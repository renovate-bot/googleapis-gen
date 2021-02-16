<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3beta1/test_case.proto

namespace Google\Cloud\Dialogflow\Cx\V3beta1\ConversationTurn;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The input from the human user.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3beta1.ConversationTurn.UserInput</code>
 */
class UserInput extends \Google\Protobuf\Internal\Message
{
    /**
     * Supports [text input][google.cloud.dialogflow.cx.v3beta1.QueryInput.text], [event input][google.cloud.dialogflow.cx.v3beta1.QueryInput.event],
     * [dtmf input][google.cloud.dialogflow.cx.v3beta1.QueryInput.dtmf] in the test case.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.QueryInput input = 5;</code>
     */
    protected $input = null;
    /**
     * Parameters that need to be injected into the conversation during intent
     * detection.
     *
     * Generated from protobuf field <code>.google.protobuf.Struct injected_parameters = 2;</code>
     */
    protected $injected_parameters = null;
    /**
     * If webhooks should be allowed to trigger in response to the user
     * utterance. Often if parameters are injected, webhooks should not be
     * enabled.
     *
     * Generated from protobuf field <code>bool is_webhook_enabled = 3;</code>
     */
    protected $is_webhook_enabled = false;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Dialogflow\Cx\V3beta1\QueryInput $input
     *           Supports [text input][google.cloud.dialogflow.cx.v3beta1.QueryInput.text], [event input][google.cloud.dialogflow.cx.v3beta1.QueryInput.event],
     *           [dtmf input][google.cloud.dialogflow.cx.v3beta1.QueryInput.dtmf] in the test case.
     *     @type \Google\Protobuf\Struct $injected_parameters
     *           Parameters that need to be injected into the conversation during intent
     *           detection.
     *     @type bool $is_webhook_enabled
     *           If webhooks should be allowed to trigger in response to the user
     *           utterance. Often if parameters are injected, webhooks should not be
     *           enabled.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3Beta1\TestCase::initOnce();
        parent::__construct($data);
    }

    /**
     * Supports [text input][google.cloud.dialogflow.cx.v3beta1.QueryInput.text], [event input][google.cloud.dialogflow.cx.v3beta1.QueryInput.event],
     * [dtmf input][google.cloud.dialogflow.cx.v3beta1.QueryInput.dtmf] in the test case.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.QueryInput input = 5;</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3beta1\QueryInput
     */
    public function getInput()
    {
        return isset($this->input) ? $this->input : null;
    }

    public function hasInput()
    {
        return isset($this->input);
    }

    public function clearInput()
    {
        unset($this->input);
    }

    /**
     * Supports [text input][google.cloud.dialogflow.cx.v3beta1.QueryInput.text], [event input][google.cloud.dialogflow.cx.v3beta1.QueryInput.event],
     * [dtmf input][google.cloud.dialogflow.cx.v3beta1.QueryInput.dtmf] in the test case.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.QueryInput input = 5;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\QueryInput $var
     * @return $this
     */
    public function setInput($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3beta1\QueryInput::class);
        $this->input = $var;

        return $this;
    }

    /**
     * Parameters that need to be injected into the conversation during intent
     * detection.
     *
     * Generated from protobuf field <code>.google.protobuf.Struct injected_parameters = 2;</code>
     * @return \Google\Protobuf\Struct
     */
    public function getInjectedParameters()
    {
        return isset($this->injected_parameters) ? $this->injected_parameters : null;
    }

    public function hasInjectedParameters()
    {
        return isset($this->injected_parameters);
    }

    public function clearInjectedParameters()
    {
        unset($this->injected_parameters);
    }

    /**
     * Parameters that need to be injected into the conversation during intent
     * detection.
     *
     * Generated from protobuf field <code>.google.protobuf.Struct injected_parameters = 2;</code>
     * @param \Google\Protobuf\Struct $var
     * @return $this
     */
    public function setInjectedParameters($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Struct::class);
        $this->injected_parameters = $var;

        return $this;
    }

    /**
     * If webhooks should be allowed to trigger in response to the user
     * utterance. Often if parameters are injected, webhooks should not be
     * enabled.
     *
     * Generated from protobuf field <code>bool is_webhook_enabled = 3;</code>
     * @return bool
     */
    public function getIsWebhookEnabled()
    {
        return $this->is_webhook_enabled;
    }

    /**
     * If webhooks should be allowed to trigger in response to the user
     * utterance. Often if parameters are injected, webhooks should not be
     * enabled.
     *
     * Generated from protobuf field <code>bool is_webhook_enabled = 3;</code>
     * @param bool $var
     * @return $this
     */
    public function setIsWebhookEnabled($var)
    {
        GPBUtil::checkBool($var);
        $this->is_webhook_enabled = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(UserInput::class, \Google\Cloud\Dialogflow\Cx\V3beta1\ConversationTurn_UserInput::class);

