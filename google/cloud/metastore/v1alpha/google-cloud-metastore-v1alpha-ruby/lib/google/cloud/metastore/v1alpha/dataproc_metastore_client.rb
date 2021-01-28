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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/metastore/v1alpha/metastore.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"
require "google/gax/operation"
require "google/longrunning/operations_client"

require "google/cloud/metastore/v1alpha/metastore_pb"
require "google/cloud/metastore/v1alpha/credentials"

module Google
  module Cloud
    module Metastore
      module V1alpha
        # Configures and manages metastore services.
        # Metastore services are fully managed, highly available, auto-scaled,
        # auto-healing, OSS-native deployments of technical metadata management
        # software. Each metastore service exposes a network endpoint through which
        # metadata queries are served. Metadata queries can originate from a variety
        # of sources, including Apache Hive, Apache Presto, and Apache Spark.
        #
        # The Dataproc Metastore API defines the following resource model:
        #
        # * The service works with a collection of Google Cloud projects, named:
        #   `/projects/*`
        # * Each project has a collection of available locations, named: `/locations/*`
        #   (a location must refer to a Google Cloud `region`)
        # * Each location has a collection of services, named: `/services/*`
        # * Dataproc Metastore services are resources with names of the form:
        #
        #   `/projects/{project_id}/locations/{location_id}/services/{service_id}`.
        #
        # @!attribute [r] dataproc_metastore_stub
        #   @return [Google::Cloud::Metastore::V1alpha::DataprocMetastore::Stub]
        class DataprocMetastoreClient
          attr_reader :dataproc_metastore_stub

          # The default address of the service.
          SERVICE_ADDRESS = "metastore.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_services" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "services"),
            "list_metadata_imports" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "metadata_imports")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform"
          ].freeze

          class OperationsClient < Google::Longrunning::OperationsClient
            self::SERVICE_ADDRESS = DataprocMetastoreClient::SERVICE_ADDRESS
            self::GRPC_INTERCEPTORS = DataprocMetastoreClient::GRPC_INTERCEPTORS
          end

          LOCATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}"
          )

          private_constant :LOCATION_PATH_TEMPLATE

          METADATA_IMPORT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/services/{service}/metadataImports/{metadata_import}"
          )

          private_constant :METADATA_IMPORT_PATH_TEMPLATE

          NETWORK_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/global/networks/{network}"
          )

          private_constant :NETWORK_PATH_TEMPLATE

          SERVICE_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/services/{service}"
          )

          private_constant :SERVICE_PATH_TEMPLATE

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

          # Returns a fully-qualified metadata_import resource name string.
          # @param project [String]
          # @param location [String]
          # @param service [String]
          # @param metadata_import [String]
          # @return [String]
          def self.metadata_import_path project, location, service, metadata_import
            METADATA_IMPORT_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"service" => service,
              :"metadata_import" => metadata_import
            )
          end

          # Returns a fully-qualified network resource name string.
          # @param project [String]
          # @param network [String]
          # @return [String]
          def self.network_path project, network
            NETWORK_PATH_TEMPLATE.render(
              :"project" => project,
              :"network" => network
            )
          end

          # Returns a fully-qualified service resource name string.
          # @param project [String]
          # @param location [String]
          # @param service [String]
          # @return [String]
          def self.service_path project, location, service
            SERVICE_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"service" => service
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
            require "google/cloud/metastore/v1alpha/metastore_services_pb"

            credentials ||= Google::Cloud::Metastore::V1alpha::Credentials.default

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
              updater_proc = Google::Cloud::Metastore::V1alpha::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-cloud-metastore'].version.version

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
              "dataproc_metastore_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.metastore.v1alpha.DataprocMetastore",
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
            @dataproc_metastore_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Metastore::V1alpha::DataprocMetastore::Stub.method(:new)
            )

            @list_services = Google::Gax.create_api_call(
              @dataproc_metastore_stub.method(:list_services),
              defaults["list_services"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_service = Google::Gax.create_api_call(
              @dataproc_metastore_stub.method(:get_service),
              defaults["get_service"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @create_service = Google::Gax.create_api_call(
              @dataproc_metastore_stub.method(:create_service),
              defaults["create_service"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @update_service = Google::Gax.create_api_call(
              @dataproc_metastore_stub.method(:update_service),
              defaults["update_service"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'service.name' => request.service.name}
              end
            )
            @delete_service = Google::Gax.create_api_call(
              @dataproc_metastore_stub.method(:delete_service),
              defaults["delete_service"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_metadata_imports = Google::Gax.create_api_call(
              @dataproc_metastore_stub.method(:list_metadata_imports),
              defaults["list_metadata_imports"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_metadata_import = Google::Gax.create_api_call(
              @dataproc_metastore_stub.method(:get_metadata_import),
              defaults["get_metadata_import"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @create_metadata_import = Google::Gax.create_api_call(
              @dataproc_metastore_stub.method(:create_metadata_import),
              defaults["create_metadata_import"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @update_metadata_import = Google::Gax.create_api_call(
              @dataproc_metastore_stub.method(:update_metadata_import),
              defaults["update_metadata_import"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'metadata_import.name' => request.metadata_import.name}
              end
            )
          end

          # Service calls

          # Lists services in a project and location.
          #
          # @param parent [String]
          #   Required. The relative resource name of the location of metastore services to
          #   list, in the following form:
          #
          #   "projects/{project_id}/locations/{location_id}".
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param filter [String]
          #   Optional. The filter to apply to list results.
          # @param order_by [String]
          #   Optional. Specify the ordering of results as described in
          #   [Sorting Order](https://cloud.google.com/apis/design/design_patterns#sorting_order). If not
          #   specified, the results will be sorted in the default order.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Metastore::V1alpha::Service>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Metastore::V1alpha::Service>]
          #   An enumerable of Google::Cloud::Metastore::V1alpha::Service instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/metastore"
          #
          #   dataproc_metastore_client = Google::Cloud::Metastore::V1alpha.new(version: :v1alpha)
          #   formatted_parent = Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # Iterate over all results.
          #   dataproc_metastore_client.list_services(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   dataproc_metastore_client.list_services(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_services \
              parent,
              page_size: nil,
              filter: nil,
              order_by: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size,
              filter: filter,
              order_by: order_by
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Metastore::V1alpha::ListServicesRequest)
            @list_services.call(req, options, &block)
          end

          # Gets the details of a single service.
          #
          # @param name [String]
          #   Required. The relative resource name of the metastore service to retrieve, in the
          #   following form:
          #
          #   "projects/{project_id}/locations/{location_id}/services/{service_id}".
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Metastore::V1alpha::Service]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Metastore::V1alpha::Service]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/metastore"
          #
          #   dataproc_metastore_client = Google::Cloud::Metastore::V1alpha.new(version: :v1alpha)
          #   formatted_name = Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient.service_path("[PROJECT]", "[LOCATION]", "[SERVICE]")
          #   response = dataproc_metastore_client.get_service(formatted_name)

          def get_service \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Metastore::V1alpha::GetServiceRequest)
            @get_service.call(req, options, &block)
          end

          # Creates a metastore service in a project and location.
          #
          # @param parent [String]
          #   Required. The relative resource name of the location in which to create a metastore
          #   service, in the following form:
          #
          #   "projects/{project_id}/locations/{location_id}".
          # @param service_id [String]
          #   Required. The ID of the metastore service, which is used as the final
          #   component of the metastore service's name.
          #
          #   This value must be between 1 and 64 characters long, begin with a
          #   letter, end with a letter or number, and consist of alpha-numeric
          #   ASCII characters or hyphens.
          # @param service [Google::Cloud::Metastore::V1alpha::Service | Hash]
          #   Required. The Metastore service to create. The `name` field is
          #   ignored. The ID of the created metastore service must be provided in
          #   the request's `service_id` field.
          #   A hash of the same form as `Google::Cloud::Metastore::V1alpha::Service`
          #   can also be provided.
          # @param request_id [String]
          #   Optional. A request ID. Specify a unique request ID to allow the server to ignore the
          #   request if it has completed. The server will ignore subsequent requests
          #   that provide a duplicate request ID for at least 60 minutes after the first
          #   request.
          #
          #   For example, if an initial request times out, followed by another request
          #   with the same request ID, the server ignores the second request to prevent
          #   the creation of duplicate commitments.
          #
          #   The request ID must be a valid
          #   [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier#Format)
          #   A zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/metastore"
          #
          #   dataproc_metastore_client = Google::Cloud::Metastore::V1alpha.new(version: :v1alpha)
          #   formatted_parent = Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # TODO: Initialize `service_id`:
          #   service_id = ''
          #
          #   # TODO: Initialize `service`:
          #   service = {}
          #
          #   # Register a callback during the method call.
          #   operation = dataproc_metastore_client.create_service(formatted_parent, service_id, service) do |op|
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

          def create_service \
              parent,
              service_id,
              service,
              request_id: nil,
              options: nil
            req = {
              parent: parent,
              service_id: service_id,
              service: service,
              request_id: request_id
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Metastore::V1alpha::CreateServiceRequest)
            operation = Google::Gax::Operation.new(
              @create_service.call(req, options),
              @operations_client,
              Google::Cloud::Metastore::V1alpha::Service,
              Google::Cloud::Metastore::V1alpha::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Updates the parameters of a single service.
          #
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Required. A field mask used to specify the fields to be overwritten in the
          #   metastore service resource by the update.
          #   Fields specified in the `update_mask` are relative to the resource (not
          #   to the full request). A field is overwritten if it is in the mask.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param service [Google::Cloud::Metastore::V1alpha::Service | Hash]
          #   Required. The metastore service to update. The server only merges fields
          #   in the service if they are specified in `update_mask`.
          #
          #   The metastore service's `name` field is used to identify the metastore
          #   service to be updated.
          #   A hash of the same form as `Google::Cloud::Metastore::V1alpha::Service`
          #   can also be provided.
          # @param request_id [String]
          #   Optional. A request ID. Specify a unique request ID to allow the server to ignore the
          #   request if it has completed. The server will ignore subsequent requests
          #   that provide a duplicate request ID for at least 60 minutes after the first
          #   request.
          #
          #   For example, if an initial request times out, followed by another request
          #   with the same request ID, the server ignores the second request to prevent
          #   the creation of duplicate commitments.
          #
          #   The request ID must be a valid
          #   [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier#Format)
          #   A zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/metastore"
          #
          #   dataproc_metastore_client = Google::Cloud::Metastore::V1alpha.new(version: :v1alpha)
          #
          #   # TODO: Initialize `update_mask`:
          #   update_mask = {}
          #
          #   # TODO: Initialize `service`:
          #   service = {}
          #
          #   # Register a callback during the method call.
          #   operation = dataproc_metastore_client.update_service(update_mask, service) do |op|
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

          def update_service \
              update_mask,
              service,
              request_id: nil,
              options: nil
            req = {
              update_mask: update_mask,
              service: service,
              request_id: request_id
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Metastore::V1alpha::UpdateServiceRequest)
            operation = Google::Gax::Operation.new(
              @update_service.call(req, options),
              @operations_client,
              Google::Cloud::Metastore::V1alpha::Service,
              Google::Cloud::Metastore::V1alpha::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Deletes a single service.
          #
          # @param name [String]
          #   Required. The relative resource name of the metastore service to delete, in the
          #   following form:
          #
          #   "projects/{project_id}/locations/{location_id}/services/{service_id}".
          # @param request_id [String]
          #   Optional. A request ID. Specify a unique request ID to allow the server to ignore the
          #   request if it has completed. The server will ignore subsequent requests
          #   that provide a duplicate request ID for at least 60 minutes after the first
          #   request.
          #
          #   For example, if an initial request times out, followed by another request
          #   with the same request ID, the server ignores the second request to prevent
          #   the creation of duplicate commitments.
          #
          #   The request ID must be a valid
          #   [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier#Format)
          #   A zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/metastore"
          #
          #   dataproc_metastore_client = Google::Cloud::Metastore::V1alpha.new(version: :v1alpha)
          #   formatted_name = Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient.service_path("[PROJECT]", "[LOCATION]", "[SERVICE]")
          #
          #   # Register a callback during the method call.
          #   operation = dataproc_metastore_client.delete_service(formatted_name) do |op|
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

          def delete_service \
              name,
              request_id: nil,
              options: nil
            req = {
              name: name,
              request_id: request_id
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Metastore::V1alpha::DeleteServiceRequest)
            operation = Google::Gax::Operation.new(
              @delete_service.call(req, options),
              @operations_client,
              Google::Protobuf::Empty,
              Google::Cloud::Metastore::V1alpha::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Lists imports in a service.
          #
          # @param parent [String]
          #   Required. The relative resource name of the service whose metadata imports to
          #   list, in the following form:
          #
          #   "projects/{project_id}/locations/{location_id}/services/{service_id}/metadataImports".
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param filter [String]
          #   Optional. The filter to apply to list results.
          # @param order_by [String]
          #   Optional. Specify the ordering of results as described in
          #   [Sorting Order](https://cloud.google.com/apis/design/design_patterns#sorting_order). If not
          #   specified, the results will be sorted in the default order.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Metastore::V1alpha::MetadataImport>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Metastore::V1alpha::MetadataImport>]
          #   An enumerable of Google::Cloud::Metastore::V1alpha::MetadataImport instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/metastore"
          #
          #   dataproc_metastore_client = Google::Cloud::Metastore::V1alpha.new(version: :v1alpha)
          #   formatted_parent = Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient.service_path("[PROJECT]", "[LOCATION]", "[SERVICE]")
          #
          #   # Iterate over all results.
          #   dataproc_metastore_client.list_metadata_imports(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   dataproc_metastore_client.list_metadata_imports(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_metadata_imports \
              parent,
              page_size: nil,
              filter: nil,
              order_by: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size,
              filter: filter,
              order_by: order_by
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Metastore::V1alpha::ListMetadataImportsRequest)
            @list_metadata_imports.call(req, options, &block)
          end

          # Gets details of a single import.
          #
          # @param name [String]
          #   Required. The relative resource name of the metadata import to retrieve, in the
          #   following form:
          #
          #   "projects/{project_id}/locations/{location_id}/services/{service_id}/metadataImports/{import_id}".
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Metastore::V1alpha::MetadataImport]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Metastore::V1alpha::MetadataImport]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/metastore"
          #
          #   dataproc_metastore_client = Google::Cloud::Metastore::V1alpha.new(version: :v1alpha)
          #   formatted_name = Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient.metadata_import_path("[PROJECT]", "[LOCATION]", "[SERVICE]", "[METADATA_IMPORT]")
          #   response = dataproc_metastore_client.get_metadata_import(formatted_name)

          def get_metadata_import \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Metastore::V1alpha::GetMetadataImportRequest)
            @get_metadata_import.call(req, options, &block)
          end

          # Creates a new MetadataImport in a given project and location.
          #
          # @param parent [String]
          #   Required. The relative resource name of the service in which to create a metastore
          #   import, in the following form:
          #
          #   "projects/{project_id}/locations/{location_id}/services/{service_id}"
          # @param metadata_import_id [String]
          #   Required. The ID of the metadata import, which is used as the final component of the
          #   metadata import's name.
          #
          #   This value must be between 1 and 64 characters long, begin with a letter,
          #   end with a letter or number, and consist of alpha-numeric ASCII characters
          #   or hyphens.
          # @param metadata_import [Google::Cloud::Metastore::V1alpha::MetadataImport | Hash]
          #   Required. The metadata import to create. The `name` field is ignored. The ID of the
          #   created metadata import must be provided in the request's
          #   `metadata_import_id` field.
          #   A hash of the same form as `Google::Cloud::Metastore::V1alpha::MetadataImport`
          #   can also be provided.
          # @param request_id [String]
          #   Optional. A request ID. Specify a unique request ID to allow the server to ignore the
          #   request if it has completed. The server will ignore subsequent requests
          #   that provide a duplicate request ID for at least 60 minutes after the first
          #   request.
          #
          #   For example, if an initial request times out, followed by another request
          #   with the same request ID, the server ignores the second request to prevent
          #   the creation of duplicate commitments.
          #
          #   The request ID must be a valid
          #   [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier#Format)
          #   A zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/metastore"
          #
          #   dataproc_metastore_client = Google::Cloud::Metastore::V1alpha.new(version: :v1alpha)
          #   formatted_parent = Google::Cloud::Metastore::V1alpha::DataprocMetastoreClient.service_path("[PROJECT]", "[LOCATION]", "[SERVICE]")
          #
          #   # TODO: Initialize `metadata_import_id`:
          #   metadata_import_id = ''
          #
          #   # TODO: Initialize `metadata_import`:
          #   metadata_import = {}
          #
          #   # Register a callback during the method call.
          #   operation = dataproc_metastore_client.create_metadata_import(formatted_parent, metadata_import_id, metadata_import) do |op|
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

          def create_metadata_import \
              parent,
              metadata_import_id,
              metadata_import,
              request_id: nil,
              options: nil
            req = {
              parent: parent,
              metadata_import_id: metadata_import_id,
              metadata_import: metadata_import,
              request_id: request_id
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Metastore::V1alpha::CreateMetadataImportRequest)
            operation = Google::Gax::Operation.new(
              @create_metadata_import.call(req, options),
              @operations_client,
              Google::Cloud::Metastore::V1alpha::MetadataImport,
              Google::Cloud::Metastore::V1alpha::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Updates a single import.
          # Only the description field of MetadataImport is supported to be updated.
          #
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Required. A field mask used to specify the fields to be overwritten in the
          #   metadata import resource by the update.
          #   Fields specified in the `update_mask` are relative to the resource (not
          #   to the full request). A field is overwritten if it is in the mask.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param metadata_import [Google::Cloud::Metastore::V1alpha::MetadataImport | Hash]
          #   Required. The metadata import to update. The server only merges fields
          #   in the import if they are specified in `update_mask`.
          #
          #   The metadata import's `name` field is used to identify the metastore
          #   import to be updated.
          #   A hash of the same form as `Google::Cloud::Metastore::V1alpha::MetadataImport`
          #   can also be provided.
          # @param request_id [String]
          #   Optional. A request ID. Specify a unique request ID to allow the server to ignore the
          #   request if it has completed. The server will ignore subsequent requests
          #   that provide a duplicate request ID for at least 60 minutes after the first
          #   request.
          #
          #   For example, if an initial request times out, followed by another request
          #   with the same request ID, the server ignores the second request to prevent
          #   the creation of duplicate commitments.
          #
          #   The request ID must be a valid
          #   [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier#Format)
          #   A zero UUID (00000000-0000-0000-0000-000000000000) is not supported.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/metastore"
          #
          #   dataproc_metastore_client = Google::Cloud::Metastore::V1alpha.new(version: :v1alpha)
          #
          #   # TODO: Initialize `update_mask`:
          #   update_mask = {}
          #
          #   # TODO: Initialize `metadata_import`:
          #   metadata_import = {}
          #
          #   # Register a callback during the method call.
          #   operation = dataproc_metastore_client.update_metadata_import(update_mask, metadata_import) do |op|
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

          def update_metadata_import \
              update_mask,
              metadata_import,
              request_id: nil,
              options: nil
            req = {
              update_mask: update_mask,
              metadata_import: metadata_import,
              request_id: request_id
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Metastore::V1alpha::UpdateMetadataImportRequest)
            operation = Google::Gax::Operation.new(
              @update_metadata_import.call(req, options),
              @operations_client,
              Google::Cloud::Metastore::V1alpha::MetadataImport,
              Google::Cloud::Metastore::V1alpha::OperationMetadata,
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
