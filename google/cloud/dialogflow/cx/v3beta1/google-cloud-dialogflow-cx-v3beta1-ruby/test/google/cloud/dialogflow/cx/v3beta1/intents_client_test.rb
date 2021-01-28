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

require "google/cloud/dialogflow/cx"
require "google/cloud/dialogflow/cx/v3beta1/intents_client"
require "google/cloud/dialogflow/cx/v3beta1/intent_services_pb"

class CustomTestError_v3beta1 < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v3beta1

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

class MockIntentsCredentials_v3beta1 < Google::Cloud::Dialogflow::Cx::V3beta1::Credentials
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

describe Google::Cloud::Dialogflow::Cx::V3beta1::IntentsClient do

  describe 'list_intents' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::IntentsClient#list_intents."

    it 'invokes list_intents without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::IntentsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Create expected grpc response
      next_page_token = ""
      intents_element = {}
      intents = [intents_element]
      expected_response = { next_page_token: next_page_token, intents: intents }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3beta1::ListIntentsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::ListIntentsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:list_intents, mock_method)

      # Mock auth layer
      mock_credentials = MockIntentsCredentials_v3beta1.new("list_intents")

      Google::Cloud::Dialogflow::Cx::V3beta1::Intents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Intents.new(version: :v3beta1)

          # Call method
          response = client.list_intents(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.intents.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_intents with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::IntentsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::ListIntentsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:list_intents, mock_method)

      # Mock auth layer
      mock_credentials = MockIntentsCredentials_v3beta1.new("list_intents")

      Google::Cloud::Dialogflow::Cx::V3beta1::Intents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Intents.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.list_intents(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_intent' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::IntentsClient#get_intent."

    it 'invokes get_intent without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::IntentsClient.intent_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      priority = 1165461084
      is_fallback = false
      description = "description-1724546052"
      expected_response = {
        name: name_2,
        display_name: display_name,
        priority: priority,
        is_fallback: is_fallback,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3beta1::Intent)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::GetIntentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:get_intent, mock_method)

      # Mock auth layer
      mock_credentials = MockIntentsCredentials_v3beta1.new("get_intent")

      Google::Cloud::Dialogflow::Cx::V3beta1::Intents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Intents.new(version: :v3beta1)

          # Call method
          response = client.get_intent(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_intent(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_intent with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::IntentsClient.intent_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::GetIntentRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:get_intent, mock_method)

      # Mock auth layer
      mock_credentials = MockIntentsCredentials_v3beta1.new("get_intent")

      Google::Cloud::Dialogflow::Cx::V3beta1::Intents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Intents.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.get_intent(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_intent' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::IntentsClient#create_intent."

    it 'invokes create_intent without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::IntentsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
      intent = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      priority = 1165461084
      is_fallback = false
      description = "description-1724546052"
      expected_response = {
        name: name,
        display_name: display_name,
        priority: priority,
        is_fallback: is_fallback,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3beta1::Intent)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::CreateIntentRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(intent, Google::Cloud::Dialogflow::Cx::V3beta1::Intent), request.intent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:create_intent, mock_method)

      # Mock auth layer
      mock_credentials = MockIntentsCredentials_v3beta1.new("create_intent")

      Google::Cloud::Dialogflow::Cx::V3beta1::Intents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Intents.new(version: :v3beta1)

          # Call method
          response = client.create_intent(formatted_parent, intent)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_intent(formatted_parent, intent) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_intent with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::IntentsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
      intent = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::CreateIntentRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(intent, Google::Cloud::Dialogflow::Cx::V3beta1::Intent), request.intent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:create_intent, mock_method)

      # Mock auth layer
      mock_credentials = MockIntentsCredentials_v3beta1.new("create_intent")

      Google::Cloud::Dialogflow::Cx::V3beta1::Intents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Intents.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.create_intent(formatted_parent, intent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_intent' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::IntentsClient#update_intent."

    it 'invokes update_intent without error' do
      # Create request parameters
      intent = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      priority = 1165461084
      is_fallback = false
      description = "description-1724546052"
      expected_response = {
        name: name,
        display_name: display_name,
        priority: priority,
        is_fallback: is_fallback,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3beta1::Intent)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::UpdateIntentRequest, request)
        assert_equal(Google::Gax::to_proto(intent, Google::Cloud::Dialogflow::Cx::V3beta1::Intent), request.intent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:update_intent, mock_method)

      # Mock auth layer
      mock_credentials = MockIntentsCredentials_v3beta1.new("update_intent")

      Google::Cloud::Dialogflow::Cx::V3beta1::Intents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Intents.new(version: :v3beta1)

          # Call method
          response = client.update_intent(intent)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_intent(intent) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_intent with error' do
      # Create request parameters
      intent = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::UpdateIntentRequest, request)
        assert_equal(Google::Gax::to_proto(intent, Google::Cloud::Dialogflow::Cx::V3beta1::Intent), request.intent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:update_intent, mock_method)

      # Mock auth layer
      mock_credentials = MockIntentsCredentials_v3beta1.new("update_intent")

      Google::Cloud::Dialogflow::Cx::V3beta1::Intents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Intents.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.update_intent(intent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_intent' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::IntentsClient#delete_intent."

    it 'invokes delete_intent without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::IntentsClient.intent_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::DeleteIntentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:delete_intent, mock_method)

      # Mock auth layer
      mock_credentials = MockIntentsCredentials_v3beta1.new("delete_intent")

      Google::Cloud::Dialogflow::Cx::V3beta1::Intents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Intents.new(version: :v3beta1)

          # Call method
          response = client.delete_intent(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_intent(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_intent with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::IntentsClient.intent_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::DeleteIntentRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:delete_intent, mock_method)

      # Mock auth layer
      mock_credentials = MockIntentsCredentials_v3beta1.new("delete_intent")

      Google::Cloud::Dialogflow::Cx::V3beta1::Intents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Intents.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.delete_intent(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end