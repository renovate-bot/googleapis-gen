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


from google.devtools.remoteworkers_v1.types import worker as gdrv_worker
from google.protobuf import any_pb2 as gp_any  # type: ignore
from google.protobuf import field_mask_pb2 as field_mask  # type: ignore
from google.protobuf import timestamp_pb2 as timestamp  # type: ignore
from google.rpc import status_pb2 as gr_status  # type: ignore


__protobuf__ = proto.module(
    package='google.devtools.remoteworkers.v1test2',
    manifest={
        'BotStatus',
        'LeaseState',
        'BotSession',
        'Lease',
        'AdminTemp',
        'CreateBotSessionRequest',
        'UpdateBotSessionRequest',
    },
)


class BotStatus(proto.Enum):
    r"""A coarse description of the status of the bot that the server
    uses to determine whether to assign the bot new leases.
    """
    BOT_STATUS_UNSPECIFIED = 0
    OK = 1
    UNHEALTHY = 2
    HOST_REBOOTING = 3
    BOT_TERMINATING = 4
    INITIALIZING = 5


class LeaseState(proto.Enum):
    r"""The state of the lease. All leases start in the PENDING
    state. A bot can change PENDING to ACTIVE or (in the case of an
    error) COMPLETED, or from ACTIVE to COMPLETED. The server can
    change PENDING or ACTIVE to CANCELLED if it wants the bot to
    release its resources - for example, if the bot needs to be
    quarantined (it's producing bad output) or a cell needs to be
    drained.
    """
    LEASE_STATE_UNSPECIFIED = 0
    PENDING = 1
    ACTIVE = 2
    COMPLETED = 4
    CANCELLED = 5


class BotSession(proto.Message):
    r"""A bot session represents the state of a bot while in continuous
    contact with the server for a period of time. The session includes
    information about the worker - that is, the *worker* (the physical
    or virtual hardware) is considered to be a property of the bot (the
    software agent running on that hardware), which is the reverse of
    real life, but more natural from the point of the view of this API,
    which communicates solely with the bot and not directly with the
    underlying worker.

    Attributes:
        name (str):
            The bot session name, as selected by the
            server. Output only during a call to
            CreateBotSession.
        bot_id (str):
            A unique bot ID within the farm used to persistently
            identify this bot over time (i.e., over multiple sessions).
            This ID must be unique within a farm. Typically, the bot ID
            will be the same as the name of the primary device in the
            worker (e.g., what you'd get from typing ``uname -n`` on
            \*nix), but this is not required since a single device may
            allow multiple bots to run on it, each with access to
            different resources. What is important is that this ID is
            meaningful to humans, who might need to hunt a physical
            machine down to fix it.

            When CreateBotSession is successfully called with a bot_id,
            all prior sessions with the same ID are invalidated. If a
            bot attempts to update an invalid session, the server must
            reject that request, and may also quarantine the other bot
            with the same bot IDs (ie, stop sending it new leases and
            alert an admin).
        status (google.devtools.remoteworkers_v1.types.BotStatus):
            The status of the bot. This must be populated
            in every call to UpdateBotSession.
        worker (google.devtools.remoteworkers_v1.types.Worker):
            A description of the worker hosting this bot. The Worker
            message is used here in the Status context (see Worker for
            more information). If multiple bots are running on the
            worker, this field should only describe the resources
            accessible from this bot.

            During the call to CreateBotSession, the server may make
            arbitrary changes to the worker's ``server_properties``
            field (see that field for more information). Otherwise, this
            field is input-only.
        leases (Sequence[google.devtools.remoteworkers_v1.types.Lease]):
            A list of all leases that are a part of this
            session. See the Lease message for details.
        expire_time (google.protobuf.timestamp_pb2.Timestamp):
            The time at which this bot session will
            expire, unless the bot calls UpdateBotSession
            again. Output only.
        version (str):
            The version of the bot code currently
            running. The server may use this information to
            issue an admin action to tell the bot to update
            itself.
    """

    name = proto.Field(proto.STRING, number=1)

    bot_id = proto.Field(proto.STRING, number=2)

    status = proto.Field(proto.ENUM, number=3,
        enum='BotStatus',
    )

    worker = proto.Field(proto.MESSAGE, number=4,
        message=gdrv_worker.Worker,
    )

    leases = proto.RepeatedField(proto.MESSAGE, number=5,
        message='Lease',
    )

    expire_time = proto.Field(proto.MESSAGE, number=6,
        message=timestamp.Timestamp,
    )

    version = proto.Field(proto.STRING, number=7)


class Lease(proto.Message):
    r"""A Lease is a lease that the scheduler has assigned to this bot. If
    the bot notices (by UpdateBotSession) that it has any leases in the
    PENDING state, it should call UpdateBotSession to put the leases
    into the ACTIVE state and start executing their assignments.

    All fields in this message are output-only, *except* the ``state``
    and ``status`` fields. Note that repeated fields can only be updated
    as a unit, so on every update the bot must provide an update for
    *all* the leases the server expects it to report on.

    The scheduler *should* ensure that all leases scheduled to a bot can
    actually be accepted, but race conditions may occur. In such cases,
    the bot should attempt to accept the leases in the order they are
    listed by the server, to allow the server to control priorities.

    The server will remove COMPLETED leases from time to time, after
    which the bot shouldn't report on them any more (the server will
    ignore superfluous COMPLETED records).

    Attributes:
        id (str):
            A short string uniquely identifing the lease
            within this bot session.
        payload (google.protobuf.any_pb2.Any):
            The actual work to be performed, if any. May be omitted by
            the server if the lease is not in the ``PENDING`` state. The
            message must be meaningful to the bot. Output only (must
            only be set by the server).
        result (google.protobuf.any_pb2.Any):
            Any result the bot wishes to provide about the lease. Must
            not be changed after the first call with the lease in the
            ``COMPLETED`` or ``CANCELLED`` state. Input only (must only
            be set by the bot, will not be echoed by the server).
        state (google.devtools.remoteworkers_v1.types.LeaseState):
            The state of the lease. See LeaseState for
            more information.
        status (google.rpc.status_pb2.Status):
            The final status of the lease (should be populated by the
            bot if the state is completed). This is the status of the
            lease, not of any task represented by the lease. For
            example, if the bot could not accept the lease because it
            asked for some resource the bot didn't have, this status
            will be FAILED_PRECONDITION. But if the assignment in the
            lease didn't execute correctly, this field will be ``OK``
            while the failure of the assignment must communicated via
            the ``result`` field.
        requirements (google.devtools.remoteworkers_v1.types.Worker):
            The requirements that are being claimed by
            this lease. This field may be omitted by the
            server if the lease is not pending.
        expire_time (google.protobuf.timestamp_pb2.Timestamp):
            The time at which this lease expires. The server *may*
            extend this over time, but due to race conditions, the bot
            is not *required* to respect any expiry date except the
            first one.
        assignment (str):
            DEPRECATED. The assignment should be provided to the bot via
            the ``payload`` field. Clients that wish to use a simple
            name (such as a queue of work provided elsewhere) should
            define a custom message type and encode it into ``payload``.
        inline_assignment (google.protobuf.any_pb2.Any):
            DEPRECATED. Use ``payload`` instead.
    """

    id = proto.Field(proto.STRING, number=7)

    payload = proto.Field(proto.MESSAGE, number=8,
        message=gp_any.Any,
    )

    result = proto.Field(proto.MESSAGE, number=9,
        message=gp_any.Any,
    )

    state = proto.Field(proto.ENUM, number=2,
        enum='LeaseState',
    )

    status = proto.Field(proto.MESSAGE, number=3,
        message=gr_status.Status,
    )

    requirements = proto.Field(proto.MESSAGE, number=4,
        message=gdrv_worker.Worker,
    )

    expire_time = proto.Field(proto.MESSAGE, number=5,
        message=timestamp.Timestamp,
    )

    assignment = proto.Field(proto.STRING, number=1)

    inline_assignment = proto.Field(proto.MESSAGE, number=6,
        message=gp_any.Any,
    )


class AdminTemp(proto.Message):
    r"""AdminTemp is a prelimiary set of administration tasks. It's called
    "Temp" because we do not yet know the best way to represent admin
    tasks; it's possible that this will be entirely replaced in later
    versions of this API. If this message proves to be sufficient, it
    will be renamed in the alpha or beta release of this API.

    This message (suitably marshalled into a protobuf.Any) can be used
    as the inline_assignment field in a lease; the lease assignment
    field should simply be ``"admin"`` in these cases.

    This message is heavily based on Swarming administration tasks from
    the LUCI project
    (http://github.com/luci/luci-py/appengine/swarming).

    Attributes:
        command (google.devtools.remoteworkers_v1.types.AdminTemp.Command):
            The admin action; see ``Command`` for legal values.
        arg (str):
            The argument to the admin action; see ``Command`` for
            semantics.
    """
    class Command(proto.Enum):
        r"""Possible administration actions."""
        UNSPECIFIED = 0
        BOT_UPDATE = 1
        BOT_RESTART = 2
        BOT_TERMINATE = 3
        HOST_RESTART = 4

    command = proto.Field(proto.ENUM, number=1,
        enum=Command,
    )

    arg = proto.Field(proto.STRING, number=2)


class CreateBotSessionRequest(proto.Message):
    r"""Request message for CreateBotSession.

    Attributes:
        parent (str):
            Required. The farm resource.
        bot_session (google.devtools.remoteworkers_v1.types.BotSession):
            Required. The bot session to create. Server-
            ssigned fields like name must be unset.
    """

    parent = proto.Field(proto.STRING, number=1)

    bot_session = proto.Field(proto.MESSAGE, number=2,
        message='BotSession',
    )


class UpdateBotSessionRequest(proto.Message):
    r"""Request message for UpdateBotSession.

    Attributes:
        name (str):
            Required. The bot session name. Must match bot_session.name.
        bot_session (google.devtools.remoteworkers_v1.types.BotSession):
            Required. The bot session resource to update.
        update_mask (google.protobuf.field_mask_pb2.FieldMask):
            Required. The fields on the bot that should
            be updated. See the BotSession resource for
            which fields are updatable by which caller.
    """

    name = proto.Field(proto.STRING, number=1)

    bot_session = proto.Field(proto.MESSAGE, number=2,
        message='BotSession',
    )

    update_mask = proto.Field(proto.MESSAGE, number=3,
        message=field_mask.FieldMask,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
