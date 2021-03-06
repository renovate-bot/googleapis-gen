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

from google.devtools.testing_v1.types import test_environment_discovery
from .transports.base import TestEnvironmentDiscoveryServiceTransport, DEFAULT_CLIENT_INFO
from .transports.grpc_asyncio import TestEnvironmentDiscoveryServiceGrpcAsyncIOTransport
from .client import TestEnvironmentDiscoveryServiceClient


class TestEnvironmentDiscoveryServiceAsyncClient:
    """Service for discovering environments supported by the
    TestExecutionService.

    Over time the TestService may add or remove devices or configuration
    options (e.g., when new devices and APIs are released). Clients
    should check here periodically to discover what options are
    supported.

    It defines the following resource model:

    -  The API a collection of [TestEnvironmentCatalog]
       [google.devtools.test.v1.TestEnvironmentCatalog] resources, named
       ``testEnvironmentCatalog/*``

    -  Each TestEnvironmentCatalog resource describes a set of supported
       environments.

    -  An
       [AndroidDeviceCatalog][google.devtools.test.v1.AndroidDeviceCatalog]
       describes supported Android devices. It contains lists of
       supported [AndroidModels][google.devtools.test.v1.AndroidModel]
       and [AndroidVersions][google.devtools.test.v1.AndroidVersion]
       along with a
       [AndroidRuntimeConfiguration][google.devtools.test.v1.AndroidRuntimeConfiguration].
       Each AndroidModel contains a list of Versions it supports. All
       models support all locales and orientations described by the
       AndroidRuntimeConfiguration

    -  An [IosDeviceCatalog][google.devtools.test.v1.IosDeviceCatalog]
       describes supported iOS devices. It contains lists of supported
       [IosModels][google.devtools.test.v1.IosModel] and
       [IosVersions][google.devtools.test.v1.IosVersion] along with a
       [IosRuntimeConfiguration][google.devtools.test.v1.IosRuntimeConfiguration].
       Each IosModel contains a list of Versions it supports. All models
       support all locales and orientations described by the
       IosRuntimeConfiguration.
    """

    _client: TestEnvironmentDiscoveryServiceClient

    DEFAULT_ENDPOINT = TestEnvironmentDiscoveryServiceClient.DEFAULT_ENDPOINT
    DEFAULT_MTLS_ENDPOINT = TestEnvironmentDiscoveryServiceClient.DEFAULT_MTLS_ENDPOINT

    common_billing_account_path = staticmethod(TestEnvironmentDiscoveryServiceClient.common_billing_account_path)
    parse_common_billing_account_path = staticmethod(TestEnvironmentDiscoveryServiceClient.parse_common_billing_account_path)
    common_folder_path = staticmethod(TestEnvironmentDiscoveryServiceClient.common_folder_path)
    parse_common_folder_path = staticmethod(TestEnvironmentDiscoveryServiceClient.parse_common_folder_path)
    common_organization_path = staticmethod(TestEnvironmentDiscoveryServiceClient.common_organization_path)
    parse_common_organization_path = staticmethod(TestEnvironmentDiscoveryServiceClient.parse_common_organization_path)
    common_project_path = staticmethod(TestEnvironmentDiscoveryServiceClient.common_project_path)
    parse_common_project_path = staticmethod(TestEnvironmentDiscoveryServiceClient.parse_common_project_path)
    common_location_path = staticmethod(TestEnvironmentDiscoveryServiceClient.common_location_path)
    parse_common_location_path = staticmethod(TestEnvironmentDiscoveryServiceClient.parse_common_location_path)

    @classmethod
    def from_service_account_info(cls, info: dict, *args, **kwargs):
        """Creates an instance of this client using the provided credentials
            info.

        Args:
            info (dict): The service account private key info.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            TestEnvironmentDiscoveryServiceAsyncClient: The constructed client.
        """
        return TestEnvironmentDiscoveryServiceClient.from_service_account_info.__func__(TestEnvironmentDiscoveryServiceAsyncClient, info, *args, **kwargs)  # type: ignore

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
            TestEnvironmentDiscoveryServiceAsyncClient: The constructed client.
        """
        return TestEnvironmentDiscoveryServiceClient.from_service_account_file.__func__(TestEnvironmentDiscoveryServiceAsyncClient, filename, *args, **kwargs)  # type: ignore

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> TestEnvironmentDiscoveryServiceTransport:
        """Returns the transport used by the client instance.

        Returns:
            TestEnvironmentDiscoveryServiceTransport: The transport used by the client instance.
        """
        return self._client.transport

    get_transport_class = functools.partial(type(TestEnvironmentDiscoveryServiceClient).get_transport_class, type(TestEnvironmentDiscoveryServiceClient))

    def __init__(self, *,
            credentials: ga_credentials.Credentials = None,
            transport: Union[str, TestEnvironmentDiscoveryServiceTransport] = "grpc_asyncio",
            client_options: ClientOptions = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiates the test environment discovery service client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, ~.TestEnvironmentDiscoveryServiceTransport]): The
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
        self._client = TestEnvironmentDiscoveryServiceClient(
            credentials=credentials,
            transport=transport,
            client_options=client_options,
            client_info=client_info,

        )

    async def get_test_environment_catalog(self,
            request: test_environment_discovery.GetTestEnvironmentCatalogRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> test_environment_discovery.TestEnvironmentCatalog:
        r"""Gets the catalog of supported test environments.

        May return any of the following canonical error codes:

        -  INVALID_ARGUMENT - if the request is malformed
        -  NOT_FOUND - if the environment type does not exist
        -  INTERNAL - if an internal error occurred

        Args:
            request (:class:`google.devtools.testing_v1.types.GetTestEnvironmentCatalogRequest`):
                The request object. Request to list the currently
                supported values for an environment type.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.devtools.testing_v1.types.TestEnvironmentCatalog:
                A description of a test environment.
        """
        # Create or coerce a protobuf request object.
        request = test_environment_discovery.GetTestEnvironmentCatalogRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_test_environment_catalog,
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





try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            "google-devtools-testing",
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    "TestEnvironmentDiscoveryServiceAsyncClient",
)
