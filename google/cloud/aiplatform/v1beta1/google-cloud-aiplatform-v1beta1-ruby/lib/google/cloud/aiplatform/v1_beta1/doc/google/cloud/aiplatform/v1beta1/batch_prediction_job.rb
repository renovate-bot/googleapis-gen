# Copyright 2020 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     https://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

module Google
  module Cloud
    module Aiplatform
      module V1beta1
        # A job that uses a {Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob#model Model} to produce predictions
        # on multiple {Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob#input_config input instances}. If
        # predictions for significant portion of the instances fail, the job may finish
        # without attempting predictions for all remaining instances.
        # @!attribute [rw] name
        #   @return [String]
        #     Output only. Resource name of the BatchPredictionJob.
        # @!attribute [rw] display_name
        #   @return [String]
        #     Required. The user-defined name of this BatchPredictionJob.
        # @!attribute [rw] model
        #   @return [String]
        #     Required. The name of the Model that produces the predictions via this job,
        #     must share the same ancestor Location.
        #     Starting this job has no impact on any existing deployments of the Model
        #     and their resources.
        # @!attribute [rw] input_config
        #   @return [Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob::InputConfig]
        #     Required. Input configuration of the instances on which predictions are performed.
        #     The schema of any single instance may be specified via
        #     the {Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob#model Model's}
        #     {Google::Cloud::Aiplatform::V1beta1::Model#predict_schemata PredictSchemata's}
        #     {Google::Cloud::Aiplatform::V1beta1::PredictSchemata#instance_schema_uri instance_schema_uri}.
        # @!attribute [rw] model_parameters
        #   @return [Google::Protobuf::Value]
        #     The parameters that govern the predictions. The schema of the parameters
        #     may be specified via the {Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob#model Model's}
        #     {Google::Cloud::Aiplatform::V1beta1::Model#predict_schemata PredictSchemata's}
        #     {Google::Cloud::Aiplatform::V1beta1::PredictSchemata#parameters_schema_uri parameters_schema_uri}.
        # @!attribute [rw] output_config
        #   @return [Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob::OutputConfig]
        #     Required. The Configuration specifying where output predictions should
        #     be written.
        #     The schema of any single prediction may be specified as a concatenation
        #     of {Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob#model Model's}
        #     {Google::Cloud::Aiplatform::V1beta1::Model#predict_schemata PredictSchemata's}
        #     {Google::Cloud::Aiplatform::V1beta1::PredictSchemata#instance_schema_uri instance_schema_uri}
        #     and
        #     {Google::Cloud::Aiplatform::V1beta1::PredictSchemata#prediction_schema_uri prediction_schema_uri}.
        # @!attribute [rw] dedicated_resources
        #   @return [Google::Cloud::Aiplatform::V1beta1::BatchDedicatedResources]
        #     The config of resources used by the Model during the batch prediction. If
        #     the Model {Google::Cloud::Aiplatform::V1beta1::Model#supported_deployment_resources_types supports}
        #     DEDICATED_RESOURCES this config may be provided (and the job will use these
        #     resources), if the Model doesn't support AUTOMATIC_RESOURCES, this config
        #     must be provided.
        # @!attribute [rw] manual_batch_tuning_parameters
        #   @return [Google::Cloud::Aiplatform::V1beta1::ManualBatchTuningParameters]
        #     Immutable. Parameters configuring the batch behavior. Currently only applicable when
        #     {Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob#dedicated_resources dedicated_resources} are used (in other cases AI Platform does
        #     the tuning itself).
        # @!attribute [rw] generate_explanation
        #   @return [true, false]
        #     Generate explanation with the batch prediction results.
        #
        #     When set to `true`, the batch prediction output changes based on the
        #     `predictions_format` field of the
        #     {Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob#output_config BatchPredictionJob#output_config} object:
        #
        #     * `bigquery`: output includes a column named `explanation`. The value
        #       is a struct that conforms to the {Google::Cloud::Aiplatform::V1beta1::Explanation Explanation} object.
        #     * `jsonl`: The JSON objects on each line include an additional entry
        #       keyed `explanation`. The value of the entry is a JSON object that
        #       conforms to the {Google::Cloud::Aiplatform::V1beta1::Explanation Explanation} object.
        #     * `csv`: Generating explanations for CSV format is not supported.
        #
        #     If this field is set to true, either the {Google::Cloud::Aiplatform::V1beta1::Model#explanation_spec Model#explanation_spec} or
        #     {Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob#explanation_spec explanation_spec} must be populated.
        # @!attribute [rw] explanation_spec
        #   @return [Google::Cloud::Aiplatform::V1beta1::ExplanationSpec]
        #     Explanation configuration for this BatchPredictionJob. Can be
        #     specified only if {Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob#generate_explanation generate_explanation} is set to `true`.
        #
        #     This value overrides the value of {Google::Cloud::Aiplatform::V1beta1::Model#explanation_spec Model#explanation_spec}. All fields of
        #     {Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob#explanation_spec explanation_spec} are optional in the request. If a field of the
        #     {Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob#explanation_spec explanation_spec} object is not populated, the corresponding field of
        #     the {Google::Cloud::Aiplatform::V1beta1::Model#explanation_spec Model#explanation_spec} object is inherited.
        # @!attribute [rw] output_info
        #   @return [Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob::OutputInfo]
        #     Output only. Information further describing the output of this job.
        # @!attribute [rw] state
        #   @return [Google::Cloud::Aiplatform::V1beta1::JobState]
        #     Output only. The detailed state of the job.
        # @!attribute [rw] error
        #   @return [Google::Rpc::Status]
        #     Output only. Only populated when the job's state is JOB_STATE_FAILED or
        #     JOB_STATE_CANCELLED.
        # @!attribute [rw] partial_failures
        #   @return [Array<Google::Rpc::Status>]
        #     Output only. Partial failures encountered.
        #     For example, single files that can't be read.
        #     This field never exceeds 20 entries.
        #     Status details fields contain standard GCP error details.
        # @!attribute [rw] resources_consumed
        #   @return [Google::Cloud::Aiplatform::V1beta1::ResourcesConsumed]
        #     Output only. Information about resources that had been consumed by this job.
        #     Provided in real time at best effort basis, as well as a final value
        #     once the job completes.
        #
        #     Note: This field currently may be not populated for batch predictions that
        #     use AutoML Models.
        # @!attribute [rw] completion_stats
        #   @return [Google::Cloud::Aiplatform::V1beta1::CompletionStats]
        #     Output only. Statistics on completed and failed prediction instances.
        # @!attribute [rw] create_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. Time when the BatchPredictionJob was created.
        # @!attribute [rw] start_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. Time when the BatchPredictionJob for the first time entered the
        #     `JOB_STATE_RUNNING` state.
        # @!attribute [rw] end_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. Time when the BatchPredictionJob entered any of the following states:
        #     `JOB_STATE_SUCCEEDED`, `JOB_STATE_FAILED`, `JOB_STATE_CANCELLED`.
        # @!attribute [rw] update_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. Time when the BatchPredictionJob was most recently updated.
        # @!attribute [rw] labels
        #   @return [Hash{String => String}]
        #     The labels with user-defined metadata to organize BatchPredictionJobs.
        #
        #     Label keys and values can be no longer than 64 characters
        #     (Unicode codepoints), can only contain lowercase letters, numeric
        #     characters, underscores and dashes. International characters are allowed.
        #
        #     See https://goo.gl/xmQnxf for more information and examples of labels.
        # @!attribute [rw] encryption_spec
        #   @return [Google::Cloud::Aiplatform::V1beta1::EncryptionSpec]
        #     Customer-managed encryption key options for a BatchPredictionJob. If this
        #     is set, then all resources created by the BatchPredictionJob will be
        #     encrypted with the provided encryption key.
        class BatchPredictionJob
          # Configures the input to {Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob BatchPredictionJob}.
          # See {Google::Cloud::Aiplatform::V1beta1::Model#supported_input_storage_formats Model#supported_input_storage_formats} for Model's supported input
          # formats, and how instances should be expressed via any of them.
          # @!attribute [rw] gcs_source
          #   @return [Google::Cloud::Aiplatform::V1beta1::GcsSource]
          #     The Cloud Storage location for the input instances.
          # @!attribute [rw] bigquery_source
          #   @return [Google::Cloud::Aiplatform::V1beta1::BigQuerySource]
          #     The BigQuery location of the input table.
          #     The schema of the table should be in the format described by the given
          #     context OpenAPI Schema, if one is provided. The table may contain
          #     additional columns that are not described by the schema, and they will
          #     be ignored.
          # @!attribute [rw] instances_format
          #   @return [String]
          #     Required. The format in which instances are given, must be one of the
          #     {Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob#model Model's}
          #     {Google::Cloud::Aiplatform::V1beta1::Model#supported_input_storage_formats supported_input_storage_formats}.
          class InputConfig; end

          # Configures the output of {Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob BatchPredictionJob}.
          # See {Google::Cloud::Aiplatform::V1beta1::Model#supported_output_storage_formats Model#supported_output_storage_formats} for supported output
          # formats, and how predictions are expressed via any of them.
          # @!attribute [rw] gcs_destination
          #   @return [Google::Cloud::Aiplatform::V1beta1::GcsDestination]
          #     The Cloud Storage location of the directory where the output is
          #     to be written to. In the given directory a new directory is created.
          #     Its name is `prediction-<model-display-name>-<job-create-time>`,
          #     where timestamp is in YYYY-MM-DDThh:mm:ss.sssZ ISO-8601 format.
          #     Inside of it files `predictions_0001.<extension>`,
          #     `predictions_0002.<extension>`, ..., `predictions_N.<extension>`
          #     are created where `<extension>` depends on chosen
          #     {Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob::OutputConfig#predictions_format predictions_format}, and N may equal 0001 and depends on the total
          #     number of successfully predicted instances.
          #     If the Model has both {Google::Cloud::Aiplatform::V1beta1::PredictSchemata#instance_schema_uri instance}
          #     and {Google::Cloud::Aiplatform::V1beta1::PredictSchemata#parameters_schema_uri prediction} schemata
          #     defined then each such file contains predictions as per the
          #     {Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob::OutputConfig#predictions_format predictions_format}.
          #     If prediction for any instance failed (partially or completely), then
          #     an additional `errors_0001.<extension>`, `errors_0002.<extension>`,...,
          #     `errors_N.<extension>` files are created (N depends on total number
          #     of failed predictions). These files contain the failed instances,
          #     as per their schema, followed by an additional `error` field which as
          #     value has
          #     [`google.rpc.Status`](https://cloud.google.comStatus)
          #     containing only `code` and `message` fields.
          # @!attribute [rw] bigquery_destination
          #   @return [Google::Cloud::Aiplatform::V1beta1::BigQueryDestination]
          #     The BigQuery project location where the output is to be written to.
          #     In the given project a new dataset is created with name
          #     `prediction_<model-display-name>_<job-create-time>`
          #     where <model-display-name> is made
          #     BigQuery-dataset-name compatible (for example, most special characters
          #     become underscores), and timestamp is in
          #     YYYY_MM_DDThh_mm_ss_sssZ "based on ISO-8601" format. In the dataset
          #     two tables will be created, `predictions`, and `errors`.
          #     If the Model has both {Google::Cloud::Aiplatform::V1beta1::PredictSchemata#instance_schema_uri instance}
          #     and {Google::Cloud::Aiplatform::V1beta1::PredictSchemata#parameters_schema_uri prediction} schemata
          #     defined then the tables have columns as follows: The `predictions`
          #     table contains instances for which the prediction succeeded, it
          #     has columns as per a concatenation of the Model's instance and
          #     prediction schemata. The `errors` table contains rows for which the
          #     prediction has failed, it has instance columns, as per the
          #     instance schema, followed by a single "errors" column, which as values
          #     has [`google.rpc.Status`](https://cloud.google.comStatus)
          #     represented as a STRUCT, and containing only `code` and `message`.
          # @!attribute [rw] predictions_format
          #   @return [String]
          #     Required. The format in which AI Platform gives the predictions, must be one of the
          #     {Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob#model Model's}
          #     {Google::Cloud::Aiplatform::V1beta1::Model#supported_output_storage_formats supported_output_storage_formats}.
          class OutputConfig; end

          # Further describes this job's output.
          # Supplements {Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob#output_config output_config}.
          # @!attribute [rw] gcs_output_directory
          #   @return [String]
          #     Output only. The full path of the Cloud Storage directory created, into which
          #     the prediction output is written.
          # @!attribute [rw] bigquery_output_dataset
          #   @return [String]
          #     Output only. The path of the BigQuery dataset created, in
          #     `bq://projectId.bqDatasetId`
          #     format, into which the prediction output is written.
          class OutputInfo; end
        end
      end
    end
  end
end