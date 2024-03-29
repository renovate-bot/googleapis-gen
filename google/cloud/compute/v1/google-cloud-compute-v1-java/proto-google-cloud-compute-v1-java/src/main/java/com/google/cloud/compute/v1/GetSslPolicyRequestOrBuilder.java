// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/compute/v1/compute.proto

package com.google.cloud.compute.v1;

public interface GetSslPolicyRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.compute.v1.GetSslPolicyRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Project ID for this request.
   * </pre>
   *
   * <code>string project = 227560217 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The project.
   */
  java.lang.String getProject();
  /**
   * <pre>
   * Project ID for this request.
   * </pre>
   *
   * <code>string project = 227560217 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for project.
   */
  com.google.protobuf.ByteString
      getProjectBytes();

  /**
   * <pre>
   * Name of the SSL policy to update. The name must be 1-63 characters long, and comply with RFC1035.
   * </pre>
   *
   * <code>string ssl_policy = 295190213 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The sslPolicy.
   */
  java.lang.String getSslPolicy();
  /**
   * <pre>
   * Name of the SSL policy to update. The name must be 1-63 characters long, and comply with RFC1035.
   * </pre>
   *
   * <code>string ssl_policy = 295190213 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for sslPolicy.
   */
  com.google.protobuf.ByteString
      getSslPolicyBytes();
}
