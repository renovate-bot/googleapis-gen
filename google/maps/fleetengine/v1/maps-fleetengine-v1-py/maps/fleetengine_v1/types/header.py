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
    package='maps.fleetengine.v1',
    manifest={
        'RequestHeader',
    },
)


class RequestHeader(proto.Message):
    r"""A RequestHeader contains fields common to all Fleet Engine
    RPC requests.

    Attributes:
        language_code (str):
            The language requested. The external form of
            Google International Identifiers Initiative
            (III) LanguageCode objects. If none is
            specified, return a name in any language, with a
            preference for English if such a name exists.
        region_code (str):
            Required. CLDR region code of the region
            where the request originates.
        sdk_version (str):
            Version of the calling SDK, if applicable.
        os_version (str):
            Version of the operating system on which the
            calling SDK is running.
        device_model (str):
            Model of the device on which the calling SDK
            is running.
    """

    language_code = proto.Field(
        proto.STRING,
        number=1,
    )
    region_code = proto.Field(
        proto.STRING,
        number=2,
    )
    sdk_version = proto.Field(
        proto.STRING,
        number=3,
    )
    os_version = proto.Field(
        proto.STRING,
        number=4,
    )
    device_model = proto.Field(
        proto.STRING,
        number=5,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
