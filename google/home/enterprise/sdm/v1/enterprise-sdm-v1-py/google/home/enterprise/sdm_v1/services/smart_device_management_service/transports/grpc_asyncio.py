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
from typing import Awaitable, Callable, Dict, Optional, Sequence, Tuple, Union

from google.api_core import gapic_v1                   # type: ignore
from google.api_core import grpc_helpers_async         # type: ignore
from google.auth import credentials as ga_credentials   # type: ignore
from google.auth.transport.grpc import SslCredentials  # type: ignore
import packaging.version

import grpc                        # type: ignore
from grpc.experimental import aio  # type: ignore

from google.home.enterprise.sdm_v1.types import device
from google.home.enterprise.sdm_v1.types import site
from google.home.enterprise.sdm_v1.types import smart_device_management_service
from .base import SmartDeviceManagementServiceTransport, DEFAULT_CLIENT_INFO
from .grpc import SmartDeviceManagementServiceGrpcTransport


class SmartDeviceManagementServiceGrpcAsyncIOTransport(SmartDeviceManagementServiceTransport):
    """gRPC AsyncIO backend transport for SmartDeviceManagementService.

    A service that allows API consumers to provision and manage
    Google Home structures and devices for enterprise use cases.

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
                       host: str = 'smartdevicemanagement.googleapis.com',
                       credentials: ga_credentials.Credentials = None,
                       credentials_file: Optional[str] = None,
                       scopes: Optional[Sequence[str]] = None,
                       quota_project_id: Optional[str] = None,
                       **kwargs) -> aio.Channel:
        """Create and return a gRPC AsyncIO channel object.
        Args:
            host (Optional[str]): The host for the channel to use.
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

        return grpc_helpers_async.create_channel(
            host,
            credentials=credentials,
            credentials_file=credentials_file,
            quota_project_id=quota_project_id,
            default_scopes=cls.AUTH_SCOPES,
            scopes=scopes,
            default_host=cls.DEFAULT_HOST,
            **kwargs
        )

    def __init__(self, *,
            host: str = 'smartdevicemanagement.googleapis.com',
            credentials: ga_credentials.Credentials = None,
            credentials_file: Optional[str] = None,
            scopes: Optional[Sequence[str]] = None,
            channel: aio.Channel = None,
            api_mtls_endpoint: str = None,
            client_cert_source: Callable[[], Tuple[bytes, bytes]] = None,
            ssl_channel_credentials: grpc.ChannelCredentials = None,
            client_cert_source_for_mtls: Callable[[], Tuple[bytes, bytes]] = None,
            quota_project_id=None,
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
            always_use_jwt_access (Optional[bool]): Whether self signed JWT should
                be used for service account credentials.

        Raises:
            google.auth.exceptions.MutualTlsChannelError: If mutual TLS transport
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

    @property
    def grpc_channel(self) -> aio.Channel:
        """Create the channel designed to connect to this service.

        This property caches on the instance; repeated calls return
        the same channel.
        """
        # Return the channel from cache.
        return self._grpc_channel

    @property
    def get_device(self) -> Callable[
            [smart_device_management_service.GetDeviceRequest],
            Awaitable[device.Device]]:
        r"""Return a callable for the get device method over gRPC.

        Gets a device managed by the enterprise.

        Returns:
            Callable[[~.GetDeviceRequest],
                    Awaitable[~.Device]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_device' not in self._stubs:
            self._stubs['get_device'] = self.grpc_channel.unary_unary(
                '/google.home.enterprise.sdm.v1.SmartDeviceManagementService/GetDevice',
                request_serializer=smart_device_management_service.GetDeviceRequest.serialize,
                response_deserializer=device.Device.deserialize,
            )
        return self._stubs['get_device']

    @property
    def list_devices(self) -> Callable[
            [smart_device_management_service.ListDevicesRequest],
            Awaitable[smart_device_management_service.ListDevicesResponse]]:
        r"""Return a callable for the list devices method over gRPC.

        Lists devices managed by the enterprise.

        Returns:
            Callable[[~.ListDevicesRequest],
                    Awaitable[~.ListDevicesResponse]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_devices' not in self._stubs:
            self._stubs['list_devices'] = self.grpc_channel.unary_unary(
                '/google.home.enterprise.sdm.v1.SmartDeviceManagementService/ListDevices',
                request_serializer=smart_device_management_service.ListDevicesRequest.serialize,
                response_deserializer=smart_device_management_service.ListDevicesResponse.deserialize,
            )
        return self._stubs['list_devices']

    @property
    def execute_device_command(self) -> Callable[
            [smart_device_management_service.ExecuteDeviceCommandRequest],
            Awaitable[smart_device_management_service.ExecuteDeviceCommandResponse]]:
        r"""Return a callable for the execute device command method over gRPC.

        Executes a command to device managed by the
        enterprise.

        Returns:
            Callable[[~.ExecuteDeviceCommandRequest],
                    Awaitable[~.ExecuteDeviceCommandResponse]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'execute_device_command' not in self._stubs:
            self._stubs['execute_device_command'] = self.grpc_channel.unary_unary(
                '/google.home.enterprise.sdm.v1.SmartDeviceManagementService/ExecuteDeviceCommand',
                request_serializer=smart_device_management_service.ExecuteDeviceCommandRequest.serialize,
                response_deserializer=smart_device_management_service.ExecuteDeviceCommandResponse.deserialize,
            )
        return self._stubs['execute_device_command']

    @property
    def get_structure(self) -> Callable[
            [smart_device_management_service.GetStructureRequest],
            Awaitable[site.Structure]]:
        r"""Return a callable for the get structure method over gRPC.

        Gets a structure managed by the enterprise.

        Returns:
            Callable[[~.GetStructureRequest],
                    Awaitable[~.Structure]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_structure' not in self._stubs:
            self._stubs['get_structure'] = self.grpc_channel.unary_unary(
                '/google.home.enterprise.sdm.v1.SmartDeviceManagementService/GetStructure',
                request_serializer=smart_device_management_service.GetStructureRequest.serialize,
                response_deserializer=site.Structure.deserialize,
            )
        return self._stubs['get_structure']

    @property
    def list_structures(self) -> Callable[
            [smart_device_management_service.ListStructuresRequest],
            Awaitable[smart_device_management_service.ListStructuresResponse]]:
        r"""Return a callable for the list structures method over gRPC.

        Lists structures managed by the enterprise.

        Returns:
            Callable[[~.ListStructuresRequest],
                    Awaitable[~.ListStructuresResponse]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_structures' not in self._stubs:
            self._stubs['list_structures'] = self.grpc_channel.unary_unary(
                '/google.home.enterprise.sdm.v1.SmartDeviceManagementService/ListStructures',
                request_serializer=smart_device_management_service.ListStructuresRequest.serialize,
                response_deserializer=smart_device_management_service.ListStructuresResponse.deserialize,
            )
        return self._stubs['list_structures']

    @property
    def get_room(self) -> Callable[
            [smart_device_management_service.GetRoomRequest],
            Awaitable[site.Room]]:
        r"""Return a callable for the get room method over gRPC.

        Gets a room managed by the enterprise.

        Returns:
            Callable[[~.GetRoomRequest],
                    Awaitable[~.Room]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_room' not in self._stubs:
            self._stubs['get_room'] = self.grpc_channel.unary_unary(
                '/google.home.enterprise.sdm.v1.SmartDeviceManagementService/GetRoom',
                request_serializer=smart_device_management_service.GetRoomRequest.serialize,
                response_deserializer=site.Room.deserialize,
            )
        return self._stubs['get_room']

    @property
    def list_rooms(self) -> Callable[
            [smart_device_management_service.ListRoomsRequest],
            Awaitable[smart_device_management_service.ListRoomsResponse]]:
        r"""Return a callable for the list rooms method over gRPC.

        Lists rooms managed by the enterprise.

        Returns:
            Callable[[~.ListRoomsRequest],
                    Awaitable[~.ListRoomsResponse]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_rooms' not in self._stubs:
            self._stubs['list_rooms'] = self.grpc_channel.unary_unary(
                '/google.home.enterprise.sdm.v1.SmartDeviceManagementService/ListRooms',
                request_serializer=smart_device_management_service.ListRoomsRequest.serialize,
                response_deserializer=smart_device_management_service.ListRoomsResponse.deserialize,
            )
        return self._stubs['list_rooms']


__all__ = (
    'SmartDeviceManagementServiceGrpcAsyncIOTransport',
)
