<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/metastore/v1alpha/metastore.proto

namespace Google\Cloud\Metastore\V1alpha;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Maintenance window. This specifies when Dataproc Metastore
 * may perform system maintenance operation to the service.
 *
 * Generated from protobuf message <code>google.cloud.metastore.v1alpha.MaintenanceWindow</code>
 */
class MaintenanceWindow extends \Google\Protobuf\Internal\Message
{
    /**
     * The hour of day (0-23) when the window starts.
     *
     * Generated from protobuf field <code>.google.protobuf.Int32Value hour_of_day = 1;</code>
     */
    protected $hour_of_day = null;
    /**
     * The day of week, when the window starts.
     *
     * Generated from protobuf field <code>.google.type.DayOfWeek day_of_week = 2;</code>
     */
    protected $day_of_week = 0;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Protobuf\Int32Value $hour_of_day
     *           The hour of day (0-23) when the window starts.
     *     @type int $day_of_week
     *           The day of week, when the window starts.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Metastore\V1Alpha\Metastore::initOnce();
        parent::__construct($data);
    }

    /**
     * The hour of day (0-23) when the window starts.
     *
     * Generated from protobuf field <code>.google.protobuf.Int32Value hour_of_day = 1;</code>
     * @return \Google\Protobuf\Int32Value|null
     */
    public function getHourOfDay()
    {
        return isset($this->hour_of_day) ? $this->hour_of_day : null;
    }

    public function hasHourOfDay()
    {
        return isset($this->hour_of_day);
    }

    public function clearHourOfDay()
    {
        unset($this->hour_of_day);
    }

    /**
     * Returns the unboxed value from <code>getHourOfDay()</code>

     * The hour of day (0-23) when the window starts.
     *
     * Generated from protobuf field <code>.google.protobuf.Int32Value hour_of_day = 1;</code>
     * @return int|null
     */
    public function getHourOfDayUnwrapped()
    {
        return $this->readWrapperValue("hour_of_day");
    }

    /**
     * The hour of day (0-23) when the window starts.
     *
     * Generated from protobuf field <code>.google.protobuf.Int32Value hour_of_day = 1;</code>
     * @param \Google\Protobuf\Int32Value $var
     * @return $this
     */
    public function setHourOfDay($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Int32Value::class);
        $this->hour_of_day = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\Int32Value object.

     * The hour of day (0-23) when the window starts.
     *
     * Generated from protobuf field <code>.google.protobuf.Int32Value hour_of_day = 1;</code>
     * @param int|null $var
     * @return $this
     */
    public function setHourOfDayUnwrapped($var)
    {
        $this->writeWrapperValue("hour_of_day", $var);
        return $this;}

    /**
     * The day of week, when the window starts.
     *
     * Generated from protobuf field <code>.google.type.DayOfWeek day_of_week = 2;</code>
     * @return int
     */
    public function getDayOfWeek()
    {
        return $this->day_of_week;
    }

    /**
     * The day of week, when the window starts.
     *
     * Generated from protobuf field <code>.google.type.DayOfWeek day_of_week = 2;</code>
     * @param int $var
     * @return $this
     */
    public function setDayOfWeek($var)
    {
        GPBUtil::checkEnum($var, \Google\Type\DayOfWeek::class);
        $this->day_of_week = $var;

        return $this;
    }

}

