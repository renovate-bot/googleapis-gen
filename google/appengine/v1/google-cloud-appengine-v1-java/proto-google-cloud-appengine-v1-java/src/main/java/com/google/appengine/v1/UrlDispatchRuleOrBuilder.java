// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/appengine/v1/application.proto

package com.google.appengine.v1;

public interface UrlDispatchRuleOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.appengine.v1.UrlDispatchRule)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Domain name to match against. The wildcard "`*`" is supported if
   * specified before a period: "`*.`".
   * Defaults to matching all domains: "`*`".
   * </pre>
   *
   * <code>string domain = 1;</code>
   * @return The domain.
   */
  java.lang.String getDomain();
  /**
   * <pre>
   * Domain name to match against. The wildcard "`*`" is supported if
   * specified before a period: "`*.`".
   * Defaults to matching all domains: "`*`".
   * </pre>
   *
   * <code>string domain = 1;</code>
   * @return The bytes for domain.
   */
  com.google.protobuf.ByteString
      getDomainBytes();

  /**
   * <pre>
   * Pathname within the host. Must start with a "`/`". A
   * single "`*`" can be included at the end of the path.
   * The sum of the lengths of the domain and path may not
   * exceed 100 characters.
   * </pre>
   *
   * <code>string path = 2;</code>
   * @return The path.
   */
  java.lang.String getPath();
  /**
   * <pre>
   * Pathname within the host. Must start with a "`/`". A
   * single "`*`" can be included at the end of the path.
   * The sum of the lengths of the domain and path may not
   * exceed 100 characters.
   * </pre>
   *
   * <code>string path = 2;</code>
   * @return The bytes for path.
   */
  com.google.protobuf.ByteString
      getPathBytes();

  /**
   * <pre>
   * Resource ID of a service in this application that should
   * serve the matched request. The service must already
   * exist. Example: `default`.
   * </pre>
   *
   * <code>string service = 3;</code>
   * @return The service.
   */
  java.lang.String getService();
  /**
   * <pre>
   * Resource ID of a service in this application that should
   * serve the matched request. The service must already
   * exist. Example: `default`.
   * </pre>
   *
   * <code>string service = 3;</code>
   * @return The bytes for service.
   */
  com.google.protobuf.ByteString
      getServiceBytes();
}
