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

from google.identity.accesscontextmanager_v1.types import access_context_manager
from google.identity.accesscontextmanager_v1.types import access_level
from google.identity.accesscontextmanager_v1.types import access_policy
from google.identity.accesscontextmanager_v1.types import gcp_user_access_binding
from google.identity.accesscontextmanager_v1.types import service_perimeter
from google.longrunning import operations_pb2  # type: ignore
from .base import AccessContextManagerTransport, DEFAULT_CLIENT_INFO


class AccessContextManagerGrpcTransport(AccessContextManagerTransport):
    """gRPC backend transport for AccessContextManager.

    API for setting [Access Levels]
    [google.identity.accesscontextmanager.v1.AccessLevel] and [Service
    Perimeters]
    [google.identity.accesscontextmanager.v1.ServicePerimeter] for
    Google Cloud Projects. Each organization has one [AccessPolicy]
    [google.identity.accesscontextmanager.v1.AccessPolicy] containing
    the [Access Levels]
    [google.identity.accesscontextmanager.v1.AccessLevel] and [Service
    Perimeters]
    [google.identity.accesscontextmanager.v1.ServicePerimeter]. This
    [AccessPolicy]
    [google.identity.accesscontextmanager.v1.AccessPolicy] is applicable
    to all resources in the organization. AccessPolicies

    This class defines the same methods as the primary client, so the
    primary client can load the underlying transport implementation
    and call it.

    It sends protocol buffers over the wire using gRPC (which is built on
    top of HTTP/2); the ``grpcio`` package must be installed.
    """
    _stubs: Dict[str, Callable]

    def __init__(self, *,
            host: str = 'accesscontextmanager.googleapis.com',
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
                       host: str = 'accesscontextmanager.googleapis.com',
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
    def list_access_policies(self) -> Callable[
            [access_context_manager.ListAccessPoliciesRequest],
            access_context_manager.ListAccessPoliciesResponse]:
        r"""Return a callable for the list access policies method over gRPC.

        List all [AccessPolicies]
        [google.identity.accesscontextmanager.v1.AccessPolicy] under a
        container.

        Returns:
            Callable[[~.ListAccessPoliciesRequest],
                    ~.ListAccessPoliciesResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_access_policies' not in self._stubs:
            self._stubs['list_access_policies'] = self.grpc_channel.unary_unary(
                '/google.identity.accesscontextmanager.v1.AccessContextManager/ListAccessPolicies',
                request_serializer=access_context_manager.ListAccessPoliciesRequest.serialize,
                response_deserializer=access_context_manager.ListAccessPoliciesResponse.deserialize,
            )
        return self._stubs['list_access_policies']

    @property
    def get_access_policy(self) -> Callable[
            [access_context_manager.GetAccessPolicyRequest],
            access_policy.AccessPolicy]:
        r"""Return a callable for the get access policy method over gRPC.

        Get an [AccessPolicy]
        [google.identity.accesscontextmanager.v1.AccessPolicy] by name.

        Returns:
            Callable[[~.GetAccessPolicyRequest],
                    ~.AccessPolicy]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_access_policy' not in self._stubs:
            self._stubs['get_access_policy'] = self.grpc_channel.unary_unary(
                '/google.identity.accesscontextmanager.v1.AccessContextManager/GetAccessPolicy',
                request_serializer=access_context_manager.GetAccessPolicyRequest.serialize,
                response_deserializer=access_policy.AccessPolicy.deserialize,
            )
        return self._stubs['get_access_policy']

    @property
    def create_access_policy(self) -> Callable[
            [access_policy.AccessPolicy],
            operations_pb2.Operation]:
        r"""Return a callable for the create access policy method over gRPC.

        Create an ``AccessPolicy``. Fails if this organization already
        has a ``AccessPolicy``. The longrunning Operation will have a
        successful status once the ``AccessPolicy`` has propagated to
        long-lasting storage. Syntactic and basic semantic errors will
        be returned in ``metadata`` as a BadRequest proto.

        Returns:
            Callable[[~.AccessPolicy],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'create_access_policy' not in self._stubs:
            self._stubs['create_access_policy'] = self.grpc_channel.unary_unary(
                '/google.identity.accesscontextmanager.v1.AccessContextManager/CreateAccessPolicy',
                request_serializer=access_policy.AccessPolicy.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['create_access_policy']

    @property
    def update_access_policy(self) -> Callable[
            [access_context_manager.UpdateAccessPolicyRequest],
            operations_pb2.Operation]:
        r"""Return a callable for the update access policy method over gRPC.

        Update an [AccessPolicy]
        [google.identity.accesscontextmanager.v1.AccessPolicy]. The
        longrunning Operation from this RPC will have a successful
        status once the changes to the [AccessPolicy]
        [google.identity.accesscontextmanager.v1.AccessPolicy] have
        propagated to long-lasting storage. Syntactic and basic semantic
        errors will be returned in ``metadata`` as a BadRequest proto.

        Returns:
            Callable[[~.UpdateAccessPolicyRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update_access_policy' not in self._stubs:
            self._stubs['update_access_policy'] = self.grpc_channel.unary_unary(
                '/google.identity.accesscontextmanager.v1.AccessContextManager/UpdateAccessPolicy',
                request_serializer=access_context_manager.UpdateAccessPolicyRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['update_access_policy']

    @property
    def delete_access_policy(self) -> Callable[
            [access_context_manager.DeleteAccessPolicyRequest],
            operations_pb2.Operation]:
        r"""Return a callable for the delete access policy method over gRPC.

        Delete an [AccessPolicy]
        [google.identity.accesscontextmanager.v1.AccessPolicy] by
        resource name. The longrunning Operation will have a successful
        status once the [AccessPolicy]
        [google.identity.accesscontextmanager.v1.AccessPolicy] has been
        removed from long-lasting storage.

        Returns:
            Callable[[~.DeleteAccessPolicyRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'delete_access_policy' not in self._stubs:
            self._stubs['delete_access_policy'] = self.grpc_channel.unary_unary(
                '/google.identity.accesscontextmanager.v1.AccessContextManager/DeleteAccessPolicy',
                request_serializer=access_context_manager.DeleteAccessPolicyRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['delete_access_policy']

    @property
    def list_access_levels(self) -> Callable[
            [access_context_manager.ListAccessLevelsRequest],
            access_context_manager.ListAccessLevelsResponse]:
        r"""Return a callable for the list access levels method over gRPC.

        List all [Access Levels]
        [google.identity.accesscontextmanager.v1.AccessLevel] for an
        access policy.

        Returns:
            Callable[[~.ListAccessLevelsRequest],
                    ~.ListAccessLevelsResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_access_levels' not in self._stubs:
            self._stubs['list_access_levels'] = self.grpc_channel.unary_unary(
                '/google.identity.accesscontextmanager.v1.AccessContextManager/ListAccessLevels',
                request_serializer=access_context_manager.ListAccessLevelsRequest.serialize,
                response_deserializer=access_context_manager.ListAccessLevelsResponse.deserialize,
            )
        return self._stubs['list_access_levels']

    @property
    def get_access_level(self) -> Callable[
            [access_context_manager.GetAccessLevelRequest],
            access_level.AccessLevel]:
        r"""Return a callable for the get access level method over gRPC.

        Get an [Access Level]
        [google.identity.accesscontextmanager.v1.AccessLevel] by
        resource name.

        Returns:
            Callable[[~.GetAccessLevelRequest],
                    ~.AccessLevel]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_access_level' not in self._stubs:
            self._stubs['get_access_level'] = self.grpc_channel.unary_unary(
                '/google.identity.accesscontextmanager.v1.AccessContextManager/GetAccessLevel',
                request_serializer=access_context_manager.GetAccessLevelRequest.serialize,
                response_deserializer=access_level.AccessLevel.deserialize,
            )
        return self._stubs['get_access_level']

    @property
    def create_access_level(self) -> Callable[
            [access_context_manager.CreateAccessLevelRequest],
            operations_pb2.Operation]:
        r"""Return a callable for the create access level method over gRPC.

        Create an [Access Level]
        [google.identity.accesscontextmanager.v1.AccessLevel]. The
        longrunning operation from this RPC will have a successful
        status once the [Access Level]
        [google.identity.accesscontextmanager.v1.AccessLevel] has
        propagated to long-lasting storage. [Access Levels]
        [google.identity.accesscontextmanager.v1.AccessLevel] containing
        errors will result in an error response for the first error
        encountered.

        Returns:
            Callable[[~.CreateAccessLevelRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'create_access_level' not in self._stubs:
            self._stubs['create_access_level'] = self.grpc_channel.unary_unary(
                '/google.identity.accesscontextmanager.v1.AccessContextManager/CreateAccessLevel',
                request_serializer=access_context_manager.CreateAccessLevelRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['create_access_level']

    @property
    def update_access_level(self) -> Callable[
            [access_context_manager.UpdateAccessLevelRequest],
            operations_pb2.Operation]:
        r"""Return a callable for the update access level method over gRPC.

        Update an [Access Level]
        [google.identity.accesscontextmanager.v1.AccessLevel]. The
        longrunning operation from this RPC will have a successful
        status once the changes to the [Access Level]
        [google.identity.accesscontextmanager.v1.AccessLevel] have
        propagated to long-lasting storage. [Access Levels]
        [google.identity.accesscontextmanager.v1.AccessLevel] containing
        errors will result in an error response for the first error
        encountered.

        Returns:
            Callable[[~.UpdateAccessLevelRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update_access_level' not in self._stubs:
            self._stubs['update_access_level'] = self.grpc_channel.unary_unary(
                '/google.identity.accesscontextmanager.v1.AccessContextManager/UpdateAccessLevel',
                request_serializer=access_context_manager.UpdateAccessLevelRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['update_access_level']

    @property
    def delete_access_level(self) -> Callable[
            [access_context_manager.DeleteAccessLevelRequest],
            operations_pb2.Operation]:
        r"""Return a callable for the delete access level method over gRPC.

        Delete an [Access Level]
        [google.identity.accesscontextmanager.v1.AccessLevel] by
        resource name. The longrunning operation from this RPC will have
        a successful status once the [Access Level]
        [google.identity.accesscontextmanager.v1.AccessLevel] has been
        removed from long-lasting storage.

        Returns:
            Callable[[~.DeleteAccessLevelRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'delete_access_level' not in self._stubs:
            self._stubs['delete_access_level'] = self.grpc_channel.unary_unary(
                '/google.identity.accesscontextmanager.v1.AccessContextManager/DeleteAccessLevel',
                request_serializer=access_context_manager.DeleteAccessLevelRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['delete_access_level']

    @property
    def replace_access_levels(self) -> Callable[
            [access_context_manager.ReplaceAccessLevelsRequest],
            operations_pb2.Operation]:
        r"""Return a callable for the replace access levels method over gRPC.

        Replace all existing [Access Levels]
        [google.identity.accesscontextmanager.v1.AccessLevel] in an
        [Access Policy]
        [google.identity.accesscontextmanager.v1.AccessPolicy] with the
        [Access Levels]
        [google.identity.accesscontextmanager.v1.AccessLevel] provided.
        This is done atomically. The longrunning operation from this RPC
        will have a successful status once all replacements have
        propagated to long-lasting storage. Replacements containing
        errors will result in an error response for the first error
        encountered. Replacement will be cancelled on error, existing
        [Access Levels]
        [google.identity.accesscontextmanager.v1.AccessLevel] will not
        be affected. Operation.response field will contain
        ReplaceAccessLevelsResponse. Removing [Access Levels]
        [google.identity.accesscontextmanager.v1.AccessLevel] contained
        in existing [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] will
        result in error.

        Returns:
            Callable[[~.ReplaceAccessLevelsRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'replace_access_levels' not in self._stubs:
            self._stubs['replace_access_levels'] = self.grpc_channel.unary_unary(
                '/google.identity.accesscontextmanager.v1.AccessContextManager/ReplaceAccessLevels',
                request_serializer=access_context_manager.ReplaceAccessLevelsRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['replace_access_levels']

    @property
    def list_service_perimeters(self) -> Callable[
            [access_context_manager.ListServicePerimetersRequest],
            access_context_manager.ListServicePerimetersResponse]:
        r"""Return a callable for the list service perimeters method over gRPC.

        List all [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] for
        an access policy.

        Returns:
            Callable[[~.ListServicePerimetersRequest],
                    ~.ListServicePerimetersResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_service_perimeters' not in self._stubs:
            self._stubs['list_service_perimeters'] = self.grpc_channel.unary_unary(
                '/google.identity.accesscontextmanager.v1.AccessContextManager/ListServicePerimeters',
                request_serializer=access_context_manager.ListServicePerimetersRequest.serialize,
                response_deserializer=access_context_manager.ListServicePerimetersResponse.deserialize,
            )
        return self._stubs['list_service_perimeters']

    @property
    def get_service_perimeter(self) -> Callable[
            [access_context_manager.GetServicePerimeterRequest],
            service_perimeter.ServicePerimeter]:
        r"""Return a callable for the get service perimeter method over gRPC.

        Get a [Service Perimeter]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] by
        resource name.

        Returns:
            Callable[[~.GetServicePerimeterRequest],
                    ~.ServicePerimeter]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_service_perimeter' not in self._stubs:
            self._stubs['get_service_perimeter'] = self.grpc_channel.unary_unary(
                '/google.identity.accesscontextmanager.v1.AccessContextManager/GetServicePerimeter',
                request_serializer=access_context_manager.GetServicePerimeterRequest.serialize,
                response_deserializer=service_perimeter.ServicePerimeter.deserialize,
            )
        return self._stubs['get_service_perimeter']

    @property
    def create_service_perimeter(self) -> Callable[
            [access_context_manager.CreateServicePerimeterRequest],
            operations_pb2.Operation]:
        r"""Return a callable for the create service perimeter method over gRPC.

        Create a [Service Perimeter]
        [google.identity.accesscontextmanager.v1.ServicePerimeter]. The
        longrunning operation from this RPC will have a successful
        status once the [Service Perimeter]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] has
        propagated to long-lasting storage. [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter]
        containing errors will result in an error response for the first
        error encountered.

        Returns:
            Callable[[~.CreateServicePerimeterRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'create_service_perimeter' not in self._stubs:
            self._stubs['create_service_perimeter'] = self.grpc_channel.unary_unary(
                '/google.identity.accesscontextmanager.v1.AccessContextManager/CreateServicePerimeter',
                request_serializer=access_context_manager.CreateServicePerimeterRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['create_service_perimeter']

    @property
    def update_service_perimeter(self) -> Callable[
            [access_context_manager.UpdateServicePerimeterRequest],
            operations_pb2.Operation]:
        r"""Return a callable for the update service perimeter method over gRPC.

        Update a [Service Perimeter]
        [google.identity.accesscontextmanager.v1.ServicePerimeter]. The
        longrunning operation from this RPC will have a successful
        status once the changes to the [Service Perimeter]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] have
        propagated to long-lasting storage. [Service Perimeter]
        [google.identity.accesscontextmanager.v1.ServicePerimeter]
        containing errors will result in an error response for the first
        error encountered.

        Returns:
            Callable[[~.UpdateServicePerimeterRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update_service_perimeter' not in self._stubs:
            self._stubs['update_service_perimeter'] = self.grpc_channel.unary_unary(
                '/google.identity.accesscontextmanager.v1.AccessContextManager/UpdateServicePerimeter',
                request_serializer=access_context_manager.UpdateServicePerimeterRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['update_service_perimeter']

    @property
    def delete_service_perimeter(self) -> Callable[
            [access_context_manager.DeleteServicePerimeterRequest],
            operations_pb2.Operation]:
        r"""Return a callable for the delete service perimeter method over gRPC.

        Delete a [Service Perimeter]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] by
        resource name. The longrunning operation from this RPC will have
        a successful status once the [Service Perimeter]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] has
        been removed from long-lasting storage.

        Returns:
            Callable[[~.DeleteServicePerimeterRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'delete_service_perimeter' not in self._stubs:
            self._stubs['delete_service_perimeter'] = self.grpc_channel.unary_unary(
                '/google.identity.accesscontextmanager.v1.AccessContextManager/DeleteServicePerimeter',
                request_serializer=access_context_manager.DeleteServicePerimeterRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['delete_service_perimeter']

    @property
    def replace_service_perimeters(self) -> Callable[
            [access_context_manager.ReplaceServicePerimetersRequest],
            operations_pb2.Operation]:
        r"""Return a callable for the replace service perimeters method over gRPC.

        Replace all existing [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] in an
        [Access Policy]
        [google.identity.accesscontextmanager.v1.AccessPolicy] with the
        [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter]
        provided. This is done atomically. The longrunning operation
        from this RPC will have a successful status once all
        replacements have propagated to long-lasting storage.
        Replacements containing errors will result in an error response
        for the first error encountered. Replacement will be cancelled
        on error, existing [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] will
        not be affected. Operation.response field will contain
        ReplaceServicePerimetersResponse.

        Returns:
            Callable[[~.ReplaceServicePerimetersRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'replace_service_perimeters' not in self._stubs:
            self._stubs['replace_service_perimeters'] = self.grpc_channel.unary_unary(
                '/google.identity.accesscontextmanager.v1.AccessContextManager/ReplaceServicePerimeters',
                request_serializer=access_context_manager.ReplaceServicePerimetersRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['replace_service_perimeters']

    @property
    def commit_service_perimeters(self) -> Callable[
            [access_context_manager.CommitServicePerimetersRequest],
            operations_pb2.Operation]:
        r"""Return a callable for the commit service perimeters method over gRPC.

        Commit the dry-run spec for all the [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] in an
        [Access
        Policy][google.identity.accesscontextmanager.v1.AccessPolicy]. A
        commit operation on a Service Perimeter involves copying its
        ``spec`` field to that Service Perimeter's ``status`` field.
        Only [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] with
        ``use_explicit_dry_run_spec`` field set to true are affected by
        a commit operation. The longrunning operation from this RPC will
        have a successful status once the dry-run specs for all the
        [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] have
        been committed. If a commit fails, it will cause the longrunning
        operation to return an error response and the entire commit
        operation will be cancelled. When successful, Operation.response
        field will contain CommitServicePerimetersResponse. The
        ``dry_run`` and the ``spec`` fields will be cleared after a
        successful commit operation.

        Returns:
            Callable[[~.CommitServicePerimetersRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'commit_service_perimeters' not in self._stubs:
            self._stubs['commit_service_perimeters'] = self.grpc_channel.unary_unary(
                '/google.identity.accesscontextmanager.v1.AccessContextManager/CommitServicePerimeters',
                request_serializer=access_context_manager.CommitServicePerimetersRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['commit_service_perimeters']

    @property
    def list_gcp_user_access_bindings(self) -> Callable[
            [access_context_manager.ListGcpUserAccessBindingsRequest],
            access_context_manager.ListGcpUserAccessBindingsResponse]:
        r"""Return a callable for the list gcp user access bindings method over gRPC.

        Lists all [GcpUserAccessBindings]
        [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]
        for a Google Cloud organization.

        Returns:
            Callable[[~.ListGcpUserAccessBindingsRequest],
                    ~.ListGcpUserAccessBindingsResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_gcp_user_access_bindings' not in self._stubs:
            self._stubs['list_gcp_user_access_bindings'] = self.grpc_channel.unary_unary(
                '/google.identity.accesscontextmanager.v1.AccessContextManager/ListGcpUserAccessBindings',
                request_serializer=access_context_manager.ListGcpUserAccessBindingsRequest.serialize,
                response_deserializer=access_context_manager.ListGcpUserAccessBindingsResponse.deserialize,
            )
        return self._stubs['list_gcp_user_access_bindings']

    @property
    def get_gcp_user_access_binding(self) -> Callable[
            [access_context_manager.GetGcpUserAccessBindingRequest],
            gcp_user_access_binding.GcpUserAccessBinding]:
        r"""Return a callable for the get gcp user access binding method over gRPC.

        Gets the [GcpUserAccessBinding]
        [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]
        with the given name.

        Returns:
            Callable[[~.GetGcpUserAccessBindingRequest],
                    ~.GcpUserAccessBinding]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_gcp_user_access_binding' not in self._stubs:
            self._stubs['get_gcp_user_access_binding'] = self.grpc_channel.unary_unary(
                '/google.identity.accesscontextmanager.v1.AccessContextManager/GetGcpUserAccessBinding',
                request_serializer=access_context_manager.GetGcpUserAccessBindingRequest.serialize,
                response_deserializer=gcp_user_access_binding.GcpUserAccessBinding.deserialize,
            )
        return self._stubs['get_gcp_user_access_binding']

    @property
    def create_gcp_user_access_binding(self) -> Callable[
            [access_context_manager.CreateGcpUserAccessBindingRequest],
            operations_pb2.Operation]:
        r"""Return a callable for the create gcp user access binding method over gRPC.

        Creates a [GcpUserAccessBinding]
        [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        If the client specifies a [name]
        [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.name],
        the server will ignore it. Fails if a resource already exists
        with the same [group_key]
        [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.group_key].
        Completion of this long-running operation does not necessarily
        signify that the new binding is deployed onto all affected
        users, which may take more time.

        Returns:
            Callable[[~.CreateGcpUserAccessBindingRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'create_gcp_user_access_binding' not in self._stubs:
            self._stubs['create_gcp_user_access_binding'] = self.grpc_channel.unary_unary(
                '/google.identity.accesscontextmanager.v1.AccessContextManager/CreateGcpUserAccessBinding',
                request_serializer=access_context_manager.CreateGcpUserAccessBindingRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['create_gcp_user_access_binding']

    @property
    def update_gcp_user_access_binding(self) -> Callable[
            [access_context_manager.UpdateGcpUserAccessBindingRequest],
            operations_pb2.Operation]:
        r"""Return a callable for the update gcp user access binding method over gRPC.

        Updates a [GcpUserAccessBinding]
        [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        Completion of this long-running operation does not necessarily
        signify that the changed binding is deployed onto all affected
        users, which may take more time.

        Returns:
            Callable[[~.UpdateGcpUserAccessBindingRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update_gcp_user_access_binding' not in self._stubs:
            self._stubs['update_gcp_user_access_binding'] = self.grpc_channel.unary_unary(
                '/google.identity.accesscontextmanager.v1.AccessContextManager/UpdateGcpUserAccessBinding',
                request_serializer=access_context_manager.UpdateGcpUserAccessBindingRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['update_gcp_user_access_binding']

    @property
    def delete_gcp_user_access_binding(self) -> Callable[
            [access_context_manager.DeleteGcpUserAccessBindingRequest],
            operations_pb2.Operation]:
        r"""Return a callable for the delete gcp user access binding method over gRPC.

        Deletes a [GcpUserAccessBinding]
        [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        Completion of this long-running operation does not necessarily
        signify that the binding deletion is deployed onto all affected
        users, which may take more time.

        Returns:
            Callable[[~.DeleteGcpUserAccessBindingRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'delete_gcp_user_access_binding' not in self._stubs:
            self._stubs['delete_gcp_user_access_binding'] = self.grpc_channel.unary_unary(
                '/google.identity.accesscontextmanager.v1.AccessContextManager/DeleteGcpUserAccessBinding',
                request_serializer=access_context_manager.DeleteGcpUserAccessBindingRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['delete_gcp_user_access_binding']

    def close(self):
        self.grpc_channel.close()

__all__ = (
    'AccessContextManagerGrpcTransport',
)
