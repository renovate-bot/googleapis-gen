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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/retail/v2alpha/catalog_service.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/retail/v2alpha/catalog_service_pb"
require "google/cloud/retail/v2alpha/credentials"

module Google
  module Cloud
    module Retail
      module V2alpha
        # Service for managing catalog configuration.
        #
        # @!attribute [r] catalog_service_stub
        #   @return [Google::Cloud::Retail::V2alpha::CatalogService::Stub]
        class CatalogServiceClient
          attr_reader :catalog_service_stub

          # The default address of the service.
          SERVICE_ADDRESS = "retail.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_catalogs" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "catalogs")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform"
          ].freeze


          CATALOG_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/catalogs/{catalog}"
          )

          private_constant :CATALOG_PATH_TEMPLATE

          LOCATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}"
          )

          private_constant :LOCATION_PATH_TEMPLATE

          # Returns a fully-qualified catalog resource name string.
          # @param project [String]
          # @param location [String]
          # @param catalog [String]
          # @return [String]
          def self.catalog_path project, location, catalog
            CATALOG_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"catalog" => catalog
            )
          end

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
            require "google/cloud/retail/v2alpha/catalog_service_services_pb"

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
              "catalog_service_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.retail.v2alpha.CatalogService",
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
            @catalog_service_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Retail::V2alpha::CatalogService::Stub.method(:new)
            )

            @list_catalogs = Google::Gax.create_api_call(
              @catalog_service_stub.method(:list_catalogs),
              defaults["list_catalogs"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @update_catalog = Google::Gax.create_api_call(
              @catalog_service_stub.method(:update_catalog),
              defaults["update_catalog"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'catalog.name' => request.catalog.name}
              end
            )
          end

          # Service calls

          # Lists all the {Google::Cloud::Retail::V2alpha::Catalog Catalog}s associated
          # with the project.
          #
          # @param parent [String]
          #   Required. The account resource name with an associated location.
          #
          #   If the caller does not have permission to list
          #   {Google::Cloud::Retail::V2alpha::Catalog Catalog}s under this location,
          #   regardless of whether or not this location exists, a PERMISSION_DENIED
          #   error is returned.
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Retail::V2alpha::Catalog>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Retail::V2alpha::Catalog>]
          #   An enumerable of Google::Cloud::Retail::V2alpha::Catalog instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/retail"
          #
          #   catalog_client = Google::Cloud::Retail::V2alpha::Catalog.new(version: :v2alpha)
          #   formatted_parent = Google::Cloud::Retail::V2alpha::CatalogServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # Iterate over all results.
          #   catalog_client.list_catalogs(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   catalog_client.list_catalogs(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_catalogs \
              parent,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Retail::V2alpha::ListCatalogsRequest)
            @list_catalogs.call(req, options, &block)
          end

          # Updates the {Google::Cloud::Retail::V2alpha::Catalog Catalog}s.
          #
          # @param catalog [Google::Cloud::Retail::V2alpha::Catalog | Hash]
          #   Required. The {Google::Cloud::Retail::V2alpha::Catalog Catalog} to update.
          #
          #   If the caller does not have permission to update the
          #   {Google::Cloud::Retail::V2alpha::Catalog Catalog}, regardless of whether or
          #   not it exists, a PERMISSION_DENIED error is returned.
          #
          #   If the {Google::Cloud::Retail::V2alpha::Catalog Catalog} to update does not
          #   exist, a NOT_FOUND error is returned.
          #   A hash of the same form as `Google::Cloud::Retail::V2alpha::Catalog`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Indicates which fields in the provided
          #   {Google::Cloud::Retail::V2alpha::Catalog Catalog} to update. If not set, will
          #   only update the
          #   {Google::Cloud::Retail::V2alpha::Catalog#product_level_config Catalog#product_level_config}
          #   field, which is also the only currently supported field to update.
          #
          #   If an unsupported or unknown field is provided, an INVALID_ARGUMENT error
          #   is returned.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Retail::V2alpha::Catalog]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Retail::V2alpha::Catalog]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/retail"
          #
          #   catalog_client = Google::Cloud::Retail::V2alpha::Catalog.new(version: :v2alpha)
          #
          #   # TODO: Initialize `catalog`:
          #   catalog = {}
          #   response = catalog_client.update_catalog(catalog)

          def update_catalog \
              catalog,
              update_mask: nil,
              options: nil,
              &block
            req = {
              catalog: catalog,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Retail::V2alpha::UpdateCatalogRequest)
            @update_catalog.call(req, options, &block)
          end
        end
      end
    end
  end
end
