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
        module Enums
          # Container for enum describing extension setting device types.
          class ExtensionSettingDeviceEnum
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods

            # Possible device types for an extension setting.
            module ExtensionSettingDevice
              # Not specified.
              UNSPECIFIED = 0

              # The value is unknown in this version.
              UNKNOWN = 1

              # Mobile. The extensions in the extension setting will only serve on
              # mobile devices.
              MOBILE = 2

              # Desktop. The extensions in the extension setting will only serve on
              # desktop devices.
              DESKTOP = 3
            end
          end
        end
      end
    end
  end
end
