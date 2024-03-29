<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v9/services/asset_set_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V9\Services;

class AssetSetService
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();
        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Http::initOnce();
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        \GPBMetadata\Google\Protobuf\Any::initOnce();
        \GPBMetadata\Google\Rpc\Status::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
4google/ads/googleads/v9/enums/asset_set_status.protogoogle.ads.googleads.v9.enums"^
AssetSetStatusEnum"H
AssetSetStatus
UNSPECIFIED 
UNKNOWN
ENABLED
REMOVEDB�
!com.google.ads.googleads.v9.enumsBAssetSetStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v9/enums;enums�GAA�Google.Ads.GoogleAds.V9.Enums�Google\\Ads\\GoogleAds\\V9\\Enums�!Google::Ads::GoogleAds::V9::Enumsbproto3
�
2google/ads/googleads/v9/enums/asset_set_type.protogoogle.ads.googleads.v9.enums"�
AssetSetTypeEnum"l
AssetSetType
UNSPECIFIED 
UNKNOWN
	PAGE_FEED
DYNAMIC_EDUCATION
MERCHANT_CENTER_FEEDB�
!com.google.ads.googleads.v9.enumsBAssetSetTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v9/enums;enums�GAA�Google.Ads.GoogleAds.V9.Enums�Google\\Ads\\GoogleAds\\V9\\Enums�!Google::Ads::GoogleAds::V9::Enumsbproto3
�
9google/ads/googleads/v9/enums/response_content_type.protogoogle.ads.googleads.v9.enums"o
ResponseContentTypeEnum"T
ResponseContentType
UNSPECIFIED 
RESOURCE_NAME_ONLY
MUTABLE_RESOURCEB�
!com.google.ads.googleads.v9.enumsBResponseContentTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v9/enums;enums�GAA�Google.Ads.GoogleAds.V9.Enums�Google\\Ads\\GoogleAds\\V9\\Enums�!Google::Ads::GoogleAds::V9::Enumsbproto3
�
1google/ads/googleads/v9/resources/asset_set.proto!google.ads.googleads.v9.resources2google/ads/googleads/v9/enums/asset_set_type.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/api/annotations.proto"�
AssetSet@
resource_name (	B)�A�A#
!googleads.googleapis.com/AssetSet
name (	B�AR
type (2<.google.ads.googleads.v9.enums.AssetSetTypeEnum.AssetSetTypeB�A�AU
status (2@.google.ads.googleads.v9.enums.AssetSetStatusEnum.AssetSetStatusB�A\\
merchant_center_feed (2>.google.ads.googleads.v9.resources.AssetSet.MerchantCenterFeed[
MerchantCenterFeed
merchant_id (B�A

feed_label (	B�AH �B
_feed_label:X�AU
!googleads.googleapis.com/AssetSet0customers/{customer_id}/assetSets/{asset_set_id}B�
%com.google.ads.googleads.v9.resourcesBAssetSetProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v9/resources;resources�GAA�!Google.Ads.GoogleAds.V9.Resources�!Google\\Ads\\GoogleAds\\V9\\Resources�%Google::Ads::GoogleAds::V9::Resourcesbproto3
�
8google/ads/googleads/v9/services/asset_set_service.proto google.ads.googleads.v9.services1google/ads/googleads/v9/resources/asset_set.protogoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.proto google/protobuf/field_mask.protogoogle/rpc/status.proto"�
MutateAssetSetsRequest
customer_id (	B�AL

operations (23.google.ads.googleads.v9.services.AssetSetOperationB�A
partial_failure (
validate_only (i
response_content_type (2J.google.ads.googleads.v9.enums.ResponseContentTypeEnum.ResponseContentType"�
AssetSetOperation/
update_mask (2.google.protobuf.FieldMask=
create (2+.google.ads.googleads.v9.resources.AssetSetH =
update (2+.google.ads.googleads.v9.resources.AssetSetH 
remove (	H B
	operation"�
MutateAssetSetsResponseG
results (26.google.ads.googleads.v9.services.MutateAssetSetResult1
partial_failure_error (2.google.rpc.Status"m
MutateAssetSetResult
resource_name (	>
	asset_set (2+.google.ads.googleads.v9.resources.AssetSet2�
AssetSetService�
MutateAssetSets8.google.ads.googleads.v9.services.MutateAssetSetsRequest9.google.ads.googleads.v9.services.MutateAssetSetsResponse"R���3"./v9/customers/{customer_id=*}/assetSets:mutate:*�Acustomer_id,operationsE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v9.servicesBAssetSetServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v9/services;services�GAA� Google.Ads.GoogleAds.V9.Services� Google\\Ads\\GoogleAds\\V9\\Services�$Google::Ads::GoogleAds::V9::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

