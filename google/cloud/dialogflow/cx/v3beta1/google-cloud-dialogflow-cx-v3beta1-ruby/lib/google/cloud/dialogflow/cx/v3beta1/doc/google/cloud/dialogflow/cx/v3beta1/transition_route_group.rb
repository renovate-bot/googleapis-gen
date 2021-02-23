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
          # An TransitionRouteGroup represents a group of
          # {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRoute `TransitionRoutes`} to be used by a {Google::Cloud::Dialogflow::Cx::V3beta1::Page Page}.
          # @!attribute [rw] name
          #   @return [String]
          #     The unique identifier of the transition route group.
          #     {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroups::CreateTransitionRouteGroup TransitionRouteGroups::CreateTransitionRouteGroup} populates the name
          #     automatically.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/flows/<Flow ID>/transitionRouteGroups/<Transition Route Group ID>`.
          # @!attribute [rw] display_name
          #   @return [String]
          #     Required. The human-readable name of the transition route group, unique within
          #     the {Google::Cloud::Dialogflow::Cx::V3beta1::Agent Agent}. The display name can be no longer than 30 characters.
          # @!attribute [rw] transition_routes
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRoute>]
          #     Transition routes associated with the {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup TransitionRouteGroup}.
          class TransitionRouteGroup; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroups::ListTransitionRouteGroups TransitionRouteGroups::ListTransitionRouteGroups}.
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. The flow to list all transition route groups for.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/flows/<Flow ID>`.
          # @!attribute [rw] page_size
          #   @return [Integer]
          #     The maximum number of items to return in a single page. By default 100 and
          #     at most 1000.
          # @!attribute [rw] page_token
          #   @return [String]
          #     The next_page_token value returned from a previous list request.
          # @!attribute [rw] language_code
          #   @return [String]
          #     The language to list transition route groups for. The field
          #     {TransitionRoute#trigger_fulfillment#messages `messages`} in
          #     {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRoute TransitionRoute} is language dependent.
          #
          #     If not specified, the agent's default language is used.
          #     [Many
          #     languages](https://cloud.google.com/dialogflow/cx/docs/reference/language)
          #     are supported.
          #     Note: languages must be enabled in the agent before they can be used.
          class ListTransitionRouteGroupsRequest; end

          # The response message for {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroups::ListTransitionRouteGroups TransitionRouteGroups::ListTransitionRouteGroups}.
          # @!attribute [rw] transition_route_groups
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup>]
          #     The list of transition route groups. There will be a maximum number of
          #     items returned based on the page_size field in the request. The list may in
          #     some cases be empty or contain fewer entries than page_size even if this
          #     isn't the last page.
          # @!attribute [rw] next_page_token
          #   @return [String]
          #     Token to retrieve the next page of results, or empty if there are no more
          #     results in the list.
          class ListTransitionRouteGroupsResponse; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroups::GetTransitionRouteGroup TransitionRouteGroups::GetTransitionRouteGroup}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. The name of the {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup TransitionRouteGroup}.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/flows/<Flow ID>/transitionRouteGroups/<Transition Route Group ID>`.
          # @!attribute [rw] language_code
          #   @return [String]
          #     The language to list transition route groups for. The field
          #     {TransitionRoute#trigger_fulfillment#messages `messages`} in
          #     {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRoute TransitionRoute} is language dependent.
          #
          #     If not specified, the agent's default language is used.
          #     [Many
          #     languages](https://cloud.google.com/dialogflow/cx/docs/reference/language)
          #     are supported.
          #     Note: languages must be enabled in the agent before they can be used.
          class GetTransitionRouteGroupRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroups::CreateTransitionRouteGroup TransitionRouteGroups::CreateTransitionRouteGroup}.
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. The flow to create an {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup TransitionRouteGroup} for.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/flows/<Flow ID>`.
          # @!attribute [rw] transition_route_group
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup]
          #     Required. The transition route group to create.
          # @!attribute [rw] language_code
          #   @return [String]
          #     The language to list transition route groups for. The field
          #     {TransitionRoute#trigger_fulfillment#messages `messages`} in
          #     {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRoute TransitionRoute} is language dependent.
          #
          #     If not specified, the agent's default language is used.
          #     [Many
          #     languages](https://cloud.google.com/dialogflow/cx/docs/reference/language)
          #     are supported.
          #     Note: languages must be enabled in the agent before they can be used.
          class CreateTransitionRouteGroupRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroups::UpdateTransitionRouteGroup TransitionRouteGroups::UpdateTransitionRouteGroup}.
          # @!attribute [rw] transition_route_group
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup]
          #     Required. The transition route group to update.
          # @!attribute [rw] update_mask
          #   @return [Google::Protobuf::FieldMask]
          #     The mask to control which fields get updated.
          # @!attribute [rw] language_code
          #   @return [String]
          #     The language to list transition route groups for. The field
          #     {TransitionRoute#trigger_fulfillment#messages `messages`} in
          #     {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRoute TransitionRoute} is language dependent.
          #
          #     If not specified, the agent's default language is used.
          #     [Many
          #     languages](https://cloud.google.com/dialogflow/cx/docs/reference/language)
          #     are supported.
          #     Note: languages must be enabled in the agent before they can be used.
          class UpdateTransitionRouteGroupRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroups::DeleteTransitionRouteGroup TransitionRouteGroups::DeleteTransitionRouteGroup}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. The name of the {Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRouteGroup TransitionRouteGroup} to delete.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/flows/<Flow ID>/transitionRouteGroups/<Transition Route Group ID>`.
          # @!attribute [rw] force
          #   @return [true, false]
          #     This field has no effect for transition route group that no page is using.
          #     If the transition route group is referenced by any page:
          #
          #     * If `force` is set to false, an error will be returned with message
          #       indicating pages that reference the transition route group.
          #     * If `force` is set to true, Dialogflow will remove the transition route
          #       group, as well as any reference to it.
          class DeleteTransitionRouteGroupRequest; end
        end
      end
    end
  end
end