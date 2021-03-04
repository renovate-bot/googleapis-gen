<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/v2/participant.proto

namespace Google\Cloud\Dialogflow\V2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Represents a response from an automated agent.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.v2.AutomatedAgentReply</code>
 */
class AutomatedAgentReply extends \Google\Protobuf\Internal\Message
{
    /**
     * Response of the Dialogflow [Sessions.DetectIntent][google.cloud.dialogflow.v2.Sessions.DetectIntent] call.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.DetectIntentResponse detect_intent_response = 1;</code>
     */
    protected $detect_intent_response = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Dialogflow\V2\DetectIntentResponse $detect_intent_response
     *           Response of the Dialogflow [Sessions.DetectIntent][google.cloud.dialogflow.v2.Sessions.DetectIntent] call.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\V2\Participant::initOnce();
        parent::__construct($data);
    }

    /**
     * Response of the Dialogflow [Sessions.DetectIntent][google.cloud.dialogflow.v2.Sessions.DetectIntent] call.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.DetectIntentResponse detect_intent_response = 1;</code>
     * @return \Google\Cloud\Dialogflow\V2\DetectIntentResponse|null
     */
    public function getDetectIntentResponse()
    {
        return isset($this->detect_intent_response) ? $this->detect_intent_response : null;
    }

    public function hasDetectIntentResponse()
    {
        return isset($this->detect_intent_response);
    }

    public function clearDetectIntentResponse()
    {
        unset($this->detect_intent_response);
    }

    /**
     * Response of the Dialogflow [Sessions.DetectIntent][google.cloud.dialogflow.v2.Sessions.DetectIntent] call.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.DetectIntentResponse detect_intent_response = 1;</code>
     * @param \Google\Cloud\Dialogflow\V2\DetectIntentResponse $var
     * @return $this
     */
    public function setDetectIntentResponse($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\V2\DetectIntentResponse::class);
        $this->detect_intent_response = $var;

        return $this;
    }

}

