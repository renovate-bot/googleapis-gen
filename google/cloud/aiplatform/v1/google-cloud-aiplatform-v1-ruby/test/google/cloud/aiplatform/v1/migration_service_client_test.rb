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
require "google/cloud/aiplatform/v1/migration_service_client"
require "google/cloud/aiplatform/v1/migration_service_services_pb"
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

class MockMigrationServiceCredentials_v1 < Google::Cloud::Aiplatform::V1::Credentials
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

describe Google::Cloud::Aiplatform::V1::MigrationServiceClient do

  describe 'search_migratable_resources' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::MigrationServiceClient#search_migratable_resources."

    it 'invokes search_migratable_resources without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::MigrationServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      migratable_resources_element = {}
      migratable_resources = [migratable_resources_element]
      expected_response = { next_page_token: next_page_token, migratable_resources: migratable_resources }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::SearchMigratableResourcesResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::SearchMigratableResourcesRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:search_migratable_resources, mock_method)

      # Mock auth layer
      mock_credentials = MockMigrationServiceCredentials_v1.new("search_migratable_resources")

      Google::Cloud::Aiplatform::V1::MigrationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Migration.new(version: :v1)

          # Call method
          response = client.search_migratable_resources(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.migratable_resources.to_a, response.to_a)
        end
      end
    end

    it 'invokes search_migratable_resources with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::MigrationServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::SearchMigratableResourcesRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:search_migratable_resources, mock_method)

      # Mock auth layer
      mock_credentials = MockMigrationServiceCredentials_v1.new("search_migratable_resources")

      Google::Cloud::Aiplatform::V1::MigrationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Migration.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.search_migratable_resources(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'batch_migrate_resources' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::MigrationServiceClient#batch_migrate_resources."

    it 'invokes batch_migrate_resources without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::MigrationServiceClient.location_path("[PROJECT]", "[LOCATION]")
      migrate_resource_requests = []

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::BatchMigrateResourcesResponse)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/batch_migrate_resources_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::BatchMigrateResourcesRequest, request)
        assert_equal(formatted_parent, request.parent)
        migrate_resource_requests = migrate_resource_requests.map do |req|
          Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1::MigrateResourceRequest)
        end
        assert_equal(migrate_resource_requests, request.migrate_resource_requests)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:batch_migrate_resources, mock_method)

      # Mock auth layer
      mock_credentials = MockMigrationServiceCredentials_v1.new("batch_migrate_resources")

      Google::Cloud::Aiplatform::V1::MigrationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Migration.new(version: :v1)

          # Call method
          response = client.batch_migrate_resources(formatted_parent, migrate_resource_requests)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes batch_migrate_resources and returns an operation error.' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::MigrationServiceClient.location_path("[PROJECT]", "[LOCATION]")
      migrate_resource_requests = []

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Aiplatform::V1::MigrationServiceClient#batch_migrate_resources.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/batch_migrate_resources_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::BatchMigrateResourcesRequest, request)
        assert_equal(formatted_parent, request.parent)
        migrate_resource_requests = migrate_resource_requests.map do |req|
          Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1::MigrateResourceRequest)
        end
        assert_equal(migrate_resource_requests, request.migrate_resource_requests)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:batch_migrate_resources, mock_method)

      # Mock auth layer
      mock_credentials = MockMigrationServiceCredentials_v1.new("batch_migrate_resources")

      Google::Cloud::Aiplatform::V1::MigrationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Migration.new(version: :v1)

          # Call method
          response = client.batch_migrate_resources(formatted_parent, migrate_resource_requests)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes batch_migrate_resources with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::MigrationServiceClient.location_path("[PROJECT]", "[LOCATION]")
      migrate_resource_requests = []

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::BatchMigrateResourcesRequest, request)
        assert_equal(formatted_parent, request.parent)
        migrate_resource_requests = migrate_resource_requests.map do |req|
          Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1::MigrateResourceRequest)
        end
        assert_equal(migrate_resource_requests, request.migrate_resource_requests)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:batch_migrate_resources, mock_method)

      # Mock auth layer
      mock_credentials = MockMigrationServiceCredentials_v1.new("batch_migrate_resources")

      Google::Cloud::Aiplatform::V1::MigrationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Migration.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.batch_migrate_resources(formatted_parent, migrate_resource_requests)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end