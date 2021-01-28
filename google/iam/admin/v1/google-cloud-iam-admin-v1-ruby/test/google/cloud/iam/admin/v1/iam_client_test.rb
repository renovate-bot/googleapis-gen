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

require "google/cloud/iam/admin"
require "google/cloud/iam/admin/v1/iam_client"
require "google/iam/admin/v1/iam_services_pb"

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

class MockIAMCredentials_v1 < Google::Cloud::Iam::Admin::V1::Credentials
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

describe Google::Cloud::Iam::Admin::V1::IamClient do

  describe 'list_service_accounts' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Iam::Admin::V1::IamClient#list_service_accounts."

    it 'invokes list_service_accounts without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.project_path("[PROJECT]")

      # Create expected grpc response
      next_page_token = ""
      accounts_element = {}
      accounts = [accounts_element]
      expected_response = { next_page_token: next_page_token, accounts: accounts }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::Admin::V1::ListServiceAccountsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Admin::V1::ListServiceAccountsRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_service_accounts, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("list_service_accounts")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          response = client.list_service_accounts(formatted_name)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.accounts.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_service_accounts with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.project_path("[PROJECT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Admin::V1::ListServiceAccountsRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_service_accounts, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("list_service_accounts")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_service_accounts(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_service_account' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Iam::Admin::V1::IamClient#get_service_account."

    it 'invokes get_service_account without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      project_id = "projectId-1969970175"
      unique_id = "uniqueId-538310583"
      email = "email96619420"
      display_name = "displayName1615086568"
      etag = "21"
      oauth2_client_id = "oauth2ClientId-1833466037"
      expected_response = {
        name: name_2,
        project_id: project_id,
        unique_id: unique_id,
        email: email,
        display_name: display_name,
        etag: etag,
        oauth2_client_id: oauth2_client_id
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::Admin::V1::ServiceAccount)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Admin::V1::GetServiceAccountRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_service_account, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("get_service_account")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          response = client.get_service_account(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_service_account(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_service_account with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Admin::V1::GetServiceAccountRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_service_account, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("get_service_account")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_service_account(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_service_account' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Iam::Admin::V1::IamClient#create_service_account."

    it 'invokes create_service_account without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.project_path("[PROJECT]")
      account_id = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      project_id = "projectId-1969970175"
      unique_id = "uniqueId-538310583"
      email = "email96619420"
      display_name = "displayName1615086568"
      etag = "21"
      oauth2_client_id = "oauth2ClientId-1833466037"
      expected_response = {
        name: name_2,
        project_id: project_id,
        unique_id: unique_id,
        email: email,
        display_name: display_name,
        etag: etag,
        oauth2_client_id: oauth2_client_id
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::Admin::V1::ServiceAccount)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Admin::V1::CreateServiceAccountRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(account_id, request.account_id)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_service_account, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("create_service_account")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          response = client.create_service_account(formatted_name, account_id)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_service_account(formatted_name, account_id) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_service_account with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.project_path("[PROJECT]")
      account_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Admin::V1::CreateServiceAccountRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(account_id, request.account_id)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_service_account, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("create_service_account")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.create_service_account(formatted_name, account_id)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_service_account' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Iam::Admin::V1::IamClient#update_service_account."

    it 'invokes update_service_account without error' do
      # Create expected grpc response
      name = "name3373707"
      project_id = "projectId-1969970175"
      unique_id = "uniqueId-538310583"
      email = "email96619420"
      display_name = "displayName1615086568"
      etag = "21"
      oauth2_client_id = "oauth2ClientId-1833466037"
      expected_response = {
        name: name,
        project_id: project_id,
        unique_id: unique_id,
        email: email,
        display_name: display_name,
        etag: etag,
        oauth2_client_id: oauth2_client_id
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::Admin::V1::ServiceAccount)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_service_account, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("update_service_account")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          response = client.update_service_account

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_service_account do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_service_account with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_service_account, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("update_service_account")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.update_service_account
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_service_account' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Iam::Admin::V1::IamClient#delete_service_account."

    it 'invokes delete_service_account without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Admin::V1::DeleteServiceAccountRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_service_account, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("delete_service_account")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          response = client.delete_service_account(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_service_account(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_service_account with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Admin::V1::DeleteServiceAccountRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_service_account, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("delete_service_account")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_service_account(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_service_account_keys' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Iam::Admin::V1::IamClient#list_service_account_keys."

    it 'invokes list_service_account_keys without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::Admin::V1::ListServiceAccountKeysResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Admin::V1::ListServiceAccountKeysRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_service_account_keys, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("list_service_account_keys")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          response = client.list_service_account_keys(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.list_service_account_keys(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes list_service_account_keys with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Admin::V1::ListServiceAccountKeysRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_service_account_keys, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("list_service_account_keys")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_service_account_keys(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_service_account_key' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Iam::Admin::V1::IamClient#get_service_account_key."

    it 'invokes get_service_account_key without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.key_path("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      private_key_data = "-58"
      public_key_data = "-96"
      expected_response = {
        name: name_2,
        private_key_data: private_key_data,
        public_key_data: public_key_data
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::Admin::V1::ServiceAccountKey)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Admin::V1::GetServiceAccountKeyRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_service_account_key, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("get_service_account_key")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          response = client.get_service_account_key(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_service_account_key(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_service_account_key with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.key_path("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Admin::V1::GetServiceAccountKeyRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_service_account_key, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("get_service_account_key")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_service_account_key(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_service_account_key' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Iam::Admin::V1::IamClient#create_service_account_key."

    it 'invokes create_service_account_key without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      private_key_data = "-58"
      public_key_data = "-96"
      expected_response = {
        name: name_2,
        private_key_data: private_key_data,
        public_key_data: public_key_data
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::Admin::V1::ServiceAccountKey)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Admin::V1::CreateServiceAccountKeyRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_service_account_key, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("create_service_account_key")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          response = client.create_service_account_key(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_service_account_key(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_service_account_key with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Admin::V1::CreateServiceAccountKeyRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_service_account_key, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("create_service_account_key")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.create_service_account_key(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_service_account_key' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Iam::Admin::V1::IamClient#delete_service_account_key."

    it 'invokes delete_service_account_key without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.key_path("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Admin::V1::DeleteServiceAccountKeyRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_service_account_key, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("delete_service_account_key")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          response = client.delete_service_account_key(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_service_account_key(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_service_account_key with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.key_path("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Admin::V1::DeleteServiceAccountKeyRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_service_account_key, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("delete_service_account_key")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_service_account_key(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'sign_blob' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Iam::Admin::V1::IamClient#sign_blob."

    it 'invokes sign_blob without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")
      bytes_to_sign = ''

      # Create expected grpc response
      key_id = "keyId-1134673157"
      signature = "-72"
      expected_response = { key_id: key_id, signature: signature }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::Admin::V1::SignBlobResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Admin::V1::SignBlobRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(bytes_to_sign, request.bytes_to_sign)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:sign_blob, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("sign_blob")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          response = client.sign_blob(formatted_name, bytes_to_sign)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.sign_blob(formatted_name, bytes_to_sign) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes sign_blob with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")
      bytes_to_sign = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Admin::V1::SignBlobRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(bytes_to_sign, request.bytes_to_sign)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:sign_blob, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("sign_blob")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.sign_blob(formatted_name, bytes_to_sign)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'sign_jwt' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Iam::Admin::V1::IamClient#sign_jwt."

    it 'invokes sign_jwt without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")
      payload = ''

      # Create expected grpc response
      key_id = "keyId-1134673157"
      signed_jwt = "signedJwt-979546844"
      expected_response = { key_id: key_id, signed_jwt: signed_jwt }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::Admin::V1::SignJwtResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Admin::V1::SignJwtRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(payload, request.payload)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:sign_jwt, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("sign_jwt")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          response = client.sign_jwt(formatted_name, payload)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.sign_jwt(formatted_name, payload) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes sign_jwt with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")
      payload = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Admin::V1::SignJwtRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(payload, request.payload)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:sign_jwt, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("sign_jwt")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.sign_jwt(formatted_name, payload)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_iam_policy' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Iam::Admin::V1::IamClient#get_iam_policy."

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
      mock_stub = MockGrpcClientStub_v1.new(:get_iam_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("get_iam_policy")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

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
      mock_stub = MockGrpcClientStub_v1.new(:get_iam_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("get_iam_policy")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_iam_policy(resource)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'set_iam_policy' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Iam::Admin::V1::IamClient#set_iam_policy."

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
      mock_stub = MockGrpcClientStub_v1.new(:set_iam_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("set_iam_policy")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

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
      mock_stub = MockGrpcClientStub_v1.new(:set_iam_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("set_iam_policy")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.set_iam_policy(resource, policy)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'test_iam_permissions' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Iam::Admin::V1::IamClient#test_iam_permissions."

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
      mock_stub = MockGrpcClientStub_v1.new(:test_iam_permissions, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("test_iam_permissions")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

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
      mock_stub = MockGrpcClientStub_v1.new(:test_iam_permissions, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("test_iam_permissions")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.test_iam_permissions(resource, permissions)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'query_grantable_roles' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Iam::Admin::V1::IamClient#query_grantable_roles."

    it 'invokes query_grantable_roles without error' do
      # Create request parameters
      full_resource_name = ''

      # Create expected grpc response
      next_page_token = ""
      roles_element = {}
      roles = [roles_element]
      expected_response = { next_page_token: next_page_token, roles: roles }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::Admin::V1::QueryGrantableRolesResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Admin::V1::QueryGrantableRolesRequest, request)
        assert_equal(full_resource_name, request.full_resource_name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:query_grantable_roles, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("query_grantable_roles")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          response = client.query_grantable_roles(full_resource_name)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.roles.to_a, response.to_a)
        end
      end
    end

    it 'invokes query_grantable_roles with error' do
      # Create request parameters
      full_resource_name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Admin::V1::QueryGrantableRolesRequest, request)
        assert_equal(full_resource_name, request.full_resource_name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:query_grantable_roles, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("query_grantable_roles")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.query_grantable_roles(full_resource_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_roles' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Iam::Admin::V1::IamClient#list_roles."

    it 'invokes list_roles without error' do
      # Create expected grpc response
      next_page_token = ""
      roles_element = {}
      roles = [roles_element]
      expected_response = { next_page_token: next_page_token, roles: roles }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::Admin::V1::ListRolesResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_roles, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("list_roles")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          response = client.list_roles

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.roles.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_roles with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_roles, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("list_roles")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_roles
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_role' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Iam::Admin::V1::IamClient#get_role."

    it 'invokes get_role without error' do
      # Create expected grpc response
      name = "name3373707"
      title = "title110371416"
      description = "description-1724546052"
      etag = "21"
      deleted = false
      expected_response = {
        name: name,
        title: title,
        description: description,
        etag: etag,
        deleted: deleted
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::Admin::V1::Role)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_role, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("get_role")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          response = client.get_role

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_role do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_role with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_role, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("get_role")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_role
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_role' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Iam::Admin::V1::IamClient#create_role."

    it 'invokes create_role without error' do
      # Create expected grpc response
      name = "name3373707"
      title = "title110371416"
      description = "description-1724546052"
      etag = "21"
      deleted = false
      expected_response = {
        name: name,
        title: title,
        description: description,
        etag: etag,
        deleted: deleted
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::Admin::V1::Role)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_role, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("create_role")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          response = client.create_role

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_role do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_role with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_role, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("create_role")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.create_role
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_role' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Iam::Admin::V1::IamClient#update_role."

    it 'invokes update_role without error' do
      # Create expected grpc response
      name = "name3373707"
      title = "title110371416"
      description = "description-1724546052"
      etag = "21"
      deleted = false
      expected_response = {
        name: name,
        title: title,
        description: description,
        etag: etag,
        deleted: deleted
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::Admin::V1::Role)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_role, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("update_role")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          response = client.update_role

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_role do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_role with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_role, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("update_role")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.update_role
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_role' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Iam::Admin::V1::IamClient#delete_role."

    it 'invokes delete_role without error' do
      # Create expected grpc response
      name = "name3373707"
      title = "title110371416"
      description = "description-1724546052"
      etag = "21"
      deleted = false
      expected_response = {
        name: name,
        title: title,
        description: description,
        etag: etag,
        deleted: deleted
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::Admin::V1::Role)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_role, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("delete_role")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          response = client.delete_role

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.delete_role do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_role with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_role, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("delete_role")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_role
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'undelete_role' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Iam::Admin::V1::IamClient#undelete_role."

    it 'invokes undelete_role without error' do
      # Create expected grpc response
      name = "name3373707"
      title = "title110371416"
      description = "description-1724546052"
      etag = "21"
      deleted = false
      expected_response = {
        name: name,
        title: title,
        description: description,
        etag: etag,
        deleted: deleted
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::Admin::V1::Role)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:undelete_role, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("undelete_role")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          response = client.undelete_role

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.undelete_role do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes undelete_role with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:undelete_role, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("undelete_role")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.undelete_role
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'query_testable_permissions' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Iam::Admin::V1::IamClient#query_testable_permissions."

    it 'invokes query_testable_permissions without error' do
      # Create expected grpc response
      next_page_token = ""
      permissions_element = {}
      permissions = [permissions_element]
      expected_response = { next_page_token: next_page_token, permissions: permissions }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::Admin::V1::QueryTestablePermissionsResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:query_testable_permissions, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("query_testable_permissions")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          response = client.query_testable_permissions

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.permissions.to_a, response.to_a)
        end
      end
    end

    it 'invokes query_testable_permissions with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:query_testable_permissions, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentials_v1.new("query_testable_permissions")

      Google::Iam::Admin::V1::IAM::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Admin::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.query_testable_permissions
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end