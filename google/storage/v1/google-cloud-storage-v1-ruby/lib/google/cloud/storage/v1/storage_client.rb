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
#
# EDITING INSTRUCTIONS
# This file was generated from the file
# https://github.com/googleapis/googleapis/blob/master/google/storage/v1/storage.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/storage/v1/storage_pb"
require "google/cloud/storage/v1/credentials"

module Google
  module Cloud
    module Storage
      module V1
        # Manages Google Cloud Storage resources.
        #
        # @!attribute [r] storage_stub
        #   @return [Google::Storage::V1::Storage::Stub]
        class StorageClient
          attr_reader :storage_stub

          # The default address of the service.
          SERVICE_ADDRESS = "storage.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
            "https://www.googleapis.com/auth/devstorage.full_control",
            "https://www.googleapis.com/auth/devstorage.read_only",
            "https://www.googleapis.com/auth/devstorage.read_write"
          ].freeze


          # @param credentials [Google::Auth::Credentials, String, Hash, GRPC::Core::Channel, GRPC::Core::ChannelCredentials, Proc]
          #   Provides the means for authenticating requests made by the client. This parameter can
          #   be many types.
          #   A `Google::Auth::Credentials` uses a the properties of its represented keyfile for
          #   authenticating requests made by this client.
          #   A `String` will be treated as the path to the keyfile to be used for the construction of
          #   credentials for this client.
          #   A `Hash` will be treated as the contents of a keyfile to be used for the construction of
          #   credentials for this client.
          #   A `GRPC::Core::Channel` will be used to make calls through.
          #   A `GRPC::Core::ChannelCredentials` for the setting up the RPC client. The channel credentials
          #   should already be composed with a `GRPC::Core::CallCredentials` object.
          #   A `Proc` will be used as an updater_proc for the Grpc channel. The proc transforms the
          #   metadata for requests, generally, to give OAuth credentials.
          # @param scopes [Array<String>]
          #   The OAuth scopes for this service. This parameter is ignored if
          #   an updater_proc is supplied.
          # @param client_config [Hash]
          #   A Hash for call options for each method. See
          #   Google::Gax#construct_settings for the structure of
          #   this data. Falls back to the default config if not specified
          #   or the specified config is missing data points.
          # @param timeout [Numeric]
          #   The default timeout, in seconds, for calls made through this client.
          # @param metadata [Hash]
          #   Default metadata to be sent with each request. This can be overridden on a per call basis.
          # @param exception_transformer [Proc]
          #   An optional proc that intercepts any exceptions raised during an API call to inject
          #   custom error handling.
          def initialize \
              credentials: nil,
              scopes: ALL_SCOPES,
              client_config: {},
              timeout: DEFAULT_TIMEOUT,
              metadata: nil,
              exception_transformer: nil,
              lib_name: nil,
              lib_version: ""
            # These require statements are intentionally placed here to initialize
            # the gRPC module only when it's required.
            # See https://github.com/googleapis/toolkit/issues/446
            require "google/gax/grpc"
            require "google/storage/v1/storage_services_pb"

            credentials ||= Google::Cloud::Storage::V1::Credentials.default

            if credentials.is_a?(String) || credentials.is_a?(Hash)
              updater_proc = Google::Cloud::Storage::V1::Credentials.new(credentials).updater_proc
            end
            if credentials.is_a?(GRPC::Core::Channel)
              channel = credentials
            end
            if credentials.is_a?(GRPC::Core::ChannelCredentials)
              chan_creds = credentials
            end
            if credentials.is_a?(Proc)
              updater_proc = credentials
            end
            if credentials.is_a?(Google::Auth::Credentials)
              updater_proc = credentials.updater_proc
            end

            package_version = Gem.loaded_specs['google-cloud-storage'].version.version

            google_api_client = "gl-ruby/#{RUBY_VERSION}"
            google_api_client << " #{lib_name}/#{lib_version}" if lib_name
            google_api_client << " gapic/#{package_version} gax/#{Google::Gax::VERSION}"
            google_api_client << " grpc/#{GRPC::VERSION}"
            google_api_client.freeze

            headers = { :"x-goog-api-client" => google_api_client }
            if credentials.respond_to?(:quota_project_id) && credentials.quota_project_id
              headers[:"x-goog-user-project"] = credentials.quota_project_id
            end
            headers.merge!(metadata) unless metadata.nil?
            client_config_file = Pathname.new(__dir__).join(
              "storage_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.storage.v1.Storage",
                JSON.parse(f.read),
                client_config,
                Google::Gax::Grpc::STATUS_CODE_NAMES,
                timeout,
                errors: Google::Gax::Grpc::API_ERRORS,
                metadata: headers
              )
            end

            # Allow overriding the service path/port in subclasses.
            service_path = self.class::SERVICE_ADDRESS
            port = self.class::DEFAULT_SERVICE_PORT
            interceptors = self.class::GRPC_INTERCEPTORS
            @storage_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Storage::V1::Storage::Stub.method(:new)
            )

            @delete_bucket_access_control = Google::Gax.create_api_call(
              @storage_stub.method(:delete_bucket_access_control),
              defaults["delete_bucket_access_control"],
              exception_transformer: exception_transformer
            )
            @get_bucket_access_control = Google::Gax.create_api_call(
              @storage_stub.method(:get_bucket_access_control),
              defaults["get_bucket_access_control"],
              exception_transformer: exception_transformer
            )
            @insert_bucket_access_control = Google::Gax.create_api_call(
              @storage_stub.method(:insert_bucket_access_control),
              defaults["insert_bucket_access_control"],
              exception_transformer: exception_transformer
            )
            @list_bucket_access_controls = Google::Gax.create_api_call(
              @storage_stub.method(:list_bucket_access_controls),
              defaults["list_bucket_access_controls"],
              exception_transformer: exception_transformer
            )
            @update_bucket_access_control = Google::Gax.create_api_call(
              @storage_stub.method(:update_bucket_access_control),
              defaults["update_bucket_access_control"],
              exception_transformer: exception_transformer
            )
            @patch_bucket_access_control = Google::Gax.create_api_call(
              @storage_stub.method(:patch_bucket_access_control),
              defaults["patch_bucket_access_control"],
              exception_transformer: exception_transformer
            )
            @delete_bucket = Google::Gax.create_api_call(
              @storage_stub.method(:delete_bucket),
              defaults["delete_bucket"],
              exception_transformer: exception_transformer
            )
            @get_bucket = Google::Gax.create_api_call(
              @storage_stub.method(:get_bucket),
              defaults["get_bucket"],
              exception_transformer: exception_transformer
            )
            @insert_bucket = Google::Gax.create_api_call(
              @storage_stub.method(:insert_bucket),
              defaults["insert_bucket"],
              exception_transformer: exception_transformer
            )
            @list_channels = Google::Gax.create_api_call(
              @storage_stub.method(:list_channels),
              defaults["list_channels"],
              exception_transformer: exception_transformer
            )
            @list_buckets = Google::Gax.create_api_call(
              @storage_stub.method(:list_buckets),
              defaults["list_buckets"],
              exception_transformer: exception_transformer
            )
            @lock_bucket_retention_policy = Google::Gax.create_api_call(
              @storage_stub.method(:lock_bucket_retention_policy),
              defaults["lock_bucket_retention_policy"],
              exception_transformer: exception_transformer
            )
            @get_bucket_iam_policy = Google::Gax.create_api_call(
              @storage_stub.method(:get_bucket_iam_policy),
              defaults["get_bucket_iam_policy"],
              exception_transformer: exception_transformer
            )
            @set_bucket_iam_policy = Google::Gax.create_api_call(
              @storage_stub.method(:set_bucket_iam_policy),
              defaults["set_bucket_iam_policy"],
              exception_transformer: exception_transformer
            )
            @test_bucket_iam_permissions = Google::Gax.create_api_call(
              @storage_stub.method(:test_bucket_iam_permissions),
              defaults["test_bucket_iam_permissions"],
              exception_transformer: exception_transformer
            )
            @patch_bucket = Google::Gax.create_api_call(
              @storage_stub.method(:patch_bucket),
              defaults["patch_bucket"],
              exception_transformer: exception_transformer
            )
            @update_bucket = Google::Gax.create_api_call(
              @storage_stub.method(:update_bucket),
              defaults["update_bucket"],
              exception_transformer: exception_transformer
            )
            @stop_channel = Google::Gax.create_api_call(
              @storage_stub.method(:stop_channel),
              defaults["stop_channel"],
              exception_transformer: exception_transformer
            )
            @delete_default_object_access_control = Google::Gax.create_api_call(
              @storage_stub.method(:delete_default_object_access_control),
              defaults["delete_default_object_access_control"],
              exception_transformer: exception_transformer
            )
            @get_default_object_access_control = Google::Gax.create_api_call(
              @storage_stub.method(:get_default_object_access_control),
              defaults["get_default_object_access_control"],
              exception_transformer: exception_transformer
            )
            @insert_default_object_access_control = Google::Gax.create_api_call(
              @storage_stub.method(:insert_default_object_access_control),
              defaults["insert_default_object_access_control"],
              exception_transformer: exception_transformer
            )
            @list_default_object_access_controls = Google::Gax.create_api_call(
              @storage_stub.method(:list_default_object_access_controls),
              defaults["list_default_object_access_controls"],
              exception_transformer: exception_transformer
            )
            @patch_default_object_access_control = Google::Gax.create_api_call(
              @storage_stub.method(:patch_default_object_access_control),
              defaults["patch_default_object_access_control"],
              exception_transformer: exception_transformer
            )
            @update_default_object_access_control = Google::Gax.create_api_call(
              @storage_stub.method(:update_default_object_access_control),
              defaults["update_default_object_access_control"],
              exception_transformer: exception_transformer
            )
            @delete_notification = Google::Gax.create_api_call(
              @storage_stub.method(:delete_notification),
              defaults["delete_notification"],
              exception_transformer: exception_transformer
            )
            @get_notification = Google::Gax.create_api_call(
              @storage_stub.method(:get_notification),
              defaults["get_notification"],
              exception_transformer: exception_transformer
            )
            @insert_notification = Google::Gax.create_api_call(
              @storage_stub.method(:insert_notification),
              defaults["insert_notification"],
              exception_transformer: exception_transformer
            )
            @list_notifications = Google::Gax.create_api_call(
              @storage_stub.method(:list_notifications),
              defaults["list_notifications"],
              exception_transformer: exception_transformer
            )
            @delete_object_access_control = Google::Gax.create_api_call(
              @storage_stub.method(:delete_object_access_control),
              defaults["delete_object_access_control"],
              exception_transformer: exception_transformer
            )
            @get_object_access_control = Google::Gax.create_api_call(
              @storage_stub.method(:get_object_access_control),
              defaults["get_object_access_control"],
              exception_transformer: exception_transformer
            )
            @insert_object_access_control = Google::Gax.create_api_call(
              @storage_stub.method(:insert_object_access_control),
              defaults["insert_object_access_control"],
              exception_transformer: exception_transformer
            )
            @list_object_access_controls = Google::Gax.create_api_call(
              @storage_stub.method(:list_object_access_controls),
              defaults["list_object_access_controls"],
              exception_transformer: exception_transformer
            )
            @patch_object_access_control = Google::Gax.create_api_call(
              @storage_stub.method(:patch_object_access_control),
              defaults["patch_object_access_control"],
              exception_transformer: exception_transformer
            )
            @update_object_access_control = Google::Gax.create_api_call(
              @storage_stub.method(:update_object_access_control),
              defaults["update_object_access_control"],
              exception_transformer: exception_transformer
            )
            @compose_object = Google::Gax.create_api_call(
              @storage_stub.method(:compose_object),
              defaults["compose_object"],
              exception_transformer: exception_transformer
            )
            @copy_object = Google::Gax.create_api_call(
              @storage_stub.method(:copy_object),
              defaults["copy_object"],
              exception_transformer: exception_transformer
            )
            @delete_object = Google::Gax.create_api_call(
              @storage_stub.method(:delete_object),
              defaults["delete_object"],
              exception_transformer: exception_transformer
            )
            @get_object = Google::Gax.create_api_call(
              @storage_stub.method(:get_object),
              defaults["get_object"],
              exception_transformer: exception_transformer
            )
            @get_object_media = Google::Gax.create_api_call(
              @storage_stub.method(:get_object_media),
              defaults["get_object_media"],
              exception_transformer: exception_transformer
            )
            @insert_object = Google::Gax.create_api_call(
              @storage_stub.method(:insert_object),
              defaults["insert_object"],
              exception_transformer: exception_transformer
            )
            @list_objects = Google::Gax.create_api_call(
              @storage_stub.method(:list_objects),
              defaults["list_objects"],
              exception_transformer: exception_transformer
            )
            @rewrite_object = Google::Gax.create_api_call(
              @storage_stub.method(:rewrite_object),
              defaults["rewrite_object"],
              exception_transformer: exception_transformer
            )
            @start_resumable_write = Google::Gax.create_api_call(
              @storage_stub.method(:start_resumable_write),
              defaults["start_resumable_write"],
              exception_transformer: exception_transformer
            )
            @query_write_status = Google::Gax.create_api_call(
              @storage_stub.method(:query_write_status),
              defaults["query_write_status"],
              exception_transformer: exception_transformer
            )
            @patch_object = Google::Gax.create_api_call(
              @storage_stub.method(:patch_object),
              defaults["patch_object"],
              exception_transformer: exception_transformer
            )
            @update_object = Google::Gax.create_api_call(
              @storage_stub.method(:update_object),
              defaults["update_object"],
              exception_transformer: exception_transformer
            )
            @get_object_iam_policy = Google::Gax.create_api_call(
              @storage_stub.method(:get_object_iam_policy),
              defaults["get_object_iam_policy"],
              exception_transformer: exception_transformer
            )
            @set_object_iam_policy = Google::Gax.create_api_call(
              @storage_stub.method(:set_object_iam_policy),
              defaults["set_object_iam_policy"],
              exception_transformer: exception_transformer
            )
            @test_object_iam_permissions = Google::Gax.create_api_call(
              @storage_stub.method(:test_object_iam_permissions),
              defaults["test_object_iam_permissions"],
              exception_transformer: exception_transformer
            )
            @watch_all_objects = Google::Gax.create_api_call(
              @storage_stub.method(:watch_all_objects),
              defaults["watch_all_objects"],
              exception_transformer: exception_transformer
            )
            @get_service_account = Google::Gax.create_api_call(
              @storage_stub.method(:get_service_account),
              defaults["get_service_account"],
              exception_transformer: exception_transformer
            )
            @create_hmac_key = Google::Gax.create_api_call(
              @storage_stub.method(:create_hmac_key),
              defaults["create_hmac_key"],
              exception_transformer: exception_transformer
            )
            @delete_hmac_key = Google::Gax.create_api_call(
              @storage_stub.method(:delete_hmac_key),
              defaults["delete_hmac_key"],
              exception_transformer: exception_transformer
            )
            @get_hmac_key = Google::Gax.create_api_call(
              @storage_stub.method(:get_hmac_key),
              defaults["get_hmac_key"],
              exception_transformer: exception_transformer
            )
            @list_hmac_keys = Google::Gax.create_api_call(
              @storage_stub.method(:list_hmac_keys),
              defaults["list_hmac_keys"],
              exception_transformer: exception_transformer
            )
            @update_hmac_key = Google::Gax.create_api_call(
              @storage_stub.method(:update_hmac_key),
              defaults["update_hmac_key"],
              exception_transformer: exception_transformer
            )
          end

          # Service calls

          # Permanently deletes the ACL entry for the specified entity on the specified
          # bucket.
          #
          # @param bucket [String]
          #   Required. Name of a bucket.
          # @param entity [String]
          #   Required. The entity holding the permission. Can be one of:
          #   * `user-`*userId*
          #   * `user-`*emailAddress*
          #   * `group-`*groupId*
          #   * `group-`*emailAddress*
          #   * `allUsers`
          #   * `allAuthenticatedUsers`
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #
          #   # TODO: Initialize `entity`:
          #   entity = ''
          #   storage_client.delete_bucket_access_control(bucket, entity)

          def delete_bucket_access_control \
              bucket,
              entity,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              entity: entity,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::DeleteBucketAccessControlRequest)
            @delete_bucket_access_control.call(req, options, &block)
            nil
          end

          # Returns the ACL entry for the specified entity on the specified bucket.
          #
          # @param bucket [String]
          #   Required. Name of a bucket.
          # @param entity [String]
          #   Required. The entity holding the permission. Can be one of:
          #   * `user-`*userId*
          #   * `user-`*emailAddress*
          #   * `group-`*groupId*
          #   * `group-`*emailAddress*
          #   * `allUsers`
          #   * `allAuthenticatedUsers`
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::BucketAccessControl]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::BucketAccessControl]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #
          #   # TODO: Initialize `entity`:
          #   entity = ''
          #   response = storage_client.get_bucket_access_control(bucket, entity)

          def get_bucket_access_control \
              bucket,
              entity,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              entity: entity,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::GetBucketAccessControlRequest)
            @get_bucket_access_control.call(req, options, &block)
          end

          # Creates a new ACL entry on the specified bucket.
          #
          # @param bucket [String]
          #   Required. Name of a bucket.
          # @param bucket_access_control [Google::Storage::V1::BucketAccessControl | Hash]
          #   Properties of the new bucket access control being inserted.
          #   A hash of the same form as `Google::Storage::V1::BucketAccessControl`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::BucketAccessControl]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::BucketAccessControl]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #   response = storage_client.insert_bucket_access_control(bucket)

          def insert_bucket_access_control \
              bucket,
              bucket_access_control: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              bucket_access_control: bucket_access_control,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::InsertBucketAccessControlRequest)
            @insert_bucket_access_control.call(req, options, &block)
          end

          # Retrieves ACL entries on the specified bucket.
          #
          # @param bucket [String]
          #   Required. Name of a bucket.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::ListBucketAccessControlsResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::ListBucketAccessControlsResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #   response = storage_client.list_bucket_access_controls(bucket)

          def list_bucket_access_controls \
              bucket,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::ListBucketAccessControlsRequest)
            @list_bucket_access_controls.call(req, options, &block)
          end

          # Updates an ACL entry on the specified bucket. Equivalent to
          # PatchBucketAccessControl, but all unspecified fields will be
          # reset to their default values.
          #
          # @param bucket [String]
          #   Required. Name of a bucket.
          # @param entity [String]
          #   Required. The entity holding the permission. Can be one of:
          #   * `user-`*userId*
          #   * `user-`*emailAddress*
          #   * `group-`*groupId*
          #   * `group-`*emailAddress*
          #   * `allUsers`
          #   * `allAuthenticatedUsers`
          # @param bucket_access_control [Google::Storage::V1::BucketAccessControl | Hash]
          #   The BucketAccessControl for updating.
          #   A hash of the same form as `Google::Storage::V1::BucketAccessControl`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::BucketAccessControl]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::BucketAccessControl]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #
          #   # TODO: Initialize `entity`:
          #   entity = ''
          #   response = storage_client.update_bucket_access_control(bucket, entity)

          def update_bucket_access_control \
              bucket,
              entity,
              bucket_access_control: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              entity: entity,
              bucket_access_control: bucket_access_control,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::UpdateBucketAccessControlRequest)
            @update_bucket_access_control.call(req, options, &block)
          end

          # Updates an ACL entry on the specified bucket.
          #
          # @param bucket [String]
          #   Required. Name of a bucket.
          # @param entity [String]
          #   Required. The entity holding the permission. Can be one of:
          #   * `user-`*userId*
          #   * `user-`*emailAddress*
          #   * `group-`*groupId*
          #   * `group-`*emailAddress*
          #   * `allUsers`
          #   * `allAuthenticatedUsers`
          # @param bucket_access_control [Google::Storage::V1::BucketAccessControl | Hash]
          #   The BucketAccessControl for updating.
          #   A hash of the same form as `Google::Storage::V1::BucketAccessControl`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   List of fields to be updated.
          #
          #   To specify ALL fields, equivalent to the JSON API's "update" function,
          #   specify a single field with the value `*`.
          #
          #
          #   Not specifying any fields is an error.
          #   Not specifying a field while setting that field to a non-default value is
          #   an error.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::BucketAccessControl]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::BucketAccessControl]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #
          #   # TODO: Initialize `entity`:
          #   entity = ''
          #   response = storage_client.patch_bucket_access_control(bucket, entity)

          def patch_bucket_access_control \
              bucket,
              entity,
              bucket_access_control: nil,
              update_mask: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              entity: entity,
              bucket_access_control: bucket_access_control,
              update_mask: update_mask,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::PatchBucketAccessControlRequest)
            @patch_bucket_access_control.call(req, options, &block)
          end

          # Permanently deletes an empty bucket.
          #
          # @param bucket [String]
          #   Required. Name of a bucket.
          # @param if_metageneration_match [Google::Protobuf::Int64Value | Hash]
          #   If set, only deletes the bucket if its metageneration matches this value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_metageneration_not_match [Google::Protobuf::Int64Value | Hash]
          #   If set, only deletes the bucket if its metageneration does not match this
          #   value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #   storage_client.delete_bucket(bucket)

          def delete_bucket \
              bucket,
              if_metageneration_match: nil,
              if_metageneration_not_match: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              if_metageneration_match: if_metageneration_match,
              if_metageneration_not_match: if_metageneration_not_match,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::DeleteBucketRequest)
            @delete_bucket.call(req, options, &block)
            nil
          end

          # Returns metadata for the specified bucket.
          #
          # @param bucket [String]
          #   Required. Name of a bucket.
          # @param if_metageneration_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the return of the bucket metadata conditional on whether the bucket's
          #   current metageneration matches the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_metageneration_not_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the return of the bucket metadata conditional on whether the bucket's
          #   current metageneration does not match the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param projection [Google::Storage::V1::CommonEnums::Projection]
          #   Set of properties to return. Defaults to `NO_ACL`.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::Bucket]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::Bucket]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #   response = storage_client.get_bucket(bucket)

          def get_bucket \
              bucket,
              if_metageneration_match: nil,
              if_metageneration_not_match: nil,
              projection: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              if_metageneration_match: if_metageneration_match,
              if_metageneration_not_match: if_metageneration_not_match,
              projection: projection,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::GetBucketRequest)
            @get_bucket.call(req, options, &block)
          end

          # Creates a new bucket.
          #
          # @param project [String]
          #   Required. A valid API project identifier.
          # @param predefined_acl [Google::Storage::V1::CommonEnums::PredefinedBucketAcl]
          #   Apply a predefined set of access controls to this bucket.
          # @param predefined_default_object_acl [Google::Storage::V1::CommonEnums::PredefinedObjectAcl]
          #   Apply a predefined set of default object access controls to this bucket.
          # @param projection [Google::Storage::V1::CommonEnums::Projection]
          #   Set of properties to return. Defaults to `NO_ACL`, unless the
          #   bucket resource specifies `acl` or `defaultObjectAcl`
          #   properties, when it defaults to `FULL`.
          # @param bucket [Google::Storage::V1::Bucket | Hash]
          #   Properties of the new bucket being inserted, including its name.
          #   A hash of the same form as `Google::Storage::V1::Bucket`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::Bucket]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::Bucket]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `project`:
          #   project = ''
          #   response = storage_client.insert_bucket(project)

          def insert_bucket \
              project,
              predefined_acl: nil,
              predefined_default_object_acl: nil,
              projection: nil,
              bucket: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              project: project,
              predefined_acl: predefined_acl,
              predefined_default_object_acl: predefined_default_object_acl,
              projection: projection,
              bucket: bucket,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::InsertBucketRequest)
            @insert_bucket.call(req, options, &block)
          end

          # List active object change notification channels for this bucket.
          #
          # @param bucket [String]
          #   Required. Name of a bucket.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::ListChannelsResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::ListChannelsResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #   response = storage_client.list_channels(bucket)

          def list_channels \
              bucket,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::ListChannelsRequest)
            @list_channels.call(req, options, &block)
          end

          # Retrieves a list of buckets for a given project.
          #
          # @param project [String]
          #   Required. A valid API project identifier.
          # @param max_results [Integer]
          #   Maximum number of buckets to return in a single response. The service will
          #   use this parameter or 1,000 items, whichever is smaller.
          # @param page_token [String]
          #   A previously-returned page token representing part of the larger set of
          #   results to view.
          # @param prefix [String]
          #   Filter results to buckets whose names begin with this prefix.
          # @param projection [Google::Storage::V1::CommonEnums::Projection]
          #   Set of properties to return. Defaults to `NO_ACL`.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::ListBucketsResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::ListBucketsResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `project`:
          #   project = ''
          #   response = storage_client.list_buckets(project)

          def list_buckets \
              project,
              max_results: nil,
              page_token: nil,
              prefix: nil,
              projection: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              project: project,
              max_results: max_results,
              page_token: page_token,
              prefix: prefix,
              projection: projection,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::ListBucketsRequest)
            @list_buckets.call(req, options, &block)
          end

          # Locks retention policy on a bucket.
          #
          # @param bucket [String]
          #   Required. Name of a bucket.
          # @param if_metageneration_match [Integer]
          #   Makes the operation conditional on whether bucket's current metageneration
          #   matches the given value. Must be positive.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::Bucket]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::Bucket]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #   response = storage_client.lock_bucket_retention_policy(bucket)

          def lock_bucket_retention_policy \
              bucket,
              if_metageneration_match: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              if_metageneration_match: if_metageneration_match,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::LockRetentionPolicyRequest)
            @lock_bucket_retention_policy.call(req, options, &block)
          end

          # Gets the IAM policy for the specified bucket.
          #
          # @param iam_request [Google::Iam::V1::GetIamPolicyRequest | Hash]
          #   The request sent to IAM.
          #   A hash of the same form as `Google::Iam::V1::GetIamPolicyRequest`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Iam::V1::Policy]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Iam::V1::Policy]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #   response = storage_client.get_bucket_iam_policy

          def get_bucket_iam_policy \
              iam_request: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              iam_request: iam_request,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::GetIamPolicyRequest)
            @get_bucket_iam_policy.call(req, options, &block)
          end

          # Updates an IAM policy for the specified bucket.
          #
          # @param iam_request [Google::Iam::V1::SetIamPolicyRequest | Hash]
          #   The request sent to IAM.
          #   A hash of the same form as `Google::Iam::V1::SetIamPolicyRequest`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Iam::V1::Policy]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Iam::V1::Policy]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #   response = storage_client.set_bucket_iam_policy

          def set_bucket_iam_policy \
              iam_request: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              iam_request: iam_request,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::SetIamPolicyRequest)
            @set_bucket_iam_policy.call(req, options, &block)
          end

          # Tests a set of permissions on the given bucket to see which, if
          # any, are held by the caller.
          #
          # @param iam_request [Google::Iam::V1::TestIamPermissionsRequest | Hash]
          #   The request sent to IAM.
          #   A hash of the same form as `Google::Iam::V1::TestIamPermissionsRequest`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Iam::V1::TestIamPermissionsResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Iam::V1::TestIamPermissionsResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #   response = storage_client.test_bucket_iam_permissions

          def test_bucket_iam_permissions \
              iam_request: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              iam_request: iam_request,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::TestIamPermissionsRequest)
            @test_bucket_iam_permissions.call(req, options, &block)
          end

          # Updates a bucket. Changes to the bucket will be readable immediately after
          # writing, but configuration changes may take time to propagate.
          #
          # @param bucket [String]
          #   Required. Name of a bucket.
          # @param if_metageneration_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the return of the bucket metadata conditional on whether the bucket's
          #   current metageneration matches the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_metageneration_not_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the return of the bucket metadata conditional on whether the bucket's
          #   current metageneration does not match the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param predefined_acl [Google::Storage::V1::CommonEnums::PredefinedBucketAcl]
          #   Apply a predefined set of access controls to this bucket.
          # @param predefined_default_object_acl [Google::Storage::V1::CommonEnums::PredefinedObjectAcl]
          #   Apply a predefined set of default object access controls to this bucket.
          # @param projection [Google::Storage::V1::CommonEnums::Projection]
          #   Set of properties to return. Defaults to `FULL`.
          # @param metadata [Google::Storage::V1::Bucket | Hash]
          #   The Bucket metadata for updating.
          #   A hash of the same form as `Google::Storage::V1::Bucket`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   List of fields to be updated.
          #
          #   To specify ALL fields, equivalent to the JSON API's "update" function,
          #   specify a single field with the value `*`. Note: not recommended. If a new
          #   field is introduced at a later time, an older client updating with the `*`
          #   may accidentally reset the new field's value.
          #
          #   Not specifying any fields is an error.
          #   Not specifying a field while setting that field to a non-default value is
          #   an error.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::Bucket]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::Bucket]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #   response = storage_client.patch_bucket(bucket)

          def patch_bucket \
              bucket,
              if_metageneration_match: nil,
              if_metageneration_not_match: nil,
              predefined_acl: nil,
              predefined_default_object_acl: nil,
              projection: nil,
              metadata: nil,
              update_mask: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              if_metageneration_match: if_metageneration_match,
              if_metageneration_not_match: if_metageneration_not_match,
              predefined_acl: predefined_acl,
              predefined_default_object_acl: predefined_default_object_acl,
              projection: projection,
              metadata: metadata,
              update_mask: update_mask,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::PatchBucketRequest)
            @patch_bucket.call(req, options, &block)
          end

          # Updates a bucket. Equivalent to PatchBucket, but always replaces all
          # mutatable fields of the bucket with new values, reverting all
          # unspecified fields to their default values.
          # Like PatchBucket, Changes to the bucket will be readable immediately after
          # writing, but configuration changes may take time to propagate.
          #
          # @param bucket [String]
          #   Required. Name of a bucket.
          # @param if_metageneration_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the return of the bucket metadata conditional on whether the bucket's
          #   current metageneration matches the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_metageneration_not_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the return of the bucket metadata conditional on whether the bucket's
          #   current metageneration does not match the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param predefined_acl [Google::Storage::V1::CommonEnums::PredefinedBucketAcl]
          #   Apply a predefined set of access controls to this bucket.
          # @param predefined_default_object_acl [Google::Storage::V1::CommonEnums::PredefinedObjectAcl]
          #   Apply a predefined set of default object access controls to this bucket.
          # @param projection [Google::Storage::V1::CommonEnums::Projection]
          #   Set of properties to return. Defaults to `FULL`.
          # @param metadata [Google::Storage::V1::Bucket | Hash]
          #   The Bucket metadata for updating.
          #   A hash of the same form as `Google::Storage::V1::Bucket`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::Bucket]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::Bucket]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #   response = storage_client.update_bucket(bucket)

          def update_bucket \
              bucket,
              if_metageneration_match: nil,
              if_metageneration_not_match: nil,
              predefined_acl: nil,
              predefined_default_object_acl: nil,
              projection: nil,
              metadata: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              if_metageneration_match: if_metageneration_match,
              if_metageneration_not_match: if_metageneration_not_match,
              predefined_acl: predefined_acl,
              predefined_default_object_acl: predefined_default_object_acl,
              projection: projection,
              metadata: metadata,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::UpdateBucketRequest)
            @update_bucket.call(req, options, &block)
          end

          # Halts "Object Change Notification" push messagages.
          # See https://cloud.google.com/storage/docs/object-change-notification
          # Note: this is not related to the newer "Notifications" resource, which
          # are stopped using DeleteNotification.
          #
          # @param channel [Google::Storage::V1::Channel | Hash]
          #   The channel to be stopped.
          #   A hash of the same form as `Google::Storage::V1::Channel`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #   storage_client.stop_channel

          def stop_channel \
              channel: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              channel: channel,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::StopChannelRequest)
            @stop_channel.call(req, options, &block)
            nil
          end

          # Permanently deletes the default object ACL entry for the specified entity
          # on the specified bucket.
          #
          # @param bucket [String]
          #   Required. Name of a bucket.
          # @param entity [String]
          #   Required. The entity holding the permission. Can be one of:
          #   * `user-`*userId*
          #   * `user-`*emailAddress*
          #   * `group-`*groupId*
          #   * `group-`*emailAddress*
          #   * `allUsers`
          #   * `allAuthenticatedUsers`
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #
          #   # TODO: Initialize `entity`:
          #   entity = ''
          #   storage_client.delete_default_object_access_control(bucket, entity)

          def delete_default_object_access_control \
              bucket,
              entity,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              entity: entity,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::DeleteDefaultObjectAccessControlRequest)
            @delete_default_object_access_control.call(req, options, &block)
            nil
          end

          # Returns the default object ACL entry for the specified entity on the
          # specified bucket.
          #
          # @param bucket [String]
          #   Required. Name of a bucket.
          # @param entity [String]
          #   Required. The entity holding the permission. Can be one of:
          #   * `user-`*userId*
          #   * `user-`*emailAddress*
          #   * `group-`*groupId*
          #   * `group-`*emailAddress*
          #   * `allUsers`
          #   * `allAuthenticatedUsers`
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::ObjectAccessControl]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::ObjectAccessControl]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #
          #   # TODO: Initialize `entity`:
          #   entity = ''
          #   response = storage_client.get_default_object_access_control(bucket, entity)

          def get_default_object_access_control \
              bucket,
              entity,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              entity: entity,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::GetDefaultObjectAccessControlRequest)
            @get_default_object_access_control.call(req, options, &block)
          end

          # Creates a new default object ACL entry on the specified bucket.
          #
          # @param bucket [String]
          #   Required. Name of a bucket.
          # @param object_access_control [Google::Storage::V1::ObjectAccessControl | Hash]
          #   Properties of the object access control being inserted.
          #   A hash of the same form as `Google::Storage::V1::ObjectAccessControl`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::ObjectAccessControl]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::ObjectAccessControl]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #   response = storage_client.insert_default_object_access_control(bucket)

          def insert_default_object_access_control \
              bucket,
              object_access_control: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              object_access_control: object_access_control,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::InsertDefaultObjectAccessControlRequest)
            @insert_default_object_access_control.call(req, options, &block)
          end

          # Retrieves default object ACL entries on the specified bucket.
          #
          # @param bucket [String]
          #   Required. Name of a bucket.
          # @param if_metageneration_match [Google::Protobuf::Int64Value | Hash]
          #   If present, only return default ACL listing if the bucket's current
          #   metageneration matches this value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_metageneration_not_match [Google::Protobuf::Int64Value | Hash]
          #   If present, only return default ACL listing if the bucket's current
          #   metageneration does not match the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::ListObjectAccessControlsResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::ListObjectAccessControlsResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #   response = storage_client.list_default_object_access_controls(bucket)

          def list_default_object_access_controls \
              bucket,
              if_metageneration_match: nil,
              if_metageneration_not_match: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              if_metageneration_match: if_metageneration_match,
              if_metageneration_not_match: if_metageneration_not_match,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::ListDefaultObjectAccessControlsRequest)
            @list_default_object_access_controls.call(req, options, &block)
          end

          # Updates a default object ACL entry on the specified bucket.
          #
          # @param bucket [String]
          #   Required. Name of a bucket.
          # @param entity [String]
          #   Required. The entity holding the permission. Can be one of:
          #   * `user-`*userId*
          #   * `user-`*emailAddress*
          #   * `group-`*groupId*
          #   * `group-`*emailAddress*
          #   * `allUsers`
          #   * `allAuthenticatedUsers`
          # @param object_access_control [Google::Storage::V1::ObjectAccessControl | Hash]
          #   The ObjectAccessControl for updating.
          #   A hash of the same form as `Google::Storage::V1::ObjectAccessControl`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   List of fields to be updated.
          #
          #   To specify ALL fields, equivalent to the JSON API's "update" function,
          #   specify a single field with the value `*`. Note: not recommended. If a new
          #   field is introduced at a later time, an older client updating with the `*`
          #   may accidentally reset the new field's value.
          #
          #   Not specifying any fields is an error.
          #   Not specifying a field while setting that field to a non-default value is
          #   an error.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::ObjectAccessControl]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::ObjectAccessControl]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #
          #   # TODO: Initialize `entity`:
          #   entity = ''
          #   response = storage_client.patch_default_object_access_control(bucket, entity)

          def patch_default_object_access_control \
              bucket,
              entity,
              object_access_control: nil,
              update_mask: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              entity: entity,
              object_access_control: object_access_control,
              update_mask: update_mask,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::PatchDefaultObjectAccessControlRequest)
            @patch_default_object_access_control.call(req, options, &block)
          end

          # Updates a default object ACL entry on the specified bucket. Equivalent to
          # PatchDefaultObjectAccessControl, but modifies all unspecified fields to
          # their default values.
          #
          # @param bucket [String]
          #   Required. Name of a bucket.
          # @param entity [String]
          #   Required. The entity holding the permission. Can be one of:
          #   * `user-`*userId*
          #   * `user-`*emailAddress*
          #   * `group-`*groupId*
          #   * `group-`*emailAddress*
          #   * `allUsers`
          #   * `allAuthenticatedUsers`
          # @param object_access_control [Google::Storage::V1::ObjectAccessControl | Hash]
          #   The ObjectAccessControl for updating.
          #   A hash of the same form as `Google::Storage::V1::ObjectAccessControl`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::ObjectAccessControl]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::ObjectAccessControl]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #
          #   # TODO: Initialize `entity`:
          #   entity = ''
          #   response = storage_client.update_default_object_access_control(bucket, entity)

          def update_default_object_access_control \
              bucket,
              entity,
              object_access_control: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              entity: entity,
              object_access_control: object_access_control,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::UpdateDefaultObjectAccessControlRequest)
            @update_default_object_access_control.call(req, options, &block)
          end

          # Permanently deletes a notification subscription.
          # Note: Older, "Object Change Notification" push subscriptions should be
          # deleted using StopChannel instead.
          #
          # @param bucket [String]
          #   Required. The parent bucket of the notification.
          # @param notification [String]
          #   Required. ID of the notification to delete.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #
          #   # TODO: Initialize `notification`:
          #   notification = ''
          #   storage_client.delete_notification(bucket, notification)

          def delete_notification \
              bucket,
              notification,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              notification: notification,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::DeleteNotificationRequest)
            @delete_notification.call(req, options, &block)
            nil
          end

          # View a notification configuration.
          #
          # @param bucket [String]
          #   Required. The parent bucket of the notification.
          # @param notification [String]
          #   Required. Notification ID.
          #   Required.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::Notification]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::Notification]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #
          #   # TODO: Initialize `notification`:
          #   notification = ''
          #   response = storage_client.get_notification(bucket, notification)

          def get_notification \
              bucket,
              notification,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              notification: notification,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::GetNotificationRequest)
            @get_notification.call(req, options, &block)
          end

          # Creates a notification subscription for a given bucket.
          # These notifications, when triggered, publish messages to the specified
          # Cloud Pub/Sub topics.
          # See https://cloud.google.com/storage/docs/pubsub-notifications.
          #
          # @param bucket [String]
          #   Required. The parent bucket of the notification.
          # @param notification [Google::Storage::V1::Notification | Hash]
          #   Properties of the notification to be inserted.
          #   A hash of the same form as `Google::Storage::V1::Notification`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::Notification]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::Notification]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #   response = storage_client.insert_notification(bucket)

          def insert_notification \
              bucket,
              notification: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              notification: notification,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::InsertNotificationRequest)
            @insert_notification.call(req, options, &block)
          end

          # Retrieves a list of notification subscriptions for a given bucket.
          #
          # @param bucket [String]
          #   Required. Name of a Google Cloud Storage bucket.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::ListNotificationsResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::ListNotificationsResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #   response = storage_client.list_notifications(bucket)

          def list_notifications \
              bucket,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::ListNotificationsRequest)
            @list_notifications.call(req, options, &block)
          end

          # Permanently deletes the ACL entry for the specified entity on the specified
          # object.
          #
          # @param bucket [String]
          #   Required. Name of a bucket.
          # @param entity [String]
          #   Required. The entity holding the permission. Can be one of:
          #   * `user-`*userId*
          #   * `user-`*emailAddress*
          #   * `group-`*groupId*
          #   * `group-`*emailAddress*
          #   * `allUsers`
          #   * `allAuthenticatedUsers`
          # @param object [String]
          #   Required. Name of the object.
          # @param generation [Integer]
          #   If present, selects a specific revision of this object (as opposed to the
          #   latest version, the default).
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #
          #   # TODO: Initialize `entity`:
          #   entity = ''
          #
          #   # TODO: Initialize `object`:
          #   object = ''
          #   storage_client.delete_object_access_control(bucket, entity, object)

          def delete_object_access_control \
              bucket,
              entity,
              object,
              generation: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              entity: entity,
              object: object,
              generation: generation,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::DeleteObjectAccessControlRequest)
            @delete_object_access_control.call(req, options, &block)
            nil
          end

          # Returns the ACL entry for the specified entity on the specified object.
          #
          # @param bucket [String]
          #   Required. Name of a bucket.
          # @param entity [String]
          #   Required. The entity holding the permission. Can be one of:
          #   * `user-`*userId*
          #   * `user-`*emailAddress*
          #   * `group-`*groupId*
          #   * `group-`*emailAddress*
          #   * `allUsers`
          #   * `allAuthenticatedUsers`
          # @param object [String]
          #   Required. Name of the object.
          # @param generation [Integer]
          #   If present, selects a specific revision of this object (as opposed to the
          #   latest version, the default).
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::ObjectAccessControl]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::ObjectAccessControl]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #
          #   # TODO: Initialize `entity`:
          #   entity = ''
          #
          #   # TODO: Initialize `object`:
          #   object = ''
          #   response = storage_client.get_object_access_control(bucket, entity, object)

          def get_object_access_control \
              bucket,
              entity,
              object,
              generation: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              entity: entity,
              object: object,
              generation: generation,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::GetObjectAccessControlRequest)
            @get_object_access_control.call(req, options, &block)
          end

          # Creates a new ACL entry on the specified object.
          #
          # @param bucket [String]
          #   Required. Name of a bucket.
          # @param object [String]
          #   Required. Name of the object.
          # @param generation [Integer]
          #   If present, selects a specific revision of this object (as opposed to the
          #   latest version, the default).
          # @param object_access_control [Google::Storage::V1::ObjectAccessControl | Hash]
          #   Properties of the object access control to be inserted.
          #   A hash of the same form as `Google::Storage::V1::ObjectAccessControl`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::ObjectAccessControl]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::ObjectAccessControl]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #
          #   # TODO: Initialize `object`:
          #   object = ''
          #   response = storage_client.insert_object_access_control(bucket, object)

          def insert_object_access_control \
              bucket,
              object,
              generation: nil,
              object_access_control: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              object: object,
              generation: generation,
              object_access_control: object_access_control,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::InsertObjectAccessControlRequest)
            @insert_object_access_control.call(req, options, &block)
          end

          # Retrieves ACL entries on the specified object.
          #
          # @param bucket [String]
          #   Required. Name of a bucket.
          # @param object [String]
          #   Required. Name of the object.
          # @param generation [Integer]
          #   If present, selects a specific revision of this object (as opposed to the
          #   latest version, the default).
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::ListObjectAccessControlsResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::ListObjectAccessControlsResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #
          #   # TODO: Initialize `object`:
          #   object = ''
          #   response = storage_client.list_object_access_controls(bucket, object)

          def list_object_access_controls \
              bucket,
              object,
              generation: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              object: object,
              generation: generation,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::ListObjectAccessControlsRequest)
            @list_object_access_controls.call(req, options, &block)
          end

          # Patches an ACL entry on the specified object.  Patch is similar to update,
          # but only applies or appends the specified fields in the
          # object_access_control object.  Other fields are unaffected.
          #
          # @param bucket [String]
          #   Required. Name of a bucket.
          # @param entity [String]
          #   Required. The entity holding the permission. Can be one of:
          #   * `user-`*userId*
          #   * `user-`*emailAddress*
          #   * `group-`*groupId*
          #   * `group-`*emailAddress*
          #   * `allUsers`
          #   * `allAuthenticatedUsers`
          # @param object [String]
          #   Required. Name of the object.
          #   Required.
          # @param generation [Integer]
          #   If present, selects a specific revision of this object (as opposed to the
          #   latest version, the default).
          # @param object_access_control [Google::Storage::V1::ObjectAccessControl | Hash]
          #   The ObjectAccessControl for updating.
          #   A hash of the same form as `Google::Storage::V1::ObjectAccessControl`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   List of fields to be updated.
          #
          #   To specify ALL fields, equivalent to the JSON API's "update" function,
          #   specify a single field with the value `*`. Note: not recommended. If a new
          #   field is introduced at a later time, an older client updating with the `*`
          #   may accidentally reset the new field's value.
          #
          #   Not specifying any fields is an error.
          #   Not specifying a field while setting that field to a non-default value is
          #   an error.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::ObjectAccessControl]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::ObjectAccessControl]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #
          #   # TODO: Initialize `entity`:
          #   entity = ''
          #
          #   # TODO: Initialize `object`:
          #   object = ''
          #   response = storage_client.patch_object_access_control(bucket, entity, object)

          def patch_object_access_control \
              bucket,
              entity,
              object,
              generation: nil,
              object_access_control: nil,
              common_request_params: nil,
              update_mask: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              entity: entity,
              object: object,
              generation: generation,
              object_access_control: object_access_control,
              common_request_params: common_request_params,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::PatchObjectAccessControlRequest)
            @patch_object_access_control.call(req, options, &block)
          end

          # Updates an ACL entry on the specified object.
          #
          # @param bucket [String]
          #   Required. Name of a bucket.
          # @param entity [String]
          #   Required. The entity holding the permission. Can be one of:
          #   * `user-`*userId*
          #   * `user-`*emailAddress*
          #   * `group-`*groupId*
          #   * `group-`*emailAddress*
          #   * `allUsers`
          #   * `allAuthenticatedUsers`
          # @param object [String]
          #   Required. Name of the object.
          #   Required.
          # @param generation [Integer]
          #   If present, selects a specific revision of this object (as opposed to the
          #   latest version, the default).
          # @param object_access_control [Google::Storage::V1::ObjectAccessControl | Hash]
          #   The ObjectAccessControl for updating.
          #   A hash of the same form as `Google::Storage::V1::ObjectAccessControl`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   List of fields to be updated.
          #
          #   To specify ALL fields, equivalent to the JSON API's "update" function,
          #   specify a single field with the value `*`. Note: not recommended. If a new
          #   field is introduced at a later time, an older client updating with the `*`
          #   may accidentally reset the new field's value.
          #
          #   Not specifying any fields is an error.
          #   Not specifying a field while setting that field to a non-default value is
          #   an error.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::ObjectAccessControl]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::ObjectAccessControl]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #
          #   # TODO: Initialize `entity`:
          #   entity = ''
          #
          #   # TODO: Initialize `object`:
          #   object = ''
          #   response = storage_client.update_object_access_control(bucket, entity, object)

          def update_object_access_control \
              bucket,
              entity,
              object,
              generation: nil,
              object_access_control: nil,
              common_request_params: nil,
              update_mask: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              entity: entity,
              object: object,
              generation: generation,
              object_access_control: object_access_control,
              common_request_params: common_request_params,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::UpdateObjectAccessControlRequest)
            @update_object_access_control.call(req, options, &block)
          end

          # Concatenates a list of existing objects into a new object in the same
          # bucket.
          #
          # @param destination_bucket [String]
          #   Required. Name of the bucket containing the source objects. The destination object is
          #   stored in this bucket.
          # @param destination_object [String]
          #   Required. Name of the new object.
          # @param destination_predefined_acl [Google::Storage::V1::CommonEnums::PredefinedObjectAcl]
          #   Apply a predefined set of access controls to the destination object.
          # @param destination [Google::Storage::V1::Object | Hash]
          #   Properties of the resulting object.
          #   A hash of the same form as `Google::Storage::V1::Object`
          #   can also be provided.
          # @param source_objects [Array<Google::Storage::V1::ComposeObjectRequest::SourceObjects | Hash>]
          #   The list of source objects that will be concatenated into a single object.
          #   A hash of the same form as `Google::Storage::V1::ComposeObjectRequest::SourceObjects`
          #   can also be provided.
          # @param if_generation_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the object's current generation
          #   matches the given value. Setting to 0 makes the operation succeed only if
          #   there are no live versions of the object.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_metageneration_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the object's current
          #   metageneration matches the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param kms_key_name [String]
          #   Resource name of the Cloud KMS key, of the form
          #   `projects/my-project/locations/my-location/keyRings/my-kr/cryptoKeys/my-key`,
          #   that will be used to encrypt the object. Overrides the object
          #   metadata's `kms_key_name` value, if any.
          # @param common_object_request_params [Google::Storage::V1::CommonObjectRequestParams | Hash]
          #   A set of parameters common to Storage API requests concerning an object.
          #   A hash of the same form as `Google::Storage::V1::CommonObjectRequestParams`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::Object]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::Object]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `destination_bucket`:
          #   destination_bucket = ''
          #
          #   # TODO: Initialize `destination_object`:
          #   destination_object = ''
          #   response = storage_client.compose_object(destination_bucket, destination_object)

          def compose_object \
              destination_bucket,
              destination_object,
              destination_predefined_acl: nil,
              destination: nil,
              source_objects: nil,
              if_generation_match: nil,
              if_metageneration_match: nil,
              kms_key_name: nil,
              common_object_request_params: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              destination_bucket: destination_bucket,
              destination_object: destination_object,
              destination_predefined_acl: destination_predefined_acl,
              destination: destination,
              source_objects: source_objects,
              if_generation_match: if_generation_match,
              if_metageneration_match: if_metageneration_match,
              kms_key_name: kms_key_name,
              common_object_request_params: common_object_request_params,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::ComposeObjectRequest)
            @compose_object.call(req, options, &block)
          end

          # Copies a source object to a destination object. Optionally overrides
          # metadata.
          #
          # @param destination_bucket [String]
          #   Required. Name of the bucket in which to store the new object. Overrides the provided
          #   object
          #   metadata's `bucket` value, if any.
          # @param destination_object [String]
          #   Required. Name of the new object.
          #   Required when the object metadata is not otherwise provided. Overrides the
          #   object metadata's `name` value, if any.
          # @param source_bucket [String]
          #   Required. Name of the bucket in which to find the source object.
          # @param source_object [String]
          #   Required. Name of the source object.
          # @param destination_predefined_acl [Google::Storage::V1::CommonEnums::PredefinedObjectAcl]
          #   Apply a predefined set of access controls to the destination object.
          # @param if_generation_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the destination object's current
          #   generation matches the given value. Setting to 0 makes the operation
          #   succeed only if there are no live versions of the object.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_generation_not_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the destination object's current
          #   generation does not match the given value. If no live object exists, the
          #   precondition fails. Setting to 0 makes the operation succeed only if there
          #   is a live version of the object.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_metageneration_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the destination object's current
          #   metageneration matches the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_metageneration_not_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the destination object's current
          #   metageneration does not match the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_source_generation_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the source object's current
          #   generation matches the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_source_generation_not_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the source object's current
          #   generation does not match the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_source_metageneration_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the source object's current
          #   metageneration matches the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_source_metageneration_not_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the source object's current
          #   metageneration does not match the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param projection [Google::Storage::V1::CommonEnums::Projection]
          #   Set of properties to return. Defaults to `NO_ACL`, unless the
          #   object resource specifies the `acl` property, when it defaults
          #   to `full`.
          # @param source_generation [Integer]
          #   If present, selects a specific revision of the source object (as opposed to
          #   the latest version, the default).
          # @param destination [Google::Storage::V1::Object | Hash]
          #   Properties of the resulting object. If not set, duplicate properties of
          #   source object.
          #   A hash of the same form as `Google::Storage::V1::Object`
          #   can also be provided.
          # @param destination_kms_key_name [String]
          #   Resource name of the Cloud KMS key, of the form
          #   `projects/my-project/locations/my-location/keyRings/my-kr/cryptoKeys/my-key`,
          #   that will be used to encrypt the object. Overrides the object
          #   metadata's `kms_key_name` value, if any.
          # @param common_object_request_params [Google::Storage::V1::CommonObjectRequestParams | Hash]
          #   A set of parameters common to Storage API requests concerning an object.
          #   A hash of the same form as `Google::Storage::V1::CommonObjectRequestParams`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::Object]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::Object]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `destination_bucket`:
          #   destination_bucket = ''
          #
          #   # TODO: Initialize `destination_object`:
          #   destination_object = ''
          #
          #   # TODO: Initialize `source_bucket`:
          #   source_bucket = ''
          #
          #   # TODO: Initialize `source_object`:
          #   source_object = ''
          #   response = storage_client.copy_object(destination_bucket, destination_object, source_bucket, source_object)

          def copy_object \
              destination_bucket,
              destination_object,
              source_bucket,
              source_object,
              destination_predefined_acl: nil,
              if_generation_match: nil,
              if_generation_not_match: nil,
              if_metageneration_match: nil,
              if_metageneration_not_match: nil,
              if_source_generation_match: nil,
              if_source_generation_not_match: nil,
              if_source_metageneration_match: nil,
              if_source_metageneration_not_match: nil,
              projection: nil,
              source_generation: nil,
              destination: nil,
              destination_kms_key_name: nil,
              common_object_request_params: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              destination_bucket: destination_bucket,
              destination_object: destination_object,
              source_bucket: source_bucket,
              source_object: source_object,
              destination_predefined_acl: destination_predefined_acl,
              if_generation_match: if_generation_match,
              if_generation_not_match: if_generation_not_match,
              if_metageneration_match: if_metageneration_match,
              if_metageneration_not_match: if_metageneration_not_match,
              if_source_generation_match: if_source_generation_match,
              if_source_generation_not_match: if_source_generation_not_match,
              if_source_metageneration_match: if_source_metageneration_match,
              if_source_metageneration_not_match: if_source_metageneration_not_match,
              projection: projection,
              source_generation: source_generation,
              destination: destination,
              destination_kms_key_name: destination_kms_key_name,
              common_object_request_params: common_object_request_params,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::CopyObjectRequest)
            @copy_object.call(req, options, &block)
          end

          # Deletes an object and its metadata. Deletions are permanent if versioning
          # is not enabled for the bucket, or if the `generation` parameter
          # is used.
          #
          # @param bucket [String]
          #   Required. Name of the bucket in which the object resides.
          # @param object [String]
          #   Required. The name of the object to delete (when not using a resumable write).
          # @param upload_id [String]
          #   The resumable upload_id of the object to delete (when using a
          #   resumable write). This should be copied from the `upload_id` field of
          #   `StartResumableWriteResponse`.
          # @param generation [Integer]
          #   If present, permanently deletes a specific revision of this object (as
          #   opposed to the latest version, the default).
          # @param if_generation_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the object's current generation
          #   matches the given value. Setting to 0 makes the operation succeed only if
          #   there are no live versions of the object.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_generation_not_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the object's current generation
          #   does not match the given value. If no live object exists, the precondition
          #   fails. Setting to 0 makes the operation succeed only if there is a live
          #   version of the object.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_metageneration_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the object's current
          #   metageneration matches the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_metageneration_not_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the object's current
          #   metageneration does not match the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param common_object_request_params [Google::Storage::V1::CommonObjectRequestParams | Hash]
          #   A set of parameters common to Storage API requests concerning an object.
          #   A hash of the same form as `Google::Storage::V1::CommonObjectRequestParams`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #
          #   # TODO: Initialize `object`:
          #   object = ''
          #   storage_client.delete_object(bucket, object)

          def delete_object \
              bucket,
              object,
              upload_id: nil,
              generation: nil,
              if_generation_match: nil,
              if_generation_not_match: nil,
              if_metageneration_match: nil,
              if_metageneration_not_match: nil,
              common_object_request_params: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              object: object,
              upload_id: upload_id,
              generation: generation,
              if_generation_match: if_generation_match,
              if_generation_not_match: if_generation_not_match,
              if_metageneration_match: if_metageneration_match,
              if_metageneration_not_match: if_metageneration_not_match,
              common_object_request_params: common_object_request_params,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::DeleteObjectRequest)
            @delete_object.call(req, options, &block)
            nil
          end

          # Retrieves an object's metadata.
          #
          # @param bucket [String]
          #   Required. Name of the bucket in which the object resides.
          # @param object [String]
          #   Required. Name of the object.
          # @param generation [Integer]
          #   If present, selects a specific revision of this object (as opposed to the
          #   latest version, the default).
          # @param if_generation_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the object's current generation
          #   matches the given value. Setting to 0 makes the operation succeed only if
          #   there are no live versions of the object.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_generation_not_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the object's current generation
          #   does not match the given value. If no live object exists, the precondition
          #   fails. Setting to 0 makes the operation succeed only if there is a live
          #   version of the object.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_metageneration_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the object's current
          #   metageneration matches the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_metageneration_not_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the object's current
          #   metageneration does not match the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param projection [Google::Storage::V1::CommonEnums::Projection]
          #   Set of properties to return. Defaults to `NO_ACL`.
          # @param common_object_request_params [Google::Storage::V1::CommonObjectRequestParams | Hash]
          #   A set of parameters common to Storage API requests concerning an object.
          #   A hash of the same form as `Google::Storage::V1::CommonObjectRequestParams`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::Object]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::Object]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #
          #   # TODO: Initialize `object`:
          #   object = ''
          #   response = storage_client.get_object(bucket, object)

          def get_object \
              bucket,
              object,
              generation: nil,
              if_generation_match: nil,
              if_generation_not_match: nil,
              if_metageneration_match: nil,
              if_metageneration_not_match: nil,
              projection: nil,
              common_object_request_params: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              object: object,
              generation: generation,
              if_generation_match: if_generation_match,
              if_generation_not_match: if_generation_not_match,
              if_metageneration_match: if_metageneration_match,
              if_metageneration_not_match: if_metageneration_not_match,
              projection: projection,
              common_object_request_params: common_object_request_params,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::GetObjectRequest)
            @get_object.call(req, options, &block)
          end

          # Reads an object's data.
          #
          # @param bucket [String]
          #   The name of the bucket containing the object to read.
          # @param object [String]
          #   The name of the object to read.
          # @param generation [Integer]
          #   If present, selects a specific revision of this object (as opposed
          #   to the latest version, the default).
          # @param read_offset [Integer]
          #   The offset for the first byte to return in the read, relative to the start
          #   of the object.
          #
          #   A negative `read_offset` value will be interpreted as the number of bytes
          #   back from the end of the object to be returned. For example, if an object's
          #   length is 15 bytes, a GetObjectMediaRequest with `read_offset` = -5 and
          #   `read_limit` = 3 would return bytes 10 through 12 of the object.
          # @param read_limit [Integer]
          #   The maximum number of `data` bytes the server is allowed to return in the
          #   sum of all `Object` messages. A `read_limit` of zero indicates that there
          #   is no limit, and a negative `read_limit` will cause an error.
          #
          #   If the stream returns fewer bytes than allowed by the `read_limit` and no
          #   error occurred, the stream includes all data from the `read_offset` to the
          #   end of the resource.
          # @param if_generation_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the object's current generation
          #   matches the given value. Setting to 0 makes the operation succeed only if
          #   there are no live versions of the object.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_generation_not_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the object's current generation
          #   does not match the given value. If no live object exists, the precondition
          #   fails. Setting to 0 makes the operation succeed only if there is a live
          #   version of the object.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_metageneration_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the object's current
          #   metageneration matches the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_metageneration_not_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the object's current
          #   metageneration does not match the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param common_object_request_params [Google::Storage::V1::CommonObjectRequestParams | Hash]
          #   A set of parameters common to Storage API requests concerning an object.
          #   A hash of the same form as `Google::Storage::V1::CommonObjectRequestParams`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Enumerable<Google::Storage::V1::GetObjectMediaResponse>]
          #   An enumerable of Google::Storage::V1::GetObjectMediaResponse instances.
          #
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #   storage_client.get_object_media.each do |element|
          #     # Process element.
          #   end

          def get_object_media \
              bucket: nil,
              object: nil,
              generation: nil,
              read_offset: nil,
              read_limit: nil,
              if_generation_match: nil,
              if_generation_not_match: nil,
              if_metageneration_match: nil,
              if_metageneration_not_match: nil,
              common_object_request_params: nil,
              common_request_params: nil,
              options: nil
            req = {
              bucket: bucket,
              object: object,
              generation: generation,
              read_offset: read_offset,
              read_limit: read_limit,
              if_generation_match: if_generation_match,
              if_generation_not_match: if_generation_not_match,
              if_metageneration_match: if_metageneration_match,
              if_metageneration_not_match: if_metageneration_not_match,
              common_object_request_params: common_object_request_params,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::GetObjectMediaRequest)
            @get_object_media.call(req, options)
          end

          # Stores a new object and metadata.
          #
          # An object can be written either in a single message stream or in a
          # resumable sequence of message streams. To write using a single stream,
          # the client should include in the first message of the stream an
          # `InsertObjectSpec` describing the destination bucket, object, and any
          # preconditions. Additionally, the final message must set 'finish_write' to
          # true, or else it is an error.
          #
          # For a resumable write, the client should instead call
          # `StartResumableWrite()` and provide that method an `InsertObjectSpec.`
          # They should then attach the returned `upload_id` to the first message of
          # each following call to `Insert`. If there is an error or the connection is
          # broken during the resumable `Insert()`, the client should check the status
          # of the `Insert()` by calling `QueryWriteStatus()` and continue writing from
          # the returned `committed_size`. This may be less than the amount of data the
          # client previously sent.
          #
          # The service will not view the object as complete until the client has
          # sent an `Insert` with `finish_write` set to `true`. Sending any
          # requests on a stream after sending a request with `finish_write` set to
          # `true` will cause an error. The client **should** check the
          # `Object` it receives to determine how much data the service was
          # able to commit and whether the service views the object as complete.
          #
          # @param reqs [Enumerable<Google::Storage::V1::InsertObjectRequest>]
          #   The input requests.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Storage::V1::Object]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          #
          # @note
          #   EXPERIMENTAL:
          #     Streaming requests are still undergoing review.
          #     This method interface might change in the future.
          #
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `write_offset`:
          #   write_offset = 0
          #   request = { write_offset: write_offset }
          #   requests = [request]
          #   response = storage_client.insert_object(requests)

          def insert_object reqs, options: nil
            request_protos = reqs.lazy.map do |req|
              Google::Gax::to_proto(req, Google::Storage::V1::InsertObjectRequest)
            end
            @insert_object.call(request_protos, options)
          end

          # Retrieves a list of objects matching the criteria.
          #
          # @param bucket [String]
          #   Required. Name of the bucket in which to look for objects.
          # @param delimiter [String]
          #   Returns results in a directory-like mode. `items` will contain
          #   only objects whose names, aside from the `prefix`, do not
          #   contain `delimiter`. Objects whose names, aside from the
          #   `prefix`, contain `delimiter` will have their name,
          #   truncated after the `delimiter`, returned in
          #   `prefixes`. Duplicate `prefixes` are omitted.
          # @param include_trailing_delimiter [true, false]
          #   If true, objects that end in exactly one instance of `delimiter`
          #   will have their metadata included in `items` in addition to
          #   `prefixes`.
          # @param max_results [Integer]
          #   Maximum number of `items` plus `prefixes` to return
          #   in a single page of responses. As duplicate `prefixes` are
          #   omitted, fewer total results may be returned than requested. The service
          #   will use this parameter or 1,000 items, whichever is smaller.
          # @param page_token [String]
          #   A previously-returned page token representing part of the larger set of
          #   results to view.
          # @param prefix [String]
          #   Filter results to objects whose names begin with this prefix.
          # @param projection [Google::Storage::V1::CommonEnums::Projection]
          #   Set of properties to return. Defaults to `NO_ACL`.
          # @param versions [true, false]
          #   If `true`, lists all versions of an object as distinct results.
          #   The default is `false`. For more information, see
          #   [Object
          #   Versioning](https://cloud.google.com/storage/docs/object-versioning).
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::ListObjectsResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::ListObjectsResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #   response = storage_client.list_objects(bucket)

          def list_objects \
              bucket,
              delimiter: nil,
              include_trailing_delimiter: nil,
              max_results: nil,
              page_token: nil,
              prefix: nil,
              projection: nil,
              versions: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              delimiter: delimiter,
              include_trailing_delimiter: include_trailing_delimiter,
              max_results: max_results,
              page_token: page_token,
              prefix: prefix,
              projection: projection,
              versions: versions,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::ListObjectsRequest)
            @list_objects.call(req, options, &block)
          end

          # Rewrites a source object to a destination object. Optionally overrides
          # metadata.
          #
          # @param destination_bucket [String]
          #   Required. Name of the bucket in which to store the new object. Overrides the provided
          #   object metadata's `bucket` value, if any.
          # @param destination_object [String]
          #   Required. Name of the new object.
          #   Required when the object metadata is not otherwise provided. Overrides the
          #   object metadata's `name` value, if any.
          # @param source_bucket [String]
          #   Required. Name of the bucket in which to find the source object.
          # @param source_object [String]
          #   Required. Name of the source object.
          # @param destination_kms_key_name [String]
          #   Resource name of the Cloud KMS key, of the form
          #   `projects/my-project/locations/my-location/keyRings/my-kr/cryptoKeys/my-key`,
          #   that will be used to encrypt the object. Overrides the object
          #   metadata's `kms_key_name` value, if any.
          # @param destination_predefined_acl [Google::Storage::V1::CommonEnums::PredefinedObjectAcl]
          #   Apply a predefined set of access controls to the destination object.
          # @param if_generation_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the object's current generation
          #   matches the given value. Setting to 0 makes the operation succeed only if
          #   there are no live versions of the object.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_generation_not_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the object's current generation
          #   does not match the given value. If no live object exists, the precondition
          #   fails. Setting to 0 makes the operation succeed only if there is a live
          #   version of the object.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_metageneration_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the destination object's current
          #   metageneration matches the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_metageneration_not_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the destination object's current
          #   metageneration does not match the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_source_generation_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the source object's current
          #   generation matches the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_source_generation_not_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the source object's current
          #   generation does not match the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_source_metageneration_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the source object's current
          #   metageneration matches the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_source_metageneration_not_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the source object's current
          #   metageneration does not match the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param max_bytes_rewritten_per_call [Integer]
          #   The maximum number of bytes that will be rewritten per rewrite request.
          #   Most callers
          #   shouldn't need to specify this parameter - it is primarily in place to
          #   support testing. If specified the value must be an integral multiple of
          #   1 MiB (1048576). Also, this only applies to requests where the source and
          #   destination span locations and/or storage classes. Finally, this value must
          #   not change across rewrite calls else you'll get an error that the
          #   `rewriteToken` is invalid.
          # @param projection [Google::Storage::V1::CommonEnums::Projection]
          #   Set of properties to return. Defaults to `NO_ACL`, unless the
          #   object resource specifies the `acl` property, when it defaults
          #   to `full`.
          # @param rewrite_token [String]
          #   Include this field (from the previous rewrite response) on each rewrite
          #   request after the first one, until the rewrite response 'done' flag is
          #   true. Calls that provide a rewriteToken can omit all other request fields,
          #   but if included those fields must match the values provided in the first
          #   rewrite request.
          # @param source_generation [Integer]
          #   If present, selects a specific revision of the source object (as opposed to
          #   the latest version, the default).
          # @param object [Google::Storage::V1::Object | Hash]
          #   Properties of the destination, post-rewrite object.
          #   A hash of the same form as `Google::Storage::V1::Object`
          #   can also be provided.
          # @param copy_source_encryption_algorithm [String]
          #   The algorithm used to encrypt the source object, if any.
          # @param copy_source_encryption_key [String]
          #   The encryption key used to encrypt the source object, if any.
          # @param copy_source_encryption_key_sha256 [String]
          #   The SHA-256 hash of the key used to encrypt the source object, if any.
          # @param common_object_request_params [Google::Storage::V1::CommonObjectRequestParams | Hash]
          #   A set of parameters common to Storage API requests concerning an object.
          #   A hash of the same form as `Google::Storage::V1::CommonObjectRequestParams`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::RewriteResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::RewriteResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `destination_bucket`:
          #   destination_bucket = ''
          #
          #   # TODO: Initialize `destination_object`:
          #   destination_object = ''
          #
          #   # TODO: Initialize `source_bucket`:
          #   source_bucket = ''
          #
          #   # TODO: Initialize `source_object`:
          #   source_object = ''
          #   response = storage_client.rewrite_object(destination_bucket, destination_object, source_bucket, source_object)

          def rewrite_object \
              destination_bucket,
              destination_object,
              source_bucket,
              source_object,
              destination_kms_key_name: nil,
              destination_predefined_acl: nil,
              if_generation_match: nil,
              if_generation_not_match: nil,
              if_metageneration_match: nil,
              if_metageneration_not_match: nil,
              if_source_generation_match: nil,
              if_source_generation_not_match: nil,
              if_source_metageneration_match: nil,
              if_source_metageneration_not_match: nil,
              max_bytes_rewritten_per_call: nil,
              projection: nil,
              rewrite_token: nil,
              source_generation: nil,
              object: nil,
              copy_source_encryption_algorithm: nil,
              copy_source_encryption_key: nil,
              copy_source_encryption_key_sha256: nil,
              common_object_request_params: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              destination_bucket: destination_bucket,
              destination_object: destination_object,
              source_bucket: source_bucket,
              source_object: source_object,
              destination_kms_key_name: destination_kms_key_name,
              destination_predefined_acl: destination_predefined_acl,
              if_generation_match: if_generation_match,
              if_generation_not_match: if_generation_not_match,
              if_metageneration_match: if_metageneration_match,
              if_metageneration_not_match: if_metageneration_not_match,
              if_source_generation_match: if_source_generation_match,
              if_source_generation_not_match: if_source_generation_not_match,
              if_source_metageneration_match: if_source_metageneration_match,
              if_source_metageneration_not_match: if_source_metageneration_not_match,
              max_bytes_rewritten_per_call: max_bytes_rewritten_per_call,
              projection: projection,
              rewrite_token: rewrite_token,
              source_generation: source_generation,
              object: object,
              copy_source_encryption_algorithm: copy_source_encryption_algorithm,
              copy_source_encryption_key: copy_source_encryption_key,
              copy_source_encryption_key_sha256: copy_source_encryption_key_sha256,
              common_object_request_params: common_object_request_params,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::RewriteObjectRequest)
            @rewrite_object.call(req, options, &block)
          end

          # Starts a resumable write. How long the write operation remains valid, and
          # what happens when the write operation becomes invalid, are
          # service-dependent.
          #
          # @param insert_object_spec [Google::Storage::V1::InsertObjectSpec | Hash]
          #   The destination bucket, object, and metadata, as well as any preconditions.
          #   A hash of the same form as `Google::Storage::V1::InsertObjectSpec`
          #   can also be provided.
          # @param common_object_request_params [Google::Storage::V1::CommonObjectRequestParams | Hash]
          #   A set of parameters common to Storage API requests concerning an object.
          #   A hash of the same form as `Google::Storage::V1::CommonObjectRequestParams`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::StartResumableWriteResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::StartResumableWriteResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #   response = storage_client.start_resumable_write

          def start_resumable_write \
              insert_object_spec: nil,
              common_object_request_params: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              insert_object_spec: insert_object_spec,
              common_object_request_params: common_object_request_params,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::StartResumableWriteRequest)
            @start_resumable_write.call(req, options, &block)
          end

          # Determines the `committed_size` for an object that is being written, which
          # can then be used as the `write_offset` for the next `Write()` call.
          #
          # If the object does not exist (i.e., the object has been deleted, or the
          # first `Write()` has not yet reached the service), this method returns the
          # error `NOT_FOUND`.
          #
          # The client **may** call `QueryWriteStatus()` at any time to determine how
          # much data has been processed for this object. This is useful if the
          # client is buffering data and needs to know which data can be safely
          # evicted. For any sequence of `QueryWriteStatus()` calls for a given
          # object name, the sequence of returned `committed_size` values will be
          # non-decreasing.
          #
          # @param upload_id [String]
          #   Required. The name of the resume token for the object whose write status is being
          #   requested.
          # @param common_object_request_params [Google::Storage::V1::CommonObjectRequestParams | Hash]
          #   A set of parameters common to Storage API requests concerning an object.
          #   A hash of the same form as `Google::Storage::V1::CommonObjectRequestParams`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::QueryWriteStatusResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::QueryWriteStatusResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `upload_id`:
          #   upload_id = ''
          #   response = storage_client.query_write_status(upload_id)

          def query_write_status \
              upload_id,
              common_object_request_params: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              upload_id: upload_id,
              common_object_request_params: common_object_request_params,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::QueryWriteStatusRequest)
            @query_write_status.call(req, options, &block)
          end

          # Updates an object's metadata.
          #
          # @param bucket [String]
          #   Required. Name of the bucket in which the object resides.
          # @param object [String]
          #   Required. Name of the object.
          # @param generation [Integer]
          #   If present, selects a specific revision of this object (as opposed to the
          #   latest version, the default).
          # @param if_generation_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the object's current generation
          #   matches the given value. Setting to 0 makes the operation succeed only if
          #   there are no live versions of the object.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_generation_not_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the object's current generation
          #   does not match the given value. If no live object exists, the precondition
          #   fails. Setting to 0 makes the operation succeed only if there is a live
          #   version of the object.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_metageneration_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the object's current
          #   metageneration matches the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_metageneration_not_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the object's current
          #   metageneration does not match the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param predefined_acl [Google::Storage::V1::CommonEnums::PredefinedObjectAcl]
          #   Apply a predefined set of access controls to this object.
          # @param projection [Google::Storage::V1::CommonEnums::Projection]
          #   Set of properties to return. Defaults to `FULL`.
          # @param metadata [Google::Storage::V1::Object | Hash]
          #   The Object metadata for updating.
          #   A hash of the same form as `Google::Storage::V1::Object`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   List of fields to be updated.
          #
          #   To specify ALL fields, equivalent to the JSON API's "update" function,
          #   specify a single field with the value `*`. Note: not recommended. If a new
          #   field is introduced at a later time, an older client updating with the `*`
          #   may accidentally reset the new field's value.
          #
          #   Not specifying any fields is an error.
          #   Not specifying a field while setting that field to a non-default value is
          #   an error.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param common_object_request_params [Google::Storage::V1::CommonObjectRequestParams | Hash]
          #   A set of parameters common to Storage API requests concerning an object.
          #   A hash of the same form as `Google::Storage::V1::CommonObjectRequestParams`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::Object]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::Object]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #
          #   # TODO: Initialize `object`:
          #   object = ''
          #   response = storage_client.patch_object(bucket, object)

          def patch_object \
              bucket,
              object,
              generation: nil,
              if_generation_match: nil,
              if_generation_not_match: nil,
              if_metageneration_match: nil,
              if_metageneration_not_match: nil,
              predefined_acl: nil,
              projection: nil,
              metadata: nil,
              update_mask: nil,
              common_object_request_params: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              object: object,
              generation: generation,
              if_generation_match: if_generation_match,
              if_generation_not_match: if_generation_not_match,
              if_metageneration_match: if_metageneration_match,
              if_metageneration_not_match: if_metageneration_not_match,
              predefined_acl: predefined_acl,
              projection: projection,
              metadata: metadata,
              update_mask: update_mask,
              common_object_request_params: common_object_request_params,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::PatchObjectRequest)
            @patch_object.call(req, options, &block)
          end

          # Updates an object's metadata. Equivalent to PatchObject, but always
          # replaces all mutatable fields of the bucket with new values, reverting all
          # unspecified fields to their default values.
          #
          # @param bucket [String]
          #   Required. Name of the bucket in which the object resides.
          # @param object [String]
          #   Required. Name of the object.
          # @param generation [Integer]
          #   If present, selects a specific revision of this object (as opposed to the
          #   latest version, the default).
          # @param if_generation_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the object's current generation
          #   matches the given value. Setting to 0 makes the operation succeed only if
          #   there are no live versions of the object.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_generation_not_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the object's current generation
          #   does not match the given value. If no live object exists, the precondition
          #   fails. Setting to 0 makes the operation succeed only if there is a live
          #   version of the object.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_metageneration_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the object's current
          #   metageneration matches the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param if_metageneration_not_match [Google::Protobuf::Int64Value | Hash]
          #   Makes the operation conditional on whether the object's current
          #   metageneration does not match the given value.
          #   A hash of the same form as `Google::Protobuf::Int64Value`
          #   can also be provided.
          # @param predefined_acl [Google::Storage::V1::CommonEnums::PredefinedObjectAcl]
          #   Apply a predefined set of access controls to this object.
          # @param projection [Google::Storage::V1::CommonEnums::Projection]
          #   Set of properties to return. Defaults to `FULL`.
          # @param metadata [Google::Storage::V1::Object | Hash]
          #   The Object metadata for updating.
          #   A hash of the same form as `Google::Storage::V1::Object`
          #   can also be provided.
          # @param common_object_request_params [Google::Storage::V1::CommonObjectRequestParams | Hash]
          #   A set of parameters common to Storage API requests concerning an object.
          #   A hash of the same form as `Google::Storage::V1::CommonObjectRequestParams`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::Object]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::Object]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `bucket`:
          #   bucket = ''
          #
          #   # TODO: Initialize `object`:
          #   object = ''
          #   response = storage_client.update_object(bucket, object)

          def update_object \
              bucket,
              object,
              generation: nil,
              if_generation_match: nil,
              if_generation_not_match: nil,
              if_metageneration_match: nil,
              if_metageneration_not_match: nil,
              predefined_acl: nil,
              projection: nil,
              metadata: nil,
              common_object_request_params: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              object: object,
              generation: generation,
              if_generation_match: if_generation_match,
              if_generation_not_match: if_generation_not_match,
              if_metageneration_match: if_metageneration_match,
              if_metageneration_not_match: if_metageneration_not_match,
              predefined_acl: predefined_acl,
              projection: projection,
              metadata: metadata,
              common_object_request_params: common_object_request_params,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::UpdateObjectRequest)
            @update_object.call(req, options, &block)
          end

          # Gets the IAM policy for the specified object.
          #
          # @param iam_request [Google::Iam::V1::GetIamPolicyRequest | Hash]
          #   The request sent to IAM.
          #   A hash of the same form as `Google::Iam::V1::GetIamPolicyRequest`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Iam::V1::Policy]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Iam::V1::Policy]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #   response = storage_client.get_object_iam_policy

          def get_object_iam_policy \
              iam_request: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              iam_request: iam_request,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::GetIamPolicyRequest)
            @get_object_iam_policy.call(req, options, &block)
          end

          # Updates an IAM policy for the specified object.
          #
          # @param iam_request [Google::Iam::V1::SetIamPolicyRequest | Hash]
          #   The request sent to IAM.
          #   A hash of the same form as `Google::Iam::V1::SetIamPolicyRequest`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Iam::V1::Policy]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Iam::V1::Policy]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #   response = storage_client.set_object_iam_policy

          def set_object_iam_policy \
              iam_request: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              iam_request: iam_request,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::SetIamPolicyRequest)
            @set_object_iam_policy.call(req, options, &block)
          end

          # Tests a set of permissions on the given object to see which, if
          # any, are held by the caller.
          #
          # @param iam_request [Google::Iam::V1::TestIamPermissionsRequest | Hash]
          #   The request sent to IAM.
          #   A hash of the same form as `Google::Iam::V1::TestIamPermissionsRequest`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Iam::V1::TestIamPermissionsResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Iam::V1::TestIamPermissionsResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #   response = storage_client.test_object_iam_permissions

          def test_object_iam_permissions \
              iam_request: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              iam_request: iam_request,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::TestIamPermissionsRequest)
            @test_object_iam_permissions.call(req, options, &block)
          end

          # Watch for changes on all objects in a bucket.
          #
          # @param bucket [String]
          #   Name of the bucket in which to look for objects.
          # @param versions [true, false]
          #   If `true`, lists all versions of an object as distinct results.
          #   The default is `false`. For more information, see
          #   [Object
          #   Versioning](https://cloud.google.com/storage/docs/object-versioning).
          # @param delimiter [String]
          #   Returns results in a directory-like mode. `items` will contain
          #   only objects whose names, aside from the `prefix`, do not
          #   contain `delimiter`. Objects whose names, aside from the
          #   `prefix`, contain `delimiter` will have their name,
          #   truncated after the `delimiter`, returned in
          #   `prefixes`. Duplicate `prefixes` are omitted.
          # @param max_results [Integer]
          #   Maximum number of `items` plus `prefixes` to return
          #   in a single page of responses. As duplicate `prefixes` are
          #   omitted, fewer total results may be returned than requested. The service
          #   will use this parameter or 1,000 items, whichever is smaller.
          # @param prefix [String]
          #   Filter results to objects whose names begin with this prefix.
          # @param include_trailing_delimiter [true, false]
          #   If true, objects that end in exactly one instance of `delimiter`
          #   will have their metadata included in `items` in addition to
          #   `prefixes`.
          # @param page_token [String]
          #   A previously-returned page token representing part of the larger set of
          #   results to view.
          # @param projection [Google::Storage::V1::CommonEnums::Projection]
          #   Set of properties to return. Defaults to `NO_ACL`.
          # @param channel [Google::Storage::V1::Channel | Hash]
          #   Properties of the channel to be inserted.
          #   A hash of the same form as `Google::Storage::V1::Channel`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::Channel]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::Channel]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #   response = storage_client.watch_all_objects

          def watch_all_objects \
              bucket: nil,
              versions: nil,
              delimiter: nil,
              max_results: nil,
              prefix: nil,
              include_trailing_delimiter: nil,
              page_token: nil,
              projection: nil,
              channel: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              bucket: bucket,
              versions: versions,
              delimiter: delimiter,
              max_results: max_results,
              prefix: prefix,
              include_trailing_delimiter: include_trailing_delimiter,
              page_token: page_token,
              projection: projection,
              channel: channel,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::WatchAllObjectsRequest)
            @watch_all_objects.call(req, options, &block)
          end

          # Retrieves the name of a project's Google Cloud Storage service account.
          #
          # @param project_id [String]
          #   Required. Project ID.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::ServiceAccount]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::ServiceAccount]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `project_id`:
          #   project_id = ''
          #   response = storage_client.get_service_account(project_id)

          def get_service_account \
              project_id,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              project_id: project_id,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::GetProjectServiceAccountRequest)
            @get_service_account.call(req, options, &block)
          end

          # Creates a new HMAC key for the given service account.
          #
          # @param project_id [String]
          #   Required. The project that the HMAC-owning service account lives in.
          # @param service_account_email [String]
          #   Required. The service account to create the HMAC for.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::CreateHmacKeyResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::CreateHmacKeyResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `project_id`:
          #   project_id = ''
          #
          #   # TODO: Initialize `service_account_email`:
          #   service_account_email = ''
          #   response = storage_client.create_hmac_key(project_id, service_account_email)

          def create_hmac_key \
              project_id,
              service_account_email,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              project_id: project_id,
              service_account_email: service_account_email,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::CreateHmacKeyRequest)
            @create_hmac_key.call(req, options, &block)
          end

          # Deletes a given HMAC key.  Key must be in an INACTIVE state.
          #
          # @param access_id [String]
          #   Required. The identifying key for the HMAC to delete.
          # @param project_id [String]
          #   Required. The project id the HMAC key lies in.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `access_id`:
          #   access_id = ''
          #
          #   # TODO: Initialize `project_id`:
          #   project_id = ''
          #   storage_client.delete_hmac_key(access_id, project_id)

          def delete_hmac_key \
              access_id,
              project_id,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              access_id: access_id,
              project_id: project_id,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::DeleteHmacKeyRequest)
            @delete_hmac_key.call(req, options, &block)
            nil
          end

          # Gets an existing HMAC key metadata for the given id.
          #
          # @param access_id [String]
          #   Required. The identifying key for the HMAC to delete.
          # @param project_id [String]
          #   Required. The project id the HMAC key lies in.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::HmacKeyMetadata]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::HmacKeyMetadata]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `access_id`:
          #   access_id = ''
          #
          #   # TODO: Initialize `project_id`:
          #   project_id = ''
          #   response = storage_client.get_hmac_key(access_id, project_id)

          def get_hmac_key \
              access_id,
              project_id,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              access_id: access_id,
              project_id: project_id,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::GetHmacKeyRequest)
            @get_hmac_key.call(req, options, &block)
          end

          # Lists HMAC keys under a given project with the additional filters provided.
          #
          # @param project_id [String]
          #   Required. The project id to list HMAC keys for.
          # @param service_account_email [String]
          #   An optional filter to only return HMAC keys for one service account.
          # @param show_deleted_keys [true, false]
          #   An optional bool to return deleted keys that have not been wiped out yet.
          # @param max_results [Integer]
          #   The maximum number of keys to return.
          # @param page_token [String]
          #   A previously returned token from ListHmacKeysResponse to get the next page.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::ListHmacKeysResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::ListHmacKeysResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `project_id`:
          #   project_id = ''
          #   response = storage_client.list_hmac_keys(project_id)

          def list_hmac_keys \
              project_id,
              service_account_email: nil,
              show_deleted_keys: nil,
              max_results: nil,
              page_token: nil,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              project_id: project_id,
              service_account_email: service_account_email,
              show_deleted_keys: show_deleted_keys,
              max_results: max_results,
              page_token: page_token,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::ListHmacKeysRequest)
            @list_hmac_keys.call(req, options, &block)
          end

          # Updates a given HMAC key state between ACTIVE and INACTIVE.
          #
          # @param access_id [String]
          #   Required. The id of the HMAC key.
          # @param project_id [String]
          #   Required. The project id the HMAC's service account lies in.
          # @param metadata [Google::Storage::V1::HmacKeyMetadata | Hash]
          #   Required. The service account owner of the HMAC key.
          #   A hash of the same form as `Google::Storage::V1::HmacKeyMetadata`
          #   can also be provided.
          # @param common_request_params [Google::Storage::V1::CommonRequestParams | Hash]
          #   A set of parameters common to all Storage API requests.
          #   A hash of the same form as `Google::Storage::V1::CommonRequestParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Storage::V1::HmacKeyMetadata]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Storage::V1::HmacKeyMetadata]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/storage"
          #
          #   storage_client = Google::Cloud::Storage.new(version: :v1)
          #
          #   # TODO: Initialize `access_id`:
          #   access_id = ''
          #
          #   # TODO: Initialize `project_id`:
          #   project_id = ''
          #
          #   # TODO: Initialize `metadata`:
          #   metadata = {}
          #   response = storage_client.update_hmac_key(access_id, project_id, metadata)

          def update_hmac_key \
              access_id,
              project_id,
              metadata,
              common_request_params: nil,
              options: nil,
              &block
            req = {
              access_id: access_id,
              project_id: project_id,
              metadata: metadata,
              common_request_params: common_request_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Storage::V1::UpdateHmacKeyRequest)
            @update_hmac_key.call(req, options, &block)
          end
        end
      end
    end
  end
end
