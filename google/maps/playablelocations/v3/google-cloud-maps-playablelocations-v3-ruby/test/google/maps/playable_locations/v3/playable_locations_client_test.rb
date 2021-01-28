# Copyright 2020 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     https://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

require "minitest/autorun"
require "minitest/spec"

require "google/gax"

require "google/maps/playable_locations"
require "google/maps/playable_locations/v3/playable_locations_client"
require "google/maps/playablelocations/v3/playablelocations_services_pb"

class CustomTestError_v3 < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v3

  # @param expected_symbol [Symbol] the symbol of the grpc method to be mocked.
  # @param mock_method [Proc] The method that is being mocked.
  def initialize(expected_symbol, mock_method)
    @expected_symbol = expected_symbol
    @mock_method = mock_method
  end

  # This overrides the Object#method method to return the mocked method when the mocked method
  # is being requested. For methods that aren't being tested, this method returns a proc that
  # will raise an error when called. This is to assure that only the mocked grpc method is being
  # called.
  #
  # @param symbol [Symbol] The symbol of the method being requested.
  # @return [Proc] The proc of the requested method. If the requested method is not being mocked
  #   the proc returned will raise when called.
  def method(symbol)
    return @mock_method if symbol == @expected_symbol

    # The requested method is not being tested, raise if it called.
    proc do
      raise "The method #{symbol} was unexpectedly called during the " \
        "test for #{@expected_symbol}."
    end
  end
end

class MockPlayableLocationsCredentials_v3 < Google::Maps::PlayableLocations::V3::Credentials
  def initialize(method_name)
    @method_name = method_name
  end

  def updater_proc
    proc do
      raise "The method `#{@method_name}` was trying to make a grpc request. This should not " \
          "happen since the grpc layer is being mocked."
    end
  end
end

describe Google::Maps::PlayableLocations::V3::PlayableLocationsClient do

  describe 'sample_playable_locations' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Maps::PlayableLocations::V3::PlayableLocationsClient#sample_playable_locations."

    it 'invokes sample_playable_locations without error' do
      # Create request parameters
      area_filter = {}
      criteria = []

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Maps::Playablelocations::V3::SamplePlayableLocationsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Maps::Playablelocations::V3::SamplePlayableLocationsRequest, request)
        assert_equal(Google::Gax::to_proto(area_filter, Google::Maps::Playablelocations::V3::Sample::AreaFilter), request.area_filter)
        criteria = criteria.map do |req|
          Google::Gax::to_proto(req, Google::Maps::Playablelocations::V3::Sample::Criterion)
        end
        assert_equal(criteria, request.criteria)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3.new(:sample_playable_locations, mock_method)

      # Mock auth layer
      mock_credentials = MockPlayableLocationsCredentials_v3.new("sample_playable_locations")

      Google::Maps::Playablelocations::V3::PlayableLocations::Stub.stub(:new, mock_stub) do
        Google::Maps::PlayableLocations::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Maps::PlayableLocations.new(version: :v3)

          # Call method
          response = client.sample_playable_locations(area_filter, criteria)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.sample_playable_locations(area_filter, criteria) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes sample_playable_locations with error' do
      # Create request parameters
      area_filter = {}
      criteria = []

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Maps::Playablelocations::V3::SamplePlayableLocationsRequest, request)
        assert_equal(Google::Gax::to_proto(area_filter, Google::Maps::Playablelocations::V3::Sample::AreaFilter), request.area_filter)
        criteria = criteria.map do |req|
          Google::Gax::to_proto(req, Google::Maps::Playablelocations::V3::Sample::Criterion)
        end
        assert_equal(criteria, request.criteria)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:sample_playable_locations, mock_method)

      # Mock auth layer
      mock_credentials = MockPlayableLocationsCredentials_v3.new("sample_playable_locations")

      Google::Maps::Playablelocations::V3::PlayableLocations::Stub.stub(:new, mock_stub) do
        Google::Maps::PlayableLocations::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Maps::PlayableLocations.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.sample_playable_locations(area_filter, criteria)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'log_player_reports' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Maps::PlayableLocations::V3::PlayableLocationsClient#log_player_reports."

    it 'invokes log_player_reports without error' do
      # Create request parameters
      player_reports = []
      request_id = ''
      client_info = {}

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Maps::Playablelocations::V3::LogPlayerReportsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Maps::Playablelocations::V3::LogPlayerReportsRequest, request)
        player_reports = player_reports.map do |req|
          Google::Gax::to_proto(req, Google::Maps::Playablelocations::V3::PlayerReport)
        end
        assert_equal(player_reports, request.player_reports)
        assert_equal(request_id, request.request_id)
        assert_equal(Google::Gax::to_proto(client_info, Google::Maps::Unity::ClientInfo), request.client_info)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3.new(:log_player_reports, mock_method)

      # Mock auth layer
      mock_credentials = MockPlayableLocationsCredentials_v3.new("log_player_reports")

      Google::Maps::Playablelocations::V3::PlayableLocations::Stub.stub(:new, mock_stub) do
        Google::Maps::PlayableLocations::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Maps::PlayableLocations.new(version: :v3)

          # Call method
          response = client.log_player_reports(
            player_reports,
            request_id,
            client_info
          )

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.log_player_reports(
            player_reports,
            request_id,
            client_info
          ) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes log_player_reports with error' do
      # Create request parameters
      player_reports = []
      request_id = ''
      client_info = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Maps::Playablelocations::V3::LogPlayerReportsRequest, request)
        player_reports = player_reports.map do |req|
          Google::Gax::to_proto(req, Google::Maps::Playablelocations::V3::PlayerReport)
        end
        assert_equal(player_reports, request.player_reports)
        assert_equal(request_id, request.request_id)
        assert_equal(Google::Gax::to_proto(client_info, Google::Maps::Unity::ClientInfo), request.client_info)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:log_player_reports, mock_method)

      # Mock auth layer
      mock_credentials = MockPlayableLocationsCredentials_v3.new("log_player_reports")

      Google::Maps::Playablelocations::V3::PlayableLocations::Stub.stub(:new, mock_stub) do
        Google::Maps::PlayableLocations::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Maps::PlayableLocations.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.log_player_reports(
              player_reports,
              request_id,
              client_info
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'log_impressions' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Maps::PlayableLocations::V3::PlayableLocationsClient#log_impressions."

    it 'invokes log_impressions without error' do
      # Create request parameters
      impressions = []
      request_id = ''
      client_info = {}

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Maps::Playablelocations::V3::LogImpressionsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Maps::Playablelocations::V3::LogImpressionsRequest, request)
        impressions = impressions.map do |req|
          Google::Gax::to_proto(req, Google::Maps::Playablelocations::V3::Impression)
        end
        assert_equal(impressions, request.impressions)
        assert_equal(request_id, request.request_id)
        assert_equal(Google::Gax::to_proto(client_info, Google::Maps::Unity::ClientInfo), request.client_info)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3.new(:log_impressions, mock_method)

      # Mock auth layer
      mock_credentials = MockPlayableLocationsCredentials_v3.new("log_impressions")

      Google::Maps::Playablelocations::V3::PlayableLocations::Stub.stub(:new, mock_stub) do
        Google::Maps::PlayableLocations::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Maps::PlayableLocations.new(version: :v3)

          # Call method
          response = client.log_impressions(
            impressions,
            request_id,
            client_info
          )

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.log_impressions(
            impressions,
            request_id,
            client_info
          ) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes log_impressions with error' do
      # Create request parameters
      impressions = []
      request_id = ''
      client_info = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Maps::Playablelocations::V3::LogImpressionsRequest, request)
        impressions = impressions.map do |req|
          Google::Gax::to_proto(req, Google::Maps::Playablelocations::V3::Impression)
        end
        assert_equal(impressions, request.impressions)
        assert_equal(request_id, request.request_id)
        assert_equal(Google::Gax::to_proto(client_info, Google::Maps::Unity::ClientInfo), request.client_info)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:log_impressions, mock_method)

      # Mock auth layer
      mock_credentials = MockPlayableLocationsCredentials_v3.new("log_impressions")

      Google::Maps::Playablelocations::V3::PlayableLocations::Stub.stub(:new, mock_stub) do
        Google::Maps::PlayableLocations::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Maps::PlayableLocations.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.log_impressions(
              impressions,
              request_id,
              client_info
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end