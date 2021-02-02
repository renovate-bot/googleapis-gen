<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v4/resources/keyword_plan_ad_group_keyword.proto

namespace GPBMetadata\Google\Ads\Googleads\V4\Resources;

class KeywordPlanAdGroupKeyword
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
6google/ads/googleads/v4/enums/keyword_match_type.protogoogle.ads.googleads.v4.enums"j
KeywordMatchTypeEnum"R
KeywordMatchType
UNSPECIFIED 
UNKNOWN	
EXACT

PHRASE	
BROADB�
!com.google.ads.googleads.v4.enumsBKeywordMatchTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v4/enums;enums�GAA�Google.Ads.GoogleAds.V4.Enums�Google\\Ads\\GoogleAds\\V4\\Enums�!Google::Ads::GoogleAds::V4::Enumsbproto3
�	
Egoogle/ads/googleads/v4/resources/keyword_plan_ad_group_keyword.proto!google.ads.googleads.v4.resourcesgoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
KeywordPlanAdGroupKeywordQ
resource_name (	B:�A�A4
2googleads.googleapis.com/KeywordPlanAdGroupKeywordm
keyword_plan_ad_group (2.google.protobuf.StringValueB0�A-
+googleads.googleapis.com/KeywordPlanAdGroup,
id (2.google.protobuf.Int64ValueB�A*
text (2.google.protobuf.StringValueX

match_type (2D.google.ads.googleads.v4.enums.KeywordMatchTypeEnum.KeywordMatchType3
cpc_bid_micros (2.google.protobuf.Int64Value1
negative (2.google.protobuf.BoolValueB�A:��A�
2googleads.googleapis.com/KeywordPlanAdGroupKeywordOcustomers/{customer}/keywordPlanAdGroupKeywords/{keyword_plan_ad_group_keyword}B�
%com.google.ads.googleads.v4.resourcesBKeywordPlanAdGroupKeywordProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v4/resources;resources�GAA�!Google.Ads.GoogleAds.V4.Resources�!Google\\Ads\\GoogleAds\\V4\\Resources�%Google::Ads::GoogleAds::V4::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

