<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/test_case.proto

namespace Google\Cloud\Dialogflow\Cx\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Error info for running a test.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3.TestError</code>
 */
class TestError extends \Google\Protobuf\Internal\Message
{
    /**
     * The test case resource name.
     *
     * Generated from protobuf field <code>string test_case = 1 [(.google.api.resource_reference) = {</code>
     */
    protected $test_case = '';
    /**
     * The status associated with the test.
     *
     * Generated from protobuf field <code>.google.rpc.Status status = 2;</code>
     */
    protected $status = null;
    /**
     * The timestamp when the test was completed.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp test_time = 3;</code>
     */
    protected $test_time = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $test_case
     *           The test case resource name.
     *     @type \Google\Rpc\Status $status
     *           The status associated with the test.
     *     @type \Google\Protobuf\Timestamp $test_time
     *           The timestamp when the test was completed.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\TestCase::initOnce();
        parent::__construct($data);
    }

    /**
     * The test case resource name.
     *
     * Generated from protobuf field <code>string test_case = 1 [(.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getTestCase()
    {
        return $this->test_case;
    }

    /**
     * The test case resource name.
     *
     * Generated from protobuf field <code>string test_case = 1 [(.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setTestCase($var)
    {
        GPBUtil::checkString($var, True);
        $this->test_case = $var;

        return $this;
    }

    /**
     * The status associated with the test.
     *
     * Generated from protobuf field <code>.google.rpc.Status status = 2;</code>
     * @return \Google\Rpc\Status
     */
    public function getStatus()
    {
        return isset($this->status) ? $this->status : null;
    }

    public function hasStatus()
    {
        return isset($this->status);
    }

    public function clearStatus()
    {
        unset($this->status);
    }

    /**
     * The status associated with the test.
     *
     * Generated from protobuf field <code>.google.rpc.Status status = 2;</code>
     * @param \Google\Rpc\Status $var
     * @return $this
     */
    public function setStatus($var)
    {
        GPBUtil::checkMessage($var, \Google\Rpc\Status::class);
        $this->status = $var;

        return $this;
    }

    /**
     * The timestamp when the test was completed.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp test_time = 3;</code>
     * @return \Google\Protobuf\Timestamp
     */
    public function getTestTime()
    {
        return isset($this->test_time) ? $this->test_time : null;
    }

    public function hasTestTime()
    {
        return isset($this->test_time);
    }

    public function clearTestTime()
    {
        unset($this->test_time);
    }

    /**
     * The timestamp when the test was completed.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp test_time = 3;</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setTestTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->test_time = $var;

        return $this;
    }

}

