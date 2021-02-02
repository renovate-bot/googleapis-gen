<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v6/services/asset_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V6\Services;

class AssetService
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
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
Xgoogle/ads/googleads/v6/enums/policy_topic_evidence_destination_not_working_device.protogoogle.ads.googleads.v6.enums"�
2PolicyTopicEvidenceDestinationNotWorkingDeviceEnum"q
.PolicyTopicEvidenceDestinationNotWorkingDevice
UNSPECIFIED 
UNKNOWN
DESKTOP
ANDROID
IOSB�
!com.google.ads.googleads.v6.enumsB3PolicyTopicEvidenceDestinationNotWorkingDeviceProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
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
;google/ads/googleads/v6/enums/policy_topic_entry_type.protogoogle.ads.googleads.v6.enums"�
PolicyTopicEntryTypeEnum"�
PolicyTopicEntryType
UNSPECIFIED 
UNKNOWN

PROHIBITED
LIMITED
FULLY_LIMITED
DESCRIPTIVE

BROADENING
AREA_OF_INTEREST_ONLYB�
!com.google.ads.googleads.v6.enumsBPolicyTopicEntryTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
:google/ads/googleads/v6/enums/policy_approval_status.protogoogle.ads.googleads.v6.enums"�
PolicyApprovalStatusEnum"�
PolicyApprovalStatus
UNSPECIFIED 
UNKNOWN
DISAPPROVED
APPROVED_LIMITED
APPROVED
AREA_OF_INTEREST_ONLYB�
!com.google.ads.googleads.v6.enumsBPolicyApprovalStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
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
�
8google/ads/googleads/v6/enums/policy_review_status.protogoogle.ads.googleads.v6.enums"�
PolicyReviewStatusEnum"�
PolicyReviewStatus
UNSPECIFIED 
UNKNOWN
REVIEW_IN_PROGRESS
REVIEWED
UNDER_APPEAL
ELIGIBLE_MAY_SERVEB�
!com.google.ads.googleads.v6.enumsBPolicyReviewStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
`google/ads/googleads/v6/enums/policy_topic_evidence_destination_not_working_dns_error_type.protogoogle.ads.googleads.v6.enums"�
8PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum"�
4PolicyTopicEvidenceDestinationNotWorkingDnsErrorType
UNSPECIFIED 
UNKNOWN
HOSTNAME_NOT_FOUND
GOOGLE_CRAWLER_DNS_ISSUEB�
!com.google.ads.googleads.v6.enumsB9PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
Wgoogle/ads/googleads/v6/enums/policy_topic_evidence_destination_mismatch_url_type.protogoogle.ads.googleads.v6.enums"�
1PolicyTopicEvidenceDestinationMismatchUrlTypeEnum"�
-PolicyTopicEvidenceDestinationMismatchUrlType
UNSPECIFIED 
UNKNOWN
DISPLAY_URL
	FINAL_URL
FINAL_MOBILE_URL
TRACKING_URL
MOBILE_TRACKING_URLB�
!com.google.ads.googleads.v6.enumsB2PolicyTopicEvidenceDestinationMismatchUrlTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
+google/ads/googleads/v6/common/policy.protogoogle.ads.googleads.v6.commonWgoogle/ads/googleads/v6/enums/policy_topic_evidence_destination_mismatch_url_type.protoXgoogle/ads/googleads/v6/enums/policy_topic_evidence_destination_not_working_device.proto`google/ads/googleads/v6/enums/policy_topic_evidence_destination_not_working_dns_error_type.protogoogle/api/annotations.proto"n
PolicyViolationKey
policy_name (	H �
violating_text (	H�B
_policy_nameB
_violating_text"�
PolicyValidationParameter
ignorable_policy_topics (	X
exempt_policy_violation_keys (22.google.ads.googleads.v6.common.PolicyViolationKey"�
PolicyTopicEntry
topic (	H �Z
type (2L.google.ads.googleads.v6.enums.PolicyTopicEntryTypeEnum.PolicyTopicEntryTypeF
	evidences (23.google.ads.googleads.v6.common.PolicyTopicEvidenceJ
constraints (25.google.ads.googleads.v6.common.PolicyTopicConstraintB
_topic"�

PolicyTopicEvidenceW
website_list (2?.google.ads.googleads.v6.common.PolicyTopicEvidence.WebsiteListH Q
	text_list (2<.google.ads.googleads.v6.common.PolicyTopicEvidence.TextListH 
language_code	 (	H h
destination_text_list (2G.google.ads.googleads.v6.common.PolicyTopicEvidence.DestinationTextListH g
destination_mismatch (2G.google.ads.googleads.v6.common.PolicyTopicEvidence.DestinationMismatchH l
destination_not_working (2I.google.ads.googleads.v6.common.PolicyTopicEvidence.DestinationNotWorkingH 
TextList
texts (	
WebsiteList
websites (	0
DestinationTextList
destination_texts (	�
DestinationMismatch�
	url_types (2~.google.ads.googleads.v6.enums.PolicyTopicEvidenceDestinationMismatchUrlTypeEnum.PolicyTopicEvidenceDestinationMismatchUrlType�
DestinationNotWorking
expanded_url (	H��
device (2�.google.ads.googleads.v6.enums.PolicyTopicEvidenceDestinationNotWorkingDeviceEnum.PolicyTopicEvidenceDestinationNotWorkingDevice#
last_checked_date_time (	H��
dns_error_type (2�.google.ads.googleads.v6.enums.PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum.PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeH 
http_error_code (H B
reasonB
_expanded_urlB
_last_checked_date_timeB
value"�
PolicyTopicConstraintn
country_constraint_list (2K.google.ads.googleads.v6.common.PolicyTopicConstraint.CountryConstraintListH g
reseller_constraint (2H.google.ads.googleads.v6.common.PolicyTopicConstraint.ResellerConstraintH z
#certificate_missing_in_country_list (2K.google.ads.googleads.v6.common.PolicyTopicConstraint.CountryConstraintListH �
+certificate_domain_mismatch_in_country_list (2K.google.ads.googleads.v6.common.PolicyTopicConstraint.CountryConstraintListH �
CountryConstraintList%
total_targeted_countries (H �Z
	countries (2G.google.ads.googleads.v6.common.PolicyTopicConstraint.CountryConstraintB
_total_targeted_countries
ResellerConstraintI
CountryConstraint
country_criterion (	H �B
_country_criterionB
valueB�
"com.google.ads.googleads.v6.commonBPolicyProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v6/common;common�GAA�Google.Ads.GoogleAds.V6.Common�Google\\Ads\\GoogleAds\\V6\\Common�"Google::Ads::GoogleAds::V6::Commonbproto3
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
"com.google.ads.googleads.v6.commonBAssetTypesProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v6/common;common�GAA�Google.Ads.GoogleAds.V6.Common�Google\\Ads\\GoogleAds\\V6\\Common�"Google::Ads::GoogleAds::V6::Commonbproto3
�
.google/ads/googleads/v6/enums/asset_type.protogoogle.ads.googleads.v6.enums"�
AssetTypeEnum"�
	AssetType
UNSPECIFIED 
UNKNOWN
YOUTUBE_VIDEO
MEDIA_BUNDLE	
IMAGE
TEXT
	LEAD_FORM
BOOK_ON_GOOGLEB�
!com.google.ads.googleads.v6.enumsBAssetTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
9google/ads/googleads/v6/enums/response_content_type.protogoogle.ads.googleads.v6.enums"o
ResponseContentTypeEnum"T
ResponseContentType
UNSPECIFIED 
RESOURCE_NAME_ONLY
MUTABLE_RESOURCEB�
!com.google.ads.googleads.v6.enumsBResponseContentTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
-google/ads/googleads/v6/resources/asset.proto!google.ads.googleads.v6.resources+google/ads/googleads/v6/common/policy.proto.google/ads/googleads/v6/enums/asset_type.proto:google/ads/googleads/v6/enums/policy_approval_status.proto8google/ads/googleads/v6/enums/policy_review_status.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/api/annotations.proto"�
Asset=
resource_name (	B&�A�A 
googleads.googleapis.com/Asset
id (B�AH�
name (	H�I
type (26.google.ads.googleads.v6.enums.AssetTypeEnum.AssetTypeB�A

final_urls (	R
policy_summary (25.google.ads.googleads.v6.resources.AssetPolicySummaryB�AU
youtube_video_asset (21.google.ads.googleads.v6.common.YoutubeVideoAssetB�AH S
media_bundle_asset (20.google.ads.googleads.v6.common.MediaBundleAssetB�AH F
image_asset (2*.google.ads.googleads.v6.common.ImageAssetB�AH D

text_asset (2).google.ads.googleads.v6.common.TextAssetB�AH H
lead_form_asset	 (2-.google.ads.googleads.v6.common.LeadFormAssetH Q
book_on_google_asset
 (21.google.ads.googleads.v6.common.BookOnGoogleAssetH :N�AK
googleads.googleapis.com/Asset)customers/{customer_id}/assets/{asset_id}B

asset_dataB
_idB
_name"�
AssetPolicySummaryS
policy_topic_entries (20.google.ads.googleads.v6.common.PolicyTopicEntryB�Ad
review_status (2H.google.ads.googleads.v6.enums.PolicyReviewStatusEnum.PolicyReviewStatusB�Aj
approval_status (2L.google.ads.googleads.v6.enums.PolicyApprovalStatusEnum.PolicyApprovalStatusB�AB�
%com.google.ads.googleads.v6.resourcesB
AssetProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v6/resources;resources�GAA�!Google.Ads.GoogleAds.V6.Resources�!Google\\Ads\\GoogleAds\\V6\\Resources�%Google::Ads::GoogleAds::V6::Resourcesbproto3
�
4google/ads/googleads/v6/services/asset_service.proto google.ads.googleads.v6.services-google/ads/googleads/v6/resources/asset.protogoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto google/protobuf/field_mask.proto"P
GetAssetRequest=
resource_name (	B&�A�A 
googleads.googleapis.com/Asset"�
MutateAssetsRequest
customer_id (	B�AI

operations (20.google.ads.googleads.v6.services.AssetOperationB�Ai
response_content_type (2J.google.ads.googleads.v6.enums.ResponseContentTypeEnum.ResponseContentType"�
AssetOperation/
update_mask (2.google.protobuf.FieldMask:
create (2(.google.ads.googleads.v6.resources.AssetH :
update (2(.google.ads.googleads.v6.resources.AssetH B
	operation"\\
MutateAssetsResponseD
results (23.google.ads.googleads.v6.services.MutateAssetResult"c
MutateAssetResult
resource_name (	7
asset (2(.google.ads.googleads.v6.resources.Asset2�
AssetService�
GetAsset1.google.ads.googleads.v6.services.GetAssetRequest(.google.ads.googleads.v6.resources.Asset"@���*(/v6/{resource_name=customers/*/assets/*}�Aresource_name�
MutateAssets5.google.ads.googleads.v6.services.MutateAssetsRequest6.google.ads.googleads.v6.services.MutateAssetsResponse"O���0"+/v6/customers/{customer_id=*}/assets:mutate:*�Acustomer_id,operationsE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v6.servicesBAssetServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v6/services;services�GAA� Google.Ads.GoogleAds.V6.Services� Google\\Ads\\GoogleAds\\V6\\Services�$Google::Ads::GoogleAds::V6::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

