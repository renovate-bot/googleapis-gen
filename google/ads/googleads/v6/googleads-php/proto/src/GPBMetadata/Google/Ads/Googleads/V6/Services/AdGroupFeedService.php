<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v6/services/ad_group_feed_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V6\Services;

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
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Protobuf\Any::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        \GPBMetadata\Google\Rpc\Status::initOnce();
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
�
9google/ads/googleads/v6/enums/response_content_type.protogoogle.ads.googleads.v6.enums"o
ResponseContentTypeEnum"T
ResponseContentType
UNSPECIFIED 
RESOURCE_NAME_ONLY
MUTABLE_RESOURCEB�
!com.google.ads.googleads.v6.enumsBResponseContentTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
5google/ads/googleads/v6/resources/ad_group_feed.proto!google.ads.googleads.v6.resources4google/ads/googleads/v6/enums/feed_link_status.proto4google/ads/googleads/v6/enums/placeholder_type.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/api/annotations.proto"�
AdGroupFeedC
resource_name (	B,�A�A&
$googleads.googleapis.com/AdGroupFeed8
feed (	B%�A�A
googleads.googleapis.com/FeedH �?
ad_group (	B(�A�A"
 googleads.googleapis.com/AdGroupH�]
placeholder_types (2B.google.ads.googleads.v6.enums.PlaceholderTypeEnum.PlaceholderTypeK
matching_function (20.google.ads.googleads.v6.common.MatchingFunctionU
status (2@.google.ads.googleads.v6.enums.FeedLinkStatusEnum.FeedLinkStatusB�A:g�Ad
$googleads.googleapis.com/AdGroupFeed<customers/{customer_id}/adGroupFeeds/{ad_group_id}~{feed_id}B
_feedB
	_ad_groupB�
%com.google.ads.googleads.v6.resourcesBAdGroupFeedProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v6/resources;resources�GAA�!Google.Ads.GoogleAds.V6.Resources�!Google\\Ads\\GoogleAds\\V6\\Resources�%Google::Ads::GoogleAds::V6::Resourcesbproto3
�
<google/ads/googleads/v6/services/ad_group_feed_service.proto google.ads.googleads.v6.services5google/ads/googleads/v6/resources/ad_group_feed.protogoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto google/protobuf/field_mask.protogoogle/rpc/status.proto"\\
GetAdGroupFeedRequestC
resource_name (	B,�A�A&
$googleads.googleapis.com/AdGroupFeed"�
MutateAdGroupFeedsRequest
customer_id (	B�AO

operations (26.google.ads.googleads.v6.services.AdGroupFeedOperationB�A
partial_failure (
validate_only (i
response_content_type (2J.google.ads.googleads.v6.enums.ResponseContentTypeEnum.ResponseContentType"�
AdGroupFeedOperation/
update_mask (2.google.protobuf.FieldMask@
create (2..google.ads.googleads.v6.resources.AdGroupFeedH @
update (2..google.ads.googleads.v6.resources.AdGroupFeedH 
remove (	H B
	operation"�
MutateAdGroupFeedsResponse1
partial_failure_error (2.google.rpc.StatusJ
results (29.google.ads.googleads.v6.services.MutateAdGroupFeedResult"w
MutateAdGroupFeedResult
resource_name (	E
ad_group_feed (2..google.ads.googleads.v6.resources.AdGroupFeed2�
AdGroupFeedService�
GetAdGroupFeed7.google.ads.googleads.v6.services.GetAdGroupFeedRequest..google.ads.googleads.v6.resources.AdGroupFeed"F���0./v6/{resource_name=customers/*/adGroupFeeds/*}�Aresource_name�
MutateAdGroupFeeds;.google.ads.googleads.v6.services.MutateAdGroupFeedsRequest<.google.ads.googleads.v6.services.MutateAdGroupFeedsResponse"U���6"1/v6/customers/{customer_id=*}/adGroupFeeds:mutate:*�Acustomer_id,operationsE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v6.servicesBAdGroupFeedServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v6/services;services�GAA� Google.Ads.GoogleAds.V6.Services� Google\\Ads\\GoogleAds\\V6\\Services�$Google::Ads::GoogleAds::V6::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

