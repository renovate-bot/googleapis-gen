<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/bigquery/storage/v1beta1/arrow.proto

namespace GPBMetadata\Google\Cloud\Bigquery\Storage\V1Beta1;

class Arrow
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        $pool->internalAddGeneratedFile(
            '
�
1google/cloud/bigquery/storage/v1beta1/arrow.proto%google.cloud.bigquery.storage.v1beta1"(
ArrowSchema
serialized_schema ("F
ArrowRecordBatch
serialized_record_batch (
	row_count (B�
)com.google.cloud.bigquery.storage.v1beta1B
ArrowProtoZLgoogle.golang.org/genproto/googleapis/cloud/bigquery/storage/v1beta1;storagebproto3'
        , true);

        static::$is_initialized = true;
    }
}

