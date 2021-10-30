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
from typing import Dict, Optional, Sequence, Tuple, Type, Union
import pkg_resources
import warnings

from google.api_core import client_options as client_options_lib  # type: ignore
from google.api_core import exceptions as core_exceptions         # type: ignore
from google.api_core import gapic_v1                              # type: ignore
from google.api_core import retry as retries                      # type: ignore
from google.auth import credentials as ga_credentials             # type: ignore
from google.auth.transport import mtls                            # type: ignore
from google.auth.transport.grpc import SslCredentials             # type: ignore
from google.auth.exceptions import MutualTLSChannelError          # type: ignore
from google.oauth2 import service_account                         # type: ignore

OptionalRetry = Union[retries.Retry, object]

from google.api.serviceusage_v1beta1.services.service_usage import pagers
from google.api.serviceusage_v1beta1.types import resources
from google.api.serviceusage_v1beta1.types import serviceusage
from google.api_core import operation  # type: ignore
from google.api_core import operation_async  # type: ignore
from google.protobuf import empty_pb2  # type: ignore
from .transports.base import ServiceUsageTransport, DEFAULT_CLIENT_INFO
from .transports.grpc import ServiceUsageGrpcTransport
from .transports.grpc_asyncio import ServiceUsageGrpcAsyncIOTransport


class ServiceUsageClientMeta(type):
    """Metaclass for the ServiceUsage client.

    This provides class-level methods for building and retrieving
    support objects (e.g. transport) without polluting the client instance
    objects.
    """
    _transport_registry = OrderedDict()  # type: Dict[str, Type[ServiceUsageTransport]]
    _transport_registry["grpc"] = ServiceUsageGrpcTransport
    _transport_registry["grpc_asyncio"] = ServiceUsageGrpcAsyncIOTransport

    def get_transport_class(cls,
            label: str = None,
        ) -> Type[ServiceUsageTransport]:
        """Returns an appropriate transport class.

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


class ServiceUsageClient(metaclass=ServiceUsageClientMeta):
    """`Service Usage
    API <https://cloud.google.com/service-usage/docs/overview>`__
    """

    @staticmethod
    def _get_default_mtls_endpoint(api_endpoint):
        """Converts api endpoint to mTLS endpoint.

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

    DEFAULT_ENDPOINT = "serviceusage.googleapis.com"
    DEFAULT_MTLS_ENDPOINT = _get_default_mtls_endpoint.__func__(  # type: ignore
        DEFAULT_ENDPOINT
    )

    @classmethod
    def from_service_account_info(cls, info: dict, *args, **kwargs):
        """Creates an instance of this client using the provided credentials
            info.

        Args:
            info (dict): The service account private key info.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            ServiceUsageClient: The constructed client.
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
            ServiceUsageClient: The constructed client.
        """
        credentials = service_account.Credentials.from_service_account_file(
            filename)
        kwargs["credentials"] = credentials
        return cls(*args, **kwargs)

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> ServiceUsageTransport:
        """Returns the transport used by the client instance.

        Returns:
            ServiceUsageTransport: The transport used by the client
                instance.
        """
        return self._transport

    @staticmethod
    def common_billing_account_path(billing_account: str, ) -> str:
        """Returns a fully-qualified billing_account string."""
        return "billingAccounts/{billing_account}".format(billing_account=billing_account, )

    @staticmethod
    def parse_common_billing_account_path(path: str) -> Dict[str,str]:
        """Parse a billing_account path into its component segments."""
        m = re.match(r"^billingAccounts/(?P<billing_account>.+?)$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def common_folder_path(folder: str, ) -> str:
        """Returns a fully-qualified folder string."""
        return "folders/{folder}".format(folder=folder, )

    @staticmethod
    def parse_common_folder_path(path: str) -> Dict[str,str]:
        """Parse a folder path into its component segments."""
        m = re.match(r"^folders/(?P<folder>.+?)$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def common_organization_path(organization: str, ) -> str:
        """Returns a fully-qualified organization string."""
        return "organizations/{organization}".format(organization=organization, )

    @staticmethod
    def parse_common_organization_path(path: str) -> Dict[str,str]:
        """Parse a organization path into its component segments."""
        m = re.match(r"^organizations/(?P<organization>.+?)$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def common_project_path(project: str, ) -> str:
        """Returns a fully-qualified project string."""
        return "projects/{project}".format(project=project, )

    @staticmethod
    def parse_common_project_path(path: str) -> Dict[str,str]:
        """Parse a project path into its component segments."""
        m = re.match(r"^projects/(?P<project>.+?)$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def common_location_path(project: str, location: str, ) -> str:
        """Returns a fully-qualified location string."""
        return "projects/{project}/locations/{location}".format(project=project, location=location, )

    @staticmethod
    def parse_common_location_path(path: str) -> Dict[str,str]:
        """Parse a location path into its component segments."""
        m = re.match(r"^projects/(?P<project>.+?)/locations/(?P<location>.+?)$", path)
        return m.groupdict() if m else {}

    def __init__(self, *,
            credentials: Optional[ga_credentials.Credentials] = None,
            transport: Union[str, ServiceUsageTransport, None] = None,
            client_options: Optional[client_options_lib.ClientOptions] = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiates the service usage client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, ServiceUsageTransport]): The
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
                if is_mtls:
                    client_cert_source_func = mtls.default_client_cert_source()
                else:
                    client_cert_source_func = None

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
                if is_mtls:
                    api_endpoint = self.DEFAULT_MTLS_ENDPOINT
                else:
                    api_endpoint = self.DEFAULT_ENDPOINT
            else:
                raise MutualTLSChannelError(
                    "Unsupported GOOGLE_API_USE_MTLS_ENDPOINT value. Accepted "
                    "values: never, auto, always"
                )

        # Save or instantiate the transport.
        # Ordinarily, we provide the transport, but allowing a custom transport
        # instance provides an extensibility point for unusual situations.
        if isinstance(transport, ServiceUsageTransport):
            # transport is a ServiceUsageTransport instance.
            if credentials or client_options.credentials_file:
                raise ValueError("When providing a transport instance, "
                                 "provide its credentials directly.")
            if client_options.scopes:
                raise ValueError(
                    "When providing a transport instance, provide its scopes "
                    "directly."
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
                always_use_jwt_access=True,
            )

    def enable_service(self,
            request: Union[serviceusage.EnableServiceRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
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
            google.api_core.operation.Operation:
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
        warnings.warn("ServiceUsageClient.enable_service is deprecated",
            DeprecationWarning)

        # Create or coerce a protobuf request object.
        # Minor optimization to avoid making a copy if the user passes
        # in a serviceusage.EnableServiceRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, serviceusage.EnableServiceRequest):
            request = serviceusage.EnableServiceRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.enable_service]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            empty_pb2.Empty,
            metadata_type=resources.OperationMetadata,
        )

        # Done; return the response.
        return response

    def disable_service(self,
            request: Union[serviceusage.DisableServiceRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
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
            google.api_core.operation.Operation:
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
        warnings.warn("ServiceUsageClient.disable_service is deprecated",
            DeprecationWarning)

        # Create or coerce a protobuf request object.
        # Minor optimization to avoid making a copy if the user passes
        # in a serviceusage.DisableServiceRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, serviceusage.DisableServiceRequest):
            request = serviceusage.DisableServiceRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.disable_service]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            empty_pb2.Empty,
            metadata_type=resources.OperationMetadata,
        )

        # Done; return the response.
        return response

    def get_service(self,
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
        warnings.warn("ServiceUsageClient.get_service is deprecated",
            DeprecationWarning)

        # Create or coerce a protobuf request object.
        # Minor optimization to avoid making a copy if the user passes
        # in a serviceusage.GetServiceRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, serviceusage.GetServiceRequest):
            request = serviceusage.GetServiceRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.get_service]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
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

    def list_services(self,
            request: Union[serviceusage.ListServicesRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListServicesPager:
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
            google.api.serviceusage_v1beta1.services.service_usage.pagers.ListServicesPager:
                Response message for the ListServices method.

                Iterating over this object will yield results and
                resolve additional pages automatically.

        """
        warnings.warn("ServiceUsageClient.list_services is deprecated",
            DeprecationWarning)

        # Create or coerce a protobuf request object.
        # Minor optimization to avoid making a copy if the user passes
        # in a serviceusage.ListServicesRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, serviceusage.ListServicesRequest):
            request = serviceusage.ListServicesRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.list_services]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("parent", request.parent),
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
        response = pagers.ListServicesPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def batch_enable_services(self,
            request: Union[serviceusage.BatchEnableServicesRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
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
            google.api_core.operation.Operation:
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
        warnings.warn("ServiceUsageClient.batch_enable_services is deprecated",
            DeprecationWarning)

        # Create or coerce a protobuf request object.
        # Minor optimization to avoid making a copy if the user passes
        # in a serviceusage.BatchEnableServicesRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, serviceusage.BatchEnableServicesRequest):
            request = serviceusage.BatchEnableServicesRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.batch_enable_services]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("parent", request.parent),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            empty_pb2.Empty,
            metadata_type=resources.OperationMetadata,
        )

        # Done; return the response.
        return response

    def list_consumer_quota_metrics(self,
            request: Union[serviceusage.ListConsumerQuotaMetricsRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListConsumerQuotaMetricsPager:
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
            google.api.serviceusage_v1beta1.services.service_usage.pagers.ListConsumerQuotaMetricsPager:
                Response message for
                ListConsumerQuotaMetrics
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        # Minor optimization to avoid making a copy if the user passes
        # in a serviceusage.ListConsumerQuotaMetricsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, serviceusage.ListConsumerQuotaMetricsRequest):
            request = serviceusage.ListConsumerQuotaMetricsRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.list_consumer_quota_metrics]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("parent", request.parent),
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
        response = pagers.ListConsumerQuotaMetricsPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def get_consumer_quota_metric(self,
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
        # Minor optimization to avoid making a copy if the user passes
        # in a serviceusage.GetConsumerQuotaMetricRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, serviceusage.GetConsumerQuotaMetricRequest):
            request = serviceusage.GetConsumerQuotaMetricRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.get_consumer_quota_metric]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
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

    def get_consumer_quota_limit(self,
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
        # Minor optimization to avoid making a copy if the user passes
        # in a serviceusage.GetConsumerQuotaLimitRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, serviceusage.GetConsumerQuotaLimitRequest):
            request = serviceusage.GetConsumerQuotaLimitRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.get_consumer_quota_limit]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
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

    def create_admin_override(self,
            request: Union[serviceusage.CreateAdminOverrideRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
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
            google.api_core.operation.Operation:
                An object representing a long-running operation.

                The result type for the operation will be
                :class:`google.api.serviceusage_v1beta1.types.QuotaOverride`
                A quota override

        """
        # Create or coerce a protobuf request object.
        # Minor optimization to avoid making a copy if the user passes
        # in a serviceusage.CreateAdminOverrideRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, serviceusage.CreateAdminOverrideRequest):
            request = serviceusage.CreateAdminOverrideRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.create_admin_override]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("parent", request.parent),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            resources.QuotaOverride,
            metadata_type=resources.OperationMetadata,
        )

        # Done; return the response.
        return response

    def update_admin_override(self,
            request: Union[serviceusage.UpdateAdminOverrideRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
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
            google.api_core.operation.Operation:
                An object representing a long-running operation.

                The result type for the operation will be
                :class:`google.api.serviceusage_v1beta1.types.QuotaOverride`
                A quota override

        """
        # Create or coerce a protobuf request object.
        # Minor optimization to avoid making a copy if the user passes
        # in a serviceusage.UpdateAdminOverrideRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, serviceusage.UpdateAdminOverrideRequest):
            request = serviceusage.UpdateAdminOverrideRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.update_admin_override]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            resources.QuotaOverride,
            metadata_type=resources.OperationMetadata,
        )

        # Done; return the response.
        return response

    def delete_admin_override(self,
            request: Union[serviceusage.DeleteAdminOverrideRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
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
            google.api_core.operation.Operation:
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
        # Minor optimization to avoid making a copy if the user passes
        # in a serviceusage.DeleteAdminOverrideRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, serviceusage.DeleteAdminOverrideRequest):
            request = serviceusage.DeleteAdminOverrideRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.delete_admin_override]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            empty_pb2.Empty,
            metadata_type=resources.OperationMetadata,
        )

        # Done; return the response.
        return response

    def list_admin_overrides(self,
            request: Union[serviceusage.ListAdminOverridesRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListAdminOverridesPager:
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
            google.api.serviceusage_v1beta1.services.service_usage.pagers.ListAdminOverridesPager:
                Response message for
                ListAdminOverrides.
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        # Minor optimization to avoid making a copy if the user passes
        # in a serviceusage.ListAdminOverridesRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, serviceusage.ListAdminOverridesRequest):
            request = serviceusage.ListAdminOverridesRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.list_admin_overrides]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("parent", request.parent),
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
        response = pagers.ListAdminOverridesPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def import_admin_overrides(self,
            request: Union[serviceusage.ImportAdminOverridesRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
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
            google.api_core.operation.Operation:
                An object representing a long-running operation.

                The result type for the operation will be
                :class:`google.api.serviceusage_v1beta1.types.ImportAdminOverridesResponse`
                Response message for ImportAdminOverrides

        """
        # Create or coerce a protobuf request object.
        # Minor optimization to avoid making a copy if the user passes
        # in a serviceusage.ImportAdminOverridesRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, serviceusage.ImportAdminOverridesRequest):
            request = serviceusage.ImportAdminOverridesRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.import_admin_overrides]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("parent", request.parent),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            serviceusage.ImportAdminOverridesResponse,
            metadata_type=serviceusage.ImportAdminOverridesMetadata,
        )

        # Done; return the response.
        return response

    def create_consumer_override(self,
            request: Union[serviceusage.CreateConsumerOverrideRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
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
            google.api_core.operation.Operation:
                An object representing a long-running operation.

                The result type for the operation will be
                :class:`google.api.serviceusage_v1beta1.types.QuotaOverride`
                A quota override

        """
        # Create or coerce a protobuf request object.
        # Minor optimization to avoid making a copy if the user passes
        # in a serviceusage.CreateConsumerOverrideRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, serviceusage.CreateConsumerOverrideRequest):
            request = serviceusage.CreateConsumerOverrideRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.create_consumer_override]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("parent", request.parent),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            resources.QuotaOverride,
            metadata_type=resources.OperationMetadata,
        )

        # Done; return the response.
        return response

    def update_consumer_override(self,
            request: Union[serviceusage.UpdateConsumerOverrideRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
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
            google.api_core.operation.Operation:
                An object representing a long-running operation.

                The result type for the operation will be
                :class:`google.api.serviceusage_v1beta1.types.QuotaOverride`
                A quota override

        """
        # Create or coerce a protobuf request object.
        # Minor optimization to avoid making a copy if the user passes
        # in a serviceusage.UpdateConsumerOverrideRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, serviceusage.UpdateConsumerOverrideRequest):
            request = serviceusage.UpdateConsumerOverrideRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.update_consumer_override]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            resources.QuotaOverride,
            metadata_type=resources.OperationMetadata,
        )

        # Done; return the response.
        return response

    def delete_consumer_override(self,
            request: Union[serviceusage.DeleteConsumerOverrideRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
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
            google.api_core.operation.Operation:
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
        # Minor optimization to avoid making a copy if the user passes
        # in a serviceusage.DeleteConsumerOverrideRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, serviceusage.DeleteConsumerOverrideRequest):
            request = serviceusage.DeleteConsumerOverrideRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.delete_consumer_override]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("name", request.name),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            empty_pb2.Empty,
            metadata_type=resources.OperationMetadata,
        )

        # Done; return the response.
        return response

    def list_consumer_overrides(self,
            request: Union[serviceusage.ListConsumerOverridesRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListConsumerOverridesPager:
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
            google.api.serviceusage_v1beta1.services.service_usage.pagers.ListConsumerOverridesPager:
                Response message for
                ListConsumerOverrides.
                Iterating over this object will yield
                results and resolve additional pages
                automatically.

        """
        # Create or coerce a protobuf request object.
        # Minor optimization to avoid making a copy if the user passes
        # in a serviceusage.ListConsumerOverridesRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, serviceusage.ListConsumerOverridesRequest):
            request = serviceusage.ListConsumerOverridesRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.list_consumer_overrides]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("parent", request.parent),
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
        response = pagers.ListConsumerOverridesPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def import_consumer_overrides(self,
            request: Union[serviceusage.ImportConsumerOverridesRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
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
            google.api_core.operation.Operation:
                An object representing a long-running operation.

                The result type for the operation will be
                :class:`google.api.serviceusage_v1beta1.types.ImportConsumerOverridesResponse`
                Response message for ImportConsumerOverrides

        """
        # Create or coerce a protobuf request object.
        # Minor optimization to avoid making a copy if the user passes
        # in a serviceusage.ImportConsumerOverridesRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, serviceusage.ImportConsumerOverridesRequest):
            request = serviceusage.ImportConsumerOverridesRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.import_consumer_overrides]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("parent", request.parent),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            serviceusage.ImportConsumerOverridesResponse,
            metadata_type=serviceusage.ImportConsumerOverridesMetadata,
        )

        # Done; return the response.
        return response

    def generate_service_identity(self,
            request: Union[serviceusage.GenerateServiceIdentityRequest, dict] = None,
            *,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
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
            google.api_core.operation.Operation:
                An object representing a long-running operation.

                The result type for the operation will be :class:`google.api.serviceusage_v1beta1.types.ServiceIdentity` Service identity for a service. This is the identity that service producer
                   should use to access consumer resources.

        """
        # Create or coerce a protobuf request object.
        # Minor optimization to avoid making a copy if the user passes
        # in a serviceusage.GenerateServiceIdentityRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, serviceusage.GenerateServiceIdentityRequest):
            request = serviceusage.GenerateServiceIdentityRequest(request)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.generate_service_identity]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("parent", request.parent),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            resources.ServiceIdentity,
            metadata_type=empty_pb2.Empty,
        )

        # Done; return the response.
        return response

    def __enter__(self):
        return self

    def __exit__(self, type, value, traceback):
        """Releases underlying transport's resources.

        .. warning::
            ONLY use as a context manager if the transport is NOT shared
            with other clients! Exiting the with block will CLOSE the transport
            and may cause errors in other clients!
        """
        self.transport.close()



try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            "google-api-serviceusage",
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    "ServiceUsageClient",
)
