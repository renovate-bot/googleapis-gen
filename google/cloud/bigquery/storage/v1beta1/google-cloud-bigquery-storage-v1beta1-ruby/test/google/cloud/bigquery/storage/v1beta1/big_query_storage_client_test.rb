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

require "google/cloud/bigquery/storage"
require "google/cloud/bigquery/storage/v1beta1/big_query_storage_client"
require "google/cloud/bigquery/storage/v1beta1/storage_services_pb"

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

class MockBigQueryStorageCredentials_v1beta1 < Google::Cloud::Bigquery::Storage::V1beta1::Credentials
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

describe Google::Cloud::Bigquery::Storage::V1beta1::BigQueryStorageClient do

  describe 'create_read_session' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Storage::V1beta1::BigQueryStorageClient#create_read_session."

    it 'invokes create_read_session without error' do
      # Create request parameters
      table_reference = {}
      formatted_parent = Google::Cloud::Bigquery::Storage::V1beta1::BigQueryStorageClient.project_path("[PROJECT]")

      # Create expected grpc response
      name = "name3373707"
      expected_response = { name: name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Storage::V1beta1::ReadSession)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Storage::V1beta1::CreateReadSessionRequest, request)
        assert_equal(Google::Gax::to_proto(table_reference, Google::Cloud::Bigquery::Storage::V1beta1::TableReference), request.table_reference)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_read_session, mock_method)

      # Mock auth layer
      mock_credentials = MockBigQueryStorageCredentials_v1beta1.new("create_read_session")

      Google::Cloud::Bigquery::Storage::V1beta1::BigQueryStorage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Storage::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Storage.new(version: :v1beta1)

          # Call method
          response = client.create_read_session(table_reference, formatted_parent)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_read_session(table_reference, formatted_parent) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_read_session with error' do
      # Create request parameters
      table_reference = {}
      formatted_parent = Google::Cloud::Bigquery::Storage::V1beta1::BigQueryStorageClient.project_path("[PROJECT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Storage::V1beta1::CreateReadSessionRequest, request)
        assert_equal(Google::Gax::to_proto(table_reference, Google::Cloud::Bigquery::Storage::V1beta1::TableReference), request.table_reference)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_read_session, mock_method)

      # Mock auth layer
      mock_credentials = MockBigQueryStorageCredentials_v1beta1.new("create_read_session")

      Google::Cloud::Bigquery::Storage::V1beta1::BigQueryStorage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Storage::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Storage.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.create_read_session(table_reference, formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'read_rows' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Storage::V1beta1::BigQueryStorageClient#read_rows."

    it 'invokes read_rows without error' do
      # Create request parameters
      read_position = {}

      # Create expected grpc response
      row_count = 1340416618
      expected_response = { row_count: row_count }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Storage::V1beta1::ReadRowsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Storage::V1beta1::ReadRowsRequest, request)
        assert_equal(Google::Gax::to_proto(read_position, Google::Cloud::Bigquery::Storage::V1beta1::StreamPosition), request.read_position)
        OpenStruct.new(execute: [expected_response])
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:read_rows, mock_method)

      # Mock auth layer
      mock_credentials = MockBigQueryStorageCredentials_v1beta1.new("read_rows")

      Google::Cloud::Bigquery::Storage::V1beta1::BigQueryStorage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Storage::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Storage.new(version: :v1beta1)

          # Call method
          response = client.read_rows(read_position)

          # Verify the response
          assert_equal(1, response.count)
          assert_equal(expected_response, response.first)
        end
      end
    end

    it 'invokes read_rows with error' do
      # Create request parameters
      read_position = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Storage::V1beta1::ReadRowsRequest, request)
        assert_equal(Google::Gax::to_proto(read_position, Google::Cloud::Bigquery::Storage::V1beta1::StreamPosition), request.read_position)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:read_rows, mock_method)

      # Mock auth layer
      mock_credentials = MockBigQueryStorageCredentials_v1beta1.new("read_rows")

      Google::Cloud::Bigquery::Storage::V1beta1::BigQueryStorage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Storage::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Storage.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.read_rows(read_position)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'batch_create_read_session_streams' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Storage::V1beta1::BigQueryStorageClient#batch_create_read_session_streams."

    it 'invokes batch_create_read_session_streams without error' do
      # Create request parameters
      session = {}
      requested_streams = 0

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Storage::V1beta1::BatchCreateReadSessionStreamsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Storage::V1beta1::BatchCreateReadSessionStreamsRequest, request)
        assert_equal(Google::Gax::to_proto(session, Google::Cloud::Bigquery::Storage::V1beta1::ReadSession), request.session)
        assert_equal(requested_streams, request.requested_streams)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:batch_create_read_session_streams, mock_method)

      # Mock auth layer
      mock_credentials = MockBigQueryStorageCredentials_v1beta1.new("batch_create_read_session_streams")

      Google::Cloud::Bigquery::Storage::V1beta1::BigQueryStorage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Storage::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Storage.new(version: :v1beta1)

          # Call method
          response = client.batch_create_read_session_streams(session, requested_streams)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.batch_create_read_session_streams(session, requested_streams) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes batch_create_read_session_streams with error' do
      # Create request parameters
      session = {}
      requested_streams = 0

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Storage::V1beta1::BatchCreateReadSessionStreamsRequest, request)
        assert_equal(Google::Gax::to_proto(session, Google::Cloud::Bigquery::Storage::V1beta1::ReadSession), request.session)
        assert_equal(requested_streams, request.requested_streams)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:batch_create_read_session_streams, mock_method)

      # Mock auth layer
      mock_credentials = MockBigQueryStorageCredentials_v1beta1.new("batch_create_read_session_streams")

      Google::Cloud::Bigquery::Storage::V1beta1::BigQueryStorage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Storage::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Storage.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.batch_create_read_session_streams(session, requested_streams)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'finalize_stream' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Storage::V1beta1::BigQueryStorageClient#finalize_stream."

    it 'invokes finalize_stream without error' do
      # Create request parameters
      stream = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Storage::V1beta1::FinalizeStreamRequest, request)
        assert_equal(Google::Gax::to_proto(stream, Google::Cloud::Bigquery::Storage::V1beta1::Stream), request.stream)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:finalize_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockBigQueryStorageCredentials_v1beta1.new("finalize_stream")

      Google::Cloud::Bigquery::Storage::V1beta1::BigQueryStorage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Storage::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Storage.new(version: :v1beta1)

          # Call method
          response = client.finalize_stream(stream)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.finalize_stream(stream) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes finalize_stream with error' do
      # Create request parameters
      stream = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Storage::V1beta1::FinalizeStreamRequest, request)
        assert_equal(Google::Gax::to_proto(stream, Google::Cloud::Bigquery::Storage::V1beta1::Stream), request.stream)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:finalize_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockBigQueryStorageCredentials_v1beta1.new("finalize_stream")

      Google::Cloud::Bigquery::Storage::V1beta1::BigQueryStorage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Storage::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Storage.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.finalize_stream(stream)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'split_read_stream' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Storage::V1beta1::BigQueryStorageClient#split_read_stream."

    it 'invokes split_read_stream without error' do
      # Create request parameters
      original_stream = {}

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Storage::V1beta1::SplitReadStreamResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Storage::V1beta1::SplitReadStreamRequest, request)
        assert_equal(Google::Gax::to_proto(original_stream, Google::Cloud::Bigquery::Storage::V1beta1::Stream), request.original_stream)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:split_read_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockBigQueryStorageCredentials_v1beta1.new("split_read_stream")

      Google::Cloud::Bigquery::Storage::V1beta1::BigQueryStorage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Storage::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Storage.new(version: :v1beta1)

          # Call method
          response = client.split_read_stream(original_stream)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.split_read_stream(original_stream) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes split_read_stream with error' do
      # Create request parameters
      original_stream = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Storage::V1beta1::SplitReadStreamRequest, request)
        assert_equal(Google::Gax::to_proto(original_stream, Google::Cloud::Bigquery::Storage::V1beta1::Stream), request.original_stream)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:split_read_stream, mock_method)

      # Mock auth layer
      mock_credentials = MockBigQueryStorageCredentials_v1beta1.new("split_read_stream")

      Google::Cloud::Bigquery::Storage::V1beta1::BigQueryStorage::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Storage::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Storage.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.split_read_stream(original_stream)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end