<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v4/resources/conversion_action.proto

namespace Google\Ads\GoogleAds\V4\Resources\ConversionAction;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Settings related to a third party app analytics conversion action.
 *
 * Generated from protobuf message <code>google.ads.googleads.v4.resources.ConversionAction.ThirdPartyAppAnalyticsSettings</code>
 */
class ThirdPartyAppAnalyticsSettings extends \Google\Protobuf\Internal\Message
{
    /**
     * Output only. The event name of a third-party app analytics conversion.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue event_name = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $event_name = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Protobuf\StringValue $event_name
     *           Output only. The event name of a third-party app analytics conversion.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Ads\Googleads\V4\Resources\ConversionAction::initOnce();
        parent::__construct($data);
    }

    /**
     * Output only. The event name of a third-party app analytics conversion.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue event_name = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\StringValue|null
     */
    public function getEventName()
    {
        return isset($this->event_name) ? $this->event_name : null;
    }

    public function hasEventName()
    {
        return isset($this->event_name);
    }

    public function clearEventName()
    {
        unset($this->event_name);
    }

    /**
     * Returns the unboxed value from <code>getEventName()</code>

     * Output only. The event name of a third-party app analytics conversion.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue event_name = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return string|null
     */
    public function getEventNameUnwrapped()
    {
        return $this->readWrapperValue("event_name");
    }

    /**
     * Output only. The event name of a third-party app analytics conversion.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue event_name = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Protobuf\StringValue $var
     * @return $this
     */
    public function setEventName($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\StringValue::class);
        $this->event_name = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\StringValue object.

     * Output only. The event name of a third-party app analytics conversion.
     *
     * Generated from protobuf field <code>.google.protobuf.StringValue event_name = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param string|null $var
     * @return $this
     */
    public function setEventNameUnwrapped($var)
    {
        $this->writeWrapperValue("event_name", $var);
        return $this;}

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(ThirdPartyAppAnalyticsSettings::class, \Google\Ads\GoogleAds\V4\Resources\ConversionAction_ThirdPartyAppAnalyticsSettings::class);

