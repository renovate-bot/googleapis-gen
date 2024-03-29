<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dataqna/v1alpha/question.proto

namespace Google\Cloud\DataQnA\V1alpha;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Information about the backend status (such as BigQuery) of the execution.
 *
 * Generated from protobuf message <code>google.cloud.dataqna.v1alpha.ExecutionInfo</code>
 */
class ExecutionInfo extends \Google\Protobuf\Internal\Message
{
    /**
     * Status returned by the backend when the job was created.
     *
     * Generated from protobuf field <code>.google.rpc.Status job_creation_status = 1;</code>
     */
    protected $job_creation_status = null;
    /**
     * Status of the job execution.
     *
     * Generated from protobuf field <code>.google.cloud.dataqna.v1alpha.ExecutionInfo.JobExecutionState job_execution_state = 2;</code>
     */
    protected $job_execution_state = 0;
    /**
     * Time when the execution was triggered.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 3;</code>
     */
    protected $create_time = null;
    /**
     * BigQuery job information.
     * Future versions will have different backends. Hence, clients must make sure
     * they can handle it when this field is not populated.
     *
     * Generated from protobuf field <code>.google.cloud.dataqna.v1alpha.BigQueryJob bigquery_job = 4;</code>
     */
    protected $bigquery_job = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Rpc\Status $job_creation_status
     *           Status returned by the backend when the job was created.
     *     @type int $job_execution_state
     *           Status of the job execution.
     *     @type \Google\Protobuf\Timestamp $create_time
     *           Time when the execution was triggered.
     *     @type \Google\Cloud\DataQnA\V1alpha\BigQueryJob $bigquery_job
     *           BigQuery job information.
     *           Future versions will have different backends. Hence, clients must make sure
     *           they can handle it when this field is not populated.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dataqna\V1Alpha\Question::initOnce();
        parent::__construct($data);
    }

    /**
     * Status returned by the backend when the job was created.
     *
     * Generated from protobuf field <code>.google.rpc.Status job_creation_status = 1;</code>
     * @return \Google\Rpc\Status|null
     */
    public function getJobCreationStatus()
    {
        return $this->job_creation_status;
    }

    public function hasJobCreationStatus()
    {
        return isset($this->job_creation_status);
    }

    public function clearJobCreationStatus()
    {
        unset($this->job_creation_status);
    }

    /**
     * Status returned by the backend when the job was created.
     *
     * Generated from protobuf field <code>.google.rpc.Status job_creation_status = 1;</code>
     * @param \Google\Rpc\Status $var
     * @return $this
     */
    public function setJobCreationStatus($var)
    {
        GPBUtil::checkMessage($var, \Google\Rpc\Status::class);
        $this->job_creation_status = $var;

        return $this;
    }

    /**
     * Status of the job execution.
     *
     * Generated from protobuf field <code>.google.cloud.dataqna.v1alpha.ExecutionInfo.JobExecutionState job_execution_state = 2;</code>
     * @return int
     */
    public function getJobExecutionState()
    {
        return $this->job_execution_state;
    }

    /**
     * Status of the job execution.
     *
     * Generated from protobuf field <code>.google.cloud.dataqna.v1alpha.ExecutionInfo.JobExecutionState job_execution_state = 2;</code>
     * @param int $var
     * @return $this
     */
    public function setJobExecutionState($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\DataQnA\V1alpha\ExecutionInfo\JobExecutionState::class);
        $this->job_execution_state = $var;

        return $this;
    }

    /**
     * Time when the execution was triggered.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 3;</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getCreateTime()
    {
        return $this->create_time;
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
     * Time when the execution was triggered.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp create_time = 3;</code>
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
     * BigQuery job information.
     * Future versions will have different backends. Hence, clients must make sure
     * they can handle it when this field is not populated.
     *
     * Generated from protobuf field <code>.google.cloud.dataqna.v1alpha.BigQueryJob bigquery_job = 4;</code>
     * @return \Google\Cloud\DataQnA\V1alpha\BigQueryJob|null
     */
    public function getBigqueryJob()
    {
        return $this->bigquery_job;
    }

    public function hasBigqueryJob()
    {
        return isset($this->bigquery_job);
    }

    public function clearBigqueryJob()
    {
        unset($this->bigquery_job);
    }

    /**
     * BigQuery job information.
     * Future versions will have different backends. Hence, clients must make sure
     * they can handle it when this field is not populated.
     *
     * Generated from protobuf field <code>.google.cloud.dataqna.v1alpha.BigQueryJob bigquery_job = 4;</code>
     * @param \Google\Cloud\DataQnA\V1alpha\BigQueryJob $var
     * @return $this
     */
    public function setBigqueryJob($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\DataQnA\V1alpha\BigQueryJob::class);
        $this->bigquery_job = $var;

        return $this;
    }

}

