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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/workflows/executions/v1/executions.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/workflows/executions/v1/executions_pb"
require "google/cloud/workflows/executions/v1/credentials"

module Google
  module Cloud
    module Workflows
      module Executions
        module V1
          # Executions is used to start and manage running instances of
          # {Google::Cloud::Workflows::V1::Workflow Workflows} called executions.
          #
          # @!attribute [r] executions_stub
          #   @return [Google::Cloud::Workflows::Executions::V1::Executions::Stub]
          class ExecutionsClient
            attr_reader :executions_stub

            # The default address of the service.
            SERVICE_ADDRESS = "workflowexecutions.googleapis.com".freeze

            # The default port of the service.
            DEFAULT_SERVICE_PORT = 443

            # The default set of gRPC interceptors.
            GRPC_INTERCEPTORS = []

            DEFAULT_TIMEOUT = 30

            PAGE_DESCRIPTORS = {
              "list_executions" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "executions")
            }.freeze

            private_constant :PAGE_DESCRIPTORS

            # The scopes needed to make gRPC calls to all of the methods defined in
            # this service.
            ALL_SCOPES = [
              "https://www.googleapis.com/auth/cloud-platform"
            ].freeze


            EXECUTION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}"
            )

            private_constant :EXECUTION_PATH_TEMPLATE

            WORKFLOW_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}/workflows/{workflow}"
            )

            private_constant :WORKFLOW_PATH_TEMPLATE

            # Returns a fully-qualified execution resource name string.
            # @param project [String]
            # @param location [String]
            # @param workflow [String]
            # @param execution [String]
            # @return [String]
            def self.execution_path project, location, workflow, execution
              EXECUTION_PATH_TEMPLATE.render(
                :"project" => project,
                :"location" => location,
                :"workflow" => workflow,
                :"execution" => execution
              )
            end

            # Returns a fully-qualified workflow resource name string.
            # @param project [String]
            # @param location [String]
            # @param workflow [String]
            # @return [String]
            def self.workflow_path project, location, workflow
              WORKFLOW_PATH_TEMPLATE.render(
                :"project" => project,
                :"location" => location,
                :"workflow" => workflow
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
              require "google/cloud/workflows/executions/v1/executions_services_pb"

              credentials ||= Google::Cloud::Workflows::Executions::V1::Credentials.default

              if credentials.is_a?(String) || credentials.is_a?(Hash)
                updater_proc = Google::Cloud::Workflows::Executions::V1::Credentials.new(credentials).updater_proc
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

              package_version = Gem.loaded_specs['google-cloud-workflows-executions'].version.version

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
                "executions_client_config.json"
              )
              defaults = client_config_file.open do |f|
                Google::Gax.construct_settings(
                  "google.cloud.workflows.executions.v1.Executions",
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
              @executions_stub = Google::Gax::Grpc.create_stub(
                service_path,
                port,
                chan_creds: chan_creds,
                channel: channel,
                updater_proc: updater_proc,
                scopes: scopes,
                interceptors: interceptors,
                &Google::Cloud::Workflows::Executions::V1::Executions::Stub.method(:new)
              )

              @list_executions = Google::Gax.create_api_call(
                @executions_stub.method(:list_executions),
                defaults["list_executions"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @create_execution = Google::Gax.create_api_call(
                @executions_stub.method(:create_execution),
                defaults["create_execution"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @get_execution = Google::Gax.create_api_call(
                @executions_stub.method(:get_execution),
                defaults["get_execution"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @cancel_execution = Google::Gax.create_api_call(
                @executions_stub.method(:cancel_execution),
                defaults["cancel_execution"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
            end

            # Service calls

            # Returns a list of executions which belong to the workflow with
            # the given name. The method returns executions of all workflow
            # revisions. Returned executions are ordered by their start time (newest
            # first).
            #
            # @param parent [String]
            #   Required. Name of the workflow for which the executions should be listed.
            #   Format: projects/{project}/locations/{location}/workflows/{workflow}
            # @param page_size [Integer]
            #   The maximum number of resources contained in the underlying API
            #   response. If page streaming is performed per-resource, this
            #   parameter does not affect the return value. If page streaming is
            #   performed per-page, this determines the maximum number of
            #   resources in a page.
            # @param view [Google::Cloud::Workflows::Executions::V1::ExecutionView]
            #   Optional. A view defining which fields should be filled in the returned executions.
            #   The API will default to the BASIC view.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Workflows::Executions::V1::Execution>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Cloud::Workflows::Executions::V1::Execution>]
            #   An enumerable of Google::Cloud::Workflows::Executions::V1::Execution instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/workflows/executions"
            #
            #   executions_client = Google::Cloud::Workflows::Executions.new(version: :v1)
            #   formatted_parent = Google::Cloud::Workflows::Executions::V1::ExecutionsClient.workflow_path("[PROJECT]", "[LOCATION]", "[WORKFLOW]")
            #
            #   # Iterate over all results.
            #   executions_client.list_executions(formatted_parent).each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   executions_client.list_executions(formatted_parent).each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_executions \
                parent,
                page_size: nil,
                view: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                page_size: page_size,
                view: view
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Workflows::Executions::V1::ListExecutionsRequest)
              @list_executions.call(req, options, &block)
            end

            # Creates a new execution using the latest revision of the given workflow.
            #
            # @param parent [String]
            #   Required. Name of the workflow for which an execution should be created.
            #   Format: projects/{project}/locations/{location}/workflows/{workflow}
            #   The latest revision of the workflow will be used.
            # @param execution [Google::Cloud::Workflows::Executions::V1::Execution | Hash]
            #   Required. Execution to be created.
            #   A hash of the same form as `Google::Cloud::Workflows::Executions::V1::Execution`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Workflows::Executions::V1::Execution]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Workflows::Executions::V1::Execution]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/workflows/executions"
            #
            #   executions_client = Google::Cloud::Workflows::Executions.new(version: :v1)
            #   formatted_parent = Google::Cloud::Workflows::Executions::V1::ExecutionsClient.workflow_path("[PROJECT]", "[LOCATION]", "[WORKFLOW]")
            #
            #   # TODO: Initialize `execution`:
            #   execution = {}
            #   response = executions_client.create_execution(formatted_parent, execution)

            def create_execution \
                parent,
                execution,
                options: nil,
                &block
              req = {
                parent: parent,
                execution: execution
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Workflows::Executions::V1::CreateExecutionRequest)
              @create_execution.call(req, options, &block)
            end

            # Returns an execution of the given name.
            #
            # @param name [String]
            #   Required. Name of the execution to be retrieved.
            #   Format:
            #   projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}
            # @param view [Google::Cloud::Workflows::Executions::V1::ExecutionView]
            #   Optional. A view defining which fields should be filled in the returned execution.
            #   The API will default to the FULL view.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Workflows::Executions::V1::Execution]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Workflows::Executions::V1::Execution]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/workflows/executions"
            #
            #   executions_client = Google::Cloud::Workflows::Executions.new(version: :v1)
            #   formatted_name = Google::Cloud::Workflows::Executions::V1::ExecutionsClient.execution_path("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]")
            #   response = executions_client.get_execution(formatted_name)

            def get_execution \
                name,
                view: nil,
                options: nil,
                &block
              req = {
                name: name,
                view: view
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Workflows::Executions::V1::GetExecutionRequest)
              @get_execution.call(req, options, &block)
            end

            # Cancels an execution of the given name.
            #
            # @param name [String]
            #   Required. Name of the execution to be cancelled.
            #   Format:
            #   projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Workflows::Executions::V1::Execution]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Workflows::Executions::V1::Execution]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/workflows/executions"
            #
            #   executions_client = Google::Cloud::Workflows::Executions.new(version: :v1)
            #   formatted_name = Google::Cloud::Workflows::Executions::V1::ExecutionsClient.execution_path("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]")
            #   response = executions_client.cancel_execution(formatted_name)

            def cancel_execution \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Workflows::Executions::V1::CancelExecutionRequest)
              @cancel_execution.call(req, options, &block)
            end
          end
        end
      end
    end
  end
end
