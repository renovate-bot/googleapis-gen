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

from google.cloud.osconfig_v1beta.types import guest_policies
from google.cloud.osconfig_v1beta.types import patch_deployments
from google.cloud.osconfig_v1beta.types import patch_jobs
from google.protobuf import empty_pb2 as empty  # type: ignore


try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            'google-cloud-osconfig',
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()

class OsConfigServiceTransport(abc.ABC):
    """Abstract transport class for OsConfigService."""

    AUTH_SCOPES = (
        'https://www.googleapis.com/auth/cloud-platform',
    )

    def __init__(
            self, *,
            host: str = 'osconfig.googleapis.com',
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
            self.execute_patch_job: gapic_v1.method.wrap_method(
                self.execute_patch_job,
                default_timeout=None,
                client_info=client_info,
            ),
            self.get_patch_job: gapic_v1.method.wrap_method(
                self.get_patch_job,
                default_timeout=None,
                client_info=client_info,
            ),
            self.cancel_patch_job: gapic_v1.method.wrap_method(
                self.cancel_patch_job,
                default_timeout=None,
                client_info=client_info,
            ),
            self.list_patch_jobs: gapic_v1.method.wrap_method(
                self.list_patch_jobs,
                default_timeout=None,
                client_info=client_info,
            ),
            self.list_patch_job_instance_details: gapic_v1.method.wrap_method(
                self.list_patch_job_instance_details,
                default_timeout=None,
                client_info=client_info,
            ),
            self.create_patch_deployment: gapic_v1.method.wrap_method(
                self.create_patch_deployment,
                default_timeout=None,
                client_info=client_info,
            ),
            self.get_patch_deployment: gapic_v1.method.wrap_method(
                self.get_patch_deployment,
                default_timeout=None,
                client_info=client_info,
            ),
            self.list_patch_deployments: gapic_v1.method.wrap_method(
                self.list_patch_deployments,
                default_timeout=None,
                client_info=client_info,
            ),
            self.delete_patch_deployment: gapic_v1.method.wrap_method(
                self.delete_patch_deployment,
                default_timeout=None,
                client_info=client_info,
            ),
            self.create_guest_policy: gapic_v1.method.wrap_method(
                self.create_guest_policy,
                default_timeout=None,
                client_info=client_info,
            ),
            self.get_guest_policy: gapic_v1.method.wrap_method(
                self.get_guest_policy,
                default_timeout=None,
                client_info=client_info,
            ),
            self.list_guest_policies: gapic_v1.method.wrap_method(
                self.list_guest_policies,
                default_timeout=None,
                client_info=client_info,
            ),
            self.update_guest_policy: gapic_v1.method.wrap_method(
                self.update_guest_policy,
                default_timeout=None,
                client_info=client_info,
            ),
            self.delete_guest_policy: gapic_v1.method.wrap_method(
                self.delete_guest_policy,
                default_timeout=None,
                client_info=client_info,
            ),
            self.lookup_effective_guest_policy: gapic_v1.method.wrap_method(
                self.lookup_effective_guest_policy,
                default_timeout=None,
                client_info=client_info,
            ),

        }

    @property
    def execute_patch_job(self) -> typing.Callable[
            [patch_jobs.ExecutePatchJobRequest],
            typing.Union[
                patch_jobs.PatchJob,
                typing.Awaitable[patch_jobs.PatchJob]
            ]]:
        raise NotImplementedError()

    @property
    def get_patch_job(self) -> typing.Callable[
            [patch_jobs.GetPatchJobRequest],
            typing.Union[
                patch_jobs.PatchJob,
                typing.Awaitable[patch_jobs.PatchJob]
            ]]:
        raise NotImplementedError()

    @property
    def cancel_patch_job(self) -> typing.Callable[
            [patch_jobs.CancelPatchJobRequest],
            typing.Union[
                patch_jobs.PatchJob,
                typing.Awaitable[patch_jobs.PatchJob]
            ]]:
        raise NotImplementedError()

    @property
    def list_patch_jobs(self) -> typing.Callable[
            [patch_jobs.ListPatchJobsRequest],
            typing.Union[
                patch_jobs.ListPatchJobsResponse,
                typing.Awaitable[patch_jobs.ListPatchJobsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def list_patch_job_instance_details(self) -> typing.Callable[
            [patch_jobs.ListPatchJobInstanceDetailsRequest],
            typing.Union[
                patch_jobs.ListPatchJobInstanceDetailsResponse,
                typing.Awaitable[patch_jobs.ListPatchJobInstanceDetailsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def create_patch_deployment(self) -> typing.Callable[
            [patch_deployments.CreatePatchDeploymentRequest],
            typing.Union[
                patch_deployments.PatchDeployment,
                typing.Awaitable[patch_deployments.PatchDeployment]
            ]]:
        raise NotImplementedError()

    @property
    def get_patch_deployment(self) -> typing.Callable[
            [patch_deployments.GetPatchDeploymentRequest],
            typing.Union[
                patch_deployments.PatchDeployment,
                typing.Awaitable[patch_deployments.PatchDeployment]
            ]]:
        raise NotImplementedError()

    @property
    def list_patch_deployments(self) -> typing.Callable[
            [patch_deployments.ListPatchDeploymentsRequest],
            typing.Union[
                patch_deployments.ListPatchDeploymentsResponse,
                typing.Awaitable[patch_deployments.ListPatchDeploymentsResponse]
            ]]:
        raise NotImplementedError()

    @property
    def delete_patch_deployment(self) -> typing.Callable[
            [patch_deployments.DeletePatchDeploymentRequest],
            typing.Union[
                empty.Empty,
                typing.Awaitable[empty.Empty]
            ]]:
        raise NotImplementedError()

    @property
    def create_guest_policy(self) -> typing.Callable[
            [guest_policies.CreateGuestPolicyRequest],
            typing.Union[
                guest_policies.GuestPolicy,
                typing.Awaitable[guest_policies.GuestPolicy]
            ]]:
        raise NotImplementedError()

    @property
    def get_guest_policy(self) -> typing.Callable[
            [guest_policies.GetGuestPolicyRequest],
            typing.Union[
                guest_policies.GuestPolicy,
                typing.Awaitable[guest_policies.GuestPolicy]
            ]]:
        raise NotImplementedError()

    @property
    def list_guest_policies(self) -> typing.Callable[
            [guest_policies.ListGuestPoliciesRequest],
            typing.Union[
                guest_policies.ListGuestPoliciesResponse,
                typing.Awaitable[guest_policies.ListGuestPoliciesResponse]
            ]]:
        raise NotImplementedError()

    @property
    def update_guest_policy(self) -> typing.Callable[
            [guest_policies.UpdateGuestPolicyRequest],
            typing.Union[
                guest_policies.GuestPolicy,
                typing.Awaitable[guest_policies.GuestPolicy]
            ]]:
        raise NotImplementedError()

    @property
    def delete_guest_policy(self) -> typing.Callable[
            [guest_policies.DeleteGuestPolicyRequest],
            typing.Union[
                empty.Empty,
                typing.Awaitable[empty.Empty]
            ]]:
        raise NotImplementedError()

    @property
    def lookup_effective_guest_policy(self) -> typing.Callable[
            [guest_policies.LookupEffectiveGuestPolicyRequest],
            typing.Union[
                guest_policies.EffectiveGuestPolicy,
                typing.Awaitable[guest_policies.EffectiveGuestPolicy]
            ]]:
        raise NotImplementedError()


__all__ = (
    'OsConfigServiceTransport',
)
