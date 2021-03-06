// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/lifesciences/v2beta/workflows.proto

package com.google.cloud.lifesciences.v2beta;

public interface DelayedEventOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.lifesciences.v2beta.DelayedEvent)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * A textual description of the cause of the delay. The string can change
   * without notice because it is often generated by another service (such as
   * Compute Engine).
   * </pre>
   *
   * <code>string cause = 1;</code>
   * @return The cause.
   */
  java.lang.String getCause();
  /**
   * <pre>
   * A textual description of the cause of the delay. The string can change
   * without notice because it is often generated by another service (such as
   * Compute Engine).
   * </pre>
   *
   * <code>string cause = 1;</code>
   * @return The bytes for cause.
   */
  com.google.protobuf.ByteString
      getCauseBytes();

  /**
   * <pre>
   * If the delay was caused by a resource shortage, this field lists the
   * Compute Engine metrics that are preventing this operation from running
   * (for example, `CPUS` or `INSTANCES`). If the particular metric is not
   * known, a single `UNKNOWN` metric will be present.
   * </pre>
   *
   * <code>repeated string metrics = 2;</code>
   * @return A list containing the metrics.
   */
  java.util.List<java.lang.String>
      getMetricsList();
  /**
   * <pre>
   * If the delay was caused by a resource shortage, this field lists the
   * Compute Engine metrics that are preventing this operation from running
   * (for example, `CPUS` or `INSTANCES`). If the particular metric is not
   * known, a single `UNKNOWN` metric will be present.
   * </pre>
   *
   * <code>repeated string metrics = 2;</code>
   * @return The count of metrics.
   */
  int getMetricsCount();
  /**
   * <pre>
   * If the delay was caused by a resource shortage, this field lists the
   * Compute Engine metrics that are preventing this operation from running
   * (for example, `CPUS` or `INSTANCES`). If the particular metric is not
   * known, a single `UNKNOWN` metric will be present.
   * </pre>
   *
   * <code>repeated string metrics = 2;</code>
   * @param index The index of the element to return.
   * @return The metrics at the given index.
   */
  java.lang.String getMetrics(int index);
  /**
   * <pre>
   * If the delay was caused by a resource shortage, this field lists the
   * Compute Engine metrics that are preventing this operation from running
   * (for example, `CPUS` or `INSTANCES`). If the particular metric is not
   * known, a single `UNKNOWN` metric will be present.
   * </pre>
   *
   * <code>repeated string metrics = 2;</code>
   * @param index The index of the value to return.
   * @return The bytes of the metrics at the given index.
   */
  com.google.protobuf.ByteString
      getMetricsBytes(int index);
}
