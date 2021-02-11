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
from typing import Awaitable, Callable, Dict, Optional, Sequence, Tuple

from google.api_core import gapic_v1                   # type: ignore
from google.api_core import grpc_helpers_async         # type: ignore
from google.api_core import operations_v1              # type: ignore
from google import auth                                # type: ignore
from google.auth import credentials                    # type: ignore
from google.auth.transport.grpc import SslCredentials  # type: ignore

import grpc                        # type: ignore
from grpc.experimental import aio  # type: ignore

from google.cloud.bigtable_admin_v2.types import bigtable_instance_admin
from google.cloud.bigtable_admin_v2.types import instance
from google.iam.v1 import iam_policy_pb2 as iam_policy  # type: ignore
from google.iam.v1 import policy_pb2 as policy  # type: ignore
from google.longrunning import operations_pb2 as operations  # type: ignore
from google.protobuf import empty_pb2 as empty  # type: ignore

from .base import BigtableInstanceAdminTransport, DEFAULT_CLIENT_INFO
from .grpc import BigtableInstanceAdminGrpcTransport


class BigtableInstanceAdminGrpcAsyncIOTransport(BigtableInstanceAdminTransport):
    """gRPC AsyncIO backend transport for BigtableInstanceAdmin.

    Service for creating, configuring, and deleting Cloud
    Bigtable Instances and Clusters. Provides access to the Instance
    and Cluster schemas only, not the tables' metadata or data
    stored in those tables.

    This class defines the same methods as the primary client, so the
    primary client can load the underlying transport implementation
    and call it.

    It sends protocol buffers over the wire using gRPC (which is built on
    top of HTTP/2); the ``grpcio`` package must be installed.
    """

    _grpc_channel: aio.Channel
    _stubs: Dict[str, Callable] = {}

    @classmethod
    def create_channel(cls,
                       host: str = 'bigtableadmin.googleapis.com',
                       credentials: credentials.Credentials = None,
                       credentials_file: Optional[str] = None,
                       scopes: Optional[Sequence[str]] = None,
                       quota_project_id: Optional[str] = None,
                       **kwargs) -> aio.Channel:
        """Create and return a gRPC AsyncIO channel object.
        Args:
            address (Optional[str]): The host for the channel to use.
            credentials (Optional[~.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify this application to the service. If
                none are specified, the client will attempt to ascertain
                the credentials from the environment.
            credentials_file (Optional[str]): A file with credentials that can
                be loaded with :func:`google.auth.load_credentials_from_file`.
                This argument is ignored if ``channel`` is provided.
            scopes (Optional[Sequence[str]]): A optional list of scopes needed for this
                service. These are only used when credentials are not specified and
                are passed to :func:`google.auth.default`.
            quota_project_id (Optional[str]): An optional project to use for billing
                and quota.
            kwargs (Optional[dict]): Keyword arguments, which are passed to the
                channel creation.
        Returns:
            aio.Channel: A gRPC AsyncIO channel object.
        """
        scopes = scopes or cls.AUTH_SCOPES
        return grpc_helpers_async.create_channel(
            host,
            credentials=credentials,
            credentials_file=credentials_file,
            scopes=scopes,
            quota_project_id=quota_project_id,
            **kwargs
        )

    def __init__(self, *,
            host: str = 'bigtableadmin.googleapis.com',
            credentials: credentials.Credentials = None,
            credentials_file: Optional[str] = None,
            scopes: Optional[Sequence[str]] = None,
            channel: aio.Channel = None,
            api_mtls_endpoint: str = None,
            client_cert_source: Callable[[], Tuple[bytes, bytes]] = None,
            ssl_channel_credentials: grpc.ChannelCredentials = None,
            client_cert_source_for_mtls: Callable[[], Tuple[bytes, bytes]] = None,
            quota_project_id=None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiate the transport.

        Args:
            host (Optional[str]): The hostname to connect to.
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
                This argument is ignored if ``channel`` is provided.
            credentials_file (Optional[str]): A file with credentials that can
                be loaded with :func:`google.auth.load_credentials_from_file`.
                This argument is ignored if ``channel`` is provided.
            scopes (Optional[Sequence[str]]): A optional list of scopes needed for this
                service. These are only used when credentials are not specified and
                are passed to :func:`google.auth.default`.
            channel (Optional[aio.Channel]): A ``Channel`` instance through
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
            google.auth.exceptions.MutualTlsChannelError: If mutual TLS transport
              creation failed for any reason.
          google.api_core.exceptions.DuplicateCredentialArgs: If both ``credentials``
              and ``credentials_file`` are passed.
        """
        self._ssl_channel_credentials = ssl_channel_credentials

        if api_mtls_endpoint:
            warnings.warn("api_mtls_endpoint is deprecated", DeprecationWarning)
        if client_cert_source:
            warnings.warn("client_cert_source is deprecated", DeprecationWarning)

        if channel:
            # Sanity check: Ensure that channel and credentials are not both
            # provided.
            credentials = False

            # If a channel was explicitly provided, set it.
            self._grpc_channel = channel
            self._ssl_channel_credentials = None
        elif api_mtls_endpoint:
            host = api_mtls_endpoint if ":" in api_mtls_endpoint else api_mtls_endpoint + ":443"

            if credentials is None:
                credentials, _ = auth.default(scopes=self.AUTH_SCOPES, quota_project_id=quota_project_id)

            # Create SSL credentials with client_cert_source or application
            # default SSL credentials.
            if client_cert_source:
                cert, key = client_cert_source()
                ssl_credentials = grpc.ssl_channel_credentials(
                    certificate_chain=cert, private_key=key
                )
            else:
                ssl_credentials = SslCredentials().ssl_credentials

            # create a new channel. The provided one is ignored.
            self._grpc_channel = type(self).create_channel(
                host,
                credentials=credentials,
                credentials_file=credentials_file,
                ssl_credentials=ssl_credentials,
                scopes=scopes or self.AUTH_SCOPES,
                quota_project_id=quota_project_id,
                options=[
                    ("grpc.max_send_message_length", -1),
                    ("grpc.max_receive_message_length", -1),
                ],
            )
            self._ssl_channel_credentials = ssl_credentials
        else:
            host = host if ":" in host else host + ":443"

            if credentials is None:
                credentials, _ = auth.default(scopes=self.AUTH_SCOPES, quota_project_id=quota_project_id)

            if client_cert_source_for_mtls and not ssl_channel_credentials:
                cert, key = client_cert_source_for_mtls()
                self._ssl_channel_credentials = grpc.ssl_channel_credentials(
                    certificate_chain=cert, private_key=key
                )

            # create a new channel. The provided one is ignored.
            self._grpc_channel = type(self).create_channel(
                host,
                credentials=credentials,
                credentials_file=credentials_file,
                ssl_credentials=self._ssl_channel_credentials,
                scopes=scopes or self.AUTH_SCOPES,
                quota_project_id=quota_project_id,
                options=[
                    ("grpc.max_send_message_length", -1),
                    ("grpc.max_receive_message_length", -1),
                ],
            )

        # Run the base constructor.
        super().__init__(
            host=host,
            credentials=credentials,
            credentials_file=credentials_file,
            scopes=scopes or self.AUTH_SCOPES,
            quota_project_id=quota_project_id,
            client_info=client_info,
        )

        self._stubs = {}
        self._operations_client = None

    @property
    def grpc_channel(self) -> aio.Channel:
        """Create the channel designed to connect to this service.

        This property caches on the instance; repeated calls return
        the same channel.
        """
        # Return the channel from cache.
        return self._grpc_channel

    @property
    def operations_client(self) -> operations_v1.OperationsAsyncClient:
        """Create the client designed to process long-running operations.

        This property caches on the instance; repeated calls return the same
        client.
        """
        # Sanity check: Only create a new client if we do not already have one.
        if self._operations_client is None:
            self._operations_client = operations_v1.OperationsAsyncClient(
                self.grpc_channel
            )

        # Return the client from cache.
        return self._operations_client

    @property
    def create_instance(self) -> Callable[
            [bigtable_instance_admin.CreateInstanceRequest],
            Awaitable[operations.Operation]]:
        r"""Return a callable for the create instance method over gRPC.

        Create an instance within a project.

        Returns:
            Callable[[~.CreateInstanceRequest],
                    Awaitable[~.Operation]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'create_instance' not in self._stubs:
            self._stubs['create_instance'] = self.grpc_channel.unary_unary(
                '/google.bigtable.admin.v2.BigtableInstanceAdmin/CreateInstance',
                request_serializer=bigtable_instance_admin.CreateInstanceRequest.serialize,
                response_deserializer=operations.Operation.FromString,
            )
        return self._stubs['create_instance']

    @property
    def get_instance(self) -> Callable[
            [bigtable_instance_admin.GetInstanceRequest],
            Awaitable[instance.Instance]]:
        r"""Return a callable for the get instance method over gRPC.

        Gets information about an instance.

        Returns:
            Callable[[~.GetInstanceRequest],
                    Awaitable[~.Instance]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_instance' not in self._stubs:
            self._stubs['get_instance'] = self.grpc_channel.unary_unary(
                '/google.bigtable.admin.v2.BigtableInstanceAdmin/GetInstance',
                request_serializer=bigtable_instance_admin.GetInstanceRequest.serialize,
                response_deserializer=instance.Instance.deserialize,
            )
        return self._stubs['get_instance']

    @property
    def list_instances(self) -> Callable[
            [bigtable_instance_admin.ListInstancesRequest],
            Awaitable[bigtable_instance_admin.ListInstancesResponse]]:
        r"""Return a callable for the list instances method over gRPC.

        Lists information about instances in a project.

        Returns:
            Callable[[~.ListInstancesRequest],
                    Awaitable[~.ListInstancesResponse]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_instances' not in self._stubs:
            self._stubs['list_instances'] = self.grpc_channel.unary_unary(
                '/google.bigtable.admin.v2.BigtableInstanceAdmin/ListInstances',
                request_serializer=bigtable_instance_admin.ListInstancesRequest.serialize,
                response_deserializer=bigtable_instance_admin.ListInstancesResponse.deserialize,
            )
        return self._stubs['list_instances']

    @property
    def update_instance(self) -> Callable[
            [instance.Instance],
            Awaitable[instance.Instance]]:
        r"""Return a callable for the update instance method over gRPC.

        Updates an instance within a project. This method
        updates only the display name and type for an Instance.
        To update other Instance properties, such as labels, use
        PartialUpdateInstance.

        Returns:
            Callable[[~.Instance],
                    Awaitable[~.Instance]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update_instance' not in self._stubs:
            self._stubs['update_instance'] = self.grpc_channel.unary_unary(
                '/google.bigtable.admin.v2.BigtableInstanceAdmin/UpdateInstance',
                request_serializer=instance.Instance.serialize,
                response_deserializer=instance.Instance.deserialize,
            )
        return self._stubs['update_instance']

    @property
    def partial_update_instance(self) -> Callable[
            [bigtable_instance_admin.PartialUpdateInstanceRequest],
            Awaitable[operations.Operation]]:
        r"""Return a callable for the partial update instance method over gRPC.

        Partially updates an instance within a project. This
        method can modify all fields of an Instance and is the
        preferred way to update an Instance.

        Returns:
            Callable[[~.PartialUpdateInstanceRequest],
                    Awaitable[~.Operation]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'partial_update_instance' not in self._stubs:
            self._stubs['partial_update_instance'] = self.grpc_channel.unary_unary(
                '/google.bigtable.admin.v2.BigtableInstanceAdmin/PartialUpdateInstance',
                request_serializer=bigtable_instance_admin.PartialUpdateInstanceRequest.serialize,
                response_deserializer=operations.Operation.FromString,
            )
        return self._stubs['partial_update_instance']

    @property
    def delete_instance(self) -> Callable[
            [bigtable_instance_admin.DeleteInstanceRequest],
            Awaitable[empty.Empty]]:
        r"""Return a callable for the delete instance method over gRPC.

        Delete an instance from a project.

        Returns:
            Callable[[~.DeleteInstanceRequest],
                    Awaitable[~.Empty]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'delete_instance' not in self._stubs:
            self._stubs['delete_instance'] = self.grpc_channel.unary_unary(
                '/google.bigtable.admin.v2.BigtableInstanceAdmin/DeleteInstance',
                request_serializer=bigtable_instance_admin.DeleteInstanceRequest.serialize,
                response_deserializer=empty.Empty.FromString,
            )
        return self._stubs['delete_instance']

    @property
    def create_cluster(self) -> Callable[
            [bigtable_instance_admin.CreateClusterRequest],
            Awaitable[operations.Operation]]:
        r"""Return a callable for the create cluster method over gRPC.

        Creates a cluster within an instance.

        Returns:
            Callable[[~.CreateClusterRequest],
                    Awaitable[~.Operation]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'create_cluster' not in self._stubs:
            self._stubs['create_cluster'] = self.grpc_channel.unary_unary(
                '/google.bigtable.admin.v2.BigtableInstanceAdmin/CreateCluster',
                request_serializer=bigtable_instance_admin.CreateClusterRequest.serialize,
                response_deserializer=operations.Operation.FromString,
            )
        return self._stubs['create_cluster']

    @property
    def get_cluster(self) -> Callable[
            [bigtable_instance_admin.GetClusterRequest],
            Awaitable[instance.Cluster]]:
        r"""Return a callable for the get cluster method over gRPC.

        Gets information about a cluster.

        Returns:
            Callable[[~.GetClusterRequest],
                    Awaitable[~.Cluster]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_cluster' not in self._stubs:
            self._stubs['get_cluster'] = self.grpc_channel.unary_unary(
                '/google.bigtable.admin.v2.BigtableInstanceAdmin/GetCluster',
                request_serializer=bigtable_instance_admin.GetClusterRequest.serialize,
                response_deserializer=instance.Cluster.deserialize,
            )
        return self._stubs['get_cluster']

    @property
    def list_clusters(self) -> Callable[
            [bigtable_instance_admin.ListClustersRequest],
            Awaitable[bigtable_instance_admin.ListClustersResponse]]:
        r"""Return a callable for the list clusters method over gRPC.

        Lists information about clusters in an instance.

        Returns:
            Callable[[~.ListClustersRequest],
                    Awaitable[~.ListClustersResponse]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_clusters' not in self._stubs:
            self._stubs['list_clusters'] = self.grpc_channel.unary_unary(
                '/google.bigtable.admin.v2.BigtableInstanceAdmin/ListClusters',
                request_serializer=bigtable_instance_admin.ListClustersRequest.serialize,
                response_deserializer=bigtable_instance_admin.ListClustersResponse.deserialize,
            )
        return self._stubs['list_clusters']

    @property
    def update_cluster(self) -> Callable[
            [instance.Cluster],
            Awaitable[operations.Operation]]:
        r"""Return a callable for the update cluster method over gRPC.

        Updates a cluster within an instance.

        Returns:
            Callable[[~.Cluster],
                    Awaitable[~.Operation]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update_cluster' not in self._stubs:
            self._stubs['update_cluster'] = self.grpc_channel.unary_unary(
                '/google.bigtable.admin.v2.BigtableInstanceAdmin/UpdateCluster',
                request_serializer=instance.Cluster.serialize,
                response_deserializer=operations.Operation.FromString,
            )
        return self._stubs['update_cluster']

    @property
    def delete_cluster(self) -> Callable[
            [bigtable_instance_admin.DeleteClusterRequest],
            Awaitable[empty.Empty]]:
        r"""Return a callable for the delete cluster method over gRPC.

        Deletes a cluster from an instance.

        Returns:
            Callable[[~.DeleteClusterRequest],
                    Awaitable[~.Empty]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'delete_cluster' not in self._stubs:
            self._stubs['delete_cluster'] = self.grpc_channel.unary_unary(
                '/google.bigtable.admin.v2.BigtableInstanceAdmin/DeleteCluster',
                request_serializer=bigtable_instance_admin.DeleteClusterRequest.serialize,
                response_deserializer=empty.Empty.FromString,
            )
        return self._stubs['delete_cluster']

    @property
    def create_app_profile(self) -> Callable[
            [bigtable_instance_admin.CreateAppProfileRequest],
            Awaitable[instance.AppProfile]]:
        r"""Return a callable for the create app profile method over gRPC.

        Creates an app profile within an instance.

        Returns:
            Callable[[~.CreateAppProfileRequest],
                    Awaitable[~.AppProfile]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'create_app_profile' not in self._stubs:
            self._stubs['create_app_profile'] = self.grpc_channel.unary_unary(
                '/google.bigtable.admin.v2.BigtableInstanceAdmin/CreateAppProfile',
                request_serializer=bigtable_instance_admin.CreateAppProfileRequest.serialize,
                response_deserializer=instance.AppProfile.deserialize,
            )
        return self._stubs['create_app_profile']

    @property
    def get_app_profile(self) -> Callable[
            [bigtable_instance_admin.GetAppProfileRequest],
            Awaitable[instance.AppProfile]]:
        r"""Return a callable for the get app profile method over gRPC.

        Gets information about an app profile.

        Returns:
            Callable[[~.GetAppProfileRequest],
                    Awaitable[~.AppProfile]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_app_profile' not in self._stubs:
            self._stubs['get_app_profile'] = self.grpc_channel.unary_unary(
                '/google.bigtable.admin.v2.BigtableInstanceAdmin/GetAppProfile',
                request_serializer=bigtable_instance_admin.GetAppProfileRequest.serialize,
                response_deserializer=instance.AppProfile.deserialize,
            )
        return self._stubs['get_app_profile']

    @property
    def list_app_profiles(self) -> Callable[
            [bigtable_instance_admin.ListAppProfilesRequest],
            Awaitable[bigtable_instance_admin.ListAppProfilesResponse]]:
        r"""Return a callable for the list app profiles method over gRPC.

        Lists information about app profiles in an instance.

        Returns:
            Callable[[~.ListAppProfilesRequest],
                    Awaitable[~.ListAppProfilesResponse]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_app_profiles' not in self._stubs:
            self._stubs['list_app_profiles'] = self.grpc_channel.unary_unary(
                '/google.bigtable.admin.v2.BigtableInstanceAdmin/ListAppProfiles',
                request_serializer=bigtable_instance_admin.ListAppProfilesRequest.serialize,
                response_deserializer=bigtable_instance_admin.ListAppProfilesResponse.deserialize,
            )
        return self._stubs['list_app_profiles']

    @property
    def update_app_profile(self) -> Callable[
            [bigtable_instance_admin.UpdateAppProfileRequest],
            Awaitable[operations.Operation]]:
        r"""Return a callable for the update app profile method over gRPC.

        Updates an app profile within an instance.

        Returns:
            Callable[[~.UpdateAppProfileRequest],
                    Awaitable[~.Operation]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update_app_profile' not in self._stubs:
            self._stubs['update_app_profile'] = self.grpc_channel.unary_unary(
                '/google.bigtable.admin.v2.BigtableInstanceAdmin/UpdateAppProfile',
                request_serializer=bigtable_instance_admin.UpdateAppProfileRequest.serialize,
                response_deserializer=operations.Operation.FromString,
            )
        return self._stubs['update_app_profile']

    @property
    def delete_app_profile(self) -> Callable[
            [bigtable_instance_admin.DeleteAppProfileRequest],
            Awaitable[empty.Empty]]:
        r"""Return a callable for the delete app profile method over gRPC.

        Deletes an app profile from an instance.

        Returns:
            Callable[[~.DeleteAppProfileRequest],
                    Awaitable[~.Empty]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'delete_app_profile' not in self._stubs:
            self._stubs['delete_app_profile'] = self.grpc_channel.unary_unary(
                '/google.bigtable.admin.v2.BigtableInstanceAdmin/DeleteAppProfile',
                request_serializer=bigtable_instance_admin.DeleteAppProfileRequest.serialize,
                response_deserializer=empty.Empty.FromString,
            )
        return self._stubs['delete_app_profile']

    @property
    def get_iam_policy(self) -> Callable[
            [iam_policy.GetIamPolicyRequest],
            Awaitable[policy.Policy]]:
        r"""Return a callable for the get iam policy method over gRPC.

        Gets the access control policy for an instance
        resource. Returns an empty policy if an instance exists
        but does not have a policy set.

        Returns:
            Callable[[~.GetIamPolicyRequest],
                    Awaitable[~.Policy]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_iam_policy' not in self._stubs:
            self._stubs['get_iam_policy'] = self.grpc_channel.unary_unary(
                '/google.bigtable.admin.v2.BigtableInstanceAdmin/GetIamPolicy',
                request_serializer=iam_policy.GetIamPolicyRequest.SerializeToString,
                response_deserializer=policy.Policy.FromString,
            )
        return self._stubs['get_iam_policy']

    @property
    def set_iam_policy(self) -> Callable[
            [iam_policy.SetIamPolicyRequest],
            Awaitable[policy.Policy]]:
        r"""Return a callable for the set iam policy method over gRPC.

        Sets the access control policy on an instance
        resource. Replaces any existing policy.

        Returns:
            Callable[[~.SetIamPolicyRequest],
                    Awaitable[~.Policy]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'set_iam_policy' not in self._stubs:
            self._stubs['set_iam_policy'] = self.grpc_channel.unary_unary(
                '/google.bigtable.admin.v2.BigtableInstanceAdmin/SetIamPolicy',
                request_serializer=iam_policy.SetIamPolicyRequest.SerializeToString,
                response_deserializer=policy.Policy.FromString,
            )
        return self._stubs['set_iam_policy']

    @property
    def test_iam_permissions(self) -> Callable[
            [iam_policy.TestIamPermissionsRequest],
            Awaitable[iam_policy.TestIamPermissionsResponse]]:
        r"""Return a callable for the test iam permissions method over gRPC.

        Returns permissions that the caller has on the
        specified instance resource.

        Returns:
            Callable[[~.TestIamPermissionsRequest],
                    Awaitable[~.TestIamPermissionsResponse]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'test_iam_permissions' not in self._stubs:
            self._stubs['test_iam_permissions'] = self.grpc_channel.unary_unary(
                '/google.bigtable.admin.v2.BigtableInstanceAdmin/TestIamPermissions',
                request_serializer=iam_policy.TestIamPermissionsRequest.SerializeToString,
                response_deserializer=iam_policy.TestIamPermissionsResponse.FromString,
            )
        return self._stubs['test_iam_permissions']


__all__ = (
    'BigtableInstanceAdminGrpcAsyncIOTransport',
)
