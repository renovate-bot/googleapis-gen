<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/webhook.proto

namespace Google\Cloud\Dialogflow\Cx\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The request message for a webhook call.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3.WebhookRequest</code>
 */
class WebhookRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Always present. The unique identifier of the [DetectIntentResponse][google.cloud.dialogflow.cx.v3.DetectIntentResponse] that
     * will be returned to the API caller.
     *
     * Generated from protobuf field <code>string detect_intent_response_id = 1;</code>
     */
    protected $detect_intent_response_id = '';
    /**
     * Always present. Information about the fulfillment that triggered this
     * webhook call.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.WebhookRequest.FulfillmentInfo fulfillment_info = 6;</code>
     */
    protected $fulfillment_info = null;
    /**
     * Information about the last matched intent.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.WebhookRequest.IntentInfo intent_info = 3;</code>
     */
    protected $intent_info = null;
    /**
     * Information about page status.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.PageInfo page_info = 4;</code>
     */
    protected $page_info = null;
    /**
     * Information about session status.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.SessionInfo session_info = 5;</code>
     */
    protected $session_info = null;
    /**
     * The list of rich message responses to present to the user. Webhook can
     * choose to append or replace this list in
     * [WebhookResponse.fulfillment_response][google.cloud.dialogflow.cx.v3.WebhookResponse.fulfillment_response];
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3.ResponseMessage messages = 7;</code>
     */
    private $messages;
    /**
     * Custom data set in [QueryParameters.payload][google.cloud.dialogflow.cx.v3.QueryParameters.payload].
     *
     * Generated from protobuf field <code>.google.protobuf.Struct payload = 8;</code>
     */
    protected $payload = null;
    /**
     * The sentiment analysis result of the current user request. The field is
     * filled when sentiment analysis is configured to be enabled for the request.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.WebhookRequest.SentimentAnalysisResult sentiment_analysis_result = 9;</code>
     */
    protected $sentiment_analysis_result = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $detect_intent_response_id
     *           Always present. The unique identifier of the [DetectIntentResponse][google.cloud.dialogflow.cx.v3.DetectIntentResponse] that
     *           will be returned to the API caller.
     *     @type \Google\Cloud\Dialogflow\Cx\V3\WebhookRequest\FulfillmentInfo $fulfillment_info
     *           Always present. Information about the fulfillment that triggered this
     *           webhook call.
     *     @type \Google\Cloud\Dialogflow\Cx\V3\WebhookRequest\IntentInfo $intent_info
     *           Information about the last matched intent.
     *     @type \Google\Cloud\Dialogflow\Cx\V3\PageInfo $page_info
     *           Information about page status.
     *     @type \Google\Cloud\Dialogflow\Cx\V3\SessionInfo $session_info
     *           Information about session status.
     *     @type \Google\Cloud\Dialogflow\Cx\V3\ResponseMessage[]|\Google\Protobuf\Internal\RepeatedField $messages
     *           The list of rich message responses to present to the user. Webhook can
     *           choose to append or replace this list in
     *           [WebhookResponse.fulfillment_response][google.cloud.dialogflow.cx.v3.WebhookResponse.fulfillment_response];
     *     @type \Google\Protobuf\Struct $payload
     *           Custom data set in [QueryParameters.payload][google.cloud.dialogflow.cx.v3.QueryParameters.payload].
     *     @type \Google\Cloud\Dialogflow\Cx\V3\WebhookRequest\SentimentAnalysisResult $sentiment_analysis_result
     *           The sentiment analysis result of the current user request. The field is
     *           filled when sentiment analysis is configured to be enabled for the request.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\Webhook::initOnce();
        parent::__construct($data);
    }

    /**
     * Always present. The unique identifier of the [DetectIntentResponse][google.cloud.dialogflow.cx.v3.DetectIntentResponse] that
     * will be returned to the API caller.
     *
     * Generated from protobuf field <code>string detect_intent_response_id = 1;</code>
     * @return string
     */
    public function getDetectIntentResponseId()
    {
        return $this->detect_intent_response_id;
    }

    /**
     * Always present. The unique identifier of the [DetectIntentResponse][google.cloud.dialogflow.cx.v3.DetectIntentResponse] that
     * will be returned to the API caller.
     *
     * Generated from protobuf field <code>string detect_intent_response_id = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setDetectIntentResponseId($var)
    {
        GPBUtil::checkString($var, True);
        $this->detect_intent_response_id = $var;

        return $this;
    }

    /**
     * Always present. Information about the fulfillment that triggered this
     * webhook call.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.WebhookRequest.FulfillmentInfo fulfillment_info = 6;</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3\WebhookRequest\FulfillmentInfo
     */
    public function getFulfillmentInfo()
    {
        return isset($this->fulfillment_info) ? $this->fulfillment_info : null;
    }

    public function hasFulfillmentInfo()
    {
        return isset($this->fulfillment_info);
    }

    public function clearFulfillmentInfo()
    {
        unset($this->fulfillment_info);
    }

    /**
     * Always present. Information about the fulfillment that triggered this
     * webhook call.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.WebhookRequest.FulfillmentInfo fulfillment_info = 6;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3\WebhookRequest\FulfillmentInfo $var
     * @return $this
     */
    public function setFulfillmentInfo($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3\WebhookRequest\FulfillmentInfo::class);
        $this->fulfillment_info = $var;

        return $this;
    }

    /**
     * Information about the last matched intent.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.WebhookRequest.IntentInfo intent_info = 3;</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3\WebhookRequest\IntentInfo
     */
    public function getIntentInfo()
    {
        return isset($this->intent_info) ? $this->intent_info : null;
    }

    public function hasIntentInfo()
    {
        return isset($this->intent_info);
    }

    public function clearIntentInfo()
    {
        unset($this->intent_info);
    }

    /**
     * Information about the last matched intent.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.WebhookRequest.IntentInfo intent_info = 3;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3\WebhookRequest\IntentInfo $var
     * @return $this
     */
    public function setIntentInfo($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3\WebhookRequest\IntentInfo::class);
        $this->intent_info = $var;

        return $this;
    }

    /**
     * Information about page status.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.PageInfo page_info = 4;</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3\PageInfo
     */
    public function getPageInfo()
    {
        return isset($this->page_info) ? $this->page_info : null;
    }

    public function hasPageInfo()
    {
        return isset($this->page_info);
    }

    public function clearPageInfo()
    {
        unset($this->page_info);
    }

    /**
     * Information about page status.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.PageInfo page_info = 4;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3\PageInfo $var
     * @return $this
     */
    public function setPageInfo($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3\PageInfo::class);
        $this->page_info = $var;

        return $this;
    }

    /**
     * Information about session status.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.SessionInfo session_info = 5;</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3\SessionInfo
     */
    public function getSessionInfo()
    {
        return isset($this->session_info) ? $this->session_info : null;
    }

    public function hasSessionInfo()
    {
        return isset($this->session_info);
    }

    public function clearSessionInfo()
    {
        unset($this->session_info);
    }

    /**
     * Information about session status.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.SessionInfo session_info = 5;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3\SessionInfo $var
     * @return $this
     */
    public function setSessionInfo($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3\SessionInfo::class);
        $this->session_info = $var;

        return $this;
    }

    /**
     * The list of rich message responses to present to the user. Webhook can
     * choose to append or replace this list in
     * [WebhookResponse.fulfillment_response][google.cloud.dialogflow.cx.v3.WebhookResponse.fulfillment_response];
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3.ResponseMessage messages = 7;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getMessages()
    {
        return $this->messages;
    }

    /**
     * The list of rich message responses to present to the user. Webhook can
     * choose to append or replace this list in
     * [WebhookResponse.fulfillment_response][google.cloud.dialogflow.cx.v3.WebhookResponse.fulfillment_response];
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3.ResponseMessage messages = 7;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3\ResponseMessage[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setMessages($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Dialogflow\Cx\V3\ResponseMessage::class);
        $this->messages = $arr;

        return $this;
    }

    /**
     * Custom data set in [QueryParameters.payload][google.cloud.dialogflow.cx.v3.QueryParameters.payload].
     *
     * Generated from protobuf field <code>.google.protobuf.Struct payload = 8;</code>
     * @return \Google\Protobuf\Struct
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
     * Custom data set in [QueryParameters.payload][google.cloud.dialogflow.cx.v3.QueryParameters.payload].
     *
     * Generated from protobuf field <code>.google.protobuf.Struct payload = 8;</code>
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
     * The sentiment analysis result of the current user request. The field is
     * filled when sentiment analysis is configured to be enabled for the request.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.WebhookRequest.SentimentAnalysisResult sentiment_analysis_result = 9;</code>
     * @return \Google\Cloud\Dialogflow\Cx\V3\WebhookRequest\SentimentAnalysisResult
     */
    public function getSentimentAnalysisResult()
    {
        return isset($this->sentiment_analysis_result) ? $this->sentiment_analysis_result : null;
    }

    public function hasSentimentAnalysisResult()
    {
        return isset($this->sentiment_analysis_result);
    }

    public function clearSentimentAnalysisResult()
    {
        unset($this->sentiment_analysis_result);
    }

    /**
     * The sentiment analysis result of the current user request. The field is
     * filled when sentiment analysis is configured to be enabled for the request.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.WebhookRequest.SentimentAnalysisResult sentiment_analysis_result = 9;</code>
     * @param \Google\Cloud\Dialogflow\Cx\V3\WebhookRequest\SentimentAnalysisResult $var
     * @return $this
     */
    public function setSentimentAnalysisResult($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\Cx\V3\WebhookRequest\SentimentAnalysisResult::class);
        $this->sentiment_analysis_result = $var;

        return $this;
    }

}

