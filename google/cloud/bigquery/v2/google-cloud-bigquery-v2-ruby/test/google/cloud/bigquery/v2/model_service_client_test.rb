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

require "google/cloud/bigquery"
require "google/cloud/bigquery/v2/model_service_client"
require "google/cloud/bigquery/v2/model_services_pb"

class CustomTestError_v2 < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v2

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

class MockModelServiceCredentials_v2 < Google::Cloud::Bigquery::V2::Credentials
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

describe Google::Cloud::Bigquery::V2::ModelServiceClient do

  describe 'get_model' do
    custom_error = CustomTestError_v2.new "Custom test error for Google::Cloud::Bigquery::V2::ModelServiceClient#get_model."

    it 'invokes get_model without error' do
      # Create request parameters
      project_id = ''
      dataset_id = ''
      model_id = ''

      # Create expected grpc response
      etag = "etag3123477"
      creation_time = 1932333101
      last_modified_time = 671513446
      description = "description-1724546052"
      friendly_name = "friendlyName1451097503"
      expiration_time = 767170141
      location = "location1901043637"
      expected_response = {
        etag: etag,
        creation_time: creation_time,
        last_modified_time: last_modified_time,
        description: description,
        friendly_name: friendly_name,
        expiration_time: expiration_time,
        location: location
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::V2::Model)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::V2::GetModelRequest, request)
        assert_equal(project_id, request.project_id)
        assert_equal(dataset_id, request.dataset_id)
        assert_equal(model_id, request.model_id)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2.new(:get_model, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v2.new("get_model")

      Google::Cloud::Bigquery::V2::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery.new(version: :v2)

          # Call method
          response = client.get_model(
            project_id,
            dataset_id,
            model_id
          )

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_model(
            project_id,
            dataset_id,
            model_id
          ) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_model with error' do
      # Create request parameters
      project_id = ''
      dataset_id = ''
      model_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::V2::GetModelRequest, request)
        assert_equal(project_id, request.project_id)
        assert_equal(dataset_id, request.dataset_id)
        assert_equal(model_id, request.model_id)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2.new(:get_model, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v2.new("get_model")

      Google::Cloud::Bigquery::V2::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery.new(version: :v2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2 do
            client.get_model(
              project_id,
              dataset_id,
              model_id
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_models' do
    custom_error = CustomTestError_v2.new "Custom test error for Google::Cloud::Bigquery::V2::ModelServiceClient#list_models."

    it 'invokes list_models without error' do
      # Create request parameters
      project_id = ''
      dataset_id = ''

      # Create expected grpc response
      next_page_token = "nextPageToken-1530815211"
      expected_response = { next_page_token: next_page_token }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::V2::ListModelsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::V2::ListModelsRequest, request)
        assert_equal(project_id, request.project_id)
        assert_equal(dataset_id, request.dataset_id)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2.new(:list_models, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v2.new("list_models")

      Google::Cloud::Bigquery::V2::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery.new(version: :v2)

          # Call method
          response = client.list_models(project_id, dataset_id)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.list_models(project_id, dataset_id) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes list_models with error' do
      # Create request parameters
      project_id = ''
      dataset_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::V2::ListModelsRequest, request)
        assert_equal(project_id, request.project_id)
        assert_equal(dataset_id, request.dataset_id)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2.new(:list_models, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v2.new("list_models")

      Google::Cloud::Bigquery::V2::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery.new(version: :v2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2 do
            client.list_models(project_id, dataset_id)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'patch_model' do
    custom_error = CustomTestError_v2.new "Custom test error for Google::Cloud::Bigquery::V2::ModelServiceClient#patch_model."

    it 'invokes patch_model without error' do
      # Create request parameters
      project_id = ''
      dataset_id = ''
      model_id = ''
      model = {}

      # Create expected grpc response
      etag = "etag3123477"
      creation_time = 1932333101
      last_modified_time = 671513446
      description = "description-1724546052"
      friendly_name = "friendlyName1451097503"
      expiration_time = 767170141
      location = "location1901043637"
      expected_response = {
        etag: etag,
        creation_time: creation_time,
        last_modified_time: last_modified_time,
        description: description,
        friendly_name: friendly_name,
        expiration_time: expiration_time,
        location: location
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::V2::Model)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::V2::PatchModelRequest, request)
        assert_equal(project_id, request.project_id)
        assert_equal(dataset_id, request.dataset_id)
        assert_equal(model_id, request.model_id)
        assert_equal(Google::Gax::to_proto(model, Google::Cloud::Bigquery::V2::Model), request.model)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2.new(:patch_model, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v2.new("patch_model")

      Google::Cloud::Bigquery::V2::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery.new(version: :v2)

          # Call method
          response = client.patch_model(
            project_id,
            dataset_id,
            model_id,
            model
          )

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.patch_model(
            project_id,
            dataset_id,
            model_id,
            model
          ) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes patch_model with error' do
      # Create request parameters
      project_id = ''
      dataset_id = ''
      model_id = ''
      model = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::V2::PatchModelRequest, request)
        assert_equal(project_id, request.project_id)
        assert_equal(dataset_id, request.dataset_id)
        assert_equal(model_id, request.model_id)
        assert_equal(Google::Gax::to_proto(model, Google::Cloud::Bigquery::V2::Model), request.model)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2.new(:patch_model, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v2.new("patch_model")

      Google::Cloud::Bigquery::V2::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery.new(version: :v2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2 do
            client.patch_model(
              project_id,
              dataset_id,
              model_id,
              model
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_model' do
    custom_error = CustomTestError_v2.new "Custom test error for Google::Cloud::Bigquery::V2::ModelServiceClient#delete_model."

    it 'invokes delete_model without error' do
      # Create request parameters
      project_id = ''
      dataset_id = ''
      model_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::V2::DeleteModelRequest, request)
        assert_equal(project_id, request.project_id)
        assert_equal(dataset_id, request.dataset_id)
        assert_equal(model_id, request.model_id)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v2.new(:delete_model, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v2.new("delete_model")

      Google::Cloud::Bigquery::V2::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery.new(version: :v2)

          # Call method
          response = client.delete_model(
            project_id,
            dataset_id,
            model_id
          )

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_model(
            project_id,
            dataset_id,
            model_id
          ) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_model with error' do
      # Create request parameters
      project_id = ''
      dataset_id = ''
      model_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::V2::DeleteModelRequest, request)
        assert_equal(project_id, request.project_id)
        assert_equal(dataset_id, request.dataset_id)
        assert_equal(model_id, request.model_id)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2.new(:delete_model, mock_method)

      # Mock auth layer
      mock_credentials = MockModelServiceCredentials_v2.new("delete_model")

      Google::Cloud::Bigquery::V2::ModelService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery.new(version: :v2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2 do
            client.delete_model(
              project_id,
              dataset_id,
              model_id
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end