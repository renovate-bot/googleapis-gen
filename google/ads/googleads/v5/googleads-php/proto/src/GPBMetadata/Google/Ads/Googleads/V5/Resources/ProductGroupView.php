<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v5/resources/product_group_view.proto

namespace GPBMetadata\Google\Ads\Googleads\V5\Resources;

class ProductGroupView
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
�
:google/ads/googleads/v5/resources/product_group_view.proto!google.ads.googleads.v5.resourcesgoogle/api/resource.protogoogle/api/annotations.proto"�
ProductGroupViewH
resource_name (	B1�A�A+
)googleads.googleapis.com/ProductGroupView:k�Ah
)googleads.googleapis.com/ProductGroupView;customers/{customer}/productGroupViews/{product_group_view}B�
%com.google.ads.googleads.v5.resourcesBProductGroupViewProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v5/resources;resources�GAA�!Google.Ads.GoogleAds.V5.Resources�!Google\\Ads\\GoogleAds\\V5\\Resources�%Google::Ads::GoogleAds::V5::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

