<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v3/resources/product_bidding_category_constant.proto

namespace GPBMetadata\Google\Ads\Googleads\V3\Resources;

class ProductBiddingCategoryConstant
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
�
Bgoogle/ads/googleads/v3/enums/product_bidding_category_level.protogoogle.ads.googleads.v3.enums"�
ProductBiddingCategoryLevelEnum"w
ProductBiddingCategoryLevel
UNSPECIFIED 
UNKNOWN

LEVEL1

LEVEL2

LEVEL3

LEVEL4

LEVEL5B�
!com.google.ads.googleads.v3.enumsB ProductBiddingCategoryLevelProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
Cgoogle/ads/googleads/v3/enums/product_bidding_category_status.protogoogle.ads.googleads.v3.enums"z
 ProductBiddingCategoryStatusEnum"V
ProductBiddingCategoryStatus
UNSPECIFIED 
UNKNOWN

ACTIVE
OBSOLETEB�
!com.google.ads.googleads.v3.enumsB!ProductBiddingCategoryStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
Igoogle/ads/googleads/v3/resources/product_bidding_category_constant.proto!google.ads.googleads.v3.resourcesCgoogle/ads/googleads/v3/enums/product_bidding_category_status.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
ProductBiddingCategoryConstantV
resource_name (	B?�A�A9
7googleads.googleapis.com/ProductBiddingCategoryConstant,
id (2.google.protobuf.Int64ValueB�A7
country_code (2.google.protobuf.StringValueB�A�
(product_bidding_category_constant_parent (2.google.protobuf.StringValueB?�A�A9
7googleads.googleapis.com/ProductBiddingCategoryConstantn
level (2Z.google.ads.googleads.v3.enums.ProductBiddingCategoryLevelEnum.ProductBiddingCategoryLevelB�Aq
status (2\\.google.ads.googleads.v3.enums.ProductBiddingCategoryStatusEnum.ProductBiddingCategoryStatusB�A8
language_code (2.google.protobuf.StringValueB�A9
localized_name (2.google.protobuf.StringValueB�A:��A~
7googleads.googleapis.com/ProductBiddingCategoryConstantCproductBiddingCategoryConstants/{product_bidding_category_constant}B�
%com.google.ads.googleads.v3.resourcesB#ProductBiddingCategoryConstantProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v3/resources;resources�GAA�!Google.Ads.GoogleAds.V3.Resources�!Google\\Ads\\GoogleAds\\V3\\Resources�%Google::Ads::GoogleAds::V3::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

