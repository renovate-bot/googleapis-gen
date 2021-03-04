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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/dialogflow/v2beta1/participant.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/dialogflow/v2beta1/participant_pb"
require "google/cloud/dialogflow/v2beta1/credentials"

module Google
  module Cloud
    module Dialogflow
      module V2beta1
        # Service for managing {Google::Cloud::Dialogflow::V2beta1::Participant Participants}.
        #
        # @!attribute [r] participants_stub
        #   @return [Google::Cloud::Dialogflow::V2beta1::Participants::Stub]
        class ParticipantsClient
          attr_reader :participants_stub

          # The default address of the service.
          SERVICE_ADDRESS = "dialogflow.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_participants" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "participants"),
            "list_suggestions" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "suggestions")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/dialogflow"
          ].freeze


          CONVERSATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/conversations/{conversation}"
          )

          private_constant :CONVERSATION_PATH_TEMPLATE

          MESSAGE_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/conversations/{conversation}/messages/{message}"
          )

          private_constant :MESSAGE_PATH_TEMPLATE

          PARTICIPANT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/conversations/{conversation}/participants/{participant}"
          )

          private_constant :PARTICIPANT_PATH_TEMPLATE

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

          # Returns a fully-qualified message resource name string.
          # @param project [String]
          # @param conversation [String]
          # @param message [String]
          # @return [String]
          def self.message_path project, conversation, message
            MESSAGE_PATH_TEMPLATE.render(
              :"project" => project,
              :"conversation" => conversation,
              :"message" => message
            )
          end

          # Returns a fully-qualified participant resource name string.
          # @param project [String]
          # @param conversation [String]
          # @param participant [String]
          # @return [String]
          def self.participant_path project, conversation, participant
            PARTICIPANT_PATH_TEMPLATE.render(
              :"project" => project,
              :"conversation" => conversation,
              :"participant" => participant
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
            require "google/cloud/dialogflow/v2beta1/participant_services_pb"

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
              "participants_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.dialogflow.v2beta1.Participants",
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
            @participants_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Dialogflow::V2beta1::Participants::Stub.method(:new)
            )

            @create_participant = Google::Gax.create_api_call(
              @participants_stub.method(:create_participant),
              defaults["create_participant"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_participant = Google::Gax.create_api_call(
              @participants_stub.method(:get_participant),
              defaults["get_participant"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_participants = Google::Gax.create_api_call(
              @participants_stub.method(:list_participants),
              defaults["list_participants"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @update_participant = Google::Gax.create_api_call(
              @participants_stub.method(:update_participant),
              defaults["update_participant"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'participant.name' => request.participant.name}
              end
            )
            @analyze_content = Google::Gax.create_api_call(
              @participants_stub.method(:analyze_content),
              defaults["analyze_content"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'participant' => request.participant}
              end
            )
            @streaming_analyze_content = Google::Gax.create_api_call(
              @participants_stub.method(:streaming_analyze_content),
              defaults["streaming_analyze_content"],
              exception_transformer: exception_transformer
            )
            @suggest_articles = Google::Gax.create_api_call(
              @participants_stub.method(:suggest_articles),
              defaults["suggest_articles"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @suggest_faq_answers = Google::Gax.create_api_call(
              @participants_stub.method(:suggest_faq_answers),
              defaults["suggest_faq_answers"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @suggest_smart_replies = Google::Gax.create_api_call(
              @participants_stub.method(:suggest_smart_replies),
              defaults["suggest_smart_replies"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @list_suggestions = Google::Gax.create_api_call(
              @participants_stub.method(:list_suggestions),
              defaults["list_suggestions"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @compile_suggestion = Google::Gax.create_api_call(
              @participants_stub.method(:compile_suggestion),
              defaults["compile_suggestion"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
          end

          # Service calls

          # Creates a new participant in a conversation.
          #
          # @param parent [String]
          #   Required. Resource identifier of the conversation adding the participant.
          #   Format: `projects/<Project ID>/locations/<Location
          #   ID>/conversations/<Conversation ID>`.
          # @param participant [Google::Cloud::Dialogflow::V2beta1::Participant | Hash]
          #   Required. The participant to create.
          #   A hash of the same form as `Google::Cloud::Dialogflow::V2beta1::Participant`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Dialogflow::V2beta1::Participant]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Dialogflow::V2beta1::Participant]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   participants_client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #
          #   # TODO: Initialize `participant`:
          #   participant = {}
          #   response = participants_client.create_participant(parent, participant)

          def create_participant \
              parent,
              participant,
              options: nil,
              &block
            req = {
              parent: parent,
              participant: participant
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::CreateParticipantRequest)
            @create_participant.call(req, options, &block)
          end

          # Retrieves a conversation participant.
          #
          # @param name [String]
          #   Required. The name of the participant. Format:
          #   `projects/<Project ID>/locations/<Location ID>/conversations/<Conversation
          #   ID>/participants/<Participant ID>`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Dialogflow::V2beta1::Participant]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Dialogflow::V2beta1::Participant]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   participants_client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)
          #
          #   # TODO: Initialize `name`:
          #   name = ''
          #   response = participants_client.get_participant(name)

          def get_participant \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::GetParticipantRequest)
            @get_participant.call(req, options, &block)
          end

          # Returns the list of all participants in the specified conversation.
          #
          # @param parent [String]
          #   Required. The conversation to list all participants from.
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::V2beta1::Participant>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::V2beta1::Participant>]
          #   An enumerable of Google::Cloud::Dialogflow::V2beta1::Participant instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   participants_client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #
          #   # Iterate over all results.
          #   participants_client.list_participants(parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   participants_client.list_participants(parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_participants \
              parent,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::ListParticipantsRequest)
            @list_participants.call(req, options, &block)
          end

          # Updates the specified participant.
          #
          # @param participant [Google::Cloud::Dialogflow::V2beta1::Participant | Hash]
          #   Required. The participant to update.
          #   A hash of the same form as `Google::Cloud::Dialogflow::V2beta1::Participant`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Required. The mask to specify which fields to update.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Dialogflow::V2beta1::Participant]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Dialogflow::V2beta1::Participant]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   participants_client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)
          #
          #   # TODO: Initialize `participant`:
          #   participant = {}
          #
          #   # TODO: Initialize `update_mask`:
          #   update_mask = {}
          #   response = participants_client.update_participant(participant, update_mask)

          def update_participant \
              participant,
              update_mask,
              options: nil,
              &block
            req = {
              participant: participant,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::UpdateParticipantRequest)
            @update_participant.call(req, options, &block)
          end

          # Adds a text (chat, for example), or audio (phone recording, for example)
          # message from a participant into the conversation.
          #
          # Note: Always use agent versions for production traffic
          # sent to virtual agents. See [Versions and
          # environments(https://cloud.google.com/dialogflow/es/docs/agents-versions).
          #
          # @param participant [String]
          #   Required. The name of the participant this text comes from.
          #   Format: `projects/<Project ID>/locations/<Location
          #   ID>/conversations/<Conversation ID>/participants/<Participant ID>`.
          # @param text [Google::Cloud::Dialogflow::V2beta1::InputText | Hash]
          #   The natural language text to be processed.
          #   A hash of the same form as `Google::Cloud::Dialogflow::V2beta1::InputText`
          #   can also be provided.
          # @param audio [Google::Cloud::Dialogflow::V2beta1::InputAudio | Hash]
          #   The natural language speech audio to be processed.
          #   A hash of the same form as `Google::Cloud::Dialogflow::V2beta1::InputAudio`
          #   can also be provided.
          # @param text_input [Google::Cloud::Dialogflow::V2beta1::TextInput | Hash]
          #   The natural language text to be processed.
          #   A hash of the same form as `Google::Cloud::Dialogflow::V2beta1::TextInput`
          #   can also be provided.
          # @param audio_input [Google::Cloud::Dialogflow::V2beta1::AudioInput | Hash]
          #   The natural language speech audio to be processed.
          #   A hash of the same form as `Google::Cloud::Dialogflow::V2beta1::AudioInput`
          #   can also be provided.
          # @param event_input [Google::Cloud::Dialogflow::V2beta1::EventInput | Hash]
          #   An input event to send to Dialogflow.
          #   A hash of the same form as `Google::Cloud::Dialogflow::V2beta1::EventInput`
          #   can also be provided.
          # @param reply_audio_config [Google::Cloud::Dialogflow::V2beta1::OutputAudioConfig | Hash]
          #   Speech synthesis configuration.
          #   The speech synthesis settings for a virtual agent that may be configured
          #   for the associated conversation profile are not used when calling
          #   AnalyzeContent. If this configuration is not supplied, speech synthesis
          #   is disabled.
          #   A hash of the same form as `Google::Cloud::Dialogflow::V2beta1::OutputAudioConfig`
          #   can also be provided.
          # @param query_params [Google::Cloud::Dialogflow::V2beta1::QueryParameters | Hash]
          #   Parameters for a Dialogflow virtual-agent query.
          #   A hash of the same form as `Google::Cloud::Dialogflow::V2beta1::QueryParameters`
          #   can also be provided.
          # @param message_send_time [Google::Protobuf::Timestamp | Hash]
          #   Optional. The send time of the message from end user or human agent's
          #   perspective. It is used for identifying the same message under one
          #   participant.
          #
          #   Given two messages under the same participant:
          #   * If send time are different regardless of whether the content of the
          #     messages are exactly the same, the conversation will regard them as
          #     two distinct messages sent by the participant.
          #   * If send time is the same regardless of whether the content of the
          #     messages are exactly the same, the conversation will regard them as
          #     same message, and ignore the message received later.
          #
          #   If the value is not provided, a new request will always be regarded as a
          #   new message without any de-duplication.
          #   A hash of the same form as `Google::Protobuf::Timestamp`
          #   can also be provided.
          # @param request_id [String]
          #   A unique identifier for this request. Restricted to 36 ASCII characters.
          #   A random UUID is recommended.
          #   This request is only idempotent if a `request_id` is provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Dialogflow::V2beta1::AnalyzeContentResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Dialogflow::V2beta1::AnalyzeContentResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   participants_client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)
          #
          #   # TODO: Initialize `participant`:
          #   participant = ''
          #   response = participants_client.analyze_content(participant)

          def analyze_content \
              participant,
              text: nil,
              audio: nil,
              text_input: nil,
              audio_input: nil,
              event_input: nil,
              reply_audio_config: nil,
              query_params: nil,
              message_send_time: nil,
              request_id: nil,
              options: nil,
              &block
            req = {
              participant: participant,
              text: text,
              audio: audio,
              text_input: text_input,
              audio_input: audio_input,
              event_input: event_input,
              reply_audio_config: reply_audio_config,
              query_params: query_params,
              message_send_time: message_send_time,
              request_id: request_id
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::AnalyzeContentRequest)
            @analyze_content.call(req, options, &block)
          end

          # Adds a text (e.g., chat) or audio (e.g., phone recording) message from a
          # participant into the conversation.
          # Note: This method is only available through the gRPC API (not REST).
          #
          # The top-level message sent to the client by the server is
          # `StreamingAnalyzeContentResponse`. Multiple response messages can be
          # returned in order. The first one or more messages contain the
          # `recognition_result` field. Each result represents a more complete
          # transcript of what the user said. The next message contains the
          # `reply_text` field, and potentially the `reply_audio` and/or the
          # `automated_agent_reply` fields.
          #
          # Note: Always use agent versions for production traffic
          # sent to virtual agents. See [Versions and
          # environments(https://cloud.google.com/dialogflow/es/docs/agents-versions).
          #
          # @param reqs [Enumerable<Google::Cloud::Dialogflow::V2beta1::StreamingAnalyzeContentRequest>]
          #   The input requests.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @return [Enumerable<Google::Cloud::Dialogflow::V2beta1::StreamingAnalyzeContentResponse>]
          #   An enumerable of Google::Cloud::Dialogflow::V2beta1::StreamingAnalyzeContentResponse instances.
          #
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          #
          # @note
          #   EXPERIMENTAL:
          #     Streaming requests are still undergoing review.
          #     This method interface might change in the future.
          #
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   participants_client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)
          #
          #   # TODO: Initialize `participant`:
          #   participant = ''
          #   request = { participant: participant }
          #   requests = [request]
          #   participants_client.streaming_analyze_content(requests).each do |element|
          #     # Process element.
          #   end

          def streaming_analyze_content reqs, options: nil
            request_protos = reqs.lazy.map do |req|
              Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::StreamingAnalyzeContentRequest)
            end
            @streaming_analyze_content.call(request_protos, options)
          end

          # Gets suggested articles for a participant based on specific historical
          # messages.
          #
          # Note that {Google::Cloud::Dialogflow::V2beta1::Participants::ListSuggestions ListSuggestions} will only list the auto-generated
          # suggestions, while {Google::Cloud::Dialogflow::V2beta1::Participants::CompileSuggestion CompileSuggestion} will try to compile suggestion
          # based on the provided conversation context in the real time.
          #
          # @param parent [String]
          #   Required. The name of the participant to fetch suggestion for.
          #   Format: `projects/<Project ID>/locations/<Location
          #   ID>/conversations/<Conversation ID>/participants/<Participant ID>`.
          # @param latest_message [String]
          #   Optional. The name of the latest conversation message to compile suggestion
          #   for. If empty, it will be the latest message of the conversation.
          #
          #   Format: `projects/<Project ID>/locations/<Location
          #   ID>/conversations/<Conversation ID>/messages/<Message ID>`.
          # @param context_size [Integer]
          #   Optional. Max number of messages prior to and including
          #   {Google::Cloud::Dialogflow::V2beta1::SuggestArticlesRequest#latest_message latest_message} to use as context
          #   when compiling the suggestion. By default 20 and at most 50.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Dialogflow::V2beta1::SuggestArticlesResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Dialogflow::V2beta1::SuggestArticlesResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   participants_client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #   response = participants_client.suggest_articles(parent)

          def suggest_articles \
              parent,
              latest_message: nil,
              context_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              latest_message: latest_message,
              context_size: context_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::SuggestArticlesRequest)
            @suggest_articles.call(req, options, &block)
          end

          # Gets suggested faq answers for a participant based on specific historical
          # messages.
          #
          # @param parent [String]
          #   Required. The name of the participant to fetch suggestion for.
          #   Format: `projects/<Project ID>/locations/<Location
          #   ID>/conversations/<Conversation ID>/participants/<Participant ID>`.
          # @param latest_message [String]
          #   Optional. The name of the latest conversation message to compile suggestion
          #   for. If empty, it will be the latest message of the conversation.
          #
          #   Format: `projects/<Project ID>/locations/<Location
          #   ID>/conversations/<Conversation ID>/messages/<Message ID>`.
          # @param context_size [Integer]
          #   Optional. Max number of messages prior to and including
          #   [latest_message] to use as context when compiling the
          #   suggestion. By default 20 and at most 50.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Dialogflow::V2beta1::SuggestFaqAnswersResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Dialogflow::V2beta1::SuggestFaqAnswersResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   participants_client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #   response = participants_client.suggest_faq_answers(parent)

          def suggest_faq_answers \
              parent,
              latest_message: nil,
              context_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              latest_message: latest_message,
              context_size: context_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::SuggestFaqAnswersRequest)
            @suggest_faq_answers.call(req, options, &block)
          end

          # Gets smart replies for a participant based on specific historical
          # messages.
          #
          # @param parent [String]
          #   Required. The name of the participant to fetch suggestion for.
          #   Format: `projects/<Project ID>/locations/<Location
          #   ID>/conversations/<Conversation ID>/participants/<Participant ID>`.
          # @param current_text_input [Google::Cloud::Dialogflow::V2beta1::TextInput | Hash]
          #   The current natural language text segment to compile suggestion
          #   for. This provides a way for user to get follow up smart reply suggestion
          #   after a smart reply selection, without sending a text message.
          #   A hash of the same form as `Google::Cloud::Dialogflow::V2beta1::TextInput`
          #   can also be provided.
          # @param latest_message [String]
          #   The name of the latest conversation message to compile suggestion
          #   for. If empty, it will be the latest message of the conversation.
          #
          #   Format: `projects/<Project ID>/locations/<Location
          #   ID>/conversations/<Conversation ID>/messages/<Message ID>`.
          # @param context_size [Integer]
          #   Optional. Max number of messages prior to and including
          #   [latest_message] to use as context when compiling the
          #   suggestion. By default 20 and at most 50.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Dialogflow::V2beta1::SuggestSmartRepliesResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Dialogflow::V2beta1::SuggestSmartRepliesResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   participants_client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)
          #
          #   # TODO: Initialize `parent`:
          #   parent = ''
          #   response = participants_client.suggest_smart_replies(parent)

          def suggest_smart_replies \
              parent,
              current_text_input: nil,
              latest_message: nil,
              context_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              current_text_input: current_text_input,
              latest_message: latest_message,
              context_size: context_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::SuggestSmartRepliesRequest)
            @suggest_smart_replies.call(req, options, &block)
          end

          # Deprecated: Use inline suggestion, event based suggestion or
          # Suggestion* API instead.
          # See {Google::Cloud::Dialogflow::V2beta1::HumanAgentAssistantConfig#name HumanAgentAssistantConfig#name} for more
          # details.
          # Removal Date: 2020-09-01.
          #
          # Retrieves suggestions for live agents.
          #
          # This method should be used by human agent client software to fetch auto
          # generated suggestions in real-time, while the conversation with an end user
          # is in progress. The functionality is implemented in terms of the
          # [list pagination](https://cloud.google.com/apis/design/design_patterns#list_pagination)
          # design pattern. The client app should use the `next_page_token` field
          # to fetch the next batch of suggestions. `suggestions` are sorted by
          # `create_time` in descending order.
          # To fetch latest suggestion, just set `page_size` to 1.
          # To fetch new suggestions without duplication, send request with filter
          # `create_time_epoch_microseconds > [first item's create_time of previous
          # request]` and empty page_token.
          #
          # @param parent [String]
          #   Required. The name of the participant to fetch suggestions for.
          #   Format: `projects/<Project ID>/locations/<Location
          #   ID>/conversations/<Conversation ID>/participants/<Participant ID>`.
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param filter [String]
          #   Optional. Filter on suggestions fields. Currently predicates on
          #   `create_time` and `create_time_epoch_microseconds` are supported.
          #   `create_time` only support milliseconds accuracy. E.g.,
          #   `create_time_epoch_microseconds > 1551790877964485` or
          #   `create_time > 2017-01-15T01:30:15.01Z`
          #
          #   For more information about filtering, see
          #   [API Filtering](https://aip.dev/160).
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::V2beta1::Suggestion>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Dialogflow::V2beta1::Suggestion>]
          #   An enumerable of Google::Cloud::Dialogflow::V2beta1::Suggestion instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   participants_client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)
          #
          #   # Iterate over all results.
          #   participants_client.list_suggestions.each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   participants_client.list_suggestions.each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_suggestions \
              parent: nil,
              page_size: nil,
              filter: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size,
              filter: filter
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::ListSuggestionsRequest)
            @list_suggestions.call(req, options, &block)
          end

          # Deprecated. use {Google::Cloud::Dialogflow::V2beta1::Participants::SuggestArticles SuggestArticles} and {Google::Cloud::Dialogflow::V2beta1::Participants::SuggestFaqAnswers SuggestFaqAnswers} instead.
          #
          # Gets suggestions for a participant based on specific historical
          # messages.
          #
          # Note that {Google::Cloud::Dialogflow::V2beta1::Participants::ListSuggestions ListSuggestions} will only list the auto-generated
          # suggestions, while {Google::Cloud::Dialogflow::V2beta1::Participants::CompileSuggestion CompileSuggestion} will try to compile suggestion
          # based on the provided conversation context in the real time.
          #
          # @param parent [String]
          #   Required. The name of the participant to fetch suggestion for.
          #   Format: `projects/<Project ID>/locations/<Location
          #   ID>/conversations/<Conversation ID>/participants/<Participant ID>`.
          # @param latest_message [String]
          #   Optional. The name of the latest conversation message to compile suggestion
          #   for. If empty, it will be the latest message of the conversation.
          #
          #   Format: `projects/<Project ID>/locations/<Location
          #   ID>/conversations/<Conversation ID>/messages/<Message ID>`.
          # @param context_size [Integer]
          #   Optional. Max number of messages prior to and including
          #   [latest_message] to use as context when compiling the
          #   suggestion. If zero or less than zero, 20 is used.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Dialogflow::V2beta1::CompileSuggestionResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Dialogflow::V2beta1::CompileSuggestionResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/dialogflow"
          #
          #   participants_client = Google::Cloud::Dialogflow::Participants.new(version: :v2beta1)
          #   response = participants_client.compile_suggestion

          def compile_suggestion \
              parent: nil,
              latest_message: nil,
              context_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              latest_message: latest_message,
              context_size: context_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Dialogflow::V2beta1::CompileSuggestionRequest)
            @compile_suggestion.call(req, options, &block)
          end
        end
      end
    end
  end
end
