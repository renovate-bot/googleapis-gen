<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v3/resources/payments_account.proto

namespace GPBMetadata\Google\Ads\Googleads\V3\Resources;

class PaymentsAccount
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
�
8google/ads/googleads/v3/resources/payments_account.proto!google.ads.googleads.v3.resourcesgoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
PaymentsAccountG
resource_name (	B0�A�A*
(googleads.googleapis.com/PaymentsAccount>
payments_account_id (2.google.protobuf.StringValueB�A/
name (2.google.protobuf.StringValueB�A8
currency_code (2.google.protobuf.StringValueB�A>
payments_profile_id (2.google.protobuf.StringValueB�AH
secondary_payments_profile_id (2.google.protobuf.StringValueB�AB
paying_manager_customer (2.google.protobuf.StringValueB�A:g�Ad
(googleads.googleapis.com/PaymentsAccount8customers/{customer}/paymentsAccounts/{payments_account}B�
%com.google.ads.googleads.v3.resourcesBPaymentsAccountProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v3/resources;resources�GAA�!Google.Ads.GoogleAds.V3.Resources�!Google\\Ads\\GoogleAds\\V3\\Resources�%Google::Ads::GoogleAds::V3::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

