<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/admob/v1/admob_resources.proto

namespace Google\Ads\Admob\V1\NetworkReportSpec;

use UnexpectedValueException;

/**
 * The dimensions of the network report. Dimensions are data attributes to
 * break down or refine the quantitative measurements (metrics) by certain
 * attributes, such as the ad format or the platform an ad was viewed on.
 *
 * Protobuf type <code>google.ads.admob.v1.NetworkReportSpec.Dimension</code>
 */
class Dimension
{
    /**
     * Default value for an unset field. Do not use.
     *
     * Generated from protobuf enum <code>DIMENSION_UNSPECIFIED = 0;</code>
     */
    const DIMENSION_UNSPECIFIED = 0;
    /**
     * A date in the YYYY-MM-DD format (for example, "2018-12-21"). Requests can
     * specify at most one time dimension.
     *
     * Generated from protobuf enum <code>DATE = 1;</code>
     */
    const DATE = 1;
    /**
     * A month in the YYYY-MM format (for example, "2018-12"). Requests can
     * specify at most one time dimension.
     *
     * Generated from protobuf enum <code>MONTH = 2;</code>
     */
    const MONTH = 2;
    /**
     * The date of the first day of a week in the YYYY-MM-DD format
     * (for example, "2018-12-21"). Requests can specify at most one time
     * dimension.
     *
     * Generated from protobuf enum <code>WEEK = 3;</code>
     */
    const WEEK = 3;
    /**
     * The unique ID of the ad unit (for example, "ca-app-pub-1234/1234").
     * If AD_UNIT dimension is specified, then APP is included automatically.
     *
     * Generated from protobuf enum <code>AD_UNIT = 4;</code>
     */
    const AD_UNIT = 4;
    /**
     * The unique ID of the mobile application (for example,
     * "ca-app-pub-1234~1234").
     *
     * Generated from protobuf enum <code>APP = 5;</code>
     */
    const APP = 5;
    /**
     * Type of the ad (for example, "text" or "image"), an ad delivery
     * dimension.
     * **Warning:** The dimension is incompatible with
     * [AD_REQUESTS](#Metric.ENUM_VALUES.AD_REQUESTS),
     * [MATCH_RATE](#Metric.ENUM_VALUES.MATCH_RATE) and
     * [IMPRESSION_RPM](#Metric.ENUM_VALUES.IMPRESSION_RPM) metrics.
     *
     * Generated from protobuf enum <code>AD_TYPE = 6;</code>
     */
    const AD_TYPE = 6;
    /**
     * CLDR country code of the place where the ad views/clicks occur (for
     * example, "US" or "FR"). This is a geography dimension.
     *
     * Generated from protobuf enum <code>COUNTRY = 7;</code>
     */
    const COUNTRY = 7;
    /**
     * Format of the ad unit (for example, "banner", "native"), an ad delivery
     * dimension.
     *
     * Generated from protobuf enum <code>FORMAT = 8;</code>
     */
    const FORMAT = 8;
    /**
     * Mobile OS platform of the app (for example, "Android" or "iOS").
     *
     * Generated from protobuf enum <code>PLATFORM = 9;</code>
     */
    const PLATFORM = 9;

    private static $valueToName = [
        self::DIMENSION_UNSPECIFIED => 'DIMENSION_UNSPECIFIED',
        self::DATE => 'DATE',
        self::MONTH => 'MONTH',
        self::WEEK => 'WEEK',
        self::AD_UNIT => 'AD_UNIT',
        self::APP => 'APP',
        self::AD_TYPE => 'AD_TYPE',
        self::COUNTRY => 'COUNTRY',
        self::FORMAT => 'FORMAT',
        self::PLATFORM => 'PLATFORM',
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
class_alias(Dimension::class, \Google\Ads\Admob\V1\NetworkReportSpec_Dimension::class);

