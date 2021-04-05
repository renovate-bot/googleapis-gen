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

from google.cloud.resourcemanager_v3.types import folders
from google.iam.v1 import iam_policy_pb2 as iam_policy  # type: ignore
from google.iam.v1 import policy_pb2 as giv_policy  # type: ignore
from google.longrunning import operations_pb2 as operations  # type: ignore


try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            'google-cloud-resourcemanager',
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()

class FoldersTransport(abc.ABC):
    """Abstract transport class for Folders."""

    AUTH_SCOPES = (
        'https://www.googleapis.com/auth/cloud-platform',
        'https://www.googleapis.com/auth/cloud-platform.read-only',
    )

    def __init__(
            self, *,
            host: str = 'cloudresourcemanager.googleapis.com',
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
            self.get_folder: gapic_v1.method.wrap_method(
                self.get_folder,
                default_retry=retries.Retry(
                    initial=0.1,
                    maximum=60.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.ServiceUnavailable,
                    ),
                    deadline=60.0,
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.list_folders: gapic_v1.method.wrap_method(
                self.list_folders,
                default_retry=retries.Retry(
                    initial=0.1,
                    maximum=60.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.ServiceUnavailable,
                    ),
                    deadline=60.0,
                ),
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.search_folders: gapic_v1.method.wrap_method(
                self.search_folders,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.create_folder: gapic_v1.method.wrap_method(
                self.create_folder,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.update_folder: gapic_v1.method.wrap_method(
                self.update_folder,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.move_folder: gapic_v1.method.wrap_method(
                self.move_folder,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.delete_folder: gapic_v1.method.wrap_method(
                self.delete_folder,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.undelete_folder: gapic_v1.method.wrap_method(
                self.undelete_folder,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.get_iam_policy: gapic_v1.method.wrap_method(
                self.get_iam_policy,
                default_retry=retries.Retry(
                    initial=0.1,
                    maximum=60.0,
                    multiplier=1.3,
                    predicate=retries.if_exception_type(
                        exceptions.ServiceUnavailable,
                    ),
                    deadline=60.0,
                ),
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
                default_timeout=None,
                client_info=client_info,
            ),

        }

    @property
    def operations_client(self) -> operations_v1.OperationsClient:
        """Return the client designed to process long-running operations."""
        raise NotImplementedError()

    @property
    def get_folder(self) -> typing.Callable[
            [folders.GetFolderRequest],
            typing.Union[
                folders.Folder,
                typing.Awaitable[folders.Folder]
            ]]:
        raise NotImplementedError()

    @property
    def list_folders(self) -> typing.Callable[
            [folders.ListFoldersRequest],
            typing.Union[
                folders.ListFoldersResponse,
                typing.Awaitable[folders.ListFoldersResponse]
            ]]:
        raise NotImplementedError()

    @property
    def search_folders(self) -> typing.Callable[
            [folders.SearchFoldersRequest],
            typing.Union[
                folders.SearchFoldersResponse,
                typing.Awaitable[folders.SearchFoldersResponse]
            ]]:
        raise NotImplementedError()

    @property
    def create_folder(self) -> typing.Callable[
            [folders.CreateFolderRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def update_folder(self) -> typing.Callable[
            [folders.UpdateFolderRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def move_folder(self) -> typing.Callable[
            [folders.MoveFolderRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def delete_folder(self) -> typing.Callable[
            [folders.DeleteFolderRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def undelete_folder(self) -> typing.Callable[
            [folders.UndeleteFolderRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def get_iam_policy(self) -> typing.Callable[
            [iam_policy.GetIamPolicyRequest],
            typing.Union[
                giv_policy.Policy,
                typing.Awaitable[giv_policy.Policy]
            ]]:
        raise NotImplementedError()

    @property
    def set_iam_policy(self) -> typing.Callable[
            [iam_policy.SetIamPolicyRequest],
            typing.Union[
                giv_policy.Policy,
                typing.Awaitable[giv_policy.Policy]
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


__all__ = (
    'FoldersTransport',
)
