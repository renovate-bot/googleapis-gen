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
import typing
import pkg_resources

from google import auth  # type: ignore
from google.api_core import exceptions  # type: ignore
from google.api_core import gapic_v1    # type: ignore
from google.api_core import retry as retries  # type: ignore
from google.auth import credentials  # type: ignore

from google.iam.v1 import iam_policy_pb2 as iam_policy  # type: ignore
from google.iam.v1 import policy_pb2 as policy  # type: ignore
from google.protobuf import empty_pb2 as empty  # type: ignore
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

    def __init__(
            self, *,
            host: str = 'storage.googleapis.com',
            credentials: credentials.Credentials = None,
            credentials_file: typing.Optional[str] = None,
            scopes: typing.Optional[typing.Sequence[str]] = AUTH_SCOPES,
            quota_project_id: typing.Optional[str] = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            **kwargs,
            ) -> None:
        """Instantiate the transport.

        Args:
            host (Optional[str]): The hostname to connect to.
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            credentials_file (Optional[str]): A file with credentials that can
                be loaded with :func:`google.auth.load_credentials_from_file`.
                This argument is mutually exclusive with credentials.
            scope (Optional[Sequence[str]]): A list of scopes.
            quota_project_id (Optional[str]): An optional project to use for billing
                and quota.
            client_info (google.api_core.gapic_v1.client_info.ClientInfo):	
                The client info used to send a user-agent string along with	
                API requests. If ``None``, then default info will be used.	
                Generally, you only need to set this if you're developing	
                your own client library.
        """
        # Save the hostname. Default to port 443 (HTTPS) if none is specified.
        if ':' not in host:
            host += ':443'
        self._host = host

        # If no credentials are provided, then determine the appropriate
        # defaults.
        if credentials and credentials_file:
            raise exceptions.DuplicateCredentialArgs("'credentials_file' and 'credentials' are mutually exclusive")

        if credentials_file is not None:
            credentials, _ = auth.load_credentials_from_file(
                                credentials_file,
                                scopes=scopes,
                                quota_project_id=quota_project_id
                            )

        elif credentials is None:
            credentials, _ = auth.default(scopes=scopes, quota_project_id=quota_project_id)

        # Save the credentials.
        self._credentials = credentials

        # Lifted into its own function so it can be stubbed out during tests.
        self._prep_wrapped_messages(client_info)

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

    @property
    def delete_bucket_access_control(self) -> typing.Callable[
            [storage.DeleteBucketAccessControlRequest],
            typing.Union[
                empty.Empty,
                typing.Awaitable[empty.Empty]
            ]]:
        raise NotImplementedError()

    @property
    def get_bucket_access_control(self) -> typing.Callable[
            [storage.GetBucketAccessControlRequest],
            typing.Union[
                storage_resources.BucketAccessControl,
                typing.Awaitable[storage_resources.BucketAccessControl]
            ]]:
        raise NotImplementedError()

    @property
    def insert_bucket_access_control(self) -> typing.Callable[
            [storage.InsertBucketAccessControlRequest],
            typing.Union[
                storage_resources.BucketAccessControl,
                typing.Awaitable[storage_resources.BucketAccessControl]
            ]]:
        raise NotImplementedError()

    @property
    def list_bucket_access_controls(self) -> typing.Callable[
            [storage.ListBucketAccessControlsRequest],
            typing.Union[
                storage_resources.ListBucketAccessControlsResponse,
                typing.Awaitable[storage_resources.ListBucketAccessControlsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def update_bucket_access_control(self) -> typing.Callable[
            [storage.UpdateBucketAccessControlRequest],
            typing.Union[
                storage_resources.BucketAccessControl,
                typing.Awaitable[storage_resources.BucketAccessControl]
            ]]:
        raise NotImplementedError()

    @property
    def patch_bucket_access_control(self) -> typing.Callable[
            [storage.PatchBucketAccessControlRequest],
            typing.Union[
                storage_resources.BucketAccessControl,
                typing.Awaitable[storage_resources.BucketAccessControl]
            ]]:
        raise NotImplementedError()

    @property
    def delete_bucket(self) -> typing.Callable[
            [storage.DeleteBucketRequest],
            typing.Union[
                empty.Empty,
                typing.Awaitable[empty.Empty]
            ]]:
        raise NotImplementedError()

    @property
    def get_bucket(self) -> typing.Callable[
            [storage.GetBucketRequest],
            typing.Union[
                storage_resources.Bucket,
                typing.Awaitable[storage_resources.Bucket]
            ]]:
        raise NotImplementedError()

    @property
    def insert_bucket(self) -> typing.Callable[
            [storage.InsertBucketRequest],
            typing.Union[
                storage_resources.Bucket,
                typing.Awaitable[storage_resources.Bucket]
            ]]:
        raise NotImplementedError()

    @property
    def list_channels(self) -> typing.Callable[
            [storage.ListChannelsRequest],
            typing.Union[
                storage_resources.ListChannelsResponse,
                typing.Awaitable[storage_resources.ListChannelsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def list_buckets(self) -> typing.Callable[
            [storage.ListBucketsRequest],
            typing.Union[
                storage_resources.ListBucketsResponse,
                typing.Awaitable[storage_resources.ListBucketsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def lock_bucket_retention_policy(self) -> typing.Callable[
            [storage.LockRetentionPolicyRequest],
            typing.Union[
                storage_resources.Bucket,
                typing.Awaitable[storage_resources.Bucket]
            ]]:
        raise NotImplementedError()

    @property
    def get_bucket_iam_policy(self) -> typing.Callable[
            [storage.GetIamPolicyRequest],
            typing.Union[
                policy.Policy,
                typing.Awaitable[policy.Policy]
            ]]:
        raise NotImplementedError()

    @property
    def set_bucket_iam_policy(self) -> typing.Callable[
            [storage.SetIamPolicyRequest],
            typing.Union[
                policy.Policy,
                typing.Awaitable[policy.Policy]
            ]]:
        raise NotImplementedError()

    @property
    def test_bucket_iam_permissions(self) -> typing.Callable[
            [storage.TestIamPermissionsRequest],
            typing.Union[
                iam_policy.TestIamPermissionsResponse,
                typing.Awaitable[iam_policy.TestIamPermissionsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def patch_bucket(self) -> typing.Callable[
            [storage.PatchBucketRequest],
            typing.Union[
                storage_resources.Bucket,
                typing.Awaitable[storage_resources.Bucket]
            ]]:
        raise NotImplementedError()

    @property
    def update_bucket(self) -> typing.Callable[
            [storage.UpdateBucketRequest],
            typing.Union[
                storage_resources.Bucket,
                typing.Awaitable[storage_resources.Bucket]
            ]]:
        raise NotImplementedError()

    @property
    def stop_channel(self) -> typing.Callable[
            [storage.StopChannelRequest],
            typing.Union[
                empty.Empty,
                typing.Awaitable[empty.Empty]
            ]]:
        raise NotImplementedError()

    @property
    def delete_default_object_access_control(self) -> typing.Callable[
            [storage.DeleteDefaultObjectAccessControlRequest],
            typing.Union[
                empty.Empty,
                typing.Awaitable[empty.Empty]
            ]]:
        raise NotImplementedError()

    @property
    def get_default_object_access_control(self) -> typing.Callable[
            [storage.GetDefaultObjectAccessControlRequest],
            typing.Union[
                storage_resources.ObjectAccessControl,
                typing.Awaitable[storage_resources.ObjectAccessControl]
            ]]:
        raise NotImplementedError()

    @property
    def insert_default_object_access_control(self) -> typing.Callable[
            [storage.InsertDefaultObjectAccessControlRequest],
            typing.Union[
                storage_resources.ObjectAccessControl,
                typing.Awaitable[storage_resources.ObjectAccessControl]
            ]]:
        raise NotImplementedError()

    @property
    def list_default_object_access_controls(self) -> typing.Callable[
            [storage.ListDefaultObjectAccessControlsRequest],
            typing.Union[
                storage_resources.ListObjectAccessControlsResponse,
                typing.Awaitable[storage_resources.ListObjectAccessControlsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def patch_default_object_access_control(self) -> typing.Callable[
            [storage.PatchDefaultObjectAccessControlRequest],
            typing.Union[
                storage_resources.ObjectAccessControl,
                typing.Awaitable[storage_resources.ObjectAccessControl]
            ]]:
        raise NotImplementedError()

    @property
    def update_default_object_access_control(self) -> typing.Callable[
            [storage.UpdateDefaultObjectAccessControlRequest],
            typing.Union[
                storage_resources.ObjectAccessControl,
                typing.Awaitable[storage_resources.ObjectAccessControl]
            ]]:
        raise NotImplementedError()

    @property
    def delete_notification(self) -> typing.Callable[
            [storage.DeleteNotificationRequest],
            typing.Union[
                empty.Empty,
                typing.Awaitable[empty.Empty]
            ]]:
        raise NotImplementedError()

    @property
    def get_notification(self) -> typing.Callable[
            [storage.GetNotificationRequest],
            typing.Union[
                storage_resources.Notification,
                typing.Awaitable[storage_resources.Notification]
            ]]:
        raise NotImplementedError()

    @property
    def insert_notification(self) -> typing.Callable[
            [storage.InsertNotificationRequest],
            typing.Union[
                storage_resources.Notification,
                typing.Awaitable[storage_resources.Notification]
            ]]:
        raise NotImplementedError()

    @property
    def list_notifications(self) -> typing.Callable[
            [storage.ListNotificationsRequest],
            typing.Union[
                storage_resources.ListNotificationsResponse,
                typing.Awaitable[storage_resources.ListNotificationsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def delete_object_access_control(self) -> typing.Callable[
            [storage.DeleteObjectAccessControlRequest],
            typing.Union[
                empty.Empty,
                typing.Awaitable[empty.Empty]
            ]]:
        raise NotImplementedError()

    @property
    def get_object_access_control(self) -> typing.Callable[
            [storage.GetObjectAccessControlRequest],
            typing.Union[
                storage_resources.ObjectAccessControl,
                typing.Awaitable[storage_resources.ObjectAccessControl]
            ]]:
        raise NotImplementedError()

    @property
    def insert_object_access_control(self) -> typing.Callable[
            [storage.InsertObjectAccessControlRequest],
            typing.Union[
                storage_resources.ObjectAccessControl,
                typing.Awaitable[storage_resources.ObjectAccessControl]
            ]]:
        raise NotImplementedError()

    @property
    def list_object_access_controls(self) -> typing.Callable[
            [storage.ListObjectAccessControlsRequest],
            typing.Union[
                storage_resources.ListObjectAccessControlsResponse,
                typing.Awaitable[storage_resources.ListObjectAccessControlsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def patch_object_access_control(self) -> typing.Callable[
            [storage.PatchObjectAccessControlRequest],
            typing.Union[
                storage_resources.ObjectAccessControl,
                typing.Awaitable[storage_resources.ObjectAccessControl]
            ]]:
        raise NotImplementedError()

    @property
    def update_object_access_control(self) -> typing.Callable[
            [storage.UpdateObjectAccessControlRequest],
            typing.Union[
                storage_resources.ObjectAccessControl,
                typing.Awaitable[storage_resources.ObjectAccessControl]
            ]]:
        raise NotImplementedError()

    @property
    def compose_object(self) -> typing.Callable[
            [storage.ComposeObjectRequest],
            typing.Union[
                storage_resources.Object,
                typing.Awaitable[storage_resources.Object]
            ]]:
        raise NotImplementedError()

    @property
    def copy_object(self) -> typing.Callable[
            [storage.CopyObjectRequest],
            typing.Union[
                storage_resources.Object,
                typing.Awaitable[storage_resources.Object]
            ]]:
        raise NotImplementedError()

    @property
    def delete_object(self) -> typing.Callable[
            [storage.DeleteObjectRequest],
            typing.Union[
                empty.Empty,
                typing.Awaitable[empty.Empty]
            ]]:
        raise NotImplementedError()

    @property
    def get_object(self) -> typing.Callable[
            [storage.GetObjectRequest],
            typing.Union[
                storage_resources.Object,
                typing.Awaitable[storage_resources.Object]
            ]]:
        raise NotImplementedError()

    @property
    def get_object_media(self) -> typing.Callable[
            [storage.GetObjectMediaRequest],
            typing.Union[
                storage.GetObjectMediaResponse,
                typing.Awaitable[storage.GetObjectMediaResponse]
            ]]:
        raise NotImplementedError()

    @property
    def insert_object(self) -> typing.Callable[
            [storage.InsertObjectRequest],
            typing.Union[
                storage_resources.Object,
                typing.Awaitable[storage_resources.Object]
            ]]:
        raise NotImplementedError()

    @property
    def list_objects(self) -> typing.Callable[
            [storage.ListObjectsRequest],
            typing.Union[
                storage_resources.ListObjectsResponse,
                typing.Awaitable[storage_resources.ListObjectsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def rewrite_object(self) -> typing.Callable[
            [storage.RewriteObjectRequest],
            typing.Union[
                storage.RewriteResponse,
                typing.Awaitable[storage.RewriteResponse]
            ]]:
        raise NotImplementedError()

    @property
    def start_resumable_write(self) -> typing.Callable[
            [storage.StartResumableWriteRequest],
            typing.Union[
                storage.StartResumableWriteResponse,
                typing.Awaitable[storage.StartResumableWriteResponse]
            ]]:
        raise NotImplementedError()

    @property
    def query_write_status(self) -> typing.Callable[
            [storage.QueryWriteStatusRequest],
            typing.Union[
                storage.QueryWriteStatusResponse,
                typing.Awaitable[storage.QueryWriteStatusResponse]
            ]]:
        raise NotImplementedError()

    @property
    def patch_object(self) -> typing.Callable[
            [storage.PatchObjectRequest],
            typing.Union[
                storage_resources.Object,
                typing.Awaitable[storage_resources.Object]
            ]]:
        raise NotImplementedError()

    @property
    def update_object(self) -> typing.Callable[
            [storage.UpdateObjectRequest],
            typing.Union[
                storage_resources.Object,
                typing.Awaitable[storage_resources.Object]
            ]]:
        raise NotImplementedError()

    @property
    def get_object_iam_policy(self) -> typing.Callable[
            [storage.GetIamPolicyRequest],
            typing.Union[
                policy.Policy,
                typing.Awaitable[policy.Policy]
            ]]:
        raise NotImplementedError()

    @property
    def set_object_iam_policy(self) -> typing.Callable[
            [storage.SetIamPolicyRequest],
            typing.Union[
                policy.Policy,
                typing.Awaitable[policy.Policy]
            ]]:
        raise NotImplementedError()

    @property
    def test_object_iam_permissions(self) -> typing.Callable[
            [storage.TestIamPermissionsRequest],
            typing.Union[
                iam_policy.TestIamPermissionsResponse,
                typing.Awaitable[iam_policy.TestIamPermissionsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def watch_all_objects(self) -> typing.Callable[
            [storage.WatchAllObjectsRequest],
            typing.Union[
                storage_resources.Channel,
                typing.Awaitable[storage_resources.Channel]
            ]]:
        raise NotImplementedError()

    @property
    def get_service_account(self) -> typing.Callable[
            [storage.GetProjectServiceAccountRequest],
            typing.Union[
                storage_resources.ServiceAccount,
                typing.Awaitable[storage_resources.ServiceAccount]
            ]]:
        raise NotImplementedError()

    @property
    def create_hmac_key(self) -> typing.Callable[
            [storage.CreateHmacKeyRequest],
            typing.Union[
                storage.CreateHmacKeyResponse,
                typing.Awaitable[storage.CreateHmacKeyResponse]
            ]]:
        raise NotImplementedError()

    @property
    def delete_hmac_key(self) -> typing.Callable[
            [storage.DeleteHmacKeyRequest],
            typing.Union[
                empty.Empty,
                typing.Awaitable[empty.Empty]
            ]]:
        raise NotImplementedError()

    @property
    def get_hmac_key(self) -> typing.Callable[
            [storage.GetHmacKeyRequest],
            typing.Union[
                storage_resources.HmacKeyMetadata,
                typing.Awaitable[storage_resources.HmacKeyMetadata]
            ]]:
        raise NotImplementedError()

    @property
    def list_hmac_keys(self) -> typing.Callable[
            [storage.ListHmacKeysRequest],
            typing.Union[
                storage.ListHmacKeysResponse,
                typing.Awaitable[storage.ListHmacKeysResponse]
            ]]:
        raise NotImplementedError()

    @property
    def update_hmac_key(self) -> typing.Callable[
            [storage.UpdateHmacKeyRequest],
            typing.Union[
                storage_resources.HmacKeyMetadata,
                typing.Awaitable[storage_resources.HmacKeyMetadata]
            ]]:
        raise NotImplementedError()


__all__ = (
    'StorageTransport',
)
