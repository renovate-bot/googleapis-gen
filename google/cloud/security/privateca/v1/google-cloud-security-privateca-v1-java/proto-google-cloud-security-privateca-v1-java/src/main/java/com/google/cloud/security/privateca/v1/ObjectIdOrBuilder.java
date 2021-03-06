// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/security/privateca/v1/resources.proto

package com.google.cloud.security.privateca.v1;

public interface ObjectIdOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.security.privateca.v1.ObjectId)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The parts of an OID path. The most significant parts of the path come
   * first.
   * </pre>
   *
   * <code>repeated int32 object_id_path = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return A list containing the objectIdPath.
   */
  java.util.List<java.lang.Integer> getObjectIdPathList();
  /**
   * <pre>
   * Required. The parts of an OID path. The most significant parts of the path come
   * first.
   * </pre>
   *
   * <code>repeated int32 object_id_path = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The count of objectIdPath.
   */
  int getObjectIdPathCount();
  /**
   * <pre>
   * Required. The parts of an OID path. The most significant parts of the path come
   * first.
   * </pre>
   *
   * <code>repeated int32 object_id_path = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @param index The index of the element to return.
   * @return The objectIdPath at the given index.
   */
  int getObjectIdPath(int index);
}
