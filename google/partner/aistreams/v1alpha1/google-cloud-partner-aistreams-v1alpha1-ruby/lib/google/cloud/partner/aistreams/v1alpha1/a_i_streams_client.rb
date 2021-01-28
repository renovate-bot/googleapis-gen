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
# https://github.com/googleapis/googleapis/blob/master/google/partner/aistreams/v1alpha1/aistreams.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"
require "google/gax/operation"
require "google/longrunning/operations_client"

require "google/partner/aistreams/v1alpha1/aistreams_pb"
require "google/cloud/partner/aistreams/v1alpha1/credentials"

module Google
  module Cloud
    module Partner
      module Aistreams
        module V1alpha1
          # AIStreams service.
          #
          # @!attribute [r] a_i_streams_stub
          #   @return [Google::Partner::Aistreams::V1alpha1::AIStreams::Stub]
          class AIStreamsClient
            attr_reader :a_i_streams_stub

            # The default address of the service.
            SERVICE_ADDRESS = "aistreams.googleapis.com".freeze

            # The default port of the service.
            DEFAULT_SERVICE_PORT = 443

            # The default set of gRPC interceptors.
            GRPC_INTERCEPTORS = []

            DEFAULT_TIMEOUT = 30

            PAGE_DESCRIPTORS = {
              "list_clusters" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "clusters"),
              "list_streams" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "streams")
            }.freeze

            private_constant :PAGE_DESCRIPTORS

            # The scopes needed to make gRPC calls to all of the methods defined in
            # this service.
            ALL_SCOPES = [
              "https://www.googleapis.com/auth/cloud-platform"
            ].freeze

            class OperationsClient < Google::Longrunning::OperationsClient
              self::SERVICE_ADDRESS = AIStreamsClient::SERVICE_ADDRESS
              self::GRPC_INTERCEPTORS = AIStreamsClient::GRPC_INTERCEPTORS
            end

            CLUSTER_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}/clusters/{cluster}"
            )

            private_constant :CLUSTER_PATH_TEMPLATE

            LOCATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}"
            )

            private_constant :LOCATION_PATH_TEMPLATE

            STREAM_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}/clusters/{cluster}/streams/{stream}"
            )

            private_constant :STREAM_PATH_TEMPLATE

            # Returns a fully-qualified cluster resource name string.
            # @param project [String]
            # @param location [String]
            # @param cluster [String]
            # @return [String]
            def self.cluster_path project, location, cluster
              CLUSTER_PATH_TEMPLATE.render(
                :"project" => project,
                :"location" => location,
                :"cluster" => cluster
              )
            end

            # Returns a fully-qualified location resource name string.
            # @param project [String]
            # @param location [String]
            # @return [String]
            def self.location_path project, location
              LOCATION_PATH_TEMPLATE.render(
                :"project" => project,
                :"location" => location
              )
            end

            # Returns a fully-qualified stream resource name string.
            # @param project [String]
            # @param location [String]
            # @param cluster [String]
            # @param stream [String]
            # @return [String]
            def self.stream_path project, location, cluster, stream
              STREAM_PATH_TEMPLATE.render(
                :"project" => project,
                :"location" => location,
                :"cluster" => cluster,
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
              require "google/partner/aistreams/v1alpha1/aistreams_services_pb"

              credentials ||= Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.default

              @operations_client = OperationsClient.new(
                credentials: credentials,
                scopes: scopes,
                client_config: client_config,
                timeout: timeout,
                lib_name: lib_name,
                lib_version: lib_version,
                metadata: metadata,
              )

              if credentials.is_a?(String) || credentials.is_a?(Hash)
                updater_proc = Google::Cloud::Partner::Aistreams::V1alpha1::Credentials.new(credentials).updater_proc
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

              package_version = Gem.loaded_specs['google-cloud-partner-aistreams'].version.version

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
                "a_i_streams_client_config.json"
              )
              defaults = client_config_file.open do |f|
                Google::Gax.construct_settings(
                  "google.partner.aistreams.v1alpha1.AIStreams",
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
              @a_i_streams_stub = Google::Gax::Grpc.create_stub(
                service_path,
                port,
                chan_creds: chan_creds,
                channel: channel,
                updater_proc: updater_proc,
                scopes: scopes,
                interceptors: interceptors,
                &Google::Partner::Aistreams::V1alpha1::AIStreams::Stub.method(:new)
              )

              @list_clusters = Google::Gax.create_api_call(
                @a_i_streams_stub.method(:list_clusters),
                defaults["list_clusters"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @get_cluster = Google::Gax.create_api_call(
                @a_i_streams_stub.method(:get_cluster),
                defaults["get_cluster"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @create_cluster = Google::Gax.create_api_call(
                @a_i_streams_stub.method(:create_cluster),
                defaults["create_cluster"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @update_cluster = Google::Gax.create_api_call(
                @a_i_streams_stub.method(:update_cluster),
                defaults["update_cluster"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'cluster.name' => request.cluster.name}
                end
              )
              @delete_cluster = Google::Gax.create_api_call(
                @a_i_streams_stub.method(:delete_cluster),
                defaults["delete_cluster"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @list_streams = Google::Gax.create_api_call(
                @a_i_streams_stub.method(:list_streams),
                defaults["list_streams"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @get_stream = Google::Gax.create_api_call(
                @a_i_streams_stub.method(:get_stream),
                defaults["get_stream"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @create_stream = Google::Gax.create_api_call(
                @a_i_streams_stub.method(:create_stream),
                defaults["create_stream"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @update_stream = Google::Gax.create_api_call(
                @a_i_streams_stub.method(:update_stream),
                defaults["update_stream"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'stream.name' => request.stream.name}
                end
              )
              @delete_stream = Google::Gax.create_api_call(
                @a_i_streams_stub.method(:delete_stream),
                defaults["delete_stream"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
            end

            # Service calls

            # Lists Clusters in a given project and location.
            #
            # @param parent [String]
            #   Required. The parent that owns the collection of Clusters.
            # @param page_size [Integer]
            #   The maximum number of resources contained in the underlying API
            #   response. If page streaming is performed per-resource, this
            #   parameter does not affect the return value. If page streaming is
            #   performed per-page, this determines the maximum number of
            #   resources in a page.
            # @param filter [String]
            #   Filter request.
            # @param order_by [String]
            #   Order by fields for the result.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Partner::Aistreams::V1alpha1::Cluster>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Partner::Aistreams::V1alpha1::Cluster>]
            #   An enumerable of Google::Partner::Aistreams::V1alpha1::Cluster instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/partner/aistreams"
            #
            #   a_i_streams_client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)
            #   formatted_parent = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.location_path("[PROJECT]", "[LOCATION]")
            #
            #   # Iterate over all results.
            #   a_i_streams_client.list_clusters(formatted_parent).each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   a_i_streams_client.list_clusters(formatted_parent).each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_clusters \
                parent,
                page_size: nil,
                filter: nil,
                order_by: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                page_size: page_size,
                filter: filter,
                order_by: order_by
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Partner::Aistreams::V1alpha1::ListClustersRequest)
              @list_clusters.call(req, options, &block)
            end

            # Gets details of a single Cluster.
            #
            # @param name [String]
            #   Required. The name of the Cluster resource to get.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Partner::Aistreams::V1alpha1::Cluster]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Partner::Aistreams::V1alpha1::Cluster]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/partner/aistreams"
            #
            #   a_i_streams_client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)
            #   formatted_name = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.cluster_path("[PROJECT]", "[LOCATION]", "[CLUSTER]")
            #   response = a_i_streams_client.get_cluster(formatted_name)

            def get_cluster \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Partner::Aistreams::V1alpha1::GetClusterRequest)
              @get_cluster.call(req, options, &block)
            end

            # Creates a new Cluster in a given project and location.
            #
            # @param parent [String]
            #   Required. The parent that owns the collection of Clusters.
            # @param cluster_id [String]
            #   Required. The cluster identifier.
            # @param cluster [Google::Partner::Aistreams::V1alpha1::Cluster | Hash]
            #   Required. The cluster resource to create.
            #   A hash of the same form as `Google::Partner::Aistreams::V1alpha1::Cluster`
            #   can also be provided.
            # @param request_id [String]
            #   Optional. An optional request ID to identify requests. Specify a unique request ID
            #   so that if you must retry your request, the server will know to ignore
            #   the request if it has already been completed. The server will guarantee
            #   that for at least 60 minutes since the first request.
            #
            #   For example, consider a situation where you make an initial request and the
            #   request times out. If you make the request again with the same request ID,
            #   the server can check if original operation with the same request ID was
            #   received, and if so, will ignore the second request. This prevents clients
            #   from accidentally creating duplicate commitments.
            #
            #   The request ID must be a valid UUID with the exception that zero UUID is
            #   not supported (00000000-0000-0000-0000-000000000000).
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @return [Google::Gax::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/partner/aistreams"
            #
            #   a_i_streams_client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)
            #   formatted_parent = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.location_path("[PROJECT]", "[LOCATION]")
            #
            #   # TODO: Initialize `cluster_id`:
            #   cluster_id = ''
            #
            #   # TODO: Initialize `cluster`:
            #   cluster = {}
            #
            #   # Register a callback during the method call.
            #   operation = a_i_streams_client.create_cluster(formatted_parent, cluster_id, cluster) do |op|
            #     raise op.results.message if op.error?
            #     op_results = op.results
            #     # Process the results.
            #
            #     metadata = op.metadata
            #     # Process the metadata.
            #   end
            #
            #   # Or use the return value to register a callback.
            #   operation.on_done do |op|
            #     raise op.results.message if op.error?
            #     op_results = op.results
            #     # Process the results.
            #
            #     metadata = op.metadata
            #     # Process the metadata.
            #   end
            #
            #   # Manually reload the operation.
            #   operation.reload!
            #
            #   # Or block until the operation completes, triggering callbacks on
            #   # completion.
            #   operation.wait_until_done!

            def create_cluster \
                parent,
                cluster_id,
                cluster,
                request_id: nil,
                options: nil
              req = {
                parent: parent,
                cluster_id: cluster_id,
                cluster: cluster,
                request_id: request_id
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Partner::Aistreams::V1alpha1::CreateClusterRequest)
              operation = Google::Gax::Operation.new(
                @create_cluster.call(req, options),
                @operations_client,
                Google::Partner::Aistreams::V1alpha1::Cluster,
                Google::Partner::Aistreams::V1alpha1::OperationMetadata,
                call_options: options
              )
              operation.on_done { |operation| yield(operation) } if block_given?
              operation
            end

            # Updates the parameters of a single Cluster.
            #
            # @param update_mask [Google::Protobuf::FieldMask | Hash]
            #   Required. Field mask is used to specify the fields to be overwritten in the
            #   Cluster resource by the update.
            #   The fields specified in the update_mask are relative to the resource, not
            #   the full request. A field will be overwritten if it is in the mask. If the
            #   user does not provide a mask then all fields will be overwritten.
            #   A hash of the same form as `Google::Protobuf::FieldMask`
            #   can also be provided.
            # @param cluster [Google::Partner::Aistreams::V1alpha1::Cluster | Hash]
            #   Required. The Cluster resource to update.
            #   A hash of the same form as `Google::Partner::Aistreams::V1alpha1::Cluster`
            #   can also be provided.
            # @param request_id [String]
            #   Optional. An optional request ID to identify requests. Specify a unique request ID
            #   so that if you must retry your request, the server will know to ignore
            #   the request if it has already been completed. The server will guarantee
            #   that for at least 60 minutes since the first request.
            #
            #   For example, consider a situation where you make an initial request and the
            #   request times out. If you make the request again with the same request ID,
            #   the server can check if original operation with the same request ID was
            #   received, and if so, will ignore the second request. This prevents clients
            #   from accidentally creating duplicate commitments.
            #
            #   The request ID must be a valid UUID with the exception that zero UUID is
            #   not supported (00000000-0000-0000-0000-000000000000).
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @return [Google::Gax::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/partner/aistreams"
            #
            #   a_i_streams_client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)
            #
            #   # TODO: Initialize `update_mask`:
            #   update_mask = {}
            #
            #   # TODO: Initialize `cluster`:
            #   cluster = {}
            #
            #   # Register a callback during the method call.
            #   operation = a_i_streams_client.update_cluster(update_mask, cluster) do |op|
            #     raise op.results.message if op.error?
            #     op_results = op.results
            #     # Process the results.
            #
            #     metadata = op.metadata
            #     # Process the metadata.
            #   end
            #
            #   # Or use the return value to register a callback.
            #   operation.on_done do |op|
            #     raise op.results.message if op.error?
            #     op_results = op.results
            #     # Process the results.
            #
            #     metadata = op.metadata
            #     # Process the metadata.
            #   end
            #
            #   # Manually reload the operation.
            #   operation.reload!
            #
            #   # Or block until the operation completes, triggering callbacks on
            #   # completion.
            #   operation.wait_until_done!

            def update_cluster \
                update_mask,
                cluster,
                request_id: nil,
                options: nil
              req = {
                update_mask: update_mask,
                cluster: cluster,
                request_id: request_id
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Partner::Aistreams::V1alpha1::UpdateClusterRequest)
              operation = Google::Gax::Operation.new(
                @update_cluster.call(req, options),
                @operations_client,
                Google::Partner::Aistreams::V1alpha1::Cluster,
                Google::Partner::Aistreams::V1alpha1::OperationMetadata,
                call_options: options
              )
              operation.on_done { |operation| yield(operation) } if block_given?
              operation
            end

            # Deletes a single Cluster.
            #
            # @param name [String]
            #   Required. The name of cluster to delete.
            # @param request_id [String]
            #   Optional. An optional request ID to identify requests. Specify a unique request ID
            #   so that if you must retry your request, the server will know to ignore
            #   the request if it has already been completed. The server will guarantee
            #   that for at least 60 minutes after the first request.
            #
            #   For example, consider a situation where you make an initial request and the
            #   request times out. If you make the request again with the same request ID,
            #   the server can check if original operation with the same request ID was
            #   received, and if so, will ignore the second request. This prevents clients
            #   from accidentally creating duplicate commitments.
            #
            #   The request ID must be a valid UUID with the exception that zero UUID is
            #   not supported (00000000-0000-0000-0000-000000000000).
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @return [Google::Gax::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/partner/aistreams"
            #
            #   a_i_streams_client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)
            #   formatted_name = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.cluster_path("[PROJECT]", "[LOCATION]", "[CLUSTER]")
            #
            #   # Register a callback during the method call.
            #   operation = a_i_streams_client.delete_cluster(formatted_name) do |op|
            #     raise op.results.message if op.error?
            #     op_results = op.results
            #     # Process the results.
            #
            #     metadata = op.metadata
            #     # Process the metadata.
            #   end
            #
            #   # Or use the return value to register a callback.
            #   operation.on_done do |op|
            #     raise op.results.message if op.error?
            #     op_results = op.results
            #     # Process the results.
            #
            #     metadata = op.metadata
            #     # Process the metadata.
            #   end
            #
            #   # Manually reload the operation.
            #   operation.reload!
            #
            #   # Or block until the operation completes, triggering callbacks on
            #   # completion.
            #   operation.wait_until_done!

            def delete_cluster \
                name,
                request_id: nil,
                options: nil
              req = {
                name: name,
                request_id: request_id
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Partner::Aistreams::V1alpha1::DeleteClusterRequest)
              operation = Google::Gax::Operation.new(
                @delete_cluster.call(req, options),
                @operations_client,
                Google::Protobuf::Empty,
                Google::Partner::Aistreams::V1alpha1::OperationMetadata,
                call_options: options
              )
              operation.on_done { |operation| yield(operation) } if block_given?
              operation
            end

            # Lists Streams in a given project, location and cluster.
            #
            # @param parent [String]
            #   Required. The parent that owns the collection of the Streams.
            # @param page_size [Integer]
            #   The maximum number of resources contained in the underlying API
            #   response. If page streaming is performed per-resource, this
            #   parameter does not affect the return value. If page streaming is
            #   performed per-page, this determines the maximum number of
            #   resources in a page.
            # @param filter [String]
            #   Filter request.
            # @param order_by [String]
            #   Order by fields for the result.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Partner::Aistreams::V1alpha1::Stream>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Partner::Aistreams::V1alpha1::Stream>]
            #   An enumerable of Google::Partner::Aistreams::V1alpha1::Stream instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/partner/aistreams"
            #
            #   a_i_streams_client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)
            #   formatted_parent = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.cluster_path("[PROJECT]", "[LOCATION]", "[CLUSTER]")
            #
            #   # Iterate over all results.
            #   a_i_streams_client.list_streams(formatted_parent).each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   a_i_streams_client.list_streams(formatted_parent).each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_streams \
                parent,
                page_size: nil,
                filter: nil,
                order_by: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                page_size: page_size,
                filter: filter,
                order_by: order_by
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Partner::Aistreams::V1alpha1::ListStreamsRequest)
              @list_streams.call(req, options, &block)
            end

            # Gets details of a single Stream.
            #
            # @param name [String]
            #   Required. The name of the stream.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Partner::Aistreams::V1alpha1::Stream]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Partner::Aistreams::V1alpha1::Stream]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/partner/aistreams"
            #
            #   a_i_streams_client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)
            #   formatted_name = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.stream_path("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]")
            #   response = a_i_streams_client.get_stream(formatted_name)

            def get_stream \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Partner::Aistreams::V1alpha1::GetStreamRequest)
              @get_stream.call(req, options, &block)
            end

            # Creates a new Stream in a given project and location.
            #
            # @param parent [String]
            #   Required. The parent that owns the collection of streams.
            # @param stream_id [String]
            #   Required. The stream identifier.
            # @param stream [Google::Partner::Aistreams::V1alpha1::Stream | Hash]
            #   Required. The stream to create.
            #   A hash of the same form as `Google::Partner::Aistreams::V1alpha1::Stream`
            #   can also be provided.
            # @param request_id [String]
            #   Optional. An optional request ID to identify requests. Specify a unique request ID
            #   so that if you must retry your request, the server will know to ignore
            #   the request if it has already been completed. The server will guarantee
            #   that for at least 60 minutes since the first request.
            #
            #   For example, consider a situation where you make an initial request and t
            #   he request times out. If you make the request again with the same request
            #   ID, the server can check if original operation with the same request ID
            #   was received, and if so, will ignore the second request. This prevents
            #   clients from accidentally creating duplicate commitments.
            #
            #   The request ID must be a valid UUID with the exception that zero UUID is
            #   not supported (00000000-0000-0000-0000-000000000000).
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @return [Google::Gax::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/partner/aistreams"
            #
            #   a_i_streams_client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)
            #   formatted_parent = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.cluster_path("[PROJECT]", "[LOCATION]", "[CLUSTER]")
            #
            #   # TODO: Initialize `stream_id`:
            #   stream_id = ''
            #
            #   # TODO: Initialize `stream`:
            #   stream = {}
            #
            #   # Register a callback during the method call.
            #   operation = a_i_streams_client.create_stream(formatted_parent, stream_id, stream) do |op|
            #     raise op.results.message if op.error?
            #     op_results = op.results
            #     # Process the results.
            #
            #     metadata = op.metadata
            #     # Process the metadata.
            #   end
            #
            #   # Or use the return value to register a callback.
            #   operation.on_done do |op|
            #     raise op.results.message if op.error?
            #     op_results = op.results
            #     # Process the results.
            #
            #     metadata = op.metadata
            #     # Process the metadata.
            #   end
            #
            #   # Manually reload the operation.
            #   operation.reload!
            #
            #   # Or block until the operation completes, triggering callbacks on
            #   # completion.
            #   operation.wait_until_done!

            def create_stream \
                parent,
                stream_id,
                stream,
                request_id: nil,
                options: nil
              req = {
                parent: parent,
                stream_id: stream_id,
                stream: stream,
                request_id: request_id
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Partner::Aistreams::V1alpha1::CreateStreamRequest)
              operation = Google::Gax::Operation.new(
                @create_stream.call(req, options),
                @operations_client,
                Google::Partner::Aistreams::V1alpha1::Stream,
                Google::Partner::Aistreams::V1alpha1::OperationMetadata,
                call_options: options
              )
              operation.on_done { |operation| yield(operation) } if block_given?
              operation
            end

            # Updates the parameters of a single Stream.
            #
            # @param update_mask [Google::Protobuf::FieldMask | Hash]
            #   Required. Field mask is used to specify the fields to be overwritten in the
            #   Stream resource by the update.
            #   The fields specified in the update_mask are relative to the resource, not
            #   the full request. A field will be overwritten if it is in the mask. If the
            #   user does not provide a mask then all fields will be overwritten.
            #   A hash of the same form as `Google::Protobuf::FieldMask`
            #   can also be provided.
            # @param stream [Google::Partner::Aistreams::V1alpha1::Stream | Hash]
            #   Required. The stream resource to update.
            #   A hash of the same form as `Google::Partner::Aistreams::V1alpha1::Stream`
            #   can also be provided.
            # @param request_id [String]
            #   Optional. An optional request ID to identify requests. Specify a unique request ID
            #   so that if you must retry your request, the server will know to ignore
            #   the request if it has already been completed. The server will guarantee
            #   that for at least 60 minutes since the first request.
            #
            #   For example, consider a situation where you make an initial request and t
            #   he request times out. If you make the request again with the same request
            #   ID, the server can check if original operation with the same request ID
            #   was received, and if so, will ignore the second request. This prevents
            #   clients from accidentally creating duplicate commitments.
            #
            #   The request ID must be a valid UUID with the exception that zero UUID is
            #   not supported (00000000-0000-0000-0000-000000000000).
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @return [Google::Gax::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/partner/aistreams"
            #
            #   a_i_streams_client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)
            #
            #   # TODO: Initialize `update_mask`:
            #   update_mask = {}
            #
            #   # TODO: Initialize `stream`:
            #   stream = {}
            #
            #   # Register a callback during the method call.
            #   operation = a_i_streams_client.update_stream(update_mask, stream) do |op|
            #     raise op.results.message if op.error?
            #     op_results = op.results
            #     # Process the results.
            #
            #     metadata = op.metadata
            #     # Process the metadata.
            #   end
            #
            #   # Or use the return value to register a callback.
            #   operation.on_done do |op|
            #     raise op.results.message if op.error?
            #     op_results = op.results
            #     # Process the results.
            #
            #     metadata = op.metadata
            #     # Process the metadata.
            #   end
            #
            #   # Manually reload the operation.
            #   operation.reload!
            #
            #   # Or block until the operation completes, triggering callbacks on
            #   # completion.
            #   operation.wait_until_done!

            def update_stream \
                update_mask,
                stream,
                request_id: nil,
                options: nil
              req = {
                update_mask: update_mask,
                stream: stream,
                request_id: request_id
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Partner::Aistreams::V1alpha1::UpdateStreamRequest)
              operation = Google::Gax::Operation.new(
                @update_stream.call(req, options),
                @operations_client,
                Google::Partner::Aistreams::V1alpha1::Stream,
                Google::Partner::Aistreams::V1alpha1::OperationMetadata,
                call_options: options
              )
              operation.on_done { |operation| yield(operation) } if block_given?
              operation
            end

            # Deletes a single Stream.
            #
            # @param name [String]
            #   Required. The name of the stream.
            # @param request_id [String]
            #   Optional. An optional request ID to identify requests. Specify a unique request ID
            #   so that if you must retry your request, the server will know to ignore
            #   the request if it has already been completed. The server will guarantee
            #   that for at least 60 minutes after the first request.
            #
            #   For example, consider a situation where you make an initial request and t
            #   he request times out. If you make the request again with the same request
            #   ID, the server can check if original operation with the same request ID
            #   was received, and if so, will ignore the second request. This prevents
            #   clients from accidentally creating duplicate commitments.
            #
            #   The request ID must be a valid UUID with the exception that zero UUID is
            #   not supported (00000000-0000-0000-0000-000000000000).
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @return [Google::Gax::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/partner/aistreams"
            #
            #   a_i_streams_client = Google::Cloud::Partner::Aistreams.new(version: :v1alpha1)
            #   formatted_name = Google::Cloud::Partner::Aistreams::V1alpha1::AIStreamsClient.stream_path("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]")
            #
            #   # Register a callback during the method call.
            #   operation = a_i_streams_client.delete_stream(formatted_name) do |op|
            #     raise op.results.message if op.error?
            #     op_results = op.results
            #     # Process the results.
            #
            #     metadata = op.metadata
            #     # Process the metadata.
            #   end
            #
            #   # Or use the return value to register a callback.
            #   operation.on_done do |op|
            #     raise op.results.message if op.error?
            #     op_results = op.results
            #     # Process the results.
            #
            #     metadata = op.metadata
            #     # Process the metadata.
            #   end
            #
            #   # Manually reload the operation.
            #   operation.reload!
            #
            #   # Or block until the operation completes, triggering callbacks on
            #   # completion.
            #   operation.wait_until_done!

            def delete_stream \
                name,
                request_id: nil,
                options: nil
              req = {
                name: name,
                request_id: request_id
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Partner::Aistreams::V1alpha1::DeleteStreamRequest)
              operation = Google::Gax::Operation.new(
                @delete_stream.call(req, options),
                @operations_client,
                Google::Protobuf::Empty,
                Google::Partner::Aistreams::V1alpha1::OperationMetadata,
                call_options: options
              )
              operation.on_done { |operation| yield(operation) } if block_given?
              operation
            end
          end
        end
      end
    end
  end
end
