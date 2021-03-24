# frozen_string_literal: true

# Copyright 2021 Google LLC
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
      module V6
        module Services
          module FeedItemTargetService
            # Path helper methods for the FeedItemTargetService API.
            module Paths
              ##
              # Create a fully-qualified AdGroup resource string.
              #
              # The resource will be in the following format:
              #
              # `customers/{customer_id}/adGroups/{ad_group_id}`
              #
              # @param customer_id [String]
              # @param ad_group_id [String]
              #
              # @return [::String]
              def ad_group_path customer_id:, ad_group_id:
                raise ::ArgumentError, "customer_id cannot contain /" if customer_id.to_s.include? "/"

                "customers/#{customer_id}/adGroups/#{ad_group_id}"
              end

              ##
              # Create a fully-qualified Campaign resource string.
              #
              # The resource will be in the following format:
              #
              # `customers/{customer_id}/campaigns/{campaign_id}`
              #
              # @param customer_id [String]
              # @param campaign_id [String]
              #
              # @return [::String]
              def campaign_path customer_id:, campaign_id:
                raise ::ArgumentError, "customer_id cannot contain /" if customer_id.to_s.include? "/"

                "customers/#{customer_id}/campaigns/#{campaign_id}"
              end

              ##
              # Create a fully-qualified FeedItem resource string.
              #
              # The resource will be in the following format:
              #
              # `customers/{customer_id}/feedItems/{feed_id}~{feed_item_id}`
              #
              # @param customer_id [String]
              # @param feed_id [String]
              # @param feed_item_id [String]
              #
              # @return [::String]
              def feed_item_path customer_id:, feed_id:, feed_item_id:
                raise ::ArgumentError, "customer_id cannot contain /" if customer_id.to_s.include? "/"
                raise ::ArgumentError, "feed_id cannot contain /" if feed_id.to_s.include? "/"

                "customers/#{customer_id}/feedItems/#{feed_id}~#{feed_item_id}"
              end

              ##
              # Create a fully-qualified FeedItemTarget resource string.
              #
              # The resource will be in the following format:
              #
              # `customers/{customer_id}/feedItemTargets/{feed_id}~{feed_item_id}~{feed_item_target_type}~{feed_item_target_id}`
              #
              # @param customer_id [String]
              # @param feed_id [String]
              # @param feed_item_id [String]
              # @param feed_item_target_type [String]
              # @param feed_item_target_id [String]
              #
              # @return [::String]
              def feed_item_target_path customer_id:, feed_id:, feed_item_id:, feed_item_target_type:, feed_item_target_id:
                raise ::ArgumentError, "customer_id cannot contain /" if customer_id.to_s.include? "/"
                raise ::ArgumentError, "feed_id cannot contain /" if feed_id.to_s.include? "/"
                raise ::ArgumentError, "feed_item_id cannot contain /" if feed_item_id.to_s.include? "/"
                raise ::ArgumentError,
                      "feed_item_target_type cannot contain /" if feed_item_target_type.to_s.include? "/"

                "customers/#{customer_id}/feedItemTargets/#{feed_id}~#{feed_item_id}~#{feed_item_target_type}~#{feed_item_target_id}"
              end

              ##
              # Create a fully-qualified GeoTargetConstant resource string.
              #
              # The resource will be in the following format:
              #
              # `geoTargetConstants/{criterion_id}`
              #
              # @param criterion_id [String]
              #
              # @return [::String]
              def geo_target_constant_path criterion_id:
                "geoTargetConstants/#{criterion_id}"
              end

              extend self
            end
          end
        end
      end
    end
  end
end
