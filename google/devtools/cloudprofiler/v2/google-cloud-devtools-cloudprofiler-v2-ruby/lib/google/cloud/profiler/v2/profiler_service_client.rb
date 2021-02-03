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
# https://github.com/googleapis/googleapis/blob/master/google/devtools/cloudprofiler/v2/profiler.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/devtools/cloudprofiler/v2/profiler_pb"
require "google/cloud/profiler/v2/credentials"

module Google
  module Cloud
    module Profiler
      module V2
        # Manage the collection of continuous profiling data provided by profiling
        # agents running in the cloud or by an offline provider of profiling data.
        #
        # General guidelines:
        # * Profiles for a single deployment must be created in ascending time order.
        # * Profiles can be created in either online or offline mode, see below.
        #
        # @!attribute [r] profiler_service_stub
        #   @return [Google::Devtools::Cloudprofiler::V2::ProfilerService::Stub]
        class ProfilerServiceClient
          attr_reader :profiler_service_stub

          # The default address of the service.
          SERVICE_ADDRESS = "cloudprofiler.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/monitoring",
            "https://www.googleapis.com/auth/monitoring.write"
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
            require "google/devtools/cloudprofiler/v2/profiler_services_pb"

            credentials ||= Google::Cloud::Profiler::V2::Credentials.default

            if credentials.is_a?(String) || credentials.is_a?(Hash)
              updater_proc = Google::Cloud::Profiler::V2::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-cloud-profiler'].version.version

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
              "profiler_service_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.devtools.cloudprofiler.v2.ProfilerService",
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
            @profiler_service_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Devtools::Cloudprofiler::V2::ProfilerService::Stub.method(:new)
            )

            @create_profile = Google::Gax.create_api_call(
              @profiler_service_stub.method(:create_profile),
              defaults["create_profile"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @create_offline_profile = Google::Gax.create_api_call(
              @profiler_service_stub.method(:create_offline_profile),
              defaults["create_offline_profile"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @update_profile = Google::Gax.create_api_call(
              @profiler_service_stub.method(:update_profile),
              defaults["update_profile"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'profile.name' => request.profile.name}
              end
            )
          end

          # Service calls

          # CreateProfile creates a new profile resource in the online mode.
          #
          # The server ensures that the new profiles are created at a constant rate per
          # deployment, so the creation request may hang for some time until the next
          # profile session is available.
          #
          # The request may fail with ABORTED error if the creation is not available
          # within ~1m, the response will indicate the duration of the backoff the
          # client should take before attempting creating a profile again. The backoff
          # duration is returned in google.rpc.RetryInfo extension on the response
          # status. To a gRPC client, the extension will be return as a
          # binary-serialized proto in the trailing metadata item named
          # "google.rpc.retryinfo-bin".
          #
          # @param parent [String]
          #   Parent project to create the profile in.
          # @param deployment [Google::Devtools::Cloudprofiler::V2::Deployment | Hash]
          #   Deployment details.
          #   A hash of the same form as `Google::Devtools::Cloudprofiler::V2::Deployment`
          #   can also be provided.
          # @param profile_type [Array<Google::Devtools::Cloudprofiler::V2::ProfileType>]
          #   One or more profile types that the agent is capable of providing.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Devtools::Cloudprofiler::V2::Profile]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Devtools::Cloudprofiler::V2::Profile]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/profiler"
          #
          #   profiler_client = Google::Cloud::Profiler.new(version: :v2)
          #   response = profiler_client.create_profile

          def create_profile \
              parent: nil,
              deployment: nil,
              profile_type: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              deployment: deployment,
              profile_type: profile_type
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Devtools::Cloudprofiler::V2::CreateProfileRequest)
            @create_profile.call(req, options, &block)
          end

          # CreateOfflineProfile creates a new profile resource in the offline mode.
          # The client provides the profile to create along with the profile bytes, the
          # server records it.
          #
          # @param parent [String]
          #   Parent project to create the profile in.
          # @param profile [Google::Devtools::Cloudprofiler::V2::Profile | Hash]
          #   Contents of the profile to create.
          #   A hash of the same form as `Google::Devtools::Cloudprofiler::V2::Profile`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Devtools::Cloudprofiler::V2::Profile]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Devtools::Cloudprofiler::V2::Profile]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/profiler"
          #
          #   profiler_client = Google::Cloud::Profiler.new(version: :v2)
          #   response = profiler_client.create_offline_profile

          def create_offline_profile \
              parent: nil,
              profile: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              profile: profile
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Devtools::Cloudprofiler::V2::CreateOfflineProfileRequest)
            @create_offline_profile.call(req, options, &block)
          end

          # UpdateProfile updates the profile bytes and labels on the profile resource
          # created in the online mode. Updating the bytes for profiles created in the
          # offline mode is currently not supported: the profile content must be
          # provided at the time of the profile creation.
          #
          # @param profile [Google::Devtools::Cloudprofiler::V2::Profile | Hash]
          #   Profile to update
          #   A hash of the same form as `Google::Devtools::Cloudprofiler::V2::Profile`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Field mask used to specify the fields to be overwritten. Currently only
          #   profile_bytes and labels fields are supported by UpdateProfile, so only
          #   those fields can be specified in the mask. When no mask is provided, all
          #   fields are overwritten.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Devtools::Cloudprofiler::V2::Profile]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Devtools::Cloudprofiler::V2::Profile]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/profiler"
          #
          #   profiler_client = Google::Cloud::Profiler.new(version: :v2)
          #   response = profiler_client.update_profile

          def update_profile \
              profile: nil,
              update_mask: nil,
              options: nil,
              &block
            req = {
              profile: profile,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Devtools::Cloudprofiler::V2::UpdateProfileRequest)
            @update_profile.call(req, options, &block)
          end
        end
      end
    end
  end
end
