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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/pubsublite/v1/topic_stats.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/pubsublite/v1/topic_stats_pb"
require "google/cloud/pubsublite/v1/credentials"

module Google
  module Cloud
    module Pubsublite
      module V1
        # This service allows users to get stats about messages in their topic.
        #
        # @!attribute [r] topic_stats_service_stub
        #   @return [Google::Cloud::Pubsublite::V1::TopicStatsService::Stub]
        class TopicStatsServiceClient
          attr_reader :topic_stats_service_stub

          # The default address of the service.
          SERVICE_ADDRESS = "pubsublite.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform"
          ].freeze


          TOPIC_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/topics/{topic}"
          )

          private_constant :TOPIC_PATH_TEMPLATE

          # Returns a fully-qualified topic resource name string.
          # @param project [String]
          # @param location [String]
          # @param topic [String]
          # @return [String]
          def self.topic_path project, location, topic
            TOPIC_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"topic" => topic
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
            require "google/cloud/pubsublite/v1/topic_stats_services_pb"

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
              "topic_stats_service_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.pubsublite.v1.TopicStatsService",
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
            @topic_stats_service_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Pubsublite::V1::TopicStatsService::Stub.method(:new)
            )

            @compute_message_stats = Google::Gax.create_api_call(
              @topic_stats_service_stub.method(:compute_message_stats),
              defaults["compute_message_stats"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'topic' => request.topic}
              end
            )
            @compute_head_cursor = Google::Gax.create_api_call(
              @topic_stats_service_stub.method(:compute_head_cursor),
              defaults["compute_head_cursor"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'topic' => request.topic}
              end
            )
          end

          # Service calls

          # Compute statistics about a range of messages in a given topic and
          # partition.
          #
          # @param topic [String]
          #   Required. The topic for which we should compute message stats.
          # @param partition [Integer]
          #   Required. The partition for which we should compute message stats.
          # @param start_cursor [Google::Cloud::Pubsublite::V1::Cursor | Hash]
          #   The inclusive start of the range.
          #   A hash of the same form as `Google::Cloud::Pubsublite::V1::Cursor`
          #   can also be provided.
          # @param end_cursor [Google::Cloud::Pubsublite::V1::Cursor | Hash]
          #   The exclusive end of the range. The range is empty if end_cursor <=
          #   start_cursor. Specifying a start_cursor before the first message and an
          #   end_cursor after the last message will retrieve all messages.
          #   A hash of the same form as `Google::Cloud::Pubsublite::V1::Cursor`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Pubsublite::V1::ComputeMessageStatsResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Pubsublite::V1::ComputeMessageStatsResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/pubsublite"
          #
          #   topic_stats_client = Google::Cloud::Pubsublite::TopicStats.new(version: :v1)
          #   formatted_topic = Google::Cloud::Pubsublite::V1::TopicStatsServiceClient.topic_path("[PROJECT]", "[LOCATION]", "[TOPIC]")
          #
          #   # TODO: Initialize `partition`:
          #   partition = 0
          #   response = topic_stats_client.compute_message_stats(formatted_topic, partition)

          def compute_message_stats \
              topic,
              partition,
              start_cursor: nil,
              end_cursor: nil,
              options: nil,
              &block
            req = {
              topic: topic,
              partition: partition,
              start_cursor: start_cursor,
              end_cursor: end_cursor
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Pubsublite::V1::ComputeMessageStatsRequest)
            @compute_message_stats.call(req, options, &block)
          end

          # Compute the head cursor for the partition.
          # The head cursor's offset is guaranteed to be less than or equal to all
          # messages which have not yet been acknowledged as published, and
          # greater than the offset of any message whose publish has already
          # been acknowledged. It is zero if there have never been messages in the
          # partition.
          #
          # @param topic [String]
          #   Required. The topic for which we should compute the head cursor.
          # @param partition [Integer]
          #   Required. The partition for which we should compute the head cursor.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Pubsublite::V1::ComputeHeadCursorResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Pubsublite::V1::ComputeHeadCursorResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/pubsublite"
          #
          #   topic_stats_client = Google::Cloud::Pubsublite::TopicStats.new(version: :v1)
          #   formatted_topic = Google::Cloud::Pubsublite::V1::TopicStatsServiceClient.topic_path("[PROJECT]", "[LOCATION]", "[TOPIC]")
          #
          #   # TODO: Initialize `partition`:
          #   partition = 0
          #   response = topic_stats_client.compute_head_cursor(formatted_topic, partition)

          def compute_head_cursor \
              topic,
              partition,
              options: nil,
              &block
            req = {
              topic: topic,
              partition: partition
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Pubsublite::V1::ComputeHeadCursorRequest)
            @compute_head_cursor.call(req, options, &block)
          end
        end
      end
    end
  end
end
