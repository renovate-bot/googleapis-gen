// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/container/v1/cluster_service.proto

package com.google.container.v1;

public interface SandboxConfigOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.container.v1.SandboxConfig)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Type of the sandbox to use for the node.
   * </pre>
   *
   * <code>.google.container.v1.SandboxConfig.Type type = 2;</code>
   * @return The enum numeric value on the wire for type.
   */
  int getTypeValue();
  /**
   * <pre>
   * Type of the sandbox to use for the node.
   * </pre>
   *
   * <code>.google.container.v1.SandboxConfig.Type type = 2;</code>
   * @return The type.
   */
  com.google.container.v1.SandboxConfig.Type getType();
}
