<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v3/resources/display_keyword_view.proto

namespace GPBMetadata\Google\Ads\Googleads\V3\Resources;

class DisplayKeywordView
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
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
<google/ads/googleads/v3/resources/display_keyword_view.proto!google.ads.googleads.v3.resourcesgoogle/api/resource.protogoogle/api/annotations.proto"�
DisplayKeywordViewJ
resource_name (	B3�A�A-
+googleads.googleapis.com/DisplayKeywordView:q�An
+googleads.googleapis.com/DisplayKeywordView?customers/{customer}/displayKeywordViews/{display_keyword_view}B�
%com.google.ads.googleads.v3.resourcesBDisplayKeywordViewProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v3/resources;resources�GAA�!Google.Ads.GoogleAds.V3.Resources�!Google\\Ads\\GoogleAds\\V3\\Resources�%Google::Ads::GoogleAds::V3::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

