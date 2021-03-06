// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/api/servicemanagement/v1/servicemanager.proto

package com.google.api.servicemanagement.v1;

public interface SubmitConfigSourceRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.api.servicemanagement.v1.SubmitConfigSourceRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The name of the service.  See the [overview](https://cloud.google.com/service-management/overview)
   * for naming requirements.  For example: `example.googleapis.com`.
   * </pre>
   *
   * <code>string service_name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The serviceName.
   */
  java.lang.String getServiceName();
  /**
   * <pre>
   * Required. The name of the service.  See the [overview](https://cloud.google.com/service-management/overview)
   * for naming requirements.  For example: `example.googleapis.com`.
   * </pre>
   *
   * <code>string service_name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for serviceName.
   */
  com.google.protobuf.ByteString
      getServiceNameBytes();

  /**
   * <pre>
   * Required. The source configuration for the service.
   * </pre>
   *
   * <code>.google.api.servicemanagement.v1.ConfigSource config_source = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the configSource field is set.
   */
  boolean hasConfigSource();
  /**
   * <pre>
   * Required. The source configuration for the service.
   * </pre>
   *
   * <code>.google.api.servicemanagement.v1.ConfigSource config_source = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The configSource.
   */
  com.google.api.servicemanagement.v1.ConfigSource getConfigSource();
  /**
   * <pre>
   * Required. The source configuration for the service.
   * </pre>
   *
   * <code>.google.api.servicemanagement.v1.ConfigSource config_source = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.api.servicemanagement.v1.ConfigSourceOrBuilder getConfigSourceOrBuilder();

  /**
   * <pre>
   * Optional. If set, this will result in the generation of a
   * `google.api.Service` configuration based on the `ConfigSource` provided,
   * but the generated config and the sources will NOT be persisted.
   * </pre>
   *
   * <code>bool validate_only = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
   * @return The validateOnly.
   */
  boolean getValidateOnly();
}
