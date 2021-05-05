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
from typing import Dict, AsyncIterable, Awaitable, Sequence, Tuple, Type, Union
import pkg_resources

import google.api_core.client_options as ClientOptions # type: ignore
from google.api_core import exceptions as core_exceptions  # type: ignore
from google.api_core import gapic_v1                   # type: ignore
from google.api_core import retry as retries           # type: ignore
from google.auth import credentials as ga_credentials   # type: ignore
from google.oauth2 import service_account              # type: ignore

from google.ads.admob_v1.services.ad_mob_api import pagers
from google.ads.admob_v1.types import admob_api
from google.ads.admob_v1.types import admob_resources
from .transports.base import AdMobApiTransport, DEFAULT_CLIENT_INFO
from .transports.grpc_asyncio import AdMobApiGrpcAsyncIOTransport
from .client import AdMobApiClient


class AdMobApiAsyncClient:
    """The AdMob API allows AdMob publishers programmatically get
    information about their AdMob account.
    """

    _client: AdMobApiClient

    DEFAULT_ENDPOINT = AdMobApiClient.DEFAULT_ENDPOINT
    DEFAULT_MTLS_ENDPOINT = AdMobApiClient.DEFAULT_MTLS_ENDPOINT

    publisher_account_path = staticmethod(AdMobApiClient.publisher_account_path)
    parse_publisher_account_path = staticmethod(AdMobApiClient.parse_publisher_account_path)
    common_billing_account_path = staticmethod(AdMobApiClient.common_billing_account_path)
    parse_common_billing_account_path = staticmethod(AdMobApiClient.parse_common_billing_account_path)
    common_folder_path = staticmethod(AdMobApiClient.common_folder_path)
    parse_common_folder_path = staticmethod(AdMobApiClient.parse_common_folder_path)
    common_organization_path = staticmethod(AdMobApiClient.common_organization_path)
    parse_common_organization_path = staticmethod(AdMobApiClient.parse_common_organization_path)
    common_project_path = staticmethod(AdMobApiClient.common_project_path)
    parse_common_project_path = staticmethod(AdMobApiClient.parse_common_project_path)
    common_location_path = staticmethod(AdMobApiClient.common_location_path)
    parse_common_location_path = staticmethod(AdMobApiClient.parse_common_location_path)

    @classmethod
    def from_service_account_info(cls, info: dict, *args, **kwargs):
        """Creates an instance of this client using the provided credentials info.

        Args:
            info (dict): The service account private key info.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            AdMobApiAsyncClient: The constructed client.
        """
        return AdMobApiClient.from_service_account_info.__func__(AdMobApiAsyncClient, info, *args, **kwargs)  # type: ignore

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
            AdMobApiAsyncClient: The constructed client.
        """
        return AdMobApiClient.from_service_account_file.__func__(AdMobApiAsyncClient, filename, *args, **kwargs)  # type: ignore

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> AdMobApiTransport:
        """Return the transport used by the client instance.

        Returns:
            AdMobApiTransport: The transport used by the client instance.
        """
        return self._client.transport

    get_transport_class = functools.partial(type(AdMobApiClient).get_transport_class, type(AdMobApiClient))

    def __init__(self, *,
            credentials: ga_credentials.Credentials = None,
            transport: Union[str, AdMobApiTransport] = 'grpc_asyncio',
            client_options: ClientOptions = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiate the ad mob api client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, ~.AdMobApiTransport]): The
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
        self._client = AdMobApiClient(
            credentials=credentials,
            transport=transport,
            client_options=client_options,
            client_info=client_info,

        )

    async def get_publisher_account(self,
            request: admob_api.GetPublisherAccountRequest = None,
            *,
            name: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> admob_resources.PublisherAccount:
        r"""Gets information about the specified AdMob publisher
        account.

        Args:
            request (:class:`google.ads.admob_v1.types.GetPublisherAccountRequest`):
                The request object. Request to retrieve the specified
                publisher account.
            name (:class:`str`):
                Resource name of the publisher
                account to retrieve. Example:
                accounts/pub-9876543210987654

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.ads.admob_v1.types.PublisherAccount:
                A publisher account contains
                information relevant to the use of this
                API, such as the time zone used for the
                reports.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        request = admob_api.GetPublisherAccountRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_publisher_account,
            default_timeout=None,
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

    async def list_publisher_accounts(self,
            request: admob_api.ListPublisherAccountsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListPublisherAccountsAsyncPager:
        r"""Lists the AdMob publisher account accessible with the
        client credential. Currently, all credentials have
        access to at most one AdMob account.

        Args:
            request (:class:`google.ads.admob_v1.types.ListPublisherAccountsRequest`):
                The request object. Request to retrieve the AdMob
                publisher account accessible with the client credential.
                Currently all credentials have access to at most 1
                account.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.ads.admob_v1.services.ad_mob_api.pagers.ListPublisherAccountsAsyncPager:
                Response for the publisher account
                list request.
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        request = admob_api.ListPublisherAccountsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_publisher_accounts,
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

        # This method is paged; wrap the response in a pager, which provides
        # an `__aiter__` convenience method.
        response = pagers.ListPublisherAccountsAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def generate_network_report(self,
            request: admob_api.GenerateNetworkReportRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> Awaitable[AsyncIterable[admob_api.GenerateNetworkReportResponse]]:
        r"""Generates an AdMob Network report based on the
        provided report specification.

        Args:
            request (:class:`google.ads.admob_v1.types.GenerateNetworkReportRequest`):
                The request object. Request to generate an AdMob Network
                report.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            AsyncIterable[google.ads.admob_v1.types.GenerateNetworkReportResponse]:
                The streaming response for the AdMob Network report where the first response
                   contains the report header, then a stream of row
                   responses, and finally a footer as the last response
                   message.

                   For example:

                      [{
                         "header": {
                            "dateRange": {
                               "startDate": {"year": 2018, "month": 9,
                               "day": 1}, "endDate": {"year": 2018,
                               "month": 9, "day": 1}

                            }, "localizationSettings": { "currencyCode":
                            "USD", "languageCode": "en-US" }

                         }

                      }, { "row": { "dimensionValues": { "DATE":
                      {"value": "20180918"}, "APP": { "value":
                      "ca-app-pub-8123415297019784~1001342552",
                      displayLabel: "My app name!" } }, "metricValues":
                      { "ESTIMATED_EARNINGS": {"microsValue": 6500000} }
                      } }, { "footer": {"matchingRowCount": 1} }]

        """
        # Create or coerce a protobuf request object.
        request = admob_api.GenerateNetworkReportRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.generate_network_report,
            default_timeout=None,
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
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def generate_mediation_report(self,
            request: admob_api.GenerateMediationReportRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> Awaitable[AsyncIterable[admob_api.GenerateMediationReportResponse]]:
        r"""Generates an AdMob Mediation report based on the
        provided report specification.

        Args:
            request (:class:`google.ads.admob_v1.types.GenerateMediationReportRequest`):
                The request object. Request to generate an AdMob
                Mediation report.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            AsyncIterable[google.ads.admob_v1.types.GenerateMediationReportResponse]:
                The streaming response for the AdMob Mediation report where the first
                   response contains the report header, then a stream of
                   row responses, and finally a footer as the last
                   response message.

                   For example:

                      [{
                         "header": {
                            "date_range": {
                               "start_date": {"year": 2018, "month": 9,
                               "day": 1}, "end_date": {"year": 2018,
                               "month": 9, "day": 1}

                            }, "localization_settings": {
                            "currency_code": "USD", "language_code":
                            "en-US" }

                         }

                      }, { "row": { "dimension_values": { "DATE":
                      {"value": "20180918"}, "APP": { "value":
                      "ca-app-pub-8123415297019784~1001342552",
                      "display_label": "My app name!" } },
                      "metric_values": { "ESTIMATED_EARNINGS":
                      {"decimal_value": "1324746"} } } }, { "footer":
                      {"matching_row_count": 1} }]

        """
        # Create or coerce a protobuf request object.
        request = admob_api.GenerateMediationReportRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.generate_mediation_report,
            default_timeout=None,
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
        response = rpc(
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
            'google-ads-admob',
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    'AdMobApiAsyncClient',
)
