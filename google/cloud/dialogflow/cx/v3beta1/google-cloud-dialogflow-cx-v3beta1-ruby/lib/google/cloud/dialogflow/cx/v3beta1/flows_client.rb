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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/dialogflow/cx/v3beta1/flow.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"
require "google/gax/operation"
require "google/longrunning/operations_client"

require "google/cloud/dialogflow/cx/v3beta1/flow_pb"
require "google/cloud/dialogflow/cx/v3beta1/credentials"

module Google
  module Cloud
    module Dialogflow
      module Cx
        module V3beta1
          # Service for managing {Google::Cloud::Dialogflow::Cx::V3beta1::Flow Flows}.
          #
          # @!attribute [r] flows_stub
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Flows::Stub]
          class FlowsClient
            attr_reader :flows_stub

            # The default address of the service.
            SERVICE_ADDRESS = "dialogflow.googleapis.com".freeze

            # The default port of the service.
            DEFAULT_SERVICE_PORT = 443

            # The default set of gRPC interceptors.
            GRPC_INTERCEPTORS = []

            DEFAULT_TIMEOUT = 30

            PAGE_DESCRIPTORS = {
              "list_flows" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "flows")
            }.freeze

            private_constant :PAGE_DESCRIPTORS

            # The scopes needed to make gRPC calls to all of the methods defined in
            # this service.
            ALL_SCOPES = [
              "https://www.googleapis.com/auth/cloud-platform",
              "https://www.googleapis.com/auth/dialogflow"
            ].freeze

            class OperationsClient < Google::Longrunning::OperationsClient
              self::SERVICE_ADDRESS = FlowsClient::SERVICE_ADDRESS
              self::GRPC_INTERCEPTORS = FlowsClient::GRPC_INTERCEPTORS
            end

            AGENT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}/agents/{agent}"
            )

            private_constant :AGENT_PATH_TEMPLATE

            FLOW_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}/agents/{agent}/flows/{flow}"
            )

            private_constant :FLOW_PATH_TEMPLATE

            FLOW_VALIDATION_RESULT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/validationResult"
            )

            private_constant :FLOW_VALIDATION_RESULT_PATH_TEMPLATE

            # Returns a fully-qualified agent resource name string.
            # @param project [String]
            # @param location [String]
            # @param agent [String]
            # @return [String]
            def self.agent_path project, location, agent
              AGENT_PATH_TEMPLATE.render(
                :"project" => project,
                :"location" => location,
                :"agent" => agent
              )
            end

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

            # Returns a fully-qualified flow_validation_result resource name string.
            # @param project [String]
            # @param location [String]
            # @param agent [String]
            # @param flow [String]
            # @return [String]
            def self.flow_validation_result_path project, location, agent, flow
              FLOW_VALIDATION_RESULT_PATH_TEMPLATE.render(
                :"project" => project,
                :"location" => location,
                :"agent" => agent,
                :"flow" => flow
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
              require "google/cloud/dialogflow/cx/v3beta1/flow_services_pb"

              credentials ||= Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.default

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
                "flows_client_config.json"
              )
              defaults = client_config_file.open do |f|
                Google::Gax.construct_settings(
                  "google.cloud.dialogflow.cx.v3beta1.Flows",
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
              @flows_stub = Google::Gax::Grpc.create_stub(
                service_path,
                port,
                chan_creds: chan_creds,
                channel: channel,
                updater_proc: updater_proc,
                scopes: scopes,
                interceptors: interceptors,
                &Google::Cloud::Dialogflow::Cx::V3beta1::Flows::Stub.method(:new)
              )

              @create_flow = Google::Gax.create_api_call(
                @flows_stub.method(:create_flow),
                defaults["create_flow"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @delete_flow = Google::Gax.create_api_call(
                @flows_stub.method(:delete_flow),
                defaults["delete_flow"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @list_flows = Google::Gax.create_api_call(
                @flows_stub.method(:list_flows),
                defaults["list_flows"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @get_flow = Google::Gax.create_api_call(
                @flows_stub.method(:get_flow),
                defaults["get_flow"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @update_flow = Google::Gax.create_api_call(
                @flows_stub.method(:update_flow),
                defaults["update_flow"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'flow.name' => request.flow.name}
                end
              )
              @train_flow = Google::Gax.create_api_call(
                @flows_stub.method(:train_flow),
                defaults["train_flow"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @validate_flow = Google::Gax.create_api_call(
                @flows_stub.method(:validate_flow),
                defaults["validate_flow"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @get_flow_validation_result = Google::Gax.create_api_call(
                @flows_stub.method(:get_flow_validation_result),
                defaults["get_flow_validation_result"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
            end

            # Service calls

            # Creates a flow in the specified agent.
            #
            # @param parent [String]
            #   Required. The agent to create a flow for.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
            # @param flow [Google::Cloud::Dialogflow::Cx::V3beta1::Flow | Hash]
            #   Required. The flow to create.
            #   A hash of the same form as `Google::Cloud::Dialogflow::Cx::V3beta1::Flow`
            #   can also be provided.
            # @param language_code [String]
            #   The language of the following fields in `flow`:
            #
            #   * `Flow.event_handlers.trigger_fulfillment.messages`
            #   * `Flow.transition_routes.trigger_fulfillment.messages`
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
            # @yieldparam result [Google::Cloud::Dialogflow::Cx::V3beta1::Flow]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Dialogflow::Cx::V3beta1::Flow]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   flows_client = Google::Cloud::Dialogflow::Cx::Flows.new(version: :v3beta1)
            #   formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::FlowsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
            #
            #   # TODO: Initialize `flow`:
            #   flow = {}
            #   response = flows_client.create_flow(formatted_parent, flow)

            def create_flow \
                parent,
                flow,
                language_code: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                flow: flow,
                language_code: language_code
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3beta1::CreateFlowRequest)
              @create_flow.call(req, options, &block)
            end

            # Deletes a specified flow.
            #
            # @param name [String]
            #   Required. The name of the flow to delete.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
            #   ID>/flows/<Flow ID>`.
            # @param force [true, false]
            #   This field has no effect for flows with no incoming transitions.
            #   For flows with incoming transitions:
            #
            #   * If `force` is set to false, an error will be returned with message
            #     indicating the incoming transitions.
            #   * If `force` is set to true, Dialogflow will remove the flow, as well as
            #     any transitions to the flow (i.e. [Target
            #     flow][EventHandler.target_flow] in event handlers or [Target
            #     flow][TransitionRoute.target_flow] in transition routes that point to
            #     this flow will be cleared).
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
            #   flows_client = Google::Cloud::Dialogflow::Cx::Flows.new(version: :v3beta1)
            #   formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::FlowsClient.flow_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")
            #   flows_client.delete_flow(formatted_name)

            def delete_flow \
                name,
                force: nil,
                options: nil,
                &block
              req = {
                name: name,
                force: force
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3beta1::DeleteFlowRequest)
              @delete_flow.call(req, options, &block)
              nil
            end

            # Returns the list of all flows in the specified agent.
            #
            # @param parent [String]
            #   Required. The agent containing the flows.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
            # @param page_size [Integer]
            #   The maximum number of resources contained in the underlying API
            #   response. If page streaming is performed per-resource, this
            #   parameter does not affect the return value. If page streaming is
            #   performed per-page, this determines the maximum number of
            #   resources in a page.
            # @param language_code [String]
            #   The language to list flows for. The following fields are language
            #   dependent:
            #
            #   * `Flow.event_handlers.trigger_fulfillment.messages`
            #   * `Flow.transition_routes.trigger_fulfillment.messages`
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
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::Cx::V3beta1::Flow>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::Cx::V3beta1::Flow>]
            #   An enumerable of Google::Cloud::Dialogflow::Cx::V3beta1::Flow instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   flows_client = Google::Cloud::Dialogflow::Cx::Flows.new(version: :v3beta1)
            #   formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::FlowsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
            #
            #   # Iterate over all results.
            #   flows_client.list_flows(formatted_parent).each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   flows_client.list_flows(formatted_parent).each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_flows \
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
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3beta1::ListFlowsRequest)
              @list_flows.call(req, options, &block)
            end

            # Retrieves the specified flow.
            #
            # @param name [String]
            #   Required. The name of the flow to get.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
            #   ID>/flows/<Flow ID>`.
            # @param language_code [String]
            #   The language to retrieve the flow for. The following fields are language
            #   dependent:
            #
            #   * `Flow.event_handlers.trigger_fulfillment.messages`
            #   * `Flow.transition_routes.trigger_fulfillment.messages`
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
            # @yieldparam result [Google::Cloud::Dialogflow::Cx::V3beta1::Flow]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Dialogflow::Cx::V3beta1::Flow]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   flows_client = Google::Cloud::Dialogflow::Cx::Flows.new(version: :v3beta1)
            #   formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::FlowsClient.flow_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")
            #   response = flows_client.get_flow(formatted_name)

            def get_flow \
                name,
                language_code: nil,
                options: nil,
                &block
              req = {
                name: name,
                language_code: language_code
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3beta1::GetFlowRequest)
              @get_flow.call(req, options, &block)
            end

            # Updates the specified flow.
            #
            # @param flow [Google::Cloud::Dialogflow::Cx::V3beta1::Flow | Hash]
            #   Required. The flow to update.
            #   A hash of the same form as `Google::Cloud::Dialogflow::Cx::V3beta1::Flow`
            #   can also be provided.
            # @param update_mask [Google::Protobuf::FieldMask | Hash]
            #   Required. The mask to control which fields get updated. If `update_mask` is not
            #   specified, an error will be returned.
            #   A hash of the same form as `Google::Protobuf::FieldMask`
            #   can also be provided.
            # @param language_code [String]
            #   The language of the following fields in `flow`:
            #
            #   * `Flow.event_handlers.trigger_fulfillment.messages`
            #   * `Flow.transition_routes.trigger_fulfillment.messages`
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
            # @yieldparam result [Google::Cloud::Dialogflow::Cx::V3beta1::Flow]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Dialogflow::Cx::V3beta1::Flow]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   flows_client = Google::Cloud::Dialogflow::Cx::Flows.new(version: :v3beta1)
            #
            #   # TODO: Initialize `flow`:
            #   flow = {}
            #
            #   # TODO: Initialize `update_mask`:
            #   update_mask = {}
            #   response = flows_client.update_flow(flow, update_mask)

            def update_flow \
                flow,
                update_mask,
                language_code: nil,
                options: nil,
                &block
              req = {
                flow: flow,
                update_mask: update_mask,
                language_code: language_code
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3beta1::UpdateFlowRequest)
              @update_flow.call(req, options, &block)
            end

            # Trains the specified flow. Note that only the flow in 'draft' environment
            # is trained.
            #
            # @param name [String]
            #   Required. The flow to train.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
            #   ID>/flows/<Flow ID>`.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @return [Google::Gax::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   flows_client = Google::Cloud::Dialogflow::Cx::Flows.new(version: :v3beta1)
            #   formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::FlowsClient.flow_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")
            #
            #   # Register a callback during the method call.
            #   operation = flows_client.train_flow(formatted_name) do |op|
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

            def train_flow \
                name,
                options: nil
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3beta1::TrainFlowRequest)
              operation = Google::Gax::Operation.new(
                @train_flow.call(req, options),
                @operations_client,
                Google::Protobuf::Empty,
                Google::Protobuf::Struct,
                call_options: options
              )
              operation.on_done { |operation| yield(operation) } if block_given?
              operation
            end

            # Validates the specified flow and creates or updates validation results.
            # Please call this API after the training is completed to get the complete
            # validation results.
            #
            # @param name [String]
            #   Required. The flow to validate.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
            #   ID>/flows/<Flow ID>`.
            # @param language_code [String]
            #   If not specified, the agent's default language is used.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Dialogflow::Cx::V3beta1::FlowValidationResult]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Dialogflow::Cx::V3beta1::FlowValidationResult]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   flows_client = Google::Cloud::Dialogflow::Cx::Flows.new(version: :v3beta1)
            #   formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::FlowsClient.flow_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")
            #   response = flows_client.validate_flow(formatted_name)

            def validate_flow \
                name,
                language_code: nil,
                options: nil,
                &block
              req = {
                name: name,
                language_code: language_code
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3beta1::ValidateFlowRequest)
              @validate_flow.call(req, options, &block)
            end

            # Gets the latest flow validation result. Flow validation is performed
            # when ValidateFlow is called.
            #
            # @param name [String]
            #   Required. The flow name.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
            #   ID>/flows/<Flow ID>/validationResult`.
            # @param language_code [String]
            #   If not specified, the agent's default language is used.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Dialogflow::Cx::V3beta1::FlowValidationResult]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Dialogflow::Cx::V3beta1::FlowValidationResult]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   flows_client = Google::Cloud::Dialogflow::Cx::Flows.new(version: :v3beta1)
            #   formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::FlowsClient.flow_validation_result_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]")
            #   response = flows_client.get_flow_validation_result(formatted_name)

            def get_flow_validation_result \
                name,
                language_code: nil,
                options: nil,
                &block
              req = {
                name: name,
                language_code: language_code
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3beta1::GetFlowValidationResultRequest)
              @get_flow_validation_result.call(req, options, &block)
            end
          end
        end
      end
    end
  end
end
