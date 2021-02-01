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
          # An intent represents a user's intent to interact with a conversational agent.
          #
          # You can provide information for the Dialogflow API to use to match user input
          # to an intent by adding training phrases (i.e., examples of user input) to
          # your intent.
          # @!attribute [rw] name
          #   @return [String]
          #     The unique identifier of the intent.
          #     Required for the {Google::Cloud::Dialogflow::Cx::V3beta1::Intents::UpdateIntent Intents::UpdateIntent} method. {Google::Cloud::Dialogflow::Cx::V3beta1::Intents::CreateIntent Intents::CreateIntent}
          #     populates the name automatically.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/intents/<Intent ID>`.
          # @!attribute [rw] display_name
          #   @return [String]
          #     Required. The human-readable name of the intent, unique within the agent.
          # @!attribute [rw] training_phrases
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::Intent::TrainingPhrase>]
          #     The collection of training phrases the agent is trained on to identify the
          #     intent.
          # @!attribute [rw] parameters
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::Intent::Parameter>]
          #     The collection of parameters associated with the intent.
          # @!attribute [rw] priority
          #   @return [Integer]
          #     The priority of this intent. Higher numbers represent higher
          #     priorities.
          #
          #     * If the supplied value is unspecified or 0, the service
          #       translates the value to 500,000, which corresponds to the
          #       `Normal` priority in the console.
          #     * If the supplied value is negative, the intent is ignored
          #       in runtime detect intent requests.
          # @!attribute [rw] is_fallback
          #   @return [true, false]
          #     Indicates whether this is a fallback intent. Currently only default
          #     fallback intent is allowed in the agent, which is added upon agent
          #     creation.
          #     Adding training phrases to fallback intent is useful in the case of
          #     requests that are mistakenly matched, since training phrases assigned to
          #     fallback intents act as negative examples that triggers no-match event.
          # @!attribute [rw] labels
          #   @return [Hash{String => String}]
          #     Optional. The key/value metadata to label an intent. Labels can contain
          #     lowercase letters, digits and the symbols '-' and '_'. International
          #     characters are allowed, including letters from unicase alphabets. Keys must
          #     start with a letter. Keys and values can be no longer than 63 characters
          #     and no more than 128 bytes.
          #
          #     Prefix "sys-" is reserved for Dialogflow defined labels. Currently allowed
          #     Dialogflow defined labels include:
          #     * sys-head
          #     * sys-contextual
          #       The above labels do not require value. "sys-head" means the intent is a
          #       head intent. "sys-contextual" means the intent is a contextual intent.
          # @!attribute [rw] description
          #   @return [String]
          #     Optional. Human readable description for better understanding an intent like its
          #     scope, content, result etc. Maximum character limit: 140 characters.
          class Intent
            # Represents an example that the agent is trained on to identify the intent.
            # @!attribute [rw] id
            #   @return [String]
            #     Output only. The unique identifier of the training phrase.
            # @!attribute [rw] parts
            #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::Intent::TrainingPhrase::Part>]
            #     Required. The ordered list of training phrase parts.
            #     The parts are concatenated in order to form the training phrase.
            #
            #     Note: The API does not automatically annotate training phrases like the
            #     Dialogflow Console does.
            #
            #     Note: Do not forget to include whitespace at part boundaries, so the
            #     training phrase is well formatted when the parts are concatenated.
            #
            #     If the training phrase does not need to be annotated with parameters,
            #     you just need a single part with only the {Google::Cloud::Dialogflow::Cx::V3beta1::Intent::TrainingPhrase::Part#text Part#text} field set.
            #
            #     If you want to annotate the training phrase, you must create multiple
            #     parts, where the fields of each part are populated in one of two ways:
            #
            #     * `Part.text` is set to a part of the phrase that has no parameters.
            #     * `Part.text` is set to a part of the phrase that you want to annotate,
            #       and the `parameter_id` field is set.
            # @!attribute [rw] repeat_count
            #   @return [Integer]
            #     Indicates how many times this example was added to the intent.
            class TrainingPhrase
              # Represents a part of a training phrase.
              # @!attribute [rw] text
              #   @return [String]
              #     Required. The text for this part.
              # @!attribute [rw] parameter_id
              #   @return [String]
              #     The {Google::Cloud::Dialogflow::Cx::V3beta1::Intent::Parameter parameter} used to annotate this part of the
              #     training phrase. This field is required for annotated parts of the
              #     training phrase.
              class Part; end
            end

            # Represents an intent parameter.
            # @!attribute [rw] id
            #   @return [String]
            #     Required. The unique identifier of the parameter. This field
            #     is used by {Google::Cloud::Dialogflow::Cx::V3beta1::Intent::TrainingPhrase training phrases} to annotate their
            #     {Google::Cloud::Dialogflow::Cx::V3beta1::Intent::TrainingPhrase::Part parts}.
            # @!attribute [rw] entity_type
            #   @return [String]
            #     Required. The entity type of the parameter.
            #     Format: `projects/-/locations/-/agents/-/entityTypes/<System Entity Type
            #     ID>` for system entity types (for example,
            #     `projects/-/locations/-/agents/-/entityTypes/sys.date`), or
            #     `projects/<Project ID>/locations/<Location ID>/agents/<Agent
            #     ID>/entityTypes/<Entity Type ID>` for developer entity types.
            # @!attribute [rw] is_list
            #   @return [true, false]
            #     Indicates whether the parameter represents a list of values.
            # @!attribute [rw] redact
            #   @return [true, false]
            #     Indicates whether the parameter content should be redacted in log. If
            #     redaction is enabled, the parameter content will be replaced by parameter
            #     name during logging.
            #     Note: the parameter content is subject to redaction if either parameter
            #     level redaction or {Google::Cloud::Dialogflow::Cx::V3beta1::EntityType#redact entity type level redaction} is
            #     enabled.
            class Parameter; end
          end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Intents::ListIntents Intents::ListIntents}.
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. The agent to list all intents for.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
          # @!attribute [rw] language_code
          #   @return [String]
          #     The language to list intents for. The following fields are language
          #     dependent:
          #
          #     * `Intent.training_phrases.parts.text`
          #
          #     If not specified, the agent's default language is used.
          #     [Many
          #     languages](https://cloud.google.com/dialogflow/docs/reference/language)
          #     are supported.
          #     Note: languages must be enabled in the agent before they can be used.
          # @!attribute [rw] intent_view
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::IntentView]
          #     The resource view to apply to the returned intent.
          # @!attribute [rw] page_size
          #   @return [Integer]
          #     The maximum number of items to return in a single page. By default 100 and
          #     at most 1000.
          # @!attribute [rw] page_token
          #   @return [String]
          #     The next_page_token value returned from a previous list request.
          class ListIntentsRequest; end

          # The response message for {Google::Cloud::Dialogflow::Cx::V3beta1::Intents::ListIntents Intents::ListIntents}.
          # @!attribute [rw] intents
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::Intent>]
          #     The list of intents. There will be a maximum number of items returned based
          #     on the page_size field in the request.
          # @!attribute [rw] next_page_token
          #   @return [String]
          #     Token to retrieve the next page of results, or empty if there are no more
          #     results in the list.
          class ListIntentsResponse; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Intents::GetIntent Intents::GetIntent}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. The name of the intent.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/intents/<Intent ID>`.
          # @!attribute [rw] language_code
          #   @return [String]
          #     The language to retrieve the intent for. The following fields are language
          #     dependent:
          #
          #     * `Intent.training_phrases.parts.text`
          #
          #     If not specified, the agent's default language is used.
          #     [Many
          #     languages](https://cloud.google.com/dialogflow/docs/reference/language)
          #     are supported.
          #     Note: languages must be enabled in the agent before they can be used.
          class GetIntentRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Intents::CreateIntent Intents::CreateIntent}.
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. The agent to create an intent for.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
          # @!attribute [rw] intent
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Intent]
          #     Required. The intent to create.
          # @!attribute [rw] language_code
          #   @return [String]
          #     The language of the following fields in `intent`:
          #
          #     * `Intent.training_phrases.parts.text`
          #
          #     If not specified, the agent's default language is used.
          #     [Many
          #     languages](https://cloud.google.com/dialogflow/docs/reference/language)
          #     are supported.
          #     Note: languages must be enabled in the agent before they can be used.
          class CreateIntentRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Intents::UpdateIntent Intents::UpdateIntent}.
          # @!attribute [rw] intent
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Intent]
          #     Required. The intent to update.
          # @!attribute [rw] language_code
          #   @return [String]
          #     The language of the following fields in `intent`:
          #
          #     * `Intent.training_phrases.parts.text`
          #
          #     If not specified, the agent's default language is used.
          #     [Many
          #     languages](https://cloud.google.com/dialogflow/docs/reference/language)
          #     are supported.
          #     Note: languages must be enabled in the agent before they can be used.
          # @!attribute [rw] update_mask
          #   @return [Google::Protobuf::FieldMask]
          #     The mask to control which fields get updated. If the mask is not present,
          #     all fields will be updated.
          class UpdateIntentRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Intents::DeleteIntent Intents::DeleteIntent}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. The name of the intent to delete.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/intents/<Intent ID>`.
          class DeleteIntentRequest; end

          # Represents the options for views of an intent.
          # An intent can be a sizable object. Therefore, we provide a resource view that
          # does not return training phrases in the response.
          module IntentView
            # Not specified. Treated as INTENT_VIEW_FULL.
            INTENT_VIEW_UNSPECIFIED = 0

            # Training phrases field is not populated in the response.
            INTENT_VIEW_PARTIAL = 1

            # All fields are populated.
            INTENT_VIEW_FULL = 2
          end
        end
      end
    end
  end
end