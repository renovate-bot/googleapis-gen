<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v8/enums/app_campaign_app_store.proto

namespace GPBMetadata\Google\Ads\Googleads\V8\Enums;

class AppCampaignAppStore
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
�
:google/ads/googleads/v8/enums/app_campaign_app_store.protogoogle.ads.googleads.v8.enums"y
AppCampaignAppStoreEnum"^
AppCampaignAppStore
UNSPECIFIED 
UNKNOWN
APPLE_APP_STORE
GOOGLE_APP_STOREB�
!com.google.ads.googleads.v8.enumsBAppCampaignAppStoreProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v8/enums;enums�GAA�Google.Ads.GoogleAds.V8.Enums�Google\\Ads\\GoogleAds\\V8\\Enums�!Google::Ads::GoogleAds::V8::Enumsbproto3'
        , true);
        static::$is_initialized = true;
    }
}

