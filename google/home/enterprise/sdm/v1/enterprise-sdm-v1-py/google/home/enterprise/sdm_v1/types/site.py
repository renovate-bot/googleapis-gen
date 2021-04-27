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

from google.protobuf import struct_pb2 as struct  # type: ignore


__protobuf__ = proto.module(
    package='google.home.enterprise.sdm.v1',
    manifest={
        'Structure',
        'Room',
    },
)


class Structure(proto.Message):
    r"""Structure resource represents an instance of enterprise
    managed home or hotel room.

    Attributes:
        name (str):
            Output only. The resource name of the
            structure. For example:
            "enterprises/XYZ/structures/ABC".
        traits (google.protobuf.struct_pb2.Struct):
            Structure traits.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    traits = proto.Field(
        proto.MESSAGE,
        number=2,
        message=struct.Struct,
    )


class Room(proto.Message):
    r"""Room resource represents an instance of sub-space within a
    structure such as rooms in a hotel suite or rental apartment.

    Attributes:
        name (str):
            Output only. The resource name of the room.
            For example:
            "enterprises/XYZ/structures/ABC/rooms/123".
        traits (google.protobuf.struct_pb2.Struct):
            Room traits.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    traits = proto.Field(
        proto.MESSAGE,
        number=2,
        message=struct.Struct,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
