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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/gkehub/v1beta1/membership.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"
require "google/gax/operation"
require "google/longrunning/operations_client"

require "google/cloud/gkehub/v1beta1/membership_pb"
require "google/cloud/gkehub/v1beta1/credentials"

module Google
  module Cloud
    module Gkehub
      module V1beta1
        # GKE Hub CRUD API for the Membership resource.
        # The Membership service is currently only available in the global location.
        #
        # @!attribute [r] gke_hub_membership_service_stub
        #   @return [Google::Cloud::Gkehub::V1beta1::GkeHubMembershipService::Stub]
        class GkeHubMembershipServiceClient
          attr_reader :gke_hub_membership_service_stub

          # The default address of the service.
          SERVICE_ADDRESS = "gkehub.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_memberships" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "resources")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform"
          ].freeze

          class OperationsClient < Google::Longrunning::OperationsClient
            self::SERVICE_ADDRESS = GkeHubMembershipServiceClient::SERVICE_ADDRESS
            self::GRPC_INTERCEPTORS = GkeHubMembershipServiceClient::GRPC_INTERCEPTORS
          end

          MEMBERSHIP_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/memberships/{membership}"
          )

          private_constant :MEMBERSHIP_PATH_TEMPLATE

          # Returns a fully-qualified membership resource name string.
          # @param project [String]
          # @param location [String]
          # @param membership [String]
          # @return [String]
          def self.membership_path project, location, membership
            MEMBERSHIP_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"membership" => membership
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
            require "google/cloud/gkehub/v1beta1/membership_services_pb"

            credentials ||= Google::Cloud::Gkehub::V1beta1::Credentials.default

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
              updater_proc = Google::Cloud::Gkehub::V1beta1::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-cloud-gkehub'].version.version

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
              "gke_hub_membership_service_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.gkehub.v1beta1.GkeHubMembershipService",
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
            @gke_hub_membership_service_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Gkehub::V1beta1::GkeHubMembershipService::Stub.method(:new)
            )

            @list_memberships = Google::Gax.create_api_call(
              @gke_hub_membership_service_stub.method(:list_memberships),
              defaults["list_memberships"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_membership = Google::Gax.create_api_call(
              @gke_hub_membership_service_stub.method(:get_membership),
              defaults["get_membership"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @create_membership = Google::Gax.create_api_call(
              @gke_hub_membership_service_stub.method(:create_membership),
              defaults["create_membership"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @delete_membership = Google::Gax.create_api_call(
              @gke_hub_membership_service_stub.method(:delete_membership),
              defaults["delete_membership"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @update_membership = Google::Gax.create_api_call(
              @gke_hub_membership_service_stub.method(:update_membership),
              defaults["update_membership"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @generate_connect_manifest = Google::Gax.create_api_call(
              @gke_hub_membership_service_stub.method(:generate_connect_manifest),
              defaults["generate_connect_manifest"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @validate_exclusivity = Google::Gax.create_api_call(
              @gke_hub_membership_service_stub.method(:validate_exclusivity),
              defaults["validate_exclusivity"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @generate_exclusivity_manifest = Google::Gax.create_api_call(
              @gke_hub_membership_service_stub.method(:generate_exclusivity_manifest),
              defaults["generate_exclusivity_manifest"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
          end

          # Service calls

          # Lists Memberships in a given project and location.
          #
          # @param parent [String]
          #   Required. The parent (project and location) where the Memberships will be listed.
          #   Specified in the format `projects/*/locations/*`.
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param filter [String]
          #   Optional. Lists Memberships that match the filter expression, following the syntax
          #   outlined in https://google.aip.dev/160.
          #
          #   Examples:
          #
          #   * Name is `bar` in project `foo-proj` and location `global`:
          #
          #     name = "projects/foo-proj/locations/global/membership/bar"
          #
          #     * Memberships that have a label called `foo`:
          #
          #       labels.foo:*
          #
          #     * Memberships that have a label called `foo` whose value is `bar`:
          #
          #       labels.foo = bar
          #
          #     * Memberships in the CREATING state:
          #
          #       state = CREATING
          # @param order_by [String]
          #   Optional. One or more fields to compare and use to sort the output.
          #   See https://google.aip.dev/132#ordering.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Gkehub::V1beta1::Membership>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Gkehub::V1beta1::Membership>]
          #   An enumerable of Google::Cloud::Gkehub::V1beta1::Membership instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gkehub"
          #
          #   gke_hub_membership_client = Google::Cloud::Gkehub.new(version: :v1beta1)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #
          #   # Iterate over all results.
          #   gke_hub_membership_client.list_memberships(parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   gke_hub_membership_client.list_memberships(parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_memberships \
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
            req = Google::Gax::to_proto(req, Google::Cloud::Gkehub::V1beta1::ListMembershipsRequest)
            @list_memberships.call(req, options, &block)
          end

          # Gets the details of a Membership.
          #
          # @param name [String]
          #   Required. The Membership resource name in the format
          #   `projects/*/locations/*/memberships/*`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Gkehub::V1beta1::Membership]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Gkehub::V1beta1::Membership]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gkehub"
          #
          #   gke_hub_membership_client = Google::Cloud::Gkehub.new(version: :v1beta1)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #   response = gke_hub_membership_client.get_membership(name)

          def get_membership \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gkehub::V1beta1::GetMembershipRequest)
            @get_membership.call(req, options, &block)
          end

          # Adds a new Membership.
          #
          # @param parent [String]
          #   Required. The parent (project and location) where the Memberships will be created.
          #   Specified in the format `projects/*/locations/*`.
          # @param membership_id [String]
          #   Required. Client chosen ID for the membership. `membership_id` must be a valid RFC
          #   1123 compliant DNS label:
          #
          #     1. At most 63 characters in length
          #     2. It must consist of lower case alphanumeric characters or `-`
          #     3. It must start and end with an alphanumeric character
          #
          #   Which can be expressed as the regex: `[a-z0-9](https://cloud.google.com[-a-z0-9]*[a-z0-9])?`,
          #   with a maximum length of 63 characters.
          # @param resource [Google::Cloud::Gkehub::V1beta1::Membership | Hash]
          #   Required. The membership to create.
          #   A hash of the same form as `Google::Cloud::Gkehub::V1beta1::Membership`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gkehub"
          #
          #   gke_hub_membership_client = Google::Cloud::Gkehub.new(version: :v1beta1)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #
          #   # TODO: Initialize `membership_id`:
          #   membership_id = ''
          #
          #   # TODO: Initialize `resource`:
          #   resource = {}
          #
          #   # Register a callback during the method call.
          #   operation = gke_hub_membership_client.create_membership(parent, membership_id, resource) do |op|
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

          def create_membership \
              parent,
              membership_id,
              resource,
              options: nil
            req = {
              parent: parent,
              membership_id: membership_id,
              resource: resource
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gkehub::V1beta1::CreateMembershipRequest)
            operation = Google::Gax::Operation.new(
              @create_membership.call(req, options),
              @operations_client,
              Google::Cloud::Gkehub::V1beta1::Membership,
              Google::Cloud::Gkehub::V1beta1::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Removes a Membership.
          #
          # @param name [String]
          #   Required. The Membership resource name in the format
          #   `projects/*/locations/*/memberships/*`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gkehub"
          #
          #   gke_hub_membership_client = Google::Cloud::Gkehub.new(version: :v1beta1)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #
          #   # Register a callback during the method call.
          #   operation = gke_hub_membership_client.delete_membership(name) do |op|
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

          def delete_membership \
              name,
              options: nil
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gkehub::V1beta1::DeleteMembershipRequest)
            operation = Google::Gax::Operation.new(
              @delete_membership.call(req, options),
              @operations_client,
              Google::Protobuf::Empty,
              Google::Cloud::Gkehub::V1beta1::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Updates an existing Membership.
          #
          # @param name [String]
          #   Required. The membership resource name in the format:
          #   `projects/[project_id]/locations/global/memberships/[membership_id]`
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Required. Mask of fields to update. At least one field path must be specified in this
          #   mask.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param resource [Google::Cloud::Gkehub::V1beta1::Membership | Hash]
          #   Required. Only fields specified in update_mask are updated.
          #   If you specify a field in the update_mask but don't specify its value here
          #   that field will be deleted.
          #   If you are updating a map field, set the value of a key to null or empty
          #   string to delete the key from the map. It's not possible to update a key's
          #   value to the empty string.
          #   A hash of the same form as `Google::Cloud::Gkehub::V1beta1::Membership`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gkehub"
          #
          #   gke_hub_membership_client = Google::Cloud::Gkehub.new(version: :v1beta1)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #
          #   # TODO: Initialize `update_mask`:
          #   update_mask = {}
          #
          #   # TODO: Initialize `resource`:
          #   resource = {}
          #
          #   # Register a callback during the method call.
          #   operation = gke_hub_membership_client.update_membership(name, update_mask, resource) do |op|
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

          def update_membership \
              name,
              update_mask,
              resource,
              options: nil
            req = {
              name: name,
              update_mask: update_mask,
              resource: resource
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gkehub::V1beta1::UpdateMembershipRequest)
            operation = Google::Gax::Operation.new(
              @update_membership.call(req, options),
              @operations_client,
              Google::Cloud::Gkehub::V1beta1::Membership,
              Google::Cloud::Gkehub::V1beta1::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Generates the manifest for deployment of the GKE connect agent.
          #
          # @param name [String]
          #   Required. The Membership resource name the Agent will associate with, in the format
          #   `projects/*/locations/*/memberships/*`.
          # @param connect_agent [Google::Cloud::Gkehub::V1beta1::ConnectAgent | Hash]
          #   Optional. The connect agent to generate manifest for.
          #   A hash of the same form as `Google::Cloud::Gkehub::V1beta1::ConnectAgent`
          #   can also be provided.
          # @param version [String]
          #   Optional. The Connect agent version to use. Defaults to the most current version.
          # @param is_upgrade [true, false]
          #   Optional. If true, generate the resources for upgrade only. Some resources
          #   generated only for installation (e.g. secrets) will be excluded.
          # @param registry [String]
          #   Optional. The registry to fetch the connect agent image from. Defaults to
          #   gcr.io/gkeconnect.
          # @param image_pull_secret_content [String]
          #   Optional. The image pull secret content for the registry, if not public.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Gkehub::V1beta1::GenerateConnectManifestResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Gkehub::V1beta1::GenerateConnectManifestResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gkehub"
          #
          #   gke_hub_membership_client = Google::Cloud::Gkehub.new(version: :v1beta1)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #   response = gke_hub_membership_client.generate_connect_manifest(name)

          def generate_connect_manifest \
              name,
              connect_agent: nil,
              version: nil,
              is_upgrade: nil,
              registry: nil,
              image_pull_secret_content: nil,
              options: nil,
              &block
            req = {
              name: name,
              connect_agent: connect_agent,
              version: version,
              is_upgrade: is_upgrade,
              registry: registry,
              image_pull_secret_content: image_pull_secret_content
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gkehub::V1beta1::GenerateConnectManifestRequest)
            @generate_connect_manifest.call(req, options, &block)
          end

          # ValidateExclusivity validates the state of exclusivity in the cluster.
          # The validation does not depend on an existing Hub membership resource.
          #
          # @param parent [String]
          #   Required. The parent (project and location) where the Memberships will be created.
          #   Specified in the format `projects/*/locations/*`.
          # @param intended_membership [String]
          #   Required. The intended membership name under the `parent`. This method only does
          #   validation in anticipation of a CreateMembership call with the same name.
          # @param cr_manifest [String]
          #   Optional. The YAML of the membership CR in the cluster. Empty if the membership
          #   CR does not exist.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Gkehub::V1beta1::ValidateExclusivityResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Gkehub::V1beta1::ValidateExclusivityResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gkehub"
          #
          #   gke_hub_membership_client = Google::Cloud::Gkehub.new(version: :v1beta1)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #
          #   # TODO: Initialize `intended_membership`:
          #   intended_membership = ''
          #   response = gke_hub_membership_client.validate_exclusivity(parent, intended_membership)

          def validate_exclusivity \
              parent,
              intended_membership,
              cr_manifest: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              intended_membership: intended_membership,
              cr_manifest: cr_manifest
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gkehub::V1beta1::ValidateExclusivityRequest)
            @validate_exclusivity.call(req, options, &block)
          end

          # GenerateExclusivityManifest generates the manifests to update the
          # exclusivity artifacts in the cluster if needed.
          #
          # Exclusivity artifacts include the Membership custom resource definition
          # (CRD) and the singleton Membership custom resource (CR). Combined with
          # ValidateExclusivity, exclusivity artifacts guarantee that a Kubernetes
          # cluster is only registered to a single GKE Hub.
          #
          # The Membership CRD is versioned, and may require conversion when the GKE
          # Hub API server begins serving a newer version of the CRD and
          # corresponding CR. The response will be the converted CRD and CR if there
          # are any differences between the versions.
          #
          # @param name [String]
          #   Required. The Membership resource name in the format
          #   `projects/*/locations/*/memberships/*`.
          # @param crd_manifest [String]
          #   Optional. The YAML manifest of the membership CRD retrieved by
          #   `kubectl get customresourcedefinitions membership`.
          #   Leave empty if the resource does not exist.
          # @param cr_manifest [String]
          #   Optional. The YAML manifest of the membership CR retrieved by
          #   `kubectl get memberships membership`.
          #   Leave empty if the resource does not exist.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Gkehub::V1beta1::GenerateExclusivityManifestResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Gkehub::V1beta1::GenerateExclusivityManifestResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/gkehub"
          #
          #   gke_hub_membership_client = Google::Cloud::Gkehub.new(version: :v1beta1)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #   response = gke_hub_membership_client.generate_exclusivity_manifest(name)

          def generate_exclusivity_manifest \
              name,
              crd_manifest: nil,
              cr_manifest: nil,
              options: nil,
              &block
            req = {
              name: name,
              crd_manifest: crd_manifest,
              cr_manifest: cr_manifest
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Gkehub::V1beta1::GenerateExclusivityManifestRequest)
            @generate_exclusivity_manifest.call(req, options, &block)
          end
        end
      end
    end
  end
end
