<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v3/resources/detail_placement_view.proto

namespace GPBMetadata\Google\Ads\Googleads\V3\Resources;

class DetailPlacementView
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
        $pool->internalAddGeneratedFile(
            '
�
2google/ads/googleads/v3/enums/placement_type.protogoogle.ads.googleads.v3.enums"�
PlacementTypeEnum"�
PlacementType
UNSPECIFIED 
UNKNOWN
WEBSITE
MOBILE_APP_CATEGORY
MOBILE_APPLICATION
YOUTUBE_VIDEO
YOUTUBE_CHANNELB�
!com.google.ads.googleads.v3.enumsBPlacementTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
=google/ads/googleads/v3/resources/detail_placement_view.proto!google.ads.googleads.v3.resourcesgoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
DetailPlacementViewK
resource_name (	B4�A�A.
,googleads.googleapis.com/DetailPlacementView4
	placement (2.google.protobuf.StringValueB�A7
display_name (2.google.protobuf.StringValueB�AE
group_placement_target_url (2.google.protobuf.StringValueB�A5

target_url (2.google.protobuf.StringValueB�A[
placement_type (2>.google.ads.googleads.v3.enums.PlacementTypeEnum.PlacementTypeB�A:t�Aq
,googleads.googleapis.com/DetailPlacementViewAcustomers/{customer}/detailPlacementViews/{detail_placement_view}B�
%com.google.ads.googleads.v3.resourcesBDetailPlacementViewProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v3/resources;resources�GAA�!Google.Ads.GoogleAds.V3.Resources�!Google\\Ads\\GoogleAds\\V3\\Resources�%Google::Ads::GoogleAds::V3::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

