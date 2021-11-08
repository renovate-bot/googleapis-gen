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
        'FinalizeMfaSignInRequest',
        'FinalizeMfaSignInResponse',
        'StartMfaSignInRequest',
        'StartMfaSignInResponse',
    },
)


class FinalizeMfaSignInRequest(proto.Message):
    r"""Finalizes sign-in by verifying MFA challenge.

    .. _oneof: https://proto-plus-python.readthedocs.io/en/stable/fields.html#oneofs-mutually-exclusive-fields

    Attributes:
        mfa_pending_credential (str):
            Required. Pending credential from first
            factor sign-in.
        phone_verification_info (google.cloud.identity_toolkit_v2.types.FinalizeMfaPhoneRequestInfo):
            Proof of completion of the SMS based MFA
            challenge.

            This field is a member of `oneof`_ ``verification_info``.
        tenant_id (str):
            The ID of the Identity Platform tenant the
            user is signing in to. If not set, the user will
            sign in to the default Identity Platform
            project.
    """

    mfa_pending_credential = proto.Field(
        proto.STRING,
        number=2,
    )
    phone_verification_info = proto.Field(
        proto.MESSAGE,
        number=3,
        oneof='verification_info',
        message=mfa_info.FinalizeMfaPhoneRequestInfo,
    )
    tenant_id = proto.Field(
        proto.STRING,
        number=4,
    )


class FinalizeMfaSignInResponse(proto.Message):
    r"""FinalizeMfaSignIn response.

    .. _oneof: https://proto-plus-python.readthedocs.io/en/stable/fields.html#oneofs-mutually-exclusive-fields

    Attributes:
        id_token (str):
            ID token for the authenticated user.
        refresh_token (str):
            Refresh token for the authenticated user.
        phone_auth_info (google.cloud.identity_toolkit_v2.types.FinalizeMfaPhoneResponseInfo):
            Extra phone auth info, including android
            verification proof.

            This field is a member of `oneof`_ ``auxiliary_auth_info``.
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


class StartMfaSignInRequest(proto.Message):
    r"""Starts multi-factor sign-in by sending the multi-factor auth
    challenge.


    .. _oneof: https://proto-plus-python.readthedocs.io/en/stable/fields.html#oneofs-mutually-exclusive-fields

    Attributes:
        mfa_pending_credential (str):
            Required. Pending credential from first
            factor sign-in.
        mfa_enrollment_id (str):
            Required. MFA enrollment id from the user's
            list of current MFA enrollments.
        phone_sign_in_info (google.cloud.identity_toolkit_v2.types.StartMfaPhoneRequestInfo):
            Verification info to authorize sending an SMS
            for phone verification.

            This field is a member of `oneof`_ ``sign_in_info``.
        tenant_id (str):
            The ID of the Identity Platform tenant the
            user is signing in to. If not set, the user will
            sign in to the default Identity Platform
            project.
    """

    mfa_pending_credential = proto.Field(
        proto.STRING,
        number=2,
    )
    mfa_enrollment_id = proto.Field(
        proto.STRING,
        number=3,
    )
    phone_sign_in_info = proto.Field(
        proto.MESSAGE,
        number=4,
        oneof='sign_in_info',
        message=mfa_info.StartMfaPhoneRequestInfo,
    )
    tenant_id = proto.Field(
        proto.STRING,
        number=5,
    )


class StartMfaSignInResponse(proto.Message):
    r"""StartMfaSignIn response.

    .. _oneof: https://proto-plus-python.readthedocs.io/en/stable/fields.html#oneofs-mutually-exclusive-fields

    Attributes:
        phone_response_info (google.cloud.identity_toolkit_v2.types.StartMfaPhoneResponseInfo):
            MultiFactor sign-in session information
            specific to SMS-type second factors. Along with
            the one-time code retrieved from the sent SMS,
            the contents of this session information should
            be passed to FinalizeMfaSignIn to complete the
            sign in.

            This field is a member of `oneof`_ ``response_info``.
    """

    phone_response_info = proto.Field(
        proto.MESSAGE,
        number=1,
        oneof='response_info',
        message=mfa_info.StartMfaPhoneResponseInfo,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
