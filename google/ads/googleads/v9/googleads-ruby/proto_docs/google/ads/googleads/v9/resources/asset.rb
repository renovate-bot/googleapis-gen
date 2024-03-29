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
          # Asset is a part of an ad which can be shared across multiple ads.
          # It can be an image (ImageAsset), a video (YoutubeVideoAsset), etc.
          # Assets are immutable and cannot be removed. To stop an asset from serving,
          # remove the asset from the entity that is using it.
          # @!attribute [rw] resource_name
          #   @return [::String]
          #     Immutable. The resource name of the asset.
          #     Asset resource names have the form:
          #
          #     `customers/{customer_id}/assets/{asset_id}`
          # @!attribute [r] id
          #   @return [::Integer]
          #     Output only. The ID of the asset.
          # @!attribute [rw] name
          #   @return [::String]
          #     Optional name of the asset.
          # @!attribute [r] type
          #   @return [::Google::Ads::GoogleAds::V9::Enums::AssetTypeEnum::AssetType]
          #     Output only. Type of the asset.
          # @!attribute [rw] final_urls
          #   @return [::Array<::String>]
          #     A list of possible final URLs after all cross domain redirects.
          # @!attribute [rw] final_mobile_urls
          #   @return [::Array<::String>]
          #     A list of possible final mobile URLs after all cross domain redirects.
          # @!attribute [rw] tracking_url_template
          #   @return [::String]
          #     URL template for constructing a tracking URL.
          # @!attribute [rw] url_custom_parameters
          #   @return [::Array<::Google::Ads::GoogleAds::V9::Common::CustomParameter>]
          #     A list of mappings to be used for substituting URL custom parameter tags in
          #     the tracking_url_template, final_urls, and/or final_mobile_urls.
          # @!attribute [rw] final_url_suffix
          #   @return [::String]
          #     URL template for appending params to landing page URLs served with parallel
          #     tracking.
          # @!attribute [r] policy_summary
          #   @return [::Google::Ads::GoogleAds::V9::Resources::AssetPolicySummary]
          #     Output only. Policy information for the asset.
          # @!attribute [rw] youtube_video_asset
          #   @return [::Google::Ads::GoogleAds::V9::Common::YoutubeVideoAsset]
          #     Immutable. A YouTube video asset.
          # @!attribute [rw] media_bundle_asset
          #   @return [::Google::Ads::GoogleAds::V9::Common::MediaBundleAsset]
          #     Immutable. A media bundle asset.
          # @!attribute [r] image_asset
          #   @return [::Google::Ads::GoogleAds::V9::Common::ImageAsset]
          #     Output only. An image asset.
          # @!attribute [rw] text_asset
          #   @return [::Google::Ads::GoogleAds::V9::Common::TextAsset]
          #     Immutable. A text asset.
          # @!attribute [rw] lead_form_asset
          #   @return [::Google::Ads::GoogleAds::V9::Common::LeadFormAsset]
          #     A lead form asset.
          # @!attribute [rw] book_on_google_asset
          #   @return [::Google::Ads::GoogleAds::V9::Common::BookOnGoogleAsset]
          #     A book on google asset.
          # @!attribute [rw] promotion_asset
          #   @return [::Google::Ads::GoogleAds::V9::Common::PromotionAsset]
          #     A promotion asset.
          # @!attribute [rw] callout_asset
          #   @return [::Google::Ads::GoogleAds::V9::Common::CalloutAsset]
          #     A callout asset.
          # @!attribute [rw] structured_snippet_asset
          #   @return [::Google::Ads::GoogleAds::V9::Common::StructuredSnippetAsset]
          #     A structured snippet asset.
          # @!attribute [rw] sitelink_asset
          #   @return [::Google::Ads::GoogleAds::V9::Common::SitelinkAsset]
          #     A sitelink asset.
          # @!attribute [rw] page_feed_asset
          #   @return [::Google::Ads::GoogleAds::V9::Common::PageFeedAsset]
          #     A page feed asset.
          # @!attribute [rw] dynamic_education_asset
          #   @return [::Google::Ads::GoogleAds::V9::Common::DynamicEducationAsset]
          #     A dynamic education asset.
          # @!attribute [rw] mobile_app_asset
          #   @return [::Google::Ads::GoogleAds::V9::Common::MobileAppAsset]
          #     A mobile app asset.
          # @!attribute [rw] hotel_callout_asset
          #   @return [::Google::Ads::GoogleAds::V9::Common::HotelCalloutAsset]
          #     A hotel callout asset.
          # @!attribute [rw] call_asset
          #   @return [::Google::Ads::GoogleAds::V9::Common::CallAsset]
          #     A call asset.
          # @!attribute [rw] price_asset
          #   @return [::Google::Ads::GoogleAds::V9::Common::PriceAsset]
          #     A price asset.
          # @!attribute [rw] call_to_action_asset
          #   @return [::Google::Ads::GoogleAds::V9::Common::CallToActionAsset]
          #     Immutable. A call to action asset.
          class Asset
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Contains policy information for an asset.
          # @!attribute [r] policy_topic_entries
          #   @return [::Array<::Google::Ads::GoogleAds::V9::Common::PolicyTopicEntry>]
          #     Output only. The list of policy findings for this asset.
          # @!attribute [r] review_status
          #   @return [::Google::Ads::GoogleAds::V9::Enums::PolicyReviewStatusEnum::PolicyReviewStatus]
          #     Output only. Where in the review process this asset is.
          # @!attribute [r] approval_status
          #   @return [::Google::Ads::GoogleAds::V9::Enums::PolicyApprovalStatusEnum::PolicyApprovalStatus]
          #     Output only. The overall approval status of this asset, calculated based on the status
          #     of its individual policy topic entries.
          class AssetPolicySummary
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end
      end
    end
  end
end
