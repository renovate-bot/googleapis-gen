<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v4/services/keyword_plan_ad_group_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V4\Services;

class KeywordPlanAdGroupService
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
�
=google/ads/googleads/v4/resources/keyword_plan_ad_group.proto!google.ads.googleads.v4.resourcesgoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
KeywordPlanAdGroupJ
resource_name (	B3�A�A-
+googleads.googleapis.com/KeywordPlanAdGroupn
keyword_plan_campaign (2.google.protobuf.StringValueB1�A.
,googleads.googleapis.com/KeywordPlanCampaign,
id (2.google.protobuf.Int64ValueB�A*
name (2.google.protobuf.StringValue3
cpc_bid_micros (2.google.protobuf.Int64Value:r�Ao
+googleads.googleapis.com/KeywordPlanAdGroup@customers/{customer}/keywordPlanAdGroups/{keyword_plan_ad_group}B�
%com.google.ads.googleads.v4.resourcesBKeywordPlanAdGroupProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v4/resources;resources�GAA�!Google.Ads.GoogleAds.V4.Resources�!Google\\Ads\\GoogleAds\\V4\\Resources�%Google::Ads::GoogleAds::V4::Resourcesbproto3
�
Dgoogle/ads/googleads/v4/services/keyword_plan_ad_group_service.proto google.ads.googleads.v4.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto google/protobuf/field_mask.protogoogle/rpc/status.proto"j
GetKeywordPlanAdGroupRequestJ
resource_name (	B3�A�A-
+googleads.googleapis.com/KeywordPlanAdGroup"�
 MutateKeywordPlanAdGroupsRequest
customer_id (	B�AV

operations (2=.google.ads.googleads.v4.services.KeywordPlanAdGroupOperationB�A
partial_failure (
validate_only ("�
KeywordPlanAdGroupOperation/
update_mask (2.google.protobuf.FieldMaskG
create (25.google.ads.googleads.v4.resources.KeywordPlanAdGroupH G
update (25.google.ads.googleads.v4.resources.KeywordPlanAdGroupH B
remove (	B0�A-
+googleads.googleapis.com/KeywordPlanAdGroupH B
	operation"�
!MutateKeywordPlanAdGroupsResponse1
partial_failure_error (2.google.rpc.StatusQ
results (2@.google.ads.googleads.v4.services.MutateKeywordPlanAdGroupResult"7
MutateKeywordPlanAdGroupResult
resource_name (	2�
KeywordPlanAdGroupService�
GetKeywordPlanAdGroup>.google.ads.googleads.v4.services.GetKeywordPlanAdGroupRequest5.google.ads.googleads.v4.resources.KeywordPlanAdGroup"M���75/v4/{resource_name=customers/*/keywordPlanAdGroups/*}�Aresource_name�
MutateKeywordPlanAdGroupsB.google.ads.googleads.v4.services.MutateKeywordPlanAdGroupsRequestC.google.ads.googleads.v4.services.MutateKeywordPlanAdGroupsResponse"\\���="8/v4/customers/{customer_id=*}/keywordPlanAdGroups:mutate:*�Acustomer_id,operationsE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v4.servicesBKeywordPlanAdGroupServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v4/services;services�GAA� Google.Ads.GoogleAds.V4.Services� Google\\Ads\\GoogleAds\\V4\\Services�$Google::Ads::GoogleAds::V4::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

