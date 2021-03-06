// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/devtools/cloudbuild/v1/cloudbuild.proto

package com.google.cloudbuild.v1;

public interface HashOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.devtools.cloudbuild.v1.Hash)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The type of hash that was performed.
   * </pre>
   *
   * <code>.google.devtools.cloudbuild.v1.Hash.HashType type = 1;</code>
   * @return The enum numeric value on the wire for type.
   */
  int getTypeValue();
  /**
   * <pre>
   * The type of hash that was performed.
   * </pre>
   *
   * <code>.google.devtools.cloudbuild.v1.Hash.HashType type = 1;</code>
   * @return The type.
   */
  com.google.cloudbuild.v1.Hash.HashType getType();

  /**
   * <pre>
   * The hash value.
   * </pre>
   *
   * <code>bytes value = 2;</code>
   * @return The value.
   */
  com.google.protobuf.ByteString getValue();
}
