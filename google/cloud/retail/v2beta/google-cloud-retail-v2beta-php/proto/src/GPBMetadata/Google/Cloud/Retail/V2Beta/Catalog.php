<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/retail/v2beta/catalog.proto

namespace GPBMetadata\Google\Cloud\Retail\V2Beta;

class Catalog
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Cloud\Retail\V2Beta\Common::initOnce();
        \GPBMetadata\Google\Cloud\Retail\V2Beta\ImportConfig::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
(google/cloud/retail/v2beta/catalog.protogoogle.cloud.retail.v2betagoogle/api/field_behavior.protogoogle/api/resource.proto\'google/cloud/retail/v2beta/common.proto.google/cloud/retail/v2beta/import_config.proto"^
ProductLevelConfig
ingestion_product_type (	(
 merchant_center_product_id_field (	"�
Catalog
name (	B�A�A
display_name (	B�A�AQ
product_level_config (2..google.cloud.retail.v2beta.ProductLevelConfigB�A:^�A[
retail.googleapis.com/Catalog:projects/{project}/locations/{location}/catalogs/{catalog}B�
com.google.cloud.retail.v2betaBCatalogProtoPZ@google.golang.org/genproto/googleapis/cloud/retail/v2beta;retail�RETAIL�Google.Cloud.Retail.V2Beta�Google\\Cloud\\Retail\\V2beta�Google::Cloud::Retail::V2betabproto3'
        , true);

        static::$is_initialized = true;
    }
}

