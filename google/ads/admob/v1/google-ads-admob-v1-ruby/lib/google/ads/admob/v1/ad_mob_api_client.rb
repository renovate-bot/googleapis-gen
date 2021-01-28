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
# https://github.com/googleapis/googleapis/blob/master/google/ads/admob/v1/admob_api.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/ads/admob/v1/admob_api_pb"
require "google/ads/admob/v1/credentials"

module Google
  module Ads
    module Admob
      module V1
        # The AdMob API allows AdMob publishers programmatically get information about
        # their AdMob account.
        #
        # @!attribute [r] ad_mob_api_stub
        #   @return [Google::Ads::Admob::V1::AdMobApi::Stub]
        class AdMobApiClient
          attr_reader :ad_mob_api_stub

          # The default address of the service.
          SERVICE_ADDRESS = "admob.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_publisher_accounts" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "account")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/admob.report"
          ].freeze


          ACCOUNT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "accounts/{account}"
          )

          private_constant :ACCOUNT_PATH_TEMPLATE

          # Returns a fully-qualified account resource name string.
          # @param account [String]
          # @return [String]
          def self.account_path account
            ACCOUNT_PATH_TEMPLATE.render(
              :"account" => account
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
            require "google/ads/admob/v1/admob_api_services_pb"

            credentials ||= Google::Ads::Admob::V1::Credentials.default

            if credentials.is_a?(String) || credentials.is_a?(Hash)
              updater_proc = Google::Ads::Admob::V1::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-ads-admob'].version.version

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
              "ad_mob_api_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.ads.admob.v1.AdMobApi",
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
            @ad_mob_api_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Ads::Admob::V1::AdMobApi::Stub.method(:new)
            )

            @get_publisher_account = Google::Gax.create_api_call(
              @ad_mob_api_stub.method(:get_publisher_account),
              defaults["get_publisher_account"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_publisher_accounts = Google::Gax.create_api_call(
              @ad_mob_api_stub.method(:list_publisher_accounts),
              defaults["list_publisher_accounts"],
              exception_transformer: exception_transformer
            )
            @generate_network_report = Google::Gax.create_api_call(
              @ad_mob_api_stub.method(:generate_network_report),
              defaults["generate_network_report"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @generate_mediation_report = Google::Gax.create_api_call(
              @ad_mob_api_stub.method(:generate_mediation_report),
              defaults["generate_mediation_report"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
          end

          # Service calls

          # Gets information about the specified AdMob publisher account.
          #
          # @param name [String]
          #   Resource name of the publisher account to retrieve.
          #   Example: accounts/pub-9876543210987654
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Ads::Admob::V1::PublisherAccount]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Ads::Admob::V1::PublisherAccount]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/ads/admob"
          #
          #   ad_mob_api_client = Google::Ads::Admob.new(version: :v1)
          #   formatted_name = Google::Ads::Admob::V1::AdMobApiClient.account_path("[ACCOUNT]")
          #   response = ad_mob_api_client.get_publisher_account(formatted_name)

          def get_publisher_account \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Ads::Admob::V1::GetPublisherAccountRequest)
            @get_publisher_account.call(req, options, &block)
          end

          # Lists the AdMob publisher account accessible with the client credential.
          # Currently, all credentials have access to at most one AdMob account.
          #
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Ads::Admob::V1::PublisherAccount>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Ads::Admob::V1::PublisherAccount>]
          #   An enumerable of Google::Ads::Admob::V1::PublisherAccount instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/ads/admob"
          #
          #   ad_mob_api_client = Google::Ads::Admob.new(version: :v1)
          #
          #   # Iterate over all results.
          #   ad_mob_api_client.list_publisher_accounts.each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   ad_mob_api_client.list_publisher_accounts.each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_publisher_accounts \
              page_size: nil,
              options: nil,
              &block
            req = {
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Ads::Admob::V1::ListPublisherAccountsRequest)
            @list_publisher_accounts.call(req, options, &block)
          end

          # Generates an AdMob Network report based on the provided report
          # specification.
          #
          # @param parent [String]
          #   Resource name of the account to generate the report for.
          #   Example: accounts/pub-9876543210987654
          # @param report_spec [Google::Ads::Admob::V1::NetworkReportSpec | Hash]
          #   Network report specification.
          #   A hash of the same form as `Google::Ads::Admob::V1::NetworkReportSpec`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Enumerable<Google::Ads::Admob::V1::GenerateNetworkReportResponse>]
          #   An enumerable of Google::Ads::Admob::V1::GenerateNetworkReportResponse instances.
          #
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/ads/admob"
          #
          #   ad_mob_api_client = Google::Ads::Admob.new(version: :v1)
          #   formatted_parent = Google::Ads::Admob::V1::AdMobApiClient.account_path("[ACCOUNT]")
          #
          #   # TODO: Initialize `report_spec`:
          #   report_spec = {}
          #   ad_mob_api_client.generate_network_report(formatted_parent, report_spec).each do |element|
          #     # Process element.
          #   end

          def generate_network_report \
              parent,
              report_spec,
              options: nil
            req = {
              parent: parent,
              report_spec: report_spec
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Ads::Admob::V1::GenerateNetworkReportRequest)
            @generate_network_report.call(req, options)
          end

          # Generates an AdMob Mediation report based on the provided report
          # specification.
          #
          # @param parent [String]
          #   Resource name of the account to generate the report for.
          #   Example: accounts/pub-9876543210987654
          # @param report_spec [Google::Ads::Admob::V1::MediationReportSpec | Hash]
          #   Network report specification.
          #   A hash of the same form as `Google::Ads::Admob::V1::MediationReportSpec`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Enumerable<Google::Ads::Admob::V1::GenerateMediationReportResponse>]
          #   An enumerable of Google::Ads::Admob::V1::GenerateMediationReportResponse instances.
          #
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/ads/admob"
          #
          #   ad_mob_api_client = Google::Ads::Admob.new(version: :v1)
          #   formatted_parent = Google::Ads::Admob::V1::AdMobApiClient.account_path("[ACCOUNT]")
          #
          #   # TODO: Initialize `report_spec`:
          #   report_spec = {}
          #   ad_mob_api_client.generate_mediation_report(formatted_parent, report_spec).each do |element|
          #     # Process element.
          #   end

          def generate_mediation_report \
              parent,
              report_spec,
              options: nil
            req = {
              parent: parent,
              report_spec: report_spec
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Ads::Admob::V1::GenerateMediationReportRequest)
            @generate_mediation_report.call(req, options)
          end
        end
      end
    end
  end
end
