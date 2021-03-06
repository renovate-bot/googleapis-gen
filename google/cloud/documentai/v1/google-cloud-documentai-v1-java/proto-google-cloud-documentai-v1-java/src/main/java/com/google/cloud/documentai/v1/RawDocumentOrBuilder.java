// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/documentai/v1/document_io.proto

package com.google.cloud.documentai.v1;

public interface RawDocumentOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.documentai.v1.RawDocument)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Inline document content.
   * </pre>
   *
   * <code>bytes content = 1;</code>
   * @return The content.
   */
  com.google.protobuf.ByteString getContent();

  /**
   * <pre>
   * An IANA MIME type (RFC6838) indicating the nature and format of the
   * [content].
   * </pre>
   *
   * <code>string mime_type = 2;</code>
   * @return The mimeType.
   */
  java.lang.String getMimeType();
  /**
   * <pre>
   * An IANA MIME type (RFC6838) indicating the nature and format of the
   * [content].
   * </pre>
   *
   * <code>string mime_type = 2;</code>
   * @return The bytes for mimeType.
   */
  com.google.protobuf.ByteString
      getMimeTypeBytes();
}
