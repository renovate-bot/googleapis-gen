<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v4/resources/age_range_view.proto

namespace GPBMetadata\Google\Ads\Googleads\V4\Resources;

class AgeRangeView
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();
        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Http::initOnce();
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
6google/ads/googleads/v4/resources/age_range_view.proto!google.ads.googleads.v4.resourcesgoogle/api/resource.protogoogle/api/annotations.proto"�
AgeRangeViewD
resource_name (	B-�A�A\'
%googleads.googleapis.com/AgeRangeView:_�A\\
%googleads.googleapis.com/AgeRangeView3customers/{customer}/ageRangeViews/{age_range_view}B�
%com.google.ads.googleads.v4.resourcesBAgeRangeViewProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v4/resources;resources�GAA�!Google.Ads.GoogleAds.V4.Resources�!Google\\Ads\\GoogleAds\\V4\\Resources�%Google::Ads::GoogleAds::V4::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

