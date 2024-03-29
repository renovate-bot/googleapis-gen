<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v9/services/video_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V9\Services;

class VideoService
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
        \GPBMetadata\Google\Api\Client::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
-google/ads/googleads/v9/resources/video.proto!google.ads.googleads.v9.resourcesgoogle/api/resource.protogoogle/api/annotations.proto"�
Video=
resource_name (	B&�A�A 
googleads.googleapis.com/Video
id (	B�AH �

channel_id (	B�AH�!
duration_millis (B�AH�
title	 (	B�AH�:N�AK
googleads.googleapis.com/Video)customers/{customer_id}/videos/{video_id}B
_idB
_channel_idB
_duration_millisB
_titleB�
%com.google.ads.googleads.v9.resourcesB
VideoProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v9/resources;resources�GAA�!Google.Ads.GoogleAds.V9.Resources�!Google\\Ads\\GoogleAds\\V9\\Resources�%Google::Ads::GoogleAds::V9::Resourcesbproto3
�
4google/ads/googleads/v9/services/video_service.proto google.ads.googleads.v9.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto"P
GetVideoRequest=
resource_name (	B&�A�A 
googleads.googleapis.com/Video2�
VideoService�
GetVideo1.google.ads.googleads.v9.services.GetVideoRequest(.google.ads.googleads.v9.resources.Video"@���*(/v9/{resource_name=customers/*/videos/*}�Aresource_nameE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v9.servicesBVideoServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v9/services;services�GAA� Google.Ads.GoogleAds.V9.Services� Google\\Ads\\GoogleAds\\V9\\Services�$Google::Ads::GoogleAds::V9::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

