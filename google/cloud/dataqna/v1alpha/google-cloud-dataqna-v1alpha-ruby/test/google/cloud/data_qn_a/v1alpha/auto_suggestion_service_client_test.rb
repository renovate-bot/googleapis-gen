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

require "google/cloud/data_qn_a/v1alpha"
require "google/cloud/data_qn_a/v1alpha/auto_suggestion_service_client"
require "google/cloud/dataqna/v1alpha/auto_suggestion_service_services_pb"

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

class MockAutoSuggestionServiceCredentials_v1alpha < Google::Cloud::DataQnA::V1alpha::Credentials
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

describe Google::Cloud::DataQnA::V1alpha::AutoSuggestionServiceClient do

  describe 'suggest_queries' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::DataQnA::V1alpha::AutoSuggestionServiceClient#suggest_queries."

    it 'invokes suggest_queries without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::DataQnA::V1alpha::AutoSuggestionServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dataqna::V1alpha::SuggestQueriesResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dataqna::V1alpha::SuggestQueriesRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:suggest_queries, mock_method)

      # Mock auth layer
      mock_credentials = MockAutoSuggestionServiceCredentials_v1alpha.new("suggest_queries")

      Google::Cloud::Dataqna::V1alpha::AutoSuggestionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::DataQnA::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::DataQnA::V1alpha::AutoSuggestion.new

          # Call method
          response = client.suggest_queries(formatted_parent)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.suggest_queries(formatted_parent) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes suggest_queries with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::DataQnA::V1alpha::AutoSuggestionServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dataqna::V1alpha::SuggestQueriesRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:suggest_queries, mock_method)

      # Mock auth layer
      mock_credentials = MockAutoSuggestionServiceCredentials_v1alpha.new("suggest_queries")

      Google::Cloud::Dataqna::V1alpha::AutoSuggestionService::Stub.stub(:new, mock_stub) do
        Google::Cloud::DataQnA::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::DataQnA::V1alpha::AutoSuggestion.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.suggest_queries(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end