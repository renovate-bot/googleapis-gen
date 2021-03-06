// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/gkehub/v1beta1/membership.proto

package com.google.cloud.gkehub.v1beta1;

public interface ValidateExclusivityRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.gkehub.v1beta1.ValidateExclusivityRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The parent (project and location) where the Memberships will be created.
   * Specified in the format `projects/&#42;&#47;locations/&#42;`.
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The parent.
   */
  java.lang.String getParent();
  /**
   * <pre>
   * Required. The parent (project and location) where the Memberships will be created.
   * Specified in the format `projects/&#42;&#47;locations/&#42;`.
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for parent.
   */
  com.google.protobuf.ByteString
      getParentBytes();

  /**
   * <pre>
   * Optional. The YAML of the membership CR in the cluster. Empty if the membership
   * CR does not exist.
   * </pre>
   *
   * <code>string cr_manifest = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
   * @return The crManifest.
   */
  java.lang.String getCrManifest();
  /**
   * <pre>
   * Optional. The YAML of the membership CR in the cluster. Empty if the membership
   * CR does not exist.
   * </pre>
   *
   * <code>string cr_manifest = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
   * @return The bytes for crManifest.
   */
  com.google.protobuf.ByteString
      getCrManifestBytes();

  /**
   * <pre>
   * Required. The intended membership name under the `parent`. This method only does
   * validation in anticipation of a CreateMembership call with the same name.
   * </pre>
   *
   * <code>string intended_membership = 3 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The intendedMembership.
   */
  java.lang.String getIntendedMembership();
  /**
   * <pre>
   * Required. The intended membership name under the `parent`. This method only does
   * validation in anticipation of a CreateMembership call with the same name.
   * </pre>
   *
   * <code>string intended_membership = 3 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for intendedMembership.
   */
  com.google.protobuf.ByteString
      getIntendedMembershipBytes();
}
