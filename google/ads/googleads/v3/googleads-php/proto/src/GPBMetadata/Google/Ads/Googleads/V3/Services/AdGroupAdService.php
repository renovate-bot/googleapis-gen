<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v3/services/ad_group_ad_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V3\Services;

class AdGroupAdService
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
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Protobuf\Any::initOnce();
        \GPBMetadata\Google\Rpc\Status::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
Agoogle/ads/googleads/v3/enums/app_url_operating_system_type.protogoogle.ads.googleads.v3.enums"p
AppUrlOperatingSystemTypeEnum"O
AppUrlOperatingSystemType
UNSPECIFIED 
UNKNOWN
IOS
ANDROIDB�
!com.google.ads.googleads.v3.enumsBAppUrlOperatingSystemTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
;google/ads/googleads/v3/enums/served_asset_field_type.protogoogle.ads.googleads.v3.enums"�
ServedAssetFieldTypeEnum"�
ServedAssetFieldType
UNSPECIFIED 
UNKNOWN

HEADLINE_1

HEADLINE_2

HEADLINE_3
DESCRIPTION_1
DESCRIPTION_2B�
!com.google.ads.googleads.v3.enumsBServedAssetFieldTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
-google/ads/googleads/v3/common/ad_asset.protogoogle.ads.googleads.v3.commongoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
AdTextAsset*
text (2.google.protobuf.StringValueb
pinned_field (2L.google.ads.googleads.v3.enums.ServedAssetFieldTypeEnum.ServedAssetFieldType";
AdImageAsset+
asset (2.google.protobuf.StringValue";
AdVideoAsset+
asset (2.google.protobuf.StringValue"A
AdMediaBundleAsset+
asset (2.google.protobuf.StringValueB�
"com.google.ads.googleads.v3.commonBAdAssetProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v3/common;common�GAA�Google.Ads.GoogleAds.V3.Common�Google\\Ads\\GoogleAds\\V3\\Common�"Google::Ads::GoogleAds::V3::Commonbproto3
�
5google/ads/googleads/v3/common/custom_parameter.protogoogle.ads.googleads.v3.commongoogle/api/annotations.proto"i
CustomParameter)
key (2.google.protobuf.StringValue+
value (2.google.protobuf.StringValueB�
"com.google.ads.googleads.v3.commonBCustomParameterProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v3/common;common�GAA�Google.Ads.GoogleAds.V3.Common�Google\\Ads\\GoogleAds\\V3\\Common�"Google::Ads::GoogleAds::V3::Commonbproto3
�
Cgoogle/ads/googleads/v3/enums/call_conversion_reporting_state.protogoogle.ads.googleads.v3.enums"�
 CallConversionReportingStateEnum"�
CallConversionReportingState
UNSPECIFIED 
UNKNOWN
DISABLED,
(USE_ACCOUNT_LEVEL_CALL_CONVERSION_ACTION-
)USE_RESOURCE_LEVEL_CALL_CONVERSION_ACTIONB�
!com.google.ads.googleads.v3.enumsB!CallConversionReportingStateProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
=google/ads/googleads/v3/enums/display_ad_format_setting.protogoogle.ads.googleads.v3.enums"�
DisplayAdFormatSettingEnum"c
DisplayAdFormatSetting
UNSPECIFIED 
UNKNOWN
ALL_FORMATS

NON_NATIVE

NATIVEB�
!com.google.ads.googleads.v3.enumsBDisplayAdFormatSettingProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
?google/ads/googleads/v3/enums/display_upload_product_type.protogoogle.ads.googleads.v3.enums"�
DisplayUploadProductTypeEnum"�
DisplayUploadProductType
UNSPECIFIED 
UNKNOWN
HTML5_UPLOAD_AD
DYNAMIC_HTML5_EDUCATION_AD
DYNAMIC_HTML5_FLIGHT_AD!
DYNAMIC_HTML5_HOTEL_RENTAL_AD
DYNAMIC_HTML5_JOB_AD
DYNAMIC_HTML5_LOCAL_AD 
DYNAMIC_HTML5_REAL_ESTATE_AD
DYNAMIC_HTML5_CUSTOM_AD	
DYNAMIC_HTML5_TRAVEL_AD

DYNAMIC_HTML5_HOTEL_ADB�
!com.google.ads.googleads.v3.enumsBDisplayUploadProductTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
-google/ads/googleads/v3/enums/mime_type.protogoogle.ads.googleads.v3.enums"�
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
!com.google.ads.googleads.v3.enumsBMimeTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
Cgoogle/ads/googleads/v3/enums/legacy_app_install_ad_app_store.protogoogle.ads.googleads.v3.enums"�
LegacyAppInstallAdAppStoreEnum"�
LegacyAppInstallAdAppStore
UNSPECIFIED 
UNKNOWN
APPLE_APP_STORE
GOOGLE_PLAY
WINDOWS_STORE
WINDOWS_PHONE_STORE
CN_APP_STOREB�
!com.google.ads.googleads.v3.enumsBLegacyAppInstallAdAppStoreProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�D
2google/ads/googleads/v3/common/ad_type_infos.protogoogle.ads.googleads.v3.commonCgoogle/ads/googleads/v3/enums/call_conversion_reporting_state.proto=google/ads/googleads/v3/enums/display_ad_format_setting.proto?google/ads/googleads/v3/enums/display_upload_product_type.protoCgoogle/ads/googleads/v3/enums/legacy_app_install_ad_app_store.proto-google/ads/googleads/v3/enums/mime_type.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�

TextAdInfo.
headline (2.google.protobuf.StringValue2
description1 (2.google.protobuf.StringValue2
description2 (2.google.protobuf.StringValue"�
ExpandedTextAdInfo4
headline_part1 (2.google.protobuf.StringValue4
headline_part2 (2.google.protobuf.StringValue4
headline_part3 (2.google.protobuf.StringValue1
description (2.google.protobuf.StringValue2
description2 (2.google.protobuf.StringValue+
path1 (2.google.protobuf.StringValue+
path2 (2.google.protobuf.StringValue"�
CallOnlyAdInfo2
country_code (2.google.protobuf.StringValue2
phone_number (2.google.protobuf.StringValue3
business_name (2.google.protobuf.StringValue/
	headline1 (2.google.protobuf.StringValue/
	headline2 (2.google.protobuf.StringValue2
description1 (2.google.protobuf.StringValue2
description2 (2.google.protobuf.StringValue0
call_tracked (2.google.protobuf.BoolValue;
disable_call_conversion (2.google.protobuf.BoolValueC
phone_number_verification_url (2.google.protobuf.StringValue7
conversion_action	 (2.google.protobuf.StringValue�
conversion_reporting_state
 (2\\.google.ads.googleads.v3.enums.CallConversionReportingStateEnum.CallConversionReportingState"�
ExpandedDynamicSearchAdInfo1
description (2.google.protobuf.StringValue2
description2 (2.google.protobuf.StringValue"
HotelAdInfo"
ShoppingSmartAdInfo"
ShoppingProductAdInfo"Q
ShoppingComparisonListingAdInfo.
headline (2.google.protobuf.StringValue"�
GmailAdInfo;
teaser (2+.google.ads.googleads.v3.common.GmailTeaser2
header_image (2.google.protobuf.StringValue5
marketing_image (2.google.protobuf.StringValue>
marketing_image_headline (2.google.protobuf.StringValueA
marketing_image_description (2.google.protobuf.StringValuec
&marketing_image_display_call_to_action (23.google.ads.googleads.v3.common.DisplayCallToActionD
product_images (2,.google.ads.googleads.v3.common.ProductImageD
product_videos (2,.google.ads.googleads.v3.common.ProductVideo"�
GmailTeaser.
headline (2.google.protobuf.StringValue1
description (2.google.protobuf.StringValue3
business_name (2.google.protobuf.StringValue0

logo_image (2.google.protobuf.StringValue"�
DisplayCallToAction*
text (2.google.protobuf.StringValue0

text_color (2.google.protobuf.StringValue7
url_collection_id (2.google.protobuf.StringValue"�
ProductImage3
product_image (2.google.protobuf.StringValue1
description (2.google.protobuf.StringValueS
display_call_to_action (23.google.ads.googleads.v3.common.DisplayCallToAction"C
ProductVideo3
product_video (2.google.protobuf.StringValue"�
ImageAdInfo0
pixel_width (2.google.protobuf.Int64Value1
pixel_height (2.google.protobuf.Int64Value/
	image_url (2.google.protobuf.StringValue8
preview_pixel_width (2.google.protobuf.Int64Value9
preview_pixel_height (2.google.protobuf.Int64Value7
preview_image_url	 (2.google.protobuf.StringValueG
	mime_type
 (24.google.ads.googleads.v3.enums.MimeTypeEnum.MimeType*
name (2.google.protobuf.StringValue2

media_file (2.google.protobuf.StringValueH +
data (2.google.protobuf.BytesValueH ?
ad_id_to_copy_image_from (2.google.protobuf.Int64ValueH B
image"S
VideoBumperInStreamAdInfo6
companion_banner (2.google.protobuf.StringValue"Y
VideoNonSkippableInStreamAdInfo6
companion_banner (2.google.protobuf.StringValue"�
VideoTrueViewInStreamAdInfo9
action_button_label (2.google.protobuf.StringValue5
action_headline (2.google.protobuf.StringValue6
companion_banner (2.google.protobuf.StringValue"y
VideoOutstreamAdInfo.
headline (2.google.protobuf.StringValue1
description (2.google.protobuf.StringValue"�
VideoTrueViewDiscoveryAdInfo.
headline (2.google.protobuf.StringValue2
description1 (2.google.protobuf.StringValue2
description2 (2.google.protobuf.StringValue"�
VideoAdInfo0

media_file (2.google.protobuf.StringValueP
	in_stream (2;.google.ads.googleads.v3.common.VideoTrueViewInStreamAdInfoH K
bumper (29.google.ads.googleads.v3.common.VideoBumperInStreamAdInfoH J

out_stream (24.google.ads.googleads.v3.common.VideoOutstreamAdInfoH X
non_skippable (2?.google.ads.googleads.v3.common.VideoNonSkippableInStreamAdInfoH Q
	discovery (2<.google.ads.googleads.v3.common.VideoTrueViewDiscoveryAdInfoH B
format"�
ResponsiveSearchAdInfo>
	headlines (2+.google.ads.googleads.v3.common.AdTextAssetA
descriptions (2+.google.ads.googleads.v3.common.AdTextAsset+
path1 (2.google.protobuf.StringValue+
path2 (2.google.protobuf.StringValue"�
LegacyResponsiveDisplayAdInfo4
short_headline (2.google.protobuf.StringValue3
long_headline (2.google.protobuf.StringValue1
description (2.google.protobuf.StringValue3
business_name (2.google.protobuf.StringValue8
allow_flexible_color (2.google.protobuf.BoolValue2
accent_color (2.google.protobuf.StringValue0

main_color (2.google.protobuf.StringValue9
call_to_action_text (2.google.protobuf.StringValue0

logo_image	 (2.google.protobuf.StringValue7
square_logo_image
 (2.google.protobuf.StringValue5
marketing_image (2.google.protobuf.StringValue<
square_marketing_image (2.google.protobuf.StringValueh
format_setting (2P.google.ads.googleads.v3.enums.DisplayAdFormatSettingEnum.DisplayAdFormatSetting2
price_prefix (2.google.protobuf.StringValue0

promo_text (2.google.protobuf.StringValue"�
	AppAdInfoF
mandatory_ad_text (2+.google.ads.googleads.v3.common.AdTextAsset>
	headlines (2+.google.ads.googleads.v3.common.AdTextAssetA
descriptions (2+.google.ads.googleads.v3.common.AdTextAsset<
images (2,.google.ads.googleads.v3.common.AdImageAssetD
youtube_videos (2,.google.ads.googleads.v3.common.AdVideoAssetO
html5_media_bundles (22.google.ads.googleads.v3.common.AdMediaBundleAsset"�
AppEngagementAdInfo>
	headlines (2+.google.ads.googleads.v3.common.AdTextAssetA
descriptions (2+.google.ads.googleads.v3.common.AdTextAsset<
images (2,.google.ads.googleads.v3.common.AdImageAsset<
videos (2,.google.ads.googleads.v3.common.AdVideoAsset"�
LegacyAppInstallAdInfo,
app_id (2.google.protobuf.StringValuek
	app_store (2X.google.ads.googleads.v3.enums.LegacyAppInstallAdAppStoreEnum.LegacyAppInstallAdAppStore.
headline (2.google.protobuf.StringValue2
description1 (2.google.protobuf.StringValue2
description2 (2.google.protobuf.StringValue"�
ResponsiveDisplayAdInfoF
marketing_images (2,.google.ads.googleads.v3.common.AdImageAssetM
square_marketing_images (2,.google.ads.googleads.v3.common.AdImageAssetA
logo_images (2,.google.ads.googleads.v3.common.AdImageAssetH
square_logo_images (2,.google.ads.googleads.v3.common.AdImageAsset>
	headlines (2+.google.ads.googleads.v3.common.AdTextAssetB
long_headline (2+.google.ads.googleads.v3.common.AdTextAssetA
descriptions (2+.google.ads.googleads.v3.common.AdTextAssetD
youtube_videos (2,.google.ads.googleads.v3.common.AdVideoAsset3
business_name	 (2.google.protobuf.StringValue0

main_color
 (2.google.protobuf.StringValue2
accent_color (2.google.protobuf.StringValue8
allow_flexible_color (2.google.protobuf.BoolValue9
call_to_action_text (2.google.protobuf.StringValue2
price_prefix (2.google.protobuf.StringValue0

promo_text (2.google.protobuf.StringValueh
format_setting (2P.google.ads.googleads.v3.enums.DisplayAdFormatSettingEnum.DisplayAdFormatSetting"�
DisplayUploadAdInfoy
display_upload_product_type (2T.google.ads.googleads.v3.enums.DisplayUploadProductTypeEnum.DisplayUploadProductTypeJ
media_bundle (22.google.ads.googleads.v3.common.AdMediaBundleAssetH B
media_assetB�
"com.google.ads.googleads.v3.commonBAdTypeInfosProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v3/common;common�GAA�Google.Ads.GoogleAds.V3.Common�Google\\Ads\\GoogleAds\\V3\\Common�"Google::Ads::GoogleAds::V3::Commonbproto3
�
2google/ads/googleads/v3/common/final_app_url.protogoogle.ads.googleads.v3.commongoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
FinalAppUrlg
os_type (2V.google.ads.googleads.v3.enums.AppUrlOperatingSystemTypeEnum.AppUrlOperatingSystemType)
url (2.google.protobuf.StringValueB�
"com.google.ads.googleads.v3.commonBFinalAppUrlProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v3/common;common�GAA�Google.Ads.GoogleAds.V3.Common�Google\\Ads\\GoogleAds\\V3\\Common�"Google::Ads::GoogleAds::V3::Commonbproto3
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
�
Wgoogle/ads/googleads/v3/enums/policy_topic_evidence_destination_mismatch_url_type.protogoogle.ads.googleads.v3.enums"�
1PolicyTopicEvidenceDestinationMismatchUrlTypeEnum"�
-PolicyTopicEvidenceDestinationMismatchUrlType
UNSPECIFIED 
UNKNOWN
DISPLAY_URL
	FINAL_URL
FINAL_MOBILE_URL
TRACKING_URL
MOBILE_TRACKING_URLB�
!com.google.ads.googleads.v3.enumsB2PolicyTopicEvidenceDestinationMismatchUrlTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
Xgoogle/ads/googleads/v3/enums/policy_topic_evidence_destination_not_working_device.protogoogle.ads.googleads.v3.enums"�
2PolicyTopicEvidenceDestinationNotWorkingDeviceEnum"q
.PolicyTopicEvidenceDestinationNotWorkingDevice
UNSPECIFIED 
UNKNOWN
DESKTOP
ANDROID
IOSB�
!com.google.ads.googleads.v3.enumsB3PolicyTopicEvidenceDestinationNotWorkingDeviceProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
;google/ads/googleads/v3/enums/policy_topic_entry_type.protogoogle.ads.googleads.v3.enums"�
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
!com.google.ads.googleads.v3.enumsBPolicyTopicEntryTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
`google/ads/googleads/v3/enums/policy_topic_evidence_destination_not_working_dns_error_type.protogoogle.ads.googleads.v3.enums"�
8PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum"�
4PolicyTopicEvidenceDestinationNotWorkingDnsErrorType
UNSPECIFIED 
UNKNOWN
HOSTNAME_NOT_FOUND
GOOGLE_CRAWLER_DNS_ISSUEB�
!com.google.ads.googleads.v3.enumsB9PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
+google/ads/googleads/v3/common/policy.protogoogle.ads.googleads.v3.commonWgoogle/ads/googleads/v3/enums/policy_topic_evidence_destination_mismatch_url_type.protoXgoogle/ads/googleads/v3/enums/policy_topic_evidence_destination_not_working_device.proto`google/ads/googleads/v3/enums/policy_topic_evidence_destination_not_working_dns_error_type.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"}
PolicyViolationKey1
policy_name (2.google.protobuf.StringValue4
violating_text (2.google.protobuf.StringValue"�
PolicyValidationParameter=
ignorable_policy_topics (2.google.protobuf.StringValueX
exempt_policy_violation_keys (22.google.ads.googleads.v3.common.PolicyViolationKey"�
PolicyTopicEntry+
topic (2.google.protobuf.StringValueZ
type (2L.google.ads.googleads.v3.enums.PolicyTopicEntryTypeEnum.PolicyTopicEntryTypeF
	evidences (23.google.ads.googleads.v3.common.PolicyTopicEvidenceJ
constraints (25.google.ads.googleads.v3.common.PolicyTopicConstraint"�
PolicyTopicEvidenceW
website_list (2?.google.ads.googleads.v3.common.PolicyTopicEvidence.WebsiteListH Q
	text_list (2<.google.ads.googleads.v3.common.PolicyTopicEvidence.TextListH 5
language_code (2.google.protobuf.StringValueH h
destination_text_list (2G.google.ads.googleads.v3.common.PolicyTopicEvidence.DestinationTextListH g
destination_mismatch (2G.google.ads.googleads.v3.common.PolicyTopicEvidence.DestinationMismatchH l
destination_not_working (2I.google.ads.googleads.v3.common.PolicyTopicEvidence.DestinationNotWorkingH 7
TextList+
texts (2.google.protobuf.StringValue=
WebsiteList.
websites (2.google.protobuf.StringValueN
DestinationTextList7
destination_texts (2.google.protobuf.StringValue�
DestinationMismatch�
	url_types (2~.google.ads.googleads.v3.enums.PolicyTopicEvidenceDestinationMismatchUrlTypeEnum.PolicyTopicEvidenceDestinationMismatchUrlType�
DestinationNotWorking2
expanded_url (2.google.protobuf.StringValue�
device (2�.google.ads.googleads.v3.enums.PolicyTopicEvidenceDestinationNotWorkingDeviceEnum.PolicyTopicEvidenceDestinationNotWorkingDevice<
last_checked_date_time (2.google.protobuf.StringValue�
dns_error_type (2�.google.ads.googleads.v3.enums.PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum.PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeH 6
http_error_code (2.google.protobuf.Int64ValueH B
reasonB
value"�
PolicyTopicConstraintn
country_constraint_list (2K.google.ads.googleads.v3.common.PolicyTopicConstraint.CountryConstraintListH g
reseller_constraint (2H.google.ads.googleads.v3.common.PolicyTopicConstraint.ResellerConstraintH z
#certificate_missing_in_country_list (2K.google.ads.googleads.v3.common.PolicyTopicConstraint.CountryConstraintListH �
+certificate_domain_mismatch_in_country_list (2K.google.ads.googleads.v3.common.PolicyTopicConstraint.CountryConstraintListH �
CountryConstraintList=
total_targeted_countries (2.google.protobuf.Int32ValueZ
	countries (2G.google.ads.googleads.v3.common.PolicyTopicConstraint.CountryConstraint
ResellerConstraintL
CountryConstraint7
country_criterion (2.google.protobuf.StringValueB
valueB�
"com.google.ads.googleads.v3.commonBPolicyProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v3/common;common�GAA�Google.Ads.GoogleAds.V3.Common�Google\\Ads\\GoogleAds\\V3\\Common�"Google::Ads::GoogleAds::V3::Commonbproto3
�
8google/ads/googleads/v3/enums/policy_review_status.protogoogle.ads.googleads.v3.enums"�
PolicyReviewStatusEnum"�
PolicyReviewStatus
UNSPECIFIED 
UNKNOWN
REVIEW_IN_PROGRESS
REVIEWED
UNDER_APPEAL
ELIGIBLE_MAY_SERVEB�
!com.google.ads.googleads.v3.enumsBPolicyReviewStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
3google/ads/googleads/v3/common/url_collection.protogoogle.ads.googleads.v3.commongoogle/api/annotations.proto"�
UrlCollection7
url_collection_id (2.google.protobuf.StringValue0

final_urls (2.google.protobuf.StringValue7
final_mobile_urls (2.google.protobuf.StringValue;
tracking_url_template (2.google.protobuf.StringValueB�
"com.google.ads.googleads.v3.commonBUrlCollectionProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v3/common;common�GAA�Google.Ads.GoogleAds.V3.Common�Google\\Ads\\GoogleAds\\V3\\Common�"Google::Ads::GoogleAds::V3::Commonbproto3
�
6google/ads/googleads/v3/enums/ad_group_ad_status.protogoogle.ads.googleads.v3.enums"l
AdGroupAdStatusEnum"U
AdGroupAdStatus
UNSPECIFIED 
UNKNOWN
ENABLED

PAUSED
REMOVEDB�
!com.google.ads.googleads.v3.enumsBAdGroupAdStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
/google/ads/googleads/v3/enums/ad_strength.protogoogle.ads.googleads.v3.enums"�
AdStrengthEnum"s

AdStrength
UNSPECIFIED 
UNKNOWN
PENDING

NO_ADS
POOR
AVERAGE
GOOD
	EXCELLENTB�
!com.google.ads.googleads.v3.enumsBAdStrengthProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
+google/ads/googleads/v3/enums/ad_type.protogoogle.ads.googleads.v3.enums"�

AdTypeEnum"�
AdType
UNSPECIFIED 
UNKNOWN
TEXT_AD
EXPANDED_TEXT_AD
CALL_ONLY_AD
EXPANDED_DYNAMIC_SEARCH_AD
HOTEL_AD
SHOPPING_SMART_AD	
SHOPPING_PRODUCT_AD

VIDEO_AD
GMAIL_AD
IMAGE_AD
RESPONSIVE_SEARCH_AD 
LEGACY_RESPONSIVE_DISPLAY_AD

APP_AD
LEGACY_APP_INSTALL_AD
RESPONSIVE_DISPLAY_AD
HTML5_UPLOAD_AD
DYNAMIC_HTML5_AD
APP_ENGAGEMENT_AD"
SHOPPING_COMPARISON_LISTING_AD
VIDEO_RESPONSIVE_ADB�
!com.google.ads.googleads.v3.enumsBAdTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
:google/ads/googleads/v3/enums/policy_approval_status.protogoogle.ads.googleads.v3.enums"�
PolicyApprovalStatusEnum"�
PolicyApprovalStatus
UNSPECIFIED 
UNKNOWN
DISAPPROVED
APPROVED_LIMITED
APPROVED
AREA_OF_INTEREST_ONLYB�
!com.google.ads.googleads.v3.enumsBPolicyApprovalStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
@google/ads/googleads/v3/enums/system_managed_entity_source.protogoogle.ads.googleads.v3.enums"q
SystemManagedResourceSourceEnum"N
SystemManagedResourceSource
UNSPECIFIED 
UNKNOWN
AD_VARIATIONSB�
!com.google.ads.googleads.v3.enumsBSystemManagedEntitySourceProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
*google/ads/googleads/v3/resources/ad.proto!google.ads.googleads.v3.resources5google/ads/googleads/v3/common/custom_parameter.proto2google/ads/googleads/v3/common/final_app_url.proto3google/ads/googleads/v3/common/url_collection.proto+google/ads/googleads/v3/enums/ad_type.proto*google/ads/googleads/v3/enums/device.proto@google/ads/googleads/v3/enums/system_managed_entity_source.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
Ad:
resource_name% (	B#�A�A
googleads.googleapis.com/Ad,
id (2.google.protobuf.Int64ValueB�A0

final_urls (2.google.protobuf.StringValueC
final_app_urls# (2+.google.ads.googleads.v3.common.FinalAppUrl7
final_mobile_urls (2.google.protobuf.StringValue;
tracking_url_template (2.google.protobuf.StringValue6
final_url_suffix& (2.google.protobuf.StringValueN
url_custom_parameters
 (2/.google.ads.googleads.v3.common.CustomParameter1
display_url (2.google.protobuf.StringValueC
type (20.google.ads.googleads.v3.enums.AdTypeEnum.AdTypeB�A<
added_by_google_ads (2.google.protobuf.BoolValueB�AK
device_preference (20.google.ads.googleads.v3.enums.DeviceEnum.DeviceF
url_collections (2-.google.ads.googleads.v3.common.UrlCollection/
name (2.google.protobuf.StringValueB�A�
system_managed_resource_source (2Z.google.ads.googleads.v3.enums.SystemManagedResourceSourceEnum.SystemManagedResourceSourceB�AB
text_ad (2*.google.ads.googleads.v3.common.TextAdInfoB�AH N
expanded_text_ad (22.google.ads.googleads.v3.common.ExpandedTextAdInfoH F
call_only_ad (2..google.ads.googleads.v3.common.CallOnlyAdInfoH f
expanded_dynamic_search_ad (2;.google.ads.googleads.v3.common.ExpandedDynamicSearchAdInfoB�AH ?
hotel_ad (2+.google.ads.googleads.v3.common.HotelAdInfoH P
shopping_smart_ad (23.google.ads.googleads.v3.common.ShoppingSmartAdInfoH T
shopping_product_ad (25.google.ads.googleads.v3.common.ShoppingProductAdInfoH D
gmail_ad (2+.google.ads.googleads.v3.common.GmailAdInfoB�AH D
image_ad (2+.google.ads.googleads.v3.common.ImageAdInfoB�AH ?
video_ad (2+.google.ads.googleads.v3.common.VideoAdInfoH V
responsive_search_ad (26.google.ads.googleads.v3.common.ResponsiveSearchAdInfoH e
legacy_responsive_display_ad (2=.google.ads.googleads.v3.common.LegacyResponsiveDisplayAdInfoH ;
app_ad (2).google.ads.googleads.v3.common.AppAdInfoH \\
legacy_app_install_ad (26.google.ads.googleads.v3.common.LegacyAppInstallAdInfoB�AH X
responsive_display_ad (27.google.ads.googleads.v3.common.ResponsiveDisplayAdInfoH P
display_upload_ad! (23.google.ads.googleads.v3.common.DisplayUploadAdInfoH P
app_engagement_ad" (23.google.ads.googleads.v3.common.AppEngagementAdInfoH i
shopping_comparison_listing_ad$ (2?.google.ads.googleads.v3.common.ShoppingComparisonListingAdInfoH :?�A<
googleads.googleapis.com/Adcustomers/{customer}/ads/{ad}B	
ad_dataB�
%com.google.ads.googleads.v3.resourcesBAdProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v3/resources;resources�GAA�!Google.Ads.GoogleAds.V3.Resources�!Google\\Ads\\GoogleAds\\V3\\Resources�%Google::Ads::GoogleAds::V3::Resourcesbproto3
�
3google/ads/googleads/v3/resources/ad_group_ad.proto!google.ads.googleads.v3.resources6google/ads/googleads/v3/enums/ad_group_ad_status.proto/google/ads/googleads/v3/enums/ad_strength.proto:google/ads/googleads/v3/enums/policy_approval_status.proto8google/ads/googleads/v3/enums/policy_review_status.proto*google/ads/googleads/v3/resources/ad.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
	AdGroupAdA
resource_name (	B*�A�A$
"googleads.googleapis.com/AdGroupAdR
status (2B.google.ads.googleads.v3.enums.AdGroupAdStatusEnum.AdGroupAdStatusX
ad_group (2.google.protobuf.StringValueB(�A�A"
 googleads.googleapis.com/AdGroup6
ad (2%.google.ads.googleads.v3.resources.AdB�AV
policy_summary (29.google.ads.googleads.v3.resources.AdGroupAdPolicySummaryB�AR
ad_strength (28.google.ads.googleads.v3.enums.AdStrengthEnum.AdStrengthB�A:V�AS
"googleads.googleapis.com/AdGroupAd-customers/{customer}/adGroupAds/{ad_group_ad}"�
AdGroupAdPolicySummaryS
policy_topic_entries (20.google.ads.googleads.v3.common.PolicyTopicEntryB�Ad
review_status (2H.google.ads.googleads.v3.enums.PolicyReviewStatusEnum.PolicyReviewStatusB�Aj
approval_status (2L.google.ads.googleads.v3.enums.PolicyApprovalStatusEnum.PolicyApprovalStatusB�AB�
%com.google.ads.googleads.v3.resourcesBAdGroupAdProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v3/resources;resources�GAA�!Google.Ads.GoogleAds.V3.Resources�!Google\\Ads\\GoogleAds\\V3\\Resources�%Google::Ads::GoogleAds::V3::Resourcesbproto3
�
:google/ads/googleads/v3/services/ad_group_ad_service.proto google.ads.googleads.v3.services3google/ads/googleads/v3/resources/ad_group_ad.protogoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto google/protobuf/field_mask.protogoogle/rpc/status.proto"X
GetAdGroupAdRequestA
resource_name (	B*�A�A$
"googleads.googleapis.com/AdGroupAd"�
MutateAdGroupAdsRequest
customer_id (	B�AM

operations (24.google.ads.googleads.v3.services.AdGroupAdOperationB�A
partial_failure (
validate_only ("�
AdGroupAdOperation/
update_mask (2.google.protobuf.FieldMask^
policy_validation_parameter (29.google.ads.googleads.v3.common.PolicyValidationParameter>
create (2,.google.ads.googleads.v3.resources.AdGroupAdH >
update (2,.google.ads.googleads.v3.resources.AdGroupAdH 
remove (	H B
	operation"�
MutateAdGroupAdsResponse1
partial_failure_error (2.google.rpc.StatusH
results (27.google.ads.googleads.v3.services.MutateAdGroupAdResult".
MutateAdGroupAdResult
resource_name (	2�
AdGroupAdService�
GetAdGroupAd5.google.ads.googleads.v3.services.GetAdGroupAdRequest,.google.ads.googleads.v3.resources.AdGroupAd"D���.,/v3/{resource_name=customers/*/adGroupAds/*}�Aresource_name�
MutateAdGroupAds9.google.ads.googleads.v3.services.MutateAdGroupAdsRequest:.google.ads.googleads.v3.services.MutateAdGroupAdsResponse"S���4"//v3/customers/{customer_id=*}/adGroupAds:mutate:*�Acustomer_id,operationsE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v3.servicesBAdGroupAdServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v3/services;services�GAA� Google.Ads.GoogleAds.V3.Services� Google\\Ads\\GoogleAds\\V3\\Services�$Google::Ads::GoogleAds::V3::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

