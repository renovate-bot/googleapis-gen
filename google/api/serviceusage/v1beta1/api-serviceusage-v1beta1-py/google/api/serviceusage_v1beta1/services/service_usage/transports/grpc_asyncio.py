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

from google.api_core import gapic_v1
from google.api_core import grpc_helpers_async
from google.api_core import operations_v1
from google.auth import credentials as ga_credentials   # type: ignore
from google.auth.transport.grpc import SslCredentials  # type: ignore

import grpc                        # type: ignore
from grpc.experimental import aio  # type: ignore

from google.api.serviceusage_v1beta1.types import resources
from google.api.serviceusage_v1beta1.types import serviceusage
from google.longrunning import operations_pb2  # type: ignore
from .base import ServiceUsageTransport, DEFAULT_CLIENT_INFO
from .grpc import ServiceUsageGrpcTransport


class ServiceUsageGrpcAsyncIOTransport(ServiceUsageTransport):
    """gRPC AsyncIO backend transport for ServiceUsage.

    `Service Usage
    API <https://cloud.google.com/service-usage/docs/overview>`__

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
                       host: str = 'serviceusage.googleapis.com',
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
            host: str = 'serviceusage.googleapis.com',
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
        self._operations_client: Optional[operations_v1.OperationsAsyncClient] = None

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
    def operations_client(self) -> operations_v1.OperationsAsyncClient:
        """Create the client designed to process long-running operations.

        This property caches on the instance; repeated calls return the same
        client.
        """
        # Sanity check: Only create a new client if we do not already have one.
        if self._operations_client is None:
            self._operations_client = operations_v1.OperationsAsyncClient(
                self.grpc_channel
            )

        # Return the client from cache.
        return self._operations_client

    @property
    def enable_service(self) -> Callable[
            [serviceusage.EnableServiceRequest],
            Awaitable[operations_pb2.Operation]]:
        r"""Return a callable for the enable service method over gRPC.

        Enables a service so that it can be used with a project.

        Operation response type: ``google.protobuf.Empty``

        Returns:
            Callable[[~.EnableServiceRequest],
                    Awaitable[~.Operation]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'enable_service' not in self._stubs:
            self._stubs['enable_service'] = self.grpc_channel.unary_unary(
                '/google.api.serviceusage.v1beta1.ServiceUsage/EnableService',
                request_serializer=serviceusage.EnableServiceRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['enable_service']

    @property
    def disable_service(self) -> Callable[
            [serviceusage.DisableServiceRequest],
            Awaitable[operations_pb2.Operation]]:
        r"""Return a callable for the disable service method over gRPC.

        Disables a service so that it can no longer be used with a
        project. This prevents unintended usage that may cause
        unexpected billing charges or security leaks.

        It is not valid to call the disable method on a service that is
        not currently enabled. Callers will receive a
        ``FAILED_PRECONDITION`` status if the target service is not
        currently enabled.

        Operation response type: ``google.protobuf.Empty``

        Returns:
            Callable[[~.DisableServiceRequest],
                    Awaitable[~.Operation]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'disable_service' not in self._stubs:
            self._stubs['disable_service'] = self.grpc_channel.unary_unary(
                '/google.api.serviceusage.v1beta1.ServiceUsage/DisableService',
                request_serializer=serviceusage.DisableServiceRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['disable_service']

    @property
    def get_service(self) -> Callable[
            [serviceusage.GetServiceRequest],
            Awaitable[resources.Service]]:
        r"""Return a callable for the get service method over gRPC.

        Returns the service configuration and enabled state
        for a given service.

        Returns:
            Callable[[~.GetServiceRequest],
                    Awaitable[~.Service]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_service' not in self._stubs:
            self._stubs['get_service'] = self.grpc_channel.unary_unary(
                '/google.api.serviceusage.v1beta1.ServiceUsage/GetService',
                request_serializer=serviceusage.GetServiceRequest.serialize,
                response_deserializer=resources.Service.deserialize,
            )
        return self._stubs['get_service']

    @property
    def list_services(self) -> Callable[
            [serviceusage.ListServicesRequest],
            Awaitable[serviceusage.ListServicesResponse]]:
        r"""Return a callable for the list services method over gRPC.

        Lists all services available to the specified project, and the
        current state of those services with respect to the project. The
        list includes all public services, all services for which the
        calling user has the ``servicemanagement.services.bind``
        permission, and all services that have already been enabled on
        the project. The list can be filtered to only include services
        in a specific state, for example to only include services
        enabled on the project.

        Returns:
            Callable[[~.ListServicesRequest],
                    Awaitable[~.ListServicesResponse]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_services' not in self._stubs:
            self._stubs['list_services'] = self.grpc_channel.unary_unary(
                '/google.api.serviceusage.v1beta1.ServiceUsage/ListServices',
                request_serializer=serviceusage.ListServicesRequest.serialize,
                response_deserializer=serviceusage.ListServicesResponse.deserialize,
            )
        return self._stubs['list_services']

    @property
    def batch_enable_services(self) -> Callable[
            [serviceusage.BatchEnableServicesRequest],
            Awaitable[operations_pb2.Operation]]:
        r"""Return a callable for the batch enable services method over gRPC.

        Enables multiple services on a project. The operation is atomic:
        if enabling any service fails, then the entire batch fails, and
        no state changes occur.

        Operation response type: ``google.protobuf.Empty``

        Returns:
            Callable[[~.BatchEnableServicesRequest],
                    Awaitable[~.Operation]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'batch_enable_services' not in self._stubs:
            self._stubs['batch_enable_services'] = self.grpc_channel.unary_unary(
                '/google.api.serviceusage.v1beta1.ServiceUsage/BatchEnableServices',
                request_serializer=serviceusage.BatchEnableServicesRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['batch_enable_services']

    @property
    def list_consumer_quota_metrics(self) -> Callable[
            [serviceusage.ListConsumerQuotaMetricsRequest],
            Awaitable[serviceusage.ListConsumerQuotaMetricsResponse]]:
        r"""Return a callable for the list consumer quota metrics method over gRPC.

        Retrieves a summary of all quota information visible
        to the service consumer, organized by service metric.
        Each metric includes information about all of its
        defined limits. Each limit includes the limit
        configuration (quota unit, preciseness, default value),
        the current effective limit value, and all of the
        overrides applied to the limit.

        Returns:
            Callable[[~.ListConsumerQuotaMetricsRequest],
                    Awaitable[~.ListConsumerQuotaMetricsResponse]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_consumer_quota_metrics' not in self._stubs:
            self._stubs['list_consumer_quota_metrics'] = self.grpc_channel.unary_unary(
                '/google.api.serviceusage.v1beta1.ServiceUsage/ListConsumerQuotaMetrics',
                request_serializer=serviceusage.ListConsumerQuotaMetricsRequest.serialize,
                response_deserializer=serviceusage.ListConsumerQuotaMetricsResponse.deserialize,
            )
        return self._stubs['list_consumer_quota_metrics']

    @property
    def get_consumer_quota_metric(self) -> Callable[
            [serviceusage.GetConsumerQuotaMetricRequest],
            Awaitable[resources.ConsumerQuotaMetric]]:
        r"""Return a callable for the get consumer quota metric method over gRPC.

        Retrieves a summary of quota information for a
        specific quota metric

        Returns:
            Callable[[~.GetConsumerQuotaMetricRequest],
                    Awaitable[~.ConsumerQuotaMetric]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_consumer_quota_metric' not in self._stubs:
            self._stubs['get_consumer_quota_metric'] = self.grpc_channel.unary_unary(
                '/google.api.serviceusage.v1beta1.ServiceUsage/GetConsumerQuotaMetric',
                request_serializer=serviceusage.GetConsumerQuotaMetricRequest.serialize,
                response_deserializer=resources.ConsumerQuotaMetric.deserialize,
            )
        return self._stubs['get_consumer_quota_metric']

    @property
    def get_consumer_quota_limit(self) -> Callable[
            [serviceusage.GetConsumerQuotaLimitRequest],
            Awaitable[resources.ConsumerQuotaLimit]]:
        r"""Return a callable for the get consumer quota limit method over gRPC.

        Retrieves a summary of quota information for a
        specific quota limit.

        Returns:
            Callable[[~.GetConsumerQuotaLimitRequest],
                    Awaitable[~.ConsumerQuotaLimit]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_consumer_quota_limit' not in self._stubs:
            self._stubs['get_consumer_quota_limit'] = self.grpc_channel.unary_unary(
                '/google.api.serviceusage.v1beta1.ServiceUsage/GetConsumerQuotaLimit',
                request_serializer=serviceusage.GetConsumerQuotaLimitRequest.serialize,
                response_deserializer=resources.ConsumerQuotaLimit.deserialize,
            )
        return self._stubs['get_consumer_quota_limit']

    @property
    def create_admin_override(self) -> Callable[
            [serviceusage.CreateAdminOverrideRequest],
            Awaitable[operations_pb2.Operation]]:
        r"""Return a callable for the create admin override method over gRPC.

        Creates an admin override.
        An admin override is applied by an administrator of a
        parent folder or parent organization of the consumer
        receiving the override. An admin override is intended to
        limit the amount of quota the consumer can use out of
        the total quota pool allocated to all children of the
        folder or organization.

        Returns:
            Callable[[~.CreateAdminOverrideRequest],
                    Awaitable[~.Operation]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'create_admin_override' not in self._stubs:
            self._stubs['create_admin_override'] = self.grpc_channel.unary_unary(
                '/google.api.serviceusage.v1beta1.ServiceUsage/CreateAdminOverride',
                request_serializer=serviceusage.CreateAdminOverrideRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['create_admin_override']

    @property
    def update_admin_override(self) -> Callable[
            [serviceusage.UpdateAdminOverrideRequest],
            Awaitable[operations_pb2.Operation]]:
        r"""Return a callable for the update admin override method over gRPC.

        Updates an admin override.

        Returns:
            Callable[[~.UpdateAdminOverrideRequest],
                    Awaitable[~.Operation]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update_admin_override' not in self._stubs:
            self._stubs['update_admin_override'] = self.grpc_channel.unary_unary(
                '/google.api.serviceusage.v1beta1.ServiceUsage/UpdateAdminOverride',
                request_serializer=serviceusage.UpdateAdminOverrideRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['update_admin_override']

    @property
    def delete_admin_override(self) -> Callable[
            [serviceusage.DeleteAdminOverrideRequest],
            Awaitable[operations_pb2.Operation]]:
        r"""Return a callable for the delete admin override method over gRPC.

        Deletes an admin override.

        Returns:
            Callable[[~.DeleteAdminOverrideRequest],
                    Awaitable[~.Operation]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'delete_admin_override' not in self._stubs:
            self._stubs['delete_admin_override'] = self.grpc_channel.unary_unary(
                '/google.api.serviceusage.v1beta1.ServiceUsage/DeleteAdminOverride',
                request_serializer=serviceusage.DeleteAdminOverrideRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['delete_admin_override']

    @property
    def list_admin_overrides(self) -> Callable[
            [serviceusage.ListAdminOverridesRequest],
            Awaitable[serviceusage.ListAdminOverridesResponse]]:
        r"""Return a callable for the list admin overrides method over gRPC.

        Lists all admin overrides on this limit.

        Returns:
            Callable[[~.ListAdminOverridesRequest],
                    Awaitable[~.ListAdminOverridesResponse]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_admin_overrides' not in self._stubs:
            self._stubs['list_admin_overrides'] = self.grpc_channel.unary_unary(
                '/google.api.serviceusage.v1beta1.ServiceUsage/ListAdminOverrides',
                request_serializer=serviceusage.ListAdminOverridesRequest.serialize,
                response_deserializer=serviceusage.ListAdminOverridesResponse.deserialize,
            )
        return self._stubs['list_admin_overrides']

    @property
    def import_admin_overrides(self) -> Callable[
            [serviceusage.ImportAdminOverridesRequest],
            Awaitable[operations_pb2.Operation]]:
        r"""Return a callable for the import admin overrides method over gRPC.

        Creates or updates multiple admin overrides
        atomically, all on the same consumer, but on many
        different metrics or limits. The name field in the quota
        override message should not be set.

        Returns:
            Callable[[~.ImportAdminOverridesRequest],
                    Awaitable[~.Operation]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'import_admin_overrides' not in self._stubs:
            self._stubs['import_admin_overrides'] = self.grpc_channel.unary_unary(
                '/google.api.serviceusage.v1beta1.ServiceUsage/ImportAdminOverrides',
                request_serializer=serviceusage.ImportAdminOverridesRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['import_admin_overrides']

    @property
    def create_consumer_override(self) -> Callable[
            [serviceusage.CreateConsumerOverrideRequest],
            Awaitable[operations_pb2.Operation]]:
        r"""Return a callable for the create consumer override method over gRPC.

        Creates a consumer override.
        A consumer override is applied to the consumer on its
        own authority to limit its own quota usage. Consumer
        overrides cannot be used to grant more quota than would
        be allowed by admin overrides, producer overrides, or
        the default limit of the service.

        Returns:
            Callable[[~.CreateConsumerOverrideRequest],
                    Awaitable[~.Operation]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'create_consumer_override' not in self._stubs:
            self._stubs['create_consumer_override'] = self.grpc_channel.unary_unary(
                '/google.api.serviceusage.v1beta1.ServiceUsage/CreateConsumerOverride',
                request_serializer=serviceusage.CreateConsumerOverrideRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['create_consumer_override']

    @property
    def update_consumer_override(self) -> Callable[
            [serviceusage.UpdateConsumerOverrideRequest],
            Awaitable[operations_pb2.Operation]]:
        r"""Return a callable for the update consumer override method over gRPC.

        Updates a consumer override.

        Returns:
            Callable[[~.UpdateConsumerOverrideRequest],
                    Awaitable[~.Operation]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update_consumer_override' not in self._stubs:
            self._stubs['update_consumer_override'] = self.grpc_channel.unary_unary(
                '/google.api.serviceusage.v1beta1.ServiceUsage/UpdateConsumerOverride',
                request_serializer=serviceusage.UpdateConsumerOverrideRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['update_consumer_override']

    @property
    def delete_consumer_override(self) -> Callable[
            [serviceusage.DeleteConsumerOverrideRequest],
            Awaitable[operations_pb2.Operation]]:
        r"""Return a callable for the delete consumer override method over gRPC.

        Deletes a consumer override.

        Returns:
            Callable[[~.DeleteConsumerOverrideRequest],
                    Awaitable[~.Operation]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'delete_consumer_override' not in self._stubs:
            self._stubs['delete_consumer_override'] = self.grpc_channel.unary_unary(
                '/google.api.serviceusage.v1beta1.ServiceUsage/DeleteConsumerOverride',
                request_serializer=serviceusage.DeleteConsumerOverrideRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['delete_consumer_override']

    @property
    def list_consumer_overrides(self) -> Callable[
            [serviceusage.ListConsumerOverridesRequest],
            Awaitable[serviceusage.ListConsumerOverridesResponse]]:
        r"""Return a callable for the list consumer overrides method over gRPC.

        Lists all consumer overrides on this limit.

        Returns:
            Callable[[~.ListConsumerOverridesRequest],
                    Awaitable[~.ListConsumerOverridesResponse]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_consumer_overrides' not in self._stubs:
            self._stubs['list_consumer_overrides'] = self.grpc_channel.unary_unary(
                '/google.api.serviceusage.v1beta1.ServiceUsage/ListConsumerOverrides',
                request_serializer=serviceusage.ListConsumerOverridesRequest.serialize,
                response_deserializer=serviceusage.ListConsumerOverridesResponse.deserialize,
            )
        return self._stubs['list_consumer_overrides']

    @property
    def import_consumer_overrides(self) -> Callable[
            [serviceusage.ImportConsumerOverridesRequest],
            Awaitable[operations_pb2.Operation]]:
        r"""Return a callable for the import consumer overrides method over gRPC.

        Creates or updates multiple consumer overrides
        atomically, all on the same consumer, but on many
        different metrics or limits. The name field in the quota
        override message should not be set.

        Returns:
            Callable[[~.ImportConsumerOverridesRequest],
                    Awaitable[~.Operation]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'import_consumer_overrides' not in self._stubs:
            self._stubs['import_consumer_overrides'] = self.grpc_channel.unary_unary(
                '/google.api.serviceusage.v1beta1.ServiceUsage/ImportConsumerOverrides',
                request_serializer=serviceusage.ImportConsumerOverridesRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['import_consumer_overrides']

    @property
    def generate_service_identity(self) -> Callable[
            [serviceusage.GenerateServiceIdentityRequest],
            Awaitable[operations_pb2.Operation]]:
        r"""Return a callable for the generate service identity method over gRPC.

        Generates service identity for service.

        Returns:
            Callable[[~.GenerateServiceIdentityRequest],
                    Awaitable[~.Operation]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'generate_service_identity' not in self._stubs:
            self._stubs['generate_service_identity'] = self.grpc_channel.unary_unary(
                '/google.api.serviceusage.v1beta1.ServiceUsage/GenerateServiceIdentity',
                request_serializer=serviceusage.GenerateServiceIdentityRequest.serialize,
                response_deserializer=operations_pb2.Operation.FromString,
            )
        return self._stubs['generate_service_identity']

    def close(self):
        return self.grpc_channel.close()


__all__ = (
    'ServiceUsageGrpcAsyncIOTransport',
)
