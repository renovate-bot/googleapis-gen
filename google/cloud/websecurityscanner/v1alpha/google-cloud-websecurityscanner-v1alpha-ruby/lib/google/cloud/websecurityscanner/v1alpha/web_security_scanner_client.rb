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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/websecurityscanner/v1alpha/web_security_scanner.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/websecurityscanner/v1alpha/web_security_scanner_pb"
require "google/cloud/websecurityscanner/v1alpha/credentials"

module Google
  module Cloud
    module Websecurityscanner
      module V1alpha
        # Cloud Web Security Scanner Service identifies security vulnerabilities in web
        # applications hosted on Google Cloud Platform. It crawls your application, and
        # attempts to exercise as many user inputs and event handlers as possible.
        #
        # @!attribute [r] web_security_scanner_stub
        #   @return [Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub]
        class WebSecurityScannerClient
          attr_reader :web_security_scanner_stub

          # The default address of the service.
          SERVICE_ADDRESS = "websecurityscanner.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_scan_configs" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "scan_configs"),
            "list_scan_runs" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "scan_runs"),
            "list_crawled_urls" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "crawled_urls"),
            "list_findings" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "findings")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform"
          ].freeze


          FINDING_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/scanConfigs/{scan_config}/scanRuns/{scan_run}/findings/{finding}"
          )

          private_constant :FINDING_PATH_TEMPLATE

          PROJECT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}"
          )

          private_constant :PROJECT_PATH_TEMPLATE

          SCAN_CONFIG_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/scanConfigs/{scan_config}"
          )

          private_constant :SCAN_CONFIG_PATH_TEMPLATE

          SCAN_RUN_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/scanConfigs/{scan_config}/scanRuns/{scan_run}"
          )

          private_constant :SCAN_RUN_PATH_TEMPLATE

          # Returns a fully-qualified finding resource name string.
          # @param project [String]
          # @param scan_config [String]
          # @param scan_run [String]
          # @param finding [String]
          # @return [String]
          def self.finding_path project, scan_config, scan_run, finding
            FINDING_PATH_TEMPLATE.render(
              :"project" => project,
              :"scan_config" => scan_config,
              :"scan_run" => scan_run,
              :"finding" => finding
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

          # Returns a fully-qualified scan_config resource name string.
          # @param project [String]
          # @param scan_config [String]
          # @return [String]
          def self.scan_config_path project, scan_config
            SCAN_CONFIG_PATH_TEMPLATE.render(
              :"project" => project,
              :"scan_config" => scan_config
            )
          end

          # Returns a fully-qualified scan_run resource name string.
          # @param project [String]
          # @param scan_config [String]
          # @param scan_run [String]
          # @return [String]
          def self.scan_run_path project, scan_config, scan_run
            SCAN_RUN_PATH_TEMPLATE.render(
              :"project" => project,
              :"scan_config" => scan_config,
              :"scan_run" => scan_run
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
            require "google/cloud/websecurityscanner/v1alpha/web_security_scanner_services_pb"

            credentials ||= Google::Cloud::Websecurityscanner::V1alpha::Credentials.default

            if credentials.is_a?(String) || credentials.is_a?(Hash)
              updater_proc = Google::Cloud::Websecurityscanner::V1alpha::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-cloud-websecurityscanner'].version.version

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
              "web_security_scanner_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.websecurityscanner.v1alpha.WebSecurityScanner",
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
            @web_security_scanner_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.method(:new)
            )

            @create_scan_config = Google::Gax.create_api_call(
              @web_security_scanner_stub.method(:create_scan_config),
              defaults["create_scan_config"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @delete_scan_config = Google::Gax.create_api_call(
              @web_security_scanner_stub.method(:delete_scan_config),
              defaults["delete_scan_config"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @get_scan_config = Google::Gax.create_api_call(
              @web_security_scanner_stub.method(:get_scan_config),
              defaults["get_scan_config"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_scan_configs = Google::Gax.create_api_call(
              @web_security_scanner_stub.method(:list_scan_configs),
              defaults["list_scan_configs"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @update_scan_config = Google::Gax.create_api_call(
              @web_security_scanner_stub.method(:update_scan_config),
              defaults["update_scan_config"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'scan_config.name' => request.scan_config.name}
              end
            )
            @start_scan_run = Google::Gax.create_api_call(
              @web_security_scanner_stub.method(:start_scan_run),
              defaults["start_scan_run"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @get_scan_run = Google::Gax.create_api_call(
              @web_security_scanner_stub.method(:get_scan_run),
              defaults["get_scan_run"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_scan_runs = Google::Gax.create_api_call(
              @web_security_scanner_stub.method(:list_scan_runs),
              defaults["list_scan_runs"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @stop_scan_run = Google::Gax.create_api_call(
              @web_security_scanner_stub.method(:stop_scan_run),
              defaults["stop_scan_run"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_crawled_urls = Google::Gax.create_api_call(
              @web_security_scanner_stub.method(:list_crawled_urls),
              defaults["list_crawled_urls"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_finding = Google::Gax.create_api_call(
              @web_security_scanner_stub.method(:get_finding),
              defaults["get_finding"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_findings = Google::Gax.create_api_call(
              @web_security_scanner_stub.method(:list_findings),
              defaults["list_findings"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @list_finding_type_stats = Google::Gax.create_api_call(
              @web_security_scanner_stub.method(:list_finding_type_stats),
              defaults["list_finding_type_stats"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
          end

          # Service calls

          # Creates a new ScanConfig.
          #
          # @param parent [String]
          #   Required. The parent resource name where the scan is created, which should be a
          #   project resource name in the format 'projects/{projectId}'.
          # @param scan_config [Google::Cloud::Websecurityscanner::V1alpha::ScanConfig | Hash]
          #   Required. The ScanConfig to be created.
          #   A hash of the same form as `Google::Cloud::Websecurityscanner::V1alpha::ScanConfig`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Websecurityscanner::V1alpha::ScanConfig]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Websecurityscanner::V1alpha::ScanConfig]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/websecurityscanner"
          #
          #   web_security_scanner_client = Google::Cloud::Websecurityscanner::V1alpha.new(version: :v1alpha)
          #   formatted_parent = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.project_path("[PROJECT]")
          #
          #   # TODO: Initialize `scan_config`:
          #   scan_config = {}
          #   response = web_security_scanner_client.create_scan_config(formatted_parent, scan_config)

          def create_scan_config \
              parent,
              scan_config,
              options: nil,
              &block
            req = {
              parent: parent,
              scan_config: scan_config
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Websecurityscanner::V1alpha::CreateScanConfigRequest)
            @create_scan_config.call(req, options, &block)
          end

          # Deletes an existing ScanConfig and its child resources.
          #
          # @param name [String]
          #   Required. The resource name of the ScanConfig to be deleted. The name follows the
          #   format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/websecurityscanner"
          #
          #   web_security_scanner_client = Google::Cloud::Websecurityscanner::V1alpha.new(version: :v1alpha)
          #   formatted_name = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_config_path("[PROJECT]", "[SCAN_CONFIG]")
          #   web_security_scanner_client.delete_scan_config(formatted_name)

          def delete_scan_config \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Websecurityscanner::V1alpha::DeleteScanConfigRequest)
            @delete_scan_config.call(req, options, &block)
            nil
          end

          # Gets a ScanConfig.
          #
          # @param name [String]
          #   Required. The resource name of the ScanConfig to be returned. The name follows the
          #   format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Websecurityscanner::V1alpha::ScanConfig]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Websecurityscanner::V1alpha::ScanConfig]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/websecurityscanner"
          #
          #   web_security_scanner_client = Google::Cloud::Websecurityscanner::V1alpha.new(version: :v1alpha)
          #   formatted_name = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_config_path("[PROJECT]", "[SCAN_CONFIG]")
          #   response = web_security_scanner_client.get_scan_config(formatted_name)

          def get_scan_config \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Websecurityscanner::V1alpha::GetScanConfigRequest)
            @get_scan_config.call(req, options, &block)
          end

          # Lists ScanConfigs under a given project.
          #
          # @param parent [String]
          #   Required. The parent resource name, which should be a project resource name in the
          #   format 'projects/{projectId}'.
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Websecurityscanner::V1alpha::ScanConfig>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Websecurityscanner::V1alpha::ScanConfig>]
          #   An enumerable of Google::Cloud::Websecurityscanner::V1alpha::ScanConfig instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/websecurityscanner"
          #
          #   web_security_scanner_client = Google::Cloud::Websecurityscanner::V1alpha.new(version: :v1alpha)
          #   formatted_parent = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.project_path("[PROJECT]")
          #
          #   # Iterate over all results.
          #   web_security_scanner_client.list_scan_configs(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   web_security_scanner_client.list_scan_configs(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_scan_configs \
              parent,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Websecurityscanner::V1alpha::ListScanConfigsRequest)
            @list_scan_configs.call(req, options, &block)
          end

          # Updates a ScanConfig. This method support partial update of a ScanConfig.
          #
          # @param scan_config [Google::Cloud::Websecurityscanner::V1alpha::ScanConfig | Hash]
          #   Required. The ScanConfig to be updated. The name field must be set to identify the
          #   resource to be updated. The values of fields not covered by the mask
          #   will be ignored.
          #   A hash of the same form as `Google::Cloud::Websecurityscanner::V1alpha::ScanConfig`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Required. The update mask applies to the resource. For the `FieldMask` definition,
          #   see
          #   https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Websecurityscanner::V1alpha::ScanConfig]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Websecurityscanner::V1alpha::ScanConfig]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/websecurityscanner"
          #
          #   web_security_scanner_client = Google::Cloud::Websecurityscanner::V1alpha.new(version: :v1alpha)
          #
          #   # TODO: Initialize `scan_config`:
          #   scan_config = {}
          #
          #   # TODO: Initialize `update_mask`:
          #   update_mask = {}
          #   response = web_security_scanner_client.update_scan_config(scan_config, update_mask)

          def update_scan_config \
              scan_config,
              update_mask,
              options: nil,
              &block
            req = {
              scan_config: scan_config,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Websecurityscanner::V1alpha::UpdateScanConfigRequest)
            @update_scan_config.call(req, options, &block)
          end

          # Start a ScanRun according to the given ScanConfig.
          #
          # @param name [String]
          #   Required. The resource name of the ScanConfig to be used. The name follows the
          #   format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Websecurityscanner::V1alpha::ScanRun]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Websecurityscanner::V1alpha::ScanRun]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/websecurityscanner"
          #
          #   web_security_scanner_client = Google::Cloud::Websecurityscanner::V1alpha.new(version: :v1alpha)
          #   formatted_name = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_config_path("[PROJECT]", "[SCAN_CONFIG]")
          #   response = web_security_scanner_client.start_scan_run(formatted_name)

          def start_scan_run \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Websecurityscanner::V1alpha::StartScanRunRequest)
            @start_scan_run.call(req, options, &block)
          end

          # Gets a ScanRun.
          #
          # @param name [String]
          #   Required. The resource name of the ScanRun to be returned. The name follows the
          #   format of
          #   'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Websecurityscanner::V1alpha::ScanRun]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Websecurityscanner::V1alpha::ScanRun]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/websecurityscanner"
          #
          #   web_security_scanner_client = Google::Cloud::Websecurityscanner::V1alpha.new(version: :v1alpha)
          #   formatted_name = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_run_path("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]")
          #   response = web_security_scanner_client.get_scan_run(formatted_name)

          def get_scan_run \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Websecurityscanner::V1alpha::GetScanRunRequest)
            @get_scan_run.call(req, options, &block)
          end

          # Lists ScanRuns under a given ScanConfig, in descending order of ScanRun
          # stop time.
          #
          # @param parent [String]
          #   Required. The parent resource name, which should be a scan resource name in the
          #   format 'projects/{projectId}/scanConfigs/{scanConfigId}'.
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Websecurityscanner::V1alpha::ScanRun>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Websecurityscanner::V1alpha::ScanRun>]
          #   An enumerable of Google::Cloud::Websecurityscanner::V1alpha::ScanRun instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/websecurityscanner"
          #
          #   web_security_scanner_client = Google::Cloud::Websecurityscanner::V1alpha.new(version: :v1alpha)
          #   formatted_parent = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_config_path("[PROJECT]", "[SCAN_CONFIG]")
          #
          #   # Iterate over all results.
          #   web_security_scanner_client.list_scan_runs(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   web_security_scanner_client.list_scan_runs(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_scan_runs \
              parent,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Websecurityscanner::V1alpha::ListScanRunsRequest)
            @list_scan_runs.call(req, options, &block)
          end

          # Stops a ScanRun. The stopped ScanRun is returned.
          #
          # @param name [String]
          #   Required. The resource name of the ScanRun to be stopped. The name follows the
          #   format of
          #   'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Websecurityscanner::V1alpha::ScanRun]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Websecurityscanner::V1alpha::ScanRun]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/websecurityscanner"
          #
          #   web_security_scanner_client = Google::Cloud::Websecurityscanner::V1alpha.new(version: :v1alpha)
          #   formatted_name = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_run_path("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]")
          #   response = web_security_scanner_client.stop_scan_run(formatted_name)

          def stop_scan_run \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Websecurityscanner::V1alpha::StopScanRunRequest)
            @stop_scan_run.call(req, options, &block)
          end

          # List CrawledUrls under a given ScanRun.
          #
          # @param parent [String]
          #   Required. The parent resource name, which should be a scan run resource name in the
          #   format
          #   'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Websecurityscanner::V1alpha::CrawledUrl>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Websecurityscanner::V1alpha::CrawledUrl>]
          #   An enumerable of Google::Cloud::Websecurityscanner::V1alpha::CrawledUrl instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/websecurityscanner"
          #
          #   web_security_scanner_client = Google::Cloud::Websecurityscanner::V1alpha.new(version: :v1alpha)
          #   formatted_parent = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_run_path("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]")
          #
          #   # Iterate over all results.
          #   web_security_scanner_client.list_crawled_urls(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   web_security_scanner_client.list_crawled_urls(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_crawled_urls \
              parent,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Websecurityscanner::V1alpha::ListCrawledUrlsRequest)
            @list_crawled_urls.call(req, options, &block)
          end

          # Gets a Finding.
          #
          # @param name [String]
          #   Required. The resource name of the Finding to be returned. The name follows the
          #   format of
          #   'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}/findings/{findingId}'.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Websecurityscanner::V1alpha::Finding]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Websecurityscanner::V1alpha::Finding]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/websecurityscanner"
          #
          #   web_security_scanner_client = Google::Cloud::Websecurityscanner::V1alpha.new(version: :v1alpha)
          #   formatted_name = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.finding_path("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]", "[FINDING]")
          #   response = web_security_scanner_client.get_finding(formatted_name)

          def get_finding \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Websecurityscanner::V1alpha::GetFindingRequest)
            @get_finding.call(req, options, &block)
          end

          # List Findings under a given ScanRun.
          #
          # @param parent [String]
          #   Required. The parent resource name, which should be a scan run resource name in the
          #   format
          #   'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
          # @param filter [String]
          #   Required. The filter expression. The expression must be in the format: <field>
          #   <operator> <value>.
          #   Supported field: 'finding_type'.
          #   Supported operator: '='.
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Websecurityscanner::V1alpha::Finding>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Websecurityscanner::V1alpha::Finding>]
          #   An enumerable of Google::Cloud::Websecurityscanner::V1alpha::Finding instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/websecurityscanner"
          #
          #   web_security_scanner_client = Google::Cloud::Websecurityscanner::V1alpha.new(version: :v1alpha)
          #   formatted_parent = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_run_path("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]")
          #
          #   # TODO: Initialize `filter`:
          #   filter = ''
          #
          #   # Iterate over all results.
          #   web_security_scanner_client.list_findings(formatted_parent, filter).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   web_security_scanner_client.list_findings(formatted_parent, filter).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_findings \
              parent,
              filter,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              filter: filter,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Websecurityscanner::V1alpha::ListFindingsRequest)
            @list_findings.call(req, options, &block)
          end

          # List all FindingTypeStats under a given ScanRun.
          #
          # @param parent [String]
          #   Required. The parent resource name, which should be a scan run resource name in the
          #   format
          #   'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Websecurityscanner::V1alpha::ListFindingTypeStatsResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Websecurityscanner::V1alpha::ListFindingTypeStatsResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/websecurityscanner"
          #
          #   web_security_scanner_client = Google::Cloud::Websecurityscanner::V1alpha.new(version: :v1alpha)
          #   formatted_parent = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_run_path("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]")
          #   response = web_security_scanner_client.list_finding_type_stats(formatted_parent)

          def list_finding_type_stats \
              parent,
              options: nil,
              &block
            req = {
              parent: parent
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Websecurityscanner::V1alpha::ListFindingTypeStatsRequest)
            @list_finding_type_stats.call(req, options, &block)
          end
        end
      end
    end
  end
end
