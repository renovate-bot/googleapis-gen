// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/metastore/v1alpha/metastore.proto

package com.google.cloud.metastore.v1alpha;

public interface MaintenanceWindowOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.metastore.v1alpha.MaintenanceWindow)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The hour of day (0-23) when the window starts.
   * </pre>
   *
   * <code>.google.protobuf.Int32Value hour_of_day = 1;</code>
   * @return Whether the hourOfDay field is set.
   */
  boolean hasHourOfDay();
  /**
   * <pre>
   * The hour of day (0-23) when the window starts.
   * </pre>
   *
   * <code>.google.protobuf.Int32Value hour_of_day = 1;</code>
   * @return The hourOfDay.
   */
  com.google.protobuf.Int32Value getHourOfDay();
  /**
   * <pre>
   * The hour of day (0-23) when the window starts.
   * </pre>
   *
   * <code>.google.protobuf.Int32Value hour_of_day = 1;</code>
   */
  com.google.protobuf.Int32ValueOrBuilder getHourOfDayOrBuilder();

  /**
   * <pre>
   * The day of week, when the window starts.
   * </pre>
   *
   * <code>.google.type.DayOfWeek day_of_week = 2;</code>
   * @return The enum numeric value on the wire for dayOfWeek.
   */
  int getDayOfWeekValue();
  /**
   * <pre>
   * The day of week, when the window starts.
   * </pre>
   *
   * <code>.google.type.DayOfWeek day_of_week = 2;</code>
   * @return The dayOfWeek.
   */
  com.google.type.DayOfWeek getDayOfWeek();
}
