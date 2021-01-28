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
# https://github.com/googleapis/googleapis/blob/master/google/iam/credentials/v1/iamcredentials.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/iam/credentials/v1/iamcredentials_pb"
require "google/cloud/iam/credentials/v1/credentials"

module Google
  module Cloud
    module Iam
      module Credentials
        module V1
          # A service account is a special type of Google account that belongs to your
          # application or a virtual machine (VM), instead of to an individual end user.
          # Your application assumes the identity of the service account to call Google
          # APIs, so that the users aren't directly involved.
          #
          # Service account credentials are used to temporarily assume the identity
          # of the service account. Supported credential types include OAuth 2.0 access
          # tokens, OpenID Connect ID tokens, self-signed JSON Web Tokens (JWTs), and
          # more.
          #
          # @!attribute [r] iam_credentials_stub
          #   @return [Google::Iam::Credentials::V1::IAMCredentials::Stub]
          class IamCredentialsClient
            attr_reader :iam_credentials_stub

            # The default address of the service.
            SERVICE_ADDRESS = "iamcredentials.googleapis.com".freeze

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


            SERVICE_ACCOUNT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/serviceAccounts/{service_account}"
            )

            private_constant :SERVICE_ACCOUNT_PATH_TEMPLATE

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
              require "google/iam/credentials/v1/iamcredentials_services_pb"

              credentials ||= Google::Cloud::Iam::Credentials::V1::Credentials.default

              if credentials.is_a?(String) || credentials.is_a?(Hash)
                updater_proc = Google::Cloud::Iam::Credentials::V1::Credentials.new(credentials).updater_proc
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

              package_version = Gem.loaded_specs['google-cloud-iam-credentials'].version.version

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
                "iam_credentials_client_config.json"
              )
              defaults = client_config_file.open do |f|
                Google::Gax.construct_settings(
                  "google.iam.credentials.v1.IAMCredentials",
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
              @iam_credentials_stub = Google::Gax::Grpc.create_stub(
                service_path,
                port,
                chan_creds: chan_creds,
                channel: channel,
                updater_proc: updater_proc,
                scopes: scopes,
                interceptors: interceptors,
                &Google::Iam::Credentials::V1::IAMCredentials::Stub.method(:new)
              )

              @generate_access_token = Google::Gax.create_api_call(
                @iam_credentials_stub.method(:generate_access_token),
                defaults["generate_access_token"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @generate_id_token = Google::Gax.create_api_call(
                @iam_credentials_stub.method(:generate_id_token),
                defaults["generate_id_token"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @sign_blob = Google::Gax.create_api_call(
                @iam_credentials_stub.method(:sign_blob),
                defaults["sign_blob"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @sign_jwt = Google::Gax.create_api_call(
                @iam_credentials_stub.method(:sign_jwt),
                defaults["sign_jwt"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
            end

            # Service calls

            # Generates an OAuth 2.0 access token for a service account.
            #
            # @param name [String]
            #   Required. The resource name of the service account for which the credentials
            #   are requested, in the following format:
            #   `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
            #   character is required; replacing it with a project ID is invalid.
            # @param scope [Array<String>]
            #   Required. Code to identify the scopes to be included in the OAuth 2.0 access token.
            #   See https://developers.google.com/identity/protocols/googlescopes for more
            #   information.
            #   At least one value required.
            # @param delegates [Array<String>]
            #   The sequence of service accounts in a delegation chain. Each service
            #   account must be granted the `roles/iam.serviceAccountTokenCreator` role
            #   on its next service account in the chain. The last service account in the
            #   chain must be granted the `roles/iam.serviceAccountTokenCreator` role
            #   on the service account that is specified in the `name` field of the
            #   request.
            #
            #   The delegates must have the following format:
            #   `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
            #   character is required; replacing it with a project ID is invalid.
            # @param lifetime [Google::Protobuf::Duration | Hash]
            #   The desired lifetime duration of the access token in seconds.
            #   Must be set to a value less than or equal to 3600 (1 hour). If a value is
            #   not specified, the token's lifetime will be set to a default value of one
            #   hour.
            #   A hash of the same form as `Google::Protobuf::Duration`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Iam::Credentials::V1::GenerateAccessTokenResponse]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Iam::Credentials::V1::GenerateAccessTokenResponse]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/iam/credentials"
            #
            #   iam_credentials_client = Google::Cloud::Iam::Credentials.new(version: :v1)
            #   formatted_name = Google::Cloud::Iam::Credentials::V1::IamCredentialsClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")
            #
            #   # TODO: Initialize `scope`:
            #   scope = []
            #   response = iam_credentials_client.generate_access_token(formatted_name, scope)

            def generate_access_token \
                name,
                scope,
                delegates: nil,
                lifetime: nil,
                options: nil,
                &block
              req = {
                name: name,
                scope: scope,
                delegates: delegates,
                lifetime: lifetime
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::Credentials::V1::GenerateAccessTokenRequest)
              @generate_access_token.call(req, options, &block)
            end

            # Generates an OpenID Connect ID token for a service account.
            #
            # @param name [String]
            #   Required. The resource name of the service account for which the credentials
            #   are requested, in the following format:
            #   `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
            #   character is required; replacing it with a project ID is invalid.
            # @param audience [String]
            #   Required. The audience for the token, such as the API or account that this token
            #   grants access to.
            # @param delegates [Array<String>]
            #   The sequence of service accounts in a delegation chain. Each service
            #   account must be granted the `roles/iam.serviceAccountTokenCreator` role
            #   on its next service account in the chain. The last service account in the
            #   chain must be granted the `roles/iam.serviceAccountTokenCreator` role
            #   on the service account that is specified in the `name` field of the
            #   request.
            #
            #   The delegates must have the following format:
            #   `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
            #   character is required; replacing it with a project ID is invalid.
            # @param include_email [true, false]
            #   Include the service account email in the token. If set to `true`, the
            #   token will contain `email` and `email_verified` claims.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Iam::Credentials::V1::GenerateIdTokenResponse]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Iam::Credentials::V1::GenerateIdTokenResponse]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/iam/credentials"
            #
            #   iam_credentials_client = Google::Cloud::Iam::Credentials.new(version: :v1)
            #   formatted_name = Google::Cloud::Iam::Credentials::V1::IamCredentialsClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")
            #
            #   # TODO: Initialize `audience`:
            #   audience = ''
            #   response = iam_credentials_client.generate_id_token(formatted_name, audience)

            def generate_id_token \
                name,
                audience,
                delegates: nil,
                include_email: nil,
                options: nil,
                &block
              req = {
                name: name,
                audience: audience,
                delegates: delegates,
                include_email: include_email
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::Credentials::V1::GenerateIdTokenRequest)
              @generate_id_token.call(req, options, &block)
            end

            # Signs a blob using a service account's system-managed private key.
            #
            # @param name [String]
            #   Required. The resource name of the service account for which the credentials
            #   are requested, in the following format:
            #   `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
            #   character is required; replacing it with a project ID is invalid.
            # @param payload [String]
            #   Required. The bytes to sign.
            # @param delegates [Array<String>]
            #   The sequence of service accounts in a delegation chain. Each service
            #   account must be granted the `roles/iam.serviceAccountTokenCreator` role
            #   on its next service account in the chain. The last service account in the
            #   chain must be granted the `roles/iam.serviceAccountTokenCreator` role
            #   on the service account that is specified in the `name` field of the
            #   request.
            #
            #   The delegates must have the following format:
            #   `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
            #   character is required; replacing it with a project ID is invalid.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Iam::Credentials::V1::SignBlobResponse]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Iam::Credentials::V1::SignBlobResponse]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/iam/credentials"
            #
            #   iam_credentials_client = Google::Cloud::Iam::Credentials.new(version: :v1)
            #   formatted_name = Google::Cloud::Iam::Credentials::V1::IamCredentialsClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")
            #
            #   # TODO: Initialize `payload`:
            #   payload = ''
            #   response = iam_credentials_client.sign_blob(formatted_name, payload)

            def sign_blob \
                name,
                payload,
                delegates: nil,
                options: nil,
                &block
              req = {
                name: name,
                payload: payload,
                delegates: delegates
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::Credentials::V1::SignBlobRequest)
              @sign_blob.call(req, options, &block)
            end

            # Signs a JWT using a service account's system-managed private key.
            #
            # @param name [String]
            #   Required. The resource name of the service account for which the credentials
            #   are requested, in the following format:
            #   `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
            #   character is required; replacing it with a project ID is invalid.
            # @param payload [String]
            #   Required. The JWT payload to sign: a JSON object that contains a JWT Claims Set.
            # @param delegates [Array<String>]
            #   The sequence of service accounts in a delegation chain. Each service
            #   account must be granted the `roles/iam.serviceAccountTokenCreator` role
            #   on its next service account in the chain. The last service account in the
            #   chain must be granted the `roles/iam.serviceAccountTokenCreator` role
            #   on the service account that is specified in the `name` field of the
            #   request.
            #
            #   The delegates must have the following format:
            #   `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
            #   character is required; replacing it with a project ID is invalid.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Iam::Credentials::V1::SignJwtResponse]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Iam::Credentials::V1::SignJwtResponse]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/iam/credentials"
            #
            #   iam_credentials_client = Google::Cloud::Iam::Credentials.new(version: :v1)
            #   formatted_name = Google::Cloud::Iam::Credentials::V1::IamCredentialsClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")
            #
            #   # TODO: Initialize `payload`:
            #   payload = ''
            #   response = iam_credentials_client.sign_jwt(formatted_name, payload)

            def sign_jwt \
                name,
                payload,
                delegates: nil,
                options: nil,
                &block
              req = {
                name: name,
                payload: payload,
                delegates: delegates
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Iam::Credentials::V1::SignJwtRequest)
              @sign_jwt.call(req, options, &block)
            end
          end
        end
      end
    end
  end
end
