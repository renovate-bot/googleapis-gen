<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/validation_message.proto

namespace Google\Cloud\Dialogflow\Cx\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Agent/flow validation message.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3.ValidationMessage</code>
 */
class ValidationMessage extends \Google\Protobuf\Internal\Message
{
    /**
     * The type of the resources where the message is found.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.ValidationMessage.ResourceType resource_type = 1;</code>
     */
    protected $resource_type = 0;
    /**
     * The names of the resources where the message is found.
     *
     * Generated from protobuf field <code>repeated string resources = 2 [deprecated = true];</code>
     */
    private $resources;
    /**
     * The resource names of the resources where the message is found.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3.ResourceName resource_names = 6;</code>
     */
    private $resource_names;
    /**
     * Indicates the severity of the message.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.ValidationMessage.Severity severity = 3;</code>
     */
    protected $severity = 0;
    /**
     * The message detail.
     *
     * Generated from protobuf field <code>string detail = 4;</code>
     */
    protected $detail = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type int $resource_type
     *           The type of the resources where the message is found.
     *     @type string[]|\Google\Protobuf\Internal\RepeatedField $resources
     *           The names of the resources where the message is found.
     *     @type \Google\Cloud\Dialogflow\Cx\V3\ResourceName[]|\Google\Protobuf\Internal\RepeatedField $resource_names
     *           The resource names of the resources where the message is found.
     *     @type int $severity
     *           Indicates the severity of the message.
     *     @type string $detail
     *           The message detail.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\ValidationMessage::initOnce();
        parent::__construct($data);
    }

    /**
     * The type of the resources where the message is found.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.ValidationMessage.ResourceType resource_type = 1;</code>
     * @return int
     */
    public function getResourceType()
    {
        return $this->resource_type;
    }

    /**
     * The type of the resources where the message is found.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.ValidationMessage.ResourceType resource_type = 1;</code>
     * @param int $var
     * @return $this
     */
    public function setResourceType($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\Dialogflow\Cx\V3\ValidationMessage\ResourceType::class);
        $this->resource_type = $var;

        return $this;
    }

    /**
     * The names of the resources where the message is found.
     *
     * Generated from protobuf field <code>repeated string resources = 2 [deprecated = true];</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getResources()
    {
        return $this->resources;
    }

    /**
     * The names of the resources where the message is found.
     *
     * Generated from protobuf field <code>repeated string resources = 2 [deprecated = true];</code>
     * @param string[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setResources($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::STRING);
        $this->resources = $arr;

        return $this;
    }

    /**
     * The resource names of the resources where the message is found.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3.ResourceName resource_names = 6;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getResourceNames()
    {
        return $this->resource_names;
    }

    /**
     * The resource names of the resources where the message is found.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3.ResourceName resource_names = 6;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3\ResourceName[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setResourceNames($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Dialogflow\Cx\V3\ResourceName::class);
        $this->resource_names = $arr;

        return $this;
    }

    /**
     * Indicates the severity of the message.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.ValidationMessage.Severity severity = 3;</code>
     * @return int
     */
    public function getSeverity()
    {
        return $this->severity;
    }

    /**
     * Indicates the severity of the message.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.ValidationMessage.Severity severity = 3;</code>
     * @param int $var
     * @return $this
     */
    public function setSeverity($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\Dialogflow\Cx\V3\ValidationMessage\Severity::class);
        $this->severity = $var;

        return $this;
    }

    /**
     * The message detail.
     *
     * Generated from protobuf field <code>string detail = 4;</code>
     * @return string
     */
    public function getDetail()
    {
        return $this->detail;
    }

    /**
     * The message detail.
     *
     * Generated from protobuf field <code>string detail = 4;</code>
     * @param string $var
     * @return $this
     */
    public function setDetail($var)
    {
        GPBUtil::checkString($var, True);
        $this->detail = $var;

        return $this;
    }

}

