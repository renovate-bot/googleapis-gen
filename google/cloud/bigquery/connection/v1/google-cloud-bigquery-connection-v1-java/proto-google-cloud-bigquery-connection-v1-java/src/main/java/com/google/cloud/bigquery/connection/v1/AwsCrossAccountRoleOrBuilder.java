// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/bigquery/connection/v1/connection.proto

package com.google.cloud.bigquery.connection.v1;

public interface AwsCrossAccountRoleOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.bigquery.connection.v1.AwsCrossAccountRole)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The user’s AWS IAM Role that trusts the Google-owned AWS IAM user
   * Connection.
   * </pre>
   *
   * <code>string iam_role_id = 1;</code>
   * @return The iamRoleId.
   */
  java.lang.String getIamRoleId();
  /**
   * <pre>
   * The user’s AWS IAM Role that trusts the Google-owned AWS IAM user
   * Connection.
   * </pre>
   *
   * <code>string iam_role_id = 1;</code>
   * @return The bytes for iamRoleId.
   */
  com.google.protobuf.ByteString
      getIamRoleIdBytes();

  /**
   * <pre>
   * Output only. Google-owned AWS IAM User for a Connection.
   * </pre>
   *
   * <code>string iam_user_id = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The iamUserId.
   */
  java.lang.String getIamUserId();
  /**
   * <pre>
   * Output only. Google-owned AWS IAM User for a Connection.
   * </pre>
   *
   * <code>string iam_user_id = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The bytes for iamUserId.
   */
  com.google.protobuf.ByteString
      getIamUserIdBytes();

  /**
   * <pre>
   * Output only. A Google-generated id for representing Connection’s identity in AWS.
   * External Id is also used for preventing the Confused Deputy Problem. See
   * https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_create_for-user_externalid.html
   * </pre>
   *
   * <code>string external_id = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The externalId.
   */
  java.lang.String getExternalId();
  /**
   * <pre>
   * Output only. A Google-generated id for representing Connection’s identity in AWS.
   * External Id is also used for preventing the Confused Deputy Problem. See
   * https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_create_for-user_externalid.html
   * </pre>
   *
   * <code>string external_id = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The bytes for externalId.
   */
  com.google.protobuf.ByteString
      getExternalIdBytes();
}
