<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v5/services/billing_setup_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V5\Services;

class BillingSetupService
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
        \GPBMetadata\Google\Api\Client::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
8google/ads/googleads/v5/enums/billing_setup_status.protogoogle.ads.googleads.v5.enums"�
BillingSetupStatusEnum"o
BillingSetupStatus
UNSPECIFIED 
UNKNOWN
PENDING
APPROVED_HELD
APPROVED
	CANCELLEDB�
!com.google.ads.googleads.v5.enumsBBillingSetupStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
-google/ads/googleads/v5/enums/time_type.protogoogle.ads.googleads.v5.enums"N
TimeTypeEnum">
TimeType
UNSPECIFIED 
UNKNOWN
NOW
FOREVERB�
!com.google.ads.googleads.v5.enumsBTimeTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
5google/ads/googleads/v5/resources/billing_setup.proto!google.ads.googleads.v5.resources-google/ads/googleads/v5/enums/time_type.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�	
BillingSetupD
resource_name (	B-�A�A\'
%googleads.googleapis.com/BillingSetup,
id (2.google.protobuf.Int64ValueB�A]
status (2H.google.ads.googleads.v5.enums.BillingSetupStatusEnum.BillingSetupStatusB�Ah
payments_account (2.google.protobuf.StringValueB0�A�A*
(googleads.googleapis.com/PaymentsAccountg
payments_account_info (2C.google.ads.googleads.v5.resources.BillingSetup.PaymentsAccountInfoB�A<
start_date_time	 (2.google.protobuf.StringValueB�AH T
start_time_type
 (24.google.ads.googleads.v5.enums.TimeTypeEnum.TimeTypeB�AH :
end_date_time (2.google.protobuf.StringValueB�AHR
end_time_type (24.google.ads.googleads.v5.enums.TimeTypeEnum.TimeTypeB�AH�
PaymentsAccountInfo>
payments_account_id (2.google.protobuf.StringValueB�A@
payments_account_name (2.google.protobuf.StringValueB�A>
payments_profile_id (2.google.protobuf.StringValueB�A@
payments_profile_name (2.google.protobuf.StringValueB�AH
secondary_payments_profile_id (2.google.protobuf.StringValueB�A:^�A[
%googleads.googleapis.com/BillingSetup2customers/{customer}/billingSetups/{billing_setup}B

start_timeB

end_timeB�
%com.google.ads.googleads.v5.resourcesBBillingSetupProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v5/resources;resources�GAA�!Google.Ads.GoogleAds.V5.Resources�!Google\\Ads\\GoogleAds\\V5\\Resources�%Google::Ads::GoogleAds::V5::Resourcesbproto3
�
<google/ads/googleads/v5/services/billing_setup_service.proto google.ads.googleads.v5.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto"^
GetBillingSetupRequestD
resource_name (	B-�A�A\'
%googleads.googleapis.com/BillingSetup"�
MutateBillingSetupRequest
customer_id (	B�AO
	operation (27.google.ads.googleads.v5.services.BillingSetupOperationB�A"y
BillingSetupOperationA
create (2/.google.ads.googleads.v5.resources.BillingSetupH 
remove (	H B
	operation"h
MutateBillingSetupResponseJ
result (2:.google.ads.googleads.v5.services.MutateBillingSetupResult"1
MutateBillingSetupResult
resource_name (	2�
BillingSetupService�
GetBillingSetup8.google.ads.googleads.v5.services.GetBillingSetupRequest/.google.ads.googleads.v5.resources.BillingSetup"G���1//v5/{resource_name=customers/*/billingSetups/*}�Aresource_name�
MutateBillingSetup;.google.ads.googleads.v5.services.MutateBillingSetupRequest<.google.ads.googleads.v5.services.MutateBillingSetupResponse"U���7"2/v5/customers/{customer_id=*}/billingSetups:mutate:*�Acustomer_id,operationE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v5.servicesBBillingSetupServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v5/services;services�GAA� Google.Ads.GoogleAds.V5.Services� Google\\Ads\\GoogleAds\\V5\\Services�$Google::Ads::GoogleAds::V5::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

