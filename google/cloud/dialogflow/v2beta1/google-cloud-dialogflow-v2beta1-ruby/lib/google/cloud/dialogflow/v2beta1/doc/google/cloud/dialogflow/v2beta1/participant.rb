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

module Google
  module Cloud
    module Dialogflow
      module V2beta1
        # Represents a conversation participant (human agent, virtual agent, end-user).
        # @!attribute [rw] name
        #   @return [String]
        #     Optional. The unique identifier of this participant.
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/conversations/<Conversation ID>/participants/<Participant ID>`.
        # @!attribute [rw] role
        #   @return [Google::Cloud::Dialogflow::V2beta1::Participant::Role]
        #     Immutable. The role this participant plays in the conversation. This field must be set
        #     during participant creation and is then immutable.
        # @!attribute [rw] obfuscated_external_user_id
        #   @return [String]
        #     Optional. Obfuscated user id that should be associated with the created participant.
        #
        #     You can specify a user id as follows:
        #
        #     1. If you set this field in
        #        {Google::Cloud::Dialogflow::V2beta1::CreateParticipantRequest#participant CreateParticipantRequest} or
        #        {Google::Cloud::Dialogflow::V2beta1::UpdateParticipantRequest#participant UpdateParticipantRequest},
        #        Dialogflow adds the obfuscated user id with the participant.
        #
        #     2. If you set this field in
        #        {Google::Cloud::Dialogflow::V2beta1::AnalyzeContentRequest#obfuscated_external_user_id AnalyzeContent} or
        #        {Google::Cloud::Dialogflow::V2beta1::StreamingAnalyzeContentRequest#obfuscated_external_user_id StreamingAnalyzeContent},
        #        Dialogflow will update {Google::Cloud::Dialogflow::V2beta1::Participant#obfuscated_external_user_id Participant#obfuscated_external_user_id}.
        #
        #     Dialogflow uses this user id for following purposes:
        #     1) Billing and measurement. If user with the same
        #     obfuscated_external_user_id is created in a later conversation, dialogflow
        #     will know it's the same user. 2) Agent assist suggestion personalization.
        #     For example, Dialogflow can use it to provide personalized smart reply
        #     suggestions for this user.
        #
        #     Note:
        #
        #     * Please never pass raw user ids to Dialogflow. Always obfuscate your user
        #       id first.
        #     * Dialogflow only accepts a UTF-8 encoded string, e.g., a hex digest of a
        #       hash function like SHA-512.
        #     * The length of the user id must be <= 256 characters.
        class Participant
          # Enumeration of the roles a participant can play in a conversation.
          module Role
            # Participant role not set.
            ROLE_UNSPECIFIED = 0

            # Participant is a human agent.
            HUMAN_AGENT = 1

            # Participant is an automated agent, such as a Dialogflow agent.
            AUTOMATED_AGENT = 2

            # Participant is an end user that has called or chatted with
            # Dialogflow services.
            END_USER = 3
          end
        end

        # Represents a message posted into a conversation.
        # @!attribute [rw] name
        #   @return [String]
        #     Optional. The unique identifier of the message.
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/conversations/<Conversation ID>/messages/<Message ID>`.
        # @!attribute [rw] content
        #   @return [String]
        #     Required. The message content.
        # @!attribute [rw] language_code
        #   @return [String]
        #     Optional. The message language.
        #     This should be a [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt)
        #     language tag. Example: "en-US".
        # @!attribute [rw] participant
        #   @return [String]
        #     Output only. The participant that sends this message.
        # @!attribute [rw] participant_role
        #   @return [Google::Cloud::Dialogflow::V2beta1::Participant::Role]
        #     Output only. The role of the participant.
        # @!attribute [rw] create_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. The time when the message was created in Contact Center AI.
        # @!attribute [rw] send_time
        #   @return [Google::Protobuf::Timestamp]
        #     Optional. The time when the message was sent.
        # @!attribute [rw] message_annotation
        #   @return [Google::Cloud::Dialogflow::V2beta1::MessageAnnotation]
        #     Output only. The annotation for the message.
        # @!attribute [rw] sentiment_analysis
        #   @return [Google::Cloud::Dialogflow::V2beta1::SentimentAnalysisResult]
        #     Output only. The sentiment analysis result for the message.
        class Message; end

        # The request message for {Google::Cloud::Dialogflow::V2beta1::Participants::CreateParticipant Participants::CreateParticipant}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. Resource identifier of the conversation adding the participant.
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/conversations/<Conversation ID>`.
        # @!attribute [rw] participant
        #   @return [Google::Cloud::Dialogflow::V2beta1::Participant]
        #     Required. The participant to create.
        class CreateParticipantRequest; end

        # The request message for {Google::Cloud::Dialogflow::V2beta1::Participants::GetParticipant Participants::GetParticipant}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the participant. Format:
        #     `projects/<Project ID>/locations/<Location ID>/conversations/<Conversation
        #     ID>/participants/<Participant ID>`.
        class GetParticipantRequest; end

        # The request message for {Google::Cloud::Dialogflow::V2beta1::Participants::ListParticipants Participants::ListParticipants}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The conversation to list all participants from.
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/conversations/<Conversation ID>`.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     Optional. The maximum number of items to return in a single page. By
        #     default 100 and at most 1000.
        # @!attribute [rw] page_token
        #   @return [String]
        #     Optional. The next_page_token value returned from a previous list request.
        class ListParticipantsRequest; end

        # The response message for {Google::Cloud::Dialogflow::V2beta1::Participants::ListParticipants Participants::ListParticipants}.
        # @!attribute [rw] participants
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Participant>]
        #     The list of participants. There is a maximum number of items
        #     returned based on the page_size field in the request.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     Token to retrieve the next page of results or empty if there are no
        #     more results in the list.
        class ListParticipantsResponse; end

        # The request message for {Google::Cloud::Dialogflow::V2beta1::Participants::UpdateParticipant Participants::UpdateParticipant}.
        # @!attribute [rw] participant
        #   @return [Google::Cloud::Dialogflow::V2beta1::Participant]
        #     Required. The participant to update.
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Required. The mask to specify which fields to update.
        class UpdateParticipantRequest; end

        # Represents the natural language text to be processed.
        # @!attribute [rw] text
        #   @return [String]
        #     Required. The UTF-8 encoded natural language text to be processed.
        #     Text length must not exceed 256 bytes.
        # @!attribute [rw] language_code
        #   @return [String]
        #     Required. The language of this conversational query. See [Language
        #     Support](https://cloud.google.com/dialogflow/docs/reference/language)
        #     for a list of the currently supported language codes.
        class InputText; end

        # Represents the natural language speech audio to be processed.
        # @!attribute [rw] config
        #   @return [Google::Cloud::Dialogflow::V2beta1::InputAudioConfig]
        #     Required. Instructs the speech recognizer how to process the speech audio.
        # @!attribute [rw] audio
        #   @return [String]
        #     Required. The natural language speech audio to be processed.
        #     A single request can contain up to 1 minute of speech audio data.
        #     The transcribed text cannot contain more than 256 bytes.
        class InputAudio; end

        # Represents the natural language speech audio to be processed.
        # @!attribute [rw] config
        #   @return [Google::Cloud::Dialogflow::V2beta1::InputAudioConfig]
        #     Required. Instructs the speech recognizer how to process the speech audio.
        # @!attribute [rw] audio
        #   @return [String]
        #     Required. The natural language speech audio to be processed.
        #     A single request can contain up to 1 minute of speech audio data.
        #     The transcribed text cannot contain more than 256 bytes.
        class AudioInput; end

        # Represents the natural language speech audio to be played to the end user.
        # @!attribute [rw] config
        #   @return [Google::Cloud::Dialogflow::V2beta1::OutputAudioConfig]
        #     Required. Instructs the speech synthesizer how to generate the speech
        #     audio.
        # @!attribute [rw] audio
        #   @return [String]
        #     Required. The natural language speech audio.
        class OutputAudio; end

        # Represents a response from an automated agent.
        # @!attribute [rw] detect_intent_response
        #   @return [Google::Cloud::Dialogflow::V2beta1::DetectIntentResponse]
        #     Response of the Dialogflow {Google::Cloud::Dialogflow::V2beta1::Sessions::DetectIntent Sessions::DetectIntent} call.
        # @!attribute [rw] response_messages
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::ResponseMessage>]
        #     Response messages from the automated agent.
        # @!attribute [rw] intent
        #   @return [String]
        #     Name of the intent if an intent is matched for the query.
        #     For a V2 query, the value format is `projects/<Project ID>/locations/
        #     <Location ID>/agent/intents/<Intent ID>`.
        #     For a V3 query, the value format is `projects/<Project ID>/locations/
        #     <Location ID>/agents/<Agent ID>/intents/<Intent ID>`.
        # @!attribute [rw] event
        #   @return [String]
        #     Event name if an event is triggered for the query.
        # @!attribute [rw] cx_session_parameters
        #   @return [Google::Protobuf::Struct]
        #     The collection of current Dialogflow CX agent session parameters at the
        #     time of this response.
        class AutomatedAgentReply; end

        # The type of Human Agent Assistant API suggestion to perform, and the maximum
        # number of results to return for that type. Multiple `Feature` objects can
        # be specified in the `features` list.
        # @!attribute [rw] type
        #   @return [Google::Cloud::Dialogflow::V2beta1::SuggestionFeature::Type]
        #     Type of Human Agent Assistant API feature to request.
        class SuggestionFeature
          # Defines the type of Human Agent Assistant feature.
          module Type
            # Unspecified feature type.
            TYPE_UNSPECIFIED = 0

            # Run article suggestion model.
            ARTICLE_SUGGESTION = 1

            # Run FAQ model.
            FAQ = 2

            # Run smart reply model.
            SMART_REPLY = 3
          end
        end

        # The request message for {Google::Cloud::Dialogflow::V2beta1::Participants::AnalyzeContent Participants::AnalyzeContent}.
        # @!attribute [rw] participant
        #   @return [String]
        #     Required. The name of the participant this text comes from.
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/conversations/<Conversation ID>/participants/<Participant ID>`.
        # @!attribute [rw] text
        #   @return [Google::Cloud::Dialogflow::V2beta1::InputText]
        #     The natural language text to be processed.
        # @!attribute [rw] audio
        #   @return [Google::Cloud::Dialogflow::V2beta1::InputAudio]
        #     The natural language speech audio to be processed.
        # @!attribute [rw] text_input
        #   @return [Google::Cloud::Dialogflow::V2beta1::TextInput]
        #     The natural language text to be processed.
        # @!attribute [rw] audio_input
        #   @return [Google::Cloud::Dialogflow::V2beta1::AudioInput]
        #     The natural language speech audio to be processed.
        # @!attribute [rw] event_input
        #   @return [Google::Cloud::Dialogflow::V2beta1::EventInput]
        #     An input event to send to Dialogflow.
        # @!attribute [rw] reply_audio_config
        #   @return [Google::Cloud::Dialogflow::V2beta1::OutputAudioConfig]
        #     Speech synthesis configuration.
        #     The speech synthesis settings for a virtual agent that may be configured
        #     for the associated conversation profile are not used when calling
        #     AnalyzeContent. If this configuration is not supplied, speech synthesis
        #     is disabled.
        # @!attribute [rw] query_params
        #   @return [Google::Cloud::Dialogflow::V2beta1::QueryParameters]
        #     Parameters for a Dialogflow virtual-agent query.
        # @!attribute [rw] message_send_time
        #   @return [Google::Protobuf::Timestamp]
        #     Optional. The send time of the message from end user or human agent's
        #     perspective. It is used for identifying the same message under one
        #     participant.
        #
        #     Given two messages under the same participant:
        #     * If send time are different regardless of whether the content of the
        #       messages are exactly the same, the conversation will regard them as
        #       two distinct messages sent by the participant.
        #     * If send time is the same regardless of whether the content of the
        #       messages are exactly the same, the conversation will regard them as
        #       same message, and ignore the message received later.
        #
        #     If the value is not provided, a new request will always be regarded as a
        #     new message without any de-duplication.
        # @!attribute [rw] request_id
        #   @return [String]
        #     A unique identifier for this request. Restricted to 36 ASCII characters.
        #     A random UUID is recommended.
        #     This request is only idempotent if a `request_id` is provided.
        class AnalyzeContentRequest; end

        # The message in the response that indicates the parameters of DTMF.
        # @!attribute [rw] accepts_dtmf_input
        #   @return [true, false]
        #     Indicates whether DTMF input can be handled in the next request.
        class DtmfParameters; end

        # The response message for {Google::Cloud::Dialogflow::V2beta1::Participants::AnalyzeContent Participants::AnalyzeContent}.
        # @!attribute [rw] reply_text
        #   @return [String]
        #     Output only. The output text content.
        #     This field is set if the automated agent responded with text to show to
        #     the user.
        # @!attribute [rw] reply_audio
        #   @return [Google::Cloud::Dialogflow::V2beta1::OutputAudio]
        #     Optional. The audio data bytes encoded as specified in the request.
        #     This field is set if:
        #
        #     * `reply_audio_config` was specified in the request, or
        #       * The automated agent responded with audio to play to the user. In such
        #         case, `reply_audio.config` contains settings used to synthesize the
        #         speech.
        #
        #       In some scenarios, multiple output audio fields may be present in the
        #       response structure. In these cases, only the top-most-level audio output
        #       has content.
        # @!attribute [rw] automated_agent_reply
        #   @return [Google::Cloud::Dialogflow::V2beta1::AutomatedAgentReply]
        #     Optional. Only set if a Dialogflow automated agent has responded.
        #     Note that: {AutomatedAgentReply#detect_intent_response#output_audio}
        #     and {AutomatedAgentReply#detect_intent_response#output_audio_config}
        #     are always empty, use {Google::Cloud::Dialogflow::V2beta1::AnalyzeContentResponse#reply_audio reply_audio} instead.
        # @!attribute [rw] message
        #   @return [Google::Cloud::Dialogflow::V2beta1::Message]
        #     Output only. Message analyzed by CCAI.
        # @!attribute [rw] human_agent_suggestion_results
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::SuggestionResult>]
        #     The suggestions for most recent human agent. The order is the same as
        #     {Google::Cloud::Dialogflow::V2beta1::HumanAgentAssistantConfig::SuggestionConfig#feature_configs HumanAgentAssistantConfig::SuggestionConfig#feature_configs} of
        #     {Google::Cloud::Dialogflow::V2beta1::HumanAgentAssistantConfig#human_agent_suggestion_config HumanAgentAssistantConfig#human_agent_suggestion_config}.
        # @!attribute [rw] end_user_suggestion_results
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::SuggestionResult>]
        #     The suggestions for end user. The order is the same as
        #     {Google::Cloud::Dialogflow::V2beta1::HumanAgentAssistantConfig::SuggestionConfig#feature_configs HumanAgentAssistantConfig::SuggestionConfig#feature_configs} of
        #     {Google::Cloud::Dialogflow::V2beta1::HumanAgentAssistantConfig#end_user_suggestion_config HumanAgentAssistantConfig#end_user_suggestion_config}.
        # @!attribute [rw] dtmf_parameters
        #   @return [Google::Cloud::Dialogflow::V2beta1::DtmfParameters]
        #     Indicates the parameters of DTMF.
        class AnalyzeContentResponse; end

        # Defines the language used in the input text.
        # @!attribute [rw] language_code
        #   @return [String]
        #     Required. The language of this conversational query. See [Language
        #     Support](https://cloud.google.com/dialogflow/docs/reference/language)
        #     for a list of the currently supported language codes.
        class InputTextConfig; end

        # The top-level message sent by the client to the
        # {Google::Cloud::Dialogflow::V2beta1::Participants::StreamingAnalyzeContent Participants::StreamingAnalyzeContent} method.
        #
        # Multiple request messages should be sent in order:
        #
        # 1.  The first message must contain
        #     {Google::Cloud::Dialogflow::V2beta1::StreamingAnalyzeContentRequest#participant participant},
        #     {Google::Cloud::Dialogflow::V2beta1::StreamingAnalyzeContentRequest#config config} and optionally
        #     {Google::Cloud::Dialogflow::V2beta1::StreamingAnalyzeContentRequest#query_params query_params}. If you want
        #     to receive an audio response, it should also contain
        #     {Google::Cloud::Dialogflow::V2beta1::StreamingAnalyzeContentRequest#reply_audio_config reply_audio_config}.
        #     The message must not contain
        #     {Google::Cloud::Dialogflow::V2beta1::StreamingAnalyzeContentRequest#input input}.
        #
        # 2.  If {Google::Cloud::Dialogflow::V2beta1::StreamingAnalyzeContentRequest#config config} in the first message
        #     was set to {Google::Cloud::Dialogflow::V2beta1::StreamingAnalyzeContentRequest#audio_config audio_config},
        #     all subsequent messages must contain
        #     {Google::Cloud::Dialogflow::V2beta1::StreamingAnalyzeContentRequest#input_audio input_audio} to continue
        #     with Speech recognition.
        #     If you decide to rather analyze text input after you already started
        #     Speech recognition, please send a message with
        #     {Google::Cloud::Dialogflow::V2beta1::StreamingAnalyzeContentRequest#input_text StreamingAnalyzeContentRequest#input_text}.
        #
        #     However, note that:
        #
        # * Dialogflow will bill you for the audio so far.
        #   * Dialogflow discards all Speech recognition results in favor of the
        #     text input.
        #
        #   3. If {Google::Cloud::Dialogflow::V2beta1::StreamingAnalyzeContentRequest#config StreamingAnalyzeContentRequest#config} in the first message was set
        #   to {Google::Cloud::Dialogflow::V2beta1::StreamingAnalyzeContentRequest#text_config StreamingAnalyzeContentRequest#text_config}, then the second message
        #   must contain only {Google::Cloud::Dialogflow::V2beta1::StreamingAnalyzeContentRequest#input_text input_text}.
        #   Moreover, you must not send more than two messages.
        #
        #  After you sent all input, you must half-close or abort the request stream.
        # @!attribute [rw] participant
        #   @return [String]
        #     Required. The name of the participant this text comes from.
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/conversations/<Conversation ID>/participants/<Participant ID>`.
        # @!attribute [rw] audio_config
        #   @return [Google::Cloud::Dialogflow::V2beta1::InputAudioConfig]
        #     Instructs the speech recognizer how to process the speech audio.
        # @!attribute [rw] text_config
        #   @return [Google::Cloud::Dialogflow::V2beta1::InputTextConfig]
        #     The natural language text to be processed.
        # @!attribute [rw] reply_audio_config
        #   @return [Google::Cloud::Dialogflow::V2beta1::OutputAudioConfig]
        #     Speech synthesis configuration.
        #     The speech synthesis settings for a virtual agent that may be configured
        #     for the associated conversation profile are not used when calling
        #     StreamingAnalyzeContent. If this configuration is not supplied, speech
        #     synthesis is disabled.
        # @!attribute [rw] input_audio
        #   @return [String]
        #     The input audio content to be recognized. Must be sent if `audio_config`
        #     is set in the first message. The complete audio over all streaming
        #     messages must not exceed 1 minute.
        # @!attribute [rw] input_text
        #   @return [String]
        #     The UTF-8 encoded natural language text to be processed. Must be sent if
        #     `text_config` is set in the first message. Text length must not exceed
        #     256 bytes. The `input_text` field can be only sent once.
        # @!attribute [rw] input_dtmf
        #   @return [Google::Cloud::Dialogflow::V2beta1::TelephonyDtmfEvents]
        #     The DTMF digits used to invoke intent and fill in parameter value.
        #
        #     This input is ignored if the previous response indicated that DTMF input
        #     is not accepted.
        # @!attribute [rw] query_params
        #   @return [Google::Cloud::Dialogflow::V2beta1::QueryParameters]
        #     Parameters for a Dialogflow virtual-agent query.
        # @!attribute [rw] enable_extended_streaming
        #   @return [true, false]
        #     Enable full bidirectional streaming. You can keep streaming the audio until
        #     timeout, and there's no need to half close the stream to get the response.
        #
        #     Restrictions:
        #
        #     * Timeout: 3 mins.
        #     * Audio Encoding: only supports {Google::Cloud::Dialogflow::V2beta1::AudioEncoding::AUDIO_ENCODING_LINEAR_16 AudioEncoding::AUDIO_ENCODING_LINEAR_16}
        #       and {Google::Cloud::Dialogflow::V2beta1::AudioEncoding::AUDIO_ENCODING_MULAW AudioEncoding::AUDIO_ENCODING_MULAW}
        #     * Lifecycle: conversation should be in `Assist Stage`, go to
        #       {Conversation::CreateConversation} for more information.
        #
        #     InvalidArgument Error will be returned if the one of restriction checks
        #     failed.
        #
        #     You can find more details in
        #     https://cloud.google.com/dialogflow/priv/docs/agent-assist/analyze-content-streaming
        class StreamingAnalyzeContentRequest; end

        # The top-level message returned from the `StreamingAnalyzeContent` method.
        #
        # Multiple response messages can be returned in order:
        #
        # 1.  If the input was set to streaming audio, the first one or more messages
        #     contain `recognition_result`. Each `recognition_result` represents a more
        #     complete transcript of what the user said. The last `recognition_result`
        #     has `is_final` set to `true`.
        #
        # 2.  The next message contains `reply_text` and optionally `reply_audio`
        #     returned by an agent. This message may also contain
        #     `automated_agent_reply`.
        # @!attribute [rw] recognition_result
        #   @return [Google::Cloud::Dialogflow::V2beta1::StreamingRecognitionResult]
        #     The result of speech recognition.
        # @!attribute [rw] reply_text
        #   @return [String]
        #     Optional. The output text content.
        #     This field is set if an automated agent responded with a text for the user.
        # @!attribute [rw] reply_audio
        #   @return [Google::Cloud::Dialogflow::V2beta1::OutputAudio]
        #     Optional. The audio data bytes encoded as specified in the request.
        #     This field is set if:
        #
        #     * The `reply_audio_config` field is specified in the request.
        #       * The automated agent, which this output comes from, responded with audio.
        #         In such case, the `reply_audio.config` field contains settings used to
        #         synthesize the speech.
        #
        #       In some scenarios, multiple output audio fields may be present in the
        #       response structure. In these cases, only the top-most-level audio output
        #       has content.
        # @!attribute [rw] automated_agent_reply
        #   @return [Google::Cloud::Dialogflow::V2beta1::AutomatedAgentReply]
        #     Optional. Only set if a Dialogflow automated agent has responded.
        #     Note that: {AutomatedAgentReply#detect_intent_response#output_audio}
        #     and {AutomatedAgentReply#detect_intent_response#output_audio_config}
        #     are always empty, use {Google::Cloud::Dialogflow::V2beta1::StreamingAnalyzeContentResponse#reply_audio reply_audio} instead.
        # @!attribute [rw] message
        #   @return [Google::Cloud::Dialogflow::V2beta1::Message]
        #     Output only. Message analyzed by CCAI.
        # @!attribute [rw] human_agent_suggestion_results
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::SuggestionResult>]
        #     The suggestions for most recent human agent. The order is the same as
        #     {Google::Cloud::Dialogflow::V2beta1::HumanAgentAssistantConfig::SuggestionConfig#feature_configs HumanAgentAssistantConfig::SuggestionConfig#feature_configs} of
        #     {Google::Cloud::Dialogflow::V2beta1::HumanAgentAssistantConfig#human_agent_suggestion_config HumanAgentAssistantConfig#human_agent_suggestion_config}.
        # @!attribute [rw] end_user_suggestion_results
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::SuggestionResult>]
        #     The suggestions for end user. The order is the same as
        #     {Google::Cloud::Dialogflow::V2beta1::HumanAgentAssistantConfig::SuggestionConfig#feature_configs HumanAgentAssistantConfig::SuggestionConfig#feature_configs} of
        #     {Google::Cloud::Dialogflow::V2beta1::HumanAgentAssistantConfig#end_user_suggestion_config HumanAgentAssistantConfig#end_user_suggestion_config}.
        # @!attribute [rw] dtmf_parameters
        #   @return [Google::Cloud::Dialogflow::V2beta1::DtmfParameters]
        #     Indicates the parameters of DTMF.
        class StreamingAnalyzeContentResponse; end

        # Represents a part of a message possibly annotated with an entity. The part
        # can be an entity or purely a part of the message between two entities or
        # message start/end.
        # @!attribute [rw] text
        #   @return [String]
        #     Required. A part of a message possibly annotated with an entity.
        # @!attribute [rw] entity_type
        #   @return [String]
        #     Optional. The [Dialogflow system entity
        #     type](https://cloud.google.com/dialogflow/docs/reference/system-entities)
        #     of this message part. If this is empty, Dialogflow could not annotate the
        #     phrase part with a system entity.
        # @!attribute [rw] formatted_value
        #   @return [Google::Protobuf::Value]
        #     Optional. The [Dialogflow system entity formatted value
        #     ](https://cloud.google.com/dialogflow/docs/reference/system-entities) of
        #     this message part. For example for a system entity of type
        #     `@sys.unit-currency`, this may contain:
        #     <pre>
        #     {
        #       "amount": 5,
        #       "currency": "USD"
        #     }
        #     </pre>
        class AnnotatedMessagePart; end

        # Represents the result of annotation for the message.
        # @!attribute [rw] parts
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::AnnotatedMessagePart>]
        #     Optional. The collection of annotated message parts ordered by their
        #     position in the message. You can recover the annotated message by
        #     concatenating [AnnotatedMessagePart.text].
        # @!attribute [rw] contain_entities
        #   @return [true, false]
        #     Required. Indicates whether the text message contains entities.
        class MessageAnnotation; end

        # Represents article answer.
        # @!attribute [rw] title
        #   @return [String]
        #     The article title.
        # @!attribute [rw] uri
        #   @return [String]
        #     The article URI.
        # @!attribute [rw] snippets
        #   @return [Array<String>]
        #     Output only. Article snippets.
        # @!attribute [rw] metadata
        #   @return [Hash{String => String}]
        #     A map that contains metadata about the answer and the
        #     document from which it originates.
        # @!attribute [rw] answer_record
        #   @return [String]
        #     The name of answer record, in the format of
        #     "projects/<Project ID>/locations/<Location ID>/answerRecords/<Answer Record
        #     ID>"
        class ArticleAnswer; end

        # Represents answer from "frequently asked questions".
        # @!attribute [rw] answer
        #   @return [String]
        #     The piece of text from the `source` knowledge base document.
        # @!attribute [rw] confidence
        #   @return [Float]
        #     The system's confidence score that this Knowledge answer is a good match
        #     for this conversational query, range from 0.0 (completely uncertain)
        #     to 1.0 (completely certain).
        # @!attribute [rw] question
        #   @return [String]
        #     The corresponding FAQ question.
        # @!attribute [rw] source
        #   @return [String]
        #     Indicates which Knowledge Document this answer was extracted
        #     from.
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/agent/knowledgeBases/<Knowledge Base ID>/documents/<Document ID>`.
        # @!attribute [rw] metadata
        #   @return [Hash{String => String}]
        #     A map that contains metadata about the answer and the
        #     document from which it originates.
        # @!attribute [rw] answer_record
        #   @return [String]
        #     The name of answer record, in the format of
        #     "projects/<Project ID>/locations/<Location ID>/answerRecords/<Answer Record
        #     ID>"
        class FaqAnswer; end

        # Represents a smart reply answer.
        # @!attribute [rw] reply
        #   @return [String]
        #     The content of the reply.
        # @!attribute [rw] confidence
        #   @return [Float]
        #     Smart reply confidence.
        #     The system's confidence score that this reply is a good match for
        #     this conversation, as a value from 0.0 (completely uncertain) to 1.0
        #     (completely certain).
        # @!attribute [rw] answer_record
        #   @return [String]
        #     The name of answer record, in the format of
        #     "projects/<Project ID>/locations/<Location ID>/answerRecords/<Answer Record
        #     ID>"
        class SmartReplyAnswer; end

        # One response of different type of suggestion response which is used in
        # the response of {Google::Cloud::Dialogflow::V2beta1::Participants::AnalyzeContent Participants::AnalyzeContent} and
        # {Google::Cloud::Dialogflow::V2beta1::Participants::AnalyzeContent Participants::AnalyzeContent}, as well as {Google::Cloud::Dialogflow::V2beta1::HumanAgentAssistantEvent HumanAgentAssistantEvent}.
        # @!attribute [rw] error
        #   @return [Google::Rpc::Status]
        #     Error status if the request failed.
        # @!attribute [rw] suggest_articles_response
        #   @return [Google::Cloud::Dialogflow::V2beta1::SuggestArticlesResponse]
        #     SuggestArticlesResponse if request is for ARTICLE_SUGGESTION.
        # @!attribute [rw] suggest_faq_answers_response
        #   @return [Google::Cloud::Dialogflow::V2beta1::SuggestFaqAnswersResponse]
        #     SuggestFaqAnswersResponse if request is for FAQ_ANSWER.
        # @!attribute [rw] suggest_smart_replies_response
        #   @return [Google::Cloud::Dialogflow::V2beta1::SuggestSmartRepliesResponse]
        #     SuggestSmartRepliesResponse if request is for SMART_REPLY.
        class SuggestionResult; end

        # The request message for {Google::Cloud::Dialogflow::V2beta1::Participants::SuggestArticles Participants::SuggestArticles}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The name of the participant to fetch suggestion for.
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/conversations/<Conversation ID>/participants/<Participant ID>`.
        # @!attribute [rw] latest_message
        #   @return [String]
        #     Optional. The name of the latest conversation message to compile suggestion
        #     for. If empty, it will be the latest message of the conversation.
        #
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/conversations/<Conversation ID>/messages/<Message ID>`.
        # @!attribute [rw] context_size
        #   @return [Integer]
        #     Optional. Max number of messages prior to and including
        #     {Google::Cloud::Dialogflow::V2beta1::SuggestArticlesRequest#latest_message latest_message} to use as context
        #     when compiling the suggestion. By default 20 and at most 50.
        class SuggestArticlesRequest; end

        # The response message for {Google::Cloud::Dialogflow::V2beta1::Participants::SuggestArticles Participants::SuggestArticles}.
        # @!attribute [rw] article_answers
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::ArticleAnswer>]
        #     Output only. Articles ordered by score in descending order.
        # @!attribute [rw] latest_message
        #   @return [String]
        #     The name of the latest conversation message used to compile
        #     suggestion for.
        #
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/conversations/<Conversation ID>/messages/<Message ID>`.
        # @!attribute [rw] context_size
        #   @return [Integer]
        #     Number of messages prior to and including
        #     {Google::Cloud::Dialogflow::V2beta1::SuggestArticlesResponse#latest_message latest_message} to compile the
        #     suggestion. It may be smaller than the
        #     {Google::Cloud::Dialogflow::V2beta1::SuggestArticlesResponse#context_size SuggestArticlesResponse#context_size} field in the request if there
        #     aren't that many messages in the conversation.
        class SuggestArticlesResponse; end

        # The request message for {Google::Cloud::Dialogflow::V2beta1::Participants::SuggestFaqAnswers Participants::SuggestFaqAnswers}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The name of the participant to fetch suggestion for.
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/conversations/<Conversation ID>/participants/<Participant ID>`.
        # @!attribute [rw] latest_message
        #   @return [String]
        #     Optional. The name of the latest conversation message to compile suggestion
        #     for. If empty, it will be the latest message of the conversation.
        #
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/conversations/<Conversation ID>/messages/<Message ID>`.
        # @!attribute [rw] context_size
        #   @return [Integer]
        #     Optional. Max number of messages prior to and including
        #     [latest_message] to use as context when compiling the
        #     suggestion. By default 20 and at most 50.
        class SuggestFaqAnswersRequest; end

        # The request message for {Google::Cloud::Dialogflow::V2beta1::Participants::SuggestFaqAnswers Participants::SuggestFaqAnswers}.
        # @!attribute [rw] faq_answers
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::FaqAnswer>]
        #     Output only. Answers extracted from FAQ documents.
        # @!attribute [rw] latest_message
        #   @return [String]
        #     The name of the latest conversation message used to compile
        #     suggestion for.
        #
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/conversations/<Conversation ID>/messages/<Message ID>`.
        # @!attribute [rw] context_size
        #   @return [Integer]
        #     Number of messages prior to and including
        #     {Google::Cloud::Dialogflow::V2beta1::SuggestFaqAnswersResponse#latest_message latest_message} to compile the
        #     suggestion. It may be smaller than the
        #     {Google::Cloud::Dialogflow::V2beta1::SuggestFaqAnswersRequest#context_size SuggestFaqAnswersRequest#context_size} field in the request if there
        #     aren't that many messages in the conversation.
        class SuggestFaqAnswersResponse; end

        # The request message for {Google::Cloud::Dialogflow::V2beta1::Participants::SuggestSmartReplies Participants::SuggestSmartReplies}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The name of the participant to fetch suggestion for.
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/conversations/<Conversation ID>/participants/<Participant ID>`.
        # @!attribute [rw] current_text_input
        #   @return [Google::Cloud::Dialogflow::V2beta1::TextInput]
        #     The current natural language text segment to compile suggestion
        #     for. This provides a way for user to get follow up smart reply suggestion
        #     after a smart reply selection, without sending a text message.
        # @!attribute [rw] latest_message
        #   @return [String]
        #     The name of the latest conversation message to compile suggestion
        #     for. If empty, it will be the latest message of the conversation.
        #
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/conversations/<Conversation ID>/messages/<Message ID>`.
        # @!attribute [rw] context_size
        #   @return [Integer]
        #     Optional. Max number of messages prior to and including
        #     [latest_message] to use as context when compiling the
        #     suggestion. By default 20 and at most 50.
        class SuggestSmartRepliesRequest; end

        # The response message for {Google::Cloud::Dialogflow::V2beta1::Participants::SuggestSmartReplies Participants::SuggestSmartReplies}.
        # @!attribute [rw] smart_reply_answers
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::SmartReplyAnswer>]
        #     Output only. Multiple reply options provided by smart reply service. The
        #     order is based on the rank of the model prediction.
        #     The maximum number of the returned replies is set in SmartReplyConfig.
        # @!attribute [rw] latest_message
        #   @return [String]
        #     The name of the latest conversation message used to compile
        #     suggestion for.
        #
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/conversations/<Conversation ID>/messages/<Message ID>`.
        # @!attribute [rw] context_size
        #   @return [Integer]
        #     Number of messages prior to and including
        #     {Google::Cloud::Dialogflow::V2beta1::SuggestSmartRepliesResponse#latest_message latest_message} to compile the
        #     suggestion. It may be smaller than the
        #     {Google::Cloud::Dialogflow::V2beta1::SuggestSmartRepliesRequest#context_size SuggestSmartRepliesRequest#context_size} field in the request if there
        #     aren't that many messages in the conversation.
        class SuggestSmartRepliesResponse; end

        # Represents a suggestion for a human agent.
        # @!attribute [rw] name
        #   @return [String]
        #     Output only. The name of this suggestion.
        #     Format:
        #     `projects/<Project ID>/locations/<Location ID>/conversations/<Conversation
        #     ID>/participants/*/suggestions/<Suggestion ID>`.
        # @!attribute [rw] articles
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Suggestion::Article>]
        #     Output only. Articles ordered by score in descending order.
        # @!attribute [rw] faq_answers
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Suggestion::FaqAnswer>]
        #     Output only. Answers extracted from FAQ documents.
        # @!attribute [rw] create_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. The time the suggestion was created.
        # @!attribute [rw] latest_message
        #   @return [String]
        #     Output only. Latest message used as context to compile this suggestion.
        #
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/conversations/<Conversation ID>/messages/<Message ID>`.
        class Suggestion
          # Represents suggested article.
          # @!attribute [rw] title
          #   @return [String]
          #     Output only. The article title.
          # @!attribute [rw] uri
          #   @return [String]
          #     Output only. The article URI.
          # @!attribute [rw] snippets
          #   @return [Array<String>]
          #     Output only. Article snippets.
          # @!attribute [rw] metadata
          #   @return [Hash{String => String}]
          #     Output only. A map that contains metadata about the answer and the
          #     document from which it originates.
          # @!attribute [rw] answer_record
          #   @return [String]
          #     Output only. The name of answer record, in the format of
          #     "projects/<Project ID>/locations/<Location ID>/answerRecords/<Answer
          #     Record ID>"
          class Article; end

          # Represents suggested answer from "frequently asked questions".
          # @!attribute [rw] answer
          #   @return [String]
          #     Output only. The piece of text from the `source` knowledge base document.
          # @!attribute [rw] confidence
          #   @return [Float]
          #     The system's confidence score that this Knowledge answer is a good match
          #     for this conversational query, range from 0.0 (completely uncertain)
          #     to 1.0 (completely certain).
          # @!attribute [rw] question
          #   @return [String]
          #     Output only. The corresponding FAQ question.
          # @!attribute [rw] source
          #   @return [String]
          #     Output only. Indicates which Knowledge Document this answer was extracted
          #     from.
          #     Format: `projects/<Project ID>/locations/<Location
          #     ID>/agent/knowledgeBases/<Knowledge Base ID>/documents/<Document ID>`.
          # @!attribute [rw] metadata
          #   @return [Hash{String => String}]
          #     Output only. A map that contains metadata about the answer and the
          #     document from which it originates.
          # @!attribute [rw] answer_record
          #   @return [String]
          #     Output only. The name of answer record, in the format of
          #     "projects/<Project ID>/locations/<Location ID>/answerRecords/<Answer
          #     Record ID>"
          class FaqAnswer; end
        end

        # The request message for {Google::Cloud::Dialogflow::V2beta1::Participants::ListSuggestions Participants::ListSuggestions}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The name of the participant to fetch suggestions for.
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/conversations/<Conversation ID>/participants/<Participant ID>`.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     Optional. The maximum number of items to return in a single page. The
        #     default value is 100; the maximum value is 1000.
        # @!attribute [rw] page_token
        #   @return [String]
        #     Optional. The next_page_token value returned from a previous list request.
        # @!attribute [rw] filter
        #   @return [String]
        #     Optional. Filter on suggestions fields. Currently predicates on
        #     `create_time` and `create_time_epoch_microseconds` are supported.
        #     `create_time` only support milliseconds accuracy. E.g.,
        #     `create_time_epoch_microseconds > 1551790877964485` or
        #     `create_time > 2017-01-15T01:30:15.01Z`
        #
        #     For more information about filtering, see
        #     [API Filtering](https://aip.dev/160).
        class ListSuggestionsRequest; end

        # The response message for {Google::Cloud::Dialogflow::V2beta1::Participants::ListSuggestions Participants::ListSuggestions}.
        # @!attribute [rw] suggestions
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Suggestion>]
        #     Required. The list of suggestions. There will be a maximum number of items
        #     returned based on the page_size field in the request. `suggestions` is
        #     sorted by `create_time` in descending order.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     Optional. Token to retrieve the next page of results or empty if there are
        #     no more results in the list.
        class ListSuggestionsResponse; end

        # The request message for {Google::Cloud::Dialogflow::V2beta1::Participants::CompileSuggestion Participants::CompileSuggestion}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The name of the participant to fetch suggestion for.
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/conversations/<Conversation ID>/participants/<Participant ID>`.
        # @!attribute [rw] latest_message
        #   @return [String]
        #     Optional. The name of the latest conversation message to compile suggestion
        #     for. If empty, it will be the latest message of the conversation.
        #
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/conversations/<Conversation ID>/messages/<Message ID>`.
        # @!attribute [rw] context_size
        #   @return [Integer]
        #     Optional. Max number of messages prior to and including
        #     [latest_message] to use as context when compiling the
        #     suggestion. If zero or less than zero, 20 is used.
        class CompileSuggestionRequest; end

        # The response message for {Google::Cloud::Dialogflow::V2beta1::Participants::CompileSuggestion Participants::CompileSuggestion}.
        # @!attribute [rw] suggestion
        #   @return [Google::Cloud::Dialogflow::V2beta1::Suggestion]
        #     The compiled suggestion.
        # @!attribute [rw] latest_message
        #   @return [String]
        #     The name of the latest conversation message used to compile
        #     suggestion for.
        #
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/conversations/<Conversation ID>/messages/<Message ID>`.
        # @!attribute [rw] context_size
        #   @return [Integer]
        #     Number of messages prior to and including
        #     {Google::Cloud::Dialogflow::V2beta1::CompileSuggestionResponse#latest_message latest_message}
        #     to compile the suggestion. It may be smaller than the
        #     {Google::Cloud::Dialogflow::V2beta1::CompileSuggestionRequest#context_size CompileSuggestionRequest#context_size} field in the request if
        #     there aren't that many messages in the conversation.
        class CompileSuggestionResponse; end

        # Response messages from an automated agent.
        # @!attribute [rw] text
        #   @return [Google::Cloud::Dialogflow::V2beta1::ResponseMessage::Text]
        #     Returns a text response.
        # @!attribute [rw] payload
        #   @return [Google::Protobuf::Struct]
        #     Returns a response containing a custom, platform-specific payload.
        # @!attribute [rw] live_agent_handoff
        #   @return [Google::Cloud::Dialogflow::V2beta1::ResponseMessage::LiveAgentHandoff]
        #     Hands off conversation to a live agent.
        # @!attribute [rw] end_interaction
        #   @return [Google::Cloud::Dialogflow::V2beta1::ResponseMessage::EndInteraction]
        #     A signal that indicates the interaction with the Dialogflow agent has
        #     ended.
        class ResponseMessage
          # The text response message.
          # @!attribute [rw] text
          #   @return [Array<String>]
          #     A collection of text responses.
          class Text; end

          # Indicates that the conversation should be handed off to a human agent.
          #
          # Dialogflow only uses this to determine which conversations were handed off
          # to a human agent for measurement purposes. What else to do with this signal
          # is up to you and your handoff procedures.
          #
          # You may set this, for example:
          # * In the entry fulfillment of a CX Page if entering the page indicates
          #   something went extremely wrong in the conversation.
          # * In a webhook response when you determine that the customer issue can only
          #   be handled by a human.
          # @!attribute [rw] metadata
          #   @return [Google::Protobuf::Struct]
          #     Custom metadata for your handoff procedure. Dialogflow doesn't impose
          #     any structure on this.
          class LiveAgentHandoff; end

          # Indicates that interaction with the Dialogflow agent has ended.
          class EndInteraction; end
        end
      end
    end
  end
end