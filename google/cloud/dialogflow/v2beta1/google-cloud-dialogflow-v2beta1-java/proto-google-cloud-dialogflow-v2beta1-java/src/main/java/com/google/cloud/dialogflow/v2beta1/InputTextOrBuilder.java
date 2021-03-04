// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dialogflow/v2beta1/participant.proto

package com.google.cloud.dialogflow.v2beta1;

public interface InputTextOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.dialogflow.v2beta1.InputText)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The UTF-8 encoded natural language text to be processed.
   * Text length must not exceed 256 bytes.
   * </pre>
   *
   * <code>string text = 1;</code>
   * @return The text.
   */
  java.lang.String getText();
  /**
   * <pre>
   * Required. The UTF-8 encoded natural language text to be processed.
   * Text length must not exceed 256 bytes.
   * </pre>
   *
   * <code>string text = 1;</code>
   * @return The bytes for text.
   */
  com.google.protobuf.ByteString
      getTextBytes();

  /**
   * <pre>
   * Required. The language of this conversational query. See [Language
   * Support](https://cloud.google.com/dialogflow/docs/reference/language)
   * for a list of the currently supported language codes.
   * </pre>
   *
   * <code>string language_code = 2;</code>
   * @return The languageCode.
   */
  java.lang.String getLanguageCode();
  /**
   * <pre>
   * Required. The language of this conversational query. See [Language
   * Support](https://cloud.google.com/dialogflow/docs/reference/language)
   * for a list of the currently supported language codes.
   * </pre>
   *
   * <code>string language_code = 2;</code>
   * @return The bytes for languageCode.
   */
  com.google.protobuf.ByteString
      getLanguageCodeBytes();
}
