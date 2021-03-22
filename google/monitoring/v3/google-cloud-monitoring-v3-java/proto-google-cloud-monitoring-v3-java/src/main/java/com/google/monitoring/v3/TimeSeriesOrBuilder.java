// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/monitoring/v3/metric.proto

package com.google.monitoring.v3;

public interface TimeSeriesOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.monitoring.v3.TimeSeries)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The associated metric. A fully-specified metric used to identify the time
   * series.
   * </pre>
   *
   * <code>.google.api.Metric metric = 1;</code>
   * @return Whether the metric field is set.
   */
  boolean hasMetric();
  /**
   * <pre>
   * The associated metric. A fully-specified metric used to identify the time
   * series.
   * </pre>
   *
   * <code>.google.api.Metric metric = 1;</code>
   * @return The metric.
   */
  com.google.api.Metric getMetric();
  /**
   * <pre>
   * The associated metric. A fully-specified metric used to identify the time
   * series.
   * </pre>
   *
   * <code>.google.api.Metric metric = 1;</code>
   */
  com.google.api.MetricOrBuilder getMetricOrBuilder();

  /**
   * <pre>
   * The associated monitored resource.  Custom metrics can use only certain
   * monitored resource types in their time series data.
   * </pre>
   *
   * <code>.google.api.MonitoredResource resource = 2;</code>
   * @return Whether the resource field is set.
   */
  boolean hasResource();
  /**
   * <pre>
   * The associated monitored resource.  Custom metrics can use only certain
   * monitored resource types in their time series data.
   * </pre>
   *
   * <code>.google.api.MonitoredResource resource = 2;</code>
   * @return The resource.
   */
  com.google.api.MonitoredResource getResource();
  /**
   * <pre>
   * The associated monitored resource.  Custom metrics can use only certain
   * monitored resource types in their time series data.
   * </pre>
   *
   * <code>.google.api.MonitoredResource resource = 2;</code>
   */
  com.google.api.MonitoredResourceOrBuilder getResourceOrBuilder();

  /**
   * <pre>
   * Output only. The associated monitored resource metadata. When reading a
   * time series, this field will include metadata labels that are explicitly
   * named in the reduction. When creating a time series, this field is ignored.
   * </pre>
   *
   * <code>.google.api.MonitoredResourceMetadata metadata = 7;</code>
   * @return Whether the metadata field is set.
   */
  boolean hasMetadata();
  /**
   * <pre>
   * Output only. The associated monitored resource metadata. When reading a
   * time series, this field will include metadata labels that are explicitly
   * named in the reduction. When creating a time series, this field is ignored.
   * </pre>
   *
   * <code>.google.api.MonitoredResourceMetadata metadata = 7;</code>
   * @return The metadata.
   */
  com.google.api.MonitoredResourceMetadata getMetadata();
  /**
   * <pre>
   * Output only. The associated monitored resource metadata. When reading a
   * time series, this field will include metadata labels that are explicitly
   * named in the reduction. When creating a time series, this field is ignored.
   * </pre>
   *
   * <code>.google.api.MonitoredResourceMetadata metadata = 7;</code>
   */
  com.google.api.MonitoredResourceMetadataOrBuilder getMetadataOrBuilder();

  /**
   * <pre>
   * The metric kind of the time series. When listing time series, this metric
   * kind might be different from the metric kind of the associated metric if
   * this time series is an alignment or reduction of other time series.
   * When creating a time series, this field is optional. If present, it must be
   * the same as the metric kind of the associated metric. If the associated
   * metric's descriptor must be auto-created, then this field specifies the
   * metric kind of the new descriptor and must be either `GAUGE` (the default)
   * or `CUMULATIVE`.
   * </pre>
   *
   * <code>.google.api.MetricDescriptor.MetricKind metric_kind = 3;</code>
   * @return The enum numeric value on the wire for metricKind.
   */
  int getMetricKindValue();
  /**
   * <pre>
   * The metric kind of the time series. When listing time series, this metric
   * kind might be different from the metric kind of the associated metric if
   * this time series is an alignment or reduction of other time series.
   * When creating a time series, this field is optional. If present, it must be
   * the same as the metric kind of the associated metric. If the associated
   * metric's descriptor must be auto-created, then this field specifies the
   * metric kind of the new descriptor and must be either `GAUGE` (the default)
   * or `CUMULATIVE`.
   * </pre>
   *
   * <code>.google.api.MetricDescriptor.MetricKind metric_kind = 3;</code>
   * @return The metricKind.
   */
  com.google.api.MetricDescriptor.MetricKind getMetricKind();

  /**
   * <pre>
   * The value type of the time series. When listing time series, this value
   * type might be different from the value type of the associated metric if
   * this time series is an alignment or reduction of other time series.
   * When creating a time series, this field is optional. If present, it must be
   * the same as the type of the data in the `points` field.
   * </pre>
   *
   * <code>.google.api.MetricDescriptor.ValueType value_type = 4;</code>
   * @return The enum numeric value on the wire for valueType.
   */
  int getValueTypeValue();
  /**
   * <pre>
   * The value type of the time series. When listing time series, this value
   * type might be different from the value type of the associated metric if
   * this time series is an alignment or reduction of other time series.
   * When creating a time series, this field is optional. If present, it must be
   * the same as the type of the data in the `points` field.
   * </pre>
   *
   * <code>.google.api.MetricDescriptor.ValueType value_type = 4;</code>
   * @return The valueType.
   */
  com.google.api.MetricDescriptor.ValueType getValueType();

  /**
   * <pre>
   * The data points of this time series. When listing time series, points are
   * returned in reverse time order.
   * When creating a time series, this field must contain exactly one point and
   * the point's type must be the same as the value type of the associated
   * metric. If the associated metric's descriptor must be auto-created, then
   * the value type of the descriptor is determined by the point's type, which
   * must be `BOOL`, `INT64`, `DOUBLE`, or `DISTRIBUTION`.
   * </pre>
   *
   * <code>repeated .google.monitoring.v3.Point points = 5;</code>
   */
  java.util.List<com.google.monitoring.v3.Point> 
      getPointsList();
  /**
   * <pre>
   * The data points of this time series. When listing time series, points are
   * returned in reverse time order.
   * When creating a time series, this field must contain exactly one point and
   * the point's type must be the same as the value type of the associated
   * metric. If the associated metric's descriptor must be auto-created, then
   * the value type of the descriptor is determined by the point's type, which
   * must be `BOOL`, `INT64`, `DOUBLE`, or `DISTRIBUTION`.
   * </pre>
   *
   * <code>repeated .google.monitoring.v3.Point points = 5;</code>
   */
  com.google.monitoring.v3.Point getPoints(int index);
  /**
   * <pre>
   * The data points of this time series. When listing time series, points are
   * returned in reverse time order.
   * When creating a time series, this field must contain exactly one point and
   * the point's type must be the same as the value type of the associated
   * metric. If the associated metric's descriptor must be auto-created, then
   * the value type of the descriptor is determined by the point's type, which
   * must be `BOOL`, `INT64`, `DOUBLE`, or `DISTRIBUTION`.
   * </pre>
   *
   * <code>repeated .google.monitoring.v3.Point points = 5;</code>
   */
  int getPointsCount();
  /**
   * <pre>
   * The data points of this time series. When listing time series, points are
   * returned in reverse time order.
   * When creating a time series, this field must contain exactly one point and
   * the point's type must be the same as the value type of the associated
   * metric. If the associated metric's descriptor must be auto-created, then
   * the value type of the descriptor is determined by the point's type, which
   * must be `BOOL`, `INT64`, `DOUBLE`, or `DISTRIBUTION`.
   * </pre>
   *
   * <code>repeated .google.monitoring.v3.Point points = 5;</code>
   */
  java.util.List<? extends com.google.monitoring.v3.PointOrBuilder> 
      getPointsOrBuilderList();
  /**
   * <pre>
   * The data points of this time series. When listing time series, points are
   * returned in reverse time order.
   * When creating a time series, this field must contain exactly one point and
   * the point's type must be the same as the value type of the associated
   * metric. If the associated metric's descriptor must be auto-created, then
   * the value type of the descriptor is determined by the point's type, which
   * must be `BOOL`, `INT64`, `DOUBLE`, or `DISTRIBUTION`.
   * </pre>
   *
   * <code>repeated .google.monitoring.v3.Point points = 5;</code>
   */
  com.google.monitoring.v3.PointOrBuilder getPointsOrBuilder(
      int index);

  /**
   * <pre>
   * The units in which the metric value is reported. It is only applicable
   * if the `value_type` is `INT64`, `DOUBLE`, or `DISTRIBUTION`. The `unit`
   * defines the representation of the stored metric values.
   * </pre>
   *
   * <code>string unit = 8;</code>
   * @return The unit.
   */
  java.lang.String getUnit();
  /**
   * <pre>
   * The units in which the metric value is reported. It is only applicable
   * if the `value_type` is `INT64`, `DOUBLE`, or `DISTRIBUTION`. The `unit`
   * defines the representation of the stored metric values.
   * </pre>
   *
   * <code>string unit = 8;</code>
   * @return The bytes for unit.
   */
  com.google.protobuf.ByteString
      getUnitBytes();
}
