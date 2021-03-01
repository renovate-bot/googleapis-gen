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


from google.ads.googleads.v5.enums.types import mobile_device_type


__protobuf__ = proto.module(
    package='google.ads.googleads.v5.resources',
    marshal='google.ads.googleads.v5',
    manifest={
        'MobileDeviceConstant',
    },
)


class MobileDeviceConstant(proto.Message):
    r"""A mobile device constant.

    Attributes:
        resource_name (str):
            Output only. The resource name of the mobile device
            constant. Mobile device constant resource names have the
            form:

            ``mobileDeviceConstants/{criterion_id}``
        id (int):
            Output only. The ID of the mobile device
            constant.
        name (str):
            Output only. The name of the mobile device.
        manufacturer_name (str):
            Output only. The manufacturer of the mobile
            device.
        operating_system_name (str):
            Output only. The operating system of the
            mobile device.
        type_ (google.ads.googleads.v5.enums.types.MobileDeviceTypeEnum.MobileDeviceType):
            Output only. The type of mobile device.
    """

    resource_name = proto.Field(proto.STRING, number=1)
    id = proto.Field(proto.INT64, number=7, optional=True)
    name = proto.Field(proto.STRING, number=8, optional=True)
    manufacturer_name = proto.Field(proto.STRING, number=9, optional=True)
    operating_system_name = proto.Field(proto.STRING, number=10, optional=True)
    type_ = proto.Field(proto.ENUM, number=6,
        enum=mobile_device_type.MobileDeviceTypeEnum.MobileDeviceType,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
