<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3beta1/environment.proto

namespace Google\Cloud\Dialogflow\Cx\V3beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The request message for [Environments.DeployFlow][google.cloud.dialogflow.cx.v3beta1.Environments.DeployFlow].
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3beta1.DeployFlowRequest</code>
 */
class DeployFlowRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The environment to deploy the flow to.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>/
     * environments/<Environment ID>`.
     *
     * Generated from protobuf field <code>string environment = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $environment = '';
    /**
     * Required. The flow version to deploy.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>/
     * flows/<Flow ID>/versions/<Version ID>`.
     *
     * Generated from protobuf field <code>string flow_version = 2 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $flow_version = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $environment
     *           Required. The environment to deploy the flow to.
     *           Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>/
     *           environments/<Environment ID>`.
     *     @type string $flow_version
     *           Required. The flow version to deploy.
     *           Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>/
     *           flows/<Flow ID>/versions/<Version ID>`.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3Beta1\Environment::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The environment to deploy the flow to.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>/
     * environments/<Environment ID>`.
     *
     * Generated from protobuf field <code>string environment = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getEnvironment()
    {
        return $this->environment;
    }

    /**
     * Required. The environment to deploy the flow to.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>/
     * environments/<Environment ID>`.
     *
     * Generated from protobuf field <code>string environment = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setEnvironment($var)
    {
        GPBUtil::checkString($var, True);
        $this->environment = $var;

        return $this;
    }

    /**
     * Required. The flow version to deploy.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>/
     * flows/<Flow ID>/versions/<Version ID>`.
     *
     * Generated from protobuf field <code>string flow_version = 2 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getFlowVersion()
    {
        return $this->flow_version;
    }

    /**
     * Required. The flow version to deploy.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>/
     * flows/<Flow ID>/versions/<Version ID>`.
     *
     * Generated from protobuf field <code>string flow_version = 2 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setFlowVersion($var)
    {
        GPBUtil::checkString($var, True);
        $this->flow_version = $var;

        return $this;
    }

}

