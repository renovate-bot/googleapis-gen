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
    module Billing
      module Budgets
        module V1beta1
          # Request for CreateBudget
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. The name of the billing account to create the budget in. Values
          #     are of the form `billingAccounts/{billingAccountId}`.
          # @!attribute [rw] budget
          #   @return [Google::Cloud::Billing::Budgets::V1beta1::Budget]
          #     Required. Budget to create.
          class CreateBudgetRequest; end

          # Request for UpdateBudget
          # @!attribute [rw] budget
          #   @return [Google::Cloud::Billing::Budgets::V1beta1::Budget]
          #     Required. The updated budget object.
          #     The budget to update is specified by the budget name in the budget.
          # @!attribute [rw] update_mask
          #   @return [Google::Protobuf::FieldMask]
          #     Optional. Indicates which fields in the provided budget to update.
          #     Read-only fields (such as `name`) cannot be changed. If this is not
          #     provided, then only fields with non-default values from the request are
          #     updated. See
          #     https://developers.google.com/protocol-buffers/docs/proto3#default for more
          #     details about default values.
          class UpdateBudgetRequest; end

          # Request for GetBudget
          # @!attribute [rw] name
          #   @return [String]
          #     Required. Name of budget to get. Values are of the form
          #     `billingAccounts/{billingAccountId}/budgets/{budgetId}`.
          class GetBudgetRequest; end

          # Request for ListBudgets
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. Name of billing account to list budgets under. Values
          #     are of the form `billingAccounts/{billingAccountId}`.
          # @!attribute [rw] page_size
          #   @return [Integer]
          #     Optional. The maximum number of budgets to return per page.
          #     The default and maximum value are 100.
          # @!attribute [rw] page_token
          #   @return [String]
          #     Optional. The value returned by the last `ListBudgetsResponse` which
          #     indicates that this is a continuation of a prior `ListBudgets` call,
          #     and that the system should return the next page of data.
          class ListBudgetsRequest; end

          # Response for ListBudgets
          # @!attribute [rw] budgets
          #   @return [Array<Google::Cloud::Billing::Budgets::V1beta1::Budget>]
          #     List of the budgets owned by the requested billing account.
          # @!attribute [rw] next_page_token
          #   @return [String]
          #     If not empty, indicates that there may be more budgets that match the
          #     request; this value should be passed in a new `ListBudgetsRequest`.
          class ListBudgetsResponse; end

          # Request for DeleteBudget
          # @!attribute [rw] name
          #   @return [String]
          #     Required. Name of the budget to delete. Values are of the form
          #     `billingAccounts/{billingAccountId}/budgets/{budgetId}`.
          class DeleteBudgetRequest; end
        end
      end
    end
  end
end