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

from google.devtools.remoteworkers_v1.types import bots
from google.devtools.remoteworkers_v1.types import worker
from google.protobuf import field_mask_pb2  # type: ignore
from google.protobuf import timestamp_pb2  # type: ignore
from .transports.base import BotsTransport, DEFAULT_CLIENT_INFO
from .transports.grpc_asyncio import BotsGrpcAsyncIOTransport
from .client import BotsClient


class BotsAsyncClient:
    """Design doc: https://goo.gl/oojM5H

    Loosely speaking, the Bots interface monitors a collection of
    workers (think of them as "computers" for a moment). This collection
    is known as a "farm," and its purpose is to perform work on behalf
    of a client.

    Each worker runs a small program known as a "bot" that allows it to
    be controlled by the server. This interface contains only methods
    that are called by the bots themselves; admin functionality is out
    of scope for this interface.

    More precisely, we use the term "worker" to refer to the physical
    "thing" running the bot. We use the term "worker," and not "machine"
    or "computer," since a worker may consist of more than one machine -
    e.g., a computer with multiple attached devices, or even a cluster
    of computers, with only one of them running the bot. Conversely, a
    single machine may host several bots, in which case each bot has a
    "worker" corresponding to the slice of the machine being managed by
    that bot.

    The main resource in the Bots interface is not, surprisingly, a Bot
    - it is a BotSession, which represents a period of time in which a
    bot is in continuous contact with the server (see the BotSession
    message for more information). The parent of a bot session can be
    thought of as an instance of a farm. That is, one endpoint may be
    able to manage many farms for many users. For example, for a farm
    managed through GCP, the parent resource will typically take the
    form "projects/{project_id}". This is referred to below as "the farm
    resource."
    """

    _client: BotsClient

    DEFAULT_ENDPOINT = BotsClient.DEFAULT_ENDPOINT
    DEFAULT_MTLS_ENDPOINT = BotsClient.DEFAULT_MTLS_ENDPOINT

    bot_session_path = staticmethod(BotsClient.bot_session_path)
    parse_bot_session_path = staticmethod(BotsClient.parse_bot_session_path)
    common_billing_account_path = staticmethod(BotsClient.common_billing_account_path)
    parse_common_billing_account_path = staticmethod(BotsClient.parse_common_billing_account_path)
    common_folder_path = staticmethod(BotsClient.common_folder_path)
    parse_common_folder_path = staticmethod(BotsClient.parse_common_folder_path)
    common_organization_path = staticmethod(BotsClient.common_organization_path)
    parse_common_organization_path = staticmethod(BotsClient.parse_common_organization_path)
    common_project_path = staticmethod(BotsClient.common_project_path)
    parse_common_project_path = staticmethod(BotsClient.parse_common_project_path)
    common_location_path = staticmethod(BotsClient.common_location_path)
    parse_common_location_path = staticmethod(BotsClient.parse_common_location_path)

    @classmethod
    def from_service_account_info(cls, info: dict, *args, **kwargs):
        """Creates an instance of this client using the provided credentials info.

        Args:
            info (dict): The service account private key info.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            BotsAsyncClient: The constructed client.
        """
        return BotsClient.from_service_account_info.__func__(BotsAsyncClient, info, *args, **kwargs)  # type: ignore

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
            BotsAsyncClient: The constructed client.
        """
        return BotsClient.from_service_account_file.__func__(BotsAsyncClient, filename, *args, **kwargs)  # type: ignore

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> BotsTransport:
        """Return the transport used by the client instance.

        Returns:
            BotsTransport: The transport used by the client instance.
        """
        return self._client.transport

    get_transport_class = functools.partial(type(BotsClient).get_transport_class, type(BotsClient))

    def __init__(self, *,
            credentials: ga_credentials.Credentials = None,
            transport: Union[str, BotsTransport] = 'grpc_asyncio',
            client_options: ClientOptions = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiate the bots client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, ~.BotsTransport]): The
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
        self._client = BotsClient(
            credentials=credentials,
            transport=transport,
            client_options=client_options,
            client_info=client_info,

        )

    async def create_bot_session(self,
            request: bots.CreateBotSessionRequest = None,
            *,
            parent: str = None,
            bot_session: bots.BotSession = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> bots.BotSession:
        r"""CreateBotSession is called when the bot first joins
        the farm, and establishes a session ID to ensure that
        multiple machines do not register using the same name
        accidentally.

        Args:
            request (:class:`google.devtools.remoteworkers_v1.types.CreateBotSessionRequest`):
                The request object. Request message for
                CreateBotSession.
            parent (:class:`str`):
                Required. The farm resource.
                This corresponds to the ``parent`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            bot_session (:class:`google.devtools.remoteworkers_v1.types.BotSession`):
                Required. The bot session to create.
                Server-assigned fields like name must be
                unset.

                This corresponds to the ``bot_session`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.devtools.remoteworkers_v1.types.BotSession:
                A bot session represents the state of a bot while in continuous contact with
                   the server for a period of time. The session includes
                   information about the worker - that is, the *worker*
                   (the physical or virtual hardware) is considered to
                   be a property of the bot (the software agent running
                   on that hardware), which is the reverse of real life,
                   but more natural from the point of the view of this
                   API, which communicates solely with the bot and not
                   directly with the underlying worker.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([parent, bot_session])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        request = bots.CreateBotSessionRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if parent is not None:
            request.parent = parent
        if bot_session is not None:
            request.bot_session = bot_session

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.create_bot_session,
            default_timeout=600.0,
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

        # Done; return the response.
        return response

    async def update_bot_session(self,
            request: bots.UpdateBotSessionRequest = None,
            *,
            name: str = None,
            bot_session: bots.BotSession = None,
            update_mask: field_mask_pb2.FieldMask = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> bots.BotSession:
        r"""UpdateBotSession must be called periodically by the
        bot (on a schedule determined by the server) to let the
        server know about its status, and to pick up new lease
        requests from the server.

        Args:
            request (:class:`google.devtools.remoteworkers_v1.types.UpdateBotSessionRequest`):
                The request object. Request message for
                UpdateBotSession.
            name (:class:`str`):
                Required. The bot session name. Must match
                bot_session.name.

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            bot_session (:class:`google.devtools.remoteworkers_v1.types.BotSession`):
                Required. The bot session resource to
                update.

                This corresponds to the ``bot_session`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            update_mask (:class:`google.protobuf.field_mask_pb2.FieldMask`):
                Required. The fields on the bot that
                should be updated. See the BotSession
                resource for which fields are updatable
                by which caller.

                This corresponds to the ``update_mask`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.devtools.remoteworkers_v1.types.BotSession:
                A bot session represents the state of a bot while in continuous contact with
                   the server for a period of time. The session includes
                   information about the worker - that is, the *worker*
                   (the physical or virtual hardware) is considered to
                   be a property of the bot (the software agent running
                   on that hardware), which is the reverse of real life,
                   but more natural from the point of the view of this
                   API, which communicates solely with the bot and not
                   directly with the underlying worker.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name, bot_session, update_mask])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        request = bots.UpdateBotSessionRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name
        if bot_session is not None:
            request.bot_session = bot_session
        if update_mask is not None:
            request.update_mask = update_mask

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.update_bot_session,
            default_timeout=600.0,
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





try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            'google-devtools-remoteworkers',
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    'BotsAsyncClient',
)
