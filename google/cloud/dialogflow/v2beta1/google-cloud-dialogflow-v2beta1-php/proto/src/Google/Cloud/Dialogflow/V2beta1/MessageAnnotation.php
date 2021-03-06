<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/v2beta1/participant.proto

namespace Google\Cloud\Dialogflow\V2beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Represents the result of annotation for the message.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.v2beta1.MessageAnnotation</code>
 */
class MessageAnnotation extends \Google\Protobuf\Internal\Message
{
    /**
     * Optional. The collection of annotated message parts ordered by their
     * position in the message. You can recover the annotated message by
     * concatenating [AnnotatedMessagePart.text].
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.v2beta1.AnnotatedMessagePart parts = 1;</code>
     */
    private $parts;
    /**
     * Required. Indicates whether the text message contains entities.
     *
     * Generated from protobuf field <code>bool contain_entities = 2;</code>
     */
    protected $contain_entities = false;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Dialogflow\V2beta1\AnnotatedMessagePart[]|\Google\Protobuf\Internal\RepeatedField $parts
     *           Optional. The collection of annotated message parts ordered by their
     *           position in the message. You can recover the annotated message by
     *           concatenating [AnnotatedMessagePart.text].
     *     @type bool $contain_entities
     *           Required. Indicates whether the text message contains entities.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\V2Beta1\Participant::initOnce();
        parent::__construct($data);
    }

    /**
     * Optional. The collection of annotated message parts ordered by their
     * position in the message. You can recover the annotated message by
     * concatenating [AnnotatedMessagePart.text].
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.v2beta1.AnnotatedMessagePart parts = 1;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getParts()
    {
        return $this->parts;
    }

    /**
     * Optional. The collection of annotated message parts ordered by their
     * position in the message. You can recover the annotated message by
     * concatenating [AnnotatedMessagePart.text].
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.v2beta1.AnnotatedMessagePart parts = 1;</code>
     * @param \Google\Cloud\Dialogflow\V2beta1\AnnotatedMessagePart[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setParts($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Dialogflow\V2beta1\AnnotatedMessagePart::class);
        $this->parts = $arr;

        return $this;
    }

    /**
     * Required. Indicates whether the text message contains entities.
     *
     * Generated from protobuf field <code>bool contain_entities = 2;</code>
     * @return bool
     */
    public function getContainEntities()
    {
        return $this->contain_entities;
    }

    /**
     * Required. Indicates whether the text message contains entities.
     *
     * Generated from protobuf field <code>bool contain_entities = 2;</code>
     * @param bool $var
     * @return $this
     */
    public function setContainEntities($var)
    {
        GPBUtil::checkBool($var);
        $this->contain_entities = $var;

        return $this;
    }

}

