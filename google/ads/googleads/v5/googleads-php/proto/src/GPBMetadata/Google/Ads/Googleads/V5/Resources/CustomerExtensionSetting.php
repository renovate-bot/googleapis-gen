<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v5/resources/customer_extension_setting.proto

namespace GPBMetadata\Google\Ads\Googleads\V5\Resources;

class CustomerExtensionSetting
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
        \GPBMetadata\Google\Protobuf\Wrappers::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
<google/ads/googleads/v5/enums/extension_setting_device.protogoogle.ads.googleads.v5.enums"m
ExtensionSettingDeviceEnum"O
ExtensionSettingDevice
UNSPECIFIED 
UNKNOWN

MOBILE
DESKTOPB�
!com.google.ads.googleads.v5.enumsBExtensionSettingDeviceProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
2google/ads/googleads/v5/enums/extension_type.protogoogle.ads.googleads.v5.enums"�
ExtensionTypeEnum"�
ExtensionType
UNSPECIFIED 
UNKNOWN
NONE
APP
CALL
CALLOUT
MESSAGE	
PRICE
	PROMOTION
SITELINK

STRUCTURED_SNIPPET
LOCATION
AFFILIATE_LOCATION
HOTEL_CALLOUTB�
!com.google.ads.googleads.v5.enumsBExtensionTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
Bgoogle/ads/googleads/v5/resources/customer_extension_setting.proto!google.ads.googleads.v5.resources2google/ads/googleads/v5/enums/extension_type.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
CustomerExtensionSettingP
resource_name (	B9�A�A3
1googleads.googleapis.com/CustomerExtensionSetting[
extension_type (2>.google.ads.googleads.v5.enums.ExtensionTypeEnum.ExtensionTypeB�Ak
extension_feed_items (2.google.protobuf.StringValueB/�A,
*googleads.googleapis.com/ExtensionFeedItem`
device (2P.google.ads.googleads.v5.enums.ExtensionSettingDeviceEnum.ExtensionSettingDevice:��A�
1googleads.googleapis.com/CustomerExtensionSettingKcustomers/{customer}/customerExtensionSettings/{customer_extension_setting}B�
%com.google.ads.googleads.v5.resourcesBCustomerExtensionSettingProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v5/resources;resources�GAA�!Google.Ads.GoogleAds.V5.Resources�!Google\\Ads\\GoogleAds\\V5\\Resources�%Google::Ads::GoogleAds::V5::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

