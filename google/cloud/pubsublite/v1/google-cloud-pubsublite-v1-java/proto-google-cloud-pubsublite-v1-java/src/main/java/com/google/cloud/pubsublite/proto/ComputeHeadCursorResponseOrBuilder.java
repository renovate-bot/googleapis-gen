// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/pubsublite/v1/topic_stats.proto

package com.google.cloud.pubsublite.proto;

public interface ComputeHeadCursorResponseOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.pubsublite.v1.ComputeHeadCursorResponse)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The head cursor.
   * </pre>
   *
   * <code>.google.cloud.pubsublite.v1.Cursor head_cursor = 1;</code>
   * @return Whether the headCursor field is set.
   */
  boolean hasHeadCursor();
  /**
   * <pre>
   * The head cursor.
   * </pre>
   *
   * <code>.google.cloud.pubsublite.v1.Cursor head_cursor = 1;</code>
   * @return The headCursor.
   */
  com.google.cloud.pubsublite.proto.Cursor getHeadCursor();
  /**
   * <pre>
   * The head cursor.
   * </pre>
   *
   * <code>.google.cloud.pubsublite.v1.Cursor head_cursor = 1;</code>
   */
  com.google.cloud.pubsublite.proto.CursorOrBuilder getHeadCursorOrBuilder();
}
