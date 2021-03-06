// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/videointelligence/v1p3beta1/video_intelligence.proto

package com.google.cloud.videointelligence.v1p3beta1;

public interface CelebrityOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.videointelligence.v1p3beta1.Celebrity)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The resource name of the celebrity. Have the format
   * `video-intelligence/kg-mid` indicates a celebrity from preloaded gallery.
   * kg-mid is the id in Google knowledge graph, which is unique for the
   * celebrity.
   * </pre>
   *
   * <code>string name = 1;</code>
   * @return The name.
   */
  java.lang.String getName();
  /**
   * <pre>
   * The resource name of the celebrity. Have the format
   * `video-intelligence/kg-mid` indicates a celebrity from preloaded gallery.
   * kg-mid is the id in Google knowledge graph, which is unique for the
   * celebrity.
   * </pre>
   *
   * <code>string name = 1;</code>
   * @return The bytes for name.
   */
  com.google.protobuf.ByteString
      getNameBytes();

  /**
   * <pre>
   * The celebrity name.
   * </pre>
   *
   * <code>string display_name = 2;</code>
   * @return The displayName.
   */
  java.lang.String getDisplayName();
  /**
   * <pre>
   * The celebrity name.
   * </pre>
   *
   * <code>string display_name = 2;</code>
   * @return The bytes for displayName.
   */
  com.google.protobuf.ByteString
      getDisplayNameBytes();

  /**
   * <pre>
   * Textual description of additional information about the celebrity, if
   * applicable.
   * </pre>
   *
   * <code>string description = 3;</code>
   * @return The description.
   */
  java.lang.String getDescription();
  /**
   * <pre>
   * Textual description of additional information about the celebrity, if
   * applicable.
   * </pre>
   *
   * <code>string description = 3;</code>
   * @return The bytes for description.
   */
  com.google.protobuf.ByteString
      getDescriptionBytes();
}
