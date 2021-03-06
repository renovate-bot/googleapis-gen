// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/analytics/admin/v1alpha/analytics_admin.proto

package com.google.analytics.admin.v1alpha;

public interface CreateUserLinkRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.analytics.admin.v1alpha.CreateUserLinkRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. Example format: accounts/1234
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The parent.
   */
  java.lang.String getParent();
  /**
   * <pre>
   * Required. Example format: accounts/1234
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for parent.
   */
  com.google.protobuf.ByteString
      getParentBytes();

  /**
   * <pre>
   * Optional. If set, then email the new user notifying them that they've been granted
   * permissions to the resource.
   * </pre>
   *
   * <code>bool notify_new_user = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
   * @return The notifyNewUser.
   */
  boolean getNotifyNewUser();

  /**
   * <pre>
   * Required. The user link to create.
   * </pre>
   *
   * <code>.google.analytics.admin.v1alpha.UserLink user_link = 3 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the userLink field is set.
   */
  boolean hasUserLink();
  /**
   * <pre>
   * Required. The user link to create.
   * </pre>
   *
   * <code>.google.analytics.admin.v1alpha.UserLink user_link = 3 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The userLink.
   */
  com.google.analytics.admin.v1alpha.UserLink getUserLink();
  /**
   * <pre>
   * Required. The user link to create.
   * </pre>
   *
   * <code>.google.analytics.admin.v1alpha.UserLink user_link = 3 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.analytics.admin.v1alpha.UserLinkOrBuilder getUserLinkOrBuilder();
}
