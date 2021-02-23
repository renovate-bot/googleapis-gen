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
    module Asset
      module V1p7beta1
        # Export asset request.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The relative name of the root asset. This can only be an
        #     organization number (such as "organizations/123"), a project ID (such as
        #     "projects/my-project-id"), or a project number (such as "projects/12345"),
        #     or a folder number (such as "folders/123").
        # @!attribute [rw] read_time
        #   @return [Google::Protobuf::Timestamp]
        #     Timestamp to take an asset snapshot. This can only be set to a timestamp
        #     between the current time and the current time minus 35 days (inclusive).
        #     If not specified, the current time will be used. Due to delays in resource
        #     data collection and indexing, there is a volatile window during which
        #     running the same query may get different results.
        # @!attribute [rw] asset_types
        #   @return [Array<String>]
        #     A list of asset types to take a snapshot for. For example:
        #     "compute.googleapis.com/Disk".
        #
        #     Regular expressions are also supported. For example:
        #
        #     * "compute.googleapis.com.*" snapshots resources whose asset type starts
        #       with "compute.googleapis.com".
        #     * ".*Instance" snapshots resources whose asset type ends with "Instance".
        #     * ".*Instance.*" snapshots resources whose asset type contains "Instance".
        #
        #     See [RE2](https://github.com/google/re2/wiki/Syntax) for all supported
        #     regular expression syntax. If the regular expression does not match any
        #     supported asset type, an INVALID_ARGUMENT error will be returned.
        #
        #     If specified, only matching assets will be returned, otherwise, it will
        #     snapshot all asset types. See [Introduction to Cloud Asset
        #     Inventory](https://cloud.google.com/asset-inventory/docs/overview)
        #     for all supported asset types.
        # @!attribute [rw] content_type
        #   @return [Google::Cloud::Asset::V1p7beta1::ContentType]
        #     Asset content type. If not specified, no content but the asset name will be
        #     returned.
        # @!attribute [rw] output_config
        #   @return [Google::Cloud::Asset::V1p7beta1::OutputConfig]
        #     Required. Output configuration indicating where the results will be output
        #     to.
        # @!attribute [rw] relationship_types
        #   @return [Array<String>]
        #     A list of relationship types to export, for example:
        #     `INSTANCE_TO_INSTANCEGROUP`. This field should only be specified if
        #     content_type=RELATIONSHIP. If specified, it will snapshot [asset_types]'
        #     specified relationships, or give errors if any relationship_types'
        #     supported types are not in [asset_types]. If not specified, it will
        #     snapshot all [asset_types]' supported relationships. An unspecified
        #     [asset_types] field means all supported asset_types. See [Introduction to
        #     Cloud Asset
        #     Inventory](https://cloud.google.com/asset-inventory/docs/overview) for all
        #     supported asset types and relationship types.
        class ExportAssetsRequest; end

        # The export asset response. This message is returned by the
        # {Google::Longrunning::Operations::GetOperation}
        # method in the returned
        # {Google::Longrunning::Operation#response}
        # field.
        # @!attribute [rw] read_time
        #   @return [Google::Protobuf::Timestamp]
        #     Time the snapshot was taken.
        # @!attribute [rw] output_config
        #   @return [Google::Cloud::Asset::V1p7beta1::OutputConfig]
        #     Output configuration indicating where the results were output to.
        # @!attribute [rw] output_result
        #   @return [Google::Cloud::Asset::V1p7beta1::OutputResult]
        #     Output result indicating where the assets were exported to. For example, a
        #     set of actual Google Cloud Storage object uris where the assets are
        #     exported to. The uris can be different from what [output_config] has
        #     specified, as the service will split the output object into multiple ones
        #     once it exceeds a single Google Cloud Storage object limit.
        class ExportAssetsResponse; end

        # Output configuration for export assets destination.
        # @!attribute [rw] gcs_destination
        #   @return [Google::Cloud::Asset::V1p7beta1::GcsDestination]
        #     Destination on Cloud Storage.
        # @!attribute [rw] bigquery_destination
        #   @return [Google::Cloud::Asset::V1p7beta1::BigQueryDestination]
        #     Destination on BigQuery. The output table stores the fields in asset
        #     proto as columns in BigQuery.
        class OutputConfig; end

        # A Cloud Storage location.
        # @!attribute [rw] uri
        #   @return [String]
        #     The uri of the Cloud Storage object. It's the same uri that is used by
        #     gsutil. Example: "gs://bucket_name/object_name". See [Viewing and
        #     Editing Object
        #     Metadata](https://cloud.google.com/storage/docs/viewing-editing-metadata)
        #     for more information.
        # @!attribute [rw] uri_prefix
        #   @return [String]
        #     The uri prefix of all generated Cloud Storage objects. Example:
        #     "gs://bucket_name/object_name_prefix". Each object uri is in format:
        #     "gs://bucket_name/object_name_prefix/{ASSET_TYPE}/{SHARD_NUMBER} and only
        #     contains assets for that type. <shard number> starts from 0. Example:
        #     "gs://bucket_name/object_name_prefix/compute.googleapis.com/Disk/0" is
        #     the first shard of output objects containing all
        #     compute.googleapis.com/Disk assets. An INVALID_ARGUMENT error will be
        #     returned if file with the same name "gs://bucket_name/object_name_prefix"
        #     already exists.
        class GcsDestination; end

        # A BigQuery destination for exporting assets to.
        # @!attribute [rw] dataset
        #   @return [String]
        #     Required. The BigQuery dataset in format
        #     "projects/projectId/datasets/datasetId", to which the snapshot result
        #     should be exported. If this dataset does not exist, the export call returns
        #     an INVALID_ARGUMENT error.
        # @!attribute [rw] table
        #   @return [String]
        #     Required. The BigQuery table to which the snapshot result should be
        #     written. If this table does not exist, a new table with the given name
        #     will be created.
        # @!attribute [rw] force
        #   @return [true, false]
        #     If the destination table already exists and this flag is `TRUE`, the
        #     table will be overwritten by the contents of assets snapshot. If the flag
        #     is `FALSE` or unset and the destination table already exists, the export
        #     call returns an INVALID_ARGUMEMT error.
        # @!attribute [rw] partition_spec
        #   @return [Google::Cloud::Asset::V1p7beta1::PartitionSpec]
        #     [partition_spec] determines whether to export to partitioned table(s) and
        #     how to partition the data.
        #
        #     If [partition_spec] is unset or [partition_spec.partition_key] is unset or
        #     `PARTITION_KEY_UNSPECIFIED`, the snapshot results will be exported to
        #     non-partitioned table(s). [force] will decide whether to overwrite existing
        #     table(s).
        #
        #     If [partition_spec] is specified. First, the snapshot results will be
        #     written to partitioned table(s) with two additional timestamp columns,
        #     readTime and requestTime, one of which will be the partition key. Secondly,
        #     in the case when any destination table already exists, it will first try to
        #     update existing table's schema as necessary by appending additional
        #     columns. Then, if [force] is `TRUE`, the corresponding partition will be
        #     overwritten by the snapshot results (data in different partitions will
        #     remain intact); if [force] is unset or `FALSE`, it will append the data. An
        #     error will be returned if the schema update or data appension fails.
        # @!attribute [rw] separate_tables_per_asset_type
        #   @return [true, false]
        #     If this flag is `TRUE`, the snapshot results will be written to one or
        #     multiple tables, each of which contains results of one asset type. The
        #     [force] and [partition_spec] fields will apply to each of them.
        #
        #     Field [table] will be concatenated with "_" and the asset type names (see
        #     https://cloud.google.com/asset-inventory/docs/supported-asset-types for
        #     supported asset types) to construct per-asset-type table names, in which
        #     all non-alphanumeric characters like "." and "/" will be substituted by
        #     "_". Example: if field [table] is "mytable" and snapshot results
        #     contain "storage.googleapis.com/Bucket" assets, the corresponding table
        #     name will be "mytable_storage_googleapis_com_Bucket". If any of these
        #     tables does not exist, a new table with the concatenated name will be
        #     created.
        #
        #     When [content_type] in the ExportAssetsRequest is `RESOURCE`, the schema of
        #     each table will include RECORD-type columns mapped to the nested fields in
        #     the Asset.resource.data field of that asset type (up to the 15 nested level
        #     BigQuery supports
        #     (https://cloud.google.com/bigquery/docs/nested-repeated#limitations)). The
        #     fields in >15 nested levels will be stored in JSON format string as a child
        #     column of its parent RECORD column.
        #
        #     If error occurs when exporting to any table, the whole export call will
        #     return an error but the export results that already succeed will persist.
        #     Example: if exporting to table_type_A succeeds when exporting to
        #     table_type_B fails during one export call, the results in table_type_A will
        #     persist and there will not be partial results persisting in a table.
        class BigQueryDestination; end

        # Specifications of BigQuery partitioned table as export destination.
        # @!attribute [rw] partition_key
        #   @return [Google::Cloud::Asset::V1p7beta1::PartitionSpec::PartitionKey]
        #     The partition key for BigQuery partitioned table.
        class PartitionSpec
          # This enum is used to determine the partition key column when exporting
          # assets to BigQuery partitioned table(s). Note that, if the partition key is
          # a timestamp column, the actual partition is based on its date value
          # (expressed in UTC. see details in
          # https://cloud.google.com/bigquery/docs/partitioned-tables#date_timestamp_partitioned_tables).
          module PartitionKey
            # Unspecified partition key. If used, it means using non-partitioned table.
            PARTITION_KEY_UNSPECIFIED = 0

            # The time when the snapshot is taken. If specified as partition key, the
            # result table(s) is partitoned by the additional timestamp column,
            # readTime. If [read_time] in ExportAssetsRequest is specified, the
            # readTime column's value will be the same as it. Otherwise, its value will
            # be the current time that is used to take the snapshot.
            READ_TIME = 1

            # The time when the request is received and started to be processed. If
            # specified as partition key, the result table(s) is partitoned by the
            # requestTime column, an additional timestamp column representing when the
            # request was received.
            REQUEST_TIME = 2
          end
        end

        # Asset content type.
        module ContentType
          # Unspecified content type.
          CONTENT_TYPE_UNSPECIFIED = 0

          # Resource metadata.
          RESOURCE = 1

          # The actual IAM policy set on a resource.
          IAM_POLICY = 2

          # The Cloud Organization Policy set on an asset.
          ORG_POLICY = 4

          # The Cloud Access context manager Policy set on an asset.
          ACCESS_POLICY = 5

          # The related resources.
          RELATIONSHIP = 7
        end
      end
    end
  end
end