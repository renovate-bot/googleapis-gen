<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/compute/v1/compute.proto

namespace Google\Cloud\Compute\V1\ProjectsSetDefaultNetworkTierRequest;

use UnexpectedValueException;

/**
 * Default network tier to be set.
 *
 * Protobuf type <code>google.cloud.compute.v1.ProjectsSetDefaultNetworkTierRequest.NetworkTier</code>
 */
class NetworkTier
{
    /**
     * A value indicating that the enum field is not set.
     *
     * Generated from protobuf enum <code>UNDEFINED_NETWORK_TIER = 0;</code>
     */
    const UNDEFINED_NETWORK_TIER = 0;
    /**
     * High quality, Google-grade network tier, support for all networking products.
     *
     * Generated from protobuf enum <code>PREMIUM = 399530551;</code>
     */
    const PREMIUM = 399530551;
    /**
     * Public internet quality, only limited support for other networking products.
     *
     * Generated from protobuf enum <code>STANDARD = 484642493;</code>
     */
    const STANDARD = 484642493;

    private static $valueToName = [
        self::UNDEFINED_NETWORK_TIER => 'UNDEFINED_NETWORK_TIER',
        self::PREMIUM => 'PREMIUM',
        self::STANDARD => 'STANDARD',
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
class_alias(NetworkTier::class, \Google\Cloud\Compute\V1\ProjectsSetDefaultNetworkTierRequest_NetworkTier::class);

