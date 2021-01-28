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

require "google/cloud/data_qn_a/v1alpha"
require "google/cloud/data_qn_a/v1alpha/question_service_client"
require "google/cloud/dataqna/v1alpha/question_service_services_pb"

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

class MockQuestionServiceCredentials_v1alpha < Google::Cloud::DataQnA::V1alpha::Credentials
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

describe Google::Cloud::DataQnA::V1alpha::QuestionServiceClient do

  describe 'get_question' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::DataQnA::V1alpha::QuestionServiceClient#get_question."

    it 'invokes get_question without error' do
      # Create request parameters
      formatted_name = Google::Cloud::DataQnA::V1alpha::QuestionServiceClient.question_path("[PROJECT]", "[LOCATION]", "[QUESTION]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      query = "query107944136"
      user_email = "userEmail1921668648"
      expected_response = {
        name: name_2,
        query: query,
        user_email: user_email
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dataqna::V1alpha::Question)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dataqna::V1alpha::GetQuestionRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_question, mock_method)

      # Mock auth layer
      mock_credentials = MockQuestionServiceCredentials_v1alpha.new("get_question")

      Google::Cloud::Dataqna::V1alpha::QuestionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::DataQnA::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::DataQnA::V1alpha::Question.new

          # Call method
          response = client.get_question(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_question(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_question with error' do
      # Create request parameters
      formatted_name = Google::Cloud::DataQnA::V1alpha::QuestionServiceClient.question_path("[PROJECT]", "[LOCATION]", "[QUESTION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dataqna::V1alpha::GetQuestionRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_question, mock_method)

      # Mock auth layer
      mock_credentials = MockQuestionServiceCredentials_v1alpha.new("get_question")

      Google::Cloud::Dataqna::V1alpha::QuestionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::DataQnA::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::DataQnA::V1alpha::Question.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.get_question(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_question' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::DataQnA::V1alpha::QuestionServiceClient#create_question."

    it 'invokes create_question without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::DataQnA::V1alpha::QuestionServiceClient.location_path("[PROJECT]", "[LOCATION]")
      question = {}

      # Create expected grpc response
      name = "name3373707"
      query = "query107944136"
      user_email = "userEmail1921668648"
      expected_response = {
        name: name,
        query: query,
        user_email: user_email
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dataqna::V1alpha::Question)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dataqna::V1alpha::CreateQuestionRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(question, Google::Cloud::Dataqna::V1alpha::Question), request.question)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:create_question, mock_method)

      # Mock auth layer
      mock_credentials = MockQuestionServiceCredentials_v1alpha.new("create_question")

      Google::Cloud::Dataqna::V1alpha::QuestionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::DataQnA::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::DataQnA::V1alpha::Question.new

          # Call method
          response = client.create_question(formatted_parent, question)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_question(formatted_parent, question) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_question with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::DataQnA::V1alpha::QuestionServiceClient.location_path("[PROJECT]", "[LOCATION]")
      question = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dataqna::V1alpha::CreateQuestionRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(question, Google::Cloud::Dataqna::V1alpha::Question), request.question)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:create_question, mock_method)

      # Mock auth layer
      mock_credentials = MockQuestionServiceCredentials_v1alpha.new("create_question")

      Google::Cloud::Dataqna::V1alpha::QuestionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::DataQnA::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::DataQnA::V1alpha::Question.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.create_question(formatted_parent, question)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'execute_question' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::DataQnA::V1alpha::QuestionServiceClient#execute_question."

    it 'invokes execute_question without error' do
      # Create request parameters
      name = ''
      interpretation_index = 0

      # Create expected grpc response
      name_2 = "name2-1052831874"
      query = "query107944136"
      user_email = "userEmail1921668648"
      expected_response = {
        name: name_2,
        query: query,
        user_email: user_email
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dataqna::V1alpha::Question)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dataqna::V1alpha::ExecuteQuestionRequest, request)
        assert_equal(name, request.name)
        assert_equal(interpretation_index, request.interpretation_index)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:execute_question, mock_method)

      # Mock auth layer
      mock_credentials = MockQuestionServiceCredentials_v1alpha.new("execute_question")

      Google::Cloud::Dataqna::V1alpha::QuestionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::DataQnA::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::DataQnA::V1alpha::Question.new

          # Call method
          response = client.execute_question(name, interpretation_index)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.execute_question(name, interpretation_index) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes execute_question with error' do
      # Create request parameters
      name = ''
      interpretation_index = 0

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dataqna::V1alpha::ExecuteQuestionRequest, request)
        assert_equal(name, request.name)
        assert_equal(interpretation_index, request.interpretation_index)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:execute_question, mock_method)

      # Mock auth layer
      mock_credentials = MockQuestionServiceCredentials_v1alpha.new("execute_question")

      Google::Cloud::Dataqna::V1alpha::QuestionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::DataQnA::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::DataQnA::V1alpha::Question.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.execute_question(name, interpretation_index)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_user_feedback' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::DataQnA::V1alpha::QuestionServiceClient#get_user_feedback."

    it 'invokes get_user_feedback without error' do
      # Create request parameters
      formatted_name = Google::Cloud::DataQnA::V1alpha::QuestionServiceClient.user_feedback_path("[PROJECT]", "[LOCATION]", "[QUESTION]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      free_form_feedback = "freeFormFeedback713254925"
      expected_response = { name: name_2, free_form_feedback: free_form_feedback }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dataqna::V1alpha::UserFeedback)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dataqna::V1alpha::GetUserFeedbackRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_user_feedback, mock_method)

      # Mock auth layer
      mock_credentials = MockQuestionServiceCredentials_v1alpha.new("get_user_feedback")

      Google::Cloud::Dataqna::V1alpha::QuestionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::DataQnA::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::DataQnA::V1alpha::Question.new

          # Call method
          response = client.get_user_feedback(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_user_feedback(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_user_feedback with error' do
      # Create request parameters
      formatted_name = Google::Cloud::DataQnA::V1alpha::QuestionServiceClient.user_feedback_path("[PROJECT]", "[LOCATION]", "[QUESTION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dataqna::V1alpha::GetUserFeedbackRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_user_feedback, mock_method)

      # Mock auth layer
      mock_credentials = MockQuestionServiceCredentials_v1alpha.new("get_user_feedback")

      Google::Cloud::Dataqna::V1alpha::QuestionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::DataQnA::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::DataQnA::V1alpha::Question.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.get_user_feedback(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_user_feedback' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::DataQnA::V1alpha::QuestionServiceClient#update_user_feedback."

    it 'invokes update_user_feedback without error' do
      # Create request parameters
      user_feedback = {}

      # Create expected grpc response
      name = "name3373707"
      free_form_feedback = "freeFormFeedback713254925"
      expected_response = { name: name, free_form_feedback: free_form_feedback }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dataqna::V1alpha::UserFeedback)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dataqna::V1alpha::UpdateUserFeedbackRequest, request)
        assert_equal(Google::Gax::to_proto(user_feedback, Google::Cloud::Dataqna::V1alpha::UserFeedback), request.user_feedback)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_user_feedback, mock_method)

      # Mock auth layer
      mock_credentials = MockQuestionServiceCredentials_v1alpha.new("update_user_feedback")

      Google::Cloud::Dataqna::V1alpha::QuestionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::DataQnA::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::DataQnA::V1alpha::Question.new

          # Call method
          response = client.update_user_feedback(user_feedback)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_user_feedback(user_feedback) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_user_feedback with error' do
      # Create request parameters
      user_feedback = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dataqna::V1alpha::UpdateUserFeedbackRequest, request)
        assert_equal(Google::Gax::to_proto(user_feedback, Google::Cloud::Dataqna::V1alpha::UserFeedback), request.user_feedback)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_user_feedback, mock_method)

      # Mock auth layer
      mock_credentials = MockQuestionServiceCredentials_v1alpha.new("update_user_feedback")

      Google::Cloud::Dataqna::V1alpha::QuestionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::DataQnA::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::DataQnA::V1alpha::Question.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.update_user_feedback(user_feedback)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end