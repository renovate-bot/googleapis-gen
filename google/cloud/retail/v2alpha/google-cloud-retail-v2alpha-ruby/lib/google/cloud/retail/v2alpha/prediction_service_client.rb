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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/retail/v2alpha/prediction_service.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/retail/v2alpha/prediction_service_pb"
require "google/cloud/retail/v2alpha/credentials"

module Google
  module Cloud
    module Retail
      module V2alpha
        # Service for making recommendation prediction.
        #
        # @!attribute [r] prediction_service_stub
        #   @return [Google::Cloud::Retail::V2alpha::PredictionService::Stub]
        class PredictionServiceClient
          attr_reader :prediction_service_stub

          # The default address of the service.
          SERVICE_ADDRESS = "retail.googleapis.com".freeze

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
            require "google/cloud/retail/v2alpha/prediction_service_services_pb"

            credentials ||= Google::Cloud::Retail::V2alpha::Credentials.default

            if credentials.is_a?(String) || credentials.is_a?(Hash)
              updater_proc = Google::Cloud::Retail::V2alpha::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-cloud-retail'].version.version

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
                "google.cloud.retail.v2alpha.PredictionService",
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
              &Google::Cloud::Retail::V2alpha::PredictionService::Stub.method(:new)
            )

            @predict = Google::Gax.create_api_call(
              @prediction_service_stub.method(:predict),
              defaults["predict"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'placement' => request.placement}
              end
            )
          end

          # Service calls

          # Makes a recommendation prediction.
          #
          # @param placement [String]
          #   Required. Full resource name of the format:
          #   {name=projects/*/locations/global/catalogs/default_catalog/placements/*}
          #   The id of the recommendation engine placement. This id is used to identify
          #   the set of models that will be used to make the prediction.
          #
          #   We currently support three placements with the following IDs by default:
          #
          #   * `shopping_cart`: Predicts products frequently bought together with one or
          #     more  products in the same shopping session. Commonly displayed after
          #     `add-to-cart` events, on product detail pages, or on the shopping cart
          #     page.
          #
          #   * `home_page`: Predicts the next product that a user will most likely
          #     engage with or purchase based on the shopping or viewing history of the
          #     specified `userId` or `visitorId`. For example - Recommendations for you.
          #
          #   * `product_detail`: Predicts the next product that a user will most likely
          #     engage with or purchase. The prediction is based on the shopping or
          #     viewing history of the specified `userId` or `visitorId` and its
          #     relevance to a specified `CatalogItem`. Typically used on product detail
          #     pages. For example - More products like this.
          #
          #   * `recently_viewed_default`: Returns up to 75 products recently viewed by
          #     the specified `userId` or `visitorId`, most recent ones first. Returns
          #     nothing if neither of them has viewed any products yet. For example -
          #     Recently viewed.
          #
          #   The full list of available placements can be seen at
          #   https://console.cloud.google.com/recommendation/catalogs/default_catalog/placements
          # @param user_event [Google::Cloud::Retail::V2alpha::UserEvent | Hash]
          #   Required. Context about the user, what they are looking at and what action
          #   they took to trigger the predict request. Note that this user event detail
          #   won't be ingested to userEvent logs. Thus, a separate userEvent write
          #   request is required for event logging.
          #   A hash of the same form as `Google::Cloud::Retail::V2alpha::UserEvent`
          #   can also be provided.
          # @param page_size [Integer]
          #   Maximum number of results to return per page. Set this property
          #   to the number of prediction results needed. If zero, the service will
          #   choose a reasonable default. The maximum allowed value is 100. Values
          #   above 100 will be coerced to 100.
          # @param page_token [String]
          #   The previous PredictResponse.next_page_token.
          # @param filter [String]
          #   Filter for restricting prediction results with a length limit of 5,000
          #   characters. Accepts values for tags and the `filterOutOfStockItems` flag.
          #
          #   * Tag expressions. Restricts predictions to products that match all of the
          #     specified tags. Boolean operators `OR` and `NOT` are supported if the
          #     expression is enclosed in parentheses, and must be separated from the
          #     tag values by a space. `-"tagA"` is also supported and is equivalent to
          #     `NOT "tagA"`. Tag values must be double quoted UTF-8 encoded strings
          #     with a size limit of 1,000 characters.
          #
          #   * filterOutOfStockItems. Restricts predictions to products that do not
          #     have a
          #     stockState value of OUT_OF_STOCK.
          #
          #   Examples:
          #
          #   * tag=("Red" OR "Blue") tag="New-Arrival" tag=(NOT "promotional")
          #     * filterOutOfStockItems  tag=(-"promotional")
          #   * filterOutOfStockItems
          #
          #   If your filter blocks all prediction results, nothing will be returned. If
          #   you want generic (unfiltered) popular products to be returned instead, set
          #   `strictFiltering` to false in `PredictRequest.params`.
          # @param validate_only [true, false]
          #   Use validate only mode for this prediction query. If set to true, a
          #   dummy model will be used that returns arbitrary products.
          #   Note that the validate only mode should only be used for testing the API,
          #   or if the model is not ready.
          # @param params [Hash{String => Google::Protobuf::Value | Hash}]
          #   Additional domain specific parameters for the predictions.
          #
          #   Allowed values:
          #
          #   * `returnProduct`: Boolean. If set to true, the associated product
          #     object will be returned in the `results.metadata` field in the
          #     prediction response.
          #   * `returnScore`: Boolean. If set to true, the prediction 'score'
          #     corresponding to each returned product will be set in the
          #     `results.metadata` field in the prediction response. The given
          #     'score' indicates the probability of an product being clicked/purchased
          #     given the user's context and history.
          #   * `strictFiltering`: Boolean. True by default. If set to false, the service
          #     will return generic (unfiltered) popular products instead of empty if
          #     your filter blocks all prediction results.
          #   A hash of the same form as `Google::Protobuf::Value`
          #   can also be provided.
          # @param labels [Hash{String => String}]
          #   The labels for the predict request.
          #
          #   * Label keys can contain lowercase letters, digits and hyphens, must start
          #     with a letter, and must end with a letter or digit.
          #   * Non-zero label values can contain lowercase letters, digits and hyphens,
          #     must start with a letter, and must end with a letter or digit.
          #   * No more than 64 labels can be associated with a given request.
          #
          #   See https://goo.gl/xmQnxf for more information on and examples of labels.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Retail::V2alpha::PredictResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Retail::V2alpha::PredictResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/retail"
          #
          #   prediction_client = Google::Cloud::Retail::V2alpha::Prediction.new(version: :v2alpha)
          #
          #   # TODO: Initialize `placement`:
          #   placement = ''
          #
          #   # TODO: Initialize `user_event`:
          #   user_event = {}
          #   response = prediction_client.predict(placement, user_event)

          def predict \
              placement,
              user_event,
              page_size: nil,
              page_token: nil,
              filter: nil,
              validate_only: nil,
              params: nil,
              labels: nil,
              options: nil,
              &block
            req = {
              placement: placement,
              user_event: user_event,
              page_size: page_size,
              page_token: page_token,
              filter: filter,
              validate_only: validate_only,
              params: params,
              labels: labels
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Retail::V2alpha::PredictRequest)
            @predict.call(req, options, &block)
          end
        end
      end
    end
  end
end
