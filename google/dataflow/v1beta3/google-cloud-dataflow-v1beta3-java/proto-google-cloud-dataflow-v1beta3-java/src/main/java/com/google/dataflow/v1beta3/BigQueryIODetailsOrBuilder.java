// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/dataflow/v1beta3/jobs.proto

package com.google.dataflow.v1beta3;

public interface BigQueryIODetailsOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.dataflow.v1beta3.BigQueryIODetails)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Table accessed in the connection.
   * </pre>
   *
   * <code>string table = 1;</code>
   * @return The table.
   */
  java.lang.String getTable();
  /**
   * <pre>
   * Table accessed in the connection.
   * </pre>
   *
   * <code>string table = 1;</code>
   * @return The bytes for table.
   */
  com.google.protobuf.ByteString
      getTableBytes();

  /**
   * <pre>
   * Dataset accessed in the connection.
   * </pre>
   *
   * <code>string dataset = 2;</code>
   * @return The dataset.
   */
  java.lang.String getDataset();
  /**
   * <pre>
   * Dataset accessed in the connection.
   * </pre>
   *
   * <code>string dataset = 2;</code>
   * @return The bytes for dataset.
   */
  com.google.protobuf.ByteString
      getDatasetBytes();

  /**
   * <pre>
   * Project accessed in the connection.
   * </pre>
   *
   * <code>string project_id = 3;</code>
   * @return The projectId.
   */
  java.lang.String getProjectId();
  /**
   * <pre>
   * Project accessed in the connection.
   * </pre>
   *
   * <code>string project_id = 3;</code>
   * @return The bytes for projectId.
   */
  com.google.protobuf.ByteString
      getProjectIdBytes();

  /**
   * <pre>
   * Query used to access data in the connection.
   * </pre>
   *
   * <code>string query = 4;</code>
   * @return The query.
   */
  java.lang.String getQuery();
  /**
   * <pre>
   * Query used to access data in the connection.
   * </pre>
   *
   * <code>string query = 4;</code>
   * @return The bytes for query.
   */
  com.google.protobuf.ByteString
      getQueryBytes();
}
