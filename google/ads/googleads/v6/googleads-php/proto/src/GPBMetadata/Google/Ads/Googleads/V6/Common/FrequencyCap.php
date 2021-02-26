<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v6/common/frequency_cap.proto

namespace GPBMetadata\Google\Ads\Googleads\V6\Common;

class FrequencyCap
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
<google/ads/googleads/v6/enums/frequency_cap_event_type.protogoogle.ads.googleads.v6.enums"r
FrequencyCapEventTypeEnum"U
FrequencyCapEventType
UNSPECIFIED 
UNKNOWN

IMPRESSION

VIDEO_VIEWB�
!com.google.ads.googleads.v6.enumsBFrequencyCapEventTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
7google/ads/googleads/v6/enums/frequency_cap_level.protogoogle.ads.googleads.v6.enums"w
FrequencyCapLevelEnum"^
FrequencyCapLevel
UNSPECIFIED 
UNKNOWN
AD_GROUP_AD
AD_GROUP
CAMPAIGNB�
!com.google.ads.googleads.v6.enumsBFrequencyCapLevelProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
;google/ads/googleads/v6/enums/frequency_cap_time_unit.protogoogle.ads.googleads.v6.enums"n
FrequencyCapTimeUnitEnum"R
FrequencyCapTimeUnit
UNSPECIFIED 
UNKNOWN
DAY
WEEK	
MONTHB�
!com.google.ads.googleads.v6.enumsBFrequencyCapTimeUnitProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
2google/ads/googleads/v6/common/frequency_cap.protogoogle.ads.googleads.v6.common7google/ads/googleads/v6/enums/frequency_cap_level.proto;google/ads/googleads/v6/enums/frequency_cap_time_unit.protogoogle/api/annotations.proto"k
FrequencyCapEntry<
key (2/.google.ads.googleads.v6.common.FrequencyCapKey
cap (H �B
_cap"�
FrequencyCapKeyU
level (2F.google.ads.googleads.v6.enums.FrequencyCapLevelEnum.FrequencyCapLevelb

event_type (2N.google.ads.googleads.v6.enums.FrequencyCapEventTypeEnum.FrequencyCapEventType_
	time_unit (2L.google.ads.googleads.v6.enums.FrequencyCapTimeUnitEnum.FrequencyCapTimeUnit
time_length (H �B
_time_lengthB�
"com.google.ads.googleads.v6.commonBFrequencyCapProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v6/common;common�GAA�Google.Ads.GoogleAds.V6.Common�Google\\Ads\\GoogleAds\\V6\\Common�"Google::Ads::GoogleAds::V6::Commonbproto3'
        , true);
        static::$is_initialized = true;
    }
}

