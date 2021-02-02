<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v5/services/keyword_plan_campaign_keyword_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V5\Services;

class KeywordPlanCampaignKeywordService
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();
        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Http::initOnce();
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Protobuf\Wrappers::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Protobuf\Any::initOnce();
        \GPBMetadata\Google\Rpc\Status::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
6google/ads/googleads/v5/enums/keyword_match_type.protogoogle.ads.googleads.v5.enums"j
KeywordMatchTypeEnum"R
KeywordMatchType
UNSPECIFIED 
UNKNOWN	
EXACT

PHRASE	
BROADB�
!com.google.ads.googleads.v5.enumsBKeywordMatchTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
Egoogle/ads/googleads/v5/resources/keyword_plan_campaign_keyword.proto!google.ads.googleads.v5.resourcesgoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
KeywordPlanCampaignKeywordR
resource_name (	B;�A�A5
3googleads.googleapis.com/KeywordPlanCampaignKeywordn
keyword_plan_campaign (2.google.protobuf.StringValueB1�A.
,googleads.googleapis.com/KeywordPlanCampaign,
id (2.google.protobuf.Int64ValueB�A*
text (2.google.protobuf.StringValueX

match_type (2D.google.ads.googleads.v5.enums.KeywordMatchTypeEnum.KeywordMatchType1
negative (2.google.protobuf.BoolValueB�A:��A�
3googleads.googleapis.com/KeywordPlanCampaignKeywordPcustomers/{customer}/keywordPlanCampaignKeywords/{keyword_plan_campaign_keyword}B�
%com.google.ads.googleads.v5.resourcesBKeywordPlanCampaignKeywordProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v5/resources;resources�GAA�!Google.Ads.GoogleAds.V5.Resources�!Google\\Ads\\GoogleAds\\V5\\Resources�%Google::Ads::GoogleAds::V5::Resourcesbproto3
�
Lgoogle/ads/googleads/v5/services/keyword_plan_campaign_keyword_service.proto google.ads.googleads.v5.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto google/protobuf/field_mask.protogoogle/rpc/status.proto"z
$GetKeywordPlanCampaignKeywordRequestR
resource_name (	B;�A�A5
3googleads.googleapis.com/KeywordPlanCampaignKeyword"�
(MutateKeywordPlanCampaignKeywordsRequest
customer_id (	B�A^

operations (2E.google.ads.googleads.v5.services.KeywordPlanCampaignKeywordOperationB�A
partial_failure (
validate_only ("�
#KeywordPlanCampaignKeywordOperation/
update_mask (2.google.protobuf.FieldMaskO
create (2=.google.ads.googleads.v5.resources.KeywordPlanCampaignKeywordH O
update (2=.google.ads.googleads.v5.resources.KeywordPlanCampaignKeywordH J
remove (	B8�A5
3googleads.googleapis.com/KeywordPlanCampaignKeywordH B
	operation"�
)MutateKeywordPlanCampaignKeywordsResponse1
partial_failure_error (2.google.rpc.StatusY
results (2H.google.ads.googleads.v5.services.MutateKeywordPlanCampaignKeywordResult"?
&MutateKeywordPlanCampaignKeywordResult
resource_name (	2�
!KeywordPlanCampaignKeywordService�
GetKeywordPlanCampaignKeywordF.google.ads.googleads.v5.services.GetKeywordPlanCampaignKeywordRequest=.google.ads.googleads.v5.resources.KeywordPlanCampaignKeyword"U���?=/v5/{resource_name=customers/*/keywordPlanCampaignKeywords/*}�Aresource_name�
!MutateKeywordPlanCampaignKeywordsJ.google.ads.googleads.v5.services.MutateKeywordPlanCampaignKeywordsRequestK.google.ads.googleads.v5.services.MutateKeywordPlanCampaignKeywordsResponse"d���E"@/v5/customers/{customer_id=*}/keywordPlanCampaignKeywords:mutate:*�Acustomer_id,operationsE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v5.servicesB&KeywordPlanCampaignKeywordServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v5/services;services�GAA� Google.Ads.GoogleAds.V5.Services� Google\\Ads\\GoogleAds\\V5\\Services�$Google::Ads::GoogleAds::V5::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

