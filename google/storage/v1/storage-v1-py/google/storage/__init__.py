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

from google.storage_v1.services.storage.async_client import StorageAsyncClient
from google.storage_v1.services.storage.client import StorageClient
from google.storage_v1.types.storage import CommonObjectRequestParams
from google.storage_v1.types.storage import CommonRequestParams
from google.storage_v1.types.storage import ComposeObjectRequest
from google.storage_v1.types.storage import CopyObjectRequest
from google.storage_v1.types.storage import CreateHmacKeyRequest
from google.storage_v1.types.storage import CreateHmacKeyResponse
from google.storage_v1.types.storage import DeleteBucketAccessControlRequest
from google.storage_v1.types.storage import DeleteBucketRequest
from google.storage_v1.types.storage import DeleteDefaultObjectAccessControlRequest
from google.storage_v1.types.storage import DeleteHmacKeyRequest
from google.storage_v1.types.storage import DeleteNotificationRequest
from google.storage_v1.types.storage import DeleteObjectAccessControlRequest
from google.storage_v1.types.storage import DeleteObjectRequest
from google.storage_v1.types.storage import GetBucketAccessControlRequest
from google.storage_v1.types.storage import GetBucketRequest
from google.storage_v1.types.storage import GetDefaultObjectAccessControlRequest
from google.storage_v1.types.storage import GetHmacKeyRequest
from google.storage_v1.types.storage import GetIamPolicyRequest
from google.storage_v1.types.storage import GetNotificationRequest
from google.storage_v1.types.storage import GetObjectAccessControlRequest
from google.storage_v1.types.storage import GetObjectMediaRequest
from google.storage_v1.types.storage import GetObjectMediaResponse
from google.storage_v1.types.storage import GetObjectRequest
from google.storage_v1.types.storage import GetProjectServiceAccountRequest
from google.storage_v1.types.storage import InsertBucketAccessControlRequest
from google.storage_v1.types.storage import InsertBucketRequest
from google.storage_v1.types.storage import InsertDefaultObjectAccessControlRequest
from google.storage_v1.types.storage import InsertNotificationRequest
from google.storage_v1.types.storage import InsertObjectAccessControlRequest
from google.storage_v1.types.storage import InsertObjectRequest
from google.storage_v1.types.storage import InsertObjectSpec
from google.storage_v1.types.storage import ListBucketAccessControlsRequest
from google.storage_v1.types.storage import ListBucketsRequest
from google.storage_v1.types.storage import ListChannelsRequest
from google.storage_v1.types.storage import ListDefaultObjectAccessControlsRequest
from google.storage_v1.types.storage import ListHmacKeysRequest
from google.storage_v1.types.storage import ListHmacKeysResponse
from google.storage_v1.types.storage import ListNotificationsRequest
from google.storage_v1.types.storage import ListObjectAccessControlsRequest
from google.storage_v1.types.storage import ListObjectsRequest
from google.storage_v1.types.storage import LockRetentionPolicyRequest
from google.storage_v1.types.storage import PatchBucketAccessControlRequest
from google.storage_v1.types.storage import PatchBucketRequest
from google.storage_v1.types.storage import PatchDefaultObjectAccessControlRequest
from google.storage_v1.types.storage import PatchObjectAccessControlRequest
from google.storage_v1.types.storage import PatchObjectRequest
from google.storage_v1.types.storage import QueryWriteStatusRequest
from google.storage_v1.types.storage import QueryWriteStatusResponse
from google.storage_v1.types.storage import RewriteObjectRequest
from google.storage_v1.types.storage import RewriteResponse
from google.storage_v1.types.storage import ServiceConstants
from google.storage_v1.types.storage import SetIamPolicyRequest
from google.storage_v1.types.storage import StartResumableWriteRequest
from google.storage_v1.types.storage import StartResumableWriteResponse
from google.storage_v1.types.storage import StopChannelRequest
from google.storage_v1.types.storage import TestIamPermissionsRequest
from google.storage_v1.types.storage import UpdateBucketAccessControlRequest
from google.storage_v1.types.storage import UpdateBucketRequest
from google.storage_v1.types.storage import UpdateDefaultObjectAccessControlRequest
from google.storage_v1.types.storage import UpdateHmacKeyRequest
from google.storage_v1.types.storage import UpdateObjectAccessControlRequest
from google.storage_v1.types.storage import UpdateObjectRequest
from google.storage_v1.types.storage import WatchAllObjectsRequest
from google.storage_v1.types.storage_resources import Bucket
from google.storage_v1.types.storage_resources import BucketAccessControl
from google.storage_v1.types.storage_resources import Channel
from google.storage_v1.types.storage_resources import ChecksummedData
from google.storage_v1.types.storage_resources import CommonEnums
from google.storage_v1.types.storage_resources import ContentRange
from google.storage_v1.types.storage_resources import HmacKeyMetadata
from google.storage_v1.types.storage_resources import ListBucketAccessControlsResponse
from google.storage_v1.types.storage_resources import ListBucketsResponse
from google.storage_v1.types.storage_resources import ListChannelsResponse
from google.storage_v1.types.storage_resources import ListNotificationsResponse
from google.storage_v1.types.storage_resources import ListObjectAccessControlsResponse
from google.storage_v1.types.storage_resources import ListObjectsResponse
from google.storage_v1.types.storage_resources import Notification
from google.storage_v1.types.storage_resources import Object
from google.storage_v1.types.storage_resources import ObjectAccessControl
from google.storage_v1.types.storage_resources import ObjectChecksums
from google.storage_v1.types.storage_resources import Owner
from google.storage_v1.types.storage_resources import ProjectTeam
from google.storage_v1.types.storage_resources import ServiceAccount

__all__ = (
    'Bucket',
    'BucketAccessControl',
    'Channel',
    'ChecksummedData',
    'CommonEnums',
    'CommonObjectRequestParams',
    'CommonRequestParams',
    'ComposeObjectRequest',
    'ContentRange',
    'CopyObjectRequest',
    'CreateHmacKeyRequest',
    'CreateHmacKeyResponse',
    'DeleteBucketAccessControlRequest',
    'DeleteBucketRequest',
    'DeleteDefaultObjectAccessControlRequest',
    'DeleteHmacKeyRequest',
    'DeleteNotificationRequest',
    'DeleteObjectAccessControlRequest',
    'DeleteObjectRequest',
    'GetBucketAccessControlRequest',
    'GetBucketRequest',
    'GetDefaultObjectAccessControlRequest',
    'GetHmacKeyRequest',
    'GetIamPolicyRequest',
    'GetNotificationRequest',
    'GetObjectAccessControlRequest',
    'GetObjectMediaRequest',
    'GetObjectMediaResponse',
    'GetObjectRequest',
    'GetProjectServiceAccountRequest',
    'HmacKeyMetadata',
    'InsertBucketAccessControlRequest',
    'InsertBucketRequest',
    'InsertDefaultObjectAccessControlRequest',
    'InsertNotificationRequest',
    'InsertObjectAccessControlRequest',
    'InsertObjectRequest',
    'InsertObjectSpec',
    'ListBucketAccessControlsRequest',
    'ListBucketAccessControlsResponse',
    'ListBucketsRequest',
    'ListBucketsResponse',
    'ListChannelsRequest',
    'ListChannelsResponse',
    'ListDefaultObjectAccessControlsRequest',
    'ListHmacKeysRequest',
    'ListHmacKeysResponse',
    'ListNotificationsRequest',
    'ListNotificationsResponse',
    'ListObjectAccessControlsRequest',
    'ListObjectAccessControlsResponse',
    'ListObjectsRequest',
    'ListObjectsResponse',
    'LockRetentionPolicyRequest',
    'Notification',
    'Object',
    'ObjectAccessControl',
    'ObjectChecksums',
    'Owner',
    'PatchBucketAccessControlRequest',
    'PatchBucketRequest',
    'PatchDefaultObjectAccessControlRequest',
    'PatchObjectAccessControlRequest',
    'PatchObjectRequest',
    'ProjectTeam',
    'QueryWriteStatusRequest',
    'QueryWriteStatusResponse',
    'RewriteObjectRequest',
    'RewriteResponse',
    'ServiceAccount',
    'ServiceConstants',
    'SetIamPolicyRequest',
    'StartResumableWriteRequest',
    'StartResumableWriteResponse',
    'StopChannelRequest',
    'StorageAsyncClient',
    'StorageClient',
    'TestIamPermissionsRequest',
    'UpdateBucketAccessControlRequest',
    'UpdateBucketRequest',
    'UpdateDefaultObjectAccessControlRequest',
    'UpdateHmacKeyRequest',
    'UpdateObjectAccessControlRequest',
    'UpdateObjectRequest',
    'WatchAllObjectsRequest',
)
