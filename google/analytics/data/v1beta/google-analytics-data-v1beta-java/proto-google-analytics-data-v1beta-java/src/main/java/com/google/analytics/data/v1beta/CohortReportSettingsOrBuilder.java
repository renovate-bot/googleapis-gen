// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/analytics/data/v1beta/data.proto

package com.google.analytics.data.v1beta;

public interface CohortReportSettingsOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.analytics.data.v1beta.CohortReportSettings)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * If true, accumulates the result from first touch day to the end day. Not
   * supported in `RunReportRequest`.
   * </pre>
   *
   * <code>bool accumulate = 1;</code>
   * @return The accumulate.
   */
  boolean getAccumulate();
}
