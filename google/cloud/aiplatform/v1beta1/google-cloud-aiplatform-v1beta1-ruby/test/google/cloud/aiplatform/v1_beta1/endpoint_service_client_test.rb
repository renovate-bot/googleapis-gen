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
require "google/cloud/aiplatform/v1_beta1/endpoint_service_client"
require "google/cloud/aiplatform/v1beta1/endpoint_service_services_pb"
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

class MockEndpointServiceCredentials_v1beta1 < Google::Cloud::Aiplatform::V1Beta1::Credentials
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

describe Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient do

  describe 'create_endpoint' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient#create_endpoint."

    it 'invokes create_endpoint without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient.location_path("[PROJECT]", "[LOCATION]")
      endpoint = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      etag = "etag3123477"
      expected_response = {
        name: name,
        display_name: display_name,
        description: description,
        etag: etag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::Endpoint)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_endpoint_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::CreateEndpointRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(endpoint, Google::Cloud::Aiplatform::V1beta1::Endpoint), request.endpoint)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_endpoint, mock_method)

      # Mock auth layer
      mock_credentials = MockEndpointServiceCredentials_v1beta1.new("create_endpoint")

      Google::Cloud::Aiplatform::V1beta1::EndpointService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Endpoint.new(version: :v1beta1)

          # Call method
          response = client.create_endpoint(formatted_parent, endpoint)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes create_endpoint and returns an operation error.' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient.location_path("[PROJECT]", "[LOCATION]")
      endpoint = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient#create_endpoint.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_endpoint_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::CreateEndpointRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(endpoint, Google::Cloud::Aiplatform::V1beta1::Endpoint), request.endpoint)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_endpoint, mock_method)

      # Mock auth layer
      mock_credentials = MockEndpointServiceCredentials_v1beta1.new("create_endpoint")

      Google::Cloud::Aiplatform::V1beta1::EndpointService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Endpoint.new(version: :v1beta1)

          # Call method
          response = client.create_endpoint(formatted_parent, endpoint)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes create_endpoint with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient.location_path("[PROJECT]", "[LOCATION]")
      endpoint = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::CreateEndpointRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(endpoint, Google::Cloud::Aiplatform::V1beta1::Endpoint), request.endpoint)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_endpoint, mock_method)

      # Mock auth layer
      mock_credentials = MockEndpointServiceCredentials_v1beta1.new("create_endpoint")

      Google::Cloud::Aiplatform::V1beta1::EndpointService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Endpoint.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.create_endpoint(formatted_parent, endpoint)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_endpoint' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient#get_endpoint."

    it 'invokes get_endpoint without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient.endpoint_path("[PROJECT]", "[LOCATION]", "[ENDPOINT]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      etag = "etag3123477"
      expected_response = {
        name: name_2,
        display_name: display_name,
        description: description,
        etag: etag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::Endpoint)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::GetEndpointRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_endpoint, mock_method)

      # Mock auth layer
      mock_credentials = MockEndpointServiceCredentials_v1beta1.new("get_endpoint")

      Google::Cloud::Aiplatform::V1beta1::EndpointService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Endpoint.new(version: :v1beta1)

          # Call method
          response = client.get_endpoint(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_endpoint(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_endpoint with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient.endpoint_path("[PROJECT]", "[LOCATION]", "[ENDPOINT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::GetEndpointRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_endpoint, mock_method)

      # Mock auth layer
      mock_credentials = MockEndpointServiceCredentials_v1beta1.new("get_endpoint")

      Google::Cloud::Aiplatform::V1beta1::EndpointService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Endpoint.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.get_endpoint(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_endpoints' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient#list_endpoints."

    it 'invokes list_endpoints without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      endpoints_element = {}
      endpoints = [endpoints_element]
      expected_response = { next_page_token: next_page_token, endpoints: endpoints }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::ListEndpointsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::ListEndpointsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_endpoints, mock_method)

      # Mock auth layer
      mock_credentials = MockEndpointServiceCredentials_v1beta1.new("list_endpoints")

      Google::Cloud::Aiplatform::V1beta1::EndpointService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Endpoint.new(version: :v1beta1)

          # Call method
          response = client.list_endpoints(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.endpoints.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_endpoints with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::ListEndpointsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_endpoints, mock_method)

      # Mock auth layer
      mock_credentials = MockEndpointServiceCredentials_v1beta1.new("list_endpoints")

      Google::Cloud::Aiplatform::V1beta1::EndpointService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Endpoint.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.list_endpoints(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_endpoint' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient#update_endpoint."

    it 'invokes update_endpoint without error' do
      # Create request parameters
      endpoint = {}
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      etag = "etag3123477"
      expected_response = {
        name: name,
        display_name: display_name,
        description: description,
        etag: etag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::Endpoint)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::UpdateEndpointRequest, request)
        assert_equal(Google::Gax::to_proto(endpoint, Google::Cloud::Aiplatform::V1beta1::Endpoint), request.endpoint)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_endpoint, mock_method)

      # Mock auth layer
      mock_credentials = MockEndpointServiceCredentials_v1beta1.new("update_endpoint")

      Google::Cloud::Aiplatform::V1beta1::EndpointService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Endpoint.new(version: :v1beta1)

          # Call method
          response = client.update_endpoint(endpoint, update_mask)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_endpoint(endpoint, update_mask) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_endpoint with error' do
      # Create request parameters
      endpoint = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::UpdateEndpointRequest, request)
        assert_equal(Google::Gax::to_proto(endpoint, Google::Cloud::Aiplatform::V1beta1::Endpoint), request.endpoint)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_endpoint, mock_method)

      # Mock auth layer
      mock_credentials = MockEndpointServiceCredentials_v1beta1.new("update_endpoint")

      Google::Cloud::Aiplatform::V1beta1::EndpointService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Endpoint.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.update_endpoint(endpoint, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_endpoint' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient#delete_endpoint."

    it 'invokes delete_endpoint without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient.endpoint_path("[PROJECT]", "[LOCATION]", "[ENDPOINT]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Protobuf::Empty)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_endpoint_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::DeleteEndpointRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_endpoint, mock_method)

      # Mock auth layer
      mock_credentials = MockEndpointServiceCredentials_v1beta1.new("delete_endpoint")

      Google::Cloud::Aiplatform::V1beta1::EndpointService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Endpoint.new(version: :v1beta1)

          # Call method
          response = client.delete_endpoint(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes delete_endpoint and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient.endpoint_path("[PROJECT]", "[LOCATION]", "[ENDPOINT]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient#delete_endpoint.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_endpoint_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::DeleteEndpointRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_endpoint, mock_method)

      # Mock auth layer
      mock_credentials = MockEndpointServiceCredentials_v1beta1.new("delete_endpoint")

      Google::Cloud::Aiplatform::V1beta1::EndpointService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Endpoint.new(version: :v1beta1)

          # Call method
          response = client.delete_endpoint(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes delete_endpoint with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient.endpoint_path("[PROJECT]", "[LOCATION]", "[ENDPOINT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::DeleteEndpointRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_endpoint, mock_method)

      # Mock auth layer
      mock_credentials = MockEndpointServiceCredentials_v1beta1.new("delete_endpoint")

      Google::Cloud::Aiplatform::V1beta1::EndpointService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Endpoint.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.delete_endpoint(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'deploy_model' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient#deploy_model."

    it 'invokes deploy_model without error' do
      # Create request parameters
      formatted_endpoint = Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient.endpoint_path("[PROJECT]", "[LOCATION]", "[ENDPOINT]")
      deployed_model = {}

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::DeployModelResponse)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/deploy_model_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::DeployModelRequest, request)
        assert_equal(formatted_endpoint, request.endpoint)
        assert_equal(Google::Gax::to_proto(deployed_model, Google::Cloud::Aiplatform::V1beta1::DeployedModel), request.deployed_model)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:deploy_model, mock_method)

      # Mock auth layer
      mock_credentials = MockEndpointServiceCredentials_v1beta1.new("deploy_model")

      Google::Cloud::Aiplatform::V1beta1::EndpointService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Endpoint.new(version: :v1beta1)

          # Call method
          response = client.deploy_model(formatted_endpoint, deployed_model)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes deploy_model and returns an operation error.' do
      # Create request parameters
      formatted_endpoint = Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient.endpoint_path("[PROJECT]", "[LOCATION]", "[ENDPOINT]")
      deployed_model = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient#deploy_model.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/deploy_model_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::DeployModelRequest, request)
        assert_equal(formatted_endpoint, request.endpoint)
        assert_equal(Google::Gax::to_proto(deployed_model, Google::Cloud::Aiplatform::V1beta1::DeployedModel), request.deployed_model)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:deploy_model, mock_method)

      # Mock auth layer
      mock_credentials = MockEndpointServiceCredentials_v1beta1.new("deploy_model")

      Google::Cloud::Aiplatform::V1beta1::EndpointService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Endpoint.new(version: :v1beta1)

          # Call method
          response = client.deploy_model(formatted_endpoint, deployed_model)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes deploy_model with error' do
      # Create request parameters
      formatted_endpoint = Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient.endpoint_path("[PROJECT]", "[LOCATION]", "[ENDPOINT]")
      deployed_model = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::DeployModelRequest, request)
        assert_equal(formatted_endpoint, request.endpoint)
        assert_equal(Google::Gax::to_proto(deployed_model, Google::Cloud::Aiplatform::V1beta1::DeployedModel), request.deployed_model)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:deploy_model, mock_method)

      # Mock auth layer
      mock_credentials = MockEndpointServiceCredentials_v1beta1.new("deploy_model")

      Google::Cloud::Aiplatform::V1beta1::EndpointService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Endpoint.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.deploy_model(formatted_endpoint, deployed_model)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'undeploy_model' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient#undeploy_model."

    it 'invokes undeploy_model without error' do
      # Create request parameters
      formatted_endpoint = Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient.endpoint_path("[PROJECT]", "[LOCATION]", "[ENDPOINT]")
      deployed_model_id = ''

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::UndeployModelResponse)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/undeploy_model_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::UndeployModelRequest, request)
        assert_equal(formatted_endpoint, request.endpoint)
        assert_equal(deployed_model_id, request.deployed_model_id)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:undeploy_model, mock_method)

      # Mock auth layer
      mock_credentials = MockEndpointServiceCredentials_v1beta1.new("undeploy_model")

      Google::Cloud::Aiplatform::V1beta1::EndpointService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Endpoint.new(version: :v1beta1)

          # Call method
          response = client.undeploy_model(formatted_endpoint, deployed_model_id)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes undeploy_model and returns an operation error.' do
      # Create request parameters
      formatted_endpoint = Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient.endpoint_path("[PROJECT]", "[LOCATION]", "[ENDPOINT]")
      deployed_model_id = ''

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient#undeploy_model.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/undeploy_model_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::UndeployModelRequest, request)
        assert_equal(formatted_endpoint, request.endpoint)
        assert_equal(deployed_model_id, request.deployed_model_id)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:undeploy_model, mock_method)

      # Mock auth layer
      mock_credentials = MockEndpointServiceCredentials_v1beta1.new("undeploy_model")

      Google::Cloud::Aiplatform::V1beta1::EndpointService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Endpoint.new(version: :v1beta1)

          # Call method
          response = client.undeploy_model(formatted_endpoint, deployed_model_id)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes undeploy_model with error' do
      # Create request parameters
      formatted_endpoint = Google::Cloud::Aiplatform::V1Beta1::EndpointServiceClient.endpoint_path("[PROJECT]", "[LOCATION]", "[ENDPOINT]")
      deployed_model_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::UndeployModelRequest, request)
        assert_equal(formatted_endpoint, request.endpoint)
        assert_equal(deployed_model_id, request.deployed_model_id)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:undeploy_model, mock_method)

      # Mock auth layer
      mock_credentials = MockEndpointServiceCredentials_v1beta1.new("undeploy_model")

      Google::Cloud::Aiplatform::V1beta1::EndpointService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Endpoint.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.undeploy_model(formatted_endpoint, deployed_model_id)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end