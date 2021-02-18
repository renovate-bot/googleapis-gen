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

require "google/analytics/data/v1beta/analytics_data_api_pb"
require "google/analytics/data/v1beta/analytics_data_api_services_pb"
require "google/analytics/data/v1beta/beta_analytics_data"

class ::Google::Analytics::Data::V1beta::BetaAnalyticsData::ClientTest < Minitest::Test
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

  def test_run_report
    # Create GRPC objects.
    grpc_response = ::Google::Analytics::Data::V1beta::RunReportResponse.new
    grpc_operation = GRPC::ActiveCall::Operation.new nil
    grpc_channel = GRPC::Core::Channel.new "localhost:8888", nil, :this_channel_is_insecure
    grpc_options = {}

    # Create request parameters for a unary method.
    property = "hello world"
    dimensions = [{}]
    metrics = [{}]
    date_ranges = [{}]
    dimension_filter = {}
    metric_filter = {}
    page_size = 42
    page_token = "hello world"
    metric_aggregations = [:METRIC_AGGREGATION_UNSPECIFIED]
    order_bys = [{}]
    currency_code = "hello world"
    cohort_spec = {}
    keep_empty_rows = true
    return_property_quota = true

    run_report_client_stub = ClientStub.new grpc_response, grpc_operation do |name, request, options:|
      assert_equal :run_report, name
      assert_kind_of ::Google::Analytics::Data::V1beta::RunReportRequest, request
      assert_equal "hello world", request["property"]
      assert_kind_of ::Google::Analytics::Data::V1beta::Dimension, request["dimensions"].first
      assert_kind_of ::Google::Analytics::Data::V1beta::Metric, request["metrics"].first
      assert_kind_of ::Google::Analytics::Data::V1beta::DateRange, request["date_ranges"].first
      assert_equal Gapic::Protobuf.coerce({}, to: ::Google::Analytics::Data::V1beta::FilterExpression), request["dimension_filter"]
      assert_equal Gapic::Protobuf.coerce({}, to: ::Google::Analytics::Data::V1beta::FilterExpression), request["metric_filter"]
      assert_equal 42, request["page_size"]
      assert_equal "hello world", request["page_token"]
      assert_equal [:METRIC_AGGREGATION_UNSPECIFIED], request["metric_aggregations"]
      assert_kind_of ::Google::Analytics::Data::V1beta::OrderBy, request["order_bys"].first
      assert_equal "hello world", request["currency_code"]
      assert_equal Gapic::Protobuf.coerce({}, to: ::Google::Analytics::Data::V1beta::CohortSpec), request["cohort_spec"]
      assert_equal true, request["keep_empty_rows"]
      assert_equal true, request["return_property_quota"]
      refute_nil options
    end

    Gapic::ServiceStub.stub :new, run_report_client_stub do
      # Create client
      client = ::Google::Analytics::Data::V1beta::BetaAnalyticsData::Client.new do |config|
        config.credentials = grpc_channel
      end

      # Use hash object
      client.run_report({ property: property, dimensions: dimensions, metrics: metrics, date_ranges: date_ranges, dimension_filter: dimension_filter, metric_filter: metric_filter, page_size: page_size, page_token: page_token, metric_aggregations: metric_aggregations, order_bys: order_bys, currency_code: currency_code, cohort_spec: cohort_spec, keep_empty_rows: keep_empty_rows, return_property_quota: return_property_quota }) do |response, operation|
        assert_kind_of Gapic::PagedEnumerable, response
        assert_equal grpc_response, response.response
        assert_equal grpc_operation, operation
      end

      # Use named arguments
      client.run_report property: property, dimensions: dimensions, metrics: metrics, date_ranges: date_ranges, dimension_filter: dimension_filter, metric_filter: metric_filter, page_size: page_size, page_token: page_token, metric_aggregations: metric_aggregations, order_bys: order_bys, currency_code: currency_code, cohort_spec: cohort_spec, keep_empty_rows: keep_empty_rows, return_property_quota: return_property_quota do |response, operation|
        assert_kind_of Gapic::PagedEnumerable, response
        assert_equal grpc_response, response.response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object
      client.run_report ::Google::Analytics::Data::V1beta::RunReportRequest.new(property: property, dimensions: dimensions, metrics: metrics, date_ranges: date_ranges, dimension_filter: dimension_filter, metric_filter: metric_filter, page_size: page_size, page_token: page_token, metric_aggregations: metric_aggregations, order_bys: order_bys, currency_code: currency_code, cohort_spec: cohort_spec, keep_empty_rows: keep_empty_rows, return_property_quota: return_property_quota) do |response, operation|
        assert_kind_of Gapic::PagedEnumerable, response
        assert_equal grpc_response, response.response
        assert_equal grpc_operation, operation
      end

      # Use hash object with options
      client.run_report({ property: property, dimensions: dimensions, metrics: metrics, date_ranges: date_ranges, dimension_filter: dimension_filter, metric_filter: metric_filter, page_size: page_size, page_token: page_token, metric_aggregations: metric_aggregations, order_bys: order_bys, currency_code: currency_code, cohort_spec: cohort_spec, keep_empty_rows: keep_empty_rows, return_property_quota: return_property_quota }, grpc_options) do |response, operation|
        assert_kind_of Gapic::PagedEnumerable, response
        assert_equal grpc_response, response.response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object with options
      client.run_report ::Google::Analytics::Data::V1beta::RunReportRequest.new(property: property, dimensions: dimensions, metrics: metrics, date_ranges: date_ranges, dimension_filter: dimension_filter, metric_filter: metric_filter, page_size: page_size, page_token: page_token, metric_aggregations: metric_aggregations, order_bys: order_bys, currency_code: currency_code, cohort_spec: cohort_spec, keep_empty_rows: keep_empty_rows, return_property_quota: return_property_quota), grpc_options do |response, operation|
        assert_kind_of Gapic::PagedEnumerable, response
        assert_equal grpc_response, response.response
        assert_equal grpc_operation, operation
      end

      # Verify method calls
      assert_equal 5, run_report_client_stub.call_rpc_count
    end
  end

  def test_run_pivot_report
    # Create GRPC objects.
    grpc_response = ::Google::Analytics::Data::V1beta::RunPivotReportResponse.new
    grpc_operation = GRPC::ActiveCall::Operation.new nil
    grpc_channel = GRPC::Core::Channel.new "localhost:8888", nil, :this_channel_is_insecure
    grpc_options = {}

    # Create request parameters for a unary method.
    property = "hello world"
    dimensions = [{}]
    metrics = [{}]
    date_ranges = [{}]
    pivots = [{}]
    dimension_filter = {}
    metric_filter = {}
    currency_code = "hello world"
    cohort_spec = {}
    keep_empty_rows = true
    return_property_quota = true

    run_pivot_report_client_stub = ClientStub.new grpc_response, grpc_operation do |name, request, options:|
      assert_equal :run_pivot_report, name
      assert_kind_of ::Google::Analytics::Data::V1beta::RunPivotReportRequest, request
      assert_equal "hello world", request["property"]
      assert_kind_of ::Google::Analytics::Data::V1beta::Dimension, request["dimensions"].first
      assert_kind_of ::Google::Analytics::Data::V1beta::Metric, request["metrics"].first
      assert_kind_of ::Google::Analytics::Data::V1beta::DateRange, request["date_ranges"].first
      assert_kind_of ::Google::Analytics::Data::V1beta::Pivot, request["pivots"].first
      assert_equal Gapic::Protobuf.coerce({}, to: ::Google::Analytics::Data::V1beta::FilterExpression), request["dimension_filter"]
      assert_equal Gapic::Protobuf.coerce({}, to: ::Google::Analytics::Data::V1beta::FilterExpression), request["metric_filter"]
      assert_equal "hello world", request["currency_code"]
      assert_equal Gapic::Protobuf.coerce({}, to: ::Google::Analytics::Data::V1beta::CohortSpec), request["cohort_spec"]
      assert_equal true, request["keep_empty_rows"]
      assert_equal true, request["return_property_quota"]
      refute_nil options
    end

    Gapic::ServiceStub.stub :new, run_pivot_report_client_stub do
      # Create client
      client = ::Google::Analytics::Data::V1beta::BetaAnalyticsData::Client.new do |config|
        config.credentials = grpc_channel
      end

      # Use hash object
      client.run_pivot_report({ property: property, dimensions: dimensions, metrics: metrics, date_ranges: date_ranges, pivots: pivots, dimension_filter: dimension_filter, metric_filter: metric_filter, currency_code: currency_code, cohort_spec: cohort_spec, keep_empty_rows: keep_empty_rows, return_property_quota: return_property_quota }) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use named arguments
      client.run_pivot_report property: property, dimensions: dimensions, metrics: metrics, date_ranges: date_ranges, pivots: pivots, dimension_filter: dimension_filter, metric_filter: metric_filter, currency_code: currency_code, cohort_spec: cohort_spec, keep_empty_rows: keep_empty_rows, return_property_quota: return_property_quota do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object
      client.run_pivot_report ::Google::Analytics::Data::V1beta::RunPivotReportRequest.new(property: property, dimensions: dimensions, metrics: metrics, date_ranges: date_ranges, pivots: pivots, dimension_filter: dimension_filter, metric_filter: metric_filter, currency_code: currency_code, cohort_spec: cohort_spec, keep_empty_rows: keep_empty_rows, return_property_quota: return_property_quota) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use hash object with options
      client.run_pivot_report({ property: property, dimensions: dimensions, metrics: metrics, date_ranges: date_ranges, pivots: pivots, dimension_filter: dimension_filter, metric_filter: metric_filter, currency_code: currency_code, cohort_spec: cohort_spec, keep_empty_rows: keep_empty_rows, return_property_quota: return_property_quota }, grpc_options) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object with options
      client.run_pivot_report ::Google::Analytics::Data::V1beta::RunPivotReportRequest.new(property: property, dimensions: dimensions, metrics: metrics, date_ranges: date_ranges, pivots: pivots, dimension_filter: dimension_filter, metric_filter: metric_filter, currency_code: currency_code, cohort_spec: cohort_spec, keep_empty_rows: keep_empty_rows, return_property_quota: return_property_quota), grpc_options do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Verify method calls
      assert_equal 5, run_pivot_report_client_stub.call_rpc_count
    end
  end

  def test_batch_run_reports
    # Create GRPC objects.
    grpc_response = ::Google::Analytics::Data::V1beta::BatchRunReportsResponse.new
    grpc_operation = GRPC::ActiveCall::Operation.new nil
    grpc_channel = GRPC::Core::Channel.new "localhost:8888", nil, :this_channel_is_insecure
    grpc_options = {}

    # Create request parameters for a unary method.
    property = "hello world"
    requests = [{}]

    batch_run_reports_client_stub = ClientStub.new grpc_response, grpc_operation do |name, request, options:|
      assert_equal :batch_run_reports, name
      assert_kind_of ::Google::Analytics::Data::V1beta::BatchRunReportsRequest, request
      assert_equal "hello world", request["property"]
      assert_kind_of ::Google::Analytics::Data::V1beta::RunReportRequest, request["requests"].first
      refute_nil options
    end

    Gapic::ServiceStub.stub :new, batch_run_reports_client_stub do
      # Create client
      client = ::Google::Analytics::Data::V1beta::BetaAnalyticsData::Client.new do |config|
        config.credentials = grpc_channel
      end

      # Use hash object
      client.batch_run_reports({ property: property, requests: requests }) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use named arguments
      client.batch_run_reports property: property, requests: requests do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object
      client.batch_run_reports ::Google::Analytics::Data::V1beta::BatchRunReportsRequest.new(property: property, requests: requests) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use hash object with options
      client.batch_run_reports({ property: property, requests: requests }, grpc_options) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object with options
      client.batch_run_reports ::Google::Analytics::Data::V1beta::BatchRunReportsRequest.new(property: property, requests: requests), grpc_options do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Verify method calls
      assert_equal 5, batch_run_reports_client_stub.call_rpc_count
    end
  end

  def test_batch_run_pivot_reports
    # Create GRPC objects.
    grpc_response = ::Google::Analytics::Data::V1beta::BatchRunPivotReportsResponse.new
    grpc_operation = GRPC::ActiveCall::Operation.new nil
    grpc_channel = GRPC::Core::Channel.new "localhost:8888", nil, :this_channel_is_insecure
    grpc_options = {}

    # Create request parameters for a unary method.
    property = "hello world"
    requests = [{}]

    batch_run_pivot_reports_client_stub = ClientStub.new grpc_response, grpc_operation do |name, request, options:|
      assert_equal :batch_run_pivot_reports, name
      assert_kind_of ::Google::Analytics::Data::V1beta::BatchRunPivotReportsRequest, request
      assert_equal "hello world", request["property"]
      assert_kind_of ::Google::Analytics::Data::V1beta::RunPivotReportRequest, request["requests"].first
      refute_nil options
    end

    Gapic::ServiceStub.stub :new, batch_run_pivot_reports_client_stub do
      # Create client
      client = ::Google::Analytics::Data::V1beta::BetaAnalyticsData::Client.new do |config|
        config.credentials = grpc_channel
      end

      # Use hash object
      client.batch_run_pivot_reports({ property: property, requests: requests }) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use named arguments
      client.batch_run_pivot_reports property: property, requests: requests do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object
      client.batch_run_pivot_reports ::Google::Analytics::Data::V1beta::BatchRunPivotReportsRequest.new(property: property, requests: requests) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use hash object with options
      client.batch_run_pivot_reports({ property: property, requests: requests }, grpc_options) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object with options
      client.batch_run_pivot_reports ::Google::Analytics::Data::V1beta::BatchRunPivotReportsRequest.new(property: property, requests: requests), grpc_options do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Verify method calls
      assert_equal 5, batch_run_pivot_reports_client_stub.call_rpc_count
    end
  end

  def test_get_metadata
    # Create GRPC objects.
    grpc_response = ::Google::Analytics::Data::V1beta::Metadata.new
    grpc_operation = GRPC::ActiveCall::Operation.new nil
    grpc_channel = GRPC::Core::Channel.new "localhost:8888", nil, :this_channel_is_insecure
    grpc_options = {}

    # Create request parameters for a unary method.
    name = "hello world"

    get_metadata_client_stub = ClientStub.new grpc_response, grpc_operation do |name, request, options:|
      assert_equal :get_metadata, name
      assert_kind_of ::Google::Analytics::Data::V1beta::GetMetadataRequest, request
      assert_equal "hello world", request["name"]
      refute_nil options
    end

    Gapic::ServiceStub.stub :new, get_metadata_client_stub do
      # Create client
      client = ::Google::Analytics::Data::V1beta::BetaAnalyticsData::Client.new do |config|
        config.credentials = grpc_channel
      end

      # Use hash object
      client.get_metadata({ name: name }) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use named arguments
      client.get_metadata name: name do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object
      client.get_metadata ::Google::Analytics::Data::V1beta::GetMetadataRequest.new(name: name) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use hash object with options
      client.get_metadata({ name: name }, grpc_options) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object with options
      client.get_metadata ::Google::Analytics::Data::V1beta::GetMetadataRequest.new(name: name), grpc_options do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Verify method calls
      assert_equal 5, get_metadata_client_stub.call_rpc_count
    end
  end

  def test_run_realtime_report
    # Create GRPC objects.
    grpc_response = ::Google::Analytics::Data::V1beta::RunRealtimeReportResponse.new
    grpc_operation = GRPC::ActiveCall::Operation.new nil
    grpc_channel = GRPC::Core::Channel.new "localhost:8888", nil, :this_channel_is_insecure
    grpc_options = {}

    # Create request parameters for a unary method.
    property = "hello world"
    dimensions = [{}]
    metrics = [{}]
    dimension_filter = {}
    metric_filter = {}
    page_size = 42
    metric_aggregations = [:METRIC_AGGREGATION_UNSPECIFIED]
    order_bys = [{}]
    return_property_quota = true

    run_realtime_report_client_stub = ClientStub.new grpc_response, grpc_operation do |name, request, options:|
      assert_equal :run_realtime_report, name
      assert_kind_of ::Google::Analytics::Data::V1beta::RunRealtimeReportRequest, request
      assert_equal "hello world", request["property"]
      assert_kind_of ::Google::Analytics::Data::V1beta::Dimension, request["dimensions"].first
      assert_kind_of ::Google::Analytics::Data::V1beta::Metric, request["metrics"].first
      assert_equal Gapic::Protobuf.coerce({}, to: ::Google::Analytics::Data::V1beta::FilterExpression), request["dimension_filter"]
      assert_equal Gapic::Protobuf.coerce({}, to: ::Google::Analytics::Data::V1beta::FilterExpression), request["metric_filter"]
      assert_equal 42, request["page_size"]
      assert_equal [:METRIC_AGGREGATION_UNSPECIFIED], request["metric_aggregations"]
      assert_kind_of ::Google::Analytics::Data::V1beta::OrderBy, request["order_bys"].first
      assert_equal true, request["return_property_quota"]
      refute_nil options
    end

    Gapic::ServiceStub.stub :new, run_realtime_report_client_stub do
      # Create client
      client = ::Google::Analytics::Data::V1beta::BetaAnalyticsData::Client.new do |config|
        config.credentials = grpc_channel
      end

      # Use hash object
      client.run_realtime_report({ property: property, dimensions: dimensions, metrics: metrics, dimension_filter: dimension_filter, metric_filter: metric_filter, page_size: page_size, metric_aggregations: metric_aggregations, order_bys: order_bys, return_property_quota: return_property_quota }) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use named arguments
      client.run_realtime_report property: property, dimensions: dimensions, metrics: metrics, dimension_filter: dimension_filter, metric_filter: metric_filter, page_size: page_size, metric_aggregations: metric_aggregations, order_bys: order_bys, return_property_quota: return_property_quota do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object
      client.run_realtime_report ::Google::Analytics::Data::V1beta::RunRealtimeReportRequest.new(property: property, dimensions: dimensions, metrics: metrics, dimension_filter: dimension_filter, metric_filter: metric_filter, page_size: page_size, metric_aggregations: metric_aggregations, order_bys: order_bys, return_property_quota: return_property_quota) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use hash object with options
      client.run_realtime_report({ property: property, dimensions: dimensions, metrics: metrics, dimension_filter: dimension_filter, metric_filter: metric_filter, page_size: page_size, metric_aggregations: metric_aggregations, order_bys: order_bys, return_property_quota: return_property_quota }, grpc_options) do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Use protobuf object with options
      client.run_realtime_report ::Google::Analytics::Data::V1beta::RunRealtimeReportRequest.new(property: property, dimensions: dimensions, metrics: metrics, dimension_filter: dimension_filter, metric_filter: metric_filter, page_size: page_size, metric_aggregations: metric_aggregations, order_bys: order_bys, return_property_quota: return_property_quota), grpc_options do |response, operation|
        assert_equal grpc_response, response
        assert_equal grpc_operation, operation
      end

      # Verify method calls
      assert_equal 5, run_realtime_report_client_stub.call_rpc_count
    end
  end

  def test_configure
    grpc_channel = GRPC::Core::Channel.new "localhost:8888", nil, :this_channel_is_insecure

    client = block_config = config = nil
    Gapic::ServiceStub.stub :new, nil do
      client = ::Google::Analytics::Data::V1beta::BetaAnalyticsData::Client.new do |config|
        config.credentials = grpc_channel
      end
    end

    config = client.configure do |c|
      block_config = c
    end

    assert_same block_config, config
    assert_kind_of ::Google::Analytics::Data::V1beta::BetaAnalyticsData::Client::Configuration, config
  end
end
