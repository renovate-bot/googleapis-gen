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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/dialogflow/v2beta1/conversation.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/dialogflow/v2beta1/conversation_pb"
require "google/cloud/dialogflow/v2beta1/credentials"

module Google
  module Cloud
    module Dialogflow
      module V2beta1
        # Service for managing {Google::Cloud::Dialogflow::V2beta1::Conversation Conversations}.
        #
        # @!attribute [r] conversations_stub
        #   @return [Google::Cloud::Dialogflow::V2beta1::Conversations::Stub]
        class ConversationsClient
          attr_reader :conversations_stub

          # The default address of the service.
          SERVICE_ADDRESS = "dialogflow.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_conversations" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "conversations"),
            "list_call_matchers" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "call_matchers"),
            "list_messages" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "messages")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/dialogflow"
          ].freeze


          CALL_MATCHER_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/conversations/{conversation}/callMatchers/{call_matcher}"
          )

          private_constant :CALL_MATCHER_PATH_TEMPLATE

          CONVERSATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/conversations/{conversation}"
          )

          private_constant :CONVERSATION_PATH_TEMPLATE

          CONVERSATION_PROFILE_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/conversationProfiles/{conversation_profile}"
          )

          private_constant :CONVERSATION_PROFILE_PATH_TEMPLATE

          LOCATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}"
          )

          private_constant :LOCATION_PATH_TEMPLATE

          PROJECT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}"
          )

          private_constant :PROJECT_PATH_TEMPLATE

          # Returns a fully-qualified call_matcher resource name string.
          # @param project [String]
          # @param conversation [String]
          # @param call_matcher [String]
          # @return [String]
          def self.call_matcher_path project, conversation, call_matcher
            CALL_MATCHER_PATH_TEMPLATE.render(
              :"project" => project,
              :"conversation" => conversation,
              :"call_matcher" => call_matcher
            )
          end

          # Returns a fully-qualified conversation resource name string.
          # @param project [String]
          # @param conversation [String]
          # @return [String]
          def self.conversation_path project, conversation
            CONVERSATION_PATH_TEMPLATE.render(
              :"project" => project,
              :"conversation" => conversation
            )
          end

          # Returns a fully-qualified conversation_profile resource name string.
          # @param project [String]
          # @param conversation_profile [String]
          # @return [String]
          def self.conversation_profile_path project, conversation_profile
            CONVERSATION_PROFILE_PATH_TEMPLATE.render(
              :"project" => project,
              :"conversation_profile" => conversation_profile
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

          # Returns a fully-qualified project resource name string.
          # @param project [String]
          # @return [String]
          def self.project_path project
            PROJECT_PATH_TEMPLATE.render(
              :"project" => project
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
            require "google/cloud/dialogflow/v2beta1/conversation_services_pb"

            credentials ||= Google::Cloud::Dialogflow::V2beta1::Credentials.default

            if credentials.is_a?(String) || credentials.is_a?(Hash)
              updater_proc = Google::Cloud::Dialogflow::V2beta1::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-cloud-dialogflow'].version.version

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
              "conversations_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.dialogflow.v2beta1.Conversations",
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
            @conversations_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Dialogflow::V2beta1::Conversations::Stub.method(:new)
            )

            @create_conversation = Google::Gax.create_api_call(
              @conversations_stub.method(:create_conversation),
              defaults["create_conversation"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @list_conversations = Google::Gax.create_api_call(
              @conversations_stub.method(:list_conversations),
              defaults["list_conversations"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_conversation = Google::Gax.create_api_call(
              @conversations_stub.method(:get_conversation),
              defaults["get_conversation"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @complete_conversation = Google::Gax.create_api_call(
              @conversations_stub.method(:complete_conversation),
              defaults["complete_conversation"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @create_call_matcher = Google::Gax.create_api_call(
              @conversations_stub.method(:create_call_matcher),
              defaults["create_call_matcher"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @list_call_matchers = Google::Gax.create_api_call(
              @conversations_stub.method(:list_call_matchers),
              defaults["list_call_matchers"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @delete_call_matcher = Google::Gax.create_api_call(
              @conversations_stub.method(:delete_call_matcher),
              defaults["delete_call_matcher"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @batch_create_messages = Google::Gax.create_api_call(
              @conversations_stub.method(:batch_create_messages),
              defaults["batch_create_messages"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @list_messages = Google::Gax.create_api_call(
              @conversations_stub.method(:list_messages),
              defaults["list_messages"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
          end

          # Service calls

          # Creates a new conversation. Conversations are auto-completed after 24
          # hours.
          #
          # Conversation Lifecycle:
          # There are two stages during a conversation: Automated Agent Stage and
          # Assist Stage.
          #
          # For Automated Agent Stage, there will be a dialogflow agent responding to
          # user queries.
          #
          # For Assist Stage, there's no dialogflow agent responding to user queries.
          # But we will provide suggestions which are generated from conversation.
          #
          # If {Google::Cloud::Dialogflow::V2beta1::Conversation#conversation_profile Conversation#conversation_profile} is configured for a dialogflow
          # agent, conversation will start from `Automated Agent Stage`, otherwise, it
          # will start from `Assist Stage`. And during `Automated Agent Stage`, once an
          # {Google::Cloud::Dialogflow::V2beta1::Intent Intent} with {Google::Cloud::Dialogflow::V2beta1::Intent#live_agent_handoff Intent#live_agent_handoff} is triggered, conversation
          # will transfer to Assist Stage.
          #
          # @param parent [String]
          #   Required. Resource identifier of the project creating the conversation.
          #   Format: `projects/<Project ID>/locations/<Location ID>`.
          # @param conversation [Google::Cloud::Dialogflow::V2beta1::Conversation | Hash]
          #   Required. The conversation to create.
          #   A hash of the same form as `Google::Cloud::Dialogflow::V2beta1::Conversation`
          #   can also be provided.
          # @param conversation_id [String]
          #   Optional. Identifier of the conversation. Generally it's auto generated by Google.
          #   Only set it if you cannot wait for the response to return a
          #   auto-generated one to you.
          #
          #   The conversation ID must be compliant with the regression fomula
          #   "[a-zA-Z][a-zA-Z0-9_-]*" with the characters length in range of [3,64].
          #   If the field is provided, the caller is resposible for
          #   1. the uniqueness of the ID, otherwise the request will be rejected.
          #   2. the consistency for whether to use custom ID or not under a project to
          #   better ensure uniqueness.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Dialogflow::V2beta1::Conversation]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Dialogflow::V2beta1::Conversation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   conversations_client = Google::Cloud::Dialogflow::Conversations.new(version: :v2beta1)
          #   formatted_parent = Google::Cloud::Dialogflow::V2beta1::ConversationsClient.project_path("[PROJECT]")
          #
          #   # TODO: Initialize `conversation`:
          #   conversation = {}
          #   response = conversations_client.create_conversation(formatted_parent, conversation)

          def create_conversation \
              parent,
              conversation,
              conversation_id: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              conversation: conversation,
              conversation_id: conversation_id
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::CreateConversationRequest)
            @create_conversation.call(req, options, &block)
          end

          # Returns the list of all conversations in the specified project.
          #
          # @param parent [String]
          #   Required. The project from which to list all conversation.
          #   Format: `projects/<Project ID>/locations/<Location ID>`.
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param filter [String]
          #   A filter expression that filters conversations listed in the response. In
          #   general, the expression must specify the field name, a comparison operator,
          #   and the value to use for filtering:
          #   <ul>
          #     <li>The value must be a string, a number, or a boolean.</li>
          #     <li>The comparison operator must be either `=`,`!=`, `>`, or `<`.</li>
          #     <li>To filter on multiple expressions, separate the
          #         expressions with `AND` or `OR` (omitting both implies `AND`).</li>
          #     <li>For clarity, expressions can be enclosed in parentheses.</li>
          #   </ul>
          #   Only `lifecycle_state` can be filtered on in this way. For example,
          #   the following expression only returns `COMPLETED` conversations:
          #
          #   `lifecycle_state = "COMPLETED"`
          #
          #   For more information about filtering, see
          #   [API Filtering](https://aip.dev/160).
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::V2beta1::Conversation>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::V2beta1::Conversation>]
          #   An enumerable of Google::Cloud::Dialogflow::V2beta1::Conversation instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   conversations_client = Google::Cloud::Dialogflow::Conversations.new(version: :v2beta1)
          #   formatted_parent = Google::Cloud::Dialogflow::V2beta1::ConversationsClient.project_path("[PROJECT]")
          #
          #   # Iterate over all results.
          #   conversations_client.list_conversations(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   conversations_client.list_conversations(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_conversations \
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
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::ListConversationsRequest)
            @list_conversations.call(req, options, &block)
          end

          # Retrieves the specific conversation.
          #
          # @param name [String]
          #   Required. The name of the conversation. Format:
          #   `projects/<Project ID>/locations/<Location ID>/conversations/<Conversation
          #   ID>`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Dialogflow::V2beta1::Conversation]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Dialogflow::V2beta1::Conversation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   conversations_client = Google::Cloud::Dialogflow::Conversations.new(version: :v2beta1)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #   response = conversations_client.get_conversation(name)

          def get_conversation \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::GetConversationRequest)
            @get_conversation.call(req, options, &block)
          end

          # Completes the specified conversation. Finished conversations are purged
          # from the database after 30 days.
          #
          # @param name [String]
          #   Required. Resource identifier of the conversation to close.
          #   Format: `projects/<Project ID>/locations/<Location
          #   ID>/conversations/<Conversation ID>`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Dialogflow::V2beta1::Conversation]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Dialogflow::V2beta1::Conversation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   conversations_client = Google::Cloud::Dialogflow::Conversations.new(version: :v2beta1)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #   response = conversations_client.complete_conversation(name)

          def complete_conversation \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::CompleteConversationRequest)
            @complete_conversation.call(req, options, &block)
          end

          # Creates a call matcher that links incoming SIP calls to the specified
          # conversation if they fulfill specified criteria.
          #
          # @param parent [String]
          #   Required. Resource identifier of the conversation adding the call matcher.
          #   Format: `projects/<Project ID>/locations/<Location
          #   ID>/conversations/<Conversation ID>`.
          # @param call_matcher [Google::Cloud::Dialogflow::V2beta1::CallMatcher | Hash]
          #   Required. The call matcher to create.
          #   A hash of the same form as `Google::Cloud::Dialogflow::V2beta1::CallMatcher`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Dialogflow::V2beta1::CallMatcher]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Dialogflow::V2beta1::CallMatcher]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   conversations_client = Google::Cloud::Dialogflow::Conversations.new(version: :v2beta1)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #   response = conversations_client.create_call_matcher(parent)

          def create_call_matcher \
              parent,
              call_matcher: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              call_matcher: call_matcher
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::CreateCallMatcherRequest)
            @create_call_matcher.call(req, options, &block)
          end

          # Returns the list of all call matchers in the specified conversation.
          #
          # @param parent [String]
          #   Required. The conversation to list all call matchers from.
          #   Format: `projects/<Project ID>/locations/<Location
          #   ID>/conversations/<Conversation ID>`.
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::V2beta1::CallMatcher>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::V2beta1::CallMatcher>]
          #   An enumerable of Google::Cloud::Dialogflow::V2beta1::CallMatcher instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   conversations_client = Google::Cloud::Dialogflow::Conversations.new(version: :v2beta1)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #
          #   # Iterate over all results.
          #   conversations_client.list_call_matchers(parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   conversations_client.list_call_matchers(parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_call_matchers \
              parent,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::ListCallMatchersRequest)
            @list_call_matchers.call(req, options, &block)
          end

          # Requests deletion of a call matcher.
          #
          # @param name [String]
          #   Required. The unique identifier of the {Google::Cloud::Dialogflow::V2beta1::CallMatcher CallMatcher} to delete.
          #   Format: `projects/<Project ID>/locations/<Location
          #   ID>/conversations/<Conversation ID>/callMatchers/<CallMatcher ID>`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   conversations_client = Google::Cloud::Dialogflow::Conversations.new(version: :v2beta1)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #   conversations_client.delete_call_matcher(name)

          def delete_call_matcher \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::DeleteCallMatcherRequest)
            @delete_call_matcher.call(req, options, &block)
            nil
          end

          # Batch ingests messages to conversation. Customers can use this RPC to
          # ingest historical messages to conversation.
          #
          # @param parent [String]
          #   Required. Resource identifier of the conversation to create message.
          #   Format: `projects/<Project ID>/locations/<Location
          #   ID>/conversations/<Conversation ID>`.
          # @param requests [Array<Google::Cloud::Dialogflow::V2beta1::CreateMessageRequest | Hash>]
          #   Required. A maximum of 1000 Messages can be created in a batch.
          #   {CreateMessageRequest#message#send_time} is required. All created
          #   messages will have identical {Google::Cloud::Dialogflow::V2beta1::Message#create_time Message#create_time}.
          #   A hash of the same form as `Google::Cloud::Dialogflow::V2beta1::CreateMessageRequest`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Dialogflow::V2beta1::BatchCreateMessagesResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Dialogflow::V2beta1::BatchCreateMessagesResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   conversations_client = Google::Cloud::Dialogflow::Conversations.new(version: :v2beta1)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #
          #   # TODO: Initialize `requests`:
          #   requests = []
          #   response = conversations_client.batch_create_messages(parent, requests)

          def batch_create_messages \
              parent,
              requests,
              options: nil,
              &block
            req = {
              parent: parent,
              requests: requests
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::BatchCreateMessagesRequest)
            @batch_create_messages.call(req, options, &block)
          end

          # Lists messages that belong to a given conversation.
          # `messages` are ordered by `create_time` in descending order. To fetch
          # updates without duplication, send request with filter
          # `create_time_epoch_microseconds >
          # [first item's create_time of previous request]` and empty page_token.
          #
          # @param parent [String]
          #   Required. The name of the conversation to list messages for.
          #   Format: `projects/<Project ID>/locations/<Location
          #   ID>/conversations/<Conversation ID>`
          # @param filter [String]
          #   Optional. Filter on message fields. Currently predicates on `create_time`
          #   and `create_time_epoch_microseconds` are supported. `create_time` only
          #   support milliseconds accuracy. E.g.,
          #   `create_time_epoch_microseconds > 1551790877964485` or
          #   `create_time > 2017-01-15T01:30:15.01Z`.
          #
          #   For more information about filtering, see
          #   [API Filtering](https://aip.dev/160).
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::V2beta1::Message>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::V2beta1::Message>]
          #   An enumerable of Google::Cloud::Dialogflow::V2beta1::Message instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   conversations_client = Google::Cloud::Dialogflow::Conversations.new(version: :v2beta1)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #
          #   # Iterate over all results.
          #   conversations_client.list_messages(parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   conversations_client.list_messages(parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_messages \
              parent,
              filter: nil,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              filter: filter,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::ListMessagesRequest)
            @list_messages.call(req, options, &block)
          end
        end
      end
    end
  end
end
