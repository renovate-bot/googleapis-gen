// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/datacatalog/v1beta1/table_spec.proto

package com.google.cloud.datacatalog.v1beta1;

public interface TableSpecOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.datacatalog.v1beta1.TableSpec)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Output only. If the table is a dated shard, i.e., with name pattern `[prefix]YYYYMMDD`,
   * `grouped_entry` is the Data Catalog resource name of the date sharded
   * grouped entry, for example,
   * `projects/{project_id}/locations/{location}/entrygroups/{entry_group_id}/entries/{entry_id}`.
   * Otherwise, `grouped_entry` is empty.
   * </pre>
   *
   * <code>string grouped_entry = 1 [(.google.api.field_behavior) = OUTPUT_ONLY, (.google.api.resource_reference) = { ... }</code>
   * @return The groupedEntry.
   */
  java.lang.String getGroupedEntry();
  /**
   * <pre>
   * Output only. If the table is a dated shard, i.e., with name pattern `[prefix]YYYYMMDD`,
   * `grouped_entry` is the Data Catalog resource name of the date sharded
   * grouped entry, for example,
   * `projects/{project_id}/locations/{location}/entrygroups/{entry_group_id}/entries/{entry_id}`.
   * Otherwise, `grouped_entry` is empty.
   * </pre>
   *
   * <code>string grouped_entry = 1 [(.google.api.field_behavior) = OUTPUT_ONLY, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for groupedEntry.
   */
  com.google.protobuf.ByteString
      getGroupedEntryBytes();
}
