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

require "google/cloud/data_qn_a/v1alpha/auto_suggestion_service_client"
require "google/cloud/data_qn_a/v1alpha/question_service_client"

module Google
  module Cloud
    module DataQnA
      # rubocop:disable LineLength

      ##
      # # Ruby Client for Data QnA API ([Alpha](https://github.com/GoogleCloudPlatform/google-cloud-ruby#versioning))
      #
      # [Data QnA API][Product Documentation]:
      # Data QnA is a natural language question and answer service for BigQuery
      # data.
      # - [Product Documentation][]
      #
      # ## Quick Start
      # In order to use this library, you first need to go through the following
      # steps:
      #
      # 1. [Select or create a Cloud Platform project.](https://console.cloud.google.com/project)
      # 2. [Enable billing for your project.](https://cloud.google.com/billing/docs/how-to/modify-project#enable_billing_for_a_project)
      # 3. [Enable the Data QnA API.](https://console.cloud.google.com/apis/library/dataqna.googleapis.com)
      # 4. [Setup Authentication.](https://googlecloudplatform.github.io/google-cloud-ruby/#/docs/google-cloud/master/guides/authentication)
      #
      # ### Installation
      # ```
      # $ gem install google-cloud-data_qn_a
      # ```
      #
      # ### Next Steps
      # - Read the [Data QnA API Product documentation][Product Documentation]
      #   to learn more about the product and see How-to Guides.
      # - View this [repository's main README](https://github.com/GoogleCloudPlatform/google-cloud-ruby/blob/master/README.md)
      #   to see the full list of Cloud APIs that we cover.
      #
      # [Product Documentation]: https://cloud.google.com/dataqna
      #
      # ## Enabling Logging
      #
      # To enable logging for this library, set the logger for the underlying [gRPC](https://github.com/grpc/grpc/tree/master/src/ruby) library.
      # The logger that you set may be a Ruby stdlib [`Logger`](https://ruby-doc.org/stdlib-2.5.0/libdoc/logger/rdoc/Logger.html) as shown below,
      # or a [`Google::Cloud::Logging::Logger`](https://googlecloudplatform.github.io/google-cloud-ruby/#/docs/google-cloud-logging/latest/google/cloud/logging/logger)
      # that will write logs to [Stackdriver Logging](https://cloud.google.com/logging/). See [grpc/logconfig.rb](https://github.com/grpc/grpc/blob/master/src/ruby/lib/grpc/logconfig.rb)
      # and the gRPC [spec_helper.rb](https://github.com/grpc/grpc/blob/master/src/ruby/spec/spec_helper.rb) for additional information.
      #
      # Configuring a Ruby stdlib logger:
      #
      # ```ruby
      # require "logger"
      #
      # module MyLogger
      #   LOGGER = Logger.new $stderr, level: Logger::WARN
      #   def logger
      #     LOGGER
      #   end
      # end
      #
      # # Define a gRPC module-level logger method before grpc/logconfig.rb loads.
      # module GRPC
      #   extend MyLogger
      # end
      # ```
      #
      module V1alpha
        # rubocop:enable LineLength

        module AutoSuggestion
          ##
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
          def self.new \
              credentials: nil,
              scopes: nil,
              client_config: nil,
              timeout: nil,
              metadata: nil,
              exception_transformer: nil,
              lib_name: nil,
              lib_version: nil
            kwargs = {
              credentials: credentials,
              scopes: scopes,
              client_config: client_config,
              timeout: timeout,
              metadata: metadata,
              exception_transformer: exception_transformer,
              lib_name: lib_name,
              lib_version: lib_version
            }.select { |_, v| v != nil }
            Google::Cloud::DataQnA::V1alpha::AutoSuggestionServiceClient.new(**kwargs)
          end
        end

        module Question
          ##
          # Service to interpret natural language queries.
          # The service allows to create `Question` resources that are interpreted and
          # are filled with one or more interpretations if the question could be
          # interpreted. Once a `Question` resource is created and has at least one
          # interpretation, an interpretation can be chosen for execution, which
          # triggers a query to the backend (for BigQuery, it will create a job).
          # Upon successful execution of that interpretation, backend specific
          # information will be returned so that the client can retrieve the results
          # from the backend.
          #
          # The `Question` resources are named `projects/*/locations/*/questions/*`.
          #
          # The `Question` resource has a singletion sub-resource `UserFeedback` named
          # `projects/*/locations/*/questions/*/userFeedback`, which allows access to
          # user feedback.
          #
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
          def self.new \
              credentials: nil,
              scopes: nil,
              client_config: nil,
              timeout: nil,
              metadata: nil,
              exception_transformer: nil,
              lib_name: nil,
              lib_version: nil
            kwargs = {
              credentials: credentials,
              scopes: scopes,
              client_config: client_config,
              timeout: timeout,
              metadata: metadata,
              exception_transformer: exception_transformer,
              lib_name: lib_name,
              lib_version: lib_version
            }.select { |_, v| v != nil }
            Google::Cloud::DataQnA::V1alpha::QuestionServiceClient.new(**kwargs)
          end
        end
      end
    end
  end
end
