<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/v2beta1/conversation.proto

namespace Google\Cloud\Dialogflow\V2beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The request message to create one Message. Currently it is only used in
 * BatchCreateMessagesRequest.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.v2beta1.CreateMessageRequest</code>
 */
class CreateMessageRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. Resource identifier of the conversation to create message.
     * Format: `projects/<Project ID>/locations/<Location
     * ID>/conversations/<Conversation ID>`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * Required. The message to create.
     * [Message.participant][google.cloud.dialogflow.v2beta1.Message.participant] is required.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2beta1.Message message = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $message = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. Resource identifier of the conversation to create message.
     *           Format: `projects/<Project ID>/locations/<Location
     *           ID>/conversations/<Conversation ID>`.
     *     @type \Google\Cloud\Dialogflow\V2beta1\Message $message
     *           Required. The message to create.
     *           [Message.participant][google.cloud.dialogflow.v2beta1.Message.participant] is required.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\V2Beta1\Conversation::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. Resource identifier of the conversation to create message.
     * Format: `projects/<Project ID>/locations/<Location
     * ID>/conversations/<Conversation ID>`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. Resource identifier of the conversation to create message.
     * Format: `projects/<Project ID>/locations/<Location
     * ID>/conversations/<Conversation ID>`.
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
     * Required. The message to create.
     * [Message.participant][google.cloud.dialogflow.v2beta1.Message.participant] is required.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2beta1.Message message = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Dialogflow\V2beta1\Message|null
     */
    public function getMessage()
    {
        return $this->message;
    }

    public function hasMessage()
    {
        return isset($this->message);
    }

    public function clearMessage()
    {
        unset($this->message);
    }

    /**
     * Required. The message to create.
     * [Message.participant][google.cloud.dialogflow.v2beta1.Message.participant] is required.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2beta1.Message message = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Dialogflow\V2beta1\Message $var
     * @return $this
     */
    public function setMessage($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\V2beta1\Message::class);
        $this->message = $var;

        return $this;
    }

}

