// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/videointelligence/v1/video_intelligence.proto

package com.google.cloud.videointelligence.v1;

public interface DetectedLandmarkOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.videointelligence.v1.DetectedLandmark)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The name of this landmark, for example, left_hand, right_shoulder.
   * </pre>
   *
   * <code>string name = 1;</code>
   * @return The name.
   */
  java.lang.String getName();
  /**
   * <pre>
   * The name of this landmark, for example, left_hand, right_shoulder.
   * </pre>
   *
   * <code>string name = 1;</code>
   * @return The bytes for name.
   */
  com.google.protobuf.ByteString
      getNameBytes();

  /**
   * <pre>
   * The 2D point of the detected landmark using the normalized image
   * coordindate system. The normalized coordinates have the range from 0 to 1.
   * </pre>
   *
   * <code>.google.cloud.videointelligence.v1.NormalizedVertex point = 2;</code>
   * @return Whether the point field is set.
   */
  boolean hasPoint();
  /**
   * <pre>
   * The 2D point of the detected landmark using the normalized image
   * coordindate system. The normalized coordinates have the range from 0 to 1.
   * </pre>
   *
   * <code>.google.cloud.videointelligence.v1.NormalizedVertex point = 2;</code>
   * @return The point.
   */
  com.google.cloud.videointelligence.v1.NormalizedVertex getPoint();
  /**
   * <pre>
   * The 2D point of the detected landmark using the normalized image
   * coordindate system. The normalized coordinates have the range from 0 to 1.
   * </pre>
   *
   * <code>.google.cloud.videointelligence.v1.NormalizedVertex point = 2;</code>
   */
  com.google.cloud.videointelligence.v1.NormalizedVertexOrBuilder getPointOrBuilder();

  /**
   * <pre>
   * The confidence score of the detected landmark. Range [0, 1].
   * </pre>
   *
   * <code>float confidence = 3;</code>
   * @return The confidence.
   */
  float getConfidence();
}
