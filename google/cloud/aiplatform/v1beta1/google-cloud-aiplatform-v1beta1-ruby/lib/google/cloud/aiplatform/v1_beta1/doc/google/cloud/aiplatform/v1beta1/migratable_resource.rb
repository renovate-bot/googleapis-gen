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
        # Represents one resource that exists in automl.googleapis.com,
        # datalabeling.googleapis.com or ml.googleapis.com.
        # @!attribute [rw] ml_engine_model_version
        #   @return [Google::Cloud::Aiplatform::V1beta1::MigratableResource::MlEngineModelVersion]
        #     Output only. Represents one Version in ml.googleapis.com.
        # @!attribute [rw] automl_model
        #   @return [Google::Cloud::Aiplatform::V1beta1::MigratableResource::AutomlModel]
        #     Output only. Represents one Model in automl.googleapis.com.
        # @!attribute [rw] automl_dataset
        #   @return [Google::Cloud::Aiplatform::V1beta1::MigratableResource::AutomlDataset]
        #     Output only. Represents one Dataset in automl.googleapis.com.
        # @!attribute [rw] data_labeling_dataset
        #   @return [Google::Cloud::Aiplatform::V1beta1::MigratableResource::DataLabelingDataset]
        #     Output only. Represents one Dataset in datalabeling.googleapis.com.
        # @!attribute [rw] last_migrate_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. Timestamp when last migrate attempt on this MigratableResource started.
        #     Will not be set if there's no migrate attempt on this MigratableResource.
        # @!attribute [rw] last_update_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. Timestamp when this MigratableResource was last updated.
        class MigratableResource
          # Represents one model Version in ml.googleapis.com.
          # @!attribute [rw] endpoint
          #   @return [String]
          #     The ml.googleapis.com endpoint that this model Version currently lives
          #     in.
          #     Example values:
          #
          #     * ml.googleapis.com
          #     * us-centrall-ml.googleapis.com
          #     * europe-west4-ml.googleapis.com
          #     * asia-east1-ml.googleapis.com
          # @!attribute [rw] version
          #   @return [String]
          #     Full resource name of ml engine model Version.
          #     Format: `projects/{project}/models/{model}/versions/{version}`.
          class MlEngineModelVersion; end

          # Represents one Model in automl.googleapis.com.
          # @!attribute [rw] model
          #   @return [String]
          #     Full resource name of automl Model.
          #     Format:
          #     `projects/{project}/locations/{location}/models/{model}`.
          # @!attribute [rw] model_display_name
          #   @return [String]
          #     The Model's display name in automl.googleapis.com.
          class AutomlModel; end

          # Represents one Dataset in automl.googleapis.com.
          # @!attribute [rw] dataset
          #   @return [String]
          #     Full resource name of automl Dataset.
          #     Format:
          #     `projects/{project}/locations/{location}/datasets/{dataset}`.
          # @!attribute [rw] dataset_display_name
          #   @return [String]
          #     The Dataset's display name in automl.googleapis.com.
          class AutomlDataset; end

          # Represents one Dataset in datalabeling.googleapis.com.
          # @!attribute [rw] dataset
          #   @return [String]
          #     Full resource name of data labeling Dataset.
          #     Format:
          #     `projects/{project}/datasets/{dataset}`.
          # @!attribute [rw] dataset_display_name
          #   @return [String]
          #     The Dataset's display name in datalabeling.googleapis.com.
          # @!attribute [rw] data_labeling_annotated_datasets
          #   @return [Array<Google::Cloud::Aiplatform::V1beta1::MigratableResource::DataLabelingDataset::DataLabelingAnnotatedDataset>]
          #     The migratable AnnotatedDataset in datalabeling.googleapis.com belongs to
          #     the data labeling Dataset.
          class DataLabelingDataset
            # Represents one AnnotatedDataset in datalabeling.googleapis.com.
            # @!attribute [rw] annotated_dataset
            #   @return [String]
            #     Full resource name of data labeling AnnotatedDataset.
            #     Format:
            #
            #     `projects/{project}/datasets/{dataset}/annotatedDatasets/{annotated_dataset}`.
            # @!attribute [rw] annotated_dataset_display_name
            #   @return [String]
            #     The AnnotatedDataset's display name in datalabeling.googleapis.com.
            class DataLabelingAnnotatedDataset; end
          end
        end
      end
    end
  end
end