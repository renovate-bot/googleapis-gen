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
require "google/cloud/gaming/v1_beta/realms_service_client"
require "google/cloud/gaming/v1beta/realms_service_services_pb"
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

class MockRealmsServiceCredentials_v1beta < Google::Cloud::Gaming::V1Beta::Credentials
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

describe Google::Cloud::Gaming::V1Beta::RealmsServiceClient do

  describe 'list_realms' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1Beta::RealmsServiceClient#list_realms."

    it 'invokes list_realms without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Gaming::V1Beta::RealmsServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      realms_element = {}
      realms = [realms_element]
      expected_response = { next_page_token: next_page_token, realms: realms }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gaming::V1beta::ListRealmsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::ListRealmsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:list_realms, mock_method)

      # Mock auth layer
      mock_credentials = MockRealmsServiceCredentials_v1beta.new("list_realms")

      Google::Cloud::Gaming::V1beta::RealmsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::Realms.new

          # Call method
          response = client.list_realms(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.realms.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_realms with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Gaming::V1Beta::RealmsServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::ListRealmsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:list_realms, mock_method)

      # Mock auth layer
      mock_credentials = MockRealmsServiceCredentials_v1beta.new("list_realms")

      Google::Cloud::Gaming::V1beta::RealmsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::Realms.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.list_realms(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_realm' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1Beta::RealmsServiceClient#get_realm."

    it 'invokes get_realm without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Gaming::V1Beta::RealmsServiceClient.realm_path("[PROJECT]", "[LOCATION]", "[REALM]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      time_zone = "timeZone36848094"
      etag = "etag3123477"
      description = "description-1724546052"
      expected_response = {
        name: name_2,
        time_zone: time_zone,
        etag: etag,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gaming::V1beta::Realm)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::GetRealmRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:get_realm, mock_method)

      # Mock auth layer
      mock_credentials = MockRealmsServiceCredentials_v1beta.new("get_realm")

      Google::Cloud::Gaming::V1beta::RealmsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::Realms.new

          # Call method
          response = client.get_realm(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_realm(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_realm with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Gaming::V1Beta::RealmsServiceClient.realm_path("[PROJECT]", "[LOCATION]", "[REALM]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::GetRealmRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:get_realm, mock_method)

      # Mock auth layer
      mock_credentials = MockRealmsServiceCredentials_v1beta.new("get_realm")

      Google::Cloud::Gaming::V1beta::RealmsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::Realms.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.get_realm(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_realm' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1Beta::RealmsServiceClient#create_realm."

    it 'invokes create_realm without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Gaming::V1Beta::RealmsServiceClient.location_path("[PROJECT]", "[LOCATION]")
      realm_id = ''
      realm = {}

      # Create expected grpc response
      name = "name3373707"
      time_zone = "timeZone36848094"
      etag = "etag3123477"
      description = "description-1724546052"
      expected_response = {
        name: name,
        time_zone: time_zone,
        etag: etag,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gaming::V1beta::Realm)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_realm_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::CreateRealmRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(realm_id, request.realm_id)
        assert_equal(Google::Gax::to_proto(realm, Google::Cloud::Gaming::V1beta::Realm), request.realm)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:create_realm, mock_method)

      # Mock auth layer
      mock_credentials = MockRealmsServiceCredentials_v1beta.new("create_realm")

      Google::Cloud::Gaming::V1beta::RealmsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::Realms.new

          # Call method
          response = client.create_realm(
            formatted_parent,
            realm_id,
            realm
          )

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes create_realm and returns an operation error.' do
      # Create request parameters
      formatted_parent = Google::Cloud::Gaming::V1Beta::RealmsServiceClient.location_path("[PROJECT]", "[LOCATION]")
      realm_id = ''
      realm = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Gaming::V1Beta::RealmsServiceClient#create_realm.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_realm_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::CreateRealmRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(realm_id, request.realm_id)
        assert_equal(Google::Gax::to_proto(realm, Google::Cloud::Gaming::V1beta::Realm), request.realm)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:create_realm, mock_method)

      # Mock auth layer
      mock_credentials = MockRealmsServiceCredentials_v1beta.new("create_realm")

      Google::Cloud::Gaming::V1beta::RealmsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::Realms.new

          # Call method
          response = client.create_realm(
            formatted_parent,
            realm_id,
            realm
          )

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes create_realm with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Gaming::V1Beta::RealmsServiceClient.location_path("[PROJECT]", "[LOCATION]")
      realm_id = ''
      realm = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::CreateRealmRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(realm_id, request.realm_id)
        assert_equal(Google::Gax::to_proto(realm, Google::Cloud::Gaming::V1beta::Realm), request.realm)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:create_realm, mock_method)

      # Mock auth layer
      mock_credentials = MockRealmsServiceCredentials_v1beta.new("create_realm")

      Google::Cloud::Gaming::V1beta::RealmsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::Realms.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.create_realm(
              formatted_parent,
              realm_id,
              realm
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_realm' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1Beta::RealmsServiceClient#delete_realm."

    it 'invokes delete_realm without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Gaming::V1Beta::RealmsServiceClient.realm_path("[PROJECT]", "[LOCATION]", "[REALM]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Protobuf::Empty)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_realm_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::DeleteRealmRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:delete_realm, mock_method)

      # Mock auth layer
      mock_credentials = MockRealmsServiceCredentials_v1beta.new("delete_realm")

      Google::Cloud::Gaming::V1beta::RealmsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::Realms.new

          # Call method
          response = client.delete_realm(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes delete_realm and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Gaming::V1Beta::RealmsServiceClient.realm_path("[PROJECT]", "[LOCATION]", "[REALM]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Gaming::V1Beta::RealmsServiceClient#delete_realm.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_realm_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::DeleteRealmRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:delete_realm, mock_method)

      # Mock auth layer
      mock_credentials = MockRealmsServiceCredentials_v1beta.new("delete_realm")

      Google::Cloud::Gaming::V1beta::RealmsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::Realms.new

          # Call method
          response = client.delete_realm(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes delete_realm with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Gaming::V1Beta::RealmsServiceClient.realm_path("[PROJECT]", "[LOCATION]", "[REALM]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::DeleteRealmRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:delete_realm, mock_method)

      # Mock auth layer
      mock_credentials = MockRealmsServiceCredentials_v1beta.new("delete_realm")

      Google::Cloud::Gaming::V1beta::RealmsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::Realms.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.delete_realm(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_realm' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1Beta::RealmsServiceClient#update_realm."

    it 'invokes update_realm without error' do
      # Create request parameters
      realm = {}
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      time_zone = "timeZone36848094"
      etag = "etag3123477"
      description = "description-1724546052"
      expected_response = {
        name: name,
        time_zone: time_zone,
        etag: etag,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gaming::V1beta::Realm)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_realm_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::UpdateRealmRequest, request)
        assert_equal(Google::Gax::to_proto(realm, Google::Cloud::Gaming::V1beta::Realm), request.realm)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:update_realm, mock_method)

      # Mock auth layer
      mock_credentials = MockRealmsServiceCredentials_v1beta.new("update_realm")

      Google::Cloud::Gaming::V1beta::RealmsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::Realms.new

          # Call method
          response = client.update_realm(realm, update_mask)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes update_realm and returns an operation error.' do
      # Create request parameters
      realm = {}
      update_mask = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Gaming::V1Beta::RealmsServiceClient#update_realm.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_realm_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::UpdateRealmRequest, request)
        assert_equal(Google::Gax::to_proto(realm, Google::Cloud::Gaming::V1beta::Realm), request.realm)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:update_realm, mock_method)

      # Mock auth layer
      mock_credentials = MockRealmsServiceCredentials_v1beta.new("update_realm")

      Google::Cloud::Gaming::V1beta::RealmsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::Realms.new

          # Call method
          response = client.update_realm(realm, update_mask)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes update_realm with error' do
      # Create request parameters
      realm = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::UpdateRealmRequest, request)
        assert_equal(Google::Gax::to_proto(realm, Google::Cloud::Gaming::V1beta::Realm), request.realm)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:update_realm, mock_method)

      # Mock auth layer
      mock_credentials = MockRealmsServiceCredentials_v1beta.new("update_realm")

      Google::Cloud::Gaming::V1beta::RealmsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::Realms.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.update_realm(realm, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'preview_realm_update' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::Gaming::V1Beta::RealmsServiceClient#preview_realm_update."

    it 'invokes preview_realm_update without error' do
      # Create request parameters
      realm = {}
      update_mask = {}

      # Create expected grpc response
      etag = "etag3123477"
      expected_response = { etag: etag }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gaming::V1beta::PreviewRealmUpdateResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::PreviewRealmUpdateRequest, request)
        assert_equal(Google::Gax::to_proto(realm, Google::Cloud::Gaming::V1beta::Realm), request.realm)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:preview_realm_update, mock_method)

      # Mock auth layer
      mock_credentials = MockRealmsServiceCredentials_v1beta.new("preview_realm_update")

      Google::Cloud::Gaming::V1beta::RealmsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::Realms.new

          # Call method
          response = client.preview_realm_update(realm, update_mask)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.preview_realm_update(realm, update_mask) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes preview_realm_update with error' do
      # Create request parameters
      realm = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gaming::V1beta::PreviewRealmUpdateRequest, request)
        assert_equal(Google::Gax::to_proto(realm, Google::Cloud::Gaming::V1beta::Realm), request.realm)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:preview_realm_update, mock_method)

      # Mock auth layer
      mock_credentials = MockRealmsServiceCredentials_v1beta.new("preview_realm_update")

      Google::Cloud::Gaming::V1beta::RealmsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gaming::V1Beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gaming::V1Beta::Realms.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.preview_realm_update(realm, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end