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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/aiplatform/v1beta1/dataset_service.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"
require "google/gax/operation"
require "google/longrunning/operations_client"

require "google/cloud/aiplatform/v1beta1/dataset_service_pb"
require "google/cloud/aiplatform/v1_beta1/credentials"

module Google
  module Cloud
    module Aiplatform
      module V1Beta1
        # @!attribute [r] dataset_service_stub
        #   @return [Google::Cloud::Aiplatform::V1beta1::DatasetService::Stub]
        class DatasetServiceClient
          attr_reader :dataset_service_stub

          # The default address of the service.
          SERVICE_ADDRESS = "aiplatform.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_datasets" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "datasets"),
            "list_data_items" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "data_items"),
            "list_annotations" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "annotations")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform"
          ].freeze

          class OperationsClient < Google::Longrunning::OperationsClient
            self::SERVICE_ADDRESS = DatasetServiceClient::SERVICE_ADDRESS
            self::GRPC_INTERCEPTORS = DatasetServiceClient::GRPC_INTERCEPTORS
          end

          ANNOTATION_SPEC_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/datasets/{dataset}/annotationSpecs/{annotation_spec}"
          )

          private_constant :ANNOTATION_SPEC_PATH_TEMPLATE

          DATA_ITEM_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}"
          )

          private_constant :DATA_ITEM_PATH_TEMPLATE

          DATASET_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/datasets/{dataset}"
          )

          private_constant :DATASET_PATH_TEMPLATE

          LOCATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}"
          )

          private_constant :LOCATION_PATH_TEMPLATE

          # Returns a fully-qualified annotation_spec resource name string.
          # @param project [String]
          # @param location [String]
          # @param dataset [String]
          # @param annotation_spec [String]
          # @return [String]
          def self.annotation_spec_path project, location, dataset, annotation_spec
            ANNOTATION_SPEC_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"dataset" => dataset,
              :"annotation_spec" => annotation_spec
            )
          end

          # Returns a fully-qualified data_item resource name string.
          # @param project [String]
          # @param location [String]
          # @param dataset [String]
          # @param data_item [String]
          # @return [String]
          def self.data_item_path project, location, dataset, data_item
            DATA_ITEM_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"dataset" => dataset,
              :"data_item" => data_item
            )
          end

          # Returns a fully-qualified dataset resource name string.
          # @param project [String]
          # @param location [String]
          # @param dataset [String]
          # @return [String]
          def self.dataset_path project, location, dataset
            DATASET_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"dataset" => dataset
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
            require "google/cloud/aiplatform/v1beta1/dataset_service_services_pb"

            credentials ||= Google::Cloud::Aiplatform::V1Beta1::Credentials.default

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
              updater_proc = Google::Cloud::Aiplatform::V1Beta1::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-cloud-aiplatform'].version.version

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
              "dataset_service_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.aiplatform.v1beta1.DatasetService",
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
            @dataset_service_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Aiplatform::V1beta1::DatasetService::Stub.method(:new)
            )

            @create_dataset = Google::Gax.create_api_call(
              @dataset_service_stub.method(:create_dataset),
              defaults["create_dataset"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_dataset = Google::Gax.create_api_call(
              @dataset_service_stub.method(:get_dataset),
              defaults["get_dataset"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @update_dataset = Google::Gax.create_api_call(
              @dataset_service_stub.method(:update_dataset),
              defaults["update_dataset"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'dataset.name' => request.dataset.name}
              end
            )
            @list_datasets = Google::Gax.create_api_call(
              @dataset_service_stub.method(:list_datasets),
              defaults["list_datasets"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @delete_dataset = Google::Gax.create_api_call(
              @dataset_service_stub.method(:delete_dataset),
              defaults["delete_dataset"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @import_data = Google::Gax.create_api_call(
              @dataset_service_stub.method(:import_data),
              defaults["import_data"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @export_data = Google::Gax.create_api_call(
              @dataset_service_stub.method(:export_data),
              defaults["export_data"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_data_items = Google::Gax.create_api_call(
              @dataset_service_stub.method(:list_data_items),
              defaults["list_data_items"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_annotation_spec = Google::Gax.create_api_call(
              @dataset_service_stub.method(:get_annotation_spec),
              defaults["get_annotation_spec"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_annotations = Google::Gax.create_api_call(
              @dataset_service_stub.method(:list_annotations),
              defaults["list_annotations"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
          end

          # Service calls

          # Creates a Dataset.
          #
          # @param parent [String]
          #   Required. The resource name of the Location to create the Dataset in.
          #   Format: `projects/{project}/locations/{location}`
          # @param dataset [Google::Cloud::Aiplatform::V1beta1::Dataset | Hash]
          #   Required. The Dataset to create.
          #   A hash of the same form as `Google::Cloud::Aiplatform::V1beta1::Dataset`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   dataset_client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # TODO: Initialize `dataset`:
          #   dataset = {}
          #
          #   # Register a callback during the method call.
          #   operation = dataset_client.create_dataset(formatted_parent, dataset) do |op|
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

          def create_dataset \
              parent,
              dataset,
              options: nil
            req = {
              parent: parent,
              dataset: dataset
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::CreateDatasetRequest)
            operation = Google::Gax::Operation.new(
              @create_dataset.call(req, options),
              @operations_client,
              Google::Cloud::Aiplatform::V1beta1::Dataset,
              Google::Cloud::Aiplatform::V1beta1::CreateDatasetOperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Gets a Dataset.
          #
          # @param name [String]
          #   Required. The name of the Dataset resource.
          # @param read_mask [Google::Protobuf::FieldMask | Hash]
          #   Mask specifying which fields to read.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1beta1::Dataset]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1beta1::Dataset]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   dataset_client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.dataset_path("[PROJECT]", "[LOCATION]", "[DATASET]")
          #   response = dataset_client.get_dataset(formatted_name)

          def get_dataset \
              name,
              read_mask: nil,
              options: nil,
              &block
            req = {
              name: name,
              read_mask: read_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::GetDatasetRequest)
            @get_dataset.call(req, options, &block)
          end

          # Updates a Dataset.
          #
          # @param dataset [Google::Cloud::Aiplatform::V1beta1::Dataset | Hash]
          #   Required. The Dataset which replaces the resource on the server.
          #   A hash of the same form as `Google::Cloud::Aiplatform::V1beta1::Dataset`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Required. The update mask applies to the resource.
          #   For the `FieldMask` definition, see
          #
          #   [FieldMask](https:
          #   //tinyurl.com/dev-google-protobuf#google.protobuf.FieldMask).
          #   Updatable fields:
          #
          #   * `display_name`
          #     * `description`
          #     * `labels`
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1beta1::Dataset]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1beta1::Dataset]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   dataset_client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)
          #
          #   # TODO: Initialize `dataset`:
          #   dataset = {}
          #
          #   # TODO: Initialize `update_mask`:
          #   update_mask = {}
          #   response = dataset_client.update_dataset(dataset, update_mask)

          def update_dataset \
              dataset,
              update_mask,
              options: nil,
              &block
            req = {
              dataset: dataset,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::UpdateDatasetRequest)
            @update_dataset.call(req, options, &block)
          end

          # Lists Datasets in a Location.
          #
          # @param parent [String]
          #   Required. The name of the Dataset's parent resource.
          #   Format: `projects/{project}/locations/{location}`
          # @param filter [String]
          #   The standard list filter.
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param read_mask [Google::Protobuf::FieldMask | Hash]
          #   Mask specifying which fields to read.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param order_by [String]
          #   A comma-separated list of fields to order by, sorted in ascending order.
          #   Use "desc" after a field name for descending.
          #   Supported fields:
          #   * `display_name`
          #     * `data_item_count`   * `create_time`
          #     * `update_time`
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1beta1::Dataset>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1beta1::Dataset>]
          #   An enumerable of Google::Cloud::Aiplatform::V1beta1::Dataset instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   dataset_client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # Iterate over all results.
          #   dataset_client.list_datasets(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   dataset_client.list_datasets(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_datasets \
              parent,
              filter: nil,
              page_size: nil,
              read_mask: nil,
              order_by: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              filter: filter,
              page_size: page_size,
              read_mask: read_mask,
              order_by: order_by
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::ListDatasetsRequest)
            @list_datasets.call(req, options, &block)
          end

          # Deletes a Dataset.
          #
          # @param name [String]
          #   Required. The resource name of the Dataset to delete.
          #   Format:
          #   `projects/{project}/locations/{location}/datasets/{dataset}`
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   dataset_client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.dataset_path("[PROJECT]", "[LOCATION]", "[DATASET]")
          #
          #   # Register a callback during the method call.
          #   operation = dataset_client.delete_dataset(formatted_name) do |op|
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

          def delete_dataset \
              name,
              options: nil
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::DeleteDatasetRequest)
            operation = Google::Gax::Operation.new(
              @delete_dataset.call(req, options),
              @operations_client,
              Google::Protobuf::Empty,
              Google::Cloud::Aiplatform::V1beta1::DeleteOperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Imports data into a Dataset.
          #
          # @param name [String]
          #   Required. The name of the Dataset resource.
          #   Format:
          #   `projects/{project}/locations/{location}/datasets/{dataset}`
          # @param import_configs [Array<Google::Cloud::Aiplatform::V1beta1::ImportDataConfig | Hash>]
          #   Required. The desired input locations. The contents of all input locations will be
          #   imported in one batch.
          #   A hash of the same form as `Google::Cloud::Aiplatform::V1beta1::ImportDataConfig`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   dataset_client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.dataset_path("[PROJECT]", "[LOCATION]", "[DATASET]")
          #
          #   # TODO: Initialize `import_configs`:
          #   import_configs = []
          #
          #   # Register a callback during the method call.
          #   operation = dataset_client.import_data(formatted_name, import_configs) do |op|
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

          def import_data \
              name,
              import_configs,
              options: nil
            req = {
              name: name,
              import_configs: import_configs
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::ImportDataRequest)
            operation = Google::Gax::Operation.new(
              @import_data.call(req, options),
              @operations_client,
              Google::Cloud::Aiplatform::V1beta1::ImportDataResponse,
              Google::Cloud::Aiplatform::V1beta1::ImportDataOperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Exports data from a Dataset.
          #
          # @param name [String]
          #   Required. The name of the Dataset resource.
          #   Format:
          #   `projects/{project}/locations/{location}/datasets/{dataset}`
          # @param export_config [Google::Cloud::Aiplatform::V1beta1::ExportDataConfig | Hash]
          #   Required. The desired output location.
          #   A hash of the same form as `Google::Cloud::Aiplatform::V1beta1::ExportDataConfig`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   dataset_client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.dataset_path("[PROJECT]", "[LOCATION]", "[DATASET]")
          #
          #   # TODO: Initialize `export_config`:
          #   export_config = {}
          #
          #   # Register a callback during the method call.
          #   operation = dataset_client.export_data(formatted_name, export_config) do |op|
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

          def export_data \
              name,
              export_config,
              options: nil
            req = {
              name: name,
              export_config: export_config
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::ExportDataRequest)
            operation = Google::Gax::Operation.new(
              @export_data.call(req, options),
              @operations_client,
              Google::Cloud::Aiplatform::V1beta1::ExportDataResponse,
              Google::Cloud::Aiplatform::V1beta1::ExportDataOperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Lists DataItems in a Dataset.
          #
          # @param parent [String]
          #   Required. The resource name of the Dataset to list DataItems from.
          #   Format:
          #   `projects/{project}/locations/{location}/datasets/{dataset}`
          # @param filter [String]
          #   The standard list filter.
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param read_mask [Google::Protobuf::FieldMask | Hash]
          #   Mask specifying which fields to read.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param order_by [String]
          #   A comma-separated list of fields to order by, sorted in ascending order.
          #   Use "desc" after a field name for descending.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1beta1::DataItem>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1beta1::DataItem>]
          #   An enumerable of Google::Cloud::Aiplatform::V1beta1::DataItem instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   dataset_client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.dataset_path("[PROJECT]", "[LOCATION]", "[DATASET]")
          #
          #   # Iterate over all results.
          #   dataset_client.list_data_items(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   dataset_client.list_data_items(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_data_items \
              parent,
              filter: nil,
              page_size: nil,
              read_mask: nil,
              order_by: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              filter: filter,
              page_size: page_size,
              read_mask: read_mask,
              order_by: order_by
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::ListDataItemsRequest)
            @list_data_items.call(req, options, &block)
          end

          # Gets an AnnotationSpec.
          #
          # @param name [String]
          #   Required. The name of the AnnotationSpec resource.
          #   Format:
          #
          #   `projects/{project}/locations/{location}/datasets/{dataset}/annotationSpecs/{annotation_spec}`
          # @param read_mask [Google::Protobuf::FieldMask | Hash]
          #   Mask specifying which fields to read.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1beta1::AnnotationSpec]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1beta1::AnnotationSpec]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   dataset_client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.annotation_spec_path("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]")
          #   response = dataset_client.get_annotation_spec(formatted_name)

          def get_annotation_spec \
              name,
              read_mask: nil,
              options: nil,
              &block
            req = {
              name: name,
              read_mask: read_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::GetAnnotationSpecRequest)
            @get_annotation_spec.call(req, options, &block)
          end

          # Lists Annotations belongs to a dataitem
          #
          # @param parent [String]
          #   Required. The resource name of the DataItem to list Annotations from.
          #   Format:
          #
          #   `projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}`
          # @param filter [String]
          #   The standard list filter.
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param read_mask [Google::Protobuf::FieldMask | Hash]
          #   Mask specifying which fields to read.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param order_by [String]
          #   A comma-separated list of fields to order by, sorted in ascending order.
          #   Use "desc" after a field name for descending.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1beta1::Annotation>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1beta1::Annotation>]
          #   An enumerable of Google::Cloud::Aiplatform::V1beta1::Annotation instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   dataset_client = Google::Cloud::Aiplatform::V1Beta1::Dataset.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1Beta1::DatasetServiceClient.data_item_path("[PROJECT]", "[LOCATION]", "[DATASET]", "[DATA_ITEM]")
          #
          #   # Iterate over all results.
          #   dataset_client.list_annotations(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   dataset_client.list_annotations(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_annotations \
              parent,
              filter: nil,
              page_size: nil,
              read_mask: nil,
              order_by: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              filter: filter,
              page_size: page_size,
              read_mask: read_mask,
              order_by: order_by
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::ListAnnotationsRequest)
            @list_annotations.call(req, options, &block)
          end
        end
      end
    end
  end
end
