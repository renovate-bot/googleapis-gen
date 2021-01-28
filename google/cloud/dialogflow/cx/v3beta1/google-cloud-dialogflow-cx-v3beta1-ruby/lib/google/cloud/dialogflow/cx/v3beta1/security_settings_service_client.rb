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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/dialogflow/cx/v3beta1/security_settings.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/dialogflow/cx/v3beta1/security_settings_pb"
require "google/cloud/dialogflow/cx/v3beta1/credentials"

module Google
  module Cloud
    module Dialogflow
      module Cx
        module V3beta1
          # Service for managing security settings for Dialogflow.
          #
          # @!attribute [r] security_settings_service_stub
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::SecuritySettingsService::Stub]
          class SecuritySettingsServiceClient
            attr_reader :security_settings_service_stub

            # The default address of the service.
            SERVICE_ADDRESS = "dialogflow.googleapis.com".freeze

            # The default port of the service.
            DEFAULT_SERVICE_PORT = 443

            # The default set of gRPC interceptors.
            GRPC_INTERCEPTORS = []

            DEFAULT_TIMEOUT = 30

            PAGE_DESCRIPTORS = {
              "list_security_settings" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "security_settings")
            }.freeze

            private_constant :PAGE_DESCRIPTORS

            # The scopes needed to make gRPC calls to all of the methods defined in
            # this service.
            ALL_SCOPES = [
              "https://www.googleapis.com/auth/cloud-platform",
              "https://www.googleapis.com/auth/dialogflow"
            ].freeze


            LOCATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}"
            )

            private_constant :LOCATION_PATH_TEMPLATE

            SECURITY_SETTINGS_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}/securitySettings/{security_settings}"
            )

            private_constant :SECURITY_SETTINGS_PATH_TEMPLATE

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

            # Returns a fully-qualified security_settings resource name string.
            # @param project [String]
            # @param location [String]
            # @param security_settings [String]
            # @return [String]
            def self.security_settings_path project, location, security_settings
              SECURITY_SETTINGS_PATH_TEMPLATE.render(
                :"project" => project,
                :"location" => location,
                :"security_settings" => security_settings
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
              require "google/cloud/dialogflow/cx/v3beta1/security_settings_services_pb"

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
                "security_settings_service_client_config.json"
              )
              defaults = client_config_file.open do |f|
                Google::Gax.construct_settings(
                  "google.cloud.dialogflow.cx.v3beta1.SecuritySettingsService",
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
              @security_settings_service_stub = Google::Gax::Grpc.create_stub(
                service_path,
                port,
                chan_creds: chan_creds,
                channel: channel,
                updater_proc: updater_proc,
                scopes: scopes,
                interceptors: interceptors,
                &Google::Cloud::Dialogflow::Cx::V3beta1::SecuritySettingsService::Stub.method(:new)
              )

              @create_security_settings = Google::Gax.create_api_call(
                @security_settings_service_stub.method(:create_security_settings),
                defaults["create_security_settings"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @get_security_settings = Google::Gax.create_api_call(
                @security_settings_service_stub.method(:get_security_settings),
                defaults["get_security_settings"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @update_security_settings = Google::Gax.create_api_call(
                @security_settings_service_stub.method(:update_security_settings),
                defaults["update_security_settings"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'security_settings.name' => request.security_settings.name}
                end
              )
              @list_security_settings = Google::Gax.create_api_call(
                @security_settings_service_stub.method(:list_security_settings),
                defaults["list_security_settings"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @delete_security_settings = Google::Gax.create_api_call(
                @security_settings_service_stub.method(:delete_security_settings),
                defaults["delete_security_settings"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
            end

            # Service calls

            # Create security settings in the specified location.
            #
            # @param parent [String]
            #   Required. The location to create an {Google::Cloud::Dialogflow::Cx::V3beta1::SecuritySettings SecuritySettings} for.
            #   Format: `projects/<Project ID>/locations/<Location ID>`.
            # @param security_settings [Google::Cloud::Dialogflow::Cx::V3beta1::SecuritySettings | Hash]
            #   Required. The security settings to create.
            #   A hash of the same form as `Google::Cloud::Dialogflow::Cx::V3beta1::SecuritySettings`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Dialogflow::Cx::V3beta1::SecuritySettings]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Dialogflow::Cx::V3beta1::SecuritySettings]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   security_settings_client = Google::Cloud::Dialogflow::Cx::SecuritySettings.new(version: :v3beta1)
            #   formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::SecuritySettingsServiceClient.location_path("[PROJECT]", "[LOCATION]")
            #
            #   # TODO: Initialize `security_settings`:
            #   security_settings = {}
            #   response = security_settings_client.create_security_settings(formatted_parent, security_settings)

            def create_security_settings \
                parent,
                security_settings,
                options: nil,
                &block
              req = {
                parent: parent,
                security_settings: security_settings
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3beta1::CreateSecuritySettingsRequest)
              @create_security_settings.call(req, options, &block)
            end

            # Retrieves the specified {Google::Cloud::Dialogflow::Cx::V3beta1::SecuritySettings SecuritySettings}.
            # The returned settings may be stale by up to 1 minute.
            #
            # @param name [String]
            #   Required. Resource name of the settings.
            #   Format: `projects/<Project ID>/locations/<Location
            #   ID>/securitySettings/<security settings ID>`.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Dialogflow::Cx::V3beta1::SecuritySettings]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Dialogflow::Cx::V3beta1::SecuritySettings]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   security_settings_client = Google::Cloud::Dialogflow::Cx::SecuritySettings.new(version: :v3beta1)
            #   formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::SecuritySettingsServiceClient.security_settings_path("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]")
            #   response = security_settings_client.get_security_settings(formatted_name)

            def get_security_settings \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3beta1::GetSecuritySettingsRequest)
              @get_security_settings.call(req, options, &block)
            end

            # Updates the specified {Google::Cloud::Dialogflow::Cx::V3beta1::SecuritySettings SecuritySettings}.
            #
            # @param security_settings [Google::Cloud::Dialogflow::Cx::V3beta1::SecuritySettings | Hash]
            #   Required. [SecuritySettings] object that contains values for each of the
            #   fields to update.
            #   A hash of the same form as `Google::Cloud::Dialogflow::Cx::V3beta1::SecuritySettings`
            #   can also be provided.
            # @param update_mask [Google::Protobuf::FieldMask | Hash]
            #   Required. The mask to control which fields get updated. If the mask is not present,
            #   all fields will be updated.
            #   A hash of the same form as `Google::Protobuf::FieldMask`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Dialogflow::Cx::V3beta1::SecuritySettings]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Dialogflow::Cx::V3beta1::SecuritySettings]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   security_settings_client = Google::Cloud::Dialogflow::Cx::SecuritySettings.new(version: :v3beta1)
            #
            #   # TODO: Initialize `security_settings`:
            #   security_settings = {}
            #
            #   # TODO: Initialize `update_mask`:
            #   update_mask = {}
            #   response = security_settings_client.update_security_settings(security_settings, update_mask)

            def update_security_settings \
                security_settings,
                update_mask,
                options: nil,
                &block
              req = {
                security_settings: security_settings,
                update_mask: update_mask
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3beta1::UpdateSecuritySettingsRequest)
              @update_security_settings.call(req, options, &block)
            end

            # Returns the list of all security settings in the specified location.
            #
            # @param parent [String]
            #   Required. The location to list all security settings for.
            #   Format: `projects/<Project ID>/locations/<Location ID>`.
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
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::Cx::V3beta1::SecuritySettings>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::Cx::V3beta1::SecuritySettings>]
            #   An enumerable of Google::Cloud::Dialogflow::Cx::V3beta1::SecuritySettings instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   security_settings_client = Google::Cloud::Dialogflow::Cx::SecuritySettings.new(version: :v3beta1)
            #   formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::SecuritySettingsServiceClient.location_path("[PROJECT]", "[LOCATION]")
            #
            #   # Iterate over all results.
            #   security_settings_client.list_security_settings(formatted_parent).each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   security_settings_client.list_security_settings(formatted_parent).each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_security_settings \
                parent,
                page_size: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                page_size: page_size
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3beta1::ListSecuritySettingsRequest)
              @list_security_settings.call(req, options, &block)
            end

            # Deletes the specified {Google::Cloud::Dialogflow::Cx::V3beta1::SecuritySettings SecuritySettings}.
            #
            # @param name [String]
            #   Required. The name of the {Google::Cloud::Dialogflow::Cx::V3beta1::SecuritySettings SecuritySettings} to delete.
            #   Format: `projects/<Project ID>/locations/<Location
            #   ID>/securitySettings/<Security Settings ID>`.
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
            #   security_settings_client = Google::Cloud::Dialogflow::Cx::SecuritySettings.new(version: :v3beta1)
            #   formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::SecuritySettingsServiceClient.security_settings_path("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]")
            #   security_settings_client.delete_security_settings(formatted_name)

            def delete_security_settings \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3beta1::DeleteSecuritySettingsRequest)
              @delete_security_settings.call(req, options, &block)
              nil
            end
          end
        end
      end
    end
  end
end
