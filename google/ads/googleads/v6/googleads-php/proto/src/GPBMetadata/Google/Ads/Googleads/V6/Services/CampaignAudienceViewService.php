<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v6/services/campaign_audience_view_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V6\Services;

class CampaignAudienceViewService
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
        \GPBMetadata\Google\Api\Client::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
>google/ads/googleads/v6/resources/campaign_audience_view.proto!google.ads.googleads.v6.resourcesgoogle/api/resource.protogoogle/api/annotations.proto"�
CampaignAudienceViewL
resource_name (	B5�A�A/
-googleads.googleapis.com/CampaignAudienceView:~�A{
-googleads.googleapis.com/CampaignAudienceViewJcustomers/{customer_id}/campaignAudienceViews/{campaign_id}~{criterion_id}B�
%com.google.ads.googleads.v6.resourcesBCampaignAudienceViewProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v6/resources;resources�GAA�!Google.Ads.GoogleAds.V6.Resources�!Google\\Ads\\GoogleAds\\V6\\Resources�%Google::Ads::GoogleAds::V6::Resourcesbproto3
�
Egoogle/ads/googleads/v6/services/campaign_audience_view_service.proto google.ads.googleads.v6.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto"n
GetCampaignAudienceViewRequestL
resource_name (	B5�A�A/
-googleads.googleapis.com/CampaignAudienceView2�
CampaignAudienceViewService�
GetCampaignAudienceView@.google.ads.googleads.v6.services.GetCampaignAudienceViewRequest7.google.ads.googleads.v6.resources.CampaignAudienceView"O���97/v6/{resource_name=customers/*/campaignAudienceViews/*}�Aresource_nameE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v6.servicesB CampaignAudienceViewServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v6/services;services�GAA� Google.Ads.GoogleAds.V6.Services� Google\\Ads\\GoogleAds\\V6\\Services�$Google::Ads::GoogleAds::V6::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

