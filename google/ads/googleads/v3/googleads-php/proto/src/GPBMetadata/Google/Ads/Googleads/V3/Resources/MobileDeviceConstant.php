<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v3/resources/mobile_device_constant.proto

namespace GPBMetadata\Google\Ads\Googleads\V3\Resources;

class MobileDeviceConstant
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
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
6google/ads/googleads/v3/enums/mobile_device_type.protogoogle.ads.googleads.v3.enums"`
MobileDeviceTypeEnum"H
MobileDeviceType
UNSPECIFIED 
UNKNOWN

MOBILE

TABLETB�
!com.google.ads.googleads.v3.enumsBMobileDeviceTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
>google/ads/googleads/v3/resources/mobile_device_constant.proto!google.ads.googleads.v3.resourcesgoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
MobileDeviceConstantL
resource_name (	B5�A�A/
-googleads.googleapis.com/MobileDeviceConstant,
id (2.google.protobuf.Int64ValueB�A/
name (2.google.protobuf.StringValueB�A<
manufacturer_name (2.google.protobuf.StringValueB�A@
operating_system_name (2.google.protobuf.StringValueB�AW
type (2D.google.ads.googleads.v3.enums.MobileDeviceTypeEnum.MobileDeviceTypeB�A:b�A_
-googleads.googleapis.com/MobileDeviceConstant.mobileDeviceConstants/{mobile_device_constant}B�
%com.google.ads.googleads.v3.resourcesBMobileDeviceConstantProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v3/resources;resources�GAA�!Google.Ads.GoogleAds.V3.Resources�!Google\\Ads\\GoogleAds\\V3\\Resources�%Google::Ads::GoogleAds::V3::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

