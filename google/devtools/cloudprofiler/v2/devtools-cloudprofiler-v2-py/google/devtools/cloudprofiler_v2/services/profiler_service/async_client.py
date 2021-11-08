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

from google.devtools.cloudprofiler_v2.types import profiler
from google.protobuf import duration_pb2  # type: ignore
from .transports.base import ProfilerServiceTransport, DEFAULT_CLIENT_INFO
from .transports.grpc_asyncio import ProfilerServiceGrpcAsyncIOTransport
from .client import ProfilerServiceClient


class ProfilerServiceAsyncClient:
    """Manage the collection of continuous profiling data provided by
    profiling agents running in the cloud or by an offline provider of
    profiling data.

    General guidelines:

    -  Profiles for a single deployment must be created in ascending
       time order.
    -  Profiles can be created in either online or offline mode, see
       below.
    """

    _client: ProfilerServiceClient

    DEFAULT_ENDPOINT = ProfilerServiceClient.DEFAULT_ENDPOINT
    DEFAULT_MTLS_ENDPOINT = ProfilerServiceClient.DEFAULT_MTLS_ENDPOINT

    common_billing_account_path = staticmethod(ProfilerServiceClient.common_billing_account_path)
    parse_common_billing_account_path = staticmethod(ProfilerServiceClient.parse_common_billing_account_path)
    common_folder_path = staticmethod(ProfilerServiceClient.common_folder_path)
    parse_common_folder_path = staticmethod(ProfilerServiceClient.parse_common_folder_path)
    common_organization_path = staticmethod(ProfilerServiceClient.common_organization_path)
    parse_common_organization_path = staticmethod(ProfilerServiceClient.parse_common_organization_path)
    common_project_path = staticmethod(ProfilerServiceClient.common_project_path)
    parse_common_project_path = staticmethod(ProfilerServiceClient.parse_common_project_path)
    common_location_path = staticmethod(ProfilerServiceClient.common_location_path)
    parse_common_location_path = staticmethod(ProfilerServiceClient.parse_common_location_path)

    @classmethod
    def from_service_account_info(cls, info: dict, *args, **kwargs):
        """Creates an instance of this client using the provided credentials
            info.

        Args:
            info (dict): The service account private key info.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            ProfilerServiceAsyncClient: The constructed client.
        """
        return ProfilerServiceClient.from_service_account_info.__func__(ProfilerServiceAsyncClient, info, *args, **kwargs)  # type: ignore

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
            ProfilerServiceAsyncClient: The constructed client.
        """
        return ProfilerServiceClient.from_service_account_file.__func__(ProfilerServiceAsyncClient, filename, *args, **kwargs)  # type: ignore

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> ProfilerServiceTransport:
        """Returns the transport used by the client instance.

        Returns:
            ProfilerServiceTransport: The transport used by the client instance.
        """
        return self._client.transport

    get_transport_class = functools.partial(type(ProfilerServiceClient).get_transport_class, type(ProfilerServiceClient))

    def __init__(self, *,
            credentials: ga_credentials.Credentials = None,
            transport: Union[str, ProfilerServiceTransport] = "grpc_asyncio",
            client_options: ClientOptions = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiates the profiler service client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, ~.ProfilerServiceTransport]): The
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
        self._client = ProfilerServiceClient(
            credentials=credentials,
            transport=transport,
            client_options=client_options,
            client_info=client_info,

        )

    async def create_profile(self,
            request: Union[profiler.CreateProfileRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> profiler.Profile:
        r"""CreateProfile creates a new profile resource in the
        online mode.
        The server ensures that the new profiles are created at
        a constant rate per deployment, so the creation request
        may hang for some time until the next profile session is
        available.

        The request may fail with ABORTED error if the creation
        is not available within ~1m, the response will indicate
        the duration of the backoff the client should take
        before attempting creating a profile again. The backoff
        duration is returned in google.rpc.RetryInfo extension
        on the response status. To a gRPC client, the extension
        will be return as a binary-serialized proto in the
        trailing metadata item named "google.rpc.retryinfo-bin".

        Args:
            request (Union[google.devtools.cloudprofiler_v2.types.CreateProfileRequest, dict]):
                The request object. CreateProfileRequest describes a
                profile resource online creation request. The deployment
                field must be populated. The profile_type specifies the
                list of profile types supported by the agent. The
                creation call will hang until a profile of one of these
                types needs to be collected.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.devtools.cloudprofiler_v2.types.Profile:
                Profile resource.
        """
        # Create or coerce a protobuf request object.
        request = profiler.CreateProfileRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.create_profile,
            default_timeout=3600.0,
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

    async def create_offline_profile(self,
            request: Union[profiler.CreateOfflineProfileRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> profiler.Profile:
        r"""CreateOfflineProfile creates a new profile resource
        in the offline mode. The client provides the profile to
        create along with the profile bytes, the server records
        it.

        Args:
            request (Union[google.devtools.cloudprofiler_v2.types.CreateOfflineProfileRequest, dict]):
                The request object. CreateOfflineProfileRequest
                describes a profile resource offline creation request.
                Profile field must be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.devtools.cloudprofiler_v2.types.Profile:
                Profile resource.
        """
        # Create or coerce a protobuf request object.
        request = profiler.CreateOfflineProfileRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.create_offline_profile,
            default_timeout=30.0,
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

    async def update_profile(self,
            request: Union[profiler.UpdateProfileRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> profiler.Profile:
        r"""UpdateProfile updates the profile bytes and labels on
        the profile resource created in the online mode.
        Updating the bytes for profiles created in the offline
        mode is currently not supported: the profile content
        must be provided at the time of the profile creation.

        Args:
            request (Union[google.devtools.cloudprofiler_v2.types.UpdateProfileRequest, dict]):
                The request object. UpdateProfileRequest contains the
                profile to update.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.devtools.cloudprofiler_v2.types.Profile:
                Profile resource.
        """
        # Create or coerce a protobuf request object.
        request = profiler.UpdateProfileRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.update_profile,
            default_timeout=30.0,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("profile.name", request.profile.name),
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

    async def __aenter__(self):
        return self

    async def __aexit__(self, exc_type, exc, tb):
        await self.transport.close()

try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            "google-devtools-cloudprofiler",
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    "ProfilerServiceAsyncClient",
)
