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
        # An intent categorizes an end-user's intention for one conversation turn. For
        # each agent, you define many intents, where your combined intents can handle a
        # complete conversation. When an end-user writes or says something, referred to
        # as an end-user expression or end-user input, Dialogflow matches the end-user
        # input to the best intent in your agent. Matching an intent is also known as
        # intent classification.
        #
        # For more information, see the [intent
        # guide](https://cloud.google.com/dialogflow/docs/intents-overview).
        # @!attribute [rw] name
        #   @return [String]
        #     Optional. The unique identifier of this intent.
        #     Required for {Google::Cloud::Dialogflow::V2beta1::Intents::UpdateIntent Intents::UpdateIntent} and {Google::Cloud::Dialogflow::V2beta1::Intents::BatchUpdateIntents Intents::BatchUpdateIntents}
        #     methods.
        #     Supported formats:
        #
        #     * `projects/<Project ID>/agent/intents/<Intent ID>`
        #     * `projects/<Project ID>/locations/<Location ID>/agent/intents/<Intent ID>`
        # @!attribute [rw] display_name
        #   @return [String]
        #     Required. The name of this intent.
        # @!attribute [rw] webhook_state
        #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::WebhookState]
        #     Optional. Indicates whether webhooks are enabled for the intent.
        # @!attribute [rw] priority
        #   @return [Integer]
        #     Optional. The priority of this intent. Higher numbers represent higher
        #     priorities.
        #
        #     * If the supplied value is unspecified or 0, the service
        #       translates the value to 500,000, which corresponds to the
        #       `Normal` priority in the console.
        #     * If the supplied value is negative, the intent is ignored
        #       in runtime detect intent requests.
        # @!attribute [rw] is_fallback
        #   @return [true, false]
        #     Optional. Indicates whether this is a fallback intent.
        # @!attribute [rw] ml_enabled
        #   @return [true, false]
        #     Optional. Indicates whether Machine Learning is enabled for the intent.
        #     Note: If `ml_enabled` setting is set to false, then this intent is not
        #     taken into account during inference in `ML ONLY` match mode. Also,
        #     auto-markup in the UI is turned off.
        #     DEPRECATED! Please use `ml_disabled` field instead.
        #     NOTE: If both `ml_enabled` and `ml_disabled` are either not set or false,
        #     then the default value is determined as follows:
        #
        #     * Before April 15th, 2018 the default is:
        #       ml_enabled = false / ml_disabled = true.
        #     * After April 15th, 2018 the default is:
        #       ml_enabled = true / ml_disabled = false.
        # @!attribute [rw] ml_disabled
        #   @return [true, false]
        #     Optional. Indicates whether Machine Learning is disabled for the intent.
        #     Note: If `ml_disabled` setting is set to true, then this intent is not
        #     taken into account during inference in `ML ONLY` match mode. Also,
        #     auto-markup in the UI is turned off.
        # @!attribute [rw] live_agent_handoff
        #   @return [true, false]
        #     Optional. Indicates that a live agent should be brought in to handle the
        #     interaction with the user. In most cases, when you set this flag to true,
        #     you would also want to set end_interaction to true as well. Default is
        #     false.
        # @!attribute [rw] end_interaction
        #   @return [true, false]
        #     Optional. Indicates that this intent ends an interaction. Some integrations
        #     (e.g., Actions on Google or Dialogflow phone gateway) use this information
        #     to close interaction with an end user. Default is false.
        # @!attribute [rw] input_context_names
        #   @return [Array<String>]
        #     Optional. The list of context names required for this intent to be
        #     triggered.
        #     Formats:
        #
        #     * `projects/<Project ID>/agent/sessions/-/contexts/<Context ID>`
        #     * `projects/<Project ID>/locations/<Location
        #       ID>/agent/sessions/-/contexts/<Context ID>`
        # @!attribute [rw] events
        #   @return [Array<String>]
        #     Optional. The collection of event names that trigger the intent.
        #     If the collection of input contexts is not empty, all of the contexts must
        #     be present in the active user session for an event to trigger this intent.
        #     Event names are limited to 150 characters.
        # @!attribute [rw] training_phrases
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Intent::TrainingPhrase>]
        #     Optional. The collection of examples that the agent is
        #     trained on.
        # @!attribute [rw] action
        #   @return [String]
        #     Optional. The name of the action associated with the intent.
        #     Note: The action name must not contain whitespaces.
        # @!attribute [rw] output_contexts
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Context>]
        #     Optional. The collection of contexts that are activated when the intent
        #     is matched. Context messages in this collection should not set the
        #     parameters field. Setting the `lifespan_count` to 0 will reset the context
        #     when the intent is matched.
        #     Format: `projects/<Project ID>/agent/sessions/-/contexts/<Context ID>`.
        # @!attribute [rw] reset_contexts
        #   @return [true, false]
        #     Optional. Indicates whether to delete all contexts in the current
        #     session when this intent is matched.
        # @!attribute [rw] parameters
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Intent::Parameter>]
        #     Optional. The collection of parameters associated with the intent.
        # @!attribute [rw] messages
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Intent::Message>]
        #     Optional. The collection of rich messages corresponding to the
        #     `Response` field in the Dialogflow console.
        # @!attribute [rw] default_response_platforms
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Intent::Message::Platform>]
        #     Optional. The list of platforms for which the first responses will be
        #     copied from the messages in PLATFORM_UNSPECIFIED (i.e. default platform).
        # @!attribute [rw] root_followup_intent_name
        #   @return [String]
        #     Output only. The unique identifier of the root intent in the chain of
        #     followup intents. It identifies the correct followup intents chain for
        #     this intent.
        #
        #     Format: `projects/<Project ID>/agent/intents/<Intent ID>`.
        # @!attribute [rw] parent_followup_intent_name
        #   @return [String]
        #     Optional. The unique identifier of the parent intent in the
        #     chain of followup intents. You can set this field when creating an intent,
        #     for example with {Google::Cloud::Dialogflow::V2beta1::Intents::CreateIntent CreateIntent} or
        #     {Google::Cloud::Dialogflow::V2beta1::Intents::BatchUpdateIntents BatchUpdateIntents}, in order to make this
        #     intent a followup intent.
        #
        #     It identifies the parent followup intent.
        #     Format: `projects/<Project ID>/agent/intents/<Intent ID>`.
        # @!attribute [rw] followup_intent_info
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Intent::FollowupIntentInfo>]
        #     Output only. Information about all followup intents that have this intent as
        #     a direct or indirect parent. We populate this field only in the output.
        class Intent
          # Represents an example that the agent is trained on.
          # @!attribute [rw] name
          #   @return [String]
          #     Output only. The unique identifier of this training phrase.
          # @!attribute [rw] type
          #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::TrainingPhrase::Type]
          #     Required. The type of the training phrase.
          # @!attribute [rw] parts
          #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Intent::TrainingPhrase::Part>]
          #     Required. The ordered list of training phrase parts.
          #     The parts are concatenated in order to form the training phrase.
          #
          #     Note: The API does not automatically annotate training phrases like the
          #     Dialogflow Console does.
          #
          #     Note: Do not forget to include whitespace at part boundaries,
          #     so the training phrase is well formatted when the parts are concatenated.
          #
          #     If the training phrase does not need to be annotated with parameters,
          #     you just need a single part with only the {Google::Cloud::Dialogflow::V2beta1::Intent::TrainingPhrase::Part#text Part#text} field set.
          #
          #     If you want to annotate the training phrase, you must create multiple
          #     parts, where the fields of each part are populated in one of two ways:
          #
          #     * `Part.text` is set to a part of the phrase that has no parameters.
          #     * `Part.text` is set to a part of the phrase that you want to annotate,
          #       and the `entity_type`, `alias`, and `user_defined` fields are all
          #       set.
          # @!attribute [rw] times_added_count
          #   @return [Integer]
          #     Optional. Indicates how many times this example was added to
          #     the intent. Each time a developer adds an existing sample by editing an
          #     intent or training, this counter is increased.
          class TrainingPhrase
            # Represents a part of a training phrase.
            # @!attribute [rw] text
            #   @return [String]
            #     Required. The text for this part.
            # @!attribute [rw] entity_type
            #   @return [String]
            #     Optional. The entity type name prefixed with `@`.
            #     This field is required for annotated parts of the training phrase.
            # @!attribute [rw] alias
            #   @return [String]
            #     Optional. The parameter name for the value extracted from the
            #     annotated part of the example.
            #     This field is required for annotated parts of the training phrase.
            # @!attribute [rw] user_defined
            #   @return [true, false]
            #     Optional. Indicates whether the text was manually annotated.
            #     This field is set to true when the Dialogflow Console is used to
            #     manually annotate the part. When creating an annotated part with the
            #     API, you must set this to true.
            class Part; end

            # Represents different types of training phrases.
            module Type
              # Not specified. This value should never be used.
              TYPE_UNSPECIFIED = 0

              # Examples do not contain @-prefixed entity type names, but example parts
              # can be annotated with entity types.
              EXAMPLE = 1

              # Templates are not annotated with entity types, but they can contain
              # @-prefixed entity type names as substrings.
              # Template mode has been deprecated. Example mode is the only supported
              # way to create new training phrases. If you have existing training
              # phrases that you've created in template mode, those will continue to
              # work.
              TEMPLATE = 2
            end
          end

          # Represents intent parameters.
          # @!attribute [rw] name
          #   @return [String]
          #     The unique identifier of this parameter.
          # @!attribute [rw] display_name
          #   @return [String]
          #     Required. The name of the parameter.
          # @!attribute [rw] value
          #   @return [String]
          #     Optional. The definition of the parameter value. It can be:
          #
          #     * a constant string,
          #     * a parameter value defined as `$parameter_name`,
          #     * an original parameter value defined as `$parameter_name.original`,
          #     * a parameter value from some context defined as
          #       `#context_name.parameter_name`.
          # @!attribute [rw] default_value
          #   @return [String]
          #     Optional. The default value to use when the `value` yields an empty
          #     result.
          #     Default values can be extracted from contexts by using the following
          #     syntax: `#context_name.parameter_name`.
          # @!attribute [rw] entity_type_display_name
          #   @return [String]
          #     Optional. The name of the entity type, prefixed with `@`, that
          #     describes values of the parameter. If the parameter is
          #     required, this must be provided.
          # @!attribute [rw] mandatory
          #   @return [true, false]
          #     Optional. Indicates whether the parameter is required. That is,
          #     whether the intent cannot be completed without collecting the parameter
          #     value.
          # @!attribute [rw] prompts
          #   @return [Array<String>]
          #     Optional. The collection of prompts that the agent can present to the
          #     user in order to collect a value for the parameter.
          # @!attribute [rw] is_list
          #   @return [true, false]
          #     Optional. Indicates whether the parameter represents a list of values.
          class Parameter; end

          # Corresponds to the `Response` field in the Dialogflow console.
          # @!attribute [rw] text
          #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::Text]
          #     Returns a text response.
          # @!attribute [rw] image
          #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::Image]
          #     Displays an image.
          # @!attribute [rw] quick_replies
          #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::QuickReplies]
          #     Displays quick replies.
          # @!attribute [rw] card
          #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::Card]
          #     Displays a card.
          # @!attribute [rw] payload
          #   @return [Google::Protobuf::Struct]
          #     A custom platform-specific response.
          # @!attribute [rw] simple_responses
          #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::SimpleResponses]
          #     Returns a voice or text-only response for Actions on Google.
          # @!attribute [rw] basic_card
          #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::BasicCard]
          #     Displays a basic card for Actions on Google.
          # @!attribute [rw] suggestions
          #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::Suggestions]
          #     Displays suggestion chips for Actions on Google.
          # @!attribute [rw] link_out_suggestion
          #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::LinkOutSuggestion]
          #     Displays a link out suggestion chip for Actions on Google.
          # @!attribute [rw] list_select
          #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::ListSelect]
          #     Displays a list card for Actions on Google.
          # @!attribute [rw] carousel_select
          #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::CarouselSelect]
          #     Displays a carousel card for Actions on Google.
          # @!attribute [rw] telephony_play_audio
          #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::TelephonyPlayAudio]
          #     Plays audio from a file in Telephony Gateway.
          # @!attribute [rw] telephony_synthesize_speech
          #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::TelephonySynthesizeSpeech]
          #     Synthesizes speech in Telephony Gateway.
          # @!attribute [rw] telephony_transfer_call
          #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::TelephonyTransferCall]
          #     Transfers the call in Telephony Gateway.
          # @!attribute [rw] rbm_text
          #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::RbmText]
          #     Rich Business Messaging (RBM) text response.
          #
          #     RBM allows businesses to send enriched and branded versions of SMS. See
          #     https://jibe.google.com/business-messaging.
          # @!attribute [rw] rbm_standalone_rich_card
          #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::RbmStandaloneCard]
          #     Standalone Rich Business Messaging (RBM) rich card response.
          # @!attribute [rw] rbm_carousel_rich_card
          #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::RbmCarouselCard]
          #     Rich Business Messaging (RBM) carousel rich card response.
          # @!attribute [rw] browse_carousel_card
          #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::BrowseCarouselCard]
          #     Browse carousel card for Actions on Google.
          # @!attribute [rw] table_card
          #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::TableCard]
          #     Table card for Actions on Google.
          # @!attribute [rw] media_content
          #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::MediaContent]
          #     The media content card for Actions on Google.
          # @!attribute [rw] platform
          #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::Platform]
          #     Optional. The platform that this message is intended for.
          class Message
            # The text response message.
            # @!attribute [rw] text
            #   @return [Array<String>]
            #     Optional. The collection of the agent's responses.
            class Text; end

            # The image response message.
            # @!attribute [rw] image_uri
            #   @return [String]
            #     Optional. The public URI to an image file.
            # @!attribute [rw] accessibility_text
            #   @return [String]
            #     A text description of the image to be used for accessibility,
            #     e.g., screen readers. Required if image_uri is set for CarouselSelect.
            class Image; end

            # The quick replies response message.
            # @!attribute [rw] title
            #   @return [String]
            #     Optional. The title of the collection of quick replies.
            # @!attribute [rw] quick_replies
            #   @return [Array<String>]
            #     Optional. The collection of quick replies.
            class QuickReplies; end

            # The card response message.
            # @!attribute [rw] title
            #   @return [String]
            #     Optional. The title of the card.
            # @!attribute [rw] subtitle
            #   @return [String]
            #     Optional. The subtitle of the card.
            # @!attribute [rw] image_uri
            #   @return [String]
            #     Optional. The public URI to an image file for the card.
            # @!attribute [rw] buttons
            #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Intent::Message::Card::Button>]
            #     Optional. The collection of card buttons.
            class Card
              # Optional. Contains information about a button.
              # @!attribute [rw] text
              #   @return [String]
              #     Optional. The text to show on the button.
              # @!attribute [rw] postback
              #   @return [String]
              #     Optional. The text to send back to the Dialogflow API or a URI to
              #     open.
              class Button; end
            end

            # The simple response message containing speech or text.
            # @!attribute [rw] text_to_speech
            #   @return [String]
            #     One of text_to_speech or ssml must be provided. The plain text of the
            #     speech output. Mutually exclusive with ssml.
            # @!attribute [rw] ssml
            #   @return [String]
            #     One of text_to_speech or ssml must be provided. Structured spoken
            #     response to the user in the SSML format. Mutually exclusive with
            #     text_to_speech.
            # @!attribute [rw] display_text
            #   @return [String]
            #     Optional. The text to display.
            class SimpleResponse; end

            # The collection of simple response candidates.
            # This message in `QueryResult.fulfillment_messages` and
            # `WebhookResponse.fulfillment_messages` should contain only one
            # `SimpleResponse`.
            # @!attribute [rw] simple_responses
            #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Intent::Message::SimpleResponse>]
            #     Required. The list of simple responses.
            class SimpleResponses; end

            # The basic card message. Useful for displaying information.
            # @!attribute [rw] title
            #   @return [String]
            #     Optional. The title of the card.
            # @!attribute [rw] subtitle
            #   @return [String]
            #     Optional. The subtitle of the card.
            # @!attribute [rw] formatted_text
            #   @return [String]
            #     Required, unless image is present. The body text of the card.
            # @!attribute [rw] image
            #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::Image]
            #     Optional. The image for the card.
            # @!attribute [rw] buttons
            #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Intent::Message::BasicCard::Button>]
            #     Optional. The collection of card buttons.
            class BasicCard
              # The button object that appears at the bottom of a card.
              # @!attribute [rw] title
              #   @return [String]
              #     Required. The title of the button.
              # @!attribute [rw] open_uri_action
              #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::BasicCard::Button::OpenUriAction]
              #     Required. Action to take when a user taps on the button.
              class Button
                # Opens the given URI.
                # @!attribute [rw] uri
                #   @return [String]
                #     Required. The HTTP or HTTPS scheme URI.
                class OpenUriAction; end
              end
            end

            # The suggestion chip message that the user can tap to quickly post a reply
            # to the conversation.
            # @!attribute [rw] title
            #   @return [String]
            #     Required. The text shown the in the suggestion chip.
            class Suggestion; end

            # The collection of suggestions.
            # @!attribute [rw] suggestions
            #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Intent::Message::Suggestion>]
            #     Required. The list of suggested replies.
            class Suggestions; end

            # The suggestion chip message that allows the user to jump out to the app
            # or website associated with this agent.
            # @!attribute [rw] destination_name
            #   @return [String]
            #     Required. The name of the app or site this chip is linking to.
            # @!attribute [rw] uri
            #   @return [String]
            #     Required. The URI of the app or site to open when the user taps the
            #     suggestion chip.
            class LinkOutSuggestion; end

            # The card for presenting a list of options to select from.
            # @!attribute [rw] title
            #   @return [String]
            #     Optional. The overall title of the list.
            # @!attribute [rw] items
            #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Intent::Message::ListSelect::Item>]
            #     Required. List items.
            # @!attribute [rw] subtitle
            #   @return [String]
            #     Optional. Subtitle of the list.
            class ListSelect
              # An item in the list.
              # @!attribute [rw] info
              #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::SelectItemInfo]
              #     Required. Additional information about this option.
              # @!attribute [rw] title
              #   @return [String]
              #     Required. The title of the list item.
              # @!attribute [rw] description
              #   @return [String]
              #     Optional. The main text describing the item.
              # @!attribute [rw] image
              #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::Image]
              #     Optional. The image to display.
              class Item; end
            end

            # The card for presenting a carousel of options to select from.
            # @!attribute [rw] items
            #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Intent::Message::CarouselSelect::Item>]
            #     Required. Carousel items.
            class CarouselSelect
              # An item in the carousel.
              # @!attribute [rw] info
              #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::SelectItemInfo]
              #     Required. Additional info about the option item.
              # @!attribute [rw] title
              #   @return [String]
              #     Required. Title of the carousel item.
              # @!attribute [rw] description
              #   @return [String]
              #     Optional. The body text of the card.
              # @!attribute [rw] image
              #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::Image]
              #     Optional. The image to display.
              class Item; end
            end

            # Additional info about the select item for when it is triggered in a
            # dialog.
            # @!attribute [rw] key
            #   @return [String]
            #     Required. A unique key that will be sent back to the agent if this
            #     response is given.
            # @!attribute [rw] synonyms
            #   @return [Array<String>]
            #     Optional. A list of synonyms that can also be used to trigger this
            #     item in dialog.
            class SelectItemInfo; end

            # Plays audio from a file in Telephony Gateway.
            # @!attribute [rw] audio_uri
            #   @return [String]
            #     Required. URI to a Google Cloud Storage object containing the audio to
            #     play, e.g., "gs://bucket/object". The object must contain a single
            #     channel (mono) of linear PCM audio (2 bytes / sample) at 8kHz.
            #
            #     This object must be readable by the `service-<Project
            #     Number>@gcp-sa-dialogflow.iam.gserviceaccount.com` service account
            #     where <Project Number> is the number of the Telephony Gateway project
            #     (usually the same as the Dialogflow agent project). If the Google Cloud
            #     Storage bucket is in the Telephony Gateway project, this permission is
            #     added by default when enabling the Dialogflow V2 API.
            #
            #     For audio from other sources, consider using the
            #     `TelephonySynthesizeSpeech` message with SSML.
            class TelephonyPlayAudio; end

            # Synthesizes speech and plays back the synthesized audio to the caller in
            # Telephony Gateway.
            #
            # Telephony Gateway takes the synthesizer settings from
            # `DetectIntentResponse.output_audio_config` which can either be set
            # at request-level or can come from the agent-level synthesizer config.
            # @!attribute [rw] text
            #   @return [String]
            #     The raw text to be synthesized.
            # @!attribute [rw] ssml
            #   @return [String]
            #     The SSML to be synthesized. For more information, see
            #     [SSML](https://developers.google.com/actions/reference/ssml).
            class TelephonySynthesizeSpeech; end

            # Transfers the call in Telephony Gateway.
            # @!attribute [rw] phone_number
            #   @return [String]
            #     Required. The phone number to transfer the call to
            #     in [E.164 format](https://en.wikipedia.org/wiki/E.164).
            #
            #     We currently only allow transferring to US numbers (+1xxxyyyzzzz).
            class TelephonyTransferCall; end

            # Rich Business Messaging (RBM) text response with suggestions.
            # @!attribute [rw] text
            #   @return [String]
            #     Required. Text sent and displayed to the user.
            # @!attribute [rw] rbm_suggestion
            #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Intent::Message::RbmSuggestion>]
            #     Optional. One or more suggestions to show to the user.
            class RbmText; end

            # Carousel Rich Business Messaging (RBM) rich card.
            #
            # Rich cards allow you to respond to users with more vivid content, e.g.
            # with media and suggestions.
            #
            # If you want to show a single card with more control over the layout,
            # please use {Google::Cloud::Dialogflow::V2beta1::Intent::Message::RbmStandaloneCard RbmStandaloneCard} instead.
            # @!attribute [rw] card_width
            #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::RbmCarouselCard::CardWidth]
            #     Required. The width of the cards in the carousel.
            # @!attribute [rw] card_contents
            #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Intent::Message::RbmCardContent>]
            #     Required. The cards in the carousel. A carousel must have at least
            #     2 cards and at most 10.
            class RbmCarouselCard
              # The width of the cards in the carousel.
              module CardWidth
                # Not specified.
                CARD_WIDTH_UNSPECIFIED = 0

                # 120 DP. Note that tall media cannot be used.
                SMALL = 1

                # 232 DP.
                MEDIUM = 2
              end
            end

            # Standalone Rich Business Messaging (RBM) rich card.
            #
            # Rich cards allow you to respond to users with more vivid content, e.g.
            # with media and suggestions.
            #
            # You can group multiple rich cards into one using {Google::Cloud::Dialogflow::V2beta1::Intent::Message::RbmCarouselCard RbmCarouselCard} but
            # carousel cards will give you less control over the card layout.
            # @!attribute [rw] card_orientation
            #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::RbmStandaloneCard::CardOrientation]
            #     Required. Orientation of the card.
            # @!attribute [rw] thumbnail_image_alignment
            #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::RbmStandaloneCard::ThumbnailImageAlignment]
            #     Required if orientation is horizontal.
            #     Image preview alignment for standalone cards with horizontal layout.
            # @!attribute [rw] card_content
            #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::RbmCardContent]
            #     Required. Card content.
            class RbmStandaloneCard
              # Orientation of the card.
              module CardOrientation
                # Not specified.
                CARD_ORIENTATION_UNSPECIFIED = 0

                # Horizontal layout.
                HORIZONTAL = 1

                # Vertical layout.
                VERTICAL = 2
              end

              # Thumbnail preview alignment for standalone cards with horizontal
              # layout.
              module ThumbnailImageAlignment
                # Not specified.
                THUMBNAIL_IMAGE_ALIGNMENT_UNSPECIFIED = 0

                # Thumbnail preview is left-aligned.
                LEFT = 1

                # Thumbnail preview is right-aligned.
                RIGHT = 2
              end
            end

            # Rich Business Messaging (RBM) Card content
            # @!attribute [rw] title
            #   @return [String]
            #     Optional. Title of the card (at most 200 bytes).
            #
            #     At least one of the title, description or media must be set.
            # @!attribute [rw] description
            #   @return [String]
            #     Optional. Description of the card (at most 2000 bytes).
            #
            #     At least one of the title, description or media must be set.
            # @!attribute [rw] media
            #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::RbmCardContent::RbmMedia]
            #     Optional. However at least one of the title, description or media must
            #     be set. Media (image, GIF or a video) to include in the card.
            # @!attribute [rw] suggestions
            #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Intent::Message::RbmSuggestion>]
            #     Optional. List of suggestions to include in the card.
            class RbmCardContent
              # Rich Business Messaging (RBM) Media displayed in Cards
              # The following media-types are currently supported:
              #
              # Image Types
              #
              # * image/jpeg
              # * image/jpg'
              # * image/gif
              # * image/png
              #
              # Video Types
              #
              # * video/h263
              # * video/m4v
              # * video/mp4
              # * video/mpeg
              # * video/mpeg4
              # * video/webm
              # @!attribute [rw] file_uri
              #   @return [String]
              #     Required. Publicly reachable URI of the file. The RBM platform
              #     determines the MIME type of the file from the content-type field in
              #     the HTTP headers when the platform fetches the file. The content-type
              #     field must be present and accurate in the HTTP response from the URL.
              # @!attribute [rw] thumbnail_uri
              #   @return [String]
              #     Optional. Publicly reachable URI of the thumbnail.If you don't
              #     provide a thumbnail URI, the RBM platform displays a blank
              #     placeholder thumbnail until the user's device downloads the file.
              #     Depending on the user's setting, the file may not download
              #     automatically and may require the user to tap a download button.
              # @!attribute [rw] height
              #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::RbmCardContent::RbmMedia::Height]
              #     Required for cards with vertical orientation. The height of the media
              #     within a rich card with a vertical layout.
              #     For a standalone card with horizontal layout, height is not
              #     customizable, and this field is ignored.
              class RbmMedia
                # Media height
                module Height
                  # Not specified.
                  HEIGHT_UNSPECIFIED = 0

                  # 112 DP.
                  SHORT = 1

                  # 168 DP.
                  MEDIUM = 2

                  # 264 DP. Not available for rich card carousels when the card width
                  # is set to small.
                  TALL = 3
                end
              end
            end

            # Rich Business Messaging (RBM) suggestion. Suggestions allow user to
            # easily select/click a predefined response or perform an action (like
            # opening a web uri).
            # @!attribute [rw] reply
            #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::RbmSuggestedReply]
            #     Predefined replies for user to select instead of typing
            # @!attribute [rw] action
            #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::RbmSuggestedAction]
            #     Predefined client side actions that user can choose
            class RbmSuggestion; end

            # Rich Business Messaging (RBM) suggested reply that the user can click
            # instead of typing in their own response.
            # @!attribute [rw] text
            #   @return [String]
            #     Suggested reply text.
            # @!attribute [rw] postback_data
            #   @return [String]
            #     Opaque payload that the Dialogflow receives in a user event
            #     when the user taps the suggested reply. This data will be also
            #     forwarded to webhook to allow performing custom business logic.
            class RbmSuggestedReply; end

            # Rich Business Messaging (RBM) suggested client-side action that the user
            # can choose from the card.
            # @!attribute [rw] text
            #   @return [String]
            #     Text to display alongside the action.
            # @!attribute [rw] postback_data
            #   @return [String]
            #     Opaque payload that the Dialogflow receives in a user event
            #     when the user taps the suggested action. This data will be also
            #     forwarded to webhook to allow performing custom business logic.
            # @!attribute [rw] dial
            #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::RbmSuggestedAction::RbmSuggestedActionDial]
            #     Suggested client side action: Dial a phone number
            # @!attribute [rw] open_url
            #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::RbmSuggestedAction::RbmSuggestedActionOpenUri]
            #     Suggested client side action: Open a URI on device
            # @!attribute [rw] share_location
            #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::RbmSuggestedAction::RbmSuggestedActionShareLocation]
            #     Suggested client side action: Share user location
            class RbmSuggestedAction
              # Opens the user's default dialer app with the specified phone number
              # but does not dial automatically.
              # @!attribute [rw] phone_number
              #   @return [String]
              #     Required. The phone number to fill in the default dialer app.
              #     This field should be in [E.164](https://en.wikipedia.org/wiki/E.164)
              #     format. An example of a correctly formatted phone number:
              #     +15556767888.
              class RbmSuggestedActionDial; end

              # Opens the user's default web browser app to the specified uri
              # If the user has an app installed that is
              # registered as the default handler for the URL, then this app will be
              # opened instead, and its icon will be used in the suggested action UI.
              # @!attribute [rw] uri
              #   @return [String]
              #     Required. The uri to open on the user device
              class RbmSuggestedActionOpenUri; end

              # Opens the device's location chooser so the user can pick a location
              # to send back to the agent.
              class RbmSuggestedActionShareLocation; end
            end

            # The media content card for Actions on Google.
            # @!attribute [rw] media_type
            #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::MediaContent::ResponseMediaType]
            #     Optional. What type of media is the content (ie "audio").
            # @!attribute [rw] media_objects
            #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Intent::Message::MediaContent::ResponseMediaObject>]
            #     Required. List of media objects.
            class MediaContent
              # Response media object for media content card.
              # @!attribute [rw] name
              #   @return [String]
              #     Required. Name of media card.
              # @!attribute [rw] description
              #   @return [String]
              #     Optional. Description of media card.
              # @!attribute [rw] large_image
              #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::Image]
              #     Optional. Image to display above media content.
              # @!attribute [rw] icon
              #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::Image]
              #     Optional. Icon to display above media content.
              # @!attribute [rw] content_url
              #   @return [String]
              #     Required. Url where the media is stored.
              class ResponseMediaObject; end

              # Format of response media type.
              module ResponseMediaType
                # Unspecified.
                RESPONSE_MEDIA_TYPE_UNSPECIFIED = 0

                # Response media type is audio.
                AUDIO = 1
              end
            end

            # Browse Carousel Card for Actions on Google.
            # https://developers.google.com/actions/assistant/responses#browsing_carousel
            # @!attribute [rw] items
            #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Intent::Message::BrowseCarouselCard::BrowseCarouselCardItem>]
            #     Required. List of items in the Browse Carousel Card. Minimum of two
            #     items, maximum of ten.
            # @!attribute [rw] image_display_options
            #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::BrowseCarouselCard::ImageDisplayOptions]
            #     Optional. Settings for displaying the image. Applies to every image in
            #     {Google::Cloud::Dialogflow::V2beta1::Intent::Message::BrowseCarouselCard#items items}.
            class BrowseCarouselCard
              # Browsing carousel tile
              # @!attribute [rw] open_uri_action
              #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::BrowseCarouselCard::BrowseCarouselCardItem::OpenUrlAction]
              #     Required. Action to present to the user.
              # @!attribute [rw] title
              #   @return [String]
              #     Required. Title of the carousel item. Maximum of two lines of text.
              # @!attribute [rw] description
              #   @return [String]
              #     Optional. Description of the carousel item. Maximum of four lines of
              #     text.
              # @!attribute [rw] image
              #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::Image]
              #     Optional. Hero image for the carousel item.
              # @!attribute [rw] footer
              #   @return [String]
              #     Optional. Text that appears at the bottom of the Browse Carousel
              #     Card. Maximum of one line of text.
              class BrowseCarouselCardItem
                # Actions on Google action to open a given url.
                # @!attribute [rw] url
                #   @return [String]
                #     Required. URL
                # @!attribute [rw] url_type_hint
                #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::BrowseCarouselCard::BrowseCarouselCardItem::OpenUrlAction::UrlTypeHint]
                #     Optional. Specifies the type of viewer that is used when opening
                #     the URL. Defaults to opening via web browser.
                class OpenUrlAction
                  # Type of the URI.
                  module UrlTypeHint
                    # Unspecified
                    URL_TYPE_HINT_UNSPECIFIED = 0

                    # Url would be an amp action
                    AMP_ACTION = 1

                    # URL that points directly to AMP content, or to a canonical URL
                    # which refers to AMP content via <link rel="amphtml">.
                    AMP_CONTENT = 2
                  end
                end
              end

              # Image display options for Actions on Google. This should be used for
              # when the image's aspect ratio does not match the image container's
              # aspect ratio.
              module ImageDisplayOptions
                # Fill the gaps between the image and the image container with gray
                # bars.
                IMAGE_DISPLAY_OPTIONS_UNSPECIFIED = 0

                # Fill the gaps between the image and the image container with gray
                # bars.
                GRAY = 1

                # Fill the gaps between the image and the image container with white
                # bars.
                WHITE = 2

                # Image is scaled such that the image width and height match or exceed
                # the container dimensions. This may crop the top and bottom of the
                # image if the scaled image height is greater than the container
                # height, or crop the left and right of the image if the scaled image
                # width is greater than the container width. This is similar to "Zoom
                # Mode" on a widescreen TV when playing a 4:3 video.
                CROPPED = 3

                # Pad the gaps between image and image frame with a blurred copy of the
                # same image.
                BLURRED_BACKGROUND = 4
              end
            end

            # Table card for Actions on Google.
            # @!attribute [rw] title
            #   @return [String]
            #     Required. Title of the card.
            # @!attribute [rw] subtitle
            #   @return [String]
            #     Optional. Subtitle to the title.
            # @!attribute [rw] image
            #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::Image]
            #     Optional. Image which should be displayed on the card.
            # @!attribute [rw] column_properties
            #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Intent::Message::ColumnProperties>]
            #     Optional. Display properties for the columns in this table.
            # @!attribute [rw] rows
            #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Intent::Message::TableCardRow>]
            #     Optional. Rows in this table of data.
            # @!attribute [rw] buttons
            #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Intent::Message::BasicCard::Button>]
            #     Optional. List of buttons for the card.
            class TableCard; end

            # Column properties for {Google::Cloud::Dialogflow::V2beta1::Intent::Message::TableCard TableCard}.
            # @!attribute [rw] header
            #   @return [String]
            #     Required. Column heading.
            # @!attribute [rw] horizontal_alignment
            #   @return [Google::Cloud::Dialogflow::V2beta1::Intent::Message::ColumnProperties::HorizontalAlignment]
            #     Optional. Defines text alignment for all cells in this column.
            class ColumnProperties
              # Text alignments within a cell.
              module HorizontalAlignment
                # Text is aligned to the leading edge of the column.
                HORIZONTAL_ALIGNMENT_UNSPECIFIED = 0

                # Text is aligned to the leading edge of the column.
                LEADING = 1

                # Text is centered in the column.
                CENTER = 2

                # Text is aligned to the trailing edge of the column.
                TRAILING = 3
              end
            end

            # Row of {Google::Cloud::Dialogflow::V2beta1::Intent::Message::TableCard TableCard}.
            # @!attribute [rw] cells
            #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Intent::Message::TableCardCell>]
            #     Optional. List of cells that make up this row.
            # @!attribute [rw] divider_after
            #   @return [true, false]
            #     Optional. Whether to add a visual divider after this row.
            class TableCardRow; end

            # Cell of {Google::Cloud::Dialogflow::V2beta1::Intent::Message::TableCardRow TableCardRow}.
            # @!attribute [rw] text
            #   @return [String]
            #     Required. Text in this cell.
            class TableCardCell; end

            # Represents different platforms that a rich message can be intended for.
            module Platform
              # Not specified.
              PLATFORM_UNSPECIFIED = 0

              # Facebook.
              FACEBOOK = 1

              # Slack.
              SLACK = 2

              # Telegram.
              TELEGRAM = 3

              # Kik.
              KIK = 4

              # Skype.
              SKYPE = 5

              # Line.
              LINE = 6

              # Viber.
              VIBER = 7

              # Google Assistant
              # See [Dialogflow webhook
              # format](https://developers.google.com/assistant/actions/build/json/dialogflow-webhook-json)
              ACTIONS_ON_GOOGLE = 8

              # Telephony Gateway.
              TELEPHONY = 10

              # Google Hangouts.
              GOOGLE_HANGOUTS = 11
            end
          end

          # Represents a single followup intent in the chain.
          # @!attribute [rw] followup_intent_name
          #   @return [String]
          #     The unique identifier of the followup intent.
          #     Format: `projects/<Project ID>/agent/intents/<Intent ID>`.
          # @!attribute [rw] parent_followup_intent_name
          #   @return [String]
          #     The unique identifier of the followup intent's parent.
          #     Format: `projects/<Project ID>/agent/intents/<Intent ID>`.
          class FollowupIntentInfo; end

          # Represents the different states that webhooks can be in.
          module WebhookState
            # Webhook is disabled in the agent and in the intent.
            WEBHOOK_STATE_UNSPECIFIED = 0

            # Webhook is enabled in the agent and in the intent.
            WEBHOOK_STATE_ENABLED = 1

            # Webhook is enabled in the agent and in the intent. Also, each slot
            # filling prompt is forwarded to the webhook.
            WEBHOOK_STATE_ENABLED_FOR_SLOT_FILLING = 2
          end
        end

        # The request message for {Google::Cloud::Dialogflow::V2beta1::Intents::ListIntents Intents::ListIntents}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The agent to list all intents from.
        #     Format: `projects/<Project ID>/agent`.
        # @!attribute [rw] language_code
        #   @return [String]
        #     Optional. The language used to access language-specific data.
        #     If not specified, the agent's default language is used.
        #     For more information, see
        #     [Multilingual intent and entity
        #     data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        # @!attribute [rw] intent_view
        #   @return [Google::Cloud::Dialogflow::V2beta1::IntentView]
        #     Optional. The resource view to apply to the returned intent.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     Optional. The maximum number of items to return in a single page. By
        #     default 100 and at most 1000.
        # @!attribute [rw] page_token
        #   @return [String]
        #     Optional. The next_page_token value returned from a previous list request.
        class ListIntentsRequest; end

        # The response message for {Google::Cloud::Dialogflow::V2beta1::Intents::ListIntents Intents::ListIntents}.
        # @!attribute [rw] intents
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Intent>]
        #     The list of agent intents. There will be a maximum number of items
        #     returned based on the page_size field in the request.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     Token to retrieve the next page of results, or empty if there are no
        #     more results in the list.
        class ListIntentsResponse; end

        # The request message for {Google::Cloud::Dialogflow::V2beta1::Intents::GetIntent Intents::GetIntent}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the intent.
        #     Supported formats:
        #
        #     * `projects/<Project ID>/agent/intents/<Intent ID>`
        #     * `projects/<Project ID>/locations/<Location ID>/agent/intents/<Intent ID>`
        # @!attribute [rw] language_code
        #   @return [String]
        #     Optional. The language used to access language-specific data.
        #     If not specified, the agent's default language is used.
        #     For more information, see
        #     [Multilingual intent and entity
        #     data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        # @!attribute [rw] intent_view
        #   @return [Google::Cloud::Dialogflow::V2beta1::IntentView]
        #     Optional. The resource view to apply to the returned intent.
        class GetIntentRequest; end

        # The request message for {Google::Cloud::Dialogflow::V2beta1::Intents::CreateIntent Intents::CreateIntent}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The agent to create a intent for.
        #     Supported formats:
        #
        #     * `projects/<Project ID>/agent`
        #     * `projects/<Project ID>/locations/<Location ID>/agent`
        # @!attribute [rw] intent
        #   @return [Google::Cloud::Dialogflow::V2beta1::Intent]
        #     Required. The intent to create.
        # @!attribute [rw] language_code
        #   @return [String]
        #     Optional. The language used to access language-specific data.
        #     If not specified, the agent's default language is used.
        #     For more information, see
        #     [Multilingual intent and entity
        #     data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        # @!attribute [rw] intent_view
        #   @return [Google::Cloud::Dialogflow::V2beta1::IntentView]
        #     Optional. The resource view to apply to the returned intent.
        class CreateIntentRequest; end

        # The request message for {Google::Cloud::Dialogflow::V2beta1::Intents::UpdateIntent Intents::UpdateIntent}.
        # @!attribute [rw] intent
        #   @return [Google::Cloud::Dialogflow::V2beta1::Intent]
        #     Required. The intent to update.
        # @!attribute [rw] language_code
        #   @return [String]
        #     Optional. The language used to access language-specific data.
        #     If not specified, the agent's default language is used.
        #     For more information, see
        #     [Multilingual intent and entity
        #     data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Optional. The mask to control which fields get updated.
        # @!attribute [rw] intent_view
        #   @return [Google::Cloud::Dialogflow::V2beta1::IntentView]
        #     Optional. The resource view to apply to the returned intent.
        class UpdateIntentRequest; end

        # The request message for {Google::Cloud::Dialogflow::V2beta1::Intents::DeleteIntent Intents::DeleteIntent}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the intent to delete. If this intent has direct or
        #     indirect followup intents, we also delete them.
        #
        #     Supported formats:
        #
        #     * `projects/<Project ID>/agent/intents/<Intent ID>`
        #     * `projects/<Project ID>/locations/<Location ID>/agent/intents/<Intent ID>`
        class DeleteIntentRequest; end

        # The request message for {Google::Cloud::Dialogflow::V2beta1::Intents::BatchUpdateIntents Intents::BatchUpdateIntents}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The name of the agent to update or create intents in.
        #     Supported formats:
        #
        #     * `projects/<Project ID>/agent`
        #     * `projects/<Project ID>/locations/<Location ID>/agent`
        # @!attribute [rw] intent_batch_uri
        #   @return [String]
        #     The URI to a Google Cloud Storage file containing intents to update or
        #     create. The file format can either be a serialized proto (of IntentBatch
        #     type) or JSON object. Note: The URI must start with "gs://".
        # @!attribute [rw] intent_batch_inline
        #   @return [Google::Cloud::Dialogflow::V2beta1::IntentBatch]
        #     The collection of intents to update or create.
        # @!attribute [rw] language_code
        #   @return [String]
        #     Optional. The language used to access language-specific data.
        #     If not specified, the agent's default language is used.
        #     For more information, see
        #     [Multilingual intent and entity
        #     data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Optional. The mask to control which fields get updated.
        # @!attribute [rw] intent_view
        #   @return [Google::Cloud::Dialogflow::V2beta1::IntentView]
        #     Optional. The resource view to apply to the returned intent.
        class BatchUpdateIntentsRequest; end

        # The response message for {Google::Cloud::Dialogflow::V2beta1::Intents::BatchUpdateIntents Intents::BatchUpdateIntents}.
        # @!attribute [rw] intents
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Intent>]
        #     The collection of updated or created intents.
        class BatchUpdateIntentsResponse; end

        # The request message for {Google::Cloud::Dialogflow::V2beta1::Intents::BatchDeleteIntents Intents::BatchDeleteIntents}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The name of the agent to delete all entities types for.
        #     Supported formats:
        #
        #     * `projects/<Project ID>/agent`
        #     * `projects/<Project ID>/locations/<Location ID>/agent`
        # @!attribute [rw] intents
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Intent>]
        #     Required. The collection of intents to delete. Only intent `name` must be
        #     filled in.
        class BatchDeleteIntentsRequest; end

        # This message is a wrapper around a collection of intents.
        # @!attribute [rw] intents
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Intent>]
        #     A collection of intents.
        class IntentBatch; end

        # Represents the options for views of an intent.
        # An intent can be a sizable object. Therefore, we provide a resource view that
        # does not return training phrases in the response by default.
        module IntentView
          # Training phrases field is not populated in the response.
          INTENT_VIEW_UNSPECIFIED = 0

          # All fields are populated.
          INTENT_VIEW_FULL = 1
        end
      end
    end
  end
end