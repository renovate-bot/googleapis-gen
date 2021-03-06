// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/monitoring/v3/metric_service.proto

package com.google.monitoring.v3;

public interface CreateTimeSeriesErrorOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.monitoring.v3.CreateTimeSeriesError)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * DEPRECATED. Time series ID that resulted in the `status` error.
   * </pre>
   *
   * <code>.google.monitoring.v3.TimeSeries time_series = 1 [deprecated = true];</code>
   * @return Whether the timeSeries field is set.
   */
  @java.lang.Deprecated boolean hasTimeSeries();
  /**
   * <pre>
   * DEPRECATED. Time series ID that resulted in the `status` error.
   * </pre>
   *
   * <code>.google.monitoring.v3.TimeSeries time_series = 1 [deprecated = true];</code>
   * @return The timeSeries.
   */
  @java.lang.Deprecated com.google.monitoring.v3.TimeSeries getTimeSeries();
  /**
   * <pre>
   * DEPRECATED. Time series ID that resulted in the `status` error.
   * </pre>
   *
   * <code>.google.monitoring.v3.TimeSeries time_series = 1 [deprecated = true];</code>
   */
  @java.lang.Deprecated com.google.monitoring.v3.TimeSeriesOrBuilder getTimeSeriesOrBuilder();

  /**
   * <pre>
   * DEPRECATED. The status of the requested write operation for `time_series`.
   * </pre>
   *
   * <code>.google.rpc.Status status = 2 [deprecated = true];</code>
   * @return Whether the status field is set.
   */
  @java.lang.Deprecated boolean hasStatus();
  /**
   * <pre>
   * DEPRECATED. The status of the requested write operation for `time_series`.
   * </pre>
   *
   * <code>.google.rpc.Status status = 2 [deprecated = true];</code>
   * @return The status.
   */
  @java.lang.Deprecated com.google.rpc.Status getStatus();
  /**
   * <pre>
   * DEPRECATED. The status of the requested write operation for `time_series`.
   * </pre>
   *
   * <code>.google.rpc.Status status = 2 [deprecated = true];</code>
   */
  @java.lang.Deprecated com.google.rpc.StatusOrBuilder getStatusOrBuilder();
}
