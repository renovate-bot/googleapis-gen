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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/pubsublite/v1/cursor.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/pubsublite/v1/cursor_pb"
require "google/cloud/pubsublite/v1/credentials"

module Google
  module Cloud
    module Pubsublite
      module V1
        # The service that a subscriber client application uses to manage committed
        # cursors while receiving messsages. A cursor represents a subscriber's
        # progress within a topic partition for a given subscription.
        #
        # @!attribute [r] cursor_service_stub
        #   @return [Google::Cloud::Pubsublite::V1::CursorService::Stub]
        class CursorServiceClient
          attr_reader :cursor_service_stub

          # The default address of the service.
          SERVICE_ADDRESS = "pubsublite.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_partition_cursors" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "partition_cursors")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform"
          ].freeze


          SUBSCRIPTION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/subscriptions/{subscription}"
          )

          private_constant :SUBSCRIPTION_PATH_TEMPLATE

          # Returns a fully-qualified subscription resource name string.
          # @param project [String]
          # @param location [String]
          # @param subscription [String]
          # @return [String]
          def self.subscription_path project, location, subscription
            SUBSCRIPTION_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"subscription" => subscription
            )
          end

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
            require "google/cloud/pubsublite/v1/cursor_services_pb"

            credentials ||= Google::Cloud::Pubsublite::V1::Credentials.default

            if credentials.is_a?(String) || credentials.is_a?(Hash)
              updater_proc = Google::Cloud::Pubsublite::V1::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-cloud-pubsublite'].version.version

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
              "cursor_service_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.pubsublite.v1.CursorService",
                JSON.parse(f.read),
                client_config,
                Google::Gax::Grpc::STATUS_CODE_NAMES,
                timeout,
                page_descriptors: PAGE_DESCRIPTORS,
                errors: Google::Gax::Grpc::API_ERRORS,
                metadata: headers
              )
            end

            # Allow overriding the service path/port in subclasses.
            service_path = self.class::SERVICE_ADDRESS
            port = self.class::DEFAULT_SERVICE_PORT
            interceptors = self.class::GRPC_INTERCEPTORS
            @cursor_service_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Pubsublite::V1::CursorService::Stub.method(:new)
            )

            @streaming_commit_cursor = Google::Gax.create_api_call(
              @cursor_service_stub.method(:streaming_commit_cursor),
              defaults["streaming_commit_cursor"],
              exception_transformer: exception_transformer
            )
            @commit_cursor = Google::Gax.create_api_call(
              @cursor_service_stub.method(:commit_cursor),
              defaults["commit_cursor"],
              exception_transformer: exception_transformer
            )
            @list_partition_cursors = Google::Gax.create_api_call(
              @cursor_service_stub.method(:list_partition_cursors),
              defaults["list_partition_cursors"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
          end

          # Service calls

          # Establishes a stream with the server for managing committed cursors.
          #
          # @param reqs [Enumerable<Google::Cloud::Pubsublite::V1::StreamingCommitCursorRequest>]
          #   The input requests.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Enumerable<Google::Cloud::Pubsublite::V1::StreamingCommitCursorResponse>]
          #   An enumerable of Google::Cloud::Pubsublite::V1::StreamingCommitCursorResponse instances.
          #
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          #
          # @note
          #   EXPERIMENTAL:
          #     Streaming requests are still undergoing review.
          #     This method interface might change in the future.
          #
          # @example
          #   require "google/cloud/pubsublite"
          #
          #   cursor_client = Google::Cloud::Pubsublite::Cursor.new(version: :v1)
          #   request = {}
          #   requests = [request]
          #   cursor_client.streaming_commit_cursor(requests).each do |element|
          #     # Process element.
          #   end

          def streaming_commit_cursor reqs, options: nil
            request_protos = reqs.lazy.map do |req|
              Google::Gax::to_proto(req, Google::Cloud::Pubsublite::V1::StreamingCommitCursorRequest)
            end
            @streaming_commit_cursor.call(request_protos, options)
          end

          # Updates the committed cursor.
          #
          # @param subscription [String]
          #   The subscription for which to update the cursor.
          # @param partition [Integer]
          #   The partition for which to update the cursor. Partitions are zero indexed,
          #   so `partition` must be in the range [0, topic.num_partitions).
          # @param cursor [Google::Cloud::Pubsublite::V1::Cursor | Hash]
          #   The new value for the committed cursor.
          #   A hash of the same form as `Google::Cloud::Pubsublite::V1::Cursor`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Pubsublite::V1::CommitCursorResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Pubsublite::V1::CommitCursorResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/pubsublite"
          #
          #   cursor_client = Google::Cloud::Pubsublite::Cursor.new(version: :v1)
          #   response = cursor_client.commit_cursor

          def commit_cursor \
              subscription: nil,
              partition: nil,
              cursor: nil,
              options: nil,
              &block
            req = {
              subscription: subscription,
              partition: partition,
              cursor: cursor
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Pubsublite::V1::CommitCursorRequest)
            @commit_cursor.call(req, options, &block)
          end

          # Returns all committed cursor information for a subscription.
          #
          # @param parent [String]
          #   Required. The subscription for which to retrieve cursors.
          #   Structured like
          #   `projects/{project_number}/locations/{location}/subscriptions/{subscription_id}`.
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Pubsublite::V1::PartitionCursor>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Pubsublite::V1::PartitionCursor>]
          #   An enumerable of Google::Cloud::Pubsublite::V1::PartitionCursor instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/pubsublite"
          #
          #   cursor_client = Google::Cloud::Pubsublite::Cursor.new(version: :v1)
          #   formatted_parent = Google::Cloud::Pubsublite::V1::CursorServiceClient.subscription_path("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]")
          #
          #   # Iterate over all results.
          #   cursor_client.list_partition_cursors(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   cursor_client.list_partition_cursors(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_partition_cursors \
              parent,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Pubsublite::V1::ListPartitionCursorsRequest)
            @list_partition_cursors.call(req, options, &block)
          end
        end
      end
    end
  end
end
