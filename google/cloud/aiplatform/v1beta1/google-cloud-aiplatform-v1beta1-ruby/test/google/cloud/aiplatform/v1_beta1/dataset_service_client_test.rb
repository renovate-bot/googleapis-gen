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

require "google/cloud/aiplatform/v1_beta1"
require "google/cloud/aiplatform/v1_beta1/dataset_service_client"
require "google/cloud/aiplatform/v1beta1/dataset_service_services_pb"
require "google/longrunning/operations_pb"

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

class MockDatasetServiceCredentials_v1beta1 < Google::Cloud::Aiplatform::V1Beta1::Credentials
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

describe Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient do

  describe 'create_dataset' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient#create_dataset."

    it 'invokes create_dataset without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.location_path("[PROJECT]", "[LOCATION]")
      dataset = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      metadata_schema_uri = "metadataSchemaUri-152319778"
      etag = "etag3123477"
      expected_response = {
        name: name,
        display_name: display_name,
        metadata_schema_uri: metadata_schema_uri,
        etag: etag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::Dataset)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_dataset_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::CreateDatasetRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(dataset, Google::Cloud::Aiplatform::V1beta1::Dataset), request.dataset)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_dataset, mock_method)

      # Mock auth layer
      mock_credentials = MockDatasetServiceCredentials_v1beta1.new("create_dataset")

      Google::Cloud::Aiplatform::V1beta1::DatasetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)

          # Call method
          response = client.create_dataset(formatted_parent, dataset)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes create_dataset and returns an operation error.' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.location_path("[PROJECT]", "[LOCATION]")
      dataset = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient#create_dataset.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_dataset_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::CreateDatasetRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(dataset, Google::Cloud::Aiplatform::V1beta1::Dataset), request.dataset)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_dataset, mock_method)

      # Mock auth layer
      mock_credentials = MockDatasetServiceCredentials_v1beta1.new("create_dataset")

      Google::Cloud::Aiplatform::V1beta1::DatasetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)

          # Call method
          response = client.create_dataset(formatted_parent, dataset)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes create_dataset with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.location_path("[PROJECT]", "[LOCATION]")
      dataset = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::CreateDatasetRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(dataset, Google::Cloud::Aiplatform::V1beta1::Dataset), request.dataset)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_dataset, mock_method)

      # Mock auth layer
      mock_credentials = MockDatasetServiceCredentials_v1beta1.new("create_dataset")

      Google::Cloud::Aiplatform::V1beta1::DatasetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.create_dataset(formatted_parent, dataset)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_dataset' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient#get_dataset."

    it 'invokes get_dataset without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.dataset_path("[PROJECT]", "[LOCATION]", "[DATASET]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      metadata_schema_uri = "metadataSchemaUri-152319778"
      etag = "etag3123477"
      expected_response = {
        name: name_2,
        display_name: display_name,
        metadata_schema_uri: metadata_schema_uri,
        etag: etag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::Dataset)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::GetDatasetRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_dataset, mock_method)

      # Mock auth layer
      mock_credentials = MockDatasetServiceCredentials_v1beta1.new("get_dataset")

      Google::Cloud::Aiplatform::V1beta1::DatasetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)

          # Call method
          response = client.get_dataset(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_dataset(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_dataset with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.dataset_path("[PROJECT]", "[LOCATION]", "[DATASET]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::GetDatasetRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_dataset, mock_method)

      # Mock auth layer
      mock_credentials = MockDatasetServiceCredentials_v1beta1.new("get_dataset")

      Google::Cloud::Aiplatform::V1beta1::DatasetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.get_dataset(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_dataset' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient#update_dataset."

    it 'invokes update_dataset without error' do
      # Create request parameters
      dataset = {}
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      metadata_schema_uri = "metadataSchemaUri-152319778"
      etag = "etag3123477"
      expected_response = {
        name: name,
        display_name: display_name,
        metadata_schema_uri: metadata_schema_uri,
        etag: etag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::Dataset)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::UpdateDatasetRequest, request)
        assert_equal(Google::Gax::to_proto(dataset, Google::Cloud::Aiplatform::V1beta1::Dataset), request.dataset)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_dataset, mock_method)

      # Mock auth layer
      mock_credentials = MockDatasetServiceCredentials_v1beta1.new("update_dataset")

      Google::Cloud::Aiplatform::V1beta1::DatasetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)

          # Call method
          response = client.update_dataset(dataset, update_mask)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_dataset(dataset, update_mask) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_dataset with error' do
      # Create request parameters
      dataset = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::UpdateDatasetRequest, request)
        assert_equal(Google::Gax::to_proto(dataset, Google::Cloud::Aiplatform::V1beta1::Dataset), request.dataset)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_dataset, mock_method)

      # Mock auth layer
      mock_credentials = MockDatasetServiceCredentials_v1beta1.new("update_dataset")

      Google::Cloud::Aiplatform::V1beta1::DatasetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.update_dataset(dataset, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_datasets' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient#list_datasets."

    it 'invokes list_datasets without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      datasets_element = {}
      datasets = [datasets_element]
      expected_response = { next_page_token: next_page_token, datasets: datasets }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::ListDatasetsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::ListDatasetsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_datasets, mock_method)

      # Mock auth layer
      mock_credentials = MockDatasetServiceCredentials_v1beta1.new("list_datasets")

      Google::Cloud::Aiplatform::V1beta1::DatasetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)

          # Call method
          response = client.list_datasets(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.datasets.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_datasets with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::ListDatasetsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_datasets, mock_method)

      # Mock auth layer
      mock_credentials = MockDatasetServiceCredentials_v1beta1.new("list_datasets")

      Google::Cloud::Aiplatform::V1beta1::DatasetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.list_datasets(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_dataset' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient#delete_dataset."

    it 'invokes delete_dataset without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.dataset_path("[PROJECT]", "[LOCATION]", "[DATASET]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Protobuf::Empty)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_dataset_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::DeleteDatasetRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_dataset, mock_method)

      # Mock auth layer
      mock_credentials = MockDatasetServiceCredentials_v1beta1.new("delete_dataset")

      Google::Cloud::Aiplatform::V1beta1::DatasetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)

          # Call method
          response = client.delete_dataset(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes delete_dataset and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.dataset_path("[PROJECT]", "[LOCATION]", "[DATASET]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient#delete_dataset.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_dataset_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::DeleteDatasetRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_dataset, mock_method)

      # Mock auth layer
      mock_credentials = MockDatasetServiceCredentials_v1beta1.new("delete_dataset")

      Google::Cloud::Aiplatform::V1beta1::DatasetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)

          # Call method
          response = client.delete_dataset(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes delete_dataset with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.dataset_path("[PROJECT]", "[LOCATION]", "[DATASET]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::DeleteDatasetRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_dataset, mock_method)

      # Mock auth layer
      mock_credentials = MockDatasetServiceCredentials_v1beta1.new("delete_dataset")

      Google::Cloud::Aiplatform::V1beta1::DatasetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.delete_dataset(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'import_data' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient#import_data."

    it 'invokes import_data without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.dataset_path("[PROJECT]", "[LOCATION]", "[DATASET]")
      import_configs = []

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::ImportDataResponse)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/import_data_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::ImportDataRequest, request)
        assert_equal(formatted_name, request.name)
        import_configs = import_configs.map do |req|
          Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::ImportDataConfig)
        end
        assert_equal(import_configs, request.import_configs)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:import_data, mock_method)

      # Mock auth layer
      mock_credentials = MockDatasetServiceCredentials_v1beta1.new("import_data")

      Google::Cloud::Aiplatform::V1beta1::DatasetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)

          # Call method
          response = client.import_data(formatted_name, import_configs)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes import_data and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.dataset_path("[PROJECT]", "[LOCATION]", "[DATASET]")
      import_configs = []

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient#import_data.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/import_data_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::ImportDataRequest, request)
        assert_equal(formatted_name, request.name)
        import_configs = import_configs.map do |req|
          Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::ImportDataConfig)
        end
        assert_equal(import_configs, request.import_configs)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:import_data, mock_method)

      # Mock auth layer
      mock_credentials = MockDatasetServiceCredentials_v1beta1.new("import_data")

      Google::Cloud::Aiplatform::V1beta1::DatasetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)

          # Call method
          response = client.import_data(formatted_name, import_configs)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes import_data with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.dataset_path("[PROJECT]", "[LOCATION]", "[DATASET]")
      import_configs = []

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::ImportDataRequest, request)
        assert_equal(formatted_name, request.name)
        import_configs = import_configs.map do |req|
          Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::ImportDataConfig)
        end
        assert_equal(import_configs, request.import_configs)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:import_data, mock_method)

      # Mock auth layer
      mock_credentials = MockDatasetServiceCredentials_v1beta1.new("import_data")

      Google::Cloud::Aiplatform::V1beta1::DatasetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.import_data(formatted_name, import_configs)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'export_data' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient#export_data."

    it 'invokes export_data without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.dataset_path("[PROJECT]", "[LOCATION]", "[DATASET]")
      export_config = {}

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::ExportDataResponse)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/export_data_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::ExportDataRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(Google::Gax::to_proto(export_config, Google::Cloud::Aiplatform::V1beta1::ExportDataConfig), request.export_config)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:export_data, mock_method)

      # Mock auth layer
      mock_credentials = MockDatasetServiceCredentials_v1beta1.new("export_data")

      Google::Cloud::Aiplatform::V1beta1::DatasetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)

          # Call method
          response = client.export_data(formatted_name, export_config)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes export_data and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.dataset_path("[PROJECT]", "[LOCATION]", "[DATASET]")
      export_config = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient#export_data.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/export_data_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::ExportDataRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(Google::Gax::to_proto(export_config, Google::Cloud::Aiplatform::V1beta1::ExportDataConfig), request.export_config)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:export_data, mock_method)

      # Mock auth layer
      mock_credentials = MockDatasetServiceCredentials_v1beta1.new("export_data")

      Google::Cloud::Aiplatform::V1beta1::DatasetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)

          # Call method
          response = client.export_data(formatted_name, export_config)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes export_data with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.dataset_path("[PROJECT]", "[LOCATION]", "[DATASET]")
      export_config = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::ExportDataRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(Google::Gax::to_proto(export_config, Google::Cloud::Aiplatform::V1beta1::ExportDataConfig), request.export_config)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:export_data, mock_method)

      # Mock auth layer
      mock_credentials = MockDatasetServiceCredentials_v1beta1.new("export_data")

      Google::Cloud::Aiplatform::V1beta1::DatasetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.export_data(formatted_name, export_config)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_data_items' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient#list_data_items."

    it 'invokes list_data_items without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.dataset_path("[PROJECT]", "[LOCATION]", "[DATASET]")

      # Create expected grpc response
      next_page_token = ""
      data_items_element = {}
      data_items = [data_items_element]
      expected_response = { next_page_token: next_page_token, data_items: data_items }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::ListDataItemsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::ListDataItemsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_data_items, mock_method)

      # Mock auth layer
      mock_credentials = MockDatasetServiceCredentials_v1beta1.new("list_data_items")

      Google::Cloud::Aiplatform::V1beta1::DatasetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)

          # Call method
          response = client.list_data_items(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.data_items.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_data_items with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.dataset_path("[PROJECT]", "[LOCATION]", "[DATASET]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::ListDataItemsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_data_items, mock_method)

      # Mock auth layer
      mock_credentials = MockDatasetServiceCredentials_v1beta1.new("list_data_items")

      Google::Cloud::Aiplatform::V1beta1::DatasetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.list_data_items(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_annotation_spec' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient#get_annotation_spec."

    it 'invokes get_annotation_spec without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.annotation_spec_path("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      etag = "etag3123477"
      expected_response = {
        name: name_2,
        display_name: display_name,
        etag: etag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::AnnotationSpec)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::GetAnnotationSpecRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_annotation_spec, mock_method)

      # Mock auth layer
      mock_credentials = MockDatasetServiceCredentials_v1beta1.new("get_annotation_spec")

      Google::Cloud::Aiplatform::V1beta1::DatasetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)

          # Call method
          response = client.get_annotation_spec(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_annotation_spec(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_annotation_spec with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.annotation_spec_path("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::GetAnnotationSpecRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_annotation_spec, mock_method)

      # Mock auth layer
      mock_credentials = MockDatasetServiceCredentials_v1beta1.new("get_annotation_spec")

      Google::Cloud::Aiplatform::V1beta1::DatasetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.get_annotation_spec(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_annotations' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient#list_annotations."

    it 'invokes list_annotations without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.data_item_path("[PROJECT]", "[LOCATION]", "[DATASET]", "[DATA_ITEM]")

      # Create expected grpc response
      next_page_token = ""
      annotations_element = {}
      annotations = [annotations_element]
      expected_response = { next_page_token: next_page_token, annotations: annotations }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::ListAnnotationsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::ListAnnotationsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_annotations, mock_method)

      # Mock auth layer
      mock_credentials = MockDatasetServiceCredentials_v1beta1.new("list_annotations")

      Google::Cloud::Aiplatform::V1beta1::DatasetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)

          # Call method
          response = client.list_annotations(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.annotations.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_annotations with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.data_item_path("[PROJECT]", "[LOCATION]", "[DATASET]", "[DATA_ITEM]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::ListAnnotationsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_annotations, mock_method)

      # Mock auth layer
      mock_credentials = MockDatasetServiceCredentials_v1beta1.new("list_annotations")

      Google::Cloud::Aiplatform::V1beta1::DatasetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.list_annotations(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end