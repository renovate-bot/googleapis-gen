// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/tpu/v1/cloud_tpu.proto

package com.google.cloud.tpu.v1;

public interface NetworkEndpointOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.tpu.v1.NetworkEndpoint)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The IP address of this network endpoint.
   * </pre>
   *
   * <code>string ip_address = 1;</code>
   * @return The ipAddress.
   */
  java.lang.String getIpAddress();
  /**
   * <pre>
   * The IP address of this network endpoint.
   * </pre>
   *
   * <code>string ip_address = 1;</code>
   * @return The bytes for ipAddress.
   */
  com.google.protobuf.ByteString
      getIpAddressBytes();

  /**
   * <pre>
   * The port of this network endpoint.
   * </pre>
   *
   * <code>int32 port = 2;</code>
   * @return The port.
   */
  int getPort();
}
