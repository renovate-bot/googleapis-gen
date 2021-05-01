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

from google.chromeos.moblab_v1beta1.types import resources
from google.protobuf import field_mask_pb2 as field_mask  # type: ignore
from google.protobuf import timestamp_pb2 as timestamp  # type: ignore


__protobuf__ = proto.module(
    package='google.chromeos.moblab.v1beta1',
    manifest={
        'ListBuildsRequest',
        'ListBuildsResponse',
        'CheckBuildStageStatusRequest',
        'CheckBuildStageStatusResponse',
        'StageBuildRequest',
        'StageBuildResponse',
        'StageBuildMetadata',
    },
)


class ListBuildsRequest(proto.Message):
    r"""Request message for listing builds.
    Attributes:
        parent (str):
            Required. The full resource name of the
            model. The model id is the same as the build
            target id for non-unified builds. For example,
            'buildTargets/octopus/models/bobba'.
        page_size (int):
            Optional. The number of builds to return in a
            page.
        page_token (str):
            Optional. A page token, received from a previous
            ``ListBuilds`` call. Provide this to retrieve the subsequent
            page.
        filter (str):
            Optional. Filter that specifies value constraints of fields.
            For example, the filter can be set as
            ``filter='milestone=milestones/80'`` to only select builds
            in milestone 80.
        read_mask (google.protobuf.field_mask_pb2.FieldMask):
            Optional. Read mask that specifies which Build fields to
            return. If empty, all Build fields will be returned. Valid
            fields: name, milestone, build_version. For example, if the
            read_mask is set as ``read_mask='milestone'``, the
            ListBuilds will return a list of Builds object with only the
            milestone field.
        group_by (google.protobuf.field_mask_pb2.FieldMask):
            Optional. The operation that groups by all the Build fields
            specified in the read mask. The group_by field should be the
            same as the read_mask field in convention of SQL.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    page_size = proto.Field(
        proto.INT32,
        number=2,
    )
    page_token = proto.Field(
        proto.STRING,
        number=3,
    )
    filter = proto.Field(
        proto.STRING,
        number=4,
    )
    read_mask = proto.Field(
        proto.MESSAGE,
        number=5,
        message=field_mask.FieldMask,
    )
    group_by = proto.Field(
        proto.MESSAGE,
        number=6,
        message=field_mask.FieldMask,
    )


class ListBuildsResponse(proto.Message):
    r"""Response message for listing builds.
    Attributes:
        builds (Sequence[google.chromeos.moblab_v1beta1.types.Build]):
            The list of builds.
        next_page_token (str):
            Token to retrieve the next page of builds. If
            this field is omitted, there are no subsequent
            pages.
        total_size (int):
            Total number of builds.
    """

    @property
    def raw_page(self):
        return self

    builds = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=resources.Build,
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )
    total_size = proto.Field(
        proto.INT32,
        number=3,
    )


class CheckBuildStageStatusRequest(proto.Message):
    r"""Request message for checking if the build artifact is staged.
    Attributes:
        name (str):
            Required. The full resource name of the build
            artifact. For example,
            'buildTargets/octopus/models/bobba/builds/12607.6.0/artifacts/chromeos-
            moblab-peng-staging'.
        filter (str):
            Optional. Filter that specifies value constraints of fields.
            For example, the filter can be set as
            ``filter='type=release'`` to only check the release builds.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    filter = proto.Field(
        proto.STRING,
        number=2,
    )


class CheckBuildStageStatusResponse(proto.Message):
    r"""Response message for checking the stage status of a build
    artifact.

    Attributes:
        is_build_staged (bool):
            The status to represent if the build is
            staged or not.
        staged_build_artifact (google.chromeos.moblab_v1beta1.types.BuildArtifact):
            The staged build artifact in the destination
            bucket.
        source_build_artifact (google.chromeos.moblab_v1beta1.types.BuildArtifact):
            The source build artifact in the source
            bucket.
    """

    is_build_staged = proto.Field(
        proto.BOOL,
        number=1,
    )
    staged_build_artifact = proto.Field(
        proto.MESSAGE,
        number=2,
        message=resources.BuildArtifact,
    )
    source_build_artifact = proto.Field(
        proto.MESSAGE,
        number=3,
        message=resources.BuildArtifact,
    )


class StageBuildRequest(proto.Message):
    r"""Request message for staging a build artifact.
    Attributes:
        name (str):
            Required. The full resource name of the build
            artifact. For example,
            'buildTargets/octopus/models/bobba/builds/12607.6.0/artifacts/chromeos-
            moblab-peng-staging'.
        filter (str):
            Optional. Filter that specifies value constraints of fields.
            For example, the filter can be set as
            ``filter='type=release'`` to only check the release builds.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    filter = proto.Field(
        proto.STRING,
        number=2,
    )


class StageBuildResponse(proto.Message):
    r"""Response message for staging a build artifact.
    Attributes:
        staged_build_artifact (google.chromeos.moblab_v1beta1.types.BuildArtifact):
            The staged build in the destination bucket.
    """

    staged_build_artifact = proto.Field(
        proto.MESSAGE,
        number=1,
        message=resources.BuildArtifact,
    )


class StageBuildMetadata(proto.Message):
    r"""Metadata message for staging a build artifact.
    Attributes:
        progress_percent (float):
            Approximate percentage of progress, e.g. "50"
            means 50%.
        start_time (google.protobuf.timestamp_pb2.Timestamp):
            Build stage start time.
        end_time (google.protobuf.timestamp_pb2.Timestamp):
            Build stage end time.
    """

    progress_percent = proto.Field(
        proto.FLOAT,
        number=1,
    )
    start_time = proto.Field(
        proto.MESSAGE,
        number=2,
        message=timestamp.Timestamp,
    )
    end_time = proto.Field(
        proto.MESSAGE,
        number=3,
        message=timestamp.Timestamp,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
