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

from google.apps.drive.activity_v2.services.drive_activity_service.async_client import DriveActivityServiceAsyncClient
from google.apps.drive.activity_v2.services.drive_activity_service.client import DriveActivityServiceClient
from google.apps.drive.activity_v2.types.action import Action
from google.apps.drive.activity_v2.types.action import ActionDetail
from google.apps.drive.activity_v2.types.action import ApplicationReference
from google.apps.drive.activity_v2.types.action import Comment
from google.apps.drive.activity_v2.types.action import Create
from google.apps.drive.activity_v2.types.action import DataLeakPreventionChange
from google.apps.drive.activity_v2.types.action import Delete
from google.apps.drive.activity_v2.types.action import Edit
from google.apps.drive.activity_v2.types.action import Move
from google.apps.drive.activity_v2.types.action import Permission
from google.apps.drive.activity_v2.types.action import PermissionChange
from google.apps.drive.activity_v2.types.action import Rename
from google.apps.drive.activity_v2.types.action import Restore
from google.apps.drive.activity_v2.types.action import SettingsChange
from google.apps.drive.activity_v2.types.actor import Actor
from google.apps.drive.activity_v2.types.actor import Administrator
from google.apps.drive.activity_v2.types.actor import AnonymousUser
from google.apps.drive.activity_v2.types.actor import Impersonation
from google.apps.drive.activity_v2.types.actor import SystemEvent
from google.apps.drive.activity_v2.types.actor import User
from google.apps.drive.activity_v2.types.common import Domain
from google.apps.drive.activity_v2.types.common import Group
from google.apps.drive.activity_v2.types.common import TimeRange
from google.apps.drive.activity_v2.types.query_drive_activity_request import ConsolidationStrategy
from google.apps.drive.activity_v2.types.query_drive_activity_request import QueryDriveActivityRequest
from google.apps.drive.activity_v2.types.query_drive_activity_response import DriveActivity
from google.apps.drive.activity_v2.types.query_drive_activity_response import QueryDriveActivityResponse
from google.apps.drive.activity_v2.types.target import Drive
from google.apps.drive.activity_v2.types.target import DriveItem
from google.apps.drive.activity_v2.types.target import DriveItemReference
from google.apps.drive.activity_v2.types.target import DriveReference
from google.apps.drive.activity_v2.types.target import FileComment
from google.apps.drive.activity_v2.types.target import Owner
from google.apps.drive.activity_v2.types.target import Target
from google.apps.drive.activity_v2.types.target import TargetReference
from google.apps.drive.activity_v2.types.target import TeamDrive
from google.apps.drive.activity_v2.types.target import TeamDriveReference

__all__ = (
    'Action',
    'ActionDetail',
    'Actor',
    'Administrator',
    'AnonymousUser',
    'ApplicationReference',
    'Comment',
    'ConsolidationStrategy',
    'Create',
    'DataLeakPreventionChange',
    'Delete',
    'Domain',
    'Drive',
    'DriveActivity',
    'DriveActivityServiceAsyncClient',
    'DriveActivityServiceClient',
    'DriveItem',
    'DriveItemReference',
    'DriveReference',
    'Edit',
    'FileComment',
    'Group',
    'Impersonation',
    'Move',
    'Owner',
    'Permission',
    'PermissionChange',
    'QueryDriveActivityRequest',
    'QueryDriveActivityResponse',
    'Rename',
    'Restore',
    'SettingsChange',
    'SystemEvent',
    'Target',
    'TargetReference',
    'TeamDrive',
    'TeamDriveReference',
    'TimeRange',
    'User',
)
