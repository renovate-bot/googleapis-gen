// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/chromeos/uidetection/v1/ui_detection.proto

package com.google.chromeos.uidetection.v1;

public interface TextBlockDetectionRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.chromeos.uidetection.v1.TextBlockDetectionRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The text block consisting a list of words to locate im the image.
   * </pre>
   *
   * <code>repeated string words = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return A list containing the words.
   */
  java.util.List<java.lang.String>
      getWordsList();
  /**
   * <pre>
   * Required. The text block consisting a list of words to locate im the image.
   * </pre>
   *
   * <code>repeated string words = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The count of words.
   */
  int getWordsCount();
  /**
   * <pre>
   * Required. The text block consisting a list of words to locate im the image.
   * </pre>
   *
   * <code>repeated string words = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @param index The index of the element to return.
   * @return The words at the given index.
   */
  java.lang.String getWords(int index);
  /**
   * <pre>
   * Required. The text block consisting a list of words to locate im the image.
   * </pre>
   *
   * <code>repeated string words = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @param index The index of the value to return.
   * @return The bytes of the words at the given index.
   */
  com.google.protobuf.ByteString
      getWordsBytes(int index);
}
