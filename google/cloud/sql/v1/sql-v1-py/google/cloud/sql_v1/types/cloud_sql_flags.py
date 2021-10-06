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

from google.cloud.sql_v1.types import cloud_sql_resources
from google.protobuf import wrappers_pb2  # type: ignore


__protobuf__ = proto.module(
    package='google.cloud.sql.v1',
    manifest={
        'SqlFlagType',
        'SqlFlagsListRequest',
        'FlagsListResponse',
        'Flag',
    },
)


class SqlFlagType(proto.Enum):
    r""""""
    SQL_FLAG_TYPE_UNSPECIFIED = 0
    BOOLEAN = 1
    STRING = 2
    INTEGER = 3
    NONE = 4
    MYSQL_TIMEZONE_OFFSET = 5
    FLOAT = 6
    REPEATED_STRING = 7


class SqlFlagsListRequest(proto.Message):
    r"""Flags list request.

    Attributes:
        database_version (str):
            Database type and version you want to
            retrieve flags for. By default, this method
            returns flags for all database types and
            versions.
    """

    database_version = proto.Field(
        proto.STRING,
        number=1,
    )


class FlagsListResponse(proto.Message):
    r"""Flags list response.

    Attributes:
        kind (str):
            This is always **sql#flagsList**.
        items (Sequence[google.cloud.sql_v1.types.Flag]):
            List of flags.
    """

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    items = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message='Flag',
    )


class Flag(proto.Message):
    r"""A flag resource.

    Attributes:
        name (str):
            This is the name of the flag. Flag names always use
            underscores, not hyphens, for example:
            **max_allowed_packet**
        type_ (google.cloud.sql_v1.types.SqlFlagType):
            The type of the flag. Flags are typed to being **BOOLEAN**,
            **STRING**, **INTEGER** or **NONE**. **NONE** is used for
            flags which do not take a value, such as
            **skip_grant_tables**.
        applies_to (Sequence[google.cloud.sql_v1.types.SqlDatabaseVersion]):
            The database version this flag applies to. Can be
            **MYSQL_8_0**, **MYSQL_5_6**, or **MYSQL_5_7**.
        allowed_string_values (Sequence[str]):
            For **STRING** flags, a list of strings that the value can
            be set to.
        min_value (google.protobuf.wrappers_pb2.Int64Value):
            For **INTEGER** flags, the minimum allowed value.
        max_value (google.protobuf.wrappers_pb2.Int64Value):
            For **INTEGER** flags, the maximum allowed value.
        requires_restart (google.protobuf.wrappers_pb2.BoolValue):
            Indicates whether changing this flag will
            trigger a database restart. Only applicable to
            Second Generation instances.
        kind (str):
            This is always **sql#flag**.
        in_beta (google.protobuf.wrappers_pb2.BoolValue):
            Whether or not the flag is considered in
            beta.
        allowed_int_values (Sequence[int]):
            Use this field if only certain integers are accepted. Can be
            combined with min_value and max_value to add additional
            values.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    type_ = proto.Field(
        proto.ENUM,
        number=2,
        enum='SqlFlagType',
    )
    applies_to = proto.RepeatedField(
        proto.ENUM,
        number=3,
        enum=cloud_sql_resources.SqlDatabaseVersion,
    )
    allowed_string_values = proto.RepeatedField(
        proto.STRING,
        number=4,
    )
    min_value = proto.Field(
        proto.MESSAGE,
        number=5,
        message=wrappers_pb2.Int64Value,
    )
    max_value = proto.Field(
        proto.MESSAGE,
        number=6,
        message=wrappers_pb2.Int64Value,
    )
    requires_restart = proto.Field(
        proto.MESSAGE,
        number=7,
        message=wrappers_pb2.BoolValue,
    )
    kind = proto.Field(
        proto.STRING,
        number=8,
    )
    in_beta = proto.Field(
        proto.MESSAGE,
        number=9,
        message=wrappers_pb2.BoolValue,
    )
    allowed_int_values = proto.RepeatedField(
        proto.INT64,
        number=10,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
