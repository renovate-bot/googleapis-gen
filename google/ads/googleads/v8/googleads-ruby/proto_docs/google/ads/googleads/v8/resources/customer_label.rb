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
          # Represents a relationship between a customer and a label. This customer may
          # not have access to all the labels attached to it. Additional CustomerLabels
          # may be returned by increasing permissions with login-customer-id.
          # @!attribute [rw] resource_name
          #   @return [::String]
          #     Immutable. Name of the resource.
          #     Customer label resource names have the form:
          #     `customers/{customer_id}/customerLabels/{label_id}`
          # @!attribute [r] customer
          #   @return [::String]
          #     Output only. The resource name of the customer to which the label is attached.
          #     Read only.
          # @!attribute [r] label
          #   @return [::String]
          #     Output only. The resource name of the label assigned to the customer.
          #
          #     Note: the Customer ID portion of the label resource name is not
          #     validated when creating a new CustomerLabel.
          class CustomerLabel
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end
      end
    end
  end
end
