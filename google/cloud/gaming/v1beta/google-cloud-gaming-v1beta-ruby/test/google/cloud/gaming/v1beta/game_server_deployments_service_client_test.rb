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
require "google/cloud/gaming/v1beta/game_server_deployments_service_client"
require "google/cloud/gaming/v1beta/game_server_deployments_service_services_pb"
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

class MockGameServerDeploymentsServiceCredentials_v1beta < Google::Cloud::Gaming::V1beta::Credentials
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

describe Google::Cloud::Gaming::V1beta::GameServerDeploymentsServiceClient do

  describe 'list_game_server_deployments' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1beta::GameServerDeploymentsServiceClient#list_game_server_deployments."

    it 'invokes list_game_server_deployments without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Gaming::V1beta::GameServerDeploymentsServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      game_server_deployments_element = {}
      game_server_deployments = [game_server_deployments_element]
      expected_response = { next_page_token: next_page_token, game_server_deployments: game_server_deployments }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gaming::V1beta::ListGameServerDeploymentsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::ListGameServerDeploymentsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:list_game_server_deployments, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerDeploymentsServiceCredentials_v1beta.new("list_game_server_deployments")

      Google::Cloud::Gaming::V1beta::GameServerDeploymentsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerDeployments.new

          # Call method
          response = client.list_game_server_deployments(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.game_server_deployments.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_game_server_deployments with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Gaming::V1beta::GameServerDeploymentsServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::ListGameServerDeploymentsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:list_game_server_deployments, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerDeploymentsServiceCredentials_v1beta.new("list_game_server_deployments")

      Google::Cloud::Gaming::V1beta::GameServerDeploymentsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerDeployments.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.list_game_server_deployments(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_game_server_deployment' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1beta::GameServerDeploymentsServiceClient#get_game_server_deployment."

    it 'invokes get_game_server_deployment without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Gaming::V1beta::GameServerDeploymentsServiceClient.game_server_deployment_path("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      etag = "etag3123477"
      description = "description-1724546052"
      expected_response = {
        name: name_2,
        etag: etag,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gaming::V1beta::GameServerDeployment)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::GetGameServerDeploymentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:get_game_server_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerDeploymentsServiceCredentials_v1beta.new("get_game_server_deployment")

      Google::Cloud::Gaming::V1beta::GameServerDeploymentsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerDeployments.new

          # Call method
          response = client.get_game_server_deployment(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_game_server_deployment(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_game_server_deployment with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Gaming::V1beta::GameServerDeploymentsServiceClient.game_server_deployment_path("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::GetGameServerDeploymentRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:get_game_server_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerDeploymentsServiceCredentials_v1beta.new("get_game_server_deployment")

      Google::Cloud::Gaming::V1beta::GameServerDeploymentsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerDeployments.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.get_game_server_deployment(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_game_server_deployment' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1beta::GameServerDeploymentsServiceClient#create_game_server_deployment."

    it 'invokes create_game_server_deployment without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Gaming::V1beta::GameServerDeploymentsServiceClient.location_path("[PROJECT]", "[LOCATION]")
      deployment_id = ''
      game_server_deployment = {}

      # Create expected grpc response
      name = "name3373707"
      etag = "etag3123477"
      description = "description-1724546052"
      expected_response = {
        name: name,
        etag: etag,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gaming::V1beta::GameServerDeployment)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_game_server_deployment_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::CreateGameServerDeploymentRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(deployment_id, request.deployment_id)
        assert_equal(Google::Gax::to_proto(game_server_deployment, Google::Cloud::Gaming::V1beta::GameServerDeployment), request.game_server_deployment)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:create_game_server_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerDeploymentsServiceCredentials_v1beta.new("create_game_server_deployment")

      Google::Cloud::Gaming::V1beta::GameServerDeploymentsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerDeployments.new

          # Call method
          response = client.create_game_server_deployment(
            formatted_parent,
            deployment_id,
            game_server_deployment
          )

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes create_game_server_deployment and returns an operation error.' do
      # Create request parameters
      formatted_parent = Google::Cloud::Gaming::V1beta::GameServerDeploymentsServiceClient.location_path("[PROJECT]", "[LOCATION]")
      deployment_id = ''
      game_server_deployment = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Gaming::V1beta::GameServerDeploymentsServiceClient#create_game_server_deployment.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_game_server_deployment_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::CreateGameServerDeploymentRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(deployment_id, request.deployment_id)
        assert_equal(Google::Gax::to_proto(game_server_deployment, Google::Cloud::Gaming::V1beta::GameServerDeployment), request.game_server_deployment)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:create_game_server_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerDeploymentsServiceCredentials_v1beta.new("create_game_server_deployment")

      Google::Cloud::Gaming::V1beta::GameServerDeploymentsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerDeployments.new

          # Call method
          response = client.create_game_server_deployment(
            formatted_parent,
            deployment_id,
            game_server_deployment
          )

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes create_game_server_deployment with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Gaming::V1beta::GameServerDeploymentsServiceClient.location_path("[PROJECT]", "[LOCATION]")
      deployment_id = ''
      game_server_deployment = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::CreateGameServerDeploymentRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(deployment_id, request.deployment_id)
        assert_equal(Google::Gax::to_proto(game_server_deployment, Google::Cloud::Gaming::V1beta::GameServerDeployment), request.game_server_deployment)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:create_game_server_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerDeploymentsServiceCredentials_v1beta.new("create_game_server_deployment")

      Google::Cloud::Gaming::V1beta::GameServerDeploymentsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerDeployments.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.create_game_server_deployment(
              formatted_parent,
              deployment_id,
              game_server_deployment
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_game_server_deployment' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1beta::GameServerDeploymentsServiceClient#delete_game_server_deployment."

    it 'invokes delete_game_server_deployment without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Gaming::V1beta::GameServerDeploymentsServiceClient.game_server_deployment_path("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Protobuf::Empty)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_game_server_deployment_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::DeleteGameServerDeploymentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:delete_game_server_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerDeploymentsServiceCredentials_v1beta.new("delete_game_server_deployment")

      Google::Cloud::Gaming::V1beta::GameServerDeploymentsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerDeployments.new

          # Call method
          response = client.delete_game_server_deployment(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes delete_game_server_deployment and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Gaming::V1beta::GameServerDeploymentsServiceClient.game_server_deployment_path("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Gaming::V1beta::GameServerDeploymentsServiceClient#delete_game_server_deployment.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_game_server_deployment_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::DeleteGameServerDeploymentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:delete_game_server_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerDeploymentsServiceCredentials_v1beta.new("delete_game_server_deployment")

      Google::Cloud::Gaming::V1beta::GameServerDeploymentsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerDeployments.new

          # Call method
          response = client.delete_game_server_deployment(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes delete_game_server_deployment with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Gaming::V1beta::GameServerDeploymentsServiceClient.game_server_deployment_path("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::DeleteGameServerDeploymentRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:delete_game_server_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerDeploymentsServiceCredentials_v1beta.new("delete_game_server_deployment")

      Google::Cloud::Gaming::V1beta::GameServerDeploymentsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerDeployments.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.delete_game_server_deployment(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_game_server_deployment' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1beta::GameServerDeploymentsServiceClient#update_game_server_deployment."

    it 'invokes update_game_server_deployment without error' do
      # Create request parameters
      game_server_deployment = {}
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      etag = "etag3123477"
      description = "description-1724546052"
      expected_response = {
        name: name,
        etag: etag,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gaming::V1beta::GameServerDeployment)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_game_server_deployment_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::UpdateGameServerDeploymentRequest, request)
        assert_equal(Google::Gax::to_proto(game_server_deployment, Google::Cloud::Gaming::V1beta::GameServerDeployment), request.game_server_deployment)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:update_game_server_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerDeploymentsServiceCredentials_v1beta.new("update_game_server_deployment")

      Google::Cloud::Gaming::V1beta::GameServerDeploymentsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerDeployments.new

          # Call method
          response = client.update_game_server_deployment(game_server_deployment, update_mask)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes update_game_server_deployment and returns an operation error.' do
      # Create request parameters
      game_server_deployment = {}
      update_mask = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Gaming::V1beta::GameServerDeploymentsServiceClient#update_game_server_deployment.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_game_server_deployment_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::UpdateGameServerDeploymentRequest, request)
        assert_equal(Google::Gax::to_proto(game_server_deployment, Google::Cloud::Gaming::V1beta::GameServerDeployment), request.game_server_deployment)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:update_game_server_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerDeploymentsServiceCredentials_v1beta.new("update_game_server_deployment")

      Google::Cloud::Gaming::V1beta::GameServerDeploymentsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerDeployments.new

          # Call method
          response = client.update_game_server_deployment(game_server_deployment, update_mask)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes update_game_server_deployment with error' do
      # Create request parameters
      game_server_deployment = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::UpdateGameServerDeploymentRequest, request)
        assert_equal(Google::Gax::to_proto(game_server_deployment, Google::Cloud::Gaming::V1beta::GameServerDeployment), request.game_server_deployment)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:update_game_server_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerDeploymentsServiceCredentials_v1beta.new("update_game_server_deployment")

      Google::Cloud::Gaming::V1beta::GameServerDeploymentsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerDeployments.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.update_game_server_deployment(game_server_deployment, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_game_server_deployment_rollout' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1beta::GameServerDeploymentsServiceClient#get_game_server_deployment_rollout."

    it 'invokes get_game_server_deployment_rollout without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Gaming::V1beta::GameServerDeploymentsServiceClient.game_server_deployment_path("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      default_game_server_config = "defaultGameServerConfig-1758159633"
      etag = "etag3123477"
      expected_response = {
        name: name_2,
        default_game_server_config: default_game_server_config,
        etag: etag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gaming::V1beta::GameServerDeploymentRollout)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::GetGameServerDeploymentRolloutRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:get_game_server_deployment_rollout, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerDeploymentsServiceCredentials_v1beta.new("get_game_server_deployment_rollout")

      Google::Cloud::Gaming::V1beta::GameServerDeploymentsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerDeployments.new

          # Call method
          response = client.get_game_server_deployment_rollout(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_game_server_deployment_rollout(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_game_server_deployment_rollout with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Gaming::V1beta::GameServerDeploymentsServiceClient.game_server_deployment_path("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::GetGameServerDeploymentRolloutRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:get_game_server_deployment_rollout, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerDeploymentsServiceCredentials_v1beta.new("get_game_server_deployment_rollout")

      Google::Cloud::Gaming::V1beta::GameServerDeploymentsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerDeployments.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.get_game_server_deployment_rollout(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_game_server_deployment_rollout' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1beta::GameServerDeploymentsServiceClient#update_game_server_deployment_rollout."

    it 'invokes update_game_server_deployment_rollout without error' do
      # Create request parameters
      rollout = {}
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      etag = "etag3123477"
      description = "description-1724546052"
      expected_response = {
        name: name,
        etag: etag,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gaming::V1beta::GameServerDeployment)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_game_server_deployment_rollout_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::UpdateGameServerDeploymentRolloutRequest, request)
        assert_equal(Google::Gax::to_proto(rollout, Google::Cloud::Gaming::V1beta::GameServerDeploymentRollout), request.rollout)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:update_game_server_deployment_rollout, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerDeploymentsServiceCredentials_v1beta.new("update_game_server_deployment_rollout")

      Google::Cloud::Gaming::V1beta::GameServerDeploymentsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerDeployments.new

          # Call method
          response = client.update_game_server_deployment_rollout(rollout, update_mask)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes update_game_server_deployment_rollout and returns an operation error.' do
      # Create request parameters
      rollout = {}
      update_mask = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Gaming::V1beta::GameServerDeploymentsServiceClient#update_game_server_deployment_rollout.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_game_server_deployment_rollout_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::UpdateGameServerDeploymentRolloutRequest, request)
        assert_equal(Google::Gax::to_proto(rollout, Google::Cloud::Gaming::V1beta::GameServerDeploymentRollout), request.rollout)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:update_game_server_deployment_rollout, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerDeploymentsServiceCredentials_v1beta.new("update_game_server_deployment_rollout")

      Google::Cloud::Gaming::V1beta::GameServerDeploymentsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerDeployments.new

          # Call method
          response = client.update_game_server_deployment_rollout(rollout, update_mask)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes update_game_server_deployment_rollout with error' do
      # Create request parameters
      rollout = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::UpdateGameServerDeploymentRolloutRequest, request)
        assert_equal(Google::Gax::to_proto(rollout, Google::Cloud::Gaming::V1beta::GameServerDeploymentRollout), request.rollout)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:update_game_server_deployment_rollout, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerDeploymentsServiceCredentials_v1beta.new("update_game_server_deployment_rollout")

      Google::Cloud::Gaming::V1beta::GameServerDeploymentsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerDeployments.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.update_game_server_deployment_rollout(rollout, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'preview_game_server_deployment_rollout' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1beta::GameServerDeploymentsServiceClient#preview_game_server_deployment_rollout."

    it 'invokes preview_game_server_deployment_rollout without error' do
      # Create request parameters
      rollout = {}

      # Create expected grpc response
      etag = "etag3123477"
      expected_response = { etag: etag }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gaming::V1beta::PreviewGameServerDeploymentRolloutResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::PreviewGameServerDeploymentRolloutRequest, request)
        assert_equal(Google::Gax::to_proto(rollout, Google::Cloud::Gaming::V1beta::GameServerDeploymentRollout), request.rollout)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:preview_game_server_deployment_rollout, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerDeploymentsServiceCredentials_v1beta.new("preview_game_server_deployment_rollout")

      Google::Cloud::Gaming::V1beta::GameServerDeploymentsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerDeployments.new

          # Call method
          response = client.preview_game_server_deployment_rollout(rollout)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.preview_game_server_deployment_rollout(rollout) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes preview_game_server_deployment_rollout with error' do
      # Create request parameters
      rollout = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::PreviewGameServerDeploymentRolloutRequest, request)
        assert_equal(Google::Gax::to_proto(rollout, Google::Cloud::Gaming::V1beta::GameServerDeploymentRollout), request.rollout)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:preview_game_server_deployment_rollout, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerDeploymentsServiceCredentials_v1beta.new("preview_game_server_deployment_rollout")

      Google::Cloud::Gaming::V1beta::GameServerDeploymentsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerDeployments.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.preview_game_server_deployment_rollout(rollout)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'fetch_deployment_state' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1beta::GameServerDeploymentsServiceClient#fetch_deployment_state."

    it 'invokes fetch_deployment_state without error' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gaming::V1beta::FetchDeploymentStateResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::FetchDeploymentStateRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:fetch_deployment_state, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerDeploymentsServiceCredentials_v1beta.new("fetch_deployment_state")

      Google::Cloud::Gaming::V1beta::GameServerDeploymentsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerDeployments.new

          # Call method
          response = client.fetch_deployment_state(name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.fetch_deployment_state(name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes fetch_deployment_state with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::FetchDeploymentStateRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:fetch_deployment_state, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerDeploymentsServiceCredentials_v1beta.new("fetch_deployment_state")

      Google::Cloud::Gaming::V1beta::GameServerDeploymentsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1beta::GameServerDeployments.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.fetch_deployment_state(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end