<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3beta1/flow.proto

namespace Google\Cloud\Dialogflow\Cx\V3beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The request message for [Flows.CreateFlow][google.cloud.dialogflow.cx.v3beta1.Flows.CreateFlow].
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3beta1.CreateFlowRequest</code>
 */
class CreateFlowRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The agent to create a flow for.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * Required. The flow to create.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.Flow flow = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $flow = null;
    /**
     * The language of the following fields in `flow`:
     * *  `Flow.event_handlers.trigger_fulfillment.messages`
     * *  `Flow.transition_routes.trigger_fulfillment.messages`
     * If not specified, the agent's default language is used.
     * [Many
     * languages](https://cloud.google.com/dialogflow/docs/reference/language)
     * are supported.
     * Note: languages must be enabled in the agent before they can be used.
     *
     * Generated from protobuf field <code>string language_code = 3;</code>
     */
    protected $language_code = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. The agent to create a flow for.
     *           Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
     *     @type \Google\Cloud\Dialogflow\Cx\V3beta1\Flow $flow
     *           Required. The flow to create.
     *     @type string $language_code
     *           The language of the following fields in `flow`:
     *           *  `Flow.event_handlers.trigger_fulfillment.messages`
     *           *  `Flow.transition_routes.trigger_fulfillment.messages`
     *           If not specified, the agent's default language is used.
     *           [Many
     *           languages](https://cloud.google.com/dialogflow/docs/reference/language)
     *           are supported.
     *           Note: languages must be enabled in the agent before they can be used.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3Beta1\Flow::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The agent to create a flow for.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. The agent to create a flow for.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setParent($var)
    {
        GPBUtil::checkString($var, True);
        $this->parent = $var;

        return $this;
    }

    /**
     * Required. The flow to create.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.Flow flow = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3beta1\Flow
     */
    public function getFlow()
    {
        return isset($this->flow) ? $this->flow : null;
    }

    public function hasFlow()
    {
        return isset($this->flow);
    }

    public function clearFlow()
    {
        unset($this->flow);
    }

    /**
     * Required. The flow to create.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.Flow flow = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\Flow $var
     * @return $this
     */
    public function setFlow($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3beta1\Flow::class);
        $this->flow = $var;

        return $this;
    }

    /**
     * The language of the following fields in `flow`:
     * *  `Flow.event_handlers.trigger_fulfillment.messages`
     * *  `Flow.transition_routes.trigger_fulfillment.messages`
     * If not specified, the agent's default language is used.
     * [Many
     * languages](https://cloud.google.com/dialogflow/docs/reference/language)
     * are supported.
     * Note: languages must be enabled in the agent before they can be used.
     *
     * Generated from protobuf field <code>string language_code = 3;</code>
     * @return string
     */
    public function getLanguageCode()
    {
        return $this->language_code;
    }

    /**
     * The language of the following fields in `flow`:
     * *  `Flow.event_handlers.trigger_fulfillment.messages`
     * *  `Flow.transition_routes.trigger_fulfillment.messages`
     * If not specified, the agent's default language is used.
     * [Many
     * languages](https://cloud.google.com/dialogflow/docs/reference/language)
     * are supported.
     * Note: languages must be enabled in the agent before they can be used.
     *
     * Generated from protobuf field <code>string language_code = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setLanguageCode($var)
    {
        GPBUtil::checkString($var, True);
        $this->language_code = $var;

        return $this;
    }

}

