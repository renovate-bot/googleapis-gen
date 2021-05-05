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
    package='google.home.enterprise.sdm.v1',
    manifest={
        'Device',
        'ParentRelation',
    },
)


class Device(proto.Message):
    r"""Device resource represents an instance of enterprise managed
    device in the property.

    Attributes:
        name (str):
            Required. The resource name of the device.
            For example: "enterprises/XYZ/devices/123".
        type_ (str):
            Output only. Type of the device for general
            display purposes. For example: "THERMOSTAT". The
            device type should not be used to deduce or
            infer functionality of the actual device it is
            assigned to. Instead, use the returned traits
            for the device.
        traits (google.protobuf.struct_pb2.Struct):
            Output only. Device traits.
        parent_relations (Sequence[google.home.enterprise.sdm_v1.types.ParentRelation]):
            Assignee details of the device.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    type_ = proto.Field(
        proto.STRING,
        number=2,
    )
    traits = proto.Field(
        proto.MESSAGE,
        number=4,
        message=struct_pb2.Struct,
    )
    parent_relations = proto.RepeatedField(
        proto.MESSAGE,
        number=5,
        message='ParentRelation',
    )


class ParentRelation(proto.Message):
    r"""Represents device relationships, for instance, structure/room
    to which the device is assigned to. For now this is only filled
    in the enterprise flow.

    Attributes:
        parent (str):
            Output only. The name of the relation --
            e.g., structure/room where the device is
            assigned to. For example:
            "enterprises/XYZ/structures/ABC" or
            "enterprises/XYZ/structures/ABC/rooms/123".
        display_name (str):
            Output only. The custom name of the relation
            -- e.g., structure/room where the device is
            assigned to.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    display_name = proto.Field(
        proto.STRING,
        number=2,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
