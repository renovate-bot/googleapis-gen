<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/texttospeech/v1beta1/cloud_tts.proto

namespace Google\Cloud\TextToSpeech\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The message returned to the client by the `SynthesizeSpeech` method.
 *
 * Generated from protobuf message <code>google.cloud.texttospeech.v1beta1.SynthesizeSpeechResponse</code>
 */
class SynthesizeSpeechResponse extends \Google\Protobuf\Internal\Message
{
    /**
     * The audio data bytes encoded as specified in the request, including the
     * header for encodings that are wrapped in containers (e.g. MP3, OGG_OPUS).
     * For LINEAR16 audio, we include the WAV header. Note: as
     * with all bytes fields, protobuffers use a pure binary representation,
     * whereas JSON representations use base64.
     *
     * Generated from protobuf field <code>bytes audio_content = 1;</code>
     */
    protected $audio_content = '';
    /**
     * A link between a position in the original request input and a corresponding
     * time in the output audio. It's only supported via `<mark>` of SSML input.
     *
     * Generated from protobuf field <code>repeated .google.cloud.texttospeech.v1beta1.Timepoint timepoints = 2;</code>
     */
    private $timepoints;
    /**
     * The audio metadata of `audio_content`.
     *
     * Generated from protobuf field <code>.google.cloud.texttospeech.v1beta1.AudioConfig audio_config = 4;</code>
     */
    protected $audio_config = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $audio_content
     *           The audio data bytes encoded as specified in the request, including the
     *           header for encodings that are wrapped in containers (e.g. MP3, OGG_OPUS).
     *           For LINEAR16 audio, we include the WAV header. Note: as
     *           with all bytes fields, protobuffers use a pure binary representation,
     *           whereas JSON representations use base64.
     *     @type \Google\Cloud\TextToSpeech\V1beta1\Timepoint[]|\Google\Protobuf\Internal\RepeatedField $timepoints
     *           A link between a position in the original request input and a corresponding
     *           time in the output audio. It's only supported via `<mark>` of SSML input.
     *     @type \Google\Cloud\TextToSpeech\V1beta1\AudioConfig $audio_config
     *           The audio metadata of `audio_content`.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Texttospeech\V1Beta1\CloudTts::initOnce();
        parent::__construct($data);
    }

    /**
     * The audio data bytes encoded as specified in the request, including the
     * header for encodings that are wrapped in containers (e.g. MP3, OGG_OPUS).
     * For LINEAR16 audio, we include the WAV header. Note: as
     * with all bytes fields, protobuffers use a pure binary representation,
     * whereas JSON representations use base64.
     *
     * Generated from protobuf field <code>bytes audio_content = 1;</code>
     * @return string
     */
    public function getAudioContent()
    {
        return $this->audio_content;
    }

    /**
     * The audio data bytes encoded as specified in the request, including the
     * header for encodings that are wrapped in containers (e.g. MP3, OGG_OPUS).
     * For LINEAR16 audio, we include the WAV header. Note: as
     * with all bytes fields, protobuffers use a pure binary representation,
     * whereas JSON representations use base64.
     *
     * Generated from protobuf field <code>bytes audio_content = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setAudioContent($var)
    {
        GPBUtil::checkString($var, False);
        $this->audio_content = $var;

        return $this;
    }

    /**
     * A link between a position in the original request input and a corresponding
     * time in the output audio. It's only supported via `<mark>` of SSML input.
     *
     * Generated from protobuf field <code>repeated .google.cloud.texttospeech.v1beta1.Timepoint timepoints = 2;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getTimepoints()
    {
        return $this->timepoints;
    }

    /**
     * A link between a position in the original request input and a corresponding
     * time in the output audio. It's only supported via `<mark>` of SSML input.
     *
     * Generated from protobuf field <code>repeated .google.cloud.texttospeech.v1beta1.Timepoint timepoints = 2;</code>
     * @param \Google\Cloud\TextToSpeech\V1beta1\Timepoint[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setTimepoints($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\TextToSpeech\V1beta1\Timepoint::class);
        $this->timepoints = $arr;

        return $this;
    }

    /**
     * The audio metadata of `audio_content`.
     *
     * Generated from protobuf field <code>.google.cloud.texttospeech.v1beta1.AudioConfig audio_config = 4;</code>
     * @return \Google\Cloud\TextToSpeech\V1beta1\AudioConfig|null
     */
    public function getAudioConfig()
    {
        return isset($this->audio_config) ? $this->audio_config : null;
    }

    public function hasAudioConfig()
    {
        return isset($this->audio_config);
    }

    public function clearAudioConfig()
    {
        unset($this->audio_config);
    }

    /**
     * The audio metadata of `audio_content`.
     *
     * Generated from protobuf field <code>.google.cloud.texttospeech.v1beta1.AudioConfig audio_config = 4;</code>
     * @param \Google\Cloud\TextToSpeech\V1beta1\AudioConfig $var
     * @return $this
     */
    public function setAudioConfig($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\TextToSpeech\V1beta1\AudioConfig::class);
        $this->audio_config = $var;

        return $this;
    }

}

