<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/v2/conversation_profile.proto

namespace Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Config for suggestion features.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.v2.HumanAgentAssistantConfig.SuggestionFeatureConfig</code>
 */
class SuggestionFeatureConfig extends \Google\Protobuf\Internal\Message
{
    /**
     * The suggestion feature.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.SuggestionFeature suggestion_feature = 5;</code>
     */
    protected $suggestion_feature = null;
    /**
     * Automatically iterates all participants and tries to compile
     * suggestions.
     * Supported features: ARTICLE_SUGGESTION, FAQ, DIALOGFLOW_ASSIST.
     *
     * Generated from protobuf field <code>bool enable_event_based_suggestion = 3;</code>
     */
    protected $enable_event_based_suggestion = false;
    /**
     * Settings of suggestion trigger.
     * Currently, only ARTICLE_SUGGESTION and FAQ will use this field.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.HumanAgentAssistantConfig.SuggestionTriggerSettings suggestion_trigger_settings = 10;</code>
     */
    protected $suggestion_trigger_settings = null;
    /**
     * Configs of query.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.HumanAgentAssistantConfig.SuggestionQueryConfig query_config = 6;</code>
     */
    protected $query_config = null;
    /**
     * Configs of custom conversation model.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.HumanAgentAssistantConfig.ConversationModelConfig conversation_model_config = 7;</code>
     */
    protected $conversation_model_config = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Dialogflow\V2\SuggestionFeature $suggestion_feature
     *           The suggestion feature.
     *     @type bool $enable_event_based_suggestion
     *           Automatically iterates all participants and tries to compile
     *           suggestions.
     *           Supported features: ARTICLE_SUGGESTION, FAQ, DIALOGFLOW_ASSIST.
     *     @type \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\SuggestionTriggerSettings $suggestion_trigger_settings
     *           Settings of suggestion trigger.
     *           Currently, only ARTICLE_SUGGESTION and FAQ will use this field.
     *     @type \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\SuggestionQueryConfig $query_config
     *           Configs of query.
     *     @type \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\ConversationModelConfig $conversation_model_config
     *           Configs of custom conversation model.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\V2\ConversationProfile::initOnce();
        parent::__construct($data);
    }

    /**
     * The suggestion feature.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.SuggestionFeature suggestion_feature = 5;</code>
     * @return \Google\Cloud\Dialogflow\V2\SuggestionFeature|null
     */
    public function getSuggestionFeature()
    {
        return $this->suggestion_feature;
    }

    public function hasSuggestionFeature()
    {
        return isset($this->suggestion_feature);
    }

    public function clearSuggestionFeature()
    {
        unset($this->suggestion_feature);
    }

    /**
     * The suggestion feature.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.SuggestionFeature suggestion_feature = 5;</code>
     * @param \Google\Cloud\Dialogflow\V2\SuggestionFeature $var
     * @return $this
     */
    public function setSuggestionFeature($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\V2\SuggestionFeature::class);
        $this->suggestion_feature = $var;

        return $this;
    }

    /**
     * Automatically iterates all participants and tries to compile
     * suggestions.
     * Supported features: ARTICLE_SUGGESTION, FAQ, DIALOGFLOW_ASSIST.
     *
     * Generated from protobuf field <code>bool enable_event_based_suggestion = 3;</code>
     * @return bool
     */
    public function getEnableEventBasedSuggestion()
    {
        return $this->enable_event_based_suggestion;
    }

    /**
     * Automatically iterates all participants and tries to compile
     * suggestions.
     * Supported features: ARTICLE_SUGGESTION, FAQ, DIALOGFLOW_ASSIST.
     *
     * Generated from protobuf field <code>bool enable_event_based_suggestion = 3;</code>
     * @param bool $var
     * @return $this
     */
    public function setEnableEventBasedSuggestion($var)
    {
        GPBUtil::checkBool($var);
        $this->enable_event_based_suggestion = $var;

        return $this;
    }

    /**
     * Settings of suggestion trigger.
     * Currently, only ARTICLE_SUGGESTION and FAQ will use this field.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.HumanAgentAssistantConfig.SuggestionTriggerSettings suggestion_trigger_settings = 10;</code>
     * @return \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\SuggestionTriggerSettings|null
     */
    public function getSuggestionTriggerSettings()
    {
        return $this->suggestion_trigger_settings;
    }

    public function hasSuggestionTriggerSettings()
    {
        return isset($this->suggestion_trigger_settings);
    }

    public function clearSuggestionTriggerSettings()
    {
        unset($this->suggestion_trigger_settings);
    }

    /**
     * Settings of suggestion trigger.
     * Currently, only ARTICLE_SUGGESTION and FAQ will use this field.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.HumanAgentAssistantConfig.SuggestionTriggerSettings suggestion_trigger_settings = 10;</code>
     * @param \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\SuggestionTriggerSettings $var
     * @return $this
     */
    public function setSuggestionTriggerSettings($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\SuggestionTriggerSettings::class);
        $this->suggestion_trigger_settings = $var;

        return $this;
    }

    /**
     * Configs of query.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.HumanAgentAssistantConfig.SuggestionQueryConfig query_config = 6;</code>
     * @return \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\SuggestionQueryConfig|null
     */
    public function getQueryConfig()
    {
        return $this->query_config;
    }

    public function hasQueryConfig()
    {
        return isset($this->query_config);
    }

    public function clearQueryConfig()
    {
        unset($this->query_config);
    }

    /**
     * Configs of query.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.HumanAgentAssistantConfig.SuggestionQueryConfig query_config = 6;</code>
     * @param \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\SuggestionQueryConfig $var
     * @return $this
     */
    public function setQueryConfig($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\SuggestionQueryConfig::class);
        $this->query_config = $var;

        return $this;
    }

    /**
     * Configs of custom conversation model.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.HumanAgentAssistantConfig.ConversationModelConfig conversation_model_config = 7;</code>
     * @return \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\ConversationModelConfig|null
     */
    public function getConversationModelConfig()
    {
        return $this->conversation_model_config;
    }

    public function hasConversationModelConfig()
    {
        return isset($this->conversation_model_config);
    }

    public function clearConversationModelConfig()
    {
        unset($this->conversation_model_config);
    }

    /**
     * Configs of custom conversation model.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.HumanAgentAssistantConfig.ConversationModelConfig conversation_model_config = 7;</code>
     * @param \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\ConversationModelConfig $var
     * @return $this
     */
    public function setConversationModelConfig($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\ConversationModelConfig::class);
        $this->conversation_model_config = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(SuggestionFeatureConfig::class, \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig_SuggestionFeatureConfig::class);

