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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/networkconnectivity/v1alpha1/hub.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"
require "google/gax/operation"
require "google/longrunning/operations_client"

require "google/cloud/networkconnectivity/v1alpha1/hub_pb"
require "google/cloud/network_connectivity/v1alpha1/credentials"

module Google
  module Cloud
    module NetworkConnectivity
      module V1alpha1
        # Network Connectivity Center is a hub-and-spoke abstraction for
        # network connectivity management in Google Cloud. It reduces
        # operational complexity through a simple, centralized connectivity management
        # model.
        #
        # @!attribute [r] hub_service_stub
        #   @return [Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub]
        class HubServiceClient
          attr_reader :hub_service_stub

          # The default address of the service.
          SERVICE_ADDRESS = "networkconnectivity.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_hubs" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "hubs"),
            "list_spokes" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "spokes")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform"
          ].freeze

          class OperationsClient < Google::Longrunning::OperationsClient
            self::SERVICE_ADDRESS = HubServiceClient::SERVICE_ADDRESS
            self::GRPC_INTERCEPTORS = HubServiceClient::GRPC_INTERCEPTORS
          end

          HUB_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/global/hubs/{hub}"
          )

          private_constant :HUB_PATH_TEMPLATE

          INTERCONNECT_ATTACHMENT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/regions/{region}/interconnectAttachments/{resource_id}"
          )

          private_constant :INTERCONNECT_ATTACHMENT_PATH_TEMPLATE

          LOCATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}"
          )

          private_constant :LOCATION_PATH_TEMPLATE

          SPOKE_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/spokes/{spoke}"
          )

          private_constant :SPOKE_PATH_TEMPLATE

          VPN_TUNNEL_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/regions/{region}/vpnTunnels/{resource_id}"
          )

          private_constant :VPN_TUNNEL_PATH_TEMPLATE

          # Returns a fully-qualified hub resource name string.
          # @param project [String]
          # @param hub [String]
          # @return [String]
          def self.hub_path project, hub
            HUB_PATH_TEMPLATE.render(
              :"project" => project,
              :"hub" => hub
            )
          end

          # Returns a fully-qualified interconnect_attachment resource name string.
          # @param project [String]
          # @param region [String]
          # @param resource_id [String]
          # @return [String]
          def self.interconnect_attachment_path project, region, resource_id
            INTERCONNECT_ATTACHMENT_PATH_TEMPLATE.render(
              :"project" => project,
              :"region" => region,
              :"resource_id" => resource_id
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

          # Returns a fully-qualified spoke resource name string.
          # @param project [String]
          # @param location [String]
          # @param spoke [String]
          # @return [String]
          def self.spoke_path project, location, spoke
            SPOKE_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"spoke" => spoke
            )
          end

          # Returns a fully-qualified vpn_tunnel resource name string.
          # @param project [String]
          # @param region [String]
          # @param resource_id [String]
          # @return [String]
          def self.vpn_tunnel_path project, region, resource_id
            VPN_TUNNEL_PATH_TEMPLATE.render(
              :"project" => project,
              :"region" => region,
              :"resource_id" => resource_id
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
            require "google/cloud/networkconnectivity/v1alpha1/hub_services_pb"

            credentials ||= Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.default

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
              updater_proc = Google::Cloud::NetworkConnectivity::V1alpha1::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-cloud-network_connectivity'].version.version

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
              "hub_service_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.networkconnectivity.v1alpha1.HubService",
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
            @hub_service_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Networkconnectivity::V1alpha1::HubService::Stub.method(:new)
            )

            @list_hubs = Google::Gax.create_api_call(
              @hub_service_stub.method(:list_hubs),
              defaults["list_hubs"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_hub = Google::Gax.create_api_call(
              @hub_service_stub.method(:get_hub),
              defaults["get_hub"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @create_hub = Google::Gax.create_api_call(
              @hub_service_stub.method(:create_hub),
              defaults["create_hub"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @update_hub = Google::Gax.create_api_call(
              @hub_service_stub.method(:update_hub),
              defaults["update_hub"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'hub.name' => request.hub.name}
              end
            )
            @delete_hub = Google::Gax.create_api_call(
              @hub_service_stub.method(:delete_hub),
              defaults["delete_hub"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_spokes = Google::Gax.create_api_call(
              @hub_service_stub.method(:list_spokes),
              defaults["list_spokes"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_spoke = Google::Gax.create_api_call(
              @hub_service_stub.method(:get_spoke),
              defaults["get_spoke"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @create_spoke = Google::Gax.create_api_call(
              @hub_service_stub.method(:create_spoke),
              defaults["create_spoke"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @update_spoke = Google::Gax.create_api_call(
              @hub_service_stub.method(:update_spoke),
              defaults["update_spoke"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'spoke.name' => request.spoke.name}
              end
            )
            @delete_spoke = Google::Gax.create_api_call(
              @hub_service_stub.method(:delete_spoke),
              defaults["delete_spoke"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
          end

          # Service calls

          # Lists Hubs in a given project and location.
          #
          # @param parent [String]
          #   Required. The parent resource's name.
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param filter [String]
          #   A filter expression that filters the results listed in the response.
          # @param order_by [String]
          #   Sort the results by a certain order.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Networkconnectivity::V1alpha1::Hub>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Networkconnectivity::V1alpha1::Hub>]
          #   An enumerable of Google::Cloud::Networkconnectivity::V1alpha1::Hub instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/network_connectivity"
          #
          #   hub_client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)
          #   formatted_parent = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # Iterate over all results.
          #   hub_client.list_hubs(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   hub_client.list_hubs(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_hubs \
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
            req = Google::Gax::to_proto(req, Google::Cloud::Networkconnectivity::V1alpha1::ListHubsRequest)
            @list_hubs.call(req, options, &block)
          end

          # Gets details of a single Hub.
          #
          # @param name [String]
          #   Required. Name of the Hub resource to get.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Networkconnectivity::V1alpha1::Hub]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Networkconnectivity::V1alpha1::Hub]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/network_connectivity"
          #
          #   hub_client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)
          #   formatted_name = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.hub_path("[PROJECT]", "[HUB]")
          #   response = hub_client.get_hub(formatted_name)

          def get_hub \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Networkconnectivity::V1alpha1::GetHubRequest)
            @get_hub.call(req, options, &block)
          end

          # Creates a new Hub in a given project and location.
          #
          # @param parent [String]
          #   Required. The parent resource's name of the Hub.
          # @param hub [Google::Cloud::Networkconnectivity::V1alpha1::Hub | Hash]
          #   Required. Initial values for a new Hub.
          #   A hash of the same form as `Google::Cloud::Networkconnectivity::V1alpha1::Hub`
          #   can also be provided.
          # @param hub_id [String]
          #   Optional. Unique id for the Hub to create.
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
          #   require "google/cloud/network_connectivity"
          #
          #   hub_client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)
          #   formatted_parent = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # TODO: Initialize `hub`:
          #   hub = {}
          #
          #   # Register a callback during the method call.
          #   operation = hub_client.create_hub(formatted_parent, hub) do |op|
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

          def create_hub \
              parent,
              hub,
              hub_id: nil,
              request_id: nil,
              options: nil
            req = {
              parent: parent,
              hub: hub,
              hub_id: hub_id,
              request_id: request_id
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Networkconnectivity::V1alpha1::CreateHubRequest)
            operation = Google::Gax::Operation.new(
              @create_hub.call(req, options),
              @operations_client,
              Google::Cloud::Networkconnectivity::V1alpha1::Hub,
              Google::Cloud::Networkconnectivity::V1alpha1::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Updates the parameters of a single Hub.
          #
          # @param hub [Google::Cloud::Networkconnectivity::V1alpha1::Hub | Hash]
          #   Required. The state that the Hub should be in after the update.
          #   A hash of the same form as `Google::Cloud::Networkconnectivity::V1alpha1::Hub`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Optional. Field mask is used to specify the fields to be overwritten in the
          #   Hub resource by the update.
          #   The fields specified in the update_mask are relative to the resource, not
          #   the full request. A field will be overwritten if it is in the mask. If the
          #   user does not provide a mask then all fields will be overwritten.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
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
          #   require "google/cloud/network_connectivity"
          #
          #   hub_client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)
          #
          #   # TODO: Initialize `hub`:
          #   hub = {}
          #
          #   # Register a callback during the method call.
          #   operation = hub_client.update_hub(hub) do |op|
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

          def update_hub \
              hub,
              update_mask: nil,
              request_id: nil,
              options: nil
            req = {
              hub: hub,
              update_mask: update_mask,
              request_id: request_id
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Networkconnectivity::V1alpha1::UpdateHubRequest)
            operation = Google::Gax::Operation.new(
              @update_hub.call(req, options),
              @operations_client,
              Google::Cloud::Networkconnectivity::V1alpha1::Hub,
              Google::Cloud::Networkconnectivity::V1alpha1::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Deletes a single Hub.
          #
          # @param name [String]
          #   Required. The name of the Hub to delete.
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
          #   require "google/cloud/network_connectivity"
          #
          #   hub_client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)
          #   formatted_name = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.hub_path("[PROJECT]", "[HUB]")
          #
          #   # Register a callback during the method call.
          #   operation = hub_client.delete_hub(formatted_name) do |op|
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

          def delete_hub \
              name,
              request_id: nil,
              options: nil
            req = {
              name: name,
              request_id: request_id
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Networkconnectivity::V1alpha1::DeleteHubRequest)
            operation = Google::Gax::Operation.new(
              @delete_hub.call(req, options),
              @operations_client,
              Google::Protobuf::Empty,
              Google::Cloud::Networkconnectivity::V1alpha1::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Lists Spokes in a given project and location.
          #
          # @param parent [String]
          #   Required. The parent's resource name.
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param filter [String]
          #   A filter expression that filters the results listed in the response.
          # @param order_by [String]
          #   Sort the results by a certain order.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Networkconnectivity::V1alpha1::Spoke>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Networkconnectivity::V1alpha1::Spoke>]
          #   An enumerable of Google::Cloud::Networkconnectivity::V1alpha1::Spoke instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/network_connectivity"
          #
          #   hub_client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)
          #   formatted_parent = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # Iterate over all results.
          #   hub_client.list_spokes(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   hub_client.list_spokes(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_spokes \
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
            req = Google::Gax::to_proto(req, Google::Cloud::Networkconnectivity::V1alpha1::ListSpokesRequest)
            @list_spokes.call(req, options, &block)
          end

          # Gets details of a single Spoke.
          #
          # @param name [String]
          #   Required. The name of Spoke resource.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Networkconnectivity::V1alpha1::Spoke]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Networkconnectivity::V1alpha1::Spoke]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/network_connectivity"
          #
          #   hub_client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)
          #   formatted_name = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.spoke_path("[PROJECT]", "[LOCATION]", "[SPOKE]")
          #   response = hub_client.get_spoke(formatted_name)

          def get_spoke \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Networkconnectivity::V1alpha1::GetSpokeRequest)
            @get_spoke.call(req, options, &block)
          end

          # Creates a new Spoke in a given project and location.
          #
          # @param parent [String]
          #   Required. The parent's resource name of the Spoke.
          # @param spoke [Google::Cloud::Networkconnectivity::V1alpha1::Spoke | Hash]
          #   Required. Initial values for a new Hub.
          #   A hash of the same form as `Google::Cloud::Networkconnectivity::V1alpha1::Spoke`
          #   can also be provided.
          # @param spoke_id [String]
          #   Optional. Unique id for the Spoke to create.
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
          #   require "google/cloud/network_connectivity"
          #
          #   hub_client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)
          #   formatted_parent = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # TODO: Initialize `spoke`:
          #   spoke = {}
          #
          #   # Register a callback during the method call.
          #   operation = hub_client.create_spoke(formatted_parent, spoke) do |op|
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

          def create_spoke \
              parent,
              spoke,
              spoke_id: nil,
              request_id: nil,
              options: nil
            req = {
              parent: parent,
              spoke: spoke,
              spoke_id: spoke_id,
              request_id: request_id
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Networkconnectivity::V1alpha1::CreateSpokeRequest)
            operation = Google::Gax::Operation.new(
              @create_spoke.call(req, options),
              @operations_client,
              Google::Cloud::Networkconnectivity::V1alpha1::Spoke,
              Google::Cloud::Networkconnectivity::V1alpha1::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Updates the parameters of a single Spoke.
          #
          # @param spoke [Google::Cloud::Networkconnectivity::V1alpha1::Spoke | Hash]
          #   Required. The state that the Spoke should be in after the update.
          #   A hash of the same form as `Google::Cloud::Networkconnectivity::V1alpha1::Spoke`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Optional. Field mask is used to specify the fields to be overwritten in the
          #   Spoke resource by the update.
          #   The fields specified in the update_mask are relative to the resource, not
          #   the full request. A field will be overwritten if it is in the mask. If the
          #   user does not provide a mask then all fields will be overwritten.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
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
          #   require "google/cloud/network_connectivity"
          #
          #   hub_client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)
          #
          #   # TODO: Initialize `spoke`:
          #   spoke = {}
          #
          #   # Register a callback during the method call.
          #   operation = hub_client.update_spoke(spoke) do |op|
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

          def update_spoke \
              spoke,
              update_mask: nil,
              request_id: nil,
              options: nil
            req = {
              spoke: spoke,
              update_mask: update_mask,
              request_id: request_id
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Networkconnectivity::V1alpha1::UpdateSpokeRequest)
            operation = Google::Gax::Operation.new(
              @update_spoke.call(req, options),
              @operations_client,
              Google::Cloud::Networkconnectivity::V1alpha1::Spoke,
              Google::Cloud::Networkconnectivity::V1alpha1::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Deletes a single Spoke.
          #
          # @param name [String]
          #   Required. The name of the Spoke to delete.
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
          #   require "google/cloud/network_connectivity"
          #
          #   hub_client = Google::Cloud::NetworkConnectivity.new(version: :v1alpha1)
          #   formatted_name = Google::Cloud::NetworkConnectivity::V1alpha1::HubServiceClient.spoke_path("[PROJECT]", "[LOCATION]", "[SPOKE]")
          #
          #   # Register a callback during the method call.
          #   operation = hub_client.delete_spoke(formatted_name) do |op|
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

          def delete_spoke \
              name,
              request_id: nil,
              options: nil
            req = {
              name: name,
              request_id: request_id
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Networkconnectivity::V1alpha1::DeleteSpokeRequest)
            operation = Google::Gax::Operation.new(
              @delete_spoke.call(req, options),
              @operations_client,
              Google::Protobuf::Empty,
              Google::Cloud::Networkconnectivity::V1alpha1::OperationMetadata,
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
