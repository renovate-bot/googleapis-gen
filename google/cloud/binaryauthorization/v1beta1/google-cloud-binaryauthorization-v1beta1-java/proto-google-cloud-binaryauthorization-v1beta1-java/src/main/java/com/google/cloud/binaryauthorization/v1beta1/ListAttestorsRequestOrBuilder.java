// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/binaryauthorization/v1beta1/service.proto

package com.google.cloud.binaryauthorization.v1beta1;

public interface ListAttestorsRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.binaryauthorization.v1beta1.ListAttestorsRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The resource name of the project associated with the
   * [attestors][google.cloud.binaryauthorization.v1beta1.Attestor], in the
   * format `projects/&#42;`.
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The parent.
   */
  java.lang.String getParent();
  /**
   * <pre>
   * Required. The resource name of the project associated with the
   * [attestors][google.cloud.binaryauthorization.v1beta1.Attestor], in the
   * format `projects/&#42;`.
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for parent.
   */
  com.google.protobuf.ByteString
      getParentBytes();

  /**
   * <pre>
   * Requested page size. The server may return fewer results than requested. If
   * unspecified, the server will pick an appropriate default.
   * </pre>
   *
   * <code>int32 page_size = 2;</code>
   * @return The pageSize.
   */
  int getPageSize();

  /**
   * <pre>
   * A token identifying a page of results the server should return. Typically,
   * this is the value of
   * [ListAttestorsResponse.next_page_token][google.cloud.binaryauthorization.v1beta1.ListAttestorsResponse.next_page_token]
   * returned from the previous call to the `ListAttestors` method.
   * </pre>
   *
   * <code>string page_token = 3;</code>
   * @return The pageToken.
   */
  java.lang.String getPageToken();
  /**
   * <pre>
   * A token identifying a page of results the server should return. Typically,
   * this is the value of
   * [ListAttestorsResponse.next_page_token][google.cloud.binaryauthorization.v1beta1.ListAttestorsResponse.next_page_token]
   * returned from the previous call to the `ListAttestors` method.
   * </pre>
   *
   * <code>string page_token = 3;</code>
   * @return The bytes for pageToken.
   */
  com.google.protobuf.ByteString
      getPageTokenBytes();
}
