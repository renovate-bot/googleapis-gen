// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/analytics/data/v1alpha/data.proto

package com.google.analytics.data.v1alpha;

public interface MetricHeaderOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.analytics.data.v1alpha.MetricHeader)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The metric's name.
   * </pre>
   *
   * <code>string name = 1;</code>
   * @return The name.
   */
  java.lang.String getName();
  /**
   * <pre>
   * The metric's name.
   * </pre>
   *
   * <code>string name = 1;</code>
   * @return The bytes for name.
   */
  com.google.protobuf.ByteString
      getNameBytes();

  /**
   * <pre>
   * The metric's data type.
   * </pre>
   *
   * <code>.google.analytics.data.v1alpha.MetricType type = 2;</code>
   * @return The enum numeric value on the wire for type.
   */
  int getTypeValue();
  /**
   * <pre>
   * The metric's data type.
   * </pre>
   *
   * <code>.google.analytics.data.v1alpha.MetricType type = 2;</code>
   * @return The type.
   */
  com.google.analytics.data.v1alpha.MetricType getType();
}
