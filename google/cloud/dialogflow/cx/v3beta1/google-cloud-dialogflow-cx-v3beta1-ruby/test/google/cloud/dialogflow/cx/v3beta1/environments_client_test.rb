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

require "google/cloud/dialogflow/cx"
require "google/cloud/dialogflow/cx/v3beta1/environments_client"
require "google/cloud/dialogflow/cx/v3beta1/environment_services_pb"
require "google/longrunning/operations_pb"

class CustomTestError_v3beta1 < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v3beta1

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

class MockEnvironmentsCredentials_v3beta1 < Google::Cloud::Dialogflow::Cx::V3beta1::Credentials
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

describe Google::Cloud::Dialogflow::Cx::V3beta1::EnvironmentsClient do

  describe 'list_environments' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::EnvironmentsClient#list_environments."

    it 'invokes list_environments without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::EnvironmentsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Create expected grpc response
      next_page_token = ""
      environments_element = {}
      environments = [environments_element]
      expected_response = { next_page_token: next_page_token, environments: environments }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3beta1::ListEnvironmentsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::ListEnvironmentsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:list_environments, mock_method)

      # Mock auth layer
      mock_credentials = MockEnvironmentsCredentials_v3beta1.new("list_environments")

      Google::Cloud::Dialogflow::Cx::V3beta1::Environments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Environments.new(version: :v3beta1)

          # Call method
          response = client.list_environments(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.environments.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_environments with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::EnvironmentsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::ListEnvironmentsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:list_environments, mock_method)

      # Mock auth layer
      mock_credentials = MockEnvironmentsCredentials_v3beta1.new("list_environments")

      Google::Cloud::Dialogflow::Cx::V3beta1::Environments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Environments.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.list_environments(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_environment' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::EnvironmentsClient#get_environment."

    it 'invokes get_environment without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::EnvironmentsClient.environment_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      expected_response = {
        name: name_2,
        display_name: display_name,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3beta1::Environment)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::GetEnvironmentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:get_environment, mock_method)

      # Mock auth layer
      mock_credentials = MockEnvironmentsCredentials_v3beta1.new("get_environment")

      Google::Cloud::Dialogflow::Cx::V3beta1::Environments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Environments.new(version: :v3beta1)

          # Call method
          response = client.get_environment(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_environment(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_environment with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::EnvironmentsClient.environment_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::GetEnvironmentRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:get_environment, mock_method)

      # Mock auth layer
      mock_credentials = MockEnvironmentsCredentials_v3beta1.new("get_environment")

      Google::Cloud::Dialogflow::Cx::V3beta1::Environments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Environments.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.get_environment(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_environment' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::EnvironmentsClient#create_environment."

    it 'invokes create_environment without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::EnvironmentsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
      environment = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      expected_response = {
        name: name,
        display_name: display_name,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3beta1::Environment)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_environment_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::CreateEnvironmentRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(environment, Google::Cloud::Dialogflow::Cx::V3beta1::Environment), request.environment)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:create_environment, mock_method)

      # Mock auth layer
      mock_credentials = MockEnvironmentsCredentials_v3beta1.new("create_environment")

      Google::Cloud::Dialogflow::Cx::V3beta1::Environments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Environments.new(version: :v3beta1)

          # Call method
          response = client.create_environment(formatted_parent, environment)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes create_environment and returns an operation error.' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::EnvironmentsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
      environment = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Dialogflow::Cx::V3beta1::EnvironmentsClient#create_environment.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_environment_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::CreateEnvironmentRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(environment, Google::Cloud::Dialogflow::Cx::V3beta1::Environment), request.environment)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:create_environment, mock_method)

      # Mock auth layer
      mock_credentials = MockEnvironmentsCredentials_v3beta1.new("create_environment")

      Google::Cloud::Dialogflow::Cx::V3beta1::Environments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Environments.new(version: :v3beta1)

          # Call method
          response = client.create_environment(formatted_parent, environment)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes create_environment with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::EnvironmentsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
      environment = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::CreateEnvironmentRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(environment, Google::Cloud::Dialogflow::Cx::V3beta1::Environment), request.environment)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:create_environment, mock_method)

      # Mock auth layer
      mock_credentials = MockEnvironmentsCredentials_v3beta1.new("create_environment")

      Google::Cloud::Dialogflow::Cx::V3beta1::Environments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Environments.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.create_environment(formatted_parent, environment)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_environment' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::EnvironmentsClient#update_environment."

    it 'invokes update_environment without error' do
      # Create request parameters
      environment = {}
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      expected_response = {
        name: name,
        display_name: display_name,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3beta1::Environment)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_environment_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::UpdateEnvironmentRequest, request)
        assert_equal(Google::Gax::to_proto(environment, Google::Cloud::Dialogflow::Cx::V3beta1::Environment), request.environment)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:update_environment, mock_method)

      # Mock auth layer
      mock_credentials = MockEnvironmentsCredentials_v3beta1.new("update_environment")

      Google::Cloud::Dialogflow::Cx::V3beta1::Environments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Environments.new(version: :v3beta1)

          # Call method
          response = client.update_environment(environment, update_mask)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes update_environment and returns an operation error.' do
      # Create request parameters
      environment = {}
      update_mask = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Dialogflow::Cx::V3beta1::EnvironmentsClient#update_environment.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_environment_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::UpdateEnvironmentRequest, request)
        assert_equal(Google::Gax::to_proto(environment, Google::Cloud::Dialogflow::Cx::V3beta1::Environment), request.environment)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:update_environment, mock_method)

      # Mock auth layer
      mock_credentials = MockEnvironmentsCredentials_v3beta1.new("update_environment")

      Google::Cloud::Dialogflow::Cx::V3beta1::Environments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Environments.new(version: :v3beta1)

          # Call method
          response = client.update_environment(environment, update_mask)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes update_environment with error' do
      # Create request parameters
      environment = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::UpdateEnvironmentRequest, request)
        assert_equal(Google::Gax::to_proto(environment, Google::Cloud::Dialogflow::Cx::V3beta1::Environment), request.environment)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:update_environment, mock_method)

      # Mock auth layer
      mock_credentials = MockEnvironmentsCredentials_v3beta1.new("update_environment")

      Google::Cloud::Dialogflow::Cx::V3beta1::Environments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Environments.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.update_environment(environment, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_environment' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::EnvironmentsClient#delete_environment."

    it 'invokes delete_environment without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::EnvironmentsClient.environment_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::DeleteEnvironmentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:delete_environment, mock_method)

      # Mock auth layer
      mock_credentials = MockEnvironmentsCredentials_v3beta1.new("delete_environment")

      Google::Cloud::Dialogflow::Cx::V3beta1::Environments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Environments.new(version: :v3beta1)

          # Call method
          response = client.delete_environment(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_environment(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_environment with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::EnvironmentsClient.environment_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::DeleteEnvironmentRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:delete_environment, mock_method)

      # Mock auth layer
      mock_credentials = MockEnvironmentsCredentials_v3beta1.new("delete_environment")

      Google::Cloud::Dialogflow::Cx::V3beta1::Environments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Environments.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.delete_environment(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'lookup_environment_history' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::EnvironmentsClient#lookup_environment_history."

    it 'invokes lookup_environment_history without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::EnvironmentsClient.environment_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]")

      # Create expected grpc response
      next_page_token = ""
      environments_element = {}
      environments = [environments_element]
      expected_response = { next_page_token: next_page_token, environments: environments }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3beta1::LookupEnvironmentHistoryResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::LookupEnvironmentHistoryRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:lookup_environment_history, mock_method)

      # Mock auth layer
      mock_credentials = MockEnvironmentsCredentials_v3beta1.new("lookup_environment_history")

      Google::Cloud::Dialogflow::Cx::V3beta1::Environments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Environments.new(version: :v3beta1)

          # Call method
          response = client.lookup_environment_history(formatted_name)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.environments.to_a, response.to_a)
        end
      end
    end

    it 'invokes lookup_environment_history with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::EnvironmentsClient.environment_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::LookupEnvironmentHistoryRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:lookup_environment_history, mock_method)

      # Mock auth layer
      mock_credentials = MockEnvironmentsCredentials_v3beta1.new("lookup_environment_history")

      Google::Cloud::Dialogflow::Cx::V3beta1::Environments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Environments.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.lookup_environment_history(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end