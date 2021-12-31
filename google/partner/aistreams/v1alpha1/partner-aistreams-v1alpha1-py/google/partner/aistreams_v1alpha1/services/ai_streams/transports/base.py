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
from typing import Awaitable, Callable, Dict, Optional, Sequence, Union
import pkg_resources

import google.auth  # type: ignore
import google.api_core
from google.api_core import exceptions as core_exceptions
from google.api_core import gapic_v1
from google.api_core import retry as retries
from google.api_core import operations_v1
from google.auth import credentials as ga_credentials  # type: ignore
from google.oauth2 import service_account # type: ignore

from google.longrunning import operations_pb2  # type: ignore
from google.partner.aistreams_v1alpha1.types import aistreams

try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            'google-partner-aistreams',
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


class AIStreamsTransport(abc.ABC):
    """Abstract transport class for AIStreams."""

    AUTH_SCOPES = (
        'https://www.googleapis.com/auth/cloud-platform',
    )

    DEFAULT_HOST: str = 'aistreams.googleapis.com'
    def __init__(
            self, *,
            host: str = DEFAULT_HOST,
            credentials: ga_credentials.Credentials = None,
            credentials_file: Optional[str] = None,
            scopes: Optional[Sequence[str]] = None,
            quota_project_id: Optional[str] = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            always_use_jwt_access: Optional[bool] = False,
            **kwargs,
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
            credentials_file (Optional[str]): A file with credentials that can
                be loaded with :func:`google.auth.load_credentials_from_file`.
                This argument is mutually exclusive with credentials.
            scopes (Optional[Sequence[str]]): A list of scopes.
            quota_project_id (Optional[str]): An optional project to use for billing
                and quota.
            client_info (google.api_core.gapic_v1.client_info.ClientInfo):
                The client info used to send a user-agent string along with
                API requests. If ``None``, then default info will be used.
                Generally, you only need to set this if you're developing
                your own client library.
            always_use_jwt_access (Optional[bool]): Whether self signed JWT should
                be used for service account credentials.
        """
        # Save the hostname. Default to port 443 (HTTPS) if none is specified.
        if ':' not in host:
            host += ':443'
        self._host = host

        scopes_kwargs = {"scopes": scopes, "default_scopes": self.AUTH_SCOPES}

        # Save the scopes.
        self._scopes = scopes

        # If no credentials are provided, then determine the appropriate
        # defaults.
        if credentials and credentials_file:
            raise core_exceptions.DuplicateCredentialArgs("'credentials_file' and 'credentials' are mutually exclusive")

        if credentials_file is not None:
            credentials, _ = google.auth.load_credentials_from_file(
                                credentials_file,
                                **scopes_kwargs,
                                quota_project_id=quota_project_id
                            )
        elif credentials is None:
            credentials, _ = google.auth.default(**scopes_kwargs, quota_project_id=quota_project_id)

        # If the credentials are service account credentials, then always try to use self signed JWT.
        if always_use_jwt_access and isinstance(credentials, service_account.Credentials) and hasattr(service_account.Credentials, "with_always_use_jwt_access"):
            credentials = credentials.with_always_use_jwt_access(True)

        # Save the credentials.
        self._credentials = credentials

    def _prep_wrapped_messages(self, client_info):
        # Precompute the wrapped methods.
        self._wrapped_methods = {
            self.list_clusters: gapic_v1.method.wrap_method(
                self.list_clusters,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.get_cluster: gapic_v1.method.wrap_method(
                self.get_cluster,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.create_cluster: gapic_v1.method.wrap_method(
                self.create_cluster,
                default_timeout=600.0,
                client_info=client_info,
            ),
            self.update_cluster: gapic_v1.method.wrap_method(
                self.update_cluster,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.delete_cluster: gapic_v1.method.wrap_method(
                self.delete_cluster,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.list_streams: gapic_v1.method.wrap_method(
                self.list_streams,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.get_stream: gapic_v1.method.wrap_method(
                self.get_stream,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.create_stream: gapic_v1.method.wrap_method(
                self.create_stream,
                default_timeout=300.0,
                client_info=client_info,
            ),
            self.update_stream: gapic_v1.method.wrap_method(
                self.update_stream,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.delete_stream: gapic_v1.method.wrap_method(
                self.delete_stream,
                default_timeout=60.0,
                client_info=client_info,
            ),
         }

    def close(self):
        """Closes resources associated with the transport.

       .. warning::
            Only call this method if the transport is NOT shared
            with other clients - this may cause errors in other clients!
        """
        raise NotImplementedError()

    @property
    def operations_client(self):
        """Return the client designed to process long-running operations."""
        raise NotImplementedError()

    @property
    def list_clusters(self) -> Callable[
            [aistreams.ListClustersRequest],
            Union[
                aistreams.ListClustersResponse,
                Awaitable[aistreams.ListClustersResponse]
            ]]:
        raise NotImplementedError()

    @property
    def get_cluster(self) -> Callable[
            [aistreams.GetClusterRequest],
            Union[
                aistreams.Cluster,
                Awaitable[aistreams.Cluster]
            ]]:
        raise NotImplementedError()

    @property
    def create_cluster(self) -> Callable[
            [aistreams.CreateClusterRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def update_cluster(self) -> Callable[
            [aistreams.UpdateClusterRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def delete_cluster(self) -> Callable[
            [aistreams.DeleteClusterRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def list_streams(self) -> Callable[
            [aistreams.ListStreamsRequest],
            Union[
                aistreams.ListStreamsResponse,
                Awaitable[aistreams.ListStreamsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def get_stream(self) -> Callable[
            [aistreams.GetStreamRequest],
            Union[
                aistreams.Stream,
                Awaitable[aistreams.Stream]
            ]]:
        raise NotImplementedError()

    @property
    def create_stream(self) -> Callable[
            [aistreams.CreateStreamRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def update_stream(self) -> Callable[
            [aistreams.UpdateStreamRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def delete_stream(self) -> Callable[
            [aistreams.DeleteStreamRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()


__all__ = (
    'AIStreamsTransport',
)
