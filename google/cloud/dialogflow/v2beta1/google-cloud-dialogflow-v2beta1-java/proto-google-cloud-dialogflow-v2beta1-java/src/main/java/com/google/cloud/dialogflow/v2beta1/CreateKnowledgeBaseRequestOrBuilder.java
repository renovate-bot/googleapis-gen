// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dialogflow/v2beta1/knowledge_base.proto

package com.google.cloud.dialogflow.v2beta1;

public interface CreateKnowledgeBaseRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.dialogflow.v2beta1.CreateKnowledgeBaseRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The project to create a knowledge base for.
   * Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The parent.
   */
  java.lang.String getParent();
  /**
   * <pre>
   * Required. The project to create a knowledge base for.
   * Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for parent.
   */
  com.google.protobuf.ByteString
      getParentBytes();

  /**
   * <pre>
   * Required. The knowledge base to create.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.v2beta1.KnowledgeBase knowledge_base = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the knowledgeBase field is set.
   */
  boolean hasKnowledgeBase();
  /**
   * <pre>
   * Required. The knowledge base to create.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.v2beta1.KnowledgeBase knowledge_base = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The knowledgeBase.
   */
  com.google.cloud.dialogflow.v2beta1.KnowledgeBase getKnowledgeBase();
  /**
   * <pre>
   * Required. The knowledge base to create.
   * </pre>
   *
   * <code>.google.cloud.dialogflow.v2beta1.KnowledgeBase knowledge_base = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.cloud.dialogflow.v2beta1.KnowledgeBaseOrBuilder getKnowledgeBaseOrBuilder();
}
