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

from google.protobuf import struct_pb2  # type: ignore


__protobuf__ = proto.module(
    package='google.home.graph.v1',
    manifest={
        'Device',
        'DeviceNames',
        'DeviceInfo',
        'AgentOtherDeviceId',
    },
)


class Device(proto.Message):
    r"""Third-party device definition.

    Attributes:
        id (str):
            Third-party device ID.
        type_ (str):
            Hardware type of the device. See `device
            types <https://developers.google.com/assistant/smarthome/guides>`__.
        traits (Sequence[str]):
            Traits supported by the device. See `device
            traits <https://developers.google.com/assistant/smarthome/traits>`__.
        name (google.home.graph_v1.types.DeviceNames):
            Names given to this device by your smart home
            Action.
        will_report_state (bool):
            Indicates whether your smart home Action will report state
            of this device to Google via
            [ReportStateAndNotification][google.home.graph.v1.HomeGraphApiService.ReportStateAndNotification].
        room_hint (str):
            Suggested name for the room where this device
            is installed. Google attempts to use this value
            during user setup.
        structure_hint (str):
            Suggested name for the structure where this
            device is installed. Google attempts to use this
            value during user setup.
        device_info (google.home.graph_v1.types.DeviceInfo):
            Device manufacturer, model, hardware version,
            and software version.
        attributes (google.protobuf.struct_pb2.Struct):
            Attributes for the traits supported by the
            device.
        custom_data (google.protobuf.struct_pb2.Struct):
            Custom device attributes stored in Home Graph and provided
            to your smart home Action in each
            `QUERY <https://developers.google.com/assistant/smarthome/reference/intent/query>`__
            and
            `EXECUTE <https://developers.google.com/assistant/smarthome/reference/intent/execute>`__
            intent.
        other_device_ids (Sequence[google.home.graph_v1.types.AgentOtherDeviceId]):
            Alternate IDs associated with this device. This is used to
            identify cloud synced devices enabled for `local
            fulfillment <https://developers.google.com/assistant/smarthome/concepts/local>`__.
        notification_supported_by_agent (bool):
            Indicates whether your smart home Action will report
            notifications to Google for this device via
            [ReportStateAndNotification][google.home.graph.v1.HomeGraphApiService.ReportStateAndNotification].

            If your smart home Action enables users to control device
            notifications, you should update this field and call
            [RequestSyncDevices][google.home.graph.v1.HomeGraphApiService.RequestSyncDevices].
    """

    id = proto.Field(
        proto.STRING,
        number=1,
    )
    type_ = proto.Field(
        proto.STRING,
        number=2,
    )
    traits = proto.RepeatedField(
        proto.STRING,
        number=3,
    )
    name = proto.Field(
        proto.MESSAGE,
        number=4,
        message='DeviceNames',
    )
    will_report_state = proto.Field(
        proto.BOOL,
        number=5,
    )
    room_hint = proto.Field(
        proto.STRING,
        number=6,
    )
    structure_hint = proto.Field(
        proto.STRING,
        number=7,
    )
    device_info = proto.Field(
        proto.MESSAGE,
        number=8,
        message='DeviceInfo',
    )
    attributes = proto.Field(
        proto.MESSAGE,
        number=9,
        message=struct_pb2.Struct,
    )
    custom_data = proto.Field(
        proto.MESSAGE,
        number=10,
        message=struct_pb2.Struct,
    )
    other_device_ids = proto.RepeatedField(
        proto.MESSAGE,
        number=11,
        message='AgentOtherDeviceId',
    )
    notification_supported_by_agent = proto.Field(
        proto.BOOL,
        number=12,
    )


class DeviceNames(proto.Message):
    r"""Identifiers used to describe the device.

    Attributes:
        name (str):
            Primary name of the device, generally
            provided by the user.
        nicknames (Sequence[str]):
            Additional names provided by the user for the
            device.
        default_names (Sequence[str]):
            List of names provided by the manufacturer
            rather than the user, such as serial numbers,
            SKUs, etc.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    nicknames = proto.RepeatedField(
        proto.STRING,
        number=2,
    )
    default_names = proto.RepeatedField(
        proto.STRING,
        number=3,
    )


class DeviceInfo(proto.Message):
    r"""Device information.

    Attributes:
        manufacturer (str):
            Device manufacturer.
        model (str):
            Device model.
        hw_version (str):
            Device hardware version.
        sw_version (str):
            Device software version.
    """

    manufacturer = proto.Field(
        proto.STRING,
        number=1,
    )
    model = proto.Field(
        proto.STRING,
        number=2,
    )
    hw_version = proto.Field(
        proto.STRING,
        number=3,
    )
    sw_version = proto.Field(
        proto.STRING,
        number=4,
    )


class AgentOtherDeviceId(proto.Message):
    r"""Alternate third-party device ID.

    Attributes:
        agent_id (str):
            Project ID for your smart home Action.
        device_id (str):
            Unique third-party device ID.
    """

    agent_id = proto.Field(
        proto.STRING,
        number=1,
    )
    device_id = proto.Field(
        proto.STRING,
        number=2,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
