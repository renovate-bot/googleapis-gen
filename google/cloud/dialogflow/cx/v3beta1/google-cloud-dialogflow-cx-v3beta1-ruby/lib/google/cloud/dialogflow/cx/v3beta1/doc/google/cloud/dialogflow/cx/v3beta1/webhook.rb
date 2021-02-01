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
          # Webhooks host the developer's business logic. During a session, webhooks
          # allow the developer to use the data extracted by Dialogflow's natural
          # language processing to generate dynamic responses, validate collected data,
          # or trigger actions on the backend.
          # @!attribute [rw] name
          #   @return [String]
          #     The unique identifier of the webhook.
          #     Required for the {Google::Cloud::Dialogflow::Cx::V3beta1::Webhooks::UpdateWebhook Webhooks::UpdateWebhook} method.
          #     {Google::Cloud::Dialogflow::Cx::V3beta1::Webhooks::CreateWebhook Webhooks::CreateWebhook} populates the name automatically.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/webhooks/<Webhook ID>`.
          # @!attribute [rw] display_name
          #   @return [String]
          #     Required. The human-readable name of the webhook, unique within the agent.
          # @!attribute [rw] generic_web_service
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Webhook::GenericWebService]
          #     Configuration for a generic web service.
          # @!attribute [rw] timeout
          #   @return [Google::Protobuf::Duration]
          #     Webhook execution timeout. Execution is considered failed if Dialogflow
          #     doesn't receive a response from webhook at the end of the timeout period.
          #     Defaults to 5 seconds, maximum allowed timeout is 30 seconds.
          # @!attribute [rw] disabled
          #   @return [true, false]
          #     Indicates whether the webhook is disabled.
          class Webhook
            # Represents configuration for a generic web service.
            # @!attribute [rw] uri
            #   @return [String]
            #     Required. The webhook URI for receiving POST requests. It must use https protocol.
            # @!attribute [rw] username
            #   @return [String]
            #     The user name for HTTP Basic authentication.
            # @!attribute [rw] password
            #   @return [String]
            #     The password for HTTP Basic authentication.
            # @!attribute [rw] request_headers
            #   @return [Hash{String => String}]
            #     The HTTP request headers to send together with webhook
            #     requests.
            class GenericWebService; end
          end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Webhooks::ListWebhooks Webhooks::ListWebhooks}.
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. The agent to list all webhooks for.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
          # @!attribute [rw] page_size
          #   @return [Integer]
          #     The maximum number of items to return in a single page. By default 100 and
          #     at most 1000.
          # @!attribute [rw] page_token
          #   @return [String]
          #     The next_page_token value returned from a previous list request.
          class ListWebhooksRequest; end

          # The response message for {Google::Cloud::Dialogflow::Cx::V3beta1::Webhooks::ListWebhooks Webhooks::ListWebhooks}.
          # @!attribute [rw] webhooks
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::Webhook>]
          #     The list of webhooks. There will be a maximum number of items returned
          #     based on the page_size field in the request.
          # @!attribute [rw] next_page_token
          #   @return [String]
          #     Token to retrieve the next page of results, or empty if there are no more
          #     results in the list.
          class ListWebhooksResponse; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Webhooks::GetWebhook Webhooks::GetWebhook}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. The name of the webhook.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/webhooks/<Webhook ID>`.
          class GetWebhookRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Webhooks::CreateWebhook Webhooks::CreateWebhook}.
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. The agent to create a webhook for.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
          # @!attribute [rw] webhook
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Webhook]
          #     Required. The webhook to create.
          class CreateWebhookRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Webhooks::UpdateWebhook Webhooks::UpdateWebhook}.
          # @!attribute [rw] webhook
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Webhook]
          #     Required. The webhook to update.
          # @!attribute [rw] update_mask
          #   @return [Google::Protobuf::FieldMask]
          #     The mask to control which fields get updated. If the mask is not present,
          #     all fields will be updated.
          class UpdateWebhookRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Webhooks::DeleteWebhook Webhooks::DeleteWebhook}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. The name of the webhook to delete.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/webhooks/<Webhook ID>`.
          # @!attribute [rw] force
          #   @return [true, false]
          #     This field has no effect for webhook not being used.
          #     For webhooks that are used by pages/flows/transition route groups:
          #
          #     * If `force` is set to false, an error will be returned with message
          #       indicating the referenced resources.
          #     * If `force` is set to true, Dialogflow will remove the webhook, as well
          #       as any references to the webhook (i.e. {Google::Cloud::Dialogflow::Cx::V3beta1::Fulfillment#webhook Webhook}
          #       and {Google::Cloud::Dialogflow::Cx::V3beta1::Fulfillment#tag tag}in fulfillments that point to this webhook
          #       will be removed).
          class DeleteWebhookRequest; end

          # The request message for a webhook call.
          # @!attribute [rw] detect_intent_response_id
          #   @return [String]
          #     Always present. The unique identifier of the {Google::Cloud::Dialogflow::Cx::V3beta1::DetectIntentResponse DetectIntentResponse} that
          #     will be returned to the API caller.
          # @!attribute [rw] fulfillment_info
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::WebhookRequest::FulfillmentInfo]
          #     Always present. Information about the fulfillment that triggered this
          #     webhook call.
          # @!attribute [rw] intent_info
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::WebhookRequest::IntentInfo]
          #     Information about the last matched intent.
          # @!attribute [rw] page_info
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::PageInfo]
          #     Information about page status.
          # @!attribute [rw] session_info
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::SessionInfo]
          #     Information about session status.
          # @!attribute [rw] messages
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::ResponseMessage>]
          #     The list of rich message responses to present to the user. Webhook can
          #     choose to append or replace this list in
          #     {Google::Cloud::Dialogflow::Cx::V3beta1::WebhookResponse#fulfillment_response WebhookResponse#fulfillment_response};
          # @!attribute [rw] payload
          #   @return [Google::Protobuf::Struct]
          #     Custom data set in {Google::Cloud::Dialogflow::Cx::V3beta1::QueryParameters#payload QueryParameters#payload}.
          class WebhookRequest
            # Represents fulfillment information communicated to the webhook.
            # @!attribute [rw] tag
            #   @return [String]
            #     Always present. The tag used to identify which fulfillment is being
            #     called.
            class FulfillmentInfo; end

            # Represents intent information communicated to the webhook.
            # @!attribute [rw] last_matched_intent
            #   @return [String]
            #     Always present. The unique identifier of the last matched
            #     {Google::Cloud::Dialogflow::Cx::V3beta1::Intent intent}. Format: `projects/<Project ID>/locations/<Location
            #     ID>/agents/<Agent ID>/intents/<Intent ID>`.
            # @!attribute [rw] display_name
            #   @return [String]
            #     Always present. The display name of the last matched {Google::Cloud::Dialogflow::Cx::V3beta1::Intent intent}.
            # @!attribute [rw] parameters
            #   @return [Hash{String => Google::Cloud::Dialogflow::Cx::V3beta1::WebhookRequest::IntentInfo::IntentParameterValue}]
            #     Parameters identified as a result of intent matching. This is a map of
            #     the name of the identified parameter to the value of the parameter
            #     identified from the user's utterance. All parameters defined in the
            #     matched intent that are identified will be surfaced here.
            # @!attribute [rw] confidence
            #   @return [Float]
            #     The confidence of the matched intent. Values range from 0.0 (completely
            #     uncertain) to 1.0 (completely certain).
            class IntentInfo
              # Represents a value for an intent parameter.
              # @!attribute [rw] original_value
              #   @return [String]
              #     Always present. Original text value extracted from user utterance.
              # @!attribute [rw] resolved_value
              #   @return [Google::Protobuf::Value]
              #     Always present. Structured value for the parameter extracted from user
              #     utterance.
              class IntentParameterValue; end
            end
          end

          # The response message for a webhook call.
          # @!attribute [rw] fulfillment_response
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::WebhookResponse::FulfillmentResponse]
          #     The fulfillment response to send to the user. This field can be omitted by
          #     the webhook if it does not intend to send any response to the user.
          # @!attribute [rw] page_info
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::PageInfo]
          #     Information about page status. This field can be omitted by the webhook if
          #     it does not intend to modify page status.
          # @!attribute [rw] session_info
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::SessionInfo]
          #     Information about session status. This field can be omitted by the webhook
          #     if it does not intend to modify session status.
          # @!attribute [rw] payload
          #   @return [Google::Protobuf::Struct]
          #     Value to append directly to {Google::Cloud::Dialogflow::Cx::V3beta1::QueryResult#webhook_payloads QueryResult#webhook_payloads}.
          # @!attribute [rw] target_page
          #   @return [String]
          #     The target page to transition to.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/flows/<Flow ID>/pages/<Page ID>`.
          # @!attribute [rw] target_flow
          #   @return [String]
          #     The target flow to transition to.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/flows/<Flow ID>`.
          class WebhookResponse
            # Represents a fulfillment response to the user.
            # @!attribute [rw] messages
            #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::ResponseMessage>]
            #     The list of rich message responses to present to the user.
            # @!attribute [rw] merge_behavior
            #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::WebhookResponse::FulfillmentResponse::MergeBehavior]
            #     Merge behavior for `messages`.
            class FulfillmentResponse
              # Defines merge behavior for `messages`.
              module MergeBehavior
                # Not specified. `APPEND` will be used.
                MERGE_BEHAVIOR_UNSPECIFIED = 0

                # `messages` will be appended to the list of messages waiting to be sent
                # to the user.
                APPEND = 1

                # `messages` will replace the list of messages waiting to be sent to the
                # user.
                REPLACE = 2
              end
            end
          end

          # Represents page information communicated to and from the webhook.
          # @!attribute [rw] current_page
          #   @return [String]
          #     Always present for {Google::Cloud::Dialogflow::Cx::V3beta1::WebhookRequest WebhookRequest}. Ignored for {Google::Cloud::Dialogflow::Cx::V3beta1::WebhookResponse WebhookResponse}.
          #     The unique identifier of the current page.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/flows/<Flow ID>/pages/<Page ID>`.
          # @!attribute [rw] form_info
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::PageInfo::FormInfo]
          #     Optional for both {Google::Cloud::Dialogflow::Cx::V3beta1::WebhookRequest WebhookRequest} and {Google::Cloud::Dialogflow::Cx::V3beta1::WebhookResponse WebhookResponse}.
          #     Information about the form.
          class PageInfo
            # Represents form information.
            # @!attribute [rw] parameter_info
            #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::PageInfo::FormInfo::ParameterInfo>]
            #     Optional for both {Google::Cloud::Dialogflow::Cx::V3beta1::WebhookRequest WebhookRequest} and {Google::Cloud::Dialogflow::Cx::V3beta1::WebhookResponse WebhookResponse}.
            #     The parameters contained in the form. Note that the webhook cannot add
            #     or remove any form parameter.
            class FormInfo
              # Represents parameter information.
              # @!attribute [rw] display_name
              #   @return [String]
              #     Always present for {Google::Cloud::Dialogflow::Cx::V3beta1::WebhookRequest WebhookRequest}. Required for
              #     {Google::Cloud::Dialogflow::Cx::V3beta1::WebhookResponse WebhookResponse}.
              #     The human-readable name of the parameter, unique within the form. This
              #     field cannot be modified by the webhook.
              # @!attribute [rw] required
              #   @return [true, false]
              #     Optional for both {Google::Cloud::Dialogflow::Cx::V3beta1::WebhookRequest WebhookRequest} and {Google::Cloud::Dialogflow::Cx::V3beta1::WebhookResponse WebhookResponse}.
              #     Indicates whether the parameter is required. Optional parameters will
              #     not trigger prompts; however, they are filled if the user specifies
              #     them. Required parameters must be filled before form filling concludes.
              # @!attribute [rw] state
              #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::PageInfo::FormInfo::ParameterInfo::ParameterState]
              #     Always present for {Google::Cloud::Dialogflow::Cx::V3beta1::WebhookRequest WebhookRequest}. Required for
              #     {Google::Cloud::Dialogflow::Cx::V3beta1::WebhookResponse WebhookResponse}. The state of the parameter. This field can be set
              #     to {Google::Cloud::Dialogflow::Cx::V3beta1::PageInfo::FormInfo::ParameterInfo::ParameterState::INVALID INVALID} by
              #     the webhook to invalidate the parameter; other values set by the
              #     webhook will be ignored.
              # @!attribute [rw] value
              #   @return [Google::Protobuf::Value]
              #     Optional for both {Google::Cloud::Dialogflow::Cx::V3beta1::WebhookRequest WebhookRequest} and {Google::Cloud::Dialogflow::Cx::V3beta1::WebhookResponse WebhookResponse}.
              #     The value of the parameter. This field can be set by the webhook to
              #     change the parameter value.
              # @!attribute [rw] just_collected
              #   @return [true, false]
              #     Optional for {Google::Cloud::Dialogflow::Cx::V3beta1::WebhookRequest WebhookRequest}. Ignored for {Google::Cloud::Dialogflow::Cx::V3beta1::WebhookResponse WebhookResponse}.
              #     Indicates if the parameter value was just collected on the last
              #     conversation turn.
              class ParameterInfo
                # Represents the state of a parameter.
                module ParameterState
                  # Not specified. This value should be never used.
                  PARAMETER_STATE_UNSPECIFIED = 0

                  # Indicates that the parameter does not have a value.
                  EMPTY = 1

                  # Indicates that the parameter value is invalid. This field can be used
                  # by the webhook to invalidate the parameter and ask the server to
                  # collect it from the user again.
                  INVALID = 2

                  # Indicates that the parameter has a value.
                  FILLED = 3
                end
              end
            end
          end

          # Represents session information communicated to and from the webhook.
          # @!attribute [rw] session
          #   @return [String]
          #     Always present for {Google::Cloud::Dialogflow::Cx::V3beta1::WebhookRequest WebhookRequest}. Ignored for {Google::Cloud::Dialogflow::Cx::V3beta1::WebhookResponse WebhookResponse}.
          #     The unique identifier of the {Google::Cloud::Dialogflow::Cx::V3beta1::DetectIntentRequest#session session}. This
          #     field can be used by the webhook to identify a session.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/sessions/<Session ID>` or `projects/<Project ID>/locations/<Location
          #     ID>/agents/<Agent ID>/environments/<Environment ID>/sessions/<Session ID>`
          #     if environment is specified.
          # @!attribute [rw] parameters
          #   @return [Hash{String => Google::Protobuf::Value}]
          #     Optional for {Google::Cloud::Dialogflow::Cx::V3beta1::WebhookRequest WebhookRequest}. Optional for {Google::Cloud::Dialogflow::Cx::V3beta1::WebhookResponse WebhookResponse}.
          #     All parameters collected from forms and intents during the session.
          #     Parameters can be created, updated, or removed by the webhook. To remove a
          #     parameter from the session, the webhook should explicitly set the parameter
          #     value to null in {Google::Cloud::Dialogflow::Cx::V3beta1::WebhookResponse WebhookResponse}. The map is keyed by parameters'
          #     display names.
          class SessionInfo; end
        end
      end
    end
  end
end