<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v5/services/campaign_extension_setting_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V5\Services;

class CampaignExtensionSettingService
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();
        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Http::initOnce();
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Protobuf\Wrappers::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Protobuf\Any::initOnce();
        \GPBMetadata\Google\Rpc\Status::initOnce();
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
�	
Bgoogle/ads/googleads/v5/resources/campaign_extension_setting.proto!google.ads.googleads.v5.resources2google/ads/googleads/v5/enums/extension_type.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
CampaignExtensionSettingP
resource_name (	B9�A�A3
1googleads.googleapis.com/CampaignExtensionSetting[
extension_type (2>.google.ads.googleads.v5.enums.ExtensionTypeEnum.ExtensionTypeB�AY
campaign (2.google.protobuf.StringValueB)�A�A#
!googleads.googleapis.com/Campaignk
extension_feed_items (2.google.protobuf.StringValueB/�A,
*googleads.googleapis.com/ExtensionFeedItem`
device (2P.google.ads.googleads.v5.enums.ExtensionSettingDeviceEnum.ExtensionSettingDevice:��A�
1googleads.googleapis.com/CampaignExtensionSettingKcustomers/{customer}/campaignExtensionSettings/{campaign_extension_setting}B�
%com.google.ads.googleads.v5.resourcesBCampaignExtensionSettingProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v5/resources;resources�GAA�!Google.Ads.GoogleAds.V5.Resources�!Google\\Ads\\GoogleAds\\V5\\Resources�%Google::Ads::GoogleAds::V5::Resourcesbproto3
�
Igoogle/ads/googleads/v5/services/campaign_extension_setting_service.proto google.ads.googleads.v5.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto google/protobuf/field_mask.protogoogle/rpc/status.proto"v
"GetCampaignExtensionSettingRequestP
resource_name (	B9�A�A3
1googleads.googleapis.com/CampaignExtensionSetting"�
&MutateCampaignExtensionSettingsRequest
customer_id (	B�A\\

operations (2C.google.ads.googleads.v5.services.CampaignExtensionSettingOperationB�A
partial_failure (
validate_only ("�
!CampaignExtensionSettingOperation/
update_mask (2.google.protobuf.FieldMaskM
create (2;.google.ads.googleads.v5.resources.CampaignExtensionSettingH M
update (2;.google.ads.googleads.v5.resources.CampaignExtensionSettingH 
remove (	H B
	operation"�
\'MutateCampaignExtensionSettingsResponse1
partial_failure_error (2.google.rpc.StatusW
results (2F.google.ads.googleads.v5.services.MutateCampaignExtensionSettingResult"=
$MutateCampaignExtensionSettingResult
resource_name (	2�
CampaignExtensionSettingService�
GetCampaignExtensionSettingD.google.ads.googleads.v5.services.GetCampaignExtensionSettingRequest;.google.ads.googleads.v5.resources.CampaignExtensionSetting"S���=;/v5/{resource_name=customers/*/campaignExtensionSettings/*}�Aresource_name�
MutateCampaignExtensionSettingsH.google.ads.googleads.v5.services.MutateCampaignExtensionSettingsRequestI.google.ads.googleads.v5.services.MutateCampaignExtensionSettingsResponse"b���C">/v5/customers/{customer_id=*}/campaignExtensionSettings:mutate:*�Acustomer_id,operationsE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v5.servicesB$CampaignExtensionSettingServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v5/services;services�GAA� Google.Ads.GoogleAds.V5.Services� Google\\Ads\\GoogleAds\\V5\\Services�$Google::Ads::GoogleAds::V5::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

