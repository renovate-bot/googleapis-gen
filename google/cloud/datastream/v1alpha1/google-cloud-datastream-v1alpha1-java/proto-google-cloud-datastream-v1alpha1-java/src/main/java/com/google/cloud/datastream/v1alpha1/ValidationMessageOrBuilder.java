// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/datastream/v1alpha1/datastream_resources.proto

package com.google.cloud.datastream.v1alpha1;

public interface ValidationMessageOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.datastream.v1alpha1.ValidationMessage)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The result of the validation.
   * </pre>
   *
   * <code>string message = 1;</code>
   * @return The message.
   */
  java.lang.String getMessage();
  /**
   * <pre>
   * The result of the validation.
   * </pre>
   *
   * <code>string message = 1;</code>
   * @return The bytes for message.
   */
  com.google.protobuf.ByteString
      getMessageBytes();

  /**
   * <pre>
   * Message severity level (warning or error).
   * </pre>
   *
   * <code>.google.cloud.datastream.v1alpha1.ValidationMessage.Level level = 2;</code>
   * @return The enum numeric value on the wire for level.
   */
  int getLevelValue();
  /**
   * <pre>
   * Message severity level (warning or error).
   * </pre>
   *
   * <code>.google.cloud.datastream.v1alpha1.ValidationMessage.Level level = 2;</code>
   * @return The level.
   */
  com.google.cloud.datastream.v1alpha1.ValidationMessage.Level getLevel();

  /**
   * <pre>
   * Additional metadata related to the result.
   * </pre>
   *
   * <code>map&lt;string, string&gt; metadata = 3;</code>
   */
  int getMetadataCount();
  /**
   * <pre>
   * Additional metadata related to the result.
   * </pre>
   *
   * <code>map&lt;string, string&gt; metadata = 3;</code>
   */
  boolean containsMetadata(
      java.lang.String key);
  /**
   * Use {@link #getMetadataMap()} instead.
   */
  @java.lang.Deprecated
  java.util.Map<java.lang.String, java.lang.String>
  getMetadata();
  /**
   * <pre>
   * Additional metadata related to the result.
   * </pre>
   *
   * <code>map&lt;string, string&gt; metadata = 3;</code>
   */
  java.util.Map<java.lang.String, java.lang.String>
  getMetadataMap();
  /**
   * <pre>
   * Additional metadata related to the result.
   * </pre>
   *
   * <code>map&lt;string, string&gt; metadata = 3;</code>
   */

  java.lang.String getMetadataOrDefault(
      java.lang.String key,
      java.lang.String defaultValue);
  /**
   * <pre>
   * Additional metadata related to the result.
   * </pre>
   *
   * <code>map&lt;string, string&gt; metadata = 3;</code>
   */

  java.lang.String getMetadataOrThrow(
      java.lang.String key);

  /**
   * <pre>
   * A custom code identifying this specific message.
   * </pre>
   *
   * <code>string code = 4;</code>
   * @return The code.
   */
  java.lang.String getCode();
  /**
   * <pre>
   * A custom code identifying this specific message.
   * </pre>
   *
   * <code>string code = 4;</code>
   * @return The bytes for code.
   */
  com.google.protobuf.ByteString
      getCodeBytes();
}
