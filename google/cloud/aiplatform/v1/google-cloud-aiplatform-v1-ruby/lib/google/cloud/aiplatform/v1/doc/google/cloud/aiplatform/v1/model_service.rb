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
        # Request message for {Google::Cloud::Aiplatform::V1::ModelService::UploadModel ModelService::UploadModel}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The resource name of the Location into which to upload the Model.
        #     Format: `projects/{project}/locations/{location}`
        # @!attribute [rw] model
        #   @return [Google::Cloud::Aiplatform::V1::Model]
        #     Required. The Model to create.
        class UploadModelRequest; end

        # Details of {Google::Cloud::Aiplatform::V1::ModelService::UploadModel ModelService::UploadModel} operation.
        # @!attribute [rw] generic_metadata
        #   @return [Google::Cloud::Aiplatform::V1::GenericOperationMetadata]
        #     The common part of the operation metadata.
        class UploadModelOperationMetadata; end

        # Response message of {Google::Cloud::Aiplatform::V1::ModelService::UploadModel ModelService::UploadModel} operation.
        # @!attribute [rw] model
        #   @return [String]
        #     The name of the uploaded Model resource.
        #     Format: `projects/{project}/locations/{location}/models/{model}`
        class UploadModelResponse; end

        # Request message for {Google::Cloud::Aiplatform::V1::ModelService::GetModel ModelService::GetModel}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the Model resource.
        #     Format: `projects/{project}/locations/{location}/models/{model}`
        class GetModelRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1::ModelService::ListModels ModelService::ListModels}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The resource name of the Location to list the Models from.
        #     Format: `projects/{project}/locations/{location}`
        # @!attribute [rw] filter
        #   @return [String]
        #     An expression for filtering the results of the request. For field names
        #     both snake_case and camelCase are supported.
        #
        #     * `model` supports = and !=. `model` represents the Model ID,
        #       i.e. the last segment of the Model's {Google::Cloud::Aiplatform::V1::Model#name resource name}.
        #       * `display_name` supports = and !=
        #       * `labels` supports general map functions that is:
        #         * `labels.key=value` - key:value equality
        #         * `labels.key:* or labels:key - key existence
        #         * A key including a space must be quoted. `labels."a key"`.
        #
        #         Some examples:
        #       * `model=1234`
        #       * `displayName="myDisplayName"`
        #       * `labels.myKey="myValue"`
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The standard list page size.
        # @!attribute [rw] page_token
        #   @return [String]
        #     The standard list page token.
        #     Typically obtained via
        #     {Google::Cloud::Aiplatform::V1::ListModelsResponse#next_page_token ListModelsResponse#next_page_token} of the previous
        #     {Google::Cloud::Aiplatform::V1::ModelService::ListModels ModelService::ListModels} call.
        # @!attribute [rw] read_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Mask specifying which fields to read.
        # @!attribute [rw] order_by
        #   @return [String]
        #     A comma-separated list of fields to order by, sorted in ascending order.
        #     Use "desc" after a field name for descending.
        #     Supported fields:
        #     * `display_name`
        #       * `create_time`
        #       * `update_time`
        #
        #       Example: `display_name, create_time desc`.
        class ListModelsRequest; end

        # Response message for {Google::Cloud::Aiplatform::V1::ModelService::ListModels ModelService::ListModels}
        # @!attribute [rw] models
        #   @return [Array<Google::Cloud::Aiplatform::V1::Model>]
        #     List of Models in the requested page.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token to retrieve next page of results.
        #     Pass to {Google::Cloud::Aiplatform::V1::ListModelsRequest#page_token ListModelsRequest#page_token} to obtain that page.
        class ListModelsResponse; end

        # Request message for {Google::Cloud::Aiplatform::V1::ModelService::UpdateModel ModelService::UpdateModel}.
        # @!attribute [rw] model
        #   @return [Google::Cloud::Aiplatform::V1::Model]
        #     Required. The Model which replaces the resource on the server.
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Required. The update mask applies to the resource.
        #     For the `FieldMask` definition, see
        #     [FieldMask](https://tinyurl.com/protobufs/google.protobuf#fieldmask).
        class UpdateModelRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1::ModelService::DeleteModel ModelService::DeleteModel}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the Model resource to be deleted.
        #     Format: `projects/{project}/locations/{location}/models/{model}`
        class DeleteModelRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1::ModelService::ExportModel ModelService::ExportModel}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The resource name of the Model to export.
        #     Format: `projects/{project}/locations/{location}/models/{model}`
        # @!attribute [rw] output_config
        #   @return [Google::Cloud::Aiplatform::V1::ExportModelRequest::OutputConfig]
        #     Required. The desired output location and configuration.
        class ExportModelRequest
          # Output configuration for the Model export.
          # @!attribute [rw] export_format_id
          #   @return [String]
          #     The ID of the format in which the Model must be exported. Each Model
          #     lists the {Google::Cloud::Aiplatform::V1::Model#supported_export_formats export formats it supports}.
          #     If no value is provided here, then the first from the list of the Model's
          #     supported formats is used by default.
          # @!attribute [rw] artifact_destination
          #   @return [Google::Cloud::Aiplatform::V1::GcsDestination]
          #     The Cloud Storage location where the Model artifact is to be
          #     written to. Under the directory given as the destination a new one with
          #     name "`model-export-<model-display-name>-<timestamp-of-export-call>`",
          #     where timestamp is in YYYY-MM-DDThh:mm:ss.sssZ ISO-8601 format,
          #     will be created. Inside, the Model and any of its supporting files
          #     will be written.
          #     This field should only be set when the `exportableContent` field of the
          #     [Model.supported_export_formats] object contains `ARTIFACT`.
          # @!attribute [rw] image_destination
          #   @return [Google::Cloud::Aiplatform::V1::ContainerRegistryDestination]
          #     The Google Container Registry or Artifact Registry uri where the
          #     Model container image will be copied to.
          #     This field should only be set when the `exportableContent` field of the
          #     [Model.supported_export_formats] object contains `IMAGE`.
          class OutputConfig; end
        end

        # Details of {Google::Cloud::Aiplatform::V1::ModelService::ExportModel ModelService::ExportModel} operation.
        # @!attribute [rw] generic_metadata
        #   @return [Google::Cloud::Aiplatform::V1::GenericOperationMetadata]
        #     The common part of the operation metadata.
        # @!attribute [rw] output_info
        #   @return [Google::Cloud::Aiplatform::V1::ExportModelOperationMetadata::OutputInfo]
        #     Output only. Information further describing the output of this Model export.
        class ExportModelOperationMetadata
          # Further describes the output of the ExportModel. Supplements
          # {Google::Cloud::Aiplatform::V1::ExportModelRequest::OutputConfig ExportModelRequest::OutputConfig}.
          # @!attribute [rw] artifact_output_uri
          #   @return [String]
          #     Output only. If the Model artifact is being exported to Google Cloud Storage this is
          #     the full path of the directory created, into which the Model files are
          #     being written to.
          # @!attribute [rw] image_output_uri
          #   @return [String]
          #     Output only. If the Model image is being exported to Google Container Registry or
          #     Artifact Registry this is the full path of the image created.
          class OutputInfo; end
        end

        # Response message of {Google::Cloud::Aiplatform::V1::ModelService::ExportModel ModelService::ExportModel} operation.
        class ExportModelResponse; end

        # Request message for {Google::Cloud::Aiplatform::V1::ModelService::GetModelEvaluation ModelService::GetModelEvaluation}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the ModelEvaluation resource.
        #     Format:
        #
        #     `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}`
        class GetModelEvaluationRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1::ModelService::ListModelEvaluations ModelService::ListModelEvaluations}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The resource name of the Model to list the ModelEvaluations from.
        #     Format: `projects/{project}/locations/{location}/models/{model}`
        # @!attribute [rw] filter
        #   @return [String]
        #     The standard list filter.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The standard list page size.
        # @!attribute [rw] page_token
        #   @return [String]
        #     The standard list page token.
        #     Typically obtained via
        #     {Google::Cloud::Aiplatform::V1::ListModelEvaluationsResponse#next_page_token ListModelEvaluationsResponse#next_page_token} of the previous
        #     {Google::Cloud::Aiplatform::V1::ModelService::ListModelEvaluations ModelService::ListModelEvaluations} call.
        # @!attribute [rw] read_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Mask specifying which fields to read.
        class ListModelEvaluationsRequest; end

        # Response message for {Google::Cloud::Aiplatform::V1::ModelService::ListModelEvaluations ModelService::ListModelEvaluations}.
        # @!attribute [rw] model_evaluations
        #   @return [Array<Google::Cloud::Aiplatform::V1::ModelEvaluation>]
        #     List of ModelEvaluations in the requested page.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token to retrieve next page of results.
        #     Pass to {Google::Cloud::Aiplatform::V1::ListModelEvaluationsRequest#page_token ListModelEvaluationsRequest#page_token} to obtain that page.
        class ListModelEvaluationsResponse; end

        # Request message for {Google::Cloud::Aiplatform::V1::ModelService::GetModelEvaluationSlice ModelService::GetModelEvaluationSlice}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the ModelEvaluationSlice resource.
        #     Format:
        #
        #     `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}`
        class GetModelEvaluationSliceRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1::ModelService::ListModelEvaluationSlices ModelService::ListModelEvaluationSlices}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The resource name of the ModelEvaluation to list the ModelEvaluationSlices
        #     from. Format:
        #
        #     `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}`
        # @!attribute [rw] filter
        #   @return [String]
        #     The standard list filter.
        #
        #     * `slice.dimension` - for =.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The standard list page size.
        # @!attribute [rw] page_token
        #   @return [String]
        #     The standard list page token.
        #     Typically obtained via
        #     {Google::Cloud::Aiplatform::V1::ListModelEvaluationSlicesResponse#next_page_token ListModelEvaluationSlicesResponse#next_page_token} of the previous
        #     {Google::Cloud::Aiplatform::V1::ModelService::ListModelEvaluationSlices ModelService::ListModelEvaluationSlices} call.
        # @!attribute [rw] read_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Mask specifying which fields to read.
        class ListModelEvaluationSlicesRequest; end

        # Response message for {Google::Cloud::Aiplatform::V1::ModelService::ListModelEvaluationSlices ModelService::ListModelEvaluationSlices}.
        # @!attribute [rw] model_evaluation_slices
        #   @return [Array<Google::Cloud::Aiplatform::V1::ModelEvaluationSlice>]
        #     List of ModelEvaluations in the requested page.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token to retrieve next page of results.
        #     Pass to {Google::Cloud::Aiplatform::V1::ListModelEvaluationSlicesRequest#page_token ListModelEvaluationSlicesRequest#page_token} to obtain that
        #     page.
        class ListModelEvaluationSlicesResponse; end
      end
    end
  end
end