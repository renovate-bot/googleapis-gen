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
require "google/cloud/dialogflow/v2beta1/conversations_client"
require "google/cloud/dialogflow/v2beta1/conversation_services_pb"

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

class MockConversationsCredentials_v2beta1 < Google::Cloud::Dialogflow::V2beta1::Credentials
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

describe Google::Cloud::Dialogflow::V2beta1::ConversationsClient do

  describe 'create_conversation' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::ConversationsClient#create_conversation."

    it 'invokes create_conversation without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::V2beta1::ConversationsClient.project_path("[PROJECT]")
      conversation = {}

      # Create expected grpc response
      name = "name3373707"
      conversation_profile = "conversationProfile-408626707"
      expected_response = { name: name, conversation_profile: conversation_profile }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::Conversation)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::CreateConversationRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(conversation, Google::Cloud::Dialogflow::V2beta1::Conversation), request.conversation)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:create_conversation, mock_method)

      # Mock auth layer
      mock_credentials = MockConversationsCredentials_v2beta1.new("create_conversation")

      Google::Cloud::Dialogflow::V2beta1::Conversations::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Conversations.new(version: :v2beta1)

          # Call method
          response = client.create_conversation(formatted_parent, conversation)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_conversation(formatted_parent, conversation) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_conversation with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::V2beta1::ConversationsClient.project_path("[PROJECT]")
      conversation = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::CreateConversationRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(conversation, Google::Cloud::Dialogflow::V2beta1::Conversation), request.conversation)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:create_conversation, mock_method)

      # Mock auth layer
      mock_credentials = MockConversationsCredentials_v2beta1.new("create_conversation")

      Google::Cloud::Dialogflow::V2beta1::Conversations::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Conversations.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.create_conversation(formatted_parent, conversation)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_conversations' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::ConversationsClient#list_conversations."

    it 'invokes list_conversations without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::V2beta1::ConversationsClient.project_path("[PROJECT]")

      # Create expected grpc response
      next_page_token = ""
      conversations_element = {}
      conversations = [conversations_element]
      expected_response = { next_page_token: next_page_token, conversations: conversations }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::ListConversationsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::ListConversationsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:list_conversations, mock_method)

      # Mock auth layer
      mock_credentials = MockConversationsCredentials_v2beta1.new("list_conversations")

      Google::Cloud::Dialogflow::V2beta1::Conversations::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Conversations.new(version: :v2beta1)

          # Call method
          response = client.list_conversations(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.conversations.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_conversations with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::V2beta1::ConversationsClient.project_path("[PROJECT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::ListConversationsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:list_conversations, mock_method)

      # Mock auth layer
      mock_credentials = MockConversationsCredentials_v2beta1.new("list_conversations")

      Google::Cloud::Dialogflow::V2beta1::Conversations::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Conversations.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.list_conversations(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_conversation' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::ConversationsClient#get_conversation."

    it 'invokes get_conversation without error' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      conversation_profile = "conversationProfile-408626707"
      expected_response = { name: name_2, conversation_profile: conversation_profile }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::Conversation)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::GetConversationRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:get_conversation, mock_method)

      # Mock auth layer
      mock_credentials = MockConversationsCredentials_v2beta1.new("get_conversation")

      Google::Cloud::Dialogflow::V2beta1::Conversations::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Conversations.new(version: :v2beta1)

          # Call method
          response = client.get_conversation(name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_conversation(name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_conversation with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::GetConversationRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:get_conversation, mock_method)

      # Mock auth layer
      mock_credentials = MockConversationsCredentials_v2beta1.new("get_conversation")

      Google::Cloud::Dialogflow::V2beta1::Conversations::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Conversations.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.get_conversation(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'complete_conversation' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::ConversationsClient#complete_conversation."

    it 'invokes complete_conversation without error' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      conversation_profile = "conversationProfile-408626707"
      expected_response = { name: name_2, conversation_profile: conversation_profile }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::Conversation)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::CompleteConversationRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:complete_conversation, mock_method)

      # Mock auth layer
      mock_credentials = MockConversationsCredentials_v2beta1.new("complete_conversation")

      Google::Cloud::Dialogflow::V2beta1::Conversations::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Conversations.new(version: :v2beta1)

          # Call method
          response = client.complete_conversation(name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.complete_conversation(name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes complete_conversation with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::CompleteConversationRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:complete_conversation, mock_method)

      # Mock auth layer
      mock_credentials = MockConversationsCredentials_v2beta1.new("complete_conversation")

      Google::Cloud::Dialogflow::V2beta1::Conversations::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Conversations.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.complete_conversation(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'batch_create_messages' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::ConversationsClient#batch_create_messages."

    it 'invokes batch_create_messages without error' do
      # Create request parameters
      parent = ''
      requests = []

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::BatchCreateMessagesResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::BatchCreateMessagesRequest, request)
        assert_equal(parent, request.parent)
        requests = requests.map do |req|
          Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::CreateMessageRequest)
        end
        assert_equal(requests, request.requests)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:batch_create_messages, mock_method)

      # Mock auth layer
      mock_credentials = MockConversationsCredentials_v2beta1.new("batch_create_messages")

      Google::Cloud::Dialogflow::V2beta1::Conversations::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Conversations.new(version: :v2beta1)

          # Call method
          response = client.batch_create_messages(parent, requests)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.batch_create_messages(parent, requests) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes batch_create_messages with error' do
      # Create request parameters
      parent = ''
      requests = []

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::BatchCreateMessagesRequest, request)
        assert_equal(parent, request.parent)
        requests = requests.map do |req|
          Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::CreateMessageRequest)
        end
        assert_equal(requests, request.requests)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:batch_create_messages, mock_method)

      # Mock auth layer
      mock_credentials = MockConversationsCredentials_v2beta1.new("batch_create_messages")

      Google::Cloud::Dialogflow::V2beta1::Conversations::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Conversations.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.batch_create_messages(parent, requests)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_messages' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::ConversationsClient#list_messages."

    it 'invokes list_messages without error' do
      # Create request parameters
      parent = ''

      # Create expected grpc response
      next_page_token = ""
      messages_element = {}
      messages = [messages_element]
      expected_response = { next_page_token: next_page_token, messages: messages }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::ListMessagesResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::ListMessagesRequest, request)
        assert_equal(parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:list_messages, mock_method)

      # Mock auth layer
      mock_credentials = MockConversationsCredentials_v2beta1.new("list_messages")

      Google::Cloud::Dialogflow::V2beta1::Conversations::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Conversations.new(version: :v2beta1)

          # Call method
          response = client.list_messages(parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.messages.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_messages with error' do
      # Create request parameters
      parent = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::ListMessagesRequest, request)
        assert_equal(parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:list_messages, mock_method)

      # Mock auth layer
      mock_credentials = MockConversationsCredentials_v2beta1.new("list_messages")

      Google::Cloud::Dialogflow::V2beta1::Conversations::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Conversations.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.list_messages(parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end