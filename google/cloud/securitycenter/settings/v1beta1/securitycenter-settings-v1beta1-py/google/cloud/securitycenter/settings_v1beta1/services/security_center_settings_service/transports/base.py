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
from google.auth import credentials  # type: ignore

from google.cloud.securitycenter.settings_v1beta1.types import component_settings
from google.cloud.securitycenter.settings_v1beta1.types import component_settings as gcss_component_settings
from google.cloud.securitycenter.settings_v1beta1.types import securitycenter_settings_service
from google.cloud.securitycenter.settings_v1beta1.types import settings
from google.cloud.securitycenter.settings_v1beta1.types import settings as gcss_settings
from google.protobuf import empty_pb2 as empty  # type: ignore


try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            'google-cloud-securitycenter-settings',
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()

class SecurityCenterSettingsServiceTransport(abc.ABC):
    """Abstract transport class for SecurityCenterSettingsService."""

    AUTH_SCOPES = (
        'https://www.googleapis.com/auth/cloud-platform',
    )

    def __init__(
            self, *,
            host: str = 'securitycenter.googleapis.com',
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
            self.get_service_account: gapic_v1.method.wrap_method(
                self.get_service_account,
                default_retry=retries.Retry(
                    initial=0.1,
                    maximum=60.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.DeadlineExceeded,
                        exceptions.ServiceUnavailable,
                    ),
                ),
                default_timeout=600.0,
                client_info=client_info,
            ),
            self.get_settings: gapic_v1.method.wrap_method(
                self.get_settings,
                default_retry=retries.Retry(
                    initial=0.1,
                    maximum=60.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.DeadlineExceeded,
                        exceptions.ServiceUnavailable,
                    ),
                ),
                default_timeout=600.0,
                client_info=client_info,
            ),
            self.update_settings: gapic_v1.method.wrap_method(
                self.update_settings,
                default_retry=retries.Retry(
                    initial=0.1,
                    maximum=60.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.DeadlineExceeded,
                        exceptions.ServiceUnavailable,
                    ),
                ),
                default_timeout=600.0,
                client_info=client_info,
            ),
            self.reset_settings: gapic_v1.method.wrap_method(
                self.reset_settings,
                default_retry=retries.Retry(
                    initial=0.1,
                    maximum=60.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.DeadlineExceeded,
                        exceptions.ServiceUnavailable,
                    ),
                ),
                default_timeout=600.0,
                client_info=client_info,
            ),
            self.batch_get_settings: gapic_v1.method.wrap_method(
                self.batch_get_settings,
                default_retry=retries.Retry(
                    initial=0.1,
                    maximum=60.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.DeadlineExceeded,
                        exceptions.ServiceUnavailable,
                    ),
                ),
                default_timeout=600.0,
                client_info=client_info,
            ),
            self.calculate_effective_settings: gapic_v1.method.wrap_method(
                self.calculate_effective_settings,
                default_retry=retries.Retry(
                    initial=0.1,
                    maximum=60.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.DeadlineExceeded,
                        exceptions.ServiceUnavailable,
                    ),
                ),
                default_timeout=600.0,
                client_info=client_info,
            ),
            self.batch_calculate_effective_settings: gapic_v1.method.wrap_method(
                self.batch_calculate_effective_settings,
                default_retry=retries.Retry(
                    initial=0.1,
                    maximum=60.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.DeadlineExceeded,
                        exceptions.ServiceUnavailable,
                    ),
                ),
                default_timeout=600.0,
                client_info=client_info,
            ),
            self.get_component_settings: gapic_v1.method.wrap_method(
                self.get_component_settings,
                default_retry=retries.Retry(
                    initial=0.1,
                    maximum=60.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.DeadlineExceeded,
                        exceptions.ServiceUnavailable,
                    ),
                ),
                default_timeout=600.0,
                client_info=client_info,
            ),
            self.update_component_settings: gapic_v1.method.wrap_method(
                self.update_component_settings,
                default_retry=retries.Retry(
                    initial=0.1,
                    maximum=60.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.DeadlineExceeded,
                        exceptions.ServiceUnavailable,
                    ),
                ),
                default_timeout=600.0,
                client_info=client_info,
            ),
            self.reset_component_settings: gapic_v1.method.wrap_method(
                self.reset_component_settings,
                default_retry=retries.Retry(
                    initial=0.1,
                    maximum=60.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.DeadlineExceeded,
                        exceptions.ServiceUnavailable,
                    ),
                ),
                default_timeout=600.0,
                client_info=client_info,
            ),
            self.calculate_effective_component_settings: gapic_v1.method.wrap_method(
                self.calculate_effective_component_settings,
                default_retry=retries.Retry(
                    initial=0.1,
                    maximum=60.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.DeadlineExceeded,
                        exceptions.ServiceUnavailable,
                    ),
                ),
                default_timeout=600.0,
                client_info=client_info,
            ),
            self.list_detectors: gapic_v1.method.wrap_method(
                self.list_detectors,
                default_retry=retries.Retry(
                    initial=0.1,
                    maximum=60.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.DeadlineExceeded,
                        exceptions.ServiceUnavailable,
                    ),
                ),
                default_timeout=600.0,
                client_info=client_info,
            ),
            self.list_components: gapic_v1.method.wrap_method(
                self.list_components,
                default_retry=retries.Retry(
                    initial=0.1,
                    maximum=60.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.DeadlineExceeded,
                        exceptions.ServiceUnavailable,
                    ),
                ),
                default_timeout=600.0,
                client_info=client_info,
            ),

        }

    @property
    def get_service_account(self) -> typing.Callable[
            [securitycenter_settings_service.GetServiceAccountRequest],
            typing.Union[
                securitycenter_settings_service.ServiceAccount,
                typing.Awaitable[securitycenter_settings_service.ServiceAccount]
            ]]:
        raise NotImplementedError()

    @property
    def get_settings(self) -> typing.Callable[
            [securitycenter_settings_service.GetSettingsRequest],
            typing.Union[
                settings.Settings,
                typing.Awaitable[settings.Settings]
            ]]:
        raise NotImplementedError()

    @property
    def update_settings(self) -> typing.Callable[
            [securitycenter_settings_service.UpdateSettingsRequest],
            typing.Union[
                gcss_settings.Settings,
                typing.Awaitable[gcss_settings.Settings]
            ]]:
        raise NotImplementedError()

    @property
    def reset_settings(self) -> typing.Callable[
            [securitycenter_settings_service.ResetSettingsRequest],
            typing.Union[
                empty.Empty,
                typing.Awaitable[empty.Empty]
            ]]:
        raise NotImplementedError()

    @property
    def batch_get_settings(self) -> typing.Callable[
            [securitycenter_settings_service.BatchGetSettingsRequest],
            typing.Union[
                securitycenter_settings_service.BatchGetSettingsResponse,
                typing.Awaitable[securitycenter_settings_service.BatchGetSettingsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def calculate_effective_settings(self) -> typing.Callable[
            [securitycenter_settings_service.CalculateEffectiveSettingsRequest],
            typing.Union[
                settings.Settings,
                typing.Awaitable[settings.Settings]
            ]]:
        raise NotImplementedError()

    @property
    def batch_calculate_effective_settings(self) -> typing.Callable[
            [securitycenter_settings_service.BatchCalculateEffectiveSettingsRequest],
            typing.Union[
                securitycenter_settings_service.BatchCalculateEffectiveSettingsResponse,
                typing.Awaitable[securitycenter_settings_service.BatchCalculateEffectiveSettingsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def get_component_settings(self) -> typing.Callable[
            [securitycenter_settings_service.GetComponentSettingsRequest],
            typing.Union[
                component_settings.ComponentSettings,
                typing.Awaitable[component_settings.ComponentSettings]
            ]]:
        raise NotImplementedError()

    @property
    def update_component_settings(self) -> typing.Callable[
            [securitycenter_settings_service.UpdateComponentSettingsRequest],
            typing.Union[
                gcss_component_settings.ComponentSettings,
                typing.Awaitable[gcss_component_settings.ComponentSettings]
            ]]:
        raise NotImplementedError()

    @property
    def reset_component_settings(self) -> typing.Callable[
            [securitycenter_settings_service.ResetComponentSettingsRequest],
            typing.Union[
                empty.Empty,
                typing.Awaitable[empty.Empty]
            ]]:
        raise NotImplementedError()

    @property
    def calculate_effective_component_settings(self) -> typing.Callable[
            [securitycenter_settings_service.CalculateEffectiveComponentSettingsRequest],
            typing.Union[
                component_settings.ComponentSettings,
                typing.Awaitable[component_settings.ComponentSettings]
            ]]:
        raise NotImplementedError()

    @property
    def list_detectors(self) -> typing.Callable[
            [securitycenter_settings_service.ListDetectorsRequest],
            typing.Union[
                securitycenter_settings_service.ListDetectorsResponse,
                typing.Awaitable[securitycenter_settings_service.ListDetectorsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def list_components(self) -> typing.Callable[
            [securitycenter_settings_service.ListComponentsRequest],
            typing.Union[
                securitycenter_settings_service.ListComponentsResponse,
                typing.Awaitable[securitycenter_settings_service.ListComponentsResponse]
            ]]:
        raise NotImplementedError()


__all__ = (
    'SecurityCenterSettingsServiceTransport',
)