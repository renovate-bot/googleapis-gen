<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v6/resources/customer_label.proto

namespace GPBMetadata\Google\Ads\Googleads\V6\Resources;

class CustomerLabel
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();
        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Http::initOnce();
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
6google/ads/googleads/v6/resources/customer_label.proto!google.ads.googleads.v6.resourcesgoogle/api/resource.protogoogle/api/annotations.proto"�
CustomerLabelE
resource_name (	B.�A�A(
&googleads.googleapis.com/CustomerLabel
customer (	B�AH �
label (	B�AH�:^�A[
&googleads.googleapis.com/CustomerLabel1customers/{customer_id}/customerLabels/{label_id}B
	_customerB
_labelB�
%com.google.ads.googleads.v6.resourcesBCustomerLabelProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v6/resources;resources�GAA�!Google.Ads.GoogleAds.V6.Resources�!Google\\Ads\\GoogleAds\\V6\\Resources�%Google::Ads::GoogleAds::V6::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

