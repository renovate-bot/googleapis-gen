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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/aiplatform/v1/model_service.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"
require "google/gax/operation"
require "google/longrunning/operations_client"

require "google/cloud/aiplatform/v1/model_service_pb"
require "google/cloud/aiplatform/v1/credentials"

module Google
  module Cloud
    module Aiplatform
      module V1
        # A service for managing AI Platform's machine learning Models.
        #
        # @!attribute [r] model_service_stub
        #   @return [Google::Cloud::Aiplatform::V1::ModelService::Stub]
        class ModelServiceClient
          attr_reader :model_service_stub

          # The default address of the service.
          SERVICE_ADDRESS = "aiplatform.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_models" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "models"),
            "list_model_evaluations" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "model_evaluations"),
            "list_model_evaluation_slices" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "model_evaluation_slices")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform"
          ].freeze

          class OperationsClient < Google::Longrunning::OperationsClient
            self::SERVICE_ADDRESS = ModelServiceClient::SERVICE_ADDRESS
            self::GRPC_INTERCEPTORS = ModelServiceClient::GRPC_INTERCEPTORS
          end

          LOCATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}"
          )

          private_constant :LOCATION_PATH_TEMPLATE

          MODEL_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/models/{model}"
          )

          private_constant :MODEL_PATH_TEMPLATE

          MODEL_EVALUATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}"
          )

          private_constant :MODEL_EVALUATION_PATH_TEMPLATE

          MODEL_EVALUATION_SLICE_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}"
          )

          private_constant :MODEL_EVALUATION_SLICE_PATH_TEMPLATE

          TRAINING_PIPELINE_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}"
          )

          private_constant :TRAINING_PIPELINE_PATH_TEMPLATE

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

          # Returns a fully-qualified model resource name string.
          # @param project [String]
          # @param location [String]
          # @param model [String]
          # @return [String]
          def self.model_path project, location, model
            MODEL_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"model" => model
            )
          end

          # Returns a fully-qualified model_evaluation resource name string.
          # @param project [String]
          # @param location [String]
          # @param model [String]
          # @param evaluation [String]
          # @return [String]
          def self.model_evaluation_path project, location, model, evaluation
            MODEL_EVALUATION_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"model" => model,
              :"evaluation" => evaluation
            )
          end

          # Returns a fully-qualified model_evaluation_slice resource name string.
          # @param project [String]
          # @param location [String]
          # @param model [String]
          # @param evaluation [String]
          # @param slice [String]
          # @return [String]
          def self.model_evaluation_slice_path project, location, model, evaluation, slice
            MODEL_EVALUATION_SLICE_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"model" => model,
              :"evaluation" => evaluation,
              :"slice" => slice
            )
          end

          # Returns a fully-qualified training_pipeline resource name string.
          # @param project [String]
          # @param location [String]
          # @param training_pipeline [String]
          # @return [String]
          def self.training_pipeline_path project, location, training_pipeline
            TRAINING_PIPELINE_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"training_pipeline" => training_pipeline
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
            require "google/cloud/aiplatform/v1/model_service_services_pb"

            credentials ||= Google::Cloud::Aiplatform::V1::Credentials.default

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
              updater_proc = Google::Cloud::Aiplatform::V1::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-cloud-aiplatform'].version.version

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
              "model_service_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.aiplatform.v1.ModelService",
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
            @model_service_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Aiplatform::V1::ModelService::Stub.method(:new)
            )

            @upload_model = Google::Gax.create_api_call(
              @model_service_stub.method(:upload_model),
              defaults["upload_model"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_model = Google::Gax.create_api_call(
              @model_service_stub.method(:get_model),
              defaults["get_model"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_models = Google::Gax.create_api_call(
              @model_service_stub.method(:list_models),
              defaults["list_models"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @update_model = Google::Gax.create_api_call(
              @model_service_stub.method(:update_model),
              defaults["update_model"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'model.name' => request.model.name}
              end
            )
            @delete_model = Google::Gax.create_api_call(
              @model_service_stub.method(:delete_model),
              defaults["delete_model"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @export_model = Google::Gax.create_api_call(
              @model_service_stub.method(:export_model),
              defaults["export_model"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @get_model_evaluation = Google::Gax.create_api_call(
              @model_service_stub.method(:get_model_evaluation),
              defaults["get_model_evaluation"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_model_evaluations = Google::Gax.create_api_call(
              @model_service_stub.method(:list_model_evaluations),
              defaults["list_model_evaluations"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_model_evaluation_slice = Google::Gax.create_api_call(
              @model_service_stub.method(:get_model_evaluation_slice),
              defaults["get_model_evaluation_slice"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_model_evaluation_slices = Google::Gax.create_api_call(
              @model_service_stub.method(:list_model_evaluation_slices),
              defaults["list_model_evaluation_slices"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
          end

          # Service calls

          # Uploads a Model artifact into AI Platform.
          #
          # @param parent [String]
          #   Required. The resource name of the Location into which to upload the Model.
          #   Format: `projects/{project}/locations/{location}`
          # @param model [Google::Cloud::Aiplatform::V1::Model | Hash]
          #   Required. The Model to create.
          #   A hash of the same form as `Google::Cloud::Aiplatform::V1::Model`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform"
          #
          #   model_client = Google::Cloud::Aiplatform::Model.new(version: :v1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1::ModelServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # TODO: Initialize `model`:
          #   model = {}
          #
          #   # Register a callback during the method call.
          #   operation = model_client.upload_model(formatted_parent, model) do |op|
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

          def upload_model \
              parent,
              model,
              options: nil
            req = {
              parent: parent,
              model: model
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1::UploadModelRequest)
            operation = Google::Gax::Operation.new(
              @upload_model.call(req, options),
              @operations_client,
              Google::Cloud::Aiplatform::V1::UploadModelResponse,
              Google::Cloud::Aiplatform::V1::UploadModelOperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Gets a Model.
          #
          # @param name [String]
          #   Required. The name of the Model resource.
          #   Format: `projects/{project}/locations/{location}/models/{model}`
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1::Model]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1::Model]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform"
          #
          #   model_client = Google::Cloud::Aiplatform::Model.new(version: :v1)
          #   formatted_name = Google::Cloud::Aiplatform::V1::ModelServiceClient.model_path("[PROJECT]", "[LOCATION]", "[MODEL]")
          #   response = model_client.get_model(formatted_name)

          def get_model \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1::GetModelRequest)
            @get_model.call(req, options, &block)
          end

          # Lists Models in a Location.
          #
          # @param parent [String]
          #   Required. The resource name of the Location to list the Models from.
          #   Format: `projects/{project}/locations/{location}`
          # @param filter [String]
          #   An expression for filtering the results of the request. For field names
          #   both snake_case and camelCase are supported.
          #
          #   * `model` supports = and !=. `model` represents the Model ID,
          #     i.e. the last segment of the Model's {Google::Cloud::Aiplatform::V1::Model#name resource name}.
          #     * `display_name` supports = and !=
          #     * `labels` supports general map functions that is:
          #       * `labels.key=value` - key:value equality
          #       * `labels.key:* or labels:key - key existence
          #       * A key including a space must be quoted. `labels."a key"`.
          #
          #       Some examples:
          #     * `model=1234`
          #     * `displayName="myDisplayName"`
          #     * `labels.myKey="myValue"`
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param read_mask [Google::Protobuf::FieldMask | Hash]
          #   Mask specifying which fields to read.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param order_by [String]
          #   A comma-separated list of fields to order by, sorted in ascending order.
          #   Use "desc" after a field name for descending.
          #   Supported fields:
          #   * `display_name`
          #     * `create_time`
          #     * `update_time`
          #
          #     Example: `display_name, create_time desc`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1::Model>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1::Model>]
          #   An enumerable of Google::Cloud::Aiplatform::V1::Model instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform"
          #
          #   model_client = Google::Cloud::Aiplatform::Model.new(version: :v1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1::ModelServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # Iterate over all results.
          #   model_client.list_models(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   model_client.list_models(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_models \
              parent,
              filter: nil,
              page_size: nil,
              read_mask: nil,
              order_by: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              filter: filter,
              page_size: page_size,
              read_mask: read_mask,
              order_by: order_by
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1::ListModelsRequest)
            @list_models.call(req, options, &block)
          end

          # Updates a Model.
          #
          # @param model [Google::Cloud::Aiplatform::V1::Model | Hash]
          #   Required. The Model which replaces the resource on the server.
          #   A hash of the same form as `Google::Cloud::Aiplatform::V1::Model`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Required. The update mask applies to the resource.
          #   For the `FieldMask` definition, see
          #   [FieldMask](https://tinyurl.com/protobufs/google.protobuf#fieldmask).
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1::Model]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1::Model]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform"
          #
          #   model_client = Google::Cloud::Aiplatform::Model.new(version: :v1)
          #
          #   # TODO: Initialize `model`:
          #   model = {}
          #
          #   # TODO: Initialize `update_mask`:
          #   update_mask = {}
          #   response = model_client.update_model(model, update_mask)

          def update_model \
              model,
              update_mask,
              options: nil,
              &block
            req = {
              model: model,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1::UpdateModelRequest)
            @update_model.call(req, options, &block)
          end

          # Deletes a Model.
          # Note: Model can only be deleted if there are no DeployedModels created
          # from it.
          #
          # @param name [String]
          #   Required. The name of the Model resource to be deleted.
          #   Format: `projects/{project}/locations/{location}/models/{model}`
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform"
          #
          #   model_client = Google::Cloud::Aiplatform::Model.new(version: :v1)
          #   formatted_name = Google::Cloud::Aiplatform::V1::ModelServiceClient.model_path("[PROJECT]", "[LOCATION]", "[MODEL]")
          #
          #   # Register a callback during the method call.
          #   operation = model_client.delete_model(formatted_name) do |op|
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

          def delete_model \
              name,
              options: nil
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1::DeleteModelRequest)
            operation = Google::Gax::Operation.new(
              @delete_model.call(req, options),
              @operations_client,
              Google::Protobuf::Empty,
              Google::Cloud::Aiplatform::V1::DeleteOperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Exports a trained, exportable, Model to a location specified by the
          # user. A Model is considered to be exportable if it has at least one
          # {Google::Cloud::Aiplatform::V1::Model#supported_export_formats supported export format}.
          #
          # @param name [String]
          #   Required. The resource name of the Model to export.
          #   Format: `projects/{project}/locations/{location}/models/{model}`
          # @param output_config [Google::Cloud::Aiplatform::V1::ExportModelRequest::OutputConfig | Hash]
          #   Required. The desired output location and configuration.
          #   A hash of the same form as `Google::Cloud::Aiplatform::V1::ExportModelRequest::OutputConfig`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform"
          #
          #   model_client = Google::Cloud::Aiplatform::Model.new(version: :v1)
          #   formatted_name = Google::Cloud::Aiplatform::V1::ModelServiceClient.model_path("[PROJECT]", "[LOCATION]", "[MODEL]")
          #
          #   # TODO: Initialize `output_config`:
          #   output_config = {}
          #
          #   # Register a callback during the method call.
          #   operation = model_client.export_model(formatted_name, output_config) do |op|
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

          def export_model \
              name,
              output_config,
              options: nil
            req = {
              name: name,
              output_config: output_config
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1::ExportModelRequest)
            operation = Google::Gax::Operation.new(
              @export_model.call(req, options),
              @operations_client,
              Google::Cloud::Aiplatform::V1::ExportModelResponse,
              Google::Cloud::Aiplatform::V1::ExportModelOperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Gets a ModelEvaluation.
          #
          # @param name [String]
          #   Required. The name of the ModelEvaluation resource.
          #   Format:
          #
          #   `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}`
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1::ModelEvaluation]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1::ModelEvaluation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform"
          #
          #   model_client = Google::Cloud::Aiplatform::Model.new(version: :v1)
          #   formatted_name = Google::Cloud::Aiplatform::V1::ModelServiceClient.model_evaluation_path("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]")
          #   response = model_client.get_model_evaluation(formatted_name)

          def get_model_evaluation \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1::GetModelEvaluationRequest)
            @get_model_evaluation.call(req, options, &block)
          end

          # Lists ModelEvaluations in a Model.
          #
          # @param parent [String]
          #   Required. The resource name of the Model to list the ModelEvaluations from.
          #   Format: `projects/{project}/locations/{location}/models/{model}`
          # @param filter [String]
          #   The standard list filter.
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param read_mask [Google::Protobuf::FieldMask | Hash]
          #   Mask specifying which fields to read.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1::ModelEvaluation>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1::ModelEvaluation>]
          #   An enumerable of Google::Cloud::Aiplatform::V1::ModelEvaluation instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform"
          #
          #   model_client = Google::Cloud::Aiplatform::Model.new(version: :v1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1::ModelServiceClient.model_path("[PROJECT]", "[LOCATION]", "[MODEL]")
          #
          #   # Iterate over all results.
          #   model_client.list_model_evaluations(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   model_client.list_model_evaluations(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_model_evaluations \
              parent,
              filter: nil,
              page_size: nil,
              read_mask: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              filter: filter,
              page_size: page_size,
              read_mask: read_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1::ListModelEvaluationsRequest)
            @list_model_evaluations.call(req, options, &block)
          end

          # Gets a ModelEvaluationSlice.
          #
          # @param name [String]
          #   Required. The name of the ModelEvaluationSlice resource.
          #   Format:
          #
          #   `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}`
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1::ModelEvaluationSlice]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1::ModelEvaluationSlice]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform"
          #
          #   model_client = Google::Cloud::Aiplatform::Model.new(version: :v1)
          #   formatted_name = Google::Cloud::Aiplatform::V1::ModelServiceClient.model_evaluation_slice_path("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]", "[SLICE]")
          #   response = model_client.get_model_evaluation_slice(formatted_name)

          def get_model_evaluation_slice \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1::GetModelEvaluationSliceRequest)
            @get_model_evaluation_slice.call(req, options, &block)
          end

          # Lists ModelEvaluationSlices in a ModelEvaluation.
          #
          # @param parent [String]
          #   Required. The resource name of the ModelEvaluation to list the ModelEvaluationSlices
          #   from. Format:
          #
          #   `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}`
          # @param filter [String]
          #   The standard list filter.
          #
          #   * `slice.dimension` - for =.
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param read_mask [Google::Protobuf::FieldMask | Hash]
          #   Mask specifying which fields to read.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1::ModelEvaluationSlice>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1::ModelEvaluationSlice>]
          #   An enumerable of Google::Cloud::Aiplatform::V1::ModelEvaluationSlice instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform"
          #
          #   model_client = Google::Cloud::Aiplatform::Model.new(version: :v1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1::ModelServiceClient.model_evaluation_path("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]")
          #
          #   # Iterate over all results.
          #   model_client.list_model_evaluation_slices(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   model_client.list_model_evaluation_slices(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_model_evaluation_slices \
              parent,
              filter: nil,
              page_size: nil,
              read_mask: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              filter: filter,
              page_size: page_size,
              read_mask: read_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1::ListModelEvaluationSlicesRequest)
            @list_model_evaluation_slices.call(req, options, &block)
          end
        end
      end
    end
  end
end
