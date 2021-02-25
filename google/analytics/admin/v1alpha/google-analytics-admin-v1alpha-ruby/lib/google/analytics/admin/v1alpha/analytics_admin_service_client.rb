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
# https://github.com/googleapis/googleapis/blob/master/google/analytics/admin/v1alpha/analytics_admin.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/analytics/admin/v1alpha/analytics_admin_pb"
require "google/analytics/admin/v1alpha/credentials"

module Google
  module Analytics
    module Admin
      module V1alpha
        # Service Interface for the Analytics Admin API (GA4).
        #
        # @!attribute [r] analytics_admin_service_stub
        #   @return [Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub]
        class AnalyticsAdminServiceClient
          attr_reader :analytics_admin_service_stub

          # The default address of the service.
          SERVICE_ADDRESS = "analyticsadmin.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_accounts" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "accounts"),
            "list_account_summaries" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "account_summaries"),
            "list_properties" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "properties"),
            "list_user_links" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "user_links"),
            "audit_user_links" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "user_links"),
            "list_web_data_streams" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "web_data_streams"),
            "list_ios_app_data_streams" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "ios_app_data_streams"),
            "list_android_app_data_streams" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "android_app_data_streams"),
            "list_firebase_links" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "firebase_links"),
            "list_google_ads_links" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "google_ads_links")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/analytics.edit",
            "https://www.googleapis.com/auth/analytics.manage.users",
            "https://www.googleapis.com/auth/analytics.manage.users.readonly",
            "https://www.googleapis.com/auth/analytics.readonly"
          ].freeze


          ACCOUNT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "accounts/{account}"
          )

          private_constant :ACCOUNT_PATH_TEMPLATE

          ANDROID_APP_DATA_STREAM_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "properties/{property}/androidAppDataStreams/{android_app_data_stream}"
          )

          private_constant :ANDROID_APP_DATA_STREAM_PATH_TEMPLATE

          DATA_SHARING_SETTINGS_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "accounts/{account}/dataSharingSettings"
          )

          private_constant :DATA_SHARING_SETTINGS_PATH_TEMPLATE

          ENHANCED_MEASUREMENT_SETTINGS_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "properties/{property}/webDataStreams/{web_data_stream}/enhancedMeasurementSettings"
          )

          private_constant :ENHANCED_MEASUREMENT_SETTINGS_PATH_TEMPLATE

          FIREBASE_LINK_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "properties/{property}/firebaseLinks/{firebase_link}"
          )

          private_constant :FIREBASE_LINK_PATH_TEMPLATE

          GLOBAL_SITE_TAG_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "properties/{property}/globalSiteTag"
          )

          private_constant :GLOBAL_SITE_TAG_PATH_TEMPLATE

          GOOGLE_ADS_LINK_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "properties/{property}/googleAdsLinks/{google_ads_link}"
          )

          private_constant :GOOGLE_ADS_LINK_PATH_TEMPLATE

          IOS_APP_DATA_STREAM_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "properties/{property}/iosAppDataStreams/{ios_app_data_stream}"
          )

          private_constant :IOS_APP_DATA_STREAM_PATH_TEMPLATE

          PROPERTY_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "properties/{property}"
          )

          private_constant :PROPERTY_PATH_TEMPLATE

          USER_LINK_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "accounts/{account}/userLinks/{user_link}"
          )

          private_constant :USER_LINK_PATH_TEMPLATE

          WEB_DATA_STREAM_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "properties/{property}/webDataStreams/{web_data_stream}"
          )

          private_constant :WEB_DATA_STREAM_PATH_TEMPLATE

          # Returns a fully-qualified account resource name string.
          # @param account [String]
          # @return [String]
          def self.account_path account
            ACCOUNT_PATH_TEMPLATE.render(
              :"account" => account
            )
          end

          # Returns a fully-qualified android_app_data_stream resource name string.
          # @param property [String]
          # @param android_app_data_stream [String]
          # @return [String]
          def self.android_app_data_stream_path property, android_app_data_stream
            ANDROID_APP_DATA_STREAM_PATH_TEMPLATE.render(
              :"property" => property,
              :"android_app_data_stream" => android_app_data_stream
            )
          end

          # Returns a fully-qualified data_sharing_settings resource name string.
          # @param account [String]
          # @return [String]
          def self.data_sharing_settings_path account
            DATA_SHARING_SETTINGS_PATH_TEMPLATE.render(
              :"account" => account
            )
          end

          # Returns a fully-qualified enhanced_measurement_settings resource name string.
          # @param property [String]
          # @param web_data_stream [String]
          # @return [String]
          def self.enhanced_measurement_settings_path property, web_data_stream
            ENHANCED_MEASUREMENT_SETTINGS_PATH_TEMPLATE.render(
              :"property" => property,
              :"web_data_stream" => web_data_stream
            )
          end

          # Returns a fully-qualified firebase_link resource name string.
          # @param property [String]
          # @param firebase_link [String]
          # @return [String]
          def self.firebase_link_path property, firebase_link
            FIREBASE_LINK_PATH_TEMPLATE.render(
              :"property" => property,
              :"firebase_link" => firebase_link
            )
          end

          # Returns a fully-qualified global_site_tag resource name string.
          # @param property [String]
          # @return [String]
          def self.global_site_tag_path property
            GLOBAL_SITE_TAG_PATH_TEMPLATE.render(
              :"property" => property
            )
          end

          # Returns a fully-qualified google_ads_link resource name string.
          # @param property [String]
          # @param google_ads_link [String]
          # @return [String]
          def self.google_ads_link_path property, google_ads_link
            GOOGLE_ADS_LINK_PATH_TEMPLATE.render(
              :"property" => property,
              :"google_ads_link" => google_ads_link
            )
          end

          # Returns a fully-qualified ios_app_data_stream resource name string.
          # @param property [String]
          # @param ios_app_data_stream [String]
          # @return [String]
          def self.ios_app_data_stream_path property, ios_app_data_stream
            IOS_APP_DATA_STREAM_PATH_TEMPLATE.render(
              :"property" => property,
              :"ios_app_data_stream" => ios_app_data_stream
            )
          end

          # Returns a fully-qualified property resource name string.
          # @param property [String]
          # @return [String]
          def self.property_path property
            PROPERTY_PATH_TEMPLATE.render(
              :"property" => property
            )
          end

          # Returns a fully-qualified user_link resource name string.
          # @param account [String]
          # @param user_link [String]
          # @return [String]
          def self.user_link_path account, user_link
            USER_LINK_PATH_TEMPLATE.render(
              :"account" => account,
              :"user_link" => user_link
            )
          end

          # Returns a fully-qualified web_data_stream resource name string.
          # @param property [String]
          # @param web_data_stream [String]
          # @return [String]
          def self.web_data_stream_path property, web_data_stream
            WEB_DATA_STREAM_PATH_TEMPLATE.render(
              :"property" => property,
              :"web_data_stream" => web_data_stream
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
            require "google/analytics/admin/v1alpha/analytics_admin_services_pb"

            credentials ||= Google::Analytics::Admin::V1alpha::Credentials.default

            if credentials.is_a?(String) || credentials.is_a?(Hash)
              updater_proc = Google::Analytics::Admin::V1alpha::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-analytics-admin'].version.version

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
              "analytics_admin_service_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.analytics.admin.v1alpha.AnalyticsAdminService",
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
            @analytics_admin_service_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Analytics::Admin::V1alpha::AnalyticsAdminService::Stub.method(:new)
            )

            @get_account = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:get_account),
              defaults["get_account"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_accounts = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:list_accounts),
              defaults["list_accounts"],
              exception_transformer: exception_transformer
            )
            @delete_account = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:delete_account),
              defaults["delete_account"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @update_account = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:update_account),
              defaults["update_account"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'account.name' => request.account.name}
              end
            )
            @provision_account_ticket = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:provision_account_ticket),
              defaults["provision_account_ticket"],
              exception_transformer: exception_transformer
            )
            @list_account_summaries = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:list_account_summaries),
              defaults["list_account_summaries"],
              exception_transformer: exception_transformer
            )
            @get_property = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:get_property),
              defaults["get_property"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_properties = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:list_properties),
              defaults["list_properties"],
              exception_transformer: exception_transformer
            )
            @create_property = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:create_property),
              defaults["create_property"],
              exception_transformer: exception_transformer
            )
            @delete_property = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:delete_property),
              defaults["delete_property"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @update_property = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:update_property),
              defaults["update_property"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'property.name' => request.property.name}
              end
            )
            @get_user_link = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:get_user_link),
              defaults["get_user_link"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @batch_get_user_links = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:batch_get_user_links),
              defaults["batch_get_user_links"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @list_user_links = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:list_user_links),
              defaults["list_user_links"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @audit_user_links = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:audit_user_links),
              defaults["audit_user_links"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @create_user_link = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:create_user_link),
              defaults["create_user_link"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @batch_create_user_links = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:batch_create_user_links),
              defaults["batch_create_user_links"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @update_user_link = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:update_user_link),
              defaults["update_user_link"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'user_link.name' => request.user_link.name}
              end
            )
            @batch_update_user_links = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:batch_update_user_links),
              defaults["batch_update_user_links"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @delete_user_link = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:delete_user_link),
              defaults["delete_user_link"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @batch_delete_user_links = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:batch_delete_user_links),
              defaults["batch_delete_user_links"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_web_data_stream = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:get_web_data_stream),
              defaults["get_web_data_stream"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @delete_web_data_stream = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:delete_web_data_stream),
              defaults["delete_web_data_stream"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @update_web_data_stream = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:update_web_data_stream),
              defaults["update_web_data_stream"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'web_data_stream.name' => request.web_data_stream.name}
              end
            )
            @create_web_data_stream = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:create_web_data_stream),
              defaults["create_web_data_stream"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @list_web_data_streams = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:list_web_data_streams),
              defaults["list_web_data_streams"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_ios_app_data_stream = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:get_ios_app_data_stream),
              defaults["get_ios_app_data_stream"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @delete_ios_app_data_stream = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:delete_ios_app_data_stream),
              defaults["delete_ios_app_data_stream"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @update_ios_app_data_stream = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:update_ios_app_data_stream),
              defaults["update_ios_app_data_stream"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'ios_app_data_stream.name' => request.ios_app_data_stream.name}
              end
            )
            @create_ios_app_data_stream = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:create_ios_app_data_stream),
              defaults["create_ios_app_data_stream"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @list_ios_app_data_streams = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:list_ios_app_data_streams),
              defaults["list_ios_app_data_streams"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_android_app_data_stream = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:get_android_app_data_stream),
              defaults["get_android_app_data_stream"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @delete_android_app_data_stream = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:delete_android_app_data_stream),
              defaults["delete_android_app_data_stream"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @update_android_app_data_stream = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:update_android_app_data_stream),
              defaults["update_android_app_data_stream"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'android_app_data_stream.name' => request.android_app_data_stream.name}
              end
            )
            @create_android_app_data_stream = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:create_android_app_data_stream),
              defaults["create_android_app_data_stream"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @list_android_app_data_streams = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:list_android_app_data_streams),
              defaults["list_android_app_data_streams"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_enhanced_measurement_settings = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:get_enhanced_measurement_settings),
              defaults["get_enhanced_measurement_settings"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @update_enhanced_measurement_settings = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:update_enhanced_measurement_settings),
              defaults["update_enhanced_measurement_settings"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'enhanced_measurement_settings.name' => request.enhanced_measurement_settings.name}
              end
            )
            @create_firebase_link = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:create_firebase_link),
              defaults["create_firebase_link"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @update_firebase_link = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:update_firebase_link),
              defaults["update_firebase_link"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'firebase_link.name' => request.firebase_link.name}
              end
            )
            @delete_firebase_link = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:delete_firebase_link),
              defaults["delete_firebase_link"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_firebase_links = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:list_firebase_links),
              defaults["list_firebase_links"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_global_site_tag = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:get_global_site_tag),
              defaults["get_global_site_tag"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @create_google_ads_link = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:create_google_ads_link),
              defaults["create_google_ads_link"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @update_google_ads_link = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:update_google_ads_link),
              defaults["update_google_ads_link"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'google_ads_link.name' => request.google_ads_link.name}
              end
            )
            @delete_google_ads_link = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:delete_google_ads_link),
              defaults["delete_google_ads_link"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_google_ads_links = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:list_google_ads_links),
              defaults["list_google_ads_links"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_data_sharing_settings = Google::Gax.create_api_call(
              @analytics_admin_service_stub.method(:get_data_sharing_settings),
              defaults["get_data_sharing_settings"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
          end

          # Service calls

          # Lookup for a single Account.
          #
          # @param name [String]
          #   Required. The name of the account to lookup.
          #   Format: accounts/{account}
          #   Example: "accounts/100"
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::Account]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::Account]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")
          #   response = analytics_admin_client.get_account(formatted_name)

          def get_account \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::GetAccountRequest)
            @get_account.call(req, options, &block)
          end

          # Returns all accounts accessible by the caller.
          #
          # Note that these accounts might not currently have GA4 properties.
          # Soft-deleted (ie: "trashed") accounts are excluded by default.
          # Returns an empty list if no relevant accounts are found.
          #
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param show_deleted [true, false]
          #   Whether to include soft-deleted (ie: "trashed") Accounts in the
          #   results. Accounts can be inspected to determine whether they are deleted or
          #   not.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Analytics::Admin::V1alpha::Account>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Analytics::Admin::V1alpha::Account>]
          #   An enumerable of Google::Analytics::Admin::V1alpha::Account instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #
          #   # Iterate over all results.
          #   analytics_admin_client.list_accounts.each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   analytics_admin_client.list_accounts.each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_accounts \
              page_size: nil,
              show_deleted: nil,
              options: nil,
              &block
            req = {
              page_size: page_size,
              show_deleted: show_deleted
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::ListAccountsRequest)
            @list_accounts.call(req, options, &block)
          end

          # Marks target Account as soft-deleted (ie: "trashed") and returns it.
          #
          # This API does not have a method to restore soft-deleted accounts.
          # However, they can be restored using the Trash Can UI.
          #
          # If the accounts are not restored before the expiration time, the account
          # and all child resources (eg: Properties, GoogleAdsLinks, Streams,
          # UserLinks) will be permanently purged.
          # https://support.google.com/analytics/answer/6154772
          #
          # Returns an error if the target is not found.
          #
          # @param name [String]
          #   Required. The name of the Account to soft-delete.
          #   Format: accounts/{account}
          #   Example: "accounts/100"
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")
          #   analytics_admin_client.delete_account(formatted_name)

          def delete_account \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::DeleteAccountRequest)
            @delete_account.call(req, options, &block)
            nil
          end

          # Updates an account.
          #
          # @param account [Google::Analytics::Admin::V1alpha::Account | Hash]
          #   Required. The account to update.
          #   The account's `name` field is used to identify the account.
          #   A hash of the same form as `Google::Analytics::Admin::V1alpha::Account`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Required. The list of fields to be updated. Field names must be in snake case
          #   (e.g., "field_to_update"). Omitted fields will not be updated. To replace
          #   the entire entity, use one path with the string "*" to match all fields.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::Account]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::Account]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #
          #   # TODO: Initialize `account`:
          #   account = {}
          #
          #   # TODO: Initialize `update_mask`:
          #   update_mask = {}
          #   response = analytics_admin_client.update_account(account, update_mask)

          def update_account \
              account,
              update_mask,
              options: nil,
              &block
            req = {
              account: account,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::UpdateAccountRequest)
            @update_account.call(req, options, &block)
          end

          # Requests a ticket for creating an account.
          #
          # @param account [Google::Analytics::Admin::V1alpha::Account | Hash]
          #   The account to create.
          #   A hash of the same form as `Google::Analytics::Admin::V1alpha::Account`
          #   can also be provided.
          # @param redirect_uri [String]
          #   Redirect URI where the user will be sent after accepting Terms of Service.
          #   Must be configured in Developers Console as a Redirect URI
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::ProvisionAccountTicketResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::ProvisionAccountTicketResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   response = analytics_admin_client.provision_account_ticket

          def provision_account_ticket \
              account: nil,
              redirect_uri: nil,
              options: nil,
              &block
            req = {
              account: account,
              redirect_uri: redirect_uri
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::ProvisionAccountTicketRequest)
            @provision_account_ticket.call(req, options, &block)
          end

          # Returns summaries of all accounts accessible by the caller.
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Analytics::Admin::V1alpha::AccountSummary>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Analytics::Admin::V1alpha::AccountSummary>]
          #   An enumerable of Google::Analytics::Admin::V1alpha::AccountSummary instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #
          #   # Iterate over all results.
          #   analytics_admin_client.list_account_summaries.each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   analytics_admin_client.list_account_summaries.each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_account_summaries \
              page_size: nil,
              options: nil,
              &block
            req = {
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::ListAccountSummariesRequest)
            @list_account_summaries.call(req, options, &block)
          end

          # Lookup for a single "GA4" Property.
          #
          # @param name [String]
          #   Required. The name of the property to lookup.
          #   Format: properties/{property_id}
          #   Example: "properties/1000"
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::Property]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::Property]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")
          #   response = analytics_admin_client.get_property(formatted_name)

          def get_property \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::GetPropertyRequest)
            @get_property.call(req, options, &block)
          end

          # Returns child Properties under the specified parent Account.
          #
          # Only "GA4" properties will be returned.
          # Properties will be excluded if the caller does not have access.
          # Soft-deleted (ie: "trashed") properties are excluded by default.
          # Returns an empty list if no relevant properties are found.
          #
          # @param filter [String]
          #   Required. An expression for filtering the results of the request.
          #   Fields eligible for filtering are:
          #   `parent:`(The resource name of the parent account) or
          #   `firebase_project:`(The id or number of the linked firebase project).
          #   Some examples of filters:
          #
          #   ```
          #   | Filter                      | Description                               |
          #   |-----------------------------|-------------------------------------------|
          #   | parent:accounts/123         | The account with account id: 123.         |
          #   | firebase_project:project-id | The firebase project with id: project-id. |
          #   | firebase_project:123        | The firebase project with number: 123.    |
          #   ```
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param show_deleted [true, false]
          #   Whether to include soft-deleted (ie: "trashed") Properties in the
          #   results. Properties can be inspected to determine whether they are deleted
          #   or not.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Analytics::Admin::V1alpha::Property>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Analytics::Admin::V1alpha::Property>]
          #   An enumerable of Google::Analytics::Admin::V1alpha::Property instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #
          #   # TODO: Initialize `filter`:
          #   filter = ''
          #
          #   # Iterate over all results.
          #   analytics_admin_client.list_properties(filter).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   analytics_admin_client.list_properties(filter).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_properties \
              filter,
              page_size: nil,
              show_deleted: nil,
              options: nil,
              &block
            req = {
              filter: filter,
              page_size: page_size,
              show_deleted: show_deleted
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::ListPropertiesRequest)
            @list_properties.call(req, options, &block)
          end

          # Creates an "GA4" property with the specified location and attributes.
          #
          # @param property [Google::Analytics::Admin::V1alpha::Property | Hash]
          #   Required. The property to create.
          #   Note: the supplied property must specify its parent.
          #   A hash of the same form as `Google::Analytics::Admin::V1alpha::Property`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::Property]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::Property]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #
          #   # TODO: Initialize `property`:
          #   property = {}
          #   response = analytics_admin_client.create_property(property)

          def create_property \
              property,
              options: nil,
              &block
            req = {
              property: property
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::CreatePropertyRequest)
            @create_property.call(req, options, &block)
          end

          # Marks target Property as soft-deleted (ie: "trashed") and returns it.
          #
          # This API does not have a method to restore soft-deleted properties.
          # However, they can be restored using the Trash Can UI.
          #
          # If the properties are not restored before the expiration time, the Property
          # and all child resources (eg: GoogleAdsLinks, Streams, UserLinks)
          # will be permanently purged.
          # https://support.google.com/analytics/answer/6154772
          #
          # Returns an error if the target is not found, or is not an GA4 Property.
          #
          # @param name [String]
          #   Required. The name of the Property to soft-delete.
          #   Format: properties/{property_id}
          #   Example: "properties/1000"
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")
          #   analytics_admin_client.delete_property(formatted_name)

          def delete_property \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::DeletePropertyRequest)
            @delete_property.call(req, options, &block)
            nil
          end

          # Updates a property.
          #
          # @param property [Google::Analytics::Admin::V1alpha::Property | Hash]
          #   Required. The property to update.
          #   The property's `name` field is used to identify the property to be
          #   updated.
          #   A hash of the same form as `Google::Analytics::Admin::V1alpha::Property`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Required. The list of fields to be updated. Field names must be in snake case
          #   (e.g., "field_to_update"). Omitted fields will not be updated. To replace
          #   the entire entity, use one path with the string "*" to match all fields.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::Property]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::Property]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #
          #   # TODO: Initialize `property`:
          #   property = {}
          #
          #   # TODO: Initialize `update_mask`:
          #   update_mask = {}
          #   response = analytics_admin_client.update_property(property, update_mask)

          def update_property \
              property,
              update_mask,
              options: nil,
              &block
            req = {
              property: property,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::UpdatePropertyRequest)
            @update_property.call(req, options, &block)
          end

          # Gets information about a user's link to an account or property.
          #
          # @param name [String]
          #   Required. Example format: accounts/1234/userLinks/5678
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::UserLink]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::UserLink]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #   response = analytics_admin_client.get_user_link(name)

          def get_user_link \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::GetUserLinkRequest)
            @get_user_link.call(req, options, &block)
          end

          # Gets information about multiple users' links to an account or property.
          #
          # @param parent [String]
          #   Required. The account or property that all user links in the request are
          #   for. The parent of all provided values for the 'names' field must match
          #   this field.
          #   Example format: accounts/1234
          # @param names [Array<String>]
          #   Required. The names of the user links to retrieve.
          #   A maximum of 1000 user links can be retrieved in a batch.
          #   Format: accounts/{accountId}/userLinks/{userLinkId}
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::BatchGetUserLinksResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::BatchGetUserLinksResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")
          #
          #   # TODO: Initialize `names`:
          #   names = []
          #   response = analytics_admin_client.batch_get_user_links(formatted_parent, names)

          def batch_get_user_links \
              parent,
              names,
              options: nil,
              &block
            req = {
              parent: parent,
              names: names
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::BatchGetUserLinksRequest)
            @batch_get_user_links.call(req, options, &block)
          end

          # Lists all user links on an account or property.
          #
          # @param parent [String]
          #   Required. Example format: accounts/1234
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Analytics::Admin::V1alpha::UserLink>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Analytics::Admin::V1alpha::UserLink>]
          #   An enumerable of Google::Analytics::Admin::V1alpha::UserLink instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")
          #
          #   # Iterate over all results.
          #   analytics_admin_client.list_user_links(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   analytics_admin_client.list_user_links(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_user_links \
              parent,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::ListUserLinksRequest)
            @list_user_links.call(req, options, &block)
          end

          # Lists all user links on an account or property, including implicit ones
          # that come from effective permissions granted by groups or organization
          # admin roles.
          #
          # If a returned user link does not have direct permissions, they cannot
          # be removed from the account or property directly with the DeleteUserLink
          # command. They have to be removed from the group/etc that gives them
          # permissions, which is currently only usable/discoverable in the GA or GMP
          # UIs.
          #
          # @param parent [String]
          #   Required. Example format: accounts/1234
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Analytics::Admin::V1alpha::AuditUserLink>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Analytics::Admin::V1alpha::AuditUserLink>]
          #   An enumerable of Google::Analytics::Admin::V1alpha::AuditUserLink instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")
          #
          #   # Iterate over all results.
          #   analytics_admin_client.audit_user_links(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   analytics_admin_client.audit_user_links(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def audit_user_links \
              parent,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::AuditUserLinksRequest)
            @audit_user_links.call(req, options, &block)
          end

          # Creates a user link on an account or property.
          #
          # If the user with the specified email already has permissions on the
          # account or property, then the user's existing permissions will be unioned
          # with the permissions specified in the new UserLink.
          #
          # @param parent [String]
          #   Required. Example format: accounts/1234
          # @param user_link [Google::Analytics::Admin::V1alpha::UserLink | Hash]
          #   Required. The user link to create.
          #   A hash of the same form as `Google::Analytics::Admin::V1alpha::UserLink`
          #   can also be provided.
          # @param notify_new_user [true, false]
          #   Optional. If set, then email the new user notifying them that they've been granted
          #   permissions to the resource.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::UserLink]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::UserLink]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")
          #
          #   # TODO: Initialize `user_link`:
          #   user_link = {}
          #   response = analytics_admin_client.create_user_link(formatted_parent, user_link)

          def create_user_link \
              parent,
              user_link,
              notify_new_user: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              user_link: user_link,
              notify_new_user: notify_new_user
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::CreateUserLinkRequest)
            @create_user_link.call(req, options, &block)
          end

          # Creates information about multiple users' links to an account or property.
          #
          # This method is transactional. If any UserLink cannot be created, none of
          # the UserLinks will be created.
          #
          # @param parent [String]
          #   Required. The account or property that all user links in the request are for.
          #   This field is required. The parent field in the CreateUserLinkRequest
          #   messages must either be empty or match this field.
          #   Example format: accounts/1234
          # @param requests [Array<Google::Analytics::Admin::V1alpha::CreateUserLinkRequest | Hash>]
          #   Required. The requests specifying the user links to create.
          #   A maximum of 1000 user links can be created in a batch.
          #   A hash of the same form as `Google::Analytics::Admin::V1alpha::CreateUserLinkRequest`
          #   can also be provided.
          # @param notify_new_users [true, false]
          #   Optional. If set, then email the new users notifying them that they've been granted
          #   permissions to the resource. Regardless of whether this is set or not,
          #   notify_new_user field inside each individual request is ignored.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::BatchCreateUserLinksResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::BatchCreateUserLinksResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")
          #
          #   # TODO: Initialize `requests`:
          #   requests = []
          #   response = analytics_admin_client.batch_create_user_links(formatted_parent, requests)

          def batch_create_user_links \
              parent,
              requests,
              notify_new_users: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              requests: requests,
              notify_new_users: notify_new_users
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::BatchCreateUserLinksRequest)
            @batch_create_user_links.call(req, options, &block)
          end

          # Updates a user link on an account or property.
          #
          # @param user_link [Google::Analytics::Admin::V1alpha::UserLink | Hash]
          #   Required. The user link to update.
          #   A hash of the same form as `Google::Analytics::Admin::V1alpha::UserLink`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::UserLink]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::UserLink]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #
          #   # TODO: Initialize `user_link`:
          #   user_link = {}
          #   response = analytics_admin_client.update_user_link(user_link)

          def update_user_link \
              user_link,
              options: nil,
              &block
            req = {
              user_link: user_link
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::UpdateUserLinkRequest)
            @update_user_link.call(req, options, &block)
          end

          # Updates information about multiple users' links to an account or property.
          #
          # @param parent [String]
          #   Required. The account or property that all user links in the request are
          #   for. The parent field in the UpdateUserLinkRequest messages must either be
          #   empty or match this field.
          #   Example format: accounts/1234
          # @param requests [Array<Google::Analytics::Admin::V1alpha::UpdateUserLinkRequest | Hash>]
          #   Required. The requests specifying the user links to update.
          #   A maximum of 1000 user links can be updated in a batch.
          #   A hash of the same form as `Google::Analytics::Admin::V1alpha::UpdateUserLinkRequest`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::BatchUpdateUserLinksResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::BatchUpdateUserLinksResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")
          #
          #   # TODO: Initialize `requests`:
          #   requests = []
          #   response = analytics_admin_client.batch_update_user_links(formatted_parent, requests)

          def batch_update_user_links \
              parent,
              requests,
              options: nil,
              &block
            req = {
              parent: parent,
              requests: requests
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::BatchUpdateUserLinksRequest)
            @batch_update_user_links.call(req, options, &block)
          end

          # Deletes a user link on an account or property.
          #
          # @param name [String]
          #   Required. Example format: accounts/1234/userLinks/5678
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #   analytics_admin_client.delete_user_link(name)

          def delete_user_link \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::DeleteUserLinkRequest)
            @delete_user_link.call(req, options, &block)
            nil
          end

          # Deletes information about multiple users' links to an account or property.
          #
          # @param parent [String]
          #   Required. The account or property that all user links in the request are
          #   for. The parent of all values for user link names to delete must match this
          #   field.
          #   Example format: accounts/1234
          # @param requests [Array<Google::Analytics::Admin::V1alpha::DeleteUserLinkRequest | Hash>]
          #   Required. The requests specifying the user links to update.
          #   A maximum of 1000 user links can be updated in a batch.
          #   A hash of the same form as `Google::Analytics::Admin::V1alpha::DeleteUserLinkRequest`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.account_path("[ACCOUNT]")
          #
          #   # TODO: Initialize `requests`:
          #   requests = []
          #   analytics_admin_client.batch_delete_user_links(formatted_parent, requests)

          def batch_delete_user_links \
              parent,
              requests,
              options: nil,
              &block
            req = {
              parent: parent,
              requests: requests
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::BatchDeleteUserLinksRequest)
            @batch_delete_user_links.call(req, options, &block)
            nil
          end

          # Lookup for a single WebDataStream
          #
          # @param name [String]
          #   Required. The name of the web data stream to lookup.
          #   Format: properties/{property_id}/webDataStreams/{stream_id}
          #   Example: "properties/123/webDataStreams/456"
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::WebDataStream]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::WebDataStream]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.web_data_stream_path("[PROPERTY]", "[WEB_DATA_STREAM]")
          #   response = analytics_admin_client.get_web_data_stream(formatted_name)

          def get_web_data_stream \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::GetWebDataStreamRequest)
            @get_web_data_stream.call(req, options, &block)
          end

          # Deletes a web stream on a property.
          #
          # @param name [String]
          #   Required. The name of the web data stream to delete.
          #   Format: properties/{property_id}/webDataStreams/{stream_id}
          #   Example: "properties/123/webDataStreams/456"
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.web_data_stream_path("[PROPERTY]", "[WEB_DATA_STREAM]")
          #   analytics_admin_client.delete_web_data_stream(formatted_name)

          def delete_web_data_stream \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::DeleteWebDataStreamRequest)
            @delete_web_data_stream.call(req, options, &block)
            nil
          end

          # Updates a web stream on a property.
          #
          # @param web_data_stream [Google::Analytics::Admin::V1alpha::WebDataStream | Hash]
          #   Required. The web stream to update.
          #   The `name` field is used to identify the web stream to be updated.
          #   A hash of the same form as `Google::Analytics::Admin::V1alpha::WebDataStream`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Required. The list of fields to be updated. Field names must be in snake case
          #   (e.g., "field_to_update"). Omitted fields will not be updated. To replace
          #   the entire entity, use one path with the string "*" to match all fields.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::WebDataStream]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::WebDataStream]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #
          #   # TODO: Initialize `web_data_stream`:
          #   web_data_stream = {}
          #
          #   # TODO: Initialize `update_mask`:
          #   update_mask = {}
          #   response = analytics_admin_client.update_web_data_stream(web_data_stream, update_mask)

          def update_web_data_stream \
              web_data_stream,
              update_mask,
              options: nil,
              &block
            req = {
              web_data_stream: web_data_stream,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::UpdateWebDataStreamRequest)
            @update_web_data_stream.call(req, options, &block)
          end

          # Creates a web stream with the specified location and attributes.
          #
          # @param web_data_stream [Google::Analytics::Admin::V1alpha::WebDataStream | Hash]
          #   Required. The web stream to create.
          #   A hash of the same form as `Google::Analytics::Admin::V1alpha::WebDataStream`
          #   can also be provided.
          # @param parent [String]
          #   Required. The parent resource where this web data stream will be created.
          #   Format: properties/123
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::WebDataStream]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::WebDataStream]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #
          #   # TODO: Initialize `web_data_stream`:
          #   web_data_stream = {}
          #   formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")
          #   response = analytics_admin_client.create_web_data_stream(web_data_stream, formatted_parent)

          def create_web_data_stream \
              web_data_stream,
              parent,
              options: nil,
              &block
            req = {
              web_data_stream: web_data_stream,
              parent: parent
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::CreateWebDataStreamRequest)
            @create_web_data_stream.call(req, options, &block)
          end

          # Returns child web data streams under the specified parent property.
          #
          # Web data streams will be excluded if the caller does not have access.
          # Returns an empty list if no relevant web data streams are found.
          #
          # @param parent [String]
          #   Required. The name of the parent property.
          #   For example, to list results of web streams under the property with Id
          #   123: "properties/123"
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Analytics::Admin::V1alpha::WebDataStream>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Analytics::Admin::V1alpha::WebDataStream>]
          #   An enumerable of Google::Analytics::Admin::V1alpha::WebDataStream instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")
          #
          #   # Iterate over all results.
          #   analytics_admin_client.list_web_data_streams(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   analytics_admin_client.list_web_data_streams(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_web_data_streams \
              parent,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::ListWebDataStreamsRequest)
            @list_web_data_streams.call(req, options, &block)
          end

          # Lookup for a single IosAppDataStream
          #
          # @param name [String]
          #   Required. The name of the iOS app data stream to lookup.
          #   Format: properties/{property_id}/iosAppDataStreams/{stream_id}
          #   Example: "properties/123/iosAppDataStreams/456"
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::IosAppDataStream]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::IosAppDataStream]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.ios_app_data_stream_path("[PROPERTY]", "[IOS_APP_DATA_STREAM]")
          #   response = analytics_admin_client.get_ios_app_data_stream(formatted_name)

          def get_ios_app_data_stream \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::GetIosAppDataStreamRequest)
            @get_ios_app_data_stream.call(req, options, &block)
          end

          # Deletes an iOS app stream on a property.
          #
          # @param name [String]
          #   Required. The name of the iOS app data stream to delete.
          #   Format: properties/{property_id}/iosAppDataStreams/{stream_id}
          #   Example: "properties/123/iosAppDataStreams/456"
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.ios_app_data_stream_path("[PROPERTY]", "[IOS_APP_DATA_STREAM]")
          #   analytics_admin_client.delete_ios_app_data_stream(formatted_name)

          def delete_ios_app_data_stream \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::DeleteIosAppDataStreamRequest)
            @delete_ios_app_data_stream.call(req, options, &block)
            nil
          end

          # Updates an iOS app stream on a property.
          #
          # @param ios_app_data_stream [Google::Analytics::Admin::V1alpha::IosAppDataStream | Hash]
          #   Required. The iOS app stream to update.
          #   The `name` field is used to identify the iOS app stream to be updated.
          #   A hash of the same form as `Google::Analytics::Admin::V1alpha::IosAppDataStream`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Required. The list of fields to be updated. Field names must be in snake case
          #   (e.g., "field_to_update"). Omitted fields will not be updated. To replace
          #   the entire entity, use one path with the string "*" to match all fields.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::IosAppDataStream]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::IosAppDataStream]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #
          #   # TODO: Initialize `ios_app_data_stream`:
          #   ios_app_data_stream = {}
          #
          #   # TODO: Initialize `update_mask`:
          #   update_mask = {}
          #   response = analytics_admin_client.update_ios_app_data_stream(ios_app_data_stream, update_mask)

          def update_ios_app_data_stream \
              ios_app_data_stream,
              update_mask,
              options: nil,
              &block
            req = {
              ios_app_data_stream: ios_app_data_stream,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::UpdateIosAppDataStreamRequest)
            @update_ios_app_data_stream.call(req, options, &block)
          end

          # Creates an iOS app stream with the specified location and attributes.
          #
          # Note that an iOS app stream must be linked to a Firebase app to receive
          # traffic.
          #
          # To create a working app stream, make sure your property is linked to a
          # Firebase project. Then, use the Firebase API to create a Firebase app,
          # which will also create an appropriate data stream in Analytics (may take up
          # to 24 hours).
          #
          # @param ios_app_data_stream [Google::Analytics::Admin::V1alpha::IosAppDataStream | Hash]
          #   Required. The iOS app data stream to create.
          #   A hash of the same form as `Google::Analytics::Admin::V1alpha::IosAppDataStream`
          #   can also be provided.
          # @param parent [String]
          #   Required. The parent resource where this ios app data stream will be created.
          #   Format: properties/123
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::IosAppDataStream]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::IosAppDataStream]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #
          #   # TODO: Initialize `ios_app_data_stream`:
          #   ios_app_data_stream = {}
          #   formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")
          #   response = analytics_admin_client.create_ios_app_data_stream(ios_app_data_stream, formatted_parent)

          def create_ios_app_data_stream \
              ios_app_data_stream,
              parent,
              options: nil,
              &block
            req = {
              ios_app_data_stream: ios_app_data_stream,
              parent: parent
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::CreateIosAppDataStreamRequest)
            @create_ios_app_data_stream.call(req, options, &block)
          end

          # Returns child iOS app data streams under the specified parent property.
          #
          # iOS app data streams will be excluded if the caller does not have access.
          # Returns an empty list if no relevant iOS app data streams are found.
          #
          # @param parent [String]
          #   Required. The name of the parent property.
          #   For example, to list results of app streams under the property with Id
          #   123: "properties/123"
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Analytics::Admin::V1alpha::IosAppDataStream>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Analytics::Admin::V1alpha::IosAppDataStream>]
          #   An enumerable of Google::Analytics::Admin::V1alpha::IosAppDataStream instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")
          #
          #   # Iterate over all results.
          #   analytics_admin_client.list_ios_app_data_streams(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   analytics_admin_client.list_ios_app_data_streams(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_ios_app_data_streams \
              parent,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::ListIosAppDataStreamsRequest)
            @list_ios_app_data_streams.call(req, options, &block)
          end

          # Lookup for a single AndroidAppDataStream
          #
          # @param name [String]
          #   Required. The name of the android app data stream to lookup.
          #   Format: properties/{property_id}/androidAppDataStreams/{stream_id}
          #   Example: "properties/123/androidAppDataStreams/456"
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::AndroidAppDataStream]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::AndroidAppDataStream]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.android_app_data_stream_path("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]")
          #   response = analytics_admin_client.get_android_app_data_stream(formatted_name)

          def get_android_app_data_stream \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::GetAndroidAppDataStreamRequest)
            @get_android_app_data_stream.call(req, options, &block)
          end

          # Deletes an android app stream on a property.
          #
          # @param name [String]
          #   Required. The name of the android app data stream to delete.
          #   Format: properties/{property_id}/androidAppDataStreams/{stream_id}
          #   Example: "properties/123/androidAppDataStreams/456"
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.android_app_data_stream_path("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]")
          #   analytics_admin_client.delete_android_app_data_stream(formatted_name)

          def delete_android_app_data_stream \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::DeleteAndroidAppDataStreamRequest)
            @delete_android_app_data_stream.call(req, options, &block)
            nil
          end

          # Updates an android app stream on a property.
          #
          # @param android_app_data_stream [Google::Analytics::Admin::V1alpha::AndroidAppDataStream | Hash]
          #   Required. The android app stream to update.
          #   The `name` field is used to identify the android app stream to be updated.
          #   A hash of the same form as `Google::Analytics::Admin::V1alpha::AndroidAppDataStream`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Required. The list of fields to be updated. Field names must be in snake case
          #   (e.g., "field_to_update"). Omitted fields will not be updated. To replace
          #   the entire entity, use one path with the string "*" to match all fields.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::AndroidAppDataStream]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::AndroidAppDataStream]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #
          #   # TODO: Initialize `android_app_data_stream`:
          #   android_app_data_stream = {}
          #
          #   # TODO: Initialize `update_mask`:
          #   update_mask = {}
          #   response = analytics_admin_client.update_android_app_data_stream(android_app_data_stream, update_mask)

          def update_android_app_data_stream \
              android_app_data_stream,
              update_mask,
              options: nil,
              &block
            req = {
              android_app_data_stream: android_app_data_stream,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::UpdateAndroidAppDataStreamRequest)
            @update_android_app_data_stream.call(req, options, &block)
          end

          # Creates an Android app stream with the specified location and attributes.
          #
          # Note that an Android app stream must be linked to a Firebase app to receive
          # traffic.
          #
          # To create a working app stream, make sure your property is linked to a
          # Firebase project. Then, use the Firebase API to create a Firebase app,
          # which will also create an appropriate data stream in Analytics (may take up
          # to 24 hours).
          #
          # @param android_app_data_stream [Google::Analytics::Admin::V1alpha::AndroidAppDataStream | Hash]
          #   Required. The android app stream to create.
          #   A hash of the same form as `Google::Analytics::Admin::V1alpha::AndroidAppDataStream`
          #   can also be provided.
          # @param parent [String]
          #   Required. The parent resource where this android app data stream will be created.
          #   Format: properties/123
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::AndroidAppDataStream]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::AndroidAppDataStream]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #
          #   # TODO: Initialize `android_app_data_stream`:
          #   android_app_data_stream = {}
          #   formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")
          #   response = analytics_admin_client.create_android_app_data_stream(android_app_data_stream, formatted_parent)

          def create_android_app_data_stream \
              android_app_data_stream,
              parent,
              options: nil,
              &block
            req = {
              android_app_data_stream: android_app_data_stream,
              parent: parent
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::CreateAndroidAppDataStreamRequest)
            @create_android_app_data_stream.call(req, options, &block)
          end

          # Returns child android app streams under the specified parent property.
          #
          # Android app streams will be excluded if the caller does not have access.
          # Returns an empty list if no relevant android app streams are found.
          #
          # @param parent [String]
          #   Required. The name of the parent property.
          #   For example, to limit results to app streams under the property with Id
          #   123: "properties/123"
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Analytics::Admin::V1alpha::AndroidAppDataStream>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Analytics::Admin::V1alpha::AndroidAppDataStream>]
          #   An enumerable of Google::Analytics::Admin::V1alpha::AndroidAppDataStream instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")
          #
          #   # Iterate over all results.
          #   analytics_admin_client.list_android_app_data_streams(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   analytics_admin_client.list_android_app_data_streams(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_android_app_data_streams \
              parent,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::ListAndroidAppDataStreamsRequest)
            @list_android_app_data_streams.call(req, options, &block)
          end

          # Returns the singleton enhanced measurement settings for this web stream.
          # Note that the stream must enable enhanced measurement for these settings to
          # take effect.
          #
          # @param name [String]
          #   Required. The name of the settings to lookup.
          #   Format:
          #   properties/{property_id}/webDataStreams/{stream_id}/enhancedMeasurementSettings
          #   Example: "properties/1000/webDataStreams/2000/enhancedMeasurementSettings"
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::EnhancedMeasurementSettings]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::EnhancedMeasurementSettings]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.enhanced_measurement_settings_path("[PROPERTY]", "[WEB_DATA_STREAM]")
          #   response = analytics_admin_client.get_enhanced_measurement_settings(formatted_name)

          def get_enhanced_measurement_settings \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::GetEnhancedMeasurementSettingsRequest)
            @get_enhanced_measurement_settings.call(req, options, &block)
          end

          # Updates the singleton enhanced measurement settings for this web stream.
          # Note that the stream must enable enhanced measurement for these settings to
          # take effect.
          #
          # @param enhanced_measurement_settings [Google::Analytics::Admin::V1alpha::EnhancedMeasurementSettings | Hash]
          #   Required. The settings to update.
          #   The `name` field is used to identify the settings to be updated.
          #   A hash of the same form as `Google::Analytics::Admin::V1alpha::EnhancedMeasurementSettings`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Required. The list of fields to be updated. Field names must be in snake case
          #   (e.g., "field_to_update"). Omitted fields will not be updated. To replace
          #   the entire entity, use one path with the string "*" to match all fields.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::EnhancedMeasurementSettings]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::EnhancedMeasurementSettings]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #
          #   # TODO: Initialize `enhanced_measurement_settings`:
          #   enhanced_measurement_settings = {}
          #
          #   # TODO: Initialize `update_mask`:
          #   update_mask = {}
          #   response = analytics_admin_client.update_enhanced_measurement_settings(enhanced_measurement_settings, update_mask)

          def update_enhanced_measurement_settings \
              enhanced_measurement_settings,
              update_mask,
              options: nil,
              &block
            req = {
              enhanced_measurement_settings: enhanced_measurement_settings,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::UpdateEnhancedMeasurementSettingsRequest)
            @update_enhanced_measurement_settings.call(req, options, &block)
          end

          # Creates a FirebaseLink.
          #
          # Properties can have at most one FirebaseLink.
          #
          # @param parent [String]
          #   Required. Format: properties/{property_id}
          #   Example: properties/1234
          # @param firebase_link [Google::Analytics::Admin::V1alpha::FirebaseLink | Hash]
          #   Required. The Firebase link to create.
          #   A hash of the same form as `Google::Analytics::Admin::V1alpha::FirebaseLink`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::FirebaseLink]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::FirebaseLink]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")
          #
          #   # TODO: Initialize `firebase_link`:
          #   firebase_link = {}
          #   response = analytics_admin_client.create_firebase_link(formatted_parent, firebase_link)

          def create_firebase_link \
              parent,
              firebase_link,
              options: nil,
              &block
            req = {
              parent: parent,
              firebase_link: firebase_link
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::CreateFirebaseLinkRequest)
            @create_firebase_link.call(req, options, &block)
          end

          # Updates a FirebaseLink on a property
          #
          # @param firebase_link [Google::Analytics::Admin::V1alpha::FirebaseLink | Hash]
          #   Required. The Firebase link to update.
          #   A hash of the same form as `Google::Analytics::Admin::V1alpha::FirebaseLink`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Required. The list of fields to be updated. Field names must be in snake case
          #   (e.g., "field_to_update"). Omitted fields will not be updated. To replace
          #   the entire entity, use one path with the string "*" to match all fields.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::FirebaseLink]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::FirebaseLink]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #
          #   # TODO: Initialize `firebase_link`:
          #   firebase_link = {}
          #
          #   # TODO: Initialize `update_mask`:
          #   update_mask = {}
          #   response = analytics_admin_client.update_firebase_link(firebase_link, update_mask)

          def update_firebase_link \
              firebase_link,
              update_mask,
              options: nil,
              &block
            req = {
              firebase_link: firebase_link,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::UpdateFirebaseLinkRequest)
            @update_firebase_link.call(req, options, &block)
          end

          # Deletes a FirebaseLink on a property
          #
          # @param name [String]
          #   Required. Format: properties/{property_id}/firebaseLinks/{firebase_link_id}
          #   Example: properties/1234/firebaseLinks/5678
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.firebase_link_path("[PROPERTY]", "[FIREBASE_LINK]")
          #   analytics_admin_client.delete_firebase_link(formatted_name)

          def delete_firebase_link \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::DeleteFirebaseLinkRequest)
            @delete_firebase_link.call(req, options, &block)
            nil
          end

          # Lists FirebaseLinks on a property.
          # Properties can have at most one FirebaseLink.
          #
          # @param parent [String]
          #   Required. Format: properties/{property_id}
          #   Example: properties/1234
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Analytics::Admin::V1alpha::FirebaseLink>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Analytics::Admin::V1alpha::FirebaseLink>]
          #   An enumerable of Google::Analytics::Admin::V1alpha::FirebaseLink instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")
          #
          #   # Iterate over all results.
          #   analytics_admin_client.list_firebase_links(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   analytics_admin_client.list_firebase_links(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_firebase_links \
              parent,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::ListFirebaseLinksRequest)
            @list_firebase_links.call(req, options, &block)
          end

          # Returns the Site Tag for the specified web stream.
          # Site Tags are immutable singletons.
          #
          # @param name [String]
          #   Required. The name of the site tag to lookup.
          #   Note that site tags are singletons and do not have unique IDs.
          #   Format: properties/{property_id}/webDataStreams/{stream_id}/globalSiteTag
          #   Example: "properties/123/webDataStreams/456/globalSiteTag"
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::GlobalSiteTag]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::GlobalSiteTag]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.global_site_tag_path("[PROPERTY]")
          #   response = analytics_admin_client.get_global_site_tag(formatted_name)

          def get_global_site_tag \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::GetGlobalSiteTagRequest)
            @get_global_site_tag.call(req, options, &block)
          end

          # Creates a GoogleAdsLink.
          #
          # @param parent [String]
          #   Required. Example format: properties/1234
          # @param google_ads_link [Google::Analytics::Admin::V1alpha::GoogleAdsLink | Hash]
          #   Required. The GoogleAdsLink to create.
          #   A hash of the same form as `Google::Analytics::Admin::V1alpha::GoogleAdsLink`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::GoogleAdsLink]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::GoogleAdsLink]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")
          #
          #   # TODO: Initialize `google_ads_link`:
          #   google_ads_link = {}
          #   response = analytics_admin_client.create_google_ads_link(formatted_parent, google_ads_link)

          def create_google_ads_link \
              parent,
              google_ads_link,
              options: nil,
              &block
            req = {
              parent: parent,
              google_ads_link: google_ads_link
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::CreateGoogleAdsLinkRequest)
            @create_google_ads_link.call(req, options, &block)
          end

          # Updates a GoogleAdsLink on a property
          #
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Required. The list of fields to be updated. Field names must be in snake case
          #   (e.g., "field_to_update"). Omitted fields will not be updated. To replace
          #   the entire entity, use one path with the string "*" to match all fields.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param google_ads_link [Google::Analytics::Admin::V1alpha::GoogleAdsLink | Hash]
          #   The GoogleAdsLink to update
          #   A hash of the same form as `Google::Analytics::Admin::V1alpha::GoogleAdsLink`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::GoogleAdsLink]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::GoogleAdsLink]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #
          #   # TODO: Initialize `update_mask`:
          #   update_mask = {}
          #   response = analytics_admin_client.update_google_ads_link(update_mask)

          def update_google_ads_link \
              update_mask,
              google_ads_link: nil,
              options: nil,
              &block
            req = {
              update_mask: update_mask,
              google_ads_link: google_ads_link
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::UpdateGoogleAdsLinkRequest)
            @update_google_ads_link.call(req, options, &block)
          end

          # Deletes a GoogleAdsLink on a property
          #
          # @param name [String]
          #   Required. Example format: properties/1234/googleAdsLinks/5678
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.google_ads_link_path("[PROPERTY]", "[GOOGLE_ADS_LINK]")
          #   analytics_admin_client.delete_google_ads_link(formatted_name)

          def delete_google_ads_link \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::DeleteGoogleAdsLinkRequest)
            @delete_google_ads_link.call(req, options, &block)
            nil
          end

          # Lists GoogleAdsLinks on a property.
          #
          # @param parent [String]
          #   Required. Example format: properties/1234
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Analytics::Admin::V1alpha::GoogleAdsLink>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Analytics::Admin::V1alpha::GoogleAdsLink>]
          #   An enumerable of Google::Analytics::Admin::V1alpha::GoogleAdsLink instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_parent = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.property_path("[PROPERTY]")
          #
          #   # Iterate over all results.
          #   analytics_admin_client.list_google_ads_links(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   analytics_admin_client.list_google_ads_links(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_google_ads_links \
              parent,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::ListGoogleAdsLinksRequest)
            @list_google_ads_links.call(req, options, &block)
          end

          # Get data sharing settings on an account.
          # Data sharing settings are singletons.
          #
          # @param name [String]
          #   Required. The name of the settings to lookup.
          #   Format: accounts/{account}/dataSharingSettings
          #   Example: "accounts/1000/dataSharingSettings"
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Analytics::Admin::V1alpha::DataSharingSettings]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Analytics::Admin::V1alpha::DataSharingSettings]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/analytics/admin"
          #
          #   analytics_admin_client = Google::Analytics::Admin::V1alpha.new(version: :v1alpha)
          #   formatted_name = Google::Analytics::Admin::V1alpha::AnalyticsAdminServiceClient.data_sharing_settings_path("[ACCOUNT]")
          #   response = analytics_admin_client.get_data_sharing_settings(formatted_name)

          def get_data_sharing_settings \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Analytics::Admin::V1alpha::GetDataSharingSettingsRequest)
            @get_data_sharing_settings.call(req, options, &block)
          end
        end
      end
    end
  end
end
