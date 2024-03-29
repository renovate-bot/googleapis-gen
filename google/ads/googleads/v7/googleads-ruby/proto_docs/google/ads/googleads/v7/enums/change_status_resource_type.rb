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
  module Ads
    module GoogleAds
      module V7
        module Enums
          # Container for enum describing supported resource types for the ChangeStatus
          # resource.
          class ChangeStatusResourceTypeEnum
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods

            # Enum listing the resource types support by the ChangeStatus resource.
            module ChangeStatusResourceType
              # No value has been specified.
              UNSPECIFIED = 0

              # Used for return value only. Represents an unclassified resource unknown
              # in this version.
              UNKNOWN = 1

              # An AdGroup resource change.
              AD_GROUP = 3

              # An AdGroupAd resource change.
              AD_GROUP_AD = 4

              # An AdGroupCriterion resource change.
              AD_GROUP_CRITERION = 5

              # A Campaign resource change.
              CAMPAIGN = 6

              # A CampaignCriterion resource change.
              CAMPAIGN_CRITERION = 7

              # A Feed resource change.
              FEED = 9

              # A FeedItem resource change.
              FEED_ITEM = 10

              # An AdGroupFeed resource change.
              AD_GROUP_FEED = 11

              # A CampaignFeed resource change.
              CAMPAIGN_FEED = 12

              # An AdGroupBidModifier resource change.
              AD_GROUP_BID_MODIFIER = 13
            end
          end
        end
      end
    end
  end
end
