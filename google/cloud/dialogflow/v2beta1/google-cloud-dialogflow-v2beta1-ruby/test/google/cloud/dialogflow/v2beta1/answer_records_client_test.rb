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
require "google/cloud/dialogflow/v2beta1/answer_records_client"
require "google/cloud/dialogflow/v2beta1/answer_record_services_pb"

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

class MockAnswerRecordsCredentials_v2beta1 < Google::Cloud::Dialogflow::V2beta1::Credentials
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

describe Google::Cloud::Dialogflow::V2beta1::AnswerRecordsClient do

  describe 'get_answer_record' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::AnswerRecordsClient#get_answer_record."

    it 'invokes get_answer_record without error' do
      # Create expected grpc response
      name = "name3373707"
      expected_response = { name: name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::AnswerRecord)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:get_answer_record, mock_method)

      # Mock auth layer
      mock_credentials = MockAnswerRecordsCredentials_v2beta1.new("get_answer_record")

      Google::Cloud::Dialogflow::V2beta1::AnswerRecords::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::AnswerRecords.new(version: :v2beta1)

          # Call method
          response = client.get_answer_record

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_answer_record do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_answer_record with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:get_answer_record, mock_method)

      # Mock auth layer
      mock_credentials = MockAnswerRecordsCredentials_v2beta1.new("get_answer_record")

      Google::Cloud::Dialogflow::V2beta1::AnswerRecords::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::AnswerRecords.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.get_answer_record
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_answer_records' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::AnswerRecordsClient#list_answer_records."

    it 'invokes list_answer_records without error' do
      # Create expected grpc response
      next_page_token = ""
      answer_records_element = {}
      answer_records = [answer_records_element]
      expected_response = { next_page_token: next_page_token, answer_records: answer_records }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::ListAnswerRecordsResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:list_answer_records, mock_method)

      # Mock auth layer
      mock_credentials = MockAnswerRecordsCredentials_v2beta1.new("list_answer_records")

      Google::Cloud::Dialogflow::V2beta1::AnswerRecords::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::AnswerRecords.new(version: :v2beta1)

          # Call method
          response = client.list_answer_records

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.answer_records.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_answer_records with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:list_answer_records, mock_method)

      # Mock auth layer
      mock_credentials = MockAnswerRecordsCredentials_v2beta1.new("list_answer_records")

      Google::Cloud::Dialogflow::V2beta1::AnswerRecords::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::AnswerRecords.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.list_answer_records
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_answer_record' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::AnswerRecordsClient#update_answer_record."

    it 'invokes update_answer_record without error' do
      # Create request parameters
      answer_record = {}

      # Create expected grpc response
      name = "name3373707"
      expected_response = { name: name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::AnswerRecord)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::UpdateAnswerRecordRequest, request)
        assert_equal(Google::Gax::to_proto(answer_record, Google::Cloud::Dialogflow::V2beta1::AnswerRecord), request.answer_record)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:update_answer_record, mock_method)

      # Mock auth layer
      mock_credentials = MockAnswerRecordsCredentials_v2beta1.new("update_answer_record")

      Google::Cloud::Dialogflow::V2beta1::AnswerRecords::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::AnswerRecords.new(version: :v2beta1)

          # Call method
          response = client.update_answer_record(answer_record)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_answer_record(answer_record) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_answer_record with error' do
      # Create request parameters
      answer_record = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::UpdateAnswerRecordRequest, request)
        assert_equal(Google::Gax::to_proto(answer_record, Google::Cloud::Dialogflow::V2beta1::AnswerRecord), request.answer_record)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:update_answer_record, mock_method)

      # Mock auth layer
      mock_credentials = MockAnswerRecordsCredentials_v2beta1.new("update_answer_record")

      Google::Cloud::Dialogflow::V2beta1::AnswerRecords::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::AnswerRecords.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.update_answer_record(answer_record)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end