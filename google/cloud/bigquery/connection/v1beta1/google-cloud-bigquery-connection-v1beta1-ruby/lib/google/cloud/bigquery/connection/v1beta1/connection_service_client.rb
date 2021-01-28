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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/bigquery/connection/v1beta1/connection.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/bigquery/connection/v1beta1/connection_pb"
require "google/cloud/bigquery/connection/v1beta1/credentials"

module Google
  module Cloud
    module Bigquery
      module Connection
        module V1beta1
          # Manages external data source connections and credentials.
          #
          # @!attribute [r] connection_service_stub
          #   @return [Google::Cloud::Bigquery::Connection::V1beta1::ConnectionService::Stub]
          class ConnectionServiceClient
            attr_reader :connection_service_stub

            # The default address of the service.
            SERVICE_ADDRESS = "bigqueryconnection.googleapis.com".freeze

            # The default port of the service.
            DEFAULT_SERVICE_PORT = 443

            # The default set of gRPC interceptors.
            GRPC_INTERCEPTORS = []

            DEFAULT_TIMEOUT = 30

            # The scopes needed to make gRPC calls to all of the methods defined in
            # this service.
            ALL_SCOPES = [
              "https://www.googleapis.com/auth/bigquery",
              "https://www.googleapis.com/auth/cloud-platform"
            ].freeze


            CONNECTION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}/connections/{connection}"
            )

            private_constant :CONNECTION_PATH_TEMPLATE

            LOCATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}"
            )

            private_constant :LOCATION_PATH_TEMPLATE

            # Returns a fully-qualified connection resource name string.
            # @param project [String]
            # @param location [String]
            # @param connection [String]
            # @return [String]
            def self.connection_path project, location, connection
              CONNECTION_PATH_TEMPLATE.render(
                :"project" => project,
                :"location" => location,
                :"connection" => connection
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
              require "google/cloud/bigquery/connection/v1beta1/connection_services_pb"

              credentials ||= Google::Cloud::Bigquery::Connection::V1beta1::Credentials.default

              if credentials.is_a?(String) || credentials.is_a?(Hash)
                updater_proc = Google::Cloud::Bigquery::Connection::V1beta1::Credentials.new(credentials).updater_proc
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

              package_version = Gem.loaded_specs['google-cloud-bigquery-connection'].version.version

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
                "connection_service_client_config.json"
              )
              defaults = client_config_file.open do |f|
                Google::Gax.construct_settings(
                  "google.cloud.bigquery.connection.v1beta1.ConnectionService",
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
              @connection_service_stub = Google::Gax::Grpc.create_stub(
                service_path,
                port,
                chan_creds: chan_creds,
                channel: channel,
                updater_proc: updater_proc,
                scopes: scopes,
                interceptors: interceptors,
                &Google::Cloud::Bigquery::Connection::V1beta1::ConnectionService::Stub.method(:new)
              )

              @create_connection = Google::Gax.create_api_call(
                @connection_service_stub.method(:create_connection),
                defaults["create_connection"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @get_connection = Google::Gax.create_api_call(
                @connection_service_stub.method(:get_connection),
                defaults["get_connection"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @list_connections = Google::Gax.create_api_call(
                @connection_service_stub.method(:list_connections),
                defaults["list_connections"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @update_connection = Google::Gax.create_api_call(
                @connection_service_stub.method(:update_connection),
                defaults["update_connection"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @update_connection_credential = Google::Gax.create_api_call(
                @connection_service_stub.method(:update_connection_credential),
                defaults["update_connection_credential"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @delete_connection = Google::Gax.create_api_call(
                @connection_service_stub.method(:delete_connection),
                defaults["delete_connection"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @get_iam_policy = Google::Gax.create_api_call(
                @connection_service_stub.method(:get_iam_policy),
                defaults["get_iam_policy"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'resource' => request.resource}
                end
              )
              @set_iam_policy = Google::Gax.create_api_call(
                @connection_service_stub.method(:set_iam_policy),
                defaults["set_iam_policy"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'resource' => request.resource}
                end
              )
              @test_iam_permissions = Google::Gax.create_api_call(
                @connection_service_stub.method(:test_iam_permissions),
                defaults["test_iam_permissions"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'resource' => request.resource}
                end
              )
            end

            # Service calls

            # Creates a new connection.
            #
            # @param parent [String]
            #   Required. Parent resource name.
            #   Must be in the format `projects/{project_id}/locations/{location_id}`
            # @param connection [Google::Cloud::Bigquery::Connection::V1beta1::Connection | Hash]
            #   Required. Connection to create.
            #   A hash of the same form as `Google::Cloud::Bigquery::Connection::V1beta1::Connection`
            #   can also be provided.
            # @param connection_id [String]
            #   Optional. Connection id that should be assigned to the created connection.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Bigquery::Connection::V1beta1::Connection]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Bigquery::Connection::V1beta1::Connection]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/connection"
            #
            #   connection_client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)
            #   formatted_parent = Google::Cloud::Bigquery::Connection::V1beta1::ConnectionServiceClient.location_path("[PROJECT]", "[LOCATION]")
            #
            #   # TODO: Initialize `connection`:
            #   connection = {}
            #   response = connection_client.create_connection(formatted_parent, connection)

            def create_connection \
                parent,
                connection,
                connection_id: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                connection: connection,
                connection_id: connection_id
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Connection::V1beta1::CreateConnectionRequest)
              @create_connection.call(req, options, &block)
            end

            # Returns specified connection.
            #
            # @param name [String]
            #   Required. Name of the requested connection, for example:
            #   `projects/{project_id}/locations/{location_id}/connections/{connection_id}`
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Bigquery::Connection::V1beta1::Connection]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Bigquery::Connection::V1beta1::Connection]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/connection"
            #
            #   connection_client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)
            #   formatted_name = Google::Cloud::Bigquery::Connection::V1beta1::ConnectionServiceClient.connection_path("[PROJECT]", "[LOCATION]", "[CONNECTION]")
            #   response = connection_client.get_connection(formatted_name)

            def get_connection \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Connection::V1beta1::GetConnectionRequest)
              @get_connection.call(req, options, &block)
            end

            # Returns a list of connections in the given project.
            #
            # @param parent [String]
            #   Required. Parent resource name.
            #   Must be in the form: `projects/{project_id}/locations/{location_id}`
            # @param max_results [Google::Protobuf::UInt32Value | Hash]
            #   Required. Maximum number of results per page.
            #   A hash of the same form as `Google::Protobuf::UInt32Value`
            #   can also be provided.
            # @param page_token [String]
            #   Page token.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Bigquery::Connection::V1beta1::ListConnectionsResponse]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Bigquery::Connection::V1beta1::ListConnectionsResponse]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/connection"
            #
            #   connection_client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)
            #   formatted_parent = Google::Cloud::Bigquery::Connection::V1beta1::ConnectionServiceClient.location_path("[PROJECT]", "[LOCATION]")
            #
            #   # TODO: Initialize `max_results`:
            #   max_results = {}
            #   response = connection_client.list_connections(formatted_parent, max_results)

            def list_connections \
                parent,
                max_results,
                page_token: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                max_results: max_results,
                page_token: page_token
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Connection::V1beta1::ListConnectionsRequest)
              @list_connections.call(req, options, &block)
            end

            # Updates the specified connection. For security reasons, also resets
            # credential if connection properties are in the update field mask.
            #
            # @param name [String]
            #   Required. Name of the connection to update, for example:
            #   `projects/{project_id}/locations/{location_id}/connections/{connection_id}`
            # @param connection [Google::Cloud::Bigquery::Connection::V1beta1::Connection | Hash]
            #   Required. Connection containing the updated fields.
            #   A hash of the same form as `Google::Cloud::Bigquery::Connection::V1beta1::Connection`
            #   can also be provided.
            # @param update_mask [Google::Protobuf::FieldMask | Hash]
            #   Required. Update mask for the connection fields to be updated.
            #   A hash of the same form as `Google::Protobuf::FieldMask`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Bigquery::Connection::V1beta1::Connection]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Bigquery::Connection::V1beta1::Connection]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/connection"
            #
            #   connection_client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)
            #   formatted_name = Google::Cloud::Bigquery::Connection::V1beta1::ConnectionServiceClient.connection_path("[PROJECT]", "[LOCATION]", "[CONNECTION]")
            #
            #   # TODO: Initialize `connection`:
            #   connection = {}
            #
            #   # TODO: Initialize `update_mask`:
            #   update_mask = {}
            #   response = connection_client.update_connection(formatted_name, connection, update_mask)

            def update_connection \
                name,
                connection,
                update_mask,
                options: nil,
                &block
              req = {
                name: name,
                connection: connection,
                update_mask: update_mask
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Connection::V1beta1::UpdateConnectionRequest)
              @update_connection.call(req, options, &block)
            end

            # Sets the credential for the specified connection.
            #
            # @param name [String]
            #   Required. Name of the connection, for example:
            #   `projects/{project_id}/locations/{location_id}/connections/{connection_id}/credential`
            # @param credential [Google::Cloud::Bigquery::Connection::V1beta1::ConnectionCredential | Hash]
            #   Required. Credential to use with the connection.
            #   A hash of the same form as `Google::Cloud::Bigquery::Connection::V1beta1::ConnectionCredential`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result []
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/connection"
            #
            #   connection_client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)
            #
            #   # TODO: Initialize `name`:
            #   name = ''
            #
            #   # TODO: Initialize `credential`:
            #   credential = {}
            #   connection_client.update_connection_credential(name, credential)

            def update_connection_credential \
                name,
                credential,
                options: nil,
                &block
              req = {
                name: name,
                credential: credential
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Connection::V1beta1::UpdateConnectionCredentialRequest)
              @update_connection_credential.call(req, options, &block)
              nil
            end

            # Deletes connection and associated credential.
            #
            # @param name [String]
            #   Required. Name of the deleted connection, for example:
            #   `projects/{project_id}/locations/{location_id}/connections/{connection_id}`
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result []
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/connection"
            #
            #   connection_client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)
            #   formatted_name = Google::Cloud::Bigquery::Connection::V1beta1::ConnectionServiceClient.connection_path("[PROJECT]", "[LOCATION]", "[CONNECTION]")
            #   connection_client.delete_connection(formatted_name)

            def delete_connection \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Connection::V1beta1::DeleteConnectionRequest)
              @delete_connection.call(req, options, &block)
              nil
            end

            # Gets the access control policy for a resource.
            # Returns an empty policy if the resource exists and does not have a policy
            # set.
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
            #   require "google/cloud/bigquery/connection"
            #
            #   connection_client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)
            #
            #   # TODO: Initialize `resource`:
            #   resource = ''
            #   response = connection_client.get_iam_policy(resource)

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

            # Sets the access control policy on the specified resource. Replaces any
            # existing policy.
            #
            # Can return Public Errors: NOT_FOUND, INVALID_ARGUMENT and PERMISSION_DENIED
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
            #   require "google/cloud/bigquery/connection"
            #
            #   connection_client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)
            #
            #   # TODO: Initialize `resource`:
            #   resource = ''
            #
            #   # TODO: Initialize `policy`:
            #   policy = {}
            #   response = connection_client.set_iam_policy(resource, policy)

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

            # Returns permissions that a caller has on the specified resource.
            # If the resource does not exist, this will return an empty set of
            # permissions, not a NOT_FOUND error.
            #
            # Note: This operation is designed to be used for building permission-aware
            # UIs and command-line tools, not for authorization checking. This operation
            # may "fail open" without warning.
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
            #   require "google/cloud/bigquery/connection"
            #
            #   connection_client = Google::Cloud::Bigquery::Connection.new(version: :v1beta1)
            #
            #   # TODO: Initialize `resource`:
            #   resource = ''
            #
            #   # TODO: Initialize `permissions`:
            #   permissions = []
            #   response = connection_client.test_iam_permissions(resource, permissions)

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
          end
        end
      end
    end
  end
end
