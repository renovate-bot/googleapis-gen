<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v3/services/ad_group_criterion_simulation_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V3\Services;

class AdGroupCriterionSimulationService
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
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
/google/ads/googleads/v3/common/simulation.protogoogle.ads.googleads.v3.commongoogle/api/annotations.proto"l
BidModifierSimulationPointListJ
points (2:.google.ads.googleads.v3.common.BidModifierSimulationPoint"b
CpcBidSimulationPointListE
points (25.google.ads.googleads.v3.common.CpcBidSimulationPoint"b
CpvBidSimulationPointListE
points (25.google.ads.googleads.v3.common.CpvBidSimulationPoint"h
TargetCpaSimulationPointListH
points (28.google.ads.googleads.v3.common.TargetCpaSimulationPoint"�
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
top_slot_impressions (2.google.protobuf.Int64ValueB�
"com.google.ads.googleads.v3.commonBSimulationProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v3/common;common�GAA�Google.Ads.GoogleAds.V3.Common�Google\\Ads\\GoogleAds\\V3\\Common�"Google::Ads::GoogleAds::V3::Commonbproto3
�
Bgoogle/ads/googleads/v3/enums/simulation_modification_method.protogoogle.ads.googleads.v3.enums"z
 SimulationModificationMethodEnum"V
SimulationModificationMethod
UNSPECIFIED 
UNKNOWN
UNIFORM
DEFAULTB�
!com.google.ads.googleads.v3.enumsB!SimulationModificationMethodProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
3google/ads/googleads/v3/enums/simulation_type.protogoogle.ads.googleads.v3.enums"�
SimulationTypeEnum"j
SimulationType
UNSPECIFIED 
UNKNOWN
CPC_BID
CPV_BID

TARGET_CPA
BID_MODIFIERB�
!com.google.ads.googleads.v3.enumsBSimulationTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
Egoogle/ads/googleads/v3/resources/ad_group_criterion_simulation.proto!google.ads.googleads.v3.resourcesBgoogle/ads/googleads/v3/enums/simulation_modification_method.proto3google/ads/googleads/v3/enums/simulation_type.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
AdGroupCriterionSimulationR
resource_name (	B;�A�A5
3googleads.googleapis.com/AdGroupCriterionSimulation5
ad_group_id (2.google.protobuf.Int64ValueB�A6
criterion_id (2.google.protobuf.Int64ValueB�AS
type (2@.google.ads.googleads.v3.enums.SimulationTypeEnum.SimulationTypeB�A~
modification_method (2\\.google.ads.googleads.v3.enums.SimulationModificationMethodEnum.SimulationModificationMethodB�A5

start_date (2.google.protobuf.StringValueB�A3
end_date (2.google.protobuf.StringValueB�A\\
cpc_bid_point_list (29.google.ads.googleads.v3.common.CpcBidSimulationPointListB�AH :��A�
3googleads.googleapis.com/AdGroupCriterionSimulationPcustomers/{customer}/adGroupCriterionSimulations/{ad_group_criterion_simulation}B

point_listB�
%com.google.ads.googleads.v3.resourcesBAdGroupCriterionSimulationProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v3/resources;resources�GAA�!Google.Ads.GoogleAds.V3.Resources�!Google\\Ads\\GoogleAds\\V3\\Resources�%Google::Ads::GoogleAds::V3::Resourcesbproto3
�
Lgoogle/ads/googleads/v3/services/ad_group_criterion_simulation_service.proto google.ads.googleads.v3.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto"z
$GetAdGroupCriterionSimulationRequestR
resource_name (	B;�A�A5
3googleads.googleapis.com/AdGroupCriterionSimulation2�
!AdGroupCriterionSimulationService�
GetAdGroupCriterionSimulationF.google.ads.googleads.v3.services.GetAdGroupCriterionSimulationRequest=.google.ads.googleads.v3.resources.AdGroupCriterionSimulation"U���?=/v3/{resource_name=customers/*/adGroupCriterionSimulations/*}�Aresource_nameE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v3.servicesB&AdGroupCriterionSimulationServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v3/services;services�GAA� Google.Ads.GoogleAds.V3.Services� Google\\Ads\\GoogleAds\\V3\\Services�$Google::Ads::GoogleAds::V3::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

