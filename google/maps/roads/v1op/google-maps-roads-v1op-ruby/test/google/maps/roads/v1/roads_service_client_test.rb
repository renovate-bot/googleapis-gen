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

require "google/maps/roads"
require "google/maps/roads/v1/roads_service_client"
require "google/maps/roads/v1op/roads_services_pb"

class CustomTestError_v1op < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v1op

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

class MockRoadsServiceCredentials_v1 < Google::Maps::Roads::V1::Credentials
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

describe Google::Maps::Roads::V1::RoadsServiceClient do

  describe 'snap_to_roads' do
    custom_error = CustomTestError_v1op.new "Custom test error for Google::Maps::Roads::V1::RoadsServiceClient#snap_to_roads."

    it 'invokes snap_to_roads without error' do
      # Create request parameters
      path = ''

      # Create expected grpc response
      warning_message = "warningMessage1427438180"
      expected_response = { warning_message: warning_message }
      expected_response = Google::Gax::to_proto(expected_response, Google::Maps::Roads::V1op::SnapToRoadsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Maps::Roads::V1op::SnapToRoadsRequest, request)
        assert_equal(path, request.path)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1op.new(:snap_to_roads, mock_method)

      # Mock auth layer
      mock_credentials = MockRoadsServiceCredentials_v1.new("snap_to_roads")

      Google::Maps::Roads::V1op::RoadsService::Stub.stub(:new, mock_stub) do
        Google::Maps::Roads::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Maps::Roads.new(version: :v1op)

          # Call method
          response = client.snap_to_roads(path)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.snap_to_roads(path) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes snap_to_roads with error' do
      # Create request parameters
      path = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Maps::Roads::V1op::SnapToRoadsRequest, request)
        assert_equal(path, request.path)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1op.new(:snap_to_roads, mock_method)

      # Mock auth layer
      mock_credentials = MockRoadsServiceCredentials_v1.new("snap_to_roads")

      Google::Maps::Roads::V1op::RoadsService::Stub.stub(:new, mock_stub) do
        Google::Maps::Roads::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Maps::Roads.new(version: :v1op)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1op do
            client.snap_to_roads(path)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_nearest_roads' do
    custom_error = CustomTestError_v1op.new "Custom test error for Google::Maps::Roads::V1::RoadsServiceClient#list_nearest_roads."

    it 'invokes list_nearest_roads without error' do
      # Create request parameters
      points = ''

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Maps::Roads::V1op::ListNearestRoadsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Maps::Roads::V1op::ListNearestRoadsRequest, request)
        assert_equal(points, request.points)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1op.new(:list_nearest_roads, mock_method)

      # Mock auth layer
      mock_credentials = MockRoadsServiceCredentials_v1.new("list_nearest_roads")

      Google::Maps::Roads::V1op::RoadsService::Stub.stub(:new, mock_stub) do
        Google::Maps::Roads::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Maps::Roads.new(version: :v1op)

          # Call method
          response = client.list_nearest_roads(points)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.list_nearest_roads(points) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes list_nearest_roads with error' do
      # Create request parameters
      points = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Maps::Roads::V1op::ListNearestRoadsRequest, request)
        assert_equal(points, request.points)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1op.new(:list_nearest_roads, mock_method)

      # Mock auth layer
      mock_credentials = MockRoadsServiceCredentials_v1.new("list_nearest_roads")

      Google::Maps::Roads::V1op::RoadsService::Stub.stub(:new, mock_stub) do
        Google::Maps::Roads::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Maps::Roads.new(version: :v1op)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1op do
            client.list_nearest_roads(points)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end