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

import google.api_core.client_options as ClientOptions # type: ignore
from google.api_core import exceptions as core_exceptions  # type: ignore
from google.api_core import gapic_v1                   # type: ignore
from google.api_core import retry as retries           # type: ignore
from google.auth import credentials as ga_credentials   # type: ignore
from google.oauth2 import service_account              # type: ignore

from google.cloud.osconfig.agentendpoint_v1.types import agentendpoint
from google.cloud.osconfig.agentendpoint_v1.types import inventory as gcoa_inventory
from google.cloud.osconfig.agentendpoint_v1.types import tasks
from .transports.base import AgentEndpointServiceTransport, DEFAULT_CLIENT_INFO
from .transports.grpc_asyncio import AgentEndpointServiceGrpcAsyncIOTransport
from .client import AgentEndpointServiceClient


class AgentEndpointServiceAsyncClient:
    """OS Config agent endpoint API."""

    _client: AgentEndpointServiceClient

    DEFAULT_ENDPOINT = AgentEndpointServiceClient.DEFAULT_ENDPOINT
    DEFAULT_MTLS_ENDPOINT = AgentEndpointServiceClient.DEFAULT_MTLS_ENDPOINT

    os_policy_assignment_path = staticmethod(AgentEndpointServiceClient.os_policy_assignment_path)
    parse_os_policy_assignment_path = staticmethod(AgentEndpointServiceClient.parse_os_policy_assignment_path)
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
            request: agentendpoint.ReceiveTaskNotificationRequest = None,
            *,
            instance_id_token: str = None,
            agent_version: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> Awaitable[AsyncIterable[agentendpoint.ReceiveTaskNotificationResponse]]:
        r"""Stream established by client to receive Task
        notifications.

        Args:
            request (:class:`google.cloud.osconfig.agentendpoint_v1.types.ReceiveTaskNotificationRequest`):
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
            AsyncIterable[google.cloud.osconfig.agentendpoint_v1.types.ReceiveTaskNotificationResponse]:
                The streaming rpc message that will
                notify the agent when it has a task it
                needs to perform on the instance.

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
            request: agentendpoint.StartNextTaskRequest = None,
            *,
            instance_id_token: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> agentendpoint.StartNextTaskResponse:
        r"""Signals the start of a task execution and returns the
        task info.

        Args:
            request (:class:`google.cloud.osconfig.agentendpoint_v1.types.StartNextTaskRequest`):
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
            google.cloud.osconfig.agentendpoint_v1.types.StartNextTaskResponse:
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
            request: agentendpoint.ReportTaskProgressRequest = None,
            *,
            instance_id_token: str = None,
            task_id: str = None,
            task_type: tasks.TaskType = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> agentendpoint.ReportTaskProgressResponse:
        r"""Signals an intermediary progress checkpoint in task
        execution.

        Args:
            request (:class:`google.cloud.osconfig.agentendpoint_v1.types.ReportTaskProgressRequest`):
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
            task_type (:class:`google.cloud.osconfig.agentendpoint_v1.types.TaskType`):
                Required. The type of task to report progress on.

                Progress must include the appropriate message based on
                this enum as specified below: APPLY_PATCHES =
                ApplyPatchesTaskProgress EXEC_STEP = Progress not
                supported for this type. APPLY_CONFIG_TASK =
                ApplyConfigTaskProgress

                This corresponds to the ``task_type`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.osconfig.agentendpoint_v1.types.ReportTaskProgressResponse:
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
            request: agentendpoint.ReportTaskCompleteRequest = None,
            *,
            instance_id_token: str = None,
            task_id: str = None,
            task_type: tasks.TaskType = None,
            error_message: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> agentendpoint.ReportTaskCompleteResponse:
        r"""Signals that the task execution is complete and
        optionally returns the next task.

        Args:
            request (:class:`google.cloud.osconfig.agentendpoint_v1.types.ReportTaskCompleteRequest`):
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
            task_type (:class:`google.cloud.osconfig.agentendpoint_v1.types.TaskType`):
                Required. The type of task to report completed.

                Output must include the appropriate message based on
                this enum as specified below: APPLY_PATCHES =
                ApplyPatchesTaskOutput EXEC_STEP = ExecStepTaskOutput
                APPLY_CONFIG_TASK = ApplyConfigTaskOutput

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
            google.cloud.osconfig.agentendpoint_v1.types.ReportTaskCompleteResponse:
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

    async def register_agent(self,
            request: agentendpoint.RegisterAgentRequest = None,
            *,
            instance_id_token: str = None,
            agent_version: str = None,
            supported_capabilities: Sequence[str] = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> agentendpoint.RegisterAgentResponse:
        r"""Registers the agent running on the VM.

        Args:
            request (:class:`google.cloud.osconfig.agentendpoint_v1.types.RegisterAgentRequest`):
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
                CONFIG_V1

                This corresponds to the ``supported_capabilities`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.osconfig.agentendpoint_v1.types.RegisterAgentResponse:
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

    async def report_inventory(self,
            request: agentendpoint.ReportInventoryRequest = None,
            *,
            instance_id_token: str = None,
            inventory_checksum: str = None,
            inventory: gcoa_inventory.Inventory = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> agentendpoint.ReportInventoryResponse:
        r"""Reports the VMs current inventory.

        Args:
            request (:class:`google.cloud.osconfig.agentendpoint_v1.types.ReportInventoryRequest`):
                The request object. The request message for having the
                agent report inventory.
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
            inventory_checksum (:class:`str`):
                Required. This is a client created
                checksum that should be generated based
                on the contents of the reported
                inventory.  This will be used by the
                service to determine if it has the
                latest version of inventory.

                This corresponds to the ``inventory_checksum`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            inventory (:class:`google.cloud.osconfig.agentendpoint_v1.types.Inventory`):
                Optional. This is the details of the
                inventory.  Should only be provided if
                the inventory has changed since the last
                report, or if instructed by the service
                to provide full inventory.

                This corresponds to the ``inventory`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.cloud.osconfig.agentendpoint_v1.types.ReportInventoryResponse:
                The response message after the agent
                has reported inventory.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([instance_id_token, inventory_checksum, inventory])
        if request is not None and has_flattened_params:
            raise ValueError("If the `request` argument is set, then none of "
                             "the individual field arguments should be set.")

        request = agentendpoint.ReportInventoryRequest(request)

        # If we have keyword arguments corresponding to fields on the
        # request, apply these.
        if instance_id_token is not None:
            request.instance_id_token = instance_id_token
        if inventory_checksum is not None:
            request.inventory_checksum = inventory_checksum
        if inventory is not None:
            request.inventory = inventory

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = gapic_v1.method_async.wrap_method(
            self._client._transport.report_inventory,
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
