# -*- coding: utf-8 -*-
# Copyright 2020 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
#
import proto  # type: ignore

from google.home.graph_v1.types import device
from google.protobuf import struct_pb2  # type: ignore


__protobuf__ = proto.module(
    package='google.home.graph.v1',
    manifest={
        'RequestSyncDevicesRequest',
        'RequestSyncDevicesResponse',
        'ReportStateAndNotificationRequest',
        'ReportStateAndNotificationResponse',
        'StateAndNotificationPayload',
        'ReportStateAndNotificationDevice',
        'DeleteAgentUserRequest',
        'QueryRequest',
        'QueryRequestInput',
        'QueryRequestPayload',
        'AgentDeviceId',
        'QueryResponse',
        'QueryResponsePayload',
        'SyncRequest',
        'SyncResponse',
        'SyncResponsePayload',
    },
)


class RequestSyncDevicesRequest(proto.Message):
    r"""Request type for the
    ```RequestSyncDevices`` <#google.home.graph.v1.HomeGraphApiService.RequestSyncDevices>`__
    call.

    Attributes:
        agent_user_id (str):
            Required. Third-party user ID.
        async_ (bool):
            Optional. If set, the request will be added to a queue and a
            response will be returned immediately. This enables
            concurrent requests for the given ``agent_user_id``, but the
            caller will not receive any error responses.
    """

    agent_user_id = proto.Field(
        proto.STRING,
        number=1,
    )
    async_ = proto.Field(
        proto.BOOL,
        number=2,
    )


class RequestSyncDevicesResponse(proto.Message):
    r"""Response type for the
    ```RequestSyncDevices`` <#google.home.graph.v1.HomeGraphApiService.RequestSyncDevices>`__
    call.

    Intentionally empty upon success. An HTTP response code is returned
    with more details upon failure.
        """


class ReportStateAndNotificationRequest(proto.Message):
    r"""Request type for the
    ```ReportStateAndNotification`` <#google.home.graph.v1.HomeGraphApiService.ReportStateAndNotification>`__
    call. It may include states, notifications, or both. States and
    notifications are defined per ``device_id`` (for example, "123" and
    "456" in the following example).

    Example
    =======

    .. code:: json

       {
         "requestId": "ff36a3cc-ec34-11e6-b1a0-64510650abcf",
         "agentUserId": "1234",
         "payload": {
           "devices": {
             "states": {
               "123": {
                 "on": true
               },
               "456": {
                 "on": true,
                 "brightness": 10
               }
             },
           }
         }
       }

    Attributes:
        request_id (str):
            Request ID used for debugging.
        event_id (str):
            Unique identifier per event (for example, a
            doorbell press).
        agent_user_id (str):
            Required. Third-party user ID.
        follow_up_token (str):
            Deprecated.
            (-- Token to maintain state in the follow up
            notification response. See the notifications
            guide at
            https://developers.google.com/assistant/smarthome/develop/notifications
            for details on implementing follow up
            notifications --)
        payload (google.home.graph_v1.types.StateAndNotificationPayload):
            Required. State of devices to update and
            notification metadata for devices.
    """

    request_id = proto.Field(
        proto.STRING,
        number=1,
    )
    event_id = proto.Field(
        proto.STRING,
        number=4,
    )
    agent_user_id = proto.Field(
        proto.STRING,
        number=2,
    )
    follow_up_token = proto.Field(
        proto.STRING,
        number=5,
    )
    payload = proto.Field(
        proto.MESSAGE,
        number=3,
        message='StateAndNotificationPayload',
    )


class ReportStateAndNotificationResponse(proto.Message):
    r"""Response type for the
    ```ReportStateAndNotification`` <#google.home.graph.v1.HomeGraphApiService.ReportStateAndNotification>`__
    call.

    Attributes:
        request_id (str):
            Request ID copied from
            [ReportStateAndNotificationRequest][google.home.graph.v1.ReportStateAndNotificationRequest].
    """

    request_id = proto.Field(
        proto.STRING,
        number=1,
    )


class StateAndNotificationPayload(proto.Message):
    r"""Payload containing the state and notification information for
    devices.

    Attributes:
        devices (google.home.graph_v1.types.ReportStateAndNotificationDevice):
            The devices for updating state and sending
            notifications.
    """

    devices = proto.Field(
        proto.MESSAGE,
        number=1,
        message='ReportStateAndNotificationDevice',
    )


class ReportStateAndNotificationDevice(proto.Message):
    r"""The states and notifications specific to a device.
    Attributes:
        states (google.protobuf.struct_pb2.Struct):
            States of devices to update. See the **Device STATES**
            section of the individual trait `reference
            guides <https://developers.google.com/assistant/smarthome/traits>`__.
        notifications (google.protobuf.struct_pb2.Struct):
            Notifications metadata for devices. See the **Device
            NOTIFICATIONS** section of the individual trait `reference
            guides <https://developers.google.com/assistant/smarthome/traits>`__.
    """

    states = proto.Field(
        proto.MESSAGE,
        number=1,
        message=struct_pb2.Struct,
    )
    notifications = proto.Field(
        proto.MESSAGE,
        number=2,
        message=struct_pb2.Struct,
    )


class DeleteAgentUserRequest(proto.Message):
    r"""Request type for the
    ```DeleteAgentUser`` <#google.home.graph.v1.HomeGraphApiService.DeleteAgentUser>`__
    call.

    Attributes:
        request_id (str):
            Request ID used for debugging.
        agent_user_id (str):
            Required. Third-party user ID.
    """

    request_id = proto.Field(
        proto.STRING,
        number=1,
    )
    agent_user_id = proto.Field(
        proto.STRING,
        number=2,
    )


class QueryRequest(proto.Message):
    r"""Request type for the
    ```Query`` <#google.home.graph.v1.HomeGraphApiService.Query>`__
    call.

    Attributes:
        request_id (str):
            Request ID used for debugging.
        agent_user_id (str):
            Required. Third-party user ID.
        inputs (Sequence[google.home.graph_v1.types.QueryRequestInput]):
            Required. Inputs containing third-party
            device IDs for which to get the device states.
    """

    request_id = proto.Field(
        proto.STRING,
        number=1,
    )
    agent_user_id = proto.Field(
        proto.STRING,
        number=2,
    )
    inputs = proto.RepeatedField(
        proto.MESSAGE,
        number=3,
        message='QueryRequestInput',
    )


class QueryRequestInput(proto.Message):
    r"""Device ID inputs to
    [QueryRequest][google.home.graph.v1.QueryRequest].

    Attributes:
        payload (google.home.graph_v1.types.QueryRequestPayload):
            Payload containing third-party device IDs.
    """

    payload = proto.Field(
        proto.MESSAGE,
        number=1,
        message='QueryRequestPayload',
    )


class QueryRequestPayload(proto.Message):
    r"""Payload containing device IDs.
    Attributes:
        devices (Sequence[google.home.graph_v1.types.AgentDeviceId]):
            Third-party device IDs for which to get the
            device states.
    """

    devices = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='AgentDeviceId',
    )


class AgentDeviceId(proto.Message):
    r"""Third-party device ID for one device.
    Attributes:
        id (str):
            Third-party device ID.
    """

    id = proto.Field(
        proto.STRING,
        number=1,
    )


class QueryResponse(proto.Message):
    r"""Response type for the
    ```Query`` <#google.home.graph.v1.HomeGraphApiService.Query>`__
    call. This should follow the same format as the Google smart home
    ``action.devices.QUERY``
    `response <https://developers.google.com/assistant/smarthome/reference/intent/query>`__.

    Example
    =======

    .. code:: json

       {
         "requestId": "ff36a3cc-ec34-11e6-b1a0-64510650abcf",
         "payload": {
           "devices": {
             "123": {
               "on": true,
               "online": true
             },
             "456": {
               "on": true,
               "online": true,
               "brightness": 80,
               "color": {
                 "name": "cerulean",
                 "spectrumRGB": 31655
               }
             }
           }
         }
       }

    Attributes:
        request_id (str):
            Request ID used for debugging. Copied from
            the request.
        payload (google.home.graph_v1.types.QueryResponsePayload):
            Device states for the devices given in the
            request.
    """

    request_id = proto.Field(
        proto.STRING,
        number=1,
    )
    payload = proto.Field(
        proto.MESSAGE,
        number=2,
        message='QueryResponsePayload',
    )


class QueryResponsePayload(proto.Message):
    r"""Payload containing device states information.
    Attributes:
        devices (Sequence[google.home.graph_v1.types.QueryResponsePayload.DevicesEntry]):
            States of the devices. Map of third-party
            device ID to struct of device states.
    """

    devices = proto.MapField(
        proto.STRING,
        proto.MESSAGE,
        number=1,
        message=struct_pb2.Struct,
    )


class SyncRequest(proto.Message):
    r"""Request type for the
    ```Sync`` <#google.home.graph.v1.HomeGraphApiService.Sync>`__ call.

    Attributes:
        request_id (str):
            Request ID used for debugging.
        agent_user_id (str):
            Required. Third-party user ID.
    """

    request_id = proto.Field(
        proto.STRING,
        number=1,
    )
    agent_user_id = proto.Field(
        proto.STRING,
        number=2,
    )


class SyncResponse(proto.Message):
    r"""Response type for the
    ```Sync`` <#google.home.graph.v1.HomeGraphApiService.Sync>`__ call.
    This should follow the same format as the Google smart home
    ``action.devices.SYNC``
    `response <https://developers.google.com/assistant/smarthome/reference/intent/sync>`__.

    Example
    =======

    .. code:: json

       {
         "requestId": "ff36a3cc-ec34-11e6-b1a0-64510650abcf",
         "payload": {
           "agentUserId": "1836.15267389",
           "devices": [{
             "id": "123",
             "type": "action.devices.types.OUTLET",
             "traits": [
               "action.devices.traits.OnOff"
             ],
             "name": {
               "defaultNames": ["My Outlet 1234"],
               "name": "Night light",
               "nicknames": ["wall plug"]
             },
             "willReportState": false,
             "deviceInfo": {
               "manufacturer": "lights-out-inc",
               "model": "hs1234",
               "hwVersion": "3.2",
               "swVersion": "11.4"
             },
             "customData": {
               "fooValue": 74,
               "barValue": true,
               "bazValue": "foo"
             }
           }]
         }
       }

    Attributes:
        request_id (str):
            Request ID used for debugging. Copied from
            the request.
        payload (google.home.graph_v1.types.SyncResponsePayload):
            Devices associated with the third-party user.
    """

    request_id = proto.Field(
        proto.STRING,
        number=1,
    )
    payload = proto.Field(
        proto.MESSAGE,
        number=2,
        message='SyncResponsePayload',
    )


class SyncResponsePayload(proto.Message):
    r"""Payload containing device information.
    Attributes:
        agent_user_id (str):
            Third-party user ID
        devices (Sequence[google.home.graph_v1.types.Device]):
            Devices associated with the third-party user.
    """

    agent_user_id = proto.Field(
        proto.STRING,
        number=1,
    )
    devices = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message=device.Device,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
