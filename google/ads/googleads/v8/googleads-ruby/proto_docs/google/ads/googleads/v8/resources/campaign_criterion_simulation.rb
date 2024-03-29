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
          # A campaign criterion simulation. Supported combinations of advertising
          # channel type, criterion ids, simulation type and simulation modification
          # method is detailed below respectively.
          #
          # 1. SEARCH - 30000,30001,30002 - BID_MODIFIER - UNIFORM
          # 2. DISPLAY - 30001 - BID_MODIFIER - UNIFORM
          # @!attribute [r] resource_name
          #   @return [::String]
          #     Output only. The resource name of the campaign criterion simulation.
          #     Campaign criterion simulation resource names have the form:
          #
          #     `customers/{customer_id}/campaignCriterionSimulations/{campaign_id}~{criterion_id}~{type}~{modification_method}~{start_date}~{end_date}`
          # @!attribute [r] campaign_id
          #   @return [::Integer]
          #     Output only. Campaign ID of the simulation.
          # @!attribute [r] criterion_id
          #   @return [::Integer]
          #     Output only. Criterion ID of the simulation.
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
          #     Output only. Last day on which the simulation is based, in YYYY-MM-DD format.
          # @!attribute [r] bid_modifier_point_list
          #   @return [::Google::Ads::GoogleAds::V8::Common::BidModifierSimulationPointList]
          #     Output only. Simulation points if the simulation type is BID_MODIFIER.
          class CampaignCriterionSimulation
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end
      end
    end
  end
end
