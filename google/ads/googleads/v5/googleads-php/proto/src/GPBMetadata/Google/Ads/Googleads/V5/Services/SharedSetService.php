<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v5/services/shared_set_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V5\Services;

class SharedSetService
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();
        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Http::initOnce();
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Protobuf\Any::initOnce();
        \GPBMetadata\Google\Rpc\Status::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
9google/ads/googleads/v5/enums/response_content_type.protogoogle.ads.googleads.v5.enums"o
ResponseContentTypeEnum"T
ResponseContentType
UNSPECIFIED 
RESOURCE_NAME_ONLY
MUTABLE_RESOURCEB�
!com.google.ads.googleads.v5.enumsBResponseContentTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
5google/ads/googleads/v5/enums/shared_set_status.protogoogle.ads.googleads.v5.enums"`
SharedSetStatusEnum"I
SharedSetStatus
UNSPECIFIED 
UNKNOWN
ENABLED
REMOVEDB�
!com.google.ads.googleads.v5.enumsBSharedSetStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
3google/ads/googleads/v5/enums/shared_set_type.protogoogle.ads.googleads.v5.enums"r
SharedSetTypeEnum"]
SharedSetType
UNSPECIFIED 
UNKNOWN
NEGATIVE_KEYWORDS
NEGATIVE_PLACEMENTSB�
!com.google.ads.googleads.v5.enumsBSharedSetTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
2google/ads/googleads/v5/resources/shared_set.proto!google.ads.googleads.v5.resources3google/ads/googleads/v5/enums/shared_set_type.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/api/annotations.proto"�
	SharedSetA
resource_name (	B*�A�A$
"googleads.googleapis.com/SharedSet
id (B�AH �Q
type (2>.google.ads.googleads.v5.enums.SharedSetTypeEnum.SharedSetTypeB�A
name	 (	H�W
status (2B.google.ads.googleads.v5.enums.SharedSetStatusEnum.SharedSetStatusB�A
member_count
 (B�AH�!
reference_count (B�AH�:U�AR
"googleads.googleapis.com/SharedSet,customers/{customer}/sharedSets/{shared_set}B
_idB
_nameB
_member_countB
_reference_countB�
%com.google.ads.googleads.v5.resourcesBSharedSetProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v5/resources;resources�GAA�!Google.Ads.GoogleAds.V5.Resources�!Google\\Ads\\GoogleAds\\V5\\Resources�%Google::Ads::GoogleAds::V5::Resourcesbproto3
�
9google/ads/googleads/v5/services/shared_set_service.proto google.ads.googleads.v5.services2google/ads/googleads/v5/resources/shared_set.protogoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto google/protobuf/field_mask.protogoogle/rpc/status.proto"X
GetSharedSetRequestA
resource_name (	B*�A�A$
"googleads.googleapis.com/SharedSet"�
MutateSharedSetsRequest
customer_id (	B�AM

operations (24.google.ads.googleads.v5.services.SharedSetOperationB�A
partial_failure (
validate_only (i
response_content_type (2J.google.ads.googleads.v5.enums.ResponseContentTypeEnum.ResponseContentType"�
SharedSetOperation/
update_mask (2.google.protobuf.FieldMask>
create (2,.google.ads.googleads.v5.resources.SharedSetH >
update (2,.google.ads.googleads.v5.resources.SharedSetH 
remove (	H B
	operation"�
MutateSharedSetsResponse1
partial_failure_error (2.google.rpc.StatusH
results (27.google.ads.googleads.v5.services.MutateSharedSetResult"p
MutateSharedSetResult
resource_name (	@

shared_set (2,.google.ads.googleads.v5.resources.SharedSet2�
SharedSetService�
GetSharedSet5.google.ads.googleads.v5.services.GetSharedSetRequest,.google.ads.googleads.v5.resources.SharedSet"D���.,/v5/{resource_name=customers/*/sharedSets/*}�Aresource_name�
MutateSharedSets9.google.ads.googleads.v5.services.MutateSharedSetsRequest:.google.ads.googleads.v5.services.MutateSharedSetsResponse"S���4"//v5/customers/{customer_id=*}/sharedSets:mutate:*�Acustomer_id,operationsE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v5.servicesBSharedSetServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v5/services;services�GAA� Google.Ads.GoogleAds.V5.Services� Google\\Ads\\GoogleAds\\V5\\Services�$Google::Ads::GoogleAds::V5::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

