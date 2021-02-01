<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v6/services/campaign_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V6\Services;

class CampaignService
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();
        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Http::initOnce();
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Protobuf\Any::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        \GPBMetadata\Google\Rpc\Status::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
Dgoogle/ads/googleads/v6/enums/target_impression_share_location.protogoogle.ads.googleads.v6.enums"�
!TargetImpressionShareLocationEnum"~
TargetImpressionShareLocation
UNSPECIFIED 
UNKNOWN
ANYWHERE_ON_PAGE
TOP_OF_PAGE
ABSOLUTE_TOP_OF_PAGEB�
!com.google.ads.googleads.v6.enumsB"TargetImpressionShareLocationProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
,google/ads/googleads/v6/common/bidding.protogoogle.ads.googleads.v6.commongoogle/api/annotations.proto"L

Commission#
commission_rate_micros (H �B
_commission_rate_micros"
EnhancedCpc"G
	ManualCpc!
enhanced_cpc_enabled (H �B
_enhanced_cpc_enabled"
	ManualCpm"
	ManualCpv")
MaximizeConversions

target_cpa ("C
MaximizeConversionValue
target_roas (H �B
_target_roas"�
	TargetCpa
target_cpa_micros (H �#
cpc_bid_ceiling_micros (H�!
cpc_bid_floor_micros (H�B
_target_cpa_microsB
_cpc_bid_ceiling_microsB
_cpc_bid_floor_micros"
	TargetCpm"�
TargetImpressionSharep
location (2^.google.ads.googleads.v6.enums.TargetImpressionShareLocationEnum.TargetImpressionShareLocation%
location_fraction_micros (H �#
cpc_bid_ceiling_micros (H�B
_location_fraction_microsB
_cpc_bid_ceiling_micros"�

TargetRoas
target_roas (H �#
cpc_bid_ceiling_micros (H�!
cpc_bid_floor_micros (H�B
_target_roasB
_cpc_bid_ceiling_microsB
_cpc_bid_floor_micros"�
TargetSpend$
target_spend_micros (BH �#
cpc_bid_ceiling_micros (H�B
_target_spend_microsB
_cpc_bid_ceiling_micros"�

PercentCpc#
cpc_bid_ceiling_micros (H �!
enhanced_cpc_enabled (H�B
_cpc_bid_ceiling_microsB
_enhanced_cpc_enabledB�
"com.google.ads.googleads.v6.commonBBiddingProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v6/common;common�GAA�Google.Ads.GoogleAds.V6.Common�Google\\Ads\\GoogleAds\\V6\\Common�"Google::Ads::GoogleAds::V6::Commonbproto3
�
5google/ads/googleads/v6/common/custom_parameter.protogoogle.ads.googleads.v6.common"I
CustomParameter
key (	H �
value (	H�B
_keyB
_valueB�
"com.google.ads.googleads.v6.commonBCustomParameterProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v6/common;common�GAA�Google.Ads.GoogleAds.V6.Common�Google\\Ads\\GoogleAds\\V6\\Common�"Google::Ads::GoogleAds::V6::Commonbproto3
�
<google/ads/googleads/v6/enums/advertising_channel_type.protogoogle.ads.googleads.v6.enums"�
AdvertisingChannelTypeEnum"�
AdvertisingChannelType
UNSPECIFIED 
UNKNOWN

SEARCH
DISPLAY
SHOPPING	
HOTEL	
VIDEO
MULTI_CHANNEL	
LOCAL	
SMART	B�
!com.google.ads.googleads.v6.enumsBAdvertisingChannelTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
@google/ads/googleads/v6/enums/advertising_channel_sub_type.protogoogle.ads.googleads.v6.enums"�
AdvertisingChannelSubTypeEnum"�
AdvertisingChannelSubType
UNSPECIFIED 
UNKNOWN
SEARCH_MOBILE_APP
DISPLAY_MOBILE_APP
SEARCH_EXPRESS
DISPLAY_EXPRESS
SHOPPING_SMART_ADS
DISPLAY_GMAIL_AD
DISPLAY_SMART_CAMPAIGN
VIDEO_OUTSTREAM	
VIDEO_ACTION

VIDEO_NON_SKIPPABLE
APP_CAMPAIGN
APP_CAMPAIGN_FOR_ENGAGEMENT
LOCAL_CAMPAIGN#
SHOPPING_COMPARISON_LISTING_ADS
SMART_CAMPAIGN
VIDEO_SEQUENCEB�
!com.google.ads.googleads.v6.enumsBAdvertisingChannelSubTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
;google/ads/googleads/v6/enums/frequency_cap_time_unit.protogoogle.ads.googleads.v6.enums"n
FrequencyCapTimeUnitEnum"R
FrequencyCapTimeUnit
UNSPECIFIED 
UNKNOWN
DAY
WEEK	
MONTHB�
!com.google.ads.googleads.v6.enumsBFrequencyCapTimeUnitProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
<google/ads/googleads/v6/enums/frequency_cap_event_type.protogoogle.ads.googleads.v6.enums"r
FrequencyCapEventTypeEnum"U
FrequencyCapEventType
UNSPECIFIED 
UNKNOWN

IMPRESSION

VIDEO_VIEWB�
!com.google.ads.googleads.v6.enumsBFrequencyCapEventTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
7google/ads/googleads/v6/enums/frequency_cap_level.protogoogle.ads.googleads.v6.enums"w
FrequencyCapLevelEnum"^
FrequencyCapLevel
UNSPECIFIED 
UNKNOWN
AD_GROUP_AD
AD_GROUP
CAMPAIGNB�
!com.google.ads.googleads.v6.enumsBFrequencyCapLevelProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
2google/ads/googleads/v6/common/frequency_cap.protogoogle.ads.googleads.v6.common7google/ads/googleads/v6/enums/frequency_cap_level.proto;google/ads/googleads/v6/enums/frequency_cap_time_unit.protogoogle/api/annotations.proto"k
FrequencyCapEntry<
key (2/.google.ads.googleads.v6.common.FrequencyCapKey
cap (H �B
_cap"�
FrequencyCapKeyU
level (2F.google.ads.googleads.v6.enums.FrequencyCapLevelEnum.FrequencyCapLevelb

event_type (2N.google.ads.googleads.v6.enums.FrequencyCapEventTypeEnum.FrequencyCapEventType_
	time_unit (2L.google.ads.googleads.v6.enums.FrequencyCapTimeUnitEnum.FrequencyCapTimeUnit
time_length (H �B
_time_lengthB�
"com.google.ads.googleads.v6.commonBFrequencyCapProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v6/common;common�GAA�Google.Ads.GoogleAds.V6.Common�Google\\Ads\\GoogleAds\\V6\\Common�"Google::Ads::GoogleAds::V6::Commonbproto3
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
�
<google/ads/googleads/v6/enums/negative_geo_target_type.protogoogle.ads.googleads.v6.enums"z
NegativeGeoTargetTypeEnum"]
NegativeGeoTargetType
UNSPECIFIED 
UNKNOWN
PRESENCE_OR_INTEREST
PRESENCEB�
!com.google.ads.googleads.v6.enumsBNegativeGeoTargetTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
>google/ads/googleads/v6/common/real_time_bidding_setting.protogoogle.ads.googleads.v6.common"8
RealTimeBiddingSetting
opt_in (H �B	
_opt_inB�
"com.google.ads.googleads.v6.commonBRealTimeBiddingSettingProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v6/common;common�GAA�Google.Ads.GoogleAds.V6.Common�Google\\Ads\\GoogleAds\\V6\\Common�"Google::Ads::GoogleAds::V6::Commonbproto3
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
�
Bgoogle/ads/googleads/v6/enums/ad_serving_optimization_status.protogoogle.ads.googleads.v6.enums"�
AdServingOptimizationStatusEnum"�
AdServingOptimizationStatus
UNSPECIFIED 
UNKNOWN
OPTIMIZE
CONVERSION_OPTIMIZE

ROTATE
ROTATE_INDEFINITELY
UNAVAILABLEB�
!com.google.ads.googleads.v6.enumsB AdServingOptimizationStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
:google/ads/googleads/v6/enums/app_campaign_app_store.protogoogle.ads.googleads.v6.enums"y
AppCampaignAppStoreEnum"^
AppCampaignAppStore
UNSPECIFIED 
UNKNOWN
APPLE_APP_STORE
GOOGLE_APP_STOREB�
!com.google.ads.googleads.v6.enumsBAppCampaignAppStoreProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
Kgoogle/ads/googleads/v6/enums/app_campaign_bidding_strategy_goal_type.protogoogle.ads.googleads.v6.enums"�
&AppCampaignBiddingStrategyGoalTypeEnum"�
"AppCampaignBiddingStrategyGoalType
UNSPECIFIED 
UNKNOWN)
%OPTIMIZE_INSTALLS_TARGET_INSTALL_COST3
/OPTIMIZE_IN_APP_CONVERSIONS_TARGET_INSTALL_COST6
2OPTIMIZE_IN_APP_CONVERSIONS_TARGET_CONVERSION_COST(
$OPTIMIZE_RETURN_ON_ADVERTISING_SPENDB�
!com.google.ads.googleads.v6.enumsB\'AppCampaignBiddingStrategyGoalTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
9google/ads/googleads/v6/enums/bidding_strategy_type.protogoogle.ads.googleads.v6.enums"�
BiddingStrategyTypeEnum"�
BiddingStrategyType
UNSPECIFIED 
UNKNOWN

COMMISSION
ENHANCED_CPC

MANUAL_CPC

MANUAL_CPM

MANUAL_CPV
MAXIMIZE_CONVERSIONS

MAXIMIZE_CONVERSION_VALUE
PAGE_ONE_PROMOTED
PERCENT_CPC

TARGET_CPA

TARGET_CPM
TARGET_IMPRESSION_SHARE
TARGET_OUTRANK_SHARE
TARGET_ROAS
TARGET_SPEND	B�
!com.google.ads.googleads.v6.enumsBBiddingStrategyTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
<google/ads/googleads/v6/enums/brand_safety_suitability.protogoogle.ads.googleads.v6.enums"�
BrandSafetySuitabilityEnum"}
BrandSafetySuitability
UNSPECIFIED 
UNKNOWN
EXPANDED_INVENTORY
STANDARD_INVENTORY
LIMITED_INVENTORYB�
!com.google.ads.googleads.v6.enumsBBrandSafetySuitabilityProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
<google/ads/googleads/v6/enums/campaign_experiment_type.protogoogle.ads.googleads.v6.enums"y
CampaignExperimentTypeEnum"[
CampaignExperimentType
UNSPECIFIED 
UNKNOWN
BASE	
DRAFT

EXPERIMENTB�
!com.google.ads.googleads.v6.enumsBCampaignExperimentTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
;google/ads/googleads/v6/enums/campaign_serving_status.protogoogle.ads.googleads.v6.enums"�
CampaignServingStatusEnum"s
CampaignServingStatus
UNSPECIFIED 
UNKNOWN
SERVING
NONE	
ENDED
PENDING
	SUSPENDEDB�
!com.google.ads.googleads.v6.enumsBCampaignServingStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
3google/ads/googleads/v6/enums/campaign_status.protogoogle.ads.googleads.v6.enums"j
CampaignStatusEnum"T
CampaignStatus
UNSPECIFIED 
UNKNOWN
ENABLED

PAUSED
REMOVEDB�
!com.google.ads.googleads.v6.enumsBCampaignStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
8google/ads/googleads/v6/enums/location_source_type.protogoogle.ads.googleads.v6.enums"s
LocationSourceTypeEnum"Y
LocationSourceType
UNSPECIFIED 
UNKNOWN
GOOGLE_MY_BUSINESS
	AFFILIATEB�
!com.google.ads.googleads.v6.enumsBLocationSourceTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
:google/ads/googleads/v6/enums/optimization_goal_type.protogoogle.ads.googleads.v6.enums"y
OptimizationGoalTypeEnum"]
OptimizationGoalType
UNSPECIFIED 
UNKNOWN
CALL_CLICKS
DRIVING_DIRECTIONSB�
!com.google.ads.googleads.v6.enumsBOptimizationGoalTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
0google/ads/googleads/v6/enums/payment_mode.protogoogle.ads.googleads.v6.enums"�
PaymentModeEnum"n
PaymentMode
UNSPECIFIED 
UNKNOWN

CLICKS
CONVERSION_VALUE
CONVERSIONS

GUEST_STAYB�
!com.google.ads.googleads.v6.enumsBPaymentModeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
<google/ads/googleads/v6/enums/positive_geo_target_type.protogoogle.ads.googleads.v6.enums"�
PositiveGeoTargetTypeEnum"r
PositiveGeoTargetType
UNSPECIFIED 
UNKNOWN
PRESENCE_OR_INTEREST
SEARCH_INTEREST
PRESENCEB�
!com.google.ads.googleads.v6.enumsBPositiveGeoTargetTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
9google/ads/googleads/v6/enums/response_content_type.protogoogle.ads.googleads.v6.enums"o
ResponseContentTypeEnum"T
ResponseContentType
UNSPECIFIED 
RESOURCE_NAME_ONLY
MUTABLE_RESOURCEB�
!com.google.ads.googleads.v6.enumsBResponseContentTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
Bgoogle/ads/googleads/v6/enums/vanity_pharma_display_url_mode.protogoogle.ads.googleads.v6.enums"�
VanityPharmaDisplayUrlModeEnum"q
VanityPharmaDisplayUrlMode
UNSPECIFIED 
UNKNOWN
MANUFACTURER_WEBSITE_URL
WEBSITE_DESCRIPTIONB�
!com.google.ads.googleads.v6.enumsBVanityPharmaDisplayUrlModeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
6google/ads/googleads/v6/enums/vanity_pharma_text.protogoogle.ads.googleads.v6.enums"�
VanityPharmaTextEnum"�
VanityPharmaText
UNSPECIFIED 
UNKNOWN%
!PRESCRIPTION_TREATMENT_WEBSITE_EN%
!PRESCRIPTION_TREATMENT_WEBSITE_ES"
PRESCRIPTION_DEVICE_WEBSITE_EN"
PRESCRIPTION_DEVICE_WEBSITE_ES
MEDICAL_DEVICE_WEBSITE_EN
MEDICAL_DEVICE_WEBSITE_ES%
!PREVENTATIVE_TREATMENT_WEBSITE_EN%
!PREVENTATIVE_TREATMENT_WEBSITE_ES	)
%PRESCRIPTION_CONTRACEPTION_WEBSITE_EN
)
%PRESCRIPTION_CONTRACEPTION_WEBSITE_ES#
PRESCRIPTION_VACCINE_WEBSITE_EN#
PRESCRIPTION_VACCINE_WEBSITE_ESB�
!com.google.ads.googleads.v6.enumsBVanityPharmaTextProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�<
0google/ads/googleads/v6/resources/campaign.proto!google.ads.googleads.v6.resources5google/ads/googleads/v6/common/custom_parameter.proto2google/ads/googleads/v6/common/frequency_cap.proto>google/ads/googleads/v6/common/real_time_bidding_setting.proto6google/ads/googleads/v6/common/targeting_setting.protoBgoogle/ads/googleads/v6/enums/ad_serving_optimization_status.proto@google/ads/googleads/v6/enums/advertising_channel_sub_type.proto<google/ads/googleads/v6/enums/advertising_channel_type.proto:google/ads/googleads/v6/enums/app_campaign_app_store.protoKgoogle/ads/googleads/v6/enums/app_campaign_bidding_strategy_goal_type.proto9google/ads/googleads/v6/enums/bidding_strategy_type.proto<google/ads/googleads/v6/enums/brand_safety_suitability.proto<google/ads/googleads/v6/enums/campaign_experiment_type.proto;google/ads/googleads/v6/enums/campaign_serving_status.proto3google/ads/googleads/v6/enums/campaign_status.proto8google/ads/googleads/v6/enums/location_source_type.proto<google/ads/googleads/v6/enums/negative_geo_target_type.proto:google/ads/googleads/v6/enums/optimization_goal_type.proto0google/ads/googleads/v6/enums/payment_mode.proto<google/ads/googleads/v6/enums/positive_geo_target_type.protoBgoogle/ads/googleads/v6/enums/vanity_pharma_display_url_mode.proto6google/ads/googleads/v6/enums/vanity_pharma_text.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/api/annotations.proto"�/
Campaign@
resource_name (	B)�A�A#
!googleads.googleapis.com/Campaign
id; (B�AH�
name: (	H�P
status (2@.google.ads.googleads.v6.enums.CampaignStatusEnum.CampaignStatusk
serving_status (2N.google.ads.googleads.v6.enums.CampaignServingStatusEnum.CampaignServingStatusB�A�
ad_serving_optimization_status (2Z.google.ads.googleads.v6.enums.AdServingOptimizationStatusEnum.AdServingOptimizationStatusw
advertising_channel_type	 (2P.google.ads.googleads.v6.enums.AdvertisingChannelTypeEnum.AdvertisingChannelTypeB�A�
advertising_channel_sub_type
 (2V.google.ads.googleads.v6.enums.AdvertisingChannelSubTypeEnum.AdvertisingChannelSubTypeB�A"
tracking_url_template< (	H�N
url_custom_parameters (2/.google.ads.googleads.v6.common.CustomParameterY
real_time_bidding_setting\' (26.google.ads.googleads.v6.common.RealTimeBiddingSettingU
network_settings (2;.google.ads.googleads.v6.resources.Campaign.NetworkSettingsX
hotel_setting  (2<.google.ads.googleads.v6.resources.Campaign.HotelSettingInfoB�Ag
dynamic_search_ads_setting! (2C.google.ads.googleads.v6.resources.Campaign.DynamicSearchAdsSettingU
shopping_setting$ (2;.google.ads.googleads.v6.resources.Campaign.ShoppingSettingK
targeting_setting+ (20.google.ads.googleads.v6.common.TargetingSettinga
geo_target_type_setting/ (2@.google.ads.googleads.v6.resources.Campaign.GeoTargetTypeSetting`
local_campaign_setting2 (2@.google.ads.googleads.v6.resources.Campaign.LocalCampaignSetting\\
app_campaign_setting3 (2>.google.ads.googleads.v6.resources.Campaign.AppCampaignSetting>
labels= (	B.�A�A(
&googleads.googleapis.com/CampaignLabeln
experiment_type (2P.google.ads.googleads.v6.enums.CampaignExperimentTypeEnum.CampaignExperimentTypeB�AE
base_campaign8 (	B)�A�A#
!googleads.googleapis.com/CampaignH�J
campaign_budget> (	B,�A)
\'googleads.googleapis.com/CampaignBudgetH�n
bidding_strategy_type (2J.google.ads.googleads.v6.enums.BiddingStrategyTypeEnum.BiddingStrategyTypeB�A

start_date? (	H�
end_date@ (	H�
final_url_suffixA (	H�I
frequency_caps( (21.google.ads.googleads.v6.common.FrequencyCapEntry}
video_brand_safety_suitability* (2P.google.ads.googleads.v6.enums.BrandSafetySuitabilityEnum.BrandSafetySuitabilityB�AO
vanity_pharma, (28.google.ads.googleads.v6.resources.Campaign.VanityPharmaa
selective_optimization- (2A.google.ads.googleads.v6.resources.Campaign.SelectiveOptimizationf
optimization_goal_setting6 (2C.google.ads.googleads.v6.resources.Campaign.OptimizationGoalSettingZ
tracking_setting. (2;.google.ads.googleads.v6.resources.Campaign.TrackingSettingB�AP
payment_mode4 (2:.google.ads.googleads.v6.enums.PaymentModeEnum.PaymentMode$
optimization_scoreB (B�AH	�I
bidding_strategyC (	B-�A*
(googleads.googleapis.com/BiddingStrategyH @

commission1 (2*.google.ads.googleads.v6.common.CommissionH ?

manual_cpc (2).google.ads.googleads.v6.common.ManualCpcH ?

manual_cpm (2).google.ads.googleads.v6.common.ManualCpmH D

manual_cpv% (2).google.ads.googleads.v6.common.ManualCpvB�AH S
maximize_conversions (23.google.ads.googleads.v6.common.MaximizeConversionsH \\
maximize_conversion_value (27.google.ads.googleads.v6.common.MaximizeConversionValueH ?

target_cpa (2).google.ads.googleads.v6.common.TargetCpaH X
target_impression_share0 (25.google.ads.googleads.v6.common.TargetImpressionShareH A
target_roas (2*.google.ads.googleads.v6.common.TargetRoasH C
target_spend (2+.google.ads.googleads.v6.common.TargetSpendH A
percent_cpc" (2*.google.ads.googleads.v6.common.PercentCpcH ?

target_cpm) (2).google.ads.googleads.v6.common.TargetCpmH �
NetworkSettings!
target_google_search (H �"
target_search_network (H�#
target_content_network (H�*
target_partner_search_network (H�B
_target_google_searchB
_target_search_networkB
_target_content_networkB 
_target_partner_search_networkI
HotelSettingInfo!
hotel_center_id (B�AH �B
_hotel_center_id~
LocalCampaignSettingf
location_source_type (2H.google.ads.googleads.v6.enums.LocationSourceTypeEnum.LocationSourceType�
DynamicSearchAdsSetting
domain_name (	B�A
language_code (	B�A#
use_supplied_urls_only (H �1
feeds	 (	B"�A
googleads.googleapis.com/FeedB
_use_supplied_urls_only�
OptimizationGoalSettingm
optimization_goal_types (2L.google.ads.googleads.v6.enums.OptimizationGoalTypeEnum.OptimizationGoalType�
ShoppingSetting
merchant_id (B�AH �
sales_country (	B�AH�
campaign_priority (H�
enable_local (H�B
_merchant_idB
_sales_countryB
_campaign_priorityB
_enable_localB
TrackingSetting
tracking_url (	B�AH �B
_tracking_urlc
SelectiveOptimizationJ
conversion_actions (	B.�A+
)googleads.googleapis.com/ConversionAction�
GeoTargetTypeSettingp
positive_geo_target_type (2N.google.ads.googleads.v6.enums.PositiveGeoTargetTypeEnum.PositiveGeoTargetTypep
negative_geo_target_type (2N.google.ads.googleads.v6.enums.NegativeGeoTargetTypeEnum.NegativeGeoTargetType�
AppCampaignSetting�
bidding_strategy_goal_type (2h.google.ads.googleads.v6.enums.AppCampaignBiddingStrategyGoalTypeEnum.AppCampaignBiddingStrategyGoalType
app_id (	B�AH �b
	app_store (2J.google.ads.googleads.v6.enums.AppCampaignAppStoreEnum.AppCampaignAppStoreB�AB	
_app_id�
VanityPharma�
vanity_pharma_display_url_mode (2X.google.ads.googleads.v6.enums.VanityPharmaDisplayUrlModeEnum.VanityPharmaDisplayUrlMode`
vanity_pharma_text (2D.google.ads.googleads.v6.enums.VanityPharmaTextEnum.VanityPharmaText:W�AT
!googleads.googleapis.com/Campaign/customers/{customer_id}/campaigns/{campaign_id}B
campaign_bidding_strategyB
_idB
_nameB
_tracking_url_templateB
_base_campaignB
_campaign_budgetB
_start_dateB
	_end_dateB
_final_url_suffixB
_optimization_scoreB�
%com.google.ads.googleads.v6.resourcesBCampaignProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v6/resources;resources�GAA�!Google.Ads.GoogleAds.V6.Resources�!Google\\Ads\\GoogleAds\\V6\\Resources�%Google::Ads::GoogleAds::V6::Resourcesbproto3
�
7google/ads/googleads/v6/services/campaign_service.proto google.ads.googleads.v6.services0google/ads/googleads/v6/resources/campaign.protogoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto google/protobuf/field_mask.protogoogle/rpc/status.proto"V
GetCampaignRequest@
resource_name (	B)�A�A#
!googleads.googleapis.com/Campaign"�
MutateCampaignsRequest
customer_id (	B�AL

operations (23.google.ads.googleads.v6.services.CampaignOperationB�A
partial_failure (
validate_only (i
response_content_type (2J.google.ads.googleads.v6.enums.ResponseContentTypeEnum.ResponseContentType"�
CampaignOperation/
update_mask (2.google.protobuf.FieldMask=
create (2+.google.ads.googleads.v6.resources.CampaignH =
update (2+.google.ads.googleads.v6.resources.CampaignH 
remove (	H B
	operation"�
MutateCampaignsResponse1
partial_failure_error (2.google.rpc.StatusG
results (26.google.ads.googleads.v6.services.MutateCampaignResult"l
MutateCampaignResult
resource_name (	=
campaign (2+.google.ads.googleads.v6.resources.Campaign2�
CampaignService�
GetCampaign4.google.ads.googleads.v6.services.GetCampaignRequest+.google.ads.googleads.v6.resources.Campaign"C���-+/v6/{resource_name=customers/*/campaigns/*}�Aresource_name�
MutateCampaigns8.google.ads.googleads.v6.services.MutateCampaignsRequest9.google.ads.googleads.v6.services.MutateCampaignsResponse"R���3"./v6/customers/{customer_id=*}/campaigns:mutate:*�Acustomer_id,operationsE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v6.servicesBCampaignServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v6/services;services�GAA� Google.Ads.GoogleAds.V6.Services� Google\\Ads\\GoogleAds\\V6\\Services�$Google::Ads::GoogleAds::V6::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

