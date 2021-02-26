<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v5/services/landing_page_view_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V5\Services;

class LandingPageViewService
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
        \GPBMetadata\Google\Api\Client::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
9google/ads/googleads/v5/resources/landing_page_view.proto!google.ads.googleads.v5.resourcesgoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
LandingPageViewG
resource_name (	B0�A�A*
(googleads.googleapis.com/LandingPageView?
unexpanded_final_url (2.google.protobuf.StringValueB�A:h�Ae
(googleads.googleapis.com/LandingPageView9customers/{customer}/landingPageViews/{landing_page_view}B�
%com.google.ads.googleads.v5.resourcesBLandingPageViewProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v5/resources;resources�GAA�!Google.Ads.GoogleAds.V5.Resources�!Google\\Ads\\GoogleAds\\V5\\Resources�%Google::Ads::GoogleAds::V5::Resourcesbproto3
�
@google/ads/googleads/v5/services/landing_page_view_service.proto google.ads.googleads.v5.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto"d
GetLandingPageViewRequestG
resource_name (	B0�A�A*
(googleads.googleapis.com/LandingPageView2�
LandingPageViewService�
GetLandingPageView;.google.ads.googleads.v5.services.GetLandingPageViewRequest2.google.ads.googleads.v5.resources.LandingPageView"J���42/v5/{resource_name=customers/*/landingPageViews/*}�Aresource_nameE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v5.servicesBLandingPageViewServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v5/services;services�GAA� Google.Ads.GoogleAds.V5.Services� Google\\Ads\\GoogleAds\\V5\\Services�$Google::Ads::GoogleAds::V5::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

