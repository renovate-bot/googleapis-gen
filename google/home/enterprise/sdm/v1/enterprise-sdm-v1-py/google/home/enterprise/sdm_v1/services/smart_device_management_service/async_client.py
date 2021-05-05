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

import google.api_core.client_options as ClientOptions # type: ignore
from google.api_core import exceptions as core_exceptions  # type: ignore
from google.api_core import gapic_v1                   # type: ignore
from google.api_core import retry as retries           # type: ignore
from google.auth import credentials as ga_credentials   # type: ignore
from google.oauth2 import service_account              # type: ignore

from google.home.enterprise.sdm_v1.services.smart_device_management_service import pagers
from google.home.enterprise.sdm_v1.types import device
from google.home.enterprise.sdm_v1.types import site
from google.home.enterprise.sdm_v1.types import smart_device_management_service
from google.protobuf import struct_pb2  # type: ignore
from .transports.base import SmartDeviceManagementServiceTransport, DEFAULT_CLIENT_INFO
from .transports.grpc_asyncio import SmartDeviceManagementServiceGrpcAsyncIOTransport
from .client import SmartDeviceManagementServiceClient


class SmartDeviceManagementServiceAsyncClient:
    """A service that allows API consumers to provision and manage
    Google Home structures and devices for enterprise use cases.
    """

    _client: SmartDeviceManagementServiceClient

    DEFAULT_ENDPOINT = SmartDeviceManagementServiceClient.DEFAULT_ENDPOINT
    DEFAULT_MTLS_ENDPOINT = SmartDeviceManagementServiceClient.DEFAULT_MTLS_ENDPOINT

    device_path = staticmethod(SmartDeviceManagementServiceClient.device_path)
    parse_device_path = staticmethod(SmartDeviceManagementServiceClient.parse_device_path)
    room_path = staticmethod(SmartDeviceManagementServiceClient.room_path)
    parse_room_path = staticmethod(SmartDeviceManagementServiceClient.parse_room_path)
    structure_path = staticmethod(SmartDeviceManagementServiceClient.structure_path)
    parse_structure_path = staticmethod(SmartDeviceManagementServiceClient.parse_structure_path)
    common_billing_account_path = staticmethod(SmartDeviceManagementServiceClient.common_billing_account_path)
    parse_common_billing_account_path = staticmethod(SmartDeviceManagementServiceClient.parse_common_billing_account_path)
    common_folder_path = staticmethod(SmartDeviceManagementServiceClient.common_folder_path)
    parse_common_folder_path = staticmethod(SmartDeviceManagementServiceClient.parse_common_folder_path)
    common_organization_path = staticmethod(SmartDeviceManagementServiceClient.common_organization_path)
    parse_common_organization_path = staticmethod(SmartDeviceManagementServiceClient.parse_common_organization_path)
    common_project_path = staticmethod(SmartDeviceManagementServiceClient.common_project_path)
    parse_common_project_path = staticmethod(SmartDeviceManagementServiceClient.parse_common_project_path)
    common_location_path = staticmethod(SmartDeviceManagementServiceClient.common_location_path)
    parse_common_location_path = staticmethod(SmartDeviceManagementServiceClient.parse_common_location_path)

    @classmethod
    def from_service_account_info(cls, info: dict, *args, **kwargs):
        """Creates an instance of this client using the provided credentials info.

        Args:
            info (dict): The service account private key info.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            SmartDeviceManagementServiceAsyncClient: The constructed client.
        """
        return SmartDeviceManagementServiceClient.from_service_account_info.__func__(SmartDeviceManagementServiceAsyncClient, info, *args, **kwargs)  # type: ignore

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
            SmartDeviceManagementServiceAsyncClient: The constructed client.
        """
        return SmartDeviceManagementServiceClient.from_service_account_file.__func__(SmartDeviceManagementServiceAsyncClient, filename, *args, **kwargs)  # type: ignore

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> SmartDeviceManagementServiceTransport:
        """Return the transport used by the client instance.

        Returns:
            SmartDeviceManagementServiceTransport: The transport used by the client instance.
        """
        return self._client.transport

    get_transport_class = functools.partial(type(SmartDeviceManagementServiceClient).get_transport_class, type(SmartDeviceManagementServiceClient))

    def __init__(self, *,
            credentials: ga_credentials.Credentials = None,
            transport: Union[str, SmartDeviceManagementServiceTransport] = 'grpc_asyncio',
            client_options: ClientOptions = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiate the smart device management service client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, ~.SmartDeviceManagementServiceTransport]): The
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
        self._client = SmartDeviceManagementServiceClient(
            credentials=credentials,
            transport=transport,
            client_options=client_options,
            client_info=client_info,

        )

    async def get_device(self,
            request: smart_device_management_service.GetDeviceRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> device.Device:
        r"""Gets a device managed by the enterprise.

        Args:
            request (:class:`google.home.enterprise.sdm_v1.types.GetDeviceRequest`):
                The request object. Request message for
                SmartDeviceManagementService.GetDevice
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.home.enterprise.sdm_v1.types.Device:
                Device resource represents an
                instance of enterprise managed device in
                the property.

        """
        # Create or coerce a protobuf request object.
        request = smart_device_management_service.GetDeviceRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_device,
            default_retry=retries.Retry(
initial=1.0,maximum=10.0,multiplier=1.3,                predicate=retries.if_exception_type(
                    exceptions.ServiceUnavailable,
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
                ('name', request.name),
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

    async def list_devices(self,
            request: smart_device_management_service.ListDevicesRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListDevicesAsyncPager:
        r"""Lists devices managed by the enterprise.

        Args:
            request (:class:`google.home.enterprise.sdm_v1.types.ListDevicesRequest`):
                The request object. Request message for
                SmartDeviceManagementService.ListDevices
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.home.enterprise.sdm_v1.services.smart_device_management_service.pagers.ListDevicesAsyncPager:
                Response message for
                SmartDeviceManagementService.ListDevices
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        request = smart_device_management_service.ListDevicesRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_devices,
            default_retry=retries.Retry(
initial=1.0,maximum=10.0,multiplier=1.3,                predicate=retries.if_exception_type(
                    exceptions.ServiceUnavailable,
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
                ('parent', request.parent),
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
        response = pagers.ListDevicesAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def execute_device_command(self,
            request: smart_device_management_service.ExecuteDeviceCommandRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> smart_device_management_service.ExecuteDeviceCommandResponse:
        r"""Executes a command to device managed by the
        enterprise.

        Args:
            request (:class:`google.home.enterprise.sdm_v1.types.ExecuteDeviceCommandRequest`):
                The request object. Request message for
                SmartDeviceManagementService.ExecuteDeviceCommand
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.home.enterprise.sdm_v1.types.ExecuteDeviceCommandResponse:
                Response message for
                SmartDeviceManagementService.ExecuteDeviceCommand

        """
        # Create or coerce a protobuf request object.
        request = smart_device_management_service.ExecuteDeviceCommandRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.execute_device_command,
            default_timeout=60.0,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('name', request.name),
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

    async def get_structure(self,
            request: smart_device_management_service.GetStructureRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> site.Structure:
        r"""Gets a structure managed by the enterprise.

        Args:
            request (:class:`google.home.enterprise.sdm_v1.types.GetStructureRequest`):
                The request object. Request message for
                SmartDeviceManagementService.GetStructure
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.home.enterprise.sdm_v1.types.Structure:
                Structure resource represents an
                instance of enterprise managed home or
                hotel room.

        """
        # Create or coerce a protobuf request object.
        request = smart_device_management_service.GetStructureRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_structure,
            default_retry=retries.Retry(
initial=1.0,maximum=10.0,multiplier=1.3,                predicate=retries.if_exception_type(
                    exceptions.ServiceUnavailable,
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
                ('name', request.name),
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

    async def list_structures(self,
            request: smart_device_management_service.ListStructuresRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListStructuresAsyncPager:
        r"""Lists structures managed by the enterprise.

        Args:
            request (:class:`google.home.enterprise.sdm_v1.types.ListStructuresRequest`):
                The request object. Request message for
                SmartDeviceManagementService.ListStructures
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.home.enterprise.sdm_v1.services.smart_device_management_service.pagers.ListStructuresAsyncPager:
                Response message for
                SmartDeviceManagementService.ListStructures
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        request = smart_device_management_service.ListStructuresRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_structures,
            default_retry=retries.Retry(
initial=1.0,maximum=10.0,multiplier=1.3,                predicate=retries.if_exception_type(
                    exceptions.ServiceUnavailable,
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
                ('parent', request.parent),
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
        response = pagers.ListStructuresAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def get_room(self,
            request: smart_device_management_service.GetRoomRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> site.Room:
        r"""Gets a room managed by the enterprise.

        Args:
            request (:class:`google.home.enterprise.sdm_v1.types.GetRoomRequest`):
                The request object. Request message for
                SmartDeviceManagementService.GetRoom
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.home.enterprise.sdm_v1.types.Room:
                Room resource represents an instance
                of sub-space within a structure such as
                rooms in a hotel suite or rental
                apartment.

        """
        # Create or coerce a protobuf request object.
        request = smart_device_management_service.GetRoomRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_room,
            default_retry=retries.Retry(
initial=1.0,maximum=10.0,multiplier=1.3,                predicate=retries.if_exception_type(
                    exceptions.ServiceUnavailable,
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
                ('name', request.name),
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

    async def list_rooms(self,
            request: smart_device_management_service.ListRoomsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListRoomsAsyncPager:
        r"""Lists rooms managed by the enterprise.

        Args:
            request (:class:`google.home.enterprise.sdm_v1.types.ListRoomsRequest`):
                The request object. Request message for
                SmartDeviceManagementService.ListRooms
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.home.enterprise.sdm_v1.services.smart_device_management_service.pagers.ListRoomsAsyncPager:
                Response message for
                SmartDeviceManagementService.ListRooms
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        request = smart_device_management_service.ListRoomsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_rooms,
            default_retry=retries.Retry(
initial=1.0,maximum=10.0,multiplier=1.3,                predicate=retries.if_exception_type(
                    exceptions.ServiceUnavailable,
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
                ('parent', request.parent),
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
        response = pagers.ListRoomsAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response





try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            'google-home-enterprise-sdm',
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    'SmartDeviceManagementServiceAsyncClient',
)
