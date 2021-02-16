<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3beta1/fulfillment.proto

namespace Google\Cloud\Dialogflow\Cx\V3beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A fulfillment can do one or more of the following actions at the same time:
 *   * Generate rich message responses.
 *   * Set parameter values.
 *   * Call the webhook.
 * Fulfillments can be called at various stages in the [Page][google.cloud.dialogflow.cx.v3beta1.Page] or
 * [Form][google.cloud.dialogflow.cx.v3beta1.Form] lifecycle. For example, when a [DetectIntentRequest][google.cloud.dialogflow.cx.v3beta1.DetectIntentRequest] drives a
 * session to enter a new page, the page's entry fulfillment can add a static
 * response to the [QueryResult][google.cloud.dialogflow.cx.v3beta1.QueryResult] in the returning [DetectIntentResponse][google.cloud.dialogflow.cx.v3beta1.DetectIntentResponse],
 * call the webhook (for example, to load user data from a database), or both.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3beta1.Fulfillment</code>
 */
class Fulfillment extends \Google\Protobuf\Internal\Message
{
    /**
     * The list of rich message responses to present to the user.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3beta1.ResponseMessage messages = 1;</code>
     */
    private $messages;
    /**
     * The webhook to call.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/webhooks/<Webhook ID>`.
     *
     * Generated from protobuf field <code>string webhook = 2 [(.google.api.resource_reference) = {</code>
     */
    protected $webhook = '';
    /**
     * The tag used by the webhook to identify which fulfillment is being called.
     * This field is required if `webhook` is specified.
     *
     * Generated from protobuf field <code>string tag = 3;</code>
     */
    protected $tag = '';
    /**
     * Set parameter values before executing the webhook.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3beta1.Fulfillment.SetParameterAction set_parameter_actions = 4;</code>
     */
    private $set_parameter_actions;
    /**
     * Conditional cases for this fulfillment.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3beta1.Fulfillment.ConditionalCases conditional_cases = 5;</code>
     */
    private $conditional_cases;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Dialogflow\Cx\V3beta1\ResponseMessage[]|\Google\Protobuf\Internal\RepeatedField $messages
     *           The list of rich message responses to present to the user.
     *     @type string $webhook
     *           The webhook to call.
     *           Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *           ID>/webhooks/<Webhook ID>`.
     *     @type string $tag
     *           The tag used by the webhook to identify which fulfillment is being called.
     *           This field is required if `webhook` is specified.
     *     @type \Google\Cloud\Dialogflow\Cx\V3beta1\Fulfillment\SetParameterAction[]|\Google\Protobuf\Internal\RepeatedField $set_parameter_actions
     *           Set parameter values before executing the webhook.
     *     @type \Google\Cloud\Dialogflow\Cx\V3beta1\Fulfillment\ConditionalCases[]|\Google\Protobuf\Internal\RepeatedField $conditional_cases
     *           Conditional cases for this fulfillment.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3Beta1\Fulfillment::initOnce();
        parent::__construct($data);
    }

    /**
     * The list of rich message responses to present to the user.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3beta1.ResponseMessage messages = 1;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getMessages()
    {
        return $this->messages;
    }

    /**
     * The list of rich message responses to present to the user.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3beta1.ResponseMessage messages = 1;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\ResponseMessage[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setMessages($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Dialogflow\Cx\V3beta1\ResponseMessage::class);
        $this->messages = $arr;

        return $this;
    }

    /**
     * The webhook to call.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/webhooks/<Webhook ID>`.
     *
     * Generated from protobuf field <code>string webhook = 2 [(.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getWebhook()
    {
        return $this->webhook;
    }

    /**
     * The webhook to call.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/webhooks/<Webhook ID>`.
     *
     * Generated from protobuf field <code>string webhook = 2 [(.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setWebhook($var)
    {
        GPBUtil::checkString($var, True);
        $this->webhook = $var;

        return $this;
    }

    /**
     * The tag used by the webhook to identify which fulfillment is being called.
     * This field is required if `webhook` is specified.
     *
     * Generated from protobuf field <code>string tag = 3;</code>
     * @return string
     */
    public function getTag()
    {
        return $this->tag;
    }

    /**
     * The tag used by the webhook to identify which fulfillment is being called.
     * This field is required if `webhook` is specified.
     *
     * Generated from protobuf field <code>string tag = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setTag($var)
    {
        GPBUtil::checkString($var, True);
        $this->tag = $var;

        return $this;
    }

    /**
     * Set parameter values before executing the webhook.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3beta1.Fulfillment.SetParameterAction set_parameter_actions = 4;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getSetParameterActions()
    {
        return $this->set_parameter_actions;
    }

    /**
     * Set parameter values before executing the webhook.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3beta1.Fulfillment.SetParameterAction set_parameter_actions = 4;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\Fulfillment\SetParameterAction[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setSetParameterActions($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Dialogflow\Cx\V3beta1\Fulfillment\SetParameterAction::class);
        $this->set_parameter_actions = $arr;

        return $this;
    }

    /**
     * Conditional cases for this fulfillment.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3beta1.Fulfillment.ConditionalCases conditional_cases = 5;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getConditionalCases()
    {
        return $this->conditional_cases;
    }

    /**
     * Conditional cases for this fulfillment.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3beta1.Fulfillment.ConditionalCases conditional_cases = 5;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\Fulfillment\ConditionalCases[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setConditionalCases($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Dialogflow\Cx\V3beta1\Fulfillment\ConditionalCases::class);
        $this->conditional_cases = $arr;

        return $this;
    }

}
