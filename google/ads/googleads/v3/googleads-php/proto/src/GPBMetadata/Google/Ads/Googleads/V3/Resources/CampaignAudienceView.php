<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v3/resources/campaign_audience_view.proto

namespace GPBMetadata\Google\Ads\Googleads\V3\Resources;

class CampaignAudienceView
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
�
>google/ads/googleads/v3/resources/campaign_audience_view.proto!google.ads.googleads.v3.resourcesgoogle/api/resource.protogoogle/api/annotations.proto"�
CampaignAudienceViewL
resource_name (	B5�A�A/
-googleads.googleapis.com/CampaignAudienceView:w�At
-googleads.googleapis.com/CampaignAudienceViewCcustomers/{customer}/campaignAudienceViews/{campaign_audience_view}B�
%com.google.ads.googleads.v3.resourcesBCampaignAudienceViewProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v3/resources;resources�GAA�!Google.Ads.GoogleAds.V3.Resources�!Google\\Ads\\GoogleAds\\V3\\Resources�%Google::Ads::GoogleAds::V3::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

