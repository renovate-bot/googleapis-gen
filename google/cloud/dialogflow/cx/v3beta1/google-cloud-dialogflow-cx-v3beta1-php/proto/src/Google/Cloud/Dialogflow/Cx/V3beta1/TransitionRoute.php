<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3beta1/page.proto

namespace Google\Cloud\Dialogflow\Cx\V3beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A transition route specifies a [intent][google.cloud.dialogflow.cx.v3beta1.Intent] that can be matched and/or a
 * data condition that can be evaluated during a session. When a specified
 * transition is matched, the following actions are taken in order:
 * *   If there is a
 * [`trigger_fulfillment`][google.cloud.dialogflow.cx.v3beta1.TransitionRoute.trigger_fulfillment] associated with
 * the transition, it will be called.
 * *   If there is a [`target_page`][google.cloud.dialogflow.cx.v3beta1.TransitionRoute.target_page] associated
 * with the transition, the session will transition into the specified page.
 * *   If there is a [`target_flow`][google.cloud.dialogflow.cx.v3beta1.TransitionRoute.target_flow] associated
 * with the transition, the session will transition into the specified flow.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3beta1.TransitionRoute</code>
 */
class TransitionRoute extends \Google\Protobuf\Internal\Message
{
    /**
     * Output only. The unique identifier of this transition route.
     *
     * Generated from protobuf field <code>string name = 6 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $name = '';
    /**
     * The unique identifier of an [Intent][google.cloud.dialogflow.cx.v3beta1.Intent].
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/intents/<Intent ID>`.
     * Indicates that the transition can only happen when the given intent is
     * matched.
     * At least one of `intent` or `condition` must be specified. When both
     * `intent` and `condition` are specified, the transition can only happen
     * when both are fulfilled.
     *
     * Generated from protobuf field <code>string intent = 1 [(.google.api.resource_reference) = {</code>
     */
    protected $intent = '';
    /**
     * The condition to evaluate against [form parameters][google.cloud.dialogflow.cx.v3beta1.Form.parameters] or
     * [session parameters][google.cloud.dialogflow.cx.v3beta1.SessionInfo.parameters].
     * See the [conditions
     * reference](https://cloud.google.com/dialogflow/cx/docs/reference/condition).
     * At least one of `intent` or `condition` must be specified. When both
     * `intent` and `condition` are specified, the transition can only happen
     * when both are fulfilled.
     *
     * Generated from protobuf field <code>string condition = 2;</code>
     */
    protected $condition = '';
    /**
     * The fulfillment to call when the condition is satisfied. At least one of
     * `trigger_fulfillment` and `target` must be specified. When both are
     * defined, `trigger_fulfillment` is executed first.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.Fulfillment trigger_fulfillment = 3;</code>
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
     *           Output only. The unique identifier of this transition route.
     *     @type string $intent
     *           The unique identifier of an [Intent][google.cloud.dialogflow.cx.v3beta1.Intent].
     *           Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *           ID>/intents/<Intent ID>`.
     *           Indicates that the transition can only happen when the given intent is
     *           matched.
     *           At least one of `intent` or `condition` must be specified. When both
     *           `intent` and `condition` are specified, the transition can only happen
     *           when both are fulfilled.
     *     @type string $condition
     *           The condition to evaluate against [form parameters][google.cloud.dialogflow.cx.v3beta1.Form.parameters] or
     *           [session parameters][google.cloud.dialogflow.cx.v3beta1.SessionInfo.parameters].
     *           See the [conditions
     *           reference](https://cloud.google.com/dialogflow/cx/docs/reference/condition).
     *           At least one of `intent` or `condition` must be specified. When both
     *           `intent` and `condition` are specified, the transition can only happen
     *           when both are fulfilled.
     *     @type \Google\Cloud\Dialogflow\Cx\V3beta1\Fulfillment $trigger_fulfillment
     *           The fulfillment to call when the condition is satisfied. At least one of
     *           `trigger_fulfillment` and `target` must be specified. When both are
     *           defined, `trigger_fulfillment` is executed first.
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
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3Beta1\Page::initOnce();
        parent::__construct($data);
    }

    /**
     * Output only. The unique identifier of this transition route.
     *
     * Generated from protobuf field <code>string name = 6 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Output only. The unique identifier of this transition route.
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
     * The unique identifier of an [Intent][google.cloud.dialogflow.cx.v3beta1.Intent].
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/intents/<Intent ID>`.
     * Indicates that the transition can only happen when the given intent is
     * matched.
     * At least one of `intent` or `condition` must be specified. When both
     * `intent` and `condition` are specified, the transition can only happen
     * when both are fulfilled.
     *
     * Generated from protobuf field <code>string intent = 1 [(.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getIntent()
    {
        return $this->intent;
    }

    /**
     * The unique identifier of an [Intent][google.cloud.dialogflow.cx.v3beta1.Intent].
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/intents/<Intent ID>`.
     * Indicates that the transition can only happen when the given intent is
     * matched.
     * At least one of `intent` or `condition` must be specified. When both
     * `intent` and `condition` are specified, the transition can only happen
     * when both are fulfilled.
     *
     * Generated from protobuf field <code>string intent = 1 [(.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setIntent($var)
    {
        GPBUtil::checkString($var, True);
        $this->intent = $var;

        return $this;
    }

    /**
     * The condition to evaluate against [form parameters][google.cloud.dialogflow.cx.v3beta1.Form.parameters] or
     * [session parameters][google.cloud.dialogflow.cx.v3beta1.SessionInfo.parameters].
     * See the [conditions
     * reference](https://cloud.google.com/dialogflow/cx/docs/reference/condition).
     * At least one of `intent` or `condition` must be specified. When both
     * `intent` and `condition` are specified, the transition can only happen
     * when both are fulfilled.
     *
     * Generated from protobuf field <code>string condition = 2;</code>
     * @return string
     */
    public function getCondition()
    {
        return $this->condition;
    }

    /**
     * The condition to evaluate against [form parameters][google.cloud.dialogflow.cx.v3beta1.Form.parameters] or
     * [session parameters][google.cloud.dialogflow.cx.v3beta1.SessionInfo.parameters].
     * See the [conditions
     * reference](https://cloud.google.com/dialogflow/cx/docs/reference/condition).
     * At least one of `intent` or `condition` must be specified. When both
     * `intent` and `condition` are specified, the transition can only happen
     * when both are fulfilled.
     *
     * Generated from protobuf field <code>string condition = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setCondition($var)
    {
        GPBUtil::checkString($var, True);
        $this->condition = $var;

        return $this;
    }

    /**
     * The fulfillment to call when the condition is satisfied. At least one of
     * `trigger_fulfillment` and `target` must be specified. When both are
     * defined, `trigger_fulfillment` is executed first.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.Fulfillment trigger_fulfillment = 3;</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3beta1\Fulfillment
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
     * The fulfillment to call when the condition is satisfied. At least one of
     * `trigger_fulfillment` and `target` must be specified. When both are
     * defined, `trigger_fulfillment` is executed first.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.Fulfillment trigger_fulfillment = 3;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\Fulfillment $var
     * @return $this
     */
    public function setTriggerFulfillment($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3beta1\Fulfillment::class);
        $this->trigger_fulfillment = $var;

        return $this;
    }

    /**
     * The target page to transition to.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/flows/<Flow ID>/pages/<Page ID>`.
     *
     * Generated from protobuf field <code>string target_page = 4 [(.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getTargetPage()
    {
        return $this->readOneof(4);
    }

    public function hasTargetPage()
    {
        return $this->hasOneof(4);
    }

    /**
     * The target page to transition to.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/flows/<Flow ID>/pages/<Page ID>`.
     *
     * Generated from protobuf field <code>string target_page = 4 [(.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setTargetPage($var)
    {
        GPBUtil::checkString($var, True);
        $this->writeOneof(4, $var);

        return $this;
    }

    /**
     * The target flow to transition to.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/flows/<Flow ID>`.
     *
     * Generated from protobuf field <code>string target_flow = 5 [(.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getTargetFlow()
    {
        return $this->readOneof(5);
    }

    public function hasTargetFlow()
    {
        return $this->hasOneof(5);
    }

    /**
     * The target flow to transition to.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/flows/<Flow ID>`.
     *
     * Generated from protobuf field <code>string target_flow = 5 [(.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setTargetFlow($var)
    {
        GPBUtil::checkString($var, True);
        $this->writeOneof(5, $var);

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
