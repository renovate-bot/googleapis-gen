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

from google.home.enterprise.sdm_v1.types import device
from google.home.enterprise.sdm_v1.types import site
from google.home.enterprise.sdm_v1.types import smart_device_management_service


try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            'google-home-enterprise-sdm',
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()

class SmartDeviceManagementServiceTransport(abc.ABC):
    """Abstract transport class for SmartDeviceManagementService."""

    AUTH_SCOPES = (
        'https://www.googleapis.com/auth/sdm.service',
    )

    def __init__(
            self, *,
            host: str = 'smartdevicemanagement.googleapis.com',
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

        # Save the scopes.
        self._scopes = scopes or self.AUTH_SCOPES

        # If no credentials are provided, then determine the appropriate
        # defaults.
        if credentials and credentials_file:
            raise exceptions.DuplicateCredentialArgs("'credentials_file' and 'credentials' are mutually exclusive")

        if credentials_file is not None:
            credentials, _ = auth.load_credentials_from_file(
                                credentials_file,
                                scopes=self._scopes,
                                quota_project_id=quota_project_id
                            )

        elif credentials is None:
            credentials, _ = auth.default(scopes=self._scopes, quota_project_id=quota_project_id)

        # Save the credentials.
        self._credentials = credentials

    def _prep_wrapped_messages(self, client_info):
        # Precompute the wrapped methods.
        self._wrapped_methods = {
            self.get_device: gapic_v1.method.wrap_method(
                self.get_device,
                default_retry=retries.Retry(
                    initial=1.0,
                    maximum=10.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.ServiceUnavailable,
                    ),
                    deadline=60.0,
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.list_devices: gapic_v1.method.wrap_method(
                self.list_devices,
                default_retry=retries.Retry(
                    initial=1.0,
                    maximum=10.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.ServiceUnavailable,
                    ),
                    deadline=60.0,
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.execute_device_command: gapic_v1.method.wrap_method(
                self.execute_device_command,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.get_structure: gapic_v1.method.wrap_method(
                self.get_structure,
                default_retry=retries.Retry(
                    initial=1.0,
                    maximum=10.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.ServiceUnavailable,
                    ),
                    deadline=60.0,
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.list_structures: gapic_v1.method.wrap_method(
                self.list_structures,
                default_retry=retries.Retry(
                    initial=1.0,
                    maximum=10.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.ServiceUnavailable,
                    ),
                    deadline=60.0,
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.get_room: gapic_v1.method.wrap_method(
                self.get_room,
                default_retry=retries.Retry(
                    initial=1.0,
                    maximum=10.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.ServiceUnavailable,
                    ),
                    deadline=60.0,
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.list_rooms: gapic_v1.method.wrap_method(
                self.list_rooms,
                default_retry=retries.Retry(
                    initial=1.0,
                    maximum=10.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.ServiceUnavailable,
                    ),
                    deadline=60.0,
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),

        }

    @property
    def get_device(self) -> typing.Callable[
            [smart_device_management_service.GetDeviceRequest],
            typing.Union[
                device.Device,
                typing.Awaitable[device.Device]
            ]]:
        raise NotImplementedError()

    @property
    def list_devices(self) -> typing.Callable[
            [smart_device_management_service.ListDevicesRequest],
            typing.Union[
                smart_device_management_service.ListDevicesResponse,
                typing.Awaitable[smart_device_management_service.ListDevicesResponse]
            ]]:
        raise NotImplementedError()

    @property
    def execute_device_command(self) -> typing.Callable[
            [smart_device_management_service.ExecuteDeviceCommandRequest],
            typing.Union[
                smart_device_management_service.ExecuteDeviceCommandResponse,
                typing.Awaitable[smart_device_management_service.ExecuteDeviceCommandResponse]
            ]]:
        raise NotImplementedError()

    @property
    def get_structure(self) -> typing.Callable[
            [smart_device_management_service.GetStructureRequest],
            typing.Union[
                site.Structure,
                typing.Awaitable[site.Structure]
            ]]:
        raise NotImplementedError()

    @property
    def list_structures(self) -> typing.Callable[
            [smart_device_management_service.ListStructuresRequest],
            typing.Union[
                smart_device_management_service.ListStructuresResponse,
                typing.Awaitable[smart_device_management_service.ListStructuresResponse]
            ]]:
        raise NotImplementedError()

    @property
    def get_room(self) -> typing.Callable[
            [smart_device_management_service.GetRoomRequest],
            typing.Union[
                site.Room,
                typing.Awaitable[site.Room]
            ]]:
        raise NotImplementedError()

    @property
    def list_rooms(self) -> typing.Callable[
            [smart_device_management_service.ListRoomsRequest],
            typing.Union[
                smart_device_management_service.ListRoomsResponse,
                typing.Awaitable[smart_device_management_service.ListRoomsResponse]
            ]]:
        raise NotImplementedError()


__all__ = (
    'SmartDeviceManagementServiceTransport',
)
