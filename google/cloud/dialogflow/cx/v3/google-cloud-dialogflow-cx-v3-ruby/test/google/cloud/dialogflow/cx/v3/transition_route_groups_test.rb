# frozen_string_literal: true

# Copyright 2021 Google LLC
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

# Auto-generated by gapic-generator-ruby. DO NOT EDIT!

require "helper"

require "gapic/grpc/service_stub"

require "google/cloud/dialogflow/cx/v3/transition_route_group_pb"
require "google/cloud/dialogflow/cx/v3/transition_route_group_services_pb"
require "google/cloud/dialogflow/cx/v3/transition_route_groups"

class ::Google::Cloud::Dialogflow::Cx::V3::TransitionRouteGroups::ClientTest < Minitest::Test
  class ClientStub
    attr_accessor :call_rpc_count, :requests

    def initialize response, operation, &block
      @response = response
      @operation = operation
      @block = block
      @call_rpc_count = 0
      @requests = []
    end

    def call_rpc *args, **kwargs
      @call_rpc_count += 1

      @requests << @block&.call(*args, **kwargs)

      yield @response, @operation if block_given?

      @response
    end
  end

  def test_list_transition_route_groups
    # Create GRPC objects.
    grpc_response = ::Google::Cloud::Dialogflow::Cx::V3::ListTransitionRouteGroupsResponse.new
    grpc_operation = GRPC::ActiveCall::Operation.new nil
    grpc_channel = GRPC::Core::Channel.new "localhost:8888", nil, :this_channel_is_insecure
    grpc_options = {}

    # Create request parameters for a unary method.
    parent = "hello world"
    page_size = 42
    page_token = "hello world"
    language_code = "hello world"

    list_transition_route_groups_client_stub = ClientStub.new grpc_response, grpc_operation do |name, request, options:|
      assert_equal :list_transition_route_groups, name
      assert_kind_of ::Google::Cloud::Dialogflow::Cx::V3::ListTransitionRouteGroupsRequest, request
      assert_equal "hello world", request["parent"]
      assert_equal 42, request["page_size"]
      assert_equal "hello world", request["page_token"]
      assert_equal "hello world", request["language_code"]
      refute_nil options
    end

    Gapic::ServiceStub.stub :new, list_transition_route_groups_client_stub do
      # Create client
      client = ::Google::Cloud::Dialogflow::Cx::V3::TransitionRouteGroups::Client.new do |config|
        config.credentials = grpc_channel
      end

      # Use hash object
      client.list_transition_route_groups({ parent: parent, page_size: page_size, page_token: page_token, language_code: language_code }) do |response, operation|
        assert_kind_of Gapic::PagedEnumerable, response
        assert_equal grpc_response, response.response
        assert_equal grpc_operation, operation
      end

      # Use named arguments
      client.list_transition_route_groups parent: parent, page_size: page_size, page_token: page_token, language_code: language_code do |response, operation|
        assert_kind_of Gapic::PagedEnumerable, response
        assert_equal grpc_response, response.response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object
      client.list_transition_route_groups ::Google::Cloud::Dialogflow::Cx::V3::ListTransitionRouteGroupsRequest.new(parent: parent, page_size: page_size, page_token: page_token, language_code: language_code) do |response, operation|
        assert_kind_of Gapic::PagedEnumerable, response
        assert_equal grpc_response, response.response
        assert_equal grpc_operation, operation
      end

      # Use hash object with options
      client.list_transition_route_groups({ parent: parent, page_size: page_size, page_token: page_token, language_code: language_code }, grpc_options) do |response, operation|
        assert_kind_of Gapic::PagedEnumerable, response
        assert_equal grpc_response, response.response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object with options
      client.list_transition_route_groups(::Google::Cloud::Dialogflow::Cx::V3::ListTransitionRouteGroupsRequest.new(parent: parent, page_size: page_size, page_token: page_token, language_code: language_code), grpc_options) do |response, operation|
        assert_kind_of Gapic::PagedEnumerable, response
        assert_equal grpc_response, response.response
        assert_equal grpc_operation, operation
      end

      # Verify method calls
      assert_equal 5, list_transition_route_groups_client_stub.call_rpc_count
    end
  end

  def test_get_transition_route_group
    # Create GRPC objects.
    grpc_response = ::Google::Cloud::Dialogflow::Cx::V3::TransitionRouteGroup.new
    grpc_operation = GRPC::ActiveCall::Operation.new nil
    grpc_channel = GRPC::Core::Channel.new "localhost:8888", nil, :this_channel_is_insecure
    grpc_options = {}

    # Create request parameters for a unary method.
    name = "hello world"
    language_code = "hello world"

    get_transition_route_group_client_stub = ClientStub.new grpc_response, grpc_operation do |name, request, options:|
      assert_equal :get_transition_route_group, name
      assert_kind_of ::Google::Cloud::Dialogflow::Cx::V3::GetTransitionRouteGroupRequest, request
      assert_equal "hello world", request["name"]
      assert_equal "hello world", request["language_code"]
      refute_nil options
    end

    Gapic::ServiceStub.stub :new, get_transition_route_group_client_stub do
      # Create client
      client = ::Google::Cloud::Dialogflow::Cx::V3::TransitionRouteGroups::Client.new do |config|
        config.credentials = grpc_channel
      end

      # Use hash object
      client.get_transition_route_group({ name: name, language_code: language_code }) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use named arguments
      client.get_transition_route_group name: name, language_code: language_code do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object
      client.get_transition_route_group ::Google::Cloud::Dialogflow::Cx::V3::GetTransitionRouteGroupRequest.new(name: name, language_code: language_code) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use hash object with options
      client.get_transition_route_group({ name: name, language_code: language_code }, grpc_options) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object with options
      client.get_transition_route_group(::Google::Cloud::Dialogflow::Cx::V3::GetTransitionRouteGroupRequest.new(name: name, language_code: language_code), grpc_options) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Verify method calls
      assert_equal 5, get_transition_route_group_client_stub.call_rpc_count
    end
  end

  def test_create_transition_route_group
    # Create GRPC objects.
    grpc_response = ::Google::Cloud::Dialogflow::Cx::V3::TransitionRouteGroup.new
    grpc_operation = GRPC::ActiveCall::Operation.new nil
    grpc_channel = GRPC::Core::Channel.new "localhost:8888", nil, :this_channel_is_insecure
    grpc_options = {}

    # Create request parameters for a unary method.
    parent = "hello world"
    transition_route_group = {}
    language_code = "hello world"

    create_transition_route_group_client_stub = ClientStub.new grpc_response, grpc_operation do |name, request, options:|
      assert_equal :create_transition_route_group, name
      assert_kind_of ::Google::Cloud::Dialogflow::Cx::V3::CreateTransitionRouteGroupRequest, request
      assert_equal "hello world", request["parent"]
      assert_equal Gapic::Protobuf.coerce({}, to: ::Google::Cloud::Dialogflow::Cx::V3::TransitionRouteGroup), request["transition_route_group"]
      assert_equal "hello world", request["language_code"]
      refute_nil options
    end

    Gapic::ServiceStub.stub :new, create_transition_route_group_client_stub do
      # Create client
      client = ::Google::Cloud::Dialogflow::Cx::V3::TransitionRouteGroups::Client.new do |config|
        config.credentials = grpc_channel
      end

      # Use hash object
      client.create_transition_route_group({ parent: parent, transition_route_group: transition_route_group, language_code: language_code }) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use named arguments
      client.create_transition_route_group parent: parent, transition_route_group: transition_route_group, language_code: language_code do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object
      client.create_transition_route_group ::Google::Cloud::Dialogflow::Cx::V3::CreateTransitionRouteGroupRequest.new(parent: parent, transition_route_group: transition_route_group, language_code: language_code) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use hash object with options
      client.create_transition_route_group({ parent: parent, transition_route_group: transition_route_group, language_code: language_code }, grpc_options) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object with options
      client.create_transition_route_group(::Google::Cloud::Dialogflow::Cx::V3::CreateTransitionRouteGroupRequest.new(parent: parent, transition_route_group: transition_route_group, language_code: language_code), grpc_options) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Verify method calls
      assert_equal 5, create_transition_route_group_client_stub.call_rpc_count
    end
  end

  def test_update_transition_route_group
    # Create GRPC objects.
    grpc_response = ::Google::Cloud::Dialogflow::Cx::V3::TransitionRouteGroup.new
    grpc_operation = GRPC::ActiveCall::Operation.new nil
    grpc_channel = GRPC::Core::Channel.new "localhost:8888", nil, :this_channel_is_insecure
    grpc_options = {}

    # Create request parameters for a unary method.
    transition_route_group = {}
    update_mask = {}
    language_code = "hello world"

    update_transition_route_group_client_stub = ClientStub.new grpc_response, grpc_operation do |name, request, options:|
      assert_equal :update_transition_route_group, name
      assert_kind_of ::Google::Cloud::Dialogflow::Cx::V3::UpdateTransitionRouteGroupRequest, request
      assert_equal Gapic::Protobuf.coerce({}, to: ::Google::Cloud::Dialogflow::Cx::V3::TransitionRouteGroup), request["transition_route_group"]
      assert_equal Gapic::Protobuf.coerce({}, to: ::Google::Protobuf::FieldMask), request["update_mask"]
      assert_equal "hello world", request["language_code"]
      refute_nil options
    end

    Gapic::ServiceStub.stub :new, update_transition_route_group_client_stub do
      # Create client
      client = ::Google::Cloud::Dialogflow::Cx::V3::TransitionRouteGroups::Client.new do |config|
        config.credentials = grpc_channel
      end

      # Use hash object
      client.update_transition_route_group({ transition_route_group: transition_route_group, update_mask: update_mask, language_code: language_code }) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use named arguments
      client.update_transition_route_group transition_route_group: transition_route_group, update_mask: update_mask, language_code: language_code do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object
      client.update_transition_route_group ::Google::Cloud::Dialogflow::Cx::V3::UpdateTransitionRouteGroupRequest.new(transition_route_group: transition_route_group, update_mask: update_mask, language_code: language_code) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use hash object with options
      client.update_transition_route_group({ transition_route_group: transition_route_group, update_mask: update_mask, language_code: language_code }, grpc_options) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object with options
      client.update_transition_route_group(::Google::Cloud::Dialogflow::Cx::V3::UpdateTransitionRouteGroupRequest.new(transition_route_group: transition_route_group, update_mask: update_mask, language_code: language_code), grpc_options) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Verify method calls
      assert_equal 5, update_transition_route_group_client_stub.call_rpc_count
    end
  end

  def test_delete_transition_route_group
    # Create GRPC objects.
    grpc_response = ::Google::Protobuf::Empty.new
    grpc_operation = GRPC::ActiveCall::Operation.new nil
    grpc_channel = GRPC::Core::Channel.new "localhost:8888", nil, :this_channel_is_insecure
    grpc_options = {}

    # Create request parameters for a unary method.
    name = "hello world"
    force = true

    delete_transition_route_group_client_stub = ClientStub.new grpc_response, grpc_operation do |name, request, options:|
      assert_equal :delete_transition_route_group, name
      assert_kind_of ::Google::Cloud::Dialogflow::Cx::V3::DeleteTransitionRouteGroupRequest, request
      assert_equal "hello world", request["name"]
      assert_equal true, request["force"]
      refute_nil options
    end

    Gapic::ServiceStub.stub :new, delete_transition_route_group_client_stub do
      # Create client
      client = ::Google::Cloud::Dialogflow::Cx::V3::TransitionRouteGroups::Client.new do |config|
        config.credentials = grpc_channel
      end

      # Use hash object
      client.delete_transition_route_group({ name: name, force: force }) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use named arguments
      client.delete_transition_route_group name: name, force: force do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object
      client.delete_transition_route_group ::Google::Cloud::Dialogflow::Cx::V3::DeleteTransitionRouteGroupRequest.new(name: name, force: force) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use hash object with options
      client.delete_transition_route_group({ name: name, force: force }, grpc_options) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object with options
      client.delete_transition_route_group(::Google::Cloud::Dialogflow::Cx::V3::DeleteTransitionRouteGroupRequest.new(name: name, force: force), grpc_options) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Verify method calls
      assert_equal 5, delete_transition_route_group_client_stub.call_rpc_count
    end
  end

  def test_configure
    grpc_channel = GRPC::Core::Channel.new "localhost:8888", nil, :this_channel_is_insecure

    client = block_config = config = nil
    Gapic::ServiceStub.stub :new, nil do
      client = ::Google::Cloud::Dialogflow::Cx::V3::TransitionRouteGroups::Client.new do |config|
        config.credentials = grpc_channel
      end
    end

    config = client.configure do |c|
      block_config = c
    end

    assert_same block_config, config
    assert_kind_of ::Google::Cloud::Dialogflow::Cx::V3::TransitionRouteGroups::Client::Configuration, config
  end
end
