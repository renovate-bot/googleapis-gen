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

require "google/cloud/aiplatform"
require "google/cloud/aiplatform/v1/specialist_pool_service_client"
require "google/cloud/aiplatform/v1/specialist_pool_service_services_pb"
require "google/longrunning/operations_pb"

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

class MockSpecialistPoolServiceCredentials_v1 < Google::Cloud::Aiplatform::V1::Credentials
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

describe Google::Cloud::Aiplatform::V1::SpecialistPoolServiceClient do

  describe 'create_specialist_pool' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::SpecialistPoolServiceClient#create_specialist_pool."

    it 'invokes create_specialist_pool without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::SpecialistPoolServiceClient.location_path("[PROJECT]", "[LOCATION]")
      specialist_pool = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      specialist_managers_count = 984151356
      expected_response = {
        name: name,
        display_name: display_name,
        specialist_managers_count: specialist_managers_count
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::SpecialistPool)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_specialist_pool_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::CreateSpecialistPoolRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(specialist_pool, Google::Cloud::Aiplatform::V1::SpecialistPool), request.specialist_pool)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_specialist_pool, mock_method)

      # Mock auth layer
      mock_credentials = MockSpecialistPoolServiceCredentials_v1.new("create_specialist_pool")

      Google::Cloud::Aiplatform::V1::SpecialistPoolService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::SpecialistPool.new(version: :v1)

          # Call method
          response = client.create_specialist_pool(formatted_parent, specialist_pool)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes create_specialist_pool and returns an operation error.' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::SpecialistPoolServiceClient.location_path("[PROJECT]", "[LOCATION]")
      specialist_pool = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Aiplatform::V1::SpecialistPoolServiceClient#create_specialist_pool.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_specialist_pool_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::CreateSpecialistPoolRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(specialist_pool, Google::Cloud::Aiplatform::V1::SpecialistPool), request.specialist_pool)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_specialist_pool, mock_method)

      # Mock auth layer
      mock_credentials = MockSpecialistPoolServiceCredentials_v1.new("create_specialist_pool")

      Google::Cloud::Aiplatform::V1::SpecialistPoolService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::SpecialistPool.new(version: :v1)

          # Call method
          response = client.create_specialist_pool(formatted_parent, specialist_pool)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes create_specialist_pool with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::SpecialistPoolServiceClient.location_path("[PROJECT]", "[LOCATION]")
      specialist_pool = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::CreateSpecialistPoolRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(specialist_pool, Google::Cloud::Aiplatform::V1::SpecialistPool), request.specialist_pool)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_specialist_pool, mock_method)

      # Mock auth layer
      mock_credentials = MockSpecialistPoolServiceCredentials_v1.new("create_specialist_pool")

      Google::Cloud::Aiplatform::V1::SpecialistPoolService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::SpecialistPool.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.create_specialist_pool(formatted_parent, specialist_pool)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_specialist_pool' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::SpecialistPoolServiceClient#get_specialist_pool."

    it 'invokes get_specialist_pool without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::SpecialistPoolServiceClient.specialist_pool_path("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      specialist_managers_count = 984151356
      expected_response = {
        name: name_2,
        display_name: display_name,
        specialist_managers_count: specialist_managers_count
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::SpecialistPool)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::GetSpecialistPoolRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_specialist_pool, mock_method)

      # Mock auth layer
      mock_credentials = MockSpecialistPoolServiceCredentials_v1.new("get_specialist_pool")

      Google::Cloud::Aiplatform::V1::SpecialistPoolService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::SpecialistPool.new(version: :v1)

          # Call method
          response = client.get_specialist_pool(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_specialist_pool(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_specialist_pool with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::SpecialistPoolServiceClient.specialist_pool_path("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::GetSpecialistPoolRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_specialist_pool, mock_method)

      # Mock auth layer
      mock_credentials = MockSpecialistPoolServiceCredentials_v1.new("get_specialist_pool")

      Google::Cloud::Aiplatform::V1::SpecialistPoolService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::SpecialistPool.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_specialist_pool(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_specialist_pools' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::SpecialistPoolServiceClient#list_specialist_pools."

    it 'invokes list_specialist_pools without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::SpecialistPoolServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      specialist_pools_element = {}
      specialist_pools = [specialist_pools_element]
      expected_response = { next_page_token: next_page_token, specialist_pools: specialist_pools }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::ListSpecialistPoolsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::ListSpecialistPoolsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_specialist_pools, mock_method)

      # Mock auth layer
      mock_credentials = MockSpecialistPoolServiceCredentials_v1.new("list_specialist_pools")

      Google::Cloud::Aiplatform::V1::SpecialistPoolService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::SpecialistPool.new(version: :v1)

          # Call method
          response = client.list_specialist_pools(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.specialist_pools.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_specialist_pools with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::SpecialistPoolServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::ListSpecialistPoolsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_specialist_pools, mock_method)

      # Mock auth layer
      mock_credentials = MockSpecialistPoolServiceCredentials_v1.new("list_specialist_pools")

      Google::Cloud::Aiplatform::V1::SpecialistPoolService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::SpecialistPool.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_specialist_pools(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_specialist_pool' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::SpecialistPoolServiceClient#delete_specialist_pool."

    it 'invokes delete_specialist_pool without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::SpecialistPoolServiceClient.specialist_pool_path("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Protobuf::Empty)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_specialist_pool_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::DeleteSpecialistPoolRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_specialist_pool, mock_method)

      # Mock auth layer
      mock_credentials = MockSpecialistPoolServiceCredentials_v1.new("delete_specialist_pool")

      Google::Cloud::Aiplatform::V1::SpecialistPoolService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::SpecialistPool.new(version: :v1)

          # Call method
          response = client.delete_specialist_pool(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes delete_specialist_pool and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::SpecialistPoolServiceClient.specialist_pool_path("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Aiplatform::V1::SpecialistPoolServiceClient#delete_specialist_pool.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_specialist_pool_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::DeleteSpecialistPoolRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_specialist_pool, mock_method)

      # Mock auth layer
      mock_credentials = MockSpecialistPoolServiceCredentials_v1.new("delete_specialist_pool")

      Google::Cloud::Aiplatform::V1::SpecialistPoolService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::SpecialistPool.new(version: :v1)

          # Call method
          response = client.delete_specialist_pool(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes delete_specialist_pool with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::SpecialistPoolServiceClient.specialist_pool_path("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::DeleteSpecialistPoolRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_specialist_pool, mock_method)

      # Mock auth layer
      mock_credentials = MockSpecialistPoolServiceCredentials_v1.new("delete_specialist_pool")

      Google::Cloud::Aiplatform::V1::SpecialistPoolService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::SpecialistPool.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_specialist_pool(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_specialist_pool' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::SpecialistPoolServiceClient#update_specialist_pool."

    it 'invokes update_specialist_pool without error' do
      # Create request parameters
      specialist_pool = {}
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      specialist_managers_count = 984151356
      expected_response = {
        name: name,
        display_name: display_name,
        specialist_managers_count: specialist_managers_count
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::SpecialistPool)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_specialist_pool_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::UpdateSpecialistPoolRequest, request)
        assert_equal(Google::Gax::to_proto(specialist_pool, Google::Cloud::Aiplatform::V1::SpecialistPool), request.specialist_pool)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_specialist_pool, mock_method)

      # Mock auth layer
      mock_credentials = MockSpecialistPoolServiceCredentials_v1.new("update_specialist_pool")

      Google::Cloud::Aiplatform::V1::SpecialistPoolService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::SpecialistPool.new(version: :v1)

          # Call method
          response = client.update_specialist_pool(specialist_pool, update_mask)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes update_specialist_pool and returns an operation error.' do
      # Create request parameters
      specialist_pool = {}
      update_mask = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Aiplatform::V1::SpecialistPoolServiceClient#update_specialist_pool.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_specialist_pool_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::UpdateSpecialistPoolRequest, request)
        assert_equal(Google::Gax::to_proto(specialist_pool, Google::Cloud::Aiplatform::V1::SpecialistPool), request.specialist_pool)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_specialist_pool, mock_method)

      # Mock auth layer
      mock_credentials = MockSpecialistPoolServiceCredentials_v1.new("update_specialist_pool")

      Google::Cloud::Aiplatform::V1::SpecialistPoolService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::SpecialistPool.new(version: :v1)

          # Call method
          response = client.update_specialist_pool(specialist_pool, update_mask)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes update_specialist_pool with error' do
      # Create request parameters
      specialist_pool = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::UpdateSpecialistPoolRequest, request)
        assert_equal(Google::Gax::to_proto(specialist_pool, Google::Cloud::Aiplatform::V1::SpecialistPool), request.specialist_pool)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_specialist_pool, mock_method)

      # Mock auth layer
      mock_credentials = MockSpecialistPoolServiceCredentials_v1.new("update_specialist_pool")

      Google::Cloud::Aiplatform::V1::SpecialistPoolService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::SpecialistPool.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.update_specialist_pool(specialist_pool, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end