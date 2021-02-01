<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v4/services/ad_group_audience_view_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V4\Services;

class AdGroupAudienceViewService
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
        \GPBMetadata\Google\Api\Client::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
>google/ads/googleads/v4/resources/ad_group_audience_view.proto!google.ads.googleads.v4.resourcesgoogle/api/resource.protogoogle/api/annotations.proto"�
AdGroupAudienceViewK
resource_name (	B4�A�A.
,googleads.googleapis.com/AdGroupAudienceView:u�Ar
,googleads.googleapis.com/AdGroupAudienceViewBcustomers/{customer}/adGroupAudienceViews/{ad_group_audience_view}B�
%com.google.ads.googleads.v4.resourcesBAdGroupAudienceViewProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v4/resources;resources�GAA�!Google.Ads.GoogleAds.V4.Resources�!Google\\Ads\\GoogleAds\\V4\\Resources�%Google::Ads::GoogleAds::V4::Resourcesbproto3
�
Egoogle/ads/googleads/v4/services/ad_group_audience_view_service.proto google.ads.googleads.v4.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto"l
GetAdGroupAudienceViewRequestK
resource_name (	B4�A�A.
,googleads.googleapis.com/AdGroupAudienceView2�
AdGroupAudienceViewService�
GetAdGroupAudienceView?.google.ads.googleads.v4.services.GetAdGroupAudienceViewRequest6.google.ads.googleads.v4.resources.AdGroupAudienceView"N���86/v4/{resource_name=customers/*/adGroupAudienceViews/*}�Aresource_nameE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v4.servicesBAdGroupAudienceViewServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v4/services;services�GAA� Google.Ads.GoogleAds.V4.Services� Google\\Ads\\GoogleAds\\V4\\Services�$Google::Ads::GoogleAds::V4::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

