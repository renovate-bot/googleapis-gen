// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/talent/v4/tenant_service.proto

package com.google.cloud.talent.v4;

public interface GetTenantRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.talent.v4.GetTenantRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The resource name of the tenant to be retrieved.
   * The format is "projects/{project_id}/tenants/{tenant_id}", for example,
   * "projects/foo/tenants/bar".
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The name.
   */
  java.lang.String getName();
  /**
   * <pre>
   * Required. The resource name of the tenant to be retrieved.
   * The format is "projects/{project_id}/tenants/{tenant_id}", for example,
   * "projects/foo/tenants/bar".
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for name.
   */
  com.google.protobuf.ByteString
      getNameBytes();
}
