<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/aiplatform/v1beta1/study.proto

namespace Google\Cloud\Aiplatform\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A message representing a Trial. A Trial contains a unique set of Parameters
 * that has been or will be evaluated, along with the objective metrics got by
 * running the Trial.
 *
 * Generated from protobuf message <code>google.cloud.aiplatform.v1beta1.Trial</code>
 */
class Trial extends \Google\Protobuf\Internal\Message
{
    /**
     * Output only. The identifier of the Trial assigned by the service.
     *
     * Generated from protobuf field <code>string id = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $id = '';
    /**
     * Output only. The detailed state of the Trial.
     *
     * Generated from protobuf field <code>.google.cloud.aiplatform.v1beta1.Trial.State state = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $state = 0;
    /**
     * Output only. The parameters of the Trial.
     *
     * Generated from protobuf field <code>repeated .google.cloud.aiplatform.v1beta1.Trial.Parameter parameters = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    private $parameters;
    /**
     * Output only. The final measurement containing the objective value.
     *
     * Generated from protobuf field <code>.google.cloud.aiplatform.v1beta1.Measurement final_measurement = 5 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $final_measurement = null;
    /**
     * Output only. Time when the Trial was started.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp start_time = 7 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $start_time = null;
    /**
     * Output only. Time when the Trial's status changed to `SUCCEEDED` or `INFEASIBLE`.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp end_time = 8 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $end_time = null;
    /**
     * Output only. The CustomJob name linked to the Trial.
     * It's set for a HyperparameterTuningJob's Trial.
     *
     * Generated from protobuf field <code>string custom_job = 11 [(.google.api.field_behavior) = OUTPUT_ONLY, (.google.api.resource_reference) = {</code>
     */
    protected $custom_job = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $id
     *           Output only. The identifier of the Trial assigned by the service.
     *     @type int $state
     *           Output only. The detailed state of the Trial.
     *     @type \Google\Cloud\Aiplatform\V1beta1\Trial\Parameter[]|\Google\Protobuf\Internal\RepeatedField $parameters
     *           Output only. The parameters of the Trial.
     *     @type \Google\Cloud\Aiplatform\V1beta1\Measurement $final_measurement
     *           Output only. The final measurement containing the objective value.
     *     @type \Google\Protobuf\Timestamp $start_time
     *           Output only. Time when the Trial was started.
     *     @type \Google\Protobuf\Timestamp $end_time
     *           Output only. Time when the Trial's status changed to `SUCCEEDED` or `INFEASIBLE`.
     *     @type string $custom_job
     *           Output only. The CustomJob name linked to the Trial.
     *           It's set for a HyperparameterTuningJob's Trial.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Aiplatform\V1Beta1\Study::initOnce();
        parent::__construct($data);
    }

    /**
     * Output only. The identifier of the Trial assigned by the service.
     *
     * Generated from protobuf field <code>string id = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return string
     */
    public function getId()
    {
        return $this->id;
    }

    /**
     * Output only. The identifier of the Trial assigned by the service.
     *
     * Generated from protobuf field <code>string id = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param string $var
     * @return $this
     */
    public function setId($var)
    {
        GPBUtil::checkString($var, True);
        $this->id = $var;

        return $this;
    }

    /**
     * Output only. The detailed state of the Trial.
     *
     * Generated from protobuf field <code>.google.cloud.aiplatform.v1beta1.Trial.State state = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return int
     */
    public function getState()
    {
        return $this->state;
    }

    /**
     * Output only. The detailed state of the Trial.
     *
     * Generated from protobuf field <code>.google.cloud.aiplatform.v1beta1.Trial.State state = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param int $var
     * @return $this
     */
    public function setState($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\Aiplatform\V1beta1\Trial\State::class);
        $this->state = $var;

        return $this;
    }

    /**
     * Output only. The parameters of the Trial.
     *
     * Generated from protobuf field <code>repeated .google.cloud.aiplatform.v1beta1.Trial.Parameter parameters = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getParameters()
    {
        return $this->parameters;
    }

    /**
     * Output only. The parameters of the Trial.
     *
     * Generated from protobuf field <code>repeated .google.cloud.aiplatform.v1beta1.Trial.Parameter parameters = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Cloud\Aiplatform\V1beta1\Trial\Parameter[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setParameters($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Aiplatform\V1beta1\Trial\Parameter::class);
        $this->parameters = $arr;

        return $this;
    }

    /**
     * Output only. The final measurement containing the objective value.
     *
     * Generated from protobuf field <code>.google.cloud.aiplatform.v1beta1.Measurement final_measurement = 5 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Cloud\Aiplatform\V1beta1\Measurement|null
     */
    public function getFinalMeasurement()
    {
        return isset($this->final_measurement) ? $this->final_measurement : null;
    }

    public function hasFinalMeasurement()
    {
        return isset($this->final_measurement);
    }

    public function clearFinalMeasurement()
    {
        unset($this->final_measurement);
    }

    /**
     * Output only. The final measurement containing the objective value.
     *
     * Generated from protobuf field <code>.google.cloud.aiplatform.v1beta1.Measurement final_measurement = 5 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Cloud\Aiplatform\V1beta1\Measurement $var
     * @return $this
     */
    public function setFinalMeasurement($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Aiplatform\V1beta1\Measurement::class);
        $this->final_measurement = $var;

        return $this;
    }

    /**
     * Output only. Time when the Trial was started.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp start_time = 7 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\Timestamp|null
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
     * Output only. Time when the Trial was started.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp start_time = 7 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
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
     * Output only. Time when the Trial's status changed to `SUCCEEDED` or `INFEASIBLE`.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp end_time = 8 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getEndTime()
    {
        return isset($this->end_time) ? $this->end_time : null;
    }

    public function hasEndTime()
    {
        return isset($this->end_time);
    }

    public function clearEndTime()
    {
        unset($this->end_time);
    }

    /**
     * Output only. Time when the Trial's status changed to `SUCCEEDED` or `INFEASIBLE`.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp end_time = 8 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setEndTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->end_time = $var;

        return $this;
    }

    /**
     * Output only. The CustomJob name linked to the Trial.
     * It's set for a HyperparameterTuningJob's Trial.
     *
     * Generated from protobuf field <code>string custom_job = 11 [(.google.api.field_behavior) = OUTPUT_ONLY, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getCustomJob()
    {
        return $this->custom_job;
    }

    /**
     * Output only. The CustomJob name linked to the Trial.
     * It's set for a HyperparameterTuningJob's Trial.
     *
     * Generated from protobuf field <code>string custom_job = 11 [(.google.api.field_behavior) = OUTPUT_ONLY, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setCustomJob($var)
    {
        GPBUtil::checkString($var, True);
        $this->custom_job = $var;

        return $this;
    }

}

