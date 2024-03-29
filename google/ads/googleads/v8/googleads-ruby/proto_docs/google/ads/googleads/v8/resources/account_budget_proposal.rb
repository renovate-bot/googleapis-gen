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
      module V8
        module Resources
          # An account-level budget proposal.
          #
          # All fields prefixed with 'proposed' may not necessarily be applied directly.
          # For example, proposed spending limits may be adjusted before their
          # application.  This is true if the 'proposed' field has an 'approved'
          # counterpart, e.g. spending limits.
          #
          # Please note that the proposal type (proposal_type) changes which fields are
          # required and which must remain empty.
          # @!attribute [rw] resource_name
          #   @return [::String]
          #     Immutable. The resource name of the proposal.
          #     AccountBudgetProposal resource names have the form:
          #
          #     `customers/{customer_id}/accountBudgetProposals/{account_budget_proposal_id}`
          # @!attribute [r] id
          #   @return [::Integer]
          #     Output only. The ID of the proposal.
          # @!attribute [rw] billing_setup
          #   @return [::String]
          #     Immutable. The resource name of the billing setup associated with this proposal.
          # @!attribute [rw] account_budget
          #   @return [::String]
          #     Immutable. The resource name of the account-level budget associated with this
          #     proposal.
          # @!attribute [rw] proposal_type
          #   @return [::Google::Ads::GoogleAds::V8::Enums::AccountBudgetProposalTypeEnum::AccountBudgetProposalType]
          #     Immutable. The type of this proposal, e.g. END to end the budget associated with this
          #     proposal.
          # @!attribute [r] status
          #   @return [::Google::Ads::GoogleAds::V8::Enums::AccountBudgetProposalStatusEnum::AccountBudgetProposalStatus]
          #     Output only. The status of this proposal.
          #     When a new proposal is created, the status defaults to PENDING.
          # @!attribute [rw] proposed_name
          #   @return [::String]
          #     Immutable. The name to assign to the account-level budget.
          # @!attribute [r] approved_start_date_time
          #   @return [::String]
          #     Output only. The approved start date time in yyyy-mm-dd hh:mm:ss format.
          # @!attribute [rw] proposed_purchase_order_number
          #   @return [::String]
          #     Immutable. A purchase order number is a value that enables the user to help them
          #     reference this budget in their monthly invoices.
          # @!attribute [rw] proposed_notes
          #   @return [::String]
          #     Immutable. Notes associated with this budget.
          # @!attribute [r] creation_date_time
          #   @return [::String]
          #     Output only. The date time when this account-level budget proposal was created, which is
          #     not the same as its approval date time, if applicable.
          # @!attribute [r] approval_date_time
          #   @return [::String]
          #     Output only. The date time when this account-level budget was approved, if applicable.
          # @!attribute [rw] proposed_start_date_time
          #   @return [::String]
          #     Immutable. The proposed start date time in yyyy-mm-dd hh:mm:ss format.
          # @!attribute [rw] proposed_start_time_type
          #   @return [::Google::Ads::GoogleAds::V8::Enums::TimeTypeEnum::TimeType]
          #     Immutable. The proposed start date time as a well-defined type, e.g. NOW.
          # @!attribute [rw] proposed_end_date_time
          #   @return [::String]
          #     Immutable. The proposed end date time in yyyy-mm-dd hh:mm:ss format.
          # @!attribute [rw] proposed_end_time_type
          #   @return [::Google::Ads::GoogleAds::V8::Enums::TimeTypeEnum::TimeType]
          #     Immutable. The proposed end date time as a well-defined type, e.g. FOREVER.
          # @!attribute [r] approved_end_date_time
          #   @return [::String]
          #     Output only. The approved end date time in yyyy-mm-dd hh:mm:ss format.
          # @!attribute [r] approved_end_time_type
          #   @return [::Google::Ads::GoogleAds::V8::Enums::TimeTypeEnum::TimeType]
          #     Output only. The approved end date time as a well-defined type, e.g. FOREVER.
          # @!attribute [rw] proposed_spending_limit_micros
          #   @return [::Integer]
          #     Immutable. The proposed spending limit in micros.  One million is equivalent to
          #     one unit.
          # @!attribute [rw] proposed_spending_limit_type
          #   @return [::Google::Ads::GoogleAds::V8::Enums::SpendingLimitTypeEnum::SpendingLimitType]
          #     Immutable. The proposed spending limit as a well-defined type, e.g. INFINITE.
          # @!attribute [r] approved_spending_limit_micros
          #   @return [::Integer]
          #     Output only. The approved spending limit in micros.  One million is equivalent to
          #     one unit.
          # @!attribute [r] approved_spending_limit_type
          #   @return [::Google::Ads::GoogleAds::V8::Enums::SpendingLimitTypeEnum::SpendingLimitType]
          #     Output only. The approved spending limit as a well-defined type, e.g. INFINITE.
          class AccountBudgetProposal
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end
      end
    end
  end
end
