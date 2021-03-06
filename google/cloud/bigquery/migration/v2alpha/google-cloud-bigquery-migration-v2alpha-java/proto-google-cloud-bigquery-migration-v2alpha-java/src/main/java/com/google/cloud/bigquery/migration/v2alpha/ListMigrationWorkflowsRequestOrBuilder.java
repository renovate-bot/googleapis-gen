// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/bigquery/migration/v2alpha/migration_service.proto

package com.google.cloud.bigquery.migration.v2alpha;

public interface ListMigrationWorkflowsRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.bigquery.migration.v2alpha.ListMigrationWorkflowsRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The project and location of the migration workflows to list.
   * Example: `projects/123/locations/us`
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The parent.
   */
  java.lang.String getParent();
  /**
   * <pre>
   * Required. The project and location of the migration workflows to list.
   * Example: `projects/123/locations/us`
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for parent.
   */
  com.google.protobuf.ByteString
      getParentBytes();

  /**
   * <pre>
   * The list of fields to be retrieved.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask read_mask = 2;</code>
   * @return Whether the readMask field is set.
   */
  boolean hasReadMask();
  /**
   * <pre>
   * The list of fields to be retrieved.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask read_mask = 2;</code>
   * @return The readMask.
   */
  com.google.protobuf.FieldMask getReadMask();
  /**
   * <pre>
   * The list of fields to be retrieved.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask read_mask = 2;</code>
   */
  com.google.protobuf.FieldMaskOrBuilder getReadMaskOrBuilder();

  /**
   * <pre>
   * The maximum number of migration workflows to return. The service may return
   * fewer than this number.
   * </pre>
   *
   * <code>int32 page_size = 3;</code>
   * @return The pageSize.
   */
  int getPageSize();

  /**
   * <pre>
   * A page token, received from previous `ListMigrationWorkflows` call.
   * Provide this to retrieve the subsequent page.
   * When paginating, all other parameters provided to `ListMigrationWorkflows`
   * must match the call that provided the page token.
   * </pre>
   *
   * <code>string page_token = 4;</code>
   * @return The pageToken.
   */
  java.lang.String getPageToken();
  /**
   * <pre>
   * A page token, received from previous `ListMigrationWorkflows` call.
   * Provide this to retrieve the subsequent page.
   * When paginating, all other parameters provided to `ListMigrationWorkflows`
   * must match the call that provided the page token.
   * </pre>
   *
   * <code>string page_token = 4;</code>
   * @return The bytes for pageToken.
   */
  com.google.protobuf.ByteString
      getPageTokenBytes();
}
