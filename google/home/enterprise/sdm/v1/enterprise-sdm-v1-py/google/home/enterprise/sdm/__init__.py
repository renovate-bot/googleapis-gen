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

from google.home.enterprise.sdm_v1.services.smart_device_management_service.client import SmartDeviceManagementServiceClient
from google.home.enterprise.sdm_v1.services.smart_device_management_service.async_client import SmartDeviceManagementServiceAsyncClient

from google.home.enterprise.sdm_v1.types.device import Device
from google.home.enterprise.sdm_v1.types.device import ParentRelation
from google.home.enterprise.sdm_v1.types.site import Room
from google.home.enterprise.sdm_v1.types.site import Structure
from google.home.enterprise.sdm_v1.types.smart_device_management_service import ExecuteDeviceCommandRequest
from google.home.enterprise.sdm_v1.types.smart_device_management_service import ExecuteDeviceCommandResponse
from google.home.enterprise.sdm_v1.types.smart_device_management_service import GetDeviceRequest
from google.home.enterprise.sdm_v1.types.smart_device_management_service import GetRoomRequest
from google.home.enterprise.sdm_v1.types.smart_device_management_service import GetStructureRequest
from google.home.enterprise.sdm_v1.types.smart_device_management_service import ListDevicesRequest
from google.home.enterprise.sdm_v1.types.smart_device_management_service import ListDevicesResponse
from google.home.enterprise.sdm_v1.types.smart_device_management_service import ListRoomsRequest
from google.home.enterprise.sdm_v1.types.smart_device_management_service import ListRoomsResponse
from google.home.enterprise.sdm_v1.types.smart_device_management_service import ListStructuresRequest
from google.home.enterprise.sdm_v1.types.smart_device_management_service import ListStructuresResponse

__all__ = ('SmartDeviceManagementServiceClient',
    'SmartDeviceManagementServiceAsyncClient',
    'Device',
    'ParentRelation',
    'Room',
    'Structure',
    'ExecuteDeviceCommandRequest',
    'ExecuteDeviceCommandResponse',
    'GetDeviceRequest',
    'GetRoomRequest',
    'GetStructureRequest',
    'ListDevicesRequest',
    'ListDevicesResponse',
    'ListRoomsRequest',
    'ListRoomsResponse',
    'ListStructuresRequest',
    'ListStructuresResponse',
)
