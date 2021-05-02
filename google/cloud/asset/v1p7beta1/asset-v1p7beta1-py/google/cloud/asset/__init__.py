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

from google.cloud.asset_v1p7beta1.services.asset_service.async_client import AssetServiceAsyncClient
from google.cloud.asset_v1p7beta1.services.asset_service.client import AssetServiceClient
from google.cloud.asset_v1p7beta1.types.asset_service import BigQueryDestination
from google.cloud.asset_v1p7beta1.types.asset_service import ContentType
from google.cloud.asset_v1p7beta1.types.asset_service import ExportAssetsRequest
from google.cloud.asset_v1p7beta1.types.asset_service import ExportAssetsResponse
from google.cloud.asset_v1p7beta1.types.asset_service import GcsDestination
from google.cloud.asset_v1p7beta1.types.asset_service import GcsOutputResult
from google.cloud.asset_v1p7beta1.types.asset_service import OutputConfig
from google.cloud.asset_v1p7beta1.types.asset_service import OutputResult
from google.cloud.asset_v1p7beta1.types.asset_service import PartitionSpec
from google.cloud.asset_v1p7beta1.types.assets import Asset
from google.cloud.asset_v1p7beta1.types.assets import RelatedAsset
from google.cloud.asset_v1p7beta1.types.assets import RelatedAssets
from google.cloud.asset_v1p7beta1.types.assets import RelationshipAttributes
from google.cloud.asset_v1p7beta1.types.assets import Resource

__all__ = ('Asset',
    'AssetServiceAsyncClient',
    'AssetServiceClient',
    'BigQueryDestination',
    'ContentType',
    'ExportAssetsRequest',
    'ExportAssetsResponse',
    'GcsDestination',
    'GcsOutputResult',
    'OutputConfig',
    'OutputResult',
    'PartitionSpec',
    'RelatedAsset',
    'RelatedAssets',
    'RelationshipAttributes',
    'Resource',
)
