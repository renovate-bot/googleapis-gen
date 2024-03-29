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
          # Request message for
          # {::Google::Ads::GoogleAds::V9::Services::CampaignCustomizerService::Client#mutate_campaign_customizers CampaignCustomizerService.MutateCampaignCustomizers}.
          # @!attribute [rw] customer_id
          #   @return [::String]
          #     Required. The ID of the customer whose campaign customizers are being modified.
          # @!attribute [rw] operations
          #   @return [::Array<::Google::Ads::GoogleAds::V9::Services::CampaignCustomizerOperation>]
          #     Required. The list of operations to perform on individual campaign customizers.
          # @!attribute [rw] partial_failure
          #   @return [::Boolean]
          #     If true, successful operations will be carried out and invalid
          #     operations will return errors. If false, all operations will be carried
          #     out in one transaction if and only if they are all valid.
          #     Default is false.
          # @!attribute [rw] validate_only
          #   @return [::Boolean]
          #     If true, the request is validated but not executed. Only errors are
          #     returned, not results.
          # @!attribute [rw] response_content_type
          #   @return [::Google::Ads::GoogleAds::V9::Enums::ResponseContentTypeEnum::ResponseContentType]
          #     The response content type setting. Determines whether the mutable resource
          #     or just the resource name should be returned post mutation.
          class MutateCampaignCustomizersRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # A single operation (create, remove) on an customizer attribute.
          # @!attribute [rw] create
          #   @return [::Google::Ads::GoogleAds::V9::Resources::CampaignCustomizer]
          #     Create operation: No resource name is expected for the new campaign
          #     customizer
          # @!attribute [rw] remove
          #   @return [::String]
          #     Remove operation: A resource name for the removed campaign customizer is
          #     expected, in this format:
          #     `customers/{customer_id}/campaignCustomizers/{campaign_id}~{customizer_attribute_id}`
          class CampaignCustomizerOperation
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Response message for an campaign customizer mutate.
          # @!attribute [rw] results
          #   @return [::Array<::Google::Ads::GoogleAds::V9::Services::MutateCampaignCustomizerResult>]
          #     All results for the mutate.
          # @!attribute [rw] partial_failure_error
          #   @return [::Google::Rpc::Status]
          #     Errors that pertain to operation failures in the partial failure mode.
          #     Returned only when partial_failure = true and all errors occur inside the
          #     operations. If any errors occur outside the operations (e.g. auth errors),
          #     we return an RPC level error.
          class MutateCampaignCustomizersResponse
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # The result for the campaign customizer mutate.
          # @!attribute [rw] resource_name
          #   @return [::String]
          #     Returned for successful operations.
          # @!attribute [rw] campaign_customizer
          #   @return [::Google::Ads::GoogleAds::V9::Resources::CampaignCustomizer]
          #     The mutated CampaignCustomizer with only mutable fields after mutate.
          #     The field will only be returned when response_content_type is set to
          #     "MUTABLE_RESOURCE".
          class MutateCampaignCustomizerResult
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end
      end
    end
  end
end
