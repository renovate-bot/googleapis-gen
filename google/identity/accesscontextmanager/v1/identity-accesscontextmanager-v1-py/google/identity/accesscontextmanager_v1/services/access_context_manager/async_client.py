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

from google.api_core.client_options import ClientOptions # type: ignore
from google.api_core import exceptions as core_exceptions  # type: ignore
from google.api_core import gapic_v1                   # type: ignore
from google.api_core import retry as retries           # type: ignore
from google.auth import credentials as ga_credentials   # type: ignore
from google.oauth2 import service_account              # type: ignore

OptionalRetry = Union[retries.Retry, object]

from google.api_core import operation  # type: ignore
from google.api_core import operation_async  # type: ignore
from google.identity.accesscontextmanager_v1.services.access_context_manager import pagers
from google.identity.accesscontextmanager_v1.types import access_context_manager
from google.identity.accesscontextmanager_v1.types import access_level
from google.identity.accesscontextmanager_v1.types import access_level as gia_access_level
from google.identity.accesscontextmanager_v1.types import access_policy
from google.identity.accesscontextmanager_v1.types import gcp_user_access_binding
from google.identity.accesscontextmanager_v1.types import gcp_user_access_binding as gia_gcp_user_access_binding
from google.identity.accesscontextmanager_v1.types import service_perimeter
from google.identity.accesscontextmanager_v1.types import service_perimeter as gia_service_perimeter
from google.protobuf import empty_pb2  # type: ignore
from google.protobuf import field_mask_pb2  # type: ignore
from google.protobuf import timestamp_pb2  # type: ignore
from .transports.base import AccessContextManagerTransport, DEFAULT_CLIENT_INFO
from .transports.grpc_asyncio import AccessContextManagerGrpcAsyncIOTransport
from .client import AccessContextManagerClient


class AccessContextManagerAsyncClient:
    """API for setting [Access Levels]
    [google.identity.accesscontextmanager.v1.AccessLevel] and [Service
    Perimeters]
    [google.identity.accesscontextmanager.v1.ServicePerimeter] for
    Google Cloud Projects. Each organization has one [AccessPolicy]
    [google.identity.accesscontextmanager.v1.AccessPolicy] containing
    the [Access Levels]
    [google.identity.accesscontextmanager.v1.AccessLevel] and [Service
    Perimeters]
    [google.identity.accesscontextmanager.v1.ServicePerimeter]. This
    [AccessPolicy]
    [google.identity.accesscontextmanager.v1.AccessPolicy] is applicable
    to all resources in the organization. AccessPolicies
    """

    _client: AccessContextManagerClient

    DEFAULT_ENDPOINT = AccessContextManagerClient.DEFAULT_ENDPOINT
    DEFAULT_MTLS_ENDPOINT = AccessContextManagerClient.DEFAULT_MTLS_ENDPOINT

    access_level_path = staticmethod(AccessContextManagerClient.access_level_path)
    parse_access_level_path = staticmethod(AccessContextManagerClient.parse_access_level_path)
    access_policy_path = staticmethod(AccessContextManagerClient.access_policy_path)
    parse_access_policy_path = staticmethod(AccessContextManagerClient.parse_access_policy_path)
    gcp_user_access_binding_path = staticmethod(AccessContextManagerClient.gcp_user_access_binding_path)
    parse_gcp_user_access_binding_path = staticmethod(AccessContextManagerClient.parse_gcp_user_access_binding_path)
    service_perimeter_path = staticmethod(AccessContextManagerClient.service_perimeter_path)
    parse_service_perimeter_path = staticmethod(AccessContextManagerClient.parse_service_perimeter_path)
    common_billing_account_path = staticmethod(AccessContextManagerClient.common_billing_account_path)
    parse_common_billing_account_path = staticmethod(AccessContextManagerClient.parse_common_billing_account_path)
    common_folder_path = staticmethod(AccessContextManagerClient.common_folder_path)
    parse_common_folder_path = staticmethod(AccessContextManagerClient.parse_common_folder_path)
    common_organization_path = staticmethod(AccessContextManagerClient.common_organization_path)
    parse_common_organization_path = staticmethod(AccessContextManagerClient.parse_common_organization_path)
    common_project_path = staticmethod(AccessContextManagerClient.common_project_path)
    parse_common_project_path = staticmethod(AccessContextManagerClient.parse_common_project_path)
    common_location_path = staticmethod(AccessContextManagerClient.common_location_path)
    parse_common_location_path = staticmethod(AccessContextManagerClient.parse_common_location_path)

    @classmethod
    def from_service_account_info(cls, info: dict, *args, **kwargs):
        """Creates an instance of this client using the provided credentials
            info.

        Args:
            info (dict): The service account private key info.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            AccessContextManagerAsyncClient: The constructed client.
        """
        return AccessContextManagerClient.from_service_account_info.__func__(AccessContextManagerAsyncClient, info, *args, **kwargs)  # type: ignore

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
            AccessContextManagerAsyncClient: The constructed client.
        """
        return AccessContextManagerClient.from_service_account_file.__func__(AccessContextManagerAsyncClient, filename, *args, **kwargs)  # type: ignore

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> AccessContextManagerTransport:
        """Returns the transport used by the client instance.

        Returns:
            AccessContextManagerTransport: The transport used by the client instance.
        """
        return self._client.transport

    get_transport_class = functools.partial(type(AccessContextManagerClient).get_transport_class, type(AccessContextManagerClient))

    def __init__(self, *,
            credentials: ga_credentials.Credentials = None,
            transport: Union[str, AccessContextManagerTransport] = "grpc_asyncio",
            client_options: ClientOptions = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiates the access context manager client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, ~.AccessContextManagerTransport]): The
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
        self._client = AccessContextManagerClient(
            credentials=credentials,
            transport=transport,
            client_options=client_options,
            client_info=client_info,

        )

    async def list_access_policies(self,
            request: Union[access_context_manager.ListAccessPoliciesRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListAccessPoliciesAsyncPager:
        r"""List all [AccessPolicies]
        [google.identity.accesscontextmanager.v1.AccessPolicy] under a
        container.

        Args:
            request (Union[google.identity.accesscontextmanager_v1.types.ListAccessPoliciesRequest, dict]):
                The request object. A request to list all
                `AccessPolicies` for a container.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.identity.accesscontextmanager_v1.services.access_context_manager.pagers.ListAccessPoliciesAsyncPager:
                A response to ListAccessPoliciesRequest.

                Iterating over this object will yield results and
                resolve additional pages automatically.

        """
        # Create or coerce a protobuf request object.
        request = access_context_manager.ListAccessPoliciesRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_access_policies,
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
        response = pagers.ListAccessPoliciesAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def get_access_policy(self,
            request: Union[access_context_manager.GetAccessPolicyRequest, dict] = None,
            *,
            name: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> access_policy.AccessPolicy:
        r"""Get an [AccessPolicy]
        [google.identity.accesscontextmanager.v1.AccessPolicy] by name.

        Args:
            request (Union[google.identity.accesscontextmanager_v1.types.GetAccessPolicyRequest, dict]):
                The request object. A request to get a particular
                `AccessPolicy`.
            name (:class:`str`):
                Required. Resource name for the access policy to get.

                Format ``accessPolicies/{policy_id}``

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.identity.accesscontextmanager_v1.types.AccessPolicy:
                AccessPolicy is a container for AccessLevels (which define the necessary
                   attributes to use Google Cloud services) and
                   ServicePerimeters (which define regions of services
                   able to freely pass data within a perimeter). An
                   access policy is globally visible within an
                   organization, and the restrictions it specifies apply
                   to all projects within an organization.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = access_context_manager.GetAccessPolicyRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_access_policy,
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

    async def create_access_policy(self,
            request: Union[access_policy.AccessPolicy, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Create an ``AccessPolicy``. Fails if this organization already
        has a ``AccessPolicy``. The longrunning Operation will have a
        successful status once the ``AccessPolicy`` has propagated to
        long-lasting storage. Syntactic and basic semantic errors will
        be returned in ``metadata`` as a BadRequest proto.

        Args:
            request (Union[google.identity.accesscontextmanager_v1.types.AccessPolicy, dict]):
                The request object. `AccessPolicy` is a container for
                `AccessLevels` (which define the necessary attributes to
                use Google Cloud services) and `ServicePerimeters`
                (which define regions of services able to freely pass
                data within a perimeter). An access policy is globally
                visible within an organization, and the restrictions it
                specifies apply to all projects within an organization.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation_async.AsyncOperation:
                An object representing a long-running operation.

                The result type for the operation will be :class:`google.identity.accesscontextmanager_v1.types.AccessPolicy` AccessPolicy is a container for AccessLevels (which define the necessary
                   attributes to use Google Cloud services) and
                   ServicePerimeters (which define regions of services
                   able to freely pass data within a perimeter). An
                   access policy is globally visible within an
                   organization, and the restrictions it specifies apply
                   to all projects within an organization.

        """
        # Create or coerce a protobuf request object.
        request = access_policy.AccessPolicy(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.create_access_policy,
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

        # Wrap the response in an operation future.
        response = operation_async.from_gapic(
            response,
            self._client._transport.operations_client,
            access_policy.AccessPolicy,
            metadata_type=access_context_manager.AccessContextManagerOperationMetadata,
        )

        # Done; return the response.
        return response

    async def update_access_policy(self,
            request: Union[access_context_manager.UpdateAccessPolicyRequest, dict] = None,
            *,
            policy: access_policy.AccessPolicy = None,
            update_mask: field_mask_pb2.FieldMask = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Update an [AccessPolicy]
        [google.identity.accesscontextmanager.v1.AccessPolicy]. The
        longrunning Operation from this RPC will have a successful
        status once the changes to the [AccessPolicy]
        [google.identity.accesscontextmanager.v1.AccessPolicy] have
        propagated to long-lasting storage. Syntactic and basic semantic
        errors will be returned in ``metadata`` as a BadRequest proto.

        Args:
            request (Union[google.identity.accesscontextmanager_v1.types.UpdateAccessPolicyRequest, dict]):
                The request object. A request to update an
                `AccessPolicy`.
            policy (:class:`google.identity.accesscontextmanager_v1.types.AccessPolicy`):
                Required. The updated AccessPolicy.
                This corresponds to the ``policy`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            update_mask (:class:`google.protobuf.field_mask_pb2.FieldMask`):
                Required. Mask to control which
                fields get updated. Must be non-empty.

                This corresponds to the ``update_mask`` field
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

                The result type for the operation will be :class:`google.identity.accesscontextmanager_v1.types.AccessPolicy` AccessPolicy is a container for AccessLevels (which define the necessary
                   attributes to use Google Cloud services) and
                   ServicePerimeters (which define regions of services
                   able to freely pass data within a perimeter). An
                   access policy is globally visible within an
                   organization, and the restrictions it specifies apply
                   to all projects within an organization.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([policy, update_mask])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = access_context_manager.UpdateAccessPolicyRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if policy is not None:
            request.policy = policy
        if update_mask is not None:
            request.update_mask = update_mask

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.update_access_policy,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("policy.name", request.policy.name),
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
            access_policy.AccessPolicy,
            metadata_type=access_context_manager.AccessContextManagerOperationMetadata,
        )

        # Done; return the response.
        return response

    async def delete_access_policy(self,
            request: Union[access_context_manager.DeleteAccessPolicyRequest, dict] = None,
            *,
            name: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Delete an [AccessPolicy]
        [google.identity.accesscontextmanager.v1.AccessPolicy] by
        resource name. The longrunning Operation will have a successful
        status once the [AccessPolicy]
        [google.identity.accesscontextmanager.v1.AccessPolicy] has been
        removed from long-lasting storage.

        Args:
            request (Union[google.identity.accesscontextmanager_v1.types.DeleteAccessPolicyRequest, dict]):
                The request object. A request to delete an
                `AccessPolicy`.
            name (:class:`str`):
                Required. Resource name for the access policy to delete.

                Format ``accessPolicies/{policy_id}``

                This corresponds to the ``name`` field
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

                The result type for the operation will be :class:`google.protobuf.empty_pb2.Empty` A generic empty message that you can re-use to avoid defining duplicated
                   empty messages in your APIs. A typical example is to
                   use it as the request or the response type of an API
                   method. For instance:

                      service Foo {
                         rpc Bar(google.protobuf.Empty) returns
                         (google.protobuf.Empty);

                      }

                   The JSON representation for Empty is empty JSON
                   object {}.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = access_context_manager.DeleteAccessPolicyRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.delete_access_policy,
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

        # Wrap the response in an operation future.
        response = operation_async.from_gapic(
            response,
            self._client._transport.operations_client,
            empty_pb2.Empty,
            metadata_type=access_context_manager.AccessContextManagerOperationMetadata,
        )

        # Done; return the response.
        return response

    async def list_access_levels(self,
            request: Union[access_context_manager.ListAccessLevelsRequest, dict] = None,
            *,
            parent: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListAccessLevelsAsyncPager:
        r"""List all [Access Levels]
        [google.identity.accesscontextmanager.v1.AccessLevel] for an
        access policy.

        Args:
            request (Union[google.identity.accesscontextmanager_v1.types.ListAccessLevelsRequest, dict]):
                The request object. A request to list all `AccessLevels`
                in an `AccessPolicy`.
            parent (:class:`str`):
                Required. Resource name for the access policy to list
                [Access Levels]
                [google.identity.accesscontextmanager.v1.AccessLevel]
                from.

                Format: ``accessPolicies/{policy_id}``

                This corresponds to the ``parent`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.identity.accesscontextmanager_v1.services.access_context_manager.pagers.ListAccessLevelsAsyncPager:
                A response to ListAccessLevelsRequest.

                Iterating over this object will yield results and
                resolve additional pages automatically.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([parent])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = access_context_manager.ListAccessLevelsRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if parent is not None:
            request.parent = parent

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_access_levels,
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
        response = pagers.ListAccessLevelsAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def get_access_level(self,
            request: Union[access_context_manager.GetAccessLevelRequest, dict] = None,
            *,
            name: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> access_level.AccessLevel:
        r"""Get an [Access Level]
        [google.identity.accesscontextmanager.v1.AccessLevel] by
        resource name.

        Args:
            request (Union[google.identity.accesscontextmanager_v1.types.GetAccessLevelRequest, dict]):
                The request object. A request to get a particular
                `AccessLevel`.
            name (:class:`str`):
                Required. Resource name for the [Access Level]
                [google.identity.accesscontextmanager.v1.AccessLevel].

                Format:
                ``accessPolicies/{policy_id}/accessLevels/{access_level_id}``

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.identity.accesscontextmanager_v1.types.AccessLevel:
                An AccessLevel is a label that can be applied to requests to Google Cloud
                   services, along with a list of requirements necessary
                   for the label to be applied.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = access_context_manager.GetAccessLevelRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_access_level,
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

    async def create_access_level(self,
            request: Union[access_context_manager.CreateAccessLevelRequest, dict] = None,
            *,
            parent: str = None,
            access_level: gia_access_level.AccessLevel = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Create an [Access Level]
        [google.identity.accesscontextmanager.v1.AccessLevel]. The
        longrunning operation from this RPC will have a successful
        status once the [Access Level]
        [google.identity.accesscontextmanager.v1.AccessLevel] has
        propagated to long-lasting storage. [Access Levels]
        [google.identity.accesscontextmanager.v1.AccessLevel] containing
        errors will result in an error response for the first error
        encountered.

        Args:
            request (Union[google.identity.accesscontextmanager_v1.types.CreateAccessLevelRequest, dict]):
                The request object. A request to create an
                `AccessLevel`.
            parent (:class:`str`):
                Required. Resource name for the access policy which owns
                this [Access Level]
                [google.identity.accesscontextmanager.v1.AccessLevel].

                Format: ``accessPolicies/{policy_id}``

                This corresponds to the ``parent`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            access_level (:class:`google.identity.accesscontextmanager_v1.types.AccessLevel`):
                Required. The [Access Level]
                [google.identity.accesscontextmanager.v1.AccessLevel] to
                create. Syntactic correctness of the [Access Level]
                [google.identity.accesscontextmanager.v1.AccessLevel] is
                a precondition for creation.

                This corresponds to the ``access_level`` field
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

                The result type for the operation will be :class:`google.identity.accesscontextmanager_v1.types.AccessLevel` An AccessLevel is a label that can be applied to requests to Google Cloud
                   services, along with a list of requirements necessary
                   for the label to be applied.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([parent, access_level])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = access_context_manager.CreateAccessLevelRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if parent is not None:
            request.parent = parent
        if access_level is not None:
            request.access_level = access_level

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.create_access_level,
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
            gia_access_level.AccessLevel,
            metadata_type=access_context_manager.AccessContextManagerOperationMetadata,
        )

        # Done; return the response.
        return response

    async def update_access_level(self,
            request: Union[access_context_manager.UpdateAccessLevelRequest, dict] = None,
            *,
            access_level: gia_access_level.AccessLevel = None,
            update_mask: field_mask_pb2.FieldMask = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Update an [Access Level]
        [google.identity.accesscontextmanager.v1.AccessLevel]. The
        longrunning operation from this RPC will have a successful
        status once the changes to the [Access Level]
        [google.identity.accesscontextmanager.v1.AccessLevel] have
        propagated to long-lasting storage. [Access Levels]
        [google.identity.accesscontextmanager.v1.AccessLevel] containing
        errors will result in an error response for the first error
        encountered.

        Args:
            request (Union[google.identity.accesscontextmanager_v1.types.UpdateAccessLevelRequest, dict]):
                The request object. A request to update an
                `AccessLevel`.
            access_level (:class:`google.identity.accesscontextmanager_v1.types.AccessLevel`):
                Required. The updated [Access Level]
                [google.identity.accesscontextmanager.v1.AccessLevel].
                Syntactic correctness of the [Access Level]
                [google.identity.accesscontextmanager.v1.AccessLevel] is
                a precondition for creation.

                This corresponds to the ``access_level`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            update_mask (:class:`google.protobuf.field_mask_pb2.FieldMask`):
                Required. Mask to control which
                fields get updated. Must be non-empty.

                This corresponds to the ``update_mask`` field
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

                The result type for the operation will be :class:`google.identity.accesscontextmanager_v1.types.AccessLevel` An AccessLevel is a label that can be applied to requests to Google Cloud
                   services, along with a list of requirements necessary
                   for the label to be applied.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([access_level, update_mask])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = access_context_manager.UpdateAccessLevelRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if access_level is not None:
            request.access_level = access_level
        if update_mask is not None:
            request.update_mask = update_mask

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.update_access_level,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("access_level.name", request.access_level.name),
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
            gia_access_level.AccessLevel,
            metadata_type=access_context_manager.AccessContextManagerOperationMetadata,
        )

        # Done; return the response.
        return response

    async def delete_access_level(self,
            request: Union[access_context_manager.DeleteAccessLevelRequest, dict] = None,
            *,
            name: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Delete an [Access Level]
        [google.identity.accesscontextmanager.v1.AccessLevel] by
        resource name. The longrunning operation from this RPC will have
        a successful status once the [Access Level]
        [google.identity.accesscontextmanager.v1.AccessLevel] has been
        removed from long-lasting storage.

        Args:
            request (Union[google.identity.accesscontextmanager_v1.types.DeleteAccessLevelRequest, dict]):
                The request object. A request to delete an
                `AccessLevel`.
            name (:class:`str`):
                Required. Resource name for the [Access Level]
                [google.identity.accesscontextmanager.v1.AccessLevel].

                Format:
                ``accessPolicies/{policy_id}/accessLevels/{access_level_id}``

                This corresponds to the ``name`` field
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

                The result type for the operation will be :class:`google.protobuf.empty_pb2.Empty` A generic empty message that you can re-use to avoid defining duplicated
                   empty messages in your APIs. A typical example is to
                   use it as the request or the response type of an API
                   method. For instance:

                      service Foo {
                         rpc Bar(google.protobuf.Empty) returns
                         (google.protobuf.Empty);

                      }

                   The JSON representation for Empty is empty JSON
                   object {}.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = access_context_manager.DeleteAccessLevelRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.delete_access_level,
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

        # Wrap the response in an operation future.
        response = operation_async.from_gapic(
            response,
            self._client._transport.operations_client,
            empty_pb2.Empty,
            metadata_type=access_context_manager.AccessContextManagerOperationMetadata,
        )

        # Done; return the response.
        return response

    async def replace_access_levels(self,
            request: Union[access_context_manager.ReplaceAccessLevelsRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Replace all existing [Access Levels]
        [google.identity.accesscontextmanager.v1.AccessLevel] in an
        [Access Policy]
        [google.identity.accesscontextmanager.v1.AccessPolicy] with the
        [Access Levels]
        [google.identity.accesscontextmanager.v1.AccessLevel] provided.
        This is done atomically. The longrunning operation from this RPC
        will have a successful status once all replacements have
        propagated to long-lasting storage. Replacements containing
        errors will result in an error response for the first error
        encountered. Replacement will be cancelled on error, existing
        [Access Levels]
        [google.identity.accesscontextmanager.v1.AccessLevel] will not
        be affected. Operation.response field will contain
        ReplaceAccessLevelsResponse. Removing [Access Levels]
        [google.identity.accesscontextmanager.v1.AccessLevel] contained
        in existing [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] will
        result in error.

        Args:
            request (Union[google.identity.accesscontextmanager_v1.types.ReplaceAccessLevelsRequest, dict]):
                The request object. A request to replace all existing
                Access Levels in an Access Policy with the Access Levels
                provided. This is done atomically.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation_async.AsyncOperation:
                An object representing a long-running operation.

                The result type for the operation will be :class:`google.identity.accesscontextmanager_v1.types.ReplaceAccessLevelsResponse` A response to ReplaceAccessLevelsRequest. This will be put inside of
                   Operation.response field.

        """
        # Create or coerce a protobuf request object.
        request = access_context_manager.ReplaceAccessLevelsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.replace_access_levels,
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
            access_context_manager.ReplaceAccessLevelsResponse,
            metadata_type=access_context_manager.AccessContextManagerOperationMetadata,
        )

        # Done; return the response.
        return response

    async def list_service_perimeters(self,
            request: Union[access_context_manager.ListServicePerimetersRequest, dict] = None,
            *,
            parent: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListServicePerimetersAsyncPager:
        r"""List all [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] for
        an access policy.

        Args:
            request (Union[google.identity.accesscontextmanager_v1.types.ListServicePerimetersRequest, dict]):
                The request object. A request to list all
                `ServicePerimeters` in an `AccessPolicy`.
            parent (:class:`str`):
                Required. Resource name for the access policy to list
                [Service Perimeters]
                [google.identity.accesscontextmanager.v1.ServicePerimeter]
                from.

                Format: ``accessPolicies/{policy_id}``

                This corresponds to the ``parent`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.identity.accesscontextmanager_v1.services.access_context_manager.pagers.ListServicePerimetersAsyncPager:
                A response to ListServicePerimetersRequest.

                Iterating over this object will yield results and
                resolve additional pages automatically.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([parent])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = access_context_manager.ListServicePerimetersRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if parent is not None:
            request.parent = parent

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_service_perimeters,
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
        response = pagers.ListServicePerimetersAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def get_service_perimeter(self,
            request: Union[access_context_manager.GetServicePerimeterRequest, dict] = None,
            *,
            name: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> service_perimeter.ServicePerimeter:
        r"""Get a [Service Perimeter]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] by
        resource name.

        Args:
            request (Union[google.identity.accesscontextmanager_v1.types.GetServicePerimeterRequest, dict]):
                The request object. A request to get a particular
                `ServicePerimeter`.
            name (:class:`str`):
                Required. Resource name for the [Service Perimeter]
                [google.identity.accesscontextmanager.v1.ServicePerimeter].

                Format:
                ``accessPolicies/{policy_id}/servicePerimeters/{service_perimeters_id}``

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.identity.accesscontextmanager_v1.types.ServicePerimeter:
                ServicePerimeter describes a set of Google Cloud resources which can freely
                   import and export data amongst themselves, but not
                   export outside of the ServicePerimeter. If a request
                   with a source within this ServicePerimeter has a
                   target outside of the ServicePerimeter, the request
                   will be blocked. Otherwise the request is allowed.
                   There are two types of Service Perimeter -Regular and
                   Bridge. Regular Service Perimeters cannot overlap, a
                   single Google Cloud project can only belong to a
                   single regular Service Perimeter. Service Perimeter
                   Bridges can contain only Google Cloud projects as
                   members, a single Google Cloud project may belong to
                   multiple Service Perimeter Bridges.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = access_context_manager.GetServicePerimeterRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_service_perimeter,
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

    async def create_service_perimeter(self,
            request: Union[access_context_manager.CreateServicePerimeterRequest, dict] = None,
            *,
            parent: str = None,
            service_perimeter: gia_service_perimeter.ServicePerimeter = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Create a [Service Perimeter]
        [google.identity.accesscontextmanager.v1.ServicePerimeter]. The
        longrunning operation from this RPC will have a successful
        status once the [Service Perimeter]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] has
        propagated to long-lasting storage. [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter]
        containing errors will result in an error response for the first
        error encountered.

        Args:
            request (Union[google.identity.accesscontextmanager_v1.types.CreateServicePerimeterRequest, dict]):
                The request object. A request to create a
                `ServicePerimeter`.
            parent (:class:`str`):
                Required. Resource name for the access policy which owns
                this [Service Perimeter]
                [google.identity.accesscontextmanager.v1.ServicePerimeter].

                Format: ``accessPolicies/{policy_id}``

                This corresponds to the ``parent`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            service_perimeter (:class:`google.identity.accesscontextmanager_v1.types.ServicePerimeter`):
                Required. The [Service Perimeter]
                [google.identity.accesscontextmanager.v1.ServicePerimeter]
                to create. Syntactic correctness of the [Service
                Perimeter]
                [google.identity.accesscontextmanager.v1.ServicePerimeter]
                is a precondition for creation.

                This corresponds to the ``service_perimeter`` field
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

                The result type for the operation will be :class:`google.identity.accesscontextmanager_v1.types.ServicePerimeter` ServicePerimeter describes a set of Google Cloud resources which can freely
                   import and export data amongst themselves, but not
                   export outside of the ServicePerimeter. If a request
                   with a source within this ServicePerimeter has a
                   target outside of the ServicePerimeter, the request
                   will be blocked. Otherwise the request is allowed.
                   There are two types of Service Perimeter -Regular and
                   Bridge. Regular Service Perimeters cannot overlap, a
                   single Google Cloud project can only belong to a
                   single regular Service Perimeter. Service Perimeter
                   Bridges can contain only Google Cloud projects as
                   members, a single Google Cloud project may belong to
                   multiple Service Perimeter Bridges.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([parent, service_perimeter])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = access_context_manager.CreateServicePerimeterRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if parent is not None:
            request.parent = parent
        if service_perimeter is not None:
            request.service_perimeter = service_perimeter

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.create_service_perimeter,
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
            gia_service_perimeter.ServicePerimeter,
            metadata_type=access_context_manager.AccessContextManagerOperationMetadata,
        )

        # Done; return the response.
        return response

    async def update_service_perimeter(self,
            request: Union[access_context_manager.UpdateServicePerimeterRequest, dict] = None,
            *,
            service_perimeter: gia_service_perimeter.ServicePerimeter = None,
            update_mask: field_mask_pb2.FieldMask = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Update a [Service Perimeter]
        [google.identity.accesscontextmanager.v1.ServicePerimeter]. The
        longrunning operation from this RPC will have a successful
        status once the changes to the [Service Perimeter]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] have
        propagated to long-lasting storage. [Service Perimeter]
        [google.identity.accesscontextmanager.v1.ServicePerimeter]
        containing errors will result in an error response for the first
        error encountered.

        Args:
            request (Union[google.identity.accesscontextmanager_v1.types.UpdateServicePerimeterRequest, dict]):
                The request object. A request to update a
                `ServicePerimeter`.
            service_perimeter (:class:`google.identity.accesscontextmanager_v1.types.ServicePerimeter`):
                Required. The updated ``ServicePerimeter``. Syntactic
                correctness of the ``ServicePerimeter`` is a
                precondition for creation.

                This corresponds to the ``service_perimeter`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            update_mask (:class:`google.protobuf.field_mask_pb2.FieldMask`):
                Required. Mask to control which
                fields get updated. Must be non-empty.

                This corresponds to the ``update_mask`` field
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

                The result type for the operation will be :class:`google.identity.accesscontextmanager_v1.types.ServicePerimeter` ServicePerimeter describes a set of Google Cloud resources which can freely
                   import and export data amongst themselves, but not
                   export outside of the ServicePerimeter. If a request
                   with a source within this ServicePerimeter has a
                   target outside of the ServicePerimeter, the request
                   will be blocked. Otherwise the request is allowed.
                   There are two types of Service Perimeter -Regular and
                   Bridge. Regular Service Perimeters cannot overlap, a
                   single Google Cloud project can only belong to a
                   single regular Service Perimeter. Service Perimeter
                   Bridges can contain only Google Cloud projects as
                   members, a single Google Cloud project may belong to
                   multiple Service Perimeter Bridges.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([service_perimeter, update_mask])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = access_context_manager.UpdateServicePerimeterRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if service_perimeter is not None:
            request.service_perimeter = service_perimeter
        if update_mask is not None:
            request.update_mask = update_mask

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.update_service_perimeter,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("service_perimeter.name", request.service_perimeter.name),
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
            gia_service_perimeter.ServicePerimeter,
            metadata_type=access_context_manager.AccessContextManagerOperationMetadata,
        )

        # Done; return the response.
        return response

    async def delete_service_perimeter(self,
            request: Union[access_context_manager.DeleteServicePerimeterRequest, dict] = None,
            *,
            name: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Delete a [Service Perimeter]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] by
        resource name. The longrunning operation from this RPC will have
        a successful status once the [Service Perimeter]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] has
        been removed from long-lasting storage.

        Args:
            request (Union[google.identity.accesscontextmanager_v1.types.DeleteServicePerimeterRequest, dict]):
                The request object. A request to delete a
                `ServicePerimeter`.
            name (:class:`str`):
                Required. Resource name for the [Service Perimeter]
                [google.identity.accesscontextmanager.v1.ServicePerimeter].

                Format:
                ``accessPolicies/{policy_id}/servicePerimeters/{service_perimeter_id}``

                This corresponds to the ``name`` field
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

                The result type for the operation will be :class:`google.protobuf.empty_pb2.Empty` A generic empty message that you can re-use to avoid defining duplicated
                   empty messages in your APIs. A typical example is to
                   use it as the request or the response type of an API
                   method. For instance:

                      service Foo {
                         rpc Bar(google.protobuf.Empty) returns
                         (google.protobuf.Empty);

                      }

                   The JSON representation for Empty is empty JSON
                   object {}.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = access_context_manager.DeleteServicePerimeterRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.delete_service_perimeter,
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

        # Wrap the response in an operation future.
        response = operation_async.from_gapic(
            response,
            self._client._transport.operations_client,
            empty_pb2.Empty,
            metadata_type=access_context_manager.AccessContextManagerOperationMetadata,
        )

        # Done; return the response.
        return response

    async def replace_service_perimeters(self,
            request: Union[access_context_manager.ReplaceServicePerimetersRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Replace all existing [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] in an
        [Access Policy]
        [google.identity.accesscontextmanager.v1.AccessPolicy] with the
        [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter]
        provided. This is done atomically. The longrunning operation
        from this RPC will have a successful status once all
        replacements have propagated to long-lasting storage.
        Replacements containing errors will result in an error response
        for the first error encountered. Replacement will be cancelled
        on error, existing [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] will
        not be affected. Operation.response field will contain
        ReplaceServicePerimetersResponse.

        Args:
            request (Union[google.identity.accesscontextmanager_v1.types.ReplaceServicePerimetersRequest, dict]):
                The request object. A request to replace all existing
                Service Perimeters in an Access Policy with the Service
                Perimeters provided. This is done atomically.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation_async.AsyncOperation:
                An object representing a long-running operation.

                The result type for the operation will be :class:`google.identity.accesscontextmanager_v1.types.ReplaceServicePerimetersResponse` A response to ReplaceServicePerimetersRequest. This will be put inside of
                   Operation.response field.

        """
        # Create or coerce a protobuf request object.
        request = access_context_manager.ReplaceServicePerimetersRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.replace_service_perimeters,
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
            access_context_manager.ReplaceServicePerimetersResponse,
            metadata_type=access_context_manager.AccessContextManagerOperationMetadata,
        )

        # Done; return the response.
        return response

    async def commit_service_perimeters(self,
            request: Union[access_context_manager.CommitServicePerimetersRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Commit the dry-run spec for all the [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] in an
        [Access
        Policy][google.identity.accesscontextmanager.v1.AccessPolicy]. A
        commit operation on a Service Perimeter involves copying its
        ``spec`` field to that Service Perimeter's ``status`` field.
        Only [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] with
        ``use_explicit_dry_run_spec`` field set to true are affected by
        a commit operation. The longrunning operation from this RPC will
        have a successful status once the dry-run specs for all the
        [Service Perimeters]
        [google.identity.accesscontextmanager.v1.ServicePerimeter] have
        been committed. If a commit fails, it will cause the longrunning
        operation to return an error response and the entire commit
        operation will be cancelled. When successful, Operation.response
        field will contain CommitServicePerimetersResponse. The
        ``dry_run`` and the ``spec`` fields will be cleared after a
        successful commit operation.

        Args:
            request (Union[google.identity.accesscontextmanager_v1.types.CommitServicePerimetersRequest, dict]):
                The request object. A request to commit dry-run specs in
                all [Service Perimeters]
                [google.identity.accesscontextmanager.v1.ServicePerimeter]
                belonging to an [Access
                Policy][google.identity.accesscontextmanager.v1.AccessPolicy].
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation_async.AsyncOperation:
                An object representing a long-running operation.

                The result type for the operation will be :class:`google.identity.accesscontextmanager_v1.types.CommitServicePerimetersResponse` A response to CommitServicePerimetersRequest. This will be put inside of
                   Operation.response field.

        """
        # Create or coerce a protobuf request object.
        request = access_context_manager.CommitServicePerimetersRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.commit_service_perimeters,
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
            access_context_manager.CommitServicePerimetersResponse,
            metadata_type=access_context_manager.AccessContextManagerOperationMetadata,
        )

        # Done; return the response.
        return response

    async def list_gcp_user_access_bindings(self,
            request: Union[access_context_manager.ListGcpUserAccessBindingsRequest, dict] = None,
            *,
            parent: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListGcpUserAccessBindingsAsyncPager:
        r"""Lists all [GcpUserAccessBindings]
        [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]
        for a Google Cloud organization.

        Args:
            request (Union[google.identity.accesscontextmanager_v1.types.ListGcpUserAccessBindingsRequest, dict]):
                The request object. Request of
                [ListGcpUserAccessBindings]
                [google.identity.accesscontextmanager.v1.AccessContextManager.ListGcpUserAccessBindings].
            parent (:class:`str`):
                Required. Example:
                "organizations/256"

                This corresponds to the ``parent`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.identity.accesscontextmanager_v1.services.access_context_manager.pagers.ListGcpUserAccessBindingsAsyncPager:
                Response of [ListGcpUserAccessBindings]
                   [google.identity.accesscontextmanager.v1.AccessContextManager.ListGcpUserAccessBindings].

                Iterating over this object will yield results and
                resolve additional pages automatically.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([parent])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = access_context_manager.ListGcpUserAccessBindingsRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if parent is not None:
            request.parent = parent

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_gcp_user_access_bindings,
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
        response = pagers.ListGcpUserAccessBindingsAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def get_gcp_user_access_binding(self,
            request: Union[access_context_manager.GetGcpUserAccessBindingRequest, dict] = None,
            *,
            name: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> gcp_user_access_binding.GcpUserAccessBinding:
        r"""Gets the [GcpUserAccessBinding]
        [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]
        with the given name.

        Args:
            request (Union[google.identity.accesscontextmanager_v1.types.GetGcpUserAccessBindingRequest, dict]):
                The request object. Request of [GetGcpUserAccessBinding]
                [google.identity.accesscontextmanager.v1.AccessContextManager.GetGcpUserAccessBinding].
            name (:class:`str`):
                Required. Example:
                "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"

                This corresponds to the ``name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.identity.accesscontextmanager_v1.types.GcpUserAccessBinding:
                Restricts access to Cloud Console and
                Google Cloud APIs for a set of users
                using Context-Aware Access.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = access_context_manager.GetGcpUserAccessBindingRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_gcp_user_access_binding,
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

    async def create_gcp_user_access_binding(self,
            request: Union[access_context_manager.CreateGcpUserAccessBindingRequest, dict] = None,
            *,
            parent: str = None,
            gcp_user_access_binding: gia_gcp_user_access_binding.GcpUserAccessBinding = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Creates a [GcpUserAccessBinding]
        [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        If the client specifies a [name]
        [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.name],
        the server will ignore it. Fails if a resource already exists
        with the same [group_key]
        [google.identity.accesscontextmanager.v1.GcpUserAccessBinding.group_key].
        Completion of this long-running operation does not necessarily
        signify that the new binding is deployed onto all affected
        users, which may take more time.

        Args:
            request (Union[google.identity.accesscontextmanager_v1.types.CreateGcpUserAccessBindingRequest, dict]):
                The request object. Request of
                [CreateGcpUserAccessBinding]
                [google.identity.accesscontextmanager.v1.AccessContextManager.CreateGcpUserAccessBinding].
            parent (:class:`str`):
                Required. Example:
                "organizations/256"

                This corresponds to the ``parent`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            gcp_user_access_binding (:class:`google.identity.accesscontextmanager_v1.types.GcpUserAccessBinding`):
                Required. [GcpUserAccessBinding]
                [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]

                This corresponds to the ``gcp_user_access_binding`` field
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

                The result type for the operation will be :class:`google.identity.accesscontextmanager_v1.types.GcpUserAccessBinding` Restricts access to Cloud Console and Google Cloud APIs for a set of users
                   using Context-Aware Access.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([parent, gcp_user_access_binding])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = access_context_manager.CreateGcpUserAccessBindingRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if parent is not None:
            request.parent = parent
        if gcp_user_access_binding is not None:
            request.gcp_user_access_binding = gcp_user_access_binding

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.create_gcp_user_access_binding,
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
            gia_gcp_user_access_binding.GcpUserAccessBinding,
            metadata_type=access_context_manager.GcpUserAccessBindingOperationMetadata,
        )

        # Done; return the response.
        return response

    async def update_gcp_user_access_binding(self,
            request: Union[access_context_manager.UpdateGcpUserAccessBindingRequest, dict] = None,
            *,
            gcp_user_access_binding: gia_gcp_user_access_binding.GcpUserAccessBinding = None,
            update_mask: field_mask_pb2.FieldMask = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Updates a [GcpUserAccessBinding]
        [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        Completion of this long-running operation does not necessarily
        signify that the changed binding is deployed onto all affected
        users, which may take more time.

        Args:
            request (Union[google.identity.accesscontextmanager_v1.types.UpdateGcpUserAccessBindingRequest, dict]):
                The request object. Request of
                [UpdateGcpUserAccessBinding]
                [google.identity.accesscontextmanager.v1.AccessContextManager.UpdateGcpUserAccessBinding].
            gcp_user_access_binding (:class:`google.identity.accesscontextmanager_v1.types.GcpUserAccessBinding`):
                Required. [GcpUserAccessBinding]
                [google.identity.accesscontextmanager.v1.GcpUserAccessBinding]

                This corresponds to the ``gcp_user_access_binding`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            update_mask (:class:`google.protobuf.field_mask_pb2.FieldMask`):
                Required. Only the fields specified in this mask are
                updated. Because name and group_key cannot be changed,
                update_mask is required and must always be:

                update_mask { paths: "access_levels" }

                This corresponds to the ``update_mask`` field
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

                The result type for the operation will be :class:`google.identity.accesscontextmanager_v1.types.GcpUserAccessBinding` Restricts access to Cloud Console and Google Cloud APIs for a set of users
                   using Context-Aware Access.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([gcp_user_access_binding, update_mask])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = access_context_manager.UpdateGcpUserAccessBindingRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if gcp_user_access_binding is not None:
            request.gcp_user_access_binding = gcp_user_access_binding
        if update_mask is not None:
            request.update_mask = update_mask

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.update_gcp_user_access_binding,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("gcp_user_access_binding.name", request.gcp_user_access_binding.name),
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
            gia_gcp_user_access_binding.GcpUserAccessBinding,
            metadata_type=access_context_manager.GcpUserAccessBindingOperationMetadata,
        )

        # Done; return the response.
        return response

    async def delete_gcp_user_access_binding(self,
            request: Union[access_context_manager.DeleteGcpUserAccessBindingRequest, dict] = None,
            *,
            name: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Deletes a [GcpUserAccessBinding]
        [google.identity.accesscontextmanager.v1.GcpUserAccessBinding].
        Completion of this long-running operation does not necessarily
        signify that the binding deletion is deployed onto all affected
        users, which may take more time.

        Args:
            request (Union[google.identity.accesscontextmanager_v1.types.DeleteGcpUserAccessBindingRequest, dict]):
                The request object. Request of
                [DeleteGcpUserAccessBinding]
                [google.identity.accesscontextmanager.v1.AccessContextManager.DeleteGcpUserAccessBinding].
            name (:class:`str`):
                Required. Example:
                "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"

                This corresponds to the ``name`` field
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

                The result type for the operation will be :class:`google.protobuf.empty_pb2.Empty` A generic empty message that you can re-use to avoid defining duplicated
                   empty messages in your APIs. A typical example is to
                   use it as the request or the response type of an API
                   method. For instance:

                      service Foo {
                         rpc Bar(google.protobuf.Empty) returns
                         (google.protobuf.Empty);

                      }

                   The JSON representation for Empty is empty JSON
                   object {}.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([name])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = access_context_manager.DeleteGcpUserAccessBindingRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if name is not None:
            request.name = name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.delete_gcp_user_access_binding,
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

        # Wrap the response in an operation future.
        response = operation_async.from_gapic(
            response,
            self._client._transport.operations_client,
            empty_pb2.Empty,
            metadata_type=access_context_manager.GcpUserAccessBindingOperationMetadata,
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
            "google-identity-accesscontextmanager",
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    "AccessContextManagerAsyncClient",
)
