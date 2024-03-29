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

from google.identity.accesscontextmanager_v1.types import access_context_manager
from google.identity.accesscontextmanager_v1.types import access_level
from google.identity.accesscontextmanager_v1.types import access_policy
from google.identity.accesscontextmanager_v1.types import gcp_user_access_binding
from google.identity.accesscontextmanager_v1.types import service_perimeter
from google.longrunning import operations_pb2  # type: ignore

try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            'google-identity-accesscontextmanager',
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


class AccessContextManagerTransport(abc.ABC):
    """Abstract transport class for AccessContextManager."""

    AUTH_SCOPES = (
        'https://www.googleapis.com/auth/cloud-platform',
    )

    DEFAULT_HOST: str = 'accesscontextmanager.googleapis.com'
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
            self.list_access_policies: gapic_v1.method.wrap_method(
                self.list_access_policies,
                default_timeout=None,
                client_info=client_info,
            ),
            self.get_access_policy: gapic_v1.method.wrap_method(
                self.get_access_policy,
                default_timeout=None,
                client_info=client_info,
            ),
            self.create_access_policy: gapic_v1.method.wrap_method(
                self.create_access_policy,
                default_timeout=None,
                client_info=client_info,
            ),
            self.update_access_policy: gapic_v1.method.wrap_method(
                self.update_access_policy,
                default_timeout=None,
                client_info=client_info,
            ),
            self.delete_access_policy: gapic_v1.method.wrap_method(
                self.delete_access_policy,
                default_timeout=None,
                client_info=client_info,
            ),
            self.list_access_levels: gapic_v1.method.wrap_method(
                self.list_access_levels,
                default_timeout=None,
                client_info=client_info,
            ),
            self.get_access_level: gapic_v1.method.wrap_method(
                self.get_access_level,
                default_timeout=None,
                client_info=client_info,
            ),
            self.create_access_level: gapic_v1.method.wrap_method(
                self.create_access_level,
                default_timeout=None,
                client_info=client_info,
            ),
            self.update_access_level: gapic_v1.method.wrap_method(
                self.update_access_level,
                default_timeout=None,
                client_info=client_info,
            ),
            self.delete_access_level: gapic_v1.method.wrap_method(
                self.delete_access_level,
                default_timeout=None,
                client_info=client_info,
            ),
            self.replace_access_levels: gapic_v1.method.wrap_method(
                self.replace_access_levels,
                default_timeout=None,
                client_info=client_info,
            ),
            self.list_service_perimeters: gapic_v1.method.wrap_method(
                self.list_service_perimeters,
                default_timeout=None,
                client_info=client_info,
            ),
            self.get_service_perimeter: gapic_v1.method.wrap_method(
                self.get_service_perimeter,
                default_timeout=None,
                client_info=client_info,
            ),
            self.create_service_perimeter: gapic_v1.method.wrap_method(
                self.create_service_perimeter,
                default_timeout=None,
                client_info=client_info,
            ),
            self.update_service_perimeter: gapic_v1.method.wrap_method(
                self.update_service_perimeter,
                default_timeout=None,
                client_info=client_info,
            ),
            self.delete_service_perimeter: gapic_v1.method.wrap_method(
                self.delete_service_perimeter,
                default_timeout=None,
                client_info=client_info,
            ),
            self.replace_service_perimeters: gapic_v1.method.wrap_method(
                self.replace_service_perimeters,
                default_timeout=None,
                client_info=client_info,
            ),
            self.commit_service_perimeters: gapic_v1.method.wrap_method(
                self.commit_service_perimeters,
                default_timeout=None,
                client_info=client_info,
            ),
            self.list_gcp_user_access_bindings: gapic_v1.method.wrap_method(
                self.list_gcp_user_access_bindings,
                default_timeout=None,
                client_info=client_info,
            ),
            self.get_gcp_user_access_binding: gapic_v1.method.wrap_method(
                self.get_gcp_user_access_binding,
                default_timeout=None,
                client_info=client_info,
            ),
            self.create_gcp_user_access_binding: gapic_v1.method.wrap_method(
                self.create_gcp_user_access_binding,
                default_timeout=None,
                client_info=client_info,
            ),
            self.update_gcp_user_access_binding: gapic_v1.method.wrap_method(
                self.update_gcp_user_access_binding,
                default_timeout=None,
                client_info=client_info,
            ),
            self.delete_gcp_user_access_binding: gapic_v1.method.wrap_method(
                self.delete_gcp_user_access_binding,
                default_timeout=None,
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
    def list_access_policies(self) -> Callable[
            [access_context_manager.ListAccessPoliciesRequest],
            Union[
                access_context_manager.ListAccessPoliciesResponse,
                Awaitable[access_context_manager.ListAccessPoliciesResponse]
            ]]:
        raise NotImplementedError()

    @property
    def get_access_policy(self) -> Callable[
            [access_context_manager.GetAccessPolicyRequest],
            Union[
                access_policy.AccessPolicy,
                Awaitable[access_policy.AccessPolicy]
            ]]:
        raise NotImplementedError()

    @property
    def create_access_policy(self) -> Callable[
            [access_policy.AccessPolicy],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def update_access_policy(self) -> Callable[
            [access_context_manager.UpdateAccessPolicyRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def delete_access_policy(self) -> Callable[
            [access_context_manager.DeleteAccessPolicyRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def list_access_levels(self) -> Callable[
            [access_context_manager.ListAccessLevelsRequest],
            Union[
                access_context_manager.ListAccessLevelsResponse,
                Awaitable[access_context_manager.ListAccessLevelsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def get_access_level(self) -> Callable[
            [access_context_manager.GetAccessLevelRequest],
            Union[
                access_level.AccessLevel,
                Awaitable[access_level.AccessLevel]
            ]]:
        raise NotImplementedError()

    @property
    def create_access_level(self) -> Callable[
            [access_context_manager.CreateAccessLevelRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def update_access_level(self) -> Callable[
            [access_context_manager.UpdateAccessLevelRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def delete_access_level(self) -> Callable[
            [access_context_manager.DeleteAccessLevelRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def replace_access_levels(self) -> Callable[
            [access_context_manager.ReplaceAccessLevelsRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def list_service_perimeters(self) -> Callable[
            [access_context_manager.ListServicePerimetersRequest],
            Union[
                access_context_manager.ListServicePerimetersResponse,
                Awaitable[access_context_manager.ListServicePerimetersResponse]
            ]]:
        raise NotImplementedError()

    @property
    def get_service_perimeter(self) -> Callable[
            [access_context_manager.GetServicePerimeterRequest],
            Union[
                service_perimeter.ServicePerimeter,
                Awaitable[service_perimeter.ServicePerimeter]
            ]]:
        raise NotImplementedError()

    @property
    def create_service_perimeter(self) -> Callable[
            [access_context_manager.CreateServicePerimeterRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def update_service_perimeter(self) -> Callable[
            [access_context_manager.UpdateServicePerimeterRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def delete_service_perimeter(self) -> Callable[
            [access_context_manager.DeleteServicePerimeterRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def replace_service_perimeters(self) -> Callable[
            [access_context_manager.ReplaceServicePerimetersRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def commit_service_perimeters(self) -> Callable[
            [access_context_manager.CommitServicePerimetersRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def list_gcp_user_access_bindings(self) -> Callable[
            [access_context_manager.ListGcpUserAccessBindingsRequest],
            Union[
                access_context_manager.ListGcpUserAccessBindingsResponse,
                Awaitable[access_context_manager.ListGcpUserAccessBindingsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def get_gcp_user_access_binding(self) -> Callable[
            [access_context_manager.GetGcpUserAccessBindingRequest],
            Union[
                gcp_user_access_binding.GcpUserAccessBinding,
                Awaitable[gcp_user_access_binding.GcpUserAccessBinding]
            ]]:
        raise NotImplementedError()

    @property
    def create_gcp_user_access_binding(self) -> Callable[
            [access_context_manager.CreateGcpUserAccessBindingRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def update_gcp_user_access_binding(self) -> Callable[
            [access_context_manager.UpdateGcpUserAccessBindingRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def delete_gcp_user_access_binding(self) -> Callable[
            [access_context_manager.DeleteGcpUserAccessBindingRequest],
            Union[
                operations_pb2.Operation,
                Awaitable[operations_pb2.Operation]
            ]]:
        raise NotImplementedError()


__all__ = (
    'AccessContextManagerTransport',
)
