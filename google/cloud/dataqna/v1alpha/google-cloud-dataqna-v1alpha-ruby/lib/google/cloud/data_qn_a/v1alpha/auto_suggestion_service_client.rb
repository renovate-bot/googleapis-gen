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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/dataqna/v1alpha/auto_suggestion_service.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/dataqna/v1alpha/auto_suggestion_service_pb"
require "google/cloud/data_qn_a/v1alpha/credentials"

module Google
  module Cloud
    module DataQnA
      module V1alpha
        # This stateless API provides automatic suggestions for natural language
        # queries for the data sources in the provided project and location.
        #
        # The service provides a resourceless operation `suggestQueries` that can be
        # called to get a list of suggestions for a given incomplete query and scope
        # (or list of scopes) under which the query is to be interpreted.
        #
        # There are two types of suggestions, ENTITY for single entity suggestions
        # and TEMPLATE for full sentences. By default, both types are returned.
        #
        # Example Request:
        # ```
        # GetSuggestions({
        #   parent: "locations/us/projects/my-project"
        #   scopes:
        #   "//bigquery.googleapis.com/projects/my-project/datasets/my-dataset/tables/my-table"
        #   query: "top it"
        # })
        # ```
        #
        # The service will retrieve information based on the given scope(s) and give
        # suggestions based on that (e.g. "top item" for "top it" if "item" is a known
        # dimension for the provided scope).
        # ```
        # suggestions {
        #   suggestion_info {
        #     annotated_suggestion {
        #       text_formatted: "top item by sum of usd_revenue_net"
        #       markups {
        #         type: DIMENSION
        #         start_char_index: 4
        #         length: 4
        #       }
        #       markups {
        #         type: METRIC
        #         start_char_index: 19
        #         length: 15
        #       }
        #     }
        #     query_matches {
        #       start_char_index: 0
        #       length: 6
        #     }
        #   }
        #   suggestion_type: TEMPLATE
        #   ranking_score: 0.9
        # }
        # suggestions {
        #   suggestion_info {
        #     annotated_suggestion {
        #       text_formatted: "item"
        #       markups {
        #         type: DIMENSION
        #         start_char_index: 4
        #         length: 2
        #       }
        #     }
        #     query_matches {
        #       start_char_index: 0
        #       length: 6
        #     }
        #   }
        #   suggestion_type: ENTITY
        #   ranking_score: 0.8
        # }
        # ```
        #
        # @!attribute [r] auto_suggestion_service_stub
        #   @return [Google::Cloud::Dataqna::V1alpha::AutoSuggestionService::Stub]
        class AutoSuggestionServiceClient
          attr_reader :auto_suggestion_service_stub

          # The default address of the service.
          SERVICE_ADDRESS = "dataqna.googleapis.com".freeze

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


          LOCATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}"
          )

          private_constant :LOCATION_PATH_TEMPLATE

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
            require "google/cloud/dataqna/v1alpha/auto_suggestion_service_services_pb"

            credentials ||= Google::Cloud::DataQnA::V1alpha::Credentials.default

            if credentials.is_a?(String) || credentials.is_a?(Hash)
              updater_proc = Google::Cloud::DataQnA::V1alpha::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-cloud-data_qn_a'].version.version

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
              "auto_suggestion_service_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.dataqna.v1alpha.AutoSuggestionService",
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
            @auto_suggestion_service_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Dataqna::V1alpha::AutoSuggestionService::Stub.method(:new)
            )

            @suggest_queries = Google::Gax.create_api_call(
              @auto_suggestion_service_stub.method(:suggest_queries),
              defaults["suggest_queries"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
          end

          # Service calls

          # Gets a list of suggestions based on a prefix string.
          # AutoSuggestion tolerance should be less than 1 second.
          #
          # @param parent [String]
          #   Required. The parent of the suggestion query is the resource denoting the project and
          #   location.
          # @param scopes [Array<String>]
          #   The scopes to which this search is restricted. The only supported scope
          #   pattern is
          #   `//bigquery.googleapis.com/projects/{GCP-PROJECT-ID}/datasets/{DATASET-ID}/tables/{TABLE-ID}`.
          # @param query [String]
          #   User query for which to generate suggestions. If the query is empty, zero
          #   state suggestions are returned. This allows UIs to display suggestions
          #   right away, helping the user to get a sense of what a query might look
          #   like.
          # @param suggestion_types [Array<Google::Cloud::Dataqna::V1alpha::SuggestionType>]
          #   The requested suggestion type. Multiple suggestion types can be
          #   requested, but there is no guarantee that the service will return
          #   suggestions for each type. Suggestions for a requested type might rank
          #   lower than suggestions for other types and the service may decide to cut
          #   these suggestions off.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Dataqna::V1alpha::SuggestQueriesResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Dataqna::V1alpha::SuggestQueriesResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/data_qn_a"
          #
          #   auto_suggestion_client = Google::Cloud::DataQnA::V1alpha::AutoSuggestion.new(version: :v1alpha)
          #   formatted_parent = Google::Cloud::DataQnA::V1alpha::AutoSuggestionServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #   response = auto_suggestion_client.suggest_queries(formatted_parent)

          def suggest_queries \
              parent,
              scopes: nil,
              query: nil,
              suggestion_types: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              scopes: scopes,
              query: query,
              suggestion_types: suggestion_types
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dataqna::V1alpha::SuggestQueriesRequest)
            @suggest_queries.call(req, options, &block)
          end
        end
      end
    end
  end
end
