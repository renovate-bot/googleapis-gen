<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v5/services/geographic_view_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V5\Services;

class GeographicViewService
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();
        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Http::initOnce();
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
6google/ads/googleads/v5/enums/geo_targeting_type.protogoogle.ads.googleads.v5.enums"x
GeoTargetingTypeEnum"`
GeoTargetingType
UNSPECIFIED 
UNKNOWN
AREA_OF_INTEREST
LOCATION_OF_PRESENCEB�
!com.google.ads.googleads.v5.enumsBGeoTargetingTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
7google/ads/googleads/v5/resources/geographic_view.proto!google.ads.googleads.v5.resourcesgoogle/api/field_behavior.protogoogle/api/resource.protogoogle/api/annotations.proto"�
GeographicViewF
resource_name (	B/�A�A)
\'googleads.googleapis.com/GeographicView`
location_type (2D.google.ads.googleads.v5.enums.GeoTargetingTypeEnum.GeoTargetingTypeB�A&
country_criterion_id (B�AH �:d�Aa
\'googleads.googleapis.com/GeographicView6customers/{customer}/geographicViews/{geographic_view}B
_country_criterion_idB�
%com.google.ads.googleads.v5.resourcesBGeographicViewProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v5/resources;resources�GAA�!Google.Ads.GoogleAds.V5.Resources�!Google\\Ads\\GoogleAds\\V5\\Resources�%Google::Ads::GoogleAds::V5::Resourcesbproto3
�
>google/ads/googleads/v5/services/geographic_view_service.proto google.ads.googleads.v5.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto"b
GetGeographicViewRequestF
resource_name (	B/�A�A)
\'googleads.googleapis.com/GeographicView2�
GeographicViewService�
GetGeographicView:.google.ads.googleads.v5.services.GetGeographicViewRequest1.google.ads.googleads.v5.resources.GeographicView"I���31/v5/{resource_name=customers/*/geographicViews/*}�Aresource_nameE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v5.servicesBGeographicViewServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v5/services;services�GAA� Google.Ads.GoogleAds.V5.Services� Google\\Ads\\GoogleAds\\V5\\Services�$Google::Ads::GoogleAds::V5::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

