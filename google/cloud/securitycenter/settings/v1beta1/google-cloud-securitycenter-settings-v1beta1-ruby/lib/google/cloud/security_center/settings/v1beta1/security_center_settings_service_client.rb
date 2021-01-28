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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/securitycenter/settings/v1beta1/securitycenter_settings_service.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/securitycenter/settings/v1beta1/securitycenter_settings_service_pb"
require "google/cloud/security_center/settings/v1beta1/credentials"

module Google
  module Cloud
    module SecurityCenter
      module Settings
        module V1beta1
          # == API Overview
          #
          # The SecurityCenterSettingsService is a sub-api of
          # `securitycenter.googleapis.com`. The service provides methods to manage
          # Security Center Settings, and Component Settings for GCP organizations,
          # folders, projects, and clusters.
          #
          # @!attribute [r] security_center_settings_service_stub
          #   @return [Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub]
          class SecurityCenterSettingsServiceClient
            attr_reader :security_center_settings_service_stub

            # The default address of the service.
            SERVICE_ADDRESS = "securitycenter.googleapis.com".freeze

            # The default port of the service.
            DEFAULT_SERVICE_PORT = 443

            # The default set of gRPC interceptors.
            GRPC_INTERCEPTORS = []

            DEFAULT_TIMEOUT = 30

            PAGE_DESCRIPTORS = {
              "list_detectors" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "detectors"),
              "list_components" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "components")
            }.freeze

            private_constant :PAGE_DESCRIPTORS

            # The scopes needed to make gRPC calls to all of the methods defined in
            # this service.
            ALL_SCOPES = [
              "https://www.googleapis.com/auth/cloud-platform"
            ].freeze


            COMPONENT_SETTINGS_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "organizations/{organization}/components/{component}/settings"
            )

            private_constant :COMPONENT_SETTINGS_PATH_TEMPLATE

            ORGANIZATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "organizations/{organization}"
            )

            private_constant :ORGANIZATION_PATH_TEMPLATE

            SERVICE_ACCOUNT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "organizations/{organization}/serviceAccount"
            )

            private_constant :SERVICE_ACCOUNT_PATH_TEMPLATE

            SETTINGS_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "organizations/{organization}/settings"
            )

            private_constant :SETTINGS_PATH_TEMPLATE

            # Returns a fully-qualified component_settings resource name string.
            # @param organization [String]
            # @param component [String]
            # @return [String]
            def self.component_settings_path organization, component
              COMPONENT_SETTINGS_PATH_TEMPLATE.render(
                :"organization" => organization,
                :"component" => component
              )
            end

            # Returns a fully-qualified organization resource name string.
            # @param organization [String]
            # @return [String]
            def self.organization_path organization
              ORGANIZATION_PATH_TEMPLATE.render(
                :"organization" => organization
              )
            end

            # Returns a fully-qualified service_account resource name string.
            # @param organization [String]
            # @return [String]
            def self.service_account_path organization
              SERVICE_ACCOUNT_PATH_TEMPLATE.render(
                :"organization" => organization
              )
            end

            # Returns a fully-qualified settings resource name string.
            # @param organization [String]
            # @return [String]
            def self.settings_path organization
              SETTINGS_PATH_TEMPLATE.render(
                :"organization" => organization
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
              require "google/cloud/securitycenter/settings/v1beta1/securitycenter_settings_service_services_pb"

              credentials ||= Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.default

              if credentials.is_a?(String) || credentials.is_a?(Hash)
                updater_proc = Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.new(credentials).updater_proc
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

              package_version = Gem.loaded_specs['google-cloud-security_center-settings'].version.version

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
                "security_center_settings_service_client_config.json"
              )
              defaults = client_config_file.open do |f|
                Google::Gax.construct_settings(
                  "google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService",
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
              @security_center_settings_service_stub = Google::Gax::Grpc.create_stub(
                service_path,
                port,
                chan_creds: chan_creds,
                channel: channel,
                updater_proc: updater_proc,
                scopes: scopes,
                interceptors: interceptors,
                &Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.method(:new)
              )

              @get_service_account = Google::Gax.create_api_call(
                @security_center_settings_service_stub.method(:get_service_account),
                defaults["get_service_account"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @get_settings = Google::Gax.create_api_call(
                @security_center_settings_service_stub.method(:get_settings),
                defaults["get_settings"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @update_settings = Google::Gax.create_api_call(
                @security_center_settings_service_stub.method(:update_settings),
                defaults["update_settings"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'settings.name' => request.settings.name}
                end
              )
              @reset_settings = Google::Gax.create_api_call(
                @security_center_settings_service_stub.method(:reset_settings),
                defaults["reset_settings"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @batch_get_settings = Google::Gax.create_api_call(
                @security_center_settings_service_stub.method(:batch_get_settings),
                defaults["batch_get_settings"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @calculate_effective_settings = Google::Gax.create_api_call(
                @security_center_settings_service_stub.method(:calculate_effective_settings),
                defaults["calculate_effective_settings"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @batch_calculate_effective_settings = Google::Gax.create_api_call(
                @security_center_settings_service_stub.method(:batch_calculate_effective_settings),
                defaults["batch_calculate_effective_settings"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @get_component_settings = Google::Gax.create_api_call(
                @security_center_settings_service_stub.method(:get_component_settings),
                defaults["get_component_settings"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @update_component_settings = Google::Gax.create_api_call(
                @security_center_settings_service_stub.method(:update_component_settings),
                defaults["update_component_settings"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'component_settings.name' => request.component_settings.name}
                end
              )
              @reset_component_settings = Google::Gax.create_api_call(
                @security_center_settings_service_stub.method(:reset_component_settings),
                defaults["reset_component_settings"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @calculate_effective_component_settings = Google::Gax.create_api_call(
                @security_center_settings_service_stub.method(:calculate_effective_component_settings),
                defaults["calculate_effective_component_settings"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @list_detectors = Google::Gax.create_api_call(
                @security_center_settings_service_stub.method(:list_detectors),
                defaults["list_detectors"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @list_components = Google::Gax.create_api_call(
                @security_center_settings_service_stub.method(:list_components),
                defaults["list_components"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
            end

            # Service calls

            # Retrieves the organizations service account, if it exists, otherwise it
            # creates the organization service account. This API is idempotent and
            # will only create a service account once. On subsequent calls it will
            # return the previously created service account.  SHA, SCC and CTD Infra
            # Automation will use this SA.  This SA will not have any permissions when
            # created.  The UI will provision this via IAM or the user will using
            # their own internal process. This API only creates SAs on the organization.
            # Folders are not supported and projects will use per-project SAs associated
            # with APIs enabled on a project. This API will be called by the UX
            # onboarding workflow.
            #
            # @param name [String]
            #   Required. The relative resource name of the service account resource.
            #   Format:
            #   * `organizations/{organization}/serviceAccount`
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Securitycenter::Settings::V1beta1::ServiceAccount]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Securitycenter::Settings::V1beta1::ServiceAccount]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/security_center/settings"
            #
            #   security_center_settings_client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)
            #   formatted_name = Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient.service_account_path("[ORGANIZATION]")
            #   response = security_center_settings_client.get_service_account(formatted_name)

            def get_service_account \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Securitycenter::Settings::V1beta1::GetServiceAccountRequest)
              @get_service_account.call(req, options, &block)
            end

            # Gets the Settings.
            #
            # @param name [String]
            #   Required. The name of the settings to retrieve.
            #   Formats:
            #   * `organizations/{organization}/settings`
            #     * `folders/{folder}/settings`
            #   * `projects/{project}/settings`
            #     * `projects/{project}/locations/{location}/clusters/{cluster}/settings`
            #   * `projects/{project}/regions/{region}/clusters/{cluster}/settings`
            #     * `projects/{project}/zones/{zone}/clusters/{cluster}/settings`
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Securitycenter::Settings::V1beta1::Settings]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Securitycenter::Settings::V1beta1::Settings]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/security_center/settings"
            #
            #   security_center_settings_client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)
            #
            #   # TODO: Initialize `name`:
            #   name = ''
            #   response = security_center_settings_client.get_settings(name)

            def get_settings \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Securitycenter::Settings::V1beta1::GetSettingsRequest)
              @get_settings.call(req, options, &block)
            end

            # Updates the Settings.
            #
            # @param settings [Google::Cloud::Securitycenter::Settings::V1beta1::Settings | Hash]
            #   Required. The settings to update.
            #
            #   The settings' `name` field is used to identify the settings to be updated.
            #   Formats:
            #   * `organizations/{organization}/settings`
            #     * `folders/{folder}/settings`
            #   * `projects/{project}/settings`
            #     * `projects/{project}/locations/{location}/clusters/{cluster}/settings`
            #   * `projects/{project}/regions/{region}/clusters/{cluster}/settings`
            #     * `projects/{project}/zones/{zone}/clusters/{cluster}/settings`
            #   A hash of the same form as `Google::Cloud::Securitycenter::Settings::V1beta1::Settings`
            #   can also be provided.
            # @param update_mask [Google::Protobuf::FieldMask | Hash]
            #   The list of fields to be updated on the settings.
            #   A hash of the same form as `Google::Protobuf::FieldMask`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Securitycenter::Settings::V1beta1::Settings]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Securitycenter::Settings::V1beta1::Settings]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/security_center/settings"
            #
            #   security_center_settings_client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)
            #
            #   # TODO: Initialize `settings`:
            #   settings = {}
            #   response = security_center_settings_client.update_settings(settings)

            def update_settings \
                settings,
                update_mask: nil,
                options: nil,
                &block
              req = {
                settings: settings,
                update_mask: update_mask
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Securitycenter::Settings::V1beta1::UpdateSettingsRequest)
              @update_settings.call(req, options, &block)
            end

            # Reset the organization, folder or project's settings and return
            # the settings of just that resource to the default.
            #
            # Settings are present at the organization, folder, project, and cluster
            # levels. Using Reset on a sub-organization level will remove that resource's
            # override and result in the parent's settings being used (eg: if Reset on a
            # cluster, project settings will be used).
            #
            # Using Reset on organization will remove the override that was set and
            # result in default settings being used.
            #
            # @param name [String]
            #   Required. The name of the settings to reset.
            #   Formats:
            #   * `organizations/{organization}/settings`
            #     * `folders/{folder}/settings`
            #   * `projects/{project}/settings`
            #     * `projects/{project}/locations/{location}/clusters/{cluster}/settings`
            #   * `projects/{project}/regions/{region}/clusters/{cluster}/settings`
            #     * `projects/{project}/zones/{zone}/clusters/{cluster}/settings`
            # @param etag [String]
            #   A fingerprint used for optimistic concurrency. If none is provided,
            #   then the existing settings will be blindly overwritten.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result []
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/security_center/settings"
            #
            #   security_center_settings_client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)
            #
            #   # TODO: Initialize `name`:
            #   name = ''
            #   security_center_settings_client.reset_settings(name)

            def reset_settings \
                name,
                etag: nil,
                options: nil,
                &block
              req = {
                name: name,
                etag: etag
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Securitycenter::Settings::V1beta1::ResetSettingsRequest)
              @reset_settings.call(req, options, &block)
              nil
            end

            # Gets a list of settings.
            #
            # @param parent [String]
            #   Required. The relative resource name of the organization shared by all of the
            #   settings being retrieved.
            #   Format:
            #   * `organizations/{organization}`
            # @param names [Array<String>]
            #   The names of the settings to retrieve.
            #   A maximum of 1000 settings can be retrieved in a batch.
            #   Formats:
            #   * `organizations/{organization}/settings`
            #     * `folders/{folder}/settings`
            #   * `projects/{project}/settings`
            #     * `projects/{project}/locations/{location}/clusters/{cluster}/settings`
            #   * `projects/{project}/regions/{region}/clusters/{cluster}/settings`
            #     * `projects/{project}/zones/{zone}/clusters/{cluster}/settings`
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Securitycenter::Settings::V1beta1::BatchGetSettingsResponse]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Securitycenter::Settings::V1beta1::BatchGetSettingsResponse]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/security_center/settings"
            #
            #   security_center_settings_client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)
            #   formatted_parent = Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient.organization_path("[ORGANIZATION]")
            #   response = security_center_settings_client.batch_get_settings(formatted_parent)

            def batch_get_settings \
                parent,
                names: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                names: names
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Securitycenter::Settings::V1beta1::BatchGetSettingsRequest)
              @batch_get_settings.call(req, options, &block)
            end

            # CalculateEffectiveSettings looks up all of the Security Center
            # Settings resources in the GCP resource hierarchy, and calculates the
            # effective settings on that resource by applying the following rules:
            # * Settings provided closer to the target resource take precedence over
            #   those further away (e.g. folder will override organization level
            #   settings).
            # * Product defaults can be overridden at org, folder, project, and cluster
            #   levels.
            # * Detectors will be filtered out if they belong to a billing tier the
            #   customer
            #   has not configured.
            #
            # @param name [String]
            #   Required. The name of the effective settings to retrieve.
            #   Formats:
            #   * `organizations/{organization}/effectiveSettings`
            #     * `folders/{folder}/effectiveSettings`
            #   * `projects/{project}/effectiveSettings`
            #     * `projects/{project}/locations/{location}/clusters/{cluster}/effectiveSettings`
            #   * `projects/{project}/regions/{region}/clusters/{cluster}/effectiveSettings`
            #     * `projects/{project}/zones/{zone}/clusters/{cluster}/effectiveSettings`
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Securitycenter::Settings::V1beta1::Settings]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Securitycenter::Settings::V1beta1::Settings]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/security_center/settings"
            #
            #   security_center_settings_client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)
            #
            #   # TODO: Initialize `name`:
            #   name = ''
            #   response = security_center_settings_client.calculate_effective_settings(name)

            def calculate_effective_settings \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Securitycenter::Settings::V1beta1::CalculateEffectiveSettingsRequest)
              @calculate_effective_settings.call(req, options, &block)
            end

            # Gets a list of effective settings.
            #
            # @param parent [String]
            #   Required. The relative resource name of the organization shared by all of the
            #   settings being retrieved.
            #   Format:
            #   * `organizations/{organization}`
            # @param requests [Array<Google::Cloud::Securitycenter::Settings::V1beta1::CalculateEffectiveSettingsRequest | Hash>]
            #   The requests specifying the effective settings to retrieve.
            #   A maximum of 1000 effective settings can be retrieved in a batch.
            #   A hash of the same form as `Google::Cloud::Securitycenter::Settings::V1beta1::CalculateEffectiveSettingsRequest`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Securitycenter::Settings::V1beta1::BatchCalculateEffectiveSettingsResponse]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Securitycenter::Settings::V1beta1::BatchCalculateEffectiveSettingsResponse]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/security_center/settings"
            #
            #   security_center_settings_client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)
            #   formatted_parent = Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient.organization_path("[ORGANIZATION]")
            #   response = security_center_settings_client.batch_calculate_effective_settings(formatted_parent)

            def batch_calculate_effective_settings \
                parent,
                requests: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                requests: requests
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Securitycenter::Settings::V1beta1::BatchCalculateEffectiveSettingsRequest)
              @batch_calculate_effective_settings.call(req, options, &block)
            end

            # Gets the Component Settings.
            #
            # @param name [String]
            #   Required. The component settings to retrieve.
            #
            #   Formats:
            #   * `organizations/{organization}/components/{component}/settings`
            #     * `folders/{folder}/components/{component}/settings`
            #   * `projects/{project}/components/{component}/settings`
            #     * `projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings`
            #   * `projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings`
            #     * `projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings`
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Securitycenter::Settings::V1beta1::ComponentSettings]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Securitycenter::Settings::V1beta1::ComponentSettings]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/security_center/settings"
            #
            #   security_center_settings_client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)
            #
            #   # TODO: Initialize `name`:
            #   name = ''
            #   response = security_center_settings_client.get_component_settings(name)

            def get_component_settings \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Securitycenter::Settings::V1beta1::GetComponentSettingsRequest)
              @get_component_settings.call(req, options, &block)
            end

            # Updates the Component Settings.
            #
            # @param component_settings [Google::Cloud::Securitycenter::Settings::V1beta1::ComponentSettings | Hash]
            #   Required. The component settings to update.
            #
            #   The component settings' `name` field is used to identify the component
            #   settings to be updated. Formats:
            #   * `organizations/{organization}/components/{component}/settings`
            #     * `folders/{folder}/components/{component}/settings`
            #   * `projects/{project}/components/{component}/settings`
            #     * `projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings`
            #   * `projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings`
            #     * `projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings`
            #   A hash of the same form as `Google::Cloud::Securitycenter::Settings::V1beta1::ComponentSettings`
            #   can also be provided.
            # @param update_mask [Google::Protobuf::FieldMask | Hash]
            #   The list of fields to be updated on the component settings resource.
            #   A hash of the same form as `Google::Protobuf::FieldMask`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Securitycenter::Settings::V1beta1::ComponentSettings]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Securitycenter::Settings::V1beta1::ComponentSettings]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/security_center/settings"
            #
            #   security_center_settings_client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)
            #
            #   # TODO: Initialize `component_settings`:
            #   component_settings = {}
            #   response = security_center_settings_client.update_component_settings(component_settings)

            def update_component_settings \
                component_settings,
                update_mask: nil,
                options: nil,
                &block
              req = {
                component_settings: component_settings,
                update_mask: update_mask
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Securitycenter::Settings::V1beta1::UpdateComponentSettingsRequest)
              @update_component_settings.call(req, options, &block)
            end

            # Reset the organization, folder or project's component settings and return
            # the settings to the default. Settings are present at the
            # organization, folder and project levels. Using Reset for a folder or
            # project will remove the override that was set and result in the
            # organization-level settings being used.
            #
            # @param name [String]
            #   Required. The component settings to reset.
            #
            #   Formats:
            #   * `organizations/{organization}/components/{component}/settings`
            #     * `folders/{folder}/components/{component}/settings`
            #   * `projects/{project}/components/{component}/settings`
            #     * `projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings`
            #   * `projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings`
            #     * `projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings`
            # @param etag [String]
            #   An fingerprint used for optimistic concurrency. If none is provided,
            #   then the existing settings will be blindly overwritten.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result []
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/security_center/settings"
            #
            #   security_center_settings_client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)
            #
            #   # TODO: Initialize `name`:
            #   name = ''
            #   security_center_settings_client.reset_component_settings(name)

            def reset_component_settings \
                name,
                etag: nil,
                options: nil,
                &block
              req = {
                name: name,
                etag: etag
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Securitycenter::Settings::V1beta1::ResetComponentSettingsRequest)
              @reset_component_settings.call(req, options, &block)
              nil
            end

            # Gets the Effective Component Settings.
            #
            # @param name [String]
            #   Required. The effective component settings to retrieve.
            #
            #   Formats:
            #   * `organizations/{organization}/components/{component}/settings`
            #     * `folders/{folder}/components/{component}/settings`
            #   * `projects/{project}/components/{component}/settings`
            #     * `projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings`
            #   * `projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings`
            #     * `projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings`
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Securitycenter::Settings::V1beta1::ComponentSettings]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Securitycenter::Settings::V1beta1::ComponentSettings]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/security_center/settings"
            #
            #   security_center_settings_client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)
            #
            #   # TODO: Initialize `name`:
            #   name = ''
            #   response = security_center_settings_client.calculate_effective_component_settings(name)

            def calculate_effective_component_settings \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Securitycenter::Settings::V1beta1::CalculateEffectiveComponentSettingsRequest)
              @calculate_effective_component_settings.call(req, options, &block)
            end

            # Retrieves an unordered list of available detectors.
            #
            # @param parent [String]
            #   Required. The parent, which owns this collection of detectors.
            #   Format:
            #   * `organizations/{organization}`
            # @param filter [String]
            #   Filters to apply on the response. Filters can be applied on:
            #   * components
            #     * labels
            #   * billing tiers
            #
            #   Component filters will retrieve only detectors for the components
            #   specified. Label filters will retrieve only detectors that match one of the
            #   labels specified. Billing tier filters will retrieve only detectors for
            #   that billing tier.
            #
            #   The filters
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
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Securitycenter::Settings::V1beta1::Detector>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Cloud::Securitycenter::Settings::V1beta1::Detector>]
            #   An enumerable of Google::Cloud::Securitycenter::Settings::V1beta1::Detector instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/security_center/settings"
            #
            #   security_center_settings_client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)
            #   formatted_parent = Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient.organization_path("[ORGANIZATION]")
            #
            #   # Iterate over all results.
            #   security_center_settings_client.list_detectors(formatted_parent).each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   security_center_settings_client.list_detectors(formatted_parent).each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_detectors \
                parent,
                filter: nil,
                page_size: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                filter: filter,
                page_size: page_size
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Securitycenter::Settings::V1beta1::ListDetectorsRequest)
              @list_detectors.call(req, options, &block)
            end

            # Retrieves an unordered list of available SCC components.
            #
            # @param parent [String]
            #   Required. The parent, which owns this collection of components.
            #   Format:
            #   * `organizations/{organization}`
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
            # @yieldparam result [Google::Gax::PagedEnumerable<String>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<String>]
            #   An enumerable of String instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/security_center/settings"
            #
            #   security_center_settings_client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)
            #   formatted_parent = Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient.organization_path("[ORGANIZATION]")
            #
            #   # Iterate over all results.
            #   security_center_settings_client.list_components(formatted_parent).each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   security_center_settings_client.list_components(formatted_parent).each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_components \
                parent,
                page_size: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                page_size: page_size
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Securitycenter::Settings::V1beta1::ListComponentsRequest)
              @list_components.call(req, options, &block)
            end
          end
        end
      end
    end
  end
end
