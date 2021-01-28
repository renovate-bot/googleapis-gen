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

require "google/cloud/aiplatform"
require "google/cloud/aiplatform/v1/pipeline_service_client"
require "google/cloud/aiplatform/v1/pipeline_service_services_pb"
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

class MockPipelineServiceCredentials_v1 < Google::Cloud::Aiplatform::V1::Credentials
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

describe Google::Cloud::Aiplatform::V1::PipelineServiceClient do

  describe 'create_training_pipeline' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::PipelineServiceClient#create_training_pipeline."

    it 'invokes create_training_pipeline without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::PipelineServiceClient.location_path("[PROJECT]", "[LOCATION]")
      training_pipeline = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      training_task_definition = "trainingTaskDefinition-1916695832"
      expected_response = {
        name: name,
        display_name: display_name,
        training_task_definition: training_task_definition
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::TrainingPipeline)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::CreateTrainingPipelineRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(training_pipeline, Google::Cloud::Aiplatform::V1::TrainingPipeline), request.training_pipeline)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_training_pipeline, mock_method)

      # Mock auth layer
      mock_credentials = MockPipelineServiceCredentials_v1.new("create_training_pipeline")

      Google::Cloud::Aiplatform::V1::PipelineService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Pipeline.new(version: :v1)

          # Call method
          response = client.create_training_pipeline(formatted_parent, training_pipeline)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_training_pipeline(formatted_parent, training_pipeline) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_training_pipeline with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::PipelineServiceClient.location_path("[PROJECT]", "[LOCATION]")
      training_pipeline = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::CreateTrainingPipelineRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(training_pipeline, Google::Cloud::Aiplatform::V1::TrainingPipeline), request.training_pipeline)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_training_pipeline, mock_method)

      # Mock auth layer
      mock_credentials = MockPipelineServiceCredentials_v1.new("create_training_pipeline")

      Google::Cloud::Aiplatform::V1::PipelineService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Pipeline.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.create_training_pipeline(formatted_parent, training_pipeline)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_training_pipeline' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::PipelineServiceClient#get_training_pipeline."

    it 'invokes get_training_pipeline without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::PipelineServiceClient.training_pipeline_path("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      training_task_definition = "trainingTaskDefinition-1916695832"
      expected_response = {
        name: name_2,
        display_name: display_name,
        training_task_definition: training_task_definition
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::TrainingPipeline)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::GetTrainingPipelineRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_training_pipeline, mock_method)

      # Mock auth layer
      mock_credentials = MockPipelineServiceCredentials_v1.new("get_training_pipeline")

      Google::Cloud::Aiplatform::V1::PipelineService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Pipeline.new(version: :v1)

          # Call method
          response = client.get_training_pipeline(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_training_pipeline(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_training_pipeline with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::PipelineServiceClient.training_pipeline_path("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::GetTrainingPipelineRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_training_pipeline, mock_method)

      # Mock auth layer
      mock_credentials = MockPipelineServiceCredentials_v1.new("get_training_pipeline")

      Google::Cloud::Aiplatform::V1::PipelineService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Pipeline.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_training_pipeline(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_training_pipelines' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::PipelineServiceClient#list_training_pipelines."

    it 'invokes list_training_pipelines without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::PipelineServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      training_pipelines_element = {}
      training_pipelines = [training_pipelines_element]
      expected_response = { next_page_token: next_page_token, training_pipelines: training_pipelines }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::ListTrainingPipelinesResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::ListTrainingPipelinesRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_training_pipelines, mock_method)

      # Mock auth layer
      mock_credentials = MockPipelineServiceCredentials_v1.new("list_training_pipelines")

      Google::Cloud::Aiplatform::V1::PipelineService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Pipeline.new(version: :v1)

          # Call method
          response = client.list_training_pipelines(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.training_pipelines.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_training_pipelines with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::PipelineServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::ListTrainingPipelinesRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_training_pipelines, mock_method)

      # Mock auth layer
      mock_credentials = MockPipelineServiceCredentials_v1.new("list_training_pipelines")

      Google::Cloud::Aiplatform::V1::PipelineService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Pipeline.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_training_pipelines(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_training_pipeline' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::PipelineServiceClient#delete_training_pipeline."

    it 'invokes delete_training_pipeline without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::PipelineServiceClient.training_pipeline_path("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Protobuf::Empty)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_training_pipeline_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::DeleteTrainingPipelineRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_training_pipeline, mock_method)

      # Mock auth layer
      mock_credentials = MockPipelineServiceCredentials_v1.new("delete_training_pipeline")

      Google::Cloud::Aiplatform::V1::PipelineService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Pipeline.new(version: :v1)

          # Call method
          response = client.delete_training_pipeline(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes delete_training_pipeline and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::PipelineServiceClient.training_pipeline_path("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Aiplatform::V1::PipelineServiceClient#delete_training_pipeline.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_training_pipeline_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::DeleteTrainingPipelineRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_training_pipeline, mock_method)

      # Mock auth layer
      mock_credentials = MockPipelineServiceCredentials_v1.new("delete_training_pipeline")

      Google::Cloud::Aiplatform::V1::PipelineService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Pipeline.new(version: :v1)

          # Call method
          response = client.delete_training_pipeline(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes delete_training_pipeline with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::PipelineServiceClient.training_pipeline_path("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::DeleteTrainingPipelineRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_training_pipeline, mock_method)

      # Mock auth layer
      mock_credentials = MockPipelineServiceCredentials_v1.new("delete_training_pipeline")

      Google::Cloud::Aiplatform::V1::PipelineService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Pipeline.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_training_pipeline(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'cancel_training_pipeline' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::PipelineServiceClient#cancel_training_pipeline."

    it 'invokes cancel_training_pipeline without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::PipelineServiceClient.training_pipeline_path("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::CancelTrainingPipelineRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:cancel_training_pipeline, mock_method)

      # Mock auth layer
      mock_credentials = MockPipelineServiceCredentials_v1.new("cancel_training_pipeline")

      Google::Cloud::Aiplatform::V1::PipelineService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Pipeline.new(version: :v1)

          # Call method
          response = client.cancel_training_pipeline(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.cancel_training_pipeline(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes cancel_training_pipeline with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::PipelineServiceClient.training_pipeline_path("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::CancelTrainingPipelineRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:cancel_training_pipeline, mock_method)

      # Mock auth layer
      mock_credentials = MockPipelineServiceCredentials_v1.new("cancel_training_pipeline")

      Google::Cloud::Aiplatform::V1::PipelineService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Pipeline.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.cancel_training_pipeline(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end