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

import abc
import typing
import pkg_resources

from google import auth  # type: ignore
from google.api_core import exceptions  # type: ignore
from google.api_core import gapic_v1    # type: ignore
from google.api_core import retry as retries  # type: ignore
from google.api_core import operations_v1  # type: ignore
from google.auth import credentials  # type: ignore

from google.cloud.tpu_v1.types import cloud_tpu
from google.longrunning import operations_pb2 as operations  # type: ignore


try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            'google-cloud-tpu',
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()

class TpuTransport(abc.ABC):
    """Abstract transport class for Tpu."""

    AUTH_SCOPES = (
        'https://www.googleapis.com/auth/cloud-platform',
    )

    def __init__(
            self, *,
            host: str = 'tpu.googleapis.com',
            credentials: credentials.Credentials = None,
            credentials_file: typing.Optional[str] = None,
            scopes: typing.Optional[typing.Sequence[str]] = AUTH_SCOPES,
            quota_project_id: typing.Optional[str] = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            **kwargs,
            ) -> None:
        """Instantiate the transport.

        Args:
            host (Optional[str]): The hostname to connect to.
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            credentials_file (Optional[str]): A file with credentials that can
                be loaded with :func:`google.auth.load_credentials_from_file`.
                This argument is mutually exclusive with credentials.
            scope (Optional[Sequence[str]]): A list of scopes.
            quota_project_id (Optional[str]): An optional project to use for billing
                and quota.
            client_info (google.api_core.gapic_v1.client_info.ClientInfo):
                The client info used to send a user-agent string along with
                API requests. If ``None``, then default info will be used.
                Generally, you only need to set this if you're developing
                your own client library.
        """
        # Save the hostname. Default to port 443 (HTTPS) if none is specified.
        if ':' not in host:
            host += ':443'
        self._host = host

        # Save the scopes.
        self._scopes = scopes or self.AUTH_SCOPES

        # If no credentials are provided, then determine the appropriate
        # defaults.
        if credentials and credentials_file:
            raise exceptions.DuplicateCredentialArgs("'credentials_file' and 'credentials' are mutually exclusive")

        if credentials_file is not None:
            credentials, _ = auth.load_credentials_from_file(
                                credentials_file,
                                scopes=self._scopes,
                                quota_project_id=quota_project_id
                            )

        elif credentials is None:
            credentials, _ = auth.default(scopes=self._scopes, quota_project_id=quota_project_id)

        # Save the credentials.
        self._credentials = credentials

    def _prep_wrapped_messages(self, client_info):
        # Precompute the wrapped methods.
        self._wrapped_methods = {
            self.list_nodes: gapic_v1.method.wrap_method(
                self.list_nodes,
                default_timeout=None,
                client_info=client_info,
            ),
            self.get_node: gapic_v1.method.wrap_method(
                self.get_node,
                default_timeout=None,
                client_info=client_info,
            ),
            self.create_node: gapic_v1.method.wrap_method(
                self.create_node,
                default_timeout=None,
                client_info=client_info,
            ),
            self.delete_node: gapic_v1.method.wrap_method(
                self.delete_node,
                default_timeout=None,
                client_info=client_info,
            ),
            self.reimage_node: gapic_v1.method.wrap_method(
                self.reimage_node,
                default_timeout=None,
                client_info=client_info,
            ),
            self.stop_node: gapic_v1.method.wrap_method(
                self.stop_node,
                default_timeout=None,
                client_info=client_info,
            ),
            self.start_node: gapic_v1.method.wrap_method(
                self.start_node,
                default_timeout=None,
                client_info=client_info,
            ),
            self.list_tensor_flow_versions: gapic_v1.method.wrap_method(
                self.list_tensor_flow_versions,
                default_timeout=None,
                client_info=client_info,
            ),
            self.get_tensor_flow_version: gapic_v1.method.wrap_method(
                self.get_tensor_flow_version,
                default_timeout=None,
                client_info=client_info,
            ),
            self.list_accelerator_types: gapic_v1.method.wrap_method(
                self.list_accelerator_types,
                default_timeout=None,
                client_info=client_info,
            ),
            self.get_accelerator_type: gapic_v1.method.wrap_method(
                self.get_accelerator_type,
                default_timeout=None,
                client_info=client_info,
            ),

        }

    @property
    def operations_client(self) -> operations_v1.OperationsClient:
        """Return the client designed to process long-running operations."""
        raise NotImplementedError()

    @property
    def list_nodes(self) -> typing.Callable[
            [cloud_tpu.ListNodesRequest],
            typing.Union[
                cloud_tpu.ListNodesResponse,
                typing.Awaitable[cloud_tpu.ListNodesResponse]
            ]]:
        raise NotImplementedError()

    @property
    def get_node(self) -> typing.Callable[
            [cloud_tpu.GetNodeRequest],
            typing.Union[
                cloud_tpu.Node,
                typing.Awaitable[cloud_tpu.Node]
            ]]:
        raise NotImplementedError()

    @property
    def create_node(self) -> typing.Callable[
            [cloud_tpu.CreateNodeRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def delete_node(self) -> typing.Callable[
            [cloud_tpu.DeleteNodeRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def reimage_node(self) -> typing.Callable[
            [cloud_tpu.ReimageNodeRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def stop_node(self) -> typing.Callable[
            [cloud_tpu.StopNodeRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def start_node(self) -> typing.Callable[
            [cloud_tpu.StartNodeRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def list_tensor_flow_versions(self) -> typing.Callable[
            [cloud_tpu.ListTensorFlowVersionsRequest],
            typing.Union[
                cloud_tpu.ListTensorFlowVersionsResponse,
                typing.Awaitable[cloud_tpu.ListTensorFlowVersionsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def get_tensor_flow_version(self) -> typing.Callable[
            [cloud_tpu.GetTensorFlowVersionRequest],
            typing.Union[
                cloud_tpu.TensorFlowVersion,
                typing.Awaitable[cloud_tpu.TensorFlowVersion]
            ]]:
        raise NotImplementedError()

    @property
    def list_accelerator_types(self) -> typing.Callable[
            [cloud_tpu.ListAcceleratorTypesRequest],
            typing.Union[
                cloud_tpu.ListAcceleratorTypesResponse,
                typing.Awaitable[cloud_tpu.ListAcceleratorTypesResponse]
            ]]:
        raise NotImplementedError()

    @property
    def get_accelerator_type(self) -> typing.Callable[
            [cloud_tpu.GetAcceleratorTypeRequest],
            typing.Union[
                cloud_tpu.AcceleratorType,
                typing.Awaitable[cloud_tpu.AcceleratorType]
            ]]:
        raise NotImplementedError()


__all__ = (
    'TpuTransport',
)
