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
# https://github.com/googleapis/googleapis/blob/master/google/home/enterprise/sdm/v1/smart_device_management_service.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/home/enterprise/sdm/v1/smart_device_management_service_pb"
require "google/home/enterprise/sdm/v1/credentials"

module Google
  module Home
    module Enterprise
      module Sdm
        module V1
          # A service that allows API consumers to provision and manage Google
          # Home structures and devices for enterprise use cases.
          #
          # @!attribute [r] smart_device_management_service_stub
          #   @return [Google::Home::Enterprise::Sdm::V1::SmartDeviceManagementService::Stub]
          class SmartDeviceManagementServiceClient
            attr_reader :smart_device_management_service_stub

            # The default address of the service.
            SERVICE_ADDRESS = "smartdevicemanagement.googleapis.com".freeze

            # The default port of the service.
            DEFAULT_SERVICE_PORT = 443

            # The default set of gRPC interceptors.
            GRPC_INTERCEPTORS = []

            DEFAULT_TIMEOUT = 30

            PAGE_DESCRIPTORS = {
              "list_devices" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "devices"),
              "list_structures" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "structures"),
              "list_rooms" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "rooms")
            }.freeze

            private_constant :PAGE_DESCRIPTORS

            # The scopes needed to make gRPC calls to all of the methods defined in
            # this service.
            ALL_SCOPES = [
              "https://www.googleapis.com/auth/sdm.service"
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
              require "google/home/enterprise/sdm/v1/smart_device_management_service_services_pb"

              credentials ||= Google::Home::Enterprise::Sdm::V1::Credentials.default

              if credentials.is_a?(String) || credentials.is_a?(Hash)
                updater_proc = Google::Home::Enterprise::Sdm::V1::Credentials.new(credentials).updater_proc
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

              package_version = Gem.loaded_specs['google-home-enterprise-sdm'].version.version

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
                "smart_device_management_service_client_config.json"
              )
              defaults = client_config_file.open do |f|
                Google::Gax.construct_settings(
                  "google.home.enterprise.sdm.v1.SmartDeviceManagementService",
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
              @smart_device_management_service_stub = Google::Gax::Grpc.create_stub(
                service_path,
                port,
                chan_creds: chan_creds,
                channel: channel,
                updater_proc: updater_proc,
                scopes: scopes,
                interceptors: interceptors,
                &Google::Home::Enterprise::Sdm::V1::SmartDeviceManagementService::Stub.method(:new)
              )

              @get_device = Google::Gax.create_api_call(
                @smart_device_management_service_stub.method(:get_device),
                defaults["get_device"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @list_devices = Google::Gax.create_api_call(
                @smart_device_management_service_stub.method(:list_devices),
                defaults["list_devices"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @execute_device_command = Google::Gax.create_api_call(
                @smart_device_management_service_stub.method(:execute_device_command),
                defaults["execute_device_command"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @get_structure = Google::Gax.create_api_call(
                @smart_device_management_service_stub.method(:get_structure),
                defaults["get_structure"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @list_structures = Google::Gax.create_api_call(
                @smart_device_management_service_stub.method(:list_structures),
                defaults["list_structures"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @get_room = Google::Gax.create_api_call(
                @smart_device_management_service_stub.method(:get_room),
                defaults["get_room"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @list_rooms = Google::Gax.create_api_call(
                @smart_device_management_service_stub.method(:list_rooms),
                defaults["list_rooms"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
            end

            # Service calls

            # Gets a device managed by the enterprise.
            #
            # @param name [String]
            #   The name of the device requested. For example:
            #   "enterprises/XYZ/devices/123"
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Home::Enterprise::Sdm::V1::Device]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Home::Enterprise::Sdm::V1::Device]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/home/enterprise/sdm"
            #
            #   smart_device_management_client = Google::Home::Enterprise::Sdm.new(version: :v1)
            #   response = smart_device_management_client.get_device

            def get_device \
                name: nil,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Home::Enterprise::Sdm::V1::GetDeviceRequest)
              @get_device.call(req, options, &block)
            end

            # Lists devices managed by the enterprise.
            #
            # @param parent [String]
            #   The parent enterprise to list devices under. E.g. "enterprises/XYZ".
            # @param page_size [Integer]
            #   The maximum number of resources contained in the underlying API
            #   response. If page streaming is performed per-resource, this
            #   parameter does not affect the return value. If page streaming is
            #   performed per-page, this determines the maximum number of
            #   resources in a page.
            # @param filter [String]
            #   Optional filter to list devices.
            #
            #   Filters can match the exact parent (could be a structure or a room):
            #   'parent=enterprises/XYZ/structures/jkl'
            #   or filter by device custom name (substring match):
            #   'customName=wing'
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Home::Enterprise::Sdm::V1::Device>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Home::Enterprise::Sdm::V1::Device>]
            #   An enumerable of Google::Home::Enterprise::Sdm::V1::Device instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/home/enterprise/sdm"
            #
            #   smart_device_management_client = Google::Home::Enterprise::Sdm.new(version: :v1)
            #
            #   # Iterate over all results.
            #   smart_device_management_client.list_devices.each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   smart_device_management_client.list_devices.each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_devices \
                parent: nil,
                page_size: nil,
                filter: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                page_size: page_size,
                filter: filter
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Home::Enterprise::Sdm::V1::ListDevicesRequest)
              @list_devices.call(req, options, &block)
            end

            # Executes a command to device managed by the enterprise.
            #
            # @param name [String]
            #   The name of the device requested. For example:
            #   "enterprises/XYZ/devices/123"
            # @param command [String]
            #   The command name to execute, represented by the fully qualified protobuf
            #   message name.
            # @param params [Google::Protobuf::Struct | Hash]
            #   The command message to execute, represented as a Struct.
            #   A hash of the same form as `Google::Protobuf::Struct`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Home::Enterprise::Sdm::V1::ExecuteDeviceCommandResponse]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Home::Enterprise::Sdm::V1::ExecuteDeviceCommandResponse]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/home/enterprise/sdm"
            #
            #   smart_device_management_client = Google::Home::Enterprise::Sdm.new(version: :v1)
            #   response = smart_device_management_client.execute_device_command

            def execute_device_command \
                name: nil,
                command: nil,
                params: nil,
                options: nil,
                &block
              req = {
                name: name,
                command: command,
                params: params
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Home::Enterprise::Sdm::V1::ExecuteDeviceCommandRequest)
              @execute_device_command.call(req, options, &block)
            end

            # Gets a structure managed by the enterprise.
            #
            # @param name [String]
            #   The name of the structure requested. For example:
            #   "enterprises/XYZ/structures/ABC".
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Home::Enterprise::Sdm::V1::Structure]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Home::Enterprise::Sdm::V1::Structure]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/home/enterprise/sdm"
            #
            #   smart_device_management_client = Google::Home::Enterprise::Sdm.new(version: :v1)
            #   response = smart_device_management_client.get_structure

            def get_structure \
                name: nil,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Home::Enterprise::Sdm::V1::GetStructureRequest)
              @get_structure.call(req, options, &block)
            end

            # Lists structures managed by the enterprise.
            #
            # @param parent [String]
            #   The parent enterprise to list structures under. E.g. "enterprises/XYZ".
            # @param page_size [Integer]
            #   The maximum number of resources contained in the underlying API
            #   response. If page streaming is performed per-resource, this
            #   parameter does not affect the return value. If page streaming is
            #   performed per-page, this determines the maximum number of
            #   resources in a page.
            # @param filter [String]
            #   Optional filter to list structures.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Home::Enterprise::Sdm::V1::Structure>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Home::Enterprise::Sdm::V1::Structure>]
            #   An enumerable of Google::Home::Enterprise::Sdm::V1::Structure instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/home/enterprise/sdm"
            #
            #   smart_device_management_client = Google::Home::Enterprise::Sdm.new(version: :v1)
            #
            #   # Iterate over all results.
            #   smart_device_management_client.list_structures.each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   smart_device_management_client.list_structures.each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_structures \
                parent: nil,
                page_size: nil,
                filter: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                page_size: page_size,
                filter: filter
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Home::Enterprise::Sdm::V1::ListStructuresRequest)
              @list_structures.call(req, options, &block)
            end

            # Gets a room managed by the enterprise.
            #
            # @param name [String]
            #   The name of the room requested. For example:
            #   "enterprises/XYZ/structures/ABC/rooms/123".
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Home::Enterprise::Sdm::V1::Room]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Home::Enterprise::Sdm::V1::Room]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/home/enterprise/sdm"
            #
            #   smart_device_management_client = Google::Home::Enterprise::Sdm.new(version: :v1)
            #   response = smart_device_management_client.get_room

            def get_room \
                name: nil,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Home::Enterprise::Sdm::V1::GetRoomRequest)
              @get_room.call(req, options, &block)
            end

            # Lists rooms managed by the enterprise.
            #
            # @param parent [String]
            #   The parent resource name of the rooms requested. For example:
            #   "enterprises/XYZ/structures/ABC".
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
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Home::Enterprise::Sdm::V1::Room>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Home::Enterprise::Sdm::V1::Room>]
            #   An enumerable of Google::Home::Enterprise::Sdm::V1::Room instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/home/enterprise/sdm"
            #
            #   smart_device_management_client = Google::Home::Enterprise::Sdm.new(version: :v1)
            #
            #   # Iterate over all results.
            #   smart_device_management_client.list_rooms.each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   smart_device_management_client.list_rooms.each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_rooms \
                parent: nil,
                page_size: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                page_size: page_size
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Home::Enterprise::Sdm::V1::ListRoomsRequest)
              @list_rooms.call(req, options, &block)
            end
          end
        end
      end
    end
  end
end
