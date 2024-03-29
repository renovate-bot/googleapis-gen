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
        module Errors
          # Container for enum describing YouTube video registration errors.
          class YoutubeVideoRegistrationErrorEnum
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods

            # Enum describing YouTube video registration errors.
            module YoutubeVideoRegistrationError
              # Enum unspecified.
              UNSPECIFIED = 0

              # The received error code is not known in this version.
              UNKNOWN = 1

              # Video to be registered wasn't found.
              VIDEO_NOT_FOUND = 2

              # Video to be registered is not accessible (e.g. private).
              VIDEO_NOT_ACCESSIBLE = 3

              # Video to be registered is not eligible (e.g. mature content).
              VIDEO_NOT_ELIGIBLE = 4
            end
          end
        end
      end
    end
  end
end
