<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v6/services/conversion_action_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V6\Services;

class ConversionActionService
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
�
6google/ads/googleads/v6/enums/tracking_code_type.protogoogle.ads.googleads.v6.enums"�
TrackingCodeTypeEnum"w
TrackingCodeType
UNSPECIFIED 
UNKNOWN
WEBPAGE
WEBPAGE_ONCLICK
CLICK_TO_CALL
WEBSITE_CALLB�
!com.google.ads.googleads.v6.enumsBTrackingCodeTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
=google/ads/googleads/v6/enums/tracking_code_page_format.protogoogle.ads.googleads.v6.enums"g
TrackingCodePageFormatEnum"I
TrackingCodePageFormat
UNSPECIFIED 
UNKNOWN
HTML
AMPB�
!com.google.ads.googleads.v6.enumsBTrackingCodePageFormatProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
>google/ads/googleads/v6/enums/conversion_action_category.protogoogle.ads.googleads.v6.enums"�
ConversionActionCategoryEnum"�
ConversionActionCategory
UNSPECIFIED 
UNKNOWN
DEFAULT
	PAGE_VIEW
PURCHASE

SIGNUP
LEAD
DOWNLOAD
ADD_TO_CART
BEGIN_CHECKOUT	
SUBSCRIBE_PAID

PHONE_CALL_LEAD
IMPORTED_LEAD
SUBMIT_LEAD_FORM
BOOK_APPOINTMENT
REQUEST_QUOTE
GET_DIRECTIONS
OUTBOUND_CLICK
CONTACT

ENGAGEMENT
STORE_VISIT

STORE_SALEB�
!com.google.ads.googleads.v6.enumsBConversionActionCategoryProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
0google/ads/googleads/v6/common/tag_snippet.protogoogle.ads.googleads.v6.common6google/ads/googleads/v6/enums/tracking_code_type.protogoogle/api/annotations.proto"�

TagSnippetR
type (2D.google.ads.googleads.v6.enums.TrackingCodeTypeEnum.TrackingCodeTypee
page_format (2P.google.ads.googleads.v6.enums.TrackingCodePageFormatEnum.TrackingCodePageFormat
global_site_tag (	H �
event_snippet (	H�B
_global_site_tagB
_event_snippetB�
"com.google.ads.googleads.v6.commonBTagSnippetProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v6/common;common�GAA�Google.Ads.GoogleAds.V6.Common�Google\\Ads\\GoogleAds\\V6\\Common�"Google::Ads::GoogleAds::V6::Commonbproto3
�
5google/ads/googleads/v6/enums/attribution_model.protogoogle.ads.googleads.v6.enums"�
AttributionModelEnum"�
AttributionModel
UNSPECIFIED 
UNKNOWN
EXTERNALd
GOOGLE_ADS_LAST_CLICKe)
%GOOGLE_SEARCH_ATTRIBUTION_FIRST_CLICKf$
 GOOGLE_SEARCH_ATTRIBUTION_LINEARg(
$GOOGLE_SEARCH_ATTRIBUTION_TIME_DECAYh,
(GOOGLE_SEARCH_ATTRIBUTION_POSITION_BASEDi)
%GOOGLE_SEARCH_ATTRIBUTION_DATA_DRIVENjB�
!com.google.ads.googleads.v6.enumsBAttributionModelProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
Cgoogle/ads/googleads/v6/enums/conversion_action_counting_type.protogoogle.ads.googleads.v6.enums"�
 ConversionActionCountingTypeEnum"c
ConversionActionCountingType
UNSPECIFIED 
UNKNOWN
ONE_PER_CLICK
MANY_PER_CLICKB�
!com.google.ads.googleads.v6.enumsB!ConversionActionCountingTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
<google/ads/googleads/v6/enums/conversion_action_status.protogoogle.ads.googleads.v6.enums"z
ConversionActionStatusEnum"\\
ConversionActionStatus
UNSPECIFIED 
UNKNOWN
ENABLED
REMOVED

HIDDENB�
!com.google.ads.googleads.v6.enumsBConversionActionStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
:google/ads/googleads/v6/enums/conversion_action_type.protogoogle.ads.googleads.v6.enums"�
ConversionActionTypeEnum"�
ConversionActionType
UNSPECIFIED 
UNKNOWN
AD_CALL
CLICK_TO_CALL
GOOGLE_PLAY_DOWNLOAD
GOOGLE_PLAY_IN_APP_PURCHASE
UPLOAD_CALLS
UPLOAD_CLICKS
WEBPAGE
WEBSITE_CALL	
STORE_SALES_DIRECT_UPLOAD

STORE_SALES
FIREBASE_ANDROID_FIRST_OPEN$
 FIREBASE_ANDROID_IN_APP_PURCHASE
FIREBASE_ANDROID_CUSTOM
FIREBASE_IOS_FIRST_OPEN 
FIREBASE_IOS_IN_APP_PURCHASE
FIREBASE_IOS_CUSTOM0
,THIRD_PARTY_APP_ANALYTICS_ANDROID_FIRST_OPEN5
1THIRD_PARTY_APP_ANALYTICS_ANDROID_IN_APP_PURCHASE,
(THIRD_PARTY_APP_ANALYTICS_ANDROID_CUSTOM,
(THIRD_PARTY_APP_ANALYTICS_IOS_FIRST_OPEN1
-THIRD_PARTY_APP_ANALYTICS_IOS_IN_APP_PURCHASE(
$THIRD_PARTY_APP_ANALYTICS_IOS_CUSTOM 
ANDROID_APP_PRE_REGISTRATION#
ANDROID_INSTALLS_ALL_OTHER_APPS
FLOODLIGHT_ACTION
FLOODLIGHT_TRANSACTION
GOOGLE_HOSTED
LEAD_FORM_SUBMIT

SALESFORCE
SEARCH_ADS_360$
 SMART_CAMPAIGN_AD_CLICKS_TO_CALL %
!SMART_CAMPAIGN_MAP_CLICKS_TO_CALL!!
SMART_CAMPAIGN_MAP_DIRECTIONS" 
SMART_CAMPAIGN_TRACKED_CALLS#
STORE_VISITS$B�
!com.google.ads.googleads.v6.enumsBConversionActionTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
<google/ads/googleads/v6/enums/data_driven_model_status.protogoogle.ads.googleads.v6.enums"�
DataDrivenModelStatusEnum"q
DataDrivenModelStatus
UNSPECIFIED 
UNKNOWN
	AVAILABLE	
STALE
EXPIRED
NEVER_GENERATEDB�
!com.google.ads.googleads.v6.enumsBDataDrivenModelStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
5google/ads/googleads/v6/enums/mobile_app_vendor.protogoogle.ads.googleads.v6.enums"q
MobileAppVendorEnum"Z
MobileAppVendor
UNSPECIFIED 
UNKNOWN
APPLE_APP_STORE
GOOGLE_APP_STOREB�
!com.google.ads.googleads.v6.enumsBMobileAppVendorProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
9google/ads/googleads/v6/resources/conversion_action.proto!google.ads.googleads.v6.resources5google/ads/googleads/v6/enums/attribution_model.proto>google/ads/googleads/v6/enums/conversion_action_category.protoCgoogle/ads/googleads/v6/enums/conversion_action_counting_type.proto<google/ads/googleads/v6/enums/conversion_action_status.proto:google/ads/googleads/v6/enums/conversion_action_type.proto<google/ads/googleads/v6/enums/data_driven_model_status.proto5google/ads/googleads/v6/enums/mobile_app_vendor.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/api/annotations.proto"�
ConversionActionH
resource_name (	B1�A�A+
)googleads.googleapis.com/ConversionAction
id (B�AH �
name (	H�`
status (2P.google.ads.googleads.v6.enums.ConversionActionStatusEnum.ConversionActionStatus_
type (2L.google.ads.googleads.v6.enums.ConversionActionTypeEnum.ConversionActionTypeB�Af
category (2T.google.ads.googleads.v6.enums.ConversionActionCategoryEnum.ConversionActionCategory 
owner_customer (	B�AH�*
include_in_conversions_metric (H�/
"click_through_lookback_window_days (H�.
!view_through_lookback_window_days (H�Y
value_settings (2A.google.ads.googleads.v6.resources.ConversionAction.ValueSettingss
counting_type (2\\.google.ads.googleads.v6.enums.ConversionActionCountingTypeEnum.ConversionActionCountingTypep
attribution_model_settings (2L.google.ads.googleads.v6.resources.ConversionAction.AttributionModelSettingsE
tag_snippets (2*.google.ads.googleads.v6.common.TagSnippetB�A(
phone_call_duration_seconds (H�
app_id (	H�b
mobile_app_vendor (2B.google.ads.googleads.v6.enums.MobileAppVendorEnum.MobileAppVendorB�Ad
firebase_settings (2D.google.ads.googleads.v6.resources.ConversionAction.FirebaseSettingsB�A�
"third_party_app_analytics_settings (2R.google.ads.googleads.v6.resources.ConversionAction.ThirdPartyAppAnalyticsSettingsB�A�
AttributionModelSettings_
attribution_model (2D.google.ads.googleads.v6.enums.AttributionModelEnum.AttributionModelu
data_driven_model_status (2N.google.ads.googleads.v6.enums.DataDrivenModelStatusEnum.DataDrivenModelStatusB�A�
ValueSettings
default_value (H �"
default_currency_code (	H�%
always_use_default_value (H�B
_default_valueB
_default_currency_codeB
_always_use_default_valueM
ThirdPartyAppAnalyticsSettings

event_name (	B�AH �B
_event_namel
FirebaseSettings

event_name (	B�AH �

project_id (	B�AH�B
_event_nameB
_project_id:p�Am
)googleads.googleapis.com/ConversionAction@customers/{customer_id}/conversionActions/{conversion_action_id}B
_idB
_nameB
_owner_customerB 
_include_in_conversions_metricB%
#_click_through_lookback_window_daysB$
"_view_through_lookback_window_daysB
_phone_call_duration_secondsB	
_app_idB�
%com.google.ads.googleads.v6.resourcesBConversionActionProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v6/resources;resources�GAA�!Google.Ads.GoogleAds.V6.Resources�!Google\\Ads\\GoogleAds\\V6\\Resources�%Google::Ads::GoogleAds::V6::Resourcesbproto3
�
@google/ads/googleads/v6/services/conversion_action_service.proto google.ads.googleads.v6.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto google/protobuf/field_mask.protogoogle/rpc/status.proto"f
GetConversionActionRequestH
resource_name (	B1�A�A+
)googleads.googleapis.com/ConversionAction"�
MutateConversionActionsRequest
customer_id (	B�AT

operations (2;.google.ads.googleads.v6.services.ConversionActionOperationB�A
partial_failure (
validate_only ("�
ConversionActionOperation/
update_mask (2.google.protobuf.FieldMaskE
create (23.google.ads.googleads.v6.resources.ConversionActionH E
update (23.google.ads.googleads.v6.resources.ConversionActionH 
remove (	H B
	operation"�
MutateConversionActionsResponse1
partial_failure_error (2.google.rpc.StatusO
results (2>.google.ads.googleads.v6.services.MutateConversionActionResult"5
MutateConversionActionResult
resource_name (	2�
ConversionActionService�
GetConversionAction<.google.ads.googleads.v6.services.GetConversionActionRequest3.google.ads.googleads.v6.resources.ConversionAction"K���53/v6/{resource_name=customers/*/conversionActions/*}�Aresource_name�
MutateConversionActions@.google.ads.googleads.v6.services.MutateConversionActionsRequestA.google.ads.googleads.v6.services.MutateConversionActionsResponse"Z���;"6/v6/customers/{customer_id=*}/conversionActions:mutate:*�Acustomer_id,operationsE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v6.servicesBConversionActionServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v6/services;services�GAA� Google.Ads.GoogleAds.V6.Services� Google\\Ads\\GoogleAds\\V6\\Services�$Google::Ads::GoogleAds::V6::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

