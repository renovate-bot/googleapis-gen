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
require "google/cloud/aiplatform/v1_beta1/prediction_service_client"
require "google/cloud/aiplatform/v1beta1/prediction_service_services_pb"

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

class MockPredictionServiceCredentials_v1beta1 < Google::Cloud::Aiplatform::V1Beta1::Credentials
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

describe Google::Cloud::Aiplatform::V1Beta1::PredictionServiceClient do

  describe 'predict' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::PredictionServiceClient#predict."

    it 'invokes predict without error' do
      # Create request parameters
      formatted_endpoint = Google::Cloud::Aiplatform::V1Beta1::PredictionServiceClient.endpoint_path("[PROJECT]", "[LOCATION]", "[ENDPOINT]")
      instances = []

      # Create expected grpc response
      deployed_model_id = "deployedModelId866642506"
      expected_response = { deployed_model_id: deployed_model_id }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::PredictResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::PredictRequest, request)
        assert_equal(formatted_endpoint, request.endpoint)
        instances = instances.map do |req|
          Google::Gax::to_proto(req, Google::Protobuf::Value)
        end
        assert_equal(instances, request.instances)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:predict, mock_method)

      # Mock auth layer
      mock_credentials = MockPredictionServiceCredentials_v1beta1.new("predict")

      Google::Cloud::Aiplatform::V1beta1::PredictionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Prediction.new(version: :v1beta1)

          # Call method
          response = client.predict(formatted_endpoint, instances)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.predict(formatted_endpoint, instances) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes predict with error' do
      # Create request parameters
      formatted_endpoint = Google::Cloud::Aiplatform::V1Beta1::PredictionServiceClient.endpoint_path("[PROJECT]", "[LOCATION]", "[ENDPOINT]")
      instances = []

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::PredictRequest, request)
        assert_equal(formatted_endpoint, request.endpoint)
        instances = instances.map do |req|
          Google::Gax::to_proto(req, Google::Protobuf::Value)
        end
        assert_equal(instances, request.instances)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:predict, mock_method)

      # Mock auth layer
      mock_credentials = MockPredictionServiceCredentials_v1beta1.new("predict")

      Google::Cloud::Aiplatform::V1beta1::PredictionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Prediction.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.predict(formatted_endpoint, instances)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'explain' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::PredictionServiceClient#explain."

    it 'invokes explain without error' do
      # Create request parameters
      formatted_endpoint = Google::Cloud::Aiplatform::V1Beta1::PredictionServiceClient.endpoint_path("[PROJECT]", "[LOCATION]", "[ENDPOINT]")
      instances = []

      # Create expected grpc response
      deployed_model_id = "deployedModelId866642506"
      expected_response = { deployed_model_id: deployed_model_id }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::ExplainResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::ExplainRequest, request)
        assert_equal(formatted_endpoint, request.endpoint)
        instances = instances.map do |req|
          Google::Gax::to_proto(req, Google::Protobuf::Value)
        end
        assert_equal(instances, request.instances)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:explain, mock_method)

      # Mock auth layer
      mock_credentials = MockPredictionServiceCredentials_v1beta1.new("explain")

      Google::Cloud::Aiplatform::V1beta1::PredictionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Prediction.new(version: :v1beta1)

          # Call method
          response = client.explain(formatted_endpoint, instances)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.explain(formatted_endpoint, instances) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes explain with error' do
      # Create request parameters
      formatted_endpoint = Google::Cloud::Aiplatform::V1Beta1::PredictionServiceClient.endpoint_path("[PROJECT]", "[LOCATION]", "[ENDPOINT]")
      instances = []

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::ExplainRequest, request)
        assert_equal(formatted_endpoint, request.endpoint)
        instances = instances.map do |req|
          Google::Gax::to_proto(req, Google::Protobuf::Value)
        end
        assert_equal(instances, request.instances)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:explain, mock_method)

      # Mock auth layer
      mock_credentials = MockPredictionServiceCredentials_v1beta1.new("explain")

      Google::Cloud::Aiplatform::V1beta1::PredictionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Prediction.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.explain(formatted_endpoint, instances)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end