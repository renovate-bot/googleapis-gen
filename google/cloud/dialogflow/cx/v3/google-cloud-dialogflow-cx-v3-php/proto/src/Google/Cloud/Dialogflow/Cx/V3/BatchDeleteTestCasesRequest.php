<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/test_case.proto

namespace Google\Cloud\Dialogflow\Cx\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The request message for [TestCases.BatchDeleteTestCases][google.cloud.dialogflow.cx.v3.TestCases.BatchDeleteTestCases].
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3.BatchDeleteTestCasesRequest</code>
 */
class BatchDeleteTestCasesRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The agent to delete test cases from.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * Required. Format of test case names: `projects/<Project ID>/locations/
     * <Location ID>/agents/<AgentID>/testCases/<TestCase ID>`.
     *
     * Generated from protobuf field <code>repeated string names = 3 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    private $names;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. The agent to delete test cases from.
     *           Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
     *     @type string[]|\Google\Protobuf\Internal\RepeatedField $names
     *           Required. Format of test case names: `projects/<Project ID>/locations/
     *           <Location ID>/agents/<AgentID>/testCases/<TestCase ID>`.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\TestCase::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The agent to delete test cases from.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. The agent to delete test cases from.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setParent($var)
    {
        GPBUtil::checkString($var, True);
        $this->parent = $var;

        return $this;
    }

    /**
     * Required. Format of test case names: `projects/<Project ID>/locations/
     * <Location ID>/agents/<AgentID>/testCases/<TestCase ID>`.
     *
     * Generated from protobuf field <code>repeated string names = 3 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getNames()
    {
        return $this->names;
    }

    /**
     * Required. Format of test case names: `projects/<Project ID>/locations/
     * <Location ID>/agents/<AgentID>/testCases/<TestCase ID>`.
     *
     * Generated from protobuf field <code>repeated string names = 3 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @param string[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setNames($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::STRING);
        $this->names = $arr;

        return $this;
    }

}

