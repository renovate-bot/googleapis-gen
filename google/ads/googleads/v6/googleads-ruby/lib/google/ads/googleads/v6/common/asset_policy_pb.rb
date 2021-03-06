# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v6/common/asset_policy.proto

require 'google/protobuf'

require 'google/ads/googleads/v6/common/policy_pb'
require 'google/ads/googleads/v6/enums/policy_approval_status_pb'
require 'google/ads/googleads/v6/enums/policy_review_status_pb'
require 'google/api/annotations_pb'
Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/ads/googleads/v6/common/asset_policy.proto", :syntax => :proto3) do
    add_message "google.ads.googleads.v6.common.AdAssetPolicySummary" do
      repeated :policy_topic_entries, :message, 1, "google.ads.googleads.v6.common.PolicyTopicEntry"
      optional :review_status, :enum, 2, "google.ads.googleads.v6.enums.PolicyReviewStatusEnum.PolicyReviewStatus"
      optional :approval_status, :enum, 3, "google.ads.googleads.v6.enums.PolicyApprovalStatusEnum.PolicyApprovalStatus"
    end
  end
end

module Google
  module Ads
    module GoogleAds
      module V6
        module Common
          AdAssetPolicySummary = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.ads.googleads.v6.common.AdAssetPolicySummary").msgclass
        end
      end
    end
  end
end
