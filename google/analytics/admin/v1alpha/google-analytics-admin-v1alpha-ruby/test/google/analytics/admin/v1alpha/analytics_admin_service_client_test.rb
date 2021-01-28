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

require "google/analytics/admin/v1alpha"
require "google/analytics/admin/v1alpha/analytics_admin_service_client"
require "google/analytics/admin/v1alpha/analytics_admin_services_pb"

class CustomTestError_v1alpha < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v1alpha

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

class MockAnalyticsAdminServiceCredentials_v1alpha < Google::Analytics::Admin::V1alpha::Credentials
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

describe Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient do

  describe 'get_account' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#get_account."

    it 'invokes get_account without error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      region_code = "regionCode-1566082984"
      deleted = false
      expected_response = {
        name: name_2,
        display_name: display_name,
        region_code: region_code,
        deleted: deleted
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::Account)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::GetAccountRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_account, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("get_account")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.get_account(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_account(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_account with error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::GetAccountRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_account, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("get_account")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.get_account(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_accounts' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#list_accounts."

    it 'invokes list_accounts without error' do
      # Create expected grpc response
      next_page_token = ""
      accounts_element = {}
      accounts = [accounts_element]
      expected_response = { next_page_token: next_page_token, accounts: accounts }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::ListAccountsResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_accounts, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("list_accounts")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.list_accounts

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.accounts.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_accounts with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_accounts, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("list_accounts")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.list_accounts
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_account' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#delete_account."

    it 'invokes delete_account without error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::DeleteAccountRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:delete_account, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("delete_account")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.delete_account(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_account(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_account with error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::DeleteAccountRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:delete_account, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("delete_account")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.delete_account(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_account' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#update_account."

    it 'invokes update_account without error' do
      # Create request parameters
      account = {}
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      region_code = "regionCode-1566082984"
      deleted = false
      expected_response = {
        name: name,
        display_name: display_name,
        region_code: region_code,
        deleted: deleted
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::Account)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::UpdateAccountRequest, request)
        assert_equal(Google::Gax::to_proto(account, Google::Analytics::Admin::V1alpha::Account), request.account)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_account, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("update_account")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.update_account(account, update_mask)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_account(account, update_mask) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_account with error' do
      # Create request parameters
      account = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::UpdateAccountRequest, request)
        assert_equal(Google::Gax::to_proto(account, Google::Analytics::Admin::V1alpha::Account), request.account)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_account, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("update_account")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.update_account(account, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'provision_account_ticket' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#provision_account_ticket."

    it 'invokes provision_account_ticket without error' do
      # Create expected grpc response
      account_ticket_id = "accountTicketId-442102884"
      expected_response = { account_ticket_id: account_ticket_id }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::ProvisionAccountTicketResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:provision_account_ticket, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("provision_account_ticket")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.provision_account_ticket

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.provision_account_ticket do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes provision_account_ticket with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:provision_account_ticket, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("provision_account_ticket")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.provision_account_ticket
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_account_summaries' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#list_account_summaries."

    it 'invokes list_account_summaries without error' do
      # Create expected grpc response
      next_page_token = ""
      account_summaries_element = {}
      account_summaries = [account_summaries_element]
      expected_response = { next_page_token: next_page_token, account_summaries: account_summaries }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::ListAccountSummariesResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_account_summaries, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("list_account_summaries")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.list_account_summaries

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.account_summaries.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_account_summaries with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_account_summaries, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("list_account_summaries")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.list_account_summaries
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_property' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#get_property."

    it 'invokes get_property without error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      parent = "parent-995424086"
      display_name = "displayName1615086568"
      time_zone = "timeZone36848094"
      currency_code = "currencyCode1108728155"
      deleted = false
      expected_response = {
        name: name_2,
        parent: parent,
        display_name: display_name,
        time_zone: time_zone,
        currency_code: currency_code,
        deleted: deleted
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::Property)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::GetPropertyRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_property, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("get_property")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.get_property(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_property(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_property with error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::GetPropertyRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_property, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("get_property")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.get_property(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_properties' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#list_properties."

    it 'invokes list_properties without error' do
      # Create request parameters
      filter = ''

      # Create expected grpc response
      next_page_token = ""
      properties_element = {}
      properties = [properties_element]
      expected_response = { next_page_token: next_page_token, properties: properties }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::ListPropertiesResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::ListPropertiesRequest, request)
        assert_equal(filter, request.filter)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_properties, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("list_properties")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.list_properties(filter)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.properties.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_properties with error' do
      # Create request parameters
      filter = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::ListPropertiesRequest, request)
        assert_equal(filter, request.filter)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_properties, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("list_properties")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.list_properties(filter)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_property' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#create_property."

    it 'invokes create_property without error' do
      # Create request parameters
      property = {}

      # Create expected grpc response
      name = "name3373707"
      parent = "parent-995424086"
      display_name = "displayName1615086568"
      time_zone = "timeZone36848094"
      currency_code = "currencyCode1108728155"
      deleted = false
      expected_response = {
        name: name,
        parent: parent,
        display_name: display_name,
        time_zone: time_zone,
        currency_code: currency_code,
        deleted: deleted
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::Property)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::CreatePropertyRequest, request)
        assert_equal(Google::Gax::to_proto(property, Google::Analytics::Admin::V1alpha::Property), request.property)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:create_property, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("create_property")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.create_property(property)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_property(property) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_property with error' do
      # Create request parameters
      property = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::CreatePropertyRequest, request)
        assert_equal(Google::Gax::to_proto(property, Google::Analytics::Admin::V1alpha::Property), request.property)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:create_property, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("create_property")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.create_property(property)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_property' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#delete_property."

    it 'invokes delete_property without error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::DeletePropertyRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:delete_property, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("delete_property")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.delete_property(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_property(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_property with error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::DeletePropertyRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:delete_property, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("delete_property")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.delete_property(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_property' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#update_property."

    it 'invokes update_property without error' do
      # Create request parameters
      property = {}
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      parent = "parent-995424086"
      display_name = "displayName1615086568"
      time_zone = "timeZone36848094"
      currency_code = "currencyCode1108728155"
      deleted = false
      expected_response = {
        name: name,
        parent: parent,
        display_name: display_name,
        time_zone: time_zone,
        currency_code: currency_code,
        deleted: deleted
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::Property)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::UpdatePropertyRequest, request)
        assert_equal(Google::Gax::to_proto(property, Google::Analytics::Admin::V1alpha::Property), request.property)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_property, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("update_property")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.update_property(property, update_mask)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_property(property, update_mask) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_property with error' do
      # Create request parameters
      property = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::UpdatePropertyRequest, request)
        assert_equal(Google::Gax::to_proto(property, Google::Analytics::Admin::V1alpha::Property), request.property)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_property, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("update_property")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.update_property(property, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_user_link' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#get_user_link."

    it 'invokes get_user_link without error' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      email_address = "emailAddress-769510831"
      expected_response = { name: name_2, email_address: email_address }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::UserLink)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::GetUserLinkRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_user_link, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("get_user_link")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.get_user_link(name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_user_link(name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_user_link with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::GetUserLinkRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_user_link, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("get_user_link")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.get_user_link(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'batch_get_user_links' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#batch_get_user_links."

    it 'invokes batch_get_user_links without error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")
      names = []

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::BatchGetUserLinksResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::BatchGetUserLinksRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(names, request.names)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:batch_get_user_links, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("batch_get_user_links")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.batch_get_user_links(formatted_parent, names)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.batch_get_user_links(formatted_parent, names) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes batch_get_user_links with error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")
      names = []

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::BatchGetUserLinksRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(names, request.names)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:batch_get_user_links, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("batch_get_user_links")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.batch_get_user_links(formatted_parent, names)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_user_links' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#list_user_links."

    it 'invokes list_user_links without error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")

      # Create expected grpc response
      next_page_token = ""
      user_links_element = {}
      user_links = [user_links_element]
      expected_response = { next_page_token: next_page_token, user_links: user_links }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::ListUserLinksResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::ListUserLinksRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_user_links, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("list_user_links")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.list_user_links(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.user_links.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_user_links with error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::ListUserLinksRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_user_links, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("list_user_links")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.list_user_links(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'audit_user_links' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#audit_user_links."

    it 'invokes audit_user_links without error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")

      # Create expected grpc response
      next_page_token = ""
      user_links_element = {}
      user_links = [user_links_element]
      expected_response = { next_page_token: next_page_token, user_links: user_links }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::AuditUserLinksResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::AuditUserLinksRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:audit_user_links, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("audit_user_links")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.audit_user_links(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.user_links.to_a, response.to_a)
        end
      end
    end

    it 'invokes audit_user_links with error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::AuditUserLinksRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:audit_user_links, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("audit_user_links")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.audit_user_links(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_user_link' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#create_user_link."

    it 'invokes create_user_link without error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")
      user_link = {}

      # Create expected grpc response
      name = "name3373707"
      email_address = "emailAddress-769510831"
      expected_response = { name: name, email_address: email_address }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::UserLink)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::CreateUserLinkRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(user_link, Google::Analytics::Admin::V1alpha::UserLink), request.user_link)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:create_user_link, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("create_user_link")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.create_user_link(formatted_parent, user_link)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_user_link(formatted_parent, user_link) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_user_link with error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")
      user_link = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::CreateUserLinkRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(user_link, Google::Analytics::Admin::V1alpha::UserLink), request.user_link)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:create_user_link, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("create_user_link")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.create_user_link(formatted_parent, user_link)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'batch_create_user_links' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#batch_create_user_links."

    it 'invokes batch_create_user_links without error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")
      requests = []

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::BatchCreateUserLinksResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::BatchCreateUserLinksRequest, request)
        assert_equal(formatted_parent, request.parent)
        requests = requests.map do |req|
          Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::CreateUserLinkRequest)
        end
        assert_equal(requests, request.requests)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:batch_create_user_links, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("batch_create_user_links")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.batch_create_user_links(formatted_parent, requests)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.batch_create_user_links(formatted_parent, requests) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes batch_create_user_links with error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")
      requests = []

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::BatchCreateUserLinksRequest, request)
        assert_equal(formatted_parent, request.parent)
        requests = requests.map do |req|
          Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::CreateUserLinkRequest)
        end
        assert_equal(requests, request.requests)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:batch_create_user_links, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("batch_create_user_links")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.batch_create_user_links(formatted_parent, requests)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_user_link' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#update_user_link."

    it 'invokes update_user_link without error' do
      # Create request parameters
      user_link = {}

      # Create expected grpc response
      name = "name3373707"
      email_address = "emailAddress-769510831"
      expected_response = { name: name, email_address: email_address }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::UserLink)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::UpdateUserLinkRequest, request)
        assert_equal(Google::Gax::to_proto(user_link, Google::Analytics::Admin::V1alpha::UserLink), request.user_link)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_user_link, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("update_user_link")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.update_user_link(user_link)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_user_link(user_link) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_user_link with error' do
      # Create request parameters
      user_link = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::UpdateUserLinkRequest, request)
        assert_equal(Google::Gax::to_proto(user_link, Google::Analytics::Admin::V1alpha::UserLink), request.user_link)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_user_link, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("update_user_link")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.update_user_link(user_link)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'batch_update_user_links' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#batch_update_user_links."

    it 'invokes batch_update_user_links without error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")
      requests = []

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::BatchUpdateUserLinksResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::BatchUpdateUserLinksRequest, request)
        assert_equal(formatted_parent, request.parent)
        requests = requests.map do |req|
          Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::UpdateUserLinkRequest)
        end
        assert_equal(requests, request.requests)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:batch_update_user_links, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("batch_update_user_links")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.batch_update_user_links(formatted_parent, requests)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.batch_update_user_links(formatted_parent, requests) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes batch_update_user_links with error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")
      requests = []

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::BatchUpdateUserLinksRequest, request)
        assert_equal(formatted_parent, request.parent)
        requests = requests.map do |req|
          Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::UpdateUserLinkRequest)
        end
        assert_equal(requests, request.requests)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:batch_update_user_links, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("batch_update_user_links")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.batch_update_user_links(formatted_parent, requests)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_user_link' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#delete_user_link."

    it 'invokes delete_user_link without error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::DeleteUserLinkRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:delete_user_link, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("delete_user_link")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.delete_user_link(name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_user_link(name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_user_link with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::DeleteUserLinkRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:delete_user_link, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("delete_user_link")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.delete_user_link(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'batch_delete_user_links' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#batch_delete_user_links."

    it 'invokes batch_delete_user_links without error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")
      requests = []

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::BatchDeleteUserLinksRequest, request)
        assert_equal(formatted_parent, request.parent)
        requests = requests.map do |req|
          Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::DeleteUserLinkRequest)
        end
        assert_equal(requests, request.requests)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:batch_delete_user_links, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("batch_delete_user_links")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.batch_delete_user_links(formatted_parent, requests)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.batch_delete_user_links(formatted_parent, requests) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes batch_delete_user_links with error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")
      requests = []

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::BatchDeleteUserLinksRequest, request)
        assert_equal(formatted_parent, request.parent)
        requests = requests.map do |req|
          Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::DeleteUserLinkRequest)
        end
        assert_equal(requests, request.requests)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:batch_delete_user_links, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("batch_delete_user_links")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.batch_delete_user_links(formatted_parent, requests)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_web_data_stream' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#get_web_data_stream."

    it 'invokes get_web_data_stream without error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.web_data_stream_path("[PROPERTY]", "[WEB_DATA_STREAM]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      measurement_id = "measurementId-223204226"
      firebase_app_id = "firebaseAppId605863217"
      default_uri = "defaultUri-436616594"
      display_name = "displayName1615086568"
      expected_response = {
        name: name_2,
        measurement_id: measurement_id,
        firebase_app_id: firebase_app_id,
        default_uri: default_uri,
        display_name: display_name
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::WebDataStream)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::GetWebDataStreamRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_web_data_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("get_web_data_stream")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.get_web_data_stream(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_web_data_stream(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_web_data_stream with error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.web_data_stream_path("[PROPERTY]", "[WEB_DATA_STREAM]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::GetWebDataStreamRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_web_data_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("get_web_data_stream")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.get_web_data_stream(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_web_data_stream' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#delete_web_data_stream."

    it 'invokes delete_web_data_stream without error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.web_data_stream_path("[PROPERTY]", "[WEB_DATA_STREAM]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::DeleteWebDataStreamRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:delete_web_data_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("delete_web_data_stream")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.delete_web_data_stream(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_web_data_stream(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_web_data_stream with error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.web_data_stream_path("[PROPERTY]", "[WEB_DATA_STREAM]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::DeleteWebDataStreamRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:delete_web_data_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("delete_web_data_stream")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.delete_web_data_stream(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_web_data_stream' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#update_web_data_stream."

    it 'invokes update_web_data_stream without error' do
      # Create request parameters
      web_data_stream = {}
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      measurement_id = "measurementId-223204226"
      firebase_app_id = "firebaseAppId605863217"
      default_uri = "defaultUri-436616594"
      display_name = "displayName1615086568"
      expected_response = {
        name: name,
        measurement_id: measurement_id,
        firebase_app_id: firebase_app_id,
        default_uri: default_uri,
        display_name: display_name
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::WebDataStream)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::UpdateWebDataStreamRequest, request)
        assert_equal(Google::Gax::to_proto(web_data_stream, Google::Analytics::Admin::V1alpha::WebDataStream), request.web_data_stream)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_web_data_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("update_web_data_stream")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.update_web_data_stream(web_data_stream, update_mask)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_web_data_stream(web_data_stream, update_mask) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_web_data_stream with error' do
      # Create request parameters
      web_data_stream = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::UpdateWebDataStreamRequest, request)
        assert_equal(Google::Gax::to_proto(web_data_stream, Google::Analytics::Admin::V1alpha::WebDataStream), request.web_data_stream)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_web_data_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("update_web_data_stream")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.update_web_data_stream(web_data_stream, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_web_data_stream' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#create_web_data_stream."

    it 'invokes create_web_data_stream without error' do
      # Create request parameters
      web_data_stream = {}
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")

      # Create expected grpc response
      name = "name3373707"
      measurement_id = "measurementId-223204226"
      firebase_app_id = "firebaseAppId605863217"
      default_uri = "defaultUri-436616594"
      display_name = "displayName1615086568"
      expected_response = {
        name: name,
        measurement_id: measurement_id,
        firebase_app_id: firebase_app_id,
        default_uri: default_uri,
        display_name: display_name
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::WebDataStream)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::CreateWebDataStreamRequest, request)
        assert_equal(Google::Gax::to_proto(web_data_stream, Google::Analytics::Admin::V1alpha::WebDataStream), request.web_data_stream)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:create_web_data_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("create_web_data_stream")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.create_web_data_stream(web_data_stream, formatted_parent)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_web_data_stream(web_data_stream, formatted_parent) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_web_data_stream with error' do
      # Create request parameters
      web_data_stream = {}
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::CreateWebDataStreamRequest, request)
        assert_equal(Google::Gax::to_proto(web_data_stream, Google::Analytics::Admin::V1alpha::WebDataStream), request.web_data_stream)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:create_web_data_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("create_web_data_stream")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.create_web_data_stream(web_data_stream, formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_web_data_streams' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#list_web_data_streams."

    it 'invokes list_web_data_streams without error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")

      # Create expected grpc response
      next_page_token = ""
      web_data_streams_element = {}
      web_data_streams = [web_data_streams_element]
      expected_response = { next_page_token: next_page_token, web_data_streams: web_data_streams }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::ListWebDataStreamsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::ListWebDataStreamsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_web_data_streams, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("list_web_data_streams")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.list_web_data_streams(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.web_data_streams.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_web_data_streams with error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::ListWebDataStreamsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_web_data_streams, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("list_web_data_streams")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.list_web_data_streams(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_ios_app_data_stream' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#get_ios_app_data_stream."

    it 'invokes get_ios_app_data_stream without error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.ios_app_data_stream_path("[PROPERTY]", "[IOS_APP_DATA_STREAM]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      firebase_app_id = "firebaseAppId605863217"
      bundle_id = "bundleId-1479583240"
      display_name = "displayName1615086568"
      expected_response = {
        name: name_2,
        firebase_app_id: firebase_app_id,
        bundle_id: bundle_id,
        display_name: display_name
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::IosAppDataStream)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::GetIosAppDataStreamRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_ios_app_data_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("get_ios_app_data_stream")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.get_ios_app_data_stream(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_ios_app_data_stream(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_ios_app_data_stream with error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.ios_app_data_stream_path("[PROPERTY]", "[IOS_APP_DATA_STREAM]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::GetIosAppDataStreamRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_ios_app_data_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("get_ios_app_data_stream")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.get_ios_app_data_stream(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_ios_app_data_stream' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#delete_ios_app_data_stream."

    it 'invokes delete_ios_app_data_stream without error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.ios_app_data_stream_path("[PROPERTY]", "[IOS_APP_DATA_STREAM]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::DeleteIosAppDataStreamRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:delete_ios_app_data_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("delete_ios_app_data_stream")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.delete_ios_app_data_stream(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_ios_app_data_stream(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_ios_app_data_stream with error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.ios_app_data_stream_path("[PROPERTY]", "[IOS_APP_DATA_STREAM]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::DeleteIosAppDataStreamRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:delete_ios_app_data_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("delete_ios_app_data_stream")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.delete_ios_app_data_stream(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_ios_app_data_stream' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#update_ios_app_data_stream."

    it 'invokes update_ios_app_data_stream without error' do
      # Create request parameters
      ios_app_data_stream = {}
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      firebase_app_id = "firebaseAppId605863217"
      bundle_id = "bundleId-1479583240"
      display_name = "displayName1615086568"
      expected_response = {
        name: name,
        firebase_app_id: firebase_app_id,
        bundle_id: bundle_id,
        display_name: display_name
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::IosAppDataStream)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::UpdateIosAppDataStreamRequest, request)
        assert_equal(Google::Gax::to_proto(ios_app_data_stream, Google::Analytics::Admin::V1alpha::IosAppDataStream), request.ios_app_data_stream)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_ios_app_data_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("update_ios_app_data_stream")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.update_ios_app_data_stream(ios_app_data_stream, update_mask)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_ios_app_data_stream(ios_app_data_stream, update_mask) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_ios_app_data_stream with error' do
      # Create request parameters
      ios_app_data_stream = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::UpdateIosAppDataStreamRequest, request)
        assert_equal(Google::Gax::to_proto(ios_app_data_stream, Google::Analytics::Admin::V1alpha::IosAppDataStream), request.ios_app_data_stream)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_ios_app_data_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("update_ios_app_data_stream")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.update_ios_app_data_stream(ios_app_data_stream, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_ios_app_data_stream' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#create_ios_app_data_stream."

    it 'invokes create_ios_app_data_stream without error' do
      # Create request parameters
      ios_app_data_stream = {}
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")

      # Create expected grpc response
      name = "name3373707"
      firebase_app_id = "firebaseAppId605863217"
      bundle_id = "bundleId-1479583240"
      display_name = "displayName1615086568"
      expected_response = {
        name: name,
        firebase_app_id: firebase_app_id,
        bundle_id: bundle_id,
        display_name: display_name
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::IosAppDataStream)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::CreateIosAppDataStreamRequest, request)
        assert_equal(Google::Gax::to_proto(ios_app_data_stream, Google::Analytics::Admin::V1alpha::IosAppDataStream), request.ios_app_data_stream)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:create_ios_app_data_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("create_ios_app_data_stream")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.create_ios_app_data_stream(ios_app_data_stream, formatted_parent)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_ios_app_data_stream(ios_app_data_stream, formatted_parent) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_ios_app_data_stream with error' do
      # Create request parameters
      ios_app_data_stream = {}
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::CreateIosAppDataStreamRequest, request)
        assert_equal(Google::Gax::to_proto(ios_app_data_stream, Google::Analytics::Admin::V1alpha::IosAppDataStream), request.ios_app_data_stream)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:create_ios_app_data_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("create_ios_app_data_stream")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.create_ios_app_data_stream(ios_app_data_stream, formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_ios_app_data_streams' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#list_ios_app_data_streams."

    it 'invokes list_ios_app_data_streams without error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")

      # Create expected grpc response
      next_page_token = ""
      ios_app_data_streams_element = {}
      ios_app_data_streams = [ios_app_data_streams_element]
      expected_response = { next_page_token: next_page_token, ios_app_data_streams: ios_app_data_streams }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::ListIosAppDataStreamsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::ListIosAppDataStreamsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_ios_app_data_streams, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("list_ios_app_data_streams")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.list_ios_app_data_streams(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.ios_app_data_streams.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_ios_app_data_streams with error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::ListIosAppDataStreamsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_ios_app_data_streams, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("list_ios_app_data_streams")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.list_ios_app_data_streams(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_android_app_data_stream' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#get_android_app_data_stream."

    it 'invokes get_android_app_data_stream without error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.android_app_data_stream_path("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      firebase_app_id = "firebaseAppId605863217"
      package_name = "packageName-1877165340"
      display_name = "displayName1615086568"
      expected_response = {
        name: name_2,
        firebase_app_id: firebase_app_id,
        package_name: package_name,
        display_name: display_name
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::AndroidAppDataStream)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::GetAndroidAppDataStreamRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_android_app_data_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("get_android_app_data_stream")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.get_android_app_data_stream(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_android_app_data_stream(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_android_app_data_stream with error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.android_app_data_stream_path("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::GetAndroidAppDataStreamRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_android_app_data_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("get_android_app_data_stream")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.get_android_app_data_stream(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_android_app_data_stream' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#delete_android_app_data_stream."

    it 'invokes delete_android_app_data_stream without error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.android_app_data_stream_path("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::DeleteAndroidAppDataStreamRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:delete_android_app_data_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("delete_android_app_data_stream")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.delete_android_app_data_stream(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_android_app_data_stream(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_android_app_data_stream with error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.android_app_data_stream_path("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::DeleteAndroidAppDataStreamRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:delete_android_app_data_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("delete_android_app_data_stream")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.delete_android_app_data_stream(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_android_app_data_stream' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#update_android_app_data_stream."

    it 'invokes update_android_app_data_stream without error' do
      # Create request parameters
      android_app_data_stream = {}
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      firebase_app_id = "firebaseAppId605863217"
      package_name = "packageName-1877165340"
      display_name = "displayName1615086568"
      expected_response = {
        name: name,
        firebase_app_id: firebase_app_id,
        package_name: package_name,
        display_name: display_name
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::AndroidAppDataStream)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::UpdateAndroidAppDataStreamRequest, request)
        assert_equal(Google::Gax::to_proto(android_app_data_stream, Google::Analytics::Admin::V1alpha::AndroidAppDataStream), request.android_app_data_stream)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_android_app_data_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("update_android_app_data_stream")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.update_android_app_data_stream(android_app_data_stream, update_mask)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_android_app_data_stream(android_app_data_stream, update_mask) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_android_app_data_stream with error' do
      # Create request parameters
      android_app_data_stream = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::UpdateAndroidAppDataStreamRequest, request)
        assert_equal(Google::Gax::to_proto(android_app_data_stream, Google::Analytics::Admin::V1alpha::AndroidAppDataStream), request.android_app_data_stream)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_android_app_data_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("update_android_app_data_stream")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.update_android_app_data_stream(android_app_data_stream, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_android_app_data_stream' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#create_android_app_data_stream."

    it 'invokes create_android_app_data_stream without error' do
      # Create request parameters
      android_app_data_stream = {}
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")

      # Create expected grpc response
      name = "name3373707"
      firebase_app_id = "firebaseAppId605863217"
      package_name = "packageName-1877165340"
      display_name = "displayName1615086568"
      expected_response = {
        name: name,
        firebase_app_id: firebase_app_id,
        package_name: package_name,
        display_name: display_name
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::AndroidAppDataStream)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::CreateAndroidAppDataStreamRequest, request)
        assert_equal(Google::Gax::to_proto(android_app_data_stream, Google::Analytics::Admin::V1alpha::AndroidAppDataStream), request.android_app_data_stream)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:create_android_app_data_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("create_android_app_data_stream")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.create_android_app_data_stream(android_app_data_stream, formatted_parent)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_android_app_data_stream(android_app_data_stream, formatted_parent) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_android_app_data_stream with error' do
      # Create request parameters
      android_app_data_stream = {}
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::CreateAndroidAppDataStreamRequest, request)
        assert_equal(Google::Gax::to_proto(android_app_data_stream, Google::Analytics::Admin::V1alpha::AndroidAppDataStream), request.android_app_data_stream)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:create_android_app_data_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("create_android_app_data_stream")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.create_android_app_data_stream(android_app_data_stream, formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_android_app_data_streams' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#list_android_app_data_streams."

    it 'invokes list_android_app_data_streams without error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")

      # Create expected grpc response
      next_page_token = ""
      android_app_data_streams_element = {}
      android_app_data_streams = [android_app_data_streams_element]
      expected_response = { next_page_token: next_page_token, android_app_data_streams: android_app_data_streams }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::ListAndroidAppDataStreamsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::ListAndroidAppDataStreamsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_android_app_data_streams, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("list_android_app_data_streams")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.list_android_app_data_streams(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.android_app_data_streams.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_android_app_data_streams with error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::ListAndroidAppDataStreamsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_android_app_data_streams, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("list_android_app_data_streams")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.list_android_app_data_streams(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_enhanced_measurement_settings' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#get_enhanced_measurement_settings."

    it 'invokes get_enhanced_measurement_settings without error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.enhanced_measurement_settings_path("[PROPERTY]", "[WEB_DATA_STREAM]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      stream_enabled = true
      page_views_enabled = true
      scrolls_enabled = true
      outbound_clicks_enabled = true
      site_search_enabled = true
      video_engagement_enabled = false
      file_downloads_enabled = true
      page_loads_enabled = false
      page_changes_enabled = false
      search_query_parameter = "searchQueryParameter638048347"
      uri_query_parameter = "uriQueryParameter964636703"
      expected_response = {
        name: name_2,
        stream_enabled: stream_enabled,
        page_views_enabled: page_views_enabled,
        scrolls_enabled: scrolls_enabled,
        outbound_clicks_enabled: outbound_clicks_enabled,
        site_search_enabled: site_search_enabled,
        video_engagement_enabled: video_engagement_enabled,
        file_downloads_enabled: file_downloads_enabled,
        page_loads_enabled: page_loads_enabled,
        page_changes_enabled: page_changes_enabled,
        search_query_parameter: search_query_parameter,
        uri_query_parameter: uri_query_parameter
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::EnhancedMeasurementSettings)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::GetEnhancedMeasurementSettingsRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_enhanced_measurement_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("get_enhanced_measurement_settings")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.get_enhanced_measurement_settings(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_enhanced_measurement_settings(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_enhanced_measurement_settings with error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.enhanced_measurement_settings_path("[PROPERTY]", "[WEB_DATA_STREAM]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::GetEnhancedMeasurementSettingsRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_enhanced_measurement_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("get_enhanced_measurement_settings")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.get_enhanced_measurement_settings(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_enhanced_measurement_settings' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#update_enhanced_measurement_settings."

    it 'invokes update_enhanced_measurement_settings without error' do
      # Create request parameters
      enhanced_measurement_settings = {}
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      stream_enabled = true
      page_views_enabled = true
      scrolls_enabled = true
      outbound_clicks_enabled = true
      site_search_enabled = true
      video_engagement_enabled = false
      file_downloads_enabled = true
      page_loads_enabled = false
      page_changes_enabled = false
      search_query_parameter = "searchQueryParameter638048347"
      uri_query_parameter = "uriQueryParameter964636703"
      expected_response = {
        name: name,
        stream_enabled: stream_enabled,
        page_views_enabled: page_views_enabled,
        scrolls_enabled: scrolls_enabled,
        outbound_clicks_enabled: outbound_clicks_enabled,
        site_search_enabled: site_search_enabled,
        video_engagement_enabled: video_engagement_enabled,
        file_downloads_enabled: file_downloads_enabled,
        page_loads_enabled: page_loads_enabled,
        page_changes_enabled: page_changes_enabled,
        search_query_parameter: search_query_parameter,
        uri_query_parameter: uri_query_parameter
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::EnhancedMeasurementSettings)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::UpdateEnhancedMeasurementSettingsRequest, request)
        assert_equal(Google::Gax::to_proto(enhanced_measurement_settings, Google::Analytics::Admin::V1alpha::EnhancedMeasurementSettings), request.enhanced_measurement_settings)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_enhanced_measurement_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("update_enhanced_measurement_settings")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.update_enhanced_measurement_settings(enhanced_measurement_settings, update_mask)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_enhanced_measurement_settings(enhanced_measurement_settings, update_mask) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_enhanced_measurement_settings with error' do
      # Create request parameters
      enhanced_measurement_settings = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::UpdateEnhancedMeasurementSettingsRequest, request)
        assert_equal(Google::Gax::to_proto(enhanced_measurement_settings, Google::Analytics::Admin::V1alpha::EnhancedMeasurementSettings), request.enhanced_measurement_settings)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_enhanced_measurement_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("update_enhanced_measurement_settings")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.update_enhanced_measurement_settings(enhanced_measurement_settings, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_firebase_link' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#create_firebase_link."

    it 'invokes create_firebase_link without error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")
      firebase_link = {}

      # Create expected grpc response
      name = "name3373707"
      project = "project-309310695"
      expected_response = { name: name, project: project }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::FirebaseLink)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::CreateFirebaseLinkRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(firebase_link, Google::Analytics::Admin::V1alpha::FirebaseLink), request.firebase_link)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:create_firebase_link, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("create_firebase_link")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.create_firebase_link(formatted_parent, firebase_link)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_firebase_link(formatted_parent, firebase_link) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_firebase_link with error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")
      firebase_link = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::CreateFirebaseLinkRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(firebase_link, Google::Analytics::Admin::V1alpha::FirebaseLink), request.firebase_link)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:create_firebase_link, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("create_firebase_link")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.create_firebase_link(formatted_parent, firebase_link)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_firebase_link' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#update_firebase_link."

    it 'invokes update_firebase_link without error' do
      # Create request parameters
      firebase_link = {}
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      project = "project-309310695"
      expected_response = { name: name, project: project }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::FirebaseLink)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::UpdateFirebaseLinkRequest, request)
        assert_equal(Google::Gax::to_proto(firebase_link, Google::Analytics::Admin::V1alpha::FirebaseLink), request.firebase_link)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_firebase_link, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("update_firebase_link")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.update_firebase_link(firebase_link, update_mask)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_firebase_link(firebase_link, update_mask) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_firebase_link with error' do
      # Create request parameters
      firebase_link = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::UpdateFirebaseLinkRequest, request)
        assert_equal(Google::Gax::to_proto(firebase_link, Google::Analytics::Admin::V1alpha::FirebaseLink), request.firebase_link)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_firebase_link, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("update_firebase_link")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.update_firebase_link(firebase_link, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_firebase_link' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#delete_firebase_link."

    it 'invokes delete_firebase_link without error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.firebase_link_path("[PROPERTY]", "[FIREBASE_LINK]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::DeleteFirebaseLinkRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:delete_firebase_link, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("delete_firebase_link")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.delete_firebase_link(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_firebase_link(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_firebase_link with error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.firebase_link_path("[PROPERTY]", "[FIREBASE_LINK]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::DeleteFirebaseLinkRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:delete_firebase_link, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("delete_firebase_link")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.delete_firebase_link(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_firebase_links' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#list_firebase_links."

    it 'invokes list_firebase_links without error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")

      # Create expected grpc response
      next_page_token = ""
      firebase_links_element = {}
      firebase_links = [firebase_links_element]
      expected_response = { next_page_token: next_page_token, firebase_links: firebase_links }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::ListFirebaseLinksResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::ListFirebaseLinksRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_firebase_links, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("list_firebase_links")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.list_firebase_links(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.firebase_links.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_firebase_links with error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::ListFirebaseLinksRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_firebase_links, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("list_firebase_links")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.list_firebase_links(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_global_site_tag' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#get_global_site_tag."

    it 'invokes get_global_site_tag without error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.global_site_tag_path("[PROPERTY]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      snippet = "snippet-2061635299"
      expected_response = { name: name_2, snippet: snippet }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::GlobalSiteTag)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::GetGlobalSiteTagRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_global_site_tag, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("get_global_site_tag")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.get_global_site_tag(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_global_site_tag(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_global_site_tag with error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.global_site_tag_path("[PROPERTY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::GetGlobalSiteTagRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_global_site_tag, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("get_global_site_tag")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.get_global_site_tag(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_google_ads_link' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#create_google_ads_link."

    it 'invokes create_google_ads_link without error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")
      google_ads_link = {}

      # Create expected grpc response
      name = "name3373707"
      customer_id = "customerId-1772061412"
      can_manage_clients = false
      email_address = "emailAddress-769510831"
      expected_response = {
        name: name,
        customer_id: customer_id,
        can_manage_clients: can_manage_clients,
        email_address: email_address
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::GoogleAdsLink)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::CreateGoogleAdsLinkRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(google_ads_link, Google::Analytics::Admin::V1alpha::GoogleAdsLink), request.google_ads_link)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:create_google_ads_link, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("create_google_ads_link")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.create_google_ads_link(formatted_parent, google_ads_link)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_google_ads_link(formatted_parent, google_ads_link) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_google_ads_link with error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")
      google_ads_link = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::CreateGoogleAdsLinkRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(google_ads_link, Google::Analytics::Admin::V1alpha::GoogleAdsLink), request.google_ads_link)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:create_google_ads_link, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("create_google_ads_link")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.create_google_ads_link(formatted_parent, google_ads_link)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_google_ads_link' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#update_google_ads_link."

    it 'invokes update_google_ads_link without error' do
      # Create request parameters
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      customer_id = "customerId-1772061412"
      can_manage_clients = false
      email_address = "emailAddress-769510831"
      expected_response = {
        name: name,
        customer_id: customer_id,
        can_manage_clients: can_manage_clients,
        email_address: email_address
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::GoogleAdsLink)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::UpdateGoogleAdsLinkRequest, request)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_google_ads_link, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("update_google_ads_link")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.update_google_ads_link(update_mask)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_google_ads_link(update_mask) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_google_ads_link with error' do
      # Create request parameters
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::UpdateGoogleAdsLinkRequest, request)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_google_ads_link, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("update_google_ads_link")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.update_google_ads_link(update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_google_ads_link' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#delete_google_ads_link."

    it 'invokes delete_google_ads_link without error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.google_ads_link_path("[PROPERTY]", "[GOOGLE_ADS_LINK]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::DeleteGoogleAdsLinkRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:delete_google_ads_link, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("delete_google_ads_link")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.delete_google_ads_link(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_google_ads_link(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_google_ads_link with error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.google_ads_link_path("[PROPERTY]", "[GOOGLE_ADS_LINK]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::DeleteGoogleAdsLinkRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:delete_google_ads_link, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("delete_google_ads_link")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.delete_google_ads_link(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_google_ads_links' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#list_google_ads_links."

    it 'invokes list_google_ads_links without error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")

      # Create expected grpc response
      next_page_token = ""
      google_ads_links_element = {}
      google_ads_links = [google_ads_links_element]
      expected_response = { next_page_token: next_page_token, google_ads_links: google_ads_links }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::ListGoogleAdsLinksResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::ListGoogleAdsLinksRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_google_ads_links, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("list_google_ads_links")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.list_google_ads_links(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.google_ads_links.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_google_ads_links with error' do
      # Create request parameters
      formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::ListGoogleAdsLinksRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_google_ads_links, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("list_google_ads_links")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.list_google_ads_links(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_data_sharing_settings' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient#get_data_sharing_settings."

    it 'invokes get_data_sharing_settings without error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.data_sharing_settings_path("[ACCOUNT]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      sharing_with_google_support_enabled = false
      sharing_with_google_assigned_sales_enabled = false
      sharing_with_google_any_sales_enabled = false
      sharing_with_google_products_enabled = true
      sharing_with_others_enabled = false
      expected_response = {
        name: name_2,
        sharing_with_google_support_enabled: sharing_with_google_support_enabled,
        sharing_with_google_assigned_sales_enabled: sharing_with_google_assigned_sales_enabled,
        sharing_with_google_any_sales_enabled: sharing_with_google_any_sales_enabled,
        sharing_with_google_products_enabled: sharing_with_google_products_enabled,
        sharing_with_others_enabled: sharing_with_others_enabled
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Analytics::Admin::V1alpha::DataSharingSettings)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::GetDataSharingSettingsRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_data_sharing_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("get_data_sharing_settings")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          response = client.get_data_sharing_settings(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_data_sharing_settings(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_data_sharing_settings with error' do
      # Create request parameters
      formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.data_sharing_settings_path("[ACCOUNT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Analytics::Admin::V1alpha::GetDataSharingSettingsRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_data_sharing_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockAnalyticsAdminServiceCredentials_v1alpha.new("get_data_sharing_settings")

      Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.stub(:new, mock_stub) do
        Google::Analytics::Admin::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Analytics::Admin::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.get_data_sharing_settings(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end