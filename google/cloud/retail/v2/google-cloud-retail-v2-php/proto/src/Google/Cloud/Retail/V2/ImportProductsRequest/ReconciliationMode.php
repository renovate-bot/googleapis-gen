<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/retail/v2/import_config.proto

namespace Google\Cloud\Retail\V2\ImportProductsRequest;

use UnexpectedValueException;

/**
 * Indicates how imported products are reconciled with the existing products
 * created or imported before.
 *
 * Protobuf type <code>google.cloud.retail.v2.ImportProductsRequest.ReconciliationMode</code>
 */
class ReconciliationMode
{
    /**
     * Defaults to INCREMENTAL.
     *
     * Generated from protobuf enum <code>RECONCILIATION_MODE_UNSPECIFIED = 0;</code>
     */
    const RECONCILIATION_MODE_UNSPECIFIED = 0;
    /**
     * Inserts new products or updates existing products.
     *
     * Generated from protobuf enum <code>INCREMENTAL = 1;</code>
     */
    const INCREMENTAL = 1;
    /**
     * Calculates diff and replaces the entire product dataset. Existing
     * products may be deleted if they are not present in the source location.
     * Can only be while using
     * [BigQuerySource][google.cloud.retail.v2.BigQuerySource].
     * Add the IAM permission "BigQuery Data Viewer" for
     * cloud-retail-customer-data-access&#64;system.gserviceaccount.com before
     * using this feature otherwise an error is thrown.
     * This feature is only available for users who have Retail Search enabled.
     * Please submit a form [here](https://cloud.google.com/contact) to contact
     * cloud sales if you are interested in using Retail Search.
     *
     * Generated from protobuf enum <code>FULL = 2;</code>
     */
    const FULL = 2;

    private static $valueToName = [
        self::RECONCILIATION_MODE_UNSPECIFIED => 'RECONCILIATION_MODE_UNSPECIFIED',
        self::INCREMENTAL => 'INCREMENTAL',
        self::FULL => 'FULL',
    ];

    public static function name($value)
    {
        if (!isset(self::$valueToName[$value])) {
            throw new UnexpectedValueException(sprintf(
                    'Enum %s has no name defined for value %s', __CLASS__, $value));
        }
        return self::$valueToName[$value];
    }


    public static function value($name)
    {
        $const = __CLASS__ . '::' . strtoupper($name);
        if (!defined($const)) {
            throw new UnexpectedValueException(sprintf(
                    'Enum %s has no value defined for name %s', __CLASS__, $name));
        }
        return constant($const);
    }
}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(ReconciliationMode::class, \Google\Cloud\Retail\V2\ImportProductsRequest_ReconciliationMode::class);

