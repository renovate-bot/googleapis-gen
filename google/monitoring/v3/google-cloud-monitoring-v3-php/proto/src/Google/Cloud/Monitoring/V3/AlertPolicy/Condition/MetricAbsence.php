<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/monitoring/v3/alert.proto

namespace Google\Cloud\Monitoring\V3\AlertPolicy\Condition;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A condition type that checks that monitored resources
 * are reporting data. The configuration defines a metric and
 * a set of monitored resources. The predicate is considered in violation
 * when a time series for the specified metric of a monitored
 * resource does not include any data in the specified `duration`.
 *
 * Generated from protobuf message <code>google.monitoring.v3.AlertPolicy.Condition.MetricAbsence</code>
 */
class MetricAbsence extends \Google\Protobuf\Internal\Message
{
    /**
     * A [filter](https://cloud.google.com/monitoring/api/v3/filters) that
     * identifies which time series should be compared with the threshold.
     * The filter is similar to the one that is specified in the
     * [`ListTimeSeries`
     * request](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.timeSeries/list)
     * (that call is useful to verify the time series that will be retrieved /
     * processed) and must specify the metric type and optionally may contain
     * restrictions on resource type, resource labels, and metric labels.
     * This field may not exceed 2048 Unicode characters in length.
     *
     * Generated from protobuf field <code>string filter = 1;</code>
     */
    protected $filter = '';
    /**
     * Specifies the alignment of data points in individual time series as
     * well as how to combine the retrieved time series together (such as
     * when aggregating multiple streams on each resource to a single
     * stream for each resource or when aggregating streams across all
     * members of a group of resrouces). Multiple aggregations
     * are applied in the order specified.
     * This field is similar to the one in the [`ListTimeSeries`
     * request](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.timeSeries/list).
     * It is advisable to use the `ListTimeSeries` method when debugging this
     * field.
     *
     * Generated from protobuf field <code>repeated .google.monitoring.v3.Aggregation aggregations = 5;</code>
     */
    private $aggregations;
    /**
     * The amount of time that a time series must fail to report new
     * data to be considered failing. Currently, only values that
     * are a multiple of a minute--e.g.  60, 120, or 300
     * seconds--are supported. If an invalid value is given, an
     * error will be returned. The `Duration.nanos` field is
     * ignored.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration duration = 2;</code>
     */
    protected $duration = null;
    /**
     * The number/percent of time series for which the comparison must hold
     * in order for the condition to trigger. If unspecified, then the
     * condition will trigger if the comparison is true for any of the
     * time series that have been identified by `filter` and `aggregations`.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.AlertPolicy.Condition.Trigger trigger = 3;</code>
     */
    protected $trigger = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $filter
     *           A [filter](https://cloud.google.com/monitoring/api/v3/filters) that
     *           identifies which time series should be compared with the threshold.
     *           The filter is similar to the one that is specified in the
     *           [`ListTimeSeries`
     *           request](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.timeSeries/list)
     *           (that call is useful to verify the time series that will be retrieved /
     *           processed) and must specify the metric type and optionally may contain
     *           restrictions on resource type, resource labels, and metric labels.
     *           This field may not exceed 2048 Unicode characters in length.
     *     @type \Google\Cloud\Monitoring\V3\Aggregation[]|\Google\Protobuf\Internal\RepeatedField $aggregations
     *           Specifies the alignment of data points in individual time series as
     *           well as how to combine the retrieved time series together (such as
     *           when aggregating multiple streams on each resource to a single
     *           stream for each resource or when aggregating streams across all
     *           members of a group of resrouces). Multiple aggregations
     *           are applied in the order specified.
     *           This field is similar to the one in the [`ListTimeSeries`
     *           request](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.timeSeries/list).
     *           It is advisable to use the `ListTimeSeries` method when debugging this
     *           field.
     *     @type \Google\Protobuf\Duration $duration
     *           The amount of time that a time series must fail to report new
     *           data to be considered failing. Currently, only values that
     *           are a multiple of a minute--e.g.  60, 120, or 300
     *           seconds--are supported. If an invalid value is given, an
     *           error will be returned. The `Duration.nanos` field is
     *           ignored.
     *     @type \Google\Cloud\Monitoring\V3\AlertPolicy\Condition\Trigger $trigger
     *           The number/percent of time series for which the comparison must hold
     *           in order for the condition to trigger. If unspecified, then the
     *           condition will trigger if the comparison is true for any of the
     *           time series that have been identified by `filter` and `aggregations`.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Monitoring\V3\Alert::initOnce();
        parent::__construct($data);
    }

    /**
     * A [filter](https://cloud.google.com/monitoring/api/v3/filters) that
     * identifies which time series should be compared with the threshold.
     * The filter is similar to the one that is specified in the
     * [`ListTimeSeries`
     * request](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.timeSeries/list)
     * (that call is useful to verify the time series that will be retrieved /
     * processed) and must specify the metric type and optionally may contain
     * restrictions on resource type, resource labels, and metric labels.
     * This field may not exceed 2048 Unicode characters in length.
     *
     * Generated from protobuf field <code>string filter = 1;</code>
     * @return string
     */
    public function getFilter()
    {
        return $this->filter;
    }

    /**
     * A [filter](https://cloud.google.com/monitoring/api/v3/filters) that
     * identifies which time series should be compared with the threshold.
     * The filter is similar to the one that is specified in the
     * [`ListTimeSeries`
     * request](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.timeSeries/list)
     * (that call is useful to verify the time series that will be retrieved /
     * processed) and must specify the metric type and optionally may contain
     * restrictions on resource type, resource labels, and metric labels.
     * This field may not exceed 2048 Unicode characters in length.
     *
     * Generated from protobuf field <code>string filter = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setFilter($var)
    {
        GPBUtil::checkString($var, True);
        $this->filter = $var;

        return $this;
    }

    /**
     * Specifies the alignment of data points in individual time series as
     * well as how to combine the retrieved time series together (such as
     * when aggregating multiple streams on each resource to a single
     * stream for each resource or when aggregating streams across all
     * members of a group of resrouces). Multiple aggregations
     * are applied in the order specified.
     * This field is similar to the one in the [`ListTimeSeries`
     * request](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.timeSeries/list).
     * It is advisable to use the `ListTimeSeries` method when debugging this
     * field.
     *
     * Generated from protobuf field <code>repeated .google.monitoring.v3.Aggregation aggregations = 5;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getAggregations()
    {
        return $this->aggregations;
    }

    /**
     * Specifies the alignment of data points in individual time series as
     * well as how to combine the retrieved time series together (such as
     * when aggregating multiple streams on each resource to a single
     * stream for each resource or when aggregating streams across all
     * members of a group of resrouces). Multiple aggregations
     * are applied in the order specified.
     * This field is similar to the one in the [`ListTimeSeries`
     * request](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.timeSeries/list).
     * It is advisable to use the `ListTimeSeries` method when debugging this
     * field.
     *
     * Generated from protobuf field <code>repeated .google.monitoring.v3.Aggregation aggregations = 5;</code>
     * @param \Google\Cloud\Monitoring\V3\Aggregation[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setAggregations($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Monitoring\V3\Aggregation::class);
        $this->aggregations = $arr;

        return $this;
    }

    /**
     * The amount of time that a time series must fail to report new
     * data to be considered failing. Currently, only values that
     * are a multiple of a minute--e.g.  60, 120, or 300
     * seconds--are supported. If an invalid value is given, an
     * error will be returned. The `Duration.nanos` field is
     * ignored.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration duration = 2;</code>
     * @return \Google\Protobuf\Duration|null
     */
    public function getDuration()
    {
        return isset($this->duration) ? $this->duration : null;
    }

    public function hasDuration()
    {
        return isset($this->duration);
    }

    public function clearDuration()
    {
        unset($this->duration);
    }

    /**
     * The amount of time that a time series must fail to report new
     * data to be considered failing. Currently, only values that
     * are a multiple of a minute--e.g.  60, 120, or 300
     * seconds--are supported. If an invalid value is given, an
     * error will be returned. The `Duration.nanos` field is
     * ignored.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration duration = 2;</code>
     * @param \Google\Protobuf\Duration $var
     * @return $this
     */
    public function setDuration($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Duration::class);
        $this->duration = $var;

        return $this;
    }

    /**
     * The number/percent of time series for which the comparison must hold
     * in order for the condition to trigger. If unspecified, then the
     * condition will trigger if the comparison is true for any of the
     * time series that have been identified by `filter` and `aggregations`.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.AlertPolicy.Condition.Trigger trigger = 3;</code>
     * @return \Google\Cloud\Monitoring\V3\AlertPolicy\Condition\Trigger|null
     */
    public function getTrigger()
    {
        return isset($this->trigger) ? $this->trigger : null;
    }

    public function hasTrigger()
    {
        return isset($this->trigger);
    }

    public function clearTrigger()
    {
        unset($this->trigger);
    }

    /**
     * The number/percent of time series for which the comparison must hold
     * in order for the condition to trigger. If unspecified, then the
     * condition will trigger if the comparison is true for any of the
     * time series that have been identified by `filter` and `aggregations`.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.AlertPolicy.Condition.Trigger trigger = 3;</code>
     * @param \Google\Cloud\Monitoring\V3\AlertPolicy\Condition\Trigger $var
     * @return $this
     */
    public function setTrigger($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Monitoring\V3\AlertPolicy\Condition\Trigger::class);
        $this->trigger = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(MetricAbsence::class, \Google\Cloud\Monitoring\V3\AlertPolicy_Condition_MetricAbsence::class);

