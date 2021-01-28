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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/domains/v1beta1/domains.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"
require "google/gax/operation"
require "google/longrunning/operations_client"

require "google/cloud/domains/v1beta1/domains_pb"
require "google/cloud/domains/v1beta1/credentials"

module Google
  module Cloud
    module Domains
      module V1beta1
        # The Cloud Domains API enables management and configuration of domain names.
        #
        # @!attribute [r] domains_stub
        #   @return [Google::Cloud::Domains::V1beta1::Domains::Stub]
        class DomainsClient
          attr_reader :domains_stub

          # The default address of the service.
          SERVICE_ADDRESS = "domains.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_registrations" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "registrations")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform"
          ].freeze

          class OperationsClient < Google::Longrunning::OperationsClient
            self::SERVICE_ADDRESS = DomainsClient::SERVICE_ADDRESS
            self::GRPC_INTERCEPTORS = DomainsClient::GRPC_INTERCEPTORS
          end

          LOCATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}"
          )

          private_constant :LOCATION_PATH_TEMPLATE

          REGISTRATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/registrations/{registration}"
          )

          private_constant :REGISTRATION_PATH_TEMPLATE

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

          # Returns a fully-qualified registration resource name string.
          # @param project [String]
          # @param location [String]
          # @param registration [String]
          # @return [String]
          def self.registration_path project, location, registration
            REGISTRATION_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"registration" => registration
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
            require "google/cloud/domains/v1beta1/domains_services_pb"

            credentials ||= Google::Cloud::Domains::V1beta1::Credentials.default

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
              updater_proc = Google::Cloud::Domains::V1beta1::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-cloud-domains'].version.version

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
              "domains_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.domains.v1beta1.Domains",
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
            @domains_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Domains::V1beta1::Domains::Stub.method(:new)
            )

            @search_domains = Google::Gax.create_api_call(
              @domains_stub.method(:search_domains),
              defaults["search_domains"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'location' => request.location}
              end
            )
            @retrieve_register_parameters = Google::Gax.create_api_call(
              @domains_stub.method(:retrieve_register_parameters),
              defaults["retrieve_register_parameters"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'location' => request.location}
              end
            )
            @register_domain = Google::Gax.create_api_call(
              @domains_stub.method(:register_domain),
              defaults["register_domain"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @list_registrations = Google::Gax.create_api_call(
              @domains_stub.method(:list_registrations),
              defaults["list_registrations"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_registration = Google::Gax.create_api_call(
              @domains_stub.method(:get_registration),
              defaults["get_registration"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @update_registration = Google::Gax.create_api_call(
              @domains_stub.method(:update_registration),
              defaults["update_registration"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'registration.name' => request.registration.name}
              end
            )
            @configure_management_settings = Google::Gax.create_api_call(
              @domains_stub.method(:configure_management_settings),
              defaults["configure_management_settings"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'registration' => request.registration}
              end
            )
            @configure_dns_settings = Google::Gax.create_api_call(
              @domains_stub.method(:configure_dns_settings),
              defaults["configure_dns_settings"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'registration' => request.registration}
              end
            )
            @configure_contact_settings = Google::Gax.create_api_call(
              @domains_stub.method(:configure_contact_settings),
              defaults["configure_contact_settings"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'registration' => request.registration}
              end
            )
            @export_registration = Google::Gax.create_api_call(
              @domains_stub.method(:export_registration),
              defaults["export_registration"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @delete_registration = Google::Gax.create_api_call(
              @domains_stub.method(:delete_registration),
              defaults["delete_registration"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @retrieve_authorization_code = Google::Gax.create_api_call(
              @domains_stub.method(:retrieve_authorization_code),
              defaults["retrieve_authorization_code"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'registration' => request.registration}
              end
            )
            @reset_authorization_code = Google::Gax.create_api_call(
              @domains_stub.method(:reset_authorization_code),
              defaults["reset_authorization_code"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'registration' => request.registration}
              end
            )
          end

          # Service calls

          # Searches for available domain names similar to the provided query.
          #
          # Availability results from this method are approximate; call
          # `RetrieveRegisterParameters` on a domain before registering to confirm
          # availability.
          #
          # @param query [String]
          #   Required. String used to search for available domain names.
          # @param location [String]
          #   Required. The location. Must be in the format `projects/*/locations/*`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Domains::V1beta1::SearchDomainsResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Domains::V1beta1::SearchDomainsResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/domains"
          #
          #   domains_client = Google::Cloud::Domains.new(version: :v1beta1)
          #
          #   # TODO: Initialize `query`:
          #   query = ''
          #   formatted_location = Google::Cloud::Domains::V1beta1::DomainsClient.location_path("[PROJECT]", "[LOCATION]")
          #   response = domains_client.search_domains(query, formatted_location)

          def search_domains \
              query,
              location,
              options: nil,
              &block
            req = {
              query: query,
              location: location
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Domains::V1beta1::SearchDomainsRequest)
            @search_domains.call(req, options, &block)
          end

          # Gets parameters needed to register a new domain name, including price and
          # up-to-date availability. Use the returned values to call `RegisterDomain`.
          #
          # @param domain_name [String]
          #   Required. The domain name. Unicode domain names must be expressed in Punycode format.
          # @param location [String]
          #   Required. The location. Must be in the format `projects/*/locations/*`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Domains::V1beta1::RetrieveRegisterParametersResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Domains::V1beta1::RetrieveRegisterParametersResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/domains"
          #
          #   domains_client = Google::Cloud::Domains.new(version: :v1beta1)
          #
          #   # TODO: Initialize `domain_name`:
          #   domain_name = ''
          #   formatted_location = Google::Cloud::Domains::V1beta1::DomainsClient.location_path("[PROJECT]", "[LOCATION]")
          #   response = domains_client.retrieve_register_parameters(domain_name, formatted_location)

          def retrieve_register_parameters \
              domain_name,
              location,
              options: nil,
              &block
            req = {
              domain_name: domain_name,
              location: location
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Domains::V1beta1::RetrieveRegisterParametersRequest)
            @retrieve_register_parameters.call(req, options, &block)
          end

          # Registers a new domain name and creates a corresponding `Registration`
          # resource.
          #
          # Call `RetrieveRegisterParameters` first to check availability of the domain
          # name and determine parameters like price that are needed to build a call to
          # this method.
          #
          # A successful call creates a `Registration` resource in state
          # `REGISTRATION_PENDING`, which resolves to `ACTIVE` within 1-2
          # minutes, indicating that the domain was successfully registered. If the
          # resource ends up in state `REGISTRATION_FAILED`, it indicates that the
          # domain was not registered successfully, and you can safely delete the
          # resource and retry registration.
          #
          # @param parent [String]
          #   Required. The parent resource of the `Registration`. Must be in the
          #   format `projects/*/locations/*`.
          # @param registration [Google::Cloud::Domains::V1beta1::Registration | Hash]
          #   Required. The complete `Registration` resource to be created.
          #   A hash of the same form as `Google::Cloud::Domains::V1beta1::Registration`
          #   can also be provided.
          # @param yearly_price [Google::Type::Money | Hash]
          #   Required. Yearly price to register or renew the domain.
          #   The value that should be put here can be obtained from
          #   RetrieveRegisterParameters or SearchDomains calls.
          #   A hash of the same form as `Google::Type::Money`
          #   can also be provided.
          # @param domain_notices [Array<Google::Cloud::Domains::V1beta1::DomainNotice>]
          #   The list of domain notices that you acknowledge. Call
          #   `RetrieveRegisterParameters` to see the notices that need acknowledgement.
          # @param contact_notices [Array<Google::Cloud::Domains::V1beta1::ContactNotice>]
          #   The list of contact notices that the caller acknowledges. The notices
          #   required here depend on the values specified in
          #   `registration.contact_settings`.
          # @param validate_only [true, false]
          #   When true, only validation will be performed, without actually registering
          #   the domain. Follows:
          #   https://cloud.google.com/apis/design/design_patterns#request_validation
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/domains"
          #
          #   domains_client = Google::Cloud::Domains.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Domains::V1beta1::DomainsClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # TODO: Initialize `registration`:
          #   registration = {}
          #
          #   # TODO: Initialize `yearly_price`:
          #   yearly_price = {}
          #
          #   # Register a callback during the method call.
          #   operation = domains_client.register_domain(formatted_parent, registration, yearly_price) do |op|
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

          def register_domain \
              parent,
              registration,
              yearly_price,
              domain_notices: nil,
              contact_notices: nil,
              validate_only: nil,
              options: nil
            req = {
              parent: parent,
              registration: registration,
              yearly_price: yearly_price,
              domain_notices: domain_notices,
              contact_notices: contact_notices,
              validate_only: validate_only
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Domains::V1beta1::RegisterDomainRequest)
            operation = Google::Gax::Operation.new(
              @register_domain.call(req, options),
              @operations_client,
              Google::Cloud::Domains::V1beta1::Registration,
              Google::Cloud::Domains::V1beta1::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Lists the `Registration` resources in a project.
          #
          # @param parent [String]
          #   Required. The project and location from which to list `Registration`s, specified in
          #   the format `projects/*/locations/*`.
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param filter [String]
          #   Filter expression to restrict the `Registration`s returned.
          #
          #   The expression must specify the field name, a comparison operator, and the
          #   value that you want to use for filtering. The value must be a string, a
          #   number, a boolean, or an enum value. The comparison operator should be one
          #   of =, !=, >, <, >=, <=, or : for prefix or wildcard matches.
          #
          #   For example, to filter to a specific domain name, use an expression like
          #   `domainName="example.com"`. You can also check for the existence of a
          #   field; for example, to find domains using custom DNS settings, use an
          #   expression like `dnsSettings.customDns:*`.
          #
          #   You can also create compound filters by combining expressions with the
          #   `AND` and `OR` operators. For example, to find domains that are suspended
          #   or have specific issues flagged, use an expression like
          #   `(state=SUSPENDED) OR (issue:*)`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Domains::V1beta1::Registration>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Domains::V1beta1::Registration>]
          #   An enumerable of Google::Cloud::Domains::V1beta1::Registration instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/domains"
          #
          #   domains_client = Google::Cloud::Domains.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Domains::V1beta1::DomainsClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # Iterate over all results.
          #   domains_client.list_registrations(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   domains_client.list_registrations(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_registrations \
              parent,
              page_size: nil,
              filter: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size,
              filter: filter
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Domains::V1beta1::ListRegistrationsRequest)
            @list_registrations.call(req, options, &block)
          end

          # Gets the details of a `Registration` resource.
          #
          # @param name [String]
          #   Required. The name of the `Registration` to get, in the format
          #   `projects/*/locations/*/registrations/*`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Domains::V1beta1::Registration]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Domains::V1beta1::Registration]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/domains"
          #
          #   domains_client = Google::Cloud::Domains.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Domains::V1beta1::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")
          #   response = domains_client.get_registration(formatted_name)

          def get_registration \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Domains::V1beta1::GetRegistrationRequest)
            @get_registration.call(req, options, &block)
          end

          # Updates select fields of a `Registration` resource, notably `labels`. To
          # update other fields, use the appropriate custom update method:
          #
          # * To update management settings, see `ConfigureManagementSettings`
          # * To update DNS configuration, see `ConfigureDnsSettings`
          # * To update contact information, see `ConfigureContactSettings`
          #
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Required. The field mask describing which fields to update as a comma-separated list.
          #   For example, if only the labels are being updated, the `update_mask` would
          #   be `"labels"`.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param registration [Google::Cloud::Domains::V1beta1::Registration | Hash]
          #   Fields of the `Registration` to update.
          #   A hash of the same form as `Google::Cloud::Domains::V1beta1::Registration`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/domains"
          #
          #   domains_client = Google::Cloud::Domains.new(version: :v1beta1)
          #
          #   # TODO: Initialize `update_mask`:
          #   update_mask = {}
          #
          #   # Register a callback during the method call.
          #   operation = domains_client.update_registration(update_mask) do |op|
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

          def update_registration \
              update_mask,
              registration: nil,
              options: nil
            req = {
              update_mask: update_mask,
              registration: registration
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Domains::V1beta1::UpdateRegistrationRequest)
            operation = Google::Gax::Operation.new(
              @update_registration.call(req, options),
              @operations_client,
              Google::Cloud::Domains::V1beta1::Registration,
              Google::Cloud::Domains::V1beta1::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Updates a `Registration`'s management settings.
          #
          # @param registration [String]
          #   Required. The name of the `Registration` whose management settings are being updated,
          #   in the format `projects/*/locations/*/registrations/*`.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Required. The field mask describing which fields to update as a comma-separated list.
          #   For example, if only the transfer lock is being updated, the `update_mask`
          #   would be `"transfer_lock_state"`.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param management_settings [Google::Cloud::Domains::V1beta1::ManagementSettings | Hash]
          #   Fields of the `ManagementSettings` to update.
          #   A hash of the same form as `Google::Cloud::Domains::V1beta1::ManagementSettings`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/domains"
          #
          #   domains_client = Google::Cloud::Domains.new(version: :v1beta1)
          #   formatted_registration = Google::Cloud::Domains::V1beta1::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")
          #
          #   # TODO: Initialize `update_mask`:
          #   update_mask = {}
          #
          #   # Register a callback during the method call.
          #   operation = domains_client.configure_management_settings(formatted_registration, update_mask) do |op|
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

          def configure_management_settings \
              registration,
              update_mask,
              management_settings: nil,
              options: nil
            req = {
              registration: registration,
              update_mask: update_mask,
              management_settings: management_settings
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Domains::V1beta1::ConfigureManagementSettingsRequest)
            operation = Google::Gax::Operation.new(
              @configure_management_settings.call(req, options),
              @operations_client,
              Google::Cloud::Domains::V1beta1::Registration,
              Google::Cloud::Domains::V1beta1::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Updates a `Registration`'s DNS settings.
          #
          # @param registration [String]
          #   Required. The name of the `Registration` whose DNS settings are being updated,
          #   in the format `projects/*/locations/*/registrations/*`.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Required. The field mask describing which fields to update as a comma-separated list.
          #   For example, if only the name servers are being updated for an existing
          #   Custom DNS configuration, the `update_mask` would be
          #   `"custom_dns.name_servers"`.
          #
          #   When changing the DNS provider from one type to another, pass the new
          #   provider's field name as part of the field mask. For example, when changing
          #   from a Google Domains DNS configuration to a Custom DNS configuration, the
          #   `update_mask` would be `"custom_dns"`. //
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param dns_settings [Google::Cloud::Domains::V1beta1::DnsSettings | Hash]
          #   Fields of the `DnsSettings` to update.
          #   A hash of the same form as `Google::Cloud::Domains::V1beta1::DnsSettings`
          #   can also be provided.
          # @param validate_only [true, false]
          #   Validate the request without actually updating the DNS settings.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/domains"
          #
          #   domains_client = Google::Cloud::Domains.new(version: :v1beta1)
          #   formatted_registration = Google::Cloud::Domains::V1beta1::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")
          #
          #   # TODO: Initialize `update_mask`:
          #   update_mask = {}
          #
          #   # Register a callback during the method call.
          #   operation = domains_client.configure_dns_settings(formatted_registration, update_mask) do |op|
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

          def configure_dns_settings \
              registration,
              update_mask,
              dns_settings: nil,
              validate_only: nil,
              options: nil
            req = {
              registration: registration,
              update_mask: update_mask,
              dns_settings: dns_settings,
              validate_only: validate_only
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Domains::V1beta1::ConfigureDnsSettingsRequest)
            operation = Google::Gax::Operation.new(
              @configure_dns_settings.call(req, options),
              @operations_client,
              Google::Cloud::Domains::V1beta1::Registration,
              Google::Cloud::Domains::V1beta1::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Updates a `Registration`'s contact settings. Some changes require
          # confirmation by the domain's registrant contact .
          #
          # @param registration [String]
          #   Required. The name of the `Registration` whose contact settings are being updated,
          #   in the format `projects/*/locations/*/registrations/*`.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Required. The field mask describing which fields to update as a comma-separated list.
          #   For example, if only the registrant contact is being updated, the
          #   `update_mask` would be `"registrant_contact"`.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param contact_settings [Google::Cloud::Domains::V1beta1::ContactSettings | Hash]
          #   Fields of the `ContactSettings` to update.
          #   A hash of the same form as `Google::Cloud::Domains::V1beta1::ContactSettings`
          #   can also be provided.
          # @param contact_notices [Array<Google::Cloud::Domains::V1beta1::ContactNotice>]
          #   The list of contact notices that the caller acknowledges. The notices
          #   required here depend on the values specified in `contact_settings`.
          # @param validate_only [true, false]
          #   Validate the request without actually updating the contact settings.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/domains"
          #
          #   domains_client = Google::Cloud::Domains.new(version: :v1beta1)
          #   formatted_registration = Google::Cloud::Domains::V1beta1::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")
          #
          #   # TODO: Initialize `update_mask`:
          #   update_mask = {}
          #
          #   # Register a callback during the method call.
          #   operation = domains_client.configure_contact_settings(formatted_registration, update_mask) do |op|
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

          def configure_contact_settings \
              registration,
              update_mask,
              contact_settings: nil,
              contact_notices: nil,
              validate_only: nil,
              options: nil
            req = {
              registration: registration,
              update_mask: update_mask,
              contact_settings: contact_settings,
              contact_notices: contact_notices,
              validate_only: validate_only
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Domains::V1beta1::ConfigureContactSettingsRequest)
            operation = Google::Gax::Operation.new(
              @configure_contact_settings.call(req, options),
              @operations_client,
              Google::Cloud::Domains::V1beta1::Registration,
              Google::Cloud::Domains::V1beta1::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Exports a `Registration` that you no longer want to use with
          # Cloud Domains. You can continue to use the domain in
          # [Google Domains](https://domains.google/) until it expires.
          #
          # If the export is successful:
          #
          # * The resource's `state` becomes `EXPORTED`, meaning that it is no longer
          #   managed by Cloud Domains
          # * Because individual users can own domains in Google Domains, the calling
          #   user becomes the domain's sole owner. Permissions for the domain are
          #   subsequently managed in Google Domains.
          # * Without further action, the domain does not renew automatically.
          #   The new owner can set up billing in Google Domains to renew the domain
          #   if needed.
          #
          # @param name [String]
          #   Required. The name of the `Registration` to export,
          #   in the format `projects/*/locations/*/registrations/*`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/domains"
          #
          #   domains_client = Google::Cloud::Domains.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Domains::V1beta1::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")
          #
          #   # Register a callback during the method call.
          #   operation = domains_client.export_registration(formatted_name) do |op|
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

          def export_registration \
              name,
              options: nil
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Domains::V1beta1::ExportRegistrationRequest)
            operation = Google::Gax::Operation.new(
              @export_registration.call(req, options),
              @operations_client,
              Google::Cloud::Domains::V1beta1::Registration,
              Google::Cloud::Domains::V1beta1::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Deletes a `Registration` resource.
          #
          # This method only works on resources in one of the following states:
          #
          # * `state` is `EXPORTED` with `expire_time` in the past
          # * `state` is `REGISTRATION_FAILED`
          #
          # @param name [String]
          #   Required. The name of the `Registration` to delete,
          #   in the format `projects/*/locations/*/registrations/*`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/domains"
          #
          #   domains_client = Google::Cloud::Domains.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Domains::V1beta1::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")
          #
          #   # Register a callback during the method call.
          #   operation = domains_client.delete_registration(formatted_name) do |op|
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

          def delete_registration \
              name,
              options: nil
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Domains::V1beta1::DeleteRegistrationRequest)
            operation = Google::Gax::Operation.new(
              @delete_registration.call(req, options),
              @operations_client,
              Google::Protobuf::Empty,
              Google::Cloud::Domains::V1beta1::OperationMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Gets the authorization code of the `Registration` for the purpose of
          # transferring the domain to another registrar.
          #
          # You can call this method only after 60 days have elapsed since the initial
          # domain registration.
          #
          # @param registration [String]
          #   Required. The name of the `Registration` whose authorization code is being retrieved,
          #   in the format `projects/*/locations/*/registrations/*`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Domains::V1beta1::AuthorizationCode]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Domains::V1beta1::AuthorizationCode]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/domains"
          #
          #   domains_client = Google::Cloud::Domains.new(version: :v1beta1)
          #   formatted_registration = Google::Cloud::Domains::V1beta1::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")
          #   response = domains_client.retrieve_authorization_code(formatted_registration)

          def retrieve_authorization_code \
              registration,
              options: nil,
              &block
            req = {
              registration: registration
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Domains::V1beta1::RetrieveAuthorizationCodeRequest)
            @retrieve_authorization_code.call(req, options, &block)
          end

          # Resets the authorization code of the `Registration` to a new random string.
          #
          # You can call this method only after 60 days have elapsed since the initial
          # domain registration.
          #
          # @param registration [String]
          #   Required. The name of the `Registration` whose authorization code is being reset,
          #   in the format `projects/*/locations/*/registrations/*`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Domains::V1beta1::AuthorizationCode]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Domains::V1beta1::AuthorizationCode]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/domains"
          #
          #   domains_client = Google::Cloud::Domains.new(version: :v1beta1)
          #   formatted_registration = Google::Cloud::Domains::V1beta1::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")
          #   response = domains_client.reset_authorization_code(formatted_registration)

          def reset_authorization_code \
              registration,
              options: nil,
              &block
            req = {
              registration: registration
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Domains::V1beta1::ResetAuthorizationCodeRequest)
            @reset_authorization_code.call(req, options, &block)
          end
        end
      end
    end
  end
end
