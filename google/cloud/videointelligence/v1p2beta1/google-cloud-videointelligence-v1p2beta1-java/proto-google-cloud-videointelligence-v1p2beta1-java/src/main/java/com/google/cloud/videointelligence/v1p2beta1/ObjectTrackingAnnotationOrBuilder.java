// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/videointelligence/v1p2beta1/video_intelligence.proto

package com.google.cloud.videointelligence.v1p2beta1;

public interface ObjectTrackingAnnotationOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.videointelligence.v1p2beta1.ObjectTrackingAnnotation)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Entity to specify the object category that this track is labeled as.
   * </pre>
   *
   * <code>.google.cloud.videointelligence.v1p2beta1.Entity entity = 1;</code>
   * @return Whether the entity field is set.
   */
  boolean hasEntity();
  /**
   * <pre>
   * Entity to specify the object category that this track is labeled as.
   * </pre>
   *
   * <code>.google.cloud.videointelligence.v1p2beta1.Entity entity = 1;</code>
   * @return The entity.
   */
  com.google.cloud.videointelligence.v1p2beta1.Entity getEntity();
  /**
   * <pre>
   * Entity to specify the object category that this track is labeled as.
   * </pre>
   *
   * <code>.google.cloud.videointelligence.v1p2beta1.Entity entity = 1;</code>
   */
  com.google.cloud.videointelligence.v1p2beta1.EntityOrBuilder getEntityOrBuilder();

  /**
   * <pre>
   * Object category's labeling confidence of this track.
   * </pre>
   *
   * <code>float confidence = 4;</code>
   * @return The confidence.
   */
  float getConfidence();

  /**
   * <pre>
   * Information corresponding to all frames where this object track appears.
   * </pre>
   *
   * <code>repeated .google.cloud.videointelligence.v1p2beta1.ObjectTrackingFrame frames = 2;</code>
   */
  java.util.List<com.google.cloud.videointelligence.v1p2beta1.ObjectTrackingFrame> 
      getFramesList();
  /**
   * <pre>
   * Information corresponding to all frames where this object track appears.
   * </pre>
   *
   * <code>repeated .google.cloud.videointelligence.v1p2beta1.ObjectTrackingFrame frames = 2;</code>
   */
  com.google.cloud.videointelligence.v1p2beta1.ObjectTrackingFrame getFrames(int index);
  /**
   * <pre>
   * Information corresponding to all frames where this object track appears.
   * </pre>
   *
   * <code>repeated .google.cloud.videointelligence.v1p2beta1.ObjectTrackingFrame frames = 2;</code>
   */
  int getFramesCount();
  /**
   * <pre>
   * Information corresponding to all frames where this object track appears.
   * </pre>
   *
   * <code>repeated .google.cloud.videointelligence.v1p2beta1.ObjectTrackingFrame frames = 2;</code>
   */
  java.util.List<? extends com.google.cloud.videointelligence.v1p2beta1.ObjectTrackingFrameOrBuilder> 
      getFramesOrBuilderList();
  /**
   * <pre>
   * Information corresponding to all frames where this object track appears.
   * </pre>
   *
   * <code>repeated .google.cloud.videointelligence.v1p2beta1.ObjectTrackingFrame frames = 2;</code>
   */
  com.google.cloud.videointelligence.v1p2beta1.ObjectTrackingFrameOrBuilder getFramesOrBuilder(
      int index);

  /**
   * <pre>
   * Each object track corresponds to one video segment where it appears.
   * </pre>
   *
   * <code>.google.cloud.videointelligence.v1p2beta1.VideoSegment segment = 3;</code>
   * @return Whether the segment field is set.
   */
  boolean hasSegment();
  /**
   * <pre>
   * Each object track corresponds to one video segment where it appears.
   * </pre>
   *
   * <code>.google.cloud.videointelligence.v1p2beta1.VideoSegment segment = 3;</code>
   * @return The segment.
   */
  com.google.cloud.videointelligence.v1p2beta1.VideoSegment getSegment();
  /**
   * <pre>
   * Each object track corresponds to one video segment where it appears.
   * </pre>
   *
   * <code>.google.cloud.videointelligence.v1p2beta1.VideoSegment segment = 3;</code>
   */
  com.google.cloud.videointelligence.v1p2beta1.VideoSegmentOrBuilder getSegmentOrBuilder();
}
