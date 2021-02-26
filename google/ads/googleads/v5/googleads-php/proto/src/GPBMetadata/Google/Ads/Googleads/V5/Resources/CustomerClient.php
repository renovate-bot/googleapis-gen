<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v5/resources/customer_client.proto

namespace GPBMetadata\Google\Ads\Googleads\V5\Resources;

class CustomerClient
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
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        $pool->internalAddGeneratedFile(
            '
�	
7google/ads/googleads/v5/resources/customer_client.proto!google.ads.googleads.v5.resourcesgoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
CustomerClientF
resource_name (	B/�A�A)
\'googleads.googleapis.com/CustomerClient`
client_customer (2.google.protobuf.StringValueB)�A�A#
!googleads.googleapis.com/Customer/
hidden (2.google.protobuf.BoolValueB�A/
level (2.google.protobuf.Int64ValueB�A4
	time_zone (2.google.protobuf.StringValueB�A5
test_account (2.google.protobuf.BoolValueB�A0
manager (2.google.protobuf.BoolValueB�A;
descriptive_name	 (2.google.protobuf.StringValueB�A8
currency_code
 (2.google.protobuf.StringValueB�A,
id (2.google.protobuf.Int64ValueB�A:d�Aa
\'googleads.googleapis.com/CustomerClient6customers/{customer}/customerClients/{customer_client}B�
%com.google.ads.googleads.v5.resourcesBCustomerClientProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v5/resources;resources�GAA�!Google.Ads.GoogleAds.V5.Resources�!Google\\Ads\\GoogleAds\\V5\\Resources�%Google::Ads::GoogleAds::V5::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

