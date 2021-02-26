<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/test_case.proto

namespace Google\Cloud\Dialogflow\Cx\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The request message for [TestCases.UpdateTestCase][google.cloud.dialogflow.cx.v3.TestCases.UpdateTestCase].
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3.UpdateTestCaseRequest</code>
 */
class UpdateTestCaseRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The test case to update.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.TestCase test_case = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $test_case = null;
    /**
     * Required. The mask to specify which fields should be updated. The
     * [`creationTime`][google.cloud.dialogflow.cx.v3.TestCase.creation_time] and
     * [`lastTestResult`][google.cloud.dialogflow.cx.v3.TestCase.last_test_result] cannot be updated.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $update_mask = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Dialogflow\Cx\V3\TestCase $test_case
     *           Required. The test case to update.
     *     @type \Google\Protobuf\FieldMask $update_mask
     *           Required. The mask to specify which fields should be updated. The
     *           [`creationTime`][google.cloud.dialogflow.cx.v3.TestCase.creation_time] and
     *           [`lastTestResult`][google.cloud.dialogflow.cx.v3.TestCase.last_test_result] cannot be updated.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\TestCase::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The test case to update.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.TestCase test_case = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3\TestCase|null
     */
    public function getTestCase()
    {
        return isset($this->test_case) ? $this->test_case : null;
    }

    public function hasTestCase()
    {
        return isset($this->test_case);
    }

    public function clearTestCase()
    {
        unset($this->test_case);
    }

    /**
     * Required. The test case to update.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.TestCase test_case = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3\TestCase $var
     * @return $this
     */
    public function setTestCase($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3\TestCase::class);
        $this->test_case = $var;

        return $this;
    }

    /**
     * Required. The mask to specify which fields should be updated. The
     * [`creationTime`][google.cloud.dialogflow.cx.v3.TestCase.creation_time] and
     * [`lastTestResult`][google.cloud.dialogflow.cx.v3.TestCase.last_test_result] cannot be updated.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Protobuf\FieldMask|null
     */
    public function getUpdateMask()
    {
        return isset($this->update_mask) ? $this->update_mask : null;
    }

    public function hasUpdateMask()
    {
        return isset($this->update_mask);
    }

    public function clearUpdateMask()
    {
        unset($this->update_mask);
    }

    /**
     * Required. The mask to specify which fields should be updated. The
     * [`creationTime`][google.cloud.dialogflow.cx.v3.TestCase.creation_time] and
     * [`lastTestResult`][google.cloud.dialogflow.cx.v3.TestCase.last_test_result] cannot be updated.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Protobuf\FieldMask $var
     * @return $this
     */
    public function setUpdateMask($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\FieldMask::class);
        $this->update_mask = $var;

        return $this;
    }

}

