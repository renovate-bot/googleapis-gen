// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dialogflow/v2/validation_result.proto

package com.google.cloud.dialogflow.v2;

public interface ValidationResultOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.dialogflow.v2.ValidationResult)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Contains all validation errors.
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.v2.ValidationError validation_errors = 1;</code>
   */
  java.util.List<com.google.cloud.dialogflow.v2.ValidationError> 
      getValidationErrorsList();
  /**
   * <pre>
   * Contains all validation errors.
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.v2.ValidationError validation_errors = 1;</code>
   */
  com.google.cloud.dialogflow.v2.ValidationError getValidationErrors(int index);
  /**
   * <pre>
   * Contains all validation errors.
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.v2.ValidationError validation_errors = 1;</code>
   */
  int getValidationErrorsCount();
  /**
   * <pre>
   * Contains all validation errors.
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.v2.ValidationError validation_errors = 1;</code>
   */
  java.util.List<? extends com.google.cloud.dialogflow.v2.ValidationErrorOrBuilder> 
      getValidationErrorsOrBuilderList();
  /**
   * <pre>
   * Contains all validation errors.
   * </pre>
   *
   * <code>repeated .google.cloud.dialogflow.v2.ValidationError validation_errors = 1;</code>
   */
  com.google.cloud.dialogflow.v2.ValidationErrorOrBuilder getValidationErrorsOrBuilder(
      int index);
}
