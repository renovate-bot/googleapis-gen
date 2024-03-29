# frozen_string_literal: true

# Copyright 2022 Google LLC
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

# Auto-generated by gapic-generator-ruby. DO NOT EDIT!


module Google
  module Cloud
    module CloudDMS
      module V1
        # Retrieve a list of all migration jobs in a given project and location.
        # @!attribute [rw] parent
        #   @return [::String]
        #     Required. The parent, which owns this collection of migrationJobs.
        # @!attribute [rw] page_size
        #   @return [::Integer]
        #     The maximum number of migration jobs to return. The service may return
        #     fewer than this value. If unspecified, at most 50 migration jobs will be
        #     returned. The maximum value is 1000; values above 1000 will be coerced to
        #     1000.
        # @!attribute [rw] page_token
        #   @return [::String]
        #     The nextPageToken value received in the previous call to
        #     migrationJobs.list, used in the subsequent request to retrieve the next
        #     page of results. On first call this should be left blank. When paginating,
        #     all other parameters provided to migrationJobs.list must match the call
        #     that provided the page token.
        # @!attribute [rw] filter
        #   @return [::String]
        #     A filter expression that filters migration jobs listed in the response.
        #     The expression must specify the field name, a comparison operator, and the
        #     value that you want to use for filtering. The value must be a string,
        #     a number, or a boolean. The comparison operator must be
        #     either =, !=, >, or <. For example, list migration jobs created this year
        #     by specifying **createTime %gt; 2020-01-01T00:00:00.000000000Z.**
        #     You can also filter nested fields. For example, you could specify
        #     **reverseSshConnectivity.vmIp = "1.2.3.4"** to select all migration
        #     jobs connecting through the specific SSH tunnel bastion.
        # @!attribute [rw] order_by
        #   @return [::String]
        #     Sort the results based on the migration job name.
        #     Valid values are: "name", "name asc", and "name desc".
        class ListMigrationJobsRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Response message for 'ListMigrationJobs' request.
        # @!attribute [rw] migration_jobs
        #   @return [::Array<::Google::Cloud::CloudDMS::V1::MigrationJob>]
        #     The list of migration jobs objects.
        # @!attribute [rw] next_page_token
        #   @return [::String]
        #     A token, which can be sent as `page_token` to retrieve the next page.
        #     If this field is omitted, there are no subsequent pages.
        # @!attribute [rw] unreachable
        #   @return [::Array<::String>]
        #     Locations that could not be reached.
        class ListMigrationJobsResponse
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request message for 'GetMigrationJob' request.
        # @!attribute [rw] name
        #   @return [::String]
        #     Required. Name of the migration job resource to get.
        class GetMigrationJobRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request message to create a new Database Migration Service migration job
        # in the specified project and region.
        # @!attribute [rw] parent
        #   @return [::String]
        #     Required. The parent, which owns this collection of migration jobs.
        # @!attribute [rw] migration_job_id
        #   @return [::String]
        #     Required. The ID of the instance to create.
        # @!attribute [rw] migration_job
        #   @return [::Google::Cloud::CloudDMS::V1::MigrationJob]
        #     Required. Represents a [migration
        #     job](https://cloud.google.com/database-migration/docs/reference/rest/v1/projects.locations.migrationJobs)
        #     object.
        # @!attribute [rw] request_id
        #   @return [::String]
        #     A unique id used to identify the request. If the server receives two
        #     requests with the same id, then the second request will be ignored.
        #
        #     It is recommended to always set this value to a UUID.
        #
        #     The id must contain only letters (a-z, A-Z), numbers (0-9), underscores
        #     (_), and hyphens (-). The maximum length is 40 characters.
        class CreateMigrationJobRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request message for 'UpdateMigrationJob' request.
        # @!attribute [rw] update_mask
        #   @return [::Google::Protobuf::FieldMask]
        #     Required. Field mask is used to specify the fields to be overwritten in the
        #     migration job resource by the update.
        # @!attribute [rw] migration_job
        #   @return [::Google::Cloud::CloudDMS::V1::MigrationJob]
        #     Required. The migration job parameters to update.
        # @!attribute [rw] request_id
        #   @return [::String]
        #     A unique id used to identify the request. If the server receives two
        #     requests with the same id, then the second request will be ignored.
        #
        #     It is recommended to always set this value to a UUID.
        #
        #     The id must contain only letters (a-z, A-Z), numbers (0-9), underscores
        #     (_), and hyphens (-). The maximum length is 40 characters.
        class UpdateMigrationJobRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request message for 'DeleteMigrationJob' request.
        # @!attribute [rw] name
        #   @return [::String]
        #     Required. Name of the migration job resource to delete.
        # @!attribute [rw] request_id
        #   @return [::String]
        #     A unique id used to identify the request. If the server receives two
        #     requests with the same id, then the second request will be ignored.
        #
        #     It is recommended to always set this value to a UUID.
        #
        #     The id must contain only letters (a-z, A-Z), numbers (0-9), underscores
        #     (_), and hyphens (-). The maximum length is 40 characters.
        # @!attribute [rw] force
        #   @return [::Boolean]
        #     The destination CloudSQL connection profile is always deleted with the
        #     migration job. In case of force delete, the destination CloudSQL replica
        #     database is also deleted.
        class DeleteMigrationJobRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request message for 'StartMigrationJob' request.
        # @!attribute [rw] name
        #   @return [::String]
        #     Name of the migration job resource to start.
        class StartMigrationJobRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request message for 'StopMigrationJob' request.
        # @!attribute [rw] name
        #   @return [::String]
        #     Name of the migration job resource to stop.
        class StopMigrationJobRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request message for 'ResumeMigrationJob' request.
        # @!attribute [rw] name
        #   @return [::String]
        #     Name of the migration job resource to resume.
        class ResumeMigrationJobRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request message for 'PromoteMigrationJob' request.
        # @!attribute [rw] name
        #   @return [::String]
        #     Name of the migration job resource to promote.
        class PromoteMigrationJobRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request message for 'VerifyMigrationJob' request.
        # @!attribute [rw] name
        #   @return [::String]
        #     Name of the migration job resource to verify.
        class VerifyMigrationJobRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request message for 'RestartMigrationJob' request.
        # @!attribute [rw] name
        #   @return [::String]
        #     Name of the migration job resource to restart.
        class RestartMigrationJobRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request message for 'GenerateSshScript' request.
        # @!attribute [rw] migration_job
        #   @return [::String]
        #     Name of the migration job resource to generate the SSH script.
        # @!attribute [rw] vm
        #   @return [::String]
        #     Required. Bastion VM Instance name to use or to create.
        # @!attribute [rw] vm_creation_config
        #   @return [::Google::Cloud::CloudDMS::V1::VmCreationConfig]
        #     The VM creation configuration
        # @!attribute [rw] vm_selection_config
        #   @return [::Google::Cloud::CloudDMS::V1::VmSelectionConfig]
        #     The VM selection configuration
        # @!attribute [rw] vm_port
        #   @return [::Integer]
        #     The port that will be open on the bastion host
        class GenerateSshScriptRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # VM creation configuration message
        # @!attribute [rw] vm_machine_type
        #   @return [::String]
        #     Required. VM instance machine type to create.
        # @!attribute [rw] vm_zone
        #   @return [::String]
        #     The Google Cloud Platform zone to create the VM in.
        # @!attribute [rw] subnet
        #   @return [::String]
        #     The subnet name the vm needs to be created in.
        class VmCreationConfig
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # VM selection configuration message
        # @!attribute [rw] vm_zone
        #   @return [::String]
        #     Required. The Google Cloud Platform zone the VM is located.
        class VmSelectionConfig
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Response message for 'GenerateSshScript' request.
        # @!attribute [rw] script
        #   @return [::String]
        #     The ssh configuration script.
        class SshScript
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request message for 'ListConnectionProfiles' request.
        # @!attribute [rw] parent
        #   @return [::String]
        #     Required. The parent, which owns this collection of connection profiles.
        # @!attribute [rw] page_size
        #   @return [::Integer]
        #     The maximum number of connection profiles to return. The service may return
        #     fewer than this value. If unspecified, at most 50 connection profiles will
        #     be returned. The maximum value is 1000; values above 1000 will be coerced
        #     to 1000.
        # @!attribute [rw] page_token
        #   @return [::String]
        #     A page token, received from a previous `ListConnectionProfiles` call.
        #     Provide this to retrieve the subsequent page.
        #
        #     When paginating, all other parameters provided to `ListConnectionProfiles`
        #     must match the call that provided the page token.
        # @!attribute [rw] filter
        #   @return [::String]
        #     A filter expression that filters connection profiles listed in the
        #     response. The expression must specify the field name, a comparison
        #     operator, and the value that you want to use for filtering. The value must
        #     be a string, a number, or a boolean. The comparison operator must be either
        #     =, !=, >, or <. For example, list connection profiles created this year by
        #     specifying **createTime %gt; 2020-01-01T00:00:00.000000000Z**. You can
        #     also filter nested fields. For example, you could specify **mySql.username
        #     = %lt;my_username%gt;** to list all connection profiles configured to
        #     connect with a specific username.
        # @!attribute [rw] order_by
        #   @return [::String]
        #     the order by fields for the result.
        class ListConnectionProfilesRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Response message for 'ListConnectionProfiles' request.
        # @!attribute [rw] connection_profiles
        #   @return [::Array<::Google::Cloud::CloudDMS::V1::ConnectionProfile>]
        #     The response list of connection profiles.
        # @!attribute [rw] next_page_token
        #   @return [::String]
        #     A token, which can be sent as `page_token` to retrieve the next page.
        #     If this field is omitted, there are no subsequent pages.
        # @!attribute [rw] unreachable
        #   @return [::Array<::String>]
        #     Locations that could not be reached.
        class ListConnectionProfilesResponse
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request message for 'GetConnectionProfile' request.
        # @!attribute [rw] name
        #   @return [::String]
        #     Required. Name of the connection profile resource to get.
        class GetConnectionProfileRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request message for 'CreateConnectionProfile' request.
        # @!attribute [rw] parent
        #   @return [::String]
        #     Required. The parent, which owns this collection of connection profiles.
        # @!attribute [rw] connection_profile_id
        #   @return [::String]
        #     Required. The connection profile identifier.
        # @!attribute [rw] connection_profile
        #   @return [::Google::Cloud::CloudDMS::V1::ConnectionProfile]
        #     Required. The create request body including the connection profile data
        # @!attribute [rw] request_id
        #   @return [::String]
        #     A unique id used to identify the request. If the server receives two
        #     requests with the same id, then the second request will be ignored.
        #
        #     It is recommended to always set this value to a UUID.
        #
        #     The id must contain only letters (a-z, A-Z), numbers (0-9), underscores
        #     (_), and hyphens (-). The maximum length is 40 characters.
        class CreateConnectionProfileRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request message for 'UpdateConnectionProfile' request.
        # @!attribute [rw] update_mask
        #   @return [::Google::Protobuf::FieldMask]
        #     Required. Field mask is used to specify the fields to be overwritten in the
        #     connection profile resource by the update.
        # @!attribute [rw] connection_profile
        #   @return [::Google::Cloud::CloudDMS::V1::ConnectionProfile]
        #     Required. The connection profile parameters to update.
        # @!attribute [rw] request_id
        #   @return [::String]
        #     A unique id used to identify the request. If the server receives two
        #     requests with the same id, then the second request will be ignored.
        #
        #     It is recommended to always set this value to a UUID.
        #
        #     The id must contain only letters (a-z, A-Z), numbers (0-9), underscores
        #     (_), and hyphens (-). The maximum length is 40 characters.
        class UpdateConnectionProfileRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request message for 'DeleteConnectionProfile' request.
        # @!attribute [rw] name
        #   @return [::String]
        #     Required. Name of the connection profile resource to delete.
        # @!attribute [rw] request_id
        #   @return [::String]
        #     A unique id used to identify the request. If the server receives two
        #     requests with the same id, then the second request will be ignored.
        #
        #     It is recommended to always set this value to a UUID.
        #
        #     The id must contain only letters (a-z, A-Z), numbers (0-9), underscores
        #     (_), and hyphens (-). The maximum length is 40 characters.
        # @!attribute [rw] force
        #   @return [::Boolean]
        #     In case of force delete, the CloudSQL replica database is also deleted
        #     (only for CloudSQL connection profile).
        class DeleteConnectionProfileRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Represents the metadata of the long-running operation.
        # @!attribute [r] create_time
        #   @return [::Google::Protobuf::Timestamp]
        #     Output only. The time the operation was created.
        # @!attribute [r] end_time
        #   @return [::Google::Protobuf::Timestamp]
        #     Output only. The time the operation finished running.
        # @!attribute [r] target
        #   @return [::String]
        #     Output only. Server-defined resource path for the target of the operation.
        # @!attribute [r] verb
        #   @return [::String]
        #     Output only. Name of the verb executed by the operation.
        # @!attribute [r] status_message
        #   @return [::String]
        #     Output only. Human-readable status of the operation, if any.
        # @!attribute [r] requested_cancellation
        #   @return [::Boolean]
        #     Output only. Identifies whether the user has requested cancellation
        #     of the operation. Operations that have successfully been cancelled
        #     have [Operation.error][] value with a {::Google::Rpc::Status#code google.rpc.Status.code} of 1,
        #     corresponding to `Code.CANCELLED`.
        # @!attribute [r] api_version
        #   @return [::String]
        #     Output only. API version used to start the operation.
        class OperationMetadata
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end
      end
    end
  end
end
