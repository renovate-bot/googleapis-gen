<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v3/resources/ad_group_audience_view.proto

namespace GPBMetadata\Google\Ads\Googleads\V3\Resources;

class AdGroupAudienceView
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
�
>google/ads/googleads/v3/resources/ad_group_audience_view.proto!google.ads.googleads.v3.resourcesgoogle/api/resource.protogoogle/api/annotations.proto"�
AdGroupAudienceViewK
resource_name (	B4�A�A.
,googleads.googleapis.com/AdGroupAudienceView:u�Ar
,googleads.googleapis.com/AdGroupAudienceViewBcustomers/{customer}/adGroupAudienceViews/{ad_group_audience_view}B�
%com.google.ads.googleads.v3.resourcesBAdGroupAudienceViewProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v3/resources;resources�GAA�!Google.Ads.GoogleAds.V3.Resources�!Google\\Ads\\GoogleAds\\V3\\Resources�%Google::Ads::GoogleAds::V3::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

