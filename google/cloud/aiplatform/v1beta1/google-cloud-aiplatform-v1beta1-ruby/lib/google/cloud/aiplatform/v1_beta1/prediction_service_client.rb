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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/aiplatform/v1beta1/prediction_service.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/aiplatform/v1beta1/prediction_service_pb"
require "google/cloud/aiplatform/v1_beta1/credentials"

module Google
  module Cloud
    module Aiplatform
      module V1Beta1
        # A service for online predictions and explanations.
        #
        # @!attribute [r] prediction_service_stub
        #   @return [Google::Cloud::Aiplatform::V1beta1::PredictionService::Stub]
        class PredictionServiceClient
          attr_reader :prediction_service_stub

          # The default address of the service.
          SERVICE_ADDRESS = "aiplatform.googleapis.com".freeze

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


          ENDPOINT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/endpoints/{endpoint}"
          )

          private_constant :ENDPOINT_PATH_TEMPLATE

          # Returns a fully-qualified endpoint resource name string.
          # @param project [String]
          # @param location [String]
          # @param endpoint [String]
          # @return [String]
          def self.endpoint_path project, location, endpoint
            ENDPOINT_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"endpoint" => endpoint
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
            require "google/cloud/aiplatform/v1beta1/prediction_service_services_pb"

            credentials ||= Google::Cloud::Aiplatform::V1Beta1::Credentials.default

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
              "prediction_service_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.aiplatform.v1beta1.PredictionService",
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
            @prediction_service_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Aiplatform::V1beta1::PredictionService::Stub.method(:new)
            )

            @predict = Google::Gax.create_api_call(
              @prediction_service_stub.method(:predict),
              defaults["predict"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'endpoint' => request.endpoint}
              end
            )
            @explain = Google::Gax.create_api_call(
              @prediction_service_stub.method(:explain),
              defaults["explain"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'endpoint' => request.endpoint}
              end
            )
          end

          # Service calls

          # Perform an online prediction.
          #
          # @param endpoint [String]
          #   Required. The name of the Endpoint requested to serve the prediction.
          #   Format:
          #   `projects/{project}/locations/{location}/endpoints/{endpoint}`
          # @param instances [Array<Google::Protobuf::Value | Hash>]
          #   Required. The instances that are the input to the prediction call.
          #   A DeployedModel may have an upper limit on the number of instances it
          #   supports per request, and when it is exceeded the prediction call errors
          #   in case of AutoML Models, or, in case of customer created Models, the
          #   behaviour is as documented by that Model.
          #   The schema of any single instance may be specified via Endpoint's
          #   DeployedModels' {Google::Cloud::Aiplatform::V1beta1::DeployedModel#model Model's}
          #   {Google::Cloud::Aiplatform::V1beta1::Model#predict_schemata PredictSchemata's}
          #   {Google::Cloud::Aiplatform::V1beta1::PredictSchemata#instance_schema_uri instance_schema_uri}.
          #   A hash of the same form as `Google::Protobuf::Value`
          #   can also be provided.
          # @param parameters [Google::Protobuf::Value | Hash]
          #   The parameters that govern the prediction. The schema of the parameters may
          #   be specified via Endpoint's DeployedModels' {Google::Cloud::Aiplatform::V1beta1::DeployedModel#model Model's }
          #   {Google::Cloud::Aiplatform::V1beta1::Model#predict_schemata PredictSchemata's}
          #   {Google::Cloud::Aiplatform::V1beta1::PredictSchemata#parameters_schema_uri parameters_schema_uri}.
          #   A hash of the same form as `Google::Protobuf::Value`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1beta1::PredictResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1beta1::PredictResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   prediction_client = Google::Cloud::Aiplatform::V1Beta1::Prediction.new(version: :v1beta1)
          #   formatted_endpoint = Google::Cloud::Aiplatform::V1Beta1::PredictionServiceClient.endpoint_path("[PROJECT]", "[LOCATION]", "[ENDPOINT]")
          #
          #   # TODO: Initialize `instances`:
          #   instances = []
          #   response = prediction_client.predict(formatted_endpoint, instances)

          def predict \
              endpoint,
              instances,
              parameters: nil,
              options: nil,
              &block
            req = {
              endpoint: endpoint,
              instances: instances,
              parameters: parameters
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::PredictRequest)
            @predict.call(req, options, &block)
          end

          # Perform an online explanation.
          #
          # If {Google::Cloud::Aiplatform::V1beta1::ExplainRequest#deployed_model_id deployed_model_id} is specified,
          # the corresponding DeployModel must have
          # {Google::Cloud::Aiplatform::V1beta1::DeployedModel#explanation_spec explanation_spec}
          # populated. If {Google::Cloud::Aiplatform::V1beta1::ExplainRequest#deployed_model_id deployed_model_id}
          # is not specified, all DeployedModels must have
          # {Google::Cloud::Aiplatform::V1beta1::DeployedModel#explanation_spec explanation_spec}
          # populated. Only deployed AutoML tabular Models have
          # explanation_spec.
          #
          # @param endpoint [String]
          #   Required. The name of the Endpoint requested to serve the explanation.
          #   Format:
          #   `projects/{project}/locations/{location}/endpoints/{endpoint}`
          # @param instances [Array<Google::Protobuf::Value | Hash>]
          #   Required. The instances that are the input to the explanation call.
          #   A DeployedModel may have an upper limit on the number of instances it
          #   supports per request, and when it is exceeded the explanation call errors
          #   in case of AutoML Models, or, in case of customer created Models, the
          #   behaviour is as documented by that Model.
          #   The schema of any single instance may be specified via Endpoint's
          #   DeployedModels' {Google::Cloud::Aiplatform::V1beta1::DeployedModel#model Model's}
          #   {Google::Cloud::Aiplatform::V1beta1::Model#predict_schemata PredictSchemata's}
          #   {Google::Cloud::Aiplatform::V1beta1::PredictSchemata#instance_schema_uri instance_schema_uri}.
          #   A hash of the same form as `Google::Protobuf::Value`
          #   can also be provided.
          # @param parameters [Google::Protobuf::Value | Hash]
          #   The parameters that govern the prediction. The schema of the parameters may
          #   be specified via Endpoint's DeployedModels' {Google::Cloud::Aiplatform::V1beta1::DeployedModel#model Model's }
          #   {Google::Cloud::Aiplatform::V1beta1::Model#predict_schemata PredictSchemata's}
          #   {Google::Cloud::Aiplatform::V1beta1::PredictSchemata#parameters_schema_uri parameters_schema_uri}.
          #   A hash of the same form as `Google::Protobuf::Value`
          #   can also be provided.
          # @param explanation_spec_override [Google::Cloud::Aiplatform::V1beta1::ExplanationSpecOverride | Hash]
          #   If specified, overrides the
          #   {Google::Cloud::Aiplatform::V1beta1::DeployedModel#explanation_spec explanation_spec} of the DeployedModel.
          #   Can be used for explaining prediction results with different
          #   configurations, such as:
          #   * Explaining top-5 predictions results as opposed to top-1;
          #     * Increasing path count or step count of the attribution methods to reduce
          #       approximate errors;
          #     * Using different baselines for explaining the prediction results.
          #   A hash of the same form as `Google::Cloud::Aiplatform::V1beta1::ExplanationSpecOverride`
          #   can also be provided.
          # @param deployed_model_id [String]
          #   If specified, this ExplainRequest will be served by the chosen
          #   DeployedModel, overriding {Google::Cloud::Aiplatform::V1beta1::Endpoint#traffic_split Endpoint#traffic_split}.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1beta1::ExplainResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1beta1::ExplainResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   prediction_client = Google::Cloud::Aiplatform::V1Beta1::Prediction.new(version: :v1beta1)
          #   formatted_endpoint = Google::Cloud::Aiplatform::V1Beta1::PredictionServiceClient.endpoint_path("[PROJECT]", "[LOCATION]", "[ENDPOINT]")
          #
          #   # TODO: Initialize `instances`:
          #   instances = []
          #   response = prediction_client.explain(formatted_endpoint, instances)

          def explain \
              endpoint,
              instances,
              parameters: nil,
              explanation_spec_override: nil,
              deployed_model_id: nil,
              options: nil,
              &block
            req = {
              endpoint: endpoint,
              instances: instances,
              parameters: parameters,
              explanation_spec_override: explanation_spec_override,
              deployed_model_id: deployed_model_id
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::ExplainRequest)
            @explain.call(req, options, &block)
          end
        end
      end
    end
  end
end
