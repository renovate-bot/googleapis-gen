<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v3/services/mobile_app_category_constant_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V3\Services;

class MobileAppCategoryConstantService
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
        \GPBMetadata\Google\Api\Client::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
Dgoogle/ads/googleads/v3/resources/mobile_app_category_constant.proto!google.ads.googleads.v3.resourcesgoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
MobileAppCategoryConstantQ
resource_name (	B:�A�A4
2googleads.googleapis.com/MobileAppCategoryConstant,
id (2.google.protobuf.Int32ValueB�A/
name (2.google.protobuf.StringValueB�A:r�Ao
2googleads.googleapis.com/MobileAppCategoryConstant9mobileAppCategoryConstants/{mobile_app_category_constant}B�
%com.google.ads.googleads.v3.resourcesBMobileAppCategoryConstantProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v3/resources;resources�GAA�!Google.Ads.GoogleAds.V3.Resources�!Google\\Ads\\GoogleAds\\V3\\Resources�%Google::Ads::GoogleAds::V3::Resourcesbproto3
�
Kgoogle/ads/googleads/v3/services/mobile_app_category_constant_service.proto google.ads.googleads.v3.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto"x
#GetMobileAppCategoryConstantRequestQ
resource_name (	B:�A�A4
2googleads.googleapis.com/MobileAppCategoryConstant2�
 MobileAppCategoryConstantService�
GetMobileAppCategoryConstantE.google.ads.googleads.v3.services.GetMobileAppCategoryConstantRequest<.google.ads.googleads.v3.resources.MobileAppCategoryConstant"H���20/v3/{resource_name=mobileAppCategoryConstants/*}�Aresource_nameE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v3.servicesB%MobileAppCategoryConstantServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v3/services;services�GAA� Google.Ads.GoogleAds.V3.Services� Google\\Ads\\GoogleAds\\V3\\Services�$Google::Ads::GoogleAds::V3::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

