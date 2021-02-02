<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v4/services/account_link_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V4\Services;

class AccountLinkService
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
        \GPBMetadata\Google\Api\Client::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
7google/ads/googleads/v4/enums/account_link_status.protogoogle.ads.googleads.v4.enums"d
AccountLinkStatusEnum"K
AccountLinkStatus
UNSPECIFIED 
UNKNOWN
ENABLED
REMOVEDB�
!com.google.ads.googleads.v4.enumsBAccountLinkStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v4/enums;enums�GAA�Google.Ads.GoogleAds.V4.Enums�Google\\Ads\\GoogleAds\\V4\\Enums�!Google::Ads::GoogleAds::V4::Enumsbproto3
�
7google/ads/googleads/v4/enums/linked_account_type.protogoogle.ads.googleads.v4.enums"i
LinkedAccountTypeEnum"P
LinkedAccountType
UNSPECIFIED 
UNKNOWN
THIRD_PARTY_APP_ANALYTICSB�
!com.google.ads.googleads.v4.enumsBLinkedAccountTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v4/enums;enums�GAA�Google.Ads.GoogleAds.V4.Enums�Google\\Ads\\GoogleAds\\V4\\Enums�!Google::Ads::GoogleAds::V4::Enumsbproto3
�
5google/ads/googleads/v4/enums/mobile_app_vendor.protogoogle.ads.googleads.v4.enums"q
MobileAppVendorEnum"Z
MobileAppVendor
UNSPECIFIED 
UNKNOWN
APPLE_APP_STORE
GOOGLE_APP_STOREB�
!com.google.ads.googleads.v4.enumsBMobileAppVendorProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v4/enums;enums�GAA�Google.Ads.GoogleAds.V4.Enums�Google\\Ads\\GoogleAds\\V4\\Enums�!Google::Ads::GoogleAds::V4::Enumsbproto3
�

4google/ads/googleads/v4/resources/account_link.proto!google.ads.googleads.v4.resources7google/ads/googleads/v4/enums/linked_account_type.proto5google/ads/googleads/v4/enums/mobile_app_vendor.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
AccountLinkC
resource_name (	B,�A�A&
$googleads.googleapis.com/AccountLink9
account_link_id (2.google.protobuf.Int64ValueB�AV
status (2F.google.ads.googleads.v4.enums.AccountLinkStatusEnum.AccountLinkStatusY
type (2F.google.ads.googleads.v4.enums.LinkedAccountTypeEnum.LinkedAccountTypeB�Aq
third_party_app_analytics (2G.google.ads.googleads.v4.resources.ThirdPartyAppAnalyticsLinkIdentifierB�AH :[�AX
$googleads.googleapis.com/AccountLink0customers/{customer}/accountLinks/{account_link}B
linked_account"�
$ThirdPartyAppAnalyticsLinkIdentifierC
app_analytics_provider_id (2.google.protobuf.Int64ValueB�A1
app_id (2.google.protobuf.StringValueB�A[

app_vendor (2B.google.ads.googleads.v4.enums.MobileAppVendorEnum.MobileAppVendorB�AB�
%com.google.ads.googleads.v4.resourcesBAccountLinkProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v4/resources;resources�GAA�!Google.Ads.GoogleAds.V4.Resources�!Google\\Ads\\GoogleAds\\V4\\Resources�%Google::Ads::GoogleAds::V4::Resourcesbproto3
�
;google/ads/googleads/v4/services/account_link_service.proto google.ads.googleads.v4.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto"\\
GetAccountLinkRequestC
resource_name (	B,�A�A&
$googleads.googleapis.com/AccountLink"�
MutateAccountLinkRequest
customer_id (	B�AN
	operation (26.google.ads.googleads.v4.services.AccountLinkOperationB�A
partial_failure (
validate_only ("w
AccountLinkOperation@
create (2..google.ads.googleads.v4.resources.AccountLinkH 
remove (	H B
	operation"f
MutateAccountLinkResponseI
result (29.google.ads.googleads.v4.services.MutateAccountLinkResult"0
MutateAccountLinkResult
resource_name (	2�
AccountLinkService�
GetAccountLink7.google.ads.googleads.v4.services.GetAccountLinkRequest..google.ads.googleads.v4.resources.AccountLink"F���0./v4/{resource_name=customers/*/accountLinks/*}�Aresource_name�
MutateAccountLink:.google.ads.googleads.v4.services.MutateAccountLinkRequest;.google.ads.googleads.v4.services.MutateAccountLinkResponse"T���6"1/v4/customers/{customer_id=*}/accountLinks:mutate:*�Acustomer_id,operationE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v4.servicesBAccountLinkServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v4/services;services�GAA� Google.Ads.GoogleAds.V4.Services� Google\\Ads\\GoogleAds\\V4\\Services�$Google::Ads::GoogleAds::V4::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

