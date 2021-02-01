<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v3/resources/campaign_budget.proto

namespace GPBMetadata\Google\Ads\Googleads\V3\Resources;

class CampaignBudget
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
        $pool->internalAddGeneratedFile(
            '
�
:google/ads/googleads/v3/enums/budget_delivery_method.protogoogle.ads.googleads.v3.enums"o
BudgetDeliveryMethodEnum"S
BudgetDeliveryMethod
UNSPECIFIED 
UNKNOWN
STANDARD
ACCELERATEDB�
!com.google.ads.googleads.v3.enumsBBudgetDeliveryMethodProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
1google/ads/googleads/v3/enums/budget_period.protogoogle.ads.googleads.v3.enums"K
BudgetPeriodEnum"7
BudgetPeriod
UNSPECIFIED 
UNKNOWN	
DAILYB�
!com.google.ads.googleads.v3.enumsBBudgetPeriodProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
1google/ads/googleads/v3/enums/budget_status.protogoogle.ads.googleads.v3.enums"Z
BudgetStatusEnum"F
BudgetStatus
UNSPECIFIED 
UNKNOWN
ENABLED
REMOVEDB�
!com.google.ads.googleads.v3.enumsBBudgetStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
/google/ads/googleads/v3/enums/budget_type.protogoogle.ads.googleads.v3.enums"s
BudgetTypeEnum"a

BudgetType
UNSPECIFIED 
UNKNOWN
STANDARD
HOTEL_ADS_COMMISSION
	FIXED_CPAB�
!com.google.ads.googleads.v3.enumsBBudgetTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
7google/ads/googleads/v3/resources/campaign_budget.proto!google.ads.googleads.v3.resources1google/ads/googleads/v3/enums/budget_period.proto1google/ads/googleads/v3/enums/budget_status.proto/google/ads/googleads/v3/enums/budget_type.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�

CampaignBudgetF
resource_name (	B/�A�A)
\'googleads.googleapis.com/CampaignBudget,
id (2.google.protobuf.Int64ValueB�A*
name (2.google.protobuf.StringValue2
amount_micros (2.google.protobuf.Int64Value8
total_amount_micros
 (2.google.protobuf.Int64ValueQ
status (2<.google.ads.googleads.v3.enums.BudgetStatusEnum.BudgetStatusB�Ae
delivery_method (2L.google.ads.googleads.v3.enums.BudgetDeliveryMethodEnum.BudgetDeliveryMethod5
explicitly_shared (2.google.protobuf.BoolValue9
reference_count	 (2.google.protobuf.Int64ValueB�A?
has_recommended_budget (2.google.protobuf.BoolValueB�AJ
 recommended_budget_amount_micros (2.google.protobuf.Int64ValueB�AQ
period (2<.google.ads.googleads.v3.enums.BudgetPeriodEnum.BudgetPeriodB�A[
1recommended_budget_estimated_change_weekly_clicks (2.google.protobuf.Int64ValueB�A`
6recommended_budget_estimated_change_weekly_cost_micros (2.google.protobuf.Int64ValueB�Aa
7recommended_budget_estimated_change_weekly_interactions (2.google.protobuf.Int64ValueB�AZ
0recommended_budget_estimated_change_weekly_views (2.google.protobuf.Int64ValueB�AK
type (28.google.ads.googleads.v3.enums.BudgetTypeEnum.BudgetTypeB�A:d�Aa
\'googleads.googleapis.com/CampaignBudget6customers/{customer}/campaignBudgets/{campaign_budget}B�
%com.google.ads.googleads.v3.resourcesBCampaignBudgetProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v3/resources;resources�GAA�!Google.Ads.GoogleAds.V3.Resources�!Google\\Ads\\GoogleAds\\V3\\Resources�%Google::Ads::GoogleAds::V3::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

