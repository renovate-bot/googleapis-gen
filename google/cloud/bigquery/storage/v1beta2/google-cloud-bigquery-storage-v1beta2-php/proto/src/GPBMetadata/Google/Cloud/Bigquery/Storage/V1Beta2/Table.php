<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/bigquery/storage/v1beta2/table.proto

namespace GPBMetadata\Google\Cloud\Bigquery\Storage\V1Beta2;

class Table
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
1google/cloud/bigquery/storage/v1beta2/table.proto%google.cloud.bigquery.storage.v1beta2"V
TableSchemaG
fields (27.google.cloud.bigquery.storage.v1beta2.TableFieldSchema"�
TableFieldSchema
name (	B�AO
type (2<.google.cloud.bigquery.storage.v1beta2.TableFieldSchema.TypeB�AO
mode (2<.google.cloud.bigquery.storage.v1beta2.TableFieldSchema.ModeB�AL
fields (27.google.cloud.bigquery.storage.v1beta2.TableFieldSchemaB�A
description (	B�A"�
Type
TYPE_UNSPECIFIED 

STRING	
INT64

DOUBLE

STRUCT	
BYTES
BOOL
	TIMESTAMP
DATE
TIME	
DATETIME

	GEOGRAPHY
NUMERIC

BIGNUMERIC
INTERVAL
JSON"F
Mode
MODE_UNSPECIFIED 
NULLABLE
REQUIRED
REPEATEDB�
)com.google.cloud.bigquery.storage.v1beta2B
TableProtoPZLgoogle.golang.org/genproto/googleapis/cloud/bigquery/storage/v1beta2;storagebproto3'
        , true);

        static::$is_initialized = true;
    }
}

