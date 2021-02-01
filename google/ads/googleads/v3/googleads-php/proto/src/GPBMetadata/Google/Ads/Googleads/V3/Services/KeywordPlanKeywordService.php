<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v3/services/keyword_plan_keyword_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V3\Services;

class KeywordPlanKeywordService
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();
        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Protobuf\Wrappers::initOnce();
        \GPBMetadata\Google\Api\Http::initOnce();
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Protobuf\Any::initOnce();
        \GPBMetadata\Google\Rpc\Status::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
6google/ads/googleads/v3/enums/keyword_match_type.protogoogle.ads.googleads.v3.enums"j
KeywordMatchTypeEnum"R
KeywordMatchType
UNSPECIFIED 
UNKNOWN	
EXACT

PHRASE	
BROADB�
!com.google.ads.googleads.v3.enumsBKeywordMatchTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
<google/ads/googleads/v3/resources/keyword_plan_keyword.proto!google.ads.googleads.v3.resourcesgoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
KeywordPlanKeywordJ
resource_name (	B3�A�A-
+googleads.googleapis.com/KeywordPlanKeywordm
keyword_plan_ad_group (2.google.protobuf.StringValueB0�A-
+googleads.googleapis.com/KeywordPlanAdGroup,
id (2.google.protobuf.Int64ValueB�A*
text (2.google.protobuf.StringValueX

match_type (2D.google.ads.googleads.v3.enums.KeywordMatchTypeEnum.KeywordMatchType3
cpc_bid_micros (2.google.protobuf.Int64Value:q�An
+googleads.googleapis.com/KeywordPlanKeyword?customers/{customer}/keywordPlanKeywords/{keyword_plan_keyword}B�
%com.google.ads.googleads.v3.resourcesBKeywordPlanKeywordProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v3/resources;resources�GAA�!Google.Ads.GoogleAds.V3.Resources�!Google\\Ads\\GoogleAds\\V3\\Resources�%Google::Ads::GoogleAds::V3::Resourcesbproto3
�
Cgoogle/ads/googleads/v3/services/keyword_plan_keyword_service.proto google.ads.googleads.v3.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto google/protobuf/field_mask.protogoogle/rpc/status.proto"j
GetKeywordPlanKeywordRequestJ
resource_name (	B3�A�A-
+googleads.googleapis.com/KeywordPlanKeyword"�
 MutateKeywordPlanKeywordsRequest
customer_id (	B�AV

operations (2=.google.ads.googleads.v3.services.KeywordPlanKeywordOperationB�A
partial_failure (
validate_only ("�
KeywordPlanKeywordOperation/
update_mask (2.google.protobuf.FieldMaskG
create (25.google.ads.googleads.v3.resources.KeywordPlanKeywordH G
update (25.google.ads.googleads.v3.resources.KeywordPlanKeywordH B
remove (	B0�A-
+googleads.googleapis.com/KeywordPlanKeywordH B
	operation"�
!MutateKeywordPlanKeywordsResponse1
partial_failure_error (2.google.rpc.StatusQ
results (2@.google.ads.googleads.v3.services.MutateKeywordPlanKeywordResult"7
MutateKeywordPlanKeywordResult
resource_name (	2�
KeywordPlanKeywordService�
GetKeywordPlanKeyword>.google.ads.googleads.v3.services.GetKeywordPlanKeywordRequest5.google.ads.googleads.v3.resources.KeywordPlanKeyword"M���75/v3/{resource_name=customers/*/keywordPlanKeywords/*}�Aresource_name�
MutateKeywordPlanKeywordsB.google.ads.googleads.v3.services.MutateKeywordPlanKeywordsRequestC.google.ads.googleads.v3.services.MutateKeywordPlanKeywordsResponse"\\���="8/v3/customers/{customer_id=*}/keywordPlanKeywords:mutate:*�Acustomer_id,operationsE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v3.servicesBKeywordPlanKeywordServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v3/services;services�GAA� Google.Ads.GoogleAds.V3.Services� Google\\Ads\\GoogleAds\\V3\\Services�$Google::Ads::GoogleAds::V3::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

