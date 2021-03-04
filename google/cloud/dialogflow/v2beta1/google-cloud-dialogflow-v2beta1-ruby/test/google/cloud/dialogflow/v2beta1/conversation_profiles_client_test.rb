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

require "google/cloud/dialogflow"
require "google/cloud/dialogflow/v2beta1/conversation_profiles_client"
require "google/cloud/dialogflow/v2beta1/conversation_profile_services_pb"

class CustomTestError_v2beta1 < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v2beta1

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

class MockConversationProfilesCredentials_v2beta1 < Google::Cloud::Dialogflow::V2beta1::Credentials
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

describe Google::Cloud::Dialogflow::V2beta1::ConversationProfilesClient do

  describe 'list_conversation_profiles' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::ConversationProfilesClient#list_conversation_profiles."

    it 'invokes list_conversation_profiles without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::V2beta1::ConversationProfilesClient.project_path("[PROJECT]")

      # Create expected grpc response
      next_page_token = ""
      conversation_profiles_element = {}
      conversation_profiles = [conversation_profiles_element]
      expected_response = { next_page_token: next_page_token, conversation_profiles: conversation_profiles }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::ListConversationProfilesResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::ListConversationProfilesRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:list_conversation_profiles, mock_method)

      # Mock auth layer
      mock_credentials = MockConversationProfilesCredentials_v2beta1.new("list_conversation_profiles")

      Google::Cloud::Dialogflow::V2beta1::ConversationProfiles::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::ConversationProfiles.new(version: :v2beta1)

          # Call method
          response = client.list_conversation_profiles(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.conversation_profiles.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_conversation_profiles with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::V2beta1::ConversationProfilesClient.project_path("[PROJECT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::ListConversationProfilesRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:list_conversation_profiles, mock_method)

      # Mock auth layer
      mock_credentials = MockConversationProfilesCredentials_v2beta1.new("list_conversation_profiles")

      Google::Cloud::Dialogflow::V2beta1::ConversationProfiles::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::ConversationProfiles.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.list_conversation_profiles(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_conversation_profile' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::ConversationProfilesClient#get_conversation_profile."

    it 'invokes get_conversation_profile without error' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      language_code = "languageCode-412800396"
      expected_response = {
        name: name_2,
        display_name: display_name,
        language_code: language_code
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::ConversationProfile)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::GetConversationProfileRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:get_conversation_profile, mock_method)

      # Mock auth layer
      mock_credentials = MockConversationProfilesCredentials_v2beta1.new("get_conversation_profile")

      Google::Cloud::Dialogflow::V2beta1::ConversationProfiles::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::ConversationProfiles.new(version: :v2beta1)

          # Call method
          response = client.get_conversation_profile(name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_conversation_profile(name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_conversation_profile with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::GetConversationProfileRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:get_conversation_profile, mock_method)

      # Mock auth layer
      mock_credentials = MockConversationProfilesCredentials_v2beta1.new("get_conversation_profile")

      Google::Cloud::Dialogflow::V2beta1::ConversationProfiles::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::ConversationProfiles.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.get_conversation_profile(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_conversation_profile' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::ConversationProfilesClient#create_conversation_profile."

    it 'invokes create_conversation_profile without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::V2beta1::ConversationProfilesClient.project_path("[PROJECT]")
      conversation_profile = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      language_code = "languageCode-412800396"
      expected_response = {
        name: name,
        display_name: display_name,
        language_code: language_code
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::ConversationProfile)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::CreateConversationProfileRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(conversation_profile, Google::Cloud::Dialogflow::V2beta1::ConversationProfile), request.conversation_profile)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:create_conversation_profile, mock_method)

      # Mock auth layer
      mock_credentials = MockConversationProfilesCredentials_v2beta1.new("create_conversation_profile")

      Google::Cloud::Dialogflow::V2beta1::ConversationProfiles::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::ConversationProfiles.new(version: :v2beta1)

          # Call method
          response = client.create_conversation_profile(formatted_parent, conversation_profile)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_conversation_profile(formatted_parent, conversation_profile) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_conversation_profile with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::V2beta1::ConversationProfilesClient.project_path("[PROJECT]")
      conversation_profile = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::CreateConversationProfileRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(conversation_profile, Google::Cloud::Dialogflow::V2beta1::ConversationProfile), request.conversation_profile)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:create_conversation_profile, mock_method)

      # Mock auth layer
      mock_credentials = MockConversationProfilesCredentials_v2beta1.new("create_conversation_profile")

      Google::Cloud::Dialogflow::V2beta1::ConversationProfiles::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::ConversationProfiles.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.create_conversation_profile(formatted_parent, conversation_profile)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_conversation_profile' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::ConversationProfilesClient#update_conversation_profile."

    it 'invokes update_conversation_profile without error' do
      # Create request parameters
      conversation_profile = {}
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      language_code = "languageCode-412800396"
      expected_response = {
        name: name,
        display_name: display_name,
        language_code: language_code
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::ConversationProfile)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::UpdateConversationProfileRequest, request)
        assert_equal(Google::Gax::to_proto(conversation_profile, Google::Cloud::Dialogflow::V2beta1::ConversationProfile), request.conversation_profile)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:update_conversation_profile, mock_method)

      # Mock auth layer
      mock_credentials = MockConversationProfilesCredentials_v2beta1.new("update_conversation_profile")

      Google::Cloud::Dialogflow::V2beta1::ConversationProfiles::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::ConversationProfiles.new(version: :v2beta1)

          # Call method
          response = client.update_conversation_profile(conversation_profile, update_mask)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_conversation_profile(conversation_profile, update_mask) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_conversation_profile with error' do
      # Create request parameters
      conversation_profile = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::UpdateConversationProfileRequest, request)
        assert_equal(Google::Gax::to_proto(conversation_profile, Google::Cloud::Dialogflow::V2beta1::ConversationProfile), request.conversation_profile)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:update_conversation_profile, mock_method)

      # Mock auth layer
      mock_credentials = MockConversationProfilesCredentials_v2beta1.new("update_conversation_profile")

      Google::Cloud::Dialogflow::V2beta1::ConversationProfiles::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::ConversationProfiles.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.update_conversation_profile(conversation_profile, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_conversation_profile' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::ConversationProfilesClient#delete_conversation_profile."

    it 'invokes delete_conversation_profile without error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::DeleteConversationProfileRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:delete_conversation_profile, mock_method)

      # Mock auth layer
      mock_credentials = MockConversationProfilesCredentials_v2beta1.new("delete_conversation_profile")

      Google::Cloud::Dialogflow::V2beta1::ConversationProfiles::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::ConversationProfiles.new(version: :v2beta1)

          # Call method
          response = client.delete_conversation_profile(name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_conversation_profile(name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_conversation_profile with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::DeleteConversationProfileRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:delete_conversation_profile, mock_method)

      # Mock auth layer
      mock_credentials = MockConversationProfilesCredentials_v2beta1.new("delete_conversation_profile")

      Google::Cloud::Dialogflow::V2beta1::ConversationProfiles::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::ConversationProfiles.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.delete_conversation_profile(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end