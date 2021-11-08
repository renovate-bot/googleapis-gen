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
from typing import Callable, Dict, Optional, Sequence, Tuple, Union

from google.api_core import grpc_helpers
from google.api_core import gapic_v1
import google.auth                         # type: ignore
from google.auth import credentials as ga_credentials  # type: ignore
from google.auth.transport.grpc import SslCredentials  # type: ignore

import grpc  # type: ignore

from google.cloud.osconfig.agentendpoint_v1beta.types import agentendpoint
from google.cloud.osconfig.agentendpoint_v1beta.types import guest_policies
from .base import AgentEndpointServiceTransport, DEFAULT_CLIENT_INFO


class AgentEndpointServiceGrpcTransport(AgentEndpointServiceTransport):
    """gRPC backend transport for AgentEndpointService.

    OS Config agent endpoint API.

    This class defines the same methods as the primary client, so the
    primary client can load the underlying transport implementation
    and call it.

    It sends protocol buffers over the wire using gRPC (which is built on
    top of HTTP/2); the ``grpcio`` package must be installed.
    """
    _stubs: Dict[str, Callable]

    def __init__(self, *,
            host: str = 'osconfig.googleapis.com',
            credentials: ga_credentials.Credentials = None,
            credentials_file: str = None,
            scopes: Sequence[str] = None,
            channel: grpc.Channel = None,
            api_mtls_endpoint: str = None,
            client_cert_source: Callable[[], Tuple[bytes, bytes]] = None,
            ssl_channel_credentials: grpc.ChannelCredentials = None,
            client_cert_source_for_mtls: Callable[[], Tuple[bytes, bytes]] = None,
            quota_project_id: Optional[str] = None,
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
            scopes (Optional(Sequence[str])): A list of scopes. This argument is
                ignored if ``channel`` is provided.
            channel (Optional[grpc.Channel]): A ``Channel`` instance through
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
          google.auth.exceptions.MutualTLSChannelError: If mutual TLS transport
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

    @classmethod
    def create_channel(cls,
                       host: str = 'osconfig.googleapis.com',
                       credentials: ga_credentials.Credentials = None,
                       credentials_file: str = None,
                       scopes: Optional[Sequence[str]] = None,
                       quota_project_id: Optional[str] = None,
                       **kwargs) -> grpc.Channel:
        """Create and return a gRPC channel object.
        Args:
            host (Optional[str]): The host for the channel to use.
            credentials (Optional[~.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify this application to the service. If
                none are specified, the client will attempt to ascertain
                the credentials from the environment.
            credentials_file (Optional[str]): A file with credentials that can
                be loaded with :func:`google.auth.load_credentials_from_file`.
                This argument is mutually exclusive with credentials.
            scopes (Optional[Sequence[str]]): A optional list of scopes needed for this
                service. These are only used when credentials are not specified and
                are passed to :func:`google.auth.default`.
            quota_project_id (Optional[str]): An optional project to use for billing
                and quota.
            kwargs (Optional[dict]): Keyword arguments, which are passed to the
                channel creation.
        Returns:
            grpc.Channel: A gRPC channel object.

        Raises:
            google.api_core.exceptions.DuplicateCredentialArgs: If both ``credentials``
              and ``credentials_file`` are passed.
        """

        return grpc_helpers.create_channel(
            host,
            credentials=credentials,
            credentials_file=credentials_file,
            quota_project_id=quota_project_id,
            default_scopes=cls.AUTH_SCOPES,
            scopes=scopes,
            default_host=cls.DEFAULT_HOST,
            **kwargs
        )

    @property
    def grpc_channel(self) -> grpc.Channel:
        """Return the channel designed to connect to this service.
        """
        return self._grpc_channel

    @property
    def receive_task_notification(self) -> Callable[
            [agentendpoint.ReceiveTaskNotificationRequest],
            agentendpoint.ReceiveTaskNotificationResponse]:
        r"""Return a callable for the receive task notification method over gRPC.

        Stream established by client to receive Task
        notifications.

        Returns:
            Callable[[~.ReceiveTaskNotificationRequest],
                    ~.ReceiveTaskNotificationResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'receive_task_notification' not in self._stubs:
            self._stubs['receive_task_notification'] = self.grpc_channel.unary_stream(
                '/google.cloud.osconfig.agentendpoint.v1beta.AgentEndpointService/ReceiveTaskNotification',
                request_serializer=agentendpoint.ReceiveTaskNotificationRequest.serialize,
                response_deserializer=agentendpoint.ReceiveTaskNotificationResponse.deserialize,
            )
        return self._stubs['receive_task_notification']

    @property
    def start_next_task(self) -> Callable[
            [agentendpoint.StartNextTaskRequest],
            agentendpoint.StartNextTaskResponse]:
        r"""Return a callable for the start next task method over gRPC.

        Signals the start of a task execution and returns the
        task info.

        Returns:
            Callable[[~.StartNextTaskRequest],
                    ~.StartNextTaskResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'start_next_task' not in self._stubs:
            self._stubs['start_next_task'] = self.grpc_channel.unary_unary(
                '/google.cloud.osconfig.agentendpoint.v1beta.AgentEndpointService/StartNextTask',
                request_serializer=agentendpoint.StartNextTaskRequest.serialize,
                response_deserializer=agentendpoint.StartNextTaskResponse.deserialize,
            )
        return self._stubs['start_next_task']

    @property
    def report_task_progress(self) -> Callable[
            [agentendpoint.ReportTaskProgressRequest],
            agentendpoint.ReportTaskProgressResponse]:
        r"""Return a callable for the report task progress method over gRPC.

        Signals an intermediary progress checkpoint in task
        execution.

        Returns:
            Callable[[~.ReportTaskProgressRequest],
                    ~.ReportTaskProgressResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'report_task_progress' not in self._stubs:
            self._stubs['report_task_progress'] = self.grpc_channel.unary_unary(
                '/google.cloud.osconfig.agentendpoint.v1beta.AgentEndpointService/ReportTaskProgress',
                request_serializer=agentendpoint.ReportTaskProgressRequest.serialize,
                response_deserializer=agentendpoint.ReportTaskProgressResponse.deserialize,
            )
        return self._stubs['report_task_progress']

    @property
    def report_task_complete(self) -> Callable[
            [agentendpoint.ReportTaskCompleteRequest],
            agentendpoint.ReportTaskCompleteResponse]:
        r"""Return a callable for the report task complete method over gRPC.

        Signals that the task execution is complete and
        optionally returns the next task.

        Returns:
            Callable[[~.ReportTaskCompleteRequest],
                    ~.ReportTaskCompleteResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'report_task_complete' not in self._stubs:
            self._stubs['report_task_complete'] = self.grpc_channel.unary_unary(
                '/google.cloud.osconfig.agentendpoint.v1beta.AgentEndpointService/ReportTaskComplete',
                request_serializer=agentendpoint.ReportTaskCompleteRequest.serialize,
                response_deserializer=agentendpoint.ReportTaskCompleteResponse.deserialize,
            )
        return self._stubs['report_task_complete']

    @property
    def lookup_effective_guest_policy(self) -> Callable[
            [guest_policies.LookupEffectiveGuestPolicyRequest],
            guest_policies.EffectiveGuestPolicy]:
        r"""Return a callable for the lookup effective guest policy method over gRPC.

        Lookup the effective guest policy that applies to a
        VM instance. This lookup merges all policies that are
        assigned to the instance ancestry.

        Returns:
            Callable[[~.LookupEffectiveGuestPolicyRequest],
                    ~.EffectiveGuestPolicy]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'lookup_effective_guest_policy' not in self._stubs:
            self._stubs['lookup_effective_guest_policy'] = self.grpc_channel.unary_unary(
                '/google.cloud.osconfig.agentendpoint.v1beta.AgentEndpointService/LookupEffectiveGuestPolicy',
                request_serializer=guest_policies.LookupEffectiveGuestPolicyRequest.serialize,
                response_deserializer=guest_policies.EffectiveGuestPolicy.deserialize,
            )
        return self._stubs['lookup_effective_guest_policy']

    @property
    def register_agent(self) -> Callable[
            [agentendpoint.RegisterAgentRequest],
            agentendpoint.RegisterAgentResponse]:
        r"""Return a callable for the register agent method over gRPC.

        Registers the agent running on the VM.

        Returns:
            Callable[[~.RegisterAgentRequest],
                    ~.RegisterAgentResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'register_agent' not in self._stubs:
            self._stubs['register_agent'] = self.grpc_channel.unary_unary(
                '/google.cloud.osconfig.agentendpoint.v1beta.AgentEndpointService/RegisterAgent',
                request_serializer=agentendpoint.RegisterAgentRequest.serialize,
                response_deserializer=agentendpoint.RegisterAgentResponse.deserialize,
            )
        return self._stubs['register_agent']

    def close(self):
        self.grpc_channel.close()

__all__ = (
    'AgentEndpointServiceGrpcTransport',
)
