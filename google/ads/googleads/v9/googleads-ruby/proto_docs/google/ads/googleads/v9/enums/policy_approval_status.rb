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
        module Enums
          # Container for enum describing possible policy approval statuses.
          class PolicyApprovalStatusEnum
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods

            # The possible policy approval statuses. When there are several approval
            # statuses available the most severe one will be used. The order of severity
            # is DISAPPROVED, AREA_OF_INTEREST_ONLY, APPROVED_LIMITED and APPROVED.
            module PolicyApprovalStatus
              # No value has been specified.
              UNSPECIFIED = 0

              # The received value is not known in this version.
              #
              # This is a response-only value.
              UNKNOWN = 1

              # Will not serve.
              DISAPPROVED = 2

              # Serves with restrictions.
              APPROVED_LIMITED = 3

              # Serves without restrictions.
              APPROVED = 4

              # Will not serve in targeted countries, but may serve for users who are
              # searching for information about the targeted countries.
              AREA_OF_INTEREST_ONLY = 5
            end
          end
        end
      end
    end
  end
end
