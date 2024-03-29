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
  module Identity
    module AccessContextManager
      module Type
        # The encryption state of the device.
        module DeviceEncryptionStatus
          # The encryption status of the device is not specified or not known.
          ENCRYPTION_UNSPECIFIED = 0

          # The device does not support encryption.
          ENCRYPTION_UNSUPPORTED = 1

          # The device supports encryption, but is currently unencrypted.
          UNENCRYPTED = 2

          # The device is encrypted.
          ENCRYPTED = 3
        end

        # The operating system type of the device.
        # Next id: 7
        module OsType
          # The operating system of the device is not specified or not known.
          OS_UNSPECIFIED = 0

          # A desktop Mac operating system.
          DESKTOP_MAC = 1

          # A desktop Windows operating system.
          DESKTOP_WINDOWS = 2

          # A desktop Linux operating system.
          DESKTOP_LINUX = 3

          # A desktop ChromeOS operating system.
          DESKTOP_CHROME_OS = 6

          # An Android operating system.
          ANDROID = 4

          # An iOS operating system.
          IOS = 5
        end

        # The degree to which the device is managed by the Cloud organization.
        module DeviceManagementLevel
          # The device's management level is not specified or not known.
          MANAGEMENT_UNSPECIFIED = 0

          # The device is not managed.
          NONE = 1

          # Basic management is enabled, which is generally limited to monitoring and
          # wiping the corporate account.
          BASIC = 2

          # Complete device management. This includes more thorough monitoring and the
          # ability to directly manage the device (such as remote wiping). This can be
          # enabled through the Android Enterprise Platform.
          COMPLETE = 3
        end
      end
    end
  end
end
