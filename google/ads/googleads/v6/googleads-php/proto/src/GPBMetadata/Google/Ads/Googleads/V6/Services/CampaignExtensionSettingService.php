<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v6/services/campaign_extension_setting_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V6\Services;

class CampaignExtensionSettingService
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
Bgoogle/ads/googleads/v6/resources/campaign_extension_setting.proto!google.ads.googleads.v6.resources2google/ads/googleads/v6/enums/extension_type.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/api/annotations.proto"�
CampaignExtensionSettingP
resource_name (	B9�A�A3
1googleads.googleapis.com/CampaignExtensionSetting[
extension_type (2>.google.ads.googleads.v6.enums.ExtensionTypeEnum.ExtensionTypeB�A@
campaign (	B)�A�A#
!googleads.googleapis.com/CampaignH �M
extension_feed_items (	B/�A,
*googleads.googleapis.com/ExtensionFeedItem`
device (2P.google.ads.googleads.v6.enums.ExtensionSettingDeviceEnum.ExtensionSettingDevice:��A�
1googleads.googleapis.com/CampaignExtensionSettingPcustomers/{customer_id}/campaignExtensionSettings/{campaign_id}~{extension_type}B
	_campaignB�
%com.google.ads.googleads.v6.resourcesBCampaignExtensionSettingProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v6/resources;resources�GAA�!Google.Ads.GoogleAds.V6.Resources�!Google\\Ads\\GoogleAds\\V6\\Resources�%Google::Ads::GoogleAds::V6::Resourcesbproto3
�
Igoogle/ads/googleads/v6/services/campaign_extension_setting_service.proto google.ads.googleads.v6.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto google/protobuf/field_mask.protogoogle/rpc/status.proto"v
"GetCampaignExtensionSettingRequestP
resource_name (	B9�A�A3
1googleads.googleapis.com/CampaignExtensionSetting"�
&MutateCampaignExtensionSettingsRequest
customer_id (	B�A\\

operations (2C.google.ads.googleads.v6.services.CampaignExtensionSettingOperationB�A
partial_failure (
validate_only ("�
!CampaignExtensionSettingOperation/
update_mask (2.google.protobuf.FieldMaskM
create (2;.google.ads.googleads.v6.resources.CampaignExtensionSettingH M
update (2;.google.ads.googleads.v6.resources.CampaignExtensionSettingH 
remove (	H B
	operation"�
\'MutateCampaignExtensionSettingsResponse1
partial_failure_error (2.google.rpc.StatusW
results (2F.google.ads.googleads.v6.services.MutateCampaignExtensionSettingResult"=
$MutateCampaignExtensionSettingResult
resource_name (	2�
CampaignExtensionSettingService�
GetCampaignExtensionSettingD.google.ads.googleads.v6.services.GetCampaignExtensionSettingRequest;.google.ads.googleads.v6.resources.CampaignExtensionSetting"S���=;/v6/{resource_name=customers/*/campaignExtensionSettings/*}�Aresource_name�
MutateCampaignExtensionSettingsH.google.ads.googleads.v6.services.MutateCampaignExtensionSettingsRequestI.google.ads.googleads.v6.services.MutateCampaignExtensionSettingsResponse"b���C">/v6/customers/{customer_id=*}/campaignExtensionSettings:mutate:*�Acustomer_id,operationsE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v6.servicesB$CampaignExtensionSettingServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v6/services;services�GAA� Google.Ads.GoogleAds.V6.Services� Google\\Ads\\GoogleAds\\V6\\Services�$Google::Ads::GoogleAds::V6::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

