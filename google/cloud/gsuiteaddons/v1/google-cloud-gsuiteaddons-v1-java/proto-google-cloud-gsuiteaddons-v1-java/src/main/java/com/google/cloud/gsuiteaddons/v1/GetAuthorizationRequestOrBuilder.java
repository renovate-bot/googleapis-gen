// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/gsuiteaddons/v1/gsuiteaddons.proto

package com.google.cloud.gsuiteaddons.v1;

public interface GetAuthorizationRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.gsuiteaddons.v1.GetAuthorizationRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. Name of the project for which to get the Google Workspace Add-ons
   * authorization information.
   * Example: `projects/my_project/authorization`.
   * </pre>
   *
   * <code>string name = 2 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The name.
   */
  java.lang.String getName();
  /**
   * <pre>
   * Required. Name of the project for which to get the Google Workspace Add-ons
   * authorization information.
   * Example: `projects/my_project/authorization`.
   * </pre>
   *
   * <code>string name = 2 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for name.
   */
  com.google.protobuf.ByteString
      getNameBytes();
}