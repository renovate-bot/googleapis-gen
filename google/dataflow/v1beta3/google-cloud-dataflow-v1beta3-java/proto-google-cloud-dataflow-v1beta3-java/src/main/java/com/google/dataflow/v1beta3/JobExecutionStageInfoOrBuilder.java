// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/dataflow/v1beta3/jobs.proto

package com.google.dataflow.v1beta3;

public interface JobExecutionStageInfoOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.dataflow.v1beta3.JobExecutionStageInfo)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The steps associated with the execution stage.
   * Note that stages may have several steps, and that a given step
   * might be run by more than one stage.
   * </pre>
   *
   * <code>repeated string step_name = 1;</code>
   * @return A list containing the stepName.
   */
  java.util.List<java.lang.String>
      getStepNameList();
  /**
   * <pre>
   * The steps associated with the execution stage.
   * Note that stages may have several steps, and that a given step
   * might be run by more than one stage.
   * </pre>
   *
   * <code>repeated string step_name = 1;</code>
   * @return The count of stepName.
   */
  int getStepNameCount();
  /**
   * <pre>
   * The steps associated with the execution stage.
   * Note that stages may have several steps, and that a given step
   * might be run by more than one stage.
   * </pre>
   *
   * <code>repeated string step_name = 1;</code>
   * @param index The index of the element to return.
   * @return The stepName at the given index.
   */
  java.lang.String getStepName(int index);
  /**
   * <pre>
   * The steps associated with the execution stage.
   * Note that stages may have several steps, and that a given step
   * might be run by more than one stage.
   * </pre>
   *
   * <code>repeated string step_name = 1;</code>
   * @param index The index of the value to return.
   * @return The bytes of the stepName at the given index.
   */
  com.google.protobuf.ByteString
      getStepNameBytes(int index);
}
