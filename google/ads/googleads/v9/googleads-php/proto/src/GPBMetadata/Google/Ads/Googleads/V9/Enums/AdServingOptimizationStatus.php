<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v9/enums/ad_serving_optimization_status.proto

namespace GPBMetadata\Google\Ads\Googleads\V9\Enums;

class AdServingOptimizationStatus
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();
        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Http::initOnce();
        \GPBMetadata\Google\Api\Annotations::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
Bgoogle/ads/googleads/v9/enums/ad_serving_optimization_status.protogoogle.ads.googleads.v9.enums"�
AdServingOptimizationStatusEnum"�
AdServingOptimizationStatus
UNSPECIFIED 
UNKNOWN
OPTIMIZE
CONVERSION_OPTIMIZE

ROTATE
ROTATE_INDEFINITELY
UNAVAILABLEB�
!com.google.ads.googleads.v9.enumsB AdServingOptimizationStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v9/enums;enums�GAA�Google.Ads.GoogleAds.V9.Enums�Google\\Ads\\GoogleAds\\V9\\Enums�!Google::Ads::GoogleAds::V9::Enumsbproto3'
        , true);
        static::$is_initialized = true;
    }
}

