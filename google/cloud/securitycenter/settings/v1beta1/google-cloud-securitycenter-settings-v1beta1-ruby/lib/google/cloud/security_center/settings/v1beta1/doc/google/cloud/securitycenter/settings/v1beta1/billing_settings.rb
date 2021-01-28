# Copyright 2020 Google LLC
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

module Google
  module Cloud
    module Securitycenter
      module Settings
        module V1beta1
          # Billing settings
          # @!attribute [rw] billing_tier
          #   @return [Google::Cloud::Securitycenter::Settings::V1beta1::BillingTier]
          #     Output only. Billing tier selected by customer
          # @!attribute [rw] billing_type
          #   @return [Google::Cloud::Securitycenter::Settings::V1beta1::BillingType]
          #     Output only. Type of billing method
          # @!attribute [rw] start_time
          #   @return [Google::Protobuf::Timestamp]
          #     Output only. The absolute point in time when the subscription became effective.
          #     Can be compared to expire_time value to determine full contract duration
          # @!attribute [rw] expire_time
          #   @return [Google::Protobuf::Timestamp]
          #     Output only. The absolute point in time when the subscription expires.
          #
          #     If this field is populated and billing_tier is STANDARD, this is
          #     indication of a point in the _past_ when a PREMIUM access ended.
          class BillingSettings; end

          # Billing tier options
          module BillingTier
            # Default value. This value is unused.
            BILLING_TIER_UNSPECIFIED = 0

            # The standard billing tier.
            STANDARD = 1

            # The premium billing tier.
            PREMIUM = 2
          end

          # Billing type
          module BillingType
            # Default billing type
            BILLING_TYPE_UNSPECIFIED = 0

            # Subscription for Premium billing tier
            SUBSCRIPTION = 1

            # Trial subscription for Premium billing tier
            TRIAL_SUBSCRIPTION = 2

            # Alpha customer for Premium billing tier
            ALPHA = 3
          end
        end
      end
    end
  end
end