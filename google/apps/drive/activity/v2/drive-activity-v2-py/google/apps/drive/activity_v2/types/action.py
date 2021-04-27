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

from google.apps.drive.activity_v2.types import actor as gada_actor
from google.apps.drive.activity_v2.types import common
from google.apps.drive.activity_v2.types import target as gada_target
from google.protobuf import timestamp_pb2 as gp_timestamp  # type: ignore


__protobuf__ = proto.module(
    package='google.apps.drive.activity.v2',
    manifest={
        'Action',
        'ActionDetail',
        'Create',
        'Edit',
        'Move',
        'Rename',
        'Delete',
        'Restore',
        'PermissionChange',
        'Permission',
        'Comment',
        'DataLeakPreventionChange',
        'ApplicationReference',
        'SettingsChange',
    },
)


class Action(proto.Message):
    r"""Information about the action.
    Attributes:
        detail (google.apps.drive.activity_v2.types.ActionDetail):
            The type and detailed information about the
            action.
        actor (google.apps.drive.activity_v2.types.Actor):
            The actor responsible for this action (or
            empty if all actors are responsible).
        target (google.apps.drive.activity_v2.types.Target):
            The target this action affects (or empty if
            affecting all targets). This represents the
            state of the target immediately after this
            action occurred.
        timestamp (google.protobuf.timestamp_pb2.Timestamp):
            The action occurred at this specific time.
        time_range (google.apps.drive.activity_v2.types.TimeRange):
            The action occurred over this time range.
    """

    detail = proto.Field(
        proto.MESSAGE,
        number=1,
        message='ActionDetail',
    )
    actor = proto.Field(
        proto.MESSAGE,
        number=3,
        message=gada_actor.Actor,
    )
    target = proto.Field(
        proto.MESSAGE,
        number=4,
        message=gada_target.Target,
    )
    timestamp = proto.Field(
        proto.MESSAGE,
        number=5,
        oneof='time',
        message=gp_timestamp.Timestamp,
    )
    time_range = proto.Field(
        proto.MESSAGE,
        number=6,
        oneof='time',
        message=common.TimeRange,
    )


class ActionDetail(proto.Message):
    r"""Data describing the type and additional information of an
    action.

    Attributes:
        create (google.apps.drive.activity_v2.types.Create):
            An object was created.
        edit (google.apps.drive.activity_v2.types.Edit):
            An object was edited.
        move (google.apps.drive.activity_v2.types.Move):
            An object was moved.
        rename (google.apps.drive.activity_v2.types.Rename):
            An object was renamed.
        delete (google.apps.drive.activity_v2.types.Delete):
            An object was deleted.
        restore (google.apps.drive.activity_v2.types.Restore):
            A deleted object was restored.
        permission_change (google.apps.drive.activity_v2.types.PermissionChange):
            The permission on an object was changed.
        comment (google.apps.drive.activity_v2.types.Comment):
            A change about comments was made.
        dlp_change (google.apps.drive.activity_v2.types.DataLeakPreventionChange):
            A change happened in data leak prevention
            status.
        reference (google.apps.drive.activity_v2.types.ApplicationReference):
            An object was referenced in an application
            outside of Drive/Docs.
        settings_change (google.apps.drive.activity_v2.types.SettingsChange):
            Settings were changed.
    """

    create = proto.Field(
        proto.MESSAGE,
        number=1,
        oneof='action_detail',
        message='Create',
    )
    edit = proto.Field(
        proto.MESSAGE,
        number=2,
        oneof='action_detail',
        message='Edit',
    )
    move = proto.Field(
        proto.MESSAGE,
        number=3,
        oneof='action_detail',
        message='Move',
    )
    rename = proto.Field(
        proto.MESSAGE,
        number=4,
        oneof='action_detail',
        message='Rename',
    )
    delete = proto.Field(
        proto.MESSAGE,
        number=5,
        oneof='action_detail',
        message='Delete',
    )
    restore = proto.Field(
        proto.MESSAGE,
        number=6,
        oneof='action_detail',
        message='Restore',
    )
    permission_change = proto.Field(
        proto.MESSAGE,
        number=7,
        oneof='action_detail',
        message='PermissionChange',
    )
    comment = proto.Field(
        proto.MESSAGE,
        number=8,
        oneof='action_detail',
        message='Comment',
    )
    dlp_change = proto.Field(
        proto.MESSAGE,
        number=9,
        oneof='action_detail',
        message='DataLeakPreventionChange',
    )
    reference = proto.Field(
        proto.MESSAGE,
        number=12,
        oneof='action_detail',
        message='ApplicationReference',
    )
    settings_change = proto.Field(
        proto.MESSAGE,
        number=13,
        oneof='action_detail',
        message='SettingsChange',
    )


class Create(proto.Message):
    r"""An object was created.
    Attributes:
        new (google.apps.drive.activity_v2.types.Create.New):
            If present, indicates the object was newly
            created (e.g. as a blank document), not derived
            from a Drive object or external object.
        upload (google.apps.drive.activity_v2.types.Create.Upload):
            If present, indicates the object originated
            externally and was uploaded to Drive.
        copy (google.apps.drive.activity_v2.types.Create.Copy):
            If present, indicates the object was created
            by copying an existing Drive object.
    """

    class New(proto.Message):
        r"""An object was created from scratch.    """

    class Upload(proto.Message):
        r"""An object was uploaded into Drive.    """

    class Copy(proto.Message):
        r"""An object was created by copying an existing object.
        Attributes:
            original_object (google.apps.drive.activity_v2.types.TargetReference):
                The original object.
        """

        original_object = proto.Field(
            proto.MESSAGE,
            number=1,
            message=gada_target.TargetReference,
        )

    new = proto.Field(
        proto.MESSAGE,
        number=1,
        oneof='origin',
        message=New,
    )
    upload = proto.Field(
        proto.MESSAGE,
        number=2,
        oneof='origin',
        message=Upload,
    )
    copy = proto.Field(
        proto.MESSAGE,
        number=3,
        oneof='origin',
        message=Copy,
    )


class Edit(proto.Message):
    r"""An empty message indicating an object was edited.    """


class Move(proto.Message):
    r"""An object was moved.
    Attributes:
        added_parents (Sequence[google.apps.drive.activity_v2.types.TargetReference]):
            The added parent object(s).
        removed_parents (Sequence[google.apps.drive.activity_v2.types.TargetReference]):
            The removed parent object(s).
    """

    added_parents = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=gada_target.TargetReference,
    )
    removed_parents = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message=gada_target.TargetReference,
    )


class Rename(proto.Message):
    r"""An object was renamed.
    Attributes:
        old_title (str):
            The previous title of the drive object.
        new_title (str):
            The new title of the drive object.
    """

    old_title = proto.Field(
        proto.STRING,
        number=1,
    )
    new_title = proto.Field(
        proto.STRING,
        number=2,
    )


class Delete(proto.Message):
    r"""An object was deleted.
    Attributes:
        type_ (google.apps.drive.activity_v2.types.Delete.Type):
            The type of delete action taken.
    """
    class Type(proto.Enum):
        r"""The type of deletion."""
        TYPE_UNSPECIFIED = 0
        TRASH = 1
        PERMANENT_DELETE = 2

    type_ = proto.Field(
        proto.ENUM,
        number=1,
        enum=Type,
    )


class Restore(proto.Message):
    r"""A deleted object was restored.
    Attributes:
        type_ (google.apps.drive.activity_v2.types.Restore.Type):
            The type of restore action taken.
    """
    class Type(proto.Enum):
        r"""The type of restoration."""
        TYPE_UNSPECIFIED = 0
        UNTRASH = 1

    type_ = proto.Field(
        proto.ENUM,
        number=1,
        enum=Type,
    )


class PermissionChange(proto.Message):
    r"""A change of the permission setting on an item.
    Attributes:
        added_permissions (Sequence[google.apps.drive.activity_v2.types.Permission]):
            The set of permissions added by this change.
        removed_permissions (Sequence[google.apps.drive.activity_v2.types.Permission]):
            The set of permissions removed by this
            change.
    """

    added_permissions = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='Permission',
    )
    removed_permissions = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message='Permission',
    )


class Permission(proto.Message):
    r"""The permission setting of an object.
    Attributes:
        role (google.apps.drive.activity_v2.types.Permission.Role):
            Indicates the `Google Drive permissions
            role <https://developers.google.com/drive/web/manage-sharing#roles>`__.
            The role determines a user's ability to read, write, and
            comment on items.
        user (google.apps.drive.activity_v2.types.User):
            The user to whom this permission applies.
        group (google.apps.drive.activity_v2.types.Group):
            The group to whom this permission applies.
        domain (google.apps.drive.activity_v2.types.Domain):
            The domain to whom this permission applies.
        anyone (google.apps.drive.activity_v2.types.Permission.Anyone):
            If set, this permission applies to anyone,
            even logged out users.
        allow_discovery (bool):
            If true, the item can be discovered (e.g. in
            the user's "Shared with me" collection) without
            needing a link to the item.
    """
    class Role(proto.Enum):
        r"""The `Google Drive permissions
        roles <https://developers.google.com/drive/web/manage-sharing#roles>`__.
        """
        ROLE_UNSPECIFIED = 0
        OWNER = 1
        ORGANIZER = 2
        FILE_ORGANIZER = 3
        EDITOR = 4
        COMMENTER = 5
        VIEWER = 6
        PUBLISHED_VIEWER = 7

    class Anyone(proto.Message):
        r"""Represents any user (including a logged out user).    """

    role = proto.Field(
        proto.ENUM,
        number=1,
        enum=Role,
    )
    user = proto.Field(
        proto.MESSAGE,
        number=2,
        oneof='scope',
        message=gada_actor.User,
    )
    group = proto.Field(
        proto.MESSAGE,
        number=3,
        oneof='scope',
        message=common.Group,
    )
    domain = proto.Field(
        proto.MESSAGE,
        number=4,
        oneof='scope',
        message=common.Domain,
    )
    anyone = proto.Field(
        proto.MESSAGE,
        number=5,
        oneof='scope',
        message=Anyone,
    )
    allow_discovery = proto.Field(
        proto.BOOL,
        number=6,
    )


class Comment(proto.Message):
    r"""A change about comments on an object.
    Attributes:
        post (google.apps.drive.activity_v2.types.Comment.Post):
            A change on a regular posted comment.
        assignment (google.apps.drive.activity_v2.types.Comment.Assignment):
            A change on an assignment.
        suggestion (google.apps.drive.activity_v2.types.Comment.Suggestion):
            A change on a suggestion.
        mentioned_users (Sequence[google.apps.drive.activity_v2.types.User]):
            Users who are mentioned in this comment.
    """

    class Post(proto.Message):
        r"""A regular posted comment.
        Attributes:
            subtype (google.apps.drive.activity_v2.types.Comment.Post.Subtype):
                The sub-type of this event.
        """
        class Subtype(proto.Enum):
            r"""More detailed information about the change."""
            SUBTYPE_UNSPECIFIED = 0
            ADDED = 1
            DELETED = 2
            REPLY_ADDED = 3
            REPLY_DELETED = 4
            RESOLVED = 5
            REOPENED = 6

        subtype = proto.Field(
            proto.ENUM,
            number=1,
            enum='Comment.Post.Subtype',
        )

    class Assignment(proto.Message):
        r"""A comment with an assignment.
        Attributes:
            subtype (google.apps.drive.activity_v2.types.Comment.Assignment.Subtype):
                The sub-type of this event.
            assigned_user (google.apps.drive.activity_v2.types.User):
                The user to whom the comment was assigned.
        """
        class Subtype(proto.Enum):
            r"""More detailed information about the change."""
            SUBTYPE_UNSPECIFIED = 0
            ADDED = 1
            DELETED = 2
            REPLY_ADDED = 3
            REPLY_DELETED = 4
            RESOLVED = 5
            REOPENED = 6
            REASSIGNED = 7

        subtype = proto.Field(
            proto.ENUM,
            number=1,
            enum='Comment.Assignment.Subtype',
        )
        assigned_user = proto.Field(
            proto.MESSAGE,
            number=7,
            message=gada_actor.User,
        )

    class Suggestion(proto.Message):
        r"""A suggestion.
        Attributes:
            subtype (google.apps.drive.activity_v2.types.Comment.Suggestion.Subtype):
                The sub-type of this event.
        """
        class Subtype(proto.Enum):
            r"""More detailed information about the change."""
            SUBTYPE_UNSPECIFIED = 0
            ADDED = 1
            DELETED = 2
            REPLY_ADDED = 3
            REPLY_DELETED = 4
            ACCEPTED = 7
            REJECTED = 8
            ACCEPT_DELETED = 9
            REJECT_DELETED = 10

        subtype = proto.Field(
            proto.ENUM,
            number=1,
            enum='Comment.Suggestion.Subtype',
        )

    post = proto.Field(
        proto.MESSAGE,
        number=1,
        oneof='type',
        message=Post,
    )
    assignment = proto.Field(
        proto.MESSAGE,
        number=2,
        oneof='type',
        message=Assignment,
    )
    suggestion = proto.Field(
        proto.MESSAGE,
        number=3,
        oneof='type',
        message=Suggestion,
    )
    mentioned_users = proto.RepeatedField(
        proto.MESSAGE,
        number=7,
        message=gada_actor.User,
    )


class DataLeakPreventionChange(proto.Message):
    r"""A change in the object's data leak prevention status.
    Attributes:
        type_ (google.apps.drive.activity_v2.types.DataLeakPreventionChange.Type):
            The type of Data Leak Prevention (DLP)
            change.
    """
    class Type(proto.Enum):
        r"""The type of the change."""
        TYPE_UNSPECIFIED = 0
        FLAGGED = 1
        CLEARED = 2

    type_ = proto.Field(
        proto.ENUM,
        number=1,
        enum=Type,
    )


class ApplicationReference(proto.Message):
    r"""Activity in applications other than Drive.
    Attributes:
        type_ (google.apps.drive.activity_v2.types.ApplicationReference.Type):
            The reference type corresponding to this
            event.
    """
    class Type(proto.Enum):
        r"""The type of the action."""
        UNSPECIFIED_REFERENCE_TYPE = 0
        LINK = 1
        DISCUSS = 2

    type_ = proto.Field(
        proto.ENUM,
        number=1,
        enum=Type,
    )


class SettingsChange(proto.Message):
    r"""Information about settings changes.
    Attributes:
        restriction_changes (Sequence[google.apps.drive.activity_v2.types.SettingsChange.RestrictionChange]):
            The set of changes made to restrictions.
    """

    class RestrictionChange(proto.Message):
        r"""Information about restriction policy changes to a feature.
        Attributes:
            feature (google.apps.drive.activity_v2.types.SettingsChange.RestrictionChange.Feature):
                The feature which had a change in restriction
                policy.
            new_restriction (google.apps.drive.activity_v2.types.SettingsChange.RestrictionChange.Restriction):
                The restriction in place after the change.
        """
        class Feature(proto.Enum):
            r"""The feature which had changes to its restriction policy."""
            FEATURE_UNSPECIFIED = 0
            SHARING_OUTSIDE_DOMAIN = 1
            DIRECT_SHARING = 2
            ITEM_DUPLICATION = 3
            DRIVE_FILE_STREAM = 4

        class Restriction(proto.Enum):
            r"""The restriction applicable to a feature."""
            RESTRICTION_UNSPECIFIED = 0
            UNRESTRICTED = 1
            FULLY_RESTRICTED = 2

        feature = proto.Field(
            proto.ENUM,
            number=1,
            enum='SettingsChange.RestrictionChange.Feature',
        )
        new_restriction = proto.Field(
            proto.ENUM,
            number=2,
            enum='SettingsChange.RestrictionChange.Restriction',
        )

    restriction_changes = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=RestrictionChange,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
