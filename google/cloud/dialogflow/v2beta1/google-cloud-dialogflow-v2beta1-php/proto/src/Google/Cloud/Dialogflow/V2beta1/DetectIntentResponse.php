<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/v2beta1/session.proto

namespace Google\Cloud\Dialogflow\V2beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The message returned from the DetectIntent method.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.v2beta1.DetectIntentResponse</code>
 */
class DetectIntentResponse extends \Google\Protobuf\Internal\Message
{
    /**
     * The unique identifier of the response. It can be used to
     * locate a response in the training example set or for reporting issues.
     *
     * Generated from protobuf field <code>string response_id = 1;</code>
     */
    protected $response_id = '';
    /**
     * The selected results of the conversational query or event processing.
     * See `alternative_query_results` for additional potential results.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2beta1.QueryResult query_result = 2;</code>
     */
    protected $query_result = null;
    /**
     * If Knowledge Connectors are enabled, there could be more than one result
     * returned for a given query or event, and this field will contain all
     * results except for the top one, which is captured in query_result. The
     * alternative results are ordered by decreasing
     * `QueryResult.intent_detection_confidence`. If Knowledge Connectors are
     * disabled, this field will be empty until multiple responses for regular
     * intents are supported, at which point those additional results will be
     * surfaced here.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.v2beta1.QueryResult alternative_query_results = 5;</code>
     */
    private $alternative_query_results;
    /**
     * Specifies the status of the webhook request.
     *
     * Generated from protobuf field <code>.google.rpc.Status webhook_status = 3;</code>
     */
    protected $webhook_status = null;
    /**
     * The audio data bytes encoded as specified in the request.
     * Note: The output audio is generated based on the values of default platform
     * text responses found in the `query_result.fulfillment_messages` field. If
     * multiple default text responses exist, they will be concatenated when
     * generating audio. If no default platform text responses exist, the
     * generated audio content will be empty.
     * In some scenarios, multiple output audio fields may be present in the
     * response structure. In these cases, only the top-most-level audio output
     * has content.
     *
     * Generated from protobuf field <code>bytes output_audio = 4;</code>
     */
    protected $output_audio = '';
    /**
     * The config used by the speech synthesizer to generate the output audio.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2beta1.OutputAudioConfig output_audio_config = 6;</code>
     */
    protected $output_audio_config = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $response_id
     *           The unique identifier of the response. It can be used to
     *           locate a response in the training example set or for reporting issues.
     *     @type \Google\Cloud\Dialogflow\V2beta1\QueryResult $query_result
     *           The selected results of the conversational query or event processing.
     *           See `alternative_query_results` for additional potential results.
     *     @type \Google\Cloud\Dialogflow\V2beta1\QueryResult[]|\Google\Protobuf\Internal\RepeatedField $alternative_query_results
     *           If Knowledge Connectors are enabled, there could be more than one result
     *           returned for a given query or event, and this field will contain all
     *           results except for the top one, which is captured in query_result. The
     *           alternative results are ordered by decreasing
     *           `QueryResult.intent_detection_confidence`. If Knowledge Connectors are
     *           disabled, this field will be empty until multiple responses for regular
     *           intents are supported, at which point those additional results will be
     *           surfaced here.
     *     @type \Google\Rpc\Status $webhook_status
     *           Specifies the status of the webhook request.
     *     @type string $output_audio
     *           The audio data bytes encoded as specified in the request.
     *           Note: The output audio is generated based on the values of default platform
     *           text responses found in the `query_result.fulfillment_messages` field. If
     *           multiple default text responses exist, they will be concatenated when
     *           generating audio. If no default platform text responses exist, the
     *           generated audio content will be empty.
     *           In some scenarios, multiple output audio fields may be present in the
     *           response structure. In these cases, only the top-most-level audio output
     *           has content.
     *     @type \Google\Cloud\Dialogflow\V2beta1\OutputAudioConfig $output_audio_config
     *           The config used by the speech synthesizer to generate the output audio.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\V2Beta1\Session::initOnce();
        parent::__construct($data);
    }

    /**
     * The unique identifier of the response. It can be used to
     * locate a response in the training example set or for reporting issues.
     *
     * Generated from protobuf field <code>string response_id = 1;</code>
     * @return string
     */
    public function getResponseId()
    {
        return $this->response_id;
    }

    /**
     * The unique identifier of the response. It can be used to
     * locate a response in the training example set or for reporting issues.
     *
     * Generated from protobuf field <code>string response_id = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setResponseId($var)
    {
        GPBUtil::checkString($var, True);
        $this->response_id = $var;

        return $this;
    }

    /**
     * The selected results of the conversational query or event processing.
     * See `alternative_query_results` for additional potential results.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2beta1.QueryResult query_result = 2;</code>
     * @return \Google\Cloud\Dialogflow\V2beta1\QueryResult|null
     */
    public function getQueryResult()
    {
        return isset($this->query_result) ? $this->query_result : null;
    }

    public function hasQueryResult()
    {
        return isset($this->query_result);
    }

    public function clearQueryResult()
    {
        unset($this->query_result);
    }

    /**
     * The selected results of the conversational query or event processing.
     * See `alternative_query_results` for additional potential results.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2beta1.QueryResult query_result = 2;</code>
     * @param \Google\Cloud\Dialogflow\V2beta1\QueryResult $var
     * @return $this
     */
    public function setQueryResult($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\V2beta1\QueryResult::class);
        $this->query_result = $var;

        return $this;
    }

    /**
     * If Knowledge Connectors are enabled, there could be more than one result
     * returned for a given query or event, and this field will contain all
     * results except for the top one, which is captured in query_result. The
     * alternative results are ordered by decreasing
     * `QueryResult.intent_detection_confidence`. If Knowledge Connectors are
     * disabled, this field will be empty until multiple responses for regular
     * intents are supported, at which point those additional results will be
     * surfaced here.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.v2beta1.QueryResult alternative_query_results = 5;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getAlternativeQueryResults()
    {
        return $this->alternative_query_results;
    }

    /**
     * If Knowledge Connectors are enabled, there could be more than one result
     * returned for a given query or event, and this field will contain all
     * results except for the top one, which is captured in query_result. The
     * alternative results are ordered by decreasing
     * `QueryResult.intent_detection_confidence`. If Knowledge Connectors are
     * disabled, this field will be empty until multiple responses for regular
     * intents are supported, at which point those additional results will be
     * surfaced here.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.v2beta1.QueryResult alternative_query_results = 5;</code>
     * @param \Google\Cloud\Dialogflow\V2beta1\QueryResult[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setAlternativeQueryResults($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Dialogflow\V2beta1\QueryResult::class);
        $this->alternative_query_results = $arr;

        return $this;
    }

    /**
     * Specifies the status of the webhook request.
     *
     * Generated from protobuf field <code>.google.rpc.Status webhook_status = 3;</code>
     * @return \Google\Rpc\Status|null
     */
    public function getWebhookStatus()
    {
        return isset($this->webhook_status) ? $this->webhook_status : null;
    }

    public function hasWebhookStatus()
    {
        return isset($this->webhook_status);
    }

    public function clearWebhookStatus()
    {
        unset($this->webhook_status);
    }

    /**
     * Specifies the status of the webhook request.
     *
     * Generated from protobuf field <code>.google.rpc.Status webhook_status = 3;</code>
     * @param \Google\Rpc\Status $var
     * @return $this
     */
    public function setWebhookStatus($var)
    {
        GPBUtil::checkMessage($var, \Google\Rpc\Status::class);
        $this->webhook_status = $var;

        return $this;
    }

    /**
     * The audio data bytes encoded as specified in the request.
     * Note: The output audio is generated based on the values of default platform
     * text responses found in the `query_result.fulfillment_messages` field. If
     * multiple default text responses exist, they will be concatenated when
     * generating audio. If no default platform text responses exist, the
     * generated audio content will be empty.
     * In some scenarios, multiple output audio fields may be present in the
     * response structure. In these cases, only the top-most-level audio output
     * has content.
     *
     * Generated from protobuf field <code>bytes output_audio = 4;</code>
     * @return string
     */
    public function getOutputAudio()
    {
        return $this->output_audio;
    }

    /**
     * The audio data bytes encoded as specified in the request.
     * Note: The output audio is generated based on the values of default platform
     * text responses found in the `query_result.fulfillment_messages` field. If
     * multiple default text responses exist, they will be concatenated when
     * generating audio. If no default platform text responses exist, the
     * generated audio content will be empty.
     * In some scenarios, multiple output audio fields may be present in the
     * response structure. In these cases, only the top-most-level audio output
     * has content.
     *
     * Generated from protobuf field <code>bytes output_audio = 4;</code>
     * @param string $var
     * @return $this
     */
    public function setOutputAudio($var)
    {
        GPBUtil::checkString($var, False);
        $this->output_audio = $var;

        return $this;
    }

    /**
     * The config used by the speech synthesizer to generate the output audio.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2beta1.OutputAudioConfig output_audio_config = 6;</code>
     * @return \Google\Cloud\Dialogflow\V2beta1\OutputAudioConfig|null
     */
    public function getOutputAudioConfig()
    {
        return isset($this->output_audio_config) ? $this->output_audio_config : null;
    }

    public function hasOutputAudioConfig()
    {
        return isset($this->output_audio_config);
    }

    public function clearOutputAudioConfig()
    {
        unset($this->output_audio_config);
    }

    /**
     * The config used by the speech synthesizer to generate the output audio.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2beta1.OutputAudioConfig output_audio_config = 6;</code>
     * @param \Google\Cloud\Dialogflow\V2beta1\OutputAudioConfig $var
     * @return $this
     */
    public function setOutputAudioConfig($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\V2beta1\OutputAudioConfig::class);
        $this->output_audio_config = $var;

        return $this;
    }

}

