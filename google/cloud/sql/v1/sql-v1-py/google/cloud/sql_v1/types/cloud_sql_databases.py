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


__protobuf__ = proto.module(
    package='google.cloud.sql.v1',
    manifest={
        'SqlDatabasesDeleteRequest',
        'SqlDatabasesGetRequest',
        'SqlDatabasesInsertRequest',
        'SqlDatabasesListRequest',
        'SqlDatabasesUpdateRequest',
        'DatabasesListResponse',
    },
)


class SqlDatabasesDeleteRequest(proto.Message):
    r"""Database delete request.
    Attributes:
        database (str):
            Name of the database to be deleted in the
            instance.
        instance (str):
            Database instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
    """

    database = proto.Field(
        proto.STRING,
        number=1,
    )
    instance = proto.Field(
        proto.STRING,
        number=2,
    )
    project = proto.Field(
        proto.STRING,
        number=3,
    )


class SqlDatabasesGetRequest(proto.Message):
    r"""Database get request.
    Attributes:
        database (str):
            Name of the database in the instance.
        instance (str):
            Database instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
    """

    database = proto.Field(
        proto.STRING,
        number=1,
    )
    instance = proto.Field(
        proto.STRING,
        number=2,
    )
    project = proto.Field(
        proto.STRING,
        number=3,
    )


class SqlDatabasesInsertRequest(proto.Message):
    r"""Database insert request.
    Attributes:
        instance (str):
            Database instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
        body (google.cloud.sql_v1.types.Database):

    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )
    body = proto.Field(
        proto.MESSAGE,
        number=100,
        message=cloud_sql_resources.Database,
    )


class SqlDatabasesListRequest(proto.Message):
    r"""Database list request.
    Attributes:
        instance (str):
            Cloud SQL instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
    """

    instance = proto.Field(
        proto.STRING,
        number=1,
    )
    project = proto.Field(
        proto.STRING,
        number=2,
    )


class SqlDatabasesUpdateRequest(proto.Message):
    r"""Database update request.
    Attributes:
        database (str):
            Name of the database to be updated in the
            instance.
        instance (str):
            Database instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
        body (google.cloud.sql_v1.types.Database):

    """

    database = proto.Field(
        proto.STRING,
        number=1,
    )
    instance = proto.Field(
        proto.STRING,
        number=2,
    )
    project = proto.Field(
        proto.STRING,
        number=3,
    )
    body = proto.Field(
        proto.MESSAGE,
        number=100,
        message=cloud_sql_resources.Database,
    )


class DatabasesListResponse(proto.Message):
    r"""Database list response.
    Attributes:
        kind (str):
            This is always **sql#databasesList**.
        items (Sequence[google.cloud.sql_v1.types.Database]):
            List of database resources in the instance.
    """

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    items = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message=cloud_sql_resources.Database,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
