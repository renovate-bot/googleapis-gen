// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/language/v1/language_service.proto

package com.google.cloud.language.v1;

public interface AnalyzeSentimentRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.language.v1.AnalyzeSentimentRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Input document.
   * </pre>
   *
   * <code>.google.cloud.language.v1.Document document = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the document field is set.
   */
  boolean hasDocument();
  /**
   * <pre>
   * Input document.
   * </pre>
   *
   * <code>.google.cloud.language.v1.Document document = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The document.
   */
  com.google.cloud.language.v1.Document getDocument();
  /**
   * <pre>
   * Input document.
   * </pre>
   *
   * <code>.google.cloud.language.v1.Document document = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.cloud.language.v1.DocumentOrBuilder getDocumentOrBuilder();

  /**
   * <pre>
   * The encoding type used by the API to calculate sentence offsets.
   * </pre>
   *
   * <code>.google.cloud.language.v1.EncodingType encoding_type = 2;</code>
   * @return The enum numeric value on the wire for encodingType.
   */
  int getEncodingTypeValue();
  /**
   * <pre>
   * The encoding type used by the API to calculate sentence offsets.
   * </pre>
   *
   * <code>.google.cloud.language.v1.EncodingType encoding_type = 2;</code>
   * @return The encodingType.
   */
  com.google.cloud.language.v1.EncodingType getEncodingType();
}
