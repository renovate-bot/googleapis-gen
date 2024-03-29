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
          # A data sharing connection, proposed or in use,
          # between a Google Ads Customer and a Merchant Center account.
          # @!attribute [rw] resource_name
          #   @return [::String]
          #     Immutable. The resource name of the merchant center link.
          #     Merchant center link resource names have the form:
          #
          #     `customers/{customer_id}/merchantCenterLinks/{merchant_center_id}`
          # @!attribute [r] id
          #   @return [::Integer]
          #     Output only. The ID of the Merchant Center account.
          #     This field is readonly.
          # @!attribute [r] merchant_center_account_name
          #   @return [::String]
          #     Output only. The name of the Merchant Center account.
          #     This field is readonly.
          # @!attribute [rw] status
          #   @return [::Google::Ads::GoogleAds::V7::Enums::MerchantCenterLinkStatusEnum::MerchantCenterLinkStatus]
          #     The status of the link.
          class MerchantCenterLink
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end
      end
    end
  end
end
