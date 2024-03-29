// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/aiplatform/v1/metadata_service.proto

package com.google.cloud.aiplatform.v1;

public interface AddContextChildrenRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.aiplatform.v1.AddContextChildrenRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The resource name of the parent Context.
   * Format:
   * `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
   * </pre>
   *
   * <code>string context = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The context.
   */
  java.lang.String getContext();
  /**
   * <pre>
   * Required. The resource name of the parent Context.
   * Format:
   * `projects/{project}/locations/{location}/metadataStores/{metadatastore}/contexts/{context}`
   * </pre>
   *
   * <code>string context = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for context.
   */
  com.google.protobuf.ByteString
      getContextBytes();

  /**
   * <pre>
   * The resource names of the child Contexts.
   * </pre>
   *
   * <code>repeated string child_contexts = 2 [(.google.api.resource_reference) = { ... }</code>
   * @return A list containing the childContexts.
   */
  java.util.List<java.lang.String>
      getChildContextsList();
  /**
   * <pre>
   * The resource names of the child Contexts.
   * </pre>
   *
   * <code>repeated string child_contexts = 2 [(.google.api.resource_reference) = { ... }</code>
   * @return The count of childContexts.
   */
  int getChildContextsCount();
  /**
   * <pre>
   * The resource names of the child Contexts.
   * </pre>
   *
   * <code>repeated string child_contexts = 2 [(.google.api.resource_reference) = { ... }</code>
   * @param index The index of the element to return.
   * @return The childContexts at the given index.
   */
  java.lang.String getChildContexts(int index);
  /**
   * <pre>
   * The resource names of the child Contexts.
   * </pre>
   *
   * <code>repeated string child_contexts = 2 [(.google.api.resource_reference) = { ... }</code>
   * @param index The index of the value to return.
   * @return The bytes of the childContexts at the given index.
   */
  com.google.protobuf.ByteString
      getChildContextsBytes(int index);
}
