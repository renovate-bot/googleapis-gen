<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/monitoring/dashboard/v1/scorecard.proto

namespace GPBMetadata\Google\Monitoring\Dashboard\V1;

class Scorecard
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Monitoring\Dashboard\V1\Metrics::initOnce();
        \GPBMetadata\Google\Protobuf\Duration::initOnce();
        \GPBMetadata\Google\Protobuf\GPBEmpty::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
.google/monitoring/dashboard/v1/scorecard.protogoogle.monitoring.dashboard.v1,google/monitoring/dashboard/v1/metrics.protogoogle/protobuf/duration.protogoogle/protobuf/empty.proto"�
	ScorecardO
time_series_query (2/.google.monitoring.dashboard.v1.TimeSeriesQueryB�AI

gauge_view (23.google.monitoring.dashboard.v1.Scorecard.GaugeViewH T
spark_chart_view (28.google.monitoring.dashboard.v1.Scorecard.SparkChartViewH =

thresholds (2).google.monitoring.dashboard.v1.Threshold5
	GaugeView
lower_bound (
upper_bound (�
SparkChartViewM
spark_chart_type (2..google.monitoring.dashboard.v1.SparkChartTypeB�A7
min_alignment_period (2.google.protobuf.DurationB
	data_viewB�
"com.google.monitoring.dashboard.v1BScorecardProtoPZGgoogle.golang.org/genproto/googleapis/monitoring/dashboard/v1;dashboard�$Google.Cloud.Monitoring.Dashboard.V1�$Google\\Cloud\\Monitoring\\Dashboard\\V1�(Google::Cloud::Monitoring::Dashboard::V1bproto3'
        , true);

        static::$is_initialized = true;
    }
}

