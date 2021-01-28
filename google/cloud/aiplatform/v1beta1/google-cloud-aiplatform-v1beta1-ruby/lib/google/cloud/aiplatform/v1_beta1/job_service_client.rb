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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/aiplatform/v1beta1/job_service.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"
require "google/gax/operation"
require "google/longrunning/operations_client"

require "google/cloud/aiplatform/v1beta1/job_service_pb"
require "google/cloud/aiplatform/v1_beta1/credentials"

module Google
  module Cloud
    module Aiplatform
      module V1Beta1
        # A service for creating and managing AI Platform's jobs.
        #
        # @!attribute [r] job_service_stub
        #   @return [Google::Cloud::Aiplatform::V1beta1::JobService::Stub]
        class JobServiceClient
          attr_reader :job_service_stub

          # The default address of the service.
          SERVICE_ADDRESS = "aiplatform.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_custom_jobs" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "custom_jobs"),
            "list_data_labeling_jobs" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "data_labeling_jobs"),
            "list_hyperparameter_tuning_jobs" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "hyperparameter_tuning_jobs"),
            "list_batch_prediction_jobs" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "batch_prediction_jobs")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform"
          ].freeze

          class OperationsClient < Google::Longrunning::OperationsClient
            self::SERVICE_ADDRESS = JobServiceClient::SERVICE_ADDRESS
            self::GRPC_INTERCEPTORS = JobServiceClient::GRPC_INTERCEPTORS
          end

          BATCH_PREDICTION_JOB_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/batchPredictionJobs/{batch_prediction_job}"
          )

          private_constant :BATCH_PREDICTION_JOB_PATH_TEMPLATE

          CUSTOM_JOB_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/customJobs/{custom_job}"
          )

          private_constant :CUSTOM_JOB_PATH_TEMPLATE

          DATA_LABELING_JOB_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}"
          )

          private_constant :DATA_LABELING_JOB_PATH_TEMPLATE

          DATASET_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/datasets/{dataset}"
          )

          private_constant :DATASET_PATH_TEMPLATE

          HYPERPARAMETER_TUNING_JOB_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}"
          )

          private_constant :HYPERPARAMETER_TUNING_JOB_PATH_TEMPLATE

          LOCATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}"
          )

          private_constant :LOCATION_PATH_TEMPLATE

          MODEL_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/models/{model}"
          )

          private_constant :MODEL_PATH_TEMPLATE

          # Returns a fully-qualified batch_prediction_job resource name string.
          # @param project [String]
          # @param location [String]
          # @param batch_prediction_job [String]
          # @return [String]
          def self.batch_prediction_job_path project, location, batch_prediction_job
            BATCH_PREDICTION_JOB_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"batch_prediction_job" => batch_prediction_job
            )
          end

          # Returns a fully-qualified custom_job resource name string.
          # @param project [String]
          # @param location [String]
          # @param custom_job [String]
          # @return [String]
          def self.custom_job_path project, location, custom_job
            CUSTOM_JOB_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"custom_job" => custom_job
            )
          end

          # Returns a fully-qualified data_labeling_job resource name string.
          # @param project [String]
          # @param location [String]
          # @param data_labeling_job [String]
          # @return [String]
          def self.data_labeling_job_path project, location, data_labeling_job
            DATA_LABELING_JOB_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"data_labeling_job" => data_labeling_job
            )
          end

          # Returns a fully-qualified dataset resource name string.
          # @param project [String]
          # @param location [String]
          # @param dataset [String]
          # @return [String]
          def self.dataset_path project, location, dataset
            DATASET_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"dataset" => dataset
            )
          end

          # Returns a fully-qualified hyperparameter_tuning_job resource name string.
          # @param project [String]
          # @param location [String]
          # @param hyperparameter_tuning_job [String]
          # @return [String]
          def self.hyperparameter_tuning_job_path project, location, hyperparameter_tuning_job
            HYPERPARAMETER_TUNING_JOB_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"hyperparameter_tuning_job" => hyperparameter_tuning_job
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
            require "google/cloud/aiplatform/v1beta1/job_service_services_pb"

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
              "job_service_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.aiplatform.v1beta1.JobService",
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
            @job_service_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Aiplatform::V1beta1::JobService::Stub.method(:new)
            )

            @create_custom_job = Google::Gax.create_api_call(
              @job_service_stub.method(:create_custom_job),
              defaults["create_custom_job"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_custom_job = Google::Gax.create_api_call(
              @job_service_stub.method(:get_custom_job),
              defaults["get_custom_job"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_custom_jobs = Google::Gax.create_api_call(
              @job_service_stub.method(:list_custom_jobs),
              defaults["list_custom_jobs"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @delete_custom_job = Google::Gax.create_api_call(
              @job_service_stub.method(:delete_custom_job),
              defaults["delete_custom_job"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @cancel_custom_job = Google::Gax.create_api_call(
              @job_service_stub.method(:cancel_custom_job),
              defaults["cancel_custom_job"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @create_data_labeling_job = Google::Gax.create_api_call(
              @job_service_stub.method(:create_data_labeling_job),
              defaults["create_data_labeling_job"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_data_labeling_job = Google::Gax.create_api_call(
              @job_service_stub.method(:get_data_labeling_job),
              defaults["get_data_labeling_job"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_data_labeling_jobs = Google::Gax.create_api_call(
              @job_service_stub.method(:list_data_labeling_jobs),
              defaults["list_data_labeling_jobs"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @delete_data_labeling_job = Google::Gax.create_api_call(
              @job_service_stub.method(:delete_data_labeling_job),
              defaults["delete_data_labeling_job"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @cancel_data_labeling_job = Google::Gax.create_api_call(
              @job_service_stub.method(:cancel_data_labeling_job),
              defaults["cancel_data_labeling_job"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @create_hyperparameter_tuning_job = Google::Gax.create_api_call(
              @job_service_stub.method(:create_hyperparameter_tuning_job),
              defaults["create_hyperparameter_tuning_job"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_hyperparameter_tuning_job = Google::Gax.create_api_call(
              @job_service_stub.method(:get_hyperparameter_tuning_job),
              defaults["get_hyperparameter_tuning_job"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_hyperparameter_tuning_jobs = Google::Gax.create_api_call(
              @job_service_stub.method(:list_hyperparameter_tuning_jobs),
              defaults["list_hyperparameter_tuning_jobs"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @delete_hyperparameter_tuning_job = Google::Gax.create_api_call(
              @job_service_stub.method(:delete_hyperparameter_tuning_job),
              defaults["delete_hyperparameter_tuning_job"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @cancel_hyperparameter_tuning_job = Google::Gax.create_api_call(
              @job_service_stub.method(:cancel_hyperparameter_tuning_job),
              defaults["cancel_hyperparameter_tuning_job"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @create_batch_prediction_job = Google::Gax.create_api_call(
              @job_service_stub.method(:create_batch_prediction_job),
              defaults["create_batch_prediction_job"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_batch_prediction_job = Google::Gax.create_api_call(
              @job_service_stub.method(:get_batch_prediction_job),
              defaults["get_batch_prediction_job"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_batch_prediction_jobs = Google::Gax.create_api_call(
              @job_service_stub.method(:list_batch_prediction_jobs),
              defaults["list_batch_prediction_jobs"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @delete_batch_prediction_job = Google::Gax.create_api_call(
              @job_service_stub.method(:delete_batch_prediction_job),
              defaults["delete_batch_prediction_job"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @cancel_batch_prediction_job = Google::Gax.create_api_call(
              @job_service_stub.method(:cancel_batch_prediction_job),
              defaults["cancel_batch_prediction_job"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
          end

          # Service calls

          # Creates a CustomJob. A created CustomJob right away
          # will be attempted to be run.
          #
          # @param parent [String]
          #   Required. The resource name of the Location to create the CustomJob in.
          #   Format: `projects/{project}/locations/{location}`
          # @param custom_job [Google::Cloud::Aiplatform::V1beta1::CustomJob | Hash]
          #   Required. The CustomJob to create.
          #   A hash of the same form as `Google::Cloud::Aiplatform::V1beta1::CustomJob`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1beta1::CustomJob]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1beta1::CustomJob]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   job_client = Google::Cloud::Aiplatform::V1Beta1::Job.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1Beta1::JobServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # TODO: Initialize `custom_job`:
          #   custom_job = {}
          #   response = job_client.create_custom_job(formatted_parent, custom_job)

          def create_custom_job \
              parent,
              custom_job,
              options: nil,
              &block
            req = {
              parent: parent,
              custom_job: custom_job
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::CreateCustomJobRequest)
            @create_custom_job.call(req, options, &block)
          end

          # Gets a CustomJob.
          #
          # @param name [String]
          #   Required. The name of the CustomJob resource.
          #   Format:
          #   `projects/{project}/locations/{location}/customJobs/{custom_job}`
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1beta1::CustomJob]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1beta1::CustomJob]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   job_client = Google::Cloud::Aiplatform::V1Beta1::Job.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::JobServiceClient.custom_job_path("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]")
          #   response = job_client.get_custom_job(formatted_name)

          def get_custom_job \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::GetCustomJobRequest)
            @get_custom_job.call(req, options, &block)
          end

          # Lists CustomJobs in a Location.
          #
          # @param parent [String]
          #   Required. The resource name of the Location to list the CustomJobs from.
          #   Format: `projects/{project}/locations/{location}`
          # @param filter [String]
          #   The standard list filter.
          #
          #   Supported fields:
          #
          #   * `display_name` supports = and !=.
          #
          #     * `state` supports = and !=.
          #
          #     Some examples of using the filter are:
          #
          #   * `state="JOB_STATE_SUCCEEDED" AND display_name="my_job"`
          #
          #   * `state="JOB_STATE_RUNNING" OR display_name="my_job"`
          #
          #   * `NOT display_name="my_job"`
          #
          #   * `state="JOB_STATE_FAILED"`
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1beta1::CustomJob>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1beta1::CustomJob>]
          #   An enumerable of Google::Cloud::Aiplatform::V1beta1::CustomJob instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   job_client = Google::Cloud::Aiplatform::V1Beta1::Job.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1Beta1::JobServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # Iterate over all results.
          #   job_client.list_custom_jobs(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   job_client.list_custom_jobs(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_custom_jobs \
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
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::ListCustomJobsRequest)
            @list_custom_jobs.call(req, options, &block)
          end

          # Deletes a CustomJob.
          #
          # @param name [String]
          #   Required. The name of the CustomJob resource to be deleted.
          #   Format:
          #   `projects/{project}/locations/{location}/customJobs/{custom_job}`
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   job_client = Google::Cloud::Aiplatform::V1Beta1::Job.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::JobServiceClient.custom_job_path("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]")
          #
          #   # Register a callback during the method call.
          #   operation = job_client.delete_custom_job(formatted_name) do |op|
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

          def delete_custom_job \
              name,
              options: nil
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::DeleteCustomJobRequest)
            operation = Google::Gax::Operation.new(
              @delete_custom_job.call(req, options),
              @operations_client,
              Google::Protobuf::Empty,
              Google::Cloud::Aiplatform::V1beta1::DeleteOperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Cancels a CustomJob.
          # Starts asynchronous cancellation on the CustomJob. The server
          # makes a best effort to cancel the job, but success is not
          # guaranteed. Clients can use {Google::Cloud::Aiplatform::V1beta1::JobService::GetCustomJob JobService::GetCustomJob} or
          # other methods to check whether the cancellation succeeded or whether the
          # job completed despite cancellation. On successful cancellation,
          # the CustomJob is not deleted; instead it becomes a job with
          # a {Google::Cloud::Aiplatform::V1beta1::CustomJob#error CustomJob#error} value with a {Google::Rpc::Status#code} of 1,
          # corresponding to `Code.CANCELLED`, and {Google::Cloud::Aiplatform::V1beta1::CustomJob#state CustomJob#state} is set to
          # `CANCELLED`.
          #
          # @param name [String]
          #   Required. The name of the CustomJob to cancel.
          #   Format:
          #   `projects/{project}/locations/{location}/customJobs/{custom_job}`
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
          #   job_client = Google::Cloud::Aiplatform::V1Beta1::Job.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::JobServiceClient.custom_job_path("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]")
          #   job_client.cancel_custom_job(formatted_name)

          def cancel_custom_job \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::CancelCustomJobRequest)
            @cancel_custom_job.call(req, options, &block)
            nil
          end

          # Creates a DataLabelingJob.
          #
          # @param parent [String]
          #   Required. The parent of the DataLabelingJob.
          #   Format: `projects/{project}/locations/{location}`
          # @param data_labeling_job [Google::Cloud::Aiplatform::V1beta1::DataLabelingJob | Hash]
          #   Required. The DataLabelingJob to create.
          #   A hash of the same form as `Google::Cloud::Aiplatform::V1beta1::DataLabelingJob`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1beta1::DataLabelingJob]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1beta1::DataLabelingJob]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   job_client = Google::Cloud::Aiplatform::V1Beta1::Job.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1Beta1::JobServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # TODO: Initialize `data_labeling_job`:
          #   data_labeling_job = {}
          #   response = job_client.create_data_labeling_job(formatted_parent, data_labeling_job)

          def create_data_labeling_job \
              parent,
              data_labeling_job,
              options: nil,
              &block
            req = {
              parent: parent,
              data_labeling_job: data_labeling_job
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::CreateDataLabelingJobRequest)
            @create_data_labeling_job.call(req, options, &block)
          end

          # Gets a DataLabelingJob.
          #
          # @param name [String]
          #   Required. The name of the DataLabelingJob.
          #   Format:
          #
          #   `projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}`
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1beta1::DataLabelingJob]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1beta1::DataLabelingJob]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   job_client = Google::Cloud::Aiplatform::V1Beta1::Job.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::JobServiceClient.data_labeling_job_path("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]")
          #   response = job_client.get_data_labeling_job(formatted_name)

          def get_data_labeling_job \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::GetDataLabelingJobRequest)
            @get_data_labeling_job.call(req, options, &block)
          end

          # Lists DataLabelingJobs in a Location.
          #
          # @param parent [String]
          #   Required. The parent of the DataLabelingJob.
          #   Format: `projects/{project}/locations/{location}`
          # @param filter [String]
          #   The standard list filter.
          #
          #   Supported fields:
          #
          #   * `display_name` supports = and !=.
          #
          #     * `state` supports = and !=.
          #
          #     Some examples of using the filter are:
          #
          #   * `state="JOB_STATE_SUCCEEDED" AND display_name="my_job"`
          #
          #   * `state="JOB_STATE_RUNNING" OR display_name="my_job"`
          #
          #   * `NOT display_name="my_job"`
          #
          #   * `state="JOB_STATE_FAILED"`
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param read_mask [Google::Protobuf::FieldMask | Hash]
          #   Mask specifying which fields to read. FieldMask represents a set of
          #   symbolic field paths. For example, the mask can be `paths: "name"`. The
          #   "name" here is a field in DataLabelingJob.
          #   If this field is not set, all fields of the DataLabelingJob are returned.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param order_by [String]
          #   A comma-separated list of fields to order by, sorted in ascending order by
          #   default.
          #   Use `desc` after a field name for descending.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1beta1::DataLabelingJob>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1beta1::DataLabelingJob>]
          #   An enumerable of Google::Cloud::Aiplatform::V1beta1::DataLabelingJob instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   job_client = Google::Cloud::Aiplatform::V1Beta1::Job.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1Beta1::JobServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # Iterate over all results.
          #   job_client.list_data_labeling_jobs(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   job_client.list_data_labeling_jobs(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_data_labeling_jobs \
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
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::ListDataLabelingJobsRequest)
            @list_data_labeling_jobs.call(req, options, &block)
          end

          # Deletes a DataLabelingJob.
          #
          # @param name [String]
          #   Required. The name of the DataLabelingJob to be deleted.
          #   Format:
          #
          #   `projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}`
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   job_client = Google::Cloud::Aiplatform::V1Beta1::Job.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::JobServiceClient.data_labeling_job_path("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]")
          #
          #   # Register a callback during the method call.
          #   operation = job_client.delete_data_labeling_job(formatted_name) do |op|
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

          def delete_data_labeling_job \
              name,
              options: nil
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::DeleteDataLabelingJobRequest)
            operation = Google::Gax::Operation.new(
              @delete_data_labeling_job.call(req, options),
              @operations_client,
              Google::Protobuf::Empty,
              Google::Cloud::Aiplatform::V1beta1::DeleteOperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Cancels a DataLabelingJob. Success of cancellation is not guaranteed.
          #
          # @param name [String]
          #   Required. The name of the DataLabelingJob.
          #   Format:
          #
          #   `projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}`
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
          #   job_client = Google::Cloud::Aiplatform::V1Beta1::Job.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::JobServiceClient.data_labeling_job_path("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]")
          #   job_client.cancel_data_labeling_job(formatted_name)

          def cancel_data_labeling_job \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::CancelDataLabelingJobRequest)
            @cancel_data_labeling_job.call(req, options, &block)
            nil
          end

          # Creates a HyperparameterTuningJob
          #
          # @param parent [String]
          #   Required. The resource name of the Location to create the HyperparameterTuningJob in.
          #   Format: `projects/{project}/locations/{location}`
          # @param hyperparameter_tuning_job [Google::Cloud::Aiplatform::V1beta1::HyperparameterTuningJob | Hash]
          #   Required. The HyperparameterTuningJob to create.
          #   A hash of the same form as `Google::Cloud::Aiplatform::V1beta1::HyperparameterTuningJob`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1beta1::HyperparameterTuningJob]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1beta1::HyperparameterTuningJob]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   job_client = Google::Cloud::Aiplatform::V1Beta1::Job.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1Beta1::JobServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # TODO: Initialize `hyperparameter_tuning_job`:
          #   hyperparameter_tuning_job = {}
          #   response = job_client.create_hyperparameter_tuning_job(formatted_parent, hyperparameter_tuning_job)

          def create_hyperparameter_tuning_job \
              parent,
              hyperparameter_tuning_job,
              options: nil,
              &block
            req = {
              parent: parent,
              hyperparameter_tuning_job: hyperparameter_tuning_job
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::CreateHyperparameterTuningJobRequest)
            @create_hyperparameter_tuning_job.call(req, options, &block)
          end

          # Gets a HyperparameterTuningJob
          #
          # @param name [String]
          #   Required. The name of the HyperparameterTuningJob resource.
          #   Format:
          #
          #   `projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}`
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1beta1::HyperparameterTuningJob]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1beta1::HyperparameterTuningJob]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   job_client = Google::Cloud::Aiplatform::V1Beta1::Job.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::JobServiceClient.hyperparameter_tuning_job_path("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]")
          #   response = job_client.get_hyperparameter_tuning_job(formatted_name)

          def get_hyperparameter_tuning_job \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::GetHyperparameterTuningJobRequest)
            @get_hyperparameter_tuning_job.call(req, options, &block)
          end

          # Lists HyperparameterTuningJobs in a Location.
          #
          # @param parent [String]
          #   Required. The resource name of the Location to list the HyperparameterTuningJobs
          #   from. Format: `projects/{project}/locations/{location}`
          # @param filter [String]
          #   The standard list filter.
          #
          #   Supported fields:
          #
          #   * `display_name` supports = and !=.
          #
          #     * `state` supports = and !=.
          #
          #     Some examples of using the filter are:
          #
          #   * `state="JOB_STATE_SUCCEEDED" AND display_name="my_job"`
          #
          #   * `state="JOB_STATE_RUNNING" OR display_name="my_job"`
          #
          #   * `NOT display_name="my_job"`
          #
          #   * `state="JOB_STATE_FAILED"`
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1beta1::HyperparameterTuningJob>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1beta1::HyperparameterTuningJob>]
          #   An enumerable of Google::Cloud::Aiplatform::V1beta1::HyperparameterTuningJob instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   job_client = Google::Cloud::Aiplatform::V1Beta1::Job.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1Beta1::JobServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # Iterate over all results.
          #   job_client.list_hyperparameter_tuning_jobs(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   job_client.list_hyperparameter_tuning_jobs(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_hyperparameter_tuning_jobs \
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
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::ListHyperparameterTuningJobsRequest)
            @list_hyperparameter_tuning_jobs.call(req, options, &block)
          end

          # Deletes a HyperparameterTuningJob.
          #
          # @param name [String]
          #   Required. The name of the HyperparameterTuningJob resource to be deleted.
          #   Format:
          #
          #   `projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}`
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   job_client = Google::Cloud::Aiplatform::V1Beta1::Job.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::JobServiceClient.hyperparameter_tuning_job_path("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]")
          #
          #   # Register a callback during the method call.
          #   operation = job_client.delete_hyperparameter_tuning_job(formatted_name) do |op|
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

          def delete_hyperparameter_tuning_job \
              name,
              options: nil
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::DeleteHyperparameterTuningJobRequest)
            operation = Google::Gax::Operation.new(
              @delete_hyperparameter_tuning_job.call(req, options),
              @operations_client,
              Google::Protobuf::Empty,
              Google::Cloud::Aiplatform::V1beta1::DeleteOperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Cancels a HyperparameterTuningJob.
          # Starts asynchronous cancellation on the HyperparameterTuningJob. The server
          # makes a best effort to cancel the job, but success is not
          # guaranteed. Clients can use {Google::Cloud::Aiplatform::V1beta1::JobService::GetHyperparameterTuningJob JobService::GetHyperparameterTuningJob} or
          # other methods to check whether the cancellation succeeded or whether the
          # job completed despite cancellation. On successful cancellation,
          # the HyperparameterTuningJob is not deleted; instead it becomes a job with
          # a {Google::Cloud::Aiplatform::V1beta1::HyperparameterTuningJob#error HyperparameterTuningJob#error} value with a {Google::Rpc::Status#code}
          # of 1, corresponding to `Code.CANCELLED`, and
          # {Google::Cloud::Aiplatform::V1beta1::HyperparameterTuningJob#state HyperparameterTuningJob#state} is set to `CANCELLED`.
          #
          # @param name [String]
          #   Required. The name of the HyperparameterTuningJob to cancel.
          #   Format:
          #
          #   `projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}`
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
          #   job_client = Google::Cloud::Aiplatform::V1Beta1::Job.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::JobServiceClient.hyperparameter_tuning_job_path("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]")
          #   job_client.cancel_hyperparameter_tuning_job(formatted_name)

          def cancel_hyperparameter_tuning_job \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::CancelHyperparameterTuningJobRequest)
            @cancel_hyperparameter_tuning_job.call(req, options, &block)
            nil
          end

          # Creates a BatchPredictionJob. A BatchPredictionJob once created will
          # right away be attempted to start.
          #
          # @param parent [String]
          #   Required. The resource name of the Location to create the BatchPredictionJob in.
          #   Format: `projects/{project}/locations/{location}`
          # @param batch_prediction_job [Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob | Hash]
          #   Required. The BatchPredictionJob to create.
          #   A hash of the same form as `Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   job_client = Google::Cloud::Aiplatform::V1Beta1::Job.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1Beta1::JobServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # TODO: Initialize `batch_prediction_job`:
          #   batch_prediction_job = {}
          #   response = job_client.create_batch_prediction_job(formatted_parent, batch_prediction_job)

          def create_batch_prediction_job \
              parent,
              batch_prediction_job,
              options: nil,
              &block
            req = {
              parent: parent,
              batch_prediction_job: batch_prediction_job
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::CreateBatchPredictionJobRequest)
            @create_batch_prediction_job.call(req, options, &block)
          end

          # Gets a BatchPredictionJob
          #
          # @param name [String]
          #   Required. The name of the BatchPredictionJob resource.
          #   Format:
          #
          #   `projects/{project}/locations/{location}/batchPredictionJobs/{batch_prediction_job}`
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   job_client = Google::Cloud::Aiplatform::V1Beta1::Job.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::JobServiceClient.batch_prediction_job_path("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]")
          #   response = job_client.get_batch_prediction_job(formatted_name)

          def get_batch_prediction_job \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::GetBatchPredictionJobRequest)
            @get_batch_prediction_job.call(req, options, &block)
          end

          # Lists BatchPredictionJobs in a Location.
          #
          # @param parent [String]
          #   Required. The resource name of the Location to list the BatchPredictionJobs
          #   from. Format: `projects/{project}/locations/{location}`
          # @param filter [String]
          #   The standard list filter.
          #
          #   Supported fields:
          #
          #   * `display_name` supports = and !=.
          #
          #     * `state` supports = and !=.
          #
          #     Some examples of using the filter are:
          #
          #   * `state="JOB_STATE_SUCCEEDED" AND display_name="my_job"`
          #
          #   * `state="JOB_STATE_RUNNING" OR display_name="my_job"`
          #
          #   * `NOT display_name="my_job"`
          #
          #   * `state="JOB_STATE_FAILED"`
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob>]
          #   An enumerable of Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   job_client = Google::Cloud::Aiplatform::V1Beta1::Job.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1Beta1::JobServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # Iterate over all results.
          #   job_client.list_batch_prediction_jobs(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   job_client.list_batch_prediction_jobs(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_batch_prediction_jobs \
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
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::ListBatchPredictionJobsRequest)
            @list_batch_prediction_jobs.call(req, options, &block)
          end

          # Deletes a BatchPredictionJob. Can only be called on jobs that already
          # finished.
          #
          # @param name [String]
          #   Required. The name of the BatchPredictionJob resource to be deleted.
          #   Format:
          #
          #   `projects/{project}/locations/{location}/batchPredictionJobs/{batch_prediction_job}`
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   job_client = Google::Cloud::Aiplatform::V1Beta1::Job.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::JobServiceClient.batch_prediction_job_path("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]")
          #
          #   # Register a callback during the method call.
          #   operation = job_client.delete_batch_prediction_job(formatted_name) do |op|
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

          def delete_batch_prediction_job \
              name,
              options: nil
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::DeleteBatchPredictionJobRequest)
            operation = Google::Gax::Operation.new(
              @delete_batch_prediction_job.call(req, options),
              @operations_client,
              Google::Protobuf::Empty,
              Google::Cloud::Aiplatform::V1beta1::DeleteOperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Cancels a BatchPredictionJob.
          #
          # Starts asynchronous cancellation on the BatchPredictionJob. The server
          # makes the best effort to cancel the job, but success is not
          # guaranteed. Clients can use {Google::Cloud::Aiplatform::V1beta1::JobService::GetBatchPredictionJob JobService::GetBatchPredictionJob} or
          # other methods to check whether the cancellation succeeded or whether the
          # job completed despite cancellation. On a successful cancellation,
          # the BatchPredictionJob is not deleted;instead its
          # {Google::Cloud::Aiplatform::V1beta1::BatchPredictionJob#state BatchPredictionJob#state} is set to `CANCELLED`. Any files already
          # outputted by the job are not deleted.
          #
          # @param name [String]
          #   Required. The name of the BatchPredictionJob to cancel.
          #   Format:
          #
          #   `projects/{project}/locations/{location}/batchPredictionJobs/{batch_prediction_job}`
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
          #   job_client = Google::Cloud::Aiplatform::V1Beta1::Job.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::JobServiceClient.batch_prediction_job_path("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]")
          #   job_client.cancel_batch_prediction_job(formatted_name)

          def cancel_batch_prediction_job \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::CancelBatchPredictionJobRequest)
            @cancel_batch_prediction_job.call(req, options, &block)
            nil
          end
        end
      end
    end
  end
end
