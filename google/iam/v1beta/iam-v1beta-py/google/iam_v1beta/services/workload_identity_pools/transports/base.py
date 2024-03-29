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

from google.iam_v1beta.types import workload_identity_pool
from google.iam_v1beta.types import workload_identity_pool as gi_workload_identity_pool
from google.longrunning import operations_pb2  # type: ignore

try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            'google-iam',
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


class WorkloadIdentityPoolsTransport(abc.ABC):
    """Abstract transport class for WorkloadIdentityPools."""

    AUTH_SCOPES = (
        'https://www.googleapis.com/auth/cloud-platform',
    )

    DEFAULT_HOST: str = 'iam.googleapis.com'
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
            self.list_workload_identity_pools: gapic_v1.method.wrap_method(
                self.list_workload_identity_pools,
                default_retry=retries.Retry(
initial=1.0,maximum=10.0,multiplier=1.3,                    predicate=retries.if_exception_type(
                        core_exceptions.DeadlineExceeded,
                        core_exceptions.ServiceUnavailable,
                    ),
                    deadline=60.0,
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.get_workload_identity_pool: gapic_v1.method.wrap_method(
                self.get_workload_identity_pool,
                default_retry=retries.Retry(
initial=1.0,maximum=10.0,multiplier=1.3,                    predicate=retries.if_exception_type(
                        core_exceptions.DeadlineExceeded,
                        core_exceptions.ServiceUnavailable,
                    ),
                    deadline=60.0,
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.create_workload_identity_pool: gapic_v1.method.wrap_method(
                self.create_workload_identity_pool,
                default_retry=retries.Retry(
initial=1.0,maximum=10.0,multiplier=1.3,                    predicate=retries.if_exception_type(
                        core_exceptions.DeadlineExceeded,
                        core_exceptions.ServiceUnavailable,
                    ),
                    deadline=60.0,
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.update_workload_identity_pool: gapic_v1.method.wrap_method(
                self.update_workload_identity_pool,
                default_retry=retries.Retry(
initial=1.0,maximum=10.0,multiplier=1.3,                    predicate=retries.if_exception_type(
                        core_exceptions.DeadlineExceeded,
                        core_exceptions.ServiceUnavailable,
                    ),
                    deadline=60.0,
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.delete_workload_identity_pool: gapic_v1.method.wrap_method(
                self.delete_workload_identity_pool,
                default_retry=retries.Retry(
initial=1.0,maximum=10.0,multiplier=1.3,                    predicate=retries.if_exception_type(
                        core_exceptions.DeadlineExceeded,
                        core_exceptions.ServiceUnavailable,
                    ),
                    deadline=60.0,
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.undelete_workload_identity_pool: gapic_v1.method.wrap_method(
                self.undelete_workload_identity_pool,
                default_retry=retries.Retry(
initial=1.0,maximum=10.0,multiplier=1.3,                    predicate=retries.if_exception_type(
                        core_exceptions.DeadlineExceeded,
                        core_exceptions.ServiceUnavailable,
                    ),
                    deadline=60.0,
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.list_workload_identity_pool_providers: gapic_v1.method.wrap_method(
                self.list_workload_identity_pool_providers,
                default_retry=retries.Retry(
initial=1.0,maximum=10.0,multiplier=1.3,                    predicate=retries.if_exception_type(
                        core_exceptions.DeadlineExceeded,
                        core_exceptions.ServiceUnavailable,
                    ),
                    deadline=60.0,
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.get_workload_identity_pool_provider: gapic_v1.method.wrap_method(
                self.get_workload_identity_pool_provider,
                default_retry=retries.Retry(
initial=1.0,maximum=10.0,multiplier=1.3,                    predicate=retries.if_exception_type(
                        core_exceptions.DeadlineExceeded,
                        core_exceptions.ServiceUnavailable,
                    ),
                    deadline=60.0,
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.create_workload_identity_pool_provider: gapic_v1.method.wrap_method(
                self.create_workload_identity_pool_provider,
                default_retry=retries.Retry(
initial=1.0,maximum=10.0,multiplier=1.3,                    predicate=retries.if_exception_type(
                        core_exceptions.DeadlineExceeded,
                        core_exceptions.ServiceUnavailable,
                    ),
                    deadline=60.0,
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.update_workload_identity_pool_provider: gapic_v1.method.wrap_method(
                self.update_workload_identity_pool_provider,
                default_retry=retries.Retry(
initial=1.0,maximum=10.0,multiplier=1.3,                    predicate=retries.if_exception_type(
                        core_exceptions.DeadlineExceeded,
                        core_exceptions.ServiceUnavailable,
                    ),
                    deadline=60.0,
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.delete_workload_identity_pool_provider: gapic_v1.method.wrap_method(
                self.delete_workload_identity_pool_provider,
                default_retry=retries.Retry(
initial=1.0,maximum=10.0,multiplier=1.3,                    predicate=retries.if_exception_type(
                        core_exceptions.DeadlineExceeded,
                        core_exceptions.ServiceUnavailable,
                    ),
                    deadline=60.0,
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.undelete_workload_identity_pool_provider: gapic_v1.method.wrap_method(
                self.undelete_workload_identity_pool_provider,
                default_retry=retries.Retry(
initial=1.0,maximum=10.0,multiplier=1.3,                    predicate=retries.if_exception_type(
                        core_exceptions.DeadlineExceeded,
                        core_exceptions.ServiceUnavailable,
                    ),
                    deadline=60.0,
                ),
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
    def list_workload_identity_pools(self) -> Callable[
            [workload_identity_pool.ListWorkloadIdentityPoolsRequest],
            Union[
                workload_identity_pool.ListWorkloadIdentityPoolsResponse,
                Awaitable[workload_identity_pool.ListWorkloadIdentityPoolsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def get_workload_identity_pool(self) -> Callable[
            [workload_identity_pool.GetWorkloadIdentityPoolRequest],
            Union[
                workload_identity_pool.WorkloadIdentityPool,
                Awaitable[workload_identity_pool.WorkloadIdentityPool]
            ]]:
        raise NotImplementedError()

    @property
    def create_workload_identity_pool(self) -> Callable[
            [gi_workload_identity_pool.CreateWorkloadIdentityPoolRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def update_workload_identity_pool(self) -> Callable[
            [gi_workload_identity_pool.UpdateWorkloadIdentityPoolRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def delete_workload_identity_pool(self) -> Callable[
            [workload_identity_pool.DeleteWorkloadIdentityPoolRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def undelete_workload_identity_pool(self) -> Callable[
            [workload_identity_pool.UndeleteWorkloadIdentityPoolRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def list_workload_identity_pool_providers(self) -> Callable[
            [workload_identity_pool.ListWorkloadIdentityPoolProvidersRequest],
            Union[
                workload_identity_pool.ListWorkloadIdentityPoolProvidersResponse,
                Awaitable[workload_identity_pool.ListWorkloadIdentityPoolProvidersResponse]
            ]]:
        raise NotImplementedError()

    @property
    def get_workload_identity_pool_provider(self) -> Callable[
            [workload_identity_pool.GetWorkloadIdentityPoolProviderRequest],
            Union[
                workload_identity_pool.WorkloadIdentityPoolProvider,
                Awaitable[workload_identity_pool.WorkloadIdentityPoolProvider]
            ]]:
        raise NotImplementedError()

    @property
    def create_workload_identity_pool_provider(self) -> Callable[
            [workload_identity_pool.CreateWorkloadIdentityPoolProviderRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def update_workload_identity_pool_provider(self) -> Callable[
            [workload_identity_pool.UpdateWorkloadIdentityPoolProviderRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def delete_workload_identity_pool_provider(self) -> Callable[
            [workload_identity_pool.DeleteWorkloadIdentityPoolProviderRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def undelete_workload_identity_pool_provider(self) -> Callable[
            [workload_identity_pool.UndeleteWorkloadIdentityPoolProviderRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()


__all__ = (
    'WorkloadIdentityPoolsTransport',
)
