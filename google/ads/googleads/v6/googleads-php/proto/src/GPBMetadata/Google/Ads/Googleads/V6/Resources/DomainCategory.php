<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v6/resources/domain_category.proto

namespace GPBMetadata\Google\Ads\Googleads\V6\Resources;

class DomainCategory
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
�
7google/ads/googleads/v6/resources/domain_category.proto!google.ads.googleads.v6.resourcesgoogle/api/resource.protogoogle/api/annotations.proto"�
DomainCategoryF
resource_name (	B/�A�A)
\'googleads.googleapis.com/DomainCategory@
campaign
 (	B)�A�A#
!googleads.googleapis.com/CampaignH �
category (	B�AH�
language_code (	B�AH�
domain (	B�AH�#
coverage_fraction (B�AH�
category_rank (B�AH�
has_children (B�AH�,
recommended_cpc_bid_micros (B�AH�:��A�
\'googleads.googleapis.com/DomainCategoryXcustomers/{customer_id}/domainCategories/{campaign_id}~{base64_category}~{language_code}B
	_campaignB
	_categoryB
_language_codeB	
_domainB
_coverage_fractionB
_category_rankB
_has_childrenB
_recommended_cpc_bid_microsB�
%com.google.ads.googleads.v6.resourcesBDomainCategoryProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v6/resources;resources�GAA�!Google.Ads.GoogleAds.V6.Resources�!Google\\Ads\\GoogleAds\\V6\\Resources�%Google::Ads::GoogleAds::V6::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

