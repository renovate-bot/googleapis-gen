// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/home/enterprise/sdm/v1/smart_device_management_service.proto

package com.google.home.enterprise.sdm.v1;

public interface ListRoomsRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.home.enterprise.sdm.v1.ListRoomsRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The parent resource name of the rooms requested. For example:
   * "enterprises/XYZ/structures/ABC".
   * </pre>
   *
   * <code>string parent = 1;</code>
   * @return The parent.
   */
  java.lang.String getParent();
  /**
   * <pre>
   * The parent resource name of the rooms requested. For example:
   * "enterprises/XYZ/structures/ABC".
   * </pre>
   *
   * <code>string parent = 1;</code>
   * @return The bytes for parent.
   */
  com.google.protobuf.ByteString
      getParentBytes();

  /**
   * <pre>
   * Requested page size. Server may return fewer rooms than requested.
   * If unspecified, server will pick an appropriate default.
   * </pre>
   *
   * <code>int32 page_size = 2;</code>
   * @return The pageSize.
   */
  int getPageSize();

  /**
   * <pre>
   * The token of the page to retrieve.
   * </pre>
   *
   * <code>string page_token = 3;</code>
   * @return The pageToken.
   */
  java.lang.String getPageToken();
  /**
   * <pre>
   * The token of the page to retrieve.
   * </pre>
   *
   * <code>string page_token = 3;</code>
   * @return The bytes for pageToken.
   */
  com.google.protobuf.ByteString
      getPageTokenBytes();
}
