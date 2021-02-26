<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/session.proto

namespace Google\Cloud\Dialogflow\Cx\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The top-level message returned from the `StreamingDetectIntent` method.
 * Multiple response messages can be returned in order:
 * 1.  If the input was set to streaming audio, the first one or more messages
 *     contain `recognition_result`. Each `recognition_result` represents a more
 *     complete transcript of what the user said. The last `recognition_result`
 *     has `is_final` set to `true`.
 * 2.  The last message contains `detect_intent_response`.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3.StreamingDetectIntentResponse</code>
 */
class StreamingDetectIntentResponse extends \Google\Protobuf\Internal\Message
{
    protected $response;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Dialogflow\Cx\V3\StreamingRecognitionResult $recognition_result
     *           The result of speech recognition.
     *     @type \Google\Cloud\Dialogflow\Cx\V3\DetectIntentResponse $detect_intent_response
     *           The response from detect intent.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\Session::initOnce();
        parent::__construct($data);
    }

    /**
     * The result of speech recognition.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.StreamingRecognitionResult recognition_result = 1;</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3\StreamingRecognitionResult|null
     */
    public function getRecognitionResult()
    {
        return $this->readOneof(1);
    }

    public function hasRecognitionResult()
    {
        return $this->hasOneof(1);
    }

    /**
     * The result of speech recognition.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.StreamingRecognitionResult recognition_result = 1;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3\StreamingRecognitionResult $var
     * @return $this
     */
    public function setRecognitionResult($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3\StreamingRecognitionResult::class);
        $this->writeOneof(1, $var);

        return $this;
    }

    /**
     * The response from detect intent.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.DetectIntentResponse detect_intent_response = 2;</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3\DetectIntentResponse|null
     */
    public function getDetectIntentResponse()
    {
        return $this->readOneof(2);
    }

    public function hasDetectIntentResponse()
    {
        return $this->hasOneof(2);
    }

    /**
     * The response from detect intent.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.DetectIntentResponse detect_intent_response = 2;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3\DetectIntentResponse $var
     * @return $this
     */
    public function setDetectIntentResponse($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3\DetectIntentResponse::class);
        $this->writeOneof(2, $var);

        return $this;
    }

    /**
     * @return string
     */
    public function getResponse()
    {
        return $this->whichOneof("response");
    }

}

