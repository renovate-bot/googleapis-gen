// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/firestore/v1beta1/firestore.proto

package com.google.firestore.v1beta1;

public interface BatchWriteRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.firestore.v1beta1.BatchWriteRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The database name. In the format:
   * `projects/{project_id}/databases/{database_id}`.
   * </pre>
   *
   * <code>string database = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The database.
   */
  java.lang.String getDatabase();
  /**
   * <pre>
   * Required. The database name. In the format:
   * `projects/{project_id}/databases/{database_id}`.
   * </pre>
   *
   * <code>string database = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for database.
   */
  com.google.protobuf.ByteString
      getDatabaseBytes();

  /**
   * <pre>
   * The writes to apply.
   * Method does not apply writes atomically and does not guarantee ordering.
   * Each write succeeds or fails independently. You cannot write to the same
   * document more than once per request.
   * </pre>
   *
   * <code>repeated .google.firestore.v1beta1.Write writes = 2;</code>
   */
  java.util.List<com.google.firestore.v1beta1.Write> 
      getWritesList();
  /**
   * <pre>
   * The writes to apply.
   * Method does not apply writes atomically and does not guarantee ordering.
   * Each write succeeds or fails independently. You cannot write to the same
   * document more than once per request.
   * </pre>
   *
   * <code>repeated .google.firestore.v1beta1.Write writes = 2;</code>
   */
  com.google.firestore.v1beta1.Write getWrites(int index);
  /**
   * <pre>
   * The writes to apply.
   * Method does not apply writes atomically and does not guarantee ordering.
   * Each write succeeds or fails independently. You cannot write to the same
   * document more than once per request.
   * </pre>
   *
   * <code>repeated .google.firestore.v1beta1.Write writes = 2;</code>
   */
  int getWritesCount();
  /**
   * <pre>
   * The writes to apply.
   * Method does not apply writes atomically and does not guarantee ordering.
   * Each write succeeds or fails independently. You cannot write to the same
   * document more than once per request.
   * </pre>
   *
   * <code>repeated .google.firestore.v1beta1.Write writes = 2;</code>
   */
  java.util.List<? extends com.google.firestore.v1beta1.WriteOrBuilder> 
      getWritesOrBuilderList();
  /**
   * <pre>
   * The writes to apply.
   * Method does not apply writes atomically and does not guarantee ordering.
   * Each write succeeds or fails independently. You cannot write to the same
   * document more than once per request.
   * </pre>
   *
   * <code>repeated .google.firestore.v1beta1.Write writes = 2;</code>
   */
  com.google.firestore.v1beta1.WriteOrBuilder getWritesOrBuilder(
      int index);

  /**
   * <pre>
   * Labels associated with this batch write.
   * </pre>
   *
   * <code>map&lt;string, string&gt; labels = 3;</code>
   */
  int getLabelsCount();
  /**
   * <pre>
   * Labels associated with this batch write.
   * </pre>
   *
   * <code>map&lt;string, string&gt; labels = 3;</code>
   */
  boolean containsLabels(
      java.lang.String key);
  /**
   * Use {@link #getLabelsMap()} instead.
   */
  @java.lang.Deprecated
  java.util.Map<java.lang.String, java.lang.String>
  getLabels();
  /**
   * <pre>
   * Labels associated with this batch write.
   * </pre>
   *
   * <code>map&lt;string, string&gt; labels = 3;</code>
   */
  java.util.Map<java.lang.String, java.lang.String>
  getLabelsMap();
  /**
   * <pre>
   * Labels associated with this batch write.
   * </pre>
   *
   * <code>map&lt;string, string&gt; labels = 3;</code>
   */

  java.lang.String getLabelsOrDefault(
      java.lang.String key,
      java.lang.String defaultValue);
  /**
   * <pre>
   * Labels associated with this batch write.
   * </pre>
   *
   * <code>map&lt;string, string&gt; labels = 3;</code>
   */

  java.lang.String getLabelsOrThrow(
      java.lang.String key);
}
