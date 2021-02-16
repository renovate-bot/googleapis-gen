<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3beta1/experiment.proto

namespace Google\Cloud\Dialogflow\Cx\V3beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Represents an experiment in an environment.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3beta1.Experiment</code>
 */
class Experiment extends \Google\Protobuf\Internal\Message
{
    /**
     * The name of the experiment.
     * Format: projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/environments/<Environment ID>/experiments/<Experiment ID>..
     *
     * Generated from protobuf field <code>string name = 1;</code>
     */
    protected $name = '';
    /**
     * Required. The human-readable name of the experiment (unique in an environment). Limit
     * of 64 characters.
     *
     * Generated from protobuf field <code>string display_name = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $display_name = '';
    /**
     * The human-readable description of the experiment.
     *
     * Generated from protobuf field <code>string description = 3;</code>
     */
    protected $description = '';
    /**
     * The current state of the experiment.
     * Transition triggered by Expriments.StartExperiment: PENDING->RUNNING.
     * Transition triggered by Expriments.CancelExperiment: PENDING->CANCELLED or
     * RUNNING->CANCELLED.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.Experiment.State state = 4;</code>
     */
    protected $state = 0;
    /**
     * The definition of the experiment.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.Experiment.Definition definition = 5;</code>
     */
    protected $definition = null;
    /**
     * Inference result of the experiment.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.Experiment.Result result = 6;</code>
     */
    protected $result = null;
    /**
     * Creation time of this experiment.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 7;</code>
     */
    protected $create_time = null;
    /**
     * Start time of this experiment.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp start_time = 8;</code>
     */
    protected $start_time = null;
    /**
     * End time of this experiment.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp end_time = 9;</code>
     */
    protected $end_time = null;
    /**
     * Last update time of this experiment.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp last_update_time = 10;</code>
     */
    protected $last_update_time = null;
    /**
     * Maximum number of days to run the experiment.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration experiment_length = 11;</code>
     */
    protected $experiment_length = null;
    /**
     * The history of updates to the experiment variants.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3beta1.VariantsHistory variants_history = 12;</code>
     */
    private $variants_history;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           The name of the experiment.
     *           Format: projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *           ID>/environments/<Environment ID>/experiments/<Experiment ID>..
     *     @type string $display_name
     *           Required. The human-readable name of the experiment (unique in an environment). Limit
     *           of 64 characters.
     *     @type string $description
     *           The human-readable description of the experiment.
     *     @type int $state
     *           The current state of the experiment.
     *           Transition triggered by Expriments.StartExperiment: PENDING->RUNNING.
     *           Transition triggered by Expriments.CancelExperiment: PENDING->CANCELLED or
     *           RUNNING->CANCELLED.
     *     @type \Google\Cloud\Dialogflow\Cx\V3beta1\Experiment\Definition $definition
     *           The definition of the experiment.
     *     @type \Google\Cloud\Dialogflow\Cx\V3beta1\Experiment\Result $result
     *           Inference result of the experiment.
     *     @type \Google\Protobuf\Timestamp $create_time
     *           Creation time of this experiment.
     *     @type \Google\Protobuf\Timestamp $start_time
     *           Start time of this experiment.
     *     @type \Google\Protobuf\Timestamp $end_time
     *           End time of this experiment.
     *     @type \Google\Protobuf\Timestamp $last_update_time
     *           Last update time of this experiment.
     *     @type \Google\Protobuf\Duration $experiment_length
     *           Maximum number of days to run the experiment.
     *     @type \Google\Cloud\Dialogflow\Cx\V3beta1\VariantsHistory[]|\Google\Protobuf\Internal\RepeatedField $variants_history
     *           The history of updates to the experiment variants.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3Beta1\Experiment::initOnce();
        parent::__construct($data);
    }

    /**
     * The name of the experiment.
     * Format: projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/environments/<Environment ID>/experiments/<Experiment ID>..
     *
     * Generated from protobuf field <code>string name = 1;</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * The name of the experiment.
     * Format: projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/environments/<Environment ID>/experiments/<Experiment ID>..
     *
     * Generated from protobuf field <code>string name = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setName($var)
    {
        GPBUtil::checkString($var, True);
        $this->name = $var;

        return $this;
    }

    /**
     * Required. The human-readable name of the experiment (unique in an environment). Limit
     * of 64 characters.
     *
     * Generated from protobuf field <code>string display_name = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getDisplayName()
    {
        return $this->display_name;
    }

    /**
     * Required. The human-readable name of the experiment (unique in an environment). Limit
     * of 64 characters.
     *
     * Generated from protobuf field <code>string display_name = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setDisplayName($var)
    {
        GPBUtil::checkString($var, True);
        $this->display_name = $var;

        return $this;
    }

    /**
     * The human-readable description of the experiment.
     *
     * Generated from protobuf field <code>string description = 3;</code>
     * @return string
     */
    public function getDescription()
    {
        return $this->description;
    }

    /**
     * The human-readable description of the experiment.
     *
     * Generated from protobuf field <code>string description = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setDescription($var)
    {
        GPBUtil::checkString($var, True);
        $this->description = $var;

        return $this;
    }

    /**
     * The current state of the experiment.
     * Transition triggered by Expriments.StartExperiment: PENDING->RUNNING.
     * Transition triggered by Expriments.CancelExperiment: PENDING->CANCELLED or
     * RUNNING->CANCELLED.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.Experiment.State state = 4;</code>
     * @return int
     */
    public function getState()
    {
        return $this->state;
    }

    /**
     * The current state of the experiment.
     * Transition triggered by Expriments.StartExperiment: PENDING->RUNNING.
     * Transition triggered by Expriments.CancelExperiment: PENDING->CANCELLED or
     * RUNNING->CANCELLED.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.Experiment.State state = 4;</code>
     * @param int $var
     * @return $this
     */
    public function setState($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\Dialogflow\Cx\V3beta1\Experiment\State::class);
        $this->state = $var;

        return $this;
    }

    /**
     * The definition of the experiment.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.Experiment.Definition definition = 5;</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3beta1\Experiment\Definition
     */
    public function getDefinition()
    {
        return isset($this->definition) ? $this->definition : null;
    }

    public function hasDefinition()
    {
        return isset($this->definition);
    }

    public function clearDefinition()
    {
        unset($this->definition);
    }

    /**
     * The definition of the experiment.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.Experiment.Definition definition = 5;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\Experiment\Definition $var
     * @return $this
     */
    public function setDefinition($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3beta1\Experiment\Definition::class);
        $this->definition = $var;

        return $this;
    }

    /**
     * Inference result of the experiment.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.Experiment.Result result = 6;</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3beta1\Experiment\Result
     */
    public function getResult()
    {
        return isset($this->result) ? $this->result : null;
    }

    public function hasResult()
    {
        return isset($this->result);
    }

    public function clearResult()
    {
        unset($this->result);
    }

    /**
     * Inference result of the experiment.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3beta1.Experiment.Result result = 6;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\Experiment\Result $var
     * @return $this
     */
    public function setResult($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3beta1\Experiment\Result::class);
        $this->result = $var;

        return $this;
    }

    /**
     * Creation time of this experiment.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 7;</code>
     * @return \Google\Protobuf\Timestamp
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
     * Creation time of this experiment.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 7;</code>
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
     * Start time of this experiment.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp start_time = 8;</code>
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
     * Start time of this experiment.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp start_time = 8;</code>
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
     * End time of this experiment.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp end_time = 9;</code>
     * @return \Google\Protobuf\Timestamp
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
     * End time of this experiment.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp end_time = 9;</code>
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
     * Last update time of this experiment.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp last_update_time = 10;</code>
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
     * Last update time of this experiment.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp last_update_time = 10;</code>
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
     * Maximum number of days to run the experiment.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration experiment_length = 11;</code>
     * @return \Google\Protobuf\Duration
     */
    public function getExperimentLength()
    {
        return isset($this->experiment_length) ? $this->experiment_length : null;
    }

    public function hasExperimentLength()
    {
        return isset($this->experiment_length);
    }

    public function clearExperimentLength()
    {
        unset($this->experiment_length);
    }

    /**
     * Maximum number of days to run the experiment.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration experiment_length = 11;</code>
     * @param \Google\Protobuf\Duration $var
     * @return $this
     */
    public function setExperimentLength($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Duration::class);
        $this->experiment_length = $var;

        return $this;
    }

    /**
     * The history of updates to the experiment variants.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3beta1.VariantsHistory variants_history = 12;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getVariantsHistory()
    {
        return $this->variants_history;
    }

    /**
     * The history of updates to the experiment variants.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3beta1.VariantsHistory variants_history = 12;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\VariantsHistory[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setVariantsHistory($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Dialogflow\Cx\V3beta1\VariantsHistory::class);
        $this->variants_history = $arr;

        return $this;
    }

}

