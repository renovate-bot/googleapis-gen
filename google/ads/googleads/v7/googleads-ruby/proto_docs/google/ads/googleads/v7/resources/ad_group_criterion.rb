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
        module Resources
          # An ad group criterion.
          # @!attribute [rw] resource_name
          #   @return [::String]
          #     Immutable. The resource name of the ad group criterion.
          #     Ad group criterion resource names have the form:
          #
          #     `customers/{customer_id}/adGroupCriteria/{ad_group_id}~{criterion_id}`
          # @!attribute [r] criterion_id
          #   @return [::Integer]
          #     Output only. The ID of the criterion.
          #
          #     This field is ignored for mutates.
          # @!attribute [r] display_name
          #   @return [::String]
          #     Output only. The display name of the criterion.
          #
          #     This field is ignored for mutates.
          # @!attribute [rw] status
          #   @return [::Google::Ads::GoogleAds::V7::Enums::AdGroupCriterionStatusEnum::AdGroupCriterionStatus]
          #     The status of the criterion.
          #
          #     This is the status of the ad group criterion entity, set by the client.
          #     Note: UI reports may incorporate additional information that affects
          #     whether a criterion is eligible to run. In some cases a criterion that's
          #     REMOVED in the API can still show as enabled in the UI.
          #     For example, campaigns by default show to users of all age ranges unless
          #     excluded. The UI will show each age range as "enabled", since they're
          #     eligible to see the ads; but AdGroupCriterion.status will show "removed",
          #     since no positive criterion was added.
          # @!attribute [r] quality_info
          #   @return [::Google::Ads::GoogleAds::V7::Resources::AdGroupCriterion::QualityInfo]
          #     Output only. Information regarding the quality of the criterion.
          # @!attribute [rw] ad_group
          #   @return [::String]
          #     Immutable. The ad group to which the criterion belongs.
          # @!attribute [r] type
          #   @return [::Google::Ads::GoogleAds::V7::Enums::CriterionTypeEnum::CriterionType]
          #     Output only. The type of the criterion.
          # @!attribute [rw] negative
          #   @return [::Boolean]
          #     Immutable. Whether to target (`false`) or exclude (`true`) the criterion.
          #
          #     This field is immutable. To switch a criterion from positive to negative,
          #     remove then re-add it.
          # @!attribute [r] system_serving_status
          #   @return [::Google::Ads::GoogleAds::V7::Enums::CriterionSystemServingStatusEnum::CriterionSystemServingStatus]
          #     Output only. Serving status of the criterion.
          # @!attribute [r] approval_status
          #   @return [::Google::Ads::GoogleAds::V7::Enums::AdGroupCriterionApprovalStatusEnum::AdGroupCriterionApprovalStatus]
          #     Output only. Approval status of the criterion.
          # @!attribute [r] disapproval_reasons
          #   @return [::Array<::String>]
          #     Output only. List of disapproval reasons of the criterion.
          #
          #     The different reasons for disapproving a criterion can be found here:
          #     https://support.google.com/adspolicy/answer/6008942
          #
          #     This field is read-only.
          # @!attribute [r] labels
          #   @return [::Array<::String>]
          #     Output only. The resource names of labels attached to this ad group criterion.
          # @!attribute [rw] bid_modifier
          #   @return [::Float]
          #     The modifier for the bid when the criterion matches. The modifier must be
          #     in the range: 0.1 - 10.0. Most targetable criteria types support modifiers.
          # @!attribute [rw] cpc_bid_micros
          #   @return [::Integer]
          #     The CPC (cost-per-click) bid.
          # @!attribute [rw] cpm_bid_micros
          #   @return [::Integer]
          #     The CPM (cost-per-thousand viewable impressions) bid.
          # @!attribute [rw] cpv_bid_micros
          #   @return [::Integer]
          #     The CPV (cost-per-view) bid.
          # @!attribute [rw] percent_cpc_bid_micros
          #   @return [::Integer]
          #     The CPC bid amount, expressed as a fraction of the advertised price
          #     for some good or service. The valid range for the fraction is [0,1) and the
          #     value stored here is 1,000,000 * [fraction].
          # @!attribute [r] effective_cpc_bid_micros
          #   @return [::Integer]
          #     Output only. The effective CPC (cost-per-click) bid.
          # @!attribute [r] effective_cpm_bid_micros
          #   @return [::Integer]
          #     Output only. The effective CPM (cost-per-thousand viewable impressions) bid.
          # @!attribute [r] effective_cpv_bid_micros
          #   @return [::Integer]
          #     Output only. The effective CPV (cost-per-view) bid.
          # @!attribute [r] effective_percent_cpc_bid_micros
          #   @return [::Integer]
          #     Output only. The effective Percent CPC bid amount.
          # @!attribute [r] effective_cpc_bid_source
          #   @return [::Google::Ads::GoogleAds::V7::Enums::BiddingSourceEnum::BiddingSource]
          #     Output only. Source of the effective CPC bid.
          # @!attribute [r] effective_cpm_bid_source
          #   @return [::Google::Ads::GoogleAds::V7::Enums::BiddingSourceEnum::BiddingSource]
          #     Output only. Source of the effective CPM bid.
          # @!attribute [r] effective_cpv_bid_source
          #   @return [::Google::Ads::GoogleAds::V7::Enums::BiddingSourceEnum::BiddingSource]
          #     Output only. Source of the effective CPV bid.
          # @!attribute [r] effective_percent_cpc_bid_source
          #   @return [::Google::Ads::GoogleAds::V7::Enums::BiddingSourceEnum::BiddingSource]
          #     Output only. Source of the effective Percent CPC bid.
          # @!attribute [r] position_estimates
          #   @return [::Google::Ads::GoogleAds::V7::Resources::AdGroupCriterion::PositionEstimates]
          #     Output only. Estimates for criterion bids at various positions.
          # @!attribute [rw] final_urls
          #   @return [::Array<::String>]
          #     The list of possible final URLs after all cross-domain redirects for the
          #     ad.
          # @!attribute [rw] final_mobile_urls
          #   @return [::Array<::String>]
          #     The list of possible final mobile URLs after all cross-domain redirects.
          # @!attribute [rw] final_url_suffix
          #   @return [::String]
          #     URL template for appending params to final URL.
          # @!attribute [rw] tracking_url_template
          #   @return [::String]
          #     The URL template for constructing a tracking URL.
          # @!attribute [rw] url_custom_parameters
          #   @return [::Array<::Google::Ads::GoogleAds::V7::Common::CustomParameter>]
          #     The list of mappings used to substitute custom parameter tags in a
          #     `tracking_url_template`, `final_urls`, or `mobile_final_urls`.
          # @!attribute [rw] keyword
          #   @return [::Google::Ads::GoogleAds::V7::Common::KeywordInfo]
          #     Immutable. Keyword.
          # @!attribute [rw] placement
          #   @return [::Google::Ads::GoogleAds::V7::Common::PlacementInfo]
          #     Immutable. Placement.
          # @!attribute [rw] mobile_app_category
          #   @return [::Google::Ads::GoogleAds::V7::Common::MobileAppCategoryInfo]
          #     Immutable. Mobile app category.
          # @!attribute [rw] mobile_application
          #   @return [::Google::Ads::GoogleAds::V7::Common::MobileApplicationInfo]
          #     Immutable. Mobile application.
          # @!attribute [rw] listing_group
          #   @return [::Google::Ads::GoogleAds::V7::Common::ListingGroupInfo]
          #     Immutable. Listing group.
          # @!attribute [rw] age_range
          #   @return [::Google::Ads::GoogleAds::V7::Common::AgeRangeInfo]
          #     Immutable. Age range.
          # @!attribute [rw] gender
          #   @return [::Google::Ads::GoogleAds::V7::Common::GenderInfo]
          #     Immutable. Gender.
          # @!attribute [rw] income_range
          #   @return [::Google::Ads::GoogleAds::V7::Common::IncomeRangeInfo]
          #     Immutable. Income range.
          # @!attribute [rw] parental_status
          #   @return [::Google::Ads::GoogleAds::V7::Common::ParentalStatusInfo]
          #     Immutable. Parental status.
          # @!attribute [rw] user_list
          #   @return [::Google::Ads::GoogleAds::V7::Common::UserListInfo]
          #     Immutable. User List.
          # @!attribute [rw] youtube_video
          #   @return [::Google::Ads::GoogleAds::V7::Common::YouTubeVideoInfo]
          #     Immutable. YouTube Video.
          # @!attribute [rw] youtube_channel
          #   @return [::Google::Ads::GoogleAds::V7::Common::YouTubeChannelInfo]
          #     Immutable. YouTube Channel.
          # @!attribute [rw] topic
          #   @return [::Google::Ads::GoogleAds::V7::Common::TopicInfo]
          #     Immutable. Topic.
          # @!attribute [rw] user_interest
          #   @return [::Google::Ads::GoogleAds::V7::Common::UserInterestInfo]
          #     Immutable. User Interest.
          # @!attribute [rw] webpage
          #   @return [::Google::Ads::GoogleAds::V7::Common::WebpageInfo]
          #     Immutable. Webpage
          # @!attribute [rw] app_payment_model
          #   @return [::Google::Ads::GoogleAds::V7::Common::AppPaymentModelInfo]
          #     Immutable. App Payment Model.
          # @!attribute [rw] custom_affinity
          #   @return [::Google::Ads::GoogleAds::V7::Common::CustomAffinityInfo]
          #     Immutable. Custom Affinity.
          # @!attribute [rw] custom_intent
          #   @return [::Google::Ads::GoogleAds::V7::Common::CustomIntentInfo]
          #     Immutable. Custom Intent.
          # @!attribute [rw] custom_audience
          #   @return [::Google::Ads::GoogleAds::V7::Common::CustomAudienceInfo]
          #     Immutable. Custom Audience.
          # @!attribute [rw] combined_audience
          #   @return [::Google::Ads::GoogleAds::V7::Common::CombinedAudienceInfo]
          #     Immutable. Combined Audience.
          class AdGroupCriterion
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods

            # A container for ad group criterion quality information.
            # @!attribute [r] quality_score
            #   @return [::Integer]
            #     Output only. The quality score.
            #
            #     This field may not be populated if Google does not have enough
            #     information to determine a value.
            # @!attribute [r] creative_quality_score
            #   @return [::Google::Ads::GoogleAds::V7::Enums::QualityScoreBucketEnum::QualityScoreBucket]
            #     Output only. The performance of the ad compared to other advertisers.
            # @!attribute [r] post_click_quality_score
            #   @return [::Google::Ads::GoogleAds::V7::Enums::QualityScoreBucketEnum::QualityScoreBucket]
            #     Output only. The quality score of the landing page.
            # @!attribute [r] search_predicted_ctr
            #   @return [::Google::Ads::GoogleAds::V7::Enums::QualityScoreBucketEnum::QualityScoreBucket]
            #     Output only. The click-through rate compared to that of other advertisers.
            class QualityInfo
              include ::Google::Protobuf::MessageExts
              extend ::Google::Protobuf::MessageExts::ClassMethods
            end

            # Estimates for criterion bids at various positions.
            # @!attribute [r] first_page_cpc_micros
            #   @return [::Integer]
            #     Output only. The estimate of the CPC bid required for ad to be shown on first
            #     page of search results.
            # @!attribute [r] first_position_cpc_micros
            #   @return [::Integer]
            #     Output only. The estimate of the CPC bid required for ad to be displayed in first
            #     position, at the top of the first page of search results.
            # @!attribute [r] top_of_page_cpc_micros
            #   @return [::Integer]
            #     Output only. The estimate of the CPC bid required for ad to be displayed at the top
            #     of the first page of search results.
            # @!attribute [r] estimated_add_clicks_at_first_position_cpc
            #   @return [::Integer]
            #     Output only. Estimate of how many clicks per week you might get by changing your
            #     keyword bid to the value in first_position_cpc_micros.
            # @!attribute [r] estimated_add_cost_at_first_position_cpc
            #   @return [::Integer]
            #     Output only. Estimate of how your cost per week might change when changing your
            #     keyword bid to the value in first_position_cpc_micros.
            class PositionEstimates
              include ::Google::Protobuf::MessageExts
              extend ::Google::Protobuf::MessageExts::ClassMethods
            end
          end
        end
      end
    end
  end
end
