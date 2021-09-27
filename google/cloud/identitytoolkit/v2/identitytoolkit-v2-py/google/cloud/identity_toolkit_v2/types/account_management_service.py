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

from google.cloud.identity_toolkit_v2.types import mfa_info


__protobuf__ = proto.module(
    package='google.cloud.identitytoolkit.v2',
    manifest={
        'FinalizeMfaEnrollmentRequest',
        'FinalizeMfaEnrollmentResponse',
        'StartMfaEnrollmentRequest',
        'StartMfaEnrollmentResponse',
        'WithdrawMfaRequest',
        'WithdrawMfaResponse',
    },
)


class FinalizeMfaEnrollmentRequest(proto.Message):
    r"""Finishes enrolling a second factor for the user.
    Attributes:
        id_token (str):
            Required. ID token.
        display_name (str):
            Display name which is entered  by users to
            distinguish between different second factors
            with same type or different type.
        phone_verification_info (google.cloud.identity_toolkit_v2.types.FinalizeMfaPhoneRequestInfo):
            Verification info to authorize sending an SMS
            for phone verification.
        tenant_id (str):
            The ID of the Identity Platform tenant that
            the user enrolling MFA belongs to. If not set,
            the user belongs to the default Identity
            Platform project.
    """

    id_token = proto.Field(
        proto.STRING,
        number=1,
    )
    display_name = proto.Field(
        proto.STRING,
        number=3,
    )
    phone_verification_info = proto.Field(
        proto.MESSAGE,
        number=4,
        oneof='verification_info',
        message=mfa_info.FinalizeMfaPhoneRequestInfo,
    )
    tenant_id = proto.Field(
        proto.STRING,
        number=5,
    )


class FinalizeMfaEnrollmentResponse(proto.Message):
    r"""FinalizeMfaEnrollment response.
    Attributes:
        id_token (str):
            ID token updated to reflect MFA enrollment.
        refresh_token (str):
            Refresh token updated to reflect MFA
            enrollment.
        phone_auth_info (google.cloud.identity_toolkit_v2.types.FinalizeMfaPhoneResponseInfo):

    """

    id_token = proto.Field(
        proto.STRING,
        number=1,
    )
    refresh_token = proto.Field(
        proto.STRING,
        number=2,
    )
    phone_auth_info = proto.Field(
        proto.MESSAGE,
        number=3,
        oneof='auxiliary_auth_info',
        message=mfa_info.FinalizeMfaPhoneResponseInfo,
    )


class StartMfaEnrollmentRequest(proto.Message):
    r"""Sends MFA enrollment verification SMS for a user.
    Attributes:
        id_token (str):
            Required. User's ID token.
        phone_enrollment_info (google.cloud.identity_toolkit_v2.types.StartMfaPhoneRequestInfo):
            Verification info to authorize sending an SMS
            for phone verification.
        tenant_id (str):
            The ID of the Identity Platform tenant that
            the user enrolling MFA belongs to. If not set,
            the user belongs to the default Identity
            Platform project.
    """

    id_token = proto.Field(
        proto.STRING,
        number=1,
    )
    phone_enrollment_info = proto.Field(
        proto.MESSAGE,
        number=3,
        oneof='enrollment_info',
        message=mfa_info.StartMfaPhoneRequestInfo,
    )
    tenant_id = proto.Field(
        proto.STRING,
        number=4,
    )


class StartMfaEnrollmentResponse(proto.Message):
    r"""StartMfaEnrollment response.
    Attributes:
        phone_session_info (google.cloud.identity_toolkit_v2.types.StartMfaPhoneResponseInfo):
            Verification info to authorize sending an SMS
            for phone verification.
    """

    phone_session_info = proto.Field(
        proto.MESSAGE,
        number=1,
        oneof='enrollment_response',
        message=mfa_info.StartMfaPhoneResponseInfo,
    )


class WithdrawMfaRequest(proto.Message):
    r"""Withdraws MFA.
    Attributes:
        id_token (str):
            Required. User's ID token.
        mfa_enrollment_id (str):
            Required. MFA enrollment id from a current
            MFA enrollment.
        tenant_id (str):
            The ID of the Identity Platform tenant that
            the user unenrolling MFA belongs to. If not set,
            the user belongs to the default Identity
            Platform project.
    """

    id_token = proto.Field(
        proto.STRING,
        number=1,
    )
    mfa_enrollment_id = proto.Field(
        proto.STRING,
        number=2,
    )
    tenant_id = proto.Field(
        proto.STRING,
        number=3,
    )


class WithdrawMfaResponse(proto.Message):
    r"""Withdraws MultiFactorAuth response.
    Attributes:
        id_token (str):
            ID token updated to reflect removal of the
            second factor.
        refresh_token (str):
            Refresh token updated to reflect removal of
            the second factor.
    """

    id_token = proto.Field(
        proto.STRING,
        number=1,
    )
    refresh_token = proto.Field(
        proto.STRING,
        number=2,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
