<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/monitoring/v3/common.proto

namespace Google\Cloud\Monitoring\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Describes how to combine multiple time series to provide a different view of
 * the data.  Aggregation of time series is done in two steps. First, each time
 * series in the set is _aligned_ to the same time interval boundaries, then the
 * set of time series is optionally _reduced_ in number.
 * Alignment consists of applying the `per_series_aligner` operation
 * to each time series after its data has been divided into regular
 * `alignment_period` time intervals. This process takes _all_ of the data
 * points in an alignment period, applies a mathematical transformation such as
 * averaging, minimum, maximum, delta, etc., and converts them into a single
 * data point per period.
 * Reduction is when the aligned and transformed time series can optionally be
 * combined, reducing the number of time series through similar mathematical
 * transformations. Reduction involves applying a `cross_series_reducer` to
 * all the time series, optionally sorting the time series into subsets with
 * `group_by_fields`, and applying the reducer to each subset.
 * The raw time series data can contain a huge amount of information from
 * multiple sources. Alignment and reduction transforms this mass of data into
 * a more manageable and representative collection of data, for example "the
 * 95% latency across the average of all tasks in a cluster". This
 * representative data can be more easily graphed and comprehended, and the
 * individual time series data is still available for later drilldown. For more
 * details, see [Filtering and
 * aggregation](https://cloud.google.com/monitoring/api/v3/aggregation).
 *
 * Generated from protobuf message <code>google.monitoring.v3.Aggregation</code>
 */
class Aggregation extends \Google\Protobuf\Internal\Message
{
    /**
     * The `alignment_period` specifies a time interval, in seconds, that is used
     * to divide the data in all the
     * [time series][google.monitoring.v3.TimeSeries] into consistent blocks of
     * time. This will be done before the per-series aligner can be applied to
     * the data.
     * The value must be at least 60 seconds. If a per-series aligner other than
     * `ALIGN_NONE` is specified, this field is required or an error is returned.
     * If no per-series aligner is specified, or the aligner `ALIGN_NONE` is
     * specified, then this field is ignored.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration alignment_period = 1;</code>
     */
    protected $alignment_period = null;
    /**
     * An `Aligner` describes how to bring the data points in a single
     * time series into temporal alignment. Except for `ALIGN_NONE`, all
     * alignments cause all the data points in an `alignment_period` to be
     * mathematically grouped together, resulting in a single data point for
     * each `alignment_period` with end timestamp at the end of the period.
     * Not all alignment operations may be applied to all time series. The valid
     * choices depend on the `metric_kind` and `value_type` of the original time
     * series. Alignment can change the `metric_kind` or the `value_type` of
     * the time series.
     * Time series data must be aligned in order to perform cross-time
     * series reduction. If `cross_series_reducer` is specified, then
     * `per_series_aligner` must be specified and not equal to `ALIGN_NONE`
     * and `alignment_period` must be specified; otherwise, an error is
     * returned.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.Aggregation.Aligner per_series_aligner = 2;</code>
     */
    protected $per_series_aligner = 0;
    /**
     * The reduction operation to be used to combine time series into a single
     * time series, where the value of each data point in the resulting series is
     * a function of all the already aligned values in the input time series.
     * Not all reducer operations can be applied to all time series. The valid
     * choices depend on the `metric_kind` and the `value_type` of the original
     * time series. Reduction can yield a time series with a different
     * `metric_kind` or `value_type` than the input time series.
     * Time series data must first be aligned (see `per_series_aligner`) in order
     * to perform cross-time series reduction. If `cross_series_reducer` is
     * specified, then `per_series_aligner` must be specified, and must not be
     * `ALIGN_NONE`. An `alignment_period` must also be specified; otherwise, an
     * error is returned.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.Aggregation.Reducer cross_series_reducer = 4;</code>
     */
    protected $cross_series_reducer = 0;
    /**
     * The set of fields to preserve when `cross_series_reducer` is
     * specified. The `group_by_fields` determine how the time series are
     * partitioned into subsets prior to applying the aggregation
     * operation. Each subset contains time series that have the same
     * value for each of the grouping fields. Each individual time
     * series is a member of exactly one subset. The
     * `cross_series_reducer` is applied to each subset of time series.
     * It is not possible to reduce across different resource types, so
     * this field implicitly contains `resource.type`.  Fields not
     * specified in `group_by_fields` are aggregated away.  If
     * `group_by_fields` is not specified and all the time series have
     * the same resource type, then the time series are aggregated into
     * a single output time series. If `cross_series_reducer` is not
     * defined, this field is ignored.
     *
     * Generated from protobuf field <code>repeated string group_by_fields = 5;</code>
     */
    private $group_by_fields;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Protobuf\Duration $alignment_period
     *           The `alignment_period` specifies a time interval, in seconds, that is used
     *           to divide the data in all the
     *           [time series][google.monitoring.v3.TimeSeries] into consistent blocks of
     *           time. This will be done before the per-series aligner can be applied to
     *           the data.
     *           The value must be at least 60 seconds. If a per-series aligner other than
     *           `ALIGN_NONE` is specified, this field is required or an error is returned.
     *           If no per-series aligner is specified, or the aligner `ALIGN_NONE` is
     *           specified, then this field is ignored.
     *     @type int $per_series_aligner
     *           An `Aligner` describes how to bring the data points in a single
     *           time series into temporal alignment. Except for `ALIGN_NONE`, all
     *           alignments cause all the data points in an `alignment_period` to be
     *           mathematically grouped together, resulting in a single data point for
     *           each `alignment_period` with end timestamp at the end of the period.
     *           Not all alignment operations may be applied to all time series. The valid
     *           choices depend on the `metric_kind` and `value_type` of the original time
     *           series. Alignment can change the `metric_kind` or the `value_type` of
     *           the time series.
     *           Time series data must be aligned in order to perform cross-time
     *           series reduction. If `cross_series_reducer` is specified, then
     *           `per_series_aligner` must be specified and not equal to `ALIGN_NONE`
     *           and `alignment_period` must be specified; otherwise, an error is
     *           returned.
     *     @type int $cross_series_reducer
     *           The reduction operation to be used to combine time series into a single
     *           time series, where the value of each data point in the resulting series is
     *           a function of all the already aligned values in the input time series.
     *           Not all reducer operations can be applied to all time series. The valid
     *           choices depend on the `metric_kind` and the `value_type` of the original
     *           time series. Reduction can yield a time series with a different
     *           `metric_kind` or `value_type` than the input time series.
     *           Time series data must first be aligned (see `per_series_aligner`) in order
     *           to perform cross-time series reduction. If `cross_series_reducer` is
     *           specified, then `per_series_aligner` must be specified, and must not be
     *           `ALIGN_NONE`. An `alignment_period` must also be specified; otherwise, an
     *           error is returned.
     *     @type string[]|\Google\Protobuf\Internal\RepeatedField $group_by_fields
     *           The set of fields to preserve when `cross_series_reducer` is
     *           specified. The `group_by_fields` determine how the time series are
     *           partitioned into subsets prior to applying the aggregation
     *           operation. Each subset contains time series that have the same
     *           value for each of the grouping fields. Each individual time
     *           series is a member of exactly one subset. The
     *           `cross_series_reducer` is applied to each subset of time series.
     *           It is not possible to reduce across different resource types, so
     *           this field implicitly contains `resource.type`.  Fields not
     *           specified in `group_by_fields` are aggregated away.  If
     *           `group_by_fields` is not specified and all the time series have
     *           the same resource type, then the time series are aggregated into
     *           a single output time series. If `cross_series_reducer` is not
     *           defined, this field is ignored.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Monitoring\V3\Common::initOnce();
        parent::__construct($data);
    }

    /**
     * The `alignment_period` specifies a time interval, in seconds, that is used
     * to divide the data in all the
     * [time series][google.monitoring.v3.TimeSeries] into consistent blocks of
     * time. This will be done before the per-series aligner can be applied to
     * the data.
     * The value must be at least 60 seconds. If a per-series aligner other than
     * `ALIGN_NONE` is specified, this field is required or an error is returned.
     * If no per-series aligner is specified, or the aligner `ALIGN_NONE` is
     * specified, then this field is ignored.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration alignment_period = 1;</code>
     * @return \Google\Protobuf\Duration|null
     */
    public function getAlignmentPeriod()
    {
        return isset($this->alignment_period) ? $this->alignment_period : null;
    }

    public function hasAlignmentPeriod()
    {
        return isset($this->alignment_period);
    }

    public function clearAlignmentPeriod()
    {
        unset($this->alignment_period);
    }

    /**
     * The `alignment_period` specifies a time interval, in seconds, that is used
     * to divide the data in all the
     * [time series][google.monitoring.v3.TimeSeries] into consistent blocks of
     * time. This will be done before the per-series aligner can be applied to
     * the data.
     * The value must be at least 60 seconds. If a per-series aligner other than
     * `ALIGN_NONE` is specified, this field is required or an error is returned.
     * If no per-series aligner is specified, or the aligner `ALIGN_NONE` is
     * specified, then this field is ignored.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration alignment_period = 1;</code>
     * @param \Google\Protobuf\Duration $var
     * @return $this
     */
    public function setAlignmentPeriod($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Duration::class);
        $this->alignment_period = $var;

        return $this;
    }

    /**
     * An `Aligner` describes how to bring the data points in a single
     * time series into temporal alignment. Except for `ALIGN_NONE`, all
     * alignments cause all the data points in an `alignment_period` to be
     * mathematically grouped together, resulting in a single data point for
     * each `alignment_period` with end timestamp at the end of the period.
     * Not all alignment operations may be applied to all time series. The valid
     * choices depend on the `metric_kind` and `value_type` of the original time
     * series. Alignment can change the `metric_kind` or the `value_type` of
     * the time series.
     * Time series data must be aligned in order to perform cross-time
     * series reduction. If `cross_series_reducer` is specified, then
     * `per_series_aligner` must be specified and not equal to `ALIGN_NONE`
     * and `alignment_period` must be specified; otherwise, an error is
     * returned.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.Aggregation.Aligner per_series_aligner = 2;</code>
     * @return int
     */
    public function getPerSeriesAligner()
    {
        return $this->per_series_aligner;
    }

    /**
     * An `Aligner` describes how to bring the data points in a single
     * time series into temporal alignment. Except for `ALIGN_NONE`, all
     * alignments cause all the data points in an `alignment_period` to be
     * mathematically grouped together, resulting in a single data point for
     * each `alignment_period` with end timestamp at the end of the period.
     * Not all alignment operations may be applied to all time series. The valid
     * choices depend on the `metric_kind` and `value_type` of the original time
     * series. Alignment can change the `metric_kind` or the `value_type` of
     * the time series.
     * Time series data must be aligned in order to perform cross-time
     * series reduction. If `cross_series_reducer` is specified, then
     * `per_series_aligner` must be specified and not equal to `ALIGN_NONE`
     * and `alignment_period` must be specified; otherwise, an error is
     * returned.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.Aggregation.Aligner per_series_aligner = 2;</code>
     * @param int $var
     * @return $this
     */
    public function setPerSeriesAligner($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\Monitoring\V3\Aggregation\Aligner::class);
        $this->per_series_aligner = $var;

        return $this;
    }

    /**
     * The reduction operation to be used to combine time series into a single
     * time series, where the value of each data point in the resulting series is
     * a function of all the already aligned values in the input time series.
     * Not all reducer operations can be applied to all time series. The valid
     * choices depend on the `metric_kind` and the `value_type` of the original
     * time series. Reduction can yield a time series with a different
     * `metric_kind` or `value_type` than the input time series.
     * Time series data must first be aligned (see `per_series_aligner`) in order
     * to perform cross-time series reduction. If `cross_series_reducer` is
     * specified, then `per_series_aligner` must be specified, and must not be
     * `ALIGN_NONE`. An `alignment_period` must also be specified; otherwise, an
     * error is returned.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.Aggregation.Reducer cross_series_reducer = 4;</code>
     * @return int
     */
    public function getCrossSeriesReducer()
    {
        return $this->cross_series_reducer;
    }

    /**
     * The reduction operation to be used to combine time series into a single
     * time series, where the value of each data point in the resulting series is
     * a function of all the already aligned values in the input time series.
     * Not all reducer operations can be applied to all time series. The valid
     * choices depend on the `metric_kind` and the `value_type` of the original
     * time series. Reduction can yield a time series with a different
     * `metric_kind` or `value_type` than the input time series.
     * Time series data must first be aligned (see `per_series_aligner`) in order
     * to perform cross-time series reduction. If `cross_series_reducer` is
     * specified, then `per_series_aligner` must be specified, and must not be
     * `ALIGN_NONE`. An `alignment_period` must also be specified; otherwise, an
     * error is returned.
     *
     * Generated from protobuf field <code>.google.monitoring.v3.Aggregation.Reducer cross_series_reducer = 4;</code>
     * @param int $var
     * @return $this
     */
    public function setCrossSeriesReducer($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\Monitoring\V3\Aggregation\Reducer::class);
        $this->cross_series_reducer = $var;

        return $this;
    }

    /**
     * The set of fields to preserve when `cross_series_reducer` is
     * specified. The `group_by_fields` determine how the time series are
     * partitioned into subsets prior to applying the aggregation
     * operation. Each subset contains time series that have the same
     * value for each of the grouping fields. Each individual time
     * series is a member of exactly one subset. The
     * `cross_series_reducer` is applied to each subset of time series.
     * It is not possible to reduce across different resource types, so
     * this field implicitly contains `resource.type`.  Fields not
     * specified in `group_by_fields` are aggregated away.  If
     * `group_by_fields` is not specified and all the time series have
     * the same resource type, then the time series are aggregated into
     * a single output time series. If `cross_series_reducer` is not
     * defined, this field is ignored.
     *
     * Generated from protobuf field <code>repeated string group_by_fields = 5;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getGroupByFields()
    {
        return $this->group_by_fields;
    }

    /**
     * The set of fields to preserve when `cross_series_reducer` is
     * specified. The `group_by_fields` determine how the time series are
     * partitioned into subsets prior to applying the aggregation
     * operation. Each subset contains time series that have the same
     * value for each of the grouping fields. Each individual time
     * series is a member of exactly one subset. The
     * `cross_series_reducer` is applied to each subset of time series.
     * It is not possible to reduce across different resource types, so
     * this field implicitly contains `resource.type`.  Fields not
     * specified in `group_by_fields` are aggregated away.  If
     * `group_by_fields` is not specified and all the time series have
     * the same resource type, then the time series are aggregated into
     * a single output time series. If `cross_series_reducer` is not
     * defined, this field is ignored.
     *
     * Generated from protobuf field <code>repeated string group_by_fields = 5;</code>
     * @param string[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setGroupByFields($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::STRING);
        $this->group_by_fields = $arr;

        return $this;
    }

}

