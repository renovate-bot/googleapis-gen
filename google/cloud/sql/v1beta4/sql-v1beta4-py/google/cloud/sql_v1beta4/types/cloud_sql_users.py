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

from google.protobuf import duration_pb2  # type: ignore
from google.protobuf import timestamp_pb2  # type: ignore


__protobuf__ = proto.module(
    package='google.cloud.sql.v1beta4',
    manifest={
        'SqlUsersDeleteRequest',
        'SqlUsersUpdateRequest',
        'SqlUsersInsertRequest',
        'SqlUsersListRequest',
        'UserPasswordValidationPolicy',
        'PasswordStatus',
        'User',
        'SqlServerUserDetails',
        'UsersListResponse',
    },
)


class SqlUsersDeleteRequest(proto.Message):
    r"""

    Attributes:
        host (str):
            Host of the user in the instance.
        instance (str):
            Database instance ID. This does not include
            the project ID.
        name (str):
            Name of the user in the instance.
        project (str):
            Project ID of the project that contains the
            instance.
    """

    host = proto.Field(
        proto.STRING,
        number=1,
    )
    instance = proto.Field(
        proto.STRING,
        number=2,
    )
    name = proto.Field(
        proto.STRING,
        number=3,
    )
    project = proto.Field(
        proto.STRING,
        number=4,
    )


class SqlUsersUpdateRequest(proto.Message):
    r"""

    Attributes:
        host (str):
            Optional. Host of the user in the instance.
        instance (str):
            Database instance ID. This does not include
            the project ID.
        name (str):
            Name of the user in the instance.
        project (str):
            Project ID of the project that contains the
            instance.
        body (google.cloud.sql_v1beta4.types.User):

    """

    host = proto.Field(
        proto.STRING,
        number=1,
    )
    instance = proto.Field(
        proto.STRING,
        number=2,
    )
    name = proto.Field(
        proto.STRING,
        number=3,
    )
    project = proto.Field(
        proto.STRING,
        number=4,
    )
    body = proto.Field(
        proto.MESSAGE,
        number=100,
        message='User',
    )


class SqlUsersInsertRequest(proto.Message):
    r"""

    Attributes:
        instance (str):
            Database instance ID. This does not include
            the project ID.
        project (str):
            Project ID of the project that contains the
            instance.
        body (google.cloud.sql_v1beta4.types.User):

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
        message='User',
    )


class SqlUsersListRequest(proto.Message):
    r"""

    Attributes:
        instance (str):
            Database instance ID. This does not include
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


class UserPasswordValidationPolicy(proto.Message):
    r"""User level password validation policy.

    Attributes:
        allowed_failed_attempts (int):
            Number of failed login attempts allowed
            before user get locked.
        password_expiration_duration (google.protobuf.duration_pb2.Duration):
            Expiration duration after password is
            updated.
        enable_failed_attempts_check (bool):
            If true, failed login attempts check will be
            enabled.
        status (google.cloud.sql_v1beta4.types.PasswordStatus):
            Output only. Read-only password status.
    """

    allowed_failed_attempts = proto.Field(
        proto.INT32,
        number=1,
    )
    password_expiration_duration = proto.Field(
        proto.MESSAGE,
        number=2,
        message=duration_pb2.Duration,
    )
    enable_failed_attempts_check = proto.Field(
        proto.BOOL,
        number=3,
    )
    status = proto.Field(
        proto.MESSAGE,
        number=4,
        message='PasswordStatus',
    )


class PasswordStatus(proto.Message):
    r"""Read-only password status.

    Attributes:
        locked (bool):
            If true, user does not have login privileges.
        password_expiration_time (google.protobuf.timestamp_pb2.Timestamp):
            The expiration time of the current password.
    """

    locked = proto.Field(
        proto.BOOL,
        number=1,
    )
    password_expiration_time = proto.Field(
        proto.MESSAGE,
        number=2,
        message=timestamp_pb2.Timestamp,
    )


class User(proto.Message):
    r"""A Cloud SQL user resource.

    .. _oneof: https://proto-plus-python.readthedocs.io/en/stable/fields.html#oneofs-mutually-exclusive-fields

    Attributes:
        kind (str):
            This is always <b>sql#user</b>.
        password (str):
            The password for the user.
        etag (str):
            This field is deprecated and will be removed
            from a future version of the API.
        name (str):
            The name of the user in the Cloud SQL instance. Can be
            omitted for **update** since it is already specified in the
            URL.
        host (str):
            Optional. The host name from which the user can connect. For
            **insert** operations, host defaults to an empty string. For
            **update** operations, host is specified as part of the
            request URL. The host name cannot be updated after
            insertion. For a MySQL instance, it's required; for a
            PostgreSQL or SQL Server instance, it's optional.
        instance (str):
            The name of the Cloud SQL instance. This does
            not include the project ID. Can be omitted for
            <b>update</b> since it is already specified on
            the URL.
        project (str):
            The project ID of the project containing the
            Cloud SQL database. The Google apps domain is
            prefixed if applicable. Can be omitted for
            <b>update</b> since it is already specified on
            the URL.
        type_ (google.cloud.sql_v1beta4.types.User.SqlUserType):
            The user type. It determines the method to
            authenticate the user during login. The default
            is the database's built-in user type.
        sqlserver_user_details (google.cloud.sql_v1beta4.types.SqlServerUserDetails):

            This field is a member of `oneof`_ ``user_details``.
        password_policy (google.cloud.sql_v1beta4.types.UserPasswordValidationPolicy):
            User level password validation policy.
    """
    class SqlUserType(proto.Enum):
        r"""The user type."""
        BUILT_IN = 0
        CLOUD_IAM_USER = 1
        CLOUD_IAM_SERVICE_ACCOUNT = 2

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    password = proto.Field(
        proto.STRING,
        number=2,
    )
    etag = proto.Field(
        proto.STRING,
        number=3,
    )
    name = proto.Field(
        proto.STRING,
        number=4,
    )
    host = proto.Field(
        proto.STRING,
        number=5,
    )
    instance = proto.Field(
        proto.STRING,
        number=6,
    )
    project = proto.Field(
        proto.STRING,
        number=7,
    )
    type_ = proto.Field(
        proto.ENUM,
        number=8,
        enum=SqlUserType,
    )
    sqlserver_user_details = proto.Field(
        proto.MESSAGE,
        number=9,
        oneof='user_details',
        message='SqlServerUserDetails',
    )
    password_policy = proto.Field(
        proto.MESSAGE,
        number=12,
        message='UserPasswordValidationPolicy',
    )


class SqlServerUserDetails(proto.Message):
    r"""Represents a Sql Server user on the Cloud SQL instance.

    Attributes:
        disabled (bool):
            If the user has been disabled
        server_roles (Sequence[str]):
            The server roles for this user
    """

    disabled = proto.Field(
        proto.BOOL,
        number=1,
    )
    server_roles = proto.RepeatedField(
        proto.STRING,
        number=2,
    )


class UsersListResponse(proto.Message):
    r"""User list response.

    Attributes:
        kind (str):
            This is always <b>sql#usersList</b>.
        items (Sequence[google.cloud.sql_v1beta4.types.User]):
            List of user resources in the instance.
        next_page_token (str):
            An identifier that uniquely identifies the
            operation. You can use this identifier to
            retrieve the Operations resource that has
            information about the operation.
    """

    @property
    def raw_page(self):
        return self

    kind = proto.Field(
        proto.STRING,
        number=1,
    )
    items = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message='User',
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=3,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
