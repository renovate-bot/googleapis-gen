<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/bigquery/migration/v2alpha/migration_metrics.proto

namespace GPBMetadata\Google\Cloud\Bigquery\Migration\V2Alpha;

class MigrationMetrics
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Distribution::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Metric::initOnce();
        \GPBMetadata\Google\Protobuf\Timestamp::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
?google/cloud/bigquery/migration/v2alpha/migration_metrics.proto\'google.cloud.bigquery.migration.v2alphagoogle/api/field_behavior.protogoogle/api/metric.protogoogle/protobuf/timestamp.proto"�

TimeSeries
metric (	B�A?

value_type (2&.google.api.MetricDescriptor.ValueTypeB�AA
metric_kind (2\'.google.api.MetricDescriptor.MetricKindB�AC
points (2..google.cloud.bigquery.migration.v2alpha.PointB�A"�
PointG
interval (25.google.cloud.bigquery.migration.v2alpha.TimeIntervalB
value (23.google.cloud.bigquery.migration.v2alpha.TypedValue"v
TimeInterval3

start_time (2.google.protobuf.TimestampB�A1
end_time (2.google.protobuf.TimestampB�A"�

TypedValue

bool_value (H 
int64_value (H 
double_value (H 
string_value (	H 6
distribution_value (2.google.api.DistributionH B
valueB�
+com.google.cloud.bigquery.migration.v2alphaBMigrationMetricsProtoPZPgoogle.golang.org/genproto/googleapis/cloud/bigquery/migration/v2alpha;migrationbproto3'
        , true);

        static::$is_initialized = true;
    }
}

