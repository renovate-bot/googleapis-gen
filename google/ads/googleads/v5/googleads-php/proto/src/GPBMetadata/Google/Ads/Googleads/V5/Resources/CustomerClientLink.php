<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v5/resources/customer_client_link.proto

namespace GPBMetadata\Google\Ads\Googleads\V5\Resources;

class CustomerClientLink
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
        \GPBMetadata\Google\Protobuf\Wrappers::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
7google/ads/googleads/v5/enums/manager_link_status.protogoogle.ads.googleads.v5.enums"�
ManagerLinkStatusEnum"s
ManagerLinkStatus
UNSPECIFIED 
UNKNOWN

ACTIVE
INACTIVE
PENDING
REFUSED
CANCELEDB�
!com.google.ads.googleads.v5.enumsBManagerLinkStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
<google/ads/googleads/v5/resources/customer_client_link.proto!google.ads.googleads.v5.resourcesgoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
CustomerClientLinkJ
resource_name (	B3�A�A-
+googleads.googleapis.com/CustomerClientLink:
client_customer (2.google.protobuf.StringValueB�A9
manager_link_id (2.google.protobuf.Int64ValueB�AV
status (2F.google.ads.googleads.v5.enums.ManagerLinkStatusEnum.ManagerLinkStatus*
hidden (2.google.protobuf.BoolValue:q�An
+googleads.googleapis.com/CustomerClientLink?customers/{customer}/customerClientLinks/{customer_client_link}B�
%com.google.ads.googleads.v5.resourcesBCustomerClientLinkProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v5/resources;resources�GAA�!Google.Ads.GoogleAds.V5.Resources�!Google\\Ads\\GoogleAds\\V5\\Resources�%Google::Ads::GoogleAds::V5::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

