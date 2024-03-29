<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/aiplatform/v1beta1/entity_type.proto

namespace GPBMetadata\Google\Cloud\Aiplatform\V1Beta1;

class EntityType
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Cloud\Aiplatform\V1Beta1\Feature::initOnce();
        \GPBMetadata\Google\Cloud\Aiplatform\V1Beta1\FeaturestoreMonitoring::initOnce();
        \GPBMetadata\Google\Protobuf\Timestamp::initOnce();
        \GPBMetadata\Google\Api\Annotations::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
1google/cloud/aiplatform/v1beta1/entity_type.protogoogle.cloud.aiplatform.v1beta1google/api/resource.proto-google/cloud/aiplatform/v1beta1/feature.proto=google/cloud/aiplatform/v1beta1/featurestore_monitoring.protogoogle/protobuf/timestamp.protogoogle/api/annotations.proto"�

EntityType
name (	B�A
description (	B�A4
create_time (2.google.protobuf.TimestampB�A4
update_time (2.google.protobuf.TimestampB�AL
labels (27.google.cloud.aiplatform.v1beta1.EntityType.LabelsEntryB�A
etag (	B�A]
monitoring_config (2=.google.cloud.aiplatform.v1beta1.FeaturestoreMonitoringConfigB�A-
LabelsEntry
key (	
value (	:8:��A�
$aiplatform.googleapis.com/EntityType^projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}B�
#com.google.cloud.aiplatform.v1beta1BEntityTypeProtoPZIgoogle.golang.org/genproto/googleapis/cloud/aiplatform/v1beta1;aiplatform�Google.Cloud.AIPlatform.V1Beta1�Google\\Cloud\\AIPlatform\\V1beta1�"Google::Cloud::AIPlatform::V1beta1bproto3'
        , true);

        static::$is_initialized = true;
    }
}

