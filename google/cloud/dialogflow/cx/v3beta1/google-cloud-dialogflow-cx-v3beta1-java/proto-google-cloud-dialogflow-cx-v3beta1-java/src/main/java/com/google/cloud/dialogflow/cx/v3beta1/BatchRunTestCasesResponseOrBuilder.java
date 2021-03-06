// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dialogflow/cx/v3beta1/test_case.proto

package com.google.cloud.dialogflow.cx.v3beta1;

public interface BatchRunTestCasesResponseOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.dialogflow.cx.v3beta1.BatchRunTestCasesResponse)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The test case results. The detailed
   * [conversation turns][google.cloud.dialogflow.cx.v3beta1.TestCaseResult.conversation_turns] are empty in this
   * response.
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.cx.v3beta1.TestCaseResult results = 1;</code>
   */
  java.util.List<com.google.cloud.dialogflow.cx.v3beta1.TestCaseResult> 
      getResultsList();
  /**
   * <pre>
   * The test case results. The detailed
   * [conversation turns][google.cloud.dialogflow.cx.v3beta1.TestCaseResult.conversation_turns] are empty in this
   * response.
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.cx.v3beta1.TestCaseResult results = 1;</code>
   */
  com.google.cloud.dialogflow.cx.v3beta1.TestCaseResult getResults(int index);
  /**
   * <pre>
   * The test case results. The detailed
   * [conversation turns][google.cloud.dialogflow.cx.v3beta1.TestCaseResult.conversation_turns] are empty in this
   * response.
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.cx.v3beta1.TestCaseResult results = 1;</code>
   */
  int getResultsCount();
  /**
   * <pre>
   * The test case results. The detailed
   * [conversation turns][google.cloud.dialogflow.cx.v3beta1.TestCaseResult.conversation_turns] are empty in this
   * response.
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.cx.v3beta1.TestCaseResult results = 1;</code>
   */
  java.util.List<? extends com.google.cloud.dialogflow.cx.v3beta1.TestCaseResultOrBuilder> 
      getResultsOrBuilderList();
  /**
   * <pre>
   * The test case results. The detailed
   * [conversation turns][google.cloud.dialogflow.cx.v3beta1.TestCaseResult.conversation_turns] are empty in this
   * response.
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.cx.v3beta1.TestCaseResult results = 1;</code>
   */
  com.google.cloud.dialogflow.cx.v3beta1.TestCaseResultOrBuilder getResultsOrBuilder(
      int index);
}
