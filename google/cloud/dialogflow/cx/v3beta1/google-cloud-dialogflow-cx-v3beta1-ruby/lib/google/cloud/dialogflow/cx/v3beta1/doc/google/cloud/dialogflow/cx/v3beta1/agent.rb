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
          # Settings related to speech recognition.
          # @!attribute [rw] enable_speech_adaptation
          #   @return [true, false]
          #     Whether to use speech adaptation for speech recognition.
          class SpeechToTextSettings; end

          # Agents are best described as Natural Language Understanding (NLU) modules
          # that transform user requests into actionable data. You can include agents
          # in your app, product, or service to determine user intent and respond to the
          # user in a natural way.
          #
          # After you create an agent, you can add {Google::Cloud::Dialogflow::Cx::V3beta1::Intent Intents},
          # {Google::Cloud::Dialogflow::Cx::V3beta1::EntityType Entity Types}, {Google::Cloud::Dialogflow::Cx::V3beta1::Flow Flows}, {Google::Cloud::Dialogflow::Cx::V3beta1::Fulfillment Fulfillments},
          # {Google::Cloud::Dialogflow::Cx::V3beta1::Webhook Webhooks}, and so on to manage the conversation flows..
          # @!attribute [rw] name
          #   @return [String]
          #     The unique identifier of the agent.
          #     Required for the {Google::Cloud::Dialogflow::Cx::V3beta1::Agents::UpdateAgent Agents::UpdateAgent} method. {Google::Cloud::Dialogflow::Cx::V3beta1::Agents::CreateAgent Agents::CreateAgent}
          #     populates the name automatically.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
          # @!attribute [rw] display_name
          #   @return [String]
          #     Required. The human-readable name of the agent, unique within the location.
          # @!attribute [rw] default_language_code
          #   @return [String]
          #     Immutable. The default language of the agent as a language tag.
          #     See [Language
          #     Support](https://cloud.google.com/dialogflow/cx/docs/reference/language)
          #     for a list of the currently supported language codes.
          #     This field cannot be set by the {Google::Cloud::Dialogflow::Cx::V3beta1::Agents::UpdateAgent Agents::UpdateAgent} method.
          # @!attribute [rw] time_zone
          #   @return [String]
          #     Required. The time zone of the agent from the [time zone
          #     database](https://www.iana.org/time-zones), e.g., America/New_York,
          #     Europe/Paris.
          # @!attribute [rw] description
          #   @return [String]
          #     The description of the agent. The maximum length is 500 characters. If
          #     exceeded, the request is rejected.
          # @!attribute [rw] avatar_uri
          #   @return [String]
          #     The URI of the agent's avatar. Avatars are used throughout the Dialogflow
          #     console and in the self-hosted [Web
          #     Demo](https://cloud.google.com/dialogflow/docs/integrations/web-demo)
          #     integration.
          # @!attribute [rw] speech_to_text_settings
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::SpeechToTextSettings]
          #     Speech recognition related settings.
          # @!attribute [rw] start_flow
          #   @return [String]
          #     Immutable. Name of the start flow in this agent. A start flow will be automatically
          #     created when the agent is created, and can only be deleted by deleting the
          #     agent.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/flows/<Flow ID>`.
          # @!attribute [rw] security_settings
          #   @return [String]
          #     Name of the {Google::Cloud::Dialogflow::Cx::V3beta1::SecuritySettings SecuritySettings} reference for the agent.
          #     Format: `projects/<Project ID>/locations/<Location
          #     ID>/securitySettings/<Security Settings ID>`.
          # @!attribute [rw] enable_stackdriver_logging
          #   @return [true, false]
          #     Indicates if stackdriver logging is enabled for the agent.
          # @!attribute [rw] enable_spell_correction
          #   @return [true, false]
          #     Indicates if automatic spell correction is enabled in detect intent
          #     requests.
          class Agent; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Agents::ListAgents Agents::ListAgents}.
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. The location to list all agents for.
          #     Format: `projects/<Project ID>/locations/<Location ID>`.
          # @!attribute [rw] page_size
          #   @return [Integer]
          #     The maximum number of items to return in a single page. By default 100 and
          #     at most 1000.
          # @!attribute [rw] page_token
          #   @return [String]
          #     The next_page_token value returned from a previous list request.
          class ListAgentsRequest; end

          # The response message for {Google::Cloud::Dialogflow::Cx::V3beta1::Agents::ListAgents Agents::ListAgents}.
          # @!attribute [rw] agents
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::Agent>]
          #     The list of agents. There will be a maximum number of items returned based
          #     on the page_size field in the request.
          # @!attribute [rw] next_page_token
          #   @return [String]
          #     Token to retrieve the next page of results, or empty if there are no more
          #     results in the list.
          class ListAgentsResponse; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Agents::GetAgent Agents::GetAgent}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. The name of the agent.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
          class GetAgentRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Agents::CreateAgent Agents::CreateAgent}.
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. The location to create a agent for.
          #     Format: `projects/<Project ID>/locations/<Location ID>`.
          # @!attribute [rw] agent
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Agent]
          #     Required. The agent to create.
          class CreateAgentRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Agents::UpdateAgent Agents::UpdateAgent}.
          # @!attribute [rw] agent
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Agent]
          #     Required. The agent to update.
          # @!attribute [rw] update_mask
          #   @return [Google::Protobuf::FieldMask]
          #     The mask to control which fields get updated. If the mask is not present,
          #     all fields will be updated.
          class UpdateAgentRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Agents::DeleteAgent Agents::DeleteAgent}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. The name of the agent to delete.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
          class DeleteAgentRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Agents::ExportAgent Agents::ExportAgent}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. The name of the agent to export.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
          # @!attribute [rw] agent_uri
          #   @return [String]
          #     Optional. The [Google Cloud Storage](https://cloud.google.com/storage/docs/) URI to
          #     export the agent to. The format of this URI must be
          #     `gs://<bucket-name>/<object-name>`.
          #     If left unspecified, the serialized agent is returned inline.
          class ExportAgentRequest; end

          # The response message for {Google::Cloud::Dialogflow::Cx::V3beta1::Agents::ExportAgent Agents::ExportAgent}.
          # @!attribute [rw] agent_uri
          #   @return [String]
          #     The URI to a file containing the exported agent. This field is populated
          #     only if `agent_uri` is specified in {Google::Cloud::Dialogflow::Cx::V3beta1::ExportAgentRequest ExportAgentRequest}.
          # @!attribute [rw] agent_content
          #   @return [String]
          #     Uncompressed raw byte content for agent.
          class ExportAgentResponse; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Agents::RestoreAgent Agents::RestoreAgent}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. The name of the agent to restore into.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
          # @!attribute [rw] agent_uri
          #   @return [String]
          #     The [Google Cloud Storage](https://cloud.google.com/storage/docs/) URI
          #     to restore agent from. The format of this URI must be
          #     `gs://<bucket-name>/<object-name>`.
          # @!attribute [rw] agent_content
          #   @return [String]
          #     Uncompressed raw byte content for agent.
          class RestoreAgentRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Agents::ValidateAgent Agents::ValidateAgent}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. The agent to validate.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
          # @!attribute [rw] language_code
          #   @return [String]
          #     If not specified, the agent's default language is used.
          class ValidateAgentRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Agents::GetAgentValidationResult Agents::GetAgentValidationResult}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. The agent name.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/validationResult`.
          # @!attribute [rw] language_code
          #   @return [String]
          #     If not specified, the agent's default language is used.
          class GetAgentValidationResultRequest; end

          # The response message for {Google::Cloud::Dialogflow::Cx::V3beta1::Agents::GetAgentValidationResult Agents::GetAgentValidationResult}.
          # @!attribute [rw] name
          #   @return [String]
          #     The unique identifier of the agent validation result.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/validationResult`.
          # @!attribute [rw] flow_validation_results
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::FlowValidationResult>]
          #     Contains all flow validation results.
          class AgentValidationResult; end
        end
      end
    end
  end
end