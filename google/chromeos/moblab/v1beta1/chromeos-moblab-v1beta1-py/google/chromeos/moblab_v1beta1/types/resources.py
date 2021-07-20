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
    package='google.chromeos.moblab.v1beta1',
    manifest={
        'BuildTarget',
        'Model',
        'Milestone',
        'Build',
        'BuildArtifact',
    },
)


class BuildTarget(proto.Message):
    r"""Resource that represents a build target.
    Attributes:
        name (str):
            The resource name of the build target. Format:
            buildTargets/{build_target}
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class Model(proto.Message):
    r"""Resource that represents a model. Each model belongs to a
    build target. For non-unified build, the model name is the same
    as its build target name.

    Attributes:
        name (str):
            The resource name of the model. Format:
            buildTargets/{build_target}/models/{model}
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class Milestone(proto.Message):
    r"""Resource that represents a chrome OS milestone.
    Attributes:
        name (str):
            The resource name of the milestone.
            Format: milestones/{milestone}
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class Build(proto.Message):
    r"""Resource that represents a build for the given build target,
    model, milestone and build version.

    Attributes:
        name (str):
            The resource name of the build. Format:
            buildTargets/{build_target}/models/{model}/builds/{build}
            Example: buildTargets/octopus/models/bobba/builds/1234.0.0
        milestone (str):
            The milestone that owns the build.
            Format: milestones/{milestone}
        build_version (str):
            The build version of the build, e.g.
            1234.0.0.
        status (google.chromeos.moblab_v1beta1.types.Build.BuildStatus):
            The status of the build.
        type_ (google.chromeos.moblab_v1beta1.types.Build.BuildType):
            The type of the build.
        branch (str):
            The branch of the build.
        rw_firmware_version (str):
            The read write firmware version of the
            software that is flashed to the chip on the
            Chrome OS device.
    """
    class BuildStatus(proto.Enum):
        r"""The build status types."""
        BUILD_STATUS_UNSPECIFIED = 0
        PASS = 1
        FAIL = 2
        RUNNING = 3
        ABORTED = 4

    class BuildType(proto.Enum):
        r"""The build types."""
        BUILD_TYPE_UNSPECIFIED = 0
        RELEASE = 1
        FIRMWARE = 2

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    milestone = proto.Field(
        proto.STRING,
        number=2,
    )
    build_version = proto.Field(
        proto.STRING,
        number=3,
    )
    status = proto.Field(
        proto.ENUM,
        number=4,
        enum=BuildStatus,
    )
    type_ = proto.Field(
        proto.ENUM,
        number=5,
        enum=BuildType,
    )
    branch = proto.Field(
        proto.STRING,
        number=6,
    )
    rw_firmware_version = proto.Field(
        proto.STRING,
        number=7,
    )


class BuildArtifact(proto.Message):
    r"""Resource that represents a build artifact stored in Google
    Cloud Storage for the given build target, model, build version
    and bucket.

    Attributes:
        name (str):
            The resource name of the build artifact. Format:
            buildTargets/{build_target}/models/{model}/builds/{build}/artifacts/{artifact}
            Example:
            buildTargets/octopus/models/bobba/builds/1234.0.0/artifacts/chromeos-moblab-peng-staging
        build (str):
            The build metadata of the build artifact.
        bucket (str):
            The bucket that stores the build artifact.
        path (str):
            The path of the build artifact in the bucket.
        object_count (int):
            The number of objects in the build artifact
            folder. The object number can be used to
            calculated the stage progress by comparing the
            source build artifact with the destination build
            artifact.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    build = proto.Field(
        proto.STRING,
        number=2,
    )
    bucket = proto.Field(
        proto.STRING,
        number=3,
    )
    path = proto.Field(
        proto.STRING,
        number=4,
    )
    object_count = proto.Field(
        proto.UINT32,
        number=5,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
