<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v5/services/reach_plan_service.proto

namespace Google\Ads\GoogleAds\V5\Services;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Forecasted traffic metrics for the planned products and targeting.
 *
 * Generated from protobuf message <code>google.ads.googleads.v5.services.Forecast</code>
 */
class Forecast extends \Google\Protobuf\Internal\Message
{
    /**
     * Number of unique people reached at least
     * GenerateReachForecastRequest.min_effective_frequency times that exactly
     * matches the Targeting.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value on_target_reach = 1;</code>
     */
    protected $on_target_reach = null;
    /**
     * Total number of unique people reached at least
     * GenerateReachForecastRequest.min_effective_frequency times. This includes
     * people that may fall outside the specified Targeting.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value total_reach = 2;</code>
     */
    protected $total_reach = null;
    /**
     * Number of ad impressions that exactly matches the Targeting.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value on_target_impressions = 3;</code>
     */
    protected $on_target_impressions = null;
    /**
     * Total number of ad impressions. This includes impressions that may fall
     * outside the specified Targeting, due to insufficient information on
     * signed-in users.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value total_impressions = 4;</code>
     */
    protected $total_impressions = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Protobuf\Int64Value $on_target_reach
     *           Number of unique people reached at least
     *           GenerateReachForecastRequest.min_effective_frequency times that exactly
     *           matches the Targeting.
     *     @type \Google\Protobuf\Int64Value $total_reach
     *           Total number of unique people reached at least
     *           GenerateReachForecastRequest.min_effective_frequency times. This includes
     *           people that may fall outside the specified Targeting.
     *     @type \Google\Protobuf\Int64Value $on_target_impressions
     *           Number of ad impressions that exactly matches the Targeting.
     *     @type \Google\Protobuf\Int64Value $total_impressions
     *           Total number of ad impressions. This includes impressions that may fall
     *           outside the specified Targeting, due to insufficient information on
     *           signed-in users.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Ads\Googleads\V5\Services\ReachPlanService::initOnce();
        parent::__construct($data);
    }

    /**
     * Number of unique people reached at least
     * GenerateReachForecastRequest.min_effective_frequency times that exactly
     * matches the Targeting.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value on_target_reach = 1;</code>
     * @return \Google\Protobuf\Int64Value|null
     */
    public function getOnTargetReach()
    {
        return isset($this->on_target_reach) ? $this->on_target_reach : null;
    }

    public function hasOnTargetReach()
    {
        return isset($this->on_target_reach);
    }

    public function clearOnTargetReach()
    {
        unset($this->on_target_reach);
    }

    /**
     * Returns the unboxed value from <code>getOnTargetReach()</code>

     * Number of unique people reached at least
     * GenerateReachForecastRequest.min_effective_frequency times that exactly
     * matches the Targeting.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value on_target_reach = 1;</code>
     * @return int|string|null
     */
    public function getOnTargetReachUnwrapped()
    {
        return $this->readWrapperValue("on_target_reach");
    }

    /**
     * Number of unique people reached at least
     * GenerateReachForecastRequest.min_effective_frequency times that exactly
     * matches the Targeting.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value on_target_reach = 1;</code>
     * @param \Google\Protobuf\Int64Value $var
     * @return $this
     */
    public function setOnTargetReach($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Int64Value::class);
        $this->on_target_reach = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\Int64Value object.

     * Number of unique people reached at least
     * GenerateReachForecastRequest.min_effective_frequency times that exactly
     * matches the Targeting.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value on_target_reach = 1;</code>
     * @param int|string|null $var
     * @return $this
     */
    public function setOnTargetReachUnwrapped($var)
    {
        $this->writeWrapperValue("on_target_reach", $var);
        return $this;}

    /**
     * Total number of unique people reached at least
     * GenerateReachForecastRequest.min_effective_frequency times. This includes
     * people that may fall outside the specified Targeting.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value total_reach = 2;</code>
     * @return \Google\Protobuf\Int64Value|null
     */
    public function getTotalReach()
    {
        return isset($this->total_reach) ? $this->total_reach : null;
    }

    public function hasTotalReach()
    {
        return isset($this->total_reach);
    }

    public function clearTotalReach()
    {
        unset($this->total_reach);
    }

    /**
     * Returns the unboxed value from <code>getTotalReach()</code>

     * Total number of unique people reached at least
     * GenerateReachForecastRequest.min_effective_frequency times. This includes
     * people that may fall outside the specified Targeting.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value total_reach = 2;</code>
     * @return int|string|null
     */
    public function getTotalReachUnwrapped()
    {
        return $this->readWrapperValue("total_reach");
    }

    /**
     * Total number of unique people reached at least
     * GenerateReachForecastRequest.min_effective_frequency times. This includes
     * people that may fall outside the specified Targeting.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value total_reach = 2;</code>
     * @param \Google\Protobuf\Int64Value $var
     * @return $this
     */
    public function setTotalReach($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Int64Value::class);
        $this->total_reach = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\Int64Value object.

     * Total number of unique people reached at least
     * GenerateReachForecastRequest.min_effective_frequency times. This includes
     * people that may fall outside the specified Targeting.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value total_reach = 2;</code>
     * @param int|string|null $var
     * @return $this
     */
    public function setTotalReachUnwrapped($var)
    {
        $this->writeWrapperValue("total_reach", $var);
        return $this;}

    /**
     * Number of ad impressions that exactly matches the Targeting.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value on_target_impressions = 3;</code>
     * @return \Google\Protobuf\Int64Value|null
     */
    public function getOnTargetImpressions()
    {
        return isset($this->on_target_impressions) ? $this->on_target_impressions : null;
    }

    public function hasOnTargetImpressions()
    {
        return isset($this->on_target_impressions);
    }

    public function clearOnTargetImpressions()
    {
        unset($this->on_target_impressions);
    }

    /**
     * Returns the unboxed value from <code>getOnTargetImpressions()</code>

     * Number of ad impressions that exactly matches the Targeting.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value on_target_impressions = 3;</code>
     * @return int|string|null
     */
    public function getOnTargetImpressionsUnwrapped()
    {
        return $this->readWrapperValue("on_target_impressions");
    }

    /**
     * Number of ad impressions that exactly matches the Targeting.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value on_target_impressions = 3;</code>
     * @param \Google\Protobuf\Int64Value $var
     * @return $this
     */
    public function setOnTargetImpressions($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Int64Value::class);
        $this->on_target_impressions = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\Int64Value object.

     * Number of ad impressions that exactly matches the Targeting.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value on_target_impressions = 3;</code>
     * @param int|string|null $var
     * @return $this
     */
    public function setOnTargetImpressionsUnwrapped($var)
    {
        $this->writeWrapperValue("on_target_impressions", $var);
        return $this;}

    /**
     * Total number of ad impressions. This includes impressions that may fall
     * outside the specified Targeting, due to insufficient information on
     * signed-in users.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value total_impressions = 4;</code>
     * @return \Google\Protobuf\Int64Value|null
     */
    public function getTotalImpressions()
    {
        return isset($this->total_impressions) ? $this->total_impressions : null;
    }

    public function hasTotalImpressions()
    {
        return isset($this->total_impressions);
    }

    public function clearTotalImpressions()
    {
        unset($this->total_impressions);
    }

    /**
     * Returns the unboxed value from <code>getTotalImpressions()</code>

     * Total number of ad impressions. This includes impressions that may fall
     * outside the specified Targeting, due to insufficient information on
     * signed-in users.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value total_impressions = 4;</code>
     * @return int|string|null
     */
    public function getTotalImpressionsUnwrapped()
    {
        return $this->readWrapperValue("total_impressions");
    }

    /**
     * Total number of ad impressions. This includes impressions that may fall
     * outside the specified Targeting, due to insufficient information on
     * signed-in users.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value total_impressions = 4;</code>
     * @param \Google\Protobuf\Int64Value $var
     * @return $this
     */
    public function setTotalImpressions($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Int64Value::class);
        $this->total_impressions = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\Int64Value object.

     * Total number of ad impressions. This includes impressions that may fall
     * outside the specified Targeting, due to insufficient information on
     * signed-in users.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value total_impressions = 4;</code>
     * @param int|string|null $var
     * @return $this
     */
    public function setTotalImpressionsUnwrapped($var)
    {
        $this->writeWrapperValue("total_impressions", $var);
        return $this;}

}

