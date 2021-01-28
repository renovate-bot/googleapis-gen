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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/documentai/v1beta2/document_understanding.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"
require "google/gax/operation"
require "google/longrunning/operations_client"

require "google/cloud/documentai/v1beta2/document_understanding_pb"
require "google/cloud/document_ai/v1beta2/credentials"

module Google
  module Cloud
    module DocumentAi
      module V1beta2
        # Service to parse structured information from unstructured or semi-structured
        # documents using state-of-the-art Google AI such as natural language,
        # computer vision, and translation.
        #
        # @!attribute [r] document_understanding_service_stub
        #   @return [Google::Cloud::Documentai::V1beta2::DocumentUnderstandingService::Stub]
        class DocumentUnderstandingServiceClient
          attr_reader :document_understanding_service_stub

          # The default address of the service.
          SERVICE_ADDRESS = "us-documentai.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform"
          ].freeze

          class OperationsClient < Google::Longrunning::OperationsClient
            self::SERVICE_ADDRESS = DocumentUnderstandingServiceClient::SERVICE_ADDRESS
            self::GRPC_INTERCEPTORS = DocumentUnderstandingServiceClient::GRPC_INTERCEPTORS
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
            require "google/cloud/documentai/v1beta2/document_understanding_services_pb"

            credentials ||= Google::Cloud::DocumentAi::V1beta2::Credentials.default

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
              updater_proc = Google::Cloud::DocumentAi::V1beta2::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-cloud-document_ai'].version.version

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
              "document_understanding_service_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.documentai.v1beta2.DocumentUnderstandingService",
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
            @document_understanding_service_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Documentai::V1beta2::DocumentUnderstandingService::Stub.method(:new)
            )

            @batch_process_documents = Google::Gax.create_api_call(
              @document_understanding_service_stub.method(:batch_process_documents),
              defaults["batch_process_documents"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @process_document = Google::Gax.create_api_call(
              @document_understanding_service_stub.method(:process_document),
              defaults["process_document"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
          end

          # Service calls

          # LRO endpoint to batch process many documents. The output is written
          # to Cloud Storage as JSON in the [Document] format.
          #
          # @param requests [Array<Google::Cloud::Documentai::V1beta2::ProcessDocumentRequest | Hash>]
          #   Required. Individual requests for each document.
          #   A hash of the same form as `Google::Cloud::Documentai::V1beta2::ProcessDocumentRequest`
          #   can also be provided.
          # @param parent [String]
          #   Target project and location to make a call.
          #
          #   Format: `projects/{project-id}/locations/{location-id}`.
          #
          #   If no location is specified, a region will be chosen automatically.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/document_ai"
          #
          #   document_understanding_client = Google::Cloud::DocumentAi.new(version: :v1beta2)
          #
          #   # TODO: Initialize `requests`:
          #   requests = []
          #
          #   # Register a callback during the method call.
          #   operation = document_understanding_client.batch_process_documents(requests) do |op|
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

          def batch_process_documents \
              requests,
              parent: nil,
              options: nil
            req = {
              requests: requests,
              parent: parent
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Documentai::V1beta2::BatchProcessDocumentsRequest)
            operation = Google::Gax::Operation.new(
              @batch_process_documents.call(req, options),
              @operations_client,
              Google::Cloud::Documentai::V1beta2::BatchProcessDocumentsResponse,
              Google::Cloud::Documentai::V1beta2::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Processes a single document.
          #
          # @param input_config [Google::Cloud::Documentai::V1beta2::InputConfig | Hash]
          #   Required. Information about the input file.
          #   A hash of the same form as `Google::Cloud::Documentai::V1beta2::InputConfig`
          #   can also be provided.
          # @param parent [String]
          #   Target project and location to make a call.
          #
          #   Format: `projects/{project-id}/locations/{location-id}`.
          #
          #   If no location is specified, a region will be chosen automatically.
          #   This field is only populated when used in ProcessDocument method.
          # @param output_config [Google::Cloud::Documentai::V1beta2::OutputConfig | Hash]
          #   Optional. The desired output location. This field is only needed in
          #   BatchProcessDocumentsRequest.
          #   A hash of the same form as `Google::Cloud::Documentai::V1beta2::OutputConfig`
          #   can also be provided.
          # @param document_type [String]
          #   Specifies a known document type for deeper structure detection. Valid
          #   values are currently "general" and "invoice". If not provided, "general"\
          #   is used as default. If any other value is given, the request is rejected.
          # @param table_extraction_params [Google::Cloud::Documentai::V1beta2::TableExtractionParams | Hash]
          #   Controls table extraction behavior. If not specified, the system will
          #   decide reasonable defaults.
          #   A hash of the same form as `Google::Cloud::Documentai::V1beta2::TableExtractionParams`
          #   can also be provided.
          # @param form_extraction_params [Google::Cloud::Documentai::V1beta2::FormExtractionParams | Hash]
          #   Controls form extraction behavior. If not specified, the system will
          #   decide reasonable defaults.
          #   A hash of the same form as `Google::Cloud::Documentai::V1beta2::FormExtractionParams`
          #   can also be provided.
          # @param entity_extraction_params [Google::Cloud::Documentai::V1beta2::EntityExtractionParams | Hash]
          #   Controls entity extraction behavior. If not specified, the system will
          #   decide reasonable defaults.
          #   A hash of the same form as `Google::Cloud::Documentai::V1beta2::EntityExtractionParams`
          #   can also be provided.
          # @param ocr_params [Google::Cloud::Documentai::V1beta2::OcrParams | Hash]
          #   Controls OCR behavior. If not specified, the system will decide reasonable
          #   defaults.
          #   A hash of the same form as `Google::Cloud::Documentai::V1beta2::OcrParams`
          #   can also be provided.
          # @param automl_params [Google::Cloud::Documentai::V1beta2::AutoMlParams | Hash]
          #   Controls AutoML model prediction behavior. AutoMlParams cannot be used
          #   together with other Params.
          #   A hash of the same form as `Google::Cloud::Documentai::V1beta2::AutoMlParams`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Documentai::V1beta2::Document]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Documentai::V1beta2::Document]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/document_ai"
          #
          #   document_understanding_client = Google::Cloud::DocumentAi.new(version: :v1beta2)
          #
          #   # TODO: Initialize `input_config`:
          #   input_config = {}
          #   response = document_understanding_client.process_document(input_config)

          def process_document \
              input_config,
              parent: nil,
              output_config: nil,
              document_type: nil,
              table_extraction_params: nil,
              form_extraction_params: nil,
              entity_extraction_params: nil,
              ocr_params: nil,
              automl_params: nil,
              options: nil,
              &block
            req = {
              input_config: input_config,
              parent: parent,
              output_config: output_config,
              document_type: document_type,
              table_extraction_params: table_extraction_params,
              form_extraction_params: form_extraction_params,
              entity_extraction_params: entity_extraction_params,
              ocr_params: ocr_params,
              automl_params: automl_params
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Documentai::V1beta2::ProcessDocumentRequest)
            @process_document.call(req, options, &block)
          end
        end
      end
    end
  end
end
