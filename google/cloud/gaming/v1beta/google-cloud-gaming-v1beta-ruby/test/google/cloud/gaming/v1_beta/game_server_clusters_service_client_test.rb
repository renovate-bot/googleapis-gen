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

require "google/cloud/gaming/v1_beta"
require "google/cloud/gaming/v1_beta/game_server_clusters_service_client"
require "google/cloud/gaming/v1beta/game_server_clusters_service_services_pb"
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

class MockGameServerClustersServiceCredentials_v1beta < Google::Cloud::Gaming::V1Beta::Credentials
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

describe Google::Cloud::Gaming::V1Beta::GameServerClustersServiceClient do

  describe 'list_game_server_clusters' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1Beta::GameServerClustersServiceClient#list_game_server_clusters."

    it 'invokes list_game_server_clusters without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Gaming::V1Beta::GameServerClustersServiceClient.realm_path("[PROJECT]", "[LOCATION]", "[REALM]")

      # Create expected grpc response
      next_page_token = ""
      game_server_clusters_element = {}
      game_server_clusters = [game_server_clusters_element]
      expected_response = { next_page_token: next_page_token, game_server_clusters: game_server_clusters }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gaming::V1beta::ListGameServerClustersResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::ListGameServerClustersRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:list_game_server_clusters, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerClustersServiceCredentials_v1beta.new("list_game_server_clusters")

      Google::Cloud::Gaming::V1beta::GameServerClustersService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::GameServerClusters.new

          # Call method
          response = client.list_game_server_clusters(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.game_server_clusters.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_game_server_clusters with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Gaming::V1Beta::GameServerClustersServiceClient.realm_path("[PROJECT]", "[LOCATION]", "[REALM]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::ListGameServerClustersRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:list_game_server_clusters, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerClustersServiceCredentials_v1beta.new("list_game_server_clusters")

      Google::Cloud::Gaming::V1beta::GameServerClustersService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::GameServerClusters.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.list_game_server_clusters(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_game_server_cluster' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1Beta::GameServerClustersServiceClient#get_game_server_cluster."

    it 'invokes get_game_server_cluster without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Gaming::V1Beta::GameServerClustersServiceClient.game_server_cluster_path("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      etag = "etag3123477"
      description = "description-1724546052"
      expected_response = {
        name: name_2,
        etag: etag,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gaming::V1beta::GameServerCluster)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::GetGameServerClusterRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:get_game_server_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerClustersServiceCredentials_v1beta.new("get_game_server_cluster")

      Google::Cloud::Gaming::V1beta::GameServerClustersService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::GameServerClusters.new

          # Call method
          response = client.get_game_server_cluster(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_game_server_cluster(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_game_server_cluster with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Gaming::V1Beta::GameServerClustersServiceClient.game_server_cluster_path("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::GetGameServerClusterRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:get_game_server_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerClustersServiceCredentials_v1beta.new("get_game_server_cluster")

      Google::Cloud::Gaming::V1beta::GameServerClustersService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::GameServerClusters.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.get_game_server_cluster(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_game_server_cluster' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1Beta::GameServerClustersServiceClient#create_game_server_cluster."

    it 'invokes create_game_server_cluster without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Gaming::V1Beta::GameServerClustersServiceClient.realm_path("[PROJECT]", "[LOCATION]", "[REALM]")
      game_server_cluster_id = ''
      game_server_cluster = {}

      # Create expected grpc response
      name = "name3373707"
      etag = "etag3123477"
      description = "description-1724546052"
      expected_response = {
        name: name,
        etag: etag,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gaming::V1beta::GameServerCluster)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_game_server_cluster_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::CreateGameServerClusterRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(game_server_cluster_id, request.game_server_cluster_id)
        assert_equal(Google::Gax::to_proto(game_server_cluster, Google::Cloud::Gaming::V1beta::GameServerCluster), request.game_server_cluster)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:create_game_server_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerClustersServiceCredentials_v1beta.new("create_game_server_cluster")

      Google::Cloud::Gaming::V1beta::GameServerClustersService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::GameServerClusters.new

          # Call method
          response = client.create_game_server_cluster(
            formatted_parent,
            game_server_cluster_id,
            game_server_cluster
          )

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes create_game_server_cluster and returns an operation error.' do
      # Create request parameters
      formatted_parent = Google::Cloud::Gaming::V1Beta::GameServerClustersServiceClient.realm_path("[PROJECT]", "[LOCATION]", "[REALM]")
      game_server_cluster_id = ''
      game_server_cluster = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Gaming::V1Beta::GameServerClustersServiceClient#create_game_server_cluster.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_game_server_cluster_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::CreateGameServerClusterRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(game_server_cluster_id, request.game_server_cluster_id)
        assert_equal(Google::Gax::to_proto(game_server_cluster, Google::Cloud::Gaming::V1beta::GameServerCluster), request.game_server_cluster)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:create_game_server_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerClustersServiceCredentials_v1beta.new("create_game_server_cluster")

      Google::Cloud::Gaming::V1beta::GameServerClustersService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::GameServerClusters.new

          # Call method
          response = client.create_game_server_cluster(
            formatted_parent,
            game_server_cluster_id,
            game_server_cluster
          )

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes create_game_server_cluster with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Gaming::V1Beta::GameServerClustersServiceClient.realm_path("[PROJECT]", "[LOCATION]", "[REALM]")
      game_server_cluster_id = ''
      game_server_cluster = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::CreateGameServerClusterRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(game_server_cluster_id, request.game_server_cluster_id)
        assert_equal(Google::Gax::to_proto(game_server_cluster, Google::Cloud::Gaming::V1beta::GameServerCluster), request.game_server_cluster)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:create_game_server_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerClustersServiceCredentials_v1beta.new("create_game_server_cluster")

      Google::Cloud::Gaming::V1beta::GameServerClustersService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::GameServerClusters.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.create_game_server_cluster(
              formatted_parent,
              game_server_cluster_id,
              game_server_cluster
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'preview_create_game_server_cluster' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1Beta::GameServerClustersServiceClient#preview_create_game_server_cluster."

    it 'invokes preview_create_game_server_cluster without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Gaming::V1Beta::GameServerClustersServiceClient.realm_path("[PROJECT]", "[LOCATION]", "[REALM]")
      game_server_cluster_id = ''
      game_server_cluster = {}

      # Create expected grpc response
      etag = "etag3123477"
      expected_response = { etag: etag }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gaming::V1beta::PreviewCreateGameServerClusterResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::PreviewCreateGameServerClusterRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(game_server_cluster_id, request.game_server_cluster_id)
        assert_equal(Google::Gax::to_proto(game_server_cluster, Google::Cloud::Gaming::V1beta::GameServerCluster), request.game_server_cluster)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:preview_create_game_server_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerClustersServiceCredentials_v1beta.new("preview_create_game_server_cluster")

      Google::Cloud::Gaming::V1beta::GameServerClustersService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::GameServerClusters.new

          # Call method
          response = client.preview_create_game_server_cluster(
            formatted_parent,
            game_server_cluster_id,
            game_server_cluster
          )

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.preview_create_game_server_cluster(
            formatted_parent,
            game_server_cluster_id,
            game_server_cluster
          ) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes preview_create_game_server_cluster with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Gaming::V1Beta::GameServerClustersServiceClient.realm_path("[PROJECT]", "[LOCATION]", "[REALM]")
      game_server_cluster_id = ''
      game_server_cluster = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::PreviewCreateGameServerClusterRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(game_server_cluster_id, request.game_server_cluster_id)
        assert_equal(Google::Gax::to_proto(game_server_cluster, Google::Cloud::Gaming::V1beta::GameServerCluster), request.game_server_cluster)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:preview_create_game_server_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerClustersServiceCredentials_v1beta.new("preview_create_game_server_cluster")

      Google::Cloud::Gaming::V1beta::GameServerClustersService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::GameServerClusters.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.preview_create_game_server_cluster(
              formatted_parent,
              game_server_cluster_id,
              game_server_cluster
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_game_server_cluster' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1Beta::GameServerClustersServiceClient#delete_game_server_cluster."

    it 'invokes delete_game_server_cluster without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Gaming::V1Beta::GameServerClustersServiceClient.game_server_cluster_path("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Protobuf::Empty)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_game_server_cluster_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::DeleteGameServerClusterRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:delete_game_server_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerClustersServiceCredentials_v1beta.new("delete_game_server_cluster")

      Google::Cloud::Gaming::V1beta::GameServerClustersService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::GameServerClusters.new

          # Call method
          response = client.delete_game_server_cluster(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes delete_game_server_cluster and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Gaming::V1Beta::GameServerClustersServiceClient.game_server_cluster_path("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Gaming::V1Beta::GameServerClustersServiceClient#delete_game_server_cluster.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_game_server_cluster_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::DeleteGameServerClusterRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:delete_game_server_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerClustersServiceCredentials_v1beta.new("delete_game_server_cluster")

      Google::Cloud::Gaming::V1beta::GameServerClustersService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::GameServerClusters.new

          # Call method
          response = client.delete_game_server_cluster(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes delete_game_server_cluster with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Gaming::V1Beta::GameServerClustersServiceClient.game_server_cluster_path("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::DeleteGameServerClusterRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:delete_game_server_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerClustersServiceCredentials_v1beta.new("delete_game_server_cluster")

      Google::Cloud::Gaming::V1beta::GameServerClustersService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::GameServerClusters.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.delete_game_server_cluster(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'preview_delete_game_server_cluster' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1Beta::GameServerClustersServiceClient#preview_delete_game_server_cluster."

    it 'invokes preview_delete_game_server_cluster without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Gaming::V1Beta::GameServerClustersServiceClient.game_server_cluster_path("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]")

      # Create expected grpc response
      etag = "etag3123477"
      expected_response = { etag: etag }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gaming::V1beta::PreviewDeleteGameServerClusterResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::PreviewDeleteGameServerClusterRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:preview_delete_game_server_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerClustersServiceCredentials_v1beta.new("preview_delete_game_server_cluster")

      Google::Cloud::Gaming::V1beta::GameServerClustersService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::GameServerClusters.new

          # Call method
          response = client.preview_delete_game_server_cluster(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.preview_delete_game_server_cluster(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes preview_delete_game_server_cluster with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Gaming::V1Beta::GameServerClustersServiceClient.game_server_cluster_path("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::PreviewDeleteGameServerClusterRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:preview_delete_game_server_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerClustersServiceCredentials_v1beta.new("preview_delete_game_server_cluster")

      Google::Cloud::Gaming::V1beta::GameServerClustersService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::GameServerClusters.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.preview_delete_game_server_cluster(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_game_server_cluster' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1Beta::GameServerClustersServiceClient#update_game_server_cluster."

    it 'invokes update_game_server_cluster without error' do
      # Create request parameters
      game_server_cluster = {}
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
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gaming::V1beta::GameServerCluster)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_game_server_cluster_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::UpdateGameServerClusterRequest, request)
        assert_equal(Google::Gax::to_proto(game_server_cluster, Google::Cloud::Gaming::V1beta::GameServerCluster), request.game_server_cluster)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:update_game_server_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerClustersServiceCredentials_v1beta.new("update_game_server_cluster")

      Google::Cloud::Gaming::V1beta::GameServerClustersService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::GameServerClusters.new

          # Call method
          response = client.update_game_server_cluster(game_server_cluster, update_mask)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes update_game_server_cluster and returns an operation error.' do
      # Create request parameters
      game_server_cluster = {}
      update_mask = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Gaming::V1Beta::GameServerClustersServiceClient#update_game_server_cluster.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_game_server_cluster_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::UpdateGameServerClusterRequest, request)
        assert_equal(Google::Gax::to_proto(game_server_cluster, Google::Cloud::Gaming::V1beta::GameServerCluster), request.game_server_cluster)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:update_game_server_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerClustersServiceCredentials_v1beta.new("update_game_server_cluster")

      Google::Cloud::Gaming::V1beta::GameServerClustersService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::GameServerClusters.new

          # Call method
          response = client.update_game_server_cluster(game_server_cluster, update_mask)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes update_game_server_cluster with error' do
      # Create request parameters
      game_server_cluster = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::UpdateGameServerClusterRequest, request)
        assert_equal(Google::Gax::to_proto(game_server_cluster, Google::Cloud::Gaming::V1beta::GameServerCluster), request.game_server_cluster)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:update_game_server_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerClustersServiceCredentials_v1beta.new("update_game_server_cluster")

      Google::Cloud::Gaming::V1beta::GameServerClustersService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::GameServerClusters.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.update_game_server_cluster(game_server_cluster, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'preview_update_game_server_cluster' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1Beta::GameServerClustersServiceClient#preview_update_game_server_cluster."

    it 'invokes preview_update_game_server_cluster without error' do
      # Create request parameters
      game_server_cluster = {}
      update_mask = {}

      # Create expected grpc response
      etag = "etag3123477"
      expected_response = { etag: etag }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gaming::V1beta::PreviewUpdateGameServerClusterResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::PreviewUpdateGameServerClusterRequest, request)
        assert_equal(Google::Gax::to_proto(game_server_cluster, Google::Cloud::Gaming::V1beta::GameServerCluster), request.game_server_cluster)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:preview_update_game_server_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerClustersServiceCredentials_v1beta.new("preview_update_game_server_cluster")

      Google::Cloud::Gaming::V1beta::GameServerClustersService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::GameServerClusters.new

          # Call method
          response = client.preview_update_game_server_cluster(game_server_cluster, update_mask)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.preview_update_game_server_cluster(game_server_cluster, update_mask) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes preview_update_game_server_cluster with error' do
      # Create request parameters
      game_server_cluster = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::PreviewUpdateGameServerClusterRequest, request)
        assert_equal(Google::Gax::to_proto(game_server_cluster, Google::Cloud::Gaming::V1beta::GameServerCluster), request.game_server_cluster)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:preview_update_game_server_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockGameServerClustersServiceCredentials_v1beta.new("preview_update_game_server_cluster")

      Google::Cloud::Gaming::V1beta::GameServerClustersService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::GameServerClusters.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.preview_update_game_server_cluster(game_server_cluster, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end