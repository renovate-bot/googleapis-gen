// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/aiplatform/v1/pipeline_job.proto

package com.google.cloud.aiplatform.v1;

public interface PipelineJobDetailOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.aiplatform.v1.PipelineJobDetail)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Output only. The context of the pipeline.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1.Context pipeline_context = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return Whether the pipelineContext field is set.
   */
  boolean hasPipelineContext();
  /**
   * <pre>
   * Output only. The context of the pipeline.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1.Context pipeline_context = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The pipelineContext.
   */
  com.google.cloud.aiplatform.v1.Context getPipelineContext();
  /**
   * <pre>
   * Output only. The context of the pipeline.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1.Context pipeline_context = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.cloud.aiplatform.v1.ContextOrBuilder getPipelineContextOrBuilder();

  /**
   * <pre>
   * Output only. The context of the current pipeline run.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1.Context pipeline_run_context = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return Whether the pipelineRunContext field is set.
   */
  boolean hasPipelineRunContext();
  /**
   * <pre>
   * Output only. The context of the current pipeline run.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1.Context pipeline_run_context = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The pipelineRunContext.
   */
  com.google.cloud.aiplatform.v1.Context getPipelineRunContext();
  /**
   * <pre>
   * Output only. The context of the current pipeline run.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1.Context pipeline_run_context = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.cloud.aiplatform.v1.ContextOrBuilder getPipelineRunContextOrBuilder();

  /**
   * <pre>
   * Output only. The runtime details of the tasks under the pipeline.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1.PipelineTaskDetail task_details = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  java.util.List<com.google.cloud.aiplatform.v1.PipelineTaskDetail> 
      getTaskDetailsList();
  /**
   * <pre>
   * Output only. The runtime details of the tasks under the pipeline.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1.PipelineTaskDetail task_details = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.cloud.aiplatform.v1.PipelineTaskDetail getTaskDetails(int index);
  /**
   * <pre>
   * Output only. The runtime details of the tasks under the pipeline.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1.PipelineTaskDetail task_details = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  int getTaskDetailsCount();
  /**
   * <pre>
   * Output only. The runtime details of the tasks under the pipeline.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1.PipelineTaskDetail task_details = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  java.util.List<? extends com.google.cloud.aiplatform.v1.PipelineTaskDetailOrBuilder> 
      getTaskDetailsOrBuilderList();
  /**
   * <pre>
   * Output only. The runtime details of the tasks under the pipeline.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1.PipelineTaskDetail task_details = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.cloud.aiplatform.v1.PipelineTaskDetailOrBuilder getTaskDetailsOrBuilder(
      int index);
}
