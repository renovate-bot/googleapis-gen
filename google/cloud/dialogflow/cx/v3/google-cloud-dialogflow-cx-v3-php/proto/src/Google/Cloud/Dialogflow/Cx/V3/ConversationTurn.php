<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/test_case.proto

namespace Google\Cloud\Dialogflow\Cx\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * One interaction between a human and virtual agent. The human provides some
 * input and the virtual agent provides a response.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3.ConversationTurn</code>
 */
class ConversationTurn extends \Google\Protobuf\Internal\Message
{
    /**
     * The user input.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.ConversationTurn.UserInput user_input = 1;</code>
     */
    protected $user_input = null;
    /**
     * The virtual agent output.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.ConversationTurn.VirtualAgentOutput virtual_agent_output = 2;</code>
     */
    protected $virtual_agent_output = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Dialogflow\Cx\V3\ConversationTurn\UserInput $user_input
     *           The user input.
     *     @type \Google\Cloud\Dialogflow\Cx\V3\ConversationTurn\VirtualAgentOutput $virtual_agent_output
     *           The virtual agent output.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\TestCase::initOnce();
        parent::__construct($data);
    }

    /**
     * The user input.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.ConversationTurn.UserInput user_input = 1;</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3\ConversationTurn\UserInput|null
     */
    public function getUserInput()
    {
        return isset($this->user_input) ? $this->user_input : null;
    }

    public function hasUserInput()
    {
        return isset($this->user_input);
    }

    public function clearUserInput()
    {
        unset($this->user_input);
    }

    /**
     * The user input.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.ConversationTurn.UserInput user_input = 1;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3\ConversationTurn\UserInput $var
     * @return $this
     */
    public function setUserInput($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3\ConversationTurn\UserInput::class);
        $this->user_input = $var;

        return $this;
    }

    /**
     * The virtual agent output.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.ConversationTurn.VirtualAgentOutput virtual_agent_output = 2;</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3\ConversationTurn\VirtualAgentOutput|null
     */
    public function getVirtualAgentOutput()
    {
        return isset($this->virtual_agent_output) ? $this->virtual_agent_output : null;
    }

    public function hasVirtualAgentOutput()
    {
        return isset($this->virtual_agent_output);
    }

    public function clearVirtualAgentOutput()
    {
        unset($this->virtual_agent_output);
    }

    /**
     * The virtual agent output.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.ConversationTurn.VirtualAgentOutput virtual_agent_output = 2;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3\ConversationTurn\VirtualAgentOutput $var
     * @return $this
     */
    public function setVirtualAgentOutput($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3\ConversationTurn\VirtualAgentOutput::class);
        $this->virtual_agent_output = $var;

        return $this;
    }

}

