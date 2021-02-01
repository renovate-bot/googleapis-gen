<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v6/resources/campaign_feed.proto

namespace GPBMetadata\Google\Ads\Googleads\V6\Resources;

class CampaignFeed
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
�
Bgoogle/ads/googleads/v6/enums/matching_function_context_type.protogoogle.ads.googleads.v6.enums"�
MatchingFunctionContextTypeEnum"^
MatchingFunctionContextType
UNSPECIFIED 
UNKNOWN
FEED_ITEM_ID
DEVICE_NAMEB�
!com.google.ads.googleads.v6.enumsB MatchingFunctionContextTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
>google/ads/googleads/v6/enums/matching_function_operator.protogoogle.ads.googleads.v6.enums"�
MatchingFunctionOperatorEnum"u
MatchingFunctionOperator
UNSPECIFIED 
UNKNOWN
IN
IDENTITY

EQUALS
AND
CONTAINS_ANYB�
!com.google.ads.googleads.v6.enumsBMatchingFunctionOperatorProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
6google/ads/googleads/v6/common/matching_function.protogoogle.ads.googleads.v6.common>google/ads/googleads/v6/enums/matching_function_operator.protogoogle/api/annotations.proto"�
MatchingFunction
function_string (	H �f
operator (2T.google.ads.googleads.v6.enums.MatchingFunctionOperatorEnum.MatchingFunctionOperator>
left_operands (2\'.google.ads.googleads.v6.common.Operand?
right_operands (2\'.google.ads.googleads.v6.common.OperandB
_function_string"�
OperandS
constant_operand (27.google.ads.googleads.v6.common.Operand.ConstantOperandH ^
feed_attribute_operand (2<.google.ads.googleads.v6.common.Operand.FeedAttributeOperandH S
function_operand (27.google.ads.googleads.v6.common.Operand.FunctionOperandH `
request_context_operand (2=.google.ads.googleads.v6.common.Operand.RequestContextOperandH �
ConstantOperand
string_value (	H 

long_value (H 
boolean_value (H 
double_value (H B
constant_operand_valuen
FeedAttributeOperand
feed_id (H �
feed_attribute_id (H�B

_feed_idB
_feed_attribute_id^
FunctionOperandK
matching_function (20.google.ads.googleads.v6.common.MatchingFunction�
RequestContextOperandp
context_type (2Z.google.ads.googleads.v6.enums.MatchingFunctionContextTypeEnum.MatchingFunctionContextTypeB
function_argument_operandB�
"com.google.ads.googleads.v6.commonBMatchingFunctionProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v6/common;common�GAA�Google.Ads.GoogleAds.V6.Common�Google\\Ads\\GoogleAds\\V6\\Common�"Google::Ads::GoogleAds::V6::Commonbproto3
�
4google/ads/googleads/v6/enums/placeholder_type.protogoogle.ads.googleads.v6.enums"�
PlaceholderTypeEnum"�
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
DYNAMIC_JOB	
IMAGEB�
!com.google.ads.googleads.v6.enumsBPlaceholderTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
4google/ads/googleads/v6/enums/feed_link_status.protogoogle.ads.googleads.v6.enums"^
FeedLinkStatusEnum"H
FeedLinkStatus
UNSPECIFIED 
UNKNOWN
ENABLED
REMOVEDB�
!com.google.ads.googleads.v6.enumsBFeedLinkStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�	
5google/ads/googleads/v6/resources/campaign_feed.proto!google.ads.googleads.v6.resources4google/ads/googleads/v6/enums/feed_link_status.proto4google/ads/googleads/v6/enums/placeholder_type.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/api/annotations.proto"�
CampaignFeedD
resource_name (	B-�A�A\'
%googleads.googleapis.com/CampaignFeed8
feed (	B%�A�A
googleads.googleapis.com/FeedH �@
campaign (	B)�A�A#
!googleads.googleapis.com/CampaignH�]
placeholder_types (2B.google.ads.googleads.v6.enums.PlaceholderTypeEnum.PlaceholderTypeK
matching_function (20.google.ads.googleads.v6.common.MatchingFunctionU
status (2@.google.ads.googleads.v6.enums.FeedLinkStatusEnum.FeedLinkStatusB�A:i�Af
%googleads.googleapis.com/CampaignFeed=customers/{customer_id}/campaignFeeds/{campaign_id}~{feed_id}B
_feedB
	_campaignB�
%com.google.ads.googleads.v6.resourcesBCampaignFeedProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v6/resources;resources�GAA�!Google.Ads.GoogleAds.V6.Resources�!Google\\Ads\\GoogleAds\\V6\\Resources�%Google::Ads::GoogleAds::V6::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

