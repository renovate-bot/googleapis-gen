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
          # A Dialogflow CX conversation (session) can be described and visualized as a
          # state machine. The states of a CX session are represented by pages.
          #
          # For each flow, you define many pages, where your combined pages can handle a
          # complete conversation on the topics the flow is designed for. At any given
          # moment, exactly one page is the current page, the current page is considered
          # active, and the flow associated with that page is considered active. Every
          # flow has a special start page. When a flow initially becomes active, the
          # start page page becomes the current page. For each conversational turn, the
          # current page will either stay the same or transition to another page.
          #
          # You configure each page to collect information from the end-user that is
          # relevant for the conversational state represented by the page.
          #
          # For more information, see the
          # [Page guide](https://cloud.google.com/dialogflow/cx/docs/concept/page).
          # @!attribute [rw] name
          #   @return [String]
          #     The unique identifier of the page.
          #     Required for the {Google::Cloud::Dialogflow::Cx::V3beta1::Pages::UpdatePage Pages::UpdatePage} method. {Google::Cloud::Dialogflow::Cx::V3beta1::Pages::CreatePage Pages::CreatePage}
          #     populates the name automatically.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/flows/<Flow ID>/pages/<Page ID>`.
          # @!attribute [rw] display_name
          #   @return [String]
          #     Required. The human-readable name of the page, unique within the agent.
          # @!attribute [rw] entry_fulfillment
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Fulfillment]
          #     The fulfillment to call when the session is entering the page.
          # @!attribute [rw] form
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Form]
          #     The form associated with the page, used for collecting parameters
          #     relevant to the page.
          # @!attribute [rw] transition_route_groups
          #   @return [Array<String>]
          #     Ordered list of {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup `TransitionRouteGroups`} associated
          #     with the page. Transition route groups must be unique within a page.
          #
          #     * If multiple transition routes within a page scope refer to the same
          #       intent, then the precedence order is: page's transition route -> page's
          #       transition route group -> flow's transition routes.
          #
          #     * If multiple transition route groups within a page contain the same
          #       intent, then the first group in the ordered list takes precedence.
          #
          #     Format:`projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/flows/<Flow ID>/transitionRouteGroups/<TransitionRouteGroup ID>`.
          # @!attribute [rw] transition_routes
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRoute>]
          #     A list of transitions for the transition rules of this page.
          #     They route the conversation to another page in the same flow, or another
          #     flow.
          #
          #     When we are in a certain page, the TransitionRoutes are evalauted in the
          #     following order:
          #
          #     * TransitionRoutes defined in the page with intent specified.
          #     * TransitionRoutes defined in the
          #       {Google::Cloud::Dialogflow::Cx::V3beta1::Page#transition_route_groups transition route groups} with intent
          #       specified.
          #     * TransitionRoutes defined in flow with intent specified.
          #     * TransitionRoutes defined in the
          #       {Google::Cloud::Dialogflow::Cx::V3beta1::Flow#transition_route_groups transition route groups} with intent
          #       specified.
          #     * TransitionRoutes defined in the page with only condition specified.
          #     * TransitionRoutes defined in the
          #       {Google::Cloud::Dialogflow::Cx::V3beta1::Page#transition_route_groups transition route groups} with only
          #       condition specified.
          # @!attribute [rw] event_handlers
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::EventHandler>]
          #     Handlers associated with the page to handle events such as webhook errors,
          #     no match or no input.
          class Page; end

          # A form is a data model that groups related parameters that can be collected
          # from the user. The process in which the agent prompts the user and collects
          # parameter values from the user is called form filling. A form can be added to
          # a {Google::Cloud::Dialogflow::Cx::V3beta1::Page page}. When form filling is done, the filled parameters will be
          # written to the {Google::Cloud::Dialogflow::Cx::V3beta1::SessionInfo#parameters session}.
          # @!attribute [rw] parameters
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::Form::Parameter>]
          #     Parameters to collect from the user.
          class Form
            # Represents a form parameter.
            # @!attribute [rw] display_name
            #   @return [String]
            #     Required. The human-readable name of the parameter, unique within the
            #     form.
            # @!attribute [rw] required
            #   @return [true, false]
            #     Indicates whether the parameter is required. Optional parameters will not
            #     trigger prompts; however, they are filled if the user specifies them.
            #     Required parameters must be filled before form filling concludes.
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
            # @!attribute [rw] fill_behavior
            #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Form::Parameter::FillBehavior]
            #     Required. Defines fill behavior for the parameter.
            # @!attribute [rw] default_value
            #   @return [Google::Protobuf::Value]
            #     The default value of an optional parameter. If the parameter is required,
            #     the default value will be ignored.
            # @!attribute [rw] redact
            #   @return [true, false]
            #     Indicates whether the parameter content should be redacted in log.  If
            #     redaction is enabled, the parameter content will be replaced by parameter
            #     name during logging.
            #     Note: the parameter content is subject to redaction if either parameter
            #     level redaction or {Google::Cloud::Dialogflow::Cx::V3beta1::EntityType#redact entity type level redaction} is
            #     enabled.
            class Parameter
              # Configuration for how the filling of a parameter should be handled.
              # @!attribute [rw] initial_prompt_fulfillment
              #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Fulfillment]
              #     Required. The fulfillment to provide the initial prompt that the agent
              #     can present to the user in order to fill the parameter.
              # @!attribute [rw] reprompt_event_handlers
              #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::EventHandler>]
              #     The handlers for parameter-level events, used to provide reprompt for
              #     the parameter or transition to a different page/flow. The supported
              #     events are:
              #     * `sys.no-match-<N>`, where N can be from 1 to 6
              #     * `sys.no-match-default`
              #     * `sys.no-input-<N>`, where N can be from 1 to 6
              #     * `sys.no-input-default`
              #     * `sys.invalid-parameter`
              #
              #     `initial_prompt_fulfillment` provides the first prompt for the
              #     parameter.
              #
              #     If the user's response does not fill the parameter, a
              #     no-match/no-input event will be triggered, and the fulfillment
              #     associated with the `sys.no-match-1`/`sys.no-input-1` handler (if
              #     defined) will be called to provide a prompt. The
              #     `sys.no-match-2`/`sys.no-input-2` handler (if defined) will respond to
              #     the next no-match/no-input event, and so on.
              #
              #     A `sys.no-match-default` or `sys.no-input-default` handler will be used
              #     to handle all following no-match/no-input events after all numbered
              #     no-match/no-input handlers for the parameter are consumed.
              #
              #     A `sys.invalid-parameter` handler can be defined to handle the case
              #     where the parameter values have been `invalidated` by webhook. For
              #     example, if the user's response fill the parameter, however the
              #     parameter was invalidated by webhook, the fulfillment associated with
              #     the `sys.invalid-parameter` handler (if defined) will be called to
              #     provide a prompt.
              #
              #     If the event handler for the corresponding event can't be found on the
              #     parameter, `initial_prompt_fulfillment` will be re-prompted.
              class FillBehavior; end
            end
          end

          # An event handler specifies an {Google::Cloud::Dialogflow::Cx::V3beta1::EventHandler#event event} that can be handled
          # during a session. When the specified event happens, the following actions are
          # taken in order:
          #
          # * If there is a
          #   {Google::Cloud::Dialogflow::Cx::V3beta1::EventHandler#trigger_fulfillment `trigger_fulfillment`} associated with
          #   the event, it will be called.
          # * If there is a {Google::Cloud::Dialogflow::Cx::V3beta1::EventHandler#target_page `target_page`} associated
          #   with the event, the session will transition into the specified page.
          # * If there is a {Google::Cloud::Dialogflow::Cx::V3beta1::EventHandler#target_flow `target_flow`} associated
          #   with the event, the session will transition into the specified flow.
          # @!attribute [rw] name
          #   @return [String]
          #     Output only. The unique identifier of this event handler.
          # @!attribute [rw] event
          #   @return [String]
          #     Required. The name of the event to handle.
          # @!attribute [rw] trigger_fulfillment
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Fulfillment]
          #     The fulfillment to call when the event occurs.
          #     Handling webhook errors with a fulfillment enabled with webhook could
          #     cause infinite loop. It is invalid to specify such fulfillment for a
          #     handler handling webhooks.
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
          class EventHandler; end

          # A transition route specifies a {Google::Cloud::Dialogflow::Cx::V3beta1::Intent intent} that can be matched and/or a
          # data condition that can be evaluated during a session. When a specified
          # transition is matched, the following actions are taken in order:
          #
          # * If there is a
          #   {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRoute#trigger_fulfillment `trigger_fulfillment`} associated with
          #   the transition, it will be called.
          # * If there is a {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRoute#target_page `target_page`} associated
          #   with the transition, the session will transition into the specified page.
          # * If there is a {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRoute#target_flow `target_flow`} associated
          #   with the transition, the session will transition into the specified flow.
          # @!attribute [rw] name
          #   @return [String]
          #     Output only. The unique identifier of this transition route.
          # @!attribute [rw] intent
          #   @return [String]
          #     The unique identifier of an {Google::Cloud::Dialogflow::Cx::V3beta1::Intent Intent}.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/intents/<Intent ID>`.
          #     Indicates that the transition can only happen when the given intent is
          #     matched.
          #     At least one of `intent` or `condition` must be specified. When both
          #     `intent` and `condition` are specified, the transition can only happen
          #     when both are fulfilled.
          # @!attribute [rw] condition
          #   @return [String]
          #     The condition to evaluate against {Google::Cloud::Dialogflow::Cx::V3beta1::Form#parameters form parameters} or
          #     {Google::Cloud::Dialogflow::Cx::V3beta1::SessionInfo#parameters session parameters}.
          #
          #     See the [conditions
          #     reference](https://cloud.google.com/dialogflow/cx/docs/reference/condition).
          #     At least one of `intent` or `condition` must be specified. When both
          #     `intent` and `condition` are specified, the transition can only happen
          #     when both are fulfilled.
          # @!attribute [rw] trigger_fulfillment
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Fulfillment]
          #     The fulfillment to call when the condition is satisfied. At least one of
          #     `trigger_fulfillment` and `target` must be specified. When both are
          #     defined, `trigger_fulfillment` is executed first.
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
          class TransitionRoute; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Pages::ListPages Pages::ListPages}.
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. The flow to list all pages for.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/flows/<Flow ID>`.
          # @!attribute [rw] language_code
          #   @return [String]
          #     The language to list pages for. The following fields are language
          #     dependent:
          #
          #     * `Page.entry_fulfillment.messages`
          #     * `Page.form.parameters.fill_behavior.initial_prompt_fulfillment.messages`
          #     * `Page.form.parameters.fill_behavior.reprompt_event_handlers.messages`
          #     * `Page.transition_routes.trigger_fulfillment.messages`
          #       *
          #       `Page.transition_route_groups.transition_routes.trigger_fulfillment.messages`
          #
          #     If not specified, the agent's default language is used.
          #     [Many
          #     languages](https://cloud.google.com/dialogflow/docs/reference/language)
          #     are supported.
          #     Note: languages must be enabled in the agent before they can be used.
          # @!attribute [rw] page_size
          #   @return [Integer]
          #     The maximum number of items to return in a single page. By default 100 and
          #     at most 1000.
          # @!attribute [rw] page_token
          #   @return [String]
          #     The next_page_token value returned from a previous list request.
          class ListPagesRequest; end

          # The response message for {Google::Cloud::Dialogflow::Cx::V3beta1::Pages::ListPages Pages::ListPages}.
          # @!attribute [rw] pages
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::Page>]
          #     The list of pages. There will be a maximum number of items returned based
          #     on the page_size field in the request.
          # @!attribute [rw] next_page_token
          #   @return [String]
          #     Token to retrieve the next page of results, or empty if there are no more
          #     results in the list.
          class ListPagesResponse; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Pages::GetPage Pages::GetPage}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. The name of the page.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/flows/<Flow ID>/pages/<Page ID>`.
          # @!attribute [rw] language_code
          #   @return [String]
          #     The language to retrieve the page for. The following fields are language
          #     dependent:
          #
          #     * `Page.entry_fulfillment.messages`
          #     * `Page.form.parameters.fill_behavior.initial_prompt_fulfillment.messages`
          #     * `Page.form.parameters.fill_behavior.reprompt_event_handlers.messages`
          #     * `Page.transition_routes.trigger_fulfillment.messages`
          #       *
          #       `Page.transition_route_groups.transition_routes.trigger_fulfillment.messages`
          #
          #     If not specified, the agent's default language is used.
          #     [Many
          #     languages](https://cloud.google.com/dialogflow/docs/reference/language)
          #     are supported.
          #     Note: languages must be enabled in the agent before they can be used.
          class GetPageRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Pages::CreatePage Pages::CreatePage}.
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. The flow to create a page for.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/flows/<Flow ID>`.
          # @!attribute [rw] page
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Page]
          #     Required. The page to create.
          # @!attribute [rw] language_code
          #   @return [String]
          #     The language of the following fields in `page`:
          #
          #     * `Page.entry_fulfillment.messages`
          #     * `Page.form.parameters.fill_behavior.initial_prompt_fulfillment.messages`
          #     * `Page.form.parameters.fill_behavior.reprompt_event_handlers.messages`
          #     * `Page.transition_routes.trigger_fulfillment.messages`
          #       *
          #       `Page.transition_route_groups.transition_routes.trigger_fulfillment.messages`
          #
          #     If not specified, the agent's default language is used.
          #     [Many
          #     languages](https://cloud.google.com/dialogflow/docs/reference/language)
          #     are supported.
          #     Note: languages must be enabled in the agent before they can be used.
          class CreatePageRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Pages::UpdatePage Pages::UpdatePage}.
          # @!attribute [rw] page
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Page]
          #     Required. The page to update.
          # @!attribute [rw] language_code
          #   @return [String]
          #     The language of the following fields in `page`:
          #
          #     * `Page.entry_fulfillment.messages`
          #     * `Page.form.parameters.fill_behavior.initial_prompt_fulfillment.messages`
          #     * `Page.form.parameters.fill_behavior.reprompt_event_handlers.messages`
          #     * `Page.transition_routes.trigger_fulfillment.messages`
          #       *
          #       `Page.transition_route_groups.transition_routes.trigger_fulfillment.messages`
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
          class UpdatePageRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::Pages::DeletePage Pages::DeletePage}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. The name of the page to delete.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/Flows/<flow ID>/pages/<Page ID>`.
          # @!attribute [rw] force
          #   @return [true, false]
          #     This field has no effect for pages with no incoming transitions.
          #     For pages with incoming transitions:
          #
          #     * If `force` is set to false, an error will be returned with message
          #       indicating the incoming transitions.
          #     * If `force` is set to true, Dialogflow will remove the page, as well as
          #       any transitions to the page (i.e. [Target
          #       page][EventHandler.target_page] in event handlers or [Target
          #       page][TransitionRoute.target_page] in transition routes that point to
          #       this page will be cleared).
          class DeletePageRequest; end
        end
      end
    end
  end
end