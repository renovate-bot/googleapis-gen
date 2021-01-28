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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/osconfig/v1beta/osconfig_service.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/osconfig/v1beta/osconfig_service_pb"
require "google/cloud/os_config/v1beta/credentials"

module Google
  module Cloud
    module OsConfig
      module V1beta
        # OS Config API
        #
        # The OS Config service is a server-side component that you can use to
        # manage package installations and patch jobs for virtual machine instances.
        #
        # @!attribute [r] os_config_service_stub
        #   @return [Google::Cloud::Osconfig::V1beta::OsConfigService::Stub]
        class OsConfigServiceClient
          attr_reader :os_config_service_stub

          # The default address of the service.
          SERVICE_ADDRESS = "osconfig.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_patch_jobs" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "patch_jobs"),
            "list_patch_job_instance_details" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "patch_job_instance_details"),
            "list_patch_deployments" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "patch_deployments"),
            "list_guest_policies" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "guest_policies")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform"
          ].freeze


          GUEST_POLICY_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/guestPolicies/{guest_policy}"
          )

          private_constant :GUEST_POLICY_PATH_TEMPLATE

          PROJECT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}"
          )

          private_constant :PROJECT_PATH_TEMPLATE

          # Returns a fully-qualified guest_policy resource name string.
          # @param project [String]
          # @param guest_policy [String]
          # @return [String]
          def self.guest_policy_path project, guest_policy
            GUEST_POLICY_PATH_TEMPLATE.render(
              :"project" => project,
              :"guest_policy" => guest_policy
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
            require "google/cloud/osconfig/v1beta/osconfig_service_services_pb"

            credentials ||= Google::Cloud::OsConfig::V1beta::Credentials.default

            if credentials.is_a?(String) || credentials.is_a?(Hash)
              updater_proc = Google::Cloud::OsConfig::V1beta::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-cloud-os_config'].version.version

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
              "os_config_service_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.osconfig.v1beta.OsConfigService",
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
            @os_config_service_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.method(:new)
            )

            @delete_patch_deployment = Google::Gax.create_api_call(
              @os_config_service_stub.method(:delete_patch_deployment),
              defaults["delete_patch_deployment"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @delete_guest_policy = Google::Gax.create_api_call(
              @os_config_service_stub.method(:delete_guest_policy),
              defaults["delete_guest_policy"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @execute_patch_job = Google::Gax.create_api_call(
              @os_config_service_stub.method(:execute_patch_job),
              defaults["execute_patch_job"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_patch_job = Google::Gax.create_api_call(
              @os_config_service_stub.method(:get_patch_job),
              defaults["get_patch_job"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @cancel_patch_job = Google::Gax.create_api_call(
              @os_config_service_stub.method(:cancel_patch_job),
              defaults["cancel_patch_job"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_patch_jobs = Google::Gax.create_api_call(
              @os_config_service_stub.method(:list_patch_jobs),
              defaults["list_patch_jobs"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @list_patch_job_instance_details = Google::Gax.create_api_call(
              @os_config_service_stub.method(:list_patch_job_instance_details),
              defaults["list_patch_job_instance_details"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @create_patch_deployment = Google::Gax.create_api_call(
              @os_config_service_stub.method(:create_patch_deployment),
              defaults["create_patch_deployment"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_patch_deployment = Google::Gax.create_api_call(
              @os_config_service_stub.method(:get_patch_deployment),
              defaults["get_patch_deployment"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_patch_deployments = Google::Gax.create_api_call(
              @os_config_service_stub.method(:list_patch_deployments),
              defaults["list_patch_deployments"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @create_guest_policy = Google::Gax.create_api_call(
              @os_config_service_stub.method(:create_guest_policy),
              defaults["create_guest_policy"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_guest_policy = Google::Gax.create_api_call(
              @os_config_service_stub.method(:get_guest_policy),
              defaults["get_guest_policy"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_guest_policies = Google::Gax.create_api_call(
              @os_config_service_stub.method(:list_guest_policies),
              defaults["list_guest_policies"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @update_guest_policy = Google::Gax.create_api_call(
              @os_config_service_stub.method(:update_guest_policy),
              defaults["update_guest_policy"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'guest_policy.name' => request.guest_policy.name}
              end
            )
            @lookup_effective_guest_policy = Google::Gax.create_api_call(
              @os_config_service_stub.method(:lookup_effective_guest_policy),
              defaults["lookup_effective_guest_policy"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'instance' => request.instance}
              end
            )
          end

          # Service calls

          # Delete an OS Config patch deployment.
          #
          # @param name [String]
          #   Required. The resource name of the patch deployment in the form
          #   `projects/*/patchDeployments/*`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/os_config"
          #
          #   os_config_client = Google::Cloud::OsConfig::V1beta.new(version: :v1beta)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #   os_config_client.delete_patch_deployment(name)

          def delete_patch_deployment \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Osconfig::V1beta::DeletePatchDeploymentRequest)
            @delete_patch_deployment.call(req, options, &block)
            nil
          end

          # Delete an OS Config guest policy.
          #
          # @param name [String]
          #   Required. The resource name of the guest policy  using one of the following forms:
          #   `projects/{project_number}/guestPolicies/{guest_policy_id}`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/os_config"
          #
          #   os_config_client = Google::Cloud::OsConfig::V1beta.new(version: :v1beta)
          #   formatted_name = Google::Cloud::OsConfig::V1beta::OsConfigServiceClient.guest_policy_path("[PROJECT]", "[GUEST_POLICY]")
          #   os_config_client.delete_guest_policy(formatted_name)

          def delete_guest_policy \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Osconfig::V1beta::DeleteGuestPolicyRequest)
            @delete_guest_policy.call(req, options, &block)
            nil
          end

          # Patch VM instances by creating and running a patch job.
          #
          # @param parent [String]
          #   Required. The project in which to run this patch in the form `projects/*`
          # @param instance_filter [Google::Cloud::Osconfig::V1beta::PatchInstanceFilter | Hash]
          #   Required. Instances to patch, either explicitly or filtered by some criteria such
          #   as zone or labels.
          #   A hash of the same form as `Google::Cloud::Osconfig::V1beta::PatchInstanceFilter`
          #   can also be provided.
          # @param description [String]
          #   Description of the patch job. Length of the description is limited
          #   to 1024 characters.
          # @param patch_config [Google::Cloud::Osconfig::V1beta::PatchConfig | Hash]
          #   Patch configuration being applied. If omitted, instances are
          #   patched using the default configurations.
          #   A hash of the same form as `Google::Cloud::Osconfig::V1beta::PatchConfig`
          #   can also be provided.
          # @param duration [Google::Protobuf::Duration | Hash]
          #   Duration of the patch job. After the duration ends, the patch job
          #   times out.
          #   A hash of the same form as `Google::Protobuf::Duration`
          #   can also be provided.
          # @param dry_run [true, false]
          #   If this patch is a dry-run only, instances are contacted but
          #   will do nothing.
          # @param display_name [String]
          #   Display name for this patch job. This does not have to be unique.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Osconfig::V1beta::PatchJob]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Osconfig::V1beta::PatchJob]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/os_config"
          #
          #   os_config_client = Google::Cloud::OsConfig::V1beta.new(version: :v1beta)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #
          #   # TODO: Initialize `instance_filter`:
          #   instance_filter = {}
          #   response = os_config_client.execute_patch_job(parent, instance_filter)

          def execute_patch_job \
              parent,
              instance_filter,
              description: nil,
              patch_config: nil,
              duration: nil,
              dry_run: nil,
              display_name: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              instance_filter: instance_filter,
              description: description,
              patch_config: patch_config,
              duration: duration,
              dry_run: dry_run,
              display_name: display_name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Osconfig::V1beta::ExecutePatchJobRequest)
            @execute_patch_job.call(req, options, &block)
          end

          # Get the patch job. This can be used to track the progress of an
          # ongoing patch job or review the details of completed jobs.
          #
          # @param name [String]
          #   Required. Name of the patch in the form `projects/*/patchJobs/*`
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Osconfig::V1beta::PatchJob]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Osconfig::V1beta::PatchJob]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/os_config"
          #
          #   os_config_client = Google::Cloud::OsConfig::V1beta.new(version: :v1beta)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #   response = os_config_client.get_patch_job(name)

          def get_patch_job \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Osconfig::V1beta::GetPatchJobRequest)
            @get_patch_job.call(req, options, &block)
          end

          # Cancel a patch job. The patch job must be active. Canceled patch jobs
          # cannot be restarted.
          #
          # @param name [String]
          #   Required. Name of the patch in the form `projects/*/patchJobs/*`
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Osconfig::V1beta::PatchJob]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Osconfig::V1beta::PatchJob]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/os_config"
          #
          #   os_config_client = Google::Cloud::OsConfig::V1beta.new(version: :v1beta)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #   response = os_config_client.cancel_patch_job(name)

          def cancel_patch_job \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Osconfig::V1beta::CancelPatchJobRequest)
            @cancel_patch_job.call(req, options, &block)
          end

          # Get a list of patch jobs.
          #
          # @param parent [String]
          #   Required. In the form of `projects/*`
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param filter [String]
          #   If provided, this field specifies the criteria that must be met by patch
          #   jobs to be included in the response.
          #   Currently, filtering is only available on the patch_deployment field.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Osconfig::V1beta::PatchJob>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Osconfig::V1beta::PatchJob>]
          #   An enumerable of Google::Cloud::Osconfig::V1beta::PatchJob instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/os_config"
          #
          #   os_config_client = Google::Cloud::OsConfig::V1beta.new(version: :v1beta)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #
          #   # Iterate over all results.
          #   os_config_client.list_patch_jobs(parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   os_config_client.list_patch_jobs(parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_patch_jobs \
              parent,
              page_size: nil,
              filter: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size,
              filter: filter
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Osconfig::V1beta::ListPatchJobsRequest)
            @list_patch_jobs.call(req, options, &block)
          end

          # Get a list of instance details for a given patch job.
          #
          # @param parent [String]
          #   Required. The parent for the instances are in the form of `projects/*/patchJobs/*`.
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param filter [String]
          #   A filter expression that filters results listed in the response. This
          #   field supports filtering results by instance zone, name, state, or
          #   `failure_reason`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Osconfig::V1beta::PatchJobInstanceDetails>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Osconfig::V1beta::PatchJobInstanceDetails>]
          #   An enumerable of Google::Cloud::Osconfig::V1beta::PatchJobInstanceDetails instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/os_config"
          #
          #   os_config_client = Google::Cloud::OsConfig::V1beta.new(version: :v1beta)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #
          #   # Iterate over all results.
          #   os_config_client.list_patch_job_instance_details(parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   os_config_client.list_patch_job_instance_details(parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_patch_job_instance_details \
              parent,
              page_size: nil,
              filter: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size,
              filter: filter
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Osconfig::V1beta::ListPatchJobInstanceDetailsRequest)
            @list_patch_job_instance_details.call(req, options, &block)
          end

          # Create an OS Config patch deployment.
          #
          # @param parent [String]
          #   Required. The project to apply this patch deployment to in the form `projects/*`.
          # @param patch_deployment_id [String]
          #   Required. A name for the patch deployment in the project. When creating a name
          #   the following rules apply:
          #   * Must contain only lowercase letters, numbers, and hyphens.
          #   * Must start with a letter.
          #   * Must be between 1-63 characters.
          #   * Must end with a number or a letter.
          #   * Must be unique within the project.
          # @param patch_deployment [Google::Cloud::Osconfig::V1beta::PatchDeployment | Hash]
          #   Required. The patch deployment to create.
          #   A hash of the same form as `Google::Cloud::Osconfig::V1beta::PatchDeployment`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Osconfig::V1beta::PatchDeployment]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Osconfig::V1beta::PatchDeployment]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/os_config"
          #
          #   os_config_client = Google::Cloud::OsConfig::V1beta.new(version: :v1beta)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #
          #   # TODO: Initialize `patch_deployment_id`:
          #   patch_deployment_id = ''
          #
          #   # TODO: Initialize `patch_deployment`:
          #   patch_deployment = {}
          #   response = os_config_client.create_patch_deployment(parent, patch_deployment_id, patch_deployment)

          def create_patch_deployment \
              parent,
              patch_deployment_id,
              patch_deployment,
              options: nil,
              &block
            req = {
              parent: parent,
              patch_deployment_id: patch_deployment_id,
              patch_deployment: patch_deployment
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Osconfig::V1beta::CreatePatchDeploymentRequest)
            @create_patch_deployment.call(req, options, &block)
          end

          # Get an OS Config patch deployment.
          #
          # @param name [String]
          #   Required. The resource name of the patch deployment in the form
          #   `projects/*/patchDeployments/*`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Osconfig::V1beta::PatchDeployment]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Osconfig::V1beta::PatchDeployment]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/os_config"
          #
          #   os_config_client = Google::Cloud::OsConfig::V1beta.new(version: :v1beta)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #   response = os_config_client.get_patch_deployment(name)

          def get_patch_deployment \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Osconfig::V1beta::GetPatchDeploymentRequest)
            @get_patch_deployment.call(req, options, &block)
          end

          # Get a page of OS Config patch deployments.
          #
          # @param parent [String]
          #   Required. The resource name of the parent in the form `projects/*`.
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Osconfig::V1beta::PatchDeployment>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Osconfig::V1beta::PatchDeployment>]
          #   An enumerable of Google::Cloud::Osconfig::V1beta::PatchDeployment instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/os_config"
          #
          #   os_config_client = Google::Cloud::OsConfig::V1beta.new(version: :v1beta)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #
          #   # Iterate over all results.
          #   os_config_client.list_patch_deployments(parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   os_config_client.list_patch_deployments(parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_patch_deployments \
              parent,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Osconfig::V1beta::ListPatchDeploymentsRequest)
            @list_patch_deployments.call(req, options, &block)
          end

          # Create an OS Config guest policy.
          #
          # @param parent [String]
          #   Required. The resource name of the parent using one of the following forms:
          #   `projects/{project_number}`.
          # @param guest_policy_id [String]
          #   Required. The logical name of the guest policy in the project
          #   with the following restrictions:
          #
          #   * Must contain only lowercase letters, numbers, and hyphens.
          #   * Must start with a letter.
          #   * Must be between 1-63 characters.
          #   * Must end with a number or a letter.
          #   * Must be unique within the project.
          # @param guest_policy [Google::Cloud::Osconfig::V1beta::GuestPolicy | Hash]
          #   Required. The GuestPolicy to create.
          #   A hash of the same form as `Google::Cloud::Osconfig::V1beta::GuestPolicy`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Osconfig::V1beta::GuestPolicy]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Osconfig::V1beta::GuestPolicy]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/os_config"
          #
          #   os_config_client = Google::Cloud::OsConfig::V1beta.new(version: :v1beta)
          #   formatted_parent = Google::Cloud::OsConfig::V1beta::OsConfigServiceClient.project_path("[PROJECT]")
          #
          #   # TODO: Initialize `guest_policy_id`:
          #   guest_policy_id = ''
          #
          #   # TODO: Initialize `guest_policy`:
          #   guest_policy = {}
          #   response = os_config_client.create_guest_policy(formatted_parent, guest_policy_id, guest_policy)

          def create_guest_policy \
              parent,
              guest_policy_id,
              guest_policy,
              options: nil,
              &block
            req = {
              parent: parent,
              guest_policy_id: guest_policy_id,
              guest_policy: guest_policy
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Osconfig::V1beta::CreateGuestPolicyRequest)
            @create_guest_policy.call(req, options, &block)
          end

          # Get an OS Config guest policy.
          #
          # @param name [String]
          #   Required. The resource name of the guest policy using one of the following forms:
          #   `projects/{project_number}/guestPolicies/{guest_policy_id}`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Osconfig::V1beta::GuestPolicy]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Osconfig::V1beta::GuestPolicy]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/os_config"
          #
          #   os_config_client = Google::Cloud::OsConfig::V1beta.new(version: :v1beta)
          #   formatted_name = Google::Cloud::OsConfig::V1beta::OsConfigServiceClient.guest_policy_path("[PROJECT]", "[GUEST_POLICY]")
          #   response = os_config_client.get_guest_policy(formatted_name)

          def get_guest_policy \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Osconfig::V1beta::GetGuestPolicyRequest)
            @get_guest_policy.call(req, options, &block)
          end

          # Get a page of OS Config guest policies.
          #
          # @param parent [String]
          #   Required. The resource name of the parent using one of the following forms:
          #   `projects/{project_number}`.
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Osconfig::V1beta::GuestPolicy>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Osconfig::V1beta::GuestPolicy>]
          #   An enumerable of Google::Cloud::Osconfig::V1beta::GuestPolicy instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/os_config"
          #
          #   os_config_client = Google::Cloud::OsConfig::V1beta.new(version: :v1beta)
          #   formatted_parent = Google::Cloud::OsConfig::V1beta::OsConfigServiceClient.project_path("[PROJECT]")
          #
          #   # Iterate over all results.
          #   os_config_client.list_guest_policies(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   os_config_client.list_guest_policies(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_guest_policies \
              parent,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Osconfig::V1beta::ListGuestPoliciesRequest)
            @list_guest_policies.call(req, options, &block)
          end

          # Update an OS Config guest policy.
          #
          # @param guest_policy [Google::Cloud::Osconfig::V1beta::GuestPolicy | Hash]
          #   Required. The updated GuestPolicy.
          #   A hash of the same form as `Google::Cloud::Osconfig::V1beta::GuestPolicy`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Field mask that controls which fields of the guest policy should be
          #   updated.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Osconfig::V1beta::GuestPolicy]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Osconfig::V1beta::GuestPolicy]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/os_config"
          #
          #   os_config_client = Google::Cloud::OsConfig::V1beta.new(version: :v1beta)
          #
          #   # TODO: Initialize `guest_policy`:
          #   guest_policy = {}
          #   response = os_config_client.update_guest_policy(guest_policy)

          def update_guest_policy \
              guest_policy,
              update_mask: nil,
              options: nil,
              &block
            req = {
              guest_policy: guest_policy,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Osconfig::V1beta::UpdateGuestPolicyRequest)
            @update_guest_policy.call(req, options, &block)
          end

          # Lookup the effective guest policy that applies to a VM instance. This
          # lookup merges all policies that are assigned to the instance ancestry.
          #
          # @param instance [String]
          #   Required. The VM instance whose policies are being looked up.
          # @param os_short_name [String]
          #   Short name of the OS running on the instance. The OS Config agent only
          #   provides this field for targeting if OS Inventory is enabled for that
          #   instance.
          # @param os_version [String]
          #   Version of the OS running on the instance. The OS Config agent only
          #   provides this field for targeting if OS Inventory is enabled for that
          #   VM instance.
          # @param os_architecture [String]
          #   Architecture of OS running on the instance. The OS Config agent only
          #   provides this field for targeting if OS Inventory is enabled for that
          #   instance.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Osconfig::V1beta::EffectiveGuestPolicy]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Osconfig::V1beta::EffectiveGuestPolicy]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/os_config"
          #
          #   os_config_client = Google::Cloud::OsConfig::V1beta.new(version: :v1beta)
          #
          #   # TODO: Initialize `instance`:
          #   instance = ''
          #   response = os_config_client.lookup_effective_guest_policy(instance)

          def lookup_effective_guest_policy \
              instance,
              os_short_name: nil,
              os_version: nil,
              os_architecture: nil,
              options: nil,
              &block
            req = {
              instance: instance,
              os_short_name: os_short_name,
              os_version: os_version,
              os_architecture: os_architecture
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Osconfig::V1beta::LookupEffectiveGuestPolicyRequest)
            @lookup_effective_guest_policy.call(req, options, &block)
          end
        end
      end
    end
  end
end
