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


from google.protobuf import timestamp_pb2 as timestamp  # type: ignore


__protobuf__ = proto.module(
    package='google.cloud.securitycenter.settings.v1beta1',
    manifest={
        'BillingTier',
        'BillingType',
        'BillingSettings',
    },
)


class BillingTier(proto.Enum):
    r"""Billing tier options"""
    BILLING_TIER_UNSPECIFIED = 0
    STANDARD = 1
    PREMIUM = 2


class BillingType(proto.Enum):
    r"""Billing type"""
    BILLING_TYPE_UNSPECIFIED = 0
    SUBSCRIPTION = 1
    TRIAL_SUBSCRIPTION = 2
    ALPHA = 3


class BillingSettings(proto.Message):
    r"""Billing settings

    Attributes:
        billing_tier (google.cloud.securitycenter.settings_v1beta1.types.BillingTier):
            Output only. Billing tier selected by
            customer
        billing_type (google.cloud.securitycenter.settings_v1beta1.types.BillingType):
            Output only. Type of billing method
        start_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The absolute point in time when the
            subscription became effective. Can be compared to
            expire_time value to determine full contract duration
        expire_time (google.protobuf.timestamp_pb2.Timestamp):
            Output only. The absolute point in time when the
            subscription expires.

            If this field is populated and billing_tier is STANDARD,
            this is indication of a point in the *past* when a PREMIUM
            access ended.
    """

    billing_tier = proto.Field(proto.ENUM, number=1,
        enum='BillingTier',
    )

    billing_type = proto.Field(proto.ENUM, number=2,
        enum='BillingType',
    )

    start_time = proto.Field(proto.MESSAGE, number=3,
        message=timestamp.Timestamp,
    )

    expire_time = proto.Field(proto.MESSAGE, number=4,
        message=timestamp.Timestamp,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
