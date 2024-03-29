<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v9/services/campaign_shared_set_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V9\Services;

class CampaignSharedSetService
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
        \GPBMetadata\Google\Api\Client::initOnce();
        \GPBMetadata\Google\Protobuf\Any::initOnce();
        \GPBMetadata\Google\Rpc\Status::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
>google/ads/googleads/v9/enums/campaign_shared_set_status.protogoogle.ads.googleads.v9.enums"p
CampaignSharedSetStatusEnum"Q
CampaignSharedSetStatus
UNSPECIFIED 
UNKNOWN
ENABLED
REMOVEDB�
!com.google.ads.googleads.v9.enumsBCampaignSharedSetStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v9/enums;enums�GAA�Google.Ads.GoogleAds.V9.Enums�Google\\Ads\\GoogleAds\\V9\\Enums�!Google::Ads::GoogleAds::V9::Enumsbproto3
�
9google/ads/googleads/v9/enums/response_content_type.protogoogle.ads.googleads.v9.enums"o
ResponseContentTypeEnum"T
ResponseContentType
UNSPECIFIED 
RESOURCE_NAME_ONLY
MUTABLE_RESOURCEB�
!com.google.ads.googleads.v9.enumsBResponseContentTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v9/enums;enums�GAA�Google.Ads.GoogleAds.V9.Enums�Google\\Ads\\GoogleAds\\V9\\Enums�!Google::Ads::GoogleAds::V9::Enumsbproto3
�
;google/ads/googleads/v9/resources/campaign_shared_set.proto!google.ads.googleads.v9.resourcesgoogle/api/field_behavior.protogoogle/api/resource.protogoogle/api/annotations.proto"�
CampaignSharedSetI
resource_name (	B2�A�A,
*googleads.googleapis.com/CampaignSharedSet@
campaign (	B)�A�A#
!googleads.googleapis.com/CampaignH �C

shared_set (	B*�A�A$
"googleads.googleapis.com/SharedSetH�g
status (2R.google.ads.googleads.v9.enums.CampaignSharedSetStatusEnum.CampaignSharedSetStatusB�A:y�Av
*googleads.googleapis.com/CampaignSharedSetHcustomers/{customer_id}/campaignSharedSets/{campaign_id}~{shared_set_id}B
	_campaignB
_shared_setB�
%com.google.ads.googleads.v9.resourcesBCampaignSharedSetProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v9/resources;resources�GAA�!Google.Ads.GoogleAds.V9.Resources�!Google\\Ads\\GoogleAds\\V9\\Resources�%Google::Ads::GoogleAds::V9::Resourcesbproto3
�
Bgoogle/ads/googleads/v9/services/campaign_shared_set_service.proto google.ads.googleads.v9.services;google/ads/googleads/v9/resources/campaign_shared_set.protogoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/rpc/status.proto"h
GetCampaignSharedSetRequestI
resource_name (	B2�A�A,
*googleads.googleapis.com/CampaignSharedSet"�
MutateCampaignSharedSetsRequest
customer_id (	B�AU

operations (2<.google.ads.googleads.v9.services.CampaignSharedSetOperationB�A
partial_failure (
validate_only (i
response_content_type (2J.google.ads.googleads.v9.enums.ResponseContentTypeEnum.ResponseContentType"�
CampaignSharedSetOperationF
create (24.google.ads.googleads.v9.resources.CampaignSharedSetH 
remove (	H B
	operation"�
 MutateCampaignSharedSetsResponse1
partial_failure_error (2.google.rpc.StatusP
results (2?.google.ads.googleads.v9.services.MutateCampaignSharedSetResult"�
MutateCampaignSharedSetResult
resource_name (	Q
campaign_shared_set (24.google.ads.googleads.v9.resources.CampaignSharedSet2�
CampaignSharedSetService�
GetCampaignSharedSet=.google.ads.googleads.v9.services.GetCampaignSharedSetRequest4.google.ads.googleads.v9.resources.CampaignSharedSet"L���64/v9/{resource_name=customers/*/campaignSharedSets/*}�Aresource_name�
MutateCampaignSharedSetsA.google.ads.googleads.v9.services.MutateCampaignSharedSetsRequestB.google.ads.googleads.v9.services.MutateCampaignSharedSetsResponse"[���<"7/v9/customers/{customer_id=*}/campaignSharedSets:mutate:*�Acustomer_id,operationsE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v9.servicesBCampaignSharedSetServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v9/services;services�GAA� Google.Ads.GoogleAds.V9.Services� Google\\Ads\\GoogleAds\\V9\\Services�$Google::Ads::GoogleAds::V9::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

