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

require "google/cloud/storage"
require "google/cloud/storage/v1/storage_client"
require "google/storage/v1/storage_services_pb"

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

class MockStorageCredentials_v1 < Google::Cloud::Storage::V1::Credentials
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

describe Google::Cloud::Storage::V1::StorageClient do

  describe 'delete_bucket_access_control' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#delete_bucket_access_control."

    it 'invokes delete_bucket_access_control without error' do
      # Create request parameters
      bucket = ''
      entity = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::DeleteBucketAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(entity, request.entity)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_bucket_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("delete_bucket_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.delete_bucket_access_control(bucket, entity)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_bucket_access_control(bucket, entity) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_bucket_access_control with error' do
      # Create request parameters
      bucket = ''
      entity = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::DeleteBucketAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(entity, request.entity)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_bucket_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("delete_bucket_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_bucket_access_control(bucket, entity)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_bucket_access_control' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#get_bucket_access_control."

    it 'invokes get_bucket_access_control without error' do
      # Create request parameters
      bucket = ''
      entity = ''

      # Create expected grpc response
      role = "role3506294"
      etag = "etag3123477"
      id = "id3355"
      bucket_2 = "bucket2-1603304675"
      entity_2 = "entity2-2102099242"
      entity_id = "entityId-740565257"
      email = "email96619420"
      domain = "domain-1326197564"
      expected_response = {
        role: role,
        etag: etag,
        id: id,
        bucket: bucket_2,
        entity: entity_2,
        entity_id: entity_id,
        email: email,
        domain: domain
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::BucketAccessControl)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::GetBucketAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(entity, request.entity)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_bucket_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("get_bucket_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.get_bucket_access_control(bucket, entity)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_bucket_access_control(bucket, entity) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_bucket_access_control with error' do
      # Create request parameters
      bucket = ''
      entity = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::GetBucketAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(entity, request.entity)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_bucket_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("get_bucket_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_bucket_access_control(bucket, entity)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'insert_bucket_access_control' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#insert_bucket_access_control."

    it 'invokes insert_bucket_access_control without error' do
      # Create request parameters
      bucket = ''

      # Create expected grpc response
      role = "role3506294"
      etag = "etag3123477"
      id = "id3355"
      bucket_2 = "bucket2-1603304675"
      entity = "entity-1298275357"
      entity_id = "entityId-740565257"
      email = "email96619420"
      domain = "domain-1326197564"
      expected_response = {
        role: role,
        etag: etag,
        id: id,
        bucket: bucket_2,
        entity: entity,
        entity_id: entity_id,
        email: email,
        domain: domain
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::BucketAccessControl)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::InsertBucketAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:insert_bucket_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("insert_bucket_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.insert_bucket_access_control(bucket)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.insert_bucket_access_control(bucket) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes insert_bucket_access_control with error' do
      # Create request parameters
      bucket = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::InsertBucketAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:insert_bucket_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("insert_bucket_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.insert_bucket_access_control(bucket)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_bucket_access_controls' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#list_bucket_access_controls."

    it 'invokes list_bucket_access_controls without error' do
      # Create request parameters
      bucket = ''

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::ListBucketAccessControlsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::ListBucketAccessControlsRequest, request)
        assert_equal(bucket, request.bucket)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_bucket_access_controls, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("list_bucket_access_controls")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.list_bucket_access_controls(bucket)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.list_bucket_access_controls(bucket) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes list_bucket_access_controls with error' do
      # Create request parameters
      bucket = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::ListBucketAccessControlsRequest, request)
        assert_equal(bucket, request.bucket)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_bucket_access_controls, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("list_bucket_access_controls")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_bucket_access_controls(bucket)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_bucket_access_control' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#update_bucket_access_control."

    it 'invokes update_bucket_access_control without error' do
      # Create request parameters
      bucket = ''
      entity = ''

      # Create expected grpc response
      role = "role3506294"
      etag = "etag3123477"
      id = "id3355"
      bucket_2 = "bucket2-1603304675"
      entity_2 = "entity2-2102099242"
      entity_id = "entityId-740565257"
      email = "email96619420"
      domain = "domain-1326197564"
      expected_response = {
        role: role,
        etag: etag,
        id: id,
        bucket: bucket_2,
        entity: entity_2,
        entity_id: entity_id,
        email: email,
        domain: domain
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::BucketAccessControl)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::UpdateBucketAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(entity, request.entity)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_bucket_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("update_bucket_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.update_bucket_access_control(bucket, entity)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_bucket_access_control(bucket, entity) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_bucket_access_control with error' do
      # Create request parameters
      bucket = ''
      entity = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::UpdateBucketAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(entity, request.entity)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_bucket_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("update_bucket_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.update_bucket_access_control(bucket, entity)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'patch_bucket_access_control' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#patch_bucket_access_control."

    it 'invokes patch_bucket_access_control without error' do
      # Create request parameters
      bucket = ''
      entity = ''

      # Create expected grpc response
      role = "role3506294"
      etag = "etag3123477"
      id = "id3355"
      bucket_2 = "bucket2-1603304675"
      entity_2 = "entity2-2102099242"
      entity_id = "entityId-740565257"
      email = "email96619420"
      domain = "domain-1326197564"
      expected_response = {
        role: role,
        etag: etag,
        id: id,
        bucket: bucket_2,
        entity: entity_2,
        entity_id: entity_id,
        email: email,
        domain: domain
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::BucketAccessControl)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::PatchBucketAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(entity, request.entity)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:patch_bucket_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("patch_bucket_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.patch_bucket_access_control(bucket, entity)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.patch_bucket_access_control(bucket, entity) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes patch_bucket_access_control with error' do
      # Create request parameters
      bucket = ''
      entity = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::PatchBucketAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(entity, request.entity)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:patch_bucket_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("patch_bucket_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.patch_bucket_access_control(bucket, entity)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_bucket' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#delete_bucket."

    it 'invokes delete_bucket without error' do
      # Create request parameters
      bucket = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::DeleteBucketRequest, request)
        assert_equal(bucket, request.bucket)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_bucket, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("delete_bucket")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.delete_bucket(bucket)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_bucket(bucket) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_bucket with error' do
      # Create request parameters
      bucket = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::DeleteBucketRequest, request)
        assert_equal(bucket, request.bucket)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_bucket, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("delete_bucket")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_bucket(bucket)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_bucket' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#get_bucket."

    it 'invokes get_bucket without error' do
      # Create request parameters
      bucket = ''

      # Create expected grpc response
      id = "id3355"
      name = "name3373707"
      project_number = 828084015
      metageneration = 1048558813
      location = "location1901043637"
      storage_class = "storageClass2035762868"
      etag = "etag3123477"
      default_event_based_hold = true
      location_type = "locationType-1796591228"
      expected_response = {
        id: id,
        name: name,
        project_number: project_number,
        metageneration: metageneration,
        location: location,
        storage_class: storage_class,
        etag: etag,
        default_event_based_hold: default_event_based_hold,
        location_type: location_type
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::Bucket)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::GetBucketRequest, request)
        assert_equal(bucket, request.bucket)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_bucket, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("get_bucket")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.get_bucket(bucket)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_bucket(bucket) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_bucket with error' do
      # Create request parameters
      bucket = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::GetBucketRequest, request)
        assert_equal(bucket, request.bucket)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_bucket, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("get_bucket")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_bucket(bucket)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'insert_bucket' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#insert_bucket."

    it 'invokes insert_bucket without error' do
      # Create request parameters
      project = ''

      # Create expected grpc response
      id = "id3355"
      name = "name3373707"
      project_number = 828084015
      metageneration = 1048558813
      location = "location1901043637"
      storage_class = "storageClass2035762868"
      etag = "etag3123477"
      default_event_based_hold = true
      location_type = "locationType-1796591228"
      expected_response = {
        id: id,
        name: name,
        project_number: project_number,
        metageneration: metageneration,
        location: location,
        storage_class: storage_class,
        etag: etag,
        default_event_based_hold: default_event_based_hold,
        location_type: location_type
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::Bucket)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::InsertBucketRequest, request)
        assert_equal(project, request.project)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:insert_bucket, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("insert_bucket")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.insert_bucket(project)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.insert_bucket(project) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes insert_bucket with error' do
      # Create request parameters
      project = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::InsertBucketRequest, request)
        assert_equal(project, request.project)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:insert_bucket, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("insert_bucket")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.insert_bucket(project)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_channels' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#list_channels."

    it 'invokes list_channels without error' do
      # Create request parameters
      bucket = ''

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::ListChannelsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::ListChannelsRequest, request)
        assert_equal(bucket, request.bucket)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_channels, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("list_channels")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.list_channels(bucket)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.list_channels(bucket) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes list_channels with error' do
      # Create request parameters
      bucket = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::ListChannelsRequest, request)
        assert_equal(bucket, request.bucket)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_channels, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("list_channels")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_channels(bucket)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_buckets' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#list_buckets."

    it 'invokes list_buckets without error' do
      # Create request parameters
      project = ''

      # Create expected grpc response
      next_page_token = "nextPageToken-1530815211"
      expected_response = { next_page_token: next_page_token }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::ListBucketsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::ListBucketsRequest, request)
        assert_equal(project, request.project)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_buckets, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("list_buckets")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.list_buckets(project)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.list_buckets(project) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes list_buckets with error' do
      # Create request parameters
      project = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::ListBucketsRequest, request)
        assert_equal(project, request.project)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_buckets, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("list_buckets")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_buckets(project)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'lock_bucket_retention_policy' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#lock_bucket_retention_policy."

    it 'invokes lock_bucket_retention_policy without error' do
      # Create request parameters
      bucket = ''

      # Create expected grpc response
      id = "id3355"
      name = "name3373707"
      project_number = 828084015
      metageneration = 1048558813
      location = "location1901043637"
      storage_class = "storageClass2035762868"
      etag = "etag3123477"
      default_event_based_hold = true
      location_type = "locationType-1796591228"
      expected_response = {
        id: id,
        name: name,
        project_number: project_number,
        metageneration: metageneration,
        location: location,
        storage_class: storage_class,
        etag: etag,
        default_event_based_hold: default_event_based_hold,
        location_type: location_type
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::Bucket)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::LockRetentionPolicyRequest, request)
        assert_equal(bucket, request.bucket)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:lock_bucket_retention_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("lock_bucket_retention_policy")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.lock_bucket_retention_policy(bucket)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.lock_bucket_retention_policy(bucket) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes lock_bucket_retention_policy with error' do
      # Create request parameters
      bucket = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::LockRetentionPolicyRequest, request)
        assert_equal(bucket, request.bucket)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:lock_bucket_retention_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("lock_bucket_retention_policy")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.lock_bucket_retention_policy(bucket)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_bucket_iam_policy' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#get_bucket_iam_policy."

    it 'invokes get_bucket_iam_policy without error' do
      # Create expected grpc response
      version = 351608024
      etag = "21"
      expected_response = { version: version, etag: etag }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::V1::Policy)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_bucket_iam_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("get_bucket_iam_policy")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.get_bucket_iam_policy

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_bucket_iam_policy do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_bucket_iam_policy with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_bucket_iam_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("get_bucket_iam_policy")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_bucket_iam_policy
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'set_bucket_iam_policy' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#set_bucket_iam_policy."

    it 'invokes set_bucket_iam_policy without error' do
      # Create expected grpc response
      version = 351608024
      etag = "21"
      expected_response = { version: version, etag: etag }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::V1::Policy)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:set_bucket_iam_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("set_bucket_iam_policy")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.set_bucket_iam_policy

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.set_bucket_iam_policy do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes set_bucket_iam_policy with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:set_bucket_iam_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("set_bucket_iam_policy")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.set_bucket_iam_policy
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'test_bucket_iam_permissions' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#test_bucket_iam_permissions."

    it 'invokes test_bucket_iam_permissions without error' do
      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::V1::TestIamPermissionsResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:test_bucket_iam_permissions, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("test_bucket_iam_permissions")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.test_bucket_iam_permissions

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.test_bucket_iam_permissions do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes test_bucket_iam_permissions with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:test_bucket_iam_permissions, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("test_bucket_iam_permissions")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.test_bucket_iam_permissions
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'patch_bucket' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#patch_bucket."

    it 'invokes patch_bucket without error' do
      # Create request parameters
      bucket = ''

      # Create expected grpc response
      id = "id3355"
      name = "name3373707"
      project_number = 828084015
      metageneration = 1048558813
      location = "location1901043637"
      storage_class = "storageClass2035762868"
      etag = "etag3123477"
      default_event_based_hold = true
      location_type = "locationType-1796591228"
      expected_response = {
        id: id,
        name: name,
        project_number: project_number,
        metageneration: metageneration,
        location: location,
        storage_class: storage_class,
        etag: etag,
        default_event_based_hold: default_event_based_hold,
        location_type: location_type
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::Bucket)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::PatchBucketRequest, request)
        assert_equal(bucket, request.bucket)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:patch_bucket, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("patch_bucket")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.patch_bucket(bucket)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.patch_bucket(bucket) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes patch_bucket with error' do
      # Create request parameters
      bucket = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::PatchBucketRequest, request)
        assert_equal(bucket, request.bucket)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:patch_bucket, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("patch_bucket")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.patch_bucket(bucket)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_bucket' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#update_bucket."

    it 'invokes update_bucket without error' do
      # Create request parameters
      bucket = ''

      # Create expected grpc response
      id = "id3355"
      name = "name3373707"
      project_number = 828084015
      metageneration = 1048558813
      location = "location1901043637"
      storage_class = "storageClass2035762868"
      etag = "etag3123477"
      default_event_based_hold = true
      location_type = "locationType-1796591228"
      expected_response = {
        id: id,
        name: name,
        project_number: project_number,
        metageneration: metageneration,
        location: location,
        storage_class: storage_class,
        etag: etag,
        default_event_based_hold: default_event_based_hold,
        location_type: location_type
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::Bucket)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::UpdateBucketRequest, request)
        assert_equal(bucket, request.bucket)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_bucket, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("update_bucket")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.update_bucket(bucket)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_bucket(bucket) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_bucket with error' do
      # Create request parameters
      bucket = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::UpdateBucketRequest, request)
        assert_equal(bucket, request.bucket)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_bucket, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("update_bucket")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.update_bucket(bucket)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'stop_channel' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#stop_channel."

    it 'invokes stop_channel without error' do

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:stop_channel, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("stop_channel")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.stop_channel

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.stop_channel do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes stop_channel with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:stop_channel, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("stop_channel")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.stop_channel
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_default_object_access_control' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#delete_default_object_access_control."

    it 'invokes delete_default_object_access_control without error' do
      # Create request parameters
      bucket = ''
      entity = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::DeleteDefaultObjectAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(entity, request.entity)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_default_object_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("delete_default_object_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.delete_default_object_access_control(bucket, entity)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_default_object_access_control(bucket, entity) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_default_object_access_control with error' do
      # Create request parameters
      bucket = ''
      entity = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::DeleteDefaultObjectAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(entity, request.entity)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_default_object_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("delete_default_object_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_default_object_access_control(bucket, entity)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_default_object_access_control' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#get_default_object_access_control."

    it 'invokes get_default_object_access_control without error' do
      # Create request parameters
      bucket = ''
      entity = ''

      # Create expected grpc response
      role = "role3506294"
      etag = "etag3123477"
      id = "id3355"
      bucket_2 = "bucket2-1603304675"
      object = "object-1023368385"
      generation = 305703192
      entity_2 = "entity2-2102099242"
      entity_id = "entityId-740565257"
      email = "email96619420"
      domain = "domain-1326197564"
      expected_response = {
        role: role,
        etag: etag,
        id: id,
        bucket: bucket_2,
        object: object,
        generation: generation,
        entity: entity_2,
        entity_id: entity_id,
        email: email,
        domain: domain
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::ObjectAccessControl)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::GetDefaultObjectAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(entity, request.entity)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_default_object_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("get_default_object_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.get_default_object_access_control(bucket, entity)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_default_object_access_control(bucket, entity) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_default_object_access_control with error' do
      # Create request parameters
      bucket = ''
      entity = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::GetDefaultObjectAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(entity, request.entity)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_default_object_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("get_default_object_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_default_object_access_control(bucket, entity)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'insert_default_object_access_control' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#insert_default_object_access_control."

    it 'invokes insert_default_object_access_control without error' do
      # Create request parameters
      bucket = ''

      # Create expected grpc response
      role = "role3506294"
      etag = "etag3123477"
      id = "id3355"
      bucket_2 = "bucket2-1603304675"
      object = "object-1023368385"
      generation = 305703192
      entity = "entity-1298275357"
      entity_id = "entityId-740565257"
      email = "email96619420"
      domain = "domain-1326197564"
      expected_response = {
        role: role,
        etag: etag,
        id: id,
        bucket: bucket_2,
        object: object,
        generation: generation,
        entity: entity,
        entity_id: entity_id,
        email: email,
        domain: domain
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::ObjectAccessControl)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::InsertDefaultObjectAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:insert_default_object_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("insert_default_object_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.insert_default_object_access_control(bucket)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.insert_default_object_access_control(bucket) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes insert_default_object_access_control with error' do
      # Create request parameters
      bucket = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::InsertDefaultObjectAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:insert_default_object_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("insert_default_object_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.insert_default_object_access_control(bucket)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_default_object_access_controls' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#list_default_object_access_controls."

    it 'invokes list_default_object_access_controls without error' do
      # Create request parameters
      bucket = ''

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::ListObjectAccessControlsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::ListDefaultObjectAccessControlsRequest, request)
        assert_equal(bucket, request.bucket)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_default_object_access_controls, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("list_default_object_access_controls")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.list_default_object_access_controls(bucket)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.list_default_object_access_controls(bucket) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes list_default_object_access_controls with error' do
      # Create request parameters
      bucket = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::ListDefaultObjectAccessControlsRequest, request)
        assert_equal(bucket, request.bucket)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_default_object_access_controls, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("list_default_object_access_controls")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_default_object_access_controls(bucket)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'patch_default_object_access_control' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#patch_default_object_access_control."

    it 'invokes patch_default_object_access_control without error' do
      # Create request parameters
      bucket = ''
      entity = ''

      # Create expected grpc response
      role = "role3506294"
      etag = "etag3123477"
      id = "id3355"
      bucket_2 = "bucket2-1603304675"
      object = "object-1023368385"
      generation = 305703192
      entity_2 = "entity2-2102099242"
      entity_id = "entityId-740565257"
      email = "email96619420"
      domain = "domain-1326197564"
      expected_response = {
        role: role,
        etag: etag,
        id: id,
        bucket: bucket_2,
        object: object,
        generation: generation,
        entity: entity_2,
        entity_id: entity_id,
        email: email,
        domain: domain
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::ObjectAccessControl)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::PatchDefaultObjectAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(entity, request.entity)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:patch_default_object_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("patch_default_object_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.patch_default_object_access_control(bucket, entity)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.patch_default_object_access_control(bucket, entity) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes patch_default_object_access_control with error' do
      # Create request parameters
      bucket = ''
      entity = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::PatchDefaultObjectAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(entity, request.entity)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:patch_default_object_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("patch_default_object_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.patch_default_object_access_control(bucket, entity)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_default_object_access_control' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#update_default_object_access_control."

    it 'invokes update_default_object_access_control without error' do
      # Create request parameters
      bucket = ''
      entity = ''

      # Create expected grpc response
      role = "role3506294"
      etag = "etag3123477"
      id = "id3355"
      bucket_2 = "bucket2-1603304675"
      object = "object-1023368385"
      generation = 305703192
      entity_2 = "entity2-2102099242"
      entity_id = "entityId-740565257"
      email = "email96619420"
      domain = "domain-1326197564"
      expected_response = {
        role: role,
        etag: etag,
        id: id,
        bucket: bucket_2,
        object: object,
        generation: generation,
        entity: entity_2,
        entity_id: entity_id,
        email: email,
        domain: domain
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::ObjectAccessControl)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::UpdateDefaultObjectAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(entity, request.entity)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_default_object_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("update_default_object_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.update_default_object_access_control(bucket, entity)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_default_object_access_control(bucket, entity) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_default_object_access_control with error' do
      # Create request parameters
      bucket = ''
      entity = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::UpdateDefaultObjectAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(entity, request.entity)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_default_object_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("update_default_object_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.update_default_object_access_control(bucket, entity)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_notification' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#delete_notification."

    it 'invokes delete_notification without error' do
      # Create request parameters
      bucket = ''
      notification = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::DeleteNotificationRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(notification, request.notification)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_notification, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("delete_notification")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.delete_notification(bucket, notification)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_notification(bucket, notification) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_notification with error' do
      # Create request parameters
      bucket = ''
      notification = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::DeleteNotificationRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(notification, request.notification)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_notification, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("delete_notification")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_notification(bucket, notification)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_notification' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#get_notification."

    it 'invokes get_notification without error' do
      # Create request parameters
      bucket = ''
      notification = ''

      # Create expected grpc response
      topic = "topic110546223"
      etag = "etag3123477"
      object_name_prefix = "objectNamePrefix1265003974"
      payload_format = "payloadFormat-1481910328"
      id = "id3355"
      expected_response = {
        topic: topic,
        etag: etag,
        object_name_prefix: object_name_prefix,
        payload_format: payload_format,
        id: id
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::Notification)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::GetNotificationRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(notification, request.notification)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_notification, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("get_notification")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.get_notification(bucket, notification)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_notification(bucket, notification) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_notification with error' do
      # Create request parameters
      bucket = ''
      notification = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::GetNotificationRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(notification, request.notification)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_notification, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("get_notification")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_notification(bucket, notification)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'insert_notification' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#insert_notification."

    it 'invokes insert_notification without error' do
      # Create request parameters
      bucket = ''

      # Create expected grpc response
      topic = "topic110546223"
      etag = "etag3123477"
      object_name_prefix = "objectNamePrefix1265003974"
      payload_format = "payloadFormat-1481910328"
      id = "id3355"
      expected_response = {
        topic: topic,
        etag: etag,
        object_name_prefix: object_name_prefix,
        payload_format: payload_format,
        id: id
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::Notification)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::InsertNotificationRequest, request)
        assert_equal(bucket, request.bucket)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:insert_notification, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("insert_notification")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.insert_notification(bucket)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.insert_notification(bucket) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes insert_notification with error' do
      # Create request parameters
      bucket = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::InsertNotificationRequest, request)
        assert_equal(bucket, request.bucket)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:insert_notification, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("insert_notification")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.insert_notification(bucket)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_notifications' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#list_notifications."

    it 'invokes list_notifications without error' do
      # Create request parameters
      bucket = ''

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::ListNotificationsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::ListNotificationsRequest, request)
        assert_equal(bucket, request.bucket)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_notifications, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("list_notifications")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.list_notifications(bucket)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.list_notifications(bucket) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes list_notifications with error' do
      # Create request parameters
      bucket = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::ListNotificationsRequest, request)
        assert_equal(bucket, request.bucket)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_notifications, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("list_notifications")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_notifications(bucket)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_object_access_control' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#delete_object_access_control."

    it 'invokes delete_object_access_control without error' do
      # Create request parameters
      bucket = ''
      entity = ''
      object = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::DeleteObjectAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(entity, request.entity)
        assert_equal(object, request.object)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_object_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("delete_object_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.delete_object_access_control(
            bucket,
            entity,
            object
          )

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_object_access_control(
            bucket,
            entity,
            object
          ) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_object_access_control with error' do
      # Create request parameters
      bucket = ''
      entity = ''
      object = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::DeleteObjectAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(entity, request.entity)
        assert_equal(object, request.object)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_object_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("delete_object_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_object_access_control(
              bucket,
              entity,
              object
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_object_access_control' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#get_object_access_control."

    it 'invokes get_object_access_control without error' do
      # Create request parameters
      bucket = ''
      entity = ''
      object = ''

      # Create expected grpc response
      role = "role3506294"
      etag = "etag3123477"
      id = "id3355"
      bucket_2 = "bucket2-1603304675"
      object_2 = "object290495794"
      generation = 305703192
      entity_2 = "entity2-2102099242"
      entity_id = "entityId-740565257"
      email = "email96619420"
      domain = "domain-1326197564"
      expected_response = {
        role: role,
        etag: etag,
        id: id,
        bucket: bucket_2,
        object: object_2,
        generation: generation,
        entity: entity_2,
        entity_id: entity_id,
        email: email,
        domain: domain
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::ObjectAccessControl)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::GetObjectAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(entity, request.entity)
        assert_equal(object, request.object)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_object_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("get_object_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.get_object_access_control(
            bucket,
            entity,
            object
          )

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_object_access_control(
            bucket,
            entity,
            object
          ) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_object_access_control with error' do
      # Create request parameters
      bucket = ''
      entity = ''
      object = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::GetObjectAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(entity, request.entity)
        assert_equal(object, request.object)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_object_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("get_object_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_object_access_control(
              bucket,
              entity,
              object
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'insert_object_access_control' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#insert_object_access_control."

    it 'invokes insert_object_access_control without error' do
      # Create request parameters
      bucket = ''
      object = ''

      # Create expected grpc response
      role = "role3506294"
      etag = "etag3123477"
      id = "id3355"
      bucket_2 = "bucket2-1603304675"
      object_2 = "object290495794"
      generation = 305703192
      entity = "entity-1298275357"
      entity_id = "entityId-740565257"
      email = "email96619420"
      domain = "domain-1326197564"
      expected_response = {
        role: role,
        etag: etag,
        id: id,
        bucket: bucket_2,
        object: object_2,
        generation: generation,
        entity: entity,
        entity_id: entity_id,
        email: email,
        domain: domain
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::ObjectAccessControl)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::InsertObjectAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(object, request.object)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:insert_object_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("insert_object_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.insert_object_access_control(bucket, object)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.insert_object_access_control(bucket, object) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes insert_object_access_control with error' do
      # Create request parameters
      bucket = ''
      object = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::InsertObjectAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(object, request.object)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:insert_object_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("insert_object_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.insert_object_access_control(bucket, object)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_object_access_controls' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#list_object_access_controls."

    it 'invokes list_object_access_controls without error' do
      # Create request parameters
      bucket = ''
      object = ''

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::ListObjectAccessControlsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::ListObjectAccessControlsRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(object, request.object)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_object_access_controls, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("list_object_access_controls")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.list_object_access_controls(bucket, object)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.list_object_access_controls(bucket, object) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes list_object_access_controls with error' do
      # Create request parameters
      bucket = ''
      object = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::ListObjectAccessControlsRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(object, request.object)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_object_access_controls, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("list_object_access_controls")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_object_access_controls(bucket, object)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'patch_object_access_control' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#patch_object_access_control."

    it 'invokes patch_object_access_control without error' do
      # Create request parameters
      bucket = ''
      entity = ''
      object = ''

      # Create expected grpc response
      role = "role3506294"
      etag = "etag3123477"
      id = "id3355"
      bucket_2 = "bucket2-1603304675"
      object_2 = "object290495794"
      generation = 305703192
      entity_2 = "entity2-2102099242"
      entity_id = "entityId-740565257"
      email = "email96619420"
      domain = "domain-1326197564"
      expected_response = {
        role: role,
        etag: etag,
        id: id,
        bucket: bucket_2,
        object: object_2,
        generation: generation,
        entity: entity_2,
        entity_id: entity_id,
        email: email,
        domain: domain
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::ObjectAccessControl)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::PatchObjectAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(entity, request.entity)
        assert_equal(object, request.object)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:patch_object_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("patch_object_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.patch_object_access_control(
            bucket,
            entity,
            object
          )

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.patch_object_access_control(
            bucket,
            entity,
            object
          ) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes patch_object_access_control with error' do
      # Create request parameters
      bucket = ''
      entity = ''
      object = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::PatchObjectAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(entity, request.entity)
        assert_equal(object, request.object)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:patch_object_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("patch_object_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.patch_object_access_control(
              bucket,
              entity,
              object
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_object_access_control' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#update_object_access_control."

    it 'invokes update_object_access_control without error' do
      # Create request parameters
      bucket = ''
      entity = ''
      object = ''

      # Create expected grpc response
      role = "role3506294"
      etag = "etag3123477"
      id = "id3355"
      bucket_2 = "bucket2-1603304675"
      object_2 = "object290495794"
      generation = 305703192
      entity_2 = "entity2-2102099242"
      entity_id = "entityId-740565257"
      email = "email96619420"
      domain = "domain-1326197564"
      expected_response = {
        role: role,
        etag: etag,
        id: id,
        bucket: bucket_2,
        object: object_2,
        generation: generation,
        entity: entity_2,
        entity_id: entity_id,
        email: email,
        domain: domain
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::ObjectAccessControl)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::UpdateObjectAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(entity, request.entity)
        assert_equal(object, request.object)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_object_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("update_object_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.update_object_access_control(
            bucket,
            entity,
            object
          )

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_object_access_control(
            bucket,
            entity,
            object
          ) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_object_access_control with error' do
      # Create request parameters
      bucket = ''
      entity = ''
      object = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::UpdateObjectAccessControlRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(entity, request.entity)
        assert_equal(object, request.object)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_object_access_control, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("update_object_access_control")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.update_object_access_control(
              bucket,
              entity,
              object
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'compose_object' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#compose_object."

    it 'invokes compose_object without error' do
      # Create request parameters
      destination_bucket = ''
      destination_object = ''

      # Create expected grpc response
      content_encoding = "contentEncoding1916674649"
      content_disposition = "contentDisposition891901169"
      cache_control = "cacheControl1032395168"
      content_language = "contentLanguage-1408137122"
      metageneration = 1048558813
      content_type = "contentType831846208"
      size = 3530753
      component_count = 485073075
      md5_hash = "md5Hash1152095023"
      etag = "etag3123477"
      storage_class = "storageClass2035762868"
      kms_key_name = "kmsKeyName2094986649"
      temporary_hold = false
      name = "name3373707"
      id = "id3355"
      bucket = "bucket-1378203158"
      generation = 305703192
      expected_response = {
        content_encoding: content_encoding,
        content_disposition: content_disposition,
        cache_control: cache_control,
        content_language: content_language,
        metageneration: metageneration,
        content_type: content_type,
        size: size,
        component_count: component_count,
        md5_hash: md5_hash,
        etag: etag,
        storage_class: storage_class,
        kms_key_name: kms_key_name,
        temporary_hold: temporary_hold,
        name: name,
        id: id,
        bucket: bucket,
        generation: generation
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::Object)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::ComposeObjectRequest, request)
        assert_equal(destination_bucket, request.destination_bucket)
        assert_equal(destination_object, request.destination_object)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:compose_object, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("compose_object")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.compose_object(destination_bucket, destination_object)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.compose_object(destination_bucket, destination_object) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes compose_object with error' do
      # Create request parameters
      destination_bucket = ''
      destination_object = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::ComposeObjectRequest, request)
        assert_equal(destination_bucket, request.destination_bucket)
        assert_equal(destination_object, request.destination_object)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:compose_object, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("compose_object")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.compose_object(destination_bucket, destination_object)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'copy_object' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#copy_object."

    it 'invokes copy_object without error' do
      # Create request parameters
      destination_bucket = ''
      destination_object = ''
      source_bucket = ''
      source_object = ''

      # Create expected grpc response
      content_encoding = "contentEncoding1916674649"
      content_disposition = "contentDisposition891901169"
      cache_control = "cacheControl1032395168"
      content_language = "contentLanguage-1408137122"
      metageneration = 1048558813
      content_type = "contentType831846208"
      size = 3530753
      component_count = 485073075
      md5_hash = "md5Hash1152095023"
      etag = "etag3123477"
      storage_class = "storageClass2035762868"
      kms_key_name = "kmsKeyName2094986649"
      temporary_hold = false
      name = "name3373707"
      id = "id3355"
      bucket = "bucket-1378203158"
      generation = 305703192
      expected_response = {
        content_encoding: content_encoding,
        content_disposition: content_disposition,
        cache_control: cache_control,
        content_language: content_language,
        metageneration: metageneration,
        content_type: content_type,
        size: size,
        component_count: component_count,
        md5_hash: md5_hash,
        etag: etag,
        storage_class: storage_class,
        kms_key_name: kms_key_name,
        temporary_hold: temporary_hold,
        name: name,
        id: id,
        bucket: bucket,
        generation: generation
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::Object)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::CopyObjectRequest, request)
        assert_equal(destination_bucket, request.destination_bucket)
        assert_equal(destination_object, request.destination_object)
        assert_equal(source_bucket, request.source_bucket)
        assert_equal(source_object, request.source_object)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:copy_object, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("copy_object")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.copy_object(
            destination_bucket,
            destination_object,
            source_bucket,
            source_object
          )

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.copy_object(
            destination_bucket,
            destination_object,
            source_bucket,
            source_object
          ) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes copy_object with error' do
      # Create request parameters
      destination_bucket = ''
      destination_object = ''
      source_bucket = ''
      source_object = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::CopyObjectRequest, request)
        assert_equal(destination_bucket, request.destination_bucket)
        assert_equal(destination_object, request.destination_object)
        assert_equal(source_bucket, request.source_bucket)
        assert_equal(source_object, request.source_object)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:copy_object, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("copy_object")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.copy_object(
              destination_bucket,
              destination_object,
              source_bucket,
              source_object
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_object' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#delete_object."

    it 'invokes delete_object without error' do
      # Create request parameters
      bucket = ''
      object = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::DeleteObjectRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(object, request.object)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_object, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("delete_object")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.delete_object(bucket, object)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_object(bucket, object) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_object with error' do
      # Create request parameters
      bucket = ''
      object = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::DeleteObjectRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(object, request.object)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_object, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("delete_object")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_object(bucket, object)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_object' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#get_object."

    it 'invokes get_object without error' do
      # Create request parameters
      bucket = ''
      object = ''

      # Create expected grpc response
      content_encoding = "contentEncoding1916674649"
      content_disposition = "contentDisposition891901169"
      cache_control = "cacheControl1032395168"
      content_language = "contentLanguage-1408137122"
      metageneration = 1048558813
      content_type = "contentType831846208"
      size = 3530753
      component_count = 485073075
      md5_hash = "md5Hash1152095023"
      etag = "etag3123477"
      storage_class = "storageClass2035762868"
      kms_key_name = "kmsKeyName2094986649"
      temporary_hold = false
      name = "name3373707"
      id = "id3355"
      bucket_2 = "bucket2-1603304675"
      generation = 305703192
      expected_response = {
        content_encoding: content_encoding,
        content_disposition: content_disposition,
        cache_control: cache_control,
        content_language: content_language,
        metageneration: metageneration,
        content_type: content_type,
        size: size,
        component_count: component_count,
        md5_hash: md5_hash,
        etag: etag,
        storage_class: storage_class,
        kms_key_name: kms_key_name,
        temporary_hold: temporary_hold,
        name: name,
        id: id,
        bucket: bucket_2,
        generation: generation
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::Object)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::GetObjectRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(object, request.object)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_object, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("get_object")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.get_object(bucket, object)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_object(bucket, object) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_object with error' do
      # Create request parameters
      bucket = ''
      object = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::GetObjectRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(object, request.object)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_object, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("get_object")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_object(bucket, object)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_object_media' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#get_object_media."

    it 'invokes get_object_media without error' do
      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::GetObjectMediaResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: [expected_response])
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_object_media, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("get_object_media")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.get_object_media

          # Verify the response
          assert_equal(1, response.count)
          assert_equal(expected_response, response.first)
        end
      end
    end

    it 'invokes get_object_media with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_object_media, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("get_object_media")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_object_media
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'insert_object' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#insert_object."

    it 'invokes insert_object without error' do
      # Create request parameters
      write_offset = 0
      request = { write_offset: write_offset }

      # Create expected grpc response
      content_encoding = "contentEncoding1916674649"
      content_disposition = "contentDisposition891901169"
      cache_control = "cacheControl1032395168"
      content_language = "contentLanguage-1408137122"
      metageneration = 1048558813
      content_type = "contentType831846208"
      size = 3530753
      component_count = 485073075
      md5_hash = "md5Hash1152095023"
      etag = "etag3123477"
      storage_class = "storageClass2035762868"
      kms_key_name = "kmsKeyName2094986649"
      temporary_hold = false
      name = "name3373707"
      id = "id3355"
      bucket = "bucket-1378203158"
      generation = 305703192
      expected_response = {
        content_encoding: content_encoding,
        content_disposition: content_disposition,
        cache_control: cache_control,
        content_language: content_language,
        metageneration: metageneration,
        content_type: content_type,
        size: size,
        component_count: component_count,
        md5_hash: md5_hash,
        etag: etag,
        storage_class: storage_class,
        kms_key_name: kms_key_name,
        temporary_hold: temporary_hold,
        name: name,
        id: id,
        bucket: bucket,
        generation: generation
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::Object)

      # Mock Grpc layer
      mock_method = proc do |requests|
        request = requests.first
        assert_instance_of(Google::Storage::V1::InsertObjectRequest, request)
        assert_equal(write_offset, request.write_offset)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:insert_object, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("insert_object")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.insert_object([request])

          # Verify the response
          assert_equal(expected_response, response)
        end
      end
    end

    it 'invokes insert_object with error' do
      # Create request parameters
      write_offset = 0
      request = { write_offset: write_offset }

      # Mock Grpc layer
      mock_method = proc do |requests|
        request = requests.first
        assert_instance_of(Google::Storage::V1::InsertObjectRequest, request)
        assert_equal(write_offset, request.write_offset)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:insert_object, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("insert_object")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.insert_object([request])
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_objects' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#list_objects."

    it 'invokes list_objects without error' do
      # Create request parameters
      bucket = ''

      # Create expected grpc response
      next_page_token = "nextPageToken-1530815211"
      expected_response = { next_page_token: next_page_token }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::ListObjectsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::ListObjectsRequest, request)
        assert_equal(bucket, request.bucket)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_objects, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("list_objects")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.list_objects(bucket)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.list_objects(bucket) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes list_objects with error' do
      # Create request parameters
      bucket = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::ListObjectsRequest, request)
        assert_equal(bucket, request.bucket)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_objects, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("list_objects")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_objects(bucket)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'rewrite_object' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#rewrite_object."

    it 'invokes rewrite_object without error' do
      # Create request parameters
      destination_bucket = ''
      destination_object = ''
      source_bucket = ''
      source_object = ''

      # Create expected grpc response
      total_bytes_rewritten = 1109205579
      object_size = 1277221631
      done = true
      rewrite_token = "rewriteToken-1475021434"
      expected_response = {
        total_bytes_rewritten: total_bytes_rewritten,
        object_size: object_size,
        done: done,
        rewrite_token: rewrite_token
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::RewriteResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::RewriteObjectRequest, request)
        assert_equal(destination_bucket, request.destination_bucket)
        assert_equal(destination_object, request.destination_object)
        assert_equal(source_bucket, request.source_bucket)
        assert_equal(source_object, request.source_object)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:rewrite_object, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("rewrite_object")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.rewrite_object(
            destination_bucket,
            destination_object,
            source_bucket,
            source_object
          )

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.rewrite_object(
            destination_bucket,
            destination_object,
            source_bucket,
            source_object
          ) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes rewrite_object with error' do
      # Create request parameters
      destination_bucket = ''
      destination_object = ''
      source_bucket = ''
      source_object = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::RewriteObjectRequest, request)
        assert_equal(destination_bucket, request.destination_bucket)
        assert_equal(destination_object, request.destination_object)
        assert_equal(source_bucket, request.source_bucket)
        assert_equal(source_object, request.source_object)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:rewrite_object, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("rewrite_object")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.rewrite_object(
              destination_bucket,
              destination_object,
              source_bucket,
              source_object
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'start_resumable_write' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#start_resumable_write."

    it 'invokes start_resumable_write without error' do
      # Create expected grpc response
      upload_id = "uploadId1239095321"
      expected_response = { upload_id: upload_id }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::StartResumableWriteResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:start_resumable_write, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("start_resumable_write")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.start_resumable_write

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.start_resumable_write do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes start_resumable_write with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:start_resumable_write, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("start_resumable_write")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.start_resumable_write
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'query_write_status' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#query_write_status."

    it 'invokes query_write_status without error' do
      # Create request parameters
      upload_id = ''

      # Create expected grpc response
      committed_size = 1907158756
      complete = false
      expected_response = { committed_size: committed_size, complete: complete }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::QueryWriteStatusResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::QueryWriteStatusRequest, request)
        assert_equal(upload_id, request.upload_id)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:query_write_status, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("query_write_status")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.query_write_status(upload_id)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.query_write_status(upload_id) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes query_write_status with error' do
      # Create request parameters
      upload_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::QueryWriteStatusRequest, request)
        assert_equal(upload_id, request.upload_id)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:query_write_status, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("query_write_status")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.query_write_status(upload_id)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'patch_object' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#patch_object."

    it 'invokes patch_object without error' do
      # Create request parameters
      bucket = ''
      object = ''

      # Create expected grpc response
      content_encoding = "contentEncoding1916674649"
      content_disposition = "contentDisposition891901169"
      cache_control = "cacheControl1032395168"
      content_language = "contentLanguage-1408137122"
      metageneration = 1048558813
      content_type = "contentType831846208"
      size = 3530753
      component_count = 485073075
      md5_hash = "md5Hash1152095023"
      etag = "etag3123477"
      storage_class = "storageClass2035762868"
      kms_key_name = "kmsKeyName2094986649"
      temporary_hold = false
      name = "name3373707"
      id = "id3355"
      bucket_2 = "bucket2-1603304675"
      generation = 305703192
      expected_response = {
        content_encoding: content_encoding,
        content_disposition: content_disposition,
        cache_control: cache_control,
        content_language: content_language,
        metageneration: metageneration,
        content_type: content_type,
        size: size,
        component_count: component_count,
        md5_hash: md5_hash,
        etag: etag,
        storage_class: storage_class,
        kms_key_name: kms_key_name,
        temporary_hold: temporary_hold,
        name: name,
        id: id,
        bucket: bucket_2,
        generation: generation
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::Object)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::PatchObjectRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(object, request.object)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:patch_object, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("patch_object")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.patch_object(bucket, object)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.patch_object(bucket, object) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes patch_object with error' do
      # Create request parameters
      bucket = ''
      object = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::PatchObjectRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(object, request.object)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:patch_object, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("patch_object")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.patch_object(bucket, object)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_object' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#update_object."

    it 'invokes update_object without error' do
      # Create request parameters
      bucket = ''
      object = ''

      # Create expected grpc response
      content_encoding = "contentEncoding1916674649"
      content_disposition = "contentDisposition891901169"
      cache_control = "cacheControl1032395168"
      content_language = "contentLanguage-1408137122"
      metageneration = 1048558813
      content_type = "contentType831846208"
      size = 3530753
      component_count = 485073075
      md5_hash = "md5Hash1152095023"
      etag = "etag3123477"
      storage_class = "storageClass2035762868"
      kms_key_name = "kmsKeyName2094986649"
      temporary_hold = false
      name = "name3373707"
      id = "id3355"
      bucket_2 = "bucket2-1603304675"
      generation = 305703192
      expected_response = {
        content_encoding: content_encoding,
        content_disposition: content_disposition,
        cache_control: cache_control,
        content_language: content_language,
        metageneration: metageneration,
        content_type: content_type,
        size: size,
        component_count: component_count,
        md5_hash: md5_hash,
        etag: etag,
        storage_class: storage_class,
        kms_key_name: kms_key_name,
        temporary_hold: temporary_hold,
        name: name,
        id: id,
        bucket: bucket_2,
        generation: generation
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::Object)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::UpdateObjectRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(object, request.object)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_object, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("update_object")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.update_object(bucket, object)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_object(bucket, object) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_object with error' do
      # Create request parameters
      bucket = ''
      object = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::UpdateObjectRequest, request)
        assert_equal(bucket, request.bucket)
        assert_equal(object, request.object)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_object, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("update_object")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.update_object(bucket, object)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_object_iam_policy' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#get_object_iam_policy."

    it 'invokes get_object_iam_policy without error' do
      # Create expected grpc response
      version = 351608024
      etag = "21"
      expected_response = { version: version, etag: etag }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::V1::Policy)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_object_iam_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("get_object_iam_policy")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.get_object_iam_policy

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_object_iam_policy do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_object_iam_policy with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_object_iam_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("get_object_iam_policy")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_object_iam_policy
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'set_object_iam_policy' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#set_object_iam_policy."

    it 'invokes set_object_iam_policy without error' do
      # Create expected grpc response
      version = 351608024
      etag = "21"
      expected_response = { version: version, etag: etag }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::V1::Policy)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:set_object_iam_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("set_object_iam_policy")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.set_object_iam_policy

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.set_object_iam_policy do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes set_object_iam_policy with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:set_object_iam_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("set_object_iam_policy")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.set_object_iam_policy
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'test_object_iam_permissions' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#test_object_iam_permissions."

    it 'invokes test_object_iam_permissions without error' do
      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::V1::TestIamPermissionsResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:test_object_iam_permissions, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("test_object_iam_permissions")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.test_object_iam_permissions

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.test_object_iam_permissions do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes test_object_iam_permissions with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:test_object_iam_permissions, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("test_object_iam_permissions")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.test_object_iam_permissions
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'watch_all_objects' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#watch_all_objects."

    it 'invokes watch_all_objects without error' do
      # Create expected grpc response
      id = "id3355"
      resource_id = "resourceId1234537196"
      resource_uri = "resourceUri-384040517"
      token = "token110541305"
      type = "type3575610"
      address = "address-1147692044"
      payload = true
      expected_response = {
        id: id,
        resource_id: resource_id,
        resource_uri: resource_uri,
        token: token,
        type: type,
        address: address,
        payload: payload
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::Channel)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:watch_all_objects, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("watch_all_objects")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.watch_all_objects

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.watch_all_objects do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes watch_all_objects with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:watch_all_objects, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("watch_all_objects")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.watch_all_objects
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_service_account' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#get_service_account."

    it 'invokes get_service_account without error' do
      # Create request parameters
      project_id = ''

      # Create expected grpc response
      email_address = "emailAddress-769510831"
      expected_response = { email_address: email_address }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::ServiceAccount)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::GetProjectServiceAccountRequest, request)
        assert_equal(project_id, request.project_id)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_service_account, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("get_service_account")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.get_service_account(project_id)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_service_account(project_id) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_service_account with error' do
      # Create request parameters
      project_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::GetProjectServiceAccountRequest, request)
        assert_equal(project_id, request.project_id)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_service_account, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("get_service_account")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_service_account(project_id)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_hmac_key' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#create_hmac_key."

    it 'invokes create_hmac_key without error' do
      # Create request parameters
      project_id = ''
      service_account_email = ''

      # Create expected grpc response
      secret = "secret-906277200"
      expected_response = { secret: secret }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::CreateHmacKeyResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::CreateHmacKeyRequest, request)
        assert_equal(project_id, request.project_id)
        assert_equal(service_account_email, request.service_account_email)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_hmac_key, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("create_hmac_key")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.create_hmac_key(project_id, service_account_email)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_hmac_key(project_id, service_account_email) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_hmac_key with error' do
      # Create request parameters
      project_id = ''
      service_account_email = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::CreateHmacKeyRequest, request)
        assert_equal(project_id, request.project_id)
        assert_equal(service_account_email, request.service_account_email)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_hmac_key, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("create_hmac_key")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.create_hmac_key(project_id, service_account_email)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_hmac_key' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#delete_hmac_key."

    it 'invokes delete_hmac_key without error' do
      # Create request parameters
      access_id = ''
      project_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::DeleteHmacKeyRequest, request)
        assert_equal(access_id, request.access_id)
        assert_equal(project_id, request.project_id)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_hmac_key, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("delete_hmac_key")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.delete_hmac_key(access_id, project_id)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_hmac_key(access_id, project_id) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_hmac_key with error' do
      # Create request parameters
      access_id = ''
      project_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::DeleteHmacKeyRequest, request)
        assert_equal(access_id, request.access_id)
        assert_equal(project_id, request.project_id)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_hmac_key, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("delete_hmac_key")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_hmac_key(access_id, project_id)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_hmac_key' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#get_hmac_key."

    it 'invokes get_hmac_key without error' do
      # Create request parameters
      access_id = ''
      project_id = ''

      # Create expected grpc response
      id = "id3355"
      access_id_2 = "accessId2-1032716279"
      project_id_2 = "projectId2939242356"
      service_account_email = "serviceAccountEmail-1300473088"
      state = "state109757585"
      etag = "etag3123477"
      expected_response = {
        id: id,
        access_id: access_id_2,
        project_id: project_id_2,
        service_account_email: service_account_email,
        state: state,
        etag: etag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::HmacKeyMetadata)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::GetHmacKeyRequest, request)
        assert_equal(access_id, request.access_id)
        assert_equal(project_id, request.project_id)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_hmac_key, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("get_hmac_key")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.get_hmac_key(access_id, project_id)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_hmac_key(access_id, project_id) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_hmac_key with error' do
      # Create request parameters
      access_id = ''
      project_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::GetHmacKeyRequest, request)
        assert_equal(access_id, request.access_id)
        assert_equal(project_id, request.project_id)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_hmac_key, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("get_hmac_key")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_hmac_key(access_id, project_id)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_hmac_keys' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#list_hmac_keys."

    it 'invokes list_hmac_keys without error' do
      # Create request parameters
      project_id = ''

      # Create expected grpc response
      next_page_token = "nextPageToken-1530815211"
      expected_response = { next_page_token: next_page_token }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::ListHmacKeysResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::ListHmacKeysRequest, request)
        assert_equal(project_id, request.project_id)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_hmac_keys, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("list_hmac_keys")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.list_hmac_keys(project_id)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.list_hmac_keys(project_id) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes list_hmac_keys with error' do
      # Create request parameters
      project_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::ListHmacKeysRequest, request)
        assert_equal(project_id, request.project_id)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_hmac_keys, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("list_hmac_keys")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_hmac_keys(project_id)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_hmac_key' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Storage::V1::StorageClient#update_hmac_key."

    it 'invokes update_hmac_key without error' do
      # Create request parameters
      access_id = ''
      project_id = ''
      metadata = {}

      # Create expected grpc response
      id = "id3355"
      access_id_2 = "accessId2-1032716279"
      project_id_2 = "projectId2939242356"
      service_account_email = "serviceAccountEmail-1300473088"
      state = "state109757585"
      etag = "etag3123477"
      expected_response = {
        id: id,
        access_id: access_id_2,
        project_id: project_id_2,
        service_account_email: service_account_email,
        state: state,
        etag: etag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Storage::V1::HmacKeyMetadata)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::UpdateHmacKeyRequest, request)
        assert_equal(access_id, request.access_id)
        assert_equal(project_id, request.project_id)
        assert_equal(Google::Gax::to_proto(metadata, Google::Storage::V1::HmacKeyMetadata), request.metadata)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_hmac_key, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("update_hmac_key")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          response = client.update_hmac_key(
            access_id,
            project_id,
            metadata
          )

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_hmac_key(
            access_id,
            project_id,
            metadata
          ) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_hmac_key with error' do
      # Create request parameters
      access_id = ''
      project_id = ''
      metadata = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Storage::V1::UpdateHmacKeyRequest, request)
        assert_equal(access_id, request.access_id)
        assert_equal(project_id, request.project_id)
        assert_equal(Google::Gax::to_proto(metadata, Google::Storage::V1::HmacKeyMetadata), request.metadata)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_hmac_key, mock_method)

      # Mock auth layer
      mock_credentials = MockStorageCredentials_v1.new("update_hmac_key")

      Google::Storage::V1::Storage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Storage::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Storage.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.update_hmac_key(
              access_id,
              project_id,
              metadata
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end