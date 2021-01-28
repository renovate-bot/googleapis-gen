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
    module Metastore
      module V1alpha
        # A managed metastore service that serves metadata queries.
        # @!attribute [rw] name
        #   @return [String]
        #     Immutable. The relative resource name of the metastore service, of the form:
        #
        #     "projects/{project_id}/locations/{location_id}/services/{service_id}".
        # @!attribute [rw] create_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. The time when the metastore service was created.
        # @!attribute [rw] update_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. The time when the metastore service was last updated.
        # @!attribute [rw] labels
        #   @return [Hash{String => String}]
        #     User-defined labels for the metastore service.
        # @!attribute [rw] hive_metastore_config
        #   @return [Google::Cloud::Metastore::V1alpha::HiveMetastoreConfig]
        #     Configuration information specific to running Hive metastore
        #     software as the metastore service.
        # @!attribute [rw] network
        #   @return [String]
        #     Immutable. The relative resource name of the VPC network on which the instance can be
        #     accessed. The network must belong to the same project as the metastore
        #     instance. It is specified in the following form:
        #
        #     "projects/{project_id}/global/networks/{network_id}".
        # @!attribute [rw] endpoint_uri
        #   @return [String]
        #     Output only. The URI of the endpoint used to access the metastore service.
        # @!attribute [rw] port
        #   @return [Integer]
        #     The TCP port at which the metastore service is reached. Default: 9083.
        # @!attribute [rw] state
        #   @return [Google::Cloud::Metastore::V1alpha::Service::State]
        #     Output only. The current state of the metastore service.
        # @!attribute [rw] state_message
        #   @return [String]
        #     Output only. Additional information about the current state of the metastore service, if
        #     available.
        # @!attribute [rw] artifact_gcs_uri
        #   @return [String]
        #     Output only. A Cloud Storage URI (starting with `gs://`) that specifies where artifacts
        #     related to the metastore service are stored.
        # @!attribute [rw] tier
        #   @return [Google::Cloud::Metastore::V1alpha::Service::Tier]
        #     The tier of the service.
        class Service
          # The current state of the metastore service.
          module State
            # The state of the metastore service is unknown.
            STATE_UNSPECIFIED = 0

            # The metastore service is in the process of being created.
            CREATING = 1

            # The metastore service is running and ready to serve queries.
            ACTIVE = 2

            # The metastore service is entering suspension. Its query-serving
            # availability may cease unexpectedly.
            SUSPENDING = 3

            # The metastore service is suspended and unable to serve queries.
            SUSPENDED = 4

            # The metastore service is being updated. It remains usable but cannot
            # accept additional update requests or be deleted at this time.
            UPDATING = 5

            # The metastore service is undergoing deletion. It cannot be used.
            DELETING = 6

            # The metastore service has encountered an error and cannot be used. The
            # metastore service should be deleted.
            ERROR = 7
          end

          # Available service tiers.
          module Tier
            # The tier is not set.
            TIER_UNSPECIFIED = 0

            # The enterprise tier combines a powerful metastore serving layer with a
            # highly scalable data storage layer.
            ENTERPRISE = 3
          end
        end

        # Specifies configuration information specific to running Hive metastore
        # software as the metastore service.
        # @!attribute [rw] version
        #   @return [String]
        #     Immutable. The Hive metastore schema version.
        # @!attribute [rw] config_overrides
        #   @return [Hash{String => String}]
        #     A mapping of Hive metastore configuration key-value pairs to apply to the
        #     Hive metastore (configured in `hive-site.xml`). The mappings
        #     override system defaults (some keys cannot be overridden).
        # @!attribute [rw] kerberos_config
        #   @return [Google::Cloud::Metastore::V1alpha::KerberosConfig]
        #     Information used to configure the Hive metastore service as a service
        #     principal in a Kerberos realm.
        class HiveMetastoreConfig; end

        # Configuration information for a Kerberos principal.
        # @!attribute [rw] keytab
        #   @return [Google::Cloud::Metastore::V1alpha::Secret]
        #     A Kerberos keytab file that can be used to authenticate a service principal
        #     with a Kerberos Key Distribution Center (KDC).
        # @!attribute [rw] principal
        #   @return [String]
        #     A Kerberos principal that exists in the both the keytab the KDC
        #     to authenticate as. A typical principal is of the form
        #     "primary/instance@REALM", but there is no exact format.
        # @!attribute [rw] krb5_config_gcs_uri
        #   @return [String]
        #     A Cloud Storage URI that specifies the path to a
        #     krb5.conf file. It is of the form gs://{bucket_name}/path/to/krb5.conf,
        #     although the file does not need to be named krb5.conf explicitly.
        class KerberosConfig; end

        # A securely stored value.
        # @!attribute [rw] cloud_secret
        #   @return [String]
        #     The relative resource name of a Secret Manager secret version, in the
        #     following form:
        #
        #     "projects/{project_id}/secrets/{secret_id}/versions/{version_id}".
        class Secret; end

        # A metastore resource that imports metadata.
        # @!attribute [rw] name
        #   @return [String]
        #     Immutable. The relative resource name of the metadata import, of the form:
        #
        #     "projects/{project_id}/locations/{location_id}/services/{service_id}/metadataImports/{metadata_import_id}".
        # @!attribute [rw] description
        #   @return [String]
        #     The description of the metadata import.
        # @!attribute [rw] create_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. The time when the metadata import was created.
        # @!attribute [rw] update_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. The time when the metadata import was last updated.
        # @!attribute [rw] state
        #   @return [Google::Cloud::Metastore::V1alpha::MetadataImport::State]
        #     Output only. The current state of the metadata import.
        # @!attribute [rw] database_dump
        #   @return [Google::Cloud::Metastore::V1alpha::MetadataImport::DatabaseDump]
        #     Immutable. A database dump from a pre-existing metastore's database.
        class MetadataImport
          # A specification of the location of and metadata about a database dump from
          # a relational database management system.
          # @!attribute [rw] database_type
          #   @return [Google::Cloud::Metastore::V1alpha::MetadataImport::DatabaseDump::DatabaseType]
          #     The type of the database.
          # @!attribute [rw] gcs_uri
          #   @return [String]
          #     A Cloud Storage object URI that specifies the source from which to
          #     import metadata. It must begin with `gs://`.
          # @!attribute [rw] source_database
          #   @return [String]
          #     The name of the source database.
          class DatabaseDump
            # The type of the database.
            module DatabaseType
              # The type of the source database is unknown.
              DATABASE_TYPE_UNSPECIFIED = 0

              # The type of the source database is MySQL.
              MYSQL = 1
            end
          end

          # The current state of the metadata import.
          module State
            # The state of the metadata import is unknown.
            STATE_UNSPECIFIED = 0

            # The metadata import is running.
            RUNNING = 1

            # The metadata import completed successfully.
            SUCCEEDED = 2

            # The metadata import is being updated.
            UPDATING = 3

            # The metadata import failed, and attempted metadata changes were rolled
            # back.
            FAILED = 4
          end
        end

        # Request message for {Google::Cloud::Metastore::V1alpha::DataprocMetastore::ListServices DataprocMetastore::ListServices}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The relative resource name of the location of metastore services to
        #     list, in the following form:
        #
        #     "projects/{project_id}/locations/{location_id}".
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     Optional. The maximum number of services to return. The response may contain less
        #     than the maximum number. If unspecified, no more than 500 services are
        #     returned. The maximum value is 1000; values above 1000 are changed to 1000.
        # @!attribute [rw] page_token
        #   @return [String]
        #     Optional. A page token, received from a previous {Google::Cloud::Metastore::V1alpha::DataprocMetastore::ListServices DataprocMetastore::ListServices}
        #     call. Provide this token to retrieve the subsequent page.
        #
        #     To retrieve the first page, supply an empty page token.
        #
        #     When paginating, other parameters provided to
        #     {Google::Cloud::Metastore::V1alpha::DataprocMetastore::ListServices DataprocMetastore::ListServices} must match the call that provided the
        #     page token.
        # @!attribute [rw] filter
        #   @return [String]
        #     Optional. The filter to apply to list results.
        # @!attribute [rw] order_by
        #   @return [String]
        #     Optional. Specify the ordering of results as described in
        #     [Sorting Order](https://cloud.google.com/apis/design/design_patterns#sorting_order). If not
        #     specified, the results will be sorted in the default order.
        class ListServicesRequest; end

        # Response message for {Google::Cloud::Metastore::V1alpha::DataprocMetastore::ListServices DataprocMetastore::ListServices}.
        # @!attribute [rw] services
        #   @return [Array<Google::Cloud::Metastore::V1alpha::Service>]
        #     The services in the specified location.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token that can be sent as `page_token` to retrieve the next page. If this
        #     field is omitted, there are no subsequent pages.
        # @!attribute [rw] unreachable
        #   @return [Array<String>]
        #     Locations that could not be reached.
        class ListServicesResponse; end

        # Request message for {Google::Cloud::Metastore::V1alpha::DataprocMetastore::GetService DataprocMetastore::GetService}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The relative resource name of the metastore service to retrieve, in the
        #     following form:
        #
        #     "projects/{project_id}/locations/{location_id}/services/{service_id}".
        class GetServiceRequest; end

        # Request message for {Google::Cloud::Metastore::V1alpha::DataprocMetastore::CreateService DataprocMetastore::CreateService}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The relative resource name of the location in which to create a metastore
        #     service, in the following form:
        #
        #     "projects/{project_id}/locations/{location_id}".
        # @!attribute [rw] service_id
        #   @return [String]
        #     Required. The ID of the metastore service, which is used as the final
        #     component of the metastore service's name.
        #
        #     This value must be between 1 and 64 characters long, begin with a
        #     letter, end with a letter or number, and consist of alpha-numeric
        #     ASCII characters or hyphens.
        # @!attribute [rw] service
        #   @return [Google::Cloud::Metastore::V1alpha::Service]
        #     Required. The Metastore service to create. The `name` field is
        #     ignored. The ID of the created metastore service must be provided in
        #     the request's `service_id` field.
        # @!attribute [rw] request_id
        #   @return [String]
        #     Optional. A request ID. Specify a unique request ID to allow the server to ignore the
        #     request if it has completed. The server will ignore subsequent requests
        #     that provide a duplicate request ID for at least 60 minutes after the first
        #     request.
        #
        #     For example, if an initial request times out, followed by another request
        #     with the same request ID, the server ignores the second request to prevent
        #     the creation of duplicate commitments.
        #
        #     The request ID must be a valid
        #     [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier#Format)
        #     A zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
        class CreateServiceRequest; end

        # Request message for {Google::Cloud::Metastore::V1alpha::DataprocMetastore::UpdateService DataprocMetastore::UpdateService}.
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Required. A field mask used to specify the fields to be overwritten in the
        #     metastore service resource by the update.
        #     Fields specified in the `update_mask` are relative to the resource (not
        #     to the full request). A field is overwritten if it is in the mask.
        # @!attribute [rw] service
        #   @return [Google::Cloud::Metastore::V1alpha::Service]
        #     Required. The metastore service to update. The server only merges fields
        #     in the service if they are specified in `update_mask`.
        #
        #     The metastore service's `name` field is used to identify the metastore
        #     service to be updated.
        # @!attribute [rw] request_id
        #   @return [String]
        #     Optional. A request ID. Specify a unique request ID to allow the server to ignore the
        #     request if it has completed. The server will ignore subsequent requests
        #     that provide a duplicate request ID for at least 60 minutes after the first
        #     request.
        #
        #     For example, if an initial request times out, followed by another request
        #     with the same request ID, the server ignores the second request to prevent
        #     the creation of duplicate commitments.
        #
        #     The request ID must be a valid
        #     [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier#Format)
        #     A zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
        class UpdateServiceRequest; end

        # Request message for {Google::Cloud::Metastore::V1alpha::DataprocMetastore::DeleteService DataprocMetastore::DeleteService}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The relative resource name of the metastore service to delete, in the
        #     following form:
        #
        #     "projects/{project_id}/locations/{location_id}/services/{service_id}".
        # @!attribute [rw] request_id
        #   @return [String]
        #     Optional. A request ID. Specify a unique request ID to allow the server to ignore the
        #     request if it has completed. The server will ignore subsequent requests
        #     that provide a duplicate request ID for at least 60 minutes after the first
        #     request.
        #
        #     For example, if an initial request times out, followed by another request
        #     with the same request ID, the server ignores the second request to prevent
        #     the creation of duplicate commitments.
        #
        #     The request ID must be a valid
        #     [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier#Format)
        #     A zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
        class DeleteServiceRequest; end

        # Request message for {Google::Cloud::Metastore::V1alpha::DataprocMetastore::ListMetadataImports DataprocMetastore::ListMetadataImports}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The relative resource name of the service whose metadata imports to
        #     list, in the following form:
        #
        #     "projects/{project_id}/locations/{location_id}/services/{service_id}/metadataImports".
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     Optional. The maximum number of imports to return. The response may contain less
        #     than the maximum number. If unspecified, no more than 500 imports are
        #     returned. The maximum value is 1000; values above 1000 are changed to 1000.
        # @!attribute [rw] page_token
        #   @return [String]
        #     Optional. A page token, received from a previous {Google::Cloud::Metastore::V1alpha::DataprocMetastore::ListServices DataprocMetastore::ListServices}
        #     call. Provide this token to retrieve the subsequent page.
        #
        #     To retrieve the first page, supply an empty page token.
        #
        #     When paginating, other parameters provided to
        #     {Google::Cloud::Metastore::V1alpha::DataprocMetastore::ListServices DataprocMetastore::ListServices} must match the call that provided the
        #     page token.
        # @!attribute [rw] filter
        #   @return [String]
        #     Optional. The filter to apply to list results.
        # @!attribute [rw] order_by
        #   @return [String]
        #     Optional. Specify the ordering of results as described in
        #     [Sorting Order](https://cloud.google.com/apis/design/design_patterns#sorting_order). If not
        #     specified, the results will be sorted in the default order.
        class ListMetadataImportsRequest; end

        # Response message for {Google::Cloud::Metastore::V1alpha::DataprocMetastore::ListMetadataImports DataprocMetastore::ListMetadataImports}.
        # @!attribute [rw] metadata_imports
        #   @return [Array<Google::Cloud::Metastore::V1alpha::MetadataImport>]
        #     The imports in the specified service.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token that can be sent as `page_token` to retrieve the next page. If this
        #     field is omitted, there are no subsequent pages.
        # @!attribute [rw] unreachable
        #   @return [Array<String>]
        #     Locations that could not be reached.
        class ListMetadataImportsResponse; end

        # Request message for {Google::Cloud::Metastore::V1alpha::DataprocMetastore::GetMetadataImport DataprocMetastore::GetMetadataImport}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The relative resource name of the metadata import to retrieve, in the
        #     following form:
        #
        #     "projects/{project_id}/locations/{location_id}/services/{service_id}/metadataImports/{import_id}".
        class GetMetadataImportRequest; end

        # Request message for {Google::Cloud::Metastore::V1alpha::DataprocMetastore::CreateMetadataImport DataprocMetastore::CreateMetadataImport}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The relative resource name of the service in which to create a metastore
        #     import, in the following form:
        #
        #     "projects/{project_id}/locations/{location_id}/services/{service_id}"
        # @!attribute [rw] metadata_import_id
        #   @return [String]
        #     Required. The ID of the metadata import, which is used as the final component of the
        #     metadata import's name.
        #
        #     This value must be between 1 and 64 characters long, begin with a letter,
        #     end with a letter or number, and consist of alpha-numeric ASCII characters
        #     or hyphens.
        # @!attribute [rw] metadata_import
        #   @return [Google::Cloud::Metastore::V1alpha::MetadataImport]
        #     Required. The metadata import to create. The `name` field is ignored. The ID of the
        #     created metadata import must be provided in the request's
        #     `metadata_import_id` field.
        # @!attribute [rw] request_id
        #   @return [String]
        #     Optional. A request ID. Specify a unique request ID to allow the server to ignore the
        #     request if it has completed. The server will ignore subsequent requests
        #     that provide a duplicate request ID for at least 60 minutes after the first
        #     request.
        #
        #     For example, if an initial request times out, followed by another request
        #     with the same request ID, the server ignores the second request to prevent
        #     the creation of duplicate commitments.
        #
        #     The request ID must be a valid
        #     [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier#Format)
        #     A zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
        class CreateMetadataImportRequest; end

        # Request message for {Google::Cloud::Metastore::V1alpha::DataprocMetastore::UpdateMetadataImport DataprocMetastore::UpdateMetadataImport}.
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Required. A field mask used to specify the fields to be overwritten in the
        #     metadata import resource by the update.
        #     Fields specified in the `update_mask` are relative to the resource (not
        #     to the full request). A field is overwritten if it is in the mask.
        # @!attribute [rw] metadata_import
        #   @return [Google::Cloud::Metastore::V1alpha::MetadataImport]
        #     Required. The metadata import to update. The server only merges fields
        #     in the import if they are specified in `update_mask`.
        #
        #     The metadata import's `name` field is used to identify the metastore
        #     import to be updated.
        # @!attribute [rw] request_id
        #   @return [String]
        #     Optional. A request ID. Specify a unique request ID to allow the server to ignore the
        #     request if it has completed. The server will ignore subsequent requests
        #     that provide a duplicate request ID for at least 60 minutes after the first
        #     request.
        #
        #     For example, if an initial request times out, followed by another request
        #     with the same request ID, the server ignores the second request to prevent
        #     the creation of duplicate commitments.
        #
        #     The request ID must be a valid
        #     [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier#Format)
        #     A zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
        class UpdateMetadataImportRequest; end

        # Represents the metadata of a long-running operation.
        # @!attribute [rw] create_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. The time the operation was created.
        # @!attribute [rw] end_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. The time the operation finished running.
        # @!attribute [rw] target
        #   @return [String]
        #     Output only. Server-defined resource path for the target of the operation.
        # @!attribute [rw] verb
        #   @return [String]
        #     Output only. Name of the verb executed by the operation.
        # @!attribute [rw] status_message
        #   @return [String]
        #     Output only. Human-readable status of the operation, if any.
        # @!attribute [rw] requested_cancellation
        #   @return [true, false]
        #     Output only. Identifies whether the caller has requested cancellation
        #     of the operation. Operations that have successfully been cancelled
        #     have {Operation#error} value with a {Google::Rpc::Status#code} of 1,
        #     corresponding to `Code.CANCELLED`.
        # @!attribute [rw] api_version
        #   @return [String]
        #     Output only. API version used to start the operation.
        class OperationMetadata; end

        # Metadata about the service in a location.
        # @!attribute [rw] supported_hive_metastore_versions
        #   @return [Array<Google::Cloud::Metastore::V1alpha::LocationMetadata::HiveMetastoreVersion>]
        #     The versions of Hive Metastore that can be used when creating a new
        #     metastore service in this location. The server guarantees that exactly one
        #     `HiveMetastoreVersion` in the list will set `is_default`.
        class LocationMetadata
          # A specification of a supported version of the Hive Metastore software.
          # @!attribute [rw] version
          #   @return [String]
          #     The semantic version of the Hive Metastore software.
          # @!attribute [rw] is_default
          #   @return [true, false]
          #     Whether `version` will be chosen by the server if a metastore service is
          #     created with a `HiveMetastoreConfig` that omits the `version`.
          class HiveMetastoreVersion; end
        end
      end
    end
  end
end