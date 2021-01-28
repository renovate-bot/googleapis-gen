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

require "google/cloud/datacatalog"
require "google/cloud/datacatalog/v1beta1/data_catalog_client"
require "google/cloud/datacatalog/v1beta1/datacatalog_services_pb"

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

class MockDataCatalogCredentials_v1beta1 < Google::Cloud::Datacatalog::V1beta1::Credentials
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

describe Google::Cloud::Datacatalog::V1beta1::DataCatalogClient do

  describe 'search_catalog' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#search_catalog."

    it 'invokes search_catalog without error' do
      # Create request parameters
      scope = {}
      query = ''

      # Create expected grpc response
      next_page_token = ""
      results_element = {}
      results = [results_element]
      expected_response = { next_page_token: next_page_token, results: results }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::SearchCatalogResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::SearchCatalogRequest, request)
        assert_equal(Google::Gax::to_proto(scope, Google::Cloud::Datacatalog::V1beta1::SearchCatalogRequest::Scope), request.scope)
        assert_equal(query, request.query)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:search_catalog, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("search_catalog")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          response = client.search_catalog(scope, query)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.results.to_a, response.to_a)
        end
      end
    end

    it 'invokes search_catalog with error' do
      # Create request parameters
      scope = {}
      query = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::SearchCatalogRequest, request)
        assert_equal(Google::Gax::to_proto(scope, Google::Cloud::Datacatalog::V1beta1::SearchCatalogRequest::Scope), request.scope)
        assert_equal(query, request.query)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:search_catalog, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("search_catalog")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.search_catalog(scope, query)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_entry' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#get_entry."

    it 'invokes get_entry without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      linked_resource = "linkedResource1544625012"
      user_specified_type = "userSpecifiedType-940364963"
      user_specified_system = "userSpecifiedSystem-1776119406"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      expected_response = {
        name: name_2,
        linked_resource: linked_resource,
        user_specified_type: user_specified_type,
        user_specified_system: user_specified_system,
        display_name: display_name,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::Entry)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::GetEntryRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_entry, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("get_entry")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          response = client.get_entry(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_entry(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_entry with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::GetEntryRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_entry, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("get_entry")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.get_entry(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'lookup_entry' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#lookup_entry."

    it 'invokes lookup_entry without error' do
      # Create expected grpc response
      name = "name3373707"
      linked_resource = "linkedResource1544625012"
      user_specified_type = "userSpecifiedType-940364963"
      user_specified_system = "userSpecifiedSystem-1776119406"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      expected_response = {
        name: name,
        linked_resource: linked_resource,
        user_specified_type: user_specified_type,
        user_specified_system: user_specified_system,
        display_name: display_name,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::Entry)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:lookup_entry, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("lookup_entry")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          response = client.lookup_entry

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.lookup_entry do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes lookup_entry with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:lookup_entry, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("lookup_entry")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.lookup_entry
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_entry_group' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#create_entry_group."

    it 'invokes create_entry_group without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.location_path("[PROJECT]", "[LOCATION]")
      entry_group_id = ''

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      expected_response = {
        name: name,
        display_name: display_name,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::EntryGroup)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::CreateEntryGroupRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(entry_group_id, request.entry_group_id)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_entry_group, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("create_entry_group")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          response = client.create_entry_group(formatted_parent, entry_group_id)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_entry_group(formatted_parent, entry_group_id) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_entry_group with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.location_path("[PROJECT]", "[LOCATION]")
      entry_group_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::CreateEntryGroupRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(entry_group_id, request.entry_group_id)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_entry_group, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("create_entry_group")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.create_entry_group(formatted_parent, entry_group_id)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_entry_group' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#update_entry_group."

    it 'invokes update_entry_group without error' do
      # Create request parameters
      entry_group = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      expected_response = {
        name: name,
        display_name: display_name,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::EntryGroup)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::UpdateEntryGroupRequest, request)
        assert_equal(Google::Gax::to_proto(entry_group, Google::Cloud::Datacatalog::V1beta1::EntryGroup), request.entry_group)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_entry_group, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("update_entry_group")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          response = client.update_entry_group(entry_group)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_entry_group(entry_group) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_entry_group with error' do
      # Create request parameters
      entry_group = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::UpdateEntryGroupRequest, request)
        assert_equal(Google::Gax::to_proto(entry_group, Google::Cloud::Datacatalog::V1beta1::EntryGroup), request.entry_group)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_entry_group, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("update_entry_group")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.update_entry_group(entry_group)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_entry_group' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#get_entry_group."

    it 'invokes get_entry_group without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_group_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      expected_response = {
        name: name_2,
        display_name: display_name,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::EntryGroup)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::GetEntryGroupRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_entry_group, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("get_entry_group")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          response = client.get_entry_group(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_entry_group(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_entry_group with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_group_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::GetEntryGroupRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_entry_group, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("get_entry_group")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.get_entry_group(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_entry_group' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#delete_entry_group."

    it 'invokes delete_entry_group without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_group_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::DeleteEntryGroupRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_entry_group, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("delete_entry_group")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          response = client.delete_entry_group(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_entry_group(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_entry_group with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_group_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::DeleteEntryGroupRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_entry_group, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("delete_entry_group")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.delete_entry_group(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_entry_groups' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#list_entry_groups."

    it 'invokes list_entry_groups without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_group_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]")

      # Create expected grpc response
      next_page_token = ""
      entry_groups_element = {}
      entry_groups = [entry_groups_element]
      expected_response = { next_page_token: next_page_token, entry_groups: entry_groups }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::ListEntryGroupsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::ListEntryGroupsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_entry_groups, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("list_entry_groups")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          response = client.list_entry_groups(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.entry_groups.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_entry_groups with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_group_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::ListEntryGroupsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_entry_groups, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("list_entry_groups")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.list_entry_groups(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_entry' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#create_entry."

    it 'invokes create_entry without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_group_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]")
      entry_id = ''
      entry = {}

      # Create expected grpc response
      name = "name3373707"
      linked_resource = "linkedResource1544625012"
      user_specified_type = "userSpecifiedType-940364963"
      user_specified_system = "userSpecifiedSystem-1776119406"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      expected_response = {
        name: name,
        linked_resource: linked_resource,
        user_specified_type: user_specified_type,
        user_specified_system: user_specified_system,
        display_name: display_name,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::Entry)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::CreateEntryRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(entry_id, request.entry_id)
        assert_equal(Google::Gax::to_proto(entry, Google::Cloud::Datacatalog::V1beta1::Entry), request.entry)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_entry, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("create_entry")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          response = client.create_entry(
            formatted_parent,
            entry_id,
            entry
          )

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_entry(
            formatted_parent,
            entry_id,
            entry
          ) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_entry with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_group_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]")
      entry_id = ''
      entry = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::CreateEntryRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(entry_id, request.entry_id)
        assert_equal(Google::Gax::to_proto(entry, Google::Cloud::Datacatalog::V1beta1::Entry), request.entry)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_entry, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("create_entry")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.create_entry(
              formatted_parent,
              entry_id,
              entry
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_entry' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#update_entry."

    it 'invokes update_entry without error' do
      # Create request parameters
      entry = {}

      # Create expected grpc response
      name = "name3373707"
      linked_resource = "linkedResource1544625012"
      user_specified_type = "userSpecifiedType-940364963"
      user_specified_system = "userSpecifiedSystem-1776119406"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      expected_response = {
        name: name,
        linked_resource: linked_resource,
        user_specified_type: user_specified_type,
        user_specified_system: user_specified_system,
        display_name: display_name,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::Entry)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::UpdateEntryRequest, request)
        assert_equal(Google::Gax::to_proto(entry, Google::Cloud::Datacatalog::V1beta1::Entry), request.entry)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_entry, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("update_entry")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          response = client.update_entry(entry)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_entry(entry) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_entry with error' do
      # Create request parameters
      entry = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::UpdateEntryRequest, request)
        assert_equal(Google::Gax::to_proto(entry, Google::Cloud::Datacatalog::V1beta1::Entry), request.entry)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_entry, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("update_entry")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.update_entry(entry)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_entry' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#delete_entry."

    it 'invokes delete_entry without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::DeleteEntryRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_entry, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("delete_entry")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          response = client.delete_entry(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_entry(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_entry with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::DeleteEntryRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_entry, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("delete_entry")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.delete_entry(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_entries' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#list_entries."

    it 'invokes list_entries without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_group_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]")

      # Create expected grpc response
      next_page_token = ""
      entries_element = {}
      entries = [entries_element]
      expected_response = { next_page_token: next_page_token, entries: entries }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::ListEntriesResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::ListEntriesRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_entries, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("list_entries")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          response = client.list_entries(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.entries.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_entries with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_group_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::ListEntriesRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_entries, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("list_entries")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.list_entries(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_tag_template' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#create_tag_template."

    it 'invokes create_tag_template without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.location_path("[PROJECT]", "[LOCATION]")
      tag_template_id = ''
      tag_template = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      expected_response = { name: name, display_name: display_name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::TagTemplate)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::CreateTagTemplateRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(tag_template_id, request.tag_template_id)
        assert_equal(Google::Gax::to_proto(tag_template, Google::Cloud::Datacatalog::V1beta1::TagTemplate), request.tag_template)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_tag_template, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("create_tag_template")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          response = client.create_tag_template(
            formatted_parent,
            tag_template_id,
            tag_template
          )

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_tag_template(
            formatted_parent,
            tag_template_id,
            tag_template
          ) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_tag_template with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.location_path("[PROJECT]", "[LOCATION]")
      tag_template_id = ''
      tag_template = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::CreateTagTemplateRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(tag_template_id, request.tag_template_id)
        assert_equal(Google::Gax::to_proto(tag_template, Google::Cloud::Datacatalog::V1beta1::TagTemplate), request.tag_template)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_tag_template, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("create_tag_template")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.create_tag_template(
              formatted_parent,
              tag_template_id,
              tag_template
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_tag_template' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#get_tag_template."

    it 'invokes get_tag_template without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.tag_template_path("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      expected_response = { name: name_2, display_name: display_name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::TagTemplate)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::GetTagTemplateRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_tag_template, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("get_tag_template")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          response = client.get_tag_template(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_tag_template(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_tag_template with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.tag_template_path("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::GetTagTemplateRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_tag_template, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("get_tag_template")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.get_tag_template(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_tag_template' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#update_tag_template."

    it 'invokes update_tag_template without error' do
      # Create request parameters
      tag_template = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      expected_response = { name: name, display_name: display_name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::TagTemplate)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::UpdateTagTemplateRequest, request)
        assert_equal(Google::Gax::to_proto(tag_template, Google::Cloud::Datacatalog::V1beta1::TagTemplate), request.tag_template)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_tag_template, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("update_tag_template")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          response = client.update_tag_template(tag_template)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_tag_template(tag_template) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_tag_template with error' do
      # Create request parameters
      tag_template = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::UpdateTagTemplateRequest, request)
        assert_equal(Google::Gax::to_proto(tag_template, Google::Cloud::Datacatalog::V1beta1::TagTemplate), request.tag_template)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_tag_template, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("update_tag_template")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.update_tag_template(tag_template)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_tag_template' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#delete_tag_template."

    it 'invokes delete_tag_template without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.tag_template_path("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]")
      force = false

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::DeleteTagTemplateRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(force, request.force)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_tag_template, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("delete_tag_template")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          response = client.delete_tag_template(formatted_name, force)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_tag_template(formatted_name, force) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_tag_template with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.tag_template_path("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]")
      force = false

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::DeleteTagTemplateRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(force, request.force)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_tag_template, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("delete_tag_template")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.delete_tag_template(formatted_name, force)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_tag_template_field' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#create_tag_template_field."

    it 'invokes create_tag_template_field without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.tag_template_path("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]")
      tag_template_field_id = ''
      tag_template_field = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      is_required = true
      order = 106006350
      expected_response = {
        name: name,
        display_name: display_name,
        is_required: is_required,
        order: order
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::TagTemplateField)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::CreateTagTemplateFieldRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(tag_template_field_id, request.tag_template_field_id)
        assert_equal(Google::Gax::to_proto(tag_template_field, Google::Cloud::Datacatalog::V1beta1::TagTemplateField), request.tag_template_field)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_tag_template_field, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("create_tag_template_field")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          response = client.create_tag_template_field(
            formatted_parent,
            tag_template_field_id,
            tag_template_field
          )

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_tag_template_field(
            formatted_parent,
            tag_template_field_id,
            tag_template_field
          ) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_tag_template_field with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.tag_template_path("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]")
      tag_template_field_id = ''
      tag_template_field = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::CreateTagTemplateFieldRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(tag_template_field_id, request.tag_template_field_id)
        assert_equal(Google::Gax::to_proto(tag_template_field, Google::Cloud::Datacatalog::V1beta1::TagTemplateField), request.tag_template_field)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_tag_template_field, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("create_tag_template_field")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.create_tag_template_field(
              formatted_parent,
              tag_template_field_id,
              tag_template_field
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_tag_template_field' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#update_tag_template_field."

    it 'invokes update_tag_template_field without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.tag_template_field_path("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]")
      tag_template_field = {}

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      is_required = true
      order = 106006350
      expected_response = {
        name: name_2,
        display_name: display_name,
        is_required: is_required,
        order: order
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::TagTemplateField)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::UpdateTagTemplateFieldRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(Google::Gax::to_proto(tag_template_field, Google::Cloud::Datacatalog::V1beta1::TagTemplateField), request.tag_template_field)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_tag_template_field, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("update_tag_template_field")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          response = client.update_tag_template_field(formatted_name, tag_template_field)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_tag_template_field(formatted_name, tag_template_field) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_tag_template_field with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.tag_template_field_path("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]")
      tag_template_field = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::UpdateTagTemplateFieldRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(Google::Gax::to_proto(tag_template_field, Google::Cloud::Datacatalog::V1beta1::TagTemplateField), request.tag_template_field)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_tag_template_field, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("update_tag_template_field")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.update_tag_template_field(formatted_name, tag_template_field)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'rename_tag_template_field' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#rename_tag_template_field."

    it 'invokes rename_tag_template_field without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.tag_template_field_path("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]")
      new_tag_template_field_id = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      is_required = true
      order = 106006350
      expected_response = {
        name: name_2,
        display_name: display_name,
        is_required: is_required,
        order: order
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::TagTemplateField)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::RenameTagTemplateFieldRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(new_tag_template_field_id, request.new_tag_template_field_id)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:rename_tag_template_field, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("rename_tag_template_field")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          response = client.rename_tag_template_field(formatted_name, new_tag_template_field_id)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.rename_tag_template_field(formatted_name, new_tag_template_field_id) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes rename_tag_template_field with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.tag_template_field_path("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]")
      new_tag_template_field_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::RenameTagTemplateFieldRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(new_tag_template_field_id, request.new_tag_template_field_id)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:rename_tag_template_field, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("rename_tag_template_field")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.rename_tag_template_field(formatted_name, new_tag_template_field_id)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_tag_template_field' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#delete_tag_template_field."

    it 'invokes delete_tag_template_field without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.tag_template_field_path("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]")
      force = false

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::DeleteTagTemplateFieldRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(force, request.force)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_tag_template_field, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("delete_tag_template_field")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          response = client.delete_tag_template_field(formatted_name, force)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_tag_template_field(formatted_name, force) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_tag_template_field with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.tag_template_field_path("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]")
      force = false

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::DeleteTagTemplateFieldRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(force, request.force)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_tag_template_field, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("delete_tag_template_field")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.delete_tag_template_field(formatted_name, force)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_tag' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#create_tag."

    it 'invokes create_tag without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.tag_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]", "[TAG]")
      tag = {}

      # Create expected grpc response
      name = "name3373707"
      template = "template-1321546630"
      template_display_name = "templateDisplayName-532252787"
      column = "column-1354837162"
      expected_response = {
        name: name,
        template: template,
        template_display_name: template_display_name,
        column: column
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::Tag)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::CreateTagRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(tag, Google::Cloud::Datacatalog::V1beta1::Tag), request.tag)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_tag, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("create_tag")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          response = client.create_tag(formatted_parent, tag)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_tag(formatted_parent, tag) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_tag with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.tag_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]", "[TAG]")
      tag = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::CreateTagRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(tag, Google::Cloud::Datacatalog::V1beta1::Tag), request.tag)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_tag, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("create_tag")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.create_tag(formatted_parent, tag)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_tag' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#update_tag."

    it 'invokes update_tag without error' do
      # Create request parameters
      tag = {}

      # Create expected grpc response
      name = "name3373707"
      template = "template-1321546630"
      template_display_name = "templateDisplayName-532252787"
      column = "column-1354837162"
      expected_response = {
        name: name,
        template: template,
        template_display_name: template_display_name,
        column: column
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::Tag)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::UpdateTagRequest, request)
        assert_equal(Google::Gax::to_proto(tag, Google::Cloud::Datacatalog::V1beta1::Tag), request.tag)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_tag, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("update_tag")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          response = client.update_tag(tag)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_tag(tag) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_tag with error' do
      # Create request parameters
      tag = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::UpdateTagRequest, request)
        assert_equal(Google::Gax::to_proto(tag, Google::Cloud::Datacatalog::V1beta1::Tag), request.tag)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_tag, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("update_tag")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.update_tag(tag)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_tag' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#delete_tag."

    it 'invokes delete_tag without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::DeleteTagRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_tag, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("delete_tag")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          response = client.delete_tag(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_tag(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_tag with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::DeleteTagRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_tag, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("delete_tag")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.delete_tag(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_tags' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#list_tags."

    it 'invokes list_tags without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]")

      # Create expected grpc response
      next_page_token = ""
      tags_element = {}
      tags = [tags_element]
      expected_response = { next_page_token: next_page_token, tags: tags }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::ListTagsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::ListTagsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_tags, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("list_tags")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          response = client.list_tags(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.tags.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_tags with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::ListTagsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_tags, mock_method)

      # Mock auth layer
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("list_tags")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.list_tags(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'set_iam_policy' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#set_iam_policy."

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
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("set_iam_policy")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

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
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("set_iam_policy")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

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

  describe 'get_iam_policy' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#get_iam_policy."

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
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("get_iam_policy")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

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
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("get_iam_policy")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

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

  describe 'test_iam_permissions' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::DataCatalogClient#test_iam_permissions."

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
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("test_iam_permissions")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

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
      mock_credentials = MockDataCatalogCredentials_v1beta1.new("test_iam_permissions")

      Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)

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