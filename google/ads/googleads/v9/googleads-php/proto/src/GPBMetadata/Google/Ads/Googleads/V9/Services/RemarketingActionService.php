<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v9/services/remarketing_action_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V9\Services;

class RemarketingActionService
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
        \GPBMetadata\Google\Protobuf\Any::initOnce();
        \GPBMetadata\Google\Rpc\Status::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
=google/ads/googleads/v9/enums/tracking_code_page_format.protogoogle.ads.googleads.v9.enums"g
TrackingCodePageFormatEnum"I
TrackingCodePageFormat
UNSPECIFIED 
UNKNOWN
HTML
AMPB�
!com.google.ads.googleads.v9.enumsBTrackingCodePageFormatProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v9/enums;enums�GAA�Google.Ads.GoogleAds.V9.Enums�Google\\Ads\\GoogleAds\\V9\\Enums�!Google::Ads::GoogleAds::V9::Enumsbproto3
�
6google/ads/googleads/v9/enums/tracking_code_type.protogoogle.ads.googleads.v9.enums"�
TrackingCodeTypeEnum"w
TrackingCodeType
UNSPECIFIED 
UNKNOWN
WEBPAGE
WEBPAGE_ONCLICK
CLICK_TO_CALL
WEBSITE_CALLB�
!com.google.ads.googleads.v9.enumsBTrackingCodeTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v9/enums;enums�GAA�Google.Ads.GoogleAds.V9.Enums�Google\\Ads\\GoogleAds\\V9\\Enums�!Google::Ads::GoogleAds::V9::Enumsbproto3
�
0google/ads/googleads/v9/common/tag_snippet.protogoogle.ads.googleads.v9.common6google/ads/googleads/v9/enums/tracking_code_type.protogoogle/api/annotations.proto"�

TagSnippetR
type (2D.google.ads.googleads.v9.enums.TrackingCodeTypeEnum.TrackingCodeTypee
page_format (2P.google.ads.googleads.v9.enums.TrackingCodePageFormatEnum.TrackingCodePageFormat
global_site_tag (	H �
event_snippet (	H�B
_global_site_tagB
_event_snippetB�
"com.google.ads.googleads.v9.commonBTagSnippetProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v9/common;common�GAA�Google.Ads.GoogleAds.V9.Common�Google\\Ads\\GoogleAds\\V9\\Common�"Google::Ads::GoogleAds::V9::Commonbproto3
�
:google/ads/googleads/v9/resources/remarketing_action.proto!google.ads.googleads.v9.resourcesgoogle/api/field_behavior.protogoogle/api/resource.protogoogle/api/annotations.proto"�
RemarketingActionI
resource_name (	B2�A�A,
*googleads.googleapis.com/RemarketingAction
id (B�AH �
name (	H�E
tag_snippets (2*.google.ads.googleads.v9.common.TagSnippetB�A:s�Ap
*googleads.googleapis.com/RemarketingActionBcustomers/{customer_id}/remarketingActions/{remarketing_action_id}B
_idB
_nameB�
%com.google.ads.googleads.v9.resourcesBRemarketingActionProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v9/resources;resources�GAA�!Google.Ads.GoogleAds.V9.Resources�!Google\\Ads\\GoogleAds\\V9\\Resources�%Google::Ads::GoogleAds::V9::Resourcesbproto3
�
Agoogle/ads/googleads/v9/services/remarketing_action_service.proto google.ads.googleads.v9.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto google/protobuf/field_mask.protogoogle/rpc/status.proto"h
GetRemarketingActionRequestI
resource_name (	B2�A�A,
*googleads.googleapis.com/RemarketingAction"�
MutateRemarketingActionsRequest
customer_id (	B�AU

operations (2<.google.ads.googleads.v9.services.RemarketingActionOperationB�A
partial_failure (
validate_only ("�
RemarketingActionOperation/
update_mask (2.google.protobuf.FieldMaskF
create (24.google.ads.googleads.v9.resources.RemarketingActionH F
update (24.google.ads.googleads.v9.resources.RemarketingActionH B
	operation"�
 MutateRemarketingActionsResponse1
partial_failure_error (2.google.rpc.StatusP
results (2?.google.ads.googleads.v9.services.MutateRemarketingActionResult"6
MutateRemarketingActionResult
resource_name (	2�
RemarketingActionService�
GetRemarketingAction=.google.ads.googleads.v9.services.GetRemarketingActionRequest4.google.ads.googleads.v9.resources.RemarketingAction"L���64/v9/{resource_name=customers/*/remarketingActions/*}�Aresource_name�
MutateRemarketingActionsA.google.ads.googleads.v9.services.MutateRemarketingActionsRequestB.google.ads.googleads.v9.services.MutateRemarketingActionsResponse"[���<"7/v9/customers/{customer_id=*}/remarketingActions:mutate:*�Acustomer_id,operationsE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v9.servicesBRemarketingActionServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v9/services;services�GAA� Google.Ads.GoogleAds.V9.Services� Google\\Ads\\GoogleAds\\V9\\Services�$Google::Ads::GoogleAds::V9::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

