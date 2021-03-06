// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/appengine/v1/audit_data.proto

package com.google.appengine.v1;

public interface AuditDataOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.appengine.v1.AuditData)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Detailed information about UpdateService call.
   * </pre>
   *
   * <code>.google.appengine.v1.UpdateServiceMethod update_service = 1;</code>
   * @return Whether the updateService field is set.
   */
  boolean hasUpdateService();
  /**
   * <pre>
   * Detailed information about UpdateService call.
   * </pre>
   *
   * <code>.google.appengine.v1.UpdateServiceMethod update_service = 1;</code>
   * @return The updateService.
   */
  com.google.appengine.v1.UpdateServiceMethod getUpdateService();
  /**
   * <pre>
   * Detailed information about UpdateService call.
   * </pre>
   *
   * <code>.google.appengine.v1.UpdateServiceMethod update_service = 1;</code>
   */
  com.google.appengine.v1.UpdateServiceMethodOrBuilder getUpdateServiceOrBuilder();

  /**
   * <pre>
   * Detailed information about CreateVersion call.
   * </pre>
   *
   * <code>.google.appengine.v1.CreateVersionMethod create_version = 2;</code>
   * @return Whether the createVersion field is set.
   */
  boolean hasCreateVersion();
  /**
   * <pre>
   * Detailed information about CreateVersion call.
   * </pre>
   *
   * <code>.google.appengine.v1.CreateVersionMethod create_version = 2;</code>
   * @return The createVersion.
   */
  com.google.appengine.v1.CreateVersionMethod getCreateVersion();
  /**
   * <pre>
   * Detailed information about CreateVersion call.
   * </pre>
   *
   * <code>.google.appengine.v1.CreateVersionMethod create_version = 2;</code>
   */
  com.google.appengine.v1.CreateVersionMethodOrBuilder getCreateVersionOrBuilder();

  public com.google.appengine.v1.AuditData.MethodCase getMethodCase();
}
