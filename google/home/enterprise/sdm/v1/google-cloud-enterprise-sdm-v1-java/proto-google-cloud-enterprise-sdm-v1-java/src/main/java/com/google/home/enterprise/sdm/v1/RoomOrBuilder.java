// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/home/enterprise/sdm/v1/site.proto

package com.google.home.enterprise.sdm.v1;

public interface RoomOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.home.enterprise.sdm.v1.Room)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Output only. The resource name of the room. For example:
   * "enterprises/XYZ/structures/ABC/rooms/123".
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The name.
   */
  java.lang.String getName();
  /**
   * <pre>
   * Output only. The resource name of the room. For example:
   * "enterprises/XYZ/structures/ABC/rooms/123".
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The bytes for name.
   */
  com.google.protobuf.ByteString
      getNameBytes();

  /**
   * <pre>
   * Room traits.
   * </pre>
   *
   * <code>.google.protobuf.Struct traits = 2;</code>
   * @return Whether the traits field is set.
   */
  boolean hasTraits();
  /**
   * <pre>
   * Room traits.
   * </pre>
   *
   * <code>.google.protobuf.Struct traits = 2;</code>
   * @return The traits.
   */
  com.google.protobuf.Struct getTraits();
  /**
   * <pre>
   * Room traits.
   * </pre>
   *
   * <code>.google.protobuf.Struct traits = 2;</code>
   */
  com.google.protobuf.StructOrBuilder getTraitsOrBuilder();
}
