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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/managedidentities/v1beta1/managed_identities_service.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"
require "google/gax/operation"
require "google/longrunning/operations_client"

require "google/cloud/managedidentities/v1beta1/managed_identities_service_pb"
require "google/cloud/managedidentities/v1beta1/credentials"

module Google
  module Cloud
    module Managedidentities
      module V1beta1
        # @!attribute [r] managed_identities_service_stub
        #   @return [Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub]
        class ManagedIdentitiesServiceClient
          attr_reader :managed_identities_service_stub

          # The default address of the service.
          SERVICE_ADDRESS = "managedidentities.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_domains" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "domains")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform"
          ].freeze

          class OperationsClient < Google::Longrunning::OperationsClient
            self::SERVICE_ADDRESS = ManagedIdentitiesServiceClient::SERVICE_ADDRESS
            self::GRPC_INTERCEPTORS = ManagedIdentitiesServiceClient::GRPC_INTERCEPTORS
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
            require "google/cloud/managedidentities/v1beta1/managed_identities_service_services_pb"

            credentials ||= Google::Cloud::Managedidentities::V1beta1::Credentials.default

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
              updater_proc = Google::Cloud::Managedidentities::V1beta1::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-cloud-managedidentities'].version.version

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
              "managed_identities_service_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.managedidentities.v1beta1.ManagedIdentitiesService",
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
            @managed_identities_service_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.method(:new)
            )

            @delete_domain = Google::Gax.create_api_call(
              @managed_identities_service_stub.method(:delete_domain),
              defaults["delete_domain"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @create_microsoft_ad_domain = Google::Gax.create_api_call(
              @managed_identities_service_stub.method(:create_microsoft_ad_domain),
              defaults["create_microsoft_ad_domain"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @reset_admin_password = Google::Gax.create_api_call(
              @managed_identities_service_stub.method(:reset_admin_password),
              defaults["reset_admin_password"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_domains = Google::Gax.create_api_call(
              @managed_identities_service_stub.method(:list_domains),
              defaults["list_domains"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_domain = Google::Gax.create_api_call(
              @managed_identities_service_stub.method(:get_domain),
              defaults["get_domain"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @update_domain = Google::Gax.create_api_call(
              @managed_identities_service_stub.method(:update_domain),
              defaults["update_domain"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'domain.name' => request.domain.name}
              end
            )
            @attach_trust = Google::Gax.create_api_call(
              @managed_identities_service_stub.method(:attach_trust),
              defaults["attach_trust"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @reconfigure_trust = Google::Gax.create_api_call(
              @managed_identities_service_stub.method(:reconfigure_trust),
              defaults["reconfigure_trust"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @detach_trust = Google::Gax.create_api_call(
              @managed_identities_service_stub.method(:detach_trust),
              defaults["detach_trust"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @validate_trust = Google::Gax.create_api_call(
              @managed_identities_service_stub.method(:validate_trust),
              defaults["validate_trust"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
          end

          # Service calls

          # Deletes a domain.
          #
          # @param name [String]
          #   The domain resource name using the form:
          #   `projects/{project_id}/locations/global/domains/{domain_name}`
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/managedidentities"
          #
          #   managed_identities_client = Google::Cloud::Managedidentities.new(version: :v1beta1)
          #
          #   # Register a callback during the method call.
          #   operation = managed_identities_client.delete_domain do |op|
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

          def delete_domain \
              name: nil,
              options: nil
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Managedidentities::V1beta1::DeleteDomainRequest)
            operation = Google::Gax::Operation.new(
              @delete_domain.call(req, options),
              @operations_client,
              Google::Protobuf::Empty,
              Google::Cloud::Managedidentities::V1beta1::OpMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Creates a Microsoft AD domain.
          #
          # @param parent [String]
          #   The resource project name and location using the form:
          #   `projects/{project_id}/locations/global`
          # @param domain_name [String]
          #   A domain name, e.g. mydomain.myorg.com, with the following restrictions:
          #   * Must contain only lowercase letters, numbers, periods and hyphens.
          #     * Must start with a letter.
          #   * Must contain between 2-64 characters.
          #     * Must end with a number or a letter.
          #   * Must not start with period.
          #     * First segement length (mydomain form example above) shouldn't exceed
          #       15 chars.
          #     * The last segment cannot be fully numeric.
          #   * Must be unique within the customer project.
          # @param domain [Google::Cloud::Managedidentities::V1beta1::Domain | Hash]
          #   A Managed Identity domain resource.
          #   A hash of the same form as `Google::Cloud::Managedidentities::V1beta1::Domain`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/managedidentities"
          #
          #   managed_identities_client = Google::Cloud::Managedidentities.new(version: :v1beta1)
          #
          #   # Register a callback during the method call.
          #   operation = managed_identities_client.create_microsoft_ad_domain do |op|
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

          def create_microsoft_ad_domain \
              parent: nil,
              domain_name: nil,
              domain: nil,
              options: nil
            req = {
              parent: parent,
              domain_name: domain_name,
              domain: domain
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Managedidentities::V1beta1::CreateMicrosoftAdDomainRequest)
            operation = Google::Gax::Operation.new(
              @create_microsoft_ad_domain.call(req, options),
              @operations_client,
              Google::Cloud::Managedidentities::V1beta1::Domain,
              Google::Cloud::Managedidentities::V1beta1::OpMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Resets a domain's administrator password.
          #
          # @param name [String]
          #   The domain resource name using the form:
          #   `projects/{project_id}/locations/global/domains/{domain_name}`
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Managedidentities::V1beta1::ResetAdminPasswordResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Managedidentities::V1beta1::ResetAdminPasswordResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/managedidentities"
          #
          #   managed_identities_client = Google::Cloud::Managedidentities.new(version: :v1beta1)
          #   response = managed_identities_client.reset_admin_password

          def reset_admin_password \
              name: nil,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Managedidentities::V1beta1::ResetAdminPasswordRequest)
            @reset_admin_password.call(req, options, &block)
          end

          # Lists domains in a project.
          #
          # @param parent [String]
          #   Required. The resource name of the domain location using the form:
          #   `projects/{project_id}/locations/global`
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param filter [String]
          #   Optional. A filter specifying constraints of a list operation.
          #   For example, `Domain.fqdn="mydomain.myorginization"`.
          # @param order_by [String]
          #   Optional. Specifies the ordering of results. See
          #   [Sorting
          #   order](https://cloud.google.com/apis/design/design_patterns#sorting_order)
          #   for more information.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Managedidentities::V1beta1::Domain>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Managedidentities::V1beta1::Domain>]
          #   An enumerable of Google::Cloud::Managedidentities::V1beta1::Domain instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/managedidentities"
          #
          #   managed_identities_client = Google::Cloud::Managedidentities.new(version: :v1beta1)
          #
          #   # Iterate over all results.
          #   managed_identities_client.list_domains.each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   managed_identities_client.list_domains.each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_domains \
              parent: nil,
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
            req = Google::Gax::to_proto(req, Google::Cloud::Managedidentities::V1beta1::ListDomainsRequest)
            @list_domains.call(req, options, &block)
          end

          # Gets information about a domain.
          #
          # @param name [String]
          #   The domain resource name using the form:
          #   `projects/{project_id}/locations/global/domains/{domain_name}`
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Managedidentities::V1beta1::Domain]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Managedidentities::V1beta1::Domain]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/managedidentities"
          #
          #   managed_identities_client = Google::Cloud::Managedidentities.new(version: :v1beta1)
          #   response = managed_identities_client.get_domain

          def get_domain \
              name: nil,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Managedidentities::V1beta1::GetDomainRequest)
            @get_domain.call(req, options, &block)
          end

          # Updates the metadata and configuration of a domain.
          #
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Mask of fields to update. At least one path must be supplied in this
          #   field. The elements of the repeated paths field may only include
          #   fields from {Google::Cloud::Managedidentities::V1beta1::Domain Domain}:
          #   * `labels`
          #     * `locations`
          #   * `authorized_networks`
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param domain [Google::Cloud::Managedidentities::V1beta1::Domain | Hash]
          #   Domain message with updated fields. Only supported fields specified in
          #   update_mask are updated.
          #   A hash of the same form as `Google::Cloud::Managedidentities::V1beta1::Domain`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/managedidentities"
          #
          #   managed_identities_client = Google::Cloud::Managedidentities.new(version: :v1beta1)
          #
          #   # Register a callback during the method call.
          #   operation = managed_identities_client.update_domain do |op|
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

          def update_domain \
              update_mask: nil,
              domain: nil,
              options: nil
            req = {
              update_mask: update_mask,
              domain: domain
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Managedidentities::V1beta1::UpdateDomainRequest)
            operation = Google::Gax::Operation.new(
              @update_domain.call(req, options),
              @operations_client,
              Google::Cloud::Managedidentities::V1beta1::Domain,
              Google::Cloud::Managedidentities::V1beta1::OpMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Adds an AD trust to a domain.
          #
          # @param name [String]
          #   The resource domain name, project name and location using the form:
          #   `projects/{project_id}/locations/global/domains/{domain_name}`
          # @param trust [Google::Cloud::Managedidentities::V1beta1::Trust | Hash]
          #   The domain trust resource.
          #   A hash of the same form as `Google::Cloud::Managedidentities::V1beta1::Trust`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/managedidentities"
          #
          #   managed_identities_client = Google::Cloud::Managedidentities.new(version: :v1beta1)
          #
          #   # Register a callback during the method call.
          #   operation = managed_identities_client.attach_trust do |op|
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

          def attach_trust \
              name: nil,
              trust: nil,
              options: nil
            req = {
              name: name,
              trust: trust
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Managedidentities::V1beta1::AttachTrustRequest)
            operation = Google::Gax::Operation.new(
              @attach_trust.call(req, options),
              @operations_client,
              Google::Cloud::Managedidentities::V1beta1::Domain,
              Google::Cloud::Managedidentities::V1beta1::OpMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Updates the DNS conditional forwarder.
          #
          # @param name [String]
          #   The resource domain name, project name and location using the form:
          #   `projects/{project_id}/locations/global/domains/{domain_name}`
          # @param target_domain_name [String]
          #   The fully-qualified target domain name which will be in trust with current
          #   domain.
          # @param target_dns_ip_addresses [Array<String>]
          #   The target DNS server IP addresses to resolve the remote domain involved
          #   in the trust.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/managedidentities"
          #
          #   managed_identities_client = Google::Cloud::Managedidentities.new(version: :v1beta1)
          #
          #   # Register a callback during the method call.
          #   operation = managed_identities_client.reconfigure_trust do |op|
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

          def reconfigure_trust \
              name: nil,
              target_domain_name: nil,
              target_dns_ip_addresses: nil,
              options: nil
            req = {
              name: name,
              target_domain_name: target_domain_name,
              target_dns_ip_addresses: target_dns_ip_addresses
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Managedidentities::V1beta1::ReconfigureTrustRequest)
            operation = Google::Gax::Operation.new(
              @reconfigure_trust.call(req, options),
              @operations_client,
              Google::Cloud::Managedidentities::V1beta1::Domain,
              Google::Cloud::Managedidentities::V1beta1::OpMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Removes an AD trust.
          #
          # @param name [String]
          #   The resource domain name, project name, and location using the form:
          #   `projects/{project_id}/locations/global/domains/{domain_name}`
          # @param trust [Google::Cloud::Managedidentities::V1beta1::Trust | Hash]
          #   The domain trust resource to removed.
          #   A hash of the same form as `Google::Cloud::Managedidentities::V1beta1::Trust`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/managedidentities"
          #
          #   managed_identities_client = Google::Cloud::Managedidentities.new(version: :v1beta1)
          #
          #   # Register a callback during the method call.
          #   operation = managed_identities_client.detach_trust do |op|
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

          def detach_trust \
              name: nil,
              trust: nil,
              options: nil
            req = {
              name: name,
              trust: trust
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Managedidentities::V1beta1::DetachTrustRequest)
            operation = Google::Gax::Operation.new(
              @detach_trust.call(req, options),
              @operations_client,
              Google::Cloud::Managedidentities::V1beta1::Domain,
              Google::Cloud::Managedidentities::V1beta1::OpMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Validates a trust state, that the target domain is reachable, and that the
          # target domain is able to accept incoming trust requests.
          #
          # @param name [String]
          #   The resource domain name, project name, and location using the form:
          #   `projects/{project_id}/locations/global/domains/{domain_name}`
          # @param trust [Google::Cloud::Managedidentities::V1beta1::Trust | Hash]
          #   The domain trust to validate trust state for.
          #   A hash of the same form as `Google::Cloud::Managedidentities::V1beta1::Trust`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/managedidentities"
          #
          #   managed_identities_client = Google::Cloud::Managedidentities.new(version: :v1beta1)
          #
          #   # Register a callback during the method call.
          #   operation = managed_identities_client.validate_trust do |op|
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

          def validate_trust \
              name: nil,
              trust: nil,
              options: nil
            req = {
              name: name,
              trust: trust
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Managedidentities::V1beta1::ValidateTrustRequest)
            operation = Google::Gax::Operation.new(
              @validate_trust.call(req, options),
              @operations_client,
              Google::Cloud::Managedidentities::V1beta1::Domain,
              Google::Cloud::Managedidentities::V1beta1::OpMetadata,
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
