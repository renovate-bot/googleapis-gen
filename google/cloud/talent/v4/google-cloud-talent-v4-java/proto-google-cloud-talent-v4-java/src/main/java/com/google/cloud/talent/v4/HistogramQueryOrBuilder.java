// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/talent/v4/histogram.proto

package com.google.cloud.talent.v4;

public interface HistogramQueryOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.talent.v4.HistogramQuery)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * An expression specifies a histogram request against matching jobs for
   * searches.
   * See [SearchJobsRequest.histogram_queries][google.cloud.talent.v4.SearchJobsRequest.histogram_queries] for details about syntax.
   * </pre>
   *
   * <code>string histogram_query = 1;</code>
   * @return The histogramQuery.
   */
  java.lang.String getHistogramQuery();
  /**
   * <pre>
   * An expression specifies a histogram request against matching jobs for
   * searches.
   * See [SearchJobsRequest.histogram_queries][google.cloud.talent.v4.SearchJobsRequest.histogram_queries] for details about syntax.
   * </pre>
   *
   * <code>string histogram_query = 1;</code>
   * @return The bytes for histogramQuery.
   */
  com.google.protobuf.ByteString
      getHistogramQueryBytes();
}
