<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/aiplatform/v1beta1/value.proto

namespace GPBMetadata\Google\Cloud\Aiplatform\V1Beta1;

class Value
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Annotations::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
+google/cloud/aiplatform/v1beta1/value.protogoogle.cloud.aiplatform.v1beta1"U
Value
	int_value (H 
double_value (H 
string_value (	H B
valueB�
#com.google.cloud.aiplatform.v1beta1B
ValueProtoPZIgoogle.golang.org/genproto/googleapis/cloud/aiplatform/v1beta1;aiplatform�Google.Cloud.AIPlatform.V1Beta1�Google\\Cloud\\AIPlatform\\V1beta1�"Google::Cloud::AIPlatform::V1beta1bproto3'
        , true);

        static::$is_initialized = true;
    }
}

