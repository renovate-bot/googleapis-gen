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

from google.api_core.client_options import ClientOptions
from google.api_core import exceptions as core_exceptions
from google.api_core import gapic_v1
from google.api_core import retry as retries
from google.auth import credentials as ga_credentials   # type: ignore
from google.oauth2 import service_account              # type: ignore

try:
    OptionalRetry = Union[retries.Retry, gapic_v1.method._MethodDefault]
except AttributeError:  # pragma: NO COVER
    OptionalRetry = Union[retries.Retry, object]  # type: ignore

from google.cloud.workspace_add_ons_v1.services.g_suite_add_ons import pagers
from google.cloud.workspace_add_ons_v1.types import gsuiteaddons
from google.protobuf import wrappers_pb2  # type: ignore
from .transports.base import GSuiteAddOnsTransport, DEFAULT_CLIENT_INFO
from .transports.grpc_asyncio import GSuiteAddOnsGrpcAsyncIOTransport
from .client import GSuiteAddOnsClient


class GSuiteAddOnsAsyncClient:
    """A service for managing Google Workspace Add-ons deployments.
    A Google Workspace Add-on is a third-party embedded component
    that can be installed in Google Workspace Applications like
    Gmail, Calendar, Drive, and the Google Docs, Sheets, and Slides
    editors. Google Workspace Add-ons can display UI cards, receive
    contextual information from the host application, and perform
    actions in the host application (See:
    https://developers.google.com/gsuite/add-ons/overview for more
    information).
    A Google Workspace Add-on deployment resource specifies metadata
    about the add-on, including a specification of the entry points
    in the host application that trigger add-on executions (see:
    https://developers.google.com/gsuite/add-ons/concepts/gsuite-
    manifests). Add-on deployments defined via the Google Workspace
    Add-ons API define their entrypoints using HTTPS URLs (See:
    https://developers.google.com/gsuite/add-ons/guides/alternate-
    runtimes),
    A Google Workspace Add-on deployment can be installed in
    developer mode, which allows an add-on developer to test the
    experience an end-user would see when installing and running the
    add-on in their G Suite applications.  When running in developer
    mode, more detailed error messages are exposed in the add-on UI
    to aid in debugging.

    A Google Workspace Add-on deployment can be published to Google
    Workspace Marketplace, which allows other Google Workspace users
    to discover and install the add-on.  See:
    https://developers.google.com/gsuite/add-ons/how-tos/publish-
    add-on-overview for details.
    """

    _client: GSuiteAddOnsClient

    DEFAULT_ENDPOINT = GSuiteAddOnsClient.DEFAULT_ENDPOINT
    DEFAULT_MTLS_ENDPOINT = GSuiteAddOnsClient.DEFAULT_MTLS_ENDPOINT

    authorization_path = staticmethod(GSuiteAddOnsClient.authorization_path)
    parse_authorization_path = staticmethod(GSuiteAddOnsClient.parse_authorization_path)
    deployment_path = staticmethod(GSuiteAddOnsClient.deployment_path)
    parse_deployment_path = staticmethod(GSuiteAddOnsClient.parse_deployment_path)
    install_status_path = staticmethod(GSuiteAddOnsClient.install_status_path)
    parse_install_status_path = staticmethod(GSuiteAddOnsClient.parse_install_status_path)
    common_billing_account_path = staticmethod(GSuiteAddOnsClient.common_billing_account_path)
    parse_common_billing_account_path = staticmethod(GSuiteAddOnsClient.parse_common_billing_account_path)
    common_folder_path = staticmethod(GSuiteAddOnsClient.common_folder_path)
    parse_common_folder_path = staticmethod(GSuiteAddOnsClient.parse_common_folder_path)
    common_organization_path = staticmethod(GSuiteAddOnsClient.common_organization_path)
    parse_common_organization_path = staticmethod(GSuiteAddOnsClient.parse_common_organization_path)
    common_project_path = staticmethod(GSuiteAddOnsClient.common_project_path)
    parse_common_project_path = staticmethod(GSuiteAddOnsClient.parse_common_project_path)
    common_location_path = staticmethod(GSuiteAddOnsClient.common_location_path)
    parse_common_location_path = staticmethod(GSuiteAddOnsClient.parse_common_location_path)

    @classmethod
    def from_service_account_info(cls, info: dict, *args, **kwargs):
        """Creates an instance of this client using the provided credentials
            info.

        Args:
            info (dict): The service account private key info.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            GSuiteAddOnsAsyncClient: The constructed client.
        """
        return GSuiteAddOnsClient.from_service_account_info.__func__(GSuiteAddOnsAsyncClient, info, *args, **kwargs)  # type: ignore

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
            GSuiteAddOnsAsyncClient: The constructed client.
        """
        return GSuiteAddOnsClient.from_service_account_file.__func__(GSuiteAddOnsAsyncClient, filename, *args, **kwargs)  # type: ignore

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> GSuiteAddOnsTransport:
        """Returns the transport used by the client instance.

        Returns:
            GSuiteAddOnsTransport: The transport used by the client instance.
        """
        return self._client.transport

    get_transport_class = functools.partial(type(GSuiteAddOnsClient).get_transport_class, type(GSuiteAddOnsClient))

    def __init__(self, *,
            credentials: ga_credentials.Credentials = None,
            transport: Union[str, GSuiteAddOnsTransport] = "grpc_asyncio",
            client_options: ClientOptions = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiates the g suite add ons client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, ~.GSuiteAddOnsTransport]): The
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
        self._client = GSuiteAddOnsClient(
            credentials=credentials,
            transport=transport,
            client_options=client_options,
            client_info=client_info,

        )

    async def get_authorization(self,
            request: Union[gsuiteaddons.GetAuthorizationRequest, dict] = None,
            *,
            name: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> gsuiteaddons.Authorization:
        r"""Gets the authorization information for deployments in
        a given project.

        Args:
            request (Union[google.cloud.workspace_add_ons_v1.types.GetAuthorizationRequest, dict]):
                The request object. Request message to get Google
                Workspace Add-ons authorization information.
            name (:class:`str`):
                Required. Name of the project for which to get the
                Google Workspace Add-ons authorization information.

                Example: ``projects/my_project/authorization``.

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.workspace_add_ons_v1.types.Authorization:
                The authorization information used
                when invoking deployment endpoints.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = gsuiteaddons.GetAuthorizationRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_authorization,
            default_timeout=120.0,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
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

    async def create_deployment(self,
            request: Union[gsuiteaddons.CreateDeploymentRequest, dict] = None,
            *,
            parent: str = None,
            deployment: gsuiteaddons.Deployment = None,
            deployment_id: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> gsuiteaddons.Deployment:
        r"""Creates a deployment with the specified name and
        configuration.

        Args:
            request (Union[google.cloud.workspace_add_ons_v1.types.CreateDeploymentRequest, dict]):
                The request object. Request message to create a
                deployment.
            parent (:class:`str`):
                Required. Name of the project in which to create the
                deployment.

                Example: ``projects/my_project``.

                This corresponds to the ``parent`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            deployment (:class:`google.cloud.workspace_add_ons_v1.types.Deployment`):
                Required. The deployment to create
                (deployment.name cannot be set).

                This corresponds to the ``deployment`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            deployment_id (:class:`str`):
                Required. The id to use for this deployment. The full
                name of the created resource will be
                ``projects/<project_number>/deployments/<deployment_id>``.

                This corresponds to the ``deployment_id`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.workspace_add_ons_v1.types.Deployment:
                A Google Workspace Add-on deployment
        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([parent, deployment, deployment_id])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = gsuiteaddons.CreateDeploymentRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if parent is not None:
            request.parent = parent
        if deployment is not None:
            request.deployment = deployment
        if deployment_id is not None:
            request.deployment_id = deployment_id

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.create_deployment,
            default_timeout=10.0,
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

        # Done; return the response.
        return response

    async def replace_deployment(self,
            request: Union[gsuiteaddons.ReplaceDeploymentRequest, dict] = None,
            *,
            deployment: gsuiteaddons.Deployment = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> gsuiteaddons.Deployment:
        r"""Creates or replaces a deployment with the specified
        name.

        Args:
            request (Union[google.cloud.workspace_add_ons_v1.types.ReplaceDeploymentRequest, dict]):
                The request object. Request message to create or replace
                a deployment.
            deployment (:class:`google.cloud.workspace_add_ons_v1.types.Deployment`):
                Required. The deployment to create or
                replace.

                This corresponds to the ``deployment`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.workspace_add_ons_v1.types.Deployment:
                A Google Workspace Add-on deployment
        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([deployment])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = gsuiteaddons.ReplaceDeploymentRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if deployment is not None:
            request.deployment = deployment

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.replace_deployment,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("deployment.name", request.deployment.name),
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

    async def get_deployment(self,
            request: Union[gsuiteaddons.GetDeploymentRequest, dict] = None,
            *,
            name: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> gsuiteaddons.Deployment:
        r"""Gets the deployment with the specified name.

        Args:
            request (Union[google.cloud.workspace_add_ons_v1.types.GetDeploymentRequest, dict]):
                The request object. Request message to get a deployment.
            name (:class:`str`):
                Required. The full resource name of the deployment to
                get.

                Example:
                ``projects/my_project/deployments/my_deployment``.

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.workspace_add_ons_v1.types.Deployment:
                A Google Workspace Add-on deployment
        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = gsuiteaddons.GetDeploymentRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_deployment,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
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

    async def list_deployments(self,
            request: Union[gsuiteaddons.ListDeploymentsRequest, dict] = None,
            *,
            parent: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListDeploymentsAsyncPager:
        r"""Lists all deployments in a particular project.

        Args:
            request (Union[google.cloud.workspace_add_ons_v1.types.ListDeploymentsRequest, dict]):
                The request object. Request message to list deployments
                for a project.
            parent (:class:`str`):
                Required. Name of the project in which to create the
                deployment.

                Example: ``projects/my_project``.

                This corresponds to the ``parent`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.workspace_add_ons_v1.services.g_suite_add_ons.pagers.ListDeploymentsAsyncPager:
                Response message to list deployments.
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

        request = gsuiteaddons.ListDeploymentsRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if parent is not None:
            request.parent = parent

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_deployments,
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
        response = pagers.ListDeploymentsAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def delete_deployment(self,
            request: Union[gsuiteaddons.DeleteDeploymentRequest, dict] = None,
            *,
            name: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> None:
        r"""Deletes the deployment with the given name.

        Args:
            request (Union[google.cloud.workspace_add_ons_v1.types.DeleteDeploymentRequest, dict]):
                The request object. Request message to delete a
                deployment.
            name (:class:`str`):
                Required. The full resource name of the deployment to
                delete.

                Example:
                ``projects/my_project/deployments/my_deployment``.

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = gsuiteaddons.DeleteDeploymentRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.delete_deployment,
            default_timeout=10.0,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
            )),
        )

        # Send the request.
        await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    async def install_deployment(self,
            request: Union[gsuiteaddons.InstallDeploymentRequest, dict] = None,
            *,
            name: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> None:
        r"""Installs a deployment in developer mode.
        See:
        https://developers.google.com/gsuite/add-ons/how-
        tos/testing-gsuite-addons.

        Args:
            request (Union[google.cloud.workspace_add_ons_v1.types.InstallDeploymentRequest, dict]):
                The request object. Request message to install a
                developer mode deployment.
            name (:class:`str`):
                Required. The full resource name of the deployment to
                install.

                Example:
                ``projects/my_project/deployments/my_deployment``.

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = gsuiteaddons.InstallDeploymentRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.install_deployment,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
            )),
        )

        # Send the request.
        await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    async def uninstall_deployment(self,
            request: Union[gsuiteaddons.UninstallDeploymentRequest, dict] = None,
            *,
            name: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> None:
        r"""Uninstalls a developer mode deployment.
        See:
        https://developers.google.com/gsuite/add-ons/how-
        tos/testing-gsuite-addons.

        Args:
            request (Union[google.cloud.workspace_add_ons_v1.types.UninstallDeploymentRequest, dict]):
                The request object. Request message to uninstall a
                developer mode deployment.
            name (:class:`str`):
                Required. The full resource name of the deployment to
                install.

                Example:
                ``projects/my_project/deployments/my_deployment``.

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = gsuiteaddons.UninstallDeploymentRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.uninstall_deployment,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
            )),
        )

        # Send the request.
        await rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    async def get_install_status(self,
            request: Union[gsuiteaddons.GetInstallStatusRequest, dict] = None,
            *,
            name: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> gsuiteaddons.InstallStatus:
        r"""Fetches the install status of a developer mode
        deployment.

        Args:
            request (Union[google.cloud.workspace_add_ons_v1.types.GetInstallStatusRequest, dict]):
                The request object. Request message to get the install
                status of a developer mode deployment.
            name (:class:`str`):
                Required. The full resource name of the deployment.

                Example:
                ``projects/my_project/deployments/my_deployment/installStatus``.

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.workspace_add_ons_v1.types.InstallStatus:
                Developer mode install status of a
                deployment

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = gsuiteaddons.GetInstallStatusRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_install_status,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
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

    async def __aenter__(self):
        return self

    async def __aexit__(self, exc_type, exc, tb):
        await self.transport.close()

try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            "google-cloud-workspace-add-ons",
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    "GSuiteAddOnsAsyncClient",
)
