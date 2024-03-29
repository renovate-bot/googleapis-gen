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
from typing import Dict, AsyncIterable, Awaitable, Sequence, Tuple, Type, Union
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

from google.cloud.osconfig.agentendpoint_v1beta.types import agentendpoint
from google.cloud.osconfig.agentendpoint_v1beta.types import guest_policies
from google.cloud.osconfig.agentendpoint_v1beta.types import tasks
from .transports.base import AgentEndpointServiceTransport, DEFAULT_CLIENT_INFO
from .transports.grpc_asyncio import AgentEndpointServiceGrpcAsyncIOTransport
from .client import AgentEndpointServiceClient


class AgentEndpointServiceAsyncClient:
    """OS Config agent endpoint API."""

    _client: AgentEndpointServiceClient

    DEFAULT_ENDPOINT = AgentEndpointServiceClient.DEFAULT_ENDPOINT
    DEFAULT_MTLS_ENDPOINT = AgentEndpointServiceClient.DEFAULT_MTLS_ENDPOINT

    common_billing_account_path = staticmethod(AgentEndpointServiceClient.common_billing_account_path)
    parse_common_billing_account_path = staticmethod(AgentEndpointServiceClient.parse_common_billing_account_path)
    common_folder_path = staticmethod(AgentEndpointServiceClient.common_folder_path)
    parse_common_folder_path = staticmethod(AgentEndpointServiceClient.parse_common_folder_path)
    common_organization_path = staticmethod(AgentEndpointServiceClient.common_organization_path)
    parse_common_organization_path = staticmethod(AgentEndpointServiceClient.parse_common_organization_path)
    common_project_path = staticmethod(AgentEndpointServiceClient.common_project_path)
    parse_common_project_path = staticmethod(AgentEndpointServiceClient.parse_common_project_path)
    common_location_path = staticmethod(AgentEndpointServiceClient.common_location_path)
    parse_common_location_path = staticmethod(AgentEndpointServiceClient.parse_common_location_path)

    @classmethod
    def from_service_account_info(cls, info: dict, *args, **kwargs):
        """Creates an instance of this client using the provided credentials
            info.

        Args:
            info (dict): The service account private key info.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            AgentEndpointServiceAsyncClient: The constructed client.
        """
        return AgentEndpointServiceClient.from_service_account_info.__func__(AgentEndpointServiceAsyncClient, info, *args, **kwargs)  # type: ignore

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
            AgentEndpointServiceAsyncClient: The constructed client.
        """
        return AgentEndpointServiceClient.from_service_account_file.__func__(AgentEndpointServiceAsyncClient, filename, *args, **kwargs)  # type: ignore

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> AgentEndpointServiceTransport:
        """Returns the transport used by the client instance.

        Returns:
            AgentEndpointServiceTransport: The transport used by the client instance.
        """
        return self._client.transport

    get_transport_class = functools.partial(type(AgentEndpointServiceClient).get_transport_class, type(AgentEndpointServiceClient))

    def __init__(self, *,
            credentials: ga_credentials.Credentials = None,
            transport: Union[str, AgentEndpointServiceTransport] = "grpc_asyncio",
            client_options: ClientOptions = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiates the agent endpoint service client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, ~.AgentEndpointServiceTransport]): The
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
        self._client = AgentEndpointServiceClient(
            credentials=credentials,
            transport=transport,
            client_options=client_options,
            client_info=client_info,

        )

    def receive_task_notification(self,
            request: Union[agentendpoint.ReceiveTaskNotificationRequest, dict] = None,
            *,
            instance_id_token: str = None,
            agent_version: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> Awaitable[AsyncIterable[agentendpoint.ReceiveTaskNotificationResponse]]:
        r"""Stream established by client to receive Task
        notifications.

        Args:
            request (Union[google.cloud.osconfig.agentendpoint_v1beta.types.ReceiveTaskNotificationRequest, dict]):
                The request object. A request message to receive task
                notifications.
            instance_id_token (:class:`str`):
                Required. This is the Compute Engine
                instance identity token described in
                https://cloud.google.com/compute/docs/instances/verifying-
                instance-identity where the audience is
                'osconfig.googleapis.com' and the format
                is 'full'.

                This corresponds to the ``instance_id_token`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            agent_version (:class:`str`):
                Required. The version of the agent
                making the request.

                This corresponds to the ``agent_version`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            AsyncIterable[google.cloud.osconfig.agentendpoint_v1beta.types.ReceiveTaskNotificationResponse]:
                The streaming rpc message that
                notifies the agent when it has a task
                that it needs to perform on the VM
                instance.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([instance_id_token, agent_version])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = agentendpoint.ReceiveTaskNotificationRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if instance_id_token is not None:
            request.instance_id_token = instance_id_token
        if agent_version is not None:
            request.agent_version = agent_version

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.receive_task_notification,
            default_retry=retries.Retry(
initial=1.0,maximum=60.0,multiplier=1.3,                predicate=retries.if_exception_type(
                    core_exceptions.Aborted,
                    core_exceptions.Cancelled,
                    core_exceptions.DeadlineExceeded,
                    core_exceptions.InternalServerError,
                    core_exceptions.ServiceUnavailable,
                ),
                deadline=3600.0,
            ),
            default_timeout=3600.0,
            client_info=DEFAULT_CLIENT_INFO,
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

    async def start_next_task(self,
            request: Union[agentendpoint.StartNextTaskRequest, dict] = None,
            *,
            instance_id_token: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> agentendpoint.StartNextTaskResponse:
        r"""Signals the start of a task execution and returns the
        task info.

        Args:
            request (Union[google.cloud.osconfig.agentendpoint_v1beta.types.StartNextTaskRequest, dict]):
                The request object. A request message for signaling the
                start of a task execution.
            instance_id_token (:class:`str`):
                Required. This is the Compute Engine
                instance identity token described in
                https://cloud.google.com/compute/docs/instances/verifying-
                instance-identity where the audience is
                'osconfig.googleapis.com' and the format
                is 'full'.

                This corresponds to the ``instance_id_token`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.osconfig.agentendpoint_v1beta.types.StartNextTaskResponse:
                A response message that contains the
                details of the task to work on.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([instance_id_token])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = agentendpoint.StartNextTaskRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if instance_id_token is not None:
            request.instance_id_token = instance_id_token

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.start_next_task,
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

        # Done; return the response.
        return response

    async def report_task_progress(self,
            request: Union[agentendpoint.ReportTaskProgressRequest, dict] = None,
            *,
            instance_id_token: str = None,
            task_id: str = None,
            task_type: tasks.TaskType = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> agentendpoint.ReportTaskProgressResponse:
        r"""Signals an intermediary progress checkpoint in task
        execution.

        Args:
            request (Union[google.cloud.osconfig.agentendpoint_v1beta.types.ReportTaskProgressRequest, dict]):
                The request object. A request message for reporting the
                progress of current task.
            instance_id_token (:class:`str`):
                Required. This is the Compute Engine
                instance identity token described in
                https://cloud.google.com/compute/docs/instances/verifying-
                instance-identity where the audience is
                'osconfig.googleapis.com' and the format
                is 'full'.

                This corresponds to the ``instance_id_token`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            task_id (:class:`str`):
                Required. Unique identifier of the
                task this applies to.

                This corresponds to the ``task_id`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            task_type (:class:`google.cloud.osconfig.agentendpoint_v1beta.types.TaskType`):
                Required. The type of task to report progress on.

                Progress must include the appropriate message based on
                this enum as specified below: APPLY_PATCHES =
                ApplyPatchesTaskProgress EXEC_STEP = Progress not
                supported for this type.

                This corresponds to the ``task_type`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.osconfig.agentendpoint_v1beta.types.ReportTaskProgressResponse:
                The response message after the agent
                reported the current task progress.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([instance_id_token, task_id, task_type])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = agentendpoint.ReportTaskProgressRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if instance_id_token is not None:
            request.instance_id_token = instance_id_token
        if task_id is not None:
            request.task_id = task_id
        if task_type is not None:
            request.task_type = task_type

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.report_task_progress,
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

        # Done; return the response.
        return response

    async def report_task_complete(self,
            request: Union[agentendpoint.ReportTaskCompleteRequest, dict] = None,
            *,
            instance_id_token: str = None,
            task_id: str = None,
            task_type: tasks.TaskType = None,
            error_message: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> agentendpoint.ReportTaskCompleteResponse:
        r"""Signals that the task execution is complete and
        optionally returns the next task.

        Args:
            request (Union[google.cloud.osconfig.agentendpoint_v1beta.types.ReportTaskCompleteRequest, dict]):
                The request object. A request message for signaling the
                completion of a task execution.
            instance_id_token (:class:`str`):
                Required. This is the Compute Engine
                instance identity token described in
                https://cloud.google.com/compute/docs/instances/verifying-
                instance-identity where the audience is
                'osconfig.googleapis.com' and the format
                is 'full'.

                This corresponds to the ``instance_id_token`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            task_id (:class:`str`):
                Required. Unique identifier of the
                task this applies to.

                This corresponds to the ``task_id`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            task_type (:class:`google.cloud.osconfig.agentendpoint_v1beta.types.TaskType`):
                Required. The type of task to report completed.

                The output must include the appropriate message based on
                the following enum values: APPLY_PATCHES =
                ApplyPatchesTaskOutput EXEC_STEP = ExecStepTaskOutput

                This corresponds to the ``task_type`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            error_message (:class:`str`):
                Descriptive error message if the task
                execution ended in error.

                This corresponds to the ``error_message`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.osconfig.agentendpoint_v1beta.types.ReportTaskCompleteResponse:
                The response message after the agent
                signaled the current task complete.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([instance_id_token, task_id, task_type, error_message])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = agentendpoint.ReportTaskCompleteRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if instance_id_token is not None:
            request.instance_id_token = instance_id_token
        if task_id is not None:
            request.task_id = task_id
        if task_type is not None:
            request.task_type = task_type
        if error_message is not None:
            request.error_message = error_message

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.report_task_complete,
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

        # Done; return the response.
        return response

    async def lookup_effective_guest_policy(self,
            request: Union[guest_policies.LookupEffectiveGuestPolicyRequest, dict] = None,
            *,
            instance_id_token: str = None,
            os_short_name: str = None,
            os_version: str = None,
            os_architecture: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> guest_policies.EffectiveGuestPolicy:
        r"""Lookup the effective guest policy that applies to a
        VM instance. This lookup merges all policies that are
        assigned to the instance ancestry.

        Args:
            request (Union[google.cloud.osconfig.agentendpoint_v1beta.types.LookupEffectiveGuestPolicyRequest, dict]):
                The request object. A request message for getting
                effective policy assigned to the instance.
            instance_id_token (:class:`str`):
                Required. This is the GCE instance
                identity token described in
                https://cloud.google.com/compute/docs/instances/verifying-
                instance-identity where the audience is
                'osconfig.googleapis.com' and the format
                is 'full'.

                This corresponds to the ``instance_id_token`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            os_short_name (:class:`str`):
                Short name of the OS running on the
                instance. The OS Config agent only
                provideS this field for targeting if OS
                Inventory is enabled for that instance.

                This corresponds to the ``os_short_name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            os_version (:class:`str`):
                Version of the OS running on the
                instance. The OS Config agent only
                provide this field for targeting if OS
                Inventory is enabled for that VM
                instance.

                This corresponds to the ``os_version`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            os_architecture (:class:`str`):
                Architecture of OS running on the
                instance. The OS Config agent only
                provide this field for targeting if OS
                Inventory is enabled for that instance.

                This corresponds to the ``os_architecture`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.osconfig.agentendpoint_v1beta.types.EffectiveGuestPolicy:
                The effective guest policy assigned
                to the instance.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([instance_id_token, os_short_name, os_version, os_architecture])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = guest_policies.LookupEffectiveGuestPolicyRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if instance_id_token is not None:
            request.instance_id_token = instance_id_token
        if os_short_name is not None:
            request.os_short_name = os_short_name
        if os_version is not None:
            request.os_version = os_version
        if os_architecture is not None:
            request.os_architecture = os_architecture

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.lookup_effective_guest_policy,
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

        # Done; return the response.
        return response

    async def register_agent(self,
            request: Union[agentendpoint.RegisterAgentRequest, dict] = None,
            *,
            instance_id_token: str = None,
            agent_version: str = None,
            supported_capabilities: Sequence[str] = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> agentendpoint.RegisterAgentResponse:
        r"""Registers the agent running on the VM.

        Args:
            request (Union[google.cloud.osconfig.agentendpoint_v1beta.types.RegisterAgentRequest, dict]):
                The request object. The request message for registering
                the agent.
            instance_id_token (:class:`str`):
                Required. This is the Compute Engine
                instance identity token described in
                https://cloud.google.com/compute/docs/instances/verifying-
                instance-identity where the audience is
                'osconfig.googleapis.com' and the format
                is 'full'.

                This corresponds to the ``instance_id_token`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            agent_version (:class:`str`):
                Required. The version of the agent.
                This corresponds to the ``agent_version`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            supported_capabilities (:class:`Sequence[str]`):
                Required. The capabilities supported by the agent.
                Supported values are: PATCH_GA GUEST_POLICY_BETA

                This corresponds to the ``supported_capabilities`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.osconfig.agentendpoint_v1beta.types.RegisterAgentResponse:
                The response message after the agent
                registered.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([instance_id_token, agent_version, supported_capabilities])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = agentendpoint.RegisterAgentRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if instance_id_token is not None:
            request.instance_id_token = instance_id_token
        if agent_version is not None:
            request.agent_version = agent_version
        if supported_capabilities:
            request.supported_capabilities.extend(supported_capabilities)

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.register_agent,
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

        # Done; return the response.
        return response

    async def __aenter__(self):
        return self

    async def __aexit__(self, exc_type, exc, tb):
        await self.transport.close()

try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            "google-cloud-osconfig-agentendpoint",
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    "AgentEndpointServiceAsyncClient",
)
