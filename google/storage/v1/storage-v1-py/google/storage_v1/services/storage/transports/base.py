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
import abc
from typing import Awaitable, Callable, Dict, Optional, Sequence, Union
import pkg_resources

import google.auth  # type: ignore
import google.api_core  # type: ignore
from google.api_core import exceptions as core_exceptions  # type: ignore
from google.api_core import gapic_v1    # type: ignore
from google.api_core import retry as retries  # type: ignore
from google.auth import credentials as ga_credentials  # type: ignore
from google.oauth2 import service_account # type: ignore

from google.iam.v1 import iam_policy_pb2  # type: ignore
from google.iam.v1 import policy_pb2  # type: ignore
from google.protobuf import empty_pb2  # type: ignore
from google.storage_v1.types import storage
from google.storage_v1.types import storage_resources

try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            'google-storage',
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


class StorageTransport(abc.ABC):
    """Abstract transport class for Storage."""

    AUTH_SCOPES = (
        'https://www.googleapis.com/auth/cloud-platform',
        'https://www.googleapis.com/auth/cloud-platform.read-only',
        'https://www.googleapis.com/auth/devstorage.full_control',
        'https://www.googleapis.com/auth/devstorage.read_only',
        'https://www.googleapis.com/auth/devstorage.read_write',
    )

    DEFAULT_HOST: str = 'storage.googleapis.com'
    def __init__(
            self, *,
            host: str = DEFAULT_HOST,
            credentials: ga_credentials.Credentials = None,
            credentials_file: Optional[str] = None,
            scopes: Optional[Sequence[str]] = None,
            quota_project_id: Optional[str] = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            always_use_jwt_access: Optional[bool] = False,
            **kwargs,
            ) -> None:
        """Instantiate the transport.

        Args:
            host (Optional[str]):
                 The hostname to connect to.
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            credentials_file (Optional[str]): A file with credentials that can
                be loaded with :func:`google.auth.load_credentials_from_file`.
                This argument is mutually exclusive with credentials.
            scopes (Optional[Sequence[str]]): A list of scopes.
            quota_project_id (Optional[str]): An optional project to use for billing
                and quota.
            client_info (google.api_core.gapic_v1.client_info.ClientInfo):
                The client info used to send a user-agent string along with
                API requests. If ``None``, then default info will be used.
                Generally, you only need to set this if you're developing
                your own client library.
            always_use_jwt_access (Optional[bool]): Whether self signed JWT should
                be used for service account credentials.
        """
        # Save the hostname. Default to port 443 (HTTPS) if none is specified.
        if ':' not in host:
            host += ':443'
        self._host = host

        scopes_kwargs = {"scopes": scopes, "default_scopes": self.AUTH_SCOPES}

        # Save the scopes.
        self._scopes = scopes

        # If no credentials are provided, then determine the appropriate
        # defaults.
        if credentials and credentials_file:
            raise core_exceptions.DuplicateCredentialArgs("'credentials_file' and 'credentials' are mutually exclusive")

        if credentials_file is not None:
            credentials, _ = google.auth.load_credentials_from_file(
                                credentials_file,
                                **scopes_kwargs,
                                quota_project_id=quota_project_id
                            )

        elif credentials is None:
            credentials, _ = google.auth.default(**scopes_kwargs, quota_project_id=quota_project_id)

        # If the credentials are service account credentials, then always try to use self signed JWT.
        if always_use_jwt_access and isinstance(credentials, service_account.Credentials) and hasattr(service_account.Credentials, "with_always_use_jwt_access"):
            credentials = credentials.with_always_use_jwt_access(True)

        # Save the credentials.
        self._credentials = credentials

    def _prep_wrapped_messages(self, client_info):
        # Precompute the wrapped methods.
        self._wrapped_methods = {
            self.delete_bucket_access_control: gapic_v1.method.wrap_method(
                self.delete_bucket_access_control,
                default_timeout=None,
                client_info=client_info,
            ),
            self.get_bucket_access_control: gapic_v1.method.wrap_method(
                self.get_bucket_access_control,
                default_timeout=None,
                client_info=client_info,
            ),
            self.insert_bucket_access_control: gapic_v1.method.wrap_method(
                self.insert_bucket_access_control,
                default_timeout=None,
                client_info=client_info,
            ),
            self.list_bucket_access_controls: gapic_v1.method.wrap_method(
                self.list_bucket_access_controls,
                default_timeout=None,
                client_info=client_info,
            ),
            self.update_bucket_access_control: gapic_v1.method.wrap_method(
                self.update_bucket_access_control,
                default_timeout=None,
                client_info=client_info,
            ),
            self.patch_bucket_access_control: gapic_v1.method.wrap_method(
                self.patch_bucket_access_control,
                default_timeout=None,
                client_info=client_info,
            ),
            self.delete_bucket: gapic_v1.method.wrap_method(
                self.delete_bucket,
                default_timeout=None,
                client_info=client_info,
            ),
            self.get_bucket: gapic_v1.method.wrap_method(
                self.get_bucket,
                default_timeout=None,
                client_info=client_info,
            ),
            self.insert_bucket: gapic_v1.method.wrap_method(
                self.insert_bucket,
                default_timeout=None,
                client_info=client_info,
            ),
            self.list_channels: gapic_v1.method.wrap_method(
                self.list_channels,
                default_timeout=None,
                client_info=client_info,
            ),
            self.list_buckets: gapic_v1.method.wrap_method(
                self.list_buckets,
                default_timeout=None,
                client_info=client_info,
            ),
            self.lock_bucket_retention_policy: gapic_v1.method.wrap_method(
                self.lock_bucket_retention_policy,
                default_timeout=None,
                client_info=client_info,
            ),
            self.get_bucket_iam_policy: gapic_v1.method.wrap_method(
                self.get_bucket_iam_policy,
                default_timeout=None,
                client_info=client_info,
            ),
            self.set_bucket_iam_policy: gapic_v1.method.wrap_method(
                self.set_bucket_iam_policy,
                default_timeout=None,
                client_info=client_info,
            ),
            self.test_bucket_iam_permissions: gapic_v1.method.wrap_method(
                self.test_bucket_iam_permissions,
                default_timeout=None,
                client_info=client_info,
            ),
            self.patch_bucket: gapic_v1.method.wrap_method(
                self.patch_bucket,
                default_timeout=None,
                client_info=client_info,
            ),
            self.update_bucket: gapic_v1.method.wrap_method(
                self.update_bucket,
                default_timeout=None,
                client_info=client_info,
            ),
            self.stop_channel: gapic_v1.method.wrap_method(
                self.stop_channel,
                default_timeout=None,
                client_info=client_info,
            ),
            self.delete_default_object_access_control: gapic_v1.method.wrap_method(
                self.delete_default_object_access_control,
                default_timeout=None,
                client_info=client_info,
            ),
            self.get_default_object_access_control: gapic_v1.method.wrap_method(
                self.get_default_object_access_control,
                default_timeout=None,
                client_info=client_info,
            ),
            self.insert_default_object_access_control: gapic_v1.method.wrap_method(
                self.insert_default_object_access_control,
                default_timeout=None,
                client_info=client_info,
            ),
            self.list_default_object_access_controls: gapic_v1.method.wrap_method(
                self.list_default_object_access_controls,
                default_timeout=None,
                client_info=client_info,
            ),
            self.patch_default_object_access_control: gapic_v1.method.wrap_method(
                self.patch_default_object_access_control,
                default_timeout=None,
                client_info=client_info,
            ),
            self.update_default_object_access_control: gapic_v1.method.wrap_method(
                self.update_default_object_access_control,
                default_timeout=None,
                client_info=client_info,
            ),
            self.delete_notification: gapic_v1.method.wrap_method(
                self.delete_notification,
                default_timeout=None,
                client_info=client_info,
            ),
            self.get_notification: gapic_v1.method.wrap_method(
                self.get_notification,
                default_timeout=None,
                client_info=client_info,
            ),
            self.insert_notification: gapic_v1.method.wrap_method(
                self.insert_notification,
                default_timeout=None,
                client_info=client_info,
            ),
            self.list_notifications: gapic_v1.method.wrap_method(
                self.list_notifications,
                default_timeout=None,
                client_info=client_info,
            ),
            self.delete_object_access_control: gapic_v1.method.wrap_method(
                self.delete_object_access_control,
                default_timeout=None,
                client_info=client_info,
            ),
            self.get_object_access_control: gapic_v1.method.wrap_method(
                self.get_object_access_control,
                default_timeout=None,
                client_info=client_info,
            ),
            self.insert_object_access_control: gapic_v1.method.wrap_method(
                self.insert_object_access_control,
                default_timeout=None,
                client_info=client_info,
            ),
            self.list_object_access_controls: gapic_v1.method.wrap_method(
                self.list_object_access_controls,
                default_timeout=None,
                client_info=client_info,
            ),
            self.patch_object_access_control: gapic_v1.method.wrap_method(
                self.patch_object_access_control,
                default_timeout=None,
                client_info=client_info,
            ),
            self.update_object_access_control: gapic_v1.method.wrap_method(
                self.update_object_access_control,
                default_timeout=None,
                client_info=client_info,
            ),
            self.compose_object: gapic_v1.method.wrap_method(
                self.compose_object,
                default_timeout=None,
                client_info=client_info,
            ),
            self.copy_object: gapic_v1.method.wrap_method(
                self.copy_object,
                default_timeout=None,
                client_info=client_info,
            ),
            self.delete_object: gapic_v1.method.wrap_method(
                self.delete_object,
                default_timeout=None,
                client_info=client_info,
            ),
            self.get_object: gapic_v1.method.wrap_method(
                self.get_object,
                default_timeout=None,
                client_info=client_info,
            ),
            self.get_object_media: gapic_v1.method.wrap_method(
                self.get_object_media,
                default_timeout=None,
                client_info=client_info,
            ),
            self.insert_object: gapic_v1.method.wrap_method(
                self.insert_object,
                default_timeout=None,
                client_info=client_info,
            ),
            self.list_objects: gapic_v1.method.wrap_method(
                self.list_objects,
                default_timeout=None,
                client_info=client_info,
            ),
            self.rewrite_object: gapic_v1.method.wrap_method(
                self.rewrite_object,
                default_timeout=None,
                client_info=client_info,
            ),
            self.start_resumable_write: gapic_v1.method.wrap_method(
                self.start_resumable_write,
                default_timeout=None,
                client_info=client_info,
            ),
            self.query_write_status: gapic_v1.method.wrap_method(
                self.query_write_status,
                default_timeout=None,
                client_info=client_info,
            ),
            self.patch_object: gapic_v1.method.wrap_method(
                self.patch_object,
                default_timeout=None,
                client_info=client_info,
            ),
            self.update_object: gapic_v1.method.wrap_method(
                self.update_object,
                default_timeout=None,
                client_info=client_info,
            ),
            self.get_object_iam_policy: gapic_v1.method.wrap_method(
                self.get_object_iam_policy,
                default_timeout=None,
                client_info=client_info,
            ),
            self.set_object_iam_policy: gapic_v1.method.wrap_method(
                self.set_object_iam_policy,
                default_timeout=None,
                client_info=client_info,
            ),
            self.test_object_iam_permissions: gapic_v1.method.wrap_method(
                self.test_object_iam_permissions,
                default_timeout=None,
                client_info=client_info,
            ),
            self.watch_all_objects: gapic_v1.method.wrap_method(
                self.watch_all_objects,
                default_timeout=None,
                client_info=client_info,
            ),
            self.get_service_account: gapic_v1.method.wrap_method(
                self.get_service_account,
                default_timeout=None,
                client_info=client_info,
            ),
            self.create_hmac_key: gapic_v1.method.wrap_method(
                self.create_hmac_key,
                default_timeout=None,
                client_info=client_info,
            ),
            self.delete_hmac_key: gapic_v1.method.wrap_method(
                self.delete_hmac_key,
                default_timeout=None,
                client_info=client_info,
            ),
            self.get_hmac_key: gapic_v1.method.wrap_method(
                self.get_hmac_key,
                default_timeout=None,
                client_info=client_info,
            ),
            self.list_hmac_keys: gapic_v1.method.wrap_method(
                self.list_hmac_keys,
                default_timeout=None,
                client_info=client_info,
            ),
            self.update_hmac_key: gapic_v1.method.wrap_method(
                self.update_hmac_key,
                default_timeout=None,
                client_info=client_info,
            ),
         }

    def close(self):
        """Closes resources associated with the transport.

       .. warning::
            Only call this method if the transport is NOT shared
            with other clients - this may cause errors in other clients!
        """
        raise NotImplementedError()

    @property
    def delete_bucket_access_control(self) -> Callable[
            [storage.DeleteBucketAccessControlRequest],
            Union[
                empty_pb2.Empty,
                Awaitable[empty_pb2.Empty]
            ]]:
        raise NotImplementedError()

    @property
    def get_bucket_access_control(self) -> Callable[
            [storage.GetBucketAccessControlRequest],
            Union[
                storage_resources.BucketAccessControl,
                Awaitable[storage_resources.BucketAccessControl]
            ]]:
        raise NotImplementedError()

    @property
    def insert_bucket_access_control(self) -> Callable[
            [storage.InsertBucketAccessControlRequest],
            Union[
                storage_resources.BucketAccessControl,
                Awaitable[storage_resources.BucketAccessControl]
            ]]:
        raise NotImplementedError()

    @property
    def list_bucket_access_controls(self) -> Callable[
            [storage.ListBucketAccessControlsRequest],
            Union[
                storage_resources.ListBucketAccessControlsResponse,
                Awaitable[storage_resources.ListBucketAccessControlsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def update_bucket_access_control(self) -> Callable[
            [storage.UpdateBucketAccessControlRequest],
            Union[
                storage_resources.BucketAccessControl,
                Awaitable[storage_resources.BucketAccessControl]
            ]]:
        raise NotImplementedError()

    @property
    def patch_bucket_access_control(self) -> Callable[
            [storage.PatchBucketAccessControlRequest],
            Union[
                storage_resources.BucketAccessControl,
                Awaitable[storage_resources.BucketAccessControl]
            ]]:
        raise NotImplementedError()

    @property
    def delete_bucket(self) -> Callable[
            [storage.DeleteBucketRequest],
            Union[
                empty_pb2.Empty,
                Awaitable[empty_pb2.Empty]
            ]]:
        raise NotImplementedError()

    @property
    def get_bucket(self) -> Callable[
            [storage.GetBucketRequest],
            Union[
                storage_resources.Bucket,
                Awaitable[storage_resources.Bucket]
            ]]:
        raise NotImplementedError()

    @property
    def insert_bucket(self) -> Callable[
            [storage.InsertBucketRequest],
            Union[
                storage_resources.Bucket,
                Awaitable[storage_resources.Bucket]
            ]]:
        raise NotImplementedError()

    @property
    def list_channels(self) -> Callable[
            [storage.ListChannelsRequest],
            Union[
                storage_resources.ListChannelsResponse,
                Awaitable[storage_resources.ListChannelsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def list_buckets(self) -> Callable[
            [storage.ListBucketsRequest],
            Union[
                storage_resources.ListBucketsResponse,
                Awaitable[storage_resources.ListBucketsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def lock_bucket_retention_policy(self) -> Callable[
            [storage.LockRetentionPolicyRequest],
            Union[
                storage_resources.Bucket,
                Awaitable[storage_resources.Bucket]
            ]]:
        raise NotImplementedError()

    @property
    def get_bucket_iam_policy(self) -> Callable[
            [storage.GetIamPolicyRequest],
            Union[
                policy_pb2.Policy,
                Awaitable[policy_pb2.Policy]
            ]]:
        raise NotImplementedError()

    @property
    def set_bucket_iam_policy(self) -> Callable[
            [storage.SetIamPolicyRequest],
            Union[
                policy_pb2.Policy,
                Awaitable[policy_pb2.Policy]
            ]]:
        raise NotImplementedError()

    @property
    def test_bucket_iam_permissions(self) -> Callable[
            [storage.TestIamPermissionsRequest],
            Union[
                iam_policy_pb2.TestIamPermissionsResponse,
                Awaitable[iam_policy_pb2.TestIamPermissionsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def patch_bucket(self) -> Callable[
            [storage.PatchBucketRequest],
            Union[
                storage_resources.Bucket,
                Awaitable[storage_resources.Bucket]
            ]]:
        raise NotImplementedError()

    @property
    def update_bucket(self) -> Callable[
            [storage.UpdateBucketRequest],
            Union[
                storage_resources.Bucket,
                Awaitable[storage_resources.Bucket]
            ]]:
        raise NotImplementedError()

    @property
    def stop_channel(self) -> Callable[
            [storage.StopChannelRequest],
            Union[
                empty_pb2.Empty,
                Awaitable[empty_pb2.Empty]
            ]]:
        raise NotImplementedError()

    @property
    def delete_default_object_access_control(self) -> Callable[
            [storage.DeleteDefaultObjectAccessControlRequest],
            Union[
                empty_pb2.Empty,
                Awaitable[empty_pb2.Empty]
            ]]:
        raise NotImplementedError()

    @property
    def get_default_object_access_control(self) -> Callable[
            [storage.GetDefaultObjectAccessControlRequest],
            Union[
                storage_resources.ObjectAccessControl,
                Awaitable[storage_resources.ObjectAccessControl]
            ]]:
        raise NotImplementedError()

    @property
    def insert_default_object_access_control(self) -> Callable[
            [storage.InsertDefaultObjectAccessControlRequest],
            Union[
                storage_resources.ObjectAccessControl,
                Awaitable[storage_resources.ObjectAccessControl]
            ]]:
        raise NotImplementedError()

    @property
    def list_default_object_access_controls(self) -> Callable[
            [storage.ListDefaultObjectAccessControlsRequest],
            Union[
                storage_resources.ListObjectAccessControlsResponse,
                Awaitable[storage_resources.ListObjectAccessControlsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def patch_default_object_access_control(self) -> Callable[
            [storage.PatchDefaultObjectAccessControlRequest],
            Union[
                storage_resources.ObjectAccessControl,
                Awaitable[storage_resources.ObjectAccessControl]
            ]]:
        raise NotImplementedError()

    @property
    def update_default_object_access_control(self) -> Callable[
            [storage.UpdateDefaultObjectAccessControlRequest],
            Union[
                storage_resources.ObjectAccessControl,
                Awaitable[storage_resources.ObjectAccessControl]
            ]]:
        raise NotImplementedError()

    @property
    def delete_notification(self) -> Callable[
            [storage.DeleteNotificationRequest],
            Union[
                empty_pb2.Empty,
                Awaitable[empty_pb2.Empty]
            ]]:
        raise NotImplementedError()

    @property
    def get_notification(self) -> Callable[
            [storage.GetNotificationRequest],
            Union[
                storage_resources.Notification,
                Awaitable[storage_resources.Notification]
            ]]:
        raise NotImplementedError()

    @property
    def insert_notification(self) -> Callable[
            [storage.InsertNotificationRequest],
            Union[
                storage_resources.Notification,
                Awaitable[storage_resources.Notification]
            ]]:
        raise NotImplementedError()

    @property
    def list_notifications(self) -> Callable[
            [storage.ListNotificationsRequest],
            Union[
                storage_resources.ListNotificationsResponse,
                Awaitable[storage_resources.ListNotificationsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def delete_object_access_control(self) -> Callable[
            [storage.DeleteObjectAccessControlRequest],
            Union[
                empty_pb2.Empty,
                Awaitable[empty_pb2.Empty]
            ]]:
        raise NotImplementedError()

    @property
    def get_object_access_control(self) -> Callable[
            [storage.GetObjectAccessControlRequest],
            Union[
                storage_resources.ObjectAccessControl,
                Awaitable[storage_resources.ObjectAccessControl]
            ]]:
        raise NotImplementedError()

    @property
    def insert_object_access_control(self) -> Callable[
            [storage.InsertObjectAccessControlRequest],
            Union[
                storage_resources.ObjectAccessControl,
                Awaitable[storage_resources.ObjectAccessControl]
            ]]:
        raise NotImplementedError()

    @property
    def list_object_access_controls(self) -> Callable[
            [storage.ListObjectAccessControlsRequest],
            Union[
                storage_resources.ListObjectAccessControlsResponse,
                Awaitable[storage_resources.ListObjectAccessControlsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def patch_object_access_control(self) -> Callable[
            [storage.PatchObjectAccessControlRequest],
            Union[
                storage_resources.ObjectAccessControl,
                Awaitable[storage_resources.ObjectAccessControl]
            ]]:
        raise NotImplementedError()

    @property
    def update_object_access_control(self) -> Callable[
            [storage.UpdateObjectAccessControlRequest],
            Union[
                storage_resources.ObjectAccessControl,
                Awaitable[storage_resources.ObjectAccessControl]
            ]]:
        raise NotImplementedError()

    @property
    def compose_object(self) -> Callable[
            [storage.ComposeObjectRequest],
            Union[
                storage_resources.Object,
                Awaitable[storage_resources.Object]
            ]]:
        raise NotImplementedError()

    @property
    def copy_object(self) -> Callable[
            [storage.CopyObjectRequest],
            Union[
                storage_resources.Object,
                Awaitable[storage_resources.Object]
            ]]:
        raise NotImplementedError()

    @property
    def delete_object(self) -> Callable[
            [storage.DeleteObjectRequest],
            Union[
                empty_pb2.Empty,
                Awaitable[empty_pb2.Empty]
            ]]:
        raise NotImplementedError()

    @property
    def get_object(self) -> Callable[
            [storage.GetObjectRequest],
            Union[
                storage_resources.Object,
                Awaitable[storage_resources.Object]
            ]]:
        raise NotImplementedError()

    @property
    def get_object_media(self) -> Callable[
            [storage.GetObjectMediaRequest],
            Union[
                storage.GetObjectMediaResponse,
                Awaitable[storage.GetObjectMediaResponse]
            ]]:
        raise NotImplementedError()

    @property
    def insert_object(self) -> Callable[
            [storage.InsertObjectRequest],
            Union[
                storage_resources.Object,
                Awaitable[storage_resources.Object]
            ]]:
        raise NotImplementedError()

    @property
    def list_objects(self) -> Callable[
            [storage.ListObjectsRequest],
            Union[
                storage_resources.ListObjectsResponse,
                Awaitable[storage_resources.ListObjectsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def rewrite_object(self) -> Callable[
            [storage.RewriteObjectRequest],
            Union[
                storage.RewriteResponse,
                Awaitable[storage.RewriteResponse]
            ]]:
        raise NotImplementedError()

    @property
    def start_resumable_write(self) -> Callable[
            [storage.StartResumableWriteRequest],
            Union[
                storage.StartResumableWriteResponse,
                Awaitable[storage.StartResumableWriteResponse]
            ]]:
        raise NotImplementedError()

    @property
    def query_write_status(self) -> Callable[
            [storage.QueryWriteStatusRequest],
            Union[
                storage.QueryWriteStatusResponse,
                Awaitable[storage.QueryWriteStatusResponse]
            ]]:
        raise NotImplementedError()

    @property
    def patch_object(self) -> Callable[
            [storage.PatchObjectRequest],
            Union[
                storage_resources.Object,
                Awaitable[storage_resources.Object]
            ]]:
        raise NotImplementedError()

    @property
    def update_object(self) -> Callable[
            [storage.UpdateObjectRequest],
            Union[
                storage_resources.Object,
                Awaitable[storage_resources.Object]
            ]]:
        raise NotImplementedError()

    @property
    def get_object_iam_policy(self) -> Callable[
            [storage.GetIamPolicyRequest],
            Union[
                policy_pb2.Policy,
                Awaitable[policy_pb2.Policy]
            ]]:
        raise NotImplementedError()

    @property
    def set_object_iam_policy(self) -> Callable[
            [storage.SetIamPolicyRequest],
            Union[
                policy_pb2.Policy,
                Awaitable[policy_pb2.Policy]
            ]]:
        raise NotImplementedError()

    @property
    def test_object_iam_permissions(self) -> Callable[
            [storage.TestIamPermissionsRequest],
            Union[
                iam_policy_pb2.TestIamPermissionsResponse,
                Awaitable[iam_policy_pb2.TestIamPermissionsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def watch_all_objects(self) -> Callable[
            [storage.WatchAllObjectsRequest],
            Union[
                storage_resources.Channel,
                Awaitable[storage_resources.Channel]
            ]]:
        raise NotImplementedError()

    @property
    def get_service_account(self) -> Callable[
            [storage.GetProjectServiceAccountRequest],
            Union[
                storage_resources.ServiceAccount,
                Awaitable[storage_resources.ServiceAccount]
            ]]:
        raise NotImplementedError()

    @property
    def create_hmac_key(self) -> Callable[
            [storage.CreateHmacKeyRequest],
            Union[
                storage.CreateHmacKeyResponse,
                Awaitable[storage.CreateHmacKeyResponse]
            ]]:
        raise NotImplementedError()

    @property
    def delete_hmac_key(self) -> Callable[
            [storage.DeleteHmacKeyRequest],
            Union[
                empty_pb2.Empty,
                Awaitable[empty_pb2.Empty]
            ]]:
        raise NotImplementedError()

    @property
    def get_hmac_key(self) -> Callable[
            [storage.GetHmacKeyRequest],
            Union[
                storage_resources.HmacKeyMetadata,
                Awaitable[storage_resources.HmacKeyMetadata]
            ]]:
        raise NotImplementedError()

    @property
    def list_hmac_keys(self) -> Callable[
            [storage.ListHmacKeysRequest],
            Union[
                storage.ListHmacKeysResponse,
                Awaitable[storage.ListHmacKeysResponse]
            ]]:
        raise NotImplementedError()

    @property
    def update_hmac_key(self) -> Callable[
            [storage.UpdateHmacKeyRequest],
            Union[
                storage_resources.HmacKeyMetadata,
                Awaitable[storage_resources.HmacKeyMetadata]
            ]]:
        raise NotImplementedError()


__all__ = (
    'StorageTransport',
)
