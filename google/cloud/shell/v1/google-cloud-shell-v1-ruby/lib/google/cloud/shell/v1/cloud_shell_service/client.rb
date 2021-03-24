# frozen_string_literal: true

# Copyright 2021 Google LLC
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

# Auto-generated by gapic-generator-ruby. DO NOT EDIT!

require "google/cloud/errors"
require "google/cloud/shell/v1/cloudshell_pb"

module Google
  module Cloud
    module Shell
      module V1
        module CloudShellService
          ##
          # Client for the CloudShellService service.
          #
          # API for interacting with Google Cloud Shell. Each user of Cloud Shell has at
          # least one environment, which has the ID "default". Environment consists of a
          # Docker image defining what is installed on the environment and a home
          # directory containing the user's data that will remain across sessions.
          # Clients use this API to start and fetch information about their environment,
          # which can then be used to connect to that environment via a separate SSH
          # client.
          #
          class Client
            include Paths

            # @private
            attr_reader :cloud_shell_service_stub

            ##
            # Configure the CloudShellService Client class.
            #
            # See {::Google::Cloud::Shell::V1::CloudShellService::Client::Configuration}
            # for a description of the configuration fields.
            #
            # ## Example
            #
            # To modify the configuration for all CloudShellService clients:
            #
            #     ::Google::Cloud::Shell::V1::CloudShellService::Client.configure do |config|
            #       config.timeout = 10.0
            #     end
            #
            # @yield [config] Configure the Client client.
            # @yieldparam config [Client::Configuration]
            #
            # @return [Client::Configuration]
            #
            def self.configure
              @configure ||= begin
                namespace = ["Google", "Cloud", "Shell", "V1"]
                parent_config = while namespace.any?
                                  parent_name = namespace.join "::"
                                  parent_const = const_get parent_name
                                  break parent_const.configure if parent_const.respond_to? :configure
                                  namespace.pop
                                end
                default_config = Client::Configuration.new parent_config

                default_config.rpcs.get_environment.timeout = 60.0
                default_config.rpcs.get_environment.retry_policy = {
                  initial_delay: 1.0,
              max_delay: 60.0,
              multiplier: 1.3,
              retry_codes: [14, 2]
                }

                default_config.rpcs.start_environment.timeout = 60.0

                default_config.rpcs.authorize_environment.timeout = 60.0

                default_config.rpcs.add_public_key.timeout = 60.0

                default_config.rpcs.remove_public_key.timeout = 60.0

                default_config
              end
              yield @configure if block_given?
              @configure
            end

            ##
            # Configure the CloudShellService Client instance.
            #
            # The configuration is set to the derived mode, meaning that values can be changed,
            # but structural changes (adding new fields, etc.) are not allowed. Structural changes
            # should be made on {Client.configure}.
            #
            # See {::Google::Cloud::Shell::V1::CloudShellService::Client::Configuration}
            # for a description of the configuration fields.
            #
            # @yield [config] Configure the Client client.
            # @yieldparam config [Client::Configuration]
            #
            # @return [Client::Configuration]
            #
            def configure
              yield @config if block_given?
              @config
            end

            ##
            # Create a new CloudShellService client object.
            #
            # ## Examples
            #
            # To create a new CloudShellService client with the default
            # configuration:
            #
            #     client = ::Google::Cloud::Shell::V1::CloudShellService::Client.new
            #
            # To create a new CloudShellService client with a custom
            # configuration:
            #
            #     client = ::Google::Cloud::Shell::V1::CloudShellService::Client.new do |config|
            #       config.timeout = 10.0
            #     end
            #
            # @yield [config] Configure the CloudShellService client.
            # @yieldparam config [Client::Configuration]
            #
            def initialize
              # These require statements are intentionally placed here to initialize
              # the gRPC module only when it's required.
              # See https://github.com/googleapis/toolkit/issues/446
              require "gapic/grpc"
              require "google/cloud/shell/v1/cloudshell_services_pb"

              # Create the configuration object
              @config = Configuration.new Client.configure

              # Yield the configuration if needed
              yield @config if block_given?

              # Create credentials
              credentials = @config.credentials
              # Use self-signed JWT if the scope and endpoint are unchanged from default,
              # but only if the default endpoint does not have a region prefix.
              enable_self_signed_jwt = @config.scope == Client.configure.scope &&
                                       @config.endpoint == Client.configure.endpoint &&
                                       !@config.endpoint.split(".").first.include?("-")
              credentials ||= Credentials.default scope: @config.scope,
                                                  enable_self_signed_jwt: enable_self_signed_jwt
              if credentials.is_a?(String) || credentials.is_a?(Hash)
                credentials = Credentials.new credentials, scope: @config.scope
              end
              @quota_project_id = @config.quota_project
              @quota_project_id ||= credentials.quota_project_id if credentials.respond_to? :quota_project_id

              @operations_client = Operations.new do |config|
                config.credentials = credentials
                config.endpoint = @config.endpoint
              end

              @cloud_shell_service_stub = ::Gapic::ServiceStub.new(
                ::Google::Cloud::Shell::V1::CloudShellService::Stub,
                credentials:  credentials,
                endpoint:     @config.endpoint,
                channel_args: @config.channel_args,
                interceptors: @config.interceptors
              )
            end

            ##
            # Get the associated client for long-running operations.
            #
            # @return [::Google::Cloud::Shell::V1::CloudShellService::Operations]
            #
            attr_reader :operations_client

            # Service calls

            ##
            # Gets an environment. Returns NOT_FOUND if the environment does not exist.
            #
            # @overload get_environment(request, options = nil)
            #   Pass arguments to `get_environment` via a request object, either of type
            #   {::Google::Cloud::Shell::V1::GetEnvironmentRequest} or an equivalent Hash.
            #
            #   @param request [::Google::Cloud::Shell::V1::GetEnvironmentRequest, ::Hash]
            #     A request object representing the call parameters. Required. To specify no
            #     parameters, or to keep all the default parameter values, pass an empty Hash.
            #   @param options [::Gapic::CallOptions, ::Hash]
            #     Overrides the default settings for this call, e.g, timeout, retries, etc. Optional.
            #
            # @overload get_environment(name: nil)
            #   Pass arguments to `get_environment` via keyword arguments. Note that at
            #   least one keyword argument is required. To specify no parameters, or to keep all
            #   the default parameter values, pass an empty Hash as a request object (see above).
            #
            #   @param name [::String]
            #     Required. Name of the requested resource, for example `users/me/environments/default`
            #     or `users/someone@example.com/environments/default`.
            #
            # @yield [response, operation] Access the result along with the RPC operation
            # @yieldparam response [::Google::Cloud::Shell::V1::Environment]
            # @yieldparam operation [::GRPC::ActiveCall::Operation]
            #
            # @return [::Google::Cloud::Shell::V1::Environment]
            #
            # @raise [::Google::Cloud::Error] if the RPC is aborted.
            #
            def get_environment request, options = nil
              raise ::ArgumentError, "request must be provided" if request.nil?

              request = ::Gapic::Protobuf.coerce request, to: ::Google::Cloud::Shell::V1::GetEnvironmentRequest

              # Converts hash and nil to an options object
              options = ::Gapic::CallOptions.new(**options.to_h) if options.respond_to? :to_h

              # Customize the options with defaults
              metadata = @config.rpcs.get_environment.metadata.to_h

              # Set x-goog-api-client and x-goog-user-project headers
              metadata[:"x-goog-api-client"] ||= ::Gapic::Headers.x_goog_api_client \
                lib_name: @config.lib_name, lib_version: @config.lib_version,
                gapic_version: ::Google::Cloud::Shell::V1::VERSION
              metadata[:"x-goog-user-project"] = @quota_project_id if @quota_project_id

              header_params = {
                "name" => request.name
              }
              request_params_header = header_params.map { |k, v| "#{k}=#{v}" }.join("&")
              metadata[:"x-goog-request-params"] ||= request_params_header

              options.apply_defaults timeout:      @config.rpcs.get_environment.timeout,
                                     metadata:     metadata,
                                     retry_policy: @config.rpcs.get_environment.retry_policy
              options.apply_defaults metadata:     @config.metadata,
                                     retry_policy: @config.retry_policy

              @cloud_shell_service_stub.call_rpc :get_environment, request, options: options do |response, operation|
                yield response, operation if block_given?
                return response
              end
            rescue ::GRPC::BadStatus => e
              raise ::Google::Cloud::Error.from_error(e)
            end

            ##
            # Starts an existing environment, allowing clients to connect to it. The
            # returned operation will contain an instance of StartEnvironmentMetadata in
            # its metadata field. Users can wait for the environment to start by polling
            # this operation via GetOperation. Once the environment has finished starting
            # and is ready to accept connections, the operation will contain a
            # StartEnvironmentResponse in its response field.
            #
            # @overload start_environment(request, options = nil)
            #   Pass arguments to `start_environment` via a request object, either of type
            #   {::Google::Cloud::Shell::V1::StartEnvironmentRequest} or an equivalent Hash.
            #
            #   @param request [::Google::Cloud::Shell::V1::StartEnvironmentRequest, ::Hash]
            #     A request object representing the call parameters. Required. To specify no
            #     parameters, or to keep all the default parameter values, pass an empty Hash.
            #   @param options [::Gapic::CallOptions, ::Hash]
            #     Overrides the default settings for this call, e.g, timeout, retries, etc. Optional.
            #
            # @overload start_environment(name: nil, access_token: nil, public_keys: nil)
            #   Pass arguments to `start_environment` via keyword arguments. Note that at
            #   least one keyword argument is required. To specify no parameters, or to keep all
            #   the default parameter values, pass an empty Hash as a request object (see above).
            #
            #   @param name [::String]
            #     Name of the resource that should be started, for example
            #     `users/me/environments/default` or
            #     `users/someone@example.com/environments/default`.
            #   @param access_token [::String]
            #     The initial access token passed to the environment. If this is present and
            #     valid, the environment will be pre-authenticated with gcloud so that the
            #     user can run gcloud commands in Cloud Shell without having to log in. This
            #     code can be updated later by calling AuthorizeEnvironment.
            #   @param public_keys [::Array<::String>]
            #     Public keys that should be added to the environment before it is started.
            #
            # @yield [response, operation] Access the result along with the RPC operation
            # @yieldparam response [::Gapic::Operation]
            # @yieldparam operation [::GRPC::ActiveCall::Operation]
            #
            # @return [::Gapic::Operation]
            #
            # @raise [::Google::Cloud::Error] if the RPC is aborted.
            #
            def start_environment request, options = nil
              raise ::ArgumentError, "request must be provided" if request.nil?

              request = ::Gapic::Protobuf.coerce request, to: ::Google::Cloud::Shell::V1::StartEnvironmentRequest

              # Converts hash and nil to an options object
              options = ::Gapic::CallOptions.new(**options.to_h) if options.respond_to? :to_h

              # Customize the options with defaults
              metadata = @config.rpcs.start_environment.metadata.to_h

              # Set x-goog-api-client and x-goog-user-project headers
              metadata[:"x-goog-api-client"] ||= ::Gapic::Headers.x_goog_api_client \
                lib_name: @config.lib_name, lib_version: @config.lib_version,
                gapic_version: ::Google::Cloud::Shell::V1::VERSION
              metadata[:"x-goog-user-project"] = @quota_project_id if @quota_project_id

              header_params = {
                "name" => request.name
              }
              request_params_header = header_params.map { |k, v| "#{k}=#{v}" }.join("&")
              metadata[:"x-goog-request-params"] ||= request_params_header

              options.apply_defaults timeout:      @config.rpcs.start_environment.timeout,
                                     metadata:     metadata,
                                     retry_policy: @config.rpcs.start_environment.retry_policy
              options.apply_defaults metadata:     @config.metadata,
                                     retry_policy: @config.retry_policy

              @cloud_shell_service_stub.call_rpc :start_environment, request, options: options do |response, operation|
                response = ::Gapic::Operation.new response, @operations_client, options: options
                yield response, operation if block_given?
                return response
              end
            rescue ::GRPC::BadStatus => e
              raise ::Google::Cloud::Error.from_error(e)
            end

            ##
            # Sends OAuth credentials to a running environment on behalf of a user. When
            # this completes, the environment will be authorized to run various Google
            # Cloud command line tools without requiring the user to manually
            # authenticate.
            #
            # @overload authorize_environment(request, options = nil)
            #   Pass arguments to `authorize_environment` via a request object, either of type
            #   {::Google::Cloud::Shell::V1::AuthorizeEnvironmentRequest} or an equivalent Hash.
            #
            #   @param request [::Google::Cloud::Shell::V1::AuthorizeEnvironmentRequest, ::Hash]
            #     A request object representing the call parameters. Required. To specify no
            #     parameters, or to keep all the default parameter values, pass an empty Hash.
            #   @param options [::Gapic::CallOptions, ::Hash]
            #     Overrides the default settings for this call, e.g, timeout, retries, etc. Optional.
            #
            # @overload authorize_environment(name: nil, access_token: nil, id_token: nil, expire_time: nil)
            #   Pass arguments to `authorize_environment` via keyword arguments. Note that at
            #   least one keyword argument is required. To specify no parameters, or to keep all
            #   the default parameter values, pass an empty Hash as a request object (see above).
            #
            #   @param name [::String]
            #     Name of the resource that should receive the credentials, for example
            #     `users/me/environments/default` or
            #     `users/someone@example.com/environments/default`.
            #   @param access_token [::String]
            #     The OAuth access token that should be sent to the environment.
            #   @param id_token [::String]
            #     The OAuth ID token that should be sent to the environment.
            #   @param expire_time [::Google::Protobuf::Timestamp, ::Hash]
            #     The time when the credentials expire. If not set, defaults to one hour from
            #     when the server received the request.
            #
            # @yield [response, operation] Access the result along with the RPC operation
            # @yieldparam response [::Gapic::Operation]
            # @yieldparam operation [::GRPC::ActiveCall::Operation]
            #
            # @return [::Gapic::Operation]
            #
            # @raise [::Google::Cloud::Error] if the RPC is aborted.
            #
            def authorize_environment request, options = nil
              raise ::ArgumentError, "request must be provided" if request.nil?

              request = ::Gapic::Protobuf.coerce request, to: ::Google::Cloud::Shell::V1::AuthorizeEnvironmentRequest

              # Converts hash and nil to an options object
              options = ::Gapic::CallOptions.new(**options.to_h) if options.respond_to? :to_h

              # Customize the options with defaults
              metadata = @config.rpcs.authorize_environment.metadata.to_h

              # Set x-goog-api-client and x-goog-user-project headers
              metadata[:"x-goog-api-client"] ||= ::Gapic::Headers.x_goog_api_client \
                lib_name: @config.lib_name, lib_version: @config.lib_version,
                gapic_version: ::Google::Cloud::Shell::V1::VERSION
              metadata[:"x-goog-user-project"] = @quota_project_id if @quota_project_id

              header_params = {
                "name" => request.name
              }
              request_params_header = header_params.map { |k, v| "#{k}=#{v}" }.join("&")
              metadata[:"x-goog-request-params"] ||= request_params_header

              options.apply_defaults timeout:      @config.rpcs.authorize_environment.timeout,
                                     metadata:     metadata,
                                     retry_policy: @config.rpcs.authorize_environment.retry_policy
              options.apply_defaults metadata:     @config.metadata,
                                     retry_policy: @config.retry_policy

              @cloud_shell_service_stub.call_rpc :authorize_environment, request, options: options do |response, operation|
                response = ::Gapic::Operation.new response, @operations_client, options: options
                yield response, operation if block_given?
                return response
              end
            rescue ::GRPC::BadStatus => e
              raise ::Google::Cloud::Error.from_error(e)
            end

            ##
            # Adds a public SSH key to an environment, allowing clients with the
            # corresponding private key to connect to that environment via SSH. If a key
            # with the same content already exists, this will error with ALREADY_EXISTS.
            #
            # @overload add_public_key(request, options = nil)
            #   Pass arguments to `add_public_key` via a request object, either of type
            #   {::Google::Cloud::Shell::V1::AddPublicKeyRequest} or an equivalent Hash.
            #
            #   @param request [::Google::Cloud::Shell::V1::AddPublicKeyRequest, ::Hash]
            #     A request object representing the call parameters. Required. To specify no
            #     parameters, or to keep all the default parameter values, pass an empty Hash.
            #   @param options [::Gapic::CallOptions, ::Hash]
            #     Overrides the default settings for this call, e.g, timeout, retries, etc. Optional.
            #
            # @overload add_public_key(environment: nil, key: nil)
            #   Pass arguments to `add_public_key` via keyword arguments. Note that at
            #   least one keyword argument is required. To specify no parameters, or to keep all
            #   the default parameter values, pass an empty Hash as a request object (see above).
            #
            #   @param environment [::String]
            #     Environment this key should be added to, e.g.
            #     `users/me/environments/default`.
            #   @param key [::String]
            #     Key that should be added to the environment. Supported formats are
            #     `ssh-dss` (see RFC4253), `ssh-rsa` (see RFC4253), `ecdsa-sha2-nistp256`
            #     (see RFC5656), `ecdsa-sha2-nistp384` (see RFC5656) and
            #     `ecdsa-sha2-nistp521` (see RFC5656). It should be structured as
            #     &lt;format&gt; &lt;content&gt;, where &lt;content&gt; part is encoded with
            #     Base64.
            #
            # @yield [response, operation] Access the result along with the RPC operation
            # @yieldparam response [::Gapic::Operation]
            # @yieldparam operation [::GRPC::ActiveCall::Operation]
            #
            # @return [::Gapic::Operation]
            #
            # @raise [::Google::Cloud::Error] if the RPC is aborted.
            #
            def add_public_key request, options = nil
              raise ::ArgumentError, "request must be provided" if request.nil?

              request = ::Gapic::Protobuf.coerce request, to: ::Google::Cloud::Shell::V1::AddPublicKeyRequest

              # Converts hash and nil to an options object
              options = ::Gapic::CallOptions.new(**options.to_h) if options.respond_to? :to_h

              # Customize the options with defaults
              metadata = @config.rpcs.add_public_key.metadata.to_h

              # Set x-goog-api-client and x-goog-user-project headers
              metadata[:"x-goog-api-client"] ||= ::Gapic::Headers.x_goog_api_client \
                lib_name: @config.lib_name, lib_version: @config.lib_version,
                gapic_version: ::Google::Cloud::Shell::V1::VERSION
              metadata[:"x-goog-user-project"] = @quota_project_id if @quota_project_id

              header_params = {
                "environment" => request.environment
              }
              request_params_header = header_params.map { |k, v| "#{k}=#{v}" }.join("&")
              metadata[:"x-goog-request-params"] ||= request_params_header

              options.apply_defaults timeout:      @config.rpcs.add_public_key.timeout,
                                     metadata:     metadata,
                                     retry_policy: @config.rpcs.add_public_key.retry_policy
              options.apply_defaults metadata:     @config.metadata,
                                     retry_policy: @config.retry_policy

              @cloud_shell_service_stub.call_rpc :add_public_key, request, options: options do |response, operation|
                response = ::Gapic::Operation.new response, @operations_client, options: options
                yield response, operation if block_given?
                return response
              end
            rescue ::GRPC::BadStatus => e
              raise ::Google::Cloud::Error.from_error(e)
            end

            ##
            # Removes a public SSH key from an environment. Clients will no longer be
            # able to connect to the environment using the corresponding private key.
            # If a key with the same content is not present, this will error with
            # NOT_FOUND.
            #
            # @overload remove_public_key(request, options = nil)
            #   Pass arguments to `remove_public_key` via a request object, either of type
            #   {::Google::Cloud::Shell::V1::RemovePublicKeyRequest} or an equivalent Hash.
            #
            #   @param request [::Google::Cloud::Shell::V1::RemovePublicKeyRequest, ::Hash]
            #     A request object representing the call parameters. Required. To specify no
            #     parameters, or to keep all the default parameter values, pass an empty Hash.
            #   @param options [::Gapic::CallOptions, ::Hash]
            #     Overrides the default settings for this call, e.g, timeout, retries, etc. Optional.
            #
            # @overload remove_public_key(environment: nil, key: nil)
            #   Pass arguments to `remove_public_key` via keyword arguments. Note that at
            #   least one keyword argument is required. To specify no parameters, or to keep all
            #   the default parameter values, pass an empty Hash as a request object (see above).
            #
            #   @param environment [::String]
            #     Environment this key should be removed from, e.g.
            #     `users/me/environments/default`.
            #   @param key [::String]
            #     Key that should be removed from the environment.
            #
            # @yield [response, operation] Access the result along with the RPC operation
            # @yieldparam response [::Gapic::Operation]
            # @yieldparam operation [::GRPC::ActiveCall::Operation]
            #
            # @return [::Gapic::Operation]
            #
            # @raise [::Google::Cloud::Error] if the RPC is aborted.
            #
            def remove_public_key request, options = nil
              raise ::ArgumentError, "request must be provided" if request.nil?

              request = ::Gapic::Protobuf.coerce request, to: ::Google::Cloud::Shell::V1::RemovePublicKeyRequest

              # Converts hash and nil to an options object
              options = ::Gapic::CallOptions.new(**options.to_h) if options.respond_to? :to_h

              # Customize the options with defaults
              metadata = @config.rpcs.remove_public_key.metadata.to_h

              # Set x-goog-api-client and x-goog-user-project headers
              metadata[:"x-goog-api-client"] ||= ::Gapic::Headers.x_goog_api_client \
                lib_name: @config.lib_name, lib_version: @config.lib_version,
                gapic_version: ::Google::Cloud::Shell::V1::VERSION
              metadata[:"x-goog-user-project"] = @quota_project_id if @quota_project_id

              header_params = {
                "environment" => request.environment
              }
              request_params_header = header_params.map { |k, v| "#{k}=#{v}" }.join("&")
              metadata[:"x-goog-request-params"] ||= request_params_header

              options.apply_defaults timeout:      @config.rpcs.remove_public_key.timeout,
                                     metadata:     metadata,
                                     retry_policy: @config.rpcs.remove_public_key.retry_policy
              options.apply_defaults metadata:     @config.metadata,
                                     retry_policy: @config.retry_policy

              @cloud_shell_service_stub.call_rpc :remove_public_key, request, options: options do |response, operation|
                response = ::Gapic::Operation.new response, @operations_client, options: options
                yield response, operation if block_given?
                return response
              end
            rescue ::GRPC::BadStatus => e
              raise ::Google::Cloud::Error.from_error(e)
            end

            ##
            # Configuration class for the CloudShellService API.
            #
            # This class represents the configuration for CloudShellService,
            # providing control over timeouts, retry behavior, logging, transport
            # parameters, and other low-level controls. Certain parameters can also be
            # applied individually to specific RPCs. See
            # {::Google::Cloud::Shell::V1::CloudShellService::Client::Configuration::Rpcs}
            # for a list of RPCs that can be configured independently.
            #
            # Configuration can be applied globally to all clients, or to a single client
            # on construction.
            #
            # # Examples
            #
            # To modify the global config, setting the timeout for get_environment
            # to 20 seconds, and all remaining timeouts to 10 seconds:
            #
            #     ::Google::Cloud::Shell::V1::CloudShellService::Client.configure do |config|
            #       config.timeout = 10.0
            #       config.rpcs.get_environment.timeout = 20.0
            #     end
            #
            # To apply the above configuration only to a new client:
            #
            #     client = ::Google::Cloud::Shell::V1::CloudShellService::Client.new do |config|
            #       config.timeout = 10.0
            #       config.rpcs.get_environment.timeout = 20.0
            #     end
            #
            # @!attribute [rw] endpoint
            #   The hostname or hostname:port of the service endpoint.
            #   Defaults to `"cloudshell.googleapis.com"`.
            #   @return [::String]
            # @!attribute [rw] credentials
            #   Credentials to send with calls. You may provide any of the following types:
            #    *  (`String`) The path to a service account key file in JSON format
            #    *  (`Hash`) A service account key as a Hash
            #    *  (`Google::Auth::Credentials`) A googleauth credentials object
            #       (see the [googleauth docs](https://googleapis.dev/ruby/googleauth/latest/index.html))
            #    *  (`Signet::OAuth2::Client`) A signet oauth2 client object
            #       (see the [signet docs](https://googleapis.dev/ruby/signet/latest/Signet/OAuth2/Client.html))
            #    *  (`GRPC::Core::Channel`) a gRPC channel with included credentials
            #    *  (`GRPC::Core::ChannelCredentials`) a gRPC credentails object
            #    *  (`nil`) indicating no credentials
            #   @return [::Object]
            # @!attribute [rw] scope
            #   The OAuth scopes
            #   @return [::Array<::String>]
            # @!attribute [rw] lib_name
            #   The library name as recorded in instrumentation and logging
            #   @return [::String]
            # @!attribute [rw] lib_version
            #   The library version as recorded in instrumentation and logging
            #   @return [::String]
            # @!attribute [rw] channel_args
            #   Extra parameters passed to the gRPC channel. Note: this is ignored if a
            #   `GRPC::Core::Channel` object is provided as the credential.
            #   @return [::Hash]
            # @!attribute [rw] interceptors
            #   An array of interceptors that are run before calls are executed.
            #   @return [::Array<::GRPC::ClientInterceptor>]
            # @!attribute [rw] timeout
            #   The call timeout in seconds.
            #   @return [::Numeric]
            # @!attribute [rw] metadata
            #   Additional gRPC headers to be sent with the call.
            #   @return [::Hash{::Symbol=>::String}]
            # @!attribute [rw] retry_policy
            #   The retry policy. The value is a hash with the following keys:
            #    *  `:initial_delay` (*type:* `Numeric`) - The initial delay in seconds.
            #    *  `:max_delay` (*type:* `Numeric`) - The max delay in seconds.
            #    *  `:multiplier` (*type:* `Numeric`) - The incremental backoff multiplier.
            #    *  `:retry_codes` (*type:* `Array<String>`) - The error codes that should
            #       trigger a retry.
            #   @return [::Hash]
            # @!attribute [rw] quota_project
            #   A separate project against which to charge quota.
            #   @return [::String]
            #
            class Configuration
              extend ::Gapic::Config

              config_attr :endpoint,      "cloudshell.googleapis.com", ::String
              config_attr :credentials,   nil do |value|
                allowed = [::String, ::Hash, ::Proc, ::Symbol, ::Google::Auth::Credentials, ::Signet::OAuth2::Client, nil]
                allowed += [::GRPC::Core::Channel, ::GRPC::Core::ChannelCredentials] if defined? ::GRPC
                allowed.any? { |klass| klass === value }
              end
              config_attr :scope,         nil, ::String, ::Array, nil
              config_attr :lib_name,      nil, ::String, nil
              config_attr :lib_version,   nil, ::String, nil
              config_attr(:channel_args,  { "grpc.service_config_disable_resolution" => 1 }, ::Hash, nil)
              config_attr :interceptors,  nil, ::Array, nil
              config_attr :timeout,       nil, ::Numeric, nil
              config_attr :metadata,      nil, ::Hash, nil
              config_attr :retry_policy,  nil, ::Hash, ::Proc, nil
              config_attr :quota_project, nil, ::String, nil

              # @private
              def initialize parent_config = nil
                @parent_config = parent_config unless parent_config.nil?

                yield self if block_given?
              end

              ##
              # Configurations for individual RPCs
              # @return [Rpcs]
              #
              def rpcs
                @rpcs ||= begin
                  parent_rpcs = nil
                  parent_rpcs = @parent_config.rpcs if defined?(@parent_config) && @parent_config.respond_to?(:rpcs)
                  Rpcs.new parent_rpcs
                end
              end

              ##
              # Configuration RPC class for the CloudShellService API.
              #
              # Includes fields providing the configuration for each RPC in this service.
              # Each configuration object is of type `Gapic::Config::Method` and includes
              # the following configuration fields:
              #
              #  *  `timeout` (*type:* `Numeric`) - The call timeout in seconds
              #  *  `metadata` (*type:* `Hash{Symbol=>String}`) - Additional gRPC headers
              #  *  `retry_policy (*type:* `Hash`) - The retry policy. The policy fields
              #     include the following keys:
              #      *  `:initial_delay` (*type:* `Numeric`) - The initial delay in seconds.
              #      *  `:max_delay` (*type:* `Numeric`) - The max delay in seconds.
              #      *  `:multiplier` (*type:* `Numeric`) - The incremental backoff multiplier.
              #      *  `:retry_codes` (*type:* `Array<String>`) - The error codes that should
              #         trigger a retry.
              #
              class Rpcs
                ##
                # RPC-specific configuration for `get_environment`
                # @return [::Gapic::Config::Method]
                #
                attr_reader :get_environment
                ##
                # RPC-specific configuration for `start_environment`
                # @return [::Gapic::Config::Method]
                #
                attr_reader :start_environment
                ##
                # RPC-specific configuration for `authorize_environment`
                # @return [::Gapic::Config::Method]
                #
                attr_reader :authorize_environment
                ##
                # RPC-specific configuration for `add_public_key`
                # @return [::Gapic::Config::Method]
                #
                attr_reader :add_public_key
                ##
                # RPC-specific configuration for `remove_public_key`
                # @return [::Gapic::Config::Method]
                #
                attr_reader :remove_public_key

                # @private
                def initialize parent_rpcs = nil
                  get_environment_config = parent_rpcs.get_environment if parent_rpcs.respond_to? :get_environment
                  @get_environment = ::Gapic::Config::Method.new get_environment_config
                  start_environment_config = parent_rpcs.start_environment if parent_rpcs.respond_to? :start_environment
                  @start_environment = ::Gapic::Config::Method.new start_environment_config
                  authorize_environment_config = parent_rpcs.authorize_environment if parent_rpcs.respond_to? :authorize_environment
                  @authorize_environment = ::Gapic::Config::Method.new authorize_environment_config
                  add_public_key_config = parent_rpcs.add_public_key if parent_rpcs.respond_to? :add_public_key
                  @add_public_key = ::Gapic::Config::Method.new add_public_key_config
                  remove_public_key_config = parent_rpcs.remove_public_key if parent_rpcs.respond_to? :remove_public_key
                  @remove_public_key = ::Gapic::Config::Method.new remove_public_key_config

                  yield self if block_given?
                end
              end
            end
          end
        end
      end
    end
  end
end
