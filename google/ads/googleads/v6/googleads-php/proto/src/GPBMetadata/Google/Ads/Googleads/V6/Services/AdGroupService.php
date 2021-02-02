<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v6/services/ad_group_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V6\Services;

class AdGroupService
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
        \GPBMetadata\Google\Protobuf\Any::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        \GPBMetadata\Google\Rpc\Status::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
5google/ads/googleads/v6/common/custom_parameter.protogoogle.ads.googleads.v6.common"I
CustomParameter
key (	H �
value (	H�B
_keyB
_valueB�
"com.google.ads.googleads.v6.commonBCustomParameterProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v6/common;common�GAA�Google.Ads.GoogleAds.V6.Common�Google\\Ads\\GoogleAds\\V6\\Common�"Google::Ads::GoogleAds::V6::Commonbproto3
�
Dgoogle/ads/googleads/v6/common/explorer_auto_optimizer_setting.protogoogle.ads.googleads.v6.common">
ExplorerAutoOptimizerSetting
opt_in (H �B	
_opt_inB�
"com.google.ads.googleads.v6.commonB!ExplorerAutoOptimizerSettingProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v6/common;common�GAA�Google.Ads.GoogleAds.V6.Common�Google\\Ads\\GoogleAds\\V6\\Common�"Google::Ads::GoogleAds::V6::Commonbproto3
�
7google/ads/googleads/v6/enums/targeting_dimension.protogoogle.ads.googleads.v6.enums"�
TargetingDimensionEnum"�
TargetingDimension
UNSPECIFIED 
UNKNOWN
KEYWORD
AUDIENCE	
TOPIC

GENDER
	AGE_RANGE
	PLACEMENT
PARENTAL_STATUS
INCOME_RANGE	B�
!com.google.ads.googleads.v6.enumsBTargetingDimensionProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
6google/ads/googleads/v6/common/targeting_setting.protogoogle.ads.googleads.v6.commongoogle/api/annotations.proto"�
TargetingSettingN
target_restrictions (21.google.ads.googleads.v6.common.TargetRestrictiona
target_restriction_operations (2:.google.ads.googleads.v6.common.TargetRestrictionOperation"�
TargetRestrictione
targeting_dimension (2H.google.ads.googleads.v6.enums.TargetingDimensionEnum.TargetingDimension
bid_only (H �B
	_bid_only"�
TargetRestrictionOperationU
operator (2C.google.ads.googleads.v6.common.TargetRestrictionOperation.Operator@
value (21.google.ads.googleads.v6.common.TargetRestriction"=
Operator
UNSPECIFIED 
UNKNOWN
ADD

REMOVEB�
"com.google.ads.googleads.v6.commonBTargetingSettingProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v6/common;common�GAA�Google.Ads.GoogleAds.V6.Common�Google\\Ads\\GoogleAds\\V6\\Common�"Google::Ads::GoogleAds::V6::Commonbproto3
�
=google/ads/googleads/v6/enums/ad_group_ad_rotation_mode.protogoogle.ads.googleads.v6.enums"t
AdGroupAdRotationModeEnum"W
AdGroupAdRotationMode
UNSPECIFIED 
UNKNOWN
OPTIMIZE
ROTATE_FOREVERB�
!com.google.ads.googleads.v6.enumsBAdGroupAdRotationModeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
3google/ads/googleads/v6/enums/ad_group_status.protogoogle.ads.googleads.v6.enums"h
AdGroupStatusEnum"S
AdGroupStatus
UNSPECIFIED 
UNKNOWN
ENABLED

PAUSED
REMOVEDB�
!com.google.ads.googleads.v6.enumsBAdGroupStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
1google/ads/googleads/v6/enums/ad_group_type.protogoogle.ads.googleads.v6.enums"�
AdGroupTypeEnum"�
AdGroupType
UNSPECIFIED 
UNKNOWN
SEARCH_STANDARD
DISPLAY_STANDARD
SHOPPING_PRODUCT_ADS
	HOTEL_ADS
SHOPPING_SMART_ADS
VIDEO_BUMPER
VIDEO_TRUE_VIEW_IN_STREAM	
VIDEO_TRUE_VIEW_IN_DISPLAY
!
VIDEO_NON_SKIPPABLE_IN_STREAM
VIDEO_OUTSTREAM
SEARCH_DYNAMIC_ADS#
SHOPPING_COMPARISON_LISTING_ADS
PROMOTED_HOTEL_ADS
VIDEO_RESPONSIVEB�
!com.google.ads.googleads.v6.enumsBAdGroupTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
2google/ads/googleads/v6/enums/bidding_source.protogoogle.ads.googleads.v6.enums"�
BiddingSourceEnum"r
BiddingSource
UNSPECIFIED 
UNKNOWN
CAMPAIGN_BIDDING_STRATEGY
AD_GROUP
AD_GROUP_CRITERIONB�
!com.google.ads.googleads.v6.enumsBBiddingSourceProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
9google/ads/googleads/v6/enums/response_content_type.protogoogle.ads.googleads.v6.enums"o
ResponseContentTypeEnum"T
ResponseContentType
UNSPECIFIED 
RESOURCE_NAME_ONLY
MUTABLE_RESOURCEB�
!com.google.ads.googleads.v6.enumsBResponseContentTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
0google/ads/googleads/v6/resources/ad_group.proto!google.ads.googleads.v6.resourcesDgoogle/ads/googleads/v6/common/explorer_auto_optimizer_setting.proto6google/ads/googleads/v6/common/targeting_setting.proto=google/ads/googleads/v6/enums/ad_group_ad_rotation_mode.proto3google/ads/googleads/v6/enums/ad_group_status.proto1google/ads/googleads/v6/enums/ad_group_type.proto2google/ads/googleads/v6/enums/bidding_source.proto7google/ads/googleads/v6/enums/targeting_dimension.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/api/annotations.proto"�
AdGroup?
resource_name (	B(�A�A"
 googleads.googleapis.com/AdGroup
id" (B�AH �
name# (	H�N
status (2>.google.ads.googleads.v6.enums.AdGroupStatusEnum.AdGroupStatusM
type (2:.google.ads.googleads.v6.enums.AdGroupTypeEnum.AdGroupTypeB�Ah
ad_rotation_mode (2N.google.ads.googleads.v6.enums.AdGroupAdRotationModeEnum.AdGroupAdRotationModeD
base_ad_group$ (	B(�A�A"
 googleads.googleapis.com/AdGroupH�"
tracking_url_template% (	H�N
url_custom_parameters (2/.google.ads.googleads.v6.common.CustomParameter@
campaign& (	B)�A�A#
!googleads.googleapis.com/CampaignH�
cpc_bid_micros\' (H�
cpm_bid_micros( (H�
target_cpa_micros) (H� 
cpv_bid_micros* (B�AH�
target_cpm_micros+ (H	�
target_roas, (H
�#
percent_cpc_bid_micros- (H�e
explorer_auto_optimizer_setting (2<.google.ads.googleads.v6.common.ExplorerAutoOptimizerSettingn
display_custom_bid_dimension (2H.google.ads.googleads.v6.enums.TargetingDimensionEnum.TargetingDimension
final_url_suffix. (	H�K
targeting_setting (20.google.ads.googleads.v6.common.TargetingSetting-
effective_target_cpa_micros/ (B�AH�h
effective_target_cpa_source (2>.google.ads.googleads.v6.enums.BiddingSourceEnum.BiddingSourceB�A\'
effective_target_roas0 (B�AH�i
effective_target_roas_source  (2>.google.ads.googleads.v6.enums.BiddingSourceEnum.BiddingSourceB�A=
labels1 (	B-�A�A\'
%googleads.googleapis.com/AdGroupLabel:U�AR
 googleads.googleapis.com/AdGroup.customers/{customer_id}/adGroups/{ad_group_id}B
_idB
_nameB
_base_ad_groupB
_tracking_url_templateB
	_campaignB
_cpc_bid_microsB
_cpm_bid_microsB
_target_cpa_microsB
_cpv_bid_microsB
_target_cpm_microsB
_target_roasB
_percent_cpc_bid_microsB
_final_url_suffixB
_effective_target_cpa_microsB
_effective_target_roasB�
%com.google.ads.googleads.v6.resourcesBAdGroupProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v6/resources;resources�GAA�!Google.Ads.GoogleAds.V6.Resources�!Google\\Ads\\GoogleAds\\V6\\Resources�%Google::Ads::GoogleAds::V6::Resourcesbproto3
�
7google/ads/googleads/v6/services/ad_group_service.proto google.ads.googleads.v6.services0google/ads/googleads/v6/resources/ad_group.protogoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto google/protobuf/field_mask.protogoogle/rpc/status.proto"T
GetAdGroupRequest?
resource_name (	B(�A�A"
 googleads.googleapis.com/AdGroup"�
MutateAdGroupsRequest
customer_id (	B�AK

operations (22.google.ads.googleads.v6.services.AdGroupOperationB�A
partial_failure (
validate_only (i
response_content_type (2J.google.ads.googleads.v6.enums.ResponseContentTypeEnum.ResponseContentType"�
AdGroupOperation/
update_mask (2.google.protobuf.FieldMask<
create (2*.google.ads.googleads.v6.resources.AdGroupH <
update (2*.google.ads.googleads.v6.resources.AdGroupH 
remove (	H B
	operation"�
MutateAdGroupsResponse1
partial_failure_error (2.google.rpc.StatusF
results (25.google.ads.googleads.v6.services.MutateAdGroupResult"j
MutateAdGroupResult
resource_name (	<
ad_group (2*.google.ads.googleads.v6.resources.AdGroup2�
AdGroupService�

GetAdGroup3.google.ads.googleads.v6.services.GetAdGroupRequest*.google.ads.googleads.v6.resources.AdGroup"B���,*/v6/{resource_name=customers/*/adGroups/*}�Aresource_name�
MutateAdGroups7.google.ads.googleads.v6.services.MutateAdGroupsRequest8.google.ads.googleads.v6.services.MutateAdGroupsResponse"Q���2"-/v6/customers/{customer_id=*}/adGroups:mutate:*�Acustomer_id,operationsE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v6.servicesBAdGroupServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v6/services;services�GAA� Google.Ads.GoogleAds.V6.Services� Google\\Ads\\GoogleAds\\V6\\Services�$Google::Ads::GoogleAds::V6::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

