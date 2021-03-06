// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/gkehub/v1alpha2/membership.proto

package com.google.cloud.gkehub.v1alpha2;

public interface ListMembershipsResponseOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.gkehub.v1alpha2.ListMembershipsResponse)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The list of matching Memberships.
   * </pre>
   *
   * <code>repeated .google.cloud.gkehub.v1alpha2.Membership resources = 1;</code>
   */
  java.util.List<com.google.cloud.gkehub.v1alpha2.Membership> 
      getResourcesList();
  /**
   * <pre>
   * The list of matching Memberships.
   * </pre>
   *
   * <code>repeated .google.cloud.gkehub.v1alpha2.Membership resources = 1;</code>
   */
  com.google.cloud.gkehub.v1alpha2.Membership getResources(int index);
  /**
   * <pre>
   * The list of matching Memberships.
   * </pre>
   *
   * <code>repeated .google.cloud.gkehub.v1alpha2.Membership resources = 1;</code>
   */
  int getResourcesCount();
  /**
   * <pre>
   * The list of matching Memberships.
   * </pre>
   *
   * <code>repeated .google.cloud.gkehub.v1alpha2.Membership resources = 1;</code>
   */
  java.util.List<? extends com.google.cloud.gkehub.v1alpha2.MembershipOrBuilder> 
      getResourcesOrBuilderList();
  /**
   * <pre>
   * The list of matching Memberships.
   * </pre>
   *
   * <code>repeated .google.cloud.gkehub.v1alpha2.Membership resources = 1;</code>
   */
  com.google.cloud.gkehub.v1alpha2.MembershipOrBuilder getResourcesOrBuilder(
      int index);

  /**
   * <pre>
   * A token to request the next page of resources from the
   * `ListMemberships` method. The value of an empty string means that
   * there are no more resources to return.
   * </pre>
   *
   * <code>string next_page_token = 2;</code>
   * @return The nextPageToken.
   */
  java.lang.String getNextPageToken();
  /**
   * <pre>
   * A token to request the next page of resources from the
   * `ListMemberships` method. The value of an empty string means that
   * there are no more resources to return.
   * </pre>
   *
   * <code>string next_page_token = 2;</code>
   * @return The bytes for nextPageToken.
   */
  com.google.protobuf.ByteString
      getNextPageTokenBytes();

  /**
   * <pre>
   * List of locations that could not be reached while fetching this list.
   * </pre>
   *
   * <code>repeated string unreachable = 3;</code>
   * @return A list containing the unreachable.
   */
  java.util.List<java.lang.String>
      getUnreachableList();
  /**
   * <pre>
   * List of locations that could not be reached while fetching this list.
   * </pre>
   *
   * <code>repeated string unreachable = 3;</code>
   * @return The count of unreachable.
   */
  int getUnreachableCount();
  /**
   * <pre>
   * List of locations that could not be reached while fetching this list.
   * </pre>
   *
   * <code>repeated string unreachable = 3;</code>
   * @param index The index of the element to return.
   * @return The unreachable at the given index.
   */
  java.lang.String getUnreachable(int index);
  /**
   * <pre>
   * List of locations that could not be reached while fetching this list.
   * </pre>
   *
   * <code>repeated string unreachable = 3;</code>
   * @param index The index of the value to return.
   * @return The bytes of the unreachable at the given index.
   */
  com.google.protobuf.ByteString
      getUnreachableBytes(int index);
}
