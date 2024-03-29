// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/chromeos/uidetection/v1/ui_detection.proto

package com.google.chromeos.uidetection.v1;

public interface UiDetectionRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.chromeos.uidetection.v1.UiDetectionRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. Required field that represents a PNG image.
   * </pre>
   *
   * <code>bytes image_png = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The imagePng.
   */
  com.google.protobuf.ByteString getImagePng();

  /**
   * <pre>
   * Required. Required field that indicates the detection type.
   * </pre>
   *
   * <code>.google.chromeos.uidetection.v1.DetectionRequest request = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the request field is set.
   */
  boolean hasRequest();
  /**
   * <pre>
   * Required. Required field that indicates the detection type.
   * </pre>
   *
   * <code>.google.chromeos.uidetection.v1.DetectionRequest request = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The request.
   */
  com.google.chromeos.uidetection.v1.DetectionRequest getRequest();
  /**
   * <pre>
   * Required. Required field that indicates the detection type.
   * </pre>
   *
   * <code>.google.chromeos.uidetection.v1.DetectionRequest request = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.chromeos.uidetection.v1.DetectionRequestOrBuilder getRequestOrBuilder();
}
