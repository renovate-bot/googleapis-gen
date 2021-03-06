// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/channel/v1/service.proto

package com.google.cloud.channel.v1;

public interface ListCustomersResponseOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.channel.v1.ListCustomersResponse)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The customers belonging to a reseller or distributor.
   * </pre>
   *
   * <code>repeated .google.cloud.channel.v1.Customer customers = 1;</code>
   */
  java.util.List<com.google.cloud.channel.v1.Customer> 
      getCustomersList();
  /**
   * <pre>
   * The customers belonging to a reseller or distributor.
   * </pre>
   *
   * <code>repeated .google.cloud.channel.v1.Customer customers = 1;</code>
   */
  com.google.cloud.channel.v1.Customer getCustomers(int index);
  /**
   * <pre>
   * The customers belonging to a reseller or distributor.
   * </pre>
   *
   * <code>repeated .google.cloud.channel.v1.Customer customers = 1;</code>
   */
  int getCustomersCount();
  /**
   * <pre>
   * The customers belonging to a reseller or distributor.
   * </pre>
   *
   * <code>repeated .google.cloud.channel.v1.Customer customers = 1;</code>
   */
  java.util.List<? extends com.google.cloud.channel.v1.CustomerOrBuilder> 
      getCustomersOrBuilderList();
  /**
   * <pre>
   * The customers belonging to a reseller or distributor.
   * </pre>
   *
   * <code>repeated .google.cloud.channel.v1.Customer customers = 1;</code>
   */
  com.google.cloud.channel.v1.CustomerOrBuilder getCustomersOrBuilder(
      int index);

  /**
   * <pre>
   * A token to retrieve the next page of results.
   * Pass to [ListCustomersRequest.page_token][google.cloud.channel.v1.ListCustomersRequest.page_token] to obtain that page.
   * </pre>
   *
   * <code>string next_page_token = 2;</code>
   * @return The nextPageToken.
   */
  java.lang.String getNextPageToken();
  /**
   * <pre>
   * A token to retrieve the next page of results.
   * Pass to [ListCustomersRequest.page_token][google.cloud.channel.v1.ListCustomersRequest.page_token] to obtain that page.
   * </pre>
   *
   * <code>string next_page_token = 2;</code>
   * @return The bytes for nextPageToken.
   */
  com.google.protobuf.ByteString
      getNextPageTokenBytes();
}
