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
from collections import OrderedDict
import functools
import re
from typing import Dict, Sequence, Tuple, Type, Union
import pkg_resources
import warnings

import google.api_core.client_options as ClientOptions # type: ignore
from google.api_core import exceptions as core_exceptions  # type: ignore
from google.api_core import gapic_v1                   # type: ignore
from google.api_core import retry as retries           # type: ignore
from google.auth import credentials as ga_credentials   # type: ignore
from google.oauth2 import service_account              # type: ignore

from google.protobuf import timestamp_pb2  # type: ignore
from google.protobuf import wrappers_pb2  # type: ignore
from google.type import latlng_pb2  # type: ignore
from maps.fleetengine_v1.services.vehicle_service import pagers
from maps.fleetengine_v1.types import fleetengine
from maps.fleetengine_v1.types import vehicle_api
from maps.fleetengine_v1.types import vehicles
from .transports.base import VehicleServiceTransport, DEFAULT_CLIENT_INFO
from .transports.grpc_asyncio import VehicleServiceGrpcAsyncIOTransport
from .client import VehicleServiceClient


class VehicleServiceAsyncClient:
    """Vehicle management service."""

    _client: VehicleServiceClient

    DEFAULT_ENDPOINT = VehicleServiceClient.DEFAULT_ENDPOINT
    DEFAULT_MTLS_ENDPOINT = VehicleServiceClient.DEFAULT_MTLS_ENDPOINT

    vehicle_path = staticmethod(VehicleServiceClient.vehicle_path)
    parse_vehicle_path = staticmethod(VehicleServiceClient.parse_vehicle_path)
    common_billing_account_path = staticmethod(VehicleServiceClient.common_billing_account_path)
    parse_common_billing_account_path = staticmethod(VehicleServiceClient.parse_common_billing_account_path)
    common_folder_path = staticmethod(VehicleServiceClient.common_folder_path)
    parse_common_folder_path = staticmethod(VehicleServiceClient.parse_common_folder_path)
    common_organization_path = staticmethod(VehicleServiceClient.common_organization_path)
    parse_common_organization_path = staticmethod(VehicleServiceClient.parse_common_organization_path)
    common_project_path = staticmethod(VehicleServiceClient.common_project_path)
    parse_common_project_path = staticmethod(VehicleServiceClient.parse_common_project_path)
    common_location_path = staticmethod(VehicleServiceClient.common_location_path)
    parse_common_location_path = staticmethod(VehicleServiceClient.parse_common_location_path)

    @classmethod
    def from_service_account_info(cls, info: dict, *args, **kwargs):
        """Creates an instance of this client using the provided credentials
            info.

        Args:
            info (dict): The service account private key info.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            VehicleServiceAsyncClient: The constructed client.
        """
        return VehicleServiceClient.from_service_account_info.__func__(VehicleServiceAsyncClient, info, *args, **kwargs)  # type: ignore

    @classmethod
    def from_service_account_file(cls, filename: str, *args, **kwargs):
        """Creates an instance of this client using the provided credentials
            file.

        Args:
            filename (str): The path to the service account private key json
                file.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            VehicleServiceAsyncClient: The constructed client.
        """
        return VehicleServiceClient.from_service_account_file.__func__(VehicleServiceAsyncClient, filename, *args, **kwargs)  # type: ignore

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> VehicleServiceTransport:
        """Returns the transport used by the client instance.

        Returns:
            VehicleServiceTransport: The transport used by the client instance.
        """
        return self._client.transport

    get_transport_class = functools.partial(type(VehicleServiceClient).get_transport_class, type(VehicleServiceClient))

    def __init__(self, *,
            credentials: ga_credentials.Credentials = None,
            transport: Union[str, VehicleServiceTransport] = "grpc_asyncio",
            client_options: ClientOptions = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiates the vehicle service client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, ~.VehicleServiceTransport]): The
                transport to use. If set to None, a transport is chosen
                automatically.
            client_options (ClientOptions): Custom options for the client. It
                won't take effect if a ``transport`` instance is provided.
                (1) The ``api_endpoint`` property can be used to override the
                default endpoint provided by the client. GOOGLE_API_USE_MTLS_ENDPOINT
                environment variable can also be used to override the endpoint:
                "always" (always use the default mTLS endpoint), "never" (always
                use the default regular endpoint) and "auto" (auto switch to the
                default mTLS endpoint if client certificate is present, this is
                the default value). However, the ``api_endpoint`` property takes
                precedence if provided.
                (2) If GOOGLE_API_USE_CLIENT_CERTIFICATE environment variable
                is "true", then the ``client_cert_source`` property can be used
                to provide client certificate for mutual TLS transport. If
                not provided, the default SSL client certificate will be used if
                present. If GOOGLE_API_USE_CLIENT_CERTIFICATE is "false" or not
                set, no client certificate will be used.

        Raises:
            google.auth.exceptions.MutualTlsChannelError: If mutual TLS transport
                creation failed for any reason.
        """
        self._client = VehicleServiceClient(
            credentials=credentials,
            transport=transport,
            client_options=client_options,
            client_info=client_info,

        )

    async def create_vehicle(self,
            request: vehicle_api.CreateVehicleRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> vehicles.Vehicle:
        r"""CreateVehicle instantiates a new vehicle associated with a
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

        Args:
            request (:class:`maps.fleetengine_v1.types.CreateVehicleRequest`):
                The request object. CreateVehicle request message.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            maps.fleetengine_v1.types.Vehicle:
                Vehicle metadata.
        """
        # Create or coerce a protobuf request object.
        request = vehicle_api.CreateVehicleRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.create_vehicle,
            default_retry=retries.Retry(
initial=1.0,maximum=10.0,multiplier=1.3,                predicate=retries.if_exception_type(
                    core_exceptions.ServiceUnavailable,
                ),
                deadline=60.0,
            ),
            default_timeout=60.0,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("parent", request.parent),
            )),
        )

        # Send the request.
        response = await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def get_vehicle(self,
            request: vehicle_api.GetVehicleRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> vehicles.Vehicle:
        r"""GetVehicle returns a vehicle from the Fleet Engine.

        Args:
            request (:class:`maps.fleetengine_v1.types.GetVehicleRequest`):
                The request object. GetVehicle request message.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            maps.fleetengine_v1.types.Vehicle:
                Vehicle metadata.
        """
        # Create or coerce a protobuf request object.
        request = vehicle_api.GetVehicleRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_vehicle,
            default_retry=retries.Retry(
initial=1.0,maximum=10.0,multiplier=1.3,                predicate=retries.if_exception_type(
                    core_exceptions.ServiceUnavailable,
                ),
                deadline=60.0,
            ),
            default_timeout=60.0,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
            )),
        )

        # Send the request.
        response = await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def update_vehicle(self,
            request: vehicle_api.UpdateVehicleRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> vehicles.Vehicle:
        r"""UpdateVehicle writes updated vehicle data to the Fleet Engine.

        When updating a Vehicle, the following fields cannot be updated
        since they are managed by the Fleet Engine:

        -  currentTrips
        -  availableCapacity
        -  current_route_segment_version
        -  waypoints_version

        The vehicle name also cannot be updated.

        The waypoints field can be updated, but must contain all the
        waypoints currently on the vehicle, and no other waypoints.

        Args:
            request (:class:`maps.fleetengine_v1.types.UpdateVehicleRequest`):
                The request object. UpdateVehicle request message.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            maps.fleetengine_v1.types.Vehicle:
                Vehicle metadata.
        """
        # Create or coerce a protobuf request object.
        request = vehicle_api.UpdateVehicleRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.update_vehicle,
            default_retry=retries.Retry(
initial=1.0,maximum=10.0,multiplier=1.3,                predicate=retries.if_exception_type(
                    core_exceptions.ServiceUnavailable,
                ),
                deadline=60.0,
            ),
            default_timeout=60.0,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
            )),
        )

        # Send the request.
        response = await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def update_vehicle_location(self,
            request: vehicle_api.UpdateVehicleLocationRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> fleetengine.VehicleLocation:
        r"""UpdateVehicleLocation updates the location of the
        vehicle. This method is deprecated. Use UpdateVehicle
        method instead.

        Args:
            request (:class:`maps.fleetengine_v1.types.UpdateVehicleLocationRequest`):
                The request object. UpdateVehicleLocation request
                message.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            maps.fleetengine_v1.types.VehicleLocation:
                The location, speed, and heading of a
                vehicle at a point in time.

        """
        warnings.warn("VehicleServiceAsyncClient.update_vehicle_location is deprecated",
            DeprecationWarning)

        # Create or coerce a protobuf request object.
        request = vehicle_api.UpdateVehicleLocationRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.update_vehicle_location,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
            )),
        )

        # Send the request.
        response = await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def update_vehicle_attributes(self,
            request: vehicle_api.UpdateVehicleAttributesRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> vehicle_api.UpdateVehicleAttributesResponse:
        r"""UpdateVehicleAttributes partially updates a vehicle's
        attributes. Only the attributes mentioned in the request will be
        updated, other attributes will NOT be altered. Note: this is
        different in UpdateVehicle, where the whole ``attributes`` field
        will be replaced by the one in UpdateVehicleRequest, attributes
        not in the request would be removed.

        Args:
            request (:class:`maps.fleetengine_v1.types.UpdateVehicleAttributesRequest`):
                The request object. UpdateVehicleAttributes request
                message.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            maps.fleetengine_v1.types.UpdateVehicleAttributesResponse:
                UpdateVehicleAttributes response
                message.

        """
        # Create or coerce a protobuf request object.
        request = vehicle_api.UpdateVehicleAttributesRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.update_vehicle_attributes,
            default_retry=retries.Retry(
initial=1.0,maximum=10.0,multiplier=1.3,                predicate=retries.if_exception_type(
                    core_exceptions.ServiceUnavailable,
                ),
                deadline=60.0,
            ),
            default_timeout=60.0,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
            )),
        )

        # Send the request.
        response = await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def list_vehicles(self,
            request: vehicle_api.ListVehiclesRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListVehiclesAsyncPager:
        r"""ListVehicles returns a paginated list of vehicles
        associated with a provider that match the request
        options.

        Args:
            request (:class:`maps.fleetengine_v1.types.ListVehiclesRequest`):
                The request object. ListVehicles request message.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            maps.fleetengine_v1.services.vehicle_service.pagers.ListVehiclesAsyncPager:
                ListVehicles response message.
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        request = vehicle_api.ListVehiclesRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_vehicles,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("parent", request.parent),
            )),
        )

        # Send the request.
        response = await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # This method is paged; wrap the response in a pager, which provides
        # an `__aiter__` convenience method.
        response = pagers.ListVehiclesAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def search_vehicles(self,
            request: vehicle_api.SearchVehiclesRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> vehicle_api.SearchVehiclesResponse:
        r"""SearchVehicles returns a list of vehicles that match
        the request options.

        Args:
            request (:class:`maps.fleetengine_v1.types.SearchVehiclesRequest`):
                The request object. SearchVehicles request message.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            maps.fleetengine_v1.types.SearchVehiclesResponse:
                SearchVehicles response message.
        """
        # Create or coerce a protobuf request object.
        request = vehicle_api.SearchVehiclesRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.search_vehicles,
            default_retry=retries.Retry(
initial=1.0,maximum=10.0,multiplier=1.3,                predicate=retries.if_exception_type(
                    core_exceptions.ServiceUnavailable,
                ),
                deadline=60.0,
            ),
            default_timeout=60.0,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("parent", request.parent),
            )),
        )

        # Send the request.
        response = await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def search_fuzzed_vehicles(self,
            request: vehicle_api.SearchVehiclesRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> vehicle_api.SearchVehiclesResponse:
        r"""SearchFuzzedVehicles returns a list of vehicles that match the
        request options with their locations fuzzed. Request does not
        support 'order_by' field. Vehicle matches in response will be in
        order of distance from pickup point. Vehicle matches in response
        will only have 'vehicle' and 'trip_type' field set.

        Args:
            request (:class:`maps.fleetengine_v1.types.SearchVehiclesRequest`):
                The request object. SearchVehicles request message.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            maps.fleetengine_v1.types.SearchVehiclesResponse:
                SearchVehicles response message.
        """
        # Create or coerce a protobuf request object.
        request = vehicle_api.SearchVehiclesRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.search_fuzzed_vehicles,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("parent", request.parent),
            )),
        )

        # Send the request.
        response = await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response





try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            "maps-fleetengine",
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    "VehicleServiceAsyncClient",
)
