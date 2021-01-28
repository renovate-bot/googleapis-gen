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

require "google/cloud/gkehub"
require "google/cloud/gkehub/v1beta1/gke_hub_membership_service_client"
require "google/cloud/gkehub/v1beta1/membership_services_pb"
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

class MockGkeHubMembershipServiceCredentials_v1beta1 < Google::Cloud::Gkehub::V1beta1::Credentials
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

describe Google::Cloud::Gkehub::V1beta1::GkeHubMembershipServiceClient do

  describe 'list_memberships' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Gkehub::V1beta1::GkeHubMembershipServiceClient#list_memberships."

    it 'invokes list_memberships without error' do
      # Create request parameters
      parent = ''

      # Create expected grpc response
      next_page_token = ""
      resources_element = {}
      resources_2 = [resources_element]
      expected_response = { next_page_token: next_page_token, resources: resources_2 }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gkehub::V1beta1::ListMembershipsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gkehub::V1beta1::ListMembershipsRequest, request)
        assert_equal(parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_memberships, mock_method)

      # Mock auth layer
      mock_credentials = MockGkeHubMembershipServiceCredentials_v1beta1.new("list_memberships")

      Google::Cloud::Gkehub::V1beta1::GkeHubMembershipService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gkehub::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gkehub.new(version: :v1beta1)

          # Call method
          response = client.list_memberships(parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.resources.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_memberships with error' do
      # Create request parameters
      parent = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gkehub::V1beta1::ListMembershipsRequest, request)
        assert_equal(parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_memberships, mock_method)

      # Mock auth layer
      mock_credentials = MockGkeHubMembershipServiceCredentials_v1beta1.new("list_memberships")

      Google::Cloud::Gkehub::V1beta1::GkeHubMembershipService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gkehub::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gkehub.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.list_memberships(parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_membership' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Gkehub::V1beta1::GkeHubMembershipServiceClient#get_membership."

    it 'invokes get_membership without error' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      description = "description-1724546052"
      external_id = "externalId-1153075697"
      unique_id = "uniqueId-538310583"
      expected_response = {
        name: name_2,
        description: description,
        external_id: external_id,
        unique_id: unique_id
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gkehub::V1beta1::Membership)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gkehub::V1beta1::GetMembershipRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_membership, mock_method)

      # Mock auth layer
      mock_credentials = MockGkeHubMembershipServiceCredentials_v1beta1.new("get_membership")

      Google::Cloud::Gkehub::V1beta1::GkeHubMembershipService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gkehub::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gkehub.new(version: :v1beta1)

          # Call method
          response = client.get_membership(name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_membership(name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_membership with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gkehub::V1beta1::GetMembershipRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_membership, mock_method)

      # Mock auth layer
      mock_credentials = MockGkeHubMembershipServiceCredentials_v1beta1.new("get_membership")

      Google::Cloud::Gkehub::V1beta1::GkeHubMembershipService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gkehub::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gkehub.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.get_membership(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_membership' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Gkehub::V1beta1::GkeHubMembershipServiceClient#create_membership."

    it 'invokes create_membership without error' do
      # Create request parameters
      parent = ''
      membership_id = ''
      resource = {}

      # Create expected grpc response
      name = "name3373707"
      description = "description-1724546052"
      external_id = "externalId-1153075697"
      unique_id = "uniqueId-538310583"
      expected_response = {
        name: name,
        description: description,
        external_id: external_id,
        unique_id: unique_id
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gkehub::V1beta1::Membership)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_membership_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gkehub::V1beta1::CreateMembershipRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(membership_id, request.membership_id)
        assert_equal(Google::Gax::to_proto(resource, Google::Cloud::Gkehub::V1beta1::Membership), request.resource)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_membership, mock_method)

      # Mock auth layer
      mock_credentials = MockGkeHubMembershipServiceCredentials_v1beta1.new("create_membership")

      Google::Cloud::Gkehub::V1beta1::GkeHubMembershipService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gkehub::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gkehub.new(version: :v1beta1)

          # Call method
          response = client.create_membership(
            parent,
            membership_id,
            resource
          )

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes create_membership and returns an operation error.' do
      # Create request parameters
      parent = ''
      membership_id = ''
      resource = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Gkehub::V1beta1::GkeHubMembershipServiceClient#create_membership.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_membership_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gkehub::V1beta1::CreateMembershipRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(membership_id, request.membership_id)
        assert_equal(Google::Gax::to_proto(resource, Google::Cloud::Gkehub::V1beta1::Membership), request.resource)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_membership, mock_method)

      # Mock auth layer
      mock_credentials = MockGkeHubMembershipServiceCredentials_v1beta1.new("create_membership")

      Google::Cloud::Gkehub::V1beta1::GkeHubMembershipService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gkehub::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gkehub.new(version: :v1beta1)

          # Call method
          response = client.create_membership(
            parent,
            membership_id,
            resource
          )

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes create_membership with error' do
      # Create request parameters
      parent = ''
      membership_id = ''
      resource = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gkehub::V1beta1::CreateMembershipRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(membership_id, request.membership_id)
        assert_equal(Google::Gax::to_proto(resource, Google::Cloud::Gkehub::V1beta1::Membership), request.resource)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_membership, mock_method)

      # Mock auth layer
      mock_credentials = MockGkeHubMembershipServiceCredentials_v1beta1.new("create_membership")

      Google::Cloud::Gkehub::V1beta1::GkeHubMembershipService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gkehub::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gkehub.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.create_membership(
              parent,
              membership_id,
              resource
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_membership' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Gkehub::V1beta1::GkeHubMembershipServiceClient#delete_membership."

    it 'invokes delete_membership without error' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Protobuf::Empty)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_membership_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gkehub::V1beta1::DeleteMembershipRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_membership, mock_method)

      # Mock auth layer
      mock_credentials = MockGkeHubMembershipServiceCredentials_v1beta1.new("delete_membership")

      Google::Cloud::Gkehub::V1beta1::GkeHubMembershipService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gkehub::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gkehub.new(version: :v1beta1)

          # Call method
          response = client.delete_membership(name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes delete_membership and returns an operation error.' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Gkehub::V1beta1::GkeHubMembershipServiceClient#delete_membership.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_membership_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gkehub::V1beta1::DeleteMembershipRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_membership, mock_method)

      # Mock auth layer
      mock_credentials = MockGkeHubMembershipServiceCredentials_v1beta1.new("delete_membership")

      Google::Cloud::Gkehub::V1beta1::GkeHubMembershipService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gkehub::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gkehub.new(version: :v1beta1)

          # Call method
          response = client.delete_membership(name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes delete_membership with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gkehub::V1beta1::DeleteMembershipRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_membership, mock_method)

      # Mock auth layer
      mock_credentials = MockGkeHubMembershipServiceCredentials_v1beta1.new("delete_membership")

      Google::Cloud::Gkehub::V1beta1::GkeHubMembershipService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gkehub::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gkehub.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.delete_membership(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_membership' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Gkehub::V1beta1::GkeHubMembershipServiceClient#update_membership."

    it 'invokes update_membership without error' do
      # Create request parameters
      name = ''
      update_mask = {}
      resource = {}

      # Create expected grpc response
      name_2 = "name2-1052831874"
      description = "description-1724546052"
      external_id = "externalId-1153075697"
      unique_id = "uniqueId-538310583"
      expected_response = {
        name: name_2,
        description: description,
        external_id: external_id,
        unique_id: unique_id
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gkehub::V1beta1::Membership)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_membership_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gkehub::V1beta1::UpdateMembershipRequest, request)
        assert_equal(name, request.name)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        assert_equal(Google::Gax::to_proto(resource, Google::Cloud::Gkehub::V1beta1::Membership), request.resource)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_membership, mock_method)

      # Mock auth layer
      mock_credentials = MockGkeHubMembershipServiceCredentials_v1beta1.new("update_membership")

      Google::Cloud::Gkehub::V1beta1::GkeHubMembershipService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gkehub::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gkehub.new(version: :v1beta1)

          # Call method
          response = client.update_membership(
            name,
            update_mask,
            resource
          )

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes update_membership and returns an operation error.' do
      # Create request parameters
      name = ''
      update_mask = {}
      resource = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Gkehub::V1beta1::GkeHubMembershipServiceClient#update_membership.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_membership_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gkehub::V1beta1::UpdateMembershipRequest, request)
        assert_equal(name, request.name)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        assert_equal(Google::Gax::to_proto(resource, Google::Cloud::Gkehub::V1beta1::Membership), request.resource)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_membership, mock_method)

      # Mock auth layer
      mock_credentials = MockGkeHubMembershipServiceCredentials_v1beta1.new("update_membership")

      Google::Cloud::Gkehub::V1beta1::GkeHubMembershipService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gkehub::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gkehub.new(version: :v1beta1)

          # Call method
          response = client.update_membership(
            name,
            update_mask,
            resource
          )

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes update_membership with error' do
      # Create request parameters
      name = ''
      update_mask = {}
      resource = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gkehub::V1beta1::UpdateMembershipRequest, request)
        assert_equal(name, request.name)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        assert_equal(Google::Gax::to_proto(resource, Google::Cloud::Gkehub::V1beta1::Membership), request.resource)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_membership, mock_method)

      # Mock auth layer
      mock_credentials = MockGkeHubMembershipServiceCredentials_v1beta1.new("update_membership")

      Google::Cloud::Gkehub::V1beta1::GkeHubMembershipService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gkehub::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gkehub.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.update_membership(
              name,
              update_mask,
              resource
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'generate_connect_manifest' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Gkehub::V1beta1::GkeHubMembershipServiceClient#generate_connect_manifest."

    it 'invokes generate_connect_manifest without error' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gkehub::V1beta1::GenerateConnectManifestResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gkehub::V1beta1::GenerateConnectManifestRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:generate_connect_manifest, mock_method)

      # Mock auth layer
      mock_credentials = MockGkeHubMembershipServiceCredentials_v1beta1.new("generate_connect_manifest")

      Google::Cloud::Gkehub::V1beta1::GkeHubMembershipService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gkehub::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gkehub.new(version: :v1beta1)

          # Call method
          response = client.generate_connect_manifest(name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.generate_connect_manifest(name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes generate_connect_manifest with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gkehub::V1beta1::GenerateConnectManifestRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:generate_connect_manifest, mock_method)

      # Mock auth layer
      mock_credentials = MockGkeHubMembershipServiceCredentials_v1beta1.new("generate_connect_manifest")

      Google::Cloud::Gkehub::V1beta1::GkeHubMembershipService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gkehub::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gkehub.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.generate_connect_manifest(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'validate_exclusivity' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Gkehub::V1beta1::GkeHubMembershipServiceClient#validate_exclusivity."

    it 'invokes validate_exclusivity without error' do
      # Create request parameters
      parent = ''
      intended_membership = ''

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gkehub::V1beta1::ValidateExclusivityResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gkehub::V1beta1::ValidateExclusivityRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(intended_membership, request.intended_membership)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:validate_exclusivity, mock_method)

      # Mock auth layer
      mock_credentials = MockGkeHubMembershipServiceCredentials_v1beta1.new("validate_exclusivity")

      Google::Cloud::Gkehub::V1beta1::GkeHubMembershipService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gkehub::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gkehub.new(version: :v1beta1)

          # Call method
          response = client.validate_exclusivity(parent, intended_membership)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.validate_exclusivity(parent, intended_membership) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes validate_exclusivity with error' do
      # Create request parameters
      parent = ''
      intended_membership = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gkehub::V1beta1::ValidateExclusivityRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(intended_membership, request.intended_membership)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:validate_exclusivity, mock_method)

      # Mock auth layer
      mock_credentials = MockGkeHubMembershipServiceCredentials_v1beta1.new("validate_exclusivity")

      Google::Cloud::Gkehub::V1beta1::GkeHubMembershipService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gkehub::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gkehub.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.validate_exclusivity(parent, intended_membership)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'generate_exclusivity_manifest' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Gkehub::V1beta1::GkeHubMembershipServiceClient#generate_exclusivity_manifest."

    it 'invokes generate_exclusivity_manifest without error' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      crd_manifest = "crdManifest-1050075815"
      cr_manifest = "crManifest1783881727"
      expected_response = { crd_manifest: crd_manifest, cr_manifest: cr_manifest }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gkehub::V1beta1::GenerateExclusivityManifestResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gkehub::V1beta1::GenerateExclusivityManifestRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:generate_exclusivity_manifest, mock_method)

      # Mock auth layer
      mock_credentials = MockGkeHubMembershipServiceCredentials_v1beta1.new("generate_exclusivity_manifest")

      Google::Cloud::Gkehub::V1beta1::GkeHubMembershipService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gkehub::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gkehub.new(version: :v1beta1)

          # Call method
          response = client.generate_exclusivity_manifest(name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.generate_exclusivity_manifest(name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes generate_exclusivity_manifest with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gkehub::V1beta1::GenerateExclusivityManifestRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:generate_exclusivity_manifest, mock_method)

      # Mock auth layer
      mock_credentials = MockGkeHubMembershipServiceCredentials_v1beta1.new("generate_exclusivity_manifest")

      Google::Cloud::Gkehub::V1beta1::GkeHubMembershipService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Gkehub::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Gkehub.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.generate_exclusivity_manifest(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end