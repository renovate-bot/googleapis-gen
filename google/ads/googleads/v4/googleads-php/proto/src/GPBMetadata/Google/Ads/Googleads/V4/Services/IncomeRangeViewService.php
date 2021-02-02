<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v4/services/income_range_view_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V4\Services;

class IncomeRangeViewService
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
        \GPBMetadata\Google\Api\Client::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
9google/ads/googleads/v4/resources/income_range_view.proto!google.ads.googleads.v4.resourcesgoogle/api/resource.protogoogle/api/annotations.proto"�
IncomeRangeViewG
resource_name (	B0�A�A*
(googleads.googleapis.com/IncomeRangeView:h�Ae
(googleads.googleapis.com/IncomeRangeView9customers/{customer}/incomeRangeViews/{income_range_view}B�
%com.google.ads.googleads.v4.resourcesBIncomeRangeViewProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v4/resources;resources�GAA�!Google.Ads.GoogleAds.V4.Resources�!Google\\Ads\\GoogleAds\\V4\\Resources�%Google::Ads::GoogleAds::V4::Resourcesbproto3
�
@google/ads/googleads/v4/services/income_range_view_service.proto google.ads.googleads.v4.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto"d
GetIncomeRangeViewRequestG
resource_name (	B0�A�A*
(googleads.googleapis.com/IncomeRangeView2�
IncomeRangeViewService�
GetIncomeRangeView;.google.ads.googleads.v4.services.GetIncomeRangeViewRequest2.google.ads.googleads.v4.resources.IncomeRangeView"J���42/v4/{resource_name=customers/*/incomeRangeViews/*}�Aresource_nameE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v4.servicesBIncomeRangeViewServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v4/services;services�GAA� Google.Ads.GoogleAds.V4.Services� Google\\Ads\\GoogleAds\\V4\\Services�$Google::Ads::GoogleAds::V4::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

