<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/session.proto

namespace Google\Cloud\Dialogflow\Cx\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Represents the natural speech audio to be processed.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3.AudioInput</code>
 */
class AudioInput extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. Instructs the speech recognizer how to process the speech audio.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.InputAudioConfig config = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $config = null;
    /**
     * The natural language speech audio to be processed.
     * A single request can contain up to 1 minute of speech audio data.
     * The [transcribed text][google.cloud.dialogflow.cx.v3.QueryResult.transcript] cannot contain more than 256
     * bytes.
     * For non-streaming audio detect intent, both `config` and `audio` must be
     * provided.
     * For streaming audio detect intent, `config` must be provided in
     * the first request and `audio` must be provided in all following requests.
     *
     * Generated from protobuf field <code>bytes audio = 2;</code>
     */
    protected $audio = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Dialogflow\Cx\V3\InputAudioConfig $config
     *           Required. Instructs the speech recognizer how to process the speech audio.
     *     @type string $audio
     *           The natural language speech audio to be processed.
     *           A single request can contain up to 1 minute of speech audio data.
     *           The [transcribed text][google.cloud.dialogflow.cx.v3.QueryResult.transcript] cannot contain more than 256
     *           bytes.
     *           For non-streaming audio detect intent, both `config` and `audio` must be
     *           provided.
     *           For streaming audio detect intent, `config` must be provided in
     *           the first request and `audio` must be provided in all following requests.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\Session::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. Instructs the speech recognizer how to process the speech audio.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.InputAudioConfig config = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3\InputAudioConfig
     */
    public function getConfig()
    {
        return isset($this->config) ? $this->config : null;
    }

    public function hasConfig()
    {
        return isset($this->config);
    }

    public function clearConfig()
    {
        unset($this->config);
    }

    /**
     * Required. Instructs the speech recognizer how to process the speech audio.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.InputAudioConfig config = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3\InputAudioConfig $var
     * @return $this
     */
    public function setConfig($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3\InputAudioConfig::class);
        $this->config = $var;

        return $this;
    }

    /**
     * The natural language speech audio to be processed.
     * A single request can contain up to 1 minute of speech audio data.
     * The [transcribed text][google.cloud.dialogflow.cx.v3.QueryResult.transcript] cannot contain more than 256
     * bytes.
     * For non-streaming audio detect intent, both `config` and `audio` must be
     * provided.
     * For streaming audio detect intent, `config` must be provided in
     * the first request and `audio` must be provided in all following requests.
     *
     * Generated from protobuf field <code>bytes audio = 2;</code>
     * @return string
     */
    public function getAudio()
    {
        return $this->audio;
    }

    /**
     * The natural language speech audio to be processed.
     * A single request can contain up to 1 minute of speech audio data.
     * The [transcribed text][google.cloud.dialogflow.cx.v3.QueryResult.transcript] cannot contain more than 256
     * bytes.
     * For non-streaming audio detect intent, both `config` and `audio` must be
     * provided.
     * For streaming audio detect intent, `config` must be provided in
     * the first request and `audio` must be provided in all following requests.
     *
     * Generated from protobuf field <code>bytes audio = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setAudio($var)
    {
        GPBUtil::checkString($var, False);
        $this->audio = $var;

        return $this;
    }

}

