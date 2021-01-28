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
require "google/cloud/datacatalog/v1beta1/policy_tag_manager_client"
require "google/cloud/datacatalog/v1beta1/policytagmanager_services_pb"

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

class MockPolicyTagManagerCredentials_v1beta1 < Google::Cloud::Datacatalog::V1beta1::Credentials
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

describe Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient do

  describe 'create_taxonomy' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient#create_taxonomy."

    it 'invokes create_taxonomy without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      expected_response = {
        name: name,
        display_name: display_name,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::Taxonomy)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::CreateTaxonomyRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_taxonomy, mock_method)

      # Mock auth layer
      mock_credentials = MockPolicyTagManagerCredentials_v1beta1.new("create_taxonomy")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)

          # Call method
          response = client.create_taxonomy(formatted_parent)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_taxonomy(formatted_parent) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_taxonomy with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::CreateTaxonomyRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_taxonomy, mock_method)

      # Mock auth layer
      mock_credentials = MockPolicyTagManagerCredentials_v1beta1.new("create_taxonomy")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.create_taxonomy(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_taxonomy' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient#delete_taxonomy."

    it 'invokes delete_taxonomy without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient.taxonomy_path("[PROJECT]", "[LOCATION]", "[TAXONOMY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::DeleteTaxonomyRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_taxonomy, mock_method)

      # Mock auth layer
      mock_credentials = MockPolicyTagManagerCredentials_v1beta1.new("delete_taxonomy")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)

          # Call method
          response = client.delete_taxonomy(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_taxonomy(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_taxonomy with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient.taxonomy_path("[PROJECT]", "[LOCATION]", "[TAXONOMY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::DeleteTaxonomyRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_taxonomy, mock_method)

      # Mock auth layer
      mock_credentials = MockPolicyTagManagerCredentials_v1beta1.new("delete_taxonomy")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.delete_taxonomy(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_taxonomy' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient#update_taxonomy."

    it 'invokes update_taxonomy without error' do
      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      expected_response = {
        name: name,
        display_name: display_name,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::Taxonomy)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_taxonomy, mock_method)

      # Mock auth layer
      mock_credentials = MockPolicyTagManagerCredentials_v1beta1.new("update_taxonomy")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)

          # Call method
          response = client.update_taxonomy

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_taxonomy do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_taxonomy with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_taxonomy, mock_method)

      # Mock auth layer
      mock_credentials = MockPolicyTagManagerCredentials_v1beta1.new("update_taxonomy")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.update_taxonomy
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_taxonomies' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient#list_taxonomies."

    it 'invokes list_taxonomies without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      taxonomies_element = {}
      taxonomies = [taxonomies_element]
      expected_response = { next_page_token: next_page_token, taxonomies: taxonomies }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::ListTaxonomiesResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::ListTaxonomiesRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_taxonomies, mock_method)

      # Mock auth layer
      mock_credentials = MockPolicyTagManagerCredentials_v1beta1.new("list_taxonomies")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)

          # Call method
          response = client.list_taxonomies(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.taxonomies.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_taxonomies with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::ListTaxonomiesRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_taxonomies, mock_method)

      # Mock auth layer
      mock_credentials = MockPolicyTagManagerCredentials_v1beta1.new("list_taxonomies")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.list_taxonomies(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_taxonomy' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient#get_taxonomy."

    it 'invokes get_taxonomy without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient.taxonomy_path("[PROJECT]", "[LOCATION]", "[TAXONOMY]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      expected_response = {
        name: name_2,
        display_name: display_name,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::Taxonomy)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::GetTaxonomyRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_taxonomy, mock_method)

      # Mock auth layer
      mock_credentials = MockPolicyTagManagerCredentials_v1beta1.new("get_taxonomy")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)

          # Call method
          response = client.get_taxonomy(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_taxonomy(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_taxonomy with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient.taxonomy_path("[PROJECT]", "[LOCATION]", "[TAXONOMY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::GetTaxonomyRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_taxonomy, mock_method)

      # Mock auth layer
      mock_credentials = MockPolicyTagManagerCredentials_v1beta1.new("get_taxonomy")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.get_taxonomy(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_policy_tag' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient#create_policy_tag."

    it 'invokes create_policy_tag without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient.taxonomy_path("[PROJECT]", "[LOCATION]", "[TAXONOMY]")

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      parent_policy_tag = "parentPolicyTag2071382466"
      expected_response = {
        name: name,
        display_name: display_name,
        description: description,
        parent_policy_tag: parent_policy_tag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::PolicyTag)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::CreatePolicyTagRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_policy_tag, mock_method)

      # Mock auth layer
      mock_credentials = MockPolicyTagManagerCredentials_v1beta1.new("create_policy_tag")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)

          # Call method
          response = client.create_policy_tag(formatted_parent)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_policy_tag(formatted_parent) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_policy_tag with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient.taxonomy_path("[PROJECT]", "[LOCATION]", "[TAXONOMY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::CreatePolicyTagRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_policy_tag, mock_method)

      # Mock auth layer
      mock_credentials = MockPolicyTagManagerCredentials_v1beta1.new("create_policy_tag")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.create_policy_tag(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_policy_tag' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient#delete_policy_tag."

    it 'invokes delete_policy_tag without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient.policy_tag_path("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::DeletePolicyTagRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_policy_tag, mock_method)

      # Mock auth layer
      mock_credentials = MockPolicyTagManagerCredentials_v1beta1.new("delete_policy_tag")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)

          # Call method
          response = client.delete_policy_tag(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_policy_tag(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_policy_tag with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient.policy_tag_path("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::DeletePolicyTagRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_policy_tag, mock_method)

      # Mock auth layer
      mock_credentials = MockPolicyTagManagerCredentials_v1beta1.new("delete_policy_tag")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.delete_policy_tag(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_policy_tag' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient#update_policy_tag."

    it 'invokes update_policy_tag without error' do
      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      parent_policy_tag = "parentPolicyTag2071382466"
      expected_response = {
        name: name,
        display_name: display_name,
        description: description,
        parent_policy_tag: parent_policy_tag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::PolicyTag)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_policy_tag, mock_method)

      # Mock auth layer
      mock_credentials = MockPolicyTagManagerCredentials_v1beta1.new("update_policy_tag")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)

          # Call method
          response = client.update_policy_tag

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_policy_tag do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_policy_tag with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_policy_tag, mock_method)

      # Mock auth layer
      mock_credentials = MockPolicyTagManagerCredentials_v1beta1.new("update_policy_tag")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.update_policy_tag
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_policy_tags' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient#list_policy_tags."

    it 'invokes list_policy_tags without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient.taxonomy_path("[PROJECT]", "[LOCATION]", "[TAXONOMY]")

      # Create expected grpc response
      next_page_token = ""
      policy_tags_element = {}
      policy_tags = [policy_tags_element]
      expected_response = { next_page_token: next_page_token, policy_tags: policy_tags }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::ListPolicyTagsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::ListPolicyTagsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_policy_tags, mock_method)

      # Mock auth layer
      mock_credentials = MockPolicyTagManagerCredentials_v1beta1.new("list_policy_tags")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)

          # Call method
          response = client.list_policy_tags(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.policy_tags.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_policy_tags with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient.taxonomy_path("[PROJECT]", "[LOCATION]", "[TAXONOMY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::ListPolicyTagsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_policy_tags, mock_method)

      # Mock auth layer
      mock_credentials = MockPolicyTagManagerCredentials_v1beta1.new("list_policy_tags")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.list_policy_tags(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_policy_tag' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient#get_policy_tag."

    it 'invokes get_policy_tag without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient.policy_tag_path("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      parent_policy_tag = "parentPolicyTag2071382466"
      expected_response = {
        name: name_2,
        display_name: display_name,
        description: description,
        parent_policy_tag: parent_policy_tag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::PolicyTag)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::GetPolicyTagRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_policy_tag, mock_method)

      # Mock auth layer
      mock_credentials = MockPolicyTagManagerCredentials_v1beta1.new("get_policy_tag")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)

          # Call method
          response = client.get_policy_tag(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_policy_tag(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_policy_tag with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient.policy_tag_path("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::GetPolicyTagRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_policy_tag, mock_method)

      # Mock auth layer
      mock_credentials = MockPolicyTagManagerCredentials_v1beta1.new("get_policy_tag")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.get_policy_tag(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_iam_policy' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient#get_iam_policy."

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
      mock_credentials = MockPolicyTagManagerCredentials_v1beta1.new("get_iam_policy")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)

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
      mock_credentials = MockPolicyTagManagerCredentials_v1beta1.new("get_iam_policy")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)

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
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient#set_iam_policy."

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
      mock_credentials = MockPolicyTagManagerCredentials_v1beta1.new("set_iam_policy")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)

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
      mock_credentials = MockPolicyTagManagerCredentials_v1beta1.new("set_iam_policy")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)

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
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient#test_iam_permissions."

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
      mock_credentials = MockPolicyTagManagerCredentials_v1beta1.new("test_iam_permissions")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)

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
      mock_credentials = MockPolicyTagManagerCredentials_v1beta1.new("test_iam_permissions")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)

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