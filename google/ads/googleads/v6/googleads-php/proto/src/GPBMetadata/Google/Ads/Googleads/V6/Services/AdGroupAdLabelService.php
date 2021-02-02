<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v6/services/ad_group_ad_label_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V6\Services;

class AdGroupAdLabelService
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
        \GPBMetadata\Google\Protobuf\Any::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        \GPBMetadata\Google\Rpc\Status::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
9google/ads/googleads/v6/resources/ad_group_ad_label.proto!google.ads.googleads.v6.resourcesgoogle/api/resource.protogoogle/api/annotations.proto"�
AdGroupAdLabelF
resource_name (	B/�A�A)
\'googleads.googleapis.com/AdGroupAdLabelD
ad_group_ad (	B*�A�A$
"googleads.googleapis.com/AdGroupAdH �:
label (	B&�A�A 
googleads.googleapis.com/LabelH�:v�As
\'googleads.googleapis.com/AdGroupAdLabelHcustomers/{customer_id}/adGroupAdLabels/{ad_group_id}~{ad_id}~{label_id}B
_ad_group_adB
_labelB�
%com.google.ads.googleads.v6.resourcesBAdGroupAdLabelProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v6/resources;resources�GAA�!Google.Ads.GoogleAds.V6.Resources�!Google\\Ads\\GoogleAds\\V6\\Resources�%Google::Ads::GoogleAds::V6::Resourcesbproto3
�
@google/ads/googleads/v6/services/ad_group_ad_label_service.proto google.ads.googleads.v6.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/rpc/status.proto"b
GetAdGroupAdLabelRequestF
resource_name (	B/�A�A)
\'googleads.googleapis.com/AdGroupAdLabel"�
MutateAdGroupAdLabelsRequest
customer_id (	B�AR

operations (29.google.ads.googleads.v6.services.AdGroupAdLabelOperationB�A
partial_failure (
validate_only ("}
AdGroupAdLabelOperationC
create (21.google.ads.googleads.v6.resources.AdGroupAdLabelH 
remove (	H B
	operation"�
MutateAdGroupAdLabelsResponse1
partial_failure_error (2.google.rpc.StatusM
results (2<.google.ads.googleads.v6.services.MutateAdGroupAdLabelResult"3
MutateAdGroupAdLabelResult
resource_name (	2�
AdGroupAdLabelService�
GetAdGroupAdLabel:.google.ads.googleads.v6.services.GetAdGroupAdLabelRequest1.google.ads.googleads.v6.resources.AdGroupAdLabel"I���31/v6/{resource_name=customers/*/adGroupAdLabels/*}�Aresource_name�
MutateAdGroupAdLabels>.google.ads.googleads.v6.services.MutateAdGroupAdLabelsRequest?.google.ads.googleads.v6.services.MutateAdGroupAdLabelsResponse"X���9"4/v6/customers/{customer_id=*}/adGroupAdLabels:mutate:*�Acustomer_id,operationsE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v6.servicesBAdGroupAdLabelServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v6/services;services�GAA� Google.Ads.GoogleAds.V6.Services� Google\\Ads\\GoogleAds\\V6\\Services�$Google::Ads::GoogleAds::V6::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

