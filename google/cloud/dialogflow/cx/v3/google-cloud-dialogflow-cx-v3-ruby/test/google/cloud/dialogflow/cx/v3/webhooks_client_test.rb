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
require "google/cloud/dialogflow/cx/v3/webhooks_client"
require "google/cloud/dialogflow/cx/v3/webhook_services_pb"

class CustomTestError_v3 < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v3

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

class MockWebhooksCredentials_v3 < Google::Cloud::Dialogflow::Cx::V3::Credentials
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

describe Google::Cloud::Dialogflow::Cx::V3::WebhooksClient do

  describe 'list_webhooks' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::WebhooksClient#list_webhooks."

    it 'invokes list_webhooks without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::WebhooksClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Create expected grpc response
      next_page_token = ""
      webhooks_element = {}
      webhooks = [webhooks_element]
      expected_response = { next_page_token: next_page_token, webhooks: webhooks }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3::ListWebhooksResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::ListWebhooksRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3.new(:list_webhooks, mock_method)

      # Mock auth layer
      mock_credentials = MockWebhooksCredentials_v3.new("list_webhooks")

      Google::Cloud::Dialogflow::Cx::V3::Webhooks::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Webhooks.new(version: :v3)

          # Call method
          response = client.list_webhooks(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.webhooks.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_webhooks with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::WebhooksClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::ListWebhooksRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:list_webhooks, mock_method)

      # Mock auth layer
      mock_credentials = MockWebhooksCredentials_v3.new("list_webhooks")

      Google::Cloud::Dialogflow::Cx::V3::Webhooks::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Webhooks.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.list_webhooks(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_webhook' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::WebhooksClient#get_webhook."

    it 'invokes get_webhook without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::WebhooksClient.webhook_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      disabled = true
      expected_response = {
        name: name_2,
        display_name: display_name,
        disabled: disabled
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3::Webhook)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::GetWebhookRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3.new(:get_webhook, mock_method)

      # Mock auth layer
      mock_credentials = MockWebhooksCredentials_v3.new("get_webhook")

      Google::Cloud::Dialogflow::Cx::V3::Webhooks::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Webhooks.new(version: :v3)

          # Call method
          response = client.get_webhook(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_webhook(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_webhook with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::WebhooksClient.webhook_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::GetWebhookRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:get_webhook, mock_method)

      # Mock auth layer
      mock_credentials = MockWebhooksCredentials_v3.new("get_webhook")

      Google::Cloud::Dialogflow::Cx::V3::Webhooks::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Webhooks.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.get_webhook(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_webhook' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::WebhooksClient#create_webhook."

    it 'invokes create_webhook without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::WebhooksClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
      webhook = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      disabled = true
      expected_response = {
        name: name,
        display_name: display_name,
        disabled: disabled
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3::Webhook)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::CreateWebhookRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(webhook, Google::Cloud::Dialogflow::Cx::V3::Webhook), request.webhook)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3.new(:create_webhook, mock_method)

      # Mock auth layer
      mock_credentials = MockWebhooksCredentials_v3.new("create_webhook")

      Google::Cloud::Dialogflow::Cx::V3::Webhooks::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Webhooks.new(version: :v3)

          # Call method
          response = client.create_webhook(formatted_parent, webhook)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_webhook(formatted_parent, webhook) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_webhook with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::WebhooksClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
      webhook = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::CreateWebhookRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(webhook, Google::Cloud::Dialogflow::Cx::V3::Webhook), request.webhook)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:create_webhook, mock_method)

      # Mock auth layer
      mock_credentials = MockWebhooksCredentials_v3.new("create_webhook")

      Google::Cloud::Dialogflow::Cx::V3::Webhooks::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Webhooks.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.create_webhook(formatted_parent, webhook)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_webhook' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::WebhooksClient#update_webhook."

    it 'invokes update_webhook without error' do
      # Create request parameters
      webhook = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      disabled = true
      expected_response = {
        name: name,
        display_name: display_name,
        disabled: disabled
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3::Webhook)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::UpdateWebhookRequest, request)
        assert_equal(Google::Gax::to_proto(webhook, Google::Cloud::Dialogflow::Cx::V3::Webhook), request.webhook)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3.new(:update_webhook, mock_method)

      # Mock auth layer
      mock_credentials = MockWebhooksCredentials_v3.new("update_webhook")

      Google::Cloud::Dialogflow::Cx::V3::Webhooks::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Webhooks.new(version: :v3)

          # Call method
          response = client.update_webhook(webhook)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_webhook(webhook) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_webhook with error' do
      # Create request parameters
      webhook = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::UpdateWebhookRequest, request)
        assert_equal(Google::Gax::to_proto(webhook, Google::Cloud::Dialogflow::Cx::V3::Webhook), request.webhook)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:update_webhook, mock_method)

      # Mock auth layer
      mock_credentials = MockWebhooksCredentials_v3.new("update_webhook")

      Google::Cloud::Dialogflow::Cx::V3::Webhooks::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Webhooks.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.update_webhook(webhook)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_webhook' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::WebhooksClient#delete_webhook."

    it 'invokes delete_webhook without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::WebhooksClient.webhook_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::DeleteWebhookRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v3.new(:delete_webhook, mock_method)

      # Mock auth layer
      mock_credentials = MockWebhooksCredentials_v3.new("delete_webhook")

      Google::Cloud::Dialogflow::Cx::V3::Webhooks::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Webhooks.new(version: :v3)

          # Call method
          response = client.delete_webhook(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_webhook(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_webhook with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::WebhooksClient.webhook_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::DeleteWebhookRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:delete_webhook, mock_method)

      # Mock auth layer
      mock_credentials = MockWebhooksCredentials_v3.new("delete_webhook")

      Google::Cloud::Dialogflow::Cx::V3::Webhooks::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Webhooks.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.delete_webhook(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end