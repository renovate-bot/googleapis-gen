<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v9/enums/video_thumbnail.proto

namespace GPBMetadata\Google\Ads\Googleads\V9\Enums;

class VideoThumbnail
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
3google/ads/googleads/v9/enums/video_thumbnail.protogoogle.ads.googleads.v9.enums"�
VideoThumbnailEnum"x
VideoThumbnail
UNSPECIFIED 
UNKNOWN
DEFAULT_THUMBNAIL
THUMBNAIL_1
THUMBNAIL_2
THUMBNAIL_3B�
!com.google.ads.googleads.v9.enumsBVideoThumbnailProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v9/enums;enums�GAA�Google.Ads.GoogleAds.V9.Enums�Google\\Ads\\GoogleAds\\V9\\Enums�!Google::Ads::GoogleAds::V9::Enumsbproto3'
        , true);
        static::$is_initialized = true;
    }
}

