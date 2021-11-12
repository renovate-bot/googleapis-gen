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

from .services.addresses import AddressesClient
from .services.region_operations import RegionOperationsClient

from .types.compute_small import Address
from .types.compute_small import AddressAggregatedList
from .types.compute_small import AddressesScopedList
from .types.compute_small import AddressList
from .types.compute_small import AggregatedListAddressesRequest
from .types.compute_small import Data
from .types.compute_small import DeleteAddressRequest
from .types.compute_small import Error
from .types.compute_small import Errors
from .types.compute_small import GetRegionOperationRequest
from .types.compute_small import InsertAddressRequest
from .types.compute_small import ListAddressesRequest
from .types.compute_small import Operation
from .types.compute_small import WaitRegionOperationRequest
from .types.compute_small import Warning
from .types.compute_small import Warnings

__all__ = (
'Address',
'AddressAggregatedList',
'AddressList',
'AddressesClient',
'AddressesScopedList',
'AggregatedListAddressesRequest',
'Data',
'DeleteAddressRequest',
'Error',
'Errors',
'GetRegionOperationRequest',
'InsertAddressRequest',
'ListAddressesRequest',
'Operation',
'RegionOperationsClient',
'WaitRegionOperationRequest',
'Warning',
'Warnings',
)
