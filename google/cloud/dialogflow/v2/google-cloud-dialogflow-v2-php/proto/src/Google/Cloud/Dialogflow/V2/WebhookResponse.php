<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/v2/webhook.proto

namespace Google\Cloud\Dialogflow\V2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The response message for a webhook call.
 * This response is validated by the Dialogflow server. If validation fails,
 * an error will be returned in the [QueryResult.diagnostic_info][google.cloud.dialogflow.v2.QueryResult.diagnostic_info] field.
 * Setting JSON fields to an empty value with the wrong type is a common error.
 * To avoid this error:
 * - Use `""` for empty strings
 * - Use `{}` or `null` for empty objects
 * - Use `[]` or `null` for empty arrays
 * For more information, see the
 * [Protocol Buffers Language
 * Guide](https://developers.google.com/protocol-buffers/docs/proto3#json).
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.v2.WebhookResponse</code>
 */
class WebhookResponse extends \Google\Protobuf\Internal\Message
{
    /**
     * Optional. The text response message intended for the end-user.
     * It is recommended to use `fulfillment_messages.text.text[0]` instead.
     * When provided, Dialogflow uses this field to populate
     * [QueryResult.fulfillment_text][google.cloud.dialogflow.v2.QueryResult.fulfillment_text] sent to the integration or API caller.
     *
     * Generated from protobuf field <code>string fulfillment_text = 1;</code>
     */
    protected $fulfillment_text = '';
    /**
     * Optional. The rich response messages intended for the end-user.
     * When provided, Dialogflow uses this field to populate
     * [QueryResult.fulfillment_messages][google.cloud.dialogflow.v2.QueryResult.fulfillment_messages] sent to the integration or API caller.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.v2.Intent.Message fulfillment_messages = 2;</code>
     */
    private $fulfillment_messages;
    /**
     * Optional. A custom field used to identify the webhook source.
     * Arbitrary strings are supported.
     * When provided, Dialogflow uses this field to populate
     * [QueryResult.webhook_source][google.cloud.dialogflow.v2.QueryResult.webhook_source] sent to the integration or API caller.
     *
     * Generated from protobuf field <code>string source = 3;</code>
     */
    protected $source = '';
    /**
     * Optional. This field can be used to pass custom data from your webhook to the
     * integration or API caller. Arbitrary JSON objects are supported.
     * When provided, Dialogflow uses this field to populate
     * [QueryResult.webhook_payload][google.cloud.dialogflow.v2.QueryResult.webhook_payload] sent to the integration or API caller.
     * This field is also used by the
     * [Google Assistant
     * integration](https://cloud.google.com/dialogflow/docs/integrations/aog)
     * for rich response messages.
     * See the format definition at [Google Assistant Dialogflow webhook
     * format](https://developers.google.com/assistant/actions/build/json/dialogflow-webhook-json)
     *
     * Generated from protobuf field <code>.google.protobuf.Struct payload = 4;</code>
     */
    protected $payload = null;
    /**
     * Optional. The collection of output contexts that will overwrite currently
     * active contexts for the session and reset their lifespans.
     * When provided, Dialogflow uses this field to populate
     * [QueryResult.output_contexts][google.cloud.dialogflow.v2.QueryResult.output_contexts] sent to the integration or API caller.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.v2.Context output_contexts = 5;</code>
     */
    private $output_contexts;
    /**
     * Optional. Invokes the supplied events.
     * When this field is set, Dialogflow ignores the `fulfillment_text`,
     * `fulfillment_messages`, and `payload` fields.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.EventInput followup_event_input = 6;</code>
     */
    protected $followup_event_input = null;
    /**
     * Optional. Additional session entity types to replace or extend developer
     * entity types with. The entity synonyms apply to all languages and persist
     * for the session. Setting this data from a webhook overwrites
     * the session entity types that have been set using `detectIntent`,
     * `streamingDetectIntent` or [SessionEntityType][google.cloud.dialogflow.v2.SessionEntityType] management methods.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.v2.SessionEntityType session_entity_types = 10;</code>
     */
    private $session_entity_types;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $fulfillment_text
     *           Optional. The text response message intended for the end-user.
     *           It is recommended to use `fulfillment_messages.text.text[0]` instead.
     *           When provided, Dialogflow uses this field to populate
     *           [QueryResult.fulfillment_text][google.cloud.dialogflow.v2.QueryResult.fulfillment_text] sent to the integration or API caller.
     *     @type \Google\Cloud\Dialogflow\V2\Intent\Message[]|\Google\Protobuf\Internal\RepeatedField $fulfillment_messages
     *           Optional. The rich response messages intended for the end-user.
     *           When provided, Dialogflow uses this field to populate
     *           [QueryResult.fulfillment_messages][google.cloud.dialogflow.v2.QueryResult.fulfillment_messages] sent to the integration or API caller.
     *     @type string $source
     *           Optional. A custom field used to identify the webhook source.
     *           Arbitrary strings are supported.
     *           When provided, Dialogflow uses this field to populate
     *           [QueryResult.webhook_source][google.cloud.dialogflow.v2.QueryResult.webhook_source] sent to the integration or API caller.
     *     @type \Google\Protobuf\Struct $payload
     *           Optional. This field can be used to pass custom data from your webhook to the
     *           integration or API caller. Arbitrary JSON objects are supported.
     *           When provided, Dialogflow uses this field to populate
     *           [QueryResult.webhook_payload][google.cloud.dialogflow.v2.QueryResult.webhook_payload] sent to the integration or API caller.
     *           This field is also used by the
     *           [Google Assistant
     *           integration](https://cloud.google.com/dialogflow/docs/integrations/aog)
     *           for rich response messages.
     *           See the format definition at [Google Assistant Dialogflow webhook
     *           format](https://developers.google.com/assistant/actions/build/json/dialogflow-webhook-json)
     *     @type \Google\Cloud\Dialogflow\V2\Context[]|\Google\Protobuf\Internal\RepeatedField $output_contexts
     *           Optional. The collection of output contexts that will overwrite currently
     *           active contexts for the session and reset their lifespans.
     *           When provided, Dialogflow uses this field to populate
     *           [QueryResult.output_contexts][google.cloud.dialogflow.v2.QueryResult.output_contexts] sent to the integration or API caller.
     *     @type \Google\Cloud\Dialogflow\V2\EventInput $followup_event_input
     *           Optional. Invokes the supplied events.
     *           When this field is set, Dialogflow ignores the `fulfillment_text`,
     *           `fulfillment_messages`, and `payload` fields.
     *     @type \Google\Cloud\Dialogflow\V2\SessionEntityType[]|\Google\Protobuf\Internal\RepeatedField $session_entity_types
     *           Optional. Additional session entity types to replace or extend developer
     *           entity types with. The entity synonyms apply to all languages and persist
     *           for the session. Setting this data from a webhook overwrites
     *           the session entity types that have been set using `detectIntent`,
     *           `streamingDetectIntent` or [SessionEntityType][google.cloud.dialogflow.v2.SessionEntityType] management methods.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\V2\Webhook::initOnce();
        parent::__construct($data);
    }

    /**
     * Optional. The text response message intended for the end-user.
     * It is recommended to use `fulfillment_messages.text.text[0]` instead.
     * When provided, Dialogflow uses this field to populate
     * [QueryResult.fulfillment_text][google.cloud.dialogflow.v2.QueryResult.fulfillment_text] sent to the integration or API caller.
     *
     * Generated from protobuf field <code>string fulfillment_text = 1;</code>
     * @return string
     */
    public function getFulfillmentText()
    {
        return $this->fulfillment_text;
    }

    /**
     * Optional. The text response message intended for the end-user.
     * It is recommended to use `fulfillment_messages.text.text[0]` instead.
     * When provided, Dialogflow uses this field to populate
     * [QueryResult.fulfillment_text][google.cloud.dialogflow.v2.QueryResult.fulfillment_text] sent to the integration or API caller.
     *
     * Generated from protobuf field <code>string fulfillment_text = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setFulfillmentText($var)
    {
        GPBUtil::checkString($var, True);
        $this->fulfillment_text = $var;

        return $this;
    }

    /**
     * Optional. The rich response messages intended for the end-user.
     * When provided, Dialogflow uses this field to populate
     * [QueryResult.fulfillment_messages][google.cloud.dialogflow.v2.QueryResult.fulfillment_messages] sent to the integration or API caller.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.v2.Intent.Message fulfillment_messages = 2;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getFulfillmentMessages()
    {
        return $this->fulfillment_messages;
    }

    /**
     * Optional. The rich response messages intended for the end-user.
     * When provided, Dialogflow uses this field to populate
     * [QueryResult.fulfillment_messages][google.cloud.dialogflow.v2.QueryResult.fulfillment_messages] sent to the integration or API caller.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.v2.Intent.Message fulfillment_messages = 2;</code>
     * @param \Google\Cloud\Dialogflow\V2\Intent\Message[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setFulfillmentMessages($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Dialogflow\V2\Intent\Message::class);
        $this->fulfillment_messages = $arr;

        return $this;
    }

    /**
     * Optional. A custom field used to identify the webhook source.
     * Arbitrary strings are supported.
     * When provided, Dialogflow uses this field to populate
     * [QueryResult.webhook_source][google.cloud.dialogflow.v2.QueryResult.webhook_source] sent to the integration or API caller.
     *
     * Generated from protobuf field <code>string source = 3;</code>
     * @return string
     */
    public function getSource()
    {
        return $this->source;
    }

    /**
     * Optional. A custom field used to identify the webhook source.
     * Arbitrary strings are supported.
     * When provided, Dialogflow uses this field to populate
     * [QueryResult.webhook_source][google.cloud.dialogflow.v2.QueryResult.webhook_source] sent to the integration or API caller.
     *
     * Generated from protobuf field <code>string source = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setSource($var)
    {
        GPBUtil::checkString($var, True);
        $this->source = $var;

        return $this;
    }

    /**
     * Optional. This field can be used to pass custom data from your webhook to the
     * integration or API caller. Arbitrary JSON objects are supported.
     * When provided, Dialogflow uses this field to populate
     * [QueryResult.webhook_payload][google.cloud.dialogflow.v2.QueryResult.webhook_payload] sent to the integration or API caller.
     * This field is also used by the
     * [Google Assistant
     * integration](https://cloud.google.com/dialogflow/docs/integrations/aog)
     * for rich response messages.
     * See the format definition at [Google Assistant Dialogflow webhook
     * format](https://developers.google.com/assistant/actions/build/json/dialogflow-webhook-json)
     *
     * Generated from protobuf field <code>.google.protobuf.Struct payload = 4;</code>
     * @return \Google\Protobuf\Struct|null
     */
    public function getPayload()
    {
        return isset($this->payload) ? $this->payload : null;
    }

    public function hasPayload()
    {
        return isset($this->payload);
    }

    public function clearPayload()
    {
        unset($this->payload);
    }

    /**
     * Optional. This field can be used to pass custom data from your webhook to the
     * integration or API caller. Arbitrary JSON objects are supported.
     * When provided, Dialogflow uses this field to populate
     * [QueryResult.webhook_payload][google.cloud.dialogflow.v2.QueryResult.webhook_payload] sent to the integration or API caller.
     * This field is also used by the
     * [Google Assistant
     * integration](https://cloud.google.com/dialogflow/docs/integrations/aog)
     * for rich response messages.
     * See the format definition at [Google Assistant Dialogflow webhook
     * format](https://developers.google.com/assistant/actions/build/json/dialogflow-webhook-json)
     *
     * Generated from protobuf field <code>.google.protobuf.Struct payload = 4;</code>
     * @param \Google\Protobuf\Struct $var
     * @return $this
     */
    public function setPayload($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Struct::class);
        $this->payload = $var;

        return $this;
    }

    /**
     * Optional. The collection of output contexts that will overwrite currently
     * active contexts for the session and reset their lifespans.
     * When provided, Dialogflow uses this field to populate
     * [QueryResult.output_contexts][google.cloud.dialogflow.v2.QueryResult.output_contexts] sent to the integration or API caller.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.v2.Context output_contexts = 5;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getOutputContexts()
    {
        return $this->output_contexts;
    }

    /**
     * Optional. The collection of output contexts that will overwrite currently
     * active contexts for the session and reset their lifespans.
     * When provided, Dialogflow uses this field to populate
     * [QueryResult.output_contexts][google.cloud.dialogflow.v2.QueryResult.output_contexts] sent to the integration or API caller.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.v2.Context output_contexts = 5;</code>
     * @param \Google\Cloud\Dialogflow\V2\Context[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setOutputContexts($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Dialogflow\V2\Context::class);
        $this->output_contexts = $arr;

        return $this;
    }

    /**
     * Optional. Invokes the supplied events.
     * When this field is set, Dialogflow ignores the `fulfillment_text`,
     * `fulfillment_messages`, and `payload` fields.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.EventInput followup_event_input = 6;</code>
     * @return \Google\Cloud\Dialogflow\V2\EventInput|null
     */
    public function getFollowupEventInput()
    {
        return isset($this->followup_event_input) ? $this->followup_event_input : null;
    }

    public function hasFollowupEventInput()
    {
        return isset($this->followup_event_input);
    }

    public function clearFollowupEventInput()
    {
        unset($this->followup_event_input);
    }

    /**
     * Optional. Invokes the supplied events.
     * When this field is set, Dialogflow ignores the `fulfillment_text`,
     * `fulfillment_messages`, and `payload` fields.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.EventInput followup_event_input = 6;</code>
     * @param \Google\Cloud\Dialogflow\V2\EventInput $var
     * @return $this
     */
    public function setFollowupEventInput($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\V2\EventInput::class);
        $this->followup_event_input = $var;

        return $this;
    }

    /**
     * Optional. Additional session entity types to replace or extend developer
     * entity types with. The entity synonyms apply to all languages and persist
     * for the session. Setting this data from a webhook overwrites
     * the session entity types that have been set using `detectIntent`,
     * `streamingDetectIntent` or [SessionEntityType][google.cloud.dialogflow.v2.SessionEntityType] management methods.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.v2.SessionEntityType session_entity_types = 10;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getSessionEntityTypes()
    {
        return $this->session_entity_types;
    }

    /**
     * Optional. Additional session entity types to replace or extend developer
     * entity types with. The entity synonyms apply to all languages and persist
     * for the session. Setting this data from a webhook overwrites
     * the session entity types that have been set using `detectIntent`,
     * `streamingDetectIntent` or [SessionEntityType][google.cloud.dialogflow.v2.SessionEntityType] management methods.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.v2.SessionEntityType session_entity_types = 10;</code>
     * @param \Google\Cloud\Dialogflow\V2\SessionEntityType[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setSessionEntityTypes($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Dialogflow\V2\SessionEntityType::class);
        $this->session_entity_types = $arr;

        return $this;
    }

}

