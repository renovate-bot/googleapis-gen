<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v3/resources/landing_page_view.proto

namespace GPBMetadata\Google\Ads\Googleads\V3\Resources;

class LandingPageView
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
�
9google/ads/googleads/v3/resources/landing_page_view.proto!google.ads.googleads.v3.resourcesgoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
LandingPageViewG
resource_name (	B0�A�A*
(googleads.googleapis.com/LandingPageView?
unexpanded_final_url (2.google.protobuf.StringValueB�A:h�Ae
(googleads.googleapis.com/LandingPageView9customers/{customer}/landingPageViews/{landing_page_view}B�
%com.google.ads.googleads.v3.resourcesBLandingPageViewProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v3/resources;resources�GAA�!Google.Ads.GoogleAds.V3.Resources�!Google\\Ads\\GoogleAds\\V3\\Resources�%Google::Ads::GoogleAds::V3::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

