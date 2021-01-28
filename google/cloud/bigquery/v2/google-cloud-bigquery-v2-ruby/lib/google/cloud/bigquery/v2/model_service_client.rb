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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/bigquery/v2/model.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/bigquery/v2/model_pb"
require "google/cloud/bigquery/v2/credentials"

module Google
  module Cloud
    module Bigquery
      module V2
        # @!attribute [r] model_service_stub
        #   @return [Google::Cloud::Bigquery::V2::ModelService::Stub]
        class ModelServiceClient
          attr_reader :model_service_stub

          # The default address of the service.
          SERVICE_ADDRESS = "bigquery.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/bigquery",
            "https://www.googleapis.com/auth/bigquery.readonly",
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only"
          ].freeze


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
            require "google/cloud/bigquery/v2/model_services_pb"

            credentials ||= Google::Cloud::Bigquery::V2::Credentials.default

            if credentials.is_a?(String) || credentials.is_a?(Hash)
              updater_proc = Google::Cloud::Bigquery::V2::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-cloud-bigquery'].version.version

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
                "google.cloud.bigquery.v2.ModelService",
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
            @model_service_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Bigquery::V2::ModelService::Stub.method(:new)
            )

            @get_model = Google::Gax.create_api_call(
              @model_service_stub.method(:get_model),
              defaults["get_model"],
              exception_transformer: exception_transformer
            )
            @list_models = Google::Gax.create_api_call(
              @model_service_stub.method(:list_models),
              defaults["list_models"],
              exception_transformer: exception_transformer
            )
            @patch_model = Google::Gax.create_api_call(
              @model_service_stub.method(:patch_model),
              defaults["patch_model"],
              exception_transformer: exception_transformer
            )
            @delete_model = Google::Gax.create_api_call(
              @model_service_stub.method(:delete_model),
              defaults["delete_model"],
              exception_transformer: exception_transformer
            )
          end

          # Service calls

          # Gets the specified model resource by model ID.
          #
          # @param project_id [String]
          #   Required. Project ID of the requested model.
          # @param dataset_id [String]
          #   Required. Dataset ID of the requested model.
          # @param model_id [String]
          #   Required. Model ID of the requested model.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Bigquery::V2::Model]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Bigquery::V2::Model]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/bigquery"
          #
          #   model_client = Google::Cloud::Bigquery.new(version: :v2)
          #
          #   # TODO: Initialize `project_id`:
          #   project_id = ''
          #
          #   # TODO: Initialize `dataset_id`:
          #   dataset_id = ''
          #
          #   # TODO: Initialize `model_id`:
          #   model_id = ''
          #   response = model_client.get_model(project_id, dataset_id, model_id)

          def get_model \
              project_id,
              dataset_id,
              model_id,
              options: nil,
              &block
            req = {
              project_id: project_id,
              dataset_id: dataset_id,
              model_id: model_id
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::V2::GetModelRequest)
            @get_model.call(req, options, &block)
          end

          # Lists all models in the specified dataset. Requires the READER dataset
          # role.
          #
          # @param project_id [String]
          #   Required. Project ID of the models to list.
          # @param dataset_id [String]
          #   Required. Dataset ID of the models to list.
          # @param max_results [Google::Protobuf::UInt32Value | Hash]
          #   The maximum number of results to return in a single response page.
          #   Leverage the page tokens to iterate through the entire collection.
          #   A hash of the same form as `Google::Protobuf::UInt32Value`
          #   can also be provided.
          # @param page_token [String]
          #   Page token, returned by a previous call to request the next page of
          #   results
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Bigquery::V2::ListModelsResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Bigquery::V2::ListModelsResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/bigquery"
          #
          #   model_client = Google::Cloud::Bigquery.new(version: :v2)
          #
          #   # TODO: Initialize `project_id`:
          #   project_id = ''
          #
          #   # TODO: Initialize `dataset_id`:
          #   dataset_id = ''
          #   response = model_client.list_models(project_id, dataset_id)

          def list_models \
              project_id,
              dataset_id,
              max_results: nil,
              page_token: nil,
              options: nil,
              &block
            req = {
              project_id: project_id,
              dataset_id: dataset_id,
              max_results: max_results,
              page_token: page_token
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::V2::ListModelsRequest)
            @list_models.call(req, options, &block)
          end

          # Patch specific fields in the specified model.
          #
          # @param project_id [String]
          #   Required. Project ID of the model to patch.
          # @param dataset_id [String]
          #   Required. Dataset ID of the model to patch.
          # @param model_id [String]
          #   Required. Model ID of the model to patch.
          # @param model [Google::Cloud::Bigquery::V2::Model | Hash]
          #   Required. Patched model.
          #   Follows RFC5789 patch semantics. Missing fields are not updated.
          #   To clear a field, explicitly set to default value.
          #   A hash of the same form as `Google::Cloud::Bigquery::V2::Model`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Bigquery::V2::Model]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Bigquery::V2::Model]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/bigquery"
          #
          #   model_client = Google::Cloud::Bigquery.new(version: :v2)
          #
          #   # TODO: Initialize `project_id`:
          #   project_id = ''
          #
          #   # TODO: Initialize `dataset_id`:
          #   dataset_id = ''
          #
          #   # TODO: Initialize `model_id`:
          #   model_id = ''
          #
          #   # TODO: Initialize `model`:
          #   model = {}
          #   response = model_client.patch_model(project_id, dataset_id, model_id, model)

          def patch_model \
              project_id,
              dataset_id,
              model_id,
              model,
              options: nil,
              &block
            req = {
              project_id: project_id,
              dataset_id: dataset_id,
              model_id: model_id,
              model: model
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::V2::PatchModelRequest)
            @patch_model.call(req, options, &block)
          end

          # Deletes the model specified by modelId from the dataset.
          #
          # @param project_id [String]
          #   Required. Project ID of the model to delete.
          # @param dataset_id [String]
          #   Required. Dataset ID of the model to delete.
          # @param model_id [String]
          #   Required. Model ID of the model to delete.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/bigquery"
          #
          #   model_client = Google::Cloud::Bigquery.new(version: :v2)
          #
          #   # TODO: Initialize `project_id`:
          #   project_id = ''
          #
          #   # TODO: Initialize `dataset_id`:
          #   dataset_id = ''
          #
          #   # TODO: Initialize `model_id`:
          #   model_id = ''
          #   model_client.delete_model(project_id, dataset_id, model_id)

          def delete_model \
              project_id,
              dataset_id,
              model_id,
              options: nil,
              &block
            req = {
              project_id: project_id,
              dataset_id: dataset_id,
              model_id: model_id
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::V2::DeleteModelRequest)
            @delete_model.call(req, options, &block)
            nil
          end
        end
      end
    end
  end
end
