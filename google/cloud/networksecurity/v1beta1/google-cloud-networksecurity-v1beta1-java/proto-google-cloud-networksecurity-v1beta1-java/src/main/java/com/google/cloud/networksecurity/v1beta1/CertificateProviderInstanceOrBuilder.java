// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/networksecurity/v1beta1/tls.proto

package com.google.cloud.networksecurity.v1beta1;

public interface CertificateProviderInstanceOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.networksecurity.v1beta1.CertificateProviderInstance)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. Plugin instance name, used to locate and load CertificateProvider instance
   * configuration. Set to "google_cloud_private_spiffe" to use Certificate
   * Authority Service certificate provider instance.
   * </pre>
   *
   * <code>string plugin_instance = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The pluginInstance.
   */
  java.lang.String getPluginInstance();
  /**
   * <pre>
   * Required. Plugin instance name, used to locate and load CertificateProvider instance
   * configuration. Set to "google_cloud_private_spiffe" to use Certificate
   * Authority Service certificate provider instance.
   * </pre>
   *
   * <code>string plugin_instance = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for pluginInstance.
   */
  com.google.protobuf.ByteString
      getPluginInstanceBytes();
}
