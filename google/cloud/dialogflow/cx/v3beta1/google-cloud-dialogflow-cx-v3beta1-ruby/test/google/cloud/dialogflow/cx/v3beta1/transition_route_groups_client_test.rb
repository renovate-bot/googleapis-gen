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
require "google/cloud/dialogflow/cx/v3beta1/transition_route_groups_client"
require "google/cloud/dialogflow/cx/v3beta1/transition_route_group_services_pb"

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

class MockTransitionRouteGroupsCredentials_v3beta1 < Google::Cloud::Dialogflow::Cx::V3beta1::Credentials
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

describe Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroupsClient do

  describe 'list_transition_route_groups' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroupsClient#list_transition_route_groups."

    it 'invokes list_transition_route_groups without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroupsClient.flow_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")

      # Create expected grpc response
      next_page_token = ""
      transition_route_groups_element = {}
      transition_route_groups = [transition_route_groups_element]
      expected_response = { next_page_token: next_page_token, transition_route_groups: transition_route_groups }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3beta1::ListTransitionRouteGroupsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::ListTransitionRouteGroupsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:list_transition_route_groups, mock_method)

      # Mock auth layer
      mock_credentials = MockTransitionRouteGroupsCredentials_v3beta1.new("list_transition_route_groups")

      Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroups::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TransitionRouteGroups.new(version: :v3beta1)

          # Call method
          response = client.list_transition_route_groups(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.transition_route_groups.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_transition_route_groups with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroupsClient.flow_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::ListTransitionRouteGroupsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:list_transition_route_groups, mock_method)

      # Mock auth layer
      mock_credentials = MockTransitionRouteGroupsCredentials_v3beta1.new("list_transition_route_groups")

      Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroups::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TransitionRouteGroups.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.list_transition_route_groups(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_transition_route_group' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroupsClient#get_transition_route_group."

    it 'invokes get_transition_route_group without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroupsClient.transition_route_group_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      expected_response = { name: name_2, display_name: display_name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::GetTransitionRouteGroupRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:get_transition_route_group, mock_method)

      # Mock auth layer
      mock_credentials = MockTransitionRouteGroupsCredentials_v3beta1.new("get_transition_route_group")

      Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroups::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TransitionRouteGroups.new(version: :v3beta1)

          # Call method
          response = client.get_transition_route_group(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_transition_route_group(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_transition_route_group with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroupsClient.transition_route_group_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::GetTransitionRouteGroupRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:get_transition_route_group, mock_method)

      # Mock auth layer
      mock_credentials = MockTransitionRouteGroupsCredentials_v3beta1.new("get_transition_route_group")

      Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroups::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TransitionRouteGroups.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.get_transition_route_group(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_transition_route_group' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroupsClient#create_transition_route_group."

    it 'invokes create_transition_route_group without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroupsClient.flow_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")
      transition_route_group = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      expected_response = { name: name, display_name: display_name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::CreateTransitionRouteGroupRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(transition_route_group, Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup), request.transition_route_group)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:create_transition_route_group, mock_method)

      # Mock auth layer
      mock_credentials = MockTransitionRouteGroupsCredentials_v3beta1.new("create_transition_route_group")

      Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroups::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TransitionRouteGroups.new(version: :v3beta1)

          # Call method
          response = client.create_transition_route_group(formatted_parent, transition_route_group)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_transition_route_group(formatted_parent, transition_route_group) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_transition_route_group with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroupsClient.flow_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")
      transition_route_group = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::CreateTransitionRouteGroupRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(transition_route_group, Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup), request.transition_route_group)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:create_transition_route_group, mock_method)

      # Mock auth layer
      mock_credentials = MockTransitionRouteGroupsCredentials_v3beta1.new("create_transition_route_group")

      Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroups::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TransitionRouteGroups.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.create_transition_route_group(formatted_parent, transition_route_group)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_transition_route_group' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroupsClient#update_transition_route_group."

    it 'invokes update_transition_route_group without error' do
      # Create request parameters
      transition_route_group = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      expected_response = { name: name, display_name: display_name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::UpdateTransitionRouteGroupRequest, request)
        assert_equal(Google::Gax::to_proto(transition_route_group, Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup), request.transition_route_group)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:update_transition_route_group, mock_method)

      # Mock auth layer
      mock_credentials = MockTransitionRouteGroupsCredentials_v3beta1.new("update_transition_route_group")

      Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroups::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TransitionRouteGroups.new(version: :v3beta1)

          # Call method
          response = client.update_transition_route_group(transition_route_group)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_transition_route_group(transition_route_group) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_transition_route_group with error' do
      # Create request parameters
      transition_route_group = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::UpdateTransitionRouteGroupRequest, request)
        assert_equal(Google::Gax::to_proto(transition_route_group, Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup), request.transition_route_group)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:update_transition_route_group, mock_method)

      # Mock auth layer
      mock_credentials = MockTransitionRouteGroupsCredentials_v3beta1.new("update_transition_route_group")

      Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroups::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TransitionRouteGroups.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.update_transition_route_group(transition_route_group)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_transition_route_group' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroupsClient#delete_transition_route_group."

    it 'invokes delete_transition_route_group without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroupsClient.transition_route_group_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::DeleteTransitionRouteGroupRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:delete_transition_route_group, mock_method)

      # Mock auth layer
      mock_credentials = MockTransitionRouteGroupsCredentials_v3beta1.new("delete_transition_route_group")

      Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroups::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TransitionRouteGroups.new(version: :v3beta1)

          # Call method
          response = client.delete_transition_route_group(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_transition_route_group(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_transition_route_group with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroupsClient.transition_route_group_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::DeleteTransitionRouteGroupRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:delete_transition_route_group, mock_method)

      # Mock auth layer
      mock_credentials = MockTransitionRouteGroupsCredentials_v3beta1.new("delete_transition_route_group")

      Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroups::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::TransitionRouteGroups.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.delete_transition_route_group(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end