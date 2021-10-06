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

from google.protobuf import timestamp_pb2  # type: ignore


__protobuf__ = proto.module(
    package='google.apps.drive.activity.v2',
    manifest={
        'TimeRange',
        'Group',
        'Domain',
    },
)


class TimeRange(proto.Message):
    r"""Information about time ranges.

    Attributes:
        start_time (google.protobuf.timestamp_pb2.Timestamp):
            The start of the time range.
        end_time (google.protobuf.timestamp_pb2.Timestamp):
            The end of the time range.
    """

    start_time = proto.Field(
        proto.MESSAGE,
        number=1,
        message=timestamp_pb2.Timestamp,
    )
    end_time = proto.Field(
        proto.MESSAGE,
        number=2,
        message=timestamp_pb2.Timestamp,
    )


class Group(proto.Message):
    r"""Information about a group.

    Attributes:
        email (str):
            The email address of the group.
        title (str):
            The title of the group.
    """

    email = proto.Field(
        proto.STRING,
        number=1,
    )
    title = proto.Field(
        proto.STRING,
        number=2,
    )


class Domain(proto.Message):
    r"""Information about a domain.

    Attributes:
        name (str):
            The name of the domain, e.g. ``google.com``.
        legacy_id (str):
            An opaque string used to identify this
            domain.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    legacy_id = proto.Field(
        proto.STRING,
        number=3,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
