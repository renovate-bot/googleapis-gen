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
from google.api_core import exceptions                 # type: ignore
from google.api_core import gapic_v1                   # type: ignore
from google.api_core import retry as retries           # type: ignore
from google.auth import credentials                    # type: ignore
from google.oauth2 import service_account              # type: ignore

from google.cloud.securitycenter.settings_v1beta1.services.security_center_settings_service import pagers
from google.cloud.securitycenter.settings_v1beta1.types import billing_settings
from google.cloud.securitycenter.settings_v1beta1.types import component_settings
from google.cloud.securitycenter.settings_v1beta1.types import component_settings as gcss_component_settings
from google.cloud.securitycenter.settings_v1beta1.types import detector
from google.cloud.securitycenter.settings_v1beta1.types import securitycenter_settings_service
from google.cloud.securitycenter.settings_v1beta1.types import settings
from google.cloud.securitycenter.settings_v1beta1.types import settings as gcss_settings
from google.cloud.securitycenter.settings_v1beta1.types import sink_settings
from google.protobuf import field_mask_pb2 as field_mask  # type: ignore
from google.protobuf import timestamp_pb2 as timestamp  # type: ignore

from .transports.base import SecurityCenterSettingsServiceTransport, DEFAULT_CLIENT_INFO
from .transports.grpc_asyncio import SecurityCenterSettingsServiceGrpcAsyncIOTransport
from .client import SecurityCenterSettingsServiceClient


class SecurityCenterSettingsServiceAsyncClient:
    """API Overview
    ------------

    The SecurityCenterSettingsService is a sub-api of
    ``securitycenter.googleapis.com``. The service provides methods to
    manage Security Center Settings, and Component Settings for GCP
    organizations, folders, projects, and clusters.
    """

    _client: SecurityCenterSettingsServiceClient

    DEFAULT_ENDPOINT = SecurityCenterSettingsServiceClient.DEFAULT_ENDPOINT
    DEFAULT_MTLS_ENDPOINT = SecurityCenterSettingsServiceClient.DEFAULT_MTLS_ENDPOINT

    component_settings_path = staticmethod(SecurityCenterSettingsServiceClient.component_settings_path)
    parse_component_settings_path = staticmethod(SecurityCenterSettingsServiceClient.parse_component_settings_path)
    service_account_path = staticmethod(SecurityCenterSettingsServiceClient.service_account_path)
    parse_service_account_path = staticmethod(SecurityCenterSettingsServiceClient.parse_service_account_path)
    settings_path = staticmethod(SecurityCenterSettingsServiceClient.settings_path)
    parse_settings_path = staticmethod(SecurityCenterSettingsServiceClient.parse_settings_path)

    common_billing_account_path = staticmethod(SecurityCenterSettingsServiceClient.common_billing_account_path)
    parse_common_billing_account_path = staticmethod(SecurityCenterSettingsServiceClient.parse_common_billing_account_path)

    common_folder_path = staticmethod(SecurityCenterSettingsServiceClient.common_folder_path)
    parse_common_folder_path = staticmethod(SecurityCenterSettingsServiceClient.parse_common_folder_path)

    common_organization_path = staticmethod(SecurityCenterSettingsServiceClient.common_organization_path)
    parse_common_organization_path = staticmethod(SecurityCenterSettingsServiceClient.parse_common_organization_path)

    common_project_path = staticmethod(SecurityCenterSettingsServiceClient.common_project_path)
    parse_common_project_path = staticmethod(SecurityCenterSettingsServiceClient.parse_common_project_path)

    common_location_path = staticmethod(SecurityCenterSettingsServiceClient.common_location_path)
    parse_common_location_path = staticmethod(SecurityCenterSettingsServiceClient.parse_common_location_path)

    from_service_account_info = SecurityCenterSettingsServiceClient.from_service_account_info
    from_service_account_file = SecurityCenterSettingsServiceClient.from_service_account_file
    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> SecurityCenterSettingsServiceTransport:
        """Return the transport used by the client instance.

        Returns:
            SecurityCenterSettingsServiceTransport: The transport used by the client instance.
        """
        return self._client.transport

    get_transport_class = functools.partial(type(SecurityCenterSettingsServiceClient).get_transport_class, type(SecurityCenterSettingsServiceClient))

    def __init__(self, *,
            credentials: credentials.Credentials = None,
            transport: Union[str, SecurityCenterSettingsServiceTransport] = 'grpc_asyncio',
            client_options: ClientOptions = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiate the security center settings service client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, ~.SecurityCenterSettingsServiceTransport]): The
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

        self._client = SecurityCenterSettingsServiceClient(
            credentials=credentials,
            transport=transport,
            client_options=client_options,
            client_info=client_info,

        )

    async def get_service_account(self,
            request: securitycenter_settings_service.GetServiceAccountRequest = None,
            *,
            name: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> securitycenter_settings_service.ServiceAccount:
        r"""Retrieves the organizations service account, if it
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

        Args:
            request (:class:`google.cloud.securitycenter.settings_v1beta1.types.GetServiceAccountRequest`):
                The request object. Request message for
                GetServiceAccount.
            name (:class:`str`):
                Required. The relative resource name of the service
                account resource. Format:

                -  ``organizations/{organization}/serviceAccount``

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.securitycenter.settings_v1beta1.types.ServiceAccount:
                An organization-level service account
                to be used by threat detection
                components.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        request = securitycenter_settings_service.GetServiceAccountRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.

        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_service_account,
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

    async def get_settings(self,
            request: securitycenter_settings_service.GetSettingsRequest = None,
            *,
            name: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> settings.Settings:
        r"""Gets the Settings.

        Args:
            request (:class:`google.cloud.securitycenter.settings_v1beta1.types.GetSettingsRequest`):
                The request object. Request message for GetSettings.
            name (:class:`str`):
                Required. The name of the settings to retrieve. Formats:

                -  ``organizations/{organization}/settings``
                -  ``folders/{folder}/settings``
                -  ``projects/{project}/settings``
                -  ``projects/{project}/locations/{location}/clusters/{cluster}/settings``
                -  ``projects/{project}/regions/{region}/clusters/{cluster}/settings``
                -  ``projects/{project}/zones/{zone}/clusters/{cluster}/settings``

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.securitycenter.settings_v1beta1.types.Settings:
                Common configuration settings for all
                of Security Center.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        request = securitycenter_settings_service.GetSettingsRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.

        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_settings,
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

    async def update_settings(self,
            request: securitycenter_settings_service.UpdateSettingsRequest = None,
            *,
            settings: gcss_settings.Settings = None,
            update_mask: field_mask.FieldMask = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> gcss_settings.Settings:
        r"""Updates the Settings.

        Args:
            request (:class:`google.cloud.securitycenter.settings_v1beta1.types.UpdateSettingsRequest`):
                The request object. Request message for UpdateSettings.
            settings (:class:`google.cloud.securitycenter.settings_v1beta1.types.Settings`):
                Required. The settings to update.

                The settings' ``name`` field is used to identify the
                settings to be updated. Formats:

                -  ``organizations/{organization}/settings``
                -  ``folders/{folder}/settings``
                -  ``projects/{project}/settings``
                -  ``projects/{project}/locations/{location}/clusters/{cluster}/settings``
                -  ``projects/{project}/regions/{region}/clusters/{cluster}/settings``
                -  ``projects/{project}/zones/{zone}/clusters/{cluster}/settings``

                This corresponds to the ``settings`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            update_mask (:class:`google.protobuf.field_mask_pb2.FieldMask`):
                The list of fields to be updated on
                the settings.

                This corresponds to the ``update_mask`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.securitycenter.settings_v1beta1.types.Settings:
                Common configuration settings for all
                of Security Center.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([settings, update_mask])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        request = securitycenter_settings_service.UpdateSettingsRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.

        if settings is not None:
            request.settings = settings
        if update_mask is not None:
            request.update_mask = update_mask

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.update_settings,
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
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('settings.name', request.settings.name),
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

    async def reset_settings(self,
            request: securitycenter_settings_service.ResetSettingsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> None:
        r"""Reset the organization, folder or project's settings
        and return the settings of just that resource to the
        default.
        Settings are present at the organization, folder,
        project, and cluster levels. Using Reset on a sub-
        organization level will remove that resource's override
        and result in the parent's settings being used (eg: if
        Reset on a cluster, project settings will be used).

        Using Reset on organization will remove the override
        that was set and result in default settings being used.

        Args:
            request (:class:`google.cloud.securitycenter.settings_v1beta1.types.ResetSettingsRequest`):
                The request object. Request message for ResetSettings.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        # Create or coerce a protobuf request object.

        request = securitycenter_settings_service.ResetSettingsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.reset_settings,
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
        await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    async def batch_get_settings(self,
            request: securitycenter_settings_service.BatchGetSettingsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> securitycenter_settings_service.BatchGetSettingsResponse:
        r"""Gets a list of settings.

        Args:
            request (:class:`google.cloud.securitycenter.settings_v1beta1.types.BatchGetSettingsRequest`):
                The request object. Request message for
                BatchGetSettings.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.securitycenter.settings_v1beta1.types.BatchGetSettingsResponse:
                Response message for
                BatchGetSettings.

        """
        # Create or coerce a protobuf request object.

        request = securitycenter_settings_service.BatchGetSettingsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.batch_get_settings,
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
        response = await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def calculate_effective_settings(self,
            request: securitycenter_settings_service.CalculateEffectiveSettingsRequest = None,
            *,
            name: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> settings.Settings:
        r"""CalculateEffectiveSettings looks up all of the Security Center
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

        Args:
            request (:class:`google.cloud.securitycenter.settings_v1beta1.types.CalculateEffectiveSettingsRequest`):
                The request object. Request message for
                CalculateEffectiveSettings.
            name (:class:`str`):
                Required. The name of the effective settings to
                retrieve. Formats:

                -  ``organizations/{organization}/effectiveSettings``
                -  ``folders/{folder}/effectiveSettings``
                -  ``projects/{project}/effectiveSettings``
                -  ``projects/{project}/locations/{location}/clusters/{cluster}/effectiveSettings``
                -  ``projects/{project}/regions/{region}/clusters/{cluster}/effectiveSettings``
                -  ``projects/{project}/zones/{zone}/clusters/{cluster}/effectiveSettings``

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.securitycenter.settings_v1beta1.types.Settings:
                Common configuration settings for all
                of Security Center.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        request = securitycenter_settings_service.CalculateEffectiveSettingsRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.

        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.calculate_effective_settings,
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

    async def batch_calculate_effective_settings(self,
            request: securitycenter_settings_service.BatchCalculateEffectiveSettingsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> securitycenter_settings_service.BatchCalculateEffectiveSettingsResponse:
        r"""Gets a list of effective settings.

        Args:
            request (:class:`google.cloud.securitycenter.settings_v1beta1.types.BatchCalculateEffectiveSettingsRequest`):
                The request object. Request message for
                BatchGetEffectiveSettings.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.securitycenter.settings_v1beta1.types.BatchCalculateEffectiveSettingsResponse:
                Response message for
                BatchGetEffectiveSettings.

        """
        # Create or coerce a protobuf request object.

        request = securitycenter_settings_service.BatchCalculateEffectiveSettingsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.batch_calculate_effective_settings,
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
        response = await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def get_component_settings(self,
            request: securitycenter_settings_service.GetComponentSettingsRequest = None,
            *,
            name: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> component_settings.ComponentSettings:
        r"""Gets the Component Settings.

        Args:
            request (:class:`google.cloud.securitycenter.settings_v1beta1.types.GetComponentSettingsRequest`):
                The request object. Request message for
                GetComponentSettings.
            name (:class:`str`):
                Required. The component settings to retrieve.

                Formats:

                -  ``organizations/{organization}/components/{component}/settings``
                -  ``folders/{folder}/components/{component}/settings``
                -  ``projects/{project}/components/{component}/settings``
                -  ``projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings``
                -  ``projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings``
                -  ``projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings``

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.securitycenter.settings_v1beta1.types.ComponentSettings:
                Component Settings for Security
                Command Center

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        request = securitycenter_settings_service.GetComponentSettingsRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.

        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_component_settings,
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

    async def update_component_settings(self,
            request: securitycenter_settings_service.UpdateComponentSettingsRequest = None,
            *,
            component_settings: gcss_component_settings.ComponentSettings = None,
            update_mask: field_mask.FieldMask = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> gcss_component_settings.ComponentSettings:
        r"""Updates the Component Settings.

        Args:
            request (:class:`google.cloud.securitycenter.settings_v1beta1.types.UpdateComponentSettingsRequest`):
                The request object. Request message for
                UpdateComponentSettings.
            component_settings (:class:`google.cloud.securitycenter.settings_v1beta1.types.ComponentSettings`):
                Required. The component settings to update.

                The component settings' ``name`` field is used to
                identify the component settings to be updated. Formats:

                -  ``organizations/{organization}/components/{component}/settings``
                -  ``folders/{folder}/components/{component}/settings``
                -  ``projects/{project}/components/{component}/settings``
                -  ``projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings``
                -  ``projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings``
                -  ``projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings``

                This corresponds to the ``component_settings`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            update_mask (:class:`google.protobuf.field_mask_pb2.FieldMask`):
                The list of fields to be updated on
                the component settings resource.

                This corresponds to the ``update_mask`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.securitycenter.settings_v1beta1.types.ComponentSettings:
                Component Settings for Security
                Command Center

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([component_settings, update_mask])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        request = securitycenter_settings_service.UpdateComponentSettingsRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.

        if component_settings is not None:
            request.component_settings = component_settings
        if update_mask is not None:
            request.update_mask = update_mask

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.update_component_settings,
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
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('component_settings.name', request.component_settings.name),
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

    async def reset_component_settings(self,
            request: securitycenter_settings_service.ResetComponentSettingsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> None:
        r"""Reset the organization, folder or project's component
        settings and return the settings to the default.
        Settings are present at the organization, folder and
        project levels. Using Reset for a folder or project will
        remove the override that was set and result in the
        organization-level settings being used.

        Args:
            request (:class:`google.cloud.securitycenter.settings_v1beta1.types.ResetComponentSettingsRequest`):
                The request object. Request message for
                ResetComponentSettings.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        # Create or coerce a protobuf request object.

        request = securitycenter_settings_service.ResetComponentSettingsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.reset_component_settings,
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
        await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    async def calculate_effective_component_settings(self,
            request: securitycenter_settings_service.CalculateEffectiveComponentSettingsRequest = None,
            *,
            name: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> component_settings.ComponentSettings:
        r"""Gets the Effective Component Settings.

        Args:
            request (:class:`google.cloud.securitycenter.settings_v1beta1.types.CalculateEffectiveComponentSettingsRequest`):
                The request object. Request message for
                CalculateEffectiveComponentSettings.
            name (:class:`str`):
                Required. The effective component settings to retrieve.

                Formats:

                -  ``organizations/{organization}/components/{component}/settings``
                -  ``folders/{folder}/components/{component}/settings``
                -  ``projects/{project}/components/{component}/settings``
                -  ``projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings``
                -  ``projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings``
                -  ``projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings``

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.securitycenter.settings_v1beta1.types.ComponentSettings:
                Component Settings for Security
                Command Center

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        request = securitycenter_settings_service.CalculateEffectiveComponentSettingsRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.

        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.calculate_effective_component_settings,
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

    async def list_detectors(self,
            request: securitycenter_settings_service.ListDetectorsRequest = None,
            *,
            parent: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListDetectorsAsyncPager:
        r"""Retrieves an unordered list of available detectors.

        Args:
            request (:class:`google.cloud.securitycenter.settings_v1beta1.types.ListDetectorsRequest`):
                The request object. Request message for ListDetectors.
            parent (:class:`str`):
                Required. The parent, which owns this collection of
                detectors. Format:

                -  ``organizations/{organization}``

                This corresponds to the ``parent`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.securitycenter.settings_v1beta1.services.security_center_settings_service.pagers.ListDetectorsAsyncPager:
                Response message for ListDetectors.
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([parent])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        request = securitycenter_settings_service.ListDetectorsRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.

        if parent is not None:
            request.parent = parent

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_detectors,
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
        response = await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # This method is paged; wrap the response in a pager, which provides
        # an `__aiter__` convenience method.
        response = pagers.ListDetectorsAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def list_components(self,
            request: securitycenter_settings_service.ListComponentsRequest = None,
            *,
            parent: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListComponentsAsyncPager:
        r"""Retrieves an unordered list of available SCC
        components.

        Args:
            request (:class:`google.cloud.securitycenter.settings_v1beta1.types.ListComponentsRequest`):
                The request object. Request message for ListComponents.
            parent (:class:`str`):
                Required. The parent, which owns this collection of
                components. Format:

                -  ``organizations/{organization}``

                This corresponds to the ``parent`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.

            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.securitycenter.settings_v1beta1.services.security_center_settings_service.pagers.ListComponentsAsyncPager:
                Response message for ListComponents.
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([parent])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        request = securitycenter_settings_service.ListComponentsRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.

        if parent is not None:
            request.parent = parent

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_components,
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
        response = await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # This method is paged; wrap the response in a pager, which provides
        # an `__aiter__` convenience method.
        response = pagers.ListComponentsAsyncPager(
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
            'google-cloud-securitycenter-settings',
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    'SecurityCenterSettingsServiceAsyncClient',
)
