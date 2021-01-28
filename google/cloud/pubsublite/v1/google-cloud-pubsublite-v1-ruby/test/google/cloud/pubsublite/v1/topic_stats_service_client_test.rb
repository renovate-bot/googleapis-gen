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
require "google/cloud/pubsublite/v1/topic_stats_service_client"
require "google/cloud/pubsublite/v1/topic_stats_services_pb"

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

class MockTopicStatsServiceCredentials_v1 < Google::Cloud::Pubsublite::V1::Credentials
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

describe Google::Cloud::Pubsublite::V1::TopicStatsServiceClient do

  describe 'compute_message_stats' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Pubsublite::V1::TopicStatsServiceClient#compute_message_stats."

    it 'invokes compute_message_stats without error' do
      # Create request parameters
      formatted_topic = Google::Cloud::Pubsublite::V1::TopicStatsServiceClient.topic_path("[PROJECT]", "[LOCATION]", "[TOPIC]")
      partition = 0

      # Create expected grpc response
      message_count = 1229303081
      message_bytes = 1229929933
      expected_response = { message_count: message_count, message_bytes: message_bytes }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Pubsublite::V1::ComputeMessageStatsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::ComputeMessageStatsRequest, request)
        assert_equal(formatted_topic, request.topic)
        assert_equal(partition, request.partition)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:compute_message_stats, mock_method)

      # Mock auth layer
      mock_credentials = MockTopicStatsServiceCredentials_v1.new("compute_message_stats")

      Google::Cloud::Pubsublite::V1::TopicStatsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::TopicStats.new(version: :v1)

          # Call method
          response = client.compute_message_stats(formatted_topic, partition)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.compute_message_stats(formatted_topic, partition) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes compute_message_stats with error' do
      # Create request parameters
      formatted_topic = Google::Cloud::Pubsublite::V1::TopicStatsServiceClient.topic_path("[PROJECT]", "[LOCATION]", "[TOPIC]")
      partition = 0

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::ComputeMessageStatsRequest, request)
        assert_equal(formatted_topic, request.topic)
        assert_equal(partition, request.partition)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:compute_message_stats, mock_method)

      # Mock auth layer
      mock_credentials = MockTopicStatsServiceCredentials_v1.new("compute_message_stats")

      Google::Cloud::Pubsublite::V1::TopicStatsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::TopicStats.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.compute_message_stats(formatted_topic, partition)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'compute_head_cursor' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Pubsublite::V1::TopicStatsServiceClient#compute_head_cursor."

    it 'invokes compute_head_cursor without error' do
      # Create request parameters
      formatted_topic = Google::Cloud::Pubsublite::V1::TopicStatsServiceClient.topic_path("[PROJECT]", "[LOCATION]", "[TOPIC]")
      partition = 0

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Pubsublite::V1::ComputeHeadCursorResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::ComputeHeadCursorRequest, request)
        assert_equal(formatted_topic, request.topic)
        assert_equal(partition, request.partition)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:compute_head_cursor, mock_method)

      # Mock auth layer
      mock_credentials = MockTopicStatsServiceCredentials_v1.new("compute_head_cursor")

      Google::Cloud::Pubsublite::V1::TopicStatsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::TopicStats.new(version: :v1)

          # Call method
          response = client.compute_head_cursor(formatted_topic, partition)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.compute_head_cursor(formatted_topic, partition) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes compute_head_cursor with error' do
      # Create request parameters
      formatted_topic = Google::Cloud::Pubsublite::V1::TopicStatsServiceClient.topic_path("[PROJECT]", "[LOCATION]", "[TOPIC]")
      partition = 0

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::ComputeHeadCursorRequest, request)
        assert_equal(formatted_topic, request.topic)
        assert_equal(partition, request.partition)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:compute_head_cursor, mock_method)

      # Mock auth layer
      mock_credentials = MockTopicStatsServiceCredentials_v1.new("compute_head_cursor")

      Google::Cloud::Pubsublite::V1::TopicStatsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::TopicStats.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.compute_head_cursor(formatted_topic, partition)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end