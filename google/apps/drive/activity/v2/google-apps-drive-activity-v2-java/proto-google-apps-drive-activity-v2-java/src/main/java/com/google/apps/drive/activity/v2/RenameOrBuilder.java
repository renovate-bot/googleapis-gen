// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/apps/drive/activity/v2/action.proto

package com.google.apps.drive.activity.v2;

public interface RenameOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.apps.drive.activity.v2.Rename)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The previous title of the drive object.
   * </pre>
   *
   * <code>string old_title = 1;</code>
   * @return The oldTitle.
   */
  java.lang.String getOldTitle();
  /**
   * <pre>
   * The previous title of the drive object.
   * </pre>
   *
   * <code>string old_title = 1;</code>
   * @return The bytes for oldTitle.
   */
  com.google.protobuf.ByteString
      getOldTitleBytes();

  /**
   * <pre>
   * The new title of the drive object.
   * </pre>
   *
   * <code>string new_title = 2;</code>
   * @return The newTitle.
   */
  java.lang.String getNewTitle();
  /**
   * <pre>
   * The new title of the drive object.
   * </pre>
   *
   * <code>string new_title = 2;</code>
   * @return The bytes for newTitle.
   */
  com.google.protobuf.ByteString
      getNewTitleBytes();
}
