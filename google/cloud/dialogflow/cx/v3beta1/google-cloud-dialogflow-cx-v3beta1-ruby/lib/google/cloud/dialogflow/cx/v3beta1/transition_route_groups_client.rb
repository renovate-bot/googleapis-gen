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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/dialogflow/cx/v3beta1/transition_route_group.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/dialogflow/cx/v3beta1/transition_route_group_pb"
require "google/cloud/dialogflow/cx/v3beta1/credentials"

module Google
  module Cloud
    module Dialogflow
      module Cx
        module V3beta1
          # Service for managing {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup TransitionRouteGroups}.
          #
          # @!attribute [r] transition_route_groups_stub
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroups::Stub]
          class TransitionRouteGroupsClient
            attr_reader :transition_route_groups_stub

            # The default address of the service.
            SERVICE_ADDRESS = "dialogflow.googleapis.com".freeze

            # The default port of the service.
            DEFAULT_SERVICE_PORT = 443

            # The default set of gRPC interceptors.
            GRPC_INTERCEPTORS = []

            DEFAULT_TIMEOUT = 30

            PAGE_DESCRIPTORS = {
              "list_transition_route_groups" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "transition_route_groups")
            }.freeze

            private_constant :PAGE_DESCRIPTORS

            # The scopes needed to make gRPC calls to all of the methods defined in
            # this service.
            ALL_SCOPES = [
              "https://www.googleapis.com/auth/cloud-platform",
              "https://www.googleapis.com/auth/dialogflow"
            ].freeze


            FLOW_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}/agents/{agent}/flows/{flow}"
            )

            private_constant :FLOW_PATH_TEMPLATE

            TRANSITION_ROUTE_GROUP_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/transitionRouteGroups/{transition_route_group}"
            )

            private_constant :TRANSITION_ROUTE_GROUP_PATH_TEMPLATE

            # Returns a fully-qualified flow resource name string.
            # @param project [String]
            # @param location [String]
            # @param agent [String]
            # @param flow [String]
            # @return [String]
            def self.flow_path project, location, agent, flow
              FLOW_PATH_TEMPLATE.render(
                :"project" => project,
                :"location" => location,
                :"agent" => agent,
                :"flow" => flow
              )
            end

            # Returns a fully-qualified transition_route_group resource name string.
            # @param project [String]
            # @param location [String]
            # @param agent [String]
            # @param flow [String]
            # @param transition_route_group [String]
            # @return [String]
            def self.transition_route_group_path project, location, agent, flow, transition_route_group
              TRANSITION_ROUTE_GROUP_PATH_TEMPLATE.render(
                :"project" => project,
                :"location" => location,
                :"agent" => agent,
                :"flow" => flow,
                :"transition_route_group" => transition_route_group
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
              require "google/cloud/dialogflow/cx/v3beta1/transition_route_group_services_pb"

              credentials ||= Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.default

              if credentials.is_a?(String) || credentials.is_a?(Hash)
                updater_proc = Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.new(credentials).updater_proc
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

              package_version = Gem.loaded_specs['google-cloud-dialogflow-cx'].version.version

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
                "transition_route_groups_client_config.json"
              )
              defaults = client_config_file.open do |f|
                Google::Gax.construct_settings(
                  "google.cloud.dialogflow.cx.v3beta1.TransitionRouteGroups",
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
              @transition_route_groups_stub = Google::Gax::Grpc.create_stub(
                service_path,
                port,
                chan_creds: chan_creds,
                channel: channel,
                updater_proc: updater_proc,
                scopes: scopes,
                interceptors: interceptors,
                &Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroups::Stub.method(:new)
              )

              @list_transition_route_groups = Google::Gax.create_api_call(
                @transition_route_groups_stub.method(:list_transition_route_groups),
                defaults["list_transition_route_groups"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @get_transition_route_group = Google::Gax.create_api_call(
                @transition_route_groups_stub.method(:get_transition_route_group),
                defaults["get_transition_route_group"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @create_transition_route_group = Google::Gax.create_api_call(
                @transition_route_groups_stub.method(:create_transition_route_group),
                defaults["create_transition_route_group"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @update_transition_route_group = Google::Gax.create_api_call(
                @transition_route_groups_stub.method(:update_transition_route_group),
                defaults["update_transition_route_group"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'transition_route_group.name' => request.transition_route_group.name}
                end
              )
              @delete_transition_route_group = Google::Gax.create_api_call(
                @transition_route_groups_stub.method(:delete_transition_route_group),
                defaults["delete_transition_route_group"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
            end

            # Service calls

            # Returns the list of all transition route groups in the specified flow.
            #
            # @param parent [String]
            #   Required. The flow to list all transition route groups for.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
            #   ID>/flows/<Flow ID>`.
            # @param page_size [Integer]
            #   The maximum number of resources contained in the underlying API
            #   response. If page streaming is performed per-resource, this
            #   parameter does not affect the return value. If page streaming is
            #   performed per-page, this determines the maximum number of
            #   resources in a page.
            # @param language_code [String]
            #   The language to list transition route groups for. The field
            #   {TransitionRoute#trigger_fulfillment#messages `messages`} in
            #   {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRoute TransitionRoute} is language dependent.
            #
            #   If not specified, the agent's default language is used.
            #   [Many
            #   languages](https://cloud.google.com/dialogflow/cx/docs/reference/language)
            #   are supported.
            #   Note: languages must be enabled in the agent before they can be used.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup>]
            #   An enumerable of Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   transition_route_groups_client = Google::Cloud::Dialogflow::Cx::TransitionRouteGroups.new(version: :v3beta1)
            #   formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroupsClient.flow_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")
            #
            #   # Iterate over all results.
            #   transition_route_groups_client.list_transition_route_groups(formatted_parent).each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   transition_route_groups_client.list_transition_route_groups(formatted_parent).each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_transition_route_groups \
                parent,
                page_size: nil,
                language_code: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                page_size: page_size,
                language_code: language_code
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3beta1::ListTransitionRouteGroupsRequest)
              @list_transition_route_groups.call(req, options, &block)
            end

            # Retrieves the specified {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup TransitionRouteGroup}.
            #
            # @param name [String]
            #   Required. The name of the {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup TransitionRouteGroup}.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
            #   ID>/flows/<Flow ID>/transitionRouteGroups/<Transition Route Group ID>`.
            # @param language_code [String]
            #   The language to list transition route groups for. The field
            #   {TransitionRoute#trigger_fulfillment#messages `messages`} in
            #   {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRoute TransitionRoute} is language dependent.
            #
            #   If not specified, the agent's default language is used.
            #   [Many
            #   languages](https://cloud.google.com/dialogflow/cx/docs/reference/language)
            #   are supported.
            #   Note: languages must be enabled in the agent before they can be used.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   transition_route_groups_client = Google::Cloud::Dialogflow::Cx::TransitionRouteGroups.new(version: :v3beta1)
            #   formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroupsClient.transition_route_group_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]")
            #   response = transition_route_groups_client.get_transition_route_group(formatted_name)

            def get_transition_route_group \
                name,
                language_code: nil,
                options: nil,
                &block
              req = {
                name: name,
                language_code: language_code
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3beta1::GetTransitionRouteGroupRequest)
              @get_transition_route_group.call(req, options, &block)
            end

            # Creates an {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup TransitionRouteGroup} in the specified flow.
            #
            # @param parent [String]
            #   Required. The flow to create an {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup TransitionRouteGroup} for.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
            #   ID>/flows/<Flow ID>`.
            # @param transition_route_group [Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup | Hash]
            #   Required. The transition route group to create.
            #   A hash of the same form as `Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup`
            #   can also be provided.
            # @param language_code [String]
            #   The language to list transition route groups for. The field
            #   {TransitionRoute#trigger_fulfillment#messages `messages`} in
            #   {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRoute TransitionRoute} is language dependent.
            #
            #   If not specified, the agent's default language is used.
            #   [Many
            #   languages](https://cloud.google.com/dialogflow/cx/docs/reference/language)
            #   are supported.
            #   Note: languages must be enabled in the agent before they can be used.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   transition_route_groups_client = Google::Cloud::Dialogflow::Cx::TransitionRouteGroups.new(version: :v3beta1)
            #   formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroupsClient.flow_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")
            #
            #   # TODO: Initialize `transition_route_group`:
            #   transition_route_group = {}
            #   response = transition_route_groups_client.create_transition_route_group(formatted_parent, transition_route_group)

            def create_transition_route_group \
                parent,
                transition_route_group,
                language_code: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                transition_route_group: transition_route_group,
                language_code: language_code
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3beta1::CreateTransitionRouteGroupRequest)
              @create_transition_route_group.call(req, options, &block)
            end

            # Updates the specified {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup TransitionRouteGroup}.
            #
            # @param transition_route_group [Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup | Hash]
            #   Required. The transition route group to update.
            #   A hash of the same form as `Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup`
            #   can also be provided.
            # @param update_mask [Google::Protobuf::FieldMask | Hash]
            #   The mask to control which fields get updated.
            #   A hash of the same form as `Google::Protobuf::FieldMask`
            #   can also be provided.
            # @param language_code [String]
            #   The language to list transition route groups for. The field
            #   {TransitionRoute#trigger_fulfillment#messages `messages`} in
            #   {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRoute TransitionRoute} is language dependent.
            #
            #   If not specified, the agent's default language is used.
            #   [Many
            #   languages](https://cloud.google.com/dialogflow/cx/docs/reference/language)
            #   are supported.
            #   Note: languages must be enabled in the agent before they can be used.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   transition_route_groups_client = Google::Cloud::Dialogflow::Cx::TransitionRouteGroups.new(version: :v3beta1)
            #
            #   # TODO: Initialize `transition_route_group`:
            #   transition_route_group = {}
            #   response = transition_route_groups_client.update_transition_route_group(transition_route_group)

            def update_transition_route_group \
                transition_route_group,
                update_mask: nil,
                language_code: nil,
                options: nil,
                &block
              req = {
                transition_route_group: transition_route_group,
                update_mask: update_mask,
                language_code: language_code
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3beta1::UpdateTransitionRouteGroupRequest)
              @update_transition_route_group.call(req, options, &block)
            end

            # Deletes the specified {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup TransitionRouteGroup}.
            #
            # @param name [String]
            #   Required. The name of the {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup TransitionRouteGroup} to delete.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
            #   ID>/flows/<Flow ID>/transitionRouteGroups/<Transition Route Group ID>`.
            # @param force [true, false]
            #   This field has no effect for transition route group that no page is using.
            #   If the transition route group is referenced by any page:
            #
            #   * If `force` is set to false, an error will be returned with message
            #     indicating pages that reference the transition route group.
            #   * If `force` is set to true, Dialogflow will remove the transition route
            #     group, as well as any reference to it.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result []
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   transition_route_groups_client = Google::Cloud::Dialogflow::Cx::TransitionRouteGroups.new(version: :v3beta1)
            #   formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroupsClient.transition_route_group_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]")
            #   transition_route_groups_client.delete_transition_route_group(formatted_name)

            def delete_transition_route_group \
                name,
                force: nil,
                options: nil,
                &block
              req = {
                name: name,
                force: force
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3beta1::DeleteTransitionRouteGroupRequest)
              @delete_transition_route_group.call(req, options, &block)
              nil
            end
          end
        end
      end
    end
  end
end
