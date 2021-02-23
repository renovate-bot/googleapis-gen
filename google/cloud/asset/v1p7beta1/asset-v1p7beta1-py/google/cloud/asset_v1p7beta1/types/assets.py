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


from google.cloud.orgpolicy.v1 import orgpolicy_pb2 as orgpolicy  # type: ignore
from google.iam.v1 import policy_pb2 as policy  # type: ignore
from google.identity.accesscontextmanager.v1 import access_level_pb2 as giav_access_level  # type: ignore
from google.identity.accesscontextmanager.v1 import access_policy_pb2 as giav_access_policy  # type: ignore
from google.identity.accesscontextmanager.v1 import service_perimeter_pb2 as giav_service_perimeter  # type: ignore
from google.protobuf import struct_pb2 as struct  # type: ignore
from google.protobuf import timestamp_pb2 as timestamp  # type: ignore


__protobuf__ = proto.module(
    package='google.cloud.asset.v1p7beta1',
    manifest={
        'Asset',
        'Resource',
        'RelatedAssets',
        'RelationshipAttributes',
        'RelatedAsset',
    },
)


class Asset(proto.Message):
    r"""An asset in Google Cloud. An asset can be any resource in the Google
    Cloud `resource
    hierarchy <https://cloud.google.com/resource-manager/docs/cloud-platform-resource-hierarchy>`__,
    a resource outside the Google Cloud resource hierarchy (such as
    Google Kubernetes Engine clusters and objects), or a policy (e.g.
    Cloud IAM policy). See `Supported asset
    types <https://cloud.google.com/asset-inventory/docs/supported-asset-types>`__
    for more information.

    Attributes:
        update_time (google.protobuf.timestamp_pb2.Timestamp):
            The last update timestamp of an asset. update_time is
            updated when create/update/delete operation is performed.
        name (str):
            The full name of the asset. Example:
            ``//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1``

            See `Resource
            names <https://cloud.google.com/apis/design/resource_names#full_resource_name>`__
            for more information.
        asset_type (str):
            The type of the asset. Example:
            ``compute.googleapis.com/Disk``

            See `Supported asset
            types <https://cloud.google.com/asset-inventory/docs/supported-asset-types>`__
            for more information.
        resource (google.cloud.asset_v1p7beta1.types.Resource):
            A representation of the resource.
        iam_policy (google.iam.v1.policy_pb2.Policy):
            A representation of the Cloud IAM policy set on a Google
            Cloud resource. There can be a maximum of one Cloud IAM
            policy set on any given resource. In addition, Cloud IAM
            policies inherit their granted access scope from any
            policies set on parent resources in the resource hierarchy.
            Therefore, the effectively policy is the union of both the
            policy set on this resource and each policy set on all of
            the resource's ancestry resource levels in the hierarchy.
            See `this
            topic <https://cloud.google.com/iam/docs/policies#inheritance>`__
            for more information.
        org_policy (Sequence[google.cloud.orgpolicy.v1.orgpolicy_pb2.Policy]):
            A representation of an `organization
            policy <https://cloud.google.com/resource-manager/docs/organization-policy/overview#organization_policy>`__.
            There can be more than one organization policy with
            different constraints set on a given resource.
        access_policy (google.identity.accesscontextmanager.v1.access_policy_pb2.AccessPolicy):
            Please also refer to the `access policy user
            guide <https://cloud.google.com/access-context-manager/docs/overview#access-policies>`__.
        access_level (google.identity.accesscontextmanager.v1.access_level_pb2.AccessLevel):
            Please also refer to the `access level user
            guide <https://cloud.google.com/access-context-manager/docs/overview#access-levels>`__.
        service_perimeter (google.identity.accesscontextmanager.v1.service_perimeter_pb2.ServicePerimeter):
            Please also refer to the `service perimeter user
            guide <https://cloud.google.com/vpc-service-controls/docs/overview>`__.
        related_assets (google.cloud.asset_v1p7beta1.types.RelatedAssets):
            The related assets of the asset of one
            relationship type. One asset only represents one
            type of relationship.
        ancestors (Sequence[str]):
            The ancestry path of an asset in Google Cloud `resource
            hierarchy <https://cloud.google.com/resource-manager/docs/cloud-platform-resource-hierarchy>`__,
            represented as a list of relative resource names. An
            ancestry path starts with the closest ancestor in the
            hierarchy and ends at root. If the asset is a project,
            folder, or organization, the ancestry path starts from the
            asset itself.

            Example:
            ``["projects/123456789", "folders/5432", "organizations/1234"]``
    """

    update_time = proto.Field(proto.MESSAGE, number=11,
        message=timestamp.Timestamp,
    )

    name = proto.Field(proto.STRING, number=1)

    asset_type = proto.Field(proto.STRING, number=2)

    resource = proto.Field(proto.MESSAGE, number=3,
        message='Resource',
    )

    iam_policy = proto.Field(proto.MESSAGE, number=4,
        message=policy.Policy,
    )

    org_policy = proto.RepeatedField(proto.MESSAGE, number=6,
        message=orgpolicy.Policy,
    )

    access_policy = proto.Field(proto.MESSAGE, number=7, oneof='access_context_policy',
        message=giav_access_policy.AccessPolicy,
    )

    access_level = proto.Field(proto.MESSAGE, number=8, oneof='access_context_policy',
        message=giav_access_level.AccessLevel,
    )

    service_perimeter = proto.Field(proto.MESSAGE, number=9, oneof='access_context_policy',
        message=giav_service_perimeter.ServicePerimeter,
    )

    related_assets = proto.Field(proto.MESSAGE, number=13,
        message='RelatedAssets',
    )

    ancestors = proto.RepeatedField(proto.STRING, number=10)


class Resource(proto.Message):
    r"""A representation of a Google Cloud resource.

    Attributes:
        version (str):
            The API version. Example: ``v1``
        discovery_document_uri (str):
            The URL of the discovery document containing the resource's
            JSON schema. Example:
            ``https://www.googleapis.com/discovery/v1/apis/compute/v1/rest``

            This value is unspecified for resources that do not have an
            API based on a discovery document, such as Cloud Bigtable.
        discovery_name (str):
            The JSON schema name listed in the discovery document.
            Example: ``Project``

            This value is unspecified for resources that do not have an
            API based on a discovery document, such as Cloud Bigtable.
        resource_url (str):
            The REST URL for accessing the resource. An HTTP ``GET``
            request using this URL returns the resource itself. Example:
            ``https://cloudresourcemanager.googleapis.com/v1/projects/my-project-123``

            This value is unspecified for resources without a REST API.
        parent (str):
            The full name of the immediate parent of this resource. See
            `Resource
            Names <https://cloud.google.com/apis/design/resource_names#full_resource_name>`__
            for more information.

            For Google Cloud assets, this value is the parent resource
            defined in the `Cloud IAM policy
            hierarchy <https://cloud.google.com/iam/docs/overview#policy_hierarchy>`__.
            Example:
            ``//cloudresourcemanager.googleapis.com/projects/my_project_123``

            For third-party assets, this field may be set differently.
        data (google.protobuf.struct_pb2.Struct):
            The content of the resource, in which some
            sensitive fields are removed and may not be
            present.
        location (str):
            The location of the resource in Google Cloud,
            such as its zone and region. For more
            information, see
            https://cloud.google.com/about/locations/.
    """

    version = proto.Field(proto.STRING, number=1)

    discovery_document_uri = proto.Field(proto.STRING, number=2)

    discovery_name = proto.Field(proto.STRING, number=3)

    resource_url = proto.Field(proto.STRING, number=4)

    parent = proto.Field(proto.STRING, number=5)

    data = proto.Field(proto.MESSAGE, number=6,
        message=struct.Struct,
    )

    location = proto.Field(proto.STRING, number=8)


class RelatedAssets(proto.Message):
    r"""The detailed related assets with the ``relationship_type``.

    Attributes:
        relationship_attributes (google.cloud.asset_v1p7beta1.types.RelationshipAttributes):
            The detailed relation attributes.
        assets (Sequence[google.cloud.asset_v1p7beta1.types.RelatedAsset]):
            The peer resources of the relationship.
    """

    relationship_attributes = proto.Field(proto.MESSAGE, number=1,
        message='RelationshipAttributes',
    )

    assets = proto.RepeatedField(proto.MESSAGE, number=2,
        message='RelatedAsset',
    )


class RelationshipAttributes(proto.Message):
    r"""The relationship attributes which include ``type``,
    ``source_resource_type``, ``target_resource_type`` and ``action``.

    Attributes:
        type_ (str):
            The unique identifier of the relationship type. Example:
            ``INSTANCE_TO_INSTANCEGROUP``
        source_resource_type (str):
            The source asset type. Example:
            ``compute.googleapis.com/Instance``
        target_resource_type (str):
            The target asset type. Example:
            ``compute.googleapis.com/Disk``
        action (str):
            The detail of the relationship, e.g. ``contains``,
            ``attaches``
    """

    type_ = proto.Field(proto.STRING, number=4)

    source_resource_type = proto.Field(proto.STRING, number=1)

    target_resource_type = proto.Field(proto.STRING, number=2)

    action = proto.Field(proto.STRING, number=3)


class RelatedAsset(proto.Message):
    r"""An asset identify in Google Cloud which contains its name, type and
    ancestors. An asset can be any resource in the Google Cloud
    `resource
    hierarchy <https://cloud.google.com/resource-manager/docs/cloud-platform-resource-hierarchy>`__,
    a resource outside the Google Cloud resource hierarchy (such as
    Google Kubernetes Engine clusters and objects), or a policy (e.g.
    Cloud IAM policy). See `Supported asset
    types <https://cloud.google.com/asset-inventory/docs/supported-asset-types>`__
    for more information.

    Attributes:
        asset (str):
            The full name of the asset. Example:
            ``//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1``

            See `Resource
            names <https://cloud.google.com/apis/design/resource_names#full_resource_name>`__
            for more information.
        asset_type (str):
            The type of the asset. Example:
            ``compute.googleapis.com/Disk``

            See `Supported asset
            types <https://cloud.google.com/asset-inventory/docs/supported-asset-types>`__
            for more information.
        ancestors (Sequence[str]):
            The ancestors of an asset in Google Cloud `resource
            hierarchy <https://cloud.google.com/resource-manager/docs/cloud-platform-resource-hierarchy>`__,
            represented as a list of relative resource names. An
            ancestry path starts with the closest ancestor in the
            hierarchy and ends at root.

            Example:
            ``["projects/123456789", "folders/5432", "organizations/1234"]``
    """

    asset = proto.Field(proto.STRING, number=1)

    asset_type = proto.Field(proto.STRING, number=2)

    ancestors = proto.RepeatedField(proto.STRING, number=3)


__all__ = tuple(sorted(__protobuf__.manifest))
