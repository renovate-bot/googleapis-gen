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

from google.protobuf import field_mask_pb2  # type: ignore
from google.protobuf import timestamp_pb2  # type: ignore


__protobuf__ = proto.module(
    package='google.cloud.recaptchaenterprise.v1beta1',
    manifest={
        'CreateAssessmentRequest',
        'AnnotateAssessmentRequest',
        'AnnotateAssessmentResponse',
        'Assessment',
        'Event',
        'TokenProperties',
        'CreateKeyRequest',
        'ListKeysRequest',
        'ListKeysResponse',
        'GetKeyRequest',
        'UpdateKeyRequest',
        'DeleteKeyRequest',
        'Key',
        'WebKeySettings',
        'AndroidKeySettings',
        'IOSKeySettings',
    },
)


class CreateAssessmentRequest(proto.Message):
    r"""The create assessment request message.

    Attributes:
        parent (str):
            Required. The name of the project in which the assessment
            will be created, in the format "projects/{project_number}".
        assessment (google.cloud.recaptchaenterprise_v1beta1.types.Assessment):
            Required. The assessment details.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    assessment = proto.Field(
        proto.MESSAGE,
        number=2,
        message='Assessment',
    )


class AnnotateAssessmentRequest(proto.Message):
    r"""The request message to annotate an Assessment.

    Attributes:
        name (str):
            Required. The resource name of the Assessment, in the format
            "projects/{project_number}/assessments/{assessment_id}".
        annotation (google.cloud.recaptchaenterprise_v1beta1.types.AnnotateAssessmentRequest.Annotation):
            Required. The annotation that will be
            assigned to the Event.
    """
    class Annotation(proto.Enum):
        r"""Enum that reprensents the types of annotations."""
        ANNOTATION_UNSPECIFIED = 0
        LEGITIMATE = 1
        FRAUDULENT = 2

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    annotation = proto.Field(
        proto.ENUM,
        number=2,
        enum=Annotation,
    )


class AnnotateAssessmentResponse(proto.Message):
    r"""Empty response for AnnotateAssessment.
    """


class Assessment(proto.Message):
    r"""A recaptcha assessment resource.

    Attributes:
        name (str):
            Output only. The resource name for the Assessment in the
            format
            "projects/{project_number}/assessments/{assessment_id}".
        event (google.cloud.recaptchaenterprise_v1beta1.types.Event):
            The event being assessed.
        score (float):
            Output only. Legitimate event score from 0.0
            to 1.0. (1.0 means very likely legitimate
            traffic while 0.0 means very likely non-
            legitimate traffic).
        token_properties (google.cloud.recaptchaenterprise_v1beta1.types.TokenProperties):
            Output only. Properties of the provided event
            token.
        reasons (Sequence[google.cloud.recaptchaenterprise_v1beta1.types.Assessment.ClassificationReason]):
            Output only. Reasons contributing to the risk
            analysis verdict.
    """
    class ClassificationReason(proto.Enum):
        r"""LINT.IfChange(classification_reason) Reasons contributing to the
        risk analysis verdict.
        """
        CLASSIFICATION_REASON_UNSPECIFIED = 0
        AUTOMATION = 1
        UNEXPECTED_ENVIRONMENT = 2
        TOO_MUCH_TRAFFIC = 3
        UNEXPECTED_USAGE_PATTERNS = 4
        LOW_CONFIDENCE_SCORE = 5

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    event = proto.Field(
        proto.MESSAGE,
        number=2,
        message='Event',
    )
    score = proto.Field(
        proto.FLOAT,
        number=3,
    )
    token_properties = proto.Field(
        proto.MESSAGE,
        number=4,
        message='TokenProperties',
    )
    reasons = proto.RepeatedField(
        proto.ENUM,
        number=5,
        enum=ClassificationReason,
    )


class Event(proto.Message):
    r"""

    Attributes:
        token (str):
            Optional. The user response token provided by
            the reCAPTCHA client-side integration on your
            site.
        site_key (str):
            Optional. The site key that was used to
            invoke reCAPTCHA on your site and generate the
            token.
        user_agent (str):
            Optional. The user agent present in the
            request from the user's device related to this
            event.
        user_ip_address (str):
            Optional. The IP address in the request from
            the user's device related to this event.
        expected_action (str):
            Optional. The expected action for this type
            of event. This should be the same action
            provided at token generation time on client-side
            platforms already integrated with recaptcha
            enterprise.
    """

    token = proto.Field(
        proto.STRING,
        number=1,
    )
    site_key = proto.Field(
        proto.STRING,
        number=2,
    )
    user_agent = proto.Field(
        proto.STRING,
        number=3,
    )
    user_ip_address = proto.Field(
        proto.STRING,
        number=4,
    )
    expected_action = proto.Field(
        proto.STRING,
        number=5,
    )


class TokenProperties(proto.Message):
    r"""

    Attributes:
        valid (bool):
            Whether the provided user response token is
            valid.
        invalid_reason (google.cloud.recaptchaenterprise_v1beta1.types.TokenProperties.InvalidReason):
            Reason associated with the response when
            valid = false.
        create_time (google.protobuf.timestamp_pb2.Timestamp):
            The timestamp corresponding to the generation
            of the token.
        hostname (str):
            The hostname of the page on which the token
            was generated.
        action (str):
            Action name provided at token generation.
    """
    class InvalidReason(proto.Enum):
        r"""LINT.IfChange
        Enum that represents the types of invalid token reasons.
        """
        INVALID_REASON_UNSPECIFIED = 0
        UNKNOWN_INVALID_REASON = 1
        MALFORMED = 2
        EXPIRED = 3
        DUPE = 4
        SITE_MISMATCH = 5
        MISSING = 6

    valid = proto.Field(
        proto.BOOL,
        number=1,
    )
    invalid_reason = proto.Field(
        proto.ENUM,
        number=2,
        enum=InvalidReason,
    )
    create_time = proto.Field(
        proto.MESSAGE,
        number=3,
        message=timestamp_pb2.Timestamp,
    )
    hostname = proto.Field(
        proto.STRING,
        number=4,
    )
    action = proto.Field(
        proto.STRING,
        number=5,
    )


class CreateKeyRequest(proto.Message):
    r"""The create key request message.

    Attributes:
        parent (str):
            Required. The name of the project in which the key will be
            created, in the format "projects/{project_number}".
        key (google.cloud.recaptchaenterprise_v1beta1.types.Key):
            Required. Information to create a reCAPTCHA
            Enterprise key.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    key = proto.Field(
        proto.MESSAGE,
        number=2,
        message='Key',
    )


class ListKeysRequest(proto.Message):
    r"""The list keys request message.

    Attributes:
        parent (str):
            Required. The name of the project that contains the keys
            that will be listed, in the format
            "projects/{project_number}".
        page_size (int):
            Optional. The maximum number of keys to
            return. Default is 10. Max limit is 1000.
        page_token (str):
            Optional. The next_page_token value returned from a
            previous. ListKeysRequest, if any.
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


class ListKeysResponse(proto.Message):
    r"""Response to request to list keys in a project.

    Attributes:
        keys (Sequence[google.cloud.recaptchaenterprise_v1beta1.types.Key]):
            Key details.
        next_page_token (str):
            Token to retrieve the next page of results.
            It is set to empty if no keys remain in results.
    """

    @property
    def raw_page(self):
        return self

    keys = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='Key',
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )


class GetKeyRequest(proto.Message):
    r"""The get key request message.

    Attributes:
        name (str):
            Required. The name of the requested key, in the format
            "projects/{project_number}/keys/{key_id}".
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class UpdateKeyRequest(proto.Message):
    r"""The update key request message.

    Attributes:
        key (google.cloud.recaptchaenterprise_v1beta1.types.Key):
            Required. The key to update.
        update_mask (google.protobuf.field_mask_pb2.FieldMask):
            Optional. The mask to control which field of
            the key get updated. If the mask is not present,
            all fields will be updated.
    """

    key = proto.Field(
        proto.MESSAGE,
        number=1,
        message='Key',
    )
    update_mask = proto.Field(
        proto.MESSAGE,
        number=2,
        message=field_mask_pb2.FieldMask,
    )


class DeleteKeyRequest(proto.Message):
    r"""The delete key request message.

    Attributes:
        name (str):
            Required. The name of the key to be deleted, in the format
            "projects/{project_number}/keys/{key_id}".
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class Key(proto.Message):
    r"""A key used to identify and configure applications (web and/or
    mobile) that use reCAPTCHA Enterprise.

    This message has `oneof`_ fields (mutually exclusive fields).
    For each oneof, at most one member field can be set at the same time.
    Setting any member of the oneof automatically clears all other
    members.

    .. _oneof: https://proto-plus-python.readthedocs.io/en/stable/fields.html#oneofs-mutually-exclusive-fields

    Attributes:
        name (str):
            The resource name for the Key in the format
            "projects/{project_number}/keys/{key_id}".
        display_name (str):
            Human-readable display name of this key.
            Modifiable by user.
        web_settings (google.cloud.recaptchaenterprise_v1beta1.types.WebKeySettings):
            Settings for keys that can be used by
            websites.

            This field is a member of `oneof`_ ``platform_settings``.
        android_settings (google.cloud.recaptchaenterprise_v1beta1.types.AndroidKeySettings):
            Settings for keys that can be used by Android
            apps.

            This field is a member of `oneof`_ ``platform_settings``.
        ios_settings (google.cloud.recaptchaenterprise_v1beta1.types.IOSKeySettings):
            Settings for keys that can be used by iOS
            apps.

            This field is a member of `oneof`_ ``platform_settings``.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    display_name = proto.Field(
        proto.STRING,
        number=2,
    )
    web_settings = proto.Field(
        proto.MESSAGE,
        number=3,
        oneof='platform_settings',
        message='WebKeySettings',
    )
    android_settings = proto.Field(
        proto.MESSAGE,
        number=4,
        oneof='platform_settings',
        message='AndroidKeySettings',
    )
    ios_settings = proto.Field(
        proto.MESSAGE,
        number=5,
        oneof='platform_settings',
        message='IOSKeySettings',
    )


class WebKeySettings(proto.Message):
    r"""Settings specific to keys that can be used by websites.

    Attributes:
        enforce_allowed_domains (bool):
            Whether allowed_domains is enforced or not.
        allowed_domains (Sequence[str]):
            Domains or subdomains of websites allowed to
            use the key. All subdomains of an allowed domain
            are automatically allowed. A valid domain
            requires a host and must not include any path,
            port, query or fragment. Examples: 'example.com'
            or 'subdomain.example.com'
        allow_amp_traffic (bool):
            Whether this key can be used on AMP
            (Accelerated Mobile Pages) websites.
        integration_type (google.cloud.recaptchaenterprise_v1beta1.types.WebKeySettings.IntegrationType):
            Required. Describes how this key is
            integrated with the website.
        challenge_security_preference (google.cloud.recaptchaenterprise_v1beta1.types.WebKeySettings.ChallengeSecurityPreference):
            Settings for the frequency and difficulty at which this key
            triggers captcha challenges. This should only be specified
            for IntegrationTypes CHECKBOX_CHALLENGE and
            INVISIBLE_CHALLENGE.
    """
    class IntegrationType(proto.Enum):
        r"""Enum that represents the integration types for web keys."""
        INTEGRATION_TYPE_UNSPECIFIED = 0
        SCORE_ONLY = 1
        CHECKBOX_CHALLENGE = 2
        INVISIBLE_CHALLENGE = 3

    class ChallengeSecurityPreference(proto.Enum):
        r"""Enum that represents the possible challenge frequency and
        difficulty configurations for a web key.
        """
        CHALLENGE_SECURITY_PREFERENCE_UNSPECIFIED = 0
        USABILITY = 1
        BALANCED = 2
        SECURITY = 3

    enforce_allowed_domains = proto.Field(
        proto.BOOL,
        number=3,
    )
    allowed_domains = proto.RepeatedField(
        proto.STRING,
        number=1,
    )
    allow_amp_traffic = proto.Field(
        proto.BOOL,
        number=2,
    )
    integration_type = proto.Field(
        proto.ENUM,
        number=4,
        enum=IntegrationType,
    )
    challenge_security_preference = proto.Field(
        proto.ENUM,
        number=5,
        enum=ChallengeSecurityPreference,
    )


class AndroidKeySettings(proto.Message):
    r"""Settings specific to keys that can be used by Android apps.

    Attributes:
        allowed_package_names (Sequence[str]):
            Android package names of apps allowed to use
            the key. Example: 'com.companyname.appname'
    """

    allowed_package_names = proto.RepeatedField(
        proto.STRING,
        number=1,
    )


class IOSKeySettings(proto.Message):
    r"""Settings specific to keys that can be used by iOS apps.

    Attributes:
        allowed_bundle_ids (Sequence[str]):
            iOS bundle ids of apps allowed to use the
            key. Example:
            'com.companyname.productname.appname'
    """

    allowed_bundle_ids = proto.RepeatedField(
        proto.STRING,
        number=1,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
