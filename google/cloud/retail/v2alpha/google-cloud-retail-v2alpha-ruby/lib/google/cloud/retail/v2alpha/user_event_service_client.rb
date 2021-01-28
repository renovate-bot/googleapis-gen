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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/retail/v2alpha/user_event_service.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"
require "google/gax/operation"
require "google/longrunning/operations_client"

require "google/cloud/retail/v2alpha/user_event_service_pb"
require "google/cloud/retail/v2alpha/credentials"

module Google
  module Cloud
    module Retail
      module V2alpha
        # Service for ingesting end user actions on the customer website.
        #
        # @!attribute [r] user_event_service_stub
        #   @return [Google::Cloud::Retail::V2alpha::UserEventService::Stub]
        class UserEventServiceClient
          attr_reader :user_event_service_stub

          # The default address of the service.
          SERVICE_ADDRESS = "retail.googleapis.com".freeze

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

          class OperationsClient < Google::Longrunning::OperationsClient
            self::SERVICE_ADDRESS = UserEventServiceClient::SERVICE_ADDRESS
            self::GRPC_INTERCEPTORS = UserEventServiceClient::GRPC_INTERCEPTORS
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
            require "google/cloud/retail/v2alpha/user_event_service_services_pb"

            credentials ||= Google::Cloud::Retail::V2alpha::Credentials.default

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
              updater_proc = Google::Cloud::Retail::V2alpha::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-cloud-retail'].version.version

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
              "user_event_service_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.retail.v2alpha.UserEventService",
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
            @user_event_service_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Retail::V2alpha::UserEventService::Stub.method(:new)
            )

            @write_user_event = Google::Gax.create_api_call(
              @user_event_service_stub.method(:write_user_event),
              defaults["write_user_event"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @collect_user_event = Google::Gax.create_api_call(
              @user_event_service_stub.method(:collect_user_event),
              defaults["collect_user_event"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @purge_user_events = Google::Gax.create_api_call(
              @user_event_service_stub.method(:purge_user_events),
              defaults["purge_user_events"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @import_user_events = Google::Gax.create_api_call(
              @user_event_service_stub.method(:import_user_events),
              defaults["import_user_events"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @rejoin_user_events = Google::Gax.create_api_call(
              @user_event_service_stub.method(:rejoin_user_events),
              defaults["rejoin_user_events"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
          end

          # Service calls

          # Writes a single user event.
          #
          # @param parent [String]
          #   Required. The parent catalog resource name, such as
          #   "projects/1234/locations/global/catalogs/default_catalog".
          # @param user_event [Google::Cloud::Retail::V2alpha::UserEvent | Hash]
          #   Required. User event to write.
          #   A hash of the same form as `Google::Cloud::Retail::V2alpha::UserEvent`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Retail::V2alpha::UserEvent]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Retail::V2alpha::UserEvent]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/retail"
          #
          #   user_event_client = Google::Cloud::Retail::V2alpha::UserEvent.new(version: :v2alpha)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #
          #   # TODO: Initialize `user_event`:
          #   user_event = {}
          #   response = user_event_client.write_user_event(parent, user_event)

          def write_user_event \
              parent,
              user_event,
              options: nil,
              &block
            req = {
              parent: parent,
              user_event: user_event
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Retail::V2alpha::WriteUserEventRequest)
            @write_user_event.call(req, options, &block)
          end

          # Writes a single user event from the browser. This uses a GET request to
          # due to browser restriction of POST-ing to a 3rd party domain.
          #
          # This method is used only by the Retail API JavaScript pixel and Google Tag
          # Manager. Users should not call this method directly.
          #
          # @param parent [String]
          #   Required. The parent catalog name, such as
          #   "projects/1234/locations/global/catalogs/default_catalog".
          # @param user_event [String]
          #   Required. URL encoded UserEvent proto with a length limit of 2,000,000
          #   characters.
          # @param uri [String]
          #   The URL including cgi-parameters but excluding the hash fragment with a
          #   length limit of 5,000 characters. This is often more useful than the
          #   referer URL, because many browsers only send the domain for 3rd party
          #   requests.
          # @param ets [Integer]
          #   The event timestamp in milliseconds. This prevents browser caching of
          #   otherwise identical get requests. The name is abbreviated to reduce the
          #   payload bytes.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Api::HttpBody]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Api::HttpBody]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/retail"
          #
          #   user_event_client = Google::Cloud::Retail::V2alpha::UserEvent.new(version: :v2alpha)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #
          #   # TODO: Initialize `user_event`:
          #   user_event = ''
          #   response = user_event_client.collect_user_event(parent, user_event)

          def collect_user_event \
              parent,
              user_event,
              uri: nil,
              ets: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              user_event: user_event,
              uri: uri,
              ets: ets
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Retail::V2alpha::CollectUserEventRequest)
            @collect_user_event.call(req, options, &block)
          end

          # Deletes permanently all user events specified by the filter provided.
          # Depending on the number of events specified by the filter, this operation
          # could take hours or days to complete. To test a filter, use the list
          # command first.
          #
          # @param parent [String]
          #   Required. The resource name of the catalog under which the events are
          #   created. The format is
          #   "projects/${projectId}/locations/global/catalogs/${catalogId}"
          # @param filter [String]
          #   Required. The filter string to specify the events to be deleted with a
          #   length limit of 5,000 characters. Empty string filter is not allowed. The
          #   eligible fields for filtering are:
          #
          #   * `eventType`: Double quoted
          #     {Google::Cloud::Retail::V2alpha::UserEvent#event_type UserEvent#event_type}
          #     string.
          #   * `eventTime`: in ISO 8601 "zulu" format.
          #   * `visitorId`: Double quoted string. Specifying this will delete all
          #     events associated with a visitor.
          #   * `userId`: Double quoted string. Specifying this will delete all events
          #     associated with a user.
          #
          #   Examples:
          #
          #   * Deleting all events in a time range:
          #     `eventTime > "2012-04-23T18:25:43.511Z"
          #     eventTime < "2012-04-23T18:30:43.511Z"`
          #   * Deleting specific eventType in time range:
          #     `eventTime > "2012-04-23T18:25:43.511Z" eventType = "detail-page-view"`
          #   * Deleting all events for a specific visitor:
          #     `visitorId = "visitor1024"`
          #
          #   The filtering fields are assumed to have an implicit AND.
          # @param force [true, false]
          #   Actually perform the purge.
          #   If `force` is set to false, the method will return the expected purge count
          #   without deleting any user events.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/retail"
          #
          #   user_event_client = Google::Cloud::Retail::V2alpha::UserEvent.new(version: :v2alpha)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #
          #   # TODO: Initialize `filter`:
          #   filter = ''
          #
          #   # Register a callback during the method call.
          #   operation = user_event_client.purge_user_events(parent, filter) do |op|
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

          def purge_user_events \
              parent,
              filter,
              force: nil,
              options: nil
            req = {
              parent: parent,
              filter: filter,
              force: force
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Retail::V2alpha::PurgeUserEventsRequest)
            operation = Google::Gax::Operation.new(
              @purge_user_events.call(req, options),
              @operations_client,
              Google::Cloud::Retail::V2alpha::PurgeUserEventsResponse,
              Google::Cloud::Retail::V2alpha::PurgeMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Bulk import of User events. Request processing might be
          # synchronous. Events that already exist are skipped.
          # Use this method for backfilling historical user events.
          #
          # Operation.response is of type ImportResponse. Note that it is
          # possible for a subset of the items to be successfully inserted.
          # Operation.metadata is of type ImportMetadata.
          #
          # @param parent [String]
          #   Required. "projects/1234/locations/global/catalogs/default_catalog"
          # @param input_config [Google::Cloud::Retail::V2alpha::UserEventInputConfig | Hash]
          #   Required. The desired input location of the data.
          #   A hash of the same form as `Google::Cloud::Retail::V2alpha::UserEventInputConfig`
          #   can also be provided.
          # @param errors_config [Google::Cloud::Retail::V2alpha::ImportErrorsConfig | Hash]
          #   The desired location of errors incurred during the Import. Cannot be set
          #   for inline user event imports.
          #   A hash of the same form as `Google::Cloud::Retail::V2alpha::ImportErrorsConfig`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/retail"
          #
          #   user_event_client = Google::Cloud::Retail::V2alpha::UserEvent.new(version: :v2alpha)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #
          #   # TODO: Initialize `input_config`:
          #   input_config = {}
          #
          #   # Register a callback during the method call.
          #   operation = user_event_client.import_user_events(parent, input_config) do |op|
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

          def import_user_events \
              parent,
              input_config,
              errors_config: nil,
              options: nil
            req = {
              parent: parent,
              input_config: input_config,
              errors_config: errors_config
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Retail::V2alpha::ImportUserEventsRequest)
            operation = Google::Gax::Operation.new(
              @import_user_events.call(req, options),
              @operations_client,
              Google::Cloud::Retail::V2alpha::ImportUserEventsResponse,
              Google::Cloud::Retail::V2alpha::ImportMetadata,
              call_options: options
            )
            operation.on_done { |operation| yield(operation) } if block_given?
            operation
          end

          # Triggers a user event rejoin operation with latest product catalog. Events
          # will not be annotated with detailed product information if product is
          # missing from the catalog at the time the user event is ingested, and these
          # events are stored as unjoined events with a limited usage on training and
          # serving. This API can be used to trigger a 'join' operation on specified
          # events with latest version of product catalog. It can also be used to
          # correct events joined with wrong product catalog.
          #
          # @param parent [String]
          #   Required. The parent catalog resource name, such as
          #   "projects/1234/locations/global/catalogs/default_catalog".
          # @param user_event_rejoin_scope [Google::Cloud::Retail::V2alpha::RejoinUserEventsRequest::UserEventRejoinScope]
          #   The type of the user event rejoin to define the scope and range of the user
          #   events to be rejoined with the latest product catalog. Defaults to
          #   USER_EVENT_REJOIN_SCOPE_UNSPECIFIED if this field is not set, or set to an
          #   invalid integer value.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Google::Gax::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/retail"
          #
          #   user_event_client = Google::Cloud::Retail::V2alpha::UserEvent.new(version: :v2alpha)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #
          #   # Register a callback during the method call.
          #   operation = user_event_client.rejoin_user_events(parent) do |op|
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

          def rejoin_user_events \
              parent,
              user_event_rejoin_scope: nil,
              options: nil
            req = {
              parent: parent,
              user_event_rejoin_scope: user_event_rejoin_scope
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Retail::V2alpha::RejoinUserEventsRequest)
            operation = Google::Gax::Operation.new(
              @rejoin_user_events.call(req, options),
              @operations_client,
              Google::Cloud::Retail::V2alpha::RejoinUserEventsResponse,
              Google::Cloud::Retail::V2alpha::RejoinUserEventsMetadata,
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
