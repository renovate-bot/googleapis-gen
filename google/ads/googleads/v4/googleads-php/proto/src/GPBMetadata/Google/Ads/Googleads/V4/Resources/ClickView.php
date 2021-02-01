<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v4/resources/click_view.proto

namespace GPBMetadata\Google\Ads\Googleads\V4\Resources;

class ClickView
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
        $pool->internalAddGeneratedFile(
            '
�
3google/ads/googleads/v4/common/click_location.protogoogle.ads.googleads.v4.commongoogle/api/annotations.proto"�
ClickLocation*
city (2.google.protobuf.StringValue-
country (2.google.protobuf.StringValue+
metro (2.google.protobuf.StringValue3
most_specific (2.google.protobuf.StringValue,
region (2.google.protobuf.StringValueB�
"com.google.ads.googleads.v4.commonBClickLocationProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v4/common;common�GAA�Google.Ads.GoogleAds.V4.Common�Google\\Ads\\GoogleAds\\V4\\Common�"Google::Ads::GoogleAds::V4::Commonbproto3
�
2google/ads/googleads/v4/resources/click_view.proto!google.ads.googleads.v4.resourcesgoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
	ClickViewA
resource_name (	B*�A�A$
"googleads.googleapis.com/ClickView0
gclid (2.google.protobuf.StringValueB�AL
area_of_interest (2-.google.ads.googleads.v4.common.ClickLocationB�AP
location_of_presence (2-.google.ads.googleads.v4.common.ClickLocationB�A5
page_number (2.google.protobuf.Int64ValueB�A]
ad_group_ad (2.google.protobuf.StringValueB*�A�A$
"googleads.googleapis.com/AdGroupAd:U�AR
"googleads.googleapis.com/ClickView,customers/{customer}/clickViews/{click_view}B�
%com.google.ads.googleads.v4.resourcesBClickViewProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v4/resources;resources�GAA�!Google.Ads.GoogleAds.V4.Resources�!Google\\Ads\\GoogleAds\\V4\\Resources�%Google::Ads::GoogleAds::V4::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

