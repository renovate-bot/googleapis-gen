<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v5/services/ad_group_feed_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V5\Services;

class AdGroupFeedService
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();
        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Http::initOnce();
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Protobuf\Wrappers::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Protobuf\Any::initOnce();
        \GPBMetadata\Google\Rpc\Status::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
Bgoogle/ads/googleads/v5/enums/matching_function_context_type.protogoogle.ads.googleads.v5.enums"�
MatchingFunctionContextTypeEnum"^
MatchingFunctionContextType
UNSPECIFIED 
UNKNOWN
FEED_ITEM_ID
DEVICE_NAMEB�
!com.google.ads.googleads.v5.enumsB MatchingFunctionContextTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
>google/ads/googleads/v5/enums/matching_function_operator.protogoogle.ads.googleads.v5.enums"�
MatchingFunctionOperatorEnum"u
MatchingFunctionOperator
UNSPECIFIED 
UNKNOWN
IN
IDENTITY

EQUALS
AND
CONTAINS_ANYB�
!com.google.ads.googleads.v5.enumsBMatchingFunctionOperatorProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
6google/ads/googleads/v5/common/matching_function.protogoogle.ads.googleads.v5.common>google/ads/googleads/v5/enums/matching_function_operator.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
MatchingFunction5
function_string (2.google.protobuf.StringValuef
operator (2T.google.ads.googleads.v5.enums.MatchingFunctionOperatorEnum.MatchingFunctionOperator>
left_operands (2\'.google.ads.googleads.v5.common.Operand?
right_operands (2\'.google.ads.googleads.v5.common.Operand"�
OperandS
constant_operand (27.google.ads.googleads.v5.common.Operand.ConstantOperandH ^
feed_attribute_operand (2<.google.ads.googleads.v5.common.Operand.FeedAttributeOperandH S
function_operand (27.google.ads.googleads.v5.common.Operand.FunctionOperandH `
request_context_operand (2=.google.ads.googleads.v5.common.Operand.RequestContextOperandH �
ConstantOperand4
string_value (2.google.protobuf.StringValueH 1

long_value (2.google.protobuf.Int64ValueH 3
boolean_value (2.google.protobuf.BoolValueH 4
double_value (2.google.protobuf.DoubleValueH B
constant_operand_value|
FeedAttributeOperand,
feed_id (2.google.protobuf.Int64Value6
feed_attribute_id (2.google.protobuf.Int64Value^
FunctionOperandK
matching_function (20.google.ads.googleads.v5.common.MatchingFunction�
RequestContextOperandp
context_type (2Z.google.ads.googleads.v5.enums.MatchingFunctionContextTypeEnum.MatchingFunctionContextTypeB
function_argument_operandB�
"com.google.ads.googleads.v5.commonBMatchingFunctionProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v5/common;common�GAA�Google.Ads.GoogleAds.V5.Common�Google\\Ads\\GoogleAds\\V5\\Common�"Google::Ads::GoogleAds::V5::Commonbproto3
�
9google/ads/googleads/v5/enums/response_content_type.protogoogle.ads.googleads.v5.enums"o
ResponseContentTypeEnum"T
ResponseContentType
UNSPECIFIED 
RESOURCE_NAME_ONLY
MUTABLE_RESOURCEB�
!com.google.ads.googleads.v5.enumsBResponseContentTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
4google/ads/googleads/v5/enums/placeholder_type.protogoogle.ads.googleads.v5.enums"�
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
!com.google.ads.googleads.v5.enumsBPlaceholderTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
4google/ads/googleads/v5/enums/feed_link_status.protogoogle.ads.googleads.v5.enums"^
FeedLinkStatusEnum"H
FeedLinkStatus
UNSPECIFIED 
UNKNOWN
ENABLED
REMOVEDB�
!com.google.ads.googleads.v5.enumsBFeedLinkStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�	
5google/ads/googleads/v5/resources/ad_group_feed.proto!google.ads.googleads.v5.resources4google/ads/googleads/v5/enums/feed_link_status.proto4google/ads/googleads/v5/enums/placeholder_type.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
AdGroupFeedC
resource_name (	B,�A�A&
$googleads.googleapis.com/AdGroupFeedQ
feed (2.google.protobuf.StringValueB%�A�A
googleads.googleapis.com/FeedX
ad_group (2.google.protobuf.StringValueB(�A�A"
 googleads.googleapis.com/AdGroup]
placeholder_types (2B.google.ads.googleads.v5.enums.PlaceholderTypeEnum.PlaceholderTypeK
matching_function (20.google.ads.googleads.v5.common.MatchingFunctionU
status (2@.google.ads.googleads.v5.enums.FeedLinkStatusEnum.FeedLinkStatusB�A:\\�AY
$googleads.googleapis.com/AdGroupFeed1customers/{customer}/adGroupFeeds/{ad_group_feed}B�
%com.google.ads.googleads.v5.resourcesBAdGroupFeedProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v5/resources;resources�GAA�!Google.Ads.GoogleAds.V5.Resources�!Google\\Ads\\GoogleAds\\V5\\Resources�%Google::Ads::GoogleAds::V5::Resourcesbproto3
�
<google/ads/googleads/v5/services/ad_group_feed_service.proto google.ads.googleads.v5.services5google/ads/googleads/v5/resources/ad_group_feed.protogoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto google/protobuf/field_mask.protogoogle/rpc/status.proto"\\
GetAdGroupFeedRequestC
resource_name (	B,�A�A&
$googleads.googleapis.com/AdGroupFeed"�
MutateAdGroupFeedsRequest
customer_id (	B�AO

operations (26.google.ads.googleads.v5.services.AdGroupFeedOperationB�A
partial_failure (
validate_only (i
response_content_type (2J.google.ads.googleads.v5.enums.ResponseContentTypeEnum.ResponseContentType"�
AdGroupFeedOperation/
update_mask (2.google.protobuf.FieldMask@
create (2..google.ads.googleads.v5.resources.AdGroupFeedH @
update (2..google.ads.googleads.v5.resources.AdGroupFeedH 
remove (	H B
	operation"�
MutateAdGroupFeedsResponse1
partial_failure_error (2.google.rpc.StatusJ
results (29.google.ads.googleads.v5.services.MutateAdGroupFeedResult"w
MutateAdGroupFeedResult
resource_name (	E
ad_group_feed (2..google.ads.googleads.v5.resources.AdGroupFeed2�
AdGroupFeedService�
GetAdGroupFeed7.google.ads.googleads.v5.services.GetAdGroupFeedRequest..google.ads.googleads.v5.resources.AdGroupFeed"F���0./v5/{resource_name=customers/*/adGroupFeeds/*}�Aresource_name�
MutateAdGroupFeeds;.google.ads.googleads.v5.services.MutateAdGroupFeedsRequest<.google.ads.googleads.v5.services.MutateAdGroupFeedsResponse"U���6"1/v5/customers/{customer_id=*}/adGroupFeeds:mutate:*�Acustomer_id,operationsE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v5.servicesBAdGroupFeedServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v5/services;services�GAA� Google.Ads.GoogleAds.V5.Services� Google\\Ads\\GoogleAds\\V5\\Services�$Google::Ads::GoogleAds::V5::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

