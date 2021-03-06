<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/monitoring/dashboard/v1/metrics.proto

namespace Google\Cloud\Monitoring\Dashboard\V1\Threshold;

use UnexpectedValueException;

/**
 * Whether the threshold is considered crossed by an actual value above or
 * below its threshold value.
 *
 * Protobuf type <code>google.monitoring.dashboard.v1.Threshold.Direction</code>
 */
class Direction
{
    /**
     * Not allowed in well-formed requests.
     *
     * Generated from protobuf enum <code>DIRECTION_UNSPECIFIED = 0;</code>
     */
    const DIRECTION_UNSPECIFIED = 0;
    /**
     * The threshold will be considered crossed if the actual value is above
     * the threshold value.
     *
     * Generated from protobuf enum <code>ABOVE = 1;</code>
     */
    const ABOVE = 1;
    /**
     * The threshold will be considered crossed if the actual value is below
     * the threshold value.
     *
     * Generated from protobuf enum <code>BELOW = 2;</code>
     */
    const BELOW = 2;

    private static $valueToName = [
        self::DIRECTION_UNSPECIFIED => 'DIRECTION_UNSPECIFIED',
        self::ABOVE => 'ABOVE',
        self::BELOW => 'BELOW',
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
class_alias(Direction::class, \Google\Cloud\Monitoring\Dashboard\V1\Threshold_Direction::class);

