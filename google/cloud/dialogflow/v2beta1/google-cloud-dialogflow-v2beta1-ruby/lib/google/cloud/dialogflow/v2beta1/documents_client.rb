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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/dialogflow/v2beta1/document.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"
require "google/gax/operation"
require "google/longrunning/operations_client"

require "google/cloud/dialogflow/v2beta1/document_pb"
require "google/cloud/dialogflow/v2beta1/credentials"

module Google
  module Cloud
    module Dialogflow
      module V2beta1
        # Service for managing knowledge {Google::Cloud::Dialogflow::V2beta1::Document Documents}.
        #
        # @!attribute [r] documents_stub
        #   @return [Google::Cloud::Dialogflow::V2beta1::Documents::Stub]
        class DocumentsClient
          attr_reader :documents_stub

          # The default address of the service.
          SERVICE_ADDRESS = "dialogflow.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_documents" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "documents")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/dialogflow"
          ].freeze

          class OperationsClient < Google::Longrunning::OperationsClient
            self::SERVICE_ADDRESS = DocumentsClient::SERVICE_ADDRESS
            self::GRPC_INTERCEPTORS = DocumentsClient::GRPC_INTERCEPTORS
          end

          DOCUMENT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/knowledgeBases/{knowledge_base}/documents/{document}"
          )

          private_constant :DOCUMENT_PATH_TEMPLATE

          KNOWLEDGE_BASE_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/knowledgeBases/{knowledge_base}"
          )

          private_constant :KNOWLEDGE_BASE_PATH_TEMPLATE

          # Returns a fully-qualified document resource name string.
          # @param project [String]
          # @param knowledge_base [String]
          # @param document [String]
          # @return [String]
          def self.document_path project, knowledge_base, document
            DOCUMENT_PATH_TEMPLATE.render(
              :"project" => project,
              :"knowledge_base" => knowledge_base,
              :"document" => document
            )
          end

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
            require "google/cloud/dialogflow/v2beta1/document_services_pb"

            credentials ||= Google::Cloud::Dialogflow::V2beta1::Credentials.default

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
              "documents_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.dialogflow.v2beta1.Documents",
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
            @documents_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Dialogflow::V2beta1::Documents::Stub.method(:new)
            )

            @list_documents = Google::Gax.create_api_call(
              @documents_stub.method(:list_documents),
              defaults["list_documents"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_document = Google::Gax.create_api_call(
              @documents_stub.method(:get_document),
              defaults["get_document"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @create_document = Google::Gax.create_api_call(
              @documents_stub.method(:create_document),
              defaults["create_document"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @delete_document = Google::Gax.create_api_call(
              @documents_stub.method(:delete_document),
              defaults["delete_document"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @update_document = Google::Gax.create_api_call(
              @documents_stub.method(:update_document),
              defaults["update_document"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'document.name' => request.document.name}
              end
            )
            @reload_document = Google::Gax.create_api_call(
              @documents_stub.method(:reload_document),
              defaults["reload_document"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
          end

          # Service calls

          # Returns the list of all documents of the knowledge base.
          #
          # Note: The `projects.agent.knowledgeBases.documents` resource is deprecated;
          # only use `projects.knowledgeBases.documents`.
          #
          # @param parent [String]
          #   Required. The knowledge base to list all documents for.
          #   Format: `projects/<Project ID>/locations/<Location
          #   ID>/knowledgeBases/<Knowledge Base ID>`.
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param filter [String]
          #   The filter expression used to filter documents returned by the list method.
          #   The expression has the following syntax:
          #
          #     <field> <operator> <value> [AND <field> <operator> <value>] ...
          #
          #   The following fields and operators are supported:
          #
          #   * knowledge_types with has(:) operator
          #   * display_name with has(:) operator
          #   * state with equals(=) operator
          #
          #   Examples:
          #
          #   * "knowledge_types:FAQ" matches documents with FAQ knowledge type.
          #   * "display_name:customer" matches documents whose display name contains
          #     "customer".
          #   * "state=ACTIVE" matches documents with ACTIVE state.
          #   * "knowledge_types:FAQ AND state=ACTIVE" matches all active FAQ documents.
          #
          #   For more information about filtering, see
          #   [API Filtering](https://aip.dev/160).
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::V2beta1::Document>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::V2beta1::Document>]
          #   An enumerable of Google::Cloud::Dialogflow::V2beta1::Document instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   documents_client = Google::Cloud::Dialogflow::Documents.new(version: :v2beta1)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #
          #   # Iterate over all results.
          #   documents_client.list_documents(parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   documents_client.list_documents(parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_documents \
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
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::ListDocumentsRequest)
            @list_documents.call(req, options, &block)
          end

          # Retrieves the specified document.
          #
          # Note: The `projects.agent.knowledgeBases.documents` resource is deprecated;
          # only use `projects.knowledgeBases.documents`.
          #
          # @param name [String]
          #   Required. The name of the document to retrieve.
          #   Format `projects/<Project ID>/locations/<Location
          #   ID>/knowledgeBases/<Knowledge Base ID>/documents/<Document ID>`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Dialogflow::V2beta1::Document]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Dialogflow::V2beta1::Document]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   documents_client = Google::Cloud::Dialogflow::Documents.new(version: :v2beta1)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #   response = documents_client.get_document(name)

          def get_document \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::GetDocumentRequest)
            @get_document.call(req, options, &block)
          end

          # Creates a new document.
          #
          # Note: The `projects.agent.knowledgeBases.documents` resource is deprecated;
          # only use `projects.knowledgeBases.documents`.
          #
          # @param parent [String]
          #   Required. The knowledge base to create a document for.
          #   Format: `projects/<Project ID>/locations/<Location
          #   ID>/knowledgeBases/<Knowledge Base ID>`.
          # @param document [Google::Cloud::Dialogflow::V2beta1::Document | Hash]
          #   Required. The document to create.
          #   A hash of the same form as `Google::Cloud::Dialogflow::V2beta1::Document`
          #   can also be provided.
          # @param import_gcs_custom_metadata [true, false]
          #   Whether to import custom metadata from Google Cloud Storage.
          #   Only valid when the document source is Google Cloud Storage URI.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   documents_client = Google::Cloud::Dialogflow::Documents.new(version: :v2beta1)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #
          #   # TODO: Initialize `document`:
          #   document = {}
          #
          #   # Register a callback during the method call.
          #   operation = documents_client.create_document(parent, document) do |op|
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

          def create_document \
              parent,
              document,
              import_gcs_custom_metadata: nil,
              options: nil
            req = {
              parent: parent,
              document: document,
              import_gcs_custom_metadata: import_gcs_custom_metadata
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::CreateDocumentRequest)
            operation = Google::Gax::Operation.new(
              @create_document.call(req, options),
              @operations_client,
              Google::Cloud::Dialogflow::V2beta1::Document,
              Google::Cloud::Dialogflow::V2beta1::KnowledgeOperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Deletes the specified document.
          #
          # Note: The `projects.agent.knowledgeBases.documents` resource is deprecated;
          # only use `projects.knowledgeBases.documents`.
          #
          # @param name [String]
          #   Required. The name of the document to delete.
          #   Format: `projects/<Project ID>/locations/<Location
          #   ID>/knowledgeBases/<Knowledge Base ID>/documents/<Document ID>`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   documents_client = Google::Cloud::Dialogflow::Documents.new(version: :v2beta1)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #
          #   # Register a callback during the method call.
          #   operation = documents_client.delete_document(name) do |op|
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

          def delete_document \
              name,
              options: nil
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::DeleteDocumentRequest)
            operation = Google::Gax::Operation.new(
              @delete_document.call(req, options),
              @operations_client,
              Google::Protobuf::Empty,
              Google::Cloud::Dialogflow::V2beta1::KnowledgeOperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Updates the specified document.
          #
          # Note: The `projects.agent.knowledgeBases.documents` resource is deprecated;
          # only use `projects.knowledgeBases.documents`.
          #
          # @param document [Google::Cloud::Dialogflow::V2beta1::Document | Hash]
          #   Required. The document to update.
          #   A hash of the same form as `Google::Cloud::Dialogflow::V2beta1::Document`
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
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   documents_client = Google::Cloud::Dialogflow::Documents.new(version: :v2beta1)
          #
          #   # TODO: Initialize `document`:
          #   document = {}
          #
          #   # Register a callback during the method call.
          #   operation = documents_client.update_document(document) do |op|
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

          def update_document \
              document,
              update_mask: nil,
              options: nil
            req = {
              document: document,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::UpdateDocumentRequest)
            operation = Google::Gax::Operation.new(
              @update_document.call(req, options),
              @operations_client,
              Google::Cloud::Dialogflow::V2beta1::Document,
              Google::Cloud::Dialogflow::V2beta1::KnowledgeOperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Reloads the specified document from its specified source, content_uri or
          # content. The previously loaded content of the document will be deleted.
          # Note: Even when the content of the document has not changed, there still
          # may be side effects because of internal implementation changes.
          # Note: If the document source is Google Cloud Storage URI, its metadata will
          # be replaced with the custom metadata from Google Cloud Storage if the
          # `import_gcs_custom_metadata` field is set to true in the request.
          #
          # Note: The `projects.agent.knowledgeBases.documents` resource is deprecated;
          # only use `projects.knowledgeBases.documents`.
          #
          # @param name [String]
          #   Required. The name of the document to reload.
          #   Format: `projects/<Project ID>/locations/<Location
          #   ID>/knowledgeBases/<Knowledge Base ID>/documents/<Document ID>`
          # @param gcs_source [Google::Cloud::Dialogflow::V2beta1::GcsSource | Hash]
          #   The path for a Cloud Storage source file for reloading document content.
          #   If not provided, the Document's existing source will be reloaded.
          #   A hash of the same form as `Google::Cloud::Dialogflow::V2beta1::GcsSource`
          #   can also be provided.
          # @param import_gcs_custom_metadata [true, false]
          #   Whether to import custom metadata from Google Cloud Storage.
          #   Only valid when the document source is Google Cloud Storage URI.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   documents_client = Google::Cloud::Dialogflow::Documents.new(version: :v2beta1)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #
          #   # Register a callback during the method call.
          #   operation = documents_client.reload_document(name) do |op|
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

          def reload_document \
              name,
              gcs_source: nil,
              import_gcs_custom_metadata: nil,
              options: nil
            req = {
              name: name,
              gcs_source: gcs_source,
              import_gcs_custom_metadata: import_gcs_custom_metadata
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::ReloadDocumentRequest)
            operation = Google::Gax::Operation.new(
              @reload_document.call(req, options),
              @operations_client,
              Google::Cloud::Dialogflow::V2beta1::Document,
              Google::Cloud::Dialogflow::V2beta1::KnowledgeOperationMetadata,
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
