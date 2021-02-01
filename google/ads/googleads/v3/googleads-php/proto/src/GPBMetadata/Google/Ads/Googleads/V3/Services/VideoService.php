<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v3/services/video_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V3\Services;

class VideoService
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();
        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Protobuf\Wrappers::initOnce();
        \GPBMetadata\Google\Api\Http::initOnce();
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
-google/ads/googleads/v3/resources/video.proto!google.ads.googleads.v3.resourcesgoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
Video=
resource_name (	B&�A�A 
googleads.googleapis.com/Video-
id (2.google.protobuf.StringValueB�A5

channel_id (2.google.protobuf.StringValueB�A9
duration_millis (2.google.protobuf.Int64ValueB�A0
title (2.google.protobuf.StringValueB�A:H�AE
googleads.googleapis.com/Video#customers/{customer}/videos/{video}B�
%com.google.ads.googleads.v3.resourcesB
VideoProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v3/resources;resources�GAA�!Google.Ads.GoogleAds.V3.Resources�!Google\\Ads\\GoogleAds\\V3\\Resources�%Google::Ads::GoogleAds::V3::Resourcesbproto3
�
4google/ads/googleads/v3/services/video_service.proto google.ads.googleads.v3.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto"P
GetVideoRequest=
resource_name (	B&�A�A 
googleads.googleapis.com/Video2�
VideoService�
GetVideo1.google.ads.googleads.v3.services.GetVideoRequest(.google.ads.googleads.v3.resources.Video"@���*(/v3/{resource_name=customers/*/videos/*}�Aresource_nameE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v3.servicesBVideoServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v3/services;services�GAA� Google.Ads.GoogleAds.V3.Services� Google\\Ads\\GoogleAds\\V3\\Services�$Google::Ads::GoogleAds::V3::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

