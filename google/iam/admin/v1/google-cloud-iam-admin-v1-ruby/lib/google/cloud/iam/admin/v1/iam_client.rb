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
# https://github.com/googleapis/googleapis/blob/master/google/iam/admin/v1/iam.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/iam/admin/v1/iam_pb"
require "google/cloud/iam/admin/v1/credentials"

module Google
  module Cloud
    module Iam
      module Admin
        module V1
          # Creates and manages service account objects.
          #
          # Service account is an account that belongs to your project instead
          # of to an individual end user. It is used to authenticate calls
          # to a Google API.
          #
          # To create a service account, specify the `project_id` and `account_id`
          # for the account.  The `account_id` is unique within the project, and used
          # to generate the service account email address and a stable
          # `unique_id`.
          #
          # All other methods can identify accounts using the format
          # `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
          # Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
          # the account. The `ACCOUNT` value can be the `email` address or the
          # `unique_id` of the service account.
          #
          # @!attribute [r] iam_stub
          #   @return [Google::Iam::Admin::V1::IAM::Stub]
          class IamClient
            attr_reader :iam_stub

            # The default address of the service.
            SERVICE_ADDRESS = "iam.googleapis.com".freeze

            # The default port of the service.
            DEFAULT_SERVICE_PORT = 443

            # The default set of gRPC interceptors.
            GRPC_INTERCEPTORS = []

            DEFAULT_TIMEOUT = 30

            PAGE_DESCRIPTORS = {
              "list_service_accounts" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "accounts"),
              "query_grantable_roles" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "roles"),
              "list_roles" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "roles"),
              "query_testable_permissions" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "permissions")
            }.freeze

            private_constant :PAGE_DESCRIPTORS

            # The scopes needed to make gRPC calls to all of the methods defined in
            # this service.
            ALL_SCOPES = [
              "https://www.googleapis.com/auth/cloud-platform"
            ].freeze


            KEY_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/serviceAccounts/{service_account}/keys/{key}"
            )

            private_constant :KEY_PATH_TEMPLATE

            PROJECT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}"
            )

            private_constant :PROJECT_PATH_TEMPLATE

            SERVICE_ACCOUNT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/serviceAccounts/{service_account}"
            )

            private_constant :SERVICE_ACCOUNT_PATH_TEMPLATE

            # Returns a fully-qualified key resource name string.
            # @param project [String]
            # @param service_account [String]
            # @param key [String]
            # @return [String]
            def self.key_path project, service_account, key
              KEY_PATH_TEMPLATE.render(
                :"project" => project,
                :"service_account" => service_account,
                :"key" => key
              )
            end

            # Returns a fully-qualified project resource name string.
            # @param project [String]
            # @return [String]
            def self.project_path project
              PROJECT_PATH_TEMPLATE.render(
                :"project" => project
              )
            end

            # Returns a fully-qualified service_account resource name string.
            # @param project [String]
            # @param service_account [String]
            # @return [String]
            def self.service_account_path project, service_account
              SERVICE_ACCOUNT_PATH_TEMPLATE.render(
                :"project" => project,
                :"service_account" => service_account
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
              require "google/iam/admin/v1/iam_services_pb"

              credentials ||= Google::Cloud::Iam::Admin::V1::Credentials.default

              if credentials.is_a?(String) || credentials.is_a?(Hash)
                updater_proc = Google::Cloud::Iam::Admin::V1::Credentials.new(credentials).updater_proc
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

              package_version = Gem.loaded_specs['google-cloud-iam-admin'].version.version

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
                "iam_client_config.json"
              )
              defaults = client_config_file.open do |f|
                Google::Gax.construct_settings(
                  "google.iam.admin.v1.IAM",
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
              @iam_stub = Google::Gax::Grpc.create_stub(
                service_path,
                port,
                chan_creds: chan_creds,
                channel: channel,
                updater_proc: updater_proc,
                scopes: scopes,
                interceptors: interceptors,
                &Google::Iam::Admin::V1::IAM::Stub.method(:new)
              )

              @list_service_accounts = Google::Gax.create_api_call(
                @iam_stub.method(:list_service_accounts),
                defaults["list_service_accounts"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @get_service_account = Google::Gax.create_api_call(
                @iam_stub.method(:get_service_account),
                defaults["get_service_account"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @create_service_account = Google::Gax.create_api_call(
                @iam_stub.method(:create_service_account),
                defaults["create_service_account"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @update_service_account = Google::Gax.create_api_call(
                @iam_stub.method(:update_service_account),
                defaults["update_service_account"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @delete_service_account = Google::Gax.create_api_call(
                @iam_stub.method(:delete_service_account),
                defaults["delete_service_account"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @list_service_account_keys = Google::Gax.create_api_call(
                @iam_stub.method(:list_service_account_keys),
                defaults["list_service_account_keys"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @get_service_account_key = Google::Gax.create_api_call(
                @iam_stub.method(:get_service_account_key),
                defaults["get_service_account_key"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @create_service_account_key = Google::Gax.create_api_call(
                @iam_stub.method(:create_service_account_key),
                defaults["create_service_account_key"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @delete_service_account_key = Google::Gax.create_api_call(
                @iam_stub.method(:delete_service_account_key),
                defaults["delete_service_account_key"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @sign_blob = Google::Gax.create_api_call(
                @iam_stub.method(:sign_blob),
                defaults["sign_blob"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @sign_jwt = Google::Gax.create_api_call(
                @iam_stub.method(:sign_jwt),
                defaults["sign_jwt"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @get_iam_policy = Google::Gax.create_api_call(
                @iam_stub.method(:get_iam_policy),
                defaults["get_iam_policy"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'resource' => request.resource}
                end
              )
              @set_iam_policy = Google::Gax.create_api_call(
                @iam_stub.method(:set_iam_policy),
                defaults["set_iam_policy"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'resource' => request.resource}
                end
              )
              @test_iam_permissions = Google::Gax.create_api_call(
                @iam_stub.method(:test_iam_permissions),
                defaults["test_iam_permissions"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'resource' => request.resource}
                end
              )
              @query_grantable_roles = Google::Gax.create_api_call(
                @iam_stub.method(:query_grantable_roles),
                defaults["query_grantable_roles"],
                exception_transformer: exception_transformer
              )
              @list_roles = Google::Gax.create_api_call(
                @iam_stub.method(:list_roles),
                defaults["list_roles"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @get_role = Google::Gax.create_api_call(
                @iam_stub.method(:get_role),
                defaults["get_role"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @create_role = Google::Gax.create_api_call(
                @iam_stub.method(:create_role),
                defaults["create_role"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @update_role = Google::Gax.create_api_call(
                @iam_stub.method(:update_role),
                defaults["update_role"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @delete_role = Google::Gax.create_api_call(
                @iam_stub.method(:delete_role),
                defaults["delete_role"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @undelete_role = Google::Gax.create_api_call(
                @iam_stub.method(:undelete_role),
                defaults["undelete_role"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @query_testable_permissions = Google::Gax.create_api_call(
                @iam_stub.method(:query_testable_permissions),
                defaults["query_testable_permissions"],
                exception_transformer: exception_transformer
              )
            end

            # Service calls

            # Lists {Google::Iam::Admin::V1::ServiceAccount ServiceAccounts} for a project.
            #
            # @param name [String]
            #   Required. The resource name of the project associated with the service
            #   accounts, such as `projects/my-project-123`.
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
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Iam::Admin::V1::ServiceAccount>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Iam::Admin::V1::ServiceAccount>]
            #   An enumerable of Google::Iam::Admin::V1::ServiceAccount instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/iam/admin"
            #
            #   iam_client = Google::Cloud::Iam::Admin.new(version: :v1)
            #   formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.project_path("[PROJECT]")
            #
            #   # Iterate over all results.
            #   iam_client.list_service_accounts(formatted_name).each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   iam_client.list_service_accounts(formatted_name).each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_service_accounts \
                name,
                page_size: nil,
                options: nil,
                &block
              req = {
                name: name,
                page_size: page_size
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::Admin::V1::ListServiceAccountsRequest)
              @list_service_accounts.call(req, options, &block)
            end

            # Gets a {Google::Iam::Admin::V1::ServiceAccount ServiceAccount}.
            #
            # @param name [String]
            #   Required. The resource name of the service account in the following format:
            #   `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
            #   Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
            #   the account. The `ACCOUNT` value can be the `email` address or the
            #   `unique_id` of the service account.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Iam::Admin::V1::ServiceAccount]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Iam::Admin::V1::ServiceAccount]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/iam/admin"
            #
            #   iam_client = Google::Cloud::Iam::Admin.new(version: :v1)
            #   formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")
            #   response = iam_client.get_service_account(formatted_name)

            def get_service_account \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::Admin::V1::GetServiceAccountRequest)
              @get_service_account.call(req, options, &block)
            end

            # Creates a {Google::Iam::Admin::V1::ServiceAccount ServiceAccount}
            # and returns it.
            #
            # @param name [String]
            #   Required. The resource name of the project associated with the service
            #   accounts, such as `projects/my-project-123`.
            # @param account_id [String]
            #   Required. The account id that is used to generate the service account
            #   email address and a stable unique id. It is unique within a project,
            #   must be 6-30 characters long, and match the regular expression
            #   `[a-z](https://cloud.google.com[-a-z0-9]*[a-z0-9])` to comply with RFC1035.
            # @param service_account [Google::Iam::Admin::V1::ServiceAccount | Hash]
            #   The {Google::Iam::Admin::V1::ServiceAccount ServiceAccount} resource to
            #   create. Currently, only the following values are user assignable:
            #   `display_name` and `description`.
            #   A hash of the same form as `Google::Iam::Admin::V1::ServiceAccount`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Iam::Admin::V1::ServiceAccount]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Iam::Admin::V1::ServiceAccount]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/iam/admin"
            #
            #   iam_client = Google::Cloud::Iam::Admin.new(version: :v1)
            #   formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.project_path("[PROJECT]")
            #
            #   # TODO: Initialize `account_id`:
            #   account_id = ''
            #   response = iam_client.create_service_account(formatted_name, account_id)

            def create_service_account \
                name,
                account_id,
                service_account: nil,
                options: nil,
                &block
              req = {
                name: name,
                account_id: account_id,
                service_account: service_account
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::Admin::V1::CreateServiceAccountRequest)
              @create_service_account.call(req, options, &block)
            end

            # Updates a {Google::Iam::Admin::V1::ServiceAccount ServiceAccount}.
            #
            # Currently, only the following fields are updatable:
            # `display_name` and `description`.
            #
            # @param name [String]
            #   The resource name of the service account in the following format:
            #   `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
            #
            #   Requests using `-` as a wildcard for the `PROJECT_ID` will infer the
            #   project from the `account` and the `ACCOUNT` value can be the `email`
            #   address or the `unique_id` of the service account.
            #
            #   In responses the resource name will always be in the format
            #   `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
            # @param project_id [String]
            #   @OutputOnly The id of the project that owns the service account.
            # @param unique_id [String]
            #   @OutputOnly The unique and stable id of the service account.
            # @param email [String]
            #   @OutputOnly The email address of the service account.
            # @param display_name [String]
            #   Optional. A user-specified name for the service account.
            #   Must be less than or equal to 100 UTF-8 bytes.
            # @param etag [String]
            #   Optional. Note: `etag` is an inoperable legacy field that is only returned
            #   for backwards compatibility.
            # @param oauth2_client_id [String]
            #   @OutputOnly. The OAuth2 client id for the service account.
            #   This is used in conjunction with the OAuth2 clientconfig API to make
            #   three legged OAuth2 (3LO) flows to access the data of Google users.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Iam::Admin::V1::ServiceAccount]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Iam::Admin::V1::ServiceAccount]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/iam/admin"
            #
            #   iam_client = Google::Cloud::Iam::Admin.new(version: :v1)
            #   response = iam_client.update_service_account

            def update_service_account \
                name: nil,
                project_id: nil,
                unique_id: nil,
                email: nil,
                display_name: nil,
                etag: nil,
                oauth2_client_id: nil,
                options: nil,
                &block
              req = {
                name: name,
                project_id: project_id,
                unique_id: unique_id,
                email: email,
                display_name: display_name,
                etag: etag,
                oauth2_client_id: oauth2_client_id
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::Admin::V1::ServiceAccount)
              @update_service_account.call(req, options, &block)
            end

            # Deletes a {Google::Iam::Admin::V1::ServiceAccount ServiceAccount}.
            #
            # @param name [String]
            #   Required. The resource name of the service account in the following format:
            #   `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
            #   Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
            #   the account. The `ACCOUNT` value can be the `email` address or the
            #   `unique_id` of the service account.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result []
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/iam/admin"
            #
            #   iam_client = Google::Cloud::Iam::Admin.new(version: :v1)
            #   formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")
            #   iam_client.delete_service_account(formatted_name)

            def delete_service_account \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::Admin::V1::DeleteServiceAccountRequest)
              @delete_service_account.call(req, options, &block)
              nil
            end

            # Lists {Google::Iam::Admin::V1::ServiceAccountKey ServiceAccountKeys}.
            #
            # @param name [String]
            #   Required. The resource name of the service account in the following format:
            #   `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
            #
            #   Using `-` as a wildcard for the `PROJECT_ID`, will infer the project from
            #   the account. The `ACCOUNT` value can be the `email` address or the
            #   `unique_id` of the service account.
            # @param key_types [Array<Google::Iam::Admin::V1::ListServiceAccountKeysRequest::KeyType>]
            #   Filters the types of keys the user wants to include in the list
            #   response. Duplicate key types are not allowed. If no key type
            #   is provided, all keys are returned.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Iam::Admin::V1::ListServiceAccountKeysResponse]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Iam::Admin::V1::ListServiceAccountKeysResponse]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/iam/admin"
            #
            #   iam_client = Google::Cloud::Iam::Admin.new(version: :v1)
            #   formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")
            #   response = iam_client.list_service_account_keys(formatted_name)

            def list_service_account_keys \
                name,
                key_types: nil,
                options: nil,
                &block
              req = {
                name: name,
                key_types: key_types
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::Admin::V1::ListServiceAccountKeysRequest)
              @list_service_account_keys.call(req, options, &block)
            end

            # Gets the {Google::Iam::Admin::V1::ServiceAccountKey ServiceAccountKey}
            # by key id.
            #
            # @param name [String]
            #   Required. The resource name of the service account key in the following format:
            #   `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
            #
            #   Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
            #   the account. The `ACCOUNT` value can be the `email` address or the
            #   `unique_id` of the service account.
            # @param public_key_type [Google::Iam::Admin::V1::ServiceAccountPublicKeyType]
            #   The output format of the public key requested.
            #   X509_PEM is the default output format.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Iam::Admin::V1::ServiceAccountKey]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Iam::Admin::V1::ServiceAccountKey]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/iam/admin"
            #
            #   iam_client = Google::Cloud::Iam::Admin.new(version: :v1)
            #   formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.key_path("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]")
            #   response = iam_client.get_service_account_key(formatted_name)

            def get_service_account_key \
                name,
                public_key_type: nil,
                options: nil,
                &block
              req = {
                name: name,
                public_key_type: public_key_type
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::Admin::V1::GetServiceAccountKeyRequest)
              @get_service_account_key.call(req, options, &block)
            end

            # Creates a {Google::Iam::Admin::V1::ServiceAccountKey ServiceAccountKey}
            # and returns it.
            #
            # @param name [String]
            #   Required. The resource name of the service account in the following format:
            #   `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
            #   Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
            #   the account. The `ACCOUNT` value can be the `email` address or the
            #   `unique_id` of the service account.
            # @param private_key_type [Google::Iam::Admin::V1::ServiceAccountPrivateKeyType]
            #   The output format of the private key. The default value is
            #   `TYPE_GOOGLE_CREDENTIALS_FILE`, which is the Google Credentials File
            #   format.
            # @param key_algorithm [Google::Iam::Admin::V1::ServiceAccountKeyAlgorithm]
            #   Which type of key and algorithm to use for the key.
            #   The default is currently a 2K RSA key.  However this may change in the
            #   future.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Iam::Admin::V1::ServiceAccountKey]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Iam::Admin::V1::ServiceAccountKey]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/iam/admin"
            #
            #   iam_client = Google::Cloud::Iam::Admin.new(version: :v1)
            #   formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")
            #   response = iam_client.create_service_account_key(formatted_name)

            def create_service_account_key \
                name,
                private_key_type: nil,
                key_algorithm: nil,
                options: nil,
                &block
              req = {
                name: name,
                private_key_type: private_key_type,
                key_algorithm: key_algorithm
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::Admin::V1::CreateServiceAccountKeyRequest)
              @create_service_account_key.call(req, options, &block)
            end

            # Deletes a {Google::Iam::Admin::V1::ServiceAccountKey ServiceAccountKey}.
            #
            # @param name [String]
            #   Required. The resource name of the service account key in the following format:
            #   `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
            #   Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
            #   the account. The `ACCOUNT` value can be the `email` address or the
            #   `unique_id` of the service account.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result []
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/iam/admin"
            #
            #   iam_client = Google::Cloud::Iam::Admin.new(version: :v1)
            #   formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.key_path("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]")
            #   iam_client.delete_service_account_key(formatted_name)

            def delete_service_account_key \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::Admin::V1::DeleteServiceAccountKeyRequest)
              @delete_service_account_key.call(req, options, &block)
              nil
            end

            # Signs a blob using a service account's system-managed private key.
            #
            # @param name [String]
            #   Required. The resource name of the service account in the following format:
            #   `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
            #   Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
            #   the account. The `ACCOUNT` value can be the `email` address or the
            #   `unique_id` of the service account.
            # @param bytes_to_sign [String]
            #   Required. The bytes to sign.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Iam::Admin::V1::SignBlobResponse]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Iam::Admin::V1::SignBlobResponse]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/iam/admin"
            #
            #   iam_client = Google::Cloud::Iam::Admin.new(version: :v1)
            #   formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")
            #
            #   # TODO: Initialize `bytes_to_sign`:
            #   bytes_to_sign = ''
            #   response = iam_client.sign_blob(formatted_name, bytes_to_sign)

            def sign_blob \
                name,
                bytes_to_sign,
                options: nil,
                &block
              req = {
                name: name,
                bytes_to_sign: bytes_to_sign
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::Admin::V1::SignBlobRequest)
              @sign_blob.call(req, options, &block)
            end

            # Signs a JWT using a service account's system-managed private key.
            #
            # If no expiry time (`exp`) is provided in the `SignJwtRequest`, IAM sets an
            # an expiry time of one hour by default. If you request an expiry time of
            # more than one hour, the request will fail.
            #
            # @param name [String]
            #   Required. The resource name of the service account in the following format:
            #   `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
            #   Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
            #   the account. The `ACCOUNT` value can be the `email` address or the
            #   `unique_id` of the service account.
            # @param payload [String]
            #   Required. The JWT payload to sign, a JSON JWT Claim set.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Iam::Admin::V1::SignJwtResponse]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Iam::Admin::V1::SignJwtResponse]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/iam/admin"
            #
            #   iam_client = Google::Cloud::Iam::Admin.new(version: :v1)
            #   formatted_name = Google::Cloud::Iam::Admin::V1::IamClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")
            #
            #   # TODO: Initialize `payload`:
            #   payload = ''
            #   response = iam_client.sign_jwt(formatted_name, payload)

            def sign_jwt \
                name,
                payload,
                options: nil,
                &block
              req = {
                name: name,
                payload: payload
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::Admin::V1::SignJwtRequest)
              @sign_jwt.call(req, options, &block)
            end

            # Returns the Cloud IAM access control policy for a
            # {Google::Iam::Admin::V1::ServiceAccount ServiceAccount}.
            #
            # Note: Service accounts are both
            # [resources and
            # identities](/iam/docs/service-accounts#service_account_permissions). This
            # method treats the service account as a resource. It returns the Cloud IAM
            # policy that reflects what members have access to the service account.
            #
            # This method does not return what resources the service account has access
            # to. To see if a service account has access to a resource, call the
            # `getIamPolicy` method on the target resource. For example, to view grants
            # for a project, call the
            # [projects.getIamPolicy](https://cloud.google.com/resource-manager/reference/rest/v1/projects/getIamPolicy)
            # method.
            #
            # @param resource [String]
            #   REQUIRED: The resource for which the policy is being requested.
            #   See the operation documentation for the appropriate value for this field.
            # @param options_ [Google::Iam::V1::GetPolicyOptions | Hash]
            #   OPTIONAL: A `GetPolicyOptions` object for specifying options to
            #   `GetIamPolicy`. This field is only used by Cloud IAM.
            #   A hash of the same form as `Google::Iam::V1::GetPolicyOptions`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Iam::V1::Policy]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Iam::V1::Policy]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/iam/admin"
            #
            #   iam_client = Google::Cloud::Iam::Admin.new(version: :v1)
            #
            #   # TODO: Initialize `resource`:
            #   resource = ''
            #   response = iam_client.get_iam_policy(resource)

            def get_iam_policy \
                resource,
                options_: nil,
                options: nil,
                &block
              req = {
                resource: resource,
                options: options_
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::V1::GetIamPolicyRequest)
              @get_iam_policy.call(req, options, &block)
            end

            # Sets the Cloud IAM access control policy for a
            # {Google::Iam::Admin::V1::ServiceAccount ServiceAccount}.
            #
            # Note: Service accounts are both
            # [resources and
            # identities](/iam/docs/service-accounts#service_account_permissions). This
            # method treats the service account as a resource. Use it to grant members
            # access to the service account, such as when they need to impersonate it.
            #
            # This method does not grant the service account access to other resources,
            # such as projects. To grant a service account access to resources, include
            # the service account in the Cloud IAM policy for the desired resource, then
            # call the appropriate `setIamPolicy` method on the target resource. For
            # example, to grant a service account access to a project, call the
            # [projects.setIamPolicy](https://cloud.google.com/resource-manager/reference/rest/v1/projects/setIamPolicy)
            # method.
            #
            # @param resource [String]
            #   REQUIRED: The resource for which the policy is being specified.
            #   See the operation documentation for the appropriate value for this field.
            # @param policy [Google::Iam::V1::Policy | Hash]
            #   REQUIRED: The complete policy to be applied to the `resource`. The size of
            #   the policy is limited to a few 10s of KB. An empty policy is a
            #   valid policy but certain Cloud Platform services (such as Projects)
            #   might reject them.
            #   A hash of the same form as `Google::Iam::V1::Policy`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Iam::V1::Policy]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Iam::V1::Policy]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/iam/admin"
            #
            #   iam_client = Google::Cloud::Iam::Admin.new(version: :v1)
            #
            #   # TODO: Initialize `resource`:
            #   resource = ''
            #
            #   # TODO: Initialize `policy`:
            #   policy = {}
            #   response = iam_client.set_iam_policy(resource, policy)

            def set_iam_policy \
                resource,
                policy,
                options: nil,
                &block
              req = {
                resource: resource,
                policy: policy
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::V1::SetIamPolicyRequest)
              @set_iam_policy.call(req, options, &block)
            end

            # Tests the specified permissions against the IAM access control policy
            # for a {Google::Iam::Admin::V1::ServiceAccount ServiceAccount}.
            #
            # @param resource [String]
            #   REQUIRED: The resource for which the policy detail is being requested.
            #   See the operation documentation for the appropriate value for this field.
            # @param permissions [Array<String>]
            #   The set of permissions to check for the `resource`. Permissions with
            #   wildcards (such as '*' or 'storage.*') are not allowed. For more
            #   information see
            #   [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Iam::V1::TestIamPermissionsResponse]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Iam::V1::TestIamPermissionsResponse]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/iam/admin"
            #
            #   iam_client = Google::Cloud::Iam::Admin.new(version: :v1)
            #
            #   # TODO: Initialize `resource`:
            #   resource = ''
            #
            #   # TODO: Initialize `permissions`:
            #   permissions = []
            #   response = iam_client.test_iam_permissions(resource, permissions)

            def test_iam_permissions \
                resource,
                permissions,
                options: nil,
                &block
              req = {
                resource: resource,
                permissions: permissions
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::V1::TestIamPermissionsRequest)
              @test_iam_permissions.call(req, options, &block)
            end

            # Queries roles that can be granted on a particular resource.
            # A role is grantable if it can be used as the role in a binding for a policy
            # for that resource.
            #
            # @param full_resource_name [String]
            #   Required. The full resource name to query from the list of grantable roles.
            #
            #   The name follows the Google Cloud Platform resource format.
            #   For example, a Cloud Platform project with id `my-project` will be named
            #   `//cloudresourcemanager.googleapis.com/projects/my-project`.
            # @param view [Google::Iam::Admin::V1::RoleView]
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
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Iam::Admin::V1::Role>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Iam::Admin::V1::Role>]
            #   An enumerable of Google::Iam::Admin::V1::Role instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/iam/admin"
            #
            #   iam_client = Google::Cloud::Iam::Admin.new(version: :v1)
            #
            #   # TODO: Initialize `full_resource_name`:
            #   full_resource_name = ''
            #
            #   # Iterate over all results.
            #   iam_client.query_grantable_roles(full_resource_name).each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   iam_client.query_grantable_roles(full_resource_name).each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def query_grantable_roles \
                full_resource_name,
                view: nil,
                page_size: nil,
                options: nil,
                &block
              req = {
                full_resource_name: full_resource_name,
                view: view,
                page_size: page_size
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::Admin::V1::QueryGrantableRolesRequest)
              @query_grantable_roles.call(req, options, &block)
            end

            # Lists the Roles defined on a resource.
            #
            # @param parent [String]
            #   The `parent` parameter's value depends on the target resource for the
            #   request, namely
            #   [`roles`](https://cloud.google.com/iam/reference/rest/v1/roles),
            #   [`projects`](https://cloud.google.com/iam/reference/rest/v1/projects.roles), or
            #   [`organizations`](https://cloud.google.com/iam/reference/rest/v1/organizations.roles). Each
            #   resource type's `parent` value format is described below:
            #
            #   * [`roles.list()`](https://cloud.google.com/iam/reference/rest/v1/roles/list): An empty string.
            #     This method doesn't require a resource; it simply returns all
            #     [predefined roles](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles) in
            #     Cloud IAM. Example request URL:
            #     `https://iam.googleapis.com/v1/roles`
            #
            #   * [`projects.roles.list()`](https://cloud.google.com/iam/reference/rest/v1/projects.roles/list):
            #     `projects/{PROJECT_ID}`. This method lists all project-level
            #     [custom roles](https://cloud.google.com/iam/docs/understanding-custom-roles).
            #     Example request URL:
            #     `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles`
            #
            #   * [`organizations.roles.list()`](https://cloud.google.com/iam/reference/rest/v1/organizations.roles/list):
            #     `organizations/{ORGANIZATION_ID}`. This method lists all
            #     organization-level [custom roles](https://cloud.google.com/iam/docs/understanding-custom-roles).
            #     Example request URL:
            #     `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles`
            #
            #   Note: Wildcard (*) values are invalid; you must specify a complete project
            #   ID or organization ID.
            # @param page_size [Integer]
            #   The maximum number of resources contained in the underlying API
            #   response. If page streaming is performed per-resource, this
            #   parameter does not affect the return value. If page streaming is
            #   performed per-page, this determines the maximum number of
            #   resources in a page.
            # @param view [Google::Iam::Admin::V1::RoleView]
            #   Optional view for the returned Role objects. When `FULL` is specified,
            #   the `includedPermissions` field is returned, which includes a list of all
            #   permissions in the role. The default value is `BASIC`, which does not
            #   return the `includedPermissions` field.
            # @param show_deleted [true, false]
            #   Include Roles that have been deleted.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Iam::Admin::V1::Role>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Iam::Admin::V1::Role>]
            #   An enumerable of Google::Iam::Admin::V1::Role instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/iam/admin"
            #
            #   iam_client = Google::Cloud::Iam::Admin.new(version: :v1)
            #
            #   # Iterate over all results.
            #   iam_client.list_roles.each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   iam_client.list_roles.each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_roles \
                parent: nil,
                page_size: nil,
                view: nil,
                show_deleted: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                page_size: page_size,
                view: view,
                show_deleted: show_deleted
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::Admin::V1::ListRolesRequest)
              @list_roles.call(req, options, &block)
            end

            # Gets a Role definition.
            #
            # @param name [String]
            #   The `name` parameter's value depends on the target resource for the
            #   request, namely
            #   [`roles`](https://cloud.google.com/iam/reference/rest/v1/roles),
            #   [`projects`](https://cloud.google.com/iam/reference/rest/v1/projects.roles), or
            #   [`organizations`](https://cloud.google.com/iam/reference/rest/v1/organizations.roles). Each
            #   resource type's `name` value format is described below:
            #
            #   * [`roles.get()`](https://cloud.google.com/iam/reference/rest/v1/roles/get): `roles/{ROLE_NAME}`.
            #     This method returns results from all
            #     [predefined roles](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles) in
            #     Cloud IAM. Example request URL:
            #     `https://iam.googleapis.com/v1/roles/{ROLE_NAME}`
            #
            #   * [`projects.roles.get()`](https://cloud.google.com/iam/reference/rest/v1/projects.roles/get):
            #     `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method returns only
            #     [custom roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been
            #     created at the project level. Example request URL:
            #     `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`
            #
            #   * [`organizations.roles.get()`](https://cloud.google.com/iam/reference/rest/v1/organizations.roles/get):
            #     `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method
            #     returns only [custom roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that
            #     have been created at the organization level. Example request URL:
            #     `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`
            #
            #   Note: Wildcard (*) values are invalid; you must specify a complete project
            #   ID or organization ID.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Iam::Admin::V1::Role]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Iam::Admin::V1::Role]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/iam/admin"
            #
            #   iam_client = Google::Cloud::Iam::Admin.new(version: :v1)
            #   response = iam_client.get_role

            def get_role \
                name: nil,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::Admin::V1::GetRoleRequest)
              @get_role.call(req, options, &block)
            end

            # Creates a new Role.
            #
            # @param parent [String]
            #   The `parent` parameter's value depends on the target resource for the
            #   request, namely
            #   [`projects`](https://cloud.google.com/iam/reference/rest/v1/projects.roles) or
            #   [`organizations`](https://cloud.google.com/iam/reference/rest/v1/organizations.roles). Each
            #   resource type's `parent` value format is described below:
            #
            #   * [`projects.roles.create()`](https://cloud.google.com/iam/reference/rest/v1/projects.roles/create):
            #     `projects/{PROJECT_ID}`. This method creates project-level
            #     [custom roles](https://cloud.google.com/iam/docs/understanding-custom-roles).
            #     Example request URL:
            #     `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles`
            #
            #   * [`organizations.roles.create()`](https://cloud.google.com/iam/reference/rest/v1/organizations.roles/create):
            #     `organizations/{ORGANIZATION_ID}`. This method creates organization-level
            #     [custom roles](https://cloud.google.com/iam/docs/understanding-custom-roles). Example request
            #     URL:
            #     `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles`
            #
            #   Note: Wildcard (*) values are invalid; you must specify a complete project
            #   ID or organization ID.
            # @param role_id [String]
            #   The role ID to use for this role.
            # @param role [Google::Iam::Admin::V1::Role | Hash]
            #   The Role resource to create.
            #   A hash of the same form as `Google::Iam::Admin::V1::Role`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Iam::Admin::V1::Role]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Iam::Admin::V1::Role]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/iam/admin"
            #
            #   iam_client = Google::Cloud::Iam::Admin.new(version: :v1)
            #   response = iam_client.create_role

            def create_role \
                parent: nil,
                role_id: nil,
                role: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                role_id: role_id,
                role: role
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::Admin::V1::CreateRoleRequest)
              @create_role.call(req, options, &block)
            end

            # Updates a Role definition.
            #
            # @param name [String]
            #   The `name` parameter's value depends on the target resource for the
            #   request, namely
            #   [`projects`](https://cloud.google.com/iam/reference/rest/v1/projects.roles) or
            #   [`organizations`](https://cloud.google.com/iam/reference/rest/v1/organizations.roles). Each
            #   resource type's `name` value format is described below:
            #
            #   * [`projects.roles.patch()`](https://cloud.google.com/iam/reference/rest/v1/projects.roles/patch):
            #     `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method updates only
            #     [custom roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been
            #     created at the project level. Example request URL:
            #     `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`
            #
            #   * [`organizations.roles.patch()`](https://cloud.google.com/iam/reference/rest/v1/organizations.roles/patch):
            #     `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method
            #     updates only [custom roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that
            #     have been created at the organization level. Example request URL:
            #     `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`
            #
            #   Note: Wildcard (*) values are invalid; you must specify a complete project
            #   ID or organization ID.
            # @param role [Google::Iam::Admin::V1::Role | Hash]
            #   The updated role.
            #   A hash of the same form as `Google::Iam::Admin::V1::Role`
            #   can also be provided.
            # @param update_mask [Google::Protobuf::FieldMask | Hash]
            #   A mask describing which fields in the Role have changed.
            #   A hash of the same form as `Google::Protobuf::FieldMask`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Iam::Admin::V1::Role]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Iam::Admin::V1::Role]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/iam/admin"
            #
            #   iam_client = Google::Cloud::Iam::Admin.new(version: :v1)
            #   response = iam_client.update_role

            def update_role \
                name: nil,
                role: nil,
                update_mask: nil,
                options: nil,
                &block
              req = {
                name: name,
                role: role,
                update_mask: update_mask
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::Admin::V1::UpdateRoleRequest)
              @update_role.call(req, options, &block)
            end

            # Soft deletes a role. The role is suspended and cannot be used to create new
            # IAM Policy Bindings.
            # The Role will not be included in `ListRoles()` unless `show_deleted` is set
            # in the `ListRolesRequest`. The Role contains the deleted boolean set.
            # Existing Bindings remains, but are inactive. The Role can be undeleted
            # within 7 days. After 7 days the Role is deleted and all Bindings associated
            # with the role are removed.
            #
            # @param name [String]
            #   The `name` parameter's value depends on the target resource for the
            #   request, namely
            #   [`projects`](https://cloud.google.com/iam/reference/rest/v1/projects.roles) or
            #   [`organizations`](https://cloud.google.com/iam/reference/rest/v1/organizations.roles). Each
            #   resource type's `name` value format is described below:
            #
            #   * [`projects.roles.delete()`](https://cloud.google.com/iam/reference/rest/v1/projects.roles/delete):
            #     `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method deletes only
            #     [custom roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been
            #     created at the project level. Example request URL:
            #     `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`
            #
            #   * [`organizations.roles.delete()`](https://cloud.google.com/iam/reference/rest/v1/organizations.roles/delete):
            #     `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method
            #     deletes only [custom roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that
            #     have been created at the organization level. Example request URL:
            #     `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`
            #
            #   Note: Wildcard (*) values are invalid; you must specify a complete project
            #   ID or organization ID.
            # @param etag [String]
            #   Used to perform a consistent read-modify-write.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Iam::Admin::V1::Role]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Iam::Admin::V1::Role]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/iam/admin"
            #
            #   iam_client = Google::Cloud::Iam::Admin.new(version: :v1)
            #   response = iam_client.delete_role

            def delete_role \
                name: nil,
                etag: nil,
                options: nil,
                &block
              req = {
                name: name,
                etag: etag
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::Admin::V1::DeleteRoleRequest)
              @delete_role.call(req, options, &block)
            end

            # Undelete a Role, bringing it back in its previous state.
            #
            # @param name [String]
            #   The `name` parameter's value depends on the target resource for the
            #   request, namely
            #   [`projects`](https://cloud.google.com/iam/reference/rest/v1/projects.roles) or
            #   [`organizations`](https://cloud.google.com/iam/reference/rest/v1/organizations.roles). Each
            #   resource type's `name` value format is described below:
            #
            #   * [`projects.roles.undelete()`](https://cloud.google.com/iam/reference/rest/v1/projects.roles/undelete):
            #     `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method undeletes
            #     only [custom roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been
            #     created at the project level. Example request URL:
            #     `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`
            #
            #   * [`organizations.roles.undelete()`](https://cloud.google.com/iam/reference/rest/v1/organizations.roles/undelete):
            #     `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method
            #     undeletes only [custom roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that
            #     have been created at the organization level. Example request URL:
            #     `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`
            #
            #   Note: Wildcard (*) values are invalid; you must specify a complete project
            #   ID or organization ID.
            # @param etag [String]
            #   Used to perform a consistent read-modify-write.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Iam::Admin::V1::Role]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Iam::Admin::V1::Role]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/iam/admin"
            #
            #   iam_client = Google::Cloud::Iam::Admin.new(version: :v1)
            #   response = iam_client.undelete_role

            def undelete_role \
                name: nil,
                etag: nil,
                options: nil,
                &block
              req = {
                name: name,
                etag: etag
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::Admin::V1::UndeleteRoleRequest)
              @undelete_role.call(req, options, &block)
            end

            # Lists the permissions testable on a resource.
            # A permission is testable if it can be tested for an identity on a resource.
            #
            # @param full_resource_name [String]
            #   Required. The full resource name to query from the list of testable
            #   permissions.
            #
            #   The name follows the Google Cloud Platform resource format.
            #   For example, a Cloud Platform project with id `my-project` will be named
            #   `//cloudresourcemanager.googleapis.com/projects/my-project`.
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
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Iam::Admin::V1::Permission>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Iam::Admin::V1::Permission>]
            #   An enumerable of Google::Iam::Admin::V1::Permission instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/iam/admin"
            #
            #   iam_client = Google::Cloud::Iam::Admin.new(version: :v1)
            #
            #   # Iterate over all results.
            #   iam_client.query_testable_permissions.each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   iam_client.query_testable_permissions.each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def query_testable_permissions \
                full_resource_name: nil,
                page_size: nil,
                options: nil,
                &block
              req = {
                full_resource_name: full_resource_name,
                page_size: page_size
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::Admin::V1::QueryTestablePermissionsRequest)
              @query_testable_permissions.call(req, options, &block)
            end
          end
        end
      end
    end
  end
end
