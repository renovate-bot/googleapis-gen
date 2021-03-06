// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/kms/v1/service.proto

package com.google.cloud.kms.v1;

public interface GetCryptoKeyRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.kms.v1.GetCryptoKeyRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The [name][google.cloud.kms.v1.CryptoKey.name] of the [CryptoKey][google.cloud.kms.v1.CryptoKey] to get.
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The name.
   */
  java.lang.String getName();
  /**
   * <pre>
   * Required. The [name][google.cloud.kms.v1.CryptoKey.name] of the [CryptoKey][google.cloud.kms.v1.CryptoKey] to get.
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for name.
   */
  com.google.protobuf.ByteString
      getNameBytes();
}
