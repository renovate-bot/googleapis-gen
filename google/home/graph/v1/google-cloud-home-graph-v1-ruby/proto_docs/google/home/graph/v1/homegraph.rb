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
  module Home
    module Graph
      module V1
        # Request type for the
        # [`RequestSyncDevices`](#google.home.graph.v1.HomeGraphApiService.RequestSyncDevices)
        # call.
        # @!attribute [rw] agent_user_id
        #   @return [::String]
        #     Required. Third-party user ID.
        # @!attribute [rw] async
        #   @return [::Boolean]
        #     Optional. If set, the request will be added to a queue and a response will
        #     be returned immediately. This enables concurrent requests for the given
        #     `agent_user_id`, but the caller will not receive any error responses.
        class RequestSyncDevicesRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Response type for the
        # [`RequestSyncDevices`](#google.home.graph.v1.HomeGraphApiService.RequestSyncDevices)
        # call.
        #
        # Intentionally empty upon success. An HTTP response code is returned
        # with more details upon failure.
        class RequestSyncDevicesResponse
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request type for the
        # [`ReportStateAndNotification`](#google.home.graph.v1.HomeGraphApiService.ReportStateAndNotification)
        # call. It may include states, notifications, or both. States and notifications
        # are defined per `device_id` (for example, "123" and "456" in the following
        # example).
        # # Example
        #
        # ```json
        # {
        #   "requestId": "ff36a3cc-ec34-11e6-b1a0-64510650abcf",
        #   "agentUserId": "1234",
        #   "payload": {
        #     "devices": {
        #       "states": {
        #         "123": {
        #           "on": true
        #         },
        #         "456": {
        #           "on": true,
        #           "brightness": 10
        #         }
        #       },
        #     }
        #   }
        # }
        # ```
        # @!attribute [rw] request_id
        #   @return [::String]
        #     Request ID used for debugging.
        # @!attribute [rw] event_id
        #   @return [::String]
        #     Unique identifier per event (for example, a doorbell press).
        # @!attribute [rw] agent_user_id
        #   @return [::String]
        #     Required. Third-party user ID.
        # @!attribute [rw] follow_up_token
        #   @return [::String]
        #     Deprecated.
        #     (-- Token to maintain state in the follow up notification response. See the
        #     notifications guide at
        #     https://developers.google.com/assistant/smarthome/develop/notifications for
        #     details on implementing follow up notifications --)
        # @!attribute [rw] payload
        #   @return [::Google::Home::Graph::V1::StateAndNotificationPayload]
        #     Required. State of devices to update and notification metadata for devices.
        class ReportStateAndNotificationRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Response type for the
        # [`ReportStateAndNotification`](#google.home.graph.v1.HomeGraphApiService.ReportStateAndNotification)
        # call.
        # @!attribute [rw] request_id
        #   @return [::String]
        #     Request ID copied from
        #     {::Google::Home::Graph::V1::ReportStateAndNotificationRequest ReportStateAndNotificationRequest}.
        class ReportStateAndNotificationResponse
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Payload containing the state and notification information for devices.
        # @!attribute [rw] devices
        #   @return [::Google::Home::Graph::V1::ReportStateAndNotificationDevice]
        #     The devices for updating state and sending notifications.
        class StateAndNotificationPayload
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The states and notifications specific to a device.
        # @!attribute [rw] states
        #   @return [::Google::Protobuf::Struct]
        #     States of devices to update. See the **Device STATES** section
        #     of the individual trait [reference
        #     guides](https://developers.google.com/assistant/smarthome/traits).
        # @!attribute [rw] notifications
        #   @return [::Google::Protobuf::Struct]
        #     Notifications metadata for devices. See the **Device NOTIFICATIONS**
        #     section of the individual trait [reference
        #     guides](https://developers.google.com/assistant/smarthome/traits).
        class ReportStateAndNotificationDevice
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request type for the
        # [`DeleteAgentUser`](#google.home.graph.v1.HomeGraphApiService.DeleteAgentUser)
        # call.
        # @!attribute [rw] request_id
        #   @return [::String]
        #     Request ID used for debugging.
        # @!attribute [rw] agent_user_id
        #   @return [::String]
        #     Required. Third-party user ID.
        class DeleteAgentUserRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request type for the
        # [`Query`](#google.home.graph.v1.HomeGraphApiService.Query) call.
        # @!attribute [rw] request_id
        #   @return [::String]
        #     Request ID used for debugging.
        # @!attribute [rw] agent_user_id
        #   @return [::String]
        #     Required. Third-party user ID.
        # @!attribute [rw] inputs
        #   @return [::Array<::Google::Home::Graph::V1::QueryRequestInput>]
        #     Required. Inputs containing third-party device IDs for which to
        #     get the device states.
        class QueryRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Device ID inputs to {::Google::Home::Graph::V1::QueryRequest QueryRequest}.
        # @!attribute [rw] payload
        #   @return [::Google::Home::Graph::V1::QueryRequestPayload]
        #     Payload containing third-party device IDs.
        class QueryRequestInput
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Payload containing device IDs.
        # @!attribute [rw] devices
        #   @return [::Array<::Google::Home::Graph::V1::AgentDeviceId>]
        #     Third-party device IDs for which to get the device states.
        class QueryRequestPayload
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Third-party device ID for one device.
        # @!attribute [rw] id
        #   @return [::String]
        #     Third-party device ID.
        class AgentDeviceId
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Response type for the
        # [`Query`](#google.home.graph.v1.HomeGraphApiService.Query) call.
        # This should follow the same format as the Google smart home
        # `action.devices.QUERY`
        # [response](https://developers.google.com/assistant/smarthome/reference/intent/query).
        # # Example
        #
        # ```json
        # {
        #   "requestId": "ff36a3cc-ec34-11e6-b1a0-64510650abcf",
        #   "payload": {
        #     "devices": {
        #       "123": {
        #         "on": true,
        #         "online": true
        #       },
        #       "456": {
        #         "on": true,
        #         "online": true,
        #         "brightness": 80,
        #         "color": {
        #           "name": "cerulean",
        #           "spectrumRGB": 31655
        #         }
        #       }
        #     }
        #   }
        # }
        # ```
        # @!attribute [rw] request_id
        #   @return [::String]
        #     Request ID used for debugging. Copied from the request.
        # @!attribute [rw] payload
        #   @return [::Google::Home::Graph::V1::QueryResponsePayload]
        #     Device states for the devices given in the request.
        class QueryResponse
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Payload containing device states information.
        # @!attribute [rw] devices
        #   @return [::Google::Protobuf::Map{::String => ::Google::Protobuf::Struct}]
        #     States of the devices. Map of third-party device ID to struct of device
        #     states.
        class QueryResponsePayload
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods

          # @!attribute [rw] key
          #   @return [::String]
          # @!attribute [rw] value
          #   @return [::Google::Protobuf::Struct]
          class DevicesEntry
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end

        # Request type for the [`Sync`](#google.home.graph.v1.HomeGraphApiService.Sync)
        # call.
        # @!attribute [rw] request_id
        #   @return [::String]
        #     Request ID used for debugging.
        # @!attribute [rw] agent_user_id
        #   @return [::String]
        #     Required. Third-party user ID.
        class SyncRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Response type for the
        # [`Sync`](#google.home.graph.v1.HomeGraphApiService.Sync) call.
        # This should follow the same format as the Google smart home
        # `action.devices.SYNC`
        # [response](https://developers.google.com/assistant/smarthome/reference/intent/sync).
        # # Example
        #
        # ```json
        # {
        #   "requestId": "ff36a3cc-ec34-11e6-b1a0-64510650abcf",
        #   "payload": {
        #     "agentUserId": "1836.15267389",
        #     "devices": [{
        #       "id": "123",
        #       "type": "action.devices.types.OUTLET",
        #       "traits": [
        #         "action.devices.traits.OnOff"
        #       ],
        #       "name": {
        #         "defaultNames": ["My Outlet 1234"],
        #         "name": "Night light",
        #         "nicknames": ["wall plug"]
        #       },
        #       "willReportState": false,
        #       "deviceInfo": {
        #         "manufacturer": "lights-out-inc",
        #         "model": "hs1234",
        #         "hwVersion": "3.2",
        #         "swVersion": "11.4"
        #       },
        #       "customData": {
        #         "fooValue": 74,
        #         "barValue": true,
        #         "bazValue": "foo"
        #       }
        #     }]
        #   }
        # }
        # ```
        # @!attribute [rw] request_id
        #   @return [::String]
        #     Request ID used for debugging. Copied from the request.
        # @!attribute [rw] payload
        #   @return [::Google::Home::Graph::V1::SyncResponsePayload]
        #     Devices associated with the third-party user.
        class SyncResponse
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Payload containing device information.
        # @!attribute [rw] agent_user_id
        #   @return [::String]
        #     Third-party user ID
        # @!attribute [rw] devices
        #   @return [::Array<::Google::Home::Graph::V1::Device>]
        #     Devices associated with the third-party user.
        class SyncResponsePayload
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end
      end
    end
  end
end
