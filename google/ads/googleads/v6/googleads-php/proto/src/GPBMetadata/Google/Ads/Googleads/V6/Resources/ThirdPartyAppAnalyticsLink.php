<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v6/resources/third_party_app_analytics_link.proto

namespace GPBMetadata\Google\Ads\Googleads\V6\Resources;

class ThirdPartyAppAnalyticsLink
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
�
Fgoogle/ads/googleads/v6/resources/third_party_app_analytics_link.proto!google.ads.googleads.v6.resourcesgoogle/api/resource.protogoogle/api/annotations.proto"�
ThirdPartyAppAnalyticsLinkR
resource_name (	B;�A�A5
3googleads.googleapis.com/ThirdPartyAppAnalyticsLink#
shareable_link_id (	B�AH �:��A}
3googleads.googleapis.com/ThirdPartyAppAnalyticsLinkFcustomers/{customer_id}/thirdPartyAppAnalyticsLinks/{customer_link_id}B
_shareable_link_idB�
%com.google.ads.googleads.v6.resourcesBThirdPartyAppAnalyticsLinkProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v6/resources;resources�GAA�!Google.Ads.GoogleAds.V6.Resources�!Google\\Ads\\GoogleAds\\V6\\Resources�%Google::Ads::GoogleAds::V6::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

