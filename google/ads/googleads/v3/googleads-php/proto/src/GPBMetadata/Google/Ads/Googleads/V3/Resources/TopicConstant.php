<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v3/resources/topic_constant.proto

namespace GPBMetadata\Google\Ads\Googleads\V3\Resources;

class TopicConstant
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
        $pool->internalAddGeneratedFile(
            '
�
6google/ads/googleads/v3/resources/topic_constant.proto!google.ads.googleads.v3.resourcesgoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
TopicConstantE
resource_name (	B.�A�A(
&googleads.googleapis.com/TopicConstant,
id (2.google.protobuf.Int64ValueB�Ak
topic_constant_parent (2.google.protobuf.StringValueB.�A�A(
&googleads.googleapis.com/TopicConstant/
path (2.google.protobuf.StringValueB�A:L�AI
&googleads.googleapis.com/TopicConstanttopicConstants/{topic_constant}B�
%com.google.ads.googleads.v3.resourcesBTopicConstantProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v3/resources;resources�GAA�!Google.Ads.GoogleAds.V3.Resources�!Google\\Ads\\GoogleAds\\V3\\Resources�%Google::Ads::GoogleAds::V3::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

