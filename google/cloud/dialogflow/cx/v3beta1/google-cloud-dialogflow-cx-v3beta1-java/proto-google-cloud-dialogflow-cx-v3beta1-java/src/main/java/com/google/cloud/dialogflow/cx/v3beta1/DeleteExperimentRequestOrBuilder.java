// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dialogflow/cx/v3beta1/experiment.proto

package com.google.cloud.dialogflow.cx.v3beta1;

public interface DeleteExperimentRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.dialogflow.cx.v3beta1.DeleteExperimentRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The name of the [Environment][google.cloud.dialogflow.cx.v3beta1.Environment] to delete.
   * Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
   * ID&gt;/environments/&lt;Environment ID&gt;/experiments/&lt;Experiment ID&gt;`.
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The name.
   */
  java.lang.String getName();
  /**
   * <pre>
   * Required. The name of the [Environment][google.cloud.dialogflow.cx.v3beta1.Environment] to delete.
   * Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
   * ID&gt;/environments/&lt;Environment ID&gt;/experiments/&lt;Experiment ID&gt;`.
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for name.
   */
  com.google.protobuf.ByteString
      getNameBytes();
}
