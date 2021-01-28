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
      module V1
        # Request message for {Google::Cloud::Aiplatform::V1::JobService::CreateCustomJob JobService::CreateCustomJob}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The resource name of the Location to create the CustomJob in.
        #     Format: `projects/{project}/locations/{location}`
        # @!attribute [rw] custom_job
        #   @return [Google::Cloud::Aiplatform::V1::CustomJob]
        #     Required. The CustomJob to create.
        class CreateCustomJobRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1::JobService::GetCustomJob JobService::GetCustomJob}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the CustomJob resource.
        #     Format:
        #     `projects/{project}/locations/{location}/customJobs/{custom_job}`
        class GetCustomJobRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1::JobService::ListCustomJobs JobService::ListCustomJobs}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The resource name of the Location to list the CustomJobs from.
        #     Format: `projects/{project}/locations/{location}`
        # @!attribute [rw] filter
        #   @return [String]
        #     The standard list filter.
        #
        #     Supported fields:
        #
        #     * `display_name` supports = and !=.
        #
        #       * `state` supports = and !=.
        #
        #       Some examples of using the filter are:
        #
        #     * `state="JOB_STATE_SUCCEEDED" AND display_name="my_job"`
        #
        #     * `state="JOB_STATE_RUNNING" OR display_name="my_job"`
        #
        #     * `NOT display_name="my_job"`
        #
        #     * `state="JOB_STATE_FAILED"`
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The standard list page size.
        # @!attribute [rw] page_token
        #   @return [String]
        #     The standard list page token.
        #     Typically obtained via
        #     {Google::Cloud::Aiplatform::V1::ListCustomJobsResponse#next_page_token ListCustomJobsResponse#next_page_token} of the previous
        #     {Google::Cloud::Aiplatform::V1::JobService::ListCustomJobs JobService::ListCustomJobs} call.
        # @!attribute [rw] read_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Mask specifying which fields to read.
        class ListCustomJobsRequest; end

        # Response message for {Google::Cloud::Aiplatform::V1::JobService::ListCustomJobs JobService::ListCustomJobs}
        # @!attribute [rw] custom_jobs
        #   @return [Array<Google::Cloud::Aiplatform::V1::CustomJob>]
        #     List of CustomJobs in the requested page.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token to retrieve the next page of results.
        #     Pass to {Google::Cloud::Aiplatform::V1::ListCustomJobsRequest#page_token ListCustomJobsRequest#page_token} to obtain that page.
        class ListCustomJobsResponse; end

        # Request message for {Google::Cloud::Aiplatform::V1::JobService::DeleteCustomJob JobService::DeleteCustomJob}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the CustomJob resource to be deleted.
        #     Format:
        #     `projects/{project}/locations/{location}/customJobs/{custom_job}`
        class DeleteCustomJobRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1::JobService::CancelCustomJob JobService::CancelCustomJob}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the CustomJob to cancel.
        #     Format:
        #     `projects/{project}/locations/{location}/customJobs/{custom_job}`
        class CancelCustomJobRequest; end

        # Request message for {DataLabelingJobService::CreateDataLabelingJob}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The parent of the DataLabelingJob.
        #     Format: `projects/{project}/locations/{location}`
        # @!attribute [rw] data_labeling_job
        #   @return [Google::Cloud::Aiplatform::V1::DataLabelingJob]
        #     Required. The DataLabelingJob to create.
        class CreateDataLabelingJobRequest; end

        # Request message for {DataLabelingJobService::GetDataLabelingJob}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the DataLabelingJob.
        #     Format:
        #
        #     `projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}`
        class GetDataLabelingJobRequest; end

        # Request message for {DataLabelingJobService::ListDataLabelingJobs}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The parent of the DataLabelingJob.
        #     Format: `projects/{project}/locations/{location}`
        # @!attribute [rw] filter
        #   @return [String]
        #     The standard list filter.
        #
        #     Supported fields:
        #
        #     * `display_name` supports = and !=.
        #
        #       * `state` supports = and !=.
        #
        #       Some examples of using the filter are:
        #
        #     * `state="JOB_STATE_SUCCEEDED" AND display_name="my_job"`
        #
        #     * `state="JOB_STATE_RUNNING" OR display_name="my_job"`
        #
        #     * `NOT display_name="my_job"`
        #
        #     * `state="JOB_STATE_FAILED"`
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The standard list page size.
        # @!attribute [rw] page_token
        #   @return [String]
        #     The standard list page token.
        # @!attribute [rw] read_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Mask specifying which fields to read. FieldMask represents a set of
        #     symbolic field paths. For example, the mask can be `paths: "name"`. The
        #     "name" here is a field in DataLabelingJob.
        #     If this field is not set, all fields of the DataLabelingJob are returned.
        # @!attribute [rw] order_by
        #   @return [String]
        #     A comma-separated list of fields to order by, sorted in ascending order by
        #     default.
        #     Use `desc` after a field name for descending.
        class ListDataLabelingJobsRequest; end

        # Response message for {Google::Cloud::Aiplatform::V1::JobService::ListDataLabelingJobs JobService::ListDataLabelingJobs}.
        # @!attribute [rw] data_labeling_jobs
        #   @return [Array<Google::Cloud::Aiplatform::V1::DataLabelingJob>]
        #     A list of DataLabelingJobs that matches the specified filter in the
        #     request.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     The standard List next-page token.
        class ListDataLabelingJobsResponse; end

        # Request message for {Google::Cloud::Aiplatform::V1::JobService::DeleteDataLabelingJob JobService::DeleteDataLabelingJob}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the DataLabelingJob to be deleted.
        #     Format:
        #
        #     `projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}`
        class DeleteDataLabelingJobRequest; end

        # Request message for {DataLabelingJobService::CancelDataLabelingJob}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the DataLabelingJob.
        #     Format:
        #
        #     `projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}`
        class CancelDataLabelingJobRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1::JobService::CreateHyperparameterTuningJob JobService::CreateHyperparameterTuningJob}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The resource name of the Location to create the HyperparameterTuningJob in.
        #     Format: `projects/{project}/locations/{location}`
        # @!attribute [rw] hyperparameter_tuning_job
        #   @return [Google::Cloud::Aiplatform::V1::HyperparameterTuningJob]
        #     Required. The HyperparameterTuningJob to create.
        class CreateHyperparameterTuningJobRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1::JobService::GetHyperparameterTuningJob JobService::GetHyperparameterTuningJob}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the HyperparameterTuningJob resource.
        #     Format:
        #
        #     `projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}`
        class GetHyperparameterTuningJobRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1::JobService::ListHyperparameterTuningJobs JobService::ListHyperparameterTuningJobs}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The resource name of the Location to list the HyperparameterTuningJobs
        #     from. Format: `projects/{project}/locations/{location}`
        # @!attribute [rw] filter
        #   @return [String]
        #     The standard list filter.
        #
        #     Supported fields:
        #
        #     * `display_name` supports = and !=.
        #
        #       * `state` supports = and !=.
        #
        #       Some examples of using the filter are:
        #
        #     * `state="JOB_STATE_SUCCEEDED" AND display_name="my_job"`
        #
        #     * `state="JOB_STATE_RUNNING" OR display_name="my_job"`
        #
        #     * `NOT display_name="my_job"`
        #
        #     * `state="JOB_STATE_FAILED"`
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The standard list page size.
        # @!attribute [rw] page_token
        #   @return [String]
        #     The standard list page token.
        #     Typically obtained via
        #     {Google::Cloud::Aiplatform::V1::ListHyperparameterTuningJobsResponse#next_page_token ListHyperparameterTuningJobsResponse#next_page_token} of the previous
        #     {Google::Cloud::Aiplatform::V1::JobService::ListHyperparameterTuningJobs JobService::ListHyperparameterTuningJobs} call.
        # @!attribute [rw] read_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Mask specifying which fields to read.
        class ListHyperparameterTuningJobsRequest; end

        # Response message for {Google::Cloud::Aiplatform::V1::JobService::ListHyperparameterTuningJobs JobService::ListHyperparameterTuningJobs}
        # @!attribute [rw] hyperparameter_tuning_jobs
        #   @return [Array<Google::Cloud::Aiplatform::V1::HyperparameterTuningJob>]
        #     List of HyperparameterTuningJobs in the requested page.
        #     {Google::Cloud::Aiplatform::V1::HyperparameterTuningJob#trials HyperparameterTuningJob#trials} of the jobs will be not be returned.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token to retrieve the next page of results.
        #     Pass to {Google::Cloud::Aiplatform::V1::ListHyperparameterTuningJobsRequest#page_token ListHyperparameterTuningJobsRequest#page_token} to obtain that
        #     page.
        class ListHyperparameterTuningJobsResponse; end

        # Request message for {Google::Cloud::Aiplatform::V1::JobService::DeleteHyperparameterTuningJob JobService::DeleteHyperparameterTuningJob}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the HyperparameterTuningJob resource to be deleted.
        #     Format:
        #
        #     `projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}`
        class DeleteHyperparameterTuningJobRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1::JobService::CancelHyperparameterTuningJob JobService::CancelHyperparameterTuningJob}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the HyperparameterTuningJob to cancel.
        #     Format:
        #
        #     `projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}`
        class CancelHyperparameterTuningJobRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1::JobService::CreateBatchPredictionJob JobService::CreateBatchPredictionJob}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The resource name of the Location to create the BatchPredictionJob in.
        #     Format: `projects/{project}/locations/{location}`
        # @!attribute [rw] batch_prediction_job
        #   @return [Google::Cloud::Aiplatform::V1::BatchPredictionJob]
        #     Required. The BatchPredictionJob to create.
        class CreateBatchPredictionJobRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1::JobService::GetBatchPredictionJob JobService::GetBatchPredictionJob}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the BatchPredictionJob resource.
        #     Format:
        #
        #     `projects/{project}/locations/{location}/batchPredictionJobs/{batch_prediction_job}`
        class GetBatchPredictionJobRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1::JobService::ListBatchPredictionJobs JobService::ListBatchPredictionJobs}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The resource name of the Location to list the BatchPredictionJobs
        #     from. Format: `projects/{project}/locations/{location}`
        # @!attribute [rw] filter
        #   @return [String]
        #     The standard list filter.
        #
        #     Supported fields:
        #
        #     * `display_name` supports = and !=.
        #
        #       * `state` supports = and !=.
        #
        #       Some examples of using the filter are:
        #
        #     * `state="JOB_STATE_SUCCEEDED" AND display_name="my_job"`
        #
        #     * `state="JOB_STATE_RUNNING" OR display_name="my_job"`
        #
        #     * `NOT display_name="my_job"`
        #
        #     * `state="JOB_STATE_FAILED"`
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The standard list page size.
        # @!attribute [rw] page_token
        #   @return [String]
        #     The standard list page token.
        #     Typically obtained via
        #     {Google::Cloud::Aiplatform::V1::ListBatchPredictionJobsResponse#next_page_token ListBatchPredictionJobsResponse#next_page_token} of the previous
        #     {Google::Cloud::Aiplatform::V1::JobService::ListBatchPredictionJobs JobService::ListBatchPredictionJobs} call.
        # @!attribute [rw] read_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Mask specifying which fields to read.
        class ListBatchPredictionJobsRequest; end

        # Response message for {Google::Cloud::Aiplatform::V1::JobService::ListBatchPredictionJobs JobService::ListBatchPredictionJobs}
        # @!attribute [rw] batch_prediction_jobs
        #   @return [Array<Google::Cloud::Aiplatform::V1::BatchPredictionJob>]
        #     List of BatchPredictionJobs in the requested page.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token to retrieve the next page of results.
        #     Pass to {Google::Cloud::Aiplatform::V1::ListBatchPredictionJobsRequest#page_token ListBatchPredictionJobsRequest#page_token} to obtain that
        #     page.
        class ListBatchPredictionJobsResponse; end

        # Request message for {Google::Cloud::Aiplatform::V1::JobService::DeleteBatchPredictionJob JobService::DeleteBatchPredictionJob}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the BatchPredictionJob resource to be deleted.
        #     Format:
        #
        #     `projects/{project}/locations/{location}/batchPredictionJobs/{batch_prediction_job}`
        class DeleteBatchPredictionJobRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1::JobService::CancelBatchPredictionJob JobService::CancelBatchPredictionJob}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the BatchPredictionJob to cancel.
        #     Format:
        #
        #     `projects/{project}/locations/{location}/batchPredictionJobs/{batch_prediction_job}`
        class CancelBatchPredictionJobRequest; end
      end
    end
  end
end