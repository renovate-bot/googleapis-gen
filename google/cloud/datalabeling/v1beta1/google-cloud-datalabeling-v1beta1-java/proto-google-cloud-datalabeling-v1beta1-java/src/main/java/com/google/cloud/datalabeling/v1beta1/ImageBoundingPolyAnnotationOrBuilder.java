// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/datalabeling/v1beta1/annotation.proto

package com.google.cloud.datalabeling.v1beta1;

public interface ImageBoundingPolyAnnotationOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.datalabeling.v1beta1.ImageBoundingPolyAnnotation)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <code>.google.cloud.datalabeling.v1beta1.BoundingPoly bounding_poly = 2;</code>
   * @return Whether the boundingPoly field is set.
   */
  boolean hasBoundingPoly();
  /**
   * <code>.google.cloud.datalabeling.v1beta1.BoundingPoly bounding_poly = 2;</code>
   * @return The boundingPoly.
   */
  com.google.cloud.datalabeling.v1beta1.BoundingPoly getBoundingPoly();
  /**
   * <code>.google.cloud.datalabeling.v1beta1.BoundingPoly bounding_poly = 2;</code>
   */
  com.google.cloud.datalabeling.v1beta1.BoundingPolyOrBuilder getBoundingPolyOrBuilder();

  /**
   * <code>.google.cloud.datalabeling.v1beta1.NormalizedBoundingPoly normalized_bounding_poly = 3;</code>
   * @return Whether the normalizedBoundingPoly field is set.
   */
  boolean hasNormalizedBoundingPoly();
  /**
   * <code>.google.cloud.datalabeling.v1beta1.NormalizedBoundingPoly normalized_bounding_poly = 3;</code>
   * @return The normalizedBoundingPoly.
   */
  com.google.cloud.datalabeling.v1beta1.NormalizedBoundingPoly getNormalizedBoundingPoly();
  /**
   * <code>.google.cloud.datalabeling.v1beta1.NormalizedBoundingPoly normalized_bounding_poly = 3;</code>
   */
  com.google.cloud.datalabeling.v1beta1.NormalizedBoundingPolyOrBuilder getNormalizedBoundingPolyOrBuilder();

  /**
   * <pre>
   * Label of object in this bounding polygon.
   * </pre>
   *
   * <code>.google.cloud.datalabeling.v1beta1.AnnotationSpec annotation_spec = 1;</code>
   * @return Whether the annotationSpec field is set.
   */
  boolean hasAnnotationSpec();
  /**
   * <pre>
   * Label of object in this bounding polygon.
   * </pre>
   *
   * <code>.google.cloud.datalabeling.v1beta1.AnnotationSpec annotation_spec = 1;</code>
   * @return The annotationSpec.
   */
  com.google.cloud.datalabeling.v1beta1.AnnotationSpec getAnnotationSpec();
  /**
   * <pre>
   * Label of object in this bounding polygon.
   * </pre>
   *
   * <code>.google.cloud.datalabeling.v1beta1.AnnotationSpec annotation_spec = 1;</code>
   */
  com.google.cloud.datalabeling.v1beta1.AnnotationSpecOrBuilder getAnnotationSpecOrBuilder();

  public com.google.cloud.datalabeling.v1beta1.ImageBoundingPolyAnnotation.BoundedAreaCase getBoundedAreaCase();
}
