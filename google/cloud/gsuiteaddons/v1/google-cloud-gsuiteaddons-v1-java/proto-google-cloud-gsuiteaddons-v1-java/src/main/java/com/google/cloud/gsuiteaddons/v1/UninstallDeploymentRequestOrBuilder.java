// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/gsuiteaddons/v1/gsuiteaddons.proto

package com.google.cloud.gsuiteaddons.v1;

public interface UninstallDeploymentRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.gsuiteaddons.v1.UninstallDeploymentRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The full resource name of the deployment to install.
   * Example:  `projects/my_project/deployments/my_deployment`.
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The name.
   */
  java.lang.String getName();
  /**
   * <pre>
   * Required. The full resource name of the deployment to install.
   * Example:  `projects/my_project/deployments/my_deployment`.
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for name.
   */
  com.google.protobuf.ByteString
      getNameBytes();
}