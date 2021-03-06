// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/home/enterprise/sdm/v1/device.proto

package com.google.home.enterprise.sdm.v1;

public interface ParentRelationOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.home.enterprise.sdm.v1.ParentRelation)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Output only. The name of the relation -- e.g., structure/room where the
   * device is assigned to. For example: "enterprises/XYZ/structures/ABC" or
   * "enterprises/XYZ/structures/ABC/rooms/123"
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The parent.
   */
  java.lang.String getParent();
  /**
   * <pre>
   * Output only. The name of the relation -- e.g., structure/room where the
   * device is assigned to. For example: "enterprises/XYZ/structures/ABC" or
   * "enterprises/XYZ/structures/ABC/rooms/123"
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The bytes for parent.
   */
  com.google.protobuf.ByteString
      getParentBytes();

  /**
   * <pre>
   * Output only. The custom name of the relation -- e.g., structure/room where
   * the device is assigned to.
   * </pre>
   *
   * <code>string display_name = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The displayName.
   */
  java.lang.String getDisplayName();
  /**
   * <pre>
   * Output only. The custom name of the relation -- e.g., structure/room where
   * the device is assigned to.
   * </pre>
   *
   * <code>string display_name = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The bytes for displayName.
   */
  com.google.protobuf.ByteString
      getDisplayNameBytes();
}
