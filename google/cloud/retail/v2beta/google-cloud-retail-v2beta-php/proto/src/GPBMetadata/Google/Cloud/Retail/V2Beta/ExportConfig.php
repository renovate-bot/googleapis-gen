<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/retail/v2beta/export_config.proto

namespace GPBMetadata\Google\Cloud\Retail\V2Beta;

class ExportConfig
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Protobuf\Timestamp::initOnce();
        \GPBMetadata\Google\Rpc\Status::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
.google/cloud/retail/v2beta/export_config.protogoogle.cloud.retail.v2betagoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/timestamp.protogoogle/rpc/status.proto"9
ExportErrorsConfig

gcs_prefix (	H B
destination"r
ExportMetadata/
create_time (2.google.protobuf.Timestamp/
update_time (2.google.protobuf.Timestamp"�
ExportProductsResponse)
error_samples (2.google.rpc.StatusE
errors_config (2..google.cloud.retail.v2beta.ExportErrorsConfig"�
ExportUserEventsResponse)
error_samples (2.google.rpc.StatusE
errors_config (2..google.cloud.retail.v2beta.ExportErrorsConfigB�
com.google.cloud.retail.v2betaBExportConfigProtoPZ@google.golang.org/genproto/googleapis/cloud/retail/v2beta;retail�RETAIL�Google.Cloud.Retail.V2Beta�Google\\Cloud\\Retail\\V2beta�Google::Cloud::Retail::V2betabproto3'
        , true);

        static::$is_initialized = true;
    }
}

