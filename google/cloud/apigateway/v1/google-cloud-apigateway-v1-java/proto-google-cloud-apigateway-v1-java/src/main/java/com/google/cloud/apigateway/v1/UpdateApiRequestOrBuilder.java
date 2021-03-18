// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/apigateway/v1/apigateway.proto

package com.google.cloud.apigateway.v1;

public interface UpdateApiRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.apigateway.v1.UpdateApiRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Field mask is used to specify the fields to be overwritten in the
   * Api resource by the update.
   * The fields specified in the update_mask are relative to the resource, not
   * the full request. A field will be overwritten if it is in the mask. If the
   * user does not provide a mask then all fields will be overwritten.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 1;</code>
   * @return Whether the updateMask field is set.
   */
  boolean hasUpdateMask();
  /**
   * <pre>
   * Field mask is used to specify the fields to be overwritten in the
   * Api resource by the update.
   * The fields specified in the update_mask are relative to the resource, not
   * the full request. A field will be overwritten if it is in the mask. If the
   * user does not provide a mask then all fields will be overwritten.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 1;</code>
   * @return The updateMask.
   */
  com.google.protobuf.FieldMask getUpdateMask();
  /**
   * <pre>
   * Field mask is used to specify the fields to be overwritten in the
   * Api resource by the update.
   * The fields specified in the update_mask are relative to the resource, not
   * the full request. A field will be overwritten if it is in the mask. If the
   * user does not provide a mask then all fields will be overwritten.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 1;</code>
   */
  com.google.protobuf.FieldMaskOrBuilder getUpdateMaskOrBuilder();

  /**
   * <pre>
   * Required. API resource.
   * </pre>
   *
   * <code>.google.cloud.apigateway.v1.Api api = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the api field is set.
   */
  boolean hasApi();
  /**
   * <pre>
   * Required. API resource.
   * </pre>
   *
   * <code>.google.cloud.apigateway.v1.Api api = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The api.
   */
  com.google.cloud.apigateway.v1.Api getApi();
  /**
   * <pre>
   * Required. API resource.
   * </pre>
   *
   * <code>.google.cloud.apigateway.v1.Api api = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.cloud.apigateway.v1.ApiOrBuilder getApiOrBuilder();
}
