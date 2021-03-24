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
        # The request to detect user's intent.
        # @!attribute [rw] session
        #   @return [String]
        #     Required. The name of the session this query is sent to. Supported formats:
        #     * `projects/<Project ID>/agent/sessions/<Session ID>,
        #     * `projects/<Project ID>/locations/<Location ID>/agent/sessions/<Session
        #       ID>`,
        #     * `projects/<Project ID>/agent/environments/<Environment ID>/users/<User
        #       ID>/sessions/<Session ID>`,
        #     * `projects/<Project ID>/locations/<Location
        #       ID>/agent/environments/<Environment ID>/users/<User ID>/sessions/<Session
        #       ID>`,
        #
        #     If `Location ID` is not specified we assume default 'us' location. If
        #     `Environment ID` is not specified, we assume default 'draft' environment
        #     (`Environment ID` might be referred to as environment name at some places).
        #     If `User ID` is not specified, we are using "-". It's up to the API caller
        #     to choose an appropriate `Session ID` and `User Id`. They can be a random
        #     number or some type of user and session identifiers (preferably hashed).
        #     The length of the `Session ID` and `User ID` must not exceed 36 characters.
        #     For more information, see the [API interactions
        #     guide](https://cloud.google.com/dialogflow/docs/api-overview).
        #
        #     Note: Always use agent versions for production traffic.
        #     See [Versions and
        #     environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        # @!attribute [rw] query_params
        #   @return [Google::Cloud::Dialogflow::V2beta1::QueryParameters]
        #     The parameters of this query.
        # @!attribute [rw] query_input
        #   @return [Google::Cloud::Dialogflow::V2beta1::QueryInput]
        #     Required. The input specification. It can be set to:
        #
        #     1.  an audio config
        #         which instructs the speech recognizer how to process the speech audio,
        #
        #     2.  a conversational query in the form of text, or
        #
        #     3.  an event that specifies which intent to trigger.
        # @!attribute [rw] output_audio_config
        #   @return [Google::Cloud::Dialogflow::V2beta1::OutputAudioConfig]
        #     Instructs the speech synthesizer how to generate the output
        #     audio. If this field is not set and agent-level speech synthesizer is not
        #     configured, no output audio is generated.
        # @!attribute [rw] output_audio_config_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Mask for {Google::Cloud::Dialogflow::V2beta1::DetectIntentRequest#output_audio_config output_audio_config} indicating which settings in this
        #     request-level config should override speech synthesizer settings defined at
        #     agent-level.
        #
        #     If unspecified or empty, {Google::Cloud::Dialogflow::V2beta1::DetectIntentRequest#output_audio_config output_audio_config} replaces the agent-level
        #     config in its entirety.
        # @!attribute [rw] input_audio
        #   @return [String]
        #     The natural language speech audio to be processed. This field
        #     should be populated iff `query_input` is set to an input audio config.
        #     A single request can contain up to 1 minute of speech audio data.
        class DetectIntentRequest; end

        # The message returned from the DetectIntent method.
        # @!attribute [rw] response_id
        #   @return [String]
        #     The unique identifier of the response. It can be used to
        #     locate a response in the training example set or for reporting issues.
        # @!attribute [rw] query_result
        #   @return [Google::Cloud::Dialogflow::V2beta1::QueryResult]
        #     The selected results of the conversational query or event processing.
        #     See `alternative_query_results` for additional potential results.
        # @!attribute [rw] alternative_query_results
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::QueryResult>]
        #     If Knowledge Connectors are enabled, there could be more than one result
        #     returned for a given query or event, and this field will contain all
        #     results except for the top one, which is captured in query_result. The
        #     alternative results are ordered by decreasing
        #     `QueryResult.intent_detection_confidence`. If Knowledge Connectors are
        #     disabled, this field will be empty until multiple responses for regular
        #     intents are supported, at which point those additional results will be
        #     surfaced here.
        # @!attribute [rw] webhook_status
        #   @return [Google::Rpc::Status]
        #     Specifies the status of the webhook request.
        # @!attribute [rw] output_audio
        #   @return [String]
        #     The audio data bytes encoded as specified in the request.
        #     Note: The output audio is generated based on the values of default platform
        #     text responses found in the `query_result.fulfillment_messages` field. If
        #     multiple default text responses exist, they will be concatenated when
        #     generating audio. If no default platform text responses exist, the
        #     generated audio content will be empty.
        #
        #     In some scenarios, multiple output audio fields may be present in the
        #     response structure. In these cases, only the top-most-level audio output
        #     has content.
        # @!attribute [rw] output_audio_config
        #   @return [Google::Cloud::Dialogflow::V2beta1::OutputAudioConfig]
        #     The config used by the speech synthesizer to generate the output audio.
        class DetectIntentResponse; end

        # Represents the parameters of the conversational query.
        # @!attribute [rw] time_zone
        #   @return [String]
        #     The time zone of this conversational query from the
        #     [time zone database](https://www.iana.org/time-zones), e.g.,
        #     America/New_York, Europe/Paris. If not provided, the time zone specified in
        #     agent settings is used.
        # @!attribute [rw] geo_location
        #   @return [Google::Type::LatLng]
        #     The geo location of this conversational query.
        # @!attribute [rw] contexts
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Context>]
        #     The collection of contexts to be activated before this query is
        #     executed.
        # @!attribute [rw] reset_contexts
        #   @return [true, false]
        #     Specifies whether to delete all contexts in the current session
        #     before the new ones are activated.
        # @!attribute [rw] session_entity_types
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::SessionEntityType>]
        #     Additional session entity types to replace or extend developer
        #     entity types with. The entity synonyms apply to all languages and persist
        #     for the session of this query.
        # @!attribute [rw] payload
        #   @return [Google::Protobuf::Struct]
        #     This field can be used to pass custom data to your webhook.
        #     Arbitrary JSON objects are supported.
        #     If supplied, the value is used to populate the
        #     `WebhookRequest.original_detect_intent_request.payload`
        #     field sent to your webhook.
        # @!attribute [rw] knowledge_base_names
        #   @return [Array<String>]
        #     KnowledgeBases to get alternative results from. If not set, the
        #     KnowledgeBases enabled in the agent (through UI) will be used.
        #     Format:  `projects/<Project ID>/knowledgeBases/<Knowledge Base ID>`.
        # @!attribute [rw] sentiment_analysis_request_config
        #   @return [Google::Cloud::Dialogflow::V2beta1::SentimentAnalysisRequestConfig]
        #     Configures the type of sentiment analysis to perform. If not
        #     provided, sentiment analysis is not performed.
        #     Note: Sentiment Analysis is only currently available for Essentials Edition
        #     agents.
        # @!attribute [rw] sub_agents
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::SubAgent>]
        #     For mega agent query, directly specify which sub agents to query.
        #     If any specified sub agent is not linked to the mega agent, an error will
        #     be returned. If empty, Dialogflow will decide which sub agents to query.
        #     If specified for a non-mega-agent query, will be silently ignored.
        # @!attribute [rw] webhook_headers
        #   @return [Hash{String => String}]
        #     This field can be used to pass HTTP headers for a webhook
        #     call. These headers will be sent to webhook along with the headers that
        #     have been configured through Dialogflow web console. The headers defined
        #     within this field will overwrite the headers configured through Dialogflow
        #     console if there is a conflict. Header names are case-insensitive.
        #     Google's specified headers are not allowed. Including: "Host",
        #     "Content-Length", "Connection", "From", "User-Agent", "Accept-Encoding",
        #     "If-Modified-Since", "If-None-Match", "X-Forwarded-For", etc.
        class QueryParameters; end

        # Represents the query input. It can contain either:
        #
        # 1.  An audio config which
        #     instructs the speech recognizer how to process the speech audio.
        #
        # 2.  A conversational query in the form of text.
        #
        # 3.  An event that specifies which intent to trigger.
        # @!attribute [rw] audio_config
        #   @return [Google::Cloud::Dialogflow::V2beta1::InputAudioConfig]
        #     Instructs the speech recognizer how to process the speech audio.
        # @!attribute [rw] text
        #   @return [Google::Cloud::Dialogflow::V2beta1::TextInput]
        #     The natural language text to be processed.
        # @!attribute [rw] event
        #   @return [Google::Cloud::Dialogflow::V2beta1::EventInput]
        #     The event to be processed.
        # @!attribute [rw] dtmf
        #   @return [Google::Cloud::Dialogflow::V2beta1::TelephonyDtmfEvents]
        #     The DTMF digits used to invoke intent and fill in parameter value.
        class QueryInput; end

        # Represents the result of conversational query or event processing.
        # @!attribute [rw] query_text
        #   @return [String]
        #     The original conversational query text:
        #
        #     * If natural language text was provided as input, `query_text` contains
        #       a copy of the input.
        #     * If natural language speech audio was provided as input, `query_text`
        #       contains the speech recognition result. If speech recognizer produced
        #       multiple alternatives, a particular one is picked.
        #     * If automatic spell correction is enabled, `query_text` will contain the
        #       corrected user input.
        # @!attribute [rw] language_code
        #   @return [String]
        #     The language that was triggered during intent detection.
        #     See [Language
        #     Support](https://cloud.google.com/dialogflow/docs/reference/language)
        #     for a list of the currently supported language codes.
        # @!attribute [rw] speech_recognition_confidence
        #   @return [Float]
        #     The Speech recognition confidence between 0.0 and 1.0. A higher number
        #     indicates an estimated greater likelihood that the recognized words are
        #     correct. The default of 0.0 is a sentinel value indicating that confidence
        #     was not set.
        #
        #     This field is not guaranteed to be accurate or set. In particular this
        #     field isn't set for StreamingDetectIntent since the streaming endpoint has
        #     separate confidence estimates per portion of the audio in
        #     StreamingRecognitionResult.
        # @!attribute [rw] action
        #   @return [String]
        #     The action name from the matched intent.
        # @!attribute [rw] parameters
        #   @return [Google::Protobuf::Struct]
        #     The collection of extracted parameters.
        #
        #     Depending on your protocol or client library language, this is a
        #     map, associative array, symbol table, dictionary, or JSON object
        #     composed of a collection of (MapKey, MapValue) pairs:
        #
        #     * MapKey type: string
        #     * MapKey value: parameter name
        #     * MapValue type:
        #       * If parameter's entity type is a composite entity: map
        #         * Else: depending on parameter value type, could be one of string,
        #           number, boolean, null, list or map
        #         * MapValue value:
        #         * If parameter's entity type is a composite entity:
        #           map from composite entity property names to property values
        #         * Else: parameter value
        # @!attribute [rw] all_required_params_present
        #   @return [true, false]
        #     This field is set to:
        #
        #     * `false` if the matched intent has required parameters and not all of
        #       the required parameter values have been collected.
        #     * `true` if all required parameter values have been collected, or if the
        #       matched intent doesn't contain any required parameters.
        # @!attribute [rw] fulfillment_text
        #   @return [String]
        #     The text to be pronounced to the user or shown on the screen.
        #     Note: This is a legacy field, `fulfillment_messages` should be preferred.
        # @!attribute [rw] fulfillment_messages
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Intent::Message>]
        #     The collection of rich messages to present to the user.
        # @!attribute [rw] webhook_source
        #   @return [String]
        #     If the query was fulfilled by a webhook call, this field is set to the
        #     value of the `source` field returned in the webhook response.
        # @!attribute [rw] webhook_payload
        #   @return [Google::Protobuf::Struct]
        #     If the query was fulfilled by a webhook call, this field is set to the
        #     value of the `payload` field returned in the webhook response.
        # @!attribute [rw] output_contexts
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Context>]
        #     The collection of output contexts. If applicable,
        #     `output_contexts.parameters` contains entries with name
        #     `<parameter name>.original` containing the original parameter values
        #     before the query.
        # @!attribute [rw] intent
        #   @return [Google::Cloud::Dialogflow::V2beta1::Intent]
        #     The intent that matched the conversational query. Some, not
        #     all fields are filled in this message, including but not limited to:
        #     `name`, `display_name`, `end_interaction` and `is_fallback`.
        # @!attribute [rw] intent_detection_confidence
        #   @return [Float]
        #     The intent detection confidence. Values range from 0.0
        #     (completely uncertain) to 1.0 (completely certain).
        #     This value is for informational purpose only and is only used to
        #     help match the best intent within the classification threshold.
        #     This value may change for the same end-user expression at any time due to a
        #     model retraining or change in implementation.
        #     If there are `multiple knowledge_answers` messages, this value is set to
        #     the greatest `knowledgeAnswers.match_confidence` value in the list.
        # @!attribute [rw] diagnostic_info
        #   @return [Google::Protobuf::Struct]
        #     Free-form diagnostic information for the associated detect intent request.
        #     The fields of this data can change without notice, so you should not write
        #     code that depends on its structure.
        #     The data may contain:
        #
        #     * webhook call latency
        #     * webhook errors
        # @!attribute [rw] sentiment_analysis_result
        #   @return [Google::Cloud::Dialogflow::V2beta1::SentimentAnalysisResult]
        #     The sentiment analysis result, which depends on the
        #     `sentiment_analysis_request_config` specified in the request.
        # @!attribute [rw] knowledge_answers
        #   @return [Google::Cloud::Dialogflow::V2beta1::KnowledgeAnswers]
        #     The result from Knowledge Connector (if any), ordered by decreasing
        #     `KnowledgeAnswers.match_confidence`.
        class QueryResult; end

        # Represents the result of querying a Knowledge base.
        # @!attribute [rw] answers
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::KnowledgeAnswers::Answer>]
        #     A list of answers from Knowledge Connector.
        class KnowledgeAnswers
          # An answer from Knowledge Connector.
          # @!attribute [rw] source
          #   @return [String]
          #     Indicates which Knowledge Document this answer was extracted from.
          #     Format: `projects/<Project ID>/knowledgeBases/<Knowledge Base
          #     ID>/documents/<Document ID>`.
          # @!attribute [rw] faq_question
          #   @return [String]
          #     The corresponding FAQ question if the answer was extracted from a FAQ
          #     Document, empty otherwise.
          # @!attribute [rw] answer
          #   @return [String]
          #     The piece of text from the `source` knowledge base document that answers
          #     this conversational query.
          # @!attribute [rw] match_confidence_level
          #   @return [Google::Cloud::Dialogflow::V2beta1::KnowledgeAnswers::Answer::MatchConfidenceLevel]
          #     The system's confidence level that this knowledge answer is a good match
          #     for this conversational query.
          #     NOTE: The confidence level for a given `<query, answer>` pair may change
          #     without notice, as it depends on models that are constantly being
          #     improved. However, it will change less frequently than the confidence
          #     score below, and should be preferred for referencing the quality of an
          #     answer.
          # @!attribute [rw] match_confidence
          #   @return [Float]
          #     The system's confidence score that this Knowledge answer is a good match
          #     for this conversational query.
          #     The range is from 0.0 (completely uncertain) to 1.0 (completely certain).
          #     Note: The confidence score is likely to vary somewhat (possibly even for
          #     identical requests), as the underlying model is under constant
          #     improvement. It may be deprecated in the future. We recommend using
          #     `match_confidence_level` which should be generally more stable.
          class Answer
            # Represents the system's confidence that this knowledge answer is a good
            # match for this conversational query.
            module MatchConfidenceLevel
              # Not specified.
              MATCH_CONFIDENCE_LEVEL_UNSPECIFIED = 0

              # Indicates that the confidence is low.
              LOW = 1

              # Indicates our confidence is medium.
              MEDIUM = 2

              # Indicates our confidence is high.
              HIGH = 3
            end
          end
        end

        # The top-level message sent by the client to the
        # {Google::Cloud::Dialogflow::V2beta1::Sessions::StreamingDetectIntent Sessions::StreamingDetectIntent} method.
        #
        # Multiple request messages should be sent in order:
        #
        # 1.  The first message must contain
        # {Google::Cloud::Dialogflow::V2beta1::StreamingDetectIntentRequest#session session},
        #     {Google::Cloud::Dialogflow::V2beta1::StreamingDetectIntentRequest#query_input query_input} plus optionally
        #     {Google::Cloud::Dialogflow::V2beta1::StreamingDetectIntentRequest#query_params query_params}. If the client
        #     wants to receive an audio response, it should also contain
        #     {Google::Cloud::Dialogflow::V2beta1::StreamingDetectIntentRequest#output_audio_config output_audio_config}.
        #     The message must not contain
        #     {Google::Cloud::Dialogflow::V2beta1::StreamingDetectIntentRequest#input_audio input_audio}.
        # 2.  If {Google::Cloud::Dialogflow::V2beta1::StreamingDetectIntentRequest#query_input query_input} was set to
        #     {Google::Cloud::Dialogflow::V2beta1::InputAudioConfig query_input::audio_config}, all subsequent
        #     messages must contain
        #     {Google::Cloud::Dialogflow::V2beta1::StreamingDetectIntentRequest#input_audio input_audio} to continue with
        #     Speech recognition.
        #     If you decide to rather detect an intent from text input after you
        #     already started Speech recognition, please send a message with
        #     {Google::Cloud::Dialogflow::V2beta1::QueryInput#text query_input::text}.
        #
        #     However, note that:
        #
        # * Dialogflow will bill you for the audio duration so far.
        #   * Dialogflow discards all Speech recognition results in favor of the
        #     input text.
        #     * Dialogflow will use the language code from the first message.
        #
        #     After you sent all input, you must half-close or abort the request stream.
        # @!attribute [rw] session
        #   @return [String]
        #     Required. The name of the session the query is sent to.
        #     Supported formats:
        #     * `projects/<Project ID>/agent/sessions/<Session ID>,
        #     * `projects/<Project ID>/locations/<Location ID>/agent/sessions/<Session
        #       ID>`,
        #     * `projects/<Project ID>/agent/environments/<Environment ID>/users/<User
        #       ID>/sessions/<Session ID>`,
        #     * `projects/<Project ID>/locations/<Location
        #       ID>/agent/environments/<Environment ID>/users/<User ID>/sessions/<Session
        #       ID>`,
        #
        #     If `Location ID` is not specified we assume default 'us' location. If
        #     `Environment ID` is not specified, we assume default 'draft' environment.
        #     If `User ID` is not specified, we are using "-". It's up to the API caller
        #     to choose an appropriate `Session ID` and `User Id`. They can be a random
        #     number or some type of user and session identifiers (preferably hashed).
        #     The length of the `Session ID` and `User ID` must not exceed 36 characters.
        #
        #     For more information, see the [API interactions
        #     guide](https://cloud.google.com/dialogflow/docs/api-overview).
        #
        #     Note: Always use agent versions for production traffic.
        #     See [Versions and
        #     environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        # @!attribute [rw] query_params
        #   @return [Google::Cloud::Dialogflow::V2beta1::QueryParameters]
        #     The parameters of this query.
        # @!attribute [rw] query_input
        #   @return [Google::Cloud::Dialogflow::V2beta1::QueryInput]
        #     Required. The input specification. It can be set to:
        #
        #     1.  an audio config which instructs the speech recognizer how to process
        #         the speech audio,
        #
        #     2.  a conversational query in the form of text, or
        #
        #     3.  an event that specifies which intent to trigger.
        # @!attribute [rw] single_utterance
        #   @return [true, false]
        #     DEPRECATED. Please use {Google::Cloud::Dialogflow::V2beta1::InputAudioConfig#single_utterance InputAudioConfig#single_utterance} instead.
        #     If `false` (default), recognition does not cease until the
        #     client closes the stream.
        #     If `true`, the recognizer will detect a single spoken utterance in input
        #     audio. Recognition ceases when it detects the audio's voice has
        #     stopped or paused. In this case, once a detected intent is received, the
        #     client should close the stream and start a new request with a new stream as
        #     needed.
        #     This setting is ignored when `query_input` is a piece of text or an event.
        # @!attribute [rw] output_audio_config
        #   @return [Google::Cloud::Dialogflow::V2beta1::OutputAudioConfig]
        #     Instructs the speech synthesizer how to generate the output
        #     audio. If this field is not set and agent-level speech synthesizer is not
        #     configured, no output audio is generated.
        # @!attribute [rw] output_audio_config_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Mask for {Google::Cloud::Dialogflow::V2beta1::StreamingDetectIntentRequest#output_audio_config output_audio_config} indicating which settings in this
        #     request-level config should override speech synthesizer settings defined at
        #     agent-level.
        #
        #     If unspecified or empty, {Google::Cloud::Dialogflow::V2beta1::StreamingDetectIntentRequest#output_audio_config output_audio_config} replaces the agent-level
        #     config in its entirety.
        # @!attribute [rw] input_audio
        #   @return [String]
        #     The input audio content to be recognized. Must be sent if
        #     `query_input` was set to a streaming input audio config. The complete audio
        #     over all streaming messages must not exceed 1 minute.
        class StreamingDetectIntentRequest; end

        # The top-level message returned from the
        # `StreamingDetectIntent` method.
        #
        # Multiple response messages can be returned in order:
        #
        # 1.  If the input was set to streaming audio, the first one or more messages
        #     contain `recognition_result`. Each `recognition_result` represents a more
        #     complete transcript of what the user said. The last `recognition_result`
        #     has `is_final` set to `true`.
        #
        # 2.  The next message contains `response_id`, `query_result`,
        #     `alternative_query_results` and optionally `webhook_status` if a WebHook
        #     was called.
        #
        # 3.  If `output_audio_config` was specified in the request or agent-level
        #     speech synthesizer is configured, all subsequent messages contain
        #     `output_audio` and `output_audio_config`.
        # @!attribute [rw] response_id
        #   @return [String]
        #     The unique identifier of the response. It can be used to
        #     locate a response in the training example set or for reporting issues.
        # @!attribute [rw] recognition_result
        #   @return [Google::Cloud::Dialogflow::V2beta1::StreamingRecognitionResult]
        #     The result of speech recognition.
        # @!attribute [rw] query_result
        #   @return [Google::Cloud::Dialogflow::V2beta1::QueryResult]
        #     The selected results of the conversational query or event processing.
        #     See `alternative_query_results` for additional potential results.
        # @!attribute [rw] alternative_query_results
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::QueryResult>]
        #     If Knowledge Connectors are enabled, there could be more than one result
        #     returned for a given query or event, and this field will contain all
        #     results except for the top one, which is captured in query_result. The
        #     alternative results are ordered by decreasing
        #     `QueryResult.intent_detection_confidence`. If Knowledge Connectors are
        #     disabled, this field will be empty until multiple responses for regular
        #     intents are supported, at which point those additional results will be
        #     surfaced here.
        # @!attribute [rw] webhook_status
        #   @return [Google::Rpc::Status]
        #     Specifies the status of the webhook request.
        # @!attribute [rw] output_audio
        #   @return [String]
        #     The audio data bytes encoded as specified in the request.
        #     Note: The output audio is generated based on the values of default platform
        #     text responses found in the `query_result.fulfillment_messages` field. If
        #     multiple default text responses exist, they will be concatenated when
        #     generating audio. If no default platform text responses exist, the
        #     generated audio content will be empty.
        #
        #     In some scenarios, multiple output audio fields may be present in the
        #     response structure. In these cases, only the top-most-level audio output
        #     has content.
        # @!attribute [rw] output_audio_config
        #   @return [Google::Cloud::Dialogflow::V2beta1::OutputAudioConfig]
        #     The config used by the speech synthesizer to generate the output audio.
        class StreamingDetectIntentResponse; end

        # Contains a speech recognition result corresponding to a portion of the audio
        # that is currently being processed or an indication that this is the end
        # of the single requested utterance.
        #
        # Example:
        #
        # 1.  transcript: "tube"
        #
        # 2.  transcript: "to be a"
        #
        # 3.  transcript: "to be"
        #
        # 4.  transcript: "to be or not to be"
        #     is_final: true
        #
        # 5.  transcript: " that's"
        #
        # 6.  transcript: " that is"
        #
        # 7.  message_type: `END_OF_SINGLE_UTTERANCE`
        #
        # 8.  transcript: " that is the question"
        #     is_final: true
        #
        # Only two of the responses contain final results (#4 and #8 indicated by
        # `is_final: true`). Concatenating these generates the full transcript: "to be
        # or not to be that is the question".
        #
        # In each response we populate:
        #
        # * for `TRANSCRIPT`: `transcript` and possibly `is_final`.
        #
        # * for `END_OF_SINGLE_UTTERANCE`: only `message_type`.
        # @!attribute [rw] message_type
        #   @return [Google::Cloud::Dialogflow::V2beta1::StreamingRecognitionResult::MessageType]
        #     Type of the result message.
        # @!attribute [rw] transcript
        #   @return [String]
        #     Transcript text representing the words that the user spoke.
        #     Populated if and only if `message_type` = `TRANSCRIPT`.
        # @!attribute [rw] is_final
        #   @return [true, false]
        #     If `false`, the `StreamingRecognitionResult` represents an
        #     interim result that may change. If `true`, the recognizer will not return
        #     any further hypotheses about this piece of the audio. May only be populated
        #     for `message_type` = `TRANSCRIPT`.
        # @!attribute [rw] confidence
        #   @return [Float]
        #     The Speech confidence between 0.0 and 1.0 for the current portion of audio.
        #     A higher number indicates an estimated greater likelihood that the
        #     recognized words are correct. The default of 0.0 is a sentinel value
        #     indicating that confidence was not set.
        #
        #     This field is typically only provided if `is_final` is true and you should
        #     not rely on it being accurate or even set.
        # @!attribute [rw] stability
        #   @return [Float]
        #     An estimate of the likelihood that the speech recognizer will
        #     not change its guess about this interim recognition result:
        #
        #     * If the value is unspecified or 0.0, Dialogflow didn't compute the
        #       stability. In particular, Dialogflow will only provide stability for
        #       `TRANSCRIPT` results with `is_final = false`.
        #     * Otherwise, the value is in (0.0, 1.0] where 0.0 means completely
        #       unstable and 1.0 means completely stable.
        # @!attribute [rw] speech_word_info
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::SpeechWordInfo>]
        #     Word-specific information for the words recognized by Speech in
        #     {Google::Cloud::Dialogflow::V2beta1::StreamingRecognitionResult#transcript transcript}. Populated if and only if `message_type` = `TRANSCRIPT` and
        #     [InputAudioConfig.enable_word_info] is set.
        # @!attribute [rw] speech_end_offset
        #   @return [Google::Protobuf::Duration]
        #     Time offset of the end of this Speech recognition result relative to the
        #     beginning of the audio. Only populated for `message_type` = `TRANSCRIPT`.
        # @!attribute [rw] dtmf_digits
        #   @return [Google::Cloud::Dialogflow::V2beta1::TelephonyDtmfEvents]
        #     DTMF digits. Populated if and only if `message_type` = `DTMF_DIGITS`.
        class StreamingRecognitionResult
          # Type of the response message.
          module MessageType
            # Not specified. Should never be used.
            MESSAGE_TYPE_UNSPECIFIED = 0

            # Message contains a (possibly partial) transcript.
            TRANSCRIPT = 1

            # Event indicates that the server has detected the end of the user's speech
            # utterance and expects no additional speech. Therefore, the server will
            # not process additional audio (although it may subsequently return
            # additional results). The client should stop sending additional audio
            # data, half-close the gRPC connection, and wait for any additional results
            # until the server closes the gRPC connection. This message is only sent if
            # `single_utterance` was set to `true`, and is not used otherwise.
            END_OF_SINGLE_UTTERANCE = 2
          end
        end

        # Represents the natural language text to be processed.
        # @!attribute [rw] text
        #   @return [String]
        #     Required. The UTF-8 encoded natural language text to be processed.
        #     Text length must not exceed 256 characters.
        # @!attribute [rw] language_code
        #   @return [String]
        #     Required. The language of this conversational query. See [Language
        #     Support](https://cloud.google.com/dialogflow/docs/reference/language)
        #     for a list of the currently supported language codes. Note that queries in
        #     the same session do not necessarily need to specify the same language.
        class TextInput; end

        # Events allow for matching intents by event name instead of the natural
        # language input. For instance, input `<event: { name: "welcome_event",
        # parameters: { name: "Sam" } }>` can trigger a personalized welcome response.
        # The parameter `name` may be used by the agent in the response:
        # `"Hello #welcome_event.name! What can I do for you today?"`.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The unique identifier of the event.
        # @!attribute [rw] parameters
        #   @return [Google::Protobuf::Struct]
        #     The collection of parameters associated with the event.
        #
        #     Depending on your protocol or client library language, this is a
        #     map, associative array, symbol table, dictionary, or JSON object
        #     composed of a collection of (MapKey, MapValue) pairs:
        #
        #     * MapKey type: string
        #     * MapKey value: parameter name
        #     * MapValue type:
        #       * If parameter's entity type is a composite entity: map
        #         * Else: depending on parameter value type, could be one of string,
        #           number, boolean, null, list or map
        #         * MapValue value:
        #         * If parameter's entity type is a composite entity:
        #           map from composite entity property names to property values
        #         * Else: parameter value
        # @!attribute [rw] language_code
        #   @return [String]
        #     Required. The language of this query. See [Language
        #     Support](https://cloud.google.com/dialogflow/docs/reference/language)
        #     for a list of the currently supported language codes. Note that queries in
        #     the same session do not necessarily need to specify the same language.
        class EventInput; end

        # Configures the types of sentiment analysis to perform.
        # @!attribute [rw] analyze_query_text_sentiment
        #   @return [true, false]
        #     Instructs the service to perform sentiment analysis on
        #     `query_text`. If not provided, sentiment analysis is not performed on
        #     `query_text`.
        class SentimentAnalysisRequestConfig; end

        # The result of sentiment analysis. Sentiment analysis inspects user input
        # and identifies the prevailing subjective opinion, especially to determine a
        # user's attitude as positive, negative, or neutral.
        # For {Participants::DetectIntent}, it needs to be configured in
        # {Google::Cloud::Dialogflow::V2beta1::DetectIntentRequest#query_params DetectIntentRequest#query_params}. For
        # {Participants::StreamingDetectIntent}, it needs to be configured in
        # {Google::Cloud::Dialogflow::V2beta1::StreamingDetectIntentRequest#query_params StreamingDetectIntentRequest#query_params}.
        # And for {Google::Cloud::Dialogflow::V2beta1::Participants::AnalyzeContent Participants::AnalyzeContent} and
        # {Google::Cloud::Dialogflow::V2beta1::Participants::StreamingAnalyzeContent Participants::StreamingAnalyzeContent}, it needs to be configured in
        # {Google::Cloud::Dialogflow::V2beta1::ConversationProfile#human_agent_assistant_config ConversationProfile#human_agent_assistant_config}
        # @!attribute [rw] query_text_sentiment
        #   @return [Google::Cloud::Dialogflow::V2beta1::Sentiment]
        #     The sentiment analysis result for `query_text`.
        class SentimentAnalysisResult; end

        # The sentiment, such as positive/negative feeling or association, for a unit
        # of analysis, such as the query text.
        # @!attribute [rw] score
        #   @return [Float]
        #     Sentiment score between -1.0 (negative sentiment) and 1.0 (positive
        #     sentiment).
        # @!attribute [rw] magnitude
        #   @return [Float]
        #     A non-negative number in the [0, +inf) range, which represents the absolute
        #     magnitude of sentiment, regardless of score (positive or negative).
        class Sentiment; end
      end
    end
  end
end