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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/gaming/v1beta/game_server_configs_service.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"
require "google/gax/operation"
require "google/longrunning/operations_client"

require "google/cloud/gaming/v1beta/game_server_configs_service_pb"
require "google/cloud/gaming/v1beta/credentials"

module Google
  module Cloud
    module Gaming
      module V1beta
        # The game server config configures the game servers in an Agones fleet.
        #
        # @!attribute [r] game_server_configs_service_stub
        #   @return [Google::Cloud::Gaming::V1beta::GameServerConfigsService::Stub]
        class GameServerConfigsServiceClient
          attr_reader :game_server_configs_service_stub

          # The default address of the service.
          SERVICE_ADDRESS = "gameservices.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_game_server_configs" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "game_server_configs")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform"
          ].freeze

          class OperationsClient < Google::Longrunning::OperationsClient
            self::SERVICE_ADDRESS = GameServerConfigsServiceClient::SERVICE_ADDRESS
            self::GRPC_INTERCEPTORS = GameServerConfigsServiceClient::GRPC_INTERCEPTORS
          end

          GAME_SERVER_CONFIG_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}"
          )

          private_constant :GAME_SERVER_CONFIG_PATH_TEMPLATE

          GAME_SERVER_DEPLOYMENT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/gameServerDeployments/{deployment}"
          )

          private_constant :GAME_SERVER_DEPLOYMENT_PATH_TEMPLATE

          # Returns a fully-qualified game_server_config resource name string.
          # @param project [String]
          # @param location [String]
          # @param deployment [String]
          # @param config [String]
          # @return [String]
          def self.game_server_config_path project, location, deployment, config
            GAME_SERVER_CONFIG_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"deployment" => deployment,
              :"config" => config
            )
          end

          # Returns a fully-qualified game_server_deployment resource name string.
          # @param project [String]
          # @param location [String]
          # @param deployment [String]
          # @return [String]
          def self.game_server_deployment_path project, location, deployment
            GAME_SERVER_DEPLOYMENT_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"deployment" => deployment
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
            require "google/cloud/gaming/v1beta/game_server_configs_service_services_pb"

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
              "game_server_configs_service_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.gaming.v1beta.GameServerConfigsService",
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
            @game_server_configs_service_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Gaming::V1beta::GameServerConfigsService::Stub.method(:new)
            )

            @list_game_server_configs = Google::Gax.create_api_call(
              @game_server_configs_service_stub.method(:list_game_server_configs),
              defaults["list_game_server_configs"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_game_server_config = Google::Gax.create_api_call(
              @game_server_configs_service_stub.method(:get_game_server_config),
              defaults["get_game_server_config"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @create_game_server_config = Google::Gax.create_api_call(
              @game_server_configs_service_stub.method(:create_game_server_config),
              defaults["create_game_server_config"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @delete_game_server_config = Google::Gax.create_api_call(
              @game_server_configs_service_stub.method(:delete_game_server_config),
              defaults["delete_game_server_config"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
          end

          # Service calls

          # Lists game server configs in a given project, location, and game server
          # deployment.
          #
          # @param parent [String]
          #   Required. The parent resource name. Uses the form:
          #
          #   `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/*`.
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Gaming::V1beta::GameServerConfig>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Gaming::V1beta::GameServerConfig>]
          #   An enumerable of Google::Cloud::Gaming::V1beta::GameServerConfig instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gaming"
          #
          #   game_server_configs_client = Google::Cloud::Gaming::V1beta::GameServerConfigs.new(version: :v1beta)
          #   formatted_parent = Google::Cloud::Gaming::V1beta::GameServerConfigsServiceClient.game_server_deployment_path("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]")
          #
          #   # Iterate over all results.
          #   game_server_configs_client.list_game_server_configs(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   game_server_configs_client.list_game_server_configs(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_game_server_configs \
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
            req = Google::Gax::to_proto(req, Google::Cloud::Gaming::V1beta::ListGameServerConfigsRequest)
            @list_game_server_configs.call(req, options, &block)
          end

          # Gets details of a single game server config.
          #
          # @param name [String]
          #   Required. The name of the game server config to retrieve. Uses the form:
          #
          #   `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Gaming::V1beta::GameServerConfig]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Gaming::V1beta::GameServerConfig]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gaming"
          #
          #   game_server_configs_client = Google::Cloud::Gaming::V1beta::GameServerConfigs.new(version: :v1beta)
          #   formatted_name = Google::Cloud::Gaming::V1beta::GameServerConfigsServiceClient.game_server_config_path("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]")
          #   response = game_server_configs_client.get_game_server_config(formatted_name)

          def get_game_server_config \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gaming::V1beta::GetGameServerConfigRequest)
            @get_game_server_config.call(req, options, &block)
          end

          # Creates a new game server config in a given project, location, and game
          # server deployment. Game server configs are immutable, and are not applied
          # until referenced in the game server deployment rollout resource.
          #
          # @param parent [String]
          #   Required. The parent resource name. Uses the form:
          #
          #   `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/`.
          # @param config_id [String]
          #   Required. The ID of the game server config resource to be created.
          # @param game_server_config [Google::Cloud::Gaming::V1beta::GameServerConfig | Hash]
          #   Required. The game server config resource to be created.
          #   A hash of the same form as `Google::Cloud::Gaming::V1beta::GameServerConfig`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gaming"
          #
          #   game_server_configs_client = Google::Cloud::Gaming::V1beta::GameServerConfigs.new(version: :v1beta)
          #   formatted_parent = Google::Cloud::Gaming::V1beta::GameServerConfigsServiceClient.game_server_deployment_path("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]")
          #
          #   # TODO: Initialize `config_id`:
          #   config_id = ''
          #
          #   # TODO: Initialize `game_server_config`:
          #   game_server_config = {}
          #
          #   # Register a callback during the method call.
          #   operation = game_server_configs_client.create_game_server_config(formatted_parent, config_id, game_server_config) do |op|
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

          def create_game_server_config \
              parent,
              config_id,
              game_server_config,
              options: nil
            req = {
              parent: parent,
              config_id: config_id,
              game_server_config: game_server_config
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gaming::V1beta::CreateGameServerConfigRequest)
            operation = Google::Gax::Operation.new(
              @create_game_server_config.call(req, options),
              @operations_client,
              Google::Cloud::Gaming::V1beta::GameServerConfig,
              Google::Cloud::Gaming::V1beta::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Deletes a single game server config. The deletion will fail if the game
          # server config is referenced in a game server deployment rollout.
          #
          # @param name [String]
          #   Required. The name of the game server config to delete. Uses the form:
          #
          #   `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gaming"
          #
          #   game_server_configs_client = Google::Cloud::Gaming::V1beta::GameServerConfigs.new(version: :v1beta)
          #   formatted_name = Google::Cloud::Gaming::V1beta::GameServerConfigsServiceClient.game_server_config_path("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]")
          #
          #   # Register a callback during the method call.
          #   operation = game_server_configs_client.delete_game_server_config(formatted_name) do |op|
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

          def delete_game_server_config \
              name,
              options: nil
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gaming::V1beta::DeleteGameServerConfigRequest)
            operation = Google::Gax::Operation.new(
              @delete_game_server_config.call(req, options),
              @operations_client,
              Google::Protobuf::Empty,
              Google::Cloud::Gaming::V1beta::OperationMetadata,
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
