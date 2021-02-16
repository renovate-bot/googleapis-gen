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

require "google/devtools/clouddebugger/v2/controller_pb"
require "google/devtools/clouddebugger/v2/controller_services_pb"
require "google/cloud/debugger/v2/controller"

class ::Google::Cloud::Debugger::V2::Controller::ClientTest < Minitest::Test
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

  def test_register_debuggee
    # Create GRPC objects.
    grpc_response = ::Google::Cloud::Debugger::V2::RegisterDebuggeeResponse.new
    grpc_operation = GRPC::ActiveCall::Operation.new nil
    grpc_channel = GRPC::Core::Channel.new "localhost:8888", nil, :this_channel_is_insecure
    grpc_options = {}

    # Create request parameters for a unary method.
    debuggee = {}

    register_debuggee_client_stub = ClientStub.new grpc_response, grpc_operation do |name, request, options:|
      assert_equal :register_debuggee, name
      assert_kind_of ::Google::Cloud::Debugger::V2::RegisterDebuggeeRequest, request
      assert_equal Gapic::Protobuf.coerce({}, to: ::Google::Cloud::Debugger::V2::Debuggee), request["debuggee"]
      refute_nil options
    end

    Gapic::ServiceStub.stub :new, register_debuggee_client_stub do
      # Create client
      client = ::Google::Cloud::Debugger::V2::Controller::Client.new do |config|
        config.credentials = grpc_channel
      end

      # Use hash object
      client.register_debuggee({ debuggee: debuggee }) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use named arguments
      client.register_debuggee debuggee: debuggee do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object
      client.register_debuggee ::Google::Cloud::Debugger::V2::RegisterDebuggeeRequest.new(debuggee: debuggee) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use hash object with options
      client.register_debuggee({ debuggee: debuggee }, grpc_options) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object with options
      client.register_debuggee ::Google::Cloud::Debugger::V2::RegisterDebuggeeRequest.new(debuggee: debuggee), grpc_options do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Verify method calls
      assert_equal 5, register_debuggee_client_stub.call_rpc_count
    end
  end

  def test_list_active_breakpoints
    # Create GRPC objects.
    grpc_response = ::Google::Cloud::Debugger::V2::ListActiveBreakpointsResponse.new
    grpc_operation = GRPC::ActiveCall::Operation.new nil
    grpc_channel = GRPC::Core::Channel.new "localhost:8888", nil, :this_channel_is_insecure
    grpc_options = {}

    # Create request parameters for a unary method.
    debuggee_id = "hello world"
    wait_token = "hello world"
    success_on_timeout = true

    list_active_breakpoints_client_stub = ClientStub.new grpc_response, grpc_operation do |name, request, options:|
      assert_equal :list_active_breakpoints, name
      assert_kind_of ::Google::Cloud::Debugger::V2::ListActiveBreakpointsRequest, request
      assert_equal "hello world", request["debuggee_id"]
      assert_equal "hello world", request["wait_token"]
      assert_equal true, request["success_on_timeout"]
      refute_nil options
    end

    Gapic::ServiceStub.stub :new, list_active_breakpoints_client_stub do
      # Create client
      client = ::Google::Cloud::Debugger::V2::Controller::Client.new do |config|
        config.credentials = grpc_channel
      end

      # Use hash object
      client.list_active_breakpoints({ debuggee_id: debuggee_id, wait_token: wait_token, success_on_timeout: success_on_timeout }) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use named arguments
      client.list_active_breakpoints debuggee_id: debuggee_id, wait_token: wait_token, success_on_timeout: success_on_timeout do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object
      client.list_active_breakpoints ::Google::Cloud::Debugger::V2::ListActiveBreakpointsRequest.new(debuggee_id: debuggee_id, wait_token: wait_token, success_on_timeout: success_on_timeout) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use hash object with options
      client.list_active_breakpoints({ debuggee_id: debuggee_id, wait_token: wait_token, success_on_timeout: success_on_timeout }, grpc_options) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object with options
      client.list_active_breakpoints ::Google::Cloud::Debugger::V2::ListActiveBreakpointsRequest.new(debuggee_id: debuggee_id, wait_token: wait_token, success_on_timeout: success_on_timeout), grpc_options do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Verify method calls
      assert_equal 5, list_active_breakpoints_client_stub.call_rpc_count
    end
  end

  def test_update_active_breakpoint
    # Create GRPC objects.
    grpc_response = ::Google::Cloud::Debugger::V2::UpdateActiveBreakpointResponse.new
    grpc_operation = GRPC::ActiveCall::Operation.new nil
    grpc_channel = GRPC::Core::Channel.new "localhost:8888", nil, :this_channel_is_insecure
    grpc_options = {}

    # Create request parameters for a unary method.
    debuggee_id = "hello world"
    breakpoint = {}

    update_active_breakpoint_client_stub = ClientStub.new grpc_response, grpc_operation do |name, request, options:|
      assert_equal :update_active_breakpoint, name
      assert_kind_of ::Google::Cloud::Debugger::V2::UpdateActiveBreakpointRequest, request
      assert_equal "hello world", request["debuggee_id"]
      assert_equal Gapic::Protobuf.coerce({}, to: ::Google::Cloud::Debugger::V2::Breakpoint), request["breakpoint"]
      refute_nil options
    end

    Gapic::ServiceStub.stub :new, update_active_breakpoint_client_stub do
      # Create client
      client = ::Google::Cloud::Debugger::V2::Controller::Client.new do |config|
        config.credentials = grpc_channel
      end

      # Use hash object
      client.update_active_breakpoint({ debuggee_id: debuggee_id, breakpoint: breakpoint }) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use named arguments
      client.update_active_breakpoint debuggee_id: debuggee_id, breakpoint: breakpoint do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object
      client.update_active_breakpoint ::Google::Cloud::Debugger::V2::UpdateActiveBreakpointRequest.new(debuggee_id: debuggee_id, breakpoint: breakpoint) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use hash object with options
      client.update_active_breakpoint({ debuggee_id: debuggee_id, breakpoint: breakpoint }, grpc_options) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object with options
      client.update_active_breakpoint ::Google::Cloud::Debugger::V2::UpdateActiveBreakpointRequest.new(debuggee_id: debuggee_id, breakpoint: breakpoint), grpc_options do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Verify method calls
      assert_equal 5, update_active_breakpoint_client_stub.call_rpc_count
    end
  end

  def test_configure
    grpc_channel = GRPC::Core::Channel.new "localhost:8888", nil, :this_channel_is_insecure

    client = block_config = config = nil
    Gapic::ServiceStub.stub :new, nil do
      client = ::Google::Cloud::Debugger::V2::Controller::Client.new do |config|
        config.credentials = grpc_channel
      end
    end

    config = client.configure do |c|
      block_config = c
    end

    assert_same block_config, config
    assert_kind_of ::Google::Cloud::Debugger::V2::Controller::Client::Configuration, config
  end
end