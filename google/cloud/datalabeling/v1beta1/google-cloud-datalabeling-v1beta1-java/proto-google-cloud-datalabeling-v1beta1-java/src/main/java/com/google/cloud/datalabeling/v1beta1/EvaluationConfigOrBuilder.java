// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/datalabeling/v1beta1/evaluation.proto

package com.google.cloud.datalabeling.v1beta1;

public interface EvaluationConfigOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.datalabeling.v1beta1.EvaluationConfig)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Only specify this field if the related model performs image object
   * detection (`IMAGE_BOUNDING_BOX_ANNOTATION`). Describes how to evaluate
   * bounding boxes.
   * </pre>
   *
   * <code>.google.cloud.datalabeling.v1beta1.BoundingBoxEvaluationOptions bounding_box_evaluation_options = 1;</code>
   * @return Whether the boundingBoxEvaluationOptions field is set.
   */
  boolean hasBoundingBoxEvaluationOptions();
  /**
   * <pre>
   * Only specify this field if the related model performs image object
   * detection (`IMAGE_BOUNDING_BOX_ANNOTATION`). Describes how to evaluate
   * bounding boxes.
   * </pre>
   *
   * <code>.google.cloud.datalabeling.v1beta1.BoundingBoxEvaluationOptions bounding_box_evaluation_options = 1;</code>
   * @return The boundingBoxEvaluationOptions.
   */
  com.google.cloud.datalabeling.v1beta1.BoundingBoxEvaluationOptions getBoundingBoxEvaluationOptions();
  /**
   * <pre>
   * Only specify this field if the related model performs image object
   * detection (`IMAGE_BOUNDING_BOX_ANNOTATION`). Describes how to evaluate
   * bounding boxes.
   * </pre>
   *
   * <code>.google.cloud.datalabeling.v1beta1.BoundingBoxEvaluationOptions bounding_box_evaluation_options = 1;</code>
   */
  com.google.cloud.datalabeling.v1beta1.BoundingBoxEvaluationOptionsOrBuilder getBoundingBoxEvaluationOptionsOrBuilder();

  public com.google.cloud.datalabeling.v1beta1.EvaluationConfig.VerticalOptionCase getVerticalOptionCase();
}
