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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/gaming/v1beta/game_server_clusters_service.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"
require "google/gax/operation"
require "google/longrunning/operations_client"

require "google/cloud/gaming/v1beta/game_server_clusters_service_pb"
require "google/cloud/gaming/v1beta/credentials"

module Google
  module Cloud
    module Gaming
      module V1beta
        # The game server cluster maps to Kubernetes clusters running Agones and is
        # used to manage fleets within clusters.
        #
        # @!attribute [r] game_server_clusters_service_stub
        #   @return [Google::Cloud::Gaming::V1beta::GameServerClustersService::Stub]
        class GameServerClustersServiceClient
          attr_reader :game_server_clusters_service_stub

          # The default address of the service.
          SERVICE_ADDRESS = "gameservices.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_game_server_clusters" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "game_server_clusters")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform"
          ].freeze

          class OperationsClient < Google::Longrunning::OperationsClient
            self::SERVICE_ADDRESS = GameServerClustersServiceClient::SERVICE_ADDRESS
            self::GRPC_INTERCEPTORS = GameServerClustersServiceClient::GRPC_INTERCEPTORS
          end

          GAME_SERVER_CLUSTER_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/realms/{realm}/gameServerClusters/{cluster}"
          )

          private_constant :GAME_SERVER_CLUSTER_PATH_TEMPLATE

          REALM_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/realms/{realm}"
          )

          private_constant :REALM_PATH_TEMPLATE

          # Returns a fully-qualified game_server_cluster resource name string.
          # @param project [String]
          # @param location [String]
          # @param realm [String]
          # @param cluster [String]
          # @return [String]
          def self.game_server_cluster_path project, location, realm, cluster
            GAME_SERVER_CLUSTER_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"realm" => realm,
              :"cluster" => cluster
            )
          end

          # Returns a fully-qualified realm resource name string.
          # @param project [String]
          # @param location [String]
          # @param realm [String]
          # @return [String]
          def self.realm_path project, location, realm
            REALM_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"realm" => realm
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
            require "google/cloud/gaming/v1beta/game_server_clusters_service_services_pb"

            credentials ||= Google::Cloud::Gaming::V1beta::Credentials.default

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
              updater_proc = Google::Cloud::Gaming::V1beta::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-cloud-gaming'].version.version

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
              "game_server_clusters_service_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.gaming.v1beta.GameServerClustersService",
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
            @game_server_clusters_service_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Gaming::V1beta::GameServerClustersService::Stub.method(:new)
            )

            @list_game_server_clusters = Google::Gax.create_api_call(
              @game_server_clusters_service_stub.method(:list_game_server_clusters),
              defaults["list_game_server_clusters"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_game_server_cluster = Google::Gax.create_api_call(
              @game_server_clusters_service_stub.method(:get_game_server_cluster),
              defaults["get_game_server_cluster"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @create_game_server_cluster = Google::Gax.create_api_call(
              @game_server_clusters_service_stub.method(:create_game_server_cluster),
              defaults["create_game_server_cluster"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @preview_create_game_server_cluster = Google::Gax.create_api_call(
              @game_server_clusters_service_stub.method(:preview_create_game_server_cluster),
              defaults["preview_create_game_server_cluster"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @delete_game_server_cluster = Google::Gax.create_api_call(
              @game_server_clusters_service_stub.method(:delete_game_server_cluster),
              defaults["delete_game_server_cluster"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @preview_delete_game_server_cluster = Google::Gax.create_api_call(
              @game_server_clusters_service_stub.method(:preview_delete_game_server_cluster),
              defaults["preview_delete_game_server_cluster"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @update_game_server_cluster = Google::Gax.create_api_call(
              @game_server_clusters_service_stub.method(:update_game_server_cluster),
              defaults["update_game_server_cluster"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'game_server_cluster.name' => request.game_server_cluster.name}
              end
            )
            @preview_update_game_server_cluster = Google::Gax.create_api_call(
              @game_server_clusters_service_stub.method(:preview_update_game_server_cluster),
              defaults["preview_update_game_server_cluster"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'game_server_cluster.name' => request.game_server_cluster.name}
              end
            )
          end

          # Service calls

          # Lists game server clusters in a given project and location.
          #
          # @param parent [String]
          #   Required. The parent resource name. Uses the form:
          #   "projects/{project}/locations/{location}/realms/{realm}".
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param filter [String]
          #   Optional. The filter to apply to list results.
          # @param order_by [String]
          #   Optional. Specifies the ordering of results following syntax at
          #   https://cloud.google.com/apis/design/design_patterns#sorting_order.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Gaming::V1beta::GameServerCluster>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Gaming::V1beta::GameServerCluster>]
          #   An enumerable of Google::Cloud::Gaming::V1beta::GameServerCluster instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gaming"
          #
          #   game_server_clusters_client = Google::Cloud::Gaming::V1beta::GameServerClusters.new(version: :v1beta)
          #   formatted_parent = Google::Cloud::Gaming::V1beta::GameServerClustersServiceClient.realm_path("[PROJECT]", "[LOCATION]", "[REALM]")
          #
          #   # Iterate over all results.
          #   game_server_clusters_client.list_game_server_clusters(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   game_server_clusters_client.list_game_server_clusters(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_game_server_clusters \
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
            req = Google::Gax::to_proto(req, Google::Cloud::Gaming::V1beta::ListGameServerClustersRequest)
            @list_game_server_clusters.call(req, options, &block)
          end

          # Gets details of a single game server cluster.
          #
          # @param name [String]
          #   Required. The name of the game server cluster to retrieve. Uses the form:
          #
          #   `projects/{project}/locations/{location}/realms/{realm-id}/gameServerClusters/{cluster}`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Gaming::V1beta::GameServerCluster]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Gaming::V1beta::GameServerCluster]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gaming"
          #
          #   game_server_clusters_client = Google::Cloud::Gaming::V1beta::GameServerClusters.new(version: :v1beta)
          #   formatted_name = Google::Cloud::Gaming::V1beta::GameServerClustersServiceClient.game_server_cluster_path("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]")
          #   response = game_server_clusters_client.get_game_server_cluster(formatted_name)

          def get_game_server_cluster \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gaming::V1beta::GetGameServerClusterRequest)
            @get_game_server_cluster.call(req, options, &block)
          end

          # Creates a new game server cluster in a given project and location.
          #
          # @param parent [String]
          #   Required. The parent resource name. Uses the form:
          #   `projects/{project}/locations/{location}/realms/{realm-id}`.
          # @param game_server_cluster_id [String]
          #   Required. The ID of the game server cluster resource to be created.
          # @param game_server_cluster [Google::Cloud::Gaming::V1beta::GameServerCluster | Hash]
          #   Required. The game server cluster resource to be created.
          #   A hash of the same form as `Google::Cloud::Gaming::V1beta::GameServerCluster`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gaming"
          #
          #   game_server_clusters_client = Google::Cloud::Gaming::V1beta::GameServerClusters.new(version: :v1beta)
          #   formatted_parent = Google::Cloud::Gaming::V1beta::GameServerClustersServiceClient.realm_path("[PROJECT]", "[LOCATION]", "[REALM]")
          #
          #   # TODO: Initialize `game_server_cluster_id`:
          #   game_server_cluster_id = ''
          #
          #   # TODO: Initialize `game_server_cluster`:
          #   game_server_cluster = {}
          #
          #   # Register a callback during the method call.
          #   operation = game_server_clusters_client.create_game_server_cluster(formatted_parent, game_server_cluster_id, game_server_cluster) do |op|
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

          def create_game_server_cluster \
              parent,
              game_server_cluster_id,
              game_server_cluster,
              options: nil
            req = {
              parent: parent,
              game_server_cluster_id: game_server_cluster_id,
              game_server_cluster: game_server_cluster
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gaming::V1beta::CreateGameServerClusterRequest)
            operation = Google::Gax::Operation.new(
              @create_game_server_cluster.call(req, options),
              @operations_client,
              Google::Cloud::Gaming::V1beta::GameServerCluster,
              Google::Cloud::Gaming::V1beta::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Previews creation of a new game server cluster in a given project and
          # location.
          #
          # @param parent [String]
          #   Required. The parent resource name. Uses the form:
          #   `projects/{project}/locations/{location}/realms/{realm}`.
          # @param game_server_cluster_id [String]
          #   Required. The ID of the game server cluster resource to be created.
          # @param game_server_cluster [Google::Cloud::Gaming::V1beta::GameServerCluster | Hash]
          #   Required. The game server cluster resource to be created.
          #   A hash of the same form as `Google::Cloud::Gaming::V1beta::GameServerCluster`
          #   can also be provided.
          # @param preview_time [Google::Protobuf::Timestamp | Hash]
          #   Optional. The target timestamp to compute the preview.
          #   A hash of the same form as `Google::Protobuf::Timestamp`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Gaming::V1beta::PreviewCreateGameServerClusterResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Gaming::V1beta::PreviewCreateGameServerClusterResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gaming"
          #
          #   game_server_clusters_client = Google::Cloud::Gaming::V1beta::GameServerClusters.new(version: :v1beta)
          #   formatted_parent = Google::Cloud::Gaming::V1beta::GameServerClustersServiceClient.realm_path("[PROJECT]", "[LOCATION]", "[REALM]")
          #
          #   # TODO: Initialize `game_server_cluster_id`:
          #   game_server_cluster_id = ''
          #
          #   # TODO: Initialize `game_server_cluster`:
          #   game_server_cluster = {}
          #   response = game_server_clusters_client.preview_create_game_server_cluster(formatted_parent, game_server_cluster_id, game_server_cluster)

          def preview_create_game_server_cluster \
              parent,
              game_server_cluster_id,
              game_server_cluster,
              preview_time: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              game_server_cluster_id: game_server_cluster_id,
              game_server_cluster: game_server_cluster,
              preview_time: preview_time
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gaming::V1beta::PreviewCreateGameServerClusterRequest)
            @preview_create_game_server_cluster.call(req, options, &block)
          end

          # Deletes a single game server cluster.
          #
          # @param name [String]
          #   Required. The name of the game server cluster to delete. Uses the form:
          #   `projects/{project}/locations/{location}/gameServerClusters/{cluster}`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gaming"
          #
          #   game_server_clusters_client = Google::Cloud::Gaming::V1beta::GameServerClusters.new(version: :v1beta)
          #   formatted_name = Google::Cloud::Gaming::V1beta::GameServerClustersServiceClient.game_server_cluster_path("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]")
          #
          #   # Register a callback during the method call.
          #   operation = game_server_clusters_client.delete_game_server_cluster(formatted_name) do |op|
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

          def delete_game_server_cluster \
              name,
              options: nil
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gaming::V1beta::DeleteGameServerClusterRequest)
            operation = Google::Gax::Operation.new(
              @delete_game_server_cluster.call(req, options),
              @operations_client,
              Google::Protobuf::Empty,
              Google::Cloud::Gaming::V1beta::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Previews deletion of a single game server cluster.
          #
          # @param name [String]
          #   Required. The name of the game server cluster to delete. Uses the form:
          #   `projects/{project}/locations/{location}/gameServerClusters/{cluster}`.
          # @param preview_time [Google::Protobuf::Timestamp | Hash]
          #   Optional. The target timestamp to compute the preview.
          #   A hash of the same form as `Google::Protobuf::Timestamp`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Gaming::V1beta::PreviewDeleteGameServerClusterResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Gaming::V1beta::PreviewDeleteGameServerClusterResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gaming"
          #
          #   game_server_clusters_client = Google::Cloud::Gaming::V1beta::GameServerClusters.new(version: :v1beta)
          #   formatted_name = Google::Cloud::Gaming::V1beta::GameServerClustersServiceClient.game_server_cluster_path("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]")
          #   response = game_server_clusters_client.preview_delete_game_server_cluster(formatted_name)

          def preview_delete_game_server_cluster \
              name,
              preview_time: nil,
              options: nil,
              &block
            req = {
              name: name,
              preview_time: preview_time
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gaming::V1beta::PreviewDeleteGameServerClusterRequest)
            @preview_delete_game_server_cluster.call(req, options, &block)
          end

          # Patches a single game server cluster.
          #
          # @param game_server_cluster [Google::Cloud::Gaming::V1beta::GameServerCluster | Hash]
          #   Required. The game server cluster to be updated.
          #   Only fields specified in update_mask are updated.
          #   A hash of the same form as `Google::Cloud::Gaming::V1beta::GameServerCluster`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Required. Mask of fields to update. At least one path must be supplied in
          #   this field. For the `FieldMask` definition, see
          #
          #   https:
          #   //developers.google.com/protocol-buffers
          #   // /docs/reference/google.protobuf#fieldmask
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gaming"
          #
          #   game_server_clusters_client = Google::Cloud::Gaming::V1beta::GameServerClusters.new(version: :v1beta)
          #
          #   # TODO: Initialize `game_server_cluster`:
          #   game_server_cluster = {}
          #
          #   # TODO: Initialize `update_mask`:
          #   update_mask = {}
          #
          #   # Register a callback during the method call.
          #   operation = game_server_clusters_client.update_game_server_cluster(game_server_cluster, update_mask) do |op|
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

          def update_game_server_cluster \
              game_server_cluster,
              update_mask,
              options: nil
            req = {
              game_server_cluster: game_server_cluster,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gaming::V1beta::UpdateGameServerClusterRequest)
            operation = Google::Gax::Operation.new(
              @update_game_server_cluster.call(req, options),
              @operations_client,
              Google::Cloud::Gaming::V1beta::GameServerCluster,
              Google::Cloud::Gaming::V1beta::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Previews updating a GameServerCluster.
          #
          # @param game_server_cluster [Google::Cloud::Gaming::V1beta::GameServerCluster | Hash]
          #   Required. The game server cluster to be updated.
          #   Only fields specified in update_mask are updated.
          #   A hash of the same form as `Google::Cloud::Gaming::V1beta::GameServerCluster`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Required. Mask of fields to update. At least one path must be supplied in
          #   this field. For the `FieldMask` definition, see
          #
          #   https:
          #   //developers.google.com/protocol-buffers
          #   // /docs/reference/google.protobuf#fieldmask
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param preview_time [Google::Protobuf::Timestamp | Hash]
          #   Optional. The target timestamp to compute the preview.
          #   A hash of the same form as `Google::Protobuf::Timestamp`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Gaming::V1beta::PreviewUpdateGameServerClusterResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Gaming::V1beta::PreviewUpdateGameServerClusterResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gaming"
          #
          #   game_server_clusters_client = Google::Cloud::Gaming::V1beta::GameServerClusters.new(version: :v1beta)
          #
          #   # TODO: Initialize `game_server_cluster`:
          #   game_server_cluster = {}
          #
          #   # TODO: Initialize `update_mask`:
          #   update_mask = {}
          #   response = game_server_clusters_client.preview_update_game_server_cluster(game_server_cluster, update_mask)

          def preview_update_game_server_cluster \
              game_server_cluster,
              update_mask,
              preview_time: nil,
              options: nil,
              &block
            req = {
              game_server_cluster: game_server_cluster,
              update_mask: update_mask,
              preview_time: preview_time
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gaming::V1beta::PreviewUpdateGameServerClusterRequest)
            @preview_update_game_server_cluster.call(req, options, &block)
          end
        end
      end
    end
  end
end
