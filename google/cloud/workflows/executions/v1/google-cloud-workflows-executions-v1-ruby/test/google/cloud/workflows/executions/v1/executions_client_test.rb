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

require "google/cloud/workflows/executions"
require "google/cloud/workflows/executions/v1/executions_client"
require "google/cloud/workflows/executions/v1/executions_services_pb"

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

class MockExecutionsCredentials_v1 < Google::Cloud::Workflows::Executions::V1::Credentials
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

describe Google::Cloud::Workflows::Executions::V1::ExecutionsClient do

  describe 'list_executions' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Workflows::Executions::V1::ExecutionsClient#list_executions."

    it 'invokes list_executions without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Workflows::Executions::V1::ExecutionsClient.workflow_path("[PROJECT]", "[LOCATION]", "[WORKFLOW]")

      # Create expected grpc response
      next_page_token = ""
      executions_element = {}
      executions = [executions_element]
      expected_response = { next_page_token: next_page_token, executions: executions }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Workflows::Executions::V1::ListExecutionsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Workflows::Executions::V1::ListExecutionsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_executions, mock_method)

      # Mock auth layer
      mock_credentials = MockExecutionsCredentials_v1.new("list_executions")

      Google::Cloud::Workflows::Executions::V1::Executions::Stub.stub(:new, mock_stub) do
        Google::Cloud::Workflows::Executions::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Workflows::Executions.new(version: :v1)

          # Call method
          response = client.list_executions(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.executions.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_executions with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Workflows::Executions::V1::ExecutionsClient.workflow_path("[PROJECT]", "[LOCATION]", "[WORKFLOW]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Workflows::Executions::V1::ListExecutionsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_executions, mock_method)

      # Mock auth layer
      mock_credentials = MockExecutionsCredentials_v1.new("list_executions")

      Google::Cloud::Workflows::Executions::V1::Executions::Stub.stub(:new, mock_stub) do
        Google::Cloud::Workflows::Executions::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Workflows::Executions.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_executions(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_execution' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Workflows::Executions::V1::ExecutionsClient#create_execution."

    it 'invokes create_execution without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Workflows::Executions::V1::ExecutionsClient.workflow_path("[PROJECT]", "[LOCATION]", "[WORKFLOW]")
      execution = {}

      # Create expected grpc response
      name = "name3373707"
      argument = "argument-1589682499"
      result = "result-934426595"
      workflow_revision_id = "workflowRevisionId-1453295745"
      expected_response = {
        name: name,
        argument: argument,
        result: result,
        workflow_revision_id: workflow_revision_id
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Workflows::Executions::V1::Execution)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Workflows::Executions::V1::CreateExecutionRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(execution, Google::Cloud::Workflows::Executions::V1::Execution), request.execution)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_execution, mock_method)

      # Mock auth layer
      mock_credentials = MockExecutionsCredentials_v1.new("create_execution")

      Google::Cloud::Workflows::Executions::V1::Executions::Stub.stub(:new, mock_stub) do
        Google::Cloud::Workflows::Executions::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Workflows::Executions.new(version: :v1)

          # Call method
          response = client.create_execution(formatted_parent, execution)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_execution(formatted_parent, execution) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_execution with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Workflows::Executions::V1::ExecutionsClient.workflow_path("[PROJECT]", "[LOCATION]", "[WORKFLOW]")
      execution = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Workflows::Executions::V1::CreateExecutionRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(execution, Google::Cloud::Workflows::Executions::V1::Execution), request.execution)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_execution, mock_method)

      # Mock auth layer
      mock_credentials = MockExecutionsCredentials_v1.new("create_execution")

      Google::Cloud::Workflows::Executions::V1::Executions::Stub.stub(:new, mock_stub) do
        Google::Cloud::Workflows::Executions::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Workflows::Executions.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.create_execution(formatted_parent, execution)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_execution' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Workflows::Executions::V1::ExecutionsClient#get_execution."

    it 'invokes get_execution without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Workflows::Executions::V1::ExecutionsClient.execution_path("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      argument = "argument-1589682499"
      result = "result-934426595"
      workflow_revision_id = "workflowRevisionId-1453295745"
      expected_response = {
        name: name_2,
        argument: argument,
        result: result,
        workflow_revision_id: workflow_revision_id
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Workflows::Executions::V1::Execution)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Workflows::Executions::V1::GetExecutionRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_execution, mock_method)

      # Mock auth layer
      mock_credentials = MockExecutionsCredentials_v1.new("get_execution")

      Google::Cloud::Workflows::Executions::V1::Executions::Stub.stub(:new, mock_stub) do
        Google::Cloud::Workflows::Executions::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Workflows::Executions.new(version: :v1)

          # Call method
          response = client.get_execution(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_execution(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_execution with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Workflows::Executions::V1::ExecutionsClient.execution_path("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Workflows::Executions::V1::GetExecutionRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_execution, mock_method)

      # Mock auth layer
      mock_credentials = MockExecutionsCredentials_v1.new("get_execution")

      Google::Cloud::Workflows::Executions::V1::Executions::Stub.stub(:new, mock_stub) do
        Google::Cloud::Workflows::Executions::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Workflows::Executions.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_execution(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'cancel_execution' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Workflows::Executions::V1::ExecutionsClient#cancel_execution."

    it 'invokes cancel_execution without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Workflows::Executions::V1::ExecutionsClient.execution_path("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      argument = "argument-1589682499"
      result = "result-934426595"
      workflow_revision_id = "workflowRevisionId-1453295745"
      expected_response = {
        name: name_2,
        argument: argument,
        result: result,
        workflow_revision_id: workflow_revision_id
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Workflows::Executions::V1::Execution)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Workflows::Executions::V1::CancelExecutionRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:cancel_execution, mock_method)

      # Mock auth layer
      mock_credentials = MockExecutionsCredentials_v1.new("cancel_execution")

      Google::Cloud::Workflows::Executions::V1::Executions::Stub.stub(:new, mock_stub) do
        Google::Cloud::Workflows::Executions::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Workflows::Executions.new(version: :v1)

          # Call method
          response = client.cancel_execution(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.cancel_execution(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes cancel_execution with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Workflows::Executions::V1::ExecutionsClient.execution_path("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Workflows::Executions::V1::CancelExecutionRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:cancel_execution, mock_method)

      # Mock auth layer
      mock_credentials = MockExecutionsCredentials_v1.new("cancel_execution")

      Google::Cloud::Workflows::Executions::V1::Executions::Stub.stub(:new, mock_stub) do
        Google::Cloud::Workflows::Executions::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Workflows::Executions.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.cancel_execution(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end