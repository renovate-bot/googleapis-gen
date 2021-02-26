<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dataproc/v1beta2/jobs.proto

namespace Google\Cloud\Dataproc\V1beta2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A request to submit a job.
 *
 * Generated from protobuf message <code>google.cloud.dataproc.v1beta2.SubmitJobRequest</code>
 */
class SubmitJobRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The ID of the Google Cloud Platform project that the job
     * belongs to.
     *
     * Generated from protobuf field <code>string project_id = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $project_id = '';
    /**
     * Required. The Dataproc region in which to handle the request.
     *
     * Generated from protobuf field <code>string region = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $region = '';
    /**
     * Required. The job resource.
     *
     * Generated from protobuf field <code>.google.cloud.dataproc.v1beta2.Job job = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $job = null;
    /**
     * Optional. A unique id used to identify the request. If the server
     * receives two [SubmitJobRequest][google.cloud.dataproc.v1beta2.SubmitJobRequest] requests  with the same
     * id, then the second request will be ignored and the
     * first [Job][google.cloud.dataproc.v1beta2.Job] created and stored in the backend
     * is returned.
     * It is recommended to always set this value to a
     * [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier).
     * The id must contain only letters (a-z, A-Z), numbers (0-9),
     * underscores (_), and hyphens (-). The maximum length is 40 characters.
     *
     * Generated from protobuf field <code>string request_id = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $request_id = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $project_id
     *           Required. The ID of the Google Cloud Platform project that the job
     *           belongs to.
     *     @type string $region
     *           Required. The Dataproc region in which to handle the request.
     *     @type \Google\Cloud\Dataproc\V1beta2\Job $job
     *           Required. The job resource.
     *     @type string $request_id
     *           Optional. A unique id used to identify the request. If the server
     *           receives two [SubmitJobRequest][google.cloud.dataproc.v1beta2.SubmitJobRequest] requests  with the same
     *           id, then the second request will be ignored and the
     *           first [Job][google.cloud.dataproc.v1beta2.Job] created and stored in the backend
     *           is returned.
     *           It is recommended to always set this value to a
     *           [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier).
     *           The id must contain only letters (a-z, A-Z), numbers (0-9),
     *           underscores (_), and hyphens (-). The maximum length is 40 characters.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dataproc\V1Beta2\Jobs::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The ID of the Google Cloud Platform project that the job
     * belongs to.
     *
     * Generated from protobuf field <code>string project_id = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getProjectId()
    {
        return $this->project_id;
    }

    /**
     * Required. The ID of the Google Cloud Platform project that the job
     * belongs to.
     *
     * Generated from protobuf field <code>string project_id = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setProjectId($var)
    {
        GPBUtil::checkString($var, True);
        $this->project_id = $var;

        return $this;
    }

    /**
     * Required. The Dataproc region in which to handle the request.
     *
     * Generated from protobuf field <code>string region = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getRegion()
    {
        return $this->region;
    }

    /**
     * Required. The Dataproc region in which to handle the request.
     *
     * Generated from protobuf field <code>string region = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setRegion($var)
    {
        GPBUtil::checkString($var, True);
        $this->region = $var;

        return $this;
    }

    /**
     * Required. The job resource.
     *
     * Generated from protobuf field <code>.google.cloud.dataproc.v1beta2.Job job = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Dataproc\V1beta2\Job|null
     */
    public function getJob()
    {
        return isset($this->job) ? $this->job : null;
    }

    public function hasJob()
    {
        return isset($this->job);
    }

    public function clearJob()
    {
        unset($this->job);
    }

    /**
     * Required. The job resource.
     *
     * Generated from protobuf field <code>.google.cloud.dataproc.v1beta2.Job job = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Dataproc\V1beta2\Job $var
     * @return $this
     */
    public function setJob($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dataproc\V1beta2\Job::class);
        $this->job = $var;

        return $this;
    }

    /**
     * Optional. A unique id used to identify the request. If the server
     * receives two [SubmitJobRequest][google.cloud.dataproc.v1beta2.SubmitJobRequest] requests  with the same
     * id, then the second request will be ignored and the
     * first [Job][google.cloud.dataproc.v1beta2.Job] created and stored in the backend
     * is returned.
     * It is recommended to always set this value to a
     * [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier).
     * The id must contain only letters (a-z, A-Z), numbers (0-9),
     * underscores (_), and hyphens (-). The maximum length is 40 characters.
     *
     * Generated from protobuf field <code>string request_id = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return string
     */
    public function getRequestId()
    {
        return $this->request_id;
    }

    /**
     * Optional. A unique id used to identify the request. If the server
     * receives two [SubmitJobRequest][google.cloud.dataproc.v1beta2.SubmitJobRequest] requests  with the same
     * id, then the second request will be ignored and the
     * first [Job][google.cloud.dataproc.v1beta2.Job] created and stored in the backend
     * is returned.
     * It is recommended to always set this value to a
     * [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier).
     * The id must contain only letters (a-z, A-Z), numbers (0-9),
     * underscores (_), and hyphens (-). The maximum length is 40 characters.
     *
     * Generated from protobuf field <code>string request_id = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param string $var
     * @return $this
     */
    public function setRequestId($var)
    {
        GPBUtil::checkString($var, True);
        $this->request_id = $var;

        return $this;
    }

}

