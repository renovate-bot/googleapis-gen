// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/appengine/v1/version.proto

package com.google.appengine.v1;

public interface CpuUtilizationOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.appengine.v1.CpuUtilization)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Period of time over which CPU utilization is calculated.
   * </pre>
   *
   * <code>.google.protobuf.Duration aggregation_window_length = 1;</code>
   * @return Whether the aggregationWindowLength field is set.
   */
  boolean hasAggregationWindowLength();
  /**
   * <pre>
   * Period of time over which CPU utilization is calculated.
   * </pre>
   *
   * <code>.google.protobuf.Duration aggregation_window_length = 1;</code>
   * @return The aggregationWindowLength.
   */
  com.google.protobuf.Duration getAggregationWindowLength();
  /**
   * <pre>
   * Period of time over which CPU utilization is calculated.
   * </pre>
   *
   * <code>.google.protobuf.Duration aggregation_window_length = 1;</code>
   */
  com.google.protobuf.DurationOrBuilder getAggregationWindowLengthOrBuilder();

  /**
   * <pre>
   * Target CPU utilization ratio to maintain when scaling. Must be between 0
   * and 1.
   * </pre>
   *
   * <code>double target_utilization = 2;</code>
   * @return The targetUtilization.
   */
  double getTargetUtilization();
}
