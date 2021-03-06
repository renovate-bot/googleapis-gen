// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dialogflow/v2beta1/document.proto

package com.google.cloud.dialogflow.v2beta1;

public interface KnowledgeOperationMetadataOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.dialogflow.v2beta1.KnowledgeOperationMetadata)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. Output only. The current state of this operation.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.v2beta1.KnowledgeOperationMetadata.State state = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The enum numeric value on the wire for state.
   */
  int getStateValue();
  /**
   * <pre>
   * Required. Output only. The current state of this operation.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.v2beta1.KnowledgeOperationMetadata.State state = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The state.
   */
  com.google.cloud.dialogflow.v2beta1.KnowledgeOperationMetadata.State getState();
}
