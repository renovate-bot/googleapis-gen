<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v3/resources/managed_placement_view.proto

namespace GPBMetadata\Google\Ads\Googleads\V3\Resources;

class ManagedPlacementView
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
>google/ads/googleads/v3/resources/managed_placement_view.proto!google.ads.googleads.v3.resourcesgoogle/api/resource.protogoogle/api/annotations.proto"�
ManagedPlacementViewL
resource_name (	B5�A�A/
-googleads.googleapis.com/ManagedPlacementView:w�At
-googleads.googleapis.com/ManagedPlacementViewCcustomers/{customer}/managedPlacementViews/{managed_placement_view}B�
%com.google.ads.googleads.v3.resourcesBManagedPlacementViewProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v3/resources;resources�GAA�!Google.Ads.GoogleAds.V3.Resources�!Google\\Ads\\GoogleAds\\V3\\Resources�%Google::Ads::GoogleAds::V3::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

