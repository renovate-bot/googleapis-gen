<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/tpu/v1/cloud_tpu.proto

namespace Google\Cloud\Tpu\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A Symptom instance.
 *
 * Generated from protobuf message <code>google.cloud.tpu.v1.Symptom</code>
 */
class Symptom extends \Google\Protobuf\Internal\Message
{
    /**
     * Timestamp when the Symptom is created.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 1;</code>
     */
    protected $create_time = null;
    /**
     * Type of the Symptom.
     *
     * Generated from protobuf field <code>.google.cloud.tpu.v1.Symptom.SymptomType symptom_type = 2;</code>
     */
    protected $symptom_type = 0;
    /**
     * Detailed information of the current Symptom.
     *
     * Generated from protobuf field <code>string details = 3;</code>
     */
    protected $details = '';
    /**
     * A string used to uniquely distinguish a worker within a TPU node.
     *
     * Generated from protobuf field <code>string worker_id = 4;</code>
     */
    protected $worker_id = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Protobuf\Timestamp $create_time
     *           Timestamp when the Symptom is created.
     *     @type int $symptom_type
     *           Type of the Symptom.
     *     @type string $details
     *           Detailed information of the current Symptom.
     *     @type string $worker_id
     *           A string used to uniquely distinguish a worker within a TPU node.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Tpu\V1\CloudTpu::initOnce();
        parent::__construct($data);
    }

    /**
     * Timestamp when the Symptom is created.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 1;</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getCreateTime()
    {
        return isset($this->create_time) ? $this->create_time : null;
    }

    public function hasCreateTime()
    {
        return isset($this->create_time);
    }

    public function clearCreateTime()
    {
        unset($this->create_time);
    }

    /**
     * Timestamp when the Symptom is created.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 1;</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setCreateTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->create_time = $var;

        return $this;
    }

    /**
     * Type of the Symptom.
     *
     * Generated from protobuf field <code>.google.cloud.tpu.v1.Symptom.SymptomType symptom_type = 2;</code>
     * @return int
     */
    public function getSymptomType()
    {
        return $this->symptom_type;
    }

    /**
     * Type of the Symptom.
     *
     * Generated from protobuf field <code>.google.cloud.tpu.v1.Symptom.SymptomType symptom_type = 2;</code>
     * @param int $var
     * @return $this
     */
    public function setSymptomType($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\Tpu\V1\Symptom\SymptomType::class);
        $this->symptom_type = $var;

        return $this;
    }

    /**
     * Detailed information of the current Symptom.
     *
     * Generated from protobuf field <code>string details = 3;</code>
     * @return string
     */
    public function getDetails()
    {
        return $this->details;
    }

    /**
     * Detailed information of the current Symptom.
     *
     * Generated from protobuf field <code>string details = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setDetails($var)
    {
        GPBUtil::checkString($var, True);
        $this->details = $var;

        return $this;
    }

    /**
     * A string used to uniquely distinguish a worker within a TPU node.
     *
     * Generated from protobuf field <code>string worker_id = 4;</code>
     * @return string
     */
    public function getWorkerId()
    {
        return $this->worker_id;
    }

    /**
     * A string used to uniquely distinguish a worker within a TPU node.
     *
     * Generated from protobuf field <code>string worker_id = 4;</code>
     * @param string $var
     * @return $this
     */
    public function setWorkerId($var)
    {
        GPBUtil::checkString($var, True);
        $this->worker_id = $var;

        return $this;
    }

}

