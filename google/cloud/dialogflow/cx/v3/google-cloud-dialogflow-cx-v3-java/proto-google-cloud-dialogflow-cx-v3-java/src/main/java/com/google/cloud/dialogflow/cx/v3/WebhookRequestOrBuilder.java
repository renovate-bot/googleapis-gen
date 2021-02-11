// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dialogflow/cx/v3/webhook.proto

package com.google.cloud.dialogflow.cx.v3;

public interface WebhookRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.dialogflow.cx.v3.WebhookRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Always present. The unique identifier of the [DetectIntentResponse][google.cloud.dialogflow.cx.v3.DetectIntentResponse] that
   * will be returned to the API caller.
   * </pre>
   *
   * <code>string detect_intent_response_id = 1;</code>
   * @return The detectIntentResponseId.
   */
  java.lang.String getDetectIntentResponseId();
  /**
   * <pre>
   * Always present. The unique identifier of the [DetectIntentResponse][google.cloud.dialogflow.cx.v3.DetectIntentResponse] that
   * will be returned to the API caller.
   * </pre>
   *
   * <code>string detect_intent_response_id = 1;</code>
   * @return The bytes for detectIntentResponseId.
   */
  com.google.protobuf.ByteString
      getDetectIntentResponseIdBytes();

  /**
   * <pre>
   * Always present. Information about the fulfillment that triggered this
   * webhook call.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.cx.v3.WebhookRequest.FulfillmentInfo fulfillment_info = 6;</code>
   * @return Whether the fulfillmentInfo field is set.
   */
  boolean hasFulfillmentInfo();
  /**
   * <pre>
   * Always present. Information about the fulfillment that triggered this
   * webhook call.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.cx.v3.WebhookRequest.FulfillmentInfo fulfillment_info = 6;</code>
   * @return The fulfillmentInfo.
   */
  com.google.cloud.dialogflow.cx.v3.WebhookRequest.FulfillmentInfo getFulfillmentInfo();
  /**
   * <pre>
   * Always present. Information about the fulfillment that triggered this
   * webhook call.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.cx.v3.WebhookRequest.FulfillmentInfo fulfillment_info = 6;</code>
   */
  com.google.cloud.dialogflow.cx.v3.WebhookRequest.FulfillmentInfoOrBuilder getFulfillmentInfoOrBuilder();

  /**
   * <pre>
   * Information about the last matched intent.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.cx.v3.WebhookRequest.IntentInfo intent_info = 3;</code>
   * @return Whether the intentInfo field is set.
   */
  boolean hasIntentInfo();
  /**
   * <pre>
   * Information about the last matched intent.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.cx.v3.WebhookRequest.IntentInfo intent_info = 3;</code>
   * @return The intentInfo.
   */
  com.google.cloud.dialogflow.cx.v3.WebhookRequest.IntentInfo getIntentInfo();
  /**
   * <pre>
   * Information about the last matched intent.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.cx.v3.WebhookRequest.IntentInfo intent_info = 3;</code>
   */
  com.google.cloud.dialogflow.cx.v3.WebhookRequest.IntentInfoOrBuilder getIntentInfoOrBuilder();

  /**
   * <pre>
   * Information about page status.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.cx.v3.PageInfo page_info = 4;</code>
   * @return Whether the pageInfo field is set.
   */
  boolean hasPageInfo();
  /**
   * <pre>
   * Information about page status.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.cx.v3.PageInfo page_info = 4;</code>
   * @return The pageInfo.
   */
  com.google.cloud.dialogflow.cx.v3.PageInfo getPageInfo();
  /**
   * <pre>
   * Information about page status.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.cx.v3.PageInfo page_info = 4;</code>
   */
  com.google.cloud.dialogflow.cx.v3.PageInfoOrBuilder getPageInfoOrBuilder();

  /**
   * <pre>
   * Information about session status.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.cx.v3.SessionInfo session_info = 5;</code>
   * @return Whether the sessionInfo field is set.
   */
  boolean hasSessionInfo();
  /**
   * <pre>
   * Information about session status.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.cx.v3.SessionInfo session_info = 5;</code>
   * @return The sessionInfo.
   */
  com.google.cloud.dialogflow.cx.v3.SessionInfo getSessionInfo();
  /**
   * <pre>
   * Information about session status.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.cx.v3.SessionInfo session_info = 5;</code>
   */
  com.google.cloud.dialogflow.cx.v3.SessionInfoOrBuilder getSessionInfoOrBuilder();

  /**
   * <pre>
   * The list of rich message responses to present to the user. Webhook can
   * choose to append or replace this list in
   * [WebhookResponse.fulfillment_response][google.cloud.dialogflow.cx.v3.WebhookResponse.fulfillment_response];
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.cx.v3.ResponseMessage messages = 7;</code>
   */
  java.util.List<com.google.cloud.dialogflow.cx.v3.ResponseMessage> 
      getMessagesList();
  /**
   * <pre>
   * The list of rich message responses to present to the user. Webhook can
   * choose to append or replace this list in
   * [WebhookResponse.fulfillment_response][google.cloud.dialogflow.cx.v3.WebhookResponse.fulfillment_response];
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.cx.v3.ResponseMessage messages = 7;</code>
   */
  com.google.cloud.dialogflow.cx.v3.ResponseMessage getMessages(int index);
  /**
   * <pre>
   * The list of rich message responses to present to the user. Webhook can
   * choose to append or replace this list in
   * [WebhookResponse.fulfillment_response][google.cloud.dialogflow.cx.v3.WebhookResponse.fulfillment_response];
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.cx.v3.ResponseMessage messages = 7;</code>
   */
  int getMessagesCount();
  /**
   * <pre>
   * The list of rich message responses to present to the user. Webhook can
   * choose to append or replace this list in
   * [WebhookResponse.fulfillment_response][google.cloud.dialogflow.cx.v3.WebhookResponse.fulfillment_response];
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.cx.v3.ResponseMessage messages = 7;</code>
   */
  java.util.List<? extends com.google.cloud.dialogflow.cx.v3.ResponseMessageOrBuilder> 
      getMessagesOrBuilderList();
  /**
   * <pre>
   * The list of rich message responses to present to the user. Webhook can
   * choose to append or replace this list in
   * [WebhookResponse.fulfillment_response][google.cloud.dialogflow.cx.v3.WebhookResponse.fulfillment_response];
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.cx.v3.ResponseMessage messages = 7;</code>
   */
  com.google.cloud.dialogflow.cx.v3.ResponseMessageOrBuilder getMessagesOrBuilder(
      int index);

  /**
   * <pre>
   * Custom data set in [QueryParameters.payload][google.cloud.dialogflow.cx.v3.QueryParameters.payload].
   * </pre>
   *
   * <code>.google.protobuf.Struct payload = 8;</code>
   * @return Whether the payload field is set.
   */
  boolean hasPayload();
  /**
   * <pre>
   * Custom data set in [QueryParameters.payload][google.cloud.dialogflow.cx.v3.QueryParameters.payload].
   * </pre>
   *
   * <code>.google.protobuf.Struct payload = 8;</code>
   * @return The payload.
   */
  com.google.protobuf.Struct getPayload();
  /**
   * <pre>
   * Custom data set in [QueryParameters.payload][google.cloud.dialogflow.cx.v3.QueryParameters.payload].
   * </pre>
   *
   * <code>.google.protobuf.Struct payload = 8;</code>
   */
  com.google.protobuf.StructOrBuilder getPayloadOrBuilder();

  /**
   * <pre>
   * The sentiment analysis result of the current user request. The field is
   * filled when sentiment analysis is configured to be enabled for the request.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.cx.v3.WebhookRequest.SentimentAnalysisResult sentiment_analysis_result = 9;</code>
   * @return Whether the sentimentAnalysisResult field is set.
   */
  boolean hasSentimentAnalysisResult();
  /**
   * <pre>
   * The sentiment analysis result of the current user request. The field is
   * filled when sentiment analysis is configured to be enabled for the request.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.cx.v3.WebhookRequest.SentimentAnalysisResult sentiment_analysis_result = 9;</code>
   * @return The sentimentAnalysisResult.
   */
  com.google.cloud.dialogflow.cx.v3.WebhookRequest.SentimentAnalysisResult getSentimentAnalysisResult();
  /**
   * <pre>
   * The sentiment analysis result of the current user request. The field is
   * filled when sentiment analysis is configured to be enabled for the request.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.cx.v3.WebhookRequest.SentimentAnalysisResult sentiment_analysis_result = 9;</code>
   */
  com.google.cloud.dialogflow.cx.v3.WebhookRequest.SentimentAnalysisResultOrBuilder getSentimentAnalysisResultOrBuilder();
}
