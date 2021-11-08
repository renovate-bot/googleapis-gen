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
        'QueryDriveActivityRequest',
        'ConsolidationStrategy',
    },
)


class QueryDriveActivityRequest(proto.Message):
    r"""The request message for querying Drive activity.

    This message has `oneof`_ fields (mutually exclusive fields).
    For each oneof, at most one member field can be set at the same time.
    Setting any member of the oneof automatically clears all other
    members.

    .. _oneof: https://proto-plus-python.readthedocs.io/en/stable/fields.html#oneofs-mutually-exclusive-fields

    Attributes:
        item_name (str):
            Return activities for this Drive item. The format is
            ``items/ITEM_ID``.

            This field is a member of `oneof`_ ``key``.
        ancestor_name (str):
            Return activities for this Drive folder and all children and
            descendants. The format is ``items/ITEM_ID``.

            This field is a member of `oneof`_ ``key``.
        consolidation_strategy (google.apps.drive.activity_v2.types.ConsolidationStrategy):
            Details on how to consolidate related actions
            that make up the activity. If not set, then
            related actions are not consolidated.
        page_size (int):
            The miminum number of activities desired in
            the response; the server will attempt to return
            at least this quanitity. The server may also
            return fewer activities if it has a partial
            response ready before the request times out. If
            not set, a default value is used.
        page_token (str):
            The token identifying which page of results to return. Set
            this to the next_page_token value returned from a previous
            query to obtain the following page of results. If not set,
            the first page of results will be returned.
        filter (str):
            The filtering for items returned from this query request.
            The format of the filter string is a sequence of
            expressions, joined by an optional "AND", where each
            expression is of the form "field operator value".

            Supported fields:

            -  ``time``: Uses numerical operators on date values either
               in terms of milliseconds since Jan 1, 1970 or in RFC 3339
               format. Examples:

               -  ``time > 1452409200000 AND time <= 1492812924310``
               -  ``time >= "2016-01-10T01:02:03-05:00"``

            -  ``detail.action_detail_case``: Uses the "has" operator
               (:) and either a singular value or a list of allowed
               action types enclosed in parentheses. Examples:

               -  ``detail.action_detail_case: RENAME``
               -  ``detail.action_detail_case:(CREATE EDIT)``
               -  ``-detail.action_detail_case:MOVE``
    """

    item_name = proto.Field(
        proto.STRING,
        number=1,
        oneof='key',
    )
    ancestor_name = proto.Field(
        proto.STRING,
        number=2,
        oneof='key',
    )
    consolidation_strategy = proto.Field(
        proto.MESSAGE,
        number=5,
        message='ConsolidationStrategy',
    )
    page_size = proto.Field(
        proto.INT32,
        number=6,
    )
    page_token = proto.Field(
        proto.STRING,
        number=7,
    )
    filter = proto.Field(
        proto.STRING,
        number=8,
    )


class ConsolidationStrategy(proto.Message):
    r"""How the individual activities are consolidated. A set of
    activities may be consolidated into one combined activity if
    they are related in some way, such as one actor performing the
    same action on multiple targets, or multiple actors performing
    the same action on a single target. The strategy defines the
    rules for which activities are related.

    This message has `oneof`_ fields (mutually exclusive fields).
    For each oneof, at most one member field can be set at the same time.
    Setting any member of the oneof automatically clears all other
    members.

    .. _oneof: https://proto-plus-python.readthedocs.io/en/stable/fields.html#oneofs-mutually-exclusive-fields

    Attributes:
        none (google.apps.drive.activity_v2.types.ConsolidationStrategy.NoConsolidation):
            The individual activities are not
            consolidated.

            This field is a member of `oneof`_ ``strategy``.
        legacy (google.apps.drive.activity_v2.types.ConsolidationStrategy.Legacy):
            The individual activities are consolidated
            using the legacy strategy.

            This field is a member of `oneof`_ ``strategy``.
    """

    class NoConsolidation(proto.Message):
        r"""A strategy which does no consolidation of individual
        activities.

        """

    class Legacy(proto.Message):
        r"""A strategy which consolidates activities using the grouping
        rules from the legacy V1 Activity API. Similar actions occurring
        within a window of time can be grouped across multiple targets
        (such as moving a set of files at once) or multiple actors (such
        as several users editing the same item). Grouping rules for this
        strategy are specific to each type of action.

        """

    none = proto.Field(
        proto.MESSAGE,
        number=1,
        oneof='strategy',
        message=NoConsolidation,
    )
    legacy = proto.Field(
        proto.MESSAGE,
        number=2,
        oneof='strategy',
        message=Legacy,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
