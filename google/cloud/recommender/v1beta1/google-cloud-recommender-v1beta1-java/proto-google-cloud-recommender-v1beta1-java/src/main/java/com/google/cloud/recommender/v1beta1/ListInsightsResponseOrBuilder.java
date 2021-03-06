// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/recommender/v1beta1/recommender_service.proto

package com.google.cloud.recommender.v1beta1;

public interface ListInsightsResponseOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.recommender.v1beta1.ListInsightsResponse)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The set of insights for the `parent` resource.
   * </pre>
   *
   * <code>repeated .google.cloud.recommender.v1beta1.Insight insights = 1;</code>
   */
  java.util.List<com.google.cloud.recommender.v1beta1.Insight> 
      getInsightsList();
  /**
   * <pre>
   * The set of insights for the `parent` resource.
   * </pre>
   *
   * <code>repeated .google.cloud.recommender.v1beta1.Insight insights = 1;</code>
   */
  com.google.cloud.recommender.v1beta1.Insight getInsights(int index);
  /**
   * <pre>
   * The set of insights for the `parent` resource.
   * </pre>
   *
   * <code>repeated .google.cloud.recommender.v1beta1.Insight insights = 1;</code>
   */
  int getInsightsCount();
  /**
   * <pre>
   * The set of insights for the `parent` resource.
   * </pre>
   *
   * <code>repeated .google.cloud.recommender.v1beta1.Insight insights = 1;</code>
   */
  java.util.List<? extends com.google.cloud.recommender.v1beta1.InsightOrBuilder> 
      getInsightsOrBuilderList();
  /**
   * <pre>
   * The set of insights for the `parent` resource.
   * </pre>
   *
   * <code>repeated .google.cloud.recommender.v1beta1.Insight insights = 1;</code>
   */
  com.google.cloud.recommender.v1beta1.InsightOrBuilder getInsightsOrBuilder(
      int index);

  /**
   * <pre>
   * A token that can be used to request the next page of results. This field is
   * empty if there are no additional results.
   * </pre>
   *
   * <code>string next_page_token = 2;</code>
   * @return The nextPageToken.
   */
  java.lang.String getNextPageToken();
  /**
   * <pre>
   * A token that can be used to request the next page of results. This field is
   * empty if there are no additional results.
   * </pre>
   *
   * <code>string next_page_token = 2;</code>
   * @return The bytes for nextPageToken.
   */
  com.google.protobuf.ByteString
      getNextPageTokenBytes();
}
