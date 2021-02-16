<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/test_case.proto

namespace Google\Cloud\Dialogflow\Cx\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The request message for [TestCases.BatchRunTestCases][google.cloud.dialogflow.cx.v3.TestCases.BatchRunTestCases].
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3.BatchRunTestCasesRequest</code>
 */
class BatchRunTestCasesRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. Agent name. Format: `projects/<Project ID>/locations/<Location ID>/agents/
     * <AgentID>`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * Optional. If not set, draft environment is assumed. Format: `projects/<Project
     * ID>/locations/<Location ID>/agents/<Agent ID>/environments/<Environment
     * ID>`.
     *
     * Generated from protobuf field <code>string environment = 2 [(.google.api.field_behavior) = OPTIONAL, (.google.api.resource_reference) = {</code>
     */
    protected $environment = '';
    /**
     * Required. Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/testCases/<TestCase ID>`.
     *
     * Generated from protobuf field <code>repeated string test_cases = 3 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    private $test_cases;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. Agent name. Format: `projects/<Project ID>/locations/<Location ID>/agents/
     *           <AgentID>`.
     *     @type string $environment
     *           Optional. If not set, draft environment is assumed. Format: `projects/<Project
     *           ID>/locations/<Location ID>/agents/<Agent ID>/environments/<Environment
     *           ID>`.
     *     @type string[]|\Google\Protobuf\Internal\RepeatedField $test_cases
     *           Required. Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *           ID>/testCases/<TestCase ID>`.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\TestCase::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. Agent name. Format: `projects/<Project ID>/locations/<Location ID>/agents/
     * <AgentID>`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. Agent name. Format: `projects/<Project ID>/locations/<Location ID>/agents/
     * <AgentID>`.
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
     * Optional. If not set, draft environment is assumed. Format: `projects/<Project
     * ID>/locations/<Location ID>/agents/<Agent ID>/environments/<Environment
     * ID>`.
     *
     * Generated from protobuf field <code>string environment = 2 [(.google.api.field_behavior) = OPTIONAL, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getEnvironment()
    {
        return $this->environment;
    }

    /**
     * Optional. If not set, draft environment is assumed. Format: `projects/<Project
     * ID>/locations/<Location ID>/agents/<Agent ID>/environments/<Environment
     * ID>`.
     *
     * Generated from protobuf field <code>string environment = 2 [(.google.api.field_behavior) = OPTIONAL, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setEnvironment($var)
    {
        GPBUtil::checkString($var, True);
        $this->environment = $var;

        return $this;
    }

    /**
     * Required. Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/testCases/<TestCase ID>`.
     *
     * Generated from protobuf field <code>repeated string test_cases = 3 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getTestCases()
    {
        return $this->test_cases;
    }

    /**
     * Required. Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/testCases/<TestCase ID>`.
     *
     * Generated from protobuf field <code>repeated string test_cases = 3 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @param string[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setTestCases($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::STRING);
        $this->test_cases = $arr;

        return $this;
    }

}

