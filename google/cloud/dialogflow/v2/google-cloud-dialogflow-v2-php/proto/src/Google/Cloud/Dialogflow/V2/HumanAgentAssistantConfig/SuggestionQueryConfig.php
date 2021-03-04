<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/v2/conversation_profile.proto

namespace Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Config for suggestion query.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.v2.HumanAgentAssistantConfig.SuggestionQueryConfig</code>
 */
class SuggestionQueryConfig extends \Google\Protobuf\Internal\Message
{
    /**
     * Maximum number of results to return. Currently, if unset, defaults to 10.
     * And the max number is 20.
     *
     * Generated from protobuf field <code>int32 max_results = 4;</code>
     */
    protected $max_results = 0;
    /**
     * Confidence threshold of query result.
     * Agent Assist gives each suggestion a score in the range [0.0, 1.0], based
     * on the relevance between the suggestion and the current conversation
     * context. A score of 0.0 has no relevance, while a score of 1.0 has high
     * relevance. Only suggestions with a score greater than or equal to the
     * value of this field are included in the results.
     * For a baseline model (the default), the recommended value is in the range
     * [0.05, 0.1].
     * For a custom model, there is no recommended value. Tune this value by
     * starting from a very low value and slowly increasing until you have
     * desired results.
     * If this field is not set, it defaults to 0.0, which means that all
     * suggestions are returned.
     * Supported features: ARTICLE_SUGGESTION.
     *
     * Generated from protobuf field <code>float confidence_threshold = 5;</code>
     */
    protected $confidence_threshold = 0.0;
    /**
     * Determines how recent conversation context is filtered when generating
     * suggestions. If unspecified, no messages will be dropped.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.HumanAgentAssistantConfig.SuggestionQueryConfig.ContextFilterSettings context_filter_settings = 7;</code>
     */
    protected $context_filter_settings = null;
    protected $query_source;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\SuggestionQueryConfig\KnowledgeBaseQuerySource $knowledge_base_query_source
     *           Query from knowledgebase. It is used by:
     *           ARTICLE_SUGGESTION, FAQ.
     *     @type \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\SuggestionQueryConfig\DocumentQuerySource $document_query_source
     *           Query from knowledge base document. It is used by:
     *           SMART_REPLY, SMART_COMPOSE.
     *     @type \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\SuggestionQueryConfig\DialogflowQuerySource $dialogflow_query_source
     *           Query from Dialogflow agent. It is used by DIALOGFLOW_ASSIST.
     *     @type int $max_results
     *           Maximum number of results to return. Currently, if unset, defaults to 10.
     *           And the max number is 20.
     *     @type float $confidence_threshold
     *           Confidence threshold of query result.
     *           Agent Assist gives each suggestion a score in the range [0.0, 1.0], based
     *           on the relevance between the suggestion and the current conversation
     *           context. A score of 0.0 has no relevance, while a score of 1.0 has high
     *           relevance. Only suggestions with a score greater than or equal to the
     *           value of this field are included in the results.
     *           For a baseline model (the default), the recommended value is in the range
     *           [0.05, 0.1].
     *           For a custom model, there is no recommended value. Tune this value by
     *           starting from a very low value and slowly increasing until you have
     *           desired results.
     *           If this field is not set, it defaults to 0.0, which means that all
     *           suggestions are returned.
     *           Supported features: ARTICLE_SUGGESTION.
     *     @type \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\SuggestionQueryConfig\ContextFilterSettings $context_filter_settings
     *           Determines how recent conversation context is filtered when generating
     *           suggestions. If unspecified, no messages will be dropped.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\V2\ConversationProfile::initOnce();
        parent::__construct($data);
    }

    /**
     * Query from knowledgebase. It is used by:
     * ARTICLE_SUGGESTION, FAQ.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.HumanAgentAssistantConfig.SuggestionQueryConfig.KnowledgeBaseQuerySource knowledge_base_query_source = 1;</code>
     * @return \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\SuggestionQueryConfig\KnowledgeBaseQuerySource|null
     */
    public function getKnowledgeBaseQuerySource()
    {
        return $this->readOneof(1);
    }

    public function hasKnowledgeBaseQuerySource()
    {
        return $this->hasOneof(1);
    }

    /**
     * Query from knowledgebase. It is used by:
     * ARTICLE_SUGGESTION, FAQ.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.HumanAgentAssistantConfig.SuggestionQueryConfig.KnowledgeBaseQuerySource knowledge_base_query_source = 1;</code>
     * @param \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\SuggestionQueryConfig\KnowledgeBaseQuerySource $var
     * @return $this
     */
    public function setKnowledgeBaseQuerySource($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\SuggestionQueryConfig\KnowledgeBaseQuerySource::class);
        $this->writeOneof(1, $var);

        return $this;
    }

    /**
     * Query from knowledge base document. It is used by:
     * SMART_REPLY, SMART_COMPOSE.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.HumanAgentAssistantConfig.SuggestionQueryConfig.DocumentQuerySource document_query_source = 2;</code>
     * @return \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\SuggestionQueryConfig\DocumentQuerySource|null
     */
    public function getDocumentQuerySource()
    {
        return $this->readOneof(2);
    }

    public function hasDocumentQuerySource()
    {
        return $this->hasOneof(2);
    }

    /**
     * Query from knowledge base document. It is used by:
     * SMART_REPLY, SMART_COMPOSE.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.HumanAgentAssistantConfig.SuggestionQueryConfig.DocumentQuerySource document_query_source = 2;</code>
     * @param \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\SuggestionQueryConfig\DocumentQuerySource $var
     * @return $this
     */
    public function setDocumentQuerySource($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\SuggestionQueryConfig\DocumentQuerySource::class);
        $this->writeOneof(2, $var);

        return $this;
    }

    /**
     * Query from Dialogflow agent. It is used by DIALOGFLOW_ASSIST.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.HumanAgentAssistantConfig.SuggestionQueryConfig.DialogflowQuerySource dialogflow_query_source = 3;</code>
     * @return \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\SuggestionQueryConfig\DialogflowQuerySource|null
     */
    public function getDialogflowQuerySource()
    {
        return $this->readOneof(3);
    }

    public function hasDialogflowQuerySource()
    {
        return $this->hasOneof(3);
    }

    /**
     * Query from Dialogflow agent. It is used by DIALOGFLOW_ASSIST.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.HumanAgentAssistantConfig.SuggestionQueryConfig.DialogflowQuerySource dialogflow_query_source = 3;</code>
     * @param \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\SuggestionQueryConfig\DialogflowQuerySource $var
     * @return $this
     */
    public function setDialogflowQuerySource($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\SuggestionQueryConfig\DialogflowQuerySource::class);
        $this->writeOneof(3, $var);

        return $this;
    }

    /**
     * Maximum number of results to return. Currently, if unset, defaults to 10.
     * And the max number is 20.
     *
     * Generated from protobuf field <code>int32 max_results = 4;</code>
     * @return int
     */
    public function getMaxResults()
    {
        return $this->max_results;
    }

    /**
     * Maximum number of results to return. Currently, if unset, defaults to 10.
     * And the max number is 20.
     *
     * Generated from protobuf field <code>int32 max_results = 4;</code>
     * @param int $var
     * @return $this
     */
    public function setMaxResults($var)
    {
        GPBUtil::checkInt32($var);
        $this->max_results = $var;

        return $this;
    }

    /**
     * Confidence threshold of query result.
     * Agent Assist gives each suggestion a score in the range [0.0, 1.0], based
     * on the relevance between the suggestion and the current conversation
     * context. A score of 0.0 has no relevance, while a score of 1.0 has high
     * relevance. Only suggestions with a score greater than or equal to the
     * value of this field are included in the results.
     * For a baseline model (the default), the recommended value is in the range
     * [0.05, 0.1].
     * For a custom model, there is no recommended value. Tune this value by
     * starting from a very low value and slowly increasing until you have
     * desired results.
     * If this field is not set, it defaults to 0.0, which means that all
     * suggestions are returned.
     * Supported features: ARTICLE_SUGGESTION.
     *
     * Generated from protobuf field <code>float confidence_threshold = 5;</code>
     * @return float
     */
    public function getConfidenceThreshold()
    {
        return $this->confidence_threshold;
    }

    /**
     * Confidence threshold of query result.
     * Agent Assist gives each suggestion a score in the range [0.0, 1.0], based
     * on the relevance between the suggestion and the current conversation
     * context. A score of 0.0 has no relevance, while a score of 1.0 has high
     * relevance. Only suggestions with a score greater than or equal to the
     * value of this field are included in the results.
     * For a baseline model (the default), the recommended value is in the range
     * [0.05, 0.1].
     * For a custom model, there is no recommended value. Tune this value by
     * starting from a very low value and slowly increasing until you have
     * desired results.
     * If this field is not set, it defaults to 0.0, which means that all
     * suggestions are returned.
     * Supported features: ARTICLE_SUGGESTION.
     *
     * Generated from protobuf field <code>float confidence_threshold = 5;</code>
     * @param float $var
     * @return $this
     */
    public function setConfidenceThreshold($var)
    {
        GPBUtil::checkFloat($var);
        $this->confidence_threshold = $var;

        return $this;
    }

    /**
     * Determines how recent conversation context is filtered when generating
     * suggestions. If unspecified, no messages will be dropped.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.HumanAgentAssistantConfig.SuggestionQueryConfig.ContextFilterSettings context_filter_settings = 7;</code>
     * @return \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\SuggestionQueryConfig\ContextFilterSettings|null
     */
    public function getContextFilterSettings()
    {
        return isset($this->context_filter_settings) ? $this->context_filter_settings : null;
    }

    public function hasContextFilterSettings()
    {
        return isset($this->context_filter_settings);
    }

    public function clearContextFilterSettings()
    {
        unset($this->context_filter_settings);
    }

    /**
     * Determines how recent conversation context is filtered when generating
     * suggestions. If unspecified, no messages will be dropped.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.HumanAgentAssistantConfig.SuggestionQueryConfig.ContextFilterSettings context_filter_settings = 7;</code>
     * @param \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\SuggestionQueryConfig\ContextFilterSettings $var
     * @return $this
     */
    public function setContextFilterSettings($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig\SuggestionQueryConfig\ContextFilterSettings::class);
        $this->context_filter_settings = $var;

        return $this;
    }

    /**
     * @return string
     */
    public function getQuerySource()
    {
        return $this->whichOneof("query_source");
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(SuggestionQueryConfig::class, \Google\Cloud\Dialogflow\V2\HumanAgentAssistantConfig_SuggestionQueryConfig::class);

