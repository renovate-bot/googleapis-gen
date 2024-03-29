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
        module Enums
          # Container for enumeration of possible positions of the Ad.
          class SlotEnum
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods

            # Enumerates possible positions of the Ad.
            module Slot
              # Not specified.
              UNSPECIFIED = 0

              # The value is unknown in this version.
              UNKNOWN = 1

              # Google search: Side.
              SEARCH_SIDE = 2

              # Google search: Top.
              SEARCH_TOP = 3

              # Google search: Other.
              SEARCH_OTHER = 4

              # Google Display Network.
              CONTENT = 5

              # Search partners: Top.
              SEARCH_PARTNER_TOP = 6

              # Search partners: Other.
              SEARCH_PARTNER_OTHER = 7

              # Cross-network.
              MIXED = 8
            end
          end
        end
      end
    end
  end
end
