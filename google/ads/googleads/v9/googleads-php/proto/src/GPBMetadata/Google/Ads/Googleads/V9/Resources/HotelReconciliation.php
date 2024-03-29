<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v9/resources/hotel_reconciliation.proto

namespace GPBMetadata\Google\Ads\Googleads\V9\Resources;

class HotelReconciliation
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
�
?google/ads/googleads/v9/enums/hotel_reconciliation_status.protogoogle.ads.googleads.v9.enums"�
HotelReconciliationStatusEnum"�
HotelReconciliationStatus
UNSPECIFIED 
UNKNOWN
RESERVATION_ENABLED
RECONCILIATION_NEEDED

RECONCILED
CANCELEDB�
!com.google.ads.googleads.v9.enumsBHotelReconciliationStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v9/enums;enums�GAA�Google.Ads.GoogleAds.V9.Enums�Google\\Ads\\GoogleAds\\V9\\Enums�!Google::Ads::GoogleAds::V9::Enumsbproto3
�
<google/ads/googleads/v9/resources/hotel_reconciliation.proto!google.ads.googleads.v9.resourcesgoogle/api/field_behavior.protogoogle/api/resource.protogoogle/api/annotations.proto"�
HotelReconciliationK
resource_name (	B4�A�A.
,googleads.googleapis.com/HotelReconciliation
commission_id (	B�A�A
order_id (	B�A
hotel_center_id (B�A
hotel_id (	B�A
check_in_date (	B�A
check_out_date (	B�A\'
reconciled_value_micros (B�A�A
billed	 (B�An
status
 (2V.google.ads.googleads.v9.enums.HotelReconciliationStatusEnum.HotelReconciliationStatusB�A�A:o�Al
,googleads.googleapis.com/HotelReconciliation<customers/{customer_id}/hotelReconciliations/{commission_id}B�
%com.google.ads.googleads.v9.resourcesBHotelReconciliationProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v9/resources;resources�GAA�!Google.Ads.GoogleAds.V9.Resources�!Google\\Ads\\GoogleAds\\V9\\Resources�%Google::Ads::GoogleAds::V9::Resourcesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

