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
      module Cx
        module V3beta1
          # The request to detect user's intent.
          # @!attribute [rw] session
          #   @return [String]
          #     Required. The name of the session this query is sent to.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/sessions/<Session ID>` or `projects/<Project ID>/locations/<Location
          #     ID>/agents/<Agent ID>/environments/<Environment ID>/sessions/<Session ID>`.
          #     If `Environment ID` is not specified, we assume default 'draft'
          #     environment.
          #     It's up to the API caller to choose an appropriate `Session ID`. It can be
          #     a random number or some type of session identifiers (preferably hashed).
          #     The length of the `Session ID` must not exceed 36 characters.
          #
          #     For more information, see the [sessions
          #     guide](https://cloud.google.com/dialogflow/cx/docs/concept/session).
          #
          #     Note: Always use agent versions for production traffic.
          #     See [Versions and
          #     environments](https://cloud.google.com/dialogflow/cx/docs/concept/version).
          # @!attribute [rw] query_params
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::QueryParameters]
          #     The parameters of this query.
          # @!attribute [rw] query_input
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::QueryInput]
          #     Required. The input specification.
          # @!attribute [rw] output_audio_config
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::OutputAudioConfig]
          #     Instructs the speech synthesizer how to generate the output audio.
          class DetectIntentRequest; end

          # The message returned from the DetectIntent method.
          # @!attribute [rw] response_id
          #   @return [String]
          #     Output only. The unique identifier of the response. It can be used to
          #     locate a response in the training example set or for reporting issues.
          # @!attribute [rw] query_result
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::QueryResult]
          #     The result of the conversational query.
          # @!attribute [rw] output_audio
          #   @return [String]
          #     The audio data bytes encoded as specified in the request.
          #     Note: The output audio is generated based on the values of default platform
          #     text responses found in the
          #     {Google::Cloud::Dialogflow::Cx::V3beta1::QueryResult#response_messages `query_result::response_messages`} field. If
          #     multiple default text responses exist, they will be concatenated when
          #     generating audio. If no default platform text responses exist, the
          #     generated audio content will be empty.
          #
          #     In some scenarios, multiple output audio fields may be present in the
          #     response structure. In these cases, only the top-most-level audio output
          #     has content.
          # @!attribute [rw] output_audio_config
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::OutputAudioConfig]
          #     The config used by the speech synthesizer to generate the output audio.
          class DetectIntentResponse; end

          # The top-level message sent by the client to the
          # {Google::Cloud::Dialogflow::Cx::V3beta1::Sessions::StreamingDetectIntent Sessions::StreamingDetectIntent} method.
          #
          # Multiple request messages should be sent in order:
          #
          # 1.  The first message must contain
          # {Google::Cloud::Dialogflow::Cx::V3beta1::StreamingDetectIntentRequest#session session},
          #     {Google::Cloud::Dialogflow::Cx::V3beta1::StreamingDetectIntentRequest#query_input query_input} plus optionally
          #     {Google::Cloud::Dialogflow::Cx::V3beta1::StreamingDetectIntentRequest#query_params query_params}. If the client
          #     wants to receive an audio response, it should also contain
          #     {Google::Cloud::Dialogflow::Cx::V3beta1::StreamingDetectIntentRequest#output_audio_config output_audio_config}.
          #
          # 2.  If {Google::Cloud::Dialogflow::Cx::V3beta1::StreamingDetectIntentRequest#query_input query_input} was set to
          #     {Google::Cloud::Dialogflow::Cx::V3beta1::AudioInput#config query_input::audio::config}, all subsequent messages
          #     must contain {Google::Cloud::Dialogflow::Cx::V3beta1::AudioInput#audio query_input::audio::audio} to continue with
          #     Speech recognition.
          #     If you decide to rather detect an intent from text
          #     input after you already started Speech recognition, please send a message
          #     with {Google::Cloud::Dialogflow::Cx::V3beta1::QueryInput#text query_input::text}.
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
          #     The name of the session this query is sent to.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/sessions/<Session ID>` or `projects/<Project ID>/locations/<Location
          #     ID>/agents/<Agent ID>/environments/<Environment ID>/sessions/<Session ID>`.
          #     If `Environment ID` is not specified, we assume default 'draft'
          #     environment.
          #     It's up to the API caller to choose an appropriate `Session ID`. It can be
          #     a random number or some type of session identifiers (preferably hashed).
          #     The length of the `Session ID` must not exceed 36 characters.
          #     Note: session must be set in the first request.
          #
          #     For more information, see the [sessions
          #     guide](https://cloud.google.com/dialogflow/cx/docs/concept/session).
          #
          #     Note: Always use agent versions for production traffic.
          #     See [Versions and
          #     environments](https://cloud.google.com/dialogflow/cx/docs/concept/version).
          # @!attribute [rw] query_params
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::QueryParameters]
          #     The parameters of this query.
          # @!attribute [rw] query_input
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::QueryInput]
          #     Required. The input specification.
          # @!attribute [rw] output_audio_config
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::OutputAudioConfig]
          #     Instructs the speech synthesizer how to generate the output audio.
          class StreamingDetectIntentRequest; end

          # The top-level message returned from the `StreamingDetectIntent` method.
          #
          # Multiple response messages can be returned in order:
          #
          # 1.  If the input was set to streaming audio, the first one or more messages
          #     contain `recognition_result`. Each `recognition_result` represents a more
          #     complete transcript of what the user said. The last `recognition_result`
          #     has `is_final` set to `true`.
          #
          # 2.  The last message contains `detect_intent_response`.
          # @!attribute [rw] recognition_result
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::StreamingRecognitionResult]
          #     The result of speech recognition.
          # @!attribute [rw] detect_intent_response
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::DetectIntentResponse]
          #     The response from detect intent.
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
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::StreamingRecognitionResult::MessageType]
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
          #     * If the value is unspecified or 0.0, Dialogflow didn't compute the
          #       stability. In particular, Dialogflow will only provide stability for
          #       `TRANSCRIPT` results with `is_final = false`.
          #     * Otherwise, the value is in (0.0, 1.0] where 0.0 means completely
          #       unstable and 1.0 means completely stable.
          # @!attribute [rw] speech_word_info
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::SpeechWordInfo>]
          #     Word-specific information for the words recognized by Speech in
          #     {Google::Cloud::Dialogflow::Cx::V3beta1::StreamingRecognitionResult#transcript transcript}. Populated if and only if `message_type` = `TRANSCRIPT` and
          #     [InputAudioConfig.enable_word_info] is set.
          # @!attribute [rw] speech_end_offset
          #   @return [Google::Protobuf::Duration]
          #     Time offset of the end of this Speech recognition result relative to the
          #     beginning of the audio. Only populated for `message_type` =
          #     `TRANSCRIPT`.
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
              # {Google::Cloud::Dialogflow::Cx::V3beta1::InputAudioConfig#single_utterance `single_utterance`} was set to
              # `true`, and is not used otherwise.
              END_OF_SINGLE_UTTERANCE = 2
            end
          end

          # Represents the parameters of a conversational query.
          # @!attribute [rw] time_zone
          #   @return [String]
          #     The time zone of this conversational query from the [time zone
          #     database](https://www.iana.org/time-zones), e.g., America/New_York,
          #     Europe/Paris. If not provided, the time zone specified in the agent is
          #     used.
          # @!attribute [rw] geo_location
          #   @return [Google::Type::LatLng]
          #     The geo location of this conversational query.
          # @!attribute [rw] session_entity_types
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::SessionEntityType>]
          #     Additional session entity types to replace or extend developer entity types
          #     with. The entity synonyms apply to all languages and persist for the
          #     session of this query.
          # @!attribute [rw] payload
          #   @return [Google::Protobuf::Struct]
          #     This field can be used to pass custom data into the webhook associated with
          #     the agent. Arbitrary JSON objects are supported.
          # @!attribute [rw] parameters
          #   @return [Google::Protobuf::Struct]
          #     Additional parameters to be put into [session
          #     parameters][SessionInfo.parameters]. To remove a
          #     parameter from the session, clients should explicitly set the parameter
          #     value to null.
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
          # @!attribute [rw] analyze_query_text_sentiment
          #   @return [true, false]
          #     Configures whether sentiment analysis should be performed. If not
          #     provided, sentiment analysis is not performed.
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

          # Represents the query input. It can contain one of:
          #
          # 1.  A conversational query in the form of text.
          #
          # 2.  An intent query that specifies which intent to trigger.
          #
          # 3.  Natural language speech audio to be processed.
          #
          # 4.  An event to be triggered.
          # @!attribute [rw] text
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::TextInput]
          #     The natural language text to be processed.
          # @!attribute [rw] intent
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::IntentInput]
          #     The intent to be triggered.
          # @!attribute [rw] audio
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::AudioInput]
          #     The natural language speech audio to be processed.
          # @!attribute [rw] event
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::EventInput]
          #     The event to be triggered.
          # @!attribute [rw] dtmf
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::DtmfInput]
          #     The DTMF event to be handled.
          # @!attribute [rw] language_code
          #   @return [String]
          #     Required. The language of the input. See [Language
          #     Support](https://cloud.google.com/dialogflow/cx/docs/reference/language)
          #     for a list of the currently supported language codes. Note that queries in
          #     the same session do not necessarily need to specify the same language.
          class QueryInput; end

          # Represents the result of a conversational query.
          # @!attribute [rw] text
          #   @return [String]
          #     If {Google::Cloud::Dialogflow::Cx::V3beta1::TextInput natural language text} was provided as input, this field
          #     will contain a copy of the text.
          # @!attribute [rw] trigger_intent
          #   @return [String]
          #     If an {Google::Cloud::Dialogflow::Cx::V3beta1::IntentInput intent} was provided as input, this field will
          #     contain a copy of the intent identifier.
          # @!attribute [rw] transcript
          #   @return [String]
          #     If {Google::Cloud::Dialogflow::Cx::V3beta1::AudioInput natural language speech audio} was provided as input,
          #     this field will contain the trascript for the audio.
          # @!attribute [rw] trigger_event
          #   @return [String]
          #     If an {Google::Cloud::Dialogflow::Cx::V3beta1::EventInput event} was provided as input, this field will contain
          #     the name of the event.
          # @!attribute [rw] language_code
          #   @return [String]
          #     The language that was triggered during intent detection.
          #     See [Language
          #     Support](https://cloud.google.com/dialogflow/cx/docs/reference/language)
          #     for a list of the currently supported language codes.
          # @!attribute [rw] parameters
          #   @return [Google::Protobuf::Struct]
          #     The collected {Google::Cloud::Dialogflow::Cx::V3beta1::SessionInfo#parameters session parameters}.
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
          # @!attribute [rw] response_messages
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::ResponseMessage>]
          #     The list of rich messages returned to the client. Responses vary from
          #     simple text messages to more sophisticated, structured payloads used
          #     to drive complex logic.
          # @!attribute [rw] webhook_statuses
          #   @return [Array<Google::Rpc::Status>]
          #     The list of webhook call status in the order of call sequence.
          # @!attribute [rw] webhook_payloads
          #   @return [Array<Google::Protobuf::Struct>]
          #     The list of webhook payload in {Google::Cloud::Dialogflow::Cx::V3beta1::WebhookResponse#payload WebhookResponse#payload}, in
          #     the order of call sequence. If some webhook call fails or doesn't return
          #     any payload, an empty `Struct` would be used instead.
          # @!attribute [rw] current_page
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Page]
          #     The current {Google::Cloud::Dialogflow::Cx::V3beta1::Page Page}. Some, not all fields are filled in this message,
          #     including but not limited to `name` and `display_name`.
          # @!attribute [rw] intent
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Intent]
          #     The {Google::Cloud::Dialogflow::Cx::V3beta1::Intent Intent} that matched the conversational query. Some, not all fields
          #     are filled in this message, including but not limited to: `name` and
          #     `display_name`.
          #     This field is deprecated, please use {Google::Cloud::Dialogflow::Cx::V3beta1::QueryResult#match QueryResult#match} instead.
          # @!attribute [rw] intent_detection_confidence
          #   @return [Float]
          #     The intent detection confidence. Values range from 0.0 (completely
          #     uncertain) to 1.0 (completely certain).
          #     This value is for informational purpose only and is only used to
          #     help match the best intent within the classification threshold.
          #     This value may change for the same end-user expression at any time due to a
          #     model retraining or change in implementation.
          #     This field is deprecated, please use {Google::Cloud::Dialogflow::Cx::V3beta1::QueryResult#match QueryResult#match} instead.
          # @!attribute [rw] match
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Match]
          #     Intent match result, could be an intent or an event.
          # @!attribute [rw] diagnostic_info
          #   @return [Google::Protobuf::Struct]
          #     The free-form diagnostic info. For example, this field could contain
          #     webhook call latency. The string keys of the Struct's fields map can change
          #     without notice.
          # @!attribute [rw] sentiment_analysis_result
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::SentimentAnalysisResult]
          #     The sentiment analyss result, which depends on
          #     [`analyze_query_text_sentiment`]
          #     [google.cloud.dialogflow.cx.v3beta1.QueryParameters.analyze_query_text_sentiment], specified in the request.
          class QueryResult; end

          # Represents the natural language text to be processed.
          # @!attribute [rw] text
          #   @return [String]
          #     Required. The UTF-8 encoded natural language text to be processed. Text length must
          #     not exceed 256 characters.
          class TextInput; end

          # Represents the intent to trigger programmatically rather than as a result of
          # natural language processing.
          # @!attribute [rw] intent
          #   @return [String]
          #     Required. The unique identifier of the intent.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/intents/<Intent ID>`.
          class IntentInput; end

          # Represents the natural speech audio to be processed.
          # @!attribute [rw] config
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::InputAudioConfig]
          #     Required. Instructs the speech recognizer how to process the speech audio.
          # @!attribute [rw] audio
          #   @return [String]
          #     The natural language speech audio to be processed.
          #     A single request can contain up to 1 minute of speech audio data.
          #     The {Google::Cloud::Dialogflow::Cx::V3beta1::QueryResult#transcript transcribed text} cannot contain more than 256
          #     bytes.
          #
          #     For non-streaming audio detect intent, both `config` and `audio` must be
          #     provided.
          #     For streaming audio detect intent, `config` must be provided in
          #     the first request and `audio` must be provided in all following requests.
          class AudioInput; end

          # Represents the event to trigger.
          # @!attribute [rw] event
          #   @return [String]
          #     Name of the event.
          class EventInput; end

          # Represents the input for dtmf event.
          # @!attribute [rw] digits
          #   @return [String]
          #     The dtmf digits.
          # @!attribute [rw] finish_digit
          #   @return [String]
          #     The finish digit (if any).
          class DtmfInput; end

          # Represents one match result of {MatchIntent}.
          # @!attribute [rw] intent
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Intent]
          #     The {Google::Cloud::Dialogflow::Cx::V3beta1::Intent Intent} that matched the query. Some, not all fields are filled in
          #     this message, including but not limited to: `name` and `display_name`. Only
          #     filled for {Google::Cloud::Dialogflow::Cx::V3beta1::Match::MatchType `INTENT`} match type.
          # @!attribute [rw] event
          #   @return [String]
          #     The event that matched the query. Only filled for
          #     {Google::Cloud::Dialogflow::Cx::V3beta1::Match::MatchType `EVENT`} match type.
          # @!attribute [rw] parameters
          #   @return [Google::Protobuf::Struct]
          #     The collection of parameters extracted from the query.
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
          # @!attribute [rw] resolved_input
          #   @return [String]
          #     Final text input which was matched during MatchIntent. This value can be
          #     different from original input sent in request because of spelling
          #     correction or other processing.
          # @!attribute [rw] match_type
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Match::MatchType]
          #     Type of this {Google::Cloud::Dialogflow::Cx::V3beta1::Match Match}.
          # @!attribute [rw] confidence
          #   @return [Float]
          #     The confidence of this match. Values range from 0.0 (completely uncertain)
          #     to 1.0 (completely certain).
          #     This value is for informational purpose only and is only used to help match
          #     the best intent within the classification threshold. This value may change
          #     for the same end-user expression at any time due to a model retraining or
          #     change in implementation.
          class Match
            # Type of a Match.
            module MatchType
              # Not specified. Should never be used.
              MATCH_TYPE_UNSPECIFIED = 0

              # The query was matched to an intent.
              INTENT = 1

              # The query directly triggered an intent.
              DIRECT_INTENT = 2

              # The query was used for parameter filling.
              PARAMETER_FILLING = 3

              # No match was found for the query.
              NO_MATCH = 4

              # Indicates an empty query.
              NO_INPUT = 5

              # The query directly triggered an event.
              EVENT = 6
            end
          end

          # Request of {MatchIntent}.
          # @!attribute [rw] session
          #   @return [String]
          #     Required. The name of the session this query is sent to.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/sessions/<Session ID>` or `projects/<Project ID>/locations/<Location
          #     ID>/agents/<Agent ID>/environments/<Environment ID>/sessions/<Session ID>`.
          #     If `Environment ID` is not specified, we assume default 'draft'
          #     environment.
          #     It's up to the API caller to choose an appropriate `Session ID`. It can be
          #     a random number or some type of session identifiers (preferably hashed).
          #     The length of the `Session ID` must not exceed 36 characters.
          #
          #     For more information, see the [sessions
          #     guide](https://cloud.google.com/dialogflow/cx/docs/concept/session).
          # @!attribute [rw] query_params
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::QueryParameters]
          #     The parameters of this query.
          # @!attribute [rw] query_input
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::QueryInput]
          #     Required. The input specification.
          class MatchIntentRequest; end

          # Response of {MatchIntent}.
          # @!attribute [rw] text
          #   @return [String]
          #     If {Google::Cloud::Dialogflow::Cx::V3beta1::TextInput natural language text} was provided as input, this field
          #     will contain a copy of the text.
          # @!attribute [rw] trigger_intent
          #   @return [String]
          #     If an {Google::Cloud::Dialogflow::Cx::V3beta1::IntentInput intent} was provided as input, this field will
          #     contain a copy of the intent identifier.
          # @!attribute [rw] transcript
          #   @return [String]
          #     If {Google::Cloud::Dialogflow::Cx::V3beta1::AudioInput natural language speech audio} was provided as input,
          #     this field will contain the trascript for the audio.
          # @!attribute [rw] trigger_event
          #   @return [String]
          #     If an {Google::Cloud::Dialogflow::Cx::V3beta1::EventInput event} was provided as input, this field will
          #     contain a copy of the event name.
          # @!attribute [rw] matches
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::Match>]
          #     Match results, if more than one, ordered descendingly by the confidence
          #     we have that the particular intent matches the query.
          # @!attribute [rw] current_page
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Page]
          #     The current {Google::Cloud::Dialogflow::Cx::V3beta1::Page Page}. Some, not all fields are filled in this message,
          #     including but not limited to `name` and `display_name`.
          class MatchIntentResponse; end

          # Request of {FulfillIntent}
          # @!attribute [rw] match_intent_request
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::MatchIntentRequest]
          #     Must be same as the corresponding MatchIntent request, otherwise the
          #     behavior is undefined.
          # @!attribute [rw] match
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Match]
          #     The matched intent/event to fulfill.
          # @!attribute [rw] output_audio_config
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::OutputAudioConfig]
          #     Instructs the speech synthesizer how to generate output audio.
          class FulfillIntentRequest; end

          # Response of {FulfillIntent}
          # @!attribute [rw] response_id
          #   @return [String]
          #     Output only. The unique identifier of the response. It can be used to
          #     locate a response in the training example set or for reporting issues.
          # @!attribute [rw] query_result
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::QueryResult]
          #     The result of the conversational query.
          # @!attribute [rw] output_audio
          #   @return [String]
          #     The audio data bytes encoded as specified in the request.
          #     Note: The output audio is generated based on the values of default platform
          #     text responses found in the
          #     {Google::Cloud::Dialogflow::Cx::V3beta1::QueryResult#response_messages `query_result::response_messages`} field. If
          #     multiple default text responses exist, they will be concatenated when
          #     generating audio. If no default platform text responses exist, the
          #     generated audio content will be empty.
          #
          #     In some scenarios, multiple output audio fields may be present in the
          #     response structure. In these cases, only the top-most-level audio output
          #     has content.
          # @!attribute [rw] output_audio_config
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::OutputAudioConfig]
          #     The config used by the speech synthesizer to generate the output audio.
          class FulfillIntentResponse; end

          # The result of sentiment analysis. Sentiment analysis inspects user input
          # and identifies the prevailing subjective opinion, especially to determine a
          # user's attitude as positive, negative, or neutral.
          # @!attribute [rw] score
          #   @return [Float]
          #     Sentiment score between -1.0 (negative sentiment) and 1.0 (positive
          #     sentiment).
          # @!attribute [rw] magnitude
          #   @return [Float]
          #     A non-negative number in the [0, +inf) range, which represents the absolute
          #     magnitude of sentiment, regardless of score (positive or negative).
          class SentimentAnalysisResult; end
        end
      end
    end
  end
end