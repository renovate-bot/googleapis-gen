<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v5/services/google_ads_field_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V5\Services;

class GoogleAdsFieldService
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();
        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Http::initOnce();
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
=google/ads/googleads/v5/enums/google_ads_field_category.protogoogle.ads.googleads.v5.enums"�
GoogleAdsFieldCategoryEnum"l
GoogleAdsFieldCategory
UNSPECIFIED 
UNKNOWN
RESOURCE
	ATTRIBUTE
SEGMENT

METRICB�
!com.google.ads.googleads.v5.enumsBGoogleAdsFieldCategoryProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
>google/ads/googleads/v5/enums/google_ads_field_data_type.protogoogle.ads.googleads.v5.enums"�
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
!com.google.ads.googleads.v5.enumsBGoogleAdsFieldDataTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�

8google/ads/googleads/v5/resources/google_ads_field.proto!google.ads.googleads.v5.resources>google/ads/googleads/v5/enums/google_ads_field_data_type.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/api/annotations.proto"�
GoogleAdsFieldF
resource_name (	B/�A�A)
\'googleads.googleapis.com/GoogleAdsField
name (	B�AH �g
category (2P.google.ads.googleads.v5.enums.GoogleAdsFieldCategoryEnum.GoogleAdsFieldCategoryB�A

selectable (B�AH�

filterable (B�AH�
sortable (B�AH�
selectable_with (	B�A 
attribute_resources (	B�A
metrics (	B�A
segments (	B�A
enum_values (	B�Ah
	data_type (2P.google.ads.googleads.v5.enums.GoogleAdsFieldDataTypeEnum.GoogleAdsFieldDataTypeB�A
type_url (	B�AH�
is_repeated (B�AH�:P�AM
\'googleads.googleapis.com/GoogleAdsField"googleAdsFields/{google_ads_field}B
_nameB
_selectableB
_filterableB
	_sortableB
	_type_urlB
_is_repeatedB�
%com.google.ads.googleads.v5.resourcesBGoogleAdsFieldProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v5/resources;resources�GAA�!Google.Ads.GoogleAds.V5.Resources�!Google\\Ads\\GoogleAds\\V5\\Resources�%Google::Ads::GoogleAds::V5::Resourcesbproto3
�

?google/ads/googleads/v5/services/google_ads_field_service.proto google.ads.googleads.v5.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto"b
GetGoogleAdsFieldRequestF
resource_name (	B/�A�A)
\'googleads.googleapis.com/GoogleAdsField"Y
SearchGoogleAdsFieldsRequest
query (	B�A

page_token (	
	page_size ("�
SearchGoogleAdsFieldsResponseB
results (21.google.ads.googleads.v5.resources.GoogleAdsField
next_page_token (	
total_results_count (2�
GoogleAdsFieldService�
GetGoogleAdsField:.google.ads.googleads.v5.services.GetGoogleAdsFieldRequest1.google.ads.googleads.v5.resources.GoogleAdsField"=���\'%/v5/{resource_name=googleAdsFields/*}�Aresource_name�
SearchGoogleAdsFields>.google.ads.googleads.v5.services.SearchGoogleAdsFieldsRequest?.google.ads.googleads.v5.services.SearchGoogleAdsFieldsResponse"-���"/v5/googleAdsFields:search:*�AqueryE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v5.servicesBGoogleAdsFieldServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v5/services;services�GAA� Google.Ads.GoogleAds.V5.Services� Google\\Ads\\GoogleAds\\V5\\Services�$Google::Ads::GoogleAds::V5::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

