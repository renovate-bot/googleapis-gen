<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/bigquery/storage/v1beta1/table_reference.proto

namespace GPBMetadata\Google\Cloud\Bigquery\Storage\V1Beta1;

class TableReference
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Protobuf\Timestamp::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
;google/cloud/bigquery/storage/v1beta1/table_reference.proto%google.cloud.bigquery.storage.v1beta1google/protobuf/timestamp.proto"J
TableReference

project_id (	

dataset_id (	
table_id (	"C
TableModifiers1
snapshot_time (2.google.protobuf.TimestampB�
)com.google.cloud.bigquery.storage.v1beta1BTableReferenceProtoZLgoogle.golang.org/genproto/googleapis/cloud/bigquery/storage/v1beta1;storagebproto3'
        , true);

        static::$is_initialized = true;
    }
}

