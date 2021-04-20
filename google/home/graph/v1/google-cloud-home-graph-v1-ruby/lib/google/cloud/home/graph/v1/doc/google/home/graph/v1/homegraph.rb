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
        # Request type for the
        # [`RequestSyncDevices`](https://cloud.google.com#google.home.graph.v1.HomeGraphApiService.RequestSyncDevices)
        # call.
        # @!attribute [rw] agent_user_id
        #   @return [String]
        #     Required. Third-party user ID.
        # @!attribute [rw] async
        #   @return [true, false]
        #     Optional. If set, the request will be added to a queue and a response will
        #     be returned immediately. This enables concurrent requests for the given
        #     `agent_user_id`, but the caller will not receive any error responses.
        class RequestSyncDevicesRequest; end

        # Response type for the
        # [`RequestSyncDevices`](https://cloud.google.com#google.home.graph.v1.HomeGraphApiService.RequestSyncDevices)
        # call.
        #
        # Intentionally empty upon success. An HTTP response code is returned
        # with more details upon failure.
        class RequestSyncDevicesResponse; end

        # Request type for the
        # [`ReportStateAndNotification`](https://cloud.google.com#google.home.graph.v1.HomeGraphApiService.ReportStateAndNotification)
        # call. It may include states, notifications, or both. States and notifications
        # are defined per `device_id` (for example, "123" and "456" in the following
        # example).
        # = Example
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
        #   @return [String]
        #     Request ID used for debugging.
        # @!attribute [rw] event_id
        #   @return [String]
        #     Unique identifier per event (for example, a doorbell press).
        # @!attribute [rw] agent_user_id
        #   @return [String]
        #     Required. Third-party user ID.
        # @!attribute [rw] follow_up_token
        #   @return [String]
        #     Deprecated.
        # @!attribute [rw] payload
        #   @return [Google::Home::Graph::V1::StateAndNotificationPayload]
        #     Required. State of devices to update and notification metadata for devices.
        class ReportStateAndNotificationRequest; end

        # Response type for the
        # [`ReportStateAndNotification`](https://cloud.google.com#google.home.graph.v1.HomeGraphApiService.ReportStateAndNotification)
        # call.
        # @!attribute [rw] request_id
        #   @return [String]
        #     Request ID copied from
        #     {Google::Home::Graph::V1::ReportStateAndNotificationRequest ReportStateAndNotificationRequest}.
        class ReportStateAndNotificationResponse; end

        # Payload containing the state and notification information for devices.
        # @!attribute [rw] devices
        #   @return [Google::Home::Graph::V1::ReportStateAndNotificationDevice]
        #     The devices for updating state and sending notifications.
        class StateAndNotificationPayload; end

        # The states and notifications specific to a device.
        # @!attribute [rw] states
        #   @return [Google::Protobuf::Struct]
        #     States of devices to update. See the **Device STATES** section
        #     of the individual trait [reference
        #     guides](https://developers.google.com/assistant/smarthome/traits).
        # @!attribute [rw] notifications
        #   @return [Google::Protobuf::Struct]
        #     Notifications metadata for devices. See the **Device NOTIFICATIONS**
        #     section of the individual trait [reference
        #     guides](https://developers.google.com/assistant/smarthome/traits).
        class ReportStateAndNotificationDevice; end

        # Request type for the
        # [`DeleteAgentUser`](https://cloud.google.com#google.home.graph.v1.HomeGraphApiService.DeleteAgentUser)
        # call.
        # @!attribute [rw] request_id
        #   @return [String]
        #     Request ID used for debugging.
        # @!attribute [rw] agent_user_id
        #   @return [String]
        #     Required. Third-party user ID.
        class DeleteAgentUserRequest; end

        # Request type for the
        # [`Query`](https://cloud.google.com#google.home.graph.v1.HomeGraphApiService.Query) call.
        # @!attribute [rw] request_id
        #   @return [String]
        #     Request ID used for debugging.
        # @!attribute [rw] agent_user_id
        #   @return [String]
        #     Required. Third-party user ID.
        # @!attribute [rw] inputs
        #   @return [Array<Google::Home::Graph::V1::QueryRequestInput>]
        #     Required. Inputs containing third-party device IDs for which to
        #     get the device states.
        class QueryRequest; end

        # Device ID inputs to {Google::Home::Graph::V1::QueryRequest QueryRequest}.
        # @!attribute [rw] payload
        #   @return [Google::Home::Graph::V1::QueryRequestPayload]
        #     Payload containing third-party device IDs.
        class QueryRequestInput; end

        # Payload containing device IDs.
        # @!attribute [rw] devices
        #   @return [Array<Google::Home::Graph::V1::AgentDeviceId>]
        #     Third-party device IDs for which to get the device states.
        class QueryRequestPayload; end

        # Third-party device ID for one device.
        # @!attribute [rw] id
        #   @return [String]
        #     Third-party device ID.
        class AgentDeviceId; end

        # Response type for the
        # [`Query`](https://cloud.google.com#google.home.graph.v1.HomeGraphApiService.Query) call.
        # This should follow the same format as the Google smart home
        # `action.devices.QUERY`
        # [response](https://developers.google.com/assistant/smarthome/reference/intent/query).
        # = Example
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
        #   @return [String]
        #     Request ID used for debugging. Copied from the request.
        # @!attribute [rw] payload
        #   @return [Google::Home::Graph::V1::QueryResponsePayload]
        #     Device states for the devices given in the request.
        class QueryResponse; end

        # Payload containing device states information.
        # @!attribute [rw] devices
        #   @return [Hash{String => Google::Protobuf::Struct}]
        #     States of the devices. Map of third-party device ID to struct of device
        #     states.
        class QueryResponsePayload; end

        # Request type for the [`Sync`](https://cloud.google.com#google.home.graph.v1.HomeGraphApiService.Sync)
        # call.
        # @!attribute [rw] request_id
        #   @return [String]
        #     Request ID used for debugging.
        # @!attribute [rw] agent_user_id
        #   @return [String]
        #     Required. Third-party user ID.
        class SyncRequest; end

        # Response type for the
        # [`Sync`](https://cloud.google.com#google.home.graph.v1.HomeGraphApiService.Sync) call.
        # This should follow the same format as the Google smart home
        # `action.devices.SYNC`
        # [response](https://developers.google.com/assistant/smarthome/reference/intent/sync).
        # = Example
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
        #   @return [String]
        #     Request ID used for debugging. Copied from the request.
        # @!attribute [rw] payload
        #   @return [Google::Home::Graph::V1::SyncResponsePayload]
        #     Devices associated with the third-party user.
        class SyncResponse; end

        # Payload containing device information.
        # @!attribute [rw] agent_user_id
        #   @return [String]
        #     Third-party user ID
        # @!attribute [rw] devices
        #   @return [Array<Google::Home::Graph::V1::Device>]
        #     Devices associated with the third-party user.
        class SyncResponsePayload; end
      end
    end
  end
end