<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v5/resources/ad_group_ad_label.proto

namespace GPBMetadata\Google\Ads\Googleads\V5\Resources;

class AdGroupAdLabel
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
�
9google/ads/googleads/v5/resources/ad_group_ad_label.proto!google.ads.googleads.v5.resourcesgoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
AdGroupAdLabelF
resource_name (	B/�A�A)
\'googleads.googleapis.com/AdGroupAdLabel]
ad_group_ad (2.google.protobuf.StringValueB*�A�A$
"googleads.googleapis.com/AdGroupAdS
label (2.google.protobuf.StringValueB&�A�A 
googleads.googleapis.com/Label:f�Ac
\'googleads.googleapis.com/AdGroupAdLabel8customers/{customer}/adGroupAdLabels/{ad_group_ad_label}B�
%com.google.ads.googleads.v5.resourcesBAdGroupAdLabelProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v5/resources;resources�GAA�!Google.Ads.GoogleAds.V5.Resources�!Google\\Ads\\GoogleAds\\V5\\Resources�%Google::Ads::GoogleAds::V5::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

