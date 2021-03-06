<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/monitoring/dashboard/v1/common.proto

namespace Google\Cloud\Monitoring\Dashboard\V1\StatisticalTimeSeriesFilter;

use UnexpectedValueException;

/**
 * The filter methods that can be applied to a stream.
 *
 * Protobuf type <code>google.monitoring.dashboard.v1.StatisticalTimeSeriesFilter.Method</code>
 */
class Method
{
    /**
     * Not allowed in well-formed requests.
     *
     * Generated from protobuf enum <code>METHOD_UNSPECIFIED = 0;</code>
     */
    const METHOD_UNSPECIFIED = 0;
    /**
     * Compute the outlier score of each stream.
     *
     * Generated from protobuf enum <code>METHOD_CLUSTER_OUTLIER = 1;</code>
     */
    const METHOD_CLUSTER_OUTLIER = 1;

    private static $valueToName = [
        self::METHOD_UNSPECIFIED => 'METHOD_UNSPECIFIED',
        self::METHOD_CLUSTER_OUTLIER => 'METHOD_CLUSTER_OUTLIER',
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
class_alias(Method::class, \Google\Cloud\Monitoring\Dashboard\V1\StatisticalTimeSeriesFilter_Method::class);

