<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3beta1/environment.proto

namespace Google\Cloud\Dialogflow\Cx\V3beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Represents an environment for an agent. You can create multiple versions
 * of your agent and publish them to separate environments. When you edit an
 * agent, you are editing the draft agent. At any point, you can save the draft
 * agent as an agent version, which is an immutable snapshot of your agent. When
 * you save the draft agent, it is published to the default environment. When
 * you create agent versions, you can publish them to custom environments. You
 * can create a variety of custom environments for testing, development,
 * production, etc.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3beta1.Environment</code>
 */
class Environment extends \Google\Protobuf\Internal\Message
{
    /**
     * The name of the environment.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/environments/<Environment ID>`.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     */
    protected $name = '';
    /**
     * Required. The human-readable name of the environment (unique in an agent). Limit of
     * 64 characters.
     *
     * Generated from protobuf field <code>string display_name = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $display_name = '';
    /**
     * The human-readable description of the environment. The maximum length is
     * 500 characters. If exceeded, the request is rejected.
     *
     * Generated from protobuf field <code>string description = 3;</code>
     */
    protected $description = '';
    /**
     * Required. A list of configurations for flow versions. You should include version
     * configs for all flows that are reachable from [`Start
     * Flow`][Agent.start_flow] in the agent. Otherwise, an error will be
     * returned.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3beta1.Environment.VersionConfig version_configs = 6 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    private $version_configs;
    /**
     * Output only. Update time of this environment.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp update_time = 5 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    protected $update_time = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           The name of the environment.
     *           Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *           ID>/environments/<Environment ID>`.
     *     @type string $display_name
     *           Required. The human-readable name of the environment (unique in an agent). Limit of
     *           64 characters.
     *     @type string $description
     *           The human-readable description of the environment. The maximum length is
     *           500 characters. If exceeded, the request is rejected.
     *     @type \Google\Cloud\Dialogflow\Cx\V3beta1\Environment\VersionConfig[]|\Google\Protobuf\Internal\RepeatedField $version_configs
     *           Required. A list of configurations for flow versions. You should include version
     *           configs for all flows that are reachable from [`Start
     *           Flow`][Agent.start_flow] in the agent. Otherwise, an error will be
     *           returned.
     *     @type \Google\Protobuf\Timestamp $update_time
     *           Output only. Update time of this environment.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3Beta1\Environment::initOnce();
        parent::__construct($data);
    }

    /**
     * The name of the environment.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/environments/<Environment ID>`.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * The name of the environment.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/environments/<Environment ID>`.
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
     * Required. The human-readable name of the environment (unique in an agent). Limit of
     * 64 characters.
     *
     * Generated from protobuf field <code>string display_name = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getDisplayName()
    {
        return $this->display_name;
    }

    /**
     * Required. The human-readable name of the environment (unique in an agent). Limit of
     * 64 characters.
     *
     * Generated from protobuf field <code>string display_name = 2 [(.google.api.field_behavior) = REQUIRED];</code>
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
     * The human-readable description of the environment. The maximum length is
     * 500 characters. If exceeded, the request is rejected.
     *
     * Generated from protobuf field <code>string description = 3;</code>
     * @return string
     */
    public function getDescription()
    {
        return $this->description;
    }

    /**
     * The human-readable description of the environment. The maximum length is
     * 500 characters. If exceeded, the request is rejected.
     *
     * Generated from protobuf field <code>string description = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setDescription($var)
    {
        GPBUtil::checkString($var, True);
        $this->description = $var;

        return $this;
    }

    /**
     * Required. A list of configurations for flow versions. You should include version
     * configs for all flows that are reachable from [`Start
     * Flow`][Agent.start_flow] in the agent. Otherwise, an error will be
     * returned.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3beta1.Environment.VersionConfig version_configs = 6 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getVersionConfigs()
    {
        return $this->version_configs;
    }

    /**
     * Required. A list of configurations for flow versions. You should include version
     * configs for all flows that are reachable from [`Start
     * Flow`][Agent.start_flow] in the agent. Otherwise, an error will be
     * returned.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3beta1.Environment.VersionConfig version_configs = 6 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3beta1\Environment\VersionConfig[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setVersionConfigs($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Dialogflow\Cx\V3beta1\Environment\VersionConfig::class);
        $this->version_configs = $arr;

        return $this;
    }

    /**
     * Output only. Update time of this environment.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp update_time = 5 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getUpdateTime()
    {
        return isset($this->update_time) ? $this->update_time : null;
    }

    public function hasUpdateTime()
    {
        return isset($this->update_time);
    }

    public function clearUpdateTime()
    {
        unset($this->update_time);
    }

    /**
     * Output only. Update time of this environment.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp update_time = 5 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setUpdateTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->update_time = $var;

        return $this;
    }

}

