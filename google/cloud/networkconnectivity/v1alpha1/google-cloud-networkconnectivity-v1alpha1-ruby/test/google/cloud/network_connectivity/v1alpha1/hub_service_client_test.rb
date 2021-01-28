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

require "google/cloud/network_connectivity"
require "google/cloud/network_connectivity/v1alpha1/hub_service_client"
require "google/cloud/networkconnectivity/v1alpha1/hub_services_pb"
require "google/longrunning/operations_pb"

class CustomTestError_v1alpha1 < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v1alpha1

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

class MockHubServiceCredentials_v1alpha1 < Google::Cloud::NetworkConnectivity::V1alpha1::Credentials
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

describe Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient do

  describe 'list_hubs' do
    custom_error = CustomTestError_v1alpha1.new "Custom test error for Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient#list_hubs."

    it 'invokes list_hubs without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      hubs_element = {}
      hubs = [hubs_element]
      expected_response = { next_page_token: next_page_token, hubs: hubs }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Networkconnectivity::V1alpha1::ListHubsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Networkconnectivity::V1alpha1::ListHubsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:list_hubs, mock_method)

      # Mock auth layer
      mock_credentials = MockHubServiceCredentials_v1alpha1.new("list_hubs")

      Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.stub(:new, mock_stub) do
        Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)

          # Call method
          response = client.list_hubs(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.hubs.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_hubs with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Networkconnectivity::V1alpha1::ListHubsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:list_hubs, mock_method)

      # Mock auth layer
      mock_credentials = MockHubServiceCredentials_v1alpha1.new("list_hubs")

      Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.stub(:new, mock_stub) do
        Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha1 do
            client.list_hubs(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_hub' do
    custom_error = CustomTestError_v1alpha1.new "Custom test error for Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient#get_hub."

    it 'invokes get_hub without error' do
      # Create request parameters
      formatted_name = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.hub_path("[PROJECT]", "[HUB]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      description = "description-1724546052"
      unique_id = "uniqueId-538310583"
      expected_response = {
        name: name_2,
        description: description,
        unique_id: unique_id
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Networkconnectivity::V1alpha1::Hub)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Networkconnectivity::V1alpha1::GetHubRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:get_hub, mock_method)

      # Mock auth layer
      mock_credentials = MockHubServiceCredentials_v1alpha1.new("get_hub")

      Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.stub(:new, mock_stub) do
        Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)

          # Call method
          response = client.get_hub(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_hub(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_hub with error' do
      # Create request parameters
      formatted_name = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.hub_path("[PROJECT]", "[HUB]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Networkconnectivity::V1alpha1::GetHubRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:get_hub, mock_method)

      # Mock auth layer
      mock_credentials = MockHubServiceCredentials_v1alpha1.new("get_hub")

      Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.stub(:new, mock_stub) do
        Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha1 do
            client.get_hub(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_hub' do
    custom_error = CustomTestError_v1alpha1.new "Custom test error for Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient#create_hub."

    it 'invokes create_hub without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.location_path("[PROJECT]", "[LOCATION]")
      hub = {}

      # Create expected grpc response
      name = "name3373707"
      description = "description-1724546052"
      unique_id = "uniqueId-538310583"
      expected_response = {
        name: name,
        description: description,
        unique_id: unique_id
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Networkconnectivity::V1alpha1::Hub)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_hub_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Networkconnectivity::V1alpha1::CreateHubRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(hub, Google::Cloud::Networkconnectivity::V1alpha1::Hub), request.hub)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:create_hub, mock_method)

      # Mock auth layer
      mock_credentials = MockHubServiceCredentials_v1alpha1.new("create_hub")

      Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.stub(:new, mock_stub) do
        Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)

          # Call method
          response = client.create_hub(formatted_parent, hub)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes create_hub and returns an operation error.' do
      # Create request parameters
      formatted_parent = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.location_path("[PROJECT]", "[LOCATION]")
      hub = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient#create_hub.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_hub_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Networkconnectivity::V1alpha1::CreateHubRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(hub, Google::Cloud::Networkconnectivity::V1alpha1::Hub), request.hub)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:create_hub, mock_method)

      # Mock auth layer
      mock_credentials = MockHubServiceCredentials_v1alpha1.new("create_hub")

      Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.stub(:new, mock_stub) do
        Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)

          # Call method
          response = client.create_hub(formatted_parent, hub)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes create_hub with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.location_path("[PROJECT]", "[LOCATION]")
      hub = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Networkconnectivity::V1alpha1::CreateHubRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(hub, Google::Cloud::Networkconnectivity::V1alpha1::Hub), request.hub)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:create_hub, mock_method)

      # Mock auth layer
      mock_credentials = MockHubServiceCredentials_v1alpha1.new("create_hub")

      Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.stub(:new, mock_stub) do
        Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha1 do
            client.create_hub(formatted_parent, hub)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_hub' do
    custom_error = CustomTestError_v1alpha1.new "Custom test error for Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient#update_hub."

    it 'invokes update_hub without error' do
      # Create request parameters
      hub = {}

      # Create expected grpc response
      name = "name3373707"
      description = "description-1724546052"
      unique_id = "uniqueId-538310583"
      expected_response = {
        name: name,
        description: description,
        unique_id: unique_id
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Networkconnectivity::V1alpha1::Hub)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_hub_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Networkconnectivity::V1alpha1::UpdateHubRequest, request)
        assert_equal(Google::Gax::to_proto(hub, Google::Cloud::Networkconnectivity::V1alpha1::Hub), request.hub)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:update_hub, mock_method)

      # Mock auth layer
      mock_credentials = MockHubServiceCredentials_v1alpha1.new("update_hub")

      Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.stub(:new, mock_stub) do
        Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)

          # Call method
          response = client.update_hub(hub)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes update_hub and returns an operation error.' do
      # Create request parameters
      hub = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient#update_hub.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_hub_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Networkconnectivity::V1alpha1::UpdateHubRequest, request)
        assert_equal(Google::Gax::to_proto(hub, Google::Cloud::Networkconnectivity::V1alpha1::Hub), request.hub)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:update_hub, mock_method)

      # Mock auth layer
      mock_credentials = MockHubServiceCredentials_v1alpha1.new("update_hub")

      Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.stub(:new, mock_stub) do
        Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)

          # Call method
          response = client.update_hub(hub)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes update_hub with error' do
      # Create request parameters
      hub = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Networkconnectivity::V1alpha1::UpdateHubRequest, request)
        assert_equal(Google::Gax::to_proto(hub, Google::Cloud::Networkconnectivity::V1alpha1::Hub), request.hub)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:update_hub, mock_method)

      # Mock auth layer
      mock_credentials = MockHubServiceCredentials_v1alpha1.new("update_hub")

      Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.stub(:new, mock_stub) do
        Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha1 do
            client.update_hub(hub)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_hub' do
    custom_error = CustomTestError_v1alpha1.new "Custom test error for Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient#delete_hub."

    it 'invokes delete_hub without error' do
      # Create request parameters
      formatted_name = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.hub_path("[PROJECT]", "[HUB]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Protobuf::Empty)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_hub_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Networkconnectivity::V1alpha1::DeleteHubRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:delete_hub, mock_method)

      # Mock auth layer
      mock_credentials = MockHubServiceCredentials_v1alpha1.new("delete_hub")

      Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.stub(:new, mock_stub) do
        Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)

          # Call method
          response = client.delete_hub(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes delete_hub and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.hub_path("[PROJECT]", "[HUB]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient#delete_hub.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_hub_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Networkconnectivity::V1alpha1::DeleteHubRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:delete_hub, mock_method)

      # Mock auth layer
      mock_credentials = MockHubServiceCredentials_v1alpha1.new("delete_hub")

      Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.stub(:new, mock_stub) do
        Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)

          # Call method
          response = client.delete_hub(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes delete_hub with error' do
      # Create request parameters
      formatted_name = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.hub_path("[PROJECT]", "[HUB]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Networkconnectivity::V1alpha1::DeleteHubRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:delete_hub, mock_method)

      # Mock auth layer
      mock_credentials = MockHubServiceCredentials_v1alpha1.new("delete_hub")

      Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.stub(:new, mock_stub) do
        Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha1 do
            client.delete_hub(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_spokes' do
    custom_error = CustomTestError_v1alpha1.new "Custom test error for Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient#list_spokes."

    it 'invokes list_spokes without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      spokes_element = {}
      spokes = [spokes_element]
      expected_response = { next_page_token: next_page_token, spokes: spokes }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Networkconnectivity::V1alpha1::ListSpokesResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Networkconnectivity::V1alpha1::ListSpokesRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:list_spokes, mock_method)

      # Mock auth layer
      mock_credentials = MockHubServiceCredentials_v1alpha1.new("list_spokes")

      Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.stub(:new, mock_stub) do
        Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)

          # Call method
          response = client.list_spokes(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.spokes.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_spokes with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Networkconnectivity::V1alpha1::ListSpokesRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:list_spokes, mock_method)

      # Mock auth layer
      mock_credentials = MockHubServiceCredentials_v1alpha1.new("list_spokes")

      Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.stub(:new, mock_stub) do
        Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha1 do
            client.list_spokes(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_spoke' do
    custom_error = CustomTestError_v1alpha1.new "Custom test error for Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient#get_spoke."

    it 'invokes get_spoke without error' do
      # Create request parameters
      formatted_name = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.spoke_path("[PROJECT]", "[LOCATION]", "[SPOKE]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      description = "description-1724546052"
      hub = "hub103669"
      unique_id = "uniqueId-538310583"
      expected_response = {
        name: name_2,
        description: description,
        hub: hub,
        unique_id: unique_id
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Networkconnectivity::V1alpha1::Spoke)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Networkconnectivity::V1alpha1::GetSpokeRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:get_spoke, mock_method)

      # Mock auth layer
      mock_credentials = MockHubServiceCredentials_v1alpha1.new("get_spoke")

      Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.stub(:new, mock_stub) do
        Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)

          # Call method
          response = client.get_spoke(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_spoke(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_spoke with error' do
      # Create request parameters
      formatted_name = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.spoke_path("[PROJECT]", "[LOCATION]", "[SPOKE]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Networkconnectivity::V1alpha1::GetSpokeRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:get_spoke, mock_method)

      # Mock auth layer
      mock_credentials = MockHubServiceCredentials_v1alpha1.new("get_spoke")

      Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.stub(:new, mock_stub) do
        Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha1 do
            client.get_spoke(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_spoke' do
    custom_error = CustomTestError_v1alpha1.new "Custom test error for Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient#create_spoke."

    it 'invokes create_spoke without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.location_path("[PROJECT]", "[LOCATION]")
      spoke = {}

      # Create expected grpc response
      name = "name3373707"
      description = "description-1724546052"
      hub = "hub103669"
      unique_id = "uniqueId-538310583"
      expected_response = {
        name: name,
        description: description,
        hub: hub,
        unique_id: unique_id
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Networkconnectivity::V1alpha1::Spoke)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_spoke_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Networkconnectivity::V1alpha1::CreateSpokeRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(spoke, Google::Cloud::Networkconnectivity::V1alpha1::Spoke), request.spoke)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:create_spoke, mock_method)

      # Mock auth layer
      mock_credentials = MockHubServiceCredentials_v1alpha1.new("create_spoke")

      Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.stub(:new, mock_stub) do
        Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)

          # Call method
          response = client.create_spoke(formatted_parent, spoke)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes create_spoke and returns an operation error.' do
      # Create request parameters
      formatted_parent = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.location_path("[PROJECT]", "[LOCATION]")
      spoke = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient#create_spoke.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_spoke_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Networkconnectivity::V1alpha1::CreateSpokeRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(spoke, Google::Cloud::Networkconnectivity::V1alpha1::Spoke), request.spoke)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:create_spoke, mock_method)

      # Mock auth layer
      mock_credentials = MockHubServiceCredentials_v1alpha1.new("create_spoke")

      Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.stub(:new, mock_stub) do
        Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)

          # Call method
          response = client.create_spoke(formatted_parent, spoke)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes create_spoke with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.location_path("[PROJECT]", "[LOCATION]")
      spoke = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Networkconnectivity::V1alpha1::CreateSpokeRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(spoke, Google::Cloud::Networkconnectivity::V1alpha1::Spoke), request.spoke)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:create_spoke, mock_method)

      # Mock auth layer
      mock_credentials = MockHubServiceCredentials_v1alpha1.new("create_spoke")

      Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.stub(:new, mock_stub) do
        Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha1 do
            client.create_spoke(formatted_parent, spoke)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_spoke' do
    custom_error = CustomTestError_v1alpha1.new "Custom test error for Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient#update_spoke."

    it 'invokes update_spoke without error' do
      # Create request parameters
      spoke = {}

      # Create expected grpc response
      name = "name3373707"
      description = "description-1724546052"
      hub = "hub103669"
      unique_id = "uniqueId-538310583"
      expected_response = {
        name: name,
        description: description,
        hub: hub,
        unique_id: unique_id
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Networkconnectivity::V1alpha1::Spoke)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_spoke_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Networkconnectivity::V1alpha1::UpdateSpokeRequest, request)
        assert_equal(Google::Gax::to_proto(spoke, Google::Cloud::Networkconnectivity::V1alpha1::Spoke), request.spoke)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:update_spoke, mock_method)

      # Mock auth layer
      mock_credentials = MockHubServiceCredentials_v1alpha1.new("update_spoke")

      Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.stub(:new, mock_stub) do
        Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)

          # Call method
          response = client.update_spoke(spoke)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes update_spoke and returns an operation error.' do
      # Create request parameters
      spoke = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient#update_spoke.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_spoke_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Networkconnectivity::V1alpha1::UpdateSpokeRequest, request)
        assert_equal(Google::Gax::to_proto(spoke, Google::Cloud::Networkconnectivity::V1alpha1::Spoke), request.spoke)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:update_spoke, mock_method)

      # Mock auth layer
      mock_credentials = MockHubServiceCredentials_v1alpha1.new("update_spoke")

      Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.stub(:new, mock_stub) do
        Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)

          # Call method
          response = client.update_spoke(spoke)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes update_spoke with error' do
      # Create request parameters
      spoke = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Networkconnectivity::V1alpha1::UpdateSpokeRequest, request)
        assert_equal(Google::Gax::to_proto(spoke, Google::Cloud::Networkconnectivity::V1alpha1::Spoke), request.spoke)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:update_spoke, mock_method)

      # Mock auth layer
      mock_credentials = MockHubServiceCredentials_v1alpha1.new("update_spoke")

      Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.stub(:new, mock_stub) do
        Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha1 do
            client.update_spoke(spoke)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_spoke' do
    custom_error = CustomTestError_v1alpha1.new "Custom test error for Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient#delete_spoke."

    it 'invokes delete_spoke without error' do
      # Create request parameters
      formatted_name = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.spoke_path("[PROJECT]", "[LOCATION]", "[SPOKE]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Protobuf::Empty)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_spoke_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Networkconnectivity::V1alpha1::DeleteSpokeRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:delete_spoke, mock_method)

      # Mock auth layer
      mock_credentials = MockHubServiceCredentials_v1alpha1.new("delete_spoke")

      Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.stub(:new, mock_stub) do
        Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)

          # Call method
          response = client.delete_spoke(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes delete_spoke and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.spoke_path("[PROJECT]", "[LOCATION]", "[SPOKE]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient#delete_spoke.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_spoke_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Networkconnectivity::V1alpha1::DeleteSpokeRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:delete_spoke, mock_method)

      # Mock auth layer
      mock_credentials = MockHubServiceCredentials_v1alpha1.new("delete_spoke")

      Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.stub(:new, mock_stub) do
        Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)

          # Call method
          response = client.delete_spoke(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes delete_spoke with error' do
      # Create request parameters
      formatted_name = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.spoke_path("[PROJECT]", "[LOCATION]", "[SPOKE]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Networkconnectivity::V1alpha1::DeleteSpokeRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha1.new(:delete_spoke, mock_method)

      # Mock auth layer
      mock_credentials = MockHubServiceCredentials_v1alpha1.new("delete_spoke")

      Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.stub(:new, mock_stub) do
        Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha1 do
            client.delete_spoke(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end