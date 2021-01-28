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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/bigquery/storage/v1beta1/storage.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/bigquery/storage/v1beta1/storage_pb"
require "google/cloud/bigquery/storage/v1beta1/credentials"

module Google
  module Cloud
    module Bigquery
      module Storage
        module V1beta1
          # BigQuery storage API.
          #
          # The BigQuery storage API can be used to read data stored in BigQuery.
          #
          # @!attribute [r] big_query_storage_stub
          #   @return [Google::Cloud::Bigquery::Storage::V1beta1::BigQueryStorage::Stub]
          class BigQueryStorageClient
            attr_reader :big_query_storage_stub

            # The default address of the service.
            SERVICE_ADDRESS = "bigquerystorage.googleapis.com".freeze

            # The default port of the service.
            DEFAULT_SERVICE_PORT = 443

            # The default set of gRPC interceptors.
            GRPC_INTERCEPTORS = []

            DEFAULT_TIMEOUT = 30

            # The scopes needed to make gRPC calls to all of the methods defined in
            # this service.
            ALL_SCOPES = [
              "https://www.googleapis.com/auth/bigquery",
              "https://www.googleapis.com/auth/bigquery.readonly",
              "https://www.googleapis.com/auth/cloud-platform"
            ].freeze


            PROJECT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}"
            )

            private_constant :PROJECT_PATH_TEMPLATE

            READ_SESSION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}/sessions/{session}"
            )

            private_constant :READ_SESSION_PATH_TEMPLATE

            STREAM_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}/streams/{stream}"
            )

            private_constant :STREAM_PATH_TEMPLATE

            # Returns a fully-qualified project resource name string.
            # @param project [String]
            # @return [String]
            def self.project_path project
              PROJECT_PATH_TEMPLATE.render(
                :"project" => project
              )
            end

            # Returns a fully-qualified read_session resource name string.
            # @param project [String]
            # @param location [String]
            # @param session [String]
            # @return [String]
            def self.read_session_path project, location, session
              READ_SESSION_PATH_TEMPLATE.render(
                :"project" => project,
                :"location" => location,
                :"session" => session
              )
            end

            # Returns a fully-qualified stream resource name string.
            # @param project [String]
            # @param location [String]
            # @param stream [String]
            # @return [String]
            def self.stream_path project, location, stream
              STREAM_PATH_TEMPLATE.render(
                :"project" => project,
                :"location" => location,
                :"stream" => stream
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
              require "google/cloud/bigquery/storage/v1beta1/storage_services_pb"

              credentials ||= Google::Cloud::Bigquery::Storage::V1beta1::Credentials.default

              if credentials.is_a?(String) || credentials.is_a?(Hash)
                updater_proc = Google::Cloud::Bigquery::Storage::V1beta1::Credentials.new(credentials).updater_proc
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

              package_version = Gem.loaded_specs['google-cloud-bigquery-storage'].version.version

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
                "big_query_storage_client_config.json"
              )
              defaults = client_config_file.open do |f|
                Google::Gax.construct_settings(
                  "google.cloud.bigquery.storage.v1beta1.BigQueryStorage",
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
              @big_query_storage_stub = Google::Gax::Grpc.create_stub(
                service_path,
                port,
                chan_creds: chan_creds,
                channel: channel,
                updater_proc: updater_proc,
                scopes: scopes,
                interceptors: interceptors,
                &Google::Cloud::Bigquery::Storage::V1beta1::BigQueryStorage::Stub.method(:new)
              )

              @create_read_session = Google::Gax.create_api_call(
                @big_query_storage_stub.method(:create_read_session),
                defaults["create_read_session"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'table_reference.project_id' => request.table_reference.project_id, 'table_reference.dataset_id' => request.table_reference.dataset_id}
                end
              )
              @read_rows = Google::Gax.create_api_call(
                @big_query_storage_stub.method(:read_rows),
                defaults["read_rows"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'read_position.stream.name' => request.read_position.stream.name}
                end
              )
              @batch_create_read_session_streams = Google::Gax.create_api_call(
                @big_query_storage_stub.method(:batch_create_read_session_streams),
                defaults["batch_create_read_session_streams"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'session.name' => request.session.name}
                end
              )
              @finalize_stream = Google::Gax.create_api_call(
                @big_query_storage_stub.method(:finalize_stream),
                defaults["finalize_stream"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'stream.name' => request.stream.name}
                end
              )
              @split_read_stream = Google::Gax.create_api_call(
                @big_query_storage_stub.method(:split_read_stream),
                defaults["split_read_stream"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'original_stream.name' => request.original_stream.name}
                end
              )
            end

            # Service calls

            # Creates a new read session. A read session divides the contents of a
            # BigQuery table into one or more streams, which can then be used to read
            # data from the table. The read session also specifies properties of the
            # data to be read, such as a list of columns or a push-down filter describing
            # the rows to be returned.
            #
            # A particular row can be read by at most one stream. When the caller has
            # reached the end of each stream in the session, then all the data in the
            # table has been read.
            #
            # Read sessions automatically expire 24 hours after they are created and do
            # not require manual clean-up by the caller.
            #
            # @param table_reference [Google::Cloud::Bigquery::Storage::V1beta1::TableReference | Hash]
            #   Required. Reference to the table to read.
            #   A hash of the same form as `Google::Cloud::Bigquery::Storage::V1beta1::TableReference`
            #   can also be provided.
            # @param parent [String]
            #   Required. String of the form `projects/{project_id}` indicating the
            #   project this ReadSession is associated with. This is the project that will
            #   be billed for usage.
            # @param table_modifiers [Google::Cloud::Bigquery::Storage::V1beta1::TableModifiers | Hash]
            #   Any modifiers to the Table (e.g. snapshot timestamp).
            #   A hash of the same form as `Google::Cloud::Bigquery::Storage::V1beta1::TableModifiers`
            #   can also be provided.
            # @param requested_streams [Integer]
            #   Initial number of streams. If unset or 0, we will
            #   provide a value of streams so as to produce reasonable throughput. Must be
            #   non-negative. The number of streams may be lower than the requested number,
            #   depending on the amount parallelism that is reasonable for the table and
            #   the maximum amount of parallelism allowed by the system.
            #
            #   Streams must be read starting from offset 0.
            # @param read_options [Google::Cloud::Bigquery::Storage::V1beta1::TableReadOptions | Hash]
            #   Read options for this session (e.g. column selection, filters).
            #   A hash of the same form as `Google::Cloud::Bigquery::Storage::V1beta1::TableReadOptions`
            #   can also be provided.
            # @param format [Google::Cloud::Bigquery::Storage::V1beta1::DataFormat]
            #   Data output format. Currently default to Avro.
            # @param sharding_strategy [Google::Cloud::Bigquery::Storage::V1beta1::ShardingStrategy]
            #   The strategy to use for distributing data among multiple streams. Currently
            #   defaults to liquid sharding.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Bigquery::Storage::V1beta1::ReadSession]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Bigquery::Storage::V1beta1::ReadSession]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/storage"
            #
            #   big_query_storage_client = Google::Cloud::Bigquery::Storage.new(version: :v1beta1)
            #
            #   # TODO: Initialize `table_reference`:
            #   table_reference = {}
            #   formatted_parent = Google::Cloud::Bigquery::Storage::V1beta1::BigQueryStorageClient.project_path("[PROJECT]")
            #   response = big_query_storage_client.create_read_session(table_reference, formatted_parent)

            def create_read_session \
                table_reference,
                parent,
                table_modifiers: nil,
                requested_streams: nil,
                read_options: nil,
                format: nil,
                sharding_strategy: nil,
                options: nil,
                &block
              req = {
                table_reference: table_reference,
                parent: parent,
                table_modifiers: table_modifiers,
                requested_streams: requested_streams,
                read_options: read_options,
                format: format,
                sharding_strategy: sharding_strategy
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Storage::V1beta1::CreateReadSessionRequest)
              @create_read_session.call(req, options, &block)
            end

            # Reads rows from the table in the format prescribed by the read session.
            # Each response contains one or more table rows, up to a maximum of 10 MiB
            # per response; read requests which attempt to read individual rows larger
            # than this will fail.
            #
            # Each request also returns a set of stream statistics reflecting the
            # estimated total number of rows in the read stream. This number is computed
            # based on the total table size and the number of active streams in the read
            # session, and may change as other streams continue to read data.
            #
            # @param read_position [Google::Cloud::Bigquery::Storage::V1beta1::StreamPosition | Hash]
            #   Required. Identifier of the position in the stream to start reading from.
            #   The offset requested must be less than the last row read from ReadRows.
            #   Requesting a larger offset is undefined.
            #   A hash of the same form as `Google::Cloud::Bigquery::Storage::V1beta1::StreamPosition`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @return [Enumerable<Google::Cloud::Bigquery::Storage::V1beta1::ReadRowsResponse>]
            #   An enumerable of Google::Cloud::Bigquery::Storage::V1beta1::ReadRowsResponse instances.
            #
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/storage"
            #
            #   big_query_storage_client = Google::Cloud::Bigquery::Storage.new(version: :v1beta1)
            #
            #   # TODO: Initialize `read_position`:
            #   read_position = {}
            #   big_query_storage_client.read_rows(read_position).each do |element|
            #     # Process element.
            #   end

            def read_rows \
                read_position,
                options: nil
              req = {
                read_position: read_position
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Storage::V1beta1::ReadRowsRequest)
              @read_rows.call(req, options)
            end

            # Creates additional streams for a ReadSession. This API can be used to
            # dynamically adjust the parallelism of a batch processing task upwards by
            # adding additional workers.
            #
            # @param session [Google::Cloud::Bigquery::Storage::V1beta1::ReadSession | Hash]
            #   Required. Must be a non-expired session obtained from a call to
            #   CreateReadSession. Only the name field needs to be set.
            #   A hash of the same form as `Google::Cloud::Bigquery::Storage::V1beta1::ReadSession`
            #   can also be provided.
            # @param requested_streams [Integer]
            #   Required. Number of new streams requested. Must be positive.
            #   Number of added streams may be less than this, see CreateReadSessionRequest
            #   for more information.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Bigquery::Storage::V1beta1::BatchCreateReadSessionStreamsResponse]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Bigquery::Storage::V1beta1::BatchCreateReadSessionStreamsResponse]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/storage"
            #
            #   big_query_storage_client = Google::Cloud::Bigquery::Storage.new(version: :v1beta1)
            #
            #   # TODO: Initialize `session`:
            #   session = {}
            #
            #   # TODO: Initialize `requested_streams`:
            #   requested_streams = 0
            #   response = big_query_storage_client.batch_create_read_session_streams(session, requested_streams)

            def batch_create_read_session_streams \
                session,
                requested_streams,
                options: nil,
                &block
              req = {
                session: session,
                requested_streams: requested_streams
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Storage::V1beta1::BatchCreateReadSessionStreamsRequest)
              @batch_create_read_session_streams.call(req, options, &block)
            end

            # Triggers the graceful termination of a single stream in a ReadSession. This
            # API can be used to dynamically adjust the parallelism of a batch processing
            # task downwards without losing data.
            #
            # This API does not delete the stream -- it remains visible in the
            # ReadSession, and any data processed by the stream is not released to other
            # streams. However, no additional data will be assigned to the stream once
            # this call completes. Callers must continue reading data on the stream until
            # the end of the stream is reached so that data which has already been
            # assigned to the stream will be processed.
            #
            # This method will return an error if there are no other live streams
            # in the Session, or if SplitReadStream() has been called on the given
            # Stream.
            #
            # @param stream [Google::Cloud::Bigquery::Storage::V1beta1::Stream | Hash]
            #   Required. Stream to finalize.
            #   A hash of the same form as `Google::Cloud::Bigquery::Storage::V1beta1::Stream`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result []
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/storage"
            #
            #   big_query_storage_client = Google::Cloud::Bigquery::Storage.new(version: :v1beta1)
            #
            #   # TODO: Initialize `stream`:
            #   stream = {}
            #   big_query_storage_client.finalize_stream(stream)

            def finalize_stream \
                stream,
                options: nil,
                &block
              req = {
                stream: stream
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Storage::V1beta1::FinalizeStreamRequest)
              @finalize_stream.call(req, options, &block)
              nil
            end

            # Splits a given read stream into two Streams. These streams are referred to
            # as the primary and the residual of the split. The original stream can still
            # be read from in the same manner as before. Both of the returned streams can
            # also be read from, and the total rows return by both child streams will be
            # the same as the rows read from the original stream.
            #
            # Moreover, the two child streams will be allocated back to back in the
            # original Stream. Concretely, it is guaranteed that for streams Original,
            # Primary, and Residual, that Original[0-j] = Primary[0-j] and
            # Original[j-n] = Residual[0-m] once the streams have been read to
            # completion.
            #
            # This method is guaranteed to be idempotent.
            #
            # @param original_stream [Google::Cloud::Bigquery::Storage::V1beta1::Stream | Hash]
            #   Required. Stream to split.
            #   A hash of the same form as `Google::Cloud::Bigquery::Storage::V1beta1::Stream`
            #   can also be provided.
            # @param fraction [Float]
            #   A value in the range (0.0, 1.0) that specifies the fractional point at
            #   which the original stream should be split. The actual split point is
            #   evaluated on pre-filtered rows, so if a filter is provided, then there is
            #   no guarantee that the division of the rows between the new child streams
            #   will be proportional to this fractional value. Additionally, because the
            #   server-side unit for assigning data is collections of rows, this fraction
            #   will always map to to a data storage boundary on the server side.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Bigquery::Storage::V1beta1::SplitReadStreamResponse]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Bigquery::Storage::V1beta1::SplitReadStreamResponse]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/storage"
            #
            #   big_query_storage_client = Google::Cloud::Bigquery::Storage.new(version: :v1beta1)
            #
            #   # TODO: Initialize `original_stream`:
            #   original_stream = {}
            #   response = big_query_storage_client.split_read_stream(original_stream)

            def split_read_stream \
                original_stream,
                fraction: nil,
                options: nil,
                &block
              req = {
                original_stream: original_stream,
                fraction: fraction
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Storage::V1beta1::SplitReadStreamRequest)
              @split_read_stream.call(req, options, &block)
            end
          end
        end
      end
    end
  end
end
