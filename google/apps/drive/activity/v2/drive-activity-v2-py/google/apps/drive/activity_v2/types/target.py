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


from google.apps.drive.activity_v2.types import actor
from google.apps.drive.activity_v2.types import common


__protobuf__ = proto.module(
    package='google.apps.drive.activity.v2',
    manifest={
        'Target',
        'TargetReference',
        'FileComment',
        'DriveItem',
        'Owner',
        'TeamDrive',
        'Drive',
        'DriveItemReference',
        'TeamDriveReference',
        'DriveReference',
    },
)


class Target(proto.Message):
    r"""Information about the target of activity.

    Attributes:
        drive_item (google.apps.drive.activity_v2.types.DriveItem):
            The target is a Drive item.
        drive (google.apps.drive.activity_v2.types.Drive):
            The target is a shared drive.
        file_comment (google.apps.drive.activity_v2.types.FileComment):
            The target is a comment on a Drive file.
        team_drive (google.apps.drive.activity_v2.types.TeamDrive):
            This field is deprecated; please use the ``drive`` field
            instead.
    """

    drive_item = proto.Field(proto.MESSAGE, number=1, oneof='object',
        message='DriveItem',
    )

    drive = proto.Field(proto.MESSAGE, number=5, oneof='object',
        message='Drive',
    )

    file_comment = proto.Field(proto.MESSAGE, number=3, oneof='object',
        message='FileComment',
    )

    team_drive = proto.Field(proto.MESSAGE, number=2,
        message='TeamDrive',
    )


class TargetReference(proto.Message):
    r"""A lightweight reference to the target of activity.

    Attributes:
        drive_item (google.apps.drive.activity_v2.types.DriveItemReference):
            The target is a Drive item.
        drive (google.apps.drive.activity_v2.types.DriveReference):
            The target is a shared drive.
        team_drive (google.apps.drive.activity_v2.types.TeamDriveReference):
            This field is deprecated; please use the ``drive`` field
            instead.
    """

    drive_item = proto.Field(proto.MESSAGE, number=1, oneof='object',
        message='DriveItemReference',
    )

    drive = proto.Field(proto.MESSAGE, number=3, oneof='object',
        message='DriveReference',
    )

    team_drive = proto.Field(proto.MESSAGE, number=2,
        message='TeamDriveReference',
    )


class FileComment(proto.Message):
    r"""A comment on a file.

    Attributes:
        legacy_comment_id (str):
            The comment in the discussion thread. This
            identifier is an opaque string compatible with
            the Drive API; see
            https://developers.google.com/drive/v3/reference/comments/get
        legacy_discussion_id (str):
            The discussion thread to which the comment
            was added. This identifier is an opaque string
            compatible with the Drive API and references the
            first comment in a discussion; see
            https://developers.google.com/drive/v3/reference/comments/get
        link_to_discussion (str):
            The link to the discussion thread containing this comment,
            for example,
            ``https://docs.google.com/DOCUMENT_ID/edit?disco=THREAD_ID``.
        parent (google.apps.drive.activity_v2.types.DriveItem):
            The Drive item containing this comment.
    """

    legacy_comment_id = proto.Field(proto.STRING, number=1)

    legacy_discussion_id = proto.Field(proto.STRING, number=2)

    link_to_discussion = proto.Field(proto.STRING, number=3)

    parent = proto.Field(proto.MESSAGE, number=4,
        message='DriveItem',
    )


class DriveItem(proto.Message):
    r"""A Drive item, such as a file or folder.

    Attributes:
        name (str):
            The target Drive item. The format is ``items/ITEM_ID``.
        title (str):
            The title of the Drive item.
        file (google.apps.drive.activity_v2.types.DriveItem.File):
            This field is deprecated; please use the ``driveFile`` field
            instead.
        folder (google.apps.drive.activity_v2.types.DriveItem.Folder):
            This field is deprecated; please use the ``driveFolder``
            field instead.
        drive_file (google.apps.drive.activity_v2.types.DriveItem.DriveFile):
            The Drive item is a file.
        drive_folder (google.apps.drive.activity_v2.types.DriveItem.DriveFolder):
            The Drive item is a folder. Includes
            information about the type of folder.
        mime_type (str):
            The MIME type of the Drive item.  See
            https://developers.google.com/drive/v3/web/mime-
            types.
        owner (google.apps.drive.activity_v2.types.Owner):
            Information about the owner of this Drive
            item.
    """
    class File(proto.Message):
        r"""This item is deprecated; please see ``DriveFile`` instead."""

    class Folder(proto.Message):
        r"""This item is deprecated; please see ``DriveFolder`` instead.

        Attributes:
            type_ (google.apps.drive.activity_v2.types.DriveItem.Folder.Type):
                This field is deprecated; please see ``DriveFolder.type``
                instead.
        """
        class Type(proto.Enum):
            r"""This item is deprecated; please see ``DriveFolder.Type`` instead."""
            TYPE_UNSPECIFIED = 0
            MY_DRIVE_ROOT = 1
            TEAM_DRIVE_ROOT = 2
            STANDARD_FOLDER = 3

        type_ = proto.Field(proto.ENUM, number=6,
            enum='DriveItem.Folder.Type',
        )

    class DriveFile(proto.Message):
        r"""A Drive item which is a file."""

    class DriveFolder(proto.Message):
        r"""A Drive item which is a folder.

        Attributes:
            type_ (google.apps.drive.activity_v2.types.DriveItem.DriveFolder.Type):
                The type of Drive folder.
        """
        class Type(proto.Enum):
            r"""The type of a Drive folder."""
            TYPE_UNSPECIFIED = 0
            MY_DRIVE_ROOT = 1
            SHARED_DRIVE_ROOT = 2
            STANDARD_FOLDER = 3

        type_ = proto.Field(proto.ENUM, number=6,
            enum='DriveItem.DriveFolder.Type',
        )

    name = proto.Field(proto.STRING, number=1)

    title = proto.Field(proto.STRING, number=2)

    file = proto.Field(proto.MESSAGE, number=3,
        message=File,
    )

    folder = proto.Field(proto.MESSAGE, number=4,
        message=Folder,
    )

    drive_file = proto.Field(proto.MESSAGE, number=8, oneof='item_type',
        message=DriveFile,
    )

    drive_folder = proto.Field(proto.MESSAGE, number=9, oneof='item_type',
        message=DriveFolder,
    )

    mime_type = proto.Field(proto.STRING, number=6)

    owner = proto.Field(proto.MESSAGE, number=7,
        message='Owner',
    )


class Owner(proto.Message):
    r"""Information about the owner of a Drive item.

    Attributes:
        user (google.apps.drive.activity_v2.types.User):
            The user that owns the Drive item.
        drive (google.apps.drive.activity_v2.types.DriveReference):
            The drive that owns the item.
        team_drive (google.apps.drive.activity_v2.types.TeamDriveReference):
            This field is deprecated; please use the ``drive`` field
            instead.
        domain (google.apps.drive.activity_v2.types.Domain):
            The domain of the Drive item owner.
    """

    user = proto.Field(proto.MESSAGE, number=1, oneof='owner',
        message=actor.User,
    )

    drive = proto.Field(proto.MESSAGE, number=4, oneof='owner',
        message='DriveReference',
    )

    team_drive = proto.Field(proto.MESSAGE, number=2,
        message='TeamDriveReference',
    )

    domain = proto.Field(proto.MESSAGE, number=3,
        message=common.Domain,
    )


class TeamDrive(proto.Message):
    r"""This item is deprecated; please see ``Drive`` instead.

    Attributes:
        name (str):
            This field is deprecated; please see ``Drive.name`` instead.
        title (str):
            This field is deprecated; please see ``Drive.title``
            instead.
        root (google.apps.drive.activity_v2.types.DriveItem):
            This field is deprecated; please see ``Drive.root`` instead.
    """

    name = proto.Field(proto.STRING, number=1)

    title = proto.Field(proto.STRING, number=2)

    root = proto.Field(proto.MESSAGE, number=3,
        message='DriveItem',
    )


class Drive(proto.Message):
    r"""Information about a shared drive.

    Attributes:
        name (str):
            The resource name of the shared drive. The format is
            ``COLLECTION_ID/DRIVE_ID``. Clients should not assume a
            specific collection ID for this resource name.
        title (str):
            The title of the shared drive.
        root (google.apps.drive.activity_v2.types.DriveItem):
            The root of this shared drive.
    """

    name = proto.Field(proto.STRING, number=1)

    title = proto.Field(proto.STRING, number=2)

    root = proto.Field(proto.MESSAGE, number=3,
        message='DriveItem',
    )


class DriveItemReference(proto.Message):
    r"""A lightweight reference to a Drive item, such as a file or
    folder.

    Attributes:
        name (str):
            The target Drive item. The format is ``items/ITEM_ID``.
        title (str):
            The title of the Drive item.
        file (google.apps.drive.activity_v2.types.DriveItem.File):
            This field is deprecated; please use the ``driveFile`` field
            instead.
        folder (google.apps.drive.activity_v2.types.DriveItem.Folder):
            This field is deprecated; please use the ``driveFolder``
            field instead.
        drive_file (google.apps.drive.activity_v2.types.DriveItem.DriveFile):
            The Drive item is a file.
        drive_folder (google.apps.drive.activity_v2.types.DriveItem.DriveFolder):
            The Drive item is a folder. Includes
            information about the type of folder.
    """

    name = proto.Field(proto.STRING, number=1)

    title = proto.Field(proto.STRING, number=2)

    file = proto.Field(proto.MESSAGE, number=3,
        message='DriveItem.File',
    )

    folder = proto.Field(proto.MESSAGE, number=4,
        message='DriveItem.Folder',
    )

    drive_file = proto.Field(proto.MESSAGE, number=8, oneof='item_type',
        message='DriveItem.DriveFile',
    )

    drive_folder = proto.Field(proto.MESSAGE, number=9, oneof='item_type',
        message='DriveItem.DriveFolder',
    )


class TeamDriveReference(proto.Message):
    r"""This item is deprecated; please see ``DriveReference`` instead.

    Attributes:
        name (str):
            This field is deprecated; please see ``DriveReference.name``
            instead.
        title (str):
            This field is deprecated; please see
            ``DriveReference.title`` instead.
    """

    name = proto.Field(proto.STRING, number=1)

    title = proto.Field(proto.STRING, number=2)


class DriveReference(proto.Message):
    r"""A lightweight reference to a shared drive.

    Attributes:
        name (str):
            The resource name of the shared drive. The format is
            ``COLLECTION_ID/DRIVE_ID``. Clients should not assume a
            specific collection ID for this resource name.
        title (str):
            The title of the shared drive.
    """

    name = proto.Field(proto.STRING, number=1)

    title = proto.Field(proto.STRING, number=2)


__all__ = tuple(sorted(__protobuf__.manifest))
