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

from google.api_core import operation  # type: ignore
from google.api_core import operation_async  # type: ignore
from google.cloud.ondemandscanning_v1beta1.services.scanner_service import pagers
from google.cloud.ondemandscanning_v1beta1.types import scanner_service
from grafeas.v1 import grafeas_pb2  # type: ignore
from .transports.base import ScannerServiceTransport, DEFAULT_CLIENT_INFO
from .transports.grpc_asyncio import ScannerServiceGrpcAsyncIOTransport
from .client import ScannerServiceClient


class ScannerServiceAsyncClient:
    """The Scanner service of the On-Demand Scanning API.

    This service provides a way to find vulnerabilities for the packages
    in some container image. A user provides a a list of packages to
    ``AnalyzePackages`` and receives a list of vulnerabilities in
    return. The ``AnalyzePackages`` method is asynchronous, implementing
    Long-running Operations to track progress.
    """

    _client: ScannerServiceClient

    DEFAULT_ENDPOINT = ScannerServiceClient.DEFAULT_ENDPOINT
    DEFAULT_MTLS_ENDPOINT = ScannerServiceClient.DEFAULT_MTLS_ENDPOINT

    occurrence_path = staticmethod(ScannerServiceClient.occurrence_path)
    parse_occurrence_path = staticmethod(ScannerServiceClient.parse_occurrence_path)
    common_billing_account_path = staticmethod(ScannerServiceClient.common_billing_account_path)
    parse_common_billing_account_path = staticmethod(ScannerServiceClient.parse_common_billing_account_path)
    common_folder_path = staticmethod(ScannerServiceClient.common_folder_path)
    parse_common_folder_path = staticmethod(ScannerServiceClient.parse_common_folder_path)
    common_organization_path = staticmethod(ScannerServiceClient.common_organization_path)
    parse_common_organization_path = staticmethod(ScannerServiceClient.parse_common_organization_path)
    common_project_path = staticmethod(ScannerServiceClient.common_project_path)
    parse_common_project_path = staticmethod(ScannerServiceClient.parse_common_project_path)
    common_location_path = staticmethod(ScannerServiceClient.common_location_path)
    parse_common_location_path = staticmethod(ScannerServiceClient.parse_common_location_path)

    @classmethod
    def from_service_account_info(cls, info: dict, *args, **kwargs):
        """Creates an instance of this client using the provided credentials
            info.

        Args:
            info (dict): The service account private key info.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            ScannerServiceAsyncClient: The constructed client.
        """
        return ScannerServiceClient.from_service_account_info.__func__(ScannerServiceAsyncClient, info, *args, **kwargs)  # type: ignore

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
            ScannerServiceAsyncClient: The constructed client.
        """
        return ScannerServiceClient.from_service_account_file.__func__(ScannerServiceAsyncClient, filename, *args, **kwargs)  # type: ignore

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> ScannerServiceTransport:
        """Returns the transport used by the client instance.

        Returns:
            ScannerServiceTransport: The transport used by the client instance.
        """
        return self._client.transport

    get_transport_class = functools.partial(type(ScannerServiceClient).get_transport_class, type(ScannerServiceClient))

    def __init__(self, *,
            credentials: ga_credentials.Credentials = None,
            transport: Union[str, ScannerServiceTransport] = "grpc_asyncio",
            client_options: ClientOptions = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiates the scanner service client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, ~.ScannerServiceTransport]): The
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
        self._client = ScannerServiceClient(
            credentials=credentials,
            transport=transport,
            client_options=client_options,
            client_info=client_info,

        )

    async def analyze_packages(self,
            request: scanner_service.AnalyzePackagesRequest = None,
            *,
            parent: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Initiates an analysis of the provided packages.

        Args:
            request (:class:`google.cloud.ondemandscanning_v1beta1.types.AnalyzePackagesRequest`):
                The request object. AnalyzePackagesRequest is the
                request to analyze a list of packages and create
                Vulnerability Occurrences for it.
            parent (:class:`str`):
                Required. The parent of the resource for which analysis
                is requested. Format:
                projects/[project_name]/locations/[location]

                This corresponds to the ``parent`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation_async.AsyncOperation:
                An object representing a long-running operation.

                The result type for the operation will be :class:`google.cloud.ondemandscanning_v1beta1.types.AnalyzePackagesResponse` AnalyzePackagesResponse contains the information necessary to find results
                   for the given scan.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([parent])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = scanner_service.AnalyzePackagesRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if parent is not None:
            request.parent = parent

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.analyze_packages,
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

        # Wrap the response in an operation future.
        response = operation_async.from_gapic(
            response,
            self._client._transport.operations_client,
            scanner_service.AnalyzePackagesResponse,
            metadata_type=scanner_service.AnalyzePackagesMetadata,
        )

        # Done; return the response.
        return response

    async def list_vulnerabilities(self,
            request: scanner_service.ListVulnerabilitiesRequest = None,
            *,
            parent: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListVulnerabilitiesAsyncPager:
        r"""Lists vulnerabilities resulting from a successfully
        completed scan.

        Args:
            request (:class:`google.cloud.ondemandscanning_v1beta1.types.ListVulnerabilitiesRequest`):
                The request object. ListVulnerabilitiesRequest is the
                request to retrieve the vulnerabilities resulting from a
                scan.
            parent (:class:`str`):
                Required. The parent of the collection of
                Vulnerabilities being requested. Format:
                projects/[project_name]/locations/[location]/scans/[scan_id]

                This corresponds to the ``parent`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.ondemandscanning_v1beta1.services.scanner_service.pagers.ListVulnerabilitiesAsyncPager:
                ListVulnerabilitiesResponse contains
                a single page of vulnerabilities
                resulting from a scan.
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([parent])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = scanner_service.ListVulnerabilitiesRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if parent is not None:
            request.parent = parent

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_vulnerabilities,
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
        response = pagers.ListVulnerabilitiesAsyncPager(
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
            "google-cloud-ondemandscanning",
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    "ScannerServiceAsyncClient",
)
