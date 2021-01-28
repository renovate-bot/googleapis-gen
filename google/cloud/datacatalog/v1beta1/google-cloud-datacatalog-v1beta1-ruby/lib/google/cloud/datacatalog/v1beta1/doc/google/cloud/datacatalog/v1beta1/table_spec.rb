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
    module Datacatalog
      module V1beta1
        # Describes a BigQuery table.
        # @!attribute [rw] table_source_type
        #   @return [Google::Cloud::Datacatalog::V1beta1::TableSourceType]
        #     Output only. The table source type.
        # @!attribute [rw] view_spec
        #   @return [Google::Cloud::Datacatalog::V1beta1::ViewSpec]
        #     Table view specification. This field should only be populated if
        #     `table_source_type` is `BIGQUERY_VIEW`.
        # @!attribute [rw] table_spec
        #   @return [Google::Cloud::Datacatalog::V1beta1::TableSpec]
        #     Spec of a BigQuery table. This field should only be populated if
        #     `table_source_type` is `BIGQUERY_TABLE`.
        class BigQueryTableSpec; end

        # Table view specification.
        # @!attribute [rw] view_query
        #   @return [String]
        #     Output only. The query that defines the table view.
        class ViewSpec; end

        # Normal BigQuery table spec.
        # @!attribute [rw] grouped_entry
        #   @return [String]
        #     Output only. If the table is a dated shard, i.e., with name pattern `[prefix]YYYYMMDD`,
        #     `grouped_entry` is the Data Catalog resource name of the date sharded
        #     grouped entry, for example,
        #     `projects/{project_id}/locations/{location}/entrygroups/{entry_group_id}/entries/{entry_id}`.
        #     Otherwise, `grouped_entry` is empty.
        class TableSpec; end

        # Spec for a group of BigQuery tables with name pattern `[prefix]YYYYMMDD`.
        # Context:
        # https://cloud.google.com/bigquery/docs/partitioned-tables#partitioning_versus_sharding
        # @!attribute [rw] dataset
        #   @return [String]
        #     Output only. The Data Catalog resource name of the dataset entry the current table
        #     belongs to, for example,
        #     `projects/{project_id}/locations/{location}/entrygroups/{entry_group_id}/entries/{entry_id}`.
        # @!attribute [rw] table_prefix
        #   @return [String]
        #     Output only. The table name prefix of the shards. The name of any given shard is
        #     `[table_prefix]YYYYMMDD`, for example, for shard `MyTable20180101`, the
        #     `table_prefix` is `MyTable`.
        # @!attribute [rw] shard_count
        #   @return [Integer]
        #     Output only. Total number of shards.
        class BigQueryDateShardedSpec; end

        # Table source type.
        module TableSourceType
          # Default unknown type.
          TABLE_SOURCE_TYPE_UNSPECIFIED = 0

          # Table view.
          BIGQUERY_VIEW = 2

          # BigQuery native table.
          BIGQUERY_TABLE = 5
        end
      end
    end
  end
end