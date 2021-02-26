<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/agent.proto

namespace Google\Cloud\Dialogflow\Cx\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The request message for [Agents.CreateAgent][google.cloud.dialogflow.cx.v3.Agents.CreateAgent].
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3.CreateAgentRequest</code>
 */
class CreateAgentRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The location to create a agent for.
     * Format: `projects/<Project ID>/locations/<Location ID>`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * Required. The agent to create.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.Agent agent = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $agent = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. The location to create a agent for.
     *           Format: `projects/<Project ID>/locations/<Location ID>`.
     *     @type \Google\Cloud\Dialogflow\Cx\V3\Agent $agent
     *           Required. The agent to create.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\Agent::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The location to create a agent for.
     * Format: `projects/<Project ID>/locations/<Location ID>`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. The location to create a agent for.
     * Format: `projects/<Project ID>/locations/<Location ID>`.
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
     * Required. The agent to create.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.Agent agent = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3\Agent|null
     */
    public function getAgent()
    {
        return isset($this->agent) ? $this->agent : null;
    }

    public function hasAgent()
    {
        return isset($this->agent);
    }

    public function clearAgent()
    {
        unset($this->agent);
    }

    /**
     * Required. The agent to create.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.Agent agent = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3\Agent $var
     * @return $this
     */
    public function setAgent($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3\Agent::class);
        $this->agent = $var;

        return $this;
    }

}

