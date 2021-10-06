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

from google.home.enterprise.sdm_v1.types import device
from google.home.enterprise.sdm_v1.types import site
from google.protobuf import struct_pb2  # type: ignore


__protobuf__ = proto.module(
    package='google.home.enterprise.sdm.v1',
    manifest={
        'GetDeviceRequest',
        'ListDevicesRequest',
        'ListDevicesResponse',
        'ExecuteDeviceCommandRequest',
        'ExecuteDeviceCommandResponse',
        'GetStructureRequest',
        'ListStructuresRequest',
        'ListStructuresResponse',
        'GetRoomRequest',
        'ListRoomsRequest',
        'ListRoomsResponse',
    },
)


class GetDeviceRequest(proto.Message):
    r"""Request message for SmartDeviceManagementService.GetDevice

    Attributes:
        name (str):
            The name of the device requested. For
            example: "enterprises/XYZ/devices/123".
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class ListDevicesRequest(proto.Message):
    r"""Request message for SmartDeviceManagementService.ListDevices

    Attributes:
        parent (str):
            The parent enterprise to list devices under.
            E.g. "enterprises/XYZ".
        page_size (int):
            Optional requested page size. Server may
            return fewer devices than requested. If
            unspecified, server will pick an appropriate
            default.
        page_token (str):
            Optional token of the page to retrieve.
        filter (str):
            Optional filter to list devices.
            Filters can match the exact parent (could be a
            structure or a room):
            'parent=enterprises/XYZ/structures/jkl'
            or filter by device custom name (substring
            match): 'customName=wing'
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    page_size = proto.Field(
        proto.INT32,
        number=2,
    )
    page_token = proto.Field(
        proto.STRING,
        number=3,
    )
    filter = proto.Field(
        proto.STRING,
        number=4,
    )


class ListDevicesResponse(proto.Message):
    r"""Response message for SmartDeviceManagementService.ListDevices

    Attributes:
        devices (Sequence[google.home.enterprise.sdm_v1.types.Device]):
            The list of devices.
        next_page_token (str):
            The pagination token to retrieve the next
            page of results.
    """

    @property
    def raw_page(self):
        return self

    devices = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=device.Device,
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )


class ExecuteDeviceCommandRequest(proto.Message):
    r"""Request message for
    SmartDeviceManagementService.ExecuteDeviceCommand

    Attributes:
        name (str):
            The name of the device requested. For
            example: "enterprises/XYZ/devices/123".
        command (str):
            The command name to execute, represented by
            the fully qualified protobuf message name.
        params (google.protobuf.struct_pb2.Struct):
            The command message to execute, represented
            as a Struct.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    command = proto.Field(
        proto.STRING,
        number=2,
    )
    params = proto.Field(
        proto.MESSAGE,
        number=3,
        message=struct_pb2.Struct,
    )


class ExecuteDeviceCommandResponse(proto.Message):
    r"""Response message for
    SmartDeviceManagementService.ExecuteDeviceCommand

    Attributes:
        results (google.protobuf.struct_pb2.Struct):
            The results of executing the command.
    """

    results = proto.Field(
        proto.MESSAGE,
        number=1,
        message=struct_pb2.Struct,
    )


class GetStructureRequest(proto.Message):
    r"""Request message for SmartDeviceManagementService.GetStructure

    Attributes:
        name (str):
            The name of the structure requested. For
            example: "enterprises/XYZ/structures/ABC".
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class ListStructuresRequest(proto.Message):
    r"""Request message for
    SmartDeviceManagementService.ListStructures

    Attributes:
        parent (str):
            The parent enterprise to list structures
            under. E.g. "enterprises/XYZ".
        page_size (int):
            Requested page size. Server may return fewer
            structures than requested. If unspecified,
            server will pick an appropriate default.
        page_token (str):
            The token of the page to retrieve.
        filter (str):
            Optional filter to list structures.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    page_size = proto.Field(
        proto.INT32,
        number=2,
    )
    page_token = proto.Field(
        proto.STRING,
        number=3,
    )
    filter = proto.Field(
        proto.STRING,
        number=4,
    )


class ListStructuresResponse(proto.Message):
    r"""Response message for
    SmartDeviceManagementService.ListStructures

    Attributes:
        structures (Sequence[google.home.enterprise.sdm_v1.types.Structure]):
            The list of structures.
        next_page_token (str):
            The pagination token to retrieve the next
            page of results. If this field is omitted, there
            are no subsequent pages.
    """

    @property
    def raw_page(self):
        return self

    structures = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=site.Structure,
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )


class GetRoomRequest(proto.Message):
    r"""Request message for SmartDeviceManagementService.GetRoom

    Attributes:
        name (str):
            The name of the room requested. For example:
            "enterprises/XYZ/structures/ABC/rooms/123".
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class ListRoomsRequest(proto.Message):
    r"""Request message for SmartDeviceManagementService.ListRooms

    Attributes:
        parent (str):
            The parent resource name of the rooms
            requested. For example:
            "enterprises/XYZ/structures/ABC".
        page_size (int):
            Requested page size. Server may return fewer
            rooms than requested. If unspecified, server
            will pick an appropriate default.
        page_token (str):
            The token of the page to retrieve.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    page_size = proto.Field(
        proto.INT32,
        number=2,
    )
    page_token = proto.Field(
        proto.STRING,
        number=3,
    )


class ListRoomsResponse(proto.Message):
    r"""Response message for SmartDeviceManagementService.ListRooms

    Attributes:
        rooms (Sequence[google.home.enterprise.sdm_v1.types.Room]):
            The list of rooms.
        next_page_token (str):
            The pagination token to retrieve the next
            page of results. If this field is omitted, there
            are no subsequent pages.
    """

    @property
    def raw_page(self):
        return self

    rooms = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=site.Room,
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
