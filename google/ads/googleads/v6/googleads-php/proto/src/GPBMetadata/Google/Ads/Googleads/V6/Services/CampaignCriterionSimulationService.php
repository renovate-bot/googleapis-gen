<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v6/services/campaign_criterion_simulation_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V6\Services;

class CampaignCriterionSimulationService
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
        $pool->internalAddGeneratedFile(
            '
�
/google/ads/googleads/v6/common/simulation.protogoogle.ads.googleads.v6.common"l
BidModifierSimulationPointListJ
points (2:.google.ads.googleads.v6.common.BidModifierSimulationPoint"b
CpcBidSimulationPointListE
points (25.google.ads.googleads.v6.common.CpcBidSimulationPoint"b
CpvBidSimulationPointListE
points (25.google.ads.googleads.v6.common.CpvBidSimulationPoint"h
TargetCpaSimulationPointListH
points (28.google.ads.googleads.v6.common.TargetCpaSimulationPoint"j
TargetRoasSimulationPointListI
points (29.google.ads.googleads.v6.common.TargetRoasSimulationPoint"p
 PercentCpcBidSimulationPointListL
points (2<.google.ads.googleads.v6.common.PercentCpcBidSimulationPoint"�
BidModifierSimulationPoint
bid_modifier (H �!
biddable_conversions (H�\'
biddable_conversions_value (H�
clicks (H�
cost_micros (H�
impressions (H�!
top_slot_impressions (H�(
parent_biddable_conversions (H�.
!parent_biddable_conversions_value (H�
parent_clicks (H	�
parent_cost_micros (H
�
parent_impressions (H�(
parent_top_slot_impressions (H�*
parent_required_budget_micros (H�B
_bid_modifierB
_biddable_conversionsB
_biddable_conversions_valueB	
_clicksB
_cost_microsB
_impressionsB
_top_slot_impressionsB
_parent_biddable_conversionsB$
"_parent_biddable_conversions_valueB
_parent_clicksB
_parent_cost_microsB
_parent_impressionsB
_parent_top_slot_impressionsB 
_parent_required_budget_micros"�
CpcBidSimulationPoint
cpc_bid_micros (H �!
biddable_conversions	 (H�\'
biddable_conversions_value
 (H�
clicks (H�
cost_micros (H�
impressions (H�!
top_slot_impressions (H�B
_cpc_bid_microsB
_biddable_conversionsB
_biddable_conversions_valueB	
_clicksB
_cost_microsB
_impressionsB
_top_slot_impressions"�
CpvBidSimulationPoint
cpv_bid_micros (H �
cost_micros (H�
impressions (H�
views (H�B
_cpv_bid_microsB
_cost_microsB
_impressionsB
_views"�
TargetCpaSimulationPoint
target_cpa_micros (H �!
biddable_conversions	 (H�\'
biddable_conversions_value
 (H�
clicks (H�
cost_micros (H�
impressions (H�!
top_slot_impressions (H�B
_target_cpa_microsB
_biddable_conversionsB
_biddable_conversions_valueB	
_clicksB
_cost_microsB
_impressionsB
_top_slot_impressions"�
TargetRoasSimulationPoint
target_roas (H �!
biddable_conversions	 (H�\'
biddable_conversions_value
 (H�
clicks (H�
cost_micros (H�
impressions (H�!
top_slot_impressions (H�B
_target_roasB
_biddable_conversionsB
_biddable_conversions_valueB	
_clicksB
_cost_microsB
_impressionsB
_top_slot_impressions"�
PercentCpcBidSimulationPoint#
percent_cpc_bid_micros (H �!
biddable_conversions (H�\'
biddable_conversions_value (H�
clicks (H�
cost_micros (H�
impressions (H�!
top_slot_impressions (H�B
_percent_cpc_bid_microsB
_biddable_conversionsB
_biddable_conversions_valueB	
_clicksB
_cost_microsB
_impressionsB
_top_slot_impressionsB�
"com.google.ads.googleads.v6.commonBSimulationProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v6/common;common�GAA�Google.Ads.GoogleAds.V6.Common�Google\\Ads\\GoogleAds\\V6\\Common�"Google::Ads::GoogleAds::V6::Commonbproto3
�
Bgoogle/ads/googleads/v6/enums/simulation_modification_method.protogoogle.ads.googleads.v6.enums"z
 SimulationModificationMethodEnum"V
SimulationModificationMethod
UNSPECIFIED 
UNKNOWN
UNIFORM
DEFAULTB�
!com.google.ads.googleads.v6.enumsB!SimulationModificationMethodProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
3google/ads/googleads/v6/enums/simulation_type.protogoogle.ads.googleads.v6.enums"�
SimulationTypeEnum"�
SimulationType
UNSPECIFIED 
UNKNOWN
CPC_BID
CPV_BID

TARGET_CPA
BID_MODIFIER
TARGET_ROAS
PERCENT_CPC_BIDB�
!com.google.ads.googleads.v6.enumsBSimulationTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
Egoogle/ads/googleads/v6/resources/campaign_criterion_simulation.proto!google.ads.googleads.v6.resourcesBgoogle/ads/googleads/v6/enums/simulation_modification_method.proto3google/ads/googleads/v6/enums/simulation_type.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/api/annotations.proto"�
CampaignCriterionSimulationS
resource_name (	B<�A�A6
4googleads.googleapis.com/CampaignCriterionSimulation
campaign_id	 (B�AH�
criterion_id
 (B�AH�S
type (2@.google.ads.googleads.v6.enums.SimulationTypeEnum.SimulationTypeB�A~
modification_method (2\\.google.ads.googleads.v6.enums.SimulationModificationMethodEnum.SimulationModificationMethodB�A

start_date (	B�AH�
end_date (	B�AH�f
bid_modifier_point_list (2>.google.ads.googleads.v6.common.BidModifierSimulationPointListB�AH :��A�
4googleads.googleapis.com/CampaignCriterionSimulation�customers/{customer_id}/campaignCriterionSimulations/{campaign_id}~{criterion_id}~{type}~{modification_method}~{start_date}~{end_date}B

point_listB
_campaign_idB
_criterion_idB
_start_dateB
	_end_dateB�
%com.google.ads.googleads.v6.resourcesB CampaignCriterionSimulationProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v6/resources;resources�GAA�!Google.Ads.GoogleAds.V6.Resources�!Google\\Ads\\GoogleAds\\V6\\Resources�%Google::Ads::GoogleAds::V6::Resourcesbproto3
�
Lgoogle/ads/googleads/v6/services/campaign_criterion_simulation_service.proto google.ads.googleads.v6.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto"|
%GetCampaignCriterionSimulationRequestS
resource_name (	B<�A�A6
4googleads.googleapis.com/CampaignCriterionSimulation2�
"CampaignCriterionSimulationService�
GetCampaignCriterionSimulationG.google.ads.googleads.v6.services.GetCampaignCriterionSimulationRequest>.google.ads.googleads.v6.resources.CampaignCriterionSimulation"V���@>/v6/{resource_name=customers/*/campaignCriterionSimulations/*}�Aresource_nameE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v6.servicesB\'CampaignCriterionSimulationServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v6/services;services�GAA� Google.Ads.GoogleAds.V6.Services� Google\\Ads\\GoogleAds\\V6\\Services�$Google::Ads::GoogleAds::V6::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

