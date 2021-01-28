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

require "google/cloud/workflows"
require "google/cloud/workflows/v1/workflows_client"
require "google/cloud/workflows/v1/workflows_services_pb"
require "google/longrunning/operations_pb"

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

class MockWorkflowsCredentials_v1 < Google::Cloud::Workflows::V1::Credentials
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

describe Google::Cloud::Workflows::V1::WorkflowsClient do

  describe 'list_workflows' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Workflows::V1::WorkflowsClient#list_workflows."

    it 'invokes list_workflows without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Workflows::V1::WorkflowsClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      workflows_element = {}
      workflows = [workflows_element]
      expected_response = { next_page_token: next_page_token, workflows: workflows }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Workflows::V1::ListWorkflowsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Workflows::V1::ListWorkflowsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_workflows, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkflowsCredentials_v1.new("list_workflows")

      Google::Cloud::Workflows::V1::Workflows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Workflows::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Workflows.new(version: :v1)

          # Call method
          response = client.list_workflows(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.workflows.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_workflows with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Workflows::V1::WorkflowsClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Workflows::V1::ListWorkflowsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_workflows, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkflowsCredentials_v1.new("list_workflows")

      Google::Cloud::Workflows::V1::Workflows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Workflows::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Workflows.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_workflows(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_workflow' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Workflows::V1::WorkflowsClient#get_workflow."

    it 'invokes get_workflow without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Workflows::V1::WorkflowsClient.workflow_path("[PROJECT]", "[LOCATION]", "[WORKFLOW]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      description = "description-1724546052"
      revision_id = "revisionId513861631"
      service_account = "serviceAccount-1948028253"
      source_contents = "sourceContents-1799875906"
      expected_response = {
        name: name_2,
        description: description,
        revision_id: revision_id,
        service_account: service_account,
        source_contents: source_contents
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Workflows::V1::Workflow)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Workflows::V1::GetWorkflowRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_workflow, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkflowsCredentials_v1.new("get_workflow")

      Google::Cloud::Workflows::V1::Workflows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Workflows::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Workflows.new(version: :v1)

          # Call method
          response = client.get_workflow(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_workflow(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_workflow with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Workflows::V1::WorkflowsClient.workflow_path("[PROJECT]", "[LOCATION]", "[WORKFLOW]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Workflows::V1::GetWorkflowRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_workflow, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkflowsCredentials_v1.new("get_workflow")

      Google::Cloud::Workflows::V1::Workflows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Workflows::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Workflows.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_workflow(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_workflow' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Workflows::V1::WorkflowsClient#create_workflow."

    it 'invokes create_workflow without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Workflows::V1::WorkflowsClient.location_path("[PROJECT]", "[LOCATION]")
      workflow = {}
      workflow_id = ''

      # Create expected grpc response
      name = "name3373707"
      description = "description-1724546052"
      revision_id = "revisionId513861631"
      service_account = "serviceAccount-1948028253"
      source_contents = "sourceContents-1799875906"
      expected_response = {
        name: name,
        description: description,
        revision_id: revision_id,
        service_account: service_account,
        source_contents: source_contents
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Workflows::V1::Workflow)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_workflow_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Workflows::V1::CreateWorkflowRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(workflow, Google::Cloud::Workflows::V1::Workflow), request.workflow)
        assert_equal(workflow_id, request.workflow_id)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_workflow, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkflowsCredentials_v1.new("create_workflow")

      Google::Cloud::Workflows::V1::Workflows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Workflows::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Workflows.new(version: :v1)

          # Call method
          response = client.create_workflow(
            formatted_parent,
            workflow,
            workflow_id
          )

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes create_workflow and returns an operation error.' do
      # Create request parameters
      formatted_parent = Google::Cloud::Workflows::V1::WorkflowsClient.location_path("[PROJECT]", "[LOCATION]")
      workflow = {}
      workflow_id = ''

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Workflows::V1::WorkflowsClient#create_workflow.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_workflow_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Workflows::V1::CreateWorkflowRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(workflow, Google::Cloud::Workflows::V1::Workflow), request.workflow)
        assert_equal(workflow_id, request.workflow_id)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_workflow, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkflowsCredentials_v1.new("create_workflow")

      Google::Cloud::Workflows::V1::Workflows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Workflows::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Workflows.new(version: :v1)

          # Call method
          response = client.create_workflow(
            formatted_parent,
            workflow,
            workflow_id
          )

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes create_workflow with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Workflows::V1::WorkflowsClient.location_path("[PROJECT]", "[LOCATION]")
      workflow = {}
      workflow_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Workflows::V1::CreateWorkflowRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(workflow, Google::Cloud::Workflows::V1::Workflow), request.workflow)
        assert_equal(workflow_id, request.workflow_id)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_workflow, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkflowsCredentials_v1.new("create_workflow")

      Google::Cloud::Workflows::V1::Workflows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Workflows::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Workflows.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.create_workflow(
              formatted_parent,
              workflow,
              workflow_id
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_workflow' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Workflows::V1::WorkflowsClient#delete_workflow."

    it 'invokes delete_workflow without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Workflows::V1::WorkflowsClient.workflow_path("[PROJECT]", "[LOCATION]", "[WORKFLOW]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Protobuf::Empty)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_workflow_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Workflows::V1::DeleteWorkflowRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_workflow, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkflowsCredentials_v1.new("delete_workflow")

      Google::Cloud::Workflows::V1::Workflows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Workflows::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Workflows.new(version: :v1)

          # Call method
          response = client.delete_workflow(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes delete_workflow and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Workflows::V1::WorkflowsClient.workflow_path("[PROJECT]", "[LOCATION]", "[WORKFLOW]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Workflows::V1::WorkflowsClient#delete_workflow.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_workflow_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Workflows::V1::DeleteWorkflowRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_workflow, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkflowsCredentials_v1.new("delete_workflow")

      Google::Cloud::Workflows::V1::Workflows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Workflows::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Workflows.new(version: :v1)

          # Call method
          response = client.delete_workflow(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes delete_workflow with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Workflows::V1::WorkflowsClient.workflow_path("[PROJECT]", "[LOCATION]", "[WORKFLOW]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Workflows::V1::DeleteWorkflowRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_workflow, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkflowsCredentials_v1.new("delete_workflow")

      Google::Cloud::Workflows::V1::Workflows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Workflows::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Workflows.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_workflow(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_workflow' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Workflows::V1::WorkflowsClient#update_workflow."

    it 'invokes update_workflow without error' do
      # Create request parameters
      workflow = {}

      # Create expected grpc response
      name = "name3373707"
      description = "description-1724546052"
      revision_id = "revisionId513861631"
      service_account = "serviceAccount-1948028253"
      source_contents = "sourceContents-1799875906"
      expected_response = {
        name: name,
        description: description,
        revision_id: revision_id,
        service_account: service_account,
        source_contents: source_contents
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Workflows::V1::Workflow)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_workflow_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Workflows::V1::UpdateWorkflowRequest, request)
        assert_equal(Google::Gax::to_proto(workflow, Google::Cloud::Workflows::V1::Workflow), request.workflow)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_workflow, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkflowsCredentials_v1.new("update_workflow")

      Google::Cloud::Workflows::V1::Workflows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Workflows::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Workflows.new(version: :v1)

          # Call method
          response = client.update_workflow(workflow)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes update_workflow and returns an operation error.' do
      # Create request parameters
      workflow = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Workflows::V1::WorkflowsClient#update_workflow.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_workflow_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Workflows::V1::UpdateWorkflowRequest, request)
        assert_equal(Google::Gax::to_proto(workflow, Google::Cloud::Workflows::V1::Workflow), request.workflow)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_workflow, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkflowsCredentials_v1.new("update_workflow")

      Google::Cloud::Workflows::V1::Workflows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Workflows::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Workflows.new(version: :v1)

          # Call method
          response = client.update_workflow(workflow)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes update_workflow with error' do
      # Create request parameters
      workflow = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Workflows::V1::UpdateWorkflowRequest, request)
        assert_equal(Google::Gax::to_proto(workflow, Google::Cloud::Workflows::V1::Workflow), request.workflow)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_workflow, mock_method)

      # Mock auth layer
      mock_credentials = MockWorkflowsCredentials_v1.new("update_workflow")

      Google::Cloud::Workflows::V1::Workflows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Workflows::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Workflows.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.update_workflow(workflow)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end