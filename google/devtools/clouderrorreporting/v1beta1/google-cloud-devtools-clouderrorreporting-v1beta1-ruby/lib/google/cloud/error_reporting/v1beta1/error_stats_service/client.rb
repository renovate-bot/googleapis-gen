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
require "google/devtools/clouderrorreporting/v1beta1/error_stats_service_pb"

module Google
  module Cloud
    module ErrorReporting
      module V1beta1
        module ErrorStatsService
          ##
          # Client for the ErrorStatsService service.
          #
          # An API for retrieving and managing error statistics as well as data for
          # individual events.
          #
          class Client
            include Paths

            # @private
            attr_reader :error_stats_service_stub

            ##
            # Configure the ErrorStatsService Client class.
            #
            # See {::Google::Cloud::ErrorReporting::V1beta1::ErrorStatsService::Client::Configuration}
            # for a description of the configuration fields.
            #
            # ## Example
            #
            # To modify the configuration for all ErrorStatsService clients:
            #
            #     ::Google::Cloud::ErrorReporting::V1beta1::ErrorStatsService::Client.configure do |config|
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
                namespace = ["Google", "Cloud", "ErrorReporting", "V1beta1"]
                parent_config = while namespace.any?
                                  parent_name = namespace.join "::"
                                  parent_const = const_get parent_name
                                  break parent_const.configure if parent_const&.respond_to? :configure
                                  namespace.pop
                                end
                default_config = Client::Configuration.new parent_config

                default_config.timeout = 600.0
                default_config.retry_policy = {
                  initial_delay: 0.1,
                  max_delay:     60.0,
                  multiplier:    1.3,
                  retry_codes:   [14, 4]
                }

                default_config
              end
              yield @configure if block_given?
              @configure
            end

            ##
            # Configure the ErrorStatsService Client instance.
            #
            # The configuration is set to the derived mode, meaning that values can be changed,
            # but structural changes (adding new fields, etc.) are not allowed. Structural changes
            # should be made on {Client.configure}.
            #
            # See {::Google::Cloud::ErrorReporting::V1beta1::ErrorStatsService::Client::Configuration}
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
            # Create a new ErrorStatsService client object.
            #
            # ## Examples
            #
            # To create a new ErrorStatsService client with the default
            # configuration:
            #
            #     client = ::Google::Cloud::ErrorReporting::V1beta1::ErrorStatsService::Client.new
            #
            # To create a new ErrorStatsService client with a custom
            # configuration:
            #
            #     client = ::Google::Cloud::ErrorReporting::V1beta1::ErrorStatsService::Client.new do |config|
            #       config.timeout = 10.0
            #     end
            #
            # @yield [config] Configure the ErrorStatsService client.
            # @yieldparam config [Client::Configuration]
            #
            def initialize
              # These require statements are intentionally placed here to initialize
              # the gRPC module only when it's required.
              # See https://github.com/googleapis/toolkit/issues/446
              require "gapic/grpc"
              require "google/devtools/clouderrorreporting/v1beta1/error_stats_service_services_pb"

              # Create the configuration object
              @config = Configuration.new Client.configure

              # Yield the configuration if needed
              yield @config if block_given?

              # Create credentials
              credentials = @config.credentials
              credentials ||= Credentials.default scope: @config.scope
              if credentials.is_a?(String) || credentials.is_a?(Hash)
                credentials = Credentials.new credentials, scope: @config.scope
              end
              @quota_project_id = @config.quota_project
              @quota_project_id ||= credentials.quota_project_id if credentials.respond_to? :quota_project_id

              @error_stats_service_stub = ::Gapic::ServiceStub.new(
                ::Google::Cloud::ErrorReporting::V1beta1::ErrorStatsService::Stub,
                credentials:  credentials,
                endpoint:     @config.endpoint,
                channel_args: @config.channel_args,
                interceptors: @config.interceptors
              )
            end

            # Service calls

            ##
            # Lists the specified groups.
            #
            # @overload list_group_stats(request, options = nil)
            #   Pass arguments to `list_group_stats` via a request object, either of type
            #   {::Google::Cloud::ErrorReporting::V1beta1::ListGroupStatsRequest} or an equivalent Hash.
            #
            #   @param request [::Google::Cloud::ErrorReporting::V1beta1::ListGroupStatsRequest, ::Hash]
            #     A request object representing the call parameters. Required. To specify no
            #     parameters, or to keep all the default parameter values, pass an empty Hash.
            #   @param options [::Gapic::CallOptions, ::Hash]
            #     Overrides the default settings for this call, e.g, timeout, retries, etc. Optional.
            #
            # @overload list_group_stats(project_name: nil, group_id: nil, service_filter: nil, time_range: nil, timed_count_duration: nil, alignment: nil, alignment_time: nil, order: nil, page_size: nil, page_token: nil)
            #   Pass arguments to `list_group_stats` via keyword arguments. Note that at
            #   least one keyword argument is required. To specify no parameters, or to keep all
            #   the default parameter values, pass an empty Hash as a request object (see above).
            #
            #   @param project_name [::String]
            #     Required. The resource name of the Google Cloud Platform project. Written
            #     as `projects/{projectID}` or `projects/{projectNumber}`, where `{projectID}`
            #     and `{projectNumber}` can be found in the
            #     [Google Cloud Console](https://support.google.com/cloud/answer/6158840).
            #
            #     Examples: `projects/my-project-123`, `projects/5551234`.
            #   @param group_id [::Array<::String>]
            #     Optional. List all <code>ErrorGroupStats</code> with these IDs.
            #   @param service_filter [::Google::Cloud::ErrorReporting::V1beta1::ServiceContextFilter, ::Hash]
            #     Optional. List only <code>ErrorGroupStats</code> which belong to a service
            #     context that matches the filter.
            #     Data for all service contexts is returned if this field is not specified.
            #   @param time_range [::Google::Cloud::ErrorReporting::V1beta1::QueryTimeRange, ::Hash]
            #     Optional. List data for the given time range.
            #     If not set, a default time range is used. The field
            #     <code>time_range_begin</code> in the response will specify the beginning
            #     of this time range.
            #     Only <code>ErrorGroupStats</code> with a non-zero count in the given time
            #     range are returned, unless the request contains an explicit
            #     <code>group_id</code> list. If a <code>group_id</code> list is given, also
            #     <code>ErrorGroupStats</code> with zero occurrences are returned.
            #   @param timed_count_duration [::Google::Protobuf::Duration, ::Hash]
            #     Optional. The preferred duration for a single returned `TimedCount`.
            #     If not set, no timed counts are returned.
            #   @param alignment [::Google::Cloud::ErrorReporting::V1beta1::TimedCountAlignment]
            #     Optional. The alignment of the timed counts to be returned.
            #     Default is `ALIGNMENT_EQUAL_AT_END`.
            #   @param alignment_time [::Google::Protobuf::Timestamp, ::Hash]
            #     Optional. Time where the timed counts shall be aligned if rounded
            #     alignment is chosen. Default is 00:00 UTC.
            #   @param order [::Google::Cloud::ErrorReporting::V1beta1::ErrorGroupOrder]
            #     Optional. The sort order in which the results are returned.
            #     Default is `COUNT_DESC`.
            #   @param page_size [::Integer]
            #     Optional. The maximum number of results to return per response.
            #     Default is 20.
            #   @param page_token [::String]
            #     Optional. A `next_page_token` provided by a previous response. To view
            #     additional results, pass this token along with the identical query
            #     parameters as the first request.
            #
            # @yield [response, operation] Access the result along with the RPC operation
            # @yieldparam response [::Gapic::PagedEnumerable<::Google::Cloud::ErrorReporting::V1beta1::ErrorGroupStats>]
            # @yieldparam operation [::GRPC::ActiveCall::Operation]
            #
            # @return [::Gapic::PagedEnumerable<::Google::Cloud::ErrorReporting::V1beta1::ErrorGroupStats>]
            #
            # @raise [::Google::Cloud::Error] if the RPC is aborted.
            #
            def list_group_stats request, options = nil
              raise ::ArgumentError, "request must be provided" if request.nil?

              request = ::Gapic::Protobuf.coerce request, to: ::Google::Cloud::ErrorReporting::V1beta1::ListGroupStatsRequest

              # Converts hash and nil to an options object
              options = ::Gapic::CallOptions.new(**options.to_h) if options.respond_to? :to_h

              # Customize the options with defaults
              metadata = @config.rpcs.list_group_stats.metadata.to_h

              # Set x-goog-api-client and x-goog-user-project headers
              metadata[:"x-goog-api-client"] ||= ::Gapic::Headers.x_goog_api_client \
                lib_name: @config.lib_name, lib_version: @config.lib_version,
                gapic_version: ::Google::Cloud::ErrorReporting::V1beta1::VERSION
              metadata[:"x-goog-user-project"] = @quota_project_id if @quota_project_id

              header_params = {
                "project_name" => request.project_name
              }
              request_params_header = header_params.map { |k, v| "#{k}=#{v}" }.join("&")
              metadata[:"x-goog-request-params"] ||= request_params_header

              options.apply_defaults timeout:      @config.rpcs.list_group_stats.timeout,
                                     metadata:     metadata,
                                     retry_policy: @config.rpcs.list_group_stats.retry_policy
              options.apply_defaults metadata:     @config.metadata,
                                     retry_policy: @config.retry_policy

              @error_stats_service_stub.call_rpc :list_group_stats, request, options: options do |response, operation|
                response = ::Gapic::PagedEnumerable.new @error_stats_service_stub, :list_group_stats, request, response, operation, options
                yield response, operation if block_given?
                return response
              end
            rescue ::GRPC::BadStatus => e
              raise ::Google::Cloud::Error.from_error(e)
            end

            ##
            # Lists the specified events.
            #
            # @overload list_events(request, options = nil)
            #   Pass arguments to `list_events` via a request object, either of type
            #   {::Google::Cloud::ErrorReporting::V1beta1::ListEventsRequest} or an equivalent Hash.
            #
            #   @param request [::Google::Cloud::ErrorReporting::V1beta1::ListEventsRequest, ::Hash]
            #     A request object representing the call parameters. Required. To specify no
            #     parameters, or to keep all the default parameter values, pass an empty Hash.
            #   @param options [::Gapic::CallOptions, ::Hash]
            #     Overrides the default settings for this call, e.g, timeout, retries, etc. Optional.
            #
            # @overload list_events(project_name: nil, group_id: nil, service_filter: nil, time_range: nil, page_size: nil, page_token: nil)
            #   Pass arguments to `list_events` via keyword arguments. Note that at
            #   least one keyword argument is required. To specify no parameters, or to keep all
            #   the default parameter values, pass an empty Hash as a request object (see above).
            #
            #   @param project_name [::String]
            #     Required. The resource name of the Google Cloud Platform project. Written
            #     as `projects/{projectID}`, where `{projectID}` is the
            #     [Google Cloud Platform project
            #     ID](https://support.google.com/cloud/answer/6158840).
            #
            #     Example: `projects/my-project-123`.
            #   @param group_id [::String]
            #     Required. The group for which events shall be returned.
            #   @param service_filter [::Google::Cloud::ErrorReporting::V1beta1::ServiceContextFilter, ::Hash]
            #     Optional. List only ErrorGroups which belong to a service context that
            #     matches the filter.
            #     Data for all service contexts is returned if this field is not specified.
            #   @param time_range [::Google::Cloud::ErrorReporting::V1beta1::QueryTimeRange, ::Hash]
            #     Optional. List only data for the given time range.
            #     If not set a default time range is used. The field time_range_begin
            #     in the response will specify the beginning of this time range.
            #   @param page_size [::Integer]
            #     Optional. The maximum number of results to return per response.
            #   @param page_token [::String]
            #     Optional. A `next_page_token` provided by a previous response.
            #
            # @yield [response, operation] Access the result along with the RPC operation
            # @yieldparam response [::Gapic::PagedEnumerable<::Google::Cloud::ErrorReporting::V1beta1::ErrorEvent>]
            # @yieldparam operation [::GRPC::ActiveCall::Operation]
            #
            # @return [::Gapic::PagedEnumerable<::Google::Cloud::ErrorReporting::V1beta1::ErrorEvent>]
            #
            # @raise [::Google::Cloud::Error] if the RPC is aborted.
            #
            def list_events request, options = nil
              raise ::ArgumentError, "request must be provided" if request.nil?

              request = ::Gapic::Protobuf.coerce request, to: ::Google::Cloud::ErrorReporting::V1beta1::ListEventsRequest

              # Converts hash and nil to an options object
              options = ::Gapic::CallOptions.new(**options.to_h) if options.respond_to? :to_h

              # Customize the options with defaults
              metadata = @config.rpcs.list_events.metadata.to_h

              # Set x-goog-api-client and x-goog-user-project headers
              metadata[:"x-goog-api-client"] ||= ::Gapic::Headers.x_goog_api_client \
                lib_name: @config.lib_name, lib_version: @config.lib_version,
                gapic_version: ::Google::Cloud::ErrorReporting::V1beta1::VERSION
              metadata[:"x-goog-user-project"] = @quota_project_id if @quota_project_id

              header_params = {
                "project_name" => request.project_name
              }
              request_params_header = header_params.map { |k, v| "#{k}=#{v}" }.join("&")
              metadata[:"x-goog-request-params"] ||= request_params_header

              options.apply_defaults timeout:      @config.rpcs.list_events.timeout,
                                     metadata:     metadata,
                                     retry_policy: @config.rpcs.list_events.retry_policy
              options.apply_defaults metadata:     @config.metadata,
                                     retry_policy: @config.retry_policy

              @error_stats_service_stub.call_rpc :list_events, request, options: options do |response, operation|
                response = ::Gapic::PagedEnumerable.new @error_stats_service_stub, :list_events, request, response, operation, options
                yield response, operation if block_given?
                return response
              end
            rescue ::GRPC::BadStatus => e
              raise ::Google::Cloud::Error.from_error(e)
            end

            ##
            # Deletes all error events of a given project.
            #
            # @overload delete_events(request, options = nil)
            #   Pass arguments to `delete_events` via a request object, either of type
            #   {::Google::Cloud::ErrorReporting::V1beta1::DeleteEventsRequest} or an equivalent Hash.
            #
            #   @param request [::Google::Cloud::ErrorReporting::V1beta1::DeleteEventsRequest, ::Hash]
            #     A request object representing the call parameters. Required. To specify no
            #     parameters, or to keep all the default parameter values, pass an empty Hash.
            #   @param options [::Gapic::CallOptions, ::Hash]
            #     Overrides the default settings for this call, e.g, timeout, retries, etc. Optional.
            #
            # @overload delete_events(project_name: nil)
            #   Pass arguments to `delete_events` via keyword arguments. Note that at
            #   least one keyword argument is required. To specify no parameters, or to keep all
            #   the default parameter values, pass an empty Hash as a request object (see above).
            #
            #   @param project_name [::String]
            #     Required. The resource name of the Google Cloud Platform project. Written
            #     as `projects/{projectID}`, where `{projectID}` is the
            #     [Google Cloud Platform project
            #     ID](https://support.google.com/cloud/answer/6158840).
            #
            #     Example: `projects/my-project-123`.
            #
            # @yield [response, operation] Access the result along with the RPC operation
            # @yieldparam response [::Google::Cloud::ErrorReporting::V1beta1::DeleteEventsResponse]
            # @yieldparam operation [::GRPC::ActiveCall::Operation]
            #
            # @return [::Google::Cloud::ErrorReporting::V1beta1::DeleteEventsResponse]
            #
            # @raise [::Google::Cloud::Error] if the RPC is aborted.
            #
            def delete_events request, options = nil
              raise ::ArgumentError, "request must be provided" if request.nil?

              request = ::Gapic::Protobuf.coerce request, to: ::Google::Cloud::ErrorReporting::V1beta1::DeleteEventsRequest

              # Converts hash and nil to an options object
              options = ::Gapic::CallOptions.new(**options.to_h) if options.respond_to? :to_h

              # Customize the options with defaults
              metadata = @config.rpcs.delete_events.metadata.to_h

              # Set x-goog-api-client and x-goog-user-project headers
              metadata[:"x-goog-api-client"] ||= ::Gapic::Headers.x_goog_api_client \
                lib_name: @config.lib_name, lib_version: @config.lib_version,
                gapic_version: ::Google::Cloud::ErrorReporting::V1beta1::VERSION
              metadata[:"x-goog-user-project"] = @quota_project_id if @quota_project_id

              header_params = {
                "project_name" => request.project_name
              }
              request_params_header = header_params.map { |k, v| "#{k}=#{v}" }.join("&")
              metadata[:"x-goog-request-params"] ||= request_params_header

              options.apply_defaults timeout:      @config.rpcs.delete_events.timeout,
                                     metadata:     metadata,
                                     retry_policy: @config.rpcs.delete_events.retry_policy
              options.apply_defaults metadata:     @config.metadata,
                                     retry_policy: @config.retry_policy

              @error_stats_service_stub.call_rpc :delete_events, request, options: options do |response, operation|
                yield response, operation if block_given?
                return response
              end
            rescue ::GRPC::BadStatus => e
              raise ::Google::Cloud::Error.from_error(e)
            end

            ##
            # Configuration class for the ErrorStatsService API.
            #
            # This class represents the configuration for ErrorStatsService,
            # providing control over timeouts, retry behavior, logging, transport
            # parameters, and other low-level controls. Certain parameters can also be
            # applied individually to specific RPCs. See
            # {::Google::Cloud::ErrorReporting::V1beta1::ErrorStatsService::Client::Configuration::Rpcs}
            # for a list of RPCs that can be configured independently.
            #
            # Configuration can be applied globally to all clients, or to a single client
            # on construction.
            #
            # # Examples
            #
            # To modify the global config, setting the timeout for list_group_stats
            # to 20 seconds, and all remaining timeouts to 10 seconds:
            #
            #     ::Google::Cloud::ErrorReporting::V1beta1::ErrorStatsService::Client.configure do |config|
            #       config.timeout = 10.0
            #       config.rpcs.list_group_stats.timeout = 20.0
            #     end
            #
            # To apply the above configuration only to a new client:
            #
            #     client = ::Google::Cloud::ErrorReporting::V1beta1::ErrorStatsService::Client.new do |config|
            #       config.timeout = 10.0
            #       config.rpcs.list_group_stats.timeout = 20.0
            #     end
            #
            # @!attribute [rw] endpoint
            #   The hostname or hostname:port of the service endpoint.
            #   Defaults to `"clouderrorreporting.googleapis.com"`.
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

              config_attr :endpoint,      "clouderrorreporting.googleapis.com", ::String
              config_attr :credentials,   nil do |value|
                allowed = [::String, ::Hash, ::Proc, ::Symbol, ::Google::Auth::Credentials, ::Signet::OAuth2::Client, nil]
                allowed += [::GRPC::Core::Channel, ::GRPC::Core::ChannelCredentials] if defined? ::GRPC
                allowed.any? { |klass| klass === value }
              end
              config_attr :scope,         nil, ::String, ::Array, nil
              config_attr :lib_name,      nil, ::String, nil
              config_attr :lib_version,   nil, ::String, nil
              config_attr(:channel_args,  { "grpc.service_config_disable_resolution"=>1 }, ::Hash, nil)
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
                  parent_rpcs = @parent_config.rpcs if defined?(@parent_config) && @parent_config&.respond_to?(:rpcs)
                  Rpcs.new parent_rpcs
                end
              end

              ##
              # Configuration RPC class for the ErrorStatsService API.
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
                # RPC-specific configuration for `list_group_stats`
                # @return [::Gapic::Config::Method]
                #
                attr_reader :list_group_stats
                ##
                # RPC-specific configuration for `list_events`
                # @return [::Gapic::Config::Method]
                #
                attr_reader :list_events
                ##
                # RPC-specific configuration for `delete_events`
                # @return [::Gapic::Config::Method]
                #
                attr_reader :delete_events

                # @private
                def initialize parent_rpcs = nil
                  list_group_stats_config = parent_rpcs&.list_group_stats if parent_rpcs&.respond_to? :list_group_stats
                  @list_group_stats = ::Gapic::Config::Method.new list_group_stats_config
                  list_events_config = parent_rpcs&.list_events if parent_rpcs&.respond_to? :list_events
                  @list_events = ::Gapic::Config::Method.new list_events_config
                  delete_events_config = parent_rpcs&.delete_events if parent_rpcs&.respond_to? :delete_events
                  @delete_events = ::Gapic::Config::Method.new delete_events_config

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