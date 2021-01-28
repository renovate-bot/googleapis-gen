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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/dialogflow/v2beta1/knowledge_base.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/dialogflow/v2beta1/knowledge_base_pb"
require "google/cloud/dialogflow/v2beta1/credentials"

module Google
  module Cloud
    module Dialogflow
      module V2beta1
        # Service for managing {Google::Cloud::Dialogflow::V2beta1::KnowledgeBase KnowledgeBases}.
        #
        # @!attribute [r] knowledge_bases_stub
        #   @return [Google::Cloud::Dialogflow::V2beta1::KnowledgeBases::Stub]
        class KnowledgeBasesClient
          attr_reader :knowledge_bases_stub

          # The default address of the service.
          SERVICE_ADDRESS = "dialogflow.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_knowledge_bases" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "knowledge_bases")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/dialogflow"
          ].freeze


          KNOWLEDGE_BASE_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/knowledgeBases/{knowledge_base}"
          )

          private_constant :KNOWLEDGE_BASE_PATH_TEMPLATE

          LOCATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}"
          )

          private_constant :LOCATION_PATH_TEMPLATE

          PROJECT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}"
          )

          private_constant :PROJECT_PATH_TEMPLATE

          # Returns a fully-qualified knowledge_base resource name string.
          # @param project [String]
          # @param knowledge_base [String]
          # @return [String]
          def self.knowledge_base_path project, knowledge_base
            KNOWLEDGE_BASE_PATH_TEMPLATE.render(
              :"project" => project,
              :"knowledge_base" => knowledge_base
            )
          end

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
            require "google/cloud/dialogflow/v2beta1/knowledge_base_services_pb"

            credentials ||= Google::Cloud::Dialogflow::V2beta1::Credentials.default

            if credentials.is_a?(String) || credentials.is_a?(Hash)
              updater_proc = Google::Cloud::Dialogflow::V2beta1::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-cloud-dialogflow'].version.version

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
              "knowledge_bases_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.dialogflow.v2beta1.KnowledgeBases",
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
            @knowledge_bases_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Dialogflow::V2beta1::KnowledgeBases::Stub.method(:new)
            )

            @list_knowledge_bases = Google::Gax.create_api_call(
              @knowledge_bases_stub.method(:list_knowledge_bases),
              defaults["list_knowledge_bases"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_knowledge_base = Google::Gax.create_api_call(
              @knowledge_bases_stub.method(:get_knowledge_base),
              defaults["get_knowledge_base"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @create_knowledge_base = Google::Gax.create_api_call(
              @knowledge_bases_stub.method(:create_knowledge_base),
              defaults["create_knowledge_base"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @delete_knowledge_base = Google::Gax.create_api_call(
              @knowledge_bases_stub.method(:delete_knowledge_base),
              defaults["delete_knowledge_base"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @update_knowledge_base = Google::Gax.create_api_call(
              @knowledge_bases_stub.method(:update_knowledge_base),
              defaults["update_knowledge_base"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'knowledge_base.name' => request.knowledge_base.name}
              end
            )
          end

          # Service calls

          # Returns the list of all knowledge bases of the specified agent.
          #
          # Note: The `projects.agent.knowledgeBases` resource is deprecated;
          # only use `projects.knowledgeBases`.
          #
          # @param parent [String]
          #   Required. The project to list of knowledge bases for.
          #   Format: `projects/<Project ID>/locations/<Location ID>`.
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param filter [String]
          #   The filter expression used to filter knowledge bases returned by the list
          #   method. The expression has the following syntax:
          #
          #     <field> <operator> <value> [AND <field> <operator> <value>] ...
          #
          #   The following fields and operators are supported:
          #
          #   * display_name with has(:) operator
          #   * language_code with equals(=) operator
          #
          #   Examples:
          #
          #   * 'language_code=en-us' matches knowledge bases with en-us language code.
          #   * 'display_name:articles' matches knowledge bases whose display name
          #     contains "articles".
          #   * 'display_name:"Best Articles"' matches knowledge bases whose display
          #     name contains "Best Articles".
          #   * 'language_code=en-gb AND display_name=articles' matches all knowledge
          #     bases whose display name contains "articles" and whose language code is
          #     "en-gb".
          #
          #   Note: An empty filter string (i.e. "") is a no-op and will result in no
          #   filtering.
          #
          #   For more information about filtering, see
          #   [API Filtering](https://aip.dev/160).
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::V2beta1::KnowledgeBase>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::V2beta1::KnowledgeBase>]
          #   An enumerable of Google::Cloud::Dialogflow::V2beta1::KnowledgeBase instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   knowledge_bases_client = Google::Cloud::Dialogflow::KnowledgeBases.new(version: :v2beta1)
          #   formatted_parent = Google::Cloud::Dialogflow::V2beta1::KnowledgeBasesClient.project_path("[PROJECT]")
          #
          #   # Iterate over all results.
          #   knowledge_bases_client.list_knowledge_bases(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   knowledge_bases_client.list_knowledge_bases(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_knowledge_bases \
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
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::ListKnowledgeBasesRequest)
            @list_knowledge_bases.call(req, options, &block)
          end

          # Retrieves the specified knowledge base.
          #
          # Note: The `projects.agent.knowledgeBases` resource is deprecated;
          # only use `projects.knowledgeBases`.
          #
          # @param name [String]
          #   Required. The name of the knowledge base to retrieve.
          #   Format `projects/<Project ID>/locations/<Location
          #   ID>/knowledgeBases/<Knowledge Base ID>`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Dialogflow::V2beta1::KnowledgeBase]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Dialogflow::V2beta1::KnowledgeBase]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   knowledge_bases_client = Google::Cloud::Dialogflow::KnowledgeBases.new(version: :v2beta1)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #   response = knowledge_bases_client.get_knowledge_base(name)

          def get_knowledge_base \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::GetKnowledgeBaseRequest)
            @get_knowledge_base.call(req, options, &block)
          end

          # Creates a knowledge base.
          #
          # Note: The `projects.agent.knowledgeBases` resource is deprecated;
          # only use `projects.knowledgeBases`.
          #
          # @param parent [String]
          #   Required. The project to create a knowledge base for.
          #   Format: `projects/<Project ID>/locations/<Location ID>`.
          # @param knowledge_base [Google::Cloud::Dialogflow::V2beta1::KnowledgeBase | Hash]
          #   Required. The knowledge base to create.
          #   A hash of the same form as `Google::Cloud::Dialogflow::V2beta1::KnowledgeBase`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Dialogflow::V2beta1::KnowledgeBase]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Dialogflow::V2beta1::KnowledgeBase]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   knowledge_bases_client = Google::Cloud::Dialogflow::KnowledgeBases.new(version: :v2beta1)
          #   formatted_parent = Google::Cloud::Dialogflow::V2beta1::KnowledgeBasesClient.project_path("[PROJECT]")
          #
          #   # TODO: Initialize `knowledge_base`:
          #   knowledge_base = {}
          #   response = knowledge_bases_client.create_knowledge_base(formatted_parent, knowledge_base)

          def create_knowledge_base \
              parent,
              knowledge_base,
              options: nil,
              &block
            req = {
              parent: parent,
              knowledge_base: knowledge_base
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::CreateKnowledgeBaseRequest)
            @create_knowledge_base.call(req, options, &block)
          end

          # Deletes the specified knowledge base.
          #
          # Note: The `projects.agent.knowledgeBases` resource is deprecated;
          # only use `projects.knowledgeBases`.
          #
          # @param name [String]
          #   Required. The name of the knowledge base to delete.
          #   Format: `projects/<Project ID>/locations/<Location
          #   ID>/knowledgeBases/<Knowledge Base ID>`.
          # @param force [true, false]
          #   Optional. Force deletes the knowledge base. When set to true, any documents
          #   in the knowledge base are also deleted.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   knowledge_bases_client = Google::Cloud::Dialogflow::KnowledgeBases.new(version: :v2beta1)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #   knowledge_bases_client.delete_knowledge_base(name)

          def delete_knowledge_base \
              name,
              force: nil,
              options: nil,
              &block
            req = {
              name: name,
              force: force
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::DeleteKnowledgeBaseRequest)
            @delete_knowledge_base.call(req, options, &block)
            nil
          end

          # Updates the specified knowledge base.
          #
          # Note: The `projects.agent.knowledgeBases` resource is deprecated;
          # only use `projects.knowledgeBases`.
          #
          # @param knowledge_base [Google::Cloud::Dialogflow::V2beta1::KnowledgeBase | Hash]
          #   Required. The knowledge base to update.
          #   A hash of the same form as `Google::Cloud::Dialogflow::V2beta1::KnowledgeBase`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Optional. Not specified means `update all`.
          #   Currently, only `display_name` can be updated, an InvalidArgument will be
          #   returned for attempting to update other fields.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Dialogflow::V2beta1::KnowledgeBase]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Dialogflow::V2beta1::KnowledgeBase]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   knowledge_bases_client = Google::Cloud::Dialogflow::KnowledgeBases.new(version: :v2beta1)
          #
          #   # TODO: Initialize `knowledge_base`:
          #   knowledge_base = {}
          #   response = knowledge_bases_client.update_knowledge_base(knowledge_base)

          def update_knowledge_base \
              knowledge_base,
              update_mask: nil,
              options: nil,
              &block
            req = {
              knowledge_base: knowledge_base,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::UpdateKnowledgeBaseRequest)
            @update_knowledge_base.call(req, options, &block)
          end
        end
      end
    end
  end
end
