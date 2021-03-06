// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/networksecurity/v1beta1/tls.proto

package com.google.cloud.networksecurity.v1beta1;

public interface GrpcEndpointOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.networksecurity.v1beta1.GrpcEndpoint)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The target URI of the gRPC endpoint. Only UDS path is supported, and
   * should start with “unix:”.
   * </pre>
   *
   * <code>string target_uri = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The targetUri.
   */
  java.lang.String getTargetUri();
  /**
   * <pre>
   * Required. The target URI of the gRPC endpoint. Only UDS path is supported, and
   * should start with “unix:”.
   * </pre>
   *
   * <code>string target_uri = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for targetUri.
   */
  com.google.protobuf.ByteString
      getTargetUriBytes();
}
