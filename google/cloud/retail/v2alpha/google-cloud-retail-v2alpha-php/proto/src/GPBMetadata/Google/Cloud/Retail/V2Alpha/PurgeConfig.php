<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/retail/v2alpha/purge_config.proto

namespace GPBMetadata\Google\Cloud\Retail\V2Alpha;

class PurgeConfig
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
.google/cloud/retail/v2alpha/purge_config.protogoogle.cloud.retail.v2alphagoogle/api/field_behavior.proto"
PurgeMetadata"Q
PurgeUserEventsRequest
parent (	B�A
filter (	B�A
force ("6
PurgeUserEventsResponse
purged_events_count (B�
com.google.cloud.retail.v2alphaBPurgeConfigProtoPZAgoogle.golang.org/genproto/googleapis/cloud/retail/v2alpha;retail�RETAIL�Google.Cloud.Retail.V2Alpha�Google\\Cloud\\Retail\\V2alpha�Google::Cloud::Retail::V2alphabproto3'
        , true);

        static::$is_initialized = true;
    }
}

