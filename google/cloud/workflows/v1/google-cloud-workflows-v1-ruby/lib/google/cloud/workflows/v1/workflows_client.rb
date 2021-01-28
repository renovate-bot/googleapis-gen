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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/workflows/v1/workflows.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"
require "google/gax/operation"
require "google/longrunning/operations_client"

require "google/cloud/workflows/v1/workflows_pb"
require "google/cloud/workflows/v1/credentials"

module Google
  module Cloud
    module Workflows
      module V1
        # Workflows is used to deploy and execute workflow programs.
        # Workflows makes sure the program executes reliably, despite hardware and
        # networking interruptions.
        #
        # @!attribute [r] workflows_stub
        #   @return [Google::Cloud::Workflows::V1::Workflows::Stub]
        class WorkflowsClient
          attr_reader :workflows_stub

          # The default address of the service.
          SERVICE_ADDRESS = "workflows.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_workflows" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "workflows")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform"
          ].freeze

          class OperationsClient < Google::Longrunning::OperationsClient
            self::SERVICE_ADDRESS = WorkflowsClient::SERVICE_ADDRESS
            self::GRPC_INTERCEPTORS = WorkflowsClient::GRPC_INTERCEPTORS
          end

          LOCATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}"
          )

          private_constant :LOCATION_PATH_TEMPLATE

          WORKFLOW_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/workflows/{workflow}"
          )

          private_constant :WORKFLOW_PATH_TEMPLATE

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
            require "google/cloud/workflows/v1/workflows_services_pb"

            credentials ||= Google::Cloud::Workflows::V1::Credentials.default

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
              updater_proc = Google::Cloud::Workflows::V1::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-cloud-workflows'].version.version

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
              "workflows_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.workflows.v1.Workflows",
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
            @workflows_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Workflows::V1::Workflows::Stub.method(:new)
            )

            @list_workflows = Google::Gax.create_api_call(
              @workflows_stub.method(:list_workflows),
              defaults["list_workflows"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_workflow = Google::Gax.create_api_call(
              @workflows_stub.method(:get_workflow),
              defaults["get_workflow"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @create_workflow = Google::Gax.create_api_call(
              @workflows_stub.method(:create_workflow),
              defaults["create_workflow"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @delete_workflow = Google::Gax.create_api_call(
              @workflows_stub.method(:delete_workflow),
              defaults["delete_workflow"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @update_workflow = Google::Gax.create_api_call(
              @workflows_stub.method(:update_workflow),
              defaults["update_workflow"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'workflow.name' => request.workflow.name}
              end
            )
          end

          # Service calls

          # Lists Workflows in a given project and location.
          # The default order is not specified.
          #
          # @param parent [String]
          #   Required. Project and location from which the workflows should be listed.
          #   Format: projects/{project}/locations/{location}
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param filter [String]
          #   Filter to restrict results to specific workflows.
          # @param order_by [String]
          #   Comma-separated list of fields that that specify the order of the results.
          #   Default sorting order for a field is ascending. To specify descending order
          #   for a field, append a " desc" suffix.
          #   If not specified, the results will be returned in an unspecified order.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Workflows::V1::Workflow>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Workflows::V1::Workflow>]
          #   An enumerable of Google::Cloud::Workflows::V1::Workflow instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/workflows"
          #
          #   workflows_client = Google::Cloud::Workflows.new(version: :v1)
          #   formatted_parent = Google::Cloud::Workflows::V1::WorkflowsClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # Iterate over all results.
          #   workflows_client.list_workflows(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   workflows_client.list_workflows(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_workflows \
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
            req = Google::Gax::to_proto(req, Google::Cloud::Workflows::V1::ListWorkflowsRequest)
            @list_workflows.call(req, options, &block)
          end

          # Gets details of a single Workflow.
          #
          # @param name [String]
          #   Required. Name of the workflow which information should be retrieved.
          #   Format: projects/{project}/locations/{location}/workflows/{workflow}
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Workflows::V1::Workflow]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Workflows::V1::Workflow]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/workflows"
          #
          #   workflows_client = Google::Cloud::Workflows.new(version: :v1)
          #   formatted_name = Google::Cloud::Workflows::V1::WorkflowsClient.workflow_path("[PROJECT]", "[LOCATION]", "[WORKFLOW]")
          #   response = workflows_client.get_workflow(formatted_name)

          def get_workflow \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Workflows::V1::GetWorkflowRequest)
            @get_workflow.call(req, options, &block)
          end

          # Creates a new workflow. If a workflow with the specified name already
          # exists in the specified project and location, the long running operation
          # will return {Google::Rpc::Code::ALREADY_EXISTS ALREADY_EXISTS} error.
          #
          # @param parent [String]
          #   Required. Project and location in which the workflow should be created.
          #   Format:  projects/{project}/locations/{location}
          # @param workflow [Google::Cloud::Workflows::V1::Workflow | Hash]
          #   Required. Workflow to be created.
          #   A hash of the same form as `Google::Cloud::Workflows::V1::Workflow`
          #   can also be provided.
          # @param workflow_id [String]
          #   Required. The ID of the workflow to be created. It has to fulfill the
          #   following requirements:
          #
          #   * Must contain only letters, numbers, underscores and hyphens.
          #   * Must start with a letter.
          #   * Must be between 1-64 characters.
          #   * Must end with a number or a letter.
          #   * Must be unique within the customer project and location.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/workflows"
          #
          #   workflows_client = Google::Cloud::Workflows.new(version: :v1)
          #   formatted_parent = Google::Cloud::Workflows::V1::WorkflowsClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # TODO: Initialize `workflow`:
          #   workflow = {}
          #
          #   # TODO: Initialize `workflow_id`:
          #   workflow_id = ''
          #
          #   # Register a callback during the method call.
          #   operation = workflows_client.create_workflow(formatted_parent, workflow, workflow_id) do |op|
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

          def create_workflow \
              parent,
              workflow,
              workflow_id,
              options: nil
            req = {
              parent: parent,
              workflow: workflow,
              workflow_id: workflow_id
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Workflows::V1::CreateWorkflowRequest)
            operation = Google::Gax::Operation.new(
              @create_workflow.call(req, options),
              @operations_client,
              Google::Cloud::Workflows::V1::Workflow,
              Google::Cloud::Workflows::V1::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Deletes a workflow with the specified name.
          # This method also cancels and deletes all running executions of the
          # workflow.
          #
          # @param name [String]
          #   Required. Name of the workflow to be deleted.
          #   Format: projects/{project}/locations/{location}/workflows/{workflow}
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/workflows"
          #
          #   workflows_client = Google::Cloud::Workflows.new(version: :v1)
          #   formatted_name = Google::Cloud::Workflows::V1::WorkflowsClient.workflow_path("[PROJECT]", "[LOCATION]", "[WORKFLOW]")
          #
          #   # Register a callback during the method call.
          #   operation = workflows_client.delete_workflow(formatted_name) do |op|
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

          def delete_workflow \
              name,
              options: nil
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Workflows::V1::DeleteWorkflowRequest)
            operation = Google::Gax::Operation.new(
              @delete_workflow.call(req, options),
              @operations_client,
              Google::Protobuf::Empty,
              Google::Cloud::Workflows::V1::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Updates an existing workflow.
          # Running this method has no impact on already running executions of the
          # workflow. A new revision of the workflow may be created as a result of a
          # successful update operation. In that case, such revision will be used
          # in new workflow executions.
          #
          # @param workflow [Google::Cloud::Workflows::V1::Workflow | Hash]
          #   Required. Workflow to be updated.
          #   A hash of the same form as `Google::Cloud::Workflows::V1::Workflow`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   List of fields to be updated. If not present, the entire workflow
          #   will be updated.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/workflows"
          #
          #   workflows_client = Google::Cloud::Workflows.new(version: :v1)
          #
          #   # TODO: Initialize `workflow`:
          #   workflow = {}
          #
          #   # Register a callback during the method call.
          #   operation = workflows_client.update_workflow(workflow) do |op|
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

          def update_workflow \
              workflow,
              update_mask: nil,
              options: nil
            req = {
              workflow: workflow,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Workflows::V1::UpdateWorkflowRequest)
            operation = Google::Gax::Operation.new(
              @update_workflow.call(req, options),
              @operations_client,
              Google::Cloud::Workflows::V1::Workflow,
              Google::Cloud::Workflows::V1::OperationMetadata,
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
