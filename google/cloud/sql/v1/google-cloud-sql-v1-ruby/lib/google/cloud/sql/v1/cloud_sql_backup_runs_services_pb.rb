# Generated by the protocol buffer compiler.  DO NOT EDIT!
# Source: google/cloud/sql/v1/cloud_sql_backup_runs.proto for package 'google.cloud.sql.v1'
# Original file comments:
# Copyright 2021 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
#

require 'grpc'
require 'google/cloud/sql/v1/cloud_sql_backup_runs_pb'

module Google
  module Cloud
    module Sql
      module V1
        module SqlBackupRunsService
          # LINT: LEGACY_NAMES
          #
          # Service for managing database backups.
          class Service

            include ::GRPC::GenericService

            self.marshal_class_method = :encode
            self.unmarshal_class_method = :decode
            self.service_name = 'google.cloud.sql.v1.SqlBackupRunsService'

            # Deletes the backup taken by a backup run.
            rpc :Delete, ::Google::Cloud::Sql::V1::SqlBackupRunsDeleteRequest, ::Google::Cloud::Sql::V1::Operation
            # Retrieves a resource containing information about a backup run.
            rpc :Get, ::Google::Cloud::Sql::V1::SqlBackupRunsGetRequest, ::Google::Cloud::Sql::V1::BackupRun
            # Creates a new backup run on demand.
            rpc :Insert, ::Google::Cloud::Sql::V1::SqlBackupRunsInsertRequest, ::Google::Cloud::Sql::V1::Operation
            # Lists all backup runs associated with the project or a given instance
            # and configuration in the reverse chronological order of the backup
            # initiation time.
            rpc :List, ::Google::Cloud::Sql::V1::SqlBackupRunsListRequest, ::Google::Cloud::Sql::V1::BackupRunsListResponse
          end

          Stub = Service.rpc_stub_class
        end
      end
    end
  end
end
