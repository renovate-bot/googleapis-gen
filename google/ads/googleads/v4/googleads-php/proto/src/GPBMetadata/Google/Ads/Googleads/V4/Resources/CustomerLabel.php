<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v4/resources/customer_label.proto

namespace GPBMetadata\Google\Ads\Googleads\V4\Resources;

class CustomerLabel
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
�
6google/ads/googleads/v4/resources/customer_label.proto!google.ads.googleads.v4.resourcesgoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
CustomerLabelE
resource_name (	B.�A�A(
&googleads.googleapis.com/CustomerLabel3
customer (2.google.protobuf.StringValueB�A0
label (2.google.protobuf.StringValueB�A:a�A^
&googleads.googleapis.com/CustomerLabel4customers/{customer}/customerLabels/{customer_label}B�
%com.google.ads.googleads.v4.resourcesBCustomerLabelProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v4/resources;resources�GAA�!Google.Ads.GoogleAds.V4.Resources�!Google\\Ads\\GoogleAds\\V4\\Resources�%Google::Ads::GoogleAds::V4::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

