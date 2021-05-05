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

from google.cloud.securitycenter.settings_v1beta1.types import component_settings as gcss_component_settings
from google.cloud.securitycenter.settings_v1beta1.types import detector
from google.cloud.securitycenter.settings_v1beta1.types import settings as gcss_settings
from google.protobuf import field_mask_pb2  # type: ignore


__protobuf__ = proto.module(
    package='google.cloud.securitycenter.settings.v1beta1',
    manifest={
        'GetServiceAccountRequest',
        'ServiceAccount',
        'GetSettingsRequest',
        'UpdateSettingsRequest',
        'ResetSettingsRequest',
        'BatchGetSettingsRequest',
        'BatchGetSettingsResponse',
        'CalculateEffectiveSettingsRequest',
        'BatchCalculateEffectiveSettingsRequest',
        'BatchCalculateEffectiveSettingsResponse',
        'GetComponentSettingsRequest',
        'UpdateComponentSettingsRequest',
        'ResetComponentSettingsRequest',
        'CalculateEffectiveComponentSettingsRequest',
        'ListDetectorsRequest',
        'ListDetectorsResponse',
        'ListComponentsRequest',
        'ListComponentsResponse',
    },
)


class GetServiceAccountRequest(proto.Message):
    r"""Request message for GetServiceAccount.
    Attributes:
        name (str):
            Required. The relative resource name of the service account
            resource. Format:

            -  ``organizations/{organization}/serviceAccount``
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class ServiceAccount(proto.Message):
    r"""An organization-level service account to be used by threat
    detection components.

    Attributes:
        name (str):
            The relative resource name of the service account resource.
            Format:

            -  ``organizations/{organization}/serviceAccount``
        service_account (str):
            Security Center managed service account for the organization
            example service-org-1234@scc.iam.gserviceaccount.com This
            service_account will be stored in the ComponentSettings
            field for the SCC, SHA, and Infra Automation components.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    service_account = proto.Field(
        proto.STRING,
        number=2,
    )


class GetSettingsRequest(proto.Message):
    r"""Request message for GetSettings.
    Attributes:
        name (str):
            Required. The name of the settings to retrieve. Formats:

            -  ``organizations/{organization}/settings``
            -  ``folders/{folder}/settings``
            -  ``projects/{project}/settings``
            -  ``projects/{project}/locations/{location}/clusters/{cluster}/settings``
            -  ``projects/{project}/regions/{region}/clusters/{cluster}/settings``
            -  ``projects/{project}/zones/{zone}/clusters/{cluster}/settings``
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class UpdateSettingsRequest(proto.Message):
    r"""Request message for UpdateSettings.
    Attributes:
        settings (google.cloud.securitycenter.settings_v1beta1.types.Settings):
            Required. The settings to update.

            The settings' ``name`` field is used to identify the
            settings to be updated. Formats:

            -  ``organizations/{organization}/settings``
            -  ``folders/{folder}/settings``
            -  ``projects/{project}/settings``
            -  ``projects/{project}/locations/{location}/clusters/{cluster}/settings``
            -  ``projects/{project}/regions/{region}/clusters/{cluster}/settings``
            -  ``projects/{project}/zones/{zone}/clusters/{cluster}/settings``
        update_mask (google.protobuf.field_mask_pb2.FieldMask):
            The list of fields to be updated on the
            settings.
    """

    settings = proto.Field(
        proto.MESSAGE,
        number=1,
        message=gcss_settings.Settings,
    )
    update_mask = proto.Field(
        proto.MESSAGE,
        number=2,
        message=field_mask_pb2.FieldMask,
    )


class ResetSettingsRequest(proto.Message):
    r"""Request message for ResetSettings.
    Attributes:
        name (str):
            Required. The name of the settings to reset. Formats:

            -  ``organizations/{organization}/settings``
            -  ``folders/{folder}/settings``
            -  ``projects/{project}/settings``
            -  ``projects/{project}/locations/{location}/clusters/{cluster}/settings``
            -  ``projects/{project}/regions/{region}/clusters/{cluster}/settings``
            -  ``projects/{project}/zones/{zone}/clusters/{cluster}/settings``
        etag (str):
            A fingerprint used for optimistic
            concurrency. If none is provided, then the
            existing settings will be blindly overwritten.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    etag = proto.Field(
        proto.STRING,
        number=2,
    )


class BatchGetSettingsRequest(proto.Message):
    r"""Request message for BatchGetSettings.
    Attributes:
        parent (str):
            Required. The relative resource name of the organization
            shared by all of the settings being retrieved. Format:

            -  ``organizations/{organization}``
        names (Sequence[str]):
            The names of the settings to retrieve. A maximum of 1000
            settings can be retrieved in a batch. Formats:

            -  ``organizations/{organization}/settings``
            -  ``folders/{folder}/settings``
            -  ``projects/{project}/settings``
            -  ``projects/{project}/locations/{location}/clusters/{cluster}/settings``
            -  ``projects/{project}/regions/{region}/clusters/{cluster}/settings``
            -  ``projects/{project}/zones/{zone}/clusters/{cluster}/settings``
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    names = proto.RepeatedField(
        proto.STRING,
        number=2,
    )


class BatchGetSettingsResponse(proto.Message):
    r"""Response message for BatchGetSettings.
    Attributes:
        settings (Sequence[google.cloud.securitycenter.settings_v1beta1.types.Settings]):
            Settings requested.
    """

    settings = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=gcss_settings.Settings,
    )


class CalculateEffectiveSettingsRequest(proto.Message):
    r"""Request message for CalculateEffectiveSettings.
    Attributes:
        name (str):
            Required. The name of the effective settings to retrieve.
            Formats:

            -  ``organizations/{organization}/effectiveSettings``
            -  ``folders/{folder}/effectiveSettings``
            -  ``projects/{project}/effectiveSettings``
            -  ``projects/{project}/locations/{location}/clusters/{cluster}/effectiveSettings``
            -  ``projects/{project}/regions/{region}/clusters/{cluster}/effectiveSettings``
            -  ``projects/{project}/zones/{zone}/clusters/{cluster}/effectiveSettings``
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class BatchCalculateEffectiveSettingsRequest(proto.Message):
    r"""Request message for BatchGetEffectiveSettings.
    Attributes:
        parent (str):
            Required. The relative resource name of the organization
            shared by all of the settings being retrieved. Format:

            -  ``organizations/{organization}``
        requests (Sequence[google.cloud.securitycenter.settings_v1beta1.types.CalculateEffectiveSettingsRequest]):
            The requests specifying the effective
            settings to retrieve. A maximum of 1000
            effective settings can be retrieved in a batch.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    requests = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message='CalculateEffectiveSettingsRequest',
    )


class BatchCalculateEffectiveSettingsResponse(proto.Message):
    r"""Response message for BatchGetEffectiveSettings.
    Attributes:
        settings (Sequence[google.cloud.securitycenter.settings_v1beta1.types.Settings]):
            Settings requested.
    """

    settings = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=gcss_settings.Settings,
    )


class GetComponentSettingsRequest(proto.Message):
    r"""Request message for GetComponentSettings.
    Attributes:
        name (str):
            Required. The component settings to retrieve.

            Formats:

            -  ``organizations/{organization}/components/{component}/settings``
            -  ``folders/{folder}/components/{component}/settings``
            -  ``projects/{project}/components/{component}/settings``
            -  ``projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings``
            -  ``projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings``
            -  ``projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings``
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class UpdateComponentSettingsRequest(proto.Message):
    r"""Request message for UpdateComponentSettings.
    Attributes:
        component_settings (google.cloud.securitycenter.settings_v1beta1.types.ComponentSettings):
            Required. The component settings to update.

            The component settings' ``name`` field is used to identify
            the component settings to be updated. Formats:

            -  ``organizations/{organization}/components/{component}/settings``
            -  ``folders/{folder}/components/{component}/settings``
            -  ``projects/{project}/components/{component}/settings``
            -  ``projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings``
            -  ``projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings``
            -  ``projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings``
        update_mask (google.protobuf.field_mask_pb2.FieldMask):
            The list of fields to be updated on the
            component settings resource.
    """

    component_settings = proto.Field(
        proto.MESSAGE,
        number=1,
        message=gcss_component_settings.ComponentSettings,
    )
    update_mask = proto.Field(
        proto.MESSAGE,
        number=2,
        message=field_mask_pb2.FieldMask,
    )


class ResetComponentSettingsRequest(proto.Message):
    r"""Request message for ResetComponentSettings.
    Attributes:
        name (str):
            Required. The component settings to reset.

            Formats:

            -  ``organizations/{organization}/components/{component}/settings``
            -  ``folders/{folder}/components/{component}/settings``
            -  ``projects/{project}/components/{component}/settings``
            -  ``projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings``
            -  ``projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings``
            -  ``projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings``
        etag (str):
            An fingerprint used for optimistic
            concurrency. If none is provided, then the
            existing settings will be blindly overwritten.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    etag = proto.Field(
        proto.STRING,
        number=2,
    )


class CalculateEffectiveComponentSettingsRequest(proto.Message):
    r"""Request message for CalculateEffectiveComponentSettings.
    Attributes:
        name (str):
            Required. The effective component settings to retrieve.

            Formats:

            -  ``organizations/{organization}/components/{component}/settings``
            -  ``folders/{folder}/components/{component}/settings``
            -  ``projects/{project}/components/{component}/settings``
            -  ``projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings``
            -  ``projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings``
            -  ``projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings``
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class ListDetectorsRequest(proto.Message):
    r"""Request message for ListDetectors.
    Attributes:
        parent (str):
            Required. The parent, which owns this collection of
            detectors. Format:

            -  ``organizations/{organization}``
        filter (str):
            Filters to apply on the response. Filters can be applied on:

            -  components
            -  labels
            -  billing tiers

            Component filters will retrieve only detectors for the
            components specified. Label filters will retrieve only
            detectors that match one of the labels specified. Billing
            tier filters will retrieve only detectors for that billing
            tier.

            The filters
        page_size (int):
            The maximum number of detectors to return.
            The service may return fewer than this value. If
            unspecified, at most 100 detectors will be
            returned. The maximum value is 1000; values
            above 1000 will be coerced to 1000.
        page_token (str):
            A page token, received from a previous ``ListDetectors``
            call. Provide this to retrieve the subsequent page.

            When paginating, all other parameters provided to
            ``ListDetectors`` must match the call that provided the page
            token.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    filter = proto.Field(
        proto.STRING,
        number=2,
    )
    page_size = proto.Field(
        proto.INT32,
        number=3,
    )
    page_token = proto.Field(
        proto.STRING,
        number=4,
    )


class ListDetectorsResponse(proto.Message):
    r"""Response message for ListDetectors.
    Attributes:
        detectors (Sequence[google.cloud.securitycenter.settings_v1beta1.types.Detector]):
            The detectors from the specified
            organization.
        next_page_token (str):
            A token that can be sent as ``page_token`` to retrieve the
            next page. If this field is omitted, there are no subsequent
            pages.
    """

    @property
    def raw_page(self):
        return self

    detectors = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=detector.Detector,
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )


class ListComponentsRequest(proto.Message):
    r"""Request message for ListComponents.
    Attributes:
        parent (str):
            Required. The parent, which owns this collection of
            components. Format:

            -  ``organizations/{organization}``
        page_size (int):
            The maximum number of components to return.
            The service may return fewer than this value. If
            unspecified, at most 100 components will be
            returned. The maximum value is 1000; values
            above 1000 will be coerced to 1000.
        page_token (str):
            A page token, received from a previous ``ListComponents``
            call. Provide this to retrieve the subsequent page.

            When paginating, all other parameters provided to
            ``ListComponents`` must match the call that provided the
            page token.
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


class ListComponentsResponse(proto.Message):
    r"""Response message for ListComponents.
    Attributes:
        components (Sequence[str]):
            The components from the specified
            organization.
        next_page_token (str):
            A token that can be sent as ``page_token`` to retrieve the
            next page. If this field is omitted, there are no subsequent
            pages.
    """

    @property
    def raw_page(self):
        return self

    components = proto.RepeatedField(
        proto.STRING,
        number=1,
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
