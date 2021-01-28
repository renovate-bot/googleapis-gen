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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/datacatalog/v1beta1/policytagmanager.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/datacatalog/v1beta1/policytagmanager_pb"
require "google/cloud/datacatalog/v1beta1/credentials"

module Google
  module Cloud
    module Datacatalog
      module V1beta1
        # The policy tag manager API service allows clients to manage their taxonomies
        # and policy tags.
        #
        # @!attribute [r] policy_tag_manager_stub
        #   @return [Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub]
        class PolicyTagManagerClient
          attr_reader :policy_tag_manager_stub

          # The default address of the service.
          SERVICE_ADDRESS = "datacatalog.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_taxonomies" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "taxonomies"),
            "list_policy_tags" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "policy_tags")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform"
          ].freeze


          LOCATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}"
          )

          private_constant :LOCATION_PATH_TEMPLATE

          POLICY_TAG_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/taxonomies/{taxonomy}/policyTags/{policy_tag}"
          )

          private_constant :POLICY_TAG_PATH_TEMPLATE

          TAXONOMY_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/taxonomies/{taxonomy}"
          )

          private_constant :TAXONOMY_PATH_TEMPLATE

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

          # Returns a fully-qualified policy_tag resource name string.
          # @param project [String]
          # @param location [String]
          # @param taxonomy [String]
          # @param policy_tag [String]
          # @return [String]
          def self.policy_tag_path project, location, taxonomy, policy_tag
            POLICY_TAG_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"taxonomy" => taxonomy,
              :"policy_tag" => policy_tag
            )
          end

          # Returns a fully-qualified taxonomy resource name string.
          # @param project [String]
          # @param location [String]
          # @param taxonomy [String]
          # @return [String]
          def self.taxonomy_path project, location, taxonomy
            TAXONOMY_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"taxonomy" => taxonomy
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
            require "google/cloud/datacatalog/v1beta1/policytagmanager_services_pb"

            credentials ||= Google::Cloud::Datacatalog::V1beta1::Credentials.default

            if credentials.is_a?(String) || credentials.is_a?(Hash)
              updater_proc = Google::Cloud::Datacatalog::V1beta1::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-cloud-datacatalog'].version.version

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
              "policy_tag_manager_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.datacatalog.v1beta1.PolicyTagManager",
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
            @policy_tag_manager_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Datacatalog::V1beta1::PolicyTagManager::Stub.method(:new)
            )

            @create_taxonomy = Google::Gax.create_api_call(
              @policy_tag_manager_stub.method(:create_taxonomy),
              defaults["create_taxonomy"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @delete_taxonomy = Google::Gax.create_api_call(
              @policy_tag_manager_stub.method(:delete_taxonomy),
              defaults["delete_taxonomy"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @update_taxonomy = Google::Gax.create_api_call(
              @policy_tag_manager_stub.method(:update_taxonomy),
              defaults["update_taxonomy"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'taxonomy.name' => request.taxonomy.name}
              end
            )
            @list_taxonomies = Google::Gax.create_api_call(
              @policy_tag_manager_stub.method(:list_taxonomies),
              defaults["list_taxonomies"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_taxonomy = Google::Gax.create_api_call(
              @policy_tag_manager_stub.method(:get_taxonomy),
              defaults["get_taxonomy"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @create_policy_tag = Google::Gax.create_api_call(
              @policy_tag_manager_stub.method(:create_policy_tag),
              defaults["create_policy_tag"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @delete_policy_tag = Google::Gax.create_api_call(
              @policy_tag_manager_stub.method(:delete_policy_tag),
              defaults["delete_policy_tag"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @update_policy_tag = Google::Gax.create_api_call(
              @policy_tag_manager_stub.method(:update_policy_tag),
              defaults["update_policy_tag"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'policy_tag.name' => request.policy_tag.name}
              end
            )
            @list_policy_tags = Google::Gax.create_api_call(
              @policy_tag_manager_stub.method(:list_policy_tags),
              defaults["list_policy_tags"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_policy_tag = Google::Gax.create_api_call(
              @policy_tag_manager_stub.method(:get_policy_tag),
              defaults["get_policy_tag"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @get_iam_policy = Google::Gax.create_api_call(
              @policy_tag_manager_stub.method(:get_iam_policy),
              defaults["get_iam_policy"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'resource' => request.resource}
              end
            )
            @set_iam_policy = Google::Gax.create_api_call(
              @policy_tag_manager_stub.method(:set_iam_policy),
              defaults["set_iam_policy"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'resource' => request.resource}
              end
            )
            @test_iam_permissions = Google::Gax.create_api_call(
              @policy_tag_manager_stub.method(:test_iam_permissions),
              defaults["test_iam_permissions"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'resource' => request.resource}
              end
            )
          end

          # Service calls

          # Creates a taxonomy in the specified project.
          #
          # @param parent [String]
          #   Required. Resource name of the project that the taxonomy will belong to.
          # @param taxonomy [Google::Cloud::Datacatalog::V1beta1::Taxonomy | Hash]
          #   The taxonomy to be created.
          #   A hash of the same form as `Google::Cloud::Datacatalog::V1beta1::Taxonomy`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Datacatalog::V1beta1::Taxonomy]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Datacatalog::V1beta1::Taxonomy]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   policy_tag_manager_client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient.location_path("[PROJECT]", "[LOCATION]")
          #   response = policy_tag_manager_client.create_taxonomy(formatted_parent)

          def create_taxonomy \
              parent,
              taxonomy: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              taxonomy: taxonomy
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::CreateTaxonomyRequest)
            @create_taxonomy.call(req, options, &block)
          end

          # Deletes a taxonomy. This operation will also delete all
          # policy tags in this taxonomy along with their associated policies.
          #
          # @param name [String]
          #   Required. Resource name of the taxonomy to be deleted. All policy tags in
          #   this taxonomy will also be deleted.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   policy_tag_manager_client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient.taxonomy_path("[PROJECT]", "[LOCATION]", "[TAXONOMY]")
          #   policy_tag_manager_client.delete_taxonomy(formatted_name)

          def delete_taxonomy \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::DeleteTaxonomyRequest)
            @delete_taxonomy.call(req, options, &block)
            nil
          end

          # Updates a taxonomy.
          #
          # @param taxonomy [Google::Cloud::Datacatalog::V1beta1::Taxonomy | Hash]
          #   The taxonomy to update. Only description, display_name, and activated
          #   policy types can be updated.
          #   A hash of the same form as `Google::Cloud::Datacatalog::V1beta1::Taxonomy`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   The update mask applies to the resource. For the `FieldMask` definition,
          #   see
          #   https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
          #   If not set, defaults to all of the fields that are allowed to update.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Datacatalog::V1beta1::Taxonomy]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Datacatalog::V1beta1::Taxonomy]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   policy_tag_manager_client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)
          #   response = policy_tag_manager_client.update_taxonomy

          def update_taxonomy \
              taxonomy: nil,
              update_mask: nil,
              options: nil,
              &block
            req = {
              taxonomy: taxonomy,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::UpdateTaxonomyRequest)
            @update_taxonomy.call(req, options, &block)
          end

          # Lists all taxonomies in a project in a particular location that the caller
          # has permission to view.
          #
          # @param parent [String]
          #   Required. Resource name of the project to list the taxonomies of.
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Datacatalog::V1beta1::Taxonomy>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Datacatalog::V1beta1::Taxonomy>]
          #   An enumerable of Google::Cloud::Datacatalog::V1beta1::Taxonomy instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   policy_tag_manager_client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # Iterate over all results.
          #   policy_tag_manager_client.list_taxonomies(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   policy_tag_manager_client.list_taxonomies(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_taxonomies \
              parent,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::ListTaxonomiesRequest)
            @list_taxonomies.call(req, options, &block)
          end

          # Gets a taxonomy.
          #
          # @param name [String]
          #   Required. Resource name of the requested taxonomy.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Datacatalog::V1beta1::Taxonomy]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Datacatalog::V1beta1::Taxonomy]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   policy_tag_manager_client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient.taxonomy_path("[PROJECT]", "[LOCATION]", "[TAXONOMY]")
          #   response = policy_tag_manager_client.get_taxonomy(formatted_name)

          def get_taxonomy \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::GetTaxonomyRequest)
            @get_taxonomy.call(req, options, &block)
          end

          # Creates a policy tag in the specified taxonomy.
          #
          # @param parent [String]
          #   Required. Resource name of the taxonomy that the policy tag will belong to.
          # @param policy_tag [Google::Cloud::Datacatalog::V1beta1::PolicyTag | Hash]
          #   The policy tag to be created.
          #   A hash of the same form as `Google::Cloud::Datacatalog::V1beta1::PolicyTag`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Datacatalog::V1beta1::PolicyTag]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Datacatalog::V1beta1::PolicyTag]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   policy_tag_manager_client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient.taxonomy_path("[PROJECT]", "[LOCATION]", "[TAXONOMY]")
          #   response = policy_tag_manager_client.create_policy_tag(formatted_parent)

          def create_policy_tag \
              parent,
              policy_tag: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              policy_tag: policy_tag
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::CreatePolicyTagRequest)
            @create_policy_tag.call(req, options, &block)
          end

          # Deletes a policy tag. Also deletes all of its descendant policy tags.
          #
          # @param name [String]
          #   Required. Resource name of the policy tag to be deleted. All of its descendant
          #   policy tags will also be deleted.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   policy_tag_manager_client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient.policy_tag_path("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]")
          #   policy_tag_manager_client.delete_policy_tag(formatted_name)

          def delete_policy_tag \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::DeletePolicyTagRequest)
            @delete_policy_tag.call(req, options, &block)
            nil
          end

          # Updates a policy tag.
          #
          # @param policy_tag [Google::Cloud::Datacatalog::V1beta1::PolicyTag | Hash]
          #   The policy tag to update. Only the description, display_name, and
          #   parent_policy_tag fields can be updated.
          #   A hash of the same form as `Google::Cloud::Datacatalog::V1beta1::PolicyTag`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   The update mask applies to the resource. Only display_name, description and
          #   parent_policy_tag can be updated and thus can be listed in the mask. If
          #   update_mask is not provided, all allowed fields (i.e. display_name,
          #   description and parent) will be updated. For more information including the
          #   `FieldMask` definition, see
          #   https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
          #   If not set, defaults to all of the fields that are allowed to update.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Datacatalog::V1beta1::PolicyTag]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Datacatalog::V1beta1::PolicyTag]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   policy_tag_manager_client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)
          #   response = policy_tag_manager_client.update_policy_tag

          def update_policy_tag \
              policy_tag: nil,
              update_mask: nil,
              options: nil,
              &block
            req = {
              policy_tag: policy_tag,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::UpdatePolicyTagRequest)
            @update_policy_tag.call(req, options, &block)
          end

          # Lists all policy tags in a taxonomy.
          #
          # @param parent [String]
          #   Required. Resource name of the taxonomy to list the policy tags of.
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Datacatalog::V1beta1::PolicyTag>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Datacatalog::V1beta1::PolicyTag>]
          #   An enumerable of Google::Cloud::Datacatalog::V1beta1::PolicyTag instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   policy_tag_manager_client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient.taxonomy_path("[PROJECT]", "[LOCATION]", "[TAXONOMY]")
          #
          #   # Iterate over all results.
          #   policy_tag_manager_client.list_policy_tags(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   policy_tag_manager_client.list_policy_tags(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_policy_tags \
              parent,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::ListPolicyTagsRequest)
            @list_policy_tags.call(req, options, &block)
          end

          # Gets a policy tag.
          #
          # @param name [String]
          #   Required. Resource name of the requested policy tag.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Datacatalog::V1beta1::PolicyTag]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Datacatalog::V1beta1::PolicyTag]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   policy_tag_manager_client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerClient.policy_tag_path("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]")
          #   response = policy_tag_manager_client.get_policy_tag(formatted_name)

          def get_policy_tag \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::GetPolicyTagRequest)
            @get_policy_tag.call(req, options, &block)
          end

          # Gets the IAM policy for a taxonomy or a policy tag.
          #
          # @param resource [String]
          #   REQUIRED: The resource for which the policy is being requested.
          #   See the operation documentation for the appropriate value for this field.
          # @param options_ [Google::Iam::V1::GetPolicyOptions | Hash]
          #   OPTIONAL: A `GetPolicyOptions` object for specifying options to
          #   `GetIamPolicy`. This field is only used by Cloud IAM.
          #   A hash of the same form as `Google::Iam::V1::GetPolicyOptions`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Iam::V1::Policy]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Iam::V1::Policy]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   policy_tag_manager_client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)
          #
          #   # TODO: Initialize `resource`:
          #   resource = ''
          #   response = policy_tag_manager_client.get_iam_policy(resource)

          def get_iam_policy \
              resource,
              options_: nil,
              options: nil,
              &block
            req = {
              resource: resource,
              options: options_
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Iam::V1::GetIamPolicyRequest)
            @get_iam_policy.call(req, options, &block)
          end

          # Sets the IAM policy for a taxonomy or a policy tag.
          #
          # @param resource [String]
          #   REQUIRED: The resource for which the policy is being specified.
          #   See the operation documentation for the appropriate value for this field.
          # @param policy [Google::Iam::V1::Policy | Hash]
          #   REQUIRED: The complete policy to be applied to the `resource`. The size of
          #   the policy is limited to a few 10s of KB. An empty policy is a
          #   valid policy but certain Cloud Platform services (such as Projects)
          #   might reject them.
          #   A hash of the same form as `Google::Iam::V1::Policy`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Iam::V1::Policy]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Iam::V1::Policy]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   policy_tag_manager_client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)
          #
          #   # TODO: Initialize `resource`:
          #   resource = ''
          #
          #   # TODO: Initialize `policy`:
          #   policy = {}
          #   response = policy_tag_manager_client.set_iam_policy(resource, policy)

          def set_iam_policy \
              resource,
              policy,
              options: nil,
              &block
            req = {
              resource: resource,
              policy: policy
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Iam::V1::SetIamPolicyRequest)
            @set_iam_policy.call(req, options, &block)
          end

          # Returns the permissions that a caller has on the specified taxonomy or
          # policy tag.
          #
          # @param resource [String]
          #   REQUIRED: The resource for which the policy detail is being requested.
          #   See the operation documentation for the appropriate value for this field.
          # @param permissions [Array<String>]
          #   The set of permissions to check for the `resource`. Permissions with
          #   wildcards (such as '*' or 'storage.*') are not allowed. For more
          #   information see
          #   [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Iam::V1::TestIamPermissionsResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Iam::V1::TestIamPermissionsResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   policy_tag_manager_client = Google::Cloud::Datacatalog::PolicyTagManager.new(version: :v1beta1)
          #
          #   # TODO: Initialize `resource`:
          #   resource = ''
          #
          #   # TODO: Initialize `permissions`:
          #   permissions = []
          #   response = policy_tag_manager_client.test_iam_permissions(resource, permissions)

          def test_iam_permissions \
              resource,
              permissions,
              options: nil,
              &block
            req = {
              resource: resource,
              permissions: permissions
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Iam::V1::TestIamPermissionsRequest)
            @test_iam_permissions.call(req, options, &block)
          end
        end
      end
    end
  end
end
