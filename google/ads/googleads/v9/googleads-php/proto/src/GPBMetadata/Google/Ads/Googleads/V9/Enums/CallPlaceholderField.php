<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v9/enums/call_placeholder_field.proto

namespace GPBMetadata\Google\Ads\Googleads\V9\Enums;

class CallPlaceholderField
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
:google/ads/googleads/v9/enums/call_placeholder_field.protogoogle.ads.googleads.v9.enums"�
CallPlaceholderFieldEnum"�
CallPlaceholderField
UNSPECIFIED 
UNKNOWN
PHONE_NUMBER
COUNTRY_CODE
TRACKED
CONVERSION_TYPE_ID
CONVERSION_REPORTING_STATEB�
!com.google.ads.googleads.v9.enumsBCallPlaceholderFieldProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v9/enums;enums�GAA�Google.Ads.GoogleAds.V9.Enums�Google\\Ads\\GoogleAds\\V9\\Enums�!Google::Ads::GoogleAds::V9::Enumsbproto3'
        , true);
        static::$is_initialized = true;
    }
}

