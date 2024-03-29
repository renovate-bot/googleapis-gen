# frozen_string_literal: true

# Copyright 2022 Google LLC
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

# Auto-generated by gapic-generator-ruby. DO NOT EDIT!


module Google
  module Cloud
    module Channel
      module V1
        # Entity representing a link between distributors and their indirect
        # resellers in an n-tier resale channel.
        # @!attribute [r] name
        #   @return [::String]
        #     Output only. Resource name for the channel partner link, in the format
        #     accounts/\\{account_id}/channelPartnerLinks/\\{id}.
        # @!attribute [rw] reseller_cloud_identity_id
        #   @return [::String]
        #     Required. Cloud Identity ID of the linked reseller.
        # @!attribute [rw] link_state
        #   @return [::Google::Cloud::Channel::V1::ChannelPartnerLinkState]
        #     Required. State of the channel partner link.
        # @!attribute [r] invite_link_uri
        #   @return [::String]
        #     Output only. URI of the web page where partner accepts the link invitation.
        # @!attribute [r] create_time
        #   @return [::Google::Protobuf::Timestamp]
        #     Output only. Timestamp of when the channel partner link is created.
        # @!attribute [r] update_time
        #   @return [::Google::Protobuf::Timestamp]
        #     Output only. Timestamp of when the channel partner link is updated.
        # @!attribute [r] public_id
        #   @return [::String]
        #     Output only. Public identifier that a customer must use to generate a transfer token
        #     to move to this distributor-reseller combination.
        # @!attribute [r] channel_partner_cloud_identity_info
        #   @return [::Google::Cloud::Channel::V1::CloudIdentityInfo]
        #     Output only. Cloud Identity info of the channel partner (IR).
        class ChannelPartnerLink
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The level of granularity the {::Google::Cloud::Channel::V1::ChannelPartnerLink ChannelPartnerLink} will display.
        module ChannelPartnerLinkView
          # The default / unset value.
          # The API will default to the BASIC view.
          UNSPECIFIED = 0

          # Includes all fields except the
          # {::Google::Cloud::Channel::V1::ChannelPartnerLink#channel_partner_cloud_identity_info ChannelPartnerLink.channel_partner_cloud_identity_info}.
          BASIC = 1

          # Includes all fields.
          FULL = 2
        end

        # ChannelPartnerLinkState represents state of a channel partner link.
        module ChannelPartnerLinkState
          # The state is not specified.
          CHANNEL_PARTNER_LINK_STATE_UNSPECIFIED = 0

          # An invitation has been sent to the reseller to create a channel partner
          # link.
          INVITED = 1

          # Status when the reseller is active.
          ACTIVE = 2

          # Status when the reseller has been revoked by the distributor.
          REVOKED = 3

          # Status when the reseller is suspended by Google or distributor.
          SUSPENDED = 4
        end
      end
    end
  end
end
