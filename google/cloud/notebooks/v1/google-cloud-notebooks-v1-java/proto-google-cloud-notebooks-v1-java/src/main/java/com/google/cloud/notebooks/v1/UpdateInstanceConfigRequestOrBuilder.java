// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/notebooks/v1/service.proto

package com.google.cloud.notebooks.v1;

public interface UpdateInstanceConfigRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.notebooks.v1.UpdateInstanceConfigRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. Format:
   * `projects/{project_id}/locations/{location}/instances/{instance_id}`
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The name.
   */
  java.lang.String getName();
  /**
   * <pre>
   * Required. Format:
   * `projects/{project_id}/locations/{location}/instances/{instance_id}`
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for name.
   */
  com.google.protobuf.ByteString
      getNameBytes();

  /**
   * <pre>
   * The instance configurations to be updated.
   * </pre>
   *
   * <code>.google.cloud.notebooks.v1.InstanceConfig config = 2;</code>
   * @return Whether the config field is set.
   */
  boolean hasConfig();
  /**
   * <pre>
   * The instance configurations to be updated.
   * </pre>
   *
   * <code>.google.cloud.notebooks.v1.InstanceConfig config = 2;</code>
   * @return The config.
   */
  com.google.cloud.notebooks.v1.InstanceConfig getConfig();
  /**
   * <pre>
   * The instance configurations to be updated.
   * </pre>
   *
   * <code>.google.cloud.notebooks.v1.InstanceConfig config = 2;</code>
   */
  com.google.cloud.notebooks.v1.InstanceConfigOrBuilder getConfigOrBuilder();
}
