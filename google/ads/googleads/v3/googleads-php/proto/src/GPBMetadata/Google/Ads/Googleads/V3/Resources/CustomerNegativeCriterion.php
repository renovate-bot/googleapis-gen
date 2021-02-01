<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v3/resources/customer_negative_criterion.proto

namespace GPBMetadata\Google\Ads\Googleads\V3\Resources;

class CustomerNegativeCriterion
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
        $pool->internalAddGeneratedFile(
            '
�
5google/ads/googleads/v3/enums/product_condition.protogoogle.ads.googleads.v3.enums"l
ProductConditionEnum"T
ProductCondition
UNSPECIFIED 
UNKNOWN
NEW
REFURBISHED
USEDB�
!com.google.ads.googleads.v3.enumsBProductConditionProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
2google/ads/googleads/v3/enums/age_range_type.protogoogle.ads.googleads.v3.enums"�
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
!com.google.ads.googleads.v3.enumsBAgeRangeTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
:google/ads/googleads/v3/enums/proximity_radius_units.protogoogle.ads.googleads.v3.enums"k
ProximityRadiusUnitsEnum"O
ProximityRadiusUnits
UNSPECIFIED 
UNKNOWN	
MILES

KILOMETERSB�
!com.google.ads.googleads.v3.enumsBProximityRadiusUnitsProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
:google/ads/googleads/v3/enums/app_payment_model_type.protogoogle.ads.googleads.v3.enums"X
AppPaymentModelTypeEnum"=
AppPaymentModelType
UNSPECIFIED 
UNKNOWN
PAIDB�
!com.google.ads.googleads.v3.enumsBAppPaymentModelTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
6google/ads/googleads/v3/enums/content_label_type.protogoogle.ads.googleads.v3.enums"�
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
!com.google.ads.googleads.v3.enumsBContentLabelTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
/google/ads/googleads/v3/enums/day_of_week.protogoogle.ads.googleads.v3.enums"�
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
!com.google.ads.googleads.v3.enumsBDayOfWeekProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
*google/ads/googleads/v3/enums/device.protogoogle.ads.googleads.v3.enums"v

DeviceEnum"h
Device
UNSPECIFIED 
UNKNOWN

MOBILE

TABLET
DESKTOP
CONNECTED_TV	
OTHERB�
!com.google.ads.googleads.v3.enumsBDeviceProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
/google/ads/googleads/v3/enums/gender_type.protogoogle.ads.googleads.v3.enums"d
GenderTypeEnum"R

GenderType
UNSPECIFIED 
UNKNOWN
MALE


FEMALE
UNDETERMINEDB�
!com.google.ads.googleads.v3.enumsBGenderTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
=google/ads/googleads/v3/enums/hotel_date_selection_type.protogoogle.ads.googleads.v3.enums"~
HotelDateSelectionTypeEnum"`
HotelDateSelectionType
UNSPECIFIED 
UNKNOWN
DEFAULT_SELECTION2
USER_SELECTED3B�
!com.google.ads.googleads.v3.enumsBHotelDateSelectionTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
5google/ads/googleads/v3/enums/income_range_type.protogoogle.ads.googleads.v3.enums"�
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
!com.google.ads.googleads.v3.enumsBIncomeRangeTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
4google/ads/googleads/v3/enums/interaction_type.protogoogle.ads.googleads.v3.enums"R
InteractionTypeEnum";
InteractionType
UNSPECIFIED 
UNKNOWN

CALLS�>B�
!com.google.ads.googleads.v3.enumsBInteractionTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
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
�
6google/ads/googleads/v3/enums/listing_group_type.protogoogle.ads.googleads.v3.enums"c
ListingGroupTypeEnum"K
ListingGroupType
UNSPECIFIED 
UNKNOWN
SUBDIVISION
UNITB�
!com.google.ads.googleads.v3.enumsBListingGroupTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
?google/ads/googleads/v3/enums/location_group_radius_units.protogoogle.ads.googleads.v3.enums"o
LocationGroupRadiusUnitsEnum"O
LocationGroupRadiusUnits
UNSPECIFIED 
UNKNOWN

METERS	
MILESB�
!com.google.ads.googleads.v3.enumsBLocationGroupRadiusUnitsProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
2google/ads/googleads/v3/enums/minute_of_hour.protogoogle.ads.googleads.v3.enums"s
MinuteOfHourEnum"_
MinuteOfHour
UNSPECIFIED 
UNKNOWN
ZERO
FIFTEEN

THIRTY

FORTY_FIVEB�
!com.google.ads.googleads.v3.enumsBMinuteOfHourProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
8google/ads/googleads/v3/enums/parental_status_type.protogoogle.ads.googleads.v3.enums"
ParentalStatusTypeEnum"e
ParentalStatusType
UNSPECIFIED 
UNKNOWN
PARENT�
NOT_A_PARENT�
UNDETERMINED�B�
!com.google.ads.googleads.v3.enumsBParentalStatusTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
:google/ads/googleads/v3/enums/preferred_content_type.protogoogle.ads.googleads.v3.enums"j
PreferredContentTypeEnum"N
PreferredContentType
UNSPECIFIED 
UNKNOWN
YOUTUBE_TOP_CONTENT�B�
!com.google.ads.googleads.v3.enumsBPreferredContentTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
Bgoogle/ads/googleads/v3/enums/product_bidding_category_level.protogoogle.ads.googleads.v3.enums"�
ProductBiddingCategoryLevelEnum"w
ProductBiddingCategoryLevel
UNSPECIFIED 
UNKNOWN

LEVEL1

LEVEL2

LEVEL3

LEVEL4

LEVEL5B�
!com.google.ads.googleads.v3.enumsB ProductBiddingCategoryLevelProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
3google/ads/googleads/v3/enums/product_channel.protogoogle.ads.googleads.v3.enums"[
ProductChannelEnum"E
ProductChannel
UNSPECIFIED 
UNKNOWN

ONLINE	
LOCALB�
!com.google.ads.googleads.v3.enumsBProductChannelProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
?google/ads/googleads/v3/enums/product_channel_exclusivity.protogoogle.ads.googleads.v3.enums"�
ProductChannelExclusivityEnum"`
ProductChannelExclusivity
UNSPECIFIED 
UNKNOWN
SINGLE_CHANNEL
MULTI_CHANNELB�
!com.google.ads.googleads.v3.enumsBProductChannelExclusivityProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
Bgoogle/ads/googleads/v3/enums/product_custom_attribute_index.protogoogle.ads.googleads.v3.enums"�
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
!com.google.ads.googleads.v3.enumsB ProductCustomAttributeIndexProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
6google/ads/googleads/v3/enums/product_type_level.protogoogle.ads.googleads.v3.enums"�
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
!com.google.ads.googleads.v3.enumsBProductTypeLevelProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
=google/ads/googleads/v3/enums/webpage_condition_operand.protogoogle.ads.googleads.v3.enums"�
WebpageConditionOperandEnum"�
WebpageConditionOperand
UNSPECIFIED 
UNKNOWN
URL
CATEGORY

PAGE_TITLE
PAGE_CONTENT
CUSTOM_LABELB�
!com.google.ads.googleads.v3.enumsBWebpageConditionOperandProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
>google/ads/googleads/v3/enums/webpage_condition_operator.protogoogle.ads.googleads.v3.enums"r
WebpageConditionOperatorEnum"R
WebpageConditionOperator
UNSPECIFIED 
UNKNOWN

EQUALS
CONTAINSB�
!com.google.ads.googleads.v3.enumsBWebpageConditionOperatorProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�I
-google/ads/googleads/v3/common/criteria.protogoogle.ads.googleads.v3.common:google/ads/googleads/v3/enums/app_payment_model_type.proto6google/ads/googleads/v3/enums/content_label_type.proto/google/ads/googleads/v3/enums/day_of_week.proto*google/ads/googleads/v3/enums/device.proto/google/ads/googleads/v3/enums/gender_type.proto=google/ads/googleads/v3/enums/hotel_date_selection_type.proto5google/ads/googleads/v3/enums/income_range_type.proto4google/ads/googleads/v3/enums/interaction_type.proto6google/ads/googleads/v3/enums/keyword_match_type.proto6google/ads/googleads/v3/enums/listing_group_type.proto?google/ads/googleads/v3/enums/location_group_radius_units.proto2google/ads/googleads/v3/enums/minute_of_hour.proto8google/ads/googleads/v3/enums/parental_status_type.proto:google/ads/googleads/v3/enums/preferred_content_type.protoBgoogle/ads/googleads/v3/enums/product_bidding_category_level.proto3google/ads/googleads/v3/enums/product_channel.proto?google/ads/googleads/v3/enums/product_channel_exclusivity.proto5google/ads/googleads/v3/enums/product_condition.protoBgoogle/ads/googleads/v3/enums/product_custom_attribute_index.proto6google/ads/googleads/v3/enums/product_type_level.proto:google/ads/googleads/v3/enums/proximity_radius_units.proto=google/ads/googleads/v3/enums/webpage_condition_operand.proto>google/ads/googleads/v3/enums/webpage_condition_operator.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
KeywordInfo*
text (2.google.protobuf.StringValueX

match_type (2D.google.ads.googleads.v3.enums.KeywordMatchTypeEnum.KeywordMatchType":
PlacementInfo)
url (2.google.protobuf.StringValue"[
MobileAppCategoryInfoB
mobile_app_category_constant (2.google.protobuf.StringValue"q
MobileApplicationInfo,
app_id (2.google.protobuf.StringValue*
name (2.google.protobuf.StringValue"I
LocationInfo9
geo_target_constant (2.google.protobuf.StringValue"L

DeviceInfo>
type (20.google.ads.googleads.v3.enums.DeviceEnum.Device"r
PreferredContentInfoZ
type (2L.google.ads.googleads.v3.enums.PreferredContentTypeEnum.PreferredContentType"�
ListingGroupInfoR
type (2D.google.ads.googleads.v3.enums.ListingGroupTypeEnum.ListingGroupTypeH

case_value (24.google.ads.googleads.v3.common.ListingDimensionInfo?
parent_ad_group_criterion (2.google.protobuf.StringValue"\\
ListingScopeInfoH

dimensions (24.google.ads.googleads.v3.common.ListingDimensionInfo"�	
ListingDimensionInfo?
hotel_id (2+.google.ads.googleads.v3.common.HotelIdInfoH E
hotel_class (2..google.ads.googleads.v3.common.HotelClassInfoH V
hotel_country_region (26.google.ads.googleads.v3.common.HotelCountryRegionInfoH E
hotel_state (2..google.ads.googleads.v3.common.HotelStateInfoH C

hotel_city (2-.google.ads.googleads.v3.common.HotelCityInfoH ^
product_bidding_category (2:.google.ads.googleads.v3.common.ProductBiddingCategoryInfoH I
product_brand (20.google.ads.googleads.v3.common.ProductBrandInfoH M
product_channel (22.google.ads.googleads.v3.common.ProductChannelInfoH d
product_channel_exclusivity	 (2=.google.ads.googleads.v3.common.ProductChannelExclusivityInfoH Q
product_condition
 (24.google.ads.googleads.v3.common.ProductConditionInfoH ^
product_custom_attribute (2:.google.ads.googleads.v3.common.ProductCustomAttributeInfoH L
product_item_id (21.google.ads.googleads.v3.common.ProductItemIdInfoH G
product_type (2/.google.ads.googleads.v3.common.ProductTypeInfoH `
unknown_listing_dimension (2;.google.ads.googleads.v3.common.UnknownListingDimensionInfoH B
	dimension":
HotelIdInfo+
value (2.google.protobuf.StringValue"<
HotelClassInfo*
value (2.google.protobuf.Int64Value"X
HotelCountryRegionInfo>
country_region_criterion (2.google.protobuf.StringValue"G
HotelStateInfo5
state_criterion (2.google.protobuf.StringValue"E
HotelCityInfo4
city_criterion (2.google.protobuf.StringValue"�
ProductBiddingCategoryInfo\'
id (2.google.protobuf.Int64Value2
country_code (2.google.protobuf.StringValuei
level (2Z.google.ads.googleads.v3.enums.ProductBiddingCategoryLevelEnum.ProductBiddingCategoryLevel"?
ProductBrandInfo+
value (2.google.protobuf.StringValue"g
ProductChannelInfoQ
channel (2@.google.ads.googleads.v3.enums.ProductChannelEnum.ProductChannel"�
ProductChannelExclusivityInfos
channel_exclusivity (2V.google.ads.googleads.v3.enums.ProductChannelExclusivityEnum.ProductChannelExclusivity"o
ProductConditionInfoW
	condition (2D.google.ads.googleads.v3.enums.ProductConditionEnum.ProductCondition"�
ProductCustomAttributeInfo+
value (2.google.protobuf.StringValuei
index (2Z.google.ads.googleads.v3.enums.ProductCustomAttributeIndexEnum.ProductCustomAttributeIndex"@
ProductItemIdInfo+
value (2.google.protobuf.StringValue"�
ProductTypeInfo+
value (2.google.protobuf.StringValueS
level (2D.google.ads.googleads.v3.enums.ProductTypeLevelEnum.ProductTypeLevel"
UnknownListingDimensionInfo"|
HotelDateSelectionTypeInfo^
type (2P.google.ads.googleads.v3.enums.HotelDateSelectionTypeEnum.HotelDateSelectionType"}
HotelAdvanceBookingWindowInfo-
min_days (2.google.protobuf.Int64Value-
max_days (2.google.protobuf.Int64Value"y
HotelLengthOfStayInfo/

min_nights (2.google.protobuf.Int64Value/

max_nights (2.google.protobuf.Int64Value"b
HotelCheckInDayInfoK
day_of_week (26.google.ads.googleads.v3.enums.DayOfWeekEnum.DayOfWeek"g
InteractionTypeInfoP
type (2B.google.ads.googleads.v3.enums.InteractionTypeEnum.InteractionType"�
AdScheduleInfoR
start_minute (2<.google.ads.googleads.v3.enums.MinuteOfHourEnum.MinuteOfHourP

end_minute (2<.google.ads.googleads.v3.enums.MinuteOfHourEnum.MinuteOfHour/

start_hour (2.google.protobuf.Int32Value-
end_hour (2.google.protobuf.Int32ValueK
day_of_week (26.google.ads.googleads.v3.enums.DayOfWeekEnum.DayOfWeek"Z
AgeRangeInfoJ
type (2<.google.ads.googleads.v3.enums.AgeRangeTypeEnum.AgeRangeType"T

GenderInfoF
type (28.google.ads.googleads.v3.enums.GenderTypeEnum.GenderType"c
IncomeRangeInfoP
type (2B.google.ads.googleads.v3.enums.IncomeRangeTypeEnum.IncomeRangeType"l
ParentalStatusInfoV
type (2H.google.ads.googleads.v3.enums.ParentalStatusTypeEnum.ParentalStatusType"B
YouTubeVideoInfo.
video_id (2.google.protobuf.StringValue"F
YouTubeChannelInfo0

channel_id (2.google.protobuf.StringValue"?
UserListInfo/
	user_list (2.google.protobuf.StringValue"�
ProximityInfo?
	geo_point (2,.google.ads.googleads.v3.common.GeoPointInfo,
radius (2.google.protobuf.DoubleValueb
radius_units (2L.google.ads.googleads.v3.enums.ProximityRadiusUnitsEnum.ProximityRadiusUnits<
address (2+.google.ads.googleads.v3.common.AddressInfo"�
GeoPointInfo?
longitude_in_micro_degrees (2.google.protobuf.Int32Value>
latitude_in_micro_degrees (2.google.protobuf.Int32Value"�
AddressInfo1
postal_code (2.google.protobuf.StringValue3
province_code (2.google.protobuf.StringValue2
country_code (2.google.protobuf.StringValue3
province_name (2.google.protobuf.StringValue4
street_address (2.google.protobuf.StringValue5
street_address2 (2.google.protobuf.StringValue/
	city_name (2.google.protobuf.StringValue"m
	TopicInfo4
topic_constant (2.google.protobuf.StringValue*
path (2.google.protobuf.StringValue"G
LanguageInfo7
language_constant (2.google.protobuf.StringValue"?
IpBlockInfo0

ip_address (2.google.protobuf.StringValue"f
ContentLabelInfoR
type (2D.google.ads.googleads.v3.enums.ContentLabelTypeEnum.ContentLabelType"E
CarrierInfo6
carrier_constant (2.google.protobuf.StringValue"P
UserInterestInfo<
user_interest_category (2.google.protobuf.StringValue"�
WebpageInfo4
criterion_name (2.google.protobuf.StringValueH

conditions (24.google.ads.googleads.v3.common.WebpageConditionInfo"�
WebpageConditionInfoc
operand (2R.google.ads.googleads.v3.enums.WebpageConditionOperandEnum.WebpageConditionOperandf
operator (2T.google.ads.googleads.v3.enums.WebpageConditionOperatorEnum.WebpageConditionOperator.
argument (2.google.protobuf.StringValue"e
OperatingSystemVersionInfoG
!operating_system_version_constant (2.google.protobuf.StringValue"o
AppPaymentModelInfoX
type (2J.google.ads.googleads.v3.enums.AppPaymentModelTypeEnum.AppPaymentModelType"P
MobileDeviceInfo<
mobile_device_constant (2.google.protobuf.StringValue"K
CustomAffinityInfo5
custom_affinity (2.google.protobuf.StringValue"G
CustomIntentInfo3
custom_intent (2.google.protobuf.StringValue"�
LocationGroupInfo*
feed (2.google.protobuf.StringValue:
geo_target_constants (2.google.protobuf.StringValue+
radius (2.google.protobuf.Int64Valuej
radius_units (2T.google.ads.googleads.v3.enums.LocationGroupRadiusUnitsEnum.LocationGroupRadiusUnitsB�
"com.google.ads.googleads.v3.commonBCriteriaProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v3/common;common�GAA�Google.Ads.GoogleAds.V3.Common�Google\\Ads\\GoogleAds\\V3\\Common�"Google::Ads::GoogleAds::V3::Commonbproto3
�
2google/ads/googleads/v3/enums/criterion_type.protogoogle.ads.googleads.v3.enums"�
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
LOCATION_GROUPB�
!com.google.ads.googleads.v3.enumsBCriterionTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
Cgoogle/ads/googleads/v3/resources/customer_negative_criterion.proto!google.ads.googleads.v3.resources2google/ads/googleads/v3/enums/criterion_type.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
CustomerNegativeCriterionQ
resource_name (	B:�A�A4
2googleads.googleapis.com/CustomerNegativeCriterion,
id (2.google.protobuf.Int64ValueB�AQ
type (2>.google.ads.googleads.v3.enums.CriterionTypeEnum.CriterionTypeB�AN
content_label (20.google.ads.googleads.v3.common.ContentLabelInfoB�AH X
mobile_application (25.google.ads.googleads.v3.common.MobileApplicationInfoB�AH Y
mobile_app_category (25.google.ads.googleads.v3.common.MobileAppCategoryInfoB�AH G
	placement (2-.google.ads.googleads.v3.common.PlacementInfoB�AH N
youtube_video (20.google.ads.googleads.v3.common.YouTubeVideoInfoB�AH R
youtube_channel	 (22.google.ads.googleads.v3.common.YouTubeChannelInfoB�AH :��A�
2googleads.googleapis.com/CustomerNegativeCriterionKcustomers/{customer}/customerNegativeCriteria/{customer_negative_criterion}B
	criterionB�
%com.google.ads.googleads.v3.resourcesBCustomerNegativeCriterionProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v3/resources;resources�GAA�!Google.Ads.GoogleAds.V3.Resources�!Google\\Ads\\GoogleAds\\V3\\Resources�%Google::Ads::GoogleAds::V3::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

