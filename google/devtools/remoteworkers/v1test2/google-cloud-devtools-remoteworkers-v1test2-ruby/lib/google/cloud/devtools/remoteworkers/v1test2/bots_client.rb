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
# https://github.com/googleapis/googleapis/blob/master/google/devtools/remoteworkers/v1test2/bots.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/devtools/remoteworkers/v1test2/bots_pb"
require "google/cloud/devtools/remoteworkers/v1test2/credentials"

module Google
  module Cloud
    module Devtools
      module Remoteworkers
        module V1test2
          # Design doc: https://goo.gl/oojM5H
          #
          # Loosely speaking, the Bots interface monitors a collection of workers (think
          # of them as "computers" for a moment). This collection is known as a "farm,"
          # and its purpose is to perform work on behalf of a client.
          #
          # Each worker runs a small program known as a "bot" that allows it to be
          # controlled by the server. This interface contains only methods that are
          # called by the bots themselves; admin functionality is out of scope for this
          # interface.
          #
          # More precisely, we use the term "worker" to refer to the physical "thing"
          # running the bot. We use the term "worker," and not "machine" or "computer,"
          # since a worker may consist of more than one machine - e.g., a computer with
          # multiple attached devices, or even a cluster of computers, with only one of
          # them running the bot. Conversely, a single machine may host several bots, in
          # which case each bot has a "worker" corresponding to the slice of the machine
          # being managed by that bot.
          #
          # The main resource in the Bots interface is not, surprisingly, a Bot - it is a
          # BotSession, which represents a period of time in which a bot is in continuous
          # contact with the server (see the BotSession message for more information).
          # The parent of a bot session can be thought of as an instance of a farm. That
          # is, one endpoint may be able to manage many farms for many users. For
          # example, for a farm managed through GCP, the parent resource will typically
          # take the form "projects/{project_id}". This is referred to below as "the farm
          # resource."
          #
          # @!attribute [r] bots_stub
          #   @return [Google::Devtools::Remoteworkers::V1test2::Bots::Stub]
          class BotsClient
            attr_reader :bots_stub

            # The default address of the service.
            SERVICE_ADDRESS = "remoteworkers.googleapis.com".freeze

            # The default port of the service.
            DEFAULT_SERVICE_PORT = 443

            # The default set of gRPC interceptors.
            GRPC_INTERCEPTORS = []

            DEFAULT_TIMEOUT = 30

            # The scopes needed to make gRPC calls to all of the methods defined in
            # this service.
            ALL_SCOPES = [
            ].freeze


            BOT_SESSION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "{unknown_path=**}/botSessions/{bot_session}"
            )

            private_constant :BOT_SESSION_PATH_TEMPLATE

            # Returns a fully-qualified bot_session resource name string.
            # @param unknown_path [String]
            # @param bot_session [String]
            # @return [String]
            def self.bot_session_path unknown_path, bot_session
              BOT_SESSION_PATH_TEMPLATE.render(
                :"unknown_path" => unknown_path,
                :"bot_session" => bot_session
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
              require "google/devtools/remoteworkers/v1test2/bots_services_pb"

              credentials ||= Google::Cloud::Devtools::Remoteworkers::V1test2::Credentials.default

              if credentials.is_a?(String) || credentials.is_a?(Hash)
                updater_proc = Google::Cloud::Devtools::Remoteworkers::V1test2::Credentials.new(credentials).updater_proc
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

              package_version = Gem.loaded_specs['google-cloud-devtools-remoteworkers'].version.version

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
                "bots_client_config.json"
              )
              defaults = client_config_file.open do |f|
                Google::Gax.construct_settings(
                  "google.devtools.remoteworkers.v1test2.Bots",
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
              @bots_stub = Google::Gax::Grpc.create_stub(
                service_path,
                port,
                chan_creds: chan_creds,
                channel: channel,
                updater_proc: updater_proc,
                scopes: scopes,
                interceptors: interceptors,
                &Google::Devtools::Remoteworkers::V1test2::Bots::Stub.method(:new)
              )

              @create_bot_session = Google::Gax.create_api_call(
                @bots_stub.method(:create_bot_session),
                defaults["create_bot_session"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @update_bot_session = Google::Gax.create_api_call(
                @bots_stub.method(:update_bot_session),
                defaults["update_bot_session"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
            end

            # Service calls

            # CreateBotSession is called when the bot first joins the farm, and
            # establishes a session ID to ensure that multiple machines do not register
            # using the same name accidentally.
            #
            # @param parent [String]
            #   Required. The farm resource.
            # @param bot_session [Google::Devtools::Remoteworkers::V1test2::BotSession | Hash]
            #   Required. The bot session to create. Server-assigned fields like name must be unset.
            #   A hash of the same form as `Google::Devtools::Remoteworkers::V1test2::BotSession`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Devtools::Remoteworkers::V1test2::BotSession]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Devtools::Remoteworkers::V1test2::BotSession]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/devtools/remoteworkers/v1test2"
            #
            #   bots_client = Google::Cloud::Devtools::Remoteworkers::V1test2.new(version: :v1test2)
            #
            #   # TODO: Initialize `parent`:
            #   parent = ''
            #
            #   # TODO: Initialize `bot_session`:
            #   bot_session = {}
            #   response = bots_client.create_bot_session(parent, bot_session)

            def create_bot_session \
                parent,
                bot_session,
                options: nil,
                &block
              req = {
                parent: parent,
                bot_session: bot_session
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Devtools::Remoteworkers::V1test2::CreateBotSessionRequest)
              @create_bot_session.call(req, options, &block)
            end

            # UpdateBotSession must be called periodically by the bot (on a schedule
            # determined by the server) to let the server know about its status, and to
            # pick up new lease requests from the server.
            #
            # @param name [String]
            #   Required. The bot session name. Must match bot_session.name.
            # @param bot_session [Google::Devtools::Remoteworkers::V1test2::BotSession | Hash]
            #   Required. The bot session resource to update.
            #   A hash of the same form as `Google::Devtools::Remoteworkers::V1test2::BotSession`
            #   can also be provided.
            # @param update_mask [Google::Protobuf::FieldMask | Hash]
            #   Required. The fields on the bot that should be updated. See the BotSession resource
            #   for which fields are updatable by which caller.
            #   A hash of the same form as `Google::Protobuf::FieldMask`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Devtools::Remoteworkers::V1test2::BotSession]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Devtools::Remoteworkers::V1test2::BotSession]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/devtools/remoteworkers/v1test2"
            #
            #   bots_client = Google::Cloud::Devtools::Remoteworkers::V1test2.new(version: :v1test2)
            #   formatted_name = Google::Cloud::Devtools::Remoteworkers::V1test2::BotsClient.bot_session_path("[UNKNOWN_PATH]", "[BOT_SESSION]")
            #
            #   # TODO: Initialize `bot_session`:
            #   bot_session = {}
            #
            #   # TODO: Initialize `update_mask`:
            #   update_mask = {}
            #   response = bots_client.update_bot_session(formatted_name, bot_session, update_mask)

            def update_bot_session \
                name,
                bot_session,
                update_mask,
                options: nil,
                &block
              req = {
                name: name,
                bot_session: bot_session,
                update_mask: update_mask
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Devtools::Remoteworkers::V1test2::UpdateBotSessionRequest)
              @update_bot_session.call(req, options, &block)
            end
          end
        end
      end
    end
  end
end
