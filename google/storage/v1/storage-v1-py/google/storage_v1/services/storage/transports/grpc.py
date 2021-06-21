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
import warnings
from typing import Callable, Dict, Optional, Sequence, Tuple, Union

from google.api_core import grpc_helpers   # type: ignore
from google.api_core import gapic_v1       # type: ignore
import google.auth                         # type: ignore
from google.auth import credentials as ga_credentials  # type: ignore
from google.auth.transport.grpc import SslCredentials  # type: ignore

import grpc  # type: ignore

from google.iam.v1 import iam_policy_pb2  # type: ignore
from google.iam.v1 import policy_pb2  # type: ignore
from google.protobuf import empty_pb2  # type: ignore
from google.storage_v1.types import storage
from google.storage_v1.types import storage_resources
from .base import StorageTransport, DEFAULT_CLIENT_INFO


class StorageGrpcTransport(StorageTransport):
    """gRPC backend transport for Storage.

    Manages Google Cloud Storage resources.

    This class defines the same methods as the primary client, so the
    primary client can load the underlying transport implementation
    and call it.

    It sends protocol buffers over the wire using gRPC (which is built on
    top of HTTP/2); the ``grpcio`` package must be installed.
    """
    _stubs: Dict[str, Callable]

    def __init__(self, *,
            host: str = 'storage.googleapis.com',
            credentials: ga_credentials.Credentials = None,
            credentials_file: str = None,
            scopes: Sequence[str] = None,
            channel: grpc.Channel = None,
            api_mtls_endpoint: str = None,
            client_cert_source: Callable[[], Tuple[bytes, bytes]] = None,
            ssl_channel_credentials: grpc.ChannelCredentials = None,
            client_cert_source_for_mtls: Callable[[], Tuple[bytes, bytes]] = None,
            quota_project_id: Optional[str] = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
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
                This argument is ignored if ``channel`` is provided.
            credentials_file (Optional[str]): A file with credentials that can
                be loaded with :func:`google.auth.load_credentials_from_file`.
                This argument is ignored if ``channel`` is provided.
            scopes (Optional(Sequence[str])): A list of scopes. This argument is
                ignored if ``channel`` is provided.
            channel (Optional[grpc.Channel]): A ``Channel`` instance through
                which to make calls.
            api_mtls_endpoint (Optional[str]): Deprecated. The mutual TLS endpoint.
                If provided, it overrides the ``host`` argument and tries to create
                a mutual TLS channel with client SSL credentials from
                ``client_cert_source`` or applicatin default SSL credentials.
            client_cert_source (Optional[Callable[[], Tuple[bytes, bytes]]]):
                Deprecated. A callback to provide client SSL certificate bytes and
                private key bytes, both in PEM format. It is ignored if
                ``api_mtls_endpoint`` is None.
            ssl_channel_credentials (grpc.ChannelCredentials): SSL credentials
                for grpc channel. It is ignored if ``channel`` is provided.
            client_cert_source_for_mtls (Optional[Callable[[], Tuple[bytes, bytes]]]):
                A callback to provide client certificate bytes and private key bytes,
                both in PEM format. It is used to configure mutual TLS channel. It is
                ignored if ``channel`` or ``ssl_channel_credentials`` is provided.
            quota_project_id (Optional[str]): An optional project to use for billing
                and quota.
            client_info (google.api_core.gapic_v1.client_info.ClientInfo):
                The client info used to send a user-agent string along with
                API requests. If ``None``, then default info will be used.
                Generally, you only need to set this if you're developing
                your own client library.

        Raises:
          google.auth.exceptions.MutualTLSChannelError: If mutual TLS transport
              creation failed for any reason.
          google.api_core.exceptions.DuplicateCredentialArgs: If both ``credentials``
              and ``credentials_file`` are passed.
        """
        self._grpc_channel = None
        self._ssl_channel_credentials = ssl_channel_credentials
        self._stubs: Dict[str, Callable] = {}

        if api_mtls_endpoint:
            warnings.warn("api_mtls_endpoint is deprecated", DeprecationWarning)
        if client_cert_source:
            warnings.warn("client_cert_source is deprecated", DeprecationWarning)

        if channel:
            # Ignore credentials if a channel was passed.
            credentials = False
            # If a channel was explicitly provided, set it.
            self._grpc_channel = channel
            self._ssl_channel_credentials = None

        else:
            if api_mtls_endpoint:
                host = api_mtls_endpoint

                # Create SSL credentials with client_cert_source or application
                # default SSL credentials.
                if client_cert_source:
                    cert, key = client_cert_source()
                    self._ssl_channel_credentials = grpc.ssl_channel_credentials(
                        certificate_chain=cert, private_key=key
                    )
                else:
                    self._ssl_channel_credentials = SslCredentials().ssl_credentials

            else:
                if client_cert_source_for_mtls and not ssl_channel_credentials:
                    cert, key = client_cert_source_for_mtls()
                    self._ssl_channel_credentials = grpc.ssl_channel_credentials(
                        certificate_chain=cert, private_key=key
                    )

        # The base transport sets the host, credentials and scopes
        super().__init__(
            host=host,
            credentials=credentials,
            credentials_file=credentials_file,
            scopes=scopes,
            quota_project_id=quota_project_id,
            client_info=client_info,
            always_use_jwt_access=True,
        )

        if not self._grpc_channel:
            self._grpc_channel = type(self).create_channel(
                self._host,
                credentials=self._credentials,
                credentials_file=credentials_file,
                scopes=self._scopes,
                ssl_credentials=self._ssl_channel_credentials,
                quota_project_id=quota_project_id,
                options=[
                    ("grpc.max_send_message_length", -1),
                    ("grpc.max_receive_message_length", -1),
                ],
            )

        # Wrap messages. This must be done after self._grpc_channel exists
        self._prep_wrapped_messages(client_info)

    @classmethod
    def create_channel(cls,
                       host: str = 'storage.googleapis.com',
                       credentials: ga_credentials.Credentials = None,
                       credentials_file: str = None,
                       scopes: Optional[Sequence[str]] = None,
                       quota_project_id: Optional[str] = None,
                       **kwargs) -> grpc.Channel:
        """Create and return a gRPC channel object.
        Args:
            host (Optional[str]): The host for the channel to use.
            credentials (Optional[~.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify this application to the service. If
                none are specified, the client will attempt to ascertain
                the credentials from the environment.
            credentials_file (Optional[str]): A file with credentials that can
                be loaded with :func:`google.auth.load_credentials_from_file`.
                This argument is mutually exclusive with credentials.
            scopes (Optional[Sequence[str]]): A optional list of scopes needed for this
                service. These are only used when credentials are not specified and
                are passed to :func:`google.auth.default`.
            quota_project_id (Optional[str]): An optional project to use for billing
                and quota.
            kwargs (Optional[dict]): Keyword arguments, which are passed to the
                channel creation.
        Returns:
            grpc.Channel: A gRPC channel object.

        Raises:
            google.api_core.exceptions.DuplicateCredentialArgs: If both ``credentials``
              and ``credentials_file`` are passed.
        """

        return grpc_helpers.create_channel(
            host,
            credentials=credentials,
            credentials_file=credentials_file,
            quota_project_id=quota_project_id,
            default_scopes=cls.AUTH_SCOPES,
            scopes=scopes,
            default_host=cls.DEFAULT_HOST,
            **kwargs
        )

    @property
    def grpc_channel(self) -> grpc.Channel:
        """Return the channel designed to connect to this service.
        """
        return self._grpc_channel

    @property
    def delete_bucket_access_control(self) -> Callable[
            [storage.DeleteBucketAccessControlRequest],
            empty_pb2.Empty]:
        r"""Return a callable for the delete bucket access control method over gRPC.

        Permanently deletes the ACL entry for the specified
        entity on the specified bucket.

        Returns:
            Callable[[~.DeleteBucketAccessControlRequest],
                    ~.Empty]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'delete_bucket_access_control' not in self._stubs:
            self._stubs['delete_bucket_access_control'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/DeleteBucketAccessControl',
                request_serializer=storage.DeleteBucketAccessControlRequest.serialize,
                response_deserializer=empty_pb2.Empty.FromString,
            )
        return self._stubs['delete_bucket_access_control']

    @property
    def get_bucket_access_control(self) -> Callable[
            [storage.GetBucketAccessControlRequest],
            storage_resources.BucketAccessControl]:
        r"""Return a callable for the get bucket access control method over gRPC.

        Returns the ACL entry for the specified entity on the
        specified bucket.

        Returns:
            Callable[[~.GetBucketAccessControlRequest],
                    ~.BucketAccessControl]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_bucket_access_control' not in self._stubs:
            self._stubs['get_bucket_access_control'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/GetBucketAccessControl',
                request_serializer=storage.GetBucketAccessControlRequest.serialize,
                response_deserializer=storage_resources.BucketAccessControl.deserialize,
            )
        return self._stubs['get_bucket_access_control']

    @property
    def insert_bucket_access_control(self) -> Callable[
            [storage.InsertBucketAccessControlRequest],
            storage_resources.BucketAccessControl]:
        r"""Return a callable for the insert bucket access control method over gRPC.

        Creates a new ACL entry on the specified bucket.

        Returns:
            Callable[[~.InsertBucketAccessControlRequest],
                    ~.BucketAccessControl]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'insert_bucket_access_control' not in self._stubs:
            self._stubs['insert_bucket_access_control'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/InsertBucketAccessControl',
                request_serializer=storage.InsertBucketAccessControlRequest.serialize,
                response_deserializer=storage_resources.BucketAccessControl.deserialize,
            )
        return self._stubs['insert_bucket_access_control']

    @property
    def list_bucket_access_controls(self) -> Callable[
            [storage.ListBucketAccessControlsRequest],
            storage_resources.ListBucketAccessControlsResponse]:
        r"""Return a callable for the list bucket access controls method over gRPC.

        Retrieves ACL entries on the specified bucket.

        Returns:
            Callable[[~.ListBucketAccessControlsRequest],
                    ~.ListBucketAccessControlsResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_bucket_access_controls' not in self._stubs:
            self._stubs['list_bucket_access_controls'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/ListBucketAccessControls',
                request_serializer=storage.ListBucketAccessControlsRequest.serialize,
                response_deserializer=storage_resources.ListBucketAccessControlsResponse.deserialize,
            )
        return self._stubs['list_bucket_access_controls']

    @property
    def update_bucket_access_control(self) -> Callable[
            [storage.UpdateBucketAccessControlRequest],
            storage_resources.BucketAccessControl]:
        r"""Return a callable for the update bucket access control method over gRPC.

        Updates an ACL entry on the specified bucket.
        Equivalent to PatchBucketAccessControl, but all
        unspecified fields will be reset to their default
        values.

        Returns:
            Callable[[~.UpdateBucketAccessControlRequest],
                    ~.BucketAccessControl]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update_bucket_access_control' not in self._stubs:
            self._stubs['update_bucket_access_control'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/UpdateBucketAccessControl',
                request_serializer=storage.UpdateBucketAccessControlRequest.serialize,
                response_deserializer=storage_resources.BucketAccessControl.deserialize,
            )
        return self._stubs['update_bucket_access_control']

    @property
    def patch_bucket_access_control(self) -> Callable[
            [storage.PatchBucketAccessControlRequest],
            storage_resources.BucketAccessControl]:
        r"""Return a callable for the patch bucket access control method over gRPC.

        Updates an ACL entry on the specified bucket.

        Returns:
            Callable[[~.PatchBucketAccessControlRequest],
                    ~.BucketAccessControl]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'patch_bucket_access_control' not in self._stubs:
            self._stubs['patch_bucket_access_control'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/PatchBucketAccessControl',
                request_serializer=storage.PatchBucketAccessControlRequest.serialize,
                response_deserializer=storage_resources.BucketAccessControl.deserialize,
            )
        return self._stubs['patch_bucket_access_control']

    @property
    def delete_bucket(self) -> Callable[
            [storage.DeleteBucketRequest],
            empty_pb2.Empty]:
        r"""Return a callable for the delete bucket method over gRPC.

        Permanently deletes an empty bucket.

        Returns:
            Callable[[~.DeleteBucketRequest],
                    ~.Empty]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'delete_bucket' not in self._stubs:
            self._stubs['delete_bucket'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/DeleteBucket',
                request_serializer=storage.DeleteBucketRequest.serialize,
                response_deserializer=empty_pb2.Empty.FromString,
            )
        return self._stubs['delete_bucket']

    @property
    def get_bucket(self) -> Callable[
            [storage.GetBucketRequest],
            storage_resources.Bucket]:
        r"""Return a callable for the get bucket method over gRPC.

        Returns metadata for the specified bucket.

        Returns:
            Callable[[~.GetBucketRequest],
                    ~.Bucket]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_bucket' not in self._stubs:
            self._stubs['get_bucket'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/GetBucket',
                request_serializer=storage.GetBucketRequest.serialize,
                response_deserializer=storage_resources.Bucket.deserialize,
            )
        return self._stubs['get_bucket']

    @property
    def insert_bucket(self) -> Callable[
            [storage.InsertBucketRequest],
            storage_resources.Bucket]:
        r"""Return a callable for the insert bucket method over gRPC.

        Creates a new bucket.

        Returns:
            Callable[[~.InsertBucketRequest],
                    ~.Bucket]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'insert_bucket' not in self._stubs:
            self._stubs['insert_bucket'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/InsertBucket',
                request_serializer=storage.InsertBucketRequest.serialize,
                response_deserializer=storage_resources.Bucket.deserialize,
            )
        return self._stubs['insert_bucket']

    @property
    def list_channels(self) -> Callable[
            [storage.ListChannelsRequest],
            storage_resources.ListChannelsResponse]:
        r"""Return a callable for the list channels method over gRPC.

        List active object change notification channels for
        this bucket.

        Returns:
            Callable[[~.ListChannelsRequest],
                    ~.ListChannelsResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_channels' not in self._stubs:
            self._stubs['list_channels'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/ListChannels',
                request_serializer=storage.ListChannelsRequest.serialize,
                response_deserializer=storage_resources.ListChannelsResponse.deserialize,
            )
        return self._stubs['list_channels']

    @property
    def list_buckets(self) -> Callable[
            [storage.ListBucketsRequest],
            storage_resources.ListBucketsResponse]:
        r"""Return a callable for the list buckets method over gRPC.

        Retrieves a list of buckets for a given project.

        Returns:
            Callable[[~.ListBucketsRequest],
                    ~.ListBucketsResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_buckets' not in self._stubs:
            self._stubs['list_buckets'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/ListBuckets',
                request_serializer=storage.ListBucketsRequest.serialize,
                response_deserializer=storage_resources.ListBucketsResponse.deserialize,
            )
        return self._stubs['list_buckets']

    @property
    def lock_bucket_retention_policy(self) -> Callable[
            [storage.LockRetentionPolicyRequest],
            storage_resources.Bucket]:
        r"""Return a callable for the lock bucket retention policy method over gRPC.

        Locks retention policy on a bucket.

        Returns:
            Callable[[~.LockRetentionPolicyRequest],
                    ~.Bucket]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'lock_bucket_retention_policy' not in self._stubs:
            self._stubs['lock_bucket_retention_policy'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/LockBucketRetentionPolicy',
                request_serializer=storage.LockRetentionPolicyRequest.serialize,
                response_deserializer=storage_resources.Bucket.deserialize,
            )
        return self._stubs['lock_bucket_retention_policy']

    @property
    def get_bucket_iam_policy(self) -> Callable[
            [storage.GetIamPolicyRequest],
            policy_pb2.Policy]:
        r"""Return a callable for the get bucket iam policy method over gRPC.

        Gets the IAM policy for the specified bucket.

        Returns:
            Callable[[~.GetIamPolicyRequest],
                    ~.Policy]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_bucket_iam_policy' not in self._stubs:
            self._stubs['get_bucket_iam_policy'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/GetBucketIamPolicy',
                request_serializer=storage.GetIamPolicyRequest.serialize,
                response_deserializer=policy_pb2.Policy.FromString,
            )
        return self._stubs['get_bucket_iam_policy']

    @property
    def set_bucket_iam_policy(self) -> Callable[
            [storage.SetIamPolicyRequest],
            policy_pb2.Policy]:
        r"""Return a callable for the set bucket iam policy method over gRPC.

        Updates an IAM policy for the specified bucket.

        Returns:
            Callable[[~.SetIamPolicyRequest],
                    ~.Policy]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'set_bucket_iam_policy' not in self._stubs:
            self._stubs['set_bucket_iam_policy'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/SetBucketIamPolicy',
                request_serializer=storage.SetIamPolicyRequest.serialize,
                response_deserializer=policy_pb2.Policy.FromString,
            )
        return self._stubs['set_bucket_iam_policy']

    @property
    def test_bucket_iam_permissions(self) -> Callable[
            [storage.TestIamPermissionsRequest],
            iam_policy_pb2.TestIamPermissionsResponse]:
        r"""Return a callable for the test bucket iam permissions method over gRPC.

        Tests a set of permissions on the given bucket to see
        which, if any, are held by the caller.

        Returns:
            Callable[[~.TestIamPermissionsRequest],
                    ~.TestIamPermissionsResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'test_bucket_iam_permissions' not in self._stubs:
            self._stubs['test_bucket_iam_permissions'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/TestBucketIamPermissions',
                request_serializer=storage.TestIamPermissionsRequest.serialize,
                response_deserializer=iam_policy_pb2.TestIamPermissionsResponse.FromString,
            )
        return self._stubs['test_bucket_iam_permissions']

    @property
    def patch_bucket(self) -> Callable[
            [storage.PatchBucketRequest],
            storage_resources.Bucket]:
        r"""Return a callable for the patch bucket method over gRPC.

        Updates a bucket. Changes to the bucket will be
        readable immediately after writing, but configuration
        changes may take time to propagate.

        Returns:
            Callable[[~.PatchBucketRequest],
                    ~.Bucket]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'patch_bucket' not in self._stubs:
            self._stubs['patch_bucket'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/PatchBucket',
                request_serializer=storage.PatchBucketRequest.serialize,
                response_deserializer=storage_resources.Bucket.deserialize,
            )
        return self._stubs['patch_bucket']

    @property
    def update_bucket(self) -> Callable[
            [storage.UpdateBucketRequest],
            storage_resources.Bucket]:
        r"""Return a callable for the update bucket method over gRPC.

        Updates a bucket. Equivalent to PatchBucket, but
        always replaces all mutatable fields of the bucket with
        new values, reverting all unspecified fields to their
        default values.
        Like PatchBucket, Changes to the bucket will be readable
        immediately after writing, but configuration changes may
        take time to propagate.

        Returns:
            Callable[[~.UpdateBucketRequest],
                    ~.Bucket]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update_bucket' not in self._stubs:
            self._stubs['update_bucket'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/UpdateBucket',
                request_serializer=storage.UpdateBucketRequest.serialize,
                response_deserializer=storage_resources.Bucket.deserialize,
            )
        return self._stubs['update_bucket']

    @property
    def stop_channel(self) -> Callable[
            [storage.StopChannelRequest],
            empty_pb2.Empty]:
        r"""Return a callable for the stop channel method over gRPC.

        Halts "Object Change Notification" push messagages.
        See https://cloud.google.com/storage/docs/object-change-
        notification Note: this is not related to the newer
        "Notifications" resource, which are stopped using
        DeleteNotification.

        Returns:
            Callable[[~.StopChannelRequest],
                    ~.Empty]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'stop_channel' not in self._stubs:
            self._stubs['stop_channel'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/StopChannel',
                request_serializer=storage.StopChannelRequest.serialize,
                response_deserializer=empty_pb2.Empty.FromString,
            )
        return self._stubs['stop_channel']

    @property
    def delete_default_object_access_control(self) -> Callable[
            [storage.DeleteDefaultObjectAccessControlRequest],
            empty_pb2.Empty]:
        r"""Return a callable for the delete default object access
        control method over gRPC.

        Permanently deletes the default object ACL entry for
        the specified entity on the specified bucket.

        Returns:
            Callable[[~.DeleteDefaultObjectAccessControlRequest],
                    ~.Empty]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'delete_default_object_access_control' not in self._stubs:
            self._stubs['delete_default_object_access_control'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/DeleteDefaultObjectAccessControl',
                request_serializer=storage.DeleteDefaultObjectAccessControlRequest.serialize,
                response_deserializer=empty_pb2.Empty.FromString,
            )
        return self._stubs['delete_default_object_access_control']

    @property
    def get_default_object_access_control(self) -> Callable[
            [storage.GetDefaultObjectAccessControlRequest],
            storage_resources.ObjectAccessControl]:
        r"""Return a callable for the get default object access
        control method over gRPC.

        Returns the default object ACL entry for the
        specified entity on the specified bucket.

        Returns:
            Callable[[~.GetDefaultObjectAccessControlRequest],
                    ~.ObjectAccessControl]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_default_object_access_control' not in self._stubs:
            self._stubs['get_default_object_access_control'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/GetDefaultObjectAccessControl',
                request_serializer=storage.GetDefaultObjectAccessControlRequest.serialize,
                response_deserializer=storage_resources.ObjectAccessControl.deserialize,
            )
        return self._stubs['get_default_object_access_control']

    @property
    def insert_default_object_access_control(self) -> Callable[
            [storage.InsertDefaultObjectAccessControlRequest],
            storage_resources.ObjectAccessControl]:
        r"""Return a callable for the insert default object access
        control method over gRPC.

        Creates a new default object ACL entry on the
        specified bucket.

        Returns:
            Callable[[~.InsertDefaultObjectAccessControlRequest],
                    ~.ObjectAccessControl]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'insert_default_object_access_control' not in self._stubs:
            self._stubs['insert_default_object_access_control'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/InsertDefaultObjectAccessControl',
                request_serializer=storage.InsertDefaultObjectAccessControlRequest.serialize,
                response_deserializer=storage_resources.ObjectAccessControl.deserialize,
            )
        return self._stubs['insert_default_object_access_control']

    @property
    def list_default_object_access_controls(self) -> Callable[
            [storage.ListDefaultObjectAccessControlsRequest],
            storage_resources.ListObjectAccessControlsResponse]:
        r"""Return a callable for the list default object access
        controls method over gRPC.

        Retrieves default object ACL entries on the specified
        bucket.

        Returns:
            Callable[[~.ListDefaultObjectAccessControlsRequest],
                    ~.ListObjectAccessControlsResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_default_object_access_controls' not in self._stubs:
            self._stubs['list_default_object_access_controls'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/ListDefaultObjectAccessControls',
                request_serializer=storage.ListDefaultObjectAccessControlsRequest.serialize,
                response_deserializer=storage_resources.ListObjectAccessControlsResponse.deserialize,
            )
        return self._stubs['list_default_object_access_controls']

    @property
    def patch_default_object_access_control(self) -> Callable[
            [storage.PatchDefaultObjectAccessControlRequest],
            storage_resources.ObjectAccessControl]:
        r"""Return a callable for the patch default object access
        control method over gRPC.

        Updates a default object ACL entry on the specified
        bucket.

        Returns:
            Callable[[~.PatchDefaultObjectAccessControlRequest],
                    ~.ObjectAccessControl]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'patch_default_object_access_control' not in self._stubs:
            self._stubs['patch_default_object_access_control'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/PatchDefaultObjectAccessControl',
                request_serializer=storage.PatchDefaultObjectAccessControlRequest.serialize,
                response_deserializer=storage_resources.ObjectAccessControl.deserialize,
            )
        return self._stubs['patch_default_object_access_control']

    @property
    def update_default_object_access_control(self) -> Callable[
            [storage.UpdateDefaultObjectAccessControlRequest],
            storage_resources.ObjectAccessControl]:
        r"""Return a callable for the update default object access
        control method over gRPC.

        Updates a default object ACL entry on the specified
        bucket. Equivalent to PatchDefaultObjectAccessControl,
        but modifies all unspecified fields to their default
        values.

        Returns:
            Callable[[~.UpdateDefaultObjectAccessControlRequest],
                    ~.ObjectAccessControl]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update_default_object_access_control' not in self._stubs:
            self._stubs['update_default_object_access_control'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/UpdateDefaultObjectAccessControl',
                request_serializer=storage.UpdateDefaultObjectAccessControlRequest.serialize,
                response_deserializer=storage_resources.ObjectAccessControl.deserialize,
            )
        return self._stubs['update_default_object_access_control']

    @property
    def delete_notification(self) -> Callable[
            [storage.DeleteNotificationRequest],
            empty_pb2.Empty]:
        r"""Return a callable for the delete notification method over gRPC.

        Permanently deletes a notification subscription.
        Note: Older, "Object Change Notification" push
        subscriptions should be deleted using StopChannel
        instead.

        Returns:
            Callable[[~.DeleteNotificationRequest],
                    ~.Empty]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'delete_notification' not in self._stubs:
            self._stubs['delete_notification'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/DeleteNotification',
                request_serializer=storage.DeleteNotificationRequest.serialize,
                response_deserializer=empty_pb2.Empty.FromString,
            )
        return self._stubs['delete_notification']

    @property
    def get_notification(self) -> Callable[
            [storage.GetNotificationRequest],
            storage_resources.Notification]:
        r"""Return a callable for the get notification method over gRPC.

        View a notification configuration.

        Returns:
            Callable[[~.GetNotificationRequest],
                    ~.Notification]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_notification' not in self._stubs:
            self._stubs['get_notification'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/GetNotification',
                request_serializer=storage.GetNotificationRequest.serialize,
                response_deserializer=storage_resources.Notification.deserialize,
            )
        return self._stubs['get_notification']

    @property
    def insert_notification(self) -> Callable[
            [storage.InsertNotificationRequest],
            storage_resources.Notification]:
        r"""Return a callable for the insert notification method over gRPC.

        Creates a notification subscription for a given
        bucket. These notifications, when triggered, publish
        messages to the specified Cloud Pub/Sub topics.
        See https://cloud.google.com/storage/docs/pubsub-
        notifications.

        Returns:
            Callable[[~.InsertNotificationRequest],
                    ~.Notification]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'insert_notification' not in self._stubs:
            self._stubs['insert_notification'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/InsertNotification',
                request_serializer=storage.InsertNotificationRequest.serialize,
                response_deserializer=storage_resources.Notification.deserialize,
            )
        return self._stubs['insert_notification']

    @property
    def list_notifications(self) -> Callable[
            [storage.ListNotificationsRequest],
            storage_resources.ListNotificationsResponse]:
        r"""Return a callable for the list notifications method over gRPC.

        Retrieves a list of notification subscriptions for a
        given bucket.

        Returns:
            Callable[[~.ListNotificationsRequest],
                    ~.ListNotificationsResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_notifications' not in self._stubs:
            self._stubs['list_notifications'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/ListNotifications',
                request_serializer=storage.ListNotificationsRequest.serialize,
                response_deserializer=storage_resources.ListNotificationsResponse.deserialize,
            )
        return self._stubs['list_notifications']

    @property
    def delete_object_access_control(self) -> Callable[
            [storage.DeleteObjectAccessControlRequest],
            empty_pb2.Empty]:
        r"""Return a callable for the delete object access control method over gRPC.

        Permanently deletes the ACL entry for the specified
        entity on the specified object.

        Returns:
            Callable[[~.DeleteObjectAccessControlRequest],
                    ~.Empty]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'delete_object_access_control' not in self._stubs:
            self._stubs['delete_object_access_control'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/DeleteObjectAccessControl',
                request_serializer=storage.DeleteObjectAccessControlRequest.serialize,
                response_deserializer=empty_pb2.Empty.FromString,
            )
        return self._stubs['delete_object_access_control']

    @property
    def get_object_access_control(self) -> Callable[
            [storage.GetObjectAccessControlRequest],
            storage_resources.ObjectAccessControl]:
        r"""Return a callable for the get object access control method over gRPC.

        Returns the ACL entry for the specified entity on the
        specified object.

        Returns:
            Callable[[~.GetObjectAccessControlRequest],
                    ~.ObjectAccessControl]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_object_access_control' not in self._stubs:
            self._stubs['get_object_access_control'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/GetObjectAccessControl',
                request_serializer=storage.GetObjectAccessControlRequest.serialize,
                response_deserializer=storage_resources.ObjectAccessControl.deserialize,
            )
        return self._stubs['get_object_access_control']

    @property
    def insert_object_access_control(self) -> Callable[
            [storage.InsertObjectAccessControlRequest],
            storage_resources.ObjectAccessControl]:
        r"""Return a callable for the insert object access control method over gRPC.

        Creates a new ACL entry on the specified object.

        Returns:
            Callable[[~.InsertObjectAccessControlRequest],
                    ~.ObjectAccessControl]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'insert_object_access_control' not in self._stubs:
            self._stubs['insert_object_access_control'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/InsertObjectAccessControl',
                request_serializer=storage.InsertObjectAccessControlRequest.serialize,
                response_deserializer=storage_resources.ObjectAccessControl.deserialize,
            )
        return self._stubs['insert_object_access_control']

    @property
    def list_object_access_controls(self) -> Callable[
            [storage.ListObjectAccessControlsRequest],
            storage_resources.ListObjectAccessControlsResponse]:
        r"""Return a callable for the list object access controls method over gRPC.

        Retrieves ACL entries on the specified object.

        Returns:
            Callable[[~.ListObjectAccessControlsRequest],
                    ~.ListObjectAccessControlsResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_object_access_controls' not in self._stubs:
            self._stubs['list_object_access_controls'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/ListObjectAccessControls',
                request_serializer=storage.ListObjectAccessControlsRequest.serialize,
                response_deserializer=storage_resources.ListObjectAccessControlsResponse.deserialize,
            )
        return self._stubs['list_object_access_controls']

    @property
    def patch_object_access_control(self) -> Callable[
            [storage.PatchObjectAccessControlRequest],
            storage_resources.ObjectAccessControl]:
        r"""Return a callable for the patch object access control method over gRPC.

        Patches an ACL entry on the specified object. Patch is similar
        to update, but only applies or appends the specified fields in
        the object_access_control object. Other fields are unaffected.

        Returns:
            Callable[[~.PatchObjectAccessControlRequest],
                    ~.ObjectAccessControl]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'patch_object_access_control' not in self._stubs:
            self._stubs['patch_object_access_control'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/PatchObjectAccessControl',
                request_serializer=storage.PatchObjectAccessControlRequest.serialize,
                response_deserializer=storage_resources.ObjectAccessControl.deserialize,
            )
        return self._stubs['patch_object_access_control']

    @property
    def update_object_access_control(self) -> Callable[
            [storage.UpdateObjectAccessControlRequest],
            storage_resources.ObjectAccessControl]:
        r"""Return a callable for the update object access control method over gRPC.

        Updates an ACL entry on the specified object.

        Returns:
            Callable[[~.UpdateObjectAccessControlRequest],
                    ~.ObjectAccessControl]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update_object_access_control' not in self._stubs:
            self._stubs['update_object_access_control'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/UpdateObjectAccessControl',
                request_serializer=storage.UpdateObjectAccessControlRequest.serialize,
                response_deserializer=storage_resources.ObjectAccessControl.deserialize,
            )
        return self._stubs['update_object_access_control']

    @property
    def compose_object(self) -> Callable[
            [storage.ComposeObjectRequest],
            storage_resources.Object]:
        r"""Return a callable for the compose object method over gRPC.

        Concatenates a list of existing objects into a new
        object in the same bucket.

        Returns:
            Callable[[~.ComposeObjectRequest],
                    ~.Object]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'compose_object' not in self._stubs:
            self._stubs['compose_object'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/ComposeObject',
                request_serializer=storage.ComposeObjectRequest.serialize,
                response_deserializer=storage_resources.Object.deserialize,
            )
        return self._stubs['compose_object']

    @property
    def copy_object(self) -> Callable[
            [storage.CopyObjectRequest],
            storage_resources.Object]:
        r"""Return a callable for the copy object method over gRPC.

        Copies a source object to a destination object.
        Optionally overrides metadata.

        Returns:
            Callable[[~.CopyObjectRequest],
                    ~.Object]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'copy_object' not in self._stubs:
            self._stubs['copy_object'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/CopyObject',
                request_serializer=storage.CopyObjectRequest.serialize,
                response_deserializer=storage_resources.Object.deserialize,
            )
        return self._stubs['copy_object']

    @property
    def delete_object(self) -> Callable[
            [storage.DeleteObjectRequest],
            empty_pb2.Empty]:
        r"""Return a callable for the delete object method over gRPC.

        Deletes an object and its metadata. Deletions are permanent if
        versioning is not enabled for the bucket, or if the
        ``generation`` parameter is used.

        Returns:
            Callable[[~.DeleteObjectRequest],
                    ~.Empty]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'delete_object' not in self._stubs:
            self._stubs['delete_object'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/DeleteObject',
                request_serializer=storage.DeleteObjectRequest.serialize,
                response_deserializer=empty_pb2.Empty.FromString,
            )
        return self._stubs['delete_object']

    @property
    def get_object(self) -> Callable[
            [storage.GetObjectRequest],
            storage_resources.Object]:
        r"""Return a callable for the get object method over gRPC.

        Retrieves an object's metadata.

        Returns:
            Callable[[~.GetObjectRequest],
                    ~.Object]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_object' not in self._stubs:
            self._stubs['get_object'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/GetObject',
                request_serializer=storage.GetObjectRequest.serialize,
                response_deserializer=storage_resources.Object.deserialize,
            )
        return self._stubs['get_object']

    @property
    def get_object_media(self) -> Callable[
            [storage.GetObjectMediaRequest],
            storage.GetObjectMediaResponse]:
        r"""Return a callable for the get object media method over gRPC.

        Reads an object's data.

        Returns:
            Callable[[~.GetObjectMediaRequest],
                    ~.GetObjectMediaResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_object_media' not in self._stubs:
            self._stubs['get_object_media'] = self.grpc_channel.unary_stream(
                '/google.storage.v1.Storage/GetObjectMedia',
                request_serializer=storage.GetObjectMediaRequest.serialize,
                response_deserializer=storage.GetObjectMediaResponse.deserialize,
            )
        return self._stubs['get_object_media']

    @property
    def insert_object(self) -> Callable[
            [storage.InsertObjectRequest],
            storage_resources.Object]:
        r"""Return a callable for the insert object method over gRPC.

        Stores a new object and metadata.

        An object can be written either in a single message stream or in
        a resumable sequence of message streams. To write using a single
        stream, the client should include in the first message of the
        stream an ``InsertObjectSpec`` describing the destination
        bucket, object, and any preconditions. Additionally, the final
        message must set 'finish_write' to true, or else it is an error.

        For a resumable write, the client should instead call
        ``StartResumableWrite()`` and provide that method an
        ``InsertObjectSpec.`` They should then attach the returned
        ``upload_id`` to the first message of each following call to
        ``Insert``. If there is an error or the connection is broken
        during the resumable ``Insert()``, the client should check the
        status of the ``Insert()`` by calling ``QueryWriteStatus()`` and
        continue writing from the returned ``committed_size``. This may
        be less than the amount of data the client previously sent.

        The service will not view the object as complete until the
        client has sent an ``Insert`` with ``finish_write`` set to
        ``true``. Sending any requests on a stream after sending a
        request with ``finish_write`` set to ``true`` will cause an
        error. The client **should** check the ``Object`` it receives to
        determine how much data the service was able to commit and
        whether the service views the object as complete.

        Returns:
            Callable[[~.InsertObjectRequest],
                    ~.Object]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'insert_object' not in self._stubs:
            self._stubs['insert_object'] = self.grpc_channel.stream_unary(
                '/google.storage.v1.Storage/InsertObject',
                request_serializer=storage.InsertObjectRequest.serialize,
                response_deserializer=storage_resources.Object.deserialize,
            )
        return self._stubs['insert_object']

    @property
    def list_objects(self) -> Callable[
            [storage.ListObjectsRequest],
            storage_resources.ListObjectsResponse]:
        r"""Return a callable for the list objects method over gRPC.

        Retrieves a list of objects matching the criteria.

        Returns:
            Callable[[~.ListObjectsRequest],
                    ~.ListObjectsResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_objects' not in self._stubs:
            self._stubs['list_objects'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/ListObjects',
                request_serializer=storage.ListObjectsRequest.serialize,
                response_deserializer=storage_resources.ListObjectsResponse.deserialize,
            )
        return self._stubs['list_objects']

    @property
    def rewrite_object(self) -> Callable[
            [storage.RewriteObjectRequest],
            storage.RewriteResponse]:
        r"""Return a callable for the rewrite object method over gRPC.

        Rewrites a source object to a destination object.
        Optionally overrides metadata.

        Returns:
            Callable[[~.RewriteObjectRequest],
                    ~.RewriteResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'rewrite_object' not in self._stubs:
            self._stubs['rewrite_object'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/RewriteObject',
                request_serializer=storage.RewriteObjectRequest.serialize,
                response_deserializer=storage.RewriteResponse.deserialize,
            )
        return self._stubs['rewrite_object']

    @property
    def start_resumable_write(self) -> Callable[
            [storage.StartResumableWriteRequest],
            storage.StartResumableWriteResponse]:
        r"""Return a callable for the start resumable write method over gRPC.

        Starts a resumable write. How long the write
        operation remains valid, and what happens when the write
        operation becomes invalid, are service-dependent.

        Returns:
            Callable[[~.StartResumableWriteRequest],
                    ~.StartResumableWriteResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'start_resumable_write' not in self._stubs:
            self._stubs['start_resumable_write'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/StartResumableWrite',
                request_serializer=storage.StartResumableWriteRequest.serialize,
                response_deserializer=storage.StartResumableWriteResponse.deserialize,
            )
        return self._stubs['start_resumable_write']

    @property
    def query_write_status(self) -> Callable[
            [storage.QueryWriteStatusRequest],
            storage.QueryWriteStatusResponse]:
        r"""Return a callable for the query write status method over gRPC.

        Determines the ``committed_size`` for an object that is being
        written, which can then be used as the ``write_offset`` for the
        next ``Write()`` call.

        If the object does not exist (i.e., the object has been deleted,
        or the first ``Write()`` has not yet reached the service), this
        method returns the error ``NOT_FOUND``.

        The client **may** call ``QueryWriteStatus()`` at any time to
        determine how much data has been processed for this object. This
        is useful if the client is buffering data and needs to know
        which data can be safely evicted. For any sequence of
        ``QueryWriteStatus()`` calls for a given object name, the
        sequence of returned ``committed_size`` values will be
        non-decreasing.

        Returns:
            Callable[[~.QueryWriteStatusRequest],
                    ~.QueryWriteStatusResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'query_write_status' not in self._stubs:
            self._stubs['query_write_status'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/QueryWriteStatus',
                request_serializer=storage.QueryWriteStatusRequest.serialize,
                response_deserializer=storage.QueryWriteStatusResponse.deserialize,
            )
        return self._stubs['query_write_status']

    @property
    def patch_object(self) -> Callable[
            [storage.PatchObjectRequest],
            storage_resources.Object]:
        r"""Return a callable for the patch object method over gRPC.

        Updates an object's metadata.

        Returns:
            Callable[[~.PatchObjectRequest],
                    ~.Object]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'patch_object' not in self._stubs:
            self._stubs['patch_object'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/PatchObject',
                request_serializer=storage.PatchObjectRequest.serialize,
                response_deserializer=storage_resources.Object.deserialize,
            )
        return self._stubs['patch_object']

    @property
    def update_object(self) -> Callable[
            [storage.UpdateObjectRequest],
            storage_resources.Object]:
        r"""Return a callable for the update object method over gRPC.

        Updates an object's metadata. Equivalent to
        PatchObject, but always replaces all mutatable fields of
        the bucket with new values, reverting all unspecified
        fields to their default values.

        Returns:
            Callable[[~.UpdateObjectRequest],
                    ~.Object]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update_object' not in self._stubs:
            self._stubs['update_object'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/UpdateObject',
                request_serializer=storage.UpdateObjectRequest.serialize,
                response_deserializer=storage_resources.Object.deserialize,
            )
        return self._stubs['update_object']

    @property
    def get_object_iam_policy(self) -> Callable[
            [storage.GetIamPolicyRequest],
            policy_pb2.Policy]:
        r"""Return a callable for the get object iam policy method over gRPC.

        Gets the IAM policy for the specified object.

        Returns:
            Callable[[~.GetIamPolicyRequest],
                    ~.Policy]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_object_iam_policy' not in self._stubs:
            self._stubs['get_object_iam_policy'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/GetObjectIamPolicy',
                request_serializer=storage.GetIamPolicyRequest.serialize,
                response_deserializer=policy_pb2.Policy.FromString,
            )
        return self._stubs['get_object_iam_policy']

    @property
    def set_object_iam_policy(self) -> Callable[
            [storage.SetIamPolicyRequest],
            policy_pb2.Policy]:
        r"""Return a callable for the set object iam policy method over gRPC.

        Updates an IAM policy for the specified object.

        Returns:
            Callable[[~.SetIamPolicyRequest],
                    ~.Policy]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'set_object_iam_policy' not in self._stubs:
            self._stubs['set_object_iam_policy'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/SetObjectIamPolicy',
                request_serializer=storage.SetIamPolicyRequest.serialize,
                response_deserializer=policy_pb2.Policy.FromString,
            )
        return self._stubs['set_object_iam_policy']

    @property
    def test_object_iam_permissions(self) -> Callable[
            [storage.TestIamPermissionsRequest],
            iam_policy_pb2.TestIamPermissionsResponse]:
        r"""Return a callable for the test object iam permissions method over gRPC.

        Tests a set of permissions on the given object to see
        which, if any, are held by the caller.

        Returns:
            Callable[[~.TestIamPermissionsRequest],
                    ~.TestIamPermissionsResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'test_object_iam_permissions' not in self._stubs:
            self._stubs['test_object_iam_permissions'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/TestObjectIamPermissions',
                request_serializer=storage.TestIamPermissionsRequest.serialize,
                response_deserializer=iam_policy_pb2.TestIamPermissionsResponse.FromString,
            )
        return self._stubs['test_object_iam_permissions']

    @property
    def watch_all_objects(self) -> Callable[
            [storage.WatchAllObjectsRequest],
            storage_resources.Channel]:
        r"""Return a callable for the watch all objects method over gRPC.

        Watch for changes on all objects in a bucket.

        Returns:
            Callable[[~.WatchAllObjectsRequest],
                    ~.Channel]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'watch_all_objects' not in self._stubs:
            self._stubs['watch_all_objects'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/WatchAllObjects',
                request_serializer=storage.WatchAllObjectsRequest.serialize,
                response_deserializer=storage_resources.Channel.deserialize,
            )
        return self._stubs['watch_all_objects']

    @property
    def get_service_account(self) -> Callable[
            [storage.GetProjectServiceAccountRequest],
            storage_resources.ServiceAccount]:
        r"""Return a callable for the get service account method over gRPC.

        Retrieves the name of a project's Google Cloud
        Storage service account.

        Returns:
            Callable[[~.GetProjectServiceAccountRequest],
                    ~.ServiceAccount]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_service_account' not in self._stubs:
            self._stubs['get_service_account'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/GetServiceAccount',
                request_serializer=storage.GetProjectServiceAccountRequest.serialize,
                response_deserializer=storage_resources.ServiceAccount.deserialize,
            )
        return self._stubs['get_service_account']

    @property
    def create_hmac_key(self) -> Callable[
            [storage.CreateHmacKeyRequest],
            storage.CreateHmacKeyResponse]:
        r"""Return a callable for the create hmac key method over gRPC.

        Creates a new HMAC key for the given service account.

        Returns:
            Callable[[~.CreateHmacKeyRequest],
                    ~.CreateHmacKeyResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'create_hmac_key' not in self._stubs:
            self._stubs['create_hmac_key'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/CreateHmacKey',
                request_serializer=storage.CreateHmacKeyRequest.serialize,
                response_deserializer=storage.CreateHmacKeyResponse.deserialize,
            )
        return self._stubs['create_hmac_key']

    @property
    def delete_hmac_key(self) -> Callable[
            [storage.DeleteHmacKeyRequest],
            empty_pb2.Empty]:
        r"""Return a callable for the delete hmac key method over gRPC.

        Deletes a given HMAC key.  Key must be in an INACTIVE
        state.

        Returns:
            Callable[[~.DeleteHmacKeyRequest],
                    ~.Empty]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'delete_hmac_key' not in self._stubs:
            self._stubs['delete_hmac_key'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/DeleteHmacKey',
                request_serializer=storage.DeleteHmacKeyRequest.serialize,
                response_deserializer=empty_pb2.Empty.FromString,
            )
        return self._stubs['delete_hmac_key']

    @property
    def get_hmac_key(self) -> Callable[
            [storage.GetHmacKeyRequest],
            storage_resources.HmacKeyMetadata]:
        r"""Return a callable for the get hmac key method over gRPC.

        Gets an existing HMAC key metadata for the given id.

        Returns:
            Callable[[~.GetHmacKeyRequest],
                    ~.HmacKeyMetadata]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_hmac_key' not in self._stubs:
            self._stubs['get_hmac_key'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/GetHmacKey',
                request_serializer=storage.GetHmacKeyRequest.serialize,
                response_deserializer=storage_resources.HmacKeyMetadata.deserialize,
            )
        return self._stubs['get_hmac_key']

    @property
    def list_hmac_keys(self) -> Callable[
            [storage.ListHmacKeysRequest],
            storage.ListHmacKeysResponse]:
        r"""Return a callable for the list hmac keys method over gRPC.

        Lists HMAC keys under a given project with the
        additional filters provided.

        Returns:
            Callable[[~.ListHmacKeysRequest],
                    ~.ListHmacKeysResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_hmac_keys' not in self._stubs:
            self._stubs['list_hmac_keys'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/ListHmacKeys',
                request_serializer=storage.ListHmacKeysRequest.serialize,
                response_deserializer=storage.ListHmacKeysResponse.deserialize,
            )
        return self._stubs['list_hmac_keys']

    @property
    def update_hmac_key(self) -> Callable[
            [storage.UpdateHmacKeyRequest],
            storage_resources.HmacKeyMetadata]:
        r"""Return a callable for the update hmac key method over gRPC.

        Updates a given HMAC key state between ACTIVE and
        INACTIVE.

        Returns:
            Callable[[~.UpdateHmacKeyRequest],
                    ~.HmacKeyMetadata]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update_hmac_key' not in self._stubs:
            self._stubs['update_hmac_key'] = self.grpc_channel.unary_unary(
                '/google.storage.v1.Storage/UpdateHmacKey',
                request_serializer=storage.UpdateHmacKeyRequest.serialize,
                response_deserializer=storage_resources.HmacKeyMetadata.deserialize,
            )
        return self._stubs['update_hmac_key']


__all__ = (
    'StorageGrpcTransport',
)
