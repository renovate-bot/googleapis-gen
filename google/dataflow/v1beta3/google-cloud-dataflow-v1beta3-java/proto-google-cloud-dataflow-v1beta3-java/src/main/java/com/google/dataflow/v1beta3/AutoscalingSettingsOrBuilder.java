// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/dataflow/v1beta3/environment.proto

package com.google.dataflow.v1beta3;

public interface AutoscalingSettingsOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.dataflow.v1beta3.AutoscalingSettings)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The algorithm to use for autoscaling.
   * </pre>
   *
   * <code>.google.dataflow.v1beta3.AutoscalingAlgorithm algorithm = 1;</code>
   * @return The enum numeric value on the wire for algorithm.
   */
  int getAlgorithmValue();
  /**
   * <pre>
   * The algorithm to use for autoscaling.
   * </pre>
   *
   * <code>.google.dataflow.v1beta3.AutoscalingAlgorithm algorithm = 1;</code>
   * @return The algorithm.
   */
  com.google.dataflow.v1beta3.AutoscalingAlgorithm getAlgorithm();

  /**
   * <pre>
   * The maximum number of workers to cap scaling at.
   * </pre>
   *
   * <code>int32 max_num_workers = 2;</code>
   * @return The maxNumWorkers.
   */
  int getMaxNumWorkers();
}
