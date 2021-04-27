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
from google.api_core import operations_v1  # type: ignore
from google.api_core import gapic_v1       # type: ignore
from google import auth                    # type: ignore
from google.auth import credentials        # type: ignore
from google.auth.transport.grpc import SslCredentials  # type: ignore

import grpc  # type: ignore

from google.longrunning import operations_pb2 as operations  # type: ignore
from google.partner.aistreams_v1alpha1.types import aistreams
from .base import AIStreamsTransport, DEFAULT_CLIENT_INFO


class AIStreamsGrpcTransport(AIStreamsTransport):
    """gRPC backend transport for AIStreams.

    AIStreams service.

    This class defines the same methods as the primary client, so the
    primary client can load the underlying transport implementation
    and call it.

    It sends protocol buffers over the wire using gRPC (which is built on
    top of HTTP/2); the ``grpcio`` package must be installed.
    """
    _stubs: Dict[str, Callable]

    def __init__(self, *,
            host: str = 'aistreams.googleapis.com',
            credentials: credentials.Credentials = None,
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
        self._operations_client = None

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
                       host: str = 'aistreams.googleapis.com',
                       credentials: credentials.Credentials = None,
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

        self_signed_jwt_kwargs = cls._get_self_signed_jwt_kwargs(host, scopes)

        return grpc_helpers.create_channel(
            host,
            credentials=credentials,
            credentials_file=credentials_file,
            quota_project_id=quota_project_id,
            **self_signed_jwt_kwargs,
            **kwargs
        )

    @property
    def grpc_channel(self) -> grpc.Channel:
        """Return the channel designed to connect to this service.
        """
        return self._grpc_channel

    @property
    def operations_client(self) -> operations_v1.OperationsClient:
        """Create the client designed to process long-running operations.

        This property caches on the instance; repeated calls return the same
        client.
        """
        # Sanity check: Only create a new client if we do not already have one.
        if self._operations_client is None:
            self._operations_client = operations_v1.OperationsClient(
                self.grpc_channel
            )

        # Return the client from cache.
        return self._operations_client

    @property
    def list_clusters(self) -> Callable[
            [aistreams.ListClustersRequest],
            aistreams.ListClustersResponse]:
        r"""Return a callable for the
        list clusters
          method over gRPC.

        Lists Clusters in a given project and location.

        Returns:
            Callable[[~.ListClustersRequest],
                    ~.ListClustersResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_clusters' not in self._stubs:
            self._stubs['list_clusters'] = self.grpc_channel.unary_unary(
                '/google.partner.aistreams.v1alpha1.AIStreams/ListClusters',
                request_serializer=aistreams.ListClustersRequest.serialize,
                response_deserializer=aistreams.ListClustersResponse.deserialize,
            )
        return self._stubs['list_clusters']

    @property
    def get_cluster(self) -> Callable[
            [aistreams.GetClusterRequest],
            aistreams.Cluster]:
        r"""Return a callable for the
        get cluster
          method over gRPC.

        Gets details of a single Cluster.

        Returns:
            Callable[[~.GetClusterRequest],
                    ~.Cluster]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_cluster' not in self._stubs:
            self._stubs['get_cluster'] = self.grpc_channel.unary_unary(
                '/google.partner.aistreams.v1alpha1.AIStreams/GetCluster',
                request_serializer=aistreams.GetClusterRequest.serialize,
                response_deserializer=aistreams.Cluster.deserialize,
            )
        return self._stubs['get_cluster']

    @property
    def create_cluster(self) -> Callable[
            [aistreams.CreateClusterRequest],
            operations.Operation]:
        r"""Return a callable for the
        create cluster
          method over gRPC.

        Creates a new Cluster in a given project and
        location.

        Returns:
            Callable[[~.CreateClusterRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'create_cluster' not in self._stubs:
            self._stubs['create_cluster'] = self.grpc_channel.unary_unary(
                '/google.partner.aistreams.v1alpha1.AIStreams/CreateCluster',
                request_serializer=aistreams.CreateClusterRequest.serialize,
                response_deserializer=operations.Operation.FromString,
            )
        return self._stubs['create_cluster']

    @property
    def update_cluster(self) -> Callable[
            [aistreams.UpdateClusterRequest],
            operations.Operation]:
        r"""Return a callable for the
        update cluster
          method over gRPC.

        Updates the parameters of a single Cluster.

        Returns:
            Callable[[~.UpdateClusterRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update_cluster' not in self._stubs:
            self._stubs['update_cluster'] = self.grpc_channel.unary_unary(
                '/google.partner.aistreams.v1alpha1.AIStreams/UpdateCluster',
                request_serializer=aistreams.UpdateClusterRequest.serialize,
                response_deserializer=operations.Operation.FromString,
            )
        return self._stubs['update_cluster']

    @property
    def delete_cluster(self) -> Callable[
            [aistreams.DeleteClusterRequest],
            operations.Operation]:
        r"""Return a callable for the
        delete cluster
          method over gRPC.

        Deletes a single Cluster.

        Returns:
            Callable[[~.DeleteClusterRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'delete_cluster' not in self._stubs:
            self._stubs['delete_cluster'] = self.grpc_channel.unary_unary(
                '/google.partner.aistreams.v1alpha1.AIStreams/DeleteCluster',
                request_serializer=aistreams.DeleteClusterRequest.serialize,
                response_deserializer=operations.Operation.FromString,
            )
        return self._stubs['delete_cluster']

    @property
    def list_streams(self) -> Callable[
            [aistreams.ListStreamsRequest],
            aistreams.ListStreamsResponse]:
        r"""Return a callable for the
        list streams
          method over gRPC.

        Lists Streams in a given project, location and
        cluster.

        Returns:
            Callable[[~.ListStreamsRequest],
                    ~.ListStreamsResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_streams' not in self._stubs:
            self._stubs['list_streams'] = self.grpc_channel.unary_unary(
                '/google.partner.aistreams.v1alpha1.AIStreams/ListStreams',
                request_serializer=aistreams.ListStreamsRequest.serialize,
                response_deserializer=aistreams.ListStreamsResponse.deserialize,
            )
        return self._stubs['list_streams']

    @property
    def get_stream(self) -> Callable[
            [aistreams.GetStreamRequest],
            aistreams.Stream]:
        r"""Return a callable for the
        get stream
          method over gRPC.

        Gets details of a single Stream.

        Returns:
            Callable[[~.GetStreamRequest],
                    ~.Stream]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_stream' not in self._stubs:
            self._stubs['get_stream'] = self.grpc_channel.unary_unary(
                '/google.partner.aistreams.v1alpha1.AIStreams/GetStream',
                request_serializer=aistreams.GetStreamRequest.serialize,
                response_deserializer=aistreams.Stream.deserialize,
            )
        return self._stubs['get_stream']

    @property
    def create_stream(self) -> Callable[
            [aistreams.CreateStreamRequest],
            operations.Operation]:
        r"""Return a callable for the
        create stream
          method over gRPC.

        Creates a new Stream in a given project and location.

        Returns:
            Callable[[~.CreateStreamRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'create_stream' not in self._stubs:
            self._stubs['create_stream'] = self.grpc_channel.unary_unary(
                '/google.partner.aistreams.v1alpha1.AIStreams/CreateStream',
                request_serializer=aistreams.CreateStreamRequest.serialize,
                response_deserializer=operations.Operation.FromString,
            )
        return self._stubs['create_stream']

    @property
    def update_stream(self) -> Callable[
            [aistreams.UpdateStreamRequest],
            operations.Operation]:
        r"""Return a callable for the
        update stream
          method over gRPC.

        Updates the parameters of a single Stream.

        Returns:
            Callable[[~.UpdateStreamRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update_stream' not in self._stubs:
            self._stubs['update_stream'] = self.grpc_channel.unary_unary(
                '/google.partner.aistreams.v1alpha1.AIStreams/UpdateStream',
                request_serializer=aistreams.UpdateStreamRequest.serialize,
                response_deserializer=operations.Operation.FromString,
            )
        return self._stubs['update_stream']

    @property
    def delete_stream(self) -> Callable[
            [aistreams.DeleteStreamRequest],
            operations.Operation]:
        r"""Return a callable for the
        delete stream
          method over gRPC.

        Deletes a single Stream.

        Returns:
            Callable[[~.DeleteStreamRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'delete_stream' not in self._stubs:
            self._stubs['delete_stream'] = self.grpc_channel.unary_unary(
                '/google.partner.aistreams.v1alpha1.AIStreams/DeleteStream',
                request_serializer=aistreams.DeleteStreamRequest.serialize,
                response_deserializer=operations.Operation.FromString,
            )
        return self._stubs['delete_stream']


__all__ = (
    'AIStreamsGrpcTransport',
)
