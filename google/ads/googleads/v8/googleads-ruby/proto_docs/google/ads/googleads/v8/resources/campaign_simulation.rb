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
          # A campaign simulation. Supported combinations of advertising
          # channel type, simulation type and simulation modification
          # method is detailed below respectively.
          #
          # SEARCH - CPC_BID - UNIFORM
          # SEARCH - CPC_BID - SCALING
          # SEARCH - TARGET_CPA - UNIFORM
          # SEARCH - TARGET_CPA - SCALING
          # SEARCH - TARGET_ROAS - UNIFORM
          # SEARCH - TARGET_IMPRESSION_SHARE - UNIFORM
          # SEARCH - BUDGET - UNIFORM
          # SHOPPING - BUDGET - UNIFORM
          # SHOPPING - TARGET_ROAS - UNIFORM
          # MULTIPLE - TARGET_CPA - UNIFORM
          # OWNED_AND_OPERATED - TARGET_CPA - DEFAULT
          # DISPLAY - TARGET_CPA - UNIFORM
          # @!attribute [r] resource_name
          #   @return [::String]
          #     Output only. The resource name of the campaign simulation.
          #     Campaign simulation resource names have the form:
          #
          #     `customers/{customer_id}/campaignSimulations/{campaign_id}~{type}~{modification_method}~{start_date}~{end_date}`
          # @!attribute [r] campaign_id
          #   @return [::Integer]
          #     Output only. Campaign id of the simulation.
          # @!attribute [r] type
          #   @return [::Google::Ads::GoogleAds::V8::Enums::SimulationTypeEnum::SimulationType]
          #     Output only. The field that the simulation modifies.
          # @!attribute [r] modification_method
          #   @return [::Google::Ads::GoogleAds::V8::Enums::SimulationModificationMethodEnum::SimulationModificationMethod]
          #     Output only. How the simulation modifies the field.
          # @!attribute [r] start_date
          #   @return [::String]
          #     Output only. First day on which the simulation is based, in YYYY-MM-DD format.
          # @!attribute [r] end_date
          #   @return [::String]
          #     Output only. Last day on which the simulation is based, in YYYY-MM-DD format
          # @!attribute [r] cpc_bid_point_list
          #   @return [::Google::Ads::GoogleAds::V8::Common::CpcBidSimulationPointList]
          #     Output only. Simulation points if the simulation type is CPC_BID.
          # @!attribute [r] target_cpa_point_list
          #   @return [::Google::Ads::GoogleAds::V8::Common::TargetCpaSimulationPointList]
          #     Output only. Simulation points if the simulation type is TARGET_CPA.
          # @!attribute [r] target_roas_point_list
          #   @return [::Google::Ads::GoogleAds::V8::Common::TargetRoasSimulationPointList]
          #     Output only. Simulation points if the simulation type is TARGET_ROAS.
          # @!attribute [r] target_impression_share_point_list
          #   @return [::Google::Ads::GoogleAds::V8::Common::TargetImpressionShareSimulationPointList]
          #     Output only. Simulation points if the simulation type is TARGET_IMPRESSION_SHARE.
          # @!attribute [r] budget_point_list
          #   @return [::Google::Ads::GoogleAds::V8::Common::BudgetSimulationPointList]
          #     Output only. Simulation points if the simulation type is BUDGET.
          class CampaignSimulation
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end
      end
    end
  end
end
