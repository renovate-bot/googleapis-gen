<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v3/resources/google_ads_field.proto

namespace GPBMetadata\Google\Ads\Googleads\V3\Resources;

class GoogleAdsField
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
�
=google/ads/googleads/v3/enums/google_ads_field_category.protogoogle.ads.googleads.v3.enums"�
GoogleAdsFieldCategoryEnum"l
GoogleAdsFieldCategory
UNSPECIFIED 
UNKNOWN
RESOURCE
	ATTRIBUTE
SEGMENT

METRICB�
!com.google.ads.googleads.v3.enumsBGoogleAdsFieldCategoryProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
>google/ads/googleads/v3/enums/google_ads_field_data_type.protogoogle.ads.googleads.v3.enums"�
GoogleAdsFieldDataTypeEnum"�
GoogleAdsFieldDataType
UNSPECIFIED 
UNKNOWN
BOOLEAN
DATE

DOUBLE
ENUM	
FLOAT	
INT32	
INT64
MESSAGE	
RESOURCE_NAME


STRING

UINT64B�
!com.google.ads.googleads.v3.enumsBGoogleAdsFieldDataTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v3/enums;enums�GAA�Google.Ads.GoogleAds.V3.Enums�Google\\Ads\\GoogleAds\\V3\\Enums�!Google::Ads::GoogleAds::V3::Enumsbproto3
�
8google/ads/googleads/v3/resources/google_ads_field.proto!google.ads.googleads.v3.resources>google/ads/googleads/v3/enums/google_ads_field_data_type.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
GoogleAdsFieldF
resource_name (	B/�A�A)
\'googleads.googleapis.com/GoogleAdsField/
name (2.google.protobuf.StringValueB�Ag
category (2P.google.ads.googleads.v3.enums.GoogleAdsFieldCategoryEnum.GoogleAdsFieldCategoryB�A3

selectable (2.google.protobuf.BoolValueB�A3

filterable (2.google.protobuf.BoolValueB�A1
sortable (2.google.protobuf.BoolValueB�A:
selectable_with (2.google.protobuf.StringValueB�A>
attribute_resources (2.google.protobuf.StringValueB�A2
metrics	 (2.google.protobuf.StringValueB�A3
segments
 (2.google.protobuf.StringValueB�A6
enum_values (2.google.protobuf.StringValueB�Ah
	data_type (2P.google.ads.googleads.v3.enums.GoogleAdsFieldDataTypeEnum.GoogleAdsFieldDataTypeB�A3
type_url (2.google.protobuf.StringValueB�A4
is_repeated (2.google.protobuf.BoolValueB�A:P�AM
\'googleads.googleapis.com/GoogleAdsField"googleAdsFields/{google_ads_field}B�
%com.google.ads.googleads.v3.resourcesBGoogleAdsFieldProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v3/resources;resources�GAA�!Google.Ads.GoogleAds.V3.Resources�!Google\\Ads\\GoogleAds\\V3\\Resources�%Google::Ads::GoogleAds::V3::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

