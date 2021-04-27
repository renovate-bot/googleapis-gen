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
from distutils import util
import os
import re
from typing import Callable, Dict, Optional, Sequence, Tuple, Type, Union
import pkg_resources

from google.api_core import client_options as client_options_lib  # type: ignore
from google.api_core import exceptions                            # type: ignore
from google.api_core import gapic_v1                              # type: ignore
from google.api_core import retry as retries                      # type: ignore
from google.auth import credentials                               # type: ignore
from google.auth.transport import mtls                            # type: ignore
from google.auth.transport.grpc import SslCredentials             # type: ignore
from google.auth.exceptions import MutualTLSChannelError          # type: ignore
from google.oauth2 import service_account                         # type: ignore

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
from .transports.grpc import SecurityCenterSettingsServiceGrpcTransport
from .transports.grpc_asyncio import SecurityCenterSettingsServiceGrpcAsyncIOTransport


class SecurityCenterSettingsServiceClientMeta(type):
    """Metaclass for the SecurityCenterSettingsService client.

    This provides class-level methods for building and retrieving
    support objects (e.g. transport) without polluting the client instance
    objects.
    """
    _transport_registry = OrderedDict()  # type: Dict[str, Type[SecurityCenterSettingsServiceTransport]]
    _transport_registry['grpc'] = SecurityCenterSettingsServiceGrpcTransport
    _transport_registry['grpc_asyncio'] = SecurityCenterSettingsServiceGrpcAsyncIOTransport

    def get_transport_class(cls,
            label: str = None,
        ) -> Type[SecurityCenterSettingsServiceTransport]:
        """Return an appropriate transport class.

        Args:
            label: The name of the desired transport. If none is
                provided, then the first transport in the registry is used.

        Returns:
            The transport class to use.
        """
        # If a specific transport is requested, return that one.
        if label:
            return cls._transport_registry[label]

        # No transport is requested; return the default (that is, the first one
        # in the dictionary).
        return next(iter(cls._transport_registry.values()))


class SecurityCenterSettingsServiceClient(metaclass=SecurityCenterSettingsServiceClientMeta):
    """API Overview
    ------------

    The SecurityCenterSettingsService is a sub-api of
    ``securitycenter.googleapis.com``. The service provides methods to
    manage Security Center Settings, and Component Settings for GCP
    organizations, folders, projects, and clusters.
    """

    @staticmethod
    def _get_default_mtls_endpoint(api_endpoint):
        """Convert api endpoint to mTLS endpoint.
        Convert "*.sandbox.googleapis.com" and "*.googleapis.com" to
        "*.mtls.sandbox.googleapis.com" and "*.mtls.googleapis.com" respectively.
        Args:
            api_endpoint (Optional[str]): the api endpoint to convert.
        Returns:
            str: converted mTLS api endpoint.
        """
        if not api_endpoint:
            return api_endpoint

        mtls_endpoint_re = re.compile(
            r"(?P<name>[^.]+)(?P<mtls>\.mtls)?(?P<sandbox>\.sandbox)?(?P<googledomain>\.googleapis\.com)?"
        )

        m = mtls_endpoint_re.match(api_endpoint)
        name, mtls, sandbox, googledomain = m.groups()
        if mtls or not googledomain:
            return api_endpoint

        if sandbox:
            return api_endpoint.replace(
                "sandbox.googleapis.com", "mtls.sandbox.googleapis.com"
            )

        return api_endpoint.replace(".googleapis.com", ".mtls.googleapis.com")

    DEFAULT_ENDPOINT = 'securitycenter.googleapis.com'
    DEFAULT_MTLS_ENDPOINT = _get_default_mtls_endpoint.__func__(  # type: ignore
        DEFAULT_ENDPOINT
    )

    @classmethod
    def from_service_account_info(cls, info: dict, *args, **kwargs):
        """Creates an instance of this client using the provided credentials info.

        Args:
            info (dict): The service account private key info.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            SecurityCenterSettingsServiceClient: The constructed client.
        """
        credentials = service_account.Credentials.from_service_account_info(info)
        kwargs["credentials"] = credentials
        return cls(*args, **kwargs)

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
            SecurityCenterSettingsServiceClient: The constructed client.
        """
        credentials = service_account.Credentials.from_service_account_file(
            filename)
        kwargs['credentials'] = credentials
        return cls(*args, **kwargs)

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> SecurityCenterSettingsServiceTransport:
        """Return the transport used by the client instance.

        Returns:
            SecurityCenterSettingsServiceTransport: The transport used by the client instance.
        """
        return self._transport

    @staticmethod
    def component_settings_path(organization: str,component: str,) -> str:
        """Return a fully-qualified component_settings string."""
        return "organizations/{organization}/components/{component}/settings".format(organization=organization, component=component, )

    @staticmethod
    def parse_component_settings_path(path: str) -> Dict[str,str]:
        """Parse a component_settings path into its component segments."""
        m = re.match(r"^organizations/(?P<organization>.+?)/components/(?P<component>.+?)/settings$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def service_account_path(organization: str,) -> str:
        """Return a fully-qualified service_account string."""
        return "organizations/{organization}/serviceAccount".format(organization=organization, )

    @staticmethod
    def parse_service_account_path(path: str) -> Dict[str,str]:
        """Parse a service_account path into its component segments."""
        m = re.match(r"^organizations/(?P<organization>.+?)/serviceAccount$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def settings_path(organization: str,) -> str:
        """Return a fully-qualified settings string."""
        return "organizations/{organization}/settings".format(organization=organization, )

    @staticmethod
    def parse_settings_path(path: str) -> Dict[str,str]:
        """Parse a settings path into its component segments."""
        m = re.match(r"^organizations/(?P<organization>.+?)/settings$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def common_billing_account_path(billing_account: str, ) -> str:
        """Return a fully-qualified billing_account string."""
        return "billingAccounts/{billing_account}".format(billing_account=billing_account, )

    @staticmethod
    def parse_common_billing_account_path(path: str) -> Dict[str,str]:
        """Parse a billing_account path into its component segments."""
        m = re.match(r"^billingAccounts/(?P<billing_account>.+?)$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def common_folder_path(folder: str, ) -> str:
        """Return a fully-qualified folder string."""
        return "folders/{folder}".format(folder=folder, )

    @staticmethod
    def parse_common_folder_path(path: str) -> Dict[str,str]:
        """Parse a folder path into its component segments."""
        m = re.match(r"^folders/(?P<folder>.+?)$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def common_organization_path(organization: str, ) -> str:
        """Return a fully-qualified organization string."""
        return "organizations/{organization}".format(organization=organization, )

    @staticmethod
    def parse_common_organization_path(path: str) -> Dict[str,str]:
        """Parse a organization path into its component segments."""
        m = re.match(r"^organizations/(?P<organization>.+?)$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def common_project_path(project: str, ) -> str:
        """Return a fully-qualified project string."""
        return "projects/{project}".format(project=project, )

    @staticmethod
    def parse_common_project_path(path: str) -> Dict[str,str]:
        """Parse a project path into its component segments."""
        m = re.match(r"^projects/(?P<project>.+?)$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def common_location_path(project: str, location: str, ) -> str:
        """Return a fully-qualified location string."""
        return "projects/{project}/locations/{location}".format(project=project, location=location, )

    @staticmethod
    def parse_common_location_path(path: str) -> Dict[str,str]:
        """Parse a location path into its component segments."""
        m = re.match(r"^projects/(?P<project>.+?)/locations/(?P<location>.+?)$", path)
        return m.groupdict() if m else {}

    def __init__(self, *,
            credentials: Optional[credentials.Credentials] = None,
            transport: Union[str, SecurityCenterSettingsServiceTransport, None] = None,
            client_options: Optional[client_options_lib.ClientOptions] = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiate the security center settings service client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, SecurityCenterSettingsServiceTransport]): The
                transport to use. If set to None, a transport is chosen
                automatically.
            client_options (google.api_core.client_options.ClientOptions): Custom options for the
                client. It won't take effect if a ``transport`` instance is provided.
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
            client_info (google.api_core.gapic_v1.client_info.ClientInfo):
                The client info used to send a user-agent string along with
                API requests. If ``None``, then default info will be used.
                Generally, you only need to set this if you're developing
                your own client library.

        Raises:
            google.auth.exceptions.MutualTLSChannelError: If mutual TLS transport
                creation failed for any reason.
        """
        if isinstance(client_options, dict):
            client_options = client_options_lib.from_dict(client_options)
        if client_options is None:
            client_options = client_options_lib.ClientOptions()

        # Create SSL credentials for mutual TLS if needed.
        use_client_cert = bool(util.strtobool(os.getenv("GOOGLE_API_USE_CLIENT_CERTIFICATE", "false")))

        client_cert_source_func = None
        is_mtls = False
        if use_client_cert:
            if client_options.client_cert_source:
                is_mtls = True
                client_cert_source_func = client_options.client_cert_source
            else:
                is_mtls = mtls.has_default_client_cert_source()
                client_cert_source_func = mtls.default_client_cert_source() if is_mtls else None

        # Figure out which api endpoint to use.
        if client_options.api_endpoint is not None:
            api_endpoint = client_options.api_endpoint
        else:
            use_mtls_env = os.getenv("GOOGLE_API_USE_MTLS_ENDPOINT", "auto")
            if use_mtls_env == "never":
                api_endpoint = self.DEFAULT_ENDPOINT
            elif use_mtls_env == "always":
                api_endpoint = self.DEFAULT_MTLS_ENDPOINT
            elif use_mtls_env == "auto":
                api_endpoint = self.DEFAULT_MTLS_ENDPOINT if is_mtls else self.DEFAULT_ENDPOINT
            else:
                raise MutualTLSChannelError(
                    "Unsupported GOOGLE_API_USE_MTLS_ENDPOINT value. Accepted values: never, auto, always"
                )

        # Save or instantiate the transport.
        # Ordinarily, we provide the transport, but allowing a custom transport
        # instance provides an extensibility point for unusual situations.
        if isinstance(transport, SecurityCenterSettingsServiceTransport):
            # transport is a SecurityCenterSettingsServiceTransport instance.
            if credentials or client_options.credentials_file:
                raise ValueError('When providing a transport instance, '
                                 'provide its credentials directly.')
            if client_options.scopes:
                raise ValueError(
                    "When providing a transport instance, "
                    "provide its scopes directly."
                )
            self._transport = transport
        else:
            Transport = type(self).get_transport_class(transport)
            self._transport = Transport(
                credentials=credentials,
                credentials_file=client_options.credentials_file,
                host=api_endpoint,
                scopes=client_options.scopes,
                client_cert_source_for_mtls=client_cert_source_func,
                quota_project_id=client_options.quota_project_id,
                client_info=client_info,
            )

    def get_service_account(self,
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
            request (google.cloud.securitycenter.settings_v1beta1.types.GetServiceAccountRequest):
                The request object.
                Request message for
                GetServiceAccount.
            name (str):
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

        # Minor optimization to avoid making a copy if the user passes
        # in a securitycenter_settings_service.GetServiceAccountRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, securitycenter_settings_service.GetServiceAccountRequest):
            request = securitycenter_settings_service.GetServiceAccountRequest(request)
             # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if name is not None:
                request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.get_service_account]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('name', request.name),
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

    def get_settings(self,
            request: securitycenter_settings_service.GetSettingsRequest = None,
            *,
            name: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> settings.Settings:
        r"""Gets the Settings.

        Args:
            request (google.cloud.securitycenter.settings_v1beta1.types.GetSettingsRequest):
                The request object.
                Request message for GetSettings.
            name (str):
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

        # Minor optimization to avoid making a copy if the user passes
        # in a securitycenter_settings_service.GetSettingsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, securitycenter_settings_service.GetSettingsRequest):
            request = securitycenter_settings_service.GetSettingsRequest(request)
             # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if name is not None:
                request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.get_settings]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('name', request.name),
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

    def update_settings(self,
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
            request (google.cloud.securitycenter.settings_v1beta1.types.UpdateSettingsRequest):
                The request object.
                Request message for UpdateSettings.
            settings (google.cloud.securitycenter.settings_v1beta1.types.Settings):
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
            update_mask (google.protobuf.field_mask_pb2.FieldMask):
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

        # Minor optimization to avoid making a copy if the user passes
        # in a securitycenter_settings_service.UpdateSettingsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, securitycenter_settings_service.UpdateSettingsRequest):
            request = securitycenter_settings_service.UpdateSettingsRequest(request)
             # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if settings is not None:
                request.settings = settings
            if update_mask is not None:
                request.update_mask = update_mask

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.update_settings]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('settings.name', request.settings.name),
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

    def reset_settings(self,
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
            request (google.cloud.securitycenter.settings_v1beta1.types.ResetSettingsRequest):
                The request object.
                Request message for ResetSettings.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        # Create or coerce a protobuf request object.
        # Minor optimization to avoid making a copy if the user passes
        # in a securitycenter_settings_service.ResetSettingsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, securitycenter_settings_service.ResetSettingsRequest):
            request = securitycenter_settings_service.ResetSettingsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.reset_settings]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('name', request.name),
            )),
        )

        # Send the request.
        rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    def batch_get_settings(self,
            request: securitycenter_settings_service.BatchGetSettingsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> securitycenter_settings_service.BatchGetSettingsResponse:
        r"""Gets a list of settings.

        Args:
            request (google.cloud.securitycenter.settings_v1beta1.types.BatchGetSettingsRequest):
                The request object.
                Request message for
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
        # Minor optimization to avoid making a copy if the user passes
        # in a securitycenter_settings_service.BatchGetSettingsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, securitycenter_settings_service.BatchGetSettingsRequest):
            request = securitycenter_settings_service.BatchGetSettingsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.batch_get_settings]

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

    def calculate_effective_settings(self,
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
            request (google.cloud.securitycenter.settings_v1beta1.types.CalculateEffectiveSettingsRequest):
                The request object.
                Request message for
                CalculateEffectiveSettings.
            name (str):
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

        # Minor optimization to avoid making a copy if the user passes
        # in a securitycenter_settings_service.CalculateEffectiveSettingsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, securitycenter_settings_service.CalculateEffectiveSettingsRequest):
            request = securitycenter_settings_service.CalculateEffectiveSettingsRequest(request)
             # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if name is not None:
                request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.calculate_effective_settings]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('name', request.name),
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

    def batch_calculate_effective_settings(self,
            request: securitycenter_settings_service.BatchCalculateEffectiveSettingsRequest = None,
            *,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> securitycenter_settings_service.BatchCalculateEffectiveSettingsResponse:
        r"""Gets a list of effective settings.

        Args:
            request (google.cloud.securitycenter.settings_v1beta1.types.BatchCalculateEffectiveSettingsRequest):
                The request object.
                Request message for
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
        # Minor optimization to avoid making a copy if the user passes
        # in a securitycenter_settings_service.BatchCalculateEffectiveSettingsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, securitycenter_settings_service.BatchCalculateEffectiveSettingsRequest):
            request = securitycenter_settings_service.BatchCalculateEffectiveSettingsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.batch_calculate_effective_settings]

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

    def get_component_settings(self,
            request: securitycenter_settings_service.GetComponentSettingsRequest = None,
            *,
            name: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> component_settings.ComponentSettings:
        r"""Gets the Component Settings.

        Args:
            request (google.cloud.securitycenter.settings_v1beta1.types.GetComponentSettingsRequest):
                The request object.
                Request message for
                GetComponentSettings.
            name (str):
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

        # Minor optimization to avoid making a copy if the user passes
        # in a securitycenter_settings_service.GetComponentSettingsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, securitycenter_settings_service.GetComponentSettingsRequest):
            request = securitycenter_settings_service.GetComponentSettingsRequest(request)
             # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if name is not None:
                request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.get_component_settings]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('name', request.name),
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

    def update_component_settings(self,
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
            request (google.cloud.securitycenter.settings_v1beta1.types.UpdateComponentSettingsRequest):
                The request object.
                Request message for
                UpdateComponentSettings.
            component_settings (google.cloud.securitycenter.settings_v1beta1.types.ComponentSettings):
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
            update_mask (google.protobuf.field_mask_pb2.FieldMask):
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

        # Minor optimization to avoid making a copy if the user passes
        # in a securitycenter_settings_service.UpdateComponentSettingsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, securitycenter_settings_service.UpdateComponentSettingsRequest):
            request = securitycenter_settings_service.UpdateComponentSettingsRequest(request)
             # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if component_settings is not None:
                request.component_settings = component_settings
            if update_mask is not None:
                request.update_mask = update_mask

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.update_component_settings]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('component_settings.name', request.component_settings.name),
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

    def reset_component_settings(self,
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
            request (google.cloud.securitycenter.settings_v1beta1.types.ResetComponentSettingsRequest):
                The request object.
                Request message for
                ResetComponentSettings.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        # Create or coerce a protobuf request object.
        # Minor optimization to avoid making a copy if the user passes
        # in a securitycenter_settings_service.ResetComponentSettingsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, securitycenter_settings_service.ResetComponentSettingsRequest):
            request = securitycenter_settings_service.ResetComponentSettingsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.reset_component_settings]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('name', request.name),
            )),
        )

        # Send the request.
        rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    def calculate_effective_component_settings(self,
            request: securitycenter_settings_service.CalculateEffectiveComponentSettingsRequest = None,
            *,
            name: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> component_settings.ComponentSettings:
        r"""Gets the Effective Component Settings.

        Args:
            request (google.cloud.securitycenter.settings_v1beta1.types.CalculateEffectiveComponentSettingsRequest):
                The request object.
                Request message for
                CalculateEffectiveComponentSettings.
            name (str):
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

        # Minor optimization to avoid making a copy if the user passes
        # in a securitycenter_settings_service.CalculateEffectiveComponentSettingsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, securitycenter_settings_service.CalculateEffectiveComponentSettingsRequest):
            request = securitycenter_settings_service.CalculateEffectiveComponentSettingsRequest(request)
             # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if name is not None:
                request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.calculate_effective_component_settings]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('name', request.name),
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

    def list_detectors(self,
            request: securitycenter_settings_service.ListDetectorsRequest = None,
            *,
            parent: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListDetectorsPager:
        r"""Retrieves an unordered list of available detectors.

        Args:
            request (google.cloud.securitycenter.settings_v1beta1.types.ListDetectorsRequest):
                The request object.
                Request message for ListDetectors.
            parent (str):
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
            google.cloud.securitycenter.settings_v1beta1.services.security_center_settings_service.pagers.ListDetectorsPager:
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

        # Minor optimization to avoid making a copy if the user passes
        # in a securitycenter_settings_service.ListDetectorsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, securitycenter_settings_service.ListDetectorsRequest):
            request = securitycenter_settings_service.ListDetectorsRequest(request)
             # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if parent is not None:
                request.parent = parent

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.list_detectors]

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

        # This method is paged; wrap the response in a pager, which provides
        # an `__iter__` convenience method.
        response = pagers.ListDetectorsPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def list_components(self,
            request: securitycenter_settings_service.ListComponentsRequest = None,
            *,
            parent: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListComponentsPager:
        r"""Retrieves an unordered list of available SCC
        components.

        Args:
            request (google.cloud.securitycenter.settings_v1beta1.types.ListComponentsRequest):
                The request object.
                Request message for ListComponents.
            parent (str):
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
            google.cloud.securitycenter.settings_v1beta1.services.security_center_settings_service.pagers.ListComponentsPager:
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

        # Minor optimization to avoid making a copy if the user passes
        # in a securitycenter_settings_service.ListComponentsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, securitycenter_settings_service.ListComponentsRequest):
            request = securitycenter_settings_service.ListComponentsRequest(request)
             # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if parent is not None:
                request.parent = parent

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.list_components]

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

        # This method is paged; wrap the response in a pager, which provides
        # an `__iter__` convenience method.
        response = pagers.ListComponentsPager(
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
    'SecurityCenterSettingsServiceClient',
)
