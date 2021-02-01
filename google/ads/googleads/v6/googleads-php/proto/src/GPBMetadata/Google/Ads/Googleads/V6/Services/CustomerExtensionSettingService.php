<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v6/services/customer_extension_setting_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V6\Services;

class CustomerExtensionSettingService
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();
        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Http::initOnce();
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Protobuf\Any::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        \GPBMetadata\Google\Rpc\Status::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
<google/ads/googleads/v6/enums/extension_setting_device.protogoogle.ads.googleads.v6.enums"m
ExtensionSettingDeviceEnum"O
ExtensionSettingDevice
UNSPECIFIED 
UNKNOWN

MOBILE
DESKTOPB�
!com.google.ads.googleads.v6.enumsBExtensionSettingDeviceProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
2google/ads/googleads/v6/enums/extension_type.protogoogle.ads.googleads.v6.enums"�
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
HOTEL_CALLOUT	
IMAGEB�
!com.google.ads.googleads.v6.enumsBExtensionTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
Bgoogle/ads/googleads/v6/resources/customer_extension_setting.proto!google.ads.googleads.v6.resources2google/ads/googleads/v6/enums/extension_type.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/api/annotations.proto"�
CustomerExtensionSettingP
resource_name (	B9�A�A3
1googleads.googleapis.com/CustomerExtensionSetting[
extension_type (2>.google.ads.googleads.v6.enums.ExtensionTypeEnum.ExtensionTypeB�AM
extension_feed_items (	B/�A,
*googleads.googleapis.com/ExtensionFeedItem`
device (2P.google.ads.googleads.v6.enums.ExtensionSettingDeviceEnum.ExtensionSettingDevice:z�Aw
1googleads.googleapis.com/CustomerExtensionSettingBcustomers/{customer_id}/customerExtensionSettings/{extension_type}B�
%com.google.ads.googleads.v6.resourcesBCustomerExtensionSettingProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v6/resources;resources�GAA�!Google.Ads.GoogleAds.V6.Resources�!Google\\Ads\\GoogleAds\\V6\\Resources�%Google::Ads::GoogleAds::V6::Resourcesbproto3
�
Igoogle/ads/googleads/v6/services/customer_extension_setting_service.proto google.ads.googleads.v6.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto google/protobuf/field_mask.protogoogle/rpc/status.proto"v
"GetCustomerExtensionSettingRequestP
resource_name (	B9�A�A3
1googleads.googleapis.com/CustomerExtensionSetting"�
&MutateCustomerExtensionSettingsRequest
customer_id (	B�A\\

operations (2C.google.ads.googleads.v6.services.CustomerExtensionSettingOperationB�A
partial_failure (
validate_only ("�
!CustomerExtensionSettingOperation/
update_mask (2.google.protobuf.FieldMaskM
create (2;.google.ads.googleads.v6.resources.CustomerExtensionSettingH M
update (2;.google.ads.googleads.v6.resources.CustomerExtensionSettingH 
remove (	H B
	operation"�
\'MutateCustomerExtensionSettingsResponse1
partial_failure_error (2.google.rpc.StatusW
results (2F.google.ads.googleads.v6.services.MutateCustomerExtensionSettingResult"=
$MutateCustomerExtensionSettingResult
resource_name (	2�
CustomerExtensionSettingService�
GetCustomerExtensionSettingD.google.ads.googleads.v6.services.GetCustomerExtensionSettingRequest;.google.ads.googleads.v6.resources.CustomerExtensionSetting"S���=;/v6/{resource_name=customers/*/customerExtensionSettings/*}�Aresource_name�
MutateCustomerExtensionSettingsH.google.ads.googleads.v6.services.MutateCustomerExtensionSettingsRequestI.google.ads.googleads.v6.services.MutateCustomerExtensionSettingsResponse"b���C">/v6/customers/{customer_id=*}/customerExtensionSettings:mutate:*�Acustomer_id,operationsE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v6.servicesB$CustomerExtensionSettingServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v6/services;services�GAA� Google.Ads.GoogleAds.V6.Services� Google\\Ads\\GoogleAds\\V6\\Services�$Google::Ads::GoogleAds::V6::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

