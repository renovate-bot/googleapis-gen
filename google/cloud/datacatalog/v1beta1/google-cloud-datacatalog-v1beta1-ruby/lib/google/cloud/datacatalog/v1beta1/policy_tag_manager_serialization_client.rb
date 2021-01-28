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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/datacatalog/v1beta1/policytagmanagerserialization.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/datacatalog/v1beta1/policytagmanagerserialization_pb"
require "google/cloud/datacatalog/v1beta1/credentials"

module Google
  module Cloud
    module Datacatalog
      module V1beta1
        # Policy tag manager serialization API service allows clients to manipulate
        # their taxonomies and policy tags data with serialized format.
        #
        # @!attribute [r] policy_tag_manager_serialization_stub
        #   @return [Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerSerialization::Stub]
        class PolicyTagManagerSerializationClient
          attr_reader :policy_tag_manager_serialization_stub

          # The default address of the service.
          SERVICE_ADDRESS = "datacatalog.googleapis.com".freeze

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

          TAXONOMY_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/taxonomies/{taxonomy}"
          )

          private_constant :TAXONOMY_PATH_TEMPLATE

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

          # Returns a fully-qualified taxonomy resource name string.
          # @param project [String]
          # @param location [String]
          # @param taxonomy [String]
          # @return [String]
          def self.taxonomy_path project, location, taxonomy
            TAXONOMY_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"taxonomy" => taxonomy
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
            require "google/cloud/datacatalog/v1beta1/policytagmanagerserialization_services_pb"

            credentials ||= Google::Cloud::Datacatalog::V1beta1::Credentials.default

            if credentials.is_a?(String) || credentials.is_a?(Hash)
              updater_proc = Google::Cloud::Datacatalog::V1beta1::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-cloud-datacatalog'].version.version

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
              "policy_tag_manager_serialization_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.datacatalog.v1beta1.PolicyTagManagerSerialization",
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
            @policy_tag_manager_serialization_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerSerialization::Stub.method(:new)
            )

            @import_taxonomies = Google::Gax.create_api_call(
              @policy_tag_manager_serialization_stub.method(:import_taxonomies),
              defaults["import_taxonomies"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @export_taxonomies = Google::Gax.create_api_call(
              @policy_tag_manager_serialization_stub.method(:export_taxonomies),
              defaults["export_taxonomies"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
          end

          # Service calls

          # Imports all taxonomies and their policy tags to a project as new
          # taxonomies.
          #
          # This method provides a bulk taxonomy / policy tag creation using nested
          # proto structure.
          #
          # @param parent [String]
          #   Required. Resource name of project that the newly created taxonomies will
          #   belong to.
          # @param inline_source [Google::Cloud::Datacatalog::V1beta1::InlineSource | Hash]
          #   Inline source used for taxonomies import
          #   A hash of the same form as `Google::Cloud::Datacatalog::V1beta1::InlineSource`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Datacatalog::V1beta1::ImportTaxonomiesResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Datacatalog::V1beta1::ImportTaxonomiesResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   policy_tag_manager_serialization_client = Google::Cloud::Datacatalog::PolicyTagManagerSerialization.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerSerializationClient.location_path("[PROJECT]", "[LOCATION]")
          #   response = policy_tag_manager_serialization_client.import_taxonomies(formatted_parent)

          def import_taxonomies \
              parent,
              inline_source: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              inline_source: inline_source
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::ImportTaxonomiesRequest)
            @import_taxonomies.call(req, options, &block)
          end

          # Exports all taxonomies and their policy tags in a project.
          #
          # This method generates SerializedTaxonomy protos with nested policy tags
          # that can be used as an input for future ImportTaxonomies calls.
          #
          # @param parent [String]
          #   Required. Resource name of the project that taxonomies to be exported
          #   will share.
          # @param taxonomies [Array<String>]
          #   Required. Resource names of the taxonomies to be exported.
          # @param serialized_taxonomies [true, false]
          #   Export taxonomies as serialized taxonomies.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Datacatalog::V1beta1::ExportTaxonomiesResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Datacatalog::V1beta1::ExportTaxonomiesResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   policy_tag_manager_serialization_client = Google::Cloud::Datacatalog::PolicyTagManagerSerialization.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Datacatalog::V1beta1::PolicyTagManagerSerializationClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # TODO: Initialize `formatted_taxonomies`:
          #   formatted_taxonomies = []
          #   response = policy_tag_manager_serialization_client.export_taxonomies(formatted_parent, formatted_taxonomies)

          def export_taxonomies \
              parent,
              taxonomies,
              serialized_taxonomies: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              taxonomies: taxonomies,
              serialized_taxonomies: serialized_taxonomies
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::ExportTaxonomiesRequest)
            @export_taxonomies.call(req, options, &block)
          end
        end
      end
    end
  end
end
