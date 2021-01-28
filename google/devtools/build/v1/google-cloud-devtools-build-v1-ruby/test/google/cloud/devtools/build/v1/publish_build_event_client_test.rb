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

require "google/cloud/devtools/build"
require "google/cloud/devtools/build/v1/publish_build_event_client"
require "google/devtools/build/v1/publish_build_event_services_pb"

class CustomTestError_v1 < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v1

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

class MockPublishBuildEventCredentials_v1 < Google::Cloud::Devtools::Build::V1::Credentials
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

describe Google::Cloud::Devtools::Build::V1::PublishBuildEventClient do

  describe 'publish_lifecycle_event' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Devtools::Build::V1::PublishBuildEventClient#publish_lifecycle_event."

    it 'invokes publish_lifecycle_event without error' do
      # Create request parameters
      build_event = {}
      project_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Devtools::Build::V1::PublishLifecycleEventRequest, request)
        assert_equal(Google::Gax::to_proto(build_event, Google::Devtools::Build::V1::OrderedBuildEvent), request.build_event)
        assert_equal(project_id, request.project_id)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:publish_lifecycle_event, mock_method)

      # Mock auth layer
      mock_credentials = MockPublishBuildEventCredentials_v1.new("publish_lifecycle_event")

      Google::Devtools::Build::V1::PublishBuildEvent::Stub.stub(:new, mock_stub) do
        Google::Cloud::Devtools::Build::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Devtools::Build.new(version: :v1)

          # Call method
          response = client.publish_lifecycle_event(build_event, project_id)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.publish_lifecycle_event(build_event, project_id) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes publish_lifecycle_event with error' do
      # Create request parameters
      build_event = {}
      project_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Devtools::Build::V1::PublishLifecycleEventRequest, request)
        assert_equal(Google::Gax::to_proto(build_event, Google::Devtools::Build::V1::OrderedBuildEvent), request.build_event)
        assert_equal(project_id, request.project_id)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:publish_lifecycle_event, mock_method)

      # Mock auth layer
      mock_credentials = MockPublishBuildEventCredentials_v1.new("publish_lifecycle_event")

      Google::Devtools::Build::V1::PublishBuildEvent::Stub.stub(:new, mock_stub) do
        Google::Cloud::Devtools::Build::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Devtools::Build.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.publish_lifecycle_event(build_event, project_id)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'publish_build_tool_event_stream' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Devtools::Build::V1::PublishBuildEventClient#publish_build_tool_event_stream."

    it 'invokes publish_build_tool_event_stream without error' do
      # Create request parameters
      ordered_build_event = {}
      project_id = ''
      request = { ordered_build_event: ordered_build_event, project_id: project_id }

      # Create expected grpc response
      sequence_number = 1309190777
      expected_response = { sequence_number: sequence_number }
      expected_response = Google::Gax::to_proto(expected_response, Google::Devtools::Build::V1::PublishBuildToolEventStreamResponse)

      # Mock Grpc layer
      mock_method = proc do |requests|
        request = requests.first
        assert_instance_of(Google::Devtools::Build::V1::PublishBuildToolEventStreamRequest, request)
        assert_equal(Google::Gax::to_proto(ordered_build_event, Google::Devtools::Build::V1::OrderedBuildEvent), request.ordered_build_event)
        assert_equal(project_id, request.project_id)
        OpenStruct.new(execute: [expected_response])
      end
      mock_stub = MockGrpcClientStub_v1.new(:publish_build_tool_event_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockPublishBuildEventCredentials_v1.new("publish_build_tool_event_stream")

      Google::Devtools::Build::V1::PublishBuildEvent::Stub.stub(:new, mock_stub) do
        Google::Cloud::Devtools::Build::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Devtools::Build.new(version: :v1)

          # Call method
          response = client.publish_build_tool_event_stream([request])

          # Verify the response
          assert_equal(1, response.count)
          assert_equal(expected_response, response.first)
        end
      end
    end

    it 'invokes publish_build_tool_event_stream with error' do
      # Create request parameters
      ordered_build_event = {}
      project_id = ''
      request = { ordered_build_event: ordered_build_event, project_id: project_id }

      # Mock Grpc layer
      mock_method = proc do |requests|
        request = requests.first
        assert_instance_of(Google::Devtools::Build::V1::PublishBuildToolEventStreamRequest, request)
        assert_equal(Google::Gax::to_proto(ordered_build_event, Google::Devtools::Build::V1::OrderedBuildEvent), request.ordered_build_event)
        assert_equal(project_id, request.project_id)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:publish_build_tool_event_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockPublishBuildEventCredentials_v1.new("publish_build_tool_event_stream")

      Google::Devtools::Build::V1::PublishBuildEvent::Stub.stub(:new, mock_stub) do
        Google::Cloud::Devtools::Build::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Devtools::Build.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.publish_build_tool_event_stream([request])
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end