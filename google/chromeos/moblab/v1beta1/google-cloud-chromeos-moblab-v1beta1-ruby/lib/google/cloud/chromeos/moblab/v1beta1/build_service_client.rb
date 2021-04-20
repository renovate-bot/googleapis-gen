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
# https://github.com/googleapis/googleapis/blob/master/google/chromeos/moblab/v1beta1/build_service.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"
require "google/gax/operation"
require "google/longrunning/operations_client"

require "google/chromeos/moblab/v1beta1/build_service_pb"
require "google/cloud/chromeos/moblab/v1beta1/credentials"

module Google
  module Cloud
    module Chromeos
      module Moblab
        module V1beta1
          # Manages Chrome OS build services.
          #
          # @!attribute [r] build_service_stub
          #   @return [Google::Chromeos::Moblab::V1beta1::BuildService::Stub]
          class BuildServiceClient
            attr_reader :build_service_stub

            # The default address of the service.
            SERVICE_ADDRESS = "chromeosmoblab.googleapis.com".freeze

            # The default port of the service.
            DEFAULT_SERVICE_PORT = 443

            # The default set of gRPC interceptors.
            GRPC_INTERCEPTORS = []

            DEFAULT_TIMEOUT = 30

            PAGE_DESCRIPTORS = {
              "list_builds" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "builds")
            }.freeze

            private_constant :PAGE_DESCRIPTORS

            # The scopes needed to make gRPC calls to all of the methods defined in
            # this service.
            ALL_SCOPES = [
              "https://www.googleapis.com/auth/moblabapi"
            ].freeze

            class OperationsClient < Google::Longrunning::OperationsClient
              self::SERVICE_ADDRESS = BuildServiceClient::SERVICE_ADDRESS
              self::GRPC_INTERCEPTORS = BuildServiceClient::GRPC_INTERCEPTORS
            end

            BUILD_ARTIFACT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "buildTargets/{build_target}/models/{model}/builds/{build}/artifacts/{artifact}"
            )

            private_constant :BUILD_ARTIFACT_PATH_TEMPLATE

            MODEL_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "buildTargets/{build_target}/models/{model}"
            )

            private_constant :MODEL_PATH_TEMPLATE

            # Returns a fully-qualified build_artifact resource name string.
            # @param build_target [String]
            # @param model [String]
            # @param build [String]
            # @param artifact [String]
            # @return [String]
            def self.build_artifact_path build_target, model, build, artifact
              BUILD_ARTIFACT_PATH_TEMPLATE.render(
                :"build_target" => build_target,
                :"model" => model,
                :"build" => build,
                :"artifact" => artifact
              )
            end

            # Returns a fully-qualified model resource name string.
            # @param build_target [String]
            # @param model [String]
            # @return [String]
            def self.model_path build_target, model
              MODEL_PATH_TEMPLATE.render(
                :"build_target" => build_target,
                :"model" => model
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
              require "google/chromeos/moblab/v1beta1/build_service_services_pb"

              credentials ||= Google::Cloud::Chromeos::Moblab::V1beta1::Credentials.default

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
                updater_proc = Google::Cloud::Chromeos::Moblab::V1beta1::Credentials.new(credentials).updater_proc
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

              package_version = Gem.loaded_specs['google-cloud-chromeos-moblab'].version.version

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
                "build_service_client_config.json"
              )
              defaults = client_config_file.open do |f|
                Google::Gax.construct_settings(
                  "google.chromeos.moblab.v1beta1.BuildService",
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
              @build_service_stub = Google::Gax::Grpc.create_stub(
                service_path,
                port,
                chan_creds: chan_creds,
                channel: channel,
                updater_proc: updater_proc,
                scopes: scopes,
                interceptors: interceptors,
                &Google::Chromeos::Moblab::V1beta1::BuildService::Stub.method(:new)
              )

              @list_builds = Google::Gax.create_api_call(
                @build_service_stub.method(:list_builds),
                defaults["list_builds"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @check_build_stage_status = Google::Gax.create_api_call(
                @build_service_stub.method(:check_build_stage_status),
                defaults["check_build_stage_status"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @stage_build = Google::Gax.create_api_call(
                @build_service_stub.method(:stage_build),
                defaults["stage_build"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
            end

            # Service calls

            # Lists all builds for the given build target and model in descending order
            # for the milestones and build versions.
            #
            # @param parent [String]
            #   Required. The full resource name of the model. The model id is the same as
            #   the build target id for non-unified builds.
            #   For example,
            #   'buildTargets/octopus/models/bobba'.
            # @param page_size [Integer]
            #   The maximum number of resources contained in the underlying API
            #   response. If page streaming is performed per-resource, this
            #   parameter does not affect the return value. If page streaming is
            #   performed per-page, this determines the maximum number of
            #   resources in a page.
            # @param filter [String]
            #   Optional. Filter that specifies value constraints of fields. For example, the
            #   filter can be set as "filter='milestone=milestones/80'" to only select
            #   builds in milestone 80.
            # @param read_mask [Google::Protobuf::FieldMask | Hash]
            #   Optional. Read mask that specifies which Build fields to return. If empty, all Build
            #   fields will be returned.
            #   Valid fields: name, milestone, build_version.
            #   For example, if the read_mask is set as "read_mask='milestone'", the
            #   ListBuilds will return a list of Builds object with only the milestone
            #   field.
            #   A hash of the same form as `Google::Protobuf::FieldMask`
            #   can also be provided.
            # @param group_by [Google::Protobuf::FieldMask | Hash]
            #   Optional. The operation that groups by all the Build fields specified in the read
            #   mask. The group_by field should be the same as the read_mask field in
            #   convention of SQL.
            #   A hash of the same form as `Google::Protobuf::FieldMask`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Chromeos::Moblab::V1beta1::Build>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Chromeos::Moblab::V1beta1::Build>]
            #   An enumerable of Google::Chromeos::Moblab::V1beta1::Build instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/chromeos/moblab"
            #
            #   build_client = Google::Cloud::Chromeos::Moblab.new(version: :v1beta1)
            #   formatted_parent = Google::Cloud::Chromeos::Moblab::V1beta1::BuildServiceClient.model_path("[BUILD_TARGET]", "[MODEL]")
            #
            #   # Iterate over all results.
            #   build_client.list_builds(formatted_parent).each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   build_client.list_builds(formatted_parent).each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_builds \
                parent,
                page_size: nil,
                filter: nil,
                read_mask: nil,
                group_by: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                page_size: page_size,
                filter: filter,
                read_mask: read_mask,
                group_by: group_by
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Chromeos::Moblab::V1beta1::ListBuildsRequest)
              @list_builds.call(req, options, &block)
            end

            # Checks the stage status for a given build artifact in a partner Google
            # Cloud Storage bucket.
            #
            # @param name [String]
            #   Required. The full resource name of the build artifact.
            #   For example,
            #   'buildTargets/octopus/models/bobba/builds/12607.6.0/artifacts/chromeos-moblab-peng-staging'.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Chromeos::Moblab::V1beta1::CheckBuildStageStatusResponse]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Chromeos::Moblab::V1beta1::CheckBuildStageStatusResponse]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/chromeos/moblab"
            #
            #   build_client = Google::Cloud::Chromeos::Moblab.new(version: :v1beta1)
            #   formatted_name = Google::Cloud::Chromeos::Moblab::V1beta1::BuildServiceClient.build_artifact_path("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]")
            #   response = build_client.check_build_stage_status(formatted_name)

            def check_build_stage_status \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Chromeos::Moblab::V1beta1::CheckBuildStageStatusRequest)
              @check_build_stage_status.call(req, options, &block)
            end

            # Stages a given build artifact from a internal Google Cloud Storage bucket
            # to a partner Google Cloud Storage bucket. If any of objects has already
            # been copied, it will overwrite the previous objects. Operation <response:
            # {Google::Chromeos::Moblab::V1beta1::StageBuildResponse StageBuildResponse},
            #            metadata: {Google::Chromeos::Moblab::V1beta1::StageBuildMetadata StageBuildMetadata}>
            #
            # @param name [String]
            #   Required. The full resource name of the build artifact.
            #   For example,
            #   'buildTargets/octopus/models/bobba/builds/12607.6.0/artifacts/chromeos-moblab-peng-staging'.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @return [Google::Gax::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/chromeos/moblab"
            #
            #   build_client = Google::Cloud::Chromeos::Moblab.new(version: :v1beta1)
            #   formatted_name = Google::Cloud::Chromeos::Moblab::V1beta1::BuildServiceClient.build_artifact_path("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]")
            #
            #   # Register a callback during the method call.
            #   operation = build_client.stage_build(formatted_name) do |op|
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

            def stage_build \
                name,
                options: nil
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Chromeos::Moblab::V1beta1::StageBuildRequest)
              operation = Google::Gax::Operation.new(
                @stage_build.call(req, options),
                @operations_client,
                Google::Chromeos::Moblab::V1beta1::StageBuildResponse,
                Google::Chromeos::Moblab::V1beta1::StageBuildMetadata,
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
end
