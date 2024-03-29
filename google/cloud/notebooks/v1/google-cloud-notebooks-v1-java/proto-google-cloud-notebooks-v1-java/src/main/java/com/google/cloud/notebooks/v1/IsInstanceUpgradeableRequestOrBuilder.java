// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/notebooks/v1/service.proto

package com.google.cloud.notebooks.v1;

public interface IsInstanceUpgradeableRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.notebooks.v1.IsInstanceUpgradeableRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. Format:
   * `projects/{project_id}/locations/{location}/instances/{instance_id}`
   * </pre>
   *
   * <code>string notebook_instance = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The notebookInstance.
   */
  java.lang.String getNotebookInstance();
  /**
   * <pre>
   * Required. Format:
   * `projects/{project_id}/locations/{location}/instances/{instance_id}`
   * </pre>
   *
   * <code>string notebook_instance = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for notebookInstance.
   */
  com.google.protobuf.ByteString
      getNotebookInstanceBytes();
}
