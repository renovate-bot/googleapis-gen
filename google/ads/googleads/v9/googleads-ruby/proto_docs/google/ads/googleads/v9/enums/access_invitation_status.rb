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
          # Container for enum for identifying the status of access invitation
          class AccessInvitationStatusEnum
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods

            # Possible access invitation status of a user
            module AccessInvitationStatus
              # Not specified.
              UNSPECIFIED = 0

              # Used for return value only. Represents value unknown in this version.
              UNKNOWN = 1

              # The initial state of an invitation, before being acted upon by anyone.
              PENDING = 2

              # Invitation process was terminated by the email recipient. No new user was
              # created.
              DECLINED = 3

              # Invitation URLs expired without being acted upon. No new user can be
              # created.  Invitations expire 20 days after creation.
              EXPIRED = 4
            end
          end
        end
      end
    end
  end
end
