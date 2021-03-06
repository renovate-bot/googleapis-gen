// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/dataflow/v1beta3/jobs.proto

package com.google.dataflow.v1beta3;

public interface DatastoreIODetailsOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.dataflow.v1beta3.DatastoreIODetails)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Namespace used in the connection.
   * </pre>
   *
   * <code>string namespace = 1;</code>
   * @return The namespace.
   */
  java.lang.String getNamespace();
  /**
   * <pre>
   * Namespace used in the connection.
   * </pre>
   *
   * <code>string namespace = 1;</code>
   * @return The bytes for namespace.
   */
  com.google.protobuf.ByteString
      getNamespaceBytes();

  /**
   * <pre>
   * ProjectId accessed in the connection.
   * </pre>
   *
   * <code>string project_id = 2;</code>
   * @return The projectId.
   */
  java.lang.String getProjectId();
  /**
   * <pre>
   * ProjectId accessed in the connection.
   * </pre>
   *
   * <code>string project_id = 2;</code>
   * @return The bytes for projectId.
   */
  com.google.protobuf.ByteString
      getProjectIdBytes();
}
