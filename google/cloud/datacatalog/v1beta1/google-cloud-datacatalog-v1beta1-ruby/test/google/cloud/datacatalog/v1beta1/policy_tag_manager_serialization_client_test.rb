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

require "google/cloud/datacatalog"
require "google/cloud/datacatalog/v1beta1/policy_tag_manager_serialization_client"
require "google/cloud/datacatalog/v1beta1/policytagmanagerserialization_services_pb"

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

class MockPolicyTagManagerSerializationCredentials_v1beta1 < Google::Cloud::Datacatalog::V1beta1::Credentials
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

describe Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerSerializationClient do

  describe 'import_taxonomies' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerSerializationClient#import_taxonomies."

    it 'invokes import_taxonomies without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerSerializationClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::ImportTaxonomiesResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::ImportTaxonomiesRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:import_taxonomies, mock_method)

      # Mock auth layer
      mock_credentials = MockPolicyTagManagerSerializationCredentials_v1beta1.new("import_taxonomies")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerSerialization::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManagerSerialization.new(version: :v1beta1)

          # Call method
          response = client.import_taxonomies(formatted_parent)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.import_taxonomies(formatted_parent) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes import_taxonomies with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerSerializationClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::ImportTaxonomiesRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:import_taxonomies, mock_method)

      # Mock auth layer
      mock_credentials = MockPolicyTagManagerSerializationCredentials_v1beta1.new("import_taxonomies")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerSerialization::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManagerSerialization.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.import_taxonomies(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'export_taxonomies' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerSerializationClient#export_taxonomies."

    it 'invokes export_taxonomies without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerSerializationClient.location_path("[PROJECT]", "[LOCATION]")
      formatted_taxonomies = []

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Datacatalog::V1beta1::ExportTaxonomiesResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::ExportTaxonomiesRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(formatted_taxonomies, request.taxonomies)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:export_taxonomies, mock_method)

      # Mock auth layer
      mock_credentials = MockPolicyTagManagerSerializationCredentials_v1beta1.new("export_taxonomies")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerSerialization::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManagerSerialization.new(version: :v1beta1)

          # Call method
          response = client.export_taxonomies(formatted_parent, formatted_taxonomies)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.export_taxonomies(formatted_parent, formatted_taxonomies) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes export_taxonomies with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerSerializationClient.location_path("[PROJECT]", "[LOCATION]")
      formatted_taxonomies = []

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Datacatalog::V1beta1::ExportTaxonomiesRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(formatted_taxonomies, request.taxonomies)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:export_taxonomies, mock_method)

      # Mock auth layer
      mock_credentials = MockPolicyTagManagerSerializationCredentials_v1beta1.new("export_taxonomies")

      Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerSerialization::Stub.stub(:new, mock_stub) do
        Google::Cloud::Datacatalog::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Datacatalog::PolicyTagManagerSerialization.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.export_taxonomies(formatted_parent, formatted_taxonomies)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end