<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3beta1/audio_config.proto

namespace Google\Cloud\Dialogflow\Cx\V3beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Information for a word recognized by the speech recognizer.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3beta1.SpeechWordInfo</code>
 */
class SpeechWordInfo extends \Google\Protobuf\Internal\Message
{
    /**
     * The word this info is for.
     *
     * Generated from protobuf field <code>string word = 3;</code>
     */
    protected $word = '';
    /**
     * Time offset relative to the beginning of the audio that corresponds to the
     * start of the spoken word. This is an experimental feature and the accuracy
     * of the time offset can vary.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration start_offset = 1;</code>
     */
    protected $start_offset = null;
    /**
     * Time offset relative to the beginning of the audio that corresponds to the
     * end of the spoken word. This is an experimental feature and the accuracy of
     * the time offset can vary.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration end_offset = 2;</code>
     */
    protected $end_offset = null;
    /**
     * The Speech confidence between 0.0 and 1.0 for this word. A higher number
     * indicates an estimated greater likelihood that the recognized word is
     * correct. The default of 0.0 is a sentinel value indicating that confidence
     * was not set.
     * This field is not guaranteed to be fully stable over time for the same
     * audio input. Users should also not rely on it to always be provided.
     *
     * Generated from protobuf field <code>float confidence = 4;</code>
     */
    protected $confidence = 0.0;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $word
     *           The word this info is for.
     *     @type \Google\Protobuf\Duration $start_offset
     *           Time offset relative to the beginning of the audio that corresponds to the
     *           start of the spoken word. This is an experimental feature and the accuracy
     *           of the time offset can vary.
     *     @type \Google\Protobuf\Duration $end_offset
     *           Time offset relative to the beginning of the audio that corresponds to the
     *           end of the spoken word. This is an experimental feature and the accuracy of
     *           the time offset can vary.
     *     @type float $confidence
     *           The Speech confidence between 0.0 and 1.0 for this word. A higher number
     *           indicates an estimated greater likelihood that the recognized word is
     *           correct. The default of 0.0 is a sentinel value indicating that confidence
     *           was not set.
     *           This field is not guaranteed to be fully stable over time for the same
     *           audio input. Users should also not rely on it to always be provided.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3Beta1\AudioConfig::initOnce();
        parent::__construct($data);
    }

    /**
     * The word this info is for.
     *
     * Generated from protobuf field <code>string word = 3;</code>
     * @return string
     */
    public function getWord()
    {
        return $this->word;
    }

    /**
     * The word this info is for.
     *
     * Generated from protobuf field <code>string word = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setWord($var)
    {
        GPBUtil::checkString($var, True);
        $this->word = $var;

        return $this;
    }

    /**
     * Time offset relative to the beginning of the audio that corresponds to the
     * start of the spoken word. This is an experimental feature and the accuracy
     * of the time offset can vary.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration start_offset = 1;</code>
     * @return \Google\Protobuf\Duration|null
     */
    public function getStartOffset()
    {
        return isset($this->start_offset) ? $this->start_offset : null;
    }

    public function hasStartOffset()
    {
        return isset($this->start_offset);
    }

    public function clearStartOffset()
    {
        unset($this->start_offset);
    }

    /**
     * Time offset relative to the beginning of the audio that corresponds to the
     * start of the spoken word. This is an experimental feature and the accuracy
     * of the time offset can vary.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration start_offset = 1;</code>
     * @param \Google\Protobuf\Duration $var
     * @return $this
     */
    public function setStartOffset($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Duration::class);
        $this->start_offset = $var;

        return $this;
    }

    /**
     * Time offset relative to the beginning of the audio that corresponds to the
     * end of the spoken word. This is an experimental feature and the accuracy of
     * the time offset can vary.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration end_offset = 2;</code>
     * @return \Google\Protobuf\Duration|null
     */
    public function getEndOffset()
    {
        return isset($this->end_offset) ? $this->end_offset : null;
    }

    public function hasEndOffset()
    {
        return isset($this->end_offset);
    }

    public function clearEndOffset()
    {
        unset($this->end_offset);
    }

    /**
     * Time offset relative to the beginning of the audio that corresponds to the
     * end of the spoken word. This is an experimental feature and the accuracy of
     * the time offset can vary.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration end_offset = 2;</code>
     * @param \Google\Protobuf\Duration $var
     * @return $this
     */
    public function setEndOffset($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Duration::class);
        $this->end_offset = $var;

        return $this;
    }

    /**
     * The Speech confidence between 0.0 and 1.0 for this word. A higher number
     * indicates an estimated greater likelihood that the recognized word is
     * correct. The default of 0.0 is a sentinel value indicating that confidence
     * was not set.
     * This field is not guaranteed to be fully stable over time for the same
     * audio input. Users should also not rely on it to always be provided.
     *
     * Generated from protobuf field <code>float confidence = 4;</code>
     * @return float
     */
    public function getConfidence()
    {
        return $this->confidence;
    }

    /**
     * The Speech confidence between 0.0 and 1.0 for this word. A higher number
     * indicates an estimated greater likelihood that the recognized word is
     * correct. The default of 0.0 is a sentinel value indicating that confidence
     * was not set.
     * This field is not guaranteed to be fully stable over time for the same
     * audio input. Users should also not rely on it to always be provided.
     *
     * Generated from protobuf field <code>float confidence = 4;</code>
     * @param float $var
     * @return $this
     */
    public function setConfidence($var)
    {
        GPBUtil::checkFloat($var);
        $this->confidence = $var;

        return $this;
    }

}

