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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/video/transcoder/v1beta1/services.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/video/transcoder/v1beta1/services_pb"
require "google/cloud/video/transcoder/v1beta1/credentials"

module Google
  module Cloud
    module Video
      module Transcoder
        module V1beta1
          # Using the Transcoder API, you can queue asynchronous jobs for transcoding
          # media into various output formats. Output formats may include different
          # streaming standards such as HTTP Live Streaming (HLS) and Dynamic Adaptive
          # Streaming over HTTP (DASH). You can also customize jobs using advanced
          # features such as Digital Rights Management (DRM), audio equalization, content
          # concatenation, and digital ad-stitch ready content generation.
          #
          # @!attribute [r] transcoder_service_stub
          #   @return [Google::Cloud::Video::Transcoder::V1beta1::TranscoderService::Stub]
          class TranscoderServiceClient
            attr_reader :transcoder_service_stub

            # The default address of the service.
            SERVICE_ADDRESS = "transcoder.googleapis.com".freeze

            # The default port of the service.
            DEFAULT_SERVICE_PORT = 443

            # The default set of gRPC interceptors.
            GRPC_INTERCEPTORS = []

            DEFAULT_TIMEOUT = 30

            PAGE_DESCRIPTORS = {
              "list_jobs" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "jobs"),
              "list_job_templates" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "job_templates")
            }.freeze

            private_constant :PAGE_DESCRIPTORS

            # The scopes needed to make gRPC calls to all of the methods defined in
            # this service.
            ALL_SCOPES = [
              "https://www.googleapis.com/auth/cloud-platform"
            ].freeze


            JOB_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}/jobs/{job}"
            )

            private_constant :JOB_PATH_TEMPLATE

            JOB_TEMPLATE_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}/jobTemplates/{job_template}"
            )

            private_constant :JOB_TEMPLATE_PATH_TEMPLATE

            LOCATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}"
            )

            private_constant :LOCATION_PATH_TEMPLATE

            # Returns a fully-qualified job resource name string.
            # @param project [String]
            # @param location [String]
            # @param job [String]
            # @return [String]
            def self.job_path project, location, job
              JOB_PATH_TEMPLATE.render(
                :"project" => project,
                :"location" => location,
                :"job" => job
              )
            end

            # Returns a fully-qualified job_template resource name string.
            # @param project [String]
            # @param location [String]
            # @param job_template [String]
            # @return [String]
            def self.job_template_path project, location, job_template
              JOB_TEMPLATE_PATH_TEMPLATE.render(
                :"project" => project,
                :"location" => location,
                :"job_template" => job_template
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
              require "google/cloud/video/transcoder/v1beta1/services_services_pb"

              credentials ||= Google::Cloud::Video::Transcoder::V1beta1::Credentials.default

              if credentials.is_a?(String) || credentials.is_a?(Hash)
                updater_proc = Google::Cloud::Video::Transcoder::V1beta1::Credentials.new(credentials).updater_proc
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

              package_version = Gem.loaded_specs['google-cloud-video-transcoder'].version.version

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
                "transcoder_service_client_config.json"
              )
              defaults = client_config_file.open do |f|
                Google::Gax.construct_settings(
                  "google.cloud.video.transcoder.v1beta1.TranscoderService",
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
              @transcoder_service_stub = Google::Gax::Grpc.create_stub(
                service_path,
                port,
                chan_creds: chan_creds,
                channel: channel,
                updater_proc: updater_proc,
                scopes: scopes,
                interceptors: interceptors,
                &Google::Cloud::Video::Transcoder::V1beta1::TranscoderService::Stub.method(:new)
              )

              @create_job = Google::Gax.create_api_call(
                @transcoder_service_stub.method(:create_job),
                defaults["create_job"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @list_jobs = Google::Gax.create_api_call(
                @transcoder_service_stub.method(:list_jobs),
                defaults["list_jobs"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @get_job = Google::Gax.create_api_call(
                @transcoder_service_stub.method(:get_job),
                defaults["get_job"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @delete_job = Google::Gax.create_api_call(
                @transcoder_service_stub.method(:delete_job),
                defaults["delete_job"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @create_job_template = Google::Gax.create_api_call(
                @transcoder_service_stub.method(:create_job_template),
                defaults["create_job_template"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @list_job_templates = Google::Gax.create_api_call(
                @transcoder_service_stub.method(:list_job_templates),
                defaults["list_job_templates"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @get_job_template = Google::Gax.create_api_call(
                @transcoder_service_stub.method(:get_job_template),
                defaults["get_job_template"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @delete_job_template = Google::Gax.create_api_call(
                @transcoder_service_stub.method(:delete_job_template),
                defaults["delete_job_template"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
            end

            # Service calls

            # Creates a job in the specified region.
            #
            # @param parent [String]
            #   Required. The parent location to create and process this job.
            #   Format: `projects/{project}/locations/{location}`
            # @param job [Google::Cloud::Video::Transcoder::V1beta1::Job | Hash]
            #   Required. Parameters for creating transcoding job.
            #   A hash of the same form as `Google::Cloud::Video::Transcoder::V1beta1::Job`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Video::Transcoder::V1beta1::Job]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Video::Transcoder::V1beta1::Job]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/video/transcoder"
            #
            #   transcoder_client = Google::Cloud::Video::Transcoder.new(version: :v1beta1)
            #   formatted_parent = Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient.location_path("[PROJECT]", "[LOCATION]")
            #
            #   # TODO: Initialize `job`:
            #   job = {}
            #   response = transcoder_client.create_job(formatted_parent, job)

            def create_job \
                parent,
                job,
                options: nil,
                &block
              req = {
                parent: parent,
                job: job
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Video::Transcoder::V1beta1::CreateJobRequest)
              @create_job.call(req, options, &block)
            end

            # Lists jobs in the specified region.
            #
            # @param parent [String]
            #   Required. Format: `projects/{project}/locations/{location}`
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
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Video::Transcoder::V1beta1::Job>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Cloud::Video::Transcoder::V1beta1::Job>]
            #   An enumerable of Google::Cloud::Video::Transcoder::V1beta1::Job instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/video/transcoder"
            #
            #   transcoder_client = Google::Cloud::Video::Transcoder.new(version: :v1beta1)
            #   formatted_parent = Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient.location_path("[PROJECT]", "[LOCATION]")
            #
            #   # Iterate over all results.
            #   transcoder_client.list_jobs(formatted_parent).each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   transcoder_client.list_jobs(formatted_parent).each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_jobs \
                parent,
                page_size: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                page_size: page_size
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Video::Transcoder::V1beta1::ListJobsRequest)
              @list_jobs.call(req, options, &block)
            end

            # Returns the job data.
            #
            # @param name [String]
            #   Required. The name of the job to retrieve.
            #   Format: `projects/{project}/locations/{location}/jobs/{job}`
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Video::Transcoder::V1beta1::Job]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Video::Transcoder::V1beta1::Job]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/video/transcoder"
            #
            #   transcoder_client = Google::Cloud::Video::Transcoder.new(version: :v1beta1)
            #   formatted_name = Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient.job_path("[PROJECT]", "[LOCATION]", "[JOB]")
            #   response = transcoder_client.get_job(formatted_name)

            def get_job \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Video::Transcoder::V1beta1::GetJobRequest)
              @get_job.call(req, options, &block)
            end

            # Deletes a job.
            #
            # @param name [String]
            #   Required. The name of the job to delete.
            #   Format: `projects/{project}/locations/{location}/jobs/{job}`
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result []
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/video/transcoder"
            #
            #   transcoder_client = Google::Cloud::Video::Transcoder.new(version: :v1beta1)
            #   formatted_name = Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient.job_path("[PROJECT]", "[LOCATION]", "[JOB]")
            #   transcoder_client.delete_job(formatted_name)

            def delete_job \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Video::Transcoder::V1beta1::DeleteJobRequest)
              @delete_job.call(req, options, &block)
              nil
            end

            # Creates a job template in the specified region.
            #
            # @param parent [String]
            #   Required. The parent location to create this job template.
            #   Format: `projects/{project}/locations/{location}`
            # @param job_template [Google::Cloud::Video::Transcoder::V1beta1::JobTemplate | Hash]
            #   Required. Parameters for creating job template.
            #   A hash of the same form as `Google::Cloud::Video::Transcoder::V1beta1::JobTemplate`
            #   can also be provided.
            # @param job_template_id [String]
            #   Required. The ID to use for the job template, which will become the final component
            #   of the job template's resource name.
            #
            #   This value should be 4-63 characters, and valid characters must match the
            #   regular expression `[a-zA-Z][a-zA-Z0-9_-]*`.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Video::Transcoder::V1beta1::JobTemplate]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Video::Transcoder::V1beta1::JobTemplate]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/video/transcoder"
            #
            #   transcoder_client = Google::Cloud::Video::Transcoder.new(version: :v1beta1)
            #   formatted_parent = Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient.location_path("[PROJECT]", "[LOCATION]")
            #
            #   # TODO: Initialize `job_template`:
            #   job_template = {}
            #
            #   # TODO: Initialize `job_template_id`:
            #   job_template_id = ''
            #   response = transcoder_client.create_job_template(formatted_parent, job_template, job_template_id)

            def create_job_template \
                parent,
                job_template,
                job_template_id,
                options: nil,
                &block
              req = {
                parent: parent,
                job_template: job_template,
                job_template_id: job_template_id
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Video::Transcoder::V1beta1::CreateJobTemplateRequest)
              @create_job_template.call(req, options, &block)
            end

            # Lists job templates in the specified region.
            #
            # @param parent [String]
            #   Required. The parent location from which to retrieve the collection of job templates.
            #   Format: `projects/{project}/locations/{location}`
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
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Video::Transcoder::V1beta1::JobTemplate>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Cloud::Video::Transcoder::V1beta1::JobTemplate>]
            #   An enumerable of Google::Cloud::Video::Transcoder::V1beta1::JobTemplate instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/video/transcoder"
            #
            #   transcoder_client = Google::Cloud::Video::Transcoder.new(version: :v1beta1)
            #   formatted_parent = Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient.location_path("[PROJECT]", "[LOCATION]")
            #
            #   # Iterate over all results.
            #   transcoder_client.list_job_templates(formatted_parent).each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   transcoder_client.list_job_templates(formatted_parent).each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_job_templates \
                parent,
                page_size: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                page_size: page_size
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Video::Transcoder::V1beta1::ListJobTemplatesRequest)
              @list_job_templates.call(req, options, &block)
            end

            # Returns the job template data.
            #
            # @param name [String]
            #   Required. The name of the job template to retrieve.
            #   Format:
            #   `projects/{project}/locations/{location}/jobTemplates/{job_template}`
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Video::Transcoder::V1beta1::JobTemplate]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Video::Transcoder::V1beta1::JobTemplate]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/video/transcoder"
            #
            #   transcoder_client = Google::Cloud::Video::Transcoder.new(version: :v1beta1)
            #   formatted_name = Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient.job_template_path("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]")
            #   response = transcoder_client.get_job_template(formatted_name)

            def get_job_template \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Video::Transcoder::V1beta1::GetJobTemplateRequest)
              @get_job_template.call(req, options, &block)
            end

            # Deletes a job template.
            #
            # @param name [String]
            #   Required. The name of the job template to delete.
            #   `projects/{project}/locations/{location}/jobTemplates/{job_template}`
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result []
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/video/transcoder"
            #
            #   transcoder_client = Google::Cloud::Video::Transcoder.new(version: :v1beta1)
            #   formatted_name = Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient.job_template_path("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]")
            #   transcoder_client.delete_job_template(formatted_name)

            def delete_job_template \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Video::Transcoder::V1beta1::DeleteJobTemplateRequest)
              @delete_job_template.call(req, options, &block)
              nil
            end
          end
        end
      end
    end
  end
end
