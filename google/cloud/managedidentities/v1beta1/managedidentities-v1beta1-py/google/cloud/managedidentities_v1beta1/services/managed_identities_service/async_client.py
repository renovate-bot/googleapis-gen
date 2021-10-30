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
from google.cloud.managedidentities_v1beta1.services.managed_identities_service import pagers
from google.cloud.managedidentities_v1beta1.types import managed_identities_service
from google.cloud.managedidentities_v1beta1.types import resource
from google.protobuf import empty_pb2  # type: ignore
from google.protobuf import timestamp_pb2  # type: ignore
from .transports.base import ManagedIdentitiesServiceTransport, DEFAULT_CLIENT_INFO
from .transports.grpc_asyncio import ManagedIdentitiesServiceGrpcAsyncIOTransport
from .client import ManagedIdentitiesServiceClient


class ManagedIdentitiesServiceAsyncClient:
    """"""

    _client: ManagedIdentitiesServiceClient

    DEFAULT_ENDPOINT = ManagedIdentitiesServiceClient.DEFAULT_ENDPOINT
    DEFAULT_MTLS_ENDPOINT = ManagedIdentitiesServiceClient.DEFAULT_MTLS_ENDPOINT

    common_billing_account_path = staticmethod(ManagedIdentitiesServiceClient.common_billing_account_path)
    parse_common_billing_account_path = staticmethod(ManagedIdentitiesServiceClient.parse_common_billing_account_path)
    common_folder_path = staticmethod(ManagedIdentitiesServiceClient.common_folder_path)
    parse_common_folder_path = staticmethod(ManagedIdentitiesServiceClient.parse_common_folder_path)
    common_organization_path = staticmethod(ManagedIdentitiesServiceClient.common_organization_path)
    parse_common_organization_path = staticmethod(ManagedIdentitiesServiceClient.parse_common_organization_path)
    common_project_path = staticmethod(ManagedIdentitiesServiceClient.common_project_path)
    parse_common_project_path = staticmethod(ManagedIdentitiesServiceClient.parse_common_project_path)
    common_location_path = staticmethod(ManagedIdentitiesServiceClient.common_location_path)
    parse_common_location_path = staticmethod(ManagedIdentitiesServiceClient.parse_common_location_path)

    @classmethod
    def from_service_account_info(cls, info: dict, *args, **kwargs):
        """Creates an instance of this client using the provided credentials
            info.

        Args:
            info (dict): The service account private key info.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            ManagedIdentitiesServiceAsyncClient: The constructed client.
        """
        return ManagedIdentitiesServiceClient.from_service_account_info.__func__(ManagedIdentitiesServiceAsyncClient, info, *args, **kwargs)  # type: ignore

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
            ManagedIdentitiesServiceAsyncClient: The constructed client.
        """
        return ManagedIdentitiesServiceClient.from_service_account_file.__func__(ManagedIdentitiesServiceAsyncClient, filename, *args, **kwargs)  # type: ignore

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> ManagedIdentitiesServiceTransport:
        """Returns the transport used by the client instance.

        Returns:
            ManagedIdentitiesServiceTransport: The transport used by the client instance.
        """
        return self._client.transport

    get_transport_class = functools.partial(type(ManagedIdentitiesServiceClient).get_transport_class, type(ManagedIdentitiesServiceClient))

    def __init__(self, *,
            credentials: ga_credentials.Credentials = None,
            transport: Union[str, ManagedIdentitiesServiceTransport] = "grpc_asyncio",
            client_options: ClientOptions = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiates the managed identities service client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, ~.ManagedIdentitiesServiceTransport]): The
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
        self._client = ManagedIdentitiesServiceClient(
            credentials=credentials,
            transport=transport,
            client_options=client_options,
            client_info=client_info,

        )

    async def create_microsoft_ad_domain(self,
            request: Union[managed_identities_service.CreateMicrosoftAdDomainRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Creates a Microsoft AD domain.

        Args:
            request (Union[google.cloud.managedidentities_v1beta1.types.CreateMicrosoftAdDomainRequest, dict]):
                The request object. Request message for
                [CreateMicrosoftAdDomain][google.cloud.managedidentities.v1beta1.CreateMicrosoftAdDomain]
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation_async.AsyncOperation:
                An object representing a long-running operation.

                The result type for the operation will be
                :class:`google.cloud.managedidentities_v1beta1.types.Domain`
                Represents a managed Microsoft Active Directory domain.

        """
        # Create or coerce a protobuf request object.
        request = managed_identities_service.CreateMicrosoftAdDomainRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.create_microsoft_ad_domain,
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
            resource.Domain,
            metadata_type=managed_identities_service.OpMetadata,
        )

        # Done; return the response.
        return response

    async def reset_admin_password(self,
            request: Union[managed_identities_service.ResetAdminPasswordRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> managed_identities_service.ResetAdminPasswordResponse:
        r"""Resets a domain's administrator password.

        Args:
            request (Union[google.cloud.managedidentities_v1beta1.types.ResetAdminPasswordRequest, dict]):
                The request object. Request message for
                [ResetAdminPassword][google.cloud.managedidentities.v1beta1.ResetAdminPassword]
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.managedidentities_v1beta1.types.ResetAdminPasswordResponse:
                Response message for
                   [ResetAdminPassword][google.cloud.managedidentities.v1beta1.ResetAdminPassword]

        """
        # Create or coerce a protobuf request object.
        request = managed_identities_service.ResetAdminPasswordRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.reset_admin_password,
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

    async def list_domains(self,
            request: Union[managed_identities_service.ListDomainsRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListDomainsAsyncPager:
        r"""Lists domains in a project.

        Args:
            request (Union[google.cloud.managedidentities_v1beta1.types.ListDomainsRequest, dict]):
                The request object. Request message for
                [ListDomains][google.cloud.managedidentities.v1beta1.ListDomains]
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.managedidentities_v1beta1.services.managed_identities_service.pagers.ListDomainsAsyncPager:
                Response message for
                   [ListDomains][google.cloud.managedidentities.v1beta1.ListDomains]

                Iterating over this object will yield results and
                resolve additional pages automatically.

        """
        # Create or coerce a protobuf request object.
        request = managed_identities_service.ListDomainsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_domains,
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
        response = pagers.ListDomainsAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def get_domain(self,
            request: Union[managed_identities_service.GetDomainRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> resource.Domain:
        r"""Gets information about a domain.

        Args:
            request (Union[google.cloud.managedidentities_v1beta1.types.GetDomainRequest, dict]):
                The request object. Request message for
                [GetDomain][google.cloud.managedidentities.v1beta1.GetDomain]
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.managedidentities_v1beta1.types.Domain:
                Represents a managed Microsoft Active
                Directory domain.

        """
        # Create or coerce a protobuf request object.
        request = managed_identities_service.GetDomainRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_domain,
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

    async def update_domain(self,
            request: Union[managed_identities_service.UpdateDomainRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Updates the metadata and configuration of a domain.

        Args:
            request (Union[google.cloud.managedidentities_v1beta1.types.UpdateDomainRequest, dict]):
                The request object. Request message for
                [UpdateDomain][google.cloud.managedidentities.v1beta1.UpdateDomain]
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation_async.AsyncOperation:
                An object representing a long-running operation.

                The result type for the operation will be
                :class:`google.cloud.managedidentities_v1beta1.types.Domain`
                Represents a managed Microsoft Active Directory domain.

        """
        # Create or coerce a protobuf request object.
        request = managed_identities_service.UpdateDomainRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.update_domain,
            default_timeout=None,
            client_info=DEFAULT_CLIENT_INFO,
        )

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("domain.name", request.domain.name),
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
            resource.Domain,
            metadata_type=managed_identities_service.OpMetadata,
        )

        # Done; return the response.
        return response

    async def delete_domain(self,
            request: Union[managed_identities_service.DeleteDomainRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Deletes a domain.

        Args:
            request (Union[google.cloud.managedidentities_v1beta1.types.DeleteDomainRequest, dict]):
                The request object. Request message for
                [DeleteDomain][google.cloud.managedidentities.v1beta1.DeleteDomain]
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
        request = managed_identities_service.DeleteDomainRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.delete_domain,
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
            metadata_type=managed_identities_service.OpMetadata,
        )

        # Done; return the response.
        return response

    async def attach_trust(self,
            request: Union[managed_identities_service.AttachTrustRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Adds an AD trust to a domain.

        Args:
            request (Union[google.cloud.managedidentities_v1beta1.types.AttachTrustRequest, dict]):
                The request object. Request message for
                [AttachTrust][google.cloud.managedidentities.v1beta1.AttachTrust]
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation_async.AsyncOperation:
                An object representing a long-running operation.

                The result type for the operation will be
                :class:`google.cloud.managedidentities_v1beta1.types.Domain`
                Represents a managed Microsoft Active Directory domain.

        """
        # Create or coerce a protobuf request object.
        request = managed_identities_service.AttachTrustRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.attach_trust,
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
            resource.Domain,
            metadata_type=managed_identities_service.OpMetadata,
        )

        # Done; return the response.
        return response

    async def reconfigure_trust(self,
            request: Union[managed_identities_service.ReconfigureTrustRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Updates the DNS conditional forwarder.

        Args:
            request (Union[google.cloud.managedidentities_v1beta1.types.ReconfigureTrustRequest, dict]):
                The request object. Request message for
                [ReconfigureTrust][google.cloud.managedidentities.v1beta1.ReconfigureTrust]
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation_async.AsyncOperation:
                An object representing a long-running operation.

                The result type for the operation will be
                :class:`google.cloud.managedidentities_v1beta1.types.Domain`
                Represents a managed Microsoft Active Directory domain.

        """
        # Create or coerce a protobuf request object.
        request = managed_identities_service.ReconfigureTrustRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.reconfigure_trust,
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
            resource.Domain,
            metadata_type=managed_identities_service.OpMetadata,
        )

        # Done; return the response.
        return response

    async def detach_trust(self,
            request: Union[managed_identities_service.DetachTrustRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Removes an AD trust.

        Args:
            request (Union[google.cloud.managedidentities_v1beta1.types.DetachTrustRequest, dict]):
                The request object. Request message for
                [DetachTrust][google.cloud.managedidentities.v1beta1.DetachTrust]
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation_async.AsyncOperation:
                An object representing a long-running operation.

                The result type for the operation will be
                :class:`google.cloud.managedidentities_v1beta1.types.Domain`
                Represents a managed Microsoft Active Directory domain.

        """
        # Create or coerce a protobuf request object.
        request = managed_identities_service.DetachTrustRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.detach_trust,
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
            resource.Domain,
            metadata_type=managed_identities_service.OpMetadata,
        )

        # Done; return the response.
        return response

    async def validate_trust(self,
            request: Union[managed_identities_service.ValidateTrustRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Validates a trust state, that the target domain is
        reachable, and that the target domain is able to accept
        incoming trust requests.

        Args:
            request (Union[google.cloud.managedidentities_v1beta1.types.ValidateTrustRequest, dict]):
                The request object. Request message for
                [ValidateTrust][google.cloud.managedidentities.v1beta1.ValidateTrust]
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation_async.AsyncOperation:
                An object representing a long-running operation.

                The result type for the operation will be
                :class:`google.cloud.managedidentities_v1beta1.types.Domain`
                Represents a managed Microsoft Active Directory domain.

        """
        # Create or coerce a protobuf request object.
        request = managed_identities_service.ValidateTrustRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.validate_trust,
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
            resource.Domain,
            metadata_type=managed_identities_service.OpMetadata,
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
            "google-cloud-managedidentities",
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    "ManagedIdentitiesServiceAsyncClient",
)
