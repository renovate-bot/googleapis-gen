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

from google.home.graph_v1.types import homegraph
from .transports.base import HomeGraphApiServiceTransport, DEFAULT_CLIENT_INFO
from .transports.grpc_asyncio import HomeGraphApiServiceGrpcAsyncIOTransport
from .client import HomeGraphApiServiceClient


class HomeGraphApiServiceAsyncClient:
    """Google Home Graph API service. The Home Graph service provides
    support for accessing first-party and third-party devices stored in
    Google's Home Graph. The Home Graph database provides contextual
    data about the relationships between devices and the home.

    For more details, see the `Home Graph developer
    guide <https://developers.google.com/assistant/smarthome/concepts/homegraph>`__.
    """

    _client: HomeGraphApiServiceClient

    DEFAULT_ENDPOINT = HomeGraphApiServiceClient.DEFAULT_ENDPOINT
    DEFAULT_MTLS_ENDPOINT = HomeGraphApiServiceClient.DEFAULT_MTLS_ENDPOINT

    agent_user_path_path = staticmethod(HomeGraphApiServiceClient.agent_user_path_path)
    parse_agent_user_path_path = staticmethod(HomeGraphApiServiceClient.parse_agent_user_path_path)
    common_billing_account_path = staticmethod(HomeGraphApiServiceClient.common_billing_account_path)
    parse_common_billing_account_path = staticmethod(HomeGraphApiServiceClient.parse_common_billing_account_path)
    common_folder_path = staticmethod(HomeGraphApiServiceClient.common_folder_path)
    parse_common_folder_path = staticmethod(HomeGraphApiServiceClient.parse_common_folder_path)
    common_organization_path = staticmethod(HomeGraphApiServiceClient.common_organization_path)
    parse_common_organization_path = staticmethod(HomeGraphApiServiceClient.parse_common_organization_path)
    common_project_path = staticmethod(HomeGraphApiServiceClient.common_project_path)
    parse_common_project_path = staticmethod(HomeGraphApiServiceClient.parse_common_project_path)
    common_location_path = staticmethod(HomeGraphApiServiceClient.common_location_path)
    parse_common_location_path = staticmethod(HomeGraphApiServiceClient.parse_common_location_path)

    @classmethod
    def from_service_account_info(cls, info: dict, *args, **kwargs):
        """Creates an instance of this client using the provided credentials
            info.

        Args:
            info (dict): The service account private key info.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            HomeGraphApiServiceAsyncClient: The constructed client.
        """
        return HomeGraphApiServiceClient.from_service_account_info.__func__(HomeGraphApiServiceAsyncClient, info, *args, **kwargs)  # type: ignore

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
            HomeGraphApiServiceAsyncClient: The constructed client.
        """
        return HomeGraphApiServiceClient.from_service_account_file.__func__(HomeGraphApiServiceAsyncClient, filename, *args, **kwargs)  # type: ignore

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> HomeGraphApiServiceTransport:
        """Returns the transport used by the client instance.

        Returns:
            HomeGraphApiServiceTransport: The transport used by the client instance.
        """
        return self._client.transport

    get_transport_class = functools.partial(type(HomeGraphApiServiceClient).get_transport_class, type(HomeGraphApiServiceClient))

    def __init__(self, *,
            credentials: ga_credentials.Credentials = None,
            transport: Union[str, HomeGraphApiServiceTransport] = "grpc_asyncio",
            client_options: ClientOptions = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiates the home graph api service client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, ~.HomeGraphApiServiceTransport]): The
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
        self._client = HomeGraphApiServiceClient(
            credentials=credentials,
            transport=transport,
            client_options=client_options,
            client_info=client_info,

        )

    async def request_sync_devices(self,
            request: homegraph.RequestSyncDevicesRequest = None,
            *,
            agent_user_id: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> homegraph.RequestSyncDevicesResponse:
        r"""Requests Google to send an ``action.devices.SYNC``
        `intent <https://developers.google.com/assistant/smarthome/reference/intent/sync>`__
        to your smart home Action to update device metadata for the
        given user.

        The third-party user's identity is passed via the
        ``agent_user_id`` (see
        [RequestSyncDevicesRequest][google.home.graph.v1.RequestSyncDevicesRequest]).
        This request must be authorized using service account
        credentials from your Actions console project.

        Args:
            request (:class:`google.home.graph_v1.types.RequestSyncDevicesRequest`):
                The request object. Request type for the
                [`RequestSyncDevices`](#google.home.graph.v1.HomeGraphApiService.RequestSyncDevices)
                call.
            agent_user_id (:class:`str`):
                Required. Third-party user ID.
                This corresponds to the ``agent_user_id`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.home.graph_v1.types.RequestSyncDevicesResponse:
                Response type for the
                   [RequestSyncDevices](#google.home.graph.v1.HomeGraphApiService.RequestSyncDevices)
                   call.

                   Intentionally empty upon success. An HTTP response
                   code is returned with more details upon failure.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([agent_user_id])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = homegraph.RequestSyncDevicesRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if agent_user_id is not None:
            request.agent_user_id = agent_user_id

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.request_sync_devices,
            default_timeout=10.0,
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

    async def report_state_and_notification(self,
            request: homegraph.ReportStateAndNotificationRequest = None,
            *,
            request_id: str = None,
            event_id: str = None,
            agent_user_id: str = None,
            payload: homegraph.StateAndNotificationPayload = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> homegraph.ReportStateAndNotificationResponse:
        r"""Reports device state and optionally sends device notifications.
        Called by your smart home Action when the state of a third-party
        device changes or you need to send a notification about the
        device. See `Implement Report
        State <https://developers.google.com/assistant/smarthome/develop/report-state>`__
        for more information.

        This method updates the device state according to its declared
        `traits <https://developers.google.com/assistant/smarthome/concepts/devices-traits>`__.
        Publishing a new state value outside of these traits will result
        in an ``INVALID_ARGUMENT`` error response.

        The third-party user's identity is passed in via the
        ``agent_user_id`` (see
        [ReportStateAndNotificationRequest][google.home.graph.v1.ReportStateAndNotificationRequest]).
        This request must be authorized using service account
        credentials from your Actions console project.

        Args:
            request (:class:`google.home.graph_v1.types.ReportStateAndNotificationRequest`):
                The request object. Request type for the
                [`ReportStateAndNotification`](#google.home.graph.v1.HomeGraphApiService.ReportStateAndNotification)
                call. It may include states, notifications, or both.
                States and notifications are defined per `device_id`
                (for example, "123" and "456" in the following example).
                # Example

                ```json
                {
                  "requestId": "ff36a3cc-ec34-11e6-b1a0-64510650abcf",
                "agentUserId": "1234",
                  "payload": {
                    "devices": {
                      "states": {
                        "123": {
                          "on": true
                        },
                        "456": {
                          "on": true,
                          "brightness": 10
                        }
                      },
                    }
                  }
                }
                ```
            request_id (:class:`str`):
                Request ID used for debugging.
                This corresponds to the ``request_id`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            event_id (:class:`str`):
                Unique identifier per event (for
                example, a doorbell press).

                This corresponds to the ``event_id`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            agent_user_id (:class:`str`):
                Required. Third-party user ID.
                This corresponds to the ``agent_user_id`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            payload (:class:`google.home.graph_v1.types.StateAndNotificationPayload`):
                Required. State of devices to update
                and notification metadata for devices.

                This corresponds to the ``payload`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.home.graph_v1.types.ReportStateAndNotificationResponse:
                Response type for the
                   [ReportStateAndNotification](#google.home.graph.v1.HomeGraphApiService.ReportStateAndNotification)
                   call.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([request_id, event_id, agent_user_id, payload])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = homegraph.ReportStateAndNotificationRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if request_id is not None:
            request.request_id = request_id
        if event_id is not None:
            request.event_id = event_id
        if agent_user_id is not None:
            request.agent_user_id = agent_user_id
        if payload is not None:
            request.payload = payload

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.report_state_and_notification,
            default_timeout=10.0,
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

    async def delete_agent_user(self,
            request: homegraph.DeleteAgentUserRequest = None,
            *,
            request_id: str = None,
            agent_user_id: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> None:
        r"""Unlinks the given third-party user from your smart home Action.
        All data related to this user will be deleted.

        For more details on how users link their accounts, see
        `fulfillment and
        authentication <https://developers.google.com/assistant/smarthome/concepts/fulfillment-authentication>`__.

        The third-party user's identity is passed in via the
        ``agent_user_id`` (see
        [DeleteAgentUserRequest][google.home.graph.v1.DeleteAgentUserRequest]).
        This request must be authorized using service account
        credentials from your Actions console project.

        Args:
            request (:class:`google.home.graph_v1.types.DeleteAgentUserRequest`):
                The request object. Request type for the
                [`DeleteAgentUser`](#google.home.graph.v1.HomeGraphApiService.DeleteAgentUser)
                call.
            request_id (:class:`str`):
                Request ID used for debugging.
                This corresponds to the ``request_id`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            agent_user_id (:class:`str`):
                Required. Third-party user ID.
                This corresponds to the ``agent_user_id`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([request_id, agent_user_id])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = homegraph.DeleteAgentUserRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if request_id is not None:
            request.request_id = request_id
        if agent_user_id is not None:
            request.agent_user_id = agent_user_id

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.delete_agent_user,
            default_retry=retries.Retry(
initial=0.1,maximum=60.0,multiplier=1.3,                predicate=retries.if_exception_type(
                    core_exceptions.DeadlineExceeded,
                    core_exceptions.ServiceUnavailable,
                ),
                deadline=10.0,
            ),
            default_timeout=10.0,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("agent_user_id", request.agent_user_id),
            )),
        )

        # Send the request.
        await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    async def query(self,
            request: homegraph.QueryRequest = None,
            *,
            request_id: str = None,
            agent_user_id: str = None,
            inputs: Sequence[homegraph.QueryRequestInput] = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> homegraph.QueryResponse:
        r"""Gets the current states in Home Graph for the given set of the
        third-party user's devices.

        The third-party user's identity is passed in via the
        ``agent_user_id`` (see
        [QueryRequest][google.home.graph.v1.QueryRequest]). This request
        must be authorized using service account credentials from your
        Actions console project.

        Args:
            request (:class:`google.home.graph_v1.types.QueryRequest`):
                The request object. Request type for the
                [`Query`](#google.home.graph.v1.HomeGraphApiService.Query)
                call.
            request_id (:class:`str`):
                Request ID used for debugging.
                This corresponds to the ``request_id`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            agent_user_id (:class:`str`):
                Required. Third-party user ID.
                This corresponds to the ``agent_user_id`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            inputs (:class:`Sequence[google.home.graph_v1.types.QueryRequestInput]`):
                Required. Inputs containing third-
                arty device IDs for which to get the
                device states.

                This corresponds to the ``inputs`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.home.graph_v1.types.QueryResponse:
                Response type for the
                   [Query](#google.home.graph.v1.HomeGraphApiService.Query)
                   call. This should follow the same format as the
                   Google smart home action.devices.QUERY
                   [response](https://developers.google.com/assistant/smarthome/reference/intent/query).
                   # Example

                   :literal:`\`json {   "requestId": "ff36a3cc-ec34-11e6-b1a0-64510650abcf",   "payload": {     "devices": {       "123": {         "on": true,         "online": true       },       "456": {         "on": true,         "online": true,         "brightness": 80,         "color": {           "name": "cerulean",           "spectrumRGB": 31655         }       }     }   } }`\ \`

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([request_id, agent_user_id, inputs])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = homegraph.QueryRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if request_id is not None:
            request.request_id = request_id
        if agent_user_id is not None:
            request.agent_user_id = agent_user_id
        if inputs:
            request.inputs.extend(inputs)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.query,
            default_retry=retries.Retry(
initial=0.1,maximum=60.0,multiplier=1.3,                predicate=retries.if_exception_type(
                    core_exceptions.DeadlineExceeded,
                    core_exceptions.ServiceUnavailable,
                ),
                deadline=10.0,
            ),
            default_timeout=10.0,
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

    async def sync(self,
            request: homegraph.SyncRequest = None,
            *,
            request_id: str = None,
            agent_user_id: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> homegraph.SyncResponse:
        r"""Gets all the devices associated with the given third-party user.

        The third-party user's identity is passed in via the
        ``agent_user_id`` (see
        [SyncRequest][google.home.graph.v1.SyncRequest]). This request
        must be authorized using service account credentials from your
        Actions console project.

        Args:
            request (:class:`google.home.graph_v1.types.SyncRequest`):
                The request object. Request type for the
                [`Sync`](#google.home.graph.v1.HomeGraphApiService.Sync)
                call.
            request_id (:class:`str`):
                Request ID used for debugging.
                This corresponds to the ``request_id`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            agent_user_id (:class:`str`):
                Required. Third-party user ID.
                This corresponds to the ``agent_user_id`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.home.graph_v1.types.SyncResponse:
                Response type for the
                   [Sync](#google.home.graph.v1.HomeGraphApiService.Sync)
                   call. This should follow the same format as the
                   Google smart home action.devices.SYNC
                   [response](https://developers.google.com/assistant/smarthome/reference/intent/sync).
                   # Example

                   :literal:`\`json {   "requestId": "ff36a3cc-ec34-11e6-b1a0-64510650abcf",   "payload": {     "agentUserId": "1836.15267389",     "devices": [{       "id": "123",       "type": "action.devices.types.OUTLET",       "traits": [         "action.devices.traits.OnOff"       ],       "name": {         "defaultNames": ["My Outlet 1234"],         "name": "Night light",         "nicknames": ["wall plug"]       },       "willReportState": false,       "deviceInfo": {         "manufacturer": "lights-out-inc",         "model": "hs1234",         "hwVersion": "3.2",         "swVersion": "11.4"       },       "customData": {         "fooValue": 74,         "barValue": true,         "bazValue": "foo"       }     }]   } }`\ \`

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([request_id, agent_user_id])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = homegraph.SyncRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if request_id is not None:
            request.request_id = request_id
        if agent_user_id is not None:
            request.agent_user_id = agent_user_id

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.sync,
            default_retry=retries.Retry(
initial=0.1,maximum=60.0,multiplier=1.3,                predicate=retries.if_exception_type(
                    core_exceptions.DeadlineExceeded,
                    core_exceptions.ServiceUnavailable,
                ),
                deadline=10.0,
            ),
            default_timeout=10.0,
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
            "google-home-graph",
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    "HomeGraphApiServiceAsyncClient",
)
