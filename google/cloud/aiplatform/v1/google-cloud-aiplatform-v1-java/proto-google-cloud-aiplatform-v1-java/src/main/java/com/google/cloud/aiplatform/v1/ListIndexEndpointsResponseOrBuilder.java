// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/aiplatform/v1/index_endpoint_service.proto

package com.google.cloud.aiplatform.v1;

public interface ListIndexEndpointsResponseOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.aiplatform.v1.ListIndexEndpointsResponse)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * List of IndexEndpoints in the requested page.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1.IndexEndpoint index_endpoints = 1;</code>
   */
  java.util.List<com.google.cloud.aiplatform.v1.IndexEndpoint> 
      getIndexEndpointsList();
  /**
   * <pre>
   * List of IndexEndpoints in the requested page.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1.IndexEndpoint index_endpoints = 1;</code>
   */
  com.google.cloud.aiplatform.v1.IndexEndpoint getIndexEndpoints(int index);
  /**
   * <pre>
   * List of IndexEndpoints in the requested page.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1.IndexEndpoint index_endpoints = 1;</code>
   */
  int getIndexEndpointsCount();
  /**
   * <pre>
   * List of IndexEndpoints in the requested page.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1.IndexEndpoint index_endpoints = 1;</code>
   */
  java.util.List<? extends com.google.cloud.aiplatform.v1.IndexEndpointOrBuilder> 
      getIndexEndpointsOrBuilderList();
  /**
   * <pre>
   * List of IndexEndpoints in the requested page.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1.IndexEndpoint index_endpoints = 1;</code>
   */
  com.google.cloud.aiplatform.v1.IndexEndpointOrBuilder getIndexEndpointsOrBuilder(
      int index);

  /**
   * <pre>
   * A token to retrieve next page of results.
   * Pass to [ListIndexEndpointsRequest.page_token][google.cloud.aiplatform.v1.ListIndexEndpointsRequest.page_token] to obtain that page.
   * </pre>
   *
   * <code>string next_page_token = 2;</code>
   * @return The nextPageToken.
   */
  java.lang.String getNextPageToken();
  /**
   * <pre>
   * A token to retrieve next page of results.
   * Pass to [ListIndexEndpointsRequest.page_token][google.cloud.aiplatform.v1.ListIndexEndpointsRequest.page_token] to obtain that page.
   * </pre>
   *
   * <code>string next_page_token = 2;</code>
   * @return The bytes for nextPageToken.
   */
  com.google.protobuf.ByteString
      getNextPageTokenBytes();
}
