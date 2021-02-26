<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v4/common/simulation.proto

namespace Google\Ads\GoogleAds\V4\Common;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Projected metrics for a specific CPC bid amount.
 *
 * Generated from protobuf message <code>google.ads.googleads.v4.common.CpcBidSimulationPoint</code>
 */
class CpcBidSimulationPoint extends \Google\Protobuf\Internal\Message
{
    /**
     * The simulated CPC bid upon which projected metrics are based.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value cpc_bid_micros = 1;</code>
     */
    protected $cpc_bid_micros = null;
    /**
     * Projected number of biddable conversions.
     *
     * Generated from protobuf field <code>.google.protobuf.DoubleValue biddable_conversions = 2;</code>
     */
    protected $biddable_conversions = null;
    /**
     * Projected total value of biddable conversions.
     *
     * Generated from protobuf field <code>.google.protobuf.DoubleValue biddable_conversions_value = 3;</code>
     */
    protected $biddable_conversions_value = null;
    /**
     * Projected number of clicks.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value clicks = 4;</code>
     */
    protected $clicks = null;
    /**
     * Projected cost in micros.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value cost_micros = 5;</code>
     */
    protected $cost_micros = null;
    /**
     * Projected number of impressions.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value impressions = 6;</code>
     */
    protected $impressions = null;
    /**
     * Projected number of top slot impressions.
     * Only search advertising channel type supports this field.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value top_slot_impressions = 7;</code>
     */
    protected $top_slot_impressions = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Protobuf\Int64Value $cpc_bid_micros
     *           The simulated CPC bid upon which projected metrics are based.
     *     @type \Google\Protobuf\DoubleValue $biddable_conversions
     *           Projected number of biddable conversions.
     *     @type \Google\Protobuf\DoubleValue $biddable_conversions_value
     *           Projected total value of biddable conversions.
     *     @type \Google\Protobuf\Int64Value $clicks
     *           Projected number of clicks.
     *     @type \Google\Protobuf\Int64Value $cost_micros
     *           Projected cost in micros.
     *     @type \Google\Protobuf\Int64Value $impressions
     *           Projected number of impressions.
     *     @type \Google\Protobuf\Int64Value $top_slot_impressions
     *           Projected number of top slot impressions.
     *           Only search advertising channel type supports this field.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Ads\Googleads\V4\Common\Simulation::initOnce();
        parent::__construct($data);
    }

    /**
     * The simulated CPC bid upon which projected metrics are based.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value cpc_bid_micros = 1;</code>
     * @return \Google\Protobuf\Int64Value|null
     */
    public function getCpcBidMicros()
    {
        return isset($this->cpc_bid_micros) ? $this->cpc_bid_micros : null;
    }

    public function hasCpcBidMicros()
    {
        return isset($this->cpc_bid_micros);
    }

    public function clearCpcBidMicros()
    {
        unset($this->cpc_bid_micros);
    }

    /**
     * Returns the unboxed value from <code>getCpcBidMicros()</code>

     * The simulated CPC bid upon which projected metrics are based.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value cpc_bid_micros = 1;</code>
     * @return int|string|null
     */
    public function getCpcBidMicrosUnwrapped()
    {
        return $this->readWrapperValue("cpc_bid_micros");
    }

    /**
     * The simulated CPC bid upon which projected metrics are based.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value cpc_bid_micros = 1;</code>
     * @param \Google\Protobuf\Int64Value $var
     * @return $this
     */
    public function setCpcBidMicros($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Int64Value::class);
        $this->cpc_bid_micros = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\Int64Value object.

     * The simulated CPC bid upon which projected metrics are based.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value cpc_bid_micros = 1;</code>
     * @param int|string|null $var
     * @return $this
     */
    public function setCpcBidMicrosUnwrapped($var)
    {
        $this->writeWrapperValue("cpc_bid_micros", $var);
        return $this;}

    /**
     * Projected number of biddable conversions.
     *
     * Generated from protobuf field <code>.google.protobuf.DoubleValue biddable_conversions = 2;</code>
     * @return \Google\Protobuf\DoubleValue|null
     */
    public function getBiddableConversions()
    {
        return isset($this->biddable_conversions) ? $this->biddable_conversions : null;
    }

    public function hasBiddableConversions()
    {
        return isset($this->biddable_conversions);
    }

    public function clearBiddableConversions()
    {
        unset($this->biddable_conversions);
    }

    /**
     * Returns the unboxed value from <code>getBiddableConversions()</code>

     * Projected number of biddable conversions.
     *
     * Generated from protobuf field <code>.google.protobuf.DoubleValue biddable_conversions = 2;</code>
     * @return float|null
     */
    public function getBiddableConversionsUnwrapped()
    {
        return $this->readWrapperValue("biddable_conversions");
    }

    /**
     * Projected number of biddable conversions.
     *
     * Generated from protobuf field <code>.google.protobuf.DoubleValue biddable_conversions = 2;</code>
     * @param \Google\Protobuf\DoubleValue $var
     * @return $this
     */
    public function setBiddableConversions($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\DoubleValue::class);
        $this->biddable_conversions = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\DoubleValue object.

     * Projected number of biddable conversions.
     *
     * Generated from protobuf field <code>.google.protobuf.DoubleValue biddable_conversions = 2;</code>
     * @param float|null $var
     * @return $this
     */
    public function setBiddableConversionsUnwrapped($var)
    {
        $this->writeWrapperValue("biddable_conversions", $var);
        return $this;}

    /**
     * Projected total value of biddable conversions.
     *
     * Generated from protobuf field <code>.google.protobuf.DoubleValue biddable_conversions_value = 3;</code>
     * @return \Google\Protobuf\DoubleValue|null
     */
    public function getBiddableConversionsValue()
    {
        return isset($this->biddable_conversions_value) ? $this->biddable_conversions_value : null;
    }

    public function hasBiddableConversionsValue()
    {
        return isset($this->biddable_conversions_value);
    }

    public function clearBiddableConversionsValue()
    {
        unset($this->biddable_conversions_value);
    }

    /**
     * Returns the unboxed value from <code>getBiddableConversionsValue()</code>

     * Projected total value of biddable conversions.
     *
     * Generated from protobuf field <code>.google.protobuf.DoubleValue biddable_conversions_value = 3;</code>
     * @return float|null
     */
    public function getBiddableConversionsValueUnwrapped()
    {
        return $this->readWrapperValue("biddable_conversions_value");
    }

    /**
     * Projected total value of biddable conversions.
     *
     * Generated from protobuf field <code>.google.protobuf.DoubleValue biddable_conversions_value = 3;</code>
     * @param \Google\Protobuf\DoubleValue $var
     * @return $this
     */
    public function setBiddableConversionsValue($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\DoubleValue::class);
        $this->biddable_conversions_value = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\DoubleValue object.

     * Projected total value of biddable conversions.
     *
     * Generated from protobuf field <code>.google.protobuf.DoubleValue biddable_conversions_value = 3;</code>
     * @param float|null $var
     * @return $this
     */
    public function setBiddableConversionsValueUnwrapped($var)
    {
        $this->writeWrapperValue("biddable_conversions_value", $var);
        return $this;}

    /**
     * Projected number of clicks.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value clicks = 4;</code>
     * @return \Google\Protobuf\Int64Value|null
     */
    public function getClicks()
    {
        return isset($this->clicks) ? $this->clicks : null;
    }

    public function hasClicks()
    {
        return isset($this->clicks);
    }

    public function clearClicks()
    {
        unset($this->clicks);
    }

    /**
     * Returns the unboxed value from <code>getClicks()</code>

     * Projected number of clicks.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value clicks = 4;</code>
     * @return int|string|null
     */
    public function getClicksUnwrapped()
    {
        return $this->readWrapperValue("clicks");
    }

    /**
     * Projected number of clicks.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value clicks = 4;</code>
     * @param \Google\Protobuf\Int64Value $var
     * @return $this
     */
    public function setClicks($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Int64Value::class);
        $this->clicks = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\Int64Value object.

     * Projected number of clicks.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value clicks = 4;</code>
     * @param int|string|null $var
     * @return $this
     */
    public function setClicksUnwrapped($var)
    {
        $this->writeWrapperValue("clicks", $var);
        return $this;}

    /**
     * Projected cost in micros.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value cost_micros = 5;</code>
     * @return \Google\Protobuf\Int64Value|null
     */
    public function getCostMicros()
    {
        return isset($this->cost_micros) ? $this->cost_micros : null;
    }

    public function hasCostMicros()
    {
        return isset($this->cost_micros);
    }

    public function clearCostMicros()
    {
        unset($this->cost_micros);
    }

    /**
     * Returns the unboxed value from <code>getCostMicros()</code>

     * Projected cost in micros.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value cost_micros = 5;</code>
     * @return int|string|null
     */
    public function getCostMicrosUnwrapped()
    {
        return $this->readWrapperValue("cost_micros");
    }

    /**
     * Projected cost in micros.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value cost_micros = 5;</code>
     * @param \Google\Protobuf\Int64Value $var
     * @return $this
     */
    public function setCostMicros($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Int64Value::class);
        $this->cost_micros = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\Int64Value object.

     * Projected cost in micros.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value cost_micros = 5;</code>
     * @param int|string|null $var
     * @return $this
     */
    public function setCostMicrosUnwrapped($var)
    {
        $this->writeWrapperValue("cost_micros", $var);
        return $this;}

    /**
     * Projected number of impressions.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value impressions = 6;</code>
     * @return \Google\Protobuf\Int64Value|null
     */
    public function getImpressions()
    {
        return isset($this->impressions) ? $this->impressions : null;
    }

    public function hasImpressions()
    {
        return isset($this->impressions);
    }

    public function clearImpressions()
    {
        unset($this->impressions);
    }

    /**
     * Returns the unboxed value from <code>getImpressions()</code>

     * Projected number of impressions.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value impressions = 6;</code>
     * @return int|string|null
     */
    public function getImpressionsUnwrapped()
    {
        return $this->readWrapperValue("impressions");
    }

    /**
     * Projected number of impressions.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value impressions = 6;</code>
     * @param \Google\Protobuf\Int64Value $var
     * @return $this
     */
    public function setImpressions($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Int64Value::class);
        $this->impressions = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\Int64Value object.

     * Projected number of impressions.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value impressions = 6;</code>
     * @param int|string|null $var
     * @return $this
     */
    public function setImpressionsUnwrapped($var)
    {
        $this->writeWrapperValue("impressions", $var);
        return $this;}

    /**
     * Projected number of top slot impressions.
     * Only search advertising channel type supports this field.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value top_slot_impressions = 7;</code>
     * @return \Google\Protobuf\Int64Value|null
     */
    public function getTopSlotImpressions()
    {
        return isset($this->top_slot_impressions) ? $this->top_slot_impressions : null;
    }

    public function hasTopSlotImpressions()
    {
        return isset($this->top_slot_impressions);
    }

    public function clearTopSlotImpressions()
    {
        unset($this->top_slot_impressions);
    }

    /**
     * Returns the unboxed value from <code>getTopSlotImpressions()</code>

     * Projected number of top slot impressions.
     * Only search advertising channel type supports this field.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value top_slot_impressions = 7;</code>
     * @return int|string|null
     */
    public function getTopSlotImpressionsUnwrapped()
    {
        return $this->readWrapperValue("top_slot_impressions");
    }

    /**
     * Projected number of top slot impressions.
     * Only search advertising channel type supports this field.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value top_slot_impressions = 7;</code>
     * @param \Google\Protobuf\Int64Value $var
     * @return $this
     */
    public function setTopSlotImpressions($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Int64Value::class);
        $this->top_slot_impressions = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\Int64Value object.

     * Projected number of top slot impressions.
     * Only search advertising channel type supports this field.
     *
     * Generated from protobuf field <code>.google.protobuf.Int64Value top_slot_impressions = 7;</code>
     * @param int|string|null $var
     * @return $this
     */
    public function setTopSlotImpressionsUnwrapped($var)
    {
        $this->writeWrapperValue("top_slot_impressions", $var);
        return $this;}

}

