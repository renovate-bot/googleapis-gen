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

from maps.fleetengine_v1.types import fleetengine
from maps.fleetengine_v1.types import vehicle_api
from maps.fleetengine_v1.types import vehicles
from .base import VehicleServiceTransport, DEFAULT_CLIENT_INFO


class VehicleServiceGrpcTransport(VehicleServiceTransport):
    """gRPC backend transport for VehicleService.

    Vehicle management service.

    This class defines the same methods as the primary client, so the
    primary client can load the underlying transport implementation
    and call it.

    It sends protocol buffers over the wire using gRPC (which is built on
    top of HTTP/2); the ``grpcio`` package must be installed.
    """
    _stubs: Dict[str, Callable]

    def __init__(self, *,
            host: str = 'fleetengine.googleapis.com',
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
                       host: str = 'fleetengine.googleapis.com',
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
    def create_vehicle(self) -> Callable[
            [vehicle_api.CreateVehicleRequest],
            vehicles.Vehicle]:
        r"""Return a callable for the create vehicle method over gRPC.

        CreateVehicle instantiates a new vehicle associated with a
        rideshare provider in the Fleet Engine. Vehicles must have a
        unique vehicle ID.

        The following Vehicle fields are required when creating a
        Vehicle:

        -  vehicleState
        -  supportedTripTypes
        -  maximumCapacity
        -  vehicleType

        The following Vehicle fields are ignored when creating a
        Vehicle:

        -  name
        -  currentTrips
        -  availableCapacity
        -  current_route_segment
        -  current_route_segment_version
        -  waypoint
        -  waypoints_version
        -  remaining_distance_meters
        -  eta_to_next_waypoint
        -  navigation_status

        All other fields are optional and used if provided.

        Returns:
            Callable[[~.CreateVehicleRequest],
                    ~.Vehicle]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'create_vehicle' not in self._stubs:
            self._stubs['create_vehicle'] = self.grpc_channel.unary_unary(
                '/maps.fleetengine.v1.VehicleService/CreateVehicle',
                request_serializer=vehicle_api.CreateVehicleRequest.serialize,
                response_deserializer=vehicles.Vehicle.deserialize,
            )
        return self._stubs['create_vehicle']

    @property
    def get_vehicle(self) -> Callable[
            [vehicle_api.GetVehicleRequest],
            vehicles.Vehicle]:
        r"""Return a callable for the get vehicle method over gRPC.

        GetVehicle returns a vehicle from the Fleet Engine.

        Returns:
            Callable[[~.GetVehicleRequest],
                    ~.Vehicle]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_vehicle' not in self._stubs:
            self._stubs['get_vehicle'] = self.grpc_channel.unary_unary(
                '/maps.fleetengine.v1.VehicleService/GetVehicle',
                request_serializer=vehicle_api.GetVehicleRequest.serialize,
                response_deserializer=vehicles.Vehicle.deserialize,
            )
        return self._stubs['get_vehicle']

    @property
    def update_vehicle(self) -> Callable[
            [vehicle_api.UpdateVehicleRequest],
            vehicles.Vehicle]:
        r"""Return a callable for the update vehicle method over gRPC.

        UpdateVehicle writes updated vehicle data to the Fleet Engine.

        When updating a Vehicle, the following fields cannot be updated
        since they are managed by the Fleet Engine:

        -  currentTrips
        -  availableCapacity
        -  current_route_segment_version
        -  waypoints_version

        The vehicle name also cannot be updated.

        The waypoints field can be updated, but must contain all the
        waypoints currently on the vehicle, and no other waypoints.

        Returns:
            Callable[[~.UpdateVehicleRequest],
                    ~.Vehicle]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update_vehicle' not in self._stubs:
            self._stubs['update_vehicle'] = self.grpc_channel.unary_unary(
                '/maps.fleetengine.v1.VehicleService/UpdateVehicle',
                request_serializer=vehicle_api.UpdateVehicleRequest.serialize,
                response_deserializer=vehicles.Vehicle.deserialize,
            )
        return self._stubs['update_vehicle']

    @property
    def update_vehicle_location(self) -> Callable[
            [vehicle_api.UpdateVehicleLocationRequest],
            fleetengine.VehicleLocation]:
        r"""Return a callable for the update vehicle location method over gRPC.

        UpdateVehicleLocation updates the location of the
        vehicle. This method is deprecated. Use UpdateVehicle
        method instead.

        Returns:
            Callable[[~.UpdateVehicleLocationRequest],
                    ~.VehicleLocation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update_vehicle_location' not in self._stubs:
            self._stubs['update_vehicle_location'] = self.grpc_channel.unary_unary(
                '/maps.fleetengine.v1.VehicleService/UpdateVehicleLocation',
                request_serializer=vehicle_api.UpdateVehicleLocationRequest.serialize,
                response_deserializer=fleetengine.VehicleLocation.deserialize,
            )
        return self._stubs['update_vehicle_location']

    @property
    def update_vehicle_attributes(self) -> Callable[
            [vehicle_api.UpdateVehicleAttributesRequest],
            vehicle_api.UpdateVehicleAttributesResponse]:
        r"""Return a callable for the update vehicle attributes method over gRPC.

        UpdateVehicleAttributes partially updates a vehicle's
        attributes. Only the attributes mentioned in the request will be
        updated, other attributes will NOT be altered. Note: this is
        different in UpdateVehicle, where the whole ``attributes`` field
        will be replaced by the one in UpdateVehicleRequest, attributes
        not in the request would be removed.

        Returns:
            Callable[[~.UpdateVehicleAttributesRequest],
                    ~.UpdateVehicleAttributesResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update_vehicle_attributes' not in self._stubs:
            self._stubs['update_vehicle_attributes'] = self.grpc_channel.unary_unary(
                '/maps.fleetengine.v1.VehicleService/UpdateVehicleAttributes',
                request_serializer=vehicle_api.UpdateVehicleAttributesRequest.serialize,
                response_deserializer=vehicle_api.UpdateVehicleAttributesResponse.deserialize,
            )
        return self._stubs['update_vehicle_attributes']

    @property
    def list_vehicles(self) -> Callable[
            [vehicle_api.ListVehiclesRequest],
            vehicle_api.ListVehiclesResponse]:
        r"""Return a callable for the list vehicles method over gRPC.

        ListVehicles returns a paginated list of vehicles
        associated with a provider that match the request
        options.

        Returns:
            Callable[[~.ListVehiclesRequest],
                    ~.ListVehiclesResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_vehicles' not in self._stubs:
            self._stubs['list_vehicles'] = self.grpc_channel.unary_unary(
                '/maps.fleetengine.v1.VehicleService/ListVehicles',
                request_serializer=vehicle_api.ListVehiclesRequest.serialize,
                response_deserializer=vehicle_api.ListVehiclesResponse.deserialize,
            )
        return self._stubs['list_vehicles']

    @property
    def search_vehicles(self) -> Callable[
            [vehicle_api.SearchVehiclesRequest],
            vehicle_api.SearchVehiclesResponse]:
        r"""Return a callable for the search vehicles method over gRPC.

        SearchVehicles returns a list of vehicles that match
        the request options.

        Returns:
            Callable[[~.SearchVehiclesRequest],
                    ~.SearchVehiclesResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'search_vehicles' not in self._stubs:
            self._stubs['search_vehicles'] = self.grpc_channel.unary_unary(
                '/maps.fleetengine.v1.VehicleService/SearchVehicles',
                request_serializer=vehicle_api.SearchVehiclesRequest.serialize,
                response_deserializer=vehicle_api.SearchVehiclesResponse.deserialize,
            )
        return self._stubs['search_vehicles']

    @property
    def search_fuzzed_vehicles(self) -> Callable[
            [vehicle_api.SearchVehiclesRequest],
            vehicle_api.SearchVehiclesResponse]:
        r"""Return a callable for the search fuzzed vehicles method over gRPC.

        SearchFuzzedVehicles returns a list of vehicles that match the
        request options with their locations fuzzed. Request does not
        support 'order_by' field. Vehicle matches in response will be in
        order of distance from pickup point. Vehicle matches in response
        will only have 'vehicle' and 'trip_type' field set.

        Returns:
            Callable[[~.SearchVehiclesRequest],
                    ~.SearchVehiclesResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'search_fuzzed_vehicles' not in self._stubs:
            self._stubs['search_fuzzed_vehicles'] = self.grpc_channel.unary_unary(
                '/maps.fleetengine.v1.VehicleService/SearchFuzzedVehicles',
                request_serializer=vehicle_api.SearchVehiclesRequest.serialize,
                response_deserializer=vehicle_api.SearchVehiclesResponse.deserialize,
            )
        return self._stubs['search_fuzzed_vehicles']


__all__ = (
    'VehicleServiceGrpcTransport',
)
