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

require "google/cloud/bigquery/connection"
require "google/cloud/bigquery/connection/v1beta1/connection_service_client"
require "google/cloud/bigquery/connection/v1beta1/connection_services_pb"

class CustomTestError_v1beta1 < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v1beta1

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

class MockConnectionServiceCredentials_v1beta1 < Google::Cloud::Bigquery::Connection::V1beta1::Credentials
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

describe Google::Cloud::Bigquery::Connection::V1beta1::ConnectionServiceClient do

  describe 'create_connection' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Connection::V1beta1::ConnectionServiceClient#create_connection."

    it 'invokes create_connection without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Bigquery::Connection::V1beta1::ConnectionServiceClient.location_path("[PROJECT]", "[LOCATION]")
      connection = {}

      # Create expected grpc response
      name = "name3373707"
      friendly_name = "friendlyName1451097503"
      description = "description-1724546052"
      creation_time = 1932333101
      last_modified_time = 671513446
      has_credential = true
      expected_response = {
        name: name,
        friendly_name: friendly_name,
        description: description,
        creation_time: creation_time,
        last_modified_time: last_modified_time,
        has_credential: has_credential
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Connection::V1beta1::Connection)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Connection::V1beta1::CreateConnectionRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(connection, Google::Cloud::Bigquery::Connection::V1beta1::Connection), request.connection)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_connection, mock_method)

      # Mock auth layer
      mock_credentials = MockConnectionServiceCredentials_v1beta1.new("create_connection")

      Google::Cloud::Bigquery::Connection::V1beta1::ConnectionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Connection::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)

          # Call method
          response = client.create_connection(formatted_parent, connection)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_connection(formatted_parent, connection) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_connection with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Bigquery::Connection::V1beta1::ConnectionServiceClient.location_path("[PROJECT]", "[LOCATION]")
      connection = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Connection::V1beta1::CreateConnectionRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(connection, Google::Cloud::Bigquery::Connection::V1beta1::Connection), request.connection)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_connection, mock_method)

      # Mock auth layer
      mock_credentials = MockConnectionServiceCredentials_v1beta1.new("create_connection")

      Google::Cloud::Bigquery::Connection::V1beta1::ConnectionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Connection::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.create_connection(formatted_parent, connection)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_connection' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Connection::V1beta1::ConnectionServiceClient#get_connection."

    it 'invokes get_connection without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Bigquery::Connection::V1beta1::ConnectionServiceClient.connection_path("[PROJECT]", "[LOCATION]", "[CONNECTION]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      friendly_name = "friendlyName1451097503"
      description = "description-1724546052"
      creation_time = 1932333101
      last_modified_time = 671513446
      has_credential = true
      expected_response = {
        name: name_2,
        friendly_name: friendly_name,
        description: description,
        creation_time: creation_time,
        last_modified_time: last_modified_time,
        has_credential: has_credential
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Connection::V1beta1::Connection)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Connection::V1beta1::GetConnectionRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_connection, mock_method)

      # Mock auth layer
      mock_credentials = MockConnectionServiceCredentials_v1beta1.new("get_connection")

      Google::Cloud::Bigquery::Connection::V1beta1::ConnectionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Connection::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)

          # Call method
          response = client.get_connection(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_connection(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_connection with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Bigquery::Connection::V1beta1::ConnectionServiceClient.connection_path("[PROJECT]", "[LOCATION]", "[CONNECTION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Connection::V1beta1::GetConnectionRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_connection, mock_method)

      # Mock auth layer
      mock_credentials = MockConnectionServiceCredentials_v1beta1.new("get_connection")

      Google::Cloud::Bigquery::Connection::V1beta1::ConnectionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Connection::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.get_connection(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_connections' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Connection::V1beta1::ConnectionServiceClient#list_connections."

    it 'invokes list_connections without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Bigquery::Connection::V1beta1::ConnectionServiceClient.location_path("[PROJECT]", "[LOCATION]")
      max_results = {}

      # Create expected grpc response
      next_page_token = "nextPageToken-1530815211"
      expected_response = { next_page_token: next_page_token }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Connection::V1beta1::ListConnectionsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Connection::V1beta1::ListConnectionsRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(max_results, Google::Protobuf::UInt32Value), request.max_results)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_connections, mock_method)

      # Mock auth layer
      mock_credentials = MockConnectionServiceCredentials_v1beta1.new("list_connections")

      Google::Cloud::Bigquery::Connection::V1beta1::ConnectionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Connection::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)

          # Call method
          response = client.list_connections(formatted_parent, max_results)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.list_connections(formatted_parent, max_results) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes list_connections with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Bigquery::Connection::V1beta1::ConnectionServiceClient.location_path("[PROJECT]", "[LOCATION]")
      max_results = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Connection::V1beta1::ListConnectionsRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(max_results, Google::Protobuf::UInt32Value), request.max_results)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_connections, mock_method)

      # Mock auth layer
      mock_credentials = MockConnectionServiceCredentials_v1beta1.new("list_connections")

      Google::Cloud::Bigquery::Connection::V1beta1::ConnectionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Connection::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.list_connections(formatted_parent, max_results)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_connection' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Connection::V1beta1::ConnectionServiceClient#update_connection."

    it 'invokes update_connection without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Bigquery::Connection::V1beta1::ConnectionServiceClient.connection_path("[PROJECT]", "[LOCATION]", "[CONNECTION]")
      connection = {}
      update_mask = {}

      # Create expected grpc response
      name_2 = "name2-1052831874"
      friendly_name = "friendlyName1451097503"
      description = "description-1724546052"
      creation_time = 1932333101
      last_modified_time = 671513446
      has_credential = true
      expected_response = {
        name: name_2,
        friendly_name: friendly_name,
        description: description,
        creation_time: creation_time,
        last_modified_time: last_modified_time,
        has_credential: has_credential
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Connection::V1beta1::Connection)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Connection::V1beta1::UpdateConnectionRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(Google::Gax::to_proto(connection, Google::Cloud::Bigquery::Connection::V1beta1::Connection), request.connection)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_connection, mock_method)

      # Mock auth layer
      mock_credentials = MockConnectionServiceCredentials_v1beta1.new("update_connection")

      Google::Cloud::Bigquery::Connection::V1beta1::ConnectionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Connection::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)

          # Call method
          response = client.update_connection(
            formatted_name,
            connection,
            update_mask
          )

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_connection(
            formatted_name,
            connection,
            update_mask
          ) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_connection with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Bigquery::Connection::V1beta1::ConnectionServiceClient.connection_path("[PROJECT]", "[LOCATION]", "[CONNECTION]")
      connection = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Connection::V1beta1::UpdateConnectionRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(Google::Gax::to_proto(connection, Google::Cloud::Bigquery::Connection::V1beta1::Connection), request.connection)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_connection, mock_method)

      # Mock auth layer
      mock_credentials = MockConnectionServiceCredentials_v1beta1.new("update_connection")

      Google::Cloud::Bigquery::Connection::V1beta1::ConnectionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Connection::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.update_connection(
              formatted_name,
              connection,
              update_mask
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_connection_credential' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Connection::V1beta1::ConnectionServiceClient#update_connection_credential."

    it 'invokes update_connection_credential without error' do
      # Create request parameters
      name = ''
      credential = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Connection::V1beta1::UpdateConnectionCredentialRequest, request)
        assert_equal(name, request.name)
        assert_equal(Google::Gax::to_proto(credential, Google::Cloud::Bigquery::Connection::V1beta1::ConnectionCredential), request.credential)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_connection_credential, mock_method)

      # Mock auth layer
      mock_credentials = MockConnectionServiceCredentials_v1beta1.new("update_connection_credential")

      Google::Cloud::Bigquery::Connection::V1beta1::ConnectionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Connection::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)

          # Call method
          response = client.update_connection_credential(name, credential)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.update_connection_credential(name, credential) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_connection_credential with error' do
      # Create request parameters
      name = ''
      credential = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Connection::V1beta1::UpdateConnectionCredentialRequest, request)
        assert_equal(name, request.name)
        assert_equal(Google::Gax::to_proto(credential, Google::Cloud::Bigquery::Connection::V1beta1::ConnectionCredential), request.credential)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_connection_credential, mock_method)

      # Mock auth layer
      mock_credentials = MockConnectionServiceCredentials_v1beta1.new("update_connection_credential")

      Google::Cloud::Bigquery::Connection::V1beta1::ConnectionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Connection::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.update_connection_credential(name, credential)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_connection' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Connection::V1beta1::ConnectionServiceClient#delete_connection."

    it 'invokes delete_connection without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Bigquery::Connection::V1beta1::ConnectionServiceClient.connection_path("[PROJECT]", "[LOCATION]", "[CONNECTION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Connection::V1beta1::DeleteConnectionRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_connection, mock_method)

      # Mock auth layer
      mock_credentials = MockConnectionServiceCredentials_v1beta1.new("delete_connection")

      Google::Cloud::Bigquery::Connection::V1beta1::ConnectionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Connection::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)

          # Call method
          response = client.delete_connection(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_connection(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_connection with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Bigquery::Connection::V1beta1::ConnectionServiceClient.connection_path("[PROJECT]", "[LOCATION]", "[CONNECTION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Connection::V1beta1::DeleteConnectionRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_connection, mock_method)

      # Mock auth layer
      mock_credentials = MockConnectionServiceCredentials_v1beta1.new("delete_connection")

      Google::Cloud::Bigquery::Connection::V1beta1::ConnectionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Connection::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.delete_connection(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_iam_policy' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Connection::V1beta1::ConnectionServiceClient#get_iam_policy."

    it 'invokes get_iam_policy without error' do
      # Create request parameters
      resource = ''

      # Create expected grpc response
      version = 351608024
      etag = "21"
      expected_response = { version: version, etag: etag }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::V1::Policy)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1::GetIamPolicyRequest, request)
        assert_equal(resource, request.resource)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_iam_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockConnectionServiceCredentials_v1beta1.new("get_iam_policy")

      Google::Cloud::Bigquery::Connection::V1beta1::ConnectionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Connection::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)

          # Call method
          response = client.get_iam_policy(resource)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_iam_policy(resource) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_iam_policy with error' do
      # Create request parameters
      resource = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1::GetIamPolicyRequest, request)
        assert_equal(resource, request.resource)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_iam_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockConnectionServiceCredentials_v1beta1.new("get_iam_policy")

      Google::Cloud::Bigquery::Connection::V1beta1::ConnectionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Connection::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.get_iam_policy(resource)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'set_iam_policy' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Connection::V1beta1::ConnectionServiceClient#set_iam_policy."

    it 'invokes set_iam_policy without error' do
      # Create request parameters
      resource = ''
      policy = {}

      # Create expected grpc response
      version = 351608024
      etag = "21"
      expected_response = { version: version, etag: etag }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::V1::Policy)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1::SetIamPolicyRequest, request)
        assert_equal(resource, request.resource)
        assert_equal(Google::Gax::to_proto(policy, Google::Iam::V1::Policy), request.policy)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:set_iam_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockConnectionServiceCredentials_v1beta1.new("set_iam_policy")

      Google::Cloud::Bigquery::Connection::V1beta1::ConnectionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Connection::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)

          # Call method
          response = client.set_iam_policy(resource, policy)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.set_iam_policy(resource, policy) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes set_iam_policy with error' do
      # Create request parameters
      resource = ''
      policy = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1::SetIamPolicyRequest, request)
        assert_equal(resource, request.resource)
        assert_equal(Google::Gax::to_proto(policy, Google::Iam::V1::Policy), request.policy)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:set_iam_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockConnectionServiceCredentials_v1beta1.new("set_iam_policy")

      Google::Cloud::Bigquery::Connection::V1beta1::ConnectionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Connection::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.set_iam_policy(resource, policy)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'test_iam_permissions' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Connection::V1beta1::ConnectionServiceClient#test_iam_permissions."

    it 'invokes test_iam_permissions without error' do
      # Create request parameters
      resource = ''
      permissions = []

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::V1::TestIamPermissionsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1::TestIamPermissionsRequest, request)
        assert_equal(resource, request.resource)
        assert_equal(permissions, request.permissions)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:test_iam_permissions, mock_method)

      # Mock auth layer
      mock_credentials = MockConnectionServiceCredentials_v1beta1.new("test_iam_permissions")

      Google::Cloud::Bigquery::Connection::V1beta1::ConnectionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Connection::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)

          # Call method
          response = client.test_iam_permissions(resource, permissions)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.test_iam_permissions(resource, permissions) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes test_iam_permissions with error' do
      # Create request parameters
      resource = ''
      permissions = []

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1::TestIamPermissionsRequest, request)
        assert_equal(resource, request.resource)
        assert_equal(permissions, request.permissions)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:test_iam_permissions, mock_method)

      # Mock auth layer
      mock_credentials = MockConnectionServiceCredentials_v1beta1.new("test_iam_permissions")

      Google::Cloud::Bigquery::Connection::V1beta1::ConnectionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Connection::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.test_iam_permissions(resource, permissions)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end