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

from google.cloud.securitycenter.settings_v1beta1.types import billing_settings


__protobuf__ = proto.module(
    package='google.cloud.securitycenter.settings.v1beta1',
    manifest={
        'Detector',
    },
)


class Detector(proto.Message):
    r"""Detector is a set of detectors or scanners act as individual
    checks done within a component e.g. bad IP, bad domains, IAM
    anomaly, cryptomining, open firewall, etc. Detector is
    independent of Organization, meaning each detector must be
    defined for a given Security Center component under a specified
    billing tier. Organizations can configure the list of detectors
    based on their subscribed billing tier.

    Defines a detector, its billing tier and any applicable labels.

    Attributes:
        detector (str):
            Output only. Detector Identifier
        component (str):
            Output only. Component that supports detector
            type.  Multiple components may support the same
            detector.
        billing_tier (google.cloud.securitycenter.settings_v1beta1.types.BillingTier):
            Output only. The billing tier may be
            different for a detector of the same name in
            another component.
        detector_labels (Sequence[str]):
            Output only. Google curated detector labels.
            These are alphanumeric tags that are not
            necessarily human readable. Labels can be used
            to group detectors together in the future. An
            example might be tagging all detectors “PCI”
            that help with PCI compliance.
    """

    detector = proto.Field(
        proto.STRING,
        number=1,
    )
    component = proto.Field(
        proto.STRING,
        number=2,
    )
    billing_tier = proto.Field(
        proto.ENUM,
        number=3,
        enum=billing_settings.BillingTier,
    )
    detector_labels = proto.RepeatedField(
        proto.STRING,
        number=4,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
