<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v3/resources/carrier_constant.proto

namespace GPBMetadata\Google\Ads\Googleads\V3\Resources;

class CarrierConstant
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
8google/ads/googleads/v3/resources/carrier_constant.proto!google.ads.googleads.v3.resourcesgoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
CarrierConstantG
resource_name (	B0�A�A*
(googleads.googleapis.com/CarrierConstant,
id (2.google.protobuf.Int64ValueB�A/
name (2.google.protobuf.StringValueB�A7
country_code (2.google.protobuf.StringValueB�A:R�AO
(googleads.googleapis.com/CarrierConstant#carrierConstants/{carrier_constant}B�
%com.google.ads.googleads.v3.resourcesBCarrierConstantProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v3/resources;resources�GAA�!Google.Ads.GoogleAds.V3.Resources�!Google\\Ads\\GoogleAds\\V3\\Resources�%Google::Ads::GoogleAds::V3::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

