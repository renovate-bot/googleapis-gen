// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/aiplatform/v1/vizier_service.proto

package com.google.cloud.aiplatform.v1;

public interface CheckTrialEarlyStoppingStateMetatdataOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.aiplatform.v1.CheckTrialEarlyStoppingStateMetatdata)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Operation metadata for suggesting Trials.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1.GenericOperationMetadata generic_metadata = 1;</code>
   * @return Whether the genericMetadata field is set.
   */
  boolean hasGenericMetadata();
  /**
   * <pre>
   * Operation metadata for suggesting Trials.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1.GenericOperationMetadata generic_metadata = 1;</code>
   * @return The genericMetadata.
   */
  com.google.cloud.aiplatform.v1.GenericOperationMetadata getGenericMetadata();
  /**
   * <pre>
   * Operation metadata for suggesting Trials.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1.GenericOperationMetadata generic_metadata = 1;</code>
   */
  com.google.cloud.aiplatform.v1.GenericOperationMetadataOrBuilder getGenericMetadataOrBuilder();

  /**
   * <pre>
   * The name of the Study that the Trial belongs to.
   * </pre>
   *
   * <code>string study = 2;</code>
   * @return The study.
   */
  java.lang.String getStudy();
  /**
   * <pre>
   * The name of the Study that the Trial belongs to.
   * </pre>
   *
   * <code>string study = 2;</code>
   * @return The bytes for study.
   */
  com.google.protobuf.ByteString
      getStudyBytes();

  /**
   * <pre>
   * The Trial name.
   * </pre>
   *
   * <code>string trial = 3;</code>
   * @return The trial.
   */
  java.lang.String getTrial();
  /**
   * <pre>
   * The Trial name.
   * </pre>
   *
   * <code>string trial = 3;</code>
   * @return The bytes for trial.
   */
  com.google.protobuf.ByteString
      getTrialBytes();
}
