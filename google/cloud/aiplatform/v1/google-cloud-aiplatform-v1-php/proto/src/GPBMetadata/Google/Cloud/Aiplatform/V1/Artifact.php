<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/aiplatform/v1/artifact.proto

namespace GPBMetadata\Google\Cloud\Aiplatform\V1;

class Artifact
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Cloud\Aiplatform\V1\Value::initOnce();
        \GPBMetadata\Google\Protobuf\Struct::initOnce();
        \GPBMetadata\Google\Protobuf\Timestamp::initOnce();
        \GPBMetadata\Google\Api\Annotations::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
)google/cloud/aiplatform/v1/artifact.protogoogle.cloud.aiplatform.v1google/api/resource.proto&google/cloud/aiplatform/v1/value.protogoogle/protobuf/struct.protogoogle/protobuf/timestamp.protogoogle/api/annotations.proto"�
Artifact
name (	B�A
display_name (	
uri (	
etag	 (	@
labels
 (20.google.cloud.aiplatform.v1.Artifact.LabelsEntry4
create_time (2.google.protobuf.TimestampB�A4
update_time (2.google.protobuf.TimestampB�A9
state (2*.google.cloud.aiplatform.v1.Artifact.State
schema_title (	
schema_version (	)
metadata (2.google.protobuf.Struct
description (	-
LabelsEntry
key (	
value (	:8"5
State
STATE_UNSPECIFIED 
PENDING
LIVE:��A�
"aiplatform.googleapis.com/Artifact\\projects/{project}/locations/{location}/metadataStores/{metadata_store}/artifacts/{artifact}B�
com.google.cloud.aiplatform.v1BArtifactProtoPZDgoogle.golang.org/genproto/googleapis/cloud/aiplatform/v1;aiplatform�Google.Cloud.AIPlatform.V1�Google\\Cloud\\AIPlatform\\V1�Google::Cloud::AIPlatform::V1bproto3'
        , true);

        static::$is_initialized = true;
    }
}

