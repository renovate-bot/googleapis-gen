<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3beta1/test_case.proto

namespace Google\Cloud\Dialogflow\Cx\V3beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The request message for [TestCases.GetTestCase][google.cloud.dialogflow.cx.v3beta1.TestCases.GetTestCase].
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3beta1.GetTestCaseRequest</code>
 */
class GetTestCaseRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The name of the testcase.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/testCases/<TestCase ID>`.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $name = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Required. The name of the testcase.
     *           Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *           ID>/testCases/<TestCase ID>`.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3Beta1\TestCase::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The name of the testcase.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/testCases/<TestCase ID>`.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Required. The name of the testcase.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/testCases/<TestCase ID>`.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setName($var)
    {
        GPBUtil::checkString($var, True);
        $this->name = $var;

        return $this;
    }

}

