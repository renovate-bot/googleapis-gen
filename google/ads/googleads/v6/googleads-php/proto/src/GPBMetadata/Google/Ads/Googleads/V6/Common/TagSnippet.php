<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v6/common/tag_snippet.proto

namespace GPBMetadata\Google\Ads\Googleads\V6\Common;

class TagSnippet
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();
        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Http::initOnce();
        \GPBMetadata\Google\Api\Annotations::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
6google/ads/googleads/v6/enums/tracking_code_type.protogoogle.ads.googleads.v6.enums"�
TrackingCodeTypeEnum"w
TrackingCodeType
UNSPECIFIED 
UNKNOWN
WEBPAGE
WEBPAGE_ONCLICK
CLICK_TO_CALL
WEBSITE_CALLB�
!com.google.ads.googleads.v6.enumsBTrackingCodeTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
=google/ads/googleads/v6/enums/tracking_code_page_format.protogoogle.ads.googleads.v6.enums"g
TrackingCodePageFormatEnum"I
TrackingCodePageFormat
UNSPECIFIED 
UNKNOWN
HTML
AMPB�
!com.google.ads.googleads.v6.enumsBTrackingCodePageFormatProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
0google/ads/googleads/v6/common/tag_snippet.protogoogle.ads.googleads.v6.common6google/ads/googleads/v6/enums/tracking_code_type.protogoogle/api/annotations.proto"�

TagSnippetR
type (2D.google.ads.googleads.v6.enums.TrackingCodeTypeEnum.TrackingCodeTypee
page_format (2P.google.ads.googleads.v6.enums.TrackingCodePageFormatEnum.TrackingCodePageFormat
global_site_tag (	H �
event_snippet (	H�B
_global_site_tagB
_event_snippetB�
"com.google.ads.googleads.v6.commonBTagSnippetProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v6/common;common�GAA�Google.Ads.GoogleAds.V6.Common�Google\\Ads\\GoogleAds\\V6\\Common�"Google::Ads::GoogleAds::V6::Commonbproto3'
        , true);
        static::$is_initialized = true;
    }
}

