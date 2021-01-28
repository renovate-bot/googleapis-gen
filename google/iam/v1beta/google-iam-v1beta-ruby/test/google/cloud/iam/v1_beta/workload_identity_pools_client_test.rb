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

require "google/cloud/iam/v1_beta"
require "google/cloud/iam/v1_beta/workload_identity_pools_client"
require "google/iam/v1beta/workload_identity_pool_services_pb"
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

class MockWorkloadIdentityPoolsCredentials_v1beta < Google::Cloud::Iam::V1Beta::Credentials
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

describe Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient do

  describe 'list_workload_identity_pools' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient#list_workload_identity_pools."

    it 'invokes list_workload_identity_pools without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient.project_path("[PROJECT]")

      # Create expected grpc response
      next_page_token = ""
      workload_identity_pools_element = {}
      workload_identity_pools = [workload_identity_pools_element]
      expected_response = { next_page_token: next_page_token, workload_identity_pools: workload_identity_pools }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::V1beta::ListWorkloadIdentityPoolsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::ListWorkloadIdentityPoolsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:list_workload_identity_pools, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("list_workload_identity_pools")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          response = client.list_workload_identity_pools(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.workload_identity_pools.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_workload_identity_pools with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient.project_path("[PROJECT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::ListWorkloadIdentityPoolsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:list_workload_identity_pools, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("list_workload_identity_pools")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.list_workload_identity_pools(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_workload_identity_pool' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient#get_workload_identity_pool."

    it 'invokes get_workload_identity_pool without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient.workload_identity_pool_path("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      disabled = true
      expected_response = {
        name: name_2,
        display_name: display_name,
        description: description,
        disabled: disabled
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::V1beta::WorkloadIdentityPool)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::GetWorkloadIdentityPoolRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:get_workload_identity_pool, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("get_workload_identity_pool")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          response = client.get_workload_identity_pool(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_workload_identity_pool(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_workload_identity_pool with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient.workload_identity_pool_path("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::GetWorkloadIdentityPoolRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:get_workload_identity_pool, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("get_workload_identity_pool")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.get_workload_identity_pool(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_workload_identity_pool' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient#create_workload_identity_pool."

    it 'invokes create_workload_identity_pool without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient.project_path("[PROJECT]")
      workload_identity_pool = {}
      workload_identity_pool_id = ''

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      disabled = true
      expected_response = {
        name: name,
        display_name: display_name,
        description: description,
        disabled: disabled
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::V1beta::WorkloadIdentityPool)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_workload_identity_pool_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::CreateWorkloadIdentityPoolRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(workload_identity_pool, Google::Iam::V1beta::WorkloadIdentityPool), request.workload_identity_pool)
        assert_equal(workload_identity_pool_id, request.workload_identity_pool_id)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:create_workload_identity_pool, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("create_workload_identity_pool")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          response = client.create_workload_identity_pool(
            formatted_parent,
            workload_identity_pool,
            workload_identity_pool_id
          )

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes create_workload_identity_pool and returns an operation error.' do
      # Create request parameters
      formatted_parent = Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient.project_path("[PROJECT]")
      workload_identity_pool = {}
      workload_identity_pool_id = ''

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient#create_workload_identity_pool.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_workload_identity_pool_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::CreateWorkloadIdentityPoolRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(workload_identity_pool, Google::Iam::V1beta::WorkloadIdentityPool), request.workload_identity_pool)
        assert_equal(workload_identity_pool_id, request.workload_identity_pool_id)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:create_workload_identity_pool, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("create_workload_identity_pool")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          response = client.create_workload_identity_pool(
            formatted_parent,
            workload_identity_pool,
            workload_identity_pool_id
          )

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes create_workload_identity_pool with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient.project_path("[PROJECT]")
      workload_identity_pool = {}
      workload_identity_pool_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::CreateWorkloadIdentityPoolRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(workload_identity_pool, Google::Iam::V1beta::WorkloadIdentityPool), request.workload_identity_pool)
        assert_equal(workload_identity_pool_id, request.workload_identity_pool_id)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:create_workload_identity_pool, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("create_workload_identity_pool")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.create_workload_identity_pool(
              formatted_parent,
              workload_identity_pool,
              workload_identity_pool_id
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_workload_identity_pool' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient#update_workload_identity_pool."

    it 'invokes update_workload_identity_pool without error' do
      # Create request parameters
      workload_identity_pool = {}
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      disabled = true
      expected_response = {
        name: name,
        display_name: display_name,
        description: description,
        disabled: disabled
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::V1beta::WorkloadIdentityPool)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_workload_identity_pool_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::UpdateWorkloadIdentityPoolRequest, request)
        assert_equal(Google::Gax::to_proto(workload_identity_pool, Google::Iam::V1beta::WorkloadIdentityPool), request.workload_identity_pool)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:update_workload_identity_pool, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("update_workload_identity_pool")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          response = client.update_workload_identity_pool(workload_identity_pool, update_mask)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes update_workload_identity_pool and returns an operation error.' do
      # Create request parameters
      workload_identity_pool = {}
      update_mask = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient#update_workload_identity_pool.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_workload_identity_pool_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::UpdateWorkloadIdentityPoolRequest, request)
        assert_equal(Google::Gax::to_proto(workload_identity_pool, Google::Iam::V1beta::WorkloadIdentityPool), request.workload_identity_pool)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:update_workload_identity_pool, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("update_workload_identity_pool")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          response = client.update_workload_identity_pool(workload_identity_pool, update_mask)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes update_workload_identity_pool with error' do
      # Create request parameters
      workload_identity_pool = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::UpdateWorkloadIdentityPoolRequest, request)
        assert_equal(Google::Gax::to_proto(workload_identity_pool, Google::Iam::V1beta::WorkloadIdentityPool), request.workload_identity_pool)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:update_workload_identity_pool, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("update_workload_identity_pool")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.update_workload_identity_pool(workload_identity_pool, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_workload_identity_pool' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient#delete_workload_identity_pool."

    it 'invokes delete_workload_identity_pool without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient.workload_identity_pool_path("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      disabled = true
      expected_response = {
        name: name_2,
        display_name: display_name,
        description: description,
        disabled: disabled
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::V1beta::WorkloadIdentityPool)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_workload_identity_pool_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::DeleteWorkloadIdentityPoolRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:delete_workload_identity_pool, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("delete_workload_identity_pool")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          response = client.delete_workload_identity_pool(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes delete_workload_identity_pool and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient.workload_identity_pool_path("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient#delete_workload_identity_pool.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_workload_identity_pool_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::DeleteWorkloadIdentityPoolRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:delete_workload_identity_pool, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("delete_workload_identity_pool")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          response = client.delete_workload_identity_pool(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes delete_workload_identity_pool with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient.workload_identity_pool_path("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::DeleteWorkloadIdentityPoolRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:delete_workload_identity_pool, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("delete_workload_identity_pool")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.delete_workload_identity_pool(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'undelete_workload_identity_pool' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient#undelete_workload_identity_pool."

    it 'invokes undelete_workload_identity_pool without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient.workload_identity_pool_path("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      disabled = true
      expected_response = {
        name: name_2,
        display_name: display_name,
        description: description,
        disabled: disabled
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::V1beta::WorkloadIdentityPool)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/undelete_workload_identity_pool_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::UndeleteWorkloadIdentityPoolRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:undelete_workload_identity_pool, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("undelete_workload_identity_pool")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          response = client.undelete_workload_identity_pool(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes undelete_workload_identity_pool and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient.workload_identity_pool_path("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient#undelete_workload_identity_pool.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/undelete_workload_identity_pool_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::UndeleteWorkloadIdentityPoolRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:undelete_workload_identity_pool, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("undelete_workload_identity_pool")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          response = client.undelete_workload_identity_pool(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes undelete_workload_identity_pool with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient.workload_identity_pool_path("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::UndeleteWorkloadIdentityPoolRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:undelete_workload_identity_pool, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("undelete_workload_identity_pool")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.undelete_workload_identity_pool(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_workload_identity_pool_providers' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient#list_workload_identity_pool_providers."

    it 'invokes list_workload_identity_pool_providers without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient.workload_identity_pool_path("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]")

      # Create expected grpc response
      next_page_token = ""
      workload_identity_pool_providers_element = {}
      workload_identity_pool_providers = [workload_identity_pool_providers_element]
      expected_response = { next_page_token: next_page_token, workload_identity_pool_providers: workload_identity_pool_providers }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::V1beta::ListWorkloadIdentityPoolProvidersResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::ListWorkloadIdentityPoolProvidersRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:list_workload_identity_pool_providers, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("list_workload_identity_pool_providers")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          response = client.list_workload_identity_pool_providers(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.workload_identity_pool_providers.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_workload_identity_pool_providers with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient.workload_identity_pool_path("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::ListWorkloadIdentityPoolProvidersRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:list_workload_identity_pool_providers, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("list_workload_identity_pool_providers")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.list_workload_identity_pool_providers(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_workload_identity_pool_provider' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient#get_workload_identity_pool_provider."

    it 'invokes get_workload_identity_pool_provider without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient.workload_identity_pool_provider_path("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      disabled = true
      attribute_condition = "attributeCondition33718072"
      expected_response = {
        name: name_2,
        display_name: display_name,
        description: description,
        disabled: disabled,
        attribute_condition: attribute_condition
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::V1beta::WorkloadIdentityPoolProvider)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::GetWorkloadIdentityPoolProviderRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:get_workload_identity_pool_provider, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("get_workload_identity_pool_provider")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          response = client.get_workload_identity_pool_provider(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_workload_identity_pool_provider(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_workload_identity_pool_provider with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient.workload_identity_pool_provider_path("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::GetWorkloadIdentityPoolProviderRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:get_workload_identity_pool_provider, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("get_workload_identity_pool_provider")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.get_workload_identity_pool_provider(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_workload_identity_pool_provider' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient#create_workload_identity_pool_provider."

    it 'invokes create_workload_identity_pool_provider without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient.workload_identity_pool_path("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]")
      workload_identity_pool_provider = {}
      workload_identity_pool_provider_id = ''

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      disabled = true
      attribute_condition = "attributeCondition33718072"
      expected_response = {
        name: name,
        display_name: display_name,
        description: description,
        disabled: disabled,
        attribute_condition: attribute_condition
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::V1beta::WorkloadIdentityPoolProvider)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_workload_identity_pool_provider_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::CreateWorkloadIdentityPoolProviderRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(workload_identity_pool_provider, Google::Iam::V1beta::WorkloadIdentityPoolProvider), request.workload_identity_pool_provider)
        assert_equal(workload_identity_pool_provider_id, request.workload_identity_pool_provider_id)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:create_workload_identity_pool_provider, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("create_workload_identity_pool_provider")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          response = client.create_workload_identity_pool_provider(
            formatted_parent,
            workload_identity_pool_provider,
            workload_identity_pool_provider_id
          )

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes create_workload_identity_pool_provider and returns an operation error.' do
      # Create request parameters
      formatted_parent = Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient.workload_identity_pool_path("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]")
      workload_identity_pool_provider = {}
      workload_identity_pool_provider_id = ''

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient#create_workload_identity_pool_provider.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_workload_identity_pool_provider_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::CreateWorkloadIdentityPoolProviderRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(workload_identity_pool_provider, Google::Iam::V1beta::WorkloadIdentityPoolProvider), request.workload_identity_pool_provider)
        assert_equal(workload_identity_pool_provider_id, request.workload_identity_pool_provider_id)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:create_workload_identity_pool_provider, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("create_workload_identity_pool_provider")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          response = client.create_workload_identity_pool_provider(
            formatted_parent,
            workload_identity_pool_provider,
            workload_identity_pool_provider_id
          )

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes create_workload_identity_pool_provider with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient.workload_identity_pool_path("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]")
      workload_identity_pool_provider = {}
      workload_identity_pool_provider_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::CreateWorkloadIdentityPoolProviderRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(workload_identity_pool_provider, Google::Iam::V1beta::WorkloadIdentityPoolProvider), request.workload_identity_pool_provider)
        assert_equal(workload_identity_pool_provider_id, request.workload_identity_pool_provider_id)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:create_workload_identity_pool_provider, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("create_workload_identity_pool_provider")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.create_workload_identity_pool_provider(
              formatted_parent,
              workload_identity_pool_provider,
              workload_identity_pool_provider_id
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_workload_identity_pool_provider' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient#update_workload_identity_pool_provider."

    it 'invokes update_workload_identity_pool_provider without error' do
      # Create request parameters
      workload_identity_pool_provider = {}
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      disabled = true
      attribute_condition = "attributeCondition33718072"
      expected_response = {
        name: name,
        display_name: display_name,
        description: description,
        disabled: disabled,
        attribute_condition: attribute_condition
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::V1beta::WorkloadIdentityPoolProvider)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_workload_identity_pool_provider_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::UpdateWorkloadIdentityPoolProviderRequest, request)
        assert_equal(Google::Gax::to_proto(workload_identity_pool_provider, Google::Iam::V1beta::WorkloadIdentityPoolProvider), request.workload_identity_pool_provider)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:update_workload_identity_pool_provider, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("update_workload_identity_pool_provider")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          response = client.update_workload_identity_pool_provider(workload_identity_pool_provider, update_mask)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes update_workload_identity_pool_provider and returns an operation error.' do
      # Create request parameters
      workload_identity_pool_provider = {}
      update_mask = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient#update_workload_identity_pool_provider.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_workload_identity_pool_provider_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::UpdateWorkloadIdentityPoolProviderRequest, request)
        assert_equal(Google::Gax::to_proto(workload_identity_pool_provider, Google::Iam::V1beta::WorkloadIdentityPoolProvider), request.workload_identity_pool_provider)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:update_workload_identity_pool_provider, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("update_workload_identity_pool_provider")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          response = client.update_workload_identity_pool_provider(workload_identity_pool_provider, update_mask)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes update_workload_identity_pool_provider with error' do
      # Create request parameters
      workload_identity_pool_provider = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::UpdateWorkloadIdentityPoolProviderRequest, request)
        assert_equal(Google::Gax::to_proto(workload_identity_pool_provider, Google::Iam::V1beta::WorkloadIdentityPoolProvider), request.workload_identity_pool_provider)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:update_workload_identity_pool_provider, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("update_workload_identity_pool_provider")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.update_workload_identity_pool_provider(workload_identity_pool_provider, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_workload_identity_pool_provider' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient#delete_workload_identity_pool_provider."

    it 'invokes delete_workload_identity_pool_provider without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient.workload_identity_pool_provider_path("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      disabled = true
      attribute_condition = "attributeCondition33718072"
      expected_response = {
        name: name_2,
        display_name: display_name,
        description: description,
        disabled: disabled,
        attribute_condition: attribute_condition
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::V1beta::WorkloadIdentityPoolProvider)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_workload_identity_pool_provider_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::DeleteWorkloadIdentityPoolProviderRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:delete_workload_identity_pool_provider, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("delete_workload_identity_pool_provider")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          response = client.delete_workload_identity_pool_provider(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes delete_workload_identity_pool_provider and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient.workload_identity_pool_provider_path("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient#delete_workload_identity_pool_provider.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_workload_identity_pool_provider_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::DeleteWorkloadIdentityPoolProviderRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:delete_workload_identity_pool_provider, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("delete_workload_identity_pool_provider")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          response = client.delete_workload_identity_pool_provider(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes delete_workload_identity_pool_provider with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient.workload_identity_pool_provider_path("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::DeleteWorkloadIdentityPoolProviderRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:delete_workload_identity_pool_provider, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("delete_workload_identity_pool_provider")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.delete_workload_identity_pool_provider(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'undelete_workload_identity_pool_provider' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient#undelete_workload_identity_pool_provider."

    it 'invokes undelete_workload_identity_pool_provider without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient.workload_identity_pool_provider_path("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      disabled = true
      attribute_condition = "attributeCondition33718072"
      expected_response = {
        name: name_2,
        display_name: display_name,
        description: description,
        disabled: disabled,
        attribute_condition: attribute_condition
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::V1beta::WorkloadIdentityPoolProvider)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/undelete_workload_identity_pool_provider_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::UndeleteWorkloadIdentityPoolProviderRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:undelete_workload_identity_pool_provider, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("undelete_workload_identity_pool_provider")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          response = client.undelete_workload_identity_pool_provider(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes undelete_workload_identity_pool_provider and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient.workload_identity_pool_provider_path("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient#undelete_workload_identity_pool_provider.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/undelete_workload_identity_pool_provider_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::UndeleteWorkloadIdentityPoolProviderRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:undelete_workload_identity_pool_provider, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("undelete_workload_identity_pool_provider")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          response = client.undelete_workload_identity_pool_provider(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes undelete_workload_identity_pool_provider with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::V1Beta::WorkloadIdentityPoolsClient.workload_identity_pool_provider_path("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1beta::UndeleteWorkloadIdentityPoolProviderRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:undelete_workload_identity_pool_provider, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkloadIdentityPoolsCredentials_v1beta.new("undelete_workload_identity_pool_provider")

      Google::Iam::V1beta::WorkloadIdentityPools::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::V1Beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.undelete_workload_identity_pool_provider(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end