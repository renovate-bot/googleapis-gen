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

from google.apps.drive.activity_v2.types import action
from google.apps.drive.activity_v2.types import actor
from google.apps.drive.activity_v2.types import common
from google.apps.drive.activity_v2.types import target
from google.protobuf import timestamp_pb2 as gp_timestamp  # type: ignore


__protobuf__ = proto.module(
    package='google.apps.drive.activity.v2',
    manifest={
        'QueryDriveActivityResponse',
        'DriveActivity',
    },
)


class QueryDriveActivityResponse(proto.Message):
    r"""Response message for querying Drive activity.
    Attributes:
        activities (Sequence[google.apps.drive.activity_v2.types.DriveActivity]):
            List of activity requested.
        next_page_token (str):
            Token to retrieve the next page of results,
            or empty if there are no more results in the
            list.
    """

    @property
    def raw_page(self):
        return self

    activities = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='DriveActivity',
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )


class DriveActivity(proto.Message):
    r"""A single Drive activity comprising one or more Actions by one
    or more Actors on one or more Targets. Some Action groupings
    occur spontaneously, such as moving an item into a shared folder
    triggering a permission change. Other groupings of related
    Actions, such as multiple Actors editing one item or moving
    multiple files into a new folder, are controlled by the
    selection of a ConsolidationStrategy in the
    QueryDriveActivityRequest.

    Attributes:
        primary_action_detail (google.apps.drive.activity_v2.types.ActionDetail):
            Key information about the primary action for
            this activity. This is either representative, or
            the most important, of all actions in the
            activity, according to the ConsolidationStrategy
            in the request.
        actors (Sequence[google.apps.drive.activity_v2.types.Actor]):
            All actor(s) responsible for the activity.
        actions (Sequence[google.apps.drive.activity_v2.types.Action]):
            Details on all actions in this activity.
        targets (Sequence[google.apps.drive.activity_v2.types.Target]):
            All Google Drive objects this activity is
            about (e.g. file, folder, drive). This
            represents the state of the target immediately
            after the actions occurred.
        timestamp (google.protobuf.timestamp_pb2.Timestamp):
            The activity occurred at this specific time.
        time_range (google.apps.drive.activity_v2.types.TimeRange):
            The activity occurred over this time range.
    """

    primary_action_detail = proto.Field(
        proto.MESSAGE,
        number=2,
        message=action.ActionDetail,
    )
    actors = proto.RepeatedField(
        proto.MESSAGE,
        number=3,
        message=actor.Actor,
    )
    actions = proto.RepeatedField(
        proto.MESSAGE,
        number=4,
        message=action.Action,
    )
    targets = proto.RepeatedField(
        proto.MESSAGE,
        number=5,
        message=target.Target,
    )
    timestamp = proto.Field(
        proto.MESSAGE,
        number=6,
        oneof='time',
        message=gp_timestamp.Timestamp,
    )
    time_range = proto.Field(
        proto.MESSAGE,
        number=7,
        oneof='time',
        message=common.TimeRange,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
