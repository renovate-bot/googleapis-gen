<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v9/common/explorer_auto_optimizer_setting.proto

namespace Google\Ads\GoogleAds\V9\Common;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Settings for the Display Campaign Optimizer, initially named "Explorer".
 * Learn more about
 * [automatic targeting](https://support.google.com/google-ads/answer/190596).
 *
 * Generated from protobuf message <code>google.ads.googleads.v9.common.ExplorerAutoOptimizerSetting</code>
 */
class ExplorerAutoOptimizerSetting extends \Google\Protobuf\Internal\Message
{
    /**
     * Indicates whether the optimizer is turned on.
     *
     * Generated from protobuf field <code>optional bool opt_in = 2;</code>
     */
    protected $opt_in = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type bool $opt_in
     *           Indicates whether the optimizer is turned on.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Ads\Googleads\V9\Common\ExplorerAutoOptimizerSetting::initOnce();
        parent::__construct($data);
    }

    /**
     * Indicates whether the optimizer is turned on.
     *
     * Generated from protobuf field <code>optional bool opt_in = 2;</code>
     * @return bool
     */
    public function getOptIn()
    {
        return isset($this->opt_in) ? $this->opt_in : false;
    }

    public function hasOptIn()
    {
        return isset($this->opt_in);
    }

    public function clearOptIn()
    {
        unset($this->opt_in);
    }

    /**
     * Indicates whether the optimizer is turned on.
     *
     * Generated from protobuf field <code>optional bool opt_in = 2;</code>
     * @param bool $var
     * @return $this
     */
    public function setOptIn($var)
    {
        GPBUtil::checkBool($var);
        $this->opt_in = $var;

        return $this;
    }

}

