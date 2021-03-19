// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/aiplatform/v1beta1/custom_job.proto

package com.google.cloud.aiplatform.v1beta1;

public interface CustomJobSpecOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.aiplatform.v1beta1.CustomJobSpec)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The spec of the worker pools including machine type and Docker image.
   * All worker pools except the first one are optional and can be skipped by
   * providing an empty value.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1beta1.WorkerPoolSpec worker_pool_specs = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  java.util.List<com.google.cloud.aiplatform.v1beta1.WorkerPoolSpec> 
      getWorkerPoolSpecsList();
  /**
   * <pre>
   * Required. The spec of the worker pools including machine type and Docker image.
   * All worker pools except the first one are optional and can be skipped by
   * providing an empty value.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1beta1.WorkerPoolSpec worker_pool_specs = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.cloud.aiplatform.v1beta1.WorkerPoolSpec getWorkerPoolSpecs(int index);
  /**
   * <pre>
   * Required. The spec of the worker pools including machine type and Docker image.
   * All worker pools except the first one are optional and can be skipped by
   * providing an empty value.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1beta1.WorkerPoolSpec worker_pool_specs = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  int getWorkerPoolSpecsCount();
  /**
   * <pre>
   * Required. The spec of the worker pools including machine type and Docker image.
   * All worker pools except the first one are optional and can be skipped by
   * providing an empty value.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1beta1.WorkerPoolSpec worker_pool_specs = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  java.util.List<? extends com.google.cloud.aiplatform.v1beta1.WorkerPoolSpecOrBuilder> 
      getWorkerPoolSpecsOrBuilderList();
  /**
   * <pre>
   * Required. The spec of the worker pools including machine type and Docker image.
   * All worker pools except the first one are optional and can be skipped by
   * providing an empty value.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1beta1.WorkerPoolSpec worker_pool_specs = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.cloud.aiplatform.v1beta1.WorkerPoolSpecOrBuilder getWorkerPoolSpecsOrBuilder(
      int index);

  /**
   * <pre>
   * Scheduling options for a CustomJob.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1beta1.Scheduling scheduling = 3;</code>
   * @return Whether the scheduling field is set.
   */
  boolean hasScheduling();
  /**
   * <pre>
   * Scheduling options for a CustomJob.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1beta1.Scheduling scheduling = 3;</code>
   * @return The scheduling.
   */
  com.google.cloud.aiplatform.v1beta1.Scheduling getScheduling();
  /**
   * <pre>
   * Scheduling options for a CustomJob.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1beta1.Scheduling scheduling = 3;</code>
   */
  com.google.cloud.aiplatform.v1beta1.SchedulingOrBuilder getSchedulingOrBuilder();

  /**
   * <pre>
   * Specifies the service account for workload run-as account.
   * Users submitting jobs must have act-as permission on this run-as account.
   * If unspecified, the AI Platform Custom Code Service Agent for the
   * CustomJob's project is used.
   * </pre>
   *
   * <code>string service_account = 4;</code>
   * @return The serviceAccount.
   */
  java.lang.String getServiceAccount();
  /**
   * <pre>
   * Specifies the service account for workload run-as account.
   * Users submitting jobs must have act-as permission on this run-as account.
   * If unspecified, the AI Platform Custom Code Service Agent for the
   * CustomJob's project is used.
   * </pre>
   *
   * <code>string service_account = 4;</code>
   * @return The bytes for serviceAccount.
   */
  com.google.protobuf.ByteString
      getServiceAccountBytes();

  /**
   * <pre>
   * The full name of the Compute Engine
   * [network](/compute/docs/networks-and-firewalls#networks) to which the Job
   * should be peered. For example, `projects/12345/global/networks/myVPC`.
   * [Format](/compute/docs/reference/rest/v1/networks/insert)
   * is of the form `projects/{project}/global/networks/{network}`.
   * Where {project} is a project number, as in `12345`, and {network} is a
   * network name.
   * Private services access must already be configured for the network. If left
   * unspecified, the job is not peered with any network.
   * </pre>
   *
   * <code>string network = 5;</code>
   * @return The network.
   */
  java.lang.String getNetwork();
  /**
   * <pre>
   * The full name of the Compute Engine
   * [network](/compute/docs/networks-and-firewalls#networks) to which the Job
   * should be peered. For example, `projects/12345/global/networks/myVPC`.
   * [Format](/compute/docs/reference/rest/v1/networks/insert)
   * is of the form `projects/{project}/global/networks/{network}`.
   * Where {project} is a project number, as in `12345`, and {network} is a
   * network name.
   * Private services access must already be configured for the network. If left
   * unspecified, the job is not peered with any network.
   * </pre>
   *
   * <code>string network = 5;</code>
   * @return The bytes for network.
   */
  com.google.protobuf.ByteString
      getNetworkBytes();

  /**
   * <pre>
   * The Cloud Storage location to store the output of this CustomJob or
   * HyperparameterTuningJob. For HyperparameterTuningJob,
   * the baseOutputDirectory of
   * each child CustomJob backing a Trial is set to a subdirectory of name
   * [id][google.cloud.aiplatform.v1beta1.Trial.id] under its parent HyperparameterTuningJob's
   * baseOutputDirectory.
   * The following AI Platform environment variables will be passed to
   * containers or python modules when this field is set:
   *   For CustomJob:
   *   * AIP_MODEL_DIR = `&lt;base_output_directory&gt;/model/`
   *   * AIP_CHECKPOINT_DIR = `&lt;base_output_directory&gt;/checkpoints/`
   *   * AIP_TENSORBOARD_LOG_DIR = `&lt;base_output_directory&gt;/logs/`
   *   For CustomJob backing a Trial of HyperparameterTuningJob:
   *   * AIP_MODEL_DIR = `&lt;base_output_directory&gt;/&lt;trial_id&gt;/model/`
   *   * AIP_CHECKPOINT_DIR = `&lt;base_output_directory&gt;/&lt;trial_id&gt;/checkpoints/`
   *   * AIP_TENSORBOARD_LOG_DIR = `&lt;base_output_directory&gt;/&lt;trial_id&gt;/logs/`
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1beta1.GcsDestination base_output_directory = 6;</code>
   * @return Whether the baseOutputDirectory field is set.
   */
  boolean hasBaseOutputDirectory();
  /**
   * <pre>
   * The Cloud Storage location to store the output of this CustomJob or
   * HyperparameterTuningJob. For HyperparameterTuningJob,
   * the baseOutputDirectory of
   * each child CustomJob backing a Trial is set to a subdirectory of name
   * [id][google.cloud.aiplatform.v1beta1.Trial.id] under its parent HyperparameterTuningJob's
   * baseOutputDirectory.
   * The following AI Platform environment variables will be passed to
   * containers or python modules when this field is set:
   *   For CustomJob:
   *   * AIP_MODEL_DIR = `&lt;base_output_directory&gt;/model/`
   *   * AIP_CHECKPOINT_DIR = `&lt;base_output_directory&gt;/checkpoints/`
   *   * AIP_TENSORBOARD_LOG_DIR = `&lt;base_output_directory&gt;/logs/`
   *   For CustomJob backing a Trial of HyperparameterTuningJob:
   *   * AIP_MODEL_DIR = `&lt;base_output_directory&gt;/&lt;trial_id&gt;/model/`
   *   * AIP_CHECKPOINT_DIR = `&lt;base_output_directory&gt;/&lt;trial_id&gt;/checkpoints/`
   *   * AIP_TENSORBOARD_LOG_DIR = `&lt;base_output_directory&gt;/&lt;trial_id&gt;/logs/`
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1beta1.GcsDestination base_output_directory = 6;</code>
   * @return The baseOutputDirectory.
   */
  com.google.cloud.aiplatform.v1beta1.GcsDestination getBaseOutputDirectory();
  /**
   * <pre>
   * The Cloud Storage location to store the output of this CustomJob or
   * HyperparameterTuningJob. For HyperparameterTuningJob,
   * the baseOutputDirectory of
   * each child CustomJob backing a Trial is set to a subdirectory of name
   * [id][google.cloud.aiplatform.v1beta1.Trial.id] under its parent HyperparameterTuningJob's
   * baseOutputDirectory.
   * The following AI Platform environment variables will be passed to
   * containers or python modules when this field is set:
   *   For CustomJob:
   *   * AIP_MODEL_DIR = `&lt;base_output_directory&gt;/model/`
   *   * AIP_CHECKPOINT_DIR = `&lt;base_output_directory&gt;/checkpoints/`
   *   * AIP_TENSORBOARD_LOG_DIR = `&lt;base_output_directory&gt;/logs/`
   *   For CustomJob backing a Trial of HyperparameterTuningJob:
   *   * AIP_MODEL_DIR = `&lt;base_output_directory&gt;/&lt;trial_id&gt;/model/`
   *   * AIP_CHECKPOINT_DIR = `&lt;base_output_directory&gt;/&lt;trial_id&gt;/checkpoints/`
   *   * AIP_TENSORBOARD_LOG_DIR = `&lt;base_output_directory&gt;/&lt;trial_id&gt;/logs/`
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1beta1.GcsDestination base_output_directory = 6;</code>
   */
  com.google.cloud.aiplatform.v1beta1.GcsDestinationOrBuilder getBaseOutputDirectoryOrBuilder();
}
