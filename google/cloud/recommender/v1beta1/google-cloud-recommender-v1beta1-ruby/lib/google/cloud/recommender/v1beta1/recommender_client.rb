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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/recommender/v1beta1/recommender_service.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/recommender/v1beta1/recommender_service_pb"
require "google/cloud/recommender/v1beta1/credentials"

module Google
  module Cloud
    module Recommender
      module V1beta1
        # Provides insights and recommendations for cloud customers for various
        # categories like performance optimization, cost savings, reliability, feature
        # discovery, etc. Insights and recommendations are generated automatically
        # based on analysis of user resources, configuration and monitoring metrics.
        #
        # @!attribute [r] recommender_stub
        #   @return [Google::Cloud::Recommender::V1beta1::Recommender::Stub]
        class RecommenderClient
          attr_reader :recommender_stub

          # The default address of the service.
          SERVICE_ADDRESS = "recommender.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_insights" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "insights"),
            "list_recommendations" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "recommendations")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform"
          ].freeze


          INSIGHT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/insightTypes/{insight_type}/insights/{insight}"
          )

          private_constant :INSIGHT_PATH_TEMPLATE

          INSIGHT_TYPE_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/insightTypes/{insight_type}"
          )

          private_constant :INSIGHT_TYPE_PATH_TEMPLATE

          RECOMMENDATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}"
          )

          private_constant :RECOMMENDATION_PATH_TEMPLATE

          RECOMMENDER_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/recommenders/{recommender}"
          )

          private_constant :RECOMMENDER_PATH_TEMPLATE

          # Returns a fully-qualified insight resource name string.
          # @param project [String]
          # @param location [String]
          # @param insight_type [String]
          # @param insight [String]
          # @return [String]
          def self.insight_path project, location, insight_type, insight
            INSIGHT_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"insight_type" => insight_type,
              :"insight" => insight
            )
          end

          # Returns a fully-qualified insight_type resource name string.
          # @param project [String]
          # @param location [String]
          # @param insight_type [String]
          # @return [String]
          def self.insight_type_path project, location, insight_type
            INSIGHT_TYPE_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"insight_type" => insight_type
            )
          end

          # Returns a fully-qualified recommendation resource name string.
          # @param project [String]
          # @param location [String]
          # @param recommender [String]
          # @param recommendation [String]
          # @return [String]
          def self.recommendation_path project, location, recommender, recommendation
            RECOMMENDATION_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"recommender" => recommender,
              :"recommendation" => recommendation
            )
          end

          # Returns a fully-qualified recommender resource name string.
          # @param project [String]
          # @param location [String]
          # @param recommender [String]
          # @return [String]
          def self.recommender_path project, location, recommender
            RECOMMENDER_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"recommender" => recommender
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
            require "google/cloud/recommender/v1beta1/recommender_service_services_pb"

            credentials ||= Google::Cloud::Recommender::V1beta1::Credentials.default

            if credentials.is_a?(String) || credentials.is_a?(Hash)
              updater_proc = Google::Cloud::Recommender::V1beta1::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-cloud-recommender'].version.version

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
              "recommender_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.recommender.v1beta1.Recommender",
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
            @recommender_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Recommender::V1beta1::Recommender::Stub.method(:new)
            )

            @list_insights = Google::Gax.create_api_call(
              @recommender_stub.method(:list_insights),
              defaults["list_insights"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_insight = Google::Gax.create_api_call(
              @recommender_stub.method(:get_insight),
              defaults["get_insight"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @mark_insight_accepted = Google::Gax.create_api_call(
              @recommender_stub.method(:mark_insight_accepted),
              defaults["mark_insight_accepted"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_recommendations = Google::Gax.create_api_call(
              @recommender_stub.method(:list_recommendations),
              defaults["list_recommendations"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_recommendation = Google::Gax.create_api_call(
              @recommender_stub.method(:get_recommendation),
              defaults["get_recommendation"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @mark_recommendation_claimed = Google::Gax.create_api_call(
              @recommender_stub.method(:mark_recommendation_claimed),
              defaults["mark_recommendation_claimed"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @mark_recommendation_succeeded = Google::Gax.create_api_call(
              @recommender_stub.method(:mark_recommendation_succeeded),
              defaults["mark_recommendation_succeeded"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @mark_recommendation_failed = Google::Gax.create_api_call(
              @recommender_stub.method(:mark_recommendation_failed),
              defaults["mark_recommendation_failed"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
          end

          # Service calls

          # Lists insights for a Cloud project. Requires the recommender.*.list IAM
          # permission for the specified insight type.
          #
          # @param parent [String]
          #   Required. The container resource on which to execute the request.
          #   Acceptable formats:
          #
          #   1.
          #   "projects/[PROJECT_NUMBER]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]",
          #
          #   LOCATION here refers to GCP Locations:
          #   https://cloud.google.com/about/locations/
          #   INSIGHT_TYPE_ID refers to supported insight types:
          #   https://cloud.google.com/recommender/docs/insights/insight-types.
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param filter [String]
          #   Optional. Filter expression to restrict the insights returned. Supported
          #   filter fields: state
          #   Eg: `state:"DISMISSED" or state:"ACTIVE"
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Recommender::V1beta1::Insight>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Recommender::V1beta1::Insight>]
          #   An enumerable of Google::Cloud::Recommender::V1beta1::Insight instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/recommender"
          #
          #   recommender_client = Google::Cloud::Recommender.new(version: :v1beta1)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #
          #   # Iterate over all results.
          #   recommender_client.list_insights(parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   recommender_client.list_insights(parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_insights \
              parent,
              page_size: nil,
              filter: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size,
              filter: filter
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Recommender::V1beta1::ListInsightsRequest)
            @list_insights.call(req, options, &block)
          end

          # Gets the requested insight. Requires the recommender.*.get IAM permission
          # for the specified insight type.
          #
          # @param name [String]
          #   Required. Name of the insight.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Recommender::V1beta1::Insight]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Recommender::V1beta1::Insight]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/recommender"
          #
          #   recommender_client = Google::Cloud::Recommender.new(version: :v1beta1)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #   response = recommender_client.get_insight(name)

          def get_insight \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Recommender::V1beta1::GetInsightRequest)
            @get_insight.call(req, options, &block)
          end

          # Marks the Insight State as Accepted. Users can use this method to
          # indicate to the Recommender API that they have applied some action based
          # on the insight. This stops the insight content from being updated.
          #
          # MarkInsightAccepted can be applied to insights in ACTIVE state. Requires
          # the recommender.*.update IAM permission for the specified insight.
          #
          # @param name [String]
          #   Required. Name of the insight.
          # @param etag [String]
          #   Required. Fingerprint of the Insight. Provides optimistic locking.
          # @param state_metadata [Hash{String => String}]
          #   Optional. State properties user wish to include with this state.  Full replace of the
          #   current state_metadata.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Recommender::V1beta1::Insight]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Recommender::V1beta1::Insight]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/recommender"
          #
          #   recommender_client = Google::Cloud::Recommender.new(version: :v1beta1)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #
          #   # TODO: Initialize `etag`:
          #   etag = ''
          #   response = recommender_client.mark_insight_accepted(name, etag)

          def mark_insight_accepted \
              name,
              etag,
              state_metadata: nil,
              options: nil,
              &block
            req = {
              name: name,
              etag: etag,
              state_metadata: state_metadata
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Recommender::V1beta1::MarkInsightAcceptedRequest)
            @mark_insight_accepted.call(req, options, &block)
          end

          # Lists recommendations for a Cloud project. Requires the recommender.*.list
          # IAM permission for the specified recommender.
          #
          # @param parent [String]
          #   Required. The container resource on which to execute the request.
          #   Acceptable formats:
          #
          #   1.
          #   "projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]",
          #
          #   LOCATION here refers to GCP Locations:
          #   https://cloud.google.com/about/locations/
          #   RECOMMENDER_ID refers to supported recommenders:
          #   https://cloud.google.com/recommender/docs/recommenders.
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param filter [String]
          #   Filter expression to restrict the recommendations returned. Supported
          #   filter fields: state_info.state
          #   Eg: `state_info.state:"DISMISSED" or state_info.state:"FAILED"
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Recommender::V1beta1::Recommendation>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Recommender::V1beta1::Recommendation>]
          #   An enumerable of Google::Cloud::Recommender::V1beta1::Recommendation instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/recommender"
          #
          #   recommender_client = Google::Cloud::Recommender.new(version: :v1beta1)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #
          #   # Iterate over all results.
          #   recommender_client.list_recommendations(parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   recommender_client.list_recommendations(parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_recommendations \
              parent,
              page_size: nil,
              filter: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size,
              filter: filter
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Recommender::V1beta1::ListRecommendationsRequest)
            @list_recommendations.call(req, options, &block)
          end

          # Gets the requested recommendation. Requires the recommender.*.get
          # IAM permission for the specified recommender.
          #
          # @param name [String]
          #   Required. Name of the recommendation.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Recommender::V1beta1::Recommendation]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Recommender::V1beta1::Recommendation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/recommender"
          #
          #   recommender_client = Google::Cloud::Recommender.new(version: :v1beta1)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #   response = recommender_client.get_recommendation(name)

          def get_recommendation \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Recommender::V1beta1::GetRecommendationRequest)
            @get_recommendation.call(req, options, &block)
          end

          # Marks the Recommendation State as Claimed. Users can use this method to
          # indicate to the Recommender API that they are starting to apply the
          # recommendation themselves. This stops the recommendation content from being
          # updated. Associated insights are frozen and placed in the ACCEPTED state.
          #
          # MarkRecommendationClaimed can be applied to recommendations in CLAIMED or
          # ACTIVE state.
          #
          # Requires the recommender.*.update IAM permission for the specified
          # recommender.
          #
          # @param name [String]
          #   Required. Name of the recommendation.
          # @param etag [String]
          #   Required. Fingerprint of the Recommendation. Provides optimistic locking.
          # @param state_metadata [Hash{String => String}]
          #   State properties to include with this state. Overwrites any existing
          #   `state_metadata`.
          #   Keys must match the regex /^[a-z0-9][a-z0-9_.-]{0,62}$/.
          #   Values must match the regex /^[a-zA-Z0-9_./-]{0,255}$/.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Recommender::V1beta1::Recommendation]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Recommender::V1beta1::Recommendation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/recommender"
          #
          #   recommender_client = Google::Cloud::Recommender.new(version: :v1beta1)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #
          #   # TODO: Initialize `etag`:
          #   etag = ''
          #   response = recommender_client.mark_recommendation_claimed(name, etag)

          def mark_recommendation_claimed \
              name,
              etag,
              state_metadata: nil,
              options: nil,
              &block
            req = {
              name: name,
              etag: etag,
              state_metadata: state_metadata
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Recommender::V1beta1::MarkRecommendationClaimedRequest)
            @mark_recommendation_claimed.call(req, options, &block)
          end

          # Marks the Recommendation State as Succeeded. Users can use this method to
          # indicate to the Recommender API that they have applied the recommendation
          # themselves, and the operation was successful. This stops the recommendation
          # content from being updated. Associated insights are frozen and placed in
          # the ACCEPTED state.
          #
          # MarkRecommendationSucceeded can be applied to recommendations in ACTIVE,
          # CLAIMED, SUCCEEDED, or FAILED state.
          #
          # Requires the recommender.*.update IAM permission for the specified
          # recommender.
          #
          # @param name [String]
          #   Required. Name of the recommendation.
          # @param etag [String]
          #   Required. Fingerprint of the Recommendation. Provides optimistic locking.
          # @param state_metadata [Hash{String => String}]
          #   State properties to include with this state. Overwrites any existing
          #   `state_metadata`.
          #   Keys must match the regex /^[a-z0-9][a-z0-9_.-]{0,62}$/.
          #   Values must match the regex /^[a-zA-Z0-9_./-]{0,255}$/.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Recommender::V1beta1::Recommendation]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Recommender::V1beta1::Recommendation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/recommender"
          #
          #   recommender_client = Google::Cloud::Recommender.new(version: :v1beta1)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #
          #   # TODO: Initialize `etag`:
          #   etag = ''
          #   response = recommender_client.mark_recommendation_succeeded(name, etag)

          def mark_recommendation_succeeded \
              name,
              etag,
              state_metadata: nil,
              options: nil,
              &block
            req = {
              name: name,
              etag: etag,
              state_metadata: state_metadata
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Recommender::V1beta1::MarkRecommendationSucceededRequest)
            @mark_recommendation_succeeded.call(req, options, &block)
          end

          # Marks the Recommendation State as Failed. Users can use this method to
          # indicate to the Recommender API that they have applied the recommendation
          # themselves, and the operation failed. This stops the recommendation content
          # from being updated. Associated insights are frozen and placed in the
          # ACCEPTED state.
          #
          # MarkRecommendationFailed can be applied to recommendations in ACTIVE,
          # CLAIMED, SUCCEEDED, or FAILED state.
          #
          # Requires the recommender.*.update IAM permission for the specified
          # recommender.
          #
          # @param name [String]
          #   Required. Name of the recommendation.
          # @param etag [String]
          #   Required. Fingerprint of the Recommendation. Provides optimistic locking.
          # @param state_metadata [Hash{String => String}]
          #   State properties to include with this state. Overwrites any existing
          #   `state_metadata`.
          #   Keys must match the regex /^[a-z0-9][a-z0-9_.-]{0,62}$/.
          #   Values must match the regex /^[a-zA-Z0-9_./-]{0,255}$/.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Recommender::V1beta1::Recommendation]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Recommender::V1beta1::Recommendation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/recommender"
          #
          #   recommender_client = Google::Cloud::Recommender.new(version: :v1beta1)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #
          #   # TODO: Initialize `etag`:
          #   etag = ''
          #   response = recommender_client.mark_recommendation_failed(name, etag)

          def mark_recommendation_failed \
              name,
              etag,
              state_metadata: nil,
              options: nil,
              &block
            req = {
              name: name,
              etag: etag,
              state_metadata: state_metadata
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Recommender::V1beta1::MarkRecommendationFailedRequest)
            @mark_recommendation_failed.call(req, options, &block)
          end
        end
      end
    end
  end
end
