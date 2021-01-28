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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/dialogflow/cx/v3/test_case.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"
require "google/gax/operation"
require "google/longrunning/operations_client"

require "google/cloud/dialogflow/cx/v3/test_case_pb"
require "google/cloud/dialogflow/cx/v3/credentials"

module Google
  module Cloud
    module Dialogflow
      module Cx
        module V3
          # Service for managing {Google::Cloud::Dialogflow::Cx::V3::TestCase Test Cases} and
          # {Google::Cloud::Dialogflow::Cx::V3::TestCaseResult Test Case Results}.
          #
          # @!attribute [r] test_cases_stub
          #   @return [Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub]
          class TestCasesClient
            attr_reader :test_cases_stub

            # The default address of the service.
            SERVICE_ADDRESS = "dialogflow.googleapis.com".freeze

            # The default port of the service.
            DEFAULT_SERVICE_PORT = 443

            # The default set of gRPC interceptors.
            GRPC_INTERCEPTORS = []

            DEFAULT_TIMEOUT = 30

            PAGE_DESCRIPTORS = {
              "list_test_cases" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "test_cases"),
              "list_test_case_results" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "test_case_results")
            }.freeze

            private_constant :PAGE_DESCRIPTORS

            # The scopes needed to make gRPC calls to all of the methods defined in
            # this service.
            ALL_SCOPES = [
              "https://www.googleapis.com/auth/cloud-platform",
              "https://www.googleapis.com/auth/dialogflow"
            ].freeze

            class OperationsClient < Google::Longrunning::OperationsClient
              self::SERVICE_ADDRESS = TestCasesClient::SERVICE_ADDRESS
              self::GRPC_INTERCEPTORS = TestCasesClient::GRPC_INTERCEPTORS
            end

            AGENT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}/agents/{agent}"
            )

            private_constant :AGENT_PATH_TEMPLATE

            ENVIRONMENT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}/agents/{agent}/environments/{environment}"
            )

            private_constant :ENVIRONMENT_PATH_TEMPLATE

            TEST_CASE_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}/agents/{agent}/testCases/{test_case}"
            )

            private_constant :TEST_CASE_PATH_TEMPLATE

            # Returns a fully-qualified agent resource name string.
            # @param project [String]
            # @param location [String]
            # @param agent [String]
            # @return [String]
            def self.agent_path project, location, agent
              AGENT_PATH_TEMPLATE.render(
                :"project" => project,
                :"location" => location,
                :"agent" => agent
              )
            end

            # Returns a fully-qualified environment resource name string.
            # @param project [String]
            # @param location [String]
            # @param agent [String]
            # @param environment [String]
            # @return [String]
            def self.environment_path project, location, agent, environment
              ENVIRONMENT_PATH_TEMPLATE.render(
                :"project" => project,
                :"location" => location,
                :"agent" => agent,
                :"environment" => environment
              )
            end

            # Returns a fully-qualified test_case resource name string.
            # @param project [String]
            # @param location [String]
            # @param agent [String]
            # @param test_case [String]
            # @return [String]
            def self.test_case_path project, location, agent, test_case
              TEST_CASE_PATH_TEMPLATE.render(
                :"project" => project,
                :"location" => location,
                :"agent" => agent,
                :"test_case" => test_case
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
              require "google/cloud/dialogflow/cx/v3/test_case_services_pb"

              credentials ||= Google::Cloud::Dialogflow::Cx::V3::Credentials.default

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
                updater_proc = Google::Cloud::Dialogflow::Cx::V3::Credentials.new(credentials).updater_proc
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

              package_version = Gem.loaded_specs['google-cloud-dialogflow-cx'].version.version

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
                "test_cases_client_config.json"
              )
              defaults = client_config_file.open do |f|
                Google::Gax.construct_settings(
                  "google.cloud.dialogflow.cx.v3.TestCases",
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
              @test_cases_stub = Google::Gax::Grpc.create_stub(
                service_path,
                port,
                chan_creds: chan_creds,
                channel: channel,
                updater_proc: updater_proc,
                scopes: scopes,
                interceptors: interceptors,
                &Google::Cloud::Dialogflow::Cx::V3::TestCases::Stub.method(:new)
              )

              @list_test_cases = Google::Gax.create_api_call(
                @test_cases_stub.method(:list_test_cases),
                defaults["list_test_cases"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @batch_delete_test_cases = Google::Gax.create_api_call(
                @test_cases_stub.method(:batch_delete_test_cases),
                defaults["batch_delete_test_cases"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @get_test_case = Google::Gax.create_api_call(
                @test_cases_stub.method(:get_test_case),
                defaults["get_test_case"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @create_test_case = Google::Gax.create_api_call(
                @test_cases_stub.method(:create_test_case),
                defaults["create_test_case"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @update_test_case = Google::Gax.create_api_call(
                @test_cases_stub.method(:update_test_case),
                defaults["update_test_case"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'test_case.name' => request.test_case.name}
                end
              )
              @run_test_case = Google::Gax.create_api_call(
                @test_cases_stub.method(:run_test_case),
                defaults["run_test_case"],
                exception_transformer: exception_transformer
              )
              @batch_run_test_cases = Google::Gax.create_api_call(
                @test_cases_stub.method(:batch_run_test_cases),
                defaults["batch_run_test_cases"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @calculate_coverage = Google::Gax.create_api_call(
                @test_cases_stub.method(:calculate_coverage),
                defaults["calculate_coverage"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'agent' => request.agent}
                end
              )
              @import_test_cases = Google::Gax.create_api_call(
                @test_cases_stub.method(:import_test_cases),
                defaults["import_test_cases"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @export_test_cases = Google::Gax.create_api_call(
                @test_cases_stub.method(:export_test_cases),
                defaults["export_test_cases"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @list_test_case_results = Google::Gax.create_api_call(
                @test_cases_stub.method(:list_test_case_results),
                defaults["list_test_case_results"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
            end

            # Service calls

            # Fetches a list of test cases for a given agent.
            #
            # @param parent [String]
            #   Required. The agent to list all pages for.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
            # @param page_size [Integer]
            #   The maximum number of resources contained in the underlying API
            #   response. If page streaming is performed per-resource, this
            #   parameter does not affect the return value. If page streaming is
            #   performed per-page, this determines the maximum number of
            #   resources in a page.
            # @param view [Google::Cloud::Dialogflow::Cx::V3::ListTestCasesRequest::TestCaseView]
            #   Specifies whether response should include all fields or just the metadata.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::Cx::V3::TestCase>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::Cx::V3::TestCase>]
            #   An enumerable of Google::Cloud::Dialogflow::Cx::V3::TestCase instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   test_cases_client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)
            #   formatted_parent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
            #
            #   # Iterate over all results.
            #   test_cases_client.list_test_cases(formatted_parent).each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   test_cases_client.list_test_cases(formatted_parent).each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_test_cases \
                parent,
                page_size: nil,
                view: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                page_size: page_size,
                view: view
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3::ListTestCasesRequest)
              @list_test_cases.call(req, options, &block)
            end

            # Batch deletes test cases.
            #
            # @param parent [String]
            #   Required. The agent to delete test cases from.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
            # @param names [Array<String>]
            #   Required. Format of test case names: `projects/<Project ID>/locations/
            #   <Location ID>/agents/<AgentID>/testCases/<TestCase ID>`.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result []
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   test_cases_client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)
            #   formatted_parent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
            #
            #   # TODO: Initialize `formatted_names`:
            #   formatted_names = []
            #   test_cases_client.batch_delete_test_cases(formatted_parent, formatted_names)

            def batch_delete_test_cases \
                parent,
                names,
                options: nil,
                &block
              req = {
                parent: parent,
                names: names
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3::BatchDeleteTestCasesRequest)
              @batch_delete_test_cases.call(req, options, &block)
              nil
            end

            # Gets a test case.
            #
            # @param name [String]
            #   Required. The name of the testcase.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
            #   ID>/testCases/<TestCase ID>`.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Dialogflow::Cx::V3::TestCase]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Dialogflow::Cx::V3::TestCase]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   test_cases_client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)
            #   formatted_name = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.test_case_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]")
            #   response = test_cases_client.get_test_case(formatted_name)

            def get_test_case \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3::GetTestCaseRequest)
              @get_test_case.call(req, options, &block)
            end

            # Creates a test case for the given agent.
            #
            # @param parent [String]
            #   Required. The agent to create the test case for.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
            # @param test_case [Google::Cloud::Dialogflow::Cx::V3::TestCase | Hash]
            #   Required. The test case to create.
            #   A hash of the same form as `Google::Cloud::Dialogflow::Cx::V3::TestCase`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Dialogflow::Cx::V3::TestCase]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Dialogflow::Cx::V3::TestCase]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   test_cases_client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)
            #   formatted_parent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
            #
            #   # TODO: Initialize `test_case`:
            #   test_case = {}
            #   response = test_cases_client.create_test_case(formatted_parent, test_case)

            def create_test_case \
                parent,
                test_case,
                options: nil,
                &block
              req = {
                parent: parent,
                test_case: test_case
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3::CreateTestCaseRequest)
              @create_test_case.call(req, options, &block)
            end

            # Updates the specified test case.
            #
            # @param test_case [Google::Cloud::Dialogflow::Cx::V3::TestCase | Hash]
            #   Required. The test case to update.
            #   A hash of the same form as `Google::Cloud::Dialogflow::Cx::V3::TestCase`
            #   can also be provided.
            # @param update_mask [Google::Protobuf::FieldMask | Hash]
            #   Required. The mask to specify which fields should be updated. The
            #   {Google::Cloud::Dialogflow::Cx::V3::TestCase#creation_time `creationTime`} and
            #   {Google::Cloud::Dialogflow::Cx::V3::TestCase#last_test_result `lastTestResult`} cannot be updated.
            #   A hash of the same form as `Google::Protobuf::FieldMask`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Dialogflow::Cx::V3::TestCase]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Dialogflow::Cx::V3::TestCase]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   test_cases_client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)
            #
            #   # TODO: Initialize `test_case`:
            #   test_case = {}
            #
            #   # TODO: Initialize `update_mask`:
            #   update_mask = {}
            #   response = test_cases_client.update_test_case(test_case, update_mask)

            def update_test_case \
                test_case,
                update_mask,
                options: nil,
                &block
              req = {
                test_case: test_case,
                update_mask: update_mask
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3::UpdateTestCaseRequest)
              @update_test_case.call(req, options, &block)
            end

            # Kicks off a test case run.
            #
            # @param name [String]
            #   Required. Format of test case name to run: `projects/<Project ID>/locations/
            #   <Location ID>/agents/<AgentID>/testCases/<TestCase ID>`.
            # @param environment [String]
            #   Optional. Environment name. If not set, draft environment is assumed.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
            #   ID>/environments/<Environment ID>`.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @return [Google::Gax::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   test_cases_client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)
            #   formatted_name = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.test_case_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]")
            #
            #   # Register a callback during the method call.
            #   operation = test_cases_client.run_test_case(formatted_name) do |op|
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

            def run_test_case \
                name,
                environment: nil,
                options: nil
              req = {
                name: name,
                environment: environment
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3::RunTestCaseRequest)
              operation = Google::Gax::Operation.new(
                @run_test_case.call(req, options),
                @operations_client,
                Google::Cloud::Dialogflow::Cx::V3::RunTestCaseResponse,
                Google::Cloud::Dialogflow::Cx::V3::RunTestCaseMetadata,
                call_options: options
              )
              operation.on_done { |operation| yield(operation) } if block_given?
              operation
            end

            # Kicks off a batch run of test cases.
            #
            # @param parent [String]
            #   Required. Agent name. Format: `projects/<Project ID>/locations/<Location ID>/agents/
            #   <AgentID>`.
            # @param test_cases [Array<String>]
            #   Required. Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
            #   ID>/testCases/<TestCase ID>`.
            # @param environment [String]
            #   Optional. If not set, draft environment is assumed. Format: `projects/<Project
            #   ID>/locations/<Location ID>/agents/<Agent ID>/environments/<Environment
            #   ID>`.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @return [Google::Gax::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   test_cases_client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)
            #   formatted_parent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
            #
            #   # TODO: Initialize `formatted_test_cases`:
            #   formatted_test_cases = []
            #
            #   # Register a callback during the method call.
            #   operation = test_cases_client.batch_run_test_cases(formatted_parent, formatted_test_cases) do |op|
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

            def batch_run_test_cases \
                parent,
                test_cases,
                environment: nil,
                options: nil
              req = {
                parent: parent,
                test_cases: test_cases,
                environment: environment
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3::BatchRunTestCasesRequest)
              operation = Google::Gax::Operation.new(
                @batch_run_test_cases.call(req, options),
                @operations_client,
                Google::Cloud::Dialogflow::Cx::V3::BatchRunTestCasesResponse,
                Google::Cloud::Dialogflow::Cx::V3::BatchRunTestCasesMetadata,
                call_options: options
              )
              operation.on_done { |operation| yield(operation) } if block_given?
              operation
            end

            # Calculates the test coverage for an agent.
            #
            # @param agent [String]
            #   Required. The agent to calculate coverage for.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
            # @param type [Google::Cloud::Dialogflow::Cx::V3::CalculateCoverageRequest::CoverageType]
            #   Required. The type of coverage requested.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Dialogflow::Cx::V3::CalculateCoverageResponse]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Dialogflow::Cx::V3::CalculateCoverageResponse]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   test_cases_client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)
            #   formatted_agent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
            #
            #   # TODO: Initialize `type`:
            #   type = :COVERAGE_TYPE_UNSPECIFIED
            #   response = test_cases_client.calculate_coverage(formatted_agent, type)

            def calculate_coverage \
                agent,
                type,
                options: nil,
                &block
              req = {
                agent: agent,
                type: type
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3::CalculateCoverageRequest)
              @calculate_coverage.call(req, options, &block)
            end

            # Imports the test cases from a Cloud Storage bucket or a local file. It
            # always creates new test cases and won't overwite any existing ones. The
            # provided ID in the imported test case is neglected.
            #
            # @param parent [String]
            #   Required. The agent to import test cases to.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
            # @param gcs_uri [String]
            #   The [Google Cloud Storage](https://cloud.google.com/storage/docs/) URI
            #   to import test cases from. The format of this URI must be
            #   `gs://<bucket-name>/<object-name>`.
            # @param content [String]
            #   Uncompressed raw byte content for test cases.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @return [Google::Gax::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   test_cases_client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)
            #   formatted_parent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
            #
            #   # Register a callback during the method call.
            #   operation = test_cases_client.import_test_cases(formatted_parent) do |op|
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

            def import_test_cases \
                parent,
                gcs_uri: nil,
                content: nil,
                options: nil
              req = {
                parent: parent,
                gcs_uri: gcs_uri,
                content: content
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3::ImportTestCasesRequest)
              operation = Google::Gax::Operation.new(
                @import_test_cases.call(req, options),
                @operations_client,
                Google::Cloud::Dialogflow::Cx::V3::ImportTestCasesResponse,
                Google::Cloud::Dialogflow::Cx::V3::ImportTestCasesMetadata,
                call_options: options
              )
              operation.on_done { |operation| yield(operation) } if block_given?
              operation
            end

            # Exports the test cases under the agent to a Cloud Storage bucket or a local
            # file. Filter can be applied to export a subset of test cases.
            #
            # @param parent [String]
            #   Required. The agent where to export test cases from.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
            # @param gcs_uri [String]
            #   The [Google Cloud Storage](https://cloud.google.com/storage/docs/) URI to
            #   export the test cases to. The format of this URI must be
            #   `gs://<bucket-name>/<object-name>`. If unspecified, the serialized test
            #   cases is returned inline.
            # @param data_format [Google::Cloud::Dialogflow::Cx::V3::ExportTestCasesRequest::DataFormat]
            #   The data format of the exported test cases. If not specified, `BLOB` is
            #   assumed.
            # @param filter [String]
            #   The filter expression used to filter exported test cases, see
            #   [API Filtering](https://aip.dev/160). The expression is case insensitive
            #   and supports the following syntax:
            #
            #     name = <value> [OR name = <value>] ...
            #
            #   For example:
            #
            #   * "name = t1 OR name = t2" matches the test case with the exact resource
            #     name "t1" or "t2".
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @return [Google::Gax::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   test_cases_client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)
            #   formatted_parent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")
            #
            #   # Register a callback during the method call.
            #   operation = test_cases_client.export_test_cases(formatted_parent) do |op|
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

            def export_test_cases \
                parent,
                gcs_uri: nil,
                data_format: nil,
                filter: nil,
                options: nil
              req = {
                parent: parent,
                gcs_uri: gcs_uri,
                data_format: data_format,
                filter: filter
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3::ExportTestCasesRequest)
              operation = Google::Gax::Operation.new(
                @export_test_cases.call(req, options),
                @operations_client,
                Google::Cloud::Dialogflow::Cx::V3::ExportTestCasesResponse,
                Google::Cloud::Dialogflow::Cx::V3::ExportTestCasesMetadata,
                call_options: options
              )
              operation.on_done { |operation| yield(operation) } if block_given?
              operation
            end

            # Fetches a list of results for a given test case.
            #
            # @param parent [String]
            #   Required. The test case to list results for.
            #   Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>/
            #   testCases/<TestCase ID>`. Specify a `-` as a wildcard for TestCase ID to
            #   list results across multiple test cases.
            # @param page_size [Integer]
            #   The maximum number of resources contained in the underlying API
            #   response. If page streaming is performed per-resource, this
            #   parameter does not affect the return value. If page streaming is
            #   performed per-page, this determines the maximum number of
            #   resources in a page.
            # @param filter [String]
            #   The filter expression used to filter test case results. See
            #   [API Filtering](https://aip.dev/160).
            #
            #   The expression is case insensitive. Only 'AND' is supported for logical
            #   operators. The supported syntax is listed below in detail:
            #
            #     <field> <operator> <value> [AND <field> <operator> <value>] ...
            #     [AND latest]
            #
            #   The supported fields and operators are:
            #   field                 operator
            #   `environment`         `=`, `IN`  (Use value `draft` for draft environment)
            #   `test_time`           `>`, `<`
            #
            #   `latest` only returns the latest test result in all results for each test
            #   case.
            #
            #   Examples:
            #   * "environment=draft AND latest" matches the latest test result for each
            #     test case in the draft environment.
            #   * "environment IN (e1,e2)" matches any test case results with an
            #     environment resource name of either "e1" or "e2".
            #   * "test_time > 1602540713" matches any test case results with test time
            #     later than a unix timestamp in seconds 1602540713.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::Cx::V3::TestCaseResult>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::Cx::V3::TestCaseResult>]
            #   An enumerable of Google::Cloud::Dialogflow::Cx::V3::TestCaseResult instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/dialogflow/cx"
            #
            #   test_cases_client = Google::Cloud::Dialogflow::Cx::TestCases.new(version: :v3)
            #   formatted_parent = Google::Cloud::Dialogflow::Cx::V3::TestCasesClient.test_case_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]")
            #
            #   # Iterate over all results.
            #   test_cases_client.list_test_case_results(formatted_parent).each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   test_cases_client.list_test_case_results(formatted_parent).each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_test_case_results \
                parent,
                page_size: nil,
                filter: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                page_size: page_size,
                filter: filter
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::Cx::V3::ListTestCaseResultsRequest)
              @list_test_case_results.call(req, options, &block)
            end
          end
        end
      end
    end
  end
end
