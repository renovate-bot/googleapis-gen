<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/agent.proto

namespace Google\Cloud\Dialogflow\Cx\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Agents are best described as Natural Language Understanding (NLU) modules
 * that transform user requests into actionable data. You can include agents
 * in your app, product, or service to determine user intent and respond to the
 * user in a natural way.
 * After you create an agent, you can add [Intents][google.cloud.dialogflow.cx.v3.Intent],
 * [Entity Types][google.cloud.dialogflow.cx.v3.EntityType], [Flows][google.cloud.dialogflow.cx.v3.Flow], [Fulfillments][google.cloud.dialogflow.cx.v3.Fulfillment],
 * [Webhooks][google.cloud.dialogflow.cx.v3.Webhook], and so on to manage the conversation flows..
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3.Agent</code>
 */
class Agent extends \Google\Protobuf\Internal\Message
{
    /**
     * The unique identifier of the agent.
     * Required for the [Agents.UpdateAgent][google.cloud.dialogflow.cx.v3.Agents.UpdateAgent] method. [Agents.CreateAgent][google.cloud.dialogflow.cx.v3.Agents.CreateAgent]
     * populates the name automatically.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     */
    protected $name = '';
    /**
     * Required. The human-readable name of the agent, unique within the location.
     *
     * Generated from protobuf field <code>string display_name = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $display_name = '';
    /**
     * Immutable. The default language of the agent as a language tag.
     * See [Language
     * Support](https://cloud.google.com/dialogflow/cx/docs/reference/language)
     * for a list of the currently supported language codes.
     * This field cannot be set by the [Agents.UpdateAgent][google.cloud.dialogflow.cx.v3.Agents.UpdateAgent] method.
     *
     * Generated from protobuf field <code>string default_language_code = 3 [(.google.api.field_behavior) = IMMUTABLE];</code>
     */
    protected $default_language_code = '';
    /**
     * Required. The time zone of the agent from the [time zone
     * database](https://www.iana.org/time-zones), e.g., America/New_York,
     * Europe/Paris.
     *
     * Generated from protobuf field <code>string time_zone = 5 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $time_zone = '';
    /**
     * The description of the agent. The maximum length is 500 characters. If
     * exceeded, the request is rejected.
     *
     * Generated from protobuf field <code>string description = 6;</code>
     */
    protected $description = '';
    /**
     * The URI of the agent's avatar. Avatars are used throughout the Dialogflow
     * console and in the self-hosted [Web
     * Demo](https://cloud.google.com/dialogflow/docs/integrations/web-demo)
     * integration.
     *
     * Generated from protobuf field <code>string avatar_uri = 7;</code>
     */
    protected $avatar_uri = '';
    /**
     * Speech recognition related settings.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.SpeechToTextSettings speech_to_text_settings = 13;</code>
     */
    protected $speech_to_text_settings = null;
    /**
     * Immutable. Name of the start flow in this agent. A start flow will be automatically
     * created when the agent is created, and can only be deleted by deleting the
     * agent.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/flows/<Flow ID>`.
     *
     * Generated from protobuf field <code>string start_flow = 16 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     */
    protected $start_flow = '';
    /**
     * Name of the [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings] reference for the agent.
     * Format: `projects/<Project ID>/locations/<Location
     * ID>/securitySettings/<Security Settings ID>`.
     *
     * Generated from protobuf field <code>string security_settings = 17 [(.google.api.resource_reference) = {</code>
     */
    protected $security_settings = '';
    /**
     * Indicates if stackdriver logging is enabled for the agent.
     *
     * Generated from protobuf field <code>bool enable_stackdriver_logging = 18;</code>
     */
    protected $enable_stackdriver_logging = false;
    /**
     * Indicates if automatic spell correction is enabled in detect intent
     * requests.
     *
     * Generated from protobuf field <code>bool enable_spell_correction = 20;</code>
     */
    protected $enable_spell_correction = false;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           The unique identifier of the agent.
     *           Required for the [Agents.UpdateAgent][google.cloud.dialogflow.cx.v3.Agents.UpdateAgent] method. [Agents.CreateAgent][google.cloud.dialogflow.cx.v3.Agents.CreateAgent]
     *           populates the name automatically.
     *           Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
     *     @type string $display_name
     *           Required. The human-readable name of the agent, unique within the location.
     *     @type string $default_language_code
     *           Immutable. The default language of the agent as a language tag.
     *           See [Language
     *           Support](https://cloud.google.com/dialogflow/cx/docs/reference/language)
     *           for a list of the currently supported language codes.
     *           This field cannot be set by the [Agents.UpdateAgent][google.cloud.dialogflow.cx.v3.Agents.UpdateAgent] method.
     *     @type string $time_zone
     *           Required. The time zone of the agent from the [time zone
     *           database](https://www.iana.org/time-zones), e.g., America/New_York,
     *           Europe/Paris.
     *     @type string $description
     *           The description of the agent. The maximum length is 500 characters. If
     *           exceeded, the request is rejected.
     *     @type string $avatar_uri
     *           The URI of the agent's avatar. Avatars are used throughout the Dialogflow
     *           console and in the self-hosted [Web
     *           Demo](https://cloud.google.com/dialogflow/docs/integrations/web-demo)
     *           integration.
     *     @type \Google\Cloud\Dialogflow\Cx\V3\SpeechToTextSettings $speech_to_text_settings
     *           Speech recognition related settings.
     *     @type string $start_flow
     *           Immutable. Name of the start flow in this agent. A start flow will be automatically
     *           created when the agent is created, and can only be deleted by deleting the
     *           agent.
     *           Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *           ID>/flows/<Flow ID>`.
     *     @type string $security_settings
     *           Name of the [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings] reference for the agent.
     *           Format: `projects/<Project ID>/locations/<Location
     *           ID>/securitySettings/<Security Settings ID>`.
     *     @type bool $enable_stackdriver_logging
     *           Indicates if stackdriver logging is enabled for the agent.
     *     @type bool $enable_spell_correction
     *           Indicates if automatic spell correction is enabled in detect intent
     *           requests.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\Agent::initOnce();
        parent::__construct($data);
    }

    /**
     * The unique identifier of the agent.
     * Required for the [Agents.UpdateAgent][google.cloud.dialogflow.cx.v3.Agents.UpdateAgent] method. [Agents.CreateAgent][google.cloud.dialogflow.cx.v3.Agents.CreateAgent]
     * populates the name automatically.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * The unique identifier of the agent.
     * Required for the [Agents.UpdateAgent][google.cloud.dialogflow.cx.v3.Agents.UpdateAgent] method. [Agents.CreateAgent][google.cloud.dialogflow.cx.v3.Agents.CreateAgent]
     * populates the name automatically.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
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
     * Required. The human-readable name of the agent, unique within the location.
     *
     * Generated from protobuf field <code>string display_name = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getDisplayName()
    {
        return $this->display_name;
    }

    /**
     * Required. The human-readable name of the agent, unique within the location.
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
     * Immutable. The default language of the agent as a language tag.
     * See [Language
     * Support](https://cloud.google.com/dialogflow/cx/docs/reference/language)
     * for a list of the currently supported language codes.
     * This field cannot be set by the [Agents.UpdateAgent][google.cloud.dialogflow.cx.v3.Agents.UpdateAgent] method.
     *
     * Generated from protobuf field <code>string default_language_code = 3 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return string
     */
    public function getDefaultLanguageCode()
    {
        return $this->default_language_code;
    }

    /**
     * Immutable. The default language of the agent as a language tag.
     * See [Language
     * Support](https://cloud.google.com/dialogflow/cx/docs/reference/language)
     * for a list of the currently supported language codes.
     * This field cannot be set by the [Agents.UpdateAgent][google.cloud.dialogflow.cx.v3.Agents.UpdateAgent] method.
     *
     * Generated from protobuf field <code>string default_language_code = 3 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param string $var
     * @return $this
     */
    public function setDefaultLanguageCode($var)
    {
        GPBUtil::checkString($var, True);
        $this->default_language_code = $var;

        return $this;
    }

    /**
     * Required. The time zone of the agent from the [time zone
     * database](https://www.iana.org/time-zones), e.g., America/New_York,
     * Europe/Paris.
     *
     * Generated from protobuf field <code>string time_zone = 5 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getTimeZone()
    {
        return $this->time_zone;
    }

    /**
     * Required. The time zone of the agent from the [time zone
     * database](https://www.iana.org/time-zones), e.g., America/New_York,
     * Europe/Paris.
     *
     * Generated from protobuf field <code>string time_zone = 5 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setTimeZone($var)
    {
        GPBUtil::checkString($var, True);
        $this->time_zone = $var;

        return $this;
    }

    /**
     * The description of the agent. The maximum length is 500 characters. If
     * exceeded, the request is rejected.
     *
     * Generated from protobuf field <code>string description = 6;</code>
     * @return string
     */
    public function getDescription()
    {
        return $this->description;
    }

    /**
     * The description of the agent. The maximum length is 500 characters. If
     * exceeded, the request is rejected.
     *
     * Generated from protobuf field <code>string description = 6;</code>
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
     * The URI of the agent's avatar. Avatars are used throughout the Dialogflow
     * console and in the self-hosted [Web
     * Demo](https://cloud.google.com/dialogflow/docs/integrations/web-demo)
     * integration.
     *
     * Generated from protobuf field <code>string avatar_uri = 7;</code>
     * @return string
     */
    public function getAvatarUri()
    {
        return $this->avatar_uri;
    }

    /**
     * The URI of the agent's avatar. Avatars are used throughout the Dialogflow
     * console and in the self-hosted [Web
     * Demo](https://cloud.google.com/dialogflow/docs/integrations/web-demo)
     * integration.
     *
     * Generated from protobuf field <code>string avatar_uri = 7;</code>
     * @param string $var
     * @return $this
     */
    public function setAvatarUri($var)
    {
        GPBUtil::checkString($var, True);
        $this->avatar_uri = $var;

        return $this;
    }

    /**
     * Speech recognition related settings.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.SpeechToTextSettings speech_to_text_settings = 13;</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3\SpeechToTextSettings|null
     */
    public function getSpeechToTextSettings()
    {
        return isset($this->speech_to_text_settings) ? $this->speech_to_text_settings : null;
    }

    public function hasSpeechToTextSettings()
    {
        return isset($this->speech_to_text_settings);
    }

    public function clearSpeechToTextSettings()
    {
        unset($this->speech_to_text_settings);
    }

    /**
     * Speech recognition related settings.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.SpeechToTextSettings speech_to_text_settings = 13;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3\SpeechToTextSettings $var
     * @return $this
     */
    public function setSpeechToTextSettings($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3\SpeechToTextSettings::class);
        $this->speech_to_text_settings = $var;

        return $this;
    }

    /**
     * Immutable. Name of the start flow in this agent. A start flow will be automatically
     * created when the agent is created, and can only be deleted by deleting the
     * agent.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/flows/<Flow ID>`.
     *
     * Generated from protobuf field <code>string start_flow = 16 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getStartFlow()
    {
        return $this->start_flow;
    }

    /**
     * Immutable. Name of the start flow in this agent. A start flow will be automatically
     * created when the agent is created, and can only be deleted by deleting the
     * agent.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/flows/<Flow ID>`.
     *
     * Generated from protobuf field <code>string start_flow = 16 [(.google.api.field_behavior) = IMMUTABLE, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setStartFlow($var)
    {
        GPBUtil::checkString($var, True);
        $this->start_flow = $var;

        return $this;
    }

    /**
     * Name of the [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings] reference for the agent.
     * Format: `projects/<Project ID>/locations/<Location
     * ID>/securitySettings/<Security Settings ID>`.
     *
     * Generated from protobuf field <code>string security_settings = 17 [(.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getSecuritySettings()
    {
        return $this->security_settings;
    }

    /**
     * Name of the [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings] reference for the agent.
     * Format: `projects/<Project ID>/locations/<Location
     * ID>/securitySettings/<Security Settings ID>`.
     *
     * Generated from protobuf field <code>string security_settings = 17 [(.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setSecuritySettings($var)
    {
        GPBUtil::checkString($var, True);
        $this->security_settings = $var;

        return $this;
    }

    /**
     * Indicates if stackdriver logging is enabled for the agent.
     *
     * Generated from protobuf field <code>bool enable_stackdriver_logging = 18;</code>
     * @return bool
     */
    public function getEnableStackdriverLogging()
    {
        return $this->enable_stackdriver_logging;
    }

    /**
     * Indicates if stackdriver logging is enabled for the agent.
     *
     * Generated from protobuf field <code>bool enable_stackdriver_logging = 18;</code>
     * @param bool $var
     * @return $this
     */
    public function setEnableStackdriverLogging($var)
    {
        GPBUtil::checkBool($var);
        $this->enable_stackdriver_logging = $var;

        return $this;
    }

    /**
     * Indicates if automatic spell correction is enabled in detect intent
     * requests.
     *
     * Generated from protobuf field <code>bool enable_spell_correction = 20;</code>
     * @return bool
     */
    public function getEnableSpellCorrection()
    {
        return $this->enable_spell_correction;
    }

    /**
     * Indicates if automatic spell correction is enabled in detect intent
     * requests.
     *
     * Generated from protobuf field <code>bool enable_spell_correction = 20;</code>
     * @param bool $var
     * @return $this
     */
    public function setEnableSpellCorrection($var)
    {
        GPBUtil::checkBool($var);
        $this->enable_spell_correction = $var;

        return $this;
    }

}

