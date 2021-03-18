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
require "google/cloud/dialogflow/v2beta1/participants_client"
require "google/cloud/dialogflow/v2beta1/participant_services_pb"

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

class MockParticipantsCredentials_v2beta1 < Google::Cloud::Dialogflow::V2beta1::Credentials
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

describe Google::Cloud::Dialogflow::V2beta1::ParticipantsClient do

  describe 'create_participant' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::ParticipantsClient#create_participant."

    it 'invokes create_participant without error' do
      # Create request parameters
      parent = ''
      participant = {}

      # Create expected grpc response
      name = "name3373707"
      obfuscated_external_user_id = "obfuscatedExternalUserId-263618122"
      expected_response = { name: name, obfuscated_external_user_id: obfuscated_external_user_id }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::Participant)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::CreateParticipantRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(Google::Gax::to_proto(participant, Google::Cloud::Dialogflow::V2beta1::Participant), request.participant)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:create_participant, mock_method)

      # Mock auth layer
      mock_credentials = MockParticipantsCredentials_v2beta1.new("create_participant")

      Google::Cloud::Dialogflow::V2beta1::Participants::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)

          # Call method
          response = client.create_participant(parent, participant)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_participant(parent, participant) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_participant with error' do
      # Create request parameters
      parent = ''
      participant = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::CreateParticipantRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(Google::Gax::to_proto(participant, Google::Cloud::Dialogflow::V2beta1::Participant), request.participant)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:create_participant, mock_method)

      # Mock auth layer
      mock_credentials = MockParticipantsCredentials_v2beta1.new("create_participant")

      Google::Cloud::Dialogflow::V2beta1::Participants::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.create_participant(parent, participant)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_participant' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::ParticipantsClient#get_participant."

    it 'invokes get_participant without error' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      obfuscated_external_user_id = "obfuscatedExternalUserId-263618122"
      expected_response = { name: name_2, obfuscated_external_user_id: obfuscated_external_user_id }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::Participant)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::GetParticipantRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:get_participant, mock_method)

      # Mock auth layer
      mock_credentials = MockParticipantsCredentials_v2beta1.new("get_participant")

      Google::Cloud::Dialogflow::V2beta1::Participants::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)

          # Call method
          response = client.get_participant(name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_participant(name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_participant with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::GetParticipantRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:get_participant, mock_method)

      # Mock auth layer
      mock_credentials = MockParticipantsCredentials_v2beta1.new("get_participant")

      Google::Cloud::Dialogflow::V2beta1::Participants::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.get_participant(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_participants' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::ParticipantsClient#list_participants."

    it 'invokes list_participants without error' do
      # Create request parameters
      parent = ''

      # Create expected grpc response
      next_page_token = ""
      participants_element = {}
      participants = [participants_element]
      expected_response = { next_page_token: next_page_token, participants: participants }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::ListParticipantsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::ListParticipantsRequest, request)
        assert_equal(parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:list_participants, mock_method)

      # Mock auth layer
      mock_credentials = MockParticipantsCredentials_v2beta1.new("list_participants")

      Google::Cloud::Dialogflow::V2beta1::Participants::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)

          # Call method
          response = client.list_participants(parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.participants.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_participants with error' do
      # Create request parameters
      parent = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::ListParticipantsRequest, request)
        assert_equal(parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:list_participants, mock_method)

      # Mock auth layer
      mock_credentials = MockParticipantsCredentials_v2beta1.new("list_participants")

      Google::Cloud::Dialogflow::V2beta1::Participants::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.list_participants(parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_participant' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::ParticipantsClient#update_participant."

    it 'invokes update_participant without error' do
      # Create request parameters
      participant = {}
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      obfuscated_external_user_id = "obfuscatedExternalUserId-263618122"
      expected_response = { name: name, obfuscated_external_user_id: obfuscated_external_user_id }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::Participant)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::UpdateParticipantRequest, request)
        assert_equal(Google::Gax::to_proto(participant, Google::Cloud::Dialogflow::V2beta1::Participant), request.participant)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:update_participant, mock_method)

      # Mock auth layer
      mock_credentials = MockParticipantsCredentials_v2beta1.new("update_participant")

      Google::Cloud::Dialogflow::V2beta1::Participants::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)

          # Call method
          response = client.update_participant(participant, update_mask)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_participant(participant, update_mask) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_participant with error' do
      # Create request parameters
      participant = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::UpdateParticipantRequest, request)
        assert_equal(Google::Gax::to_proto(participant, Google::Cloud::Dialogflow::V2beta1::Participant), request.participant)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:update_participant, mock_method)

      # Mock auth layer
      mock_credentials = MockParticipantsCredentials_v2beta1.new("update_participant")

      Google::Cloud::Dialogflow::V2beta1::Participants::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.update_participant(participant, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'analyze_content' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::ParticipantsClient#analyze_content."

    it 'invokes analyze_content without error' do
      # Create request parameters
      participant = ''

      # Create expected grpc response
      reply_text = "replyText-549180062"
      expected_response = { reply_text: reply_text }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::AnalyzeContentResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::AnalyzeContentRequest, request)
        assert_equal(participant, request.participant)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:analyze_content, mock_method)

      # Mock auth layer
      mock_credentials = MockParticipantsCredentials_v2beta1.new("analyze_content")

      Google::Cloud::Dialogflow::V2beta1::Participants::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)

          # Call method
          response = client.analyze_content(participant)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.analyze_content(participant) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes analyze_content with error' do
      # Create request parameters
      participant = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::AnalyzeContentRequest, request)
        assert_equal(participant, request.participant)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:analyze_content, mock_method)

      # Mock auth layer
      mock_credentials = MockParticipantsCredentials_v2beta1.new("analyze_content")

      Google::Cloud::Dialogflow::V2beta1::Participants::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.analyze_content(participant)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'suggest_articles' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::ParticipantsClient#suggest_articles."

    it 'invokes suggest_articles without error' do
      # Create request parameters
      parent = ''

      # Create expected grpc response
      latest_message = "latestMessage-1788166321"
      context_size = 1116903569
      expected_response = { latest_message: latest_message, context_size: context_size }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::SuggestArticlesResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::SuggestArticlesRequest, request)
        assert_equal(parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:suggest_articles, mock_method)

      # Mock auth layer
      mock_credentials = MockParticipantsCredentials_v2beta1.new("suggest_articles")

      Google::Cloud::Dialogflow::V2beta1::Participants::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)

          # Call method
          response = client.suggest_articles(parent)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.suggest_articles(parent) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes suggest_articles with error' do
      # Create request parameters
      parent = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::SuggestArticlesRequest, request)
        assert_equal(parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:suggest_articles, mock_method)

      # Mock auth layer
      mock_credentials = MockParticipantsCredentials_v2beta1.new("suggest_articles")

      Google::Cloud::Dialogflow::V2beta1::Participants::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.suggest_articles(parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'suggest_faq_answers' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::ParticipantsClient#suggest_faq_answers."

    it 'invokes suggest_faq_answers without error' do
      # Create request parameters
      parent = ''

      # Create expected grpc response
      latest_message = "latestMessage-1788166321"
      context_size = 1116903569
      expected_response = { latest_message: latest_message, context_size: context_size }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::SuggestFaqAnswersResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::SuggestFaqAnswersRequest, request)
        assert_equal(parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:suggest_faq_answers, mock_method)

      # Mock auth layer
      mock_credentials = MockParticipantsCredentials_v2beta1.new("suggest_faq_answers")

      Google::Cloud::Dialogflow::V2beta1::Participants::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)

          # Call method
          response = client.suggest_faq_answers(parent)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.suggest_faq_answers(parent) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes suggest_faq_answers with error' do
      # Create request parameters
      parent = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::SuggestFaqAnswersRequest, request)
        assert_equal(parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:suggest_faq_answers, mock_method)

      # Mock auth layer
      mock_credentials = MockParticipantsCredentials_v2beta1.new("suggest_faq_answers")

      Google::Cloud::Dialogflow::V2beta1::Participants::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.suggest_faq_answers(parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'suggest_smart_replies' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::ParticipantsClient#suggest_smart_replies."

    it 'invokes suggest_smart_replies without error' do
      # Create request parameters
      parent = ''

      # Create expected grpc response
      latest_message = "latestMessage-1788166321"
      context_size = 1116903569
      expected_response = { latest_message: latest_message, context_size: context_size }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::SuggestSmartRepliesResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::SuggestSmartRepliesRequest, request)
        assert_equal(parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:suggest_smart_replies, mock_method)

      # Mock auth layer
      mock_credentials = MockParticipantsCredentials_v2beta1.new("suggest_smart_replies")

      Google::Cloud::Dialogflow::V2beta1::Participants::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)

          # Call method
          response = client.suggest_smart_replies(parent)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.suggest_smart_replies(parent) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes suggest_smart_replies with error' do
      # Create request parameters
      parent = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::SuggestSmartRepliesRequest, request)
        assert_equal(parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:suggest_smart_replies, mock_method)

      # Mock auth layer
      mock_credentials = MockParticipantsCredentials_v2beta1.new("suggest_smart_replies")

      Google::Cloud::Dialogflow::V2beta1::Participants::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.suggest_smart_replies(parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_suggestions' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::ParticipantsClient#list_suggestions."

    it 'invokes list_suggestions without error' do
      # Create expected grpc response
      next_page_token = ""
      suggestions_element = {}
      suggestions = [suggestions_element]
      expected_response = { next_page_token: next_page_token, suggestions: suggestions }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::ListSuggestionsResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:list_suggestions, mock_method)

      # Mock auth layer
      mock_credentials = MockParticipantsCredentials_v2beta1.new("list_suggestions")

      Google::Cloud::Dialogflow::V2beta1::Participants::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)

          # Call method
          response = client.list_suggestions

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.suggestions.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_suggestions with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:list_suggestions, mock_method)

      # Mock auth layer
      mock_credentials = MockParticipantsCredentials_v2beta1.new("list_suggestions")

      Google::Cloud::Dialogflow::V2beta1::Participants::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.list_suggestions
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'compile_suggestion' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::ParticipantsClient#compile_suggestion."

    it 'invokes compile_suggestion without error' do
      # Create expected grpc response
      latest_message = "latestMessage-1788166321"
      context_size = 1116903569
      expected_response = { latest_message: latest_message, context_size: context_size }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::CompileSuggestionResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:compile_suggestion, mock_method)

      # Mock auth layer
      mock_credentials = MockParticipantsCredentials_v2beta1.new("compile_suggestion")

      Google::Cloud::Dialogflow::V2beta1::Participants::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)

          # Call method
          response = client.compile_suggestion

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.compile_suggestion do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes compile_suggestion with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:compile_suggestion, mock_method)

      # Mock auth layer
      mock_credentials = MockParticipantsCredentials_v2beta1.new("compile_suggestion")

      Google::Cloud::Dialogflow::V2beta1::Participants::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.compile_suggestion
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end