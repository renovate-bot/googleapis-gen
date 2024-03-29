// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/domains/v1/domains.proto

package com.google.cloud.domains.v1;

public interface UpdateRegistrationRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.domains.v1.UpdateRegistrationRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Fields of the `Registration` to update.
   * </pre>
   *
   * <code>.google.cloud.domains.v1.Registration registration = 1;</code>
   * @return Whether the registration field is set.
   */
  boolean hasRegistration();
  /**
   * <pre>
   * Fields of the `Registration` to update.
   * </pre>
   *
   * <code>.google.cloud.domains.v1.Registration registration = 1;</code>
   * @return The registration.
   */
  com.google.cloud.domains.v1.Registration getRegistration();
  /**
   * <pre>
   * Fields of the `Registration` to update.
   * </pre>
   *
   * <code>.google.cloud.domains.v1.Registration registration = 1;</code>
   */
  com.google.cloud.domains.v1.RegistrationOrBuilder getRegistrationOrBuilder();

  /**
   * <pre>
   * Required. The field mask describing which fields to update as a comma-separated list.
   * For example, if only the labels are being updated, the `update_mask` is
   * `"labels"`.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the updateMask field is set.
   */
  boolean hasUpdateMask();
  /**
   * <pre>
   * Required. The field mask describing which fields to update as a comma-separated list.
   * For example, if only the labels are being updated, the `update_mask` is
   * `"labels"`.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The updateMask.
   */
  com.google.protobuf.FieldMask getUpdateMask();
  /**
   * <pre>
   * Required. The field mask describing which fields to update as a comma-separated list.
   * For example, if only the labels are being updated, the `update_mask` is
   * `"labels"`.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.protobuf.FieldMaskOrBuilder getUpdateMaskOrBuilder();
}
