// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/recaptchaenterprise/v1/recaptchaenterprise.proto

package com.google.recaptchaenterprise.v1;

public interface SearchRelatedAccountGroupMembershipsResponseOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.recaptchaenterprise.v1.SearchRelatedAccountGroupMembershipsResponse)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The queried memberships.
   * </pre>
   *
   * <code>repeated .google.cloud.recaptchaenterprise.v1.RelatedAccountGroupMembership related_account_group_memberships = 1;</code>
   */
  java.util.List<com.google.recaptchaenterprise.v1.RelatedAccountGroupMembership> 
      getRelatedAccountGroupMembershipsList();
  /**
   * <pre>
   * The queried memberships.
   * </pre>
   *
   * <code>repeated .google.cloud.recaptchaenterprise.v1.RelatedAccountGroupMembership related_account_group_memberships = 1;</code>
   */
  com.google.recaptchaenterprise.v1.RelatedAccountGroupMembership getRelatedAccountGroupMemberships(int index);
  /**
   * <pre>
   * The queried memberships.
   * </pre>
   *
   * <code>repeated .google.cloud.recaptchaenterprise.v1.RelatedAccountGroupMembership related_account_group_memberships = 1;</code>
   */
  int getRelatedAccountGroupMembershipsCount();
  /**
   * <pre>
   * The queried memberships.
   * </pre>
   *
   * <code>repeated .google.cloud.recaptchaenterprise.v1.RelatedAccountGroupMembership related_account_group_memberships = 1;</code>
   */
  java.util.List<? extends com.google.recaptchaenterprise.v1.RelatedAccountGroupMembershipOrBuilder> 
      getRelatedAccountGroupMembershipsOrBuilderList();
  /**
   * <pre>
   * The queried memberships.
   * </pre>
   *
   * <code>repeated .google.cloud.recaptchaenterprise.v1.RelatedAccountGroupMembership related_account_group_memberships = 1;</code>
   */
  com.google.recaptchaenterprise.v1.RelatedAccountGroupMembershipOrBuilder getRelatedAccountGroupMembershipsOrBuilder(
      int index);

  /**
   * <pre>
   * A token, which can be sent as `page_token` to retrieve the next page.
   * If this field is omitted, there are no subsequent pages.
   * </pre>
   *
   * <code>string next_page_token = 2;</code>
   * @return The nextPageToken.
   */
  java.lang.String getNextPageToken();
  /**
   * <pre>
   * A token, which can be sent as `page_token` to retrieve the next page.
   * If this field is omitted, there are no subsequent pages.
   * </pre>
   *
   * <code>string next_page_token = 2;</code>
   * @return The bytes for nextPageToken.
   */
  com.google.protobuf.ByteString
      getNextPageTokenBytes();
}
