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

from google.maps.roads_v1.services.roads_service.client import RoadsServiceClient
from google.maps.roads_v1.services.roads_service.async_client import RoadsServiceAsyncClient

from google.maps.roads_v1.types.roads import ListNearestRoadsRequest
from google.maps.roads_v1.types.roads import ListNearestRoadsResponse
from google.maps.roads_v1.types.roads import SnappedPoint
from google.maps.roads_v1.types.roads import SnapToRoadsRequest
from google.maps.roads_v1.types.roads import SnapToRoadsResponse
from google.maps.roads_v1.types.roads import TravelMode

__all__ = ('RoadsServiceClient',
    'RoadsServiceAsyncClient',
    'ListNearestRoadsRequest',
    'ListNearestRoadsResponse',
    'SnappedPoint',
    'SnapToRoadsRequest',
    'SnapToRoadsResponse',
    'TravelMode',
)
