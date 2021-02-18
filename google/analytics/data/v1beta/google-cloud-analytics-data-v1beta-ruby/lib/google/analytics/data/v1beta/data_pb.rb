# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/analytics/data/v1beta/data.proto

require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/analytics/data/v1beta/data.proto", :syntax => :proto3) do
    add_message "google.analytics.data.v1beta.DateRange" do
      optional :start_date, :string, 1
      optional :end_date, :string, 2
      optional :name, :string, 3
    end
    add_message "google.analytics.data.v1beta.Dimension" do
      optional :name, :string, 1
      optional :dimension_expression, :message, 2, "google.analytics.data.v1beta.DimensionExpression"
    end
    add_message "google.analytics.data.v1beta.DimensionExpression" do
      oneof :one_expression do
        optional :lower_case, :message, 4, "google.analytics.data.v1beta.DimensionExpression.CaseExpression"
        optional :upper_case, :message, 5, "google.analytics.data.v1beta.DimensionExpression.CaseExpression"
        optional :concatenate, :message, 6, "google.analytics.data.v1beta.DimensionExpression.ConcatenateExpression"
      end
    end
    add_message "google.analytics.data.v1beta.DimensionExpression.CaseExpression" do
      optional :dimension_name, :string, 1
    end
    add_message "google.analytics.data.v1beta.DimensionExpression.ConcatenateExpression" do
      repeated :dimension_names, :string, 1
      optional :delimiter, :string, 2
    end
    add_message "google.analytics.data.v1beta.Metric" do
      optional :name, :string, 1
      optional :expression, :string, 2
      optional :invisible, :bool, 3
    end
    add_message "google.analytics.data.v1beta.FilterExpression" do
      oneof :expr do
        optional :and_group, :message, 1, "google.analytics.data.v1beta.FilterExpressionList"
        optional :or_group, :message, 2, "google.analytics.data.v1beta.FilterExpressionList"
        optional :not_expression, :message, 3, "google.analytics.data.v1beta.FilterExpression"
        optional :filter, :message, 4, "google.analytics.data.v1beta.Filter"
      end
    end
    add_message "google.analytics.data.v1beta.FilterExpressionList" do
      repeated :expressions, :message, 1, "google.analytics.data.v1beta.FilterExpression"
    end
    add_message "google.analytics.data.v1beta.Filter" do
      optional :field_name, :string, 1
      oneof :one_filter do
        optional :string_filter, :message, 3, "google.analytics.data.v1beta.Filter.StringFilter"
        optional :in_list_filter, :message, 4, "google.analytics.data.v1beta.Filter.InListFilter"
        optional :numeric_filter, :message, 5, "google.analytics.data.v1beta.Filter.NumericFilter"
        optional :between_filter, :message, 6, "google.analytics.data.v1beta.Filter.BetweenFilter"
      end
    end
    add_message "google.analytics.data.v1beta.Filter.StringFilter" do
      optional :match_type, :enum, 1, "google.analytics.data.v1beta.Filter.StringFilter.MatchType"
      optional :value, :string, 2
      optional :case_sensitive, :bool, 3
    end
    add_enum "google.analytics.data.v1beta.Filter.StringFilter.MatchType" do
      value :MATCH_TYPE_UNSPECIFIED, 0
      value :EXACT, 1
      value :BEGINS_WITH, 2
      value :ENDS_WITH, 3
      value :CONTAINS, 4
      value :FULL_REGEXP, 5
      value :PARTIAL_REGEXP, 6
    end
    add_message "google.analytics.data.v1beta.Filter.InListFilter" do
      repeated :values, :string, 1
      optional :case_sensitive, :bool, 2
    end
    add_message "google.analytics.data.v1beta.Filter.NumericFilter" do
      optional :operation, :enum, 1, "google.analytics.data.v1beta.Filter.NumericFilter.Operation"
      optional :value, :message, 2, "google.analytics.data.v1beta.NumericValue"
    end
    add_enum "google.analytics.data.v1beta.Filter.NumericFilter.Operation" do
      value :OPERATION_UNSPECIFIED, 0
      value :EQUAL, 1
      value :LESS_THAN, 2
      value :LESS_THAN_OR_EQUAL, 3
      value :GREATER_THAN, 4
      value :GREATER_THAN_OR_EQUAL, 5
    end
    add_message "google.analytics.data.v1beta.Filter.BetweenFilter" do
      optional :from_value, :message, 1, "google.analytics.data.v1beta.NumericValue"
      optional :to_value, :message, 2, "google.analytics.data.v1beta.NumericValue"
    end
    add_message "google.analytics.data.v1beta.OrderBy" do
      optional :desc, :bool, 4
      oneof :one_order_by do
        optional :metric, :message, 1, "google.analytics.data.v1beta.OrderBy.MetricOrderBy"
        optional :dimension, :message, 2, "google.analytics.data.v1beta.OrderBy.DimensionOrderBy"
        optional :pivot, :message, 3, "google.analytics.data.v1beta.OrderBy.PivotOrderBy"
      end
    end
    add_message "google.analytics.data.v1beta.OrderBy.MetricOrderBy" do
      optional :metric_name, :string, 1
    end
    add_message "google.analytics.data.v1beta.OrderBy.DimensionOrderBy" do
      optional :dimension_name, :string, 1
      optional :order_type, :enum, 2, "google.analytics.data.v1beta.OrderBy.DimensionOrderBy.OrderType"
    end
    add_enum "google.analytics.data.v1beta.OrderBy.DimensionOrderBy.OrderType" do
      value :ORDER_TYPE_UNSPECIFIED, 0
      value :ALPHANUMERIC, 1
      value :CASE_INSENSITIVE_ALPHANUMERIC, 2
      value :NUMERIC, 3
    end
    add_message "google.analytics.data.v1beta.OrderBy.PivotOrderBy" do
      optional :metric_name, :string, 1
      repeated :pivot_selections, :message, 2, "google.analytics.data.v1beta.OrderBy.PivotOrderBy.PivotSelection"
    end
    add_message "google.analytics.data.v1beta.OrderBy.PivotOrderBy.PivotSelection" do
      optional :dimension_name, :string, 1
      optional :dimension_value, :string, 2
    end
    add_message "google.analytics.data.v1beta.Pivot" do
      repeated :field_names, :string, 1
      repeated :order_bys, :message, 2, "google.analytics.data.v1beta.OrderBy"
      optional :offset, :int64, 3
      optional :limit, :int64, 4
      repeated :metric_aggregations, :enum, 5, "google.analytics.data.v1beta.MetricAggregation"
    end
    add_message "google.analytics.data.v1beta.CohortSpec" do
      repeated :cohorts, :message, 1, "google.analytics.data.v1beta.Cohort"
      optional :cohorts_range, :message, 2, "google.analytics.data.v1beta.CohortsRange"
      optional :cohort_report_settings, :message, 3, "google.analytics.data.v1beta.CohortReportSettings"
    end
    add_message "google.analytics.data.v1beta.Cohort" do
      optional :name, :string, 1
      optional :dimension, :string, 2
      optional :date_range, :message, 3, "google.analytics.data.v1beta.DateRange"
    end
    add_message "google.analytics.data.v1beta.CohortsRange" do
      optional :granularity, :enum, 1, "google.analytics.data.v1beta.CohortsRange.Granularity"
      optional :start_offset, :int32, 2
      optional :end_offset, :int32, 3
    end
    add_enum "google.analytics.data.v1beta.CohortsRange.Granularity" do
      value :GRANULARITY_UNSPECIFIED, 0
      value :DAILY, 1
      value :WEEKLY, 2
      value :MONTHLY, 3
    end
    add_message "google.analytics.data.v1beta.CohortReportSettings" do
      optional :accumulate, :bool, 1
    end
    add_message "google.analytics.data.v1beta.ResponseMetaData" do
      optional :data_loss_from_other_row, :bool, 3
    end
    add_message "google.analytics.data.v1beta.DimensionHeader" do
      optional :name, :string, 1
    end
    add_message "google.analytics.data.v1beta.MetricHeader" do
      optional :name, :string, 1
      optional :type, :enum, 2, "google.analytics.data.v1beta.MetricType"
    end
    add_message "google.analytics.data.v1beta.PivotHeader" do
      repeated :pivot_dimension_headers, :message, 1, "google.analytics.data.v1beta.PivotDimensionHeader"
      optional :row_count, :int32, 2
    end
    add_message "google.analytics.data.v1beta.PivotDimensionHeader" do
      repeated :dimension_values, :message, 1, "google.analytics.data.v1beta.DimensionValue"
    end
    add_message "google.analytics.data.v1beta.Row" do
      repeated :dimension_values, :message, 1, "google.analytics.data.v1beta.DimensionValue"
      repeated :metric_values, :message, 2, "google.analytics.data.v1beta.MetricValue"
    end
    add_message "google.analytics.data.v1beta.DimensionValue" do
      oneof :one_value do
        optional :value, :string, 1
      end
    end
    add_message "google.analytics.data.v1beta.MetricValue" do
      oneof :one_value do
        optional :value, :string, 4
      end
    end
    add_message "google.analytics.data.v1beta.NumericValue" do
      oneof :one_value do
        optional :int64_value, :int64, 1
        optional :double_value, :double, 2
      end
    end
    add_message "google.analytics.data.v1beta.PropertyQuota" do
      optional :tokens_per_day, :message, 1, "google.analytics.data.v1beta.QuotaStatus"
      optional :tokens_per_hour, :message, 2, "google.analytics.data.v1beta.QuotaStatus"
      optional :concurrent_requests, :message, 3, "google.analytics.data.v1beta.QuotaStatus"
      optional :server_errors_per_project_per_hour, :message, 4, "google.analytics.data.v1beta.QuotaStatus"
    end
    add_message "google.analytics.data.v1beta.QuotaStatus" do
      optional :consumed, :int32, 1
      optional :remaining, :int32, 2
    end
    add_message "google.analytics.data.v1beta.DimensionMetadata" do
      optional :api_name, :string, 1
      optional :ui_name, :string, 2
      optional :description, :string, 3
      repeated :deprecated_api_names, :string, 4
      optional :custom_definition, :bool, 5
    end
    add_message "google.analytics.data.v1beta.MetricMetadata" do
      optional :api_name, :string, 1
      optional :ui_name, :string, 2
      optional :description, :string, 3
      repeated :deprecated_api_names, :string, 4
      optional :type, :enum, 5, "google.analytics.data.v1beta.MetricType"
      optional :expression, :string, 6
      optional :custom_definition, :bool, 7
    end
    add_enum "google.analytics.data.v1beta.MetricAggregation" do
      value :METRIC_AGGREGATION_UNSPECIFIED, 0
      value :TOTAL, 1
      value :MINIMUM, 5
      value :MAXIMUM, 6
      value :COUNT, 4
    end
    add_enum "google.analytics.data.v1beta.MetricType" do
      value :METRIC_TYPE_UNSPECIFIED, 0
      value :TYPE_INTEGER, 1
      value :TYPE_FLOAT, 2
      value :TYPE_SECONDS, 4
      value :TYPE_MILLISECONDS, 5
      value :TYPE_MINUTES, 6
      value :TYPE_HOURS, 7
      value :TYPE_STANDARD, 8
      value :TYPE_CURRENCY, 9
      value :TYPE_FEET, 10
      value :TYPE_MILES, 11
      value :TYPE_METERS, 12
      value :TYPE_KILOMETERS, 13
    end
  end
end

module Google
  module Analytics
    module Data
      module V1beta
        DateRange = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.DateRange").msgclass
        Dimension = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.Dimension").msgclass
        DimensionExpression = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.DimensionExpression").msgclass
        DimensionExpression::CaseExpression = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.DimensionExpression.CaseExpression").msgclass
        DimensionExpression::ConcatenateExpression = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.DimensionExpression.ConcatenateExpression").msgclass
        Metric = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.Metric").msgclass
        FilterExpression = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.FilterExpression").msgclass
        FilterExpressionList = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.FilterExpressionList").msgclass
        Filter = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.Filter").msgclass
        Filter::StringFilter = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.Filter.StringFilter").msgclass
        Filter::StringFilter::MatchType = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.Filter.StringFilter.MatchType").enummodule
        Filter::InListFilter = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.Filter.InListFilter").msgclass
        Filter::NumericFilter = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.Filter.NumericFilter").msgclass
        Filter::NumericFilter::Operation = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.Filter.NumericFilter.Operation").enummodule
        Filter::BetweenFilter = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.Filter.BetweenFilter").msgclass
        OrderBy = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.OrderBy").msgclass
        OrderBy::MetricOrderBy = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.OrderBy.MetricOrderBy").msgclass
        OrderBy::DimensionOrderBy = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.OrderBy.DimensionOrderBy").msgclass
        OrderBy::DimensionOrderBy::OrderType = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.OrderBy.DimensionOrderBy.OrderType").enummodule
        OrderBy::PivotOrderBy = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.OrderBy.PivotOrderBy").msgclass
        OrderBy::PivotOrderBy::PivotSelection = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.OrderBy.PivotOrderBy.PivotSelection").msgclass
        Pivot = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.Pivot").msgclass
        CohortSpec = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.CohortSpec").msgclass
        Cohort = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.Cohort").msgclass
        CohortsRange = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.CohortsRange").msgclass
        CohortsRange::Granularity = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.CohortsRange.Granularity").enummodule
        CohortReportSettings = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.CohortReportSettings").msgclass
        ResponseMetaData = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.ResponseMetaData").msgclass
        DimensionHeader = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.DimensionHeader").msgclass
        MetricHeader = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.MetricHeader").msgclass
        PivotHeader = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.PivotHeader").msgclass
        PivotDimensionHeader = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.PivotDimensionHeader").msgclass
        Row = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.Row").msgclass
        DimensionValue = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.DimensionValue").msgclass
        MetricValue = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.MetricValue").msgclass
        NumericValue = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.NumericValue").msgclass
        PropertyQuota = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.PropertyQuota").msgclass
        QuotaStatus = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.QuotaStatus").msgclass
        DimensionMetadata = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.DimensionMetadata").msgclass
        MetricMetadata = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.MetricMetadata").msgclass
        MetricAggregation = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.MetricAggregation").enummodule
        MetricType = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.analytics.data.v1beta.MetricType").enummodule
      end
    end
  end
end
