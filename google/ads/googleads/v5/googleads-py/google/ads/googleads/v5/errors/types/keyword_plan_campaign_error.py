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


__protobuf__ = proto.module(
    package='google.ads.googleads.v5.errors',
    marshal='google.ads.googleads.v5',
    manifest={
        'KeywordPlanCampaignErrorEnum',
    },
)


class KeywordPlanCampaignErrorEnum(proto.Message):
    r"""Container for enum describing possible errors from applying a
    keyword plan campaign.
    """
    class KeywordPlanCampaignError(proto.Enum):
        r"""Enum describing possible errors from applying a keyword plan
        campaign.
        """
        UNSPECIFIED = 0
        UNKNOWN = 1
        INVALID_NAME = 2
        INVALID_LANGUAGES = 3
        INVALID_GEOS = 4
        DUPLICATE_NAME = 5
        MAX_GEOS_EXCEEDED = 6
        MAX_LANGUAGES_EXCEEDED = 7


__all__ = tuple(sorted(__protobuf__.manifest))
