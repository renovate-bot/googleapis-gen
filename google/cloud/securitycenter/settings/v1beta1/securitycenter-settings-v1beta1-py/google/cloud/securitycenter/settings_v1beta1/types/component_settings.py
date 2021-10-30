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
    package='google.cloud.securitycenter.settings.v1beta1',
    manifest={
        'ComponentEnablementState',
        'ComponentSettings',
        'WebSecurityScanner',
        'ContainerThreatDetectionSettings',
        'EventThreatDetectionSettings',
        'SecurityHealthAnalyticsSettings',
    },
)


class ComponentEnablementState(proto.Enum):
    r"""Valid states for a component"""
    COMPONENT_ENABLEMENT_STATE_UNSPECIFIED = 0
    DISABLE = 1
    ENABLE = 2
    INHERIT = 3


class ComponentSettings(proto.Message):
    r"""Component Settings for Security Command Center

    This message has `oneof`_ fields (mutually exclusive fields).
    For each oneof, at most one member field can be set at the same time.
    Setting any member of the oneof automatically clears all other
    members.

    .. _oneof: https://proto-plus-python.readthedocs.io/en/stable/fields.html#oneofs-mutually-exclusive-fields

    Attributes:
        name (str):
            The relative resource name of the component settings.
            Formats:

            -  ``organizations/{organization}/components/{component}/settings``
            -  ``folders/{folder}/components/{component}/settings``
            -  ``projects/{project}/components/{component}/settings``
            -  ``projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings``
            -  ``projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings``
            -  ``projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings``
        state (google.cloud.securitycenter.settings_v1beta1.types.ComponentEnablementState):
            ENABLE to enable component, DISABLE to
            disable and INHERIT to inherit setting from
            ancestors.
        project_service_account (str):
            Output only. The service account to be used
            for security center component. The component
            must have permission to "act as" the service
            account.
        detector_settings (Sequence[google.cloud.securitycenter.settings_v1beta1.types.ComponentSettings.DetectorSettingsEntry]):
            Settings for detectors.  Not all detectors
            must have settings present at each and every
            level in the hierarchy.  If it is not present
            the setting will be inherited from its ancestors
            folders, organizations or the defaults.
        etag (str):
            Output only. An fingerprint used for
            optimistic concurrency. If none is provided on
            updates then the existing metadata will be
            blindly overwritten.
        update_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The time these settings were
            last updated.
        container_threat_detection_settings (google.cloud.securitycenter.settings_v1beta1.types.ContainerThreatDetectionSettings):
            Container Threate Detection specific settings For component,
            expect CONTAINER_THREAT_DETECTION
            This field is a member of `oneof`_ ``specific_settings``.
        event_threat_detection_settings (google.cloud.securitycenter.settings_v1beta1.types.EventThreatDetectionSettings):
            Event Threat Detection specific settings For component,
            expect EVENT_THREAT_DETECTION
            This field is a member of `oneof`_ ``specific_settings``.
        security_health_analytics_settings (google.cloud.securitycenter.settings_v1beta1.types.SecurityHealthAnalyticsSettings):
            Security Health Analytics specific settings For component,
            expect SECURITY_HEALTH_ANALYTICS
            This field is a member of `oneof`_ ``specific_settings``.
        web_security_scanner_settings (google.cloud.securitycenter.settings_v1beta1.types.WebSecurityScanner):
            Web Security Scanner specific settings For component, expect
            WEB_SECURITY_SCANNER
            This field is a member of `oneof`_ ``specific_settings``.
    """

    class DetectorSettings(proto.Message):
        r"""Settings for each detector.

        Attributes:
            state (google.cloud.securitycenter.settings_v1beta1.types.ComponentEnablementState):
                ENABLE to enable component, DISABLE to
                disable and INHERIT to inherit setting from
                ancestors.
        """

        state = proto.Field(
            proto.ENUM,
            number=1,
            enum='ComponentEnablementState',
        )

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    state = proto.Field(
        proto.ENUM,
        number=2,
        enum='ComponentEnablementState',
    )
    project_service_account = proto.Field(
        proto.STRING,
        number=3,
    )
    detector_settings = proto.MapField(
        proto.STRING,
        proto.MESSAGE,
        number=4,
        message=DetectorSettings,
    )
    etag = proto.Field(
        proto.STRING,
        number=5,
    )
    update_time = proto.Field(
        proto.MESSAGE,
        number=6,
        message=timestamp_pb2.Timestamp,
    )
    container_threat_detection_settings = proto.Field(
        proto.MESSAGE,
        number=41,
        oneof='specific_settings',
        message='ContainerThreatDetectionSettings',
    )
    event_threat_detection_settings = proto.Field(
        proto.MESSAGE,
        number=42,
        oneof='specific_settings',
        message='EventThreatDetectionSettings',
    )
    security_health_analytics_settings = proto.Field(
        proto.MESSAGE,
        number=44,
        oneof='specific_settings',
        message='SecurityHealthAnalyticsSettings',
    )
    web_security_scanner_settings = proto.Field(
        proto.MESSAGE,
        number=40,
        oneof='specific_settings',
        message='WebSecurityScanner',
    )


class WebSecurityScanner(proto.Message):
    r"""User specified settings for Web Security Scanner
    """


class ContainerThreatDetectionSettings(proto.Message):
    r"""User specified settings for KTD
    """


class EventThreatDetectionSettings(proto.Message):
    r"""User specified settings for ETD
    """


class SecurityHealthAnalyticsSettings(proto.Message):
    r"""User specified settings for Security Health Analytics

    Attributes:
        non_org_iam_member_settings (google.cloud.securitycenter.settings_v1beta1.types.SecurityHealthAnalyticsSettings.NonOrgIamMemberSettings):
            Settings for "NON_ORG_IAM_MEMBER" scanner.
        admin_service_account_settings (google.cloud.securitycenter.settings_v1beta1.types.SecurityHealthAnalyticsSettings.AdminServiceAccountSettings):
            Settings for "ADMIN_SERVICE_ACCOUNT" scanner.
    """

    class NonOrgIamMemberSettings(proto.Message):
        r"""Settings for "NON_ORG_IAM_MEMBER" scanner.

        Attributes:
            approved_identities (Sequence[str]):
                User emails ending in the provided identities are allowed to
                have IAM permissions on a project or the organization.
                Otherwise a finding will be created. A valid identity can
                be:

                -  a domain that starts with "@", e.g. "@yourdomain.com".
                -  a fully specified email address that does not start with
                   "@", e.g. "abc@gmail.com" Regular expressions are not
                   supported. Service accounts are not examined by the
                   scanner and will be omitted if added to the list. If not
                   specified, only Gmail accounts will be considered as
                   non-approved.
        """

        approved_identities = proto.RepeatedField(
            proto.STRING,
            number=1,
        )

    class AdminServiceAccountSettings(proto.Message):
        r"""Settings for "ADMIN_SERVICE_ACCOUNT" scanner.

        Attributes:
            approved_identities (Sequence[str]):
                User-created service accounts ending in the provided
                identities are allowed to have Admin, Owner or Editor roles
                granted to them. Otherwise a finding will be created. A
                valid identity can be:

                -  a partilly specified service account that starts with
                   "@", e.g. "@myproject.iam.gserviceaccount.com". This
                   approves all the service accounts suffixed with the
                   specified identity.
                -  a fully specified service account that does not start
                   with "@", e.g.
                   "myadmin@myproject.iam.gserviceaccount.com".
                   Google-created service accounts are all approved.
        """

        approved_identities = proto.RepeatedField(
            proto.STRING,
            number=1,
        )

    non_org_iam_member_settings = proto.Field(
        proto.MESSAGE,
        number=1,
        message=NonOrgIamMemberSettings,
    )
    admin_service_account_settings = proto.Field(
        proto.MESSAGE,
        number=2,
        message=AdminServiceAccountSettings,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
