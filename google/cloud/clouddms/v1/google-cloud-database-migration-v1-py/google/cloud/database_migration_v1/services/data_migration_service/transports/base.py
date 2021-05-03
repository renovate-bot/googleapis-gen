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

from google.cloud.database_migration_v1.types import clouddms
from google.cloud.database_migration_v1.types import clouddms_resources
from google.longrunning import operations_pb2 as operations  # type: ignore


try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            'google-cloud-database-migration',
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()

class DataMigrationServiceTransport(abc.ABC):
    """Abstract transport class for DataMigrationService."""

    AUTH_SCOPES = (
        'https://www.googleapis.com/auth/cloud-platform',
    )

    def __init__(
            self, *,
            host: str = 'datamigration.googleapis.com',
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
            self.list_migration_jobs: gapic_v1.method.wrap_method(
                self.list_migration_jobs,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.get_migration_job: gapic_v1.method.wrap_method(
                self.get_migration_job,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.create_migration_job: gapic_v1.method.wrap_method(
                self.create_migration_job,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.update_migration_job: gapic_v1.method.wrap_method(
                self.update_migration_job,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.delete_migration_job: gapic_v1.method.wrap_method(
                self.delete_migration_job,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.start_migration_job: gapic_v1.method.wrap_method(
                self.start_migration_job,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.stop_migration_job: gapic_v1.method.wrap_method(
                self.stop_migration_job,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.resume_migration_job: gapic_v1.method.wrap_method(
                self.resume_migration_job,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.promote_migration_job: gapic_v1.method.wrap_method(
                self.promote_migration_job,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.verify_migration_job: gapic_v1.method.wrap_method(
                self.verify_migration_job,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.restart_migration_job: gapic_v1.method.wrap_method(
                self.restart_migration_job,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.generate_ssh_script: gapic_v1.method.wrap_method(
                self.generate_ssh_script,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.list_connection_profiles: gapic_v1.method.wrap_method(
                self.list_connection_profiles,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.get_connection_profile: gapic_v1.method.wrap_method(
                self.get_connection_profile,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.create_connection_profile: gapic_v1.method.wrap_method(
                self.create_connection_profile,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.update_connection_profile: gapic_v1.method.wrap_method(
                self.update_connection_profile,
                default_timeout=60.0,
                client_info=client_info,
            ),
            self.delete_connection_profile: gapic_v1.method.wrap_method(
                self.delete_connection_profile,
                default_timeout=60.0,
                client_info=client_info,
            ),

        }

    @property
    def operations_client(self) -> operations_v1.OperationsClient:
        """Return the client designed to process long-running operations."""
        raise NotImplementedError()

    @property
    def list_migration_jobs(self) -> typing.Callable[
            [clouddms.ListMigrationJobsRequest],
            typing.Union[
                clouddms.ListMigrationJobsResponse,
                typing.Awaitable[clouddms.ListMigrationJobsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def get_migration_job(self) -> typing.Callable[
            [clouddms.GetMigrationJobRequest],
            typing.Union[
                clouddms_resources.MigrationJob,
                typing.Awaitable[clouddms_resources.MigrationJob]
            ]]:
        raise NotImplementedError()

    @property
    def create_migration_job(self) -> typing.Callable[
            [clouddms.CreateMigrationJobRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def update_migration_job(self) -> typing.Callable[
            [clouddms.UpdateMigrationJobRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def delete_migration_job(self) -> typing.Callable[
            [clouddms.DeleteMigrationJobRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def start_migration_job(self) -> typing.Callable[
            [clouddms.StartMigrationJobRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def stop_migration_job(self) -> typing.Callable[
            [clouddms.StopMigrationJobRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def resume_migration_job(self) -> typing.Callable[
            [clouddms.ResumeMigrationJobRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def promote_migration_job(self) -> typing.Callable[
            [clouddms.PromoteMigrationJobRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def verify_migration_job(self) -> typing.Callable[
            [clouddms.VerifyMigrationJobRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def restart_migration_job(self) -> typing.Callable[
            [clouddms.RestartMigrationJobRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def generate_ssh_script(self) -> typing.Callable[
            [clouddms.GenerateSshScriptRequest],
            typing.Union[
                clouddms.SshScript,
                typing.Awaitable[clouddms.SshScript]
            ]]:
        raise NotImplementedError()

    @property
    def list_connection_profiles(self) -> typing.Callable[
            [clouddms.ListConnectionProfilesRequest],
            typing.Union[
                clouddms.ListConnectionProfilesResponse,
                typing.Awaitable[clouddms.ListConnectionProfilesResponse]
            ]]:
        raise NotImplementedError()

    @property
    def get_connection_profile(self) -> typing.Callable[
            [clouddms.GetConnectionProfileRequest],
            typing.Union[
                clouddms_resources.ConnectionProfile,
                typing.Awaitable[clouddms_resources.ConnectionProfile]
            ]]:
        raise NotImplementedError()

    @property
    def create_connection_profile(self) -> typing.Callable[
            [clouddms.CreateConnectionProfileRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def update_connection_profile(self) -> typing.Callable[
            [clouddms.UpdateConnectionProfileRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()

    @property
    def delete_connection_profile(self) -> typing.Callable[
            [clouddms.DeleteConnectionProfileRequest],
            typing.Union[
                operations.Operation,
                typing.Awaitable[operations.Operation]
            ]]:
        raise NotImplementedError()


__all__ = (
    'DataMigrationServiceTransport',
)
