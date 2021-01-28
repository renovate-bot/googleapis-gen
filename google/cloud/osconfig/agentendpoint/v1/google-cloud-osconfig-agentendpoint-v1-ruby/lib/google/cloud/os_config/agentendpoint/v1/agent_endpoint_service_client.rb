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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/osconfig/agentendpoint/v1/agentendpoint.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/osconfig/agentendpoint/v1/agentendpoint_pb"
require "google/cloud/os_config/agentendpoint/v1/credentials"

module Google
  module Cloud
    module OsConfig
      module Agentendpoint
        module V1
          # OS Config agent endpoint API.
          #
          # @!attribute [r] agent_endpoint_service_stub
          #   @return [Google::Cloud::Osconfig::Agentendpoint::V1::AgentEndpointService::Stub]
          class AgentEndpointServiceClient
            attr_reader :agent_endpoint_service_stub

            # The default address of the service.
            SERVICE_ADDRESS = "osconfig.googleapis.com".freeze

            # The default port of the service.
            DEFAULT_SERVICE_PORT = 443

            # The default set of gRPC interceptors.
            GRPC_INTERCEPTORS = []

            DEFAULT_TIMEOUT = 30

            # The scopes needed to make gRPC calls to all of the methods defined in
            # this service.
            ALL_SCOPES = [
            ].freeze


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
              require "google/cloud/osconfig/agentendpoint/v1/agentendpoint_services_pb"

              credentials ||= Google::Cloud::OsConfig::Agentendpoint::V1::Credentials.default

              if credentials.is_a?(String) || credentials.is_a?(Hash)
                updater_proc = Google::Cloud::OsConfig::Agentendpoint::V1::Credentials.new(credentials).updater_proc
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

              package_version = Gem.loaded_specs['google-cloud-os_config-agentendpoint'].version.version

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
                "agent_endpoint_service_client_config.json"
              )
              defaults = client_config_file.open do |f|
                Google::Gax.construct_settings(
                  "google.cloud.osconfig.agentendpoint.v1.AgentEndpointService",
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
              @agent_endpoint_service_stub = Google::Gax::Grpc.create_stub(
                service_path,
                port,
                chan_creds: chan_creds,
                channel: channel,
                updater_proc: updater_proc,
                scopes: scopes,
                interceptors: interceptors,
                &Google::Cloud::Osconfig::Agentendpoint::V1::AgentEndpointService::Stub.method(:new)
              )

              @receive_task_notification = Google::Gax.create_api_call(
                @agent_endpoint_service_stub.method(:receive_task_notification),
                defaults["receive_task_notification"],
                exception_transformer: exception_transformer
              )
              @start_next_task = Google::Gax.create_api_call(
                @agent_endpoint_service_stub.method(:start_next_task),
                defaults["start_next_task"],
                exception_transformer: exception_transformer
              )
              @report_task_progress = Google::Gax.create_api_call(
                @agent_endpoint_service_stub.method(:report_task_progress),
                defaults["report_task_progress"],
                exception_transformer: exception_transformer
              )
              @report_task_complete = Google::Gax.create_api_call(
                @agent_endpoint_service_stub.method(:report_task_complete),
                defaults["report_task_complete"],
                exception_transformer: exception_transformer
              )
              @register_agent = Google::Gax.create_api_call(
                @agent_endpoint_service_stub.method(:register_agent),
                defaults["register_agent"],
                exception_transformer: exception_transformer
              )
              @report_inventory = Google::Gax.create_api_call(
                @agent_endpoint_service_stub.method(:report_inventory),
                defaults["report_inventory"],
                exception_transformer: exception_transformer
              )
            end

            # Service calls

            # Stream established by client to receive Task notifications.
            #
            # @param instance_id_token [String]
            #   Required. This is the Compute Engine instance identity token described in
            #   https://cloud.google.com/compute/docs/instances/verifying-instance-identity
            #   where the audience is 'osconfig.googleapis.com' and the format is 'full'.
            # @param agent_version [String]
            #   Required. The version of the agent making the request.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @return [Enumerable<Google::Cloud::Osconfig::Agentendpoint::V1::ReceiveTaskNotificationResponse>]
            #   An enumerable of Google::Cloud::Osconfig::Agentendpoint::V1::ReceiveTaskNotificationResponse instances.
            #
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/os_config/agentendpoint"
            #
            #   agent_endpoint_client = Google::Cloud::OsConfig::Agentendpoint.new(version: :v1)
            #
            #   # TODO: Initialize `instance_id_token`:
            #   instance_id_token = ''
            #
            #   # TODO: Initialize `agent_version`:
            #   agent_version = ''
            #   agent_endpoint_client.receive_task_notification(instance_id_token, agent_version).each do |element|
            #     # Process element.
            #   end

            def receive_task_notification \
                instance_id_token,
                agent_version,
                options: nil
              req = {
                instance_id_token: instance_id_token,
                agent_version: agent_version
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Osconfig::Agentendpoint::V1::ReceiveTaskNotificationRequest)
              @receive_task_notification.call(req, options)
            end

            # Signals the start of a task execution and returns the task info.
            #
            # @param instance_id_token [String]
            #   Required. This is the Compute Engine instance identity token described in
            #   https://cloud.google.com/compute/docs/instances/verifying-instance-identity
            #   where the audience is 'osconfig.googleapis.com' and the format is 'full'.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Osconfig::Agentendpoint::V1::StartNextTaskResponse]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Osconfig::Agentendpoint::V1::StartNextTaskResponse]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/os_config/agentendpoint"
            #
            #   agent_endpoint_client = Google::Cloud::OsConfig::Agentendpoint.new(version: :v1)
            #
            #   # TODO: Initialize `instance_id_token`:
            #   instance_id_token = ''
            #   response = agent_endpoint_client.start_next_task(instance_id_token)

            def start_next_task \
                instance_id_token,
                options: nil,
                &block
              req = {
                instance_id_token: instance_id_token
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Osconfig::Agentendpoint::V1::StartNextTaskRequest)
              @start_next_task.call(req, options, &block)
            end

            # Signals an intermediary progress checkpoint in task execution.
            #
            # @param instance_id_token [String]
            #   Required. This is the Compute Engine instance identity token described in
            #   https://cloud.google.com/compute/docs/instances/verifying-instance-identity
            #   where the audience is 'osconfig.googleapis.com' and the format is 'full'.
            # @param task_id [String]
            #   Required. Unique identifier of the task this applies to.
            # @param task_type [Google::Cloud::Osconfig::Agentendpoint::V1::TaskType]
            #   Required. The type of task to report progress on.
            #
            #   Progress must include the appropriate message based on this enum as
            #   specified below:
            #   APPLY_PATCHES = ApplyPatchesTaskProgress
            #   EXEC_STEP = Progress not supported for this type.
            # @param apply_patches_task_progress [Google::Cloud::Osconfig::Agentendpoint::V1::ApplyPatchesTaskProgress | Hash]
            #   Details about the progress of the apply patches task.
            #   A hash of the same form as `Google::Cloud::Osconfig::Agentendpoint::V1::ApplyPatchesTaskProgress`
            #   can also be provided.
            # @param exec_step_task_progress [Google::Cloud::Osconfig::Agentendpoint::V1::ExecStepTaskProgress | Hash]
            #   Details about the progress of the exec step task.
            #   A hash of the same form as `Google::Cloud::Osconfig::Agentendpoint::V1::ExecStepTaskProgress`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Osconfig::Agentendpoint::V1::ReportTaskProgressResponse]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Osconfig::Agentendpoint::V1::ReportTaskProgressResponse]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/os_config/agentendpoint"
            #
            #   agent_endpoint_client = Google::Cloud::OsConfig::Agentendpoint.new(version: :v1)
            #
            #   # TODO: Initialize `instance_id_token`:
            #   instance_id_token = ''
            #
            #   # TODO: Initialize `task_id`:
            #   task_id = ''
            #
            #   # TODO: Initialize `task_type`:
            #   task_type = :TASK_TYPE_UNSPECIFIED
            #   response = agent_endpoint_client.report_task_progress(instance_id_token, task_id, task_type)

            def report_task_progress \
                instance_id_token,
                task_id,
                task_type,
                apply_patches_task_progress: nil,
                exec_step_task_progress: nil,
                options: nil,
                &block
              req = {
                instance_id_token: instance_id_token,
                task_id: task_id,
                task_type: task_type,
                apply_patches_task_progress: apply_patches_task_progress,
                exec_step_task_progress: exec_step_task_progress
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Osconfig::Agentendpoint::V1::ReportTaskProgressRequest)
              @report_task_progress.call(req, options, &block)
            end

            # Signals that the task execution is complete and optionally returns the next
            # task.
            #
            # @param instance_id_token [String]
            #   Required. This is the Compute Engine instance identity token described in
            #   https://cloud.google.com/compute/docs/instances/verifying-instance-identity
            #   where the audience is 'osconfig.googleapis.com' and the format is 'full'.
            # @param task_id [String]
            #   Required. Unique identifier of the task this applies to.
            # @param task_type [Google::Cloud::Osconfig::Agentendpoint::V1::TaskType]
            #   Required. The type of task to report completed.
            #
            #   The output must include the appropriate message based on the following
            #   enum values:
            #   APPLY_PATCHES = ApplyPatchesTaskOutput
            #   EXEC_STEP = ExecStepTaskOutput
            # @param error_message [String]
            #   Descriptive error message if the task execution ended in error.
            # @param apply_patches_task_output [Google::Cloud::Osconfig::Agentendpoint::V1::ApplyPatchesTaskOutput | Hash]
            #   Final output details of the apply patches task;
            #   A hash of the same form as `Google::Cloud::Osconfig::Agentendpoint::V1::ApplyPatchesTaskOutput`
            #   can also be provided.
            # @param exec_step_task_output [Google::Cloud::Osconfig::Agentendpoint::V1::ExecStepTaskOutput | Hash]
            #   Final output details of the exec step task;
            #   A hash of the same form as `Google::Cloud::Osconfig::Agentendpoint::V1::ExecStepTaskOutput`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Osconfig::Agentendpoint::V1::ReportTaskCompleteResponse]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Osconfig::Agentendpoint::V1::ReportTaskCompleteResponse]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/os_config/agentendpoint"
            #
            #   agent_endpoint_client = Google::Cloud::OsConfig::Agentendpoint.new(version: :v1)
            #
            #   # TODO: Initialize `instance_id_token`:
            #   instance_id_token = ''
            #
            #   # TODO: Initialize `task_id`:
            #   task_id = ''
            #
            #   # TODO: Initialize `task_type`:
            #   task_type = :TASK_TYPE_UNSPECIFIED
            #   response = agent_endpoint_client.report_task_complete(instance_id_token, task_id, task_type)

            def report_task_complete \
                instance_id_token,
                task_id,
                task_type,
                error_message: nil,
                apply_patches_task_output: nil,
                exec_step_task_output: nil,
                options: nil,
                &block
              req = {
                instance_id_token: instance_id_token,
                task_id: task_id,
                task_type: task_type,
                error_message: error_message,
                apply_patches_task_output: apply_patches_task_output,
                exec_step_task_output: exec_step_task_output
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Osconfig::Agentendpoint::V1::ReportTaskCompleteRequest)
              @report_task_complete.call(req, options, &block)
            end

            # Registers the agent running on the VM.
            #
            # @param instance_id_token [String]
            #   Required. This is the Compute Engine instance identity token described in
            #   https://cloud.google.com/compute/docs/instances/verifying-instance-identity
            #   where the audience is 'osconfig.googleapis.com' and the format is 'full'.
            # @param agent_version [String]
            #   Required. The version of the agent.
            # @param supported_capabilities [Array<String>]
            #   Required. The capabilities supported by the agent. Supported values are:
            #   PATCH_GA
            #   GUEST_POLICY_BETA
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Osconfig::Agentendpoint::V1::RegisterAgentResponse]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Osconfig::Agentendpoint::V1::RegisterAgentResponse]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/os_config/agentendpoint"
            #
            #   agent_endpoint_client = Google::Cloud::OsConfig::Agentendpoint.new(version: :v1)
            #
            #   # TODO: Initialize `instance_id_token`:
            #   instance_id_token = ''
            #
            #   # TODO: Initialize `agent_version`:
            #   agent_version = ''
            #
            #   # TODO: Initialize `supported_capabilities`:
            #   supported_capabilities = []
            #   response = agent_endpoint_client.register_agent(instance_id_token, agent_version, supported_capabilities)

            def register_agent \
                instance_id_token,
                agent_version,
                supported_capabilities,
                options: nil,
                &block
              req = {
                instance_id_token: instance_id_token,
                agent_version: agent_version,
                supported_capabilities: supported_capabilities
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Osconfig::Agentendpoint::V1::RegisterAgentRequest)
              @register_agent.call(req, options, &block)
            end

            # Reports the VMs current inventory.
            #
            # @param instance_id_token [String]
            #   Required. This is the Compute Engine instance identity token described in
            #   https://cloud.google.com/compute/docs/instances/verifying-instance-identity
            #   where the audience is 'osconfig.googleapis.com' and the format is 'full'.
            # @param inventory_checksum [String]
            #   Required. This is a client created checksum that should be generated based on the
            #   contents of the reported inventory.  This will be used by the service to
            #   determine if it has the latest version of inventory.
            # @param inventory [Google::Cloud::Osconfig::Agentendpoint::V1::Inventory | Hash]
            #   Optional. This is the details of the inventory.  Should only be provided if the
            #   inventory has changed since the last report, or if instructed by the
            #   service to provide full inventory.
            #   A hash of the same form as `Google::Cloud::Osconfig::Agentendpoint::V1::Inventory`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Osconfig::Agentendpoint::V1::ReportInventoryResponse]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Osconfig::Agentendpoint::V1::ReportInventoryResponse]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/os_config/agentendpoint"
            #
            #   agent_endpoint_client = Google::Cloud::OsConfig::Agentendpoint.new(version: :v1)
            #
            #   # TODO: Initialize `instance_id_token`:
            #   instance_id_token = ''
            #
            #   # TODO: Initialize `inventory_checksum`:
            #   inventory_checksum = ''
            #   response = agent_endpoint_client.report_inventory(instance_id_token, inventory_checksum)

            def report_inventory \
                instance_id_token,
                inventory_checksum,
                inventory: nil,
                options: nil,
                &block
              req = {
                instance_id_token: instance_id_token,
                inventory_checksum: inventory_checksum,
                inventory: inventory
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Osconfig::Agentendpoint::V1::ReportInventoryRequest)
              @report_inventory.call(req, options, &block)
            end
          end
        end
      end
    end
  end
end
