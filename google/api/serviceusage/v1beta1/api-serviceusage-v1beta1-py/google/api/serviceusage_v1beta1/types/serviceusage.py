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

from google.api.serviceusage_v1beta1.types import resources
from google.protobuf import field_mask_pb2  # type: ignore


__protobuf__ = proto.module(
    package='google.api.serviceusage.v1beta1',
    manifest={
        'EnableServiceRequest',
        'DisableServiceRequest',
        'GetServiceRequest',
        'ListServicesRequest',
        'ListServicesResponse',
        'BatchEnableServicesRequest',
        'ListConsumerQuotaMetricsRequest',
        'ListConsumerQuotaMetricsResponse',
        'GetConsumerQuotaMetricRequest',
        'GetConsumerQuotaLimitRequest',
        'CreateAdminOverrideRequest',
        'UpdateAdminOverrideRequest',
        'DeleteAdminOverrideRequest',
        'ListAdminOverridesRequest',
        'ListAdminOverridesResponse',
        'BatchCreateAdminOverridesResponse',
        'ImportAdminOverridesRequest',
        'ImportAdminOverridesResponse',
        'ImportAdminOverridesMetadata',
        'CreateConsumerOverrideRequest',
        'UpdateConsumerOverrideRequest',
        'DeleteConsumerOverrideRequest',
        'ListConsumerOverridesRequest',
        'ListConsumerOverridesResponse',
        'BatchCreateConsumerOverridesResponse',
        'ImportConsumerOverridesRequest',
        'ImportConsumerOverridesResponse',
        'ImportConsumerOverridesMetadata',
        'ImportAdminQuotaPoliciesResponse',
        'ImportAdminQuotaPoliciesMetadata',
        'CreateAdminQuotaPolicyMetadata',
        'UpdateAdminQuotaPolicyMetadata',
        'DeleteAdminQuotaPolicyMetadata',
        'GenerateServiceIdentityRequest',
        'GetServiceIdentityResponse',
        'GetServiceIdentityMetadata',
    },
)


class EnableServiceRequest(proto.Message):
    r"""Request message for the ``EnableService`` method.

    Attributes:
        name (str):
            Name of the consumer and service to enable the service on.

            The ``EnableService`` and ``DisableService`` methods
            currently only support projects.

            Enabling a service requires that the service is public or is
            shared with the user enabling the service.

            An example name would be:
            ``projects/123/services/serviceusage.googleapis.com`` where
            ``123`` is the project number (not project ID).
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class DisableServiceRequest(proto.Message):
    r"""Request message for the ``DisableService`` method.

    Attributes:
        name (str):
            Name of the consumer and service to disable the service on.

            The enable and disable methods currently only support
            projects.

            An example name would be:
            ``projects/123/services/serviceusage.googleapis.com`` where
            ``123`` is the project number (not project ID).
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class GetServiceRequest(proto.Message):
    r"""Request message for the ``GetService`` method.

    Attributes:
        name (str):
            Name of the consumer and service to get the
            ``ConsumerState`` for.

            An example name would be:
            ``projects/123/services/serviceusage.googleapis.com`` where
            ``123`` is the project number (not project ID).
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class ListServicesRequest(proto.Message):
    r"""Request message for the ``ListServices`` method.

    Attributes:
        parent (str):
            Parent to search for services on.

            An example name would be: ``projects/123`` where ``123`` is
            the project number (not project ID).
        page_size (int):
            Requested size of the next page of data.
            Requested page size cannot exceed 200.
             If not set, the default page size is 50.
        page_token (str):
            Token identifying which result to start with,
            which is returned by a previous list call.
        filter (str):
            Only list services that conform to the given filter. The
            allowed filter strings are ``state:ENABLED`` and
            ``state:DISABLED``.
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


class ListServicesResponse(proto.Message):
    r"""Response message for the ``ListServices`` method.

    Attributes:
        services (Sequence[google.api.serviceusage_v1beta1.types.Service]):
            The available services for the requested
            project.
        next_page_token (str):
            Token that can be passed to ``ListServices`` to resume a
            paginated query.
    """

    @property
    def raw_page(self):
        return self

    services = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=resources.Service,
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )


class BatchEnableServicesRequest(proto.Message):
    r"""Request message for the ``BatchEnableServices`` method.

    Attributes:
        parent (str):
            Parent to enable services on.

            An example name would be: ``projects/123`` where ``123`` is
            the project number (not project ID).

            The ``BatchEnableServices`` method currently only supports
            projects.
        service_ids (Sequence[str]):
            The identifiers of the services to enable on the project.

            A valid identifier would be: serviceusage.googleapis.com

            Enabling services requires that each service is public or is
            shared with the user enabling the service.

            Two or more services must be specified. To enable a single
            service, use the ``EnableService`` method instead.

            A single request can enable a maximum of 20 services at a
            time. If more than 20 services are specified, the request
            will fail, and no state changes will occur.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    service_ids = proto.RepeatedField(
        proto.STRING,
        number=2,
    )


class ListConsumerQuotaMetricsRequest(proto.Message):
    r"""Request message for ListConsumerQuotaMetrics

    Attributes:
        parent (str):
            Parent of the quotas resource.

            Some example names would be:
            ``projects/123/services/serviceconsumermanagement.googleapis.com``
            ``folders/345/services/serviceconsumermanagement.googleapis.com``
            ``organizations/456/services/serviceconsumermanagement.googleapis.com``
        page_size (int):
            Requested size of the next page of data.
        page_token (str):
            Token identifying which result to start with;
            returned by a previous list call.
        view (google.api.serviceusage_v1beta1.types.QuotaView):
            Specifies the level of detail for quota
            information in the response.
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
    view = proto.Field(
        proto.ENUM,
        number=4,
        enum=resources.QuotaView,
    )


class ListConsumerQuotaMetricsResponse(proto.Message):
    r"""Response message for ListConsumerQuotaMetrics

    Attributes:
        metrics (Sequence[google.api.serviceusage_v1beta1.types.ConsumerQuotaMetric]):
            Quota settings for the consumer, organized by
            quota metric.
        next_page_token (str):
            Token identifying which result to start with;
            returned by a previous list call.
    """

    @property
    def raw_page(self):
        return self

    metrics = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=resources.ConsumerQuotaMetric,
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )


class GetConsumerQuotaMetricRequest(proto.Message):
    r"""Request message for GetConsumerQuotaMetric

    Attributes:
        name (str):
            The resource name of the quota limit.

            An example name would be:
            ``projects/123/services/serviceusage.googleapis.com/quotas/metrics/serviceusage.googleapis.com%2Fmutate_requests``
        view (google.api.serviceusage_v1beta1.types.QuotaView):
            Specifies the level of detail for quota
            information in the response.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    view = proto.Field(
        proto.ENUM,
        number=2,
        enum=resources.QuotaView,
    )


class GetConsumerQuotaLimitRequest(proto.Message):
    r"""Request message for GetConsumerQuotaLimit

    Attributes:
        name (str):
            The resource name of the quota limit.
            Use the quota limit resource name returned by
            previous ListConsumerQuotaMetrics and
            GetConsumerQuotaMetric API calls.
        view (google.api.serviceusage_v1beta1.types.QuotaView):
            Specifies the level of detail for quota
            information in the response.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    view = proto.Field(
        proto.ENUM,
        number=2,
        enum=resources.QuotaView,
    )


class CreateAdminOverrideRequest(proto.Message):
    r"""Request message for CreateAdminOverride.

    Attributes:
        parent (str):
            The resource name of the parent quota limit, returned by a
            ListConsumerQuotaMetrics or GetConsumerQuotaMetric call.

            An example name would be:
            ``projects/123/services/compute.googleapis.com/consumerQuotaMetrics/compute.googleapis.com%2Fcpus/limits/%2Fproject%2Fregion``
        override (google.api.serviceusage_v1beta1.types.QuotaOverride):
            The admin override to create.
        force (bool):
            Whether to force the creation of the quota
            override. Setting the force parameter to 'true'
            ignores all quota safety checks that would fail
            the request. QuotaSafetyCheck lists all such
            validations.
        force_only (Sequence[google.api.serviceusage_v1beta1.types.QuotaSafetyCheck]):
            The list of quota safety checks to ignore before the
            override mutation. Unlike 'force' field that ignores all the
            quota safety checks, the 'force_only' field ignores only the
            specified checks; other checks are still enforced. The
            'force' and 'force_only' fields cannot both be set.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    override = proto.Field(
        proto.MESSAGE,
        number=2,
        message=resources.QuotaOverride,
    )
    force = proto.Field(
        proto.BOOL,
        number=3,
    )
    force_only = proto.RepeatedField(
        proto.ENUM,
        number=4,
        enum=resources.QuotaSafetyCheck,
    )


class UpdateAdminOverrideRequest(proto.Message):
    r"""Request message for UpdateAdminOverride.

    Attributes:
        name (str):
            The resource name of the override to update.

            An example name would be:
            ``projects/123/services/compute.googleapis.com/consumerQuotaMetrics/compute.googleapis.com%2Fcpus/limits/%2Fproject%2Fregion/adminOverrides/4a3f2c1d``
        override (google.api.serviceusage_v1beta1.types.QuotaOverride):
            The new override. Only the override_value is updated; all
            other fields are ignored.
        force (bool):
            Whether to force the update of the quota
            override. Setting the force parameter to 'true'
            ignores all quota safety checks that would fail
            the request. QuotaSafetyCheck lists all such
            validations.
        update_mask (google.protobuf.field_mask_pb2.FieldMask):
            Update only the specified fields of the
            override. If unset, all fields will be updated.
        force_only (Sequence[google.api.serviceusage_v1beta1.types.QuotaSafetyCheck]):
            The list of quota safety checks to ignore before the
            override mutation. Unlike 'force' field that ignores all the
            quota safety checks, the 'force_only' field ignores only the
            specified checks; other checks are still enforced. The
            'force' and 'force_only' fields cannot both be set.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    override = proto.Field(
        proto.MESSAGE,
        number=2,
        message=resources.QuotaOverride,
    )
    force = proto.Field(
        proto.BOOL,
        number=3,
    )
    update_mask = proto.Field(
        proto.MESSAGE,
        number=4,
        message=field_mask_pb2.FieldMask,
    )
    force_only = proto.RepeatedField(
        proto.ENUM,
        number=5,
        enum=resources.QuotaSafetyCheck,
    )


class DeleteAdminOverrideRequest(proto.Message):
    r"""Request message for DeleteAdminOverride.

    Attributes:
        name (str):
            The resource name of the override to delete.

            An example name would be:
            ``projects/123/services/compute.googleapis.com/consumerQuotaMetrics/compute.googleapis.com%2Fcpus/limits/%2Fproject%2Fregion/adminOverrides/4a3f2c1d``
        force (bool):
            Whether to force the deletion of the quota
            override. Setting the force parameter to 'true'
            ignores all quota safety checks that would fail
            the request. QuotaSafetyCheck lists all such
            validations.
        force_only (Sequence[google.api.serviceusage_v1beta1.types.QuotaSafetyCheck]):
            The list of quota safety checks to ignore before the
            override mutation. Unlike 'force' field that ignores all the
            quota safety checks, the 'force_only' field ignores only the
            specified checks; other checks are still enforced. The
            'force' and 'force_only' fields cannot both be set.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    force = proto.Field(
        proto.BOOL,
        number=2,
    )
    force_only = proto.RepeatedField(
        proto.ENUM,
        number=3,
        enum=resources.QuotaSafetyCheck,
    )


class ListAdminOverridesRequest(proto.Message):
    r"""Request message for ListAdminOverrides

    Attributes:
        parent (str):
            The resource name of the parent quota limit, returned by a
            ListConsumerQuotaMetrics or GetConsumerQuotaMetric call.

            An example name would be:
            ``projects/123/services/compute.googleapis.com/consumerQuotaMetrics/compute.googleapis.com%2Fcpus/limits/%2Fproject%2Fregion``
        page_size (int):
            Requested size of the next page of data.
        page_token (str):
            Token identifying which result to start with;
            returned by a previous list call.
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


class ListAdminOverridesResponse(proto.Message):
    r"""Response message for ListAdminOverrides.

    Attributes:
        overrides (Sequence[google.api.serviceusage_v1beta1.types.QuotaOverride]):
            Admin overrides on this limit.
        next_page_token (str):
            Token identifying which result to start with;
            returned by a previous list call.
    """

    @property
    def raw_page(self):
        return self

    overrides = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=resources.QuotaOverride,
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )


class BatchCreateAdminOverridesResponse(proto.Message):
    r"""Response message for BatchCreateAdminOverrides

    Attributes:
        overrides (Sequence[google.api.serviceusage_v1beta1.types.QuotaOverride]):
            The overrides that were created.
    """

    overrides = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=resources.QuotaOverride,
    )


class ImportAdminOverridesRequest(proto.Message):
    r"""Request message for ImportAdminOverrides

    .. _oneof: https://proto-plus-python.readthedocs.io/en/stable/fields.html#oneofs-mutually-exclusive-fields

    Attributes:
        parent (str):
            The resource name of the consumer.

            An example name would be:
            ``projects/123/services/compute.googleapis.com``
        inline_source (google.api.serviceusage_v1beta1.types.OverrideInlineSource):
            The import data is specified in the request
            message itself

            This field is a member of `oneof`_ ``source``.
        force (bool):
            Whether to force the creation of the quota
            overrides. Setting the force parameter to 'true'
            ignores all quota safety checks that would fail
            the request. QuotaSafetyCheck lists all such
            validations.
        force_only (Sequence[google.api.serviceusage_v1beta1.types.QuotaSafetyCheck]):
            The list of quota safety checks to ignore before the
            override mutation. Unlike 'force' field that ignores all the
            quota safety checks, the 'force_only' field ignores only the
            specified checks; other checks are still enforced. The
            'force' and 'force_only' fields cannot both be set.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    inline_source = proto.Field(
        proto.MESSAGE,
        number=2,
        oneof='source',
        message=resources.OverrideInlineSource,
    )
    force = proto.Field(
        proto.BOOL,
        number=3,
    )
    force_only = proto.RepeatedField(
        proto.ENUM,
        number=4,
        enum=resources.QuotaSafetyCheck,
    )


class ImportAdminOverridesResponse(proto.Message):
    r"""Response message for ImportAdminOverrides

    Attributes:
        overrides (Sequence[google.api.serviceusage_v1beta1.types.QuotaOverride]):
            The overrides that were created from the
            imported data.
    """

    overrides = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=resources.QuotaOverride,
    )


class ImportAdminOverridesMetadata(proto.Message):
    r"""Metadata message that provides information such as progress,
    partial failures, and similar information on each GetOperation
    call of LRO returned by ImportAdminOverrides.

    """


class CreateConsumerOverrideRequest(proto.Message):
    r"""Request message for CreateConsumerOverride.

    Attributes:
        parent (str):
            The resource name of the parent quota limit, returned by a
            ListConsumerQuotaMetrics or GetConsumerQuotaMetric call.

            An example name would be:
            ``projects/123/services/compute.googleapis.com/consumerQuotaMetrics/compute.googleapis.com%2Fcpus/limits/%2Fproject%2Fregion``
        override (google.api.serviceusage_v1beta1.types.QuotaOverride):
            The override to create.
        force (bool):
            Whether to force the creation of the quota
            override. Setting the force parameter to 'true'
            ignores all quota safety checks that would fail
            the request. QuotaSafetyCheck lists all such
            validations.
        force_only (Sequence[google.api.serviceusage_v1beta1.types.QuotaSafetyCheck]):
            The list of quota safety checks to ignore before the
            override mutation. Unlike 'force' field that ignores all the
            quota safety checks, the 'force_only' field ignores only the
            specified checks; other checks are still enforced. The
            'force' and 'force_only' fields cannot both be set.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    override = proto.Field(
        proto.MESSAGE,
        number=2,
        message=resources.QuotaOverride,
    )
    force = proto.Field(
        proto.BOOL,
        number=3,
    )
    force_only = proto.RepeatedField(
        proto.ENUM,
        number=4,
        enum=resources.QuotaSafetyCheck,
    )


class UpdateConsumerOverrideRequest(proto.Message):
    r"""Request message for UpdateConsumerOverride.

    Attributes:
        name (str):
            The resource name of the override to update.

            An example name would be:
            ``projects/123/services/compute.googleapis.com/consumerQuotaMetrics/compute.googleapis.com%2Fcpus/limits/%2Fproject%2Fregion/consumerOverrides/4a3f2c1d``
        override (google.api.serviceusage_v1beta1.types.QuotaOverride):
            The new override. Only the override_value is updated; all
            other fields are ignored.
        force (bool):
            Whether to force the update of the quota
            override. Setting the force parameter to 'true'
            ignores all quota safety checks that would fail
            the request. QuotaSafetyCheck lists all such
            validations.
        update_mask (google.protobuf.field_mask_pb2.FieldMask):
            Update only the specified fields of the
            override. If unset, all fields will be updated.
        force_only (Sequence[google.api.serviceusage_v1beta1.types.QuotaSafetyCheck]):
            The list of quota safety checks to ignore before the
            override mutation. Unlike 'force' field that ignores all the
            quota safety checks, the 'force_only' field ignores only the
            specified checks; other checks are still enforced. The
            'force' and 'force_only' fields cannot both be set.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    override = proto.Field(
        proto.MESSAGE,
        number=2,
        message=resources.QuotaOverride,
    )
    force = proto.Field(
        proto.BOOL,
        number=3,
    )
    update_mask = proto.Field(
        proto.MESSAGE,
        number=4,
        message=field_mask_pb2.FieldMask,
    )
    force_only = proto.RepeatedField(
        proto.ENUM,
        number=5,
        enum=resources.QuotaSafetyCheck,
    )


class DeleteConsumerOverrideRequest(proto.Message):
    r"""Request message for DeleteConsumerOverride.

    Attributes:
        name (str):
            The resource name of the override to delete.

            An example name would be:
            ``projects/123/services/compute.googleapis.com/consumerQuotaMetrics/compute.googleapis.com%2Fcpus/limits/%2Fproject%2Fregion/consumerOverrides/4a3f2c1d``
        force (bool):
            Whether to force the deletion of the quota
            override. Setting the force parameter to 'true'
            ignores all quota safety checks that would fail
            the request. QuotaSafetyCheck lists all such
            validations.
        force_only (Sequence[google.api.serviceusage_v1beta1.types.QuotaSafetyCheck]):
            The list of quota safety checks to ignore before the
            override mutation. Unlike 'force' field that ignores all the
            quota safety checks, the 'force_only' field ignores only the
            specified checks; other checks are still enforced. The
            'force' and 'force_only' fields cannot both be set.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    force = proto.Field(
        proto.BOOL,
        number=2,
    )
    force_only = proto.RepeatedField(
        proto.ENUM,
        number=3,
        enum=resources.QuotaSafetyCheck,
    )


class ListConsumerOverridesRequest(proto.Message):
    r"""Request message for ListConsumerOverrides

    Attributes:
        parent (str):
            The resource name of the parent quota limit, returned by a
            ListConsumerQuotaMetrics or GetConsumerQuotaMetric call.

            An example name would be:
            ``projects/123/services/compute.googleapis.com/consumerQuotaMetrics/compute.googleapis.com%2Fcpus/limits/%2Fproject%2Fregion``
        page_size (int):
            Requested size of the next page of data.
        page_token (str):
            Token identifying which result to start with;
            returned by a previous list call.
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


class ListConsumerOverridesResponse(proto.Message):
    r"""Response message for ListConsumerOverrides.

    Attributes:
        overrides (Sequence[google.api.serviceusage_v1beta1.types.QuotaOverride]):
            Consumer overrides on this limit.
        next_page_token (str):
            Token identifying which result to start with;
            returned by a previous list call.
    """

    @property
    def raw_page(self):
        return self

    overrides = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=resources.QuotaOverride,
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )


class BatchCreateConsumerOverridesResponse(proto.Message):
    r"""Response message for BatchCreateConsumerOverrides

    Attributes:
        overrides (Sequence[google.api.serviceusage_v1beta1.types.QuotaOverride]):
            The overrides that were created.
    """

    overrides = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=resources.QuotaOverride,
    )


class ImportConsumerOverridesRequest(proto.Message):
    r"""Request message for ImportConsumerOverrides

    .. _oneof: https://proto-plus-python.readthedocs.io/en/stable/fields.html#oneofs-mutually-exclusive-fields

    Attributes:
        parent (str):
            The resource name of the consumer.

            An example name would be:
            ``projects/123/services/compute.googleapis.com``
        inline_source (google.api.serviceusage_v1beta1.types.OverrideInlineSource):
            The import data is specified in the request
            message itself

            This field is a member of `oneof`_ ``source``.
        force (bool):
            Whether to force the creation of the quota
            overrides. Setting the force parameter to 'true'
            ignores all quota safety checks that would fail
            the request. QuotaSafetyCheck lists all such
            validations.
        force_only (Sequence[google.api.serviceusage_v1beta1.types.QuotaSafetyCheck]):
            The list of quota safety checks to ignore before the
            override mutation. Unlike 'force' field that ignores all the
            quota safety checks, the 'force_only' field ignores only the
            specified checks; other checks are still enforced. The
            'force' and 'force_only' fields cannot both be set.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    inline_source = proto.Field(
        proto.MESSAGE,
        number=2,
        oneof='source',
        message=resources.OverrideInlineSource,
    )
    force = proto.Field(
        proto.BOOL,
        number=3,
    )
    force_only = proto.RepeatedField(
        proto.ENUM,
        number=4,
        enum=resources.QuotaSafetyCheck,
    )


class ImportConsumerOverridesResponse(proto.Message):
    r"""Response message for ImportConsumerOverrides

    Attributes:
        overrides (Sequence[google.api.serviceusage_v1beta1.types.QuotaOverride]):
            The overrides that were created from the
            imported data.
    """

    overrides = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=resources.QuotaOverride,
    )


class ImportConsumerOverridesMetadata(proto.Message):
    r"""Metadata message that provides information such as progress,
    partial failures, and similar information on each GetOperation
    call of LRO returned by ImportConsumerOverrides.

    """


class ImportAdminQuotaPoliciesResponse(proto.Message):
    r"""Response message for ImportAdminQuotaPolicies

    Attributes:
        policies (Sequence[google.api.serviceusage_v1beta1.types.AdminQuotaPolicy]):
            The policies that were created from the
            imported data.
    """

    policies = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=resources.AdminQuotaPolicy,
    )


class ImportAdminQuotaPoliciesMetadata(proto.Message):
    r"""Metadata message that provides information such as progress,
    partial failures, and similar information on each GetOperation
    call of LRO returned by ImportAdminQuotaPolicies.

    """


class CreateAdminQuotaPolicyMetadata(proto.Message):
    r"""Metadata message that provides information such as progress,
    partial failures, and similar information on each GetOperation
    call of LRO returned by CreateAdminQuotaPolicy.

    """


class UpdateAdminQuotaPolicyMetadata(proto.Message):
    r"""Metadata message that provides information such as progress,
    partial failures, and similar information on each GetOperation
    call of LRO returned by UpdateAdminQuotaPolicy.

    """


class DeleteAdminQuotaPolicyMetadata(proto.Message):
    r"""Metadata message that provides information such as progress,
    partial failures, and similar information on each GetOperation
    call of LRO returned by DeleteAdminQuotaPolicy.

    """


class GenerateServiceIdentityRequest(proto.Message):
    r"""Request message for generating service identity.

    Attributes:
        parent (str):
            Name of the consumer and service to generate an identity
            for.

            The ``GenerateServiceIdentity`` methods currently only
            support projects.

            An example name would be:
            ``projects/123/services/example.googleapis.com`` where
            ``123`` is the project number.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )


class GetServiceIdentityResponse(proto.Message):
    r"""Response message for getting service identity.

    Attributes:
        identity (google.api.serviceusage_v1beta1.types.ServiceIdentity):
            Service identity that service producer can use to access
            consumer resources. If exists is true, it contains email and
            unique_id. If exists is false, it contains pre-constructed
            email and empty unique_id.
        state (google.api.serviceusage_v1beta1.types.GetServiceIdentityResponse.IdentityState):
            Service identity state.
    """
    class IdentityState(proto.Enum):
        r"""Enum for service identity state."""
        IDENTITY_STATE_UNSPECIFIED = 0
        ACTIVE = 1

    identity = proto.Field(
        proto.MESSAGE,
        number=1,
        message=resources.ServiceIdentity,
    )
    state = proto.Field(
        proto.ENUM,
        number=2,
        enum=IdentityState,
    )


class GetServiceIdentityMetadata(proto.Message):
    r"""Metadata for the ``GetServiceIdentity`` method.
    """


__all__ = tuple(sorted(__protobuf__.manifest))
