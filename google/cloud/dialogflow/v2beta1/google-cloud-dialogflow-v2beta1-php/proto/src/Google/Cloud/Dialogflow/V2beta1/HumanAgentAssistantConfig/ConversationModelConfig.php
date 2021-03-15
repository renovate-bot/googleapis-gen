<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/v2beta1/conversation_profile.proto

namespace Google\Cloud\Dialogflow\V2beta1\HumanAgentAssistantConfig;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Custom conversation models used in agent assist feature.
 * Supported feature: ARTICLE_SUGGESTION, SMART_COMPOSE, SMART_REPLY.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.v2beta1.HumanAgentAssistantConfig.ConversationModelConfig</code>
 */
class ConversationModelConfig extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. Conversation model resource name. Format: `projects/<Project
     * ID>/conversationModels/<Model ID>`.
     *
     * Generated from protobuf field <code>string model = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $model = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $model
     *           Required. Conversation model resource name. Format: `projects/<Project
     *           ID>/conversationModels/<Model ID>`.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\V2Beta1\ConversationProfile::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. Conversation model resource name. Format: `projects/<Project
     * ID>/conversationModels/<Model ID>`.
     *
     * Generated from protobuf field <code>string model = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getModel()
    {
        return $this->model;
    }

    /**
     * Required. Conversation model resource name. Format: `projects/<Project
     * ID>/conversationModels/<Model ID>`.
     *
     * Generated from protobuf field <code>string model = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setModel($var)
    {
        GPBUtil::checkString($var, True);
        $this->model = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(ConversationModelConfig::class, \Google\Cloud\Dialogflow\V2beta1\HumanAgentAssistantConfig_ConversationModelConfig::class);

