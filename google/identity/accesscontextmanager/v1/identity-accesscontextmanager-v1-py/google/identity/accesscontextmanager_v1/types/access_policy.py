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

from google.protobuf import timestamp_pb2  # type: ignore


__protobuf__ = proto.module(
    package='google.identity.accesscontextmanager.v1',
    manifest={
        'AccessPolicy',
    },
)


class AccessPolicy(proto.Message):
    r"""``AccessPolicy`` is a container for ``AccessLevels`` (which define
    the necessary attributes to use Google Cloud services) and
    ``ServicePerimeters`` (which define regions of services able to
    freely pass data within a perimeter). An access policy is globally
    visible within an organization, and the restrictions it specifies
    apply to all projects within an organization.

    Attributes:
        name (str):
            Output only. Resource name of the ``AccessPolicy``. Format:
            ``accessPolicies/{access_policy}``
        parent (str):
            Required. The parent of this ``AccessPolicy`` in the Cloud
            Resource Hierarchy. Currently immutable once created.
            Format: ``organizations/{organization_id}``
        title (str):
            Required. Human readable title. Does not
            affect behavior.
        create_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. Time the ``AccessPolicy`` was created in UTC.
        update_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. Time the ``AccessPolicy`` was updated in UTC.
        etag (str):
            Output only. An opaque identifier for the current version of
            the ``AccessPolicy``. This will always be a strongly
            validated etag, meaning that two Access Polices will be
            identical if and only if their etags are identical. Clients
            should not expect this to be in any specific format.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    parent = proto.Field(
        proto.STRING,
        number=2,
    )
    title = proto.Field(
        proto.STRING,
        number=3,
    )
    create_time = proto.Field(
        proto.MESSAGE,
        number=4,
        message=timestamp_pb2.Timestamp,
    )
    update_time = proto.Field(
        proto.MESSAGE,
        number=5,
        message=timestamp_pb2.Timestamp,
    )
    etag = proto.Field(
        proto.STRING,
        number=6,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
