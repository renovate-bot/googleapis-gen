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
from typing import Dict, AsyncIterable, Awaitable, AsyncIterator, Sequence, Tuple, Type, Union
import pkg_resources

from google.api_core.client_options import ClientOptions
from google.api_core import exceptions as core_exceptions
from google.api_core import gapic_v1
from google.api_core import retry as retries
from google.auth import credentials as ga_credentials   # type: ignore
from google.oauth2 import service_account              # type: ignore

try:
    OptionalRetry = Union[retries.Retry, gapic_v1.method._MethodDefault]
except AttributeError:  # pragma: NO COVER
    OptionalRetry = Union[retries.Retry, object]  # type: ignore

from google.devtools.build_v1.types import build_events
from google.devtools.build_v1.types import publish_build_event
from .transports.base import PublishBuildEventTransport, DEFAULT_CLIENT_INFO
from .transports.grpc_asyncio import PublishBuildEventGrpcAsyncIOTransport
from .client import PublishBuildEventClient


class PublishBuildEventAsyncClient:
    """A service for publishing BuildEvents. BuildEvents are
    generated by Build Systems to record actions taken during a
    Build. Events occur in streams, are identified by a StreamId,
    and ordered by sequence number in a stream.
    A Build may contain several streams of BuildEvents, depending on
    the systems that are involved in the Build. Some BuildEvents are
    used to declare the beginning and end of major portions of a
    Build; these are called LifecycleEvents, and are used (for
    example) to indicate the beginning or end of a Build, and the
    beginning or end of an Invocation attempt (there can be more
    than 1 Invocation in a Build if, for example, a failure occurs
    somewhere and it needs to be retried).

    Other, build-tool events represent actions taken by the Build
    tool, such as target objects produced via compilation, tests
    run, et cetera. There could be more than one build tool stream
    for an invocation attempt of a build.
    """

    _client: PublishBuildEventClient

    DEFAULT_ENDPOINT = PublishBuildEventClient.DEFAULT_ENDPOINT
    DEFAULT_MTLS_ENDPOINT = PublishBuildEventClient.DEFAULT_MTLS_ENDPOINT

    common_billing_account_path = staticmethod(PublishBuildEventClient.common_billing_account_path)
    parse_common_billing_account_path = staticmethod(PublishBuildEventClient.parse_common_billing_account_path)
    common_folder_path = staticmethod(PublishBuildEventClient.common_folder_path)
    parse_common_folder_path = staticmethod(PublishBuildEventClient.parse_common_folder_path)
    common_organization_path = staticmethod(PublishBuildEventClient.common_organization_path)
    parse_common_organization_path = staticmethod(PublishBuildEventClient.parse_common_organization_path)
    common_project_path = staticmethod(PublishBuildEventClient.common_project_path)
    parse_common_project_path = staticmethod(PublishBuildEventClient.parse_common_project_path)
    common_location_path = staticmethod(PublishBuildEventClient.common_location_path)
    parse_common_location_path = staticmethod(PublishBuildEventClient.parse_common_location_path)

    @classmethod
    def from_service_account_info(cls, info: dict, *args, **kwargs):
        """Creates an instance of this client using the provided credentials
            info.

        Args:
            info (dict): The service account private key info.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            PublishBuildEventAsyncClient: The constructed client.
        """
        return PublishBuildEventClient.from_service_account_info.__func__(PublishBuildEventAsyncClient, info, *args, **kwargs)  # type: ignore

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
            PublishBuildEventAsyncClient: The constructed client.
        """
        return PublishBuildEventClient.from_service_account_file.__func__(PublishBuildEventAsyncClient, filename, *args, **kwargs)  # type: ignore

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> PublishBuildEventTransport:
        """Returns the transport used by the client instance.

        Returns:
            PublishBuildEventTransport: The transport used by the client instance.
        """
        return self._client.transport

    get_transport_class = functools.partial(type(PublishBuildEventClient).get_transport_class, type(PublishBuildEventClient))

    def __init__(self, *,
            credentials: ga_credentials.Credentials = None,
            transport: Union[str, PublishBuildEventTransport] = "grpc_asyncio",
            client_options: ClientOptions = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiates the publish build event client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, ~.PublishBuildEventTransport]): The
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
        self._client = PublishBuildEventClient(
            credentials=credentials,
            transport=transport,
            client_options=client_options,
            client_info=client_info,

        )

    async def publish_lifecycle_event(self,
            request: Union[publish_build_event.PublishLifecycleEventRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> None:
        r"""Publish a build event stating the new state of a build
        (typically from the build queue). The BuildEnqueued event must
        be publishd before all other events for the same build ID.

        The backend will persist the event and deliver it to registered
        frontend jobs immediately without batching.

        The commit status of the request is reported by the RPC's
        util_status() function. The error code is the canoncial error
        code defined in //util/task/codes.proto.

        Args:
            request (Union[google.devtools.build_v1.types.PublishLifecycleEventRequest, dict]):
                The request object. Publishes 'lifecycle events' that
                update the high-level state of a build: - BuildEnqueued:
                When a build is scheduled. - InvocationAttemptStarted:
                When work for a build starts; there can be     multiple
                invocations for a build (e.g. retries).
                - InvocationAttemptCompleted: When work for a build
                finishes. - BuildFinished: When a build is finished.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        # Create or coerce a protobuf request object.
        request = publish_build_event.PublishLifecycleEventRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.publish_lifecycle_event,
            default_timeout=600.0,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("project_id", request.project_id),
            )),
        )

        # Send the request.
        await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    def publish_build_tool_event_stream(self,
            requests: AsyncIterator[publish_build_event.PublishBuildToolEventStreamRequest] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> Awaitable[AsyncIterable[publish_build_event.PublishBuildToolEventStreamResponse]]:
        r"""Publish build tool events belonging to the same
        stream to a backend job using bidirectional streaming.

        Args:
            requests (AsyncIterator[`google.devtools.build_v1.types.PublishBuildToolEventStreamRequest`]):
                The request object AsyncIterator. Streaming request message for
                PublishBuildToolEventStream.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            AsyncIterable[google.devtools.build_v1.types.PublishBuildToolEventStreamResponse]:
                States which event has been
                committed. Any failure to commit will
                cause RPC errors, hence not recorded by
                this proto.

        """

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.publish_build_tool_event_stream,
            default_timeout=600.0,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
            )),
        )

        # Send the request.
        response = rpc(
            requests,
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
            "google-devtools-build",
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    "PublishBuildEventAsyncClient",
)
