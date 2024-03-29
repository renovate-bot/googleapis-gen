<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/compute/v1/compute.proto

namespace Google\Cloud\Compute\V1\PublicDelegatedPrefix;

use UnexpectedValueException;

/**
 * [Output Only] The status of the public delegated prefix.
 *
 * Protobuf type <code>google.cloud.compute.v1.PublicDelegatedPrefix.Status</code>
 */
class Status
{
    /**
     * A value indicating that the enum field is not set.
     *
     * Generated from protobuf enum <code>UNDEFINED_STATUS = 0;</code>
     */
    const UNDEFINED_STATUS = 0;
    /**
     * Generated from protobuf enum <code>ANNOUNCED = 365103355;</code>
     */
    const ANNOUNCED = 365103355;
    /**
     * Generated from protobuf enum <code>DELETING = 528602024;</code>
     */
    const DELETING = 528602024;
    /**
     * Generated from protobuf enum <code>INITIALIZING = 306588749;</code>
     */
    const INITIALIZING = 306588749;
    /**
     * Generated from protobuf enum <code>READY_TO_ANNOUNCE = 64641265;</code>
     */
    const READY_TO_ANNOUNCE = 64641265;

    private static $valueToName = [
        self::UNDEFINED_STATUS => 'UNDEFINED_STATUS',
        self::ANNOUNCED => 'ANNOUNCED',
        self::DELETING => 'DELETING',
        self::INITIALIZING => 'INITIALIZING',
        self::READY_TO_ANNOUNCE => 'READY_TO_ANNOUNCE',
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
class_alias(Status::class, \Google\Cloud\Compute\V1\PublicDelegatedPrefix_Status::class);

