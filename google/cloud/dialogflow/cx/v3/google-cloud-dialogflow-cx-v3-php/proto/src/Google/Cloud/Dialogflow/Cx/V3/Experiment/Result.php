<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/experiment.proto

namespace Google\Cloud\Dialogflow\Cx\V3\Experiment;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The inference result which includes an objective metric to optimize and the
 * confidence interval.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3.Experiment.Result</code>
 */
class Result extends \Google\Protobuf\Internal\Message
{
    /**
     * Version variants and metrics.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3.Experiment.Result.VersionMetrics version_metrics = 1;</code>
     */
    private $version_metrics;
    /**
     * The last time the experiment's stats data was updated. Will have default
     * value if stats have never been computed for this experiment.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp last_update_time = 2;</code>
     */
    protected $last_update_time = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Dialogflow\Cx\V3\Experiment\Result\VersionMetrics[]|\Google\Protobuf\Internal\RepeatedField $version_metrics
     *           Version variants and metrics.
     *     @type \Google\Protobuf\Timestamp $last_update_time
     *           The last time the experiment's stats data was updated. Will have default
     *           value if stats have never been computed for this experiment.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\Experiment::initOnce();
        parent::__construct($data);
    }

    /**
     * Version variants and metrics.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3.Experiment.Result.VersionMetrics version_metrics = 1;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getVersionMetrics()
    {
        return $this->version_metrics;
    }

    /**
     * Version variants and metrics.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3.Experiment.Result.VersionMetrics version_metrics = 1;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3\Experiment\Result\VersionMetrics[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setVersionMetrics($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Dialogflow\Cx\V3\Experiment\Result\VersionMetrics::class);
        $this->version_metrics = $arr;

        return $this;
    }

    /**
     * The last time the experiment's stats data was updated. Will have default
     * value if stats have never been computed for this experiment.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp last_update_time = 2;</code>
     * @return \Google\Protobuf\Timestamp|null
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
     * The last time the experiment's stats data was updated. Will have default
     * value if stats have never been computed for this experiment.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp last_update_time = 2;</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setLastUpdateTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->last_update_time = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(Result::class, \Google\Cloud\Dialogflow\Cx\V3\Experiment_Result::class);

