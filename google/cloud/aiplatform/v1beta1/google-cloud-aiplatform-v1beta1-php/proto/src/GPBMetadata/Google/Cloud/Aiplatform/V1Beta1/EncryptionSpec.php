<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/aiplatform/v1beta1/encryption_spec.proto

namespace GPBMetadata\Google\Cloud\Aiplatform\V1Beta1;

class EncryptionSpec
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Annotations::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
5google/cloud/aiplatform/v1beta1/encryption_spec.protogoogle.cloud.aiplatform.v1beta1google/api/annotations.proto"+
EncryptionSpec
kms_key_name (	B�AB�
#com.google.cloud.aiplatform.v1beta1BEncryptionSpecProtoPZIgoogle.golang.org/genproto/googleapis/cloud/aiplatform/v1beta1;aiplatform�Google.Cloud.AIPlatform.V1Beta1�Google\\Cloud\\AIPlatform\\V1beta1�"Google::Cloud::AIPlatform::V1beta1bproto3'
        , true);

        static::$is_initialized = true;
    }
}

