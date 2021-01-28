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
    module Bigquery
      module Connection
        module V1beta1
          # The request for {Google::Cloud::Bigquery::Connection::V1beta1::ConnectionService::CreateConnection ConnectionService::CreateConnection}.
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. Parent resource name.
          #     Must be in the format `projects/{project_id}/locations/{location_id}`
          # @!attribute [rw] connection_id
          #   @return [String]
          #     Optional. Connection id that should be assigned to the created connection.
          # @!attribute [rw] connection
          #   @return [Google::Cloud::Bigquery::Connection::V1beta1::Connection]
          #     Required. Connection to create.
          class CreateConnectionRequest; end

          # The request for {Google::Cloud::Bigquery::Connection::V1beta1::ConnectionService::GetConnection ConnectionService::GetConnection}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. Name of the requested connection, for example:
          #     `projects/{project_id}/locations/{location_id}/connections/{connection_id}`
          class GetConnectionRequest; end

          # The request for {Google::Cloud::Bigquery::Connection::V1beta1::ConnectionService::ListConnections ConnectionService::ListConnections}.
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. Parent resource name.
          #     Must be in the form: `projects/{project_id}/locations/{location_id}`
          # @!attribute [rw] max_results
          #   @return [Google::Protobuf::UInt32Value]
          #     Required. Maximum number of results per page.
          # @!attribute [rw] page_token
          #   @return [String]
          #     Page token.
          class ListConnectionsRequest; end

          # The response for {Google::Cloud::Bigquery::Connection::V1beta1::ConnectionService::ListConnections ConnectionService::ListConnections}.
          # @!attribute [rw] next_page_token
          #   @return [String]
          #     Next page token.
          # @!attribute [rw] connections
          #   @return [Array<Google::Cloud::Bigquery::Connection::V1beta1::Connection>]
          #     List of connections.
          class ListConnectionsResponse; end

          # The request for {Google::Cloud::Bigquery::Connection::V1beta1::ConnectionService::UpdateConnection ConnectionService::UpdateConnection}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. Name of the connection to update, for example:
          #     `projects/{project_id}/locations/{location_id}/connections/{connection_id}`
          # @!attribute [rw] connection
          #   @return [Google::Cloud::Bigquery::Connection::V1beta1::Connection]
          #     Required. Connection containing the updated fields.
          # @!attribute [rw] update_mask
          #   @return [Google::Protobuf::FieldMask]
          #     Required. Update mask for the connection fields to be updated.
          class UpdateConnectionRequest; end

          # The request for {Google::Cloud::Bigquery::Connection::V1beta1::ConnectionService::UpdateConnectionCredential ConnectionService::UpdateConnectionCredential}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. Name of the connection, for example:
          #     `projects/{project_id}/locations/{location_id}/connections/{connection_id}/credential`
          # @!attribute [rw] credential
          #   @return [Google::Cloud::Bigquery::Connection::V1beta1::ConnectionCredential]
          #     Required. Credential to use with the connection.
          class UpdateConnectionCredentialRequest; end

          # The request for {ConnectionService::DeleteConnectionRequest}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. Name of the deleted connection, for example:
          #     `projects/{project_id}/locations/{location_id}/connections/{connection_id}`
          class DeleteConnectionRequest; end

          # Configuration parameters to establish connection with an external data
          # source, except the credential attributes.
          # @!attribute [rw] name
          #   @return [String]
          #     The resource name of the connection in the form of:
          #     `projects/{project_id}/locations/{location_id}/connections/{connection_id}`
          # @!attribute [rw] friendly_name
          #   @return [String]
          #     User provided display name for the connection.
          # @!attribute [rw] description
          #   @return [String]
          #     User provided description.
          # @!attribute [rw] cloud_sql
          #   @return [Google::Cloud::Bigquery::Connection::V1beta1::CloudSqlProperties]
          #     Cloud SQL properties.
          # @!attribute [rw] creation_time
          #   @return [Integer]
          #     Output only. The creation timestamp of the connection.
          # @!attribute [rw] last_modified_time
          #   @return [Integer]
          #     Output only. The last update timestamp of the connection.
          # @!attribute [rw] has_credential
          #   @return [true, false]
          #     Output only. True, if credential is configured for this connection.
          class Connection; end

          # Credential to use with a connection.
          # @!attribute [rw] cloud_sql
          #   @return [Google::Cloud::Bigquery::Connection::V1beta1::CloudSqlCredential]
          #     Credential for Cloud SQL database.
          class ConnectionCredential; end

          # Connection properties specific to the Cloud SQL.
          # @!attribute [rw] instance_id
          #   @return [String]
          #     Cloud SQL instance ID in the form `project:location:instance`.
          # @!attribute [rw] database
          #   @return [String]
          #     Database name.
          # @!attribute [rw] type
          #   @return [Google::Cloud::Bigquery::Connection::V1beta1::CloudSqlProperties::DatabaseType]
          #     Type of the Cloud SQL database.
          # @!attribute [rw] credential
          #   @return [Google::Cloud::Bigquery::Connection::V1beta1::CloudSqlCredential]
          #     Input only. Cloud SQL credential.
          class CloudSqlProperties
            # Supported Cloud SQL database types.
            module DatabaseType
              # Unspecified database type.
              DATABASE_TYPE_UNSPECIFIED = 0

              # Cloud SQL for PostgreSQL.
              POSTGRES = 1

              # Cloud SQL for MySQL.
              MYSQL = 2
            end
          end

          # Credential info for the Cloud SQL.
          # @!attribute [rw] username
          #   @return [String]
          #     The username for the credential.
          # @!attribute [rw] password
          #   @return [String]
          #     The password for the credential.
          class CloudSqlCredential; end
        end
      end
    end
  end
end