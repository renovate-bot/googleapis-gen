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

from google.devtools.build_v1.types import build_events
from google.protobuf import duration_pb2  # type: ignore


__protobuf__ = proto.module(
    package='google.devtools.build.v1',
    manifest={
        'PublishLifecycleEventRequest',
        'PublishBuildToolEventStreamResponse',
        'OrderedBuildEvent',
        'PublishBuildToolEventStreamRequest',
    },
)


class PublishLifecycleEventRequest(proto.Message):
    r"""Publishes 'lifecycle events' that update the high-level state
    of a build: - BuildEnqueued: When a build is scheduled. -
    InvocationAttemptStarted: When work for a build starts; there
    can be     multiple invocations for a build (e.g. retries). -
    InvocationAttemptCompleted: When work for a build finishes. -
    BuildFinished: When a build is finished.

    Attributes:
        service_level (google.devtools.build_v1.types.PublishLifecycleEventRequest.ServiceLevel):
            The interactivity of this build.
        build_event (google.devtools.build_v1.types.OrderedBuildEvent):
            Required. The lifecycle build event. If this is a build tool
            event, the RPC will fail with INVALID_REQUEST.
        stream_timeout (google.protobuf.duration_pb2.Duration):
            If the next event for this build or invocation (depending on
            the event type) hasn't been published after this duration
            from when {build_event} is written to BES, consider this
            stream expired. If this field is not set, BES backend will
            use its own default value.
        notification_keywords (Sequence[str]):
            Additional information about a build request.
            These are define by the event publishers, and
            the Build Event Service does not validate or
            interpret them. They are used while notifying
            internal systems of new builds and invocations
            if the OrderedBuildEvent.event type is
            BuildEnqueued/InvocationAttemptStarted.
        project_id (str):
            Required. The project this build is
            associated with. This should match the project
            used for the initial call to
            PublishLifecycleEvent (containing a
            BuildEnqueued message).
    """
    class ServiceLevel(proto.Enum):
        r"""The service level of the build request. Backends only uses
        this value when the BuildEnqueued event is published to
        determine what level of service this build should receive.
        """
        NONINTERACTIVE = 0
        INTERACTIVE = 1

    service_level = proto.Field(
        proto.ENUM,
        number=1,
        enum=ServiceLevel,
    )
    build_event = proto.Field(
        proto.MESSAGE,
        number=2,
        message='OrderedBuildEvent',
    )
    stream_timeout = proto.Field(
        proto.MESSAGE,
        number=3,
        message=duration_pb2.Duration,
    )
    notification_keywords = proto.RepeatedField(
        proto.STRING,
        number=4,
    )
    project_id = proto.Field(
        proto.STRING,
        number=6,
    )


class PublishBuildToolEventStreamResponse(proto.Message):
    r"""States which event has been committed. Any failure to commit
    will cause RPC errors, hence not recorded by this proto.

    Attributes:
        stream_id (google.devtools.build_v1.types.StreamId):
            The stream that contains this event.
        sequence_number (int):
            The sequence number of this event that has
            been committed.
    """

    stream_id = proto.Field(
        proto.MESSAGE,
        number=1,
        message=build_events.StreamId,
    )
    sequence_number = proto.Field(
        proto.INT64,
        number=2,
    )


class OrderedBuildEvent(proto.Message):
    r"""Build event with contextual information about the stream it
    belongs to and its position in that stream.

    Attributes:
        stream_id (google.devtools.build_v1.types.StreamId):
            Which build event stream this event belongs
            to.
        sequence_number (int):
            The position of this event in the stream. The
            sequence numbers for a build event stream should
            be a sequence of consecutive natural numbers
            starting from one. (1, 2, 3, ...)
        event (google.devtools.build_v1.types.BuildEvent):
            The actual event.
    """

    stream_id = proto.Field(
        proto.MESSAGE,
        number=1,
        message=build_events.StreamId,
    )
    sequence_number = proto.Field(
        proto.INT64,
        number=2,
    )
    event = proto.Field(
        proto.MESSAGE,
        number=3,
        message=build_events.BuildEvent,
    )


class PublishBuildToolEventStreamRequest(proto.Message):
    r"""Streaming request message for PublishBuildToolEventStream.

    Attributes:
        ordered_build_event (google.devtools.build_v1.types.OrderedBuildEvent):
            Required. The build event with position info.
            New publishing clients should use this field
            rather than the 3 above.
        notification_keywords (Sequence[str]):
            The keywords to be attached to the notification which
            notifies the start of a new build event stream. BES only
            reads this field when sequence_number or
            ordered_build_event.sequence_number is 1 in this message. If
            this field is empty, BES will not publish notification
            messages for this stream.
        project_id (str):
            Required. The project this build is
            associated with. This should match the project
            used for the initial call to
            PublishLifecycleEvent (containing a
            BuildEnqueued message).
    """

    ordered_build_event = proto.Field(
        proto.MESSAGE,
        number=4,
        message='OrderedBuildEvent',
    )
    notification_keywords = proto.RepeatedField(
        proto.STRING,
        number=5,
    )
    project_id = proto.Field(
        proto.STRING,
        number=6,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
