<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v3/services/feed_mapping_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V3\Services;

class FeedMappingService
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
        \GPBMetadata\Google\Protobuf\Any::initOnce();
        \GPBMetadata\Google\Rpc\Status::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
;google/ads/googleads/v3/enums/price_placeholder_field.protogoogle.ads.googleads.v3.enums"�	
PricePlaceholderFieldEnum"�	
PricePlaceholderField
UNSPECIFIED 
UNKNOWN
TYPE
PRICE_QUALIFIER
TRACKING_TEMPLATE
LANGUAGE
FINAL_URL_SUFFIX
ITEM_1_HEADERd
ITEM_1_DESCRIPTIONe
ITEM_1_PRICEf
ITEM_1_UNITg
ITEM_1_FINAL_URLSh
ITEM_1_FINAL_MOBILE_URLSi
ITEM_2_HEADER�
ITEM_2_DESCRIPTION�
ITEM_2_PRICE�
ITEM_2_UNIT�
ITEM_2_FINAL_URLS�
ITEM_2_FINAL_MOBILE_URLS�
ITEM_3_HEADER�
ITEM_3_DESCRIPTION�
ITEM_3_PRICE�
ITEM_3_UNIT�
ITEM_3_FINAL_URLS�
ITEM_3_FINAL_MOBILE_URLS�
ITEM_4_HEADER�
ITEM_4_DESCRIPTION�
ITEM_4_PRICE�
ITEM_4_UNIT�
ITEM_4_FINAL_URLS�
ITEM_4_FINAL_MOBILE_URLS�
ITEM_5_HEADER�
ITEM_5_DESCRIPTION�
ITEM_5_PRICE�
ITEM_5_UNIT�
ITEM_5_FINAL_URLS�
ITEM_5_FINAL_MOBILE_URLS�
ITEM_6_HEADER�
ITEM_6_DESCRIPTION�
ITEM_6_PRICE�
ITEM_6_UNIT�
ITEM_6_FINAL_URLS�
ITEM_6_FINAL_MOBILE_URLS�
ITEM_7_HEADER�
ITEM_7_DESCRIPTION�
ITEM_7_PRICE�
ITEM_7_UNIT�
ITEM_7_FINAL_URLS�
ITEM_7_FINAL_MOBILE_URLS�
ITEM_8_HEADER�
ITEM_8_DESCRIPTION�
ITEM_8_PRICE�
ITEM_8_UNIT�
ITEM_8_FINAL_URLS�
ITEM_8_FINAL_MOBILE_URLS�B�
!com.google.ads.googleads.v3.enumsBPricePlaceholderFieldProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
4google/ads/googleads/v3/enums/placeholder_type.protogoogle.ads.googleads.v3.enums"�
PlaceholderTypeEnum"�
PlaceholderType
UNSPECIFIED 
UNKNOWN
SITELINK
CALL
APP
LOCATION
AFFILIATE_LOCATION
CALLOUT
STRUCTURED_SNIPPET
MESSAGE		
PRICE

	PROMOTION
AD_CUSTOMIZER
DYNAMIC_EDUCATION
DYNAMIC_FLIGHT
DYNAMIC_CUSTOM
DYNAMIC_HOTEL
DYNAMIC_REAL_ESTATE
DYNAMIC_TRAVEL
DYNAMIC_LOCAL
DYNAMIC_JOBB�
!com.google.ads.googleads.v3.enumsBPlaceholderTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
Cgoogle/ads/googleads/v3/enums/ad_customizer_placeholder_field.protogoogle.ads.googleads.v3.enums"�
 AdCustomizerPlaceholderFieldEnum"j
AdCustomizerPlaceholderField
UNSPECIFIED 
UNKNOWN
INTEGER	
PRICE
DATE

STRINGB�
!com.google.ads.googleads.v3.enumsB!AdCustomizerPlaceholderFieldProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
Hgoogle/ads/googleads/v3/enums/affiliate_location_placeholder_field.protogoogle.ads.googleads.v3.enums"�
%AffiliateLocationPlaceholderFieldEnum"�
!AffiliateLocationPlaceholderField
UNSPECIFIED 
UNKNOWN
BUSINESS_NAME
ADDRESS_LINE_1
ADDRESS_LINE_2
CITY
PROVINCE
POSTAL_CODE
COUNTRY_CODE
PHONE_NUMBER	
LANGUAGE_CODE

CHAIN_ID

CHAIN_NAMEB�
!com.google.ads.googleads.v3.enumsB&AffiliateLocationPlaceholderFieldProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
9google/ads/googleads/v3/enums/app_placeholder_field.protogoogle.ads.googleads.v3.enums"�
AppPlaceholderFieldEnum"�
AppPlaceholderField
UNSPECIFIED 
UNKNOWN	
STORE
ID
	LINK_TEXT
URL

FINAL_URLS
FINAL_MOBILE_URLS
TRACKING_URL
FINAL_URL_SUFFIX	B�
!com.google.ads.googleads.v3.enumsBAppPlaceholderFieldProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
:google/ads/googleads/v3/enums/call_placeholder_field.protogoogle.ads.googleads.v3.enums"�
CallPlaceholderFieldEnum"�
CallPlaceholderField
UNSPECIFIED 
UNKNOWN
PHONE_NUMBER
COUNTRY_CODE
TRACKED
CONVERSION_TYPE_ID
CONVERSION_REPORTING_STATEB�
!com.google.ads.googleads.v3.enumsBCallPlaceholderFieldProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
=google/ads/googleads/v3/enums/callout_placeholder_field.protogoogle.ads.googleads.v3.enums"h
CalloutPlaceholderFieldEnum"I
CalloutPlaceholderField
UNSPECIFIED 
UNKNOWN
CALLOUT_TEXTB�
!com.google.ads.googleads.v3.enumsBCalloutPlaceholderFieldProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
<google/ads/googleads/v3/enums/custom_placeholder_field.protogoogle.ads.googleads.v3.enums"�
CustomPlaceholderFieldEnum"�
CustomPlaceholderField
UNSPECIFIED 
UNKNOWN
ID
ID2

ITEM_TITLE
ITEM_SUBTITLE
ITEM_DESCRIPTION
ITEM_ADDRESS	
PRICE
FORMATTED_PRICE	

SALE_PRICE

FORMATTED_SALE_PRICE
	IMAGE_URL
ITEM_CATEGORY

FINAL_URLS
FINAL_MOBILE_URLS
TRACKING_URL
CONTEXTUAL_KEYWORDS
ANDROID_APP_LINK
SIMILAR_IDS
IOS_APP_LINK
IOS_APP_STORE_IDB�
!com.google.ads.googleads.v3.enumsBCustomPlaceholderFieldProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
Agoogle/ads/googleads/v3/enums/dsa_page_feed_criterion_field.protogoogle.ads.googleads.v3.enums"s
DsaPageFeedCriterionFieldEnum"R
DsaPageFeedCriterionField
UNSPECIFIED 
UNKNOWN
PAGE_URL	
LABELB�
!com.google.ads.googleads.v3.enumsBDsaPageFeedCriterionFieldProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
?google/ads/googleads/v3/enums/education_placeholder_field.protogoogle.ads.googleads.v3.enums"�
EducationPlaceholderFieldEnum"�
EducationPlaceholderField
UNSPECIFIED 
UNKNOWN

PROGRAM_ID
LOCATION_ID
PROGRAM_NAME
AREA_OF_STUDY
PROGRAM_DESCRIPTION
SCHOOL_NAME
ADDRESS
THUMBNAIL_IMAGE_URL	#
ALTERNATIVE_THUMBNAIL_IMAGE_URL


FINAL_URLS
FINAL_MOBILE_URLS
TRACKING_URL
CONTEXTUAL_KEYWORDS
ANDROID_APP_LINK
SIMILAR_PROGRAM_IDS
IOS_APP_LINK
IOS_APP_STORE_IDB�
!com.google.ads.googleads.v3.enumsBEducationPlaceholderFieldProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
?google/ads/googleads/v3/enums/feed_mapping_criterion_type.protogoogle.ads.googleads.v3.enums"�
FeedMappingCriterionTypeEnum"m
FeedMappingCriterionType
UNSPECIFIED 
UNKNOWN 
LOCATION_EXTENSION_TARGETING
DSA_PAGE_FEEDB�
!com.google.ads.googleads.v3.enumsBFeedMappingCriterionTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
7google/ads/googleads/v3/enums/feed_mapping_status.protogoogle.ads.googleads.v3.enums"d
FeedMappingStatusEnum"K
FeedMappingStatus
UNSPECIFIED 
UNKNOWN
ENABLED
REMOVEDB�
!com.google.ads.googleads.v3.enumsBFeedMappingStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
<google/ads/googleads/v3/enums/flight_placeholder_field.protogoogle.ads.googleads.v3.enums"�
FlightPlaceholderFieldEnum"�
FlightPlaceholderField
UNSPECIFIED 
UNKNOWN
DESTINATION_ID
	ORIGIN_ID
FLIGHT_DESCRIPTION
ORIGIN_NAME
DESTINATION_NAME
FLIGHT_PRICE
FORMATTED_PRICE
FLIGHT_SALE_PRICE	
FORMATTED_SALE_PRICE

	IMAGE_URL

FINAL_URLS
FINAL_MOBILE_URLS
TRACKING_URL
ANDROID_APP_LINK
SIMILAR_DESTINATION_IDS
IOS_APP_LINK
IOS_APP_STORE_IDB�
!com.google.ads.googleads.v3.enumsBFlightsPlaceholderFieldProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
;google/ads/googleads/v3/enums/hotel_placeholder_field.protogoogle.ads.googleads.v3.enums"�
HotelPlaceholderFieldEnum"�
HotelPlaceholderField
UNSPECIFIED 
UNKNOWN
PROPERTY_ID
PROPERTY_NAME
DESTINATION_NAME
DESCRIPTION
ADDRESS	
PRICE
FORMATTED_PRICE

SALE_PRICE	
FORMATTED_SALE_PRICE

	IMAGE_URL
CATEGORY
STAR_RATING
CONTEXTUAL_KEYWORDS

FINAL_URLS
FINAL_MOBILE_URLS
TRACKING_URL
ANDROID_APP_LINK
SIMILAR_PROPERTY_IDS
IOS_APP_LINK
IOS_APP_STORE_IDB�
!com.google.ads.googleads.v3.enumsBHotelsPlaceholderFieldProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
=google/ads/googleads/v3/enums/message_placeholder_field.protogoogle.ads.googleads.v3.enums"�
MessagePlaceholderFieldEnum"�
MessagePlaceholderField
UNSPECIFIED 
UNKNOWN
BUSINESS_NAME
COUNTRY_CODE
PHONE_NUMBER
MESSAGE_EXTENSION_TEXT
MESSAGE_TEXTB�
!com.google.ads.googleads.v3.enumsBMessagePlaceholderFieldProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
9google/ads/googleads/v3/enums/job_placeholder_field.protogoogle.ads.googleads.v3.enums"�
JobPlaceholderFieldEnum"�
JobPlaceholderField
UNSPECIFIED 
UNKNOWN

JOB_ID
LOCATION_ID	
TITLE
SUBTITLE
DESCRIPTION
	IMAGE_URL
CATEGORY
CONTEXTUAL_KEYWORDS	
ADDRESS


SALARY

FINAL_URLS
FINAL_MOBILE_URLS
TRACKING_URL
ANDROID_APP_LINK
SIMILAR_JOB_IDS
IOS_APP_LINK
IOS_APP_STORE_IDB�
!com.google.ads.googleads.v3.enumsBJobsPlaceholderFieldProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
;google/ads/googleads/v3/enums/local_placeholder_field.protogoogle.ads.googleads.v3.enums"�
LocalPlaceholderFieldEnum"�
LocalPlaceholderField
UNSPECIFIED 
UNKNOWN
DEAL_ID
	DEAL_NAME
SUBTITLE
DESCRIPTION	
PRICE
FORMATTED_PRICE

SALE_PRICE
FORMATTED_SALE_PRICE	
	IMAGE_URL

ADDRESS
CATEGORY
CONTEXTUAL_KEYWORDS

FINAL_URLS
FINAL_MOBILE_URLS
TRACKING_URL
ANDROID_APP_LINK
SIMILAR_DEAL_IDS
IOS_APP_LINK
IOS_APP_STORE_IDB�
!com.google.ads.googleads.v3.enumsBLocalPlaceholderFieldProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
Pgoogle/ads/googleads/v3/enums/location_extension_targeting_criterion_field.protogoogle.ads.googleads.v3.enums"�
,LocationExtensionTargetingCriterionFieldEnum"�
(LocationExtensionTargetingCriterionField
UNSPECIFIED 
UNKNOWN
ADDRESS_LINE_1
ADDRESS_LINE_2
CITY
PROVINCE
POSTAL_CODE
COUNTRY_CODEB�
!com.google.ads.googleads.v3.enumsB-LocationExtensionTargetingCriterionFieldProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
>google/ads/googleads/v3/enums/location_placeholder_field.protogoogle.ads.googleads.v3.enums"�
LocationPlaceholderFieldEnum"�
LocationPlaceholderField
UNSPECIFIED 
UNKNOWN
BUSINESS_NAME
ADDRESS_LINE_1
ADDRESS_LINE_2
CITY
PROVINCE
POSTAL_CODE
COUNTRY_CODE
PHONE_NUMBER	B�
!com.google.ads.googleads.v3.enumsBLocationPlaceholderFieldProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
?google/ads/googleads/v3/enums/promotion_placeholder_field.protogoogle.ads.googleads.v3.enums"�
PromotionPlaceholderFieldEnum"�
PromotionPlaceholderField
UNSPECIFIED 
UNKNOWN
PROMOTION_TARGET
DISCOUNT_MODIFIER
PERCENT_OFF
MONEY_AMOUNT_OFF
PROMOTION_CODE
ORDERS_OVER_AMOUNT
PROMOTION_START
PROMOTION_END	
OCCASION


FINAL_URLS
FINAL_MOBILE_URLS
TRACKING_URL
LANGUAGE
FINAL_URL_SUFFIXB�
!com.google.ads.googleads.v3.enumsBPromotionPlaceholderFieldProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
Agoogle/ads/googleads/v3/enums/real_estate_placeholder_field.protogoogle.ads.googleads.v3.enums"�
RealEstatePlaceholderFieldEnum"�
RealEstatePlaceholderField
UNSPECIFIED 
UNKNOWN

LISTING_ID
LISTING_NAME
	CITY_NAME
DESCRIPTION
ADDRESS	
PRICE
FORMATTED_PRICE
	IMAGE_URL	
PROPERTY_TYPE

LISTING_TYPE
CONTEXTUAL_KEYWORDS

FINAL_URLS
FINAL_MOBILE_URLS
TRACKING_URL
ANDROID_APP_LINK
SIMILAR_LISTING_IDS
IOS_APP_LINK
IOS_APP_STORE_IDB�
!com.google.ads.googleads.v3.enumsBRealEstatePlaceholderFieldProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
>google/ads/googleads/v3/enums/sitelink_placeholder_field.protogoogle.ads.googleads.v3.enums"�
SitelinkPlaceholderFieldEnum"�
SitelinkPlaceholderField
UNSPECIFIED 
UNKNOWN
TEXT

LINE_1

LINE_2

FINAL_URLS
FINAL_MOBILE_URLS
TRACKING_URL
FINAL_URL_SUFFIXB�
!com.google.ads.googleads.v3.enumsBSitelinkPlaceholderFieldProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
Hgoogle/ads/googleads/v3/enums/structured_snippet_placeholder_field.protogoogle.ads.googleads.v3.enums"�
%StructuredSnippetPlaceholderFieldEnum"[
!StructuredSnippetPlaceholderField
UNSPECIFIED 
UNKNOWN

HEADER
SNIPPETSB�
!com.google.ads.googleads.v3.enumsB&StructuredSnippetPlaceholderFieldProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
<google/ads/googleads/v3/enums/travel_placeholder_field.protogoogle.ads.googleads.v3.enums"�
TravelPlaceholderFieldEnum"�
TravelPlaceholderField
UNSPECIFIED 
UNKNOWN
DESTINATION_ID
	ORIGIN_ID	
TITLE
DESTINATION_NAME
ORIGIN_NAME	
PRICE
FORMATTED_PRICE

SALE_PRICE	
FORMATTED_SALE_PRICE

	IMAGE_URL
CATEGORY
CONTEXTUAL_KEYWORDS
DESTINATION_ADDRESS
	FINAL_URL
FINAL_MOBILE_URLS
TRACKING_URL
ANDROID_APP_LINK
SIMILAR_DESTINATION_IDS
IOS_APP_LINK
IOS_APP_STORE_IDB�
!com.google.ads.googleads.v3.enumsBTravelPlaceholderFieldProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�)
4google/ads/googleads/v3/resources/feed_mapping.proto!google.ads.googleads.v3.resourcesHgoogle/ads/googleads/v3/enums/affiliate_location_placeholder_field.proto9google/ads/googleads/v3/enums/app_placeholder_field.proto:google/ads/googleads/v3/enums/call_placeholder_field.proto=google/ads/googleads/v3/enums/callout_placeholder_field.proto<google/ads/googleads/v3/enums/custom_placeholder_field.protoAgoogle/ads/googleads/v3/enums/dsa_page_feed_criterion_field.proto?google/ads/googleads/v3/enums/education_placeholder_field.proto?google/ads/googleads/v3/enums/feed_mapping_criterion_type.proto7google/ads/googleads/v3/enums/feed_mapping_status.proto<google/ads/googleads/v3/enums/flight_placeholder_field.proto;google/ads/googleads/v3/enums/hotel_placeholder_field.proto9google/ads/googleads/v3/enums/job_placeholder_field.proto;google/ads/googleads/v3/enums/local_placeholder_field.protoPgoogle/ads/googleads/v3/enums/location_extension_targeting_criterion_field.proto>google/ads/googleads/v3/enums/location_placeholder_field.proto=google/ads/googleads/v3/enums/message_placeholder_field.proto4google/ads/googleads/v3/enums/placeholder_type.proto;google/ads/googleads/v3/enums/price_placeholder_field.proto?google/ads/googleads/v3/enums/promotion_placeholder_field.protoAgoogle/ads/googleads/v3/enums/real_estate_placeholder_field.proto>google/ads/googleads/v3/enums/sitelink_placeholder_field.protoHgoogle/ads/googleads/v3/enums/structured_snippet_placeholder_field.proto<google/ads/googleads/v3/enums/travel_placeholder_field.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
FeedMappingC
resource_name (	B,�A�A&
$googleads.googleapis.com/FeedMappingQ
feed (2.google.protobuf.StringValueB%�A�A
googleads.googleapis.com/Feed_
attribute_field_mappings (28.google.ads.googleads.v3.resources.AttributeFieldMappingB�A[
status (2F.google.ads.googleads.v3.enums.FeedMappingStatusEnum.FeedMappingStatusB�Ac
placeholder_type (2B.google.ads.googleads.v3.enums.PlaceholderTypeEnum.PlaceholderTypeB�AH s
criterion_type (2T.google.ads.googleads.v3.enums.FeedMappingCriterionTypeEnum.FeedMappingCriterionTypeB�AH :[�AX
$googleads.googleapis.com/FeedMapping0customers/{customer}/feedMappings/{feed_mapping}B
target"�
AttributeFieldMapping;
feed_attribute_id (2.google.protobuf.Int64ValueB�A2
field_id (2.google.protobuf.Int64ValueB�As
sitelink_field (2T.google.ads.googleads.v3.enums.SitelinkPlaceholderFieldEnum.SitelinkPlaceholderFieldB�AH g

call_field (2L.google.ads.googleads.v3.enums.CallPlaceholderFieldEnum.CallPlaceholderFieldB�AH d
	app_field (2J.google.ads.googleads.v3.enums.AppPlaceholderFieldEnum.AppPlaceholderFieldB�AH s
location_field (2T.google.ads.googleads.v3.enums.LocationPlaceholderFieldEnum.LocationPlaceholderFieldB�AH �
affiliate_location_field (2f.google.ads.googleads.v3.enums.AffiliateLocationPlaceholderFieldEnum.AffiliateLocationPlaceholderFieldB�AH p
callout_field (2R.google.ads.googleads.v3.enums.CalloutPlaceholderFieldEnum.CalloutPlaceholderFieldB�AH �
structured_snippet_field	 (2f.google.ads.googleads.v3.enums.StructuredSnippetPlaceholderFieldEnum.StructuredSnippetPlaceholderFieldB�AH p
message_field
 (2R.google.ads.googleads.v3.enums.MessagePlaceholderFieldEnum.MessagePlaceholderFieldB�AH j
price_field (2N.google.ads.googleads.v3.enums.PricePlaceholderFieldEnum.PricePlaceholderFieldB�AH v
promotion_field (2V.google.ads.googleads.v3.enums.PromotionPlaceholderFieldEnum.PromotionPlaceholderFieldB�AH �
ad_customizer_field (2\\.google.ads.googleads.v3.enums.AdCustomizerPlaceholderFieldEnum.AdCustomizerPlaceholderFieldB�AH z
dsa_page_feed_field (2V.google.ads.googleads.v3.enums.DsaPageFeedCriterionFieldEnum.DsaPageFeedCriterionFieldB�AH �
"location_extension_targeting_field (2t.google.ads.googleads.v3.enums.LocationExtensionTargetingCriterionFieldEnum.LocationExtensionTargetingCriterionFieldB�AH v
education_field (2V.google.ads.googleads.v3.enums.EducationPlaceholderFieldEnum.EducationPlaceholderFieldB�AH m
flight_field (2P.google.ads.googleads.v3.enums.FlightPlaceholderFieldEnum.FlightPlaceholderFieldB�AH m
custom_field (2P.google.ads.googleads.v3.enums.CustomPlaceholderFieldEnum.CustomPlaceholderFieldB�AH j
hotel_field (2N.google.ads.googleads.v3.enums.HotelPlaceholderFieldEnum.HotelPlaceholderFieldB�AH z
real_estate_field (2X.google.ads.googleads.v3.enums.RealEstatePlaceholderFieldEnum.RealEstatePlaceholderFieldB�AH m
travel_field (2P.google.ads.googleads.v3.enums.TravelPlaceholderFieldEnum.TravelPlaceholderFieldB�AH j
local_field (2N.google.ads.googleads.v3.enums.LocalPlaceholderFieldEnum.LocalPlaceholderFieldB�AH d
	job_field (2J.google.ads.googleads.v3.enums.JobPlaceholderFieldEnum.JobPlaceholderFieldB�AH B
fieldB�
%com.google.ads.googleads.v3.resourcesBFeedMappingProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v3/resources;resources�GAA�!Google.Ads.GoogleAds.V3.Resources�!Google\\Ads\\GoogleAds\\V3\\Resources�%Google::Ads::GoogleAds::V3::Resourcesbproto3
�
;google/ads/googleads/v3/services/feed_mapping_service.proto google.ads.googleads.v3.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/rpc/status.proto"\\
GetFeedMappingRequestC
resource_name (	B,�A�A&
$googleads.googleapis.com/FeedMapping"�
MutateFeedMappingsRequest
customer_id (	B�AO

operations (26.google.ads.googleads.v3.services.FeedMappingOperationB�A
partial_failure (
validate_only ("w
FeedMappingOperation@
create (2..google.ads.googleads.v3.resources.FeedMappingH 
remove (	H B
	operation"�
MutateFeedMappingsResponse1
partial_failure_error (2.google.rpc.StatusJ
results (29.google.ads.googleads.v3.services.MutateFeedMappingResult"0
MutateFeedMappingResult
resource_name (	2�
FeedMappingService�
GetFeedMapping7.google.ads.googleads.v3.services.GetFeedMappingRequest..google.ads.googleads.v3.resources.FeedMapping"F���0./v3/{resource_name=customers/*/feedMappings/*}�Aresource_name�
MutateFeedMappings;.google.ads.googleads.v3.services.MutateFeedMappingsRequest<.google.ads.googleads.v3.services.MutateFeedMappingsResponse"U���6"1/v3/customers/{customer_id=*}/feedMappings:mutate:*�Acustomer_id,operationsE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v3.servicesBFeedMappingServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v3/services;services�GAA� Google.Ads.GoogleAds.V3.Services� Google\\Ads\\GoogleAds\\V3\\Services�$Google::Ads::GoogleAds::V3::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

