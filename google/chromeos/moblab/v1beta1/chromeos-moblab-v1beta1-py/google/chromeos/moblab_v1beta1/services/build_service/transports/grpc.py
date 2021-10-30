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
import google.auth                         # type: ignore
from google.auth import credentials as ga_credentials  # type: ignore
from google.auth.transport.grpc import SslCredentials  # type: ignore

import grpc  # type: ignore

from google.chromeos.moblab_v1beta1.types import build_service
from google.longrunning import operations_pb2  # type: ignore
from .base import BuildServiceTransport, DEFAULT_CLIENT_INFO


class BuildServiceGrpcTransport(BuildServiceTransport):
    """gRPC backend transport for BuildService.

    Manages Chrome OS build services.

    This class defines the same methods as the primary client, so the
    primary client can load the underlying transport implementation
    and call it.

    It sends protocol buffers over the wire using gRPC (which is built on
    top of HTTP/2); the ``grpcio`` package must be installed.
    """
    _stubs: Dict[str, Callable]

    def __init__(self, *,
            host: str = 'chromeosmoblab.googleapis.com',
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
            always_use_jwt_access: Optional[bool] = False,
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
                ``client_cert_source`` or application default SSL credentials.
            client_cert_source (Optional[Callable[[], Tuple[bytes, bytes]]]):
                Deprecated. A callback to provide client SSL certificate bytes and
                private key bytes, both in PEM format. It is ignored if
                ``api_mtls_endpoint`` is None.
            ssl_channel_credentials (grpc.ChannelCredentials): SSL credentials
                for the grpc channel. It is ignored if ``channel`` is provided.
            client_cert_source_for_mtls (Optional[Callable[[], Tuple[bytes, bytes]]]):
                A callback to provide client certificate bytes and private key bytes,
                both in PEM format. It is used to configure a mutual TLS channel. It is
                ignored if ``channel`` or ``ssl_channel_credentials`` is provided.
            quota_project_id (Optional[str]): An optional project to use for billing
                and quota.
            client_info (google.api_core.gapic_v1.client_info.ClientInfo):
                The client info used to send a user-agent string along with
                API requests. If ``None``, then default info will be used.
                Generally, you only need to set this if you're developing
                your own client library.
            always_use_jwt_access (Optional[bool]): Whether self signed JWT should
                be used for service account credentials.

        Raises:
          google.auth.exceptions.MutualTLSChannelError: If mutual TLS transport
              creation failed for any reason.
          google.api_core.exceptions.DuplicateCredentialArgs: If both ``credentials``
              and ``credentials_file`` are passed.
        """
        self._grpc_channel = None
        self._ssl_channel_credentials = ssl_channel_credentials
        self._stubs: Dict[str, Callable] = {}
        self._operations_client: Optional[operations_v1.OperationsClient] = None

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
            always_use_jwt_access=always_use_jwt_access,
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
                       host: str = 'chromeosmoblab.googleapis.com',
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
    def list_build_targets(self) -> Callable[
            [build_service.ListBuildTargetsRequest],
            build_service.ListBuildTargetsResponse]:
        r"""Return a callable for the list build targets method over gRPC.

        Lists all build targets that a user has access to.

        Returns:
            Callable[[~.ListBuildTargetsRequest],
                    ~.ListBuildTargetsResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_build_targets' not in self._stubs:
            self._stubs['list_build_targets'] = self.grpc_channel.unary_unary(
                '/google.chromeos.moblab.v1beta1.BuildService/ListBuildTargets',
                request_serializer=build_service.ListBuildTargetsRequest.serialize,
                response_deserializer=build_service.ListBuildTargetsResponse.deserialize,
            )
        return self._stubs['list_build_targets']

    @property
    def list_models(self) -> Callable[
            [build_service.ListModelsRequest],
            build_service.ListModelsResponse]:
        r"""Return a callable for the list models method over gRPC.

        Lists all models for the given build target.

        Returns:
            Callable[[~.ListModelsRequest],
                    ~.ListModelsResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_models' not in self._stubs:
            self._stubs['list_models'] = self.grpc_channel.unary_unary(
                '/google.chromeos.moblab.v1beta1.BuildService/ListModels',
                request_serializer=build_service.ListModelsRequest.serialize,
                response_deserializer=build_service.ListModelsResponse.deserialize,
            )
        return self._stubs['list_models']

    @property
    def list_builds(self) -> Callable[
            [build_service.ListBuildsRequest],
            build_service.ListBuildsResponse]:
        r"""Return a callable for the list builds method over gRPC.

        Lists all builds for the given build target and model
        in descending order for the milestones and build
        versions.

        Returns:
            Callable[[~.ListBuildsRequest],
                    ~.ListBuildsResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_builds' not in self._stubs:
            self._stubs['list_builds'] = self.grpc_channel.unary_unary(
                '/google.chromeos.moblab.v1beta1.BuildService/ListBuilds',
                request_serializer=build_service.ListBuildsRequest.serialize,
                response_deserializer=build_service.ListBuildsResponse.deserialize,
            )
        return self._stubs['list_builds']

    @property
    def check_build_stage_status(self) -> Callable[
            [build_service.CheckBuildStageStatusRequest],
            build_service.CheckBuildStageStatusResponse]:
        r"""Return a callable for the check build stage status method over gRPC.

        Checks the stage status for a given build artifact in
        a partner Google Cloud Storage bucket.

        Returns:
            Callable[[~.CheckBuildStageStatusRequest],
                    ~.CheckBuildStageStatusResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'check_build_stage_status' not in self._stubs:
            self._stubs['check_build_stage_status'] = self.grpc_channel.unary_unary(
                '/google.chromeos.moblab.v1beta1.BuildService/CheckBuildStageStatus',
                request_serializer=build_service.CheckBuildStageStatusRequest.serialize,
                response_deserializer=build_service.CheckBuildStageStatusResponse.deserialize,
            )
        return self._stubs['check_build_stage_status']

    @property
    def stage_build(self) -> Callable[
            [build_service.StageBuildRequest],
            operations_pb2.Operation]:
        r"""Return a callable for the stage build method over gRPC.

        Stages a given build artifact from a internal Google Cloud
        Storage bucket to a partner Google Cloud Storage bucket. If any
        of objects has already been copied, it will overwrite the
        previous objects. Operation <response:
        [StageBuildResponse][google.chromeos.moblab.v1beta1.StageBuildResponse],
        metadata:
        [StageBuildMetadata][google.chromeos.moblab.v1beta1.StageBuildMetadata]>

        Returns:
            Callable[[~.StageBuildRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'stage_build' not in self._stubs:
            self._stubs['stage_build'] = self.grpc_channel.unary_unary(
                '/google.chromeos.moblab.v1beta1.BuildService/StageBuild',
                request_serializer=build_service.StageBuildRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['stage_build']

    @property
    def find_most_stable_build(self) -> Callable[
            [build_service.FindMostStableBuildRequest],
            build_service.FindMostStableBuildResponse]:
        r"""Return a callable for the find most stable build method over gRPC.

        Finds the most stable build for the given build
        target. The definition of the most stable build is
        determined by evaluating the following rules in order
        until one is true. If none are true, then there is no
        stable build and it will return an empty response.

        Evaluation rules:
          1. Stable channel build with label “Live”
          2. Beta channel build with label “Live”
          3. Dev channel build with label “Live”
          4. Most recent stable channel build with build status
        Pass   5. Most recent beta channel build with build
        status Pass   6. Most recent dev channel build with
        build status Pass

        Returns:
            Callable[[~.FindMostStableBuildRequest],
                    ~.FindMostStableBuildResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'find_most_stable_build' not in self._stubs:
            self._stubs['find_most_stable_build'] = self.grpc_channel.unary_unary(
                '/google.chromeos.moblab.v1beta1.BuildService/FindMostStableBuild',
                request_serializer=build_service.FindMostStableBuildRequest.serialize,
                response_deserializer=build_service.FindMostStableBuildResponse.deserialize,
            )
        return self._stubs['find_most_stable_build']

    def close(self):
        self.grpc_channel.close()

__all__ = (
    'BuildServiceGrpcTransport',
)
