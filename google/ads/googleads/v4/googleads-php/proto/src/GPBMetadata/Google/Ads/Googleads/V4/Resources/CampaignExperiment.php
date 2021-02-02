<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v4/resources/campaign_experiment.proto

namespace GPBMetadata\Google\Ads\Googleads\V4\Resources;

class CampaignExperiment
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
�
>google/ads/googleads/v4/enums/campaign_experiment_status.protogoogle.ads.googleads.v4.enums"�
CampaignExperimentStatusEnum"�
CampaignExperimentStatus
UNSPECIFIED 
UNKNOWN
INITIALIZING
INITIALIZATION_FAILED
ENABLED
	GRADUATED
REMOVED
	PROMOTING
PROMOTION_FAILED	
PROMOTED
ENDED_MANUALLY
B�
!com.google.ads.googleads.v4.enumsBCampaignExperimentStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v4/enums;enums�GAA�Google.Ads.GoogleAds.V4.Enums�Google\\Ads\\GoogleAds\\V4\\Enums�!Google::Ads::GoogleAds::V4::Enumsbproto3
�
Jgoogle/ads/googleads/v4/enums/campaign_experiment_traffic_split_type.protogoogle.ads.googleads.v4.enums"�
&CampaignExperimentTrafficSplitTypeEnum"`
"CampaignExperimentTrafficSplitType
UNSPECIFIED 
UNKNOWN
RANDOM_QUERY

COOKIEB�
!com.google.ads.googleads.v4.enumsB\'CampaignExperimentTrafficSplitTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v4/enums;enums�GAA�Google.Ads.GoogleAds.V4.Enums�Google\\Ads\\GoogleAds\\V4\\Enums�!Google::Ads::GoogleAds::V4::Enumsbproto3
�
;google/ads/googleads/v4/resources/campaign_experiment.proto!google.ads.googleads.v4.resourcesJgoogle/ads/googleads/v4/enums/campaign_experiment_traffic_split_type.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
CampaignExperimentJ
resource_name (	B3�A�A-
+googleads.googleapis.com/CampaignExperiment,
id (2.google.protobuf.Int64ValueB�Ad
campaign_draft (2.google.protobuf.StringValueB.�A�A(
&googleads.googleapis.com/CampaignDraft*
name (2.google.protobuf.StringValue1
description (2.google.protobuf.StringValue?
traffic_split_percent (2.google.protobuf.Int64ValueB�A�
traffic_split_type (2h.google.ads.googleads.v4.enums.CampaignExperimentTrafficSplitTypeEnum.CampaignExperimentTrafficSplitTypeB�Ad
experiment_campaign (2.google.protobuf.StringValueB)�A�A#
!googleads.googleapis.com/Campaigni
status	 (2T.google.ads.googleads.v4.enums.CampaignExperimentStatusEnum.CampaignExperimentStatusB�AA
long_running_operation
 (2.google.protobuf.StringValueB�A0

start_date (2.google.protobuf.StringValue.
end_date (2.google.protobuf.StringValue:p�Am
+googleads.googleapis.com/CampaignExperiment>customers/{customer}/campaignExperiments/{campaign_experiment}B�
%com.google.ads.googleads.v4.resourcesBCampaignExperimentProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v4/resources;resources�GAA�!Google.Ads.GoogleAds.V4.Resources�!Google\\Ads\\GoogleAds\\V4\\Resources�%Google::Ads::GoogleAds::V4::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

