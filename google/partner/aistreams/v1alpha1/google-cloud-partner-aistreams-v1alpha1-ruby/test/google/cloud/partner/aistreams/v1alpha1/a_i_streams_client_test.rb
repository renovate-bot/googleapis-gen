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

require "google/cloud/partner/aistreams"
require "google/cloud/partner/aistreams/v1alpha1/a_i_streams_client"
require "google/partner/aistreams/v1alpha1/aistreams_services_pb"
require "google/longrunning/operations_pb"

class CustomTestError_v1alpha1 < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v1alpha1

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

class MockAIStreamsCredentials_v1alpha1 < Google::Cloud::Partner::Aistreams::V1alpha1::Credentials
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

describe Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient do

  describe 'list_clusters' do
    custom_error = CustomTestError_v1alpha1.new "Custom test error for Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient#list_clusters."

    it 'invokes list_clusters without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      clusters_element = {}
      clusters = [clusters_element]
      expected_response = { next_page_token: next_page_token, clusters: clusters }
      expected_response = Google::Gax::to_proto(expected_response, Google::Partner::Aistreams::V1alpha1::ListClustersResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Partner::Aistreams::V1alpha1::ListClustersRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:list_clusters, mock_method)

      # Mock auth layer
      mock_credentials = MockAIStreamsCredentials_v1alpha1.new("list_clusters")

      Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.stub(:new, mock_stub) do
        Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)

          # Call method
          response = client.list_clusters(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.clusters.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_clusters with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Partner::Aistreams::V1alpha1::ListClustersRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:list_clusters, mock_method)

      # Mock auth layer
      mock_credentials = MockAIStreamsCredentials_v1alpha1.new("list_clusters")

      Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.stub(:new, mock_stub) do
        Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha1 do
            client.list_clusters(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_cluster' do
    custom_error = CustomTestError_v1alpha1.new "Custom test error for Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient#get_cluster."

    it 'invokes get_cluster without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.cluster_path("[PROJECT]", "[LOCATION]", "[CLUSTER]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      certificate = "certificate1952399767"
      service_endpoint = "serviceEndpoint-676052001"
      expected_response = {
        name: name_2,
        certificate: certificate,
        service_endpoint: service_endpoint
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Partner::Aistreams::V1alpha1::Cluster)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Partner::Aistreams::V1alpha1::GetClusterRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:get_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockAIStreamsCredentials_v1alpha1.new("get_cluster")

      Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.stub(:new, mock_stub) do
        Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)

          # Call method
          response = client.get_cluster(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_cluster(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_cluster with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.cluster_path("[PROJECT]", "[LOCATION]", "[CLUSTER]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Partner::Aistreams::V1alpha1::GetClusterRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:get_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockAIStreamsCredentials_v1alpha1.new("get_cluster")

      Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.stub(:new, mock_stub) do
        Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha1 do
            client.get_cluster(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_cluster' do
    custom_error = CustomTestError_v1alpha1.new "Custom test error for Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient#create_cluster."

    it 'invokes create_cluster without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.location_path("[PROJECT]", "[LOCATION]")
      cluster_id = ''
      cluster = {}

      # Create expected grpc response
      name = "name3373707"
      certificate = "certificate1952399767"
      service_endpoint = "serviceEndpoint-676052001"
      expected_response = {
        name: name,
        certificate: certificate,
        service_endpoint: service_endpoint
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Partner::Aistreams::V1alpha1::Cluster)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_cluster_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Partner::Aistreams::V1alpha1::CreateClusterRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(cluster_id, request.cluster_id)
        assert_equal(Google::Gax::to_proto(cluster, Google::Partner::Aistreams::V1alpha1::Cluster), request.cluster)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:create_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockAIStreamsCredentials_v1alpha1.new("create_cluster")

      Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.stub(:new, mock_stub) do
        Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)

          # Call method
          response = client.create_cluster(
            formatted_parent,
            cluster_id,
            cluster
          )

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes create_cluster and returns an operation error.' do
      # Create request parameters
      formatted_parent = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.location_path("[PROJECT]", "[LOCATION]")
      cluster_id = ''
      cluster = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient#create_cluster.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_cluster_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Partner::Aistreams::V1alpha1::CreateClusterRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(cluster_id, request.cluster_id)
        assert_equal(Google::Gax::to_proto(cluster, Google::Partner::Aistreams::V1alpha1::Cluster), request.cluster)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:create_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockAIStreamsCredentials_v1alpha1.new("create_cluster")

      Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.stub(:new, mock_stub) do
        Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)

          # Call method
          response = client.create_cluster(
            formatted_parent,
            cluster_id,
            cluster
          )

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes create_cluster with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.location_path("[PROJECT]", "[LOCATION]")
      cluster_id = ''
      cluster = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Partner::Aistreams::V1alpha1::CreateClusterRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(cluster_id, request.cluster_id)
        assert_equal(Google::Gax::to_proto(cluster, Google::Partner::Aistreams::V1alpha1::Cluster), request.cluster)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:create_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockAIStreamsCredentials_v1alpha1.new("create_cluster")

      Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.stub(:new, mock_stub) do
        Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha1 do
            client.create_cluster(
              formatted_parent,
              cluster_id,
              cluster
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_cluster' do
    custom_error = CustomTestError_v1alpha1.new "Custom test error for Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient#update_cluster."

    it 'invokes update_cluster without error' do
      # Create request parameters
      update_mask = {}
      cluster = {}

      # Create expected grpc response
      name = "name3373707"
      certificate = "certificate1952399767"
      service_endpoint = "serviceEndpoint-676052001"
      expected_response = {
        name: name,
        certificate: certificate,
        service_endpoint: service_endpoint
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Partner::Aistreams::V1alpha1::Cluster)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_cluster_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Partner::Aistreams::V1alpha1::UpdateClusterRequest, request)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        assert_equal(Google::Gax::to_proto(cluster, Google::Partner::Aistreams::V1alpha1::Cluster), request.cluster)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:update_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockAIStreamsCredentials_v1alpha1.new("update_cluster")

      Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.stub(:new, mock_stub) do
        Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)

          # Call method
          response = client.update_cluster(update_mask, cluster)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes update_cluster and returns an operation error.' do
      # Create request parameters
      update_mask = {}
      cluster = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient#update_cluster.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_cluster_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Partner::Aistreams::V1alpha1::UpdateClusterRequest, request)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        assert_equal(Google::Gax::to_proto(cluster, Google::Partner::Aistreams::V1alpha1::Cluster), request.cluster)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:update_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockAIStreamsCredentials_v1alpha1.new("update_cluster")

      Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.stub(:new, mock_stub) do
        Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)

          # Call method
          response = client.update_cluster(update_mask, cluster)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes update_cluster with error' do
      # Create request parameters
      update_mask = {}
      cluster = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Partner::Aistreams::V1alpha1::UpdateClusterRequest, request)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        assert_equal(Google::Gax::to_proto(cluster, Google::Partner::Aistreams::V1alpha1::Cluster), request.cluster)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:update_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockAIStreamsCredentials_v1alpha1.new("update_cluster")

      Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.stub(:new, mock_stub) do
        Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha1 do
            client.update_cluster(update_mask, cluster)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_cluster' do
    custom_error = CustomTestError_v1alpha1.new "Custom test error for Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient#delete_cluster."

    it 'invokes delete_cluster without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.cluster_path("[PROJECT]", "[LOCATION]", "[CLUSTER]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Protobuf::Empty)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_cluster_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Partner::Aistreams::V1alpha1::DeleteClusterRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:delete_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockAIStreamsCredentials_v1alpha1.new("delete_cluster")

      Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.stub(:new, mock_stub) do
        Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)

          # Call method
          response = client.delete_cluster(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes delete_cluster and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.cluster_path("[PROJECT]", "[LOCATION]", "[CLUSTER]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient#delete_cluster.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_cluster_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Partner::Aistreams::V1alpha1::DeleteClusterRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:delete_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockAIStreamsCredentials_v1alpha1.new("delete_cluster")

      Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.stub(:new, mock_stub) do
        Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)

          # Call method
          response = client.delete_cluster(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes delete_cluster with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.cluster_path("[PROJECT]", "[LOCATION]", "[CLUSTER]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Partner::Aistreams::V1alpha1::DeleteClusterRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:delete_cluster, mock_method)

      # Mock auth layer
      mock_credentials = MockAIStreamsCredentials_v1alpha1.new("delete_cluster")

      Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.stub(:new, mock_stub) do
        Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha1 do
            client.delete_cluster(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_streams' do
    custom_error = CustomTestError_v1alpha1.new "Custom test error for Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient#list_streams."

    it 'invokes list_streams without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.cluster_path("[PROJECT]", "[LOCATION]", "[CLUSTER]")

      # Create expected grpc response
      next_page_token = ""
      streams_element = {}
      streams = [streams_element]
      expected_response = { next_page_token: next_page_token, streams: streams }
      expected_response = Google::Gax::to_proto(expected_response, Google::Partner::Aistreams::V1alpha1::ListStreamsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Partner::Aistreams::V1alpha1::ListStreamsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:list_streams, mock_method)

      # Mock auth layer
      mock_credentials = MockAIStreamsCredentials_v1alpha1.new("list_streams")

      Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.stub(:new, mock_stub) do
        Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)

          # Call method
          response = client.list_streams(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.streams.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_streams with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.cluster_path("[PROJECT]", "[LOCATION]", "[CLUSTER]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Partner::Aistreams::V1alpha1::ListStreamsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:list_streams, mock_method)

      # Mock auth layer
      mock_credentials = MockAIStreamsCredentials_v1alpha1.new("list_streams")

      Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.stub(:new, mock_stub) do
        Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha1 do
            client.list_streams(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_stream' do
    custom_error = CustomTestError_v1alpha1.new "Custom test error for Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient#get_stream."

    it 'invokes get_stream without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.stream_path("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      expected_response = { name: name_2 }
      expected_response = Google::Gax::to_proto(expected_response, Google::Partner::Aistreams::V1alpha1::Stream)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Partner::Aistreams::V1alpha1::GetStreamRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:get_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAIStreamsCredentials_v1alpha1.new("get_stream")

      Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.stub(:new, mock_stub) do
        Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)

          # Call method
          response = client.get_stream(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_stream(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_stream with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.stream_path("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Partner::Aistreams::V1alpha1::GetStreamRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:get_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAIStreamsCredentials_v1alpha1.new("get_stream")

      Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.stub(:new, mock_stub) do
        Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha1 do
            client.get_stream(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_stream' do
    custom_error = CustomTestError_v1alpha1.new "Custom test error for Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient#create_stream."

    it 'invokes create_stream without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.cluster_path("[PROJECT]", "[LOCATION]", "[CLUSTER]")
      stream_id = ''
      stream = {}

      # Create expected grpc response
      name = "name3373707"
      expected_response = { name: name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Partner::Aistreams::V1alpha1::Stream)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_stream_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Partner::Aistreams::V1alpha1::CreateStreamRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(stream_id, request.stream_id)
        assert_equal(Google::Gax::to_proto(stream, Google::Partner::Aistreams::V1alpha1::Stream), request.stream)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:create_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAIStreamsCredentials_v1alpha1.new("create_stream")

      Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.stub(:new, mock_stub) do
        Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)

          # Call method
          response = client.create_stream(
            formatted_parent,
            stream_id,
            stream
          )

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes create_stream and returns an operation error.' do
      # Create request parameters
      formatted_parent = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.cluster_path("[PROJECT]", "[LOCATION]", "[CLUSTER]")
      stream_id = ''
      stream = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient#create_stream.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_stream_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Partner::Aistreams::V1alpha1::CreateStreamRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(stream_id, request.stream_id)
        assert_equal(Google::Gax::to_proto(stream, Google::Partner::Aistreams::V1alpha1::Stream), request.stream)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:create_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAIStreamsCredentials_v1alpha1.new("create_stream")

      Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.stub(:new, mock_stub) do
        Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)

          # Call method
          response = client.create_stream(
            formatted_parent,
            stream_id,
            stream
          )

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes create_stream with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.cluster_path("[PROJECT]", "[LOCATION]", "[CLUSTER]")
      stream_id = ''
      stream = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Partner::Aistreams::V1alpha1::CreateStreamRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(stream_id, request.stream_id)
        assert_equal(Google::Gax::to_proto(stream, Google::Partner::Aistreams::V1alpha1::Stream), request.stream)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:create_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAIStreamsCredentials_v1alpha1.new("create_stream")

      Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.stub(:new, mock_stub) do
        Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha1 do
            client.create_stream(
              formatted_parent,
              stream_id,
              stream
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_stream' do
    custom_error = CustomTestError_v1alpha1.new "Custom test error for Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient#update_stream."

    it 'invokes update_stream without error' do
      # Create request parameters
      update_mask = {}
      stream = {}

      # Create expected grpc response
      name = "name3373707"
      expected_response = { name: name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Partner::Aistreams::V1alpha1::Stream)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_stream_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Partner::Aistreams::V1alpha1::UpdateStreamRequest, request)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        assert_equal(Google::Gax::to_proto(stream, Google::Partner::Aistreams::V1alpha1::Stream), request.stream)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:update_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAIStreamsCredentials_v1alpha1.new("update_stream")

      Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.stub(:new, mock_stub) do
        Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)

          # Call method
          response = client.update_stream(update_mask, stream)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes update_stream and returns an operation error.' do
      # Create request parameters
      update_mask = {}
      stream = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient#update_stream.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_stream_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Partner::Aistreams::V1alpha1::UpdateStreamRequest, request)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        assert_equal(Google::Gax::to_proto(stream, Google::Partner::Aistreams::V1alpha1::Stream), request.stream)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:update_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAIStreamsCredentials_v1alpha1.new("update_stream")

      Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.stub(:new, mock_stub) do
        Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)

          # Call method
          response = client.update_stream(update_mask, stream)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes update_stream with error' do
      # Create request parameters
      update_mask = {}
      stream = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Partner::Aistreams::V1alpha1::UpdateStreamRequest, request)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        assert_equal(Google::Gax::to_proto(stream, Google::Partner::Aistreams::V1alpha1::Stream), request.stream)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:update_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAIStreamsCredentials_v1alpha1.new("update_stream")

      Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.stub(:new, mock_stub) do
        Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha1 do
            client.update_stream(update_mask, stream)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_stream' do
    custom_error = CustomTestError_v1alpha1.new "Custom test error for Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient#delete_stream."

    it 'invokes delete_stream without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.stream_path("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Protobuf::Empty)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_stream_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Partner::Aistreams::V1alpha1::DeleteStreamRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:delete_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAIStreamsCredentials_v1alpha1.new("delete_stream")

      Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.stub(:new, mock_stub) do
        Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)

          # Call method
          response = client.delete_stream(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes delete_stream and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.stream_path("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient#delete_stream.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_stream_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Partner::Aistreams::V1alpha1::DeleteStreamRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:delete_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAIStreamsCredentials_v1alpha1.new("delete_stream")

      Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.stub(:new, mock_stub) do
        Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)

          # Call method
          response = client.delete_stream(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes delete_stream with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.stream_path("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Partner::Aistreams::V1alpha1::DeleteStreamRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:delete_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAIStreamsCredentials_v1alpha1.new("delete_stream")

      Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.stub(:new, mock_stub) do
        Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha1 do
            client.delete_stream(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end