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

from google.api import auth_pb2  # type: ignore
from google.api import documentation_pb2  # type: ignore
from google.api import endpoint_pb2  # type: ignore
from google.api import monitored_resource_pb2  # type: ignore
from google.api import monitoring_pb2  # type: ignore
from google.api import quota_pb2  # type: ignore
from google.api import usage_pb2  # type: ignore
from google.protobuf import api_pb2  # type: ignore


__protobuf__ = proto.module(
    package='google.api.serviceusage.v1beta1',
    manifest={
        'State',
        'QuotaView',
        'QuotaSafetyCheck',
        'Service',
        'ServiceConfig',
        'OperationMetadata',
        'ConsumerQuotaMetric',
        'ConsumerQuotaLimit',
        'QuotaBucket',
        'QuotaOverride',
        'OverrideInlineSource',
        'AdminQuotaPolicy',
        'ServiceIdentity',
    },
)


class State(proto.Enum):
    r"""Whether or not a service has been enabled for use by a
    consumer.
    """
    STATE_UNSPECIFIED = 0
    DISABLED = 1
    ENABLED = 2


class QuotaView(proto.Enum):
    r"""Selected view of quota. Can be used to request more detailed
    quota information when retrieving quota metrics and limits.
    """
    QUOTA_VIEW_UNSPECIFIED = 0
    BASIC = 1
    FULL = 2


class QuotaSafetyCheck(proto.Enum):
    r"""Enumerations of quota safety checks."""
    QUOTA_SAFETY_CHECK_UNSPECIFIED = 0
    LIMIT_DECREASE_BELOW_USAGE = 1
    LIMIT_DECREASE_PERCENTAGE_TOO_HIGH = 2


class Service(proto.Message):
    r"""A service that is available for use by the consumer.
    Attributes:
        name (str):
            The resource name of the consumer and service.

            A valid name would be:

            -  ``projects/123/services/serviceusage.googleapis.com``
        parent (str):
            The resource name of the consumer.

            A valid name would be:

            -  ``projects/123``
        config (google.api.serviceusage_v1beta1.types.ServiceConfig):
            The service configuration of the available service. Some
            fields may be filtered out of the configuration in responses
            to the ``ListServices`` method. These fields are present
            only in responses to the ``GetService`` method.
        state (google.api.serviceusage_v1beta1.types.State):
            Whether or not the service has been enabled
            for use by the consumer.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    parent = proto.Field(
        proto.STRING,
        number=5,
    )
    config = proto.Field(
        proto.MESSAGE,
        number=2,
        message='ServiceConfig',
    )
    state = proto.Field(
        proto.ENUM,
        number=4,
        enum='State',
    )


class ServiceConfig(proto.Message):
    r"""The configuration of the service.
    Attributes:
        name (str):
            The DNS address at which this service is available.

            An example DNS address would be:
            ``calendar.googleapis.com``.
        title (str):
            The product title for this service.
        apis (Sequence[google.protobuf.api_pb2.Api]):
            A list of API interfaces exported by this
            service. Contains only the names, versions, and
            method names of the interfaces.
        documentation (google.api.documentation_pb2.Documentation):
            Additional API documentation. Contains only
            the summary and the documentation URL.
        quota (google.api.quota_pb2.Quota):
            Quota configuration.
        authentication (google.api.auth_pb2.Authentication):
            Auth configuration. Contains only the OAuth
            rules.
        usage (google.api.usage_pb2.Usage):
            Configuration controlling usage of this
            service.
        endpoints (Sequence[google.api.endpoint_pb2.Endpoint]):
            Configuration for network endpoints. Contains
            only the names and aliases of the endpoints.
        monitored_resources (Sequence[google.api.monitored_resource_pb2.MonitoredResourceDescriptor]):
            Defines the monitored resources used by this service. This
            is required by the
            [Service.monitoring][google.api.Service.monitoring] and
            [Service.logging][google.api.Service.logging]
            configurations.
        monitoring (google.api.monitoring_pb2.Monitoring):
            Monitoring configuration. This should not include the
            'producer_destinations' field.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    title = proto.Field(
        proto.STRING,
        number=2,
    )
    apis = proto.RepeatedField(
        proto.MESSAGE,
        number=3,
        message=api_pb2.Api,
    )
    documentation = proto.Field(
        proto.MESSAGE,
        number=6,
        message=documentation_pb2.Documentation,
    )
    quota = proto.Field(
        proto.MESSAGE,
        number=10,
        message=quota_pb2.Quota,
    )
    authentication = proto.Field(
        proto.MESSAGE,
        number=11,
        message=auth_pb2.Authentication,
    )
    usage = proto.Field(
        proto.MESSAGE,
        number=15,
        message=usage_pb2.Usage,
    )
    endpoints = proto.RepeatedField(
        proto.MESSAGE,
        number=18,
        message=endpoint_pb2.Endpoint,
    )
    monitored_resources = proto.RepeatedField(
        proto.MESSAGE,
        number=25,
        message=monitored_resource_pb2.MonitoredResourceDescriptor,
    )
    monitoring = proto.Field(
        proto.MESSAGE,
        number=28,
        message=monitoring_pb2.Monitoring,
    )


class OperationMetadata(proto.Message):
    r"""The operation metadata returned for the batchend services
    operation.

    Attributes:
        resource_names (Sequence[str]):
            The full name of the resources that this
            operation is directly associated with.
    """

    resource_names = proto.RepeatedField(
        proto.STRING,
        number=2,
    )


class ConsumerQuotaMetric(proto.Message):
    r"""Consumer quota settings for a quota metric.
    Attributes:
        name (str):
            The resource name of the quota settings on this metric for
            this consumer.

            An example name would be:
            ``projects/123/services/compute.googleapis.com/consumerQuotaMetrics/compute.googleapis.com%2Fcpus``

            The resource name is intended to be opaque and should not be
            parsed for its component strings, since its representation
            could change in the future.
        metric (str):
            The name of the metric.

            An example name would be: ``compute.googleapis.com/cpus``
        display_name (str):
            The display name of the metric.

            An example name would be: ``CPUs``
        consumer_quota_limits (Sequence[google.api.serviceusage_v1beta1.types.ConsumerQuotaLimit]):
            The consumer quota for each quota limit
            defined on the metric.
        descendant_consumer_quota_limits (Sequence[google.api.serviceusage_v1beta1.types.ConsumerQuotaLimit]):
            The quota limits targeting the descendant containers of the
            consumer in request.

            If the consumer in request is of type ``organizations`` or
            ``folders``, the field will list per-project limits in the
            metric; if the consumer in request is of type ``project``,
            the field will be empty.

            The ``quota_buckets`` field of each descendant consumer
            quota limit will not be populated.
        unit (str):
            The units in which the metric value is
            reported.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    metric = proto.Field(
        proto.STRING,
        number=4,
    )
    display_name = proto.Field(
        proto.STRING,
        number=2,
    )
    consumer_quota_limits = proto.RepeatedField(
        proto.MESSAGE,
        number=3,
        message='ConsumerQuotaLimit',
    )
    descendant_consumer_quota_limits = proto.RepeatedField(
        proto.MESSAGE,
        number=6,
        message='ConsumerQuotaLimit',
    )
    unit = proto.Field(
        proto.STRING,
        number=5,
    )


class ConsumerQuotaLimit(proto.Message):
    r"""Consumer quota settings for a quota limit.
    Attributes:
        name (str):
            The resource name of the quota limit.

            An example name would be:
            ``projects/123/services/compute.googleapis.com/consumerQuotaMetrics/compute.googleapis.com%2Fcpus/limits/%2Fproject%2Fregion``

            The resource name is intended to be opaque and should not be
            parsed for its component strings, since its representation
            could change in the future.
        metric (str):
            The name of the parent metric of this limit.

            An example name would be: ``compute.googleapis.com/cpus``
        unit (str):
            The limit unit.

            An example unit would be ``1/{project}/{region}`` Note that
            ``{project}`` and ``{region}`` are not placeholders in this
            example; the literal characters ``{`` and ``}`` occur in the
            string.
        is_precise (bool):
            Whether this limit is precise or imprecise.
        allows_admin_overrides (bool):
            Whether admin overrides are allowed on this
            limit
        quota_buckets (Sequence[google.api.serviceusage_v1beta1.types.QuotaBucket]):
            Summary of the enforced quota buckets,
            organized by quota dimension, ordered from least
            specific to most specific (for example, the
            global default bucket, with no quota dimensions,
            will always appear first).
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    metric = proto.Field(
        proto.STRING,
        number=8,
    )
    unit = proto.Field(
        proto.STRING,
        number=2,
    )
    is_precise = proto.Field(
        proto.BOOL,
        number=3,
    )
    allows_admin_overrides = proto.Field(
        proto.BOOL,
        number=7,
    )
    quota_buckets = proto.RepeatedField(
        proto.MESSAGE,
        number=9,
        message='QuotaBucket',
    )


class QuotaBucket(proto.Message):
    r"""A quota bucket is a quota provisioning unit for a specific
    set of dimensions.

    Attributes:
        effective_limit (int):
            The effective limit of this quota bucket. Equal to
            default_limit if there are no overrides.
        default_limit (int):
            The default limit of this quota bucket, as
            specified by the service configuration.
        producer_override (google.api.serviceusage_v1beta1.types.QuotaOverride):
            Producer override on this quota bucket.
        consumer_override (google.api.serviceusage_v1beta1.types.QuotaOverride):
            Consumer override on this quota bucket.
        admin_override (google.api.serviceusage_v1beta1.types.QuotaOverride):
            Admin override on this quota bucket.
        dimensions (Sequence[google.api.serviceusage_v1beta1.types.QuotaBucket.DimensionsEntry]):
            The dimensions of this quota bucket.

            If this map is empty, this is the global bucket, which is
            the default quota value applied to all requests that do not
            have a more specific override.

            If this map is nonempty, the default limit, effective limit,
            and quota overrides apply only to requests that have the
            dimensions given in the map.

            For example, if the map has key ``region`` and value
            ``us-east-1``, then the specified effective limit is only
            effective in that region, and the specified overrides apply
            only in that region.
    """

    effective_limit = proto.Field(
        proto.INT64,
        number=1,
    )
    default_limit = proto.Field(
        proto.INT64,
        number=2,
    )
    producer_override = proto.Field(
        proto.MESSAGE,
        number=3,
        message='QuotaOverride',
    )
    consumer_override = proto.Field(
        proto.MESSAGE,
        number=4,
        message='QuotaOverride',
    )
    admin_override = proto.Field(
        proto.MESSAGE,
        number=5,
        message='QuotaOverride',
    )
    dimensions = proto.MapField(
        proto.STRING,
        proto.STRING,
        number=6,
    )


class QuotaOverride(proto.Message):
    r"""A quota override
    Attributes:
        name (str):
            The resource name of the override. This name is generated by
            the server when the override is created.

            Example names would be:
            ``projects/123/services/compute.googleapis.com/consumerQuotaMetrics/compute.googleapis.com%2Fcpus/limits/%2Fproject%2Fregion/adminOverrides/4a3f2c1d``
            ``projects/123/services/compute.googleapis.com/consumerQuotaMetrics/compute.googleapis.com%2Fcpus/limits/%2Fproject%2Fregion/consumerOverrides/4a3f2c1d``

            The resource name is intended to be opaque and should not be
            parsed for its component strings, since its representation
            could change in the future.
        override_value (int):
            The overriding quota limit value.
            Can be any nonnegative integer, or -1 (unlimited
            quota).
        dimensions (Sequence[google.api.serviceusage_v1beta1.types.QuotaOverride.DimensionsEntry]):
            If this map is nonempty, then this override applies only to
            specific values for dimensions defined in the limit unit.

            For example, an override on a limit with the unit
            ``1/{project}/{region}`` could contain an entry with the key
            ``region`` and the value ``us-east-1``; the override is only
            applied to quota consumed in that region.

            This map has the following restrictions:

            -  Keys that are not defined in the limit's unit are not
               valid keys. Any string appearing in ``{brackets}`` in the
               unit (besides ``{project}`` or ``{user}``) is a defined
               key.
            -  ``project`` is not a valid key; the project is already
               specified in the parent resource name.
            -  ``user`` is not a valid key; the API does not support
               quota overrides that apply only to a specific user.
            -  If ``region`` appears as a key, its value must be a valid
               Cloud region.
            -  If ``zone`` appears as a key, its value must be a valid
               Cloud zone.
            -  If any valid key other than ``region`` or ``zone``
               appears in the map, then all valid keys other than
               ``region`` or ``zone`` must also appear in the map.
        metric (str):
            The name of the metric to which this override applies.

            An example name would be: ``compute.googleapis.com/cpus``
        unit (str):
            The limit unit of the limit to which this override applies.

            An example unit would be: ``1/{project}/{region}`` Note that
            ``{project}`` and ``{region}`` are not placeholders in this
            example; the literal characters ``{`` and ``}`` occur in the
            string.
        admin_override_ancestor (str):
            The resource name of the ancestor that requested the
            override. For example: ``organizations/12345`` or
            ``folders/67890``. Used by admin overrides only.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    override_value = proto.Field(
        proto.INT64,
        number=2,
    )
    dimensions = proto.MapField(
        proto.STRING,
        proto.STRING,
        number=3,
    )
    metric = proto.Field(
        proto.STRING,
        number=4,
    )
    unit = proto.Field(
        proto.STRING,
        number=5,
    )
    admin_override_ancestor = proto.Field(
        proto.STRING,
        number=6,
    )


class OverrideInlineSource(proto.Message):
    r"""Import data embedded in the request message
    Attributes:
        overrides (Sequence[google.api.serviceusage_v1beta1.types.QuotaOverride]):
            The overrides to create.
            Each override must have a value for 'metric' and
            'unit', to specify which metric and which limit
            the override should be applied to. The 'name'
            field of the override does not need to be set;
            it is ignored.
    """

    overrides = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='QuotaOverride',
    )


class AdminQuotaPolicy(proto.Message):
    r"""Quota policy created by quota administrator.
    Attributes:
        name (str):
            The resource name of the policy. This name is generated by
            the server when the policy is created.

            Example names would be:
            ``organizations/123/services/compute.googleapis.com/consumerQuotaMetrics/compute.googleapis.com%2Fcpus/limits/%2Fproject%2Fregion/adminQuotaPolicies/4a3f2c1d``
        policy_value (int):
            The quota policy value.
            Can be any nonnegative integer, or -1 (unlimited
            quota).
        dimensions (Sequence[google.api.serviceusage_v1beta1.types.AdminQuotaPolicy.DimensionsEntry]):
            If this map is nonempty, then this policy applies only to
            specific values for dimensions defined in the limit unit.

            For example, an policy on a limit with the unit
            ``1/{project}/{region}`` could contain an entry with the key
            ``region`` and the value ``us-east-1``; the policy is only
            applied to quota consumed in that region.

            This map has the following restrictions:

            -  If ``region`` appears as a key, its value must be a valid
               Cloud region.
            -  If ``zone`` appears as a key, its value must be a valid
               Cloud zone.
            -  Keys other than ``region`` or ``zone`` are not valid.
        metric (str):
            The name of the metric to which this policy applies.

            An example name would be: ``compute.googleapis.com/cpus``
        unit (str):
            The limit unit of the limit to which this policy applies.

            An example unit would be: ``1/{project}/{region}`` Note that
            ``{project}`` and ``{region}`` are not placeholders in this
            example; the literal characters ``{`` and ``}`` occur in the
            string.
        container (str):
            The cloud resource container at which the quota policy is
            created. The format is
            ``{container_type}/{container_number}``
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    policy_value = proto.Field(
        proto.INT64,
        number=2,
    )
    dimensions = proto.MapField(
        proto.STRING,
        proto.STRING,
        number=3,
    )
    metric = proto.Field(
        proto.STRING,
        number=4,
    )
    unit = proto.Field(
        proto.STRING,
        number=5,
    )
    container = proto.Field(
        proto.STRING,
        number=6,
    )


class ServiceIdentity(proto.Message):
    r"""Service identity for a service. This is the identity that
    service producer should use to access consumer resources.

    Attributes:
        email (str):
            The email address of the service account that
            a service producer would use to access consumer
            resources.
        unique_id (str):
            The unique and stable id of the service
            account.
            https://cloud.google.com/iam/reference/rest/v1/projects.serviceAccounts#ServiceAccount
    """

    email = proto.Field(
        proto.STRING,
        number=1,
    )
    unique_id = proto.Field(
        proto.STRING,
        number=2,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
