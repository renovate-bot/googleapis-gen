// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dialogflow/cx/v3/test_case.proto

package com.google.cloud.dialogflow.cx.v3;

public interface TestConfigOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.dialogflow.cx.v3.TestConfig)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Session parameters to be compared when calculating differences.
   * </pre>
   *
   * <code>repeated string tracking_parameters = 1;</code>
   * @return A list containing the trackingParameters.
   */
  java.util.List<java.lang.String>
      getTrackingParametersList();
  /**
   * <pre>
   * Session parameters to be compared when calculating differences.
   * </pre>
   *
   * <code>repeated string tracking_parameters = 1;</code>
   * @return The count of trackingParameters.
   */
  int getTrackingParametersCount();
  /**
   * <pre>
   * Session parameters to be compared when calculating differences.
   * </pre>
   *
   * <code>repeated string tracking_parameters = 1;</code>
   * @param index The index of the element to return.
   * @return The trackingParameters at the given index.
   */
  java.lang.String getTrackingParameters(int index);
  /**
   * <pre>
   * Session parameters to be compared when calculating differences.
   * </pre>
   *
   * <code>repeated string tracking_parameters = 1;</code>
   * @param index The index of the value to return.
   * @return The bytes of the trackingParameters at the given index.
   */
  com.google.protobuf.ByteString
      getTrackingParametersBytes(int index);

  /**
   * <pre>
   * Flow name. If not set, default start flow is assumed.
   * Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
   * ID&gt;/flows/&lt;Flow ID&gt;`.
   * </pre>
   *
   * <code>string flow = 2 [(.google.api.resource_reference) = { ... }</code>
   * @return The flow.
   */
  java.lang.String getFlow();
  /**
   * <pre>
   * Flow name. If not set, default start flow is assumed.
   * Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
   * ID&gt;/flows/&lt;Flow ID&gt;`.
   * </pre>
   *
   * <code>string flow = 2 [(.google.api.resource_reference) = { ... }</code>
   * @return The bytes for flow.
   */
  com.google.protobuf.ByteString
      getFlowBytes();
}
