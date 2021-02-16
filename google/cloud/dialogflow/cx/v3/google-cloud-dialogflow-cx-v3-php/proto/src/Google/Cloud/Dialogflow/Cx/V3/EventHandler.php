<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/page.proto

namespace Google\Cloud\Dialogflow\Cx\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * An event handler specifies an [event][google.cloud.dialogflow.cx.v3.EventHandler.event] that can be handled
 * during a session. When the specified event happens, the following actions are
 * taken in order:
 * *   If there is a
 * [`trigger_fulfillment`][google.cloud.dialogflow.cx.v3.EventHandler.trigger_fulfillment] associated with
 * the event, it will be called.
 * *   If there is a [`target_page`][google.cloud.dialogflow.cx.v3.EventHandler.target_page] associated
 * with the event, the session will transition into the specified page.
 * *   If there is a [`target_flow`][google.cloud.dialogflow.cx.v3.EventHandler.target_flow] associated
 * with the event, the session will transition into the specified flow.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3.EventHandler</code>
 */
class EventHandler extends \Google\Protobuf\Internal\Message
{
    /**
     * Output only. The unique identifier of this event handler.
     *
     * Generated from protobuf field <code>string name = 6 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $name = '';
    /**
     * Required. The name of the event to handle.
     *
     * Generated from protobuf field <code>string event = 4 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $event = '';
    /**
     * The fulfillment to call when the event occurs.
     * Handling webhook errors with a fulfillment enabled with webhook could
     * cause infinite loop. It is invalid to specify such fulfillment for a
     * handler handling webhooks.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.Fulfillment trigger_fulfillment = 5;</code>
     */
    protected $trigger_fulfillment = null;
    protected $target;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Output only. The unique identifier of this event handler.
     *     @type string $event
     *           Required. The name of the event to handle.
     *     @type \Google\Cloud\Dialogflow\Cx\V3\Fulfillment $trigger_fulfillment
     *           The fulfillment to call when the event occurs.
     *           Handling webhook errors with a fulfillment enabled with webhook could
     *           cause infinite loop. It is invalid to specify such fulfillment for a
     *           handler handling webhooks.
     *     @type string $target_page
     *           The target page to transition to.
     *           Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *           ID>/flows/<Flow ID>/pages/<Page ID>`.
     *     @type string $target_flow
     *           The target flow to transition to.
     *           Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *           ID>/flows/<Flow ID>`.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\Page::initOnce();
        parent::__construct($data);
    }

    /**
     * Output only. The unique identifier of this event handler.
     *
     * Generated from protobuf field <code>string name = 6 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Output only. The unique identifier of this event handler.
     *
     * Generated from protobuf field <code>string name = 6 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param string $var
     * @return $this
     */
    public function setName($var)
    {
        GPBUtil::checkString($var, True);
        $this->name = $var;

        return $this;
    }

    /**
     * Required. The name of the event to handle.
     *
     * Generated from protobuf field <code>string event = 4 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getEvent()
    {
        return $this->event;
    }

    /**
     * Required. The name of the event to handle.
     *
     * Generated from protobuf field <code>string event = 4 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setEvent($var)
    {
        GPBUtil::checkString($var, True);
        $this->event = $var;

        return $this;
    }

    /**
     * The fulfillment to call when the event occurs.
     * Handling webhook errors with a fulfillment enabled with webhook could
     * cause infinite loop. It is invalid to specify such fulfillment for a
     * handler handling webhooks.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.Fulfillment trigger_fulfillment = 5;</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3\Fulfillment
     */
    public function getTriggerFulfillment()
    {
        return isset($this->trigger_fulfillment) ? $this->trigger_fulfillment : null;
    }

    public function hasTriggerFulfillment()
    {
        return isset($this->trigger_fulfillment);
    }

    public function clearTriggerFulfillment()
    {
        unset($this->trigger_fulfillment);
    }

    /**
     * The fulfillment to call when the event occurs.
     * Handling webhook errors with a fulfillment enabled with webhook could
     * cause infinite loop. It is invalid to specify such fulfillment for a
     * handler handling webhooks.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.Fulfillment trigger_fulfillment = 5;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3\Fulfillment $var
     * @return $this
     */
    public function setTriggerFulfillment($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3\Fulfillment::class);
        $this->trigger_fulfillment = $var;

        return $this;
    }

    /**
     * The target page to transition to.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/flows/<Flow ID>/pages/<Page ID>`.
     *
     * Generated from protobuf field <code>string target_page = 2 [(.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getTargetPage()
    {
        return $this->readOneof(2);
    }

    public function hasTargetPage()
    {
        return $this->hasOneof(2);
    }

    /**
     * The target page to transition to.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/flows/<Flow ID>/pages/<Page ID>`.
     *
     * Generated from protobuf field <code>string target_page = 2 [(.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setTargetPage($var)
    {
        GPBUtil::checkString($var, True);
        $this->writeOneof(2, $var);

        return $this;
    }

    /**
     * The target flow to transition to.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/flows/<Flow ID>`.
     *
     * Generated from protobuf field <code>string target_flow = 3 [(.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getTargetFlow()
    {
        return $this->readOneof(3);
    }

    public function hasTargetFlow()
    {
        return $this->hasOneof(3);
    }

    /**
     * The target flow to transition to.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/flows/<Flow ID>`.
     *
     * Generated from protobuf field <code>string target_flow = 3 [(.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setTargetFlow($var)
    {
        GPBUtil::checkString($var, True);
        $this->writeOneof(3, $var);

        return $this;
    }

    /**
     * @return string
     */
    public function getTarget()
    {
        return $this->whichOneof("target");
    }

}
