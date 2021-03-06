// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/api/serviceusage/v1/resources.proto

package com.google.api.serviceusage.v1;

public interface OperationMetadataOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.api.serviceusage.v1.OperationMetadata)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The full name of the resources that this operation is directly
   * associated with.
   * </pre>
   *
   * <code>repeated string resource_names = 2;</code>
   * @return A list containing the resourceNames.
   */
  java.util.List<java.lang.String>
      getResourceNamesList();
  /**
   * <pre>
   * The full name of the resources that this operation is directly
   * associated with.
   * </pre>
   *
   * <code>repeated string resource_names = 2;</code>
   * @return The count of resourceNames.
   */
  int getResourceNamesCount();
  /**
   * <pre>
   * The full name of the resources that this operation is directly
   * associated with.
   * </pre>
   *
   * <code>repeated string resource_names = 2;</code>
   * @param index The index of the element to return.
   * @return The resourceNames at the given index.
   */
  java.lang.String getResourceNames(int index);
  /**
   * <pre>
   * The full name of the resources that this operation is directly
   * associated with.
   * </pre>
   *
   * <code>repeated string resource_names = 2;</code>
   * @param index The index of the value to return.
   * @return The bytes of the resourceNames at the given index.
   */
  com.google.protobuf.ByteString
      getResourceNamesBytes(int index);
}
