// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/bigtable/admin/v2/bigtable_table_admin.proto

package com.google.bigtable.admin.v2;

public interface RestoreTableRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.bigtable.admin.v2.RestoreTableRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The name of the instance in which to create the restored
   * table. This instance must be the parent of the source backup. Values are
   * of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The parent.
   */
  java.lang.String getParent();
  /**
   * <pre>
   * Required. The name of the instance in which to create the restored
   * table. This instance must be the parent of the source backup. Values are
   * of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for parent.
   */
  com.google.protobuf.ByteString
      getParentBytes();

  /**
   * <pre>
   * Required. The id of the table to create and restore to. This
   * table must not already exist. The `table_id` appended to
   * `parent` forms the full table name of the form
   * `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table_id&gt;`.
   * </pre>
   *
   * <code>string table_id = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The tableId.
   */
  java.lang.String getTableId();
  /**
   * <pre>
   * Required. The id of the table to create and restore to. This
   * table must not already exist. The `table_id` appended to
   * `parent` forms the full table name of the form
   * `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table_id&gt;`.
   * </pre>
   *
   * <code>string table_id = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for tableId.
   */
  com.google.protobuf.ByteString
      getTableIdBytes();

  /**
   * <pre>
   * Name of the backup from which to restore.  Values are of the form
   * `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;/backups/&lt;backup&gt;`.
   * </pre>
   *
   * <code>string backup = 3 [(.google.api.resource_reference) = { ... }</code>
   * @return Whether the backup field is set.
   */
  boolean hasBackup();
  /**
   * <pre>
   * Name of the backup from which to restore.  Values are of the form
   * `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;/backups/&lt;backup&gt;`.
   * </pre>
   *
   * <code>string backup = 3 [(.google.api.resource_reference) = { ... }</code>
   * @return The backup.
   */
  java.lang.String getBackup();
  /**
   * <pre>
   * Name of the backup from which to restore.  Values are of the form
   * `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;/backups/&lt;backup&gt;`.
   * </pre>
   *
   * <code>string backup = 3 [(.google.api.resource_reference) = { ... }</code>
   * @return The bytes for backup.
   */
  com.google.protobuf.ByteString
      getBackupBytes();

  public com.google.bigtable.admin.v2.RestoreTableRequest.SourceCase getSourceCase();
}
