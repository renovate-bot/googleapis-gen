<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v3/services/feed_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V3\Services;

class FeedService
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
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Protobuf\Any::initOnce();
        \GPBMetadata\Google\Rpc\Status::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
Mgoogle/ads/googleads/v3/enums/affiliate_location_feed_relationship_type.protogoogle.ads.googleads.v3.enums"�
)AffiliateLocationFeedRelationshipTypeEnum"[
%AffiliateLocationFeedRelationshipType
UNSPECIFIED 
UNKNOWN
GENERAL_RETAILERB�
!com.google.ads.googleads.v3.enumsB*AffiliateLocationFeedRelationshipTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
7google/ads/googleads/v3/enums/feed_attribute_type.protogoogle.ads.googleads.v3.enums"�
FeedAttributeTypeEnum"�
FeedAttributeType
UNSPECIFIED 
UNKNOWN	
INT64

DOUBLE

STRING
BOOLEAN
URL
	DATE_TIME

INT64_LIST
DOUBLE_LIST	
STRING_LIST

BOOLEAN_LIST
URL_LIST
DATE_TIME_LIST	
PRICEB�
!com.google.ads.googleads.v3.enumsBFeedAttributeTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
/google/ads/googleads/v3/enums/feed_origin.protogoogle.ads.googleads.v3.enums"R
FeedOriginEnum"@

FeedOrigin
UNSPECIFIED 
UNKNOWN
USER

GOOGLEB�
!com.google.ads.googleads.v3.enumsBFeedOriginProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
/google/ads/googleads/v3/enums/feed_status.protogoogle.ads.googleads.v3.enums"V
FeedStatusEnum"D

FeedStatus
UNSPECIFIED 
UNKNOWN
ENABLED
REMOVEDB�
!com.google.ads.googleads.v3.enumsBFeedStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
,google/ads/googleads/v3/resources/feed.proto!google.ads.googleads.v3.resources7google/ads/googleads/v3/enums/feed_attribute_type.proto/google/ads/googleads/v3/enums/feed_origin.proto/google/ads/googleads/v3/enums/feed_status.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
Feed<
resource_name (	B%�A�A
googleads.googleapis.com/Feed,
id (2.google.protobuf.Int64ValueB�A/
name (2.google.protobuf.StringValueB�AD

attributes (20.google.ads.googleads.v3.resources.FeedAttributeW
attribute_operations	 (29.google.ads.googleads.v3.resources.FeedAttributeOperationM
origin (28.google.ads.googleads.v3.enums.FeedOriginEnum.FeedOriginB�AM
status (28.google.ads.googleads.v3.enums.FeedStatusEnum.FeedStatusB�Ac
places_location_feed_data (2>.google.ads.googleads.v3.resources.Feed.PlacesLocationFeedDataH i
affiliate_location_feed_data (2A.google.ads.googleads.v3.resources.Feed.AffiliateLocationFeedDataH �
PlacesLocationFeedDataa

oauth_info (2H.google.ads.googleads.v3.resources.Feed.PlacesLocationFeedData.OAuthInfoB�A3
email_address (2.google.protobuf.StringValue9
business_account_id
 (2.google.protobuf.StringValue:
business_name_filter (2.google.protobuf.StringValue6
category_filters (2.google.protobuf.StringValue3
label_filters (2.google.protobuf.StringValue�
	OAuthInfo1
http_method (2.google.protobuf.StringValue6
http_request_url (2.google.protobuf.StringValue?
http_authorization_header (2.google.protobuf.StringValue�
AffiliateLocationFeedData.
	chain_ids (2.google.protobuf.Int64Value�
relationship_type (2n.google.ads.googleads.v3.enums.AffiliateLocationFeedRelationshipTypeEnum.AffiliateLocationFeedRelationshipType:E�AB
googleads.googleapis.com/Feed!customers/{customer}/feeds/{feed}B
system_feed_generation_data"�
FeedAttribute\'
id (2.google.protobuf.Int64Value*
name (2.google.protobuf.StringValueT
type (2F.google.ads.googleads.v3.enums.FeedAttributeTypeEnum.FeedAttributeType2
is_part_of_key (2.google.protobuf.BoolValue"�
FeedAttributeOperationY
operator (2B.google.ads.googleads.v3.resources.FeedAttributeOperation.OperatorB�AD
value (20.google.ads.googleads.v3.resources.FeedAttributeB�A"1
Operator
UNSPECIFIED 
UNKNOWN
ADDB�
%com.google.ads.googleads.v3.resourcesB	FeedProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v3/resources;resources�GAA�!Google.Ads.GoogleAds.V3.Resources�!Google\\Ads\\GoogleAds\\V3\\Resources�%Google::Ads::GoogleAds::V3::Resourcesbproto3
�
3google/ads/googleads/v3/services/feed_service.proto google.ads.googleads.v3.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto google/protobuf/field_mask.protogoogle/rpc/status.proto"N
GetFeedRequest<
resource_name (	B%�A�A
googleads.googleapis.com/Feed"�
MutateFeedsRequest
customer_id (	B�AH

operations (2/.google.ads.googleads.v3.services.FeedOperationB�A
partial_failure (
validate_only ("�
FeedOperation/
update_mask (2.google.protobuf.FieldMask9
create (2\'.google.ads.googleads.v3.resources.FeedH 9
update (2\'.google.ads.googleads.v3.resources.FeedH 
remove (	H B
	operation"�
MutateFeedsResponse1
partial_failure_error (2.google.rpc.StatusC
results (22.google.ads.googleads.v3.services.MutateFeedResult")
MutateFeedResult
resource_name (	2�
FeedService�
GetFeed0.google.ads.googleads.v3.services.GetFeedRequest\'.google.ads.googleads.v3.resources.Feed"?���)\'/v3/{resource_name=customers/*/feeds/*}�Aresource_name�
MutateFeeds4.google.ads.googleads.v3.services.MutateFeedsRequest5.google.ads.googleads.v3.services.MutateFeedsResponse"N���/"*/v3/customers/{customer_id=*}/feeds:mutate:*�Acustomer_id,operationsE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v3.servicesBFeedServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v3/services;services�GAA� Google.Ads.GoogleAds.V3.Services� Google\\Ads\\GoogleAds\\V3\\Services�$Google::Ads::GoogleAds::V3::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

