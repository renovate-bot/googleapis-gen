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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/orgpolicy/v2/orgpolicy.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/orgpolicy/v2/orgpolicy_pb"
require "google/cloud/orgpolicy/v2/credentials"

module Google
  module Cloud
    module Orgpolicy
      module V2
        # An interface for managing organization policies.
        #
        # The Cloud Org Policy service provides a simple mechanism for organizations to
        # restrict the allowed configurations across their entire Cloud Resource
        # hierarchy.
        #
        # You can use a `policy` to configure restrictions in Cloud resources. For
        # example, you can enforce a `policy` that restricts which Google
        # Cloud Platform APIs can be activated in a certain part of your resource
        # hierarchy, or prevents serial port access to VM instances in a particular
        # folder.
        #
        # `Policies` are inherited down through the resource hierarchy. A `policy`
        # applied to a parent resource automatically applies to all its child resources
        # unless overridden with a `policy` lower in the hierarchy.
        #
        # A `constraint` defines an aspect of a resource's configuration that can be
        # controlled by an organization's policy administrator. `Policies` are a
        # collection of `constraints` that defines their allowable configuration on a
        # particular resource and its child resources.
        #
        # @!attribute [r] org_policy_stub
        #   @return [Google::Cloud::Orgpolicy::V2::OrgPolicy::Stub]
        class OrgPolicyClient
          attr_reader :org_policy_stub

          # The default address of the service.
          SERVICE_ADDRESS = "orgpolicy.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_constraints" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "constraints"),
            "list_policies" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "policies")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platforma"
          ].freeze


          FOLDER_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "folders/{folder}"
          )

          private_constant :FOLDER_PATH_TEMPLATE

          ORGANIZATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "organizations/{organization}"
          )

          private_constant :ORGANIZATION_PATH_TEMPLATE

          POLICY_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/policies/{policy}"
          )

          private_constant :POLICY_PATH_TEMPLATE

          PROJECT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}"
          )

          private_constant :PROJECT_PATH_TEMPLATE

          # Returns a fully-qualified folder resource name string.
          # @param folder [String]
          # @return [String]
          def self.folder_path folder
            FOLDER_PATH_TEMPLATE.render(
              :"folder" => folder
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

          # Returns a fully-qualified policy resource name string.
          # @param project [String]
          # @param policy [String]
          # @return [String]
          def self.policy_path project, policy
            POLICY_PATH_TEMPLATE.render(
              :"project" => project,
              :"policy" => policy
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
            require "google/cloud/orgpolicy/v2/orgpolicy_services_pb"

            credentials ||= Google::Cloud::Orgpolicy::V2::Credentials.default

            if credentials.is_a?(String) || credentials.is_a?(Hash)
              updater_proc = Google::Cloud::Orgpolicy::V2::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-cloud-orgpolicy'].version.version

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
              "org_policy_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.orgpolicy.v2.OrgPolicy",
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
            @org_policy_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Orgpolicy::V2::OrgPolicy::Stub.method(:new)
            )

            @list_constraints = Google::Gax.create_api_call(
              @org_policy_stub.method(:list_constraints),
              defaults["list_constraints"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @list_policies = Google::Gax.create_api_call(
              @org_policy_stub.method(:list_policies),
              defaults["list_policies"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_policy = Google::Gax.create_api_call(
              @org_policy_stub.method(:get_policy),
              defaults["get_policy"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @get_effective_policy = Google::Gax.create_api_call(
              @org_policy_stub.method(:get_effective_policy),
              defaults["get_effective_policy"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @create_policy = Google::Gax.create_api_call(
              @org_policy_stub.method(:create_policy),
              defaults["create_policy"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @update_policy = Google::Gax.create_api_call(
              @org_policy_stub.method(:update_policy),
              defaults["update_policy"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'policy.name' => request.policy.name}
              end
            )
            @delete_policy = Google::Gax.create_api_call(
              @org_policy_stub.method(:delete_policy),
              defaults["delete_policy"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
          end

          # Service calls

          # Lists `Constraints` that could be applied on the specified resource.
          #
          # @param parent [String]
          #   Required. The Cloud resource that parents the constraint. Must be in one of the
          #   following forms:
          #   * `projects/{project_number}`
          #   * `projects/{project_id}`
          #   * `folders/{folder_id}`
          #   * `organizations/{organization_id}`
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Orgpolicy::V2::Constraint>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Orgpolicy::V2::Constraint>]
          #   An enumerable of Google::Cloud::Orgpolicy::V2::Constraint instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/orgpolicy"
          #
          #   org_policy_client = Google::Cloud::Orgpolicy.new(version: :v2)
          #   formatted_parent = Google::Cloud::Orgpolicy::V2::OrgPolicyClient.project_path("[PROJECT]")
          #
          #   # Iterate over all results.
          #   org_policy_client.list_constraints(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   org_policy_client.list_constraints(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_constraints \
              parent,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Orgpolicy::V2::ListConstraintsRequest)
            @list_constraints.call(req, options, &block)
          end

          # Retrieves all of the `Policies` that exist on a particular resource.
          #
          # @param parent [String]
          #   Required. The target Cloud resource that parents the set of constraints and policies
          #   that will be returned from this call. Must be in one of the following
          #   forms:
          #   * `projects/{project_number}`
          #   * `projects/{project_id}`
          #   * `folders/{folder_id}`
          #   * `organizations/{organization_id}`
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Orgpolicy::V2::Policy>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Orgpolicy::V2::Policy>]
          #   An enumerable of Google::Cloud::Orgpolicy::V2::Policy instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/orgpolicy"
          #
          #   org_policy_client = Google::Cloud::Orgpolicy.new(version: :v2)
          #   formatted_parent = Google::Cloud::Orgpolicy::V2::OrgPolicyClient.project_path("[PROJECT]")
          #
          #   # Iterate over all results.
          #   org_policy_client.list_policies(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   org_policy_client.list_policies(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_policies \
              parent,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Orgpolicy::V2::ListPoliciesRequest)
            @list_policies.call(req, options, &block)
          end

          # Gets a `Policy` on a resource.
          #
          # If no `Policy` is set on the resource, NOT_FOUND is returned. The
          # `etag` value can be used with `UpdatePolicy()` to update a
          # `Policy` during read-modify-write.
          #
          # @param name [String]
          #   Required. Resource name of the policy. See `Policy` for naming requirements.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Orgpolicy::V2::Policy]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Orgpolicy::V2::Policy]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/orgpolicy"
          #
          #   org_policy_client = Google::Cloud::Orgpolicy.new(version: :v2)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #   response = org_policy_client.get_policy(name)

          def get_policy \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Orgpolicy::V2::GetPolicyRequest)
            @get_policy.call(req, options, &block)
          end

          # Gets the effective `Policy` on a resource. This is the result of merging
          # `Policies` in the resource hierarchy and evaluating conditions. The
          # returned `Policy` will not have an `etag` or `condition` set because it is
          # a computed `Policy` across multiple resources.
          # Subtrees of Resource Manager resource hierarchy with 'under:' prefix will
          # not be expanded.
          #
          # @param name [String]
          #   Required. The effective policy to compute. See `Policy` for naming rules.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Orgpolicy::V2::Policy]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Orgpolicy::V2::Policy]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/orgpolicy"
          #
          #   org_policy_client = Google::Cloud::Orgpolicy.new(version: :v2)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #   response = org_policy_client.get_effective_policy(name)

          def get_effective_policy \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Orgpolicy::V2::GetEffectivePolicyRequest)
            @get_effective_policy.call(req, options, &block)
          end

          # Creates a Policy.
          #
          # Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
          # constraint does not exist.
          # Returns a `google.rpc.Status` with `google.rpc.Code.ALREADY_EXISTS` if the
          # policy already exists on the given Cloud resource.
          #
          # @param parent [String]
          #   Required. The Cloud resource that will parent the new Policy. Must be in one of the
          #   following forms:
          #   * `projects/{project_number}`
          #   * `projects/{project_id}`
          #   * `folders/{folder_id}`
          #   * `organizations/{organization_id}`
          # @param policy [Google::Cloud::Orgpolicy::V2::Policy | Hash]
          #   Required. `Policy` to create.
          #   A hash of the same form as `Google::Cloud::Orgpolicy::V2::Policy`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Orgpolicy::V2::Policy]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Orgpolicy::V2::Policy]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/orgpolicy"
          #
          #   org_policy_client = Google::Cloud::Orgpolicy.new(version: :v2)
          #   formatted_parent = Google::Cloud::Orgpolicy::V2::OrgPolicyClient.project_path("[PROJECT]")
          #
          #   # TODO: Initialize `policy`:
          #   policy = {}
          #   response = org_policy_client.create_policy(formatted_parent, policy)

          def create_policy \
              parent,
              policy,
              options: nil,
              &block
            req = {
              parent: parent,
              policy: policy
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Orgpolicy::V2::CreatePolicyRequest)
            @create_policy.call(req, options, &block)
          end

          # Updates a Policy.
          #
          # Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
          # constraint or the policy do not exist.
          # Returns a `google.rpc.Status` with `google.rpc.Code.ABORTED` if the etag
          # supplied in the request does not match the persisted etag of the policy
          #
          # Note: the supplied policy will perform a full overwrite of all
          # fields.
          #
          # @param policy [Google::Cloud::Orgpolicy::V2::Policy | Hash]
          #   Required. `Policy` to update.
          #   A hash of the same form as `Google::Cloud::Orgpolicy::V2::Policy`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Orgpolicy::V2::Policy]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Orgpolicy::V2::Policy]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/orgpolicy"
          #
          #   org_policy_client = Google::Cloud::Orgpolicy.new(version: :v2)
          #
          #   # TODO: Initialize `policy`:
          #   policy = {}
          #   response = org_policy_client.update_policy(policy)

          def update_policy \
              policy,
              options: nil,
              &block
            req = {
              policy: policy
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Orgpolicy::V2::UpdatePolicyRequest)
            @update_policy.call(req, options, &block)
          end

          # Deletes a Policy.
          #
          # Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
          # constraint or Org Policy does not exist.
          #
          # @param name [String]
          #   Required. Name of the policy to delete.
          #   See `Policy` for naming rules.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/orgpolicy"
          #
          #   org_policy_client = Google::Cloud::Orgpolicy.new(version: :v2)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #   org_policy_client.delete_policy(name)

          def delete_policy \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Orgpolicy::V2::DeletePolicyRequest)
            @delete_policy.call(req, options, &block)
            nil
          end
        end
      end
    end
  end
end
