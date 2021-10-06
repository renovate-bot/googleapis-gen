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
import warnings
from typing import Awaitable, Callable, Dict, Optional, Sequence, Tuple, Union

from google.api_core import gapic_v1                   # type: ignore
from google.api_core import grpc_helpers_async         # type: ignore
from google.auth import credentials as ga_credentials   # type: ignore
from google.auth.transport.grpc import SslCredentials  # type: ignore
import packaging.version

import grpc                        # type: ignore
from grpc.experimental import aio  # type: ignore

from google.cloud.securitycenter.settings_v1beta1.types import component_settings
from google.cloud.securitycenter.settings_v1beta1.types import component_settings as gcss_component_settings
from google.cloud.securitycenter.settings_v1beta1.types import securitycenter_settings_service
from google.cloud.securitycenter.settings_v1beta1.types import settings
from google.cloud.securitycenter.settings_v1beta1.types import settings as gcss_settings
from google.protobuf import empty_pb2  # type: ignore
from .base import SecurityCenterSettingsServiceTransport, DEFAULT_CLIENT_INFO
from .grpc import SecurityCenterSettingsServiceGrpcTransport


class SecurityCenterSettingsServiceGrpcAsyncIOTransport(SecurityCenterSettingsServiceTransport):
    """gRPC AsyncIO backend transport for SecurityCenterSettingsService.

    API Overview
    ------------

    The SecurityCenterSettingsService is a sub-api of
    ``securitycenter.googleapis.com``. The service provides methods to
    manage Security Center Settings, and Component Settings for GCP
    organizations, folders, projects, and clusters.

    This class defines the same methods as the primary client, so the
    primary client can load the underlying transport implementation
    and call it.

    It sends protocol buffers over the wire using gRPC (which is built on
    top of HTTP/2); the ``grpcio`` package must be installed.
    """

    _grpc_channel: aio.Channel
    _stubs: Dict[str, Callable] = {}

    @classmethod
    def create_channel(cls,
                       host: str = 'securitycenter.googleapis.com',
                       credentials: ga_credentials.Credentials = None,
                       credentials_file: Optional[str] = None,
                       scopes: Optional[Sequence[str]] = None,
                       quota_project_id: Optional[str] = None,
                       **kwargs) -> aio.Channel:
        """Create and return a gRPC AsyncIO channel object.
        Args:
            host (Optional[str]): The host for the channel to use.
            credentials (Optional[~.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify this application to the service. If
                none are specified, the client will attempt to ascertain
                the credentials from the environment.
            credentials_file (Optional[str]): A file with credentials that can
                be loaded with :func:`google.auth.load_credentials_from_file`.
                This argument is ignored if ``channel`` is provided.
            scopes (Optional[Sequence[str]]): A optional list of scopes needed for this
                service. These are only used when credentials are not specified and
                are passed to :func:`google.auth.default`.
            quota_project_id (Optional[str]): An optional project to use for billing
                and quota.
            kwargs (Optional[dict]): Keyword arguments, which are passed to the
                channel creation.
        Returns:
            aio.Channel: A gRPC AsyncIO channel object.
        """

        return grpc_helpers_async.create_channel(
            host,
            credentials=credentials,
            credentials_file=credentials_file,
            quota_project_id=quota_project_id,
            default_scopes=cls.AUTH_SCOPES,
            scopes=scopes,
            default_host=cls.DEFAULT_HOST,
            **kwargs
        )

    def __init__(self, *,
            host: str = 'securitycenter.googleapis.com',
            credentials: ga_credentials.Credentials = None,
            credentials_file: Optional[str] = None,
            scopes: Optional[Sequence[str]] = None,
            channel: aio.Channel = None,
            api_mtls_endpoint: str = None,
            client_cert_source: Callable[[], Tuple[bytes, bytes]] = None,
            ssl_channel_credentials: grpc.ChannelCredentials = None,
            client_cert_source_for_mtls: Callable[[], Tuple[bytes, bytes]] = None,
            quota_project_id=None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            always_use_jwt_access: Optional[bool] = False,
            ) -> None:
        """Instantiate the transport.

        Args:
            host (Optional[str]):
                 The hostname to connect to.
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
                This argument is ignored if ``channel`` is provided.
            credentials_file (Optional[str]): A file with credentials that can
                be loaded with :func:`google.auth.load_credentials_from_file`.
                This argument is ignored if ``channel`` is provided.
            scopes (Optional[Sequence[str]]): A optional list of scopes needed for this
                service. These are only used when credentials are not specified and
                are passed to :func:`google.auth.default`.
            channel (Optional[aio.Channel]): A ``Channel`` instance through
                which to make calls.
            api_mtls_endpoint (Optional[str]): Deprecated. The mutual TLS endpoint.
                If provided, it overrides the ``host`` argument and tries to create
                a mutual TLS channel with client SSL credentials from
                ``client_cert_source`` or application default SSL credentials.
            client_cert_source (Optional[Callable[[], Tuple[bytes, bytes]]]):
                Deprecated. A callback to provide client SSL certificate bytes and
                private key bytes, both in PEM format. It is ignored if
                ``api_mtls_endpoint`` is None.
            ssl_channel_credentials (grpc.ChannelCredentials): SSL credentials
                for the grpc channel. It is ignored if ``channel`` is provided.
            client_cert_source_for_mtls (Optional[Callable[[], Tuple[bytes, bytes]]]):
                A callback to provide client certificate bytes and private key bytes,
                both in PEM format. It is used to configure a mutual TLS channel. It is
                ignored if ``channel`` or ``ssl_channel_credentials`` is provided.
            quota_project_id (Optional[str]): An optional project to use for billing
                and quota.
            client_info (google.api_core.gapic_v1.client_info.ClientInfo):
                The client info used to send a user-agent string along with
                API requests. If ``None``, then default info will be used.
                Generally, you only need to set this if you're developing
                your own client library.
            always_use_jwt_access (Optional[bool]): Whether self signed JWT should
                be used for service account credentials.

        Raises:
            google.auth.exceptions.MutualTlsChannelError: If mutual TLS transport
              creation failed for any reason.
          google.api_core.exceptions.DuplicateCredentialArgs: If both ``credentials``
              and ``credentials_file`` are passed.
        """
        self._grpc_channel = None
        self._ssl_channel_credentials = ssl_channel_credentials
        self._stubs: Dict[str, Callable] = {}

        if api_mtls_endpoint:
            warnings.warn("api_mtls_endpoint is deprecated", DeprecationWarning)
        if client_cert_source:
            warnings.warn("client_cert_source is deprecated", DeprecationWarning)

        if channel:
            # Ignore credentials if a channel was passed.
            credentials = False
            # If a channel was explicitly provided, set it.
            self._grpc_channel = channel
            self._ssl_channel_credentials = None
        else:
            if api_mtls_endpoint:
                host = api_mtls_endpoint

                # Create SSL credentials with client_cert_source or application
                # default SSL credentials.
                if client_cert_source:
                    cert, key = client_cert_source()
                    self._ssl_channel_credentials = grpc.ssl_channel_credentials(
                        certificate_chain=cert, private_key=key
                    )
                else:
                    self._ssl_channel_credentials = SslCredentials().ssl_credentials

            else:
                if client_cert_source_for_mtls and not ssl_channel_credentials:
                    cert, key = client_cert_source_for_mtls()
                    self._ssl_channel_credentials = grpc.ssl_channel_credentials(
                        certificate_chain=cert, private_key=key
                    )

        # The base transport sets the host, credentials and scopes
        super().__init__(
            host=host,
            credentials=credentials,
            credentials_file=credentials_file,
            scopes=scopes,
            quota_project_id=quota_project_id,
            client_info=client_info,
            always_use_jwt_access=always_use_jwt_access,
        )

        if not self._grpc_channel:
            self._grpc_channel = type(self).create_channel(
                self._host,
                credentials=self._credentials,
                credentials_file=credentials_file,
                scopes=self._scopes,
                ssl_credentials=self._ssl_channel_credentials,
                quota_project_id=quota_project_id,
                options=[
                    ("grpc.max_send_message_length", -1),
                    ("grpc.max_receive_message_length", -1),
                ],
            )

        # Wrap messages. This must be done after self._grpc_channel exists
        self._prep_wrapped_messages(client_info)

    @property
    def grpc_channel(self) -> aio.Channel:
        """Create the channel designed to connect to this service.

        This property caches on the instance; repeated calls return
        the same channel.
        """
        # Return the channel from cache.
        return self._grpc_channel

    @property
    def get_service_account(self) -> Callable[
            [securitycenter_settings_service.GetServiceAccountRequest],
            Awaitable[securitycenter_settings_service.ServiceAccount]]:
        r"""Return a callable for the get service account method over gRPC.

        Retrieves the organizations service account, if it
        exists, otherwise it creates the organization service
        account. This API is idempotent and will only create a
        service account once. On subsequent calls it will return
        the previously created service account.  SHA, SCC and
        CTD Infra Automation will use this SA.  This SA will not
        have any permissions when created.  The UI will
        provision this via IAM or the user will using their own
        internal process. This API only creates SAs on the
        organization. Folders are not supported and projects
        will use per-project SAs associated with APIs enabled on
        a project. This API will be called by the UX onboarding
        workflow.

        Returns:
            Callable[[~.GetServiceAccountRequest],
                    Awaitable[~.ServiceAccount]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_service_account' not in self._stubs:
            self._stubs['get_service_account'] = self.grpc_channel.unary_unary(
                '/google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService/GetServiceAccount',
                request_serializer=securitycenter_settings_service.GetServiceAccountRequest.serialize,
                response_deserializer=securitycenter_settings_service.ServiceAccount.deserialize,
            )
        return self._stubs['get_service_account']

    @property
    def get_settings(self) -> Callable[
            [securitycenter_settings_service.GetSettingsRequest],
            Awaitable[settings.Settings]]:
        r"""Return a callable for the get settings method over gRPC.

        Gets the Settings.

        Returns:
            Callable[[~.GetSettingsRequest],
                    Awaitable[~.Settings]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_settings' not in self._stubs:
            self._stubs['get_settings'] = self.grpc_channel.unary_unary(
                '/google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService/GetSettings',
                request_serializer=securitycenter_settings_service.GetSettingsRequest.serialize,
                response_deserializer=settings.Settings.deserialize,
            )
        return self._stubs['get_settings']

    @property
    def update_settings(self) -> Callable[
            [securitycenter_settings_service.UpdateSettingsRequest],
            Awaitable[gcss_settings.Settings]]:
        r"""Return a callable for the update settings method over gRPC.

        Updates the Settings.

        Returns:
            Callable[[~.UpdateSettingsRequest],
                    Awaitable[~.Settings]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update_settings' not in self._stubs:
            self._stubs['update_settings'] = self.grpc_channel.unary_unary(
                '/google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService/UpdateSettings',
                request_serializer=securitycenter_settings_service.UpdateSettingsRequest.serialize,
                response_deserializer=gcss_settings.Settings.deserialize,
            )
        return self._stubs['update_settings']

    @property
    def reset_settings(self) -> Callable[
            [securitycenter_settings_service.ResetSettingsRequest],
            Awaitable[empty_pb2.Empty]]:
        r"""Return a callable for the reset settings method over gRPC.

        Reset the organization, folder or project's settings
        and return the settings of just that resource to the
        default.
        Settings are present at the organization, folder,
        project, and cluster levels. Using Reset on a sub-
        organization level will remove that resource's override
        and result in the parent's settings being used (eg: if
        Reset on a cluster, project settings will be used).

        Using Reset on organization will remove the override
        that was set and result in default settings being used.

        Returns:
            Callable[[~.ResetSettingsRequest],
                    Awaitable[~.Empty]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'reset_settings' not in self._stubs:
            self._stubs['reset_settings'] = self.grpc_channel.unary_unary(
                '/google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService/ResetSettings',
                request_serializer=securitycenter_settings_service.ResetSettingsRequest.serialize,
                response_deserializer=empty_pb2.Empty.FromString,
            )
        return self._stubs['reset_settings']

    @property
    def batch_get_settings(self) -> Callable[
            [securitycenter_settings_service.BatchGetSettingsRequest],
            Awaitable[securitycenter_settings_service.BatchGetSettingsResponse]]:
        r"""Return a callable for the batch get settings method over gRPC.

        Gets a list of settings.

        Returns:
            Callable[[~.BatchGetSettingsRequest],
                    Awaitable[~.BatchGetSettingsResponse]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'batch_get_settings' not in self._stubs:
            self._stubs['batch_get_settings'] = self.grpc_channel.unary_unary(
                '/google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService/BatchGetSettings',
                request_serializer=securitycenter_settings_service.BatchGetSettingsRequest.serialize,
                response_deserializer=securitycenter_settings_service.BatchGetSettingsResponse.deserialize,
            )
        return self._stubs['batch_get_settings']

    @property
    def calculate_effective_settings(self) -> Callable[
            [securitycenter_settings_service.CalculateEffectiveSettingsRequest],
            Awaitable[settings.Settings]]:
        r"""Return a callable for the calculate effective settings method over gRPC.

        CalculateEffectiveSettings looks up all of the Security Center
        Settings resources in the GCP resource hierarchy, and calculates
        the effective settings on that resource by applying the
        following rules:

        -  Settings provided closer to the target resource take
           precedence over those further away (e.g. folder will override
           organization level settings).
        -  Product defaults can be overridden at org, folder, project,
           and cluster levels.
        -  Detectors will be filtered out if they belong to a billing
           tier the customer has not configured.

        Returns:
            Callable[[~.CalculateEffectiveSettingsRequest],
                    Awaitable[~.Settings]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'calculate_effective_settings' not in self._stubs:
            self._stubs['calculate_effective_settings'] = self.grpc_channel.unary_unary(
                '/google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService/CalculateEffectiveSettings',
                request_serializer=securitycenter_settings_service.CalculateEffectiveSettingsRequest.serialize,
                response_deserializer=settings.Settings.deserialize,
            )
        return self._stubs['calculate_effective_settings']

    @property
    def batch_calculate_effective_settings(self) -> Callable[
            [securitycenter_settings_service.BatchCalculateEffectiveSettingsRequest],
            Awaitable[securitycenter_settings_service.BatchCalculateEffectiveSettingsResponse]]:
        r"""Return a callable for the batch calculate effective
        settings method over gRPC.

        Gets a list of effective settings.

        Returns:
            Callable[[~.BatchCalculateEffectiveSettingsRequest],
                    Awaitable[~.BatchCalculateEffectiveSettingsResponse]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'batch_calculate_effective_settings' not in self._stubs:
            self._stubs['batch_calculate_effective_settings'] = self.grpc_channel.unary_unary(
                '/google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService/BatchCalculateEffectiveSettings',
                request_serializer=securitycenter_settings_service.BatchCalculateEffectiveSettingsRequest.serialize,
                response_deserializer=securitycenter_settings_service.BatchCalculateEffectiveSettingsResponse.deserialize,
            )
        return self._stubs['batch_calculate_effective_settings']

    @property
    def get_component_settings(self) -> Callable[
            [securitycenter_settings_service.GetComponentSettingsRequest],
            Awaitable[component_settings.ComponentSettings]]:
        r"""Return a callable for the get component settings method over gRPC.

        Gets the Component Settings.

        Returns:
            Callable[[~.GetComponentSettingsRequest],
                    Awaitable[~.ComponentSettings]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_component_settings' not in self._stubs:
            self._stubs['get_component_settings'] = self.grpc_channel.unary_unary(
                '/google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService/GetComponentSettings',
                request_serializer=securitycenter_settings_service.GetComponentSettingsRequest.serialize,
                response_deserializer=component_settings.ComponentSettings.deserialize,
            )
        return self._stubs['get_component_settings']

    @property
    def update_component_settings(self) -> Callable[
            [securitycenter_settings_service.UpdateComponentSettingsRequest],
            Awaitable[gcss_component_settings.ComponentSettings]]:
        r"""Return a callable for the update component settings method over gRPC.

        Updates the Component Settings.

        Returns:
            Callable[[~.UpdateComponentSettingsRequest],
                    Awaitable[~.ComponentSettings]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update_component_settings' not in self._stubs:
            self._stubs['update_component_settings'] = self.grpc_channel.unary_unary(
                '/google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService/UpdateComponentSettings',
                request_serializer=securitycenter_settings_service.UpdateComponentSettingsRequest.serialize,
                response_deserializer=gcss_component_settings.ComponentSettings.deserialize,
            )
        return self._stubs['update_component_settings']

    @property
    def reset_component_settings(self) -> Callable[
            [securitycenter_settings_service.ResetComponentSettingsRequest],
            Awaitable[empty_pb2.Empty]]:
        r"""Return a callable for the reset component settings method over gRPC.

        Reset the organization, folder or project's component
        settings and return the settings to the default.
        Settings are present at the organization, folder and
        project levels. Using Reset for a folder or project will
        remove the override that was set and result in the
        organization-level settings being used.

        Returns:
            Callable[[~.ResetComponentSettingsRequest],
                    Awaitable[~.Empty]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'reset_component_settings' not in self._stubs:
            self._stubs['reset_component_settings'] = self.grpc_channel.unary_unary(
                '/google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService/ResetComponentSettings',
                request_serializer=securitycenter_settings_service.ResetComponentSettingsRequest.serialize,
                response_deserializer=empty_pb2.Empty.FromString,
            )
        return self._stubs['reset_component_settings']

    @property
    def calculate_effective_component_settings(self) -> Callable[
            [securitycenter_settings_service.CalculateEffectiveComponentSettingsRequest],
            Awaitable[component_settings.ComponentSettings]]:
        r"""Return a callable for the calculate effective component
        settings method over gRPC.

        Gets the Effective Component Settings.

        Returns:
            Callable[[~.CalculateEffectiveComponentSettingsRequest],
                    Awaitable[~.ComponentSettings]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'calculate_effective_component_settings' not in self._stubs:
            self._stubs['calculate_effective_component_settings'] = self.grpc_channel.unary_unary(
                '/google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService/CalculateEffectiveComponentSettings',
                request_serializer=securitycenter_settings_service.CalculateEffectiveComponentSettingsRequest.serialize,
                response_deserializer=component_settings.ComponentSettings.deserialize,
            )
        return self._stubs['calculate_effective_component_settings']

    @property
    def list_detectors(self) -> Callable[
            [securitycenter_settings_service.ListDetectorsRequest],
            Awaitable[securitycenter_settings_service.ListDetectorsResponse]]:
        r"""Return a callable for the list detectors method over gRPC.

        Retrieves an unordered list of available detectors.

        Returns:
            Callable[[~.ListDetectorsRequest],
                    Awaitable[~.ListDetectorsResponse]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_detectors' not in self._stubs:
            self._stubs['list_detectors'] = self.grpc_channel.unary_unary(
                '/google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService/ListDetectors',
                request_serializer=securitycenter_settings_service.ListDetectorsRequest.serialize,
                response_deserializer=securitycenter_settings_service.ListDetectorsResponse.deserialize,
            )
        return self._stubs['list_detectors']

    @property
    def list_components(self) -> Callable[
            [securitycenter_settings_service.ListComponentsRequest],
            Awaitable[securitycenter_settings_service.ListComponentsResponse]]:
        r"""Return a callable for the list components method over gRPC.

        Retrieves an unordered list of available SCC
        components.

        Returns:
            Callable[[~.ListComponentsRequest],
                    Awaitable[~.ListComponentsResponse]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_components' not in self._stubs:
            self._stubs['list_components'] = self.grpc_channel.unary_unary(
                '/google.cloud.securitycenter.settings.v1beta1.SecurityCenterSettingsService/ListComponents',
                request_serializer=securitycenter_settings_service.ListComponentsRequest.serialize,
                response_deserializer=securitycenter_settings_service.ListComponentsResponse.deserialize,
            )
        return self._stubs['list_components']

    def close(self):
        return self.grpc_channel.close()


__all__ = (
    'SecurityCenterSettingsServiceGrpcAsyncIOTransport',
)
