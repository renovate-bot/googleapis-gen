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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/aiplatform/v1beta1/pipeline_service.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"
require "google/gax/operation"
require "google/longrunning/operations_client"

require "google/cloud/aiplatform/v1beta1/pipeline_service_pb"
require "google/cloud/aiplatform/v1_beta1/credentials"

module Google
  module Cloud
    module Aiplatform
      module V1Beta1
        # A service for creating and managing AI Platform's pipelines.
        #
        # @!attribute [r] pipeline_service_stub
        #   @return [Google::Cloud::Aiplatform::V1beta1::PipelineService::Stub]
        class PipelineServiceClient
          attr_reader :pipeline_service_stub

          # The default address of the service.
          SERVICE_ADDRESS = "aiplatform.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_training_pipelines" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "training_pipelines")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform"
          ].freeze

          class OperationsClient < Google::Longrunning::OperationsClient
            self::SERVICE_ADDRESS = PipelineServiceClient::SERVICE_ADDRESS
            self::GRPC_INTERCEPTORS = PipelineServiceClient::GRPC_INTERCEPTORS
          end

          LOCATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}"
          )

          private_constant :LOCATION_PATH_TEMPLATE

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
            require "google/cloud/aiplatform/v1beta1/pipeline_service_services_pb"

            credentials ||= Google::Cloud::Aiplatform::V1Beta1::Credentials.default

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
              updater_proc = Google::Cloud::Aiplatform::V1Beta1::Credentials.new(credentials).updater_proc
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
              "pipeline_service_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.aiplatform.v1beta1.PipelineService",
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
            @pipeline_service_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Aiplatform::V1beta1::PipelineService::Stub.method(:new)
            )

            @create_training_pipeline = Google::Gax.create_api_call(
              @pipeline_service_stub.method(:create_training_pipeline),
              defaults["create_training_pipeline"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_training_pipeline = Google::Gax.create_api_call(
              @pipeline_service_stub.method(:get_training_pipeline),
              defaults["get_training_pipeline"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_training_pipelines = Google::Gax.create_api_call(
              @pipeline_service_stub.method(:list_training_pipelines),
              defaults["list_training_pipelines"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @delete_training_pipeline = Google::Gax.create_api_call(
              @pipeline_service_stub.method(:delete_training_pipeline),
              defaults["delete_training_pipeline"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @cancel_training_pipeline = Google::Gax.create_api_call(
              @pipeline_service_stub.method(:cancel_training_pipeline),
              defaults["cancel_training_pipeline"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
          end

          # Service calls

          # Creates a TrainingPipeline. A created TrainingPipeline right away will be
          # attempted to be run.
          #
          # @param parent [String]
          #   Required. The resource name of the Location to create the TrainingPipeline in.
          #   Format: `projects/{project}/locations/{location}`
          # @param training_pipeline [Google::Cloud::Aiplatform::V1beta1::TrainingPipeline | Hash]
          #   Required. The TrainingPipeline to create.
          #   A hash of the same form as `Google::Cloud::Aiplatform::V1beta1::TrainingPipeline`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1beta1::TrainingPipeline]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1beta1::TrainingPipeline]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   pipeline_client = Google::Cloud::Aiplatform::V1Beta1::Pipeline.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1Beta1::PipelineServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # TODO: Initialize `training_pipeline`:
          #   training_pipeline = {}
          #   response = pipeline_client.create_training_pipeline(formatted_parent, training_pipeline)

          def create_training_pipeline \
              parent,
              training_pipeline,
              options: nil,
              &block
            req = {
              parent: parent,
              training_pipeline: training_pipeline
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::CreateTrainingPipelineRequest)
            @create_training_pipeline.call(req, options, &block)
          end

          # Gets a TrainingPipeline.
          #
          # @param name [String]
          #   Required. The name of the TrainingPipeline resource.
          #   Format:
          #   `projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}`
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1beta1::TrainingPipeline]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1beta1::TrainingPipeline]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   pipeline_client = Google::Cloud::Aiplatform::V1Beta1::Pipeline.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::PipelineServiceClient.training_pipeline_path("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]")
          #   response = pipeline_client.get_training_pipeline(formatted_name)

          def get_training_pipeline \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::GetTrainingPipelineRequest)
            @get_training_pipeline.call(req, options, &block)
          end

          # Lists TrainingPipelines in a Location.
          #
          # @param parent [String]
          #   Required. The resource name of the Location to list the TrainingPipelines from.
          #   Format: `projects/{project}/locations/{location}`
          # @param filter [String]
          #   The standard list filter.
          #   Supported fields:
          #
          #   * `display_name` supports = and !=.
          #
          #     * `state` supports = and !=.
          #
          #     Some examples of using the filter are:
          #
          #   * `state="PIPELINE_STATE_SUCCEEDED" AND display_name="my_pipeline"`
          #
          #   * `state="PIPELINE_STATE_RUNNING" OR display_name="my_pipeline"`
          #
          #   * `NOT display_name="my_pipeline"`
          #
          #   * `state="PIPELINE_STATE_FAILED"`
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1beta1::TrainingPipeline>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1beta1::TrainingPipeline>]
          #   An enumerable of Google::Cloud::Aiplatform::V1beta1::TrainingPipeline instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   pipeline_client = Google::Cloud::Aiplatform::V1Beta1::Pipeline.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1Beta1::PipelineServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # Iterate over all results.
          #   pipeline_client.list_training_pipelines(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   pipeline_client.list_training_pipelines(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_training_pipelines \
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
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::ListTrainingPipelinesRequest)
            @list_training_pipelines.call(req, options, &block)
          end

          # Deletes a TrainingPipeline.
          #
          # @param name [String]
          #   Required. The name of the TrainingPipeline resource to be deleted.
          #   Format:
          #   `projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}`
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   pipeline_client = Google::Cloud::Aiplatform::V1Beta1::Pipeline.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::PipelineServiceClient.training_pipeline_path("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]")
          #
          #   # Register a callback during the method call.
          #   operation = pipeline_client.delete_training_pipeline(formatted_name) do |op|
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

          def delete_training_pipeline \
              name,
              options: nil
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::DeleteTrainingPipelineRequest)
            operation = Google::Gax::Operation.new(
              @delete_training_pipeline.call(req, options),
              @operations_client,
              Google::Protobuf::Empty,
              Google::Cloud::Aiplatform::V1beta1::DeleteOperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Cancels a TrainingPipeline.
          # Starts asynchronous cancellation on the TrainingPipeline. The server
          # makes a best effort to cancel the pipeline, but success is not
          # guaranteed. Clients can use {Google::Cloud::Aiplatform::V1beta1::PipelineService::GetTrainingPipeline PipelineService::GetTrainingPipeline} or
          # other methods to check whether the cancellation succeeded or whether the
          # pipeline completed despite cancellation. On successful cancellation,
          # the TrainingPipeline is not deleted; instead it becomes a pipeline with
          # a {Google::Cloud::Aiplatform::V1beta1::TrainingPipeline#error TrainingPipeline#error} value with a {Google::Rpc::Status#code} of 1,
          # corresponding to `Code.CANCELLED`, and {Google::Cloud::Aiplatform::V1beta1::TrainingPipeline#state TrainingPipeline#state} is set to
          # `CANCELLED`.
          #
          # @param name [String]
          #   Required. The name of the TrainingPipeline to cancel.
          #   Format:
          #   `projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}`
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   pipeline_client = Google::Cloud::Aiplatform::V1Beta1::Pipeline.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::PipelineServiceClient.training_pipeline_path("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]")
          #   pipeline_client.cancel_training_pipeline(formatted_name)

          def cancel_training_pipeline \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::CancelTrainingPipelineRequest)
            @cancel_training_pipeline.call(req, options, &block)
            nil
          end
        end
      end
    end
  end
end
