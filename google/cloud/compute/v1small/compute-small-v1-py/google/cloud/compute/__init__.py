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

from google.cloud.compute_v1.services.addresses.client import AddressesClient
from google.cloud.compute_v1.services.region_operations.client import RegionOperationsClient

from google.cloud.compute_v1.types.compute_small import Address
from google.cloud.compute_v1.types.compute_small import AddressAggregatedList
from google.cloud.compute_v1.types.compute_small import AddressesScopedList
from google.cloud.compute_v1.types.compute_small import AddressList
from google.cloud.compute_v1.types.compute_small import AggregatedListAddressesRequest
from google.cloud.compute_v1.types.compute_small import Data
from google.cloud.compute_v1.types.compute_small import DeleteAddressRequest
from google.cloud.compute_v1.types.compute_small import Error
from google.cloud.compute_v1.types.compute_small import Errors
from google.cloud.compute_v1.types.compute_small import GetRegionOperationRequest
from google.cloud.compute_v1.types.compute_small import InsertAddressRequest
from google.cloud.compute_v1.types.compute_small import ListAddressesRequest
from google.cloud.compute_v1.types.compute_small import Operation
from google.cloud.compute_v1.types.compute_small import WaitRegionOperationRequest
from google.cloud.compute_v1.types.compute_small import Warning
from google.cloud.compute_v1.types.compute_small import Warnings

__all__ = ('AddressesClient',
    'RegionOperationsClient',
    'Address',
    'AddressAggregatedList',
    'AddressesScopedList',
    'AddressList',
    'AggregatedListAddressesRequest',
    'Data',
    'DeleteAddressRequest',
    'Error',
    'Errors',
    'GetRegionOperationRequest',
    'InsertAddressRequest',
    'ListAddressesRequest',
    'Operation',
    'WaitRegionOperationRequest',
    'Warning',
    'Warnings',
)
