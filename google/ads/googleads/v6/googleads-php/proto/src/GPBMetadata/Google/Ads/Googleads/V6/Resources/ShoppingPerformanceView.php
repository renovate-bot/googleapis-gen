<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v6/resources/shopping_performance_view.proto

namespace GPBMetadata\Google\Ads\Googleads\V6\Resources;

class ShoppingPerformanceView
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
�
Agoogle/ads/googleads/v6/resources/shopping_performance_view.proto!google.ads.googleads.v6.resourcesgoogle/api/resource.protogoogle/api/annotations.proto"�
ShoppingPerformanceViewO
resource_name (	B8�A�A2
0googleads.googleapis.com/ShoppingPerformanceView:f�Ac
0googleads.googleapis.com/ShoppingPerformanceView/customers/{customer_id}/shoppingPerformanceViewB�
%com.google.ads.googleads.v6.resourcesBShoppingPerformanceViewProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v6/resources;resources�GAA�!Google.Ads.GoogleAds.V6.Resources�!Google\\Ads\\GoogleAds\\V6\\Resources�%Google::Ads::GoogleAds::V6::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

