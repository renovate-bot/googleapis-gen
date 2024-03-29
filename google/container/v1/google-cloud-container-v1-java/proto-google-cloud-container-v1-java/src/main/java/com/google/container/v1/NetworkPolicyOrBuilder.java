// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/container/v1/cluster_service.proto

package com.google.container.v1;

public interface NetworkPolicyOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.container.v1.NetworkPolicy)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The selected network policy provider.
   * </pre>
   *
   * <code>.google.container.v1.NetworkPolicy.Provider provider = 1;</code>
   * @return The enum numeric value on the wire for provider.
   */
  int getProviderValue();
  /**
   * <pre>
   * The selected network policy provider.
   * </pre>
   *
   * <code>.google.container.v1.NetworkPolicy.Provider provider = 1;</code>
   * @return The provider.
   */
  com.google.container.v1.NetworkPolicy.Provider getProvider();

  /**
   * <pre>
   * Whether network policy is enabled on the cluster.
   * </pre>
   *
   * <code>bool enabled = 2;</code>
   * @return The enabled.
   */
  boolean getEnabled();
}
