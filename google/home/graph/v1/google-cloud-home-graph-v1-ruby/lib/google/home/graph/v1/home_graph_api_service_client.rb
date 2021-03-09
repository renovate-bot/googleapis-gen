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
# https://github.com/googleapis/googleapis/blob/master/google/home/graph/v1/homegraph.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/home/graph/v1/homegraph_pb"
require "google/home/graph/v1/credentials"

module Google
  module Home
    module Graph
      module V1
        # Google Home Graph API service. The Home Graph service provides support for
        # accessing first-party and third-party devices stored in Google's Home Graph.
        # The Home Graph database provides contextual data about the relationships
        # between devices and the home.
        #
        # For more details, see the [Home Graph developer
        # guide](https://developers.google.com/assistant/smarthome/concepts/homegraph).
        #
        # @!attribute [r] home_graph_api_service_stub
        #   @return [Google::Home::Graph::V1::HomeGraphApiService::Stub]
        class HomeGraphApiServiceClient
          attr_reader :home_graph_api_service_stub

          # The default address of the service.
          SERVICE_ADDRESS = "homegraph.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
          ].freeze


          AGENT_USER_PATH_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "agentUsers/{agent_user_path=**}"
          )

          private_constant :AGENT_USER_PATH_PATH_TEMPLATE

          # Returns a fully-qualified agent_user_path resource name string.
          # @param agent_user_path [String]
          # @return [String]
          def self.agent_user_path_path agent_user_path
            AGENT_USER_PATH_PATH_TEMPLATE.render(
              :"agent_user_path" => agent_user_path
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
            require "google/home/graph/v1/homegraph_services_pb"

            credentials ||= Google::Home::Graph::V1::Credentials.default

            if credentials.is_a?(String) || credentials.is_a?(Hash)
              updater_proc = Google::Home::Graph::V1::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-home-graph'].version.version

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
              "home_graph_api_service_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.home.graph.v1.HomeGraphApiService",
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
            @home_graph_api_service_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Home::Graph::V1::HomeGraphApiService::Stub.method(:new)
            )

            @request_sync_devices = Google::Gax.create_api_call(
              @home_graph_api_service_stub.method(:request_sync_devices),
              defaults["request_sync_devices"],
              exception_transformer: exception_transformer
            )
            @report_state_and_notification = Google::Gax.create_api_call(
              @home_graph_api_service_stub.method(:report_state_and_notification),
              defaults["report_state_and_notification"],
              exception_transformer: exception_transformer
            )
            @delete_agent_user = Google::Gax.create_api_call(
              @home_graph_api_service_stub.method(:delete_agent_user),
              defaults["delete_agent_user"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'agent_user_id' => request.agent_user_id}
              end
            )
            @query = Google::Gax.create_api_call(
              @home_graph_api_service_stub.method(:query),
              defaults["query"],
              exception_transformer: exception_transformer
            )
            @sync = Google::Gax.create_api_call(
              @home_graph_api_service_stub.method(:sync),
              defaults["sync"],
              exception_transformer: exception_transformer
            )
          end

          # Service calls

          # Requests Google to send an `action.devices.SYNC`
          # [intent](https://developers.google.com/assistant/smarthome/reference/intent/sync)
          # to your smart home Action to update device metadata for the given user.
          #
          #
          # The third-party user's identity is passed via the `agent_user_id`
          # (see
          # {Google::Home::Graph::V1::RequestSyncDevicesRequest RequestSyncDevicesRequest}).
          # This request must be authorized using service account credentials from your
          # Actions console project.
          #
          # @param agent_user_id [String]
          #   Required. Third-party user ID.
          # @param async [true, false]
          #   Optional. If set, the request will be added to a queue and a response will
          #   be returned immediately. This enables concurrent requests for the given
          #   `agent_user_id`, but the caller will not receive any error responses.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Home::Graph::V1::RequestSyncDevicesResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Home::Graph::V1::RequestSyncDevicesResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/home/graph"
          #
          #   home_graph_api_client = Google::Home::Graph.new(version: :v1)
          #
          #   # TODO: Initialize `agent_user_id`:
          #   agent_user_id = ''
          #   response = home_graph_api_client.request_sync_devices(agent_user_id)

          def request_sync_devices \
              agent_user_id,
              async: nil,
              options: nil,
              &block
            req = {
              agent_user_id: agent_user_id,
              async: async
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Home::Graph::V1::RequestSyncDevicesRequest)
            @request_sync_devices.call(req, options, &block)
          end

          # Reports device state and optionally sends device notifications.
          # Called by your smart home Action when the state of a third-party device
          # changes or you need to send a notification about the device.
          # See [Implement Report
          # State](https://developers.google.com/assistant/smarthome/develop/report-state)
          # for more information.
          #
          # This method updates the device state according to its declared
          # [traits](https://developers.google.com/assistant/smarthome/concepts/devices-traits).
          # Publishing a new state value outside of these traits will result in an
          # `INVALID_ARGUMENT` error response.
          #
          # The third-party user's identity is passed in via the `agent_user_id`
          # (see
          # {Google::Home::Graph::V1::ReportStateAndNotificationRequest ReportStateAndNotificationRequest}).
          # This request must be authorized using service account credentials from your
          # Actions console project.
          #
          # @param agent_user_id [String]
          #   Required. Third-party user ID.
          # @param payload [Google::Home::Graph::V1::StateAndNotificationPayload | Hash]
          #   Required. State of devices to update and notification metadata for devices.
          #   A hash of the same form as `Google::Home::Graph::V1::StateAndNotificationPayload`
          #   can also be provided.
          # @param request_id [String]
          #   Request ID used for debugging.
          # @param event_id [String]
          #   Unique identifier per event (for example, a doorbell press).
          # @param follow_up_token [String]
          #   Deprecated.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Home::Graph::V1::ReportStateAndNotificationResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Home::Graph::V1::ReportStateAndNotificationResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/home/graph"
          #
          #   home_graph_api_client = Google::Home::Graph.new(version: :v1)
          #
          #   # TODO: Initialize `agent_user_id`:
          #   agent_user_id = ''
          #
          #   # TODO: Initialize `payload`:
          #   payload = {}
          #   response = home_graph_api_client.report_state_and_notification(agent_user_id, payload)

          def report_state_and_notification \
              agent_user_id,
              payload,
              request_id: nil,
              event_id: nil,
              follow_up_token: nil,
              options: nil,
              &block
            req = {
              agent_user_id: agent_user_id,
              payload: payload,
              request_id: request_id,
              event_id: event_id,
              follow_up_token: follow_up_token
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Home::Graph::V1::ReportStateAndNotificationRequest)
            @report_state_and_notification.call(req, options, &block)
          end

          # Unlinks the given third-party user from your smart home Action.
          # All data related to this user will be deleted.
          #
          # For more details on how users link their accounts, see
          # [fulfillment and
          # authentication](https://developers.google.com/assistant/smarthome/concepts/fulfillment-authentication).
          #
          # The third-party user's identity is passed in via the `agent_user_id`
          # (see
          # {Google::Home::Graph::V1::DeleteAgentUserRequest DeleteAgentUserRequest}).
          # This request must be authorized using service account credentials from your
          # Actions console project.
          #
          # @param agent_user_id [String]
          #   Required. Third-party user ID.
          # @param request_id [String]
          #   Request ID used for debugging.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/home/graph"
          #
          #   home_graph_api_client = Google::Home::Graph.new(version: :v1)
          #   formatted_agent_user_id = Google::Home::Graph::V1::HomeGraphApiServiceClient.agent_user_path_path("[AGENT_USER_PATH]")
          #   home_graph_api_client.delete_agent_user(formatted_agent_user_id)

          def delete_agent_user \
              agent_user_id,
              request_id: nil,
              options: nil,
              &block
            req = {
              agent_user_id: agent_user_id,
              request_id: request_id
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Home::Graph::V1::DeleteAgentUserRequest)
            @delete_agent_user.call(req, options, &block)
            nil
          end

          # Gets the current states in Home Graph for the given set of the third-party
          # user's devices.
          #
          # The third-party user's identity is passed in via the `agent_user_id`
          # (see {Google::Home::Graph::V1::QueryRequest QueryRequest}).
          # This request must be authorized using service account credentials from your
          # Actions console project.
          #
          # @param agent_user_id [String]
          #   Required. Third-party user ID.
          # @param inputs [Array<Google::Home::Graph::V1::QueryRequestInput | Hash>]
          #   Required. Inputs containing third-party device IDs for which to
          #   get the device states.
          #   A hash of the same form as `Google::Home::Graph::V1::QueryRequestInput`
          #   can also be provided.
          # @param request_id [String]
          #   Request ID used for debugging.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Home::Graph::V1::QueryResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Home::Graph::V1::QueryResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/home/graph"
          #
          #   home_graph_api_client = Google::Home::Graph.new(version: :v1)
          #
          #   # TODO: Initialize `agent_user_id`:
          #   agent_user_id = ''
          #
          #   # TODO: Initialize `inputs`:
          #   inputs = []
          #   response = home_graph_api_client.query(agent_user_id, inputs)

          def query \
              agent_user_id,
              inputs,
              request_id: nil,
              options: nil,
              &block
            req = {
              agent_user_id: agent_user_id,
              inputs: inputs,
              request_id: request_id
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Home::Graph::V1::QueryRequest)
            @query.call(req, options, &block)
          end

          # Gets all the devices associated with the given third-party user.
          #
          # The third-party user's identity is passed in via the `agent_user_id`
          # (see {Google::Home::Graph::V1::SyncRequest SyncRequest}).
          # This request must be authorized using service account credentials from your
          # Actions console project.
          #
          # @param agent_user_id [String]
          #   Required. Third-party user ID.
          # @param request_id [String]
          #   Request ID used for debugging.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Home::Graph::V1::SyncResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Home::Graph::V1::SyncResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/home/graph"
          #
          #   home_graph_api_client = Google::Home::Graph.new(version: :v1)
          #
          #   # TODO: Initialize `agent_user_id`:
          #   agent_user_id = ''
          #   response = home_graph_api_client.sync(agent_user_id)

          def sync \
              agent_user_id,
              request_id: nil,
              options: nil,
              &block
            req = {
              agent_user_id: agent_user_id,
              request_id: request_id
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Home::Graph::V1::SyncRequest)
            @sync.call(req, options, &block)
          end
        end
      end
    end
  end
end
