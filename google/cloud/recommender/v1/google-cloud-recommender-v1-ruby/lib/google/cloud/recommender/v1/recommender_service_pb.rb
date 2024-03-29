# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/recommender/v1/recommender_service.proto

require 'google/api/annotations_pb'
require 'google/api/client_pb'
require 'google/api/field_behavior_pb'
require 'google/api/resource_pb'
require 'google/cloud/recommender/v1/insight_pb'
require 'google/cloud/recommender/v1/recommendation_pb'
require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/cloud/recommender/v1/recommender_service.proto", :syntax => :proto3) do
    add_message "google.cloud.recommender.v1.ListInsightsRequest" do
      optional :parent, :string, 1
      optional :page_size, :int32, 2
      optional :page_token, :string, 3
      optional :filter, :string, 4
    end
    add_message "google.cloud.recommender.v1.ListInsightsResponse" do
      repeated :insights, :message, 1, "google.cloud.recommender.v1.Insight"
      optional :next_page_token, :string, 2
    end
    add_message "google.cloud.recommender.v1.GetInsightRequest" do
      optional :name, :string, 1
    end
    add_message "google.cloud.recommender.v1.MarkInsightAcceptedRequest" do
      optional :name, :string, 1
      map :state_metadata, :string, :string, 2
      optional :etag, :string, 3
    end
    add_message "google.cloud.recommender.v1.ListRecommendationsRequest" do
      optional :parent, :string, 1
      optional :page_size, :int32, 2
      optional :page_token, :string, 3
      optional :filter, :string, 5
    end
    add_message "google.cloud.recommender.v1.ListRecommendationsResponse" do
      repeated :recommendations, :message, 1, "google.cloud.recommender.v1.Recommendation"
      optional :next_page_token, :string, 2
    end
    add_message "google.cloud.recommender.v1.GetRecommendationRequest" do
      optional :name, :string, 1
    end
    add_message "google.cloud.recommender.v1.MarkRecommendationClaimedRequest" do
      optional :name, :string, 1
      map :state_metadata, :string, :string, 2
      optional :etag, :string, 3
    end
    add_message "google.cloud.recommender.v1.MarkRecommendationSucceededRequest" do
      optional :name, :string, 1
      map :state_metadata, :string, :string, 2
      optional :etag, :string, 3
    end
    add_message "google.cloud.recommender.v1.MarkRecommendationFailedRequest" do
      optional :name, :string, 1
      map :state_metadata, :string, :string, 2
      optional :etag, :string, 3
    end
  end
end

module Google
  module Cloud
    module Recommender
      module V1
        ListInsightsRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.recommender.v1.ListInsightsRequest").msgclass
        ListInsightsResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.recommender.v1.ListInsightsResponse").msgclass
        GetInsightRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.recommender.v1.GetInsightRequest").msgclass
        MarkInsightAcceptedRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.recommender.v1.MarkInsightAcceptedRequest").msgclass
        ListRecommendationsRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.recommender.v1.ListRecommendationsRequest").msgclass
        ListRecommendationsResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.recommender.v1.ListRecommendationsResponse").msgclass
        GetRecommendationRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.recommender.v1.GetRecommendationRequest").msgclass
        MarkRecommendationClaimedRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.recommender.v1.MarkRecommendationClaimedRequest").msgclass
        MarkRecommendationSucceededRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.recommender.v1.MarkRecommendationSucceededRequest").msgclass
        MarkRecommendationFailedRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.recommender.v1.MarkRecommendationFailedRequest").msgclass
      end
    end
  end
end
