<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/asset/v1p7beta1/asset_service.proto

namespace Google\Cloud\Asset\V1p7beta1;

use UnexpectedValueException;

/**
 * Asset content type.
 *
 * Protobuf type <code>google.cloud.asset.v1p7beta1.ContentType</code>
 */
class ContentType
{
    /**
     * Unspecified content type.
     *
     * Generated from protobuf enum <code>CONTENT_TYPE_UNSPECIFIED = 0;</code>
     */
    const CONTENT_TYPE_UNSPECIFIED = 0;
    /**
     * Resource metadata.
     *
     * Generated from protobuf enum <code>RESOURCE = 1;</code>
     */
    const RESOURCE = 1;
    /**
     * The actual IAM policy set on a resource.
     *
     * Generated from protobuf enum <code>IAM_POLICY = 2;</code>
     */
    const IAM_POLICY = 2;
    /**
     * The Cloud Organization Policy set on an asset.
     *
     * Generated from protobuf enum <code>ORG_POLICY = 4;</code>
     */
    const ORG_POLICY = 4;
    /**
     * The Cloud Access context manager Policy set on an asset.
     *
     * Generated from protobuf enum <code>ACCESS_POLICY = 5;</code>
     */
    const ACCESS_POLICY = 5;
    /**
     * The related resources.
     *
     * Generated from protobuf enum <code>RELATIONSHIP = 7;</code>
     */
    const RELATIONSHIP = 7;

    private static $valueToName = [
        self::CONTENT_TYPE_UNSPECIFIED => 'CONTENT_TYPE_UNSPECIFIED',
        self::RESOURCE => 'RESOURCE',
        self::IAM_POLICY => 'IAM_POLICY',
        self::ORG_POLICY => 'ORG_POLICY',
        self::ACCESS_POLICY => 'ACCESS_POLICY',
        self::RELATIONSHIP => 'RELATIONSHIP',
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

