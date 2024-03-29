// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/networkconnectivity/v1/hub.proto

package com.google.cloud.networkconnectivity.v1;

public interface ListSpokesResponseOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.networkconnectivity.v1.ListSpokesResponse)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The requested spokes.
   * </pre>
   *
   * <code>repeated .google.cloud.networkconnectivity.v1.Spoke spokes = 1;</code>
   */
  java.util.List<com.google.cloud.networkconnectivity.v1.Spoke> 
      getSpokesList();
  /**
   * <pre>
   * The requested spokes.
   * </pre>
   *
   * <code>repeated .google.cloud.networkconnectivity.v1.Spoke spokes = 1;</code>
   */
  com.google.cloud.networkconnectivity.v1.Spoke getSpokes(int index);
  /**
   * <pre>
   * The requested spokes.
   * </pre>
   *
   * <code>repeated .google.cloud.networkconnectivity.v1.Spoke spokes = 1;</code>
   */
  int getSpokesCount();
  /**
   * <pre>
   * The requested spokes.
   * </pre>
   *
   * <code>repeated .google.cloud.networkconnectivity.v1.Spoke spokes = 1;</code>
   */
  java.util.List<? extends com.google.cloud.networkconnectivity.v1.SpokeOrBuilder> 
      getSpokesOrBuilderList();
  /**
   * <pre>
   * The requested spokes.
   * </pre>
   *
   * <code>repeated .google.cloud.networkconnectivity.v1.Spoke spokes = 1;</code>
   */
  com.google.cloud.networkconnectivity.v1.SpokeOrBuilder getSpokesOrBuilder(
      int index);

  /**
   * <pre>
   * The next pagination token in the List response. It should be used as
   * page_token for the following request. An empty value means no more result.
   * </pre>
   *
   * <code>string next_page_token = 2;</code>
   * @return The nextPageToken.
   */
  java.lang.String getNextPageToken();
  /**
   * <pre>
   * The next pagination token in the List response. It should be used as
   * page_token for the following request. An empty value means no more result.
   * </pre>
   *
   * <code>string next_page_token = 2;</code>
   * @return The bytes for nextPageToken.
   */
  com.google.protobuf.ByteString
      getNextPageTokenBytes();

  /**
   * <pre>
   * Locations that could not be reached.
   * </pre>
   *
   * <code>repeated string unreachable = 3;</code>
   * @return A list containing the unreachable.
   */
  java.util.List<java.lang.String>
      getUnreachableList();
  /**
   * <pre>
   * Locations that could not be reached.
   * </pre>
   *
   * <code>repeated string unreachable = 3;</code>
   * @return The count of unreachable.
   */
  int getUnreachableCount();
  /**
   * <pre>
   * Locations that could not be reached.
   * </pre>
   *
   * <code>repeated string unreachable = 3;</code>
   * @param index The index of the element to return.
   * @return The unreachable at the given index.
   */
  java.lang.String getUnreachable(int index);
  /**
   * <pre>
   * Locations that could not be reached.
   * </pre>
   *
   * <code>repeated string unreachable = 3;</code>
   * @param index The index of the value to return.
   * @return The bytes of the unreachable at the given index.
   */
  com.google.protobuf.ByteString
      getUnreachableBytes(int index);
}
