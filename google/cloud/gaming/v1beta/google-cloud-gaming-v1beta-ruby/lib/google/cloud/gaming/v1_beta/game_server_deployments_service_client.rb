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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/gaming/v1beta/game_server_deployments_service.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"
require "google/gax/operation"
require "google/longrunning/operations_client"

require "google/cloud/gaming/v1beta/game_server_deployments_service_pb"
require "google/cloud/gaming/v1_beta/credentials"

module Google
  module Cloud
    module Gaming
      module V1Beta
        # The game server deployment is used to control the deployment of Agones
        # fleets.
        #
        # @!attribute [r] game_server_deployments_service_stub
        #   @return [Google::Cloud::Gaming::V1beta::GameServerDeploymentsService::Stub]
        class GameServerDeploymentsServiceClient
          attr_reader :game_server_deployments_service_stub

          # The default address of the service.
          SERVICE_ADDRESS = "gameservices.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_game_server_deployments" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "game_server_deployments")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform"
          ].freeze

          class OperationsClient < Google::Longrunning::OperationsClient
            self::SERVICE_ADDRESS = GameServerDeploymentsServiceClient::SERVICE_ADDRESS
            self::GRPC_INTERCEPTORS = GameServerDeploymentsServiceClient::GRPC_INTERCEPTORS
          end

          GAME_SERVER_DEPLOYMENT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/gameServerDeployments/{deployment}"
          )

          private_constant :GAME_SERVER_DEPLOYMENT_PATH_TEMPLATE

          GAME_SERVER_DEPLOYMENT_ROLLOUT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout"
          )

          private_constant :GAME_SERVER_DEPLOYMENT_ROLLOUT_PATH_TEMPLATE

          LOCATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}"
          )

          private_constant :LOCATION_PATH_TEMPLATE

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

          # Returns a fully-qualified game_server_deployment_rollout resource name string.
          # @param project [String]
          # @param location [String]
          # @param deployment [String]
          # @return [String]
          def self.game_server_deployment_rollout_path project, location, deployment
            GAME_SERVER_DEPLOYMENT_ROLLOUT_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"deployment" => deployment
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
            require "google/cloud/gaming/v1beta/game_server_deployments_service_services_pb"

            credentials ||= Google::Cloud::Gaming::V1Beta::Credentials.default

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
              updater_proc = Google::Cloud::Gaming::V1Beta::Credentials.new(credentials).updater_proc
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
              "game_server_deployments_service_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.gaming.v1beta.GameServerDeploymentsService",
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
            @game_server_deployments_service_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Gaming::V1beta::GameServerDeploymentsService::Stub.method(:new)
            )

            @list_game_server_deployments = Google::Gax.create_api_call(
              @game_server_deployments_service_stub.method(:list_game_server_deployments),
              defaults["list_game_server_deployments"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_game_server_deployment = Google::Gax.create_api_call(
              @game_server_deployments_service_stub.method(:get_game_server_deployment),
              defaults["get_game_server_deployment"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @create_game_server_deployment = Google::Gax.create_api_call(
              @game_server_deployments_service_stub.method(:create_game_server_deployment),
              defaults["create_game_server_deployment"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @delete_game_server_deployment = Google::Gax.create_api_call(
              @game_server_deployments_service_stub.method(:delete_game_server_deployment),
              defaults["delete_game_server_deployment"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @update_game_server_deployment = Google::Gax.create_api_call(
              @game_server_deployments_service_stub.method(:update_game_server_deployment),
              defaults["update_game_server_deployment"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'game_server_deployment.name' => request.game_server_deployment.name}
              end
            )
            @get_game_server_deployment_rollout = Google::Gax.create_api_call(
              @game_server_deployments_service_stub.method(:get_game_server_deployment_rollout),
              defaults["get_game_server_deployment_rollout"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @update_game_server_deployment_rollout = Google::Gax.create_api_call(
              @game_server_deployments_service_stub.method(:update_game_server_deployment_rollout),
              defaults["update_game_server_deployment_rollout"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'rollout.name' => request.rollout.name}
              end
            )
            @preview_game_server_deployment_rollout = Google::Gax.create_api_call(
              @game_server_deployments_service_stub.method(:preview_game_server_deployment_rollout),
              defaults["preview_game_server_deployment_rollout"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'rollout.name' => request.rollout.name}
              end
            )
            @fetch_deployment_state = Google::Gax.create_api_call(
              @game_server_deployments_service_stub.method(:fetch_deployment_state),
              defaults["fetch_deployment_state"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
          end

          # Service calls

          # Lists game server deployments in a given project and location.
          #
          # @param parent [String]
          #   Required. The parent resource name. Uses the form:
          #   `projects/{project}/locations/{location}`.
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Gaming::V1beta::GameServerDeployment>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Gaming::V1beta::GameServerDeployment>]
          #   An enumerable of Google::Cloud::Gaming::V1beta::GameServerDeployment instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gaming/v1_beta"
          #
          #   game_server_deployments_client = Google::Cloud::Gaming::V1Beta::GameServerDeployments.new(version: :v1beta)
          #   formatted_parent = Google::Cloud::Gaming::V1Beta::GameServerDeploymentsServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # Iterate over all results.
          #   game_server_deployments_client.list_game_server_deployments(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   game_server_deployments_client.list_game_server_deployments(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_game_server_deployments \
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
            req = Google::Gax::to_proto(req, Google::Cloud::Gaming::V1beta::ListGameServerDeploymentsRequest)
            @list_game_server_deployments.call(req, options, &block)
          end

          # Gets details of a single game server deployment.
          #
          # @param name [String]
          #   Required. The name of the game server delpoyment to retrieve. Uses the form:
          #
          #   `projects/{project}/locations/{location}/gameServerDeployments/{deployment}`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Gaming::V1beta::GameServerDeployment]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Gaming::V1beta::GameServerDeployment]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gaming/v1_beta"
          #
          #   game_server_deployments_client = Google::Cloud::Gaming::V1Beta::GameServerDeployments.new(version: :v1beta)
          #   formatted_name = Google::Cloud::Gaming::V1Beta::GameServerDeploymentsServiceClient.game_server_deployment_path("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]")
          #   response = game_server_deployments_client.get_game_server_deployment(formatted_name)

          def get_game_server_deployment \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gaming::V1beta::GetGameServerDeploymentRequest)
            @get_game_server_deployment.call(req, options, &block)
          end

          # Creates a new game server deployment in a given project and location.
          #
          # @param parent [String]
          #   Required. The parent resource name. Uses the form:
          #   `projects/{project}/locations/{location}`.
          # @param deployment_id [String]
          #   Required. The ID of the game server delpoyment resource to be created.
          # @param game_server_deployment [Google::Cloud::Gaming::V1beta::GameServerDeployment | Hash]
          #   Required. The game server delpoyment resource to be created.
          #   A hash of the same form as `Google::Cloud::Gaming::V1beta::GameServerDeployment`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gaming/v1_beta"
          #
          #   game_server_deployments_client = Google::Cloud::Gaming::V1Beta::GameServerDeployments.new(version: :v1beta)
          #   formatted_parent = Google::Cloud::Gaming::V1Beta::GameServerDeploymentsServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # TODO: Initialize `deployment_id`:
          #   deployment_id = ''
          #
          #   # TODO: Initialize `game_server_deployment`:
          #   game_server_deployment = {}
          #
          #   # Register a callback during the method call.
          #   operation = game_server_deployments_client.create_game_server_deployment(formatted_parent, deployment_id, game_server_deployment) do |op|
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

          def create_game_server_deployment \
              parent,
              deployment_id,
              game_server_deployment,
              options: nil
            req = {
              parent: parent,
              deployment_id: deployment_id,
              game_server_deployment: game_server_deployment
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gaming::V1beta::CreateGameServerDeploymentRequest)
            operation = Google::Gax::Operation.new(
              @create_game_server_deployment.call(req, options),
              @operations_client,
              Google::Cloud::Gaming::V1beta::GameServerDeployment,
              Google::Cloud::Gaming::V1beta::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Deletes a single game server deployment.
          #
          # @param name [String]
          #   Required. The name of the game server delpoyment to delete. Uses the form:
          #
          #   `projects/{project}/locations/{location}/gameServerDeployments/{deployment}`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gaming/v1_beta"
          #
          #   game_server_deployments_client = Google::Cloud::Gaming::V1Beta::GameServerDeployments.new(version: :v1beta)
          #   formatted_name = Google::Cloud::Gaming::V1Beta::GameServerDeploymentsServiceClient.game_server_deployment_path("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]")
          #
          #   # Register a callback during the method call.
          #   operation = game_server_deployments_client.delete_game_server_deployment(formatted_name) do |op|
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

          def delete_game_server_deployment \
              name,
              options: nil
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gaming::V1beta::DeleteGameServerDeploymentRequest)
            operation = Google::Gax::Operation.new(
              @delete_game_server_deployment.call(req, options),
              @operations_client,
              Google::Protobuf::Empty,
              Google::Cloud::Gaming::V1beta::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Patches a game server deployment.
          #
          # @param game_server_deployment [Google::Cloud::Gaming::V1beta::GameServerDeployment | Hash]
          #   Required. The game server delpoyment to be updated.
          #   Only fields specified in update_mask are updated.
          #   A hash of the same form as `Google::Cloud::Gaming::V1beta::GameServerDeployment`
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
          #   require "google/cloud/gaming/v1_beta"
          #
          #   game_server_deployments_client = Google::Cloud::Gaming::V1Beta::GameServerDeployments.new(version: :v1beta)
          #
          #   # TODO: Initialize `game_server_deployment`:
          #   game_server_deployment = {}
          #
          #   # TODO: Initialize `update_mask`:
          #   update_mask = {}
          #
          #   # Register a callback during the method call.
          #   operation = game_server_deployments_client.update_game_server_deployment(game_server_deployment, update_mask) do |op|
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

          def update_game_server_deployment \
              game_server_deployment,
              update_mask,
              options: nil
            req = {
              game_server_deployment: game_server_deployment,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gaming::V1beta::UpdateGameServerDeploymentRequest)
            operation = Google::Gax::Operation.new(
              @update_game_server_deployment.call(req, options),
              @operations_client,
              Google::Cloud::Gaming::V1beta::GameServerDeployment,
              Google::Cloud::Gaming::V1beta::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Gets details a single game server deployment rollout.
          #
          # @param name [String]
          #   Required. The name of the game server delpoyment to retrieve. Uses the form:
          #
          #   `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Gaming::V1beta::GameServerDeploymentRollout]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Gaming::V1beta::GameServerDeploymentRollout]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gaming/v1_beta"
          #
          #   game_server_deployments_client = Google::Cloud::Gaming::V1Beta::GameServerDeployments.new(version: :v1beta)
          #   formatted_name = Google::Cloud::Gaming::V1Beta::GameServerDeploymentsServiceClient.game_server_deployment_path("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]")
          #   response = game_server_deployments_client.get_game_server_deployment_rollout(formatted_name)

          def get_game_server_deployment_rollout \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gaming::V1beta::GetGameServerDeploymentRolloutRequest)
            @get_game_server_deployment_rollout.call(req, options, &block)
          end

          # Patches a single game server deployment rollout.
          # The method will not return an error if the update does not affect any
          # existing realms. For example - if the default_game_server_config is changed
          # but all existing realms use the override, that is valid. Similarly, if a
          # non existing realm is explicitly called out in game_server_config_overrides
          # field, that will also not result in an error.
          #
          # @param rollout [Google::Cloud::Gaming::V1beta::GameServerDeploymentRollout | Hash]
          #   Required. The game server delpoyment rollout to be updated.
          #   Only fields specified in update_mask are updated.
          #   A hash of the same form as `Google::Cloud::Gaming::V1beta::GameServerDeploymentRollout`
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
          #   require "google/cloud/gaming/v1_beta"
          #
          #   game_server_deployments_client = Google::Cloud::Gaming::V1Beta::GameServerDeployments.new(version: :v1beta)
          #
          #   # TODO: Initialize `rollout`:
          #   rollout = {}
          #
          #   # TODO: Initialize `update_mask`:
          #   update_mask = {}
          #
          #   # Register a callback during the method call.
          #   operation = game_server_deployments_client.update_game_server_deployment_rollout(rollout, update_mask) do |op|
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

          def update_game_server_deployment_rollout \
              rollout,
              update_mask,
              options: nil
            req = {
              rollout: rollout,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gaming::V1beta::UpdateGameServerDeploymentRolloutRequest)
            operation = Google::Gax::Operation.new(
              @update_game_server_deployment_rollout.call(req, options),
              @operations_client,
              Google::Cloud::Gaming::V1beta::GameServerDeployment,
              Google::Cloud::Gaming::V1beta::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Previews the game server deployment rollout. This API does not mutate the
          # rollout resource.
          #
          # @param rollout [Google::Cloud::Gaming::V1beta::GameServerDeploymentRollout | Hash]
          #   Required. The game server deployment rollout to be updated.
          #   Only fields specified in update_mask are updated.
          #   A hash of the same form as `Google::Cloud::Gaming::V1beta::GameServerDeploymentRollout`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Optional. Mask of fields to update. At least one path must be supplied in
          #   this field. For the `FieldMask` definition, see
          #
          #   https:
          #   //developers.google.com/protocol-buffers
          #   // /docs/reference/google.protobuf#fieldmask
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param preview_time [Google::Protobuf::Timestamp | Hash]
          #   Optional. The target timestamp to compute the preview. Defaults to the immediately
          #   after the proposed rollout completes.
          #   A hash of the same form as `Google::Protobuf::Timestamp`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Gaming::V1beta::PreviewGameServerDeploymentRolloutResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Gaming::V1beta::PreviewGameServerDeploymentRolloutResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gaming/v1_beta"
          #
          #   game_server_deployments_client = Google::Cloud::Gaming::V1Beta::GameServerDeployments.new(version: :v1beta)
          #
          #   # TODO: Initialize `rollout`:
          #   rollout = {}
          #   response = game_server_deployments_client.preview_game_server_deployment_rollout(rollout)

          def preview_game_server_deployment_rollout \
              rollout,
              update_mask: nil,
              preview_time: nil,
              options: nil,
              &block
            req = {
              rollout: rollout,
              update_mask: update_mask,
              preview_time: preview_time
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gaming::V1beta::PreviewGameServerDeploymentRolloutRequest)
            @preview_game_server_deployment_rollout.call(req, options, &block)
          end

          # Retrieves information about the current state of the game server
          # deployment. Gathers all the Agones fleets and Agones autoscalers,
          # including fleets running an older version of the game server deployment.
          #
          # @param name [String]
          #   Required. The name of the game server delpoyment. Uses the form:
          #
          #   `projects/{project}/locations/{location}/gameServerDeployments/{deployment}`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Gaming::V1beta::FetchDeploymentStateResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Gaming::V1beta::FetchDeploymentStateResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gaming/v1_beta"
          #
          #   game_server_deployments_client = Google::Cloud::Gaming::V1Beta::GameServerDeployments.new(version: :v1beta)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #   response = game_server_deployments_client.fetch_deployment_state(name)

          def fetch_deployment_state \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gaming::V1beta::FetchDeploymentStateRequest)
            @fetch_deployment_state.call(req, options, &block)
          end
        end
      end
    end
  end
end
