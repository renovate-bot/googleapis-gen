<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v4/services/ad_group_simulation_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V4\Services;

class AdGroupSimulationService
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
        $pool->internalAddGeneratedFile(
            '
�
/google/ads/googleads/v4/common/simulation.protogoogle.ads.googleads.v4.commongoogle/api/annotations.proto"l
BidModifierSimulationPointListJ
points (2:.google.ads.googleads.v4.common.BidModifierSimulationPoint"b
CpcBidSimulationPointListE
points (25.google.ads.googleads.v4.common.CpcBidSimulationPoint"b
CpvBidSimulationPointListE
points (25.google.ads.googleads.v4.common.CpvBidSimulationPoint"h
TargetCpaSimulationPointListH
points (28.google.ads.googleads.v4.common.TargetCpaSimulationPoint"j
TargetRoasSimulationPointListI
points (29.google.ads.googleads.v4.common.TargetRoasSimulationPoint"�
BidModifierSimulationPoint2
bid_modifier (2.google.protobuf.DoubleValue:
biddable_conversions (2.google.protobuf.DoubleValue@
biddable_conversions_value (2.google.protobuf.DoubleValue+
clicks (2.google.protobuf.Int64Value0
cost_micros (2.google.protobuf.Int64Value0
impressions (2.google.protobuf.Int64Value9
top_slot_impressions (2.google.protobuf.Int64ValueA
parent_biddable_conversions (2.google.protobuf.DoubleValueG
!parent_biddable_conversions_value	 (2.google.protobuf.DoubleValue2
parent_clicks
 (2.google.protobuf.Int64Value7
parent_cost_micros (2.google.protobuf.Int64Value7
parent_impressions (2.google.protobuf.Int64Value@
parent_top_slot_impressions (2.google.protobuf.Int64ValueB
parent_required_budget_micros (2.google.protobuf.Int64Value"�
CpcBidSimulationPoint3
cpc_bid_micros (2.google.protobuf.Int64Value:
biddable_conversions (2.google.protobuf.DoubleValue@
biddable_conversions_value (2.google.protobuf.DoubleValue+
clicks (2.google.protobuf.Int64Value0
cost_micros (2.google.protobuf.Int64Value0
impressions (2.google.protobuf.Int64Value9
top_slot_impressions (2.google.protobuf.Int64Value"�
CpvBidSimulationPoint3
cpv_bid_micros (2.google.protobuf.Int64Value0
cost_micros (2.google.protobuf.Int64Value0
impressions (2.google.protobuf.Int64Value*
views (2.google.protobuf.Int64Value"�
TargetCpaSimulationPoint6
target_cpa_micros (2.google.protobuf.Int64Value:
biddable_conversions (2.google.protobuf.DoubleValue@
biddable_conversions_value (2.google.protobuf.DoubleValue+
clicks (2.google.protobuf.Int64Value0
cost_micros (2.google.protobuf.Int64Value0
impressions (2.google.protobuf.Int64Value9
top_slot_impressions (2.google.protobuf.Int64Value"�
TargetRoasSimulationPoint1
target_roas (2.google.protobuf.DoubleValue:
biddable_conversions (2.google.protobuf.DoubleValue@
biddable_conversions_value (2.google.protobuf.DoubleValue+
clicks (2.google.protobuf.Int64Value0
cost_micros (2.google.protobuf.Int64Value0
impressions (2.google.protobuf.Int64Value9
top_slot_impressions (2.google.protobuf.Int64ValueB�
"com.google.ads.googleads.v4.commonBSimulationProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v4/common;common�GAA�Google.Ads.GoogleAds.V4.Common�Google\\Ads\\GoogleAds\\V4\\Common�"Google::Ads::GoogleAds::V4::Commonbproto3
�
Bgoogle/ads/googleads/v4/enums/simulation_modification_method.protogoogle.ads.googleads.v4.enums"z
 SimulationModificationMethodEnum"V
SimulationModificationMethod
UNSPECIFIED 
UNKNOWN
UNIFORM
DEFAULTB�
!com.google.ads.googleads.v4.enumsB!SimulationModificationMethodProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v4/enums;enums�GAA�Google.Ads.GoogleAds.V4.Enums�Google\\Ads\\GoogleAds\\V4\\Enums�!Google::Ads::GoogleAds::V4::Enumsbproto3
�
3google/ads/googleads/v4/enums/simulation_type.protogoogle.ads.googleads.v4.enums"�
SimulationTypeEnum"{
SimulationType
UNSPECIFIED 
UNKNOWN
CPC_BID
CPV_BID

TARGET_CPA
BID_MODIFIER
TARGET_ROASB�
!com.google.ads.googleads.v4.enumsBSimulationTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v4/enums;enums�GAA�Google.Ads.GoogleAds.V4.Enums�Google\\Ads\\GoogleAds\\V4\\Enums�!Google::Ads::GoogleAds::V4::Enumsbproto3
�
;google/ads/googleads/v4/resources/ad_group_simulation.proto!google.ads.googleads.v4.resourcesBgoogle/ads/googleads/v4/enums/simulation_modification_method.proto3google/ads/googleads/v4/enums/simulation_type.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
AdGroupSimulationI
resource_name (	B2�A�A,
*googleads.googleapis.com/AdGroupSimulation5
ad_group_id (2.google.protobuf.Int64ValueB�AS
type (2@.google.ads.googleads.v4.enums.SimulationTypeEnum.SimulationTypeB�A~
modification_method (2\\.google.ads.googleads.v4.enums.SimulationModificationMethodEnum.SimulationModificationMethodB�A5

start_date (2.google.protobuf.StringValueB�A3
end_date (2.google.protobuf.StringValueB�A\\
cpc_bid_point_list (29.google.ads.googleads.v4.common.CpcBidSimulationPointListB�AH \\
cpv_bid_point_list
 (29.google.ads.googleads.v4.common.CpvBidSimulationPointListB�AH b
target_cpa_point_list	 (2<.google.ads.googleads.v4.common.TargetCpaSimulationPointListB�AH d
target_roas_point_list (2=.google.ads.googleads.v4.common.TargetRoasSimulationPointListB�AH :n�Ak
*googleads.googleapis.com/AdGroupSimulation=customers/{customer}/adGroupSimulations/{ad_group_simulation}B

point_listB�
%com.google.ads.googleads.v4.resourcesBAdGroupSimulationProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v4/resources;resources�GAA�!Google.Ads.GoogleAds.V4.Resources�!Google\\Ads\\GoogleAds\\V4\\Resources�%Google::Ads::GoogleAds::V4::Resourcesbproto3
�
Bgoogle/ads/googleads/v4/services/ad_group_simulation_service.proto google.ads.googleads.v4.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto"h
GetAdGroupSimulationRequestI
resource_name (	B2�A�A,
*googleads.googleapis.com/AdGroupSimulation2�
AdGroupSimulationService�
GetAdGroupSimulation=.google.ads.googleads.v4.services.GetAdGroupSimulationRequest4.google.ads.googleads.v4.resources.AdGroupSimulation"L���64/v4/{resource_name=customers/*/adGroupSimulations/*}�Aresource_nameE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v4.servicesBAdGroupSimulationServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v4/services;services�GAA� Google.Ads.GoogleAds.V4.Services� Google\\Ads\\GoogleAds\\V4\\Services�$Google::Ads::GoogleAds::V4::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

