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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/dialogflow/cx/v3/webhook.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/dialogflow/cx/v3/webhook_pb"
require "google/cloud/dialogflow/cx/v3/credentials"

module Google
  module Cloud
    module Dialogflow
      module Cx
        module V3
          # Service for managing {Google::Cloud::Dialogflow::Cx::V3::Webhook Webhooks}.
          #
          # @!attribute [r] webhooks_stub
          #   @return [Google::Cloud::Dialogflow::Cx::V3::Webhooks::Stub]
          class WebhooksClient
            attr_reader :webhooks_stub

            # The default address of the service.
            SERVICE_ADDRESS = "dialogflow.googleapis.com".freeze

            # The default port of the service.
            DEFAULT_SERVICE_PORT = 443

            # The default set of gRPC interceptors.
            GRPC_INTERCEPTORS = []

            DEFAULT_TIMEOUT = 30

            PAGE_DESCRIPTORS = {
              "list_webhooks" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "webhooks")
            }.freeze

            private_constant :PAGE_DESCRIPTORS

            # The scopes needed to make gRPC calls to all of the methods defined in
            # this service.
            ALL_SCOPES = [
              "https://www.googleapis.com/auth/cloud-platform",
              "https://www.googleapis.com/auth/dialogflow"
            ].freeze


            AGENT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}/agents/{agent}"
            )

            private_constant :AGENT_PATH_TEMPLATE

            WEBHOOK_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}/agents/{agent}/webhooks/{webhook}"
            )

            private_constant :WEBHOOK_PATH_TEMPLATE

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

            # Returns a fully-qualified webhook resource name string.
            # @param project [String]
            # @param location [String]
            # @param agent [String]
            # @param webhook [String]
            # @return [String]
            def self.webhook_path project, location, agent, webhook
              WEBHOOK_PATH_TEMPLATE.render(
                :"project" => project,
                :"location" => location,
                :"agent" => agent,
                :"webhook" => webhook
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
              require "google/cloud/dialogflow/cx/v3/webhook_services_pb"

              credentials ||= Google::Cloud::Dialogflow::Cx::V3::Credentials.default

              if credentials.is_a?(String) || credentials.is_a?(Hash)
                updater_proc = Google::Cloud::Dialogflow::Cx::V3::Credentials.new(credentials).updater_proc
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
                "webhooks_client_config.json"
              )
              defaults = client_config_file.open do |f|
                Google::Gax.construct_settings(
                  "google.cloud.dialogflow.cx.v3.Webhooks",
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
              @webhooks_stub = Google::Gax::Grpc.create_stub(
                service_path,
                port,
                chan_creds: chan_creds,
                channel: channel,
                updater_proc: updater_proc,
                scopes: scopes,
                interceptors: interceptors,
                &Google::Cloud::Dialogflow::Cx::V3::Webhooks::Stub.method(:new)
              )

              @list_webhooks = Google::Gax.create_api_call(
                @webhooks_stub.method(:list_webhooks),
                defaults["list_webhooks"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @get_webhook = Google::Gax.create_api_call(
                @webhooks_stub.method(:get_webhook),
                defaults["get_webhook"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @create_webhook = Google::Gax.create_api_call(
                @webhooks_stub.method(:create_webhook),
                defaults["create_webhook"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @update_webhook = Google::Gax.create_api_call(
                @webhooks_stub.method(:update_webhook),
                defaults["update_webhook"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'webhook.name' => request.webhook.name}
                end
              )
              @delete_webhook = Google::Gax.create_api_call(
                @webhooks_stub.method(:delete_webhook),
                defaults["delete_webhook"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
            end

            # Service calls

            # Returns the list of all webhooks in the specified agent.
            #
            # @param parent [String]
            #   Required. The agent to list all webhooks for.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
            # @param page_size [Integer]
            #   The maximum number of resources contained in the underlying API
            #   response. If page streaming is performed per-resource, this
            #   parameter does not affect the return value. If page streaming is
            #   performed per-page, this determines the maximum number of
            #   resources in a page.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::Cx::V3::Webhook>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::Cx::V3::Webhook>]
            #   An enumerable of Google::Cloud::Dialogflow::Cx::V3::Webhook instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   webhooks_client = Google::Cloud::Dialogflow::Cx::Webhooks.new(version: :v3)
            #   formatted_parent = Google::Cloud::Dialogflow::Cx::V3::WebhooksClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
            #
            #   # Iterate over all results.
            #   webhooks_client.list_webhooks(formatted_parent).each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   webhooks_client.list_webhooks(formatted_parent).each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_webhooks \
                parent,
                page_size: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                page_size: page_size
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3::ListWebhooksRequest)
              @list_webhooks.call(req, options, &block)
            end

            # Retrieves the specified webhook.
            #
            # @param name [String]
            #   Required. The name of the webhook.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
            #   ID>/webhooks/<Webhook ID>`.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Dialogflow::Cx::V3::Webhook]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Dialogflow::Cx::V3::Webhook]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   webhooks_client = Google::Cloud::Dialogflow::Cx::Webhooks.new(version: :v3)
            #   formatted_name = Google::Cloud::Dialogflow::Cx::V3::WebhooksClient.webhook_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]")
            #   response = webhooks_client.get_webhook(formatted_name)

            def get_webhook \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3::GetWebhookRequest)
              @get_webhook.call(req, options, &block)
            end

            # Creates a webhook in the specified agent.
            #
            # @param parent [String]
            #   Required. The agent to create a webhook for.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
            # @param webhook [Google::Cloud::Dialogflow::Cx::V3::Webhook | Hash]
            #   Required. The webhook to create.
            #   A hash of the same form as `Google::Cloud::Dialogflow::Cx::V3::Webhook`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Dialogflow::Cx::V3::Webhook]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Dialogflow::Cx::V3::Webhook]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   webhooks_client = Google::Cloud::Dialogflow::Cx::Webhooks.new(version: :v3)
            #   formatted_parent = Google::Cloud::Dialogflow::Cx::V3::WebhooksClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
            #
            #   # TODO: Initialize `webhook`:
            #   webhook = {}
            #   response = webhooks_client.create_webhook(formatted_parent, webhook)

            def create_webhook \
                parent,
                webhook,
                options: nil,
                &block
              req = {
                parent: parent,
                webhook: webhook
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3::CreateWebhookRequest)
              @create_webhook.call(req, options, &block)
            end

            # Updates the specified webhook.
            #
            # @param webhook [Google::Cloud::Dialogflow::Cx::V3::Webhook | Hash]
            #   Required. The webhook to update.
            #   A hash of the same form as `Google::Cloud::Dialogflow::Cx::V3::Webhook`
            #   can also be provided.
            # @param update_mask [Google::Protobuf::FieldMask | Hash]
            #   The mask to control which fields get updated. If the mask is not present,
            #   all fields will be updated.
            #   A hash of the same form as `Google::Protobuf::FieldMask`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Dialogflow::Cx::V3::Webhook]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Dialogflow::Cx::V3::Webhook]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   webhooks_client = Google::Cloud::Dialogflow::Cx::Webhooks.new(version: :v3)
            #
            #   # TODO: Initialize `webhook`:
            #   webhook = {}
            #   response = webhooks_client.update_webhook(webhook)

            def update_webhook \
                webhook,
                update_mask: nil,
                options: nil,
                &block
              req = {
                webhook: webhook,
                update_mask: update_mask
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3::UpdateWebhookRequest)
              @update_webhook.call(req, options, &block)
            end

            # Deletes the specified webhook.
            #
            # @param name [String]
            #   Required. The name of the webhook to delete.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
            #   ID>/webhooks/<Webhook ID>`.
            # @param force [true, false]
            #   This field has no effect for webhook not being used.
            #   For webhooks that are used by pages/flows/transition route groups:
            #
            #   * If `force` is set to false, an error will be returned with message
            #     indicating the referenced resources.
            #   * If `force` is set to true, Dialogflow will remove the webhook, as well
            #     as any references to the webhook (i.e. {Google::Cloud::Dialogflow::Cx::V3::Fulfillment#webhook Webhook}
            #     and {Google::Cloud::Dialogflow::Cx::V3::Fulfillment#tag tag}in fulfillments that point to this webhook
            #     will be removed).
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
            #   webhooks_client = Google::Cloud::Dialogflow::Cx::Webhooks.new(version: :v3)
            #   formatted_name = Google::Cloud::Dialogflow::Cx::V3::WebhooksClient.webhook_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]")
            #   webhooks_client.delete_webhook(formatted_name)

            def delete_webhook \
                name,
                force: nil,
                options: nil,
                &block
              req = {
                name: name,
                force: force
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3::DeleteWebhookRequest)
              @delete_webhook.call(req, options, &block)
              nil
            end
          end
        end
      end
    end
  end
end
