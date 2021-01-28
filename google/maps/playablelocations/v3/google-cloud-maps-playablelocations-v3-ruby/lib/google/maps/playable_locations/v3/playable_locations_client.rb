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
# https://github.com/googleapis/googleapis/blob/master/google/maps/playablelocations/v3/playablelocations.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/maps/playablelocations/v3/playablelocations_pb"
require "google/maps/playable_locations/v3/credentials"

module Google
  module Maps
    module PlayableLocations
      module V3
        # The Playable Locations API for v3.
        #
        # @!attribute [r] playable_locations_stub
        #   @return [Google::Maps::Playablelocations::V3::PlayableLocations::Stub]
        class PlayableLocationsClient
          attr_reader :playable_locations_stub

          # The default address of the service.
          SERVICE_ADDRESS = "playablelocations.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
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
            require "google/maps/playablelocations/v3/playablelocations_services_pb"

            credentials ||= Google::Maps::PlayableLocations::V3::Credentials.default

            if credentials.is_a?(String) || credentials.is_a?(Hash)
              updater_proc = Google::Maps::PlayableLocations::V3::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-maps-playable_locations'].version.version

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
              "playable_locations_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.maps.playablelocations.v3.PlayableLocations",
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
            @playable_locations_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Maps::Playablelocations::V3::PlayableLocations::Stub.method(:new)
            )

            @sample_playable_locations = Google::Gax.create_api_call(
              @playable_locations_stub.method(:sample_playable_locations),
              defaults["sample_playable_locations"],
              exception_transformer: exception_transformer
            )
            @log_player_reports = Google::Gax.create_api_call(
              @playable_locations_stub.method(:log_player_reports),
              defaults["log_player_reports"],
              exception_transformer: exception_transformer
            )
            @log_impressions = Google::Gax.create_api_call(
              @playable_locations_stub.method(:log_impressions),
              defaults["log_impressions"],
              exception_transformer: exception_transformer
            )
          end

          # Service calls

          # Returns a set of playable locations that lie within a specified area,
          # that satisfy optional filter criteria.
          #
          # Note: Identical `SamplePlayableLocations` requests can return different
          # results as the state of the world changes over time.
          #
          # @param area_filter [Google::Maps::Playablelocations::V3::Sample::AreaFilter | Hash]
          #   Required. Specifies the area to search within for playable locations.
          #   A hash of the same form as `Google::Maps::Playablelocations::V3::Sample::AreaFilter`
          #   can also be provided.
          # @param criteria [Array<Google::Maps::Playablelocations::V3::Sample::Criterion | Hash>]
          #   Required. Specifies one or more (up to 5) criteria for filtering the
          #   returned playable locations.
          #   A hash of the same form as `Google::Maps::Playablelocations::V3::Sample::Criterion`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Maps::Playablelocations::V3::SamplePlayableLocationsResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Maps::Playablelocations::V3::SamplePlayableLocationsResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/maps/playable_locations"
          #
          #   playable_locations_client = Google::Maps::PlayableLocations.new(version: :v3)
          #
          #   # TODO: Initialize `area_filter`:
          #   area_filter = {}
          #
          #   # TODO: Initialize `criteria`:
          #   criteria = []
          #   response = playable_locations_client.sample_playable_locations(area_filter, criteria)

          def sample_playable_locations \
              area_filter,
              criteria,
              options: nil,
              &block
            req = {
              area_filter: area_filter,
              criteria: criteria
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Maps::Playablelocations::V3::SamplePlayableLocationsRequest)
            @sample_playable_locations.call(req, options, &block)
          end

          # Logs bad playable location reports submitted by players.
          #
          # Reports are not partially saved; either all reports are saved and this
          # request succeeds, or no reports are saved, and this request fails.
          #
          # @param player_reports [Array<Google::Maps::Playablelocations::V3::PlayerReport | Hash>]
          #   Required. Player reports. The maximum number of player reports that you can log at
          #   once is 50.
          #   A hash of the same form as `Google::Maps::Playablelocations::V3::PlayerReport`
          #   can also be provided.
          # @param request_id [String]
          #   Required. A string that uniquely identifies the log player reports request. This
          #   allows you to detect duplicate requests. We recommend that you use UUIDs
          #   for this value. The value must not exceed 50 characters.
          #
          #   You should reuse the `request_id` only when retrying a request in the case
          #   of a failure. In that case, the request must be identical to the one that
          #   failed.
          # @param client_info [Google::Maps::Unity::ClientInfo | Hash]
          #   Required. Information about the client device (for example, device model and
          #   operating system).
          #   A hash of the same form as `Google::Maps::Unity::ClientInfo`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Maps::Playablelocations::V3::LogPlayerReportsResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Maps::Playablelocations::V3::LogPlayerReportsResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/maps/playable_locations"
          #
          #   playable_locations_client = Google::Maps::PlayableLocations.new(version: :v3)
          #
          #   # TODO: Initialize `player_reports`:
          #   player_reports = []
          #
          #   # TODO: Initialize `request_id`:
          #   request_id = ''
          #
          #   # TODO: Initialize `client_info`:
          #   client_info = {}
          #   response = playable_locations_client.log_player_reports(player_reports, request_id, client_info)

          def log_player_reports \
              player_reports,
              request_id,
              client_info,
              options: nil,
              &block
            req = {
              player_reports: player_reports,
              request_id: request_id,
              client_info: client_info
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Maps::Playablelocations::V3::LogPlayerReportsRequest)
            @log_player_reports.call(req, options, &block)
          end

          # Logs new events when playable locations are displayed, and when they are
          # interacted with.
          #
          # Impressions are not partially saved; either all impressions are saved and
          # this request succeeds, or no impressions are saved, and this request fails.
          #
          # @param impressions [Array<Google::Maps::Playablelocations::V3::Impression | Hash>]
          #   Required. Impression event details. The maximum number of impression reports that you
          #   can log at once is 50.
          #   A hash of the same form as `Google::Maps::Playablelocations::V3::Impression`
          #   can also be provided.
          # @param request_id [String]
          #   Required. A string that uniquely identifies the log impressions request. This allows
          #   you to detect duplicate requests. We recommend that you use UUIDs for this
          #   value. The value must not exceed 50 characters.
          #
          #   You should reuse the `request_id` only when retrying a request in case of
          #   failure. In this case, the request must be identical to the one that
          #   failed.
          # @param client_info [Google::Maps::Unity::ClientInfo | Hash]
          #   Required. Information about the client device. For example, device model and
          #   operating system.
          #   A hash of the same form as `Google::Maps::Unity::ClientInfo`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Maps::Playablelocations::V3::LogImpressionsResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Maps::Playablelocations::V3::LogImpressionsResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/maps/playable_locations"
          #
          #   playable_locations_client = Google::Maps::PlayableLocations.new(version: :v3)
          #
          #   # TODO: Initialize `impressions`:
          #   impressions = []
          #
          #   # TODO: Initialize `request_id`:
          #   request_id = ''
          #
          #   # TODO: Initialize `client_info`:
          #   client_info = {}
          #   response = playable_locations_client.log_impressions(impressions, request_id, client_info)

          def log_impressions \
              impressions,
              request_id,
              client_info,
              options: nil,
              &block
            req = {
              impressions: impressions,
              request_id: request_id,
              client_info: client_info
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Maps::Playablelocations::V3::LogImpressionsRequest)
            @log_impressions.call(req, options, &block)
          end
        end
      end
    end
  end
end
