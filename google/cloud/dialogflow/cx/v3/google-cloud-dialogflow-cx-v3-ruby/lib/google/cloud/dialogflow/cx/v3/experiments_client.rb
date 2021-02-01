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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/dialogflow/cx/v3/experiment.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/dialogflow/cx/v3/experiment_pb"
require "google/cloud/dialogflow/cx/v3/credentials"

module Google
  module Cloud
    module Dialogflow
      module Cx
        module V3
          # Service for managing {Google::Cloud::Dialogflow::Cx::V3::Experiment Experiments}.
          #
          # @!attribute [r] experiments_stub
          #   @return [Google::Cloud::Dialogflow::Cx::V3::Experiments::Stub]
          class ExperimentsClient
            attr_reader :experiments_stub

            # The default address of the service.
            SERVICE_ADDRESS = "dialogflow.googleapis.com".freeze

            # The default port of the service.
            DEFAULT_SERVICE_PORT = 443

            # The default set of gRPC interceptors.
            GRPC_INTERCEPTORS = []

            DEFAULT_TIMEOUT = 30

            PAGE_DESCRIPTORS = {
              "list_experiments" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "experiments")
            }.freeze

            private_constant :PAGE_DESCRIPTORS

            # The scopes needed to make gRPC calls to all of the methods defined in
            # this service.
            ALL_SCOPES = [
              "https://www.googleapis.com/auth/cloud-platform",
              "https://www.googleapis.com/auth/dialogflow"
            ].freeze


            ENVIRONMENT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}/agents/{agent}/environments/{environment}"
            )

            private_constant :ENVIRONMENT_PATH_TEMPLATE

            EXPERIMENT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/experiments/{experiment}"
            )

            private_constant :EXPERIMENT_PATH_TEMPLATE

            # Returns a fully-qualified environment resource name string.
            # @param project [String]
            # @param location [String]
            # @param agent [String]
            # @param environment [String]
            # @return [String]
            def self.environment_path project, location, agent, environment
              ENVIRONMENT_PATH_TEMPLATE.render(
                :"project" => project,
                :"location" => location,
                :"agent" => agent,
                :"environment" => environment
              )
            end

            # Returns a fully-qualified experiment resource name string.
            # @param project [String]
            # @param location [String]
            # @param agent [String]
            # @param environment [String]
            # @param experiment [String]
            # @return [String]
            def self.experiment_path project, location, agent, environment, experiment
              EXPERIMENT_PATH_TEMPLATE.render(
                :"project" => project,
                :"location" => location,
                :"agent" => agent,
                :"environment" => environment,
                :"experiment" => experiment
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
              require "google/cloud/dialogflow/cx/v3/experiment_services_pb"

              credentials ||= Google::Cloud::Dialogflow::Cx::V3::Credentials.default

              if credentials.is_a?(String) || credentials.is_a?(Hash)
                updater_proc = Google::Cloud::Dialogflow::Cx::V3::Credentials.new(credentials).updater_proc
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

              package_version = Gem.loaded_specs['google-cloud-dialogflow-cx'].version.version

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
                "experiments_client_config.json"
              )
              defaults = client_config_file.open do |f|
                Google::Gax.construct_settings(
                  "google.cloud.dialogflow.cx.v3.Experiments",
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
              @experiments_stub = Google::Gax::Grpc.create_stub(
                service_path,
                port,
                chan_creds: chan_creds,
                channel: channel,
                updater_proc: updater_proc,
                scopes: scopes,
                interceptors: interceptors,
                &Google::Cloud::Dialogflow::Cx::V3::Experiments::Stub.method(:new)
              )

              @list_experiments = Google::Gax.create_api_call(
                @experiments_stub.method(:list_experiments),
                defaults["list_experiments"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @get_experiment = Google::Gax.create_api_call(
                @experiments_stub.method(:get_experiment),
                defaults["get_experiment"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @create_experiment = Google::Gax.create_api_call(
                @experiments_stub.method(:create_experiment),
                defaults["create_experiment"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @update_experiment = Google::Gax.create_api_call(
                @experiments_stub.method(:update_experiment),
                defaults["update_experiment"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'experiment.name' => request.experiment.name}
                end
              )
              @delete_experiment = Google::Gax.create_api_call(
                @experiments_stub.method(:delete_experiment),
                defaults["delete_experiment"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @start_experiment = Google::Gax.create_api_call(
                @experiments_stub.method(:start_experiment),
                defaults["start_experiment"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @stop_experiment = Google::Gax.create_api_call(
                @experiments_stub.method(:stop_experiment),
                defaults["stop_experiment"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
            end

            # Service calls

            # Returns the list of all experiments in the specified {Google::Cloud::Dialogflow::Cx::V3::Environment Environment}.
            #
            # @param parent [String]
            #   Required. The {Google::Cloud::Dialogflow::Cx::V3::Environment Environment} to list all environments for.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
            #   ID>/environments/<Environment ID>`.
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
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::Cx::V3::Experiment>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::Cx::V3::Experiment>]
            #   An enumerable of Google::Cloud::Dialogflow::Cx::V3::Experiment instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   experiments_client = Google::Cloud::Dialogflow::Cx::Experiments.new(version: :v3)
            #   formatted_parent = Google::Cloud::Dialogflow::Cx::V3::ExperimentsClient.environment_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]")
            #
            #   # Iterate over all results.
            #   experiments_client.list_experiments(formatted_parent).each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   experiments_client.list_experiments(formatted_parent).each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_experiments \
                parent,
                page_size: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                page_size: page_size
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3::ListExperimentsRequest)
              @list_experiments.call(req, options, &block)
            end

            # Retrieves the specified {Google::Cloud::Dialogflow::Cx::V3::Experiment Experiment}.
            #
            # @param name [String]
            #   Required. The name of the {Google::Cloud::Dialogflow::Cx::V3::Environment Environment}.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
            #   ID>/environments/<Environment ID>/experiments/<Experiment ID>`.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Dialogflow::Cx::V3::Experiment]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Dialogflow::Cx::V3::Experiment]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   experiments_client = Google::Cloud::Dialogflow::Cx::Experiments.new(version: :v3)
            #   formatted_name = Google::Cloud::Dialogflow::Cx::V3::ExperimentsClient.experiment_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]")
            #   response = experiments_client.get_experiment(formatted_name)

            def get_experiment \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3::GetExperimentRequest)
              @get_experiment.call(req, options, &block)
            end

            # Creates an {Google::Cloud::Dialogflow::Cx::V3::Experiment Experiment} in the specified {Google::Cloud::Dialogflow::Cx::V3::Environment Environment}.
            #
            # @param parent [String]
            #   Required. The {Google::Cloud::Dialogflow::Cx::V3::Agent Agent} to create an {Google::Cloud::Dialogflow::Cx::V3::Environment Environment} for.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
            #   ID>/environments/<Environment ID>`.
            # @param experiment [Google::Cloud::Dialogflow::Cx::V3::Experiment | Hash]
            #   Required. The experiment to create.
            #   A hash of the same form as `Google::Cloud::Dialogflow::Cx::V3::Experiment`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Dialogflow::Cx::V3::Experiment]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Dialogflow::Cx::V3::Experiment]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   experiments_client = Google::Cloud::Dialogflow::Cx::Experiments.new(version: :v3)
            #   formatted_parent = Google::Cloud::Dialogflow::Cx::V3::ExperimentsClient.environment_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]")
            #
            #   # TODO: Initialize `experiment`:
            #   experiment = {}
            #   response = experiments_client.create_experiment(formatted_parent, experiment)

            def create_experiment \
                parent,
                experiment,
                options: nil,
                &block
              req = {
                parent: parent,
                experiment: experiment
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3::CreateExperimentRequest)
              @create_experiment.call(req, options, &block)
            end

            # Updates the specified {Google::Cloud::Dialogflow::Cx::V3::Experiment Experiment}.
            #
            # @param experiment [Google::Cloud::Dialogflow::Cx::V3::Experiment | Hash]
            #   Required. The experiment to update.
            #   A hash of the same form as `Google::Cloud::Dialogflow::Cx::V3::Experiment`
            #   can also be provided.
            # @param update_mask [Google::Protobuf::FieldMask | Hash]
            #   Required. The mask to control which fields get updated.
            #   A hash of the same form as `Google::Protobuf::FieldMask`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Dialogflow::Cx::V3::Experiment]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Dialogflow::Cx::V3::Experiment]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   experiments_client = Google::Cloud::Dialogflow::Cx::Experiments.new(version: :v3)
            #
            #   # TODO: Initialize `experiment`:
            #   experiment = {}
            #
            #   # TODO: Initialize `update_mask`:
            #   update_mask = {}
            #   response = experiments_client.update_experiment(experiment, update_mask)

            def update_experiment \
                experiment,
                update_mask,
                options: nil,
                &block
              req = {
                experiment: experiment,
                update_mask: update_mask
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3::UpdateExperimentRequest)
              @update_experiment.call(req, options, &block)
            end

            # Deletes the specified {Google::Cloud::Dialogflow::Cx::V3::Experiment Experiment}.
            #
            # @param name [String]
            #   Required. The name of the {Google::Cloud::Dialogflow::Cx::V3::Environment Environment} to delete.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
            #   ID>/environments/<Environment ID>/experiments/<Experiment ID>`.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result []
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   experiments_client = Google::Cloud::Dialogflow::Cx::Experiments.new(version: :v3)
            #   formatted_name = Google::Cloud::Dialogflow::Cx::V3::ExperimentsClient.experiment_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]")
            #   experiments_client.delete_experiment(formatted_name)

            def delete_experiment \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3::DeleteExperimentRequest)
              @delete_experiment.call(req, options, &block)
              nil
            end

            # Starts the specified {Google::Cloud::Dialogflow::Cx::V3::Experiment Experiment}. This rpc only changes the state of
            # experiment from PENDING to RUNNING.
            #
            # @param name [String]
            #   Required. Resource name of the experiment to start.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
            #   ID>/environments/<Environment ID>/experiments/<Experiment ID>`.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Dialogflow::Cx::V3::Experiment]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Dialogflow::Cx::V3::Experiment]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   experiments_client = Google::Cloud::Dialogflow::Cx::Experiments.new(version: :v3)
            #   formatted_name = Google::Cloud::Dialogflow::Cx::V3::ExperimentsClient.experiment_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]")
            #   response = experiments_client.start_experiment(formatted_name)

            def start_experiment \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3::StartExperimentRequest)
              @start_experiment.call(req, options, &block)
            end

            # Stops the specified {Google::Cloud::Dialogflow::Cx::V3::Experiment Experiment}. This rpc only changes the state of
            # experiment from RUNNING to DONE.
            #
            # @param name [String]
            #   Required. Resource name of the experiment to stop.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
            #   ID>/environments/<Environment ID>/experiments/<Experiment ID>`.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Dialogflow::Cx::V3::Experiment]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Dialogflow::Cx::V3::Experiment]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   experiments_client = Google::Cloud::Dialogflow::Cx::Experiments.new(version: :v3)
            #   formatted_name = Google::Cloud::Dialogflow::Cx::V3::ExperimentsClient.experiment_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]")
            #   response = experiments_client.stop_experiment(formatted_name)

            def stop_experiment \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3::StopExperimentRequest)
              @stop_experiment.call(req, options, &block)
            end
          end
        end
      end
    end
  end
end
