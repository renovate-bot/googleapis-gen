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

require "google/cloud/gaming/v1beta"
require "google/cloud/gaming/v1beta/game_server_configs_service_client"
require "google/cloud/gaming/v1beta/game_server_configs_service_services_pb"
require "google/longrunning/operations_pb"

class CustomTestError_v1beta < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v1beta

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

class MockGameServerConfigsServiceCredentials_v1beta < Google::Cloud::Gaming::V1beta::Credentials
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

describe Google::Cloud::Gaming::V1beta::GameServerConfigsServiceClient do

  describe 'list_game_server_configs' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1beta::GameServerConfigsServiceClient#list_game_server_configs."

    it 'invokes list_game_server_configs without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Gaming::V1beta::GameServerConfigsServiceClient.game_server_deployment_path("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]")

      # Create expected grpc response
      next_page_token = ""
      game_server_configs_element = {}
      game_server_configs = [game_server_configs_element]
      expected_response = { next_page_token: next_page_token, game_server_configs: game_server_configs }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gaming::V1beta::ListGameServerConfigsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::ListGameServerConfigsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:list_game_server_configs, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerConfigsServiceCredentials_v1beta.new("list_game_server_configs")

      Google::Cloud::Gaming::V1beta::GameServerConfigsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerConfigs.new

          # Call method
          response = client.list_game_server_configs(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.game_server_configs.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_game_server_configs with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Gaming::V1beta::GameServerConfigsServiceClient.game_server_deployment_path("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::ListGameServerConfigsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:list_game_server_configs, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerConfigsServiceCredentials_v1beta.new("list_game_server_configs")

      Google::Cloud::Gaming::V1beta::GameServerConfigsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerConfigs.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.list_game_server_configs(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_game_server_config' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1beta::GameServerConfigsServiceClient#get_game_server_config."

    it 'invokes get_game_server_config without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Gaming::V1beta::GameServerConfigsServiceClient.game_server_config_path("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      description = "description-1724546052"
      expected_response = { name: name_2, description: description }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gaming::V1beta::GameServerConfig)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::GetGameServerConfigRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:get_game_server_config, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerConfigsServiceCredentials_v1beta.new("get_game_server_config")

      Google::Cloud::Gaming::V1beta::GameServerConfigsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerConfigs.new

          # Call method
          response = client.get_game_server_config(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_game_server_config(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_game_server_config with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Gaming::V1beta::GameServerConfigsServiceClient.game_server_config_path("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::GetGameServerConfigRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:get_game_server_config, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerConfigsServiceCredentials_v1beta.new("get_game_server_config")

      Google::Cloud::Gaming::V1beta::GameServerConfigsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerConfigs.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.get_game_server_config(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_game_server_config' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1beta::GameServerConfigsServiceClient#create_game_server_config."

    it 'invokes create_game_server_config without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Gaming::V1beta::GameServerConfigsServiceClient.game_server_deployment_path("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]")
      config_id = ''
      game_server_config = {}

      # Create expected grpc response
      name = "name3373707"
      description = "description-1724546052"
      expected_response = { name: name, description: description }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gaming::V1beta::GameServerConfig)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_game_server_config_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::CreateGameServerConfigRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(config_id, request.config_id)
        assert_equal(Google::Gax::to_proto(game_server_config, Google::Cloud::Gaming::V1beta::GameServerConfig), request.game_server_config)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:create_game_server_config, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerConfigsServiceCredentials_v1beta.new("create_game_server_config")

      Google::Cloud::Gaming::V1beta::GameServerConfigsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerConfigs.new

          # Call method
          response = client.create_game_server_config(
            formatted_parent,
            config_id,
            game_server_config
          )

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes create_game_server_config and returns an operation error.' do
      # Create request parameters
      formatted_parent = Google::Cloud::Gaming::V1beta::GameServerConfigsServiceClient.game_server_deployment_path("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]")
      config_id = ''
      game_server_config = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Gaming::V1beta::GameServerConfigsServiceClient#create_game_server_config.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_game_server_config_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::CreateGameServerConfigRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(config_id, request.config_id)
        assert_equal(Google::Gax::to_proto(game_server_config, Google::Cloud::Gaming::V1beta::GameServerConfig), request.game_server_config)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:create_game_server_config, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerConfigsServiceCredentials_v1beta.new("create_game_server_config")

      Google::Cloud::Gaming::V1beta::GameServerConfigsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerConfigs.new

          # Call method
          response = client.create_game_server_config(
            formatted_parent,
            config_id,
            game_server_config
          )

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes create_game_server_config with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Gaming::V1beta::GameServerConfigsServiceClient.game_server_deployment_path("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]")
      config_id = ''
      game_server_config = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::CreateGameServerConfigRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(config_id, request.config_id)
        assert_equal(Google::Gax::to_proto(game_server_config, Google::Cloud::Gaming::V1beta::GameServerConfig), request.game_server_config)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:create_game_server_config, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerConfigsServiceCredentials_v1beta.new("create_game_server_config")

      Google::Cloud::Gaming::V1beta::GameServerConfigsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerConfigs.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.create_game_server_config(
              formatted_parent,
              config_id,
              game_server_config
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_game_server_config' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1beta::GameServerConfigsServiceClient#delete_game_server_config."

    it 'invokes delete_game_server_config without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Gaming::V1beta::GameServerConfigsServiceClient.game_server_config_path("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Protobuf::Empty)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_game_server_config_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::DeleteGameServerConfigRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:delete_game_server_config, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerConfigsServiceCredentials_v1beta.new("delete_game_server_config")

      Google::Cloud::Gaming::V1beta::GameServerConfigsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerConfigs.new

          # Call method
          response = client.delete_game_server_config(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes delete_game_server_config and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Gaming::V1beta::GameServerConfigsServiceClient.game_server_config_path("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Gaming::V1beta::GameServerConfigsServiceClient#delete_game_server_config.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_game_server_config_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::DeleteGameServerConfigRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:delete_game_server_config, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerConfigsServiceCredentials_v1beta.new("delete_game_server_config")

      Google::Cloud::Gaming::V1beta::GameServerConfigsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerConfigs.new

          # Call method
          response = client.delete_game_server_config(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes delete_game_server_config with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Gaming::V1beta::GameServerConfigsServiceClient.game_server_config_path("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::DeleteGameServerConfigRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:delete_game_server_config, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerConfigsServiceCredentials_v1beta.new("delete_game_server_config")

      Google::Cloud::Gaming::V1beta::GameServerConfigsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerConfigs.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.delete_game_server_config(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end