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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/aiplatform/v1beta1/specialist_pool_service.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"
require "google/gax/operation"
require "google/longrunning/operations_client"

require "google/cloud/aiplatform/v1beta1/specialist_pool_service_pb"
require "google/cloud/aiplatform/v1_beta1/credentials"

module Google
  module Cloud
    module Aiplatform
      module V1Beta1
        # A service for creating and managing Customer SpecialistPools.
        # When customers start Data Labeling jobs, they can reuse/create Specialist
        # Pools to bring their own Specialists to label the data.
        # Customers can add/remove Managers for the Specialist Pool on Cloud console,
        # then Managers will get email notifications to manage Specialists and tasks on
        # CrowdCompute console.
        #
        # @!attribute [r] specialist_pool_service_stub
        #   @return [Google::Cloud::Aiplatform::V1beta1::SpecialistPoolService::Stub]
        class SpecialistPoolServiceClient
          attr_reader :specialist_pool_service_stub

          # The default address of the service.
          SERVICE_ADDRESS = "aiplatform.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_specialist_pools" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "specialist_pools")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform"
          ].freeze

          class OperationsClient < Google::Longrunning::OperationsClient
            self::SERVICE_ADDRESS = SpecialistPoolServiceClient::SERVICE_ADDRESS
            self::GRPC_INTERCEPTORS = SpecialistPoolServiceClient::GRPC_INTERCEPTORS
          end

          LOCATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}"
          )

          private_constant :LOCATION_PATH_TEMPLATE

          SPECIALIST_POOL_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/specialistPools/{specialist_pool}"
          )

          private_constant :SPECIALIST_POOL_PATH_TEMPLATE

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

          # Returns a fully-qualified specialist_pool resource name string.
          # @param project [String]
          # @param location [String]
          # @param specialist_pool [String]
          # @return [String]
          def self.specialist_pool_path project, location, specialist_pool
            SPECIALIST_POOL_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"specialist_pool" => specialist_pool
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
            require "google/cloud/aiplatform/v1beta1/specialist_pool_service_services_pb"

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
              "specialist_pool_service_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.aiplatform.v1beta1.SpecialistPoolService",
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
            @specialist_pool_service_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Aiplatform::V1beta1::SpecialistPoolService::Stub.method(:new)
            )

            @create_specialist_pool = Google::Gax.create_api_call(
              @specialist_pool_service_stub.method(:create_specialist_pool),
              defaults["create_specialist_pool"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_specialist_pool = Google::Gax.create_api_call(
              @specialist_pool_service_stub.method(:get_specialist_pool),
              defaults["get_specialist_pool"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_specialist_pools = Google::Gax.create_api_call(
              @specialist_pool_service_stub.method(:list_specialist_pools),
              defaults["list_specialist_pools"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @delete_specialist_pool = Google::Gax.create_api_call(
              @specialist_pool_service_stub.method(:delete_specialist_pool),
              defaults["delete_specialist_pool"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @update_specialist_pool = Google::Gax.create_api_call(
              @specialist_pool_service_stub.method(:update_specialist_pool),
              defaults["update_specialist_pool"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'specialist_pool.name' => request.specialist_pool.name}
              end
            )
          end

          # Service calls

          # Creates a SpecialistPool.
          #
          # @param parent [String]
          #   Required. The parent Project name for the new SpecialistPool.
          #   The form is `projects/{project}/locations/{location}`.
          # @param specialist_pool [Google::Cloud::Aiplatform::V1beta1::SpecialistPool | Hash]
          #   Required. The SpecialistPool to create.
          #   A hash of the same form as `Google::Cloud::Aiplatform::V1beta1::SpecialistPool`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   specialist_pool_client = Google::Cloud::Aiplatform::V1Beta1::SpecialistPool.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1Beta1::SpecialistPoolServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # TODO: Initialize `specialist_pool`:
          #   specialist_pool = {}
          #
          #   # Register a callback during the method call.
          #   operation = specialist_pool_client.create_specialist_pool(formatted_parent, specialist_pool) do |op|
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

          def create_specialist_pool \
              parent,
              specialist_pool,
              options: nil
            req = {
              parent: parent,
              specialist_pool: specialist_pool
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::CreateSpecialistPoolRequest)
            operation = Google::Gax::Operation.new(
              @create_specialist_pool.call(req, options),
              @operations_client,
              Google::Cloud::Aiplatform::V1beta1::SpecialistPool,
              Google::Cloud::Aiplatform::V1beta1::CreateSpecialistPoolOperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Gets a SpecialistPool.
          #
          # @param name [String]
          #   Required. The name of the SpecialistPool resource.
          #   The form is
          #
          #   `projects/{project}/locations/{location}/specialistPools/{specialist_pool}`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Aiplatform::V1beta1::SpecialistPool]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Aiplatform::V1beta1::SpecialistPool]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   specialist_pool_client = Google::Cloud::Aiplatform::V1Beta1::SpecialistPool.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::SpecialistPoolServiceClient.specialist_pool_path("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]")
          #   response = specialist_pool_client.get_specialist_pool(formatted_name)

          def get_specialist_pool \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::GetSpecialistPoolRequest)
            @get_specialist_pool.call(req, options, &block)
          end

          # Lists SpecialistPools in a Location.
          #
          # @param parent [String]
          #   Required. The name of the SpecialistPool's parent resource.
          #   Format: `projects/{project}/locations/{location}`
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param read_mask [Google::Protobuf::FieldMask | Hash]
          #   Mask specifying which fields to read. FieldMask represents a set of
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1beta1::SpecialistPool>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Aiplatform::V1beta1::SpecialistPool>]
          #   An enumerable of Google::Cloud::Aiplatform::V1beta1::SpecialistPool instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   specialist_pool_client = Google::Cloud::Aiplatform::V1Beta1::SpecialistPool.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Aiplatform::V1Beta1::SpecialistPoolServiceClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # Iterate over all results.
          #   specialist_pool_client.list_specialist_pools(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   specialist_pool_client.list_specialist_pools(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_specialist_pools \
              parent,
              page_size: nil,
              read_mask: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size,
              read_mask: read_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::ListSpecialistPoolsRequest)
            @list_specialist_pools.call(req, options, &block)
          end

          # Deletes a SpecialistPool as well as all Specialists in the pool.
          #
          # @param name [String]
          #   Required. The resource name of the SpecialistPool to delete. Format:
          #   `projects/{project}/locations/{location}/specialistPools/{specialist_pool}`
          # @param force [true, false]
          #   If set to true, any specialist managers in this SpecialistPool will also be
          #   deleted. (Otherwise, the request will only work if the SpecialistPool has
          #   no specialist managers.)
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   specialist_pool_client = Google::Cloud::Aiplatform::V1Beta1::SpecialistPool.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Aiplatform::V1Beta1::SpecialistPoolServiceClient.specialist_pool_path("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]")
          #
          #   # Register a callback during the method call.
          #   operation = specialist_pool_client.delete_specialist_pool(formatted_name) do |op|
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

          def delete_specialist_pool \
              name,
              force: nil,
              options: nil
            req = {
              name: name,
              force: force
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::DeleteSpecialistPoolRequest)
            operation = Google::Gax::Operation.new(
              @delete_specialist_pool.call(req, options),
              @operations_client,
              Google::Protobuf::Empty,
              Google::Cloud::Aiplatform::V1beta1::DeleteOperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Updates a SpecialistPool.
          #
          # @param specialist_pool [Google::Cloud::Aiplatform::V1beta1::SpecialistPool | Hash]
          #   Required. The SpecialistPool which replaces the resource on the server.
          #   A hash of the same form as `Google::Cloud::Aiplatform::V1beta1::SpecialistPool`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Required. The update mask applies to the resource.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/aiplatform/v1_beta1"
          #
          #   specialist_pool_client = Google::Cloud::Aiplatform::V1Beta1::SpecialistPool.new(version: :v1beta1)
          #
          #   # TODO: Initialize `specialist_pool`:
          #   specialist_pool = {}
          #
          #   # TODO: Initialize `update_mask`:
          #   update_mask = {}
          #
          #   # Register a callback during the method call.
          #   operation = specialist_pool_client.update_specialist_pool(specialist_pool, update_mask) do |op|
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

          def update_specialist_pool \
              specialist_pool,
              update_mask,
              options: nil
            req = {
              specialist_pool: specialist_pool,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Aiplatform::V1beta1::UpdateSpecialistPoolRequest)
            operation = Google::Gax::Operation.new(
              @update_specialist_pool.call(req, options),
              @operations_client,
              Google::Cloud::Aiplatform::V1beta1::SpecialistPool,
              Google::Cloud::Aiplatform::V1beta1::UpdateSpecialistPoolOperationMetadata,
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
