<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v6/resources/ad_group_label.proto

namespace GPBMetadata\Google\Ads\Googleads\V6\Resources;

class AdGroupLabel
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
6google/ads/googleads/v6/resources/ad_group_label.proto!google.ads.googleads.v6.resourcesgoogle/api/resource.protogoogle/api/annotations.proto"�
AdGroupLabelD
resource_name (	B-�A�A\'
%googleads.googleapis.com/AdGroupLabel?
ad_group (	B(�A�A"
 googleads.googleapis.com/AdGroupH �:
label (	B&�A�A 
googleads.googleapis.com/LabelH�:j�Ag
%googleads.googleapis.com/AdGroupLabel>customers/{customer_id}/adGroupLabels/{ad_group_id}~{label_id}B
	_ad_groupB
_labelB�
%com.google.ads.googleads.v6.resourcesBAdGroupLabelProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v6/resources;resources�GAA�!Google.Ads.GoogleAds.V6.Resources�!Google\\Ads\\GoogleAds\\V6\\Resources�%Google::Ads::GoogleAds::V6::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

