<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/speech/v1p1beta1/cloud_speech.proto

namespace Google\Cloud\Speech\V1p1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The top-level message sent by the client for the `LongRunningRecognize`
 * method.
 *
 * Generated from protobuf message <code>google.cloud.speech.v1p1beta1.LongRunningRecognizeRequest</code>
 */
class LongRunningRecognizeRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. Provides information to the recognizer that specifies how to
     * process the request.
     *
     * Generated from protobuf field <code>.google.cloud.speech.v1p1beta1.RecognitionConfig config = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $config = null;
    /**
     * Required. The audio data to be recognized.
     *
     * Generated from protobuf field <code>.google.cloud.speech.v1p1beta1.RecognitionAudio audio = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $audio = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Speech\V1p1beta1\RecognitionConfig $config
     *           Required. Provides information to the recognizer that specifies how to
     *           process the request.
     *     @type \Google\Cloud\Speech\V1p1beta1\RecognitionAudio $audio
     *           Required. The audio data to be recognized.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Speech\V1P1Beta1\CloudSpeech::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. Provides information to the recognizer that specifies how to
     * process the request.
     *
     * Generated from protobuf field <code>.google.cloud.speech.v1p1beta1.RecognitionConfig config = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Speech\V1p1beta1\RecognitionConfig|null
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
     * Required. Provides information to the recognizer that specifies how to
     * process the request.
     *
     * Generated from protobuf field <code>.google.cloud.speech.v1p1beta1.RecognitionConfig config = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Speech\V1p1beta1\RecognitionConfig $var
     * @return $this
     */
    public function setConfig($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Speech\V1p1beta1\RecognitionConfig::class);
        $this->config = $var;

        return $this;
    }

    /**
     * Required. The audio data to be recognized.
     *
     * Generated from protobuf field <code>.google.cloud.speech.v1p1beta1.RecognitionAudio audio = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Speech\V1p1beta1\RecognitionAudio|null
     */
    public function getAudio()
    {
        return isset($this->audio) ? $this->audio : null;
    }

    public function hasAudio()
    {
        return isset($this->audio);
    }

    public function clearAudio()
    {
        unset($this->audio);
    }

    /**
     * Required. The audio data to be recognized.
     *
     * Generated from protobuf field <code>.google.cloud.speech.v1p1beta1.RecognitionAudio audio = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Speech\V1p1beta1\RecognitionAudio $var
     * @return $this
     */
    public function setAudio($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Speech\V1p1beta1\RecognitionAudio::class);
        $this->audio = $var;

        return $this;
    }

}

