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

from ccc.hosted.marketplace_v2.services.customer_license_service.async_client import CustomerLicenseServiceAsyncClient
from ccc.hosted.marketplace_v2.services.customer_license_service.client import CustomerLicenseServiceClient
from ccc.hosted.marketplace_v2.services.license_notification_service.async_client import LicenseNotificationServiceAsyncClient
from ccc.hosted.marketplace_v2.services.license_notification_service.client import LicenseNotificationServiceClient
from ccc.hosted.marketplace_v2.services.user_license_service.async_client import UserLicenseServiceAsyncClient
from ccc.hosted.marketplace_v2.services.user_license_service.client import UserLicenseServiceClient
from ccc.hosted.marketplace_v2.types.resources import CustomerLicense
from ccc.hosted.marketplace_v2.types.resources import LicenseNotification
from ccc.hosted.marketplace_v2.types.resources import LicenseNotificationList
from ccc.hosted.marketplace_v2.types.resources import UserLicense
from ccc.hosted.marketplace_v2.types.services import CustomerLicenseGetRequest
from ccc.hosted.marketplace_v2.types.services import LicenseNotificationListRequest
from ccc.hosted.marketplace_v2.types.services import UserLicenseGetRequest

__all__ = ('CustomerLicense',
    'CustomerLicenseGetRequest',
    'CustomerLicenseServiceAsyncClient',
    'CustomerLicenseServiceClient',
    'LicenseNotification',
    'LicenseNotificationList',
    'LicenseNotificationListRequest',
    'LicenseNotificationServiceAsyncClient',
    'LicenseNotificationServiceClient',
    'UserLicense',
    'UserLicenseGetRequest',
    'UserLicenseServiceAsyncClient',
    'UserLicenseServiceClient',
)
