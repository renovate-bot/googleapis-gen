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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/gsuiteaddons/v1/gsuiteaddons.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/gsuiteaddons/v1/gsuiteaddons_pb"
require "google/cloud/g_suite_add_ons/v1/credentials"

module Google
  module Cloud
    module GSuiteAddOns
      module V1
        # A service for managing Google Workspace Add-ons deployments.
        #
        # A Google Workspace Add-on is a third-party embedded component that can be
        # installed in Google Workspace Applications like Gmail, Calendar, Drive, and
        # the Google Docs, Sheets, and Slides editors. Google Workspace Add-ons can
        # display UI cards, receive contextual information from the host application,
        # and perform actions in the host application (See:
        # https://developers.google.com/gsuite/add-ons/overview for more information).
        #
        # A Google Workspace Add-on deployment resource specifies metadata about the
        # add-on, including a specification of the entry points in the host application
        # that trigger add-on executions (see:
        # https://developers.google.com/gsuite/add-ons/concepts/gsuite-manifests).
        # Add-on deployments defined via the Google Workspace Add-ons API define their
        # entrypoints using HTTPS URLs (See:
        # https://developers.google.com/gsuite/add-ons/guides/alternate-runtimes),
        #
        # A Google Workspace Add-on deployment can be installed in developer mode,
        # which allows an add-on developer to test the experience an end-user would see
        # when installing and running the add-on in their G Suite applications.  When
        # running in developer mode, more detailed error messages are exposed in the
        # add-on UI to aid in debugging.
        #
        # A Google Workspace Add-on deployment can be published to Google Workspace
        # Marketplace, which allows other Google Workspace users to discover and
        # install the add-on.  See:
        # https://developers.google.com/gsuite/add-ons/how-tos/publish-add-on-overview
        # for details.
        #
        # @!attribute [r] g_suite_add_ons_stub
        #   @return [Google::Cloud::Gsuiteaddons::V1::GSuiteAddOns::Stub]
        class GSuiteAddOnsClient
          attr_reader :g_suite_add_ons_stub

          # The default address of the service.
          SERVICE_ADDRESS = "gsuiteaddons.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_deployments" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "deployments")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform"
          ].freeze


          AUTHORIZATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/authorization"
          )

          private_constant :AUTHORIZATION_PATH_TEMPLATE

          DEPLOYMENT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/deployments/{deployment}"
          )

          private_constant :DEPLOYMENT_PATH_TEMPLATE

          INSTALL_STATUS_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/deployments/{deployment}/installStatus"
          )

          private_constant :INSTALL_STATUS_PATH_TEMPLATE

          PROJECT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}"
          )

          private_constant :PROJECT_PATH_TEMPLATE

          # Returns a fully-qualified authorization resource name string.
          # @param project [String]
          # @return [String]
          def self.authorization_path project
            AUTHORIZATION_PATH_TEMPLATE.render(
              :"project" => project
            )
          end

          # Returns a fully-qualified deployment resource name string.
          # @param project [String]
          # @param deployment [String]
          # @return [String]
          def self.deployment_path project, deployment
            DEPLOYMENT_PATH_TEMPLATE.render(
              :"project" => project,
              :"deployment" => deployment
            )
          end

          # Returns a fully-qualified install_status resource name string.
          # @param project [String]
          # @param deployment [String]
          # @return [String]
          def self.install_status_path project, deployment
            INSTALL_STATUS_PATH_TEMPLATE.render(
              :"project" => project,
              :"deployment" => deployment
            )
          end

          # Returns a fully-qualified project resource name string.
          # @param project [String]
          # @return [String]
          def self.project_path project
            PROJECT_PATH_TEMPLATE.render(
              :"project" => project
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
            require "google/cloud/gsuiteaddons/v1/gsuiteaddons_services_pb"

            credentials ||= Google::Cloud::GSuiteAddOns::V1::Credentials.default

            if credentials.is_a?(String) || credentials.is_a?(Hash)
              updater_proc = Google::Cloud::GSuiteAddOns::V1::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-cloud-g_suite_add_ons'].version.version

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
              "g_suite_add_ons_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.gsuiteaddons.v1.GSuiteAddOns",
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
            @g_suite_add_ons_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Gsuiteaddons::V1::GSuiteAddOns::Stub.method(:new)
            )

            @get_authorization = Google::Gax.create_api_call(
              @g_suite_add_ons_stub.method(:get_authorization),
              defaults["get_authorization"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @create_deployment = Google::Gax.create_api_call(
              @g_suite_add_ons_stub.method(:create_deployment),
              defaults["create_deployment"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @replace_deployment = Google::Gax.create_api_call(
              @g_suite_add_ons_stub.method(:replace_deployment),
              defaults["replace_deployment"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'deployment.name' => request.deployment.name}
              end
            )
            @get_deployment = Google::Gax.create_api_call(
              @g_suite_add_ons_stub.method(:get_deployment),
              defaults["get_deployment"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_deployments = Google::Gax.create_api_call(
              @g_suite_add_ons_stub.method(:list_deployments),
              defaults["list_deployments"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @delete_deployment = Google::Gax.create_api_call(
              @g_suite_add_ons_stub.method(:delete_deployment),
              defaults["delete_deployment"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @install_deployment = Google::Gax.create_api_call(
              @g_suite_add_ons_stub.method(:install_deployment),
              defaults["install_deployment"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @uninstall_deployment = Google::Gax.create_api_call(
              @g_suite_add_ons_stub.method(:uninstall_deployment),
              defaults["uninstall_deployment"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @get_install_status = Google::Gax.create_api_call(
              @g_suite_add_ons_stub.method(:get_install_status),
              defaults["get_install_status"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
          end

          # Service calls

          # Gets the authorization information for deployments in a given project.
          #
          # @param name [String]
          #   Required. Name of the project for which to get the Google Workspace Add-ons
          #   authorization information.
          #
          #   Example: `projects/my_project/authorization`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Gsuiteaddons::V1::Authorization]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Gsuiteaddons::V1::Authorization]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/g_suite_add_ons"
          #
          #   g_suite_add_ons_client = Google::Cloud::GSuiteAddOns.new(version: :v1)
          #   formatted_name = Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient.authorization_path("[PROJECT]")
          #   response = g_suite_add_ons_client.get_authorization(formatted_name)

          def get_authorization \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gsuiteaddons::V1::GetAuthorizationRequest)
            @get_authorization.call(req, options, &block)
          end

          # Creates a deployment with the specified name and configuration.
          #
          # @param parent [String]
          #   Required. Name of the project in which to create the deployment.
          #
          #   Example: `projects/my_project`.
          # @param deployment_id [String]
          #   Required. The id to use for this deployment.  The full name of the created
          #   resource will be `projects/<project_number>/deployments/<deployment_id>`.
          # @param deployment [Google::Cloud::Gsuiteaddons::V1::Deployment | Hash]
          #   Required. The deployment to create (deployment.name cannot be set).
          #   A hash of the same form as `Google::Cloud::Gsuiteaddons::V1::Deployment`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Gsuiteaddons::V1::Deployment]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Gsuiteaddons::V1::Deployment]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/g_suite_add_ons"
          #
          #   g_suite_add_ons_client = Google::Cloud::GSuiteAddOns.new(version: :v1)
          #   formatted_parent = Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient.project_path("[PROJECT]")
          #
          #   # TODO: Initialize `deployment_id`:
          #   deployment_id = ''
          #
          #   # TODO: Initialize `deployment`:
          #   deployment = {}
          #   response = g_suite_add_ons_client.create_deployment(formatted_parent, deployment_id, deployment)

          def create_deployment \
              parent,
              deployment_id,
              deployment,
              options: nil,
              &block
            req = {
              parent: parent,
              deployment_id: deployment_id,
              deployment: deployment
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gsuiteaddons::V1::CreateDeploymentRequest)
            @create_deployment.call(req, options, &block)
          end

          # Creates or replaces a deployment with the specified name.
          #
          # @param deployment [Google::Cloud::Gsuiteaddons::V1::Deployment | Hash]
          #   Required. The deployment to create or replace.
          #   A hash of the same form as `Google::Cloud::Gsuiteaddons::V1::Deployment`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Gsuiteaddons::V1::Deployment]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Gsuiteaddons::V1::Deployment]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/g_suite_add_ons"
          #
          #   g_suite_add_ons_client = Google::Cloud::GSuiteAddOns.new(version: :v1)
          #
          #   # TODO: Initialize `deployment`:
          #   deployment = {}
          #   response = g_suite_add_ons_client.replace_deployment(deployment)

          def replace_deployment \
              deployment,
              options: nil,
              &block
            req = {
              deployment: deployment
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gsuiteaddons::V1::ReplaceDeploymentRequest)
            @replace_deployment.call(req, options, &block)
          end

          # Gets the deployment with the specified name.
          #
          # @param name [String]
          #   Required. The full resource name of the deployment to get.
          #
          #   Example:  `projects/my_project/deployments/my_deployment`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Gsuiteaddons::V1::Deployment]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Gsuiteaddons::V1::Deployment]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/g_suite_add_ons"
          #
          #   g_suite_add_ons_client = Google::Cloud::GSuiteAddOns.new(version: :v1)
          #   formatted_name = Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient.deployment_path("[PROJECT]", "[DEPLOYMENT]")
          #   response = g_suite_add_ons_client.get_deployment(formatted_name)

          def get_deployment \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gsuiteaddons::V1::GetDeploymentRequest)
            @get_deployment.call(req, options, &block)
          end

          # Lists all deployments in a particular project.
          #
          # @param parent [String]
          #   Required. Name of the project in which to create the deployment.
          #
          #   Example: `projects/my_project`.
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Gsuiteaddons::V1::Deployment>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Gsuiteaddons::V1::Deployment>]
          #   An enumerable of Google::Cloud::Gsuiteaddons::V1::Deployment instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/g_suite_add_ons"
          #
          #   g_suite_add_ons_client = Google::Cloud::GSuiteAddOns.new(version: :v1)
          #   formatted_parent = Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient.project_path("[PROJECT]")
          #
          #   # Iterate over all results.
          #   g_suite_add_ons_client.list_deployments(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   g_suite_add_ons_client.list_deployments(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_deployments \
              parent,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gsuiteaddons::V1::ListDeploymentsRequest)
            @list_deployments.call(req, options, &block)
          end

          # Deletes the deployment with the given name.
          #
          # @param name [String]
          #   Required. The full resource name of the deployment to delete.
          #
          #   Example:  `projects/my_project/deployments/my_deployment`.
          # @param etag [String]
          #   The etag of the deployment to delete.
          #   If this is provided, it must match the server's etag.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/g_suite_add_ons"
          #
          #   g_suite_add_ons_client = Google::Cloud::GSuiteAddOns.new(version: :v1)
          #   formatted_name = Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient.deployment_path("[PROJECT]", "[DEPLOYMENT]")
          #   g_suite_add_ons_client.delete_deployment(formatted_name)

          def delete_deployment \
              name,
              etag: nil,
              options: nil,
              &block
            req = {
              name: name,
              etag: etag
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gsuiteaddons::V1::DeleteDeploymentRequest)
            @delete_deployment.call(req, options, &block)
            nil
          end

          # Installs a deployment in developer mode.
          # See:
          # https://developers.google.com/gsuite/add-ons/how-tos/testing-gsuite-addons.
          #
          # @param name [String]
          #   Required. The full resource name of the deployment to install.
          #
          #   Example:  `projects/my_project/deployments/my_deployment`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/g_suite_add_ons"
          #
          #   g_suite_add_ons_client = Google::Cloud::GSuiteAddOns.new(version: :v1)
          #   formatted_name = Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient.deployment_path("[PROJECT]", "[DEPLOYMENT]")
          #   g_suite_add_ons_client.install_deployment(formatted_name)

          def install_deployment \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gsuiteaddons::V1::InstallDeploymentRequest)
            @install_deployment.call(req, options, &block)
            nil
          end

          # Uninstalls a developer mode deployment.
          # See:
          # https://developers.google.com/gsuite/add-ons/how-tos/testing-gsuite-addons.
          #
          # @param name [String]
          #   Required. The full resource name of the deployment to install.
          #
          #   Example:  `projects/my_project/deployments/my_deployment`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/g_suite_add_ons"
          #
          #   g_suite_add_ons_client = Google::Cloud::GSuiteAddOns.new(version: :v1)
          #   formatted_name = Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient.deployment_path("[PROJECT]", "[DEPLOYMENT]")
          #   g_suite_add_ons_client.uninstall_deployment(formatted_name)

          def uninstall_deployment \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gsuiteaddons::V1::UninstallDeploymentRequest)
            @uninstall_deployment.call(req, options, &block)
            nil
          end

          # Fetches the install status of a developer mode deployment.
          #
          # @param name [String]
          #   Required. The full resource name of the deployment.
          #
          #   Example:  `projects/my_project/deployments/my_deployment/installStatus`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Gsuiteaddons::V1::InstallStatus]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Gsuiteaddons::V1::InstallStatus]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/g_suite_add_ons"
          #
          #   g_suite_add_ons_client = Google::Cloud::GSuiteAddOns.new(version: :v1)
          #   formatted_name = Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient.install_status_path("[PROJECT]", "[DEPLOYMENT]")
          #   response = g_suite_add_ons_client.get_install_status(formatted_name)

          def get_install_status \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gsuiteaddons::V1::GetInstallStatusRequest)
            @get_install_status.call(req, options, &block)
          end
        end
      end
    end
  end
end
