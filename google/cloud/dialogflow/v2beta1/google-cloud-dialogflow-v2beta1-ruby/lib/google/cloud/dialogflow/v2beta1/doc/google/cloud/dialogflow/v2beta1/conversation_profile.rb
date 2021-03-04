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
        # Defines the services to connect to incoming Dialogflow conversations.
        # @!attribute [rw] name
        #   @return [String]
        #     The unique identifier of this conversation profile.
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/conversationProfiles/<Conversation Profile ID>`.
        # @!attribute [rw] display_name
        #   @return [String]
        #     Required. Human readable name for this profile. Max length 1024 bytes.
        # @!attribute [rw] create_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. Create time of the conversation profile.
        # @!attribute [rw] update_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. Update time of the conversation profile.
        # @!attribute [rw] automated_agent_config
        #   @return [Google::Cloud::Dialogflow::V2beta1::AutomatedAgentConfig]
        #     Configuration for an automated agent to use with this profile.
        # @!attribute [rw] human_agent_assistant_config
        #   @return [Google::Cloud::Dialogflow::V2beta1::HumanAgentAssistantConfig]
        #     Configuration for agent assistance to use with this profile.
        # @!attribute [rw] human_agent_handoff_config
        #   @return [Google::Cloud::Dialogflow::V2beta1::HumanAgentHandoffConfig]
        #     Configuration for connecting to a live agent.
        # @!attribute [rw] notification_config
        #   @return [Google::Cloud::Dialogflow::V2beta1::NotificationConfig]
        #     Configuration for publishing conversation lifecycle events.
        # @!attribute [rw] logging_config
        #   @return [Google::Cloud::Dialogflow::V2beta1::LoggingConfig]
        #     Configuration for logging conversation lifecycle events.
        # @!attribute [rw] new_message_event_notification_config
        #   @return [Google::Cloud::Dialogflow::V2beta1::NotificationConfig]
        #     Configuration for publishing new message events. Event will be sent in
        #     format of {Google::Cloud::Dialogflow::V2beta1::ConversationEvent ConversationEvent}
        # @!attribute [rw] stt_config
        #   @return [Google::Cloud::Dialogflow::V2beta1::SpeechToTextConfig]
        #     Settings for speech transcription.
        # @!attribute [rw] language_code
        #   @return [String]
        #     Language code for the conversation profile. If not specified, the language
        #     is en-US. Language at ConversationProfile should be set for all non en-us
        #     languages.
        class ConversationProfile; end

        # Defines the Automated Agent to connect to a conversation.
        # @!attribute [rw] agent
        #   @return [String]
        #     Required. ID of the Dialogflow agent environment to use.
        #
        #     This project needs to either be the same project as the conversation or you
        #     need to grant `service-<Conversation Project
        #     Number>@gcp-sa-dialogflow.iam.gserviceaccount.com` the `Dialogflow API
        #     Service Agent` role in this project.
        #
        #     * For ES agents, use format: `projects/<Project ID>/locations/<Location
        #       ID>/agent/environments/<Environment ID or '-'>`. If environment is not
        #       specified, the default `draft` environment is used. Refer to
        #       [DetectIntentRequest](https://cloud.google.com/dialogflow/docs/reference/rpc/google.cloud.dialogflow.v2beta1#google.cloud.dialogflow.v2beta1.DetectIntentRequest)
        #       for more details.
        #
        #     * For CX agents, use format `projects/<Project ID>/locations/<Location
        #       ID>/agents/<Agent ID>/environments/<Environment ID
        #       or '-'>`. If environment is not specified, the default `draft` environment
        #       is used.
        class AutomatedAgentConfig; end

        # Defines the Human Agent Assistant to connect to a conversation.
        # @!attribute [rw] notification_config
        #   @return [Google::Cloud::Dialogflow::V2beta1::NotificationConfig]
        #     Pub/Sub topic on which to publish new agent assistant events.
        # @!attribute [rw] human_agent_suggestion_config
        #   @return [Google::Cloud::Dialogflow::V2beta1::HumanAgentAssistantConfig::SuggestionConfig]
        #     Configuration for agent assistance of human agent participant.
        # @!attribute [rw] end_user_suggestion_config
        #   @return [Google::Cloud::Dialogflow::V2beta1::HumanAgentAssistantConfig::SuggestionConfig]
        #     Configuration for agent assistance of end user participant.
        # @!attribute [rw] message_analysis_config
        #   @return [Google::Cloud::Dialogflow::V2beta1::HumanAgentAssistantConfig::MessageAnalysisConfig]
        #     Configuration for message analysis.
        class HumanAgentAssistantConfig
          # Settings of suggestion trigger.
          # @!attribute [rw] no_small_talk
          #   @return [true, false]
          #     Do not trigger if last utterance is small talk.
          # @!attribute [rw] only_end_user
          #   @return [true, false]
          #     Only trigger suggestion if participant role of last utterance is
          #     END_USER.
          class SuggestionTriggerSettings; end

          # Config for suggestion features.
          # @!attribute [rw] suggestion_feature
          #   @return [Google::Cloud::Dialogflow::V2beta1::SuggestionFeature]
          #     The suggestion feature.
          # @!attribute [rw] enable_event_based_suggestion
          #   @return [true, false]
          #     Automatically iterates all participants and tries to compile
          #     suggestions.
          #
          #     Supported features: ARTICLE_SUGGESTION, FAQ, DIALOGFLOW_ASSIST.
          # @!attribute [rw] suggestion_trigger_settings
          #   @return [Google::Cloud::Dialogflow::V2beta1::HumanAgentAssistantConfig::SuggestionTriggerSettings]
          #     Settings of suggestion trigger.
          #
          #     Currently, only ARTICLE_SUGGESTION, FAQ, and DIALOGFLOW_ASSIST will use
          #     this field.
          # @!attribute [rw] query_config
          #   @return [Google::Cloud::Dialogflow::V2beta1::HumanAgentAssistantConfig::SuggestionQueryConfig]
          #     Configs of query.
          # @!attribute [rw] conversation_model_config
          #   @return [Google::Cloud::Dialogflow::V2beta1::HumanAgentAssistantConfig::ConversationModelConfig]
          #     Configs of custom conversation model.
          class SuggestionFeatureConfig; end

          # Detail human agent assistant config.
          # @!attribute [rw] feature_configs
          #   @return [Array<Google::Cloud::Dialogflow::V2beta1::HumanAgentAssistantConfig::SuggestionFeatureConfig>]
          #     Configuration of different suggestion features. One feature can have only
          #     one config.
          # @!attribute [rw] group_suggestion_responses
          #   @return [true, false]
          #     If `group_suggestion_responses` is false, and there are multiple
          #     `feature_configs` in `event based suggestion` or
          #     StreamingAnalyzeContent, we will try to deliver suggestions to customers
          #     as soon as we get new suggestion. Different type of suggestions based on
          #     the same context will be in  separate Pub/Sub event or
          #     `StreamingAnalyzeContentResponse`.
          #
          #     If `group_suggestion_responses` set to true. All the suggestions to the
          #     same participant based on the same context will be grouped into a single
          #     Pub/Sub event or StreamingAnalyzeContentResponse.
          class SuggestionConfig; end

          # Config for suggestion query.
          # @!attribute [rw] knowledge_base_query_source
          #   @return [Google::Cloud::Dialogflow::V2beta1::HumanAgentAssistantConfig::SuggestionQueryConfig::KnowledgeBaseQuerySource]
          #     Query from knowledgebase. It is used by:
          #     ARTICLE_SUGGESTION, FAQ.
          # @!attribute [rw] document_query_source
          #   @return [Google::Cloud::Dialogflow::V2beta1::HumanAgentAssistantConfig::SuggestionQueryConfig::DocumentQuerySource]
          #     Query from knowledge base document. It is used by:
          #     SMART_REPLY, SMART_COMPOSE.
          # @!attribute [rw] dialogflow_query_source
          #   @return [Google::Cloud::Dialogflow::V2beta1::HumanAgentAssistantConfig::SuggestionQueryConfig::DialogflowQuerySource]
          #     Query from Dialogflow agent. It is used by DIALOGFLOW_ASSIST.
          # @!attribute [rw] max_results
          #   @return [Integer]
          #     Maximum number of results to return. Currently, if unset, defaults to 10.
          #     And the max number is 20.
          # @!attribute [rw] confidence_threshold
          #   @return [Float]
          #     Confidence threshold of query result.
          #
          #     Agent Assist gives each suggestion a score in the range [0.0, 1.0], based
          #     on the relevance between the suggestion and the current conversation
          #     context. A score of 0.0 has no relevance, while a score of 1.0 has high
          #     relevance. Only suggestions with a score greater than or equal to the
          #     value of this field are included in the results.
          #
          #     For a baseline model (the default), the recommended value is in the range
          #     [0.05, 0.1].
          #
          #     For a custom model, there is no recommended value. Tune this value by
          #     starting from a very low value and slowly increasing until you have
          #     desired results.
          #
          #     If this field is not set, it is default to 0.0, which means that all
          #     suggestions are returned.
          #
          #     Supported features: ARTICLE_SUGGESTION, FAQ, SMART_REPLY, SMART_COMPOSE.
          # @!attribute [rw] context_filter_settings
          #   @return [Google::Cloud::Dialogflow::V2beta1::HumanAgentAssistantConfig::SuggestionQueryConfig::ContextFilterSettings]
          #     Determines how recent conversation context is filtered when generating
          #     suggestions. If unspecified, no messages will be dropped.
          class SuggestionQueryConfig
            # Knowledge base source settings.
            #
            # Supported features: ARTICLE_SUGGESTION, FAQ.
            # @!attribute [rw] knowledge_bases
            #   @return [Array<String>]
            #     Required. Knowledge bases to query. Format:
            #     `projects/<Project ID>/locations/<Location
            #     ID>/knowledgeBases/<Knowledge Base ID>`. Currently, only one knowledge
            #     base is supported.
            class KnowledgeBaseQuerySource; end

            # Document source settings.
            #
            # Supported features: SMART_REPLY, SMART_COMPOSE.
            # @!attribute [rw] documents
            #   @return [Array<String>]
            #     Required. Knowledge documents to query from. Format:
            #     `projects/<Project ID>/locations/<Location
            #     ID>/knowledgeBases/<KnowledgeBase ID>/documents/<Document ID>`.
            #     Currently, only one document is supported.
            class DocumentQuerySource; end

            # Dialogflow source setting.
            #
            # Supported feature: DIALOGFLOW_ASSIST.
            # @!attribute [rw] agent
            #   @return [String]
            #     Required. The name of a dialogflow virtual agent used for end user side intent
            #     detection and suggestion. Format: `projects/<Project Number /
            #     ID>/locations/<Location ID>/agent`. When multiple agents are allowed in
            #     the same Dialogflow project.
            class DialogflowQuerySource; end

            # Settings that determine how to filter recent conversation context when
            # generating suggestions.
            # @!attribute [rw] drop_handoff_messages
            #   @return [true, false]
            #     If set to true, the last message from virtual agent (hand off message)
            #     and the message before it (trigger message of hand off) are dropped.
            # @!attribute [rw] drop_virtual_agent_messages
            #   @return [true, false]
            #     If set to true, all messages from virtual agent are dropped.
            # @!attribute [rw] drop_ivr_messages
            #   @return [true, false]
            #     If set to true, all messages from ivr stage are dropped.
            class ContextFilterSettings; end
          end

          # Custom conversation models used in agent assist feature.
          #
          # Supported feature: ARTICLE_SUGGESTION, SMART_COMPOSE, SMART_REPLY.
          # @!attribute [rw] model
          #   @return [String]
          #     Required. Conversation model resource name. Format: `projects/<Project
          #     ID>/conversationModels/<Model ID>`.
          class ConversationModelConfig; end

          # Configuration for analyses to run on each conversation message.
          # @!attribute [rw] enable_entity_extraction
          #   @return [true, false]
          #     Enable entity extraction in conversation messages on [agent assist
          #     stage](https://cloud.google.com/dialogflow/priv/docs/contact-center/basics#stages).
          #     If unspecified, defaults to false.
          # @!attribute [rw] enable_sentiment_analysis
          #   @return [true, false]
          #     Enable sentiment analysis in conversation messages on [agent assist
          #     stage](https://cloud.google.com/dialogflow/priv/docs/contact-center/basics#stages).
          #     If unspecified, defaults to false. Sentiment analysis inspects user input
          #     and identifies the prevailing subjective opinion, especially to determine
          #     a user's attitude as positive, negative, or neutral:
          #     https://cloud.google.com/natural-language/docs/basics#sentiment_analysis
          #     For {Google::Cloud::Dialogflow::V2beta1::Participants::StreamingAnalyzeContent Participants::StreamingAnalyzeContent} method, result will be in
          #     {Google::Cloud::Dialogflow::V2beta1::StreamingAnalyzeContentResponse#message StreamingAnalyzeContentResponse#message::SentimentAnalysisResult}.
          #     For {Google::Cloud::Dialogflow::V2beta1::Participants::AnalyzeContent Participants::AnalyzeContent} method, result will be in
          #     {Google::Cloud::Dialogflow::V2beta1::AnalyzeContentResponse#message AnalyzeContentResponse#message::SentimentAnalysisResult}
          #     For {Google::Cloud::Dialogflow::V2beta1::Conversations::ListMessages Conversations::ListMessages} method, result will be in
          #     {Google::Cloud::Dialogflow::V2beta1::ListMessagesResponse#messages ListMessagesResponse#messages::SentimentAnalysisResult}
          #     If Pub/Sub notification is configured, result will be in
          #     {Google::Cloud::Dialogflow::V2beta1::ConversationEvent#new_message_payload ConversationEvent#new_message_payload::SentimentAnalysisResult}.
          class MessageAnalysisConfig; end
        end

        # Defines the hand off to a live agent, typically on which external agent
        # service provider to connect to a conversation.
        # @!attribute [rw] live_person_config
        #   @return [Google::Cloud::Dialogflow::V2beta1::HumanAgentHandoffConfig::LivePersonConfig]
        #     Uses LivePerson (https://www.liveperson.com).
        # @!attribute [rw] salesforce_live_agent_config
        #   @return [Google::Cloud::Dialogflow::V2beta1::HumanAgentHandoffConfig::SalesforceLiveAgentConfig]
        #     Uses Salesforce Live Agent.
        class HumanAgentHandoffConfig
          # Configuration specific to LivePerson (https://www.liveperson.com).
          # @!attribute [rw] account_number
          #   @return [String]
          #     Required. Account number of the LivePerson account to connect. This is
          #     the account number you input at the login page.
          class LivePersonConfig; end

          # Configuration specific to Salesforce Live Agent.
          # @!attribute [rw] organization_id
          #   @return [String]
          #     Required. The organization ID of the Salesforce account.
          # @!attribute [rw] deployment_id
          #   @return [String]
          #     Required. Live Agent deployment ID.
          # @!attribute [rw] button_id
          #   @return [String]
          #     Required. Live Agent chat button ID.
          # @!attribute [rw] endpoint_domain
          #   @return [String]
          #     Required. Domain of the Live Agent endpoint for this agent. You can find
          #     the endpoint URL in the `Live Agent settings` page. For example if URL
          #     has the form https://d.la4-c2-phx.salesforceliveagent.com/...,
          #     you should fill in d.la4-c2-phx.salesforceliveagent.com.
          class SalesforceLiveAgentConfig; end
        end

        # Defines notification behavior.
        # @!attribute [rw] topic
        #   @return [String]
        #     Name of the Pub/Sub topic to publish conversation
        #     events like
        #     {Google::Cloud::Dialogflow::V2beta1::ConversationEvent::Type::CONVERSATION_STARTED CONVERSATION_STARTED} as
        #     serialized {Google::Cloud::Dialogflow::V2beta1::ConversationEvent ConversationEvent} protos.
        #
        #     Notification works for phone calls, if this topic either is in the same
        #     project as the conversation or you grant `service-<Conversation Project
        #     Number>@gcp-sa-dialogflow.iam.gserviceaccount.com` the `Dialogflow Service
        #     Agent` role in the topic project.
        #
        #     Format: `projects/<Project ID>/locations/<Location ID>/topics/<Topic ID>`.
        # @!attribute [rw] message_format
        #   @return [Google::Cloud::Dialogflow::V2beta1::NotificationConfig::MessageFormat]
        #     Format of message.
        class NotificationConfig
          # Format of cloud pub/sub message.
          module MessageFormat
            # If it is unspecified, PROTO will be used.
            MESSAGE_FORMAT_UNSPECIFIED = 0

            # Pubsub message will be serialized proto.
            PROTO = 1

            # Pubsub message will be json.
            JSON = 2
          end
        end

        # Defines logging behavior for conversation lifecycle events.
        # @!attribute [rw] enable_stackdriver_logging
        #   @return [true, false]
        #     Whether to log conversation events like
        #     {Google::Cloud::Dialogflow::V2beta1::ConversationEvent::Type::CONVERSATION_STARTED CONVERSATION_STARTED} to
        #     Stackdriver in the conversation project as JSON format
        #     {Google::Cloud::Dialogflow::V2beta1::ConversationEvent ConversationEvent} protos.
        class LoggingConfig; end

        # The request message for {Google::Cloud::Dialogflow::V2beta1::ConversationProfiles::ListConversationProfiles ConversationProfiles::ListConversationProfiles}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The project to list all conversation profiles from.
        #     Format: `projects/<Project ID>/locations/<Location ID>`.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The maximum number of items to return in a single page. By
        #     default 100 and at most 1000.
        # @!attribute [rw] page_token
        #   @return [String]
        #     The next_page_token value returned from a previous list request.
        class ListConversationProfilesRequest; end

        # The response message for {Google::Cloud::Dialogflow::V2beta1::ConversationProfiles::ListConversationProfiles ConversationProfiles::ListConversationProfiles}.
        # @!attribute [rw] conversation_profiles
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::ConversationProfile>]
        #     The list of project conversation profiles. There is a maximum number
        #     of items returned based on the page_size field in the request.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     Token to retrieve the next page of results, or empty if there are no
        #     more results in the list.
        class ListConversationProfilesResponse; end

        # The request message for {Google::Cloud::Dialogflow::V2beta1::ConversationProfiles::GetConversationProfile ConversationProfiles::GetConversationProfile}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The resource name of the conversation profile.
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/conversationProfiles/<Conversation Profile ID>`.
        class GetConversationProfileRequest; end

        # The request message for {Google::Cloud::Dialogflow::V2beta1::ConversationProfiles::CreateConversationProfile ConversationProfiles::CreateConversationProfile}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The project to create a conversation profile for.
        #     Format: `projects/<Project ID>/locations/<Location ID>`.
        # @!attribute [rw] conversation_profile
        #   @return [Google::Cloud::Dialogflow::V2beta1::ConversationProfile]
        #     Required. The conversation profile to create.
        class CreateConversationProfileRequest; end

        # The request message for {Google::Cloud::Dialogflow::V2beta1::ConversationProfiles::UpdateConversationProfile ConversationProfiles::UpdateConversationProfile}.
        # @!attribute [rw] conversation_profile
        #   @return [Google::Cloud::Dialogflow::V2beta1::ConversationProfile]
        #     Required. The conversation profile to update.
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Required. The mask to control which fields to update.
        class UpdateConversationProfileRequest; end

        # The request message for {Google::Cloud::Dialogflow::V2beta1::ConversationProfiles::DeleteConversationProfile ConversationProfiles::DeleteConversationProfile}.
        #
        # This operation fails if the conversation profile is still referenced from
        # a phone number.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the conversation profile to delete.
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/conversationProfiles/<Conversation Profile ID>`.
        class DeleteConversationProfileRequest; end
      end
    end
  end
end