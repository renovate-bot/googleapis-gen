<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v6/common/asset_types.proto

namespace GPBMetadata\Google\Ads\Googleads\V6\Common;

class AssetTypes
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
        $pool->internalAddGeneratedFile(
            '
�
Cgoogle/ads/googleads/v6/enums/lead_form_field_user_input_type.protogoogle.ads.googleads.v6.enums"�

LeadFormFieldUserInputTypeEnum"�

LeadFormFieldUserInputType
UNSPECIFIED 
UNKNOWN
	FULL_NAME

GIVEN_NAME
FAMILY_NAME	
EMAIL
PHONE_NUMBER
POSTAL_CODE
CITY	

REGION

COUNTRY

WORK_EMAIL
COMPANY_NAME

WORK_PHONE
	JOB_TITLE
VEHICLE_MODEL�
VEHICLE_TYPE�
PREFERRED_DEALERSHIP�
VEHICLE_PURCHASE_TIMELINE�
VEHICLE_OWNERSHIP�
VEHICLE_PAYMENT_TYPE�
VEHICLE_CONDITION�
COMPANY_SIZE�
ANNUAL_SALES�
YEARS_IN_BUSINESS�
JOB_DEPARTMENT�
JOB_ROLE�
EDUCATION_PROGRAM�
EDUCATION_COURSE�
PRODUCT�
SERVICE�

OFFER�
CATEGORY�
PREFERRED_CONTACT_METHOD�
PREFERRED_LOCATION�
PREFERRED_CONTACT_TIME�
PURCHASE_TIMELINE�
YEARS_OF_EXPERIENCE�
JOB_INDUSTRY�
LEVEL_OF_EDUCATION�
PROPERTY_TYPE�
REALTOR_HELP_GOAL�
PROPERTY_COMMUNITY�
PRICE_RANGE�
NUMBER_OF_BEDROOMS�
FURNISHED_PROPERTY�
PETS_ALLOWED_PROPERTY�
NEXT_PLANNED_PURCHASE�
EVENT_SIGNUP_INTEREST�
PREFERRED_SHOPPING_PLACES�
FAVORITE_BRAND�+
&TRANSPORTATION_COMMERCIAL_LICENSE_TYPE�
EVENT_BOOKING_INTEREST�
DESTINATION_COUNTRY�
DESTINATION_CITY�
DEPARTURE_COUNTRY�
DEPARTURE_CITY�
DEPARTURE_DATE�
RETURN_DATE�
NUMBER_OF_TRAVELERS�
TRAVEL_BUDGET�
TRAVEL_ACCOMMODATION�B�
!com.google.ads.googleads.v6.enumsBLeadFormFieldUserInputTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
-google/ads/googleads/v6/enums/mime_type.protogoogle.ads.googleads.v6.enums"�
MimeTypeEnum"�
MimeType
UNSPECIFIED 
UNKNOWN

IMAGE_JPEG
	IMAGE_GIF
	IMAGE_PNG	
FLASH
	TEXT_HTML
PDF

MSWORD
MSEXCEL	
RTF

	AUDIO_WAV
	AUDIO_MP3
HTML5_AD_ZIPB�
!com.google.ads.googleads.v6.enumsBMimeTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
<google/ads/googleads/v6/enums/lead_form_desired_intent.protogoogle.ads.googleads.v6.enums"s
LeadFormDesiredIntentEnum"V
LeadFormDesiredIntent
UNSPECIFIED 
UNKNOWN

LOW_INTENT
HIGH_INTENTB�
!com.google.ads.googleads.v6.enumsBLeadFormDesiredIntentProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
Mgoogle/ads/googleads/v6/enums/lead_form_post_submit_call_to_action_type.protogoogle.ads.googleads.v6.enums"�
&LeadFormPostSubmitCallToActionTypeEnum"~
"LeadFormPostSubmitCallToActionType
UNSPECIFIED 
UNKNOWN

VISIT_SITE
DOWNLOAD

LEARN_MORE
SHOP_NOWB�
!com.google.ads.googleads.v6.enumsB\'LeadFormPostSubmitCallToActionTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
Agoogle/ads/googleads/v6/enums/lead_form_call_to_action_type.protogoogle.ads.googleads.v6.enums"�
LeadFormCallToActionTypeEnum"�
LeadFormCallToActionType
UNSPECIFIED 
UNKNOWN

LEARN_MORE
	GET_QUOTE
	APPLY_NOW
SIGN_UP

CONTACT_US
	SUBSCRIBE
DOWNLOAD
BOOK_NOW	
	GET_OFFER

REGISTER
GET_INFO
REQUEST_DEMO
JOIN_NOW
GET_STARTEDB�
!com.google.ads.googleads.v6.enumsBLeadFormCallToActionTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
0google/ads/googleads/v6/common/asset_types.protogoogle.ads.googleads.v6.common<google/ads/googleads/v6/enums/lead_form_desired_intent.protoCgoogle/ads/googleads/v6/enums/lead_form_field_user_input_type.protoMgoogle/ads/googleads/v6/enums/lead_form_post_submit_call_to_action_type.proto-google/ads/googleads/v6/enums/mime_type.protogoogle/api/field_behavior.protogoogle/api/annotations.proto"G
YoutubeVideoAsset
youtube_video_id (	H �B
_youtube_video_id".
MediaBundleAsset
data (H �B
_data"�

ImageAsset
data (H �
	file_size (H�G
	mime_type (24.google.ads.googleads.v6.enums.MimeTypeEnum.MimeTypeA
	full_size (2..google.ads.googleads.v6.common.ImageDimensionB
_dataB

_file_size"�
ImageDimension
height_pixels (H �
width_pixels (H�
url (	H�B
_height_pixelsB
_width_pixelsB
_url"\'
	TextAsset
text (	H �B
_text"�
LeadFormAsset
business_name
 (	B�Av
call_to_action_type (2T.google.ads.googleads.v6.enums.LeadFormCallToActionTypeEnum.LeadFormCallToActionTypeB�A\'
call_to_action_description (	B�A
headline (	B�A
description (	B�A
privacy_policy_url (	B�A!
post_submit_headline (	H �$
post_submit_description (	H�=
fields (2-.google.ads.googleads.v6.common.LeadFormFieldP
delivery_methods	 (26.google.ads.googleads.v6.common.LeadFormDeliveryMethod�
post_submit_call_to_action_type (2h.google.ads.googleads.v6.enums.LeadFormPostSubmitCallToActionTypeEnum.LeadFormPostSubmitCallToActionType#
background_image_asset (	H�f
desired_intent (2N.google.ads.googleads.v6.enums.LeadFormDesiredIntentEnum.LeadFormDesiredIntent
custom_disclosure (	H�B
_post_submit_headlineB
_post_submit_descriptionB
_background_image_assetB
_custom_disclosure"�
LeadFormFieldl

input_type (2X.google.ads.googleads.v6.enums.LeadFormFieldUserInputTypeEnum.LeadFormFieldUserInputType\\
single_choice_answers (2;.google.ads.googleads.v6.common.LeadFormSingleChoiceAnswersH B	
answers".
LeadFormSingleChoiceAnswers
answers (	"p
LeadFormDeliveryMethodB
webhook (2/.google.ads.googleads.v6.common.WebhookDeliveryH B
delivery_details"�
WebhookDelivery#
advertiser_webhook_url (	H �
google_secret (	H�#
payload_schema_version (H�B
_advertiser_webhook_urlB
_google_secretB
_payload_schema_version"
BookOnGoogleAssetB�
"com.google.ads.googleads.v6.commonBAssetTypesProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v6/common;common�GAA�Google.Ads.GoogleAds.V6.Common�Google\\Ads\\GoogleAds\\V6\\Common�"Google::Ads::GoogleAds::V6::Commonbproto3'
        , true);
        static::$is_initialized = true;
    }
}

