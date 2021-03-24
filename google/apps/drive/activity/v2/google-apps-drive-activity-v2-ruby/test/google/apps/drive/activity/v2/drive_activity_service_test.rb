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

require "google/apps/drive/activity/v2/drive_activity_service_pb"
require "google/apps/drive/activity/v2/drive_activity_service_services_pb"
require "google/apps/drive/activity/v2/drive_activity_service"

class ::Google::Apps::Drive::Activity::V2::DriveActivityService::ClientTest < Minitest::Test
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

  def test_query_drive_activity
    # Create GRPC objects.
    grpc_response = ::Google::Apps::Drive::Activity::V2::QueryDriveActivityResponse.new
    grpc_operation = GRPC::ActiveCall::Operation.new nil
    grpc_channel = GRPC::Core::Channel.new "localhost:8888", nil, :this_channel_is_insecure
    grpc_options = {}

    # Create request parameters for a unary method.
    item_name = "hello world"
    consolidation_strategy = {}
    page_size = 42
    page_token = "hello world"
    filter = "hello world"

    query_drive_activity_client_stub = ClientStub.new grpc_response, grpc_operation do |name, request, options:|
      assert_equal :query_drive_activity, name
      assert_kind_of ::Google::Apps::Drive::Activity::V2::QueryDriveActivityRequest, request
      assert_equal "hello world", request["item_name"]
      assert_equal :item_name, request.key
      assert_equal Gapic::Protobuf.coerce({}, to: ::Google::Apps::Drive::Activity::V2::ConsolidationStrategy), request["consolidation_strategy"]
      assert_equal 42, request["page_size"]
      assert_equal "hello world", request["page_token"]
      assert_equal "hello world", request["filter"]
      refute_nil options
    end

    Gapic::ServiceStub.stub :new, query_drive_activity_client_stub do
      # Create client
      client = ::Google::Apps::Drive::Activity::V2::DriveActivityService::Client.new do |config|
        config.credentials = grpc_channel
      end

      # Use hash object
      client.query_drive_activity({ item_name: item_name, consolidation_strategy: consolidation_strategy, page_size: page_size, page_token: page_token, filter: filter }) do |response, operation|
        assert_kind_of Gapic::PagedEnumerable, response
        assert_equal grpc_response, response.response
        assert_equal grpc_operation, operation
      end

      # Use named arguments
      client.query_drive_activity item_name: item_name, consolidation_strategy: consolidation_strategy, page_size: page_size, page_token: page_token, filter: filter do |response, operation|
        assert_kind_of Gapic::PagedEnumerable, response
        assert_equal grpc_response, response.response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object
      client.query_drive_activity ::Google::Apps::Drive::Activity::V2::QueryDriveActivityRequest.new(item_name: item_name, consolidation_strategy: consolidation_strategy, page_size: page_size, page_token: page_token, filter: filter) do |response, operation|
        assert_kind_of Gapic::PagedEnumerable, response
        assert_equal grpc_response, response.response
        assert_equal grpc_operation, operation
      end

      # Use hash object with options
      client.query_drive_activity({ item_name: item_name, consolidation_strategy: consolidation_strategy, page_size: page_size, page_token: page_token, filter: filter }, grpc_options) do |response, operation|
        assert_kind_of Gapic::PagedEnumerable, response
        assert_equal grpc_response, response.response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object with options
      client.query_drive_activity(::Google::Apps::Drive::Activity::V2::QueryDriveActivityRequest.new(item_name: item_name, consolidation_strategy: consolidation_strategy, page_size: page_size, page_token: page_token, filter: filter), grpc_options) do |response, operation|
        assert_kind_of Gapic::PagedEnumerable, response
        assert_equal grpc_response, response.response
        assert_equal grpc_operation, operation
      end

      # Verify method calls
      assert_equal 5, query_drive_activity_client_stub.call_rpc_count
    end
  end

  def test_configure
    grpc_channel = GRPC::Core::Channel.new "localhost:8888", nil, :this_channel_is_insecure

    client = block_config = config = nil
    Gapic::ServiceStub.stub :new, nil do
      client = ::Google::Apps::Drive::Activity::V2::DriveActivityService::Client.new do |config|
        config.credentials = grpc_channel
      end
    end

    config = client.configure do |c|
      block_config = c
    end

    assert_same block_config, config
    assert_kind_of ::Google::Apps::Drive::Activity::V2::DriveActivityService::Client::Configuration, config
  end
end
