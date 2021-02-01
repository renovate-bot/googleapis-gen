<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v5/resources/change_status.proto

namespace GPBMetadata\Google\Ads\Googleads\V5\Resources;

class ChangeStatus
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
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
<google/ads/googleads/v5/enums/advertising_channel_type.protogoogle.ads.googleads.v5.enums"�
AdvertisingChannelTypeEnum"�
AdvertisingChannelType
UNSPECIFIED 
UNKNOWN

SEARCH
DISPLAY
SHOPPING	
HOTEL	
VIDEO
MULTI_CHANNEL	
LOCAL	
SMART	B�
!com.google.ads.googleads.v5.enumsBAdvertisingChannelTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
@google/ads/googleads/v5/enums/advertising_channel_sub_type.protogoogle.ads.googleads.v5.enums"�
AdvertisingChannelSubTypeEnum"�
AdvertisingChannelSubType
UNSPECIFIED 
UNKNOWN
SEARCH_MOBILE_APP
DISPLAY_MOBILE_APP
SEARCH_EXPRESS
DISPLAY_EXPRESS
SHOPPING_SMART_ADS
DISPLAY_GMAIL_AD
DISPLAY_SMART_CAMPAIGN
VIDEO_OUTSTREAM	
VIDEO_ACTION

VIDEO_NON_SKIPPABLE
APP_CAMPAIGN
APP_CAMPAIGN_FOR_ENGAGEMENT
LOCAL_CAMPAIGN#
SHOPPING_COMPARISON_LISTING_ADS
SMART_CAMPAIGN
VIDEO_SEQUENCEB�
!com.google.ads.googleads.v5.enumsBAdvertisingChannelSubTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
+google/ads/googleads/v5/enums/ad_type.protogoogle.ads.googleads.v5.enums"�

AdTypeEnum"�
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
RESPONSIVE_DISPLAY_AD
LOCAL_AD
HTML5_UPLOAD_AD
DYNAMIC_HTML5_AD
APP_ENGAGEMENT_AD"
SHOPPING_COMPARISON_LISTING_AD
VIDEO_BUMPER_AD$
 VIDEO_NON_SKIPPABLE_IN_STREAM_AD
VIDEO_OUTSTREAM_AD
VIDEO_TRUEVIEW_DISCOVERY_AD
VIDEO_TRUEVIEW_IN_STREAM_AD
VIDEO_RESPONSIVE_ADB�
!com.google.ads.googleads.v5.enumsBAdTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
;google/ads/googleads/v5/enums/change_status_operation.protogoogle.ads.googleads.v5.enums"w
ChangeStatusOperationEnum"Z
ChangeStatusOperation
UNSPECIFIED 
UNKNOWN	
ADDED
CHANGED
REMOVEDB�
!com.google.ads.googleads.v5.enumsBChangeStatusOperationProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
?google/ads/googleads/v5/enums/change_status_resource_type.protogoogle.ads.googleads.v5.enums"�
ChangeStatusResourceTypeEnum"�
ChangeStatusResourceType
UNSPECIFIED 
UNKNOWN
AD_GROUP
AD_GROUP_AD
AD_GROUP_CRITERION
CAMPAIGN
CAMPAIGN_CRITERION
FEED	
	FEED_ITEM

AD_GROUP_FEED
CAMPAIGN_FEED
AD_GROUP_BID_MODIFIERB�
!com.google.ads.googleads.v5.enumsBChangeStatusResourceTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
2google/ads/googleads/v5/enums/criterion_type.protogoogle.ads.googleads.v5.enums"�
CriterionTypeEnum"�
CriterionType
UNSPECIFIED 
UNKNOWN
KEYWORD
	PLACEMENT
MOBILE_APP_CATEGORY
MOBILE_APPLICATION

DEVICE
LOCATION
LISTING_GROUP
AD_SCHEDULE	
	AGE_RANGE


GENDER
INCOME_RANGE
PARENTAL_STATUS
YOUTUBE_VIDEO
YOUTUBE_CHANNEL
	USER_LIST
	PROXIMITY	
TOPIC
LISTING_SCOPE
LANGUAGE
IP_BLOCK
CONTENT_LABEL
CARRIER
USER_INTEREST
WEBPAGE
OPERATING_SYSTEM_VERSION
APP_PAYMENT_MODEL
MOBILE_DEVICE
CUSTOM_AFFINITY
CUSTOM_INTENT
LOCATION_GROUPB�
!com.google.ads.googleads.v5.enumsBCriterionTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
/google/ads/googleads/v5/enums/feed_origin.protogoogle.ads.googleads.v5.enums"R
FeedOriginEnum"@

FeedOrigin
UNSPECIFIED 
UNKNOWN
USER

GOOGLEB�
!com.google.ads.googleads.v5.enumsBFeedOriginProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
5google/ads/googleads/v5/resources/change_status.proto!google.ads.googleads.v5.resources@google/ads/googleads/v5/enums/advertising_channel_sub_type.proto<google/ads/googleads/v5/enums/advertising_channel_type.proto;google/ads/googleads/v5/enums/change_status_operation.proto?google/ads/googleads/v5/enums/change_status_resource_type.proto2google/ads/googleads/v5/enums/criterion_type.proto/google/ads/googleads/v5/enums/feed_origin.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
ChangeStatusD
resource_name (	B-�A�A\'
%googleads.googleapis.com/ChangeStatus@
last_change_date_time (2.google.protobuf.StringValueB�Ap
resource_type (2T.google.ads.googleads.v5.enums.ChangeStatusResourceTypeEnum.ChangeStatusResourceTypeB�A@
campaign (	B)�A�A#
!googleads.googleapis.com/CampaignH �?
ad_group (	B(�A�A"
 googleads.googleapis.com/AdGroupH�l
resource_status (2N.google.ads.googleads.v5.enums.ChangeStatusOperationEnum.ChangeStatusOperationB�A]
ad_group_ad	 (2.google.protobuf.StringValueB*�A�A$
"googleads.googleapis.com/AdGroupAdk
ad_group_criterion
 (2.google.protobuf.StringValueB1�A�A+
)googleads.googleapis.com/AdGroupCriterionl
campaign_criterion (2.google.protobuf.StringValueB2�A�A,
*googleads.googleapis.com/CampaignCriterionQ
feed (2.google.protobuf.StringValueB%�A�A
googleads.googleapis.com/FeedZ
	feed_item (2.google.protobuf.StringValueB)�A�A#
!googleads.googleapis.com/FeedItema
ad_group_feed (2.google.protobuf.StringValueB,�A�A&
$googleads.googleapis.com/AdGroupFeedb
campaign_feed (2.google.protobuf.StringValueB-�A�A\'
%googleads.googleapis.com/CampaignFeedp
ad_group_bid_modifier (2.google.protobuf.StringValueB3�A�A-
+googleads.googleapis.com/AdGroupBidModifier:]�AZ
%googleads.googleapis.com/ChangeStatus1customers/{customer}/changeStatus/{change_status}B
	_campaignB
	_ad_groupB�
%com.google.ads.googleads.v5.resourcesBChangeStatusProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v5/resources;resources�GAA�!Google.Ads.GoogleAds.V5.Resources�!Google\\Ads\\GoogleAds\\V5\\Resources�%Google::Ads::GoogleAds::V5::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

