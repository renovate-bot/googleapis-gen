// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/pubsublite/v1/publisher.proto

package com.google.cloud.pubsublite.proto;

public interface MessagePublishResponseOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.pubsublite.v1.MessagePublishResponse)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The cursor of the first published message in the batch. The cursors for any
   * remaining messages in the batch are guaranteed to be sequential.
   * </pre>
   *
   * <code>.google.cloud.pubsublite.v1.Cursor start_cursor = 1;</code>
   * @return Whether the startCursor field is set.
   */
  boolean hasStartCursor();
  /**
   * <pre>
   * The cursor of the first published message in the batch. The cursors for any
   * remaining messages in the batch are guaranteed to be sequential.
   * </pre>
   *
   * <code>.google.cloud.pubsublite.v1.Cursor start_cursor = 1;</code>
   * @return The startCursor.
   */
  com.google.cloud.pubsublite.proto.Cursor getStartCursor();
  /**
   * <pre>
   * The cursor of the first published message in the batch. The cursors for any
   * remaining messages in the batch are guaranteed to be sequential.
   * </pre>
   *
   * <code>.google.cloud.pubsublite.v1.Cursor start_cursor = 1;</code>
   */
  com.google.cloud.pubsublite.proto.CursorOrBuilder getStartCursorOrBuilder();
}
