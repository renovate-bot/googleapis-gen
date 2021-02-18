<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/speech/v1p1beta1/cloud_speech.proto

namespace Google\Cloud\Speech\V1p1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Describes the progress of a long-running `LongRunningRecognize` call. It is
 * included in the `metadata` field of the `Operation` returned by the
 * `GetOperation` call of the `google::longrunning::Operations` service.
 *
 * Generated from protobuf message <code>google.cloud.speech.v1p1beta1.LongRunningRecognizeMetadata</code>
 */
class LongRunningRecognizeMetadata extends \Google\Protobuf\Internal\Message
{
    /**
     * Approximate percentage of audio processed thus far. Guaranteed to be 100
     * when the audio is fully processed and the results are available.
     *
     * Generated from protobuf field <code>int32 progress_percent = 1;</code>
     */
    protected $progress_percent = 0;
    /**
     * Time when the request was received.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp start_time = 2;</code>
     */
    protected $start_time = null;
    /**
     * Time of the most recent processing update.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp last_update_time = 3;</code>
     */
    protected $last_update_time = null;
    /**
     * Output only. The URI of the audio file being transcribed. Empty if the
     * audio was sent as byte content.
     *
     * Generated from protobuf field <code>string uri = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $uri = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type int $progress_percent
     *           Approximate percentage of audio processed thus far. Guaranteed to be 100
     *           when the audio is fully processed and the results are available.
     *     @type \Google\Protobuf\Timestamp $start_time
     *           Time when the request was received.
     *     @type \Google\Protobuf\Timestamp $last_update_time
     *           Time of the most recent processing update.
     *     @type string $uri
     *           Output only. The URI of the audio file being transcribed. Empty if the
     *           audio was sent as byte content.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Speech\V1P1Beta1\CloudSpeech::initOnce();
        parent::__construct($data);
    }

    /**
     * Approximate percentage of audio processed thus far. Guaranteed to be 100
     * when the audio is fully processed and the results are available.
     *
     * Generated from protobuf field <code>int32 progress_percent = 1;</code>
     * @return int
     */
    public function getProgressPercent()
    {
        return $this->progress_percent;
    }

    /**
     * Approximate percentage of audio processed thus far. Guaranteed to be 100
     * when the audio is fully processed and the results are available.
     *
     * Generated from protobuf field <code>int32 progress_percent = 1;</code>
     * @param int $var
     * @return $this
     */
    public function setProgressPercent($var)
    {
        GPBUtil::checkInt32($var);
        $this->progress_percent = $var;

        return $this;
    }

    /**
     * Time when the request was received.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp start_time = 2;</code>
     * @return \Google\Protobuf\Timestamp
     */
    public function getStartTime()
    {
        return isset($this->start_time) ? $this->start_time : null;
    }

    public function hasStartTime()
    {
        return isset($this->start_time);
    }

    public function clearStartTime()
    {
        unset($this->start_time);
    }

    /**
     * Time when the request was received.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp start_time = 2;</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setStartTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->start_time = $var;

        return $this;
    }

    /**
     * Time of the most recent processing update.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp last_update_time = 3;</code>
     * @return \Google\Protobuf\Timestamp
     */
    public function getLastUpdateTime()
    {
        return isset($this->last_update_time) ? $this->last_update_time : null;
    }

    public function hasLastUpdateTime()
    {
        return isset($this->last_update_time);
    }

    public function clearLastUpdateTime()
    {
        unset($this->last_update_time);
    }

    /**
     * Time of the most recent processing update.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp last_update_time = 3;</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setLastUpdateTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->last_update_time = $var;

        return $this;
    }

    /**
     * Output only. The URI of the audio file being transcribed. Empty if the
     * audio was sent as byte content.
     *
     * Generated from protobuf field <code>string uri = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return string
     */
    public function getUri()
    {
        return $this->uri;
    }

    /**
     * Output only. The URI of the audio file being transcribed. Empty if the
     * audio was sent as byte content.
     *
     * Generated from protobuf field <code>string uri = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param string $var
     * @return $this
     */
    public function setUri($var)
    {
        GPBUtil::checkString($var, True);
        $this->uri = $var;

        return $this;
    }

}

