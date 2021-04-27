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

from google.protobuf import any_pb2 as gp_any  # type: ignore
from google.protobuf import wrappers_pb2 as wrappers  # type: ignore


__protobuf__ = proto.module(
    package='google.devtools.build.v1',
    manifest={
        'BuildStatus',
    },
)


class BuildStatus(proto.Message):
    r"""Status used for both invocation attempt and overall build
    completion.

    Attributes:
        result (google.devtools.build_v1.types.BuildStatus.Result):
            The end result.
        final_invocation_id (str):
            Final invocation ID of the build, if there
            was one. This field is only set on a status in
            BuildFinished event.
        build_tool_exit_code (google.protobuf.wrappers_pb2.Int32Value):
            Build tool exit code. Integer value returned
            by the executed build tool. Might not be
            available in some cases, e.g., a build timeout.
        details (google.protobuf.any_pb2.Any):
            Fine-grained diagnostic information to
            complement the status.
    """
    class Result(proto.Enum):
        r"""The end result of the Build."""
        UNKNOWN_STATUS = 0
        COMMAND_SUCCEEDED = 1
        COMMAND_FAILED = 2
        USER_ERROR = 3
        SYSTEM_ERROR = 4
        RESOURCE_EXHAUSTED = 5
        INVOCATION_DEADLINE_EXCEEDED = 6
        REQUEST_DEADLINE_EXCEEDED = 8
        CANCELLED = 7

    result = proto.Field(
        proto.ENUM,
        number=1,
        enum=Result,
    )
    final_invocation_id = proto.Field(
        proto.STRING,
        number=3,
    )
    build_tool_exit_code = proto.Field(
        proto.MESSAGE,
        number=4,
        message=wrappers.Int32Value,
    )
    details = proto.Field(
        proto.MESSAGE,
        number=2,
        message=gp_any.Any,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
