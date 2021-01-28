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

require "google/home/graph"
require "google/home/graph/v1/home_graph_api_service_client"
require "google/home/graph/v1/homegraph_services_pb"

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

class MockHomeGraphApiServiceCredentials_v1 < Google::Home::Graph::V1::Credentials
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

describe Google::Home::Graph::V1::HomeGraphApiServiceClient do

  describe 'request_sync_devices' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Home::Graph::V1::HomeGraphApiServiceClient#request_sync_devices."

    it 'invokes request_sync_devices without error' do
      # Create request parameters
      agent_user_id = ''

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Home::Graph::V1::RequestSyncDevicesResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Home::Graph::V1::RequestSyncDevicesRequest, request)
        assert_equal(agent_user_id, request.agent_user_id)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:request_sync_devices, mock_method)

      # Mock auth layer
      mock_credentials = MockHomeGraphApiServiceCredentials_v1.new("request_sync_devices")

      Google::Home::Graph::V1::HomeGraphApiService::Stub.stub(:new, mock_stub) do
        Google::Home::Graph::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Home::Graph.new(version: :v1)

          # Call method
          response = client.request_sync_devices(agent_user_id)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.request_sync_devices(agent_user_id) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes request_sync_devices with error' do
      # Create request parameters
      agent_user_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Home::Graph::V1::RequestSyncDevicesRequest, request)
        assert_equal(agent_user_id, request.agent_user_id)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:request_sync_devices, mock_method)

      # Mock auth layer
      mock_credentials = MockHomeGraphApiServiceCredentials_v1.new("request_sync_devices")

      Google::Home::Graph::V1::HomeGraphApiService::Stub.stub(:new, mock_stub) do
        Google::Home::Graph::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Home::Graph.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.request_sync_devices(agent_user_id)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'report_state_and_notification' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Home::Graph::V1::HomeGraphApiServiceClient#report_state_and_notification."

    it 'invokes report_state_and_notification without error' do
      # Create request parameters
      agent_user_id = ''
      payload = {}

      # Create expected grpc response
      request_id = "requestId37109963"
      expected_response = { request_id: request_id }
      expected_response = Google::Gax::to_proto(expected_response, Google::Home::Graph::V1::ReportStateAndNotificationResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Home::Graph::V1::ReportStateAndNotificationRequest, request)
        assert_equal(agent_user_id, request.agent_user_id)
        assert_equal(Google::Gax::to_proto(payload, Google::Home::Graph::V1::StateAndNotificationPayload), request.payload)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:report_state_and_notification, mock_method)

      # Mock auth layer
      mock_credentials = MockHomeGraphApiServiceCredentials_v1.new("report_state_and_notification")

      Google::Home::Graph::V1::HomeGraphApiService::Stub.stub(:new, mock_stub) do
        Google::Home::Graph::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Home::Graph.new(version: :v1)

          # Call method
          response = client.report_state_and_notification(agent_user_id, payload)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.report_state_and_notification(agent_user_id, payload) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes report_state_and_notification with error' do
      # Create request parameters
      agent_user_id = ''
      payload = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Home::Graph::V1::ReportStateAndNotificationRequest, request)
        assert_equal(agent_user_id, request.agent_user_id)
        assert_equal(Google::Gax::to_proto(payload, Google::Home::Graph::V1::StateAndNotificationPayload), request.payload)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:report_state_and_notification, mock_method)

      # Mock auth layer
      mock_credentials = MockHomeGraphApiServiceCredentials_v1.new("report_state_and_notification")

      Google::Home::Graph::V1::HomeGraphApiService::Stub.stub(:new, mock_stub) do
        Google::Home::Graph::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Home::Graph.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.report_state_and_notification(agent_user_id, payload)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_agent_user' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Home::Graph::V1::HomeGraphApiServiceClient#delete_agent_user."

    it 'invokes delete_agent_user without error' do
      # Create request parameters
      formatted_agent_user_id = Google::Home::Graph::V1::HomeGraphApiServiceClient.agent_user_path_path("[AGENT_USER_PATH]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Home::Graph::V1::DeleteAgentUserRequest, request)
        assert_equal(formatted_agent_user_id, request.agent_user_id)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_agent_user, mock_method)

      # Mock auth layer
      mock_credentials = MockHomeGraphApiServiceCredentials_v1.new("delete_agent_user")

      Google::Home::Graph::V1::HomeGraphApiService::Stub.stub(:new, mock_stub) do
        Google::Home::Graph::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Home::Graph.new(version: :v1)

          # Call method
          response = client.delete_agent_user(formatted_agent_user_id)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_agent_user(formatted_agent_user_id) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_agent_user with error' do
      # Create request parameters
      formatted_agent_user_id = Google::Home::Graph::V1::HomeGraphApiServiceClient.agent_user_path_path("[AGENT_USER_PATH]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Home::Graph::V1::DeleteAgentUserRequest, request)
        assert_equal(formatted_agent_user_id, request.agent_user_id)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_agent_user, mock_method)

      # Mock auth layer
      mock_credentials = MockHomeGraphApiServiceCredentials_v1.new("delete_agent_user")

      Google::Home::Graph::V1::HomeGraphApiService::Stub.stub(:new, mock_stub) do
        Google::Home::Graph::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Home::Graph.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_agent_user(formatted_agent_user_id)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'query' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Home::Graph::V1::HomeGraphApiServiceClient#query."

    it 'invokes query without error' do
      # Create request parameters
      agent_user_id = ''
      inputs = []

      # Create expected grpc response
      request_id = "requestId37109963"
      expected_response = { request_id: request_id }
      expected_response = Google::Gax::to_proto(expected_response, Google::Home::Graph::V1::QueryResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Home::Graph::V1::QueryRequest, request)
        assert_equal(agent_user_id, request.agent_user_id)
        inputs = inputs.map do |req|
          Google::Gax::to_proto(req, Google::Home::Graph::V1::QueryRequestInput)
        end
        assert_equal(inputs, request.inputs)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:query, mock_method)

      # Mock auth layer
      mock_credentials = MockHomeGraphApiServiceCredentials_v1.new("query")

      Google::Home::Graph::V1::HomeGraphApiService::Stub.stub(:new, mock_stub) do
        Google::Home::Graph::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Home::Graph.new(version: :v1)

          # Call method
          response = client.query(agent_user_id, inputs)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.query(agent_user_id, inputs) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes query with error' do
      # Create request parameters
      agent_user_id = ''
      inputs = []

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Home::Graph::V1::QueryRequest, request)
        assert_equal(agent_user_id, request.agent_user_id)
        inputs = inputs.map do |req|
          Google::Gax::to_proto(req, Google::Home::Graph::V1::QueryRequestInput)
        end
        assert_equal(inputs, request.inputs)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:query, mock_method)

      # Mock auth layer
      mock_credentials = MockHomeGraphApiServiceCredentials_v1.new("query")

      Google::Home::Graph::V1::HomeGraphApiService::Stub.stub(:new, mock_stub) do
        Google::Home::Graph::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Home::Graph.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.query(agent_user_id, inputs)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'sync' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Home::Graph::V1::HomeGraphApiServiceClient#sync."

    it 'invokes sync without error' do
      # Create request parameters
      agent_user_id = ''

      # Create expected grpc response
      request_id = "requestId37109963"
      expected_response = { request_id: request_id }
      expected_response = Google::Gax::to_proto(expected_response, Google::Home::Graph::V1::SyncResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Home::Graph::V1::SyncRequest, request)
        assert_equal(agent_user_id, request.agent_user_id)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:sync, mock_method)

      # Mock auth layer
      mock_credentials = MockHomeGraphApiServiceCredentials_v1.new("sync")

      Google::Home::Graph::V1::HomeGraphApiService::Stub.stub(:new, mock_stub) do
        Google::Home::Graph::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Home::Graph.new(version: :v1)

          # Call method
          response = client.sync(agent_user_id)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.sync(agent_user_id) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes sync with error' do
      # Create request parameters
      agent_user_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Home::Graph::V1::SyncRequest, request)
        assert_equal(agent_user_id, request.agent_user_id)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:sync, mock_method)

      # Mock auth layer
      mock_credentials = MockHomeGraphApiServiceCredentials_v1.new("sync")

      Google::Home::Graph::V1::HomeGraphApiService::Stub.stub(:new, mock_stub) do
        Google::Home::Graph::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Home::Graph.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.sync(agent_user_id)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end