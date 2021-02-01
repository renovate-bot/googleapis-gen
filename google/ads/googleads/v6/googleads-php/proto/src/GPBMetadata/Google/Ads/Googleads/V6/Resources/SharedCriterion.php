<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v6/resources/shared_criterion.proto

namespace GPBMetadata\Google\Ads\Googleads\V6\Resources;

class SharedCriterion
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
        $pool->internalAddGeneratedFile(
            '
�
Bgoogle/ads/googleads/v6/enums/product_bidding_category_level.protogoogle.ads.googleads.v6.enums"�
ProductBiddingCategoryLevelEnum"w
ProductBiddingCategoryLevel
UNSPECIFIED 
UNKNOWN

LEVEL1

LEVEL2

LEVEL3

LEVEL4

LEVEL5B�
!com.google.ads.googleads.v6.enumsB ProductBiddingCategoryLevelProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
2google/ads/googleads/v6/enums/age_range_type.protogoogle.ads.googleads.v6.enums"�
AgeRangeTypeEnum"�
AgeRangeType
UNSPECIFIED 
UNKNOWN
AGE_RANGE_18_24��
AGE_RANGE_25_34��
AGE_RANGE_35_44��
AGE_RANGE_45_54��
AGE_RANGE_55_64��
AGE_RANGE_65_UP��
AGE_RANGE_UNDETERMINED��B�
!com.google.ads.googleads.v6.enumsBAgeRangeTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
:google/ads/googleads/v6/enums/app_payment_model_type.protogoogle.ads.googleads.v6.enums"X
AppPaymentModelTypeEnum"=
AppPaymentModelType
UNSPECIFIED 
UNKNOWN
PAIDB�
!com.google.ads.googleads.v6.enumsBAppPaymentModelTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
6google/ads/googleads/v6/enums/content_label_type.protogoogle.ads.googleads.v6.enums"�
ContentLabelTypeEnum"�
ContentLabelType
UNSPECIFIED 
UNKNOWN
SEXUALLY_SUGGESTIVE
BELOW_THE_FOLD
PARKED_DOMAIN
JUVENILE
	PROFANITY
TRAGEDY	
VIDEO	
VIDEO_RATING_DV_G

VIDEO_RATING_DV_PG
VIDEO_RATING_DV_T
VIDEO_RATING_DV_MA
VIDEO_NOT_YET_RATED
EMBEDDED_VIDEO
LIVE_STREAMING_VIDEO
SOCIAL_ISSUESB�
!com.google.ads.googleads.v6.enumsBContentLabelTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
/google/ads/googleads/v6/enums/day_of_week.protogoogle.ads.googleads.v6.enums"�
DayOfWeekEnum"�
	DayOfWeek
UNSPECIFIED 
UNKNOWN

MONDAY
TUESDAY
	WEDNESDAY
THURSDAY

FRIDAY
SATURDAY

SUNDAYB�
!com.google.ads.googleads.v6.enumsBDayOfWeekProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
*google/ads/googleads/v6/enums/device.protogoogle.ads.googleads.v6.enums"v

DeviceEnum"h
Device
UNSPECIFIED 
UNKNOWN

MOBILE

TABLET
DESKTOP
CONNECTED_TV	
OTHERB�
!com.google.ads.googleads.v6.enumsBDeviceProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
/google/ads/googleads/v6/enums/gender_type.protogoogle.ads.googleads.v6.enums"d
GenderTypeEnum"R

GenderType
UNSPECIFIED 
UNKNOWN
MALE


FEMALE
UNDETERMINEDB�
!com.google.ads.googleads.v6.enumsBGenderTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
=google/ads/googleads/v6/enums/hotel_date_selection_type.protogoogle.ads.googleads.v6.enums"~
HotelDateSelectionTypeEnum"`
HotelDateSelectionType
UNSPECIFIED 
UNKNOWN
DEFAULT_SELECTION2
USER_SELECTED3B�
!com.google.ads.googleads.v6.enumsBHotelDateSelectionTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
5google/ads/googleads/v6/enums/income_range_type.protogoogle.ads.googleads.v6.enums"�
IncomeRangeTypeEnum"�
IncomeRangeType
UNSPECIFIED 
UNKNOWN
INCOME_RANGE_0_50��
INCOME_RANGE_50_60��
INCOME_RANGE_60_70��
INCOME_RANGE_70_80��
INCOME_RANGE_80_90��
INCOME_RANGE_90_UP��
INCOME_RANGE_UNDETERMINED��B�
!com.google.ads.googleads.v6.enumsBIncomeRangeTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
4google/ads/googleads/v6/enums/interaction_type.protogoogle.ads.googleads.v6.enums"R
InteractionTypeEnum";
InteractionType
UNSPECIFIED 
UNKNOWN

CALLS�>B�
!com.google.ads.googleads.v6.enumsBInteractionTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
6google/ads/googleads/v6/enums/keyword_match_type.protogoogle.ads.googleads.v6.enums"j
KeywordMatchTypeEnum"R
KeywordMatchType
UNSPECIFIED 
UNKNOWN	
EXACT

PHRASE	
BROADB�
!com.google.ads.googleads.v6.enumsBKeywordMatchTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
6google/ads/googleads/v6/enums/listing_group_type.protogoogle.ads.googleads.v6.enums"c
ListingGroupTypeEnum"K
ListingGroupType
UNSPECIFIED 
UNKNOWN
SUBDIVISION
UNITB�
!com.google.ads.googleads.v6.enumsBListingGroupTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
?google/ads/googleads/v6/enums/location_group_radius_units.protogoogle.ads.googleads.v6.enums"�
LocationGroupRadiusUnitsEnum"`
LocationGroupRadiusUnits
UNSPECIFIED 
UNKNOWN

METERS	
MILES
MILLI_MILESB�
!com.google.ads.googleads.v6.enumsBLocationGroupRadiusUnitsProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
2google/ads/googleads/v6/enums/minute_of_hour.protogoogle.ads.googleads.v6.enums"s
MinuteOfHourEnum"_
MinuteOfHour
UNSPECIFIED 
UNKNOWN
ZERO
FIFTEEN

THIRTY

FORTY_FIVEB�
!com.google.ads.googleads.v6.enumsBMinuteOfHourProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
8google/ads/googleads/v6/enums/parental_status_type.protogoogle.ads.googleads.v6.enums"
ParentalStatusTypeEnum"e
ParentalStatusType
UNSPECIFIED 
UNKNOWN
PARENT�
NOT_A_PARENT�
UNDETERMINED�B�
!com.google.ads.googleads.v6.enumsBParentalStatusTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
:google/ads/googleads/v6/enums/preferred_content_type.protogoogle.ads.googleads.v6.enums"j
PreferredContentTypeEnum"N
PreferredContentType
UNSPECIFIED 
UNKNOWN
YOUTUBE_TOP_CONTENT�B�
!com.google.ads.googleads.v6.enumsBPreferredContentTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
3google/ads/googleads/v6/enums/product_channel.protogoogle.ads.googleads.v6.enums"[
ProductChannelEnum"E
ProductChannel
UNSPECIFIED 
UNKNOWN

ONLINE	
LOCALB�
!com.google.ads.googleads.v6.enumsBProductChannelProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
?google/ads/googleads/v6/enums/product_channel_exclusivity.protogoogle.ads.googleads.v6.enums"�
ProductChannelExclusivityEnum"`
ProductChannelExclusivity
UNSPECIFIED 
UNKNOWN
SINGLE_CHANNEL
MULTI_CHANNELB�
!com.google.ads.googleads.v6.enumsBProductChannelExclusivityProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
5google/ads/googleads/v6/enums/product_condition.protogoogle.ads.googleads.v6.enums"l
ProductConditionEnum"T
ProductCondition
UNSPECIFIED 
UNKNOWN
NEW
REFURBISHED
USEDB�
!com.google.ads.googleads.v6.enumsBProductConditionProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
Bgoogle/ads/googleads/v6/enums/product_custom_attribute_index.protogoogle.ads.googleads.v6.enums"�
ProductCustomAttributeIndexEnum"w
ProductCustomAttributeIndex
UNSPECIFIED 
UNKNOWN

INDEX0

INDEX1

INDEX2	

INDEX3


INDEX4B�
!com.google.ads.googleads.v6.enumsB ProductCustomAttributeIndexProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
6google/ads/googleads/v6/enums/product_type_level.protogoogle.ads.googleads.v6.enums"�
ProductTypeLevelEnum"l
ProductTypeLevel
UNSPECIFIED 
UNKNOWN

LEVEL1

LEVEL2

LEVEL3	

LEVEL4


LEVEL5B�
!com.google.ads.googleads.v6.enumsBProductTypeLevelProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
:google/ads/googleads/v6/enums/proximity_radius_units.protogoogle.ads.googleads.v6.enums"k
ProximityRadiusUnitsEnum"O
ProximityRadiusUnits
UNSPECIFIED 
UNKNOWN	
MILES

KILOMETERSB�
!com.google.ads.googleads.v6.enumsBProximityRadiusUnitsProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
=google/ads/googleads/v6/enums/webpage_condition_operand.protogoogle.ads.googleads.v6.enums"�
WebpageConditionOperandEnum"�
WebpageConditionOperand
UNSPECIFIED 
UNKNOWN
URL
CATEGORY

PAGE_TITLE
PAGE_CONTENT
CUSTOM_LABELB�
!com.google.ads.googleads.v6.enumsBWebpageConditionOperandProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
>google/ads/googleads/v6/enums/webpage_condition_operator.protogoogle.ads.googleads.v6.enums"r
WebpageConditionOperatorEnum"R
WebpageConditionOperator
UNSPECIFIED 
UNKNOWN

EQUALS
CONTAINSB�
!com.google.ads.googleads.v6.enumsBWebpageConditionOperatorProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�F
-google/ads/googleads/v6/common/criteria.protogoogle.ads.googleads.v6.common:google/ads/googleads/v6/enums/app_payment_model_type.proto6google/ads/googleads/v6/enums/content_label_type.proto/google/ads/googleads/v6/enums/day_of_week.proto*google/ads/googleads/v6/enums/device.proto/google/ads/googleads/v6/enums/gender_type.proto=google/ads/googleads/v6/enums/hotel_date_selection_type.proto5google/ads/googleads/v6/enums/income_range_type.proto4google/ads/googleads/v6/enums/interaction_type.proto6google/ads/googleads/v6/enums/keyword_match_type.proto6google/ads/googleads/v6/enums/listing_group_type.proto?google/ads/googleads/v6/enums/location_group_radius_units.proto2google/ads/googleads/v6/enums/minute_of_hour.proto8google/ads/googleads/v6/enums/parental_status_type.proto:google/ads/googleads/v6/enums/preferred_content_type.protoBgoogle/ads/googleads/v6/enums/product_bidding_category_level.proto3google/ads/googleads/v6/enums/product_channel.proto?google/ads/googleads/v6/enums/product_channel_exclusivity.proto5google/ads/googleads/v6/enums/product_condition.protoBgoogle/ads/googleads/v6/enums/product_custom_attribute_index.proto6google/ads/googleads/v6/enums/product_type_level.proto:google/ads/googleads/v6/enums/proximity_radius_units.proto=google/ads/googleads/v6/enums/webpage_condition_operand.proto>google/ads/googleads/v6/enums/webpage_condition_operator.protogoogle/api/annotations.proto"�
KeywordInfo
text (	H �X

match_type (2D.google.ads.googleads.v6.enums.KeywordMatchTypeEnum.KeywordMatchTypeB
_text")
PlacementInfo
url (	H �B
_url"c
MobileAppCategoryInfo)
mobile_app_category_constant (	H �B
_mobile_app_category_constant"S
MobileApplicationInfo
app_id (	H �
name (	H�B	
_app_idB
_name"H
LocationInfo 
geo_target_constant (	H �B
_geo_target_constant"L

DeviceInfo>
type (20.google.ads.googleads.v6.enums.DeviceEnum.Device"r
PreferredContentInfoZ
type (2L.google.ads.googleads.v6.enums.PreferredContentTypeEnum.PreferredContentType"�
ListingGroupInfoR
type (2D.google.ads.googleads.v6.enums.ListingGroupTypeEnum.ListingGroupTypeH

case_value (24.google.ads.googleads.v6.common.ListingDimensionInfo&
parent_ad_group_criterion (	H �B
_parent_ad_group_criterion"\\
ListingScopeInfoH

dimensions (24.google.ads.googleads.v6.common.ListingDimensionInfo"�	
ListingDimensionInfo?
hotel_id (2+.google.ads.googleads.v6.common.HotelIdInfoH E
hotel_class (2..google.ads.googleads.v6.common.HotelClassInfoH V
hotel_country_region (26.google.ads.googleads.v6.common.HotelCountryRegionInfoH E
hotel_state (2..google.ads.googleads.v6.common.HotelStateInfoH C

hotel_city (2-.google.ads.googleads.v6.common.HotelCityInfoH ^
product_bidding_category (2:.google.ads.googleads.v6.common.ProductBiddingCategoryInfoH I
product_brand (20.google.ads.googleads.v6.common.ProductBrandInfoH M
product_channel (22.google.ads.googleads.v6.common.ProductChannelInfoH d
product_channel_exclusivity	 (2=.google.ads.googleads.v6.common.ProductChannelExclusivityInfoH Q
product_condition
 (24.google.ads.googleads.v6.common.ProductConditionInfoH ^
product_custom_attribute (2:.google.ads.googleads.v6.common.ProductCustomAttributeInfoH L
product_item_id (21.google.ads.googleads.v6.common.ProductItemIdInfoH G
product_type (2/.google.ads.googleads.v6.common.ProductTypeInfoH `
unknown_listing_dimension (2;.google.ads.googleads.v6.common.UnknownListingDimensionInfoH B
	dimension"+
HotelIdInfo
value (	H �B
_value".
HotelClassInfo
value (H �B
_value"\\
HotelCountryRegionInfo%
country_region_criterion (	H �B
_country_region_criterion"B
HotelStateInfo
state_criterion (	H �B
_state_criterion"?
HotelCityInfo
city_criterion (	H �B
_city_criterion"�
ProductBiddingCategoryInfo
id (H �
country_code (	H�i
level (2Z.google.ads.googleads.v6.enums.ProductBiddingCategoryLevelEnum.ProductBiddingCategoryLevelB
_idB
_country_code"0
ProductBrandInfo
value (	H �B
_value"g
ProductChannelInfoQ
channel (2@.google.ads.googleads.v6.enums.ProductChannelEnum.ProductChannel"�
ProductChannelExclusivityInfos
channel_exclusivity (2V.google.ads.googleads.v6.enums.ProductChannelExclusivityEnum.ProductChannelExclusivity"o
ProductConditionInfoW
	condition (2D.google.ads.googleads.v6.enums.ProductConditionEnum.ProductCondition"�
ProductCustomAttributeInfo
value (	H �i
index (2Z.google.ads.googleads.v6.enums.ProductCustomAttributeIndexEnum.ProductCustomAttributeIndexB
_value"1
ProductItemIdInfo
value (	H �B
_value"�
ProductTypeInfo
value (	H �S
level (2D.google.ads.googleads.v6.enums.ProductTypeLevelEnum.ProductTypeLevelB
_value"
UnknownListingDimensionInfo"|
HotelDateSelectionTypeInfo^
type (2P.google.ads.googleads.v6.enums.HotelDateSelectionTypeEnum.HotelDateSelectionType"g
HotelAdvanceBookingWindowInfo
min_days (H �
max_days (H�B
	_min_daysB
	_max_days"g
HotelLengthOfStayInfo

min_nights (H �

max_nights (H�B
_min_nightsB
_max_nights"b
HotelCheckInDayInfoK
day_of_week (26.google.ads.googleads.v6.enums.DayOfWeekEnum.DayOfWeek"g
InteractionTypeInfoP
type (2B.google.ads.googleads.v6.enums.InteractionTypeEnum.InteractionType"�
AdScheduleInfoR
start_minute (2<.google.ads.googleads.v6.enums.MinuteOfHourEnum.MinuteOfHourP

end_minute (2<.google.ads.googleads.v6.enums.MinuteOfHourEnum.MinuteOfHour

start_hour (H �
end_hour (H�K
day_of_week (26.google.ads.googleads.v6.enums.DayOfWeekEnum.DayOfWeekB
_start_hourB
	_end_hour"Z
AgeRangeInfoJ
type (2<.google.ads.googleads.v6.enums.AgeRangeTypeEnum.AgeRangeType"T

GenderInfoF
type (28.google.ads.googleads.v6.enums.GenderTypeEnum.GenderType"c
IncomeRangeInfoP
type (2B.google.ads.googleads.v6.enums.IncomeRangeTypeEnum.IncomeRangeType"l
ParentalStatusInfoV
type (2H.google.ads.googleads.v6.enums.ParentalStatusTypeEnum.ParentalStatusType"6
YouTubeVideoInfo
video_id (	H �B
	_video_id"<
YouTubeChannelInfo

channel_id (	H �B
_channel_id"4
UserListInfo
	user_list (	H �B

_user_list"�
ProximityInfo?
	geo_point (2,.google.ads.googleads.v6.common.GeoPointInfo
radius (H �b
radius_units (2L.google.ads.googleads.v6.enums.ProximityRadiusUnitsEnum.ProximityRadiusUnits<
address (2+.google.ads.googleads.v6.common.AddressInfoB	
_radius"�
GeoPointInfo\'
longitude_in_micro_degrees (H �&
latitude_in_micro_degrees (H�B
_longitude_in_micro_degreesB
_latitude_in_micro_degrees"�
AddressInfo
postal_code (	H �
province_code	 (	H�
country_code
 (	H�
province_name (	H�
street_address (	H�
street_address2 (	H�
	city_name (	H�B
_postal_codeB
_province_codeB
_country_codeB
_province_nameB
_street_addressB
_street_address2B

_city_name"I
	TopicInfo
topic_constant (	H �
path (	B
_topic_constant"D
LanguageInfo
language_constant (	H �B
_language_constant"5
IpBlockInfo

ip_address (	H �B
_ip_address"f
ContentLabelInfoR
type (2D.google.ads.googleads.v6.enums.ContentLabelTypeEnum.ContentLabelType"A
CarrierInfo
carrier_constant (	H �B
_carrier_constant"R
UserInterestInfo#
user_interest_category (	H �B
_user_interest_category"�
WebpageInfo
criterion_name (	H �H

conditions (24.google.ads.googleads.v6.common.WebpageConditionInfoB
_criterion_name"�
WebpageConditionInfoc
operand (2R.google.ads.googleads.v6.enums.WebpageConditionOperandEnum.WebpageConditionOperandf
operator (2T.google.ads.googleads.v6.enums.WebpageConditionOperatorEnum.WebpageConditionOperator
argument (	H �B
	_argument"r
OperatingSystemVersionInfo.
!operating_system_version_constant (	H �B$
"_operating_system_version_constant"o
AppPaymentModelInfoX
type (2J.google.ads.googleads.v6.enums.AppPaymentModelTypeEnum.AppPaymentModelType"R
MobileDeviceInfo#
mobile_device_constant (	H �B
_mobile_device_constant"F
CustomAffinityInfo
custom_affinity (	H �B
_custom_affinity"@
CustomIntentInfo
custom_intent (	H �B
_custom_intent"�
LocationGroupInfo
feed (	H �
geo_target_constants (	
radius (H�j
radius_units (2T.google.ads.googleads.v6.enums.LocationGroupRadiusUnitsEnum.LocationGroupRadiusUnits
feed_item_sets (	B
_feedB	
_radius"-
CustomAudienceInfo
custom_audience (	"1
CombinedAudienceInfo
combined_audience (	B�
"com.google.ads.googleads.v6.commonBCriteriaProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v6/common;common�GAA�Google.Ads.GoogleAds.V6.Common�Google\\Ads\\GoogleAds\\V6\\Common�"Google::Ads::GoogleAds::V6::Commonbproto3
�
2google/ads/googleads/v6/enums/criterion_type.protogoogle.ads.googleads.v6.enums"�
CriterionTypeEnum"�
CriterionType
UNSPECIFIED 
UNKNOWN
KEYWORD
	PLACEMENT
MOBILE_APP_CATEGORY
MOBILE_APPLICATION

DEVICE
LOCATION
LISTING_GROUP
AD_SCHEDULE	
	AGE_RANGE


GENDER
INCOME_RANGE
PARENTAL_STATUS
YOUTUBE_VIDEO
YOUTUBE_CHANNEL
	USER_LIST
	PROXIMITY	
TOPIC
LISTING_SCOPE
LANGUAGE
IP_BLOCK
CONTENT_LABEL
CARRIER
USER_INTEREST
WEBPAGE
OPERATING_SYSTEM_VERSION
APP_PAYMENT_MODEL
MOBILE_DEVICE
CUSTOM_AFFINITY
CUSTOM_INTENT
LOCATION_GROUP
CUSTOM_AUDIENCE B�
!com.google.ads.googleads.v6.enumsBCriterionTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
8google/ads/googleads/v6/resources/shared_criterion.proto!google.ads.googleads.v6.resources2google/ads/googleads/v6/enums/criterion_type.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/api/annotations.proto"�
SharedCriterionG
resource_name (	B0�A�A*
(googleads.googleapis.com/SharedCriterionC

shared_set
 (	B*�A�A$
"googleads.googleapis.com/SharedSetH�
criterion_id (B�AH�Q
type (2>.google.ads.googleads.v6.enums.CriterionTypeEnum.CriterionTypeB�AC
keyword (2+.google.ads.googleads.v6.common.KeywordInfoB�AH N
youtube_video (20.google.ads.googleads.v6.common.YouTubeVideoInfoB�AH R
youtube_channel (22.google.ads.googleads.v6.common.YouTubeChannelInfoB�AH G
	placement (2-.google.ads.googleads.v6.common.PlacementInfoB�AH Y
mobile_app_category (25.google.ads.googleads.v6.common.MobileAppCategoryInfoB�AH X
mobile_application	 (25.google.ads.googleads.v6.common.MobileApplicationInfoB�AH :t�Aq
(googleads.googleapis.com/SharedCriterionEcustomers/{customer_id}/sharedCriteria/{shared_set_id}~{criterion_id}B
	criterionB
_shared_setB
_criterion_idB�
%com.google.ads.googleads.v6.resourcesBSharedCriterionProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v6/resources;resources�GAA�!Google.Ads.GoogleAds.V6.Resources�!Google\\Ads\\GoogleAds\\V6\\Resources�%Google::Ads::GoogleAds::V6::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

