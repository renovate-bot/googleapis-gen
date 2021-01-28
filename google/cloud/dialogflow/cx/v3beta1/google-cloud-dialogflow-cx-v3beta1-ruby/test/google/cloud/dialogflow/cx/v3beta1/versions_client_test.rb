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

require "google/cloud/dialogflow/cx"
require "google/cloud/dialogflow/cx/v3beta1/versions_client"
require "google/cloud/dialogflow/cx/v3beta1/version_services_pb"
require "google/longrunning/operations_pb"

class CustomTestError_v3beta1 < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v3beta1

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

class MockVersionsCredentials_v3beta1 < Google::Cloud::Dialogflow::Cx::V3beta1::Credentials
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

describe Google::Cloud::Dialogflow::Cx::V3beta1::VersionsClient do

  describe 'list_versions' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::VersionsClient#list_versions."

    it 'invokes list_versions without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::VersionsClient.flow_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")

      # Create expected grpc response
      next_page_token = ""
      versions_element = {}
      versions = [versions_element]
      expected_response = { next_page_token: next_page_token, versions: versions }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3beta1::ListVersionsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::ListVersionsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:list_versions, mock_method)

      # Mock auth layer
      mock_credentials = MockVersionsCredentials_v3beta1.new("list_versions")

      Google::Cloud::Dialogflow::Cx::V3beta1::Versions::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Versions.new(version: :v3beta1)

          # Call method
          response = client.list_versions(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.versions.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_versions with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::VersionsClient.flow_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::ListVersionsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:list_versions, mock_method)

      # Mock auth layer
      mock_credentials = MockVersionsCredentials_v3beta1.new("list_versions")

      Google::Cloud::Dialogflow::Cx::V3beta1::Versions::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Versions.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.list_versions(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_version' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::VersionsClient#get_version."

    it 'invokes get_version without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::VersionsClient.version_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      expected_response = {
        name: name_2,
        display_name: display_name,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3beta1::Version)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::GetVersionRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:get_version, mock_method)

      # Mock auth layer
      mock_credentials = MockVersionsCredentials_v3beta1.new("get_version")

      Google::Cloud::Dialogflow::Cx::V3beta1::Versions::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Versions.new(version: :v3beta1)

          # Call method
          response = client.get_version(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_version(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_version with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::VersionsClient.version_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::GetVersionRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:get_version, mock_method)

      # Mock auth layer
      mock_credentials = MockVersionsCredentials_v3beta1.new("get_version")

      Google::Cloud::Dialogflow::Cx::V3beta1::Versions::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Versions.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.get_version(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_version' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::VersionsClient#create_version."

    it 'invokes create_version without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::VersionsClient.flow_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")
      version = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      expected_response = {
        name: name,
        display_name: display_name,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3beta1::Version)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_version_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::CreateVersionRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(version, Google::Cloud::Dialogflow::Cx::V3beta1::Version), request.version)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:create_version, mock_method)

      # Mock auth layer
      mock_credentials = MockVersionsCredentials_v3beta1.new("create_version")

      Google::Cloud::Dialogflow::Cx::V3beta1::Versions::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Versions.new(version: :v3beta1)

          # Call method
          response = client.create_version(formatted_parent, version)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes create_version and returns an operation error.' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::VersionsClient.flow_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")
      version = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Dialogflow::Cx::V3beta1::VersionsClient#create_version.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_version_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::CreateVersionRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(version, Google::Cloud::Dialogflow::Cx::V3beta1::Version), request.version)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:create_version, mock_method)

      # Mock auth layer
      mock_credentials = MockVersionsCredentials_v3beta1.new("create_version")

      Google::Cloud::Dialogflow::Cx::V3beta1::Versions::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Versions.new(version: :v3beta1)

          # Call method
          response = client.create_version(formatted_parent, version)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes create_version with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::VersionsClient.flow_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")
      version = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::CreateVersionRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(version, Google::Cloud::Dialogflow::Cx::V3beta1::Version), request.version)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:create_version, mock_method)

      # Mock auth layer
      mock_credentials = MockVersionsCredentials_v3beta1.new("create_version")

      Google::Cloud::Dialogflow::Cx::V3beta1::Versions::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Versions.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.create_version(formatted_parent, version)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_version' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::VersionsClient#update_version."

    it 'invokes update_version without error' do
      # Create request parameters
      version = {}
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      expected_response = {
        name: name,
        display_name: display_name,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3beta1::Version)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::UpdateVersionRequest, request)
        assert_equal(Google::Gax::to_proto(version, Google::Cloud::Dialogflow::Cx::V3beta1::Version), request.version)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:update_version, mock_method)

      # Mock auth layer
      mock_credentials = MockVersionsCredentials_v3beta1.new("update_version")

      Google::Cloud::Dialogflow::Cx::V3beta1::Versions::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Versions.new(version: :v3beta1)

          # Call method
          response = client.update_version(version, update_mask)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_version(version, update_mask) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_version with error' do
      # Create request parameters
      version = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::UpdateVersionRequest, request)
        assert_equal(Google::Gax::to_proto(version, Google::Cloud::Dialogflow::Cx::V3beta1::Version), request.version)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:update_version, mock_method)

      # Mock auth layer
      mock_credentials = MockVersionsCredentials_v3beta1.new("update_version")

      Google::Cloud::Dialogflow::Cx::V3beta1::Versions::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Versions.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.update_version(version, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_version' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::VersionsClient#delete_version."

    it 'invokes delete_version without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::VersionsClient.version_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::DeleteVersionRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:delete_version, mock_method)

      # Mock auth layer
      mock_credentials = MockVersionsCredentials_v3beta1.new("delete_version")

      Google::Cloud::Dialogflow::Cx::V3beta1::Versions::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Versions.new(version: :v3beta1)

          # Call method
          response = client.delete_version(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_version(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_version with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::VersionsClient.version_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::DeleteVersionRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:delete_version, mock_method)

      # Mock auth layer
      mock_credentials = MockVersionsCredentials_v3beta1.new("delete_version")

      Google::Cloud::Dialogflow::Cx::V3beta1::Versions::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Versions.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.delete_version(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'load_version' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::VersionsClient#load_version."

    it 'invokes load_version without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::VersionsClient.version_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Protobuf::Empty)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/load_version_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::LoadVersionRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:load_version, mock_method)

      # Mock auth layer
      mock_credentials = MockVersionsCredentials_v3beta1.new("load_version")

      Google::Cloud::Dialogflow::Cx::V3beta1::Versions::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Versions.new(version: :v3beta1)

          # Call method
          response = client.load_version(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes load_version and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::VersionsClient.version_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Dialogflow::Cx::V3beta1::VersionsClient#load_version.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/load_version_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::LoadVersionRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:load_version, mock_method)

      # Mock auth layer
      mock_credentials = MockVersionsCredentials_v3beta1.new("load_version")

      Google::Cloud::Dialogflow::Cx::V3beta1::Versions::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Versions.new(version: :v3beta1)

          # Call method
          response = client.load_version(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes load_version with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::VersionsClient.version_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::LoadVersionRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:load_version, mock_method)

      # Mock auth layer
      mock_credentials = MockVersionsCredentials_v3beta1.new("load_version")

      Google::Cloud::Dialogflow::Cx::V3beta1::Versions::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Versions.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.load_version(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end