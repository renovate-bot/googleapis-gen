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
require "google/cloud/dialogflow/cx/v3/test_cases_client"
require "google/cloud/dialogflow/cx/v3/test_case_services_pb"
require "google/longrunning/operations_pb"

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

class MockTestCasesCredentials_v3 < Google::Cloud::Dialogflow::Cx::V3::Credentials
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

describe Google::Cloud::Dialogflow::Cx::V3::TestCasesClient do

  describe 'list_test_cases' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::TestCasesClient#list_test_cases."

    it 'invokes list_test_cases without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Create expected grpc response
      next_page_token = ""
      test_cases_element = {}
      test_cases = [test_cases_element]
      expected_response = { next_page_token: next_page_token, test_cases: test_cases }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3::ListTestCasesResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::ListTestCasesRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3.new(:list_test_cases, mock_method)

      # Mock auth layer
      mock_credentials = MockTestCasesCredentials_v3.new("list_test_cases")

      Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)

          # Call method
          response = client.list_test_cases(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.test_cases.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_test_cases with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::ListTestCasesRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:list_test_cases, mock_method)

      # Mock auth layer
      mock_credentials = MockTestCasesCredentials_v3.new("list_test_cases")

      Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.list_test_cases(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'batch_delete_test_cases' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::TestCasesClient#batch_delete_test_cases."

    it 'invokes batch_delete_test_cases without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
      formatted_names = []

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::BatchDeleteTestCasesRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(formatted_names, request.names)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v3.new(:batch_delete_test_cases, mock_method)

      # Mock auth layer
      mock_credentials = MockTestCasesCredentials_v3.new("batch_delete_test_cases")

      Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)

          # Call method
          response = client.batch_delete_test_cases(formatted_parent, formatted_names)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.batch_delete_test_cases(formatted_parent, formatted_names) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes batch_delete_test_cases with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
      formatted_names = []

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::BatchDeleteTestCasesRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(formatted_names, request.names)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:batch_delete_test_cases, mock_method)

      # Mock auth layer
      mock_credentials = MockTestCasesCredentials_v3.new("batch_delete_test_cases")

      Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.batch_delete_test_cases(formatted_parent, formatted_names)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_test_case' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::TestCasesClient#get_test_case."

    it 'invokes get_test_case without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.test_case_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      notes = "notes105008833"
      expected_response = {
        name: name_2,
        display_name: display_name,
        notes: notes
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3::TestCase)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::GetTestCaseRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3.new(:get_test_case, mock_method)

      # Mock auth layer
      mock_credentials = MockTestCasesCredentials_v3.new("get_test_case")

      Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)

          # Call method
          response = client.get_test_case(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_test_case(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_test_case with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.test_case_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::GetTestCaseRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:get_test_case, mock_method)

      # Mock auth layer
      mock_credentials = MockTestCasesCredentials_v3.new("get_test_case")

      Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.get_test_case(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_test_case' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::TestCasesClient#create_test_case."

    it 'invokes create_test_case without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
      test_case = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      notes = "notes105008833"
      expected_response = {
        name: name,
        display_name: display_name,
        notes: notes
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3::TestCase)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::CreateTestCaseRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(test_case, Google::Cloud::Dialogflow::Cx::V3::TestCase), request.test_case)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3.new(:create_test_case, mock_method)

      # Mock auth layer
      mock_credentials = MockTestCasesCredentials_v3.new("create_test_case")

      Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)

          # Call method
          response = client.create_test_case(formatted_parent, test_case)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_test_case(formatted_parent, test_case) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_test_case with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
      test_case = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::CreateTestCaseRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(test_case, Google::Cloud::Dialogflow::Cx::V3::TestCase), request.test_case)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:create_test_case, mock_method)

      # Mock auth layer
      mock_credentials = MockTestCasesCredentials_v3.new("create_test_case")

      Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.create_test_case(formatted_parent, test_case)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_test_case' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::TestCasesClient#update_test_case."

    it 'invokes update_test_case without error' do
      # Create request parameters
      test_case = {}
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      notes = "notes105008833"
      expected_response = {
        name: name,
        display_name: display_name,
        notes: notes
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3::TestCase)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::UpdateTestCaseRequest, request)
        assert_equal(Google::Gax::to_proto(test_case, Google::Cloud::Dialogflow::Cx::V3::TestCase), request.test_case)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3.new(:update_test_case, mock_method)

      # Mock auth layer
      mock_credentials = MockTestCasesCredentials_v3.new("update_test_case")

      Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)

          # Call method
          response = client.update_test_case(test_case, update_mask)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_test_case(test_case, update_mask) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_test_case with error' do
      # Create request parameters
      test_case = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::UpdateTestCaseRequest, request)
        assert_equal(Google::Gax::to_proto(test_case, Google::Cloud::Dialogflow::Cx::V3::TestCase), request.test_case)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:update_test_case, mock_method)

      # Mock auth layer
      mock_credentials = MockTestCasesCredentials_v3.new("update_test_case")

      Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.update_test_case(test_case, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'run_test_case' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::TestCasesClient#run_test_case."

    it 'invokes run_test_case without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.test_case_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3::RunTestCaseResponse)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/run_test_case_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::RunTestCaseRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v3.new(:run_test_case, mock_method)

      # Mock auth layer
      mock_credentials = MockTestCasesCredentials_v3.new("run_test_case")

      Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)

          # Call method
          response = client.run_test_case(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes run_test_case and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.test_case_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Dialogflow::Cx::V3::TestCasesClient#run_test_case.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/run_test_case_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::RunTestCaseRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v3.new(:run_test_case, mock_method)

      # Mock auth layer
      mock_credentials = MockTestCasesCredentials_v3.new("run_test_case")

      Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)

          # Call method
          response = client.run_test_case(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes run_test_case with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.test_case_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::RunTestCaseRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:run_test_case, mock_method)

      # Mock auth layer
      mock_credentials = MockTestCasesCredentials_v3.new("run_test_case")

      Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.run_test_case(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'batch_run_test_cases' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::TestCasesClient#batch_run_test_cases."

    it 'invokes batch_run_test_cases without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
      formatted_test_cases = []

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3::BatchRunTestCasesResponse)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/batch_run_test_cases_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::BatchRunTestCasesRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(formatted_test_cases, request.test_cases)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v3.new(:batch_run_test_cases, mock_method)

      # Mock auth layer
      mock_credentials = MockTestCasesCredentials_v3.new("batch_run_test_cases")

      Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)

          # Call method
          response = client.batch_run_test_cases(formatted_parent, formatted_test_cases)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes batch_run_test_cases and returns an operation error.' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
      formatted_test_cases = []

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Dialogflow::Cx::V3::TestCasesClient#batch_run_test_cases.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/batch_run_test_cases_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::BatchRunTestCasesRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(formatted_test_cases, request.test_cases)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v3.new(:batch_run_test_cases, mock_method)

      # Mock auth layer
      mock_credentials = MockTestCasesCredentials_v3.new("batch_run_test_cases")

      Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)

          # Call method
          response = client.batch_run_test_cases(formatted_parent, formatted_test_cases)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes batch_run_test_cases with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
      formatted_test_cases = []

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::BatchRunTestCasesRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(formatted_test_cases, request.test_cases)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:batch_run_test_cases, mock_method)

      # Mock auth layer
      mock_credentials = MockTestCasesCredentials_v3.new("batch_run_test_cases")

      Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.batch_run_test_cases(formatted_parent, formatted_test_cases)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'calculate_coverage' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::TestCasesClient#calculate_coverage."

    it 'invokes calculate_coverage without error' do
      # Create request parameters
      formatted_agent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
      type = :COVERAGE_TYPE_UNSPECIFIED

      # Create expected grpc response
      agent_2 = "agent2-1060986504"
      expected_response = { agent: agent_2 }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3::CalculateCoverageResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::CalculateCoverageRequest, request)
        assert_equal(formatted_agent, request.agent)
        assert_equal(type, request.type)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3.new(:calculate_coverage, mock_method)

      # Mock auth layer
      mock_credentials = MockTestCasesCredentials_v3.new("calculate_coverage")

      Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)

          # Call method
          response = client.calculate_coverage(formatted_agent, type)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.calculate_coverage(formatted_agent, type) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes calculate_coverage with error' do
      # Create request parameters
      formatted_agent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
      type = :COVERAGE_TYPE_UNSPECIFIED

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::CalculateCoverageRequest, request)
        assert_equal(formatted_agent, request.agent)
        assert_equal(type, request.type)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:calculate_coverage, mock_method)

      # Mock auth layer
      mock_credentials = MockTestCasesCredentials_v3.new("calculate_coverage")

      Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.calculate_coverage(formatted_agent, type)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'import_test_cases' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::TestCasesClient#import_test_cases."

    it 'invokes import_test_cases without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3::ImportTestCasesResponse)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/import_test_cases_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::ImportTestCasesRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v3.new(:import_test_cases, mock_method)

      # Mock auth layer
      mock_credentials = MockTestCasesCredentials_v3.new("import_test_cases")

      Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)

          # Call method
          response = client.import_test_cases(formatted_parent)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes import_test_cases and returns an operation error.' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Dialogflow::Cx::V3::TestCasesClient#import_test_cases.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/import_test_cases_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::ImportTestCasesRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v3.new(:import_test_cases, mock_method)

      # Mock auth layer
      mock_credentials = MockTestCasesCredentials_v3.new("import_test_cases")

      Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)

          # Call method
          response = client.import_test_cases(formatted_parent)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes import_test_cases with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::ImportTestCasesRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:import_test_cases, mock_method)

      # Mock auth layer
      mock_credentials = MockTestCasesCredentials_v3.new("import_test_cases")

      Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.import_test_cases(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'export_test_cases' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::TestCasesClient#export_test_cases."

    it 'invokes export_test_cases without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Create expected grpc response
      gcs_uri = "gcsUri-132964284"
      expected_response = { gcs_uri: gcs_uri }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3::ExportTestCasesResponse)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/export_test_cases_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::ExportTestCasesRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v3.new(:export_test_cases, mock_method)

      # Mock auth layer
      mock_credentials = MockTestCasesCredentials_v3.new("export_test_cases")

      Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)

          # Call method
          response = client.export_test_cases(formatted_parent)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes export_test_cases and returns an operation error.' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Dialogflow::Cx::V3::TestCasesClient#export_test_cases.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/export_test_cases_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::ExportTestCasesRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v3.new(:export_test_cases, mock_method)

      # Mock auth layer
      mock_credentials = MockTestCasesCredentials_v3.new("export_test_cases")

      Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)

          # Call method
          response = client.export_test_cases(formatted_parent)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes export_test_cases with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::ExportTestCasesRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:export_test_cases, mock_method)

      # Mock auth layer
      mock_credentials = MockTestCasesCredentials_v3.new("export_test_cases")

      Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.export_test_cases(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_test_case_results' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::TestCasesClient#list_test_case_results."

    it 'invokes list_test_case_results without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.test_case_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]")

      # Create expected grpc response
      next_page_token = ""
      test_case_results_element = {}
      test_case_results = [test_case_results_element]
      expected_response = { next_page_token: next_page_token, test_case_results: test_case_results }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3::ListTestCaseResultsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::ListTestCaseResultsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3.new(:list_test_case_results, mock_method)

      # Mock auth layer
      mock_credentials = MockTestCasesCredentials_v3.new("list_test_case_results")

      Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)

          # Call method
          response = client.list_test_case_results(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.test_case_results.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_test_case_results with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.test_case_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::ListTestCaseResultsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:list_test_case_results, mock_method)

      # Mock auth layer
      mock_credentials = MockTestCasesCredentials_v3.new("list_test_case_results")

      Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.list_test_case_results(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end