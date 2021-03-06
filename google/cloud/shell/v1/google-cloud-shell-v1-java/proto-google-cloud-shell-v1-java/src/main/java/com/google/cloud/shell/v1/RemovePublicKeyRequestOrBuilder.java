// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/shell/v1/cloudshell.proto

package com.google.cloud.shell.v1;

public interface RemovePublicKeyRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.shell.v1.RemovePublicKeyRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Environment this key should be removed from, e.g.
   * `users/me/environments/default`.
   * </pre>
   *
   * <code>string environment = 1;</code>
   * @return The environment.
   */
  java.lang.String getEnvironment();
  /**
   * <pre>
   * Environment this key should be removed from, e.g.
   * `users/me/environments/default`.
   * </pre>
   *
   * <code>string environment = 1;</code>
   * @return The bytes for environment.
   */
  com.google.protobuf.ByteString
      getEnvironmentBytes();

  /**
   * <pre>
   * Key that should be removed from the environment.
   * </pre>
   *
   * <code>string key = 2;</code>
   * @return The key.
   */
  java.lang.String getKey();
  /**
   * <pre>
   * Key that should be removed from the environment.
   * </pre>
   *
   * <code>string key = 2;</code>
   * @return The bytes for key.
   */
  com.google.protobuf.ByteString
      getKeyBytes();
}
