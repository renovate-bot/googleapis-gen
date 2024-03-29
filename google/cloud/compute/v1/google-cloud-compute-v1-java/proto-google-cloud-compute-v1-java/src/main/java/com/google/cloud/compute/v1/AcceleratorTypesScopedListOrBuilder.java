// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/compute/v1/compute.proto

package com.google.cloud.compute.v1;

public interface AcceleratorTypesScopedListOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.compute.v1.AcceleratorTypesScopedList)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * [Output Only] A list of accelerator types contained in this scope.
   * </pre>
   *
   * <code>repeated .google.cloud.compute.v1.AcceleratorType accelerator_types = 520872357;</code>
   */
  java.util.List<com.google.cloud.compute.v1.AcceleratorType> 
      getAcceleratorTypesList();
  /**
   * <pre>
   * [Output Only] A list of accelerator types contained in this scope.
   * </pre>
   *
   * <code>repeated .google.cloud.compute.v1.AcceleratorType accelerator_types = 520872357;</code>
   */
  com.google.cloud.compute.v1.AcceleratorType getAcceleratorTypes(int index);
  /**
   * <pre>
   * [Output Only] A list of accelerator types contained in this scope.
   * </pre>
   *
   * <code>repeated .google.cloud.compute.v1.AcceleratorType accelerator_types = 520872357;</code>
   */
  int getAcceleratorTypesCount();
  /**
   * <pre>
   * [Output Only] A list of accelerator types contained in this scope.
   * </pre>
   *
   * <code>repeated .google.cloud.compute.v1.AcceleratorType accelerator_types = 520872357;</code>
   */
  java.util.List<? extends com.google.cloud.compute.v1.AcceleratorTypeOrBuilder> 
      getAcceleratorTypesOrBuilderList();
  /**
   * <pre>
   * [Output Only] A list of accelerator types contained in this scope.
   * </pre>
   *
   * <code>repeated .google.cloud.compute.v1.AcceleratorType accelerator_types = 520872357;</code>
   */
  com.google.cloud.compute.v1.AcceleratorTypeOrBuilder getAcceleratorTypesOrBuilder(
      int index);

  /**
   * <pre>
   * [Output Only] An informational warning that appears when the accelerator types list is empty.
   * </pre>
   *
   * <code>optional .google.cloud.compute.v1.Warning warning = 50704284;</code>
   * @return Whether the warning field is set.
   */
  boolean hasWarning();
  /**
   * <pre>
   * [Output Only] An informational warning that appears when the accelerator types list is empty.
   * </pre>
   *
   * <code>optional .google.cloud.compute.v1.Warning warning = 50704284;</code>
   * @return The warning.
   */
  com.google.cloud.compute.v1.Warning getWarning();
  /**
   * <pre>
   * [Output Only] An informational warning that appears when the accelerator types list is empty.
   * </pre>
   *
   * <code>optional .google.cloud.compute.v1.Warning warning = 50704284;</code>
   */
  com.google.cloud.compute.v1.WarningOrBuilder getWarningOrBuilder();
}
