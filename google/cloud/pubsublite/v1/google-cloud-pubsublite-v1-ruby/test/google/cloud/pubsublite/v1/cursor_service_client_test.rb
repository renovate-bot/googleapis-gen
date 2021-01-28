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
require "google/cloud/pubsublite/v1/cursor_service_client"
require "google/cloud/pubsublite/v1/cursor_services_pb"

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

class MockCursorServiceCredentials_v1 < Google::Cloud::Pubsublite::V1::Credentials
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

describe Google::Cloud::Pubsublite::V1::CursorServiceClient do

  describe 'streaming_commit_cursor' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Pubsublite::V1::CursorServiceClient#streaming_commit_cursor."

    it 'invokes streaming_commit_cursor without error' do
      # Create request parameters
      request = {}

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Pubsublite::V1::StreamingCommitCursorResponse)

      # Mock Grpc layer
      mock_method = proc do |requests|
        request = requests.first
        OpenStruct.new(execute: [expected_response])
      end
      mock_stub = MockGrpcClientStub_v1.new(:streaming_commit_cursor, mock_method)

      # Mock auth layer
      mock_credentials = MockCursorServiceCredentials_v1.new("streaming_commit_cursor")

      Google::Cloud::Pubsublite::V1::CursorService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Cursor.new(version: :v1)

          # Call method
          response = client.streaming_commit_cursor([request])

          # Verify the response
          assert_equal(1, response.count)
          assert_equal(expected_response, response.first)
        end
      end
    end

    it 'invokes streaming_commit_cursor with error' do
      # Create request parameters
      request = {}

      # Mock Grpc layer
      mock_method = proc do |requests|
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:streaming_commit_cursor, mock_method)

      # Mock auth layer
      mock_credentials = MockCursorServiceCredentials_v1.new("streaming_commit_cursor")

      Google::Cloud::Pubsublite::V1::CursorService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Cursor.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.streaming_commit_cursor([request])
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'commit_cursor' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Pubsublite::V1::CursorServiceClient#commit_cursor."

    it 'invokes commit_cursor without error' do
      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Pubsublite::V1::CommitCursorResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:commit_cursor, mock_method)

      # Mock auth layer
      mock_credentials = MockCursorServiceCredentials_v1.new("commit_cursor")

      Google::Cloud::Pubsublite::V1::CursorService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Cursor.new(version: :v1)

          # Call method
          response = client.commit_cursor

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.commit_cursor do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes commit_cursor with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:commit_cursor, mock_method)

      # Mock auth layer
      mock_credentials = MockCursorServiceCredentials_v1.new("commit_cursor")

      Google::Cloud::Pubsublite::V1::CursorService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Cursor.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.commit_cursor
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_partition_cursors' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Pubsublite::V1::CursorServiceClient#list_partition_cursors."

    it 'invokes list_partition_cursors without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Pubsublite::V1::CursorServiceClient.subscription_path("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]")

      # Create expected grpc response
      next_page_token = ""
      partition_cursors_element = {}
      partition_cursors = [partition_cursors_element]
      expected_response = { next_page_token: next_page_token, partition_cursors: partition_cursors }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Pubsublite::V1::ListPartitionCursorsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::ListPartitionCursorsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_partition_cursors, mock_method)

      # Mock auth layer
      mock_credentials = MockCursorServiceCredentials_v1.new("list_partition_cursors")

      Google::Cloud::Pubsublite::V1::CursorService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Cursor.new(version: :v1)

          # Call method
          response = client.list_partition_cursors(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.partition_cursors.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_partition_cursors with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Pubsublite::V1::CursorServiceClient.subscription_path("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Pubsublite::V1::ListPartitionCursorsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_partition_cursors, mock_method)

      # Mock auth layer
      mock_credentials = MockCursorServiceCredentials_v1.new("list_partition_cursors")

      Google::Cloud::Pubsublite::V1::CursorService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Pubsublite::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Pubsublite::Cursor.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_partition_cursors(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end