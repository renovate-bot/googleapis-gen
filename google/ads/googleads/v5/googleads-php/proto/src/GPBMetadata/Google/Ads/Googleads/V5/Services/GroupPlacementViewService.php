<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v5/services/group_placement_view_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V5\Services;

class GroupPlacementViewService
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();
        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Http::initOnce();
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Protobuf\Wrappers::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
2google/ads/googleads/v5/enums/placement_type.protogoogle.ads.googleads.v5.enums"�
PlacementTypeEnum"�
PlacementType
UNSPECIFIED 
UNKNOWN
WEBSITE
MOBILE_APP_CATEGORY
MOBILE_APPLICATION
YOUTUBE_VIDEO
YOUTUBE_CHANNELB�
!com.google.ads.googleads.v5.enumsBPlacementTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
<google/ads/googleads/v5/resources/group_placement_view.proto!google.ads.googleads.v5.resourcesgoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
GroupPlacementViewJ
resource_name (	B3�A�A-
+googleads.googleapis.com/GroupPlacementView4
	placement (2.google.protobuf.StringValueB�A7
display_name (2.google.protobuf.StringValueB�A5

target_url (2.google.protobuf.StringValueB�A[
placement_type (2>.google.ads.googleads.v5.enums.PlacementTypeEnum.PlacementTypeB�A:q�An
+googleads.googleapis.com/GroupPlacementView?customers/{customer}/groupPlacementViews/{group_placement_view}B�
%com.google.ads.googleads.v5.resourcesBGroupPlacementViewProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v5/resources;resources�GAA�!Google.Ads.GoogleAds.V5.Resources�!Google\\Ads\\GoogleAds\\V5\\Resources�%Google::Ads::GoogleAds::V5::Resourcesbproto3
�
Cgoogle/ads/googleads/v5/services/group_placement_view_service.proto google.ads.googleads.v5.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto"j
GetGroupPlacementViewRequestJ
resource_name (	B3�A�A-
+googleads.googleapis.com/GroupPlacementView2�
GroupPlacementViewService�
GetGroupPlacementView>.google.ads.googleads.v5.services.GetGroupPlacementViewRequest5.google.ads.googleads.v5.resources.GroupPlacementView"M���75/v5/{resource_name=customers/*/groupPlacementViews/*}�Aresource_nameE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v5.servicesBGroupPlacementViewServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v5/services;services�GAA� Google.Ads.GoogleAds.V5.Services� Google\\Ads\\GoogleAds\\V5\\Services�$Google::Ads::GoogleAds::V5::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

