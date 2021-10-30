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
import warnings

from google.api_core.client_options import ClientOptions # type: ignore
from google.api_core import exceptions as core_exceptions  # type: ignore
from google.api_core import gapic_v1                   # type: ignore
from google.api_core import retry as retries           # type: ignore
from google.auth import credentials as ga_credentials   # type: ignore
from google.oauth2 import service_account              # type: ignore

OptionalRetry = Union[retries.Retry, object]

from google.api.serviceusage_v1beta1.services.service_usage import pagers
from google.api.serviceusage_v1beta1.types import resources
from google.api.serviceusage_v1beta1.types import serviceusage
from google.api_core import operation  # type: ignore
from google.api_core import operation_async  # type: ignore
from google.protobuf import empty_pb2  # type: ignore
from .transports.base import ServiceUsageTransport, DEFAULT_CLIENT_INFO
from .transports.grpc_asyncio import ServiceUsageGrpcAsyncIOTransport
from .client import ServiceUsageClient


class ServiceUsageAsyncClient:
    """`Service Usage
    API <https://cloud.google.com/service-usage/docs/overview>`__
    """

    _client: ServiceUsageClient

    DEFAULT_ENDPOINT = ServiceUsageClient.DEFAULT_ENDPOINT
    DEFAULT_MTLS_ENDPOINT = ServiceUsageClient.DEFAULT_MTLS_ENDPOINT

    common_billing_account_path = staticmethod(ServiceUsageClient.common_billing_account_path)
    parse_common_billing_account_path = staticmethod(ServiceUsageClient.parse_common_billing_account_path)
    common_folder_path = staticmethod(ServiceUsageClient.common_folder_path)
    parse_common_folder_path = staticmethod(ServiceUsageClient.parse_common_folder_path)
    common_organization_path = staticmethod(ServiceUsageClient.common_organization_path)
    parse_common_organization_path = staticmethod(ServiceUsageClient.parse_common_organization_path)
    common_project_path = staticmethod(ServiceUsageClient.common_project_path)
    parse_common_project_path = staticmethod(ServiceUsageClient.parse_common_project_path)
    common_location_path = staticmethod(ServiceUsageClient.common_location_path)
    parse_common_location_path = staticmethod(ServiceUsageClient.parse_common_location_path)

    @classmethod
    def from_service_account_info(cls, info: dict, *args, **kwargs):
        """Creates an instance of this client using the provided credentials
            info.

        Args:
            info (dict): The service account private key info.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            ServiceUsageAsyncClient: The constructed client.
        """
        return ServiceUsageClient.from_service_account_info.__func__(ServiceUsageAsyncClient, info, *args, **kwargs)  # type: ignore

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
            ServiceUsageAsyncClient: The constructed client.
        """
        return ServiceUsageClient.from_service_account_file.__func__(ServiceUsageAsyncClient, filename, *args, **kwargs)  # type: ignore

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> ServiceUsageTransport:
        """Returns the transport used by the client instance.

        Returns:
            ServiceUsageTransport: The transport used by the client instance.
        """
        return self._client.transport

    get_transport_class = functools.partial(type(ServiceUsageClient).get_transport_class, type(ServiceUsageClient))

    def __init__(self, *,
            credentials: ga_credentials.Credentials = None,
            transport: Union[str, ServiceUsageTransport] = "grpc_asyncio",
            client_options: ClientOptions = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiates the service usage client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, ~.ServiceUsageTransport]): The
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
        self._client = ServiceUsageClient(
            credentials=credentials,
            transport=transport,
            client_options=client_options,
            client_info=client_info,

        )

    async def enable_service(self,
            request: Union[serviceusage.EnableServiceRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Enables a service so that it can be used with a project.

        Operation response type: ``google.protobuf.Empty``

        Args:
            request (Union[google.api.serviceusage_v1beta1.types.EnableServiceRequest, dict]):
                The request object. Request message for the
                `EnableService` method.
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
        warnings.warn("ServiceUsageAsyncClient.enable_service is deprecated",
            DeprecationWarning)

        # Create or coerce a protobuf request object.
        request = serviceusage.EnableServiceRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.enable_service,
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
            metadata_type=resources.OperationMetadata,
        )

        # Done; return the response.
        return response

    async def disable_service(self,
            request: Union[serviceusage.DisableServiceRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Disables a service so that it can no longer be used with a
        project. This prevents unintended usage that may cause
        unexpected billing charges or security leaks.

        It is not valid to call the disable method on a service that is
        not currently enabled. Callers will receive a
        ``FAILED_PRECONDITION`` status if the target service is not
        currently enabled.

        Operation response type: ``google.protobuf.Empty``

        Args:
            request (Union[google.api.serviceusage_v1beta1.types.DisableServiceRequest, dict]):
                The request object. Request message for the
                `DisableService` method.
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
        warnings.warn("ServiceUsageAsyncClient.disable_service is deprecated",
            DeprecationWarning)

        # Create or coerce a protobuf request object.
        request = serviceusage.DisableServiceRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.disable_service,
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
            metadata_type=resources.OperationMetadata,
        )

        # Done; return the response.
        return response

    async def get_service(self,
            request: Union[serviceusage.GetServiceRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> resources.Service:
        r"""Returns the service configuration and enabled state
        for a given service.

        Args:
            request (Union[google.api.serviceusage_v1beta1.types.GetServiceRequest, dict]):
                The request object. Request message for the `GetService`
                method.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api.serviceusage_v1beta1.types.Service:
                A service that is available for use
                by the consumer.

        """
        warnings.warn("ServiceUsageAsyncClient.get_service is deprecated",
            DeprecationWarning)

        # Create or coerce a protobuf request object.
        request = serviceusage.GetServiceRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_service,
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

    async def list_services(self,
            request: Union[serviceusage.ListServicesRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListServicesAsyncPager:
        r"""Lists all services available to the specified project, and the
        current state of those services with respect to the project. The
        list includes all public services, all services for which the
        calling user has the ``servicemanagement.services.bind``
        permission, and all services that have already been enabled on
        the project. The list can be filtered to only include services
        in a specific state, for example to only include services
        enabled on the project.

        Args:
            request (Union[google.api.serviceusage_v1beta1.types.ListServicesRequest, dict]):
                The request object. Request message for the
                `ListServices` method.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api.serviceusage_v1beta1.services.service_usage.pagers.ListServicesAsyncPager:
                Response message for the ListServices method.

                Iterating over this object will yield results and
                resolve additional pages automatically.

        """
        warnings.warn("ServiceUsageAsyncClient.list_services is deprecated",
            DeprecationWarning)

        # Create or coerce a protobuf request object.
        request = serviceusage.ListServicesRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_services,
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
        response = pagers.ListServicesAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def batch_enable_services(self,
            request: Union[serviceusage.BatchEnableServicesRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Enables multiple services on a project. The operation is atomic:
        if enabling any service fails, then the entire batch fails, and
        no state changes occur.

        Operation response type: ``google.protobuf.Empty``

        Args:
            request (Union[google.api.serviceusage_v1beta1.types.BatchEnableServicesRequest, dict]):
                The request object. Request message for the
                `BatchEnableServices` method.
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
        warnings.warn("ServiceUsageAsyncClient.batch_enable_services is deprecated",
            DeprecationWarning)

        # Create or coerce a protobuf request object.
        request = serviceusage.BatchEnableServicesRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.batch_enable_services,
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
            empty_pb2.Empty,
            metadata_type=resources.OperationMetadata,
        )

        # Done; return the response.
        return response

    async def list_consumer_quota_metrics(self,
            request: Union[serviceusage.ListConsumerQuotaMetricsRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListConsumerQuotaMetricsAsyncPager:
        r"""Retrieves a summary of all quota information visible
        to the service consumer, organized by service metric.
        Each metric includes information about all of its
        defined limits. Each limit includes the limit
        configuration (quota unit, preciseness, default value),
        the current effective limit value, and all of the
        overrides applied to the limit.

        Args:
            request (Union[google.api.serviceusage_v1beta1.types.ListConsumerQuotaMetricsRequest, dict]):
                The request object. Request message for
                ListConsumerQuotaMetrics
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api.serviceusage_v1beta1.services.service_usage.pagers.ListConsumerQuotaMetricsAsyncPager:
                Response message for
                ListConsumerQuotaMetrics
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        request = serviceusage.ListConsumerQuotaMetricsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_consumer_quota_metrics,
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
        response = pagers.ListConsumerQuotaMetricsAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def get_consumer_quota_metric(self,
            request: Union[serviceusage.GetConsumerQuotaMetricRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> resources.ConsumerQuotaMetric:
        r"""Retrieves a summary of quota information for a
        specific quota metric

        Args:
            request (Union[google.api.serviceusage_v1beta1.types.GetConsumerQuotaMetricRequest, dict]):
                The request object. Request message for
                GetConsumerQuotaMetric
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api.serviceusage_v1beta1.types.ConsumerQuotaMetric:
                Consumer quota settings for a quota
                metric.

        """
        # Create or coerce a protobuf request object.
        request = serviceusage.GetConsumerQuotaMetricRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_consumer_quota_metric,
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

    async def get_consumer_quota_limit(self,
            request: Union[serviceusage.GetConsumerQuotaLimitRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> resources.ConsumerQuotaLimit:
        r"""Retrieves a summary of quota information for a
        specific quota limit.

        Args:
            request (Union[google.api.serviceusage_v1beta1.types.GetConsumerQuotaLimitRequest, dict]):
                The request object. Request message for
                GetConsumerQuotaLimit
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api.serviceusage_v1beta1.types.ConsumerQuotaLimit:
                Consumer quota settings for a quota
                limit.

        """
        # Create or coerce a protobuf request object.
        request = serviceusage.GetConsumerQuotaLimitRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.get_consumer_quota_limit,
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

    async def create_admin_override(self,
            request: Union[serviceusage.CreateAdminOverrideRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Creates an admin override.
        An admin override is applied by an administrator of a
        parent folder or parent organization of the consumer
        receiving the override. An admin override is intended to
        limit the amount of quota the consumer can use out of
        the total quota pool allocated to all children of the
        folder or organization.

        Args:
            request (Union[google.api.serviceusage_v1beta1.types.CreateAdminOverrideRequest, dict]):
                The request object. Request message for
                CreateAdminOverride.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation_async.AsyncOperation:
                An object representing a long-running operation.

                The result type for the operation will be
                :class:`google.api.serviceusage_v1beta1.types.QuotaOverride`
                A quota override

        """
        # Create or coerce a protobuf request object.
        request = serviceusage.CreateAdminOverrideRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.create_admin_override,
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
            resources.QuotaOverride,
            metadata_type=resources.OperationMetadata,
        )

        # Done; return the response.
        return response

    async def update_admin_override(self,
            request: Union[serviceusage.UpdateAdminOverrideRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Updates an admin override.

        Args:
            request (Union[google.api.serviceusage_v1beta1.types.UpdateAdminOverrideRequest, dict]):
                The request object. Request message for
                UpdateAdminOverride.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation_async.AsyncOperation:
                An object representing a long-running operation.

                The result type for the operation will be
                :class:`google.api.serviceusage_v1beta1.types.QuotaOverride`
                A quota override

        """
        # Create or coerce a protobuf request object.
        request = serviceusage.UpdateAdminOverrideRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.update_admin_override,
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
            resources.QuotaOverride,
            metadata_type=resources.OperationMetadata,
        )

        # Done; return the response.
        return response

    async def delete_admin_override(self,
            request: Union[serviceusage.DeleteAdminOverrideRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Deletes an admin override.

        Args:
            request (Union[google.api.serviceusage_v1beta1.types.DeleteAdminOverrideRequest, dict]):
                The request object. Request message for
                DeleteAdminOverride.
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
        request = serviceusage.DeleteAdminOverrideRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.delete_admin_override,
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
            metadata_type=resources.OperationMetadata,
        )

        # Done; return the response.
        return response

    async def list_admin_overrides(self,
            request: Union[serviceusage.ListAdminOverridesRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListAdminOverridesAsyncPager:
        r"""Lists all admin overrides on this limit.

        Args:
            request (Union[google.api.serviceusage_v1beta1.types.ListAdminOverridesRequest, dict]):
                The request object. Request message for
                ListAdminOverrides
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api.serviceusage_v1beta1.services.service_usage.pagers.ListAdminOverridesAsyncPager:
                Response message for
                ListAdminOverrides.
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        request = serviceusage.ListAdminOverridesRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_admin_overrides,
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
        response = pagers.ListAdminOverridesAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def import_admin_overrides(self,
            request: Union[serviceusage.ImportAdminOverridesRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Creates or updates multiple admin overrides
        atomically, all on the same consumer, but on many
        different metrics or limits. The name field in the quota
        override message should not be set.

        Args:
            request (Union[google.api.serviceusage_v1beta1.types.ImportAdminOverridesRequest, dict]):
                The request object. Request message for
                ImportAdminOverrides
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation_async.AsyncOperation:
                An object representing a long-running operation.

                The result type for the operation will be
                :class:`google.api.serviceusage_v1beta1.types.ImportAdminOverridesResponse`
                Response message for ImportAdminOverrides

        """
        # Create or coerce a protobuf request object.
        request = serviceusage.ImportAdminOverridesRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.import_admin_overrides,
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
            serviceusage.ImportAdminOverridesResponse,
            metadata_type=serviceusage.ImportAdminOverridesMetadata,
        )

        # Done; return the response.
        return response

    async def create_consumer_override(self,
            request: Union[serviceusage.CreateConsumerOverrideRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Creates a consumer override.
        A consumer override is applied to the consumer on its
        own authority to limit its own quota usage. Consumer
        overrides cannot be used to grant more quota than would
        be allowed by admin overrides, producer overrides, or
        the default limit of the service.

        Args:
            request (Union[google.api.serviceusage_v1beta1.types.CreateConsumerOverrideRequest, dict]):
                The request object. Request message for
                CreateConsumerOverride.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation_async.AsyncOperation:
                An object representing a long-running operation.

                The result type for the operation will be
                :class:`google.api.serviceusage_v1beta1.types.QuotaOverride`
                A quota override

        """
        # Create or coerce a protobuf request object.
        request = serviceusage.CreateConsumerOverrideRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.create_consumer_override,
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
            resources.QuotaOverride,
            metadata_type=resources.OperationMetadata,
        )

        # Done; return the response.
        return response

    async def update_consumer_override(self,
            request: Union[serviceusage.UpdateConsumerOverrideRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Updates a consumer override.

        Args:
            request (Union[google.api.serviceusage_v1beta1.types.UpdateConsumerOverrideRequest, dict]):
                The request object. Request message for
                UpdateConsumerOverride.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation_async.AsyncOperation:
                An object representing a long-running operation.

                The result type for the operation will be
                :class:`google.api.serviceusage_v1beta1.types.QuotaOverride`
                A quota override

        """
        # Create or coerce a protobuf request object.
        request = serviceusage.UpdateConsumerOverrideRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.update_consumer_override,
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
            resources.QuotaOverride,
            metadata_type=resources.OperationMetadata,
        )

        # Done; return the response.
        return response

    async def delete_consumer_override(self,
            request: Union[serviceusage.DeleteConsumerOverrideRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Deletes a consumer override.

        Args:
            request (Union[google.api.serviceusage_v1beta1.types.DeleteConsumerOverrideRequest, dict]):
                The request object. Request message for
                DeleteConsumerOverride.
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
        request = serviceusage.DeleteConsumerOverrideRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.delete_consumer_override,
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
            metadata_type=resources.OperationMetadata,
        )

        # Done; return the response.
        return response

    async def list_consumer_overrides(self,
            request: Union[serviceusage.ListConsumerOverridesRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListConsumerOverridesAsyncPager:
        r"""Lists all consumer overrides on this limit.

        Args:
            request (Union[google.api.serviceusage_v1beta1.types.ListConsumerOverridesRequest, dict]):
                The request object. Request message for
                ListConsumerOverrides
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api.serviceusage_v1beta1.services.service_usage.pagers.ListConsumerOverridesAsyncPager:
                Response message for
                ListConsumerOverrides.
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        request = serviceusage.ListConsumerOverridesRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.list_consumer_overrides,
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
        response = pagers.ListConsumerOverridesAsyncPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    async def import_consumer_overrides(self,
            request: Union[serviceusage.ImportConsumerOverridesRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Creates or updates multiple consumer overrides
        atomically, all on the same consumer, but on many
        different metrics or limits. The name field in the quota
        override message should not be set.

        Args:
            request (Union[google.api.serviceusage_v1beta1.types.ImportConsumerOverridesRequest, dict]):
                The request object. Request message for
                ImportConsumerOverrides
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation_async.AsyncOperation:
                An object representing a long-running operation.

                The result type for the operation will be
                :class:`google.api.serviceusage_v1beta1.types.ImportConsumerOverridesResponse`
                Response message for ImportConsumerOverrides

        """
        # Create or coerce a protobuf request object.
        request = serviceusage.ImportConsumerOverridesRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.import_consumer_overrides,
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
            serviceusage.ImportConsumerOverridesResponse,
            metadata_type=serviceusage.ImportConsumerOverridesMetadata,
        )

        # Done; return the response.
        return response

    async def generate_service_identity(self,
            request: Union[serviceusage.GenerateServiceIdentityRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation_async.AsyncOperation:
        r"""Generates service identity for service.

        Args:
            request (Union[google.api.serviceusage_v1beta1.types.GenerateServiceIdentityRequest, dict]):
                The request object. Request message for generating
                service identity.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation_async.AsyncOperation:
                An object representing a long-running operation.

                The result type for the operation will be :class:`google.api.serviceusage_v1beta1.types.ServiceIdentity` Service identity for a service. This is the identity that service producer
                   should use to access consumer resources.

        """
        # Create or coerce a protobuf request object.
        request = serviceusage.GenerateServiceIdentityRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.generate_service_identity,
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
            resources.ServiceIdentity,
            metadata_type=empty_pb2.Empty,
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
            "google-api-serviceusage",
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    "ServiceUsageAsyncClient",
)
