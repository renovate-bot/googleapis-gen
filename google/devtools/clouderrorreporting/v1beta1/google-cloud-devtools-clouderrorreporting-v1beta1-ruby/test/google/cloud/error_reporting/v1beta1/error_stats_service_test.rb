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

require "google/devtools/clouderrorreporting/v1beta1/error_stats_service_pb"
require "google/devtools/clouderrorreporting/v1beta1/error_stats_service_services_pb"
require "google/cloud/error_reporting/v1beta1/error_stats_service"

class ::Google::Cloud::ErrorReporting::V1beta1::ErrorStatsService::ClientTest < Minitest::Test
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

  def test_list_group_stats
    # Create GRPC objects.
    grpc_response = ::Google::Cloud::ErrorReporting::V1beta1::ListGroupStatsResponse.new
    grpc_operation = GRPC::ActiveCall::Operation.new nil
    grpc_channel = GRPC::Core::Channel.new "localhost:8888", nil, :this_channel_is_insecure
    grpc_options = {}

    # Create request parameters for a unary method.
    project_name = "hello world"
    group_id = ["hello world"]
    service_filter = {}
    time_range = {}
    timed_count_duration = {}
    alignment = :ERROR_COUNT_ALIGNMENT_UNSPECIFIED
    alignment_time = {}
    order = :GROUP_ORDER_UNSPECIFIED
    page_size = 42
    page_token = "hello world"

    list_group_stats_client_stub = ClientStub.new grpc_response, grpc_operation do |name, request, options:|
      assert_equal :list_group_stats, name
      assert_kind_of ::Google::Cloud::ErrorReporting::V1beta1::ListGroupStatsRequest, request
      assert_equal "hello world", request["project_name"]
      assert_equal ["hello world"], request["group_id"]
      assert_equal Gapic::Protobuf.coerce({}, to: ::Google::Cloud::ErrorReporting::V1beta1::ServiceContextFilter), request["service_filter"]
      assert_equal Gapic::Protobuf.coerce({}, to: ::Google::Cloud::ErrorReporting::V1beta1::QueryTimeRange), request["time_range"]
      assert_equal Gapic::Protobuf.coerce({}, to: ::Google::Protobuf::Duration), request["timed_count_duration"]
      assert_equal :ERROR_COUNT_ALIGNMENT_UNSPECIFIED, request["alignment"]
      assert_equal Gapic::Protobuf.coerce({}, to: ::Google::Protobuf::Timestamp), request["alignment_time"]
      assert_equal :GROUP_ORDER_UNSPECIFIED, request["order"]
      assert_equal 42, request["page_size"]
      assert_equal "hello world", request["page_token"]
      refute_nil options
    end

    Gapic::ServiceStub.stub :new, list_group_stats_client_stub do
      # Create client
      client = ::Google::Cloud::ErrorReporting::V1beta1::ErrorStatsService::Client.new do |config|
        config.credentials = grpc_channel
      end

      # Use hash object
      client.list_group_stats({ project_name: project_name, group_id: group_id, service_filter: service_filter, time_range: time_range, timed_count_duration: timed_count_duration, alignment: alignment, alignment_time: alignment_time, order: order, page_size: page_size, page_token: page_token }) do |response, operation|
        assert_kind_of Gapic::PagedEnumerable, response
        assert_equal grpc_response, response.response
        assert_equal grpc_operation, operation
      end

      # Use named arguments
      client.list_group_stats project_name: project_name, group_id: group_id, service_filter: service_filter, time_range: time_range, timed_count_duration: timed_count_duration, alignment: alignment, alignment_time: alignment_time, order: order, page_size: page_size, page_token: page_token do |response, operation|
        assert_kind_of Gapic::PagedEnumerable, response
        assert_equal grpc_response, response.response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object
      client.list_group_stats ::Google::Cloud::ErrorReporting::V1beta1::ListGroupStatsRequest.new(project_name: project_name, group_id: group_id, service_filter: service_filter, time_range: time_range, timed_count_duration: timed_count_duration, alignment: alignment, alignment_time: alignment_time, order: order, page_size: page_size, page_token: page_token) do |response, operation|
        assert_kind_of Gapic::PagedEnumerable, response
        assert_equal grpc_response, response.response
        assert_equal grpc_operation, operation
      end

      # Use hash object with options
      client.list_group_stats({ project_name: project_name, group_id: group_id, service_filter: service_filter, time_range: time_range, timed_count_duration: timed_count_duration, alignment: alignment, alignment_time: alignment_time, order: order, page_size: page_size, page_token: page_token }, grpc_options) do |response, operation|
        assert_kind_of Gapic::PagedEnumerable, response
        assert_equal grpc_response, response.response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object with options
      client.list_group_stats ::Google::Cloud::ErrorReporting::V1beta1::ListGroupStatsRequest.new(project_name: project_name, group_id: group_id, service_filter: service_filter, time_range: time_range, timed_count_duration: timed_count_duration, alignment: alignment, alignment_time: alignment_time, order: order, page_size: page_size, page_token: page_token), grpc_options do |response, operation|
        assert_kind_of Gapic::PagedEnumerable, response
        assert_equal grpc_response, response.response
        assert_equal grpc_operation, operation
      end

      # Verify method calls
      assert_equal 5, list_group_stats_client_stub.call_rpc_count
    end
  end

  def test_list_events
    # Create GRPC objects.
    grpc_response = ::Google::Cloud::ErrorReporting::V1beta1::ListEventsResponse.new
    grpc_operation = GRPC::ActiveCall::Operation.new nil
    grpc_channel = GRPC::Core::Channel.new "localhost:8888", nil, :this_channel_is_insecure
    grpc_options = {}

    # Create request parameters for a unary method.
    project_name = "hello world"
    group_id = "hello world"
    service_filter = {}
    time_range = {}
    page_size = 42
    page_token = "hello world"

    list_events_client_stub = ClientStub.new grpc_response, grpc_operation do |name, request, options:|
      assert_equal :list_events, name
      assert_kind_of ::Google::Cloud::ErrorReporting::V1beta1::ListEventsRequest, request
      assert_equal "hello world", request["project_name"]
      assert_equal "hello world", request["group_id"]
      assert_equal Gapic::Protobuf.coerce({}, to: ::Google::Cloud::ErrorReporting::V1beta1::ServiceContextFilter), request["service_filter"]
      assert_equal Gapic::Protobuf.coerce({}, to: ::Google::Cloud::ErrorReporting::V1beta1::QueryTimeRange), request["time_range"]
      assert_equal 42, request["page_size"]
      assert_equal "hello world", request["page_token"]
      refute_nil options
    end

    Gapic::ServiceStub.stub :new, list_events_client_stub do
      # Create client
      client = ::Google::Cloud::ErrorReporting::V1beta1::ErrorStatsService::Client.new do |config|
        config.credentials = grpc_channel
      end

      # Use hash object
      client.list_events({ project_name: project_name, group_id: group_id, service_filter: service_filter, time_range: time_range, page_size: page_size, page_token: page_token }) do |response, operation|
        assert_kind_of Gapic::PagedEnumerable, response
        assert_equal grpc_response, response.response
        assert_equal grpc_operation, operation
      end

      # Use named arguments
      client.list_events project_name: project_name, group_id: group_id, service_filter: service_filter, time_range: time_range, page_size: page_size, page_token: page_token do |response, operation|
        assert_kind_of Gapic::PagedEnumerable, response
        assert_equal grpc_response, response.response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object
      client.list_events ::Google::Cloud::ErrorReporting::V1beta1::ListEventsRequest.new(project_name: project_name, group_id: group_id, service_filter: service_filter, time_range: time_range, page_size: page_size, page_token: page_token) do |response, operation|
        assert_kind_of Gapic::PagedEnumerable, response
        assert_equal grpc_response, response.response
        assert_equal grpc_operation, operation
      end

      # Use hash object with options
      client.list_events({ project_name: project_name, group_id: group_id, service_filter: service_filter, time_range: time_range, page_size: page_size, page_token: page_token }, grpc_options) do |response, operation|
        assert_kind_of Gapic::PagedEnumerable, response
        assert_equal grpc_response, response.response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object with options
      client.list_events ::Google::Cloud::ErrorReporting::V1beta1::ListEventsRequest.new(project_name: project_name, group_id: group_id, service_filter: service_filter, time_range: time_range, page_size: page_size, page_token: page_token), grpc_options do |response, operation|
        assert_kind_of Gapic::PagedEnumerable, response
        assert_equal grpc_response, response.response
        assert_equal grpc_operation, operation
      end

      # Verify method calls
      assert_equal 5, list_events_client_stub.call_rpc_count
    end
  end

  def test_delete_events
    # Create GRPC objects.
    grpc_response = ::Google::Cloud::ErrorReporting::V1beta1::DeleteEventsResponse.new
    grpc_operation = GRPC::ActiveCall::Operation.new nil
    grpc_channel = GRPC::Core::Channel.new "localhost:8888", nil, :this_channel_is_insecure
    grpc_options = {}

    # Create request parameters for a unary method.
    project_name = "hello world"

    delete_events_client_stub = ClientStub.new grpc_response, grpc_operation do |name, request, options:|
      assert_equal :delete_events, name
      assert_kind_of ::Google::Cloud::ErrorReporting::V1beta1::DeleteEventsRequest, request
      assert_equal "hello world", request["project_name"]
      refute_nil options
    end

    Gapic::ServiceStub.stub :new, delete_events_client_stub do
      # Create client
      client = ::Google::Cloud::ErrorReporting::V1beta1::ErrorStatsService::Client.new do |config|
        config.credentials = grpc_channel
      end

      # Use hash object
      client.delete_events({ project_name: project_name }) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use named arguments
      client.delete_events project_name: project_name do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object
      client.delete_events ::Google::Cloud::ErrorReporting::V1beta1::DeleteEventsRequest.new(project_name: project_name) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use hash object with options
      client.delete_events({ project_name: project_name }, grpc_options) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object with options
      client.delete_events ::Google::Cloud::ErrorReporting::V1beta1::DeleteEventsRequest.new(project_name: project_name), grpc_options do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Verify method calls
      assert_equal 5, delete_events_client_stub.call_rpc_count
    end
  end

  def test_configure
    grpc_channel = GRPC::Core::Channel.new "localhost:8888", nil, :this_channel_is_insecure

    client = block_config = config = nil
    Gapic::ServiceStub.stub :new, nil do
      client = ::Google::Cloud::ErrorReporting::V1beta1::ErrorStatsService::Client.new do |config|
        config.credentials = grpc_channel
      end
    end

    config = client.configure do |c|
      block_config = c
    end

    assert_same block_config, config
    assert_kind_of ::Google::Cloud::ErrorReporting::V1beta1::ErrorStatsService::Client::Configuration, config
  end
end