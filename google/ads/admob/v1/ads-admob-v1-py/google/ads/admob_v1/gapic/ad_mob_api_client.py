# -*- coding: utf-8 -*-
#
# Copyright 2020 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     https://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

"""Accesses the google.ads.admob.v1 AdMobApi API."""

import functools
import pkg_resources
import warnings

from google.oauth2 import service_account
import google.api_core.client_options
import google.api_core.gapic_v1.client_info
import google.api_core.gapic_v1.config
import google.api_core.gapic_v1.method
import google.api_core.gapic_v1.routing_header
import google.api_core.grpc_helpers
import google.api_core.page_iterator
import google.api_core.path_template
import grpc

from google.ads.admob_v1.gapic import ad_mob_api_client_config
from google.ads.admob_v1.gapic import enums
from google.ads.admob_v1.gapic.transports import ad_mob_api_grpc_transport
from google.ads.admob_v1.proto import admob_api_pb2
from google.ads.admob_v1.proto import admob_api_pb2_grpc
from google.ads.admob_v1.proto import admob_resources_pb2



_GAPIC_LIBRARY_VERSION = pkg_resources.get_distribution(
    'google-cloud-ads-admob',
).version


class AdMobApiClient(object):
    """
    The AdMob API allows AdMob publishers programmatically get information about
    their AdMob account.
    """

    SERVICE_ADDRESS = 'admob.googleapis.com:443'
    """The default address of the service."""

    # The name of the interface for this client. This is the key used to
    # find the method configuration in the client_config dictionary.
    _INTERFACE_NAME = 'google.ads.admob.v1.AdMobApi'


    @classmethod
    def from_service_account_file(cls, filename, *args, **kwargs):
        """Creates an instance of this client using the provided credentials
        file.

        Args:
            filename (str): The path to the service account private key json
                file.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            AdMobApiClient: The constructed client.
        """
        credentials = service_account.Credentials.from_service_account_file(
            filename)
        kwargs['credentials'] = credentials
        return cls(*args, **kwargs)

    from_service_account_json = from_service_account_file


    @classmethod
    def account_path(cls, account):
        """Return a fully-qualified account string."""
        return google.api_core.path_template.expand(
            'accounts/{account}',
            account=account,
        )

    def __init__(self, transport=None, channel=None, credentials=None,
            client_config=None, client_info=None, client_options=None):
        """Constructor.

        Args:
            transport (Union[~.AdMobApiGrpcTransport,
                    Callable[[~.Credentials, type], ~.AdMobApiGrpcTransport]): A transport
                instance, responsible for actually making the API calls.
                The default transport uses the gRPC protocol.
                This argument may also be a callable which returns a
                transport instance. Callables will be sent the credentials
                as the first argument and the default transport class as
                the second argument.
            channel (grpc.Channel): DEPRECATED. A ``Channel`` instance
                through which to make calls. This argument is mutually exclusive
                with ``credentials``; providing both will raise an exception.
            credentials (google.auth.credentials.Credentials): The
                authorization credentials to attach to requests. These
                credentials identify this application to the service. If none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
                This argument is mutually exclusive with providing a
                transport instance to ``transport``; doing so will raise
                an exception.
            client_config (dict): DEPRECATED. A dictionary of call options for
                each method. If not specified, the default configuration is used.
            client_info (google.api_core.gapic_v1.client_info.ClientInfo):
                The client info used to send a user-agent string along with
                API requests. If ``None``, then default info will be used.
                Generally, you only need to set this if you're developing
                your own client library.
            client_options (Union[dict, google.api_core.client_options.ClientOptions]):
                Client options used to set user options on the client. API Endpoint
                should be set through client_options.
        """
        # Raise deprecation warnings for things we want to go away.
        if client_config is not None:
            warnings.warn('The `client_config` argument is deprecated.',
                          PendingDeprecationWarning, stacklevel=2)
        else:
            client_config = ad_mob_api_client_config.config

        if channel:
            warnings.warn('The `channel` argument is deprecated; use '
                          '`transport` instead.',
                          PendingDeprecationWarning, stacklevel=2)

        api_endpoint = self.SERVICE_ADDRESS
        if client_options:
            if type(client_options) == dict:
                client_options = google.api_core.client_options.from_dict(client_options)
            if client_options.api_endpoint:
                api_endpoint = client_options.api_endpoint

        # Instantiate the transport.
        # The transport is responsible for handling serialization and
        # deserialization and actually sending data to the service.
        if transport:
            if callable(transport):
                self.transport = transport(
                    credentials=credentials,
                    default_class=ad_mob_api_grpc_transport.AdMobApiGrpcTransport,
                    address=api_endpoint,
                )
            else:
                if credentials:
                    raise ValueError(
                        'Received both a transport instance and '
                        'credentials; these are mutually exclusive.'
                    )
                self.transport = transport
        else:
            self.transport = ad_mob_api_grpc_transport.AdMobApiGrpcTransport(
                address=api_endpoint,
                channel=channel,
                credentials=credentials,
            )

        if client_info is None:
            client_info = google.api_core.gapic_v1.client_info.ClientInfo(
                gapic_version=_GAPIC_LIBRARY_VERSION,
            )
        else:
            client_info.gapic_version = _GAPIC_LIBRARY_VERSION
        self._client_info = client_info

        # Parse out the default settings for retry and timeout for each RPC
        # from the client configuration.
        # (Ordinarily, these are the defaults specified in the `*_config.py`
        # file next to this one.)
        self._method_configs = google.api_core.gapic_v1.config.parse_method_configs(
            client_config['interfaces'][self._INTERFACE_NAME],
        )

        # Save a dictionary of cached API call functions.
        # These are the actual callables which invoke the proper
        # transport methods, wrapped with `wrap_method` to add retry,
        # timeout, and the like.
        self._inner_api_calls = {}

    # Service calls
    def get_publisher_account(
            self,
            name,
            retry=google.api_core.gapic_v1.method.DEFAULT,
            timeout=google.api_core.gapic_v1.method.DEFAULT,
            metadata=None):
        """
        Gets information about the specified AdMob publisher account.

        Example:
            >>> from google.ads import admob_v1
            >>>
            >>> client = admob_v1.AdMobApiClient()
            >>>
            >>> name = client.account_path('[ACCOUNT]')
            >>>
            >>> response = client.get_publisher_account(name)

        Args:
            name (str): Resource name of the publisher account to retrieve.
                Example: accounts/pub-9876543210987654
            retry (Optional[google.api_core.retry.Retry]):  A retry object used
                to retry requests. If ``None`` is specified, requests will
                be retried using a default configuration.
            timeout (Optional[float]): The amount of time, in seconds, to wait
                for the request to complete. Note that if ``retry`` is
                specified, the timeout applies to each individual attempt.
            metadata (Optional[Sequence[Tuple[str, str]]]): Additional metadata
                that is provided to the method.

        Returns:
            A :class:`~google.ads.admob_v1.types.PublisherAccount` instance.

        Raises:
            google.api_core.exceptions.GoogleAPICallError: If the request
                    failed for any reason.
            google.api_core.exceptions.RetryError: If the request failed due
                    to a retryable error and retry attempts failed.
            ValueError: If the parameters are invalid.
        """
        # Wrap the transport method to add retry and timeout logic.
        if 'get_publisher_account' not in self._inner_api_calls:
            self._inner_api_calls['get_publisher_account'] = google.api_core.gapic_v1.method.wrap_method(
                self.transport.get_publisher_account,
                default_retry=self._method_configs['GetPublisherAccount'].retry,
                default_timeout=self._method_configs['GetPublisherAccount'].timeout,
                client_info=self._client_info,
            )

        request = admob_api_pb2.GetPublisherAccountRequest(
            name=name,
        )
        if metadata is None:
            metadata = []
        metadata = list(metadata)
        try:
            routing_header = [('name', name)]
        except AttributeError:
            pass
        else:
            routing_metadata = google.api_core.gapic_v1.routing_header.to_grpc_metadata(routing_header)
            metadata.append(routing_metadata)

        return self._inner_api_calls['get_publisher_account'](request, retry=retry, timeout=timeout, metadata=metadata)

    def list_publisher_accounts(
            self,
            page_size=None,
            retry=google.api_core.gapic_v1.method.DEFAULT,
            timeout=google.api_core.gapic_v1.method.DEFAULT,
            metadata=None):
        """
        Lists the AdMob publisher account accessible with the client credential.
        Currently, all credentials have access to at most one AdMob account.

        Example:
            >>> from google.ads import admob_v1
            >>>
            >>> client = admob_v1.AdMobApiClient()
            >>>
            >>> # Iterate over all results
            >>> for element in client.list_publisher_accounts():
            ...     # process element
            ...     pass
            >>>
            >>>
            >>> # Alternatively:
            >>>
            >>> # Iterate over results one page at a time
            >>> for page in client.list_publisher_accounts().pages:
            ...     for element in page:
            ...         # process element
            ...         pass

        Args:
            page_size (int): The maximum number of resources contained in the
                underlying API response. If page streaming is performed per-
                resource, this parameter does not affect the return value. If page
                streaming is performed per-page, this determines the maximum number
                of resources in a page.
            retry (Optional[google.api_core.retry.Retry]):  A retry object used
                to retry requests. If ``None`` is specified, requests will
                be retried using a default configuration.
            timeout (Optional[float]): The amount of time, in seconds, to wait
                for the request to complete. Note that if ``retry`` is
                specified, the timeout applies to each individual attempt.
            metadata (Optional[Sequence[Tuple[str, str]]]): Additional metadata
                that is provided to the method.

        Returns:
            A :class:`~google.api_core.page_iterator.PageIterator` instance.
            An iterable of :class:`~google.ads.admob_v1.types.PublisherAccount` instances.
            You can also iterate over the pages of the response
            using its `pages` property.

        Raises:
            google.api_core.exceptions.GoogleAPICallError: If the request
                    failed for any reason.
            google.api_core.exceptions.RetryError: If the request failed due
                    to a retryable error and retry attempts failed.
            ValueError: If the parameters are invalid.
        """
        # Wrap the transport method to add retry and timeout logic.
        if 'list_publisher_accounts' not in self._inner_api_calls:
            self._inner_api_calls['list_publisher_accounts'] = google.api_core.gapic_v1.method.wrap_method(
                self.transport.list_publisher_accounts,
                default_retry=self._method_configs['ListPublisherAccounts'].retry,
                default_timeout=self._method_configs['ListPublisherAccounts'].timeout,
                client_info=self._client_info,
            )

        request = admob_api_pb2.ListPublisherAccountsRequest(
            page_size=page_size,
        )
        iterator = google.api_core.page_iterator.GRPCIterator(
            client=None,
            method=functools.partial(self._inner_api_calls['list_publisher_accounts'], retry=retry, timeout=timeout, metadata=metadata),
            request=request,
            items_field='account',
            request_token_field='page_token',
            response_token_field='next_page_token',
        )
        return iterator

    def generate_network_report(
            self,
            parent,
            report_spec,
            retry=google.api_core.gapic_v1.method.DEFAULT,
            timeout=google.api_core.gapic_v1.method.DEFAULT,
            metadata=None):
        """
        Generates an AdMob Network report based on the provided report
        specification.

        Example:
            >>> from google.ads import admob_v1
            >>>
            >>> client = admob_v1.AdMobApiClient()
            >>>
            >>> parent = client.account_path('[ACCOUNT]')
            >>>
            >>> # TODO: Initialize `report_spec`:
            >>> report_spec = {}
            >>>
            >>> for element in client.generate_network_report(parent, report_spec):
            ...     # process element
            ...     pass

        Args:
            parent (str): Resource name of the account to generate the report for.
                Example: accounts/pub-9876543210987654
            report_spec (Union[dict, ~google.ads.admob_v1.types.NetworkReportSpec]): Network report specification.

                If a dict is provided, it must be of the same form as the protobuf
                message :class:`~google.ads.admob_v1.types.NetworkReportSpec`
            retry (Optional[google.api_core.retry.Retry]):  A retry object used
                to retry requests. If ``None`` is specified, requests will
                be retried using a default configuration.
            timeout (Optional[float]): The amount of time, in seconds, to wait
                for the request to complete. Note that if ``retry`` is
                specified, the timeout applies to each individual attempt.
            metadata (Optional[Sequence[Tuple[str, str]]]): Additional metadata
                that is provided to the method.

        Returns:
            Iterable[~google.ads.admob_v1.types.GenerateNetworkReportResponse].

        Raises:
            google.api_core.exceptions.GoogleAPICallError: If the request
                    failed for any reason.
            google.api_core.exceptions.RetryError: If the request failed due
                    to a retryable error and retry attempts failed.
            ValueError: If the parameters are invalid.
        """
        # Wrap the transport method to add retry and timeout logic.
        if 'generate_network_report' not in self._inner_api_calls:
            self._inner_api_calls['generate_network_report'] = google.api_core.gapic_v1.method.wrap_method(
                self.transport.generate_network_report,
                default_retry=self._method_configs['GenerateNetworkReport'].retry,
                default_timeout=self._method_configs['GenerateNetworkReport'].timeout,
                client_info=self._client_info,
            )

        request = admob_api_pb2.GenerateNetworkReportRequest(
            parent=parent,
            report_spec=report_spec,
        )
        if metadata is None:
            metadata = []
        metadata = list(metadata)
        try:
            routing_header = [('parent', parent)]
        except AttributeError:
            pass
        else:
            routing_metadata = google.api_core.gapic_v1.routing_header.to_grpc_metadata(routing_header)
            metadata.append(routing_metadata)

        return self._inner_api_calls['generate_network_report'](request, retry=retry, timeout=timeout, metadata=metadata)

    def generate_mediation_report(
            self,
            parent,
            report_spec,
            retry=google.api_core.gapic_v1.method.DEFAULT,
            timeout=google.api_core.gapic_v1.method.DEFAULT,
            metadata=None):
        """
        Generates an AdMob Mediation report based on the provided report
        specification.

        Example:
            >>> from google.ads import admob_v1
            >>>
            >>> client = admob_v1.AdMobApiClient()
            >>>
            >>> parent = client.account_path('[ACCOUNT]')
            >>>
            >>> # TODO: Initialize `report_spec`:
            >>> report_spec = {}
            >>>
            >>> for element in client.generate_mediation_report(parent, report_spec):
            ...     # process element
            ...     pass

        Args:
            parent (str): Resource name of the account to generate the report for.
                Example: accounts/pub-9876543210987654
            report_spec (Union[dict, ~google.ads.admob_v1.types.MediationReportSpec]): Network report specification.

                If a dict is provided, it must be of the same form as the protobuf
                message :class:`~google.ads.admob_v1.types.MediationReportSpec`
            retry (Optional[google.api_core.retry.Retry]):  A retry object used
                to retry requests. If ``None`` is specified, requests will
                be retried using a default configuration.
            timeout (Optional[float]): The amount of time, in seconds, to wait
                for the request to complete. Note that if ``retry`` is
                specified, the timeout applies to each individual attempt.
            metadata (Optional[Sequence[Tuple[str, str]]]): Additional metadata
                that is provided to the method.

        Returns:
            Iterable[~google.ads.admob_v1.types.GenerateMediationReportResponse].

        Raises:
            google.api_core.exceptions.GoogleAPICallError: If the request
                    failed for any reason.
            google.api_core.exceptions.RetryError: If the request failed due
                    to a retryable error and retry attempts failed.
            ValueError: If the parameters are invalid.
        """
        # Wrap the transport method to add retry and timeout logic.
        if 'generate_mediation_report' not in self._inner_api_calls:
            self._inner_api_calls['generate_mediation_report'] = google.api_core.gapic_v1.method.wrap_method(
                self.transport.generate_mediation_report,
                default_retry=self._method_configs['GenerateMediationReport'].retry,
                default_timeout=self._method_configs['GenerateMediationReport'].timeout,
                client_info=self._client_info,
            )

        request = admob_api_pb2.GenerateMediationReportRequest(
            parent=parent,
            report_spec=report_spec,
        )
        if metadata is None:
            metadata = []
        metadata = list(metadata)
        try:
            routing_header = [('parent', parent)]
        except AttributeError:
            pass
        else:
            routing_metadata = google.api_core.gapic_v1.routing_header.to_grpc_metadata(routing_header)
            metadata.append(routing_metadata)

        return self._inner_api_calls['generate_mediation_report'](request, retry=retry, timeout=timeout, metadata=metadata)
