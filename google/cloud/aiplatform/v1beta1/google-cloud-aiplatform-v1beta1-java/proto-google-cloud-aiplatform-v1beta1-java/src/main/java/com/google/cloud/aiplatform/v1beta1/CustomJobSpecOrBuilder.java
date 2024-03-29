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
   * If unspecified, the [Vertex AI Custom Code Service
   * Agent](https://cloud.google.com/vertex-ai/docs/general/access-control#service-agents)
   * for the CustomJob's project is used.
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
   * If unspecified, the [Vertex AI Custom Code Service
   * Agent](https://cloud.google.com/vertex-ai/docs/general/access-control#service-agents)
   * for the CustomJob's project is used.
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
   * To specify this field, you must have already [configured VPC Network
   * Peering for Vertex
   * AI](https://cloud.google.com/vertex-ai/docs/general/vpc-peering).
   * If this field is left unspecified, the job is not peered with any network.
   * </pre>
   *
   * <code>string network = 5 [(.google.api.resource_reference) = { ... }</code>
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
   * To specify this field, you must have already [configured VPC Network
   * Peering for Vertex
   * AI](https://cloud.google.com/vertex-ai/docs/general/vpc-peering).
   * If this field is left unspecified, the job is not peered with any network.
   * </pre>
   *
   * <code>string network = 5 [(.google.api.resource_reference) = { ... }</code>
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
   * The following Vertex AI environment variables will be passed to
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
   * The following Vertex AI environment variables will be passed to
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
   * The following Vertex AI environment variables will be passed to
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

  /**
   * <pre>
   * Optional. The name of a Vertex AI [Tensorboard][google.cloud.aiplatform.v1beta1.Tensorboard] resource to which this CustomJob
   * will upload Tensorboard logs.
   * Format:
   * `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
   * </pre>
   *
   * <code>string tensorboard = 7 [(.google.api.field_behavior) = OPTIONAL, (.google.api.resource_reference) = { ... }</code>
   * @return The tensorboard.
   */
  java.lang.String getTensorboard();
  /**
   * <pre>
   * Optional. The name of a Vertex AI [Tensorboard][google.cloud.aiplatform.v1beta1.Tensorboard] resource to which this CustomJob
   * will upload Tensorboard logs.
   * Format:
   * `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
   * </pre>
   *
   * <code>string tensorboard = 7 [(.google.api.field_behavior) = OPTIONAL, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for tensorboard.
   */
  com.google.protobuf.ByteString
      getTensorboardBytes();

  /**
   * <pre>
   * Optional. Whether you want Vertex AI to enable [interactive shell
   * access](https://cloud.google.com/vertex-ai/docs/training/monitor-debug-interactive-shell)
   * to training containers.
   * If set to `true`, you can access interactive shells at the URIs given
   * by [CustomJob.web_access_uris][google.cloud.aiplatform.v1beta1.CustomJob.web_access_uris] or [Trial.web_access_uris][google.cloud.aiplatform.v1beta1.Trial.web_access_uris] (within
   * [HyperparameterTuningJob.trials][google.cloud.aiplatform.v1beta1.HyperparameterTuningJob.trials]).
   * </pre>
   *
   * <code>bool enable_web_access = 10 [(.google.api.field_behavior) = OPTIONAL];</code>
   * @return The enableWebAccess.
   */
  boolean getEnableWebAccess();
}
