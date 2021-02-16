<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/agent.proto

namespace Google\Cloud\Dialogflow\Cx\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The request message for [Agents.ExportAgent][google.cloud.dialogflow.cx.v3.Agents.ExportAgent].
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3.ExportAgentRequest</code>
 */
class ExportAgentRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The name of the agent to export.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $name = '';
    /**
     * Optional. The [Google Cloud Storage](https://cloud.google.com/storage/docs/) URI to
     * export the agent to. The format of this URI must be
     * `gs://<bucket-name>/<object-name>`.
     * If left unspecified, the serialized agent is returned inline.
     *
     * Generated from protobuf field <code>string agent_uri = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $agent_uri = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Required. The name of the agent to export.
     *           Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
     *     @type string $agent_uri
     *           Optional. The [Google Cloud Storage](https://cloud.google.com/storage/docs/) URI to
     *           export the agent to. The format of this URI must be
     *           `gs://<bucket-name>/<object-name>`.
     *           If left unspecified, the serialized agent is returned inline.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\Agent::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The name of the agent to export.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Required. The name of the agent to export.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
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
     * Optional. The [Google Cloud Storage](https://cloud.google.com/storage/docs/) URI to
     * export the agent to. The format of this URI must be
     * `gs://<bucket-name>/<object-name>`.
     * If left unspecified, the serialized agent is returned inline.
     *
     * Generated from protobuf field <code>string agent_uri = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return string
     */
    public function getAgentUri()
    {
        return $this->agent_uri;
    }

    /**
     * Optional. The [Google Cloud Storage](https://cloud.google.com/storage/docs/) URI to
     * export the agent to. The format of this URI must be
     * `gs://<bucket-name>/<object-name>`.
     * If left unspecified, the serialized agent is returned inline.
     *
     * Generated from protobuf field <code>string agent_uri = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param string $var
     * @return $this
     */
    public function setAgentUri($var)
    {
        GPBUtil::checkString($var, True);
        $this->agent_uri = $var;

        return $this;
    }

}

