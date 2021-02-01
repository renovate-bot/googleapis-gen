<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v5/services/expanded_landing_page_view_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V5\Services;

class ExpandedLandingPageViewService
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
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
Bgoogle/ads/googleads/v5/resources/expanded_landing_page_view.proto!google.ads.googleads.v5.resourcesgoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
ExpandedLandingPageViewO
resource_name (	B8�A�A2
0googleads.googleapis.com/ExpandedLandingPageView=
expanded_final_url (2.google.protobuf.StringValueB�A:��A~
0googleads.googleapis.com/ExpandedLandingPageViewJcustomers/{customer}/expandedLandingPageViews/{expanded_landing_page_view}B�
%com.google.ads.googleads.v5.resourcesBExpandedLandingPageViewProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v5/resources;resources�GAA�!Google.Ads.GoogleAds.V5.Resources�!Google\\Ads\\GoogleAds\\V5\\Resources�%Google::Ads::GoogleAds::V5::Resourcesbproto3
�
Igoogle/ads/googleads/v5/services/expanded_landing_page_view_service.proto google.ads.googleads.v5.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto"t
!GetExpandedLandingPageViewRequestO
resource_name (	B8�A�A2
0googleads.googleapis.com/ExpandedLandingPageView2�
ExpandedLandingPageViewService�
GetExpandedLandingPageViewC.google.ads.googleads.v5.services.GetExpandedLandingPageViewRequest:.google.ads.googleads.v5.resources.ExpandedLandingPageView"R���<:/v5/{resource_name=customers/*/expandedLandingPageViews/*}�Aresource_nameE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v5.servicesB#ExpandedLandingPageViewServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v5/services;services�GAA� Google.Ads.GoogleAds.V5.Services� Google\\Ads\\GoogleAds\\V5\\Services�$Google::Ads::GoogleAds::V5::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

