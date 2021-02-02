<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v4/services/ad_group_ad_asset_view_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V4\Services;

class AdGroupAdAssetViewService
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
        $pool->internalAddGeneratedFile(
            '
�
`google/ads/googleads/v4/enums/policy_topic_evidence_destination_not_working_dns_error_type.protogoogle.ads.googleads.v4.enums"�
8PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum"�
4PolicyTopicEvidenceDestinationNotWorkingDnsErrorType
UNSPECIFIED 
UNKNOWN
HOSTNAME_NOT_FOUND
GOOGLE_CRAWLER_DNS_ISSUEB�
!com.google.ads.googleads.v4.enumsB9PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v4/enums;enums�GAA�Google.Ads.GoogleAds.V4.Enums�Google\\Ads\\GoogleAds\\V4\\Enums�!Google::Ads::GoogleAds::V4::Enumsbproto3
�
Wgoogle/ads/googleads/v4/enums/policy_topic_evidence_destination_mismatch_url_type.protogoogle.ads.googleads.v4.enums"�
1PolicyTopicEvidenceDestinationMismatchUrlTypeEnum"�
-PolicyTopicEvidenceDestinationMismatchUrlType
UNSPECIFIED 
UNKNOWN
DISPLAY_URL
	FINAL_URL
FINAL_MOBILE_URL
TRACKING_URL
MOBILE_TRACKING_URLB�
!com.google.ads.googleads.v4.enumsB2PolicyTopicEvidenceDestinationMismatchUrlTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v4/enums;enums�GAA�Google.Ads.GoogleAds.V4.Enums�Google\\Ads\\GoogleAds\\V4\\Enums�!Google::Ads::GoogleAds::V4::Enumsbproto3
�
;google/ads/googleads/v4/enums/policy_topic_entry_type.protogoogle.ads.googleads.v4.enums"�
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
!com.google.ads.googleads.v4.enumsBPolicyTopicEntryTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v4/enums;enums�GAA�Google.Ads.GoogleAds.V4.Enums�Google\\Ads\\GoogleAds\\V4\\Enums�!Google::Ads::GoogleAds::V4::Enumsbproto3
�
Xgoogle/ads/googleads/v4/enums/policy_topic_evidence_destination_not_working_device.protogoogle.ads.googleads.v4.enums"�
2PolicyTopicEvidenceDestinationNotWorkingDeviceEnum"q
.PolicyTopicEvidenceDestinationNotWorkingDevice
UNSPECIFIED 
UNKNOWN
DESKTOP
ANDROID
IOSB�
!com.google.ads.googleads.v4.enumsB3PolicyTopicEvidenceDestinationNotWorkingDeviceProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v4/enums;enums�GAA�Google.Ads.GoogleAds.V4.Enums�Google\\Ads\\GoogleAds\\V4\\Enums�!Google::Ads::GoogleAds::V4::Enumsbproto3
�
+google/ads/googleads/v4/common/policy.protogoogle.ads.googleads.v4.commonWgoogle/ads/googleads/v4/enums/policy_topic_evidence_destination_mismatch_url_type.protoXgoogle/ads/googleads/v4/enums/policy_topic_evidence_destination_not_working_device.proto`google/ads/googleads/v4/enums/policy_topic_evidence_destination_not_working_dns_error_type.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"}
PolicyViolationKey1
policy_name (2.google.protobuf.StringValue4
violating_text (2.google.protobuf.StringValue"�
PolicyValidationParameter=
ignorable_policy_topics (2.google.protobuf.StringValueX
exempt_policy_violation_keys (22.google.ads.googleads.v4.common.PolicyViolationKey"�
PolicyTopicEntry+
topic (2.google.protobuf.StringValueZ
type (2L.google.ads.googleads.v4.enums.PolicyTopicEntryTypeEnum.PolicyTopicEntryTypeF
	evidences (23.google.ads.googleads.v4.common.PolicyTopicEvidenceJ
constraints (25.google.ads.googleads.v4.common.PolicyTopicConstraint"�
PolicyTopicEvidenceW
website_list (2?.google.ads.googleads.v4.common.PolicyTopicEvidence.WebsiteListH Q
	text_list (2<.google.ads.googleads.v4.common.PolicyTopicEvidence.TextListH 5
language_code (2.google.protobuf.StringValueH h
destination_text_list (2G.google.ads.googleads.v4.common.PolicyTopicEvidence.DestinationTextListH g
destination_mismatch (2G.google.ads.googleads.v4.common.PolicyTopicEvidence.DestinationMismatchH l
destination_not_working (2I.google.ads.googleads.v4.common.PolicyTopicEvidence.DestinationNotWorkingH 7
TextList+
texts (2.google.protobuf.StringValue=
WebsiteList.
websites (2.google.protobuf.StringValueN
DestinationTextList7
destination_texts (2.google.protobuf.StringValue�
DestinationMismatch�
	url_types (2~.google.ads.googleads.v4.enums.PolicyTopicEvidenceDestinationMismatchUrlTypeEnum.PolicyTopicEvidenceDestinationMismatchUrlType�
DestinationNotWorking2
expanded_url (2.google.protobuf.StringValue�
device (2�.google.ads.googleads.v4.enums.PolicyTopicEvidenceDestinationNotWorkingDeviceEnum.PolicyTopicEvidenceDestinationNotWorkingDevice<
last_checked_date_time (2.google.protobuf.StringValue�
dns_error_type (2�.google.ads.googleads.v4.enums.PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum.PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeH 6
http_error_code (2.google.protobuf.Int64ValueH B
reasonB
value"�
PolicyTopicConstraintn
country_constraint_list (2K.google.ads.googleads.v4.common.PolicyTopicConstraint.CountryConstraintListH g
reseller_constraint (2H.google.ads.googleads.v4.common.PolicyTopicConstraint.ResellerConstraintH z
#certificate_missing_in_country_list (2K.google.ads.googleads.v4.common.PolicyTopicConstraint.CountryConstraintListH �
+certificate_domain_mismatch_in_country_list (2K.google.ads.googleads.v4.common.PolicyTopicConstraint.CountryConstraintListH �
CountryConstraintList=
total_targeted_countries (2.google.protobuf.Int32ValueZ
	countries (2G.google.ads.googleads.v4.common.PolicyTopicConstraint.CountryConstraint
ResellerConstraintL
CountryConstraint7
country_criterion (2.google.protobuf.StringValueB
valueB�
"com.google.ads.googleads.v4.commonBPolicyProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v4/common;common�GAA�Google.Ads.GoogleAds.V4.Common�Google\\Ads\\GoogleAds\\V4\\Common�"Google::Ads::GoogleAds::V4::Commonbproto3
�
4google/ads/googleads/v4/enums/asset_field_type.protogoogle.ads.googleads.v4.enums"�
AssetFieldTypeEnum"�
AssetFieldType
UNSPECIFIED 
UNKNOWN
HEADLINE
DESCRIPTION
MANDATORY_AD_TEXT
MARKETING_IMAGE
MEDIA_BUNDLE
YOUTUBE_VIDEOB�
!com.google.ads.googleads.v4.enumsBAssetFieldTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v4/enums;enums�GAA�Google.Ads.GoogleAds.V4.Enums�Google\\Ads\\GoogleAds\\V4\\Enums�!Google::Ads::GoogleAds::V4::Enumsbproto3
�
;google/ads/googleads/v4/enums/asset_performance_label.protogoogle.ads.googleads.v4.enums"�
AssetPerformanceLabelEnum"m
AssetPerformanceLabel
UNSPECIFIED 
UNKNOWN
PENDING
LEARNING
LOW
GOOD
BESTB�
!com.google.ads.googleads.v4.enumsBAssetPerformanceLabelProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v4/enums;enums�GAA�Google.Ads.GoogleAds.V4.Enums�Google\\Ads\\GoogleAds\\V4\\Enums�!Google::Ads::GoogleAds::V4::Enumsbproto3
�
:google/ads/googleads/v4/enums/policy_approval_status.protogoogle.ads.googleads.v4.enums"�
PolicyApprovalStatusEnum"�
PolicyApprovalStatus
UNSPECIFIED 
UNKNOWN
DISAPPROVED
APPROVED_LIMITED
APPROVED
AREA_OF_INTEREST_ONLYB�
!com.google.ads.googleads.v4.enumsBPolicyApprovalStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v4/enums;enums�GAA�Google.Ads.GoogleAds.V4.Enums�Google\\Ads\\GoogleAds\\V4\\Enums�!Google::Ads::GoogleAds::V4::Enumsbproto3
�
8google/ads/googleads/v4/enums/policy_review_status.protogoogle.ads.googleads.v4.enums"�
PolicyReviewStatusEnum"�
PolicyReviewStatus
UNSPECIFIED 
UNKNOWN
REVIEW_IN_PROGRESS
REVIEWED
UNDER_APPEAL
ELIGIBLE_MAY_SERVEB�
!com.google.ads.googleads.v4.enumsBPolicyReviewStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v4/enums;enums�GAA�Google.Ads.GoogleAds.V4.Enums�Google\\Ads\\GoogleAds\\V4\\Enums�!Google::Ads::GoogleAds::V4::Enumsbproto3
�
>google/ads/googleads/v4/resources/ad_group_ad_asset_view.proto!google.ads.googleads.v4.resources4google/ads/googleads/v4/enums/asset_field_type.proto;google/ads/googleads/v4/enums/asset_performance_label.proto:google/ads/googleads/v4/enums/policy_approval_status.proto8google/ads/googleads/v4/enums/policy_review_status.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
AdGroupAdAssetViewJ
resource_name (	B3�A�A-
+googleads.googleapis.com/AdGroupAdAssetView]
ad_group_ad (2.google.protobuf.StringValueB*�A�A$
"googleads.googleapis.com/AdGroupAdS
asset (2.google.protobuf.StringValueB&�A�A 
googleads.googleapis.com/AssetY

field_type (2@.google.ads.googleads.v4.enums.AssetFieldTypeEnum.AssetFieldTypeB�A[
policy_summary (2>.google.ads.googleads.v4.resources.AdGroupAdAssetPolicySummaryB�An
performance_label (2N.google.ads.googleads.v4.enums.AssetPerformanceLabelEnum.AssetPerformanceLabelB�A:s�Ap
+googleads.googleapis.com/AdGroupAdAssetViewAcustomers/{customer}/adGroupAdAssetViews/{ad_group_ad_asset_view}"�
AdGroupAdAssetPolicySummaryS
policy_topic_entries (20.google.ads.googleads.v4.common.PolicyTopicEntryB�Ad
review_status (2H.google.ads.googleads.v4.enums.PolicyReviewStatusEnum.PolicyReviewStatusB�Aj
approval_status (2L.google.ads.googleads.v4.enums.PolicyApprovalStatusEnum.PolicyApprovalStatusB�AB�
%com.google.ads.googleads.v4.resourcesBAdGroupAdAssetViewProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v4/resources;resources�GAA�!Google.Ads.GoogleAds.V4.Resources�!Google\\Ads\\GoogleAds\\V4\\Resources�%Google::Ads::GoogleAds::V4::Resourcesbproto3
�
Egoogle/ads/googleads/v4/services/ad_group_ad_asset_view_service.proto google.ads.googleads.v4.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto"j
GetAdGroupAdAssetViewRequestJ
resource_name (	B3�A�A-
+googleads.googleapis.com/AdGroupAdAssetView2�
AdGroupAdAssetViewService�
GetAdGroupAdAssetView>.google.ads.googleads.v4.services.GetAdGroupAdAssetViewRequest5.google.ads.googleads.v4.resources.AdGroupAdAssetView"M���75/v4/{resource_name=customers/*/adGroupAdAssetViews/*}�Aresource_nameE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v4.servicesBAdGroupAdAssetViewServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v4/services;services�GAA� Google.Ads.GoogleAds.V4.Services� Google\\Ads\\GoogleAds\\V4\\Services�$Google::Ads::GoogleAds::V4::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

