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
          # {::Google::Ads::GoogleAds::V9::Services::CustomerUserAccessService::Client#get_customer_user_access CustomerUserAccessService.GetCustomerUserAccess}.
          # @!attribute [rw] resource_name
          #   @return [::String]
          #     Required. Resource name of the customer user access.
          class GetCustomerUserAccessRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Mutate Request for
          # {::Google::Ads::GoogleAds::V9::Services::CustomerUserAccessService::Client#mutate_customer_user_access CustomerUserAccessService.MutateCustomerUserAccess}.
          # @!attribute [rw] customer_id
          #   @return [::String]
          #     Required. The ID of the customer being modified.
          # @!attribute [rw] operation
          #   @return [::Google::Ads::GoogleAds::V9::Services::CustomerUserAccessOperation]
          #     Required. The operation to perform on the customer
          class MutateCustomerUserAccessRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # A single operation (update, remove) on customer user access.
          # @!attribute [rw] update_mask
          #   @return [::Google::Protobuf::FieldMask]
          #     FieldMask that determines which resource fields are modified in an update.
          # @!attribute [rw] update
          #   @return [::Google::Ads::GoogleAds::V9::Resources::CustomerUserAccess]
          #     Update operation: The customer user access is expected to have a valid
          #     resource name.
          # @!attribute [rw] remove
          #   @return [::String]
          #     Remove operation: A resource name for the removed access is
          #     expected, in this format:
          #
          #     `customers/{customer_id}/customerUserAccesses/{CustomerUserAccess.user_id}`
          class CustomerUserAccessOperation
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Response message for customer user access mutate.
          # @!attribute [rw] result
          #   @return [::Google::Ads::GoogleAds::V9::Services::MutateCustomerUserAccessResult]
          #     Result for the mutate.
          class MutateCustomerUserAccessResponse
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # The result for the customer user access mutate.
          # @!attribute [rw] resource_name
          #   @return [::String]
          #     Returned for successful operations.
          class MutateCustomerUserAccessResult
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end
      end
    end
  end
end
