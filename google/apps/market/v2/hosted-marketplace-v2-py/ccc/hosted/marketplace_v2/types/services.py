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
    package='ccc.hosted.marketplace.v2',
    manifest={
        'CustomerLicenseGetRequest',
        'LicenseNotificationListRequest',
        'UserLicenseGetRequest',
    },
)


class CustomerLicenseGetRequest(proto.Message):
    r"""
    Attributes:
        application_id (str):
            Application Id
        customer_id (str):
            Customer Id
    """

    application_id = proto.Field(
        proto.STRING,
        number=1,
    )
    customer_id = proto.Field(
        proto.STRING,
        number=2,
    )


class LicenseNotificationListRequest(proto.Message):
    r"""
    Attributes:
        application_id (str):
            Application Id
        max_results (int):

        start_token (str):

        timestamp (int):
            Timestamp in milliseconds since epoch
    """

    application_id = proto.Field(
        proto.STRING,
        number=1,
    )
    max_results = proto.Field(
        proto.UINT32,
        number=2,
    )
    start_token = proto.Field(
        proto.STRING,
        number=3,
    )
    timestamp = proto.Field(
        proto.UINT64,
        number=4,
    )


class UserLicenseGetRequest(proto.Message):
    r"""
    Attributes:
        application_id (str):
            Application Id
        user_id (str):
            User Id
    """

    application_id = proto.Field(
        proto.STRING,
        number=1,
    )
    user_id = proto.Field(
        proto.STRING,
        number=2,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
