<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/privacy/dlp/v2/dlp.proto

namespace Google\Cloud\Dlp\V2\AnalyzeDataSourceRiskDetails;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Result of the numerical stats computation.
 *
 * Generated from protobuf message <code>google.privacy.dlp.v2.AnalyzeDataSourceRiskDetails.NumericalStatsResult</code>
 */
class NumericalStatsResult extends \Google\Protobuf\Internal\Message
{
    /**
     * Minimum value appearing in the column.
     *
     * Generated from protobuf field <code>.google.privacy.dlp.v2.Value min_value = 1;</code>
     */
    protected $min_value = null;
    /**
     * Maximum value appearing in the column.
     *
     * Generated from protobuf field <code>.google.privacy.dlp.v2.Value max_value = 2;</code>
     */
    protected $max_value = null;
    /**
     * List of 99 values that partition the set of field values into 100 equal
     * sized buckets.
     *
     * Generated from protobuf field <code>repeated .google.privacy.dlp.v2.Value quantile_values = 4;</code>
     */
    private $quantile_values;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Dlp\V2\Value $min_value
     *           Minimum value appearing in the column.
     *     @type \Google\Cloud\Dlp\V2\Value $max_value
     *           Maximum value appearing in the column.
     *     @type \Google\Cloud\Dlp\V2\Value[]|\Google\Protobuf\Internal\RepeatedField $quantile_values
     *           List of 99 values that partition the set of field values into 100 equal
     *           sized buckets.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Privacy\Dlp\V2\Dlp::initOnce();
        parent::__construct($data);
    }

    /**
     * Minimum value appearing in the column.
     *
     * Generated from protobuf field <code>.google.privacy.dlp.v2.Value min_value = 1;</code>
     * @return \Google\Cloud\Dlp\V2\Value|null
     */
    public function getMinValue()
    {
        return isset($this->min_value) ? $this->min_value : null;
    }

    public function hasMinValue()
    {
        return isset($this->min_value);
    }

    public function clearMinValue()
    {
        unset($this->min_value);
    }

    /**
     * Minimum value appearing in the column.
     *
     * Generated from protobuf field <code>.google.privacy.dlp.v2.Value min_value = 1;</code>
     * @param \Google\Cloud\Dlp\V2\Value $var
     * @return $this
     */
    public function setMinValue($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dlp\V2\Value::class);
        $this->min_value = $var;

        return $this;
    }

    /**
     * Maximum value appearing in the column.
     *
     * Generated from protobuf field <code>.google.privacy.dlp.v2.Value max_value = 2;</code>
     * @return \Google\Cloud\Dlp\V2\Value|null
     */
    public function getMaxValue()
    {
        return isset($this->max_value) ? $this->max_value : null;
    }

    public function hasMaxValue()
    {
        return isset($this->max_value);
    }

    public function clearMaxValue()
    {
        unset($this->max_value);
    }

    /**
     * Maximum value appearing in the column.
     *
     * Generated from protobuf field <code>.google.privacy.dlp.v2.Value max_value = 2;</code>
     * @param \Google\Cloud\Dlp\V2\Value $var
     * @return $this
     */
    public function setMaxValue($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dlp\V2\Value::class);
        $this->max_value = $var;

        return $this;
    }

    /**
     * List of 99 values that partition the set of field values into 100 equal
     * sized buckets.
     *
     * Generated from protobuf field <code>repeated .google.privacy.dlp.v2.Value quantile_values = 4;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getQuantileValues()
    {
        return $this->quantile_values;
    }

    /**
     * List of 99 values that partition the set of field values into 100 equal
     * sized buckets.
     *
     * Generated from protobuf field <code>repeated .google.privacy.dlp.v2.Value quantile_values = 4;</code>
     * @param \Google\Cloud\Dlp\V2\Value[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setQuantileValues($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Dlp\V2\Value::class);
        $this->quantile_values = $arr;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(NumericalStatsResult::class, \Google\Cloud\Dlp\V2\AnalyzeDataSourceRiskDetails_NumericalStatsResult::class);

