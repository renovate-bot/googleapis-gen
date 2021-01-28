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
require "google/cloud/dialogflow/cx/v3/flows_client"
require "google/cloud/dialogflow/cx/v3/flow_services_pb"
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

class MockFlowsCredentials_v3 < Google::Cloud::Dialogflow::Cx::V3::Credentials
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

describe Google::Cloud::Dialogflow::Cx::V3::FlowsClient do

  describe 'create_flow' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::FlowsClient#create_flow."

    it 'invokes create_flow without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::FlowsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
      flow = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      expected_response = {
        name: name,
        display_name: display_name,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3::Flow)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::CreateFlowRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(flow, Google::Cloud::Dialogflow::Cx::V3::Flow), request.flow)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3.new(:create_flow, mock_method)

      # Mock auth layer
      mock_credentials = MockFlowsCredentials_v3.new("create_flow")

      Google::Cloud::Dialogflow::Cx::V3::Flows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Flows.new(version: :v3)

          # Call method
          response = client.create_flow(formatted_parent, flow)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_flow(formatted_parent, flow) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_flow with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::FlowsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
      flow = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::CreateFlowRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(flow, Google::Cloud::Dialogflow::Cx::V3::Flow), request.flow)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:create_flow, mock_method)

      # Mock auth layer
      mock_credentials = MockFlowsCredentials_v3.new("create_flow")

      Google::Cloud::Dialogflow::Cx::V3::Flows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Flows.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.create_flow(formatted_parent, flow)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_flow' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::FlowsClient#delete_flow."

    it 'invokes delete_flow without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::FlowsClient.flow_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::DeleteFlowRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v3.new(:delete_flow, mock_method)

      # Mock auth layer
      mock_credentials = MockFlowsCredentials_v3.new("delete_flow")

      Google::Cloud::Dialogflow::Cx::V3::Flows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Flows.new(version: :v3)

          # Call method
          response = client.delete_flow(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_flow(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_flow with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::FlowsClient.flow_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::DeleteFlowRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:delete_flow, mock_method)

      # Mock auth layer
      mock_credentials = MockFlowsCredentials_v3.new("delete_flow")

      Google::Cloud::Dialogflow::Cx::V3::Flows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Flows.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.delete_flow(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_flows' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::FlowsClient#list_flows."

    it 'invokes list_flows without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::FlowsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Create expected grpc response
      next_page_token = ""
      flows_element = {}
      flows = [flows_element]
      expected_response = { next_page_token: next_page_token, flows: flows }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3::ListFlowsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::ListFlowsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3.new(:list_flows, mock_method)

      # Mock auth layer
      mock_credentials = MockFlowsCredentials_v3.new("list_flows")

      Google::Cloud::Dialogflow::Cx::V3::Flows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Flows.new(version: :v3)

          # Call method
          response = client.list_flows(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.flows.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_flows with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::FlowsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::ListFlowsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:list_flows, mock_method)

      # Mock auth layer
      mock_credentials = MockFlowsCredentials_v3.new("list_flows")

      Google::Cloud::Dialogflow::Cx::V3::Flows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Flows.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.list_flows(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_flow' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::FlowsClient#get_flow."

    it 'invokes get_flow without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::FlowsClient.flow_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      expected_response = {
        name: name_2,
        display_name: display_name,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3::Flow)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::GetFlowRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3.new(:get_flow, mock_method)

      # Mock auth layer
      mock_credentials = MockFlowsCredentials_v3.new("get_flow")

      Google::Cloud::Dialogflow::Cx::V3::Flows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Flows.new(version: :v3)

          # Call method
          response = client.get_flow(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_flow(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_flow with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::FlowsClient.flow_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::GetFlowRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:get_flow, mock_method)

      # Mock auth layer
      mock_credentials = MockFlowsCredentials_v3.new("get_flow")

      Google::Cloud::Dialogflow::Cx::V3::Flows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Flows.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.get_flow(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_flow' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::FlowsClient#update_flow."

    it 'invokes update_flow without error' do
      # Create request parameters
      flow = {}
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      expected_response = {
        name: name,
        display_name: display_name,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3::Flow)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::UpdateFlowRequest, request)
        assert_equal(Google::Gax::to_proto(flow, Google::Cloud::Dialogflow::Cx::V3::Flow), request.flow)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3.new(:update_flow, mock_method)

      # Mock auth layer
      mock_credentials = MockFlowsCredentials_v3.new("update_flow")

      Google::Cloud::Dialogflow::Cx::V3::Flows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Flows.new(version: :v3)

          # Call method
          response = client.update_flow(flow, update_mask)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_flow(flow, update_mask) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_flow with error' do
      # Create request parameters
      flow = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::UpdateFlowRequest, request)
        assert_equal(Google::Gax::to_proto(flow, Google::Cloud::Dialogflow::Cx::V3::Flow), request.flow)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:update_flow, mock_method)

      # Mock auth layer
      mock_credentials = MockFlowsCredentials_v3.new("update_flow")

      Google::Cloud::Dialogflow::Cx::V3::Flows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Flows.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.update_flow(flow, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'train_flow' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::FlowsClient#train_flow."

    it 'invokes train_flow without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::FlowsClient.flow_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Protobuf::Empty)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/train_flow_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::TrainFlowRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v3.new(:train_flow, mock_method)

      # Mock auth layer
      mock_credentials = MockFlowsCredentials_v3.new("train_flow")

      Google::Cloud::Dialogflow::Cx::V3::Flows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Flows.new(version: :v3)

          # Call method
          response = client.train_flow(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes train_flow and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::FlowsClient.flow_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Dialogflow::Cx::V3::FlowsClient#train_flow.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/train_flow_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::TrainFlowRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v3.new(:train_flow, mock_method)

      # Mock auth layer
      mock_credentials = MockFlowsCredentials_v3.new("train_flow")

      Google::Cloud::Dialogflow::Cx::V3::Flows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Flows.new(version: :v3)

          # Call method
          response = client.train_flow(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes train_flow with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::FlowsClient.flow_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::TrainFlowRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:train_flow, mock_method)

      # Mock auth layer
      mock_credentials = MockFlowsCredentials_v3.new("train_flow")

      Google::Cloud::Dialogflow::Cx::V3::Flows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Flows.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.train_flow(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'validate_flow' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::FlowsClient#validate_flow."

    it 'invokes validate_flow without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::FlowsClient.flow_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      expected_response = { name: name_2 }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3::FlowValidationResult)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::ValidateFlowRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3.new(:validate_flow, mock_method)

      # Mock auth layer
      mock_credentials = MockFlowsCredentials_v3.new("validate_flow")

      Google::Cloud::Dialogflow::Cx::V3::Flows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Flows.new(version: :v3)

          # Call method
          response = client.validate_flow(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.validate_flow(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes validate_flow with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::FlowsClient.flow_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::ValidateFlowRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:validate_flow, mock_method)

      # Mock auth layer
      mock_credentials = MockFlowsCredentials_v3.new("validate_flow")

      Google::Cloud::Dialogflow::Cx::V3::Flows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Flows.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.validate_flow(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_flow_validation_result' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::FlowsClient#get_flow_validation_result."

    it 'invokes get_flow_validation_result without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::FlowsClient.flow_validation_result_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      expected_response = { name: name_2 }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3::FlowValidationResult)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::GetFlowValidationResultRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3.new(:get_flow_validation_result, mock_method)

      # Mock auth layer
      mock_credentials = MockFlowsCredentials_v3.new("get_flow_validation_result")

      Google::Cloud::Dialogflow::Cx::V3::Flows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Flows.new(version: :v3)

          # Call method
          response = client.get_flow_validation_result(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_flow_validation_result(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_flow_validation_result with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::FlowsClient.flow_validation_result_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::GetFlowValidationResultRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:get_flow_validation_result, mock_method)

      # Mock auth layer
      mock_credentials = MockFlowsCredentials_v3.new("get_flow_validation_result")

      Google::Cloud::Dialogflow::Cx::V3::Flows::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Flows.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.get_flow_validation_result(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end