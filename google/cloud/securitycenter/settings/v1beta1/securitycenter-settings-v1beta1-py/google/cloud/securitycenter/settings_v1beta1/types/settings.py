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

from google.cloud.securitycenter.settings_v1beta1.types import billing_settings as gcss_billing_settings
from google.cloud.securitycenter.settings_v1beta1.types import component_settings as gcss_component_settings
from google.cloud.securitycenter.settings_v1beta1.types import sink_settings as gcss_sink_settings
from google.protobuf import timestamp_pb2 as timestamp  # type: ignore


__protobuf__ = proto.module(
    package='google.cloud.securitycenter.settings.v1beta1',
    manifest={
        'Settings',
    },
)


class Settings(proto.Message):
    r"""Common configuration settings for all of Security Center.
    Attributes:
        name (str):
            The relative resource name of the settings resource.
            Formats:

            -  ``organizations/{organization}/settings``
            -  ``folders/{folder}/settings``
            -  ``projects/{project}/settings``
            -  ``projects/{project}/locations/{location}/clusters/{cluster}/settings``
            -  ``projects/{project}/regions/{region}/clusters/{cluster}/settings``
            -  ``projects/{project}/zones/{zone}/clusters/{cluster}/settings``
        billing_settings (google.cloud.securitycenter.settings_v1beta1.types.BillingSettings):
            Billing settings
        state (google.cloud.securitycenter.settings_v1beta1.types.Settings.OnboardingState):
            An enum representing the current on boarding
            state of SCC.
        org_service_account (str):
            Output only. The organization-level service
            account to be used for security center
            components. The component must have permission
            to "act as" the service account.
        sink_settings (google.cloud.securitycenter.settings_v1beta1.types.SinkSettings):
            Sink settings.
        component_settings (Sequence[google.cloud.securitycenter.settings_v1beta1.types.Settings.ComponentSettingsEntry]):
            The settings for detectors and/or scanners.
        detector_group_settings (Sequence[google.cloud.securitycenter.settings_v1beta1.types.Settings.DetectorGroupSettingsEntry]):
            Detector group settings for all Security
            Center components. The key is the name of the
            detector group and the value is the settings for
            that group.
        etag (str):
            A fingerprint used for optimistic
            concurrency. If none is provided on updates then
            the existing metadata will be blindly
            overwritten.
        update_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The time these settings were
            last updated.
    """
    class OnboardingState(proto.Enum):
        r"""Defines the onboarding states for SCC
        Potentially is just an indicator that a user has reviewed some
        subset of our configuration surface, even if it's still
        currently set to its API-default state.
        """
        ONBOARDING_STATE_UNSPECIFIED = 0
        ENABLED = 1
        DISABLED = 2
        BILLING_SELECTED = 3
        PROVIDERS_SELECTED = 4
        RESOURCES_SELECTED = 5
        ORG_SERVICE_ACCOUNT_CREATED = 6

    class DetectorGroupSettings(proto.Message):
        r"""The DetectorGroupSettings define the configuration for a
        detector group.

        Attributes:
            state (google.cloud.securitycenter.settings_v1beta1.types.ComponentEnablementState):
                The state determines if the group is enabled
                or not.
        """

        state = proto.Field(
            proto.ENUM,
            number=1,
            enum=gcss_component_settings.ComponentEnablementState,
        )

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    billing_settings = proto.Field(
        proto.MESSAGE,
        number=2,
        message=gcss_billing_settings.BillingSettings,
    )
    state = proto.Field(
        proto.ENUM,
        number=3,
        enum=OnboardingState,
    )
    org_service_account = proto.Field(
        proto.STRING,
        number=5,
    )
    sink_settings = proto.Field(
        proto.MESSAGE,
        number=6,
        message=gcss_sink_settings.SinkSettings,
    )
    component_settings = proto.MapField(
        proto.STRING,
        proto.MESSAGE,
        number=7,
        message=gcss_component_settings.ComponentSettings,
    )
    detector_group_settings = proto.MapField(
        proto.STRING,
        proto.MESSAGE,
        number=8,
        message=DetectorGroupSettings,
    )
    etag = proto.Field(
        proto.STRING,
        number=9,
    )
    update_time = proto.Field(
        proto.MESSAGE,
        number=10,
        message=timestamp.Timestamp,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
