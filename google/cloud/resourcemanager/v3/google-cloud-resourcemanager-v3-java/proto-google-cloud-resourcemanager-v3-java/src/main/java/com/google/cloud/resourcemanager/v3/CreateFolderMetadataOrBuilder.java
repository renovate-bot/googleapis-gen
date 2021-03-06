// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/resourcemanager/v3/folders.proto

package com.google.cloud.resourcemanager.v3;

public interface CreateFolderMetadataOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.resourcemanager.v3.CreateFolderMetadata)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The display name of the folder.
   * </pre>
   *
   * <code>string display_name = 1;</code>
   * @return The displayName.
   */
  java.lang.String getDisplayName();
  /**
   * <pre>
   * The display name of the folder.
   * </pre>
   *
   * <code>string display_name = 1;</code>
   * @return The bytes for displayName.
   */
  com.google.protobuf.ByteString
      getDisplayNameBytes();

  /**
   * <pre>
   * The resource name of the folder or organization we are creating the folder
   * under.
   * </pre>
   *
   * <code>string parent = 2;</code>
   * @return The parent.
   */
  java.lang.String getParent();
  /**
   * <pre>
   * The resource name of the folder or organization we are creating the folder
   * under.
   * </pre>
   *
   * <code>string parent = 2;</code>
   * @return The bytes for parent.
   */
  com.google.protobuf.ByteString
      getParentBytes();
}
