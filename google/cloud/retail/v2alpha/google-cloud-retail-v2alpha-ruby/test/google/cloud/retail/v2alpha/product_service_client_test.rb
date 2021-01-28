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

require "google/cloud/retail/v2alpha"
require "google/cloud/retail/v2alpha/product_service_client"
require "google/cloud/retail/v2alpha/product_service_services_pb"
require "google/longrunning/operations_pb"

class CustomTestError_v2alpha < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v2alpha

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

class MockProductServiceCredentials_v2alpha < Google::Cloud::Retail::V2alpha::Credentials
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

describe Google::Cloud::Retail::V2alpha::ProductServiceClient do

  describe 'create_product' do
    custom_error = CustomTestError_v2alpha.new "Custom test error for Google::Cloud::Retail::V2alpha::ProductServiceClient#create_product."

    it 'invokes create_product without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Retail::V2alpha::ProductServiceClient.branch_path("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]")
      product = {}
      product_id = ''

      # Create expected grpc response
      name = "name3373707"
      id = "id3355"
      primary_product_id = "primaryProductId-898851640"
      title = "title110371416"
      description = "description-1724546052"
      uri = "uri116076"
      expected_response = {
        name: name,
        id: id,
        primary_product_id: primary_product_id,
        title: title,
        description: description,
        uri: uri
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Retail::V2alpha::Product)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Retail::V2alpha::CreateProductRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(product, Google::Cloud::Retail::V2alpha::Product), request.product)
        assert_equal(product_id, request.product_id)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2alpha.new(:create_product, mock_method)

      # Mock auth layer
      mock_credentials = MockProductServiceCredentials_v2alpha.new("create_product")

      Google::Cloud::Retail::V2alpha::ProductService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Retail::V2alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Retail::V2alpha::Product.new

          # Call method
          response = client.create_product(
            formatted_parent,
            product,
            product_id
          )

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_product(
            formatted_parent,
            product,
            product_id
          ) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_product with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Retail::V2alpha::ProductServiceClient.branch_path("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]")
      product = {}
      product_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Retail::V2alpha::CreateProductRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(product, Google::Cloud::Retail::V2alpha::Product), request.product)
        assert_equal(product_id, request.product_id)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2alpha.new(:create_product, mock_method)

      # Mock auth layer
      mock_credentials = MockProductServiceCredentials_v2alpha.new("create_product")

      Google::Cloud::Retail::V2alpha::ProductService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Retail::V2alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Retail::V2alpha::Product.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2alpha do
            client.create_product(
              formatted_parent,
              product,
              product_id
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_product' do
    custom_error = CustomTestError_v2alpha.new "Custom test error for Google::Cloud::Retail::V2alpha::ProductServiceClient#get_product."

    it 'invokes get_product without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Retail::V2alpha::ProductServiceClient.product_path("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      id = "id3355"
      primary_product_id = "primaryProductId-898851640"
      title = "title110371416"
      description = "description-1724546052"
      uri = "uri116076"
      expected_response = {
        name: name_2,
        id: id,
        primary_product_id: primary_product_id,
        title: title,
        description: description,
        uri: uri
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Retail::V2alpha::Product)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Retail::V2alpha::GetProductRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2alpha.new(:get_product, mock_method)

      # Mock auth layer
      mock_credentials = MockProductServiceCredentials_v2alpha.new("get_product")

      Google::Cloud::Retail::V2alpha::ProductService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Retail::V2alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Retail::V2alpha::Product.new

          # Call method
          response = client.get_product(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_product(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_product with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Retail::V2alpha::ProductServiceClient.product_path("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Retail::V2alpha::GetProductRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2alpha.new(:get_product, mock_method)

      # Mock auth layer
      mock_credentials = MockProductServiceCredentials_v2alpha.new("get_product")

      Google::Cloud::Retail::V2alpha::ProductService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Retail::V2alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Retail::V2alpha::Product.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2alpha do
            client.get_product(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_product' do
    custom_error = CustomTestError_v2alpha.new "Custom test error for Google::Cloud::Retail::V2alpha::ProductServiceClient#update_product."

    it 'invokes update_product without error' do
      # Create request parameters
      product = {}

      # Create expected grpc response
      name = "name3373707"
      id = "id3355"
      primary_product_id = "primaryProductId-898851640"
      title = "title110371416"
      description = "description-1724546052"
      uri = "uri116076"
      expected_response = {
        name: name,
        id: id,
        primary_product_id: primary_product_id,
        title: title,
        description: description,
        uri: uri
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Retail::V2alpha::Product)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Retail::V2alpha::UpdateProductRequest, request)
        assert_equal(Google::Gax::to_proto(product, Google::Cloud::Retail::V2alpha::Product), request.product)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2alpha.new(:update_product, mock_method)

      # Mock auth layer
      mock_credentials = MockProductServiceCredentials_v2alpha.new("update_product")

      Google::Cloud::Retail::V2alpha::ProductService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Retail::V2alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Retail::V2alpha::Product.new

          # Call method
          response = client.update_product(product)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_product(product) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_product with error' do
      # Create request parameters
      product = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Retail::V2alpha::UpdateProductRequest, request)
        assert_equal(Google::Gax::to_proto(product, Google::Cloud::Retail::V2alpha::Product), request.product)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2alpha.new(:update_product, mock_method)

      # Mock auth layer
      mock_credentials = MockProductServiceCredentials_v2alpha.new("update_product")

      Google::Cloud::Retail::V2alpha::ProductService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Retail::V2alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Retail::V2alpha::Product.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2alpha do
            client.update_product(product)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_product' do
    custom_error = CustomTestError_v2alpha.new "Custom test error for Google::Cloud::Retail::V2alpha::ProductServiceClient#delete_product."

    it 'invokes delete_product without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Retail::V2alpha::ProductServiceClient.product_path("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Retail::V2alpha::DeleteProductRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v2alpha.new(:delete_product, mock_method)

      # Mock auth layer
      mock_credentials = MockProductServiceCredentials_v2alpha.new("delete_product")

      Google::Cloud::Retail::V2alpha::ProductService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Retail::V2alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Retail::V2alpha::Product.new

          # Call method
          response = client.delete_product(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_product(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_product with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Retail::V2alpha::ProductServiceClient.product_path("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Retail::V2alpha::DeleteProductRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2alpha.new(:delete_product, mock_method)

      # Mock auth layer
      mock_credentials = MockProductServiceCredentials_v2alpha.new("delete_product")

      Google::Cloud::Retail::V2alpha::ProductService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Retail::V2alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Retail::V2alpha::Product.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2alpha do
            client.delete_product(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'import_products' do
    custom_error = CustomTestError_v2alpha.new "Custom test error for Google::Cloud::Retail::V2alpha::ProductServiceClient#import_products."

    it 'invokes import_products without error' do
      # Create request parameters
      parent = ''
      input_config = {}

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Retail::V2alpha::ImportProductsResponse)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/import_products_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Retail::V2alpha::ImportProductsRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(Google::Gax::to_proto(input_config, Google::Cloud::Retail::V2alpha::ProductInputConfig), request.input_config)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v2alpha.new(:import_products, mock_method)

      # Mock auth layer
      mock_credentials = MockProductServiceCredentials_v2alpha.new("import_products")

      Google::Cloud::Retail::V2alpha::ProductService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Retail::V2alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Retail::V2alpha::Product.new

          # Call method
          response = client.import_products(parent, input_config)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes import_products and returns an operation error.' do
      # Create request parameters
      parent = ''
      input_config = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Retail::V2alpha::ProductServiceClient#import_products.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/import_products_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Retail::V2alpha::ImportProductsRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(Google::Gax::to_proto(input_config, Google::Cloud::Retail::V2alpha::ProductInputConfig), request.input_config)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v2alpha.new(:import_products, mock_method)

      # Mock auth layer
      mock_credentials = MockProductServiceCredentials_v2alpha.new("import_products")

      Google::Cloud::Retail::V2alpha::ProductService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Retail::V2alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Retail::V2alpha::Product.new

          # Call method
          response = client.import_products(parent, input_config)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes import_products with error' do
      # Create request parameters
      parent = ''
      input_config = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Retail::V2alpha::ImportProductsRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(Google::Gax::to_proto(input_config, Google::Cloud::Retail::V2alpha::ProductInputConfig), request.input_config)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2alpha.new(:import_products, mock_method)

      # Mock auth layer
      mock_credentials = MockProductServiceCredentials_v2alpha.new("import_products")

      Google::Cloud::Retail::V2alpha::ProductService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Retail::V2alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Retail::V2alpha::Product.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2alpha do
            client.import_products(parent, input_config)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end