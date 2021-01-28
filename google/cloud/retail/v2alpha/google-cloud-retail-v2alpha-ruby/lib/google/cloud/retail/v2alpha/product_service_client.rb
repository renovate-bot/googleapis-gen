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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/retail/v2alpha/product_service.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"
require "google/gax/operation"
require "google/longrunning/operations_client"

require "google/cloud/retail/v2alpha/product_service_pb"
require "google/cloud/retail/v2alpha/credentials"

module Google
  module Cloud
    module Retail
      module V2alpha
        # Service for ingesting {Google::Cloud::Retail::V2alpha::Product Product}
        # information of the customer's website.
        #
        # @!attribute [r] product_service_stub
        #   @return [Google::Cloud::Retail::V2alpha::ProductService::Stub]
        class ProductServiceClient
          attr_reader :product_service_stub

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

          class OperationsClient < Google::Longrunning::OperationsClient
            self::SERVICE_ADDRESS = ProductServiceClient::SERVICE_ADDRESS
            self::GRPC_INTERCEPTORS = ProductServiceClient::GRPC_INTERCEPTORS
          end

          BRANCH_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/catalogs/{catalog}/branches/{branch}"
          )

          private_constant :BRANCH_PATH_TEMPLATE

          PRODUCT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/catalogs/{catalog}/branches/{branch}/products/{product}"
          )

          private_constant :PRODUCT_PATH_TEMPLATE

          # Returns a fully-qualified branch resource name string.
          # @param project [String]
          # @param location [String]
          # @param catalog [String]
          # @param branch [String]
          # @return [String]
          def self.branch_path project, location, catalog, branch
            BRANCH_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"catalog" => catalog,
              :"branch" => branch
            )
          end

          # Returns a fully-qualified product resource name string.
          # @param project [String]
          # @param location [String]
          # @param catalog [String]
          # @param branch [String]
          # @param product [String]
          # @return [String]
          def self.product_path project, location, catalog, branch, product
            PRODUCT_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"catalog" => catalog,
              :"branch" => branch,
              :"product" => product
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
            require "google/cloud/retail/v2alpha/product_service_services_pb"

            credentials ||= Google::Cloud::Retail::V2alpha::Credentials.default

            @operations_client = OperationsClient.new(
              credentials: credentials,
              scopes: scopes,
              client_config: client_config,
              timeout: timeout,
              lib_name: lib_name,
              lib_version: lib_version,
              metadata: metadata,
            )

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
              "product_service_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.retail.v2alpha.ProductService",
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
            @product_service_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Retail::V2alpha::ProductService::Stub.method(:new)
            )

            @create_product = Google::Gax.create_api_call(
              @product_service_stub.method(:create_product),
              defaults["create_product"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_product = Google::Gax.create_api_call(
              @product_service_stub.method(:get_product),
              defaults["get_product"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @update_product = Google::Gax.create_api_call(
              @product_service_stub.method(:update_product),
              defaults["update_product"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'product.name' => request.product.name}
              end
            )
            @delete_product = Google::Gax.create_api_call(
              @product_service_stub.method(:delete_product),
              defaults["delete_product"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @import_products = Google::Gax.create_api_call(
              @product_service_stub.method(:import_products),
              defaults["import_products"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
          end

          # Service calls

          # Creates a {Google::Cloud::Retail::V2alpha::Product Product}.
          #
          # @param parent [String]
          #   Required. The parent catalog resource name, such as
          #   "projects/*/locations/global/catalogs/default_catalog/branches/default_branch".
          # @param product [Google::Cloud::Retail::V2alpha::Product | Hash]
          #   Required. The {Google::Cloud::Retail::V2alpha::Product Product} to create.
          #   A hash of the same form as `Google::Cloud::Retail::V2alpha::Product`
          #   can also be provided.
          # @param product_id [String]
          #   Required. The ID to use for the
          #   {Google::Cloud::Retail::V2alpha::Product Product}, which will become the final
          #   component of the {Google::Cloud::Retail::V2alpha::Product#name Product#name}.
          #
          #   If the caller does not have permission to create the
          #   {Google::Cloud::Retail::V2alpha::Product Product}, regardless of whether or
          #   not it exists, a PERMISSION_DENIED error is returned.
          #
          #   This field must be unique among all
          #   {Google::Cloud::Retail::V2alpha::Product Product}s with the same
          #   {Google::Cloud::Retail::V2alpha::CreateProductRequest#parent parent}.
          #   Otherwise, an ALREADY_EXISTS error is returned.
          #
          #   This field must be a UTF-8 encoded string with a length limit of 128
          #   characters. Otherwise, an INVALID_ARGUMENT error is returned.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Retail::V2alpha::Product]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Retail::V2alpha::Product]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/retail"
          #
          #   product_client = Google::Cloud::Retail::V2alpha::Product.new(version: :v2alpha)
          #   formatted_parent = Google::Cloud::Retail::V2alpha::ProductServiceClient.branch_path("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]")
          #
          #   # TODO: Initialize `product`:
          #   product = {}
          #
          #   # TODO: Initialize `product_id`:
          #   product_id = ''
          #   response = product_client.create_product(formatted_parent, product, product_id)

          def create_product \
              parent,
              product,
              product_id,
              options: nil,
              &block
            req = {
              parent: parent,
              product: product,
              product_id: product_id
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Retail::V2alpha::CreateProductRequest)
            @create_product.call(req, options, &block)
          end

          # Gets a {Google::Cloud::Retail::V2alpha::Product Product}.
          #
          # @param name [String]
          #   Required. Full resource name of
          #   {Google::Cloud::Retail::V2alpha::Product Product}, such as
          #   "projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id".
          #
          #   If the caller does not have permission to access the
          #   {Google::Cloud::Retail::V2alpha::Product Product}, regardless of whether or
          #   not it exists, a PERMISSION_DENIED error is returned.
          #
          #   If the requested {Google::Cloud::Retail::V2alpha::Product Product} does not
          #   exist, a NOT_FOUND error is returned.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Retail::V2alpha::Product]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Retail::V2alpha::Product]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/retail"
          #
          #   product_client = Google::Cloud::Retail::V2alpha::Product.new(version: :v2alpha)
          #   formatted_name = Google::Cloud::Retail::V2alpha::ProductServiceClient.product_path("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]")
          #   response = product_client.get_product(formatted_name)

          def get_product \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Retail::V2alpha::GetProductRequest)
            @get_product.call(req, options, &block)
          end

          # Updates a {Google::Cloud::Retail::V2alpha::Product Product}.
          #
          # @param product [Google::Cloud::Retail::V2alpha::Product | Hash]
          #   Required. The product to update/create.
          #
          #   If the caller does not have permission to update the
          #   {Google::Cloud::Retail::V2alpha::Product Product}, regardless of whether or
          #   not it exists, a PERMISSION_DENIED error is returned.
          #
          #   If the {Google::Cloud::Retail::V2alpha::Product Product} to update does not
          #   exist, a NOT_FOUND error is returned.
          #   A hash of the same form as `Google::Cloud::Retail::V2alpha::Product`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Indicates which fields in the provided
          #   {Google::Cloud::Retail::V2alpha::Product Product} to update. The immutable and
          #   output only fields are NOT supported. If not set, all supported fields (the
          #   fields that are neither immutable nor output only) are updated.
          #
          #   If an unsupported or unknown field is provided, an INVALID_ARGUMENT error
          #   is returned.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Retail::V2alpha::Product]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Retail::V2alpha::Product]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/retail"
          #
          #   product_client = Google::Cloud::Retail::V2alpha::Product.new(version: :v2alpha)
          #
          #   # TODO: Initialize `product`:
          #   product = {}
          #   response = product_client.update_product(product)

          def update_product \
              product,
              update_mask: nil,
              options: nil,
              &block
            req = {
              product: product,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Retail::V2alpha::UpdateProductRequest)
            @update_product.call(req, options, &block)
          end

          # Deletes a {Google::Cloud::Retail::V2alpha::Product Product}.
          #
          # @param name [String]
          #   Required. Full resource name of
          #   {Google::Cloud::Retail::V2alpha::Product Product}, such as
          #   "projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id".
          #
          #   If the caller does not have permission to delete the
          #   {Google::Cloud::Retail::V2alpha::Product Product}, regardless of whether or
          #   not it exists, a PERMISSION_DENIED error is returned.
          #
          #   If the {Google::Cloud::Retail::V2alpha::Product Product} to delete does not
          #   exist, a NOT_FOUND error is returned.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/retail"
          #
          #   product_client = Google::Cloud::Retail::V2alpha::Product.new(version: :v2alpha)
          #   formatted_name = Google::Cloud::Retail::V2alpha::ProductServiceClient.product_path("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]")
          #   product_client.delete_product(formatted_name)

          def delete_product \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Retail::V2alpha::DeleteProductRequest)
            @delete_product.call(req, options, &block)
            nil
          end

          # Bulk import of multiple {Google::Cloud::Retail::V2alpha::Product Product}s.
          #
          # Request processing may be synchronous. No partial updating is supported.
          # Non-existing items are created.
          #
          # Note that it is possible for a subset of the
          # {Google::Cloud::Retail::V2alpha::Product Product}s to be successfully updated.
          #
          # @param parent [String]
          #   Required.
          #   "projects/1234/locations/global/catalogs/default_catalog/branches/default_branch"
          #
          #   If no updateMask is specified, requires products.create permission.
          #   If updateMask is specified, requires products.update permission.
          # @param input_config [Google::Cloud::Retail::V2alpha::ProductInputConfig | Hash]
          #   Required. The desired input location of the data.
          #   A hash of the same form as `Google::Cloud::Retail::V2alpha::ProductInputConfig`
          #   can also be provided.
          # @param errors_config [Google::Cloud::Retail::V2alpha::ImportErrorsConfig | Hash]
          #   The desired location of errors incurred during the Import.
          #   A hash of the same form as `Google::Cloud::Retail::V2alpha::ImportErrorsConfig`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Indicates which fields in the provided imported 'products' to update. If
          #   not set, will by default update all fields.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/retail"
          #
          #   product_client = Google::Cloud::Retail::V2alpha::Product.new(version: :v2alpha)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #
          #   # TODO: Initialize `input_config`:
          #   input_config = {}
          #
          #   # Register a callback during the method call.
          #   operation = product_client.import_products(parent, input_config) do |op|
          #     raise op.results.message if op.error?
          #     op_results = op.results
          #     # Process the results.
          #
          #     metadata = op.metadata
          #     # Process the metadata.
          #   end
          #
          #   # Or use the return value to register a callback.
          #   operation.on_done do |op|
          #     raise op.results.message if op.error?
          #     op_results = op.results
          #     # Process the results.
          #
          #     metadata = op.metadata
          #     # Process the metadata.
          #   end
          #
          #   # Manually reload the operation.
          #   operation.reload!
          #
          #   # Or block until the operation completes, triggering callbacks on
          #   # completion.
          #   operation.wait_until_done!

          def import_products \
              parent,
              input_config,
              errors_config: nil,
              update_mask: nil,
              options: nil
            req = {
              parent: parent,
              input_config: input_config,
              errors_config: errors_config,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Retail::V2alpha::ImportProductsRequest)
            operation = Google::Gax::Operation.new(
              @import_products.call(req, options),
              @operations_client,
              Google::Cloud::Retail::V2alpha::ImportProductsResponse,
              Google::Cloud::Retail::V2alpha::ImportMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end
        end
      end
    end
  end
end
