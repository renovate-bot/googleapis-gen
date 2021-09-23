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
from typing import Dict, Optional, Iterable, Sequence, Tuple, Type, Union
import pkg_resources

from google.api_core import client_options as client_options_lib  # type: ignore
from google.api_core import exceptions as core_exceptions         # type: ignore
from google.api_core import gapic_v1                              # type: ignore
from google.api_core import retry as retries                      # type: ignore
from google.auth import credentials as ga_credentials             # type: ignore
from google.auth.transport import mtls                            # type: ignore
from google.auth.transport.grpc import SslCredentials             # type: ignore
from google.auth.exceptions import MutualTLSChannelError          # type: ignore
from google.oauth2 import service_account                         # type: ignore

from google.cloud.osconfig.agentendpoint_v1.types import agentendpoint
from google.cloud.osconfig.agentendpoint_v1.types import inventory as gcoa_inventory
from google.cloud.osconfig.agentendpoint_v1.types import tasks
from .transports.base import AgentEndpointServiceTransport, DEFAULT_CLIENT_INFO
from .transports.grpc import AgentEndpointServiceGrpcTransport
from .transports.grpc_asyncio import AgentEndpointServiceGrpcAsyncIOTransport


class AgentEndpointServiceClientMeta(type):
    """Metaclass for the AgentEndpointService client.

    This provides class-level methods for building and retrieving
    support objects (e.g. transport) without polluting the client instance
    objects.
    """
    _transport_registry = OrderedDict()  # type: Dict[str, Type[AgentEndpointServiceTransport]]
    _transport_registry["grpc"] = AgentEndpointServiceGrpcTransport
    _transport_registry["grpc_asyncio"] = AgentEndpointServiceGrpcAsyncIOTransport

    def get_transport_class(cls,
            label: str = None,
        ) -> Type[AgentEndpointServiceTransport]:
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


class AgentEndpointServiceClient(metaclass=AgentEndpointServiceClientMeta):
    """OS Config agent endpoint API."""

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

    DEFAULT_ENDPOINT = "osconfig.googleapis.com"
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
            AgentEndpointServiceClient: The constructed client.
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
            AgentEndpointServiceClient: The constructed client.
        """
        credentials = service_account.Credentials.from_service_account_file(
            filename)
        kwargs["credentials"] = credentials
        return cls(*args, **kwargs)

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> AgentEndpointServiceTransport:
        """Returns the transport used by the client instance.

        Returns:
            AgentEndpointServiceTransport: The transport used by the client
                instance.
        """
        return self._transport

    @staticmethod
    def os_policy_assignment_path(project: str,location: str,os_policy_assignment: str,) -> str:
        """Returns a fully-qualified os_policy_assignment string."""
        return "projects/{project}/locations/{location}/osPolicyAssignments/{os_policy_assignment}".format(project=project, location=location, os_policy_assignment=os_policy_assignment, )

    @staticmethod
    def parse_os_policy_assignment_path(path: str) -> Dict[str,str]:
        """Parses a os_policy_assignment path into its component segments."""
        m = re.match(r"^projects/(?P<project>.+?)/locations/(?P<location>.+?)/osPolicyAssignments/(?P<os_policy_assignment>.+?)$", path)
        return m.groupdict() if m else {}

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
            transport: Union[str, AgentEndpointServiceTransport, None] = None,
            client_options: Optional[client_options_lib.ClientOptions] = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiates the agent endpoint service client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, AgentEndpointServiceTransport]): The
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
        if isinstance(transport, AgentEndpointServiceTransport):
            # transport is a AgentEndpointServiceTransport instance.
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
                always_use_jwt_access=(
                    Transport == type(self).get_transport_class("grpc")
                    or Transport == type(self).get_transport_class("grpc_asyncio")
                ),
            )

    def receive_task_notification(self,
            request: Union[agentendpoint.ReceiveTaskNotificationRequest, dict] = None,
            *,
            instance_id_token: str = None,
            agent_version: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> Iterable[agentendpoint.ReceiveTaskNotificationResponse]:
        r"""Stream established by client to receive Task
        notifications.

        Args:
            request (Union[google.cloud.osconfig.agentendpoint_v1.types.ReceiveTaskNotificationRequest, dict]):
                The request object. A request message to receive task
                notifications.
            instance_id_token (str):
                Required. This is the Compute Engine
                instance identity token described in
                https://cloud.google.com/compute/docs/instances/verifying-
                instance-identity where the audience is
                'osconfig.googleapis.com' and the format
                is 'full'.

                This corresponds to the ``instance_id_token`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            agent_version (str):
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
            Iterable[google.cloud.osconfig.agentendpoint_v1.types.ReceiveTaskNotificationResponse]:
                The streaming rpc message that will
                notify the agent when it has a task it
                needs to perform on the instance.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([instance_id_token, agent_version])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a agentendpoint.ReceiveTaskNotificationRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, agentendpoint.ReceiveTaskNotificationRequest):
            request = agentendpoint.ReceiveTaskNotificationRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if instance_id_token is not None:
                request.instance_id_token = instance_id_token
            if agent_version is not None:
                request.agent_version = agent_version

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.receive_task_notification]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def start_next_task(self,
            request: Union[agentendpoint.StartNextTaskRequest, dict] = None,
            *,
            instance_id_token: str = None,
            retry: retries.Retry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> agentendpoint.StartNextTaskResponse:
        r"""Signals the start of a task execution and returns the
        task info.

        Args:
            request (Union[google.cloud.osconfig.agentendpoint_v1.types.StartNextTaskRequest, dict]):
                The request object. A request message for signaling the
                start of a task execution.
            instance_id_token (str):
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
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a agentendpoint.StartNextTaskRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, agentendpoint.StartNextTaskRequest):
            request = agentendpoint.StartNextTaskRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if instance_id_token is not None:
                request.instance_id_token = instance_id_token

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.start_next_task]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def report_task_progress(self,
            request: Union[agentendpoint.ReportTaskProgressRequest, dict] = None,
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
            request (Union[google.cloud.osconfig.agentendpoint_v1.types.ReportTaskProgressRequest, dict]):
                The request object. A request message for reporting the
                progress of current task.
            instance_id_token (str):
                Required. This is the Compute Engine
                instance identity token described in
                https://cloud.google.com/compute/docs/instances/verifying-
                instance-identity where the audience is
                'osconfig.googleapis.com' and the format
                is 'full'.

                This corresponds to the ``instance_id_token`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            task_id (str):
                Required. Unique identifier of the
                task this applies to.

                This corresponds to the ``task_id`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            task_type (google.cloud.osconfig.agentendpoint_v1.types.TaskType):
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
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a agentendpoint.ReportTaskProgressRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, agentendpoint.ReportTaskProgressRequest):
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
        rpc = self._transport._wrapped_methods[self._transport.report_task_progress]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def report_task_complete(self,
            request: Union[agentendpoint.ReportTaskCompleteRequest, dict] = None,
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
            request (Union[google.cloud.osconfig.agentendpoint_v1.types.ReportTaskCompleteRequest, dict]):
                The request object. A request message for signaling the
                completion of a task execution.
            instance_id_token (str):
                Required. This is the Compute Engine
                instance identity token described in
                https://cloud.google.com/compute/docs/instances/verifying-
                instance-identity where the audience is
                'osconfig.googleapis.com' and the format
                is 'full'.

                This corresponds to the ``instance_id_token`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            task_id (str):
                Required. Unique identifier of the
                task this applies to.

                This corresponds to the ``task_id`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            task_type (google.cloud.osconfig.agentendpoint_v1.types.TaskType):
                Required. The type of task to report completed.

                Output must include the appropriate message based on
                this enum as specified below: APPLY_PATCHES =
                ApplyPatchesTaskOutput EXEC_STEP = ExecStepTaskOutput
                APPLY_CONFIG_TASK = ApplyConfigTaskOutput

                This corresponds to the ``task_type`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            error_message (str):
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
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a agentendpoint.ReportTaskCompleteRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, agentendpoint.ReportTaskCompleteRequest):
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
        rpc = self._transport._wrapped_methods[self._transport.report_task_complete]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def register_agent(self,
            request: Union[agentendpoint.RegisterAgentRequest, dict] = None,
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
            request (Union[google.cloud.osconfig.agentendpoint_v1.types.RegisterAgentRequest, dict]):
                The request object. The request message for registering
                the agent.
            instance_id_token (str):
                Required. This is the Compute Engine
                instance identity token described in
                https://cloud.google.com/compute/docs/instances/verifying-
                instance-identity where the audience is
                'osconfig.googleapis.com' and the format
                is 'full'.

                This corresponds to the ``instance_id_token`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            agent_version (str):
                Required. The version of the agent.
                This corresponds to the ``agent_version`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            supported_capabilities (Sequence[str]):
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
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a agentendpoint.RegisterAgentRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, agentendpoint.RegisterAgentRequest):
            request = agentendpoint.RegisterAgentRequest(request)
            # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if instance_id_token is not None:
                request.instance_id_token = instance_id_token
            if agent_version is not None:
                request.agent_version = agent_version
            if supported_capabilities is not None:
                request.supported_capabilities = supported_capabilities

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.register_agent]

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def report_inventory(self,
            request: Union[agentendpoint.ReportInventoryRequest, dict] = None,
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
            request (Union[google.cloud.osconfig.agentendpoint_v1.types.ReportInventoryRequest, dict]):
                The request object. The request message for having the
                agent report inventory.
            instance_id_token (str):
                Required. This is the Compute Engine
                instance identity token described in
                https://cloud.google.com/compute/docs/instances/verifying-
                instance-identity where the audience is
                'osconfig.googleapis.com' and the format
                is 'full'.

                This corresponds to the ``instance_id_token`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            inventory_checksum (str):
                Required. This is a client created
                checksum that should be generated based
                on the contents of the reported
                inventory.  This will be used by the
                service to determine if it has the
                latest version of inventory.

                This corresponds to the ``inventory_checksum`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            inventory (google.cloud.osconfig.agentendpoint_v1.types.Inventory):
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
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a agentendpoint.ReportInventoryRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, agentendpoint.ReportInventoryRequest):
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
        rpc = self._transport._wrapped_methods[self._transport.report_inventory]

        # Send the request.
        response = rpc(
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
    "AgentEndpointServiceClient",
)
