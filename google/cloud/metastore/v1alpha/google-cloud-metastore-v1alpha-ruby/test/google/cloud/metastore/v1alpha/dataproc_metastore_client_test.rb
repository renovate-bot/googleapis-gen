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

require "google/cloud/metastore/v1alpha"
require "google/cloud/metastore/v1alpha/dataproc_metastore_client"
require "google/cloud/metastore/v1alpha/metastore_services_pb"
require "google/longrunning/operations_pb"

class CustomTestError_v1alpha < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v1alpha

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

class MockDataprocMetastoreCredentials_v1alpha < Google::Cloud::Metastore::V1alpha::Credentials
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

describe Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient do

  describe 'list_services' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient#list_services."

    it 'invokes list_services without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      services_element = {}
      services = [services_element]
      expected_response = { next_page_token: next_page_token, services: services }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Metastore::V1alpha::ListServicesResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Metastore::V1alpha::ListServicesRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_services, mock_method)

      # Mock auth layer
      mock_credentials = MockDataprocMetastoreCredentials_v1alpha.new("list_services")

      Google::Cloud::Metastore::V1alpha::DataprocMetastore::Stub.stub(:new, mock_stub) do
        Google::Cloud::Metastore::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Metastore::V1alpha.new

          # Call method
          response = client.list_services(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.services.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_services with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Metastore::V1alpha::ListServicesRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_services, mock_method)

      # Mock auth layer
      mock_credentials = MockDataprocMetastoreCredentials_v1alpha.new("list_services")

      Google::Cloud::Metastore::V1alpha::DataprocMetastore::Stub.stub(:new, mock_stub) do
        Google::Cloud::Metastore::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Metastore::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.list_services(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_service' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient#get_service."

    it 'invokes get_service without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient.service_path("[PROJECT]", "[LOCATION]", "[SERVICE]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      network = "network1843485230"
      endpoint_uri = "endpointUri-850313278"
      port = 3446913
      state_message = "stateMessage29641305"
      artifact_gcs_uri = "artifactGcsUri1337121495"
      expected_response = {
        name: name_2,
        network: network,
        endpoint_uri: endpoint_uri,
        port: port,
        state_message: state_message,
        artifact_gcs_uri: artifact_gcs_uri
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Metastore::V1alpha::Service)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Metastore::V1alpha::GetServiceRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_service, mock_method)

      # Mock auth layer
      mock_credentials = MockDataprocMetastoreCredentials_v1alpha.new("get_service")

      Google::Cloud::Metastore::V1alpha::DataprocMetastore::Stub.stub(:new, mock_stub) do
        Google::Cloud::Metastore::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Metastore::V1alpha.new

          # Call method
          response = client.get_service(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_service(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_service with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient.service_path("[PROJECT]", "[LOCATION]", "[SERVICE]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Metastore::V1alpha::GetServiceRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_service, mock_method)

      # Mock auth layer
      mock_credentials = MockDataprocMetastoreCredentials_v1alpha.new("get_service")

      Google::Cloud::Metastore::V1alpha::DataprocMetastore::Stub.stub(:new, mock_stub) do
        Google::Cloud::Metastore::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Metastore::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.get_service(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_service' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient#create_service."

    it 'invokes create_service without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient.location_path("[PROJECT]", "[LOCATION]")
      service_id = ''
      service = {}

      # Create expected grpc response
      name = "name3373707"
      network = "network1843485230"
      endpoint_uri = "endpointUri-850313278"
      port = 3446913
      state_message = "stateMessage29641305"
      artifact_gcs_uri = "artifactGcsUri1337121495"
      expected_response = {
        name: name,
        network: network,
        endpoint_uri: endpoint_uri,
        port: port,
        state_message: state_message,
        artifact_gcs_uri: artifact_gcs_uri
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Metastore::V1alpha::Service)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_service_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Metastore::V1alpha::CreateServiceRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(service_id, request.service_id)
        assert_equal(Google::Gax::to_proto(service, Google::Cloud::Metastore::V1alpha::Service), request.service)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:create_service, mock_method)

      # Mock auth layer
      mock_credentials = MockDataprocMetastoreCredentials_v1alpha.new("create_service")

      Google::Cloud::Metastore::V1alpha::DataprocMetastore::Stub.stub(:new, mock_stub) do
        Google::Cloud::Metastore::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Metastore::V1alpha.new

          # Call method
          response = client.create_service(
            formatted_parent,
            service_id,
            service
          )

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes create_service and returns an operation error.' do
      # Create request parameters
      formatted_parent = Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient.location_path("[PROJECT]", "[LOCATION]")
      service_id = ''
      service = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient#create_service.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_service_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Metastore::V1alpha::CreateServiceRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(service_id, request.service_id)
        assert_equal(Google::Gax::to_proto(service, Google::Cloud::Metastore::V1alpha::Service), request.service)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:create_service, mock_method)

      # Mock auth layer
      mock_credentials = MockDataprocMetastoreCredentials_v1alpha.new("create_service")

      Google::Cloud::Metastore::V1alpha::DataprocMetastore::Stub.stub(:new, mock_stub) do
        Google::Cloud::Metastore::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Metastore::V1alpha.new

          # Call method
          response = client.create_service(
            formatted_parent,
            service_id,
            service
          )

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes create_service with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient.location_path("[PROJECT]", "[LOCATION]")
      service_id = ''
      service = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Metastore::V1alpha::CreateServiceRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(service_id, request.service_id)
        assert_equal(Google::Gax::to_proto(service, Google::Cloud::Metastore::V1alpha::Service), request.service)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:create_service, mock_method)

      # Mock auth layer
      mock_credentials = MockDataprocMetastoreCredentials_v1alpha.new("create_service")

      Google::Cloud::Metastore::V1alpha::DataprocMetastore::Stub.stub(:new, mock_stub) do
        Google::Cloud::Metastore::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Metastore::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.create_service(
              formatted_parent,
              service_id,
              service
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_service' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient#update_service."

    it 'invokes update_service without error' do
      # Create request parameters
      update_mask = {}
      service = {}

      # Create expected grpc response
      name = "name3373707"
      network = "network1843485230"
      endpoint_uri = "endpointUri-850313278"
      port = 3446913
      state_message = "stateMessage29641305"
      artifact_gcs_uri = "artifactGcsUri1337121495"
      expected_response = {
        name: name,
        network: network,
        endpoint_uri: endpoint_uri,
        port: port,
        state_message: state_message,
        artifact_gcs_uri: artifact_gcs_uri
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Metastore::V1alpha::Service)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_service_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Metastore::V1alpha::UpdateServiceRequest, request)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        assert_equal(Google::Gax::to_proto(service, Google::Cloud::Metastore::V1alpha::Service), request.service)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_service, mock_method)

      # Mock auth layer
      mock_credentials = MockDataprocMetastoreCredentials_v1alpha.new("update_service")

      Google::Cloud::Metastore::V1alpha::DataprocMetastore::Stub.stub(:new, mock_stub) do
        Google::Cloud::Metastore::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Metastore::V1alpha.new

          # Call method
          response = client.update_service(update_mask, service)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes update_service and returns an operation error.' do
      # Create request parameters
      update_mask = {}
      service = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient#update_service.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_service_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Metastore::V1alpha::UpdateServiceRequest, request)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        assert_equal(Google::Gax::to_proto(service, Google::Cloud::Metastore::V1alpha::Service), request.service)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_service, mock_method)

      # Mock auth layer
      mock_credentials = MockDataprocMetastoreCredentials_v1alpha.new("update_service")

      Google::Cloud::Metastore::V1alpha::DataprocMetastore::Stub.stub(:new, mock_stub) do
        Google::Cloud::Metastore::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Metastore::V1alpha.new

          # Call method
          response = client.update_service(update_mask, service)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes update_service with error' do
      # Create request parameters
      update_mask = {}
      service = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Metastore::V1alpha::UpdateServiceRequest, request)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        assert_equal(Google::Gax::to_proto(service, Google::Cloud::Metastore::V1alpha::Service), request.service)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_service, mock_method)

      # Mock auth layer
      mock_credentials = MockDataprocMetastoreCredentials_v1alpha.new("update_service")

      Google::Cloud::Metastore::V1alpha::DataprocMetastore::Stub.stub(:new, mock_stub) do
        Google::Cloud::Metastore::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Metastore::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.update_service(update_mask, service)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_service' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient#delete_service."

    it 'invokes delete_service without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient.service_path("[PROJECT]", "[LOCATION]", "[SERVICE]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Protobuf::Empty)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_service_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Metastore::V1alpha::DeleteServiceRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:delete_service, mock_method)

      # Mock auth layer
      mock_credentials = MockDataprocMetastoreCredentials_v1alpha.new("delete_service")

      Google::Cloud::Metastore::V1alpha::DataprocMetastore::Stub.stub(:new, mock_stub) do
        Google::Cloud::Metastore::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Metastore::V1alpha.new

          # Call method
          response = client.delete_service(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes delete_service and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient.service_path("[PROJECT]", "[LOCATION]", "[SERVICE]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient#delete_service.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_service_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Metastore::V1alpha::DeleteServiceRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:delete_service, mock_method)

      # Mock auth layer
      mock_credentials = MockDataprocMetastoreCredentials_v1alpha.new("delete_service")

      Google::Cloud::Metastore::V1alpha::DataprocMetastore::Stub.stub(:new, mock_stub) do
        Google::Cloud::Metastore::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Metastore::V1alpha.new

          # Call method
          response = client.delete_service(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes delete_service with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient.service_path("[PROJECT]", "[LOCATION]", "[SERVICE]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Metastore::V1alpha::DeleteServiceRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:delete_service, mock_method)

      # Mock auth layer
      mock_credentials = MockDataprocMetastoreCredentials_v1alpha.new("delete_service")

      Google::Cloud::Metastore::V1alpha::DataprocMetastore::Stub.stub(:new, mock_stub) do
        Google::Cloud::Metastore::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Metastore::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.delete_service(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_metadata_imports' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient#list_metadata_imports."

    it 'invokes list_metadata_imports without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient.service_path("[PROJECT]", "[LOCATION]", "[SERVICE]")

      # Create expected grpc response
      next_page_token = ""
      metadata_imports_element = {}
      metadata_imports = [metadata_imports_element]
      expected_response = { next_page_token: next_page_token, metadata_imports: metadata_imports }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Metastore::V1alpha::ListMetadataImportsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Metastore::V1alpha::ListMetadataImportsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_metadata_imports, mock_method)

      # Mock auth layer
      mock_credentials = MockDataprocMetastoreCredentials_v1alpha.new("list_metadata_imports")

      Google::Cloud::Metastore::V1alpha::DataprocMetastore::Stub.stub(:new, mock_stub) do
        Google::Cloud::Metastore::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Metastore::V1alpha.new

          # Call method
          response = client.list_metadata_imports(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.metadata_imports.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_metadata_imports with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient.service_path("[PROJECT]", "[LOCATION]", "[SERVICE]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Metastore::V1alpha::ListMetadataImportsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_metadata_imports, mock_method)

      # Mock auth layer
      mock_credentials = MockDataprocMetastoreCredentials_v1alpha.new("list_metadata_imports")

      Google::Cloud::Metastore::V1alpha::DataprocMetastore::Stub.stub(:new, mock_stub) do
        Google::Cloud::Metastore::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Metastore::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.list_metadata_imports(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_metadata_import' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient#get_metadata_import."

    it 'invokes get_metadata_import without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient.metadata_import_path("[PROJECT]", "[LOCATION]", "[SERVICE]", "[METADATA_IMPORT]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      description = "description-1724546052"
      expected_response = { name: name_2, description: description }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Metastore::V1alpha::MetadataImport)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Metastore::V1alpha::GetMetadataImportRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_metadata_import, mock_method)

      # Mock auth layer
      mock_credentials = MockDataprocMetastoreCredentials_v1alpha.new("get_metadata_import")

      Google::Cloud::Metastore::V1alpha::DataprocMetastore::Stub.stub(:new, mock_stub) do
        Google::Cloud::Metastore::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Metastore::V1alpha.new

          # Call method
          response = client.get_metadata_import(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_metadata_import(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_metadata_import with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient.metadata_import_path("[PROJECT]", "[LOCATION]", "[SERVICE]", "[METADATA_IMPORT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Metastore::V1alpha::GetMetadataImportRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_metadata_import, mock_method)

      # Mock auth layer
      mock_credentials = MockDataprocMetastoreCredentials_v1alpha.new("get_metadata_import")

      Google::Cloud::Metastore::V1alpha::DataprocMetastore::Stub.stub(:new, mock_stub) do
        Google::Cloud::Metastore::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Metastore::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.get_metadata_import(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_metadata_import' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient#create_metadata_import."

    it 'invokes create_metadata_import without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient.service_path("[PROJECT]", "[LOCATION]", "[SERVICE]")
      metadata_import_id = ''
      metadata_import = {}

      # Create expected grpc response
      name = "name3373707"
      description = "description-1724546052"
      expected_response = { name: name, description: description }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Metastore::V1alpha::MetadataImport)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_metadata_import_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Metastore::V1alpha::CreateMetadataImportRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(metadata_import_id, request.metadata_import_id)
        assert_equal(Google::Gax::to_proto(metadata_import, Google::Cloud::Metastore::V1alpha::MetadataImport), request.metadata_import)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:create_metadata_import, mock_method)

      # Mock auth layer
      mock_credentials = MockDataprocMetastoreCredentials_v1alpha.new("create_metadata_import")

      Google::Cloud::Metastore::V1alpha::DataprocMetastore::Stub.stub(:new, mock_stub) do
        Google::Cloud::Metastore::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Metastore::V1alpha.new

          # Call method
          response = client.create_metadata_import(
            formatted_parent,
            metadata_import_id,
            metadata_import
          )

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes create_metadata_import and returns an operation error.' do
      # Create request parameters
      formatted_parent = Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient.service_path("[PROJECT]", "[LOCATION]", "[SERVICE]")
      metadata_import_id = ''
      metadata_import = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient#create_metadata_import.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_metadata_import_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Metastore::V1alpha::CreateMetadataImportRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(metadata_import_id, request.metadata_import_id)
        assert_equal(Google::Gax::to_proto(metadata_import, Google::Cloud::Metastore::V1alpha::MetadataImport), request.metadata_import)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:create_metadata_import, mock_method)

      # Mock auth layer
      mock_credentials = MockDataprocMetastoreCredentials_v1alpha.new("create_metadata_import")

      Google::Cloud::Metastore::V1alpha::DataprocMetastore::Stub.stub(:new, mock_stub) do
        Google::Cloud::Metastore::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Metastore::V1alpha.new

          # Call method
          response = client.create_metadata_import(
            formatted_parent,
            metadata_import_id,
            metadata_import
          )

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes create_metadata_import with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient.service_path("[PROJECT]", "[LOCATION]", "[SERVICE]")
      metadata_import_id = ''
      metadata_import = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Metastore::V1alpha::CreateMetadataImportRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(metadata_import_id, request.metadata_import_id)
        assert_equal(Google::Gax::to_proto(metadata_import, Google::Cloud::Metastore::V1alpha::MetadataImport), request.metadata_import)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:create_metadata_import, mock_method)

      # Mock auth layer
      mock_credentials = MockDataprocMetastoreCredentials_v1alpha.new("create_metadata_import")

      Google::Cloud::Metastore::V1alpha::DataprocMetastore::Stub.stub(:new, mock_stub) do
        Google::Cloud::Metastore::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Metastore::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.create_metadata_import(
              formatted_parent,
              metadata_import_id,
              metadata_import
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_metadata_import' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient#update_metadata_import."

    it 'invokes update_metadata_import without error' do
      # Create request parameters
      update_mask = {}
      metadata_import = {}

      # Create expected grpc response
      name = "name3373707"
      description = "description-1724546052"
      expected_response = { name: name, description: description }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Metastore::V1alpha::MetadataImport)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_metadata_import_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Metastore::V1alpha::UpdateMetadataImportRequest, request)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        assert_equal(Google::Gax::to_proto(metadata_import, Google::Cloud::Metastore::V1alpha::MetadataImport), request.metadata_import)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_metadata_import, mock_method)

      # Mock auth layer
      mock_credentials = MockDataprocMetastoreCredentials_v1alpha.new("update_metadata_import")

      Google::Cloud::Metastore::V1alpha::DataprocMetastore::Stub.stub(:new, mock_stub) do
        Google::Cloud::Metastore::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Metastore::V1alpha.new

          # Call method
          response = client.update_metadata_import(update_mask, metadata_import)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes update_metadata_import and returns an operation error.' do
      # Create request parameters
      update_mask = {}
      metadata_import = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient#update_metadata_import.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_metadata_import_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Metastore::V1alpha::UpdateMetadataImportRequest, request)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        assert_equal(Google::Gax::to_proto(metadata_import, Google::Cloud::Metastore::V1alpha::MetadataImport), request.metadata_import)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_metadata_import, mock_method)

      # Mock auth layer
      mock_credentials = MockDataprocMetastoreCredentials_v1alpha.new("update_metadata_import")

      Google::Cloud::Metastore::V1alpha::DataprocMetastore::Stub.stub(:new, mock_stub) do
        Google::Cloud::Metastore::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Metastore::V1alpha.new

          # Call method
          response = client.update_metadata_import(update_mask, metadata_import)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes update_metadata_import with error' do
      # Create request parameters
      update_mask = {}
      metadata_import = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Metastore::V1alpha::UpdateMetadataImportRequest, request)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        assert_equal(Google::Gax::to_proto(metadata_import, Google::Cloud::Metastore::V1alpha::MetadataImport), request.metadata_import)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_metadata_import, mock_method)

      # Mock auth layer
      mock_credentials = MockDataprocMetastoreCredentials_v1alpha.new("update_metadata_import")

      Google::Cloud::Metastore::V1alpha::DataprocMetastore::Stub.stub(:new, mock_stub) do
        Google::Cloud::Metastore::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Metastore::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.update_metadata_import(update_mask, metadata_import)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end