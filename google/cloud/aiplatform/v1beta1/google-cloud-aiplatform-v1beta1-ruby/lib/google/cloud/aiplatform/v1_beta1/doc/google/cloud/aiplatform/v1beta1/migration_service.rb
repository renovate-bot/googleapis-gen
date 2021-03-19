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
        # Request message for {Google::Cloud::Aiplatform::V1beta1::MigrationService::SearchMigratableResources MigrationService::SearchMigratableResources}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The location that the migratable resources should be searched from.
        #     It's the AI Platform location that the resources can be migrated to, not
        #     the resources' original location.
        #     Format:
        #     `projects/{project}/locations/{location}`
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The standard page size.
        #     The default and maximum value is 100.
        # @!attribute [rw] page_token
        #   @return [String]
        #     The standard page token.
        # @!attribute [rw] filter
        #   @return [String]
        #     Supported filters are:
        #     * Resource type: For a specific type of MigratableResource.
        #       * `ml_engine_model_version:*`
        #       * `automl_model:*`,
        #       * `automl_dataset:*`
        #       * `data_labeling_dataset:*`.
        #     * Migrated or not: Filter migrated resource or not by last_migrate_time.
        #       * `last_migrate_time:*` will filter migrated resources.
        #       * `NOT last_migrate_time:*` will filter not yet migrated resources.
        class SearchMigratableResourcesRequest; end

        # Response message for {Google::Cloud::Aiplatform::V1beta1::MigrationService::SearchMigratableResources MigrationService::SearchMigratableResources}.
        # @!attribute [rw] migratable_resources
        #   @return [Array<Google::Cloud::Aiplatform::V1beta1::MigratableResource>]
        #     All migratable resources that can be migrated to the
        #     location specified in the request.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     The standard next-page token.
        #     The migratable_resources may not fill page_size in
        #     SearchMigratableResourcesRequest even when there are subsequent pages.
        class SearchMigratableResourcesResponse; end

        # Request message for {Google::Cloud::Aiplatform::V1beta1::MigrationService::BatchMigrateResources MigrationService::BatchMigrateResources}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The location of the migrated resource will live in.
        #     Format: `projects/{project}/locations/{location}`
        # @!attribute [rw] migrate_resource_requests
        #   @return [Array<Google::Cloud::Aiplatform::V1beta1::MigrateResourceRequest>]
        #     Required. The request messages specifying the resources to migrate.
        #     They must be in the same location as the destination.
        #     Up to 50 resources can be migrated in one batch.
        class BatchMigrateResourcesRequest; end

        # Config of migrating one resource from automl.googleapis.com,
        # datalabeling.googleapis.com and ml.googleapis.com to AI Platform.
        # @!attribute [rw] migrate_ml_engine_model_version_config
        #   @return [Google::Cloud::Aiplatform::V1beta1::MigrateResourceRequest::MigrateMlEngineModelVersionConfig]
        #     Config for migrating Version in ml.googleapis.com to AI Platform's Model.
        # @!attribute [rw] migrate_automl_model_config
        #   @return [Google::Cloud::Aiplatform::V1beta1::MigrateResourceRequest::MigrateAutomlModelConfig]
        #     Config for migrating Model in automl.googleapis.com to AI Platform's
        #     Model.
        # @!attribute [rw] migrate_automl_dataset_config
        #   @return [Google::Cloud::Aiplatform::V1beta1::MigrateResourceRequest::MigrateAutomlDatasetConfig]
        #     Config for migrating Dataset in automl.googleapis.com to AI Platform's
        #     Dataset.
        # @!attribute [rw] migrate_data_labeling_dataset_config
        #   @return [Google::Cloud::Aiplatform::V1beta1::MigrateResourceRequest::MigrateDataLabelingDatasetConfig]
        #     Config for migrating Dataset in datalabeling.googleapis.com to
        #     AI Platform's Dataset.
        class MigrateResourceRequest
          # Config for migrating version in ml.googleapis.com to AI Platform's Model.
          # @!attribute [rw] endpoint
          #   @return [String]
          #     Required. The ml.googleapis.com endpoint that this model version should be migrated
          #     from.
          #     Example values:
          #
          #     * ml.googleapis.com
          #
          #     * us-centrall-ml.googleapis.com
          #
          #     * europe-west4-ml.googleapis.com
          #
          #     * asia-east1-ml.googleapis.com
          # @!attribute [rw] model_version
          #   @return [String]
          #     Required. Full resource name of ml engine model version.
          #     Format: `projects/{project}/models/{model}/versions/{version}`.
          # @!attribute [rw] model_display_name
          #   @return [String]
          #     Required. Display name of the model in AI Platform.
          #     System will pick a display name if unspecified.
          class MigrateMlEngineModelVersionConfig; end

          # Config for migrating Model in automl.googleapis.com to AI Platform's Model.
          # @!attribute [rw] model
          #   @return [String]
          #     Required. Full resource name of automl Model.
          #     Format:
          #     `projects/{project}/locations/{location}/models/{model}`.
          # @!attribute [rw] model_display_name
          #   @return [String]
          #     Optional. Display name of the model in AI Platform.
          #     System will pick a display name if unspecified.
          class MigrateAutomlModelConfig; end

          # Config for migrating Dataset in automl.googleapis.com to AI Platform's
          # Dataset.
          # @!attribute [rw] dataset
          #   @return [String]
          #     Required. Full resource name of automl Dataset.
          #     Format:
          #     `projects/{project}/locations/{location}/datasets/{dataset}`.
          # @!attribute [rw] dataset_display_name
          #   @return [String]
          #     Required. Display name of the Dataset in AI Platform.
          #     System will pick a display name if unspecified.
          class MigrateAutomlDatasetConfig; end

          # Config for migrating Dataset in datalabeling.googleapis.com to AI
          # Platform's Dataset.
          # @!attribute [rw] dataset
          #   @return [String]
          #     Required. Full resource name of data labeling Dataset.
          #     Format:
          #     `projects/{project}/datasets/{dataset}`.
          # @!attribute [rw] dataset_display_name
          #   @return [String]
          #     Optional. Display name of the Dataset in AI Platform.
          #     System will pick a display name if unspecified.
          # @!attribute [rw] migrate_data_labeling_annotated_dataset_configs
          #   @return [Array<Google::Cloud::Aiplatform::V1beta1::MigrateResourceRequest::MigrateDataLabelingDatasetConfig::MigrateDataLabelingAnnotatedDatasetConfig>]
          #     Optional. Configs for migrating AnnotatedDataset in datalabeling.googleapis.com to
          #     AI Platform's SavedQuery. The specified AnnotatedDatasets have to belong
          #     to the datalabeling Dataset.
          class MigrateDataLabelingDatasetConfig
            # Config for migrating AnnotatedDataset in datalabeling.googleapis.com to
            # AI Platform's SavedQuery.
            # @!attribute [rw] annotated_dataset
            #   @return [String]
            #     Required. Full resource name of data labeling AnnotatedDataset.
            #     Format:
            #     `projects/{project}/datasets/{dataset}/annotatedDatasets/{annotated_dataset}`.
            class MigrateDataLabelingAnnotatedDatasetConfig; end
          end
        end

        # Response message for {Google::Cloud::Aiplatform::V1beta1::MigrationService::BatchMigrateResources MigrationService::BatchMigrateResources}.
        # @!attribute [rw] migrate_resource_responses
        #   @return [Array<Google::Cloud::Aiplatform::V1beta1::MigrateResourceResponse>]
        #     Successfully migrated resources.
        class BatchMigrateResourcesResponse; end

        # Describes a successfully migrated resource.
        # @!attribute [rw] dataset
        #   @return [String]
        #     Migrated Dataset's resource name.
        # @!attribute [rw] model
        #   @return [String]
        #     Migrated Model's resource name.
        # @!attribute [rw] migratable_resource
        #   @return [Google::Cloud::Aiplatform::V1beta1::MigratableResource]
        #     Before migration, the identifier in ml.googleapis.com,
        #     automl.googleapis.com or datalabeling.googleapis.com.
        class MigrateResourceResponse; end

        # Runtime operation information for {Google::Cloud::Aiplatform::V1beta1::MigrationService::BatchMigrateResources MigrationService::BatchMigrateResources}.
        # @!attribute [rw] generic_metadata
        #   @return [Google::Cloud::Aiplatform::V1beta1::GenericOperationMetadata]
        #     The common part of the operation metadata.
        # @!attribute [rw] partial_results
        #   @return [Array<Google::Cloud::Aiplatform::V1beta1::BatchMigrateResourcesOperationMetadata::PartialResult>]
        #     Partial results that reflect the latest migration operation progress.
        class BatchMigrateResourcesOperationMetadata
          # Represents a partial result in batch migration operation for one
          # {Google::Cloud::Aiplatform::V1beta1::MigrateResourceRequest MigrateResourceRequest}.
          # @!attribute [rw] error
          #   @return [Google::Rpc::Status]
          #     The error result of the migration request in case of failure.
          # @!attribute [rw] model
          #   @return [String]
          #     Migrated model resource name.
          # @!attribute [rw] dataset
          #   @return [String]
          #     Migrated dataset resource name.
          # @!attribute [rw] request
          #   @return [Google::Cloud::Aiplatform::V1beta1::MigrateResourceRequest]
          #     It's the same as the value in
          #     {MigrateResourceRequest#migrate_resource_requests}.
          class PartialResult; end
        end
      end
    end
  end
end