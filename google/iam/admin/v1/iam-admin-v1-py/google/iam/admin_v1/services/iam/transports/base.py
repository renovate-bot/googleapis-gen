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
from google.auth import credentials  # type: ignore

from google.iam.admin_v1.types import iam
from google.iam.v1 import iam_policy_pb2 as iam_policy  # type: ignore
from google.iam.v1 import policy_pb2 as policy  # type: ignore
from google.protobuf import empty_pb2 as empty  # type: ignore


try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            'google-iam-admin',
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()

class IAMTransport(abc.ABC):
    """Abstract transport class for IAM."""

    AUTH_SCOPES = (
        'https://www.googleapis.com/auth/cloud-platform',
    )

    def __init__(
            self, *,
            host: str = 'iam.googleapis.com',
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

        # If no credentials are provided, then determine the appropriate
        # defaults.
        if credentials and credentials_file:
            raise exceptions.DuplicateCredentialArgs("'credentials_file' and 'credentials' are mutually exclusive")

        if credentials_file is not None:
            credentials, _ = auth.load_credentials_from_file(
                                credentials_file,
                                scopes=scopes,
                                quota_project_id=quota_project_id
                            )

        elif credentials is None:
            credentials, _ = auth.default(scopes=scopes, quota_project_id=quota_project_id)

        # Save the credentials.
        self._credentials = credentials

        # Lifted into its own function so it can be stubbed out during tests.
        self._prep_wrapped_messages(client_info)

    def _prep_wrapped_messages(self, client_info):
        # Precompute the wrapped methods.
        self._wrapped_methods = {
            self.list_service_accounts: gapic_v1.method.wrap_method(
                self.list_service_accounts,
                default_retry=retries.Retry(
                    initial=0.1,
                    maximum=60.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.DeadlineExceeded,
                        exceptions.ServiceUnavailable,
                    ),
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.get_service_account: gapic_v1.method.wrap_method(
                self.get_service_account,
                default_retry=retries.Retry(
                    initial=0.1,
                    maximum=60.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.DeadlineExceeded,
                        exceptions.ServiceUnavailable,
                    ),
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.create_service_account: gapic_v1.method.wrap_method(
                self.create_service_account,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.update_service_account: gapic_v1.method.wrap_method(
                self.update_service_account,
                default_retry=retries.Retry(
                    initial=0.1,
                    maximum=60.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.DeadlineExceeded,
                        exceptions.ServiceUnavailable,
                    ),
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.delete_service_account: gapic_v1.method.wrap_method(
                self.delete_service_account,
                default_retry=retries.Retry(
                    initial=0.1,
                    maximum=60.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.DeadlineExceeded,
                        exceptions.ServiceUnavailable,
                    ),
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.list_service_account_keys: gapic_v1.method.wrap_method(
                self.list_service_account_keys,
                default_retry=retries.Retry(
                    initial=0.1,
                    maximum=60.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.DeadlineExceeded,
                        exceptions.ServiceUnavailable,
                    ),
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.get_service_account_key: gapic_v1.method.wrap_method(
                self.get_service_account_key,
                default_retry=retries.Retry(
                    initial=0.1,
                    maximum=60.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.DeadlineExceeded,
                        exceptions.ServiceUnavailable,
                    ),
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.create_service_account_key: gapic_v1.method.wrap_method(
                self.create_service_account_key,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.delete_service_account_key: gapic_v1.method.wrap_method(
                self.delete_service_account_key,
                default_retry=retries.Retry(
                    initial=0.1,
                    maximum=60.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.DeadlineExceeded,
                        exceptions.ServiceUnavailable,
                    ),
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.sign_blob: gapic_v1.method.wrap_method(
                self.sign_blob,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.sign_jwt: gapic_v1.method.wrap_method(
                self.sign_jwt,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.get_iam_policy: gapic_v1.method.wrap_method(
                self.get_iam_policy,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.set_iam_policy: gapic_v1.method.wrap_method(
                self.set_iam_policy,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.test_iam_permissions: gapic_v1.method.wrap_method(
                self.test_iam_permissions,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.query_grantable_roles: gapic_v1.method.wrap_method(
                self.query_grantable_roles,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.list_roles: gapic_v1.method.wrap_method(
                self.list_roles,
                default_timeout=None,
                client_info=client_info,
            ),
            self.get_role: gapic_v1.method.wrap_method(
                self.get_role,
                default_timeout=None,
                client_info=client_info,
            ),
            self.create_role: gapic_v1.method.wrap_method(
                self.create_role,
                default_timeout=None,
                client_info=client_info,
            ),
            self.update_role: gapic_v1.method.wrap_method(
                self.update_role,
                default_timeout=None,
                client_info=client_info,
            ),
            self.delete_role: gapic_v1.method.wrap_method(
                self.delete_role,
                default_timeout=None,
                client_info=client_info,
            ),
            self.undelete_role: gapic_v1.method.wrap_method(
                self.undelete_role,
                default_timeout=None,
                client_info=client_info,
            ),
            self.query_testable_permissions: gapic_v1.method.wrap_method(
                self.query_testable_permissions,
                default_timeout=None,
                client_info=client_info,
            ),

        }

    @property
    def list_service_accounts(self) -> typing.Callable[
            [iam.ListServiceAccountsRequest],
            typing.Union[
                iam.ListServiceAccountsResponse,
                typing.Awaitable[iam.ListServiceAccountsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def get_service_account(self) -> typing.Callable[
            [iam.GetServiceAccountRequest],
            typing.Union[
                iam.ServiceAccount,
                typing.Awaitable[iam.ServiceAccount]
            ]]:
        raise NotImplementedError()

    @property
    def create_service_account(self) -> typing.Callable[
            [iam.CreateServiceAccountRequest],
            typing.Union[
                iam.ServiceAccount,
                typing.Awaitable[iam.ServiceAccount]
            ]]:
        raise NotImplementedError()

    @property
    def update_service_account(self) -> typing.Callable[
            [iam.ServiceAccount],
            typing.Union[
                iam.ServiceAccount,
                typing.Awaitable[iam.ServiceAccount]
            ]]:
        raise NotImplementedError()

    @property
    def delete_service_account(self) -> typing.Callable[
            [iam.DeleteServiceAccountRequest],
            typing.Union[
                empty.Empty,
                typing.Awaitable[empty.Empty]
            ]]:
        raise NotImplementedError()

    @property
    def list_service_account_keys(self) -> typing.Callable[
            [iam.ListServiceAccountKeysRequest],
            typing.Union[
                iam.ListServiceAccountKeysResponse,
                typing.Awaitable[iam.ListServiceAccountKeysResponse]
            ]]:
        raise NotImplementedError()

    @property
    def get_service_account_key(self) -> typing.Callable[
            [iam.GetServiceAccountKeyRequest],
            typing.Union[
                iam.ServiceAccountKey,
                typing.Awaitable[iam.ServiceAccountKey]
            ]]:
        raise NotImplementedError()

    @property
    def create_service_account_key(self) -> typing.Callable[
            [iam.CreateServiceAccountKeyRequest],
            typing.Union[
                iam.ServiceAccountKey,
                typing.Awaitable[iam.ServiceAccountKey]
            ]]:
        raise NotImplementedError()

    @property
    def delete_service_account_key(self) -> typing.Callable[
            [iam.DeleteServiceAccountKeyRequest],
            typing.Union[
                empty.Empty,
                typing.Awaitable[empty.Empty]
            ]]:
        raise NotImplementedError()

    @property
    def sign_blob(self) -> typing.Callable[
            [iam.SignBlobRequest],
            typing.Union[
                iam.SignBlobResponse,
                typing.Awaitable[iam.SignBlobResponse]
            ]]:
        raise NotImplementedError()

    @property
    def sign_jwt(self) -> typing.Callable[
            [iam.SignJwtRequest],
            typing.Union[
                iam.SignJwtResponse,
                typing.Awaitable[iam.SignJwtResponse]
            ]]:
        raise NotImplementedError()

    @property
    def get_iam_policy(self) -> typing.Callable[
            [iam_policy.GetIamPolicyRequest],
            typing.Union[
                policy.Policy,
                typing.Awaitable[policy.Policy]
            ]]:
        raise NotImplementedError()

    @property
    def set_iam_policy(self) -> typing.Callable[
            [iam_policy.SetIamPolicyRequest],
            typing.Union[
                policy.Policy,
                typing.Awaitable[policy.Policy]
            ]]:
        raise NotImplementedError()

    @property
    def test_iam_permissions(self) -> typing.Callable[
            [iam_policy.TestIamPermissionsRequest],
            typing.Union[
                iam_policy.TestIamPermissionsResponse,
                typing.Awaitable[iam_policy.TestIamPermissionsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def query_grantable_roles(self) -> typing.Callable[
            [iam.QueryGrantableRolesRequest],
            typing.Union[
                iam.QueryGrantableRolesResponse,
                typing.Awaitable[iam.QueryGrantableRolesResponse]
            ]]:
        raise NotImplementedError()

    @property
    def list_roles(self) -> typing.Callable[
            [iam.ListRolesRequest],
            typing.Union[
                iam.ListRolesResponse,
                typing.Awaitable[iam.ListRolesResponse]
            ]]:
        raise NotImplementedError()

    @property
    def get_role(self) -> typing.Callable[
            [iam.GetRoleRequest],
            typing.Union[
                iam.Role,
                typing.Awaitable[iam.Role]
            ]]:
        raise NotImplementedError()

    @property
    def create_role(self) -> typing.Callable[
            [iam.CreateRoleRequest],
            typing.Union[
                iam.Role,
                typing.Awaitable[iam.Role]
            ]]:
        raise NotImplementedError()

    @property
    def update_role(self) -> typing.Callable[
            [iam.UpdateRoleRequest],
            typing.Union[
                iam.Role,
                typing.Awaitable[iam.Role]
            ]]:
        raise NotImplementedError()

    @property
    def delete_role(self) -> typing.Callable[
            [iam.DeleteRoleRequest],
            typing.Union[
                iam.Role,
                typing.Awaitable[iam.Role]
            ]]:
        raise NotImplementedError()

    @property
    def undelete_role(self) -> typing.Callable[
            [iam.UndeleteRoleRequest],
            typing.Union[
                iam.Role,
                typing.Awaitable[iam.Role]
            ]]:
        raise NotImplementedError()

    @property
    def query_testable_permissions(self) -> typing.Callable[
            [iam.QueryTestablePermissionsRequest],
            typing.Union[
                iam.QueryTestablePermissionsResponse,
                typing.Awaitable[iam.QueryTestablePermissionsResponse]
            ]]:
        raise NotImplementedError()


__all__ = (
    'IAMTransport',
)
