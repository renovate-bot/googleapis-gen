// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/bigtable/admin/v2/bigtable_table_admin.proto

package com.google.bigtable.admin.v2;

public interface CreateBackupMetadataOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.bigtable.admin.v2.CreateBackupMetadata)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The name of the backup being created.
   * </pre>
   *
   * <code>string name = 1;</code>
   * @return The name.
   */
  java.lang.String getName();
  /**
   * <pre>
   * The name of the backup being created.
   * </pre>
   *
   * <code>string name = 1;</code>
   * @return The bytes for name.
   */
  com.google.protobuf.ByteString
      getNameBytes();

  /**
   * <pre>
   * The name of the table the backup is created from.
   * </pre>
   *
   * <code>string source_table = 2;</code>
   * @return The sourceTable.
   */
  java.lang.String getSourceTable();
  /**
   * <pre>
   * The name of the table the backup is created from.
   * </pre>
   *
   * <code>string source_table = 2;</code>
   * @return The bytes for sourceTable.
   */
  com.google.protobuf.ByteString
      getSourceTableBytes();

  /**
   * <pre>
   * The time at which this operation started.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp start_time = 3;</code>
   * @return Whether the startTime field is set.
   */
  boolean hasStartTime();
  /**
   * <pre>
   * The time at which this operation started.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp start_time = 3;</code>
   * @return The startTime.
   */
  com.google.protobuf.Timestamp getStartTime();
  /**
   * <pre>
   * The time at which this operation started.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp start_time = 3;</code>
   */
  com.google.protobuf.TimestampOrBuilder getStartTimeOrBuilder();

  /**
   * <pre>
   * If set, the time at which this operation finished or was cancelled.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp end_time = 4;</code>
   * @return Whether the endTime field is set.
   */
  boolean hasEndTime();
  /**
   * <pre>
   * If set, the time at which this operation finished or was cancelled.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp end_time = 4;</code>
   * @return The endTime.
   */
  com.google.protobuf.Timestamp getEndTime();
  /**
   * <pre>
   * If set, the time at which this operation finished or was cancelled.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp end_time = 4;</code>
   */
  com.google.protobuf.TimestampOrBuilder getEndTimeOrBuilder();
}
