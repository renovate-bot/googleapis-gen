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
          # Container for enum describing possible access role for user.
          class AccessRoleEnum
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods

            # Possible access role of a user.
            module AccessRole
              # Not specified.
              UNSPECIFIED = 0

              # Used for return value only. Represents value unknown in this version.
              UNKNOWN = 1

              # Owns its account and can control the addition of other users.
              ADMIN = 2

              # Can modify campaigns, but can't affect other users.
              STANDARD = 3

              # Can view campaigns and account changes, but cannot make edits.
              READ_ONLY = 4

              # Role for \"email only\" access. Represents an email recipient rather than
              # a true User entity.
              EMAIL_ONLY = 5
            end
          end
        end
      end
    end
  end
end
