// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/essentialcontacts/v1/service.proto

package com.google.cloud.essentialcontacts.v1;

public interface ComputeContactsResponseOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.essentialcontacts.v1.ComputeContactsResponse)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * All contacts for the resource that are subscribed to the specified
   * notification categories, including contacts inherited from any parent
   * resources.
   * </pre>
   *
   * <code>repeated .google.cloud.essentialcontacts.v1.Contact contacts = 1;</code>
   */
  java.util.List<com.google.cloud.essentialcontacts.v1.Contact> 
      getContactsList();
  /**
   * <pre>
   * All contacts for the resource that are subscribed to the specified
   * notification categories, including contacts inherited from any parent
   * resources.
   * </pre>
   *
   * <code>repeated .google.cloud.essentialcontacts.v1.Contact contacts = 1;</code>
   */
  com.google.cloud.essentialcontacts.v1.Contact getContacts(int index);
  /**
   * <pre>
   * All contacts for the resource that are subscribed to the specified
   * notification categories, including contacts inherited from any parent
   * resources.
   * </pre>
   *
   * <code>repeated .google.cloud.essentialcontacts.v1.Contact contacts = 1;</code>
   */
  int getContactsCount();
  /**
   * <pre>
   * All contacts for the resource that are subscribed to the specified
   * notification categories, including contacts inherited from any parent
   * resources.
   * </pre>
   *
   * <code>repeated .google.cloud.essentialcontacts.v1.Contact contacts = 1;</code>
   */
  java.util.List<? extends com.google.cloud.essentialcontacts.v1.ContactOrBuilder> 
      getContactsOrBuilderList();
  /**
   * <pre>
   * All contacts for the resource that are subscribed to the specified
   * notification categories, including contacts inherited from any parent
   * resources.
   * </pre>
   *
   * <code>repeated .google.cloud.essentialcontacts.v1.Contact contacts = 1;</code>
   */
  com.google.cloud.essentialcontacts.v1.ContactOrBuilder getContactsOrBuilder(
      int index);

  /**
   * <pre>
   * If there are more results than those appearing in this response, then
   * `next_page_token` is included. To get the next set of results, call this
   * method again using the value of `next_page_token` as `page_token` and the
   * rest of the parameters the same as the original request.
   * </pre>
   *
   * <code>string next_page_token = 2;</code>
   * @return The nextPageToken.
   */
  java.lang.String getNextPageToken();
  /**
   * <pre>
   * If there are more results than those appearing in this response, then
   * `next_page_token` is included. To get the next set of results, call this
   * method again using the value of `next_page_token` as `page_token` and the
   * rest of the parameters the same as the original request.
   * </pre>
   *
   * <code>string next_page_token = 2;</code>
   * @return The bytes for nextPageToken.
   */
  com.google.protobuf.ByteString
      getNextPageTokenBytes();
}
