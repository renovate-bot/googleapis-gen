<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/agent.proto

namespace Google\Cloud\Dialogflow\Cx\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Settings related to speech recognition.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3.SpeechToTextSettings</code>
 */
class SpeechToTextSettings extends \Google\Protobuf\Internal\Message
{
    /**
     * Whether to use speech adaptation for speech recognition.
     *
     * Generated from protobuf field <code>bool enable_speech_adaptation = 1;</code>
     */
    protected $enable_speech_adaptation = false;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type bool $enable_speech_adaptation
     *           Whether to use speech adaptation for speech recognition.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\Agent::initOnce();
        parent::__construct($data);
    }

    /**
     * Whether to use speech adaptation for speech recognition.
     *
     * Generated from protobuf field <code>bool enable_speech_adaptation = 1;</code>
     * @return bool
     */
    public function getEnableSpeechAdaptation()
    {
        return $this->enable_speech_adaptation;
    }

    /**
     * Whether to use speech adaptation for speech recognition.
     *
     * Generated from protobuf field <code>bool enable_speech_adaptation = 1;</code>
     * @param bool $var
     * @return $this
     */
    public function setEnableSpeechAdaptation($var)
    {
        GPBUtil::checkBool($var);
        $this->enable_speech_adaptation = $var;

        return $this;
    }

}

