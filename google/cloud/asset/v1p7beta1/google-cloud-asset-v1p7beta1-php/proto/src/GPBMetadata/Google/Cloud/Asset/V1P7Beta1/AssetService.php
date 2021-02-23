<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/asset/v1p7beta1/asset_service.proto

namespace GPBMetadata\Google\Cloud\Asset\V1P7Beta1;

class AssetService
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Cloud\Asset\V1P7Beta1\Assets::initOnce();
        \GPBMetadata\Google\Longrunning\Operations::initOnce();
        \GPBMetadata\Google\Protobuf\GPBEmpty::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Protobuf\Timestamp::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
0google/cloud/asset/v1p7beta1/asset_service.protogoogle.cloud.asset.v1p7beta1google/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto)google/cloud/asset/v1p7beta1/assets.proto#google/longrunning/operations.protogoogle/protobuf/empty.proto google/protobuf/field_mask.protogoogle/protobuf/timestamp.proto"�
ExportAssetsRequest7
parent (	B\'�A�A!cloudasset.googleapis.com/Asset-
	read_time (2.google.protobuf.Timestamp
asset_types (	?
content_type (2).google.cloud.asset.v1p7beta1.ContentTypeF
output_config (2*.google.cloud.asset.v1p7beta1.OutputConfigB�A
relationship_types (	"�
ExportAssetsResponse-
	read_time (2.google.protobuf.TimestampA
output_config (2*.google.cloud.asset.v1p7beta1.OutputConfigA
output_result (2*.google.cloud.asset.v1p7beta1.OutputResult"�
OutputConfigG
gcs_destination (2,.google.cloud.asset.v1p7beta1.GcsDestinationH Q
bigquery_destination (21.google.cloud.asset.v1p7beta1.BigQueryDestinationH B
destination"]
OutputResultC

gcs_result (2-.google.cloud.asset.v1p7beta1.GcsOutputResultH B
result"
GcsOutputResult
uris (	"C
GcsDestination
uri (	H 

uri_prefix (	H B

object_uri"�
BigQueryDestination
dataset (	B�A
table (	B�A
force (C
partition_spec (2+.google.cloud.asset.v1p7beta1.PartitionSpec&
separate_tables_per_asset_type ("�
PartitionSpecO
partition_key (28.google.cloud.asset.v1p7beta1.PartitionSpec.PartitionKey"N
PartitionKey
PARTITION_KEY_UNSPECIFIED 
	READ_TIME
REQUEST_TIME*~
ContentType
CONTENT_TYPE_UNSPECIFIED 
RESOURCE

IAM_POLICY

ORG_POLICY
ACCESS_POLICY
RELATIONSHIP2�
AssetService�
ExportAssets1.google.cloud.asset.v1p7beta1.ExportAssetsRequest.google.longrunning.Operation"����)"$/v1p7beta1/{parent=*/*}:exportAssets:*�Ae
1google.cloud.asset.v1p7beta1.ExportAssetsResponse0google.cloud.asset.v1p7beta1.ExportAssetsRequestM�Acloudasset.googleapis.com�A.https://www.googleapis.com/auth/cloud-platformB�
 com.google.cloud.asset.v1p7beta1BAssetServiceProtoPZAgoogle.golang.org/genproto/googleapis/cloud/asset/v1p7beta1;asset�Google.Cloud.Asset.V1P7Beta1�Google\\Cloud\\Asset\\V1p7beta1bproto3'
        , true);

        static::$is_initialized = true;
    }
}

