<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/tasks/v2beta2/task.proto

namespace Google\Cloud\Tasks\V2beta2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The status of a task attempt.
 *
 * Generated from protobuf message <code>google.cloud.tasks.v2beta2.AttemptStatus</code>
 */
class AttemptStatus extends \Google\Protobuf\Internal\Message
{
    /**
     * Output only. The time that this attempt was scheduled.
     * `schedule_time` will be truncated to the nearest microsecond.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp schedule_time = 1;</code>
     */
    protected $schedule_time = null;
    /**
     * Output only. The time that this attempt was dispatched.
     * `dispatch_time` will be truncated to the nearest microsecond.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp dispatch_time = 2;</code>
     */
    protected $dispatch_time = null;
    /**
     * Output only. The time that this attempt response was received.
     * `response_time` will be truncated to the nearest microsecond.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp response_time = 3;</code>
     */
    protected $response_time = null;
    /**
     * Output only. The response from the target for this attempt.
     * If the task has not been attempted or the task is currently running
     * then the response status is unset.
     *
     * Generated from protobuf field <code>.google.rpc.Status response_status = 4;</code>
     */
    protected $response_status = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Protobuf\Timestamp $schedule_time
     *           Output only. The time that this attempt was scheduled.
     *           `schedule_time` will be truncated to the nearest microsecond.
     *     @type \Google\Protobuf\Timestamp $dispatch_time
     *           Output only. The time that this attempt was dispatched.
     *           `dispatch_time` will be truncated to the nearest microsecond.
     *     @type \Google\Protobuf\Timestamp $response_time
     *           Output only. The time that this attempt response was received.
     *           `response_time` will be truncated to the nearest microsecond.
     *     @type \Google\Rpc\Status $response_status
     *           Output only. The response from the target for this attempt.
     *           If the task has not been attempted or the task is currently running
     *           then the response status is unset.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Tasks\V2Beta2\Task::initOnce();
        parent::__construct($data);
    }

    /**
     * Output only. The time that this attempt was scheduled.
     * `schedule_time` will be truncated to the nearest microsecond.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp schedule_time = 1;</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getScheduleTime()
    {
        return isset($this->schedule_time) ? $this->schedule_time : null;
    }

    public function hasScheduleTime()
    {
        return isset($this->schedule_time);
    }

    public function clearScheduleTime()
    {
        unset($this->schedule_time);
    }

    /**
     * Output only. The time that this attempt was scheduled.
     * `schedule_time` will be truncated to the nearest microsecond.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp schedule_time = 1;</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setScheduleTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->schedule_time = $var;

        return $this;
    }

    /**
     * Output only. The time that this attempt was dispatched.
     * `dispatch_time` will be truncated to the nearest microsecond.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp dispatch_time = 2;</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getDispatchTime()
    {
        return isset($this->dispatch_time) ? $this->dispatch_time : null;
    }

    public function hasDispatchTime()
    {
        return isset($this->dispatch_time);
    }

    public function clearDispatchTime()
    {
        unset($this->dispatch_time);
    }

    /**
     * Output only. The time that this attempt was dispatched.
     * `dispatch_time` will be truncated to the nearest microsecond.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp dispatch_time = 2;</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setDispatchTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->dispatch_time = $var;

        return $this;
    }

    /**
     * Output only. The time that this attempt response was received.
     * `response_time` will be truncated to the nearest microsecond.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp response_time = 3;</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getResponseTime()
    {
        return isset($this->response_time) ? $this->response_time : null;
    }

    public function hasResponseTime()
    {
        return isset($this->response_time);
    }

    public function clearResponseTime()
    {
        unset($this->response_time);
    }

    /**
     * Output only. The time that this attempt response was received.
     * `response_time` will be truncated to the nearest microsecond.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp response_time = 3;</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setResponseTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->response_time = $var;

        return $this;
    }

    /**
     * Output only. The response from the target for this attempt.
     * If the task has not been attempted or the task is currently running
     * then the response status is unset.
     *
     * Generated from protobuf field <code>.google.rpc.Status response_status = 4;</code>
     * @return \Google\Rpc\Status|null
     */
    public function getResponseStatus()
    {
        return isset($this->response_status) ? $this->response_status : null;
    }

    public function hasResponseStatus()
    {
        return isset($this->response_status);
    }

    public function clearResponseStatus()
    {
        unset($this->response_status);
    }

    /**
     * Output only. The response from the target for this attempt.
     * If the task has not been attempted or the task is currently running
     * then the response status is unset.
     *
     * Generated from protobuf field <code>.google.rpc.Status response_status = 4;</code>
     * @param \Google\Rpc\Status $var
     * @return $this
     */
    public function setResponseStatus($var)
    {
        GPBUtil::checkMessage($var, \Google\Rpc\Status::class);
        $this->response_status = $var;

        return $this;
    }

}

