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
        module Services
          # Request message for {::Google::Ads::GoogleAds::V9::Services::CustomAudienceService::Client#get_custom_audience CustomAudienceService.GetCustomAudience}.
          # @!attribute [rw] resource_name
          #   @return [::String]
          #     Required. The resource name of the custom audience to fetch.
          class GetCustomAudienceRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Request message for {::Google::Ads::GoogleAds::V9::Services::CustomAudienceService::Client#mutate_custom_audiences CustomAudienceService.MutateCustomAudiences}.
          # @!attribute [rw] customer_id
          #   @return [::String]
          #     Required. The ID of the customer whose custom audiences are being modified.
          # @!attribute [rw] operations
          #   @return [::Array<::Google::Ads::GoogleAds::V9::Services::CustomAudienceOperation>]
          #     Required. The list of operations to perform on individual custom audiences.
          # @!attribute [rw] validate_only
          #   @return [::Boolean]
          #     If true, the request is validated but not executed. Only errors are
          #     returned, not results.
          class MutateCustomAudiencesRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # A single operation (create, update) on a custom audience.
          # @!attribute [rw] update_mask
          #   @return [::Google::Protobuf::FieldMask]
          #     FieldMask that determines which resource fields are modified in an update.
          # @!attribute [rw] create
          #   @return [::Google::Ads::GoogleAds::V9::Resources::CustomAudience]
          #     Create operation: No resource name is expected for the new custom
          #     audience.
          # @!attribute [rw] update
          #   @return [::Google::Ads::GoogleAds::V9::Resources::CustomAudience]
          #     Update operation: The custom audience is expected to have a valid
          #     resource name.
          # @!attribute [rw] remove
          #   @return [::String]
          #     Remove operation: A resource name for the removed custom audience is
          #     expected, in this format:
          #
          #     `customers/{customer_id}/customAudiences/{custom_audience_id}`
          class CustomAudienceOperation
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Response message for custom audience mutate.
          # @!attribute [rw] results
          #   @return [::Array<::Google::Ads::GoogleAds::V9::Services::MutateCustomAudienceResult>]
          #     All results for the mutate.
          class MutateCustomAudiencesResponse
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # The result for the custom audience mutate.
          # @!attribute [rw] resource_name
          #   @return [::String]
          #     Returned for successful operations.
          class MutateCustomAudienceResult
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end
      end
    end
  end
end
