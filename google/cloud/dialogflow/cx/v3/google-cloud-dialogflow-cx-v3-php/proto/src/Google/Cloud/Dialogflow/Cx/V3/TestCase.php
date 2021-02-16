<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/test_case.proto

namespace Google\Cloud\Dialogflow\Cx\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Represents a test case.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3.TestCase</code>
 */
class TestCase extends \Google\Protobuf\Internal\Message
{
    /**
     * The unique identifier of the test case.
     * [TestCases.CreateTestCase][google.cloud.dialogflow.cx.v3.TestCases.CreateTestCase] will populate the name automatically.
     * Otherwise use format: `projects/<Project ID>/locations/<LocationID>/agents/
     * <AgentID>/testCases/<TestCase ID>`.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     */
    protected $name = '';
    /**
     * Tags are short descriptions that users may apply to test cases for
     * organizational and filtering purposes. Each tag should start with "#" and
     * has a limit of 30 characters.
     *
     * Generated from protobuf field <code>repeated string tags = 2;</code>
     */
    private $tags;
    /**
     * Required. The human-readable name of the test case, unique within the agent. Limit of
     * 200 characters.
     *
     * Generated from protobuf field <code>string display_name = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $display_name = '';
    /**
     * Additional freeform notes about the test case. Limit of 400 characters.
     *
     * Generated from protobuf field <code>string notes = 4;</code>
     */
    protected $notes = '';
    /**
     * Config for the test case.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.TestConfig test_config = 13;</code>
     */
    protected $test_config = null;
    /**
     * The conversation turns uttered when the test case was created, in
     * chronological order. These include the canonical set of agent utterances
     * that should occur when the agent is working properly.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3.ConversationTurn test_case_conversation_turns = 5;</code>
     */
    private $test_case_conversation_turns;
    /**
     * Output only. When the test was created.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp creation_time = 10 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $creation_time = null;
    /**
     * The latest test result.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.TestCaseResult last_test_result = 12;</code>
     */
    protected $last_test_result = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           The unique identifier of the test case.
     *           [TestCases.CreateTestCase][google.cloud.dialogflow.cx.v3.TestCases.CreateTestCase] will populate the name automatically.
     *           Otherwise use format: `projects/<Project ID>/locations/<LocationID>/agents/
     *           <AgentID>/testCases/<TestCase ID>`.
     *     @type string[]|\Google\Protobuf\Internal\RepeatedField $tags
     *           Tags are short descriptions that users may apply to test cases for
     *           organizational and filtering purposes. Each tag should start with "#" and
     *           has a limit of 30 characters.
     *     @type string $display_name
     *           Required. The human-readable name of the test case, unique within the agent. Limit of
     *           200 characters.
     *     @type string $notes
     *           Additional freeform notes about the test case. Limit of 400 characters.
     *     @type \Google\Cloud\Dialogflow\Cx\V3\TestConfig $test_config
     *           Config for the test case.
     *     @type \Google\Cloud\Dialogflow\Cx\V3\ConversationTurn[]|\Google\Protobuf\Internal\RepeatedField $test_case_conversation_turns
     *           The conversation turns uttered when the test case was created, in
     *           chronological order. These include the canonical set of agent utterances
     *           that should occur when the agent is working properly.
     *     @type \Google\Protobuf\Timestamp $creation_time
     *           Output only. When the test was created.
     *     @type \Google\Cloud\Dialogflow\Cx\V3\TestCaseResult $last_test_result
     *           The latest test result.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\TestCase::initOnce();
        parent::__construct($data);
    }

    /**
     * The unique identifier of the test case.
     * [TestCases.CreateTestCase][google.cloud.dialogflow.cx.v3.TestCases.CreateTestCase] will populate the name automatically.
     * Otherwise use format: `projects/<Project ID>/locations/<LocationID>/agents/
     * <AgentID>/testCases/<TestCase ID>`.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * The unique identifier of the test case.
     * [TestCases.CreateTestCase][google.cloud.dialogflow.cx.v3.TestCases.CreateTestCase] will populate the name automatically.
     * Otherwise use format: `projects/<Project ID>/locations/<LocationID>/agents/
     * <AgentID>/testCases/<TestCase ID>`.
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
     * Tags are short descriptions that users may apply to test cases for
     * organizational and filtering purposes. Each tag should start with "#" and
     * has a limit of 30 characters.
     *
     * Generated from protobuf field <code>repeated string tags = 2;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getTags()
    {
        return $this->tags;
    }

    /**
     * Tags are short descriptions that users may apply to test cases for
     * organizational and filtering purposes. Each tag should start with "#" and
     * has a limit of 30 characters.
     *
     * Generated from protobuf field <code>repeated string tags = 2;</code>
     * @param string[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setTags($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::STRING);
        $this->tags = $arr;

        return $this;
    }

    /**
     * Required. The human-readable name of the test case, unique within the agent. Limit of
     * 200 characters.
     *
     * Generated from protobuf field <code>string display_name = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getDisplayName()
    {
        return $this->display_name;
    }

    /**
     * Required. The human-readable name of the test case, unique within the agent. Limit of
     * 200 characters.
     *
     * Generated from protobuf field <code>string display_name = 3 [(.google.api.field_behavior) = REQUIRED];</code>
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
     * Additional freeform notes about the test case. Limit of 400 characters.
     *
     * Generated from protobuf field <code>string notes = 4;</code>
     * @return string
     */
    public function getNotes()
    {
        return $this->notes;
    }

    /**
     * Additional freeform notes about the test case. Limit of 400 characters.
     *
     * Generated from protobuf field <code>string notes = 4;</code>
     * @param string $var
     * @return $this
     */
    public function setNotes($var)
    {
        GPBUtil::checkString($var, True);
        $this->notes = $var;

        return $this;
    }

    /**
     * Config for the test case.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.TestConfig test_config = 13;</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3\TestConfig
     */
    public function getTestConfig()
    {
        return isset($this->test_config) ? $this->test_config : null;
    }

    public function hasTestConfig()
    {
        return isset($this->test_config);
    }

    public function clearTestConfig()
    {
        unset($this->test_config);
    }

    /**
     * Config for the test case.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.TestConfig test_config = 13;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3\TestConfig $var
     * @return $this
     */
    public function setTestConfig($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3\TestConfig::class);
        $this->test_config = $var;

        return $this;
    }

    /**
     * The conversation turns uttered when the test case was created, in
     * chronological order. These include the canonical set of agent utterances
     * that should occur when the agent is working properly.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3.ConversationTurn test_case_conversation_turns = 5;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getTestCaseConversationTurns()
    {
        return $this->test_case_conversation_turns;
    }

    /**
     * The conversation turns uttered when the test case was created, in
     * chronological order. These include the canonical set of agent utterances
     * that should occur when the agent is working properly.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3.ConversationTurn test_case_conversation_turns = 5;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3\ConversationTurn[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setTestCaseConversationTurns($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Dialogflow\Cx\V3\ConversationTurn::class);
        $this->test_case_conversation_turns = $arr;

        return $this;
    }

    /**
     * Output only. When the test was created.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp creation_time = 10 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\Timestamp
     */
    public function getCreationTime()
    {
        return isset($this->creation_time) ? $this->creation_time : null;
    }

    public function hasCreationTime()
    {
        return isset($this->creation_time);
    }

    public function clearCreationTime()
    {
        unset($this->creation_time);
    }

    /**
     * Output only. When the test was created.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp creation_time = 10 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setCreationTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->creation_time = $var;

        return $this;
    }

    /**
     * The latest test result.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.TestCaseResult last_test_result = 12;</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3\TestCaseResult
     */
    public function getLastTestResult()
    {
        return isset($this->last_test_result) ? $this->last_test_result : null;
    }

    public function hasLastTestResult()
    {
        return isset($this->last_test_result);
    }

    public function clearLastTestResult()
    {
        unset($this->last_test_result);
    }

    /**
     * The latest test result.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.TestCaseResult last_test_result = 12;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3\TestCaseResult $var
     * @return $this
     */
    public function setLastTestResult($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3\TestCaseResult::class);
        $this->last_test_result = $var;

        return $this;
    }

}

