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

require "google/cloud/pubsublite"
require "google/cloud/pubsublite/v1/admin_service_client"
require "google/cloud/pubsublite/v1/admin_services_pb"

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

class MockAdminServiceCredentials_v1 < Google::Cloud::Pubsublite::V1::Credentials
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

describe Google::Cloud::Pubsublite::V1::AdminServiceClient do

  describe 'create_topic' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Pubsublite::V1::AdminServiceClient#create_topic."

    it 'invokes create_topic without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Pubsublite::V1::AdminServiceClient.location_path("[PROJECT]", "[LOCATION]")
      topic = {}
      topic_id = ''

      # Create expected grpc response
      name = "name3373707"
      expected_response = { name: name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Pubsublite::V1::Topic)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::CreateTopicRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(topic, Google::Cloud::Pubsublite::V1::Topic), request.topic)
        assert_equal(topic_id, request.topic_id)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_topic, mock_method)

      # Mock auth layer
      mock_credentials = MockAdminServiceCredentials_v1.new("create_topic")

      Google::Cloud::Pubsublite::V1::AdminService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Admin.new(version: :v1)

          # Call method
          response = client.create_topic(
            formatted_parent,
            topic,
            topic_id
          )

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_topic(
            formatted_parent,
            topic,
            topic_id
          ) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_topic with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Pubsublite::V1::AdminServiceClient.location_path("[PROJECT]", "[LOCATION]")
      topic = {}
      topic_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::CreateTopicRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(topic, Google::Cloud::Pubsublite::V1::Topic), request.topic)
        assert_equal(topic_id, request.topic_id)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_topic, mock_method)

      # Mock auth layer
      mock_credentials = MockAdminServiceCredentials_v1.new("create_topic")

      Google::Cloud::Pubsublite::V1::AdminService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.create_topic(
              formatted_parent,
              topic,
              topic_id
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_topic' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Pubsublite::V1::AdminServiceClient#get_topic."

    it 'invokes get_topic without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Pubsublite::V1::AdminServiceClient.topic_path("[PROJECT]", "[LOCATION]", "[TOPIC]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      expected_response = { name: name_2 }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Pubsublite::V1::Topic)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::GetTopicRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_topic, mock_method)

      # Mock auth layer
      mock_credentials = MockAdminServiceCredentials_v1.new("get_topic")

      Google::Cloud::Pubsublite::V1::AdminService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Admin.new(version: :v1)

          # Call method
          response = client.get_topic(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_topic(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_topic with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Pubsublite::V1::AdminServiceClient.topic_path("[PROJECT]", "[LOCATION]", "[TOPIC]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::GetTopicRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_topic, mock_method)

      # Mock auth layer
      mock_credentials = MockAdminServiceCredentials_v1.new("get_topic")

      Google::Cloud::Pubsublite::V1::AdminService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_topic(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_topic_partitions' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Pubsublite::V1::AdminServiceClient#get_topic_partitions."

    it 'invokes get_topic_partitions without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Pubsublite::V1::AdminServiceClient.topic_path("[PROJECT]", "[LOCATION]", "[TOPIC]")

      # Create expected grpc response
      partition_count = 1738969222
      expected_response = { partition_count: partition_count }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Pubsublite::V1::TopicPartitions)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::GetTopicPartitionsRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_topic_partitions, mock_method)

      # Mock auth layer
      mock_credentials = MockAdminServiceCredentials_v1.new("get_topic_partitions")

      Google::Cloud::Pubsublite::V1::AdminService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Admin.new(version: :v1)

          # Call method
          response = client.get_topic_partitions(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_topic_partitions(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_topic_partitions with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Pubsublite::V1::AdminServiceClient.topic_path("[PROJECT]", "[LOCATION]", "[TOPIC]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::GetTopicPartitionsRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_topic_partitions, mock_method)

      # Mock auth layer
      mock_credentials = MockAdminServiceCredentials_v1.new("get_topic_partitions")

      Google::Cloud::Pubsublite::V1::AdminService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_topic_partitions(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_topics' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Pubsublite::V1::AdminServiceClient#list_topics."

    it 'invokes list_topics without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Pubsublite::V1::AdminServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      topics_element = {}
      topics = [topics_element]
      expected_response = { next_page_token: next_page_token, topics: topics }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Pubsublite::V1::ListTopicsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::ListTopicsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_topics, mock_method)

      # Mock auth layer
      mock_credentials = MockAdminServiceCredentials_v1.new("list_topics")

      Google::Cloud::Pubsublite::V1::AdminService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Admin.new(version: :v1)

          # Call method
          response = client.list_topics(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.topics.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_topics with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Pubsublite::V1::AdminServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::ListTopicsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_topics, mock_method)

      # Mock auth layer
      mock_credentials = MockAdminServiceCredentials_v1.new("list_topics")

      Google::Cloud::Pubsublite::V1::AdminService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_topics(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_topic' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Pubsublite::V1::AdminServiceClient#update_topic."

    it 'invokes update_topic without error' do
      # Create request parameters
      topic = {}
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      expected_response = { name: name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Pubsublite::V1::Topic)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::UpdateTopicRequest, request)
        assert_equal(Google::Gax::to_proto(topic, Google::Cloud::Pubsublite::V1::Topic), request.topic)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_topic, mock_method)

      # Mock auth layer
      mock_credentials = MockAdminServiceCredentials_v1.new("update_topic")

      Google::Cloud::Pubsublite::V1::AdminService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Admin.new(version: :v1)

          # Call method
          response = client.update_topic(topic, update_mask)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_topic(topic, update_mask) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_topic with error' do
      # Create request parameters
      topic = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::UpdateTopicRequest, request)
        assert_equal(Google::Gax::to_proto(topic, Google::Cloud::Pubsublite::V1::Topic), request.topic)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_topic, mock_method)

      # Mock auth layer
      mock_credentials = MockAdminServiceCredentials_v1.new("update_topic")

      Google::Cloud::Pubsublite::V1::AdminService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.update_topic(topic, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_topic' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Pubsublite::V1::AdminServiceClient#delete_topic."

    it 'invokes delete_topic without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Pubsublite::V1::AdminServiceClient.topic_path("[PROJECT]", "[LOCATION]", "[TOPIC]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::DeleteTopicRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_topic, mock_method)

      # Mock auth layer
      mock_credentials = MockAdminServiceCredentials_v1.new("delete_topic")

      Google::Cloud::Pubsublite::V1::AdminService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Admin.new(version: :v1)

          # Call method
          response = client.delete_topic(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_topic(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_topic with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Pubsublite::V1::AdminServiceClient.topic_path("[PROJECT]", "[LOCATION]", "[TOPIC]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::DeleteTopicRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_topic, mock_method)

      # Mock auth layer
      mock_credentials = MockAdminServiceCredentials_v1.new("delete_topic")

      Google::Cloud::Pubsublite::V1::AdminService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_topic(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_topic_subscriptions' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Pubsublite::V1::AdminServiceClient#list_topic_subscriptions."

    it 'invokes list_topic_subscriptions without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Pubsublite::V1::AdminServiceClient.topic_path("[PROJECT]", "[LOCATION]", "[TOPIC]")

      # Create expected grpc response
      next_page_token = ""
      subscriptions_element = "subscriptionsElement1698708147"
      subscriptions = [subscriptions_element]
      expected_response = { next_page_token: next_page_token, subscriptions: subscriptions }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Pubsublite::V1::ListTopicSubscriptionsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::ListTopicSubscriptionsRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_topic_subscriptions, mock_method)

      # Mock auth layer
      mock_credentials = MockAdminServiceCredentials_v1.new("list_topic_subscriptions")

      Google::Cloud::Pubsublite::V1::AdminService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Admin.new(version: :v1)

          # Call method
          response = client.list_topic_subscriptions(formatted_name)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.subscriptions.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_topic_subscriptions with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Pubsublite::V1::AdminServiceClient.topic_path("[PROJECT]", "[LOCATION]", "[TOPIC]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::ListTopicSubscriptionsRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_topic_subscriptions, mock_method)

      # Mock auth layer
      mock_credentials = MockAdminServiceCredentials_v1.new("list_topic_subscriptions")

      Google::Cloud::Pubsublite::V1::AdminService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_topic_subscriptions(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_subscription' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Pubsublite::V1::AdminServiceClient#create_subscription."

    it 'invokes create_subscription without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Pubsublite::V1::AdminServiceClient.location_path("[PROJECT]", "[LOCATION]")
      subscription = {}
      subscription_id = ''

      # Create expected grpc response
      name = "name3373707"
      topic = "topic110546223"
      expected_response = { name: name, topic: topic }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Pubsublite::V1::Subscription)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::CreateSubscriptionRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(subscription, Google::Cloud::Pubsublite::V1::Subscription), request.subscription)
        assert_equal(subscription_id, request.subscription_id)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_subscription, mock_method)

      # Mock auth layer
      mock_credentials = MockAdminServiceCredentials_v1.new("create_subscription")

      Google::Cloud::Pubsublite::V1::AdminService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Admin.new(version: :v1)

          # Call method
          response = client.create_subscription(
            formatted_parent,
            subscription,
            subscription_id
          )

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_subscription(
            formatted_parent,
            subscription,
            subscription_id
          ) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_subscription with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Pubsublite::V1::AdminServiceClient.location_path("[PROJECT]", "[LOCATION]")
      subscription = {}
      subscription_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::CreateSubscriptionRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(subscription, Google::Cloud::Pubsublite::V1::Subscription), request.subscription)
        assert_equal(subscription_id, request.subscription_id)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_subscription, mock_method)

      # Mock auth layer
      mock_credentials = MockAdminServiceCredentials_v1.new("create_subscription")

      Google::Cloud::Pubsublite::V1::AdminService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.create_subscription(
              formatted_parent,
              subscription,
              subscription_id
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_subscription' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Pubsublite::V1::AdminServiceClient#get_subscription."

    it 'invokes get_subscription without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Pubsublite::V1::AdminServiceClient.subscription_path("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      topic = "topic110546223"
      expected_response = { name: name_2, topic: topic }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Pubsublite::V1::Subscription)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::GetSubscriptionRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_subscription, mock_method)

      # Mock auth layer
      mock_credentials = MockAdminServiceCredentials_v1.new("get_subscription")

      Google::Cloud::Pubsublite::V1::AdminService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Admin.new(version: :v1)

          # Call method
          response = client.get_subscription(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_subscription(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_subscription with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Pubsublite::V1::AdminServiceClient.subscription_path("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::GetSubscriptionRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_subscription, mock_method)

      # Mock auth layer
      mock_credentials = MockAdminServiceCredentials_v1.new("get_subscription")

      Google::Cloud::Pubsublite::V1::AdminService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_subscription(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_subscriptions' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Pubsublite::V1::AdminServiceClient#list_subscriptions."

    it 'invokes list_subscriptions without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Pubsublite::V1::AdminServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      subscriptions_element = {}
      subscriptions = [subscriptions_element]
      expected_response = { next_page_token: next_page_token, subscriptions: subscriptions }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Pubsublite::V1::ListSubscriptionsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::ListSubscriptionsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_subscriptions, mock_method)

      # Mock auth layer
      mock_credentials = MockAdminServiceCredentials_v1.new("list_subscriptions")

      Google::Cloud::Pubsublite::V1::AdminService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Admin.new(version: :v1)

          # Call method
          response = client.list_subscriptions(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.subscriptions.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_subscriptions with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Pubsublite::V1::AdminServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::ListSubscriptionsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_subscriptions, mock_method)

      # Mock auth layer
      mock_credentials = MockAdminServiceCredentials_v1.new("list_subscriptions")

      Google::Cloud::Pubsublite::V1::AdminService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_subscriptions(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_subscription' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Pubsublite::V1::AdminServiceClient#update_subscription."

    it 'invokes update_subscription without error' do
      # Create request parameters
      subscription = {}
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      topic = "topic110546223"
      expected_response = { name: name, topic: topic }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Pubsublite::V1::Subscription)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::UpdateSubscriptionRequest, request)
        assert_equal(Google::Gax::to_proto(subscription, Google::Cloud::Pubsublite::V1::Subscription), request.subscription)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_subscription, mock_method)

      # Mock auth layer
      mock_credentials = MockAdminServiceCredentials_v1.new("update_subscription")

      Google::Cloud::Pubsublite::V1::AdminService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Admin.new(version: :v1)

          # Call method
          response = client.update_subscription(subscription, update_mask)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_subscription(subscription, update_mask) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_subscription with error' do
      # Create request parameters
      subscription = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::UpdateSubscriptionRequest, request)
        assert_equal(Google::Gax::to_proto(subscription, Google::Cloud::Pubsublite::V1::Subscription), request.subscription)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_subscription, mock_method)

      # Mock auth layer
      mock_credentials = MockAdminServiceCredentials_v1.new("update_subscription")

      Google::Cloud::Pubsublite::V1::AdminService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.update_subscription(subscription, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_subscription' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Pubsublite::V1::AdminServiceClient#delete_subscription."

    it 'invokes delete_subscription without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Pubsublite::V1::AdminServiceClient.subscription_path("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::DeleteSubscriptionRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_subscription, mock_method)

      # Mock auth layer
      mock_credentials = MockAdminServiceCredentials_v1.new("delete_subscription")

      Google::Cloud::Pubsublite::V1::AdminService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Admin.new(version: :v1)

          # Call method
          response = client.delete_subscription(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_subscription(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_subscription with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Pubsublite::V1::AdminServiceClient.subscription_path("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::DeleteSubscriptionRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_subscription, mock_method)

      # Mock auth layer
      mock_credentials = MockAdminServiceCredentials_v1.new("delete_subscription")

      Google::Cloud::Pubsublite::V1::AdminService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Admin.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_subscription(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end