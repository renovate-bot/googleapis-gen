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
          # Represents a bidding seasonality adjustment.
          #
          # See "About seasonality adjustments" at
          # https://support.google.com/google-ads/answer/10369906.
          # @!attribute [rw] resource_name
          #   @return [::String]
          #     Immutable. The resource name of the seasonality adjustment.
          #     Seasonality adjustment resource names have the form:
          #
          #     `customers/{customer_id}/biddingSeasonalityAdjustments/{seasonality_adjustment_id}`
          # @!attribute [r] seasonality_adjustment_id
          #   @return [::Integer]
          #     Output only. The ID of the seasonality adjustment.
          # @!attribute [rw] scope
          #   @return [::Google::Ads::GoogleAds::V9::Enums::SeasonalityEventScopeEnum::SeasonalityEventScope]
          #     The scope of the seasonality adjustment.
          # @!attribute [r] status
          #   @return [::Google::Ads::GoogleAds::V9::Enums::SeasonalityEventStatusEnum::SeasonalityEventStatus]
          #     Output only. The status of the seasonality adjustment.
          # @!attribute [rw] start_date_time
          #   @return [::String]
          #     Required. The inclusive start time of the seasonality adjustment in yyyy-MM-dd
          #     HH:mm:ss format.
          #
          #     A seasonality adjustment is forward looking and should be used for events
          #     that start and end in the future.
          # @!attribute [rw] end_date_time
          #   @return [::String]
          #     Required. The exclusive end time of the seasonality adjustment in yyyy-MM-dd HH:mm:ss
          #     format.
          #
          #     The length of [start_date_time, end_date_time) interval must be
          #     within (0, 14 days].
          # @!attribute [rw] name
          #   @return [::String]
          #     The name of the seasonality adjustment. The name can be at most 255
          #     characters.
          # @!attribute [rw] description
          #   @return [::String]
          #     The description of the seasonality adjustment. The description can be at
          #     most 2048 characters.
          # @!attribute [rw] devices
          #   @return [::Array<::Google::Ads::GoogleAds::V9::Enums::DeviceEnum::Device>]
          #     If not specified, all devices will be included in this adjustment.
          #     Otherwise, only the specified targeted devices will be included in this
          #     adjustment.
          # @!attribute [rw] conversion_rate_modifier
          #   @return [::Float]
          #     Conversion rate modifier estimated based on expected conversion rate
          #     changes. When this field is unset or set to 1.0 no adjustment will be
          #     applied to traffic. The allowed range is 0.1 to 10.0.
          # @!attribute [rw] campaigns
          #   @return [::Array<::String>]
          #     The seasonality adjustment will apply to the campaigns listed when the
          #     scope of this adjustment is CAMPAIGN. The maximum number of campaigns per
          #     event is 2000.
          #     Note: a seasonality adjustment with both advertising_channel_types and
          #     campaign_ids is not supported.
          # @!attribute [rw] advertising_channel_types
          #   @return [::Array<::Google::Ads::GoogleAds::V9::Enums::AdvertisingChannelTypeEnum::AdvertisingChannelType>]
          #     The seasonality adjustment will apply to all the campaigns under the listed
          #     channels retroactively as well as going forward when the scope of this
          #     adjustment is CHANNEL.
          #     The supported advertising channel types are DISPLAY, SEARCH and SHOPPING.
          #     Note: a seasonality adjustment with both advertising_channel_types and
          #     campaign_ids is not supported.
          class BiddingSeasonalityAdjustment
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end
      end
    end
  end
end
