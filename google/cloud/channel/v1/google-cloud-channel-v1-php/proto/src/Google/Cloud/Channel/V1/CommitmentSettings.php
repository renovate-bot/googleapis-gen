<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/channel/v1/entitlements.proto

namespace Google\Cloud\Channel\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Commitment settings for commitment-based offers.
 *
 * Generated from protobuf message <code>google.cloud.channel.v1.CommitmentSettings</code>
 */
class CommitmentSettings extends \Google\Protobuf\Internal\Message
{
    /**
     * Output only. Commitment start timestamp.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp start_time = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $start_time = null;
    /**
     * Output only. Commitment end timestamp.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp end_time = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $end_time = null;
    /**
     * Optional. Renewal settings applicable for a commitment-based Offer.
     *
     * Generated from protobuf field <code>.google.cloud.channel.v1.RenewalSettings renewal_settings = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $renewal_settings = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Protobuf\Timestamp $start_time
     *           Output only. Commitment start timestamp.
     *     @type \Google\Protobuf\Timestamp $end_time
     *           Output only. Commitment end timestamp.
     *     @type \Google\Cloud\Channel\V1\RenewalSettings $renewal_settings
     *           Optional. Renewal settings applicable for a commitment-based Offer.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Channel\V1\Entitlements::initOnce();
        parent::__construct($data);
    }

    /**
     * Output only. Commitment start timestamp.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp start_time = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getStartTime()
    {
        return isset($this->start_time) ? $this->start_time : null;
    }

    public function hasStartTime()
    {
        return isset($this->start_time);
    }

    public function clearStartTime()
    {
        unset($this->start_time);
    }

    /**
     * Output only. Commitment start timestamp.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp start_time = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setStartTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->start_time = $var;

        return $this;
    }

    /**
     * Output only. Commitment end timestamp.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp end_time = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getEndTime()
    {
        return isset($this->end_time) ? $this->end_time : null;
    }

    public function hasEndTime()
    {
        return isset($this->end_time);
    }

    public function clearEndTime()
    {
        unset($this->end_time);
    }

    /**
     * Output only. Commitment end timestamp.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp end_time = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setEndTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->end_time = $var;

        return $this;
    }

    /**
     * Optional. Renewal settings applicable for a commitment-based Offer.
     *
     * Generated from protobuf field <code>.google.cloud.channel.v1.RenewalSettings renewal_settings = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return \Google\Cloud\Channel\V1\RenewalSettings|null
     */
    public function getRenewalSettings()
    {
        return isset($this->renewal_settings) ? $this->renewal_settings : null;
    }

    public function hasRenewalSettings()
    {
        return isset($this->renewal_settings);
    }

    public function clearRenewalSettings()
    {
        unset($this->renewal_settings);
    }

    /**
     * Optional. Renewal settings applicable for a commitment-based Offer.
     *
     * Generated from protobuf field <code>.google.cloud.channel.v1.RenewalSettings renewal_settings = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param \Google\Cloud\Channel\V1\RenewalSettings $var
     * @return $this
     */
    public function setRenewalSettings($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Channel\V1\RenewalSettings::class);
        $this->renewal_settings = $var;

        return $this;
    }

}

