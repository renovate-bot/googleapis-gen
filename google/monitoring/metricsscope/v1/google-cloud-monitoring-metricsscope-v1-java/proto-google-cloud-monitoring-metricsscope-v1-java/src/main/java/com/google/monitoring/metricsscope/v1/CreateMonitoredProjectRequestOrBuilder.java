// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/monitoring/metricsscope/v1/metrics_scopes.proto

package com.google.monitoring.metricsscope.v1;

public interface CreateMonitoredProjectRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.monitoring.metricsscope.v1.CreateMonitoredProjectRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The resource name of the existing `Metrics Scope` that will monitor this
   * project.
   * Example:
   * `locations/global/metricsScopes/{SCOPING_PROJECT_ID_OR_NUMBER}`
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The parent.
   */
  java.lang.String getParent();
  /**
   * <pre>
   * Required. The resource name of the existing `Metrics Scope` that will monitor this
   * project.
   * Example:
   * `locations/global/metricsScopes/{SCOPING_PROJECT_ID_OR_NUMBER}`
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for parent.
   */
  com.google.protobuf.ByteString
      getParentBytes();

  /**
   * <pre>
   * Required. The initial `MonitoredProject` configuration.
   * Specify only the `monitored_project.name` field. All other fields are
   * ignored. The `monitored_project.name` must be in the format:
   * `locations/global/metricsScopes/{SCOPING_PROJECT_ID_OR_NUMBER}/projects/{MONITORED_PROJECT_ID_OR_NUMBER}`
   * </pre>
   *
   * <code>.google.monitoring.metricsscope.v1.MonitoredProject monitored_project = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the monitoredProject field is set.
   */
  boolean hasMonitoredProject();
  /**
   * <pre>
   * Required. The initial `MonitoredProject` configuration.
   * Specify only the `monitored_project.name` field. All other fields are
   * ignored. The `monitored_project.name` must be in the format:
   * `locations/global/metricsScopes/{SCOPING_PROJECT_ID_OR_NUMBER}/projects/{MONITORED_PROJECT_ID_OR_NUMBER}`
   * </pre>
   *
   * <code>.google.monitoring.metricsscope.v1.MonitoredProject monitored_project = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The monitoredProject.
   */
  com.google.monitoring.metricsscope.v1.MonitoredProject getMonitoredProject();
  /**
   * <pre>
   * Required. The initial `MonitoredProject` configuration.
   * Specify only the `monitored_project.name` field. All other fields are
   * ignored. The `monitored_project.name` must be in the format:
   * `locations/global/metricsScopes/{SCOPING_PROJECT_ID_OR_NUMBER}/projects/{MONITORED_PROJECT_ID_OR_NUMBER}`
   * </pre>
   *
   * <code>.google.monitoring.metricsscope.v1.MonitoredProject monitored_project = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.monitoring.metricsscope.v1.MonitoredProjectOrBuilder getMonitoredProjectOrBuilder();
}
