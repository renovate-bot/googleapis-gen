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

from google.api_core.client_options import ClientOptions # type: ignore
from google.api_core import exceptions as core_exceptions  # type: ignore
from google.api_core import gapic_v1                   # type: ignore
from google.api_core import retry as retries           # type: ignore
from google.auth import credentials as ga_credentials   # type: ignore
from google.oauth2 import service_account              # type: ignore

OptionalRetry = Union[retries.Retry, object]

from google.maps.roads_v1.types import roads
from .transports.base import RoadsServiceTransport, DEFAULT_CLIENT_INFO
from .transports.grpc_asyncio import RoadsServiceGrpcAsyncIOTransport
from .client import RoadsServiceClient


class RoadsServiceAsyncClient:
    """"""

    _client: RoadsServiceClient

    DEFAULT_ENDPOINT = RoadsServiceClient.DEFAULT_ENDPOINT
    DEFAULT_MTLS_ENDPOINT = RoadsServiceClient.DEFAULT_MTLS_ENDPOINT

    common_billing_account_path = staticmethod(RoadsServiceClient.common_billing_account_path)
    parse_common_billing_account_path = staticmethod(RoadsServiceClient.parse_common_billing_account_path)
    common_folder_path = staticmethod(RoadsServiceClient.common_folder_path)
    parse_common_folder_path = staticmethod(RoadsServiceClient.parse_common_folder_path)
    common_organization_path = staticmethod(RoadsServiceClient.common_organization_path)
    parse_common_organization_path = staticmethod(RoadsServiceClient.parse_common_organization_path)
    common_project_path = staticmethod(RoadsServiceClient.common_project_path)
    parse_common_project_path = staticmethod(RoadsServiceClient.parse_common_project_path)
    common_location_path = staticmethod(RoadsServiceClient.common_location_path)
    parse_common_location_path = staticmethod(RoadsServiceClient.parse_common_location_path)

    @classmethod
    def from_service_account_info(cls, info: dict, *args, **kwargs):
        """Creates an instance of this client using the provided credentials
            info.

        Args:
            info (dict): The service account private key info.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            RoadsServiceAsyncClient: The constructed client.
        """
        return RoadsServiceClient.from_service_account_info.__func__(RoadsServiceAsyncClient, info, *args, **kwargs)  # type: ignore

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
            RoadsServiceAsyncClient: The constructed client.
        """
        return RoadsServiceClient.from_service_account_file.__func__(RoadsServiceAsyncClient, filename, *args, **kwargs)  # type: ignore

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> RoadsServiceTransport:
        """Returns the transport used by the client instance.

        Returns:
            RoadsServiceTransport: The transport used by the client instance.
        """
        return self._client.transport

    get_transport_class = functools.partial(type(RoadsServiceClient).get_transport_class, type(RoadsServiceClient))

    def __init__(self, *,
            credentials: ga_credentials.Credentials = None,
            transport: Union[str, RoadsServiceTransport] = "grpc_asyncio",
            client_options: ClientOptions = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiates the roads service client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, ~.RoadsServiceTransport]): The
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
        self._client = RoadsServiceClient(
            credentials=credentials,
            transport=transport,
            client_options=client_options,
            client_info=client_info,

        )

    async def snap_to_roads(self,
            request: Union[roads.SnapToRoadsRequest, dict] = None,
            *,
            path: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> roads.SnapToRoadsResponse:
        r"""This method takes a sequence of latitude,longitude
        points and snaps them to the most likely road segments.
        Optionally returns additional points giving the full
        road geometry. Also returns a place ID for each snapped
        point.

        Args:
            request (Union[google.maps.roads_v1.types.SnapToRoadsRequest, dict]):
                The request object. A request to the SnapToRoads method,
                requesting that a sequence of points be snapped to road
                segments.
            path (:class:`str`):
                The path to be snapped as a series of lat, lng points.
                Specified as a string of the format: lat,lng|lat,lng|...

                This corresponds to the ``path`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.maps.roads_v1.types.SnapToRoadsResponse:
                The response from the SnapToRoads
                method, returning a sequence of snapped
                points.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([path])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = roads.SnapToRoadsRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if path is not None:
            request.path = path

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.snap_to_roads,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
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

    async def list_nearest_roads(self,
            request: Union[roads.ListNearestRoadsRequest, dict] = None,
            *,
            points: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> roads.ListNearestRoadsResponse:
        r"""This method takes a list of latitude,longitude points
        and snaps them each to their nearest road. Also returns
        a place ID for each snapped point.

        Args:
            request (Union[google.maps.roads_v1.types.ListNearestRoadsRequest, dict]):
                The request object. A request to the ListNearestRoads
                method, requesting that a sequence of points be snapped
                individually to the road segment that each is closest
                to.
            points (:class:`str`):
                The points to be snapped as a series of lat, lng points.
                Specified as a string of the format: lat,lng|lat,lng|...

                This corresponds to the ``points`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.maps.roads_v1.types.ListNearestRoadsResponse:
                The response from the
                ListNearestRoads method, returning a
                list of snapped points.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([points])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = roads.ListNearestRoadsRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if points is not None:
            request.points = points

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_nearest_roads,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
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

    async def __aenter__(self):
        return self

    async def __aexit__(self, exc_type, exc, tb):
        await self.transport.close()

try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            "google-maps-roads",
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    "RoadsServiceAsyncClient",
)
