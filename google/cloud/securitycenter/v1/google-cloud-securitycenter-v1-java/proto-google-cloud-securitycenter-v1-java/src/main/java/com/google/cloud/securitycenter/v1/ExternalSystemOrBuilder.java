// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/securitycenter/v1/external_system.proto

package com.google.cloud.securitycenter.v1;

public interface ExternalSystemOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.securitycenter.v1.ExternalSystem)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * External System Name e.g. jira, demisto, etc.
   *  e.g.: `organizations/1234/sources/5678/findings/123456/externalSystems/jira`
   * `folders/1234/sources/5678/findings/123456/externalSystems/jira`
   * `projects/1234/sources/5678/findings/123456/externalSystems/jira`
   * </pre>
   *
   * <code>string name = 1;</code>
   * @return The name.
   */
  java.lang.String getName();
  /**
   * <pre>
   * External System Name e.g. jira, demisto, etc.
   *  e.g.: `organizations/1234/sources/5678/findings/123456/externalSystems/jira`
   * `folders/1234/sources/5678/findings/123456/externalSystems/jira`
   * `projects/1234/sources/5678/findings/123456/externalSystems/jira`
   * </pre>
   *
   * <code>string name = 1;</code>
   * @return The bytes for name.
   */
  com.google.protobuf.ByteString
      getNameBytes();

  /**
   * <pre>
   * References primary/secondary etc assignees in the external system.
   * </pre>
   *
   * <code>repeated string assignees = 2;</code>
   * @return A list containing the assignees.
   */
  java.util.List<java.lang.String>
      getAssigneesList();
  /**
   * <pre>
   * References primary/secondary etc assignees in the external system.
   * </pre>
   *
   * <code>repeated string assignees = 2;</code>
   * @return The count of assignees.
   */
  int getAssigneesCount();
  /**
   * <pre>
   * References primary/secondary etc assignees in the external system.
   * </pre>
   *
   * <code>repeated string assignees = 2;</code>
   * @param index The index of the element to return.
   * @return The assignees at the given index.
   */
  java.lang.String getAssignees(int index);
  /**
   * <pre>
   * References primary/secondary etc assignees in the external system.
   * </pre>
   *
   * <code>repeated string assignees = 2;</code>
   * @param index The index of the value to return.
   * @return The bytes of the assignees at the given index.
   */
  com.google.protobuf.ByteString
      getAssigneesBytes(int index);

  /**
   * <pre>
   * Identifier that's used to track the given finding in the external system.
   * </pre>
   *
   * <code>string external_uid = 3;</code>
   * @return The externalUid.
   */
  java.lang.String getExternalUid();
  /**
   * <pre>
   * Identifier that's used to track the given finding in the external system.
   * </pre>
   *
   * <code>string external_uid = 3;</code>
   * @return The bytes for externalUid.
   */
  com.google.protobuf.ByteString
      getExternalUidBytes();

  /**
   * <pre>
   * Most recent status of the corresponding finding's ticket/tracker in the
   * external system.
   * </pre>
   *
   * <code>string status = 4;</code>
   * @return The status.
   */
  java.lang.String getStatus();
  /**
   * <pre>
   * Most recent status of the corresponding finding's ticket/tracker in the
   * external system.
   * </pre>
   *
   * <code>string status = 4;</code>
   * @return The bytes for status.
   */
  com.google.protobuf.ByteString
      getStatusBytes();

  /**
   * <pre>
   * The most recent time when the corresponding finding's ticket/tracker was
   * updated in the external system.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp external_system_update_time = 5;</code>
   * @return Whether the externalSystemUpdateTime field is set.
   */
  boolean hasExternalSystemUpdateTime();
  /**
   * <pre>
   * The most recent time when the corresponding finding's ticket/tracker was
   * updated in the external system.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp external_system_update_time = 5;</code>
   * @return The externalSystemUpdateTime.
   */
  com.google.protobuf.Timestamp getExternalSystemUpdateTime();
  /**
   * <pre>
   * The most recent time when the corresponding finding's ticket/tracker was
   * updated in the external system.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp external_system_update_time = 5;</code>
   */
  com.google.protobuf.TimestampOrBuilder getExternalSystemUpdateTimeOrBuilder();
}
