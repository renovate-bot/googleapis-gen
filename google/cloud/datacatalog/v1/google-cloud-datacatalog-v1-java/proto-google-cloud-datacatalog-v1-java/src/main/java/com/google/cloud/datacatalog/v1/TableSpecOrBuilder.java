// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/datacatalog/v1/table_spec.proto

package com.google.cloud.datacatalog.v1;

public interface TableSpecOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.datacatalog.v1.TableSpec)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Output only. If the table is date-sharded, that is, it matches the `[prefix]YYYYMMDD`
   * name pattern, this field is the Data Catalog resource name of the
   * date-sharded grouped entry. For example:
   * `projects/{PROJECT_ID}/locations/{LOCATION}/entrygroups/{ENTRY_GROUP_ID}/entries/{ENTRY_ID}`.
   * Otherwise, `grouped_entry` is empty.
   * </pre>
   *
   * <code>string grouped_entry = 1 [(.google.api.field_behavior) = OUTPUT_ONLY, (.google.api.resource_reference) = { ... }</code>
   * @return The groupedEntry.
   */
  java.lang.String getGroupedEntry();
  /**
   * <pre>
   * Output only. If the table is date-sharded, that is, it matches the `[prefix]YYYYMMDD`
   * name pattern, this field is the Data Catalog resource name of the
   * date-sharded grouped entry. For example:
   * `projects/{PROJECT_ID}/locations/{LOCATION}/entrygroups/{ENTRY_GROUP_ID}/entries/{ENTRY_ID}`.
   * Otherwise, `grouped_entry` is empty.
   * </pre>
   *
   * <code>string grouped_entry = 1 [(.google.api.field_behavior) = OUTPUT_ONLY, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for groupedEntry.
   */
  com.google.protobuf.ByteString
      getGroupedEntryBytes();
}
