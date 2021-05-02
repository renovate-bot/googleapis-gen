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

from google.protobuf import duration_pb2 as gp_duration  # type: ignore
from google.protobuf import field_mask_pb2 as field_mask  # type: ignore


__protobuf__ = proto.module(
    package='google.devtools.cloudprofiler.v2',
    manifest={
        'ProfileType',
        'CreateProfileRequest',
        'CreateOfflineProfileRequest',
        'UpdateProfileRequest',
        'Profile',
        'Deployment',
    },
)


class ProfileType(proto.Enum):
    r"""ProfileType is type of profiling data.
    NOTE: the enumeration member names are used (in lowercase) as
    unique string identifiers of profile types, so they must not be
    renamed.
    """
    PROFILE_TYPE_UNSPECIFIED = 0
    CPU = 1
    WALL = 2
    HEAP = 3
    THREADS = 4
    CONTENTION = 5
    PEAK_HEAP = 6
    HEAP_ALLOC = 7


class CreateProfileRequest(proto.Message):
    r"""CreateProfileRequest describes a profile resource online creation
    request. The deployment field must be populated. The profile_type
    specifies the list of profile types supported by the agent. The
    creation call will hang until a profile of one of these types needs
    to be collected.

    Attributes:
        parent (str):
            Parent project to create the profile in.
        deployment (google.devtools.cloudprofiler_v2.types.Deployment):
            Deployment details.
        profile_type (Sequence[google.devtools.cloudprofiler_v2.types.ProfileType]):
            One or more profile types that the agent is
            capable of providing.
    """

    parent = proto.Field(
        proto.STRING,
        number=4,
    )
    deployment = proto.Field(
        proto.MESSAGE,
        number=1,
        message='Deployment',
    )
    profile_type = proto.RepeatedField(
        proto.ENUM,
        number=2,
        enum='ProfileType',
    )


class CreateOfflineProfileRequest(proto.Message):
    r"""CreateOfflineProfileRequest describes a profile resource
    offline creation request. Profile field must be set.

    Attributes:
        parent (str):
            Parent project to create the profile in.
        profile (google.devtools.cloudprofiler_v2.types.Profile):
            Contents of the profile to create.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    profile = proto.Field(
        proto.MESSAGE,
        number=2,
        message='Profile',
    )


class UpdateProfileRequest(proto.Message):
    r"""UpdateProfileRequest contains the profile to update.
    Attributes:
        profile (google.devtools.cloudprofiler_v2.types.Profile):
            Profile to update
        update_mask (google.protobuf.field_mask_pb2.FieldMask):
            Field mask used to specify the fields to be overwritten.
            Currently only profile_bytes and labels fields are supported
            by UpdateProfile, so only those fields can be specified in
            the mask. When no mask is provided, all fields are
            overwritten.
    """

    profile = proto.Field(
        proto.MESSAGE,
        number=1,
        message='Profile',
    )
    update_mask = proto.Field(
        proto.MESSAGE,
        number=2,
        message=field_mask.FieldMask,
    )


class Profile(proto.Message):
    r"""Profile resource.
    Attributes:
        name (str):
            Output only. Opaque, server-assigned, unique
            ID for this profile.
        profile_type (google.devtools.cloudprofiler_v2.types.ProfileType):
            Type of profile.
            For offline mode, this must be specified when
            creating the profile. For online mode it is
            assigned and returned by the server.
        deployment (google.devtools.cloudprofiler_v2.types.Deployment):
            Deployment this profile corresponds to.
        duration (google.protobuf.duration_pb2.Duration):
            Duration of the profiling session.
            Input (for the offline mode) or output (for the
            online mode). The field represents requested
            profiling duration. It may slightly differ from
            the effective profiling duration, which is
            recorded in the profile data, in case the
            profiling can't be stopped immediately (e.g. in
            case stopping the profiling is handled
            asynchronously).
        profile_bytes (bytes):
            Input only. Profile bytes, as a gzip
            compressed serialized proto, the format is
            https://github.com/google/pprof/blob/master/proto/profile.proto.
        labels (Sequence[google.devtools.cloudprofiler_v2.types.Profile.LabelsEntry]):
            Input only. Labels associated to this
            specific profile. These labels will get merged
            with the deployment labels for the final data
            set.  See documentation on deployment labels for
            validation rules and limits.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    profile_type = proto.Field(
        proto.ENUM,
        number=2,
        enum='ProfileType',
    )
    deployment = proto.Field(
        proto.MESSAGE,
        number=3,
        message='Deployment',
    )
    duration = proto.Field(
        proto.MESSAGE,
        number=4,
        message=gp_duration.Duration,
    )
    profile_bytes = proto.Field(
        proto.BYTES,
        number=5,
    )
    labels = proto.MapField(
        proto.STRING,
        proto.STRING,
        number=6
    )


class Deployment(proto.Message):
    r"""Deployment contains the deployment identification
    information.

    Attributes:
        project_id (str):
            Project ID is the ID of a cloud project. Validation regex:
            ``^[a-z][-a-z0-9:.]{4,61}[a-z0-9]$``.
        target (str):
            Target is the service name used to group related
            deployments:

            -  Service name for GAE Flex / Standard.
            -  Cluster and container name for GKE.
            -  User-specified string for direct GCE profiling (e.g.
               Java).
            -  Job name for Dataflow. Validation regex:
               ``^[a-z]([-a-z0-9_.]{0,253}[a-z0-9])?$``.
        labels (Sequence[google.devtools.cloudprofiler_v2.types.Deployment.LabelsEntry]):
            Labels identify the deployment within the user universe and
            same target. Validation regex for label names:
            ``^[a-z0-9]([a-z0-9-]{0,61}[a-z0-9])?$``. Value for an
            individual label must be <= 512 bytes, the total size of all
            label names and values must be <= 1024 bytes.

            Label named "language" can be used to record the programming
            language of the profiled deployment. The standard choices
            for the value include "java", "go", "python", "ruby",
            "nodejs", "php", "dotnet".

            For deployments running on Google Cloud Platform, "zone" or
            "region" label should be present describing the deployment
            location. An example of a zone is "us-central1-a", an
            example of a region is "us-central1" or "us-central".
    """

    project_id = proto.Field(
        proto.STRING,
        number=1,
    )
    target = proto.Field(
        proto.STRING,
        number=2,
    )
    labels = proto.MapField(
        proto.STRING,
        proto.STRING,
        number=3
    )


__all__ = tuple(sorted(__protobuf__.manifest))
