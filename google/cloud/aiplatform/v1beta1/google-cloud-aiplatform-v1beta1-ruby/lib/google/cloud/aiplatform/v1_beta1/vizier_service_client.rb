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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/aiplatform/v1beta1/vizier_service.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"
require "google/gax/operation"
require "google/longrunning/operations_client"

require "google/cloud/aiplatform/v1beta1/vizier_service_pb"
require "google/cloud/aiplatform/v1_beta1/credentials"

module Google
  module Cloud
    module Aiplatform
      module V1Beta1
        # Cloud AI Platform Vizier API.
        #
        # Vizier service is a GCP service to solve blackbox optimization problems,
        # such as tuning machine learning hyperparameters and searching over deep
        # learning architectures.
        #
        # @!attribute [r] vizier_service_stub
        #   @return [Google::Cloud::Aiplatform::V1beta1::VizierService::Stub]
        class VizierServiceClient
          attr_reader :vizier_service_stub

          # The default address of the service.
          SERVICE_ADDRESS = "aiplatform.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_studies" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "studies"),
            "list_trials" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "trials")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform"
          ].freeze

          class OperationsClient < Google::Longrunning::OperationsClient
            self::SERVICE_ADDRESS = VizierServiceClient::SERVICE_ADDRESS
            self::GRPC_INTERCEPTORS = VizierServiceClient::GRPC_INTERCEPTORS
          end

          CUSTOM_JOB_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/customJobs/{custom_job}"
          )

          private_constant :CUSTOM_JOB_PATH_TEMPLATE

          LOCATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}"
          )

          private_constant :LOCATION_PATH_TEMPLATE

          STUDY_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/studies/{study}"
          )

          private_constant :STUDY_PATH_TEMPLATE

          TRIAL_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/studies/{study}/trials/{trial}"
          )

          private_constant :TRIAL_PATH_TEMPLATE

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

          # Returns a fully-qualified study resource name string.
          # @param project [String]
          # @param location [String]
          # @param study [String]
          # @return [String]
          def self.study_path project, location, study
            STUDY_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"study" => study
            )
          end

          # Returns a fully-qualified trial resource name string.
          # @param project [String]
          # @param location [String]
          # @param study [String]
          # @param trial [String]
          # @return [String]
          def self.trial_path project, location, study, trial
            TRIAL_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"study" => study,
              :"trial" => trial
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
            require "google/cloud/aiplatform/v1beta1/vizier_service_services_pb"

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
              "vizier_service_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.aiplatform.v1beta1.VizierService",
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
            @vizier_service_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.method(:new)
            )

            @create_study = Google::Gax.create_api_call(
              @vizier_service_stub.method(:create_study),
              defaults["create_study"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_study = Google::Gax.create_api_call(
              @vizier_service_stub.method(:get_study),
              defaults["get_study"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_studies = Google::Gax.create_api_call(
              @vizier_service_stub.method(:list_studies),
              defaults["list_studies"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @delete_study = Google::Gax.create_api_call(
              @vizier_service_stub.method(:delete_study),
              defaults["delete_study"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @lookup_study = Google::Gax.create_api_call(
              @vizier_service_stub.method(:lookup_study),
              defaults["lookup_study"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @suggest_trials = Google::Gax.create_api_call(
              @vizier_service_stub.method(:suggest_trials),
              defaults["suggest_trials"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @create_trial = Google::Gax.create_api_call(
              @vizier_service_stub.method(:create_trial),
              defaults["create_trial"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_trial = Google::Gax.create_api_call(
              @vizier_service_stub.method(:get_trial),
              defaults["get_trial"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_trials = Google::Gax.create_api_call(
              @vizier_service_stub.method(:list_trials),
              defaults["list_trials"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @add_trial_measurement = Google::Gax.create_api_call(
              @vizier_service_stub.method(:add_trial_measurement),
              defaults["add_trial_measurement"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'trial_name' => request.trial_name}
              end
            )
            @complete_trial = Google::Gax.create_api_call(
              @vizier_service_stub.method(:complete_trial),
              defaults["complete_trial"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @delete_trial = Google::Gax.create_api_call(
              @vizier_service_stub.method(:delete_trial),
              defaults["delete_trial"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @check_trial_early_stopping_state = Google::Gax.create_api_call(
              @vizier_service_stub.method(:check_trial_early_stopping_state),
              defaults["check_trial_early_stopping_state"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'trial_name' => request.trial_name}
              end
            )
            @stop_trial = Google::Gax.create_api_call(
              @vizier_service_stub.method(:stop_trial),
              defaults["stop_trial"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_optimal_trials = Google::Gax.create_api_call(
              @vizier_service_stub.method(:list_optimal_trials),
              defaults["list_optimal_trials"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
          end

          # Service calls

          # Creates a Study. A resource name will be generated after creation of the
          # Study.
          #
          # @param parent [String]
          #   Required. The resource name of the Location to create the CustomJob in.
          #   Format: `projects/{project}/locations/{location}`
          # @param study [Google::Cloud::Aiplatform::V1beta1::Study | Hash]
          #   Required. The Study configuration used to create the Study.
          #   A hash of the same form as `Google::Cloud::Aiplatform::V1beta1::Study`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1beta1::Study]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1beta1::Study]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   vizier_client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # TODO: Initialize `study`:
          #   study = {}
          #   response = vizier_client.create_study(formatted_parent, study)

          def create_study \
              parent,
              study,
              options: nil,
              &block
            req = {
              parent: parent,
              study: study
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::CreateStudyRequest)
            @create_study.call(req, options, &block)
          end

          # Gets a Study by name.
          #
          # @param name [String]
          #   Required. The name of the Study resource.
          #   Format: `projects/{project}/locations/{location}/studies/{study}`
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1beta1::Study]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1beta1::Study]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   vizier_client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.study_path("[PROJECT]", "[LOCATION]", "[STUDY]")
          #   response = vizier_client.get_study(formatted_name)

          def get_study \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::GetStudyRequest)
            @get_study.call(req, options, &block)
          end

          # Lists all the studies in a region for an associated project.
          #
          # @param parent [String]
          #   Required. The resource name of the Location to list the Study from.
          #   Format: `projects/{project}/locations/{location}`
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1beta1::Study>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1beta1::Study>]
          #   An enumerable of Google::Cloud::Aiplatform::V1beta1::Study instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   vizier_client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # Iterate over all results.
          #   vizier_client.list_studies(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   vizier_client.list_studies(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_studies \
              parent,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::ListStudiesRequest)
            @list_studies.call(req, options, &block)
          end

          # Deletes a Study.
          #
          # @param name [String]
          #   Required. The name of the Study resource to be deleted.
          #   Format: `projects/{project}/locations/{location}/studies/{study}`
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
          #   vizier_client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.study_path("[PROJECT]", "[LOCATION]", "[STUDY]")
          #   vizier_client.delete_study(formatted_name)

          def delete_study \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::DeleteStudyRequest)
            @delete_study.call(req, options, &block)
            nil
          end

          # Looks a study up using the user-defined display_name field instead of the
          # fully qualified resource name.
          #
          # @param parent [String]
          #   Required. The resource name of the Location to get the Study from.
          #   Format: `projects/{project}/locations/{location}`
          # @param display_name [String]
          #   Required. The user-defined display name of the Study
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1beta1::Study]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1beta1::Study]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   vizier_client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # TODO: Initialize `display_name`:
          #   display_name = ''
          #   response = vizier_client.lookup_study(formatted_parent, display_name)

          def lookup_study \
              parent,
              display_name,
              options: nil,
              &block
            req = {
              parent: parent,
              display_name: display_name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::LookupStudyRequest)
            @lookup_study.call(req, options, &block)
          end

          # Adds one or more Trials to a Study, with parameter values
          # suggested by AI Platform Vizier. Returns a long-running
          # operation associated with the generation of Trial suggestions.
          # When this long-running operation succeeds, it will contain
          # a {Google::Cloud::Ml::V1::SuggestTrialsResponse SuggestTrialsResponse}.
          #
          # @param parent [String]
          #   Required. The project and location that the Study belongs to.
          #   Format: `projects/{project}/locations/{location}/studies/{study}`
          # @param suggestion_count [Integer]
          #   Required. The number of suggestions requested.
          # @param client_id [String]
          #   Required. The identifier of the client that is requesting the suggestion.
          #
          #   If multiple SuggestTrialsRequests have the same `client_id`,
          #   the service will return the identical suggested Trial if the Trial is
          #   pending, and provide a new Trial if the last suggested Trial was completed.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   vizier_client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.study_path("[PROJECT]", "[LOCATION]", "[STUDY]")
          #
          #   # TODO: Initialize `suggestion_count`:
          #   suggestion_count = 0
          #
          #   # TODO: Initialize `client_id`:
          #   client_id = ''
          #
          #   # Register a callback during the method call.
          #   operation = vizier_client.suggest_trials(formatted_parent, suggestion_count, client_id) do |op|
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

          def suggest_trials \
              parent,
              suggestion_count,
              client_id,
              options: nil
            req = {
              parent: parent,
              suggestion_count: suggestion_count,
              client_id: client_id
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::SuggestTrialsRequest)
            operation = Google::Gax::Operation.new(
              @suggest_trials.call(req, options),
              @operations_client,
              Google::Cloud::Aiplatform::V1beta1::SuggestTrialsResponse,
              Google::Cloud::Aiplatform::V1beta1::SuggestTrialsMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Adds a user provided Trial to a Study.
          #
          # @param parent [String]
          #   Required. The resource name of the Study to create the Trial in.
          #   Format: `projects/{project}/locations/{location}/studies/{study}`
          # @param trial [Google::Cloud::Aiplatform::V1beta1::Trial | Hash]
          #   Required. The Trial to create.
          #   A hash of the same form as `Google::Cloud::Aiplatform::V1beta1::Trial`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1beta1::Trial]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1beta1::Trial]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   vizier_client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.study_path("[PROJECT]", "[LOCATION]", "[STUDY]")
          #
          #   # TODO: Initialize `trial`:
          #   trial = {}
          #   response = vizier_client.create_trial(formatted_parent, trial)

          def create_trial \
              parent,
              trial,
              options: nil,
              &block
            req = {
              parent: parent,
              trial: trial
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::CreateTrialRequest)
            @create_trial.call(req, options, &block)
          end

          # Gets a Trial.
          #
          # @param name [String]
          #   Required. The name of the Trial resource.
          #   Format:
          #   `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1beta1::Trial]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1beta1::Trial]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   vizier_client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.trial_path("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]")
          #   response = vizier_client.get_trial(formatted_name)

          def get_trial \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::GetTrialRequest)
            @get_trial.call(req, options, &block)
          end

          # Lists the Trials associated with a Study.
          #
          # @param parent [String]
          #   Required. The resource name of the Study to list the Trial from.
          #   Format: `projects/{project}/locations/{location}/studies/{study}`
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1beta1::Trial>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1beta1::Trial>]
          #   An enumerable of Google::Cloud::Aiplatform::V1beta1::Trial instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   vizier_client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.study_path("[PROJECT]", "[LOCATION]", "[STUDY]")
          #
          #   # Iterate over all results.
          #   vizier_client.list_trials(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   vizier_client.list_trials(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_trials \
              parent,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::ListTrialsRequest)
            @list_trials.call(req, options, &block)
          end

          # Adds a measurement of the objective metrics to a Trial. This measurement
          # is assumed to have been taken before the Trial is complete.
          #
          # @param trial_name [String]
          #   Required. The name of the trial to add measurement.
          #   Format:
          #   `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
          # @param measurement [Google::Cloud::Aiplatform::V1beta1::Measurement | Hash]
          #   Required. The measurement to be added to a Trial.
          #   A hash of the same form as `Google::Cloud::Aiplatform::V1beta1::Measurement`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1beta1::Trial]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1beta1::Trial]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   vizier_client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)
          #   formatted_trial_name = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.trial_path("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]")
          #
          #   # TODO: Initialize `measurement`:
          #   measurement = {}
          #   response = vizier_client.add_trial_measurement(formatted_trial_name, measurement)

          def add_trial_measurement \
              trial_name,
              measurement,
              options: nil,
              &block
            req = {
              trial_name: trial_name,
              measurement: measurement
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::AddTrialMeasurementRequest)
            @add_trial_measurement.call(req, options, &block)
          end

          # Marks a Trial as complete.
          #
          # @param name [String]
          #   Required. The Trial's name.
          #   Format:
          #   `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
          # @param final_measurement [Google::Cloud::Aiplatform::V1beta1::Measurement | Hash]
          #   Optional. If provided, it will be used as the completed Trial's
          #   final_measurement; Otherwise, the service will auto-select a
          #   previously reported measurement as the final-measurement
          #   A hash of the same form as `Google::Cloud::Aiplatform::V1beta1::Measurement`
          #   can also be provided.
          # @param trial_infeasible [true, false]
          #   Optional. True if the Trial cannot be run with the given Parameter, and
          #   final_measurement will be ignored.
          # @param infeasible_reason [String]
          #   Optional. A human readable reason why the trial was infeasible. This should
          #   only be provided if `trial_infeasible` is true.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1beta1::Trial]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1beta1::Trial]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   vizier_client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.trial_path("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]")
          #   response = vizier_client.complete_trial(formatted_name)

          def complete_trial \
              name,
              final_measurement: nil,
              trial_infeasible: nil,
              infeasible_reason: nil,
              options: nil,
              &block
            req = {
              name: name,
              final_measurement: final_measurement,
              trial_infeasible: trial_infeasible,
              infeasible_reason: infeasible_reason
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::CompleteTrialRequest)
            @complete_trial.call(req, options, &block)
          end

          # Deletes a Trial.
          #
          # @param name [String]
          #   Required. The Trial's name.
          #   Format:
          #   `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
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
          #   vizier_client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.trial_path("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]")
          #   vizier_client.delete_trial(formatted_name)

          def delete_trial \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::DeleteTrialRequest)
            @delete_trial.call(req, options, &block)
            nil
          end

          # Checks  whether a Trial should stop or not. Returns a
          # long-running operation. When the operation is successful,
          # it will contain a
          # {Google::Cloud::Ml::V1::CheckTrialEarlyStoppingStateResponse CheckTrialEarlyStoppingStateResponse}.
          #
          # @param trial_name [String]
          #   Required. The Trial's name.
          #   Format:
          #   `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   vizier_client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)
          #   formatted_trial_name = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.trial_path("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]")
          #
          #   # Register a callback during the method call.
          #   operation = vizier_client.check_trial_early_stopping_state(formatted_trial_name) do |op|
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

          def check_trial_early_stopping_state \
              trial_name,
              options: nil
            req = {
              trial_name: trial_name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::CheckTrialEarlyStoppingStateRequest)
            operation = Google::Gax::Operation.new(
              @check_trial_early_stopping_state.call(req, options),
              @operations_client,
              Google::Cloud::Aiplatform::V1beta1::CheckTrialEarlyStoppingStateResponse,
              Google::Cloud::Aiplatform::V1beta1::CheckTrialEarlyStoppingStateMetatdata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Stops a Trial.
          #
          # @param name [String]
          #   Required. The Trial's name.
          #   Format:
          #   `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1beta1::Trial]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1beta1::Trial]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   vizier_client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.trial_path("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]")
          #   response = vizier_client.stop_trial(formatted_name)

          def stop_trial \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::StopTrialRequest)
            @stop_trial.call(req, options, &block)
          end

          # Lists the pareto-optimal Trials for multi-objective Study or the
          # optimal Trials for single-objective Study. The definition of
          # pareto-optimal can be checked in wiki page.
          # https://en.wikipedia.org/wiki/Pareto_efficiency
          #
          # @param parent [String]
          #   Required. The name of the Study that the optimal Trial belongs to.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1beta1::ListOptimalTrialsResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1beta1::ListOptimalTrialsResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   vizier_client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.study_path("[PROJECT]", "[LOCATION]", "[STUDY]")
          #   response = vizier_client.list_optimal_trials(formatted_parent)

          def list_optimal_trials \
              parent,
              options: nil,
              &block
            req = {
              parent: parent
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::ListOptimalTrialsRequest)
            @list_optimal_trials.call(req, options, &block)
          end
        end
      end
    end
  end
end
