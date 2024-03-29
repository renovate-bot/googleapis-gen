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
      module V8
        module Resources
          # CampaignSharedSets are used for managing the shared sets associated with a
          # campaign.
          # @!attribute [rw] resource_name
          #   @return [::String]
          #     Immutable. The resource name of the campaign shared set.
          #     Campaign shared set resource names have the form:
          #
          #     `customers/{customer_id}/campaignSharedSets/{campaign_id}~{shared_set_id}`
          # @!attribute [rw] campaign
          #   @return [::String]
          #     Immutable. The campaign to which the campaign shared set belongs.
          # @!attribute [rw] shared_set
          #   @return [::String]
          #     Immutable. The shared set associated with the campaign. This may be a negative keyword
          #     shared set of another customer. This customer should be a manager of the
          #     other customer, otherwise the campaign shared set will exist but have no
          #     serving effect. Only negative keyword shared sets can be associated with
          #     Shopping campaigns. Only negative placement shared sets can be associated
          #     with Display mobile app campaigns.
          # @!attribute [r] status
          #   @return [::Google::Ads::GoogleAds::V8::Enums::CampaignSharedSetStatusEnum::CampaignSharedSetStatus]
          #     Output only. The status of this campaign shared set. Read only.
          class CampaignSharedSet
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end
      end
    end
  end
end
