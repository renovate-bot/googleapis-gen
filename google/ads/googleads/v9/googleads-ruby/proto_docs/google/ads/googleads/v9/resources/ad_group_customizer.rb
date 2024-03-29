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
      module V9
        module Resources
          # A customizer value for the associated CustomizerAttribute at the AdGroup
          # level.
          # @!attribute [rw] resource_name
          #   @return [::String]
          #     Immutable. The resource name of the ad group customizer.
          #     Ad group customizer resource names have the form:
          #
          #     `customers/{customer_id}/adGroupCustomizers/{ad_group_id}~{customizer_attribute_id}`
          # @!attribute [rw] ad_group
          #   @return [::String]
          #     Immutable. The ad group to which the customizer attribute is linked.
          # @!attribute [rw] customizer_attribute
          #   @return [::String]
          #     Required. Immutable. The customizer attribute which is linked to the ad group.
          # @!attribute [r] status
          #   @return [::Google::Ads::GoogleAds::V9::Enums::CustomizerValueStatusEnum::CustomizerValueStatus]
          #     Output only. The status of the ad group customizer.
          # @!attribute [rw] value
          #   @return [::Google::Ads::GoogleAds::V9::Common::CustomizerValue]
          #     Required. The value to associate with the customizer attribute at this level. The
          #     value must be of the type specified for the CustomizerAttribute.
          class AdGroupCustomizer
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end
      end
    end
  end
end
