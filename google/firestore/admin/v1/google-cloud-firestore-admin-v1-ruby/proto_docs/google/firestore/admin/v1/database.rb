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
    module Firestore
      module Admin
        module V1
          # A Cloud Firestore Database.
          # Currently only one database is allowed per cloud project; this database
          # must have a `database_id` of '(default)'.
          # @!attribute [rw] name
          #   @return [::String]
          #     The resource name of the Database.
          #     Format: `projects/{project}/databases/{database}`
          # @!attribute [rw] location_id
          #   @return [::String]
          #     The location of the database. Available databases are listed at
          #     https://cloud.google.com/firestore/docs/locations.
          # @!attribute [rw] type
          #   @return [::Google::Cloud::Firestore::Admin::V1::Database::DatabaseType]
          #     The type of the database.
          #     See https://cloud.google.com/datastore/docs/firestore-or-datastore for
          #     information about how to choose.
          # @!attribute [rw] concurrency_mode
          #   @return [::Google::Cloud::Firestore::Admin::V1::Database::ConcurrencyMode]
          #     The concurrency control mode to use for this database.
          # @!attribute [rw] etag
          #   @return [::String]
          #     This checksum is computed by the server based on the value of other
          #     fields, and may be sent on update and delete requests to ensure the
          #     client has an up-to-date value before proceeding.
          class Database
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods

            # The type of the database.
            # See https://cloud.google.com/datastore/docs/firestore-or-datastore for
            # information about how to choose.
            module DatabaseType
              # The default value. This value is used if the database type is omitted.
              DATABASE_TYPE_UNSPECIFIED = 0

              # Firestore Native Mode
              FIRESTORE_NATIVE = 1

              # Firestore in Datastore Mode.
              DATASTORE_MODE = 2
            end

            # The type of concurrency control mode for transactions.
            module ConcurrencyMode
              # Not used.
              CONCURRENCY_MODE_UNSPECIFIED = 0

              # Use optimistic concurrency control by default. This setting is available
              # for Cloud Firestore customers.
              OPTIMISTIC = 1

              # Use pessimistic concurrency control by default. This setting is available
              # for Cloud Firestore customers.
              # This is the default setting for Cloud Firestore.
              PESSIMISTIC = 2

              # Use optimistic concurrency control with entity groups by default. This is
              # the only available setting for Cloud Datastore customers.
              # This is the default setting for Cloud Datastore.
              OPTIMISTIC_WITH_ENTITY_GROUPS = 3
            end
          end
        end
      end
    end
  end
end
