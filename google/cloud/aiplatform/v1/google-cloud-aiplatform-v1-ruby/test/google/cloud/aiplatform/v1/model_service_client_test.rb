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
require "google/cloud/aiplatform/v1/model_service_client"
require "google/cloud/aiplatform/v1/model_service_services_pb"
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

class MockModelServiceCredentials_v1 < Google::Cloud::Aiplatform::V1::Credentials
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

describe Google::Cloud::Aiplatform::V1::ModelServiceClient do

  describe 'upload_model' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::ModelServiceClient#upload_model."

    it 'invokes upload_model without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::ModelServiceClient.location_path("[PROJECT]", "[LOCATION]")
      model = {}

      # Create expected grpc response
      model_2 = "model21226956956"
      expected_response = { model: model_2 }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::UploadModelResponse)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/upload_model_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::UploadModelRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(model, Google::Cloud::Aiplatform::V1::Model), request.model)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:upload_model, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v1.new("upload_model")

      Google::Cloud::Aiplatform::V1::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Model.new(version: :v1)

          # Call method
          response = client.upload_model(formatted_parent, model)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes upload_model and returns an operation error.' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::ModelServiceClient.location_path("[PROJECT]", "[LOCATION]")
      model = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Aiplatform::V1::ModelServiceClient#upload_model.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/upload_model_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::UploadModelRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(model, Google::Cloud::Aiplatform::V1::Model), request.model)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:upload_model, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v1.new("upload_model")

      Google::Cloud::Aiplatform::V1::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Model.new(version: :v1)

          # Call method
          response = client.upload_model(formatted_parent, model)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes upload_model with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::ModelServiceClient.location_path("[PROJECT]", "[LOCATION]")
      model = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::UploadModelRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(model, Google::Cloud::Aiplatform::V1::Model), request.model)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:upload_model, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v1.new("upload_model")

      Google::Cloud::Aiplatform::V1::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Model.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.upload_model(formatted_parent, model)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_model' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::ModelServiceClient#get_model."

    it 'invokes get_model without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::ModelServiceClient.model_path("[PROJECT]", "[LOCATION]", "[MODEL]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      metadata_schema_uri = "metadataSchemaUri-152319778"
      training_pipeline = "trainingPipeline-2026166169"
      artifact_uri = "artifactUri-671891073"
      etag = "etag3123477"
      expected_response = {
        name: name_2,
        display_name: display_name,
        description: description,
        metadata_schema_uri: metadata_schema_uri,
        training_pipeline: training_pipeline,
        artifact_uri: artifact_uri,
        etag: etag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::Model)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::GetModelRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_model, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v1.new("get_model")

      Google::Cloud::Aiplatform::V1::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Model.new(version: :v1)

          # Call method
          response = client.get_model(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_model(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_model with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::ModelServiceClient.model_path("[PROJECT]", "[LOCATION]", "[MODEL]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::GetModelRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_model, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v1.new("get_model")

      Google::Cloud::Aiplatform::V1::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Model.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_model(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_models' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::ModelServiceClient#list_models."

    it 'invokes list_models without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::ModelServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      models_element = {}
      models = [models_element]
      expected_response = { next_page_token: next_page_token, models: models }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::ListModelsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::ListModelsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_models, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v1.new("list_models")

      Google::Cloud::Aiplatform::V1::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Model.new(version: :v1)

          # Call method
          response = client.list_models(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.models.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_models with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::ModelServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::ListModelsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_models, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v1.new("list_models")

      Google::Cloud::Aiplatform::V1::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Model.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_models(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_model' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::ModelServiceClient#update_model."

    it 'invokes update_model without error' do
      # Create request parameters
      model = {}
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      metadata_schema_uri = "metadataSchemaUri-152319778"
      training_pipeline = "trainingPipeline-2026166169"
      artifact_uri = "artifactUri-671891073"
      etag = "etag3123477"
      expected_response = {
        name: name,
        display_name: display_name,
        description: description,
        metadata_schema_uri: metadata_schema_uri,
        training_pipeline: training_pipeline,
        artifact_uri: artifact_uri,
        etag: etag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::Model)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::UpdateModelRequest, request)
        assert_equal(Google::Gax::to_proto(model, Google::Cloud::Aiplatform::V1::Model), request.model)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_model, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v1.new("update_model")

      Google::Cloud::Aiplatform::V1::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Model.new(version: :v1)

          # Call method
          response = client.update_model(model, update_mask)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_model(model, update_mask) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_model with error' do
      # Create request parameters
      model = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::UpdateModelRequest, request)
        assert_equal(Google::Gax::to_proto(model, Google::Cloud::Aiplatform::V1::Model), request.model)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_model, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v1.new("update_model")

      Google::Cloud::Aiplatform::V1::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Model.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.update_model(model, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_model' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::ModelServiceClient#delete_model."

    it 'invokes delete_model without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::ModelServiceClient.model_path("[PROJECT]", "[LOCATION]", "[MODEL]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Protobuf::Empty)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_model_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::DeleteModelRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_model, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v1.new("delete_model")

      Google::Cloud::Aiplatform::V1::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Model.new(version: :v1)

          # Call method
          response = client.delete_model(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes delete_model and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::ModelServiceClient.model_path("[PROJECT]", "[LOCATION]", "[MODEL]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Aiplatform::V1::ModelServiceClient#delete_model.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_model_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::DeleteModelRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_model, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v1.new("delete_model")

      Google::Cloud::Aiplatform::V1::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Model.new(version: :v1)

          # Call method
          response = client.delete_model(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes delete_model with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::ModelServiceClient.model_path("[PROJECT]", "[LOCATION]", "[MODEL]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::DeleteModelRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_model, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v1.new("delete_model")

      Google::Cloud::Aiplatform::V1::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Model.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_model(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'export_model' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::ModelServiceClient#export_model."

    it 'invokes export_model without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::ModelServiceClient.model_path("[PROJECT]", "[LOCATION]", "[MODEL]")
      output_config = {}

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::ExportModelResponse)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/export_model_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::ExportModelRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(Google::Gax::to_proto(output_config, Google::Cloud::Aiplatform::V1::ExportModelRequest::OutputConfig), request.output_config)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:export_model, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v1.new("export_model")

      Google::Cloud::Aiplatform::V1::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Model.new(version: :v1)

          # Call method
          response = client.export_model(formatted_name, output_config)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes export_model and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::ModelServiceClient.model_path("[PROJECT]", "[LOCATION]", "[MODEL]")
      output_config = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Aiplatform::V1::ModelServiceClient#export_model.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/export_model_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::ExportModelRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(Google::Gax::to_proto(output_config, Google::Cloud::Aiplatform::V1::ExportModelRequest::OutputConfig), request.output_config)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:export_model, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v1.new("export_model")

      Google::Cloud::Aiplatform::V1::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Model.new(version: :v1)

          # Call method
          response = client.export_model(formatted_name, output_config)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes export_model with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::ModelServiceClient.model_path("[PROJECT]", "[LOCATION]", "[MODEL]")
      output_config = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::ExportModelRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(Google::Gax::to_proto(output_config, Google::Cloud::Aiplatform::V1::ExportModelRequest::OutputConfig), request.output_config)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:export_model, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v1.new("export_model")

      Google::Cloud::Aiplatform::V1::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Model.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.export_model(formatted_name, output_config)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_model_evaluation' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::ModelServiceClient#get_model_evaluation."

    it 'invokes get_model_evaluation without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::ModelServiceClient.model_evaluation_path("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      metrics_schema_uri = "metricsSchemaUri981925578"
      expected_response = { name: name_2, metrics_schema_uri: metrics_schema_uri }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::ModelEvaluation)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::GetModelEvaluationRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_model_evaluation, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v1.new("get_model_evaluation")

      Google::Cloud::Aiplatform::V1::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Model.new(version: :v1)

          # Call method
          response = client.get_model_evaluation(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_model_evaluation(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_model_evaluation with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::ModelServiceClient.model_evaluation_path("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::GetModelEvaluationRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_model_evaluation, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v1.new("get_model_evaluation")

      Google::Cloud::Aiplatform::V1::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Model.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_model_evaluation(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_model_evaluations' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::ModelServiceClient#list_model_evaluations."

    it 'invokes list_model_evaluations without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::ModelServiceClient.model_path("[PROJECT]", "[LOCATION]", "[MODEL]")

      # Create expected grpc response
      next_page_token = ""
      model_evaluations_element = {}
      model_evaluations = [model_evaluations_element]
      expected_response = { next_page_token: next_page_token, model_evaluations: model_evaluations }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::ListModelEvaluationsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::ListModelEvaluationsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_model_evaluations, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v1.new("list_model_evaluations")

      Google::Cloud::Aiplatform::V1::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Model.new(version: :v1)

          # Call method
          response = client.list_model_evaluations(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.model_evaluations.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_model_evaluations with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::ModelServiceClient.model_path("[PROJECT]", "[LOCATION]", "[MODEL]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::ListModelEvaluationsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_model_evaluations, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v1.new("list_model_evaluations")

      Google::Cloud::Aiplatform::V1::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Model.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_model_evaluations(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_model_evaluation_slice' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::ModelServiceClient#get_model_evaluation_slice."

    it 'invokes get_model_evaluation_slice without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::ModelServiceClient.model_evaluation_slice_path("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]", "[SLICE]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      metrics_schema_uri = "metricsSchemaUri981925578"
      expected_response = { name: name_2, metrics_schema_uri: metrics_schema_uri }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::ModelEvaluationSlice)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::GetModelEvaluationSliceRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_model_evaluation_slice, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v1.new("get_model_evaluation_slice")

      Google::Cloud::Aiplatform::V1::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Model.new(version: :v1)

          # Call method
          response = client.get_model_evaluation_slice(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_model_evaluation_slice(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_model_evaluation_slice with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::ModelServiceClient.model_evaluation_slice_path("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]", "[SLICE]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::GetModelEvaluationSliceRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_model_evaluation_slice, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v1.new("get_model_evaluation_slice")

      Google::Cloud::Aiplatform::V1::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Model.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_model_evaluation_slice(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_model_evaluation_slices' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::ModelServiceClient#list_model_evaluation_slices."

    it 'invokes list_model_evaluation_slices without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::ModelServiceClient.model_evaluation_path("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]")

      # Create expected grpc response
      next_page_token = ""
      model_evaluation_slices_element = {}
      model_evaluation_slices = [model_evaluation_slices_element]
      expected_response = { next_page_token: next_page_token, model_evaluation_slices: model_evaluation_slices }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::ListModelEvaluationSlicesResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::ListModelEvaluationSlicesRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_model_evaluation_slices, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v1.new("list_model_evaluation_slices")

      Google::Cloud::Aiplatform::V1::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Model.new(version: :v1)

          # Call method
          response = client.list_model_evaluation_slices(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.model_evaluation_slices.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_model_evaluation_slices with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::ModelServiceClient.model_evaluation_path("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::ListModelEvaluationSlicesRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_model_evaluation_slices, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v1.new("list_model_evaluation_slices")

      Google::Cloud::Aiplatform::V1::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Model.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_model_evaluation_slices(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end