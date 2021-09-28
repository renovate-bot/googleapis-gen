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

from google.cloud.gaming.allocationendpoint_v1alpha.services.allocation_endpoint_service.client import AllocationEndpointServiceClient
from google.cloud.gaming.allocationendpoint_v1alpha.services.allocation_endpoint_service.async_client import AllocationEndpointServiceAsyncClient

from google.cloud.gaming.allocationendpoint_v1alpha.types.allocation_endpoint import AllocationRequest
from google.cloud.gaming.allocationendpoint_v1alpha.types.allocation_endpoint import AllocationResponse
from google.cloud.gaming.allocationendpoint_v1alpha.types.allocation_endpoint import GameServerSelector
from google.cloud.gaming.allocationendpoint_v1alpha.types.allocation_endpoint import MetaPatch

__all__ = ('AllocationEndpointServiceClient',
    'AllocationEndpointServiceAsyncClient',
    'AllocationRequest',
    'AllocationResponse',
    'GameServerSelector',
    'MetaPatch',
)
