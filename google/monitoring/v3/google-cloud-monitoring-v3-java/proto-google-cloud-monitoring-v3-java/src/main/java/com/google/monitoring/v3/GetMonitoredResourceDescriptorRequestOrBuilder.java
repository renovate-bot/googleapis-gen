// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/monitoring/v3/metric_service.proto

package com.google.monitoring.v3;

public interface GetMonitoredResourceDescriptorRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.monitoring.v3.GetMonitoredResourceDescriptorRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The monitored resource descriptor to get.  The format is:
   *     projects/[PROJECT_ID_OR_NUMBER]/monitoredResourceDescriptors/[RESOURCE_TYPE]
   * The `[RESOURCE_TYPE]` is a predefined type, such as
   * `cloudsql_database`.
   * </pre>
   *
   * <code>string name = 3 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The name.
   */
  java.lang.String getName();
  /**
   * <pre>
   * Required. The monitored resource descriptor to get.  The format is:
   *     projects/[PROJECT_ID_OR_NUMBER]/monitoredResourceDescriptors/[RESOURCE_TYPE]
   * The `[RESOURCE_TYPE]` is a predefined type, such as
   * `cloudsql_database`.
   * </pre>
   *
   * <code>string name = 3 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for name.
   */
  com.google.protobuf.ByteString
      getNameBytes();
}
