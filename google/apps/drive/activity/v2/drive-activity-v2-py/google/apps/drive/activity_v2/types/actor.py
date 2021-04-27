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


__protobuf__ = proto.module(
    package='google.apps.drive.activity.v2',
    manifest={
        'Actor',
        'User',
        'AnonymousUser',
        'Impersonation',
        'SystemEvent',
        'Administrator',
    },
)


class Actor(proto.Message):
    r"""The actor of a Drive activity.
    Attributes:
        user (google.apps.drive.activity_v2.types.User):
            An end user.
        anonymous (google.apps.drive.activity_v2.types.AnonymousUser):
            An anonymous user.
        impersonation (google.apps.drive.activity_v2.types.Impersonation):
            An account acting on behalf of another.
        system (google.apps.drive.activity_v2.types.SystemEvent):
            A non-user actor (i.e. system triggered).
        administrator (google.apps.drive.activity_v2.types.Administrator):
            An administrator.
    """

    user = proto.Field(
        proto.MESSAGE,
        number=1,
        oneof='type',
        message='User',
    )
    anonymous = proto.Field(
        proto.MESSAGE,
        number=2,
        oneof='type',
        message='AnonymousUser',
    )
    impersonation = proto.Field(
        proto.MESSAGE,
        number=3,
        oneof='type',
        message='Impersonation',
    )
    system = proto.Field(
        proto.MESSAGE,
        number=4,
        oneof='type',
        message='SystemEvent',
    )
    administrator = proto.Field(
        proto.MESSAGE,
        number=5,
        oneof='type',
        message='Administrator',
    )


class User(proto.Message):
    r"""Information about an end user.
    Attributes:
        known_user (google.apps.drive.activity_v2.types.User.KnownUser):
            A known user.
        deleted_user (google.apps.drive.activity_v2.types.User.DeletedUser):
            A user whose account has since been deleted.
        unknown_user (google.apps.drive.activity_v2.types.User.UnknownUser):
            A user about whom nothing is currently known.
    """

    class KnownUser(proto.Message):
        r"""A known user.
        Attributes:
            person_name (str):
                The identifier for this user that can be used with the
                People API to get more information. The format is
                ``people/ACCOUNT_ID``. See
                https://developers.google.com/people/.
            is_current_user (bool):
                True if this is the user making the request.
        """

        person_name = proto.Field(
            proto.STRING,
            number=1,
        )
        is_current_user = proto.Field(
            proto.BOOL,
            number=2,
        )

    class DeletedUser(proto.Message):
        r"""A user whose account has since been deleted.    """

    class UnknownUser(proto.Message):
        r"""A user about whom nothing is currently known.    """

    known_user = proto.Field(
        proto.MESSAGE,
        number=2,
        oneof='type',
        message=KnownUser,
    )
    deleted_user = proto.Field(
        proto.MESSAGE,
        number=3,
        oneof='type',
        message=DeletedUser,
    )
    unknown_user = proto.Field(
        proto.MESSAGE,
        number=4,
        oneof='type',
        message=UnknownUser,
    )


class AnonymousUser(proto.Message):
    r"""Empty message representing an anonymous user or indicating
    the authenticated user should be anonymized.
        """


class Impersonation(proto.Message):
    r"""Information about an impersonation, where an admin acts on
    behalf of an end user. Information about the acting admin is not
    currently available.

    Attributes:
        impersonated_user (google.apps.drive.activity_v2.types.User):
            The impersonated user.
    """

    impersonated_user = proto.Field(
        proto.MESSAGE,
        number=1,
        message='User',
    )


class SystemEvent(proto.Message):
    r"""Event triggered by system operations instead of end users.
    Attributes:
        type_ (google.apps.drive.activity_v2.types.SystemEvent.Type):
            The type of the system event that may
            triggered activity.
    """
    class Type(proto.Enum):
        r"""The types of system events that may trigger activity."""
        TYPE_UNSPECIFIED = 0
        USER_DELETION = 1
        TRASH_AUTO_PURGE = 2

    type_ = proto.Field(
        proto.ENUM,
        number=1,
        enum=Type,
    )


class Administrator(proto.Message):
    r"""Empty message representing an administrator.    """


__all__ = tuple(sorted(__protobuf__.manifest))
