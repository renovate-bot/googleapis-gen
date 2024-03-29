// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/aiplatform/v1/endpoint_service.proto

package com.google.cloud.aiplatform.v1;

public interface ListEndpointsResponseOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.aiplatform.v1.ListEndpointsResponse)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * List of Endpoints in the requested page.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1.Endpoint endpoints = 1;</code>
   */
  java.util.List<com.google.cloud.aiplatform.v1.Endpoint> 
      getEndpointsList();
  /**
   * <pre>
   * List of Endpoints in the requested page.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1.Endpoint endpoints = 1;</code>
   */
  com.google.cloud.aiplatform.v1.Endpoint getEndpoints(int index);
  /**
   * <pre>
   * List of Endpoints in the requested page.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1.Endpoint endpoints = 1;</code>
   */
  int getEndpointsCount();
  /**
   * <pre>
   * List of Endpoints in the requested page.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1.Endpoint endpoints = 1;</code>
   */
  java.util.List<? extends com.google.cloud.aiplatform.v1.EndpointOrBuilder> 
      getEndpointsOrBuilderList();
  /**
   * <pre>
   * List of Endpoints in the requested page.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1.Endpoint endpoints = 1;</code>
   */
  com.google.cloud.aiplatform.v1.EndpointOrBuilder getEndpointsOrBuilder(
      int index);

  /**
   * <pre>
   * A token to retrieve the next page of results.
   * Pass to [ListEndpointsRequest.page_token][google.cloud.aiplatform.v1.ListEndpointsRequest.page_token] to obtain that page.
   * </pre>
   *
   * <code>string next_page_token = 2;</code>
   * @return The nextPageToken.
   */
  java.lang.String getNextPageToken();
  /**
   * <pre>
   * A token to retrieve the next page of results.
   * Pass to [ListEndpointsRequest.page_token][google.cloud.aiplatform.v1.ListEndpointsRequest.page_token] to obtain that page.
   * </pre>
   *
   * <code>string next_page_token = 2;</code>
   * @return The bytes for nextPageToken.
   */
  com.google.protobuf.ByteString
      getNextPageTokenBytes();
}
