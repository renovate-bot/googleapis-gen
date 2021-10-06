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
    package='google.cloud.identitytoolkit.v2',
    manifest={
        'AutoRetrievalInfo',
        'StartMfaPhoneRequestInfo',
        'StartMfaPhoneResponseInfo',
        'FinalizeMfaPhoneRequestInfo',
        'FinalizeMfaPhoneResponseInfo',
    },
)


class AutoRetrievalInfo(proto.Message):
    r"""The information required to auto-retrieve an SMS.

    Attributes:
        app_signature_hash (str):
            The Android app's signature hash for Google
            Play Service's SMS Retriever API.
    """

    app_signature_hash = proto.Field(
        proto.STRING,
        number=1,
    )


class StartMfaPhoneRequestInfo(proto.Message):
    r"""App Verification info for a StartMfa request.

    Attributes:
        phone_number (str):
            Required for enrollment. Phone number to be
            enrolled as MFA.
        ios_receipt (str):
            iOS only. Receipt of successful app token
            validation with APNS.
        ios_secret (str):
            iOS only. Secret delivered to iOS app via
            APNS.
        recaptcha_token (str):
            Web only. Recaptcha solution.
        auto_retrieval_info (google.cloud.identity_toolkit_v2.types.AutoRetrievalInfo):
            Android only. Used by Google Play Services to
            identify the app for auto-retrieval.
        safety_net_token (str):
            Android only. Used to assert application identity in place
            of a recaptcha token. A SafetyNet Token can be generated via
            the `SafetyNet Android Attestation
            API <https://developer.android.com/training/safetynet/attestation.html>`__,
            with the Base64 encoding of the ``phone_number`` field as
            the nonce.
    """

    phone_number = proto.Field(
        proto.STRING,
        number=1,
    )
    ios_receipt = proto.Field(
        proto.STRING,
        number=2,
    )
    ios_secret = proto.Field(
        proto.STRING,
        number=3,
    )
    recaptcha_token = proto.Field(
        proto.STRING,
        number=4,
    )
    auto_retrieval_info = proto.Field(
        proto.MESSAGE,
        number=5,
        message='AutoRetrievalInfo',
    )
    safety_net_token = proto.Field(
        proto.STRING,
        number=6,
    )


class StartMfaPhoneResponseInfo(proto.Message):
    r"""Phone Verification info for a StartMfa response.

    Attributes:
        session_info (str):
            An opaque string that represents the
            enrollment session.
    """

    session_info = proto.Field(
        proto.STRING,
        number=1,
    )


class FinalizeMfaPhoneRequestInfo(proto.Message):
    r"""Phone Verification info for a FinalizeMfa request.

    Attributes:
        session_info (str):
            An opaque string that represents the
            enrollment session.
        code (str):
            User-entered verification code.
        android_verification_proof (str):
            Android only. Uses for "instant" phone number
            verification though GmsCore.
        phone_number (str):
            Required if Android verification proof is
            presented.
    """

    session_info = proto.Field(
        proto.STRING,
        number=1,
    )
    code = proto.Field(
        proto.STRING,
        number=2,
    )
    android_verification_proof = proto.Field(
        proto.STRING,
        number=3,
    )
    phone_number = proto.Field(
        proto.STRING,
        number=4,
    )


class FinalizeMfaPhoneResponseInfo(proto.Message):
    r"""Phone Verification info for a FinalizeMfa response.

    Attributes:
        android_verification_proof (str):
            Android only. Long-lived replacement for
            valid code tied to android device.
        android_verification_proof_expire_time (google.protobuf.timestamp_pb2.Timestamp):
            Android only. Expiration time of verification
            proof in seconds.
        phone_number (str):
            For Android verification proof.
    """

    android_verification_proof = proto.Field(
        proto.STRING,
        number=1,
    )
    android_verification_proof_expire_time = proto.Field(
        proto.MESSAGE,
        number=2,
        message=timestamp_pb2.Timestamp,
    )
    phone_number = proto.Field(
        proto.STRING,
        number=3,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
