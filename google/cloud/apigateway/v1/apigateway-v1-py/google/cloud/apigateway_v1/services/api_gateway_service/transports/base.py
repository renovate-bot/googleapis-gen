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

import abc
import typing
import pkg_resources

from google import auth  # type: ignore
from google.api_core import exceptions  # type: ignore
from google.api_core import gapic_v1    # type: ignore
from google.api_core import retry as retries  # type: ignore
from google.api_core import operations_v1  # type: ignore
from google.auth import credentials  # type: ignore

from google.cloud.apigateway_v1.types import apigateway
from google.longrunning import operations_pb2 as operations  # type: ignore


try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            'google-cloud-apigateway',
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()

class ApiGatewayServiceTransport(abc.ABC):
    """Abstract transport class for ApiGatewayService."""

    AUTH_SCOPES = (
        'https://www.googleapis.com/auth/cloud-platform',
    )

    def __init__(
            self, *,
            host: str = 'apigateway.googleapis.com',
            credentials: credentials.Credentials = None,
            credentials_file: typing.Optional[str] = None,
            scopes: typing.Optional[typing.Sequence[str]] = AUTH_SCOPES,
            quota_project_id: typing.Optional[str] = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            **kwargs,
            ) -> None:
        """Instantiate the transport.

        Args:
            host (Optional[str]): The hostname to connect to.
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            credentials_file (Optional[str]): A file with credentials that can
                be loaded with :func:`google.auth.load_credentials_from_file`.
                This argument is mutually exclusive with credentials.
            scope (Optional[Sequence[str]]): A list of scopes.
            quota_project_id (Optional[str]): An optional project to use for billing
                and quota.
            client_info (google.api_core.gapic_v1.client_info.ClientInfo):	
                The client info used to send a user-agent string along with	
                API requests. If ``None``, then default info will be used.	
                Generally, you only need to set this if you're developing	
                your own client library.
        """
        # Save the hostname. Default to port 443 (HTTPS) if none is specified.
        if ':' not in host:
            host += ':443'
        self._host = host

        # If no credentials are provided, then determine the appropriate
        # defaults.
        if credentials and credentials_file:
            raise exceptions.DuplicateCredentialArgs("'credentials_file' and 'credentials' are mutually exclusive")

        if credentials_file is not None:
            credentials, _ = auth.load_credentials_from_file(
                                credentials_file,
                                scopes=scopes,
                                quota_project_id=quota_project_id
                            )

        elif credentials is None:
            credentials, _ = auth.default(scopes=scopes, quota_project_id=quota_project_id)

        # Save the credentials.
        self._credentials = credentials

        # Lifted into its own function so it can be stubbed out during tests.
        self._prep_wrapped_messages(client_info)

    def _prep_wrapped_messages(self, client_info):
        # Precompute the wrapped methods.
        self._wrapped_methods = {
            self.list_gateways: gapic_v1.method.wrap_method(
                self.list_gateways,
                default_timeout=None,
                client_info=client_info,
            ),
            self.get_gateway: gapic_v1.method.wrap_method(
                self.get_gateway,
                default_timeout=None,
                client_info=client_info,
            ),
            self.create_gateway: gapic_v1.method.wrap_method(
                self.create_gateway,
                default_retry=retries.Retry(
                    initial=1.0,
                    maximum=60.0,
                    multiplier=2,
                    predicate=retries.if_exception_type(
                        exceptions.ServiceUnavailable,
                        exceptions.Unknown,
                    ),
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.update_gateway: gapic_v1.method.wrap_method(
                self.update_gateway,
                default_retry=retries.Retry(
                    initial=1.0,
                    maximum=60.0,
                    multiplier=2,
                    predicate=retries.if_exception_type(
                        exceptions.ServiceUnavailable,
                        exceptions.Unknown,
                    ),
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.delete_gateway: gapic_v1.method.wrap_method(
                self.delete_gateway,
                default_retry=retries.Retry(
                    initial=1.0,
                    maximum=60.0,
                    multiplier=2,
                    predicate=retries.if_exception_type(
                        exceptions.ServiceUnavailable,
                        exceptions.Unknown,
                    ),
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.list_apis: gapic_v1.method.wrap_method(
                self.list_apis,
                default_timeout=None,
                client_info=client_info,
            ),
            self.get_api: gapic_v1.method.wrap_method(
                self.get_api,
                default_timeout=None,
                client_info=client_info,
            ),
            self.create_api: gapic_v1.method.wrap_method(
                self.create_api,
                default_retry=retries.Retry(
                    initial=1.0,
                    maximum=60.0,
                    multiplier=2,
                    predicate=retries.if_exception_type(
                        exceptions.ServiceUnavailable,
                        exceptions.Unknown,
                    ),
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.update_api: gapic_v1.method.wrap_method(
                self.update_api,
                default_retry=retries.Retry(
                    initial=1.0,
                    maximum=60.0,
                    multiplier=2,
                    predicate=retries.if_exception_type(
                        exceptions.ServiceUnavailable,
                        exceptions.Unknown,
                    ),
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.delete_api: gapic_v1.method.wrap_method(
                self.delete_api,
                default_retry=retries.Retry(
                    initial=1.0,
                    maximum=60.0,
                    multiplier=2,
                    predicate=retries.if_exception_type(
                        exceptions.ServiceUnavailable,
                        exceptions.Unknown,
                    ),
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.list_api_configs: gapic_v1.method.wrap_method(
                self.list_api_configs,
                default_timeout=None,
                client_info=client_info,
            ),
            self.get_api_config: gapic_v1.method.wrap_method(
                self.get_api_config,
                default_timeout=None,
                client_info=client_info,
            ),
            self.create_api_config: gapic_v1.method.wrap_method(
                self.create_api_config,
                default_retry=retries.Retry(
                    initial=1.0,
                    maximum=60.0,
                    multiplier=2,
                    predicate=retries.if_exception_type(
                        exceptions.ServiceUnavailable,
                        exceptions.Unknown,
                    ),
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.update_api_config: gapic_v1.method.wrap_method(
                self.update_api_config,
                default_retry=retries.Retry(
                    initial=1.0,
                    maximum=60.0,
                    multiplier=2,
                    predicate=retries.if_exception_type(
                        exceptions.ServiceUnavailable,
                        exceptions.Unknown,
                    ),
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.delete_api_config: gapic_v1.method.wrap_method(
                self.delete_api_config,
                default_retry=retries.Retry(
                    initial=1.0,
                    maximum=60.0,
                    multiplier=2,
                    predicate=retries.if_exception_type(
                        exceptions.ServiceUnavailable,
                        exceptions.Unknown,
                    ),
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),

        }

    @property
    def operations_client(self) -> operations_v1.OperationsClient:
        """Return the client designed to process long-running operations."""
        raise NotImplementedError()

    @property
    def list_gateways(self) -> typing.Callable[
            [apigateway.ListGatewaysRequest],
            typing.Union[
                apigateway.ListGatewaysResponse,
                typing.Awaitable[apigateway.ListGatewaysResponse]
            ]]:
        raise NotImplementedError()

    @property
    def get_gateway(self) -> typing.Callable[
            [apigateway.GetGatewayRequest],
            typing.Union[
                apigateway.Gateway,
                typing.Awaitable[apigateway.Gateway]
            ]]:
        raise NotImplementedError()

    @property
    def create_gateway(self) -> typing.Callable[
            [apigateway.CreateGatewayRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def update_gateway(self) -> typing.Callable[
            [apigateway.UpdateGatewayRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def delete_gateway(self) -> typing.Callable[
            [apigateway.DeleteGatewayRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def list_apis(self) -> typing.Callable[
            [apigateway.ListApisRequest],
            typing.Union[
                apigateway.ListApisResponse,
                typing.Awaitable[apigateway.ListApisResponse]
            ]]:
        raise NotImplementedError()

    @property
    def get_api(self) -> typing.Callable[
            [apigateway.GetApiRequest],
            typing.Union[
                apigateway.Api,
                typing.Awaitable[apigateway.Api]
            ]]:
        raise NotImplementedError()

    @property
    def create_api(self) -> typing.Callable[
            [apigateway.CreateApiRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def update_api(self) -> typing.Callable[
            [apigateway.UpdateApiRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def delete_api(self) -> typing.Callable[
            [apigateway.DeleteApiRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def list_api_configs(self) -> typing.Callable[
            [apigateway.ListApiConfigsRequest],
            typing.Union[
                apigateway.ListApiConfigsResponse,
                typing.Awaitable[apigateway.ListApiConfigsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def get_api_config(self) -> typing.Callable[
            [apigateway.GetApiConfigRequest],
            typing.Union[
                apigateway.ApiConfig,
                typing.Awaitable[apigateway.ApiConfig]
            ]]:
        raise NotImplementedError()

    @property
    def create_api_config(self) -> typing.Callable[
            [apigateway.CreateApiConfigRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def update_api_config(self) -> typing.Callable[
            [apigateway.UpdateApiConfigRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def delete_api_config(self) -> typing.Callable[
            [apigateway.DeleteApiConfigRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()


__all__ = (
    'ApiGatewayServiceTransport',
)
