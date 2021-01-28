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
  module Home
    module Graph
      module V1
        # Third-party device definition.
        # @!attribute [rw] id
        #   @return [String]
        #     Third-party device ID.
        # @!attribute [rw] type
        #   @return [String]
        #     Hardware type of the device.
        #     See [device
        #     types](https://developers.google.com/assistant/smarthome/guides).
        # @!attribute [rw] traits
        #   @return [Array<String>]
        #     Traits supported by the device.
        #     See [device
        #     traits](https://developers.google.com/assistant/smarthome/traits).
        # @!attribute [rw] name
        #   @return [Google::Home::Graph::V1::DeviceNames]
        #     Names given to this device by your smart home Action.
        # @!attribute [rw] will_report_state
        #   @return [true, false]
        #     Indicates whether your smart home Action will report state of this device
        #     to Google via
        #     {Google::Home::Graph::V1::HomeGraphApiService::ReportStateAndNotification ReportStateAndNotification}.
        # @!attribute [rw] room_hint
        #   @return [String]
        #     Suggested name for the room where this device is installed.
        #     Google attempts to use this value during user setup.
        # @!attribute [rw] structure_hint
        #   @return [String]
        #     Suggested name for the structure where this device is installed.
        #     Google attempts to use this value during user setup.
        # @!attribute [rw] device_info
        #   @return [Google::Home::Graph::V1::DeviceInfo]
        #     Device manufacturer, model, hardware version, and software version.
        # @!attribute [rw] attributes
        #   @return [Google::Protobuf::Struct]
        #     Attributes for the traits supported by the device.
        # @!attribute [rw] custom_data
        #   @return [Google::Protobuf::Struct]
        #     Custom device attributes stored in Home Graph and provided to your
        #     smart home Action in each
        #     [QUERY](https://developers.google.com/assistant/smarthome/reference/intent/query)
        #     and
        #     [EXECUTE](https://developers.google.com/assistant/smarthome/reference/intent/execute)
        #     intent.
        # @!attribute [rw] other_device_ids
        #   @return [Array<Google::Home::Graph::V1::AgentOtherDeviceId>]
        #     Alternate IDs associated with this device.
        #     This is used to identify cloud synced devices enabled for [local
        #     fulfillment](https://developers.google.com/assistant/smarthome/concepts/local).
        # @!attribute [rw] notification_supported_by_agent
        #   @return [true, false]
        #     Indicates whether your smart home Action will report notifications
        #     to Google for this device via
        #     {Google::Home::Graph::V1::HomeGraphApiService::ReportStateAndNotification ReportStateAndNotification}.
        #
        #     If your smart home Action enables users to control device notifications,
        #     you should update this field and call
        #     {Google::Home::Graph::V1::HomeGraphApiService::RequestSyncDevices RequestSyncDevices}.
        class Device; end

        # Identifiers used to describe the device.
        # @!attribute [rw] name
        #   @return [String]
        #     Primary name of the device, generally provided by the user.
        # @!attribute [rw] nicknames
        #   @return [Array<String>]
        #     Additional names provided by the user for the device.
        # @!attribute [rw] default_names
        #   @return [Array<String>]
        #     List of names provided by the manufacturer rather than the user, such as
        #     serial numbers, SKUs, etc.
        class DeviceNames; end

        # Device information.
        # @!attribute [rw] manufacturer
        #   @return [String]
        #     Device manufacturer.
        # @!attribute [rw] model
        #   @return [String]
        #     Device model.
        # @!attribute [rw] hw_version
        #   @return [String]
        #     Device hardware version.
        # @!attribute [rw] sw_version
        #   @return [String]
        #     Device software version.
        class DeviceInfo; end

        # Alternate third-party device ID.
        # @!attribute [rw] agent_id
        #   @return [String]
        #     Project ID for your smart home Action.
        # @!attribute [rw] device_id
        #   @return [String]
        #     Unique third-party device ID.
        class AgentOtherDeviceId; end
      end
    end
  end
end